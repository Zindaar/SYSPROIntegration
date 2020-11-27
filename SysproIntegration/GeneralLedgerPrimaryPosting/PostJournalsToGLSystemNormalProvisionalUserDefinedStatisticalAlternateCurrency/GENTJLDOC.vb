Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.PostJournalsToGLSystemNormalProvisionalUserDefinedStatisticalAlternateCurrency.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostGlJournal
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostGlJournalItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostGlJournalParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostGlJournalItem
            End If
        End Sub
        
        Public Property Item() As PostGlJournalItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "GENTJL"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostGlJournalParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostGlJournalParameters
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
                Dim objParams As Params.PostGlJournal
                objParams = New Params.PostGlJournal
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlJournalItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalTypeField As PostGlJournalItemJournalType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorizeJournalField As PostGlJournalItemAuthorizeJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorizeJournalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postJournalField As PostGlJournalItemPostJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postJournalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelJournalField As PostGlJournalItemCancelJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelJournalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdJournalField As PostGlJournalItemHoldJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdJournalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private esignatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private auditorsPasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalDetailsCollectionField As List(Of PostGlJournalItemJournalDetails)
        
        Public Sub New()
            MyBase.New
            If (Me.journalDetailsCollectionField Is Nothing) Then
                Me.journalDetailsCollectionField = New List(Of PostGlJournalItemJournalDetails)
            End If
        End Sub
        
        Public Property JournalType() As PostGlJournalItemJournalType
            Get
                Return Me.journalTypeField
            End Get
            Set
                Me.journalTypeField = value
                Me.JournalTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property JournalTypeSpecified() As Boolean
            Get
                Return Me.journalTypeFieldSpecified
            End Get
        End Property
        
        Public Property JournalNumber() As String
            Get
                Return Me.journalNumberField
            End Get
            Set
                Me.journalNumberField = value
            End Set
        End Property
        
        Public Property AuthorizeJournal() As PostGlJournalItemAuthorizeJournal
            Get
                Return Me.authorizeJournalField
            End Get
            Set
                Me.authorizeJournalField = value
                Me.AuthorizeJournalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AuthorizeJournalSpecified() As Boolean
            Get
                Return Me.authorizeJournalFieldSpecified
            End Get
        End Property
        
        Public Property PostJournal() As PostGlJournalItemPostJournal
            Get
                Return Me.postJournalField
            End Get
            Set
                Me.postJournalField = value
                Me.PostJournalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PostJournalSpecified() As Boolean
            Get
                Return Me.postJournalFieldSpecified
            End Get
        End Property
        
        Public Property CancelJournal() As PostGlJournalItemCancelJournal
            Get
                Return Me.cancelJournalField
            End Get
            Set
                Me.cancelJournalField = value
                Me.CancelJournalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CancelJournalSpecified() As Boolean
            Get
                Return Me.cancelJournalFieldSpecified
            End Get
        End Property
        
        Public Property HoldJournal() As PostGlJournalItemHoldJournal
            Get
                Return Me.holdJournalField
            End Get
            Set
                Me.holdJournalField = value
                Me.HoldJournalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property HoldJournalSpecified() As Boolean
            Get
                Return Me.holdJournalFieldSpecified
            End Get
        End Property
        
        Public Property JournalDate() As String
            Get
                Return Me.journalDateField
            End Get
            Set
                Me.journalDateField = value
            End Set
        End Property
        
        Public Property JournalReference() As String
            Get
                Return Me.journalReferenceField
            End Get
            Set
                Me.journalReferenceField = value
            End Set
        End Property
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        Public Property PostingPeriod() As String
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        Public Property PostingYear() As String
            Get
                Return Me.postingYearField
            End Get
            Set
                Me.postingYearField = value
            End Set
        End Property
        
        Public Property esignature() As String
            Get
                Return Me.esignatureField
            End Get
            Set
                Me.esignatureField = value
            End Set
        End Property
        
        Public Property SourceCode() As String
            Get
                Return Me.sourceCodeField
            End Get
            Set
                Me.sourceCodeField = value
            End Set
        End Property
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property AuditorsPassword() As String
            Get
                Return Me.auditorsPasswordField
            End Get
            Set
                Me.auditorsPasswordField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("JournalDetails")> _
        Public Property JournalDetailsCollection() As List(Of PostGlJournalItemJournalDetails)
            Get
                Return Me.journalDetailsCollectionField
            End Get
            Set(ByVal value As List(Of PostGlJournalItemJournalDetails))
                Me.journalDetailsCollectionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemJournalType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
        
        '''<remarks/>
        U
        
        '''<remarks/>
        S
        
        '''<remarks/>
        L
        
        '''<remarks/>
        A
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemAuthorizeJournal
        
        '''<remarks/>
        D
        
        '''<remarks/>
        A
        
        '''<remarks/>
        U
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemPostJournal
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemCancelJournal
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemHoldJournal
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlJournalItemJournalDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodePasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteEntryField As PostGlJournalItemJournalDetailsDeleteEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteEntryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyDetailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyDebitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyDebitPassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyCreditField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyCreditPassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisLineEntryField As PostGlJournalItemJournalDetailsAnalysisLineEntry
        
        Public Sub New()
            MyBase.New
            If (Me.analysisLineEntryField Is Nothing) Then
                Me.analysisLineEntryField = New PostGlJournalItemJournalDetailsAnalysisLineEntry
            End If
        End Sub
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        Public Property LedgerCodePassword() As String
            Get
                Return Me.ledgerCodePasswordField
            End Get
            Set
                Me.ledgerCodePasswordField = value
            End Set
        End Property
        
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set
                Me.entryAmountField = value
            End Set
        End Property
        
        Public Property DeleteEntry() As PostGlJournalItemJournalDetailsDeleteEntry
            Get
                Return Me.deleteEntryField
            End Get
            Set
                Me.deleteEntryField = value
                Me.DeleteEntryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DeleteEntrySpecified() As Boolean
            Get
                Return Me.deleteEntryFieldSpecified
            End Get
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property AnalysisEntry() As String
            Get
                Return Me.analysisEntryField
            End Get
            Set
                Me.analysisEntryField = value
            End Set
        End Property
        
        Public Property InterCompanyDetail() As String
            Get
                Return Me.interCompanyDetailField
            End Get
            Set
                Me.interCompanyDetailField = value
            End Set
        End Property
        
        Public Property InterCompanyId() As String
            Get
                Return Me.interCompanyIdField
            End Get
            Set
                Me.interCompanyIdField = value
            End Set
        End Property
        
        Public Property InterCompanyDebit() As String
            Get
                Return Me.interCompanyDebitField
            End Get
            Set
                Me.interCompanyDebitField = value
            End Set
        End Property
        
        Public Property InterCompanyDebitPass() As String
            Get
                Return Me.interCompanyDebitPassField
            End Get
            Set
                Me.interCompanyDebitPassField = value
            End Set
        End Property
        
        Public Property InterCompanyCredit() As String
            Get
                Return Me.interCompanyCreditField
            End Get
            Set
                Me.interCompanyCreditField = value
            End Set
        End Property
        
        Public Property InterCompanyCreditPass() As String
            Get
                Return Me.interCompanyCreditPassField
            End Get
            Set
                Me.interCompanyCreditPassField = value
            End Set
        End Property
        
        Public Property AnalysisLineEntry() As PostGlJournalItemJournalDetailsAnalysisLineEntry
            Get
                Return Me.analysisLineEntryField
            End Get
            Set
                Me.analysisLineEntryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalItemJournalDetailsDeleteEntry
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlJournalItemJournalDetailsAnalysisLineEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set
                Me.analysisCode1Field = value
            End Set
        End Property
        
        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set
                Me.analysisCode2Field = value
            End Set
        End Property
        
        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set
                Me.analysisCode3Field = value
            End Set
        End Property
        
        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set
                Me.analysisCode4Field = value
            End Set
        End Property
        
        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set
                Me.analysisCode5Field = value
            End Set
        End Property
        
        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = value
            End Set
        End Property
        
        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = value
            End Set
        End Property
        
        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set
                Me.entryAmountField = value
            End Set
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
    End Class
End Namespace
