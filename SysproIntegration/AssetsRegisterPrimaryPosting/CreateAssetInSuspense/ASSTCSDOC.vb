Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryPosting.CreateAssetInSuspense.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostAssetCapexSuspense
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostAssetCapexSuspenseItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostAssetCapexSuspenseParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostAssetCapexSuspenseItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostAssetCapexSuspenseItem)
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
                Return "ASSTCS"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostAssetCapexSuspenseParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostAssetCapexSuspenseParameters
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
                Dim objParams As Params.PostAssetCapexSuspense
                objParams = New Params.PostAssetCapexSuspense
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostAssetCapexSuspenseItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createdFromFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createdFromKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private spentField As String
        
        Public Property CapexCode() As String
            Get
                Return Me.capexCodeField
            End Get
            Set
                Me.capexCodeField = value
            End Set
        End Property
        
        Public Property CapexLine() As String
            Get
                Return Me.capexLineField
            End Get
            Set
                Me.capexLineField = value
            End Set
        End Property
        
        Public Property PurchaseDate() As String
            Get
                Return Me.purchaseDateField
            End Get
            Set
                Me.purchaseDateField = value
            End Set
        End Property
        
        Public Property CreatedFromFlag() As String
            Get
                Return Me.createdFromFlagField
            End Get
            Set
                Me.createdFromFlagField = value
            End Set
        End Property
        
        Public Property CreatedFromKey() As String
            Get
                Return Me.createdFromKeyField
            End Get
            Set
                Me.createdFromKeyField = value
            End Set
        End Property
        
        Public Property Qty() As String
            Get
                Return Me.qtyField
            End Get
            Set
                Me.qtyField = value
            End Set
        End Property
        
        Public Property Spent() As String
            Get
                Return Me.spentField
            End Get
            Set
                Me.spentField = value
            End Set
        End Property
    End Class
End Namespace
