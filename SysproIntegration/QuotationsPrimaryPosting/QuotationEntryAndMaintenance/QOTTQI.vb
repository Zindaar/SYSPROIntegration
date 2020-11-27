Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostQuotation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostQuotationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostQuotationParameters
            End If
        End Sub
        
        Public Property Parameters() As PostQuotationParameters
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
    Partial Public Class PostQuotationParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostQuotationParametersActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostQuotationParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostQuotationParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostQuotationParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateWorkingDaysField As PostQuotationParametersValidateWorkingDays
        
        Public Sub New()
            MyBase.New
            Me.actionTypeField = PostQuotationParametersActionType.A
            Me.validateOnlyField = PostQuotationParametersValidateOnly.N
            Me.ignoreWarningsField = PostQuotationParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostQuotationParametersApplyIfEntireDocumentValid.N
            Me.validateWorkingDaysField = PostQuotationParametersValidateWorkingDays.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationParametersActionType.A)>  _
        Public Property ActionType() As PostQuotationParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostQuotationParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostQuotationParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostQuotationParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostQuotationParametersValidateWorkingDays.N)>  _
        Public Property ValidateWorkingDays() As PostQuotationParametersValidateWorkingDays
            Get
                Return Me.validateWorkingDaysField
            End Get
            Set
                Me.validateWorkingDaysField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationParametersActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostQuotationParametersValidateWorkingDays
        
        '''<remarks/>
        N
        
        '''<remarks/>
        A
        
        '''<remarks/>
        P
    End Enum
End Namespace
