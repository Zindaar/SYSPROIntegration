Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting

<TestClass()> _
Public Class TestChangeSOStatus

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestReleaseFromSuspense()
        Dim releaseItem As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Data.Item
        With releaseItem
            .SalesOrder = "513942"
            .OrderStatus = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Data.OrderStatus.S
            .NewOrderStatus = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Data.NewOrderStatus.Item3
            .CreditAuthority = "AUT"
        End With

        Dim releaseBO As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Data.PostSorOrderStatus
        With releaseBO
            With .Params
                .AllowInvoiceInformationEntry = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.AllowInvoiceInformationEntry.N
                .ApplyIfEntireDocumentValid = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.ParametersApplyIfEntireDocumentValid.Y
                .IgnoreWarnings = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.IgnoreWarnings.Y
                .InBoxMsgReqd = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.InBoxMsgReqd.N
                .ValidateOnly = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.ValidateOnly.N
                .WarnIfCustomerOnHold = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params.WarnIfCustomerOnHold.N
            End With
            .Item = releaseItem
            .Post(False)
            'An error here probably means that SYSPRO will not allow this order to go into a status of 1...so try the posting again putting it in a status of 2 instead of 1
        End With

        Assert.IsTrue(True)
    End Sub

End Class
