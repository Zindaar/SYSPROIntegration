Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO


Namespace SetupObjects

    <Serializable()> Public Class Customer
        Implements ISetup

        Const _BusinessObject As String = "ARSSCS"


#Region "Private Object Members"

        Private _xmlParam As String
        Private _xmlOut As String
        Private _ActionType As CommonEnums.ActionType_Setup

#End Region

#Region "Private Param Members"

        Dim _ApplyIfEntireDocumentValid As ArCustomerSetup_ApplyIfEntireDocumentValid_Enum = ArCustomerSetup_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_N
        Dim _IgnoreWarnings As ArCustomerSetup_IgnoreWarnings_Enum = ArCustomerSetup_IgnoreWarnings_Enum.IgnoreWarnings_Upper_Y
        Dim _ValidateOnly As ArCustomerSetup_ValidateOnly_Enum = ArCustomerSetup_ValidateOnly_Enum.ValidateOnly_Upper_N

#End Region

#Region "Private Data Members"

        'Dim _Item As String = String.Empty
        '  Dim _Key As String = String.Empty

        Dim _AddTelephone As String = String.Empty
        Dim _ApplyLineDisc As ArCustomerSetup_ApplyLineDisc_Enum
        Dim _ApplyOrdDisc As ArCustomerSetup_ApplyOrdDisc_Enum
        Dim _SetupArCustomer As String = String.Empty
        Dim _Area As String = String.Empty
        Dim _BackOrdReqd As ArCustomerSetup_BackOrdReqd_Enum
        Dim _BalanceType As ArCustomerSetup_BalanceType_Enum
        Dim _Branch As String = String.Empty
        Dim _BuyingGroup1 As String = String.Empty
        Dim _BuyingGroup2 As String = String.Empty
        Dim _BuyingGroup3 As String = String.Empty
        Dim _BuyingGroup4 As String = String.Empty
        Dim _BuyingGroup5 As String = String.Empty
        Dim _City As String = String.Empty
        Dim _City1 As String = String.Empty
        Dim _Contact As String = String.Empty
        Dim _ContractPrcReqd As ArCustomerSetup_ContractPrcReqd_Enum
        Dim _CounterSlsOnly As ArCustomerSetup_CounterSlsOnly_Enum
        Dim _CountyZip As String = String.Empty
        Dim _CountyZip1 As String = String.Empty
        Dim _CreditLimit As String = String.Empty
        Dim _CreditStatus As ArCustomerSetup_CreditStatus_Enum
        Dim _Currency As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _CustomerClass As String = String.Empty
        Dim _CustomerOnHold As ArCustomerSetup_CustomerOnHold_Enum
        Dim _DateCustAdded As String = String.Empty
        Dim _DefaultOrdType As String = String.Empty
        Dim _Warehouse As String = String.Empty
        Dim _DetailMoveReqd As ArCustomerSetup_DetailMoveReqd_Enum
        Dim _DocFax As String = String.Empty
        Dim _DocFaxContact As String = String.Empty
        Dim _EdiFlag As ArCustomerSetup_EdiFlag_Enum
        Dim _EdiSenderCode As String = String.Empty
        Dim _Email As String = String.Empty
        Dim _ExemptFinChg As ArCustomerSetup_ExemptFinChg_Enum
        Dim _Fax As String = String.Empty
        Dim _FaxInvoices As ArCustomerSetup_FaxInvoices_Enum = ArCustomerSetup_FaxInvoices_Enum.FaxInvoices_Upper_N
        Dim _FaxStatements As ArCustomerSetup_FaxStatements_Enum
        Dim _GstExemptFlag As ArCustomerSetup_GstExemptFlag_Enum
        Dim _GstExemptNum As String = String.Empty
        Dim _GstLevel As ArCustomerSetup_GstLevel_Enum
        Dim _HighInv As String = String.Empty
        Dim _HighInvDays As String = String.Empty
        Dim _HighestBalance As String = String.Empty
        Dim _IbtCustomer As ArCustomerSetup_IbtCustomer_Enum
        Dim _InvCommentCode As String = String.Empty
        Dim _InvDiscCode As String = String.Empty
        Dim _FaxQuotes As ArCustomerSetup_FaxQuotes_Enum
        Dim _TransactionNature As String = String.Empty
        Dim _TransactionNatureC As String = String.Empty
        Dim _DeliveryTerms As String = String.Empty
        Dim _DeliveryTermsC As String = String.Empty

        Dim _LineDiscCode As String = String.Empty
        Dim _MaintHistory As ArCustomerSetup_MaintHistory_Enum
        Dim _MaintLastPrcPaid As ArCustomerSetup_MaintLastPrcPaid_Enum
        Dim _Name As String = String.Empty
        Dim _Nationality As String = String.Empty
        Dim _PoNumberMandatory As ArCustomerSetup_PoNumberMandatory_Enum
        Dim _PriceCategoryTable As String = String.Empty
        Dim _PriceCode As String = String.Empty
        Dim _RouteCode As String = String.Empty
        Dim _RouteDistance As String = String.Empty
        Dim _Salesperson As String = String.Empty
        Dim _Salesperson1 As String = String.Empty
        Dim _Salesperson2 As String = String.Empty
        Dim _Salesperson3 As String = String.Empty
        Dim _ShipPostalCode As String = String.Empty
        Dim _ShipToAddr1 As String = String.Empty
        Dim _ShipToAddr2 As String = String.Empty
        Dim _ShipToAddr3 As String = String.Empty
        Dim _ShipToAddr4 As String = String.Empty
        Dim _ShipToAddr5 As String = String.Empty
        Dim _ShippingInstrs As String = String.Empty
        Dim _ShortName As String = String.Empty
        Dim _SoDefaultDoc As ArCustomerSetup_SoDefaultDoc_Enum
        Dim _SoDefaultType As ArCustomerSetup_SoDefaultType_Enum
        Dim _SoldPostalCode As String = String.Empty
        Dim _SoldToAddr1 As String = String.Empty
        Dim _SoldToAddr2 As String = String.Empty
        Dim _SoldToAddr3 As String = String.Empty
        Dim _SoldToAddr4 As String = String.Empty
        Dim _SoldToAddr5 As String = String.Empty
        Dim _SpecialInstrs As String = String.Empty
        Dim _State As String = String.Empty
        Dim _State1 As String = String.Empty
        Dim _StateCode As String = String.Empty
        Dim _StatementReqd As ArCustomerSetup_StatementReqd_Enum
        Dim _StockInterchange As ArCustomerSetup_StockInterchange_Enum
        Dim _TaxExemptNumber As String = String.Empty
        Dim _TaxStatus As ArCustomerSetup_TaxStatus_Enum
        Dim _Telephone As String = String.Empty
        Dim _TelephoneExtn As String = String.Empty
        Dim _Telex As String = String.Empty
        Dim _TermsCode As String = String.Empty
        Dim _TpmCustomerFlag As ArCustomerSetup_TpmCustomerFlag_Enum
        Dim _TpmPricingFlag As ArCustomerSetup_TpmPricingFlag_Enum
        Dim _TpmCreditCheck As ArCustomerSetup_TpmCreditCheck_Enum
        Dim _UserField1 As String = String.Empty
        Dim _UserField2 As String = String.Empty
        Dim _CreditCheckFlag As String = String.Empty

        Dim _AddTelephoneSpecified As Boolean
        Dim _ApplyLineDiscSpecified As Boolean
        Dim _ApplyOrdDiscSpecified As Boolean
        Dim _SetupArCustomerSpecified As Boolean
        Dim _AreaSpecified As Boolean
        Dim _BackOrdReqdSpecified As Boolean
        Dim _BalanceTypeSpecified As Boolean
        Dim _BranchSpecified As Boolean
        Dim _BuyingGroup1Specified As Boolean
        Dim _BuyingGroup2Specified As Boolean
        Dim _BuyingGroup3Specified As Boolean
        Dim _BuyingGroup4Specified As Boolean
        Dim _BuyingGroup5Specified As Boolean
        Dim _CitySpecified As Boolean
        Dim _City1Specified As Boolean
        Dim _ContactSpecified As Boolean
        Dim _ContractPrcReqdSpecified As Boolean
        Dim _CounterSlsOnlySpecified As Boolean
        Dim _CountyZipSpecified As Boolean
        Dim _CountyZip1Specified As Boolean
        Dim _CreditLimitSpecified As Boolean
        Dim _CreditStatusSpecified As Boolean
        Dim _CurrencySpecified As Boolean
        Dim _CustomerSpecified As Boolean
        Dim _CustomerClassSpecified As Boolean
        Dim _CustomerOnHoldSpecified As Boolean
        Dim _DateCustAddedSpecified As Boolean
        Dim _DefaultOrdTypeSpecified As Boolean
        Dim _WarehouseSpecified As Boolean
        Dim _DetailMoveReqdSpecified As Boolean
        Dim _DocFaxSpecified As Boolean
        Dim _DocFaxContactSpecified As Boolean
        Dim _EdiFlagSpecified As Boolean
        Dim _EdiSenderCodeSpecified As Boolean
        Dim _EmailSpecified As Boolean
        Dim _ExemptFinChgSpecified As Boolean
        Dim _FaxSpecified As Boolean
        Dim _FaxInvoicesSpecified As Boolean
        Dim _FaxStatementsSpecified As Boolean
        Dim _GstExemptFlagSpecified As Boolean
        Dim _GstExemptNumSpecified As Boolean
        Dim _GstLevelSpecified As Boolean
        Dim _HighInvSpecified As Boolean
        Dim _HighInvDaysSpecified As Boolean
        Dim _HighestBalanceSpecified As Boolean
        Dim _IbtCustomerSpecified As Boolean
        Dim _InvCommentCodeSpecified As Boolean
        Dim _InvDiscCodeSpecified As Boolean
        Dim _ItemSpecified As Boolean
        Dim _FaxQuotesSpecified As Boolean
        Dim _TransactionNatureSpecified As Boolean
        Dim _TransactionNatureCSpecified As Boolean
        Dim _DeliveryTermsSpecified As Boolean
        Dim _DeliveryTermsCSpecified As Boolean
        Dim _KeySpecified As Boolean
        Dim _LineDiscCodeSpecified As Boolean
        Dim _MaintHistorySpecified As Boolean
        Dim _MaintLastPrcPaidSpecified As Boolean
        Dim _NameSpecified As Boolean
        Dim _NationalitySpecified As Boolean
        Dim _PoNumberMandatorySpecified As Boolean
        Dim _PriceCategoryTableSpecified As Boolean
        Dim _PriceCodeSpecified As Boolean
        Dim _RouteCodeSpecified As Boolean
        Dim _RouteDistanceSpecified As Boolean
        Dim _SalespersonSpecified As Boolean
        Dim _Salesperson1Specified As Boolean
        Dim _Salesperson2Specified As Boolean
        Dim _Salesperson3Specified As Boolean
        Dim _ShipPostalCodeSpecified As Boolean
        Dim _ShipToAddr1Specified As Boolean
        Dim _ShipToAddr2Specified As Boolean
        Dim _ShipToAddr3Specified As Boolean
        Dim _ShipToAddr4Specified As Boolean
        Dim _ShipToAddr5Specified As Boolean
        Dim _ShippingInstrsSpecified As Boolean
        Dim _ShortNameSpecified As Boolean
        Dim _SoDefaultDocSpecified As Boolean
        Dim _SoDefaultTypeSpecified As Boolean
        Dim _SoldPostalCodeSpecified As Boolean
        Dim _SoldToAddr1Specified As Boolean
        Dim _SoldToAddr2Specified As Boolean
        Dim _SoldToAddr3Specified As Boolean
        Dim _SoldToAddr4Specified As Boolean
        Dim _SoldToAddr5Specified As Boolean
        Dim _SpecialInstrsSpecified As Boolean
        Dim _StateSpecified As Boolean
        Dim _State1Specified As Boolean
        Dim _StateCodeSpecified As Boolean
        Dim _StatementReqdSpecified As Boolean
        Dim _StockInterchangeSpecified As Boolean
        Dim _TaxExemptNumberSpecified As Boolean
        Dim _TaxStatusSpecified As Boolean
        Dim _TelephoneSpecified As Boolean
        Dim _TelephoneExtnSpecified As Boolean
        Dim _TelexSpecified As Boolean
        Dim _TermsCodeSpecified As Boolean
        Dim _TpmCustomerFlagSpecified As Boolean
        Dim _TpmPricingFlagSpecified As Boolean
        Dim _TpmCreditCheckSpecified As Boolean
        Dim _UserField1Specified As Boolean
        Dim _UserField2Specified As Boolean
        Dim _CreditCheckFlagSpecified As Boolean


