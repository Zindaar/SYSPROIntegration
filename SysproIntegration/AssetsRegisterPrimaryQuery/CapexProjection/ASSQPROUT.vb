Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryQuery.CapexProjection.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CapexProjectionReport
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As CapexProjectionReportSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queryOptionsField As CapexProjectionReportQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemsField As CapexProjectionReportCapexItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsField As CapexProjectionReportBranchTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsField As CapexProjectionReportBranchCcTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsField As CapexProjectionReportGroupTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsField As CapexProjectionReportClassificationTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsField As CapexProjectionReportTypeTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsField As CapexProjectionReportYearFinalTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsField As CapexProjectionReportCompanyTotals
        
        Public Sub New()
            MyBase.New
            If (Me.companyTotalsField Is Nothing) Then
                Me.companyTotalsField = New CapexProjectionReportCompanyTotals
            End If
            If (Me.yearFinalTotalsField Is Nothing) Then
                Me.yearFinalTotalsField = New CapexProjectionReportYearFinalTotals
            End If
            If (Me.typeTotalsField Is Nothing) Then
                Me.typeTotalsField = New CapexProjectionReportTypeTotals
            End If
            If (Me.classificationTotalsField Is Nothing) Then
                Me.classificationTotalsField = New CapexProjectionReportClassificationTotals
            End If
            If (Me.groupTotalsField Is Nothing) Then
                Me.groupTotalsField = New CapexProjectionReportGroupTotals
            End If
            If (Me.branchCcTotalsField Is Nothing) Then
                Me.branchCcTotalsField = New CapexProjectionReportBranchCcTotals
            End If
            If (Me.branchTotalsField Is Nothing) Then
                Me.branchTotalsField = New CapexProjectionReportBranchTotals
            End If
            If (Me.capexItemsField Is Nothing) Then
                Me.capexItemsField = New CapexProjectionReportCapexItems
            End If
            If (Me.queryOptionsField Is Nothing) Then
                Me.queryOptionsField = New CapexProjectionReportQueryOptions
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New CapexProjectionReportSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As CapexProjectionReportSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property QueryOptions() As CapexProjectionReportQueryOptions
            Get
                Return Me.queryOptionsField
            End Get
            Set
                Me.queryOptionsField = value
            End Set
        End Property
        
        Public Property CapexItems() As CapexProjectionReportCapexItems
            Get
                Return Me.capexItemsField
            End Get
            Set
                Me.capexItemsField = value
            End Set
        End Property
        
        Public Property BranchTotals() As CapexProjectionReportBranchTotals
            Get
                Return Me.branchTotalsField
            End Get
            Set
                Me.branchTotalsField = value
            End Set
        End Property
        
        Public Property BranchCcTotals() As CapexProjectionReportBranchCcTotals
            Get
                Return Me.branchCcTotalsField
            End Get
            Set
                Me.branchCcTotalsField = value
            End Set
        End Property
        
        Public Property GroupTotals() As CapexProjectionReportGroupTotals
            Get
                Return Me.groupTotalsField
            End Get
            Set
                Me.groupTotalsField = value
            End Set
        End Property
        
        Public Property ClassificationTotals() As CapexProjectionReportClassificationTotals
            Get
                Return Me.classificationTotalsField
            End Get
            Set
                Me.classificationTotalsField = value
            End Set
        End Property
        
        Public Property TypeTotals() As CapexProjectionReportTypeTotals
            Get
                Return Me.typeTotalsField
            End Get
            Set
                Me.typeTotalsField = value
            End Set
        End Property
        
        Public Property YearFinalTotals() As CapexProjectionReportYearFinalTotals
            Get
                Return Me.yearFinalTotalsField
            End Get
            Set
                Me.yearFinalTotalsField = value
            End Set
        End Property
        
        Public Property CompanyTotals() As CapexProjectionReportCompanyTotals
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
    Partial Public Class CapexProjectionReportSystemInformation
        
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
    Partial Public Class CapexProjectionReportQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportSequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useItemFieldsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNoLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeClosedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDeniedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineFilterValueField As String
        
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
        Private capexTypeFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexTypeFilterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCodeFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCodeFilterValueField As String
        
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
        
        Public Property UseItemFields() As String
            Get
                Return Me.useItemFieldsField
            End Get
            Set
                Me.useItemFieldsField = value
            End Set
        End Property
        
        Public Property IncludeNoLines() As String
            Get
                Return Me.includeNoLinesField
            End Get
            Set
                Me.includeNoLinesField = value
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
        
        Public Property PrintLines() As String
            Get
                Return Me.printLinesField
            End Get
            Set
                Me.printLinesField = value
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
        
        Public Property CapexLineFilterType() As String
            Get
                Return Me.capexLineFilterTypeField
            End Get
            Set
                Me.capexLineFilterTypeField = value
            End Set
        End Property
        
        Public Property CapexLineFilterValue() As String
            Get
                Return Me.capexLineFilterValueField
            End Get
            Set
                Me.capexLineFilterValueField = value
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
        
        Public Property CapexTypeFilterType() As String
            Get
                Return Me.capexTypeFilterTypeField
            End Get
            Set
                Me.capexTypeFilterTypeField = value
            End Set
        End Property
        
        Public Property CapexTypeFilterValue() As String
            Get
                Return Me.capexTypeFilterValueField
            End Get
            Set
                Me.capexTypeFilterValueField = value
            End Set
        End Property
        
        Public Property AssetCodeFilterType() As String
            Get
                Return Me.assetCodeFilterTypeField
            End Get
            Set
                Me.assetCodeFilterTypeField = value
            End Set
        End Property
        
        Public Property AssetCodeFilterValue() As String
            Get
                Return Me.assetCodeFilterValueField
            End Get
            Set
                Me.assetCodeFilterValueField = value
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
    Partial Public Class CapexProjectionReportCapexItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemField As CapexProjectionReportCapexItemsCapexItem
        
        Public Sub New()
            MyBase.New
            If (Me.capexItemField Is Nothing) Then
                Me.capexItemField = New CapexProjectionReportCapexItemsCapexItem
            End If
        End Sub
        
        Public Property CapexItem() As CapexProjectionReportCapexItemsCapexItem
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
    Partial Public Class CapexProjectionReportCapexItemsCapexItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexHeaderField As List(Of CapexProjectionReportCapexItemsCapexItemCapexHeader)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLinesField As List(Of CapexProjectionReportCapexItemsCapexItemCapexLinesCapexLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsField As List(Of CapexProjectionReportCapexItemsCapexItemYearTotals)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsField As List(Of CapexProjectionReportCapexItemsCapexItemCapexItemTotals)
        
        Public Sub New()
            MyBase.New
            If (Me.capexItemTotalsField Is Nothing) Then
                Me.capexItemTotalsField = New List(Of CapexProjectionReportCapexItemsCapexItemCapexItemTotals)
            End If
            If (Me.yearTotalsField Is Nothing) Then
                Me.yearTotalsField = New List(Of CapexProjectionReportCapexItemsCapexItemYearTotals)
            End If
            If (Me.capexLinesField Is Nothing) Then
                Me.capexLinesField = New List(Of CapexProjectionReportCapexItemsCapexItemCapexLinesCapexLine)
            End If
            If (Me.capexHeaderField Is Nothing) Then
                Me.capexHeaderField = New List(Of CapexProjectionReportCapexItemsCapexItemCapexHeader)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("CapexHeader")>  _
        Public Property CapexHeaderCollection() As List(Of CapexProjectionReportCapexItemsCapexItemCapexHeader)
            Get
                Return Me.capexHeaderField
            End Get
            Set
                Me.capexHeaderField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("CapexLine", GetType(CapexProjectionReportCapexItemsCapexItemCapexLinesCapexLine), IsNullable:=false)>  _
        Public Property CapexLinesCollection() As List(Of CapexProjectionReportCapexItemsCapexItemCapexLinesCapexLine)
            Get
                Return Me.capexLinesField
            End Get
            Set
                Me.capexLinesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("YearTotals")>  _
        Public Property YearTotalsCollection() As List(Of CapexProjectionReportCapexItemsCapexItemYearTotals)
            Get
                Return Me.yearTotalsField
            End Get
            Set
                Me.yearTotalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CapexItemTotals")>  _
        Public Property CapexItemTotalsCollection() As List(Of CapexProjectionReportCapexItemsCapexItemCapexItemTotals)
            Get
                Return Me.capexItemTotalsField
            End Get
            Set
                Me.capexItemTotalsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportCapexItemsCapexItemCapexHeader
        
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
        Private valueNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueUncommittedField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueCommittedField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueAvailableField As Double
        
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
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexNextLineField As String
        
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
            End Set
        End Property
        
        Public Property ValueNotAuth() As Double
            Get
                Return Me.valueNotAuthField
            End Get
            Set
                Me.valueNotAuthField = value
            End Set
        End Property
        
        Public Property ValueUncommitted() As Double
            Get
                Return Me.valueUncommittedField
            End Get
            Set
                Me.valueUncommittedField = value
            End Set
        End Property
        
        Public Property ValueCommitted() As Double
            Get
                Return Me.valueCommittedField
            End Get
            Set
                Me.valueCommittedField = value
            End Set
        End Property
        
        Public Property ValueSpent() As Double
            Get
                Return Me.valueSpentField
            End Get
            Set
                Me.valueSpentField = value
            End Set
        End Property
        
        Public Property ValueAvailable() As Double
            Get
                Return Me.valueAvailableField
            End Get
            Set
                Me.valueAvailableField = value
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
        
        Public Property CapexNextLine() As String
            Get
                Return Me.capexNextLineField
            End Get
            Set
                Me.capexNextLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportCapexItemsCapexItemCapexLinesCapexLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineCapexCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineAssetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSBRN_CapexLineDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineAssetCostCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSCCE_CapexLineDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineAssetGroupCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSGRP_CapexLineDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aSSCTP_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineSystemDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineApprovalStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineOperatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineOperApprovedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineDateApprovedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastRequisitionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPurchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastGrnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPartBillingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineStartPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQtyField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQtyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplier2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCost2Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCost2FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQty2Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQty2FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uom2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRate2Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRate2FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currency2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDiv2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplier3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCost3Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCost3FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQty3Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQty3FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uom3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRate3Field As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRate3FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currency3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDiv3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueNotAuthFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueAuthUncommFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueCommittedField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueCommittedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueSpentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineValueTotalFieldSpecified As Boolean
        
        Public Property CapexLineCapexCode() As String
            Get
                Return Me.capexLineCapexCodeField
            End Get
            Set
                Me.capexLineCapexCodeField = value
            End Set
        End Property
        
        Public Property CapexLineNumber() As String
            Get
                Return Me.capexLineNumberField
            End Get
            Set
                Me.capexLineNumberField = value
            End Set
        End Property
        
        Public Property CapexLineAsset() As String
            Get
                Return Me.capexLineAssetField
            End Get
            Set
                Me.capexLineAssetField = value
            End Set
        End Property
        
        Public Property CapexLineDescription() As String
            Get
                Return Me.capexLineDescriptionField
            End Get
            Set
                Me.capexLineDescriptionField = value
            End Set
        End Property
        
        Public Property CapexLineBranch() As String
            Get
                Return Me.capexLineBranchField
            End Get
            Set
                Me.capexLineBranchField = value
            End Set
        End Property
        
        Public Property ASSBRN_CapexLineDescription() As String
            Get
                Return Me.aSSBRN_CapexLineDescriptionField
            End Get
            Set
                Me.aSSBRN_CapexLineDescriptionField = value
            End Set
        End Property
        
        Public Property CapexLineAssetCostCenter() As String
            Get
                Return Me.capexLineAssetCostCenterField
            End Get
            Set
                Me.capexLineAssetCostCenterField = value
            End Set
        End Property
        
        Public Property ASSCCE_CapexLineDescription() As String
            Get
                Return Me.aSSCCE_CapexLineDescriptionField
            End Get
            Set
                Me.aSSCCE_CapexLineDescriptionField = value
            End Set
        End Property
        
        Public Property CapexLineAssetGroupCode() As String
            Get
                Return Me.capexLineAssetGroupCodeField
            End Get
            Set
                Me.capexLineAssetGroupCodeField = value
            End Set
        End Property
        
        Public Property ASSGRP_CapexLineDescription() As String
            Get
                Return Me.aSSGRP_CapexLineDescriptionField
            End Get
            Set
                Me.aSSGRP_CapexLineDescriptionField = value
            End Set
        End Property
        
        Public Property CapexType() As String
            Get
                Return Me.capexTypeField
            End Get
            Set
                Me.capexTypeField = value
            End Set
        End Property
        
        Public Property ASSCTP_Description() As String
            Get
                Return Me.aSSCTP_DescriptionField
            End Get
            Set
                Me.aSSCTP_DescriptionField = value
            End Set
        End Property
        
        Public Property CapexLineReference() As String
            Get
                Return Me.capexLineReferenceField
            End Get
            Set
                Me.capexLineReferenceField = value
            End Set
        End Property
        
        Public Property CapexLineSystemDate() As String
            Get
                Return Me.capexLineSystemDateField
            End Get
            Set
                Me.capexLineSystemDateField = value
            End Set
        End Property
        
        Public Property CapexLineApprovalStatus() As String
            Get
                Return Me.capexLineApprovalStatusField
            End Get
            Set
                Me.capexLineApprovalStatusField = value
            End Set
        End Property
        
        Public Property CapexLineOperator() As String
            Get
                Return Me.capexLineOperatorField
            End Get
            Set
                Me.capexLineOperatorField = value
            End Set
        End Property
        
        Public Property CapexLineOperApproved() As String
            Get
                Return Me.capexLineOperApprovedField
            End Get
            Set
                Me.capexLineOperApprovedField = value
            End Set
        End Property
        
        Public Property CapexLineDateApproved() As String
            Get
                Return Me.capexLineDateApprovedField
            End Get
            Set
                Me.capexLineDateApprovedField = value
            End Set
        End Property
        
        Public Property LastRequisition() As String
            Get
                Return Me.lastRequisitionField
            End Get
            Set
                Me.lastRequisitionField = value
            End Set
        End Property
        
        Public Property LastPurchaseOrder() As String
            Get
                Return Me.lastPurchaseOrderField
            End Get
            Set
                Me.lastPurchaseOrderField = value
            End Set
        End Property
        
        Public Property LastJob() As String
            Get
                Return Me.lastJobField
            End Get
            Set
                Me.lastJobField = value
            End Set
        End Property
        
        Public Property LastGrn() As String
            Get
                Return Me.lastGrnField
            End Get
            Set
                Me.lastGrnField = value
            End Set
        End Property
        
        Public Property LastPartBilling() As String
            Get
                Return Me.lastPartBillingField
            End Get
            Set
                Me.lastPartBillingField = value
            End Set
        End Property
        
        Public Property Originator() As String
            Get
                Return Me.originatorField
            End Get
            Set
                Me.originatorField = value
            End Set
        End Property
        
        Public Property CapexLineStartPeriod() As String
            Get
                Return Me.capexLineStartPeriodField
            End Get
            Set
                Me.capexLineStartPeriodField = value
            End Set
        End Property
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property UnitCost() As Double
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
                Me.UnitCostFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UnitCostSpecified() As Boolean
            Get
                Return Me.unitCostFieldSpecified
            End Get
        End Property
        
        Public Property AssetQty() As Double
            Get
                Return Me.assetQtyField
            End Get
            Set
                Me.assetQtyField = value
                Me.AssetQtyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AssetQtySpecified() As Boolean
            Get
                Return Me.assetQtyFieldSpecified
            End Get
        End Property
        
        Public Property Uom() As String
            Get
                Return Me.uomField
            End Get
            Set
                Me.uomField = value
            End Set
        End Property
        
        Public Property ExchangeRate() As Double
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
                Me.ExchangeRateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExchangeRateSpecified() As Boolean
            Get
                Return Me.exchangeRateFieldSpecified
            End Get
        End Property
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property MulDiv() As String
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
            End Set
        End Property
        
        Public Property Supplier2() As String
            Get
                Return Me.supplier2Field
            End Get
            Set
                Me.supplier2Field = value
            End Set
        End Property
        
        Public Property UnitCost2() As Double
            Get
                Return Me.unitCost2Field
            End Get
            Set
                Me.unitCost2Field = value
                Me.UnitCost2FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UnitCost2Specified() As Boolean
            Get
                Return Me.unitCost2FieldSpecified
            End Get
        End Property
        
        Public Property AssetQty2() As Double
            Get
                Return Me.assetQty2Field
            End Get
            Set
                Me.assetQty2Field = value
                Me.AssetQty2FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AssetQty2Specified() As Boolean
            Get
                Return Me.assetQty2FieldSpecified
            End Get
        End Property
        
        Public Property Uom2() As String
            Get
                Return Me.uom2Field
            End Get
            Set
                Me.uom2Field = value
            End Set
        End Property
        
        Public Property ExchangeRate2() As Double
            Get
                Return Me.exchangeRate2Field
            End Get
            Set
                Me.exchangeRate2Field = value
                Me.ExchangeRate2FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExchangeRate2Specified() As Boolean
            Get
                Return Me.exchangeRate2FieldSpecified
            End Get
        End Property
        
        Public Property Currency2() As String
            Get
                Return Me.currency2Field
            End Get
            Set
                Me.currency2Field = value
            End Set
        End Property
        
        Public Property MulDiv2() As String
            Get
                Return Me.mulDiv2Field
            End Get
            Set
                Me.mulDiv2Field = value
            End Set
        End Property
        
        Public Property Supplier3() As String
            Get
                Return Me.supplier3Field
            End Get
            Set
                Me.supplier3Field = value
            End Set
        End Property
        
        Public Property UnitCost3() As Double
            Get
                Return Me.unitCost3Field
            End Get
            Set
                Me.unitCost3Field = value
                Me.UnitCost3FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UnitCost3Specified() As Boolean
            Get
                Return Me.unitCost3FieldSpecified
            End Get
        End Property
        
        Public Property AssetQty3() As Double
            Get
                Return Me.assetQty3Field
            End Get
            Set
                Me.assetQty3Field = value
                Me.AssetQty3FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AssetQty3Specified() As Boolean
            Get
                Return Me.assetQty3FieldSpecified
            End Get
        End Property
        
        Public Property Uom3() As String
            Get
                Return Me.uom3Field
            End Get
            Set
                Me.uom3Field = value
            End Set
        End Property
        
        Public Property ExchangeRate3() As Double
            Get
                Return Me.exchangeRate3Field
            End Get
            Set
                Me.exchangeRate3Field = value
                Me.ExchangeRate3FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExchangeRate3Specified() As Boolean
            Get
                Return Me.exchangeRate3FieldSpecified
            End Get
        End Property
        
        Public Property Currency3() As String
            Get
                Return Me.currency3Field
            End Get
            Set
                Me.currency3Field = value
            End Set
        End Property
        
        Public Property MulDiv3() As String
            Get
                Return Me.mulDiv3Field
            End Get
            Set
                Me.mulDiv3Field = value
            End Set
        End Property
        
        Public Property CapexLineValueNotAuth() As Double
            Get
                Return Me.capexLineValueNotAuthField
            End Get
            Set
                Me.capexLineValueNotAuthField = value
                Me.CapexLineValueNotAuthFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexLineValueNotAuthSpecified() As Boolean
            Get
                Return Me.capexLineValueNotAuthFieldSpecified
            End Get
        End Property
        
        Public Property CapexLineValueAuthUncomm() As Double
            Get
                Return Me.capexLineValueAuthUncommField
            End Get
            Set
                Me.capexLineValueAuthUncommField = value
                Me.CapexLineValueAuthUncommFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexLineValueAuthUncommSpecified() As Boolean
            Get
                Return Me.capexLineValueAuthUncommFieldSpecified
            End Get
        End Property
        
        Public Property CapexLineValueCommitted() As Double
            Get
                Return Me.capexLineValueCommittedField
            End Get
            Set
                Me.capexLineValueCommittedField = value
                Me.CapexLineValueCommittedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexLineValueCommittedSpecified() As Boolean
            Get
                Return Me.capexLineValueCommittedFieldSpecified
            End Get
        End Property
        
        Public Property CapexLineValueSpent() As Double
            Get
                Return Me.capexLineValueSpentField
            End Get
            Set
                Me.capexLineValueSpentField = value
                Me.CapexLineValueSpentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexLineValueSpentSpecified() As Boolean
            Get
                Return Me.capexLineValueSpentFieldSpecified
            End Get
        End Property
        
        Public Property CapexLineValueTotal() As Double
            Get
                Return Me.capexLineValueTotalField
            End Get
            Set
                Me.capexLineValueTotalField = value
                Me.CapexLineValueTotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexLineValueTotalSpecified() As Boolean
            Get
                Return Me.capexLineValueTotalFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportCapexItemsCapexItemYearTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearTotalsCountLinesField As String
        
        Public Property YearTotalsYear() As String
            Get
                Return Me.yearTotalsYearField
            End Get
            Set
                Me.yearTotalsYearField = value
            End Set
        End Property
        
        Public Property YearTotalsNotAuth() As Double
            Get
                Return Me.yearTotalsNotAuthField
            End Get
            Set
                Me.yearTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property YearTotalsAuthUncomm() As Double
            Get
                Return Me.yearTotalsAuthUncommField
            End Get
            Set
                Me.yearTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property YearTotalsComm() As Double
            Get
                Return Me.yearTotalsCommField
            End Get
            Set
                Me.yearTotalsCommField = value
            End Set
        End Property
        
        Public Property YearTotalsSpent() As Double
            Get
                Return Me.yearTotalsSpentField
            End Get
            Set
                Me.yearTotalsSpentField = value
            End Set
        End Property
        
        Public Property YearTotalsTotal() As Double
            Get
                Return Me.yearTotalsTotalField
            End Get
            Set
                Me.yearTotalsTotalField = value
            End Set
        End Property
        
        Public Property YearTotalsCountLines() As String
            Get
                Return Me.yearTotalsCountLinesField
            End Get
            Set
                Me.yearTotalsCountLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportCapexItemsCapexItemCapexItemTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsCapexCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsNotAuthFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsAuthUncommFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsCommFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsSpentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsTotalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexItemTotalsCountLinesField As String
        
        Public Property CapexItemTotalsCapexCode() As String
            Get
                Return Me.capexItemTotalsCapexCodeField
            End Get
            Set
                Me.capexItemTotalsCapexCodeField = value
            End Set
        End Property
        
        Public Property CapexItemTotalsNotAuth() As Double
            Get
                Return Me.capexItemTotalsNotAuthField
            End Get
            Set
                Me.capexItemTotalsNotAuthField = value
                Me.CapexItemTotalsNotAuthFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexItemTotalsNotAuthSpecified() As Boolean
            Get
                Return Me.capexItemTotalsNotAuthFieldSpecified
            End Get
        End Property
        
        Public Property CapexItemTotalsAuthUncomm() As Double
            Get
                Return Me.capexItemTotalsAuthUncommField
            End Get
            Set
                Me.capexItemTotalsAuthUncommField = value
                Me.CapexItemTotalsAuthUncommFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexItemTotalsAuthUncommSpecified() As Boolean
            Get
                Return Me.capexItemTotalsAuthUncommFieldSpecified
            End Get
        End Property
        
        Public Property CapexItemTotalsComm() As Double
            Get
                Return Me.capexItemTotalsCommField
            End Get
            Set
                Me.capexItemTotalsCommField = value
                Me.CapexItemTotalsCommFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexItemTotalsCommSpecified() As Boolean
            Get
                Return Me.capexItemTotalsCommFieldSpecified
            End Get
        End Property
        
        Public Property CapexItemTotalsSpent() As Double
            Get
                Return Me.capexItemTotalsSpentField
            End Get
            Set
                Me.capexItemTotalsSpentField = value
                Me.CapexItemTotalsSpentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexItemTotalsSpentSpecified() As Boolean
            Get
                Return Me.capexItemTotalsSpentFieldSpecified
            End Get
        End Property
        
        Public Property CapexItemTotalsTotal() As Double
            Get
                Return Me.capexItemTotalsTotalField
            End Get
            Set
                Me.capexItemTotalsTotalField = value
                Me.CapexItemTotalsTotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CapexItemTotalsTotalSpecified() As Boolean
            Get
                Return Me.capexItemTotalsTotalFieldSpecified
            End Get
        End Property
        
        Public Property CapexItemTotalsCountLines() As String
            Get
                Return Me.capexItemTotalsCountLinesField
            End Get
            Set
                Me.capexItemTotalsCountLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportBranchTotals
        
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
        Private branchTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsCountLinesField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchTotalsCountItemsField As Double
        
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
        
        Public Property BranchTotalsAvailable() As Double
            Get
                Return Me.branchTotalsAvailableField
            End Get
            Set
                Me.branchTotalsAvailableField = value
            End Set
        End Property
        
        Public Property BranchTotalsCountLines() As Double
            Get
                Return Me.branchTotalsCountLinesField
            End Get
            Set
                Me.branchTotalsCountLinesField = value
            End Set
        End Property
        
        Public Property BranchTotalsCountItems() As Double
            Get
                Return Me.branchTotalsCountItemsField
            End Get
            Set
                Me.branchTotalsCountItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportBranchCcTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsCcField As String
        
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
        Private branchCcTotalsCountLinesField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchCcTotalsCountItemsField As Double
        
        Public Property BranchCcTotalsBranch() As String
            Get
                Return Me.branchCcTotalsBranchField
            End Get
            Set
                Me.branchCcTotalsBranchField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsCc() As String
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
        
        Public Property BranchCcTotalsCountLines() As Double
            Get
                Return Me.branchCcTotalsCountLinesField
            End Get
            Set
                Me.branchCcTotalsCountLinesField = value
            End Set
        End Property
        
        Public Property BranchCcTotalsCountItems() As Double
            Get
                Return Me.branchCcTotalsCountItemsField
            End Get
            Set
                Me.branchCcTotalsCountItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportGroupTotals
        
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
        Private groupTotalsCountLinesField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupTotalsCountItemsField As Double
        
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
        
        Public Property GroupTotalsCountLines() As Double
            Get
                Return Me.groupTotalsCountLinesField
            End Get
            Set
                Me.groupTotalsCountLinesField = value
            End Set
        End Property
        
        Public Property GroupTotalsCountItems() As Double
            Get
                Return Me.groupTotalsCountItemsField
            End Get
            Set
                Me.groupTotalsCountItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportClassificationTotals
        
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
        Private classificationTotalsCountLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationTotalsCountItemsField As String
        
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
        
        Public Property ClassificationTotalsCountLines() As String
            Get
                Return Me.classificationTotalsCountLinesField
            End Get
            Set
                Me.classificationTotalsCountLinesField = value
            End Set
        End Property
        
        Public Property ClassificationTotalsCountItems() As String
            Get
                Return Me.classificationTotalsCountItemsField
            End Get
            Set
                Me.classificationTotalsCountItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportTypeTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeTotalsCountLinesField As String
        
        Public Property TypeTotalsType() As String
            Get
                Return Me.typeTotalsTypeField
            End Get
            Set
                Me.typeTotalsTypeField = value
            End Set
        End Property
        
        Public Property TypeTotalsNotAuth() As Double
            Get
                Return Me.typeTotalsNotAuthField
            End Get
            Set
                Me.typeTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property TypeTotalsAuthUncomm() As Double
            Get
                Return Me.typeTotalsAuthUncommField
            End Get
            Set
                Me.typeTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property TypeTotalsComm() As Double
            Get
                Return Me.typeTotalsCommField
            End Get
            Set
                Me.typeTotalsCommField = value
            End Set
        End Property
        
        Public Property TypeTotalsSpent() As Double
            Get
                Return Me.typeTotalsSpentField
            End Get
            Set
                Me.typeTotalsSpentField = value
            End Set
        End Property
        
        Public Property TypeTotalsTotal() As Double
            Get
                Return Me.typeTotalsTotalField
            End Get
            Set
                Me.typeTotalsTotalField = value
            End Set
        End Property
        
        Public Property TypeTotalsCountLines() As String
            Get
                Return Me.typeTotalsCountLinesField
            End Get
            Set
                Me.typeTotalsCountLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportYearFinalTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsNotAuthField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsAuthUncommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsCommField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsSpentField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearFinalTotalsCountLinesField As String
        
        Public Property YearFinalTotalsYear() As String
            Get
                Return Me.yearFinalTotalsYearField
            End Get
            Set
                Me.yearFinalTotalsYearField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsNotAuth() As Double
            Get
                Return Me.yearFinalTotalsNotAuthField
            End Get
            Set
                Me.yearFinalTotalsNotAuthField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsAuthUncomm() As Double
            Get
                Return Me.yearFinalTotalsAuthUncommField
            End Get
            Set
                Me.yearFinalTotalsAuthUncommField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsComm() As Double
            Get
                Return Me.yearFinalTotalsCommField
            End Get
            Set
                Me.yearFinalTotalsCommField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsSpent() As Double
            Get
                Return Me.yearFinalTotalsSpentField
            End Get
            Set
                Me.yearFinalTotalsSpentField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsTotal() As Double
            Get
                Return Me.yearFinalTotalsTotalField
            End Get
            Set
                Me.yearFinalTotalsTotalField = value
            End Set
        End Property
        
        Public Property YearFinalTotalsCountLines() As String
            Get
                Return Me.yearFinalTotalsCountLinesField
            End Get
            Set
                Me.yearFinalTotalsCountLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CapexProjectionReportCompanyTotals
        
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
        Private companyTotalsTotalField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsAvailableField As Double
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsCountLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsCountItemsField As String
        
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
        
        Public Property CompanyTotalsTotal() As Double
            Get
                Return Me.companyTotalsTotalField
            End Get
            Set
                Me.companyTotalsTotalField = value
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
        
        Public Property CompanyTotalsCountLines() As String
            Get
                Return Me.companyTotalsCountLinesField
            End Get
            Set
                Me.companyTotalsCountLinesField = value
            End Set
        End Property
        
        Public Property CompanyTotalsCountItems() As String
            Get
                Return Me.companyTotalsCountItemsField
            End Get
            Set
                Me.companyTotalsCountItemsField = value
            End Set
        End Property
    End Class
End Namespace
