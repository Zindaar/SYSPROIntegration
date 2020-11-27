Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.ListOfStockCodesFilteredByOperatorAccess.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockCodeList
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As StockCodeListOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As StockCodeListFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New StockCodeListFilter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New StockCodeListOption
            End If
        End Sub
        
        Public Property [Option]() As StockCodeListOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Filter() As StockCodeListFilter
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
                Return "INVQSL"
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
    Partial Public Class StockCodeListOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterOnCustomerField As StockCodeListOptionFilterOnCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterOnOperatorWhseField As StockCodeListOptionFilterOnOperatorWhse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As StockCodeListOptionSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxRowsToReturnField As String
        
        Public Sub New()
            MyBase.New
            Me.filterOnCustomerField = StockCodeListOptionFilterOnCustomer.N
            Me.filterOnOperatorWhseField = StockCodeListOptionFilterOnOperatorWhse.Y
            Me.sequenceField = StockCodeListOptionSequence.S
            Me.maxRowsToReturnField = "100"
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(StockCodeListOptionFilterOnCustomer.N)>  _
        Public Property FilterOnCustomer() As StockCodeListOptionFilterOnCustomer
            Get
                Return Me.filterOnCustomerField
            End Get
            Set
                Me.filterOnCustomerField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(StockCodeListOptionFilterOnOperatorWhse.Y)>  _
        Public Property FilterOnOperatorWhse() As StockCodeListOptionFilterOnOperatorWhse
            Get
                Return Me.filterOnOperatorWhseField
            End Get
            Set
                Me.filterOnOperatorWhseField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(StockCodeListOptionSequence.S)>  _
        Public Property Sequence() As StockCodeListOptionSequence
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("100")>  _
        Public Property MaxRowsToReturn() As String
            Get
                Return Me.maxRowsToReturnField
            End Get
            Set
                Me.maxRowsToReturnField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListOptionFilterOnCustomer
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListOptionFilterOnOperatorWhse
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListOptionSequence
        
        '''<remarks/>
        S
        
        '''<remarks/>
        D
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockCodeListFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCodeListFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As StockCodeListFilterCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As StockCodeListFilterWarehouse
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New StockCodeListFilterWarehouse
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New StockCodeListFilterCustomer
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCodeListFilterStockCode
            End If
        End Sub
        
        Public Property StockCode() As StockCodeListFilterStockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Customer() As StockCodeListFilterCustomer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property Warehouse() As StockCodeListFilterWarehouse
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
    Partial Public Class StockCodeListFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As StockCodeListFilterStockCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As StockCodeListFilterStockCodeFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
                Me.FilterTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FilterTypeSpecified() As Boolean
            Get
                Return Me.filterTypeFieldSpecified
            End Get
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListFilterStockCodeFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockCodeListFilterCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As StockCodeListFilterCustomerFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As StockCodeListFilterCustomerFilterType
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListFilterCustomerFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class StockCodeListFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As StockCodeListFilterWarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As StockCodeListFilterWarehouseFilterType
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum StockCodeListFilterWarehouseFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
    End Enum
End Namespace
