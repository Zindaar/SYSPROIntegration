Imports NLog
Imports SYSPROWCFServicesClientLibrary40

Public Class Utilities

    Private Shared externallyAssignedSessionID As String
    Shared syncLockLogOnOffObject As New Object
    Private Shared mSessionIDs As New Dictionary(Of User_GUID, Int16)(New User_GUIDComparer)
    Shared nlogger As Logger = LogManager.GetCurrentClassLogger()

    ''' <summary>
    ''' Does a logon to SYSPRO as the logged-in operator
    ''' </summary>
    ''' <param name="blnForceLogon"></param>
    ''' <returns>The SYSPRO-Assigned Logon GUID</returns>
    ''' <remarks>The logon GUID is stored in a local variable and is used in all other posts</remarks>
    Public Shared Function Logon(ByVal blnForceLogon As Boolean) As String


        SyncLock syncLockLogOnOffObject

            If Not String.IsNullOrEmpty(externallyAssignedSessionID) Then
                Return externallyAssignedSessionID
            End If

            Dim sessionKey As User_GUID = GetExistingSessionKey(blnForceLogon)
            Dim sessionID As String = sessionKey.GUID

            If Not blnForceLogon Then
                'not forcing a new logon
                If Not String.IsNullOrEmpty(sessionID) Then
                    Dim existingReferences As Int16 = mSessionIDs(sessionKey)
                    nlogger.Trace("Utilities.Logon(Thread " & Threading.Thread.CurrentThread.ManagedThreadId & "): Returning existing sessionID " & sessionID & " and incrementing refCount from " & existingReferences)
                    mSessionIDs(sessionKey) = existingReferences + 1
                    Return (sessionID)
                End If
            End If

            'If we get here a new logon needs to be done

#If DEBUG Then
            ' NB this is just to mimic a slow connection for multi-threaded testing!
            'System.Threading.Thread.Sleep(1000)

            Dim sw As Stopwatch = Stopwatch.StartNew()

#End If

            'If we get here there has not yet been a logon for this user/company or blnForceLogon is true
            'If we have a session id lets log it off
            If Not String.IsNullOrEmpty(sessionID) Then
#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.Logon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Logging off existing sessionID " & sessionID)
#End If
                Logoff(sessionKey)

#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.Logon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Logged off existing sessionID " & sessionID)
#End If
            End If

            nlogger.Trace("Utilities.Logon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): Logging on to Syspro...")

            If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
                sessionID = DoWcfLogon()
            ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
                sessionID = DoCOMDCOMLogon()
            Else
                sessionID = DoWebServicesLogon()
            End If

            sessionKey.GUID = sessionID
            mSessionIDs.Add(sessionKey, 1)
