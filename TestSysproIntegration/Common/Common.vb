Namespace Common
    Public Class CommonTestMethods
        Public Shared Sub SetLogonParameters()
            If IsNothing(Codewell.SysproIntegration.LogonDetails.GetInstance) Then
                Codewell.SysproIntegration.LogonDetails.SetLogonDetails("ADMIN", "", "A", "", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.WebServices, "http://codewells1/SysproWebServices/")
            End If
        End Sub

        Public Shared Sub SetWCFLogonParameters()
            If IsNothing(Codewell.SysproIntegration.LogonDetails.GetInstance) Then
                Codewell.SysproIntegration.LogonDetails.SetLogonDetails("ADMIN", "", "0", "", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.WCF)
            End If
        End Sub
    End Class
End Namespace
