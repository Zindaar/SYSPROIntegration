Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.PurchaseOrderReceiptsReversal.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostPOReceiptsReverse

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private parametersField As PostPOReceiptsReverseParameters

        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostPOReceiptsReverseParameters()
            End If
        End Sub

        Public Property Parameters() As PostPOReceiptsReverseParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostPOReceiptsReverseParameters

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private transactionDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreWarningsField As PostPOReceiptsReverseParametersIgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nonStockedWhToUseField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyIfEntireDocumentValidField As PostPOReceiptsReverseParametersApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private validateOnlyField As PostPOReceiptsReverseParametersValidateOnly

        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostPOReceiptsReverseParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostPOReceiptsReverseParametersApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = PostPOReceiptsReverseParametersValidateOnly.N
        End Sub

        Public Property TransactionDate() As String
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseParametersIgnoreWarnings.N)>
        Public Property IgnoreWarnings() As PostPOReceiptsReverseParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = Value
            End Set
        End Property

        Public Property NonStockedWhToUse() As String
            Get
                Return Me.nonStockedWhToUseField
            End Get
            Set
                Me.nonStockedWhToUseField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseParametersApplyIfEntireDocumentValid.Y)>
        Public Property ApplyIfEntireDocumentValid() As PostPOReceiptsReverseParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseParametersValidateOnly.N)>
        Public Property ValidateOnly() As PostPOReceiptsReverseParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseParametersIgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseParametersApplyIfEntireDocumentValid

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostPOReceiptsReverseParametersValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
