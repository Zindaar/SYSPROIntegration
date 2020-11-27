Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace TransactionObjects.ChangeSOWarehouse.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostChangeSoWarehouse

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As PostChangeSoWarehouseParameters

        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostChangeSoWarehouseParameters
            End If
        End Sub

        Public Property Parameters() As PostChangeSoWarehouseParameters
            Get
                Return Me.parametersField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParameters)
                Me.parametersField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostChangeSoWarehouseParameters

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsField As PostChangeSoWarehouseParametersIgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidField As PostChangeSoWarehouseParametersApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As PostChangeSoWarehouseParametersValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addWarehouseDetailsField As PostChangeSoWarehouseParametersAddWarehouseDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addLotDetailsField As PostChangeSoWarehouseParametersAddLotDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addSerialDetailsField As PostChangeSoWarehouseParametersAddSerialDetails

        Public Sub New()
            MyBase.New()
            Me.ignoreWarningsField = PostChangeSoWarehouseParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostChangeSoWarehouseParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostChangeSoWarehouseParametersValidateOnly.N
            Me.addWarehouseDetailsField = PostChangeSoWarehouseParametersAddWarehouseDetails.N
            Me.addLotDetailsField = PostChangeSoWarehouseParametersAddLotDetails.N
            Me.addSerialDetailsField = PostChangeSoWarehouseParametersAddSerialDetails.N
        End Sub

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersIgnoreWarnings.N)> _
        Public Property IgnoreWarnings() As PostChangeSoWarehouseParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersIgnoreWarnings)
                Me.ignoreWarningsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersApplyIfEntireDocumentValid.N)> _
        Public Property ApplyIfEntireDocumentValid() As PostChangeSoWarehouseParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersApplyIfEntireDocumentValid)
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersValidateOnly.N)> _
        Public Property ValidateOnly() As PostChangeSoWarehouseParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersValidateOnly)
                Me.validateOnlyField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersAddWarehouseDetails.N)> _
        Public Property AddWarehouseDetails() As PostChangeSoWarehouseParametersAddWarehouseDetails
            Get
                Return Me.addWarehouseDetailsField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersAddWarehouseDetails)
                Me.addWarehouseDetailsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersAddLotDetails.N)> _
        Public Property AddLotDetails() As PostChangeSoWarehouseParametersAddLotDetails
            Get
                Return Me.addLotDetailsField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersAddLotDetails)
                Me.addLotDetailsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostChangeSoWarehouseParametersAddSerialDetails.N)> _
        Public Property AddSerialDetails() As PostChangeSoWarehouseParametersAddSerialDetails
            Get
                Return Me.addSerialDetailsField
            End Get
            Set(ByVal value As PostChangeSoWarehouseParametersAddSerialDetails)
                Me.addSerialDetailsField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersIgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        W

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")> _
        Item
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersApplyIfEntireDocumentValid

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersAddWarehouseDetails

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersAddLotDetails

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostChangeSoWarehouseParametersAddSerialDetails

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")> _
        Item
    End Enum
End Namespace
