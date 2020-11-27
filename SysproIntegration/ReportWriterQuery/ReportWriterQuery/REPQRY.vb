Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ReportWriterQuery.ReportWriterQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportField As String
        
        '''<summary>
        '''This is mandatory and contains the report code to run a report or retrieve report information. If you want to retrieve a list of all reports this must be set to {all}.
        '''</summary>
        Public Property Report() As String
            Get
                Return Me.reportField
            End Get
            Set
                Me.reportField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retrieveField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private summaryField As Summary
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private summaryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As Sequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForReportField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runTimeField As List(Of RunTime)
        
        Public Sub New()
            MyBase.New
            Me.summaryField = Summary.N
            Me.sequenceField = Sequence.Item1
            If (Me.runTimeField Is Nothing) Then
                Me.runTimeField = New List(Of RunTime)
            End If
        End Sub
        
        '''<summary>
        '''This is only used for retrieving run time information pertaining to a specific report. (Y = yes).  When using the retrieve function, only the report element and this element need be supplied.
        '''</summary>
        Public Property Retrieve() As String
            Get
                Return Me.retrieveField
            End Get
            Set
                Me.retrieveField = value
            End Set
        End Property
        
        '''<summary>
        '''Summary report  (Y- Yes, N - No). If not supplied defaults to N
        '''</summary>
        Public Property Summary() As Summary
            Get
                Return Me.summaryField
            End Get
            Set
                Me.summaryField = value
                Me.SummaryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SummarySpecified() As Boolean
            Get
                Return Me.summaryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Report sequence (0-10). If not supplied defaults to 1
        '''</summary>
        Public Property Sequence() As Sequence
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
                Me.SequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SequenceSpecified() As Boolean
            Get
                Return Me.sequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the password which must be supplied for a report which is password protected
        '''</summary>
        Public Property PasswordForReport() As String
            Get
                Return Me.passwordForReportField
            End Get
            Set
                Me.passwordForReportField = value
            End Set
        End Property
        
        '''<summary>
        '''This is a list of run time variables for the report 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("RunTime")>  _
        Public Property RunTimeCollection() As List(Of RunTime)
            Get
                Return Me.runTimeField
            End Get
            Set
                Me.runTimeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Summary
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Sequence
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")>  _
        Item5
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")>  _
        Item6
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("9")>  _
        Item9
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class RunTime
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private variableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As Type
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.typeField = Type.A
        End Sub
        
        '''<summary>
        '''Run time variable name eg.FromStock
        '''</summary>
        Public Property Variable() As String
            Get
                Return Me.variableField
            End Get
            Set
                Me.variableField = value
            End Set
        End Property
        
        '''<summary>
        '''Run time variable value eg.B100 
        '''</summary>
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
        
        '''<summary>
        '''Run time variable data type (A-alpha, N-numeric, D-date)
        '''</summary>
        Public Property Type() As Type
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
                Me.TypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Type
        
        '''<remarks/>
        A
        
        '''<remarks/>
        N
        
        '''<remarks/>
        D
    End Enum
    
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
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        '''<summary>
        '''The key to use for this query
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of options
        '''</summary>
        Public Property [Option]() As [Option]
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
                Return "REPQRY"
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
End Namespace
