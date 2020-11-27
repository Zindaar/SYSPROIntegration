Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ContactManagementPrimaryPosting.ContactPostContact.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostContact
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostContactParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostContactParameters
            End If
        End Sub
        
        Public Property Parameters() As PostContactParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostContactParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostContactParametersActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactIdTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysApplyAllField As String
        
        Public Sub New()
            MyBase.New
            Me.actionTypeField = PostContactParametersActionType.A
            Me.alwaysApplyAllField = "Y"
        End Sub
        
        Public Property ActionType() As PostContactParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
            End Set
        End Property
        
        Public Property ContactIdType() As String
            Get
                Return Me.contactIdTypeField
            End Get
            Set
                Me.contactIdTypeField = value
            End Set
        End Property
        
        Public Property AlwaysApplyAll() As String
            Get
                Return Me.alwaysApplyAllField
            End Get
            Set
                Me.alwaysApplyAllField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostContactParametersActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
End Namespace
