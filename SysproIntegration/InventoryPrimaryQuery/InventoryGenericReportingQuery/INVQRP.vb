Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryGenericReportingQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ABCClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ABCClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ABCClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ABCClassFilterType.A)>  _
        Public Property FilterType() As ABCClassFilterType
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
    Public Enum ABCClassFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
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
    Partial Public Class Buyer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Currency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CycleCount
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As Warehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementsField As Movements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As Buyer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As CycleCount
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As Salesperson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As Currency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As PriceCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryField As PriceCategory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As PriceMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aBCClassField As ABCClass
        
        Public Sub New()
            MyBase.New
            If (Me.aBCClassField Is Nothing) Then
                Me.aBCClassField = New ABCClass
            End If
            If (Me.priceMethodField Is Nothing) Then
                Me.priceMethodField = New PriceMethod
            End If
            If (Me.priceCategoryField Is Nothing) Then
                Me.priceCategoryField = New PriceCategory
            End If
            If (Me.priceCodeField Is Nothing) Then
                Me.priceCodeField = New PriceCode
            End If
            If (Me.currencyField Is Nothing) Then
                Me.currencyField = New Currency
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
            If (Me.salespersonField Is Nothing) Then
                Me.salespersonField = New Salesperson
            End If
            If (Me.supplierField Is Nothing) Then
                Me.supplierField = New Supplier
            End If
            If (Me.cycleCountField Is Nothing) Then
                Me.cycleCountField = New CycleCount
            End If
            If (Me.buyerField Is Nothing) Then
                Me.buyerField = New Buyer
            End If
            If (Me.movementsField Is Nothing) Then
                Me.movementsField = New Movements
            End If
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New Warehouse
            End If
            If (Me.productClassField Is Nothing) Then
                Me.productClassField = New ProductClass
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
        End Sub
        
        '''<summary>
        '''All, Range, Single or List of stock codes to return. FilterType options - A(All), R(Range), (S)Single or (L)List. Maximum of 1000 characters can be entered.
        '''</summary>
        Public Property StockCode() As StockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range or Single product class selection for stock items to be returned. FilterType options - A(All), R(Range), (S)Single.
        '''</summary>
        Public Property ProductClass() As ProductClass
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range, Single or List of warehouse selection. FilterType options - A(All), R(Range), (S)Single or (L)List.
        '''</summary>
        Public Property Warehouse() As Warehouse
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''Movement filter FilterType can take the following values:  C = current month, Y = current year, N = number of months, S = single period.If you selected C, the query will return current month details only. The current period information will be retrieved from the control table, and you do not need to enter anything in the FilterValue. If you selected Y, the query will return details for the current financial year. The current financial year information will be retrieved from the control table, therefore you do not need to enter any value in the FilterValue. If number of months is selected (N), the FilterValue should contain the number of prior periods from which you want to view the your movements. That is, if you have 12 periods in a year, and your FilterValue is 5, the query will return details for the past 5 months. If you selected S, single period, the FilterValue should contain the period number of periods for which you want to view the movements. That is, if you have 12 periods in a year, and your FilterValue is 5, the query will return details for the fifth period only.
        '''</summary>
        Public Property Movements() As Movements
            Get
                Return Me.movementsField
            End Get
            Set
                Me.movementsField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range or Single buyer selection separated by commas. FilterType options - A(All), R(Range), (S)Single.
        '''</summary>
        Public Property Buyer() As Buyer
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        '''<summary>
        '''All, or Single cycle count selection for stock items to be returned. FilterType options - A(All), (S)Single.
        '''</summary>
        Public Property CycleCount() As CycleCount
            Get
                Return Me.cycleCountField
            End Get
            Set
                Me.cycleCountField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range or Single supplier selection for stock items to be returned. FilterType options - A(All), R(Range), (S)Single.
        '''</summary>
        Public Property Supplier() As Supplier
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range or Single salesperson selection for stock movement items to be returned. FilterType options - A(All), R(Range), (S)Single.
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
        '''All, Range or Single customer selection for stock movement items to be returned. FilterType options - A(All), R(Range), (S)Single.
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
        '''If a foreign price method is selected, all, range or single currency can be entered in the query filter Currency. The default is all currencies. FilterType options - A(All), (R)Range, (S)Single  
        '''</summary>
        Public Property Currency() As Currency
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        '''<summary>
        '''If a coded price method is selected, in PriceMethod Filter, All(A), (R)Range or (S)Single price code can be selected in the query filter PriceCode. The default is all(A) price codes.
        '''</summary>
        Public Property PriceCode() As PriceCode
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''All, Range, Single price category for a stock codes to return. FilterType options - A(All), R(Range), (S)Single.
        '''
        '''</summary>
        Public Property PriceCategory() As PriceCategory
            Get
                Return Me.priceCategoryField
            End Get
            Set
                Me.priceCategoryField = value
            End Set
        End Property
        
        '''<summary>
        '''The business object can return pricing information for more than one pricing method. If IncludePricingInformation option is not 'Y'(Yes), the this option will be ignored.
        '''A single or list of price methods can be returned. FilterType options - (S)Single, (L)List.  
        '''
        ''' A list of pricing methods can be entered in the query FilterValue: 
        ''' C -  coded, 
        ''' Q -  quantity, 
        ''' F -  foreign.
        '''
        '''If a coded price method is selected, a list (or single) of price code(s) can be selected in the query filter PriceCode. The default is all price codes.
        '''
        '''If a foreign price method is selected, all, range or single currency can be entered in the query filter Currency. The default is all currencies.   
        '''
        '''</summary>
        Public Property PriceMethod() As PriceMethod
            Get
                Return Me.priceMethodField
            End Get
            Set
                Me.priceMethodField = value
            End Set
        End Property
        
        '''<summary>
        '''List or Single ABCClasses separated by commas. A - Abc class A, B - Abc class B, C - Abc class C, D - Abc class D. N - for items with no Abc class. 
        '''FilterType options - A(All), L(List), S(Single). FilterValue option - N,A,B,C,D.
        ''' 
        '''</summary>
        Public Property ABCClass() As ABCClass
            Get
                Return Me.aBCClassField
            End Get
            Set
                Me.aBCClassField = value
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
    Partial Public Class StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
            Me.filterValueField = " "
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
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(" ")>  _
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Warehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Movements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "C"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("C")>  _
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Salesperson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PriceCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PriceCategory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PriceMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeAgeValuationInformation
        
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
    Public Enum IncludeAlternateStock
        
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
    Public Enum IncludeAlternateSupplier
        
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
    Public Enum IncludePriceInformation
        
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
    Public Enum IncludeWhMovementAdjustments
        
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
    Public Enum IncludeWhMovementBinTransfers
        
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
    Public Enum IncludeWhMovementCostChanges
        
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
    Public Enum IncludeWhMovementCostMods
        
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
    Public Enum IncludeWhMovementCreditNotes
        
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
    Public Enum IncludeWhMovementDebitNotes
        
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
    Public Enum IncludeWhMovementDispatchNotes
        
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
    Public Enum IncludeWhMovementInvoices
        
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
    Public Enum IncludeWhMovementIssues
        
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
    Public Enum IncludeWhMovementPhysical
        
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
    Public Enum IncludeWhMovementReceipts
        
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
    Public Enum IncludeWhMovementTransfers
        
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
    Public Enum IncludeWhMovements
        
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
    Public Enum MPSItems
        
        '''<remarks/>
        I
        
        '''<remarks/>
        X
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MakeToOrderItems
        
        '''<remarks/>
        I
        
        '''<remarks/>
        X
        
        '''<remarks/>
        O
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
        Private sequenceField As Sequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxNumberStkItemsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAgeValuationInformationField As IncludeAgeValuationInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAgeValuationInformationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePriceInformationField As IncludePriceInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePriceInformationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rulesField As Rules
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inactiveDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supersessionDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhNoActivityAdjustmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementsField As IncludeWhMovements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whMovementDateSequenceField As WhMovementDateSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whMovementDateSequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxNumberWhMovementsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementIssuesField As IncludeWhMovementIssues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementIssuesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementTransfersField As IncludeWhMovementTransfers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementTransfersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementReceiptsField As IncludeWhMovementReceipts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementReceiptsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementPhysicalField As IncludeWhMovementPhysical
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementPhysicalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementAdjustmentsField As IncludeWhMovementAdjustments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementAdjustmentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCostChangesField As IncludeWhMovementCostChanges
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCostChangesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCostModsField As IncludeWhMovementCostMods
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCostModsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementBinTransfersField As IncludeWhMovementBinTransfers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementBinTransfersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementInvoicesField As IncludeWhMovementInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCreditNotesField As IncludeWhMovementCreditNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementCreditNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementDebitNotesField As IncludeWhMovementDebitNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementDebitNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementDispatchNotesField As IncludeWhMovementDispatchNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhMovementDispatchNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statisticalItemsField As StatisticalItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statisticalItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPSItemsField As MPSItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPSItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderItemsField As MakeToOrderItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateStockField As IncludeAlternateStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateSupplierField As IncludeAlternateSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateSupplierFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWhSalesHistoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.sequenceField = Sequence.S
            Me.maxNumberStkItemsField = "100"
            Me.includeAgeValuationInformationField = IncludeAgeValuationInformation.N
            Me.includePriceInformationField = IncludePriceInformation.N
            Me.inactiveDaysField = "60"
            Me.supersessionDaysField = "0"
            Me.includeWhNoActivityAdjustmentField = "Y"
            Me.includeWhMovementsField = IncludeWhMovements.N
            Me.whMovementDateSequenceField = WhMovementDateSequence.A
            Me.maxNumberWhMovementsField = "100"
            Me.includeWhMovementIssuesField = IncludeWhMovementIssues.N
            Me.includeWhMovementTransfersField = IncludeWhMovementTransfers.N
            Me.includeWhMovementReceiptsField = IncludeWhMovementReceipts.N
            Me.includeWhMovementPhysicalField = IncludeWhMovementPhysical.N
            Me.includeWhMovementAdjustmentsField = IncludeWhMovementAdjustments.N
            Me.includeWhMovementCostChangesField = IncludeWhMovementCostChanges.N
            Me.includeWhMovementCostModsField = IncludeWhMovementCostMods.N
            Me.includeWhMovementBinTransfersField = IncludeWhMovementBinTransfers.N
            Me.includeWhMovementInvoicesField = IncludeWhMovementInvoices.N
            Me.includeWhMovementCreditNotesField = IncludeWhMovementCreditNotes.N
            Me.includeWhMovementDebitNotesField = IncludeWhMovementDebitNotes.N
            Me.includeWhMovementDispatchNotesField = IncludeWhMovementDispatchNotes.N
            Me.mPSItemsField = MPSItems.I
            Me.makeToOrderItemsField = MakeToOrderItems.I
            Me.includeAlternateStockField = IncludeAlternateStock.N
            Me.includeAlternateSupplierField = IncludeAlternateSupplier.N
            Me.includeWhSalesHistoryField = "N"
            If (Me.rulesField Is Nothing) Then
                Me.rulesField = New Rules
            End If
        End Sub
        
        '''<summary>
        '''The query details can be returned in stock code, stock code description, warehouse, supplier or product class sequence. 
        '''The input options: S - Stock code, D - Stock code description,  W - warehouse,  V - supplier, and P - product class, with a default of S, (stock code).
        '''</summary>
        Public Property Sequence() As Sequence
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
                Me.SequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SequenceSpecified() As Boolean
            Get
                Return Me.sequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this element to select the number of stock items to return in the query, and will default to 100. 
        '''</summary>
        Public Property MaxNumberStkItems() As String
            Get
                Return Me.maxNumberStkItemsField
            End Get
            Set
                Me.maxNumberStkItemsField = value
            End Set
        End Property
        
        '''<summary>
        '''You can only return warehouse age valuation information if you indicated that an aged inventory valuation is required (Inventory Setup). Otherwise  Aged valuation option is ignored.This element can be "Y" or "N". If  "Y", then all the aged quantities and the aged year for each warehouse will be returned.  
        '''</summary>
        Public Property IncludeAgeValuationInformation() As IncludeAgeValuationInformation
            Get
                Return Me.includeAgeValuationInformationField
            End Get
            Set
                Me.includeAgeValuationInformationField = value
                Me.IncludeAgeValuationInformationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeAgeValuationInformationSpecified() As Boolean
            Get
                Return Me.includeAgeValuationInformationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Element options, Y or N. If this element is Y, then the stock code price information based on the price method selected in the query filters will be returned. The default is N.
        '''
        '''
        '''</summary>
        Public Property IncludePriceInformation() As IncludePriceInformation
            Get
                Return Me.includePriceInformationField
            End Get
            Set
                Me.includePriceInformationField = value
                Me.IncludePriceInformationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludePriceInformationSpecified() As Boolean
            Get
                Return Me.includePriceInformationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''List of rules 
        '''</summary>
        Public Property Rules() As Rules
            Get
                Return Me.rulesField
            End Get
            Set
                Me.rulesField = value
            End Set
        End Property
        
        '''<summary>
        '''If you selected to include inactive stock codes, a cut-off number of days is entered in InactiveDays. InactiveDays will default to 60 days.
        '''</summary>
        Public Property InactiveDays() As String
            Get
                Return Me.inactiveDaysField
            End Get
            Set
                Me.inactiveDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''If you selected to return superseded stock items, a number of supersession days can be entered in SupersessionDays, if not entered will default to zero (0) (that is supersession date is today).
        '''</summary>
        Public Property SupersessionDays() As String
            Get
                Return Me.supersessionDaysField
            End Get
            Set
                Me.supersessionDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''You have an option to include month-to-date stock adjustments for a warehouse where no activity have taken place. If Y the month to date quantity adjustment records will be included in the output. Y(Yes), N(No). Default is Y(Yes).
        '''</summary>
        Public Property IncludeWhNoActivityAdjustment() As String
            Get
                Return Me.includeWhNoActivityAdjustmentField
            End Get
            Set
                Me.includeWhNoActivityAdjustmentField = value
            End Set
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock code warehouse movement records. If not movement type has been selected, then this option will be ignored. (Y - Yes or N - No).
        '''</summary>
        Public Property IncludeWhMovements() As IncludeWhMovements
            Get
                Return Me.includeWhMovementsField
            End Get
            Set
                Me.includeWhMovementsField = value
                Me.IncludeWhMovementsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementsSpecified() As Boolean
            Get
                Return Me.includeWhMovementsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Inventory warehouse movements can be returned in ascending or descending order. You enter 'A' for ascending and 'D' for descending and the default is 'A'.  
        '''</summary>
        Public Property WhMovementDateSequence() As WhMovementDateSequence
            Get
                Return Me.whMovementDateSequenceField
            End Get
            Set
                Me.whMovementDateSequenceField = value
                Me.WhMovementDateSequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property WhMovementDateSequenceSpecified() As Boolean
            Get
                Return Me.whMovementDateSequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this element to select the maximum number of stock code movements  in a warehouse, and will default to 100. 
        '''</summary>
        Public Property MaxNumberWhMovements() As String
            Get
                Return Me.maxNumberWhMovementsField
            End Get
            Set
                Me.maxNumberWhMovementsField = value
            End Set
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock issues type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementIssues() As IncludeWhMovementIssues
            Get
                Return Me.includeWhMovementIssuesField
            End Get
            Set
                Me.includeWhMovementIssuesField = value
                Me.IncludeWhMovementIssuesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementIssuesSpecified() As Boolean
            Get
                Return Me.includeWhMovementIssuesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock transfer type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementTransfers() As IncludeWhMovementTransfers
            Get
                Return Me.includeWhMovementTransfersField
            End Get
            Set
                Me.includeWhMovementTransfersField = value
                Me.IncludeWhMovementTransfersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementTransfersSpecified() As Boolean
            Get
                Return Me.includeWhMovementTransfersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock sales receipts type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementReceipts() As IncludeWhMovementReceipts
            Get
                Return Me.includeWhMovementReceiptsField
            End Get
            Set
                Me.includeWhMovementReceiptsField = value
                Me.IncludeWhMovementReceiptsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementReceiptsSpecified() As Boolean
            Get
                Return Me.includeWhMovementReceiptsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock physical adjustment type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementPhysical() As IncludeWhMovementPhysical
            Get
                Return Me.includeWhMovementPhysicalField
            End Get
            Set
                Me.includeWhMovementPhysicalField = value
                Me.IncludeWhMovementPhysicalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementPhysicalSpecified() As Boolean
            Get
                Return Me.includeWhMovementPhysicalFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock adjustment type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementAdjustments() As IncludeWhMovementAdjustments
            Get
                Return Me.includeWhMovementAdjustmentsField
            End Get
            Set
                Me.includeWhMovementAdjustmentsField = value
                Me.IncludeWhMovementAdjustmentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementAdjustmentsSpecified() As Boolean
            Get
                Return Me.includeWhMovementAdjustmentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock item cost changes type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementCostChanges() As IncludeWhMovementCostChanges
            Get
                Return Me.includeWhMovementCostChangesField
            End Get
            Set
                Me.includeWhMovementCostChangesField = value
                Me.IncludeWhMovementCostChangesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementCostChangesSpecified() As Boolean
            Get
                Return Me.includeWhMovementCostChangesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock costs modifications type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementCostMods() As IncludeWhMovementCostMods
            Get
                Return Me.includeWhMovementCostModsField
            End Get
            Set
                Me.includeWhMovementCostModsField = value
                Me.IncludeWhMovementCostModsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementCostModsSpecified() As Boolean
            Get
                Return Me.includeWhMovementCostModsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include bin transfer type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementBinTransfers() As IncludeWhMovementBinTransfers
            Get
                Return Me.includeWhMovementBinTransfersField
            End Get
            Set
                Me.includeWhMovementBinTransfersField = value
                Me.IncludeWhMovementBinTransfersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementBinTransfersSpecified() As Boolean
            Get
                Return Me.includeWhMovementBinTransfersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock invoice type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementInvoices() As IncludeWhMovementInvoices
            Get
                Return Me.includeWhMovementInvoicesField
            End Get
            Set
                Me.includeWhMovementInvoicesField = value
                Me.IncludeWhMovementInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementInvoicesSpecified() As Boolean
            Get
                Return Me.includeWhMovementInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock credit note type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementCreditNotes() As IncludeWhMovementCreditNotes
            Get
                Return Me.includeWhMovementCreditNotesField
            End Get
            Set
                Me.includeWhMovementCreditNotesField = value
                Me.IncludeWhMovementCreditNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementCreditNotesSpecified() As Boolean
            Get
                Return Me.includeWhMovementCreditNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock debit note type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementDebitNotes() As IncludeWhMovementDebitNotes
            Get
                Return Me.includeWhMovementDebitNotesField
            End Get
            Set
                Me.includeWhMovementDebitNotesField = value
                Me.IncludeWhMovementDebitNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementDebitNotesSpecified() As Boolean
            Get
                Return Me.includeWhMovementDebitNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include stock dispatch note type of inventory movements for the selected period in a warehouse. (Y - Yes or N - No).
        '''
        '''
        '''</summary>
        Public Property IncludeWhMovementDispatchNotes() As IncludeWhMovementDispatchNotes
            Get
                Return Me.includeWhMovementDispatchNotesField
            End Get
            Set
                Me.includeWhMovementDispatchNotesField = value
                Me.IncludeWhMovementDispatchNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWhMovementDispatchNotesSpecified() As Boolean
            Get
                Return Me.includeWhMovementDispatchNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You can include, exclude or only return Statistical stock items,  (I - Include,  X - Exclude and O - Only).
        '''</summary>
        Public Property StatisticalItems() As StatisticalItems
            Get
                Return Me.statisticalItemsField
            End Get
            Set
                Me.statisticalItemsField = value
                Me.StatisticalItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StatisticalItemsSpecified() As Boolean
            Get
                Return Me.statisticalItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You can include, exclude or only return MPS items,  (I - Include, X - Exclude and O - Only) .
        '''</summary>
        Public Property MPSItems() As MPSItems
            Get
                Return Me.mPSItemsField
            End Get
            Set
                Me.mPSItemsField = value
                Me.MPSItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MPSItemsSpecified() As Boolean
            Get
                Return Me.mPSItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You can include, exclude or only return Make to order items (I - Include, X - Exclude and O - Only).
        '''</summary>
        Public Property MakeToOrderItems() As MakeToOrderItems
            Get
                Return Me.makeToOrderItemsField
            End Get
            Set
                Me.makeToOrderItemsField = value
                Me.MakeToOrderItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MakeToOrderItemsSpecified() As Boolean
            Get
                Return Me.makeToOrderItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''All alternate stock codes for each stock code selected will be returned when this element is Y. The default for this element is N . Options Y - Yes, and N - No
        '''
        '''</summary>
        Public Property IncludeAlternateStock() As IncludeAlternateStock
            Get
                Return Me.includeAlternateStockField
            End Get
            Set
                Me.includeAlternateStockField = value
                Me.IncludeAlternateStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeAlternateStockSpecified() As Boolean
            Get
                Return Me.includeAlternateStockFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''All alternate suppliers for each stock code selected will be returned when this element is Y. The default for this element is N . Options Y - Yes, and N - No
        '''
        '''</summary>
        Public Property IncludeAlternateSupplier() As IncludeAlternateSupplier
            Get
                Return Me.includeAlternateSupplierField
            End Get
            Set
                Me.includeAlternateSupplierField = value
                Me.IncludeAlternateSupplierFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeAlternateSupplierSpecified() As Boolean
            Get
                Return Me.includeAlternateSupplierFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If element is 'Y',  you select to include warehouse sales history for the selected period in a warehouse. (Y - Yes or N - No).
        '''</summary>
        Public Property IncludeWhSalesHistory() As String
            Get
                Return Me.includeWhSalesHistoryField
            End Get
            Set
                Me.includeWhSalesHistoryField = value
            End Set
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied.
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
    Public Enum Sequence
        
        '''<remarks/>
        S
        
        '''<remarks/>
        D
        
        '''<remarks/>
        W
        
        '''<remarks/>
        V
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Rules
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ruleField As List(Of String)
        
        '''<summary>
        '''You can select each exception type to be included in the XML-out. All the exception options will default to N (No). That is 'Rules' will be empty. These are values you use to select exception types that can be returned:
        ''' Select warehouses with available quantity less than zero - NegQty.
        ''' Select warehouses with available quantity zero - ZeroQty 
        ''' Select warehouses with available quantity greater than zero - PosQty
        ''' Select warehouses with on purchase order - OnOrder
        ''' Select warehouses with quantity on back order - BackOrder
        ''' Select warehouses with goods in transit - GIT
        ''' Select warehouses with available less than minimum quantity - UnderMin
        ''' Select warehouses with available less than safety - UnderSafety
        ''' Select warehouses with available greater than maximum quantity - OverMax
        ''' Select warehosue with zero quantity on hand - OnHandZero
        ''' Select inactive stock items - Inactive
        ''' Select clearing stock items - Clr
        ''' Select superceded items - Super
        ''' Select items on hold - OnHold
        '''
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Rule")>  _
        Public Property RuleCollection() As List(Of String)
            Get
                Return Me.ruleField
            End Get
            Set
                Me.ruleField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum WhMovementDateSequence
        
        '''<remarks/>
        A
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StatisticalItems
        
        '''<remarks/>
        I
        
        '''<remarks/>
        X
        
        '''<remarks/>
        O
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
        
        '''<summary>
        '''List of options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''List of filters
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
                Return "INVQRP"
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
