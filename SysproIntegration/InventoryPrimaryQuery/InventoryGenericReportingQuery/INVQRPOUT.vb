Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryGenericReportingQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InvReportingQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As InvReportingQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemField As List(Of InvReportingQueryStockItem)
        
        Public Sub New()
            MyBase.New
            If (Me.stockItemField Is Nothing) Then
                Me.stockItemField = New List(Of InvReportingQueryStockItem)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New InvReportingQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As InvReportingQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("StockItem")>  _
        Public Property StockItemCollection() As List(Of InvReportingQueryStockItem)
            Get
                Return Me.stockItemField
            End Get
            Set
                Me.stockItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQuerySystemInformation
        
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
    Partial Public Class InvReportingQueryStockItem
        
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
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
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
        Private priceCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private clearingFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private listPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingRuleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactAltUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactOthUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceInformationField As InvReportingQueryStockItemPriceInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateStockCodeField As InvReportingQueryStockItemAlternateStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateSupplierField As InvReportingQueryStockItemAlternateSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exceptionsField As InvReportingQueryStockItemExceptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseItemField As List(Of InvReportingQueryStockItemWarehouseItem)
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseItemField Is Nothing) Then
                Me.warehouseItemField = New List(Of InvReportingQueryStockItemWarehouseItem)
            End If
            If (Me.exceptionsField Is Nothing) Then
                Me.exceptionsField = New InvReportingQueryStockItemExceptions
            End If
            If (Me.alternateSupplierField Is Nothing) Then
                Me.alternateSupplierField = New InvReportingQueryStockItemAlternateSupplier
            End If
            If (Me.alternateStockCodeField Is Nothing) Then
                Me.alternateStockCodeField = New InvReportingQueryStockItemAlternateStockCode
            End If
            If (Me.priceInformationField Is Nothing) Then
                Me.priceInformationField = New InvReportingQueryStockItemPriceInformation
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
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
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
        
        Public Property Supplier() As Object
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property SupplierName() As Object
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
        
        Public Property CycleCount() As String
            Get
                Return Me.cycleCountField
            End Get
            Set
                Me.cycleCountField = value
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
        
        Public Property WarehouseToUse() As String
            Get
                Return Me.warehouseToUseField
            End Get
            Set
                Me.warehouseToUseField = value
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
        
        Public Property PriceCategory() As String
            Get
                Return Me.priceCategoryField
            End Get
            Set
                Me.priceCategoryField = value
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
        
        Public Property AbcClass() As String
            Get
                Return Me.abcClassField
            End Get
            Set
                Me.abcClassField = value
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
        
        Public Property ClearingFlag() As String
            Get
                Return Me.clearingFlagField
            End Get
            Set
                Me.clearingFlagField = value
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
        
        Public Property BuyingRule() As String
            Get
                Return Me.buyingRuleField
            End Get
            Set
                Me.buyingRuleField = value
            End Set
        End Property
        
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
            End Set
        End Property
        
        Public Property EccFlag() As String
            Get
                Return Me.eccFlagField
            End Get
            Set
                Me.eccFlagField = value
            End Set
        End Property
        
        Public Property EccUser() As String
            Get
                Return Me.eccUserField
            End Get
            Set
                Me.eccUserField = value
            End Set
        End Property
        
        Public Property MakeToOrderFlag() As String
            Get
                Return Me.makeToOrderFlagField
            End Get
            Set
                Me.makeToOrderFlagField = value
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
        
        Public Property ConvMulDiv() As String
            Get
                Return Me.convMulDivField
            End Get
            Set
                Me.convMulDivField = value
            End Set
        End Property
        
        Public Property PriceInformation() As InvReportingQueryStockItemPriceInformation
            Get
                Return Me.priceInformationField
            End Get
            Set
                Me.priceInformationField = value
            End Set
        End Property
        
        Public Property AlternateStockCode() As InvReportingQueryStockItemAlternateStockCode
            Get
                Return Me.alternateStockCodeField
            End Get
            Set
                Me.alternateStockCodeField = value
            End Set
        End Property
        
        Public Property AlternateSupplier() As InvReportingQueryStockItemAlternateSupplier
            Get
                Return Me.alternateSupplierField
            End Get
            Set
                Me.alternateSupplierField = value
            End Set
        End Property
        
        Public Property Exceptions() As InvReportingQueryStockItemExceptions
            Get
                Return Me.exceptionsField
            End Get
            Set
                Me.exceptionsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("WarehouseItem")>  _
        Public Property WarehouseItemCollection() As List(Of InvReportingQueryStockItemWarehouseItem)
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
    Partial Public Class InvReportingQueryStockItemPriceInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeItemField As List(Of InvReportingQueryStockItemPriceInformationPriceCodeItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignCurrencyItemField As List(Of InvReportingQueryStockItemPriceInformationForeignCurrencyItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityPriceMethodItemField As InvReportingQueryStockItemPriceInformationQuantityPriceMethodItem
        
        Public Sub New()
            MyBase.New
            If (Me.quantityPriceMethodItemField Is Nothing) Then
                Me.quantityPriceMethodItemField = New InvReportingQueryStockItemPriceInformationQuantityPriceMethodItem
            End If
            If (Me.foreignCurrencyItemField Is Nothing) Then
                Me.foreignCurrencyItemField = New List(Of InvReportingQueryStockItemPriceInformationForeignCurrencyItem)
            End If
            If (Me.priceCodeItemField Is Nothing) Then
                Me.priceCodeItemField = New List(Of InvReportingQueryStockItemPriceInformationPriceCodeItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("PriceCodeItem")>  _
        Public Property PriceCodeItemCollection() As List(Of InvReportingQueryStockItemPriceInformationPriceCodeItem)
            Get
                Return Me.priceCodeItemField
            End Get
            Set
                Me.priceCodeItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ForeignCurrencyItem")>  _
        Public Property ForeignCurrencyItemCollection() As List(Of InvReportingQueryStockItemPriceInformationForeignCurrencyItem)
            Get
                Return Me.foreignCurrencyItemField
            End Get
            Set
                Me.foreignCurrencyItemField = value
            End Set
        End Property
        
        Public Property QuantityPriceMethodItem() As InvReportingQueryStockItemPriceInformationQuantityPriceMethodItem
            Get
                Return Me.quantityPriceMethodItemField
            End Get
            Set
                Me.quantityPriceMethodItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemPriceInformationPriceCodeItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sellingPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceBasisField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionCodeField As String
        
        Public Property SellingPrice() As String
            Get
                Return Me.sellingPriceField
            End Get
            Set
                Me.sellingPriceField = value
            End Set
        End Property
        
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
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
        
        Public Property PriceBasis() As String
            Get
                Return Me.priceBasisField
            End Get
            Set
                Me.priceBasisField = value
            End Set
        End Property
        
        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set
                Me.commissionCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemPriceInformationForeignCurrencyItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignPriceField As String
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property ForeignPrice() As String
            Get
                Return Me.foreignPriceField
            End Get
            Set
                Me.foreignPriceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemPriceInformationQuantityPriceMethodItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyBreakField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        Public Property QtyBreak() As String
            Get
                Return Me.qtyBreakField
            End Get
            Set
                Me.qtyBreakField = value
            End Set
        End Property
        
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemAlternateStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeItemField As InvReportingQueryStockItemAlternateStockCodeStockCodeItem
        
        Public Sub New()
            MyBase.New
            If (Me.stockCodeItemField Is Nothing) Then
                Me.stockCodeItemField = New InvReportingQueryStockItemAlternateStockCodeStockCodeItem
            End If
        End Sub
        
        Public Property StockCodeItem() As InvReportingQueryStockItemAlternateStockCodeStockCodeItem
            Get
                Return Me.stockCodeItemField
            End Get
            Set
                Me.stockCodeItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemAlternateStockCodeStockCodeItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemAlternateSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierItemField As List(Of InvReportingQueryStockItemAlternateSupplierSupplierItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textField Is Nothing) Then
                Me.textField = New List(Of String)
            End If
            If (Me.supplierItemField Is Nothing) Then
                Me.supplierItemField = New List(Of InvReportingQueryStockItemAlternateSupplierSupplierItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("SupplierItem")>  _
        Public Property SupplierItemCollection() As List(Of InvReportingQueryStockItemAlternateSupplierSupplierItem)
            Get
                Return Me.supplierItemField
            End Get
            Set
                Me.supplierItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
        Public Property TextCollection() As List(Of String)
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemAlternateSupplierSupplierItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemExceptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isOnHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isSuperSededField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isClearingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textField Is Nothing) Then
                Me.textField = New List(Of String)
            End If
        End Sub
        
        Public Property IsOnHold() As String
            Get
                Return Me.isOnHoldField
            End Get
            Set
                Me.isOnHoldField = value
            End Set
        End Property
        
        Public Property IsSuperSeded() As String
            Get
                Return Me.isSuperSededField
            End Get
            Set
                Me.isSuperSededField = value
            End Set
        End Property
        
        Public Property IsClearing() As String
            Get
                Return Me.isClearingField
            End Get
            Set
                Me.isClearingField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
        Public Property TextCollection() As List(Of String)
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemWarehouseItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcClassField As String
        
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
        Private qtyAllocatedWipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyAdjustedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdQtyTrfField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdQtyIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prevYearQtySoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInTransitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyDispatchedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastSaleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastStockMoveField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastCostChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastStockCntField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastPurchaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseHistoryDetailsField As List(Of InvReportingQueryStockItemWarehouseItemWarehouseHistoryItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageValuationInformationField As List(Of InvReportingQueryStockItemWarehouseItemAgeItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exceptionsField As InvReportingQueryStockItemWarehouseItemExceptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementField As List(Of InvReportingQueryStockItemWarehouseItemMovement)
        
        Public Sub New()
            MyBase.New
            If (Me.movementField Is Nothing) Then
                Me.movementField = New List(Of InvReportingQueryStockItemWarehouseItemMovement)
            End If
            If (Me.exceptionsField Is Nothing) Then
                Me.exceptionsField = New InvReportingQueryStockItemWarehouseItemExceptions
            End If
            If (Me.ageValuationInformationField Is Nothing) Then
                Me.ageValuationInformationField = New List(Of InvReportingQueryStockItemWarehouseItemAgeItem)
            End If
            If (Me.warehouseHistoryDetailsField Is Nothing) Then
                Me.warehouseHistoryDetailsField = New List(Of InvReportingQueryStockItemWarehouseItemWarehouseHistoryItem)
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
        
        Public Property DefaultBin() As String
            Get
                Return Me.defaultBinField
            End Get
            Set
                Me.defaultBinField = value
            End Set
        End Property
        
        Public Property AbcClass() As String
            Get
                Return Me.abcClassField
            End Get
            Set
                Me.abcClassField = value
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
        
        Public Property QtyAllocatedWip() As String
            Get
                Return Me.qtyAllocatedWipField
            End Get
            Set
                Me.qtyAllocatedWipField = value
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
        
        Public Property OpeningBalance() As String
            Get
                Return Me.openingBalanceField
            End Get
            Set
                Me.openingBalanceField = value
            End Set
        End Property
        
        Public Property YtdQtyIssued() As String
            Get
                Return Me.ytdQtyIssuedField
            End Get
            Set
                Me.ytdQtyIssuedField = value
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
        
        Public Property QtyDispatched() As String
            Get
                Return Me.qtyDispatchedField
            End Get
            Set
                Me.qtyDispatchedField = value
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
        
        Public Property DateLastSale() As String
            Get
                Return Me.dateLastSaleField
            End Get
            Set
                Me.dateLastSaleField = value
            End Set
        End Property
        
        Public Property DateLastStockMove() As String
            Get
                Return Me.dateLastStockMoveField
            End Get
            Set
                Me.dateLastStockMoveField = value
            End Set
        End Property
        
        Public Property DateLastCostChange() As String
            Get
                Return Me.dateLastCostChangeField
            End Get
            Set
                Me.dateLastCostChangeField = value
            End Set
        End Property
        
        Public Property DateLastStockCnt() As String
            Get
                Return Me.dateLastStockCntField
            End Get
            Set
                Me.dateLastStockCntField = value
            End Set
        End Property
        
        Public Property DateLastPurchase() As String
            Get
                Return Me.dateLastPurchaseField
            End Get
            Set
                Me.dateLastPurchaseField = value
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
        
        <System.Xml.Serialization.XmlArrayItemAttribute("WarehouseHistoryItem", IsNullable:=false)>  _
        Public Property WarehouseHistoryDetailsCollection() As List(Of InvReportingQueryStockItemWarehouseItemWarehouseHistoryItem)
            Get
                Return Me.warehouseHistoryDetailsField
            End Get
            Set
                Me.warehouseHistoryDetailsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("AgeItem", IsNullable:=false)>  _
        Public Property AgeValuationInformationCollection() As List(Of InvReportingQueryStockItemWarehouseItemAgeItem)
            Get
                Return Me.ageValuationInformationField
            End Get
            Set
                Me.ageValuationInformationField = value
            End Set
        End Property
        
        Public Property Exceptions() As InvReportingQueryStockItemWarehouseItemExceptions
            Get
                Return Me.exceptionsField
            End Get
            Set
                Me.exceptionsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Movement")>  _
        Public Property MovementCollection() As List(Of InvReportingQueryStockItemWarehouseItemMovement)
            Get
                Return Me.movementField
            End Get
            Set
                Me.movementField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemWarehouseItemWarehouseHistoryItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openBalQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openBalCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesQtyField As String
        
        Public Property OpenBalQty() As String
            Get
                Return Me.openBalQtyField
            End Get
            Set
                Me.openBalQtyField = value
            End Set
        End Property
        
        Public Property OpenBalCost() As String
            Get
                Return Me.openBalCostField
            End Get
            Set
                Me.openBalCostField = value
            End Set
        End Property
        
        Public Property Month() As String
            Get
                Return Me.monthField
            End Get
            Set
                Me.monthField = value
            End Set
        End Property
        
        Public Property Year() As String
            Get
                Return Me.yearField
            End Get
            Set
                Me.yearField = value
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
        
        Public Property SalesQty() As String
            Get
                Return Me.salesQtyField
            End Get
            Set
                Me.salesQtyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemWarehouseItemAgeItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        Public Property Year() As String
            Get
                Return Me.yearField
            End Get
            Set
                Me.yearField = value
            End Set
        End Property
        
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemWarehouseItemExceptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isZeroQtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isNegQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isZeroQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isPosQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isOnOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isOnBackOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isGITField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isUnderMinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isUnderSafetyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isOverMaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isInactiveField As String
        
        Public Property IsZeroQtyOnHand() As String
            Get
                Return Me.isZeroQtyOnHandField
            End Get
            Set
                Me.isZeroQtyOnHandField = value
            End Set
        End Property
        
        Public Property IsNegQty() As String
            Get
                Return Me.isNegQtyField
            End Get
            Set
                Me.isNegQtyField = value
            End Set
        End Property
        
        Public Property IsZeroQty() As String
            Get
                Return Me.isZeroQtyField
            End Get
            Set
                Me.isZeroQtyField = value
            End Set
        End Property
        
        Public Property IsPosQty() As String
            Get
                Return Me.isPosQtyField
            End Get
            Set
                Me.isPosQtyField = value
            End Set
        End Property
        
        Public Property IsOnOrder() As String
            Get
                Return Me.isOnOrderField
            End Get
            Set
                Me.isOnOrderField = value
            End Set
        End Property
        
        Public Property IsOnBackOrder() As String
            Get
                Return Me.isOnBackOrderField
            End Get
            Set
                Me.isOnBackOrderField = value
            End Set
        End Property
        
        Public Property IsGIT() As String
            Get
                Return Me.isGITField
            End Get
            Set
                Me.isGITField = value
            End Set
        End Property
        
        Public Property IsUnderMin() As String
            Get
                Return Me.isUnderMinField
            End Get
            Set
                Me.isUnderMinField = value
            End Set
        End Property
        
        Public Property IsUnderSafety() As String
            Get
                Return Me.isUnderSafetyField
            End Get
            Set
                Me.isUnderSafetyField = value
            End Set
        End Property
        
        Public Property IsOverMax() As String
            Get
                Return Me.isOverMaxField
            End Get
            Set
                Me.isOverMaxField = value
            End Set
        End Property
        
        Public Property IsInactive() As String
            Get
                Return Me.isInactiveField
            End Get
            Set
                Me.isInactiveField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InvReportingQueryStockItemWarehouseItemMovement
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
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
        Private trnValueField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newWarehouseField As String
        
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
        Private typeField As String
        
        Public Property EntryDate() As String
            Get
                Return Me.entryDateField
            End Get
            Set
                Me.entryDateField = value
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
        
        Public Property TrnValue() As Decimal
            Get
                Return Me.trnValueField
            End Get
            Set
                Me.trnValueField = value
            End Set
        End Property
        
        Public Property SalesBin() As String
            Get
                Return Me.salesBinField
            End Get
            Set
                Me.salesBinField = value
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
        
        Public Property DispatchNote() As String
            Get
                Return Me.dispatchNoteField
            End Get
            Set
                Me.dispatchNoteField = value
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
        
        Public Property NewWarehouse() As String
            Get
                Return Me.newWarehouseField
            End Get
            Set
                Me.newWarehouseField = value
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
End Namespace
