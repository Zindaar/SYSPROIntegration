Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.GoodsInTransitTransferCreationFromDispatchNotes.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchTransfer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostDispatchTransferParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostDispatchTransferParameters
            End If
        End Sub
        
        Public Property Parameters() As PostDispatchTransferParameters
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
    Partial Public Class PostDispatchTransferParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transferDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostDispatchTransferParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostDispatchTransferParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostDispatchTransferParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostDispatchTransferParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateAllLinesField As PostDispatchTransferParametersValidateAllLines
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostDispatchTransferParametersPostingPeriod.C
            Me.ignoreWarningsField = PostDispatchTransferParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostDispatchTransferParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostDispatchTransferParametersValidateOnly.N
            Me.validateAllLinesField = PostDispatchTransferParametersValidateAllLines.N
        End Sub
        
        Public Property TransferDate() As String
            Get
                Return Me.transferDateField
            End Get
            Set
                Me.transferDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchTransferParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostDispatchTransferParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchTransferParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostDispatchTransferParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchTransferParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostDispatchTransferParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchTransferParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostDispatchTransferParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchTransferParametersValidateAllLines.N)>  _
        Public Property ValidateAllLines() As PostDispatchTransferParametersValidateAllLines
            Get
                Return Me.validateAllLinesField
            End Get
            Set
                Me.validateAllLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchTransferParametersPostingPeriod
        
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
    Public Enum PostDispatchTransferParametersIgnoreWarnings
        
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
    Public Enum PostDispatchTransferParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchTransferParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchTransferParametersValidateAllLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
