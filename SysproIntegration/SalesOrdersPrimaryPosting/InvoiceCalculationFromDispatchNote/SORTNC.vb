Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.InvoiceCalculationFromDispatchNote.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchInvoice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostDispatchInvoiceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostDispatchInvoiceParameters
            End If
        End Sub
        
        Public Property Parameters() As PostDispatchInvoiceParameters
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
    Partial Public Class PostDispatchInvoiceParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostDispatchInvoiceParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostDispatchInvoiceParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostDispatchInvoiceParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostDispatchInvoiceParametersValidateOnly
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostDispatchInvoiceParametersPostingPeriod.C
            Me.ignoreWarningsField = PostDispatchInvoiceParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostDispatchInvoiceParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostDispatchInvoiceParametersValidateOnly.N
        End Sub
        
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set
                Me.invoiceDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchInvoiceParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostDispatchInvoiceParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchInvoiceParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostDispatchInvoiceParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchInvoiceParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostDispatchInvoiceParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchInvoiceParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostDispatchInvoiceParametersValidateOnly
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
    Public Enum PostDispatchInvoiceParametersPostingPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchInvoiceParametersIgnoreWarnings
        
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
    Public Enum PostDispatchInvoiceParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchInvoiceParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
