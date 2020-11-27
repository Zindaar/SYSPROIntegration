Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorFinishDetails.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        '''<summary>
        '''This element indicates the parent stock code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the component stock code/non-stocked code on completion of the configuration. This element is also output when creating BOM operations and indicates the parent stock code of the operation on completion of the configuration. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
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
        
        Public Property NonStockCode() As String
            Get
                Return Me.nonStockCodeField
            End Get
            Set
                Me.nonStockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicate the route of the parent stock code. This element will be output when coming from another phase and the source is  - BOM parent (B) or BOM details (b) and a parent is being created or estimate details (e) and a stocked parent is being created. This element is also output when you are creating BOM/estimate operations or components. This element indicates the route of the parent stock code on completion of the configuration. The format is a one character alphanumeric field.
        '''</summary>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
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
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishSalesQuoteParentField As postconfigurationItemFinishSalesQuoteParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishListPriceDetailsField As postconfigurationItemFinishListPriceDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createBomEstJobField As postconfigurationItemCreateBomEstJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createBomEstJobFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectionCriteriaProcessedField As postconfigurationItemSelectionCriteriaProcessed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectionCriteriaProcessedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compsOpersSelectedField As postconfigurationItemCompsOpersSelected
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compsOpersSelectedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bomRoutingField As List(Of Key)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bomStructureField As List(Of Key)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qotRoutingField As List(Of Key)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qotStructureField As List(Of Key)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDetailsField As postconfigurationItemJobDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrdersField As postconfigurationItemSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationField As postconfigurationItemQuotation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectionCriteriaField As postconfigurationItemSelectionCriteria
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As postconfigurationItemOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configurationField As postconfigurationItemConfiguration
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configurationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentConfigurationObjectField As postconfigurationItemCurrentConfigurationObject
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentConfigurationObjectFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As postconfigurationItemParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New postconfigurationItemParameters
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New postconfigurationItemOption
            End If
            If (Me.selectionCriteriaField Is Nothing) Then
                Me.selectionCriteriaField = New postconfigurationItemSelectionCriteria
            End If
            If (Me.quotationField Is Nothing) Then
                Me.quotationField = New postconfigurationItemQuotation
            End If
            If (Me.salesOrdersField Is Nothing) Then
                Me.salesOrdersField = New postconfigurationItemSalesOrders
            End If
            If (Me.jobDetailsField Is Nothing) Then
                Me.jobDetailsField = New postconfigurationItemJobDetails
            End If
            If (Me.qotStructureField Is Nothing) Then
                Me.qotStructureField = New List(Of Key)
            End If
            If (Me.qotRoutingField Is Nothing) Then
                Me.qotRoutingField = New List(Of Key)
            End If
            If (Me.bomStructureField Is Nothing) Then
                Me.bomStructureField = New List(Of Key)
            End If
            If (Me.bomRoutingField Is Nothing) Then
                Me.bomRoutingField = New List(Of Key)
            End If
            If (Me.finishListPriceDetailsField Is Nothing) Then
                Me.finishListPriceDetailsField = New postconfigurationItemFinishListPriceDetails
            End If
            If (Me.finishSalesQuoteParentField Is Nothing) Then
                Me.finishSalesQuoteParentField = New postconfigurationItemFinishSalesQuoteParent
            End If
        End Sub
        
        '''<summary>
        '''This element indicates the parent stock code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the component stock code/non-stocked code on completion of the configuration. This element is also output when creating BOM operations and indicates the parent stock code of the operation on completion of the configuration. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the stocked code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the description for the component stock code/non-stocked code and the operation work centre on completion of the configuration. The format is a 30 character alphanumeric field.
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
        '''This element indicates the warehouse against the parent stock code. For non-stocked items this element will be '**'. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the component warehouse on completion of the configuration. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the quantity of the parent required. This element is output when the source is sales orders (S), quotes (Q) or jobs (W) and when you are coming from another phase. This element is also output when the source is T - test mode and indicates the total component quantity required on completion of the configuration. The format is a signed 7.3 field.
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
        '''This element indicates the quantity unit of measure of the parent. This element is output when the source is sales orders (S), quotes (Q) or jobs (W) and when you are coming from another phase. This element is also output when the source is T - test mode and indicates the quantity unit of measure of the component on completion of the configuration. The format is a 3 character alphanumeric field.
        '''</summary>
        Public Property QuantityUom() As String
            Get
                Return Me.quantityUomField
            End Get
            Set
                Me.quantityUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicate the route of the parent stock code. This element will be output when coming from another phase and the source is  - BOM parent (B) or BOM details (b) and a parent is being created or estimate details (e) and a stocked parent is being created. This element is also output when you are creating BOM/estimate operations or components. This element indicates the route of the parent stock code on completion of the configuration. The format is a one character alphanumeric field.
        '''</summary>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = value
            End Set
        End Property
        
        Public Property UnitVolume() As String
            Get
                Return Me.unitVolumeField
            End Get
            Set
                Me.unitVolumeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the product class of the parent. This element is output when the source is sales orders (S) or quotes (Q) and you are coming from another phase. This element is also output when the source is T - test mode and indicates the product class of the component and operations on completion of the configuration. The format is a 4 character alphanumeric field.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property FinishSalesQuoteParent() As postconfigurationItemFinishSalesQuoteParent
            Get
                Return Me.finishSalesQuoteParentField
            End Get
            Set
                Me.finishSalesQuoteParentField = value
            End Set
        End Property
        
        Public Property FinishListPriceDetails() As postconfigurationItemFinishListPriceDetails
            Get
                Return Me.finishListPriceDetailsField
            End Get
            Set
                Me.finishListPriceDetailsField = value
            End Set
        End Property
        
        Public Property CreateBomEstJob() As postconfigurationItemCreateBomEstJob
            Get
                Return Me.createBomEstJobField
            End Get
            Set
                Me.createBomEstJobField = value
                Me.CreateBomEstJobFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CreateBomEstJobSpecified() As Boolean
            Get
                Return Me.createBomEstJobFieldSpecified
            End Get
        End Property
        
        Public Property SelectionCriteriaProcessed() As postconfigurationItemSelectionCriteriaProcessed
            Get
                Return Me.selectionCriteriaProcessedField
            End Get
            Set
                Me.selectionCriteriaProcessedField = value
                Me.SelectionCriteriaProcessedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SelectionCriteriaProcessedSpecified() As Boolean
            Get
                Return Me.selectionCriteriaProcessedFieldSpecified
            End Get
        End Property
        
        Public Property CompsOpersSelected() As postconfigurationItemCompsOpersSelected
            Get
                Return Me.compsOpersSelectedField
            End Get
            Set
                Me.compsOpersSelectedField = value
                Me.CompsOpersSelectedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CompsOpersSelectedSpecified() As Boolean
            Get
                Return Me.compsOpersSelectedFieldSpecified
            End Get
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable:=false)>  _
        Public Property BomRoutingCollection() As List(Of Key)
            Get
                Return Me.bomRoutingField
            End Get
            Set
                Me.bomRoutingField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable:=false)>  _
        Public Property BomStructureCollection() As List(Of Key)
            Get
                Return Me.bomStructureField
            End Get
            Set
                Me.bomStructureField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable:=false)>  _
        Public Property QotRoutingCollection() As List(Of Key)
            Get
                Return Me.qotRoutingField
            End Get
            Set
                Me.qotRoutingField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable:=false)>  _
        Public Property QotStructureCollection() As List(Of Key)
            Get
                Return Me.qotStructureField
            End Get
            Set
                Me.qotStructureField = value
            End Set
        End Property
        
        Public Property JobDetails() As postconfigurationItemJobDetails
            Get
                Return Me.jobDetailsField
            End Get
            Set
                Me.jobDetailsField = value
            End Set
        End Property
        
        Public Property SalesOrders() As postconfigurationItemSalesOrders
            Get
                Return Me.salesOrdersField
            End Get
            Set
                Me.salesOrdersField = value
            End Set
        End Property
        
        Public Property Quotation() As postconfigurationItemQuotation
            Get
                Return Me.quotationField
            End Get
            Set
                Me.quotationField = value
            End Set
        End Property
        
        Public Property SelectionCriteria() As postconfigurationItemSelectionCriteria
            Get
                Return Me.selectionCriteriaField
            End Get
            Set
                Me.selectionCriteriaField = value
            End Set
        End Property
        
        Public Property [Option]() As postconfigurationItemOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Configuration() As postconfigurationItemConfiguration
            Get
                Return Me.configurationField
            End Get
            Set
                Me.configurationField = value
                Me.ConfigurationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfigurationSpecified() As Boolean
            Get
                Return Me.configurationFieldSpecified
            End Get
        End Property
        
        Public Property CurrentConfigurationObject() As postconfigurationItemCurrentConfigurationObject
            Get
                Return Me.currentConfigurationObjectField
            End Get
            Set
                Me.currentConfigurationObjectField = value
                Me.CurrentConfigurationObjectFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CurrentConfigurationObjectSpecified() As Boolean
            Get
                Return Me.currentConfigurationObjectFieldSpecified
            End Get
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
    Partial Public Class postconfigurationItemFinishSalesQuoteParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As postconfigurationItemFinishSalesQuoteParentDiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessField As postconfigurationItemFinishSalesQuoteParentDiscountPctPlusLess
        
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
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFlagField As postconfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFlagFieldSpecified As Boolean
        
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
            End Set
        End Property
        
        '''<summary>
        '''When creating a new stocked parent this element indicates the list price code of the parent. This element also indicates the price code of a parent and is only output when an existing stocked parent which has a bill of material is being used and the source is sales orders (S) and the pricing method is simple or extended. If this element contains an '!' then the price is a contract price. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the price of the parent which defaults to the accumulated line value of the components and operations selected. When the source is sales orders (S) and an existing stock code which has a bill of material is used, this element will default to the price set up within SYSPRO. This element also indicates the list price of the parent which defaults to the accumulated list price of the components selected as well as the accumulated line value of the operations selected. The format is a 10.5 numeric field.
        '''</summary>
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
        
        '''<summary>
        '''This element indicates the commission of the parent part. This element also indicates the commission of the list price when creating a stocked parent. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property Commission() As String
            Get
                Return Me.commissionField
            End Get
            Set
                Me.commissionField = value
            End Set
        End Property
        
        Public Property DiscountFlag() As postconfigurationItemFinishSalesQuoteParentDiscountFlag
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
        
        Public Property DiscountPctPlusLess() As postconfigurationItemFinishSalesQuoteParentDiscountPctPlusLess
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
        
        '''<summary>
        '''This element indicates the total value for the parent line when creating a sales order or quote and coming from another phase. This element also indicates the total value of the component/operation line when the source is test mode (T) on completion of the configuration. The format is a signed 12.2 field.
        '''</summary>
        Public Property LineValue() As String
            Get
                Return Me.lineValueField
            End Get
            Set
                Me.lineValueField = value
            End Set
        End Property
        
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        Public Property SupplementaryUnitsFlag() As postconfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
            Get
                Return Me.supplementaryUnitsFlagField
            End Get
            Set
                Me.supplementaryUnitsFlagField = value
                Me.SupplementaryUnitsFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SupplementaryUnitsFlagSpecified() As Boolean
            Get
                Return Me.supplementaryUnitsFlagFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemFinishSalesQuoteParentDiscountFlag
        
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
    Public Enum postconfigurationItemFinishSalesQuoteParentDiscountPctPlusLess
        
        '''<remarks/>
        L
        
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
    Public Enum postconfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
        
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
    Partial Public Class postconfigurationItemFinishListPriceDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceBasisField As postconfigurationItemFinishListPriceDetailsPriceBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        '''<summary>
        '''When creating a new stocked parent this element indicates the list price code of the parent. This element also indicates the price code of a parent and is only output when an existing stocked parent which has a bill of material is being used and the source is sales orders (S) and the pricing method is simple or extended. If this element contains an '!' then the price is a contract price. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the price of the parent which defaults to the accumulated line value of the components and operations selected. When the source is sales orders (S) and an existing stock code which has a bill of material is used, this element will default to the price set up within SYSPRO. This element also indicates the list price of the parent which defaults to the accumulated list price of the components selected as well as the accumulated line value of the operations selected. The format is a 10.5 numeric field.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property PriceBasis() As postconfigurationItemFinishListPriceDetailsPriceBasis
            Get
                Return Me.priceBasisField
            End Get
            Set
                Me.priceBasisField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the commission of the parent part. This element also indicates the commission of the list price when creating a stocked parent. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property Commission() As String
            Get
                Return Me.commissionField
            End Get
            Set
                Me.commissionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemFinishListPriceDetailsPriceBasis
        
        '''<remarks/>
        S
        
        '''<remarks/>
        O
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemCreateBomEstJob
        
        '''<remarks/>
        B
        
        '''<remarks/>
        J
        
        '''<remarks/>
        E
        
        '''<remarks/>
        A
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemSelectionCriteriaProcessed
        
        '''<remarks/>
        Yes
        
        '''<remarks/>
        No
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemCompsOpersSelected
        
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
    Partial Public Class postconfigurationItemJobDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobsField As List(Of postconfigurationItemJobDetailsSubJobs)
        
        Public Sub New()
            MyBase.New
            If (Me.subJobsField Is Nothing) Then
                Me.subJobsField = New List(Of postconfigurationItemJobDetailsSubJobs)
            End If
        End Sub
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SubJobs")>  _
        Public Property SubJobsCollection() As List(Of postconfigurationItemJobDetailsSubJobs)
            Get
                Return Me.subJobsField
            End Get
            Set
                Me.subJobsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemJobDetailsSubJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.jobField Is Nothing) Then
                Me.jobField = New List(Of String)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Job")>  _
        Public Property JobCollection() As List(Of String)
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemQuotation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemSelectionCriteria
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectionField As postconfigurationItemSelectionCriteriaSelection
        
        Public Sub New()
            MyBase.New
            If (Me.selectionField Is Nothing) Then
                Me.selectionField = New postconfigurationItemSelectionCriteriaSelection
            End If
        End Sub
        
        Public Property Selection() As postconfigurationItemSelectionCriteriaSelection
            Get
                Return Me.selectionField
            End Get
            Set
                Me.selectionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemSelectionCriteriaSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private criteriaChosenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        '''<summary>
        '''This element indicates the selection line processed. This element also indicates the option line processed. This element also indicates the component/operation line which was selected. The format is a 3 character numeric field.
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
        '''This element indicates the description of the stocked code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the description for the component stock code/non-stocked code and the operation work centre on completion of the configuration. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property CriteriaChosen() As String
            Get
                Return Me.criteriaChosenField
            End Get
            Set
                Me.criteriaChosenField = value
            End Set
        End Property
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of postconfigurationItemOptionOperation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of postconfigurationItemOptionComponent)
        
        Public Sub New()
            MyBase.New
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of postconfigurationItemOptionComponent)
            End If
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of postconfigurationItemOptionOperation)
            End If
        End Sub
        
        '''<summary>
        '''This element indicates the selection line processed. This element also indicates the option line processed. This element also indicates the component/operation line which was selected. The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
        
        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of postconfigurationItemOptionComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
    End Class
    
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
        Private workCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As postconfigurationItemOptionOperationType
        
        '''<summary>
        '''This element indicates the selection line processed. This element also indicates the option line processed. This element also indicates the component/operation line which was selected. The format is a 3 character numeric field.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        Public Property WorkCenter() As String
            Get
                Return Me.workCenterField
            End Get
            Set
                Me.workCenterField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the stocked code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the description for the component stock code/non-stocked code and the operation work centre on completion of the configuration. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
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
        
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set
                Me.timeUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the product class of the parent. This element is output when the source is sales orders (S) or quotes (Q) and you are coming from another phase. This element is also output when the source is T - test mode and indicates the product class of the component and operations on completion of the configuration. The format is a 4 character alphanumeric field.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the total value for the parent line when creating a sales order or quote and coming from another phase. This element also indicates the total value of the component/operation line when the source is test mode (T) on completion of the configuration. The format is a signed 12.2 field.
        '''</summary>
        Public Property LineValue() As String
            Get
                Return Me.lineValueField
            End Get
            Set
                Me.lineValueField = value
            End Set
        End Property
        
        Public Property Type() As postconfigurationItemOptionOperationType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemOptionOperationType
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemOptionComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialTypeField As postconfigurationItemOptionComponentMaterialType
        
        '''<summary>
        '''This element indicates the selection line processed. This element also indicates the option line processed. This element also indicates the component/operation line which was selected. The format is a 3 character numeric field.
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
        '''This element indicates the parent stock code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the component stock code/non-stocked code on completion of the configuration. This element is also output when creating BOM operations and indicates the parent stock code of the operation on completion of the configuration. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the stocked code/non-stocked code. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the description for the component stock code/non-stocked code and the operation work centre on completion of the configuration. The format is a 30 character alphanumeric field.
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
        '''This element indicates the quantity of the parent required. This element is output when the source is sales orders (S), quotes (Q) or jobs (W) and when you are coming from another phase. This element is also output when the source is T - test mode and indicates the total component quantity required on completion of the configuration. The format is a signed 7.3 field.
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
        '''This element indicates the quantity unit of measure of the parent. This element is output when the source is sales orders (S), quotes (Q) or jobs (W) and when you are coming from another phase. This element is also output when the source is T - test mode and indicates the quantity unit of measure of the component on completion of the configuration. The format is a 3 character alphanumeric field.
        '''</summary>
        Public Property QuantityUom() As String
            Get
                Return Me.quantityUomField
            End Get
            Set
                Me.quantityUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the product class of the parent. This element is output when the source is sales orders (S) or quotes (Q) and you are coming from another phase. This element is also output when the source is T - test mode and indicates the product class of the component and operations on completion of the configuration. The format is a 4 character alphanumeric field.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the warehouse against the parent stock code. For non-stocked items this element will be '**'. This element is output when a parent part is being created and you come from another phase. This element is also output when the source is T - test mode and indicates the component warehouse on completion of the configuration. The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the total value for the parent line when creating a sales order or quote and coming from another phase. This element also indicates the total value of the component/operation line when the source is test mode (T) on completion of the configuration. The format is a signed 12.2 field.
        '''</summary>
        Public Property LineValue() As String
            Get
                Return Me.lineValueField
            End Get
            Set
                Me.lineValueField = value
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
    Public Enum postconfigurationItemConfiguration
        
        '''<remarks/>
        Complete
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemCurrentConfigurationObject
        
        '''<remarks/>
        CFGTFD
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
