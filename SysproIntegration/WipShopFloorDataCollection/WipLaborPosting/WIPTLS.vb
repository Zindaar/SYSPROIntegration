Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipShopFloorDataCollection.WipTrackLotsAndSerials.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostTracking

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As PostTrackingParameters

        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostTrackingParameters
            End If
        End Sub

        Public Property Parameters() As PostTrackingParameters
            Get
                Return Me.parametersField
            End Get
            Set(ByVal value As PostTrackingParameters)
                Me.parametersField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostTrackingParameters

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As PostTrackingParametersValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidField As PostTrackingParametersApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsField As PostTrackingParametersIgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private actionTypeField As PostTrackingParametersActionType

        Public Sub New()
            MyBase.New()
            Me.validateOnlyField = PostTrackingParametersValidateOnly.N
            Me.applyIfEntireDocumentValidField = PostTrackingParametersApplyIfEntireDocumentValid.N
            Me.ignoreWarningsField = PostTrackingParametersIgnoreWarnings.N
            Me.actionTypeField = PostTrackingParametersActionType.T
        End Sub

        <System.ComponentModel.DefaultValueAttribute(PostTrackingParametersValidateOnly.N)> _
        Public Property ValidateOnly() As PostTrackingParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As PostTrackingParametersValidateOnly)
                Me.validateOnlyField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostTrackingParametersApplyIfEntireDocumentValid.N)> _
        Public Property ApplyIfEntireDocumentValid() As PostTrackingParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set(ByVal value As PostTrackingParametersApplyIfEntireDocumentValid)
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostTrackingParametersIgnoreWarnings.N)> _
        Public Property IgnoreWarnings() As PostTrackingParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(ByVal value As PostTrackingParametersIgnoreWarnings)
                Me.ignoreWarningsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostTrackingParametersActionType.T)> _
        Public Property ActionType() As PostTrackingParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set(ByVal value As PostTrackingParametersActionType)
                Me.actionTypeField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostTrackingParametersValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostTrackingParametersApplyIfEntireDocumentValid

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostTrackingParametersIgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostTrackingParametersActionType

        '''<remarks/>
        T

        '''<remarks/>
        C

        '''<remarks/>
        D
    End Enum
End Namespace
