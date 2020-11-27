Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryPosting.PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False, elementName:="Item")> _
    Partial Public Class Adjustments

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private bankField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentTypeField As PaymentType

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentTypeFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerBankField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerBranchField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceToAdjustField As List(Of InvoiceToAdjust)

        Public Sub New()
            MyBase.New()
            Me.paymentTypeField = PaymentType.C
            If (Me.invoiceToAdjustField Is Nothing) Then
                Me.invoiceToAdjustField = New List(Of InvoiceToAdjust)
            End If
        End Sub

        '''<summary>
        '''This element is mandatory within the 'Payment' and 'Adjustments' elements. This is the SYSPRO customer against which A/R payments/adjustments are to be processed. The value of this element must be a valid SYSPRO customer.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set(ByVal value As String)
                Me.customerField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. If the SYSPRO A/R Setup /General / 'Bank deposit slip required' is not selected, then this element is not relevant. The bank must be a valid SYSPRO bank. If the element is not supplied or if spaces or nulls supplied, then the default is the default bank defined against the SYSPRO operator. 
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set(ByVal value As String)
                Me.bankField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This is the type of payment. Valid values are 'C' - check, 'S' - cash or 'O' other. The default value if the payment,adjustment or miscellaneous receipt is in local currency is 'C'. All foreign payments,adjustments or miscellaneous receipts have a 'PaymentType' of 'O' irrespective of the element value supplied.
        '''</summary>
        Public Property PaymentType() As PaymentType
            Get
                Return Me.paymentTypeField
            End Get
            Set(ByVal value As PaymentType)
                Me.paymentTypeField = Value
                Me.paymentTypeFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property PaymentTypeSpecified() As Boolean
            Get
                Return Me.paymentTypeFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). The default element value is the customer name of the 'Customer' element.This is the name of the drawer of the check.
        '''</summary>
        Public Property DrawerName() As String
            Get
                Return Me.drawerNameField
            End Get
            Set(ByVal value As String)
                Me.drawerNameField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the bank of the drawer of the check.
        '''</summary>
        Public Property DrawerBank() As String
            Get
                Return Me.drawerBankField
            End Get
            Set(ByVal value As String)
                Me.drawerBankField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the branch of the drawer of the check.
        '''</summary>
        Public Property DrawerBranch() As String
            Get
                Return Me.drawerBranchField
            End Get
            Set(ByVal value As String)
                Me.drawerBranchField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory within the 'Adjustments' element but is not mandatory within the 'Item' element. This is the top element for all data supplied for performing an adjustment to a SYSPRO A/R invoice for a SYSPRO customer.This element can occur multiple times within the 'Adjustments' element. Each occurrence contains all the data for adjusting a single A/R invoice.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceToAdjust")> _
        Public Property InvoiceToAdjustCollection() As List(Of InvoiceToAdjust)
            Get
                Return Me.invoiceToAdjustField
            End Get
            Set(ByVal value As List(Of InvoiceToAdjust))
                Me.invoiceToAdjustField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PaymentType
        
        '''<remarks/>
        C
        
        '''<remarks/>
        S
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InvoiceToAdjust
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTypeField As TransactionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private adjustmentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private adjustmentTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxPortionOfAdjustmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private adjustmentLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForAdjustmentLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalNotationField As String
        
        Public Sub New()
            MyBase.New
            Me.transactionTypeField = TransactionType.I
        End Sub
        
        '''<summary>
        '''This element is optional.This is the element to define if the SYSPRO A/R invoice against which the payment or adjustment is being made, was originally captured as an invoice, credit note or debit note.  Valid values of this element are 'I' - invoice, 'C' - credit note, or 'D' - debit note. The default value is 'I'. 
        '''</summary>
        Public Property TransactionType() As TransactionType
            Get
                Return Me.transactionTypeField
            End Get
            Set
                Me.transactionTypeField = value
                Me.TransactionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TransactionTypeSpecified() As Boolean
            Get
                Return Me.transactionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'InvoiceToPay' or 'InvoiceToAdjust'  or 'InvoiceToReEstablish' elements. This is the invoice to which the payment or adjustment is being made or the invoice that is being re-established. If making a payment or an adjustment then the value of this element must be a valid SYSPRO A/R invoice. If re-establishing an invoice, then this invoice must not exist on the SYSPRO A/R invoice file.
        '''</summary>
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'InvoiceToAdjust' element as a zero value adjustment is invalid. This is the value by which the SYSPRO A/R invoice must be adjusted. 
        '''</summary>
        Public Property AdjustmentValue() As String
            Get
                Return Me.adjustmentValueField
            End Get
            Set
                Me.adjustmentValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.This element is only relevant if the SYSPRO A/R Setup/Tax/'Request tax portion for invoice adjustments/discounts' is selected. In addition, this element is not relevant if making an adjustment to a foreign currency SYSPRO customer or if the SYSPRO customer is non-taxable. If the element is not supplied, the default is the tax code defined in SYSPRO A/R / Setup / Tax / 'Default tax code'.If the element is supplied with a value of spaces, and 'Y' is supplied against the 'AutoCalculateTax', then a tax rate of zero is applied when the tax is automatically calculated.
        '''If a value is supplied in this element and 'Y' is supplied against the 'AutoCalculateTax' element, then the tax code supplied is used to ascertain the tax rate to be used in the automatic calculation of the tax portion of the adjustment and must be a valid SYSPRO tax code.  
        '''</summary>
        Public Property AdjustmentTaxCode() As String
            Get
                Return Me.adjustmentTaxCodeField
            End Get
            Set
                Me.adjustmentTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.This element is only relevant if the SYSPRO A/R Setup/Tax/'Request tax portion for invoice adjustments/discounts' is selected. In addition, this element is not relevant if making an adjustment to a foreign currency SYSPRO customer or if the SYSPRO customer is non-taxable. This is the tax value of the adjustment. If this element is supplied (even if the element value is spaces or nulls), then the value supplied is always used. If this element is not supplied and the value of the 'AutoCalcTax' element is 'N', then the default element value is zero. If the element is not supplied and a 'Y' is supplied against the 'AutoCalcTax' element, then the tax code supplied in the 'AdjustmentTaxCode' element is used to ascertain the tax rate to use in the calculation of the tax portion value. The calculated value is used as the default value.  
        '''</summary>
        Public Property TaxPortionOfAdjustment() As String
            Get
                Return Me.taxPortionOfAdjustmentField
            End Get
            Set
                Me.taxPortionOfAdjustmentField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the reference to be assigned to a payment, adjustment or miscellaneous receipt.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.This element is only validated if A/R is integrated to General Ledger in 'Summary ' or 'Detail' in SYSPRO. This is the ledger code to which the adjustment value will be distributed. If this element is not supplied the default value is the Adjustment ledger code defined on the SYSPRO payments interface record.
        '''</summary>
        Public Property AdjustmentLedgerCode() As String
            Get
                Return Me.adjustmentLedgerCodeField
            End Get
            Set
                Me.adjustmentLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If the  SYSPRO ledger code supplied in the 'AdjustmentLedgerCode' element has an associated password, then this element is used to define this password.
        '''</summary>
        Public Property PasswordForAdjustmentLedgerCode() As String
            Get
                Return Me.passwordForAdjustmentLedgerCodeField
            End Get
            Set
                Me.passwordForAdjustmentLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. This is the journal notation for payments, adjustments and miscellaneous receipts.
        '''</summary>
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set
                Me.journalNotationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TransactionType
        
        '''<remarks/>
        I
        
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
    Public Enum ApplyAutomaticPayments
        
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
    Partial Public Class AutomaticPaymentsOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyAutomaticPaymentsField As ApplyAutomaticPayments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyAutomaticPaymentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private automaticPaymentsSequenceField As AutomaticPaymentsSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private automaticPaymentsSequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFutureInvoicesField As IncludeFutureInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFutureInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrentInvoicesField As IncludeCurrentInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrentInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include30DayInvoicesField As Include30DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include30DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include60DayInvoicesField As Include60DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include60DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include90DayInvoicesField As Include90DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include90DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include120DayAndOverInvoicesField As Include120DayAndOverInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include120DayAndOverInvoicesFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.applyAutomaticPaymentsField = ApplyAutomaticPayments.N
            Me.automaticPaymentsSequenceField = AutomaticPaymentsSequence.I
            Me.includeFutureInvoicesField = IncludeFutureInvoices.Y
            Me.includeCurrentInvoicesField = IncludeCurrentInvoices.Y
            Me.include30DayInvoicesField = Include30DayInvoices.Y
            Me.include60DayInvoicesField = Include60DayInvoices.Y
            Me.include90DayInvoicesField = Include90DayInvoices.Y
            Me.include120DayAndOverInvoicesField = Include120DayAndOverInvoices.Y
        End Sub
        
        '''<summary>
        '''This element is optional.This is used to specify whether the undistributed portion of the 'PaymentValue' is to be used to pay all outstanding invoices for the SYSPRO customer, until the undistributed amount falls to zero. 
        '''Valid values are 'Y' - yes and 'N' - no. The default value is 'N'.
        '''</summary>
        Public Property ApplyAutomaticPayments() As ApplyAutomaticPayments
            Get
                Return Me.applyAutomaticPaymentsField
            End Get
            Set
                Me.applyAutomaticPaymentsField = value
                Me.ApplyAutomaticPaymentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyAutomaticPaymentsSpecified() As Boolean
            Get
                Return Me.applyAutomaticPaymentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. This indicates the sequence in which invoices are to be selected for automatic payment. Valid values are  'I' (invoice sequence) or 'D' (invoice date sequence). The default is 'I'
        '''</summary>
        Public Property AutomaticPaymentsSequence() As AutomaticPaymentsSequence
            Get
                Return Me.automaticPaymentsSequenceField
            End Get
            Set
                Me.automaticPaymentsSequenceField = value
                Me.AutomaticPaymentsSequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AutomaticPaymentsSequenceSpecified() As Boolean
            Get
                Return Me.automaticPaymentsSequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R future invoices are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R future invoices  are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property IncludeFutureInvoices() As IncludeFutureInvoices
            Get
                Return Me.includeFutureInvoicesField
            End Get
            Set
                Me.includeFutureInvoicesField = value
                Me.IncludeFutureInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeFutureInvoicesSpecified() As Boolean
            Get
                Return Me.includeFutureInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices that are less than 30 days old are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices that are less than 30 days old are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property IncludeCurrentInvoices() As IncludeCurrentInvoices
            Get
                Return Me.includeCurrentInvoicesField
            End Get
            Set
                Me.includeCurrentInvoicesField = value
                Me.IncludeCurrentInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCurrentInvoicesSpecified() As Boolean
            Get
                Return Me.includeCurrentInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 30 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 30 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include30DayInvoices() As Include30DayInvoices
            Get
                Return Me.include30DayInvoicesField
            End Get
            Set
                Me.include30DayInvoicesField = value
                Me.Include30DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include30DayInvoicesSpecified() As Boolean
            Get
                Return Me.include30DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 60 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 60 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include60DayInvoices() As Include60DayInvoices
            Get
                Return Me.include60DayInvoicesField
            End Get
            Set
                Me.include60DayInvoicesField = value
                Me.Include60DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include60DayInvoicesSpecified() As Boolean
            Get
                Return Me.include60DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 90 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 90 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include90DayInvoices() As Include90DayInvoices
            Get
                Return Me.include90DayInvoicesField
            End Get
            Set
                Me.include90DayInvoicesField = value
                Me.Include90DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include90DayInvoicesSpecified() As Boolean
            Get
                Return Me.include90DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 120 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 120 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include120DayAndOverInvoices() As Include120DayAndOverInvoices
            Get
                Return Me.include120DayAndOverInvoicesField
            End Get
            Set
                Me.include120DayAndOverInvoicesField = value
                Me.Include120DayAndOverInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include120DayAndOverInvoicesSpecified() As Boolean
            Get
                Return Me.include120DayAndOverInvoicesFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AutomaticPaymentsSequence
        
        '''<remarks/>
        I
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeFutureInvoices
        
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
    Public Enum IncludeCurrentInvoices
        
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
    Public Enum Include30DayInvoices
        
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
    Public Enum Include60DayInvoices
        
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
    Public Enum Include90DayInvoices
        
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
    Public Enum Include120DayAndOverInvoices
        
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
    Public Enum DefaultExchangeRateMethod
        
        '''<remarks/>
        I
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InvoiceToPay
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTypeField As TransactionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossPaymentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxPortionOfDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withholdingTaxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPurchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateToUseField As String
        
        Public Sub New()
            MyBase.New
            Me.transactionTypeField = TransactionType.I
        End Sub
        
        '''<summary>
        '''This element is optional.This is the element to define if the SYSPRO A/R invoice against which the payment or adjustment is being made, was originally captured as an invoice, credit note or debit note.  Valid values of this element are 'I' - invoice, 'C' - credit note, or 'D' - debit note. The default value is 'I'. 
        '''</summary>
        Public Property TransactionType() As TransactionType
            Get
                Return Me.transactionTypeField
            End Get
            Set
                Me.transactionTypeField = value
                Me.TransactionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TransactionTypeSpecified() As Boolean
            Get
                Return Me.transactionTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'InvoiceToPay' or 'InvoiceToAdjust'  or 'InvoiceToReEstablish' elements. This is the invoice to which the payment or adjustment is being made or the invoice that is being re-established. If making a payment or an adjustment then the value of this element must be a valid SYSPRO A/R invoice. If re-establishing an invoice, then this invoice must not exist on the SYSPRO A/R invoice file.
        '''</summary>
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. The gross amount is the total payment amount, including tax and discounts to be paid against the SYSPRO A/R invoice. Within the 'InvoiceToPay' hierarchy, if this element is not supplied, the default value is the outstanding value of the SYSPRO A/R invoice.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied, the default value is zero.
        '''Within the 'InvoiceToPay' or the 'InvoiceToReEstablish' hierarchy, if spaces or nulls are supplied in the element value, then the element value is assumed to be zero.
        '''
        '''
        '''
        '''</summary>
        Public Property GrossPaymentValue() As String
            Get
                Return Me.grossPaymentValueField
            End Get
            Set
                Me.grossPaymentValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the value of discount to be given.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied or nulls are supplied, a default of zero is used.
        '''Within the 'InvoiceToPay' hierarchy, if the 'PaymentDate' is within the SYSPRO customer discount terms and the entire invoice balance is being paid, then the default for this element is the original discount against the SYSPRO A/R invoice.This default is only used if the element is not supplied. If  this default exceeds the 'GrossPaymentValue', then the default is set to the 'GrossPaymentValue'. If a value of spaces or nulls is supplied then a discount value of zero is assumed.
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
        '''This element is optional.This element is only relevant if the SYSPRO A/R Setup/Tax/'Request tax portion for invoice adjustments/discounts' is selected. In addition, this element is not relevant  if the SYSPRO customer is non-taxable. This is the tax value of the discount. If this element is supplied (even if the element value is spaces or nulls), then the value supplied is always used. If this element is not supplied and the value of the 'AutoCalcTax' element is 'N', then the default element value is zero. If the element is not supplied and a 'Y' is supplied against the 'AutoCalcTax' element, then the tax portion value is automatically calculated using the tax code defined in SYSPRO A/R Setup / Tax / 'Default tax code'.
        '''</summary>
        Public Property TaxPortionOfDiscount() As String
            Get
                Return Me.taxPortionOfDiscountField
            End Get
            Set
                Me.taxPortionOfDiscountField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if SYSPRO Tax setup / Withholding tax / 'Withholding tax' is required. This is the value of withholding tax.
        '''</summary>
        Public Property WithholdingTaxValue() As String
            Get
                Return Me.withholdingTaxValueField
            End Get
            Set
                Me.withholdingTaxValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If you wish to change the customer purchase order against the SYSPRO A/R Invoice, then this element is used to supply the new value of the customer purchase order. For 'UnappliedPayment' the default value of this element, if not supplied, is 'Unapplied cash'.
        '''</summary>
        Public Property CustomerPurchaseOrder() As String
            Get
                Return Me.customerPurchaseOrderField
            End Get
            Set
                Me.customerPurchaseOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If SYSPRO A/R Setup / General / 'Foreign currency sales is not required', or if the SYSPRO customer is a local currency customer, then this element is not relevant. If the currency defined against the SYSPRO customer is defined as fixed, then this element is not relevant as the current SYSPRO exchange rate is always used.This is the exchange rate at which to pay the  SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'I',  then the default value of this element is the original exchange rate on the SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'N', then the default value of this element is the value supplied in the 'DefaultExchangeRateToUse' element. 
        '''</summary>
        Public Property ExchangeRateToUse() As String
            Get
                Return Me.exchangeRateToUseField
            End Get
            Set
                Me.exchangeRateToUseField = value
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <System.Xml.Serialization.XmlElementAttribute("Adjustments", GetType(Adjustments)),  _
         System.Xml.Serialization.XmlElementAttribute("MiscellaneousReceipt", GetType(MiscellaneousReceipt)),  _
         System.Xml.Serialization.XmlElementAttribute("Payment", GetType(Payment))>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
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
    Partial Public Class MiscellaneousReceipt
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscellaneousReceiptValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscellaneousReceiptDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private debitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForDebitLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForCreditLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalNotationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscellaneousExchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentTypeField As PaymentType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawerBankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawerBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankChargeValueField As String
        
        Public Sub New()
            MyBase.New
            Me.paymentTypeField = PaymentType.C
        End Sub
        
        '''<summary>
        '''This element is optional. If the SYSPRO A/R Setup /General / 'Bank deposit slip required' is not selected, then this element is not relevant. The bank must be a valid SYSPRO bank. If the element is not supplied or if spaces or nulls supplied, then the default is the default bank defined against the SYSPRO operator. 
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the currency  of the miscellaneous receipt.
        '''If SYSPRO A/R Setup / General / 'Foreign currency sales required' is not selected, then this element is not relevant and the SYSPRO local currency will always be used. If the element is not supplied or if spaces or nulls are supplied, the default currency will be the currency defined against the 'Bank' element. If the A/R Setup / General / 'Bank Deposit slip required' is not selected, then the default is the SYSPRO local currency. The currency must be a valid SYSPRO currency.
        '''</summary>
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.This element is only relevant to Miscellaneous receipts and is the branch to which the miscellaneous receipt is to be posted. If a 'Y' is supplied against the 'ApplySpecificBranch' element, then the value of this element is ignored and the value against the 'BranchToUse' element is used instead.
        '''The default value of this element is the default branch defined against the SYSPRO operator. The default will only be used if the element is not supplied.
        '''If spaces(blanks) or nulls are supplied, the business object will validate whether a branch with a value of 'spaces' exists on the SYSPRO branch file. Historically SYSPRO did allow a branch with a key of 'spaces' to be captured.
        '''</summary>
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'MiscellaneousReceipt' element as a value of zero is invalid. A negative value will result in a warning message being issued.
        '''</summary>
        Public Property MiscellaneousReceiptValue() As String
            Get
                Return Me.miscellaneousReceiptValueField
            End Get
            Set
                Me.miscellaneousReceiptValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the reference to be assigned to a payment, adjustment or miscellaneous receipt.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the date to be assigned to the miscellaneous receipt. The default is the current system date.
        '''</summary>
        Public Property MiscellaneousReceiptDate() As String
            Get
                Return Me.miscellaneousReceiptDateField
            End Get
            Set
                Me.miscellaneousReceiptDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the debit ledger code to which the miscellaneous receipt value will be distributed. This element must be a valid SYSPRO general ledger code if  A/R is integrated to General Ledger in 'Summary ' or 'Detail' in SYSPRO. If integrated by 'Report', then spaces are invalid. 
        '''</summary>
        Public Property DebitLedgerCode() As String
            Get
                Return Me.debitLedgerCodeField
            End Get
            Set
                Me.debitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If the  SYSPRO ledger code supplied in the 'DebitLedgerCode' element has an associated password, then this element is  used to define this password.
        '''</summary>
        Public Property PasswordForDebitLedgerCode() As String
            Get
                Return Me.passwordForDebitLedgerCodeField
            End Get
            Set
                Me.passwordForDebitLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the credit ledger code to which the miscellaneous receipt value will be distributed. This element must be a valid SYSPRO general ledger code if  A/R is integrated to General Ledger in 'Summary ' or 'Detail' in SYSPRO. If integrated by 'Report', then spaces are invalid. 
        '''</summary>
        Public Property CreditLedgerCode() As String
            Get
                Return Me.creditLedgerCodeField
            End Get
            Set
                Me.creditLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If the  SYSPRO ledger code supplied in the 'CreditLedgerCode' element has an associated password, then this element is used to define this password.
        '''</summary>
        Public Property PasswordForCreditLedgerCode() As String
            Get
                Return Me.passwordForCreditLedgerCodeField
            End Get
            Set
                Me.passwordForCreditLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. This is the journal notation for payments, adjustments and miscellaneous receipts.
        '''</summary>
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set
                Me.journalNotationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if A/R Setup / General / 'Foreign currency sales required' is selected and the 'Currency' supplied is foreign currency and the rate defined against the currency in SYSPRO is not fixed. This is the  exchange rate at which the miscellaneous receipt is to be processed. If the 'Currency' is local currency, the value of this element is always set to '1'.  If the 'Currency' is foreign currency, and the SYSPRO currency is defined as a fixed rate, then the rate against the SYSPRO currency is always used and the value of this element is ignored. If this element is not supplied or zeros,spaces or nulls are supplied, the default rate used is the rate against the SYSPRO currency.
        '''</summary>
        Public Property MiscellaneousExchangeRate() As String
            Get
                Return Me.miscellaneousExchangeRateField
            End Get
            Set
                Me.miscellaneousExchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This is the type of payment. Valid values are 'C' - check, 'S' - cash or 'O' other. The default value if the payment,adjustment or miscellaneous receipt is in local currency is 'C'. All foreign payments,adjustments or miscellaneous receipts have a 'PaymentType' of 'O' irrespective of the element value supplied.
        '''</summary>
        Public Property PaymentType() As PaymentType
            Get
                Return Me.paymentTypeField
            End Get
            Set
                Me.paymentTypeField = value
                Me.PaymentTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PaymentTypeSpecified() As Boolean
            Get
                Return Me.paymentTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). The default element value is the customer name of the 'Customer' element.This is the name of the drawer of the check.
        '''</summary>
        Public Property DrawerName() As String
            Get
                Return Me.drawerNameField
            End Get
            Set
                Me.drawerNameField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the bank of the drawer of the check.
        '''</summary>
        Public Property DrawerBank() As String
            Get
                Return Me.drawerBankField
            End Get
            Set
                Me.drawerBankField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the branch of the drawer of the check.
        '''</summary>
        Public Property DrawerBranch() As String
            Get
                Return Me.drawerBranchField
            End Get
            Set
                Me.drawerBranchField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is not relevant for adjustments. For payments and miscellaneous receipts this element is only relevant if
        '''SYSPRO Cash Book is installed and SYSPRO A/R Setup / Integration - payments are linked to Cash Book, and bank charges are required for the 'Bank' supplied.
        '''
        '''</summary>
        Public Property BankChargeValue() As String
            Get
                Return Me.bankChargeValueField
            End Get
            Set
                Me.bankChargeValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False, elementName:="Item")> _
    Partial Public Class Payment

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private referenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalNotationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentNarrationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defaultExchangeRateMethodField As DefaultExchangeRateMethod

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defaultExchangeRateMethodFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defaultExchangeRateToUseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchangeRateVarianceLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private passwordExchangeRateVarianceLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyDuePostDatedChecksField As ApplyDuePostDatedChecks

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyDuePostDatedChecksFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private bankField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentTypeField As PaymentType

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentTypeFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerBankField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private drawerBranchField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private bankChargeValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private bankChargeExchangeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceToPayField As List(Of InvoiceToPay)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private automaticPaymentsOptionsField As AutomaticPaymentsOptions

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private sumCreditValuesOptionsField As SumCreditValuesOptions

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceToReEstablishField As List(Of InvoiceToReEstablish)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unappliedPaymentField As List(Of UnappliedPayment)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postDatedCheckField As List(Of PostDatedCheck)

        Public Sub New()
            MyBase.New()
            Me.defaultExchangeRateMethodField = DefaultExchangeRateMethod.N
            Me.applyDuePostDatedChecksField = ApplyDuePostDatedChecks.N
            Me.paymentTypeField = PaymentType.C
            If (Me.postDatedCheckField Is Nothing) Then
                Me.postDatedCheckField = New List(Of PostDatedCheck)
            End If
            If (Me.unappliedPaymentField Is Nothing) Then
                Me.unappliedPaymentField = New List(Of UnappliedPayment)
            End If
            If (Me.invoiceToReEstablishField Is Nothing) Then
                Me.invoiceToReEstablishField = New List(Of InvoiceToReEstablish)
            End If
            If (Me.sumCreditValuesOptionsField Is Nothing) Then
                Me.sumCreditValuesOptionsField = New SumCreditValuesOptions
            End If
            If (Me.automaticPaymentsOptionsField Is Nothing) Then
                Me.automaticPaymentsOptionsField = New AutomaticPaymentsOptions
            End If
            If (Me.invoiceToPayField Is Nothing) Then
                Me.invoiceToPayField = New List(Of InvoiceToPay)
            End If
        End Sub

        '''<summary>
        '''This element is mandatory within the 'Payment' and 'Adjustments' elements. This is the SYSPRO customer against which A/R payments/adjustments are to be processed. The value of this element must be a valid SYSPRO customer.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set(ByVal value As String)
                Me.customerField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the value of the payment in the currency of the SYSPRO A/R customer.
        '''</summary>
        Public Property PaymentValue() As String
            Get
                Return Me.paymentValueField
            End Get
            Set(ByVal value As String)
                Me.paymentValueField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the reference to be assigned to a payment, adjustment or miscellaneous receipt.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As String)
                Me.referenceField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the date of the payment. If the element is not supplied or if zeros or spaces are supplied the default is the current system date.
        '''</summary>
        Public Property PaymentDate() As String
            Get
                Return Me.paymentDateField
            End Get
            Set(ByVal value As String)
                Me.paymentDateField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory. This is the journal notation for payments, adjustments and miscellaneous receipts.
        '''</summary>
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set(ByVal value As String)
                Me.journalNotationField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the payment narration.
        '''</summary>
        Public Property PaymentNarration() As String
            Get
                Return Me.paymentNarrationField
            End Get
            Set(ByVal value As String)
                Me.paymentNarrationField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. If the currency against the SYSPRO customer is local currency or if A/R Setup / General/ 'Foreign sales required' is not ticked, then this element is not relevant. If the currency against the SYSPRO customer is foreign and the rate against the SYSPRO currency is defined as fixed, then this element is not relevant.(If the SYSPRO currency is defined as fixed, then the current rate against the SYSPRO currency is used as the exchange rate for the invoice payments.)This element describes the default exchange rate method to be applied when paying invoices. If a value is supplied in the 'ExchangeRateToUse' element, then this element is not relevant.This element is just a default exchange rate method to be applied, and each invoice can be paid at a different exchange rate by supplying a value in the 'ExchangeRateToUse' element.  Valid values are 'I' (pay the invoice at the exchange rate against the invoice) or 'N' (pay the invoice at a different exchange rate from the original invoice exchange rate). The default value is 'N'. 
        '''</summary>
        Public Property DefaultExchangeRateMethod() As DefaultExchangeRateMethod
            Get
                Return Me.defaultExchangeRateMethodField
            End Get
            Set(ByVal value As DefaultExchangeRateMethod)
                Me.defaultExchangeRateMethodField = Value
                Me.defaultExchangeRateMethodFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property DefaultExchangeRateMethodSpecified() As Boolean
            Get
                Return Me.defaultExchangeRateMethodFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if the value of the 'DefaultExchangeRateMethod' is 'I'. This is the default exchange rate value to use when paying invoices at an exchange rate that differs from the original invoice exchange rate. The default is the current exchange rate against the SYSPRO currency.
        '''</summary>
        Public Property DefaultExchangeRateToUse() As String
            Get
                Return Me.defaultExchangeRateToUseField
            End Get
            Set(ByVal value As String)
                Me.defaultExchangeRateToUseField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the SYSPRO ledger code to which any exchange rate variances must be posted. This element defaults to the exchange rate variance account defined in your SYSPRO General Ledger Integration / Receivables / 'Exchange rate variance'.
        '''This element must be a valid SYSPRO general ledger code if  A/R is integrated to General Ledger in 'Summary ' or 'Detail' in SYSPRO. 
        '''</summary>
        Public Property ExchangeRateVarianceLedgerCode() As String
            Get
                Return Me.exchangeRateVarianceLedgerCodeField
            End Get
            Set(ByVal value As String)
                Me.exchangeRateVarianceLedgerCodeField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. If the  SYSPRO ledger code supplied in the 'ExchangeRateVarianceLedgerCode' element has an associated password, then this element is used to define this password.
        '''</summary>
        Public Property PasswordExchangeRateVarianceLedgerCode() As String
            Get
                Return Me.passwordExchangeRateVarianceLedgerCodeField
            End Get
            Set(ByVal value As String)
                Me.passwordExchangeRateVarianceLedgerCodeField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element alows you to  select all post dated checks that are dated before or equal to the payment date. The total value of these ‘due’ post dated checks is added to the payment value supplied and can then be distributed as normal. 
        '''If the 'PaymentDate' element is not supplied, or if spaces or zeros are supplied, then the current computer date is used to ascertain if the post dated check is ‘due’.If you only wish to apply certain checks, then you  must use the elements within the 'PostDatedCheck' hierarchy. Valid values are 'Y' (to apply due post dated checks) and 'N' (to ignore due post dated checks). The default is 'N'
        '''
        '''</summary>
        Public Property ApplyDuePostDatedChecks() As ApplyDuePostDatedChecks
            Get
                Return Me.applyDuePostDatedChecksField
            End Get
            Set(ByVal value As ApplyDuePostDatedChecks)
                Me.applyDuePostDatedChecksField = Value
                Me.applyDuePostDatedChecksFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property ApplyDuePostDatedChecksSpecified() As Boolean
            Get
                Return Me.applyDuePostDatedChecksFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is optional. If the SYSPRO A/R Setup /General / 'Bank deposit slip required' is not selected, then this element is not relevant. The bank must be a valid SYSPRO bank. If the element is not supplied or if spaces or nulls supplied, then the default is the default bank defined against the SYSPRO operator. 
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set(ByVal value As String)
                Me.bankField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This is the type of payment. Valid values are 'C' - check, 'S' - cash or 'O' other. The default value if the payment,adjustment or miscellaneous receipt is in local currency is 'C'. All foreign payments,adjustments or miscellaneous receipts have a 'PaymentType' of 'O' irrespective of the element value supplied.
        '''</summary>
        Public Property PaymentType() As PaymentType
            Get
                Return Me.paymentTypeField
            End Get
            Set(ByVal value As PaymentType)
                Me.paymentTypeField = Value
                Me.paymentTypeFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property PaymentTypeSpecified() As Boolean
            Get
                Return Me.paymentTypeFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). The default element value is the customer name of the 'Customer' element.This is the name of the drawer of the check.
        '''</summary>
        Public Property DrawerName() As String
            Get
                Return Me.drawerNameField
            End Get
            Set(ByVal value As String)
                Me.drawerNameField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the bank of the drawer of the check.
        '''</summary>
        Public Property DrawerBank() As String
            Get
                Return Me.drawerBankField
            End Get
            Set(ByVal value As String)
                Me.drawerBankField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant if SYSPRO A/R Setup / General / 'Bank Deposit slip required' is not selected. This element is only used if the 'PaymentType' element value is 'C'(check). This is the branch of the drawer of the check.
        '''</summary>
        Public Property DrawerBranch() As String
            Get
                Return Me.drawerBranchField
            End Get
            Set(ByVal value As String)
                Me.drawerBranchField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant for adjustments. For payments and miscellaneous receipts this element is only relevant if
        '''SYSPRO Cash Book is installed and SYSPRO A/R Setup / Integration - payments are linked to Cash Book, and bank charges are required for the 'Bank' supplied.
        '''
        '''</summary>
        Public Property BankChargeValue() As String
            Get
                Return Me.bankChargeValueField
            End Get
            Set(ByVal value As String)
                Me.bankChargeValueField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This element is not relevant for adjustments. This is the exchange rate at which the bank charge is to be converted to local currency.
        '''</summary>
        Public Property BankChargeExchangeRate() As String
            Get
                Return Me.bankChargeExchangeRateField
            End Get
            Set(ByVal value As String)
                Me.bankChargeExchangeRateField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the top element for all data supplied for performing an payment to a SYSPRO A/R invoice for a SYSPRO customer.This element can occur multiple times within the 'Payment' element. Each occurrence contains all the data for making a payment against a single SYSPRO A/R invoice.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceToPay")> _
        Public Property InvoiceToPayCollection() As List(Of InvoiceToPay)
            Get
                Return Me.invoiceToPayField
            End Get
            Set(ByVal value As List(Of InvoiceToPay))
                Me.invoiceToPayField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional .This is the top element for all data supplied for performing automatic payments. This element contains all the elements required to automatically pay SYSPRO A/R invoices for a SYSPRO customer.
        '''Invoices are systematically paid in the sequence specified in the 'AutomaticPaymentsSequence' element until the 'PaymentValue' is fully distributed. Credit balance invoices are ignored.
        '''</summary>
        Public Property AutomaticPaymentsOptions() As AutomaticPaymentsOptions
            Get
                Return Me.automaticPaymentsOptionsField
            End Get
            Set(ByVal value As AutomaticPaymentsOptions)
                Me.automaticPaymentsOptionsField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional.This is the top element for all data supplied to allow the value of credit value invoices to be offset against debit value invoices. Invoices with a credit balance that match the selection criteria supplied, are reduced to have an outstanding balance of zero. The value of the credit is added to the 'PaymentValue' element and this can then be distributed against debit value invoices.
        '''
        '''
        '''</summary>
        Public Property SumCreditValuesOptions() As SumCreditValuesOptions
            Get
                Return Me.sumCreditValuesOptionsField
            End Get
            Set(ByVal value As SumCreditValuesOptions)
                Me.sumCreditValuesOptionsField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the top element for all data supplied for re-establishing an invoice. If you want to make a payment against a SYSPRO A/R Invoice which no longer exists on the SYSPRO A/R Invoice file, you can re-establish the invoice and allocate a payment to this invoice from the data supplied within this element.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceToReEstablish")> _
        Public Property InvoiceToReEstablishCollection() As List(Of InvoiceToReEstablish)
            Get
                Return Me.invoiceToReEstablishField
            End Get
            Set(ByVal value As List(Of InvoiceToReEstablish))
                Me.invoiceToReEstablishField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the top element for all data supplied for performing an 'unapplied' payment.
        '''An 'unapplied' payments is a payment value that needs to be distributed, but it is not associated with a specific SYSPRO A/R invoice. The business object automatically generates the invoice number against which the payment value will be allocated.The invoice numbers always starts’ _CRD’ and the ‘xx’ suffix is determined by getting the highest _CRD invoice number currently on the SYSPRO A/R Invoice file (for the customer), and incrementing this by one. 
        '''This element can occur multiple times within the 'Payment' element. Each occurrence contains all the data for making a single 'unapplied' payment.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("UnappliedPayment")> _
        Public Property UnappliedPaymentCollection() As List(Of UnappliedPayment)
            Get
                Return Me.unappliedPaymentField
            End Get
            Set(ByVal value As List(Of UnappliedPayment))
                Me.unappliedPaymentField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional. This is the top element for all data supplied to select and apply a specific SYSPRO post dated check. The value of the post dated check is added to the 'PaymentValue' and can be distributed as normal.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("PostDatedCheck")> _
        Public Property PostDatedCheckCollection() As List(Of PostDatedCheck)
            Get
                Return Me.postDatedCheckField
            End Get
            Set(ByVal value As List(Of PostDatedCheck))
                Me.postDatedCheckField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyDuePostDatedChecks
        
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
    Partial Public Class SumCreditValuesOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sumCreditValuesField As SumCreditValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sumCreditValuesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFutureInvoicesField As IncludeFutureInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFutureInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrentInvoicesField As IncludeCurrentInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrentInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include30DayInvoicesField As Include30DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include30DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include60DayInvoicesField As Include60DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include60DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include90DayInvoicesField As Include90DayInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include90DayInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include120DayAndOverInvoicesField As Include120DayAndOverInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private include120DayAndOverInvoicesFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.sumCreditValuesField = SumCreditValues.N
            Me.includeFutureInvoicesField = IncludeFutureInvoices.Y
            Me.includeCurrentInvoicesField = IncludeCurrentInvoices.Y
            Me.include30DayInvoicesField = Include30DayInvoices.Y
            Me.include60DayInvoicesField = Include60DayInvoices.Y
            Me.include90DayInvoicesField = Include90DayInvoices.Y
            Me.include120DayAndOverInvoicesField = Include120DayAndOverInvoices.Y
        End Sub
        
        '''<summary>
        '''This element is optional.This is used to specify if the total value of all credit value invoices is to be accumulated and added to the 'PaymentValue' supplied. The outstanding balance of these credit value invoices is set to zero.
        '''Valid options are 'Y' - yes and 'N' - no. The default value is 'N'.
        '''</summary>
        Public Property SumCreditValues() As SumCreditValues
            Get
                Return Me.sumCreditValuesField
            End Get
            Set
                Me.sumCreditValuesField = value
                Me.SumCreditValuesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SumCreditValuesSpecified() As Boolean
            Get
                Return Me.sumCreditValuesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R future invoices are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R future invoices  are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property IncludeFutureInvoices() As IncludeFutureInvoices
            Get
                Return Me.includeFutureInvoicesField
            End Get
            Set
                Me.includeFutureInvoicesField = value
                Me.IncludeFutureInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeFutureInvoicesSpecified() As Boolean
            Get
                Return Me.includeFutureInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices that are less than 30 days old are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices that are less than 30 days old are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property IncludeCurrentInvoices() As IncludeCurrentInvoices
            Get
                Return Me.includeCurrentInvoicesField
            End Get
            Set
                Me.includeCurrentInvoicesField = value
                Me.IncludeCurrentInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCurrentInvoicesSpecified() As Boolean
            Get
                Return Me.includeCurrentInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 30 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 30 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include30DayInvoices() As Include30DayInvoices
            Get
                Return Me.include30DayInvoicesField
            End Get
            Set
                Me.include30DayInvoicesField = value
                Me.Include30DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include30DayInvoicesSpecified() As Boolean
            Get
                Return Me.include30DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 60 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 60 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include60DayInvoices() As Include60DayInvoices
            Get
                Return Me.include60DayInvoicesField
            End Get
            Set
                Me.include60DayInvoicesField = value
                Me.Include60DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include60DayInvoicesSpecified() As Boolean
            Get
                Return Me.include60DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 90 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 90 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include90DayInvoices() As Include90DayInvoices
            Get
                Return Me.include90DayInvoicesField
            End Get
            Set
                Me.include90DayInvoicesField = value
                Me.Include90DayInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include90DayInvoicesSpecified() As Boolean
            Get
                Return Me.include90DayInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. Valid values are 'Y'(yes) and 'N' (no). The default is 'Y'.
        '''If 'Y' is supplied then all SYSPRO A/R invoices older than 120 days are included for automatic payment/sum credits. If 'N' is supplied then all SYSPRO A/R invoices older than 120 days are excluded from automatic payment/sum credits.
        '''</summary>
        Public Property Include120DayAndOverInvoices() As Include120DayAndOverInvoices
            Get
                Return Me.include120DayAndOverInvoicesField
            End Get
            Set
                Me.include120DayAndOverInvoicesField = value
                Me.Include120DayAndOverInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property Include120DayAndOverInvoicesSpecified() As Boolean
            Get
                Return Me.include120DayAndOverInvoicesFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SumCreditValues
        
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
    Partial Public Class InvoiceToReEstablish
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalInvoiceValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalInvoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalInvoiceTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalDiscountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalCustomerPurchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossPaymentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxPortionOfDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withholdingTaxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateToUseField As String
        
        Public Sub New()
            MyBase.New
            Me.originalCustomerPurchaseOrderField = "Re-established"
        End Sub
        
        '''<summary>
        '''This element is mandatory within the 'InvoiceToPay' or 'InvoiceToAdjust'  or 'InvoiceToReEstablish' elements. This is the invoice to which the payment or adjustment is being made or the invoice that is being re-established. If making a payment or an adjustment then the value of this element must be a valid SYSPRO A/R invoice. If re-establishing an invoice, then this invoice must not exist on the SYSPRO A/R invoice file.
        '''</summary>
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional.This is the value of the invoice that you are re-establishing. If this element is not supplied or if spaces or nulls are supplied, then the default value is zero.
        '''</summary>
        Public Property OriginalInvoiceValue() As String
            Get
                Return Me.originalInvoiceValueField
            End Get
            Set
                Me.originalInvoiceValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the invoice date of the invoice that you are re-establishing. If this element is not supplied or if nulls or spaces are supplied, then the value supplied in the 'PaymentDate' is used as the default.
        '''</summary>
        Public Property OriginalInvoiceDate() As String
            Get
                Return Me.originalInvoiceDateField
            End Get
            Set
                Me.originalInvoiceDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the terms code of the invoice you are re-establishing. If this element is not supplied, or if the 'OriginalInvoiceValue' is not > 0, then the terms code defined against the SYSPRO A/R Customer is used as the default.
        '''</summary>
        Public Property OriginalInvoiceTerms() As String
            Get
                Return Me.originalInvoiceTermsField
            End Get
            Set
                Me.originalInvoiceTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the value of the discount on the invoice that you are re-establishing. If the 'OriginalInvoiceValue' is not > 0, then a value of zero is always used and the value supplied is ignored.
        '''</summary>
        Public Property OriginalDiscountValue() As String
            Get
                Return Me.originalDiscountValueField
            End Get
            Set
                Me.originalDiscountValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the customer purchase order of the invoice that you are re-establishing. If this element is not supplied, then the default is 'Re-established'.
        '''</summary>
        Public Property OriginalCustomerPurchaseOrder() As String
            Get
                Return Me.originalCustomerPurchaseOrderField
            End Get
            Set
                Me.originalCustomerPurchaseOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If SYSPRO A/R Setup / General / 'Foreign currency sales is not required', or if the SYSPRO customer is a local currency customer, then this element is not relevant. If the currency defined against the SYSPRO customer is defined as fixed, then this element is not relevant as the current SYSPRO exchange rate is always used.This is the original exchange rate at which to re-establish the SYSPRO A/R Invoice. If the 'DefaultExchangeRateMethod'  element has a value of 'I',  then the default value of this element is the current SYSPRO exchange rate. If the 'DefaultExchangeRateMethod' element has a value of 'N', then the default value of this element is the value supplied in the 'DefaultExchangeRateToUse' element. 
        '''</summary>
        Public Property OriginalExchangeRate() As String
            Get
                Return Me.originalExchangeRateField
            End Get
            Set
                Me.originalExchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. The gross amount is the total payment amount, including tax and discounts to be paid against the SYSPRO A/R invoice. Within the 'InvoiceToPay' hierarchy, if this element is not supplied, the default value is the outstanding value of the SYSPRO A/R invoice.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied, the default value is zero.
        '''Within the 'InvoiceToPay' or the 'InvoiceToReEstablish' hierarchy, if spaces or nulls are supplied in the element value, then the element value is assumed to be zero.
        '''
        '''
        '''
        '''</summary>
        Public Property GrossPaymentValue() As String
            Get
                Return Me.grossPaymentValueField
            End Get
            Set
                Me.grossPaymentValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the value of discount to be given.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied or nulls are supplied, a default of zero is used.
        '''Within the 'InvoiceToPay' hierarchy, if the 'PaymentDate' is within the SYSPRO customer discount terms and the entire invoice balance is being paid, then the default for this element is the original discount against the SYSPRO A/R invoice.This default is only used if the element is not supplied. If  this default exceeds the 'GrossPaymentValue', then the default is set to the 'GrossPaymentValue'. If a value of spaces or nulls is supplied then a discount value of zero is assumed.
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
        '''This element is optional.This element is only relevant if the SYSPRO A/R Setup/Tax/'Request tax portion for invoice adjustments/discounts' is selected. In addition, this element is not relevant  if the SYSPRO customer is non-taxable. This is the tax value of the discount. If this element is supplied (even if the element value is spaces or nulls), then the value supplied is always used. If this element is not supplied and the value of the 'AutoCalcTax' element is 'N', then the default element value is zero. If the element is not supplied and a 'Y' is supplied against the 'AutoCalcTax' element, then the tax portion value is automatically calculated using the tax code defined in SYSPRO A/R Setup / Tax / 'Default tax code'.
        '''</summary>
        Public Property TaxPortionOfDiscount() As String
            Get
                Return Me.taxPortionOfDiscountField
            End Get
            Set
                Me.taxPortionOfDiscountField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if SYSPRO Tax setup / Withholding tax / 'Withholding tax' is required. This is the value of withholding tax.
        '''</summary>
        Public Property WithholdingTaxValue() As String
            Get
                Return Me.withholdingTaxValueField
            End Get
            Set
                Me.withholdingTaxValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If SYSPRO A/R Setup / General / 'Foreign currency sales is not required', or if the SYSPRO customer is a local currency customer, then this element is not relevant. If the currency defined against the SYSPRO customer is defined as fixed, then this element is not relevant as the current SYSPRO exchange rate is always used.This is the exchange rate at which to pay the  SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'I',  then the default value of this element is the original exchange rate on the SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'N', then the default value of this element is the value supplied in the 'DefaultExchangeRateToUse' element. 
        '''</summary>
        Public Property ExchangeRateToUse() As String
            Get
                Return Me.exchangeRateToUseField
            End Get
            Set
                Me.exchangeRateToUseField = value
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
    Partial Public Class UnappliedPayment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossPaymentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxPortionOfDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withholdingTaxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPurchaseOrderField As String
        
        '''<summary>
        '''This element is optional. The gross amount is the total payment amount, including tax and discounts to be paid against the SYSPRO A/R invoice. Within the 'InvoiceToPay' hierarchy, if this element is not supplied, the default value is the outstanding value of the SYSPRO A/R invoice.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied, the default value is zero.
        '''Within the 'InvoiceToPay' or the 'InvoiceToReEstablish' hierarchy, if spaces or nulls are supplied in the element value, then the element value is assumed to be zero.
        '''
        '''
        '''
        '''</summary>
        Public Property GrossPaymentValue() As String
            Get
                Return Me.grossPaymentValueField
            End Get
            Set
                Me.grossPaymentValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This is the value of discount to be given.
        '''Within the 'InvoiceToReEstablish'  and 'UnappliedPayment' hierarchy, if this element is not supplied or nulls are supplied, a default of zero is used.
        '''Within the 'InvoiceToPay' hierarchy, if the 'PaymentDate' is within the SYSPRO customer discount terms and the entire invoice balance is being paid, then the default for this element is the original discount against the SYSPRO A/R invoice.This default is only used if the element is not supplied. If  this default exceeds the 'GrossPaymentValue', then the default is set to the 'GrossPaymentValue'. If a value of spaces or nulls is supplied then a discount value of zero is assumed.
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
        '''This element is optional.This element is only relevant if the SYSPRO A/R Setup/Tax/'Request tax portion for invoice adjustments/discounts' is selected. In addition, this element is not relevant  if the SYSPRO customer is non-taxable. This is the tax value of the discount. If this element is supplied (even if the element value is spaces or nulls), then the value supplied is always used. If this element is not supplied and the value of the 'AutoCalcTax' element is 'N', then the default element value is zero. If the element is not supplied and a 'Y' is supplied against the 'AutoCalcTax' element, then the tax portion value is automatically calculated using the tax code defined in SYSPRO A/R Setup / Tax / 'Default tax code'.
        '''</summary>
        Public Property TaxPortionOfDiscount() As String
            Get
                Return Me.taxPortionOfDiscountField
            End Get
            Set
                Me.taxPortionOfDiscountField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if SYSPRO Tax setup / Withholding tax / 'Withholding tax' is required. This is the value of withholding tax.
        '''</summary>
        Public Property WithholdingTaxValue() As String
            Get
                Return Me.withholdingTaxValueField
            End Get
            Set
                Me.withholdingTaxValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If SYSPRO A/R Setup / General / 'Foreign currency sales is not required', or if the SYSPRO customer is a local currency customer, then this element is not relevant. If the currency defined against the SYSPRO customer is defined as fixed, then this element is not relevant as the current SYSPRO exchange rate is always used.This is the exchange rate at which to pay the  SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'I',  then the default value of this element is the original exchange rate on the SYSPRO A/R invoice. If the 'DefaultExchangeRateMethod' element has a value of 'N', then the default value of this element is the value supplied in the 'DefaultExchangeRateToUse' element. 
        '''</summary>
        Public Property ExchangeRateToUse() As String
            Get
                Return Me.exchangeRateToUseField
            End Get
            Set
                Me.exchangeRateToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If you wish to change the customer purchase order against the SYSPRO A/R Invoice, then this element is used to supply the new value of the customer purchase order. For 'UnappliedPayment' the default value of this element, if not supplied, is 'Unapplied cash'.
        '''</summary>
        Public Property CustomerPurchaseOrder() As String
            Get
                Return Me.customerPurchaseOrderField
            End Get
            Set
                Me.customerPurchaseOrderField = value
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
    Partial Public Class PostDatedCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkNumberField As String
        
        '''<summary>
        '''This element is optional. This is the check date of the post dated check to be selected. If the date is not supplied or if spaces or zeros are supplied, the default is the current computer date.
        '''</summary>
        Public Property CheckDate() As String
            Get
                Return Me.checkDateField
            End Get
            Set
                Me.checkDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. This is the check number of the post dated check to be selected.
        '''</summary>
        Public Property CheckNumber() As String
            Get
                Return Me.checkNumberField
            End Get
            Set
                Me.checkNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostArPayment
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of Object)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.Parameters

        '''<summary>
        '''This element is mandatory.This is the top element for all data required for performing adjustments,payments or miscellaneous receipts. This element can occur multiple times as the business object caters for the posting of multiple transactions to multiple customers.
        '''</summary>
        <System.Xml.Serialization.XmlArrayItemAttribute("Adjustments", GetType(Adjustments), IsNullable:=False), _
         System.Xml.Serialization.XmlArrayItemAttribute("MiscellaneousReceipt", GetType(MiscellaneousReceipt), IsNullable:=False), _
         System.Xml.Serialization.XmlArrayItemAttribute("Payment", GetType(Payment), IsNullable:=False)> _
        Public Property ItemCollection() As List(Of Object)
            Get
                If Me.itemField Is Nothing Then
                    Me.itemField = New List(Of Object)
                End If
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of Object))
                Me.itemField = value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "ARSTPY"
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

                Debug.WriteLine("XMLData Before:" & vbCrLf & doc.OuterXml)

                If doc.ChildNodes.Count = 2 Then
                    Dim itemCollectionElement As Xml.XmlNode = doc.ChildNodes(1).SelectSingleNode("ItemCollection")
                    Dim itemCollectionElementClone As Xml.XmlNode = itemCollectionElement.CloneNode(True)

                    doc.ChildNodes(1).RemoveChild(itemCollectionElement)

                    For iNodeIndex As Integer = 0 To itemCollectionElementClone.ChildNodes.Count - 1
                        Dim node As Xml.XmlNode = itemCollectionElementClone.ChildNodes(iNodeIndex)
                        Debug.WriteLine("XMLData: Found Node " & node.OuterXml)
                        Dim itemNode As Xml.XmlNode = doc.CreateElement("Item")
                        itemNode.AppendChild(node.Clone)
                        doc.ChildNodes(1).AppendChild(itemNode)
                    Next
                End If

                Debug.WriteLine("XMLData After:" & vbCrLf & doc.OuterXml)

                Return doc.OuterXml
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostArPayment
                objParams = New Params.PostArPayment
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
End Namespace
