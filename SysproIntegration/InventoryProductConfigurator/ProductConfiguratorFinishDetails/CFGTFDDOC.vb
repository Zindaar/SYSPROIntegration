Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorFinishDetails.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DiscountFlag
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DiscountPctPlusLess
        
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
                Return "CFGTFD"
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
        Private finishBomEstimateField As PostConfigurationItemFinishBomEstimate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishListPriceDetailsField As PostConfigurationItemFinishListPriceDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishSalesQuoteNoParentField As PostConfigurationItemFinishSalesQuoteNoParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishSalesQuoteParentField As PostConfigurationItemFinishSalesQuoteParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finishJobDetailsField As PostConfigurationItemFinishJobDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private libraryMaintenanceField As PostConfigurationItemLibraryMaintenance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createBomEstJobField As PostConfigurationItemCreateBomEstJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createBomEstJobFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefinedCommentsField As String
        
        Public Sub New()
            MyBase.New
            If (Me.libraryMaintenanceField Is Nothing) Then
                Me.libraryMaintenanceField = New PostConfigurationItemLibraryMaintenance
            End If
            If (Me.finishJobDetailsField Is Nothing) Then
                Me.finishJobDetailsField = New PostConfigurationItemFinishJobDetails
            End If
            If (Me.finishSalesQuoteParentField Is Nothing) Then
                Me.finishSalesQuoteParentField = New PostConfigurationItemFinishSalesQuoteParent
            End If
            If (Me.finishSalesQuoteNoParentField Is Nothing) Then
                Me.finishSalesQuoteNoParentField = New PostConfigurationItemFinishSalesQuoteNoParent
            End If
            If (Me.finishListPriceDetailsField Is Nothing) Then
                Me.finishListPriceDetailsField = New PostConfigurationItemFinishListPriceDetails
            End If
            If (Me.finishBomEstimateField Is Nothing) Then
                Me.finishBomEstimateField = New PostConfigurationItemFinishBomEstimate
            End If
        End Sub
        
        Public Property FinishBomEstimate() As PostConfigurationItemFinishBomEstimate
            Get
                Return Me.finishBomEstimateField
            End Get
            Set
                Me.finishBomEstimateField = value
            End Set
        End Property
        
        Public Property FinishListPriceDetails() As PostConfigurationItemFinishListPriceDetails
            Get
                Return Me.finishListPriceDetailsField
            End Get
            Set
                Me.finishListPriceDetailsField = value
            End Set
        End Property
        
        Public Property FinishSalesQuoteNoParent() As PostConfigurationItemFinishSalesQuoteNoParent
            Get
                Return Me.finishSalesQuoteNoParentField
            End Get
            Set
                Me.finishSalesQuoteNoParentField = value
            End Set
        End Property
        
        Public Property FinishSalesQuoteParent() As PostConfigurationItemFinishSalesQuoteParent
            Get
                Return Me.finishSalesQuoteParentField
            End Get
            Set
                Me.finishSalesQuoteParentField = value
            End Set
        End Property
        
        Public Property FinishJobDetails() As PostConfigurationItemFinishJobDetails
            Get
                Return Me.finishJobDetailsField
            End Get
            Set
                Me.finishJobDetailsField = value
            End Set
        End Property
        
        Public Property LibraryMaintenance() As PostConfigurationItemLibraryMaintenance
            Get
                Return Me.libraryMaintenanceField
            End Get
            Set
                Me.libraryMaintenanceField = value
            End Set
        End Property
        
        Public Property CreateBomEstJob() As PostConfigurationItemCreateBomEstJob
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
        
        Public Property UserDefinedComments() As String
            Get
                Return Me.userDefinedCommentsField
            End Get
            Set
                Me.userDefinedCommentsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemFinishBomEstimate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentOptionsField As PostConfigurationItemFinishBomEstimateComponentOptions
        
        Public Sub New()
            MyBase.New
            Me.componentOptionsField = PostConfigurationItemFinishBomEstimateComponentOptions.A
        End Sub
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishBomEstimateComponentOptions.A)>  _
        Public Property ComponentOptions() As PostConfigurationItemFinishBomEstimateComponentOptions
            Get
                Return Me.componentOptionsField
            End Get
            Set
                Me.componentOptionsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishBomEstimateComponentOptions
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemFinishListPriceDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceBasisField As PostConfigurationItemFinishListPriceDetailsPriceBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        Public Sub New()
            MyBase.New
            Me.priceBasisField = PostConfigurationItemFinishListPriceDetailsPriceBasis.S
        End Sub
        
        '''<summary>
        '''This element indicates the price code against the parent price/list price. The price code in the finishlistpricedetails node is only applicable when creating a stocked parent.The price code in the finishsalesquoteparent node is only applicable when using an existing stocked parent which has a bill of material and the source of the configuration is sales orders and when using the simple/extended pricing method which is set in sales order setup on the pricing tab within SYSPRO and when the priceflg element is C . The format is a 2 character alphanumeric field.
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
        '''This element indicates the price/list price of the parent. The price in the finishlistpricedetails node is only applicable when creating a stocked parent. 
        '''The price in the finishsalesquoteparent node is only applicable when the source of the configuration is sales orders or quotes When using the price in the finishsalesquoteparent node and you are using an existing stocked parent which has a bill of material and you are using the simple or extended pricing method then the priceflg element must be a P else the finishsalesquoteparent price element will be ignored. When using an existing stocked parent which has a bill of material the finishsalesquoteparent price will default to a calculated price according to pricing options within SYSPRO. 
        '''When creating a new stock/non-stocked code or using an existing stocked parent which does not have a bill of material then the price will default to the accumulated price according to the operations and components selected. The format is 10.5 numeric.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishListPriceDetailsPriceBasis.S)>  _
        Public Property PriceBasis() As PostConfigurationItemFinishListPriceDetailsPriceBasis
            Get
                Return Me.priceBasisField
            End Get
            Set
                Me.priceBasisField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the commission for the parent. This element in the finishlistpricedetails node is only applicable when creating a stocked parent. This element in the finishsalesquoteparent node is only applicable when the source of the configuration is sales orders or quotes. The format is a 2 character alphanumeric field. 
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
    Public Enum PostConfigurationItemFinishListPriceDetailsPriceBasis
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemFinishSalesQuoteNoParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As DiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessField As DiscountPctPlusLess
        
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
        '''This element indicates the description of the library code you are maintaining when in the librarymaintenance node. This element indicate the description of the discount value when in the finishsalesquotenoparent node. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates if the discount value is unit or a total value. Possible value: U (unit) or V (total value). This element is only applicable when the source of the configuration is sales orders or quotes. If no parent is created then this element can only be a V.
        '''</summary>
        Public Property DiscountFlag() As DiscountFlag
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
        
        '''<summary>
        '''This element indicates whether the discount value should be added or subtracted from the parent price/sales order/quote value and is only applicable when using chain discount percentages . Possible values: P (plus) or L (less).
        '''</summary>
        Public Property DiscountPctPlusLess() As DiscountPctPlusLess
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
        
        '''<summary>
        '''This indicates the first discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a 3.2 numeric field. This element is only applicable when the discount plus less flag is not spaces.  
        '''</summary>
        Public Property DiscountPct1() As String
            Get
                Return Me.discountPct1Field
            End Get
            Set
                Me.discountPct1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the second discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a signed 2.2 numeric field. This element is only applicable  when the discount plus less flag is not spaces. 
        '''</summary>
        Public Property DiscountPct2() As String
            Get
                Return Me.discountPct2Field
            End Get
            Set
                Me.discountPct2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the third discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a signed 2.2 numeric field. This element is only applicable when the discount plus less flag is not spaces. 
        '''</summary>
        Public Property DiscountPct3() As String
            Get
                Return Me.discountPct3Field
            End Get
            Set
                Me.discountPct3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates either the total discount value or the unit discount value (depending on the discount flag) that will be added to the parent price/sales order/quote value. This element only applies when the discount flag is either V or U.  The format is a signed 12.2 numeric field. 
        '''</summary>
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemFinishSalesQuoteParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceFlgField As PostConfigurationItemFinishSalesQuoteParentPriceFlg
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceFlgFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As DiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPctPlusLessField As DiscountPctPlusLess
        
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
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitsFlagField As PostConfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
        
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
        '''This element indicates the price/list price of the parent. The price in the finishlistpricedetails node is only applicable when creating a stocked parent. 
        '''The price in the finishsalesquoteparent node is only applicable when the source of the configuration is sales orders or quotes When using the price in the finishsalesquoteparent node and you are using an existing stocked parent which has a bill of material and you are using the simple or extended pricing method then the priceflg element must be a P else the finishsalesquoteparent price element will be ignored. When using an existing stocked parent which has a bill of material the finishsalesquoteparent price will default to a calculated price according to pricing options within SYSPRO. 
        '''When creating a new stock/non-stocked code or using an existing stocked parent which does not have a bill of material then the price will default to the accumulated price according to the operations and components selected. The format is 10.5 numeric.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property PriceFlg() As PostConfigurationItemFinishSalesQuoteParentPriceFlg
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
        
        '''<summary>
        '''This element indicates the price code against the parent price/list price. The price code in the finishlistpricedetails node is only applicable when creating a stocked parent.The price code in the finishsalesquoteparent node is only applicable when using an existing stocked parent which has a bill of material and the source of the configuration is sales orders and when using the simple/extended pricing method which is set in sales order setup on the pricing tab within SYSPRO and when the priceflg element is C . The format is a 2 character alphanumeric field.
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
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
        '''This element indicates the commission for the parent. This element in the finishlistpricedetails node is only applicable when creating a stocked parent. This element in the finishsalesquoteparent node is only applicable when the source of the configuration is sales orders or quotes. The format is a 2 character alphanumeric field. 
        '''</summary>
        Public Property Commission() As String
            Get
                Return Me.commissionField
            End Get
            Set
                Me.commissionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates if the discount value is unit or a total value. Possible value: U (unit) or V (total value). This element is only applicable when the source of the configuration is sales orders or quotes. If no parent is created then this element can only be a V.
        '''</summary>
        Public Property DiscountFlag() As DiscountFlag
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
        
        '''<summary>
        '''This element indicates whether the discount value should be added or subtracted from the parent price/sales order/quote value and is only applicable when using chain discount percentages . Possible values: P (plus) or L (less).
        '''</summary>
        Public Property DiscountPctPlusLess() As DiscountPctPlusLess
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
        
        '''<summary>
        '''This indicates the first discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a 3.2 numeric field. This element is only applicable when the discount plus less flag is not spaces.  
        '''</summary>
        Public Property DiscountPct1() As String
            Get
                Return Me.discountPct1Field
            End Get
            Set
                Me.discountPct1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the second discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a signed 2.2 numeric field. This element is only applicable  when the discount plus less flag is not spaces. 
        '''</summary>
        Public Property DiscountPct2() As String
            Get
                Return Me.discountPct2Field
            End Get
            Set
                Me.discountPct2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the third discount percentage when using chain discount percentages that will be either subtracted or added to the parent price/sales order/quote value depending on the discount percentage plus less flag. The format is a signed 2.2 numeric field. This element is only applicable when the discount plus less flag is not spaces. 
        '''</summary>
        Public Property DiscountPct3() As String
            Get
                Return Me.discountPct3Field
            End Get
            Set
                Me.discountPct3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates either the total discount value or the unit discount value (depending on the discount flag) that will be added to the parent price/sales order/quote value. This element only applies when the discount flag is either V or U.  The format is a signed 12.2 numeric field. 
        '''</summary>
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
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
        
        Public Property SupplementaryUnitsFlag() As PostConfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
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
    Public Enum PostConfigurationItemFinishSalesQuoteParentPriceFlg
        
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
    Public Enum PostConfigurationItemFinishSalesQuoteParentSupplementaryUnitsFlag
        
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
    Partial Public Class PostConfigurationItemFinishJobDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodField As PostConfigurationItemFinishJobDetailsDateCalcMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOvertimePctField As PostConfigurationItemFinishJobDetailsIncludeOvertimePct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setMethodToManualField As PostConfigurationItemFinishJobDetailsSetMethodToManual
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobOptionsField As PostConfigurationItemFinishJobDetailsSubJobOptions
        
        Public Sub New()
            MyBase.New
            Me.includeOvertimePctField = PostConfigurationItemFinishJobDetailsIncludeOvertimePct.N
            Me.setMethodToManualField = PostConfigurationItemFinishJobDetailsSetMethodToManual.N
            If (Me.subJobOptionsField Is Nothing) Then
                Me.subJobOptionsField = New PostConfigurationItemFinishJobDetailsSubJobOptions
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
        
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        Public Property DateCalcMethod() As PostConfigurationItemFinishJobDetailsDateCalcMethod
            Get
                Return Me.dateCalcMethodField
            End Get
            Set
                Me.dateCalcMethodField = value
                Me.DateCalcMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DateCalcMethodSpecified() As Boolean
            Get
                Return Me.dateCalcMethodFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishJobDetailsIncludeOvertimePct.N)>  _
        Public Property IncludeOvertimePct() As PostConfigurationItemFinishJobDetailsIncludeOvertimePct
            Get
                Return Me.includeOvertimePctField
            End Get
            Set
                Me.includeOvertimePctField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishJobDetailsSetMethodToManual.N)>  _
        Public Property SetMethodToManual() As PostConfigurationItemFinishJobDetailsSetMethodToManual
            Get
                Return Me.setMethodToManualField
            End Get
            Set
                Me.setMethodToManualField = value
            End Set
        End Property
        
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
        
        Public Property SubJobOptions() As PostConfigurationItemFinishJobDetailsSubJobOptions
            Get
                Return Me.subJobOptionsField
            End Get
            Set
                Me.subJobOptionsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishJobDetailsDateCalcMethod
        
        '''<remarks/>
        D
        
        '''<remarks/>
        S
        
        '''<remarks/>
        M
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishJobDetailsIncludeOvertimePct
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishJobDetailsSetMethodToManual
        
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
    Partial Public Class PostConfigurationItemFinishJobDetailsSubJobOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobsField As PostConfigurationItemFinishJobDetailsSubJobOptionsCreateSubJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobPrefixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useGlForAllJobsField As PostConfigurationItemFinishJobDetailsSubJobOptionsUseGlForAllJobs
        
        Public Sub New()
            MyBase.New
            Me.createSubJobsField = PostConfigurationItemFinishJobDetailsSubJobOptionsCreateSubJobs.N
            Me.useGlForAllJobsField = PostConfigurationItemFinishJobDetailsSubJobOptionsUseGlForAllJobs.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishJobDetailsSubJobOptionsCreateSubJobs.N)>  _
        Public Property CreateSubJobs() As PostConfigurationItemFinishJobDetailsSubJobOptionsCreateSubJobs
            Get
                Return Me.createSubJobsField
            End Get
            Set
                Me.createSubJobsField = value
            End Set
        End Property
        
        Public Property SubJobPrefix() As String
            Get
                Return Me.subJobPrefixField
            End Get
            Set
                Me.subJobPrefixField = value
            End Set
        End Property
        
        Public Property SubJobSuffix() As String
            Get
                Return Me.subJobSuffixField
            End Get
            Set
                Me.subJobSuffixField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemFinishJobDetailsSubJobOptionsUseGlForAllJobs.N)>  _
        Public Property UseGlForAllJobs() As PostConfigurationItemFinishJobDetailsSubJobOptionsUseGlForAllJobs
            Get
                Return Me.useGlForAllJobsField
            End Get
            Set
                Me.useGlForAllJobsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishJobDetailsSubJobOptionsCreateSubJobs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemFinishJobDetailsSubJobOptionsUseGlForAllJobs
        
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
    Partial Public Class PostConfigurationItemLibraryMaintenance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostConfigurationItemLibraryMaintenanceActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private libraryCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private libraryStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private libraryExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteOriginalLibraryField As PostConfigurationItemLibraryMaintenanceDeleteOriginalLibrary
        
        Public Sub New()
            MyBase.New
            Me.deleteOriginalLibraryField = PostConfigurationItemLibraryMaintenanceDeleteOriginalLibrary.N
        End Sub
        
        Public Property ActionType() As PostConfigurationItemLibraryMaintenanceActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
                Me.ActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ActionTypeSpecified() As Boolean
            Get
                Return Me.actionTypeFieldSpecified
            End Get
        End Property
        
        Public Property LibraryCode() As String
            Get
                Return Me.libraryCodeField
            End Get
            Set
                Me.libraryCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the description of the library code you are maintaining when in the librarymaintenance node. This element indicate the description of the discount value when in the finishsalesquotenoparent node. The format is a 30 character alphanumeric field.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property LibraryStartDate() As String
            Get
                Return Me.libraryStartDateField
            End Get
            Set
                Me.libraryStartDateField = value
            End Set
        End Property
        
        Public Property LibraryExpiryDate() As String
            Get
                Return Me.libraryExpiryDateField
            End Get
            Set
                Me.libraryExpiryDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemLibraryMaintenanceDeleteOriginalLibrary.N)>  _
        Public Property DeleteOriginalLibrary() As PostConfigurationItemLibraryMaintenanceDeleteOriginalLibrary
            Get
                Return Me.deleteOriginalLibraryField
            End Get
            Set
                Me.deleteOriginalLibraryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemLibraryMaintenanceActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemLibraryMaintenanceDeleteOriginalLibrary
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemCreateBomEstJob
        
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
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
