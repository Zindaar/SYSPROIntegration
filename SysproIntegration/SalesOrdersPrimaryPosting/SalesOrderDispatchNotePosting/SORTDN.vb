Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderDispatchNotePosting.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostDispatchNotesParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostDispatchNotesParameters
            End If
        End Sub
        
        Public Property Parameters() As PostDispatchNotesParameters
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
    Partial Public Class PostDispatchNotesParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostDispatchNotesParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostDispatchNotesParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private basisForDispatchField As PostDispatchNotesParametersBasisForDispatch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonMerchandiseSourceField As PostDispatchNotesParametersNonMerchandiseSource
        
        Public Sub New()
            MyBase.New
            Me.validateOnlyField = PostDispatchNotesParametersValidateOnly.N
            Me.ignoreWarningsField = PostDispatchNotesParametersIgnoreWarnings.N
            Me.basisForDispatchField = PostDispatchNotesParametersBasisForDispatch.B
            Me.nonMerchandiseSourceField = PostDispatchNotesParametersNonMerchandiseSource.I
        End Sub
        
        '<System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostDispatchNotesParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As PostDispatchNotesParametersValidateOnly)
                Me.validateOnlyField = Value
            End Set
        End Property
        
        '<System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostDispatchNotesParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(ByVal value As PostDispatchNotesParametersIgnoreWarnings)
                Me.ignoreWarningsField = Value
            End Set
        End Property
        
        '<System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersBasisForDispatch.B)>  _
        Public Property BasisForDispatch() As PostDispatchNotesParametersBasisForDispatch
            Get
                Return Me.basisForDispatchField
            End Get
            Set(ByVal value As PostDispatchNotesParametersBasisForDispatch)
                Me.basisForDispatchField = Value
            End Set
        End Property
        
        '<System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersNonMerchandiseSource.I)>  _
        Public Property NonMerchandiseSource() As PostDispatchNotesParametersNonMerchandiseSource
            Get
                Return Me.nonMerchandiseSourceField
            End Get
            Set(ByVal value As PostDispatchNotesParametersNonMerchandiseSource)
                Me.nonMerchandiseSourceField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesParametersIgnoreWarnings
        
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
    Public Enum PostDispatchNotesParametersBasisForDispatch
        
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
    Public Enum PostDispatchNotesParametersNonMerchandiseSource
        
        '''<remarks/>
        I
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
