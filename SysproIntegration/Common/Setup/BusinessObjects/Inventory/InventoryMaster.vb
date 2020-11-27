Namespace SetupObjects
    ''' -----------------------------------------------------------------------------
    ''' Project	 : SysproIntegration
    ''' Class	 : SysproIntegration.InvMaster
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' E.Net Stock Code Setup Business Object.  Use with the Setup.[Add|Update|Delete] methods.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	20/04/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class InventoryMaster
        Implements ISetup

        Const _BusinessObject As String = "INVSST"

#Region "Local Variables"

        Private _StockCode As String 'max 30
        Private _Description As String 'max 30
        Private _LongDesc As String  'max 30
        Private _AlternateKey1 As String  'max 20
        Private _AlternateKey2 As String  'max 6
        Private _EccUser As String  'max 6
        Private _StockUom As String 'max 3
        Private _AlternateUom As String 'max 30
        Private _OtherUom As String 'max 3
        Private _ConvFactAltUom As Decimal '6.4 Positive Numeric
        Private _ConvMulDiv As CommonEnums.ConvEnum = CommonEnums.ConvEnum.Multiply '
        Private _ConvFactOthUom As Decimal '6.4 Positive Numeric
        Private _MulDiv As CommonEnums.ConvEnum = CommonEnums.ConvEnum.Multiply '
        Private _Mass As Decimal '6.6 Positive numeric
        Private _Volume As Decimal '6.6 Positive numeric
        Private _Decimals As Integer '1 digit max 3
        Private _PriceCategory As String = "A" '1 character alpha
        Private _PriceMethod As CommonEnums.PriceMethodEnum '
        Private _Supplier As String 'max 7
        Private _CycleCount As Integer '2 digits
        Private _ProductClass As String 'max 4
        Private _TaxCode As String 'max 1
        Private _OtherTaxCode As String '1 digit
        Private _ListPriceCode As String 'max 2
        Private _SerialMethod As CommonEnums.SerialMethodEnum = CommonEnums.SerialMethodEnum.None '
        Private _KitType As CommonEnums.KitTypeEnum = CommonEnums.KitTypeEnum.None '
        Private _Buyer As String 'max 3
        Private _Planner As String 'max 3
        Private _TraceableType As CommonEnums.TraceableTypeEnum = CommonEnums.TraceableTypeEnum.NonTraceable '
        Private _MpsFlag As CommonEnums.MPSFlagEnum '
        Private _BulkIssueFlag As CommonEnums.BulkIssueFlagEnum = CommonEnums.BulkIssueFlagEnum.No '
        Private _LeadTime As Integer '3 digits positive numeric
        Private _StockMovementReq As CommonEnums.YesNoEnum '
        Private _ClearingFlag As CommonEnums.ClearingFlagEnum = CommonEnums.ClearingFlagEnum.Normal '
        Private _SupercessionDate As Date '
        Private _AbcAnalysisReq As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes '
        Private _AbcCostingReq As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _CostUom As String 'max 3
        Private _MinPricePct As Integer  '2 digits
        Private _LabourCost As Decimal  '10.5 numeric
        Private _MaterialCost As Decimal  '10.5 numeric
        Private _FixOverhead As Decimal  '10.5 numeric
        Private _SubContractCost As Decimal  '12.5 positive numeric
        Private _VariableOverhead As Decimal  '10.5 numeric
        Private _PartCategory As CommonEnums.PartCategoryEnum = CommonEnums.PartCategoryEnum.Bought '
        Private _DrawOfficeNum As String 'max 32
        Private _WarehouseToUse As String 'max 2
        Private _BuyingRule As CommonEnums.BuyingRuleEnum = CommonEnums.BuyingRuleEnum.A_Lot_for_lot '
        Private _SpecificGravity As Decimal '2.4 positive numeric
        Private _Ebq As Integer '7.3 positive numeric
        Private _FixTimePeriod As Integer '2 digits
        Private _PanSize As Decimal '7.3 positive numeric
        Private _DockToStock As Integer '3 digits positive numeric
        Private _OutputMassFlag As CommonEnums.OutputMassFlagEnum '
        Private _ShelfLife As Integer 'max 4 digits
        Private _Version As String  'max 3
        Private _Release As String  'max 3
        Private _DemandTimeFence As Integer '3 digits positive numeric
        Private _MakeToOrderFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _ManufLeadTime As Integer  '3 digits positive numeric
        Private _GrossReqRule As CommonEnums.GrossRequirementsRuleEnum '
        Private _PercentageYield As Integer '3 digits positive numeric
        Private _WipCtlGlCode As String  'max 15
        Private _ResourceCode As String  'max 15
        Private _GstTaxCode As String  '1 Digit
        Private _PrcInclGst As CommonEnums.YesNoEnum '
        Private _SerEntryAtSale As String = ""  'Y or Blank
        Private _UserField1 As String  'max 10
        Private _UserField2 As Decimal  '12.5 positive numeric
        Private _UserField3 As String  'max 1
        Private _UserField4 As String  'max 1
        Private _UserField5 As String  'max 1
        Private _TariffCode As String  'max 15
        Private _SupplementaryUnit As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _EbqPan As CommonEnums.EbqPanEnum '
        Private _LctRequired As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _IssMultLotsFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes '
        Private _InclInStrValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes '
        Private _CountryOfOrigin As String  'max 3
        Private _StockOnHold As String = " "  '1 digit: Blank, P or F
        Private _StockOnHoldReason As String  'max 6
        Private _EccFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _StockAndAltUm As CommonEnums.YesNoEnum '
        Private _BatchBill As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _DistWarehouseToUse As String 'max 2
        Private _JobClassification As String  'max 4
        Private _ActionType As CommonEnums.ActionTypeEnum
        Private _ApplyProductClassDefault As String
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ValidateAgainstConfiguration As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _InspectionFlag As CommonEnums.InspectionFlag = CommonEnums.InspectionFlag.Yes
        Private _serialPrefix As String
        Private _serialSuffix As String

        Private _DescriptionSpecified As Boolean = False
        Private _LongDescSpecified As Boolean = False
        Private _AlternateKey1Specified As Boolean = False
        Private _AlternateKey2Specified As Boolean = False
        Private _EccUserSpecified As Boolean = False
        Private _StockUomSpecified As Boolean = False
        Private _AlternateUomSpecified As Boolean = False
        Private _OtherUomSpecified As Boolean = False
        Private _ConvFactAltUomSpecified As Boolean = False
        Private _ConvMulDivSpecified As Boolean = False
        Private _ConvFactOthUomSpecified As Boolean = False
        Private _MulDivSpecified As Boolean = False
        Private _MassSpecified As Boolean = False
        Private _VolumeSpecified As Boolean = False
        Private _DecimalsSpecified As Boolean = False
        Private _PriceCategorySpecified As Boolean = False
        Private _PriceMethodSpecified As Boolean = False
        Private _SupplierSpecified As Boolean = False
        Private _CycleCountSpecified As Boolean = False
        Private _ProductClassSpecified As Boolean = False
        Private _TaxCodeSpecified As Boolean = False
        Private _OtherTaxCodeSpecified As Boolean = False
        Private _ListPriceCodeSpecified As Boolean = False
        Private _SerialMethodSpecified As Boolean = False
        Private _KitTypeSpecified As Boolean = False
        Private _BuyerSpecified As Boolean = False
        Private _PlannerSpecified As Boolean = False
        Private _TraceableTypeSpecified As Boolean = False
        Private _MpsFlagSpecified As Boolean = False
        Private _BulkIssueFlagSpecified As Boolean = False
        Private _LeadTimeSpecified As Boolean = False
        Private _StockMovementReqSpecified As Boolean = False
        Private _ClearingFlagSpecified As Boolean = False
        Private _SupercessionDateSpecified As Boolean = False
        Private _AbcAnalysisReqSpecified As Boolean = False
        Private _AbcCostingReqSpecified As Boolean = False
        Private _CostUomSpecified As Boolean = False
        Private _MinPricePctSpecified As Boolean = False
        Private _LabourCostSpecified As Boolean = False
        Private _MaterialCostSpecified As Boolean = False
        Private _FixOverheadSpecified As Boolean = False
        Private _SubContractCostSpecified As Boolean = False
        Private _VariableOverheadSpecified As Boolean = False
        Private _PartCategorySpecified As Boolean = False
        Private _DrawOfficeNumSpecified As Boolean = False
        Private _WarehouseToUseSpecified As Boolean = False
        Private _BuyingRuleSpecified As Boolean = False
        Private _SpecificGravitySpecified As Boolean = False
        Private _EbqSpecified As Boolean = False
        Private _FixTimePeriodSpecified As Boolean = False
        Private _PanSizeSpecified As Boolean = False
        Private _DockToStockSpecified As Boolean = False
        Private _OutputMassFlagSpecified As Boolean = False
        Private _ShelfLifeSpecified As Boolean = False
        Private _VersionSpecified As Boolean = False
        Private _ReleaseSpecified As Boolean = False
        Private _DemandTimeFenceSpecified As Boolean = False
        Private _MakeToOrderFlagSpecified As Boolean = False
        Private _ManufLeadTimeSpecified As Boolean = False
        Private _GrossReqRuleSpecified As Boolean = False
        Private _PercentageYieldSpecified As Boolean = False
        Private _WipCtlGlCodeSpecified As Boolean = False
        Private _ResourceCodeSpecified As Boolean = False
        Private _GstTaxCodeSpecified As Boolean = False
        Private _PrcInclGstSpecified As Boolean = False
        Private _SerEntryAtSaleSpecified As Boolean = False
        Private _UserField1Specified As Boolean = False
        Private _UserField2Specified As Boolean = False
        Private _UserField3Specified As Boolean = False
        Private _UserField4Specified As Boolean = False
        Private _UserField5Specified As Boolean = False
        Private _TariffCodeSpecified As Boolean = False
        Private _SupplementaryUnitSpecified As Boolean = False
        Private _EbqPanSpecified As Boolean = False
        Private _LctRequiredSpecified As Boolean = False
        Private _IssMultLotsFlagSpecified As Boolean = False
        Private _InclInStrValidSpecified As Boolean = False
        Private _CountryOfOriginSpecified As Boolean = False
        Private _StockOnHoldSpecified As Boolean = False
        Private _StockOnHoldReasonSpecified As Boolean = False
        Private _EccFlagSpecified As Boolean = False
        Private _StockAndAltUmSpecified As Boolean = False
        Private _BatchBillSpecified As Boolean = False
        Private _DistWarehouseToUseSpecified As Boolean = False
        Private _JobClassificationSpecified As Boolean = False
        Private _ActionTypeSpecified As Boolean = False
        Private _ApplyProductClassDefaultSpecified As Boolean = False
        Private _ApplyIfEntireDocumentValidSpecified As Boolean = False
        Private _IgnoreWarningsSpecified As Boolean = False
        Private _ValidateOnlySpecified As Boolean = False
        Private _ValidateAgainstConfigurationSpecified As Boolean = False
        Private _InspectionFlagSpecified As Boolean = False
        Private _serialPrefixSpecified As Boolean = False
        Private _serialSuffixSpecified As Boolean = False

#End Region

#Region "Properties"
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value : _DescriptionSpecified = True
            End Set
        End Property
        Public Property LongDesc() As String
            Get
                Return _LongDesc
            End Get
            Set(ByVal Value As String)
                _LongDesc = Value : _LongDescSpecified = True
            End Set
        End Property
        Public Property AlternateKey1() As String
            Get
                Return _AlternateKey1
            End Get
            Set(ByVal Value As String)
                _AlternateKey1 = Value : _AlternateKey1Specified = True
            End Set
        End Property
        Public Property AlternateKey2() As String
            Get
                Return _AlternateKey2
            End Get
            Set(ByVal Value As String)
                _AlternateKey2 = Value : _AlternateKey2Specified = True
            End Set
        End Property
        Public Property EccUser() As String
            Get
                Return _EccUser
            End Get
            Set(ByVal Value As String)
                _EccUser = Value : _EccUserSpecified = True
            End Set
        End Property
        Public Property StockUom() As String
            Get
                Return _StockUom
            End Get
            Set(ByVal Value As String)
                _StockUom = Value : _StockUomSpecified = True
            End Set
        End Property
        Public Property AlternateUom() As String
            Get
                Return _AlternateUom
            End Get
            Set(ByVal Value As String)
                _AlternateUom = Value : _AlternateUomSpecified = True
            End Set
        End Property
        Public Property OtherUom() As String
            Get
                Return _OtherUom
            End Get
            Set(ByVal Value As String)
                _OtherUom = Value : _OtherUomSpecified = True
            End Set
        End Property
        Public Property ConvFactAltUom() As Decimal
            Get
                Return _ConvFactAltUom
            End Get
            Set(ByVal Value As Decimal)
                _ConvFactAltUom = Value : _ConvFactAltUomSpecified = True
            End Set
        End Property
        Public Property ConvMulDiv() As CommonEnums.ConvEnum
            Get
                Return _ConvMulDiv
            End Get
            Set(ByVal Value As CommonEnums.ConvEnum)
                _ConvMulDiv = Value : _ConvMulDivSpecified = True
            End Set
        End Property
        Public Property ConvFactOthUom() As Decimal
            Get
                Return _ConvFactOthUom
            End Get
            Set(ByVal Value As Decimal)
                _ConvFactOthUom = Value : _ConvFactOthUomSpecified = True
            End Set
        End Property
        Public Property MulDiv() As CommonEnums.ConvEnum
            Get
                Return _MulDiv
            End Get
            Set(ByVal Value As CommonEnums.ConvEnum)
                _MulDiv = Value : _MulDivSpecified = True
            End Set
        End Property
        Public Property Mass() As Decimal
            Get
                Return _Mass
            End Get
            Set(ByVal Value As Decimal)
                _Mass = Value : _MassSpecified = True
            End Set
        End Property
        Public Property Volume() As Decimal
            Get
                Return _Volume
            End Get
            Set(ByVal Value As Decimal)
                _Volume = Value : _VolumeSpecified = True
            End Set
        End Property
        Public Property Decimals() As Integer
            Get
                Return _Decimals
            End Get
            Set(ByVal Value As Integer)
                _Decimals = Value : _DecimalsSpecified = True
            End Set
        End Property
        Public Property PriceCategory() As String
            Get
                Return _PriceCategory
            End Get
            Set(ByVal Value As String)
                _PriceCategory = Value : _PriceCategorySpecified = True
            End Set
        End Property
        Public Property PriceMethod() As CommonEnums.PriceMethodEnum
            Get
                Return _PriceMethod
            End Get
            Set(ByVal Value As CommonEnums.PriceMethodEnum)
                _PriceMethod = Value : _PriceMethodSpecified = True
            End Set
        End Property
        Public Property Supplier() As String
            Get
                Return _Supplier
            End Get
            Set(ByVal Value As String)
                _Supplier = Value : _SupplierSpecified = True
            End Set
        End Property
        Public Property CycleCount() As Integer
            Get
                Return _CycleCount
            End Get
            Set(ByVal Value As Integer)
                _CycleCount = Value : _CycleCountSpecified = True
            End Set
        End Property
        Public Property ProductClass() As String
            Get
                Return _ProductClass
            End Get
            Set(ByVal Value As String)
                _ProductClass = Value : _ProductClassSpecified = True
            End Set
        End Property
        Public Property TaxCode() As String
            Get
                Return _TaxCode
            End Get
            Set(ByVal Value As String)
                _TaxCode = Value : _TaxCodeSpecified = True
            End Set
        End Property
        Public Property OtherTaxCode() As String
            Get
                Return _OtherTaxCode
            End Get
            Set(ByVal Value As String)
                _OtherTaxCode = Value : _OtherTaxCodeSpecified = True
            End Set
        End Property
        Public Property ListPriceCode() As String
            Get
                Return _ListPriceCode
            End Get
            Set(ByVal Value As String)
                _ListPriceCode = Value : _ListPriceCodeSpecified = True
            End Set
        End Property
        Public Property SerialMethod() As CommonEnums.SerialMethodEnum
            Get
                Return _SerialMethod
            End Get
            Set(ByVal Value As CommonEnums.SerialMethodEnum)
                _SerialMethod = Value : _SerialMethodSpecified = True
            End Set
        End Property
        Public Property KitType() As CommonEnums.KitTypeEnum
            Get
                Return _KitType
            End Get
            Set(ByVal Value As CommonEnums.KitTypeEnum)
                _KitType = Value : _KitTypeSpecified = True
            End Set
        End Property
        Public Property Buyer() As String
            Get
                Return _Buyer
            End Get
            Set(ByVal Value As String)
                _Buyer = Value : _BuyerSpecified = True
            End Set
        End Property
        Public Property Planner() As String
            Get
                Return _Planner
            End Get
            Set(ByVal Value As String)
                _Planner = Value : _PlannerSpecified = True
            End Set
        End Property
        Public Property TraceableType() As CommonEnums.TraceableTypeEnum
            Get
                Return _TraceableType
            End Get
            Set(ByVal Value As CommonEnums.TraceableTypeEnum)
                _TraceableType = Value : _TraceableTypeSpecified = True
            End Set
        End Property
        Public Property MpsFlag() As CommonEnums.MPSFlagEnum
            Get
                Return _MpsFlag
            End Get
            Set(ByVal Value As CommonEnums.MPSFlagEnum)
                _MpsFlag = Value : _MpsFlagSpecified = True
            End Set
        End Property
        Public Property BulkIssueFlag() As CommonEnums.BulkIssueFlagEnum
            Get
                Return _BulkIssueFlag
            End Get
            Set(ByVal Value As CommonEnums.BulkIssueFlagEnum)
                _BulkIssueFlag = Value : _BulkIssueFlagSpecified = True
            End Set
        End Property
        Public Property LeadTime() As Integer
            Get
                Return _LeadTime
            End Get
            Set(ByVal Value As Integer)
                _LeadTime = Value : _LeadTimeSpecified = True
            End Set
        End Property
        Public Property StockMovementReq() As CommonEnums.YesNoEnum
            Get
                Return _StockMovementReq
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _StockMovementReq = Value : _StockMovementReqSpecified = True
            End Set
        End Property
        Public Property ClearingFlag() As CommonEnums.ClearingFlagEnum
            Get
                Return _ClearingFlag
            End Get
            Set(ByVal Value As CommonEnums.ClearingFlagEnum)
                _ClearingFlag = Value : _ClearingFlagSpecified = True
            End Set
        End Property
        Public Property SupercessionDate() As Date
            Get
                Return _SupercessionDate
            End Get
            Set(ByVal Value As Date)
                _SupercessionDate = Value : _SupercessionDateSpecified = True
            End Set
        End Property
        Public Property AbcAnalysisReq() As CommonEnums.YesNoEnum
            Get
                Return _AbcAnalysisReq
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AbcAnalysisReq = Value : _AbcAnalysisReqSpecified = True
            End Set
        End Property
        Public Property AbcCostingReq() As CommonEnums.YesNoEnum
            Get
                Return _AbcCostingReq
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AbcCostingReq = Value : _AbcCostingReqSpecified = True
            End Set
        End Property
        Public Property CostUom() As String
            Get
                Return _CostUom
            End Get
            Set(ByVal Value As String)
                _CostUom = Value : _CostUomSpecified = True
            End Set
        End Property
        Public Property MinPricePct() As Integer
            Get
                Return _MinPricePct
            End Get
            Set(ByVal Value As Integer)
                _MinPricePct = Value : _MinPricePctSpecified = True
            End Set
        End Property
        Public Property LabourCost() As Decimal
            Get
                Return _LabourCost
            End Get
            Set(ByVal Value As Decimal)
                _LabourCost = Value : _LabourCostSpecified = True
            End Set
        End Property
        Public Property MaterialCost() As Decimal
            Get
                Return _MaterialCost
            End Get
            Set(ByVal Value As Decimal)
                _MaterialCost = Value : _MaterialCostSpecified = True
            End Set
        End Property
        Public Property FixOverhead() As Decimal
            Get
                Return _FixOverhead
            End Get
            Set(ByVal Value As Decimal)
                _FixOverhead = Value : _FixOverheadSpecified = True
            End Set
        End Property
        Public Property SubContractCost() As Decimal
            Get
                Return _SubContractCost
            End Get
            Set(ByVal Value As Decimal)
                _SubContractCost = Value : _SubContractCostSpecified = True
            End Set
        End Property
        Public Property VariableOverhead() As Decimal
            Get
                Return _VariableOverhead
            End Get
            Set(ByVal Value As Decimal)
                _VariableOverhead = Value : _VariableOverheadSpecified = True
            End Set
        End Property
        Public Property PartCategory() As CommonEnums.PartCategoryEnum
            Get
                Return _PartCategory
            End Get
            Set(ByVal Value As CommonEnums.PartCategoryEnum)
                _PartCategory = Value : _PartCategorySpecified = True
            End Set
        End Property
        Public Property DrawOfficeNum() As String
            Get
                Return _DrawOfficeNum
            End Get
            Set(ByVal Value As String)
                _DrawOfficeNum = Value : _DrawOfficeNumSpecified = True
            End Set
        End Property
        Public Property WarehouseToUse() As String
            Get
                Return _WarehouseToUse
            End Get
            Set(ByVal Value As String)
                _WarehouseToUse = Value : _WarehouseToUseSpecified = True
            End Set
        End Property
        Public Property BuyingRule() As CommonEnums.BuyingRuleEnum
            Get
                Return _BuyingRule
            End Get
            Set(ByVal Value As CommonEnums.BuyingRuleEnum)
                _BuyingRule = Value : _BuyingRuleSpecified = True
            End Set
        End Property
        Public Property SpecificGravity() As Decimal
            Get
                Return _SpecificGravity
            End Get
            Set(ByVal Value As Decimal)
                _SpecificGravity = Value : _SpecificGravitySpecified = True
            End Set
        End Property
        Public Property Ebq() As Integer
            Get
                Return _Ebq
            End Get
            Set(ByVal Value As Integer)
                _Ebq = Value : _EbqSpecified = True
            End Set
        End Property
        Public Property FixTimePeriod() As Integer
            Get
                Return _FixTimePeriod
            End Get
            Set(ByVal Value As Integer)
                _FixTimePeriod = Value : _FixTimePeriodSpecified = True
            End Set
        End Property
        Public Property PanSize() As Decimal
            Get
                Return _PanSize
            End Get
            Set(ByVal Value As Decimal)
                _PanSize = Value : _PanSizeSpecified = True
            End Set
        End Property
        Public Property DockToStock() As Integer
            Get
                Return _DockToStock
            End Get
            Set(ByVal Value As Integer)
                _DockToStock = Value : _DockToStockSpecified = True
            End Set
        End Property
        Public Property OutputMassFlag() As CommonEnums.OutputMassFlagEnum
            Get
                Return _OutputMassFlag
            End Get
            Set(ByVal Value As CommonEnums.OutputMassFlagEnum)
                _OutputMassFlag = Value : _OutputMassFlagSpecified = True
            End Set
        End Property
        Public Property ShelfLife() As Integer
            Get
                Return _ShelfLife
            End Get
            Set(ByVal Value As Integer)
                _ShelfLife = Value : _ShelfLifeSpecified = True
            End Set
        End Property
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal Value As String)
                _Version = Value : _VersionSpecified = True
            End Set
        End Property
        Public Property Release() As String
            Get
                Return _Release
            End Get
            Set(ByVal Value As String)
                _Release = Value : _ReleaseSpecified = True
            End Set
        End Property
        Public Property DemandTimeFence() As Integer
            Get
                Return _DemandTimeFence
            End Get
            Set(ByVal Value As Integer)
                _DemandTimeFence = Value : _DemandTimeFenceSpecified = True
            End Set
        End Property
        Public Property MakeToOrderFlag() As CommonEnums.YesNoEnum
            Get
                Return _MakeToOrderFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _MakeToOrderFlag = Value : _MakeToOrderFlagSpecified = True
            End Set
        End Property
        Public Property ManufLeadTime() As Integer
            Get
                Return _ManufLeadTime
            End Get
            Set(ByVal Value As Integer)
                _ManufLeadTime = Value : _ManufLeadTimeSpecified = True
            End Set
        End Property
        Public Property GrossReqRule() As CommonEnums.GrossRequirementsRuleEnum
            Get
                Return _GrossReqRule
            End Get
            Set(ByVal Value As CommonEnums.GrossRequirementsRuleEnum)
                _GrossReqRule = Value : _GrossReqRuleSpecified = True
            End Set
        End Property
        Public Property PercentageYield() As Integer
            Get
                Return _PercentageYield
            End Get
            Set(ByVal Value As Integer)
                _PercentageYield = Value : _PercentageYieldSpecified = True
            End Set
        End Property
        Public Property WipCtlGlCode() As String
            Get
                Return _WipCtlGlCode
            End Get
            Set(ByVal Value As String)
                _WipCtlGlCode = Value : _WipCtlGlCodeSpecified = True
            End Set
        End Property
        Public Property ResourceCode() As String
            Get
                Return _ResourceCode
            End Get
            Set(ByVal Value As String)
                _ResourceCode = Value : _ResourceCodeSpecified = True
            End Set
        End Property
        Public Property GstTaxCode() As String
            Get
                Return _GstTaxCode
            End Get
            Set(ByVal Value As String)
                _GstTaxCode = Value : _GstTaxCodeSpecified = True
            End Set
        End Property
        Public Property PrcInclGst() As CommonEnums.YesNoEnum
            Get
                Return _PrcInclGst
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _PrcInclGst = Value : _PrcInclGstSpecified = True
            End Set
        End Property
        Public Property SerEntryAtSale() As String
            Get
                Return _SerEntryAtSale
            End Get
            Set(ByVal Value As String)
                _SerEntryAtSale = Value : _SerEntryAtSaleSpecified = True
            End Set
        End Property
        Public Property UserField1() As String
            Get
                Return _UserField1
            End Get
            Set(ByVal Value As String)
                _UserField1 = Value : _UserField1Specified = True
            End Set
        End Property
        Public Property UserField2() As Decimal
            Get
                Return _UserField2
            End Get
            Set(ByVal Value As Decimal)
                _UserField2 = Value : _UserField2Specified = True
            End Set
        End Property
        Public Property UserField3() As String
            Get
                Return _UserField3
            End Get
            Set(ByVal Value As String)
                _UserField3 = Value : _UserField3Specified = True
            End Set
        End Property
        Public Property UserField4() As String
            Get
                Return _UserField4
            End Get
            Set(ByVal Value As String)
                _UserField4 = Value : _UserField4Specified = True
            End Set
        End Property
        Public Property UserField5() As String
            Get
                Return _UserField5
            End Get
            Set(ByVal Value As String)
                _UserField5 = Value : _UserField5Specified = True
            End Set
        End Property
        Public Property TariffCode() As String
            Get
                Return _TariffCode
            End Get
            Set(ByVal Value As String)
                _TariffCode = Value : _TariffCodeSpecified = True
            End Set
        End Property
        Public Property SupplementaryUnit() As CommonEnums.YesNoEnum
            Get
                Return _SupplementaryUnit
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _SupplementaryUnit = Value : _SupplementaryUnitSpecified = True
            End Set
        End Property
        Public Property EbqPan() As CommonEnums.EbqPanEnum
            Get
                Return _EbqPan
            End Get
            Set(ByVal Value As CommonEnums.EbqPanEnum)
                _EbqPan = Value : _EbqPanSpecified = True
            End Set
        End Property
        Public Property LctRequired() As CommonEnums.YesNoEnum
            Get
                Return _LctRequired
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _LctRequired = Value : _LctRequiredSpecified = True
            End Set
        End Property
        Public Property IssMultLotsFlag() As CommonEnums.YesNoEnum
            Get
                Return _IssMultLotsFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IssMultLotsFlag = Value : _IssMultLotsFlagSpecified = True
            End Set
        End Property
        Public Property InclInStrValid() As CommonEnums.YesNoEnum
            Get
                Return _InclInStrValid
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _InclInStrValid = Value : _InclInStrValidSpecified = True
            End Set
        End Property
        Public Property CountryOfOrigin() As String
            Get
                Return _CountryOfOrigin
            End Get
            Set(ByVal Value As String)
                _CountryOfOrigin = Value : _CountryOfOriginSpecified = True
            End Set
        End Property
        Public Property StockOnHold() As String
            Get
                Return _StockOnHold
            End Get
            Set(ByVal Value As String)
                _StockOnHold = Value : _StockOnHoldSpecified = True
            End Set
        End Property
        Public Property StockOnHoldReason() As String
            Get
                Return _StockOnHoldReason
            End Get
            Set(ByVal Value As String)
                _StockOnHoldReason = Value : _StockOnHoldReasonSpecified = True
            End Set
        End Property
        Public Property EccFlag() As CommonEnums.YesNoEnum
            Get
                Return _EccFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _EccFlag = Value : _EccFlagSpecified = True
            End Set
        End Property
        Public Property StockAndAltUm() As CommonEnums.YesNoEnum
            Get
                Return _StockAndAltUm
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _StockAndAltUm = Value : _StockAndAltUmSpecified = True
            End Set
        End Property
        Public Property BatchBill() As CommonEnums.YesNoEnum
            Get
                Return _BatchBill
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _BatchBill = Value : _BatchBillSpecified = True
            End Set
        End Property
        Public Property DistWarehouseToUse() As String
            Get
                Return _DistWarehouseToUse
            End Get
            Set(ByVal Value As String)
                _DistWarehouseToUse = Value : _DistWarehouseToUseSpecified = True
            End Set
        End Property
        Public Property JobClassification() As String
            Get
                Return _JobClassification
            End Get
            Set(ByVal Value As String)
                _JobClassification = Value : _JobClassificationSpecified = True
            End Set
        End Property
        Public Property ApplyProductClassDefault() As String
            Get
                Return _ApplyProductClassDefault
            End Get
            Set(ByVal Value As String)
                _ApplyProductClassDefault = Value : _ApplyProductClassDefaultSpecified = True
            End Set
        End Property
        Public Property ApplyIfEntireDocumentValid() As CommonEnums.YesNoEnum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ApplyIfEntireDocumentValid = Value : _ApplyIfEntireDocumentValidSpecified = True
            End Set
        End Property
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = Value : _IgnoreWarningsSpecified = True
            End Set
        End Property
        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value : _ValidateOnlySpecified = True
            End Set
        End Property
        Public Property ValidateAgainstConfiguration() As CommonEnums.YesNoEnum
            Get
                Return _ValidateAgainstConfiguration
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateAgainstConfiguration = Value : _ValidateAgainstConfigurationSpecified = True
            End Set
        End Property
        Public Property InspectionFlag() As CommonEnums.InspectionFlag
            Get
                Return _InspectionFlag
            End Get
            Set(ByVal Value As CommonEnums.InspectionFlag)
                _InspectionFlag = Value : _InspectionFlagSpecified = True
            End Set
        End Property
        Public Property SerialPrefix() As String
            Get
                Return _serialPrefix
            End Get
            Set(ByVal Value As String)
                _serialPrefix = Value : _serialPrefixSpecified = True
            End Set
        End Property
        Public Property SerialSuffix() As String
            Get
                Return _serialSuffix
            End Get
            Set(ByVal Value As String)
                _serialSuffix = Value : _serialSuffixSpecified = True
            End Set
        End Property
#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _ProcessedElement As String
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This returns the StockCode of the posted item after a successful post.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/Stockcode")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This builds and returns the Parameters to be passed to the Setup.[Add|Update|Delete] method.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function ConstructXML_Parameter() As String

            Dim sbXMLParam As New System.Text.StringBuilder
            'Build an XML string to pass parameters
            sbXMLParam.Append("<SetupInvMaster>")
            sbXMLParam.Append("<Parameters>")
            sbXMLParam.AppendFormat("<ApplyProductClassDefault>{0}</ApplyProductClassDefault>", _ApplyProductClassDefault)
            sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(_IgnoreWarnings.ToString, 1))
            sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(_ApplyIfEntireDocumentValid.ToString, 1))
            sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(_ValidateOnly.ToString, 1))
            sbXMLParam.AppendFormat("<ValidateAgainstConfiguration>{0}</ValidateAgainstConfiguration>", Left(_ValidateAgainstConfiguration.ToString, 1))
            sbXMLParam.Append("</Parameters>")
            sbXMLParam.Append("</SetupInvMaster>")

            Return sbXMLParam.ToString
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This builds and returns the Data to be passed to the Setup.[Add|Update|Delete] method.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function ConstructXML_Data() As String

            Dim sbXMLin As New System.Text.StringBuilder

            sbXMLin.Append("<SetupInvMaster>" & vbCrLf)
            sbXMLin.Append("<Item>" & vbCrLf)
            sbXMLin.Append("<Key>" & vbCrLf)
            sbXMLin.AppendFormat("<StockCode>{0}</StockCode>" & vbCrLf, StockCode)
            sbXMLin.Append("</Key>" & vbCrLf)
            If _DescriptionSpecified Then sbXMLin.AppendFormat("<Description>{0}</Description>" & vbCrLf, Replace(Left(_Description, 30), "&", "&amp;"))
            If _LongDescSpecified Then sbXMLin.AppendFormat("<LongDesc>{0}</LongDesc >" & vbCrLf, Replace(Left(_LongDesc, 30), "&", "&amp;"))
            If _AlternateKey1Specified Then sbXMLin.AppendFormat("<AlternateKey1 >{0}</AlternateKey1 >" & vbCrLf, AlternateKey1)
            If _AlternateKey2Specified Then sbXMLin.AppendFormat("<AlternateKey2 >{0}</AlternateKey2 >" & vbCrLf, AlternateKey2)
            If _EccUserSpecified Then sbXMLin.AppendFormat("<EccUser >{0}</EccUser >" & vbCrLf, EccUser)
            If _StockUomSpecified Then sbXMLin.AppendFormat("<StockUom>{0}</StockUom>" & vbCrLf, StockUom)
            If _AlternateUomSpecified Then sbXMLin.AppendFormat("<AlternateUom>{0}</AlternateUom>" & vbCrLf, AlternateUom)
            If _OtherUomSpecified Then sbXMLin.AppendFormat("<OtherUom>{0}</OtherUom>" & vbCrLf, OtherUom)
            If _ConvFactAltUomSpecified Then sbXMLin.AppendFormat("<ConvFactAltUom>{0}</ConvFactAltUom>" & vbCrLf, ConvFactAltUom)
            If _ConvMulDivSpecified Then sbXMLin.AppendFormat("<ConvMulDiv>{0}</ConvMulDiv>" & vbCrLf, Left(ConvMulDiv.ToString, 1))
            If _ConvFactOthUomSpecified Then sbXMLin.AppendFormat("<ConvFactOthUom>{0}</ConvFactOthUom>" & vbCrLf, ConvFactOthUom)
            If _MulDivSpecified Then sbXMLin.AppendFormat("<MulDiv>{0}</MulDiv>" & vbCrLf, Left(MulDiv.ToString, 1))
            If _MassSpecified Then sbXMLin.AppendFormat("<Mass>{0}</Mass>" & vbCrLf, Mass)
            If _VolumeSpecified Then sbXMLin.AppendFormat("<Volume>{0}</Volume>" & vbCrLf, Volume)
            If _DecimalsSpecified Then sbXMLin.AppendFormat("<Decimals>{0}</Decimals>" & vbCrLf, Decimals)
            If _PriceCategorySpecified Then sbXMLin.AppendFormat("<PriceCategory>{0}</PriceCategory>" & vbCrLf, PriceCategory)
            If _PriceMethodSpecified Then sbXMLin.AppendFormat("<PriceMethod>{0}</PriceMethod>" & vbCrLf, Left(PriceMethod.ToString, 1))
            If _SupplierSpecified Then sbXMLin.AppendFormat("<Supplier>{0}</Supplier>" & vbCrLf, Supplier)
            If _CycleCountSpecified Then sbXMLin.AppendFormat("<CycleCount>{0}</CycleCount>" & vbCrLf, CycleCount)
            If _ProductClassSpecified Then sbXMLin.AppendFormat("<ProductClass>{0}</ProductClass>" & vbCrLf, ProductClass)
            If _TaxCodeSpecified Then sbXMLin.AppendFormat("<TaxCode>{0}</TaxCode>" & vbCrLf, TaxCode)
            If _OtherTaxCodeSpecified Then sbXMLin.AppendFormat("<OtherTaxCode>{0}</OtherTaxCode>" & vbCrLf, OtherTaxCode)
            If _ListPriceCodeSpecified Then sbXMLin.AppendFormat("<ListPriceCode>{0}</ListPriceCode>" & vbCrLf, ListPriceCode)
            If _SerialMethodSpecified Then sbXMLin.AppendFormat("<SerialMethod>{0}</SerialMethod>" & vbCrLf, Left(SerialMethod.ToString, 1))
            If _KitTypeSpecified Then sbXMLin.AppendFormat("<KitType>{0}</KitType>" & vbCrLf, Left(KitType.ToString, 1))
            If _BuyerSpecified Then sbXMLin.AppendFormat("<Buyer>{0}</Buyer>" & vbCrLf, Buyer)
            If _PlannerSpecified Then sbXMLin.AppendFormat("<Planner>{0}</Planner>" & vbCrLf, Planner)
            If _TraceableTypeSpecified Then sbXMLin.AppendFormat("<TraceableType>{0}</TraceableType>" & vbCrLf, Left(TraceableType.ToString, 1))
            If _MpsFlagSpecified Then sbXMLin.AppendFormat("<MpsFlag>{0}</MpsFlag>" & vbCrLf, Left(MpsFlag.ToString, 1))
            If _BulkIssueFlagSpecified Then sbXMLin.AppendFormat("<BulkIssueFlag>{0}</BulkIssueFlag>" & vbCrLf, Left(BulkIssueFlag.ToString, 1))
            If _LeadTimeSpecified Then sbXMLin.AppendFormat("<LeadTime>{0}</LeadTime>" & vbCrLf, LeadTime)
            If _StockMovementReqSpecified Then sbXMLin.AppendFormat("<StockMovementReq>{0}</StockMovementReq>" & vbCrLf, Left(StockMovementReq.ToString, 1))
            If _ClearingFlagSpecified Then sbXMLin.AppendFormat("<ClearingFlag>{0}</ClearingFlag>" & vbCrLf, Left(ClearingFlag.ToString, 1))
            If _SupercessionDateSpecified Then sbXMLin.Append("<SupercessionDate />")
            If _AbcAnalysisReqSpecified Then sbXMLin.AppendFormat("<AbcAnalysisReq>{0}</AbcAnalysisReq>" & vbCrLf, Left(AbcAnalysisReq.ToString, 1))
            If _AbcCostingReqSpecified Then sbXMLin.AppendFormat("<AbcCostingReq>{0}</AbcCostingReq>" & vbCrLf, Left(AbcCostingReq.ToString, 1))
            If _CostUomSpecified Then sbXMLin.AppendFormat("<CostUom>{0}</CostUom>" & vbCrLf, CostUom)
            If _MinPricePctSpecified Then sbXMLin.AppendFormat("<MinPricePct >{0}</MinPricePct >" & vbCrLf, MinPricePct)
            If _LabourCostSpecified Then sbXMLin.AppendFormat("<LabourCost >{0}</LabourCost >" & vbCrLf, LabourCost)
            If _MaterialCostSpecified Then sbXMLin.AppendFormat("<MaterialCost >{0}</MaterialCost >" & vbCrLf, MaterialCost)
            If _FixOverheadSpecified Then sbXMLin.AppendFormat("<FixOverhead >{0}</FixOverhead >" & vbCrLf, FixOverhead)
            If _SubContractCostSpecified Then sbXMLin.AppendFormat("<SubContractCost >{0}</SubContractCost >" & vbCrLf, SubContractCost)
            If _VariableOverheadSpecified Then sbXMLin.AppendFormat("<VariableOverhead >{0}</VariableOverhead >" & vbCrLf, VariableOverhead)
            If _PartCategorySpecified Then sbXMLin.AppendFormat("<PartCategory>{0}</PartCategory>" & vbCrLf, Left(PartCategory.ToString, 1))
            If _DrawOfficeNumSpecified Then sbXMLin.AppendFormat("<DrawOfficeNum>{0}</DrawOfficeNum>" & vbCrLf, DrawOfficeNum)
            If _WarehouseToUseSpecified Then sbXMLin.AppendFormat("<WarehouseToUse>{0}</WarehouseToUse>" & vbCrLf, WarehouseToUse)
            If _BuyingRuleSpecified Then sbXMLin.AppendFormat("<BuyingRule>{0}</BuyingRule>" & vbCrLf, Left(BuyingRule.ToString, 1))
            If _SpecificGravitySpecified Then sbXMLin.AppendFormat("<SpecificGravity>{0}</SpecificGravity>" & vbCrLf, SpecificGravity)
            If _EbqSpecified Then sbXMLin.AppendFormat("<Ebq>{0}</Ebq>" & vbCrLf, Ebq)
            If _FixTimePeriodSpecified Then sbXMLin.AppendFormat("<FixTimePeriod>{0}</FixTimePeriod>" & vbCrLf, FixTimePeriod)
            If _PanSizeSpecified Then sbXMLin.AppendFormat("<PanSize>{0}</PanSize>" & vbCrLf, PanSize)
            If _DockToStockSpecified Then sbXMLin.AppendFormat("<DockToStock>{0}</DockToStock>" & vbCrLf, DockToStock)
            If _OutputMassFlagSpecified Then sbXMLin.AppendFormat("<OutputMassFlag>{0}</OutputMassFlag>" & vbCrLf, Left(OutputMassFlag.ToString, 1))
            If _ShelfLifeSpecified Then sbXMLin.AppendFormat("<ShelfLife>{0}</ShelfLife>" & vbCrLf, ShelfLife)
            If _VersionSpecified Then sbXMLin.AppendFormat("<Version >{0}</Version >" & vbCrLf, Version)
            If _ReleaseSpecified Then sbXMLin.AppendFormat("<Release >{0}</Release >" & vbCrLf, Release)
            If _DemandTimeFenceSpecified Then sbXMLin.AppendFormat("<DemandTimeFence>{0}</DemandTimeFence>" & vbCrLf, DemandTimeFence)
            If _MakeToOrderFlagSpecified Then sbXMLin.AppendFormat("<MakeToOrderFlag>{0}</MakeToOrderFlag>" & vbCrLf, Left(MakeToOrderFlag.ToString, 1))
            If _ManufLeadTimeSpecified Then sbXMLin.AppendFormat("<ManufLeadTime >{0}</ManufLeadTime >" & vbCrLf, ManufLeadTime)
            If _GrossReqRuleSpecified Then sbXMLin.AppendFormat("<GrossReqRule>{0}</GrossReqRule>" & vbCrLf, Left(GrossReqRule.ToString, 1))
            If _PercentageYieldSpecified Then sbXMLin.AppendFormat("<PercentageYield>{0}</PercentageYield>" & vbCrLf, PercentageYield)
            If _WipCtlGlCodeSpecified Then sbXMLin.AppendFormat("<WipCtlGlCode >{0}</WipCtlGlCode >" & vbCrLf, WipCtlGlCode)
            If _ResourceCodeSpecified Then sbXMLin.AppendFormat("<ResourceCode >{0}</ResourceCode >" & vbCrLf, ResourceCode)
            If _GstTaxCodeSpecified Then sbXMLin.AppendFormat("<GstTaxCode >{0}</GstTaxCode >" & vbCrLf, GstTaxCode)
            If _PrcInclGstSpecified Then sbXMLin.AppendFormat("<PrcInclGst>{0}</PrcInclGst>" & vbCrLf, Left(PrcInclGst.ToString, 1))
            If _SerEntryAtSaleSpecified Then sbXMLin.AppendFormat("<SerEntryAtSale >{0}</SerEntryAtSale >" & vbCrLf, SerEntryAtSale)
            If _UserField1Specified Then sbXMLin.AppendFormat("<UserField1 >{0}</UserField1 >" & vbCrLf, UserField1)
            If _UserField2Specified Then sbXMLin.AppendFormat("<UserField2 >{0}</UserField2 >" & vbCrLf, UserField2)
            If _UserField3Specified Then sbXMLin.AppendFormat("<UserField3 >{0}</UserField3 >" & vbCrLf, UserField3)
            If _UserField4Specified Then sbXMLin.AppendFormat("<UserField4 >{0}</UserField4 >" & vbCrLf, UserField4)
            If _UserField5Specified Then sbXMLin.AppendFormat("<UserField5 >{0}</UserField5 >" & vbCrLf, UserField5)
            If _TariffCodeSpecified Then sbXMLin.AppendFormat("<TariffCode >{0}</TariffCode >" & vbCrLf, TariffCode)
            If _SupplementaryUnitSpecified Then sbXMLin.AppendFormat("<SupplementaryUnit>{0}</SupplementaryUnit>" & vbCrLf, Left(SupplementaryUnit.ToString, 1))
            If _EbqPanSpecified Then sbXMLin.AppendFormat("<EbqPan>{0}</EbqPan>" & vbCrLf, Left(EbqPan.ToString, 1))
            If _LctRequiredSpecified Then sbXMLin.AppendFormat("<LctRequired>{0}</LctRequired>" & vbCrLf, Left(LctRequired.ToString, 1))
            If _IssMultLotsFlagSpecified Then sbXMLin.AppendFormat("<IssMultLotsFlag>{0}</IssMultLotsFlag>" & vbCrLf, Left(IssMultLotsFlag.ToString, 1))
            If _InclInStrValidSpecified Then sbXMLin.AppendFormat("<InclInStrValid>{0}</InclInStrValid>" & vbCrLf, Left(InclInStrValid.ToString, 1))
            If _CountryOfOriginSpecified Then sbXMLin.AppendFormat("<CountryOfOrigin >{0}</CountryOfOrigin >" & vbCrLf, CountryOfOrigin)
            If _StockOnHoldSpecified Then sbXMLin.AppendFormat("<StockOnHold>{0}</StockOnHold >" & vbCrLf, StockOnHold)
            If _StockOnHoldReasonSpecified Then sbXMLin.AppendFormat("<StockOnHoldReason >{0}</StockOnHoldReason >" & vbCrLf, StockOnHoldReason)
            If _EccFlagSpecified Then sbXMLin.AppendFormat("<EccFlag>{0}</EccFlag>" & vbCrLf, Left(EccFlag.ToString, 1))
            If _StockAndAltUmSpecified Then sbXMLin.AppendFormat("<StockAndAltUm>{0}</StockAndAltUm>" & vbCrLf, Left(StockAndAltUm.ToString, 1))
            If _BatchBillSpecified Then sbXMLin.AppendFormat("<BatchBill>{0}</BatchBill>" & vbCrLf, Left(BatchBill.ToString, 1))
            If _DistWarehouseToUseSpecified Then sbXMLin.AppendFormat("<DistWarehouseToUse>{0}</DistWarehouseToUse>" & vbCrLf, DistWarehouseToUse)
            If _JobClassificationSpecified Then sbXMLin.AppendFormat("<JobClassification>{0}</JobClassification >" & vbCrLf, JobClassification)
            If _InspectionFlagSpecified Then sbXMLin.AppendFormat("<InspectionFlag>{0}</InspectionFlag >" & vbCrLf, Left(InspectionFlag.ToString, 1))
            If _serialPrefixSpecified Then sbXMLin.AppendFormat("<SerialPrefix>{0}</SerialPrefix>" & vbCrLf, _serialPrefix)
            If _serialSuffixSpecified Then sbXMLin.AppendFormat("<SerialSuffix>{0}</SerialSuffix>" & vbCrLf, _serialSuffix)
            sbXMLin.Append("</Item>" & vbCrLf)
            sbXMLin.Append("</SetupInvMaster>")

            Return sbXMLin.ToString
        End Function

#End Region

#Region "Public Object Properties"

        Public Property ActionType() As CommonEnums.ActionType_Setup Implements ISetup.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlData() As String Implements ISetup.xmlData
            Get
                Return ConstructXML_Data()
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ISetup.xmlParam
            Get
                Return ConstructXML_Parameter()
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property
#End Region

#Region "Post Method"

        Public Sub Post() Implements ISetup.Post
            'Using New Microsoft.Practices.EnterpriseLibrary.Logging.Tracer("Trace" + TDBLL.Common.AppSettings.oEnvironmentConfig.EnvironmentKey)
            Select Case _ActionType
                Case CommonEnums.ActionType_Setup.Add
                    _xmlOut = Setup.Add(Me)
                Case CommonEnums.ActionType_Setup.Delete
                    _xmlOut = Setup.Delete(Me)
                Case CommonEnums.ActionType_Setup.Update
                    _xmlOut = Setup.Update(Me)
            End Select
            'Tallbridge.SysproIntegration.Common.SysproUtilities.CheckXMLOut(Me.xmlData, Me.xmlParam, Me._xmlOut)
            'End Using
        End Sub


#End Region

    End Class

End Namespace
