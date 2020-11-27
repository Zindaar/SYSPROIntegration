Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderSupplyChainTransfer.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSalesOrdersSCT
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersField As List(Of PostSalesOrdersSCTOrders)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostSalesOrdersSCTParameters
        
        Public Sub New()
            MyBase.New
            If (Me.ordersField Is Nothing) Then
                Me.ordersField = New List(Of PostSalesOrdersSCTOrders)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Orders")>  _
        Public Property OrdersCollection() As List(Of PostSalesOrdersSCTOrders)
            Get
                Return Me.ordersField
            End Get
            Set
                Me.ordersField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTTR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostSalesOrdersSCTParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostSalesOrdersSCTParameters
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
                Dim objParams As Params.PostSalesOrdersSCT
                objParams = New Params.PostSalesOrdersSCT
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderHeaderField As PostSalesOrdersSCTOrdersOrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDetailsField As PostSalesOrdersSCTOrdersOrderDetails
        
        Public Sub New()
            MyBase.New
            If (Me.orderDetailsField Is Nothing) Then
                Me.orderDetailsField = New PostSalesOrdersSCTOrdersOrderDetails
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New PostSalesOrdersSCTOrdersOrderHeader
            End If
        End Sub
        
        Public Property OrderHeader() As PostSalesOrdersSCTOrdersOrderHeader
            Get
                Return Me.orderHeaderField
            End Get
            Set
                Me.orderHeaderField = value
            End Set
        End Property
        
        Public Property OrderDetails() As PostSalesOrdersSCTOrdersOrderDetails
            Get
                Return Me.orderDetailsField
            End Get
            Set
                Me.orderDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrdersOrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private targetWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderCommentsField As List(Of PostSalesOrdersSCTOrdersOrderHeaderOrderComments)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            If (Me.orderCommentsField Is Nothing) Then
                Me.orderCommentsField = New List(Of PostSalesOrdersSCTOrdersOrderHeaderOrderComments)
            End If
        End Sub
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
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
        
        Public Property TargetWarehouse() As String
            Get
                Return Me.targetWarehouseField
            End Get
            Set
                Me.targetWarehouseField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property OrderDate() As Date
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
                Me.OrderDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderDateSpecified() As Boolean
            Get
                Return Me.orderDateFieldSpecified
            End Get
        End Property
        
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
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
        
        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = value
            End Set
        End Property
        
        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = value
            End Set
        End Property
        
        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = value
            End Set
        End Property
        
        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = value
            End Set
        End Property
        
        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = value
            End Set
        End Property
        
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
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
        
        <System.Xml.Serialization.XmlElementAttribute("OrderComments")>  _
        Public Property OrderCommentsCollection() As List(Of PostSalesOrdersSCTOrdersOrderHeaderOrderComments)
            Get
                Return Me.orderCommentsField
            End Get
            Set
                Me.orderCommentsField = value
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
        
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrdersOrderHeaderOrderComments
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrdersOrderDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockLineField As List(Of PostSalesOrdersSCTOrdersOrderDetailsStockLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As List(Of PostSalesOrdersSCTOrdersOrderDetailsCommentLine)
        
        Public Sub New()
            MyBase.New
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New List(Of PostSalesOrdersSCTOrdersOrderDetailsCommentLine)
            End If
            If (Me.stockLineField Is Nothing) Then
                Me.stockLineField = New List(Of PostSalesOrdersSCTOrdersOrderDetailsStockLine)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("StockLine")>  _
        Public Property StockLineCollection() As List(Of PostSalesOrdersSCTOrdersOrderDetailsStockLine)
            Get
                Return Me.stockLineField
            End Get
            Set
                Me.stockLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CommentLine")>  _
        Public Property CommentLineCollection() As List(Of PostSalesOrdersSCTOrdersOrderDetailsCommentLine)
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrdersOrderDetailsStockLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineReceiptDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineReceiptDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefinedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitVolumeField As String
        
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
        
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property LineShipDate() As Date
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
                Me.LineShipDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineShipDateSpecified() As Boolean
            Get
                Return Me.lineShipDateFieldSpecified
            End Get
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property LineReceiptDate() As Date
            Get
                Return Me.lineReceiptDateField
            End Get
            Set
                Me.lineReceiptDateField = value
                Me.LineReceiptDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineReceiptDateSpecified() As Boolean
            Get
                Return Me.lineReceiptDateFieldSpecified
            End Get
        End Property
        
        Public Property UserDefined() As String
            Get
                Return Me.userDefinedField
            End Get
            Set
                Me.userDefinedField = value
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
        
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        Public Property UnitVolume() As String
            Get
                Return Me.unitVolumeField
            End Get
            Set
                Me.unitVolumeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrdersSCTOrdersOrderDetailsCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedLineField As PostSalesOrdersSCTOrdersOrderDetailsCommentLineAttachedLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedLineFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeField As PostSalesOrdersSCTOrdersOrderDetailsCommentLineCommentType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeFieldSpecified As Boolean
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property AttachedLine() As PostSalesOrdersSCTOrdersOrderDetailsCommentLineAttachedLine
            Get
                Return Me.attachedLineField
            End Get
            Set
                Me.attachedLineField = value
                Me.AttachedLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AttachedLineSpecified() As Boolean
            Get
                Return Me.attachedLineFieldSpecified
            End Get
        End Property
        
        Public Property CommentType() As PostSalesOrdersSCTOrdersOrderDetailsCommentLineCommentType
            Get
                Return Me.commentTypeField
            End Get
            Set
                Me.commentTypeField = value
                Me.CommentTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CommentTypeSpecified() As Boolean
            Get
                Return Me.commentTypeFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTOrdersOrderDetailsCommentLineAttachedLine
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTOrdersOrderDetailsCommentLineCommentType
        
        '''<remarks/>
        O
        
        '''<remarks/>
        I
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
