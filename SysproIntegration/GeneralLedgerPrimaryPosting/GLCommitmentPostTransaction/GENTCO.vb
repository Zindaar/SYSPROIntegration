Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.GLCommitmentPostTransaction.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostGlCommitments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostGlCommitmentsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostGlCommitmentsParameters
            End If
        End Sub
        
        Public Property Parameters() As PostGlCommitmentsParameters
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
    Partial Public Class PostGlCommitmentsParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostGlCommitmentsParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostGlCommitmentsParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostGlCommitmentsParametersValidateOnly
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostGlCommitmentsParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostGlCommitmentsParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostGlCommitmentsParametersValidateOnly.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostGlCommitmentsParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostGlCommitmentsParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostGlCommitmentsParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostGlCommitmentsParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostGlCommitmentsParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostGlCommitmentsParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlCommitmentsParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlCommitmentsParametersApplyIfEntireDocumentValid
        
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
    Public Enum PostGlCommitmentsParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
