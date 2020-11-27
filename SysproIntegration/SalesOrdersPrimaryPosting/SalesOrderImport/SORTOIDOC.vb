Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderImport.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllocationAction
        
        '''<remarks/>
        F
        
        '''<remarks/>
        B
        
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
    Public Enum AlwaysUseDiscountEntered
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AlwaysUsePriceEntered
        
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
    Partial Public Class CommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedLineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeField As CommentType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
            Me.commentTypeField = CommentType.I
        End Sub
        
        '''<summary>
        '''For a new order, this will be the line number from the customer's original order, and may not relate to the sales order line number within SYSPRO as comment or components may be added automatically, in which case multiple lines may be present for each line. If the LineActionType is C or D (change or cancel) this entry is mandatory, and refers to the actual line number on the order. This can be from 1 to 9999.
        '''</summary>
        Public Property CustomerPoLine() As String
            Get
                Return Me.customerPoLineField
            End Get
            Set
                Me.customerPoLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The action to be performed for this order line. The action can be:  A - Add a sales order line, C - Change an existing sales order line, D - Cancel the sales order line. If the OrderActionType is A for a new order, all the detail lines must contain a LineActionType of A.
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the comment. The format is 100 characters, alphanumeric.
        '''</summary>
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the detail line number to which the comment line is attached.
        '''</summary>
        Public Property AttachedLineNumber() As String
            Get
                Return Me.attachedLineNumberField
            End Get
            Set
                Me.attachedLineNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The comment type specifies whether the comment is for the order only, or for both order and invoice. The valid entries are 'O' (Order only), and 'I' (Invoice and Order) and blank. The default is 'I' .  This is only used when adding a new comment line.
        '''</summary>
        Public Property CommentType() As CommentType
            Get
                Return Me.commentTypeField
            End Get
            Set
                Me.commentTypeField = value
                Me.CommentTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CommentTypeSpecified() As Boolean
            Get
                Return Me.commentTypeFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum LineActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CommentType
        
        '''<remarks/>
        I
        
        '''<remarks/>
        O
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ConfigPrintInv
        
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
    Public Enum ConfigPrintDel
        
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
    Public Enum ConfigPrintAck
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DeliveryLoad
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryRouteCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliverySequenceField As String
        
        '''<summary>
        '''Only relevant if load planning is in use. It is the Delivery Route Code for the delivery load of the detail line. If used it must be a valid delivery route code. 
        '''</summary>
        Public Property DeliveryRouteCode() As String
            Get
                Return Me.deliveryRouteCodeField
            End Get
            Set
                Me.deliveryRouteCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the delivery date for the delivery load.  Valid only when Load Planning is in use.
        '''</summary>
        Public Property DeliveryDate() As String
            Get
                Return Me.deliveryDateField
            End Get
            Set
                Me.deliveryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Only relevant if load planning is in use. It is the Delivery Sequence for the delivery load of the detail line.
        '''</summary>
        Public Property DeliverySequence() As String
            Get
                Return Me.deliverySequenceField
            End Get
            Set
                Me.deliverySequenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DeliveryRouteAction
        
        '''<remarks/>
        N
        
        '''<remarks/>
        E
        
        '''<remarks/>
        C
        
        '''<remarks/>
        X
        
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
    Partial Public Class FreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineCancelCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableField As FreightNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableField As FreightNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
        End Sub
        
        '''<summary>
        '''For a new order, this will be the line number from the customer's original order, and may not relate to the sales order line number within SYSPRO as comment or components may be added automatically, in which case multiple lines may be present for each line. If the LineActionType is C or D (change or cancel) this entry is mandatory, and refers to the actual line number on the order. This can be from 1 to 9999.
        '''</summary>
        Public Property CustomerPoLine() As String
            Get
                Return Me.customerPoLineField
            End Get
            Set
                Me.customerPoLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The action to be performed for this order line. The action can be:  A - Add a sales order line, C - Change an existing sales order line, D - Cancel the sales order line. If the OrderActionType is A for a new order, all the detail lines must contain a LineActionType of A.
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only required if the detail line has a LineActionType of 'D' - delete. If the SYSPRO setup option to retain analysis details for cancelled order lines is selected, then the contents of this element must be a valid Cancel Reason code within SYSPRO, or the element 'CancelReasoncode' within the order header must contain a valid Cancel Reason code. It can contain 1 to 6 alphanumeric characters.
        '''</summary>
        Public Property LineCancelCode() As String
            Get
                Return Me.lineCancelCodeField
            End Get
            Set
                Me.lineCancelCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the value of the freight charge. The format is 12.2 either positive or negative. The negative sign can either precede or follow the value.
        '''</summary>
        Public Property FreightValue() As String
            Get
                Return Me.freightValueField
            End Get
            Set
                Me.freightValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the cost of the freight entry. The format is 12.2 either positive or negative. The negative sign can either precede or follow the value.
        '''</summary>
        Public Property FreightCost() As String
            Get
                Return Me.freightCostField
            End Get
            Set
                Me.freightCostField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to be assigned to the freight charge. If this is present it must be a valid SYSPRO tax code. The format is 3 character, alphanumeric.When using Descriptive Tax Codes, a descriptive tax code must be provided.
        '''</summary>
        Public Property FreightTaxCode() As String
            Get
                Return Me.freightTaxCodeField
            End Get
            Set
                Me.freightTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default tax status of the freight detail line. If the order is subject to sales tax, then setting this element to 'Y' will cause the line to have no sales tax applied. The element may contain 'Y' (not taxable) or blank (default).
        '''</summary>
        Public Property FreightNotTaxable() As FreightNotTaxable
            Get
                Return Me.freightNotTaxableField
            End Get
            Set
                Me.freightNotTaxableField = value
                Me.FreightNotTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightNotTaxableSpecified() As Boolean
            Get
                Return Me.freightNotTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the Canadian Federal Sales Tax code to be assigned to this freight charge. If the Canadian FST system is in use and a tax code is present, it must be valid within SYSPRO. The format is 3 character, alphanumeric.
        '''</summary>
        Public Property FreightFstCode() As String
            Get
                Return Me.freightFstCodeField
            End Get
            Set
                Me.freightFstCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default FST (Canadian tax system) status of the freight detail line. If the order is subject to FST, then setting this element to 'Y' will cause the line to have no FST applied. The element may contain 'Y' (not taxable) or blank (default).
        '''</summary>
        Public Property FreightNotFstTaxable() As FreightNotFstTaxable
            Get
                Return Me.freightNotFstTaxableField
            End Get
            Set
                Me.freightNotFstTaxableField = value
                Me.FreightNotFstTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightNotFstTaxableSpecified() As Boolean
            Get
                Return Me.freightNotFstTaxableFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FreightNotTaxable
        
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
    Public Enum FreightNotFstTaxable
        
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
    Public Enum GstExemptionStatus
        
        '''<remarks/>
        E
        
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
    Public Enum InvoiceWholeOrderOnly
        
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
    Public Enum LineDiscValFlag
        
        '''<remarks/>
        V
        
        '''<remarks/>
        U
        
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
    Partial Public Class MiscChargeLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineCancelCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableField As MiscNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableField As MiscNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscSvcChargePriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintInvField As ConfigPrintInv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintInvFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintDelField As ConfigPrintDel
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintDelFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintAckField As ConfigPrintAck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintAckFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
        End Sub
        
        '''<summary>
        '''For a new order, this will be the line number from the customer's original order, and may not relate to the sales order line number within SYSPRO as comment or components may be added automatically, in which case multiple lines may be present for each line. If the LineActionType is C or D (change or cancel) this entry is mandatory, and refers to the actual line number on the order. This can be from 1 to 9999.
        '''</summary>
        Public Property CustomerPoLine() As String
            Get
                Return Me.customerPoLineField
            End Get
            Set
                Me.customerPoLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The action to be performed for this order line. The action can be:  A - Add a sales order line, C - Change an existing sales order line, D - Cancel the sales order line. If the OrderActionType is A for a new order, all the detail lines must contain a LineActionType of A.
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only required if the detail line has a LineActionType of 'D' - delete. If the SYSPRO setup option to retain analysis details for cancelled order lines is selected, then the contents of this element must be a valid Cancel Reason code within SYSPRO, or the element 'CancelReasoncode' within the order header must contain a valid Cancel Reason code. It can contain 1 to 6 alphanumeric characters.
        '''</summary>
        Public Property LineCancelCode() As String
            Get
                Return Me.lineCancelCodeField
            End Get
            Set
                Me.lineCancelCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the value of the miscellaneous charge. The format is 12.2 either positive or negative. The negative sign can either precede or follow the value.
        '''</summary>
        Public Property MiscChargeValue() As String
            Get
                Return Me.miscChargeValueField
            End Get
            Set
                Me.miscChargeValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the cost of the miscellaneous charge. The format is 12.2 either positive or negative. The negative sign can either precede or follow the value.
        '''</summary>
        Public Property MiscChargeCost() As String
            Get
                Return Me.miscChargeCostField
            End Get
            Set
                Me.miscChargeCostField = value
            End Set
        End Property
        
        '''<summary>
        '''If using service charges, this is the quantity of the services charges. The format is 12.6positive or negative, where the negative sign can precede or follow the value.
        '''</summary>
        Public Property MiscQuantity() As String
            Get
                Return Me.miscQuantityField
            End Get
            Set
                Me.miscQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the product class to be updated with the sales quantity and cost values for the miscellaneous charge. This is a mandatory element, unless a standard code is provided. The product class must be valid within SYSPRO. The format is 20 characters, alphanumeric.
        '''</summary>
        Public Property MiscProductClass() As String
            Get
                Return Me.miscProductClassField
            End Get
            Set
                Me.miscProductClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to be assigned to the miscellaneous charge. If this is present it must be a valid SYSPRO tax code. The format is 3character, alphanumeric.When using Descriptive Tax Codes, a descriptive tax code must be provided.
        '''</summary>
        Public Property MiscTaxCode() As String
            Get
                Return Me.miscTaxCodeField
            End Get
            Set
                Me.miscTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default tax status of the miscellaneous charge detail line. If the order is subject to sales tax, then setting this element to 'Y' will cause the line to have no sales tax applied. The element may contain 'Y' (not taxable) or blank (default).
        '''</summary>
        Public Property MiscNotTaxable() As MiscNotTaxable
            Get
                Return Me.miscNotTaxableField
            End Get
            Set
                Me.miscNotTaxableField = value
                Me.MiscNotTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscNotTaxableSpecified() As Boolean
            Get
                Return Me.miscNotTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the Canadian Federal Sales Tax code to be assigned to the miscellaneous charge. If the Canadian FST system is in use and a tax code is present, it must be valid within SYSPRO. The format is 1 character, alphanumeric.
        '''</summary>
        Public Property MiscFstCode() As String
            Get
                Return Me.miscFstCodeField
            End Get
            Set
                Me.miscFstCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default FST (Canadian tax system) status of the miscellaneous charge detail line. If the order is subject to FST, then setting this element to 'Y' will cause the line to have no FST applied. The element may contain 'Y' (not taxable) or blank (default).
        '''</summary>
        Public Property MiscNotFstTaxable() As MiscNotFstTaxable
            Get
                Return Me.miscNotFstTaxableField
            End Get
            Set
                Me.miscNotFstTaxableField = value
                Me.MiscNotFstTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscNotFstTaxableSpecified() As Boolean
            Get
                Return Me.miscNotFstTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the description to appear with the miscellaneous charge. The format is 100 characters, alphanumeric.
        '''</summary>
        Public Property MiscDescription() As String
            Get
                Return Me.miscDescriptionField
            End Get
            Set
                Me.miscDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to select a standard service charge on which to base the miscellaneous line. It is only relevant when a line is added. If entered, it must represent a standard SYSPRO service charge code.
        '''</summary>
        Public Property MiscChargeCode() As String
            Get
                Return Me.miscChargeCodeField
            End Get
            Set
                Me.miscChargeCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This only applies if a charge code is used to instantiate the information in the miscellaneous charge line. If entered, the contents will be used as the tariff code for the line. 
        '''</summary>
        Public Property MiscTariffCode() As String
            Get
                Return Me.miscTariffCodeField
            End Get
            Set
                Me.miscTariffCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The price of the Service Charge. Will only be used if MiscChargeCode is not blank.  The format is 10.5.
        '''</summary>
        Public Property MiscSvcChargePrice() As String
            Get
                Return Me.miscSvcChargePriceField
            End Get
            Set
                Me.miscSvcChargePriceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on an invoice. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintInv() As ConfigPrintInv
            Get
                Return Me.configPrintInvField
            End Get
            Set
                Me.configPrintInvField = value
                Me.ConfigPrintInvFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintInvSpecified() As Boolean
            Get
                Return Me.configPrintInvFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on a delivery note. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintDel() As ConfigPrintDel
            Get
                Return Me.configPrintDelField
            End Get
            Set
                Me.configPrintDelField = value
                Me.ConfigPrintDelFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintDelSpecified() As Boolean
            Get
                Return Me.configPrintDelFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on an order acknowledgement. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintAck() As ConfigPrintAck
            Get
                Return Me.configPrintAckField
            End Get
            Set
                Me.configPrintAckField = value
                Me.ConfigPrintAckFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintAckSpecified() As Boolean
            Get
                Return Me.configPrintAckFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MiscNotTaxable
        
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
    Public Enum MiscNotFstTaxable
        
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
    Public Enum NonStockedLine
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockLineField As List(Of StockLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As List(Of CommentLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeLineField As List(Of MiscChargeLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As List(Of FreightLine)
        
        Public Sub New()
            MyBase.New
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New List(Of FreightLine)()
            End If
            If (Me.miscChargeLineField Is Nothing) Then
                Me.miscChargeLineField = New List(Of MiscChargeLine)()
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New List(Of CommentLine)()
            End If
            If (Me.stockLineField Is Nothing) Then
                Me.stockLineField = New List(Of StockLine)()
            End If
        End Sub
        
        '''<summary>
        '''This element specifies that the sub-elements make up a detail sales order line for a stocked or non-stocked item.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("StockLine")>  _
        Public Property StockLineCollection() As List(Of StockLine)
            Get
                Return Me.stockLineField
            End Get
            Set
                Me.stockLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies that the sub-elements make up a detail sales order line for a comment line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("CommentLine")>  _
        Public Property CommentLineCollection() As List(Of CommentLine)
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies that the sub-elements make up a detail sales order line for a Miscellaneous Charge line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("MiscChargeLine")>  _
        Public Property MiscChargeLineCollection() As List(Of MiscChargeLine)
            Get
                Return Me.miscChargeLineField
            End Get
            Set
                Me.miscChargeLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies that the sub-elements make up a detail sales order line for a Freight line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("FreightLine")>  _
        Public Property FreightLineCollection() As List(Of FreightLine)
            Get
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineCancelCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customersPartNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUsePriceEnteredField As AlwaysUsePriceEntered
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUsePriceEnteredFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUseDiscountEnteredField As AlwaysUseDiscountEntered
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUseDiscountEnteredFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private custRequestDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private custRequestDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscValFlagField As LineDiscValFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscValFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overrideCalculatedDiscountField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefinedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedLineField As NonStockedLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedLineFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nsProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nsUnitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockNotTaxableField As StockNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockNotFstTaxableField As StockNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockNotFstTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionField As AllocationAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintInvField As ConfigPrintInv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintInvFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintDelField As ConfigPrintDel
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintDelFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintAckField As ConfigPrintAck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configPrintAckFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMultiShipCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFactorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockField As ReserveStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockRequestAllocsField As ReserveStockRequestAllocs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockRequestAllocsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tradePromotionCodesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInMrpField As StockLineIncludeInMrp
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInMrpFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryLoadField As DeliveryLoad
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
            If (Me.deliveryLoadField Is Nothing) Then
                Me.deliveryLoadField = New DeliveryLoad()
            End If
        End Sub
        
        '''<summary>
        '''For a new order, this will be the line number from the customer's original order, and may not relate to the sales order line number within SYSPRO as comment or components may be added automatically, in which case multiple lines may be present for each line. If the LineActionType is C or D (change or cancel) this entry is mandatory, and refers to the actual line number on the order. This can be from 1 to 9999.
        '''</summary>
        Public Property CustomerPoLine() As String
            Get
                Return Me.customerPoLineField
            End Get
            Set
                Me.customerPoLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The action to be performed for this order line. The action can be:  A - Add a sales order line, C - Change an existing sales order line, D - Cancel the sales order line. If the OrderActionType is A for a new order, all the detail lines must contain a LineActionType of A.
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only required if the detail line has a LineActionType of 'D' - delete. If the SYSPRO setup option to retain analysis details for cancelled order lines is selected, then the contents of this element must be a valid Cancel Reason code within SYSPRO, or the element 'CancelReasoncode' within the order header must contain a valid Cancel Reason code. It can contain 1 to 6 alphanumeric characters.
        '''</summary>
        Public Property LineCancelCode() As String
            Get
                Return Me.lineCancelCodeField
            End Get
            Set
                Me.lineCancelCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''SYSPRO sales orders can be entered using either the company's stock code (StockCode) or the customer's part number (CustomersPartNumber). If the company's StockCode element is non-blank, a check is made to see if this is a valid stock code, and if it is, it is used. If the company's stock code is either blank or invalid, the CustomersPartNumber element is read and a check is done for the customer/stock code combination using the cross-reference file. If this is a valid part number for the customer, it is used. If the customer's part number is either invalid, or does not exist, a check is made to see if non-stocked lines are allowed. If they are then the line is accepted. The stock item must not be on hold. 
        '''
        '''If the stock code is under the control of ECC and it is not of type S (for Stock) it will be rejected. If it is type S the line is accepted. 
        '''If the action is change, and the stock code is provided, it is used to validate that the line selected for change is the correct line.
        '''The format is 30 characters, numeric or alphanumeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If the customer's part number is missing and the content of StockCode is not valid a check is made to see if non-stocked lines are allowed. If they are, the contents of this element are used as the description of the non-stocked item. The format is 50 characters, alphanumeric.
        '''If the line is a new valid stocked line, and the parameter 'UseStockDescSupplied' is set to 'Y', and the contents of this element are not blank, then the contents of this element are used instead of the description from the Item Master.
        '''</summary>
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''If the warehouse is supplied on the detail line, that is used. If it is not valid then an error is returned. If there is no warehouse against the detail line then the warehouse against the header is used. If this is invalid an error is returned. If there is no warehouse entry against the header the warehouse in the supplied parameter file is used.
        '''
        '''If the warehouse record in the parameter file is invalid an error is returned. If there is no warehouse record in the parameter file then the Distribution Warehouse held against the stock code is used. If this is not present then the Warehouse To Use against the stock code is used.
        '''
        '''The format is 10 characters, alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''If the value of the element StockCode is blank, and this element contains a value, a check is made against the customer/stock code cross-reference file to see if this part number is valid for this customer. If it is, the matching SYSPRO stock code is used for the stock code in sales orders.
        '''</summary>
        Public Property CustomersPartNumber() As String
            Get
                Return Me.customersPartNumberField
            End Get
            Set
                Me.customersPartNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The quantity of the item that the customer is ordering, in the unit of measure entered in OrderUom. If LineType is A, the OrderQty element is mandatory. If the LineType is C, this is the new quantity to use (ie. the existing order quantity is replaced with this value). The format is 12.6 positive or negative, with either a preceding or following negative. If Multiple Bins are installed, if the stock item is serialized, lot traceable or kit type or if there is not enough stock, the quantity ordered will automatically be placed in back order.
        '''</summary>
        Public Property OrderQty() As String
            Get
                Return Me.orderQtyField
            End Get
            Set
                Me.orderQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''The unit of measure for OrderQty for the item. This is mandatory for each new StockLine entry. It will be ignored on a change stock line, as the unit of measure cannot be changed on an existing line. This must be a valid unit of measure within SYSPRO. The format is 10 characters, alphanumeric.
        '''</summary>
        Public Property OrderUom() As String
            Get
                Return Me.orderUomField
            End Get
            Set
                Me.orderUomField = value
            End Set
        End Property
        
        '''<summary>
        '''The price of the item in the unit of measure PriceUom. Depending on the SYSPRO configuration options this price will normally be calculated during the import and updated if necessary the format is 10.5.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        '''<summary>
        '''The unit of measure that the Price refers to. This is a mandatory field if Price contains an entry. This entry must be a valid price unit of measure within SYSPRO. The format is 10 characters, alphanumeric. 
        '''</summary>
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        '''<summary>
        '''The price code can be supplied for a stocked item only. If entered, it must be a valid price code for the stocked item. It will be considered after the price element, but before using the standard SYSPRO pricing mechanism.
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies that the price supplied in the element 'Price" on this detail line is to be used instead of any price calculated using the SYSPRO configuration parameters(Y - Yes, N - No). If not supplied, then the contents of the parameter 'AlwaysUsePriceEntered' will be used. This is only relevant for a new line.
        '''</summary>
        Public Property AlwaysUsePriceEntered() As AlwaysUsePriceEntered
            Get
                Return Me.alwaysUsePriceEnteredField
            End Get
            Set
                Me.alwaysUsePriceEnteredField = value
                Me.AlwaysUsePriceEnteredFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AlwaysUsePriceEnteredSpecified() As Boolean
            Get
                Return Me.alwaysUsePriceEnteredFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If the detail line is a merchandise line, and the stock code is a unit-qty type stock code and the OrderQty element is not supplied, the quantity of the detail line must be supplied as units and pieces. At least one of these elements must be supplied. Both elements must be of the same sign. If processing a change or a deletion, then a quantity is not required.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If the detail line is a merchandise line, and the stock code is a unit-qty type stock code and the OrderQty element is not supplied, the quantity of the detail line must be supplied as units and pieces. At least one of these elements must be supplied. Both elements must be of the same sign. If processing a change or a deletion, then a quantity is not required.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the product class for this sales order line. It is only relevant for a merchandise line. If supplied it must be valid. If not supplied the product class is picked up from the stock item. If the item is non-stocked, then the product class will be taken form the element NsProductClass first.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''The first line discount percentage to be applied to this sales order line. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will only be used if the customer is not subject to contract pricing.
        '''</summary>
        Public Property LineDiscPercent1() As String
            Get
                Return Me.lineDiscPercent1Field
            End Get
            Set
                Me.lineDiscPercent1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The second line discount percentage to be applied to this sales order line. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will be applied after LineDiscPercent1. This will only be used if the customer is not subject to contract pricing.
        '''</summary>
        Public Property LineDiscPercent2() As String
            Get
                Return Me.lineDiscPercent2Field
            End Get
            Set
                Me.lineDiscPercent2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The third line discount percentage to be applied to this sales order line. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will be applied after LineDiscPercent1 and LineDiscPercent2. This will only be used if the customer is not subject to contract pricing.
        '''</summary>
        Public Property LineDiscPercent3() As String
            Get
                Return Me.lineDiscPercent3Field
            End Get
            Set
                Me.lineDiscPercent3Field = value
            End Set
        End Property
        
        '''<summary>
        '''If this element is set to 'Y' and a discount is entered, the discount is applied to the price for the line. Defaults to 'N'. This option is only applicable when adding a new line.
        '''</summary>
        Public Property AlwaysUseDiscountEntered() As AlwaysUseDiscountEntered
            Get
                Return Me.alwaysUseDiscountEnteredField
            End Get
            Set
                Me.alwaysUseDiscountEnteredField = value
                Me.AlwaysUseDiscountEnteredFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AlwaysUseDiscountEnteredSpecified() As Boolean
            Get
                Return Me.alwaysUseDiscountEnteredFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the date that the customer has requested shipment of this detail line. The format is CCYY-MM-DD. If no date is supplied for a new detail line, then it is calculated as today's date plus MinimumDaysToShip from the supplied parameter file. If there is no MinimumDaysToShip entry then the SYSPRO field Minimum Number of Days To Ship against the operator code is added to today's date. If RequestedShipDate is supplied, a check is made that it is at least MinimumDaysToShip (or Minimum Number of Days To Ship if MinimumDaysToShip is not in the parameter file) days in to the future. If this date is supplied for a changed line, it is used to update only the customer request date.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property CustRequestDate() As Date
            Get
                Return Me.custRequestDateField
            End Get
            Set
                Me.custRequestDateField = value
                Me.CustRequestDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CustRequestDateSpecified() As Boolean
            Get
                Return Me.custRequestDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If entered, this is used to override the commission code against the price code, or in the setup. If entered, it is cehcked to be a valid commission code in SYSPRO, and is treasted as a warning if not valid.
        '''</summary>
        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set
                Me.commissionCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the expected ship date of this detail line. The format is CCYY-MM-DD. If no date is supplied for a new detail line, then it is taken from the contents of the element CustRequestDate which itself may have been calculated. If it is supplied for a changed line, then it is used to update only the line ship date. If it is supplied, and the parameter 'AcceptEarlierShipDate' is set to 'Y', then this date may be before the ship date on the header.
        '''</summary>
        Public Property LineShipDate() As String
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the discount value to be applied to this detail line. The format is 12.2 positive or negative, and the negative sign can precede or follow the value. If this value is not entered, the type of discount  for the line is assumed to be a chain discount. This will only be used if the customer is not subject to contract pricing. The elememt 'LineDiscValflag' is used to decide if the discount is a unit or a value discount.
        '''</summary>
        Public Property LineDiscValue() As String
            Get
                Return Me.lineDiscValueField
            End Get
            Set
                Me.lineDiscValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag is used to determine the usage of the contents of the element 'LineDiscValue'. When 'LineDiscValue' is non zero, then an entry of 'U' means the value is to be applied as a unit discount. When 'V' or space (the default), then the value is applied as a value discount.
        '''</summary>
        Public Property LineDiscValFlag() As LineDiscValFlag
            Get
                Return Me.lineDiscValFlagField
            End Get
            Set
                Me.lineDiscValFlagField = value
                Me.LineDiscValFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineDiscValFlagSpecified() As Boolean
            Get
                Return Me.lineDiscValFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If this element is set, then the discount entered agains tthe line (even if zero) will be used in preference to any calcualted order level discounts for the product class and customer if the customer is set up to use order discounts by product class. The default is 'N'.
        '''</summary>
        Public Property OverrideCalculatedDiscount() As Object
            Get
                Return Me.overrideCalculatedDiscountField
            End Get
            Set
                Me.overrideCalculatedDiscountField = value
            End Set
        End Property
        
        '''<summary>
        '''This is for use by the user, and is not validated. The format is 4 characters, alphanumeric.
        '''</summary>
        Public Property UserDefined() As String
            Get
                Return Me.userDefinedField
            End Get
            Set
                Me.userDefinedField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used in conjuction with the parameter 'AllowNonStockedItems'. When the parameter is set to 'S' (specify), then this element is used to determine if a line is for a non-stocked item. Valid entries are 'Y' (yes, a non-stocked line), or blank, the default. This element is normally only relevant for line action type 'A' - add, and will be ignored for other actions. the exception is cancelling a non-stocked line where the non-stocked code is also a valid stocked code. Then the flag must be set to 'Y', and the parameter to 'S'.
        '''</summary>
        Public Property NonStockedLine() As NonStockedLine
            Get
                Return Me.nonStockedLineField
            End Get
            Set
                Me.nonStockedLineField = value
                Me.NonStockedLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NonStockedLineSpecified() As Boolean
            Get
                Return Me.nonStockedLineFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the product class to be used for the item if it is non-stocked. If it is a non-stocked item this element is mandatory and must be a valid entry within SYSPRO. The format is 20 characters, alphanumeric.
        '''</summary>
        Public Property NsProductClass() As String
            Get
                Return Me.nsProductClassField
            End Get
            Set
                Me.nsProductClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit cost of the non-stocked item. The format is 10.5 positive.The element is only relevant for a non-stocked line.
        '''</summary>
        Public Property NsUnitCost() As String
            Get
                Return Me.nsUnitCostField
            End Get
            Set
                Me.nsUnitCostField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit mass of the merchandise item. The format is 12.6 positive. If this is not given for a stocked line, the unit mass of the inventory item is used.
        '''</summary>
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit volume of the merchandise item. The format is 12.6 positive. If this is not given for a stocked line, the unit volume of the inventory item is used.
        '''</summary>
        Public Property UnitVolume() As String
            Get
                Return Me.unitVolumeField
            End Get
            Set
                Me.unitVolumeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to be assigned to the stock line. If this is present it must be a valid SYSPRO tax code. The format is 3 character, alphanumeric. If the setup option 'Sales Order setup - Tax/um - allow changes to tax code for stocked items' is not selected, then any entry in this element will be rejected.
        '''</summary>
        Public Property StockTaxCode() As String
            Get
                Return Me.stockTaxCodeField
            End Get
            Set
                Me.stockTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default tax status of the stock detail line. If the order is subject to sales tax, then setting this element to 'Y' will cause the line to have no sales tax applied. The element may contain 'Y' (not taxable) or blank (default).  If the setup option 'Sales Order setup - Tax/um - allow changes to tax code for stocked items' is not selected, and the merchandise line is a stocked line, then an entry of 'Y' in this element will be rejected.
        '''</summary>
        Public Property StockNotTaxable() As StockNotTaxable
            Get
                Return Me.stockNotTaxableField
            End Get
            Set
                Me.stockNotTaxableField = value
                Me.StockNotTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockNotTaxableSpecified() As Boolean
            Get
                Return Me.stockNotTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the Canadian Federal Sales Tax code to be assigned to the stock line. If this is present, and the Canadian tax system is in use, it must be a valid SYSPRO tax code. The format is 3 character, alphanumeric. If the setup option 'Sales Order setup - Tax/um - allow changes to tax code for stocked items' is not selected, then any entry in this element will be rejected.
        '''</summary>
        Public Property StockFstCode() As String
            Get
                Return Me.stockFstCodeField
            End Get
            Set
                Me.stockFstCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to override the default FST (Canadian tax system) status of the stock detail line. If the order is subject to FST, then setting this element to 'Y' will cause the line to have no FST applied. The element may contain 'Y' (not taxable) or blank (default). If the setup option 'Sales Order setup - Tax/um - allow changes to tax code for stocked items' is not selected, and the merchandise line is a stocked line, then an entry of 'Y' in this element will be rejected.
        '''</summary>
        Public Property StockNotFstTaxable() As StockNotFstTaxable
            Get
                Return Me.stockNotFstTaxableField
            End Get
            Set
                Me.stockNotFstTaxableField = value
                Me.StockNotFstTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockNotFstTaxableSpecified() As Boolean
            Get
                Return Me.stockNotFstTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether merchandise lines are to be allocated or placed on back order. If used, this element will override the parameter entry, AllocationAction. Valid entries are 'F'  - allocate only if full order quantity is available, 'B' -  place whole line on back order, 'A' - allocate available quantity if less than order quantity, and place the remainder on back order. If blank or not entered, 'F' is assumed. If set to 'B' (Back order), then the parameter 'ShipFromDefaultBin' is ignored. Note that any items which are kit items,  lot traceable or serialised will still be placed on back order.
        '''</summary>
        Public Property AllocationAction() As AllocationAction
            Get
                Return Me.allocationActionField
            End Get
            Set
                Me.allocationActionField = value
                Me.AllocationActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllocationActionSpecified() As Boolean
            Get
                Return Me.allocationActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on an invoice. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintInv() As ConfigPrintInv
            Get
                Return Me.configPrintInvField
            End Get
            Set
                Me.configPrintInvField = value
                Me.ConfigPrintInvFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintInvSpecified() As Boolean
            Get
                Return Me.configPrintInvFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on a delivery note. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintDel() As ConfigPrintDel
            Get
                Return Me.configPrintDelField
            End Get
            Set
                Me.configPrintDelField = value
                Me.ConfigPrintDelFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintDelSpecified() As Boolean
            Get
                Return Me.configPrintDelFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant when the business object is called by the Product Configurator, and will be ignored at any other time. It determines whether the product configurator line will be printed on an order acknowledgement. Valid entries are 'Y' (print), 'N' (do not print). If not supplied or left blank, then 'Y' is assumed.
        '''</summary>
        Public Property ConfigPrintAck() As ConfigPrintAck
            Get
                Return Me.configPrintAckField
            End Get
            Set
                Me.configPrintAckField = value
                Me.ConfigPrintAckFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigPrintAckSpecified() As Boolean
            Get
                Return Me.configPrintAckFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If entered, the contents will be used as the tariff code for the sales order line for both stocked and non-stocked. If not entered, then the tariff code from the inventory master will be used when adding a stocked line. If EC Vat is in operation, and a tariff code is required, then a blank tariff code will be treated as a warning.
        '''</summary>
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only applicable when the order header element 'ShipAddressPerLine' is set to 'Y'. If entered it must be a valid address code for the customer. 
        '''</summary>
        Public Property LineMultiShipCode() As String
            Get
                Return Me.lineMultiShipCodeField
            End Get
            Set
                Me.lineMultiShipCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This entry only applies if the line is a stocked line, the stock code required the use of supplementary units for EC Vat reporting, and the stock code is linked to a supplementary units code. If supplied, it must be a positive number with up to 6 decimal places.
        '''</summary>
        Public Property SupplementaryUnitsFactor() As String
            Get
                Return Me.supplementaryUnitsFactorField
            End Get
            Set
                Me.supplementaryUnitsFactorField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if the SO Option to allow reserving of stock is selected. If set to 'Y', then any attempt to allocate stock for a line will result in it being reserved, and not shipped. If set to 'N', then any attempt to allocate stock will result in it being shipped. If the element is not supplied, then the parameter ReserveStock will be used, or the SYSPRO company setting will be used.
        '''</summary>
        Public Property ReserveStock() As ReserveStock
            Get
                Return Me.reserveStockField
            End Get
            Set
                Me.reserveStockField = value
                Me.ReserveStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReserveStockSpecified() As Boolean
            Get
                Return Me.reserveStockFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the SO Option to allow reserving of stock is selected, and stock is being reserved not shipped. If set to 'Y', then any lot bin or serial item can only be reserved using the ship rules.  If set to 'N', then a lot , serial or bin item can be reserved as detail allocations are not required.  If the element is not supplied, then the parameter ReserveStock will be used, or the SYSPRO company setting will be used.
        '''</summary>
        Public Property ReserveStockRequestAllocs() As ReserveStockRequestAllocs
            Get
                Return Me.reserveStockRequestAllocsField
            End Get
            Set
                Me.reserveStockRequestAllocsField = value
                Me.ReserveStockRequestAllocsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReserveStockRequestAllocsSpecified() As Boolean
            Get
                Return Me.reserveStockRequestAllocsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This must be a list of qualified promotions for the line selected.  Each code is a maximum of 10 characters, separated by a comma.
        '''
        '''
        '''
        '''If the element SalesOrderAction is 'W', then this is ignored.
        '''</summary>
        Public Property TradePromotionCodes() As String
            Get
                Return Me.tradePromotionCodesField
            End Get
            Set
                Me.tradePromotionCodesField = value
            End Set
        End Property
        
        Public Property IncludeInMrp() As StockLineIncludeInMrp
            Get
                Return Me.includeInMrpField
            End Get
            Set
                Me.includeInMrpField = value
                Me.IncludeInMrpFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeInMrpSpecified() As Boolean
            Get
                Return Me.includeInMrpFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element specifies the sub elements that make up the delivery load for the detail line.
        '''</summary>
        Public Property DeliveryLoad() As DeliveryLoad
            Get
                Return Me.deliveryLoadField
            End Get
            Set
                Me.deliveryLoadField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StockNotTaxable
        
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
    Public Enum StockNotFstTaxable
        
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
    Public Enum ReserveStock
        
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
    Public Enum ReserveStockRequestAllocs
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockLineIncludeInMrp
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderActionTypeField As OrderActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newCustomerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3LocalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipGpsLatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipGpsLongField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiShipCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddressPerLineField As ShipAddressPerLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddressPerLineFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requestedShipDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requestedShipDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceNumberEnteredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateEnteredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderCommentsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transportModeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptionStatusField As TaxExemptionStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptionStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptionStatusField As GstExemptionStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptionStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTaxNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddressPerLineTaxField As ShipAddressPerLineTax
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddressPerLineTaxFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelReasonCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryRouteActionField As DeliveryRouteAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryRouteActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryRouteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceWholeOrderOnlyField As InvoiceWholeOrderOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceWholeOrderOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoQualifyActionField As SalesOrderPromoQualifyAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoQualifyActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoSelectActionField As SalesOrderPromoSelectAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoSelectActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private globalTradePromotionCodesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pOSSalesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInMrpField As OrderHeaderIncludeInMrp
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInMrpFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.orderActionTypeField = OrderActionType.A
            Me.deliveryRouteActionField = DeliveryRouteAction.N
            If (Me.orderCommentsField Is Nothing) Then
                Me.orderCommentsField = New List(Of String)()
            End If
        End Sub
        
        '''<summary>
        '''The use of this element is based on the setting of the parameter 'CheckForCustomerPoNumbers'.  If the parameter is set to 'Y' (the default), then the element 'CustomerPoNumber' must be supplied when adding a sales order. If set to 'N', then the element may be missing, or may be blank. If set to 'C' (customer) then the check is based on the setting of the SYSPRO Customer Maintenance option 'Customer purchase order number mandatory'.. If the order is for a sub-account that has a store number,and  the element is blank, then the store number will be used as the customer purchase order number. If the SYSPRO configuration is set so that duplicate purchase order numbers are not allowed, the order will be rejected if this purchase order number already exists. If duplicate purchase order numbers are allowed, but this purchase order number already exists for this customer it will be rejected. There is a parameter 'AllowDuplicateOrderNumbers' which will override the check for duplicate purchase order numbers against the same customer, as long as the SYSPRO configuration is set so that duplicate purchase order numbers are allowed. The format is up to 30 characters, alphanumeric.
        '''</summary>
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The action to be performed for this order header. The action can be A - Add a sales order, C - Change an existing sales order, D - Cancel the sales order. If adding a sales order header, all detail lines must have an A for LineActionType. If changing an order, the individual order lines may be added, changed or cancelled. If Cancelling an order, all detail lines will be cancelled. 
        '''</summary>
        Public Property OrderActionType() As OrderActionType
            Get
                Return Me.orderActionTypeField
            End Get
            Set
                Me.orderActionTypeField = value
                Me.OrderActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderActionTypeSpecified() As Boolean
            Get
                Return Me.orderActionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is only relevant if changing an order. This element is used to allow the existing customer purchase order number on a sales order to be changed. If the SYSPRO configuration is set so that duplicate purchase order numbers are not allowed, the change will be rejected if this purchase order number already exists. If duplicate purchase order numbers are allowed, but this purchase order number already exists for the customer it will be rejected. There is a parameter 'AllowDuplicateOrderNumbers' which will override the check for duplicate purchase order numbers against the same customer, as long as the SYSPRO configuration is set so that duplicate purchase order numbers are allowed. The format is up to 30 characters, alphanumeric.
        '''</summary>
        Public Property NewCustomerPoNumber() As String
            Get
                Return Me.newCustomerPoNumberField
            End Get
            Set
                Me.newCustomerPoNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is currently for reference purposes only. The format is 15 characters, alphanumeric.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''The customer code will be used if the SenderCode element is empty. If Customer is supplied this customer account must not be on hold. If multiple customers are allowed for sub-accounts, this customer must be attached as a sub-account of SenderCode. The format is 7 characters, alphanumeric or numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the date the order was placed. The format is CCYY-MM-DD.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property OrderDate() As Date
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
                Me.OrderDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderDateSpecified() As Boolean
            Get
                Return Me.orderDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the invoice terms code for the transaction. If it is not present the invoice terms code for the relevant customer is obtained from SYSPRO. The format is 2 characters, alphanumeric.
        '''</summary>
        Public Property InvoiceTerms() As String
            Get
                Return Me.invoiceTermsField
            End Get
            Set
                Me.invoiceTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''The currency code used for the values within this order. If this is not present the currency code held against the relevant customer within SYSPRO is used. If present, then it must match the currency against the relevant customer, and must be a valid curreny code within SYSPRO. The format is 3 characters, alphanumeric. This element is ignored for a changed order.
        '''</summary>
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains any shipping instructions that are to be placed against the order. The format is 50 characters, alphanumeric. If the SYSPRO option to use coded shipping instructions is in use then any entry here will be used to over-ride the description against the code.
        '''</summary>
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        '''<summary>
        ''' If the SYSPRO option to use coded shipping instructions is in use and this element is populated, then the table of Shipping Instructions in SYSPRO is read, and the description used on the header, unless the element ShippingInstrs is populated, which will cause the description to be over-ridden. If the parameter 'ValidateShippingInstrs' is set to 'Y' then this element can contain only a valid shipping code - it may be blank for a changed order.
        '''</summary>
        Public Property ShippingInstrsCode() As String
            Get
                Return Me.shippingInstrsCodeField
            End Get
            Set
                Me.shippingInstrsCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the customer name to appear against the sales order. If this is left blank it will default to the customer name held against the customer account within SYSPRO. The format is 50 characters, alphanumeric.
        '''</summary>
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the first line of the delivery address to appear against the sales order. If this and all other address lines are left blank the full address will be taken from the customer account. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the second line of the delivery address to appear against the sales order. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the third line of the delivery address to appear against the sales order. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the locality of the delivery address to appear against the sales order. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress3Locality() As String
            Get
                Return Me.shipAddress3LocalityField
            End Get
            Set
                Me.shipAddress3LocalityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the fourth line of the delivery address to appear against the sales order.  To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the fifth line of the delivery address to appear against the sales order. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 40 characters, alphanumeric.
        '''</summary>
        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the postal code line of the delivery address to appear against the sales order. To remove this line from an existing address when changing an order, use the text {blank} or {BLANK}.The format is 10 characters, alphanumeric.
        '''</summary>
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the geo location latitude of the delivery address to appear against the sales order. The format is 2.6, positive or negative.
        '''</summary>
        Public Property ShipGpsLat() As String
            Get
                Return Me.shipGpsLatField
            End Get
            Set
                Me.shipGpsLatField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the geo location longitude of the delivery address to appear against the sales order. The format is 3.6, positive or negative.
        '''</summary>
        Public Property ShipGpsLong() As String
            Get
                Return Me.shipGpsLongField
            End Get
            Set
                Me.shipGpsLongField = value
            End Set
        End Property
        
        Public Property LanguageCode() As Object
            Get
                Return Me.languageCodeField
            End Get
            Set
                Me.languageCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the e-mail address to be stored against the sales order. The format is 255 characters, alphanumeric.
        '''</summary>
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        '''<summary>
        '''The first order discount percentage to be applied to the sales order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will only be used if a configuration option is set.
        '''</summary>
        Public Property OrderDiscPercent1() As String
            Get
                Return Me.orderDiscPercent1Field
            End Get
            Set
                Me.orderDiscPercent1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The second order discount percentage to be applied to the sales order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will be applied after OrderDiscPercent1. This will only be used if a configuration option is set.
        '''</summary>
        Public Property OrderDiscPercent2() As String
            Get
                Return Me.orderDiscPercent2Field
            End Get
            Set
                Me.orderDiscPercent2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The third order discount percentage to be applied to the sales order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. This will be applied after OrderDiscPercent1 and OrderDiscPercent2. This will only be used if a configuration option is set.
        '''</summary>
        Public Property OrderDiscPercent3() As String
            Get
                Return Me.orderDiscPercent3Field
            End Get
            Set
                Me.orderDiscPercent3Field = value
            End Set
        End Property
        
        '''<summary>
        '''If the warehouse is supplied on the detail line, that is used. If it is not valid then an error is returned. If there is no warehouse against the detail line then the warehouse against the header is used. If this is invalid an error is returned. If there is no warehouse entry against the header the warehouse in the supplied parameter file is used.
        '''
        '''If the warehouse record in the parameter file is invalid an error is returned. If there is no warehouse record in the parameter file then the Distribution Warehouse held against the stock code is used. If this is not present then the Warehouse To Use against the stock code is used.
        '''
        '''The format is 10 characters, alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains any special instructions that are to be placed against the order. The format is 50 characters, alphanumeric.
        '''</summary>
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
            End Set
        End Property
        
        '''<summary>
        '''The sales order number to use. If the OrderActionType is A (Add) and SYSPRO is NOT set up to use automatic sales order numbering, this number will become the sales order number. If the OrderActionType is either C or D (for change or cancel) the sales order number must be supplied. The format is maximum 20 characters, either numeric or alphanumeric, depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''The contents of this element will update the order type field on the sales order. The order type field is a user-defined means of categorizing sales orders. If the SYSPRO configuration option specifies that OrderType must be valid, the order type will be validated. If not supplied the default order type is used. If no default is present then an error is returned. The format is 2 characters, alphanumeric.
        '''</summary>
        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''The contents of this element can be used to select one of the predefined multiple ship to addresses against this customer. The format is 5 characters, alphanumeric.
        '''</summary>
        Public Property MultiShipCode() As String
            Get
                Return Me.multiShipCodeField
            End Get
            Set
                Me.multiShipCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This may be set to 'Y' to indicate that merchandise lines may contain a ship address code that differs from the order ship address code. All lines and associated lines with the same code will be used to produce a separate delivery note.
        '''</summary>
        Public Property ShipAddressPerLine() As ShipAddressPerLine
            Get
                Return Me.shipAddressPerLineField
            End Get
            Set
                Me.shipAddressPerLineField = value
                Me.ShipAddressPerLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShipAddressPerLineSpecified() As Boolean
            Get
                Return Me.shipAddressPerLineFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the alternate key to be used when creating the sales order. It must comply with the type of default alternate key defined in Sales Orders Setup (i.e. Branch, Geographic Area or Warehouse). If Alternate Key is mandatory and this element is not supplied, the alternate key will be set to the default alternate key. If there is no default, it will be rejected.
        '''</summary>
        Public Property AlternateReference() As String
            Get
                Return Me.alternateReferenceField
            End Get
            Set
                Me.alternateReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the salesperson responsible for this sales order. If supplied it must be valid. If not supplied the salesperson is picked up from the customer account.
        '''</summary>
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the branch for this sales order. If supplied it must be valid. If not supplied the branch is picked up from the customer account.
        '''</summary>
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the geographic area for this sales order. If supplied it must be valid. If not supplied the geographic area is picked up from the customer account.
        '''</summary>
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the date that the customer has requested shipment of the whole order. The format is CCYY-MM-DD. 
        '''
        '''If no date is supplied then it is calculated as today's date plus MinimumDaysToShip from the supplied parameter file. If there is no MinimumDaysToShip entry then the SYSPRO field Minimum Number of Days To Ship is added to today's date.
        '''
        '''If RequestedShipDate is supplied and AcceptEarlierShipDate in the parameter file is set to 'N', a check is made that it is equal to or greater than the date calculated above.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property RequestedShipDate() As Date
            Get
                Return Me.requestedShipDateField
            End Get
            Set
                Me.requestedShipDateField = value
                Me.RequestedShipDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property RequestedShipDateSpecified() As Boolean
            Get
                Return Me.requestedShipDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The invoice number may only be supplied if the sales order is to be created in a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The entry must follow the SYSPRO configuration rules for the type of invoice number.
        '''</summary>
        Public Property InvoiceNumberEntered() As String
            Get
                Return Me.invoiceNumberEnteredField
            End Get
            Set
                Me.invoiceNumberEnteredField = value
            End Set
        End Property
        
        '''<summary>
        '''The invoice date may only be supplied if the sales order is to be created in a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The format is CCYY-MM-DD.
        '''</summary>
        Public Property InvoiceDateEntered() As String
            Get
                Return Me.invoiceDateEnteredField
            End Get
            Set
                Me.invoiceDateEnteredField = value
            End Set
        End Property
        
        '''<summary>
        '''Order comments can be added as one or more strings. The maximum length of a single string is 400 characters. If a single string is more than 100 characters, it will be broken into more than one line at an appropriate place. The maximum total size of the order comments is 4 lines each of 100 characters.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("OrderComments")>  _
        Public Property OrderCommentsCollection() As List(Of String)
            Get
                Return Me.orderCommentsField
            End Get
            Set
                Me.orderCommentsField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for orders placed where the SYSPRO option 'EC Vat system required' is selected. The nationality code if entered must be valid against the table of nationality codes in SYSPRO. If not entered, it will default to the nationality against the customer. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for orders placed where the SYSPRO option 'EC Vat system required' is selected. The delivery terms code is optional, but if entered is up to 3 characters, alphanumeric.
        '''</summary>
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        Public Property ShippingLocation() As String
            Get
                Return Me.shippingLocationField
            End Get
            Set
                Me.shippingLocationField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for orders placed where the SYSPRO option 'EC Vat system required' is selected. The transaction nature code is optional, but if entered is up to 3 numeric digits.
        '''</summary>
        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set
                Me.transactionNatureField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for orders placed where the SYSPRO option 'EC Vat system required' is selected. The mode of transport code is optional, but if entered is up to 2 numeric digits.
        '''</summary>
        Public Property TransportMode() As String
            Get
                Return Me.transportModeField
            End Get
            Set
                Me.transportModeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for orders placed where the SYSPRO option 'EC Vat system required' is selected. The process flag is optional, but if entered is 1 numeric containing  0-9.
        '''</summary>
        Public Property ProcessFlag() As String
            Get
                Return Me.processFlagField
            End Get
            Set
                Me.processFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the customer's tax exemption number. If it is not supplied, the tax exemption number from the Customer Master table is used. The element can contain up to 30 alphanumeric characters. Although the element is only meaningful for an exempt order, if suppllied it will be used, regardless of the type of order.
        '''</summary>
        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set
                Me.taxExemptNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This is used to override the tax status of the customer. If not given or blank the tax status of the customer is used for a new order. It can be used to change the tax status of an existing order.
        '''</summary>
        Public Property TaxExemptionStatus() As TaxExemptionStatus
            Get
                Return Me.taxExemptionStatusField
            End Get
            Set
                Me.taxExemptionStatusField = value
                Me.TaxExemptionStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxExemptionStatusSpecified() As Boolean
            Get
                Return Me.taxExemptionStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the customer's Gst exemption number. If it is not supplied, the Gst exemption number from the Customer Master table is used. The element can contain up to 15 alphanumeric characters. Although the element is only meaningful for a Gst exempt order where Canadian tax is in force, if supllied it will be used, regardless of the type of order.
        '''</summary>
        Public Property GstExemptNumber() As String
            Get
                Return Me.gstExemptNumberField
            End Get
            Set
                Me.gstExemptNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This is used to override the GSTstatus of the customer if Canadian tax is required. If not given or blank the GSTstatus of the customer is used for a new order. It can be used to change the GSTstatus of an existing order.
        '''</summary>
        Public Property GstExemptionStatus() As GstExemptionStatus
            Get
                Return Me.gstExemptionStatusField
            End Get
            Set
                Me.gstExemptionStatusField = value
                Me.GstExemptionStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GstExemptionStatusSpecified() As Boolean
            Get
                Return Me.gstExemptionStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the customer's company tax registration number. If it is not supplied, the company tax registration number from the Customer Master table is used. The element can contain up to 15 alphanumeric characters. Although the element is only meaningful for a taxable order, if suppllied it will be used, regardless of the type of order.
        '''</summary>
        Public Property CompanyTaxNumber() As String
            Get
                Return Me.companyTaxNumberField
            End Get
            Set
                Me.companyTaxNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates which tax code must be used if ship address is per line. Valid values are 'H' - Tax code from header ship address area or 'L' - Tax code from line ship address area. If not supplied, defaults to 'H'. It only applies if tax by geographic area.
        '''</summary>
        Public Property ShipAddressPerLineTax() As ShipAddressPerLineTax
            Get
                Return Me.shipAddressPerLineTaxField
            End Get
            Set
                Me.shipAddressPerLineTaxField = value
                Me.ShipAddressPerLineTaxFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShipAddressPerLineTaxSpecified() As Boolean
            Get
                Return Me.shipAddressPerLineTaxFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only required if the sales order has an OrderActionType of 'D' - delete. If the SYSPRO setup option to retain analysis details for cancelled order lines is selected, then the contents of this element must be a valid Cancel Reason code within SYSPRO. It can contain 1 to 6 alphanumeric characters.
        '''</summary>
        Public Property CancelReasonCode() As String
            Get
                Return Me.cancelReasonCodeField
            End Get
            Set
                Me.cancelReasonCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the document format number to be used when printing the document on SYSPRO. If entered, it must be in the range 0 to 9, A - Z, a-z. If not entered, then the code from the customer will be used. If there is no code on the customer, zero is assumed.
        '''</summary>
        Public Property DocumentFormat() As String
            Get
                Return Me.documentFormatField
            End Get
            Set
                Me.documentFormatField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the state code that is part of the extended tax code  that will be used for the order. It must make up a valid extended tax code if entered. If not supplied, then the SYSPRO rules for obtaining the extended tax code will be used. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 2 character alphanumeric. If the three extended tax entries are left blank, the whole extended tax code will default to that on the customer master.
        '''</summary>
        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the county or zip code that is part of the extended tax code  that will be used for the order. It must make up a valid extended tax code if entered. If not supplied, then the SYSPRO rules for obtaining the extended tax code will be used. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 5 character alphanumeric (AVP sales tax) or 4 characters alphanumeric  (Advanced geocodes). 
        '''</summary>
        Public Property CountyZip() As String
            Get
                Return Me.countyZipField
            End Get
            Set
                Me.countyZipField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the city code that is part of the extended tax code  that will be used for the order. It must make up a valid extended tax code if entered. If not supplied, then the SYSPRO rules for obtaining the extended tax code will be used. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 3 character alphanumeric (Advanced geocodes) or 2 characters alphanumeric (AVP sales tax).
        '''</summary>
        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant if load planning is in use. 'N', the default - No delivery route required, 'E', use delivery route entered in element 'DeliveryRoute', 'C', use delivery route from customer, 'X', remove exisitng delivery route from order.
        '''</summary>
        Public Property DeliveryRouteAction() As DeliveryRouteAction
            Get
                Return Me.deliveryRouteActionField
            End Get
            Set
                Me.deliveryRouteActionField = value
                Me.DeliveryRouteActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DeliveryRouteActionSpecified() As Boolean
            Get
                Return Me.deliveryRouteActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Only relevant if load planning is in use. It is used in conjunction with the element 'DeliveryRouteAction'.  If entered, and DeliveryRouteAction is 'E', then it must be a valid delivery route code. 
        '''</summary>
        Public Property DeliveryRoute() As String
            Get
                Return Me.deliveryRouteField
            End Get
            Set
                Me.deliveryRouteField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used in conjunction with the SYSPRO customer rule 'Invoice whole orders only' . This element may be used to over-ride the rule for an individual order only. it may only be used if the operator has authority to do this.
        '''</summary>
        Public Property InvoiceWholeOrderOnly() As InvoiceWholeOrderOnly
            Get
                Return Me.invoiceWholeOrderOnlyField
            End Get
            Set
                Me.invoiceWholeOrderOnlyField = value
                Me.InvoiceWholeOrderOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InvoiceWholeOrderOnlySpecified() As Boolean
            Get
                Return Me.invoiceWholeOrderOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the action to be applied when qualifying trade promotions. This element is used in conjunction with the element 'SalesOrderPromoSelectAction'.
        '''
        '''
        '''
        '''If  'SalesOrderPromoQualifyAction' is 'W', then the whole order is taken, and all lines are submitted for checking, and all qualifying promotions will be applied, or reapplied to the order.
        '''
        '''
        '''
        '''If  'SalesOrderPromoQualifyAction' is 'S', then only merchandise  lines  with the 'TradePromotionsCodes' node are submitted for checking, and all qualifying promotions for them will be applied, or reapplied to the order.  
        '''
        ''''Sales OrderPromoSelectionAction' is only applicable when 'SalesOrderPromoQualityAction' is 'W'. If  'SalesOrderPromoSelectAction' is 'A' (all lines),  it has the same effect as selecting 'Requalify' in Sales Order Entry, with the TP setup options 'Automatically select line promotions' and 'Automatically select global promotions' set on. Any line or global promotion codes supplied will be ignored. 
        '''
        '''If 'SalesOrderPromoSelectAction' is 'S' (selected lines),  then only lines containing the 'TradePromotionCodes' element are considered for selection. 
        '''The specific promotions required may be provided for the relevant sales order lines. If no promotion codes are given for a selected line, then all promotions for that line are marked as selected. If the GlobalTradePromotionsCodes is supplied, then only those entered will be selected. If the element is supplied, but no codes, then all global promotions for the order are marked as selected.
        '''</summary>
        Public Property SalesOrderPromoQualifyAction() As SalesOrderPromoQualifyAction
            Get
                Return Me.salesOrderPromoQualifyActionField
            End Get
            Set
                Me.salesOrderPromoQualifyActionField = value
                Me.SalesOrderPromoQualifyActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SalesOrderPromoQualifyActionSpecified() As Boolean
            Get
                Return Me.salesOrderPromoQualifyActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the action to be applied when selecting trade promotions. This element is used in conjunction with the element 'SalesOrderPromoSelectAction', and is only applicable when 'SalesOrderPromoQualifyAction' is 'W'.
        '''
        '''If  'SalesOrderPromoSelectAction' is 'A' (all lines),  it has the same effect as selecting 'Requalify' in Sales Order Entry, with the TP setup options 'Automatically select line promotions' and 'Automatically select global promotions' set on.  Any line or global promotion codes supplied will be ignored. .
        '''
        '''
        '''
        '''If  'SalesOrderPromoQualifyAction' is 'S', then only merchandise lines with the 'TradePromotionsCodes' node are submitted for checking, and all qualifying promotions for them will be applied, or reapplied to the order.  
        '''
        ''''Sales OrderPromoSelectionAction' is only applicable when 'SalesOrderPromoQualityAction' is 'W'. If  'SalesOrderPromoSelectAction' is 'A' (all lines),  it has the same effect as selecting 'Requalify' in Sales Order Entry, with the TP setup options 'Automatically select line promotions' and 'Automatically select global promotions' set on. Any line or global promotion codes supplied will be ignored. 
        '''
        '''If 'SalesOrderPromoSelectAction' is 'S' (selected lines),  then only lines containing the 'TradePromotionCodes' element are considered for selection. 
        '''The specific promotions required may be provided for the relevant sales order lines. If no promotion codes are given for a selected line, then all promotions for that line are marked as selected. If the GlobalTradePromotionsCodes is supplied, then only those entered will be selected. If the element is supplied, but no codes, then all global promotions for the order are marked as selected.
        '''</summary>
        Public Property SalesOrderPromoSelectAction() As SalesOrderPromoSelectAction
            Get
                Return Me.salesOrderPromoSelectActionField
            End Get
            Set
                Me.salesOrderPromoSelectActionField = value
                Me.SalesOrderPromoSelectActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SalesOrderPromoSelectActionSpecified() As Boolean
            Get
                Return Me.salesOrderPromoSelectActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This must be a list of qualified global promotions for the order selected. Each code is a maximum of 10 characters, separated by a comma.
        '''
        '''
        '''
        '''If the element SalesOrderAction is 'W', then this is ignored.
        '''</summary>
        Public Property GlobalTradePromotionCodes() As String
            Get
                Return Me.globalTradePromotionCodesField
            End Get
            Set
                Me.globalTradePromotionCodesField = value
            End Set
        End Property
        
        '''<summary>
        '''The Sales Order number allocated by SYSPRO Point of Sale. This is only available if the SYSPRO Point of Sale system is currently in use, and a new sales order is being added.
        '''</summary>
        Public Property POSSalesOrder() As String
            Get
                Return Me.pOSSalesOrderField
            End Get
            Set
                Me.pOSSalesOrderField = value
            End Set
        End Property
        
        Public Property IncludeInMrp() As OrderHeaderIncludeInMrp
            Get
                Return Me.includeInMrpField
            End Get
            Set
                Me.includeInMrpField = value
                Me.IncludeInMrpFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeInMrpSpecified() As Boolean
            Get
                Return Me.includeInMrpFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If required, this element must contain a GUID, for the eSignature system to accept the transaction as having been authenticated. The GUID format is in the format {36303032-3330-3031-3038-323434363433}, where the numbers can be replaced with any character. It is up to the developer to have requested a password to protect the transaction. An example is that a GUID associated with the act of entering a valid password could be obtained and presented.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ShipAddressPerLine
        
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
    Public Enum TaxExemptionStatus
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ShipAddressPerLineTax
        
        '''<remarks/>
        H
        
        '''<remarks/>
        L
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SalesOrderPromoQualifyAction
        
        '''<remarks/>
        W
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("S ")>  _
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SalesOrderPromoSelectAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OrderHeaderIncludeInMrp
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Orders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderHeaderField As OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDetailsField As OrderDetails
        
        '''<summary>
        '''This element contains the elements that make up the order header information for a sales order.
        '''</summary>
        Public Property OrderHeader() As OrderHeader
            Get
                Return Me.orderHeaderField
            End Get
            Set
                Me.orderHeaderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the elements that make up the order detail line information. It can contain StockLine (for stocked lines), CommentLine (for comment lines), MiscChargeLine (for lines containing miscellaneous charges) and FreightLine (for lines relating to freight charges).
        '''</summary>
        Public Property OrderDetails() As OrderDetails
            Get
                Return Me.orderDetailsField
            End Get
            Set
                Me.orderDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SalesOrders
        Implements ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transmissionHeaderField As TransmissionHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersField As List(Of Orders)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''The transmission header holds information used to track documents.
        '''</summary>
        Public Property TransmissionHeader() As TransmissionHeader
            Get
                Return Me.transmissionHeaderField
            End Get
            Set
                Me.transmissionHeaderField = value
            End Set
        End Property
        
        '''<summary>
        '''This node contains all the information required to add, change or delete a slaes order. It can appear multiple times
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Orders")>  _
        Public Property OrdersCollection() As List(Of Orders)
            Get
                Return Me.ordersField
            End Get
            Set
                Me.ordersField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTOI"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters()
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim doc As System.Xml.XmlDocument = Common.SysproUtilities.SerializeToXMLDoc(Me)
                Common.SysproUtilities.SortTheOrderLinesByCustomerPOLineNumber(doc)
                Dim outerXML As String = doc.OuterXml
                outerXML = outerXML.Replace("<DeliveryLoad />", "")
                outerXML = outerXML.Replace("<DeliveryLoad/>", "")



                Return outerXML
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.SalesOrders
                objParams = New Params.SalesOrders()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class TransmissionHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transmissionReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private senderCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiverCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePreparedField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePreparedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timePreparedField As String
        
        '''<summary>
        '''This reference is for reference purposes only (up to 14 characters, alphanumeric).
        '''</summary>
        Public Property TransmissionReference() As String
            Get
                Return Me.transmissionReferenceField
            End Get
            Set
                Me.transmissionReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the code referring to the sending trading partner. Within SYSPRO you can set up trading partners and give them a code. This code is used to identify them so most of the normal information does not need to be passed. If there is an entry for SenderCode it must be valid. If this code is not supplied then the Customer element customer code will be used. If this is not present then the "Customer to Access" against the operator code is used. If this is also not present the "Customer to Use" code in the supplied parameter file is used. This field is up to 40 characters, alphanumeric.
        '''</summary>
        Public Property SenderCode() As String
            Get
                Return Me.senderCodeField
            End Get
            Set
                Me.senderCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the EDI code for the organization (up to 40 characters, alphanumeric), and is for reference purposes only.
        '''</summary>
        Public Property ReceiverCode() As String
            Get
                Return Me.receiverCodeField
            End Get
            Set
                Me.receiverCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the date that this document was produced and is for reference purposes  only. If not supplied it will default to the run date. The format is CCYY-MM-DD.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property DatePrepared() As Date
            Get
                Return Me.datePreparedField
            End Get
            Set
                Me.datePreparedField = value
                Me.DatePreparedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DatePreparedSpecified() As Boolean
            Get
                Return Me.datePreparedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the time that the orginal document was prepared and is for reference purposes only. If not supplied it defaults to the run time. The format is HH:MM in the 24 hour clock.
        '''</summary>
        Public Property TimePrepared() As String
            Get
                Return Me.timePreparedField
            End Get
            Set
                Me.timePreparedField = value
            End Set
        End Property
    End Class
End Namespace
