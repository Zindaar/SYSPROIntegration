Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryPosting.AccountsReceivableInvoicePosting.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GenerateInvoiceNumber
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionTypeField As TransactionType
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postToExistingInvoiceField As PostToExistingInvoice
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private generateInvoiceNumberField As GenerateInvoiceNumber
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private gSTValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private geographicAreaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private branchField As String
        
        
        '''<summary>
        '''Mandatory element.  Enter the transaction type. 'I' = Invoice, 'D' = Debit note, 'C' = Credit note
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("TransactionType")> _
        Public Property TransactionType() As TransactionType
            Get
                Return Me.transactionTypeField
            End Get
            Set(ByVal value As TransactionType)
                Me.transactionTypeField = Value
            End Set
        End Property
        
        '''<summary>
        '''Mandatory element. Enter the SYSPRO customer applicable to the transaction. This must be a valid SYSPRO customer.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Customer")> _
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set(ByVal value As String)
                Me.customerField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.  This is only available when processing a credit note or debit note, and the 'Generate Invoice Number' option is set to No.  The existing invoice number must then be input in the Invoice element.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("PostToExistingInvoice")> _
        Public Property PostToExistingInvoice() As PostToExistingInvoice
            Get
                Return Me.postToExistingInvoiceField
            End Get
            Set(ByVal value As PostToExistingInvoice)
                Me.postToExistingInvoiceField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.  If invoice numbering is by 'Company', then this is only available if A/R invoice key type is numeric. If invoice numbering is by 'Branch', then this element is available irrespective of the A/R invoice key type.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("GenerateInvoiceNumber")> _
        Public Property GenerateInvoiceNumber() As GenerateInvoiceNumber
            Get
                Return Me.generateInvoiceNumberField
            End Get
            Set(ByVal value As GenerateInvoiceNumber)
                Me.generateInvoiceNumberField = Value
            End Set
        End Property
        
        '''<summary>
        '''Enter the invoice number for the transaction if not selecting to Generate Invoice Number.  If the A/R invoice key type is alphanumeric then an invoice number is mandatory.  If an invoice number is given as well as the 'Generate Invoice Number' being set to yes, this invoice number will be ignored and a system number will be generated.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Invoice")> _
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set(ByVal value As String)
                Me.invoiceField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If this element is not supplied or if zeroes are entered against this element, the current system date will be used as the default.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceDate")> _
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set(ByVal value As String)
                Me.invoiceDateField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If the transaction is being posted to a Sub Account and the user has not given a Reference, then the store number from the customer master file will be used as the reference.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Reference")> _
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As String)
                Me.referenceField = Value
            End Set
        End Property
        
        '''<summary>
        '''Mandatory element. Enter the transaction value in the customer's currency. This may not be a negative value, the system will convert it to be negative for credit notes.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceValue")> _
        Public Property InvoiceValue() As String
            Get
                Return Me.invoiceValueField
            End Get
            Set(ByVal value As String)
                Me.invoiceValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If the SYSPRO customer is a local currency customer the value of this element is ignored and an exchange rate of 1 is always used. For foreign currency SYSPRO customers, the following rules apply: If this element is not supplied or a value of zero is supplied, the exchange rate against the SYSPRO currency code is used as the default. If this element is supplied and the SYSPRO currency code is setup with a non-fixed exchange rate, then the value against the element is used. If this element is supplied and the SYSPRO currency code is setup with a fixed exchange rate, then the value against the element must match the exchange rate setup against the SYSPRO currency code. If a debit or credit note is posted against an existing invoice, the exchange rate against the original invoice is used.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("ExchangeRate")> _
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set(ByVal value As String)
                Me.exchangeRateField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.  This is the tax value of the transaction in the customers currency. This will only be used if the customer is defined as non-exempt from tax in the Customer setup.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("TaxValue")> _
        Public Property TaxValue() As String
            Get
                Return Me.taxValueField
            End Get
            Set(ByVal value As String)
                Me.taxValueField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.  This is the GST value of the transaction in the customers currency. This will only be used if the customer is defined as non-exempt from GST in the Customer setup and if the SYSPRO nationality code is defined as CAN.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("GSTValue")> _
        Public Property GSTValue() As String
            Get
                Return Me.gSTValueField
            End Get
            Set(ByVal value As String)
                Me.gSTValueField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.  This is the cost value of the transaction in local currency.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("CostValue")> _
        Public Property CostValue() As String
            Get
                Return Me.costValueField
            End Get
            Set(ByVal value As String)
                Me.costValueField = Value
            End Set
        End Property
        
        '''<summary>
        '''Mandatory element. Enter the SYSPRO product class applicable to the transaction. This must be a valid SYSPRO product class.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("ProductClass")> _
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set(ByVal value As String)
                Me.productClassField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if spaces are specified against this element, then the invoice terms against the SYSPRO customer will be used, otherwise the invoice terms supplied against this element will be used. The invoice terms must be a valid SYSPRO invoice terms.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("InvoiceTerms")> _
        Public Property InvoiceTerms() As String
            Get
                Return Me.invoiceTermsField
            End Get
            Set(ByVal value As String)
                Me.invoiceTermsField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if spaces are specified against this element, then the geographic area against the SYSPRO customer will be used, otherwise the geographic area supplied against this element will be used. The geographic area must be a valid SYSPRO geographic area.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("GeographicArea")> _
        Public Property GeographicArea() As String
            Get
                Return Me.geographicAreaField
            End Get
            Set(ByVal value As String)
                Me.geographicAreaField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if spaces are specified against this element, then the salesperson against the SYSPRO customer will be used, otherwise the salesperson supplied against this element will be used. The salesperson must be a valid SYSPRO salesperson.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Salesperson")> _
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set(ByVal value As String)
                Me.salespersonField = Value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if spaces are specified against this element, then the branch against the SYSPRO customer will be used, otherwise the branch supplied against this element will be used. The branch must be a valid SYSPRO branch.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Branch")> _
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set(ByVal value As String)
                Me.branchField = Value
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
    Public Enum PostToExistingInvoice
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostArInvoices
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This is the top element for all data required for the transaction.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of Item))
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
                Return "ARSTIN"
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
                Dim objParams As Params.PostArInvoices
                objParams = New Params.PostArInvoices
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
