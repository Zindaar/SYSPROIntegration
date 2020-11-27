Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesAnalysis.LostSalesPosting.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostLostSales
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As PostLostSalesParameters
        
        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostLostSalesParameters
            End If
        End Sub

        Public Property Parameters() As PostLostSalesParameters
            Get
                Return Me.parametersField
            End Get
            Set(value As PostLostSalesParameters)
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLostSalesParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostLostSalesParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostLostSalesParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostLostSalesParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteEntriesField As PostLostSalesParametersDeleteEntries
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostLostSalesParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostLostSalesParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostLostSalesParametersValidateOnly.N
            Me.deleteEntriesField = PostLostSalesParametersDeleteEntries.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostLostSalesParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostLostSalesParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostLostSalesParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property TransactionDate() As Date
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = value
                Me.TransactionDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TransactionDateSpecified() As Boolean
            Get
                Return Me.transactionDateFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersDeleteEntries.N)>  _
        Public Property DeleteEntries() As PostLostSalesParametersDeleteEntries
            Get
                Return Me.deleteEntriesField
            End Get
            Set
                Me.deleteEntriesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLostSalesParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLostSalesParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLostSalesParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLostSalesParametersDeleteEntries
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
