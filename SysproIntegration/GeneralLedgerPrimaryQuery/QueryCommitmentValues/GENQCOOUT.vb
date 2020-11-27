Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.QueryCommitmentValues.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GlCommitmentQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As GlCommitmentQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfCommitmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodValuesField As GlCommitmentQueryPeriodValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearToDateValuesField As GlCommitmentQueryYearToDateValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private annualValuesField As GlCommitmentQueryAnnualValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unallocatedUncommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unallocatedCommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unallocatedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private underPerBudgetflagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private underYtdBudgetflagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private underAnnBudgetflagField As String
        
        Public Sub New()
            MyBase.New
            If (Me.annualValuesField Is Nothing) Then
                Me.annualValuesField = New GlCommitmentQueryAnnualValues
            End If
            If (Me.yearToDateValuesField Is Nothing) Then
                Me.yearToDateValuesField = New GlCommitmentQueryYearToDateValues
            End If
            If (Me.periodValuesField Is Nothing) Then
                Me.periodValuesField = New GlCommitmentQueryPeriodValues
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New GlCommitmentQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As GlCommitmentQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
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
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property TypeOfCommitment() As String
            Get
                Return Me.typeOfCommitmentField
            End Get
            Set
                Me.typeOfCommitmentField = value
            End Set
        End Property
        
        Public Property CommitmentDate() As String
            Get
                Return Me.commitmentDateField
            End Get
            Set
                Me.commitmentDateField = value
            End Set
        End Property
        
        Public Property CommitmentValue() As String
            Get
                Return Me.commitmentValueField
            End Get
            Set
                Me.commitmentValueField = value
            End Set
        End Property
        
        Public Property CommitmentYear() As String
            Get
                Return Me.commitmentYearField
            End Get
            Set
                Me.commitmentYearField = value
            End Set
        End Property
        
        Public Property CommitmentPeriod() As String
            Get
                Return Me.commitmentPeriodField
            End Get
            Set
                Me.commitmentPeriodField = value
            End Set
        End Property
        
        Public Property PeriodValues() As GlCommitmentQueryPeriodValues
            Get
                Return Me.periodValuesField
            End Get
            Set
                Me.periodValuesField = value
            End Set
        End Property
        
        Public Property YearToDateValues() As GlCommitmentQueryYearToDateValues
            Get
                Return Me.yearToDateValuesField
            End Get
            Set
                Me.yearToDateValuesField = value
            End Set
        End Property
        
        Public Property AnnualValues() As GlCommitmentQueryAnnualValues
            Get
                Return Me.annualValuesField
            End Get
            Set
                Me.annualValuesField = value
            End Set
        End Property
        
        Public Property UnallocatedUncommitted() As String
            Get
                Return Me.unallocatedUncommittedField
            End Get
            Set
                Me.unallocatedUncommittedField = value
            End Set
        End Property
        
        Public Property UnallocatedCommitted() As String
            Get
                Return Me.unallocatedCommittedField
            End Get
            Set
                Me.unallocatedCommittedField = value
            End Set
        End Property
        
        Public Property UnallocatedFlag() As String
            Get
                Return Me.unallocatedFlagField
            End Get
            Set
                Me.unallocatedFlagField = value
            End Set
        End Property
        
        Public Property UnderPerBudgetflag() As String
            Get
                Return Me.underPerBudgetflagField
            End Get
            Set
                Me.underPerBudgetflagField = value
            End Set
        End Property
        
        Public Property UnderYtdBudgetflag() As String
            Get
                Return Me.underYtdBudgetflagField
            End Get
            Set
                Me.underYtdBudgetflagField = value
            End Set
        End Property
        
        Public Property UnderAnnBudgetflag() As String
            Get
                Return Me.underAnnBudgetflagField
            End Get
            Set
                Me.underAnnBudgetflagField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GlCommitmentQuerySystemInformation
        
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
    Partial Public Class GlCommitmentQueryPeriodValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommitmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableField As String
        
        Public Property Uncommitted() As String
            Get
                Return Me.uncommittedField
            End Get
            Set
                Me.uncommittedField = value
            End Set
        End Property
        
        Public Property Committed() As String
            Get
                Return Me.committedField
            End Get
            Set
                Me.committedField = value
            End Set
        End Property
        
        Public Property TotalCommitted() As String
            Get
                Return Me.totalCommittedField
            End Get
            Set
                Me.totalCommittedField = value
            End Set
        End Property
        
        Public Property Actual() As String
            Get
                Return Me.actualField
            End Get
            Set
                Me.actualField = value
            End Set
        End Property
        
        Public Property TotalCommitment() As String
            Get
                Return Me.totalCommitmentField
            End Get
            Set
                Me.totalCommitmentField = value
            End Set
        End Property
        
        Public Property Budget() As String
            Get
                Return Me.budgetField
            End Get
            Set
                Me.budgetField = value
            End Set
        End Property
        
        Public Property Available() As String
            Get
                Return Me.availableField
            End Get
            Set
                Me.availableField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GlCommitmentQueryYearToDateValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommitmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableField As String
        
        Public Property Uncommitted() As String
            Get
                Return Me.uncommittedField
            End Get
            Set
                Me.uncommittedField = value
            End Set
        End Property
        
        Public Property Committed() As String
            Get
                Return Me.committedField
            End Get
            Set
                Me.committedField = value
            End Set
        End Property
        
        Public Property TotalCommitted() As String
            Get
                Return Me.totalCommittedField
            End Get
            Set
                Me.totalCommittedField = value
            End Set
        End Property
        
        Public Property Actual() As String
            Get
                Return Me.actualField
            End Get
            Set
                Me.actualField = value
            End Set
        End Property
        
        Public Property TotalCommitment() As String
            Get
                Return Me.totalCommitmentField
            End Get
            Set
                Me.totalCommitmentField = value
            End Set
        End Property
        
        Public Property Budget() As String
            Get
                Return Me.budgetField
            End Get
            Set
                Me.budgetField = value
            End Set
        End Property
        
        Public Property Available() As String
            Get
                Return Me.availableField
            End Get
            Set
                Me.availableField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GlCommitmentQueryAnnualValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommittedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCommitmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableField As String
        
        Public Property Uncommitted() As String
            Get
                Return Me.uncommittedField
            End Get
            Set
                Me.uncommittedField = value
            End Set
        End Property
        
        Public Property Committed() As String
            Get
                Return Me.committedField
            End Get
            Set
                Me.committedField = value
            End Set
        End Property
        
        Public Property TotalCommitted() As String
            Get
                Return Me.totalCommittedField
            End Get
            Set
                Me.totalCommittedField = value
            End Set
        End Property
        
        Public Property Actual() As String
            Get
                Return Me.actualField
            End Get
            Set
                Me.actualField = value
            End Set
        End Property
        
        Public Property TotalCommitment() As String
            Get
                Return Me.totalCommitmentField
            End Get
            Set
                Me.totalCommitmentField = value
            End Set
        End Property
        
        Public Property Budget() As String
            Get
                Return Me.budgetField
            End Get
            Set
                Me.budgetField = value
            End Set
        End Property
        
        Public Property Available() As String
            Get
                Return Me.availableField
            End Get
            Set
                Me.availableField = value
            End Set
        End Property
    End Class
End Namespace
