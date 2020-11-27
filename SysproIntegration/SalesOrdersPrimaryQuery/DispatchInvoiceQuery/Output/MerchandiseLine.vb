Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> Public Class MerchandiseLine
        Implements IDispatchInvoiceLine

#Region " Private Variables "
        Private _LineType As DispatchInvoiceLineTypeEnum = DispatchInvoiceLineTypeEnum.Merchandise
        Private _DocumentNumber As String = ""
        Private _LineNumber As String = ""
        Private _SalesOrderInitLine As String = ""
        Private _MOrderQty As String = ""
        Private _MShipQty As String = ""
        Private _MBackOrderQty As String = ""
        Private _MStockQtyToShp As String = ""
        Private _PricingQtyShip As String = ""
        Private _MOrderUom As String = ""
        Private _MStockingUom As String = ""
        Private _DispatchNote As String = ""
        Private _DispatchNoteLine As String = ""
        Private _MStockCode As String = ""
        Private _MStockDes As String = ""
        Private _MWarehouse As String = ""
        Private _MBin As String = ""
        Private _JobNumber As String = ""
        Private _MLineShipDate As String = ""
        Private _MCustRequestDat As String = ""
        Private _MContract As String = ""
        Private _MBuyingGroup As String = ""
        Private _MCusSupStkCode As String = ""
        Private _MCusRetailPrice As String = ""
        Private _CusGrossProfitPerc As String = ""
        Private _DetCustTotalRetail As String = ""
        Private _ManPartNumber As String = ""
        Private _LongDesc As String = ""
        Private _OtherUm As String = ""
        Private _UserField1 As String = ""
        Private _UserField2 As String = ""
        Private _UserField3 As String = ""
        Private _UserField4 As String = ""
        Private _UserField5 As String = ""
        Private _AlternateKey1 As String = ""
        Private _AlternateKey2 As String = ""
        Private _DrawOfficeNum As String = ""
        Private _MUserDef As String = ""
        Private _MStockUnitVol As String = ""
        Private _LineVolume As String = ""
        Private _MerchLineCount As String = ""
        Private _MStockUnitMass As String = ""
        Private _LineMass As String = ""
        Private _LineMassRounded As String = ""
        Private _LineVolRounded As String = ""
        Private _MPriceCode As String = ""
        Private _MPrice As String = ""
        Private _NetUnitPrice As String = ""
        Private _UnitPriceInclTax As String = ""
        Private _UnitDiscount As String = ""
        Private _UnitPriceInOrderUm As String = ""
        Private _MTariffcode As String = ""
        Private _MSupplementaryUn As String = ""
        Private _MPriceUom As String = ""
        Private _MDiscValFlg As String = ""
        Private _MDiscValue As String = ""
        Private _MDiscPct1 As String = ""
        Private _MDiscPct2 As String = ""
        Private _MDiscPct3 As String = ""
        Private _LineDiscValue As String = ""
        Private _LineSalesTax As String = ""
        Private _LineGrossAmount As String = ""
        Private _LineNetAfterDisc As String = ""
        Private _MTaxCode As String = ""
        Private _LineTaxPerc As String = ""
        Private _LineNetInclTax As String = ""
        Private _MConvFactOrdUm As String = ""
        Private _MMulDivPrcFct As String = ""
        Private _SalesOrder As String = ""
        Private _MProductClass As String = ""
        Private _PalletQty As String = ""
        Private _WarehouseToUse As String = ""
        Private _MVersion As String = ""
        Private _MRelease As String = ""
        Private _CountryOfOrigin As String = ""
        Private _CountryOfOriginName As String = ""
        Private _MCommissionCode As String = ""
        
        Private _myBins As BinLineCollection

        'TODO: This was initially done for Schneider, who does not use Lots and serials...hence these are commented out for quicker delivery
        'Private _myLots As LotLineCollection
        'Private _mySerials As SerialLineCollection

