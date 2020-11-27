Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryQuery.PurchaseOrderValuation.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class FreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargePrintField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeForField As Decimal
        
        '''<summary>
        '''This element contains charges print flag. ( Y - has been printed and N - not yet printed )
        '''</summary>
        Public Property NMscChargePrint() As String
            Get
                Return Me.nMscChargePrintField
            End Get
            Set
                Me.nMscChargePrintField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the Miscellaneous charge value in local currency. The maximum size is 12.2.
        '''</summary>
        Public Property NMscChargeValue() As Decimal
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is other charges amount, miscellaneous or freight, (in foreign currency) to be used for this stock item.The maximum size is 12.2.
        '''</summary>
        Public Property NMscChargeFor() As Decimal
            Get
                Return Me.nMscChargeForField
            End Get
            Set
                Me.nMscChargeForField = value
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
    Partial Public Class MDiscValFlag
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class MerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineTypeField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderQtyField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReceivedQtyField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mConvFactPrcUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMulDivPrcField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct1Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct2Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct3Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValFlagField As MDiscValFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValueField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mNonsUnitMassField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mNonsUnitVolField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mForeignPriceField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCompleteFlagField As String
        
        Public Sub New()
            MyBase.New
            If (Me.mDiscValFlagField Is Nothing) Then
                Me.mDiscValFlagField = New MDiscValFlag
            End If
        End Sub
        
        '''<summary>
        '''This element specifies whether MStockCode contains a stock code for an item stocked with SYSPRO or a non-stocked item (1 - Stocked, 7 - Non-Stocked). This is a mandatory element.
        '''</summary>
        Public Property LineType() As Boolean
            Get
                Return Me.lineTypeField
            End Get
            Set
                Me.lineTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Depending on whether LineType contains either a 1 or 7, this element will contain a stock code for a stocked or non-stocked item. If this is for a stocked item then this stock code must exist within SYSPRO. This is a mandatory element.
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
        '''If LineType is 1 and MWarehouse contains a value, this value will be used as the warehouse to look up costs for the stock code. If this element does not exist the Warehouse to Use against the stock code will be used. This element is ignored if LineType is 7.
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
        '''This is the original purchase order quantity for this stock code. This is a mandatory field and must contain a value greater than zero. The maximum field size is 7.3.
        '''</summary>
        Public Property MOrderQty() As Decimal
            Get
                Return Me.mOrderQtyField
            End Get
            Set
                Me.mOrderQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the quantity that is already received from this order. The maximum field size is 7.3. 
        '''</summary>
        Public Property MReceivedQty() As Decimal
            Get
                Return Me.mReceivedQtyField
            End Get
            Set
                Me.mReceivedQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the unit of measure to be used for MOrderQty. If it is supplied it must be valid within SYSPRO. If this element is not present for a stocked item the stocking unit of measure against the stock code will be used. For a non-stocked item EA will be used.
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
        '''This is the price to be used for this stock item. This is a mandatory element and the maximum size is 10.5. 
        '''</summary>
        Public Property MPrice() As Decimal
            Get
                Return Me.mPriceField
            End Get
            Set
                Me.mPriceField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the unit of measure to be used for MPrice. If it is supplied it must be valid within SYSPRO. If this element is not present for a stocked item the stocking unit of measure against the stock code will be used. For a non-stocked item EA will be used.
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
        '''This element contains the conversion factor to be used to convert the order quantity unit of measure to the price unit of measure. If the order quantity unit of measure and the price unit of measure are different and this element is not present, the conversion factor will be picked up from the stock code in SYSPRO. If there is no entry for this conversion against the stock code, or this is for a non-stocked item, the default will be 1.
        '''</summary>
        Public Property MConvFactPrcUm() As String
            Get
                Return Me.mConvFactPrcUmField
            End Get
            Set
                Me.mConvFactPrcUmField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies whether the contents of MOrderQty should be multiplied or divided by the value in MConvFactOrdUm before multiplying it by the price, to find the total price (M - Multiply, D - Divide). If MConvFactOrdUm contains a value and this element does not, the default is M.
        '''</summary>
        Public Property MMulDivPrc() As String
            Get
                Return Me.mMulDivPrcField
            End Get
            Set
                Me.mMulDivPrcField = value
            End Set
        End Property
        
        '''<summary>
        '''The first discount percentage to be applied to the purchase order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property MDiscPct1() As Decimal
            Get
                Return Me.mDiscPct1Field
            End Get
            Set
                Me.mDiscPct1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The second discount percentage to be applied to the purchase order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value
        '''</summary>
        Public Property MDiscPct2() As Decimal
            Get
                Return Me.mDiscPct2Field
            End Get
            Set
                Me.mDiscPct2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The third discount percentage to be applied to the purchase order. This can be up to 100.00, positive or negative. The negative sign can precede or follow the value. 
        '''</summary>
        Public Property MDiscPct3() As Decimal
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
            End Set
        End Property
        
        '''<summary>
        '''This is a discount value. If MDiscValFlag is either V or U, this must contain a value greater than zero.
        '''</summary>
        Public Property MDiscValue() As Decimal
            Get
                Return Me.mDiscValueField
            End Get
            Set
                Me.mDiscValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit mass for this item. If this is not supplied it defaults to the contents of the unit mass field against the stock code in SYSPRO for a stocked item. For a non-stocked items the default is 1 and the maximum size is 6.6.
        '''</summary>
        Public Property MNonsUnitMass() As Decimal
            Get
                Return Me.mNonsUnitMassField
            End Get
            Set
                Me.mNonsUnitMassField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the unit volume for this item. If this is not supplied it defaults to the contents of the unit volume field against the stock code in SYSPRO for a stocked item. For a non-stocked items the default is 1 and the maximum size is 6.6
        '''</summary>
        Public Property MNonsUnitVol() As Decimal
            Get
                Return Me.mNonsUnitVolField
            End Get
            Set
                Me.mNonsUnitVolField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the foreign price to be used for this stock item. This is a mandatory element for foreign orders and the maximum size is 10.5. 
        '''</summary>
        Public Property MForeignPrice() As Decimal
            Get
                Return Me.mForeignPriceField
            End Get
            Set
                Me.mForeignPriceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies whether PurchaseOrder is complete. (Y - The purchase order is complete,  N or blank the purchase order line is not complete).
        '''</summary>
        Public Property MCompleteFlag() As String
            Get
                Return Me.mCompleteFlagField
            End Get
            Set
                Me.mCompleteFlagField = value
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
    Partial Public Class MiscellaneousLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargePrintField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeForField As Decimal
        
        '''<summary>
        '''This element contains charges print flag. ( Y - has been printed and N - not yet printed )
        '''</summary>
        Public Property NMscChargePrint() As String
            Get
                Return Me.nMscChargePrintField
            End Get
            Set
                Me.nMscChargePrintField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the Miscellaneous charge value in local currency. The maximum size is 12.2.
        '''</summary>
        Public Property NMscChargeValue() As Decimal
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is other charges amount, miscellaneous or freight, (in foreign currency) to be used for this stock item.The maximum size is 12.2.
        '''</summary>
        Public Property NMscChargeFor() As Decimal
            Get
                Return Me.nMscChargeForField
            End Get
            Set
                Me.nMscChargeForField = value
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderHeaderField As OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseLineField As MerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscellaneousLineField As MiscellaneousLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As FreightLine
        
        Public Sub New()
            MyBase.New
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New FreightLine
            End If
            If (Me.miscellaneousLineField Is Nothing) Then
                Me.miscellaneousLineField = New MiscellaneousLine
            End If
            If (Me.merchandiseLineField Is Nothing) Then
                Me.merchandiseLineField = New MerchandiseLine
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New OrderHeader
            End If
        End Sub
        
        '''<summary>
        '''This is the purchase order number to be valued. In this option only the purchase order is passed for valuation, if any other element is in the XML it will be ignored.
        '''</summary>
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the information required for a purchase order header (this is mandatory and can only appear once per purchase order).
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
        '''This element contains elements relating to stocked and non-stocked details. 
        '''</summary>
        Public Property MerchandiseLine() As MerchandiseLine
            Get
                Return Me.merchandiseLineField
            End Get
            Set
                Me.merchandiseLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains elements relating to miscellaneous charge details.
        '''</summary>
        Public Property MiscellaneousLine() As MiscellaneousLine
            Get
                Return Me.miscellaneousLineField
            End Get
            Set
                Me.miscellaneousLineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains elements relating to freight charges.
        '''</summary>
        Public Property FreightLine() As FreightLine
            Get
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
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
    Partial Public Class OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchRateFixedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        '''<summary>
        '''This contains a valid SYSPRO Accounts Payable supplier code. This is a mandatory element.
        '''</summary>
        <CLSCompliant(False)> _
        Public Property Supplier() As SByte
            Get
                Return Me.supplierField
            End Get
            Set(ByVal value As SByte)
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''Use the contents of ExchangeRate for the currency conversion or use the currency code against the customer code (Y - Use the value of ExchangeRate to calculate the order values, N - Use the currency code against the customer).
        '''</summary>
        Public Property ExchRateFixed() As String
            Get
                Return Me.exchRateFixedField
            End Get
            Set
                Me.exchRateFixedField = value
            End Set
        End Property
        
        '''<summary>
        '''The exchange rate conversion factor to be used if ExchRateFix is Y. This value is used to either multiply or divide the costs / prices depending on the contents of MulDiv. If ExchRateFix is Y this is a mandatory element and must be greater than 0.
        '''</summary>
        Public Property ExchangeRate() As Decimal
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''Multiply or divide the costs / prices by the ExchRateFix (M - Multiply, D - Divide). If ExchRateFix is Y then this is a mandatory element.
        '''</summary>
        Public Property MulDiv() As String
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains the purchase order currency. If the purchase order currency is different from the local currency then Foreign currency conversion is needed.
        '''</summary>
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As List(Of [Option])
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New List(Of [Option])
            End If
        End Sub
        
        '''<summary>
        '''There are two types of XMLs used to execute this busines object. In the first option the purchase order number is passed, and all other elements (if they exist) will be ignore. But if the purchase order number is not found then the second option (all the elements except for the purchase order will be validated and used to calculate purchase order values) is applied.   
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Option")>  _
        Public Property OptionCollection() As List(Of [Option])
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used to display the XML file.
        '''</summary>
        Public Property XslStylesheet() As XslStylesheet
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
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
                Return "PORQOV"
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class XslStylesheet
    End Class
End Namespace
