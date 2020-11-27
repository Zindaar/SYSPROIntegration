Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InvQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As InvQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemField As InvQueryStockItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseItemField As List(Of InvQueryWarehouseItem)
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseItemField Is Nothing) Then
                Me.warehouseItemField = New List(Of InvQueryWarehouseItem)
            End If
            If (Me.stockItemField Is Nothing) Then
                Me.stockItemField = New InvQueryStockItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New InvQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As InvQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property StockItem() As InvQueryStockItem
            Get
                Return Me.stockItemField
            End Get
            Set
                Me.stockItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("WarehouseItem")>  _
        Public Property WarehouseItemCollection() As List(Of InvQueryWarehouseItem)
            Get
                Return Me.warehouseItemField
            End Get
            Set
                Me.warehouseItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQuerySystemInformation
        
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
    Partial Public Class InvQueryStockItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKey1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKey2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactAltUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactOthUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockAndAltUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mpsFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supercessionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawOfficeNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dockToStockField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private leadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossReqRuleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eCCUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private listPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bulkIssueFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcClassField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockMovementReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private clearingFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcAnalysisReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCostingReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldReasonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private imageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customFormField As List(Of InvQueryStockItemField)
        
        Public Sub New()
            MyBase.New
            If (Me.customFormField Is Nothing) Then
                Me.customFormField = New List(Of InvQueryStockItemField)
            End If
        End Sub
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property AlternateKey1() As String
            Get
                Return Me.alternateKey1Field
            End Get
            Set
                Me.alternateKey1Field = value
            End Set
        End Property
        
        Public Property AlternateKey2() As String
            Get
                Return Me.alternateKey2Field
            End Get
            Set
                Me.alternateKey2Field = value
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
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property ConvFactAltUom() As String
            Get
                Return Me.convFactAltUomField
            End Get
            Set
                Me.convFactAltUomField = value
            End Set
        End Property
        
        Public Property ConvMulDiv() As String
            Get
                Return Me.convMulDivField
            End Get
            Set
                Me.convMulDivField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
        Public Property ConvFactOthUom() As String
            Get
                Return Me.convFactOthUomField
            End Get
            Set
                Me.convFactOthUomField = value
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
        
        Public Property StockAndAltUm() As String
            Get
                Return Me.stockAndAltUmField
            End Get
            Set
                Me.stockAndAltUmField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
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
        
        Public Property SupplierName() As String
            Get
                Return Me.supplierNameField
            End Get
            Set
                Me.supplierNameField = value
            End Set
        End Property
        
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        Public Property Planner() As String
            Get
                Return Me.plannerField
            End Get
            Set
                Me.plannerField = value
            End Set
        End Property
        
        Public Property TraceableType() As String
            Get
                Return Me.traceableTypeField
            End Get
            Set
                Me.traceableTypeField = value
            End Set
        End Property
        
        Public Property MpsFlag() As String
            Get
                Return Me.mpsFlagField
            End Get
            Set
                Me.mpsFlagField = value
            End Set
        End Property
        
        Public Property SupercessionDate() As String
            Get
                Return Me.supercessionDateField
            End Get
            Set
                Me.supercessionDateField = value
            End Set
        End Property
        
        Public Property DrawOfficeNum() As String
            Get
                Return Me.drawOfficeNumField
            End Get
            Set
                Me.drawOfficeNumField = value
            End Set
        End Property
        
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        Public Property DockToStock() As String
            Get
                Return Me.dockToStockField
            End Get
            Set
                Me.dockToStockField = value
            End Set
        End Property
        
        Public Property ManufLeadTime() As String
            Get
                Return Me.manufLeadTimeField
            End Get
            Set
                Me.manufLeadTimeField = value
            End Set
        End Property
        
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        Public Property UserField3() As String
            Get
                Return Me.userField3Field
            End Get
            Set
                Me.userField3Field = value
            End Set
        End Property
        
        Public Property UserField4() As String
            Get
                Return Me.userField4Field
            End Get
            Set
                Me.userField4Field = value
            End Set
        End Property
        
        Public Property UserField5() As String
            Get
                Return Me.userField5Field
            End Get
            Set
                Me.userField5Field = value
            End Set
        End Property
        
        Public Property LeadTime() As String
            Get
                Return Me.leadTimeField
            End Get
            Set
                Me.leadTimeField = value
            End Set
        End Property
        
        Public Property WarehouseToUse() As String
            Get
                Return Me.warehouseToUseField
            End Get
            Set
                Me.warehouseToUseField = value
            End Set
        End Property
        
        Public Property GrossReqRule() As String
            Get
                Return Me.grossReqRuleField
            End Get
            Set
                Me.grossReqRuleField = value
            End Set
        End Property
        
        Public Property ECCUser() As String
            Get
                Return Me.eCCUserField
            End Get
            Set
                Me.eCCUserField = value
            End Set
        End Property
        
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
        
        Public Property Volume() As String
            Get
                Return Me.volumeField
            End Get
            Set
                Me.volumeField = value
            End Set
        End Property
        
        Public Property PriceCategory() As String
            Get
                Return Me.priceCategoryField
            End Get
            Set
                Me.priceCategoryField = value
            End Set
        End Property
        
        Public Property PriceMethod() As String
            Get
                Return Me.priceMethodField
            End Get
            Set
                Me.priceMethodField = value
            End Set
        End Property
        
        Public Property CycleCount() As String
            Get
                Return Me.cycleCountField
            End Get
            Set
                Me.cycleCountField = value
            End Set
        End Property
        
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        Public Property OtherTaxCode() As String
            Get
                Return Me.otherTaxCodeField
            End Get
            Set
                Me.otherTaxCodeField = value
            End Set
        End Property
        
        Public Property ListPriceCode() As String
            Get
                Return Me.listPriceCodeField
            End Get
            Set
                Me.listPriceCodeField = value
            End Set
        End Property
        
        Public Property SerialMethod() As String
            Get
                Return Me.serialMethodField
            End Get
            Set
                Me.serialMethodField = value
            End Set
        End Property
        
        Public Property KitType() As String
            Get
                Return Me.kitTypeField
            End Get
            Set
                Me.kitTypeField = value
            End Set
        End Property
        
        Public Property BulkIssueFlag() As String
            Get
                Return Me.bulkIssueFlagField
            End Get
            Set
                Me.bulkIssueFlagField = value
            End Set
        End Property
        
        Public Property AbcClass() As Object
            Get
                Return Me.abcClassField
            End Get
            Set
                Me.abcClassField = value
            End Set
        End Property
        
        Public Property StockMovementReq() As String
            Get
                Return Me.stockMovementReqField
            End Get
            Set
                Me.stockMovementReqField = value
            End Set
        End Property
        
        Public Property ClearingFlag() As String
            Get
                Return Me.clearingFlagField
            End Get
            Set
                Me.clearingFlagField = value
            End Set
        End Property
        
        Public Property AbcAnalysisReq() As String
            Get
                Return Me.abcAnalysisReqField
            End Get
            Set
                Me.abcAnalysisReqField = value
            End Set
        End Property
        
        Public Property AbcCostingReq() As String
            Get
                Return Me.abcCostingReqField
            End Get
            Set
                Me.abcCostingReqField = value
            End Set
        End Property
        
        Public Property CostUom() As String
            Get
                Return Me.costUomField
            End Get
            Set
                Me.costUomField = value
            End Set
        End Property
        
        Public Property StockOnHold() As String
            Get
                Return Me.stockOnHoldField
            End Get
            Set
                Me.stockOnHoldField = value
            End Set
        End Property
        
        Public Property StockOnHoldReason() As String
            Get
                Return Me.stockOnHoldReasonField
            End Get
            Set
                Me.stockOnHoldReasonField = value
            End Set
        End Property
        
        Public Property Image() As String
            Get
                Return Me.imageField
            End Get
            Set
                Me.imageField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable:=false)>  _
        Public Property CustomFormCollection() As List(Of InvQueryStockItemField)
            Get
                Return Me.customFormField
            End Get
            Set
                Me.customFormField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryStockItemField
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private promptField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lengthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNullField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Property Sequence() As String
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
            End Set
        End Property
        
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set
                Me.promptField = value
            End Set
        End Property
        
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        Public Property Length() As String
            Get
                Return Me.lengthField
            End Get
            Set
                Me.lengthField = value
            End Set
        End Property
        
        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
            End Set
        End Property
        
        Public Property [Default]() As String
            Get
                Return Me.defaultField
            End Get
            Set
                Me.defaultField = value
            End Set
        End Property
        
        Public Property AllowNull() As String
            Get
                Return Me.allowNullField
            End Get
            Set
                Me.allowNullField = value
            End Set
        End Property
        
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInInspectionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maximumQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnBackOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAllocatedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyAdjustedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prevYearQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInTransitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAllocatedWipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyTrfField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQtyByMonthField As InvQueryWarehouseItemSalesQtyByMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binItemField As List(Of InvQueryWarehouseItemBinItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotItemField As InvQueryWarehouseItemLotItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialItemField As List(Of InvQueryWarehouseItemSerialItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementField As List(Of InvQueryWarehouseItemMovement)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccItemField As InvQueryWarehouseItemEccItem
        
        Public Sub New()
            MyBase.New
            If (Me.eccItemField Is Nothing) Then
                Me.eccItemField = New InvQueryWarehouseItemEccItem
            End If
            If (Me.movementField Is Nothing) Then
                Me.movementField = New List(Of InvQueryWarehouseItemMovement)
            End If
            If (Me.serialItemField Is Nothing) Then
                Me.serialItemField = New List(Of InvQueryWarehouseItemSerialItem)
            End If
            If (Me.lotItemField Is Nothing) Then
                Me.lotItemField = New InvQueryWarehouseItemLotItem
            End If
            If (Me.binItemField Is Nothing) Then
                Me.binItemField = New List(Of InvQueryWarehouseItemBinItem)
            End If
            If (Me.salesQtyByMonthField Is Nothing) Then
                Me.salesQtyByMonthField = New InvQueryWarehouseItemSalesQtyByMonth
            End If
        End Sub
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
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
        
        Public Property QtyOnHand() As String
            Get
                Return Me.qtyOnHandField
            End Get
            Set
                Me.qtyOnHandField = value
            End Set
        End Property
        
        Public Property AvailableQty() As String
            Get
                Return Me.availableQtyField
            End Get
            Set
                Me.availableQtyField = value
            End Set
        End Property
        
        Public Property QtyOnOrder() As String
            Get
                Return Me.qtyOnOrderField
            End Get
            Set
                Me.qtyOnOrderField = value
            End Set
        End Property
        
        Public Property QtyInInspection() As String
            Get
                Return Me.qtyInInspectionField
            End Get
            Set
                Me.qtyInInspectionField = value
            End Set
        End Property
        
        Public Property MinimumQty() As String
            Get
                Return Me.minimumQtyField
            End Get
            Set
                Me.minimumQtyField = value
            End Set
        End Property
        
        Public Property MaximumQty() As String
            Get
                Return Me.maximumQtyField
            End Get
            Set
                Me.maximumQtyField = value
            End Set
        End Property
        
        Public Property QtyOnBackOrder() As String
            Get
                Return Me.qtyOnBackOrderField
            End Get
            Set
                Me.qtyOnBackOrderField = value
            End Set
        End Property
        
        Public Property QtyAllocated() As String
            Get
                Return Me.qtyAllocatedField
            End Get
            Set
                Me.qtyAllocatedField = value
            End Set
        End Property
        
        Public Property MtdQtyReceived() As String
            Get
                Return Me.mtdQtyReceivedField
            End Get
            Set
                Me.mtdQtyReceivedField = value
            End Set
        End Property
        
        Public Property MtdQtyAdjusted() As String
            Get
                Return Me.mtdQtyAdjustedField
            End Get
            Set
                Me.mtdQtyAdjustedField = value
            End Set
        End Property
        
        Public Property MtdQtyIssued() As String
            Get
                Return Me.mtdQtyIssuedField
            End Get
            Set
                Me.mtdQtyIssuedField = value
            End Set
        End Property
        
        Public Property YtdQtySold() As String
            Get
                Return Me.ytdQtySoldField
            End Get
            Set
                Me.ytdQtySoldField = value
            End Set
        End Property
        
        Public Property PrevYearQtySold() As String
            Get
                Return Me.prevYearQtySoldField
            End Get
            Set
                Me.prevYearQtySoldField = value
            End Set
        End Property
        
        Public Property QtyInTransit() As String
            Get
                Return Me.qtyInTransitField
            End Get
            Set
                Me.qtyInTransitField = value
            End Set
        End Property
        
        Public Property QtyAllocatedWip() As String
            Get
                Return Me.qtyAllocatedWipField
            End Get
            Set
                Me.qtyAllocatedWipField = value
            End Set
        End Property
        
        Public Property MtdQtySold() As String
            Get
                Return Me.mtdQtySoldField
            End Get
            Set
                Me.mtdQtySoldField = value
            End Set
        End Property
        
        Public Property MtdQtyTrf() As String
            Get
                Return Me.mtdQtyTrfField
            End Get
            Set
                Me.mtdQtyTrfField = value
            End Set
        End Property
        
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        Public Property UserField3() As String
            Get
                Return Me.userField3Field
            End Get
            Set
                Me.userField3Field = value
            End Set
        End Property
        
        Public Property DefaultBin() As String
            Get
                Return Me.defaultBinField
            End Get
            Set
                Me.defaultBinField = value
            End Set
        End Property
        
        Public Property UnitCost() As Decimal
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        Public Property SalesQtyByMonth() As InvQueryWarehouseItemSalesQtyByMonth
            Get
                Return Me.salesQtyByMonthField
            End Get
            Set
                Me.salesQtyByMonthField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("BinItem")>  _
        Public Property BinItemCollection() As List(Of InvQueryWarehouseItemBinItem)
            Get
                Return Me.binItemField
            End Get
            Set
                Me.binItemField = value
            End Set
        End Property
        
        Public Property LotItem() As InvQueryWarehouseItemLotItem
            Get
                Return Me.lotItemField
            End Get
            Set
                Me.lotItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SerialItem")>  _
        Public Property SerialItemCollection() As List(Of InvQueryWarehouseItemSerialItem)
            Get
                Return Me.serialItemField
            End Get
            Set
                Me.serialItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Movement")>  _
        Public Property MovementCollection() As List(Of InvQueryWarehouseItemMovement)
            Get
                Return Me.movementField
            End Get
            Set
                Me.movementField = value
            End Set
        End Property
        
        Public Property EccItem() As InvQueryWarehouseItemEccItem
            Get
                Return Me.eccItemField
            End Get
            Set
                Me.eccItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemSalesQtyByMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQty12Field As String
        
        Public Property SalesQty1() As String
            Get
                Return Me.salesQty1Field
            End Get
            Set
                Me.salesQty1Field = value
            End Set
        End Property
        
        Public Property SalesQty2() As String
            Get
                Return Me.salesQty2Field
            End Get
            Set
                Me.salesQty2Field = value
            End Set
        End Property
        
        Public Property SalesQty3() As String
            Get
                Return Me.salesQty3Field
            End Get
            Set
                Me.salesQty3Field = value
            End Set
        End Property
        
        Public Property SalesQty4() As String
            Get
                Return Me.salesQty4Field
            End Get
            Set
                Me.salesQty4Field = value
            End Set
        End Property
        
        Public Property SalesQty5() As String
            Get
                Return Me.salesQty5Field
            End Get
            Set
                Me.salesQty5Field = value
            End Set
        End Property
        
        Public Property SalesQty6() As String
            Get
                Return Me.salesQty6Field
            End Get
            Set
                Me.salesQty6Field = value
            End Set
        End Property
        
        Public Property SalesQty7() As String
            Get
                Return Me.salesQty7Field
            End Get
            Set
                Me.salesQty7Field = value
            End Set
        End Property
        
        Public Property SalesQty8() As String
            Get
                Return Me.salesQty8Field
            End Get
            Set
                Me.salesQty8Field = value
            End Set
        End Property
        
        Public Property SalesQty9() As String
            Get
                Return Me.salesQty9Field
            End Get
            Set
                Me.salesQty9Field = value
            End Set
        End Property
        
        Public Property SalesQty10() As String
            Get
                Return Me.salesQty10Field
            End Get
            Set
                Me.salesQty10Field = value
            End Set
        End Property
        
        Public Property SalesQty11() As String
            Get
                Return Me.salesQty11Field
            End Get
            Set
                Me.salesQty11Field = value
            End Set
        End Property
        
        Public Property SalesQty12() As String
            Get
                Return Me.salesQty12Field
            End Get
            Set
                Me.salesQty12Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemBinItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private noteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldReasonField As String
        
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
            End Set
        End Property
        
        Public Property QtyOnHand() As String
            Get
                Return Me.qtyOnHandField
            End Get
            Set
                Me.qtyOnHandField = value
            End Set
        End Property
        
        Public Property AvailableQty() As String
            Get
                Return Me.availableQtyField
            End Get
            Set
                Me.availableQtyField = value
            End Set
        End Property
        
        Public Property Note() As String
            Get
                Return Me.noteField
            End Get
            Set
                Me.noteField = value
            End Set
        End Property
        
        Public Property OnHold() As String
            Get
                Return Me.onHoldField
            End Get
            Set
                Me.onHoldField = value
            End Set
        End Property
        
        Public Property OnHoldReason() As String
            Get
                Return Me.onHoldReasonField
            End Get
            Set
                Me.onHoldReasonField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemLotItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private noteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotHoldFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        Public Property LotJob() As String
            Get
                Return Me.lotJobField
            End Get
            Set
                Me.lotJobField = value
            End Set
        End Property
        
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
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
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property QtyOnHand() As String
            Get
                Return Me.qtyOnHandField
            End Get
            Set
                Me.qtyOnHandField = value
            End Set
        End Property
        
        Public Property AvailableQty() As String
            Get
                Return Me.availableQtyField
            End Get
            Set
                Me.availableQtyField = value
            End Set
        End Property
        
        Public Property Note() As String
            Get
                Return Me.noteField
            End Get
            Set
                Me.noteField = value
            End Set
        End Property
        
        Public Property LotHoldFlag() As String
            Get
                Return Me.lotHoldFlagField
            End Get
            Set
                Me.lotHoldFlagField = value
            End Set
        End Property
        
        Public Property ExpiryDate() As String
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemSerialItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private locationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serviceFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private loadFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serviceDepotFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAvailableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInTransitOutField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        Public Property Serial() As String
            Get
                Return Me.serialField
            End Get
            Set
                Me.serialField = value
            End Set
        End Property
        
        Public Property SerialDescription() As String
            Get
                Return Me.serialDescriptionField
            End Get
            Set
                Me.serialDescriptionField = value
            End Set
        End Property
        
        Public Property SerialMethod() As String
            Get
                Return Me.serialMethodField
            End Get
            Set
                Me.serialMethodField = value
            End Set
        End Property
        
        Public Property Location() As String
            Get
                Return Me.locationField
            End Get
            Set
                Me.locationField = value
            End Set
        End Property
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        Public Property ServiceFlag() As String
            Get
                Return Me.serviceFlagField
            End Get
            Set
                Me.serviceFlagField = value
            End Set
        End Property
        
        Public Property LoadFlag() As String
            Get
                Return Me.loadFlagField
            End Get
            Set
                Me.loadFlagField = value
            End Set
        End Property
        
        Public Property ServiceDepotFlag() As String
            Get
                Return Me.serviceDepotFlagField
            End Get
            Set
                Me.serviceDepotFlagField = value
            End Set
        End Property
        
        Public Property QtyOnHand() As String
            Get
                Return Me.qtyOnHandField
            End Get
            Set
                Me.qtyOnHandField = value
            End Set
        End Property
        
        Public Property QtyAvailable() As String
            Get
                Return Me.qtyAvailableField
            End Get
            Set
                Me.qtyAvailableField = value
            End Set
        End Property
        
        Public Property QtyReceived() As String
            Get
                Return Me.qtyReceivedField
            End Get
            Set
                Me.qtyReceivedField = value
            End Set
        End Property
        
        Public Property QtyInTransitOut() As String
            Get
                Return Me.qtyInTransitOutField
            End Get
            Set
                Me.qtyInTransitOutField = value
            End Set
        End Property
        
        Public Property ExpiryDate() As String
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = value
            End Set
        End Property
        
        Public Property ScrapDate() As String
            Get
                Return Me.scrapDateField
            End Get
            Set
                Me.scrapDateField = value
            End Set
        End Property
        
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemMovement
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private docTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As String
        
        Public Property EntryDate() As String
            Get
                Return Me.entryDateField
            End Get
            Set
                Me.entryDateField = value
            End Set
        End Property
        
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
            End Set
        End Property
        
        Public Property TrnQty() As String
            Get
                Return Me.trnQtyField
            End Get
            Set
                Me.trnQtyField = value
            End Set
        End Property
        
        Public Property TrnType() As String
            Get
                Return Me.trnTypeField
            End Get
            Set
                Me.trnTypeField = value
            End Set
        End Property
        
        Public Property Document() As String
            Get
                Return Me.documentField
            End Get
            Set
                Me.documentField = value
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
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
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
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
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
        
        Public Property SupplierName() As String
            Get
                Return Me.supplierNameField
            End Get
            Set
                Me.supplierNameField = value
            End Set
        End Property
        
        Public Property TrnValue() As String
            Get
                Return Me.trnValueField
            End Get
            Set
                Me.trnValueField = value
            End Set
        End Property
        
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        Public Property CostValue() As String
            Get
                Return Me.costValueField
            End Get
            Set
                Me.costValueField = value
            End Set
        End Property
        
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        Public Property UnitPrice() As String
            Get
                Return Me.unitPriceField
            End Get
            Set
                Me.unitPriceField = value
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
        
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
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
        
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        Public Property DocType() As String
            Get
                Return Me.docTypeField
            End Get
            Set
                Me.docTypeField = value
            End Set
        End Property
        
        Public Property NewWarehouse() As String
            Get
                Return Me.newWarehouseField
            End Get
            Set
                Me.newWarehouseField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvQueryWarehouseItemEccItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInInspectionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnBackOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAllocatedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAllocatedWipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInTransitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyDispatchedField As String
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property QtyOnHand() As String
            Get
                Return Me.qtyOnHandField
            End Get
            Set
                Me.qtyOnHandField = value
            End Set
        End Property
        
        Public Property AvailableQty() As String
            Get
                Return Me.availableQtyField
            End Get
            Set
                Me.availableQtyField = value
            End Set
        End Property
        
        Public Property QtyOnOrder() As String
            Get
                Return Me.qtyOnOrderField
            End Get
            Set
                Me.qtyOnOrderField = value
            End Set
        End Property
        
        Public Property QtyInInspection() As String
            Get
                Return Me.qtyInInspectionField
            End Get
            Set
                Me.qtyInInspectionField = value
            End Set
        End Property
        
        Public Property QtyOnBackOrder() As String
            Get
                Return Me.qtyOnBackOrderField
            End Get
            Set
                Me.qtyOnBackOrderField = value
            End Set
        End Property
        
        Public Property QtyAllocated() As String
            Get
                Return Me.qtyAllocatedField
            End Get
            Set
                Me.qtyAllocatedField = value
            End Set
        End Property
        
        Public Property QtyAllocatedWip() As String
            Get
                Return Me.qtyAllocatedWipField
            End Get
            Set
                Me.qtyAllocatedWipField = value
            End Set
        End Property
        
        Public Property QtyInTransit() As String
            Get
                Return Me.qtyInTransitField
            End Get
            Set
                Me.qtyInTransitField = value
            End Set
        End Property
        
        Public Property QtyDispatched() As String
            Get
                Return Me.qtyDispatchedField
            End Get
            Set
                Me.qtyDispatchedField = value
            End Set
        End Property
    End Class
End Namespace
