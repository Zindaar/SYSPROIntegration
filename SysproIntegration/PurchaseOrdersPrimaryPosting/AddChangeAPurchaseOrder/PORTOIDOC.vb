Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.AddChangeAPurchaseOrder.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyDueDateToLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        A
        
        '''<remarks/>
        L
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ChgPOStatToReadyToPrint
        
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
    Partial Public Class CommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedToStkLineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteAttachedCommentLinesField As DeleteAttachedCommentLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteAttachedCommentLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSingleCommentLineField As ChangeSingleCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSingleCommentLineFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
            Me.deleteAttachedCommentLinesField = DeleteAttachedCommentLines.N
        End Sub
        
        '''<summary>
        '''Indicates the Purchase order line to be changed or deleted. Must be supplied when changing or deleting a line.  When changing or deleting line the P/order line supplied must be on file. When adding a new P/order line - the line number will be generated automatically using the next line number field from the P/order header. This is a 4 integer field.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the line should be added, changed or deleted. Possible values A (add), C (change) or D (delete). Default A. If adding a purchase order,then all detail lines must have an A for LineActionType (will automatically be set to A)
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
                Me.LineActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionTypeSpecified() As Boolean
            Get
                Return Me.lineActionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Comment can contain up to 990 characters, which equals 22 lines of 45 characters. The comment will be spilt into separate lines of 45 characters for you in order to save them on the P/order detail table. Please note when changing a P/order comment the whole comment will be deleted and overwritten by the new comment supplied - in other words you will not be able to change only one comment line of 45 characters alone. (Therefore when changing supply the complete new comment). Please note that  when changing the comment lines you will not be allowed to add more comment lines than the original comment had unless the comment is the last line for the P/order.
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
        '''Enter a line number in this element to attach the comment line to an order line. Comment lines may only be attached to stocked and non-stocked lines. This is a 4 character integer field.
        '''</summary>
        Public Property AttachedToStkLineNumber() As String
            Get
                Return Me.attachedToStkLineNumberField
            End Get
            Set
                Me.attachedToStkLineNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element will indicate if only this specific comment line should be deleted or the complete comment (if the comment spans over more than one line). Default N (No). (Y- yes will delete the entire comment - all the lines, N - No will only delete the specific comment line supplied).
        '''</summary>
        Public Property DeleteAttachedCommentLines() As DeleteAttachedCommentLines
            Get
                Return Me.deleteAttachedCommentLinesField
            End Get
            Set
                Me.deleteAttachedCommentLinesField = value
                Me.DeleteAttachedCommentLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DeleteAttachedCommentLinesSpecified() As Boolean
            Get
                Return Me.deleteAttachedCommentLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Only used if the comment is to be changed. Possible values Y (Yes) or N (No). The default is N(No). If the element is set  to 'Y', then only the comment line selected will be changed. In addition, the length of the element Comment cannot be more than 45. If set to 'N' then the comment lines from this line to the next non-comment line will be replaced by the contents of the element Comment.
        '''</summary>
        Public Property ChangeSingleCommentLine() As ChangeSingleCommentLine
            Get
                Return Me.changeSingleCommentLineField
            End Get
            Set
                Me.changeSingleCommentLineField = value
                Me.ChangeSingleCommentLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChangeSingleCommentLineSpecified() As Boolean
            Get
                Return Me.changeSingleCommentLineFieldSpecified
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
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DeleteAttachedCommentLines
        
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
    Public Enum ChangeSingleCommentLine
        
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
    Public Enum DiscountLessPlus
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ExchRateFixed
        
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
    Public Enum FreightFLoc
        
        '''<remarks/>
        L
        
        '''<remarks/>
        F
        
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
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxableField As FreightTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightFLocField As FreightFLoc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightFLocFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
        End Sub
        
        '''<summary>
        '''Indicates the Purchase order line to be changed or deleted. Must be supplied when changing or deleting a line.  When changing or deleting line the P/order line supplied must be on file. When adding a new P/order line - the line number will be generated automatically using the next line number field from the P/order header. This is a 4 integer field.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the line should be added, changed or deleted. Possible values A (add), C (change) or D (delete). Default A. If adding a purchase order,then all detail lines must have an A for LineActionType (will automatically be set to A)
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
                Me.LineActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionTypeSpecified() As Boolean
            Get
                Return Me.lineActionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Used to enter freight charges that you want to assign to the order. This is a signed 12 integer, 2 decimal field.
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
        '''You use this field to indicate the tax code that you want to assign to the freight order line. May not be blank when adding a freight line - or changing the tax status of the line from no to yes - and the taxable status of the line is Yes.This is a 1 character, alphanumeric field.
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
        '''You use this option to indicate whether the order line is taxable. If not supplied or contains spaces will default to the tax status of the P/order header. Possible value Y (Yes), N (No) or spaces.
        '''
        '''</summary>
        Public Property FreightTaxable() As FreightTaxable
            Get
                Return Me.freightTaxableField
            End Get
            Set
                Me.freightTaxableField = value
                Me.FreightTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightTaxableSpecified() As Boolean
            Get
                Return Me.freightTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only used if processing freight charges for a foreign currency supplier. This enables you to indicate the currency in which the charge is being entered. If not supplied and a P/order is added for a foreign currency supplier it  will default according to the Purchase order set-up for Freight charges (Details tab). This is a 1 character, alphanumeric field. Possible values L (local) or F (foreign).
        '''</summary>
        Public Property FreightFLoc() As FreightFLoc
            Get
                Return Me.freightFLocField
            End Get
            Set
                Me.freightFLocField = value
                Me.FreightFLocFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightFLocSpecified() As Boolean
            Get
                Return Me.freightFLocFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FreightTaxable
        
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
    Public Enum InspectionReqd
        
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
    Public Enum LineDiscLessPlus
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum LineDiscType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
        
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
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTaxableField As MiscTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeFLocField As MiscChargeFLoc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeFLocFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscCommentCodeField As String
        
        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
        End Sub
        
        '''<summary>
        '''Indicates the Purchase order line to be changed or deleted. Must be supplied when changing or deleting a line.  When changing or deleting line the P/order line supplied must be on file. When adding a new P/order line - the line number will be generated automatically using the next line number field from the P/order header. This is a 4 integer field.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the line should be added, changed or deleted. Possible values A (add), C (change) or D (delete). Default A. If adding a purchase order,then all detail lines must have an A for LineActionType (will automatically be set to A)
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
                Me.LineActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionTypeSpecified() As Boolean
            Get
                Return Me.lineActionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the miscellaneous charges to be applied to an order.  This is a signed 12 integer, 2 decimal field.
        '''
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
        '''You use this option to indicate the tax code to be used for the miscellaneous order line.  This is a 1 character, alphanumeric field.
        '''</summary>
        Public Property MiscChargeTax() As String
            Get
                Return Me.miscChargeTaxField
            End Get
            Set
                Me.miscChargeTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether the miscellaneous order line is taxable. If not supplied or contains spaces will default to the tax status of the P/order header. Possible values Y (Yes) or N (No).
        '''
        '''</summary>
        Public Property MiscTaxable() As MiscTaxable
            Get
                Return Me.miscTaxableField
            End Get
            Set
                Me.miscTaxableField = value
                Me.MiscTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscTaxableSpecified() As Boolean
            Get
                Return Me.miscTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only used if processing miscellaneous charges for a foreign currency supplier. This enables you to indicate the currency in which the charge is being entered.
        '''If not supplied and a P/order is added for a foreign currency supplier  it will default according to the Purchase order set-up for Misc charges (Details tab).
        '''Possible values L (local) or F (foreign).
        '''
        '''</summary>
        Public Property MiscChargeFLoc() As MiscChargeFLoc
            Get
                Return Me.miscChargeFLocField
            End Get
            Set
                Me.miscChargeFLocField = value
                Me.MiscChargeFLocFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscChargeFLocSpecified() As Boolean
            Get
                Return Me.miscChargeFLocFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the description for the miscellaneous charge line. This is a 45 character, alphanumeric field.
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
        '''If standard comments have been created you can enter the comment code instead of a description for the miscellaneous order line. This is a 3 character, alphanumeric field.
        '''</summary>
        Public Property MiscCommentCode() As String
            Get
                Return Me.miscCommentCodeField
            End Get
            Set
                Me.miscCommentCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MiscTaxable
        
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
    Public Enum MiscChargeFLoc
        
        '''<remarks/>
        L
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
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
                Me.freightLineField = New List(Of FreightLine)
            End If
            If (Me.miscChargeLineField Is Nothing) Then
                Me.miscChargeLineField = New List(Of MiscChargeLine)
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New List(Of CommentLine)
            End If
            If (Me.stockLineField Is Nothing) Then
                Me.stockLineField = New List(Of StockLine)
            End If
        End Sub
        
        '''<summary>
        '''The element Stock Line must be used to identify the start and end of the import information for the order stocked/non-stocked line.
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
        '''The element CommentLine must be used to identify the start and end of the import information for the comment order line section.
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
        '''The element MiscChargeLine must be used to identify the start and end of the import information for the other/miscellaneous charge order line section.
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
        '''The element FreightLine must be used to identify the start and end of the import information for the freight order line section.
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
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeField As LineActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supCatalogueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As PriceMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierContractReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscTypeField As LineDiscType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscLessPlusField As LineDiscLessPlus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscLessPlusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableField As Taxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private latestDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rescheduleDueDateField As RescheduleDueDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rescheduleDueDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractOpField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionReqdField As InspectionReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonsUnitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonsUnitVolField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedLineField As String

        Public Sub New()
            MyBase.New
            Me.lineActionTypeField = LineActionType.A
            Me.lineDiscTypeField = LineDiscType.P
            Me.lineDiscLessPlusField = LineDiscLessPlus.L
            Me.inspectionReqdField = InspectionReqd.N
        End Sub
        
        '''<summary>
        '''Indicates the Purchase order line to be changed or deleted. Must be supplied when changing or deleting a line.  When changing or deleting line the P/order line supplied must be on file. When adding a new P/order line - the line number will be generated automatically using the next line number field from the P/order header. This is a 4 integer field.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the line should be added, changed or deleted. Possible values A (add), C (change) or D (delete). Default A. If adding a purchase order,then all detail lines must have an A for LineActionType (will automatically be set to A)
        '''</summary>
        Public Property LineActionType() As LineActionType
            Get
                Return Me.lineActionTypeField
            End Get
            Set
                Me.lineActionTypeField = value
                Me.LineActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionTypeSpecified() As Boolean
            Get
                Return Me.lineActionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the stock item for the P/order line. If the stock code supplied does not exist on the inventory master and the parameter AllowNonStockItems is set to Y (Yes) then the detail line will be added as a non-stocked line. This is a 30 character, alphanumeric field.
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
        '''Indicates the stock description for the stock/non-stocked code for a P/order line. Will default to the Inventory master stock description but can be changed against the P/order by supplying a stock description. This is a 30 character, alphanumeric field.
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
        '''If the purchase order set-up option to Restrict order to single warehouse and use for delivery address has been selected (P/order set-up - Option tab) - then the warehouse supplied in the OrderHeader will be used for the entire order and you will not be allowed to enter/change the warehouse per P/order line. A warehouse can be supplied per P/order line if the set-up option has not been selected. You will not be allowed to change the warehouse for the entire order by supplying the new warehouse code in the OrderHeader when maintaining the order if the option to Restrict order to single warehouse has been selected.This is a 2 character, alphanumeric field. If the option to Restrict order to single warehouse has been selected then the delivery address against the warehouse will be used for the delivery address of the new P/order.
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
        '''The supplier's catalogue number can be supplied instead of the SYSPRO stock code. The Supplier/stock code interchange system required option must be selected in the Inventory set-up (option tab) and the stock code must be linked to a supplier catalogue number. If the stock code has not been supplied or contains spaces and supplier/stock code interchange system is required - the suppliers catalogue will be used to retrieve the SYSPRO stock code. The suppliers catalogue will only be validated if the stock code was not supplied. This is a 30 character, alphanumeric field.
        '''</summary>
        Public Property SupCatalogue() As String
            Get
                Return Me.supCatalogueField
            End Get
            Set
                Me.supCatalogueField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the order quantity for the stocked/non-stocked line.  At least one of the qty fields must be supplied either OrderQty or Units and Pieces.
        '''If stock item requires Unit quantity processing but quantity is supplied it will be used rather than the units and pieces. Else the units and pieces will be used.
        '''If a decimal quantity is supplied for an item that uses unit quantity processing the quantity must convert to a valid number of units and pieces.
        '''If item does not require unit quantity processing, units/pieces are invalid.
        '''This is a signed 7 integer, 3 decimal field.
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
        '''Indicates the unit of measure for the order quantity. If not supplied - will default to the inventory master stocking unit of measure. For non-stocked the default Unit of measure will be used - Inventory set-up - Option tab. This is a 3 character, aplha-numeric field. The Order unit of measure may be either the stocking unit of measure or the alternate unit of measure when the purchase order set-up option (General tab) to Use alternate unit of measure for order quantity has been selected (enabling you to use as the order quantity either the stocking or alternate unit of measure). You will not be able to change the order unit of measure for a stock code that requires Unit quantity processing. The inventory master stocking unit of measure will always be used for a stock code that requires Unit quantity processing. 
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
        '''Indicates the units for the order line if the stock code makes use of unit quantity processing. This is a 7 integer field.
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
        '''Indicates the pieces for the order line if the stock code makes use of unit quantity processing. This is a 3 integer field.
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
        '''The purpose of the price method is to allow the user to select where the unit price for the P/order line should default from during order entry. Therefore a price does not have to be supplied. If neither a price nor a price method has been supplied for the line - Price method will default according to P/order setup General tab. PriceMethod may only contain "M" (Manual), "CC" (Current cost),  "LC" (Last cost),  "LP" (List price) , "LPP" (Last price paid), S (Supplier price) or F (Foreign Price). For non-stocked items always Manual - M.
        '''</summary>
        Public Property PriceMethod() As PriceMethod
            Get
                Return Me.priceMethodField
            End Get
            Set
                Me.priceMethodField = value
                Me.PriceMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceMethodSpecified() As Boolean
            Get
                Return Me.priceMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''When using the supplier's price method - the supplier's contract number must be supplied in order to retrieve the correct default list price. This is a 6 character, alphanumeric field.
        '''</summary>
        Public Property SupplierContract() As String
            Get
                Return Me.supplierContractField
            End Get
            Set
                Me.supplierContractField = value
            End Set
        End Property
        
        '''<summary>
        '''When using the supplier's price method - the supplier's contract number must be supplied in order to retrieve the correct default list price. The supplier contract reference can additoinally be supplied to differentiate between more than one entry with the same contract number. This is a 10 character, alphanumeric field.
        '''</summary>
        Public Property SupplierContractReference() As String
            Get
                Return Me.supplierContractReferenceField
            End Get
            Set
                Me.supplierContractReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the unit price to be applied for the order line. This is a 10 integer, 5 decimal field.If the purchase order is for a local currency and no price method or price has been supplied then the price will default based on the P/order set-up default pricing method. If default pricing method is Current inventory cost price: If you have not supplied a Price then the warehouse cost will be used for the Price.If default pricing method is Purchasing price: If you have not supplied a Price then the inventory selling price will be used for the Price.If default Last price paid: If a catalogue exists then the last price paid will be used from the P/o Supplier/Stock code information table. If  you have selected Supplier Prices as a Pricing method and you supply the supplier contract the program will extract the Price from the P/o Supplier/stock code contract price file. The pricing method F (Foreign price) may only be selected if the supplier is a foreign supplier and a Foreign Purchase Price exists on file for the stock code. (Inventory set-up Foreign Purchasing Price). Will pick up the Foreign price from the Foreign Purchase Price file. If a valid job number and subcontract number has been supplied for a non-stocked P/order line. The List price will default to the subcontract operation unit cost.
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
        '''Indicates the price unit of measure for the order line. If not supplied and there is no default Pricing method - will default to the inventory master stocking unit of measure. For non-stocked if a stock unit of measure has been supplied the price Unit of measure will default to the Stock unit of measure or else the default Unit of measure will be used - Inventory set-up - Option tab. This is a 3 character, alphanumeric field.
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
        '''Indicates if the line discount has been entered as a value or percentages. Possible values - P (percentage) or V (value). Default P.
        '''</summary>
        Public Property LineDiscType() As LineDiscType
            Get
                Return Me.lineDiscTypeField
            End Get
            Set
                Me.lineDiscTypeField = value
                Me.LineDiscTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineDiscTypeSpecified() As Boolean
            Get
                Return Me.lineDiscTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use the Line Discount elements to enter/change the discount percentages to be applied to the line. This element indicates if the discount should be added or subtracted from the line value. Possible values: L - less or P - Plus. Default - L.
        '''</summary>
        Public Property LineDiscLessPlus() As LineDiscLessPlus
            Get
                Return Me.lineDiscLessPlusField
            End Get
            Set
                Me.lineDiscLessPlusField = value
                Me.LineDiscLessPlusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineDiscLessPlusSpecified() As Boolean
            Get
                Return Me.lineDiscLessPlusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use the Line Discount elements to enter/change the discount percentages to be applied to the order line. This element indicates the first discount percentage. This is a signed 3 integer, 2 decimal field. If this element is not supplied, or is zero, then the elements LineDiscPercent2 and LineDiscPercent3 cannot contain a value.
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
        '''You use the Line Discount elements to enter/change the discount percentages to be applied to the order line. This element indicates the second discount percentage. This is a signed 2 integer, 2 decimal field. If this element is not supplied, or is zero, then the element DiscPercent3 cannot contain a value.
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
        '''You use the Line Discount elements to enter/change the discount percentages to be applied to the order line. This element indicates the third discount percentage. This is a signed 2 integer, 2 decimal field.
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
        '''Indicates the line discount value to be applied to the order line. This is a signed 12 integer, 2 decimal field.
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
        '''Indicates if the line is taxable - only used if the order header is taxable. Possible values Y (Yes) or N (No). If the taxable status has not been supplied for the line, the line will default to Taxable.
        '''</summary>
        Public Property Taxable() As Taxable
            Get
                Return Me.taxableField
            End Get
            Set
                Me.taxableField = value
                Me.TaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxableSpecified() As Boolean
            Get
                Return Me.taxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the tax code to be used for the stocked/non-stocked order line if taxable. This is a 1 character, alphanumeric field. The tax code will default from the inventory master for a stocked item if not supplied and line is taxable.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the job number that you want to associate with this purchase order line. If the Work in Progress module is installed, then the job is validated. This number will become the default job number when performing a purchase order receipt. This is an 8 character, alphanumeric field.
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is required when adding a purchase order line for a job that is heirarchical, and must be valid against the job. When changing the job on a line, this elemtn is required if the new job  is heirarchical, and must be valid against the job.
        '''</summary>
        Public Property HierHead() As String
            Get
                Return Me.hierHeadField
            End Get
            Set
                Me.hierHeadField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used together with the Section2, Section3 and Section4 elements to build a full hierarchy for validating against a hierarchical job. It is only required if the element HierHead has been entered
        '''</summary>
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used together with the Section1, Section3 and Section4 elements to build a full hierarchy for validating against a hierarchical job. It is only required if the elements HierHead  and Section1 have been entered
        '''</summary>
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used together with the Section1, Section2 and Section4 elements to build a full hierarchy for validating against a hierarchical job. It is only required if the elements HierHead ,Section1 and Section2 have been entered
        '''</summary>
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used together with the Section1, Section2 and Section3 elements to build a full hierarchy for validating against a hierarchical job. It is only required if the elements HierHead ,Section1, Section2 and Section3 have been entered
        '''</summary>
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the version number for the stock code if ECC is in use and the order line is for an ECC controlled item. This is a 3 character, alphanumeric field.
        '''</summary>
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the release number for the stock code if ECC is in use and the order line is for an ECC controlled item. This is a 3 character, alphanumeric field.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to enter the due date of the line. Must be in a CCYY-MM-DD format. If you have the parameter Calc due date (based on lead time) selected (set to Y), the P/order header Due date and the inventory master lead time will be used to calculate a due date for the line. If a Due date was not supplied for the header the current system date would have been used.  If a supersession date has been entered against the stock code  the due date will be checked against the supersession date. 
        '''</summary>
        Public Property LatestDueDate() As String
            Get
                Return Me.latestDueDateField
            End Get
            Set
                Me.latestDueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the original due date of the order line if changes were made to the due date. Will only be used if the line action type is C (Change). Must be  entered in a CCYY-MM-DD format. 
        '''</summary>
        Public Property OriginalDueDate() As String
            Get
                Return Me.originalDueDateField
            End Get
            Set
                Me.originalDueDateField = value
            End Set
        End Property
        
        '''<summary>
        ''' Allow MRP to reschedule due date may only contain Y or N. You use this option to indicate whether MRP can reschedule the due date of the order. When a Requirements Calculation is performed and this option is enabled, you can change the due date of the order to fall in line with the production schedule. 
        ''' If adding a P/order line for a non-stocked item and a job number has been supplied and the line has been flagged as a subcontract operation (a subcontract operation number supplied) the Reschedule for MRP flag will default to N (No) if not supplied. When adding a stocked line the Reschedule for MRP flag will default to Y (Yes) - if not supplied
        '''
        '''</summary>
        Public Property RescheduleDueDate() As RescheduleDueDate
            Get
                Return Me.rescheduleDueDateField
            End Get
            Set
                Me.rescheduleDueDateField = value
                Me.RescheduleDueDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property RescheduleDueDateSpecified() As Boolean
            Get
                Return Me.rescheduleDueDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this field to indicate the ledger code that must be debited when processing a purchase order receipt. For stock codes the inventory warehouse ledger code will be used. For non-stocked lines the default WIP ledger code will be used only if a job number has been supplied and WIP integrated to G/L or the Ledger code supplied against the Job. The Ledger code supplied will only be used for a non-stocked item when there is no Job number against the P/order line.  In this case the Ledger code is mandatory depending on the P/order parameter  Allow blank ledger code (for non-stocked).This is a 15 character, alphanumeric field.
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If the Ledger code supplied for the Non-stock P/order line is password protected a valid  password must be supplied. This is a 4 character, alphanumeric field.
        '''</summary>
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the sub-contract operation code to be applied to the P/order line. This element will only be used if the P/order line is a non-stocked line and a job number has been supplied. If a valid job number and subcontract number has been supplied for a non-stocked P/order line the List price will default to the subcontract operation unit cost when adding a new line.
        '''This is a 4 integer field.
        '''</summary>
        Public Property SubcontractOp() As String
            Get
                Return Me.subcontractOpField
            End Get
            Set
                Me.subcontractOpField = value
            End Set
        End Property
        
        '''<summary>
        '''Only for non-stocked items. Possible value - Y (Yes) or N (No). Default - N.
        '''Select this option if you want to receive the non-stocked order line into inspection and perform two-tier receipting of the item using the Purchase Receipts and Inspections program. Once in inspection, you can count the non-stocked quantity, scrap quantities, reject quantities, return quantities, and receive the non-stocked item into stock. Any linked sales orders or jobs are updated and the ledger codes entered against the purchase order line are used for distribution.
        '''
        '''
        '''
        '''
        '''
        '''</summary>
        Public Property InspectionReqd() As InspectionReqd
            Get
                Return Me.inspectionReqdField
            End Get
            Set
                Me.inspectionReqdField = value
                Me.InspectionReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InspectionReqdSpecified() As Boolean
            Get
                Return Me.inspectionReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Product class must be provided for a non-stocked P/order line. This is a 4 character, alphanumeric field.
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
        '''Indicates the unit mass for a non-stocked item. This is a signed 6 integer, 6 decimal field.
        '''</summary>
        Public Property NonsUnitMass() As String
            Get
                Return Me.nonsUnitMassField
            End Get
            Set
                Me.nonsUnitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the unit volume for a non-stocked item. This is a signed 6 integer, 6 decimal field.
        '''</summary>
        Public Property NonsUnitVol() As String
            Get
                Return Me.nonsUnitVolField
            End Get
            Set
                Me.nonsUnitVolField = value
            End Set
        End Property

        '''<summary>
        '''This element is used in conjuction with the parameter 'AllowNonStockedItems'. When the parameter is set to 'S' (specify), then this element is used to determine if a line is for a non-stocked item. Valid entries are 'Y' (yes, a non-stocked line), or blank, the default. This element is only relevant for line action type 'A' - add, and will be ignored for other actions.
        '''</summary>
        Public Property NonStockedLine() As String
            Get
                Return Me.nonStockedLineField
            End Get
            Set
                Me.nonStockedLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PriceMethod
        
        '''<remarks/>
        M
        
        '''<remarks/>
        CC
        
        '''<remarks/>
        LC
        
        '''<remarks/>
        LP
        
        '''<remarks/>
        LPP
        
        '''<remarks/>
        S
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Taxable
        
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
    Public Enum RescheduleDueDate
        
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
    Partial Public Class OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderActionTypeField As OrderActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderActionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchRateFixedField As ExchRateFixed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchRateFixedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As OrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As TaxStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyDueDateToLinesField As ApplyDueDateToLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyDueDateToLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountLessPlusField As DiscountLessPlus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountLessPlusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chgPOStatToReadyToPrintField As ChgPOStatToReadyToPrint
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chgPOStatToReadyToPrintFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.orderActionTypeField = OrderActionType.A
            Me.exchRateFixedField = ExchRateFixed.N
            Me.applyDueDateToLinesField = ApplyDueDateToLines.N
            Me.discountLessPlusField = DiscountLessPlus.L
        End Sub
        
        '''<summary>
        '''Indicates the action to be performed for this order header (A - Add a purchase order, C - Change an existing purchase order, D - Cancel the purchase order). Order Action Type will default to A (Add) if not supplied. If adding a sales order header, all detail lines must have an A for LineActionType. If changing an order, the individual order lines may be added, changed or cancelled. If cancelling an order the P/order status will be set to cancelled (*) and the P/order will be flagged as cancelled and not active.
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
        '''Indicates the supplier for the purchase order.  The supplier for the P/order must be supplied when adding a new P/order and can not be changed when maintaining the order. This is a 7 character, alphanumeric field. The operator must have access to the Accounts Payable branch against the supplier. The supplier must allow P/orders (supplier set-up - Purchasing tab).
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
        '''This element will only be relevant if processing an order for a foreign currency supplier and you selected the Allow entry/maintenance of exchange rate option (Purchase Orders Set-up) and the currency has not been flagged as Fixed on the currency conversion table (Accounts payable - Currency Setup).This element will indicate if the default fixed exchange rate is to be used when a foreign supplier is entered during order entry.  All foreign prices entered will be converted to local currency values using this fixed exchange rate. Possible value - Y (Yes) or N (No). Default N.
        '''</summary>
        Public Property ExchRateFixed() As ExchRateFixed
            Get
                Return Me.exchRateFixedField
            End Get
            Set
                Me.exchRateFixedField = value
                Me.ExchRateFixedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExchRateFixedSpecified() As Boolean
            Get
                Return Me.exchRateFixedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If processing an order for a foreign currency supplier and the currency has been flagged as fixed - an exchange rate to be applied to this order can be supplied instead of using the default fixed exchange rate. This is a 6 integer, 6 decimal field.
        '''</summary>
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the Purchase order type. Possible values L (Local), I (Import) or O(Other). The default value for Order type  is determined by the currency code of the supplier and the local currency code defined within the Company options. 
        '''</summary>
        Public Property OrderType() As OrderType
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
                Me.OrderTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderTypeSpecified() As Boolean
            Get
                Return Me.orderTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the customer code if the purchase order is to be processed for a customer. This is a 7 character, alphanumeric field.
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
        '''Indicates the tax status of the P/order. Possible values E (Exempt) or N (Not exempt- taxable). If no value has been supplied - will default to the default tax status in the Purchase order set-up - Option tab. 
        '''</summary>
        Public Property TaxStatus() As TaxStatus
            Get
                Return Me.taxStatusField
            End Get
            Set
                Me.taxStatusField = value
                Me.TaxStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxStatusSpecified() As Boolean
            Get
                Return Me.taxStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the payment terms for the order e.g. COD. This is a 3 character, alphanumeric field.
        '''</summary>
        Public Property PaymentTerms() As String
            Get
                Return Me.paymentTermsField
            End Get
            Set
                Me.paymentTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the invoice terms for the purchase order. Will default to the supplier master invoice terms if not supplied when adding an order. This is a 2 character, alphanumeric field.
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
        '''Indicates the customer purchase order number to be used for cross-referencing purposes. This is a 30 character, alphanumeric field.
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
        '''Indicates the shipping instructions to be applied to the P/order. The shipping instructions for the order will default from the Purchase Order Setup. This is a 30 character, alphanumeric field.
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
        '''Indicates the order date to be applied for the purchase order. Must be in a CCYY-MM-DD format. Will default to current date if not supplied when adding an order.
        '''</summary>
        Public Property OrderDate() As String
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the Due date for the purchase order. The due date defaults to the current system date, if not supplied. This can be printed on the purchase order and used for selection purposes within the Purchase orders by order number report. The order due date will also be used in the Requirements calculation program (Requirements Planning module). Must be supplied in a CCYY-MM-DD format.
        '''</summary>
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the memo date to be applied to the order header. Must be entered in a CCYY-MM-DD format. The memo date defaults from the order date plus the  default memo days supplied in the parameter Default Memo Days if the memo date has not been supplied when adding an order. The memo date can be set to a few days before the order due date, and when running the Purchase orders by order number report you will be able to check all the orders which are coming in on a specific date.
        '''</summary>
        Public Property MemoDate() As String
            Get
                Return Me.memoDateField
            End Get
            Set
                Me.memoDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates that when changing the Due date for the p/order header - the new Due date for the order header will be applied to all stocked and non-stocked detail lines for the order. Possible values  A - apply order header due date to all detail lines or L - apply order due date to all detail lines except lines that are confirmed in a LCT shipment or N - do not apply header due date to order lines. Default N.
        '''</summary>
        Public Property ApplyDueDateToLines() As ApplyDueDateToLines
            Get
                Return Me.applyDueDateToLinesField
            End Get
            Set
                Me.applyDueDateToLinesField = value
                Me.ApplyDueDateToLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyDueDateToLinesSpecified() As Boolean
            Get
                Return Me.applyDueDateToLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the memo code to be applied to the order header. This memo code can be used as a means of identifying who raised the purchase order.  The default Memo code will be used for all new orders where a memo code has not been supplied in the Order Header. This is a 1 character, alphanumeric field.
        '''</summary>
        Public Property MemoCode() As String
            Get
                Return Me.memoCodeField
            End Get
            Set
                Me.memoCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the buyer responsible for purchasing the goods on the purchase order. Buyer will be validated according to the set-up options for buyer in the purchase order set-up - Options tab. If Mandatory - Buyer must be supplied and on file. If Entered - the supplied Buyer must be on file, if not entered, and not mandatory, there is no validation. This is a 3 character, alphanumeric field.
        '''</summary>
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the name of the Delivery address for the P/order. If delivery Name and Address has not been supplied - will use the default Delivery address against the delivery address code supplied in the parameter Default delivery address. If the purchase order set-up option to Restrict order to single warehouse and use for delivery address has been selected ( P/order set-up - Option tab) - the warehouse address will be used instead. This is a 30 character, alphanumeric field.
        '''</summary>
        Public Property DeliveryName() As String
            Get
                Return Me.deliveryNameField
            End Get
            Set
                Me.deliveryNameField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the first line of the Delivery address for the P/order. If delivery Name and Address has not been supplied - will use the default Delivery address against the delivery address code supplied in the parameter Default delivery address. If the purchase order set-up option to Restrict order to single warehouse and use for delivery address has been selected ( P/order set-up - Option tab) - the warehouse address will be used instead. This is a 40 character, alpha-numeric field.
        '''</summary>
        Public Property DeliveryAddr1() As String
            Get
                Return Me.deliveryAddr1Field
            End Get
            Set
                Me.deliveryAddr1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the second line of the Delivery address for the P/order. This is a 40 character, alphanumeric field.
        '''</summary>
        Public Property DeliveryAddr2() As String
            Get
                Return Me.deliveryAddr2Field
            End Get
            Set
                Me.deliveryAddr2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the third line of the Delivery address for the P/order. This is a 40 character, alphanumeric field.
        '''</summary>
        Public Property DeliveryAddr3() As String
            Get
                Return Me.deliveryAddr3Field
            End Get
            Set
                Me.deliveryAddr3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the fourth line of the Delivery address for the P/order. This is a 40 character, alphanumeric field.
        '''</summary>
        Public Property DeliveryAddr4() As String
            Get
                Return Me.deliveryAddr4Field
            End Get
            Set
                Me.deliveryAddr4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the fifth line of the Delivery address for the P/order. This is a 40 character, alphanumeric field.
        '''</summary>
        Public Property DeliveryAddr5() As String
            Get
                Return Me.deliveryAddr5Field
            End Get
            Set
                Me.deliveryAddr5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the postal code for the delivery address for the purchase order header. This is a 9 character, alphanumeric field.
        '''</summary>
        Public Property PostalCode() As String
            Get
                Return Me.postalCodeField
            End Get
            Set
                Me.postalCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If the purchase order set-up option to Restrict order to single warehouse and use for delivery address has been selected (P/order set-up - Option tab) - then the warehouse supplied in the OrderHeader will be used for the entire order and you will not be allowed to enter/change the warehouse per P/order line. A warehouse can be supplied per P/order line if the set-up option has not been selected. You will not be allowed to change the warehouse for the entire order by supplying the new warehouse code in the OrderHeader when maintaining the order if the option to Restrict order to single warehouse has been selected.This is a 2 character, alphanumeric field. If the option to Restrict order to single warehouse has been selected then the delivery address against the warehouse will be used for the delivery address of the new P/order.
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
        '''You use the Order Discount elements to enter/change the discount percentages to be applied to the order. This element indicates if the discount should be added or subtracted from the order value. Possible values: L - less or P - Plus. Default - L.
        '''</summary>
        Public Property DiscountLessPlus() As DiscountLessPlus
            Get
                Return Me.discountLessPlusField
            End Get
            Set
                Me.discountLessPlusField = value
                Me.DiscountLessPlusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DiscountLessPlusSpecified() As Boolean
            Get
                Return Me.discountLessPlusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use the Order Discount elements to enter/change the discount percentages to be applied to the order. This element indicates the first discount percentage. This is a signed 3 integer, 2 decimal field. If this element is not supplied, or is zero, then the elements DiscPercent2 and DiscPercent3 cannot contain a value.
        '''</summary>
        Public Property DiscPercent1() As String
            Get
                Return Me.discPercent1Field
            End Get
            Set
                Me.discPercent1Field = value
            End Set
        End Property
        
        '''<summary>
        '''You use the Order Discount elements to enter/change the discount percentages to be applied to the order. This element indicates the second discount percentage. This is a signed 2 integer, 2 decimal field. If this element is not supplied, or is zero, then the element DiscPercent3 cannot contain a value.
        '''</summary>
        Public Property DiscPercent2() As String
            Get
                Return Me.discPercent2Field
            End Get
            Set
                Me.discPercent2Field = value
            End Set
        End Property
        
        '''<summary>
        '''You use the Order Discount elements to enter/change the discount percentages to be applied to the order. This element indicates the third discount percentage. This is a signed 2 integer, 2 decimal field.
        '''</summary>
        Public Property DiscPercent3() As String
            Get
                Return Me.discPercent3Field
            End Get
            Set
                Me.discPercent3Field = value
            End Set
        End Property
        
        '''<summary>
        '''The Purchase order number must be supplied if changing or cancelling the order, or when adding a new P/order and the Purchase order numbering is Manual. Please note that the P/order number must be supplied even if you are only making changes to some of the P/order lines or adding a new P/order line to an existing P/order. This is a 6 character, alphanumeric field.
        '''</summary>
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''If you selected the option: Set order status to ready to print after maintenance (Purchase Order Set-up), after maintaining an order (in status 4), the status will be reset to 1 if this element is set to Y (Yes). Only applicable when changing a P/order (action type = C). Default N (No). Possible values Y, N or spaces.
        '''</summary>
        Public Property ChgPOStatToReadyToPrint() As ChgPOStatToReadyToPrint
            Get
                Return Me.chgPOStatToReadyToPrintField
            End Get
            Set
                Me.chgPOStatToReadyToPrintField = value
                Me.ChgPOStatToReadyToPrintFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChgPOStatToReadyToPrintSpecified() As Boolean
            Get
                Return Me.chgPOStatToReadyToPrintFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderType
        
        '''<remarks/>
        L
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TaxStatus
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Orders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderHeaderField As OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDetailsField As OrderDetails
        
        Public Sub New()
            MyBase.New
            If (Me.orderDetailsField Is Nothing) Then
                Me.orderDetailsField = New OrderDetails
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New OrderHeader
            End If
        End Sub
        
        '''<summary>
        '''The element Order Header must be used to identify the start and end of the import information for the order header.
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
        '''The element Order Details must be used to identify the start and end of the import information for all the order lines for an order. This includes stocked lines, freight lines, miscellaneous lines and comment line.
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
    Partial Public Class PostPurchaseOrders
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersField As List(Of Orders)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.ordersField Is Nothing) Then
                Me.ordersField = New List(Of Orders)
            End If
        End Sub
        
        '''<summary>
        '''The element Orders must be used to identify the start and end of the import information for an order - this includes the order header and all the order detail lines.
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
                Return "PORTOI"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostPurchaseOrders
                objParams = New Params.PostPurchaseOrders
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
