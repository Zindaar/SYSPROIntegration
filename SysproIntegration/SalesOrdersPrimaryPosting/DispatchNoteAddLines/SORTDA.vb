Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.DispatchNoteAddLines.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchNoteLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostDispatchNoteLinesParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostDispatchNoteLinesParameters
            End If
        End Sub
        
        Public Property Parameters() As PostDispatchNoteLinesParameters
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
    Partial Public Class PostDispatchNoteLinesParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostDispatchNoteLinesParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostDispatchNoteLinesParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostDispatchNoteLinesParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private basisForDispatchField As PostDispatchNoteLinesParametersBasisForDispatch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreAutoDepletionField As PostDispatchNoteLinesParametersIgnoreAutoDepletion
        
        Public Sub New()
            MyBase.New
            Me.validateOnlyField = PostDispatchNoteLinesParametersValidateOnly.N
            Me.applyIfEntireDocumentValidField = PostDispatchNoteLinesParametersApplyIfEntireDocumentValid.N
            Me.ignoreWarningsField = PostDispatchNoteLinesParametersIgnoreWarnings.N
            Me.basisForDispatchField = PostDispatchNoteLinesParametersBasisForDispatch.B
            Me.ignoreAutoDepletionField = PostDispatchNoteLinesParametersIgnoreAutoDepletion.N
        End Sub
        
        '<System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostDispatchNoteLinesParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(value As PostDispatchNoteLinesParametersValidateOnly)
                Me.validateOnlyField = Value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostDispatchNoteLinesParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostDispatchNoteLinesParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesParametersBasisForDispatch.B)>  _
        Public Property BasisForDispatch() As PostDispatchNoteLinesParametersBasisForDispatch
            Get
                Return Me.basisForDispatchField
            End Get
            Set
                Me.basisForDispatchField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesParametersIgnoreAutoDepletion.N)>  _
        Public Property IgnoreAutoDepletion() As PostDispatchNoteLinesParametersIgnoreAutoDepletion
            Get
                Return Me.ignoreAutoDepletionField
            End Get
            Set
                Me.ignoreAutoDepletionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesParametersIgnoreWarnings
        
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
    Public Enum PostDispatchNoteLinesParametersBasisForDispatch
        
        '''<remarks/>
        B
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesParametersIgnoreAutoDepletion
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
