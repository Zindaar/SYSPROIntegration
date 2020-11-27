Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.AddDetailLineToExistingCreditNote.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum AllowZeroQty

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Bins

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binPiecesField As String

        '''<summary>
        '''Bin location if multiple bins are in use for the warehouse entered.
        '''</summary>
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = Value
            End Set
        End Property

        '''<summary>
        '''Quantity allocated to bin location entered.
        '''Not required if stock item is a unit-quantity type item.
        '''</summary>
        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = Value
            End Set
        End Property

        '''<summary>
        '''Number of whole units allocated to bin location entered, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = Value
            End Set
        End Property

        '''<summary>
        '''Number of pieces allocated to bin location entered, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property BinPieces() As String
            Get
                Return Me.binPiecesField
            End Get
            Set
                Me.binPiecesField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum DiscValFlag

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        U

        '''<remarks/>
        V
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Item

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private creditNoteNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private creditReasonField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonStockedLineField As NonStockedLine

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private descriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private revisionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private releaseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private customerPartNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderQtyField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private allowZeroQtyField As AllowZeroQty

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private priceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private priceUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private priceCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderPiecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialsField As Serials

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private binsField As Bins

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private productClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private discPercent1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private discPercent2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private discPercent3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private discValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private discValFlagField As DiscValFlag

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private overrideCalculatedDiscountField As OverrideCalculatedDiscount

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private custRequestDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private commissionCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private userDefinedField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitMassField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unitVolumeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockTaxCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockNotTaxableField As StockNotTaxable

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockFstCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stockNotFstTaxableField As StockNotFstTaxable

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nsProductClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nsUnitCostField As String

        Public Sub New()
            MyBase.New
            Me.nonStockedLineField = NonStockedLine.N
            Me.allowZeroQtyField = AllowZeroQty.N
            If (Me.binsField Is Nothing) Then
                Me.binsField = New Bins()
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New Serials()
            End If
        End Sub

        '''<summary>
        '''Valid number of an existing credit note, to which lines are to be added.
        '''Mandatory.
        '''</summary>
        Public Property CreditNoteNumber() As String
            Get
                Return Me.creditNoteNumberField
            End Get
            Set
                Me.creditNoteNumberField = Value
            End Set
        End Property

        '''<summary>
        '''Valid credit note reason code. Optional, unless credit note reason required (Sales Order Setup).
        '''</summary>
        Public Property CreditReason() As String
            Get
                Return Me.creditReasonField
            End Get
            Set
                Me.creditReasonField = Value
            End Set
        End Property

        '''<summary>
        '''Indicates whether new line is a non-stocked line or not.
        '''Optional. Valid values are "N" - Stocked line (default) or 'Y' - Non-stocked line.
        '''</summary>
        Public Property NonStockedLine() As NonStockedLine
            Get
                Return Me.nonStockedLineField
            End Get
            Set
                Me.nonStockedLineField = Value
            End Set
        End Property

        '''<summary>
        '''Valid stocked item code or non-stocked code if non-stocked line.
        '''Mandatory.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = Value
            End Set
        End Property

        '''<summary>
        '''Stock description if not using the standard stock code desription.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = Value
            End Set
        End Property

        '''<summary>
        '''Revision number if ECC stock item.
        '''</summary>
        Public Property Revision() As String
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = Value
            End Set
        End Property

        '''<summary>
        '''Release number if ECC stock item.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = Value
            End Set
        End Property

        '''<summary>
        '''Valid warehouse code where given stock item is stocked or "**" if non-stocked line.
        '''Mandatory.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = Value
            End Set
        End Property

        '''<summary>
        '''Customer part number.
        '''</summary>
        Public Property CustomerPartNumber() As String
            Get
                Return Me.customerPartNumberField
            End Get
            Set
                Me.customerPartNumberField = Value
            End Set
        End Property

        '''<summary>
        '''Quantity required on credit note line.
        '''If stock item is a unit-quantity type, enter quantity in OrderUnits and OrderPieces elements.
        '''</summary>
        Public Property OrderQty() As String
            Get
                Return Me.orderQtyField
            End Get
            Set
                Me.orderQtyField = Value
            End Set
        End Property

        '''<summary>
        '''Order quantity unit of measure.
        '''</summary>
        Public Property OrderUom() As String
            Get
                Return Me.orderUomField
            End Get
            Set
                Me.orderUomField = Value
            End Set
        End Property

        '''<summary>
        '''Zero quantity allowed on credit note line.
        '''Valid values are 'N' - No (default) or 'Y' - Yes.
        '''</summary>
        Public Property AllowZeroQty() As AllowZeroQty
            Get
                Return Me.allowZeroQtyField
            End Get
            Set
                Me.allowZeroQtyField = Value
            End Set
        End Property

        '''<summary>
        '''Price of stock item. Mandatory if manual pricing is used or there is no default price for the stock code entered and no PriceCode is entered.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = Value
            End Set
        End Property

        '''<summary>
        '''Unit of measure for price entered.
        '''</summary>
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = Value
            End Set
        End Property

        '''<summary>
        '''Price code of price to use. 
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = Value
            End Set
        End Property

        '''<summary>
        '''Number of whole units on the credit note line, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property OrderUnits() As String
            Get
                Return Me.orderUnitsField
            End Get
            Set
                Me.orderUnitsField = Value
            End Set
        End Property

        '''<summary>
        '''Number of pieces on the credit note line, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property OrderPieces() As String
            Get
                Return Me.orderPiecesField
            End Get
            Set
                Me.orderPiecesField = Value
            End Set
        End Property

        '''<summary>
        '''This element initiates the data set for the aloocation of serials.
        '''</summary>
        Public Property Serials() As Serials
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = Value
            End Set
        End Property

        '''<summary>
        '''Valid lot number if stock item is lot-traceable.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = Value
            End Set
        End Property

        '''<summary>
        '''This element initiates the data set for the aloocation of bins.
        '''</summary>
        Public Property Bins() As Bins
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = Value
            End Set
        End Property

        '''<summary>
        '''Valid product class.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = Value
            End Set
        End Property

        '''<summary>
        '''Percentage of first level of discount.
        '''</summary>
        Public Property DiscPercent1() As String
            Get
                Return Me.discPercent1Field
            End Get
            Set
                Me.discPercent1Field = Value
            End Set
        End Property

        '''<summary>
        '''Percentage of second level of discount.
        '''</summary>
        Public Property DiscPercent2() As String
            Get
                Return Me.discPercent2Field
            End Get
            Set
                Me.discPercent2Field = Value
            End Set
        End Property

        '''<summary>
        '''Percentage of third level of discount.
        '''</summary>
        Public Property DiscPercent3() As String
            Get
                Return Me.discPercent3Field
            End Get
            Set
                Me.discPercent3Field = Value
            End Set
        End Property

        '''<summary>
        '''Discount value to be applied if DiscValFlag is 'V' or 'U'.
        '''</summary>
        Public Property DiscValue() As String
            Get
                Return Me.discValueField
            End Get
            Set
                Me.discValueField = Value
            End Set
        End Property

        '''<summary>
        '''Flag to indicate if discount is by value or unit. Valid values are ' ' - Spaces (default), 'V' - Value or 'U' - Unit.
        '''If 'V' or 'U', a DiscValue must be supplied.
        '''</summary>
        Public Property DiscValFlag() As DiscValFlag
            Get
                Return Me.discValFlagField
            End Get
            Set
                Me.discValFlagField = Value
            End Set
        End Property

        '''<summary>
        '''Flag to indicate override of discount.
        '''Valid values are ' ' - Spaces, 'Y' - Yes or 'N' - No.
        '''</summary>
        Public Property OverrideCalculatedDiscount() As OverrideCalculatedDiscount
            Get
                Return Me.overrideCalculatedDiscountField
            End Get
            Set
                Me.overrideCalculatedDiscountField = Value
            End Set
        End Property

        '''<summary>
        '''Customer request date. If supplied, must be in the format CCYY-MM-DD.
        '''</summary>
        Public Property CustRequestDate() As String
            Get
                Return Me.custRequestDateField
            End Get
            Set
                Me.custRequestDateField = Value
            End Set
        End Property

        '''<summary>
        '''Valid commission code.
        '''</summary>
        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set
                Me.commissionCodeField = Value
            End Set
        End Property

        '''<summary>
        '''Ship date. If supplied, must be in the format CCYY-MM-DD.
        '''</summary>
        Public Property ShipDate() As String
            Get
                Return Me.shipDateField
            End Get
            Set
                Me.shipDateField = Value
            End Set
        End Property

        '''<summary>
        '''User-defined field.
        '''</summary>
        Public Property UserDefined() As String
            Get
                Return Me.userDefinedField
            End Get
            Set
                Me.userDefinedField = Value
            End Set
        End Property

        '''<summary>
        '''Unit mass.
        '''</summary>
        Public Property UnitMass() As String
            Get
                Return Me.unitMassField
            End Get
            Set
                Me.unitMassField = Value
            End Set
        End Property

        '''<summary>
        '''Unit volume.
        '''</summary>
        Public Property UnitVolume() As String
            Get
                Return Me.unitVolumeField
            End Get
            Set
                Me.unitVolumeField = Value
            End Set
        End Property

        '''<summary>
        '''Tax code, if applicable.
        '''</summary>
        Public Property StockTaxCode() As String
            Get
                Return Me.stockTaxCodeField
            End Get
            Set
                Me.stockTaxCodeField = Value
            End Set
        End Property

        '''<summary>
        '''Flag to indicate if credit note line is or not taxable.
        '''Valid values are 'N' - No or 'Y' - Yes.
        '''</summary>
        Public Property StockNotTaxable() As StockNotTaxable
            Get
                Return Me.stockNotTaxableField
            End Get
            Set
                Me.stockNotTaxableField = Value
            End Set
        End Property

        '''<summary>
        '''Federal sales tax code, if applicable.
        '''</summary>
        Public Property StockFstCode() As String
            Get
                Return Me.stockFstCodeField
            End Get
            Set
                Me.stockFstCodeField = Value
            End Set
        End Property

        '''<summary>
        '''Flag to indicate if credit note line is or not FST taxable.
        '''Valid values are 'N' - No or 'Y' - Yes.
        '''</summary>
        Public Property StockNotFstTaxable() As StockNotFstTaxable
            Get
                Return Me.stockNotFstTaxableField
            End Get
            Set
                Me.stockNotFstTaxableField = Value
            End Set
        End Property

        '''<summary>
        '''Valid product class for non-stocked lines.
        '''</summary>
        Public Property NsProductClass() As String
            Get
                Return Me.nsProductClassField
            End Get
            Set
                Me.nsProductClassField = Value
            End Set
        End Property

        '''<summary>
        '''Non-stocked item unit cost.
        '''</summary>
        Public Property NsUnitCost() As String
            Get
                Return Me.nsUnitCostField
            End Get
            Set
                Me.nsUnitCostField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum NonStockedLine

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Serials

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialPiecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialCreationDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialScrapDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private serialLocationField As String

        '''<summary>
        '''Serial number to allocate quantity entered.
        '''</summary>
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = Value
            End Set
        End Property

        '''<summary>
        '''Serial quantity to allocate to serial number entered.
        '''Not required if stock item is a unit-quantity type item.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = Value
            End Set
        End Property

        '''<summary>
        '''Number of whole units to be allocated to serial number entered, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property SerialUnits() As String
            Get
                Return Me.serialUnitsField
            End Get
            Set
                Me.serialUnitsField = Value
            End Set
        End Property

        '''<summary>
        '''Number of pieces to be allocated to serial number entered, if stock item is a unit-quantity type item.
        '''</summary>
        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = Value
            End Set
        End Property

        '''<summary>
        '''Serial creation date. If supplied, must be in the format CCYY-MM-DD.
        '''</summary>
        Public Property SerialCreationDate() As String
            Get
                Return Me.serialCreationDateField
            End Get
            Set
                Me.serialCreationDateField = Value
            End Set
        End Property

        '''<summary>
        '''Serial expiry date. If supplied, must be in the format CCYY-MM-DD.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = Value
            End Set
        End Property

        '''<summary>
        '''Serial scrap date. If supplied, must be in the format CCYY-MM-DD.
        '''</summary>
        Public Property SerialScrapDate() As String
            Get
                Return Me.serialScrapDateField
            End Get
            Set
                Me.serialScrapDateField = Value
            End Set
        End Property

        '''<summary>
        '''Serial location.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum OverrideCalculatedDiscount

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum StockNotTaxable

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum StockNotFstTaxable

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class SOCreditNoteLine
        Implements ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As List(Of Item)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.Parameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        '''<summary>
        '''This element initiates the data set for a credit note line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTCL"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters()
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.SOCreditNoteLine
                objParams = New Params.SOCreditNoteLine()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
