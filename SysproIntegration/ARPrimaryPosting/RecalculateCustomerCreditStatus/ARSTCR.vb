Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryPosting.RecalculateCustomerCreditStatus.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.N
            Me.postingPeriodField = PostingPeriod.C
        End Sub
        
        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings such as "Document value is zero". (N - No, Y - Yes) If not supplied it defaults to 'N'. 
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
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
        
        '''<summary>
        '''Specifies whether the entire document must be validated first before applying the function (N - apply function for each valid item, Y - all items must be valid before function is applied). If not supplied it defaults to 'Y'.
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
                Me.ApplyIfEntireDocumentValidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document). If not supplied it defaults to 'N'.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
                Me.ValidateOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies the period to which the transaction must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2).
        '''</summary>
        Public Property PostingPeriod() As PostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
                Me.PostingPeriodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PostingPeriodSpecified() As Boolean
            Get
                Return Me.postingPeriodFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PostingPeriod
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ArCreditCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This contains parameters
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
