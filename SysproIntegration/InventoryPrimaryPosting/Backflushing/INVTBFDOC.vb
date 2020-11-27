Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryPosting.InventoryMovementsBackflushing.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostInvBackflushing
        Implements ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As List(Of PostInvBackflushingItem)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.PostInvBackflushingParameters

        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostInvBackflushingItem)()
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")>
        Public Property ItemCollection() As List(Of PostInvBackflushingItem)
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
                Return "INVTBF"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostInvBackflushingParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostInvBackflushingParameters()
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
                Dim objParams As Params.PostInvBackflushing
                objParams = New Params.PostInvBackflushing()
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
    Partial Public Class PostInvBackflushingItem

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private parentJournalField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private componentJournalField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private versionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private releaseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private quantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitOfMeasureField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private piecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private fifoBucketField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotConcessionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotExpiryField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private useSingleTypeABCElementsField As PostInvBackflushingItemUseSingleTypeABCElements

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binsField As PostInvBackflushingItemBins

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialsField As List(Of Serials)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialRangeField As PostInvBackflushingItemSerialRange

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialAllocationField As SerialAllocation

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyCostMultiplierField As PostInvBackflushingItemApplyCostMultiplier

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private costMultiplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonMerchandiseCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonMerchandiseDistributionField As List(Of PostInvBackflushingItemNonMerchandiseDistribution)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private referenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private notationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private passwordForLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private routeToUseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private routePasswordField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private includeSetUpTimeField As PostInvBackflushingItemIncludeSetUpTime

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private includeStartUpTimeField As PostInvBackflushingItemIncludeStartUpTime

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private includeTearDownTimeField As PostInvBackflushingItemIncludeTearDownTime

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private jobField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private componentDetailsField As List(Of PostInvBackflushingItemComponentDetails)

        Public Sub New()
            MyBase.New
            Me.useSingleTypeABCElementsField = PostInvBackflushingItemUseSingleTypeABCElements.N
            Me.applyCostMultiplierField = PostInvBackflushingItemApplyCostMultiplier.N
            Me.routeToUseField = "0"
            Me.includeSetUpTimeField = PostInvBackflushingItemIncludeSetUpTime.N
            Me.includeStartUpTimeField = PostInvBackflushingItemIncludeStartUpTime.N
            Me.includeTearDownTimeField = PostInvBackflushingItemIncludeTearDownTime.N
            If (Me.componentDetailsField Is Nothing) Then
                Me.componentDetailsField = New List(Of PostInvBackflushingItemComponentDetails)()
            End If
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of PostInvBackflushingItemNonMerchandiseDistribution)()
            End If
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New SerialAllocation()
            End If
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New PostInvBackflushingItemSerialRange()
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)()
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New PostInvBackflushingItemBins()
            End If
        End Sub

        Public Property ParentJournal() As String
            Get
                Return Me.parentJournalField
            End Get
            Set
                Me.parentJournalField = Value
            End Set
        End Property

        Public Property ComponentJournal() As String
            Get
                Return Me.componentJournalField
            End Get
            Set
                Me.componentJournalField = Value
            End Set
        End Property

        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory and must contain a valid stock code. The stock code indicates either the parent item or the component for which you want to allocate serials or lots. The format is either alphanumeric or numeric, depending on the key configuration for stock code within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = Value
            End Set
        End Property

        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = Value
            End Set
        End Property

        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = Value
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

        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = Value
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

        Public Property FifoBucket() As String
            Get
                Return Me.fifoBucketField
            End Get
            Set
                Me.fifoBucketField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory for lot traceable stock items. You may supply multiple lots for lot traceable components, but only one lot will be accepted for the parent item. The format is either alphanumeric or numeric, depending on the key configuration setup for lot within SYSPRO.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = Value
            End Set
        End Property

        Public Property LotConcession() As String
            Get
                Return Me.lotConcessionField
            End Get
            Set
                Me.lotConcessionField = Value
            End Set
        End Property

        Public Property LotExpiry() As String
            Get
                Return Me.lotExpiryField
            End Get
            Set
                Me.lotExpiryField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemUseSingleTypeABCElements.N)>
        Public Property UseSingleTypeABCElements() As PostInvBackflushingItemUseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set
                Me.useSingleTypeABCElementsField = Value
            End Set
        End Property

        Public Property Bins() As PostInvBackflushingItemBins
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = Value
            End Set
        End Property

        '''<summary>
        '''A set of serial numbers and relevant information must be supplied if stock item specified is serialized.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Serials")>
        Public Property SerialsCollection() As List(Of Serials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = Value
            End Set
        End Property

        Public Property SerialRange() As PostInvBackflushingItemSerialRange
            Get
                Return Me.serialRangeField
            End Get
            Set
                Me.serialRangeField = Value
            End Set
        End Property

        '''<summary>
        '''This element is used to specify a range of serial numbers to be allocated. It is only valid when processing manual serialized stock items.
        '''</summary>
        Public Property SerialAllocation() As SerialAllocation
            Get
                Return Me.serialAllocationField
            End Get
            Set
                Me.serialAllocationField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemApplyCostMultiplier.N)>
        Public Property ApplyCostMultiplier() As PostInvBackflushingItemApplyCostMultiplier
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
        Public Property NonMerchandiseDistributionCollection() As List(Of PostInvBackflushingItemNonMerchandiseDistribution)
            Get
                Return Me.nonMerchandiseDistributionField
            End Get
            Set
                Me.nonMerchandiseDistributionField = Value
            End Set
        End Property

        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = Value
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

        <System.ComponentModel.DefaultValueAttribute("0")>
        Public Property RouteToUse() As String
            Get
                Return Me.routeToUseField
            End Get
            Set
                Me.routeToUseField = Value
            End Set
        End Property

        Public Property RoutePassword() As String
            Get
                Return Me.routePasswordField
            End Get
            Set
                Me.routePasswordField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemIncludeSetUpTime.N)>
        Public Property IncludeSetUpTime() As PostInvBackflushingItemIncludeSetUpTime
            Get
                Return Me.includeSetUpTimeField
            End Get
            Set
                Me.includeSetUpTimeField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemIncludeStartUpTime.N)>
        Public Property IncludeStartUpTime() As PostInvBackflushingItemIncludeStartUpTime
            Get
                Return Me.includeStartUpTimeField
            End Get
            Set
                Me.includeStartUpTimeField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemIncludeTearDownTime.N)>
        Public Property IncludeTearDownTime() As PostInvBackflushingItemIncludeTearDownTime
            Get
                Return Me.includeTearDownTimeField
            End Get
            Set
                Me.includeTearDownTimeField = Value
            End Set
        End Property

        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("ComponentDetails")>
        Public Property ComponentDetailsCollection() As List(Of PostInvBackflushingItemComponentDetails)
            Get
                Return Me.componentDetailsField
            End Get
            Set
                Me.componentDetailsField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingItemUseSingleTypeABCElements

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
    Partial Public Class PostInvBackflushingItemBins

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binPiecesField As String

        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = Value
            End Set
        End Property

        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = Value
            End Set
        End Property

        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = Value
            End Set
        End Property

        Public Property BinPieces() As String
            Get
                Return Me.binPiecesField
            End Get
            Set
                Me.binPiecesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Serials

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialFifoBucketField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialLocationField As String

        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = Value
            End Set
        End Property

        Public Property SerialFifoBucket() As String
            Get
                Return Me.serialFifoBucketField
            End Get
            Set
                Me.serialFifoBucketField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock. The format is CCYY-MM-DD.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostInvBackflushingItemSerialRange

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialPrefixField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialSuffixField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private startSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialLocationField As String

        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set
                Me.serialPrefixField = Value
            End Set
        End Property

        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set
                Me.serialSuffixField = Value
            End Set
        End Property

        Public Property StartSerialNumber() As String
            Get
                Return Me.startSerialNumberField
            End Get
            Set
                Me.startSerialNumberField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock. The format is CCYY-MM-DD.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class SerialAllocation

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

        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
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
    Public Enum PostInvBackflushingItemApplyCostMultiplier

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
    Partial Public Class PostInvBackflushingItemNonMerchandiseDistribution

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nmLedgerPasswordField As String

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

        Public Property NmLedgerPassword() As String
            Get
                Return Me.nmLedgerPasswordField
            End Get
            Set
                Me.nmLedgerPasswordField = Value
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
    Public Enum PostInvBackflushingItemIncludeSetUpTime

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingItemIncludeStartUpTime

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingItemIncludeTearDownTime

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
    Partial Public Class PostInvBackflushingItemComponentDetails

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private allowUnderIssueField As PostInvBackflushingItemComponentDetailsAllowUnderIssue

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotAndSerialField As List(Of PostInvBackflushingItemComponentDetailsLotAndSerial)

        Public Sub New()
            MyBase.New
            Me.allowUnderIssueField = PostInvBackflushingItemComponentDetailsAllowUnderIssue.N
            If (Me.lotAndSerialField Is Nothing) Then
                Me.lotAndSerialField = New List(Of PostInvBackflushingItemComponentDetailsLotAndSerial)()
            End If
        End Sub

        '''<summary>
        '''This element is mandatory and must contain a valid stock code. The stock code indicates either the parent item or the component for which you want to allocate serials or lots. The format is either alphanumeric or numeric, depending on the key configuration for stock code within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingItemComponentDetailsAllowUnderIssue.N)>
        Public Property AllowUnderIssue() As PostInvBackflushingItemComponentDetailsAllowUnderIssue
            Get
                Return Me.allowUnderIssueField
            End Get
            Set
                Me.allowUnderIssueField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("LotAndSerial")>
        Public Property LotAndSerialCollection() As List(Of PostInvBackflushingItemComponentDetailsLotAndSerial)
            Get
                Return Me.lotAndSerialField
            End Get
            Set
                Me.lotAndSerialField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingItemComponentDetailsAllowUnderIssue

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        S
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostInvBackflushingItemComponentDetailsLotAndSerial

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotFifoBucketField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialsField As List(Of Serials)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialAllocationField As SerialAllocation

        '''<summary>
        '''This element is mandatory for lot traceable stock items. You may supply multiple lots for lot traceable components, but only one lot will be accepted for the parent item. The format is either alphanumeric or numeric, depending on the key configuration setup for lot within SYSPRO.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = Value
            End Set
        End Property

        Public Property LotQuantity() As String
            Get
                Return Me.lotQuantityField
            End Get
            Set
                Me.lotQuantityField = Value
            End Set
        End Property

        Public Property LotFifoBucket() As String
            Get
                Return Me.lotFifoBucketField
            End Get
            Set
                Me.lotFifoBucketField = Value
            End Set
        End Property

        '''<summary>
        '''A set of serial numbers and relevant information must be supplied if stock item specified is serialized.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Serials")>
        Public Property SerialsCollection() As List(Of Serials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = Value
            End Set
        End Property

        '''<summary>
        '''This element is used to specify a range of serial numbers to be allocated. It is only valid when processing manual serialized stock items.
        '''</summary>
        Public Property SerialAllocation() As SerialAllocation
            Get
                Return Me.serialAllocationField
            End Get
            Set
                Me.serialAllocationField = Value
            End Set
        End Property
    End Class
End Namespace
