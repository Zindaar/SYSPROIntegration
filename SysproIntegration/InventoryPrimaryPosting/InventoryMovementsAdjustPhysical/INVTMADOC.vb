Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostInvAdjustments
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
                Me.itemField = New List(Of Item)()
            End If
        End Sub
        
        '''<summary>
        '''This is the top element for all data required for the transaction
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
                Return "INVTMA"
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
                Dim objParams As Params.PostInvAdjustments
                objParams = New Params.PostInvAdjustments()
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
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fifoBucketField As String
        
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
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisLineEntryField As AnalysisLineEntry
        
        Public Sub New()
            MyBase.New
            If (Me.analysisLineEntryField Is Nothing) Then
                Me.analysisLineEntryField = New AnalysisLineEntry()
            End If
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of SerialAllocation)()
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)()
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
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. If processing a Physical Count, none of the quantity fields may be negative.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative.
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
        '''If multiple bins are installed, this element is mandatory.
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
        '''This element is optional. It must be supplied if FIFO is installed or FIFO/LIFO costing is used and a specific FIFO/LIFO bucket is to be adjusted. Note that a FIFO bucket of zeros is valid and is the first bucket on file.
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
        '''This element is mandatory for lot traceable stock codes. Not allowed for unit-qty type stock codes.
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
        '''If ledger codes require a password, this element must contain the relevant password.
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
        '''A set of serial numbers and relevant quantities to process may be supplied for serialized stock codes. Not allowed for unit-qty type stock codes.
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
        
        '''<summary>
        '''If an analysis entry number has been assigned to this detail line, then use this element to store the analysis entry number. If Analysis Line entry is passed then that will overwrite and analysis number supplied in the AnalysisEntry element. 
        '''</summary>
        Public Property AnalysisEntry() As String
            Get
                Return Me.analysisEntryField
            End Get
            Set
                Me.analysisEntryField = value
            End Set
        End Property
        
        '''<summary>
        '''If IgnoreAnalysis is set to 'Y" this node and all it's elements are ignored. If you are supplying your own AnalysisEntry Number ensure that you have set IgnoreAnalysis to "Y"
        '''</summary>
        Public Property AnalysisLineEntry() As AnalysisLineEntry
            Get
                Return Me.analysisLineEntryField
            End Get
            Set
                Me.analysisLineEntryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
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
        Private serialFifoBucketField As String
        
        '''<summary>
        '''Serial number to adjust for a serialized stock code.
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
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be received for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
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
        '''If stock code is a unit-qty type stock code and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative. This element is only valid for batch serialized items.
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
        '''If stock code is a unit-qty type stock code and serialquantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative.This element is only valid for batch serialized items.
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
        '''This element is optional.It is only required for Batch Serialized items if Actual Costing is by Serials.
        '''</summary>
        Public Property SerialFifoBucket() As String
            Get
                Return Me.serialFifoBucketField
            End Get
            Set
                Me.serialFifoBucketField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
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
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be received for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class AnalysisLineEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set
                Me.analysisCode1Field = value
            End Set
        End Property
        
        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set
                Me.analysisCode2Field = value
            End Set
        End Property
        
        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set
                Me.analysisCode3Field = value
            End Set
        End Property
        
        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set
                Me.analysisCode4Field = value
            End Set
        End Property
        
        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set
                Me.analysisCode5Field = value
            End Set
        End Property
        
        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = value
            End Set
        End Property
        
        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = value
            End Set
        End Property
        
        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set
                Me.entryAmountField = value
            End Set
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
    End Class
End Namespace
