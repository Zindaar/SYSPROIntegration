Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryValuationQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AsOfPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As CycleCount
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As Warehouse
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New Warehouse
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
            If (Me.supplierField Is Nothing) Then
                Me.supplierField = New Supplier
            End If
            If (Me.productClassField Is Nothing) Then
                Me.productClassField = New ProductClass
            End If
            If (Me.cycleCountField Is Nothing) Then
                Me.cycleCountField = New CycleCount
            End If
        End Sub
        
        '''<summary>
        '''This field enables you to select stock items for valuation according to the number of times a stock item has been counted during the year. 
        '''The field will have a value(2 character) if a single Cyclecount is selected.  
        '''
        '''
        '''
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
        '''This specifies the selection of product class ( A - All, S - Single, R - Range).  If not provided default is A.  If range(R) is selected then start and end product classes are separated by a comma. If single(S) is selected a product class is given as FilterValue.
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
        '''This specifies the selection of suppliers ( A - All, S - Single, R - Range).  If not provided default is A.  If range(R) is selected then start and end supplier codes are separated by a comma. If single(S) is selected a supplier code is given as FilterValue.
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
        '''This specifies the selection of stock codes ( A - All, S - Single, R - Range).  If not provided default is A.  If range(R) is selected then start and end stock codes are separated by a comma. If single(S) is selected a stock code is given as FilterValue.
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
        '''This specifies the selection of warehouses ( A - All, S - Single, R - Range).  If not provided default is A.  If range(R) is selected then start and end warehouses are separated by a comma. If single(S) is selected a warehouse is given as FilterValue.
        '''</summary>
        Public Property Warehouse() As Warehouse
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ProductClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ProductClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ProductClassFilterType.A)>  _
        Public Property FilterType() As ProductClassFilterType
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
    Public Enum ProductClassFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SupplierFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = SupplierFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(SupplierFilterType.A)>  _
        Public Property FilterType() As SupplierFilterType
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
    Public Enum SupplierFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As StockCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = StockCodeFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(StockCodeFilterType.A)>  _
        Public Property FilterType() As StockCodeFilterType
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
    Public Enum StockCodeFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Warehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As WarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = WarehouseFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(WarehouseFilterType.A)>  _
        Public Property FilterType() As WarehouseFilterType
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
    Public Enum WarehouseFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeProductClassDesc
        
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
    Public Enum IncludeWarehouseMass
        
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
    Public Enum IncludeZeroValueWarehouses
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        C
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
        Private asOfPeriodField As AsOfPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private asOfPeriodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As Sequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroValueWarehousesField As IncludeZeroValueWarehouses
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroValueWarehousesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeProductClassDescField As IncludeProductClassDesc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeProductClassDescFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valuationCostBasedOnField As ValuationCostBasedOn
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valuationCostBasedOnFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccItemsOnlyField As OptionEccItemsOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccItemsOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroEccRevRelField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multipleBinsPrintTotalsOnlyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.asOfPeriodField = AsOfPeriod.C
            Me.sequenceField = Sequence.S
            Me.includeZeroValueWarehousesField = IncludeZeroValueWarehouses.N
            Me.includeProductClassDescField = IncludeProductClassDesc.Y
            Me.valuationCostBasedOnField = ValuationCostBasedOn.C
            Me.multipleBinsPrintTotalsOnlyField = "N"
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''Valuation as of period. Select the period in which to show the details. Default is C for Current period.  C - Current period, P - Previous month 1, B - Previous month 2
        '''</summary>
        Public Property AsOfPeriod() As AsOfPeriod
            Get
                Return Me.asOfPeriodField
            End Get
            Set
                Me.asOfPeriodField = value
                Me.AsOfPeriodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AsOfPeriodSpecified() As Boolean
            Get
                Return Me.asOfPeriodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies which sequence in which the data is returned ( S - Stock code, D - Stock code description,  U - Supplier, P - Product class).  If not provided the default is S.
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
        '''Default N - No, This element gives an option to include warehouses for  selected stock items that have a zero value. Values Y - Yes, N - No, C - when the cost is zero, but the quantity in not, Q - when the quantity is zero but the cost is not zero. Note that the warehouse value is the quantity multiplied by the cost. 
        '''</summary>
        Public Property IncludeZeroValueWarehouses() As IncludeZeroValueWarehouses
            Get
                Return Me.includeZeroValueWarehousesField
            End Get
            Set
                Me.includeZeroValueWarehousesField = value
                Me.IncludeZeroValueWarehousesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeZeroValueWarehousesSpecified() As Boolean
            Get
                Return Me.includeZeroValueWarehousesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This option is effective only if you select to show the query in product class sequence. Your entry at the Branch field is used to extract the relevant product class description. If no Branch is selected, the product class description will not be returned. The default is Yes.  
        '''</summary>
        Public Property IncludeProductClassDesc() As IncludeProductClassDesc
            Get
                Return Me.includeProductClassDescField
            End Get
            Set
                Me.includeProductClassDescField = value
                Me.IncludeProductClassDescFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeProductClassDescSpecified() As Boolean
            Get
                Return Me.includeProductClassDescFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Default C - Current costing method. You can select to return the values based on Fifo(F), if you have FIFO on. If you do not FIFO set on, and you selected to F(FIFO) the program will default to the current costing method. You can select, F - Fifo, L - last costing, and C - current cost. Select FIFO to show inventory value according to the FIFO costs held in each FIFO bin location. W - Warehouse costs, this will return the values based on the warehouse costing method, this option is only available if you have costing per warehouse, else the default will be applied. 
        '''</summary>
        Public Property ValuationCostBasedOn() As ValuationCostBasedOn
            Get
                Return Me.valuationCostBasedOnField
            End Get
            Set
                Me.valuationCostBasedOnField = value
                Me.ValuationCostBasedOnFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValuationCostBasedOnSpecified() As Boolean
            Get
                Return Me.valuationCostBasedOnFieldSpecified
            End Get
        End Property
        
        Public Property EccItemsOnly() As OptionEccItemsOnly
            Get
                Return Me.eccItemsOnlyField
            End Get
            Set
                Me.eccItemsOnlyField = value
                Me.EccItemsOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EccItemsOnlySpecified() As Boolean
            Get
                Return Me.eccItemsOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''d
        '''</summary>
        Public Property IncludeZeroEccRevRel() As String
            Get
                Return Me.includeZeroEccRevRelField
            End Get
            Set
                Me.includeZeroEccRevRelField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag enables you to print warehouse totals only when Muliple Bins are switched on. Default is N. Options are Y or N.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute("N")>  _
        Public Property MultipleBinsPrintTotalsOnly() As String
            Get
                Return Me.multipleBinsPrintTotalsOnlyField
            End Get
            Set
                Me.multipleBinsPrintTotalsOnlyField = value
            End Set
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied
        '''</summary>
        Public Property XslStylesheet() As XslStylesheet
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
        U
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValuationCostBasedOn
        
        '''<remarks/>
        C
        
        '''<remarks/>
        F
        
        '''<remarks/>
        L
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionEccItemsOnly
        
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
    Partial Public Class XslStylesheet
    End Class
    
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
        '''The list of options
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
        '''List of filters.
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
                Return "INVQVL"
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
