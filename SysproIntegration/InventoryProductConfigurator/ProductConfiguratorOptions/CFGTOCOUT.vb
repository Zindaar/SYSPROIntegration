Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorOptions.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Selected
        
        '''<remarks/>
        No
        
        '''<remarks/>
        Yes
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Type
        
        '''<remarks/>
        C
        
        '''<remarks/>
        O
        
        '''<remarks/>
        Mandatory
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("Range ")>  _
        Range
        
        '''<remarks/>
        [Optional]
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class postconfiguration
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As postconfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New postconfigurationItem
            End If
        End Sub
        
        Public Property Item() As postconfigurationItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Language() As SByte
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As SByte)
                Me.languageField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property DecFormat() As Boolean
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property DateFormat() As SByte
            Get
                Return Me.dateFormatField
            End Get
            Set(ByVal value As SByte)
                Me.dateFormatField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Role() As SByte
            Get
                Return Me.roleField
            End Get
            Set(ByVal value As SByte)
                Me.roleField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As List(Of postconfigurationItemOption)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phantomLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentsField As postconfigurationItemComponents
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationsField As postconfigurationItemOperations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentConfigurationObjectField As postconfigurationItemCurrentConfigurationObject
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As postconfigurationItemParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New postconfigurationItemParameters
            End If
            If (Me.operationsField Is Nothing) Then
                Me.operationsField = New postconfigurationItemOperations
            End If
            If (Me.componentsField Is Nothing) Then
                Me.componentsField = New postconfigurationItemComponents
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New List(Of postconfigurationItemOption)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Option")>  _
        Public Property OptionCollection() As List(Of postconfigurationItemOption)
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the line you are currently on for the configuration. The line could refer to the option line, component line or operation line.         '''This element can also indicate the component/operation line when components/operations have been supplied for selection and contain errors.        '''The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''When exploding a phantom parent into its component parts, this element indicates the component line of the phantom.         '''This element can also indicate the component phantom line when phantom parts which are exploded have been supplied for selection and contain errors.        '''The format is a 5 character numeric field.
        '''</summary>
        Public Property PhantomLine() As String
            Get
                Return Me.phantomLineField
            End Get
            Set
                Me.phantomLineField = value
            End Set
        End Property
        
        Public Property Components() As postconfigurationItemComponents
            Get
                Return Me.componentsField
            End Get
            Set
                Me.componentsField = value
            End Set
        End Property
        
        Public Property Operations() As postconfigurationItemOperations
            Get
                Return Me.operationsField
            End Get
            Set
                Me.operationsField = value
            End Set
        End Property
        
        Public Property CurrentConfigurationObject() As postconfigurationItemCurrentConfigurationObject
            Get
                Return Me.currentConfigurationObjectField
            End Get
            Set
                Me.currentConfigurationObjectField = value
            End Set
        End Property
        
        Public Property Parameters() As postconfigurationItemParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As Type
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minNumComponentsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxNumComponentsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minTotCompQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxTotCompQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of postconfigurationItemOptionComponent)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minNumOperationsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxNumOperationsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of postconfigurationItemOptionOperation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anySelectedField As postconfigurationItemOptionAnySelected
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anySelectedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalValueField As String
        
        Public Sub New()
            MyBase.New
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of postconfigurationItemOptionOperation)
            End If
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of postconfigurationItemOptionComponent)
            End If
        End Sub
        
        '''<summary>
        '''This element indicates the line you are currently on for the configuration. The line could refer to the option line, component line or operation line.         '''This element can also indicate the component/operation line when components/operations have been supplied for selection and contain errors.        '''The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the option you are currently on. This element also indicates the description of the stock code within the component node. This element also indicates the description of the work centre within the operations node. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the type of option you are currently on. Possible values C - Components or  O - Operations.         '''Within the operations node this element also indicates whether the operation type is mandatory, optional or range.  Mandatory - the operation will be automatically selected. Optional  - When configuring the product you can optionally select the operation but cannot change the run time required. Range - When configuring the product you can optionally select the operation as well as change the run time required within a given range. Range is only applicable for internal operations. This element will not be output when processing a library and returning to the options phase from the finish details phase. 
        '''</summary>
        Public Property Type() As Type
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
                Me.TypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
        End Property
        
        Public Property MinNumComponents() As String
            Get
                Return Me.minNumComponentsField
            End Get
            Set
                Me.minNumComponentsField = value
            End Set
        End Property
        
        Public Property MaxNumComponents() As String
            Get
                Return Me.maxNumComponentsField
            End Get
            Set
                Me.maxNumComponentsField = value
            End Set
        End Property
        
        Public Property QtyPerDesc() As String
            Get
                Return Me.qtyPerDescField
            End Get
            Set
                Me.qtyPerDescField = value
            End Set
        End Property
        
        Public Property MinTotCompQty() As String
            Get
                Return Me.minTotCompQtyField
            End Get
            Set
                Me.minTotCompQtyField = value
            End Set
        End Property
        
        Public Property MaxTotCompQty() As String
            Get
                Return Me.maxTotCompQtyField
            End Get
            Set
                Me.maxTotCompQtyField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of postconfigurationItemOptionComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        Public Property MinNumOperations() As String
            Get
                Return Me.minNumOperationsField
            End Get
            Set
                Me.minNumOperationsField = value
            End Set
        End Property
        
        Public Property MaxNumOperations() As String
            Get
                Return Me.maxNumOperationsField
            End Get
            Set
                Me.maxNumOperationsField = value
            End Set
        End Property
        
        Public Property MinTime() As String
            Get
                Return Me.minTimeField
            End Get
            Set
                Me.minTimeField = value
            End Set
        End Property
        
        Public Property MaxTime() As String
            Get
                Return Me.maxTimeField
            End Get
            Set
                Me.maxTimeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Operation")>  _
        Public Property OperationCollection() As List(Of postconfigurationItemOptionOperation)
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property AnySelected() As postconfigurationItemOptionAnySelected
            Get
                Return Me.anySelectedField
            End Get
            Set
                Me.anySelectedField = value
                Me.AnySelectedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AnySelectedSpecified() As Boolean
            Get
                Return Me.anySelectedFieldSpecified
            End Get
        End Property
        
        Public Property Components() As String
            Get
                Return Me.componentsField
            End Get
            Set
                Me.componentsField = value
            End Set
        End Property
        
        Public Property Operations() As String
            Get
                Return Me.operationsField
            End Get
            Set
                Me.operationsField = value
            End Set
        End Property
        
        Public Property TotalValue() As String
            Get
                Return Me.totalValueField
            End Get
            Set
                Me.totalValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOptionComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectedField As Selected
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phantomLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialTypeField As postconfigurationItemOptionComponentMaterialType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maximumPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private backOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As postconfigurationItemOptionComponentDiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessField As postconfigurationItemOptionComponentDiscountPctPlusLess
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalDiscountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        '''<summary>
        '''This element indicates the line you are currently on for the configuration. The line could refer to the option line, component line or operation line.         '''This element can also indicate the component/operation line when components/operations have been supplied for selection and contain errors.        '''The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element  indicates whether the component/operation has been selected or not. Possible values are 'Yes' and 'No'
        '''</summary>
        Public Property Selected() As Selected
            Get
                Return Me.selectedField
            End Get
            Set
                Me.selectedField = value
            End Set
        End Property
        
        '''<summary>
        '''When exploding a phantom parent into its component parts, this element indicates the component line of the phantom.         '''This element can also indicate the component phantom line when phantom parts which are exploded have been supplied for selection and contain errors.        '''The format is a 5 character numeric field.
        '''</summary>
        Public Property PhantomLine() As String
            Get
                Return Me.phantomLineField
            End Get
            Set
                Me.phantomLineField = value
            End Set
        End Property
        
        Public Property MaterialType() As postconfigurationItemOptionComponentMaterialType
            Get
                Return Me.materialTypeField
            End Get
            Set
                Me.materialTypeField = value
            End Set
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the option you are currently on. This element also indicates the description of the stock code within the component node. This element also indicates the description of the work centre within the operations node. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property Available() As String
            Get
                Return Me.availableField
            End Get
            Set
                Me.availableField = value
            End Set
        End Property
        
        Public Property Free() As String
            Get
                Return Me.freeField
            End Get
            Set
                Me.freeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the minimum quantity of the component which must be selected. The format is a signed 7.3  field.        '''Within the operation node this element indicates the minimum amount of run time allowed for the operation and is only output for internal operations. The format is a  5.4 numeric field.        '''        '''
        '''</summary>
        Public Property MinimumPer() As String
            Get
                Return Me.minimumPerField
            End Get
            Set
                Me.minimumPerField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the maximum quantity of the component which can be    selected. The format is a signed 7.3  field.        '''Within the operation node this element indicates the maximum amount of run time allowed for the operation and is only output for internal operations. The format is a  5.4 numeric field.        '''        '''
        '''</summary>
        Public Property MaximumPer() As String
            Get
                Return Me.maximumPerField
            End Get
            Set
                Me.maximumPerField = value
            End Set
        End Property
        
        Public Property TotalQuantity() As String
            Get
                Return Me.totalQuantityField
            End Get
            Set
                Me.totalQuantityField = value
            End Set
        End Property
        
        Public Property QuantityUom() As String
            Get
                Return Me.quantityUomField
            End Get
            Set
                Me.quantityUomField = value
            End Set
        End Property
        
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the product class of the component/operation and will only be output when the source of the configuration is S - Sales orders or Q - Quotes. This element within the component node will not be output if exploding a phantom and the output is for the phantom parent. The format is a 4 character alphanumeric field. 
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property BackOrderQty() As String
            Get
                Return Me.backOrderQtyField
            End Get
            Set
                Me.backOrderQtyField = value
            End Set
        End Property
        
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        Public Property Commission() As String
            Get
                Return Me.commissionField
            End Get
            Set
                Me.commissionField = value
            End Set
        End Property
        
        Public Property DiscountFlag() As postconfigurationItemOptionComponentDiscountFlag
            Get
                Return Me.discountFlagField
            End Get
            Set
                Me.discountFlagField = value
                Me.DiscountFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DiscountFlagSpecified() As Boolean
            Get
                Return Me.discountFlagFieldSpecified
            End Get
        End Property
        
        Public Property DiscountPctPlusLess() As postconfigurationItemOptionComponentDiscountPctPlusLess
            Get
                Return Me.discountPctPlusLessField
            End Get
            Set
                Me.discountPctPlusLessField = value
                Me.DiscountPctPlusLessFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DiscountPctPlusLessSpecified() As Boolean
            Get
                Return Me.discountPctPlusLessFieldSpecified
            End Get
        End Property
        
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
            End Set
        End Property
        
        Public Property DiscountPct1() As String
            Get
                Return Me.discountPct1Field
            End Get
            Set
                Me.discountPct1Field = value
            End Set
        End Property
        
        Public Property DiscountPct2() As String
            Get
                Return Me.discountPct2Field
            End Get
            Set
                Me.discountPct2Field = value
            End Set
        End Property
        
        Public Property DiscountPct3() As String
            Get
                Return Me.discountPct3Field
            End Get
            Set
                Me.discountPct3Field = value
            End Set
        End Property
        
        Public Property TotalDiscountValue() As String
            Get
                Return Me.totalDiscountValueField
            End Get
            Set
                Me.totalDiscountValueField = value
            End Set
        End Property
        
        Public Property NetPrice() As String
            Get
                Return Me.netPriceField
            End Get
            Set
                Me.netPriceField = value
            End Set
        End Property
        
        Public Property LineValue() As String
            Get
                Return Me.lineValueField
            End Get
            Set
                Me.lineValueField = value
            End Set
        End Property
        
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemOptionComponentMaterialType
        
        '''<remarks/>
        Mandatory
        
        '''<remarks/>
        Range
        
        '''<remarks/>
        [Optional]
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemOptionComponentDiscountFlag
        
        '''<remarks/>
        U
        
        '''<remarks/>
        V
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemOptionComponentDiscountPctPlusLess
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOptionOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectedField As Selected
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As Type
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private machineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maximumPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCtrRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        '''<summary>
        '''This element indicates the line you are currently on for the configuration. The line could refer to the option line, component line or operation line.         '''This element can also indicate the component/operation line when components/operations have been supplied for selection and contain errors.        '''The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element  indicates whether the component/operation has been selected or not. Possible values are 'Yes' and 'No'
        '''</summary>
        Public Property Selected() As Selected
            Get
                Return Me.selectedField
            End Get
            Set
                Me.selectedField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the type of option you are currently on. Possible values C - Components or  O - Operations.         '''Within the operations node this element also indicates whether the operation type is mandatory, optional or range.  Mandatory - the operation will be automatically selected. Optional  - When configuring the product you can optionally select the operation but cannot change the run time required. Range - When configuring the product you can optionally select the operation as well as change the run time required within a given range. Range is only applicable for internal operations. This element will not be output when processing a library and returning to the options phase from the finish details phase. 
        '''</summary>
        Public Property Type() As Type
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the option you are currently on. This element also indicates the description of the stock code within the component node. This element also indicates the description of the work centre within the operations node. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property RunTime() As String
            Get
                Return Me.runTimeField
            End Get
            Set
                Me.runTimeField = value
            End Set
        End Property
        
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set
                Me.timeUomField = value
            End Set
        End Property
        
        Public Property TotalTime() As String
            Get
                Return Me.totalTimeField
            End Get
            Set
                Me.totalTimeField = value
            End Set
        End Property
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property Machine() As String
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the minimum quantity of the component which must be selected. The format is a signed 7.3  field.        '''Within the operation node this element indicates the minimum amount of run time allowed for the operation and is only output for internal operations. The format is a  5.4 numeric field.        '''        '''
        '''</summary>
        Public Property MinimumPer() As String
            Get
                Return Me.minimumPerField
            End Get
            Set
                Me.minimumPerField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the maximum quantity of the component which can be    selected. The format is a signed 7.3  field.        '''Within the operation node this element indicates the maximum amount of run time allowed for the operation and is only output for internal operations. The format is a  5.4 numeric field.        '''        '''
        '''</summary>
        Public Property MaximumPer() As String
            Get
                Return Me.maximumPerField
            End Get
            Set
                Me.maximumPerField = value
            End Set
        End Property
        
        Public Property WorkCtrRate() As String
            Get
                Return Me.workCtrRateField
            End Get
            Set
                Me.workCtrRateField = value
            End Set
        End Property
        
        Public Property UnitValue() As String
            Get
                Return Me.unitValueField
            End Get
            Set
                Me.unitValueField = value
            End Set
        End Property
        
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the product class of the component/operation and will only be output when the source of the configuration is S - Sales orders or Q - Quotes. This element within the component node will not be output if exploding a phantom and the output is for the phantom parent. The format is a 4 character alphanumeric field. 
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemOptionAnySelected
        
        '''<remarks/>
        Yes
        
        '''<remarks/>
        No
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemComponents
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validField As String
        
        '''<summary>
        '''When components/operations are supplied and errors are found then this element is output and indicates the number of component/operation lines processed. 
        '''</summary>
        Public Property LineCount() As String
            Get
                Return Me.lineCountField
            End Get
            Set
                Me.lineCountField = value
            End Set
        End Property
        
        '''<summary>
        '''When components/operations are supplied and errors are found then this element is output and indicates the number of valid component/operation lines processed. 
        '''</summary>
        Public Property Valid() As String
            Get
                Return Me.validField
            End Get
            Set
                Me.validField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOperations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validField As String
        
        '''<summary>
        '''When components/operations are supplied and errors are found then this element is output and indicates the number of component/operation lines processed. 
        '''</summary>
        Public Property LineCount() As String
            Get
                Return Me.lineCountField
            End Get
            Set
                Me.lineCountField = value
            End Set
        End Property
        
        '''<summary>
        '''When components/operations are supplied and errors are found then this element is output and indicates the number of valid component/operation lines processed. 
        '''</summary>
        Public Property Valid() As String
            Get
                Return Me.validField
            End Get
            Set
                Me.validField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemCurrentConfigurationObject
        
        '''<remarks/>
        CFGTOC
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private functionField As postconfigurationItemParametersFunction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configurationInstanceField As String
        
        Public Property [Function]() As postconfigurationItemParametersFunction
            Get
                Return Me.functionField
            End Get
            Set
                Me.functionField = value
            End Set
        End Property
        
        Public Property ConfigurationInstance() As String
            Get
                Return Me.configurationInstanceField
            End Get
            Set
                Me.configurationInstanceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemParametersFunction
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
    End Enum
End Namespace
