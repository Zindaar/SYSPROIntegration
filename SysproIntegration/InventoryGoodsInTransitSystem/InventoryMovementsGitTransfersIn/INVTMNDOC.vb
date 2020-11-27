Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryGoodsInTransitSystem.InventoryMovementsGitTransfersIn.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ActionBackToSource
        
        '''<remarks/>
        I
        
        '''<remarks/>
        A
    End Enum
    
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionBackToSourceField As ActionBackToSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionBackToSourceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private targetBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expenseLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As Lot
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceBinsField As List(Of SourceBins)
        
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
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.applyCostMultiplierField = ApplyCostMultiplier.N
            If (Me.nonMerchandiseDistributionField Is Nothing) Then
                Me.nonMerchandiseDistributionField = New List(Of NonMerchandiseDistribution)
            End If
            If (Me.sourceBinsField Is Nothing) Then
                Me.sourceBinsField = New List(Of SourceBins)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
            If (Me.lotField Is Nothing) Then
                Me.lotField = New Lot
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
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
        '''This is the top element specifying the key of the GIT transaction to be processed. It must be the key to a record in the GtrDetail table.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the quantity to be accepted into the target warehouse and must only be supplied if NOT transferring the total outstanding quantity. It must not be negative.
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
        '''This element contains the number of units to be accepted into the target warehouse and must only be supplied if NOT transferring the total outstanding quantity. This is only applicable to 'unit-qty type' stock items. It must not be negative.
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
        '''This element contains the number of pieces to be accepted into the target warehouse and must only be supplied if NOT transferring the total outstanding quantity. This is only applicable to 'unit-qty type' stock items. It must not be negative.
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
        '''This element is only required if the quantity being accepted into the target warehouse is NOT the total outstanding quantity but the GIT transfer must be flagged as completed. In this case, the quantity supplied in the 'Quantity', 'Units' or 'Pieces' elements are accepted into the target warehouse and the remaining quantity will be either adjusted back to the source warehouse or treated as an expense issue. Valid values are 'A' for an adjustment or 'I' for an expense issue.
        '''</summary>
        Public Property ActionBackToSource() As ActionBackToSource
            Get
                Return Me.actionBackToSourceField
            End Get
            Set
                Me.actionBackToSourceField = value
                Me.ActionBackToSourceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ActionBackToSourceSpecified() As Boolean
            Get
                Return Me.actionBackToSourceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the target bin location, if it differs from the original GIT transfer bin location. If the parameter element 'CreateBinLocation' is set to 'N' and the target bin location does not exist, the transaction will be rejected.
        '''</summary>
        Public Property TargetBin() As String
            Get
                Return Me.targetBinField
            End Get
            Set
                Me.targetBinField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the ledger account code to which an expense issue must be posted, if it differs from the default already set in SYSPRO 6.0.
        '''If supplied, it must be a valid ledger account.
        '''</summary>
        Public Property ExpenseLedgerCode() As String
            Get
                Return Me.expenseLedgerCodeField
            End Get
            Set
                Me.expenseLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element must contain a valid password, if the 'ExpenseLedgerCode' supplied is password-protected.
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
        '''This is the top element for the data relating to the lot being received into the target warehouse, if the stock item is lot traceable.
        '''</summary>
        Public Property Lot() As Lot
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        '''<summary>
        '''This is a top element for all data relating to a specific serial number.
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
        '''This is the top element for the data required for posting back to a bin in the source warehouse. Source bins are only required if Multiple Bins are installed and the stock item is NOT lot traceable.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("SourceBins")>  _
        Public Property SourceBinsCollection() As List(Of SourceBins)
            Get
                Return Me.sourceBinsField
            End Get
            Set
                Me.sourceBinsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not a cost multiplier must be applied to the cost of the GIT transfer. If not supplied it defaults to 'N'. Valid values are 'N' and 'Y'.
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
        '''This element contains the cost multiplier to be applied to the cost of the GIT transfer and only takes effect if 'ApplyCostMultiplier' is set to 'Y' and the cost multiplier against the warehouse is greater than 1.00. If this is not supplied, the warehouse cost multiplier is used.
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
        '''This is the top element for the non-merchandise distribution. If the element 'ApplyCostMultiplier' is set to 'Y', this is mandatory.
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gtrReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private targetWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        '''<summary>
        '''This element is mandatory and must contain the GTR reference number to be processed.
        '''</summary>
        Public Property GtrReference() As String
            Get
                Return Me.gtrReferenceField
            End Get
            Set
                Me.gtrReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain the source warehouse relating to the transaction to be processed.
        '''</summary>
        Public Property SourceWarehouse() As String
            Get
                Return Me.sourceWarehouseField
            End Get
            Set
                Me.sourceWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain the target warehouse relating to the transaction to be processed.
        '''</summary>
        Public Property TargetWarehouse() As String
            Get
                Return Me.targetWarehouseField
            End Get
            Set
                Me.targetWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain the line number corresponding to the transaction to be processed.
        '''</summary>
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
    Partial Public Class Lot
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotBinField As String
        
        '''<summary>
        '''If GIT transfer is for a lot-traceable stock item and the quantity being accepted is not the total outstanding quantity, the lot number for the quantity being accepted must be supplied. Only one lot must be supplied each time.
        '''</summary>
        Public Property LotNumber() As String
            Get
                Return Me.lotNumberField
            End Get
            Set
                Me.lotNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''If Multiple Bins are installed, the bin relating to the specified lot number being received into the target warehouse must be specified.
        '''</summary>
        Public Property LotBin() As String
            Get
                Return Me.lotBinField
            End Get
            Set
                Me.lotBinField = value
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
        '''If GIT transfer is for a serialized stock item and the quantity being accepted is not the total outstanding quantity, the serial numbers corresponding to the quantity being accepted must be supplied.
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
        '''If GIT transfer is for a serialized stock item and the quantity being accepted is not the total outstanding quantity, the quantity corresponding to each serial number being accepted must be supplied.
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
        '''This element contains the number of units to be accepted into the target warehouse and must only be supplied if NOT transferring the total outstanding quantity. This is only applicable when the 'SerialQuantity' element is not supplied. It must not be negative. This element is only valid for batch serialized items.
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
        '''This element contains the number of pieces to be accepted into the target warehouse and must only be supplied if NOT transferring the total outstanding quantity. This is only applicable when the 'SerialQuantity' element is not supplied. It must not be negative. This element is only valid for batch serialized items.
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
    Partial Public Class SourceBins
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binPiecesField As String
        
        '''<summary>
        '''If 'ActionBackToSource' is set to 'A' i.e. adjustment back to source warehouse, this element must contain the bin location to which the adjustment must be made.
        '''</summary>
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set(value As String)
                Me.binLocationField = Value
            End Set
        End Property
        
        '''<summary>
        '''If 'ActionBackToSource' is set to 'A' i.e. adjustment back to source warehouse, this element must contain the quantity to be adjusted to the source bin location specified in 'BinLocation'.
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
        '''If 'ActionBackToSource' is set to 'A' i.e. adjustment back to source warehouse, this element must contain the quantity to be adjusted to the source bin location specified in 'BinLocation'. This element is only applicable to 'unit-qty type' stock items.
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
        '''If 'ActionBackToSource' is set to 'A' i.e. adjustment back to source warehouse, this element must contain the quantity to be adjusted to the source bin location specified in 'BinLocation'. This element is only applicable to 'unit-qty type' stock items.
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
    Partial Public Class NonMerchandiseDistribution
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmAmountField As String
        
        '''<summary>
        '''This element is mandatory if non-merchandised distribution is done.
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
        '''If not supplied, the default cost multiplier ledger code defined against the GIT warehouse is used. If this is blank, the cost multiplier ledger code defined against the warehouse in the Warehouse Matrix is used.
        '''If this is also blank, the transaction will be rejected.
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
    Partial Public Class PostInvGitWhTransferIn
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
                Return "INVTMN"
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
                Dim objParams As Params.PostInvGitWhTransferIn
                objParams = New Params.PostInvGitWhTransferIn
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
