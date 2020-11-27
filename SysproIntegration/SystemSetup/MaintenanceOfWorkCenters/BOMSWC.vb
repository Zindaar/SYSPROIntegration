Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.MaintenanceOfWorkCenters.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupBomWorkCentre
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As SetupBomWorkCentreParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New SetupBomWorkCentreParameters
            End If
        End Sub
        
        Public Property Parameters() As SetupBomWorkCentreParameters
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
    Partial Public Class SetupBomWorkCentreParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As SetupBomWorkCentreParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As SetupBomWorkCentreParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As SetupBomWorkCentreParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triggerApsField As SetupBomWorkCentreParametersTriggerAps
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = SetupBomWorkCentreParametersIgnoreWarnings.Y
            Me.applyIfEntireDocumentValidField = SetupBomWorkCentreParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = SetupBomWorkCentreParametersValidateOnly.N
            Me.triggerApsField = SetupBomWorkCentreParametersTriggerAps.Y
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreParametersIgnoreWarnings.Y)>  _
        Public Property IgnoreWarnings() As SetupBomWorkCentreParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As SetupBomWorkCentreParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As SetupBomWorkCentreParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreParametersTriggerAps.Y)>  _
        Public Property TriggerAps() As SetupBomWorkCentreParametersTriggerAps
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
    Public Enum SetupBomWorkCentreParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreParametersTriggerAps
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
