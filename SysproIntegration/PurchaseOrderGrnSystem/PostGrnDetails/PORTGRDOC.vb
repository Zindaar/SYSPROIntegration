Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderGrnSystem.PostGrnDetails.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierDeliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitLedgerPasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nmDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        '''<summary>
        '''The GrnNumber element is mandatory if the 'AlwaysSupplyGrnNumbers' parameter is N, or if GRN numbering is manual.
        '''</summary>
        Public Property GrnNumber() As String
            Get
                Return Me.grnNumberField
            End Get
            Set
                Me.grnNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain the supplier code to where the GrnValue will be posted.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if posting GRN details for a purchase order receipt. If posting non-merchandise costs, this element is not required.
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
        '''This element contains the stock description to be saved for this GRN, if a stocked item is supplied. It will not change the stock description of the stock code. This element is optional.
        '''</summary>
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains a valid warehouse. If not supplied, the stock code supplied will be treated as a non-stocked item.
        '''If posting non-merchandise costs, this element is not required.
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
        '''This element is mandatory and contains the value to be posted for the supplier specified.
        '''</summary>
        Public Property GrnValue() As String
            Get
                Return Me.grnValueField
            End Get
            Set
                Me.grnValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and contains the supplier's delivery note.
        '''</summary>
        Public Property SupplierDeliveryNote() As String
            Get
                Return Me.supplierDeliveryNoteField
            End Get
            Set
                Me.supplierDeliveryNoteField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and must contain a valid ledger code if integrated to General Ledger in detail or summary.
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
        '''This element is optional and must contain the password for the debit ledger code if that code is password-secured.
        '''</summary>
        Public Property DebitLedgerPassword() As String
            Get
                Return Me.debitLedgerPasswordField
            End Get
            Set
                Me.debitLedgerPasswordField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if posting non-merchandise costs and contains the description posted against the GRN created.
        '''</summary>
        Public Property NmDescription() As String
            Get
                Return Me.nmDescriptionField
            End Get
            Set
                Me.nmDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and contains the GIT reference if called from the GIT Receipt with Apportionment program. It will be printed on the GRN Adjustment Journal.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
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
    Partial Public Class PostGrnDetails
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostGrnDetailsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
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
                Return "PORTGR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostGrnDetailsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostGrnDetailsParameters
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
                Dim objParams As Params.PostGrnDetails
                objParams = New Params.PostGrnDetails
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
