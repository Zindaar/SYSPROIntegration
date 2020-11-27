Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO

Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class InvoiceQuery
        Implements IQuery

#Region "Private Data Members"

        Dim _xQuery As String = String.Empty
        Dim _xOption As String = String.Empty
        Dim _Reprint As InvoiceQuery_Reprint_Enum = InvoiceQuery_Reprint_Enum.Reprint_Upper_Y
        Dim _DocumentType As InvoiceQuery_DocumentType_Enum = InvoiceQuery_DocumentType_Enum.DocumentType_Upper_I
        Dim _IncludeForms As InvoiceQuery_IncludeForms_Enum = InvoiceQuery_IncludeForms_Enum.IncludeForms_Upper_N
        Dim _IncludeCustomerForms As InvoiceQuery_IncludeCustomerForms_Enum = InvoiceQuery_IncludeCustomerForms_Enum.IncludeCustomerForms_Upper_N
        Dim _IncludeStockForms As InvoiceQuery_IncludeStockForms_Enum = InvoiceQuery_IncludeStockForms_Enum.IncludeStockForms_Upper_N
        Dim _IncludeDetailForms As InvoiceQuery_IncludeDetailForms_Enum = InvoiceQuery_IncludeDetailForms_Enum.IncludeDetailForms_Upper_N
        Dim _IncludeNotes As InvoiceQuery_IncludeNotes_Enum = InvoiceQuery_IncludeNotes_Enum.IncludeNotes_Upper_N
        Dim _IgnorePrintStatus As InvoiceQuery_IgnorePrintStatus_Enum = InvoiceQuery_IgnorePrintStatus_Enum.IgnorePrintStatus_Upper_Y
        Dim _RoundMass As InvoiceQuery_RoundMass_Enum = InvoiceQuery_RoundMass_Enum.RoundMass_Upper_O
        Dim _RoundMassDecs As String = String.Empty
        Dim _RoundVolume As InvoiceQuery_RoundVolume_Enum = InvoiceQuery_RoundVolume_Enum.RoundVolume_Upper_O
        Dim _RoundVolumeDecs As String = String.Empty
        Dim _XslStylesheet As String = String.Empty
        Dim _Filter As String = String.Empty
        Dim _Branch As String = String.Empty
        Dim _Branch_FilterType As InvoiceQuery_Branch_FilterType_Enum = InvoiceQuery_Branch_FilterType_Enum.Branch_FilterType_Upper_A
        Dim _Branch_FilterValue As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _Customer_FilterType As InvoiceQuery_Customer_FilterType_Enum = InvoiceQuery_Customer_FilterType_Enum.Customer_FilterType_Upper_A
        Dim _Customer_FilterValue As String = String.Empty
        Dim _SourceWarehouse As String = String.Empty
        Dim _SourceWarehouse_FilterType As InvoiceQuery_SourceWarehouse_FilterType_Enum = InvoiceQuery_SourceWarehouse_FilterType_Enum.SourceWarehouse_FilterType_Upper_A
        Dim _SourceWarehouse_FilterValue As String = String.Empty
        Dim _TargetWarehouse As String = String.Empty
        Dim _TargetWarehouse_FilterType As InvoiceQuery_TargetWarehouse_FilterType_Enum = InvoiceQuery_TargetWarehouse_FilterType_Enum.TargetWarehouse_FilterType_Upper_A
        Dim _TargetWarehouse_FilterValue As String = String.Empty
        Dim _OrderType As String = String.Empty
        Dim _OrderType_FilterType As InvoiceQuery_OrderType_FilterType_Enum = InvoiceQuery_OrderType_FilterType_Enum.OrderType_FilterType_Upper_A
        Dim _OrderType_FilterValue As String = String.Empty
        Dim _CustomerPo As String = String.Empty
        Dim _CustomerPo_FilterType As InvoiceQuery_CustomerPo_FilterType_Enum = InvoiceQuery_CustomerPo_FilterType_Enum.CustomerPo_FilterType_Upper_A
        Dim _CustomerPo_FilterValue As InvoiceQuery_CustomerPo_FilterValue_Enum
        Dim _InvoiceNumber As String = String.Empty
        Dim _InvoiceNumber_FilterType As InvoiceQuery_InvoiceNumber_FilterType_Enum = InvoiceQuery_InvoiceNumber_FilterType_Enum.InvoiceNumber_FilterType_Upper_A
        Dim _InvoiceNumber_FilterValue As String = String.Empty
        Dim _GtrReference As String = String.Empty
        Dim _GtrReference_FilterType As InvoiceQuery_GtrReference_FilterType_Enum = InvoiceQuery_GtrReference_FilterType_Enum.GtrReference_FilterType_Upper_A
        Dim _GtrReference_FilterValue As String = String.Empty
        Dim _SalesOrder As String = String.Empty
        Dim _SalesOrder_FilterType As InvoiceQuery_SalesOrder_FilterType_Enum = InvoiceQuery_SalesOrder_FilterType_Enum.SalesOrder_FilterType_Upper_A
        Dim _SalesOrder_FilterValue As String = String.Empty
        Dim _InvoiceDate As String = String.Empty
        Dim _InvoiceDate_FilterType As InvoiceQuery_InvoiceDate_FilterType_Enum = InvoiceQuery_InvoiceDate_FilterType_Enum.InvoiceDate_FilterType_Upper_A
        Dim _InvoiceDate_FilterValue As String = String.Empty
        Dim _xOperator As String = String.Empty
        Dim _Operator_FilterType As InvoiceQuery_Operator_FilterType_Enum = InvoiceQuery_Operator_FilterType_Enum.Operator_FilterType_Upper_A
        Dim _Operator_FilterValue As String = String.Empty
        Dim _GeographicArea As String = String.Empty
        Dim _GeographicArea_FilterType As InvoiceQuery_GeographicArea_FilterType_Enum = InvoiceQuery_GeographicArea_FilterType_Enum.GeographicArea_FilterType_Upper_A
        Dim _GeographicArea_FilterValue As String = String.Empty


