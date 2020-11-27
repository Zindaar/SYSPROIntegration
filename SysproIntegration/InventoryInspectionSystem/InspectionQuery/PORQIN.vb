Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryInspectionSystem.InspectionQuery.QueryData
    
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
        End Sub
        
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
                Return "PORQIN"
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
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedItemsField As QueryOptionIncludeNonStockedItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialNumbersField As QueryOptionIncludeSerialNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeTransactionDetailsField As QueryOptionIncludeTransactionDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedItemsField As QueryOptionIncludeCompletedItems
        
        Public Sub New()
            MyBase.New
            Me.includeNonStockedItemsField = QueryOptionIncludeNonStockedItems.Y
            Me.includeSerialNumbersField = QueryOptionIncludeSerialNumbers.Y
            Me.includeTransactionDetailsField = QueryOptionIncludeTransactionDetails.N
            Me.includeCompletedItemsField = QueryOptionIncludeCompletedItems.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStockedItems.Y)>  _
        Public Property IncludeNonStockedItems() As QueryOptionIncludeNonStockedItems
            Get
                Return Me.includeNonStockedItemsField
            End Get
            Set
                Me.includeNonStockedItemsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSerialNumbers.Y)>  _
        Public Property IncludeSerialNumbers() As QueryOptionIncludeSerialNumbers
            Get
                Return Me.includeSerialNumbersField
            End Get
            Set
                Me.includeSerialNumbersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeTransactionDetails.N)>  _
        Public Property IncludeTransactionDetails() As QueryOptionIncludeTransactionDetails
            Get
                Return Me.includeTransactionDetailsField
            End Get
            Set
                Me.includeTransactionDetailsField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCompletedItems.N)>  _
        Public Property IncludeCompletedItems() As QueryOptionIncludeCompletedItems
            Get
                Return Me.includeCompletedItemsField
            End Get
            Set
                Me.includeCompletedItemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNonStockedItems
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSerialNumbers
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeTransactionDetails
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCompletedItems
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As QueryFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As QueryFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNNumberField As QueryFilterGRNNumber
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As QueryFilterSupplier
        
        Public Sub New()
            MyBase.New
            If (Me.supplierField Is Nothing) Then
                Me.supplierField = New QueryFilterSupplier
            End If
            If (Me.gRNNumberField Is Nothing) Then
                Me.gRNNumberField = New QueryFilterGRNNumber
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New QueryFilterStockCode
            End If
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New QueryFilterWarehouse
            End If
        End Sub
        
        Public Property Warehouse() As QueryFilterWarehouse
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property StockCode() As QueryFilterStockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property GRNNumber() As QueryFilterGRNNumber
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = value
            End Set
        End Property
        
        Public Property Supplier() As QueryFilterSupplier
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterWarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As QueryFilterWarehouseFilterType
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
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterWarehouseFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterStockCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As QueryFilterStockCodeFilterType
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
    Public Enum QueryFilterStockCodeFilterType
        
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
    Partial Public Class QueryFilterGRNNumber
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterGRNNumberFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As QueryFilterGRNNumberFilterType
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
    Public Enum QueryFilterGRNNumberFilterType
        
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
    Partial Public Class QueryFilterSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterSupplierFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As QueryFilterSupplierFilterType
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
    Public Enum QueryFilterSupplierFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
    End Enum
End Namespace
