Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace BillOfMaterialPrimaryQuery.AdvancedTrialKittingQuery.QueryData
    
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
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CustomerFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CustomerFilterType.A)>  _
        Public Property FilterType() As CustomerFilterType
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
    Public Enum CustomerFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GrossQuantity
        
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
    Partial Public Class Job
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As JobFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = JobFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(JobFilterType.A)>  _
        Public Property FilterType() As JobFilterType
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
    Public Enum JobFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
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
    Partial Public Class NonStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As NonStockCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = NonStockCodeFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(NonStockCodeFilterType.A)>  _
        Public Property FilterType() As NonStockCodeFilterType
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
    Public Enum NonStockCodeFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
            If (Me.filterField Is Nothing) Then
                Me.filterField = New QueryFilter
            End If
        End Sub
        
        Public Property Filter() As QueryFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
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
                Return "BOMQTK"
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
    Partial Public Class QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private standardPartField As QueryFilterStandardPart
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobSelectionField As QueryFilterJobSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderSelectionField As QueryFilterSalesOrderSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteSelectionField As QueryFilterQuoteSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentWhRouteField As QueryFilterUseParentWhRoute
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As QueryFilterWarehouse
        
        Public Sub New()
            MyBase.New
            Me.useParentWhRouteField = QueryFilterUseParentWhRoute.N
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New QueryFilterWarehouse
            End If
            If (Me.quoteSelectionField Is Nothing) Then
                Me.quoteSelectionField = New QueryFilterQuoteSelection
            End If
            If (Me.salesOrderSelectionField Is Nothing) Then
                Me.salesOrderSelectionField = New QueryFilterSalesOrderSelection
            End If
            If (Me.jobSelectionField Is Nothing) Then
                Me.jobSelectionField = New QueryFilterJobSelection
            End If
            If (Me.standardPartField Is Nothing) Then
                Me.standardPartField = New QueryFilterStandardPart
            End If
        End Sub
        
        Public Property StandardPart() As QueryFilterStandardPart
            Get
                Return Me.standardPartField
            End Get
            Set
                Me.standardPartField = value
            End Set
        End Property
        
        Public Property JobSelection() As QueryFilterJobSelection
            Get
                Return Me.jobSelectionField
            End Get
            Set
                Me.jobSelectionField = value
            End Set
        End Property
        
        Public Property SalesOrderSelection() As QueryFilterSalesOrderSelection
            Get
                Return Me.salesOrderSelectionField
            End Get
            Set
                Me.salesOrderSelectionField = value
            End Set
        End Property
        
        Public Property QuoteSelection() As QueryFilterQuoteSelection
            Get
                Return Me.quoteSelectionField
            End Get
            Set
                Me.quoteSelectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterUseParentWhRoute.N)>  _
        Public Property UseParentWhRoute() As QueryFilterUseParentWhRoute
            Get
                Return Me.useParentWhRouteField
            End Get
            Set
                Me.useParentWhRouteField = value
            End Set
        End Property
        
        Public Property Warehouse() As QueryFilterWarehouse
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
    Partial Public Class QueryFilterStandardPart
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQuantityField As GrossQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQuantityFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useEBQField As UseEBQ
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useEBQFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentWhToUseField As QueryFilterStandardPartUseParentWhToUse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockListField As List(Of QueryFilterStandardPartStockList)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockCodeField As NonStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockRouteField As QueryFilterStandardPartNonStockRoute
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockGrossQuantityField As QueryFilterStandardPartNonStockGrossQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockListField As List(Of QueryFilterStandardPartNonStockList)
        
        Public Sub New()
            MyBase.New
            Me.routeField = "0"
            Me.quantityField = "1"
            Me.grossQuantityField = GrossQuantity.N
            Me.useEBQField = UseEBQ.N
            Me.useParentWhToUseField = QueryFilterStandardPartUseParentWhToUse.Y
            Me.nonStockRouteField = QueryFilterStandardPartNonStockRoute.Item0
            Me.nonStockGrossQuantityField = QueryFilterStandardPartNonStockGrossQuantity.N
            If (Me.nonStockListField Is Nothing) Then
                Me.nonStockListField = New List(Of QueryFilterStandardPartNonStockList)
            End If
            If (Me.nonStockCodeField Is Nothing) Then
                Me.nonStockCodeField = New NonStockCode
            End If
            If (Me.stockListField Is Nothing) Then
                Me.stockListField = New List(Of QueryFilterStandardPartStockList)
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
        End Sub
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("0")>  _
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of stocked standard parts for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A.  If R is selected then separated by a ','.  Example: B100,DFMB900. If L is selected then a list of stock codes must be provided using the group element StockList. This element will be ignored if the element IncludeStandardParts is 'N'.
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
        '''This indicates the quantity to make for the standard stock codes specified. This element will be ignored if the element UseEBQ is 'Y'. The format is up to 12 characters numeric with 7 integers and 3 decimals. If not provided the default is 1. This element will be ignored if the element IncludeStandardParts is 'N'.
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
        '''If progressive scrap is required (Bill of Material setup, General tab) then you may select if the Quantity to make for stocked standard parts represents the Gross or Net quantity. Possible values: N (Net quantity) or Y (Gross quantity). If not provided the default is N. This element will be ignored if the element IncludeStandardParts is 'N'.
        '''</summary>
        Public Property GrossQuantity() As GrossQuantity
            Get
                Return Me.grossQuantityField
            End Get
            Set
                Me.grossQuantityField = value
                Me.GrossQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GrossQuantitySpecified() As Boolean
            Get
                Return Me.grossQuantityFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You may select to use the Economic batch quantity for each stocked parent part (Inventory stock code setup). If the EBQ quantity for a stock code is zero, then the quantity to make will default to one. If you select to use the route defined against the parent warehouse control (when element UseParentWhRoute = 'Y') then the EBQ quantity will be taken as the re-order quantity against the stocked parent part warehouse, therefore you must select to either use the 'warehouse to use' against the stocked parent part (supply 'Y' in 'UseParentWhToUse' element) or supply a warehouse for all standard parts (in element 'ParentWarehouse). If progressive scrap is required (Bill of Material setup, General tab) then the EBQ quantity will be taken as the net quantity. Possible values: Y (use EBQ quantity) or N (use Quantity supplied). If not provided the default is N. This element will be ignored if the element IncludeStandardParts is 'N'.
        '''</summary>
        Public Property UseEBQ() As UseEBQ
            Get
                Return Me.useEBQField
            End Get
            Set
                Me.useEBQField = value
                Me.UseEBQFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseEBQSpecified() As Boolean
            Get
                Return Me.useEBQFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterStandardPartUseParentWhToUse.Y)>  _
        Public Property UseParentWhToUse() As QueryFilterStandardPartUseParentWhToUse
            Get
                Return Me.useParentWhToUseField
            End Get
            Set
                Me.useParentWhToUseField = value
            End Set
        End Property
        
        Public Property ParentWarehouse() As String
            Get
                Return Me.parentWarehouseField
            End Get
            Set
                Me.parentWarehouseField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("StockList")>  _
        Public Property StockListCollection() As List(Of QueryFilterStandardPartStockList)
            Get
                Return Me.stockListField
            End Get
            Set
                Me.stockListField = value
            End Set
        End Property
        
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of non-stocked standard parts for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A.  If R is selected then separated by a ','.  Example: B100A,DFMB900. If L is selected then a list of non-stock codes must be provided using the group element NonStockList. This element will be ignored if the element IncludeNonStockedStandardParts is 'N'.
        '''</summary>
        Public Property NonStockCode() As NonStockCode
            Get
                Return Me.nonStockCodeField
            End Get
            Set
                Me.nonStockCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterStandardPartNonStockRoute.Item0)>  _
        Public Property NonStockRoute() As QueryFilterStandardPartNonStockRoute
            Get
                Return Me.nonStockRouteField
            End Get
            Set
                Me.nonStockRouteField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the quantity to make for the standard non-stock codes specified. The format is up to 12 characters numeric with 7 integers and 3 decimals. If not provided the default is 1. This element will be ignored if the element IncludeNonStockedStandardParts is 'N'.
        '''</summary>
        Public Property NonStockQuantity() As String
            Get
                Return Me.nonStockQuantityField
            End Get
            Set
                Me.nonStockQuantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterStandardPartNonStockGrossQuantity.N)>  _
        Public Property NonStockGrossQuantity() As QueryFilterStandardPartNonStockGrossQuantity
            Get
                Return Me.nonStockGrossQuantityField
            End Get
            Set
                Me.nonStockGrossQuantityField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("NonStockList")>  _
        Public Property NonStockListCollection() As List(Of QueryFilterStandardPartNonStockList)
            Get
                Return Me.nonStockListField
            End Get
            Set
                Me.nonStockListField = value
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
        Private filterTypeField As StockCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
    Public Enum StockCodeFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseEBQ
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterStandardPartUseParentWhToUse
        
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
    Partial Public Class QueryFilterStandardPartStockList
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useEBQField As UseEBQ
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useEBQFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQuantityField As GrossQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQuantityFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.quantityField = "1"
            Me.useEBQField = UseEBQ.N
            Me.grossQuantityField = GrossQuantity.N
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of stocked standard parts for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A.  If R is selected then separated by a ','.  Example: B100,DFMB900. If L is selected then a list of stock codes must be provided using the group element StockList. This element will be ignored if the element IncludeStandardParts is 'N'.
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
        '''This indicates the quantity to make for the standard stock codes specified. This element will be ignored if the element UseEBQ is 'Y'. The format is up to 12 characters numeric with 7 integers and 3 decimals. If not provided the default is 1. This element will be ignored if the element IncludeStandardParts is 'N'.
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
        '''You may select to use the Economic batch quantity for each stocked parent part (Inventory stock code setup). If the EBQ quantity for a stock code is zero, then the quantity to make will default to one. If you select to use the route defined against the parent warehouse control (when element UseParentWhRoute = 'Y') then the EBQ quantity will be taken as the re-order quantity against the stocked parent part warehouse, therefore you must select to either use the 'warehouse to use' against the stocked parent part (supply 'Y' in 'UseParentWhToUse' element) or supply a warehouse for all standard parts (in element 'ParentWarehouse). If progressive scrap is required (Bill of Material setup, General tab) then the EBQ quantity will be taken as the net quantity. Possible values: Y (use EBQ quantity) or N (use Quantity supplied). If not provided the default is N. This element will be ignored if the element IncludeStandardParts is 'N'.
        '''</summary>
        Public Property UseEBQ() As UseEBQ
            Get
                Return Me.useEBQField
            End Get
            Set
                Me.useEBQField = value
                Me.UseEBQFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseEBQSpecified() As Boolean
            Get
                Return Me.useEBQFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If progressive scrap is required (Bill of Material setup, General tab) then you may select if the Quantity to make for stocked standard parts represents the Gross or Net quantity. Possible values: N (Net quantity) or Y (Gross quantity). If not provided the default is N. This element will be ignored if the element IncludeStandardParts is 'N'.
        '''</summary>
        Public Property GrossQuantity() As GrossQuantity
            Get
                Return Me.grossQuantityField
            End Get
            Set
                Me.grossQuantityField = value
                Me.GrossQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GrossQuantitySpecified() As Boolean
            Get
                Return Me.grossQuantityFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterStandardPartNonStockRoute
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterStandardPartNonStockGrossQuantity
        
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
    Partial Public Class QueryFilterStandardPartNonStockList
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockCodeField As NonStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockGrossQuantityField As QueryFilterStandardPartNonStockListNonStockGrossQuantity
        
        Public Sub New()
            MyBase.New
            Me.nonStockGrossQuantityField = QueryFilterStandardPartNonStockListNonStockGrossQuantity.N
            If (Me.nonStockCodeField Is Nothing) Then
                Me.nonStockCodeField = New NonStockCode
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of non-stocked standard parts for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A.  If R is selected then separated by a ','.  Example: B100A,DFMB900. If L is selected then a list of non-stock codes must be provided using the group element NonStockList. This element will be ignored if the element IncludeNonStockedStandardParts is 'N'.
        '''</summary>
        Public Property NonStockCode() As NonStockCode
            Get
                Return Me.nonStockCodeField
            End Get
            Set
                Me.nonStockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the quantity to make for the standard non-stock codes specified. The format is up to 12 characters numeric with 7 integers and 3 decimals. If not provided the default is 1. This element will be ignored if the element IncludeNonStockedStandardParts is 'N'.
        '''</summary>
        Public Property NonStockQuantity() As String
            Get
                Return Me.nonStockQuantityField
            End Get
            Set
                Me.nonStockQuantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterStandardPartNonStockListNonStockGrossQuantity.N)>  _
        Public Property NonStockGrossQuantity() As QueryFilterStandardPartNonStockListNonStockGrossQuantity
            Get
                Return Me.nonStockGrossQuantityField
            End Get
            Set
                Me.nonStockGrossQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterStandardPartNonStockListNonStockGrossQuantity
        
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
    Partial Public Class QueryFilterJobSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As Job
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBalanceOutstandingField As UseBalanceOutstanding
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBalanceOutstandingFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobListField As List(Of QueryFilterJobSelectionJobList)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassField As QueryFilterJobSelectionJobClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As QueryFilterJobSelectionJobStartDate
        
        Public Sub New()
            MyBase.New
            Me.useBalanceOutstandingField = UseBalanceOutstanding.Y
            If (Me.jobStartDateField Is Nothing) Then
                Me.jobStartDateField = New QueryFilterJobSelectionJobStartDate
            End If
            If (Me.jobClassField Is Nothing) Then
                Me.jobClassField = New QueryFilterJobSelectionJobClass
            End If
            If (Me.jobListField Is Nothing) Then
                Me.jobListField = New List(Of QueryFilterJobSelectionJobList)
            End If
            If (Me.jobField Is Nothing) Then
                Me.jobField = New Job
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of jobs for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A. If R is selected then separated by a ','.  Example: 100,120. If L is selected then a list of jobs must be provided using the group element JobList. 
        '''</summary>
        Public Property Job() As Job
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''If you select Use Balance Outstanding then the program will take the quantity to make of the job and calculate how much of each component is still required for each allocation. Possible values: Y (use balance outstanding) or N (Use Quantity to Make).
        '''</summary>
        Public Property UseBalanceOutstanding() As UseBalanceOutstanding
            Get
                Return Me.useBalanceOutstandingField
            End Get
            Set
                Me.useBalanceOutstandingField = value
                Me.UseBalanceOutstandingFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseBalanceOutstandingSpecified() As Boolean
            Get
                Return Me.useBalanceOutstandingFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If you define a quantity to make then the gross required quantity for each component (allocation) of the job will be calculated as the quantity to make multiplied by the quantity per for the allocation. This element will be ignored if the element UseBalanceOutstanding is 'Y'. The format is up to 12 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property QuantityToMake() As String
            Get
                Return Me.quantityToMakeField
            End Get
            Set
                Me.quantityToMakeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("JobList")>  _
        Public Property JobListCollection() As List(Of QueryFilterJobSelectionJobList)
            Get
                Return Me.jobListField
            End Get
            Set
                Me.jobListField = value
            End Set
        End Property
        
        Public Property JobClass() As QueryFilterJobSelectionJobClass
            Get
                Return Me.jobClassField
            End Get
            Set
                Me.jobClassField = value
            End Set
        End Property
        
        Public Property JobStartDate() As QueryFilterJobSelectionJobStartDate
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseBalanceOutstanding
        
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
    Partial Public Class QueryFilterJobSelectionJobList
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As Job
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBalanceOutstandingField As UseBalanceOutstanding
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBalanceOutstandingFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityToMakeField As String
        
        Public Sub New()
            MyBase.New
            Me.useBalanceOutstandingField = UseBalanceOutstanding.Y
            If (Me.jobField Is Nothing) Then
                Me.jobField = New Job
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of jobs for which a trial kit list must be generated ( A - All, S - Single, R - Range, L - List).  If not provided the default is A. If R is selected then separated by a ','.  Example: 100,120. If L is selected then a list of jobs must be provided using the group element JobList. 
        '''</summary>
        Public Property Job() As Job
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''If you select Use Balance Outstanding then the program will take the quantity to make of the job and calculate how much of each component is still required for each allocation. Possible values: Y (use balance outstanding) or N (Use Quantity to Make).
        '''</summary>
        Public Property UseBalanceOutstanding() As UseBalanceOutstanding
            Get
                Return Me.useBalanceOutstandingField
            End Get
            Set
                Me.useBalanceOutstandingField = value
                Me.UseBalanceOutstandingFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseBalanceOutstandingSpecified() As Boolean
            Get
                Return Me.useBalanceOutstandingFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If you define a quantity to make then the gross required quantity for each component (allocation) of the job will be calculated as the quantity to make multiplied by the quantity per for the allocation. This element will be ignored if the element UseBalanceOutstanding is 'Y'. The format is up to 12 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property QuantityToMake() As String
            Get
                Return Me.quantityToMakeField
            End Get
            Set
                Me.quantityToMakeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterJobSelectionJobClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterJobSelectionJobClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterJobSelectionJobClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterJobSelectionJobClassFilterType.A)>  _
        Public Property FilterType() As QueryFilterJobSelectionJobClassFilterType
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
    Public Enum QueryFilterJobSelectionJobClassFilterType
        
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
    Partial Public Class QueryFilterJobSelectionJobStartDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterJobSelectionJobStartDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterJobSelectionJobStartDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterJobSelectionJobStartDateFilterType.A)>  _
        Public Property FilterType() As QueryFilterJobSelectionJobStartDateFilterType
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
    Public Enum QueryFilterJobSelectionJobStartDateFilterType
        
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
    Partial Public Class QueryFilterSalesOrderSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrdersField As QueryFilterSalesOrderSelectionSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipDateField As ShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        Public Property SalesOrders() As QueryFilterSalesOrderSelectionSalesOrders
            Get
                Return Me.salesOrdersField
            End Get
            Set
                Me.salesOrdersField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicate the ship date filter on the selection of sales orders or the selection of quotations for which a trial kit list must be generated ( A - All, S - Single, R - Range).  If not provided the default is A. If R is selected then separated by a ','.  Example: 2006-05-10,2006-06-11. 
        '''</summary>
        Public Property ShipDate() As ShipDate
            Get
                Return Me.shipDateField
            End Get
            Set
                Me.shipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicate the customer filter on the selection of sales orders or the selection of quotations for which a trial kit list must be generated ( A - All, S - Single).  If not provided the default is A. 
        '''</summary>
        Public Property Customer() As Customer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterSalesOrderSelectionSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterSalesOrderSelectionSalesOrdersFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterSalesOrderSelectionSalesOrdersFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterSalesOrderSelectionSalesOrdersFilterType.A)>  _
        Public Property FilterType() As QueryFilterSalesOrderSelectionSalesOrdersFilterType
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
    Public Enum QueryFilterSalesOrderSelectionSalesOrdersFilterType
        
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
    Partial Public Class ShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ShipDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ShipDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ShipDateFilterType.A)>  _
        Public Property FilterType() As ShipDateFilterType
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
    Public Enum ShipDateFilterType
        
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
    Partial Public Class QueryFilterQuoteSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotesField As QueryFilterQuoteSelectionQuotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipDateField As ShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As QueryFilterQuoteSelectionOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private probabilityField As QueryFilterQuoteSelectionProbability
        
        Public Sub New()
            MyBase.New
            Me.offerField = QueryFilterQuoteSelectionOffer.Item1
            Me.probabilityField = QueryFilterQuoteSelectionProbability.Item0
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
            If (Me.shipDateField Is Nothing) Then
                Me.shipDateField = New ShipDate
            End If
            If (Me.quotesField Is Nothing) Then
                Me.quotesField = New QueryFilterQuoteSelectionQuotes
            End If
        End Sub
        
        Public Property Quotes() As QueryFilterQuoteSelectionQuotes
            Get
                Return Me.quotesField
            End Get
            Set
                Me.quotesField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicate the ship date filter on the selection of sales orders or the selection of quotations for which a trial kit list must be generated ( A - All, S - Single, R - Range).  If not provided the default is A. If R is selected then separated by a ','.  Example: 2006-05-10,2006-06-11. 
        '''</summary>
        Public Property ShipDate() As ShipDate
            Get
                Return Me.shipDateField
            End Get
            Set
                Me.shipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicate the customer filter on the selection of sales orders or the selection of quotations for which a trial kit list must be generated ( A - All, S - Single).  If not provided the default is A. 
        '''</summary>
        Public Property Customer() As Customer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterQuoteSelectionOffer.Item1)>  _
        Public Property Offer() As QueryFilterQuoteSelectionOffer
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryFilterQuoteSelectionProbability.Item0)>  _
        Public Property Probability() As QueryFilterQuoteSelectionProbability
            Get
                Return Me.probabilityField
            End Get
            Set
                Me.probabilityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterQuoteSelectionQuotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterQuoteSelectionQuotesFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterQuoteSelectionQuotesFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterQuoteSelectionQuotesFilterType.A)>  _
        Public Property FilterType() As QueryFilterQuoteSelectionQuotesFilterType
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
    Public Enum QueryFilterQuoteSelectionQuotesFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterQuoteSelectionOffer
        
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
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterQuoteSelectionProbability
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
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
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")>  _
        Item6
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterUseParentWhRoute
        
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
    Partial Public Class QueryFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterWarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterWarehouseFilterType.U
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterWarehouseFilterType.U)>  _
        Public Property FilterType() As QueryFilterWarehouseFilterType
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
    Public Enum QueryFilterWarehouseFilterType
        
        '''<remarks/>
        U
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStandardPartsField As QueryOptionIncludeStandardParts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedStandardPartsField As QueryOptionIncludeNonStockedStandardParts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobSelectionField As QueryOptionIncludeJobSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrderSelectionField As QueryOptionIncludeSalesOrderSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeQuoteSelectionField As QueryOptionIncludeQuoteSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeConfirmedJobsField As QueryOptionIncludeConfirmedJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedCodesField As QueryOptionIncludeNonStockedCodes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrderAllocationsField As QueryOptionIncludeSalesOrderAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWIPAllocationsField As QueryOptionIncludeWIPAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeQuotesInDemandField As QueryOptionIncludeQuotesInDemand
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSafetyMinimumQuantityField As QueryOptionIncludeSafetyMinimumQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOutstandingPurOrdersField As QueryOptionIncludeOutstandingPurOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOutstandingJobsField As QueryOptionIncludeOutstandingJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOutstandingSCTField As QueryOptionIncludeOutstandingSCT
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeQtyInPoInspectionField As QueryOptionIncludeQtyInPoInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeQtyInWipInspectionField As QueryOptionIncludeQtyInWipInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useArchivedBillsField As QueryOptionUseArchivedBills
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplyDueInDaysField As QueryOptionSupplyDueInDays
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplyDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showNegativeAllocationsField As QueryOptionShowNegativeAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As QueryOptionUnitOfMeasure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSupplierStockUomField As QueryOptionUseSupplierStockUom
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private explodeBoughtOutItemsField As QueryOptionExplodeBoughtOutItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnSupplyDemandField As QueryOptionReturnSupplyDemand
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnSourceField As QueryOptionReturnSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStyleSheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeStandardPartsField = QueryOptionIncludeStandardParts.Y
            Me.includeNonStockedStandardPartsField = QueryOptionIncludeNonStockedStandardParts.N
            Me.includeJobSelectionField = QueryOptionIncludeJobSelection.N
            Me.includeSalesOrderSelectionField = QueryOptionIncludeSalesOrderSelection.N
            Me.includeQuoteSelectionField = QueryOptionIncludeQuoteSelection.N
            Me.includeConfirmedJobsField = QueryOptionIncludeConfirmedJobs.N
            Me.includeNonStockedCodesField = QueryOptionIncludeNonStockedCodes.N
            Me.includeSalesOrderAllocationsField = QueryOptionIncludeSalesOrderAllocations.Y
            Me.includeWIPAllocationsField = QueryOptionIncludeWIPAllocations.Y
            Me.includeQuotesInDemandField = QueryOptionIncludeQuotesInDemand.N
            Me.includeSafetyMinimumQuantityField = QueryOptionIncludeSafetyMinimumQuantity.S
            Me.includeOutstandingPurOrdersField = QueryOptionIncludeOutstandingPurOrders.Y
            Me.includeOutstandingJobsField = QueryOptionIncludeOutstandingJobs.Y
            Me.includeOutstandingSCTField = QueryOptionIncludeOutstandingSCT.Y
            Me.includeQtyInPoInspectionField = QueryOptionIncludeQtyInPoInspection.Y
            Me.includeQtyInWipInspectionField = QueryOptionIncludeQtyInWipInspection.Y
            Me.useArchivedBillsField = QueryOptionUseArchivedBills.N
            Me.supplyDueInDaysField = QueryOptionSupplyDueInDays.N
            Me.showNegativeAllocationsField = QueryOptionShowNegativeAllocations.N
            Me.unitOfMeasureField = QueryOptionUnitOfMeasure.S
            Me.useSupplierStockUomField = QueryOptionUseSupplierStockUom.N
            Me.explodeBoughtOutItemsField = QueryOptionExplodeBoughtOutItems.N
            Me.returnSupplyDemandField = QueryOptionReturnSupplyDemand.N
            Me.returnSourceField = QueryOptionReturnSource.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeStandardParts.Y)>  _
        Public Property IncludeStandardParts() As QueryOptionIncludeStandardParts
            Get
                Return Me.includeStandardPartsField
            End Get
            Set
                Me.includeStandardPartsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStockedStandardParts.N)>  _
        Public Property IncludeNonStockedStandardParts() As QueryOptionIncludeNonStockedStandardParts
            Get
                Return Me.includeNonStockedStandardPartsField
            End Get
            Set
                Me.includeNonStockedStandardPartsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeJobSelection.N)>  _
        Public Property IncludeJobSelection() As QueryOptionIncludeJobSelection
            Get
                Return Me.includeJobSelectionField
            End Get
            Set
                Me.includeJobSelectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesOrderSelection.N)>  _
        Public Property IncludeSalesOrderSelection() As QueryOptionIncludeSalesOrderSelection
            Get
                Return Me.includeSalesOrderSelectionField
            End Get
            Set
                Me.includeSalesOrderSelectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeQuoteSelection.N)>  _
        Public Property IncludeQuoteSelection() As QueryOptionIncludeQuoteSelection
            Get
                Return Me.includeQuoteSelectionField
            End Get
            Set
                Me.includeQuoteSelectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeConfirmedJobs.N)>  _
        Public Property IncludeConfirmedJobs() As QueryOptionIncludeConfirmedJobs
            Get
                Return Me.includeConfirmedJobsField
            End Get
            Set
                Me.includeConfirmedJobsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStockedCodes.N)>  _
        Public Property IncludeNonStockedCodes() As QueryOptionIncludeNonStockedCodes
            Get
                Return Me.includeNonStockedCodesField
            End Get
            Set
                Me.includeNonStockedCodesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesOrderAllocations.Y)>  _
        Public Property IncludeSalesOrderAllocations() As QueryOptionIncludeSalesOrderAllocations
            Get
                Return Me.includeSalesOrderAllocationsField
            End Get
            Set
                Me.includeSalesOrderAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeWIPAllocations.Y)>  _
        Public Property IncludeWIPAllocations() As QueryOptionIncludeWIPAllocations
            Get
                Return Me.includeWIPAllocationsField
            End Get
            Set
                Me.includeWIPAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeQuotesInDemand.N)>  _
        Public Property IncludeQuotesInDemand() As QueryOptionIncludeQuotesInDemand
            Get
                Return Me.includeQuotesInDemandField
            End Get
            Set
                Me.includeQuotesInDemandField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSafetyMinimumQuantity.S)>  _
        Public Property IncludeSafetyMinimumQuantity() As QueryOptionIncludeSafetyMinimumQuantity
            Get
                Return Me.includeSafetyMinimumQuantityField
            End Get
            Set
                Me.includeSafetyMinimumQuantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeOutstandingPurOrders.Y)>  _
        Public Property IncludeOutstandingPurOrders() As QueryOptionIncludeOutstandingPurOrders
            Get
                Return Me.includeOutstandingPurOrdersField
            End Get
            Set
                Me.includeOutstandingPurOrdersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeOutstandingJobs.Y)>  _
        Public Property IncludeOutstandingJobs() As QueryOptionIncludeOutstandingJobs
            Get
                Return Me.includeOutstandingJobsField
            End Get
            Set
                Me.includeOutstandingJobsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeOutstandingSCT.Y)>  _
        Public Property IncludeOutstandingSCT() As QueryOptionIncludeOutstandingSCT
            Get
                Return Me.includeOutstandingSCTField
            End Get
            Set
                Me.includeOutstandingSCTField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeQtyInPoInspection.Y)>  _
        Public Property IncludeQtyInPoInspection() As QueryOptionIncludeQtyInPoInspection
            Get
                Return Me.includeQtyInPoInspectionField
            End Get
            Set
                Me.includeQtyInPoInspectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeQtyInWipInspection.Y)>  _
        Public Property IncludeQtyInWipInspection() As QueryOptionIncludeQtyInWipInspection
            Get
                Return Me.includeQtyInWipInspectionField
            End Get
            Set
                Me.includeQtyInWipInspectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionUseArchivedBills.N)>  _
        Public Property UseArchivedBills() As QueryOptionUseArchivedBills
            Get
                Return Me.useArchivedBillsField
            End Get
            Set
                Me.useArchivedBillsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionSupplyDueInDays.N)>  _
        Public Property SupplyDueInDays() As QueryOptionSupplyDueInDays
            Get
                Return Me.supplyDueInDaysField
            End Get
            Set
                Me.supplyDueInDaysField = value
            End Set
        End Property
        
        Public Property SupplyDays() As String
            Get
                Return Me.supplyDaysField
            End Get
            Set
                Me.supplyDaysField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionShowNegativeAllocations.N)>  _
        Public Property ShowNegativeAllocations() As QueryOptionShowNegativeAllocations
            Get
                Return Me.showNegativeAllocationsField
            End Get
            Set
                Me.showNegativeAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionUnitOfMeasure.S)>  _
        Public Property UnitOfMeasure() As QueryOptionUnitOfMeasure
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionUseSupplierStockUom.N)>  _
        Public Property UseSupplierStockUom() As QueryOptionUseSupplierStockUom
            Get
                Return Me.useSupplierStockUomField
            End Get
            Set
                Me.useSupplierStockUomField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionExplodeBoughtOutItems.N)>  _
        Public Property ExplodeBoughtOutItems() As QueryOptionExplodeBoughtOutItems
            Get
                Return Me.explodeBoughtOutItemsField
            End Get
            Set
                Me.explodeBoughtOutItemsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionReturnSupplyDemand.N)>  _
        Public Property ReturnSupplyDemand() As QueryOptionReturnSupplyDemand
            Get
                Return Me.returnSupplyDemandField
            End Get
            Set
                Me.returnSupplyDemandField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionReturnSource.N)>  _
        Public Property ReturnSource() As QueryOptionReturnSource
            Get
                Return Me.returnSourceField
            End Get
            Set
                Me.returnSourceField = value
            End Set
        End Property
        
        Public Property XslStyleSheet() As String
            Get
                Return Me.xslStyleSheetField
            End Get
            Set
                Me.xslStyleSheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeStandardParts
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNonStockedStandardParts
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeJobSelection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSalesOrderSelection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeQuoteSelection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeConfirmedJobs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNonStockedCodes
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSalesOrderAllocations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeWIPAllocations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeQuotesInDemand
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSafetyMinimumQuantity
        
        '''<remarks/>
        S
        
        '''<remarks/>
        M
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeOutstandingPurOrders
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeOutstandingJobs
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeOutstandingSCT
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeQtyInPoInspection
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeQtyInWipInspection
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionUseArchivedBills
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionSupplyDueInDays
        
        '''<remarks/>
        N
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionShowNegativeAllocations
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionUnitOfMeasure
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionUseSupplierStockUom
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionExplodeBoughtOutItems
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionReturnSupplyDemand
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionReturnSource
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
