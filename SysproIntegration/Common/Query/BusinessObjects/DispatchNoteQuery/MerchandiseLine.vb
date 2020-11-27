Namespace QueryObjects.DispatchNoteQuery
    <Serializable()> Public Class MerchandiseLine
        Implements IDispatchNoteLine

#Region " Private Variables "
        Private _DocumentNumber As String = ""
        Private _LineType As DispatchNoteLineTypeEnum = DispatchNoteLineTypeEnum.Merchandise
        Private _DispatchNoteLine As String = ""
        Private _MStockCode As String = "" '
        Private _MStockDes As String = "" '
        Private _LongDesc As String = "" '
        Private _MWarehouse As String = "" '
        Private _SalesOrderLine As String = "" '
        Private _MBin As String = "" '
        Private _DispatchStatus As String = "" '
        Private _MCusSupStkCode As String = "" '
        Private _OverUnderFlag As String = "" '
        Private _StockDepleted As String = "" '
        Private _MOrderQty As String = "" '
        Private _MOrderQtyInStockingUm As String = "" '
        Private _MQtyToDispatch As String = "" '
        Private _MStockQtyToShp As String = "" '
        Private _MBackOrderQty As String = "" '
        Private _MBackOrderQtyInStockingUm As String = "" '
        Private _MMulDivQtyFct As String = "" '
        Private _MConvFactAlloc As String = "" '
        Private _MOrderUom As String = "" '
        Private _MStockingUom As String = "" '
        Private _MStockUnitMass As String = "" '
        Private _MStockUnitVol As String = "" '
        Private _MPrice As String = "" '
        Private _MPriceUom As String = "" '
        Private _ConfirmationDate As String = "" '
        Private _ConfirmationLine As String = "" '
        Private _OrigShipSoUom As String = "" '
        Private _OrigShipStkUom As String = "" '
        Private _OrigBoSoUom As String = "" '
        Private _MDiscValFlag As String = "" '
        Private _MDiscPct1 As String = "" '
        Private _MDiscPct2 As String = "" '
        Private _MDiscPct3 As String = "" '
        Private _OrderLineValue As String = "" '
        Private _MCustRequestDat As String = "" '
        Private _MHierarchyJob As String = "" '
        Private _MUnitCost As String = "" '
        Private _MBomFlag As String = "" '
        Private _MParentKitType As String = "" '
        Private _MQtyPer As String = "" '
        Private _MScrapPercentage As String = "" '
        Private _MPrintComponent As String = "" '
        Private _MComponentSeq As String = "" '
        Private _MQtyChangesFlag As String = "" '
        Private _MOptionalFlag As String = "" '
        Private _MDecimals As String = "" '
        Private _MConvFactOrdUm As String = "" '
        Private _MMulDivPrcFct As String = "" '
        Private _MCommissionCode As String = "" '
        Private _MProductClass As String = "" '
        Private _MTaxCode As String = "" '
        Private _MLineShipDate As String = "" '
        Private _MAllocStatSched As String = "" '
        Private _MFstTaxCode As String = "" '
        Private _MPriceCode As String = "" '
        Private _MTraceableType As String = "" '
        Private _MMpsFlag As String = "" '
        Private _MPickingSlip As String = "" '
        Private _MMovementReqd As String = "" '
        Private _MSerialMethod As String = "" '
        Private _MZeroQtyCrNote As String = "" '
        Private _MAbcApplied As String = "" '
        Private _MMpsGrossReqd As String = "" '
        Private _MContract As String = "" '
        Private _MBuyingGroup As String = "" '
        Private _MCusRetailPrice As String = "" '
        Private _TotalValue As String = "" '
        Private _MTariffCode As String = "" '
        Private _MLineReceiptDat As String = "" '
        Private _MLeadTime As String = "" '
        Private _MTrfCostMult As String = "" '
        Private _MSupplementaryUn As String = "" '
        Private _MReviewFlag As String = "" '
        Private _MReviewStatus As String = "" '
        Private _MInvoicePrinted As String = "" '
        Private _MDelNotePrinted As String = "" '
        Private _MOrdAckPrinted As String = "" '
        Private _MLastDelNote As String = "" '
        Private _MUserDef As String = "" '
        Private _MQtyDispatched As String = "" '
        Private _MDiscChanged As String = "" '
        Private _MCreditOrderNo As String = "" '
        Private _MCreditOrderLine As String = "" '
        Private _MUnitQuantity As String = "" '
        Private _MConvFactUnitQ As String = "" '
        Private _MAltUomUnitQ As String = "" '
        Private _MDecimalsUnitQ As String = "" '
        Private _MEccFlag As String = "" '
        Private _MVersion As String = "" '
        Private _MRelease As String = "" '
        Private _MCommitDate As String = "" '

        Private _myBins As BinLineCollection

        'TODO: This was initially done for Schneider, who does not use Lots and serials...hence these are commented out for quicker delivery
        'Private _myLots As LotLineCollection
        'Private _mySerials As SerialLineCollection

