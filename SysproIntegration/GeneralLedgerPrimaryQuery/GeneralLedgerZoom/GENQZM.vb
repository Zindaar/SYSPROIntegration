Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GeneralLedgerZoom.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
        End Sub
        
        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "GENQZM"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private generalLedgerJournalField As QueryOptionGeneralLedgerJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subLedgerField As QueryOptionSubLedger
        
        Public Sub New()
            MyBase.New
            If (Me.subLedgerField Is Nothing) Then
                Me.subLedgerField = New QueryOptionSubLedger
            End If
            If (Me.generalLedgerJournalField Is Nothing) Then
                Me.generalLedgerJournalField = New QueryOptionGeneralLedgerJournal
            End If
        End Sub
        
        Public Property GeneralLedgerJournal() As QueryOptionGeneralLedgerJournal
            Get
                Return Me.generalLedgerJournalField
            End Get
            Set
                Me.generalLedgerJournalField = value
            End Set
        End Property
        
        Public Property SubLedger() As QueryOptionSubLedger
            Get
                Return Me.subLedgerField
            End Get
            Set
                Me.subLedgerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionGeneralLedgerJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGLJournalsField As QueryOptionGeneralLedgerJournalIncludeGLJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private auditorsPasswordField As String
        
        Public Sub New()
            MyBase.New
            Me.includeGLJournalsField = QueryOptionGeneralLedgerJournalIncludeGLJournals.N
        End Sub
        
        Public Property IncludeGLJournals() As QueryOptionGeneralLedgerJournalIncludeGLJournals
            Get
                Return Me.includeGLJournalsField
            End Get
            Set
                Me.includeGLJournalsField = value
            End Set
        End Property
        
        Public Property GlYear() As String
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
        
        Public Property GlPer() As String
            Get
                Return Me.glPerField
            End Get
            Set
                Me.glPerField = value
            End Set
        End Property
        
        Public Property GlJournal() As String
            Get
                Return Me.glJournalField
            End Get
            Set
                Me.glJournalField = value
            End Set
        End Property
        
        Public Property AuditorsPassword() As String
            Get
                Return Me.auditorsPasswordField
            End Get
            Set
                Me.auditorsPasswordField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionGeneralLedgerJournalIncludeGLJournals
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionSubLedger
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSubLedgerField As QueryOptionSubLedgerIncludeSubLedger
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originField As QueryOptionSubLedgerOrigin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originZoomKeyField As String
        
        Public Sub New()
            MyBase.New
            Me.includeSubLedgerField = QueryOptionSubLedgerIncludeSubLedger.N
        End Sub
        
        Public Property IncludeSubLedger() As QueryOptionSubLedgerIncludeSubLedger
            Get
                Return Me.includeSubLedgerField
            End Get
            Set
                Me.includeSubLedgerField = value
            End Set
        End Property
        
        Public Property Origin() As QueryOptionSubLedgerOrigin
            Get
                Return Me.originField
            End Get
            Set
                Me.originField = value
                Me.OriginFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OriginSpecified() As Boolean
            Get
                Return Me.originFieldSpecified
            End Get
        End Property
        
        Public Property OriginZoomKey() As String
            Get
                Return Me.originZoomKeyField
            End Get
            Set
                Me.originZoomKeyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionSubLedgerIncludeSubLedger
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionSubLedgerOrigin
        
        '''<remarks/>
        CREH
        
        '''<remarks/>
        CREE
        
        '''<remarks/>
        DEBP
        
        '''<remarks/>
        DEBS
        
        '''<remarks/>
        INV
        
        '''<remarks/>
        GRN
        
        '''<remarks/>
        COSL
        
        '''<remarks/>
        COSB
        
        '''<remarks/>
        CRED
        
        '''<remarks/>
        CSBK
    End Enum
End Namespace
