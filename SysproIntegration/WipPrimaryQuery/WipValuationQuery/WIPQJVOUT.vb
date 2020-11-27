Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryQuery.WipValuationQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class WipValuationQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As WipValuationQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As List(Of WipValuationQueryJob)
        
        Public Sub New()
            MyBase.New
            If (Me.jobField Is Nothing) Then
                Me.jobField = New List(Of WipValuationQueryJob)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New WipValuationQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As WipValuationQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Job")>  _
        Public Property JobCollection() As List(Of WipValuationQueryJob)
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class WipValuationQuerySystemInformation
        
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
    Partial Public Class WipValuationQueryJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private masterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iNVWHC_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyManufacturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bOMROU_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hrsBookToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labValueIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matValueIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As List(Of WipValuationQueryJobJob)
        
        Public Sub New()
            MyBase.New
            If (Me.jobField Is Nothing) Then
                Me.jobField = New List(Of WipValuationQueryJobJob)
            End If
        End Sub
        
        Public Property Master() As String
            Get
                Return Me.masterField
            End Get
            Set
                Me.masterField = value
            End Set
        End Property
        
        Public Property JobNumber() As String
            Get
                Return Me.jobNumberField
            End Get
            Set
                Me.jobNumberField = value
            End Set
        End Property
        
        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set
                Me.jobDescriptionField = value
            End Set
        End Property
        
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        Public Property ClassDescription() As String
            Get
                Return Me.classDescriptionField
            End Get
            Set
                Me.classDescriptionField = value
            End Set
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property Version() As Object
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As Object
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property INVWHC_Description() As String
            Get
                Return Me.iNVWHC_DescriptionField
            End Get
            Set
                Me.iNVWHC_DescriptionField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
        
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        Public Property Complete() As String
            Get
                Return Me.completeField
            End Get
            Set
                Me.completeField = value
            End Set
        End Property
        
        Public Property HoldFlag() As String
            Get
                Return Me.holdFlagField
            End Get
            Set
                Me.holdFlagField = value
            End Set
        End Property
        
        Public Property ExpLabour() As String
            Get
                Return Me.expLabourField
            End Get
            Set
                Me.expLabourField = value
            End Set
        End Property
        
        Public Property ExpMaterial() As String
            Get
                Return Me.expMaterialField
            End Get
            Set
                Me.expMaterialField = value
            End Set
        End Property
        
        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set
                Me.qtyToMakeField = value
            End Set
        End Property
        
        Public Property QtyManufactured() As String
            Get
                Return Me.qtyManufacturedField
            End Get
            Set
                Me.qtyManufacturedField = value
            End Set
        End Property
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        Public Property BOMROU_Description() As String
            Get
                Return Me.bOMROU_DescriptionField
            End Get
            Set
                Me.bOMROU_DescriptionField = value
            End Set
        End Property
        
        Public Property ConfirmedFlag() As String
            Get
                Return Me.confirmedFlagField
            End Get
            Set
                Me.confirmedFlagField = value
            End Set
        End Property
        
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        Public Property HrsBookToDate() As String
            Get
                Return Me.hrsBookToDateField
            End Get
            Set
                Me.hrsBookToDateField = value
            End Set
        End Property
        
        Public Property LabCostToDate() As String
            Get
                Return Me.labCostToDateField
            End Get
            Set
                Me.labCostToDateField = value
            End Set
        End Property
        
        Public Property MatCostToDate() As String
            Get
                Return Me.matCostToDateField
            End Get
            Set
                Me.matCostToDateField = value
            End Set
        End Property
        
        Public Property LabValueIssues() As String
            Get
                Return Me.labValueIssuesField
            End Get
            Set
                Me.labValueIssuesField = value
            End Set
        End Property
        
        Public Property MatValueIssues() As String
            Get
                Return Me.matValueIssuesField
            End Get
            Set
                Me.matValueIssuesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Job")>  _
        Public Property JobCollection() As List(Of WipValuationQueryJobJob)
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class WipValuationQueryJobJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private masterSubField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iNVWHC_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyManufacturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bOMROU_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hrsBookToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labValueIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matValueIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As WipValuationQueryJobJobJob
        
        Public Sub New()
            MyBase.New
            If (Me.jobField Is Nothing) Then
                Me.jobField = New WipValuationQueryJobJobJob
            End If
        End Sub
        
        Public Property MasterSub() As String
            Get
                Return Me.masterSubField
            End Get
            Set
                Me.masterSubField = value
            End Set
        End Property
        
        Public Property [Sub]() As String
            Get
                Return Me.subField
            End Get
            Set
                Me.subField = value
            End Set
        End Property
        
        Public Property JobNumber() As String
            Get
                Return Me.jobNumberField
            End Get
            Set
                Me.jobNumberField = value
            End Set
        End Property
        
        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set
                Me.jobDescriptionField = value
            End Set
        End Property
        
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        Public Property ClassDescription() As String
            Get
                Return Me.classDescriptionField
            End Get
            Set
                Me.classDescriptionField = value
            End Set
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property Version() As Object
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As Object
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property INVWHC_Description() As String
            Get
                Return Me.iNVWHC_DescriptionField
            End Get
            Set
                Me.iNVWHC_DescriptionField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
        
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        Public Property Complete() As String
            Get
                Return Me.completeField
            End Get
            Set
                Me.completeField = value
            End Set
        End Property
        
        Public Property HoldFlag() As String
            Get
                Return Me.holdFlagField
            End Get
            Set
                Me.holdFlagField = value
            End Set
        End Property
        
        Public Property ExpLabour() As String
            Get
                Return Me.expLabourField
            End Get
            Set
                Me.expLabourField = value
            End Set
        End Property
        
        Public Property ExpMaterial() As String
            Get
                Return Me.expMaterialField
            End Get
            Set
                Me.expMaterialField = value
            End Set
        End Property
        
        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set
                Me.qtyToMakeField = value
            End Set
        End Property
        
        Public Property QtyManufactured() As String
            Get
                Return Me.qtyManufacturedField
            End Get
            Set
                Me.qtyManufacturedField = value
            End Set
        End Property
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        Public Property BOMROU_Description() As String
            Get
                Return Me.bOMROU_DescriptionField
            End Get
            Set
                Me.bOMROU_DescriptionField = value
            End Set
        End Property
        
        Public Property ConfirmedFlag() As String
            Get
                Return Me.confirmedFlagField
            End Get
            Set
                Me.confirmedFlagField = value
            End Set
        End Property
        
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        Public Property HrsBookToDate() As String
            Get
                Return Me.hrsBookToDateField
            End Get
            Set
                Me.hrsBookToDateField = value
            End Set
        End Property
        
        Public Property LabCostToDate() As String
            Get
                Return Me.labCostToDateField
            End Get
            Set
                Me.labCostToDateField = value
            End Set
        End Property
        
        Public Property MatCostToDate() As String
            Get
                Return Me.matCostToDateField
            End Get
            Set
                Me.matCostToDateField = value
            End Set
        End Property
        
        Public Property LabValueIssues() As String
            Get
                Return Me.labValueIssuesField
            End Get
            Set
                Me.labValueIssuesField = value
            End Set
        End Property
        
        Public Property MatValueIssues() As String
            Get
                Return Me.matValueIssuesField
            End Get
            Set
                Me.matValueIssuesField = value
            End Set
        End Property
        
        Public Property Job() As WipValuationQueryJobJobJob
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class WipValuationQueryJobJobJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classDescriptionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iNVWHC_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyManufacturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bOMROU_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hrsBookToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matCostToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labValueIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matValueIssuesField As String
        
        Public Property [Sub]() As String
            Get
                Return Me.subField
            End Get
            Set
                Me.subField = value
            End Set
        End Property
        
        Public Property JobNumber() As String
            Get
                Return Me.jobNumberField
            End Get
            Set
                Me.jobNumberField = value
            End Set
        End Property
        
        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set
                Me.jobDescriptionField = value
            End Set
        End Property
        
        Public Property JobClassification() As Object
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        Public Property ClassDescription() As Object
            Get
                Return Me.classDescriptionField
            End Get
            Set
                Me.classDescriptionField = value
            End Set
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property Version() As Object
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As Object
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property INVWHC_Description() As String
            Get
                Return Me.iNVWHC_DescriptionField
            End Get
            Set
                Me.iNVWHC_DescriptionField = value
            End Set
        End Property
        
        Public Property Customer() As Object
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerName() As Object
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
        
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        Public Property Complete() As String
            Get
                Return Me.completeField
            End Get
            Set
                Me.completeField = value
            End Set
        End Property
        
        Public Property HoldFlag() As String
            Get
                Return Me.holdFlagField
            End Get
            Set
                Me.holdFlagField = value
            End Set
        End Property
        
        Public Property ExpLabour() As String
            Get
                Return Me.expLabourField
            End Get
            Set
                Me.expLabourField = value
            End Set
        End Property
        
        Public Property ExpMaterial() As String
            Get
                Return Me.expMaterialField
            End Get
            Set
                Me.expMaterialField = value
            End Set
        End Property
        
        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set
                Me.qtyToMakeField = value
            End Set
        End Property
        
        Public Property QtyManufactured() As String
            Get
                Return Me.qtyManufacturedField
            End Get
            Set
                Me.qtyManufacturedField = value
            End Set
        End Property
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        Public Property BOMROU_Description() As String
            Get
                Return Me.bOMROU_DescriptionField
            End Get
            Set
                Me.bOMROU_DescriptionField = value
            End Set
        End Property
        
        Public Property ConfirmedFlag() As String
            Get
                Return Me.confirmedFlagField
            End Get
            Set
                Me.confirmedFlagField = value
            End Set
        End Property
        
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        Public Property HrsBookToDate() As String
            Get
                Return Me.hrsBookToDateField
            End Get
            Set
                Me.hrsBookToDateField = value
            End Set
        End Property
        
        Public Property LabCostToDate() As String
            Get
                Return Me.labCostToDateField
            End Get
            Set
                Me.labCostToDateField = value
            End Set
        End Property
        
        Public Property MatCostToDate() As String
            Get
                Return Me.matCostToDateField
            End Get
            Set
                Me.matCostToDateField = value
            End Set
        End Property
        
        Public Property LabValueIssues() As String
            Get
                Return Me.labValueIssuesField
            End Get
            Set
                Me.labValueIssuesField = value
            End Set
        End Property
        
        Public Property MatValueIssues() As String
            Get
                Return Me.matValueIssuesField
            End Get
            Set
                Me.matValueIssuesField = value
            End Set
        End Property
    End Class
End Namespace
