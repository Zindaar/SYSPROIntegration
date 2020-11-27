Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryPosting.InventoryMovementsReceipts.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyCostMultiplier
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Bins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binPiecesField As String
        
        '''<summary>
        '''This element contains the bin location of the stock being received. If processing a negative receipt, only one bin location may be supplied. Any others will be ignored.
        '''</summary>
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock item is not a unit-qty type stock item. If it is and this element is supplied, the units and pieces elements must NOT be supplied. The total bin quantity must match the quantity specified for the transaction.
        '''</summary>
        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and bin quantity element is not supplied, the bin quantity must be supplied as units and pieces. At least one of these elements must be supplied.
        '''</summary>
        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and bin quantity element is not supplied, the bin quantity must be supplied as units and pieces. At least one of these elements must be supplied.
        '''</summary>
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fifoBucketField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotConcessionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsField As UseSingleTypeABCElements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As List(Of Bins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialRangeField As List(Of SerialRange)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialAllocationField As List(Of SerialAllocation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyCostMultiplierField As ApplyCostMultiplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyCostMultiplierFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costMultiplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonMerchandiseCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonMerchandiseDistributionField As List(Of NonMerchandiseDistribution)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.useSingleTypeABCElementsField = UseSingleTypeABCElements.N
            Me.applyCostMultiplierField = ApplyCostMultiplier.N
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of NonMerchandiseDistribution)
            End If
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of SerialAllocation)
            End If
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New List(Of SerialRange)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of Bins)
            End If
        End Sub
        
        '''<summary>
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the current posting period and warehouse and may not have been printed already. If not supplied a new journal will be created.
        '''</summary>
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain a valid warehouse code.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain a valid stock code.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock is ECC-controlled at version or release level.
        '''</summary>
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock is ECC-controlled at release level.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock item is not a unit-qty type stock item. If it is and this element is supplied, the units and pieces elements must NOT be supplied.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''If quantity was supplied in a unit of measure different to the stocking unit of measure, this element must indicate the alternate unit of measure.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''Unit cost of the specified quantity. Only one of the costs may be supplied. The transaction will be rejected if both are supplied.
        '''</summary>
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        '''<summary>
        '''Total cost of the specified quantity. The unit cost will be calculated. Only one of the costs may be supplied. The transaction will be rejected if both are supplied.
        '''</summary>
        Public Property TotalCost() As String
            Get
                Return Me.totalCostField
            End Get
            Set
                Me.totalCostField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If FIFO is installed and processing a negative receipt, a specific FIFO bucket may be specified. If a FIFO bucket is supplied when processing a positive receipt, it will be ignored.
        '''</summary>
        Public Property FifoBucket() As String
            Get
                Return Me.fifoBucketField
            End Get
            Set
                Me.fifoBucketField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory for lot traceable stock items if lot numbering is not automatic. However, if processing a negative receipt, the lot number must be specified.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. However, if element 'IgnoreWarnings' is set to 'N', it must be supplied.
        '''</summary>
        Public Property LotConcession() As String
            Get
                Return Me.lotConcessionField
            End Get
            Set
                Me.lotConcessionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If supplied it must contain a valid date.
        '''</summary>
        Public Property LotExpiryDate() As String
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only valid if ABC costing is in use. If not supplied and ABC costing is required, it defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property UseSingleTypeABCElements() As UseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set
                Me.useSingleTypeABCElementsField = value
                Me.UseSingleTypeABCElementsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseSingleTypeABCElementsSpecified() As Boolean
            Get
                Return Me.useSingleTypeABCElementsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the top element for the set of bins affected by this transaction, if multiple bins is installed.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Bins")>  _
        Public Property BinsCollection() As List(Of Bins)
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        '''<summary>
        '''A set of serial numbers and relevant information must be supplied if stock item specified is serialized.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Serials")>  _
        Public Property SerialsCollection() As List(Of Serials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to specify a prefix and suffix or starting serial number for a range of new serial numbers to be generated. It is only valid when processing positive receipts for manual serialized stock items. It has two formats, depending on the serial key type. If serial numbers are ALPHANUMERIC, a prefix and a suffix need to be supplied. If serial numbers are NUMERIC, a starting serial number is required.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("SerialRange")>  _
        Public Property SerialRangeCollection() As List(Of SerialRange)
            Get
                Return Me.serialRangeField
            End Get
            Set
                Me.serialRangeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to specify a range of serial numbers to be allocated. It is only valid when processing negative receipts for manual serialized stock items.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("SerialAllocation")>  _
        Public Property SerialAllocationCollection() As List(Of SerialAllocation)
            Get
                Return Me.serialAllocationField
            End Get
            Set
                Me.serialAllocationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not a cost multiplier must be applied to the cost of the receipt. IF not supplied it defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ApplyCostMultiplier() As ApplyCostMultiplier
            Get
                Return Me.applyCostMultiplierField
            End Get
            Set
                Me.applyCostMultiplierField = value
                Me.ApplyCostMultiplierFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyCostMultiplierSpecified() As Boolean
            Get
                Return Me.applyCostMultiplierFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the cost multiplier to be applied to the cost of the receipt and only takes effect if 'ApplyCostMultiplier' is set to 'Y' and the cost multiplier against the warehouse is greater than 1.00. If this is not supplied, the warehouse cost multiplier is used.
        '''</summary>
        Public Property CostMultiplier() As String
            Get
                Return Me.costMultiplierField
            End Get
            Set
                Me.costMultiplierField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains a non merchandise cost to be applied and overrides the cost multiplier, if supplied. This only takes effect if 'ApplyCostMultiplier' is set to 'Y'.
        '''</summary>
        Public Property NonMerchandiseCost() As String
            Get
                Return Me.nonMerchandiseCostField
            End Get
            Set
                Me.nonMerchandiseCostField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the top element for the non-merchandise distribution.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("NonMerchandiseDistribution")>  _
        Public Property NonMerchandiseDistributionCollection() As List(Of NonMerchandiseDistribution)
            Get
                Return Me.nonMerchandiseDistributionField
            End Get
            Set
                Me.nonMerchandiseDistributionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.
        '''</summary>
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only used if Inventory is integrated to General Ledger or requires a Report,  and ledger codes are required for this type of inventory transaction. If entered and used, it must be a valid ledger code, and must not be on hold.
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If ledger codes require a password, this element must contain the relevant password for the specified ledger code.
        '''</summary>
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the GUID of the current process required to authenticate the transaction when Electronic Signatures are in use.
        '''</summary>
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseSingleTypeABCElements
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Serials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        '''<summary>
        '''Serial number being received into stock.
        '''</summary>
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
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
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
        '''</summary>
        Public Property SerialUnits() As String
            Get
                Return Me.serialUnitsField
            End Get
            Set
                Me.serialUnitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
        '''</summary>
        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock.
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
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SerialRange
        
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
        
        '''<summary>
        '''This element specifies the prefix to be used when generating a range of ALPHANUMERIC serial numbers. Prefix + suffix cannot exceed the size of the serial number key which is 20 characters. Mandatory for ALPHANUMERIC serial numbers.
        '''</summary>
        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set
                Me.serialPrefixField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the suffix to be used when generating a range of ALPHANUMERIC serial numbers. The suffix element must be numeric. Prefix + suffix cannot exceed the size of the serial number key which is 20 characters. Mandatory for ALPHANUMERIC serial numbers.
        '''</summary>
        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set
                Me.serialSuffixField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the starting serial number when generating a range of NUMERIC serial numbers. Mandatory for numeric serial numbers.
        '''</summary>
        Public Property StartSerialNumber() As String
            Get
                Return Me.startSerialNumberField
            End Get
            Set
                Me.startSerialNumberField = value
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
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock.
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
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SerialAllocation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        '''<summary>
        '''This element specifies the starting serial number to be allocated when processing negative receipts.
        '''</summary>
        Public Property FromSerialNumber() As String
            Get
                Return Me.fromSerialNumberField
            End Get
            Set
                Me.fromSerialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the endingserial number to be allocated when processing negative receipts. If this element is not supplied, serial numbers will be allocated starting at the FromSerialNumber until the specified quantity has been allocated.
        '''</summary>
        Public Property ToSerialNumber() As String
            Get
                Return Me.toSerialNumberField
            End Get
            Set
                Me.toSerialNumberField = value
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
                Me.serialQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class NonMerchandiseDistribution
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmAmountField As String
        
        '''<summary>
        '''This element is mandatory.
        '''</summary>
        Public Property NmReference() As String
            Get
                Return Me.nmReferenceField
            End Get
            Set
                Me.nmReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the ledger code to which the non-merchandise amount must be posted.
        '''</summary>
        Public Property NmLedgerCode() As String
            Get
                Return Me.nmLedgerCodeField
            End Get
            Set
                Me.nmLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the non-merchandise amount to be posted to the corresponding ledger code.
        '''</summary>
        Public Property NmAmount() As String
            Get
                Return Me.nmAmountField
            End Get
            Set
                Me.nmAmountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostInvReceipts
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This is the top element for all data required for the transaction.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
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
                Return "INVTMR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
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
                Dim objParams As Params.PostInvReceipts
                objParams = New Params.PostInvReceipts
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
End Namespace
