Imports NLog
Imports SYSPROWCFServicesClientLibrary40

Friend Class TransactionObject

    Shared nlogger As Logger = LogManager.GetCurrentClassLogger()

    Friend Shared Function Post(ByVal TransactionObject As ITransaction, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Transaction.Post {0} {1} {2}", TransactionObject.BusinessObject, TransactionObject.xmlData, TransactionObject.xmlParam)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)

        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objTransaction As Object
            Try
                objTransaction = CreateObject("Encore.Transaction")
            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Transaction.  The SYSPRO Encore.dll is not installed or registered.")
            End Try

            Try
                Dim result As String = objTransaction.Post(SessionID, TransactionObject.BusinessObject, TransactionObject.xmlParam, TransactionObject.xmlData)
                nlogger.Debug("Transaction.PostResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try

        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.TransactionPost(SessionID, TransactionObject.BusinessObject, TransactionObject.xmlParam, TransactionObject.xmlData)
            nlogger.Debug("Transaction.PostResult {0}", result)
            Return result
        Else

            Dim objTransaction As New SysproWS_Transaction.transactionclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Transaction")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Transaction Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Transaction.")
                Else
                    objTransaction.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Transaction")
                End If
            Else
                objTransaction.Url = LogonDetails.GetInstance.BaseAddress & "\Transaction.asmx"
            End If

            Try
                Dim result As String = objTransaction.Post(SessionID, TransactionObject.BusinessObject, TransactionObject.xmlParam, TransactionObject.xmlData)
                nlogger.Debug("Transaction.PostResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objTransaction.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objTransaction.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Transaction.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If
    End Function

    Friend Shared Function Build(ByVal BuildObject As IBuild, Optional ByVal blnForceLogon As Boolean = False) As String
        nlogger.Debug("Transaction.Build {0} {1}", BuildObject.BusinessObject, BuildObject.xmlData)

        Dim SessionID As String = Utilities.Logon(blnForceLogon)
        If LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.COMDCOM Then

            Dim objTransaction As Object
            Try
                objTransaction = CreateObject("Encore.Transaction")

            Catch ex As Exception
                Throw New ApplicationException("Error creating Encore.Transaction.  The SYSPRO Encore.dll is not installed or registered.")
            End Try
            Try
                Dim result As String = objTransaction.Build(SessionID, BuildObject.BusinessObject, BuildObject.xmlData)
                nlogger.Debug("Transaction.BuildResult {0}", result)
                Return result
            Finally
                Utilities.Logoff()
            End Try
        ElseIf LogonDetails.GetInstance.CommunicationMethod = LogonDetails.CommunicationMethodEnum.WCF Then
            Dim bindingType As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_Binding")
            Dim baseAddress As String = Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_WCF_BaseAddress")

            Dim oSysproWcf As New SYSPROWCFServicesPrimitiveClient(baseAddress, [Enum].Parse(GetType(SYSPROWCFBinding), bindingType))
            Dim result As String = oSysproWcf.TransactionBuild(SessionID, BuildObject.BusinessObject, BuildObject.xmlData)
            nlogger.Debug("Transaction.BuildResult {0}", result)
            Return result
        Else
            Dim objTransaction As New SysproWS_Transaction.transactionclass
            If String.IsNullOrEmpty(LogonDetails.GetInstance.BaseAddress) Then
                If String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Transaction")) Then
                    Throw New ApplicationException("The configuration file has not defined an address to the Transaction Web Service." & vbCrLf & "This address needs to be defined in an appSetting named Codewell_SysproIntegration_SysproWS_Transaction.")
                Else
                    objTransaction.Url = System.Configuration.ConfigurationManager.AppSettings("Codewell_SysproIntegration_SysproWS_Transaction")
                End If
            Else
                objTransaction.Url = LogonDetails.GetInstance.BaseAddress & "\Transaction.asmx"
            End If

            Try
                Dim result As String = objTransaction.Build(SessionID, BuildObject.BusinessObject, BuildObject.xmlData)
                nlogger.Debug("Transaction.BuildResult {0}", result)
                Return result
            Catch wex As System.Net.WebException
                'The web service was not found
                If wex.Message = "The request failed with HTTP status 404: Not Found." Then
                    Throw New ApplicationException("The Web Service address (" & objTransaction.Url & ") was not found on the server.")
                End If
                If wex.Message = "Unable to connect to the remote server" Then
                    Throw New ApplicationException("The Server for address (" & objTransaction.Url & ") was not found.")
                End If
                Throw New Exception("Web Exception occurred while logging onto Syspro: " & wex.Message)
            Catch sex As System.Web.Services.Protocols.SoapException
                'The web service was found and called
                If sex.Message.Contains("0x80040154") Then
                    Throw New ApplicationException("Error creating Encore.Transaction.  The SYSPRO Encore.dll is not installed or registered on the Web Server")
                End If
                Throw
            Finally
                Utilities.Logoff()
            End Try
        End If

    End Function


End Class
