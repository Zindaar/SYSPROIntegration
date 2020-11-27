Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.GoodsInTransitTransferCreationFromSupplyChainTransfers.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSalesOrderTransfer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostSalesOrderTransferParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostSalesOrderTransferParameters
            End If
        End Sub
        
        Public Property Parameters() As PostSalesOrderTransferParameters
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
    Partial Public Class PostSalesOrderTransferParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transferDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostSalesOrderTransferParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostSalesOrderTransferParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostSalesOrderTransferParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostSalesOrderTransferParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateAllLinesField As PostSalesOrderTransferParametersValidateAllLines
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostSalesOrderTransferParametersPostingPeriod.C
            Me.ignoreWarningsField = PostSalesOrderTransferParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostSalesOrderTransferParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostSalesOrderTransferParametersValidateOnly.N
            Me.validateAllLinesField = PostSalesOrderTransferParametersValidateAllLines.N
        End Sub
        
        Public Property TransferDate() As String
            Get
                Return Me.transferDateField
            End Get
            Set
                Me.transferDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderTransferParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostSalesOrderTransferParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderTransferParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostSalesOrderTransferParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderTransferParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostSalesOrderTransferParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderTransferParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostSalesOrderTransferParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderTransferParametersValidateAllLines.N)>  _
        Public Property ValidateAllLines() As PostSalesOrderTransferParametersValidateAllLines
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
    Public Enum PostSalesOrderTransferParametersPostingPeriod
        
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
    Public Enum PostSalesOrderTransferParametersIgnoreWarnings
        
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
    Public Enum PostSalesOrderTransferParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderTransferParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderTransferParametersValidateAllLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