#End Region

#Region " Public Properties "
        Public Property DocumentNumber() As String Implements IDispatchNoteLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal value As String)
                _DocumentNumber = value
            End Set
        End Property
        Public ReadOnly Property LineType() As DispatchNoteLineTypeEnum Implements IDispatchNoteLine.LineType
            Get
                Return _LineType
            End Get
        End Property
        Public Property DispatchNoteLine() As String Implements IDispatchNoteLine.LineNumber
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
        Public Property LongDesc() As String
            Get
                Return _LongDesc
            End Get
            Set(ByVal Value As String)
                _LongDesc = Value
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
        Public Property SalesOrderLine() As String
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As String)
                _SalesOrderLine = Value
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
        Public Property DispatchStatus() As String
            Get
                Return _DispatchStatus
            End Get
            Set(ByVal Value As String)
                _DispatchStatus = Value
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
        Public Property OverUnderFlag() As String
            Get
                Return _OverUnderFlag
            End Get
            Set(ByVal Value As String)
                _OverUnderFlag = Value
            End Set
        End Property
        Public Property StockDepleted() As String
            Get
                Return _StockDepleted
            End Get
            Set(ByVal Value As String)
                _StockDepleted = Value
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
        Public Property MOrderQtyInStockingUm() As String
            Get
                Return _MOrderQtyInStockingUm
            End Get
            Set(ByVal Value As String)
                _MOrderQtyInStockingUm = Value
            End Set
        End Property
        Public Property MQtyToDispatch() As String
            Get
                Return _MQtyToDispatch
            End Get
            Set(ByVal Value As String)
                _MQtyToDispatch = Value
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
        Public Property MBackOrderQty() As String
            Get
                Return _MBackOrderQty
            End Get
            Set(ByVal Value As String)
                _MBackOrderQty = Value
            End Set
        End Property
        Public Property MBackOrderQtyInStockingUm() As String
            Get
                Return _MBackOrderQtyInStockingUm
            End Get
            Set(ByVal Value As String)
                _MBackOrderQtyInStockingUm = Value
            End Set
        End Property
        Public Property MMulDivQtyFct() As String
            Get
                Return _MMulDivQtyFct
            End Get
            Set(ByVal Value As String)
                _MMulDivQtyFct = Value
            End Set
        End Property
        Public Property MConvFactAlloc() As String
            Get
                Return _MConvFactAlloc
            End Get
            Set(ByVal Value As String)
                _MConvFactAlloc = Value
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
        Public Property MStockUnitMass() As String
            Get
                Return _MStockUnitMass
            End Get
            Set(ByVal Value As String)
                _MStockUnitMass = Value
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
        Public Property MPrice() As String
            Get
                Return _MPrice
            End Get
            Set(ByVal Value As String)
                _MPrice = Value
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
        Public Property ConfirmationDate() As String
            Get
                Return _ConfirmationDate
            End Get
            Set(ByVal Value As String)
                _ConfirmationDate = Value
            End Set
        End Property
        Public Property ConfirmationLine() As String
            Get
                Return _ConfirmationLine
            End Get
            Set(ByVal Value As String)
                _ConfirmationLine = Value
            End Set
        End Property
        Public Property OrigShipSoUom() As String
            Get
                Return _OrigShipSoUom
            End Get
            Set(ByVal Value As String)
                _OrigShipSoUom = Value
            End Set
        End Property
        Public Property OrigShipStkUom() As String
            Get
                Return _OrigShipStkUom
            End Get
            Set(ByVal Value As String)
                _OrigShipStkUom = Value
            End Set
        End Property
        Public Property OrigBoSoUom() As String
            Get
                Return _OrigBoSoUom
            End Get
            Set(ByVal Value As String)
                _OrigBoSoUom = Value
            End Set
        End Property
        Public Property MDiscValFlag() As String
            Get
                Return _MDiscValFlag
            End Get
            Set(ByVal Value As String)
                _MDiscValFlag = Value
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
        Public Property OrderLineValue() As String
            Get
                Return _OrderLineValue
            End Get
            Set(ByVal Value As String)
                _OrderLineValue = Value
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
        Public Property MHierarchyJob() As String
            Get
                Return _MHierarchyJob
            End Get
            Set(ByVal Value As String)
                _MHierarchyJob = Value
            End Set
        End Property
        Public Property MUnitCost() As String
            Get
                Return _MUnitCost
            End Get
            Set(ByVal Value As String)
                _MUnitCost = Value
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
        Public Property MQtyPer() As String
            Get
                Return _MQtyPer
            End Get
            Set(ByVal Value As String)
                _MQtyPer = Value
            End Set
        End Property
        Public Property MScrapPercentage() As String
            Get
                Return _MScrapPercentage
            End Get
            Set(ByVal Value As String)
                _MScrapPercentage = Value
            End Set
        End Property
        Public Property MPrintComponent() As String
            Get
                Return _MPrintComponent
            End Get
            Set(ByVal Value As String)
                _MPrintComponent = Value
            End Set
        End Property
        Public Property MComponentSeq() As String
            Get
                Return _MComponentSeq
            End Get
            Set(ByVal Value As String)
                _MComponentSeq = Value
            End Set
        End Property
        Public Property MQtyChangesFlag() As String
            Get
                Return _MQtyChangesFlag
            End Get
            Set(ByVal Value As String)
                _MQtyChangesFlag = Value
            End Set
        End Property
        Public Property MOptionalFlag() As String
            Get
                Return _MOptionalFlag
            End Get
            Set(ByVal Value As String)
                _MOptionalFlag = Value
            End Set
        End Property
        Public Property MDecimals() As String
            Get
                Return _MDecimals
            End Get
            Set(ByVal Value As String)
                _MDecimals = Value
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
        Public Property MCommissionCode() As String
            Get
                Return _MCommissionCode
            End Get
            Set(ByVal Value As String)
                _MCommissionCode = Value
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
        Public Property MTaxCode() As String
            Get
                Return _MTaxCode
            End Get
            Set(ByVal Value As String)
                _MTaxCode = Value
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
        Public Property MAllocStatSched() As String
            Get
                Return _MAllocStatSched
            End Get
            Set(ByVal Value As String)
                _MAllocStatSched = Value
            End Set
        End Property
        Public Property MFstTaxCode() As String
            Get
                Return _MFstTaxCode
            End Get
            Set(ByVal Value As String)
                _MFstTaxCode = Value
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
        Public Property MTraceableType() As String
            Get
                Return _MTraceableType
            End Get
            Set(ByVal Value As String)
                _MTraceableType = Value
            End Set
        End Property
        Public Property MMpsFlag() As String
            Get
                Return _MMpsFlag
            End Get
            Set(ByVal Value As String)
                _MMpsFlag = Value
            End Set
        End Property
        Public Property MPickingSlip() As String
            Get
                Return _MPickingSlip
            End Get
            Set(ByVal Value As String)
                _MPickingSlip = Value
            End Set
        End Property
        Public Property MMovementReqd() As String
            Get
                Return _MMovementReqd
            End Get
            Set(ByVal Value As String)
                _MMovementReqd = Value
            End Set
        End Property
        Public Property MSerialMethod() As String
            Get
                Return _MSerialMethod
            End Get
            Set(ByVal Value As String)
                _MSerialMethod = Value
            End Set
        End Property
        Public Property MZeroQtyCrNote() As String
            Get
                Return _MZeroQtyCrNote
            End Get
            Set(ByVal Value As String)
                _MZeroQtyCrNote = Value
            End Set
        End Property
        Public Property MAbcApplied() As String
            Get
                Return _MAbcApplied
            End Get
            Set(ByVal Value As String)
                _MAbcApplied = Value
            End Set
        End Property
        Public Property MMpsGrossReqd() As String
            Get
                Return _MMpsGrossReqd
            End Get
            Set(ByVal Value As String)
                _MMpsGrossReqd = Value
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
        Public Property MCusRetailPrice() As String
            Get
                Return _MCusRetailPrice
            End Get
            Set(ByVal Value As String)
                _MCusRetailPrice = Value
            End Set
        End Property
        Public Property TotalValue() As String
            Get
                Return _TotalValue
            End Get
            Set(ByVal Value As String)
                _TotalValue = Value
            End Set
        End Property
        Public Property MTariffCode() As String
            Get
                Return _MTariffCode
            End Get
            Set(ByVal Value As String)
                _MTariffCode = Value
            End Set
        End Property
        Public Property MLineReceiptDat() As String
            Get
                Return _MLineReceiptDat
            End Get
            Set(ByVal Value As String)
                _MLineReceiptDat = Value
            End Set
        End Property
        Public Property MLeadTime() As String
            Get
                Return _MLeadTime
            End Get
            Set(ByVal Value As String)
                _MLeadTime = Value
            End Set
        End Property
        Public Property MTrfCostMult() As String
            Get
                Return _MTrfCostMult
            End Get
            Set(ByVal Value As String)
                _MTrfCostMult = Value
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
        Public Property MReviewFlag() As String
            Get
                Return _MReviewFlag
            End Get
            Set(ByVal Value As String)
                _MReviewFlag = Value
            End Set
        End Property
        Public Property MReviewStatus() As String
            Get
                Return _MReviewStatus
            End Get
            Set(ByVal Value As String)
                _MReviewStatus = Value
            End Set
        End Property
        Public Property MInvoicePrinted() As String
            Get
                Return _MInvoicePrinted
            End Get
            Set(ByVal Value As String)
                _MInvoicePrinted = Value
            End Set
        End Property
        Public Property MDelNotePrinted() As String
            Get
                Return _MDelNotePrinted
            End Get
            Set(ByVal Value As String)
                _MDelNotePrinted = Value
            End Set
        End Property
        Public Property MOrdAckPrinted() As String
            Get
                Return _MOrdAckPrinted
            End Get
            Set(ByVal Value As String)
                _MOrdAckPrinted = Value
            End Set
        End Property
        Public Property MLastDelNote() As String
            Get
                Return _MLastDelNote
            End Get
            Set(ByVal Value As String)
                _MLastDelNote = Value
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
        Public Property MQtyDispatched() As String
            Get
                Return _MQtyDispatched
            End Get
            Set(ByVal Value As String)
                _MQtyDispatched = Value
            End Set
        End Property
        Public Property MDiscChanged() As String
            Get
                Return _MDiscChanged
            End Get
            Set(ByVal Value As String)
                _MDiscChanged = Value
            End Set
        End Property
        Public Property MCreditOrderNo() As String
            Get
                Return _MCreditOrderNo
            End Get
            Set(ByVal Value As String)
                _MCreditOrderNo = Value
            End Set
        End Property
        Public Property MCreditOrderLine() As String
            Get
                Return _MCreditOrderLine
            End Get
            Set(ByVal Value As String)
                _MCreditOrderLine = Value
            End Set
        End Property
        Public Property MUnitQuantity() As String
            Get
                Return _MUnitQuantity
            End Get
            Set(ByVal Value As String)
                _MUnitQuantity = Value
            End Set
        End Property
        Public Property MConvFactUnitQ() As String
            Get
                Return _MConvFactUnitQ
            End Get
            Set(ByVal Value As String)
                _MConvFactUnitQ = Value
            End Set
        End Property
        Public Property MAltUomUnitQ() As String
            Get
                Return _MAltUomUnitQ
            End Get
            Set(ByVal Value As String)
                _MAltUomUnitQ = Value
            End Set
        End Property
        Public Property MDecimalsUnitQ() As String
            Get
                Return _MDecimalsUnitQ
            End Get
            Set(ByVal Value As String)
                _MDecimalsUnitQ = Value
            End Set
        End Property
        Public Property MEccFlag() As String
            Get
                Return _MEccFlag
            End Get
            Set(ByVal Value As String)
                _MEccFlag = Value
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
        Public Property MCommitDate() As String
            Get
                Return _MCommitDate
            End Get
            Set(ByVal Value As String)
                _MCommitDate = Value
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
                .DispatchNoteLine = rootRow.Item("DispatchNoteLine").ToString
                .MStockCode = rootRow.Item("MStockCode").ToString
                .MStockDes = rootRow.Item("MStockDes").ToString
                .LongDesc = rootRow.Item("LongDesc").ToString
                .MWarehouse = rootRow.Item("MWarehouse").ToString
                .SalesOrderLine = rootRow.Item("SalesOrderLine").ToString
                .MBin = rootRow.Item("MBin").ToString
                .DispatchStatus = rootRow.Item("DispatchStatus").ToString
                .MCusSupStkCode = rootRow.Item("MCusSupStkCode").ToString
                .OverUnderFlag = rootRow.Item("OverUnderFlag").ToString
                .StockDepleted = rootRow.Item("StockDepleted").ToString
                .MOrderQty = rootRow.Item("MOrderQty").ToString
                .MOrderQtyInStockingUm = rootRow.Item("MOrderQtyInStockingUm").ToString
                .MQtyToDispatch = rootRow.Item("MQtyToDispatch").ToString
                .MStockQtyToShp = rootRow.Item("MStockQtyToShp").ToString
                .MBackOrderQty = rootRow.Item("MBackOrderQty").ToString
                .MBackOrderQtyInStockingUm = rootRow.Item("MBackOrderQtyInStockingUm").ToString
                .MMulDivQtyFct = rootRow.Item("MMulDivQtyFct").ToString
                'This field occurs twice in the xmlOUT!!!! .MConvFactAlloc = rootRow.Item("MConvFactAlloc").ToString
                .MOrderUom = rootRow.Item("MOrderUom").ToString
                .MStockingUom = rootRow.Item("MStockingUom").ToString
                .MStockUnitMass = rootRow.Item("MStockUnitMass").ToString
                .MStockUnitVol = rootRow.Item("MStockUnitVol").ToString
                .MPrice = rootRow.Item("MPrice").ToString
                .MPriceUom = rootRow.Item("MPriceUom").ToString
                .ConfirmationDate = rootRow.Item("ConfirmationDate").ToString
                .ConfirmationLine = rootRow.Item("ConfirmationLine").ToString
                .OrigShipSoUom = rootRow.Item("OrigShipSoUom").ToString
                .OrigShipStkUom = rootRow.Item("OrigShipStkUom").ToString
                .OrigBoSoUom = rootRow.Item("OrigBoSoUom").ToString
                .MDiscValFlag = rootRow.Item("MDiscValFlag").ToString
                .MDiscPct1 = rootRow.Item("MDiscPct1").ToString
                .MDiscPct2 = rootRow.Item("MDiscPct2").ToString
                .MDiscPct3 = rootRow.Item("MDiscPct3").ToString
                .OrderLineValue = rootRow.Item("OrderLineValue").ToString
                .MCustRequestDat = rootRow.Item("MCustRequestDat").ToString
                .MHierarchyJob = rootRow.Item("MHierarchyJob").ToString
                .MUnitCost = rootRow.Item("MUnitCost").ToString
                .MBomFlag = rootRow.Item("MBomFlag").ToString
                .MParentKitType = rootRow.Item("MParentKitType").ToString
                .MQtyPer = rootRow.Item("MQtyPer").ToString
                .MScrapPercentage = rootRow.Item("MScrapPercentage").ToString
                .MPrintComponent = rootRow.Item("MPrintComponent").ToString
                .MComponentSeq = rootRow.Item("MComponentSeq").ToString
                .MQtyChangesFlag = rootRow.Item("MQtyChangesFlag").ToString
                .MOptionalFlag = rootRow.Item("MOptionalFlag").ToString
                .MDecimals = rootRow.Item("MDecimals").ToString
                .MConvFactOrdUm = rootRow.Item("MConvFactOrdUm").ToString
                .MMulDivPrcFct = rootRow.Item("MMulDivPrcFct").ToString
                .MCommissionCode = rootRow.Item("MCommissionCode").ToString
                .MProductClass = rootRow.Item("MProductClass").ToString
                .MTaxCode = rootRow.Item("MTaxCode").ToString
                .MLineShipDate = rootRow.Item("MLineShipDate").ToString
                .MAllocStatSched = rootRow.Item("MAllocStatSched").ToString
                .MFstTaxCode = rootRow.Item("MFstTaxCode").ToString
                .MPriceCode = rootRow.Item("MPriceCode").ToString
                .MTraceableType = rootRow.Item("MTraceableType").ToString
                .MMpsFlag = rootRow.Item("MMpsFlag").ToString
                .MPickingSlip = rootRow.Item("MPickingSlip").ToString
                .MMovementReqd = rootRow.Item("MMovementReqd").ToString
                .MSerialMethod = rootRow.Item("MSerialMethod").ToString
                .MZeroQtyCrNote = rootRow.Item("MZeroQtyCrNote").ToString
                .MAbcApplied = rootRow.Item("MAbcApplied").ToString
                .MMpsGrossReqd = rootRow.Item("MMpsGrossReqd").ToString
                .MContract = rootRow.Item("MContract").ToString
                .MBuyingGroup = rootRow.Item("MBuyingGroup").ToString
                .MCusRetailPrice = rootRow.Item("MCusRetailPrice").ToString
                .TotalValue = rootRow.Item("TotalValue").ToString
                .MTariffCode = rootRow.Item("MTariffCode").ToString
                .MLineReceiptDat = rootRow.Item("MLineReceiptDat").ToString
                .MLeadTime = rootRow.Item("MLeadTime").ToString
                .MTrfCostMult = rootRow.Item("MTrfCostMult").ToString
                .MSupplementaryUn = rootRow.Item("MSupplementaryUn").ToString
                .MReviewFlag = rootRow.Item("MReviewFlag").ToString
                .MReviewStatus = rootRow.Item("MReviewStatus").ToString
                .MInvoicePrinted = rootRow.Item("MInvoicePrinted").ToString
                .MDelNotePrinted = rootRow.Item("MDelNotePrinted").ToString
                .MOrdAckPrinted = rootRow.Item("MOrdAckPrinted").ToString
                .MLastDelNote = rootRow.Item("MLastDelNote").ToString
                .MUserDef = rootRow.Item("MUserDef").ToString
                .MQtyDispatched = rootRow.Item("MQtyDispatched").ToString
                .MDiscChanged = rootRow.Item("MDiscChanged").ToString
                .MCreditOrderNo = rootRow.Item("MCreditOrderNo").ToString
                .MCreditOrderLine = rootRow.Item("MCreditOrderLine").ToString
                .MUnitQuantity = rootRow.Item("MUnitQuantity").ToString
                .MConvFactUnitQ = rootRow.Item("MConvFactUnitQ").ToString
                .MAltUomUnitQ = rootRow.Item("MAltUomUnitQ").ToString
                .MDecimalsUnitQ = rootRow.Item("MDecimalsUnitQ").ToString
                .MEccFlag = rootRow.Item("MEccFlag").ToString
                .MVersion = rootRow.Item("MVersion").ToString
                .MRelease = rootRow.Item("MRelease").ToString
                .MCommitDate = rootRow.Item("MCommitDate").ToString

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
