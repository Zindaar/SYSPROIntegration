Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.CreditNoteFromExistingInvoiceDispatchNote.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostCreditFromInvoice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostCreditFromInvoiceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostCreditFromInvoiceParameters
            End If
        End Sub
        
        Public Property Parameters() As PostCreditFromInvoiceParameters
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
    Partial Public Class PostCreditFromInvoiceParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostCreditFromInvoiceParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostCreditFromInvoiceParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostCreditFromInvoiceParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addAttachedLinesField As PostCreditFromInvoiceParametersAddAttachedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addZeroRemainingLinesField As PostCreditFromInvoiceParametersAddZeroRemainingLines
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostCreditFromInvoiceParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostCreditFromInvoiceParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostCreditFromInvoiceParametersValidateOnly.N
            Me.addAttachedLinesField = PostCreditFromInvoiceParametersAddAttachedLines.N
            Me.addZeroRemainingLinesField = PostCreditFromInvoiceParametersAddZeroRemainingLines.N
        End Sub
        
        Public Property DocumentDate() As String
            Get
                Return Me.documentDateField
            End Get
            Set
                Me.documentDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCreditFromInvoiceParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostCreditFromInvoiceParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCreditFromInvoiceParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostCreditFromInvoiceParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCreditFromInvoiceParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostCreditFromInvoiceParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCreditFromInvoiceParametersAddAttachedLines.N)>  _
        Public Property AddAttachedLines() As PostCreditFromInvoiceParametersAddAttachedLines
            Get
                Return Me.addAttachedLinesField
            End Get
            Set
                Me.addAttachedLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCreditFromInvoiceParametersAddZeroRemainingLines.N)>  _
        Public Property AddZeroRemainingLines() As PostCreditFromInvoiceParametersAddZeroRemainingLines
            Get
                Return Me.addZeroRemainingLinesField
            End Get
            Set
                Me.addZeroRemainingLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCreditFromInvoiceParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCreditFromInvoiceParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCreditFromInvoiceParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCreditFromInvoiceParametersAddAttachedLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCreditFromInvoiceParametersAddZeroRemainingLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
    End Enum
End Namespace
