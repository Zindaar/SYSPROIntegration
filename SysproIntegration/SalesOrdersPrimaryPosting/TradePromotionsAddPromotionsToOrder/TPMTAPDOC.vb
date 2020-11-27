Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.TradePromotionsAddPromotionsToOrder.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostTradePromotionsForSalesOrders
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostTradePromotionsForSalesOrdersItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostTradePromotionsForSalesOrdersItem)()
            End If
            
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostTradePromotionsForSalesOrdersItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "TPMTAP"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters()
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostTradePromotionsForSalesOrders
                objParams = New Params.PostTradePromotionsForSalesOrders()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostTradePromotionsForSalesOrdersItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderEntryField As PostTradePromotionsForSalesOrdersItemSalesOrderEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLinesField As List(Of PostTradePromotionsForSalesOrdersItemSalesOrderLinesLineTradePromotions)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private globalTradePromotionsField As PostTradePromotionsForSalesOrdersItemGlobalTradePromotions
        
        Public Sub New()
            MyBase.New
            If (Me.globalTradePromotionsField Is Nothing) Then
                Me.globalTradePromotionsField = New PostTradePromotionsForSalesOrdersItemGlobalTradePromotions()
            End If
            If (Me.salesOrderLinesField Is Nothing) Then
                Me.salesOrderLinesField = New List(Of PostTradePromotionsForSalesOrdersItemSalesOrderLinesLineTradePromotions)()
            End If
            If (Me.salesOrderEntryField Is Nothing) Then
                Me.salesOrderEntryField = New PostTradePromotionsForSalesOrdersItemSalesOrderEntry()
            End If
        End Sub
        
        Public Property SalesOrderEntry() As PostTradePromotionsForSalesOrdersItemSalesOrderEntry
            Get
                Return Me.salesOrderEntryField
            End Get
            Set
                Me.salesOrderEntryField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("LineTradePromotions", GetType(PostTradePromotionsForSalesOrdersItemSalesOrderLinesLineTradePromotions), IsNullable:=false)>  _
        Public Property SalesOrderLinesCollection() As List(Of PostTradePromotionsForSalesOrdersItemSalesOrderLinesLineTradePromotions)
            Get
                Return Me.salesOrderLinesField
            End Get
            Set
                Me.salesOrderLinesField = value
            End Set
        End Property
        
        Public Property GlobalTradePromotions() As PostTradePromotionsForSalesOrdersItemGlobalTradePromotions
            Get
                Return Me.globalTradePromotionsField
            End Get
            Set
                Me.globalTradePromotionsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostTradePromotionsForSalesOrdersItemSalesOrderEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processReservedStockField As PostTradePromotionsForSalesOrdersItemSalesOrderEntryProcessReservedStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processReservedStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoQualifyActionField As PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoQualifyAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderPromoSelectActionField As PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoSelectAction
        
        Public Sub New()
            MyBase.New
            Me.salesOrderPromoQualifyActionField = PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoQualifyAction.W
            Me.salesOrderPromoSelectActionField = PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoSelectAction.A
        End Sub
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property ProcessReservedStock() As PostTradePromotionsForSalesOrdersItemSalesOrderEntryProcessReservedStock
            Get
                Return Me.processReservedStockField
            End Get
            Set
                Me.processReservedStockField = value
                Me.ProcessReservedStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ProcessReservedStockSpecified() As Boolean
            Get
                Return Me.processReservedStockFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoQualifyAction.W)>  _
        Public Property SalesOrderPromoQualifyAction() As PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoQualifyAction
            Get
                Return Me.salesOrderPromoQualifyActionField
            End Get
            Set
                Me.salesOrderPromoQualifyActionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoSelectAction.A)>  _
        Public Property SalesOrderPromoSelectAction() As PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoSelectAction
            Get
                Return Me.salesOrderPromoSelectActionField
            End Get
            Set
                Me.salesOrderPromoSelectActionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostTradePromotionsForSalesOrdersItemSalesOrderEntryProcessReservedStock
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoQualifyAction
        
        '''<remarks/>
        W
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostTradePromotionsForSalesOrdersItemSalesOrderEntrySalesOrderPromoSelectAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostTradePromotionsForSalesOrdersItemSalesOrderLinesLineTradePromotions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tradePromotionCodesField As String
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property TradePromotionCodes() As String
            Get
                Return Me.tradePromotionCodesField
            End Get
            Set
                Me.tradePromotionCodesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostTradePromotionsForSalesOrdersItemGlobalTradePromotions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private globalTradePromotionCodesField As String
        
        Public Property GlobalTradePromotionCodes() As String
            Get
                Return Me.globalTradePromotionCodesField
            End Get
            Set
                Me.globalTradePromotionCodesField = value
            End Set
        End Property
    End Class
End Namespace
