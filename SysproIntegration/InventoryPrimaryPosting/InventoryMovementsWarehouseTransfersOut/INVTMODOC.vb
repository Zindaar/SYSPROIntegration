Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryPosting.InventoryMovementsWarehouseTransfersOut.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Immediate
        
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
    Partial Public Class PostInvWhTransferOut
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This is the top element fo all data required for the transaction.
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
                Return "INVTMO"
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
                Dim objParams As Params.PostInvWhTransferOut
                objParams = New Params.PostInvWhTransferOut
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private immediateField As Immediate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private immediateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private noDestinationField As NoDestination
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private noDestinationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromBinField As String
        
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
        Private toWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toWhJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialAllocationField As List(Of SerialAllocation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.immediateField = Immediate.N
            Me.noDestinationField = NoDestination.N
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of SerialAllocation)
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
            Set
                Me.journalField = value
            End Set
        End Property
        
        '''<summary>
        '''If processing an immediate warehouse transfer, this element must contain 'Y'. If this is not supplied or is set to 'N' a normal transfer OUT transaction is processed.Defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property Immediate() As Immediate
            Get
                Return Me.immediateField
            End Get
            Set
                Me.immediateField = value
                Me.ImmediateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ImmediateSpecified() As Boolean
            Get
                Return Me.immediateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If processing a warehouse transfer OUT No Destination, this element must contain 'Y'. If this is not supplied or is set to 'N' a normal transfer OUT transaction is processed.Defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property NoDestination() As NoDestination
            Get
                Return Me.noDestinationField
            End Get
            Set
                Me.noDestinationField = value
                Me.NoDestinationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NoDestinationSpecified() As Boolean
            Get
                Return Me.noDestinationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory and must stock specified stock item.
        '''</summary>
        Public Property FromWarehouse() As String
            Get
                Return Me.fromWarehouseField
            End Get
            Set
                Me.fromWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if multiple bins are installed  and must be exist in 'From' warehouse.
        '''</summary>
        Public Property FromBin() As String
            Get
                Return Me.fromBinField
            End Get
            Set
                Me.fromBinField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must be stocked in 'From' warehouse specified.
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
        '''If quantity was supplied in a unit of measure different to the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
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
        '''If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
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
        '''If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
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
        '''This element is mandatory unless transaction is a 'No Destination' transfer. Stock item specified must be stocked in this warehouse unless 'CreateDestinationWarehouse' paramenter is set to 'Y'. In this case, the warehouse will be created for this stock item.
        '''</summary>
        Public Property ToWarehouse() As String
            Get
                Return Me.toWarehouseField
            End Get
            Set
                Me.toWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if multiple bins are installed. If transaction is an 'Immediate' transfer, this bin location must exist in the 'To' warehouse.
        '''</summary>
        Public Property ToBin() As String
            Get
                Return Me.toBinField
            End Get
            Set
                Me.toBinField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the journal number to which the journal entry generated for the receiving warehouse on an immediate transfer will be added. It must be valid for the specified posting period and receiving warehouse and may not have been printed already. If not supplied, a new journal will be created.
        '''</summary>
        Public Property ToWhJournal() As String
            Get
                Return Me.toWhJournalField
            End Get
            Set
                Me.toWhJournalField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory for lot traceable stock items. Not allowed for unit-qty type stock items.
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
        '''A set of serial numbers and relevant quantities to process may be supplied, if stock item is serialized. Not allowed for unit-qty type stock items.
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
        '''This element is used to specify a range of serial numbers to be allocated. It is only valid when processing manual serialized stock items.
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
    Public Enum NoDestination
        
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
        
        '''<summary>
        '''Serial number from which serial quantity must be transferred.
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
        '''This element is mandatory and specifies the quantity to allocate for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be allocated for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
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
        '''If stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
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
        '''If stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
        '''</summary>
        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = value
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
        '''This element specifies the starting serial number to be allocated.
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
        '''This element specifies the ending serial number to be allocated. If this element is not supplied, serial numbers will be allocated starting at the FromSerialNumber until the specified quantity has been allocated.
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
        '''This element is mandatory and specifies the quantity to allocate for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be allocated for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
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
End Namespace
