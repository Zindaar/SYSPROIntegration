Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.ListOfSalesOrders.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class AlternateKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As AlternateKeyFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As AlternateKeyFilterType
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
    Public Enum AlternateKeyFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Branch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As BranchFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As BranchFilterType
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
    Public Enum BranchFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As CustomerFilterType
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
    Public Enum CustomerFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CustomerPo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerPoFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As CustomerPoFilterType
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
    Public Enum CustomerPoFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As Salesperson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As Branch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As OrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoField As CustomerPo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As SalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As OrderDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As OrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKeyField As AlternateKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaField As GeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requestedShipDateField As RequestedShipDate
        
        Public Sub New()
            MyBase.New
            If (Me.requestedShipDateField Is Nothing) Then
                Me.requestedShipDateField = New RequestedShipDate
            End If
            If (Me.geographicAreaField Is Nothing) Then
                Me.geographicAreaField = New GeographicArea
            End If
            If (Me.alternateKeyField Is Nothing) Then
                Me.alternateKeyField = New AlternateKey
            End If
            If (Me.orderStatusField Is Nothing) Then
                Me.orderStatusField = New OrderStatus
            End If
            If (Me.orderDateField Is Nothing) Then
                Me.orderDateField = New OrderDate
            End If
            If (Me.salesOrderField Is Nothing) Then
                Me.salesOrderField = New SalesOrder
            End If
            If (Me.customerPoField Is Nothing) Then
                Me.customerPoField = New CustomerPo
            End If
            If (Me.orderTypeField Is Nothing) Then
                Me.orderTypeField = New OrderType
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
            If (Me.branchField Is Nothing) Then
                Me.branchField = New Branch
            End If
            If (Me.salespersonField Is Nothing) Then
                Me.salespersonField = New Salesperson
            End If
        End Sub
        
        '''<summary>
        '''Salesperson to be selected (FilterType of A - All, S - Single salesperson, FilterValue contains the selected salesperson if FilterType is S)
        '''</summary>
        Public Property Salesperson() As Salesperson
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        '''<summary>
        '''Branch to be selected (FilterType of A - All, S - Single branch, FilterValue contains the selected branch if FilterType is S).
        '''</summary>
        Public Property Branch() As Branch
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer to be selected (FilterType of A - All, S - Single customer, FilterValue contains the selected customer if FilterType is S).
        '''</summary>
        Public Property Customer() As Customer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''Order type to be selected (FilterType of A - All, R - Range, L - List or S - Single order type, FilterValue contains the selected order type if FilterType is S or a range or list of order types separated by commas).
        '''</summary>
        Public Property OrderType() As OrderType
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer purchase order number to be selected (FilterType of A - All, S - Single p/o number, FilterValue contains the selected p/o number if FilterType is S).
        '''</summary>
        Public Property CustomerPo() As CustomerPo
            Get
                Return Me.customerPoField
            End Get
            Set
                Me.customerPoField = value
            End Set
        End Property
        
        '''<summary>
        '''Sales order numbers to be selected (FilterType of A - All, R - Range, FilterValue is range of sales order numbers separated by a commas if FilterType is R).
        '''</summary>
        Public Property SalesOrder() As SalesOrder
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''Sales order dates selected (FilterType of A - All, R - Range, FilterValue is range of order dates separated by a comma if FilterType is R).
        '''</summary>
        Public Property OrderDate() As OrderDate
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Order status to be selected (FilterType of A - All, R - Range, L - List or S - Single order status, FilterValue contains the selected order status if FilterType is S or a range or list of order status separated by commas)
        '''</summary>
        Public Property OrderStatus() As OrderStatus
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
            End Set
        End Property
        
        '''<summary>
        '''Alternate key to be selected (FilterType of A - All, R - Range, L - List or S - Single alternate key, FilterValue contains the selected alternate key if FilterType is S or a range or list of alternate keys separated by commas)
        '''</summary>
        Public Property AlternateKey() As AlternateKey
            Get
                Return Me.alternateKeyField
            End Get
            Set
                Me.alternateKeyField = value
            End Set
        End Property
        
        '''<summary>
        '''Geographic area to be selected (FilterType of A - All, S - Single geographic area, FilterValue contains the selected geographic area if FilterType is S)
        '''</summary>
        Public Property GeographicArea() As GeographicArea
            Get
                Return Me.geographicAreaField
            End Get
            Set
                Me.geographicAreaField = value
            End Set
        End Property
        
        '''<summary>
        '''Requested ship dates selected (FilterType of A - All, R - Range, FilterValue is range of requested ship dates separated by a comma if FilterType is R).
        '''</summary>
        Public Property RequestedShipDate() As RequestedShipDate
            Get
                Return Me.requestedShipDateField
            End Get
            Set
                Me.requestedShipDateField = value
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
    Partial Public Class Salesperson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SalespersonFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As SalespersonFilterType
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
    Public Enum SalespersonFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As OrderTypeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As OrderTypeFilterType
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
    Public Enum OrderTypeFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SalesOrderFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = SalesOrderFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(SalesOrderFilterType.A)>  _
        Public Property FilterType() As SalesOrderFilterType
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
    Public Enum SalesOrderFilterType
        
        '''<remarks/>
        R
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As OrderDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As OrderDateFilterType
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
    Public Enum OrderDateFilterType
        
        '''<remarks/>
        R
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As OrderStatusFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As OrderStatusFilterType
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
    Public Enum OrderStatusFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As GeographicAreaFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As GeographicAreaFilterType
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
    Public Enum GeographicAreaFilterType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class RequestedShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As RequestedShipDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As RequestedShipDateFilterType
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
    Public Enum RequestedShipDateFilterType
        
        '''<remarks/>
        R
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCancelledOrders
        
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
    Public Enum IncludeCompletedOrders
        
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
    Public Enum IncludeForwardOrders
        
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedOrdersField As IncludeCompletedOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCancelledOrdersField As IncludeCancelledOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCancelledOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeForwardOrdersField As IncludeForwardOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeForwardOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startAtOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingQtyField As OutstandingQty
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingQtyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnPreviousOrderField As ReturnPreviousOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnPreviousOrderFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeCompletedOrdersField = IncludeCompletedOrders.N
            Me.includeCancelledOrdersField = IncludeCancelledOrders.N
            Me.includeForwardOrdersField = IncludeForwardOrders.N
            Me.outstandingQtyField = OutstandingQty.I
            Me.returnPreviousOrderField = ReturnPreviousOrder.N
        End Sub
        
        '''<summary>
        '''Do you wish to include completed orders (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeCompletedOrders() As IncludeCompletedOrders
            Get
                Return Me.includeCompletedOrdersField
            End Get
            Set
                Me.includeCompletedOrdersField = value
                Me.IncludeCompletedOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCompletedOrdersSpecified() As Boolean
            Get
                Return Me.includeCompletedOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include cancelled orders (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeCancelledOrders() As IncludeCancelledOrders
            Get
                Return Me.includeCancelledOrdersField
            End Get
            Set
                Me.includeCancelledOrdersField = value
                Me.IncludeCancelledOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCancelledOrdersSpecified() As Boolean
            Get
                Return Me.includeCancelledOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include forward orders (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeForwardOrders() As IncludeForwardOrders
            Get
                Return Me.includeForwardOrdersField
            End Get
            Set
                Me.includeForwardOrdersField = value
                Me.IncludeForwardOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeForwardOrdersSpecified() As Boolean
            Get
                Return Me.includeForwardOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the primary key to the sales order master table. This is optional and will default to the beginning of the file. If a range of orders is also selected, then this starting point will only be used if it is greater than or equal to the start of the range.
        '''</summary>
        Public Property StartAtOrder() As String
            Get
                Return Me.startAtOrderField
            End Get
            Set
                Me.startAtOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''The number of orders to return. If this is specified then this number of orders will be returned. If blank then 20 will be returned. If the element is not used, then all orders for the selection criteria will be returned. If entered, the element must contain a numeric value.
        '''</summary>
        Public Property ReturnOrders() As String
            Get
                Return Me.returnOrdersField
            End Get
            Set
                Me.returnOrdersField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the order detail lines are to be checked based on quantity. I - ignore, do not check detial lines, otherwise the order is checked to see if it contains one or more lines with an outstanding quantity of B - Back order , O - outstanding (ship plus back order), S - Ship.
        '''</summary>
        Public Property OutstandingQty() As OutstandingQty
            Get
                Return Me.outstandingQtyField
            End Get
            Set
                Me.outstandingQtyField = value
                Me.OutstandingQtyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OutstandingQtySpecified() As Boolean
            Get
                Return Me.outstandingQtyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is set to 'Y' if the previous and next information is to be obtained.
        '''</summary>
        Public Property ReturnPreviousOrder() As ReturnPreviousOrder
            Get
                Return Me.returnPreviousOrderField
            End Get
            Set
                Me.returnPreviousOrderField = value
                Me.ReturnPreviousOrderFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReturnPreviousOrderSpecified() As Boolean
            Get
                Return Me.returnPreviousOrderFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used
        '''</summary>
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OutstandingQty
        
        '''<remarks/>
        I
        
        '''<remarks/>
        B
        
        '''<remarks/>
        O
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReturnPreviousOrder
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New Filter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
        End Sub
        
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains one or more filters to restrict the amount of data returned
        '''</summary>
        Public Property Filter() As Filter
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
                Return "SORQSO"
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
End Namespace
