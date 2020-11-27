Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderBackOrderReleaseBuild.BuildData
    
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
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As Filter
        
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
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IBuild.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IBuild.BusinessObject
            Get
                Return "SORRBO"
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequence1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequence2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCounterSaleOrdersField As IncludeCounterSaleOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCounterSaleOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeSchedOrderLinesNotAllocField As ExcludeSchedOrderLinesNotAlloc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeSchedOrderLinesNotAllocFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negativeWhOnlyConsiderFreeStockField As NegativeWhOnlyConsiderFreeStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negativeWhOnlyConsiderFreeStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showZeroToReleaseField As ShowZeroToRelease
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showZeroToReleaseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showOnHoldStockField As ShowOnHoldStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showOnHoldStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBillsStatus8Field As IncludeBillsStatus8
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBillsStatus8FieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''This element is used to indicate the primary sequence in which you want orders to be returned. The default sequence is sales order(O). ( O - Order number;  S - Salesperson;  C - Customer class;  G - Geographic area; L - Line ship date;      T - Stock code; U - Customer)       
        ''' 
        '''
        '''</summary>
        Public Property Sequence1() As String
            Get
                Return Me.sequence1Field
            End Get
            Set
                Me.sequence1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element is used to indicate the secondary sequence in which you want orders to be returned. The default sequence is sales order(O). ( O - Order number;  S - Salesperson;  C - Customer class;  G - Geographic area; L - Line ship date;      T - Stock code; U - Customer)    
        '''</summary>
        Public Property Sequence2() As String
            Get
                Return Me.sequence2Field
            End Get
            Set
                Me.sequence2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element gives an option to include counter sale orders.  (Y - Yes , N -No)   Default - N (No).
        '''</summary>
        Public Property IncludeCounterSaleOrders() As IncludeCounterSaleOrders
            Get
                Return Me.includeCounterSaleOrdersField
            End Get
            Set
                Me.includeCounterSaleOrdersField = value
                Me.IncludeCounterSaleOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCounterSaleOrdersSpecified() As Boolean
            Get
                Return Me.includeCounterSaleOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to exclude scheduled order lines not yet allocated. (Y- Yes, N - No) , default N - No. 
        '''
        '''</summary>
        Public Property ExcludeSchedOrderLinesNotAlloc() As ExcludeSchedOrderLinesNotAlloc
            Get
                Return Me.excludeSchedOrderLinesNotAllocField
            End Get
            Set
                Me.excludeSchedOrderLinesNotAllocField = value
                Me.ExcludeSchedOrderLinesNotAllocFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExcludeSchedOrderLinesNotAllocSpecified() As Boolean
            Get
                Return Me.excludeSchedOrderLinesNotAllocFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include negative warehouse only consider free stock. (Y- Yes, N - No) , default N - No. 
        '''</summary>
        Public Property NegativeWhOnlyConsiderFreeStock() As NegativeWhOnlyConsiderFreeStock
            Get
                Return Me.negativeWhOnlyConsiderFreeStockField
            End Get
            Set
                Me.negativeWhOnlyConsiderFreeStockField = value
                Me.NegativeWhOnlyConsiderFreeStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NegativeWhOnlyConsiderFreeStockSpecified() As Boolean
            Get
                Return Me.negativeWhOnlyConsiderFreeStockFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to show sales orders with zero quantity to release. (Y- Yes, N - No) , default Y - Yes. 
        '''</summary>
        Public Property ShowZeroToRelease() As ShowZeroToRelease
            Get
                Return Me.showZeroToReleaseField
            End Get
            Set
                Me.showZeroToReleaseField = value
                Me.ShowZeroToReleaseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShowZeroToReleaseSpecified() As Boolean
            Get
                Return Me.showZeroToReleaseFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This option can be used to include stock that is on hold in the information returned. N - default - do not return lines where stock is on hold. P - return lines where the stock item is on partial hold. Y - return lines where stock is on either full or partial hold.
        '''</summary>
        Public Property ShowOnHoldStock() As ShowOnHoldStock
            Get
                Return Me.showOnHoldStockField
            End Get
            Set
                Me.showOnHoldStockField = value
                Me.ShowOnHoldStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShowOnHoldStockSpecified() As Boolean
            Get
                Return Me.showOnHoldStockFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include billings in status 8. ( Y - Yes , N -No),  Default - N (No).
        '''</summary>
        Public Property IncludeBillsStatus8() As IncludeBillsStatus8
            Get
                Return Me.includeBillsStatus8Field
            End Get
            Set
                Me.includeBillsStatus8Field = value
                Me.IncludeBillsStatus8FieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBillsStatus8Specified() As Boolean
            Get
                Return Me.includeBillsStatus8FieldSpecified
            End Get
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
    Public Enum IncludeCounterSaleOrders
        
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
    Public Enum ExcludeSchedOrderLinesNotAlloc
        
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
    Public Enum NegativeWhOnlyConsiderFreeStock
        
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
    Public Enum ShowZeroToRelease
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ShowOnHoldStock
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
        
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
    Public Enum IncludeBillsStatus8
        
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
    Partial Public Class XslStylesheet
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
        Private salesOrderField As SalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As Warehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerClassField As CustomerClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaField As GeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipDateField As ShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesPersonField As SalesPerson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        Public Sub New()
            MyBase.New
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
            If (Me.salesPersonField Is Nothing) Then
                Me.salesPersonField = New SalesPerson
            End If
            If (Me.shipDateField Is Nothing) Then
                Me.shipDateField = New ShipDate
            End If
            If (Me.geographicAreaField Is Nothing) Then
                Me.geographicAreaField = New GeographicArea
            End If
            If (Me.productClassField Is Nothing) Then
                Me.productClassField = New ProductClass
            End If
            If (Me.customerClassField Is Nothing) Then
                Me.customerClassField = New CustomerClass
            End If
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New Warehouse
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
            If (Me.salesOrderField Is Nothing) Then
                Me.salesOrderField = New SalesOrder
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of sales order ( A - All, R - Range, S - Single). Default  A (All). 
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
        '''This specifies the selection of stock codes ( A - All, S - Single, R - Range). Default is A (All).
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
        '''This specifies the selection of warehouses ( A - All, S - Single).  Default A (All).
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
        '''This specifies the selection of the customer class ( A - All, S - Single).  Default is A (All).
        '''</summary>
        Public Property CustomerClass() As CustomerClass
            Get
                Return Me.customerClassField
            End Get
            Set
                Me.customerClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of productclass ( A - All, S - Single).  Default is A (All).
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
        '''This specifies the selection of the geographic area ( A - All, S - Single).  Default is A (All).
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
        '''This specifies the selection of ship date ( A - All, S - Single, R - Range).  Default is A (All). Date must be in CCYYMMDD format.
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
        '''This specifies the selection of salesperson ( A - All, S - Single). Default  A (All).
        '''</summary>
        Public Property SalesPerson() As SalesPerson
            Get
                Return Me.salesPersonField
            End Get
            Set
                Me.salesPersonField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of the customer ( A - All, S - Single).  Default is A (All). 
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
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CustomerClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CustomerClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CustomerClassFilterType.A)>  _
        Public Property FilterType() As CustomerClassFilterType
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
    Public Enum CustomerClassFilterType
        
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
        S
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
        A
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SalesPerson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SalesPersonFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = SalesPersonFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(SalesPersonFilterType.A)>  _
        Public Property FilterType() As SalesPersonFilterType
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
    Public Enum SalesPersonFilterType
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
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
End Namespace
