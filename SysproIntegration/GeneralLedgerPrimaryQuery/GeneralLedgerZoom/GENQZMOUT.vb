Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GeneralLedgerZoom.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class LedgerQueryZoom
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As LedgerQueryZoomSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private generalLedgerJournalField As LedgerQueryZoomGeneralLedgerJournal
        
        Public Sub New()
            MyBase.New
            If (Me.generalLedgerJournalField Is Nothing) Then
                Me.generalLedgerJournalField = New LedgerQueryZoomGeneralLedgerJournal
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New LedgerQueryZoomSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As LedgerQueryZoomSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property GeneralLedgerJournal() As LedgerQueryZoomGeneralLedgerJournal
            Get
                Return Me.generalLedgerJournalField
            End Get
            Set
                Me.generalLedgerJournalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryZoomSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorEmailAddressField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set
                Me.languageField = value
            End Set
        End Property
        
        Public Property DecFormat() As String
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        Public Property DateFormat() As String
            Get
                Return Me.dateFormatField
            End Get
            Set
                Me.dateFormatField = value
            End Set
        End Property
        
        Public Property Role() As String
            Get
                Return Me.roleField
            End Get
            Set
                Me.roleField = value
            End Set
        End Property
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property CompanyId() As String
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = value
            End Set
        End Property
        
        Public Property CompanyName() As String
            Get
                Return Me.companyNameField
            End Get
            Set
                Me.companyNameField = value
            End Set
        End Property
        
        Public Property OperatorCode() As String
            Get
                Return Me.operatorCodeField
            End Get
            Set
                Me.operatorCodeField = value
            End Set
        End Property
        
        Public Property OperatorName() As String
            Get
                Return Me.operatorNameField
            End Get
            Set
                Me.operatorNameField = value
            End Set
        End Property
        
        Public Property OperatorGroup() As String
            Get
                Return Me.operatorGroupField
            End Get
            Set
                Me.operatorGroupField = value
            End Set
        End Property
        
        Public Property OperatorEmailAddress() As String
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As String
            Get
                Return Me.operatorLocationField
            End Get
            Set
                Me.operatorLocationField = value
            End Set
        End Property
        
        Public Property ReportDate() As String
            Get
                Return Me.reportDateField
            End Get
            Set
                Me.reportDateField = value
            End Set
        End Property
        
        Public Property UseSeparatorOnReports() As String
            Get
                Return Me.useSeparatorOnReportsField
            End Get
            Set
                Me.useSeparatorOnReportsField = value
            End Set
        End Property
        
        Public Property SeparatorToUse() As String
            Get
                Return Me.separatorToUseField
            End Get
            Set
                Me.separatorToUseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryZoomGeneralLedgerJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlPostingTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfEntriesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlPrintFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private auditorsPasswordInUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private generalLedgerJournalDetailField As List(Of LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail)
        
        Public Sub New()
            MyBase.New
            If (Me.generalLedgerJournalDetailField Is Nothing) Then
                Me.generalLedgerJournalDetailField = New List(Of LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail)
            End If
        End Sub
        
        Public Property GlYear() As String
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
        
        Public Property GlJournal() As String
            Get
                Return Me.glJournalField
            End Get
            Set
                Me.glJournalField = value
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
        
        Public Property JournalDate() As String
            Get
                Return Me.journalDateField
            End Get
            Set
                Me.journalDateField = value
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
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        Public Property GlPeriod() As String
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
        
        Public Property DebitAmount() As String
            Get
                Return Me.debitAmountField
            End Get
            Set
                Me.debitAmountField = value
            End Set
        End Property
        
        Public Property CreditAmount() As String
            Get
                Return Me.creditAmountField
            End Get
            Set
                Me.creditAmountField = value
            End Set
        End Property
        
        Public Property NumOfEntries() As String
            Get
                Return Me.numOfEntriesField
            End Get
            Set
                Me.numOfEntriesField = value
            End Set
        End Property
        
        Public Property Source() As String
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = value
            End Set
        End Property
        
        Public Property JnlStatus() As String
            Get
                Return Me.jnlStatusField
            End Get
            Set
                Me.jnlStatusField = value
            End Set
        End Property
        
        Public Property Currency() As Object
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property [Operator]() As String
            Get
                Return Me.operatorField
            End Get
            Set
                Me.operatorField = value
            End Set
        End Property
        
        Public Property JnlPrintFlag() As String
            Get
                Return Me.jnlPrintFlagField
            End Get
            Set
                Me.jnlPrintFlagField = value
            End Set
        End Property
        
        Public Property AuditorsPasswordInUse() As String
            Get
                Return Me.auditorsPasswordInUseField
            End Get
            Set
                Me.auditorsPasswordInUseField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("GeneralLedgerJournalDetail")>  _
        Public Property GeneralLedgerJournalDetailCollection() As List(Of LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail)
            Get
                Return Me.generalLedgerJournalDetailField
            End Get
            Set
                Me.generalLedgerJournalDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interCompanyFlagField As String
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property EntryDate() As String
            Get
                Return Me.entryDateField
            End Get
            Set
                Me.entryDateField = value
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
        
        Public Property EntryValue() As String
            Get
                Return Me.entryValueField
            End Get
            Set
                Me.entryValueField = value
            End Set
        End Property
        
        Public Property EntryType() As String
            Get
                Return Me.entryTypeField
            End Get
            Set
                Me.entryTypeField = value
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
        
        Public Property InterCompanyFlag() As String
            Get
                Return Me.interCompanyFlagField
            End Get
            Set
                Me.interCompanyFlagField = value
            End Set
        End Property
    End Class
End Namespace
