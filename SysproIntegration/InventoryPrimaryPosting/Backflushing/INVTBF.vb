Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryPosting.InventoryMovementsBackflushing.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostInvBackflushing

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private parametersField As PostInvBackflushingParameters

        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostInvBackflushingParameters()
            End If
        End Sub

        Public Property Parameters() As PostInvBackflushingParameters
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
    Partial Public Class PostInvBackflushingParameters

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private transactionDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private passwordForTransactionField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreWarningsField As PostInvBackflushingParametersIgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private validateOnlyField As PostInvBackflushingParametersValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyIfEntireDocumentValidField As PostInvBackflushingParametersApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private backflushLevelField As PostInvBackflushingParametersBackflushLevel

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private issueFromComponentWarehouseToUseField As PostInvBackflushingParametersIssueFromComponentWarehouseToUse

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreBomWhField As PostInvBackflushingParametersIgnoreBomWh

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private componentWarehouseToIssueFromField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private excludeComponentsIfBoughtOutField As PostInvBackflushingParametersExcludeComponentsIfBoughtOut

        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostInvBackflushingParametersIgnoreWarnings.N
            Me.validateOnlyField = PostInvBackflushingParametersValidateOnly.N
            Me.applyIfEntireDocumentValidField = PostInvBackflushingParametersApplyIfEntireDocumentValid.N
            Me.backflushLevelField = PostInvBackflushingParametersBackflushLevel.A
            Me.issueFromComponentWarehouseToUseField = PostInvBackflushingParametersIssueFromComponentWarehouseToUse.Y
            Me.ignoreBomWhField = PostInvBackflushingParametersIgnoreBomWh.N
            Me.excludeComponentsIfBoughtOutField = PostInvBackflushingParametersExcludeComponentsIfBoughtOut.N
        End Sub

        Public Property TransactionDate() As String
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = Value
            End Set
        End Property

        Public Property PasswordForTransaction() As String
            Get
                Return Me.passwordForTransactionField
            End Get
            Set
                Me.passwordForTransactionField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersIgnoreWarnings.N)>
        Public Property IgnoreWarnings() As PostInvBackflushingParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersValidateOnly.N)>
        Public Property ValidateOnly() As PostInvBackflushingParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersApplyIfEntireDocumentValid.N)>
        Public Property ApplyIfEntireDocumentValid() As PostInvBackflushingParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersBackflushLevel.A)>
        Public Property BackflushLevel() As PostInvBackflushingParametersBackflushLevel
            Get
                Return Me.backflushLevelField
            End Get
            Set
                Me.backflushLevelField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersIssueFromComponentWarehouseToUse.Y)>
        Public Property IssueFromComponentWarehouseToUse() As PostInvBackflushingParametersIssueFromComponentWarehouseToUse
            Get
                Return Me.issueFromComponentWarehouseToUseField
            End Get
            Set
                Me.issueFromComponentWarehouseToUseField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersIgnoreBomWh.N)>
        Public Property IgnoreBomWh() As PostInvBackflushingParametersIgnoreBomWh
            Get
                Return Me.ignoreBomWhField
            End Get
            Set
                Me.ignoreBomWhField = Value
            End Set
        End Property

        Public Property ComponentWarehouseToIssueFrom() As String
            Get
                Return Me.componentWarehouseToIssueFromField
            End Get
            Set
                Me.componentWarehouseToIssueFromField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostInvBackflushingParametersExcludeComponentsIfBoughtOut.N)>
        Public Property ExcludeComponentsIfBoughtOut() As PostInvBackflushingParametersExcludeComponentsIfBoughtOut
            Get
                Return Me.excludeComponentsIfBoughtOutField
            End Get
            Set
                Me.excludeComponentsIfBoughtOutField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersIgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersApplyIfEntireDocumentValid

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersBackflushLevel

        '''<remarks/>
        A

        '''<remarks/>
        S
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersIssueFromComponentWarehouseToUse

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersIgnoreBomWh

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PostInvBackflushingParametersExcludeComponentsIfBoughtOut

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
