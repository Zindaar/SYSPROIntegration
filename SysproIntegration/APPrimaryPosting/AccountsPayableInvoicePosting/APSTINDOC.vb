Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace APPrimaryPosting.AccountsPayableInvoicePosting.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum DiscountBasis

        '''<remarks/>
        T

        '''<remarks/>
        P

        '''<remarks/>
        V
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class Item

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private eSignatureField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private supplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionCodeField As TransactionCode

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private branchField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private freightChargeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private miscellaneousChargeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private notationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalNotationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountBasisField As DiscountBasis

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountBasisFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountableValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountPercentageValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountAdjustmentField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dueDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private discountDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchRateAtEntryField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixedExchRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxBasisField As TaxBasis

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private calculateQstOnTaxField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxCodeField As TaxCode

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private secondTaxCodeField As SecondTaxCode

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private secondTaxValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ecAcquisitionField As EcAcquisition

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ecAcquisitionFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nationalityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisEntryField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisLineEntryField As ItemAnalysisLineEntry

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnDetailsField As List(Of GrnDetails)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerDistributionField As List(Of LedgerDistribution)

        Public Sub New()
            MyBase.New()
            Me.transactionCodeField = TransactionCode.I
            Me.discountBasisField = DiscountBasis.T
            Me.taxBasisField = TaxBasis.E
            Me.ecAcquisitionField = EcAcquisition.Y
            If (Me.ledgerDistributionField Is Nothing) Then
                Me.ledgerDistributionField = New List(Of LedgerDistribution)()
            End If
            If (Me.grnDetailsField Is Nothing) Then
                Me.grnDetailsField = New List(Of GrnDetails)()
            End If
            If (Me.analysisLineEntryField Is Nothing) Then
                Me.analysisLineEntryField = New ItemAnalysisLineEntry()
            End If
        End Sub

        '''<summary>
        '''Optional element that is only relevant if 'TransactionCode' element has a value of 'I'(invoice).If this element is not supplied or if spaces are specified against this element, then the branch against the SYSPRO supplier will be used, otherwise the branch supplied against this element will be used. The branch must be a valid SYSPRO branch.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set(value As String)
                Me.eSignatureField = value
            End Set
        End Property

        '''<summary>
        '''Mandatory element. Enter the SYSPRO supplier applicable to the transaction. This must be a valid SYSPRO supplier.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set(value As String)
                Me.supplierField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. Indicates whether the transaction we are posting is an invoice,adjustment,debit note or credit note.Valid options are 'I' (invoice), 'A'(adjustment),'C'(credit note), 'D'(debit note). The default is 'I'.
        '''</summary>
        Public Property TransactionCode() As TransactionCode
            Get
                Return Me.transactionCodeField
            End Get
            Set(value As TransactionCode)
                Me.transactionCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element that is only relevant if 'TransactionCode' element has a value of 'I'(invoice).If this element is not supplied or if spaces are specified against this element, then the branch against the SYSPRO supplier will be used, otherwise the branch supplied against this element will be used. The branch must be a valid SYSPRO branch.
        '''</summary>
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set(value As String)
                Me.branchField = value
            End Set
        End Property

        '''<summary>
        '''Mandatory element. The invoice must not exist on the SYSPRO Accounts Payable invoice file or on the SYSPRO Accounts Payable Registered invoice file if the 'TransactionCode' element has a value of 'I'(invoice). If the 'TransactionCode' element has a value of 'A'(adjustment), 'C'(credit note) or 'D'(debit note), then the invoice must exist on the SYSPRO Accounts Payable invoice file.
        '''</summary>
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set(value As String)
                Me.invoiceField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This is the value of the transaction inclusive of tax.
        '''</summary>
        Public Property TransactionValue() As String
            Get
                Return Me.transactionValueField
            End Get
            Set(value As String)
                Me.transactionValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. The freight charge is used to calculate the 'Invoice merchandise value'. The 'Invoice merchandise value' is used in GRN matching. The ledger code to which the freight charge is to be distributed must be supplied in the XMLIN under the LedgerDistribution elements.
        '''</summary>
        Public Property FreightCharge() As String
            Get
                Return Me.freightChargeField
            End Get
            Set(value As String)
                Me.freightChargeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. The miscellaneous charge is used to calculate the 'Invoice merchandise value'. The 'Invoice merchandise value' is used in GRN matching. The ledger code to which the miscellaneous charge is to be distributed must be supplied in the XMLIN under the LedgerDistribution elements.
        '''</summary>
        Public Property MiscellaneousCharge() As String
            Get
                Return Me.miscellaneousChargeField
            End Get
            Set(value As String)
                Me.miscellaneousChargeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if the SYSPRO A/P setup has the option 'Ask notation per detail distribution' set on. 
        '''</summary>
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set(value As String)
                Me.notationField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. Transaction reference.
        '''</summary>
        Public Property TransactionReference() As String
            Get
                Return Me.transactionReferenceField
            End Get
            Set(value As String)
                Me.transactionReferenceField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. Journal notation.
        '''</summary>
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set(value As String)
                Me.journalNotationField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if the 'TransactionCode' element has a value of 'I'(invoice).This element specifies how the value of the discount is to be calculated. (T - discount calculated according to the terms code captured against the SYSPRO supplier, P - discount calculated according to the percentage specified against the 'DiscountPercentageValue' element, V - discount value is specified in the 'DiscountPercentageValue' element). The default is 'T'. 
        '''</summary>
        Public Property DiscountBasis() As DiscountBasis
            Get
                Return Me.discountBasisField
            End Get
            Set(value As DiscountBasis)
                Me.discountBasisField = value
                Me.DiscountBasisFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property DiscountBasisSpecified() As Boolean
            Get
                Return Me.discountBasisFieldSpecified
            End Get
        End Property

        '''<summary>
        '''Optional element. Only relevant if the 'TransactionCode' element has a value of 'I'(invoice).If  'T'(invoice terms) or 'P' (percentage) has been specified against 'DiscountBasis' element, then this element specifies how much of the total invoice value is subject to discount. The default is zero.
        '''</summary>
        Public Property DiscountableValue() As String
            Get
                Return Me.discountableValueField
            End Get
            Set(value As String)
                Me.discountableValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if 'TransactionCode' element has a value of 'I'(invoice). If 'P' (percentage) has been specified against the 'DiscountBasis' element, then this element specifies the percentage to be applied to the 'DiscountableValue' in order to calculate the value of discount.  The maximum size of the data is 2 integers and 2 decimals.
        '''If 'V' (value) has been specified against the 'DiscountBasis' element, then this is the value of the discount. The maximum size of the data is 12 integers and 2 decimals.
        '''</summary>
        Public Property DiscountPercentageValue() As String
            Get
                Return Me.discountPercentageValueField
            End Get
            Set(value As String)
                Me.discountPercentageValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. It is only relevant if the 'TransactionCode' element has a value of 'A' (adjustment), or 'C' (credit note) or 'D' (debit note). This is the value by which the discount value of the original invoice must be adjusted.
        '''</summary>
        Public Property DiscountAdjustment() As String
            Get
                Return Me.discountAdjustmentField
            End Get
            Set(value As String)
                Me.discountAdjustmentField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. If this element is not supplied or if zeroes are entered against this element, the current system date will be used as the default.
        '''</summary>
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set(value As String)
                Me.invoiceDateField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This is the date by which the supplier should be paid. If this element is not supplied or if zeroes are entered against this element, the due date will be calculated according to the invoice terms against the SYSPRO supplier. 
        '''</summary>
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set(value As String)
                Me.dueDateField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if the 'TransactionCode' element has a value of 'I'(invoice). In order to qualify for the invoice discount, payment must be made to the supplier on or before the discount date. If this element is not supplied or if zeroes are entered against this element, the discount date will be calculated according to the invoice terms against the SYSPRO supplier. 
        '''</summary>
        Public Property DiscountDate() As String
            Get
                Return Me.discountDateField
            End Get
            Set(value As String)
                Me.discountDateField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. Only relevant if the 'TransactionCode' element has a value of 'I'. If the SYSPRO supplier is a local currency supplier the value of this element is ignored and an exchange rate of 1 is always used. For foreign currency SYSPRO suppliers, the following rules apply:
        '''If this element is not supplied or a value of zero is supplied, the exchange rate against the SYSPRO currency code is used as the default.
        ''' 
        '''If this element is supplied and the SYSPRO currency code is setup with a non-fixed exchange rate, then the value against the element is used. 
        '''If this element is supplied and the SYSPRO currency code is setup with a fixed exchange rate, then the value against the element must match the exchange rate setup against the SYSPRO currency code. 
        '''</summary>
        Public Property ExchRateAtEntry() As String
            Get
                Return Me.exchRateAtEntryField
            End Get
            Set(value As String)
                Me.exchRateAtEntryField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. Only relevant if the 'TransactionCode' element has a value of 'I'. If the SYSPRO supplier is a local currency supplier the value of this element is ignored.  It is mainly used to ignore invoices for revaluation. Valid values 'Y' and 'N'
        '''</summary>
        Public Property FixedExchRate() As String
            Get
                Return Me.fixedExchRateField
            End Get
            Set(value As String)
                Me.fixedExchRateField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element indicates whether the tax is exclusive or inclusive. Valid options are 'E'(exclusive) or 'I'(inclusive). The default is 'E'.
        '''If EC Vat is installed and the transaction supplied is an EC Acquisition, the value of this field is an 'E', irrespective of the value supplied.
        '''</summary>
        Public Property TaxBasis() As TaxBasis
            Get
                Return Me.taxBasisField
            End Get
            Set(value As TaxBasis)
                Me.taxBasisField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. It is only relevant if the AP Setup indicates the 2nd tier tax is required. This element indicates how the value of 2nd tier tax is to be calculated. Valid values are 'Y' (yes) or 'N' (no). If the element is not supplied or if spaces are supplied, the default is derived from the AP Setup option 'Second tier tax calculated on tax'.
        '''</summary>
        Public Property CalculateQstOnTax() As String
            Get
                Return Me.calculateQstOnTaxField
            End Get
            Set(value As String)
                Me.calculateQstOnTaxField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if SYSPRO A/P setup Tax distribution method is ‘D’ or ‘S’ or G/L setup indicates that a Global tax file is required.  Valid values are A-Z or spaces.
        '''If the element value is spaces,  then the tax code is not validated.In all  other cases the tax code must be a valid SYSPRO tax code.
        ''' If the 'AutomaticTaxCalculation' element has a value of 'Y' and the 'TaxValue' element is not supplied or has a value of spaces, then the value against the 'TaxCode' element is used to determine the tax rate to use to automatically calculate the value of tax of the transaction.
        '''If this element is not supplied the default that is used depends on the SYSPRO A/P setup options:
        '''EC Vat not required - defaults to A/P Tax code defined in SYSPRO A/P Setup
        '''
        '''EC Vat required and default to supplier tax is set to 'N' - 
        '''1) Non EC Vat supplier defaults to A/P Tax code defined in SYSPRO A/P Setup
        '''2) EC Vat supplier and non acquisition defaults to A/P Tax code defined in SYSPRO A/P Setup.
        '''3) EC Vat supplier and acquisition always uses default A/P Tax code defined in SYSPRO A/P Setup irresepective of what is supplied in the element.
        '''
        '''EC Vat supplier and default to supplier tax code is set to 'Y' -
        '''1) Non EC Vat supplier defaults to default A/P Tax code defined in SYSPRO A/P setup.
        '''2)EC Vat supplier non acquisition defaults to EC Vat code defined against the supplier.
        '''3)EC Vat supplier and acquisition always uses the EC Vat code defined against the supplier irrespective of the value supplied against the element. 
        '''</summary>
        Public Property TaxCode() As TaxCode
            Get
                Return Me.taxCodeField
            End Get
            Set(value As TaxCode)
                Me.taxCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if SYSPRO A/P setup Tax distribution method is ‘D’ or ‘S’ or G/L setup indicates that a Global tax file is required. This element contains the value of the tax of the transaction. If this element is not supplied or a value of spaces is supplied, AND the 'AutomaticTaxCalculation' element has a value of 'Y', then the business object will automatically calculate tax based on the SYSPRO tax rate held against the tax code supplied in the 'TaxCode' element. If the 'AutomaticTaxCalculation' element has a value of 'N' then the default value of 'TaxValue' is zero.
        '''
        '''</summary>
        Public Property TaxValue() As String
            Get
                Return Me.taxValueField
            End Get
            Set(value As String)
                Me.taxValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if SYSPRO A/P setup Tax distribution method is ‘D’ or ‘S’ or G/L setup indicates that a Global tax file is required and 2nd tier tax is required.  Valid values are A-Z or spaces.
        '''If the element value is spaces,  then the tax code is not validated.In all  other cases the tax code must be a valid SYSPRO tax code.
        ''' If the 'AutomaticTaxCalculation' element has a value of 'Y' and the 'TaxValue' element is not supplied or has a value of spaces, then the value against the 'SecondTaxCode' element is used to determine the tax rate to use to automatically calculate the value of tax of the transaction.
        '''2n Tier tax is not relevant for foreign currency suppliers or EC Vat acquisitions.If this element is not supplied the default that is used depends on the SYSPRO A/P setup options:
        '''EC Vat not required - defaults to A/P Tax code defined in SYSPRO A/P Setup
        '''
        '''EC Vat required and default to supplier tax is set to 'N' - 
        '''1) Non EC Vat supplier defaults to A/P Tax code defined in SYSPRO A/P Setup
        '''2) EC Vat supplier and non acquisition defaults to A/P Tax code defined in SYSPRO A/P Setup.
        '''
        '''EC Vat supplier and default to supplier tax code is set to 'Y' -
        '''1) Non EC Vat supplier defaults to default A/P Tax code defined in SYSPRO A/P setup.
        '''2)EC Vat supplier non acquisition defaults to EC Vat code defined against the supplier.
        '''
        '''</summary>
        Public Property SecondTaxCode() As SecondTaxCode
            Get
                Return Me.secondTaxCodeField
            End Get
            Set(value As SecondTaxCode)
                Me.secondTaxCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This element is only relevant if SYSPRO A/P setup Tax distribution method is ‘D’ or ‘S’ and '2nd tier tax' is required. This element contains the value of the 2nd tier tax of the transaction. If this element is not supplied or a value of spaces is supplied, AND the 'AutomaticTaxCalculation' element has a value of 'Y', then the business object will automatically calculate tax based on the SYSPRO tax rate held against the tax code supplied in the 'SecondTaxCode' element. If the 'AutomaticTaxCalculation' element has a value of 'N' then the default value of 'SecondTaxValue' is zero.
        '''
        '''</summary>
        Public Property SecondTaxValue() As String
            Get
                Return Me.secondTaxValueField
            End Get
            Set(value As String)
                Me.secondTaxValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if EC VAT system is required as per the SYSPRO Tax Options program. Valid options are 'Y' - yes and 'N'-no. If 'Y' is supplied then the invoice relates to an acquisition from an EC supplier (as defined by the EC regulations). 
        '''
        '''</summary>
        Public Property EcAcquisition() As EcAcquisition
            Get
                Return Me.ecAcquisitionField
            End Get
            Set(value As EcAcquisition)
                Me.ecAcquisitionField = value
                Me.EcAcquisitionFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property EcAcquisitionSpecified() As Boolean
            Get
                Return Me.ecAcquisitionFieldSpecified
            End Get
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if EC VAT system is required as per the SYSPRO Tax Options program. If this element is not supplied or if blanks are supplied, the element value defaults to the nationality code of the supplier. This must be a valid SYSPRO nationality code.
        '''</summary>
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set(value As String)
                Me.nationalityField = value
            End Set
        End Property

        Public Property AnalysisEntry() As String
            Get
                Return Me.analysisEntryField
            End Get
            Set(value As String)
                Me.analysisEntryField = value
            End Set
        End Property

        Public Property AnalysisLineEntry() As ItemAnalysisLineEntry
            Get
                Return Me.analysisLineEntryField
            End Get
            Set(value As ItemAnalysisLineEntry)
                Me.analysisLineEntryField = value
            End Set
        End Property

        '''<summary>
        '''Optional or mandatory element. This is the top element for all data supplied for matching GRN lines. This element can occur multiple times within the 'Item' element. Each occurrence represents all the data applicable to match a GRN line against the SYSPRO AP invoice. If the SYSPRO Operator activity 'AP Untick GRN matching required' is unticked, then this element is mandatory.                 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("GrnDetails")> _
        Public Property GrnDetailsCollection() As List(Of GrnDetails)
            Get
                Return Me.grnDetailsField
            End Get
            Set(value As List(Of GrnDetails))
                Me.grnDetailsField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This is the top element for all data supplied for the distribution of the transaction value to the relevant General Ledger accounts. This element can occur multiple times within the 'Item' element. Each occurrence represents all the data applicable to post a value to a SYSPRO General Ledger account.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("LedgerDistribution")> _
        Public Property LedgerDistributionCollection() As List(Of LedgerDistribution)
            Get
                Return Me.ledgerDistributionField
            End Get
            Set(value As List(Of LedgerDistribution))
                Me.ledgerDistributionField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum TransactionCode

        '''<remarks/>
        A

        '''<remarks/>
        I

        '''<remarks/>
        D

        '''<remarks/>
        C

        '''<remarks/>
        P

        '''<remarks/>
        V
        
        '''<remarks/>
        E
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum TaxBasis

        '''<remarks/>
        E

        '''<remarks/>
        I
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum TaxCode

        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        A

        '''<remarks/>
        B

        '''<remarks/>
        C

        '''<remarks/>
        D

        '''<remarks/>
        E

        '''<remarks/>
        F

        '''<remarks/>
        G

        '''<remarks/>
        H

        '''<remarks/>
        I

        '''<remarks/>
        J

        '''<remarks/>
        K

        '''<remarks/>
        L

        '''<remarks/>
        M

        '''<remarks/>
        N

        '''<remarks/>
        O

        '''<remarks/>
        P

        '''<remarks/>
        Q

        '''<remarks/>
        R

        '''<remarks/>
        S

        '''<remarks/>
        T

        '''<remarks/>
        U

        '''<remarks/>
        V

        '''<remarks/>
        W

        '''<remarks/>
        X

        '''<remarks/>
        Y

        '''<remarks/>
        Z
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum SecondTaxCode

        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        A

        '''<remarks/>
        B

        '''<remarks/>
        C

        '''<remarks/>
        D

        '''<remarks/>
        E

        '''<remarks/>
        F

        '''<remarks/>
        G

        '''<remarks/>
        H

        '''<remarks/>
        I

        '''<remarks/>
        J

        '''<remarks/>
        K

        '''<remarks/>
        L

        '''<remarks/>
        M

        '''<remarks/>
        N

        '''<remarks/>
        O

        '''<remarks/>
        P

        '''<remarks/>
        Q

        '''<remarks/>
        R

        '''<remarks/>
        S

        '''<remarks/>
        T

        '''<remarks/>
        U

        '''<remarks/>
        V

        '''<remarks/>
        W

        '''<remarks/>
        X

        '''<remarks/>
        Y

        '''<remarks/>
        Z
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum EcAcquisition

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class ItemAnalysisLineEntry

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private endDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private entryAmountField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private commentField As String

        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set(value As String)
                Me.analysisCode1Field = value
            End Set
        End Property

        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set(value As String)
                Me.analysisCode2Field = value
            End Set
        End Property

        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set(value As String)
                Me.analysisCode3Field = value
            End Set
        End Property

        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set(value As String)
                Me.analysisCode4Field = value
            End Set
        End Property

        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set(value As String)
                Me.analysisCode5Field = value
            End Set
        End Property

        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set(value As String)
                Me.startDateField = value
            End Set
        End Property

        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set(value As String)
                Me.endDateField = value
            End Set
        End Property

        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set(value As String)
                Me.entryAmountField = value
            End Set
        End Property

        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set(value As String)
                Me.commentField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class GrnDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnDetailKeyField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnMatchTypeField As GrnMatchType

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnMatchTypeFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnMatchValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnPartialMatchQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private grnPartialMatchValueField As String

        '''<summary>
        '''Optional element. This is the key to the SYSPRO GRN detail record that you wish to select for GRN matching.
        '''</summary>
        Public Property GrnDetailKey() As String
            Get
                Return Me.grnDetailKeyField
            End Get
            Set(value As String)
                Me.grnDetailKeyField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element describes the type of Grn matching that is to be performed. Valid values are P, U, or O. 
        '''P - partial matching. The quantitiy to match must be supplied in the element 'PartialMatchQuantity' and the value to match in the element 'PartialMatchValue'.
        '''U - the GRN will be updated to be fully matched. The value to match must be supplied in the element 'GrnMatchValue'.
        '''O - the GRN will be updated to be fully matched.  The current outstanding unmatched value  is calculated and will be used as the value to match.
        '''</summary>
        Public Property GrnMatchType() As GrnMatchType
            Get
                Return Me.grnMatchTypeField
            End Get
            Set(value As GrnMatchType)
                Me.grnMatchTypeField = value
                Me.GrnMatchTypeFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property GrnMatchTypeSpecified() As Boolean
            Get
                Return Me.grnMatchTypeFieldSpecified
            End Get
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if the value of the 'GrnMatchType' element is 'U'. This is the value to match for GRN matching.
        '''</summary>
        Public Property GrnMatchValue() As String
            Get
                Return Me.grnMatchValueField
            End Get
            Set(value As String)
                Me.grnMatchValueField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if the value of the 'GrnMatchType' element is 'P'. This is the partial quantity to match for GRN matching.
        '''</summary>
        Public Property GrnPartialMatchQuantity() As String
            Get
                Return Me.grnPartialMatchQuantityField
            End Get
            Set(value As String)
                Me.grnPartialMatchQuantityField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if the value of the 'GrnMatchType' element is 'P'. This is the partial value to match for GRN matching.
        '''</summary>
        Public Property GrnPartialMatchValue() As String
            Get
                Return Me.grnPartialMatchValueField
            End Get
            Set(value As String)
                Me.grnPartialMatchValueField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum GrnMatchType

        '''<remarks/>
        P

        '''<remarks/>
        U

        '''<remarks/>
        O
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class LedgerDistribution

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private passwordForLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerTaxCodeField As LedgerTaxCode

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerSecondTaxCodeField As LedgerSecondTaxCode

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerNotationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisEntryField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisLineEntryField As LedgerDistributionAnalysisLineEntry

        '''<summary>
        '''Optional element. This is the SYSPRO ledger code to which the value of the 'LedgerValue' element is to be posted. If  SYSPRO G/L integration  for Accounts Payable is detail or summary, then the ledger code must be a valid SYSPRO ledger code.
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set(value As String)
                Me.ledgerCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This field defines the password associated with the ledger code supplied in the 'LedgerCode' element. This must be valid if the ledger code has a password defined against it in SYSPRO.
        '''</summary>
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set(value As String)
                Me.passwordForLedgerCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.Only relevant if SYSPRO A/P setup options indicate that the tax distribution method is detail or global tax is required. It must be a valid SYSPRO tax code.The SYSPRO tax rate defined against the 'LedgerTaxCode' is used to calculate the value of the tax for the G/L distribution entry. If this element is not supplied then the default depends on the SYSPRO Setup options:
        '''EC Vat not required, A/P not integrated to G/L -  defaults to value supplied against 'TaxCode' element. If this is spaces, then defaults to  A/P Tax code in SYSPRO A/P Setup.
        '''
        '''EC Vat not required , A/P integrated to G/L - defaults to tax code defined against the G/L code.If this is spaces, then defaults to value supplied in 'TaxCode' element. If this is spaces, then defaults to  A/P Tax code in SYSPRO A/P setup.
        '''
        '''EC Vat required, A/P not integrated to G/L and default to supplier tax is set to 'N' -
        '''1) Non EC VAT supplier or EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to A/P Tax code in SYSPRO A/P Setup.
        '''2)EC Vat supplier and acquisition always uses A/P Tax code in SYSPRO A/P Setup irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''EC Vat required, A/P integrated to G/L, and default to supplier tax is set to 'N' -
        '''1)Non EC Vat supplier or EC Vat supplier non acquisition defaults to tax code defined against the G/L code. If this is spaces the defaults to the value supplied against the 'TaxCode' element. If this is spaces then defaults to A/P Tax Code in SYSPRO A/P Setup.
        '''2) EC Vat supplier and acquisition always uses the A/P Tax Code defined in SYSPRO A/P Setup.   
        '''
        '''EC Vat required, A/P not integrated to G/L, default to supplier tax code is set to 'Y'-
        '''1) Non EC Vat supplier or EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to A/P Tax Code in SYSPRO A/P Setup.
        '''2) EC Vat supplier and acquisition always uses the EC Vat code defined against the supplier irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''EC Vat required, A/P integrated to G/L, default to supplier tax code is set to 'Y'-
        '''1)Non EC Vat supplier defaults to tax code defined against G/L code. If this is spaces then defaults to value provided in 'TaxCode' element. If this is spaces then defaults to A/P Tax Code in SYSPRO A/P Setup.
        '''2)EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to A/P Tax Code in SYSPRO A/P Setup.
        '''3) EC Vat supplier and acquisition always uses the EC Vat code defined against the supplier irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''</summary>
        Public Property LedgerTaxCode() As LedgerTaxCode
            Get
                Return Me.ledgerTaxCodeField
            End Get
            Set(value As LedgerTaxCode)
                Me.ledgerTaxCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element.This is the  tax code that is used to calculate the value of 2nd tier tax of the G/L distribution entry.Only relevant if SYSPRO A/P setup options indicate that 2nd tier tax is required and the tax distribution method is detail or summary or if the SYSPRO G/L setup options indicate that the global tax file is required. 2nd tier tax is not applicable to foreign currency suppliers or to EC acquisitions.It must be a valid SYSPRO tax code. If this element is not supplied, then the default that is used depends on your SYSPRO setup options.
        '''EC Vat not required, A/P not integrated to G/L -  defaults to value supplied against 'TaxCode' element. If this is spaces, then defaults to 2nd tier  A/P Tax code in SYSPRO A/P Setup.
        '''
        '''EC Vat not required , A/P integrated to G/L - defaults to 2nd tier tax code defined against the G/L code.If this is spaces, then defaults to value supplied in 'TaxCode' element. If this is spaces, then defaults to  A/P Tax code in SYSPRO A/P setup.
        '''
        '''EC Vat required, A/P not integrated to G/L and default to supplier tax is set to 'N' -
        '''1) Non EC VAT supplier or EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to 2nd tier  A/P Tax code in SYSPRO A/P Setup.
        '''2)EC Vat supplier and acquisition always uses 2nd tier A/P Tax code in SYSPRO A/P Setup irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''EC Vat required, A/P integrated to G/L, and default to supplier tax is set to 'N' -
        '''1)Non EC Vat supplier or EC Vat supplier non acquisition defaults to tax code defined against the G/L code. If this is spaces the defaults to the value supplied against the 'TaxCode' element. If this is spaces then defaults to 2nd tier A/P Tax Code in SYSPRO A/P Setup.
        '''2) EC Vat supplier and acquisition always uses the A/P Tax Code defined in SYSPRO A/P Setup.   
        '''
        '''EC Vat required, A/P not integrated to G/L, default to supplier tax code is set to 'Y'-
        '''1) Non EC Vat supplier or EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to 2nd tier A/P Tax Code in SYSPRO A/P Setup.
        '''2) EC Vat supplier and acquisition always uses the EC Vat code defined against the supplier irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''EC Vat required, A/P integrated to G/L, default to supplier tax code is set to 'Y'-
        '''1)Non EC Vat supplier defaults to tax code defined against G/L code. If this is spaces then defaults to value provided in 'TaxCode' element. If this is spaces then defaults to 2nd tier A/P Tax Code in SYSPRO A/P Setup.
        '''2)EC Vat supplier non acquisition defaults to value supplied in 'TaxCode' element. If this is spaces then defaults to 2nd tier A/P Tax Code in SYSPRO A/P Setup.
        '''3) EC Vat supplier and acquisition always uses the EC Vat code defined against the supplier irrespective of the value supplied in the 'LedgerTaxCode' element.
        '''
        '''</summary>
        Public Property LedgerSecondTaxCode() As LedgerSecondTaxCode
            Get
                Return Me.ledgerSecondTaxCodeField
            End Get
            Set(value As LedgerSecondTaxCode)
                Me.ledgerSecondTaxCodeField = value
            End Set
        End Property

        '''<summary>
        '''Optional element. This element is only relevant if the SYSPRO A/P setup has the option 'Ask notation per detail distribution' set on. 
        '''</summary>
        Public Property LedgerNotation() As String
            Get
                Return Me.ledgerNotationField
            End Get
            Set(value As String)
                Me.ledgerNotationField = value
            End Set
        End Property

        '''<summary>
        '''Optional element: This is the value to be allocated to the ledger code supplied in the 'LedgerCode' element.
        '''</summary>
        Public Property LedgerValue() As String
            Get
                Return Me.ledgerValueField
            End Get
            Set(value As String)
                Me.ledgerValueField = value
            End Set
        End Property

        Public Property AnalysisEntry() As String
            Get
                Return Me.analysisEntryField
            End Get
            Set(value As String)
                Me.analysisEntryField = value
            End Set
        End Property

        Public Property AnalysisLineEntry() As LedgerDistributionAnalysisLineEntry
            Get
                Return Me.analysisLineEntryField
            End Get
            Set(value As LedgerDistributionAnalysisLineEntry)
                Me.analysisLineEntryField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum LedgerTaxCode

        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        A

        '''<remarks/>
        B

        '''<remarks/>
        C

        '''<remarks/>
        D

        '''<remarks/>
        E

        '''<remarks/>
        F

        '''<remarks/>
        G

        '''<remarks/>
        H

        '''<remarks/>
        I

        '''<remarks/>
        J

        '''<remarks/>
        K

        '''<remarks/>
        L

        '''<remarks/>
        M

        '''<remarks/>
        N

        '''<remarks/>
        O

        '''<remarks/>
        P

        '''<remarks/>
        Q

        '''<remarks/>
        R

        '''<remarks/>
        S

        '''<remarks/>
        T

        '''<remarks/>
        U

        '''<remarks/>
        V

        '''<remarks/>
        W

        '''<remarks/>
        X

        '''<remarks/>
        Y

        '''<remarks/>
        Z

    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum LedgerSecondTaxCode

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        A

        '''<remarks/>
        B

        '''<remarks/>
        C

        '''<remarks/>
        D

        '''<remarks/>
        E

        '''<remarks/>
        F

        '''<remarks/>
        G

        '''<remarks/>
        H

        '''<remarks/>
        I

        '''<remarks/>
        J

        '''<remarks/>
        KL

        '''<remarks/>
        M

        '''<remarks/>
        NO

        '''<remarks/>
        P

        '''<remarks/>
        Q

        '''<remarks/>
        R

        '''<remarks/>
        S

        '''<remarks/>
        T

        '''<remarks/>
        U

        '''<remarks/>
        V

        '''<remarks/>
        W

        '''<remarks/>
        X

        '''<remarks/>
        Y

        '''<remarks/>
        Z


    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class LedgerDistributionAnalysisLineEntry

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisCode5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private endDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private entryAmountField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private commentField As String

        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set(value As String)
                Me.analysisCode1Field = value
            End Set
        End Property

        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set(value As String)
                Me.analysisCode2Field = value
            End Set
        End Property

        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set(value As String)
                Me.analysisCode3Field = value
            End Set
        End Property

        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set(value As String)
                Me.analysisCode4Field = value
            End Set
        End Property

        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set(value As String)
                Me.analysisCode5Field = value
            End Set
        End Property

        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set(value As String)
                Me.startDateField = value
            End Set
        End Property

        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set(value As String)
                Me.endDateField = value
            End Set
        End Property

        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set(value As String)
                Me.entryAmountField = value
            End Set
        End Property

        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set(value As String)
                Me.commentField = value
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
    Partial Public Class PostApInvoice
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As New List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''Mandatory element.This is the top element for all data required for the transaction. This element can occur multiple times as the business object caters for the posting of multiple transactions to multiple suppliers.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
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
                Return "APSTIN"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
                End If
                Return Me._params
            End Get
        End Property

        <Reflection.Obfuscation(Exclude:=False)> _
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
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
        
        <Reflection.Obfuscation(Exclude:=False)> _
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostApInvoice
                objParams = New Params.PostApInvoice
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

        <Reflection.Obfuscation(Exclude:=False)> _
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
