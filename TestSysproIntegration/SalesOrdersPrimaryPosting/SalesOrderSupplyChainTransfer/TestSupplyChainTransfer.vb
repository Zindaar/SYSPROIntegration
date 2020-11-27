Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting

<TestClass()> _
Public Class TestSupplyChainTransfer


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestCreateSupplyChainTransfer()
        Dim hdr As New SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCTOrdersOrderHeader
        With hdr
            .SourceWarehouse = "N"
            .TargetWarehouse = "E"
        End With

        Dim ln As New SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCTOrdersOrderDetailsStockLine
        With ln
            .OrderQty = 2
            .StockCode = "blah"
        End With

        Dim cln As New SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCTOrdersOrderDetailsCommentLine
        With cln
            .Comment = "Trf of job x to job y"
            .CommentType = SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCTOrdersOrderDetailsCommentLineCommentType.O
        End With

        Dim order As New SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCTOrders
        order.OrderHeader = hdr
        order.OrderDetails.StockLineCollection.Add(ln)
        order.OrderDetails.CommentLineCollection.Add(cln)

        Dim bo As New SalesOrderSupplyChainTransfer.Data.PostSalesOrdersSCT
        With bo
            With .Params
                .AllocationAction = SalesOrderSupplyChainTransfer.Params.PostSalesOrdersSCTParametersAllocationAction.B
                .IgnoreWarnings = SalesOrderSupplyChainTransfer.Params.PostSalesOrdersSCTParametersIgnoreWarnings.N
                .ValidateOnly = SalesOrderSupplyChainTransfer.Params.PostSalesOrdersSCTParametersValidateOnly.Y
            End With
            .OrdersCollection.Add(order)
            .Post(True)
        End With

    End Sub

End Class
