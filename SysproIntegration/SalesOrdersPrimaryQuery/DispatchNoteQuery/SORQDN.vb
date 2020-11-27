Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.DispatchNoteQuery.QueryData
    
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
        Private keyField As QueryKey
        
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
            If (Me.keyField Is Nothing) Then
                Me.keyField = New QueryKey
            End If
        End Sub
        
        Public Property Key() As QueryKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
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
                Return "SORQDN"
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
    Partial Public Class QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteField As String
        
        Public Property DispatchNote() As String
            Get
                Return Me.dispatchNoteField
            End Get
            Set
                Me.dispatchNoteField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockedLinesField As QueryOptionIncludeStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedLinesField As QueryOptionIncludeNonStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFreightLinesField As QueryOptionIncludeFreightLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMiscellaneousLinesField As QueryOptionIncludeMiscellaneousLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommentLinesField As QueryOptionIncludeCommentLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsField As QueryOptionIncludeLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBinsField As QueryOptionIncludeBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialsField As QueryOptionIncludeSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As QueryOptionXslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.includeStockedLinesField = QueryOptionIncludeStockedLines.Y
            Me.includeNonStockedLinesField = QueryOptionIncludeNonStockedLines.Y
            Me.includeFreightLinesField = QueryOptionIncludeFreightLines.Y
            Me.includeMiscellaneousLinesField = QueryOptionIncludeMiscellaneousLines.Y
            Me.includeCommentLinesField = QueryOptionIncludeCommentLines.Y
            Me.includeLotsField = QueryOptionIncludeLots.Y
            Me.includeBinsField = QueryOptionIncludeBins.Y
            Me.includeSerialsField = QueryOptionIncludeSerials.Y
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New QueryOptionXslStylesheet
            End If
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeStockedLines.Y)>  _
        Public Property IncludeStockedLines() As QueryOptionIncludeStockedLines
            Get
                Return Me.includeStockedLinesField
            End Get
            Set
                Me.includeStockedLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStockedLines.Y)>  _
        Public Property IncludeNonStockedLines() As QueryOptionIncludeNonStockedLines
            Get
                Return Me.includeNonStockedLinesField
            End Get
            Set
                Me.includeNonStockedLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeFreightLines.Y)>  _
        Public Property IncludeFreightLines() As QueryOptionIncludeFreightLines
            Get
                Return Me.includeFreightLinesField
            End Get
            Set
                Me.includeFreightLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeMiscellaneousLines.Y)>  _
        Public Property IncludeMiscellaneousLines() As QueryOptionIncludeMiscellaneousLines
            Get
                Return Me.includeMiscellaneousLinesField
            End Get
            Set
                Me.includeMiscellaneousLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommentLines.Y)>  _
        Public Property IncludeCommentLines() As QueryOptionIncludeCommentLines
            Get
                Return Me.includeCommentLinesField
            End Get
            Set
                Me.includeCommentLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeLots.Y)>  _
        Public Property IncludeLots() As QueryOptionIncludeLots
            Get
                Return Me.includeLotsField
            End Get
            Set
                Me.includeLotsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBins.Y)>  _
        Public Property IncludeBins() As QueryOptionIncludeBins
            Get
                Return Me.includeBinsField
            End Get
            Set
                Me.includeBinsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSerials.Y)>  _
        Public Property IncludeSerials() As QueryOptionIncludeSerials
            Get
                Return Me.includeSerialsField
            End Get
            Set
                Me.includeSerialsField = value
            End Set
        End Property
        
        Public Property IncludeCustomForms() As Object
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As QueryOptionXslStylesheet
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeStockedLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNonStockedLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeFreightLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeMiscellaneousLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCommentLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeLots
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBins
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSerials
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionXslStylesheet
    End Class
End Namespace
