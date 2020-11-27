Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.InventoryStockTakeImport.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineTypeField As LineType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyCapturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ticketNumberField As String
        
        '''<summary>
        '''The line type to make sure that this is a stock take file. This is a compulsory element and must contain an 'S'.
        '''</summary>
        Public Property LineType() As LineType
            Get
                Return Me.lineTypeField
            End Get
            Set
                Me.lineTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the warehouse in which the stock take is taking place. If this is blank the warehouse held against the header/detail supplied with INVTSC.XML, will be used.
        '''</summary>
        Public Property WarehouseCode() As String
            Get
                Return Me.warehouseCodeField
            End Get
            Set
                Me.warehouseCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The stock code/SKU number of the part being captured. This is a compulsory element if ticket numbers are not in use. If ticket numbers are in use, and a ticket number is supplied, then the stock code associated with the ticket is used.
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
        '''The quantity of stock to be captured. If using unit quantity processing this will contain the cases portion. This is a compulsory element.
        '''</summary>
        Public Property QtyCaptured() As String
            Get
                Return Me.qtyCapturedField
            End Get
            Set
                Me.qtyCapturedField = value
            End Set
        End Property
        
        '''<summary>
        '''The bin number containing the stock.
        '''</summary>
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
            End Set
        End Property
        
        '''<summary>
        '''A reference of up to nine characters.
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
        '''The serial number of the captured stock item.
        '''</summary>
        Public Property Serial() As String
            Get
                Return Me.serialField
            End Get
            Set
                Me.serialField = value
            End Set
        End Property
        
        '''<summary>
        '''If using unit quantity processing this will contain the pieces portion of the quantity.
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
        '''If the entered lot is not held on file, then you can indicate that the lot number must be created, as well as enter an expiry date for the lot. If you have indicated that the same lot number cannot be used on multiple stock codes (Setup,  Lot Traceability Setup), then you will be unable to capture the same lot number for different stock codes.
        '''
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
        '''The date that the contents of this lot expire.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property LotExpiryDate() As Date
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
                Me.LotExpiryDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LotExpiryDateSpecified() As Boolean
            Get
                Return Me.lotExpiryDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The version number of the item being captured.
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
        '''The release level of the captured stock item.
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
        '''This is a numeric element of up to 6 digits defining the ticket number if ticket numbers are in use. Use of ticket numbers is controlled by the parameters 'CaptureTicketNumbers' ( a ticket number may be supplied and will be added to the ticket file if new) and 'TicketNumbersExist' (a ticket number must already exist, and the stock code must match that on the ticket, or will be derived from the ticket). 
        '''</summary>
        Public Property TicketNumber() As String
            Get
                Return Me.ticketNumberField
            End Get
            Set
                Me.ticketNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum LineType
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockTake
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockTakeDetailField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.StockTake
        
        Public Sub New()
            MyBase.New
            If (Me.stockTakeDetailField Is Nothing) Then
                Me.stockTakeDetailField = New List(Of Item)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable:=false)>  _
        Public Property StockTakeDetailCollection() As List(Of Item)
            Get
                Return Me.stockTakeDetailField
            End Get
            Set
                Me.stockTakeDetailField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "INVTSC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.StockTake
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.StockTake
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
                Dim objParams As Params.StockTake
                objParams = Me.Params
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
    Partial Public Class StockTakeDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This element contains the details for a stock code. This will appear once for each detail line to be captured.
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
    End Class
End Namespace
