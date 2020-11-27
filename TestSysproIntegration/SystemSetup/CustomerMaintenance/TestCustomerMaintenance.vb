Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> _
Public Class TestCustomerMaintenance

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub


    <TestMethod()> _
    Public Sub TestAddNewStockCode()

        Dim itm As New Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Data.Item
        With itm
            .Key.Customer = "2"
            .CompanyTaxNumber = "12345"
            .SalesWarehouse = "GH"
        End With

        Dim obj As New Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Data.SetupArCustomer
        With obj
            .ItemCollection.Add(itm)
            .SetupActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Setup.Update
            With .Params
                .ApplyIfEntireDocumentValid = Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Params.ApplyIfEntireDocumentValid.Y
                .IgnoreWarnings = Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Params.IgnoreWarnings.N
                .ValidateOnly = Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Params.ValidateOnly.N
            End With
            .Post(True)
        End With

        Assert.IsTrue(True)

        Dim custItem As New Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Data.Item
        With custItem
            .CustomerClass = "AC"
            .Key.Customer = "AB"
        End With

        Dim custBO As New Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Data.SetupArCustomer
        With custBO
            .Params.ValidateOnly = Codewell.SysproIntegration.SystemSetup.AccountsReceivableCustomerMaintenance.Params.ValidateOnly.Y
            .SetupActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Setup.Add
            .ItemCollection.Add(custItem)
            .Post(True)
        End With

    End Sub

End Class
