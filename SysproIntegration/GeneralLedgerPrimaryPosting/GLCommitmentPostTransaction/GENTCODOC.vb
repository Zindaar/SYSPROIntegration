Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.GLCommitmentPostTransaction.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostGlCommitments
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostGlCommitmentsItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostGlCommitmentsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostGlCommitmentsItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostGlCommitmentsItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "GENTCO"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostGlCommitmentsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostGlCommitmentsParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostGlCommitments
                objParams = New Params.PostGlCommitments
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlCommitmentsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postActionField As PostGlCommitmentsItemPostAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfCommitmentField As PostGlCommitmentsItemTypeOfCommitment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentRefLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commitmentSourceKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origTypeOfCommitmentField As PostGlCommitmentsItemOrigTypeOfCommitment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origTypeOfCommitmentFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origCommitmentDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origCommitmentReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origCommitmentRefLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origCommitmentSourceKeyField As String
        
        Public Sub New()
            MyBase.New
            Me.postActionField = PostGlCommitmentsItemPostAction.A
            Me.typeOfCommitmentField = PostGlCommitmentsItemTypeOfCommitment.R
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostGlCommitmentsItemPostAction.A)>  _
        Public Property PostAction() As PostGlCommitmentsItemPostAction
            Get
                Return Me.postActionField
            End Get
            Set
                Me.postActionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostGlCommitmentsItemTypeOfCommitment.R)>  _
        Public Property TypeOfCommitment() As PostGlCommitmentsItemTypeOfCommitment
            Get
                Return Me.typeOfCommitmentField
            End Get
            Set
                Me.typeOfCommitmentField = value
            End Set
        End Property
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        Public Property CommitmentDate() As String
            Get
                Return Me.commitmentDateField
            End Get
            Set
                Me.commitmentDateField = value
            End Set
        End Property
        
        Public Property CommitmentValue() As String
            Get
                Return Me.commitmentValueField
            End Get
            Set
                Me.commitmentValueField = value
            End Set
        End Property
        
        Public Property CommitmentReference() As String
            Get
                Return Me.commitmentReferenceField
            End Get
            Set
                Me.commitmentReferenceField = value
            End Set
        End Property
        
        Public Property CommitmentRefLine() As String
            Get
                Return Me.commitmentRefLineField
            End Get
            Set
                Me.commitmentRefLineField = value
            End Set
        End Property
        
        Public Property CommitmentSourceKey() As String
            Get
                Return Me.commitmentSourceKeyField
            End Get
            Set
                Me.commitmentSourceKeyField = value
            End Set
        End Property
        
        Public Property OrigTypeOfCommitment() As PostGlCommitmentsItemOrigTypeOfCommitment
            Get
                Return Me.origTypeOfCommitmentField
            End Get
            Set
                Me.origTypeOfCommitmentField = value
                Me.OrigTypeOfCommitmentFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrigTypeOfCommitmentSpecified() As Boolean
            Get
                Return Me.origTypeOfCommitmentFieldSpecified
            End Get
        End Property
        
        Public Property OrigLedgerCode() As String
            Get
                Return Me.origLedgerCodeField
            End Get
            Set
                Me.origLedgerCodeField = value
            End Set
        End Property
        
        Public Property OrigCommitmentDate() As String
            Get
                Return Me.origCommitmentDateField
            End Get
            Set
                Me.origCommitmentDateField = value
            End Set
        End Property
        
        Public Property OrigCommitmentReference() As String
            Get
                Return Me.origCommitmentReferenceField
            End Get
            Set
                Me.origCommitmentReferenceField = value
            End Set
        End Property
        
        Public Property OrigCommitmentRefLine() As String
            Get
                Return Me.origCommitmentRefLineField
            End Get
            Set
                Me.origCommitmentRefLineField = value
            End Set
        End Property
        
        Public Property OrigCommitmentSourceKey() As String
            Get
                Return Me.origCommitmentSourceKeyField
            End Get
            Set
                Me.origCommitmentSourceKeyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlCommitmentsItemPostAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlCommitmentsItemTypeOfCommitment
        
        '''<remarks/>
        R
        
        '''<remarks/>
        P
        
        '''<remarks/>
        U
        
        '''<remarks/>
        C
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlCommitmentsItemOrigTypeOfCommitment
        
        '''<remarks/>
        R
        
        '''<remarks/>
        P
        
        '''<remarks/>
        U
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
