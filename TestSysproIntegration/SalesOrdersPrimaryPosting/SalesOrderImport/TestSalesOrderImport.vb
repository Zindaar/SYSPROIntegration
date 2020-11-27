Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport
Imports sorData = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data
Imports sorParams = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params

<TestClass()> _
Public Class TestSalesOrderImport


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestPostSalesOrder()

        Dim thdr As New Data.TransmissionHeader
        With thdr
            '.ReceiverCode = "EDIR"
            '.SenderCode = "EDIS"
            .TransmissionReference = "SDW"
        End With

        Dim hdr As New Data.OrderHeader
        With hdr
            .Customer = "2"
            .OrderActionType = Data.OrderActionType.A
            .CustomerPoNumber = "SDW Test 2"
            .OrderType = "SO"
        End With

        Dim sLine As New Data.StockLine
        With sLine
            .StockCode = "B100"
            .CustomerPoLine = 3
            .OrderQty = 2
            .OrderUom = "EA"
            .Warehouse = "N"
        End With

        Dim cLine As New Data.CommentLine
        With cLine
            .Comment = "This is a comment"
            .CommentType = Data.CommentType.I
            .CustomerPoLine = 1
        End With

        Dim mLine As New Data.MiscChargeLine
        With mLine
            .CustomerPoLine = 2
            .MiscChargeCost = 100
            .MiscChargeValue = 150
            .MiscProductClass = "BA"
            .MiscDescription = "Misc Description here"
        End With

        Dim sLine2 As New Data.StockLine
        With sLine2
            .StockCode = "B111"
            .CustomerPoLine = 4
            .OrderUom = "EA"
            .OrderQty = 3
            .Warehouse = "SA"
        End With


        Dim so As New Data.Orders
        so.OrderHeader = hdr
        so.OrderDetails = New Data.OrderDetails

        so.OrderDetails.CommentLineCollection.Add(cLine)
        so.OrderDetails.MiscChargeLineCollection.Add(mLine)
        so.OrderDetails.StockLineCollection.Add(sLine)
        so.OrderDetails.StockLineCollection.Add(sLine2)

        Dim sos As New Data.SalesOrders
        sos.TransmissionHeader = thdr
        sos.OrdersCollection = New List(Of Data.Orders)
        sos.OrdersCollection.Add(so)
        With sos.Params
            .Process = Params.Process.VALIDATE
        End With

        sos.Post(True)

        Assert.IsTrue(sos.XmlOut.Contains("Error") = False, sos.XmlOut)
    End Sub

    '<TestMethod()> _
    'Public Sub TestCreateSORTOIOUTFromPostSalesOrder()

    '    Dim thdr As New Data.TransmissionHeader
    '    With thdr
    '        '.ReceiverCode = "EDIR"
    '        '.SenderCode = "EDIS"
    '        .TransmissionReference = "SDW"
    '    End With

    '    Dim hdr As New Data.OrderHeader
    '    With hdr
    '        .Customer = "z"
    '        .OrderActionType = Data.OrderActionType.A
    '        .CustomerPoNumber = "SDW Test 2"
    '        .OrderType = "SO"
    '    End With

    '    Dim sLine As New Data.StockLine
    '    With sLine
    '        .StockCode = "B100"
    '        .CustomerPoLine = 3
    '        .OrderQty = 2
    '        .OrderUom = "EA"
    '        .Warehouse = "N"
    '    End With

    '    Dim cLine As New Data.CommentLine
    '    With cLine
    '        .Comment = "This is a comment"
    '        .CommentType = Data.CommentType.I
    '        .CustomerPoLine = 1
    '    End With

    '    Dim mLine As New Data.MiscChargeLine
    '    With mLine
    '        .CustomerPoLine = 2
    '        .MiscChargeCost = 100
    '        .MiscChargeValue = 150
    '        .MiscProductClass = "BA"
    '        .MiscDescription = "Misc Description here"
    '    End With

    '    Dim sLine2 As New Data.StockLine
    '    With sLine2
    '        .StockCode = "B111"
    '        .CustomerPoLine = 4
    '        .OrderUom = "EA"
    '        .OrderQty = 3
    '        .Warehouse = "SA"
    '    End With


    '    Dim so As New Data.Orders
    '    so.OrderHeader = hdr
    '    so.OrderDetails = New Data.OrderDetails

    '    so.OrderDetails.CommentLineCollection.Add(cLine)
    '    so.OrderDetails.MiscChargeLineCollection.Add(mLine)
    '    so.OrderDetails.StockLineCollection.Add(sLine)
    '    so.OrderDetails.StockLineCollection.Add(sLine2)

    '    Dim sos As New Data.SalesOrders
    '    sos.TransmissionHeader = thdr
    '    sos.OrdersCollection = New List(Of Data.Orders)
    '    sos.OrdersCollection.Add(so)
    '    With sos.Params
    '        .Process = Params.Process.VALIDATE
    '    End With
    '    Try
    '        sos.Post()
    '    Catch ex As Exception
    '        'At this point we don't care about an exception...(it should be part of the XmlOut )
    '    End Try

    '    Dim sortoiout As Output.NewDataSet = Output.NewDataSet.NewFromXML(sos.XmlOut)
    '    Assert.IsTrue(True)
    '    'Assert.IsTrue(sos.XmlOut.Contains("Error") = False, sos.XmlOut)
    'End Sub

    <TestMethod()> _
    Public Sub SalesOrderLineChange()

        For i As Integer = 1 To 1 ' Each objSorDetail As BLL.SorDetail In oChangedOrderLines
            Dim objSalesOrders As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.SalesOrders
            With objSalesOrders.Params
                .AcceptEarlierShipDate = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AcceptEarlierShipDate.Y
                .AcceptOrdersIfNoCredit = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AcceptOrdersIfNoCredit.N
                .AddAttachedServiceCharges = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AddAttachedServiceCharges.N
                .AllocationAction = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AllocationAction.A
                .AllowChangeToZeroPrice = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AllowChangeToZeroPrice.N
                .AllowNonStockItems = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AllowNonStockItems.N
                .AlwaysUsePriceEntered = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AlwaysUsePriceEntered.Y
                .AllowZeroPrice = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.AllowZeroPrice.Y
                .CheckForCustomerPoNumbers = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.CheckForCustomerPoNumbers.C
                .IgnoreWarnings = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.IgnoreWarnings.Y
                .Process = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Params.Process.IMPORT
            End With

            Dim objOrders As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.Orders
            Dim objOrderHeader As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.OrderHeader
            objOrders.OrderHeader = objOrderHeader

            With objOrders.OrderHeader
                .OrderActionType = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.OrderActionType.C
                .SalesOrder = "331233"
                '.Customer = objSorDetail.MySorMaster.Customer
                '.CustomerName = objSorDetail.MySorMaster.CustomerName
                '.CustomerPoNumber = objSorDetail.MySorMaster.CustomerPoNumber
                '.Email = objSorDetail.MySorMaster.Email
                '.MultiShipCode = objSorDetail.MySorMaster.MultiShipCode
                '.OrderDate = objSorDetail.MySorMaster.OrderDate
                '.OrderDiscPercent1 = objSorDetail.MySorMaster.DiscPct1
                '.OrderDiscPercent2 = objSorDetail.MySorMaster.DiscPct2
                '.OrderDiscPercent3 = objSorDetail.MySorMaster.DiscPct3
                '.RequestedShipDate = objSorDetail.MySorMaster.ReqShipDate
                '.Salesperson = objSorDetail.MySorMaster.Salesperson
                '.ShipAddress1 = objSorDetail.MySorMaster.ShipAddress1
                '.ShipAddress2 = objSorDetail.MySorMaster.ShipAddress2
                '.ShipAddress3 = objSorDetail.MySorMaster.ShipAddress3
                '.ShipAddress4 = objSorDetail.MySorMaster.ShipAddress4
                '.ShipAddress5 = objSorDetail.MySorMaster.ShipAddress5
                '.ShipPostalCode = objSorDetail.MySorMaster.ShipPostalCode
                '.SpecialInstrs = objSorDetail.MySorMaster.SpecialInstrs
            End With

            Dim objStockLine As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.StockLine
            With objStockLine
                .LineActionType = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.LineActionType.C
                .CustomerPoLine = i
                '.LineDiscPercent1 = objSorDetail.MDiscPct1
                '.LineDiscPercent2 = objSorDetail.MDiscPct2
                '.LineDiscPercent3 = objSorDetail.MDiscPct3
                '.LineDiscValFlag = Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.LineDiscValFlag.V
                '.LineDiscValue = objSorDetail.MDiscValue
                .LineShipDate = Today 'objSorDetail.MLineShipDate
                '.OrderQty = objSorDetail.MOrderQty
                '.Price = objSorDetail.MPrice
                '.PriceCode = objSorDetail.MPriceCode
                '.PriceUom = objSorDetail.MPriceUom
                '.ProductClass = objSorDetail.MProductClass
                '.StockCode = objSorDetail.MStockCode
                '.StockDescription = objSorDetail.MStockDes
                '.StockTaxCode = objSorDetail.MTaxCode
                '.Warehouse = objSorDetail.MWarehouse
            End With

            Dim objOrderDetails As New Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.OrderDetails
            objOrders.OrderDetails = objOrderDetails
            objOrders.OrderDetails.StockLineCollection.Add(objStockLine)

            objSalesOrders.OrdersCollection = New List(Of Codewell.SysproIntegration.SalesOrdersPrimaryPosting.SalesOrderImport.Data.Orders)

            objSalesOrders.OrdersCollection.Add(objOrders)

            objSalesOrders.Post(True)

        Next

        Assert.Inconclusive()

    End Sub

    <TestMethod()> Public Sub TestMultipleStockLinesAndCommentLines()
        'Create the posting object
        Dim postingObject As New Data.SalesOrders

        'set the parameters for the posting object
        With postingObject.Params
            .AcceptEarlierShipDate = Params.AcceptEarlierShipDate.Y
            .AllowNonStockItems = Params.AllowNonStockItems.Y
            .AllowZeroPrice = Params.AllowZeroPrice.Y
            .AlwaysUsePriceEntered = Params.AlwaysUsePriceEntered.Y
            .AllowDuplicateOrderNumbers = Params.AllowDuplicateOrderNumbers.A
            .Process = Params.Process.IMPORT
            .StatusInProcess = Params.StatusInProcess.Item
            .TypeOfOrder = Params.TypeOfOrder.SCH
            .IgnoreWarnings = Params.IgnoreWarnings.Y
        End With


        'Start building a sales order object
        Dim SalesOrder As New Data.Orders

        SalesOrder.OrderHeader = New Data.OrderHeader
        SalesOrder.OrderDetails = New Data.OrderDetails
        'build the header

        With SalesOrder.OrderHeader
            .OrderActionType = Data.OrderActionType.C
            .SalesOrder = "12345"
        End With

        Dim commentLine As New Data.CommentLine
        With commentLine
            .LineActionType = Data.LineActionType.D
            .CustomerPoLine = 3
        End With
        SalesOrder.OrderDetails.CommentLineCollection.Add(commentLine)

        Dim stockLine1 As New Data.StockLine
        With stockLine1
            .LineActionType = Data.LineActionType.A
            .CustomerPoLine = 4
            .StockCode = "MStockCode1"
        End With
        SalesOrder.OrderDetails.StockLineCollection.Add(stockLine1)

        Dim stockLine2 As New Data.StockLine
        With stockLine2
            .LineActionType = Data.LineActionType.A
            .CustomerPoLine = 5
            .StockCode = "MStockCode2"
        End With
        SalesOrder.OrderDetails.StockLineCollection.Add(stockLine2)

        Dim unscheduledDeliveryLine As New Data.CommentLine
        With unscheduledDeliveryLine
            .LineActionType = Data.LineActionType.A
            .CustomerPoLine = 6
            .Comment = "left unscheduled"
        End With
        SalesOrder.OrderDetails.CommentLineCollection.Add(unscheduledDeliveryLine)


        postingObject.OrdersCollection = New List(Of Data.Orders)
        'Add the sales order(s) to the posting object (more than one sales order can be posted at a time)
        postingObject.OrdersCollection.Add(SalesOrder)

        Assert.IsTrue(postingObject.XMLData.Contains("<CommentLine"))
    End Sub

    <TestMethod()> _
    Public Sub XMLHasZeroPrice()

        Dim postingObject As New sorData.SalesOrders
        Dim header As New sorData.OrderHeader
        header.Customer = "1"

        Dim stockLine As New sorData.StockLine
        stockLine.CustomerPoLine = 1
        stockLine.StockCode = "123"
        stockLine.OrderQty = 1
        stockLine.Price = "0"

        Dim orders As New sorData.Orders
        orders.OrderHeader = header
        orders.OrderDetails = New sorData.OrderDetails
        orders.OrderDetails.StockLineCollection = New List(Of sorData.StockLine)
        orders.OrderDetails.StockLineCollection.Add(stockLine)

        postingObject.OrdersCollection = New List(Of sorData.Orders)

        postingObject.OrdersCollection.Add(orders)

        Assert.IsTrue(postingObject.XMLData.Contains("<Price>0</Price>"), postingObject.XMLData)

    End Sub


End Class
