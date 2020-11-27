Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.CreditNoteFromExistingInvoiceDispatchNote.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostCreditFromInvoice
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostCreditFromInvoiceItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostCreditFromInvoiceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostCreditFromInvoiceItem
            End If
        End Sub
        
        Public Property Item() As PostCreditFromInvoiceItem
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
                Return "SORTCI"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostCreditFromInvoiceParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostCreditFromInvoiceParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostCreditFromInvoice
                objParams = New Params.PostCreditFromInvoice
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCreditFromInvoiceItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditReasonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private linesField As List(Of PostCreditFromInvoiceItemLines)
        
        Public Sub New()
            MyBase.New
            If (Me.linesField Is Nothing) Then
                Me.linesField = New List(Of PostCreditFromInvoiceItemLines)
            End If
        End Sub
        
        Public Property CreditNoteNumber() As String
            Get
                Return Me.creditNoteNumberField
            End Get
            Set
                Me.creditNoteNumberField = value
            End Set
        End Property
        
        Public Property InvoiceNumber() As String
            Get
                Return Me.invoiceNumberField
            End Get
            Set
                Me.invoiceNumberField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property CreditReason() As String
            Get
                Return Me.creditReasonField
            End Get
            Set
                Me.creditReasonField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Lines")> _
        Public Property Lines() As List(Of PostCreditFromInvoiceItemLines)
            Get
                Return Me.linesField
            End Get
            Set(value As List(Of PostCreditFromInvoiceItemLines))
                Me.linesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCreditFromInvoiceItemLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchLineNumberField As String
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
            End Set
        End Property
        
        Public Property DispatchNote() As String
            Get
                Return Me.dispatchNoteField
            End Get
            Set
                Me.dispatchNoteField = value
            End Set
        End Property
        
        Public Property DispatchLineNumber() As String
            Get
                Return Me.dispatchLineNumberField
            End Get
            Set
                Me.dispatchLineNumberField = value
            End Set
        End Property
    End Class
End Namespace
