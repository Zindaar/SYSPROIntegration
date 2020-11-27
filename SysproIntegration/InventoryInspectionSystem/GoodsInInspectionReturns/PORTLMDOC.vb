Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryInspectionSystem.GoodsInInspectionReturns.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ShipmentMaintenance
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As ShipmentMaintenanceItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.ShipmentMaintenanceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New ShipmentMaintenanceItem
            End If
        End Sub
        
        Public Property Item() As ShipmentMaintenanceItem
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
                Return "PORTLM"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.ShipmentMaintenanceParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.ShipmentMaintenanceParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.ShipmentMaintenance
                objParams = New Params.ShipmentMaintenance
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
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
    Partial Public Class ShipmentMaintenanceItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionField As ShipmentMaintenanceItemAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private vesselField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departureDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipmentReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityShippedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createPurchaseOrderLineField As ShipmentMaintenanceItemCreatePurchaseOrderLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discTypeField As ShipmentMaintenanceItemDiscType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discLessPlusField As ShipmentMaintenanceItemDiscLessPlus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchMDField As ShipmentMaintenanceItemExchMD
        
        Public Sub New()
            MyBase.New
            Me.createPurchaseOrderLineField = ShipmentMaintenanceItemCreatePurchaseOrderLine.N
            Me.discTypeField = ShipmentMaintenanceItemDiscType.P
            Me.discLessPlusField = ShipmentMaintenanceItemDiscLessPlus.L
            Me.exchMDField = ShipmentMaintenanceItemExchMD.M
        End Sub
        
        Public Property Action() As ShipmentMaintenanceItemAction
            Get
                Return Me.actionField
            End Get
            Set
                Me.actionField = value
            End Set
        End Property
        
        Public Property Vessel() As String
            Get
                Return Me.vesselField
            End Get
            Set
                Me.vesselField = value
            End Set
        End Property
        
        Public Property DepartureDate() As String
            Get
                Return Me.departureDateField
            End Get
            Set
                Me.departureDateField = value
            End Set
        End Property
        
        Public Property ShipmentReference() As String
            Get
                Return Me.shipmentReferenceField
            End Get
            Set
                Me.shipmentReferenceField = value
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
        
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        Public Property QuantityShipped() As String
            Get
                Return Me.quantityShippedField
            End Get
            Set
                Me.quantityShippedField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemCreatePurchaseOrderLine.N)>  _
        Public Property CreatePurchaseOrderLine() As ShipmentMaintenanceItemCreatePurchaseOrderLine
            Get
                Return Me.createPurchaseOrderLineField
            End Get
            Set
                Me.createPurchaseOrderLineField = value
            End Set
        End Property
        
        Public Property PurchaseOrderLineDueDate() As String
            Get
                Return Me.purchaseOrderLineDueDateField
            End Get
            Set
                Me.purchaseOrderLineDueDateField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemDiscType.P)>  _
        Public Property DiscType() As ShipmentMaintenanceItemDiscType
            Get
                Return Me.discTypeField
            End Get
            Set
                Me.discTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemDiscLessPlus.L)>  _
        Public Property DiscLessPlus() As ShipmentMaintenanceItemDiscLessPlus
            Get
                Return Me.discLessPlusField
            End Get
            Set
                Me.discLessPlusField = value
            End Set
        End Property
        
        Public Property DiscPercent1() As String
            Get
                Return Me.discPercent1Field
            End Get
            Set
                Me.discPercent1Field = value
            End Set
        End Property
        
        Public Property DiscPercent2() As String
            Get
                Return Me.discPercent2Field
            End Get
            Set
                Me.discPercent2Field = value
            End Set
        End Property
        
        Public Property DiscPercent3() As String
            Get
                Return Me.discPercent3Field
            End Get
            Set
                Me.discPercent3Field = value
            End Set
        End Property
        
        Public Property DiscValue() As String
            Get
                Return Me.discValueField
            End Get
            Set
                Me.discValueField = value
            End Set
        End Property
        
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemExchMD.M)>  _
        Public Property ExchMD() As ShipmentMaintenanceItemExchMD
            Get
                Return Me.exchMDField
            End Get
            Set
                Me.exchMDField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShipmentMaintenanceItemAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        X
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShipmentMaintenanceItemCreatePurchaseOrderLine
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShipmentMaintenanceItemDiscType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShipmentMaintenanceItemDiscLessPlus
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShipmentMaintenanceItemExchMD
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
