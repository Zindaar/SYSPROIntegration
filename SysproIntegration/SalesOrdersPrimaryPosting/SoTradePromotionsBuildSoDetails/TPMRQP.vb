Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SoTradePromotionsBuildSoDetails.BuildData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GstExemptORide
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MDiscValFlag
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        V
        
        '''<remarks/>
        P
        
        '''<remarks/>
        U
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MMulDivPrcFct
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class MerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mShipQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCustRequestDatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extendedTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mConvFactOrdUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMulDivPrcFctField As MMulDivPrcFct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMulDivPrcFctFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValFlagField As MDiscValFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitVolField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mFstTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mProductClassField As String
        
        Public Sub New()
            MyBase.New
            Me.mMulDivPrcFctField = MMulDivPrcFct.M
        End Sub
        
        '''<summary>
        '''This is a unique line reference (1 to 9999) passed for the parent merchandise line. If the line is resubmitted, the same number must be used. 
        '''</summary>
        Public Property LineReference() As String
            Get
                Return Me.lineReferenceField
            End Get
            Set
                Me.lineReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element will contain a stock code and must exist within SYSPRO. This is a compulsory element.
        '''</summary>
        Public Property MStockCode() As String
            Get
                Return Me.mStockCodeField
            End Get
            Set
                Me.mStockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If supplied, this value will be used as the warehouse to look up costs for the stock code. If this element does not exist the Warehouse to Use against the stock code will be used. 
        '''</summary>
        Public Property MWarehouse() As String
            Get
                Return Me.mWarehouseField
            End Get
            Set
                Me.mWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the original order quantity for this stock code. This is a compulsory field and must contain a value greater than zero. 
        '''</summary>
        Public Property MOrderQty() As String
            Get
                Return Me.mOrderQtyField
            End Get
            Set
                Me.mOrderQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the quantity that would be shipped in the current shipment from this order. 
        '''</summary>
        Public Property MShipQty() As String
            Get
                Return Me.mShipQtyField
            End Get
            Set
                Me.mShipQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the unit of measure to be used for MOrderQty. If it is supplied it must be valid within SYSPRO. If this element is not present for a stocked item the stocking unit of measure against the stock code will be used.
        '''</summary>
        Public Property MOrderUom() As String
            Get
                Return Me.mOrderUomField
            End Get
            Set
                Me.mOrderUomField = value
            End Set
        End Property
        
        '''<summary>
        '''The requested ship date of the line. Only applies to a scheduled order, and if not passed, the order ship date is assumed.
        '''</summary>
        Public Property MCustRequestDat() As String
            Get
                Return Me.mCustRequestDatField
            End Get
            Set
                Me.mCustRequestDatField = value
            End Set
        End Property
        
        '''<summary>
        '''The city portion of the tax code (USA Advanced Geo tax). The other portions are State and CountyZip.  If all three portions are blank, the tax code from the customer is used.
        '''</summary>
        Public Property ExtendedTaxCode() As String
            Get
                Return Me.extendedTaxCodeField
            End Get
            Set
                Me.extendedTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the price to be used for this stock item. This is a compulsory element. Please see MOrderQty, MOrderUom, MPriceUom, MConvFactOrdUm and MMulDivPrcFct.
        '''</summary>
        Public Property MPrice() As String
            Get
                Return Me.mPriceField
            End Get
            Set
                Me.mPriceField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the unit of measure to be used for MPrice. If it is supplied it must be valid within SYSPRO. If this element is not present the stocking unit of measure against the stock code will be used. 
        '''</summary>
        Public Property MPriceUom() As String
            Get
                Return Me.mPriceUomField
            End Get
            Set
                Me.mPriceUomField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the conversion factor to be used to convert the order quantity unit of measure to the price unit of measure. If the order quantity unit of measure and the price unit of measure are different and this element is not present, the conversion factor will picked up from the stock code in SYSPRO. If there is no entry for this conversion against the stock code the default will be 1.
        '''</summary>
        Public Property MConvFactOrdUm() As String
            Get
                Return Me.mConvFactOrdUmField
            End Get
            Set
                Me.mConvFactOrdUmField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies whether the contents of MOrderQty should be multipled or divided by the value in MConvFactOrdUm before multiplying it by the price, to find the total price (M - Multiply, D - Divide). If MConvFactOrdUm contains a value and this element does not, the default is M.
        '''</summary>
        Public Property MMulDivPrcFct() As MMulDivPrcFct
            Get
                Return Me.mMulDivPrcFctField
            End Get
            Set
                Me.mMulDivPrcFctField = value
                Me.MMulDivPrcFctFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MMulDivPrcFctSpecified() As Boolean
            Get
                Return Me.mMulDivPrcFctFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The first line discount percentage to be applied to the sales order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property MDiscPct1() As String
            Get
                Return Me.mDiscPct1Field
            End Get
            Set
                Me.mDiscPct1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The second line discount percentage to be applied to the sales order. This can be up to 99.99, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property MDiscPct2() As String
            Get
                Return Me.mDiscPct2Field
            End Get
            Set
                Me.mDiscPct2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The third line discount percentage to be applied to the sales order. This can be up to 99.99, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property MDiscPct3() As String
            Get
                Return Me.mDiscPct3Field
            End Get
            Set
                Me.mDiscPct3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies how to apply discounts to this detail line. (blank - Use the percentages in MDiscPct1 to 3, V - the value MDiscValue is applied to the value of the line, P - the discount percentages are applied to the unit price before extending it, U - the discount value is applied to the unit price before extending it).
        '''</summary>
        Public Property MDiscValFlag() As MDiscValFlag
            Get
                Return Me.mDiscValFlagField
            End Get
            Set
                Me.mDiscValFlagField = value
                Me.MDiscValFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MDiscValFlagSpecified() As Boolean
            Get
                Return Me.mDiscValFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is a discount value. If MDiscValFlag is either V or U, this must contain a value greater than zero.
        '''</summary>
        Public Property MDiscValue() As String
            Get
                Return Me.mDiscValueField
            End Get
            Set
                Me.mDiscValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit mass for this item. If this is not supplied it defaults to the contents of the unit mass field against the stock code in SYSPRO for a stocked item. 
        '''</summary>
        Public Property MStockUnitMass() As String
            Get
                Return Me.mStockUnitMassField
            End Get
            Set
                Me.mStockUnitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit volume for this item. If this is not supplied it defaults to the contents of the unit volume field against the stock code in SYSPRO for a stocked item. 
        '''</summary>
        Public Property MStockUnitVol() As String
            Get
                Return Me.mStockUnitVolField
            End Get
            Set
                Me.mStockUnitVolField = value
            End Set
        End Property
        
        '''<summary>
        '''The tax code to use for the valuation. If this is not supplied the tax code against the stock item within SYSPRO will be used.
        '''</summary>
        Public Property MTaxCode() As String
            Get
                Return Me.mTaxCodeField
            End Get
            Set
                Me.mTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to use for Canadian FST. If this is in use MFstTaxCode must be a valid tax code. Spaces will imply that the line does not have FST applied
        '''</summary>
        Public Property MFstTaxCode() As String
            Get
                Return Me.mFstTaxCodeField
            End Get
            Set
                Me.mFstTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If supplied it will be used to replace the product class for the stock code supplied for the merchandise line.
        '''</summary>
        Public Property MProductClass() As String
            Get
                Return Me.mProductClassField
            End Get
            Set
                Me.mProductClassField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderHeaderField As OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseLineField As MerchandiseLine
        
        Friend Sub New()
            MyBase.New
            If (Me.merchandiseLineField Is Nothing) Then
                Me.merchandiseLineField = New MerchandiseLine()
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New OrderHeader()
            End If
        End Sub
        
        '''<summary>
        '''This contains the information required for a sales order header which must be passed with each mmerchandise line when the function is 'L', or once for whole order when the function is 'W'.
        '''</summary>
        Public Property OrderHeader() As OrderHeader
            Get
                Return Me.orderHeaderField
            End Get
            Set
                Me.orderHeaderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains elements relating to the parent merchandise line for which promotions are to be derived.
        '''</summary>
        Public Property MerchandiseLine() As MerchandiseLine
            Get
                Return Me.merchandiseLineField
            End Get
            Set
                Me.merchandiseLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private functionField As [Function]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduledOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reqShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extendedTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptORideField As GstExemptORide
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptORideFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptOverrideField As TaxExemptOverride
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptOverrideFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invTermsOverrideField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnTaxInformationField As ReturnTaxInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnTaxInformationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private calloutUsaTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3LocalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipGpsLatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipGpsLongField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiShipCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private temporaryFileReferenceField As String
        
        '''<summary>
        '''Mandatory field determining the process to be carried out
        '''
        ''''I' - Initialize. Always first process for an order, unless the function is 'W' where it is not required. A dummy order reference is returned and must be used for all subsequent calls made when building up the order
        '''
        ''''L' - Line promotions. Order header and Merchandise detials must be supplied, and an updated parent, plus qualified line promotions returned. Global promotions will be updated and saved
        '''
        ''''G' - Global. Only the reference and customer are required. All qualified global promotions will be returned.
        '''
        ''''W' - Whole order. Multiple parent merchandise lines are provided, and the complete order is qualified for trade promotions. Each parent is returned updated if required, with its associated promotions, and global promotions are also returned.  When the function is 'W', no other functions are required to be processed.
        '''
        ''''X' - Exit. All saved information will be cleared. This will also be done in a SYPSRO purge process if the process fails at any point, and exit is not carried out.
        '''</summary>
        Public Property [Function]() As [Function]
            Get
                Return Me.functionField
            End Get
            Set
                Me.functionField = value
            End Set
        End Property
        
        '''<summary>
        '''Blank for function 'I' and 'W', Mandatory for all other functions.
        '''</summary>
        Public Property OrderReference() As String
            Get
                Return Me.orderReferenceField
            End Get
            Set
                Me.orderReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains a valid SYSPRO Accounts Receivable customer account code. The customer must be a Trade Promotions customer. This is a compulsory element when function is 'I' or 'W'.  For other functions it is optional, but if given, must equal the customer passed for function 'I'.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        ''''Y' - the order is scheduled.
        '''</summary>
        Public Property ScheduledOrder() As String
            Get
                Return Me.scheduledOrderField
            End Get
            Set
                Me.scheduledOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''Requested ship date of the order if not the same as the order date.
        '''</summary>
        Public Property ReqShipDate() As String
            Get
                Return Me.reqShipDateField
            End Get
            Set
                Me.reqShipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The order date if not todays date. Any valid date.
        '''</summary>
        Public Property OrderDate() As String
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The first order discount percentage to be applied to the sales order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property DiscPct1() As String
            Get
                Return Me.discPct1Field
            End Get
            Set
                Me.discPct1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The second order discount percentage to be applied to the sales order. This can be up to 99.99, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property DiscPct2() As String
            Get
                Return Me.discPct2Field
            End Get
            Set
                Me.discPct2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The third order discount percentage to be applied to the sales order. This can be up to 99.99, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property DiscPct3() As String
            Get
                Return Me.discPct3Field
            End Get
            Set
                Me.discPct3Field = value
            End Set
        End Property
        
        '''<summary>
        '''The state code portion of the tax code (USA Advanced Geo codes, or USA AVP Sales tax). The other portions are CountyZip and ExtendedTaxCode.  If all three portions are blank, the tax code from the customer is used.
        '''</summary>
        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        '''<summary>
        '''The county (USA Advanced Geo codes) or zip code (USA AVP Sales tax) portion of the tax code. The other portions are State and ExtendedTaxCode. If all three portions are blank, the tax code from the customer is used.
        '''</summary>
        Public Property CountyZip() As String
            Get
                Return Me.countyZipField
            End Get
            Set
                Me.countyZipField = value
            End Set
        End Property
        
        '''<summary>
        '''The city portion of the tax code (USA Advanced Geo tax). The other portions are State and CountyZip.  If all three portions are blank, the tax code from the customer is used.
        '''</summary>
        Public Property ExtendedTaxCode() As String
            Get
                Return Me.extendedTaxCodeField
            End Get
            Set
                Me.extendedTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The geographic area. If SYSPRO is configured for tax by area this is a compulsory element. 
        '''</summary>
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies whether the customer is to be charged GSTor if they are exempt from GST (E - Exempt from GST, N - Non exempt).
        '''</summary>
        Public Property GstExemptORide() As GstExemptORide
            Get
                Return Me.gstExemptORideField
            End Get
            Set
                Me.gstExemptORideField = value
                Me.GstExemptORideFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GstExemptORideSpecified() As Boolean
            Get
                Return Me.gstExemptORideFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether the customer is to be charged tax, they are exempt from tax or the other tax code should be used (E - Exempt from tax, N - Non exempt, O - Use other tax code).
        '''</summary>
        Public Property TaxExemptOverride() As TaxExemptOverride
            Get
                Return Me.taxExemptOverrideField
            End Get
            Set
                Me.taxExemptOverrideField = value
                Me.TaxExemptOverrideFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxExemptOverrideSpecified() As Boolean
            Get
                Return Me.taxExemptOverrideFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If this contains a value then this invoice terms code is used instead of the one against the customer within SYSPRO. 
        '''</summary>
        Public Property InvTermsOverride() As String
            Get
                Return Me.invTermsOverrideField
            End Get
            Set
                Me.invTermsOverrideField = value
            End Set
        End Property
        
        '''<summary>
        '''If this parameter is supplied as 'Y', then tax is calculated on the Trade Promotion  lines where applicable, and the tax rate, and tax amount are returned. Tax is calculated on the value of the lines generated, based on the order quantity for free goods.
        '''</summary>
        Public Property ReturnTaxInformation() As ReturnTaxInformation
            Get
                Return Me.returnTaxInformationField
            End Get
            Set
                Me.returnTaxInformationField = value
                Me.ReturnTaxInformationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReturnTaxInformationSpecified() As Boolean
            Get
                Return Me.returnTaxInformationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element determines if tax is to be calculated by calling the 3rd party USA tax calculation routine. This element is only conisdered if the SYSPRO tax option to use a 3rd party calculation is selected, and the parameter ReturnTaxInformation is 'Y'.
        '''</summary>
        Public Property CalloutUsaTax() As String
            Get
                Return Me.calloutUsaTaxField
            End Get
            Set
                Me.calloutUsaTaxField = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress3Locality() As String
            Get
                Return Me.shipAddress3LocalityField
            End Get
            Set
                Me.shipAddress3LocalityField = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipGpsLat() As String
            Get
                Return Me.shipGpsLatField
            End Get
            Set
                Me.shipGpsLatField = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property ShipGpsLong() As String
            Get
                Return Me.shipGpsLongField
            End Get
            Set
                Me.shipGpsLongField = value
            End Set
        End Property
        
        '''<summary>
        '''The ship address, postal code and multiple ship address elements are only relevant if USA 3rd party tax is in use. If it is, then they are used to determine the address passed. If ShipAddress1 is populated, then the address and postal code elements are used. If blank, then multiple ship address is checked, and if populated, then address from that code is used. If all blank, then the ship address of the customer is used.
        '''</summary>
        Public Property MultiShipCode() As String
            Get
                Return Me.multiShipCodeField
            End Get
            Set
                Me.multiShipCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This information is passed back when function 'I' is carried out. It must be returned in the input XML when processing an 'L' function.
        '''</summary>
        Public Property TemporaryFileReference() As String
            Get
                Return Me.temporaryFileReferenceField
            End Get
            Set
                Me.temporaryFileReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum [Function]
        
        '''<remarks/>
        I
        
        '''<remarks/>
        L
        
        '''<remarks/>
        G
        
        '''<remarks/>
        W
        
        '''<remarks/>
        X
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TaxExemptOverride
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReturnTaxInformation
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Build
        Implements Codewell.SysproIntegration.IBuild

        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IBuild.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IBuild.BusinessObject
            Get
                Return "TPMRQP"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IBuild.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IBuild.Post
            Me._xmlOut = TransactionObject.Build(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
