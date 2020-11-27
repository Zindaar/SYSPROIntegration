Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.CustomFormSetup.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupCustomForm
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of SetupCustomFormItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupCustomFormParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of SetupCustomFormItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of SetupCustomFormItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set
                Me._setupActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "COMSFM"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupCustomFormParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupCustomFormParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.XmlParam
            Get
                Dim objParams As Params.SetupCustomForm
                objParams = New Params.SetupCustomForm
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ISetup.Post
            If (Me._setupActionTypeField = CommonEnums.ActionType_Setup.Add) Then
                Me._xmlOut = SetupObject.Add(Me)
            End If
            If (Me._setupActionTypeField = CommonEnums.ActionType_Setup.Update) Then
                Me._xmlOut = SetupObject.Update(Me)
            End If
            If (Me._setupActionTypeField = CommonEnums.ActionType_Setup.Delete) Then
                Me._xmlOut = SetupObject.Delete(Me)
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XMLParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupCustomFormItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupCustomFormItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alphaValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numericValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateValueField As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupCustomFormItemKey
            End If
        End Sub
        
        Public Property Key() As SetupCustomFormItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property AlphaValue() As String
            Get
                Return Me.alphaValueField
            End Get
            Set
                Me.alphaValueField = value
            End Set
        End Property
        
        Public Property NumericValue() As String
            Get
                Return Me.numericValueField
            End Get
            Set
                Me.numericValueField = value
            End Set
        End Property
        
        Public Property DateValue() As String
            Get
                Return Me.dateValueField
            End Get
            Set
                Me.dateValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupCustomFormItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyFieldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fieldNameField As String
        
        Public Property FormType() As String
            Get
                Return Me.formTypeField
            End Get
            Set
                Me.formTypeField = value
            End Set
        End Property
        
        Public Property KeyField() As String
            Get
                Return Me.keyFieldField
            End Get
            Set
                Me.keyFieldField = value
            End Set
        End Property
        
        Public Property FieldName() As String
            Get
                Return Me.fieldNameField
            End Get
            Set
                Me.fieldNameField = value
            End Set
        End Property
    End Class
End Namespace
