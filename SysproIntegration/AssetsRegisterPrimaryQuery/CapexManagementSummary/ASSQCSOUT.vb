Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryQuery.CapexManagementSummary.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CapexManagementSummaryReport
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As CapexManagementSummaryReportSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queryOptionsField As CapexManagementSummaryReportQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemsField As CapexManagementSummaryReportCapexItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsField As CapexManagementSummaryReportBranchTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsField As CapexManagementSummaryReportBranchCcTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsField As CapexManagementSummaryReportGroupTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsField As CapexManagementSummaryReportClassificationTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsField As CapexManagementSummaryReportCompanyTotals
        
        Public Sub New()
            MyBase.New
            If (Me.companyTotalsField Is Nothing) Then
                Me.companyTotalsField = New CapexManagementSummaryReportCompanyTotals
            End If
            If (Me.classificationTotalsField Is Nothing) Then
                Me.classificationTotalsField = New CapexManagementSummaryReportClassificationTotals
            End If
            If (Me.groupTotalsField Is Nothing) Then
                Me.groupTotalsField = New CapexManagementSummaryReportGroupTotals
            End If
            If (Me.branchCcTotalsField Is Nothing) Then
                Me.branchCcTotalsField = New CapexManagementSummaryReportBranchCcTotals
            End If
            If (Me.branchTotalsField Is Nothing) Then
                Me.branchTotalsField = New CapexManagementSummaryReportBranchTotals
            End If
            If (Me.capexItemsField Is Nothing) Then
                Me.capexItemsField = New CapexManagementSummaryReportCapexItems
            End If
            If (Me.queryOptionsField Is Nothing) Then
                Me.queryOptionsField = New CapexManagementSummaryReportQueryOptions
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New CapexManagementSummaryReportSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As CapexManagementSummaryReportSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property QueryOptions() As CapexManagementSummaryReportQueryOptions
            Get
                Return Me.queryOptionsField
            End Get
            Set
                Me.queryOptionsField = value
            End Set
        End Property
        
        Public Property CapexItems() As CapexManagementSummaryReportCapexItems
            Get
                Return Me.capexItemsField
            End Get
            Set
                Me.capexItemsField = value
            End Set
        End Property
        
        Public Property BranchTotals() As CapexManagementSummaryReportBranchTotals
            Get
                Return Me.branchTotalsField
            End Get
            Set
                Me.branchTotalsField = value
            End Set
        End Property
        
        Public Property BranchCcTotals() As CapexManagementSummaryReportBranchCcTotals
            Get
                Return Me.branchCcTotalsField
            End Get
            Set
                Me.branchCcTotalsField = value
            End Set
        End Property
        
        Public Property GroupTotals() As CapexManagementSummaryReportGroupTotals
            Get
                Return Me.groupTotalsField
            End Get
            Set
                Me.groupTotalsField = value
            End Set
        End Property
        
        Public Property ClassificationTotals() As CapexManagementSummaryReportClassificationTotals
            Get
                Return Me.classificationTotalsField
            End Get
            Set
                Me.classificationTotalsField = value
            End Set
        End Property
        
        Public Property CompanyTotals() As CapexManagementSummaryReportCompanyTotals
            Get
                Return Me.companyTotalsField
            End Get
            Set
                Me.companyTotalsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportSystemInformation
        
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportSequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeClosedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDeniedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetGroupCodeFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetGroupCodeFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostCenterFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostCenterFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexClassFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexClassFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodFilterValueField As String
        
        Public Property ReportSequence() As String
            Get
                Return Me.reportSequenceField
            End Get
            Set
                Me.reportSequenceField = value
            End Set
        End Property
        
        Public Property IncludeClosed() As String
            Get
                Return Me.includeClosedField
            End Get
            Set
                Me.includeClosedField = value
            End Set
        End Property
        
        Public Property IncludeDenied() As String
            Get
                Return Me.includeDeniedField
            End Get
            Set
                Me.includeDeniedField = value
            End Set
        End Property
        
        Public Property CapexItemFilterType() As String
            Get
                Return Me.capexItemFilterTypeField
            End Get
            Set
                Me.capexItemFilterTypeField = value
            End Set
        End Property
        
        Public Property CapexItemFilterValue() As String
            Get
                Return Me.capexItemFilterValueField
            End Get
            Set
                Me.capexItemFilterValueField = value
            End Set
        End Property
        
        Public Property BranchFilterType() As String
            Get
                Return Me.branchFilterTypeField
            End Get
            Set
                Me.branchFilterTypeField = value
            End Set
        End Property
        
        Public Property BranchFilterValue() As String
            Get
                Return Me.branchFilterValueField
            End Get
            Set
                Me.branchFilterValueField = value
            End Set
        End Property
        
        Public Property AssetGroupCodeFilterType() As String
            Get
                Return Me.assetGroupCodeFilterTypeField
            End Get
            Set
                Me.assetGroupCodeFilterTypeField = value
            End Set
        End Property
        
        Public Property AssetGroupCodeFilterValue() As String
            Get
                Return Me.assetGroupCodeFilterValueField
            End Get
            Set
                Me.assetGroupCodeFilterValueField = value
            End Set
        End Property
        
        Public Property AssetCostCenterFilterType() As String
            Get
                Return Me.assetCostCenterFilterTypeField
            End Get
            Set
                Me.assetCostCenterFilterTypeField = value
            End Set
        End Property
        
        Public Property AssetCostCenterFilterValue() As String
            Get
                Return Me.assetCostCenterFilterValueField
            End Get
            Set
                Me.assetCostCenterFilterValueField = value
            End Set
        End Property
        
        Public Property CapexClassFilterType() As String
            Get
                Return Me.capexClassFilterTypeField
            End Get
            Set
                Me.capexClassFilterTypeField = value
            End Set
        End Property
        
        Public Property CapexClassFilterValue() As String
            Get
                Return Me.capexClassFilterValueField
            End Get
            Set
                Me.capexClassFilterValueField = value
            End Set
        End Property
        
        Public Property YearFilterType() As String
            Get
                Return Me.yearFilterTypeField
            End Get
            Set
                Me.yearFilterTypeField = value
            End Set
        End Property
        
        Public Property YearFilterValue() As String
            Get
                Return Me.yearFilterValueField
            End Get
            Set
                Me.yearFilterValueField = value
            End Set
        End Property
        
        Public Property PeriodFilterType() As String
            Get
                Return Me.periodFilterTypeField
            End Get
            Set
                Me.periodFilterTypeField = value
            End Set
        End Property
        
        Public Property PeriodFilterValue() As String
            Get
                Return Me.periodFilterValueField
            End Get
            Set
                Me.periodFilterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportCapexItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemField As CapexManagementSummaryReportCapexItemsCapexItem
        
        Public Sub New()
            MyBase.New
            If (Me.capexItemField Is Nothing) Then
                Me.capexItemField = New CapexManagementSummaryReportCapexItemsCapexItem
            End If
        End Sub
        
        Public Property CapexItem() As CapexManagementSummaryReportCapexItemsCapexItem
            Get
                Return Me.capexItemField
            End Get
            Set
                Me.capexItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportCapexItemsCapexItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexRefField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSBRN_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSCCE_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetGroupCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSGRP_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSCLS_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private approvalStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueBudgetedField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueBudgetedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueNotAuthFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueAuthUncommFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueCommittedField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueCommittedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueSpentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueAvailableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorApprovedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateApprovedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endPeriodField As String
        
        Public Property CapexCode() As String
            Get
                Return Me.capexCodeField
            End Get
            Set
                Me.capexCodeField = value
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
        
        Public Property CapexRef() As String
            Get
                Return Me.capexRefField
            End Get
            Set
                Me.capexRefField = value
            End Set
        End Property
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property ASSBRN_Description() As String
            Get
                Return Me.aSSBRN_DescriptionField
            End Get
            Set
                Me.aSSBRN_DescriptionField = value
            End Set
        End Property
        
        Public Property AssetCostCenter() As String
            Get
                Return Me.assetCostCenterField
            End Get
            Set
                Me.assetCostCenterField = value
            End Set
        End Property
        
        Public Property ASSCCE_Description() As String
            Get
                Return Me.aSSCCE_DescriptionField
            End Get
            Set
                Me.aSSCCE_DescriptionField = value
            End Set
        End Property
        
        Public Property AssetGroupCode() As String
            Get
                Return Me.assetGroupCodeField
            End Get
            Set
                Me.assetGroupCodeField = value
            End Set
        End Property
        
        Public Property ASSGRP_Description() As String
            Get
                Return Me.aSSGRP_DescriptionField
            End Get
            Set
                Me.aSSGRP_DescriptionField = value
            End Set
        End Property
        
        Public Property CapexClass() As String
            Get
                Return Me.capexClassField
            End Get
            Set
                Me.capexClassField = value
            End Set
        End Property
        
        Public Property ASSCLS_Description() As String
            Get
                Return Me.aSSCLS_DescriptionField
            End Get
            Set
                Me.aSSCLS_DescriptionField = value
            End Set
        End Property
        
        Public Property ApprovalStatus() As String
            Get
                Return Me.approvalStatusField
            End Get
            Set
                Me.approvalStatusField = value
            End Set
        End Property
        
        Public Property ValueBudgeted() As Double
            Get
                Return Me.valueBudgetedField
            End Get
            Set
                Me.valueBudgetedField = value
                Me.ValueBudgetedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueBudgetedSpecified() As Boolean
            Get
                Return Me.valueBudgetedFieldSpecified
            End Get
        End Property
        
        Public Property ValueNotAuth() As Double
            Get
                Return Me.valueNotAuthField
            End Get
            Set
                Me.valueNotAuthField = value
                Me.ValueNotAuthFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueNotAuthSpecified() As Boolean
            Get
                Return Me.valueNotAuthFieldSpecified
            End Get
        End Property
        
        Public Property ValueAuthUncomm() As Double
            Get
                Return Me.valueAuthUncommField
            End Get
            Set
                Me.valueAuthUncommField = value
                Me.ValueAuthUncommFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueAuthUncommSpecified() As Boolean
            Get
                Return Me.valueAuthUncommFieldSpecified
            End Get
        End Property
        
        Public Property ValueCommitted() As Double
            Get
                Return Me.valueCommittedField
            End Get
            Set
                Me.valueCommittedField = value
                Me.ValueCommittedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueCommittedSpecified() As Boolean
            Get
                Return Me.valueCommittedFieldSpecified
            End Get
        End Property
        
        Public Property ValueSpent() As Double
            Get
                Return Me.valueSpentField
            End Get
            Set
                Me.valueSpentField = value
                Me.ValueSpentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueSpentSpecified() As Boolean
            Get
                Return Me.valueSpentFieldSpecified
            End Get
        End Property
        
        Public Property ValueAvailable() As Double
            Get
                Return Me.valueAvailableField
            End Get
            Set
                Me.valueAvailableField = value
                Me.ValueAvailableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValueAvailableSpecified() As Boolean
            Get
                Return Me.valueAvailableFieldSpecified
            End Get
        End Property
        
        Public Property [Operator]() As String
            Get
                Return Me.operatorField
            End Get
            Set
                Me.operatorField = value
            End Set
        End Property
        
        Public Property SystemDate() As String
            Get
                Return Me.systemDateField
            End Get
            Set
                Me.systemDateField = value
            End Set
        End Property
        
        Public Property OperatorApproved() As String
            Get
                Return Me.operatorApprovedField
            End Get
            Set
                Me.operatorApprovedField = value
            End Set
        End Property
        
        Public Property DateApproved() As String
            Get
                Return Me.dateApprovedField
            End Get
            Set
                Me.dateApprovedField = value
            End Set
        End Property
        
        Public Property StartPeriod() As String
            Get
                Return Me.startPeriodField
            End Get
            Set
                Me.startPeriodField = value
            End Set
        End Property
        
        Public Property EndPeriod() As String
            Get
                Return Me.endPeriodField
            End Get
            Set
                Me.endPeriodField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportBranchTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsBudgetField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsAvailableField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsCountField As UInteger
        
        Public Property BranchTotalsBranch() As String
            Get
                Return Me.branchTotalsBranchField
            End Get
            Set
                Me.branchTotalsBranchField = value
            End Set
        End Property
        
        Public Property BranchTotalsBudget() As Double
            Get
                Return Me.branchTotalsBudgetField
            End Get
            Set
                Me.branchTotalsBudgetField = value
            End Set
        End Property
        
        Public Property BranchTotalsNotAuth() As Double
            Get
                Return Me.branchTotalsNotAuthField
            End Get
            Set
                Me.branchTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property BranchTotalsAuthUncomm() As Double
            Get
                Return Me.branchTotalsAuthUncommField
            End Get
            Set
                Me.branchTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property BranchTotalsComm() As Double
            Get
                Return Me.branchTotalsCommField
            End Get
            Set
                Me.branchTotalsCommField = value
            End Set
        End Property
        
        Public Property BranchTotalsSpent() As Double
            Get
                Return Me.branchTotalsSpentField
            End Get
            Set
                Me.branchTotalsSpentField = value
            End Set
        End Property
        
        Public Property BranchTotalsTotal() As Double
            Get
                Return Me.branchTotalsTotalField
            End Get
            Set
                Me.branchTotalsTotalField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="time")>  _
        Public Property BranchTotalsAvailable() As Date
            Get
                Return Me.branchTotalsAvailableField
            End Get
            Set
                Me.branchTotalsAvailableField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property BranchTotalsCount() As UInteger
            Get
                Return Me.branchTotalsCountField
            End Get
            Set(ByVal value As UInteger)
                Me.branchTotalsCountField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportBranchCcTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsCcField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsBudgetField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsCountField As Double
        
        Public Property BranchCcTotalsBranch() As String
            Get
                Return Me.branchCcTotalsBranchField
            End Get
            Set
                Me.branchCcTotalsBranchField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsCc() As Double
            Get
                Return Me.branchCcTotalsCcField
            End Get
            Set
                Me.branchCcTotalsCcField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsBudget() As Double
            Get
                Return Me.branchCcTotalsBudgetField
            End Get
            Set
                Me.branchCcTotalsBudgetField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsNotAuth() As Double
            Get
                Return Me.branchCcTotalsNotAuthField
            End Get
            Set
                Me.branchCcTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsAuthUncomm() As Double
            Get
                Return Me.branchCcTotalsAuthUncommField
            End Get
            Set
                Me.branchCcTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsComm() As Double
            Get
                Return Me.branchCcTotalsCommField
            End Get
            Set
                Me.branchCcTotalsCommField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsSpent() As Double
            Get
                Return Me.branchCcTotalsSpentField
            End Get
            Set
                Me.branchCcTotalsSpentField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsTotal() As Double
            Get
                Return Me.branchCcTotalsTotalField
            End Get
            Set
                Me.branchCcTotalsTotalField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsAvailable() As Double
            Get
                Return Me.branchCcTotalsAvailableField
            End Get
            Set
                Me.branchCcTotalsAvailableField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsCount() As Double
            Get
                Return Me.branchCcTotalsCountField
            End Get
            Set
                Me.branchCcTotalsCountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportGroupTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsBudgetField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsCountField As Double
        
        Public Property GroupTotalsGroup() As String
            Get
                Return Me.groupTotalsGroupField
            End Get
            Set
                Me.groupTotalsGroupField = value
            End Set
        End Property
        
        Public Property GroupTotalsBudget() As Double
            Get
                Return Me.groupTotalsBudgetField
            End Get
            Set
                Me.groupTotalsBudgetField = value
            End Set
        End Property
        
        Public Property GroupTotalsNotAuth() As Double
            Get
                Return Me.groupTotalsNotAuthField
            End Get
            Set
                Me.groupTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property GroupTotalsAuthUncomm() As Double
            Get
                Return Me.groupTotalsAuthUncommField
            End Get
            Set
                Me.groupTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property GroupTotalsComm() As Double
            Get
                Return Me.groupTotalsCommField
            End Get
            Set
                Me.groupTotalsCommField = value
            End Set
        End Property
        
        Public Property GroupTotalsSpent() As Double
            Get
                Return Me.groupTotalsSpentField
            End Get
            Set
                Me.groupTotalsSpentField = value
            End Set
        End Property
        
        Public Property GroupTotalsTotal() As Double
            Get
                Return Me.groupTotalsTotalField
            End Get
            Set
                Me.groupTotalsTotalField = value
            End Set
        End Property
        
        Public Property GroupTotalsAvailable() As Double
            Get
                Return Me.groupTotalsAvailableField
            End Get
            Set
                Me.groupTotalsAvailableField = value
            End Set
        End Property
        
        Public Property GroupTotalsCount() As Double
            Get
                Return Me.groupTotalsCountField
            End Get
            Set
                Me.groupTotalsCountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportClassificationTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsBudgetField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsCountField As Double
        
        Public Property ClassificationTotalsClass() As String
            Get
                Return Me.classificationTotalsClassField
            End Get
            Set
                Me.classificationTotalsClassField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsBudget() As Double
            Get
                Return Me.classificationTotalsBudgetField
            End Get
            Set
                Me.classificationTotalsBudgetField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsNotAuth() As Double
            Get
                Return Me.classificationTotalsNotAuthField
            End Get
            Set
                Me.classificationTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsAuthUncomm() As Double
            Get
                Return Me.classificationTotalsAuthUncommField
            End Get
            Set
                Me.classificationTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsComm() As Double
            Get
                Return Me.classificationTotalsCommField
            End Get
            Set
                Me.classificationTotalsCommField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsSpent() As Double
            Get
                Return Me.classificationTotalsSpentField
            End Get
            Set
                Me.classificationTotalsSpentField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsTotal() As Double
            Get
                Return Me.classificationTotalsTotalField
            End Get
            Set
                Me.classificationTotalsTotalField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsAvailable() As Double
            Get
                Return Me.classificationTotalsAvailableField
            End Get
            Set
                Me.classificationTotalsAvailableField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsCount() As Double
            Get
                Return Me.classificationTotalsCountField
            End Get
            Set
                Me.classificationTotalsCountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexManagementSummaryReportCompanyTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsBudgetField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsCountField As Double
        
        Public Property CompanyTotalsBudget() As Double
            Get
                Return Me.companyTotalsBudgetField
            End Get
            Set
                Me.companyTotalsBudgetField = value
            End Set
        End Property
        
        Public Property CompanyTotalsNotAuth() As Double
            Get
                Return Me.companyTotalsNotAuthField
            End Get
            Set
                Me.companyTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property CompanyTotalsAuthUncomm() As Double
            Get
                Return Me.companyTotalsAuthUncommField
            End Get
            Set
                Me.companyTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property CompanyTotalsComm() As Double
            Get
                Return Me.companyTotalsCommField
            End Get
            Set
                Me.companyTotalsCommField = value
            End Set
        End Property
        
        Public Property CompanyTotalsSpent() As Double
            Get
                Return Me.companyTotalsSpentField
            End Get
            Set
                Me.companyTotalsSpentField = value
            End Set
        End Property
        
        Public Property BranchTotalsTotal() As Double
            Get
                Return Me.branchTotalsTotalField
            End Get
            Set
                Me.branchTotalsTotalField = value
            End Set
        End Property
        
        Public Property CompanyTotalsAvailable() As Double
            Get
                Return Me.companyTotalsAvailableField
            End Get
            Set
                Me.companyTotalsAvailableField = value
            End Set
        End Property
        
        Public Property CompanyTotalsCount() As Double
            Get
                Return Me.companyTotalsCountField
            End Get
            Set
                Me.companyTotalsCountField = value
            End Set
        End Property
    End Class
End Namespace
