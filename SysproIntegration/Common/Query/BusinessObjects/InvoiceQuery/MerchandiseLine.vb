Namespace QueryObjects.InvoiceQuery

    <Serializable()> Public Class MerchandiseLine
        Implements IInvoiceLine

#Region " Private Variables "
        Private _LineType As InvoiceLineTypeEnum
        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0001</LineNumber> 
        Private _SalesOrderLine As String = "" '>1</SalesOrderLine> 
        Private _MOrderQty As String = "" '>2.000</MOrderQty> 
        Private _MShipQty As String = "" '>2.000</MShipQty> 
        Private _MBackOrderQty As String = "" '>0.000</MBackOrderQty> 
        Private _MStockQtyToShp As String = "" '>2.000</MStockQtyToShp> 
        Private _PricingQtyShip As String = "" '>2.000</PricingQtyShip> 
        Private _MOrderUom As String = "" '>EA</MOrderUom> 
        Private _MStockingUom As String = "" '>EA</MStockingUom> 
        Private _MStockCode As String = "" '>MBHB100</MStockCode> 
        Private _MStockDes As String = "" '>Bicycle Helmet - White</MStockDes> 
        Private _MWarehouse As String = "" '>FG</MWarehouse> 
        Private _MBin As String = "" '>FG</MBin> 
        Private _MLineShipDate As String = "" '>2006-06-07</MLineShipDate> 
        Private _MCustRequestDat As String = "" '>2006-06-07</MCustRequestDat> 
        Private _MContract As String = "" ' /> 
        Private _MBuyingGroup As String = "" ' /> 
        Private _MCusSupStkCode As String = "" ' /> 
        Private _MCusRetailPrice As String = "" '>0.00000</MCusRetailPrice> 
        Private _CusGrossProfitPerc As String = "" '>0</CusGrossProfitPerc> 
        Private _DetCustTotalRetail As String = "" '>0.00</DetCustTotalRetail> 
        Private _ManPartNumber As String = "" ' /> 
        Private _LongDesc As String = "" ' /> 
        Private _OtherUm As String = "" '>EA</OtherUm> 
        Private _UserField1 As String = "" ' /> 
        Private _UserField2 As String = "" '>0.00000</UserField2> 
        Private _UserField3 As String = "" ' /> 
        Private _UserField4 As String = "" ' /> 
        Private _UserField5 As String = "" ' /> 
        Private _AlternateKey1 As String = "" ' /> 
        Private _AlternateKey2 As String = "" ' /> 
        Private _DrawOfficeNum As String = "" ' /> 
        Private _MUserDef As String = "" ' /> 
        Private _MStockUnitVol As String = "" '>0.000000</MStockUnitVol> 
        Private _LineVolume As String = "" '>0.000000</LineVolume> 
        Private _MBomFlag As String = "" ' /> 
        Private _MParentKitType As String = "" ' /> 
        Private _CreditReason As String = "" ' /> 
        Private _ReasonDescription As String = "" ' /> 
        Private _MerchLineCount As String = "" ' /> 
        Private _MStockUnitMass As String = "" '>1.000000</MStockUnitMass> 
        Private _LineMass As String = "" '>2.000000</LineMass> 
        Private _LineMassRounded As String = "" '>2</LineMassRounded> 
        Private _LineVolRounded As String = "" '>0</LineVolRounded> 
        Private _MPriceCode As String = "" '>A</MPriceCode> 
        Private _MPrice As String = "" '>500.00000</MPrice> 
        Private _NetUnitPrice As String = "" '>500.00000</NetUnitPrice> 
        Private _UnitPriceInclTax As String = "" '>550.00000</UnitPriceInclTax> 
        Private _UnitDiscount As String = "" '>0.00000</UnitDiscount> 
        Private _UnitPriceInOrderUm As String = "" '>500.00000</UnitPriceInOrderUm> 
        Private _MTariffcode As String = "" ' /> 
        Private _MSupplementaryUn As String = "" '>N</MSupplementaryUn> 
        Private _MPriceUom As String = "" '>EA</MPriceUom> 
        Private _MDiscPct1 As String = "" '>0.00</MDiscPct1> 
        Private _MDiscPct2 As String = "" '>0.00</MDiscPct2> 
        Private _MDiscPct3 As String = "" '>0.00</MDiscPct3> 
        Private _LineDiscValue As String = "" '>0.00</LineDiscValue> 
        Private _LineSalesTax As String = "" '>100.00</LineSalesTax> 
        Private _LineGrossamount As String = "" '>1000.00</LineGrossamount> 
        Private _LineNetAfterDisc As String = "" '>1000.00</LineNetAfterDisc> 
        Private _MTaxCode As String = "" '>A</MTaxCode> 
        Private _LineTaxPerc As String = "" '>10.00</LineTaxPerc> 
        Private _LineNetInclTax As String = "" '>1100.00</LineNetInclTax> 
        Private _MConvFactOrdUm As String = "" '>1.000000</MConvFactOrdUm> 
        Private _MMulDivPrcFct As String = "" '>M</MMulDivPrcFct> 
        Private _SalesOrder As String = "" '>000244</SalesOrder> 
        Private _MProductClass As String = "" '>MB</MProductClass> 
        Private _PalletQty As String = "" '>0.000</PalletQty> 
        Private _WarehouseToUse As String = "" '>FG</WarehouseToUse> 
        Private _MVersion As String = "" ' /> 
        Private _MRelease As String = "" ' /> 
        Private _MCommissionCode As String = "" ' /> 
        Private _SalesOrderInitLine As String = "" '>1</SalesOrderInitLine> 

        Private _myBins As BinLineCollection
        Private _myLots As LotLineCollection
        Private _mySerials As SerialLineCollection