#If DEBUG Then
            sw.Stop()
            nlogger.Trace(vbTab & "Utilities.Logon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " returning sessionID " & sessionID)
#End If

            Return sessionID

        End SyncLock

    End Function

    Private Shared Function GetExistingSessionKey(ByRef forceLogon As Boolean) As User_GUID
        Dim ldInstance As LogonDetails = LogonDetails.GetInstance()
        If ldInstance Is Nothing Then
            Throw New ApplicationException("Cannot logon if no LogonDetails have been specified.  Please call SetLogonDetails first.")
        End If

        Dim candidateKey As New User_GUID With {
            .Company = ldInstance.Company,
            .UserName = ldInstance.SysproOperator
        }

        Dim matchingKey As User_GUID
        Dim otherCompanyKey As User_GUID
        If mSessionIDs.ContainsKey(candidateKey) Then
            matchingKey =
                mSessionIDs.Keys.Where(Function(k) k.UserName = candidateKey.UserName AndAlso k.Company = candidateKey.Company).SingleOrDefault

            If matchingKey Is Nothing Then
                'User is not already logged in to this company; he may be logged in to another company though
                otherCompanyKey =
                    mSessionIDs.Keys.Where(Function(k) k.UserName = candidateKey.UserName).SingleOrDefault
                If otherCompanyKey Is Nothing Then
                    'User is not logged in at all.
                    Return candidateKey
                Else
                    'User is logged in to another company
                    forceLogon = True
                    Return otherCompanyKey
                End If
            Else
                'user is already logged on to this company
                Return matchingKey
            End If
        End If
        Return candidateKey
    End Function

    ''' <summary>
    ''' Does a test logon to SYSPRO using the given credentials
    ''' </summary>
    ''' <returns>The SYSPRO-Assigned Logon GUID</returns>
    ''' <remarks></remarks>
    Public Shared Function TestLogon(ByVal strSysproOperator As String, ByVal strSysproOperatorPassword As String, ByVal strCompany As String, ByVal strCompanyPassword As String) As String
        If LogonDetails.GetInstance Is Nothing Then
            LogonDetails.SetLogonDetails("", "", "", "", LogonDetails.CommunicationMethodEnum.WebServices)
        End If
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
            'Use DCOM
            Dim objUtilities As Object
            Try
                objUtilities = CreateObject("Encore.Utilities")
            Catch ex As Exception
                Throw New ApplicationException("The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Return objUtilities.Logon(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, 5, 0, 0, "")
            Catch ex As Exception
                Throw New Exception("Error logging onto Syspro for User " & strSysproOperator & ": " & ex.Message)
            Finally
                objUtilities = Nothing
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Return oSysproWcf.Logon(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, 5, 0, 0, "")
        Else
            'Use Web Services
            Dim objUtilities As New SysproWS_Utilities.utilitiesclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
                Else
                    objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
                End If
            Else
                objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
            End If

            Try
                Return objUtilities.Logon(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, 5, 0, 0, "")
            Catch ex As Exception
                Throw New Exception("Error logging onto Syspro for User " & strSysproOperator & ": " & ex.Message)
            Finally
                objUtilities = Nothing
            End Try

        End If

    End Function

    Public Shared Function TestLogon(ByVal strSysproOperator As String, ByVal strSysproOperatorPassword As String, ByVal strCompany As String, ByVal strCompanyPassword As String, WebServicesBaseAddress As String) As String

        'Use Web Services
        Dim objUtilities As New SysproWS_Utilities.utilitiesclass
        objUtilities.Url = WebServicesBaseAddress & "\Utilities.asmx"

        Try
            Return objUtilities.Logon(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, 5, 0, 0, "")
        Catch ex As Exception
            Throw New Exception("Error logging onto Syspro for User " & strSysproOperator & ": " & ex.Message)
        Finally
            objUtilities = Nothing
        End Try

    End Function


    ''' <summary>
    ''' Use this method to define an already valid SYSPRO e.Net Logon Session ID
    ''' </summary>
    ''' <param name="strGivenGUID"></param>
    ''' <remarks></remarks>
    Friend Shared Sub SetExistingSessionID(ByVal strGivenGUID As String)
        externallyAssignedSessionID = strGivenGUID
    End Sub

    ''' <summary>
    ''' Returns the _sessionID
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SessionID() As String
        Get
            Return externallyAssignedSessionID
        End Get
    End Property


    ''' <summary>
    ''' Logs off the GUID stored in _sessionID
    ''' </summary>
    ''' <remarks>Will never throw an exception</remarks>
    Public Shared Sub Logoff(Optional ByVal allSessionsForUser = False)
        SyncLock syncLockLogOnOffObject

            Dim sessionKey As User_GUID = GetExistingSessionKey(False)

            If Not mSessionIDs.ContainsKey(sessionKey) Then
                nlogger.Trace("Utilities.Logoff(" & Threading.Thread.CurrentThread.ManagedThreadId & "): No session key found for user")
                Exit Sub
            End If

            If Not allSessionsForUser Then
                'we just reduce the ref count for the existing user
                Dim existingReferences As Int16 = mSessionIDs.Item(sessionKey)
                If existingReferences > 1 Then
                    nlogger.Trace("Utilities.Logoff(" & Threading.Thread.CurrentThread.ManagedThreadId & "): reducing refCount from " & existingReferences & "on sessionID " & sessionKey.GUID)
                    mSessionIDs.Item(sessionKey) = existingReferences - 1
                    Exit Sub
                End If
            End If

            nlogger.Trace("Utilities.Logoff(" & Threading.Thread.CurrentThread.ManagedThreadId & "): logging off sessionID " & sessionKey.GUID)

            If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
                'Use DCOM
                Dim objUtilities As Object = CreateObject("Encore.Utilities")
                Try
                    objUtilities.Logoff(sessionKey.GUID)
                    nlogger.Trace("COMDCOM Logged off GUID " & sessionKey.GUID & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                Catch ex As Exception
                    'Do Nothing
                Finally
                    objUtilities = Nothing
                End Try

            ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
                Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
                Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

                Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
                Try
                    Dim result As String = oSysproWcf.Logoff(sessionKey.GUID)
                Catch ex As Exception
                    'gulp
                End Try
            Else
                'Use Web Services
                Dim objUtilities As New SysproWS_Utilities.utilitiesclass
                If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                    If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                        Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
                    Else
                        objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
                    End If
                Else
                    objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
                End If

                Try
                    objUtilities.Logoff(sessionKey.GUID)
                    nlogger.Trace("WebServices Logged off GUID " & sessionKey.GUID & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                Catch ex As Exception
                    'Do Nothing
                Finally
                    objUtilities = Nothing
                End Try
            End If

            nlogger.Trace("Utilities.Logoff(" & Threading.Thread.CurrentThread.ManagedThreadId & "): removing sessionKey " & sessionKey.UserName & ":" & sessionKey.Company)
            mSessionIDs.Remove(sessionKey)

        End SyncLock
    End Sub

    ''' <summary>
    ''' Logs off the given strGUIDtoLogoff
    ''' </summary>
    ''' <remarks>Will never throw an exception</remarks>
    Private Shared Sub Logoff(ByVal GUIDtoLogoff As User_GUID)
        If GUIDtoLogoff Is Nothing Then Exit Sub

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
            'Use DCOM
            Try
                Dim objUtilities As Object = CreateObject("Encore.Utilities")
                objUtilities.Logoff(GUIDtoLogoff.GUID)
            Catch ex As Exception
                'Don't worry about an error logging off
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.Logoff(GUIDtoLogoff.GUID)
        Else
            'Use Web Services
            Try
                Using objUtilities As New SysproWS_Utilities.utilitiesclass
                    If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                        If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                            Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
                        Else
                            objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
                        End If
                    Else
                        objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
                    End If

                    objUtilities.Logoff(GUIDtoLogoff.GUID)
                End Using
            Catch ex As Exception
                'Don't worry about an error logging off
            End Try
        End If

        mSessionIDs.Remove(GUIDtoLogoff)

    End Sub


    ''' <summary>
    ''' Gets the SYSPRO logon profile of the GUID stored in _session
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetLogonProfile() As String
        'If String.IsNullOrEmpty(_sessionID) Then
        '    Throw New ApplicationException("Please log on to SYSPRO first.")
        'End If
        'If LogonDetails.GetInstance Is Nothing Then
        '    Throw New ApplicationException("The LogonDetails have not yet been set")
        'End If

#If DEBUG Then
        Dim swGLP As Stopwatch = Stopwatch.StartNew()
#End If


        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
            'Use DCOM
#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Using COMDCOM")
#End If
            Try

#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Creating Object Encore.Utilities...")
#End If

                Dim objUtilities As Object = CreateObject("Encore.Utilities")

#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Created Object Encore.Utilities")
#End If

                Return objUtilities.GetLogonProfile(Utilities.Logon(False))
            Finally
                Utilities.Logoff()
#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " COMDCOM All Done")
#End If
            End Try


        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.GetLogonProfile(Utilities.Logon(False))
            nlogger.Debug("GetLogonProfileResult {0}", result)
            Return result
        Else
            'Use Web Services
#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Using WebServices")
#End If

            Try

#If DEBUG Then
                nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Instantiating UtilitiesClass...")
#End If
                Using objUtilities As New SysproWS_Utilities.utilitiesclass

#If DEBUG Then
                    nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & " Instantiated UtilitiesClass")
#End If
                    If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                        If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                            Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
                        Else
                            objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
                        End If
                    Else
                        objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
                    End If

                    Return objUtilities.GetLogonProfile(Utilities.Logon(False))
                End Using

            Finally
                Logoff()

#If DEBUG Then
                swGLP.Stop()
                nlogger.Trace(vbTab & "Utilities.GetLogonProfile(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & swGLP.ElapsedMilliseconds & "All Done")
#End If
            End Try
        End If
    End Function

    ''' <summary>
    ''' Gets the SYSPRO logon profile of the given strGUID
    ''' </summary>
    ''' <param name="strGUID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetLogonProfile(ByVal strGUID As String) As String

        If String.IsNullOrEmpty(strGUID) Then
            Throw New ArgumentNullException("strGUID")
        End If
        If LogonDetails.GetInstance Is Nothing Then
            Throw New ApplicationException("The LogonDetails have not yet been set")
        End If

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then
            'Use DCOM
            Try
                Dim objUtilities As Object = CreateObject("Encore.Utilities")
                Return objUtilities.GetLogonProfile(strGUID)
            Catch ex As Exception
                'Don't worry about an error logging off
                Return ""
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Return oSysproWcf.GetLogonProfile(strGUID)
        Else
            'Use Web Services
            Using objUtilities As New SysproWS_Utilities.utilitiesclass
                If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                    If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                        Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
                    Else
                        objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
                    End If
                Else
                    objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
                End If
                Return objUtilities.GetLogonProfile(strGUID)
            End Using
        End If
    End Function


    Private Shared Function DoCOMDCOMLogon() As String
#If DEBUG Then
        Dim sw As Stopwatch = Stopwatch.StartNew()
        nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Using COMDCOM")
#End If
        Dim _sessionID As String

        'Use COM/DCOM
        Dim objUtilities As Object
        Try
#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Creating Object Encore.Uilities...")
#End If

            objUtilities = CreateObject("Encore.Utilities")

#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Created Object Encore.Uilities")
#End If

        Catch ex As Exception
            Throw New ApplicationException("Error creating Encore.Utilities.  The SYSPRO Encore.dll is not installed or registered.", ex)
        End Try

        Try
#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Calling Encore.Utilities.Logon...")
#End If
            nlogger.Trace(String.Format("Logging on user {0} using COMDCOM...", LogonDetails.GetInstance.SysproOperator.TrimEnd()))

            _sessionID = objUtilities.Logon(LogonDetails.GetInstance.SysproOperator.TrimEnd(), LogonDetails.GetInstance.SysproOperatorPassword, LogonDetails.GetInstance.Company, LogonDetails.GetInstance.CompanyPassword, LogonDetails.GetInstance.LanguageCode, LogonDetails.GetInstance.LogDetail, LogonDetails.GetInstance.SYSPROInstance, LogonDetails.GetInstance.XMLIn)

#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Called Encore.Utilities.Logon")
#End If

        Catch comex As System.Runtime.InteropServices.COMException
            If comex.Message.Contains("Unable to open and read operator file (ADMOPR.DAT)") Then
                Throw New ApplicationException("Unable to open and read operator file (ADMOPR.DAT)." & vbCrLf & "Please grant security access to the SYSPRO folder to the current user.")
            End If
            Throw New Exception("COM Exception logging onto Syspro for User " & LogonDetails.GetInstance.SysproOperator.TrimEnd() & ": " & comex.Message)
        Catch ex As Exception
            Throw New Exception("DCOM Error logging onto Syspro for User " & LogonDetails.GetInstance.SysproOperator.TrimEnd() & ": " & ex.Message)
        Finally
            objUtilities = Nothing
        End Try


#If DEBUG Then
        sw.Stop()
        nlogger.Trace(vbTab & "Utilities.DoCOMDCOMLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " COMDCOM Ready To Return")
#End If
        Return _sessionID

    End Function

    Private Shared Function DoWebServicesLogon() As String
        'Use Web Services
#If DEBUG Then
        Dim sw As Stopwatch = Stopwatch.StartNew()
        nlogger.Trace(vbTab & "Utilities.DoWebServicesLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Using WebServices; Instantiating UtilitiesClass...")
#End If

        Dim objUtilities As New SysproWS_Utilities.utilitiesclass

#If DEBUG Then
        nlogger.Trace(vbTab & "Utilities.DoWebServicesLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Instantiated UtilitiesClass...")
#End If

        If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
            If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")) Then
                Throw New ApplicationException("The configuration file has not defined an address to the Utilities Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Utilities.")
            Else
                objUtilities.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Utilities")
            End If
        Else
            objUtilities.Url = LogonDetails.GetInstance.BaseAddress & "\Utilities.asmx"
        End If

        Dim _sessionID As String
        Try
#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoWebServicesLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Calling UtilitiesClass.Logon...")
#End If

            nlogger.Trace(String.Format("Logging on user {0} using WebServices...", LogonDetails.GetInstance.SysproOperator.TrimEnd()))

            _sessionID = objUtilities.Logon(LogonDetails.GetInstance.SysproOperator.TrimEnd(), LogonDetails.GetInstance.SysproOperatorPassword, LogonDetails.GetInstance.Company, LogonDetails.GetInstance.CompanyPassword, LogonDetails.GetInstance.LanguageCode, LogonDetails.GetInstance.LogDetail, LogonDetails.GetInstance.SYSPROInstance, LogonDetails.GetInstance.XMLIn)

#If DEBUG Then
            nlogger.Trace(vbTab & "Utilities.DoWebServicesLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " Called UtilitiesClass.Logon")
#End If

        Catch wex As System.Net.WebException
            'The web service was not found
            If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                Throw New ApplicationException("The Web Service address (" & objUtilities.Url & ") was not found on the server.")
            End If
            If wex.Message = "Unable to connect to the remote server" Then
                Throw New ApplicationException("The Server for address (" & objUtilities.Url & ") was not found.")
            End If
            Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
        Catch sex As System.Web.Services.Protocols.SoapException
            'The web service was found and called
            If sex.Message.Contains("0x80040154") Then
                Throw New ApplicationException("The SYSPRO Encore.dll is not installed or registered on the Web Server")
            End If
            If sex.Message.Contains("Unable to open and read operator file (ADMOPR.DAT)") Then
                Throw New ApplicationException("Unable to open and read operator file (ADMOPR.DAT)." & vbCrLf & "Please grant security access to the SYSPRO folder to the user in whose context IIS is running")
            End If
            Throw New Exception("Server Error logging onto Syspro for User " & LogonDetails.GetInstance.SysproOperator.TrimEnd() & ": " & sex.Message)
        Catch ex As Exception
            Throw New Exception("Error logging onto Syspro for User " & LogonDetails.GetInstance.SysproOperator.TrimEnd() & ": " & ex.Message)
        Finally
            objUtilities = Nothing
        End Try
#If DEBUG Then
        sw.Stop()
        nlogger.Trace(vbTab & "Utilities.DoWebServicesLogon(" & Threading.Thread.CurrentThread.ManagedThreadId & "): " & sw.ElapsedMilliseconds & " WebServices Ready To Return")
#End If
        Return _sessionID
    End Function

    Private Shared Function DoWcfLogon() As String
        Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
        If String.IsNullOrEmpty(bindingType) Then
            Throw New ApplicationException("Please specify the WCF Binding type in a app setting called 'Codewell_SysproIntegration_WCF_Binding'")
        End If
        Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")
        If String.IsNullOrEmpty(baseAddress) Then
            Throw New ApplicationException("Please specify the WCF base address in a app setting called 'Codewell_SysproIntegration_WCF_BaseAddress'")
        End If
        Dim binding As SYSPROWCFBinding
        If Not [Enum].TryParse(Of SYSPROWCFBinding)(bindingType, binding) Then
            Throw New ApplicationException("WCF Binding must be one of these: RESTHttp, NetNamedPipe, NetTcp, BasicHttp, WSHttp")
        End If

        nlogger.Trace("Logging on user {0} using WCF...", LogonDetails.GetInstance.SysproOperator.TrimEnd())

        Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, binding)
        Return oSysproWcf.Logon(LogonDetails.GetInstance.SysproOperator.TrimEnd(),
                                     LogonDetails.GetInstance.SysproOperatorPassword,
                                     LogonDetails.GetInstance.Company,
                                     LogonDetails.GetInstance.CompanyPassword,
                                     LogonDetails.GetInstance.LanguageCode,
                                     LogonDetails.GetInstance.LogDetail,
                                     LogonDetails.GetInstance.SYSPROInstance,
                                     LogonDetails.GetInstance.XMLIn)

    End Function

End Class

Public Class User_GUID
    Public UserName As String
    Public Company As String
    Public GUID As String

    'Public Overrides Function Equals(obj As Object) As Boolean
    '    If Not TypeOf (obj) Is User_GUID Then
    '        Return False
    '    End If

    '    Dim nObj As User_GUID = DirectCast(obj, User_GUID)

    '    Return UserName = nObj.UserName AndAlso Company = nObj.Company

    'End Function
End Class


Public Class User_GUIDComparer
    Implements IEqualityComparer(Of User_GUID)

    Public Shadows Function Equals(x As User_GUID, y As User_GUID) As Boolean Implements System.Collections.Generic.IEqualityComparer(Of User_GUID).Equals
        Return x.UserName = y.UserName AndAlso x.Company = y.Company
    End Function

    Public Shadows Function GetHashCode(obj As User_GUID) As Integer Implements System.Collections.Generic.IEqualityComparer(Of User_GUID).GetHashCode
        Return String.Concat(obj.UserName, obj.Company).GetHashCode
    End Function
End Class
