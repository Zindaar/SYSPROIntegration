Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting

<TestClass()> _
Public Class TestGITCreationFromSCT

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestCreateGITFromSCT()

        Dim itm As New GoodsInTransitTransferCreationFromSupplyChainTransfers.Data.PostSalesOrderTransferItem
        itm.SalesOrder = "12345"

        Dim bo As New GoodsInTransitTransferCreationFromSupplyChainTransfers.Data.PostSalesOrderTransfer
        With bo
            With .Params
                .ApplyIfEntireDocumentValid = GoodsInTransitTransferCreationFromSupplyChainTransfers.Params.PostSalesOrderTransferParametersApplyIfEntireDocumentValid.Y
                .IgnoreWarnings = GoodsInTransitTransferCreationFromSupplyChainTransfers.Params.PostSalesOrderTransferParametersIgnoreWarnings.N
                .ValidateAllLines = GoodsInTransitTransferCreationFromSupplyChainTransfers.Params.PostSalesOrderTransferParametersValidateAllLines.Y
                .ValidateOnly = GoodsInTransitTransferCreationFromSupplyChainTransfers.Params.PostSalesOrderTransferParametersValidateOnly.Y
            End With
            .ItemCollection.Add(itm)
            .Post(True)
        End With

    End Sub

End Class
