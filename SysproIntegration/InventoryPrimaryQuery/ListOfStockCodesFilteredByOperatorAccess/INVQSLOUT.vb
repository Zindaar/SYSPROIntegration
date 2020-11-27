Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.ListOfStockCodesFilteredByOperatorAccess.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InventoryListQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As InventoryListQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemField As InventoryListQueryStockItem
        
        Public Sub New()
            MyBase.New
            If (Me.stockItemField Is Nothing) Then
                Me.stockItemField = New InventoryListQueryStockItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New InventoryListQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As InventoryListQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property StockItem() As InventoryListQueryStockItem
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
    Partial Public Class InventoryListQuerySystemInformation
        
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
    Partial Public Class InventoryListQueryStockItem
        
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
        Private kitTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supercessionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawOfficeNumField As String
        
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
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private listPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldReasonField As String
        
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
        
        Public Property KitType() As String
            Get
                Return Me.kitTypeField
            End Get
            Set
                Me.kitTypeField = value
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
        
        Public Property SerialMethod() As String
            Get
                Return Me.serialMethodField
            End Get
            Set
                Me.serialMethodField = value
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
        
        Public Property ListPriceCode() As String
            Get
                Return Me.listPriceCodeField
            End Get
            Set
                Me.listPriceCodeField = value
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
        
        Public Property GstTaxCode() As String
            Get
                Return Me.gstTaxCodeField
            End Get
            Set
                Me.gstTaxCodeField = value
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
    End Class
End Namespace
