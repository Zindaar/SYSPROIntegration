Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.ReserveLotSerial.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostReserveLotSerial

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As PostReserveLotSerialParameters

        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostReserveLotSerialParameters
            End If
        End Sub

        Public Property Parameters() As PostReserveLotSerialParameters
            Get
                Return Me.parametersField
            End Get
            Set(ByVal value As PostReserveLotSerialParameters)
                Me.parametersField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostReserveLotSerialParameters

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionTypeField As PostReserveLotSerialParametersTransactionType

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private sourceField As PostReserveLotSerialParametersSource

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As PostReserveLotSerialParametersValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidField As PostReserveLotSerialParametersApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsField As PostReserveLotSerialParametersIgnoreWarnings

        Public Sub New()
            MyBase.New()
            Me.transactionTypeField = PostReserveLotSerialParametersTransactionType.A
            Me.sourceField = PostReserveLotSerialParametersSource.J
            Me.validateOnlyField = PostReserveLotSerialParametersValidateOnly.N
            Me.applyIfEntireDocumentValidField = PostReserveLotSerialParametersApplyIfEntireDocumentValid.Y
            Me.ignoreWarningsField = PostReserveLotSerialParametersIgnoreWarnings.N
        End Sub

        <System.ComponentModel.DefaultValueAttribute(PostReserveLotSerialParametersTransactionType.A)> _
        Public Property TransactionType() As PostReserveLotSerialParametersTransactionType
            Get
                Return Me.transactionTypeField
            End Get
            Set(ByVal value As PostReserveLotSerialParametersTransactionType)
                Me.transactionTypeField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostReserveLotSerialParametersSource.J)> _
        Public Property Source() As PostReserveLotSerialParametersSource
            Get
                Return Me.sourceField
            End Get
            Set(ByVal value As PostReserveLotSerialParametersSource)
                Me.sourceField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostReserveLotSerialParametersValidateOnly.N)> _
        Public Property ValidateOnly() As PostReserveLotSerialParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As PostReserveLotSerialParametersValidateOnly)
                Me.validateOnlyField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostReserveLotSerialParametersApplyIfEntireDocumentValid.Y)> _
        Public Property ApplyIfEntireDocumentValid() As PostReserveLotSerialParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set(ByVal value As PostReserveLotSerialParametersApplyIfEntireDocumentValid)
                Me.applyIfEntireDocumentValidField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostReserveLotSerialParametersIgnoreWarnings.N)> _
        Public Property IgnoreWarnings() As PostReserveLotSerialParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(ByVal value As PostReserveLotSerialParametersIgnoreWarnings)
                Me.ignoreWarningsField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostReserveLotSerialParametersTransactionType

        '''<remarks/>
        A

        '''<remarks/>
        R

        '''<remarks/>
        S

        '''<remarks/>
        E

        '''<remarks/>
        D

        '''<remarks/>
        C
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostReserveLotSerialParametersSource

        '''<remarks/>
        J

        '''<remarks/>
        A
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostReserveLotSerialParametersValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostReserveLotSerialParametersApplyIfEntireDocumentValid

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostReserveLotSerialParametersIgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