#End Region

#Region "Public Object Properties"

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
                Return Construct_XMLParam()
            End Get
        End Property

        Public Property ActionType() As CommonEnums.ActionType_Setup Implements ISetup.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property xmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property


#End Region

#Region "Public Param Properties"

        ''' <summary> 
        '''  Specifies whether the entire document must be validated first before applying the function (N - apply function for each valid item, Y - all items must be valid before function is applied).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As ArCustomerSetup_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As ArCustomerSetup_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a ledger code entered is not the correct type of account, it is okay to write the record away as such but you may want the warning supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As ArCustomerSetup_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As ArCustomerSetup_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As ArCustomerSetup_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As ArCustomerSetup_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

#End Region

#Region "Public Data Properties"
        ''' <summary> 
        '''  Additional telephone number for the customer. Format is 20 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AddTelephone() As String
            Get
                Return _AddTelephone
            End Get
            Set(ByVal Value As String)
                _AddTelephone = Value : _AddTelephoneSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Calculate order line discounts according to product class sold. Select this option if you want to be able to assign order discount breaks to specific customer/product class combinations. These discounts are applied to the order line value or order line quantity of orders processed against the customer within the Sales Order Order Entry program. All common product classes for an order are accumulated and the total of each product class is compared to the discount break tables and the discount applied to each line accordingly. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyLineDisc() As ArCustomerSetup_ApplyLineDisc_Enum
            Get
                Return _ApplyLineDisc
            End Get
            Set(ByVal Value As ArCustomerSetup_ApplyLineDisc_Enum)
                _ApplyLineDisc = Value : _ApplyLineDiscSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Calculate order discount based on order value/quantity flag. Select this option if you want to be able to assign order discount breaks to this customer. These discounts are applied to the total value or total quantity of an order processed against the customer within the Sales Order Order Entry program. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyOrdDisc() As ArCustomerSetup_ApplyOrdDisc_Enum
            Get
                Return _ApplyOrdDisc
            End Get
            Set(ByVal Value As ArCustomerSetup_ApplyOrdDisc_Enum)
                _ApplyOrdDisc = Value : _ApplyOrdDiscSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SetupArCustomer() As String
            Get
                Return _SetupArCustomer
            End Get
            Set(ByVal Value As String)
                _SetupArCustomer = Value : _SetupArCustomerSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Geographic area is used to classify the customer's location. If you require tax by geographic area (Tax Options Setup) then the tax code assigned to the customer's geographic area can be used to override the tax codes normally used throughout the system. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Area() As String
            Get
                Return _Area
            End Get
            Set(ByVal Value As String)
                _Area = Value : _AreaSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Back orders allowed. Select this option to allow backorder quantities to be entered against the customer during processing in the Sales Order Entry.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BackOrdReqd() As ArCustomerSetup_BackOrdReqd_Enum
            Get
                Return _BackOrdReqd
            End Get
            Set(ByVal Value As ArCustomerSetup_BackOrdReqd_Enum)
                _BackOrdReqd = Value : _BackOrdReqdSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Balance print type flag. Settings are as follows: I - Open item if you do not want the customer's balance to be brought forward at the end of each month. All transactions are retained on file until the outstanding balance reaches zero and the number of months to retain zero balance invoices has been reached (Accounts Receivable Setup). B - Balance forward if you want to accumulate the total amount owing by the customer at the end of each month and represent the figure as a balance brought forward from previous months on the debtors statement. If you require brought forward customers to be consolidated at month end (Accounts Receivable Setup) then at month end all details are accumulated into a series of aged balance figures. Payments, adjustments and transactions are made against a specific aged balance.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BalanceType() As ArCustomerSetup_BalanceType_Enum
            Get
                Return _BalanceType
            End Get
            Set(ByVal Value As ArCustomerSetup_BalanceType_Enum)
                _BalanceType = Value : _BalanceTypeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Branch assigned to the customer is used to integrate sales and payments to the General Ledger module. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Branch() As String
            Get
                Return _Branch
            End Get
            Set(ByVal Value As String)
                _Branch = Value : _BranchSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  First buying group to which the customer is associated. This must be different to all the other buying groups. Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BuyingGroup1() As String
            Get
                Return _BuyingGroup1
            End Get
            Set(ByVal Value As String)
                _BuyingGroup1 = Value : _BuyingGroup1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Second buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the first is blank. Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BuyingGroup2() As String
            Get
                Return _BuyingGroup2
            End Get
            Set(ByVal Value As String)
                _BuyingGroup2 = Value : _BuyingGroup2Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Third buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the second is blank. Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BuyingGroup3() As String
            Get
                Return _BuyingGroup3
            End Get
            Set(ByVal Value As String)
                _BuyingGroup3 = Value : _BuyingGroup3Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fourth buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the third is blank. Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BuyingGroup4() As String
            Get
                Return _BuyingGroup4
            End Get
            Set(ByVal Value As String)
                _BuyingGroup4 = Value : _BuyingGroup4Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fifth buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the fourth is blank. Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property BuyingGroup5() As String
            Get
                Return _BuyingGroup5
            End Get
            Set(ByVal Value As String)
                _BuyingGroup5 = Value : _BuyingGroup5Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the city code that is part of the extended tax code applicable to the sold to address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 3 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property City() As String
            Get
                Return _City
            End Get
            Set(ByVal Value As String)
                _City = Value : _CitySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the city code that is part of the extended tax code applicable to the sold to address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 3 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property City1() As String
            Get
                Return _City1
            End Get
            Set(ByVal Value As String)
                _City1 = Value : _City1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Contact name for the customer. Format is 30 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Contact() As String
            Get
                Return _Contact
            End Get
            Set(ByVal Value As String)
                _Contact = Value : _ContactSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Contract pricing flag. Select this option if you require special prices (or price discounts) for stock items to be available for the customer over a fixed time period. During Sales Order Entry the lowest contract price for the customer is used as the price for the order line. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ContractPrcReqd() As ArCustomerSetup_ContractPrcReqd_Enum
            Get
                Return _ContractPrcReqd
            End Get
            Set(ByVal Value As ArCustomerSetup_ContractPrcReqd_Enum)
                _ContractPrcReqd = Value : _ContractPrcReqdSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Counter sales only. Select this option if you only require counter sales orders to be accepted for the customer during processing in the Sales Order Entry program. This also prevents any part of a counter sales invoice from being placed on account. This option is only used if the Counter Sales module is installed. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CounterSlsOnly() As ArCustomerSetup_CounterSlsOnly_Enum
            Get
                Return _CounterSlsOnly
            End Get
            Set(ByVal Value As ArCustomerSetup_CounterSlsOnly_Enum)
                _CounterSlsOnly = Value : _CounterSlsOnlySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the county or zip code that is part of the extended tax code applicable to the sold to address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 5 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CountyZip() As String
            Get
                Return _CountyZip
            End Get
            Set(ByVal Value As String)
                _CountyZip = Value : _CountyZipSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the county or zip code that is part of the extended tax code applicable to the shipto address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 5 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CountyZip1() As String
            Get
                Return _CountyZip1
            End Get
            Set(ByVal Value As String)
                _CountyZip1 = Value : _CountyZip1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Credit limit is the maximum limit that the customer's balance can reach, taking into account any outstanding order values. Format is 12 characters positive numeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CreditLimit() As String
            Get
                Return _CreditLimit
            End Get
            Set(ByVal Value As String)
                _CreditLimit = Value : _CreditLimitSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Credit status flag indicates the customer's current status based on the age of his oldest invoice. This is calculated by the Balance function of the Period End Processing program. The following describes the status code settings: 0 - indicates only current invoices 1 - indicates at least one invoice which is 30 days or over 2 - indicates at least one invoice which is 60 days or over 3 - indicates at least one invoice which is 90 days or over 4 - indicates at least one invoice which is 120 days or over 5 - indicates at least one invoice which is 150 days or over 6 - indicates at least one invoice which is 180 days or over 9 - indicates a manual hold on the account which suspends all credit for the customer
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CreditStatus() As ArCustomerSetup_CreditStatus_Enum
            Get
                Return _CreditStatus
            End Get
            Set(ByVal Value As ArCustomerSetup_CreditStatus_Enum)
                _CreditStatus = Value : _CreditStatusSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Currency code used to determine the currency in which to process invoices for the customer. Note: If foreign currency sales are not required (Accounts Receivable Setup) or a blank entry is made then the local currency is used. You cannot change a customer's currency once transactions (sales orders etc.) have been processed for that customer. Format is 3 characters alphanumeric. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value : _CurrencySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the key to the customer being maintained. This is mandatory.The format is up to 7 characters, alphanumeric or numeric depending on a configuration option within SYSPRO.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal Value As String)
                _Customer = Value : _CustomerSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Customer class enables you to classify customers into categories for reports and sales history analysis. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerClass() As String
            Get
                Return _CustomerClass
            End Get
            Set(ByVal Value As String)
                _CustomerClass = Value : _CustomerClassSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Customer on hold flag. Select this option if you want to prohibit new orders from being processed for the customer in the Invoice Posting and Sales Order Entry programs. You will also be unable to process adjustments against the customer in the Payments and Adjustments program. ( Y - On hold, N - Not on hold)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerOnHold() As ArCustomerSetup_CustomerOnHold_Enum
            Get
                Return _CustomerOnHold
            End Get
            Set(ByVal Value As ArCustomerSetup_CustomerOnHold_Enum)
                _CustomerOnHold = Value : _CustomerOnHoldSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Date created is the date the customer was initially taken on. If zero then the system date is used. Format is CCYY-MM-DD
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DateCustAdded() As String
            Get
                Return _DateCustAdded
            End Get
            Set(ByVal Value As String)
                _DateCustAdded = Value : _DateCustAddedSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default order type to be used when an order is generated for this customer at header level in the Sales Order Entry program. The entry made here overrides whatever default order type is defined within the Sales Order module. Format is 2 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DefaultOrdType() As String
            Get
                Return _DefaultOrdType
            End Get
            Set(ByVal Value As String)
                _DefaultOrdType = Value : _DefaultOrdTypeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the default warehouse to be used for this customer when entering a sales order. If entered, it must be a valid SYSPRO warehouse.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value : _WarehouseSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Retain detail sales movements against the customer. These detail stock movements can be viewed in the Customer Query program and reported on in the Customer Movements program. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DetailMoveReqd() As ArCustomerSetup_DetailMoveReqd_Enum
            Get
                Return _DetailMoveReqd
            End Get
            Set(ByVal Value As ArCustomerSetup_DetailMoveReqd_Enum)
                _DetailMoveReqd = Value : _DetailMoveReqdSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fax number to use when automatically faxing invoices (FaxInvoices = "Y") and or statements (FaxStatements = "Y") to the customer. If either are set to "Y" then this entry cannot be blank. Format is 20 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DocFax() As String
            Get
                Return _DocFax
            End Get
            Set(ByVal Value As String)
                _DocFax = Value : _DocFaxSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Contact name to add to the invoices/statements being automatically faxed. Format is 40 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DocFaxContact() As String
            Get
                Return _DocFaxContact
            End Get
            Set(ByVal Value As String)
                _DocFaxContact = Value : _DocFaxContactSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  EDI trading partner. Select this option to indicate that the Electronic Data Interchange (EDI) system can be used to generate orders for this customer. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property EdiFlag() As ArCustomerSetup_EdiFlag_Enum
            Get
                Return _EdiFlag
            End Get
            Set(ByVal Value As ArCustomerSetup_EdiFlag_Enum)
                _EdiFlag = Value : _EdiFlagSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  EDI sender code. You use this field to indicate the Sender code of the company from which you import orders electronically via an ASCII file. You can import this file (EDI Sales Order Import) providing that the entry made here matches the sender code of the company transmitting the file (Interface Setup, Local Site). Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property EdiSenderCode() As String
            Get
                Return _EdiSenderCode
            End Get
            Set(ByVal Value As String)
                _EdiSenderCode = Value : _EdiSenderCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Enter the e-mail address for the customer. Format is 50 characters alphanumeric. If the 'FaxInvoices' element or the 'FaxStatements' element has been set to email documents, this element cannot be spaces.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal Value As String)
                _Email = Value : _EmailSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Exempt from finance charge flag indicates whether the customer is exempt from finance charges calculated by the Finance Charge Calculation program. (Y - Exempt, N - Not exempt)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ExemptFinChg() As ArCustomerSetup_ExemptFinChg_Enum
            Get
                Return _ExemptFinChg
            End Get
            Set(ByVal Value As ArCustomerSetup_ExemptFinChg_Enum)
                _ExemptFinChg = Value : _ExemptFinChgSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fax number for the customer. Format is 20 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Fax() As String
            Get
                Return _Fax
            End Get
            Set(ByVal Value As String)
                _Fax = Value : _FaxSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fax invoices flag. This element indicates which S/O documents, if any, are to be automatically faxed or emailed. The valid values are: Spaces or 'N' - No documents faxed or emailed (Default) 'A' - Fax Order ack and Delivery note 'B' - Fax Order ack and Dispatch note 'C' - Fax Order ack and Invoice 'D' - Fax Delivery note and Dispatch note 'E' - Fax Delivery note and Invoice 'F' - Fax Dispatch note and Invoice 'G' - Fax Order ack, Delivery note and Dispatch note 'H' - Fax Order ack, Delivery note and Invoice 'I' - Fax Order ack, Dispatch note and Invoice 'J' - Fax Delivery note, Dispatch note and Invoice 'K' - Fax Order ack, Delivery note, Dispatch note and invoice 'W' - Order ack 'X' - Delivery note 'Y' - Invoice 'Z' - Dispatch note The above codes in lower case will indicate the same combination of documents but to be emailed, eg, 'a' - Email Order ack and Delivery note 'b' - Email Order ack and Dispatch note and so on....
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property FaxInvoices() As ArCustomerSetup_FaxInvoices_Enum
            Get
                Return _FaxInvoices
            End Get
            Set(ByVal Value As ArCustomerSetup_FaxInvoices_Enum)
                _FaxInvoices = Value : _FaxInvoicesSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fax statements flag. Select this option if you wish to automatically fax statements to the customer. (Y - Fax, E - Email, N - Print).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property FaxStatements() As ArCustomerSetup_FaxStatements_Enum
            Get
                Return _FaxStatements
            End Get
            Set(ByVal Value As ArCustomerSetup_FaxStatements_Enum)
                _FaxStatements = Value : _FaxStatementsSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Canadian GST exemption flag. Settings are as follows: E - Exempt to exempt the customer from GST. N - To indicate that GST is applicable to the customer. Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup) 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GstExemptFlag() As ArCustomerSetup_GstExemptFlag_Enum
            Get
                Return _GstExemptFlag
            End Get
            Set(ByVal Value As ArCustomerSetup_GstExemptFlag_Enum)
                _GstExemptFlag = Value : _GstExemptFlagSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Canadian GST exempt number for customer. Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup). Format is 15 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GstExemptNum() As String
            Get
                Return _GstExemptNum
            End Get
            Set(ByVal Value As String)
                _GstExemptNum = Value : _GstExemptNumSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Canadian GST shown by flag. Settings as follows: I - Invoice if you want GST that is calculated on invoice lines to be shown separately in the invoice totals, and not included in the prices. L - Line if you want the GST that is calculated on invoice lines to be included in the line values. For stocked items that have GST included in the price, this option has no effect for non-exempt customers as the GST is already part of the price shown at line level. For exempt customers, the GST value that is part of the price is deducted from the line or the total GST value, depending on your selection at this field. Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GstLevel() As ArCustomerSetup_GstLevel_Enum
            Get
                Return _GstLevel
            End Get
            Set(ByVal Value As ArCustomerSetup_GstLevel_Enum)
                _GstLevel = Value : _GstLevelSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Invoice number of oldest outstanding invoice. These fields are normally updated by the system only. However, during the 'takeon' process of a 'Debtors Book' (New installation or new module) - this information may be available and is useful to the credit controller. Format is 6 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property HighInv() As String
            Get
                Return _HighInv
            End Get
            Set(ByVal Value As String)
                _HighInv = Value : _HighInvSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Age of oldest outstanding invoice. These fields are normally updated by the system only. However, during the 'takeon' process of a 'Debtors Book' (New installation or new module) - this information may be available and is useful to the credit controller. Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property HighInvDays() As String
            Get
                Return _HighInvDays
            End Get
            Set(ByVal Value As String)
                _HighInvDays = Value : _HighInvDaysSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This field is usually one entered during the takeon of a debtors book.Highest balance attained represents the highest balance ever held by the customer and is updated automatically by the system after the initial takeon. Format is 12.2 positive numeric. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property HighestBalance() As String
            Get
                Return _HighestBalance
            End Get
            Set(ByVal Value As String)
                _HighestBalance = Value : _HighestBalanceSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  IBT customer. Select this option if you want to be able to enter inter-branch transfers for this customer during Sales Order Entry. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IbtCustomer() As ArCustomerSetup_IbtCustomer_Enum
            Get
                Return _IbtCustomer
            End Get
            Set(ByVal Value As ArCustomerSetup_IbtCustomer_Enum)
                _IbtCustomer = Value : _IbtCustomerSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Standard comment code is the standard sales order comments to be used for the customer during processing in Sales Order Entry.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvCommentCode() As String
            Get
                Return _InvCommentCode
            End Get
            Set(ByVal Value As String)
                _InvCommentCode = Value : _InvCommentCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Invoice disount code is used to establish the automatic discount applicable to the customer for each invoice entered in the Detail Invoice Posting and Sales Order Order Entry programs. A blank entry indicates that no automatic invoice discount is required for the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvDiscCode() As String
            Get
                Return _InvDiscCode
            End Get
            Set(ByVal Value As String)
                _InvDiscCode = Value : _InvDiscCodeSpecified = True
            End Set
        End Property

        '''' <summary> 
        ''''  This element contains information to maintain a single customer. NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete
        '''' </summary> 
        '''' <returns></returns> 
        '''' <remarks></remarks> 
        'Public Property Item() As String
        '    Get
        '        Return _Item
        '    End Get
        '    Set(ByVal Value As String)
        '        _Item = Value : _ItemSpecified = True
        '    End Set
        'End Property

        ''' <summary> 
        '''  Fax quotes flag. Select this option if you wish to automatically fax quotations to the customer. (Y - Fax, E - Email, N - Print).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property FaxQuotes() As ArCustomerSetup_FaxQuotes_Enum
            Get
                Return _FaxQuotes
            End Get
            Set(ByVal Value As ArCustomerSetup_FaxQuotes_Enum)
                _FaxQuotes = Value : _FaxQuotesSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default Intrastat Nature of Transaction for Invoices to be used against customer. Format is 3 characters numeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TransactionNature() As String
            Get
                Return _TransactionNature
            End Get
            Set(ByVal Value As String)
                _TransactionNature = Value : _TransactionNatureSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default Intrastat Nature of Transaction for Credit Notes to be used against customer. Format is 3 characters numeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TransactionNatureC() As String
            Get
                Return _TransactionNatureC
            End Get
            Set(ByVal Value As String)
                _TransactionNatureC = Value : _TransactionNatureCSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default Intrastat Delivery Terms for Invoices to be used against customer. Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DeliveryTerms() As String
            Get
                Return _DeliveryTerms
            End Get
            Set(ByVal Value As String)
                _DeliveryTerms = Value : _DeliveryTermsSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default Intrastat Delivery Terms for Credit Notes to be used against customer. Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DeliveryTermsC() As String
            Get
                Return _DeliveryTermsC
            End Get
            Set(ByVal Value As String)
                _DeliveryTermsC = Value : _DeliveryTermsCSpecified = True
            End Set
        End Property

        '''' <summary> 
        ''''  This element contains the key information required to maintain a customer.
        '''' </summary> 
        '''' <returns></returns> 
        '''' <remarks></remarks> 
        'Public Property Key() As String
        '    Get
        '        Return _Key
        '    End Get
        '    Set(ByVal Value As String)
        '        _Key = Value : _KeySpecified = True
        '    End Set
        'End Property

        ''' <summary> 
        '''  Line discount code is used to establish the automatic discount applicable to the customer for each order line entered in the Detail Invoice Posting and Sales Order Order Entry programs. A blank entry indicates that no automatic line discount is required for the customer. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property LineDiscCode() As String
            Get
                Return _LineDiscCode
            End Get
            Set(ByVal Value As String)
                _LineDiscCode = Value : _LineDiscCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Detail history required flag indicates whether or not you require detail sales history to be recorded for any transaction processed against the customer. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property MaintHistory() As ArCustomerSetup_MaintHistory_Enum
            Get
                Return _MaintHistory
            End Get
            Set(ByVal Value As ArCustomerSetup_MaintHistory_Enum)
                _MaintHistory = Value : _MaintHistorySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Customer/stock code cross-reference required. Select this option if you want to retain the last two sales details of any stock item sold to the customer. At the time of entering sales order detail lines you can retrieve this information if you want to enter the same details that were previously processed for the customer. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property MaintLastPrcPaid() As ArCustomerSetup_MaintLastPrcPaid_Enum
            Get
                Return _MaintLastPrcPaid
            End Get
            Set(ByVal Value As ArCustomerSetup_MaintLastPrcPaid_Enum)
                _MaintLastPrcPaid = Value : _MaintLastPrcPaidSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the name of the customer and is used primarily to identify the customer. The format is 30 characters, alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value : _NameSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Nationality code. If the EC tax system is installed (Tax Options Setup) then you assign a Nationality code to the customer. This is required by EC Vat regulations to generate various reports required for the proper administration of the EC tax system. Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Nationality() As String
            Get
                Return _Nationality
            End Get
            Set(ByVal Value As String)
                _Nationality = Value : _NationalitySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Is a customer purchase order required when entering a sales order?
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PoNumberMandatory() As ArCustomerSetup_PoNumberMandatory_Enum
            Get
                Return _PoNumberMandatory
            End Get
            Set(ByVal Value As ArCustomerSetup_PoNumberMandatory_Enum)
                _PoNumberMandatory = Value : _PoNumberMandatorySpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Price category table. If you are using extended pricing, then you can enter up to 26 codes, each 2 characters long, determining the price or discount code applicable to a category (A - Z) of products being sold . The pricing category from the inventory file is used to locate a place in the customer's price category/code table. Depending on whether the inventory pricing method is coded or discounted, the price code found in this table is used against the discount table to locate the required discount or to locate a price entry in the inventory file. Format is 26 X 2 alphanumeric characters that match up to category.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PriceCategoryTable() As String
            Get
                Return _PriceCategoryTable
            End Get
            Set(ByVal Value As String)
                _PriceCategoryTable = Value : _PriceCategoryTableSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  If you are using simple pricing, then the code entered here is used to establish the price (or discount code) applicable to a specific stock code for the customer, depending on whether the inventory pricing method is coded or discounted. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PriceCode() As String
            Get
                Return _PriceCode
            End Get
            Set(ByVal Value As String)
                _PriceCode = Value : _PriceCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the default delivery route to be used in Load Planning is required. If entered, it must be a valid SYSPRO load planning route code.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteCode() As String
            Get
                Return _RouteCode
            End Get
            Set(ByVal Value As String)
                _RouteCode = Value : _RouteCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the distance or sequence to be used against all loads for this customer. It is used to determine the order of loading items. The fields is numeric, 4 integers.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteDistance() As String
            Get
                Return _RouteDistance
            End Get
            Set(ByVal Value As String)
                _RouteDistance = Value : _RouteDistanceSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Salesperson is the primary salesperson assigned to the customer and can be used as a selection criterion for various Sales Analysis reports. It is also be used to calculate commissions if you require the source of commission to be based on the salesperson, and not the price of the product being sold. Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Salesperson() As String
            Get
                Return _Salesperson
            End Get
            Set(ByVal Value As String)
                _Salesperson = Value : _SalespersonSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  First additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined. You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer. Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order). Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Salesperson1() As String
            Get
                Return _Salesperson1
            End Get
            Set(ByVal Value As String)
                _Salesperson1 = Value : _Salesperson1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Second additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined. It must be left blank if the first additional salesperson is not defined. You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer. Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order). Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Salesperson2() As String
            Get
                Return _Salesperson2
            End Get
            Set(ByVal Value As String)
                _Salesperson2 = Value : _Salesperson2Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Third additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined. It must be left blank if the second additional salesperson is not defined. You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer. Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order). Format is 3 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Salesperson3() As String
            Get
                Return _Salesperson3
            End Get
            Set(ByVal Value As String)
                _Salesperson3 = Value : _Salesperson3Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Postal/zip code for the ship to address. Ship to address can be printed on invoices and faxes. Format is 9 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipPostalCode() As String
            Get
                Return _ShipPostalCode
            End Get
            Set(ByVal Value As String)
                _ShipPostalCode = Value : _ShipPostalCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  First line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipToAddr1() As String
            Get
                Return _ShipToAddr1
            End Get
            Set(ByVal Value As String)
                _ShipToAddr1 = Value : _ShipToAddr1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Second line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipToAddr2() As String
            Get
                Return _ShipToAddr2
            End Get
            Set(ByVal Value As String)
                _ShipToAddr2 = Value : _ShipToAddr2Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Third line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipToAddr3() As String
            Get
                Return _ShipToAddr3
            End Get
            Set(ByVal Value As String)
                _ShipToAddr3 = Value : _ShipToAddr3Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fourth line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipToAddr4() As String
            Get
                Return _ShipToAddr4
            End Get
            Set(ByVal Value As String)
                _ShipToAddr4 = Value : _ShipToAddr4Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fifth line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShipToAddr5() As String
            Get
                Return _ShipToAddr5
            End Get
            Set(ByVal Value As String)
                _ShipToAddr5 = Value : _ShipToAddr5Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Ship via is the default shipping instruction message to be used for this customer in the Sales Order Entry program. If you leave this field blank, then the default shipping message defined in the Sales Order module (Sales Order Setup) is used. Format is 30 characters alphanumeric. However, if in SYSPRO Sales Order Setup, the format of the shipping instructions is defined as 'Coded', the first 2 characters designate an existing code and the shipping instructions will be picked up from the code's description. If this code does not exist, the shipping instructions will be saved as entered.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShippingInstrs() As String
            Get
                Return _ShippingInstrs
            End Get
            Set(ByVal Value As String)
                _ShippingInstrs = Value : _ShippingInstrsSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is a short name and is used in searching for a customer. It is also used as selection criteria in some reports.The format is 10 characters, alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ShortName() As String
            Get
                Return _ShortName
            End Get
            Set(ByVal Value As String)
                _ShortName = Value : _ShortNameSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default document format is a default document format for the customer used when batch invoices and/or delivery notes are printed.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoDefaultDoc() As ArCustomerSetup_SoDefaultDoc_Enum
            Get
                Return _SoDefaultDoc
            End Get
            Set(ByVal Value As ArCustomerSetup_SoDefaultDoc_Enum)
                _SoDefaultDoc = Value : _SoDefaultDocSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Default type of sales order that applies to the customer. Settings are as follows: Space - Operator default O - Sales order B - Billing S - Scheduled order C - Credit note D - Debit note F - Forward order U - Counter sale I - IBT H - Hierachical order
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoDefaultType() As ArCustomerSetup_SoDefaultType_Enum
            Get
                Return _SoDefaultType
            End Get
            Set(ByVal Value As ArCustomerSetup_SoDefaultType_Enum)
                _SoDefaultType = Value : _SoDefaultTypeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Postal/zip code for the sold to address. Sold to address can be printed on invoices and faxes. Format is 9 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldPostalCode() As String
            Get
                Return _SoldPostalCode
            End Get
            Set(ByVal Value As String)
                _SoldPostalCode = Value : _SoldPostalCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  First line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldToAddr1() As String
            Get
                Return _SoldToAddr1
            End Get
            Set(ByVal Value As String)
                _SoldToAddr1 = Value : _SoldToAddr1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Second line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldToAddr2() As String
            Get
                Return _SoldToAddr2
            End Get
            Set(ByVal Value As String)
                _SoldToAddr2 = Value : _SoldToAddr2Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Third line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldToAddr3() As String
            Get
                Return _SoldToAddr3
            End Get
            Set(ByVal Value As String)
                _SoldToAddr3 = Value : _SoldToAddr3Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fourth line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldToAddr4() As String
            Get
                Return _SoldToAddr4
            End Get
            Set(ByVal Value As String)
                _SoldToAddr4 = Value : _SoldToAddr4Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Fifth line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SoldToAddr5() As String
            Get
                Return _SoldToAddr5
            End Get
            Set(ByVal Value As String)
                _SoldToAddr5 = Value : _SoldToAddr5Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Special instructions is used in the Sales Order Entry program and can be printed on invoices and reports. Format is 30 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SpecialInstrs() As String
            Get
                Return _SpecialInstrs
            End Get
            Set(ByVal Value As String)
                _SpecialInstrs = Value : _SpecialInstrsSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the state code that is part of the extended tax code applicable to the sold to address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 2 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property State() As String
            Get
                Return _State
            End Get
            Set(ByVal Value As String)
                _State = Value : _StateSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is the state code that is part of the extended tax code applicable to the ship to address. Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup). Format is 2 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property State1() As String
            Get
                Return _State1
            End Get
            Set(ByVal Value As String)
                _State1 = Value : _State1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  State code for customer. Format is 3 character alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property StateCode() As String
            Get
                Return _StateCode
            End Get
            Set(ByVal Value As String)
                _StateCode = Value : _StateCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Statements required flag. Select this option if you want to include this customer for selection when statements are produced for customers using the Statement Print program. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property StatementReqd() As ArCustomerSetup_StatementReqd_Enum
            Get
                Return _StatementReqd
            End Get
            Set(ByVal Value As ArCustomerSetup_StatementReqd_Enum)
                _StatementReqd = Value : _StatementReqdSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Stock code interchange required. Select this option if you want the customer's stock codes to be converted to the standard SYSPRO stock code during processing in Sales Order Entry. (Y - Yes, N - No)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property StockInterchange() As ArCustomerSetup_StockInterchange_Enum
            Get
                Return _StockInterchange
            End Get
            Set(ByVal Value As ArCustomerSetup_StockInterchange_Enum)
                _StockInterchange = Value : _StockInterchangeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Customer's tax exempt number. Format is 30 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TaxExemptNumber() As String
            Get
                Return _TaxExemptNumber
            End Get
            Set(ByVal Value As String)
                _TaxExemptNumber = Value : _TaxExemptNumberSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Tax status flag. Settings are as follows: E - Exempt to exempt the customer from sales tax. N - To indicate that sales tax is applicable to the customer. O - Other tax code if the tax entry held in the Other tax code field against the stock item is to be used when making a sale against the customer in the Invoice Posting or Sales Order Entry programs.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TaxStatus() As ArCustomerSetup_TaxStatus_Enum
            Get
                Return _TaxStatus
            End Get
            Set(ByVal Value As ArCustomerSetup_TaxStatus_Enum)
                _TaxStatus = Value : _TaxStatusSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Telephone number for the customer. Format is 20 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Telephone() As String
            Get
                Return _Telephone
            End Get
            Set(ByVal Value As String)
                _Telephone = Value : _TelephoneSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Telephone extension for the customer. Format is 5 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TelephoneExtn() As String
            Get
                Return _TelephoneExtn
            End Get
            Set(ByVal Value As String)
                _TelephoneExtn = Value : _TelephoneExtnSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Telex number for the customer. Format is 10 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Telex() As String
            Get
                Return _Telex
            End Get
            Set(ByVal Value As String)
                _Telex = Value : _TelexSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Invoice terms is used to determine the default settlement terms required for a customer. SYSPRO uses the invoice terms to calculate discount amounts as well as discount dates and due dates of customer documents processed within the Invoice Posting and Permanent Entries programs. Format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TermsCode() As String
            Get
                Return _TermsCode
            End Get
            Set(ByVal Value As String)
                _TermsCode = Value : _TermsCodeSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Is the customer a Trade Promotions customer?
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TpmCustomerFlag() As ArCustomerSetup_TpmCustomerFlag_Enum
            Get
                Return _TpmCustomerFlag
            End Get
            Set(ByVal Value As ArCustomerSetup_TpmCustomerFlag_Enum)
                _TpmCustomerFlag = Value : _TpmCustomerFlagSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Does the customer require Trade Promotions pricing. This is only relevant if the customer is a Trade Promotions customer.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TpmPricingFlag() As ArCustomerSetup_TpmPricingFlag_Enum
            Get
                Return _TpmPricingFlag
            End Get
            Set(ByVal Value As ArCustomerSetup_TpmPricingFlag_Enum)
                _TpmPricingFlag = Value : _TpmPricingFlagSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  Does the customer require Trade Promotions credit checking. This is only relevant if the custoemr is a Trade Promotions customer, and credit checking is required.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TpmCreditCheck() As ArCustomerSetup_TpmCreditCheck_Enum
            Get
                Return _TpmCreditCheck
            End Get
            Set(ByVal Value As ArCustomerSetup_TpmCreditCheck_Enum)
                _TpmCreditCheck = Value : _TpmCreditCheckSpecified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is a 10 character free format alphanumeric user defined field.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UserField1() As String
            Get
                Return _UserField1
            End Get
            Set(ByVal Value As String)
                _UserField1 = Value : _UserField1Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  This is a 12.2 positive or negative numeric user defined field.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UserField2() As String
            Get
                Return _UserField2
            End Get
            Set(ByVal Value As String)
                _UserField2 = Value : _UserField2Specified = True
            End Set
        End Property

        ''' <summary> 
        '''  Credit checking method for customer. The format is 1 character alphanumeric. Valid values are T (check terms only), L (check limit only), B (check both), N (no checking), and Blank (use company method).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CreditCheckFlag() As String
            Get
                Return _CreditCheckFlag
            End Get
            Set(ByVal Value As String)
                _CreditCheckFlag = Value : _CreditCheckFlagSpecified = True
            End Set
        End Property


