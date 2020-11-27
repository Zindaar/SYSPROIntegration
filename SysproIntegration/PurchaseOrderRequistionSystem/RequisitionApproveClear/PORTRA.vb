Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionApproveClear.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostReqApprove
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostReqApproveParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostReqApproveParameters
            End If
        End Sub
        
        Public Property Parameters() As PostReqApproveParameters
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
    Partial Public Class PostReqApproveParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostReqApproveParametersActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostReqApproveParametersIgnoreWarnings
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostReqApproveParametersIgnoreWarnings.Y
        End Sub
        
        Public Property ActionType() As PostReqApproveParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
                Me.ActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ActionTypeSpecified() As Boolean
            Get
                Return Me.actionTypeFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostReqApproveParametersIgnoreWarnings.Y)>  _
        Public Property IgnoreWarnings() As PostReqApproveParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostReqApproveParametersActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostReqApproveParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        W
    End Enum
End Namespace