#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As DispatchInvoiceLineTypeEnum Implements IDispatchInvoiceLine.LineType
            Get
                Return _LineType
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IDispatchInvoiceLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IDispatchInvoiceLine.LineNumber
            Get
                Return _LineNumber
            End Get
            Set(ByVal Value As String)
                _LineNumber = Value
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
        Public Property DispatchNote() As String
            Get
                Return _DispatchNote
            End Get
            Set(ByVal Value As String)
                _DispatchNote = Value
            End Set
        End Property
        Public Property DispatchNoteLine() As String
            Get
                Return _DispatchNoteLine
            End Get
            Set(ByVal Value As String)
                _DispatchNoteLine = Value
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
        Public Property JobNumber() As String
            Get
                Return _JobNumber
            End Get
            Set(ByVal Value As String)
                _JobNumber = Value
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
        Public Property MDiscValFlg() As String
            Get
                Return _MDiscValFlg
            End Get
            Set(ByVal Value As String)
                _MDiscValFlg = Value
            End Set
        End Property
        Public Property MDiscValue() As String
            Get
                Return _MDiscValue
            End Get
            Set(ByVal Value As String)
                _MDiscValue = Value
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
        Public Property LineGrossAmount() As String
            Get
                Return _LineGrossAmount
            End Get
            Set(ByVal Value As String)
                _LineGrossAmount = Value
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
        Public Property CountryOfOrigin() As String
            Get
                Return _CountryOfOrigin
            End Get
            Set(ByVal Value As String)
                _CountryOfOrigin = Value
            End Set
        End Property
        Public Property CountryOfOriginName() As String
            Get
                Return _CountryOfOriginName
            End Get
            Set(ByVal Value As String)
                _CountryOfOriginName = Value
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

        Public Property myBins() As BinLineCollection
            Get
                Return _myBins
            End Get
            Set(ByVal Value As BinLineCollection)
                _myBins = Value
            End Set
        End Property

        'TODO: This was initially done for Schneider, who does not use Lots and serials...hence these are commented out for quicker delivery
        'Public Property myLots() As LotLineCollection
        '    Get
        '        If _myLots Is Nothing Then
        '            _myLots = New LotLineCollection
        '        End If
        '        Return _myLots
        '    End Get
        '    Set(ByVal Value As LotLineCollection)
        '        _myLots = Value
        '    End Set
        'End Property
        'Public Property mySerials() As SerialLineCollection
        '    Get
        '        If _mySerials Is Nothing Then
        '            _mySerials = New SerialLineCollection
        '        End If
        '        Return _mySerials
        '    End Get
        '    Set(ByVal Value As SerialLineCollection)
        '        _mySerials = Value
        '    End Set
        'End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As MerchandiseLine

            Dim merchLine As New MerchandiseLine

            With merchLine
                Try : .DocumentNumber = rootRow.Item("DocumentNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .LineNumber = rootRow.Item("LineNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrderInitLine = rootRow.Item("SalesOrderInitLine").ToString : Catch ex As ArgumentException : End Try
                Try : .MOrderQty = rootRow.Item("MOrderQty").ToString : Catch ex As ArgumentException : End Try
                Try : .MShipQty = rootRow.Item("MShipQty").ToString : Catch ex As ArgumentException : End Try
                Try : .MBackOrderQty = rootRow.Item("MBackOrderQty").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockQtyToShp = rootRow.Item("MStockQtyToShp").ToString : Catch ex As ArgumentException : End Try
                Try : .PricingQtyShip = rootRow.Item("PricingQtyShip").ToString : Catch ex As ArgumentException : End Try
                Try : .MOrderUom = rootRow.Item("MOrderUom").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockingUom = rootRow.Item("MStockingUom").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchNote = rootRow.Item("DispatchNote").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchNoteLine = rootRow.Item("DispatchNoteLine").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockCode = rootRow.Item("MStockCode").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockDes = rootRow.Item("MStockDes").ToString : Catch ex As ArgumentException : End Try
                Try : .MWarehouse = rootRow.Item("MWarehouse").ToString : Catch ex As ArgumentException : End Try
                Try : .MBin = rootRow.Item("MBin").ToString : Catch ex As ArgumentException : End Try
                Try : .JobNumber = rootRow.Item("JobNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .MLineShipDate = rootRow.Item("MLineShipDate").ToString : Catch ex As ArgumentException : End Try
                Try : .MCustRequestDat = rootRow.Item("MCustRequestDat").ToString : Catch ex As ArgumentException : End Try
                Try : .MContract = rootRow.Item("MContract").ToString : Catch ex As ArgumentException : End Try
                Try : .MBuyingGroup = rootRow.Item("MBuyingGroup").ToString : Catch ex As ArgumentException : End Try
                Try : .MCusSupStkCode = rootRow.Item("MCusSupStkCode").ToString : Catch ex As ArgumentException : End Try
                Try : .MCusRetailPrice = rootRow.Item("MCusRetailPrice").ToString : Catch ex As ArgumentException : End Try
                Try : .CusGrossProfitPerc = rootRow.Item("CusGrossProfitPerc").ToString : Catch ex As ArgumentException : End Try
                Try : .DetCustTotalRetail = rootRow.Item("DetCustTotalRetail").ToString : Catch ex As ArgumentException : End Try
                Try : .ManPartNumber = rootRow.Item("ManPartNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .LongDesc = rootRow.Item("LongDesc").ToString : Catch ex As ArgumentException : End Try
                Try : .OtherUm = rootRow.Item("OtherUm").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField1 = rootRow.Item("UserField1").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField2 = rootRow.Item("UserField2").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField3 = rootRow.Item("UserField3").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField4 = rootRow.Item("UserField4").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField5 = rootRow.Item("UserField5").ToString : Catch ex As ArgumentException : End Try
                Try : .AlternateKey1 = rootRow.Item("AlternateKey1").ToString : Catch ex As ArgumentException : End Try
                Try : .AlternateKey2 = rootRow.Item("AlternateKey2").ToString : Catch ex As ArgumentException : End Try
                Try : .DrawOfficeNum = rootRow.Item("DrawOfficeNum").ToString : Catch ex As ArgumentException : End Try
                Try : .MUserDef = rootRow.Item("MUserDef").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockUnitVol = rootRow.Item("MStockUnitVol").ToString : Catch ex As ArgumentException : End Try
                Try : .LineVolume = rootRow.Item("LineVolume").ToString : Catch ex As ArgumentException : End Try
                Try : .MerchLineCount = rootRow.Item("MerchLineCount").ToString : Catch ex As ArgumentException : End Try
                Try : .MStockUnitMass = rootRow.Item("MStockUnitMass").ToString : Catch ex As ArgumentException : End Try
                Try : .LineMass = rootRow.Item("LineMass").ToString : Catch ex As ArgumentException : End Try
                Try : .LineMassRounded = rootRow.Item("LineMassRounded").ToString : Catch ex As ArgumentException : End Try
                Try : .LineVolRounded = rootRow.Item("LineVolRounded").ToString : Catch ex As ArgumentException : End Try
                Try : .MPriceCode = rootRow.Item("MPriceCode").ToString : Catch ex As ArgumentException : End Try
                Try : .MPrice = rootRow.Item("MPrice").ToString : Catch ex As ArgumentException : End Try
                Try : .NetUnitPrice = rootRow.Item("NetUnitPrice").ToString : Catch ex As ArgumentException : End Try
                Try : .UnitPriceInclTax = rootRow.Item("UnitPriceInclTax").ToString : Catch ex As ArgumentException : End Try
                Try : .UnitDiscount = rootRow.Item("UnitDiscount").ToString : Catch ex As ArgumentException : End Try
                Try : .UnitPriceInOrderUm = rootRow.Item("UnitPriceInOrderUm").ToString : Catch ex As ArgumentException : End Try
                Try : .MTariffcode = rootRow.Item("MTariffcode").ToString : Catch ex As ArgumentException : End Try
                Try : .MSupplementaryUn = rootRow.Item("MSupplementaryUn").ToString : Catch ex As ArgumentException : End Try
                Try : .MPriceUom = rootRow.Item("MPriceUom").ToString : Catch ex As ArgumentException : End Try
                Try : .MDiscValFlg = rootRow.Item("MDiscValFlg").ToString : Catch ex As ArgumentException : End Try
                Try : .MDiscValue = rootRow.Item("MDiscValue").ToString : Catch ex As ArgumentException : End Try
                Try : .MDiscPct1 = rootRow.Item("MDiscPct1").ToString : Catch ex As ArgumentException : End Try
                Try : .MDiscPct2 = rootRow.Item("MDiscPct2").ToString : Catch ex As ArgumentException : End Try
                Try : .MDiscPct3 = rootRow.Item("MDiscPct3").ToString : Catch ex As ArgumentException : End Try
                Try : .LineDiscValue = rootRow.Item("LineDiscValue").ToString : Catch ex As ArgumentException : End Try
                Try : .LineSalesTax = rootRow.Item("LineSalesTax").ToString : Catch ex As ArgumentException : End Try
                Try : .LineGrossAmount = rootRow.Item("LineGrossAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .LineNetAfterDisc = rootRow.Item("LineNetAfterDisc").ToString : Catch ex As ArgumentException : End Try
                Try : .MTaxCode = rootRow.Item("MTaxCode").ToString : Catch ex As ArgumentException : End Try
                Try : .LineTaxPerc = rootRow.Item("LineTaxPerc").ToString : Catch ex As ArgumentException : End Try
                Try : .LineNetInclTax = rootRow.Item("LineNetInclTax").ToString : Catch ex As ArgumentException : End Try
                Try : .MConvFactOrdUm = rootRow.Item("MConvFactOrdUm").ToString : Catch ex As ArgumentException : End Try
                Try : .MMulDivPrcFct = rootRow.Item("MMulDivPrcFct").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrder = rootRow.Item("SalesOrder").ToString : Catch ex As ArgumentException : End Try
                Try : .MProductClass = rootRow.Item("MProductClass").ToString : Catch ex As ArgumentException : End Try
                Try : .PalletQty = rootRow.Item("PalletQty").ToString : Catch ex As ArgumentException : End Try
                Try : .WarehouseToUse = rootRow.Item("WarehouseToUse").ToString : Catch ex As ArgumentException : End Try
                Try : .MVersion = rootRow.Item("MVersion").ToString : Catch ex As ArgumentException : End Try
                Try : .MRelease = rootRow.Item("MRelease").ToString : Catch ex As ArgumentException : End Try
                Try : .CountryOfOrigin = rootRow.Item("CountryOfOrigin").ToString : Catch ex As ArgumentException : End Try
                Try : .CountryOfOriginName = rootRow.Item("CountryOfOriginName").ToString : Catch ex As ArgumentException : End Try
                Try : .MCommissionCode = rootRow.Item("MCommissionCode").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrderInitLine = rootRow.Item("SalesOrderInitLine").ToString : Catch ex As ArgumentException : End Try
            End With

            Return merchLine

        End Function

        Public Sub AddBinsFromDS(ByVal ds As DataSet)
            If ds.Tables.Contains("Bins") Then
                For Each binRow As DataRow In ds.Tables("Bins").Rows
                    If binRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
                    binRow.Item("LineNumber").ToString = DispatchNoteLine Then
                        myBins.Add(BinLine.NewFromDataRow(binRow))
                    End If
                Next
            End If
        End Sub

        'TODO: This was initially done for Schneider, who does not use Lots and serials...hence these are commented out for quicker delivery
        'Public Sub AddLotsFromDS(ByVal ds As DataSet)
        '    If ds.Tables.Contains("Lots") Then
        '        For Each LotRow As DataRow In ds.Tables("Lots").Rows
        '            If LotRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
        '            LotRow.Item("LineNumber").ToString = LineNumber Then
        '                myLots.Add(LotLine.NewFromDataRow(LotRow))
        '            End If
        '        Next
        '    End If
        'End Sub

        'Public Sub AddSerialsFromDS(ByVal ds As DataSet)
        '    If ds.Tables.Contains("Serials") Then
        '        For Each SerialRow As DataRow In ds.Tables("Serials").Rows
        '            If SerialRow.Item("DocumentNumber").ToString = DocumentNumber AndAlso _
        '            SerialRow.Item("LineNumber").ToString = LineNumber Then
        '                mySerials.Add(SerialLine.NewFromDataRow(SerialRow))
        '            End If
        '        Next
        '    End If
        'End Sub

    End Class
End Namespace
