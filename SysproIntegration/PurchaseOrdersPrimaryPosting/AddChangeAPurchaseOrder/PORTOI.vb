Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.AddChangeAPurchaseOrder.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowBlankLedgerCode
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowNonStockItems
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowPoWhenBlanketPo
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowZeroPrice
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CalcDueDate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FixedExchangeRate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InsertAdditionalPOText
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InsertDangerousGoodsText
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonStockItemsField As AllowNonStockItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonStockItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowZeroPriceField As AllowZeroPrice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowZeroPriceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateWorkingDaysField As ValidateWorkingDays
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateWorkingDaysFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowPoWhenBlanketPoField As AllowPoWhenBlanketPo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowPoWhenBlanketPoFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultMemoCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedExchangeRateField As FixedExchangeRate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedExchangeRateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultMemoDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBlankLedgerCodeField As AllowBlankLedgerCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBlankLedgerCodeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultDeliveryAddressField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private calcDueDateField As CalcDueDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private calcDueDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private insertDangerousGoodsTextField As InsertDangerousGoodsText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private insertDangerousGoodsTextFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private insertAdditionalPOTextField As InsertAdditionalPOText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private insertAdditionalPOTextFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusField As Status
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.validateOnlyField = ValidateOnly.Y
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.allowNonStockItemsField = AllowNonStockItems.N
            Me.allowZeroPriceField = AllowZeroPrice.N
            Me.validateWorkingDaysField = ValidateWorkingDays.N
            Me.allowPoWhenBlanketPoField = AllowPoWhenBlanketPo.N
            Me.fixedExchangeRateField = FixedExchangeRate.N
            Me.allowBlankLedgerCodeField = AllowBlankLedgerCode.Y
            Me.calcDueDateField = CalcDueDate.N
            Me.insertDangerousGoodsTextField = InsertDangerousGoodsText.N
            Me.insertAdditionalPOTextField = InsertAdditionalPOText.N
            Me.statusField = Status.Item1
        End Sub
        
        '''<summary>
        '''Specifies whether to only validate the contents of the document. (N - validate and apply function if no errors, Y - only validate the document). Default Y - (validate only).
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
                Me.ValidateOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings, such as a delivery address code invalid, customer not on file,  P/O line with material allocations, stock superceded due date, invalid price method, invalid ledger code, ledger code on hold, ledger code is a control account, job not found, product class not found or cancelling a line where line is for EDI order, line originates from a S/O, line associated with a job, line has material allocations, adding a miscellaneous line where charge value is zero,  adding a freight line where charge value is zero. If 'W' supplied, these errors will be reported as warnings. If it is not supplied, it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
                Me.IgnoreWarningsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If the stock code supplied does not exist on the inventory master the P/order line will be added as a non-stocked detail line only if the parameter Allow non-stocked items is set to Y (Yes). Default N (No).
        '''</summary>
        Public Property AllowNonStockItems() As AllowNonStockItems
            Get
                Return Me.allowNonStockItemsField
            End Get
            Set
                Me.allowNonStockItemsField = value
                Me.AllowNonStockItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowNonStockItemsSpecified() As Boolean
            Get
                Return Me.allowNonStockItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter will indicate if a zero price will be accepted when saving a new  P/order. (Y - will save line with a zero price, N - will raise an error when no price or default price has been supplied for a P/order line). Default N (No).
        '''</summary>
        Public Property AllowZeroPrice() As AllowZeroPrice
            Get
                Return Me.allowZeroPriceField
            End Get
            Set
                Me.allowZeroPriceField = value
                Me.AllowZeroPriceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowZeroPriceSpecified() As Boolean
            Get
                Return Me.allowZeroPriceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter indicates that the order and due dates will be validated to ensure that these dates are working dates. ( A - no validation will be performed and all dates will be accepted as supplied, P - dates will be validated and if the date falls on a non-working date, the previous working date will be selected, N - dates will be validated and if the date falls on a non-working date, the next working date will be selected). Default N - (No).
        '''</summary>
        Public Property ValidateWorkingDays() As ValidateWorkingDays
            Get
                Return Me.validateWorkingDaysField
            End Get
            Set
                Me.validateWorkingDaysField = value
                Me.ValidateWorkingDaysFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateWorkingDaysSpecified() As Boolean
            Get
                Return Me.validateWorkingDaysFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If the supplier is flagged as Blanket purchase orders in use (supplier set-up - Purchasing tab) - then the program will check if there are any blanket P/order contracts for the stock code and allow the P/order to be added depending on this parameter and the Purchase order set-up  (Option tab) to allow manual entry of P/order when Blanket P/orders exist. Default N (No).
        ''' Based on contract: if the Blanket P/order contract is not fixed and the parameter Allow P/order When Blanket P/order contains 'Y' - lines may be added. However you will not be able to add a P/order line for the stock code if the blanket P/order contract is fixed or the parameter contains 'N'.
        '''Not allowed : You will not be able to add a P/order line if a blanket P/order already exists.
        '''Allowed: You will only be allowed to add a P/order line if the parameter Allow P/order When Blanket P/order contains Y.
        '''
        '''</summary>
        Public Property AllowPoWhenBlanketPo() As AllowPoWhenBlanketPo
            Get
                Return Me.allowPoWhenBlanketPoField
            End Get
            Set
                Me.allowPoWhenBlanketPoField = value
                Me.AllowPoWhenBlanketPoFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowPoWhenBlanketPoSpecified() As Boolean
            Get
                Return Me.allowPoWhenBlanketPoFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates a single character default memo code. This memo code can be used as a means of identifying who raised the purchase order.  The default Memo code will be used for all new orders where a memo code has not been supplied in the Order Header.
        '''</summary>
        Public Property DefaultMemoCode() As String
            Get
                Return Me.defaultMemoCodeField
            End Get
            Set
                Me.defaultMemoCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This parameter will only be relevant if processing an order for a foreign currency supplier and you selected the Allow entry/maintenance of exchange rate option (Purchase Orders Set-up) and the currency has not been flagged as Fixed on the currency conversion table (Accounts payable - Currency Set-up). This parameter will indicate if the order will default to a fixed exchange rate. The current exchange rate is used. Default N - (No).
        '''</summary>
        Public Property FixedExchangeRate() As FixedExchangeRate
            Get
                Return Me.fixedExchangeRateField
            End Get
            Set
                Me.fixedExchangeRateField = value
                Me.FixedExchangeRateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FixedExchangeRateSpecified() As Boolean
            Get
                Return Me.fixedExchangeRateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The memo date for the order header defaults from the order date plus the default memo days supplied if the Memo date is not supplied when adding an order.  This is a 3 digit integer field.
        '''</summary>
        Public Property DefaultMemoDays() As String
            Get
                Return Me.defaultMemoDaysField
            End Get
            Set
                Me.defaultMemoDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the ledger code will be mandatory when adding a non-stocked order line. If this parameter is set to N (No) - a ledger code for non-stocked lines must be supplied. Will default to Y(Yes).
        '''</summary>
        Public Property AllowBlankLedgerCode() As AllowBlankLedgerCode
            Get
                Return Me.allowBlankLedgerCodeField
            End Get
            Set
                Me.allowBlankLedgerCodeField = value
                Me.AllowBlankLedgerCodeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowBlankLedgerCodeSpecified() As Boolean
            Get
                Return Me.allowBlankLedgerCodeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter indicates the default delivery address to be used for all purchase orders.  Will be validated if supplied - if not on file a warning will be issued if the parameter Ignore Warnings contains N (No). This address is only used if the delivery address is not supplied with the purchase order, and the system setting to use the warehouse address is not selected
        '''
        '''</summary>
        Public Property DefaultDeliveryAddress() As String
            Get
                Return Me.defaultDeliveryAddressField
            End Get
            Set
                Me.defaultDeliveryAddressField = value
            End Set
        End Property
        
        '''<summary>
        '''This parameter indicates if you want to calculate the line due date of a stocked line by extending the company date forward by the lead time defined against the stock code. If the calculated date is a non-working date - the next or previous working date can be used depending on the parameter ValidateWorking date. Default N- (No).
        '''</summary>
        Public Property CalcDueDate() As CalcDueDate
            Get
                Return Me.calcDueDateField
            End Get
            Set
                Me.calcDueDateField = value
                Me.CalcDueDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CalcDueDateSpecified() As Boolean
            Get
                Return Me.calcDueDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Any dangerous goods text held against a stocked item being purchase will be inserted automatically if the Purchase order set-up option (Option tab) to Insert dangerous goods text automatically is selected. However if this set-up option is not selected this parameter will indicate if any dangerous goods text should still be inserted for the purchase order. Possible value Y (Yes) or N (No). Default N - (No).
        '''</summary>
        Public Property InsertDangerousGoodsText() As InsertDangerousGoodsText
            Get
                Return Me.insertDangerousGoodsTextField
            End Get
            Set
                Me.insertDangerousGoodsTextField = value
                Me.InsertDangerousGoodsTextFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InsertDangerousGoodsTextSpecified() As Boolean
            Get
                Return Me.insertDangerousGoodsTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Any additional Purchase order text held against a stocked item being purchase will be inserted automatically if the Purchase order set-up option (Option tab) to Insert purchase order additional text automatically is selected. However if this set-up option is not selected this parameter will indicate if any additional purchase order text should still be inserted for the purchase order. Possible value Y (Yes) or N (No). Default N - (No).
        '''</summary>
        Public Property InsertAdditionalPOText() As InsertAdditionalPOText
            Get
                Return Me.insertAdditionalPOTextField
            End Get
            Set
                Me.insertAdditionalPOTextField = value
                Me.InsertAdditionalPOTextFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InsertAdditionalPOTextSpecified() As Boolean
            Get
                Return Me.insertAdditionalPOTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The required status of the purchase order. This only applies when adding a new order. (Status 1 is ready to print, status 4 is already printed). Default is 1.
        '''</summary>
        Public Property Status() As Status
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
                Me.StatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StatusSpecified() As Boolean
            Get
                Return Me.statusFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateWorkingDays
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
        
        '''<remarks/>
        A
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Status
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostPurchaseOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This element contains the optional parameter elements.
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
