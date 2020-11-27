Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DefaultOffer
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DiscountFlag
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
        
        '''<remarks/>
        U
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GSTTaxable
        
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
    Public Enum LineAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        I
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Offer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerActionField As OfferOfferAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCalculationMethodField As PriceCalculationMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCalculationMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private profitPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As DiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private clearDiscountsField As OfferClearDiscounts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeToUseField As OfferRouteToUse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeToUseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberField As OfferOfferNumber
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.offerActionField = OfferOfferAction.A
            Me.discountFlagField = DiscountFlag.L
            Me.clearDiscountsField = OfferClearDiscounts.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(OfferOfferAction.A)>  _
        Public Property OfferAction() As OfferOfferAction
            Get
                Return Me.offerActionField
            End Get
            Set
                Me.offerActionField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the quantity of items for the offer. The element is only applicable when offer is for a for non-stocked and stocked quotation line. The format is up to 10 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
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
        
        '''<summary>
        '''This indicates how the price for a non-stocked or stocked item should be calculated on a quotation. Enter Markup to add a markup percentage to the cost of the non-stocked item on the quotation. Enter Margin to add a margin percentage to the selling price of the non-stocked item on the quotation. Enter Fixed if you want to supply a fixed price for offers for the either non-stocked or stocked items. Enter Coded if you want to supply a price code for the offers for the stocked line. Enter Last if you want the last price paid by the customer for this stock code to be used (The option customer/stock code cross reference must be selected against the customer to use this option). The format is 6 characters alphanumeric.
        '''</summary>
        Public Property PriceCalculationMethod() As PriceCalculationMethod
            Get
                Return Me.priceCalculationMethodField
            End Get
            Set
                Me.priceCalculationMethodField = value
                Me.PriceCalculationMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceCalculationMethodSpecified() As Boolean
            Get
                Return Me.priceCalculationMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the default markup/margin profit percentage applicable for non-stocked items on a quotation. The format is up to 5 characters numeric with 3 integers and 2 decimals.
        '''</summary>
        Public Property ProfitPercentage() As String
            Get
                Return Me.profitPercentageField
            End Get
            Set
                Me.profitPercentageField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the code that is used to establish the price (or discount code) applicable to the sale of a specific stock item to the customer, depending on whether the inventory pricing method is coded or discounted. The format is up to 2 characters alphanumeric. Default to the price code on file for the customer when customer code has been supplied
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
        '''This indicates the price for the offer for the non-stocked or stocked items on a quotation if you want to override the automatic price calculation. This element is only applicable if the price calculation method is fixed. For offers for non-stocked quotation lines changes must be allowed at quotation level in the quotation setup within SYSPRO. The format is up to 15 characters numeric with 10 integers and 5 decimals.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the price unit of measure for the offer for the non-stocked or stocked item on a quotation used when you want to override the automatic price calculation. This element is only applicable if the price calculation method is fixed. This element is only applicable for non-stocked items if changes are allowed at quotation level. The format is up to 3 characters alphanumeric. Default to the unit of measure against the non-stocked or stocked code.
        '''</summary>
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the first discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 5 characters numeric with 3 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount1() As String
            Get
                Return Me.lineDiscount1Field
            End Get
            Set
                Me.lineDiscount1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the second discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 4 characters numeric with 2 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount2() As String
            Get
                Return Me.lineDiscount2Field
            End Get
            Set
                Me.lineDiscount2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the third discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 4 characters numeric with 2 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount3() As String
            Get
                Return Me.lineDiscount3Field
            End Get
            Set
                Me.lineDiscount3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates how the offer discount should be applied to the offer line. Discounts can be supplied as either a single value (which will be either a total discount value for the offer or a unit discount value) or up to three chained discount percentages. Possible values: V (Discount value entered for offer line), U (Unit discount value entered for offer line), L (Discount percentages to be subtracted from offer value) or P (Discount percentages to be added to offer value as a surcharge).
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
        '''This indicates either the total discount value or the unit discount value (depending on the discount flag) that will be added to the offer value. The format is up to 14 characters numeric with 12 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is either V or U.
        '''</summary>
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OfferClearDiscounts.N)>  _
        Public Property ClearDiscounts() As OfferClearDiscounts
            Get
                Return Me.clearDiscountsField
            End Get
            Set
                Me.clearDiscountsField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the commission code that must be used to calculate the commission for the offer. The format is up to 2 characters alpha-numeric. This element only applies to offers for non-stocked and stocked quotation lines. 
        '''</summary>
        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set
                Me.commissionCodeField = value
            End Set
        End Property
        
        Public Property RouteToUse() As OfferRouteToUse
            Get
                Return Me.routeToUseField
            End Get
            Set
                Me.routeToUseField = value
                Me.RouteToUseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property RouteToUseSpecified() As Boolean
            Get
                Return Me.routeToUseFieldSpecified
            End Get
        End Property
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
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
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OfferNumber() As OfferOfferNumber
            Get
                Return Me.offerNumberField
            End Get
            Set
                Me.offerNumberField = value
                Me.OfferNumberFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OfferNumberSpecified() As Boolean
            Get
                Return Me.offerNumberFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OfferOfferAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PriceCalculationMethod
        
        '''<remarks/>
        Markup
        
        '''<remarks/>
        Margin
        
        '''<remarks/>
        Fixed
        
        '''<remarks/>
        Coded
        
        '''<remarks/>
        Last
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OfferClearDiscounts
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OfferRouteToUse
        
        '''<remarks/>
        C
        
        '''<remarks/>
        L
        
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
    Public Enum OfferOfferNumber
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostQuotation
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostQuotationItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostQuotationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostQuotationItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostQuotationItem)
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
                Return "QOTTQI"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostQuotationParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostQuotationParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim doc As System.Xml.XmlDocument = Common.SysproUtilities.SerializeToXMLDoc(Me)
                Common.SysproUtilities.SortTheQuoteLinesByQuotationLineNumber(doc)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostQuotation
                objParams = New Params.PostQuotation
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
    Partial Public Class PostQuotationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationHeaderField As PostQuotationItemQuotationHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationDetailsField As PostQuotationItemQuotationDetails
        
        Public Sub New()
            MyBase.New
            If (Me.quotationDetailsField Is Nothing) Then
                Me.quotationDetailsField = New PostQuotationItemQuotationDetails
            End If
            If (Me.quotationHeaderField Is Nothing) Then
                Me.quotationHeaderField = New PostQuotationItemQuotationHeader
            End If
        End Sub
        
        Public Property QuotationHeader() As PostQuotationItemQuotationHeader
            Get
                Return Me.quotationHeaderField
            End Get
            Set
                Me.quotationHeaderField = value
            End Set
        End Property
        
        Public Property QuotationDetails() As PostQuotationItemQuotationDetails
            Get
                Return Me.quotationDetailsField
            End Get
            Set
                Me.quotationDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteStatusField As PostQuotationItemQuotationHeaderQuoteStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusReasonCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyQuoteField As PostQuotationItemQuotationHeaderHierarchyQuote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private probabilityFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateEnquiryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateTenderRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedExchangeRateField As PostQuotationItemQuotationHeaderFixedExchangeRate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyOrderDiscountField As PostQuotationItemQuotationHeaderApplyOrderDiscount
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDiscountCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyLineDiscountField As PostQuotationItemQuotationHeaderApplyLineDiscount
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscountCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractPricingRequiredField As PostQuotationItemQuotationHeaderContractPricingRequired
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transportModeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As PostQuotationItemQuotationHeaderTaxStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptFlagField As PostQuotationItemQuotationHeaderGstExemptFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstRegistrationNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstLevelField As PostQuotationItemQuotationHeaderGstLevel
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryTableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extendedTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentMethodField As PostQuotationItemQuotationHeaderPaymentMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requiredShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstructionsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstructionsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipLineCompleteField As PostQuotationItemQuotationHeaderShipLineComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCalculationMethodField As PriceCalculationMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCalculationMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private profitPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyPercentageToAllLinesField As PostQuotationItemQuotationHeaderApplyPercentageToAllLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerDescription1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerDescription2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerDescription3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerDescription4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerDescription5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferDescriptionField As String
        
        Public Sub New()
            MyBase.New
            Me.quoteStatusField = PostQuotationItemQuotationHeaderQuoteStatus.P
            Me.hierarchyQuoteField = PostQuotationItemQuotationHeaderHierarchyQuote.N
            Me.probabilityFlagField = "9"
            Me.fixedExchangeRateField = PostQuotationItemQuotationHeaderFixedExchangeRate.N
            Me.applyOrderDiscountField = PostQuotationItemQuotationHeaderApplyOrderDiscount.N
            Me.applyLineDiscountField = PostQuotationItemQuotationHeaderApplyLineDiscount.N
            Me.contractPricingRequiredField = PostQuotationItemQuotationHeaderContractPricingRequired.N
            Me.taxStatusField = PostQuotationItemQuotationHeaderTaxStatus.E
            Me.gstExemptFlagField = PostQuotationItemQuotationHeaderGstExemptFlag.E
            Me.gstLevelField = PostQuotationItemQuotationHeaderGstLevel.I
            Me.paymentMethodField = PostQuotationItemQuotationHeaderPaymentMethod.CR
            Me.shipLineCompleteField = PostQuotationItemQuotationHeaderShipLineComplete.N
            Me.applyPercentageToAllLinesField = PostQuotationItemQuotationHeaderApplyPercentageToAllLines.N
        End Sub
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
        
        Public Property QuoteStatus() As PostQuotationItemQuotationHeaderQuoteStatus
            Get
                Return Me.quoteStatusField
            End Get
            Set(ByVal value As PostQuotationItemQuotationHeaderQuoteStatus)
                Me.quoteStatusField = Value
            End Set
        End Property
        
        Public Property StatusReasonCode() As String
            Get
                Return Me.statusReasonCodeField
            End Get
            Set
                Me.statusReasonCodeField = value
            End Set
        End Property
        
        Public Property QuoteDescription() As String
            Get
                Return Me.quoteDescriptionField
            End Get
            Set
                Me.quoteDescriptionField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderHierarchyQuote.N)>  _
        Public Property HierarchyQuote() As PostQuotationItemQuotationHeaderHierarchyQuote
            Get
                Return Me.hierarchyQuoteField
            End Get
            Set
                Me.hierarchyQuoteField = value
            End Set
        End Property
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
            End Set
        End Property
        
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        Public Property Classification() As String
            Get
                Return Me.classificationField
            End Get
            Set
                Me.classificationField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("9")>  _
        Public Property ProbabilityFlag() As String
            Get
                Return Me.probabilityFlagField
            End Get
            Set
                Me.probabilityFlagField = value
            End Set
        End Property
        
        Public Property DateEnquiry() As String
            Get
                Return Me.dateEnquiryField
            End Get
            Set
                Me.dateEnquiryField = value
            End Set
        End Property
        
        Public Property DateTenderRequired() As String
            Get
                Return Me.dateTenderRequiredField
            End Get
            Set
                Me.dateTenderRequiredField = value
            End Set
        End Property
        
        Public Property ExpiryDate() As String
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = value
            End Set
        End Property
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderFixedExchangeRate.N)>  _
        Public Property FixedExchangeRate() As PostQuotationItemQuotationHeaderFixedExchangeRate
            Get
                Return Me.fixedExchangeRateField
            End Get
            Set
                Me.fixedExchangeRateField = value
            End Set
        End Property
        
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        Public Property DocumentFormat() As String
            Get
                Return Me.documentFormatField
            End Get
            Set
                Me.documentFormatField = value
            End Set
        End Property
        
        Public Property InvoiceTerms() As String
            Get
                Return Me.invoiceTermsField
            End Get
            Set
                Me.invoiceTermsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderApplyOrderDiscount.N)>  _
        Public Property ApplyOrderDiscount() As PostQuotationItemQuotationHeaderApplyOrderDiscount
            Get
                Return Me.applyOrderDiscountField
            End Get
            Set
                Me.applyOrderDiscountField = value
            End Set
        End Property
        
        Public Property InvoiceDiscountCode() As String
            Get
                Return Me.invoiceDiscountCodeField
            End Get
            Set
                Me.invoiceDiscountCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderApplyLineDiscount.N)>  _
        Public Property ApplyLineDiscount() As PostQuotationItemQuotationHeaderApplyLineDiscount
            Get
                Return Me.applyLineDiscountField
            End Get
            Set
                Me.applyLineDiscountField = value
            End Set
        End Property
        
        Public Property LineDiscountCode() As String
            Get
                Return Me.lineDiscountCodeField
            End Get
            Set
                Me.lineDiscountCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderContractPricingRequired.N)>  _
        Public Property ContractPricingRequired() As PostQuotationItemQuotationHeaderContractPricingRequired
            Get
                Return Me.contractPricingRequiredField
            End Get
            Set
                Me.contractPricingRequiredField = value
            End Set
        End Property
        
        Public Property BuyingGroup1() As String
            Get
                Return Me.buyingGroup1Field
            End Get
            Set
                Me.buyingGroup1Field = value
            End Set
        End Property
        
        Public Property BuyingGroup2() As String
            Get
                Return Me.buyingGroup2Field
            End Get
            Set
                Me.buyingGroup2Field = value
            End Set
        End Property
        
        Public Property BuyingGroup3() As String
            Get
                Return Me.buyingGroup3Field
            End Get
            Set
                Me.buyingGroup3Field = value
            End Set
        End Property
        
        Public Property BuyingGroup4() As String
            Get
                Return Me.buyingGroup4Field
            End Get
            Set
                Me.buyingGroup4Field = value
            End Set
        End Property
        
        Public Property BuyingGroup5() As String
            Get
                Return Me.buyingGroup5Field
            End Get
            Set
                Me.buyingGroup5Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the code that is used to establish the price (or discount code) applicable to the sale of a specific stock item to the customer, depending on whether the inventory pricing method is coded or discounted. The format is up to 2 characters alphanumeric. Default to the price code on file for the customer when customer code has been supplied
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set
                Me.transactionNatureField = value
            End Set
        End Property
        
        Public Property TransportMode() As String
            Get
                Return Me.transportModeField
            End Get
            Set
                Me.transportModeField = value
            End Set
        End Property
        
        Public Property ProcessFlag() As String
            Get
                Return Me.processFlagField
            End Get
            Set
                Me.processFlagField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderTaxStatus.E)>  _
        Public Property TaxStatus() As PostQuotationItemQuotationHeaderTaxStatus
            Get
                Return Me.taxStatusField
            End Get
            Set
                Me.taxStatusField = value
            End Set
        End Property
        
        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set
                Me.taxExemptNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderGstExemptFlag.E)>  _
        Public Property GstExemptFlag() As PostQuotationItemQuotationHeaderGstExemptFlag
            Get
                Return Me.gstExemptFlagField
            End Get
            Set
                Me.gstExemptFlagField = value
            End Set
        End Property
        
        Public Property GstRegistrationNumber() As String
            Get
                Return Me.gstRegistrationNumberField
            End Get
            Set
                Me.gstRegistrationNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderGstLevel.I)>  _
        Public Property GstLevel() As PostQuotationItemQuotationHeaderGstLevel
            Get
                Return Me.gstLevelField
            End Get
            Set
                Me.gstLevelField = value
            End Set
        End Property
        
        Public Property PriceCategoryTable() As String
            Get
                Return Me.priceCategoryTableField
            End Get
            Set
                Me.priceCategoryTableField = value
            End Set
        End Property
        
        Public Property Contact() As String
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
            End Set
        End Property
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        Public Property ShipToAddress1() As String
            Get
                Return Me.shipToAddress1Field
            End Get
            Set
                Me.shipToAddress1Field = value
            End Set
        End Property
        
        Public Property ShipToAddress2() As String
            Get
                Return Me.shipToAddress2Field
            End Get
            Set
                Me.shipToAddress2Field = value
            End Set
        End Property
        
        Public Property ShipToAddress3() As String
            Get
                Return Me.shipToAddress3Field
            End Get
            Set
                Me.shipToAddress3Field = value
            End Set
        End Property
        
        Public Property ShipToAddress4() As String
            Get
                Return Me.shipToAddress4Field
            End Get
            Set
                Me.shipToAddress4Field = value
            End Set
        End Property
        
        Public Property ShipToAddress5() As String
            Get
                Return Me.shipToAddress5Field
            End Get
            Set
                Me.shipToAddress5Field = value
            End Set
        End Property
        
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        Public Property ExtendedTaxCode() As String
            Get
                Return Me.extendedTaxCodeField
            End Get
            Set
                Me.extendedTaxCodeField = value
            End Set
        End Property
        
        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderPaymentMethod.CR)>  _
        Public Property PaymentMethod() As PostQuotationItemQuotationHeaderPaymentMethod
            Get
                Return Me.paymentMethodField
            End Get
            Set
                Me.paymentMethodField = value
            End Set
        End Property
        
        Public Property RequiredShipDate() As String
            Get
                Return Me.requiredShipDateField
            End Get
            Set
                Me.requiredShipDateField = value
            End Set
        End Property
        
        Public Property SpecialInstructions() As String
            Get
                Return Me.specialInstructionsField
            End Get
            Set
                Me.specialInstructionsField = value
            End Set
        End Property
        
        Public Property AlternateKey() As String
            Get
                Return Me.alternateKeyField
            End Get
            Set
                Me.alternateKeyField = value
            End Set
        End Property
        
        Public Property ShippingInstructions() As String
            Get
                Return Me.shippingInstructionsField
            End Get
            Set
                Me.shippingInstructionsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderShipLineComplete.N)>  _
        Public Property ShipLineComplete() As PostQuotationItemQuotationHeaderShipLineComplete
            Get
                Return Me.shipLineCompleteField
            End Get
            Set
                Me.shipLineCompleteField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates how the price for a non-stocked or stocked item should be calculated on a quotation. Enter Markup to add a markup percentage to the cost of the non-stocked item on the quotation. Enter Margin to add a margin percentage to the selling price of the non-stocked item on the quotation. Enter Fixed if you want to supply a fixed price for offers for the either non-stocked or stocked items. Enter Coded if you want to supply a price code for the offers for the stocked line. Enter Last if you want the last price paid by the customer for this stock code to be used (The option customer/stock code cross reference must be selected against the customer to use this option). The format is 6 characters alphanumeric.
        '''</summary>
        Public Property PriceCalculationMethod() As PriceCalculationMethod
            Get
                Return Me.priceCalculationMethodField
            End Get
            Set
                Me.priceCalculationMethodField = value
                Me.PriceCalculationMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceCalculationMethodSpecified() As Boolean
            Get
                Return Me.priceCalculationMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the default markup/margin profit percentage applicable for non-stocked items on a quotation. The format is up to 5 characters numeric with 3 integers and 2 decimals.
        '''</summary>
        Public Property ProfitPercentage() As String
            Get
                Return Me.profitPercentageField
            End Get
            Set
                Me.profitPercentageField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationHeaderApplyPercentageToAllLines.N)>  _
        Public Property ApplyPercentageToAllLines() As PostQuotationItemQuotationHeaderApplyPercentageToAllLines
            Get
                Return Me.applyPercentageToAllLinesField
            End Get
            Set
                Me.applyPercentageToAllLinesField = value
            End Set
        End Property
        
        Public Property OfferDescription1() As String
            Get
                Return Me.offerDescription1Field
            End Get
            Set
                Me.offerDescription1Field = value
            End Set
        End Property
        
        Public Property OfferDescription2() As String
            Get
                Return Me.offerDescription2Field
            End Get
            Set
                Me.offerDescription2Field = value
            End Set
        End Property
        
        Public Property OfferDescription3() As String
            Get
                Return Me.offerDescription3Field
            End Get
            Set
                Me.offerDescription3Field = value
            End Set
        End Property
        
        Public Property OfferDescription4() As String
            Get
                Return Me.offerDescription4Field
            End Get
            Set
                Me.offerDescription4Field = value
            End Set
        End Property
        
        Public Property OfferDescription5() As String
            Get
                Return Me.offerDescription5Field
            End Get
            Set
                Me.offerDescription5Field = value
            End Set
        End Property
        
        Public Property DefaultOfferDescription() As String
            Get
                Return Me.defaultOfferDescriptionField
            End Get
            Set
                Me.defaultOfferDescriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderQuoteStatus
        
        '''<remarks/>
        P
        
        '''<remarks/>
        A
        
        '''<remarks/>
        H
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderHierarchyQuote
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderFixedExchangeRate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderApplyOrderDiscount
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderApplyLineDiscount
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderContractPricingRequired
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderTaxStatus
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderGstExemptFlag
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderGstLevel
        
        '''<remarks/>
        I
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderPaymentMethod
        
        '''<remarks/>
        CR
        
        '''<remarks/>
        CS
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderShipLineComplete
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationHeaderApplyPercentageToAllLines
        
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
    Partial Public Class PostQuotationItemQuotationDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonstockedLineField As List(Of PostQuotationItemQuotationDetailsNonstockedLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockLineField As List(Of PostQuotationItemQuotationDetailsStockLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeLineField As List(Of PostQuotationItemQuotationDetailsMiscChargeLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As List(Of PostQuotationItemQuotationDetailsFreightLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As List(Of PostQuotationItemQuotationDetailsCommentLine)
        
        Public Sub New()
            MyBase.New
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New List(Of PostQuotationItemQuotationDetailsCommentLine)
            End If
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New List(Of PostQuotationItemQuotationDetailsFreightLine)
            End If
            If (Me.miscChargeLineField Is Nothing) Then
                Me.miscChargeLineField = New List(Of PostQuotationItemQuotationDetailsMiscChargeLine)
            End If
            If (Me.stockLineField Is Nothing) Then
                Me.stockLineField = New List(Of PostQuotationItemQuotationDetailsStockLine)
            End If
            If (Me.nonstockedLineField Is Nothing) Then
                Me.nonstockedLineField = New List(Of PostQuotationItemQuotationDetailsNonstockedLine)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Non-stockedLine")>  _
        Public Property NonstockedLineCollection() As List(Of PostQuotationItemQuotationDetailsNonstockedLine)
            Get
                Return Me.nonstockedLineField
            End Get
            Set
                Me.nonstockedLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("StockLine")>  _
        Public Property StockLineCollection() As List(Of PostQuotationItemQuotationDetailsStockLine)
            Get
                Return Me.stockLineField
            End Get
            Set
                Me.stockLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MiscChargeLine")>  _
        Public Property MiscChargeLineCollection() As List(Of PostQuotationItemQuotationDetailsMiscChargeLine)
            Get
                Return Me.miscChargeLineField
            End Get
            Set
                Me.miscChargeLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("FreightLine")>  _
        Public Property FreightLineCollection() As List(Of PostQuotationItemQuotationDetailsFreightLine)
            Get
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CommentLine")>  _
        Public Property CommentLineCollection() As List(Of PostQuotationItemQuotationDetailsCommentLine)
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsNonstockedLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionField As LineAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableField As Taxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableField As GSTTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private federalSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferField As DefaultOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As List(Of Offer)
        
        Public Sub New()
            MyBase.New
            Me.lineActionField = LineAction.A
            Me.taxableField = Taxable.N
            Me.gSTTaxableField = GSTTaxable.N
            If (Me.offerField Is Nothing) Then
                Me.offerField = New List(Of Offer)
            End If
        End Sub
        
        '''<summary>
        '''This indicates the detail line number for the quotation. This is a mandatory field when changing or deleting the line. When inserting a quotation line this element should contain the line number that you want the new line to be inserted as. The next line number will be generated automatically when adding a new quotation line. The format is up to 4 characters numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which action should be performed for the detail line. The possible actions are: add (A) a new detail line, change (C) the detail line,  delete (D) the detail line or insert (I) a new detail line. Possible values: A (Add), C (Change), D (Delete) or I (Insert). Default to A (add).
        '''</summary>
        Public Property LineAction() As LineAction
            Get
                Return Me.lineActionField
            End Get
            Set
                Me.lineActionField = value
                Me.LineActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionSpecified() As Boolean
            Get
                Return Me.lineActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the non-stocked item or the stock code that you want to use for the offer. The non-stocked and stock code can not be changed once the quotation line has been saved therefore this element will be ignored when changing the line. The format is up to 30 characters alphanumeric or up to 15 characters numeric depending on the key configuration option for stock code within SYSPRO.
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
        '''This indicates the description for the non-stocked item or stock code. The format is up to 30 characters alphanumeric. For stock codes this element is only applicable when the sales order setup option within SYSPRO to allow changes to description for stock items has been selected.
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
        '''This indicates the Product class assigned to the stock code. Product classes are used throughout the system to record statistics and to add processing and reporting flexibility. In addition, product classes can provide the basis for multiple account distributions of sales revenue and cost of sales expenses (General Ledger Integration Setup). The format is up to 4 characters alpha-numeric. Default to the product class saved against the stock code.
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
        '''This indicates if the quotation line you are entering is taxable. If the quotation header has been flagged as exempt from tax this element will be ignored as the line tax status will also be exempt. Possible values: Y (taxable) or N (not taxable). The line tax status will default to the tax status of the sales order header for the quotation.
        '''</summary>
        Public Property Taxable() As Taxable
            Get
                Return Me.taxableField
            End Get
            Set
                Me.taxableField = value
                Me.TaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxableSpecified() As Boolean
            Get
                Return Me.taxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable and the appropriate tax rate. This element is not applicable when the tax system in use is by USA AVP sales tax. This element will only be applicable for all other tax systems if the line is flagged as taxable. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST. If the quotation header has been flagged as exempt from GST, then this element will be ignored as the line will also be exempt. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. Possible values: Y (GST taxable) or N (not GST taxable). The line GST status will default to the GST status of the sales order header for the quotation.
        '''</summary>
        Public Property GSTTaxable() As GSTTaxable
            Get
                Return Me.gSTTaxableField
            End Get
            Set
                Me.gSTTaxableField = value
                Me.GSTTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GSTTaxableSpecified() As Boolean
            Get
                Return Me.gSTTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST and the appropriate GST rate. This element is only relevant when the line is subject to GST. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property FederalSalesTax() As String
            Get
                Return Me.federalSalesTaxField
            End Get
            Set
                Me.federalSalesTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the date on which the items can be shipped to the customer. The ship date can be changed for each line on the quote, depending on the items availability. The ship date will be validate to ensure that it falls on a working day if the parameter validate working days is set to P (default to previous working day) or N(default to next working day). The format is 10 characters numeric and must be in a CCYY-MM-DD format. Default to the ship date supplied for the quotation header.
        '''</summary>
        Public Property LineShipDate() As String
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the offer which will be used as a default for the line. The default offer for each line can be used to automatically create sales orders, jobs, purchase orders or requisitions using the Quotation Confirmation program. If the default offer element contains 0 then no default offer is required. Possible values: 0 to 5
        '''</summary>
        Public Property DefaultOffer() As DefaultOffer
            Get
                Return Me.defaultOfferField
            End Get
            Set
                Me.defaultOfferField = value
                Me.DefaultOfferFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DefaultOfferSpecified() As Boolean
            Get
                Return Me.defaultOfferFieldSpecified
            End Get
        End Property
        
        Public Property HierarchyCode() As String
            Get
                Return Me.hierarchyCodeField
            End Get
            Set
                Me.hierarchyCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the information to maintain an offer for a detail line. You may supply up to five offers for each quotation detail line. The offer number must be defined as an attribute of the offer. Possible offer number values: 1 to 5.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Offer")>  _
        Public Property OfferCollection() As List(Of Offer)
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Taxable
        
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
    Partial Public Class PostQuotationItemQuotationDetailsStockLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionField As LineAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentWhenShippingField As PostQuotationItemQuotationDetailsStockLineCurrentWhenShipping
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableField As Taxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableField As GSTTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private federalSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferField As DefaultOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefinedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printComponentField As PrintComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printComponentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSOrderTextField As PostQuotationItemQuotationDetailsStockLineIncludeSOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDangerousGoodsTextField As PostQuotationItemQuotationDetailsStockLineIncludeDangerousGoodsText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyToOffersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printOnQuoteField As PrintOnQuote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printOnQuoteFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printSalesMethodField As PrintSalesMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printSalesMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As List(Of Offer)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitItemField As List(Of PostQuotationItemQuotationDetailsStockLineKitItem)
        
        Public Sub New()
            MyBase.New
            Me.lineActionField = LineAction.A
            Me.currentWhenShippingField = PostQuotationItemQuotationDetailsStockLineCurrentWhenShipping.N
            Me.taxableField = Taxable.N
            Me.gSTTaxableField = GSTTaxable.N
            Me.printComponentField = PrintComponent.N
            Me.includeSOrderTextField = PostQuotationItemQuotationDetailsStockLineIncludeSOrderText.N
            Me.includeDangerousGoodsTextField = PostQuotationItemQuotationDetailsStockLineIncludeDangerousGoodsText.N
            Me.printOnQuoteField = PrintOnQuote.Y
            Me.printSalesMethodField = PrintSalesMethod.B
            If (Me.kitItemField Is Nothing) Then
                Me.kitItemField = New List(Of PostQuotationItemQuotationDetailsStockLineKitItem)
            End If
            If (Me.offerField Is Nothing) Then
                Me.offerField = New List(Of Offer)
            End If
        End Sub
        
        '''<summary>
        '''This indicates the detail line number for the quotation. This is a mandatory field when changing or deleting the line. When inserting a quotation line this element should contain the line number that you want the new line to be inserted as. The next line number will be generated automatically when adding a new quotation line. The format is up to 4 characters numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which action should be performed for the detail line. The possible actions are: add (A) a new detail line, change (C) the detail line,  delete (D) the detail line or insert (I) a new detail line. Possible values: A (Add), C (Change), D (Delete) or I (Insert). Default to A (add).
        '''</summary>
        Public Property LineAction() As LineAction
            Get
                Return Me.lineActionField
            End Get
            Set
                Me.lineActionField = value
                Me.LineActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionSpecified() As Boolean
            Get
                Return Me.lineActionFieldSpecified
            End Get
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
        '''This indicates the non-stocked item or the stock code that you want to use for the offer. The non-stocked and stock code can not be changed once the quotation line has been saved therefore this element will be ignored when changing the line. The format is up to 30 characters alphanumeric or up to 15 characters numeric depending on the key configuration option for stock code within SYSPRO.
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
        '''This indicates the description for the non-stocked item or stock code. The format is up to 30 characters alphanumeric. For stock codes this element is only applicable when the sales order setup option within SYSPRO to allow changes to description for stock items has been selected.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsStockLineCurrentWhenShipping.N)>  _
        Public Property CurrentWhenShipping() As PostQuotationItemQuotationDetailsStockLineCurrentWhenShipping
            Get
                Return Me.currentWhenShippingField
            End Get
            Set
                Me.currentWhenShippingField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable. If the quotation header has been flagged as exempt from tax this element will be ignored as the line tax status will also be exempt. Possible values: Y (taxable) or N (not taxable). The line tax status will default to the tax status of the sales order header for the quotation.
        '''</summary>
        Public Property Taxable() As Taxable
            Get
                Return Me.taxableField
            End Get
            Set
                Me.taxableField = value
                Me.TaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxableSpecified() As Boolean
            Get
                Return Me.taxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable and the appropriate tax rate. This element is not applicable when the tax system in use is by USA AVP sales tax. This element will only be applicable for all other tax systems if the line is flagged as taxable. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST. If the quotation header has been flagged as exempt from GST, then this element will be ignored as the line will also be exempt. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. Possible values: Y (GST taxable) or N (not GST taxable). The line GST status will default to the GST status of the sales order header for the quotation.
        '''</summary>
        Public Property GSTTaxable() As GSTTaxable
            Get
                Return Me.gSTTaxableField
            End Get
            Set
                Me.gSTTaxableField = value
                Me.GSTTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GSTTaxableSpecified() As Boolean
            Get
                Return Me.gSTTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST and the appropriate GST rate. This element is only relevant when the line is subject to GST. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property FederalSalesTax() As String
            Get
                Return Me.federalSalesTaxField
            End Get
            Set
                Me.federalSalesTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the date on which the items can be shipped to the customer. The ship date can be changed for each line on the quote, depending on the items availability. The ship date will be validate to ensure that it falls on a working day if the parameter validate working days is set to P (default to previous working day) or N(default to next working day). The format is 10 characters numeric and must be in a CCYY-MM-DD format. Default to the ship date supplied for the quotation header.
        '''</summary>
        Public Property LineShipDate() As String
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the offer which will be used as a default for the line. The default offer for each line can be used to automatically create sales orders, jobs, purchase orders or requisitions using the Quotation Confirmation program. If the default offer element contains 0 then no default offer is required. Possible values: 0 to 5
        '''</summary>
        Public Property DefaultOffer() As DefaultOffer
            Get
                Return Me.defaultOfferField
            End Get
            Set
                Me.defaultOfferField = value
                Me.DefaultOfferFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DefaultOfferSpecified() As Boolean
            Get
                Return Me.defaultOfferFieldSpecified
            End Get
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
        
        Public Property UserDefined() As String
            Get
                Return Me.userDefinedField
            End Get
            Set
                Me.userDefinedField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the component should be printed on order documents. Possible values: Y (yes) or N (No).
        '''</summary>
        Public Property PrintComponent() As PrintComponent
            Get
                Return Me.printComponentField
            End Get
            Set
                Me.printComponentField = value
                Me.PrintComponentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintComponentSpecified() As Boolean
            Get
                Return Me.printComponentFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsStockLineIncludeSOrderText.N)>  _
        Public Property IncludeSOrderText() As PostQuotationItemQuotationDetailsStockLineIncludeSOrderText
            Get
                Return Me.includeSOrderTextField
            End Get
            Set
                Me.includeSOrderTextField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsStockLineIncludeDangerousGoodsText.N)>  _
        Public Property IncludeDangerousGoodsText() As PostQuotationItemQuotationDetailsStockLineIncludeDangerousGoodsText
            Get
                Return Me.includeDangerousGoodsTextField
            End Get
            Set
                Me.includeDangerousGoodsTextField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates to which offers the sales order additional text and/or dangerous goods text applies. Offers should be entered separated by commas (e.g. 1,3,4,D). The format is up to 11 characters alphanumeric. Possible values: Offer 1 to 5 and D for default offer.
        '''</summary>
        Public Property ApplyToOffers() As String
            Get
                Return Me.applyToOffersField
            End Get
            Set
                Me.applyToOffersField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the sales order additional text and/or dangerous goods text should be printed on the quote. Possible values: Y (yes, print comment on quote) or N (No, do not print comment on quote). Default to Y (yes)
        '''</summary>
        Public Property PrintOnQuote() As PrintOnQuote
            Get
                Return Me.printOnQuoteField
            End Get
            Set
                Me.printOnQuoteField = value
                Me.PrintOnQuoteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintOnQuoteSpecified() As Boolean
            Get
                Return Me.printOnQuoteFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the sales order additional text and/or dangerous goods text should be printed on the delivery notes and invoices created from this quote. Possible values: N(None text applies to neither delivery note nor invoice i.e. the text will not be copied to the sales order), or D (Delivery note only text will be printed on the delivery note only), or B(Both delivery note and invoice text will be printed on both the delivery note and the invoice). Default to B.
        '''</summary>
        Public Property PrintSalesMethod() As PrintSalesMethod
            Get
                Return Me.printSalesMethodField
            End Get
            Set
                Me.printSalesMethodField = value
                Me.PrintSalesMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintSalesMethodSpecified() As Boolean
            Get
                Return Me.printSalesMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the information to maintain an offer for a detail line. You may supply up to five offers for each quotation detail line. The offer number must be defined as an attribute of the offer. Possible offer number values: 1 to 5.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Offer")>  _
        Public Property OfferCollection() As List(Of Offer)
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("KitItem")>  _
        Public Property KitItemCollection() As List(Of PostQuotationItemQuotationDetailsStockLineKitItem)
            Get
                Return Me.kitItemField
            End Get
            Set
                Me.kitItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsStockLineCurrentWhenShipping
        
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
    Public Enum PrintComponent
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsStockLineIncludeSOrderText
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsStockLineIncludeDangerousGoodsText
        
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
    Public Enum PrintOnQuote
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PrintSalesMethod
        
        '''<remarks/>
        B
        
        '''<remarks/>
        D
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsStockLineKitItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printComponentField As PrintComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printComponentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitOfferField As List(Of PostQuotationItemQuotationDetailsStockLineKitItemKitOffer)
        
        Public Sub New()
            MyBase.New
            Me.printComponentField = PrintComponent.N
            If (Me.kitOfferField Is Nothing) Then
                Me.kitOfferField = New List(Of PostQuotationItemQuotationDetailsStockLineKitItemKitOffer)
            End If
        End Sub
        
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the Product class assigned to the stock code. Product classes are used throughout the system to record statistics and to add processing and reporting flexibility. In addition, product classes can provide the basis for multiple account distributions of sales revenue and cost of sales expenses (General Ledger Integration Setup). The format is up to 4 characters alpha-numeric. Default to the product class saved against the stock code.
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
        '''This indicates if the component should be printed on order documents. Possible values: Y (yes) or N (No).
        '''</summary>
        Public Property PrintComponent() As PrintComponent
            Get
                Return Me.printComponentField
            End Get
            Set
                Me.printComponentField = value
                Me.PrintComponentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintComponentSpecified() As Boolean
            Get
                Return Me.printComponentFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the date on which the items can be shipped to the customer. The ship date can be changed for each line on the quote, depending on the items availability. The ship date will be validate to ensure that it falls on a working day if the parameter validate working days is set to P (default to previous working day) or N(default to next working day). The format is 10 characters numeric and must be in a CCYY-MM-DD format. Default to the ship date supplied for the quotation header.
        '''</summary>
        Public Property LineShipDate() As String
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("KitOffer")>  _
        Public Property KitOfferCollection() As List(Of PostQuotationItemQuotationDetailsStockLineKitItemKitOffer)
            Get
                Return Me.kitOfferField
            End Get
            Set
                Me.kitOfferField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsStockLineKitItemKitOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As PostQuotationItemQuotationDetailsStockLineKitItemKitOfferPriceMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscount3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagField As DiscountFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commissionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberField As PostQuotationItemQuotationDetailsStockLineKitItemKitOfferOfferNumber
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.priceMethodField = PostQuotationItemQuotationDetailsStockLineKitItemKitOfferPriceMethod.C
            Me.discountFlagField = DiscountFlag.L
        End Sub
        
        '''<summary>
        '''This indicates the quantity of items for the offer. The element is only applicable when offer is for a for non-stocked and stocked quotation line. The format is up to 10 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsStockLineKitItemKitOfferPriceMethod.C)>  _
        Public Property PriceMethod() As PostQuotationItemQuotationDetailsStockLineKitItemKitOfferPriceMethod
            Get
                Return Me.priceMethodField
            End Get
            Set
                Me.priceMethodField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the code that is used to establish the price (or discount code) applicable to the sale of a specific stock item to the customer, depending on whether the inventory pricing method is coded or discounted. The format is up to 2 characters alphanumeric. Default to the price code on file for the customer when customer code has been supplied
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
        '''This indicates the price for the offer for the non-stocked or stocked items on a quotation if you want to override the automatic price calculation. This element is only applicable if the price calculation method is fixed. For offers for non-stocked quotation lines changes must be allowed at quotation level in the quotation setup within SYSPRO. The format is up to 15 characters numeric with 10 integers and 5 decimals.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the price unit of measure for the offer for the non-stocked or stocked item on a quotation used when you want to override the automatic price calculation. This element is only applicable if the price calculation method is fixed. This element is only applicable for non-stocked items if changes are allowed at quotation level. The format is up to 3 characters alphanumeric. Default to the unit of measure against the non-stocked or stocked code.
        '''</summary>
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the first discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 5 characters numeric with 3 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount1() As String
            Get
                Return Me.lineDiscount1Field
            End Get
            Set
                Me.lineDiscount1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the second discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 4 characters numeric with 2 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount2() As String
            Get
                Return Me.lineDiscount2Field
            End Get
            Set
                Me.lineDiscount2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the third discount value when using chain discount percentages that will be either subtracted or added to the offer value depending on the discount flag. The format is up to 4 characters numeric with 2 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is L or P.
        '''</summary>
        Public Property LineDiscount3() As String
            Get
                Return Me.lineDiscount3Field
            End Get
            Set
                Me.lineDiscount3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates how the offer discount should be applied to the offer line. Discounts can be supplied as either a single value (which will be either a total discount value for the offer or a unit discount value) or up to three chained discount percentages. Possible values: V (Discount value entered for offer line), U (Unit discount value entered for offer line), L (Discount percentages to be subtracted from offer value) or P (Discount percentages to be added to offer value as a surcharge).
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
        '''This indicates either the total discount value or the unit discount value (depending on the discount flag) that will be added to the offer value. The format is up to 14 characters numeric with 12 integers and 2 decimals. This element only applies to offers for non-stocked and stocked quotation lines and when the discount flag is either V or U.
        '''</summary>
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the commission code that must be used to calculate the commission for the offer. The format is up to 2 characters alpha-numeric. This element only applies to offers for non-stocked and stocked quotation lines. 
        '''</summary>
        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set
                Me.commissionCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OfferNumber() As PostQuotationItemQuotationDetailsStockLineKitItemKitOfferOfferNumber
            Get
                Return Me.offerNumberField
            End Get
            Set
                Me.offerNumberField = value
                Me.OfferNumberFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OfferNumberSpecified() As Boolean
            Get
                Return Me.offerNumberFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsStockLineKitItemKitOfferPriceMethod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsStockLineKitItemKitOfferOfferNumber
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsMiscChargeLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionField As LineAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableField As Taxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableField As GSTTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private federalSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferField As DefaultOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As List(Of Offer)
        
        Public Sub New()
            MyBase.New
            Me.lineActionField = LineAction.A
            Me.taxableField = Taxable.N
            Me.gSTTaxableField = GSTTaxable.N
            If (Me.offerField Is Nothing) Then
                Me.offerField = New List(Of Offer)
            End If
        End Sub
        
        '''<summary>
        '''This indicates the detail line number for the quotation. This is a mandatory field when changing or deleting the line. When inserting a quotation line this element should contain the line number that you want the new line to be inserted as. The next line number will be generated automatically when adding a new quotation line. The format is up to 4 characters numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which action should be performed for the detail line. The possible actions are: add (A) a new detail line, change (C) the detail line,  delete (D) the detail line or insert (I) a new detail line. Possible values: A (Add), C (Change), D (Delete) or I (Insert). Default to A (add).
        '''</summary>
        Public Property LineAction() As LineAction
            Get
                Return Me.lineActionField
            End Get
            Set
                Me.lineActionField = value
                Me.LineActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionSpecified() As Boolean
            Get
                Return Me.lineActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the description for the non-stocked item or stock code. The format is up to 30 characters alphanumeric. For stock codes this element is only applicable when the sales order setup option within SYSPRO to allow changes to description for stock items has been selected.
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
        '''This indicates the Product class assigned to the stock code. Product classes are used throughout the system to record statistics and to add processing and reporting flexibility. In addition, product classes can provide the basis for multiple account distributions of sales revenue and cost of sales expenses (General Ledger Integration Setup). The format is up to 4 characters alpha-numeric. Default to the product class saved against the stock code.
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
        '''This indicates if the quotation line you are entering is taxable. If the quotation header has been flagged as exempt from tax this element will be ignored as the line tax status will also be exempt. Possible values: Y (taxable) or N (not taxable). The line tax status will default to the tax status of the sales order header for the quotation.
        '''</summary>
        Public Property Taxable() As Taxable
            Get
                Return Me.taxableField
            End Get
            Set
                Me.taxableField = value
                Me.TaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxableSpecified() As Boolean
            Get
                Return Me.taxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable and the appropriate tax rate. This element is not applicable when the tax system in use is by USA AVP sales tax. This element will only be applicable for all other tax systems if the line is flagged as taxable. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST. If the quotation header has been flagged as exempt from GST, then this element will be ignored as the line will also be exempt. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. Possible values: Y (GST taxable) or N (not GST taxable). The line GST status will default to the GST status of the sales order header for the quotation.
        '''</summary>
        Public Property GSTTaxable() As GSTTaxable
            Get
                Return Me.gSTTaxableField
            End Get
            Set
                Me.gSTTaxableField = value
                Me.GSTTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GSTTaxableSpecified() As Boolean
            Get
                Return Me.gSTTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST and the appropriate GST rate. This element is only relevant when the line is subject to GST. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property FederalSalesTax() As String
            Get
                Return Me.federalSalesTaxField
            End Get
            Set
                Me.federalSalesTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the offer which will be used as a default for the line. The default offer for each line can be used to automatically create sales orders, jobs, purchase orders or requisitions using the Quotation Confirmation program. If the default offer element contains 0 then no default offer is required. Possible values: 0 to 5
        '''</summary>
        Public Property DefaultOffer() As DefaultOffer
            Get
                Return Me.defaultOfferField
            End Get
            Set
                Me.defaultOfferField = value
                Me.DefaultOfferFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DefaultOfferSpecified() As Boolean
            Get
                Return Me.defaultOfferFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the information to maintain an offer for a detail line. You may supply up to five offers for each quotation detail line. The offer number must be defined as an attribute of the offer. Possible offer number values: 1 to 5.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Offer")>  _
        Public Property OfferCollection() As List(Of Offer)
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsFreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionField As LineAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableField As Taxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableField As GSTTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gSTTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private federalSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferField As DefaultOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOfferFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As List(Of Offer)
        
        Public Sub New()
            MyBase.New
            Me.lineActionField = LineAction.A
            Me.taxableField = Taxable.N
            Me.gSTTaxableField = GSTTaxable.N
            If (Me.offerField Is Nothing) Then
                Me.offerField = New List(Of Offer)
            End If
        End Sub
        
        '''<summary>
        '''This indicates the detail line number for the quotation. This is a mandatory field when changing or deleting the line. When inserting a quotation line this element should contain the line number that you want the new line to be inserted as. The next line number will be generated automatically when adding a new quotation line. The format is up to 4 characters numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which action should be performed for the detail line. The possible actions are: add (A) a new detail line, change (C) the detail line,  delete (D) the detail line or insert (I) a new detail line. Possible values: A (Add), C (Change), D (Delete) or I (Insert). Default to A (add).
        '''</summary>
        Public Property LineAction() As LineAction
            Get
                Return Me.lineActionField
            End Get
            Set
                Me.lineActionField = value
                Me.LineActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionSpecified() As Boolean
            Get
                Return Me.lineActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable. If the quotation header has been flagged as exempt from tax this element will be ignored as the line tax status will also be exempt. Possible values: Y (taxable) or N (not taxable). The line tax status will default to the tax status of the sales order header for the quotation.
        '''</summary>
        Public Property Taxable() As Taxable
            Get
                Return Me.taxableField
            End Get
            Set
                Me.taxableField = value
                Me.TaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxableSpecified() As Boolean
            Get
                Return Me.taxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is taxable and the appropriate tax rate. This element is not applicable when the tax system in use is by USA AVP sales tax. This element will only be applicable for all other tax systems if the line is flagged as taxable. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST. If the quotation header has been flagged as exempt from GST, then this element will be ignored as the line will also be exempt. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. Possible values: Y (GST taxable) or N (not GST taxable). The line GST status will default to the GST status of the sales order header for the quotation.
        '''</summary>
        Public Property GSTTaxable() As GSTTaxable
            Get
                Return Me.gSTTaxableField
            End Get
            Set
                Me.gSTTaxableField = value
                Me.GSTTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GSTTaxableSpecified() As Boolean
            Get
                Return Me.gSTTaxableFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the quotation line you are entering is subject to GST and the appropriate GST rate. This element is only relevant when the line is subject to GST. This element is only relevant when your system nationality is set to CAN (Canadian) and the Canadian GST system is in use. The format is up to 1 character alphanumeric.
        '''</summary>
        Public Property FederalSalesTax() As String
            Get
                Return Me.federalSalesTaxField
            End Get
            Set
                Me.federalSalesTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the offer which will be used as a default for the line. The default offer for each line can be used to automatically create sales orders, jobs, purchase orders or requisitions using the Quotation Confirmation program. If the default offer element contains 0 then no default offer is required. Possible values: 0 to 5
        '''</summary>
        Public Property DefaultOffer() As DefaultOffer
            Get
                Return Me.defaultOfferField
            End Get
            Set
                Me.defaultOfferField = value
                Me.DefaultOfferFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DefaultOfferSpecified() As Boolean
            Get
                Return Me.defaultOfferFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the information to maintain an offer for a detail line. You may supply up to five offers for each quotation detail line. The offer number must be defined as an attribute of the offer. Possible offer number values: 1 to 5.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Offer")>  _
        Public Property OfferCollection() As List(Of Offer)
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostQuotationItemQuotationDetailsCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionField As LineAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private standardCommentCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedToQuoteLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printOnQuoteField As PrintOnQuote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printOnQuoteFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printSalesMethodField As PrintSalesMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printSalesMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyToOffersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteAttachedCommentLinesField As PostQuotationItemQuotationDetailsCommentLineDeleteAttachedCommentLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updateEntireCommentField As PostQuotationItemQuotationDetailsCommentLineUpdateEntireComment
        
        Public Sub New()
            MyBase.New
            Me.lineActionField = LineAction.A
            Me.printOnQuoteField = PrintOnQuote.Y
            Me.printSalesMethodField = PrintSalesMethod.B
            Me.deleteAttachedCommentLinesField = PostQuotationItemQuotationDetailsCommentLineDeleteAttachedCommentLines.N
            Me.updateEntireCommentField = PostQuotationItemQuotationDetailsCommentLineUpdateEntireComment.Y
        End Sub
        
        '''<summary>
        '''This indicates the detail line number for the quotation. This is a mandatory field when changing or deleting the line. When inserting a quotation line this element should contain the line number that you want the new line to be inserted as. The next line number will be generated automatically when adding a new quotation line. The format is up to 4 characters numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which action should be performed for the detail line. The possible actions are: add (A) a new detail line, change (C) the detail line,  delete (D) the detail line or insert (I) a new detail line. Possible values: A (Add), C (Change), D (Delete) or I (Insert). Default to A (add).
        '''</summary>
        Public Property LineAction() As LineAction
            Get
                Return Me.lineActionField
            End Get
            Set
                Me.lineActionField = value
                Me.LineActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LineActionSpecified() As Boolean
            Get
                Return Me.lineActionFieldSpecified
            End Get
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property StandardCommentCode() As String
            Get
                Return Me.standardCommentCodeField
            End Get
            Set
                Me.standardCommentCodeField = value
            End Set
        End Property
        
        Public Property AttachedToQuoteLine() As String
            Get
                Return Me.attachedToQuoteLineField
            End Get
            Set
                Me.attachedToQuoteLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates if the sales order additional text and/or dangerous goods text should be printed on the quote. Possible values: Y (yes, print comment on quote) or N (No, do not print comment on quote). Default to Y (yes)
        '''</summary>
        Public Property PrintOnQuote() As PrintOnQuote
            Get
                Return Me.printOnQuoteField
            End Get
            Set
                Me.printOnQuoteField = value
                Me.PrintOnQuoteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintOnQuoteSpecified() As Boolean
            Get
                Return Me.printOnQuoteFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates if the sales order additional text and/or dangerous goods text should be printed on the delivery notes and invoices created from this quote. Possible values: N(None text applies to neither delivery note nor invoice i.e. the text will not be copied to the sales order), or D (Delivery note only text will be printed on the delivery note only), or B(Both delivery note and invoice text will be printed on both the delivery note and the invoice). Default to B.
        '''</summary>
        Public Property PrintSalesMethod() As PrintSalesMethod
            Get
                Return Me.printSalesMethodField
            End Get
            Set
                Me.printSalesMethodField = value
                Me.PrintSalesMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrintSalesMethodSpecified() As Boolean
            Get
                Return Me.printSalesMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates to which offers the sales order additional text and/or dangerous goods text applies. Offers should be entered separated by commas (e.g. 1,3,4,D). The format is up to 11 characters alphanumeric. Possible values: Offer 1 to 5 and D for default offer.
        '''</summary>
        Public Property ApplyToOffers() As String
            Get
                Return Me.applyToOffersField
            End Get
            Set
                Me.applyToOffersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsCommentLineDeleteAttachedCommentLines.N)>  _
        Public Property DeleteAttachedCommentLines() As PostQuotationItemQuotationDetailsCommentLineDeleteAttachedCommentLines
            Get
                Return Me.deleteAttachedCommentLinesField
            End Get
            Set
                Me.deleteAttachedCommentLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationItemQuotationDetailsCommentLineUpdateEntireComment.Y)>  _
        Public Property UpdateEntireComment() As PostQuotationItemQuotationDetailsCommentLineUpdateEntireComment
            Get
                Return Me.updateEntireCommentField
            End Get
            Set
                Me.updateEntireCommentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsCommentLineDeleteAttachedCommentLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationItemQuotationDetailsCommentLineUpdateEntireComment
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
