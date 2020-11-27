Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryInspectionSystem.GoodsInInspectionScraps.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CostBasis
        
        '''<remarks/>
        P
        
        '''<remarks/>
        C
        
        '''<remarks/>
        T
        
        '''<remarks/>
        M
        
        '''<remarks/>
        X
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GrnSource
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
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
        Private documentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paySupplierForScrappedItemsField As PaySupplierForScrappedItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paySupplierForScrappedItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As CostBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnSourceField As GrnSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnSourceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectAvailableSerialsField As SelectAvailableSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectAvailableSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        Public Sub New()
            MyBase.New
            Me.paySupplierForScrappedItemsField = PaySupplierForScrappedItems.N
            Me.grnSourceField = GrnSource.Item1
            Me.selectAvailableSerialsField = SelectAvailableSerials.N
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
        End Sub
        
        '''<summary>
        '''This element must contain a valid GRN number and is mandatory.
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
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. The quantity may not be less than zero.
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
        '''If quantity supplied in a unit of measure different to the stocking unit of measure, this element must be supplied to indicate the alternate unit of measure.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. The units may not be less than zero.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. The pieces may not be less than zero.
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
        '''This element is optional and contains the document number for this scrap transaction.
        '''</summary>
        Public Property Document() As String
            Get
                Return Me.documentField
            End Get
            Set
                Me.documentField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the reject code relevant for the transaction.
        '''</summary>
        Public Property RejectCode() As String
            Get
                Return Me.rejectCodeField
            End Get
            Set
                Me.rejectCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If not supplied and a reject code is supplied, the reject code description is used.
        '''</summary>
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and may be set to 'Y' if suppliers are to be paid for scrapped items. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property PaySupplierForScrappedItems() As PaySupplierForScrappedItems
            Get
                Return Me.paySupplierForScrappedItemsField
            End Get
            Set
                Me.paySupplierForScrappedItemsField = value
                Me.PaySupplierForScrappedItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PaySupplierForScrappedItemsSpecified() As Boolean
            Get
                Return Me.paySupplierForScrappedItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only required if paying supplier for scrapped items. If not supplied, the warehouse variance account is used. If this is not available, the purchase price variance control account is used.
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
        '''This element is mandatory if the operator is allowed activity 'P/O Inspection change scrap liability', otherwise it defaults to 'P'. This element specifies which cost to use for the transaction. Valid values are:
        '''C - Current warehouse cost
        '''T - Total cost entered manually
        '''M - Unit cost entered manually
        '''P - Purchase price at the time of order entry
        '''X - Purchase price plus tax.
        '''</summary>
        Public Property CostBasis() As CostBasis
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
                Me.CostBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CostBasisSpecified() As Boolean
            Get
                Return Me.costBasisFieldSpecified
            End Get
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
        '''This element is optional and if not supplied defaults to '1'. Valid values are '1' to '5'.
        '''</summary>
        Public Property GrnSource() As GrnSource
            Get
                Return Me.grnSourceField
            End Get
            Set
                Me.grnSourceField = value
                Me.GrnSourceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GrnSourceSpecified() As Boolean
            Get
                Return Me.grnSourceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'N' and 'Y'. Default is 'N'.
        '''When scrapping a serialized stock item and this element is set to 'Y', the serial numbers available for the stock item being processed are used until the quantity supplied is satisfied. This is only applicable to Manual serial items.
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
        '''A set of serial numbers and relevant information must be supplied if stock item specified is serialized and the element 'SelectAvailableSerials' is not set to 'Y' (manual serials only).
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PaySupplierForScrappedItems
        
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
        '''This element is mandatory if the stock item being scrapped is serialized. It represents the serial number to be scrapped. However, if the element 'SelectAvailableSerials' is set to 'Y', serial numbers must not be supplied.
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
        '''This element is mandatory and specifies the quantity scrapped for the specified serial number. If manual serial, it can only be 1. However, if the element 'SelectAvailableSerials' is set to 'Y', serial quantity must not be supplied.
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
        '''If stock code is a unit-qty type stock code and the SerialQuantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
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
        '''If stock code is a unit-qty type stock code and the SerialQuantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
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
    Partial Public Class PostInspectionScraps
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
                Return "PORTIS"
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
                Dim objParams As Params.PostInspectionScraps
                objParams = New Params.PostInspectionScraps
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
