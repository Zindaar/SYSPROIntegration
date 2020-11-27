Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryInspectionSystem.InspectionQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PorInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As PorInspectionSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionItemField As PorInspectionInspectionItem
        
        Public Sub New()
            MyBase.New
            If (Me.inspectionItemField Is Nothing) Then
                Me.inspectionItemField = New PorInspectionInspectionItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New PorInspectionSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As PorInspectionSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property InspectionItem() As PorInspectionInspectionItem
            Get
                Return Me.inspectionItemField
            End Get
            Set
                Me.inspectionItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorInspectionSystemInformation
        
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
    Partial Public Class PorInspectionInspectionItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseItemField As PorInspectionInspectionItemWarehouseItem
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseItemField Is Nothing) Then
                Me.warehouseItemField = New PorInspectionInspectionItemWarehouseItem
            End If
        End Sub
        
        Public Property WarehouseItem() As PorInspectionInspectionItemWarehouseItem
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
    Partial Public Class PorInspectionInspectionItemWarehouseItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeItemField As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItem)
        
        Public Sub New()
            MyBase.New
            If (Me.stockCodeItemField Is Nothing) Then
                Me.stockCodeItemField = New List(Of PorInspectionInspectionItemWarehouseItemStockCodeItem)
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
        
        <System.Xml.Serialization.XmlElementAttribute("StockCodeItem")>  _
        Public Property StockCodeItemCollection() As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItem)
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
    Partial Public Class PorInspectionInspectionItemWarehouseItemStockCodeItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supCatalogueNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnItemField As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem)
        
        Public Sub New()
            MyBase.New
            If (Me.grnItemField Is Nothing) Then
                Me.grnItemField = New List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem)
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
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property SupCatalogueNum() As String
            Get
                Return Me.supCatalogueNumField
            End Get
            Set
                Me.supCatalogueNumField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("GrnItem")>  _
        Public Property GrnItemCollection() As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem)
            Get
                Return Me.grnItemField
            End Get
            Set
                Me.grnItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnReceiptDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supDelNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private certificateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspNarrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOnSiteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyOffSiteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAdvisedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyInspectedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyCountedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countCompletedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionCompletedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyAcceptedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyScrappedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyRejectedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceFactorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderFactorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactOrdUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLValFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDetailField As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialItemField As PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem
        
        Public Sub New()
            MyBase.New
            If (Me.serialItemField Is Nothing) Then
                Me.serialItemField = New PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem
            End If
            If (Me.transactionDetailField Is Nothing) Then
                Me.transactionDetailField = New List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail)
            End If
        End Sub
        
        Public Property Grn() As String
            Get
                Return Me.grnField
            End Get
            Set
                Me.grnField = value
            End Set
        End Property
        
        Public Property GrnReceiptDate() As String
            Get
                Return Me.grnReceiptDateField
            End Get
            Set
                Me.grnReceiptDateField = value
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
        
        Public Property Contact() As String
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
            End Set
        End Property
        
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
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
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property PurchaseOrderLin() As String
            Get
                Return Me.purchaseOrderLinField
            End Get
            Set
                Me.purchaseOrderLinField = value
            End Set
        End Property
        
        Public Property SupDelNote() As String
            Get
                Return Me.supDelNoteField
            End Get
            Set
                Me.supDelNoteField = value
            End Set
        End Property
        
        Public Property Certificate() As String
            Get
                Return Me.certificateField
            End Get
            Set
                Me.certificateField = value
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
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property InspNarration() As String
            Get
                Return Me.inspNarrationField
            End Get
            Set
                Me.inspNarrationField = value
            End Set
        End Property
        
        Public Property LctFlag() As String
            Get
                Return Me.lctFlagField
            End Get
            Set
                Me.lctFlagField = value
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
        
        Public Property ExpiryDate() As String
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = value
            End Set
        End Property
        
        Public Property QtyOnSite() As String
            Get
                Return Me.qtyOnSiteField
            End Get
            Set
                Me.qtyOnSiteField = value
            End Set
        End Property
        
        Public Property QtyOffSite() As String
            Get
                Return Me.qtyOffSiteField
            End Get
            Set
                Me.qtyOffSiteField = value
            End Set
        End Property
        
        Public Property CommittedValue() As String
            Get
                Return Me.committedValueField
            End Get
            Set
                Me.committedValueField = value
            End Set
        End Property
        
        Public Property QtyAdvised() As String
            Get
                Return Me.qtyAdvisedField
            End Get
            Set
                Me.qtyAdvisedField = value
            End Set
        End Property
        
        Public Property QtyInspected() As String
            Get
                Return Me.qtyInspectedField
            End Get
            Set
                Me.qtyInspectedField = value
            End Set
        End Property
        
        Public Property QtyCounted() As String
            Get
                Return Me.qtyCountedField
            End Get
            Set
                Me.qtyCountedField = value
            End Set
        End Property
        
        Public Property CountCompleted() As String
            Get
                Return Me.countCompletedField
            End Get
            Set
                Me.countCompletedField = value
            End Set
        End Property
        
        Public Property InspectionCompleted() As String
            Get
                Return Me.inspectionCompletedField
            End Get
            Set
                Me.inspectionCompletedField = value
            End Set
        End Property
        
        Public Property QtyAccepted() As String
            Get
                Return Me.qtyAcceptedField
            End Get
            Set
                Me.qtyAcceptedField = value
            End Set
        End Property
        
        Public Property QtyScrapped() As String
            Get
                Return Me.qtyScrappedField
            End Get
            Set
                Me.qtyScrappedField = value
            End Set
        End Property
        
        Public Property QtyRejected() As String
            Get
                Return Me.qtyRejectedField
            End Get
            Set
                Me.qtyRejectedField = value
            End Set
        End Property
        
        Public Property PoPrice() As String
            Get
                Return Me.poPriceField
            End Get
            Set
                Me.poPriceField = value
            End Set
        End Property
        
        Public Property PriceFactor() As String
            Get
                Return Me.priceFactorField
            End Get
            Set
                Me.priceFactorField = value
            End Set
        End Property
        
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        Public Property ConvFactPriceUom() As String
            Get
                Return Me.convFactPriceUomField
            End Get
            Set
                Me.convFactPriceUomField = value
            End Set
        End Property
        
        Public Property OrderFactor() As String
            Get
                Return Me.orderFactorField
            End Get
            Set
                Me.orderFactorField = value
            End Set
        End Property
        
        Public Property OrderUom() As String
            Get
                Return Me.orderUomField
            End Get
            Set
                Me.orderUomField = value
            End Set
        End Property
        
        Public Property ConvFactOrdUom() As String
            Get
                Return Me.convFactOrdUomField
            End Get
            Set
                Me.convFactOrdUomField = value
            End Set
        End Property
        
        Public Property DiscLPct1() As String
            Get
                Return Me.discLPct1Field
            End Get
            Set
                Me.discLPct1Field = value
            End Set
        End Property
        
        Public Property DiscLPct2() As String
            Get
                Return Me.discLPct2Field
            End Get
            Set
                Me.discLPct2Field = value
            End Set
        End Property
        
        Public Property DiscLPct3() As String
            Get
                Return Me.discLPct3Field
            End Get
            Set
                Me.discLPct3Field = value
            End Set
        End Property
        
        Public Property DiscLValFlag() As String
            Get
                Return Me.discLValFlagField
            End Get
            Set
                Me.discLValFlagField = value
            End Set
        End Property
        
        Public Property DiscLValue() As String
            Get
                Return Me.discLValueField
            End Get
            Set
                Me.discLValueField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("TransactionDetail")>  _
        Public Property TransactionDetailCollection() As List(Of PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail)
            Get
                Return Me.transactionDetailField
            End Get
            Set
                Me.transactionDetailField = value
            End Set
        End Property
        
        Public Property SerialItem() As PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem
            Get
                Return Me.serialItemField
            End Get
            Set
                Me.serialItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemTransactionDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private concessionNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnSupFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnSupplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectScrapCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectNarrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapGLCodeField As String
        
        Public Property TrnType() As String
            Get
                Return Me.trnTypeField
            End Get
            Set
                Me.trnTypeField = value
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
        
        Public Property DocumentNum() As String
            Get
                Return Me.documentNumField
            End Get
            Set
                Me.documentNumField = value
            End Set
        End Property
        
        Public Property ConcessionNum() As String
            Get
                Return Me.concessionNumField
            End Get
            Set
                Me.concessionNumField = value
            End Set
        End Property
        
        Public Property ReturnSupFlag() As String
            Get
                Return Me.returnSupFlagField
            End Get
            Set
                Me.returnSupFlagField = value
            End Set
        End Property
        
        Public Property ReturnSupplier() As String
            Get
                Return Me.returnSupplierField
            End Get
            Set
                Me.returnSupplierField = value
            End Set
        End Property
        
        Public Property RejectScrapCode() As String
            Get
                Return Me.rejectScrapCodeField
            End Get
            Set
                Me.rejectScrapCodeField = value
            End Set
        End Property
        
        Public Property RejectNarration() As String
            Get
                Return Me.rejectNarrationField
            End Get
            Set
                Me.rejectNarrationField = value
            End Set
        End Property
        
        Public Property ScrapGLCode() As String
            Get
                Return Me.scrapGLCodeField
            End Get
            Set
                Me.scrapGLCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorInspectionInspectionItemWarehouseItemStockCodeItemGrnItemSerialItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        Public Property Serial() As String
            Get
                Return Me.serialField
            End Get
            Set
                Me.serialField = value
            End Set
        End Property
        
        Public Property Status() As String
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
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
    End Class
End Namespace
