Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.InventoryStockTakeTicketDocumentQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New QueryFilter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New QueryKey
            End If
        End Sub
        
        Public Property Key() As QueryKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Filter() As QueryFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "INVQST"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfTicketsPerBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintField As QueryOptionReprint
        
        Public Sub New()
            MyBase.New
            Me.numOfTicketsPerBinField = "1"
            Me.reprintField = QueryOptionReprint.Y
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute("1")>  _
        Public Property NumOfTicketsPerBin() As String
            Get
                Return Me.numOfTicketsPerBinField
            End Get
            Set
                Me.numOfTicketsPerBinField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionReprint.Y)>  _
        Public Property Reprint() As QueryOptionReprint
            Get
                Return Me.reprintField
            End Get
            Set
                Me.reprintField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionReprint
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As QueryFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As QueryFilterBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As QueryFilterProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As QueryFilterUnitOfMeasure
        
        Public Sub New()
            MyBase.New
            If (Me.unitOfMeasureField Is Nothing) Then
                Me.unitOfMeasureField = New QueryFilterUnitOfMeasure
            End If
            If (Me.productClassField Is Nothing) Then
                Me.productClassField = New QueryFilterProductClass
            End If
            If (Me.binField Is Nothing) Then
                Me.binField = New QueryFilterBin
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New QueryFilterStockCode
            End If
        End Sub
        
        Public Property StockCode() As QueryFilterStockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Bin() As QueryFilterBin
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
            End Set
        End Property
        
        Public Property ProductClass() As QueryFilterProductClass
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As QueryFilterUnitOfMeasure
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterUnitOfMeasure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
End Namespace
