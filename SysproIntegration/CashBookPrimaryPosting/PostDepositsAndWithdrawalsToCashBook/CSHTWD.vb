Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace CashBookPrimaryPosting.PostDepositsAndWithdrawalsToCashBook.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostCbDepositsWithdrawals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostCbDepositsWithdrawalsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostCbDepositsWithdrawalsParameters
            End If
        End Sub
        
        Public Property Parameters() As PostCbDepositsWithdrawalsParameters
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
    Partial Public Class PostCbDepositsWithdrawalsParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostCbDepositsWithdrawalsParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostCbDepositsWithdrawalsParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostCbDepositsWithdrawalsParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostCbDepositsWithdrawalsParametersValidateOnly
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostCbDepositsWithdrawalsParametersPostingPeriod.C
            Me.ignoreWarningsField = PostCbDepositsWithdrawalsParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostCbDepositsWithdrawalsParametersApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = PostCbDepositsWithdrawalsParametersValidateOnly.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostCbDepositsWithdrawalsParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostCbDepositsWithdrawalsParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsParametersApplyIfEntireDocumentValid.Y)>  _
        Public Property ApplyIfEntireDocumentValid() As PostCbDepositsWithdrawalsParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostCbDepositsWithdrawalsParametersValidateOnly
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
    Public Enum PostCbDepositsWithdrawalsParametersPostingPeriod
        
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
    Public Enum PostCbDepositsWithdrawalsParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsParametersValidateOnly
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
