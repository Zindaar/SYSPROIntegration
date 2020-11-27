Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.PurchaseOrderReceiptsReversal.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostPOReceiptsReverse
        Implements ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As List(Of PostPOReceiptsReverseItem)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.PostPOReceiptsReverseParameters

        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostPOReceiptsReverseItem)()
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")>
        Public Property ItemCollection() As List(Of PostPOReceiptsReverseItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "PORTRO"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostPOReceiptsReverseParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostPOReceiptsReverseParameters()
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostPOReceiptsReverse
                objParams = New Params.PostPOReceiptsReverse()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostPOReceiptsReverseItem

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private purchaseOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private purchaseOrderLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private quantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private piecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private deliveryNoteField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private costField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private costBasisField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private gRNNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private gRNSourceField As PostPOReceiptsReverseItemGRNSource

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private fifoBucketField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialsField As List(Of PostPOReceiptsReverseItemSerials)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialAllocationField As List(Of PostPOReceiptsReverseItemSerialAllocation)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private purchaseOrderLineCompleteField As PostPOReceiptsReverseItemPurchaseOrderLineComplete

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyCostMultiplierField As PostPOReceiptsReverseItemApplyCostMultiplier

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private costMultiplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonMerchandiseCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonMerchandiseDistributionField As List(Of PostPOReceiptsReverseItemNonMerchandiseDistribution)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private notationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private passwordForLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private debitLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private passwordForDebitLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private countryOfOriginField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private deliveryTermsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shippingLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private natureOfTransactionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private modeOfTransportField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private tradersReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private tariffCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitMassField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private supplementaryUnitsField As PostPOReceiptsReverseItemSupplementaryUnits

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private supplementaryUnitsFactorField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private switchOnGRNMatchingField As PostPOReceiptsReverseItemSwitchOnGRNMatching

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private useSingleTypeABCElementsField As PostPOReceiptsReverseItemUseSingleTypeABCElements

        Public Sub New()
            MyBase.New
            Me.purchaseOrderLineCompleteField = PostPOReceiptsReverseItemPurchaseOrderLineComplete.N
            Me.applyCostMultiplierField = PostPOReceiptsReverseItemApplyCostMultiplier.N
            Me.supplementaryUnitsField = PostPOReceiptsReverseItemSupplementaryUnits.N
            Me.switchOnGRNMatchingField = PostPOReceiptsReverseItemSwitchOnGRNMatching.N
            Me.useSingleTypeABCElementsField = PostPOReceiptsReverseItemUseSingleTypeABCElements.N
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of PostPOReceiptsReverseItemNonMerchandiseDistribution)()
            End If
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of PostPOReceiptsReverseItemSerialAllocation)()
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostPOReceiptsReverseItemSerials)()
            End If
        End Sub

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = Value
            End Set
        End Property

        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = Value
            End Set
        End Property

        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = Value
            End Set
        End Property

        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = Value
            End Set
        End Property

        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = Value
            End Set
        End Property

        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = Value
            End Set
        End Property

        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = Value
            End Set
        End Property

        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = Value
            End Set
        End Property

        Public Property CostBasis() As String
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = Value
            End Set
        End Property

        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = Value
            End Set
        End Property

        Public Property GRNSource() As PostPOReceiptsReverseItemGRNSource
            Get
                Return Me.gRNSourceField
            End Get
            Set
                Me.gRNSourceField = Value
            End Set
        End Property

        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = Value
            End Set
        End Property

        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = Value
            End Set
        End Property

        Public Property FifoBucket() As String
            Get
                Return Me.fifoBucketField
            End Get
            Set
                Me.fifoBucketField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Serials")>
        Public Property SerialsCollection() As List(Of PostPOReceiptsReverseItemSerials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SerialAllocation")>
        Public Property SerialAllocationCollection() As List(Of PostPOReceiptsReverseItemSerialAllocation)
            Get
                Return Me.serialAllocationField
            End Get
            Set
                Me.serialAllocationField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemPurchaseOrderLineComplete.N)>
        Public Property PurchaseOrderLineComplete() As PostPOReceiptsReverseItemPurchaseOrderLineComplete
            Get
                Return Me.purchaseOrderLineCompleteField
            End Get
            Set
                Me.purchaseOrderLineCompleteField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemApplyCostMultiplier.N)>
        Public Property ApplyCostMultiplier() As PostPOReceiptsReverseItemApplyCostMultiplier
            Get
                Return Me.applyCostMultiplierField
            End Get
            Set
                Me.applyCostMultiplierField = Value
            End Set
        End Property

        Public Property CostMultiplier() As String
            Get
                Return Me.costMultiplierField
            End Get
            Set
                Me.costMultiplierField = Value
            End Set
        End Property

        Public Property NonMerchandiseCost() As String
            Get
                Return Me.nonMerchandiseCostField
            End Get
            Set
                Me.nonMerchandiseCostField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonMerchandiseDistribution")>
        Public Property NonMerchandiseDistributionCollection() As List(Of PostPOReceiptsReverseItemNonMerchandiseDistribution)
            Get
                Return Me.nonMerchandiseDistributionField
            End Get
            Set
                Me.nonMerchandiseDistributionField = Value
            End Set
        End Property

        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = Value
            End Set
        End Property

        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = Value
            End Set
        End Property

        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = Value
            End Set
        End Property

        Public Property DebitLedgerCode() As String
            Get
                Return Me.debitLedgerCodeField
            End Get
            Set
                Me.debitLedgerCodeField = Value
            End Set
        End Property

        Public Property PasswordForDebitLedgerCode() As String
            Get
                Return Me.passwordForDebitLedgerCodeField
            End Get
            Set
                Me.passwordForDebitLedgerCodeField = Value
            End Set
        End Property

        Public Property CountryOfOrigin() As String
            Get
                Return Me.countryOfOriginField
            End Get
            Set
                Me.countryOfOriginField = Value
            End Set
        End Property

        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = Value
            End Set
        End Property

        Public Property ShippingLocation() As String
            Get
                Return Me.shippingLocationField
            End Get
            Set
                Me.shippingLocationField = Value
            End Set
        End Property

        Public Property NatureOfTransaction() As String
            Get
                Return Me.natureOfTransactionField
            End Get
            Set
                Me.natureOfTransactionField = Value
            End Set
        End Property

        Public Property ModeOfTransport() As String
            Get
                Return Me.modeOfTransportField
            End Get
            Set
                Me.modeOfTransportField = Value
            End Set
        End Property

        Public Property TradersReference() As String
            Get
                Return Me.tradersReferenceField
            End Get
            Set
                Me.tradersReferenceField = Value
            End Set
        End Property

        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = Value
            End Set
        End Property

        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemSupplementaryUnits.N)>
        Public Property SupplementaryUnits() As PostPOReceiptsReverseItemSupplementaryUnits
            Get
                Return Me.supplementaryUnitsField
            End Get
            Set
                Me.supplementaryUnitsField = Value
            End Set
        End Property

        Public Property SupplementaryUnitsFactor() As String
            Get
                Return Me.supplementaryUnitsFactorField
            End Get
            Set
                Me.supplementaryUnitsFactorField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemSwitchOnGRNMatching.N)>
        Public Property SwitchOnGRNMatching() As PostPOReceiptsReverseItemSwitchOnGRNMatching
            Get
                Return Me.switchOnGRNMatchingField
            End Get
            Set
                Me.switchOnGRNMatchingField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemUseSingleTypeABCElements.N)>
        Public Property UseSingleTypeABCElements() As PostPOReceiptsReverseItemUseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set
                Me.useSingleTypeABCElementsField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemGRNSource

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>
        Item4

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")>
        Item5
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostPOReceiptsReverseItemSerials

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialPiecesField As String

        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = Value
            End Set
        End Property

        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = Value
            End Set
        End Property

        Public Property SerialUnits() As String
            Get
                Return Me.serialUnitsField
            End Get
            Set
                Me.serialUnitsField = Value
            End Set
        End Property

        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostPOReceiptsReverseItemSerialAllocation

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private fromSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private toSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialQuantityField As String

        Public Property FromSerialNumber() As String
            Get
                Return Me.fromSerialNumberField
            End Get
            Set
                Me.fromSerialNumberField = Value
            End Set
        End Property

        Public Property ToSerialNumber() As String
            Get
                Return Me.toSerialNumberField
            End Get
            Set
                Me.toSerialNumberField = Value
            End Set
        End Property

        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemPurchaseOrderLineComplete

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemApplyCostMultiplier

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostPOReceiptsReverseItemNonMerchandiseDistribution

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmSupplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmAmountField As String

        Public Property NmReference() As String
            Get
                Return Me.nmReferenceField
            End Get
            Set
                Me.nmReferenceField = Value
            End Set
        End Property

        Public Property NmLedgerCode() As String
            Get
                Return Me.nmLedgerCodeField
            End Get
            Set
                Me.nmLedgerCodeField = Value
            End Set
        End Property

        Public Property NmSupplier() As String
            Get
                Return Me.nmSupplierField
            End Get
            Set
                Me.nmSupplierField = Value
            End Set
        End Property

        Public Property NmAmount() As String
            Get
                Return Me.nmAmountField
            End Get
            Set
                Me.nmAmountField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemSupplementaryUnits

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemSwitchOnGRNMatching

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseItemUseSingleTypeABCElements

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
