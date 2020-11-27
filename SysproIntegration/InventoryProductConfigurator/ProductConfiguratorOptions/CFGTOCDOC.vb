Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorOptions.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostConfiguration
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostConfigurationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostConfigurationItem
            End If
        End Sub
        
        Public Property Item() As PostConfigurationItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "CFGTOC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostConfigurationParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostConfigurationParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostConfiguration
                objParams = New Params.PostConfiguration
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As List(Of Object)
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Component", GetType(PostConfigurationItemComponent), IsNullable:=false),  _
         System.Xml.Serialization.XmlArrayItemAttribute("Line", GetType(String), IsNullable:=false),  _
         System.Xml.Serialization.XmlArrayItemAttribute("Operation", GetType(PostConfigurationItemOperation), IsNullable:=false),  _
         System.Xml.Serialization.XmlArrayItemAttribute("Type", GetType(PostConfigurationItemType), IsNullable:=false)>  _
        Public Property OptionCollection() As List(Of Object)
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectField As [Select]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phantomLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceFlgField As PostConfigurationItemComponentPriceFlg
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceFlgFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomMulDivField As PostConfigurationItemComponentPriceUomMulDiv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomMulDivFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomFactorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As PostConfigurationItemComponentDiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessField As PostConfigurationItemComponentDiscountPctPlusLess
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        '''<summary>
        '''This element indicates whether you are selecting or deselecting a component/operation. You may also maintain a previously selected component/operation by supplying an S. Possible values: S (select) or D (deselect). This is a mandatory element.
        '''</summary>
        Public Property [Select]() As [Select]
            Get
                Return Me.selectField
            End Get
            Set
                Me.selectField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the line you are currently processing for the configuration. The line could refer to the option line, component line or operation line.This element is mandatory. The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        Public Property PhantomLine() As String
            Get
                Return Me.phantomLineField
            End Get
            Set
                Me.phantomLineField = value
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
        
        '''<summary>
        '''This element indicates the product class of the component or operation. This element is only required when the source of the configuration is sales orders or quotes. For a stocked component this element will default to the product class held against the configuration maintenance, else if this is spaces, this element will default to the product class held against the stock code. When creating a sales order for a parent which is a kit type parent then the stocked component product class cannot be changed and the inventory master product class will be used. For a non-stocked component this element will default to the product class held against the configuration maintenance, else if this is spaces, this element will default to the product class held against the component. For an operation this element will default to the product class against the configuration maintenance, if this is spaces this element will default to the product class against the work centre, and if this is spaces it will default to _LAB. The format is a 4 character alphanumeric field. 
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
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
        
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        Public Property PriceFlg() As PostConfigurationItemComponentPriceFlg
            Get
                Return Me.priceFlgField
            End Get
            Set
                Me.priceFlgField = value
                Me.PriceFlgFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceFlgSpecified() As Boolean
            Get
                Return Me.priceFlgFieldSpecified
            End Get
        End Property
        
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
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
        
        Public Property PriceUomMulDiv() As PostConfigurationItemComponentPriceUomMulDiv
            Get
                Return Me.priceUomMulDivField
            End Get
            Set
                Me.priceUomMulDivField = value
                Me.PriceUomMulDivFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceUomMulDivSpecified() As Boolean
            Get
                Return Me.priceUomMulDivFieldSpecified
            End Get
        End Property
        
        Public Property PriceUomFactor() As String
            Get
                Return Me.priceUomFactorField
            End Get
            Set
                Me.priceUomFactorField = value
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
        
        Public Property DiscountFlag() As PostConfigurationItemComponentDiscountFlag
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
        
        Public Property DiscountPctPlusLess() As PostConfigurationItemComponentDiscountPctPlusLess
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
        
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum [Select]
        
        '''<remarks/>
        S
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemComponentPriceFlg
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemComponentPriceUomMulDiv
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemComponentDiscountFlag
        
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
    Public Enum PostConfigurationItemComponentDiscountPctPlusLess
        
        '''<remarks/>
        P
        
        '''<remarks/>
        L
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectField As [Select]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        '''<summary>
        '''This element indicates whether you are selecting or deselecting a component/operation. You may also maintain a previously selected component/operation by supplying an S. Possible values: S (select) or D (deselect). This is a mandatory element.
        '''</summary>
        Public Property [Select]() As [Select]
            Get
                Return Me.selectField
            End Get
            Set
                Me.selectField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the line you are currently processing for the configuration. The line could refer to the option line, component line or operation line.This element is mandatory. The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
        
        '''<summary>
        '''This element indicates the product class of the component or operation. This element is only required when the source of the configuration is sales orders or quotes. For a stocked component this element will default to the product class held against the configuration maintenance, else if this is spaces, this element will default to the product class held against the stock code. When creating a sales order for a parent which is a kit type parent then the stocked component product class cannot be changed and the inventory master product class will be used. For a non-stocked component this element will default to the product class held against the configuration maintenance, else if this is spaces, this element will default to the product class held against the component. For an operation this element will default to the product class against the configuration maintenance, if this is spaces this element will default to the product class against the work centre, and if this is spaces it will default to _LAB. The format is a 4 character alphanumeric field. 
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
    Public Enum PostConfigurationItemType
        
        '''<remarks/>
        O
        
        '''<remarks/>
        C
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
