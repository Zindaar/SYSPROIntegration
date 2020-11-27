Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemPosting.CustomFormPost.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostCustomForm
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostCustomFormParameters

       
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "COMTFM"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostCustomFormParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostCustomFormParameters()
                End If
                Return Me._params
            End Get
        End Property

        Private _xmlData As String
        Public Overridable WriteOnly Property XMLDataIn As String
            Set(value As String)
                _xmlData = value
            End Set
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return _xmlData
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostCustomForm
                objParams = New Params.PostCustomForm()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams).Replace("Function xsi:type=""xsd:string""", "Function")
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    
End Namespace
