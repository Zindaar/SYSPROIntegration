Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.StockTakeQueries.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockTakeDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As StockTakeDetailSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeDetailField As StockTakeDetailStockCodeDetail
        
        Public Sub New()
            MyBase.New
            If (Me.stockCodeDetailField Is Nothing) Then
                Me.stockCodeDetailField = New StockTakeDetailStockCodeDetail
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New StockTakeDetailSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As StockTakeDetailSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
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
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property StockCodeDetail() As StockTakeDetailStockCodeDetail
            Get
                Return Me.stockCodeDetailField
            End Get
            Set
                Me.stockCodeDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockTakeDetailSystemInformation
        
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
    Partial Public Class StockTakeDetailStockCodeDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("BinDetail", GetType(StockTakeDetailStockCodeDetailBinDetail)),  _
         System.Xml.Serialization.XmlElementAttribute("CapturedQty", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("CapturedValue", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("CostUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ExeptionLine", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("LongDesc", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Mass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("OrigQtyOnHand", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("ProductClass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Reference", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Release", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SavedValue", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("SerialDetail", GetType(StockTakeDetailStockCodeDetailSerialDetail)),  _
         System.Xml.Serialization.XmlElementAttribute("StockCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("StockOnHold", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("StockUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Supplier", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("UnitCost", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("VarianceQty", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("VarianceValue", GetType(Decimal)),  _
         System.Xml.Serialization.XmlElementAttribute("Version", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Volume", GetType(Decimal)),  _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ItemsElementName"),  _
         System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ItemsElementNameCollection() As List(Of ItemsChoiceType)
            Get
                Return Me.itemsElementNameField
            End Get
            Set
                Me.itemsElementNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockTakeDetailStockCodeDetailBinDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origQtyOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capturedQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private varianceQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exeptionLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private savedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capturedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private varianceValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ticketDetailField As StockTakeDetailStockCodeDetailBinDetailTicketDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotDetailField As StockTakeDetailStockCodeDetailBinDetailLotDetail
        
        Public Sub New()
            MyBase.New
            If (Me.lotDetailField Is Nothing) Then
                Me.lotDetailField = New StockTakeDetailStockCodeDetailBinDetailLotDetail
            End If
            If (Me.ticketDetailField Is Nothing) Then
                Me.ticketDetailField = New StockTakeDetailStockCodeDetailBinDetailTicketDetail
            End If
        End Sub
        
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
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
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
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
        
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
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
        
        Public Property OrigQtyOnHand() As String
            Get
                Return Me.origQtyOnHandField
            End Get
            Set
                Me.origQtyOnHandField = value
            End Set
        End Property
        
        Public Property CapturedQty() As String
            Get
                Return Me.capturedQtyField
            End Get
            Set
                Me.capturedQtyField = value
            End Set
        End Property
        
        Public Property VarianceQty() As String
            Get
                Return Me.varianceQtyField
            End Get
            Set
                Me.varianceQtyField = value
            End Set
        End Property
        
        Public Property ExeptionLine() As String
            Get
                Return Me.exeptionLineField
            End Get
            Set
                Me.exeptionLineField = value
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
        
        Public Property SavedValue() As String
            Get
                Return Me.savedValueField
            End Get
            Set
                Me.savedValueField = value
            End Set
        End Property
        
        Public Property CapturedValue() As String
            Get
                Return Me.capturedValueField
            End Get
            Set
                Me.capturedValueField = value
            End Set
        End Property
        
        Public Property VarianceValue() As String
            Get
                Return Me.varianceValueField
            End Get
            Set
                Me.varianceValueField = value
            End Set
        End Property
        
        Public Property TicketDetail() As StockTakeDetailStockCodeDetailBinDetailTicketDetail
            Get
                Return Me.ticketDetailField
            End Get
            Set
                Me.ticketDetailField = value
            End Set
        End Property
        
        Public Property LotDetail() As StockTakeDetailStockCodeDetailBinDetailLotDetail
            Get
                Return Me.lotDetailField
            End Get
            Set
                Me.lotDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockTakeDetailStockCodeDetailBinDetailTicketDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ticketNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyCapturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timesCapturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomField As String
        
        Public Property TicketNum() As String
            Get
                Return Me.ticketNumField
            End Get
            Set
                Me.ticketNumField = value
            End Set
        End Property
        
        Public Property QtyCaptured() As String
            Get
                Return Me.qtyCapturedField
            End Get
            Set
                Me.qtyCapturedField = value
            End Set
        End Property
        
        Public Property TimesCaptured() As String
            Get
                Return Me.timesCapturedField
            End Get
            Set
                Me.timesCapturedField = value
            End Set
        End Property
        
        Public Property Uom() As String
            Get
                Return Me.uomField
            End Get
            Set
                Me.uomField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockTakeDetailStockCodeDetailBinDetailLotDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private savedQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capturedQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private varianceQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private savedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capturedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private varianceValueField As String
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        Public Property SavedQty() As String
            Get
                Return Me.savedQtyField
            End Get
            Set
                Me.savedQtyField = value
            End Set
        End Property
        
        Public Property CapturedQty() As String
            Get
                Return Me.capturedQtyField
            End Get
            Set
                Me.capturedQtyField = value
            End Set
        End Property
        
        Public Property VarianceQty() As String
            Get
                Return Me.varianceQtyField
            End Get
            Set
                Me.varianceQtyField = value
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
        
        Public Property SavedValue() As String
            Get
                Return Me.savedValueField
            End Get
            Set
                Me.savedValueField = value
            End Set
        End Property
        
        Public Property CapturedValue() As String
            Get
                Return Me.capturedValueField
            End Get
            Set
                Me.capturedValueField = value
            End Set
        End Property
        
        Public Property VarianceValue() As String
            Get
                Return Me.varianceValueField
            End Get
            Set
                Me.varianceValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockTakeDetailStockCodeDetailSerialDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialItemField As StockTakeDetailStockCodeDetailSerialDetailSerialItem
        
        Public Sub New()
            MyBase.New
            If (Me.serialItemField Is Nothing) Then
                Me.serialItemField = New StockTakeDetailStockCodeDetailSerialDetailSerialItem
            End If
        End Sub
        
        Public Property SerialItem() As StockTakeDetailStockCodeDetailSerialDetailSerialItem
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
    Partial Public Class StockTakeDetailStockCodeDetailSerialDetailSerialItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private savedOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyCapturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private varianceQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
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
        
        Public Property SavedOnHand() As String
            Get
                Return Me.savedOnHandField
            End Get
            Set
                Me.savedOnHandField = value
            End Set
        End Property
        
        Public Property QtyCaptured() As String
            Get
                Return Me.qtyCapturedField
            End Get
            Set
                Me.qtyCapturedField = value
            End Set
        End Property
        
        Public Property VarianceQty() As String
            Get
                Return Me.varianceQtyField
            End Get
            Set
                Me.varianceQtyField = value
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
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType
        
        '''<remarks/>
        BinDetail
        
        '''<remarks/>
        CapturedQty
        
        '''<remarks/>
        CapturedValue
        
        '''<remarks/>
        CostUom
        
        '''<remarks/>
        Description
        
        '''<remarks/>
        ExeptionLine
        
        '''<remarks/>
        LongDesc
        
        '''<remarks/>
        Mass
        
        '''<remarks/>
        OrigQtyOnHand
        
        '''<remarks/>
        ProductClass
        
        '''<remarks/>
        Reference
        
        '''<remarks/>
        Release
        
        '''<remarks/>
        SavedValue
        
        '''<remarks/>
        SerialDetail
        
        '''<remarks/>
        StockCode
        
        '''<remarks/>
        StockOnHold
        
        '''<remarks/>
        StockUom
        
        '''<remarks/>
        Supplier
        
        '''<remarks/>
        UnitCost
        
        '''<remarks/>
        VarianceQty
        
        '''<remarks/>
        VarianceValue
        
        '''<remarks/>
        Version
        
        '''<remarks/>
        Volume
    End Enum
End Namespace
