Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace APPrimaryPosting.PostAPRegisterInvoice.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DiscountBasis
        
        '''<remarks/>
        T
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountBasisField As DiscountBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountableValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPercentageValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchRateAtEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorisingPersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateInvoiceSentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private followUpDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersField As List(Of String)
        
        Public Sub New()
            MyBase.New
            Me.discountBasisField = DiscountBasis.T
            If (Me.ordersField Is Nothing) Then
                Me.ordersField = New List(Of String)
            End If
        End Sub
        
        '''<summary>
        '''Mandatory element. Enter the SYSPRO supplier applicable to the transaction. This must be a valid SYSPRO supplier.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if spaces are specified against this element, then the branch against the SYSPRO supplier will be used, otherwise the branch supplied against this element will be used. The branch must be a valid SYSPRO branch.
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
        '''Mandatory element. The invoice must not exist on the SYSPRO Accounts Payable invoice file or on the SYSPRO Accounts Payable Registered invoice file.
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
        '''Optional element. This is the total value of the invoice including tax.
        '''</summary>
        Public Property InvoiceValue() As String
            Get
                Return Me.invoiceValueField
            End Get
            Set
                Me.invoiceValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.This element specifies how the value of the discount is to be calculated. (T - discount calculated according to the terms code captured against the SYSPRO supplier, P - discount calculated according to the percentage specified against the 'DiscountPercentageValue' element, V - discount value is specified in the 'DiscountPercentageValue' element) 
        '''</summary>
        Public Property DiscountBasis() As DiscountBasis
            Get
                Return Me.discountBasisField
            End Get
            Set
                Me.discountBasisField = value
                Me.DiscountBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DiscountBasisSpecified() As Boolean
            Get
                Return Me.discountBasisFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Optional element. If  'T'(invoice terms) or 'P' (percentage) has been specified against 'DiscountBasis' element, then this element specifies how much of the total invoice value is subject to discount. The default is zero.
        '''</summary>
        Public Property DiscountableValue() As String
            Get
                Return Me.discountableValueField
            End Get
            Set
                Me.discountableValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If 'P' (percentage) has been specified against the 'DiscountBasis' element, then this element specifies the percentage to be applied to the 'DiscountableValue' in order to calculate the value of discount.  The maximum size of the data is 2 integers and 2 decimals.
        '''If 'V' (value) has been specified against the 'DiscountBasis' element, then this is the value of the discount. The maximum size of the data is 12 integers and 2 decimals.
        '''</summary>
        Public Property DiscountPercentageValue() As String
            Get
                Return Me.discountPercentageValueField
            End Get
            Set
                Me.discountPercentageValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.
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
        '''Optional element. If this element is not supplied or if zeroes are entered against this element, the current system date will be used as the default.
        '''</summary>
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set
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
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. In order to qualify for the invoice discount, payment must be made to the supplier on or before the discount date. If this element is not supplied or if zeroes are entered against this element, the discount date will be calculated according to the invoice terms against the SYSPRO supplier. 
        '''</summary>
        Public Property DiscountDate() As String
            Get
                Return Me.discountDateField
            End Get
            Set
                Me.discountDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If the SYSPRO supplier is a local currency supplier the value of this element is ignored and an exchange rate of 1 is always used. For foreign currency SYSPRO suppliers, the following rules apply:
        '''If this element is not supplied or a value of zero is supplied, the exchange rate against the SYSPRO currency code is used as the default.
        ''' 
        '''If this element is supplied and the SYSPRO currency code is setup with a non-fixed exchange rate, then the value against the element is used. 
        '''If this element is supplied and the SYSPRO currency code is setup with a fixed exchange rate, then the value against the element must match the exchange rate setup against the SYSPRO currency code. 
        '''</summary>
        Public Property ExchRateAtEntry() As String
            Get
                Return Me.exchRateAtEntryField
            End Get
            Set
                Me.exchRateAtEntryField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. Person to authorize the registered invoice.
        '''</summary>
        Public Property AuthorisingPerson() As String
            Get
                Return Me.authorisingPersonField
            End Get
            Set
                Me.authorisingPersonField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. Buyer code for this transaction.
        '''</summary>
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. This is the date the invoice was sent for approval. If this element is not supplied or if zeroes are entered against this element, the date used will default to the value of the 'InvoiceDate' element.
        '''</summary>
        Public Property DateInvoiceSent() As String
            Get
                Return Me.dateInvoiceSentField
            End Get
            Set
                Me.dateInvoiceSentField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. This is the department code of the department making the purchase.
        '''</summary>
        Public Property Department() As String
            Get
                Return Me.departmentField
            End Get
            Set
                Me.departmentField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element.If this element is not supplied or if zeroes are entered against this element, the date used will default to the value of the 'InvoiceDate' element.
        '''</summary>
        Public Property FollowUpDate() As String
            Get
                Return Me.followUpDateField
            End Get
            Set
                Me.followUpDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. Notes against the registered invoice transaction.
        '''</summary>
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. A set of up to twenty purchase order numbers associated with the registered invoice can be supplied.
        '''</summary>
        <System.Xml.Serialization.XmlArrayItemAttribute("PurchaseOrder", IsNullable:=false)>  _
        Public Property OrdersCollection() As List(Of String)
            Get
                Return Me.ordersField
            End Get
            Set
                Me.ordersField = value
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
    Partial Public Class Orders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As List(Of String)
        
        '''<summary>
        '''Optional element. A maximum of twenty Purchase order numbers can be associated with the registered invoice. 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("PurchaseOrder")>  _
        Public Property PurchaseOrderCollection() As List(Of String)
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
    Partial Public Class PostApRegisterInvoice
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This is the top element for all data required for the transaction.
        '''</summary>
        Public Property Item() As Item
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
                Return "APSTRI"
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
                Dim objParams As Params.PostApRegisterInvoice
                objParams = New Params.PostApRegisterInvoice
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
