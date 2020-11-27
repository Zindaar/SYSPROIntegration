Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ChangeFwdOrderToSched
        
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As OrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newOrderStatusField As NewOrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditAuthorityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateDeliveryNotePrintedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeDeliveryNotePrintedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceNumberEnteredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateEnteredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sctReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeFwdOrderToSchedField As ChangeFwdOrderToSched
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeFwdOrderToSchedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.changeFwdOrderToSchedField = ChangeFwdOrderToSched.N
        End Sub
        
        '''<summary>
        '''This element is mandatory and must contain a valid sales order number.
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. If entered, then it must contain the current status of the order selected.
        '''</summary>
        Public Property OrderStatus() As OrderStatus
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
                Me.OrderStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderStatusSpecified() As Boolean
            Get
                Return Me.orderStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory. It must contain the new status for the selected sales order. The SYSPRO configuration rules will be used to validate the correct combination of existing order type and status, and the new order status requested. 
        '''Valid status codes for a sales order are:-
        '''1 - Open order,
        '''2 - Open back order,
        '''3 - Released back order,
        '''4 - In warehouse (delivery note printed),
        '''8 - Released for invoicing (or ready to transfer for an SCT),
        '''9 - Complete,
        '''S - In suspense.
        '''</summary>
        Public Property NewOrderStatus() As NewOrderStatus
            Get
                Return Me.newOrderStatusField
            End Get
            Set
                Me.newOrderStatusField = value
            End Set
        End Property
        
        '''<summary>
        '''This element must contain a credit authority entry if the order is being released from suspense.
        '''</summary>
        Public Property CreditAuthority() As String
            Get
                Return Me.creditAuthorityField
            End Get
            Set
                Me.creditAuthorityField = value
            End Set
        End Property
        
        '''<summary>
        '''The delivery note number may only be supplied if the sales order is to be changed to a status of 4. It may only be supplied if the SYSPRO configuration rules allow it to be supplied. The entry must follow the SYSPRO configuration rules for the type of delivery note number.
        '''</summary>
        Public Property DeliveryNoteNumber() As String
            Get
                Return Me.deliveryNoteNumberField
            End Get
            Set
                Me.deliveryNoteNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The date delivery note printed may only be supplied if the sales order is to be changed to a status of 4. The format is CCYY-MM-DD. If not supplied then the current date will be used.
        '''</summary>
        Public Property DateDeliveryNotePrinted() As String
            Get
                Return Me.dateDeliveryNotePrintedField
            End Get
            Set
                Me.dateDeliveryNotePrintedField = value
            End Set
        End Property
        
        '''<summary>
        '''The time delivery note printed may only be supplied if the sales order is to be changed to a status of 4. The format is HH:MM:SS.ddd.  Only the HH:MM portion is required. If not supplied then the current time will be used.
        '''</summary>
        Public Property TimeDeliveryNotePrinted() As String
            Get
                Return Me.timeDeliveryNotePrintedField
            End Get
            Set
                Me.timeDeliveryNotePrintedField = value
            End Set
        End Property
        
        '''<summary>
        '''The invoice number may only be supplied if the sales order is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The entry must follow the SYSPRO configuration rules for the type of invoice number.
        '''</summary>
        Public Property InvoiceNumberEntered() As String
            Get
                Return Me.invoiceNumberEnteredField
            End Get
            Set
                Me.invoiceNumberEnteredField = value
            End Set
        End Property
        
        '''<summary>
        '''The invoice date may only be supplied if the sales order is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The format is CCYY-MM-DD.
        '''</summary>
        Public Property InvoiceDateEntered() As String
            Get
                Return Me.invoiceDateEnteredField
            End Get
            Set
                Me.invoiceDateEnteredField = value
            End Set
        End Property
        
        '''<summary>
        '''The SCT reference may only be supplied if the sales order is an SCT order, and is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The entry must follow the SYSPRO configuration rules for the type of SCT reference number.
        '''</summary>
        Public Property SctReference() As String
            Get
                Return Me.sctReferenceField
            End Get
            Set
                Me.sctReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only required when changing the status of a forward order. The valid entries are N (the default) and Y. If set to Y then the forward order will be converted to a scheduled order.
        '''</summary>
        Public Property ChangeFwdOrderToSched() As ChangeFwdOrderToSched
            Get
                Return Me.changeFwdOrderToSchedField
            End Get
            Set
                Me.changeFwdOrderToSchedField = value
                Me.ChangeFwdOrderToSchedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChangeFwdOrderToSchedSpecified() As Boolean
            Get
                Return Me.changeFwdOrderToSchedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If required, this element must contain a GUID, for the eSignature system to accept the transaction as having been authenticated. The GUID format is in the format {36303032-3330-3031-3038-323434363433}, where the numbers can be replaced with any character. It is up to the developer to have requested a password to protect the transaction. An example is that a GUID associated with the act of entering a valid password could be obtained and presented.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderStatus
        
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
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        F
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum NewOrderStatus
        
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
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("9")> _
        Item9
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSorOrderStatus
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New Item
            End If
        End Sub
        
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
                Return "SORTOS"
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
                Dim objParams As Params.PostSorOrderStatus
                objParams = New Params.PostSorOrderStatus
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
