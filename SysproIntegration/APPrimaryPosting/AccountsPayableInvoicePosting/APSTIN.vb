Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace APPrimaryPosting.AccountsPayableInvoicePosting.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum ApplyIfEntireDocumentValid

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum IgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum LedgerDistributionCurrency

        '''<remarks/>
        L

        '''<remarks/>
        F
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class Parameters

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postingPeriodField As PostingPeriod

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsField As IgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As ValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postZeroAdjustmentsField As PostZeroAdjustments

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defaultDiscountDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defaultDueDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerDistributionCurrencyField As LedgerDistributionCurrency

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private automaticTaxCalculationField As AutomaticTaxCalculation

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private permissibleTaxVarianceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private apArContraTrxField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreAnalysisField As ParametersIgnoreAnalysis

        Public Sub New()
            MyBase.New()
            Me.postingPeriodField = PostingPeriod.C
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.N
            Me.postZeroAdjustmentsField = PostZeroAdjustments.N
            Me.ledgerDistributionCurrencyField = LedgerDistributionCurrency.L
            Me.automaticTaxCalculationField = AutomaticTaxCalculation.N
            Me.ignoreAnalysisField = ParametersIgnoreAnalysis.Y
        End Sub

        '''<summary>
        '''Period to which transactions must be posted. Valid values are 'C' for current period, 'P' for previous period 1 and 'B' for before previous period 2.Default is 'C'
        '''</summary>
        Public Property PostingPeriod() As PostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set(value As PostingPeriod)
                Me.postingPeriodField = value
            End Set
        End Property

        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings such as 'Supplier on hold'. (N - No, Y - Yes, W - give a warning message but don't reject the transaction) Default is 'N'
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(value As IgnoreWarnings)
                Me.ignoreWarningsField = value
            End Set
        End Property

        '''<summary>
        '''This element indicates whether the entire document must be validated prior to any posting taking place. If set to 'N', each item is validated and rejected if in error or posted if correct. This is the fastest option. If set to 'Y', all items in the document are first validated.If the entire document is valid then items are posted.Default  is 'Y'. Valid values are 'Y' and 'N'.
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set(value As ApplyIfEntireDocumentValid)
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property

        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No posting will take place. If set to 'N', each item is validated and posting is performed based on the value of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(value As ValidateOnly)
                Me.validateOnlyField = value
            End Set
        End Property

        '''<summary>
        '''This is only relevant if the 'TransactionType' element has a value of 'A'(adjustment) and the 'TransactionValue' is zero. Valid values are 'N'-no and 'Y'-yes. If set to 'N' then no record is created in the SYSPRO A/P Invoice Payment file. The default is 'N'.
        '''</summary>
        Public Property PostZeroAdjustments() As PostZeroAdjustments
            Get
                Return Me.postZeroAdjustmentsField
            End Get
            Set(value As PostZeroAdjustments)
                Me.postZeroAdjustmentsField = value
            End Set
        End Property

        '''<summary>
        '''Default discount date. This date will be used as the transaction discount date if no value is supplied against the 'DiscountDate' element.
        '''</summary>
        Public Property DefaultDiscountDate() As String
            Get
                Return Me.defaultDiscountDateField
            End Get
            Set(value As String)
                Me.defaultDiscountDateField = value
            End Set
        End Property

        '''<summary>
        '''Default due date.  This date will be used as the transaction due date if no value is supplied against the 'DueDate' element.
        '''</summary>
        Public Property DefaultDueDate() As String
            Get
                Return Me.defaultDueDateField
            End Get
            Set(value As String)
                Me.defaultDueDateField = value
            End Set
        End Property

        '''<summary>
        '''This element describes whether the value supplied in the 'LedgerValue' element is in local currency or is in the currency of the supplier.This is the value for the G/L distribution entry. It is only used if if the supplier is a foreign currency supplier. Valid values are 'L'-local currency or 'F' - foreign currency.The default is 'L'. 
        '''</summary>
        Public Property LedgerDistributionCurrency() As LedgerDistributionCurrency
            Get
                Return Me.ledgerDistributionCurrencyField
            End Get
            Set(value As LedgerDistributionCurrency)
                Me.ledgerDistributionCurrencyField = value
            End Set
        End Property

        '''<summary>
        '''This element indicates whether the tax value of the transaction is to be automatically calculated if it is not supplied in the 'TaxValue' element.Valid values are 'N'o and 'Y'es. The default is 'N'. This element also applies to 2nd tier tax. If EC Vat is installed then the value o this element is always 'N' if the transaction being processed is an EC Acquisition.
        '''</summary>
        Public Property AutomaticTaxCalculation() As AutomaticTaxCalculation
            Get
                Return Me.automaticTaxCalculationField
            End Get
            Set(value As AutomaticTaxCalculation)
                Me.automaticTaxCalculationField = value
            End Set
        End Property

        '''<summary>
        '''This element is only relevant if 'TaxBasis' is defined as ‘E’xclusive and the SYSPRO  A/P setup indicates that tax amounts are to be distributed over multiple G/L Tax accounts. The business object calculates and accumulates the tax value of each G/L distribution entry based on the value in 'LedgerValue' and the rate defined against 'LedgerTaxCode'.
        '''The calculated tax value is compared to the value supplied(or automatically calculated) in the 'TaxValue' element.   If a discrepancy is found and the discrepancy is larger than the 'PermissibleTaxVariance', then the business object will return an error indicating that the calculated tax is not the same as the tax value supplied. If there is a discrepancy, but it is less than or equal to the 'PermissibleTaxVariance', then no error is reported. In this case, the discrepancy value is added to the calculated tax value of the tax code used against the first G/L distribution entry of the transaction. If 2nd tier tax is installed, then the same logic applies to the 2nd tier tax.
        '''The default is zero.
        '''</summary>
        Public Property PermissibleTaxVariance() As String
            Get
                Return Me.permissibleTaxVarianceField
            End Get
            Set(value As String)
                Me.permissibleTaxVarianceField = value
            End Set
        End Property

        '''<summary>
        '''This element indicates whether the transaction is AP-AR Contra type. If It is set to Y for Yes then all the tax calculation will be ignored and no tax posting will take palce.
        '''</summary>
        Public Property ApArContraTrx() As String
            Get
                Return Me.apArContraTrxField
            End Get
            Set(value As String)
                Me.apArContraTrxField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(ParametersIgnoreAnalysis.Y)> _
        Public Property IgnoreAnalysis() As ParametersIgnoreAnalysis
            Get
                Return Me.ignoreAnalysisField
            End Get
            Set(value As ParametersIgnoreAnalysis)
                Me.ignoreAnalysisField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum PostingPeriod

        '''<remarks/>
        C

        '''<remarks/>
        P

        '''<remarks/>
        B
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum ValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum PostZeroAdjustments

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum AutomaticTaxCalculation

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum ParametersIgnoreAnalysis

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostApInvoice

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As Parameters

        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters()
            End If
        End Sub

        '''<summary>
        '''This contains parameters.
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set(value As Parameters)
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