#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As InvoiceLineTypeEnum Implements IInvoiceLine.LineType
            Get
                Return InvoiceLineTypeEnum.Merchandise
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IInvoiceLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IInvoiceLine.LineNumber
            Get
                Return _LineNumber
            End Get
            Set(ByVal Value As String)
                _LineNumber = Value
            End Set
        End Property

        Public Property SalesOrderLine() As String
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As String)
                _SalesOrderLine = Value
            End Set
        End Property
        Public Property MOrderQty() As String
            Get
                Return _MOrderQty
            End Get
            Set(ByVal Value As String)
                _MOrderQty = Value
            End Set
        End Property
        Public Property MShipQty() As String
            Get
                Return _MShipQty
            End Get
            Set(ByVal Value As String)
                _MShipQty = Value
            End Set
        End Property
        Public Property MBackOrderQty() As String
            Get
                Return _MBackOrderQty
            End Get
            Set(ByVal Value As String)
                _MBackOrderQty = Value
            End Set
        End Property
        Public Property MStockQtyToShp() As String
            Get
                Return _MStockQtyToShp
            End Get
            Set(ByVal Value As String)
                _MStockQtyToShp = Value
            End Set
        End Property
        Public Property PricingQtyShip() As String
            Get
                Return _PricingQtyShip
            End Get
            Set(ByVal Value As String)
                _PricingQtyShip = Value
            End Set
        End Property
        Public Property MOrderUom() As String
            Get
                Return _MOrderUom
            End Get
            Set(ByVal Value As String)
                _MOrderUom = Value
            End Set
        End Property
        Public Property MStockingUom() As String
            Get
                Return _MStockingUom
            End Get
            Set(ByVal Value As String)
                _MStockingUom = Value
            End Set
        End Property
        Public Property MStockCode() As String
            Get
                Return _MStockCode
            End Get
            Set(ByVal Value As String)
                _MStockCode = Value
            End Set
        End Property
        Public Property MStockDes() As String
            Get
                Return _MStockDes
            End Get
            Set(ByVal Value As String)
                _MStockDes = Value
            End Set
        End Property
        Public Property MWarehouse() As String
            Get
                Return _MWarehouse
            End Get
            Set(ByVal Value As String)
                _MWarehouse = Value
            End Set
        End Property
        Public Property MBin() As String
            Get
                Return _MBin
            End Get
            Set(ByVal Value As String)
                _MBin = Value
            End Set
        End Property
        Public Property MLineShipDate() As String
            Get
                Return _MLineShipDate
            End Get
            Set(ByVal Value As String)
                _MLineShipDate = Value
            End Set
        End Property
        Public Property MCustRequestDat() As String
            Get
                Return _MCustRequestDat
            End Get
            Set(ByVal Value As String)
                _MCustRequestDat = Value
            End Set
        End Property
        Public Property MContract() As String
            Get
                Return _MContract
            End Get
            Set(ByVal Value As String)
                _MContract = Value
            End Set
        End Property
        Public Property MBuyingGroup() As String
            Get
                Return _MBuyingGroup
            End Get
            Set(ByVal Value As String)
                _MBuyingGroup = Value
            End Set
        End Property
        Public Property MCusSupStkCode() As String
            Get
                Return _MCusSupStkCode
            End Get
            Set(ByVal Value As String)
                _MCusSupStkCode = Value
            End Set
        End Property
        Public Property MCusRetailPrice() As String
            Get
                Return _MCusRetailPrice
            End Get
            Set(ByVal Value As String)
                _MCusRetailPrice = Value
            End Set
        End Property
        Public Property CusGrossProfitPerc() As String
            Get
                Return _CusGrossProfitPerc
            End Get
            Set(ByVal Value As String)
                _CusGrossProfitPerc = Value
            End Set
        End Property
        Public Property DetCustTotalRetail() As String
            Get
                Return _DetCustTotalRetail
            End Get
            Set(ByVal Value As String)
                _DetCustTotalRetail = Value
            End Set
        End Property
        Public Property ManPartNumber() As String
            Get
                Return _ManPartNumber
            End Get
            Set(ByVal Value As String)
                _ManPartNumber = Value
            End Set
        End Property
        Public Property LongDesc() As String
            Get
                Return _LongDesc
            End Get
            Set(ByVal Value As String)
                _LongDesc = Value
            End Set
        End Property
        Public Property OtherUm() As String
            Get
                Return _OtherUm
            End Get
            Set(ByVal Value As String)
                _OtherUm = Value
            End Set
        End Property
        Public Property UserField1() As String
            Get
                Return _UserField1
            End Get
            Set(ByVal Value As String)
                _UserField1 = Value
            End Set
        End Property
        Public Property UserField2() As String
            Get
                Return _UserField2
            End Get
            Set(ByVal Value As String)
                _UserField2 = Value
            End Set
        End Property
        Public Property UserField3() As String
            Get
                Return _UserField3
            End Get
            Set(ByVal Value As String)
                _UserField3 = Value
            End Set
        End Property
        Public Property UserField4() As String
            Get
                Return _UserField4
            End Get
            Set(ByVal Value As String)
                _UserField4 = Value
            End Set
        End Property
        Public Property UserField5() As String
            Get
                Return _UserField5
            End Get
            Set(ByVal Value As String)
                _UserField5 = Value
            End Set
        End Property
        Public Property AlternateKey1() As String
            Get
                Return _AlternateKey1
            End Get
            Set(ByVal Value As String)
                _AlternateKey1 = Value
            End Set
        End Property
        Public Property AlternateKey2() As String
            Get
                Return _AlternateKey2
            End Get
            Set(ByVal Value As String)
                _AlternateKey2 = Value
            End Set
        End Property
        Public Property DrawOfficeNum() As String
            Get
                Return _DrawOfficeNum
            End Get
            Set(ByVal Value As String)
                _DrawOfficeNum = Value
            End Set
        End Property
        Public Property MUserDef() As String
            Get
                Return _MUserDef
            End Get
            Set(ByVal Value As String)
                _MUserDef = Value
            End Set
        End Property
        Public Property MStockUnitVol() As String
            Get
                Return _MStockUnitVol
            End Get
            Set(ByVal Value As String)
                _MStockUnitVol = Value
            End Set
        End Property
        Public Property LineVolume() As String
            Get
                Return _LineVolume
            End Get
            Set(ByVal Value As String)
                _LineVolume = Value
            End Set
        End Property
        Public Property MBomFlag() As String
            Get
                Return _MBomFlag
            End Get
            Set(ByVal Value As String)
                _MBomFlag = Value
            End Set
        End Property
        Public Property MParentKitType() As String
            Get
                Return _MParentKitType
            End Get
            Set(ByVal Value As String)
                _MParentKitType = Value
            End Set
        End Property
        Public Property CreditReason() As String
            Get
                Return _CreditReason
            End Get
            Set(ByVal Value As String)
                _CreditReason = Value
            End Set
        End Property
        Public Property ReasonDescription() As String
            Get
                Return _ReasonDescription
            End Get
            Set(ByVal Value As String)
                _ReasonDescription = Value
            End Set
        End Property
        Public Property MerchLineCount() As String
            Get
                Return _MerchLineCount
            End Get
            Set(ByVal Value As String)
                _MerchLineCount = Value
            End Set
        End Property
        Public Property MStockUnitMass() As String
            Get
                Return _MStockUnitMass
            End Get
            Set(ByVal Value As String)
                _MStockUnitMass = Value
            End Set
        End Property
        Public Property LineMass() As String
            Get
                Return _LineMass
            End Get
            Set(ByVal Value As String)
                _LineMass = Value
            End Set
        End Property
        Public Property LineMassRounded() As String
            Get
                Return _LineMassRounded
            End Get
            Set(ByVal Value As String)
                _LineMassRounded = Value
            End Set
        End Property
        Public Property LineVolRounded() As String
            Get
                Return _LineVolRounded
            End Get
            Set(ByVal Value As String)
                _LineVolRounded = Value
            End Set
        End Property
        Public Property MPriceCode() As String
            Get
                Return _MPriceCode
            End Get
            Set(ByVal Value As String)
                _MPriceCode = Value
            End Set
        End Property
        Public Property MPrice() As String
            Get
                Return _MPrice
            End Get
            Set(ByVal Value As String)
                _MPrice = Value
            End Set
        End Property
        Public Property NetUnitPrice() As String
            Get
                Return _NetUnitPrice
            End Get
            Set(ByVal Value As String)
                _NetUnitPrice = Value
            End Set
        End Property
        Public Property UnitPriceInclTax() As String
            Get
                Return _UnitPriceInclTax
            End Get
            Set(ByVal Value As String)
                _UnitPriceInclTax = Value
            End Set
        End Property
        Public Property UnitDiscount() As String
            Get
                Return _UnitDiscount
            End Get
            Set(ByVal Value As String)
                _UnitDiscount = Value
            End Set
        End Property
        Public Property UnitPriceInOrderUm() As String
            Get
                Return _UnitPriceInOrderUm
            End Get
            Set(ByVal Value As String)
                _UnitPriceInOrderUm = Value
            End Set
        End Property
        Public Property MTariffcode() As String
            Get
                Return _MTariffcode
            End Get
            Set(ByVal Value As String)
                _MTariffcode = Value
            End Set
        End Property
        Public Property MSupplementaryUn() As String
            Get
                Return _MSupplementaryUn
            End Get
            Set(ByVal Value As String)
                _MSupplementaryUn = Value
            End Set
        End Property
        Public Property MPriceUom() As String
            Get
                Return _MPriceUom
            End Get
            Set(ByVal Value As String)
                _MPriceUom = Value
            End Set
        End Property
        Public Property MDiscPct1() As String
            Get
                Return _MDiscPct1
            End Get
            Set(ByVal Value As String)
                _MDiscPct1 = Value
            End Set
        End Property
        Public Property MDiscPct2() As String
            Get
                Return _MDiscPct2
            End Get
            Set(ByVal Value As String)
                _MDiscPct2 = Value
            End Set
        End Property
        Public Property MDiscPct3() As String
            Get
                Return _MDiscPct3
            End Get
            Set(ByVal Value As String)
                _MDiscPct3 = Value
            End Set
        End Property
        Public Property LineDiscValue() As String
            Get
                Return _LineDiscValue
            End Get
            Set(ByVal Value As String)
                _LineDiscValue = Value
            End Set
        End Property
        Public Property LineSalesTax() As String
            Get
                Return _LineSalesTax
            End Get
            Set(ByVal Value As String)
                _LineSalesTax = Value
            End Set
        End Property
        Public Property LineGrossamount() As String
            Get
                Return _LineGrossamount
            End Get
            Set(ByVal Value As String)
                _LineGrossamount = Value
            End Set
        End Property
        Public Property LineNetAfterDisc() As String
            Get
                Return _LineNetAfterDisc
            End Get
            Set(ByVal Value As String)
                _LineNetAfterDisc = Value
            End Set
        End Property
        Public Property MTaxCode() As String
            Get
                Return _MTaxCode
            End Get
            Set(ByVal Value As String)
                _MTaxCode = Value
            End Set
        End Property
        Public Property LineTaxPerc() As String
            Get
                Return _LineTaxPerc
            End Get
            Set(ByVal Value As String)
                _LineTaxPerc = Value
            End Set
        End Property
        Public Property LineNetInclTax() As String
            Get
                Return _LineNetInclTax
            End Get
            Set(ByVal Value As String)
                _LineNetInclTax = Value
            End Set
        End Property
        Public Property MConvFactOrdUm() As String
            Get
                Return _MConvFactOrdUm
            End Get
            Set(ByVal Value As String)
                _MConvFactOrdUm = Value
            End Set
        End Property
        Public Property MMulDivPrcFct() As String
            Get
                Return _MMulDivPrcFct
            End Get
            Set(ByVal Value As String)
                _MMulDivPrcFct = Value
            End Set
        End Property
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property MProductClass() As String
            Get
                Return _MProductClass
            End Get
            Set(ByVal Value As String)
                _MProductClass = Value
            End Set
        End Property
        Public Property PalletQty() As String
            Get
                Return _PalletQty
            End Get
            Set(ByVal Value As String)
                _PalletQty = Value
            End Set
        End Property
        Public Property WarehouseToUse() As String
            Get
                Return _WarehouseToUse
            End Get
            Set(ByVal Value As String)
                _WarehouseToUse = Value
            End Set
        End Property
        Public Property MVersion() As String
            Get
                Return _MVersion
            End Get
            Set(ByVal Value As String)
                _MVersion = Value
            End Set
        End Property
        Public Property MRelease() As String
            Get
                Return _MRelease
            End Get
            Set(ByVal Value As String)
                _MRelease = Value
            End Set
        End Property
        Public Property MCommissionCode() As String
            Get
                Return _MCommissionCode
            End Get
            Set(ByVal Value As String)
                _MCommissionCode = Value
            End Set
        End Property
        Public Property SalesOrderInitLine() As String
            Get
                Return _SalesOrderInitLine
            End Get
            Set(ByVal Value As String)
                _SalesOrderInitLine = Value
            End Set
        End Property
        Public Property myBins() As BinLineCollection
            Get
                If _myBins Is Nothing Then
                    _myBins = New BinLineCollection
                End If
                Return _myBins
            End Get
            Set(ByVal Value As BinLineCollection)
                _myBins = Value
            End Set
        End Property
        Public Property myLots() As LotLineCollection
            Get
                If _myLots Is Nothing Then
                    _myLots = New LotLineCollection
                End If
                Return _myLots
            End Get
            Set(ByVal Value As LotLineCollection)
                _myLots = Value
            End Set
        End Property
        Public Property mySerials() As SerialLineCollection
            Get
                If _mySerials Is Nothing Then
                    _mySerials = New SerialLineCollection
                End If
                Return _mySerials
            End Get
            Set(ByVal Value As SerialLineCollection)
                _mySerials = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As MerchandiseLine

            Dim merchLine As New MerchandiseLine

            With merchLine
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                Try
                    .SalesOrderLine = rootRow.Item("SalesOrderLine").ToString
                Catch ex As Exception
                    'This element does not exist in the XML Out anymore even though it is defined to be there in the E.Net Reference!
                End Try
                .MOrderQty = rootRow.Item("MOrderQty").ToString
                .MShipQty = rootRow.Item("MShipQty").ToString
                .MBackOrderQty = rootRow.Item("MBackOrderQty").ToString
                .MStockQtyToShp = rootRow.Item("MStockQtyToShp").ToString
                .PricingQtyShip = rootRow.Item("PricingQtyShip").ToString
                .MOrderUom = rootRow.Item("MOrderUom").ToString
                .MStockingUom = rootRow.Item("MStockingUom").ToString
                .MStockCode = rootRow.Item("MStockCode").ToString
                .MStockDes = rootRow.Item("MStockDes").ToString
                .MWarehouse = rootRow.Item("MWarehouse").ToString
                .MBin = rootRow.Item("MBin").ToString
                .MLineShipDate = rootRow.Item("MLineShipDate").ToString
                .MCustRequestDat = rootRow.Item("MCustRequestDat").ToString
                .MContract = rootRow.Item("MContract").ToString
                .MBuyingGroup = rootRow.Item("MBuyingGroup").ToString
                .MCusSupStkCode = rootRow.Item("MCusSupStkCode").ToString
                .MCusRetailPrice = rootRow.Item("MCusRetailPrice").ToString
                .CusGrossProfitPerc = rootRow.Item("CusGrossProfitPerc").ToString
                .DetCustTotalRetail = rootRow.Item("DetCustTotalRetail").ToString
                .ManPartNumber = rootRow.Item("ManPartNumber").ToString
                .LongDesc = rootRow.Item("LongDesc").ToString
                .OtherUm = rootRow.Item("OtherUm").ToString
                .UserField1 = rootRow.Item("UserField1").ToString
                .UserField2 = rootRow.Item("UserField2").ToString
                .UserField3 = rootRow.Item("UserField3").ToString
                .UserField4 = rootRow.Item("UserField4").ToString
                .UserField5 = rootRow.Item("UserField5").ToString
                .AlternateKey1 = rootRow.Item("AlternateKey1").ToString
                .AlternateKey2 = rootRow.Item("AlternateKey2").ToString
                .DrawOfficeNum = rootRow.Item("DrawOfficeNum").ToString
                .MUserDef = rootRow.Item("MUserDef").ToString
                .MStockUnitVol = rootRow.Item("MStockUnitVol").ToString
                .LineVolume = rootRow.Item("LineVolume").ToString
                Try
                    .MBomFlag = rootRow.Item("MBomFlag").ToString
                Catch ex As Exception
                    'This element does not exist in the XML Out anymore even though it is defined to be there in the E.Net Reference!
                End Try
                Try
                    .MParentKitType = rootRow.Item("MParentKitType").ToString
                Catch ex As Exception
                    'This element does not exist in the XML Out anymore even though it is defined to be there in the E.Net Reference!
                End Try
                .CreditReason = rootRow.Item("CreditReason").ToString
                .ReasonDescription = rootRow.Item("ReasonDescription").ToString
                .MerchLineCount = rootRow.Item("MerchLineCount").ToString
                .MStockUnitMass = rootRow.Item("MStockUnitMass").ToString
                .LineMass = rootRow.Item("LineMass").ToString
                .LineMassRounded = rootRow.Item("LineMassRounded").ToString
                .LineVolRounded = rootRow.Item("LineVolRounded").ToString
                .MPriceCode = rootRow.Item("MPriceCode").ToString
                .MPrice = rootRow.Item("MPrice").ToString
                .NetUnitPrice = rootRow.Item("NetUnitPrice").ToString
                .UnitPriceInclTax = rootRow.Item("UnitPriceInclTax").ToString
                .UnitDiscount = rootRow.Item("UnitDiscount").ToString
                .UnitPriceInOrderUm = rootRow.Item("UnitPriceInOrderUm").ToString
                .MTariffcode = rootRow.Item("MTariffcode").ToString
                .MSupplementaryUn = rootRow.Item("MSupplementaryUn").ToString
                .MPriceUom = rootRow.Item("MPriceUom").ToString
                .MDiscPct1 = rootRow.Item("MDiscPct1").ToString
                .MDiscPct2 = rootRow.Item("MDiscPct2").ToString
                .MDiscPct3 = rootRow.Item("MDiscPct3").ToString
                .LineDiscValue = rootRow.Item("LineDiscValue").ToString
                .LineSalesTax = rootRow.Item("LineSalesTax").ToString
                .LineGrossamount = rootRow.Item("LineGrossamount").ToString
                .LineNetAfterDisc = rootRow.Item("LineNetAfterDisc").ToString
                .MTaxCode = rootRow.Item("MTaxCode").ToString
                .LineTaxPerc = rootRow.Item("LineTaxPerc").ToString
                .LineNetInclTax = rootRow.Item("LineNetInclTax").ToString
                .MConvFactOrdUm = rootRow.Item("MConvFactOrdUm").ToString
                .MMulDivPrcFct = rootRow.Item("MMulDivPrcFct").ToString
                Try
                    .SalesOrder = rootRow.Item("SalesOrder").ToString
                Catch ex As Exception
                    'This element does not exist in the XML Out anymore even though it is defined to be there in the E.Net Reference!
                End Try
                .MProductClass = rootRow.Item("MProductClass").ToString
                .PalletQty = rootRow.Item("PalletQty").ToString
                .WarehouseToUse = rootRow.Item("WarehouseToUse").ToString
                .MVersion = rootRow.Item("MVersion").ToString
                .MRelease = rootRow.Item("MRelease").ToString
                .MCommissionCode = rootRow.Item("MCommissionCode").ToString
                Try
                    .SalesOrderInitLine = rootRow.Item("SalesOrderInitLine").ToString
                Catch ex As Exception
                    'This element does not exist in the XML Out anymore even though it is defined to be there in the E.Net Reference!
                End Try

            End With

            Return merchLine

        End Function

        Public Sub AddBinsFromDS(ByVal ds As DataSet)
            If ds.Tables.Contains("Bins") Then
                For Each binRow As DataRow In ds.Tables("Bins").Rows
                    If binRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
                    binRow.Item("LineNumber").ToString = LineNumber Then
                        myBins.Add(BinLine.NewFromDataRow(binRow))
                    End If
                Next
            End If
        End Sub

        Public Sub AddLotsFromDS(ByVal ds As DataSet)
            If ds.Tables.Contains("Lots") Then
                For Each LotRow As DataRow In ds.Tables("Lots").Rows
                    If LotRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
                    LotRow.Item("LineNumber").ToString = LineNumber Then
                        myLots.Add(LotLine.NewFromDataRow(LotRow))
                    End If
                Next
            End If
        End Sub

        Public Sub AddSerialsFromDS(ByVal ds As DataSet)
            If ds.Tables.Contains("Serials") Then
                For Each SerialRow As DataRow In ds.Tables("Serials").Rows
                    If SerialRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
                    SerialRow.Item("LineNumber").ToString = LineNumber Then
                        mySerials.Add(SerialLine.NewFromDataRow(SerialRow))
                    End If
                Next
            End If
        End Sub

    End Class
End Namespace
