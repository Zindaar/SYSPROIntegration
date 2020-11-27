Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GLAnalysis.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As QuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queryOptionsField As QueryQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glAnalysisField As QueryGlAnalysis
        
        Public Sub New()
            MyBase.New
            If (Me.glAnalysisField Is Nothing) Then
                Me.glAnalysisField = New QueryGlAnalysis
            End If
            If (Me.queryOptionsField Is Nothing) Then
                Me.queryOptionsField = New QueryQueryOptions
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New QuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As QuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property QueryOptions() As QueryQueryOptions
            Get
                Return Me.queryOptionsField
            End Get
            Set
                Me.queryOptionsField = value
            End Set
        End Property
        
        Public Property GlAnalysis() As QueryGlAnalysis
            Get
                Return Me.glAnalysisField
            End Get
            Set
                Me.glAnalysisField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As Object
        
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
        Private operatorEmailAddressField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localCurrencyDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPrdPerYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorPrimaryRoleField As Object
        
        Public Property CssStyle() As Object
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
        
        Public Property OperatorEmailAddress() As Object
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As Object
            Get
                Return Me.operatorLocationField
            End Get
            Set
                Me.operatorLocationField = value
            End Set
        End Property
        
        Public Property LocalCurrency() As String
            Get
                Return Me.localCurrencyField
            End Get
            Set
                Me.localCurrencyField = value
            End Set
        End Property
        
        Public Property LocalCurrencyDesc() As String
            Get
                Return Me.localCurrencyDescField
            End Get
            Set
                Me.localCurrencyDescField = value
            End Set
        End Property
        
        Public Property GlPrdPerYear() As String
            Get
                Return Me.glPrdPerYearField
            End Get
            Set
                Me.glPrdPerYearField = value
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
        
        Public Property OperatorPrimaryRole() As Object
            Get
                Return Me.operatorPrimaryRoleField
            End Get
            Set
                Me.operatorPrimaryRoleField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCategoryFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCategoryFilterValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisTypeFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisTypeFilterValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glGroupFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glGroupFilterValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeFilterValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodFilterValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAssetAccountsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCapitalAccountsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLiabilityAccountsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeExpenseAccountsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRevenueAccountsField As String
        
        <CLSCompliant(False)> _
        Public Property GlYear() As UShort
            Get
                Return Me.glYearField
            End Get
            Set(ByVal value As UShort)
                Me.glYearField = value
            End Set
        End Property
        
        Public Property AnalysisCategoryFilterType() As String
            Get
                Return Me.analysisCategoryFilterTypeField
            End Get
            Set
                Me.analysisCategoryFilterTypeField = value
            End Set
        End Property
        
        Public Property AnalysisCategoryFilterValue() As Object
            Get
                Return Me.analysisCategoryFilterValueField
            End Get
            Set
                Me.analysisCategoryFilterValueField = value
            End Set
        End Property
        
        Public Property AnalysisTypeFilterType() As String
            Get
                Return Me.analysisTypeFilterTypeField
            End Get
            Set
                Me.analysisTypeFilterTypeField = value
            End Set
        End Property
        
        Public Property AnalysisTypeFilterValue() As Object
            Get
                Return Me.analysisTypeFilterValueField
            End Get
            Set
                Me.analysisTypeFilterValueField = value
            End Set
        End Property
        
        Public Property GlGroupFilterType() As String
            Get
                Return Me.glGroupFilterTypeField
            End Get
            Set
                Me.glGroupFilterTypeField = value
            End Set
        End Property
        
        Public Property GlGroupFilterValue() As Object
            Get
                Return Me.glGroupFilterValueField
            End Get
            Set
                Me.glGroupFilterValueField = value
            End Set
        End Property
        
        Public Property GlCodeFilterType() As String
            Get
                Return Me.glCodeFilterTypeField
            End Get
            Set
                Me.glCodeFilterTypeField = value
            End Set
        End Property
        
        Public Property GlCodeFilterValue() As Object
            Get
                Return Me.glCodeFilterValueField
            End Get
            Set
                Me.glCodeFilterValueField = value
            End Set
        End Property
        
        Public Property GlPeriodFilterType() As String
            Get
                Return Me.glPeriodFilterTypeField
            End Get
            Set
                Me.glPeriodFilterTypeField = value
            End Set
        End Property
        
        Public Property GlPeriodFilterValue() As Object
            Get
                Return Me.glPeriodFilterValueField
            End Get
            Set
                Me.glPeriodFilterValueField = value
            End Set
        End Property
        
        Public Property IncludeAssetAccounts() As String
            Get
                Return Me.includeAssetAccountsField
            End Get
            Set
                Me.includeAssetAccountsField = value
            End Set
        End Property
        
        Public Property IncludeCapitalAccounts() As String
            Get
                Return Me.includeCapitalAccountsField
            End Get
            Set
                Me.includeCapitalAccountsField = value
            End Set
        End Property
        
        Public Property IncludeLiabilityAccounts() As String
            Get
                Return Me.includeLiabilityAccountsField
            End Get
            Set
                Me.includeLiabilityAccountsField = value
            End Set
        End Property
        
        Public Property IncludeExpenseAccounts() As String
            Get
                Return Me.includeExpenseAccountsField
            End Get
            Set
                Me.includeExpenseAccountsField = value
            End Set
        End Property
        
        Public Property IncludeRevenueAccounts() As String
            Get
                Return Me.includeRevenueAccountsField
            End Get
            Set
                Me.includeRevenueAccountsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As QueryGlAnalysisGlYear
        
        Public Sub New()
            MyBase.New
            If (Me.glYearField Is Nothing) Then
                Me.glYearField = New QueryGlAnalysisGlYear
            End If
        End Sub
        
        Public Property GlYear() As QueryGlAnalysisGlYear
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYear
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearHeaderField As QueryGlAnalysisGlYearYearHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodsField As QueryGlAnalysisGlYearGlPeriods
        
        Public Sub New()
            MyBase.New
            If (Me.glPeriodsField Is Nothing) Then
                Me.glPeriodsField = New QueryGlAnalysisGlYearGlPeriods
            End If
            If (Me.yearHeaderField Is Nothing) Then
                Me.yearHeaderField = New QueryGlAnalysisGlYearYearHeader
            End If
        End Sub
        
        Public Property YearHeader() As QueryGlAnalysisGlYearYearHeader
            Get
                Return Me.yearHeaderField
            End Get
            Set
                Me.yearHeaderField = value
            End Set
        End Property
        
        Public Property GlPeriods() As QueryGlAnalysisGlYearGlPeriods
            Get
                Return Me.glPeriodsField
            End Get
            Set
                Me.glPeriodsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYearYearHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearField As String
        
        Public Property Year() As String
            Get
                Return Me.yearField
            End Get
            Set
                Me.yearField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYearGlPeriods
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As QueryGlAnalysisGlYearGlPeriodsGlPeriod
        
        Public Sub New()
            MyBase.New
            If (Me.glPeriodField Is Nothing) Then
                Me.glPeriodField = New QueryGlAnalysisGlYearGlPeriodsGlPeriod
            End If
        End Sub
        
        Public Property GlPeriod() As QueryGlAnalysisGlYearGlPeriodsGlPeriod
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYearGlPeriodsGlPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodHeaderField As QueryGlAnalysisGlYearGlPeriodsGlPeriodPeriodHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisEntriesField As List(Of QueryGlAnalysisGlYearGlPeriodsGlPeriodAnalysisEntry)
        
        Public Sub New()
            MyBase.New
            If (Me.analysisEntriesField Is Nothing) Then
                Me.analysisEntriesField = New List(Of QueryGlAnalysisGlYearGlPeriodsGlPeriodAnalysisEntry)
            End If
            If (Me.periodHeaderField Is Nothing) Then
                Me.periodHeaderField = New QueryGlAnalysisGlYearGlPeriodsGlPeriodPeriodHeader
            End If
        End Sub
        
        Public Property PeriodHeader() As QueryGlAnalysisGlYearGlPeriodsGlPeriodPeriodHeader
            Get
                Return Me.periodHeaderField
            End Get
            Set
                Me.periodHeaderField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("AnalysisEntry", IsNullable:=false)>  _
        Public Property AnalysisEntriesCollection() As List(Of QueryGlAnalysisGlYearGlPeriodsGlPeriodAnalysisEntry)
            Get
                Return Me.analysisEntriesField
            End Get
            Set
                Me.analysisEntriesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYearGlPeriodsGlPeriodPeriodHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodField As String
        
        Public Property Period() As String
            Get
                Return Me.periodField
            End Get
            Set
                Me.periodField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryGlAnalysisGlYearGlPeriodsGlPeriodAnalysisEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCategoryDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode1DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysis1DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode2DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysis2DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode3DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysis3DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode4DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysis4DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode5DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysis5DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As Double
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property GlCodeDescription() As String
            Get
                Return Me.glCodeDescriptionField
            End Get
            Set
                Me.glCodeDescriptionField = value
            End Set
        End Property
        
        Public Property FromDate() As String
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        Public Property ToDate() As String
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
        
        Public Property AnalysisCategory() As String
            Get
                Return Me.analysisCategoryField
            End Get
            Set
                Me.analysisCategoryField = value
            End Set
        End Property
        
        Public Property AnalysisCategoryDescription() As String
            Get
                Return Me.analysisCategoryDescriptionField
            End Get
            Set
                Me.analysisCategoryDescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode1Description() As String
            Get
                Return Me.analysisCode1DescriptionField
            End Get
            Set
                Me.analysisCode1DescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set
                Me.analysisCode1Field = value
            End Set
        End Property
        
        Public Property Analysis1Description() As String
            Get
                Return Me.analysis1DescriptionField
            End Get
            Set
                Me.analysis1DescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode2Description() As String
            Get
                Return Me.analysisCode2DescriptionField
            End Get
            Set
                Me.analysisCode2DescriptionField = value
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
        
        Public Property Analysis2Description() As String
            Get
                Return Me.analysis2DescriptionField
            End Get
            Set
                Me.analysis2DescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode3Description() As String
            Get
                Return Me.analysisCode3DescriptionField
            End Get
            Set
                Me.analysisCode3DescriptionField = value
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
        
        Public Property Analysis3Description() As String
            Get
                Return Me.analysis3DescriptionField
            End Get
            Set
                Me.analysis3DescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode4Description() As String
            Get
                Return Me.analysisCode4DescriptionField
            End Get
            Set
                Me.analysisCode4DescriptionField = value
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
        
        Public Property Analysis4Description() As String
            Get
                Return Me.analysis4DescriptionField
            End Get
            Set
                Me.analysis4DescriptionField = value
            End Set
        End Property
        
        Public Property AnalysisCode5Description() As String
            Get
                Return Me.analysisCode5DescriptionField
            End Get
            Set
                Me.analysisCode5DescriptionField = value
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
        
        Public Property Analysis5Description() As String
            Get
                Return Me.analysis5DescriptionField
            End Get
            Set
                Me.analysis5DescriptionField = value
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
        
        Public Property Value() As Double
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
End Namespace
