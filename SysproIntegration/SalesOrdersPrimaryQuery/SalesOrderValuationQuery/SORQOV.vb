Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.SalesOrderValuationQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DocumentType
        
        '''<remarks/>
        O
        
        '''<remarks/>
        B
        
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
    Public Enum FixExchangeRate
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
    Partial Public Class FreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscProductClsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nSrvIncTotalField As NSrvIncTotal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nSrvIncTotalFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.nSrvIncTotalField = NSrvIncTotal.N
        End Sub
        
        '''<summary>
        '''This contains the value of the miscellaneous or freight charge. This is a compulsary element and must contain a value greater than zero. The maximum field size is 12.2 and it can have a preceding or following negative sign if the value is negative.
        '''</summary>
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code for the miscellaneous or freight charge. If blank use the tax code against the customer.
        '''</summary>
        Public Property NMscTaxCode() As String
            Get
                Return Me.nMscTaxCodeField
            End Get
            Set
                Me.nMscTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to use for USA FST. If this is in use NMscFstCode must be a valid tax code.
        '''</summary>
        Public Property NMscFstCode() As String
            Get
                Return Me.nMscFstCodeField
            End Get
            Set
                Me.nMscFstCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The product class to use for this miscellaneous or freight charge.
        '''</summary>
        Public Property NMscProductCls() As String
            Get
                Return Me.nMscProductClsField
            End Get
            Set
                Me.nMscProductClsField = value
            End Set
        End Property
        
        '''<summary>
        '''The cost associated with this miscellaneous or freight charge.
        '''</summary>
        Public Property NMscChargeCost() As String
            Get
                Return Me.nMscChargeCostField
            End Get
            Set
                Me.nMscChargeCostField = value
            End Set
        End Property
        
        '''<summary>
        '''Include the value of NMscChargeValue in the tax calculation (N - No, Y - Yes).
        '''</summary>
        Public Property NSrvIncTotal() As NSrvIncTotal
            Get
                Return Me.nSrvIncTotalField
            End Get
            Set
                Me.nSrvIncTotalField = value
                Me.NSrvIncTotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NSrvIncTotalSpecified() As Boolean
            Get
                Return Me.nSrvIncTotalFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum NSrvIncTotal
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
    Public Enum GstDeduction
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum LineType
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MZeroQtyCrNote
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
    Partial Public Class MerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineTypeField As LineType
        
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
        Private mZeroQtyCrNoteField As MZeroQtyCrNote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mZeroQtyCrNoteFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mFstTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mUnitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mProductClassField As String
        
        Public Sub New()
            MyBase.New
            Me.mMulDivPrcFctField = MMulDivPrcFct.M
            Me.mZeroQtyCrNoteField = MZeroQtyCrNote.N
        End Sub
        
        '''<summary>
        '''This element specifies whether MStockCode contains a stock code for an item stocked with SYSPRO or a non-stocked item (1 - Stocked, 7 - Non-Stocked). This is a compulsary element.
        '''</summary>
        Public Property LineType() As LineType
            Get
                Return Me.lineTypeField
            End Get
            Set
                Me.lineTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Depending on whether LineType contains either a 1 or 7, this element will contain a stock code for a stocked or non-stocked item. If this is for a stocked item then this stock code must exist within SYSPRO. This is a compulsary element.
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
        '''This is the original order quantity for this stock code. This is a compulsary field and must contain a value greater than zero. The maximum field size is 7.3 and it can have a leading or following negative sign if required.
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
        '''This contains the quantity that would be shipped in the first shipment from this order. The maximum field size is 7.3 and it can have a leading or following negative sign if required.
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
        '''This is the price to be used for this stock item. This is a compulsary element and the maximum size is 10.5. Please see MOrderQty, MOrderUom, MPriceUom, MConvFactOrdUm and MMulDivPrcFct.
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
        '''This element contains the conversion factor to be used to convert the order quantity unit of measure to the price unit of measure. If the order quantity unit of measure and the price unit of measure are different and this element is not present, the conversion factor will picked up from the stock code in SYSPRO. If there is no entry for this conversion against the stock code, or this is for a non-stocked item, the default will be 1.
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
        '''This is a dicount value. If MDiscValFlag is either V or U, this must contain a value greater than zero.
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
        '''This is the unit mass for this item. If this is not supplied it defaults to the contents of the unit mass field against the stock code in SYSPRO for a stocked item. For a non-stocked items the default is 1.
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
        '''This is the unit volume for this item. If this is not supplied it defaults to the contents of the unit volume field against the stock code in SYSPRO for a stocked item. For a non-stocked items the default is 1.
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
        '''This element is only used if the element DocumentType is C (Credit Note). It specifies whether the credit note is for a zero quantity (ie. stock not to be returned) (blank or N - No, Y - Yes).
        '''</summary>
        Public Property MZeroQtyCrNote() As MZeroQtyCrNote
            Get
                Return Me.mZeroQtyCrNoteField
            End Get
            Set
                Me.mZeroQtyCrNoteField = value
                Me.MZeroQtyCrNoteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MZeroQtyCrNoteSpecified() As Boolean
            Get
                Return Me.mZeroQtyCrNoteFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The tax code to use for the valuation. If this is not supplied the tax code against the customer within SYSPRO will be used.
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
        '''This is the tax code to use for USA FST. If this is in use MFstTaxCode must be a valid tax code.
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
        '''This is ignored for stocked items. For non-stocked items it is the unit cost for this item in the unit of measure specified in MOrderUom. If MUnitCost is not supplied it defaults to 1.
        '''</summary>
        Public Property MUnitCost() As String
            Get
                Return Me.mUnitCostField
            End Get
            Set
                Me.mUnitCostField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only required if LineType is '7', and the option to apply order level discounts has been selected. It must be a valid SYSPRO product class, and will be ingored for the calcualtion if it is not.
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class MiscellaneousLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscProductClsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nSrvIncTotalField As NSrvIncTotal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nSrvIncTotalFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.nSrvIncTotalField = NSrvIncTotal.N
        End Sub
        
        '''<summary>
        '''This contains the value of the miscellaneous or freight charge. This is a compulsary element and must contain a value greater than zero. The maximum field size is 12.2 and it can have a preceding or following negative sign if the value is negative.
        '''</summary>
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code for the miscellaneous or freight charge. If blank use the tax code against the customer.
        '''</summary>
        Public Property NMscTaxCode() As String
            Get
                Return Me.nMscTaxCodeField
            End Get
            Set
                Me.nMscTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the tax code to use for USA FST. If this is in use NMscFstCode must be a valid tax code.
        '''</summary>
        Public Property NMscFstCode() As String
            Get
                Return Me.nMscFstCodeField
            End Get
            Set
                Me.nMscFstCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The product class to use for this miscellaneous or freight charge.
        '''</summary>
        Public Property NMscProductCls() As String
            Get
                Return Me.nMscProductClsField
            End Get
            Set
                Me.nMscProductClsField = value
            End Set
        End Property
        
        '''<summary>
        '''The cost associated with this miscellaneous or freight charge.
        '''</summary>
        Public Property NMscChargeCost() As String
            Get
                Return Me.nMscChargeCostField
            End Get
            Set
                Me.nMscChargeCostField = value
            End Set
        End Property
        
        '''<summary>
        '''Include the value of NMscChargeValue in the tax calculation (N - No, Y - Yes).
        '''</summary>
        Public Property NSrvIncTotal() As NSrvIncTotal
            Get
                Return Me.nSrvIncTotalField
            End Get
            Set
                Me.nSrvIncTotalField = value
                Me.NSrvIncTotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NSrvIncTotalSpecified() As Boolean
            Get
                Return Me.nSrvIncTotalFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MulDiv
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderHeaderField As OrderHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseLineField As List(Of MerchandiseLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscellaneousLineField As List(Of MiscellaneousLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As List(Of FreightLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New List(Of FreightLine)
            End If
            If (Me.miscellaneousLineField Is Nothing) Then
                Me.miscellaneousLineField = New List(Of MiscellaneousLine)
            End If
            If (Me.merchandiseLineField Is Nothing) Then
                Me.merchandiseLineField = New List(Of MerchandiseLine)
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New OrderHeader
            End If
        End Sub

        '''<summary>
        '''The existing sales order number.
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As String)
                Me.salesOrderField = value
            End Set
        End Property

        '''<summary>
        '''This contains the information required for a sales order header (this is compulsary and can only appear once per order).
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
        <System.Xml.Serialization.XmlElementAttribute("MerchandiseLine")>  _
        Public Property MerchandiseLineCollection() As List(Of MerchandiseLine)
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
        <System.Xml.Serialization.XmlElementAttribute("MiscellaneousLine")>  _
        Public Property MiscellaneousLineCollection() As List(Of MiscellaneousLine)
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
        <System.Xml.Serialization.XmlElementAttribute("FreightLine")>  _
        Public Property FreightLineCollection() As List(Of FreightLine)
            Get
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used to display the XML file.
        '''</summary>
        Public Property XslStylesheet() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class OrderHeader

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As DocumentType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixExchangeRateField As FixExchangeRate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixExchangeRateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As MulDiv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extendedTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstDeductionField As GstDeduction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstDeductionFieldSpecified As Boolean
        
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
        Private creditedInvDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditedInvDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscountBreaksField As OrderDiscountBreaks
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscountBreaksFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.documentTypeField = DocumentType.O
            Me.mulDivField = MulDiv.M
            Me.orderDiscountBreaksField = OrderDiscountBreaks.N
        End Sub

        '''<summary>
        '''This contains a valid SYSPRO Accounts Receivable customer account code. This is a compulsary element.
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
        '''This is the type of SYSPRO sales order (O - Order, B - Billing, C - Credit Note, D - Debit Note).
        '''</summary>
        Public Property DocumentType() As DocumentType
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
                Me.DocumentTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DocumentTypeSpecified() As Boolean
            Get
                Return Me.documentTypeFieldSpecified
            End Get
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
        '''Use the contents of ExchangeRate for the currency conversion or use the currency code against the customer code (Y - Use the value of ExchangeRate to calculate the order values, N or blank - Use the currency code against the customer).
        '''</summary>
        Public Property FixExchangeRate() As FixExchangeRate
            Get
                Return Me.fixExchangeRateField
            End Get
            Set
                Me.fixExchangeRateField = value
                Me.FixExchangeRateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FixExchangeRateSpecified() As Boolean
            Get
                Return Me.fixExchangeRateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The exchange rate conversion factor to be used if FixExchangeRate is Y. This value is used to either multiply or divide the costs / prices depending on the contents of MulDiv. If FixExchangeRate is Y this is a compulsary element and must be greater than 0.
        '''</summary>
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''Multiply or divide the costs / prices by the FIxExchangeRate (M - Multiply, D - Divide). If FixExchangeRate is Y then this is a compulsary element.
        '''</summary>
        Public Property MulDiv() As MulDiv
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
                Me.MulDivFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MulDivSpecified() As Boolean
            Get
                Return Me.mulDivFieldSpecified
            End Get
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
        '''The county (USA Advanced Geo codes) or zip code (USA AVP Sales tax) portion of the tax code. The otehr portions are State and ExtendedTaxCode. If all three portions are blank, the tax code from the customer is used.
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
        '''The geographic area. If SYSPRO is configured for tax by area this is a compulsary element. 
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
        '''This specifies whether the Canadian GST is calculated by Invoice or Line (I - Invoice, L - Line). Used for Canada only.
        '''</summary>
        Public Property GstDeduction() As GstDeduction
            Get
                Return Me.gstDeductionField
            End Get
            Set
                Me.gstDeductionField = value
                Me.GstDeductionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GstDeductionSpecified() As Boolean
            Get
                Return Me.gstDeductionFieldSpecified
            End Get
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
        '''If the DocumentType is C this element should contain the date that the original invoice was created. This is so the credit note can be calculated using the tax percentage in effect at that time. Dates are in CCYY-MM-DD format.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property CreditedInvDate() As Date
            Get
                Return Me.creditedInvDateField
            End Get
            Set
                Me.creditedInvDateField = value
                Me.CreditedInvDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CreditedInvDateSpecified() As Boolean
            Get
                Return Me.creditedInvDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element determines if order discount breaks are to be taken into account for the supplied order lines prior to valuing the order. It is only relevant where the customer supplied is subject to order discount breaks.
        '''</summary>
        Public Property OrderDiscountBreaks() As OrderDiscountBreaks
            Get
                Return Me.orderDiscountBreaksField
            End Get
            Set
                Me.orderDiscountBreaksField = value
                Me.OrderDiscountBreaksFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderDiscountBreaksSpecified() As Boolean
            Get
                Return Me.orderDiscountBreaksFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderDiscountBreaks
        
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
        End Sub
        
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                Me._queryActionTypeField = Value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "SORQOV"
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
