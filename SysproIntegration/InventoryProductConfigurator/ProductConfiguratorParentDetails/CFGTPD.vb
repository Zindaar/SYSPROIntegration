Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorParentDetails.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostConfiguration
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostConfigurationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostConfigurationParameters
            End If
        End Sub
        
        Public Property Parameters() As PostConfigurationParameters
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
    Partial Public Class PostConfigurationParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private functionField As PostConfigurationParametersFunction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configurationInstanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostConfigurationParametersIgnoreWarnings
        
        Public Sub New()
            MyBase.New
            Me.functionField = PostConfigurationParametersFunction.N
            Me.ignoreWarningsField = PostConfigurationParametersIgnoreWarnings.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationParametersFunction.N)>  _
        Public Property [Function]() As PostConfigurationParametersFunction
            Get
                Return Me.functionField
            End Get
            Set
                Me.functionField = value
            End Set
        End Property
        
        Public Property ConfigurationInstance() As String
            Get
                Return Me.configurationInstanceField
            End Get
            Set
                Me.configurationInstanceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostConfigurationParametersIgnoreWarnings
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
    Public Enum PostConfigurationParametersFunction
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
