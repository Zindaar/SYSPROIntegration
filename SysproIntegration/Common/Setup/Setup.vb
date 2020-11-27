Imports NLog
Imports SYSPROWCFServicesClientLibrary40

Friend Class SetupObject
    Shared nlogger As Logger = LogManager.GetCurrentClassLogger()

    Friend Shared Function Add(ByVal SetupObject As ISetup, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Setup.Add {0} {1} {2}", SetupObject.BusinessObject, SetupObject.xmlData, SetupObject.xmlParam)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objSetup As Object
            Try
                objSetup = CreateObject("Encore.Setup")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objSetup.Add(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.AddResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.SetupAdd(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
            nlogger.Debug("Setup.AddResult {0}", result)
            Return result
        Else
            Dim objSetup As New SysproWS_Setup.setupclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Setup Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Setup.")
                Else
                    objSetup.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")
                End If
            Else
                objSetup.Url = LogonDetails.GetInstance.BaseAddress & "\Setup.asmx"
            End If
            Try
                Dim result As String = objSetup.Add(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.AddResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objSetup.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objSetup.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function Update(ByVal SetupObject As ISetup, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Setup.Update {0} {1} {2}", SetupObject.BusinessObject, SetupObject.xmlData, SetupObject.xmlParam)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objSetup As Object
            Try
                objSetup = CreateObject("Encore.Setup")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objSetup.Update(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.UpdateResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.SetupUpdate(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
            nlogger.Debug("Setup.UpdateResult {0}", result)
            Return result
        Else
            Dim objSetup As New SysproWS_Setup.setupclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Setup Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Setup.")
                Else
                    objSetup.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")
                End If
            Else
                objSetup.Url = LogonDetails.GetInstance.BaseAddress & "\Setup.asmx"
            End If

            Try
                Dim result As String = objSetup.Update(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.UpdateResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objSetup.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objSetup.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function Delete(ByVal SetupObject As ISetup, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Setup.Delete {0} {1} {2}", SetupObject.BusinessObject, SetupObject.xmlData, SetupObject.xmlParam)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objSetup As Object
            Try
                objSetup = CreateObject("Encore.Setup")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objSetup.Delete(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.DeleteResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try

        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.SetupDelete(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
            nlogger.Debug("Setup.DeleteResult {0}", result)
            Return result
        Else
            Dim objSetup As New SysproWS_Setup.setupclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Setup Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Setup.")
                Else
                    objSetup.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Setup")
                End If
            Else
                objSetup.Url = LogonDetails.GetInstance.BaseAddress & "\Setup.asmx"
            End If

            Try
                Dim result As String = objSetup.Delete(SessionID, SetupObject.BusinessObject, SetupObject.xmlParam, SetupObject.xmlData)
                nlogger.Debug("Setup.DeleteResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objSetup.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objSetup.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Setup.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

End Class
