Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderGrnSystem.GrnPostGrnAdjustments.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostGrnAdjustments

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private parametersField As Parameters

        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters()
            End If
        End Sub

        '''<summary>
        '''This contains parameters.
        '''</summary>
        Public Property Parameters() As Parameters
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Parameters

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private actionTypeField As ActionType

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private actionTypeFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreAnalysisField As IgnoreAnalysis

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private postingPeriodField As PostingPeriod

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private postingPeriodFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreWarningsField As IgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ignoreWarningsFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private applyIfEntireDocumentValidFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private validateOnlyField As ValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private validateOnlyFieldSpecified As Boolean

        Public Sub New()
            MyBase.New
            Me.actionTypeField = ActionType.A
            Me.ignoreAnalysisField = IgnoreAnalysis.Y
            Me.postingPeriodField = PostingPeriod.Item1
        End Sub

        '''<summary>
        '''Add or Change a GRN, A = Add, C = Change.
        '''</summary>
        Public Property ActionType() As ActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = Value
                Me.actionTypeFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property ActionTypeSpecified() As Boolean
            Get
                Return Me.actionTypeFieldSpecified
            End Get
        End Property

        '''<summary>
        '''Ignore analysis Y=Yes, N-No
        '''</summary>
        Public Property IgnoreAnalysis() As IgnoreAnalysis
            Get
                Return Me.ignoreAnalysisField
            End Get
            Set
                Me.ignoreAnalysisField = Value
            End Set
        End Property

        '''<summary>
        '''Change from the current posting period to previous 1 or 2. Only available when adding a new GRN. 1 = Current, 2 = Previous 1, 3 - Previous 2.
        '''</summary>
        Public Property PostingPeriod() As PostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = Value
                Me.postingPeriodFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property PostingPeriodSpecified() As Boolean
            Get
                Return Me.postingPeriodFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings. If it is not supplied, it defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = Value
                Me.ignoreWarningsFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = Value
                Me.applyIfEntireDocumentValidFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = Value
                Me.validateOnlyFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum ActionType

        '''<remarks/>
        A

        '''<remarks/>
        C
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum IgnoreAnalysis

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum PostingPeriod

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum IgnoreWarnings

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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum ApplyIfEntireDocumentValid

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum ValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
