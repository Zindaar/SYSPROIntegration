Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.PurchaseOrderReceipts.Data
    
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
        '''This element contains the bin location of the stock being received.
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
        '''This element is mandatory if stock item is not a unit-qty type stock item. If it is and this element is supplied, the units and pieces elements must NOT be supplied. The total bin quantity must match the quantity specified for the transaction and must be entered in the stocking unit of measure.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ChangeSalesOrderStatus
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CountedQuantityComplete
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GRNSource
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")>  _
        Item5
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncreaseSalesOrderQuantity
        
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptField As Receipt
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptIntoInspectionField As ReceiptIntoInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptFromInspectionField As ReceiptFromInspection
        
        Public Sub New()
            MyBase.New

        End Sub
        
        '''<summary>
        '''This is the top element for the set of data required for a normal purchase order line receipt. It can only be supplied once within each 'Item' instance.
        '''</summary>
        Public Property Receipt() As Receipt
            Get
                Return Me.receiptField
            End Get
            Set
                Me.receiptField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the top element for the set of data required for a purchase order line receipt into inspection. It can only be supplied once within each 'Item' instance.
        '''</summary>
        Public Property ReceiptIntoInspection() As ReceiptIntoInspection
            Get
                Return Me.receiptIntoInspectionField
            End Get
            Set
                Me.receiptIntoInspectionField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the top element for the set of data required to receive a GRN into stock from Inspection. It can only be supplied once within each 'Item' instance.
        '''</summary>
        Public Property ReceiptFromInspection() As ReceiptFromInspection
            Get
                Return Me.receiptFromInspectionField
            End Get
            Set
                Me.receiptFromInspectionField = value
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
    Partial Public Class Receipt
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private switchOnGRNMatchingField As SwitchOnGRNMatching
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private switchOnGRNMatchingFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNSourceField As GRNSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNSourceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsField As UseSingleTypeABCElements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As List(Of Bins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialRangeField As List(Of SerialRange)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineCompleteField As PurchaseOrderLineComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineCompleteFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityField As IncreaseSalesOrderQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderStatusField As ChangeSalesOrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderStatusFieldSpecified As Boolean
        
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
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForDebitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countryOfOriginField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private natureOfTransactionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private modeOfTransportField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tradersReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsField As SupplementaryUnits
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.switchOnGRNMatchingField = SwitchOnGRNMatching.N
            Me.useSingleTypeABCElementsField = UseSingleTypeABCElements.N
            Me.increaseSalesOrderQuantityField = IncreaseSalesOrderQuantity.N
            Me.changeSalesOrderStatusField = ChangeSalesOrderStatus.N
            Me.applyCostMultiplierField = ApplyCostMultiplier.N
            Me.supplementaryUnitsField = SupplementaryUnits.N
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of NonMerchandiseDistribution)
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
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the specified posting period and warehouse and may not have been printed already. If not supplied, a new journal will be created.
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
        '''This element is mandatory and contains the Purchase Order being received.
        '''</summary>
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the Purchase Order line being received. If this is not supplied, the 'Warehouse' and 'StockCode' elements must be given so that the correct Purchase Order line can be identified. If there is more than one line for the same warehouse/stock code, the earliest Purchase Order line will be received.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element must be supplied if a 'PurchaseOrderLine' element is not entered.
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
        '''This element must be supplied if a 'PurchaseOrderLine' was not entered.
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
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. It must not be negative.
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
        '''If quantity was supplied in a unit of measure different from the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''This element is optional and contains the supplier's delivery note.
        '''</summary>
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and need only be supplied when 'CostBasis' is set to 'M' (manual cost) or 'T' (total cost). It contains the cost of the specified stock code and if it is specified as a total cost, the unit cost will be calculated.
        '''</summary>
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must specify which cost to use for the Purchase Order receipt. Valid values are:
        '''C - Current warehouse cost
        '''T - Total cost entered manually
        '''M - Unit cost entered manually
        '''P - Purchase price
        '''X - Purchase price plus tax
        '''</summary>
        Public Property CostBasis() As String
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and indicates whether GRN matching must be switched on for a supplier, should it be switched off. However, if the parameter 'GRNMatchingAction' is set to 'R' and GRN matching is switched off, the transaction will reject. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property SwitchOnGRNMatching() As SwitchOnGRNMatching
            Get
                Return Me.switchOnGRNMatchingField
            End Get
            Set
                Me.switchOnGRNMatchingField = value
                Me.SwitchOnGRNMatchingFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SwitchOnGRNMatchingSpecified() As Boolean
            Get
                Return Me.switchOnGRNMatchingFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory if GRN matching is required and must contain a new GRN number, when processing a normal receipt or a receipt into inspection and GRN number is not automatic.
        '''This element is always mandatory when processing a receipt into stock FROM inspection.
        '''</summary>
        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = value
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
        '''This element is mandatory if GRN matching is switched on. Valid values are 1 to 5.
        '''</summary>
        Public Property GRNSource() As GRNSource
            Get
                Return Me.gRNSourceField
            End Get
            Set
                Me.gRNSourceField = value
                Me.GRNSourceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GRNSourceSpecified() As Boolean
            Get
                Return Me.gRNSourceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only required if ABC costing is in use. If not supplied and ABC costing is required, it defaults to 'N'. Valid values are 'N' and 'Y'.
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
        '''This element is mandatory if receiving a traceable item.
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
        '''This element is optional and contains the expiry date of the lot supplied, if processing a traceable item. Format must be CCYY-MM-DD.
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
        '''This is the top element for the set of bins affected by this transaction. Mandatory if multiple bins are installed.
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
        '''This element is used to specify a prefix and suffix or starting serial number for a range of new serial numbers to be generated. It is only valid when processing receipts or receipts into inspection for manual serialized stock items. It has two formats, depending on the serial key type. If serial numbers are ALPHANUMERIC, a prefix and a suffix need to be supplied. If serial numbers are NUMERIC, a starting serial number is required.
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
        '''This element allows the purchase order line to be set to complete upon completion of the receipt. When set to a Y, the purchase order line will be marked as complete, regardless of the quantity remaining.
        '''</summary>
        Public Property PurchaseOrderLineComplete() As PurchaseOrderLineComplete
            Get
                Return Me.purchaseOrderLineCompleteField
            End Get
            Set
                Me.purchaseOrderLineCompleteField = value
                Me.PurchaseOrderLineCompleteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PurchaseOrderLineCompleteSpecified() As Boolean
            Get
                Return Me.purchaseOrderLineCompleteFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. If the Purchase Order is linked to a Sales Order and the receipt quantity is greater than the order quantity, the order quantity will be increased to the receipt quantity, if this element is set to 'Y'. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property IncreaseSalesOrderQuantity() As IncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set
                Me.increaseSalesOrderQuantityField = value
                Me.IncreaseSalesOrderQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncreaseSalesOrderQuantitySpecified() As Boolean
            Get
                Return Me.increaseSalesOrderQuantityFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. If the Purchase Order is linked to a Sales Order, this element can be set to 'Y' if the Sales Order status needs to be changed from '2' (in backorder) to '3' (released backorder). If credit checking is required for the customer and it fails, the sales order may go into 'S' (suspense). Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property ChangeSalesOrderStatus() As ChangeSalesOrderStatus
            Get
                Return Me.changeSalesOrderStatusField
            End Get
            Set
                Me.changeSalesOrderStatusField = value
                Me.ChangeSalesOrderStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChangeSalesOrderStatusSpecified() As Boolean
            Get
                Return Me.changeSalesOrderStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element indicates whether or not a cost multiplier must be applied to the cost of the receipt. If not supplied it defaults to 'N'. Valid values are 'N' and 'Y'.
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
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If supplied, it will overwrite the default ledger code defined in General Ledger Integration.
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
        '''If the ledger code requires a password, this element must contain the relevant password for the specified ledger code.
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
        '''Only required if receiving a non-stocked item. If supplied overwrites the default ledger code specified in SYSPRO.
        '''</summary>
        Public Property DebitLedgerCode() As String
            Get
                Return Me.debitLedgerCodeField
            End Get
            Set
                Me.debitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If the debit ledger code requires a password, this element must contain the relevant password for the specified ledger code.
        '''</summary>
        Public Property PasswordForDebitLedgerCode() As String
            Get
                Return Me.passwordForDebitLedgerCodeField
            End Get
            Set
                Me.passwordForDebitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property CountryOfOrigin() As String
            Get
                Return Me.countryOfOriginField
            End Get
            Set
                Me.countryOfOriginField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property NatureOfTransaction() As String
            Get
                Return Me.natureOfTransactionField
            End Get
            Set
                Me.natureOfTransactionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property ModeOfTransport() As String
            Get
                Return Me.modeOfTransportField
            End Get
            Set
                Me.modeOfTransportField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property TradersReference() As String
            Get
                Return Me.tradersReferenceField
            End Get
            Set
                Me.tradersReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required. Valid values are 'N' and 'Y'. Default 
        '''</summary>
        Public Property SupplementaryUnits() As SupplementaryUnits
            Get
                Return Me.supplementaryUnitsField
            End Get
            Set
                Me.supplementaryUnitsField = value
                Me.SupplementaryUnitsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SupplementaryUnitsSpecified() As Boolean
            Get
                Return Me.supplementaryUnitsFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SwitchOnGRNMatching
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
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
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1. If within the 'SerialRange' group, it is the total quantity in the stocking unit of measure, to be received for the specified range.
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
        '''If stock code is a unit-qty type stock code and the SerialQuantity element is not supplied, the quantity of each serial must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''If stock code is a unit-qty type stock code and the SerialQuantity element is not supplied, the quantity of each serial must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock. Valid format is 'CCYY-MM-DD'.
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
        '''This element contains the location of the serial number or range of serial numbers being received when processing a Purchase Order receipt.
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
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1. If within the 'SerialRange' group, it is the total quantity in the stocking unit of measure, to be received for the specified range.
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
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock. Valid format is 'CCYY-MM-DD'.
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
        '''This element contains the location of the serial number or range of serial numbers being received when processing a Purchase Order receipt.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PurchaseOrderLineComplete
        
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
        Private nmSupplierField As String
        
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
        '''This element is mandatory if GRN matching is switched on.
        '''</summary>
        Public Property NmSupplier() As String
            Get
                Return Me.nmSupplierField
            End Get
            Set
                Me.nmSupplierField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the non-merchandise amount to be posted to the corresponding ledger code. The total 'NmAmount' distributed must match the non-merchandise cost (either supplied or calculated).
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SupplementaryUnits
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class ReceiptIntoInspection

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private purchaseOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private purchaseOrderLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private quantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitOfMeasureField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private piecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private countedQuantityCompleteField As CountedQuantityComplete

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private countedQuantityCompleteFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private deliveryNoteField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private deliveryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private certificateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private narrationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private switchOnGRNMatchingField As SwitchOnGRNMatching

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private switchOnGRNMatchingFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private gRNNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private purchaseOrderLineCompleteField As PurchaseOrderLineComplete

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private purchaseOrderLineCompleteFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialsField As List(Of Serials)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialRangeField As List(Of SerialRange)

        Public Sub New()
            MyBase.New()
            Me.countedQuantityCompleteField = CountedQuantityComplete.N
            Me.switchOnGRNMatchingField = SwitchOnGRNMatching.N
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New List(Of SerialRange)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
        End Sub

        '''<summary>
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the specified posting period and warehouse and may not have been printed already. If not supplied, a new journal will be created.
        '''</summary>
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory and contains the Purchase Order being received.
        '''</summary>
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set(ByVal value As String)
                Me.purchaseOrderField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the Purchase Order line being received. If this is not supplied, the 'Warehouse' and 'StockCode' elements must be given so that the correct Purchase Order line can be identified. If there is more than one line for the same warehouse/stock code, the earliest Purchase Order line will be received.
        '''</summary>
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set(ByVal value As String)
                Me.purchaseOrderLineField = Value
            End Set
        End Property

        '''<summary>
        '''This element must be supplied if a 'PurchaseOrderLine' element is not entered.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set(ByVal value As String)
                Me.warehouseField = Value
            End Set
        End Property

        '''<summary>
        '''This element must be supplied if a 'PurchaseOrderLine' was not entered.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set(ByVal value As String)
                Me.stockCodeField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. It must not be negative.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set(ByVal value As String)
                Me.quantityField = Value
            End Set
        End Property

        '''<summary>
        '''If quantity was supplied in a unit of measure different from the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set(ByVal value As String)
                Me.unitOfMeasureField = Value
            End Set
        End Property

        '''<summary>
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set(ByVal value As String)
                Me.unitsField = Value
            End Set
        End Property

        '''<summary>
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set(ByVal value As String)
                Me.piecesField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and indicates whether the quantity has been counted or not. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property CountedQuantityComplete() As CountedQuantityComplete
            Get
                Return Me.countedQuantityCompleteField
            End Get
            Set(ByVal value As CountedQuantityComplete)
                Me.countedQuantityCompleteField = Value
                Me.countedQuantityCompleteFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property CountedQuantityCompleteSpecified() As Boolean
            Get
                Return Me.countedQuantityCompleteFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is optional and contains the supplier's delivery note.
        '''</summary>
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set(ByVal value As String)
                Me.deliveryNoteField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and contains the delivery date of the receipt. Format must be CCYY-MM-DD. If not supplied it defaults to rundate.
        '''</summary>
        Public Property DeliveryDate() As String
            Get
                Return Me.deliveryDateField
            End Get
            Set(ByVal value As String)
                Me.deliveryDateField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and contains the certificate number.
        '''</summary>
        Public Property Certificate() As String
            Get
                Return Me.certificateField
            End Get
            Set(ByVal value As String)
                Me.certificateField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional.
        '''</summary>
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set(ByVal value As String)
                Me.narrationField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and indicates whether GRN matching must be switched on for a supplier, should it be switched off. However, if the parameter 'GRNMatchingAction' is set to 'R' and GRN matching is switched off, the transaction will reject. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property SwitchOnGRNMatching() As SwitchOnGRNMatching
            Get
                Return Me.switchOnGRNMatchingField
            End Get
            Set(ByVal value As SwitchOnGRNMatching)
                Me.switchOnGRNMatchingField = Value
                Me.switchOnGRNMatchingFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property SwitchOnGRNMatchingSpecified() As Boolean
            Get
                Return Me.switchOnGRNMatchingFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is mandatory if GRN matching is required and must contain a new GRN number, when processing a normal receipt or a receipt into inspection and GRN number is not automatic.
        '''This element is always mandatory when processing a receipt into stock FROM inspection.
        '''</summary>
        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set(ByVal value As String)
                Me.gRNNumberField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory if receiving a traceable item.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set(ByVal value As String)
                Me.lotField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and contains the expiry date of the lot supplied, if processing a traceable item. Format must be CCYY-MM-DD.
        '''</summary>
        Public Property LotExpiryDate() As String
            Get
                Return Me.lotExpiryDateField
            End Get
            Set(ByVal value As String)
                Me.lotExpiryDateField = Value
            End Set
        End Property

        '''<summary>
        '''This element allows the purchase order line to be set to complete upon completion of the receipt. When set to a Y, the purchase order line will be marked as complete, regardless of the quantity remaining.
        '''</summary>
        Public Property PurchaseOrderLineComplete() As PurchaseOrderLineComplete
            Get
                Return Me.purchaseOrderLineCompleteField
            End Get
            Set(ByVal value As PurchaseOrderLineComplete)
                Me.purchaseOrderLineCompleteField = Value
                Me.purchaseOrderLineCompleteFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property PurchaseOrderLineCompleteSpecified() As Boolean
            Get
                Return Me.purchaseOrderLineCompleteFieldSpecified
            End Get
        End Property

        '''<summary>
        '''A set of serial numbers and relevant information must be supplied if stock item specified is serialized.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Serials")> _
        Public Property SerialsCollection() As List(Of Serials)
            Get
                Return Me.serialsField
            End Get
            Set(ByVal value As List(Of Serials))
                Me.serialsField = Value
            End Set
        End Property

        '''<summary>
        '''This element is used to specify a prefix and suffix or starting serial number for a range of new serial numbers to be generated. It is only valid when processing receipts or receipts into inspection for manual serialized stock items. It has two formats, depending on the serial key type. If serial numbers are ALPHANUMERIC, a prefix and a suffix need to be supplied. If serial numbers are NUMERIC, a starting serial number is required.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("SerialRange")> _
        Public Property SerialRangeCollection() As List(Of SerialRange)
            Get
                Return Me.serialRangeField
            End Get
            Set(ByVal value As List(Of SerialRange))
                Me.serialRangeField = Value
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
    Partial Public Class ReceiptFromInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private concessionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNSourceField As GRNSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNSourceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsField As UseSingleTypeABCElements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As List(Of Bins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectAvailableSerialsField As SelectAvailableSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectAvailableSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityField As IncreaseSalesOrderQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderStatusField As ChangeSalesOrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderStatusFieldSpecified As Boolean
        
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
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForDebitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countryOfOriginField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private natureOfTransactionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private modeOfTransportField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tradersReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsField As SupplementaryUnits
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.useSingleTypeABCElementsField = UseSingleTypeABCElements.N
            Me.selectAvailableSerialsField = SelectAvailableSerials.N
            Me.increaseSalesOrderQuantityField = IncreaseSalesOrderQuantity.N
            Me.changeSalesOrderStatusField = ChangeSalesOrderStatus.N
            Me.applyCostMultiplierField = ApplyCostMultiplier.N
            Me.supplementaryUnitsField = SupplementaryUnits.N
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of NonMerchandiseDistribution)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of Bins)
            End If
        End Sub
        
        '''<summary>
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the specified posting period and warehouse and may not have been printed already. If not supplied, a new journal will be created.
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
        '''This element is mandatory if GRN matching is required and must contain a new GRN number, when processing a normal receipt or a receipt into inspection and GRN number is not automatic.
        '''This element is always mandatory when processing a receipt into stock FROM inspection.
        '''</summary>
        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. It must not be negative.
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
        '''If quantity was supplied in a unit of measure different from the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. None of the quantity fields may be negative.
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
        '''This element is optional and contains the supplier's delivery note.
        '''</summary>
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.
        '''</summary>
        Public Property Concession() As String
            Get
                Return Me.concessionField
            End Get
            Set
                Me.concessionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and need only be supplied when 'CostBasis' is set to 'M' (manual cost) or 'T' (total cost). It contains the cost of the specified stock code and if it is specified as a total cost, the unit cost will be calculated.
        '''</summary>
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must specify which cost to use for the Purchase Order receipt. Valid values are:
        '''C - Current warehouse cost
        '''T - Total cost entered manually
        '''M - Unit cost entered manually
        '''P - Purchase price
        '''X - Purchase price plus tax
        '''</summary>
        Public Property CostBasis() As String
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
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
        '''This element is mandatory if GRN matching is switched on. Valid values are 1 to 5.
        '''</summary>
        Public Property GRNSource() As GRNSource
            Get
                Return Me.gRNSourceField
            End Get
            Set
                Me.gRNSourceField = value
                Me.GRNSourceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GRNSourceSpecified() As Boolean
            Get
                Return Me.gRNSourceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only required if ABC costing is in use. If not supplied and ABC costing is required, it defaults to 'N'. Valid values are 'N' and 'Y'.
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
        '''This is the top element for the set of bins affected by this transaction. Mandatory if multiple bins are installed.
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
        '''This element is optional. Valid values are 'N' and 'Y'. Default is 'N'.
        '''When accepting a serialized stock item into stock FROM inspection and this element is set to 'Y', the inspected serial numbers available for the stock item being processed are used until the quantity supplied is satisfied. The 'Serials' data group must not be supplied. This is only applicable to Manual serial items.
        '''</summary>
        Public Property SelectAvailableSerials() As SelectAvailableSerials
            Get
                Return Me.selectAvailableSerialsField
            End Get
            Set
                Me.selectAvailableSerialsField = value
                Me.SelectAvailableSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SelectAvailableSerialsSpecified() As Boolean
            Get
                Return Me.selectAvailableSerialsFieldSpecified
            End Get
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
        '''This element is optional. If the Purchase Order is linked to a Sales Order and the receipt quantity is greater than the order quantity, the order quantity will be increased to the receipt quantity, if this element is set to 'Y'. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property IncreaseSalesOrderQuantity() As IncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set
                Me.increaseSalesOrderQuantityField = value
                Me.IncreaseSalesOrderQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncreaseSalesOrderQuantitySpecified() As Boolean
            Get
                Return Me.increaseSalesOrderQuantityFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. If the Purchase Order is linked to a Sales Order, this element can be set to 'Y' if the Sales Order status needs to be changed from '2' (in backorder) to '3' (released backorder). If credit checking is required for the customer and it fails, the sales order may go into 'S' (suspense). Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property ChangeSalesOrderStatus() As ChangeSalesOrderStatus
            Get
                Return Me.changeSalesOrderStatusField
            End Get
            Set
                Me.changeSalesOrderStatusField = value
                Me.ChangeSalesOrderStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChangeSalesOrderStatusSpecified() As Boolean
            Get
                Return Me.changeSalesOrderStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element indicates whether or not a cost multiplier must be applied to the cost of the receipt. If not supplied it defaults to 'N'. Valid values are 'N' and 'Y'.
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
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If supplied, it will overwrite the default ledger code defined in General Ledger Integration.
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
        '''If the ledger code requires a password, this element must contain the relevant password for the specified ledger code.
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
        '''Only required if receiving a non-stocked item. If supplied overwrites the default ledger code specified in SYSPRO.
        '''</summary>
        Public Property DebitLedgerCode() As String
            Get
                Return Me.debitLedgerCodeField
            End Get
            Set
                Me.debitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If the debit ledger code requires a password, this element must contain the relevant password for the specified ledger code.
        '''</summary>
        Public Property PasswordForDebitLedgerCode() As String
            Get
                Return Me.passwordForDebitLedgerCodeField
            End Get
            Set
                Me.passwordForDebitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property CountryOfOrigin() As String
            Get
                Return Me.countryOfOriginField
            End Get
            Set
                Me.countryOfOriginField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property NatureOfTransaction() As String
            Get
                Return Me.natureOfTransactionField
            End Get
            Set
                Me.natureOfTransactionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property ModeOfTransport() As String
            Get
                Return Me.modeOfTransportField
            End Get
            Set
                Me.modeOfTransportField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property TradersReference() As String
            Get
                Return Me.tradersReferenceField
            End Get
            Set
                Me.tradersReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required.
        '''</summary>
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It is only required if EC VAT system is required. Valid values are 'N' and 'Y'. Default 
        '''</summary>
        Public Property SupplementaryUnits() As SupplementaryUnits
            Get
                Return Me.supplementaryUnitsField
            End Get
            Set
                Me.supplementaryUnitsField = value
                Me.SupplementaryUnitsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SupplementaryUnitsSpecified() As Boolean
            Get
                Return Me.supplementaryUnitsFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SelectAvailableSerials
        
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
    Partial Public Class PostPurchaseOrderReceipts
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As New List(Of Item)
        
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
                Return "PORTOR"
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
                Dim objParams As Params.PostPurchaseOrderReceipts
                objParams = New Params.PostPurchaseOrderReceipts
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
