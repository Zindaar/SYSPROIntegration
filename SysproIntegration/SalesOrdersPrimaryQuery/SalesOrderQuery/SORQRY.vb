Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.SalesOrderQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeBins
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCommentLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCompletedLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeFreightLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeLots
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeMiscLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeNonStockedLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeStockedLines
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeAttachedItems
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeSerials
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        '''<summary>
        '''Enter the sales order number to be queried
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter the A/R invoice number, if the sales order to be queried has already been invoiced.
        '''</summary>
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
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
        Private includeStockedLinesField As IncludeStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedLinesField As IncludeNonStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFreightLinesField As IncludeFreightLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFreightLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMiscLinesField As IncludeMiscLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMiscLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommentLinesField As IncludeCommentLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommentLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedLinesField As IncludeCompletedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialsField As IncludeSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsField As IncludeLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBinsField As IncludeBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBinsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAttachedItemsField As IncludeAttachedItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAttachedItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As IncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDetailLineCustomFormsField As IncludeDetailLineCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDetailLineCustomFormsFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.includeStockedLinesField = IncludeStockedLines.Y
            Me.includeNonStockedLinesField = IncludeNonStockedLines.Y
            Me.includeFreightLinesField = IncludeFreightLines.Y
            Me.includeMiscLinesField = IncludeMiscLines.Y
            Me.includeCommentLinesField = IncludeCommentLines.Y
            Me.includeCompletedLinesField = IncludeCompletedLines.Y
            Me.includeSerialsField = IncludeSerials.Y
            Me.includeLotsField = IncludeLots.Y
            Me.includeBinsField = IncludeBins.Y
            Me.includeAttachedItemsField = IncludeAttachedItems.N
            Me.includeCustomFormsField = IncludeCustomForms.N
            Me.includeDetailLineCustomFormsField = IncludeDetailLineCustomForms.N
        End Sub
        
        '''<summary>
        '''Do you wish to include lines containing stocked items (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeStockedLines() As IncludeStockedLines
            Get
                Return Me.includeStockedLinesField
            End Get
            Set
                Me.includeStockedLinesField = value
                Me.IncludeStockedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeStockedLinesSpecified() As Boolean
            Get
                Return Me.includeStockedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include lines containing non-stocked items (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeNonStockedLines() As IncludeNonStockedLines
            Get
                Return Me.includeNonStockedLinesField
            End Get
            Set
                Me.includeNonStockedLinesField = value
                Me.IncludeNonStockedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeNonStockedLinesSpecified() As Boolean
            Get
                Return Me.includeNonStockedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include freight lines (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeFreightLines() As IncludeFreightLines
            Get
                Return Me.includeFreightLinesField
            End Get
            Set
                Me.includeFreightLinesField = value
                Me.IncludeFreightLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeFreightLinesSpecified() As Boolean
            Get
                Return Me.includeFreightLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include miscellaneous charge lines (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMiscLines() As IncludeMiscLines
            Get
                Return Me.includeMiscLinesField
            End Get
            Set
                Me.includeMiscLinesField = value
                Me.IncludeMiscLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMiscLinesSpecified() As Boolean
            Get
                Return Me.includeMiscLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include comment lines (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeCommentLines() As IncludeCommentLines
            Get
                Return Me.includeCommentLinesField
            End Get
            Set
                Me.includeCommentLinesField = value
                Me.IncludeCommentLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCommentLinesSpecified() As Boolean
            Get
                Return Me.includeCommentLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include completed lines (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeCompletedLines() As IncludeCompletedLines
            Get
                Return Me.includeCompletedLinesField
            End Get
            Set
                Me.includeCompletedLinesField = value
                Me.IncludeCompletedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCompletedLinesSpecified() As Boolean
            Get
                Return Me.includeCompletedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include serial numbers (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeSerials() As IncludeSerials
            Get
                Return Me.includeSerialsField
            End Get
            Set
                Me.includeSerialsField = value
                Me.IncludeSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeSerialsSpecified() As Boolean
            Get
                Return Me.includeSerialsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include lots (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeLots() As IncludeLots
            Get
                Return Me.includeLotsField
            End Get
            Set
                Me.includeLotsField = value
                Me.IncludeLotsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeLotsSpecified() As Boolean
            Get
                Return Me.includeLotsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include multiple bin lines (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeBins() As IncludeBins
            Get
                Return Me.includeBinsField
            End Get
            Set
                Me.includeBinsField = value
                Me.IncludeBinsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBinsSpecified() As Boolean
            Get
                Return Me.includeBinsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to return attached items (Y - Yes, N - No). Default = N. If Yes, this will return the Job, Purchase order,Supply chain transfer or Requisition that has been created against the line. 
        '''</summary>
        Public Property IncludeAttachedItems() As IncludeAttachedItems
            Get
                Return Me.includeAttachedItemsField
            End Get
            Set
                Me.includeAttachedItemsField = value
                Me.IncludeAttachedItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeAttachedItemsSpecified() As Boolean
            Get
                Return Me.includeAttachedItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include custom forms (Y - Yes, N - No). Default = N. If Y - Yes, custom form fields and values defined against the sales order are returned.  
        '''</summary>
        Public Property IncludeCustomForms() As IncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
                Me.IncludeCustomFormsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCustomFormsSpecified() As Boolean
            Get
                Return Me.includeCustomFormsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the name of the XSL Stylesheet to use
        '''</summary>
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include custom forms for detail lines (Y - Yes, N - No). Default = N. If Y - Yes, custom form fields and values defined against the sales order detail line are returned.  
        '''</summary>
        Public Property IncludeDetailLineCustomForms() As IncludeDetailLineCustomForms
            Get
                Return Me.includeDetailLineCustomFormsField
            End Get
            Set
                Me.includeDetailLineCustomFormsField = value
                Me.IncludeDetailLineCustomFormsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeDetailLineCustomFormsSpecified() As Boolean
            Get
                Return Me.includeDetailLineCustomFormsFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeDetailLineCustomForms
        
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
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''The key to use for this query.
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
        '''The list of options.
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
                Return "SORQRY"
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