#End Region

#Region "Constructors"

        ''' <summary>
        ''' Initializes a new instance of the CustomerMaintenance class.
        ''' </summary>
        ''' <param name="Customer"></param>
        Public Sub New(ByVal Customer As String)
            _Customer = Customer
        End Sub


#End Region

#Region "Post Method"

        Public Sub Post() Implements ISetup.Post

            Select Case _ActionType
                Case CommonEnums.ActionType_Setup.Add
                    _xmlOut = Setup.Add(Me)
                Case CommonEnums.ActionType_Setup.Delete
                    _xmlOut = Setup.Delete(Me)
                Case CommonEnums.ActionType_Setup.Update
                    _xmlOut = Setup.Update(Me)
            End Select



        End Sub

#End Region

#Region "XML Document Constructors"

#Region "Parameters XML Constructor"

        Private Function Construct_XMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument
            Dim SetupArCustomer As System.Xml.XmlElement = xmlDoc.CreateElement("SetupArCustomer")
            xmlDoc.AppendChild(SetupArCustomer)

            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            SetupArCustomer.AppendChild(Parameters)

            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")

            Parameters.AppendChild(ApplyIfEntireDocumentValid)
            Parameters.AppendChild(IgnoreWarnings)
            Parameters.AppendChild(ValidateOnly)

            ApplyIfEntireDocumentValid.InnerText = Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString)
            IgnoreWarnings.InnerText = Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString)
            ValidateOnly.InnerText = Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString)

            Return xmlDoc.OuterXml

        End Function


