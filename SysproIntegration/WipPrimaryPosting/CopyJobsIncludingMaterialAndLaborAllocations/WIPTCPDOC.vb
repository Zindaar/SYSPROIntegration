Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.CopyJobsIncludingMaterialAndLaborAllocations.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostWipJobCopy
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostWipJobCopyItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostWipJobCopyParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostWipJobCopyItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostWipJobCopyItem)
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
                Return "WIPTCP"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostWipJobCopyParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostWipJobCopyParameters
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
                Dim objParams As Params.PostWipJobCopy
                objParams = New Params.PostWipJobCopy
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
    Partial Public Class PostWipJobCopyItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private archivedJobField As PostWipJobCopyItemArchivedJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private archiveNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toJobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedOrBuiltField As PostWipJobCopyItemPlannedOrBuilt
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialAllocsField As PostWipJobCopyItemIncludeMaterialAllocs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLaborAllocsField As PostWipJobCopyItemIncludeLaborAllocs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNotepadField As PostWipJobCopyItemIncludeNotepad
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As PostWipJobCopyItemIncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNarrationsField As PostWipJobCopyItemIncludeNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMultimediaField As PostWipJobCopyItemIncludeMultimedia
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodField As PostWipJobCopyItemDateCalcMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOvertimePctField As PostWipJobCopyItemIncludeOvertimePct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        Public Sub New()
            MyBase.New
            Me.archivedJobField = PostWipJobCopyItemArchivedJob.N
            Me.plannedOrBuiltField = PostWipJobCopyItemPlannedOrBuilt.P
            Me.includeMaterialAllocsField = PostWipJobCopyItemIncludeMaterialAllocs.N
            Me.includeLaborAllocsField = PostWipJobCopyItemIncludeLaborAllocs.N
            Me.includeNotepadField = PostWipJobCopyItemIncludeNotepad.N
            Me.includeCustomFormsField = PostWipJobCopyItemIncludeCustomForms.N
            Me.includeNarrationsField = PostWipJobCopyItemIncludeNarrations.N
            Me.includeMultimediaField = PostWipJobCopyItemIncludeMultimedia.N
            Me.dateCalcMethodField = PostWipJobCopyItemDateCalcMethod.M
            Me.includeOvertimePctField = PostWipJobCopyItemIncludeOvertimePct.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemArchivedJob.N)>  _
        Public Property ArchivedJob() As PostWipJobCopyItemArchivedJob
            Get
                Return Me.archivedJobField
            End Get
            Set
                Me.archivedJobField = value
            End Set
        End Property
        
        Public Property ArchiveNumber() As String
            Get
                Return Me.archiveNumberField
            End Get
            Set
                Me.archiveNumberField = value
            End Set
        End Property
        
        Public Property FromJob() As String
            Get
                Return Me.fromJobField
            End Get
            Set
                Me.fromJobField = value
            End Set
        End Property
        
        Public Property ToJob() As String
            Get
                Return Me.toJobField
            End Get
            Set
                Me.toJobField = value
            End Set
        End Property
        
        Public Property ToJobDescription() As String
            Get
                Return Me.toJobDescriptionField
            End Get
            Set
                Me.toJobDescriptionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemPlannedOrBuilt.P)>  _
        Public Property PlannedOrBuilt() As PostWipJobCopyItemPlannedOrBuilt
            Get
                Return Me.plannedOrBuiltField
            End Get
            Set
                Me.plannedOrBuiltField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeMaterialAllocs.N)>  _
        Public Property IncludeMaterialAllocs() As PostWipJobCopyItemIncludeMaterialAllocs
            Get
                Return Me.includeMaterialAllocsField
            End Get
            Set
                Me.includeMaterialAllocsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeLaborAllocs.N)>  _
        Public Property IncludeLaborAllocs() As PostWipJobCopyItemIncludeLaborAllocs
            Get
                Return Me.includeLaborAllocsField
            End Get
            Set
                Me.includeLaborAllocsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeNotepad.N)>  _
        Public Property IncludeNotepad() As PostWipJobCopyItemIncludeNotepad
            Get
                Return Me.includeNotepadField
            End Get
            Set
                Me.includeNotepadField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeCustomForms.N)>  _
        Public Property IncludeCustomForms() As PostWipJobCopyItemIncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeNarrations.N)>  _
        Public Property IncludeNarrations() As PostWipJobCopyItemIncludeNarrations
            Get
                Return Me.includeNarrationsField
            End Get
            Set
                Me.includeNarrationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeMultimedia.N)>  _
        Public Property IncludeMultimedia() As PostWipJobCopyItemIncludeMultimedia
            Get
                Return Me.includeMultimediaField
            End Get
            Set
                Me.includeMultimediaField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemDateCalcMethod.M)>  _
        Public Property DateCalcMethod() As PostWipJobCopyItemDateCalcMethod
            Get
                Return Me.dateCalcMethodField
            End Get
            Set
                Me.dateCalcMethodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipJobCopyItemIncludeOvertimePct.N)>  _
        Public Property IncludeOvertimePct() As PostWipJobCopyItemIncludeOvertimePct
            Get
                Return Me.includeOvertimePctField
            End Get
            Set
                Me.includeOvertimePctField = value
            End Set
        End Property
        
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemArchivedJob
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemPlannedOrBuilt
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeMaterialAllocs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeLaborAllocs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeNotepad
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeNarrations
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeMultimedia
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemDateCalcMethod
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
        
        '''<remarks/>
        S
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipJobCopyItemIncludeOvertimePct
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
