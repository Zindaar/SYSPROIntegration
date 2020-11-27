Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsCostChanges

<TestClass()> _
Public Class TestInventoryMovementsCostChanges

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod(), _
     ExpectedException(GetType(Codewell.SysproIntegration.SysproException))> _
    Public Sub PostTestCostChangeExcessiveChange()


        Dim itm1 As New Data.Item
        With itm1
            .LedgerCode = "blah"
            .StockCode = "blahblah"
            .NewTotalCost = 500
        End With

        Dim itm2 As New Data.Item
        With itm2
            .LedgerCode = "blah"
            .StockCode = "blahblah"
            .NewTotalCost = 500
        End With

        Dim obj As New Data.PostInvCostChange
        With obj
            .Params.ApplyIfEntireDocumentValid = Params.ApplyIfEntireDocumentValid.Y
            .Params.IgnoreWarnings = Params.IgnoreWarnings.N
            .Params.ValidateOnly = Params.ValidateOnly.Y

            .ItemCollection.Add(itm1)
            .ItemCollection.Add(itm2)
            .Post(True)
        End With

        'Dim item As New Data.Item
        'With item
        '    .NewUnitCost = 50
        '    .Notation = "SDW Test"
        '    .Reference = "blah"
        '    .StockCode = "B100"
        '    .UpdateLastCost = Data.UpdateLastCost.Y
        '    .Warehouse = "N"
        'End With

        'Dim bo As New Data.PostInvCostChange
        'With bo
        '    .ItemCollection.Add(item)
        '    .Params.ApplyIfEntireDocumentValid = Params.ApplyIfEntireDocumentValid.Y
        '    .Params.IgnoreWarnings = Params.IgnoreWarnings.N
        '    .Params.ValidateOnly = Params.ValidateOnly.Y
        '    .Post()
        'End With

        Assert.IsTrue(True)

    End Sub
End Class
