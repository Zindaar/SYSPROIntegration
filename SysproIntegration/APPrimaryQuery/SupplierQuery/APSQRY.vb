Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace APPrimaryQuery.SupplierQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CashProjectionAtCurrentRate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeGoodsReceivedNotes
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeInvoicePayments
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeReceipts
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeRegisteredInvoices
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeRetainedInvoices
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeScrapReject
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeUnapprovedInvInCashProj
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        '''<summary>
        '''The supplier to use for the query
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInvoicesField As IncludeInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReceiptsField As IncludeReceipts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReceiptsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeScrapRejectField As IncludeScrapReject
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeScrapRejectFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUnapprovedInvInCashProjField As IncludeUnapprovedInvInCashProj
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUnapprovedInvInCashProjFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cashProjectionAtCurrentRateField As CashProjectionAtCurrentRate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cashProjectionAtCurrentRateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRetainedInvoicesField As IncludeRetainedInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRetainedInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInvoicePaymentsField As IncludeInvoicePayments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInvoicePaymentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRegisteredInvoicesField As IncludeRegisteredInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRegisteredInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGoodsReceivedNotesField As IncludeGoodsReceivedNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGoodsReceivedNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As IncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiMediaImageTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeInvoicesField = IncludeInvoices.Y
            Me.includeReceiptsField = IncludeReceipts.Y
            Me.includeScrapRejectField = IncludeScrapReject.Y
            Me.includeUnapprovedInvInCashProjField = IncludeUnapprovedInvInCashProj.N
            Me.cashProjectionAtCurrentRateField = CashProjectionAtCurrentRate.N
            Me.includeRetainedInvoicesField = IncludeRetainedInvoices.N
            Me.includeInvoicePaymentsField = IncludeInvoicePayments.N
            Me.includeRegisteredInvoicesField = IncludeRegisteredInvoices.N
            Me.includeGoodsReceivedNotesField = IncludeGoodsReceivedNotes.N
            Me.includeCustomFormsField = IncludeCustomForms.N
        End Sub
        
        '''<summary>
        '''Do you wish to include invoices? (Y - Yes, N - No) If this option is set to N, then  element 'IncludeInvoicePayments' will be ignored, and there will be no Cash Projection.
        '''</summary>
        Public Property IncludeInvoices() As IncludeInvoices
            Get
                Return Me.includeInvoicesField
            End Get
            Set
                Me.includeInvoicesField = value
                Me.IncludeInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeInvoicesSpecified() As Boolean
            Get
                Return Me.includeInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include receipts ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeReceipts() As IncludeReceipts
            Get
                Return Me.includeReceiptsField
            End Get
            Set
                Me.includeReceiptsField = value
                Me.IncludeReceiptsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeReceiptsSpecified() As Boolean
            Get
                Return Me.includeReceiptsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include scrap and reject ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeScrapReject() As IncludeScrapReject
            Get
                Return Me.includeScrapRejectField
            End Get
            Set
                Me.includeScrapRejectField = value
                Me.IncludeScrapRejectFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeScrapRejectSpecified() As Boolean
            Get
                Return Me.includeScrapRejectFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include unapproved invoices in the cash projection ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeUnapprovedInvInCashProj() As IncludeUnapprovedInvInCashProj
            Get
                Return Me.includeUnapprovedInvInCashProjField
            End Get
            Set
                Me.includeUnapprovedInvInCashProjField = value
                Me.IncludeUnapprovedInvInCashProjFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeUnapprovedInvInCashProjSpecified() As Boolean
            Get
                Return Me.includeUnapprovedInvInCashProjFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use current rate for cash projection ? (N - No, Y - Yes)
        '''</summary>
        Public Property CashProjectionAtCurrentRate() As CashProjectionAtCurrentRate
            Get
                Return Me.cashProjectionAtCurrentRateField
            End Get
            Set
                Me.cashProjectionAtCurrentRateField = value
                Me.CashProjectionAtCurrentRateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CashProjectionAtCurrentRateSpecified() As Boolean
            Get
                Return Me.cashProjectionAtCurrentRateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include retained invoices ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeRetainedInvoices() As IncludeRetainedInvoices
            Get
                Return Me.includeRetainedInvoicesField
            End Get
            Set
                Me.includeRetainedInvoicesField = value
                Me.IncludeRetainedInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeRetainedInvoicesSpecified() As Boolean
            Get
                Return Me.includeRetainedInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include invoice payments ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeInvoicePayments() As IncludeInvoicePayments
            Get
                Return Me.includeInvoicePaymentsField
            End Get
            Set
                Me.includeInvoicePaymentsField = value
                Me.IncludeInvoicePaymentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeInvoicePaymentsSpecified() As Boolean
            Get
                Return Me.includeInvoicePaymentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include registered invoices ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeRegisteredInvoices() As IncludeRegisteredInvoices
            Get
                Return Me.includeRegisteredInvoicesField
            End Get
            Set
                Me.includeRegisteredInvoicesField = value
                Me.IncludeRegisteredInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeRegisteredInvoicesSpecified() As Boolean
            Get
                Return Me.includeRegisteredInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include goods received notes ? (N - No, Y - Yes, M - Include matched goods received notes)
        '''</summary>
        Public Property IncludeGoodsReceivedNotes() As IncludeGoodsReceivedNotes
            Get
                Return Me.includeGoodsReceivedNotesField
            End Get
            Set
                Me.includeGoodsReceivedNotesField = value
                Me.IncludeGoodsReceivedNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeGoodsReceivedNotesSpecified() As Boolean
            Get
                Return Me.includeGoodsReceivedNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include fields from custom forms ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeCustomForms() As IncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
                Me.IncludeCustomFormsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCustomFormsSpecified() As Boolean
            Get
                Return Me.includeCustomFormsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Image type to retrieve (for example: GIF, JPG, BMP)
        '''</summary>
        Public Property MultiMediaImageType() As String
            Get
                Return Me.multiMediaImageTypeField
            End Get
            Set
                Me.multiMediaImageTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied
        '''</summary>
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeInvoices
        
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''The key to use for this query.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "APSQRY"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
