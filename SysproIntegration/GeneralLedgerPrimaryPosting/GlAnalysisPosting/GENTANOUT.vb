Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.GlAnalysisPosting.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class postglanalysis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As postglanalysisItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusOfItemsField As postglanalysisStatusOfItems
        
        Public Sub New()
            MyBase.New
            If (Me.statusOfItemsField Is Nothing) Then
                Me.statusOfItemsField = New postglanalysisStatusOfItems
            End If
            If (Me.itemField Is Nothing) Then
                Me.itemField = New postglanalysisItem
            End If
        End Sub
        
        Public Property Item() As postglanalysisItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Property StatusOfItems() As postglanalysisStatusOfItems
            Get
                Return Me.statusOfItemsField
            End Get
            Set
                Me.statusOfItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postglanalysisItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionField As postglanalysisItemTransaction
        
        Public Sub New()
            MyBase.New
            If (Me.transactionField Is Nothing) Then
                Me.transactionField = New postglanalysisItemTransaction
            End If
        End Sub
        
        Public Property Transaction() As postglanalysisItemTransaction
            Get
                Return Me.transactionField
            End Get
            Set
                Me.transactionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postglanalysisItemTransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As postglanalysisItemTransactionKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalAmountField As Decimal
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New postglanalysisItemTransactionKey
            End If
        End Sub
        
        Public Property Key() As postglanalysisItemTransactionKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property TotalAmount() As Decimal
            Get
                Return Me.totalAmountField
            End Get
            Set
                Me.totalAmountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postglanalysisItemTransactionKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisEntryField As Short
        
        Public Property Company() As Boolean
            Get
                Return Me.companyField
            End Get
            Set
                Me.companyField = value
            End Set
        End Property
        
        Public Property GlYear() As Short
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property

#Disable Warning BC40027 ' Return type of function is not CLS-compliant
        Public Property GlPeriod() As SByte
#Enable Warning BC40027 ' Return type of function is not CLS-compliant
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
        
        Public Property AnalysisEntry() As Short
            Get
                Return Me.analysisEntryField
            End Get
            Set
                Me.analysisEntryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postglanalysisStatusOfItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entriesProcessedField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entriesInvalidField As postglanalysisStatusOfItemsEntriesInvalid
        
        Public Sub New()
            MyBase.New
            If (Me.entriesInvalidField Is Nothing) Then
                Me.entriesInvalidField = New postglanalysisStatusOfItemsEntriesInvalid
            End If
        End Sub
        
        Public Property EntriesProcessed() As Boolean
            Get
                Return Me.entriesProcessedField
            End Get
            Set
                Me.entriesProcessedField = value
            End Set
        End Property
        
        Public Property EntriesInvalid() As postglanalysisStatusOfItemsEntriesInvalid
            Get
                Return Me.entriesInvalidField
            End Get
            Set
                Me.entriesInvalidField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postglanalysisStatusOfItemsEntriesInvalid
    End Class
End Namespace
