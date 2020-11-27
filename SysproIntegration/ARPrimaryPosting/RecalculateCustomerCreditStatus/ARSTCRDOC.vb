Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryPosting.RecalculateCustomerCreditStatus.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ArCreditCheck
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
                Return "ARSTCR"
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
                Dim objParams As Params.ArCreditCheck
                objParams = New Params.ArCreditCheck
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionMethodField As List(Of TransactionMethod)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerFromField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerToField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.customerToField Is Nothing) Then
                Me.customerToField = New List(Of String)
            End If
            If (Me.customerFromField Is Nothing) Then
                Me.customerFromField = New List(Of String)
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New List(Of String)
            End If
            If (Me.transactionMethodField Is Nothing) Then
                Me.transactionMethodField = New List(Of TransactionMethod)
            End If
        End Sub
        
        '''<summary>
        '''Mandatory element.  Enter the transaction method. 'S' = query single customer, 'R' = Query a range of customers
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("TransactionMethod")>  _
        Public Property TransactionMethodCollection() As List(Of TransactionMethod)
            Get
                Return Me.transactionMethodField
            End Get
            Set
                Me.transactionMethodField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. NB: This element is mandatory if 'S' TransactionMethod is selected. Enter the SYSPRO customer applicable to the transaction. This must be a valid SYSPRO customer.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Customer")>  _
        Public Property CustomerCollection() As List(Of String)
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If "R" TransactionMethod is used, this will be used to query and post the transction starting with the customer that is equal or greater that this input. 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("CustomerFrom")>  _
        Public Property CustomerFromCollection() As List(Of String)
            Get
                Return Me.customerFromField
            End Get
            Set
                Me.customerFromField = value
            End Set
        End Property
        
        '''<summary>
        '''Optional element. If "R" TransactionMethod is used, this will be used to query and post the transction up until the customer that is equal or greater that this input. 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("CustomerTo")>  _
        Public Property CustomerToCollection() As List(Of String)
            Get
                Return Me.customerToField
            End Get
            Set
                Me.customerToField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TransactionMethod
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
    End Enum
End Namespace
