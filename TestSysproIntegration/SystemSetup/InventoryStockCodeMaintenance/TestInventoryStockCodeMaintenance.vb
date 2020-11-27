Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SystemSetup.InventoryStockCodeMaintenance

<TestClass()> _
Public Class TestInventoryStockCodeMaintenance

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub


    <TestMethod()> _
    Public Sub TestAddNewStockCode()

        Dim itm As New Data.Item
        With itm
            .Key.StockCode = "SDW Test"
            .AbcAnalysisReq = Data.AbcAnalysisReq.Y
            .AbcCostingReq = Data.AbcCostingReq.Y
            .Basis = Data.Basis.Item
            .Description = "Shawn's test item"
        End With

        Dim obj As New Data.SetupInvMaster
        With obj
            .ItemCollection.Add(itm)
            .SetupActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Setup.Update
            With .Params
                .ApplyIfEntireDocumentValid = Params.ApplyIfEntireDocumentValid.Y
                .IgnoreWarnings = Params.IgnoreWarnings.N
                .ValidateOnly = Params.ValidateOnly.Y
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