#End Region

#Region "Data XML Constructor"

        Private Function ConstructXML_Data() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim SetupArCustomer As System.Xml.XmlElement = xmlDoc.CreateElement("SetupArCustomer")
            xmlDoc.AppendChild(SetupArCustomer)

            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            SetupArCustomer.AppendChild(Item)

            Dim Key As System.Xml.XmlElement = xmlDoc.CreateElement("Key")
            Item.AppendChild(Key)

            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            ' Key.PrependChild(Customer)
            Common.SysproUtilities.AppendXMLElement(Key, Customer, _Customer.ToString)

            Dim Name As System.Xml.XmlElement = xmlDoc.CreateElement("Name")
            Common.SysproUtilities.AppendXMLElement(Item, Name, _Name.ToString)

            Dim AddTelephone As System.Xml.XmlElement = xmlDoc.CreateElement("AddTelephone")
            Dim ApplyLineDisc As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyLineDisc")
            Dim ApplyOrdDisc As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyOrdDisc")
            Dim Area As System.Xml.XmlElement = xmlDoc.CreateElement("Area")
            Dim BackOrdReqd As System.Xml.XmlElement = xmlDoc.CreateElement("BackOrdReqd")
            Dim BalanceType As System.Xml.XmlElement = xmlDoc.CreateElement("BalanceType")
            Dim Branch As System.Xml.XmlElement = xmlDoc.CreateElement("Branch")
            Dim BuyingGroup1 As System.Xml.XmlElement = xmlDoc.CreateElement("BuyingGroup1")
            Dim BuyingGroup2 As System.Xml.XmlElement = xmlDoc.CreateElement("BuyingGroup2")
            Dim BuyingGroup3 As System.Xml.XmlElement = xmlDoc.CreateElement("BuyingGroup3")
            Dim BuyingGroup4 As System.Xml.XmlElement = xmlDoc.CreateElement("BuyingGroup4")
            Dim BuyingGroup5 As System.Xml.XmlElement = xmlDoc.CreateElement("BuyingGroup5")
            Dim City As System.Xml.XmlElement = xmlDoc.CreateElement("City")
            Dim City1 As System.Xml.XmlElement = xmlDoc.CreateElement("City1")
            Dim Contact As System.Xml.XmlElement = xmlDoc.CreateElement("Contact")
            Dim ContractPrcReqd As System.Xml.XmlElement = xmlDoc.CreateElement("ContractPrcReqd")
            Dim CounterSlsOnly As System.Xml.XmlElement = xmlDoc.CreateElement("CounterSlsOnly")
            Dim CountyZip As System.Xml.XmlElement = xmlDoc.CreateElement("CountyZip")
            Dim CountyZip1 As System.Xml.XmlElement = xmlDoc.CreateElement("CountyZip1")
            Dim CreditLimit As System.Xml.XmlElement = xmlDoc.CreateElement("CreditLimit")
            Dim CreditStatus As System.Xml.XmlElement = xmlDoc.CreateElement("CreditStatus")
            Dim Currency As System.Xml.XmlElement = xmlDoc.CreateElement("Currency")
            Dim CustomerClass As System.Xml.XmlElement = xmlDoc.CreateElement("CustomerClass")
            Dim CustomerOnHold As System.Xml.XmlElement = xmlDoc.CreateElement("CustomerOnHold")
            Dim DateCustAdded As System.Xml.XmlElement = xmlDoc.CreateElement("DateCustAdded")
            Dim DefaultOrdType As System.Xml.XmlElement = xmlDoc.CreateElement("DefaultOrdType")
            Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")
            Dim DetailMoveReqd As System.Xml.XmlElement = xmlDoc.CreateElement("DetailMoveReqd")
            Dim DocFax As System.Xml.XmlElement = xmlDoc.CreateElement("DocFax")
            Dim DocFaxContact As System.Xml.XmlElement = xmlDoc.CreateElement("DocFaxContact")
            Dim EdiFlag As System.Xml.XmlElement = xmlDoc.CreateElement("EdiFlag")
            Dim EdiSenderCode As System.Xml.XmlElement = xmlDoc.CreateElement("EdiSenderCode")
            Dim Email As System.Xml.XmlElement = xmlDoc.CreateElement("Email")
            Dim ExemptFinChg As System.Xml.XmlElement = xmlDoc.CreateElement("ExemptFinChg")
            Dim Fax As System.Xml.XmlElement = xmlDoc.CreateElement("Fax")
            Dim FaxInvoices As System.Xml.XmlElement = xmlDoc.CreateElement("FaxInvoices")
            Dim FaxStatements As System.Xml.XmlElement = xmlDoc.CreateElement("FaxStatements")
            Dim GstExemptFlag As System.Xml.XmlElement = xmlDoc.CreateElement("GstExemptFlag")
            Dim GstExemptNum As System.Xml.XmlElement = xmlDoc.CreateElement("GstExemptNum")
            Dim GstLevel As System.Xml.XmlElement = xmlDoc.CreateElement("GstLevel")
            Dim HighInv As System.Xml.XmlElement = xmlDoc.CreateElement("HighInv")
            Dim HighInvDays As System.Xml.XmlElement = xmlDoc.CreateElement("HighInvDays")
            Dim HighestBalance As System.Xml.XmlElement = xmlDoc.CreateElement("HighestBalance")
            Dim IbtCustomer As System.Xml.XmlElement = xmlDoc.CreateElement("IbtCustomer")
            Dim InvCommentCode As System.Xml.XmlElement = xmlDoc.CreateElement("InvCommentCode")
            Dim InvDiscCode As System.Xml.XmlElement = xmlDoc.CreateElement("InvDiscCode")
            Dim FaxQuotes As System.Xml.XmlElement = xmlDoc.CreateElement("FaxQuotes")
            Dim TransactionNature As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionNature")
            Dim TransactionNatureC As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionNatureC")
            Dim DeliveryTerms As System.Xml.XmlElement = xmlDoc.CreateElement("DeliveryTerms")
            Dim DeliveryTermsC As System.Xml.XmlElement = xmlDoc.CreateElement("DeliveryTermsC")
            Dim LineDiscCode As System.Xml.XmlElement = xmlDoc.CreateElement("LineDiscCode")
            Dim MaintHistory As System.Xml.XmlElement = xmlDoc.CreateElement("MaintHistory")
            Dim MaintLastPrcPaid As System.Xml.XmlElement = xmlDoc.CreateElement("MaintLastPrcPaid")
            Dim Nationality As System.Xml.XmlElement = xmlDoc.CreateElement("Nationality")
            Dim PoNumberMandatory As System.Xml.XmlElement = xmlDoc.CreateElement("PoNumberMandatory")
            Dim PriceCategoryTable As System.Xml.XmlElement = xmlDoc.CreateElement("PriceCategoryTable")
            Dim PriceCode As System.Xml.XmlElement = xmlDoc.CreateElement("PriceCode")
            Dim RouteCode As System.Xml.XmlElement = xmlDoc.CreateElement("RouteCode")
            Dim RouteDistance As System.Xml.XmlElement = xmlDoc.CreateElement("RouteDistance")
            Dim Salesperson As System.Xml.XmlElement = xmlDoc.CreateElement("Salesperson")
            Dim Salesperson1 As System.Xml.XmlElement = xmlDoc.CreateElement("Salesperson1")
            Dim Salesperson2 As System.Xml.XmlElement = xmlDoc.CreateElement("Salesperson2")
            Dim Salesperson3 As System.Xml.XmlElement = xmlDoc.CreateElement("Salesperson3")
            Dim ShipPostalCode As System.Xml.XmlElement = xmlDoc.CreateElement("ShipPostalCode")
            Dim ShipToAddr1 As System.Xml.XmlElement = xmlDoc.CreateElement("ShipToAddr1")
            Dim ShipToAddr2 As System.Xml.XmlElement = xmlDoc.CreateElement("ShipToAddr2")
            Dim ShipToAddr3 As System.Xml.XmlElement = xmlDoc.CreateElement("ShipToAddr3")
            Dim ShipToAddr4 As System.Xml.XmlElement = xmlDoc.CreateElement("ShipToAddr4")
            Dim ShipToAddr5 As System.Xml.XmlElement = xmlDoc.CreateElement("ShipToAddr5")
            Dim ShippingInstrs As System.Xml.XmlElement = xmlDoc.CreateElement("ShippingInstrs")
            Dim ShortName As System.Xml.XmlElement = xmlDoc.CreateElement("ShortName")
            Dim SoDefaultDoc As System.Xml.XmlElement = xmlDoc.CreateElement("SoDefaultDoc")
            Dim SoDefaultType As System.Xml.XmlElement = xmlDoc.CreateElement("SoDefaultType")
            Dim SoldPostalCode As System.Xml.XmlElement = xmlDoc.CreateElement("SoldPostalCode")
            Dim SoldToAddr1 As System.Xml.XmlElement = xmlDoc.CreateElement("SoldToAddr1")
            Dim SoldToAddr2 As System.Xml.XmlElement = xmlDoc.CreateElement("SoldToAddr2")
            Dim SoldToAddr3 As System.Xml.XmlElement = xmlDoc.CreateElement("SoldToAddr3")
            Dim SoldToAddr4 As System.Xml.XmlElement = xmlDoc.CreateElement("SoldToAddr4")
            Dim SoldToAddr5 As System.Xml.XmlElement = xmlDoc.CreateElement("SoldToAddr5")
            Dim SpecialInstrs As System.Xml.XmlElement = xmlDoc.CreateElement("SpecialInstrs")
            Dim State As System.Xml.XmlElement = xmlDoc.CreateElement("State")
            Dim State1 As System.Xml.XmlElement = xmlDoc.CreateElement("State1")
            Dim StateCode As System.Xml.XmlElement = xmlDoc.CreateElement("StateCode")
            Dim StatementReqd As System.Xml.XmlElement = xmlDoc.CreateElement("StatementReqd")
            Dim StockInterchange As System.Xml.XmlElement = xmlDoc.CreateElement("StockInterchange")
            Dim TaxExemptNumber As System.Xml.XmlElement = xmlDoc.CreateElement("TaxExemptNumber")
            Dim TaxStatus As System.Xml.XmlElement = xmlDoc.CreateElement("TaxStatus")
            Dim Telephone As System.Xml.XmlElement = xmlDoc.CreateElement("Telephone")
            Dim TelephoneExtn As System.Xml.XmlElement = xmlDoc.CreateElement("TelephoneExtn")
            Dim Telex As System.Xml.XmlElement = xmlDoc.CreateElement("Telex")
            Dim TermsCode As System.Xml.XmlElement = xmlDoc.CreateElement("TermsCode")
            Dim TpmCustomerFlag As System.Xml.XmlElement = xmlDoc.CreateElement("TpmCustomerFlag")
            Dim TpmPricingFlag As System.Xml.XmlElement = xmlDoc.CreateElement("TpmPricingFlag")
            Dim TpmCreditCheck As System.Xml.XmlElement = xmlDoc.CreateElement("TpmCreditCheck")
            Dim UserField1 As System.Xml.XmlElement = xmlDoc.CreateElement("UserField1")
            Dim UserField2 As System.Xml.XmlElement = xmlDoc.CreateElement("UserField2")
            Dim CreditCheckFlag As System.Xml.XmlElement = xmlDoc.CreateElement("CreditCheckFlag")


            If _AddTelephoneSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, AddTelephone, _AddTelephone.ToString)
            If _ApplyLineDiscSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ApplyLineDisc, Common.SysproUtilities.GetEnumValue(_ApplyLineDisc.ToString))
            If _ApplyOrdDiscSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ApplyOrdDisc, Common.SysproUtilities.GetEnumValue(_ApplyOrdDisc.ToString))
            If _SetupArCustomerSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, SetupArCustomer, _SetupArCustomer.ToString)
            If _AreaSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Area, _Area.ToString)
            If _BackOrdReqdSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, BackOrdReqd, Common.SysproUtilities.GetEnumValue(_BackOrdReqd.ToString))
            If _BalanceTypeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, BalanceType, Common.SysproUtilities.GetEnumValue(_BalanceType.ToString))
            If _BranchSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Branch, _Branch.ToString)
            If _BuyingGroup1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, BuyingGroup1, _BuyingGroup1.ToString)
            If _BuyingGroup2Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, BuyingGroup2, _BuyingGroup2.ToString)
            If _BuyingGroup3Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, BuyingGroup3, _BuyingGroup3.ToString)
            If _BuyingGroup4Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, BuyingGroup4, _BuyingGroup4.ToString)
            If _BuyingGroup5Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, BuyingGroup5, _BuyingGroup5.ToString)


            If _CitySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, City, _City.ToString)
            If _City1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, City1, _City1.ToString)
            If _ContactSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Contact, _Contact.ToString)

            If _ContractPrcReqdSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ContractPrcReqd, Common.SysproUtilities.GetEnumValue(_ContractPrcReqd.ToString))
            If _CounterSlsOnlySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CounterSlsOnly, Common.SysproUtilities.GetEnumValue(_CounterSlsOnly.ToString))
            If _CountyZipSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CountyZip, _CountyZip.ToString)
            If _CountyZip1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, CountyZip1, _CountyZip1.ToString)
            If _CreditLimitSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CreditLimit, _CreditLimit.ToString)
            If _CreditStatusSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CreditStatus, Common.SysproUtilities.GetEnumValue(_CreditStatus.ToString))
            If _CurrencySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Currency, _Currency.ToString)
            If _CustomerSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Customer, _Customer.ToString)
            If _CustomerClassSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CustomerClass, _CustomerClass.ToString)
            If _CustomerOnHoldSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CustomerOnHold, Common.SysproUtilities.GetEnumValue(_CustomerOnHold.ToString))
            If _DateCustAddedSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DateCustAdded, _DateCustAdded.ToString)
            If _DefaultOrdTypeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DefaultOrdType, _DefaultOrdType.ToString)
            If _WarehouseSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Warehouse, _Warehouse.ToString)
            If _DetailMoveReqdSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DetailMoveReqd, Common.SysproUtilities.GetEnumValue(_DetailMoveReqd.ToString))
            If _DocFaxSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DocFax, _DocFax.ToString)
            If _DocFaxContactSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DocFaxContact, _DocFaxContact.ToString)
            If _EdiFlagSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, EdiFlag, Common.SysproUtilities.GetEnumValue(_EdiFlag.ToString))
            If _EdiSenderCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, EdiSenderCode, _EdiSenderCode.ToString)
            If _EmailSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Email, _Email.ToString)
            If _ExemptFinChgSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ExemptFinChg, Common.SysproUtilities.GetEnumValue(_ExemptFinChg.ToString))
            If _FaxSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Fax, _Fax.ToString)
            If _FaxInvoicesSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, FaxInvoices, Common.SysproUtilities.GetEnumValue(_FaxInvoices.ToString))
            If _FaxStatementsSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, FaxStatements, Common.SysproUtilities.GetEnumValue(_FaxStatements.ToString))
            If _GstExemptFlagSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, GstExemptFlag, Common.SysproUtilities.GetEnumValue(_GstExemptFlag.ToString))
            If _GstExemptNumSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, GstExemptNum, _GstExemptNum.ToString)
            If _GstLevelSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, GstLevel, Common.SysproUtilities.GetEnumValue(_GstLevel.ToString))
            If _HighInvSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, HighInv, _HighInv.ToString)
            If _HighInvDaysSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, HighInvDays, _HighInvDays.ToString)
            If _HighestBalanceSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, HighestBalance, _HighestBalance.ToString)
            If _IbtCustomerSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, IbtCustomer, Common.SysproUtilities.GetEnumValue(_IbtCustomer.ToString))
            If _InvCommentCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, InvCommentCode, _InvCommentCode.ToString)
            If _InvDiscCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, InvDiscCode, _InvDiscCode.ToString)

            If _FaxQuotesSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, FaxQuotes, Common.SysproUtilities.GetEnumValue(_FaxQuotes.ToString))
            If _TransactionNatureSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TransactionNature, _TransactionNature.ToString)
            If _TransactionNatureCSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TransactionNatureC, _TransactionNatureC.ToString)
            If _DeliveryTermsSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DeliveryTerms, _DeliveryTerms.ToString)
            If _DeliveryTermsCSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, DeliveryTermsC, _DeliveryTermsC.ToString)

            'If _ItemSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Item, _Item.ToString)
            'If _KeySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Key, _Key.ToString)

            If _LineDiscCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, LineDiscCode, _LineDiscCode.ToString)
            If _MaintHistorySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, MaintHistory, Common.SysproUtilities.GetEnumValue(_MaintHistory.ToString))
            If _MaintLastPrcPaidSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, MaintLastPrcPaid, Common.SysproUtilities.GetEnumValue(_MaintLastPrcPaid.ToString))
            If _NameSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Name, _Name.ToString)
            If _NationalitySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Nationality, _Nationality.ToString)
            If _PoNumberMandatorySpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, PoNumberMandatory, Common.SysproUtilities.GetEnumValue(_PoNumberMandatory.ToString))
            If _PriceCategoryTableSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, PriceCategoryTable, _PriceCategoryTable.ToString)
            If _PriceCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, PriceCode, _PriceCode.ToString)
            If _RouteCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, RouteCode, _RouteCode.ToString)
            If _RouteDistanceSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, RouteDistance, _RouteDistance.ToString)
            If _SalespersonSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Salesperson, _Salesperson.ToString)
            If _Salesperson1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, Salesperson1, _Salesperson1.ToString)
            If _Salesperson2Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, Salesperson2, _Salesperson2.ToString)
            If _Salesperson3Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, Salesperson3, _Salesperson3.ToString)
            If _ShipPostalCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipPostalCode, _ShipPostalCode.ToString)
            If _ShipToAddr1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipToAddr1, _ShipToAddr1.ToString)
            If _ShipToAddr2Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipToAddr2, _ShipToAddr2.ToString)
            If _ShipToAddr3Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipToAddr3, _ShipToAddr3.ToString)
            If _ShipToAddr4Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipToAddr4, _ShipToAddr4.ToString)
            If _ShipToAddr5Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShipToAddr5, _ShipToAddr5.ToString)
            If _ShippingInstrsSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShippingInstrs, _ShippingInstrs.ToString)
            If _ShortNameSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, ShortName, _ShortName.ToString)
            If _SoDefaultDocSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoDefaultDoc, Common.SysproUtilities.GetEnumValue(_SoDefaultDoc.ToString))
            If _SoDefaultTypeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoDefaultType, Common.SysproUtilities.GetEnumValue(_SoDefaultType.ToString))
            If _SoldPostalCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldPostalCode, _SoldPostalCode.ToString)
            If _SoldToAddr1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldToAddr1, _SoldToAddr1.ToString)
            If _SoldToAddr2Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldToAddr2, _SoldToAddr2.ToString)
            If _SoldToAddr3Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldToAddr3, _SoldToAddr3.ToString)
            If _SoldToAddr4Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldToAddr4, _SoldToAddr4.ToString)
            If _SoldToAddr5Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, SoldToAddr5, _SoldToAddr5.ToString)
            If _SpecialInstrsSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, SpecialInstrs, _SpecialInstrs.ToString)
            If _StateSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, State, _State.ToString)
            If _State1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, State1, _State1.ToString)
            If _StateCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, StateCode, _StateCode.ToString)
            If _StatementReqdSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, StatementReqd, Common.SysproUtilities.GetEnumValue(_StatementReqd.ToString))
            If _StockInterchangeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, StockInterchange, Common.SysproUtilities.GetEnumValue(_StockInterchange.ToString))
            If _TaxExemptNumberSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TaxExemptNumber, _TaxExemptNumber.ToString)
            If _TaxStatusSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TaxStatus, Common.SysproUtilities.GetEnumValue(_TaxStatus.ToString))
            If _TelephoneSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Telephone, _Telephone.ToString)
            If _TelephoneExtnSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TelephoneExtn, _TelephoneExtn.ToString)
            If _TelexSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, Telex, _Telex.ToString)
            If _TermsCodeSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TermsCode, _TermsCode.ToString)
            If _TpmCustomerFlagSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TpmCustomerFlag, Common.SysproUtilities.GetEnumValue(_TpmCustomerFlag.ToString))
            If _TpmPricingFlagSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TpmPricingFlag, Common.SysproUtilities.GetEnumValue(_TpmPricingFlag.ToString))
            If _TpmCreditCheckSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, TpmCreditCheck, Common.SysproUtilities.GetEnumValue(_TpmCreditCheck.ToString))
            If _UserField1Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, UserField1, _UserField1.ToString)
            If _UserField2Specified = True Then Common.SysproUtilities.AppendXMLElement(Item, UserField2, _UserField2.ToString)
            If _CreditCheckFlagSpecified = True Then Common.SysproUtilities.AppendXMLElement(Item, CreditCheckFlag, _CreditCheckFlag.ToString)

            Return xmlDoc.OuterXml

        End Function




