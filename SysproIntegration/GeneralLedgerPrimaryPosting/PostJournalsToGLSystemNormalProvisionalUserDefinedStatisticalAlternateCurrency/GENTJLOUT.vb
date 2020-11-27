Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.PostJournalsToGLSystemNormalProvisionalUserDefinedStatisticalAlternateCurrency.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class postgljournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As postgljournalItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusOfItemsField As postgljournalStatusOfItems
        
        Public Sub New()
            MyBase.New
            If (Me.statusOfItemsField Is Nothing) Then
                Me.statusOfItemsField = New postgljournalStatusOfItems
            End If
            If (Me.itemField Is Nothing) Then
                Me.itemField = New postgljournalItem
            End If
        End Sub
        
        Public Property Item() As postgljournalItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Property StatusOfItems() As postgljournalStatusOfItems
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
    Partial Public Class postgljournalItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionField As postgljournalItemTransaction
        
        Public Sub New()
            MyBase.New
            If (Me.transactionField Is Nothing) Then
                Me.transactionField = New postgljournalItemTransaction
            End If
        End Sub
        
        Public Property Transaction() As postgljournalItemTransaction
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
    Partial Public Class postgljournalItemTransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As postgljournalItemTransactionKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As Integer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfEntriesField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitAmountField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditAmountField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlPostingTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlstatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As postgljournalItemTransactionCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorisedField As String
        
        Public Sub New()
            MyBase.New
            If (Me.currencyField Is Nothing) Then
                Me.currencyField = New postgljournalItemTransactionCurrency
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New postgljournalItemTransactionKey
            End If
        End Sub
        
        Public Property Key() As postgljournalItemTransactionKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property JournalDate() As Integer
            Get
                Return Me.journalDateField
            End Get
            Set
                Me.journalDateField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property NumOfEntries() As SByte
            Get
                Return Me.numOfEntriesField
            End Get
            Set(ByVal value As SByte)
                Me.numOfEntriesField = value
            End Set
        End Property
        
        Public Property DebitAmount() As Decimal
            Get
                Return Me.debitAmountField
            End Get
            Set
                Me.debitAmountField = value
            End Set
        End Property
        
        Public Property CreditAmount() As Decimal
            Get
                Return Me.creditAmountField
            End Get
            Set
                Me.creditAmountField = value
            End Set
        End Property
        
        Public Property JnlPostingType() As String
            Get
                Return Me.jnlPostingTypeField
            End Get
            Set
                Me.jnlPostingTypeField = value
            End Set
        End Property
        
        Public Property Jnlstatus() As String
            Get
                Return Me.jnlstatusField
            End Get
            Set
                Me.jnlstatusField = value
            End Set
        End Property
        
        Public Property Currency() As postgljournalItemTransactionCurrency
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property Authorised() As String
            Get
                Return Me.authorisedField
            End Get
            Set
                Me.authorisedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postgljournalItemTransactionKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glJournalField As SByte
        
        Public Property GlYear() As Short
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property GlPeriod() As SByte
            Get
                Return Me.glPeriodField
            End Get
            Set(ByVal value As SByte)
                Me.glPeriodField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property GlJournal() As SByte
            Get
                Return Me.glJournalField
            End Get
            Set(ByVal value As SByte)
                Me.glJournalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postgljournalItemTransactionCurrency
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postgljournalStatusOfItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalsProcessedField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingsProcessedField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingsInvalidField As postgljournalStatusOfItemsPostingsInvalid
        
        Public Sub New()
            MyBase.New
            If (Me.postingsInvalidField Is Nothing) Then
                Me.postingsInvalidField = New postgljournalStatusOfItemsPostingsInvalid
            End If
        End Sub
        
        Public Property JournalsProcessed() As Boolean
            Get
                Return Me.journalsProcessedField
            End Get
            Set
                Me.journalsProcessedField = value
            End Set
        End Property
        
        Public Property PostingsProcessed() As Boolean
            Get
                Return Me.postingsProcessedField
            End Get
            Set
                Me.postingsProcessedField = value
            End Set
        End Property
        
        Public Property PostingsInvalid() As postgljournalStatusOfItemsPostingsInvalid
            Get
                Return Me.postingsInvalidField
            End Get
            Set
                Me.postingsInvalidField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postgljournalStatusOfItemsPostingsInvalid
    End Class
End Namespace
