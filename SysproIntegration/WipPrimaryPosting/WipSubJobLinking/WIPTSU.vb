Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.WipSubJobLinking.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostMasterSubJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostMasterSubJobParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostMasterSubJobParameters
            End If
        End Sub
        
        Public Property Parameters() As PostMasterSubJobParameters
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
    Partial Public Class PostMasterSubJobParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostMasterSubJobParametersActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostMasterSubJobParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostMasterSubJobParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triggerApsField As PostMasterSubJobParametersTriggerAps
        
        Public Sub New()
            MyBase.New
            Me.actionTypeField = PostMasterSubJobParametersActionType.A
            Me.validateOnlyField = PostMasterSubJobParametersValidateOnly.N
            Me.triggerApsField = PostMasterSubJobParametersTriggerAps.Y
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostMasterSubJobParametersActionType.A)>  _
        Public Property ActionType() As PostMasterSubJobParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMasterSubJobParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostMasterSubJobParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        Public Property IgnoreWarnings() As PostMasterSubJobParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
                Me.IgnoreWarningsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMasterSubJobParametersTriggerAps.Y)>  _
        Public Property TriggerAps() As PostMasterSubJobParametersTriggerAps
            Get
                Return Me.triggerApsField
            End Get
            Set
                Me.triggerApsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMasterSubJobParametersActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMasterSubJobParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMasterSubJobParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMasterSubJobParametersTriggerAps
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
