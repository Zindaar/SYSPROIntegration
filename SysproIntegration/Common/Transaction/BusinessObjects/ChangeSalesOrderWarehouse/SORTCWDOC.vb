Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace TransactionObjects.ChangeSOWarehouse.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostChangeSoWarehouse
        Implements Tallbridge.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of PostChangeSoWarehouseItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostChangeSoWarehouseParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostChangeSoWarehouseItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of PostChangeSoWarehouseItem)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of PostChangeSoWarehouseItem))
                Me.itemField = value
            End Set
        End Property

        ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTCW"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostChangeSoWarehouseParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostChangeSoWarehouseParameters
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
                Return doc.OuterXml
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostChangeSoWarehouse
                objParams = New Params.PostChangeSoWarehouse
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

        Public Sub Post() Implements ITransaction.Post
            _xmlOut = Transaction.Post(Me)
        End Sub

        Private _ActionTypeTrn As CommonEnums.ActionType_Transaction
        Public Property ActionTypeTrn() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionTypeTrn
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionTypeTrn = value
            End Set
        End Property

    End Class


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostChangeSoWarehouseItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private newWarehouseField As String

        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As String)
                Me.salesOrderField = value
            End Set
        End Property

        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set(ByVal value As String)
                Me.salesOrderLineField = value
            End Set
        End Property

        Public Property NewWarehouse() As String
            Get
                Return Me.newWarehouseField
            End Get
            Set(ByVal value As String)
                Me.newWarehouseField = value
            End Set
        End Property
    End Class
End Namespace