#End Region


#End Region

#Region "Parameter Enumerations"

        Public Enum ArCustomerSetup_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_N
            ApplyIfEntireDocumentValid_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_N
        End Enum
        Public Enum ArCustomerSetup_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum

#End Region

#Region "Data Enumerations"


        Public Enum ArCustomerSetup_ApplyLineDisc_Enum
            ApplyLineDisc_Upper_N
            ApplyLineDisc_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_ApplyOrdDisc_Enum
            ApplyOrdDisc_Upper_N
            ApplyOrdDisc_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_BackOrdReqd_Enum
            BackOrdReqd_Upper_Y
            BackOrdReqd_Upper_N
        End Enum
        Public Enum ArCustomerSetup_BalanceType_Enum
            BalanceType_Upper_I
            BalanceType_Upper_B
        End Enum
        Public Enum ArCustomerSetup_ContractPrcReqd_Enum
            ContractPrcReqd_Upper_N
            ContractPrcReqd_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_CounterSlsOnly_Enum
            CounterSlsOnly_Upper_N
            CounterSlsOnly_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_CreditStatus_Enum
            CreditStatus_0
            CreditStatus_1
            CreditStatus_2
            CreditStatus_3
            CreditStatus_4
            CreditStatus_5
            CreditStatus_6
            CreditStatus_7
            CreditStatus_8
            CreditStatus_9
        End Enum
        Public Enum ArCustomerSetup_CustomerOnHold_Enum
            CustomerOnHold_Upper_N
            CustomerOnHold_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_DetailMoveReqd_Enum
            DetailMoveReqd_Upper_Y
            DetailMoveReqd_Upper_N
        End Enum
        Public Enum ArCustomerSetup_EdiFlag_Enum
            EdiFlag_Upper_N
            EdiFlag_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_ExemptFinChg_Enum
            ExemptFinChg_Upper_Y
            ExemptFinChg_Upper_N
        End Enum
        Public Enum ArCustomerSetup_FaxInvoices_Enum
            FaxInvoices_Space
            FaxInvoices_Upper_N
            FaxInvoices_Upper_A
            FaxInvoices_Upper_B
            FaxInvoices_Upper_C
            FaxInvoices_Upper_D
            FaxInvoices_Upper_E
            FaxInvoices_Upper_F
            FaxInvoices_Upper_G
            FaxInvoices_Upper_H
            FaxInvoices_Upper_I
            FaxInvoices_Upper_J
            FaxInvoices_Upper_K
            FaxInvoices_Upper_W
            FaxInvoices_Upper_X
            FaxInvoices_Upper_Y
            FaxInvoices_Upper_Z
            FaxInvoices_Lower_a
            FaxInvoices_Lower_b
            FaxInvoices_Lower_c
            FaxInvoices_Lower_d
            FaxInvoices_Lower_e
            FaxInvoices_Lower_f
            FaxInvoices_Lower_g
            FaxInvoices_Lower_h
            FaxInvoices_Lower_i
            FaxInvoices_Lower_j
            FaxInvoices_Lower_k
            FaxInvoices_Lower_w
            FaxInvoices_Lower_x
            FaxInvoices_Lower_y
            FaxInvoices_Lower_z
        End Enum
        Public Enum ArCustomerSetup_FaxStatements_Enum
            FaxStatements_Upper_Y
            FaxStatements_Upper_N
            FaxStatements_Upper_E
        End Enum
        Public Enum ArCustomerSetup_GstExemptFlag_Enum
            GstExemptFlag_Upper_E
            GstExemptFlag_Upper_N
        End Enum
        Public Enum ArCustomerSetup_GstLevel_Enum
            GstLevel_Blank
            GstLevel_Upper_I
            GstLevel_Upper_L
        End Enum
        Public Enum ArCustomerSetup_IbtCustomer_Enum
            IbtCustomer_Upper_N
            IbtCustomer_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_FaxQuotes_Enum
            FaxQuotes_Blank
            FaxQuotes_Space
            FaxQuotes_Upper_Y
            FaxQuotes_Upper_N
            FaxQuotes_Upper_E
        End Enum
        Public Enum ArCustomerSetup_MaintHistory_Enum
            MaintHistory_Upper_Y
            MaintHistory_Upper_N
        End Enum
        Public Enum ArCustomerSetup_MaintLastPrcPaid_Enum
            MaintLastPrcPaid_Upper_N
            MaintLastPrcPaid_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_PoNumberMandatory_Enum
            PoNumberMandatory_Blank
            PoNumberMandatory_Upper_N
            PoNumberMandatory_Upper_Y
            PoNumberMandatory_Space
        End Enum
        Public Enum ArCustomerSetup_SoDefaultDoc_Enum
            SoDefaultDoc_Blank
            SoDefaultDoc_0
            SoDefaultDoc_1
            SoDefaultDoc_2
            SoDefaultDoc_3
            SoDefaultDoc_4
            SoDefaultDoc_5
            SoDefaultDoc_6
            SoDefaultDoc_7
            SoDefaultDoc_8
            SoDefaultDoc_9
            SoDefaultDoc_Upper_A
            SoDefaultDoc_Upper_B
            SoDefaultDoc_Upper_C
            SoDefaultDoc_Upper_D
            SoDefaultDoc_Upper_E
            SoDefaultDoc_Upper_F
            SoDefaultDoc_Upper_G
            SoDefaultDoc_Upper_H
            SoDefaultDoc_Upper_I
            SoDefaultDoc_Upper_J
            SoDefaultDoc_Upper_K
            SoDefaultDoc_Upper_L
            SoDefaultDoc_Upper_M
            SoDefaultDoc_Upper_N
            SoDefaultDoc_Upper_O
            SoDefaultDoc_Upper_P
            SoDefaultDoc_Upper_Q
            SoDefaultDoc_Upper_R
            SoDefaultDoc_Upper_S
            SoDefaultDoc_Upper_T
            SoDefaultDoc_Upper_U
            SoDefaultDoc_Upper_V
            SoDefaultDoc_Upper_W
            SoDefaultDoc_Upper_X
            SoDefaultDoc_Upper_Y
            SoDefaultDoc_Upper_Z
        End Enum
        Public Enum ArCustomerSetup_SoDefaultType_Enum
            SoDefaultType_Blank
            SoDefaultType_Upper_O
            SoDefaultType_Upper_B
            SoDefaultType_Upper_S
            SoDefaultType_Upper_C
            SoDefaultType_Upper_D
            SoDefaultType_Upper_F
            SoDefaultType_Upper_U
            SoDefaultType_Upper_I
            SoDefaultType_Upper_H
        End Enum
        Public Enum ArCustomerSetup_StatementReqd_Enum
            StatementReqd_Upper_Y
            StatementReqd_Upper_N
        End Enum
        Public Enum ArCustomerSetup_StockInterchange_Enum
            StockInterchange_Upper_N
            StockInterchange_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_TaxStatus_Enum
            TaxStatus_Upper_E
            TaxStatus_Upper_N
            TaxStatus_Upper_O
        End Enum
        Public Enum ArCustomerSetup_TpmCustomerFlag_Enum
            TpmCustomerFlag_Upper_N
            TpmCustomerFlag_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_TpmPricingFlag_Enum
            TpmPricingFlag_Upper_N
            TpmPricingFlag_Upper_Y
        End Enum
        Public Enum ArCustomerSetup_TpmCreditCheck_Enum
            TpmCreditCheck_Blank
            TpmCreditCheck_Upper_N
            TpmCreditCheck_Upper_Y
        End Enum


#End Region




    End Class
End Namespace