#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xQuery() As String
            Get
                Return _xQuery
            End Get
            Set(ByVal Value As String)
                _xQuery = Value
            End Set
        End Property

        ''' <summary> 
        '''  List of options.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xOption() As String
            Get
                Return _xOption
            End Get
            Set(ByVal Value As String)
                _xOption = Value
            End Set
        End Property

        ''' <summary> 
        '''  This indicates if an original document is to be returned, or one which has already been printed or presented as XML. Valid entries are 'N' and 'Y'. Default is 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Reprint() As InvoiceQuery_Reprint_Enum
            Get
                Return _Reprint
            End Get
            Set(ByVal Value As InvoiceQuery_Reprint_Enum)
                _Reprint = Value
            End Set
        End Property

        ''' <summary> 
        '''  The type of document to be returned - 'I- Invoice, C- Credit Note, D - Debit Note, G - Goods in Transit Supply Chain Transfer - default is 'I'
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DocumentType() As InvoiceQuery_DocumentType_Enum
            Get
                Return _DocumentType
            End Get
            Set(ByVal Value As InvoiceQuery_DocumentType_Enum)
                _DocumentType = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether custom form information attached to the sales order should be returned. Valid entries are 'N' - no, and 'Y' - yes. The default is 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeForms() As InvoiceQuery_IncludeForms_Enum
            Get
                Return _IncludeForms
            End Get
            Set(ByVal Value As InvoiceQuery_IncludeForms_Enum)
                _IncludeForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether custom form information for the invoice customer should be returned. Valid entries are 'N' - no, and 'Y' - yes. The default is 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCustomerForms() As InvoiceQuery_IncludeCustomerForms_Enum
            Get
                Return _IncludeCustomerForms
            End Get
            Set(ByVal Value As InvoiceQuery_IncludeCustomerForms_Enum)
                _IncludeCustomerForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether custom form information for the stock code on a detail stocked merchandise line should be returned. Valid entries are 'N' - no, and 'Y' - yes. The default is 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeStockForms() As InvoiceQuery_IncludeStockForms_Enum
            Get
                Return _IncludeStockForms
            End Get
            Set(ByVal Value As InvoiceQuery_IncludeStockForms_Enum)
                _IncludeStockForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether custom form information for the detail merchandise line should be returned. Valid entries are 'N' - no, and 'Y' - yes. The default is 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeDetailForms() As InvoiceQuery_IncludeDetailForms_Enum
            Get
                Return _IncludeDetailForms
            End Get
            Set(ByVal Value As InvoiceQuery_IncludeDetailForms_Enum)
                _IncludeDetailForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether notepad information attached to the invoice sales order should be returned. Valid entries are 'N' - no, and 'Y' - yes. The default is 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeNotes() As InvoiceQuery_IncludeNotes_Enum
            Get
                Return _IncludeNotes
            End Get
            Set(ByVal Value As InvoiceQuery_IncludeNotes_Enum)
                _IncludeNotes = Value
            End Set
        End Property

        ''' <summary> 
        '''  If this element is set to 'Y', it will over-ride the contents of the 'Reprint' option. Any invoices selected through other criteria will be returned, regardless of the print status for the document. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnorePrintStatus() As InvoiceQuery_IgnorePrintStatus_Enum
            Get
                Return _IgnorePrintStatus
            End Get
            Set(ByVal Value As InvoiceQuery_IgnorePrintStatus_Enum)
                _IgnorePrintStatus = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element controls the rounding of the mass on individual merchandise lines. The rounded figure is added to the total mass for the document. The number of decimals is controlled by the 'RoundMassDecs' option. The rounding is O - 'off', 'U' - up, or 'D' down. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RoundMass() As InvoiceQuery_RoundMass_Enum
            Get
                Return _RoundMass
            End Get
            Set(ByVal Value As InvoiceQuery_RoundMass_Enum)
                _RoundMass = Value
            End Set
        End Property

        ''' <summary> 
        '''  This controls the number of decimals used in the rounding of mass as described in 'RoundMass'. A single digit in the range 0 to 6 must be provided. If this element is not used, then the number of decimal places in the mass (currently 6) is used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RoundMassDecs() As String
            Get
                Return _RoundMassDecs
            End Get
            Set(ByVal Value As String)
                _RoundMassDecs = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element controls the rounding of the volume on individual merchandise lines. The rounded figure is added to the total volume for the document. The number of decimals is controlled by the 'RoundVolumeDecs' option. The rounding is 'O' - off, 'U' - up, or 'D' down. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RoundVolume() As InvoiceQuery_RoundVolume_Enum
            Get
                Return _RoundVolume
            End Get
            Set(ByVal Value As InvoiceQuery_RoundVolume_Enum)
                _RoundVolume = Value
            End Set
        End Property

        ''' <summary> 
        '''  This controls the number of decimals used in the rounding of volume as described in 'RoundVolume'. A single digit in the range 0 to 6 must be provided. If this element is not used, then the number of decimal places in the volume (currently 6) is used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RoundVolumeDecs() As String
            Get
                Return _RoundVolumeDecs
            End Get
            Set(ByVal Value As String)
                _RoundVolumeDecs = Value
            End Set
        End Property

        ''' <summary> 
        '''  The XSL Stylesheet to be used
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property XslStylesheet() As String
            Get
                Return _XslStylesheet
            End Get
            Set(ByVal Value As String)
                _XslStylesheet = Value
            End Set
        End Property

        ''' <summary> 
        '''  This contains one or more filters to restrict the number of documents returned.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Filter() As String
            Get
                Return _Filter
            End Get
            Set(ByVal Value As String)
                _Filter = Value
            End Set
        End Property

        ''' <summary> 
        '''  Branch to be selected (FilterType of A - All, R - Range or S - Single branch, FilterValue contains a range of branches separated by commas if FilterType is R or a single branch if S).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Branch_FilterType() As InvoiceQuery_Branch_FilterType_Enum
            Get
                Return _Branch_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_Branch_FilterType_Enum)
                _Branch_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Branch_FilterValue() As String
            Get
                Return _Branch_FilterValue
            End Get
            Set(ByVal Value As String)
                _Branch_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Customer to be selected (FilterType of A - All, R - Range or L - List of customers, FilterValue contains a range or list of customers separated by commas if FilterType is R or L).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer_FilterType() As InvoiceQuery_Customer_FilterType_Enum
            Get
                Return _Customer_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_Customer_FilterType_Enum)
                _Customer_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer_FilterValue() As String
            Get
                Return _Customer_FilterValue
            End Get
            Set(ByVal Value As String)
                _Customer_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Warehouse to be selected (FilterType of A - All, R - Range or L - List of warehouses, FilterValue contains a range or list of warehouses separated by commas if FilterType is R or L). This only applies to a Goods in Transit transfer, and is applied to the source warehouse
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SourceWarehouse_FilterType() As InvoiceQuery_SourceWarehouse_FilterType_Enum
            Get
                Return _SourceWarehouse_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_SourceWarehouse_FilterType_Enum)
                _SourceWarehouse_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SourceWarehouse_FilterValue() As String
            Get
                Return _SourceWarehouse_FilterValue
            End Get
            Set(ByVal Value As String)
                _SourceWarehouse_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Warehouse to be selected (FilterType of A - All, R - Range or L - List of warehouses, FilterValue contains a range or list of warehouses separated by commas if FilterType is R or L). This only applies to a Goods in Transit transfer, and is applied to the target warehouse
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TargetWarehouse_FilterType() As InvoiceQuery_TargetWarehouse_FilterType_Enum
            Get
                Return _TargetWarehouse_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_TargetWarehouse_FilterType_Enum)
                _TargetWarehouse_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TargetWarehouse_FilterValue() As String
            Get
                Return _TargetWarehouse_FilterValue
            End Get
            Set(ByVal Value As String)
                _TargetWarehouse_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Order type to be selected (FilterType of A - All, R - Range or S - Single order types, FilterValue contains a range of order types separated by commas if FilterType is R or a single order type if S).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderType_FilterType() As InvoiceQuery_OrderType_FilterType_Enum
            Get
                Return _OrderType_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_OrderType_FilterType_Enum)
                _OrderType_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderType_FilterValue() As String
            Get
                Return _OrderType_FilterValue
            End Get
            Set(ByVal Value As String)
                _OrderType_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Customer purchase order number to be selected (FilterType of A - All, S - Single p/o number, FilterValue contains the selected p/o number if FilterType is S).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerPo_FilterType() As InvoiceQuery_CustomerPo_FilterType_Enum
            Get
                Return _CustomerPo_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_CustomerPo_FilterType_Enum)
                _CustomerPo_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerPo_FilterValue() As InvoiceQuery_CustomerPo_FilterValue_Enum
            Get
                Return _CustomerPo_FilterValue
            End Get
            Set(ByVal Value As InvoiceQuery_CustomerPo_FilterValue_Enum)
                _CustomerPo_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Invoice to be selected (FilterType of A - All, R - Range or L - List of invoice numbers, FilterValue contains a range or list of invoice numbers separated by commas if FilterType is R or L).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceNumber_FilterType() As InvoiceQuery_InvoiceNumber_FilterType_Enum
            Get
                Return _InvoiceNumber_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_InvoiceNumber_FilterType_Enum)
                _InvoiceNumber_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceNumber_FilterValue() As String
            Get
                Return _InvoiceNumber_FilterValue
            End Get
            Set(ByVal Value As String)
                _InvoiceNumber_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Goods in transit number to be selected (FilterType of A - All, R - Range or L - List of numbers, FilterValue contains a range or list of numbers separated by commas if FilterType is R or L). This is only used if Document Type is 'S' - Supply Chain Transfer
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GtrReference_FilterType() As InvoiceQuery_GtrReference_FilterType_Enum
            Get
                Return _GtrReference_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_GtrReference_FilterType_Enum)
                _GtrReference_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GtrReference_FilterValue() As String
            Get
                Return _GtrReference_FilterValue
            End Get
            Set(ByVal Value As String)
                _GtrReference_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Sales order to be selected (FilterType of A - All, R - Range or L - List of sales orders, FilterValue contains a range or list of sales orders separated by commas if FilterType is R or L).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SalesOrder_FilterType() As InvoiceQuery_SalesOrder_FilterType_Enum
            Get
                Return _SalesOrder_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_SalesOrder_FilterType_Enum)
                _SalesOrder_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SalesOrder_FilterValue() As String
            Get
                Return _SalesOrder_FilterValue
            End Get
            Set(ByVal Value As String)
                _SalesOrder_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Invoice date to be selected (FilterType of A - All, R - Range or S - Single invoice date, FilterValue contains a range of invoice dates separated by commas if FilterType is R or a single sales order date if S).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceDate_FilterType() As InvoiceQuery_InvoiceDate_FilterType_Enum
            Get
                Return _InvoiceDate_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_InvoiceDate_FilterType_Enum)
                _InvoiceDate_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceDate_FilterValue() As String
            Get
                Return _InvoiceDate_FilterValue
            End Get
            Set(ByVal Value As String)
                _InvoiceDate_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Operator to be selected (FilterType of A - All, S - Single operator, FilterValue contains the selected operator if FilterType is S).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Operator_FilterType() As InvoiceQuery_Operator_FilterType_Enum
            Get
                Return _Operator_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_Operator_FilterType_Enum)
                _Operator_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Operator_FilterValue() As String
            Get
                Return _Operator_FilterValue
            End Get
            Set(ByVal Value As String)
                _Operator_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Geographic area to be selected (FilterType of A - All, S - Single geographic area, FilterValue contains the selected geographic area if FilterType is S)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GeographicArea_FilterType() As InvoiceQuery_GeographicArea_FilterType_Enum
            Get
                Return _GeographicArea_FilterType
            End Get
            Set(ByVal Value As InvoiceQuery_GeographicArea_FilterType_Enum)
                _GeographicArea_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GeographicArea_FilterValue() As String
            Get
                Return _GeographicArea_FilterValue
            End Get
            Set(ByVal Value As String)
                _GeographicArea_FilterValue = Value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum InvoiceQuery_Reprint_Enum
            Reprint_Upper_Y
            Reprint_Upper_N
        End Enum
        Public Enum InvoiceQuery_DocumentType_Enum
            DocumentType_Upper_I
            DocumentType_Upper_C
            DocumentType_Upper_D
            DocumentType_Upper_G
        End Enum
        Public Enum InvoiceQuery_IncludeForms_Enum
            IncludeForms_Upper_N
            IncludeForms_Upper_Y
            IncludeForms_Upper_
        End Enum
        Public Enum InvoiceQuery_IncludeCustomerForms_Enum
            IncludeCustomerForms_Upper_N
            IncludeCustomerForms_Upper_Y
            IncludeCustomerForms_Upper_
        End Enum
        Public Enum InvoiceQuery_IncludeStockForms_Enum
            IncludeStockForms_Upper_N
            IncludeStockForms_Upper_Y
            IncludeStockForms_Upper_
        End Enum
        Public Enum InvoiceQuery_IncludeDetailForms_Enum
            IncludeDetailForms_Upper_N
            IncludeDetailForms_Upper_Y
            IncludeDetailForms_Upper_
        End Enum
        Public Enum InvoiceQuery_IncludeNotes_Enum
            IncludeNotes_Upper_N
            IncludeNotes_Upper_Y
            IncludeNotes_Upper_
        End Enum
        Public Enum InvoiceQuery_IgnorePrintStatus_Enum
            IgnorePrintStatus_Upper_N
            IgnorePrintStatus_Upper_Y
            IgnorePrintStatus_Upper_
        End Enum
        Public Enum InvoiceQuery_RoundMass_Enum
            RoundMass_Upper_O
            RoundMass_Upper_U
            RoundMass_Upper_D
        End Enum
        Public Enum InvoiceQuery_RoundVolume_Enum
            RoundVolume_Upper_O
            RoundVolume_Upper_U
            RoundVolume_Upper_D
        End Enum
        Public Enum InvoiceQuery_Branch_FilterType_Enum
            Branch_FilterType_Upper_A
            Branch_FilterType_Upper_R
            Branch_FilterType_Upper_S
            Branch_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_Customer_FilterType_Enum
            Customer_FilterType_Upper_A
            Customer_FilterType_Upper_R
            Customer_FilterType_Upper_L
            Customer_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_SourceWarehouse_FilterType_Enum
            SourceWarehouse_FilterType_Upper_A
            SourceWarehouse_FilterType_Upper_R
            SourceWarehouse_FilterType_Upper_L
        End Enum
        Public Enum InvoiceQuery_TargetWarehouse_FilterType_Enum
            TargetWarehouse_FilterType_Upper_A
            TargetWarehouse_FilterType_Upper_R
            TargetWarehouse_FilterType_Upper_L
        End Enum
        Public Enum InvoiceQuery_OrderType_FilterType_Enum
            OrderType_FilterType_Upper_A
            OrderType_FilterType_Upper_R
            OrderType_FilterType_Upper_S
            OrderType_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_CustomerPo_FilterType_Enum
            CustomerPo_FilterType_Upper_A
            CustomerPo_FilterType_Upper_S
        End Enum
        Public Enum InvoiceQuery_CustomerPo_FilterValue_Enum
            CustomerPo_FilterValue_Upper_A
            CustomerPo_FilterValue_Upper_S
            CustomerPo_FilterValue_Upper_
        End Enum
        Public Enum InvoiceQuery_InvoiceNumber_FilterType_Enum
            InvoiceNumber_FilterType_Upper_A
            InvoiceNumber_FilterType_Upper_R
            InvoiceNumber_FilterType_Upper_L
        End Enum
        Public Enum InvoiceQuery_GtrReference_FilterType_Enum
            GtrReference_FilterType_Upper_A
            GtrReference_FilterType_Upper_R
            GtrReference_FilterType_Upper_L
        End Enum
        Public Enum InvoiceQuery_SalesOrder_FilterType_Enum
            SalesOrder_FilterType_Upper_A
            SalesOrder_FilterType_Upper_R
            SalesOrder_FilterType_Upper_L
            SalesOrder_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_InvoiceDate_FilterType_Enum
            InvoiceDate_FilterType_Upper_A
            InvoiceDate_FilterType_Upper_R
            InvoiceDate_FilterType_Upper_S
            InvoiceDate_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_Operator_FilterType_Enum
            Operator_FilterType_Upper_A
            Operator_FilterType_Upper_S
            Operator_FilterType_Upper_
        End Enum
        Public Enum InvoiceQuery_GeographicArea_FilterType_Enum
            GeographicArea_FilterType_Upper_A
            GeographicArea_FilterType_Upper_S
            GeographicArea_FilterType_Upper_
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim xQuery As System.Xml.XmlElement = xmlDoc.CreateElement("Query")
            Dim xOption As System.Xml.XmlElement = xmlDoc.CreateElement("Option")
            Dim Reprint As System.Xml.XmlElement = xmlDoc.CreateElement("Reprint")
            Dim DocumentType As System.Xml.XmlElement = xmlDoc.CreateElement("DocumentType")
            Dim IncludeForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeForms")
            Dim IncludeCustomerForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCustomerForms")
            Dim IncludeStockForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeStockForms")
            Dim IncludeDetailForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeDetailForms")
            Dim IncludeNotes As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeNotes")
            Dim IgnorePrintStatus As System.Xml.XmlElement = xmlDoc.CreateElement("IgnorePrintStatus")
            Dim RoundMass As System.Xml.XmlElement = xmlDoc.CreateElement("RoundMass")
            Dim RoundMassDecs As System.Xml.XmlElement = xmlDoc.CreateElement("RoundMassDecs")
            Dim RoundVolume As System.Xml.XmlElement = xmlDoc.CreateElement("RoundVolume")
            Dim RoundVolumeDecs As System.Xml.XmlElement = xmlDoc.CreateElement("RoundVolumeDecs")
            Dim XslStylesheet As System.Xml.XmlElement = xmlDoc.CreateElement("XslStylesheet")
            Dim Filter As System.Xml.XmlElement = xmlDoc.CreateElement("Filter")
            Dim Branch As System.Xml.XmlElement = xmlDoc.CreateElement("Branch")
            Dim Branch_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim Branch_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim Customer_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim Customer_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim SourceWarehouse As System.Xml.XmlElement = xmlDoc.CreateElement("SourceWarehouse")
            Dim SourceWarehouse_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim SourceWarehouse_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim TargetWarehouse As System.Xml.XmlElement = xmlDoc.CreateElement("TargetWarehouse")
            Dim TargetWarehouse_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim TargetWarehouse_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim OrderType As System.Xml.XmlElement = xmlDoc.CreateElement("OrderType")
            Dim OrderType_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim OrderType_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim CustomerPo As System.Xml.XmlElement = xmlDoc.CreateElement("CustomerPo")
            Dim CustomerPo_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim CustomerPo_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim InvoiceNumber As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceNumber")
            Dim InvoiceNumber_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim InvoiceNumber_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim GtrReference As System.Xml.XmlElement = xmlDoc.CreateElement("GtrReference")
            Dim GtrReference_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim GtrReference_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim SalesOrder As System.Xml.XmlElement = xmlDoc.CreateElement("SalesOrder")
            Dim SalesOrder_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim SalesOrder_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim InvoiceDate As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceDate")
            Dim InvoiceDate_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim InvoiceDate_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim xOperator As System.Xml.XmlElement = xmlDoc.CreateElement("xOperator")
            Dim Operator_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim Operator_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")
            Dim GeographicArea As System.Xml.XmlElement = xmlDoc.CreateElement("GeographicArea")
            Dim GeographicArea_FilterType As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterType")
            Dim GeographicArea_FilterValue As System.Xml.XmlAttribute = xmlDoc.CreateAttribute("FilterValue")

            xmlDoc.AppendChild(xQuery)
            Common.SysproUtilities.AppendXMLElement(xQuery, xOption, _xOption.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, Reprint, Common.SysproUtilities.GetEnumValue(_Reprint.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, DocumentType, Common.SysproUtilities.GetEnumValue(_DocumentType.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeForms, Common.SysproUtilities.GetEnumValue(_IncludeForms.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCustomerForms, Common.SysproUtilities.GetEnumValue(_IncludeCustomerForms.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeStockForms, Common.SysproUtilities.GetEnumValue(_IncludeStockForms.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeDetailForms, Common.SysproUtilities.GetEnumValue(_IncludeDetailForms.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeNotes, Common.SysproUtilities.GetEnumValue(_IncludeNotes.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IgnorePrintStatus, Common.SysproUtilities.GetEnumValue(_IgnorePrintStatus.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, RoundMass, Common.SysproUtilities.GetEnumValue(_RoundMass.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, RoundMassDecs, _RoundMassDecs.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, RoundVolume, Common.SysproUtilities.GetEnumValue(_RoundVolume.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, RoundVolumeDecs, _RoundVolumeDecs.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, XslStylesheet, _XslStylesheet.ToString)
            Common.SysproUtilities.AppendXMLElement(xQuery, Filter, _Filter.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, Branch, _Branch.ToString)
            Common.SysproUtilities.AppendXMLAttribute(Branch, Branch_FilterType, Common.SysproUtilities.GetEnumValue(_Branch_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(Branch, Branch_FilterValue, _Branch_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLAttribute(Customer, Customer_FilterType, Common.SysproUtilities.GetEnumValue(_Customer_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(Customer, Customer_FilterValue, _Customer_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, SourceWarehouse, _SourceWarehouse.ToString)
            Common.SysproUtilities.AppendXMLAttribute(SourceWarehouse, SourceWarehouse_FilterType, Common.SysproUtilities.GetEnumValue(_SourceWarehouse_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(SourceWarehouse, SourceWarehouse_FilterValue, _SourceWarehouse_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, TargetWarehouse, _TargetWarehouse.ToString)
            Common.SysproUtilities.AppendXMLAttribute(TargetWarehouse, TargetWarehouse_FilterType, Common.SysproUtilities.GetEnumValue(_TargetWarehouse_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(TargetWarehouse, TargetWarehouse_FilterValue, _TargetWarehouse_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, OrderType, _OrderType.ToString)
            Common.SysproUtilities.AppendXMLAttribute(OrderType, OrderType_FilterType, Common.SysproUtilities.GetEnumValue(_OrderType_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(OrderType, OrderType_FilterValue, _OrderType_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, CustomerPo, _CustomerPo.ToString)
            Common.SysproUtilities.AppendXMLAttribute(CustomerPo, CustomerPo_FilterType, Common.SysproUtilities.GetEnumValue(_CustomerPo_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(CustomerPo, CustomerPo_FilterValue, Common.SysproUtilities.GetEnumValue(_CustomerPo_FilterValue.ToString))
            Common.SysproUtilities.AppendXMLElement(Filter, InvoiceNumber, _InvoiceNumber.ToString)
            Common.SysproUtilities.AppendXMLAttribute(InvoiceNumber, InvoiceNumber_FilterType, Common.SysproUtilities.GetEnumValue(_InvoiceNumber_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(InvoiceNumber, InvoiceNumber_FilterValue, _InvoiceNumber_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, GtrReference, _GtrReference.ToString)
            Common.SysproUtilities.AppendXMLAttribute(GtrReference, GtrReference_FilterType, Common.SysproUtilities.GetEnumValue(_GtrReference_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(GtrReference, GtrReference_FilterValue, _GtrReference_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, SalesOrder, _SalesOrder.ToString)
            Common.SysproUtilities.AppendXMLAttribute(SalesOrder, SalesOrder_FilterType, Common.SysproUtilities.GetEnumValue(_SalesOrder_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(SalesOrder, SalesOrder_FilterValue, _SalesOrder_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, InvoiceDate, _InvoiceDate.ToString)
            Common.SysproUtilities.AppendXMLAttribute(InvoiceDate, InvoiceDate_FilterType, Common.SysproUtilities.GetEnumValue(_InvoiceDate_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(InvoiceDate, InvoiceDate_FilterValue, _InvoiceDate_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, xOperator, _xOperator.ToString)
            Common.SysproUtilities.AppendXMLAttribute(xOperator, Operator_FilterType, Common.SysproUtilities.GetEnumValue(_Operator_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(xOperator, Operator_FilterValue, _Operator_FilterValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Filter, GeographicArea, _GeographicArea.ToString)
            Common.SysproUtilities.AppendXMLAttribute(GeographicArea, GeographicArea_FilterType, Common.SysproUtilities.GetEnumValue(_GeographicArea_FilterType.ToString))
            Common.SysproUtilities.AppendXMLAttribute(GeographicArea, GeographicArea_FilterValue, _GeographicArea_FilterValue.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region " IQuery Interface "

        Private _actionType As CommonEnums.ActionType_Query
        Public Property ActionType() As CommonEnums.ActionType_Query Implements IQuery.ActionType
            Get
                Return _actionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                _actionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "SORQID"
            End Get
        End Property

        Public Sub Post() Implements IQuery.Post
            Select Case _actionType
                Case CommonEnums.ActionType_Query.Browse
                    _xmlOut = Query.Browse(Me)
                Case CommonEnums.ActionType_Query.Fetch
                    _xmlOut = Query.Fetch(Me)
                Case CommonEnums.ActionType_Query.NextKey
                    _xmlOut = Query.NextKey(Me)
                Case CommonEnums.ActionType_Query.PreviousKey
                    _xmlOut = Query.PreviousKey(Me)
                Case CommonEnums.ActionType_Query.Query
                    _xmlOut = Query.Query(Me)
            End Select
        End Sub

        Public ReadOnly Property xmlData() As String Implements IQuery.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

#End Region

    End Class

End Namespace
