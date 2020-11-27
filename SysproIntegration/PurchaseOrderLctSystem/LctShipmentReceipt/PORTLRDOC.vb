Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderLctSystem.LctShipmentReceipt.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostLandedCostReceipts
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemsField As List(Of PostLandedCostReceiptsItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostLandedCostReceiptsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of PostLandedCostReceiptsItem)
            End If
        End Sub
        
        Public Property Item() As List(Of PostLandedCostReceiptsItem)
            Get
                Return Me.itemsField
            End Get
            Set(value As List(Of PostLandedCostReceiptsItem))
                Me.itemsField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "PORTLR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostLandedCostReceiptsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostLandedCostReceiptsParameters
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
                Dim objParams As Params.PostLandedCostReceipts
                objParams = New Params.PostLandedCostReceipts
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
    Partial Public Class PostLandedCostReceiptsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipmentReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private vesselField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departureDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNSourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalNotationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierDeliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderDetailsField As PostLandedCostReceiptsItemPurchaseOrderDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sundryDetailsField As PostLandedCostReceiptsItemSundryDetails
        
        Public Sub New()
            MyBase.New
            If (Me.sundryDetailsField Is Nothing) Then
                Me.sundryDetailsField = New PostLandedCostReceiptsItemSundryDetails
            End If
            If (Me.purchaseOrderDetailsField Is Nothing) Then
                Me.purchaseOrderDetailsField = New PostLandedCostReceiptsItemPurchaseOrderDetails
            End If
        End Sub
        
        Public Property ShipmentReference() As String
            Get
                Return Me.shipmentReferenceField
            End Get
            Set
                Me.shipmentReferenceField = value
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
        
        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = value
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
        
        Public Property GRNSource() As String
            Get
                Return Me.gRNSourceField
            End Get
            Set
                Me.gRNSourceField = value
            End Set
        End Property
        
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set
                Me.journalNotationField = value
            End Set
        End Property
        
        Public Property SupplierDeliveryNote() As String
            Get
                Return Me.supplierDeliveryNoteField
            End Get
            Set
                Me.supplierDeliveryNoteField = value
            End Set
        End Property
        
        Public Property PurchaseOrderDetails() As PostLandedCostReceiptsItemPurchaseOrderDetails
            Get
                Return Me.purchaseOrderDetailsField
            End Get
            Set
                Me.purchaseOrderDetailsField = value
            End Set
        End Property
        
        Public Property SundryDetails() As PostLandedCostReceiptsItemSundryDetails
            Get
                Return Me.sundryDetailsField
            End Get
            Set
                Me.sundryDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemPurchaseOrderDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As PostLandedCostReceiptsItemPurchaseOrderDetailsBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As PostLandedCostReceiptsItemPurchaseOrderDetailsSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialRangeField As PostLandedCostReceiptsItemPurchaseOrderDetailsSerialRange
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsField As PostLandedCostReceiptsItemPurchaseOrderDetailsUseSingleTypeABCElements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isSalesOrderCompleteField As PostLandedCostReceiptsItemPurchaseOrderDetailsIsSalesOrderComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityField As PostLandedCostReceiptsItemPurchaseOrderDetailsIncreaseSalesOrderQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private natureOfTransactionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private modeOfTransportField As PostLandedCostReceiptsItemPurchaseOrderDetailsModeOfTransport
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tradersReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsField As PostLandedCostReceiptsItemPurchaseOrderDetailsSupplementaryUnits
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private certificateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionGRNField As PostLandedCostReceiptsItemPurchaseOrderDetailsInspectionGRN
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionGRNFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sampleQuantityField As String
        
        Public Sub New()
            MyBase.New
            Me.useSingleTypeABCElementsField = PostLandedCostReceiptsItemPurchaseOrderDetailsUseSingleTypeABCElements.N
            Me.isSalesOrderCompleteField = PostLandedCostReceiptsItemPurchaseOrderDetailsIsSalesOrderComplete.N
            Me.increaseSalesOrderQuantityField = PostLandedCostReceiptsItemPurchaseOrderDetailsIncreaseSalesOrderQuantity.N
            Me.supplementaryUnitsField = PostLandedCostReceiptsItemPurchaseOrderDetailsSupplementaryUnits.N
            If (Me.modeOfTransportField Is Nothing) Then
                Me.modeOfTransportField = New PostLandedCostReceiptsItemPurchaseOrderDetailsModeOfTransport
            End If
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New PostLandedCostReceiptsItemPurchaseOrderDetailsSerialRange
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New PostLandedCostReceiptsItemPurchaseOrderDetailsSerials
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New PostLandedCostReceiptsItemPurchaseOrderDetailsBins
            End If
        End Sub
        
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
        
        Public Property Bins() As PostLandedCostReceiptsItemPurchaseOrderDetailsBins
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        Public Property Serials() As PostLandedCostReceiptsItemPurchaseOrderDetailsSerials
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        Public Property SerialRange() As PostLandedCostReceiptsItemPurchaseOrderDetailsSerialRange
            Get
                Return Me.serialRangeField
            End Get
            Set
                Me.serialRangeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLandedCostReceiptsItemPurchaseOrderDetailsUseSingleTypeABCElements.N)>  _
        Public Property UseSingleTypeABCElements() As PostLandedCostReceiptsItemPurchaseOrderDetailsUseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set
                Me.useSingleTypeABCElementsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLandedCostReceiptsItemPurchaseOrderDetailsIsSalesOrderComplete.N)>  _
        Public Property IsSalesOrderComplete() As PostLandedCostReceiptsItemPurchaseOrderDetailsIsSalesOrderComplete
            Get
                Return Me.isSalesOrderCompleteField
            End Get
            Set
                Me.isSalesOrderCompleteField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLandedCostReceiptsItemPurchaseOrderDetailsIncreaseSalesOrderQuantity.N)>  _
        Public Property IncreaseSalesOrderQuantity() As PostLandedCostReceiptsItemPurchaseOrderDetailsIncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set
                Me.increaseSalesOrderQuantityField = value
            End Set
        End Property
        
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        Public Property NatureOfTransaction() As String
            Get
                Return Me.natureOfTransactionField
            End Get
            Set
                Me.natureOfTransactionField = value
            End Set
        End Property
        
        Public Property ModeOfTransport() As PostLandedCostReceiptsItemPurchaseOrderDetailsModeOfTransport
            Get
                Return Me.modeOfTransportField
            End Get
            Set
                Me.modeOfTransportField = value
            End Set
        End Property
        
        Public Property TradersReference() As String
            Get
                Return Me.tradersReferenceField
            End Get
            Set
                Me.tradersReferenceField = value
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
        
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLandedCostReceiptsItemPurchaseOrderDetailsSupplementaryUnits.N)>  _
        Public Property SupplementaryUnits() As PostLandedCostReceiptsItemPurchaseOrderDetailsSupplementaryUnits
            Get
                Return Me.supplementaryUnitsField
            End Get
            Set
                Me.supplementaryUnitsField = value
            End Set
        End Property
        
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = value
            End Set
        End Property
        
        Public Property DeliveryDate() As String
            Get
                Return Me.deliveryDateField
            End Get
            Set
                Me.deliveryDateField = value
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
        
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
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
        
        Public Property LotExpiryDate() As String
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
            End Set
        End Property
        
        Public Property InspectionGRN() As PostLandedCostReceiptsItemPurchaseOrderDetailsInspectionGRN
            Get
                Return Me.inspectionGRNField
            End Get
            Set
                Me.inspectionGRNField = value
                Me.InspectionGRNFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InspectionGRNSpecified() As Boolean
            Get
                Return Me.inspectionGRNFieldSpecified
            End Get
        End Property
        
        Public Property SampleQuantity() As String
            Get
                Return Me.sampleQuantityField
            End Get
            Set
                Me.sampleQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemPurchaseOrderDetailsBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binPiecesField As String
        
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = value
            End Set
        End Property
        
        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = value
            End Set
        End Property
        
        Public Property BinPieces() As String
            Get
                Return Me.binPiecesField
            End Get
            Set
                Me.binPiecesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemPurchaseOrderDetailsSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''Becomes mandatory when the item is serialized batch, and is not unit processing.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the date the serial expires.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the location of the serial number.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemPurchaseOrderDetailsSerialRange
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPrefixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set
                Me.serialPrefixField = value
            End Set
        End Property
        
        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set
                Me.serialSuffixField = value
            End Set
        End Property
        
        Public Property StartSerialNumber() As String
            Get
                Return Me.startSerialNumberField
            End Get
            Set
                Me.startSerialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''Becomes mandatory when the item is serialized batch, and is not unit processing.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the date the serial expires.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the location of the serial number.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsItemPurchaseOrderDetailsUseSingleTypeABCElements
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsItemPurchaseOrderDetailsIsSalesOrderComplete
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsItemPurchaseOrderDetailsIncreaseSalesOrderQuantity
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemPurchaseOrderDetailsModeOfTransport
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsItemPurchaseOrderDetailsSupplementaryUnits
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsItemPurchaseOrderDetailsInspectionGRN
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemSundryDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipmentLineField As PostLandedCostReceiptsItemSundryDetailsShipmentLine
        
        Public Property ShipmentLine() As PostLandedCostReceiptsItemSundryDetailsShipmentLine
            Get
                Return Me.shipmentLineField
            End Get
            Set
                Me.shipmentLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsItemSundryDetailsShipmentLine
    End Class
End Namespace
