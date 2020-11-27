Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.SalesOrderQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SorDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType2)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType2)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("AlternateKey", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("Area", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Branch", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Commissions", GetType(SorDetailCommissions)),  _
         System.Xml.Serialization.XmlElementAttribute("CompanyTaxNo", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ConsolidatedOrder", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("CounterSalesFlag", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("CountyZip", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("CreditedInvDate", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("Currency", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomForm", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomForms", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Customer", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomerName", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomerPoNumber", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("DateLastInvPrt", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("DeliveryNote", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("DepositFlag", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("EdiSource", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("EntInvoice", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ExchangeRate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ExtendedTaxCode", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("FixExchangeRate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("GstDeduction", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("GstExemptNum", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("HierarchyFlag", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("InvTermsOverride", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Job", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("JobsExistFlag", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("LastDelNote", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("LastInvoice", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("LastOperator", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MulDiv", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MultShipCode", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("Nationality", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("Operator", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("OrderDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("OrderStatus", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("OrderType", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ProcessFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Quote", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ReqShipDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SALARE_Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SALBRN_Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SALSLS_Name", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrder", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrderInitLine", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrderLine", GetType(SorDetailSalesOrderLine)),  _
         System.Xml.Serialization.XmlElementAttribute("Salesperson", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ScheduledOrdFlag", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("SerialisedFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddress1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddress2", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddress3", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddress4", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddress5", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipPostalCode", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("ShippingInstrs", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SpecialInstrs", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("State", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("SystemInformation", GetType(SorDetailSystemInformation)),  _
         System.Xml.Serialization.XmlElementAttribute("TBLART_Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TaxExemptNumber", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("TimeDelPrtedHh", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TimeDelPrtedMm", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TimeInvPrtedHh", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TimeInvPrtedMm", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TransactionNature", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TransportMode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("WebCreated", GetType(Object)),  _
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
        Public Property ItemsElementNameCollection() As List(Of ItemsChoiceType2)
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
    Partial Public Class SorDetailCommissions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionSales1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson2Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionSales2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson3Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionSales3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson4Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionSales4Field As String
        
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        Public Property CommissionSales1() As String
            Get
                Return Me.commissionSales1Field
            End Get
            Set
                Me.commissionSales1Field = value
            End Set
        End Property
        
        Public Property Salesperson2() As Object
            Get
                Return Me.salesperson2Field
            End Get
            Set
                Me.salesperson2Field = value
            End Set
        End Property
        
        Public Property CommissionSales2() As String
            Get
                Return Me.commissionSales2Field
            End Get
            Set
                Me.commissionSales2Field = value
            End Set
        End Property
        
        Public Property Salesperson3() As Object
            Get
                Return Me.salesperson3Field
            End Get
            Set
                Me.salesperson3Field = value
            End Set
        End Property
        
        Public Property CommissionSales3() As String
            Get
                Return Me.commissionSales3Field
            End Get
            Set
                Me.commissionSales3Field = value
            End Set
        End Property
        
        Public Property Salesperson4() As Object
            Get
                Return Me.salesperson4Field
            End Get
            Set
                Me.salesperson4Field = value
            End Set
        End Property
        
        Public Property CommissionSales4() As String
            Get
                Return Me.commissionSales4Field
            End Get
            Set
                Me.commissionSales4Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeField As SorDetailSalesOrderLineMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightField As SorDetailSalesOrderLineFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As SorDetailSalesOrderLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseField As SorDetailSalesOrderLineMerchandise
        
        Public Sub New()
            MyBase.New
            If (Me.merchandiseField Is Nothing) Then
                Me.merchandiseField = New SorDetailSalesOrderLineMerchandise
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New SorDetailSalesOrderLineCommentLine
            End If
            If (Me.freightField Is Nothing) Then
                Me.freightField = New SorDetailSalesOrderLineFreight
            End If
            If (Me.miscChargeField Is Nothing) Then
                Me.miscChargeField = New SorDetailSalesOrderLineMiscCharge
            End If
        End Sub
        
        Public Property MiscCharge() As SorDetailSalesOrderLineMiscCharge
            Get
                Return Me.miscChargeField
            End Get
            Set
                Me.miscChargeField = value
            End Set
        End Property
        
        Public Property Freight() As SorDetailSalesOrderLineFreight
            Get
                Return Me.freightField
            End Get
            Set
                Me.freightField = value
            End Set
        End Property
        
        Public Property CommentLine() As SorDetailSalesOrderLineCommentLine
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        Public Property Merchandise() As SorDetailSalesOrderLineMerchandise
            Get
                Return Me.merchandiseField
            End Get
            Set
                Me.merchandiseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
        
        Public Property NCommentFromLin() As String
            Get
                Return Me.nCommentFromLinField
            End Get
            Set
                Me.nCommentFromLinField = value
            End Set
        End Property
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
        
        Public Property NCommentFromLin() As String
            Get
                Return Me.nCommentFromLinField
            End Get
            Set
                Me.nCommentFromLinField = value
            End Set
        End Property
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
        
        Public Property NCommentFromLin() As String
            Get
                Return Me.nCommentFromLinField
            End Get
            Set
                Me.nCommentFromLinField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMerchandise
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType1)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType1)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("AttachedItems", GetType(SorDetailSalesOrderLineMerchandiseAttachedItems)),  _
         System.Xml.Serialization.XmlElementAttribute("Bin", GetType(SorDetailSalesOrderLineMerchandiseBin)),  _
         System.Xml.Serialization.XmlElementAttribute("Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("LongDesc", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("Lot", GetType(SorDetailSalesOrderLineMerchandiseLot)),  _
         System.Xml.Serialization.XmlElementAttribute("MBackOrderQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MBin", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MCusSupStkCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MCustRequestDat", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MDiscPct1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MDiscPct2", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MDiscPct3", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MDiscValue", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MHierarchyJob", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MLineShipDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderQtyInStockingUm", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MPrice", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MPriceUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MProductClass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MShipQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockDes", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockQtyToShp", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockUnitMass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockUnitVol", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockingUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MWarehouse", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("OrderLineValue", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrderLine", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Serial", GetType(SorDetailSalesOrderLineMerchandiseSerial)),  _
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
        Public Property ItemsElementNameCollection() As List(Of ItemsChoiceType1)
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
    Partial Public Class SorDetailSalesOrderLineMerchandiseAttachedItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sctItemField As SorDetailSalesOrderLineMerchandiseAttachedItemsSctItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionItemField As SorDetailSalesOrderLineMerchandiseAttachedItemsRequisitionItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As SorDetailSalesOrderLineMerchandiseAttachedItemsPurchaseOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textField Is Nothing) Then
                Me.textField = New List(Of String)
            End If
            If (Me.purchaseOrderField Is Nothing) Then
                Me.purchaseOrderField = New SorDetailSalesOrderLineMerchandiseAttachedItemsPurchaseOrder
            End If
            If (Me.requisitionItemField Is Nothing) Then
                Me.requisitionItemField = New SorDetailSalesOrderLineMerchandiseAttachedItemsRequisitionItem
            End If
            If (Me.sctItemField Is Nothing) Then
                Me.sctItemField = New SorDetailSalesOrderLineMerchandiseAttachedItemsSctItem
            End If
        End Sub
        
        Public Property SctItem() As SorDetailSalesOrderLineMerchandiseAttachedItemsSctItem
            Get
                Return Me.sctItemField
            End Get
            Set
                Me.sctItemField = value
            End Set
        End Property
        
        Public Property RequisitionItem() As SorDetailSalesOrderLineMerchandiseAttachedItemsRequisitionItem
            Get
                Return Me.requisitionItemField
            End Get
            Set
                Me.requisitionItemField = value
            End Set
        End Property
        
        Public Property PurchaseOrder() As SorDetailSalesOrderLineMerchandiseAttachedItemsPurchaseOrder
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
    Partial Public Class SorDetailSalesOrderLineMerchandiseAttachedItemsSctItem
        
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
        
        <System.Xml.Serialization.XmlElementAttribute("LongDesc", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MBackOrderQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MBin", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MCustRequestDat", GetType(Object)),  _
         System.Xml.Serialization.XmlElementAttribute("MLineShipDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderQtyInStockingUm", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MOrderUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MPrice", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MPriceUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MProductClass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MShipQty", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockDes", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockQtyToShp", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockUnitMass", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockUnitVol", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MStockingUom", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MUnitCost", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MWarehouse", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SctOrder", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SctOrderLine", GetType(String)),  _
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
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType
        
        '''<remarks/>
        LongDesc
        
        '''<remarks/>
        MBackOrderQty
        
        '''<remarks/>
        MBin
        
        '''<remarks/>
        MCustRequestDat
        
        '''<remarks/>
        MLineShipDate
        
        '''<remarks/>
        MOrderQty
        
        '''<remarks/>
        MOrderQtyInStockingUm
        
        '''<remarks/>
        MOrderUom
        
        '''<remarks/>
        MPrice
        
        '''<remarks/>
        MPriceUom
        
        '''<remarks/>
        MProductClass
        
        '''<remarks/>
        MShipQty
        
        '''<remarks/>
        MStockCode
        
        '''<remarks/>
        MStockDes
        
        '''<remarks/>
        MStockQtyToShp
        
        '''<remarks/>
        MStockUnitMass
        
        '''<remarks/>
        MStockUnitVol
        
        '''<remarks/>
        MStockingUom
        
        '''<remarks/>
        MUnitCost
        
        '''<remarks/>
        MWarehouse
        
        '''<remarks/>
        SctOrder
        
        '''<remarks/>
        SctOrderLine
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMerchandiseAttachedItemsRequisitionItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForReqnField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lessPlusDiscField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccHoldField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateReqnRaisedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastReceiptField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePoConfirmedField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateActionedField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reqnStatusField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supCatalogueNumField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexNumField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bpoApprovedField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        Public Property Requisition() As String
            Get
                Return Me.requisitionField
            End Get
            Set
                Me.requisitionField = value
            End Set
        End Property
        
        Public Property ReasonForReqn() As Object
            Get
                Return Me.reasonForReqnField
            End Get
            Set
                Me.reasonForReqnField = value
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
        
        Public Property SupplierCurrency() As String
            Get
                Return Me.supplierCurrencyField
            End Get
            Set
                Me.supplierCurrencyField = value
            End Set
        End Property
        
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
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
        
        Public Property GlCode() As Object
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property DiscountCode() As Object
            Get
                Return Me.discountCodeField
            End Get
            Set
                Me.discountCodeField = value
            End Set
        End Property
        
        Public Property LessPlusDisc() As String
            Get
                Return Me.lessPlusDiscField
            End Get
            Set
                Me.lessPlusDiscField = value
            End Set
        End Property
        
        Public Property DiscPct1() As String
            Get
                Return Me.discPct1Field
            End Get
            Set
                Me.discPct1Field = value
            End Set
        End Property
        
        Public Property DiscPct2() As String
            Get
                Return Me.discPct2Field
            End Get
            Set
                Me.discPct2Field = value
            End Set
        End Property
        
        Public Property DiscPct3() As String
            Get
                Return Me.discPct3Field
            End Get
            Set
                Me.discPct3Field = value
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
        
        Public Property EccHold() As Object
            Get
                Return Me.eccHoldField
            End Get
            Set
                Me.eccHoldField = value
            End Set
        End Property
        
        Public Property OrderQty() As String
            Get
                Return Me.orderQtyField
            End Get
            Set
                Me.orderQtyField = value
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
        
        Public Property DateReqnRaised() As String
            Get
                Return Me.dateReqnRaisedField
            End Get
            Set
                Me.dateReqnRaisedField = value
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
        
        Public Property DateLastReceipt() As Object
            Get
                Return Me.dateLastReceiptField
            End Get
            Set
                Me.dateLastReceiptField = value
            End Set
        End Property
        
        Public Property DatePoConfirmed() As Object
            Get
                Return Me.datePoConfirmedField
            End Get
            Set
                Me.datePoConfirmedField = value
            End Set
        End Property
        
        Public Property DateActioned() As Object
            Get
                Return Me.dateActionedField
            End Get
            Set
                Me.dateActionedField = value
            End Set
        End Property
        
        Public Property ReqnStatus() As Object
            Get
                Return Me.reqnStatusField
            End Get
            Set
                Me.reqnStatusField = value
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property SupCatalogueNum() As Object
            Get
                Return Me.supCatalogueNumField
            End Get
            Set
                Me.supCatalogueNumField = value
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
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerPoNumber() As Object
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
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
        
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        Public Property CapexNum() As Object
            Get
                Return Me.capexNumField
            End Get
            Set
                Me.capexNumField = value
            End Set
        End Property
        
        Public Property BpoApproved() As Object
            Get
                Return Me.bpoApprovedField
            End Get
            Set
                Me.bpoApprovedField = value
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
        
        Public Property Job() As String
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
    Partial Public Class SorDetailSalesOrderLineMerchandiseAttachedItemsPurchaseOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr4Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr5Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supPostalCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr3Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr4Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr5Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postalCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderEntryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentTermsField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscountField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amendedCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentFormatField As String
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
        
        Public Property SupplierClass() As String
            Get
                Return Me.supplierClassField
            End Get
            Set
                Me.supplierClassField = value
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
        
        Public Property CustomerPoNumber() As Object
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        Public Property SupplierAddr1() As String
            Get
                Return Me.supplierAddr1Field
            End Get
            Set
                Me.supplierAddr1Field = value
            End Set
        End Property
        
        Public Property SupplierAddr2() As String
            Get
                Return Me.supplierAddr2Field
            End Get
            Set
                Me.supplierAddr2Field = value
            End Set
        End Property
        
        Public Property SupplierAddr3() As String
            Get
                Return Me.supplierAddr3Field
            End Get
            Set
                Me.supplierAddr3Field = value
            End Set
        End Property
        
        Public Property SupplierAddr4() As Object
            Get
                Return Me.supplierAddr4Field
            End Get
            Set
                Me.supplierAddr4Field = value
            End Set
        End Property
        
        Public Property SupplierAddr5() As Object
            Get
                Return Me.supplierAddr5Field
            End Get
            Set
                Me.supplierAddr5Field = value
            End Set
        End Property
        
        Public Property SupPostalCode() As Object
            Get
                Return Me.supPostalCodeField
            End Get
            Set
                Me.supPostalCodeField = value
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
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property DeliveryName() As String
            Get
                Return Me.deliveryNameField
            End Get
            Set
                Me.deliveryNameField = value
            End Set
        End Property
        
        Public Property DeliveryAddr1() As String
            Get
                Return Me.deliveryAddr1Field
            End Get
            Set
                Me.deliveryAddr1Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr2() As String
            Get
                Return Me.deliveryAddr2Field
            End Get
            Set
                Me.deliveryAddr2Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr3() As Object
            Get
                Return Me.deliveryAddr3Field
            End Get
            Set
                Me.deliveryAddr3Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr4() As Object
            Get
                Return Me.deliveryAddr4Field
            End Get
            Set
                Me.deliveryAddr4Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr5() As Object
            Get
                Return Me.deliveryAddr5Field
            End Get
            Set
                Me.deliveryAddr5Field = value
            End Set
        End Property
        
        Public Property PostalCode() As Object
            Get
                Return Me.postalCodeField
            End Get
            Set
                Me.postalCodeField = value
            End Set
        End Property
        
        Public Property OrderStatus() As String
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
            End Set
        End Property
        
        Public Property OrderEntryDate() As String
            Get
                Return Me.orderEntryDateField
            End Get
            Set
                Me.orderEntryDateField = value
            End Set
        End Property
        
        Public Property OrderDueDate() As String
            Get
                Return Me.orderDueDateField
            End Get
            Set
                Me.orderDueDateField = value
            End Set
        End Property
        
        Public Property MemoDate() As String
            Get
                Return Me.memoDateField
            End Get
            Set
                Me.memoDateField = value
            End Set
        End Property
        
        Public Property MemoCode() As Object
            Get
                Return Me.memoCodeField
            End Get
            Set
                Me.memoCodeField = value
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
        
        Public Property PaymentTerms() As Object
            Get
                Return Me.paymentTermsField
            End Get
            Set
                Me.paymentTermsField = value
            End Set
        End Property
        
        Public Property TaxStatus() As String
            Get
                Return Me.taxStatusField
            End Get
            Set
                Me.taxStatusField = value
            End Set
        End Property
        
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        Public Property OrderDiscount() As Object
            Get
                Return Me.orderDiscountField
            End Get
            Set
                Me.orderDiscountField = value
            End Set
        End Property
        
        Public Property AmendedCount() As String
            Get
                Return Me.amendedCountField
            End Get
            Set
                Me.amendedCountField = value
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
        
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        Public Property DocumentFormat() As String
            Get
                Return Me.documentFormatField
            End Get
            Set
                Me.documentFormatField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMerchandiseBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
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
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMerchandiseLot
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private certificateField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As Object
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        Public Property Certificate() As Object
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
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
        
        Public Property LotExpiryDate() As Object
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSalesOrderLineMerchandiseSerial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newExpiryDateField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
        Public Property Serial() As String
            Get
                Return Me.serialField
            End Get
            Set
                Me.serialField = value
            End Set
        End Property
        
        Public Property Lot() As Object
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        Public Property NewExpiryDate() As Object
            Get
                Return Me.newExpiryDateField
            End Get
            Set
                Me.newExpiryDateField = value
            End Set
        End Property
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType1
        
        '''<remarks/>
        AttachedItems
        
        '''<remarks/>
        Bin
        
        '''<remarks/>
        Description
        
        '''<remarks/>
        LongDesc
        
        '''<remarks/>
        Lot
        
        '''<remarks/>
        MBackOrderQty
        
        '''<remarks/>
        MBin
        
        '''<remarks/>
        MCusSupStkCode
        
        '''<remarks/>
        MCustRequestDat
        
        '''<remarks/>
        MDiscPct1
        
        '''<remarks/>
        MDiscPct2
        
        '''<remarks/>
        MDiscPct3
        
        '''<remarks/>
        MDiscValue
        
        '''<remarks/>
        MHierarchyJob
        
        '''<remarks/>
        MLineShipDate
        
        '''<remarks/>
        MOrderQty
        
        '''<remarks/>
        MOrderQtyInStockingUm
        
        '''<remarks/>
        MOrderUom
        
        '''<remarks/>
        MPrice
        
        '''<remarks/>
        MPriceUom
        
        '''<remarks/>
        MProductClass
        
        '''<remarks/>
        MShipQty
        
        '''<remarks/>
        MStockCode
        
        '''<remarks/>
        MStockDes
        
        '''<remarks/>
        MStockQtyToShp
        
        '''<remarks/>
        MStockUnitMass
        
        '''<remarks/>
        MStockUnitVol
        
        '''<remarks/>
        MStockingUom
        
        '''<remarks/>
        MWarehouse
        
        '''<remarks/>
        OrderLineValue
        
        '''<remarks/>
        SalesOrderLine
        
        '''<remarks/>
        Serial
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorDetailSystemInformation
        
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
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
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
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType2
        
        '''<remarks/>
        AlternateKey
        
        '''<remarks/>
        Area
        
        '''<remarks/>
        Branch
        
        '''<remarks/>
        Commissions
        
        '''<remarks/>
        CompanyTaxNo
        
        '''<remarks/>
        ConsolidatedOrder
        
        '''<remarks/>
        CounterSalesFlag
        
        '''<remarks/>
        CountyZip
        
        '''<remarks/>
        CreditedInvDate
        
        '''<remarks/>
        Currency
        
        '''<remarks/>
        CustomForm
        
        '''<remarks/>
        CustomForms
        
        '''<remarks/>
        Customer
        
        '''<remarks/>
        CustomerName
        
        '''<remarks/>
        CustomerPoNumber
        
        '''<remarks/>
        DateLastInvPrt
        
        '''<remarks/>
        DeliveryNote
        
        '''<remarks/>
        DeliveryTerms
        
        '''<remarks/>
        DepositFlag
        
        '''<remarks/>
        EdiSource
        
        '''<remarks/>
        EntInvoice
        
        '''<remarks/>
        ExchangeRate
        
        '''<remarks/>
        ExtendedTaxCode
        
        '''<remarks/>
        FixExchangeRate
        
        '''<remarks/>
        GstDeduction
        
        '''<remarks/>
        GstExemptNum
        
        '''<remarks/>
        HierarchyFlag
        
        '''<remarks/>
        InvTermsOverride
        
        '''<remarks/>
        Job
        
        '''<remarks/>
        JobsExistFlag
        
        '''<remarks/>
        LastDelNote
        
        '''<remarks/>
        LastInvoice
        
        '''<remarks/>
        LastOperator
        
        '''<remarks/>
        MulDiv
        
        '''<remarks/>
        MultShipCode
        
        '''<remarks/>
        Nationality
        
        '''<remarks/>
        [Operator]
        
        '''<remarks/>
        OrderDate
        
        '''<remarks/>
        OrderStatus
        
        '''<remarks/>
        OrderType
        
        '''<remarks/>
        ProcessFlag
        
        '''<remarks/>
        Quote
        
        '''<remarks/>
        ReqShipDate
        
        '''<remarks/>
        SALARE_Description
        
        '''<remarks/>
        SALBRN_Description
        
        '''<remarks/>
        SALSLS_Name
        
        '''<remarks/>
        SalesOrder
        
        '''<remarks/>
        SalesOrderInitLine
        
        '''<remarks/>
        SalesOrderLine
        
        '''<remarks/>
        Salesperson
        
        '''<remarks/>
        ScheduledOrdFlag
        
        '''<remarks/>
        SerialisedFlag
        
        '''<remarks/>
        ShipAddress1
        
        '''<remarks/>
        ShipAddress2
        
        '''<remarks/>
        ShipAddress3
        
        '''<remarks/>
        ShipAddress4
        
        '''<remarks/>
        ShipAddress5
        
        '''<remarks/>
        ShipPostalCode
        
        '''<remarks/>
        ShippingInstrs
        
        '''<remarks/>
        SpecialInstrs
        
        '''<remarks/>
        State
        
        '''<remarks/>
        SystemInformation
        
        '''<remarks/>
        TBLART_Description
        
        '''<remarks/>
        TaxExemptNumber
        
        '''<remarks/>
        TimeDelPrtedHh
        
        '''<remarks/>
        TimeDelPrtedMm
        
        '''<remarks/>
        TimeInvPrtedHh
        
        '''<remarks/>
        TimeInvPrtedMm
        
        '''<remarks/>
        TransactionNature
        
        '''<remarks/>
        TransportMode
        
        '''<remarks/>
        WebCreated
    End Enum
End Namespace
