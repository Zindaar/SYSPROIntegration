Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipShopFloorDataCollection.WipSpecificIssues.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostMaterial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostMaterialParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostMaterialParameters
            End If
        End Sub
        
        Public Property Parameters() As PostMaterialParameters
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
    Partial Public Class PostMaterialParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateField As System.Nullable(Of Date)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostMaterialParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostMaterialParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostMaterialParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostMaterialParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoDepleteLotsBinsField As PostMaterialParametersAutoDepleteLotsBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postFloorstockField As PostMaterialParametersPostFloorstock
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostMaterialParametersPostingPeriod.C
            Me.applyIfEntireDocumentValidField = PostMaterialParametersApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = PostMaterialParametersValidateOnly.N
            Me.ignoreWarningsField = PostMaterialParametersIgnoreWarnings.N
            Me.autoDepleteLotsBinsField = PostMaterialParametersAutoDepleteLotsBins.N
            Me.postFloorstockField = PostMaterialParametersPostFloorstock.N
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date", IsNullable:=true)>  _
        Public Property TransactionDate() As System.Nullable(Of Date)
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
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostMaterialParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersApplyIfEntireDocumentValid.Y)>  _
        Public Property ApplyIfEntireDocumentValid() As PostMaterialParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostMaterialParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostMaterialParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersAutoDepleteLotsBins.N)>  _
        Public Property AutoDepleteLotsBins() As PostMaterialParametersAutoDepleteLotsBins
            Get
                Return Me.autoDepleteLotsBinsField
            End Get
            Set
                Me.autoDepleteLotsBinsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostMaterialParametersPostFloorstock.N)>  _
        Public Property PostFloorstock() As PostMaterialParametersPostFloorstock
            Get
                Return Me.postFloorstockField
            End Get
            Set
                Me.postFloorstockField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMaterialParametersPostingPeriod
        
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
    Public Enum PostMaterialParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMaterialParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMaterialParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMaterialParametersAutoDepleteLotsBins
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostMaterialParametersPostFloorstock
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
