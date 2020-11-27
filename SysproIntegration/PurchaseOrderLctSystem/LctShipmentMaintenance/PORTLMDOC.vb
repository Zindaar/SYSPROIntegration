Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderLctSystem.LctShipmentMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ShipmentMaintenance
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of ShipmentMaintenanceItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.ShipmentMaintenanceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of ShipmentMaintenanceItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of ShipmentMaintenanceItem)
            Get
                Return Me.itemField
            End Get
            Set(value As List(Of ShipmentMaintenanceItem))
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
                Dim xml As String = Common.SysproUtilities.SerializeToXMLString(Me)
                Return StripEpicentreFields(xml)
            End Get
        End Property

        Public Function StripEpicentreFields(xmlData As String) As String
            Dim pattern As String = ""
            'Now remove the Epicentre-specific elements, Route, EstimatedArrivalDate, VesselDescription, ChargeableWeight()

            pattern = "<Route>.{0,8}</Route>"
            Dim rgx As New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result1 As String = rgx.Replace(xmlData, "")

            pattern = "<Route />"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result2 As String = rgx.Replace(result1, "")

            pattern = "<VesselDescription>.{0,30}</VesselDescription>"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result3 As String = rgx.Replace(result2, "")

            pattern = "<VesselDescription />"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result4 As String = rgx.Replace(result3, "")

            pattern = "<ChargeableWeight>.{0,13}</ChargeableWeight>"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result5 As String = rgx.Replace(result4, "")

            pattern = "<ChargeableWeight />"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result6 As String = rgx.Replace(result5, "")

            pattern = "<EstimatedArrivalDate>.{0,10}</EstimatedArrivalDate>"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result7 As String = rgx.Replace(result6, "")

            pattern = "<EstimatedArrivalDate />"
            rgx = New System.Text.RegularExpressions.Regex(pattern, Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim result8 As String = rgx.Replace(result7, "")

            Return result8
        End Function

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.ShipmentMaintenance
                objParams = New Params.ShipmentMaintenance
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
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchangeRateField As String

        ''' <summary>
        ''' This field is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks></remarks>
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private routeField As String

        ''' <summary>
        ''' This field is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks></remarks>
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private estimatedArrivalDateField As String

        ''' <summary>
        ''' This field is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks></remarks>
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private vesselDescriptionField As String

        ''' <summary>
        ''' This field is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks></remarks>
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private chargeableWeightField As String


        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchMDField As ShipmentMaintenanceItemExchMD

        Public Sub New()
            MyBase.New()
            Me.createPurchaseOrderLineField = ShipmentMaintenanceItemCreatePurchaseOrderLine.N
            Me.discTypeField = ShipmentMaintenanceItemDiscType.P
            Me.discLessPlusField = ShipmentMaintenanceItemDiscLessPlus.L
            Me.exchMDField = ShipmentMaintenanceItemExchMD.M
        End Sub

        Public Property Action() As ShipmentMaintenanceItemAction
            Get
                Return Me.actionField
            End Get
            Set(value As ShipmentMaintenanceItemAction)
                Me.actionField = value
            End Set
        End Property

        Public Property Vessel() As String
            Get
                Return Me.vesselField
            End Get
            Set(value As String)
                Me.vesselField = value
            End Set
        End Property

        Public Property DepartureDate() As String
            Get
                Return Me.departureDateField
            End Get
            Set(value As String)
                Me.departureDateField = value
            End Set
        End Property

        Public Property ShipmentReference() As String
            Get
                Return Me.shipmentReferenceField
            End Get
            Set(value As String)
                Me.shipmentReferenceField = value
            End Set
        End Property

        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set(value As String)
                Me.purchaseOrderField = value
            End Set
        End Property

        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set(value As String)
                Me.purchaseOrderLineField = value
            End Set
        End Property

        Public Property QuantityShipped() As String
            Get
                Return Me.quantityShippedField
            End Get
            Set(value As String)
                Me.quantityShippedField = value
            End Set
        End Property

        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set(value As String)
                Me.unitsField = value
            End Set
        End Property

        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set(value As String)
                Me.piecesField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemCreatePurchaseOrderLine.N)> _
        Public Property CreatePurchaseOrderLine() As ShipmentMaintenanceItemCreatePurchaseOrderLine
            Get
                Return Me.createPurchaseOrderLineField
            End Get
            Set(value As ShipmentMaintenanceItemCreatePurchaseOrderLine)
                Me.createPurchaseOrderLineField = value
            End Set
        End Property

        Public Property PurchaseOrderLineDueDate() As String
            Get
                Return Me.purchaseOrderLineDueDateField
            End Get
            Set(value As String)
                Me.purchaseOrderLineDueDateField = value
            End Set
        End Property

        Public Property UnitPrice() As String
            Get
                Return Me.unitPriceField
            End Get
            Set(value As String)
                Me.unitPriceField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemDiscType.P)> _
        Public Property DiscType() As ShipmentMaintenanceItemDiscType
            Get
                Return Me.discTypeField
            End Get
            Set(value As ShipmentMaintenanceItemDiscType)
                Me.discTypeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemDiscLessPlus.L)> _
        Public Property DiscLessPlus() As ShipmentMaintenanceItemDiscLessPlus
            Get
                Return Me.discLessPlusField
            End Get
            Set(value As ShipmentMaintenanceItemDiscLessPlus)
                Me.discLessPlusField = value
            End Set
        End Property

        Public Property DiscPercent1() As String
            Get
                Return Me.discPercent1Field
            End Get
            Set(value As String)
                Me.discPercent1Field = value
            End Set
        End Property

        Public Property DiscPercent2() As String
            Get
                Return Me.discPercent2Field
            End Get
            Set(value As String)
                Me.discPercent2Field = value
            End Set
        End Property

        Public Property DiscPercent3() As String
            Get
                Return Me.discPercent3Field
            End Get
            Set(value As String)
                Me.discPercent3Field = value
            End Set
        End Property

        Public Property DiscValue() As String
            Get
                Return Me.discValueField
            End Get
            Set(value As String)
                Me.discValueField = value
            End Set
        End Property

        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set(value As String)
                Me.exchangeRateField = value
            End Set
        End Property

        ''' <summary>
        ''' The Route property is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks>Max 8 characters</remarks>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set(value As String)
                Me.routeField = value
            End Set
        End Property

        ''' <summary>
        ''' The EstimatedArrivalDate property is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks>Should be YYYY-MM-DD</remarks>
        Public Property EstimatedArrivalDate() As String
            Get
                Return Me.estimatedArrivalDateField
            End Get
            Set(value As String)
                Me.estimatedArrivalDateField = value
            End Set
        End Property

        ''' <summary>
        ''' The VesselDescription property is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks>Should be max 30 characters</remarks>
        Public Property VesselDescription() As String
            Get
                Return Me.vesselDescriptionField
            End Get
            Set(value As String)
                Me.vesselDescriptionField = value
            End Set
        End Property

        ''' <summary>
        ''' The ChargeableWeight property is for specific use by Epicentre only...it is not part of the Syspro Business Object
        ''' </summary>
        ''' <remarks>Should be Decimal(10,2)</remarks>
        Public Property ChargeableWeight() As String
            Get
                Return Me.chargeableWeightField
            End Get
            Set(value As String)
                Me.chargeableWeightField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(ShipmentMaintenanceItemExchMD.M)> _
        Public Property ExchMD() As ShipmentMaintenanceItemExchMD
            Get
                Return Me.exchMDField
            End Get
            Set(value As ShipmentMaintenanceItemExchMD)
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
