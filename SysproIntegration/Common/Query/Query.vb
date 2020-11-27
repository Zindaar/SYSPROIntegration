Imports NLog
Imports SYSPROWCFServicesClientLibrary40

Friend Class QueryObject
    Shared nlogger As Logger = LogManager.GetCurrentClassLogger()

    Friend Shared Function Query(ByVal QueryObject As IQuery, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Query.Query {0} {1}", QueryObject.BusinessObject, QueryObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objQuery As Object
            Try
                objQuery = CreateObject("Encore.Query")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objQuery.Query(SessionID, QueryObject.BusinessObject, QueryObject.xmlData)
                nlogger.Debug("Query.QueryResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try

        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.QueryQuery(SessionID, QueryObject.BusinessObject, QueryObject.xmlData)
            nlogger.Debug("Query.QueryResult {0}", result)
            Return result
        Else
            Dim objQuery As New SysproWS_Query.queryclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Query Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Query.")
                Else
                    objQuery.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")
                End If
            Else
                objQuery.Url = LogonDetails.GetInstance.BaseAddress & "\Query.asmx"
            End If
            Try
                Dim result As String = objQuery.Query(SessionID, QueryObject.BusinessObject, QueryObject.xmlData)
                nlogger.Debug("Query.QueryResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objQuery.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objQuery.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function Fetch(ByVal QueryObject As IQuery, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Query.Fetch {0} {1}", QueryObject.BusinessObject, QueryObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objQuery As Object
            Try
                objQuery = CreateObject("Encore.Query")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objQuery.Fetch(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.FetchResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try

        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.QueryFetch(SessionID, QueryObject.xmlData)
            nlogger.Debug("Query.FetchResult {0}", result)
            Return result
        Else
            Dim objQuery As New SysproWS_Query.queryclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Query Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Query.")
                Else
                    objQuery.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")
                End If
            Else
                objQuery.Url = LogonDetails.GetInstance.BaseAddress & "\Query.asmx"
            End If

            Try
                Dim result As String = objQuery.Fetch(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.FetchResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objQuery.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objQuery.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function Browse(ByVal QueryObject As IQuery, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Query.Browse {0} {1}", QueryObject.BusinessObject, QueryObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objQuery As Object
            Try
                objQuery = CreateObject("Encore.Query")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objQuery.Browse(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.BrowseResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.QueryBrowse(SessionID, QueryObject.xmlData)
            nlogger.Debug("Query.BrowseResult {0}", result)
            Return result

        Else
            Dim objQuery As New SysproWS_Query.queryclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Query Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Query.")
                Else
                    objQuery.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")
                End If
            Else
                objQuery.Url = LogonDetails.GetInstance.BaseAddress & "\Query.asmx"
            End If

            Try
                Dim result As String = objQuery.Browse(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.BrowseResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objQuery.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objQuery.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function NextKey(ByVal QueryObject As IQuery, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Query.NextKey {0} {1}", QueryObject.BusinessObject, QueryObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objQuery As Object
            Try
                objQuery = CreateObject("Encore.Query")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objQuery.NextKey(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.NextKeyResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try

        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.NextKey(SessionID, QueryObject.xmlData)
            nlogger.Debug("Query.NextKeyResult {0}", result)
            Return result
        Else
            Dim objQuery As New SysproWS_Query.queryclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Query Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Query.")
                Else
                    objQuery.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")
                End If
            Else
                objQuery.Url = LogonDetails.GetInstance.BaseAddress & "\Query.asmx"
            End If
            Try
                Dim result As String = objQuery.NextKey(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.NextKeyResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objQuery.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objQuery.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

    Friend Shared Function PreviousKey(ByVal QueryObject As IQuery, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Query.PreviousKey {0} {1}", QueryObject.BusinessObject, QueryObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objQuery As Object
            Try
                objQuery = CreateObject("Encore.Query")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objQuery.PreviousKey(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.PreviousKeyResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.PreviousKey(SessionID, QueryObject.xmlData)
            nlogger.Debug("Query.PreviousKeyResult {0}", result)
            Return result

        Else
            Dim objQuery As New SysproWS_Query.queryclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Query Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Query.")
                Else
                    objQuery.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Query")
                End If
            Else
                objQuery.Url = LogonDetails.GetInstance.BaseAddress & "\Query.asmx"
            End If

            Try
                Dim result As String = objQuery.PreviousKey(SessionID, QueryObject.xmlData)
                nlogger.Debug("Query.PreviousKeyResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objQuery.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objQuery.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Query.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function

End Class
