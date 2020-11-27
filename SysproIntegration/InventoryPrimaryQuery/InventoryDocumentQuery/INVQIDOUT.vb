Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryDocumentQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InventoryDocuments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As InventoryDocumentsSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inventoryDocumentField As List(Of InventoryDocumentsInventoryDocument)
        
        Public Sub New()
            MyBase.New
            If (Me.inventoryDocumentField Is Nothing) Then
                Me.inventoryDocumentField = New List(Of InventoryDocumentsInventoryDocument)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New InventoryDocumentsSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As InventoryDocumentsSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("InventoryDocument")>  _
        Public Property InventoryDocumentCollection() As List(Of InventoryDocumentsInventoryDocument)
            Get
                Return Me.inventoryDocumentField
            End Get
            Set
                Me.inventoryDocumentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsSystemInformation
        
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
    Partial Public Class InventoryDocumentsInventoryDocument
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headerField As InventoryDocumentsInventoryDocumentHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private detailLineField As InventoryDocumentsInventoryDocumentDetailLine
        
        Public Sub New()
            MyBase.New
            If (Me.detailLineField Is Nothing) Then
                Me.detailLineField = New InventoryDocumentsInventoryDocumentDetailLine
            End If
            If (Me.headerField Is Nothing) Then
                Me.headerField = New InventoryDocumentsInventoryDocumentHeader
            End If
        End Sub
        
        Public Property Header() As InventoryDocumentsInventoryDocumentHeader
            Get
                Return Me.headerField
            End Get
            Set
                Me.headerField = value
            End Set
        End Property
        
        Public Property DetailLine() As InventoryDocumentsInventoryDocumentDetailLine
            Get
                Return Me.detailLineField
            End Get
            Set
                Me.detailLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDeliveryAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDeliveryAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDeliveryAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDeliveryAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDeliveryAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private interWhLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expectedDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gitReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printStatusField As String
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property DocumentType() As String
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
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
        
        Public Property SystemTime() As String
            Get
                Return Me.systemTimeField
            End Get
            Set
                Me.systemTimeField = value
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
        
        Public Property Grn() As String
            Get
                Return Me.grnField
            End Get
            Set
                Me.grnField = value
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property WarehouseName() As String
            Get
                Return Me.warehouseNameField
            End Get
            Set
                Me.warehouseNameField = value
            End Set
        End Property
        
        Public Property WhDeliveryAddr1() As String
            Get
                Return Me.whDeliveryAddr1Field
            End Get
            Set
                Me.whDeliveryAddr1Field = value
            End Set
        End Property
        
        Public Property WhDeliveryAddr2() As String
            Get
                Return Me.whDeliveryAddr2Field
            End Get
            Set
                Me.whDeliveryAddr2Field = value
            End Set
        End Property
        
        Public Property WhDeliveryAddr3() As String
            Get
                Return Me.whDeliveryAddr3Field
            End Get
            Set
                Me.whDeliveryAddr3Field = value
            End Set
        End Property
        
        Public Property WhDeliveryAddr4() As String
            Get
                Return Me.whDeliveryAddr4Field
            End Get
            Set
                Me.whDeliveryAddr4Field = value
            End Set
        End Property
        
        Public Property WhDeliveryAddr5() As String
            Get
                Return Me.whDeliveryAddr5Field
            End Get
            Set
                Me.whDeliveryAddr5Field = value
            End Set
        End Property
        
        Public Property PostalCode() As String
            Get
                Return Me.postalCodeField
            End Get
            Set
                Me.postalCodeField = value
            End Set
        End Property
        
        Public Property WarehouseContact() As String
            Get
                Return Me.warehouseContactField
            End Get
            Set
                Me.warehouseContactField = value
            End Set
        End Property
        
        Public Property WarehouseFax() As String
            Get
                Return Me.warehouseFaxField
            End Get
            Set
                Me.warehouseFaxField = value
            End Set
        End Property
        
        Public Property SourceWarehouse() As String
            Get
                Return Me.sourceWarehouseField
            End Get
            Set
                Me.sourceWarehouseField = value
            End Set
        End Property
        
        Public Property SourceWarehouseName() As String
            Get
                Return Me.sourceWarehouseNameField
            End Get
            Set
                Me.sourceWarehouseNameField = value
            End Set
        End Property
        
        Public Property InterWhLeadTime() As String
            Get
                Return Me.interWhLeadTimeField
            End Get
            Set
                Me.interWhLeadTimeField = value
            End Set
        End Property
        
        Public Property ExpectedDate() As String
            Get
                Return Me.expectedDateField
            End Get
            Set
                Me.expectedDateField = value
            End Set
        End Property
        
        Public Property GitReference() As String
            Get
                Return Me.gitReferenceField
            End Get
            Set
                Me.gitReferenceField = value
            End Set
        End Property
        
        Public Property PrintStatus() As String
            Get
                Return Me.printStatusField
            End Get
            Set
                Me.printStatusField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnWhField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transferFromWhField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private concessionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glcodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private technicalSpecificationField As InventoryDocumentsInventoryDocumentDetailLineTechnicalSpecification
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionTextField As InventoryDocumentsInventoryDocumentDetailLineInspectionText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderTextField As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderCommentField As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderComment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionField As InventoryDocumentsInventoryDocumentDetailLineRequisition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private suppliersDelNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private catalogueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnSourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As InventoryDocumentsInventoryDocumentDetailLineSerials
        
        Public Sub New()
            MyBase.New
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New InventoryDocumentsInventoryDocumentDetailLineSerials
            End If
            If (Me.purchaseOrderField Is Nothing) Then
                Me.purchaseOrderField = New InventoryDocumentsInventoryDocumentDetailLinePurchaseOrder
            End If
            If (Me.requisitionField Is Nothing) Then
                Me.requisitionField = New InventoryDocumentsInventoryDocumentDetailLineRequisition
            End If
            If (Me.purchaseOrderCommentField Is Nothing) Then
                Me.purchaseOrderCommentField = New InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderComment
            End If
            If (Me.purchaseOrderTextField Is Nothing) Then
                Me.purchaseOrderTextField = New InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderText
            End If
            If (Me.inspectionTextField Is Nothing) Then
                Me.inspectionTextField = New InventoryDocumentsInventoryDocumentDetailLineInspectionText
            End If
            If (Me.technicalSpecificationField Is Nothing) Then
                Me.technicalSpecificationField = New InventoryDocumentsInventoryDocumentDetailLineTechnicalSpecification
            End If
        End Sub
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
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
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
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
        
        Public Property TrnQty() As String
            Get
                Return Me.trnQtyField
            End Get
            Set
                Me.trnQtyField = value
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
        
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        Public Property TrnMass() As String
            Get
                Return Me.trnMassField
            End Get
            Set
                Me.trnMassField = value
            End Set
        End Property
        
        Public Property TrnVolume() As String
            Get
                Return Me.trnVolumeField
            End Get
            Set
                Me.trnVolumeField = value
            End Set
        End Property
        
        Public Property TrnDate() As String
            Get
                Return Me.trnDateField
            End Get
            Set
                Me.trnDateField = value
            End Set
        End Property
        
        Public Property TrnWh() As String
            Get
                Return Me.trnWhField
            End Get
            Set
                Me.trnWhField = value
            End Set
        End Property
        
        Public Property TrnReference() As String
            Get
                Return Me.trnReferenceField
            End Get
            Set
                Me.trnReferenceField = value
            End Set
        End Property
        
        Public Property TransferFromWh() As String
            Get
                Return Me.transferFromWhField
            End Get
            Set
                Me.transferFromWhField = value
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
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        Public Property ConcessionNumber() As String
            Get
                Return Me.concessionNumberField
            End Get
            Set
                Me.concessionNumberField = value
            End Set
        End Property
        
        Public Property Glcode() As String
            Get
                Return Me.glcodeField
            End Get
            Set
                Me.glcodeField = value
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
        
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
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
        
        Public Property TechnicalSpecification() As InventoryDocumentsInventoryDocumentDetailLineTechnicalSpecification
            Get
                Return Me.technicalSpecificationField
            End Get
            Set
                Me.technicalSpecificationField = value
            End Set
        End Property
        
        Public Property InspectionText() As InventoryDocumentsInventoryDocumentDetailLineInspectionText
            Get
                Return Me.inspectionTextField
            End Get
            Set
                Me.inspectionTextField = value
            End Set
        End Property
        
        Public Property PurchaseOrderText() As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderText
            Get
                Return Me.purchaseOrderTextField
            End Get
            Set
                Me.purchaseOrderTextField = value
            End Set
        End Property
        
        Public Property PurchaseOrderComment() As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderComment
            Get
                Return Me.purchaseOrderCommentField
            End Get
            Set
                Me.purchaseOrderCommentField = value
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
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property RejectCode() As String
            Get
                Return Me.rejectCodeField
            End Get
            Set
                Me.rejectCodeField = value
            End Set
        End Property
        
        Public Property Requisition() As InventoryDocumentsInventoryDocumentDetailLineRequisition
            Get
                Return Me.requisitionField
            End Get
            Set
                Me.requisitionField = value
            End Set
        End Property
        
        Public Property PurchaseOrder() As InventoryDocumentsInventoryDocumentDetailLinePurchaseOrder
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property SuppliersDelNote() As String
            Get
                Return Me.suppliersDelNoteField
            End Get
            Set
                Me.suppliersDelNoteField = value
            End Set
        End Property
        
        Public Property Catalogue() As String
            Get
                Return Me.catalogueField
            End Get
            Set
                Me.catalogueField = value
            End Set
        End Property
        
        Public Property DrGlCode() As String
            Get
                Return Me.drGlCodeField
            End Get
            Set
                Me.drGlCodeField = value
            End Set
        End Property
        
        Public Property GrnSource() As String
            Get
                Return Me.grnSourceField
            End Get
            Set
                Me.grnSourceField = value
            End Set
        End Property
        
        Public Property Serials() As InventoryDocumentsInventoryDocumentDetailLineSerials
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLineTechnicalSpecification
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textItemField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textItemField Is Nothing) Then
                Me.textItemField = New List(Of String)
            End If
        End Sub
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property TextItemCollection() As List(Of String)
            Get
                Return Me.textItemField
            End Get
            Set
                Me.textItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLineInspectionText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textItemField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textItemField Is Nothing) Then
                Me.textItemField = New List(Of String)
            End If
        End Sub
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property TextItemCollection() As List(Of String)
            Get
                Return Me.textItemField
            End Get
            Set
                Me.textItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textItemField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textItemField Is Nothing) Then
                Me.textItemField = New List(Of String)
            End If
        End Sub
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property TextItemCollection() As List(Of String)
            Get
                Return Me.textItemField
            End Get
            Set
                Me.textItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLinePurchaseOrderComment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textItemField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textItemField Is Nothing) Then
                Me.textItemField = New List(Of String)
            End If
        End Sub
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property TextItemCollection() As List(Of String)
            Get
                Return Me.textItemField
            End Get
            Set
                Me.textItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLineRequisition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorField As String
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        Public Property Number() As String
            Get
                Return Me.numberField
            End Get
            Set
                Me.numberField = value
            End Set
        End Property
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLinePurchaseOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonMerchandiseValueField As String
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
        
        Public Property LineDueDate() As String
            Get
                Return Me.lineDueDateField
            End Get
            Set
                Me.lineDueDateField = value
            End Set
        End Property
        
        Public Property OriginalQty() As String
            Get
                Return Me.originalQtyField
            End Get
            Set
                Me.originalQtyField = value
            End Set
        End Property
        
        Public Property OutstandingQty() As String
            Get
                Return Me.outstandingQtyField
            End Get
            Set
                Me.outstandingQtyField = value
            End Set
        End Property
        
        Public Property MerchandiseValue() As String
            Get
                Return Me.merchandiseValueField
            End Get
            Set
                Me.merchandiseValueField = value
            End Set
        End Property
        
        Public Property NonMerchandiseValue() As String
            Get
                Return Me.nonMerchandiseValueField
            End Get
            Set
                Me.nonMerchandiseValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLineSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialItemField As InventoryDocumentsInventoryDocumentDetailLineSerialsSerialItem
        
        Public Sub New()
            MyBase.New
            If (Me.serialItemField Is Nothing) Then
                Me.serialItemField = New InventoryDocumentsInventoryDocumentDetailLineSerialsSerialItem
            End If
        End Sub
        
        Public Property SerialItem() As InventoryDocumentsInventoryDocumentDetailLineSerialsSerialItem
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
    Partial Public Class InventoryDocumentsInventoryDocumentDetailLineSerialsSerialItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        Public Property ItemNumber() As String
            Get
                Return Me.itemNumberField
            End Get
            Set
                Me.itemNumberField = value
            End Set
        End Property
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
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
End Namespace
