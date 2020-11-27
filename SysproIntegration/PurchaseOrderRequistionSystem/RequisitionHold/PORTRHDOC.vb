Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionHold.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userPasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonField As String
        
        '''<summary>
        '''The user who is placing the requisition on hold, or releasing the requisition from hold. If the user is not supplied then the user associated with the operator will be assumed. The user must be valid.
        '''The user must be the owner or current holder to place a requisition on hold. To release a requisition the user must be the one who placed it on hold in the first instance.
        '''</summary>
        Public Property User() As String
            Get
                Return Me.userField
            End Get
            Set
                Me.userField = value
            End Set
        End Property
        
        '''<summary>
        '''The password associated with the user. The password is only required to be supplied if the user element was supplied and it differs from the user associated with the operator default. 
        '''</summary>
        Public Property UserPassword() As String
            Get
                Return Me.userPasswordField
            End Get
            Set
                Me.userPasswordField = value
            End Set
        End Property
        
        '''<summary>
        '''The requisition to be held/released. All lines of a requisition can be held/released by setting the RequisitionLine to be zero.
        '''</summary>
        Public Property RequisitionNumber() As String
            Get
                Return Me.requisitionNumberField
            End Get
            Set
                Me.requisitionNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The line number of the requisition to be held/released. Set this element to be zero (or blank) if all lines for the requisition are to be held/released.
        '''</summary>
        Public Property RequisitionLine() As String
            Get
                Return Me.requisitionLineField
            End Get
            Set
                Me.requisitionLineField = value
            End Set
        End Property
        
        '''<summary>
        '''A description of the reason for placing the requisition on hold. This element must be non-blank when placing a requisition on hold.
        '''This element is not required when releasing requisitions.
        '''</summary>
        Public Property Reason() As String
            Get
                Return Me.reasonField
            End Get
            Set
                Me.reasonField = value
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
    Partial Public Class PostReqHold
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
                Return "PORTRH"
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
                Dim objParams As Params.PostReqHold
                objParams = New Params.PostReqHold
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
