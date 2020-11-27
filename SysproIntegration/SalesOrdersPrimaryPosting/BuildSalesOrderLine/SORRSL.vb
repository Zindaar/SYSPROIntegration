Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.BuildSalesOrderLine.BuildData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Build
        Implements Codewell.SysproIntegration.IBuild
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IBuild.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IBuild.BusinessObject
            Get
                Return "SORRSL"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IBuild.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IBuild.Post
            Me._xmlOut = TransactionObject.Build(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
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
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfOrderField As TypeOfOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfOrderFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exemptStatusField As ExemptStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exemptStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockSalesOrderTextField As IncludeStockSalesOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private includePriceListField As IncludePriceList

        <EditorBrowsable(EditorBrowsableState.Never)> _
Private includeStockSalesOrderTextFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private includePriceListFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDangerousGoodsTextField As IncludeDangerousGoodsText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDangerousGoodsTextFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeServiceChargesField As IncludeServiceCharges
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeServiceChargesFieldSpecified As Boolean
        
        '''<summary>
        '''Enter the stock code for the order line. If the stock code is not valid the program will access the customer/stock code interchange file for a match - if a match is found then the program will return the inventory stock code.
        '''The stock code must be non-blank and valid.
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
        '''Enter the warehouse from where the stock is to be sold. This is only required when discounts or customer contracts are based on unit cost.
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
        '''Enter the customer whom this order is for. This is a compulsory field.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter the type of sales order (O = normal order, I = IBT, C = Credit Note, D = Debit Note, S = Scheduled Order). If this is left blank then type O is assumed.
        '''</summary>
        Public Property TypeOfOrder() As TypeOfOrder
            Get
                Return Me.typeOfOrderField
            End Get
            Set
                Me.typeOfOrderField = value
                Me.TypeOfOrderFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeOfOrderSpecified() As Boolean
            Get
                Return Me.typeOfOrderFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the tax exempt status to be used (E = tax exempt, N = taxable, O = taxable using the "Other tax code"). If this is left blank the value against the customer will be used.
        '''</summary>
        Public Property ExemptStatus() As ExemptStatus
            Get
                Return Me.exemptStatusField
            End Get
            Set
                Me.exemptStatusField = value
                Me.ExemptStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExemptStatusSpecified() As Boolean
            Get
                Return Me.exemptStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the order quantity to be used. If this is left blank, 1.000 is assumed.
        '''</summary>
        Public Property OrderQuantity() As String
            Get
                Return Me.orderQuantityField
            End Get
            Set
                Me.orderQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter the unit of measure to be used. If this is left blank, the stocking unit of measure from the stock code will be used.
        '''</summary>
        Public Property OrderUm() As String
            Get
                Return Me.orderUmField
            End Get
            Set
                Me.orderUmField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
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
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
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
        '''Enter the order date. This date is used to determine supercession dates, pricing and the line ship date. If no date is supplied then today's date will be applied.
        '''</summary>
        Public Property OrderDate() As String
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter 'Y' if any standard text attached to the stock code is to be returned. Valid entries are 'N' - No, and 'Y' - Yes. The default is 'N'.
        '''</summary>
        Public Property IncludeStockSalesOrderText() As IncludeStockSalesOrderText
            Get
                Return Me.includeStockSalesOrderTextField
            End Get
            Set
                Me.includeStockSalesOrderTextField = value
                Me.IncludeStockSalesOrderTextFieldSpecified = true
            End Set
        End Property

        Public Property IncludePriceList() As IncludePriceList
            Get
                Return Me.includePriceListField
            End Get
            Set(value As IncludePriceList)
                Me.includePriceListField = value
                Me.IncludePriceListFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeStockSalesOrderTextSpecified() As Boolean
            Get
                Return Me.includeStockSalesOrderTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter 'Y' if any dangerous goods text attached to the stock code is to be returned. Valid entries are 'N' - No, and 'Y' - Yes. The default is 'N'.
        '''</summary>
        Public Property IncludeDangerousGoodsText() As IncludeDangerousGoodsText
            Get
                Return Me.includeDangerousGoodsTextField
            End Get
            Set
                Me.includeDangerousGoodsTextField = value
                Me.IncludeDangerousGoodsTextFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeDangerousGoodsTextSpecified() As Boolean
            Get
                Return Me.includeDangerousGoodsTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter 'Y' if any service charges attached to the stock code are to be returned. Valid entries are 'N' - No, and 'Y' - Yes. The default is 'N'.
        '''</summary>
        Public Property IncludeServiceCharges() As IncludeServiceCharges
            Get
                Return Me.includeServiceChargesField
            End Get
            Set
                Me.includeServiceChargesField = value
                Me.IncludeServiceChargesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeServiceChargesSpecified() As Boolean
            Get
                Return Me.includeServiceChargesFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TypeOfOrder
        
        '''<remarks/>
        O
        
        '''<remarks/>
        I
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ExemptStatus
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeStockSalesOrderText
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum IncludePriceList

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")> _
        Item
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeDangerousGoodsText
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeServiceCharges
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
