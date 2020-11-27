Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.InventoryGoodsInTransitSystem

<TestClass()> _
Public Class TestGITTransferIn


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub


    <TestMethod()> _
    Public Sub TestGITIn()
        Dim itm As New InventoryMovementsGitTransfersIn.Data.Item
        With itm
            .Key.GtrReference = "FG0000001"
            .Key.SourceWarehouse = "FG"
            .Key.TargetWarehouse = "N"
            .Key.LineNumber = 1

            .ActionBackToSource = InventoryMovementsGitTransfersIn.Data.ActionBackToSource.I
            .ApplyCostMultiplier = InventoryMovementsGitTransfersIn.Data.ApplyCostMultiplier.N
            .Quantity = 1

        End With

        Dim bo As New InventoryMovementsGitTransfersIn.Data.PostInvGitWhTransferIn
        With bo
            With .Params
                .ApplyIfEntireDocumentValid = InventoryMovementsGitTransfersIn.Params.ApplyIfEntireDocumentValid.Y
                .IgnoreWarnings = InventoryMovementsGitTransfersIn.Params.IgnoreWarnings.N
                .UpdateOriginatingOrder = InventoryMovementsGitTransfersIn.Params.UpdateOriginatingOrder.N
                .UseDefaultWarehouseBin = InventoryMovementsGitTransfersIn.Params.UseDefaultWarehouseBin.Y
                .ValidateOnly = InventoryMovementsGitTransfersIn.Params.ValidateOnly.N
            End With
            .ItemCollection = New List(Of InventoryMovementsGitTransfersIn.Data.Item)
            .ItemCollection.Add(itm)
            .Post(True)
        End With
    End Sub

End Class
