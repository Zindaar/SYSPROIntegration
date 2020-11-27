Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ComGenericBrowse
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Browse
        Implements Codewell.SysproIntegration.IQuery


        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private browseNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startAtKeyField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startConditionField As StartCondition

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startConditionFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private returnRowsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private xslStylesheetField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private browseDetailsField As BrowseDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private filterField As BrowseFilter

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        Public Sub New()
            MyBase.New()
            Me.startConditionField = StartCondition.GE
            If (Me.filterField Is Nothing) Then
                Me.filterField = New BrowseFilter
            End If
            If (Me.browseDetailsField Is Nothing) Then
                Me.browseDetailsField = New BrowseDetails
            End If
        End Sub

        '''<summary>
        '''This is a user defined name. This is a compulsary.
        '''</summary>
        Public Property BrowseName() As String
            Get
                Return Me.browseNameField
            End Get
            Set(ByVal value As String)
                Me.browseNameField = value
            End Set
        End Property

        '''<summary>
        '''This is the primary key to the table name defined against this BrowseName in the configuration file. This is optional and will default to the beginning of the file.
        '''</summary>
        Public Property StartAtKey() As String
            Get
                Return Me.startAtKeyField
            End Get
            Set(ByVal value As String)
                Me.startAtKeyField = value
            End Set
        End Property

        '''<summary>
        '''This is used with the StartAtKey to specify the information to be returned (GR - greater than, GE - greater than or equal to, EF - end of file, LE - less than or equal to). Both GR and GE progress forward through the file whereas EF and LE return backwards through the file. The default is GE.
        '''</summary>
        Public Property StartCondition() As StartCondition
            Get
                Return Me.startConditionField
            End Get
            Set(ByVal value As StartCondition)
                Me.startConditionField = value
                Me.startConditionFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property StartConditionSpecified() As Boolean
            Get
                Return Me.startConditionFieldSpecified
            End Get
        End Property

        '''<summary>
        '''The number of rows either before or after this row to return (depending on whether GR/GE or EF/LE is used). If this is specified then this number of rows will be returned. If blank then the number against this BrowseName in the configuration file will be used. If thie number against the BrowseName is also blank then the default number against the configuration file will be used. If this default is also blank then 20 will be returned.
        '''</summary>
        Public Property ReturnRows() As String
            Get
                Return Me.returnRowsField
            End Get
            Set(ByVal value As String)
                Me.returnRowsField = value
            End Set
        End Property

        '''<summary>
        '''An optional section that allows for a filter on the browse
        '''</summary>
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set(ByVal value As String)
                Me.xslStylesheetField = value
            End Set
        End Property

        '''<summary>
        '''An optional section than overrides the configuration file information. If this element exists it must contain a tablename element with a value, or else the configuration file will be used.
        '''</summary>
        Public Property BrowseDetails() As BrowseDetails
            Get
                Return Me.browseDetailsField
            End Get
            Set(ByVal value As BrowseDetails)
                Me.browseDetailsField = value
            End Set
        End Property

        Public Property Filter() As BrowseFilter
            Get
                Return Me.filterField
            End Get
            Set(ByVal value As BrowseFilter)
                Me.filterField = value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "COMBRW"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            Me._xmlOut = QueryObject.Browse(Me)

            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub

        Public Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return CommonEnums.ActionType_Query.Browse
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                'Do nothing
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StartCondition
        
        '''<remarks/>
        GE
        
        '''<remarks/>
        GR
        
        '''<remarks/>
        EF
        
        '''<remarks/>
        LE
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class BrowseDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tableNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private titleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnField As List(Of Column)
        
        '''<summary>
        '''If the BrowseDetails element exists then this element is compulsary. This is the TableName from which you require data.
        '''</summary>
        Public Property TableName() As String
            Get
                Return Me.tableNameField
            End Get
            Set
                Me.tableNameField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the text to be used in the web browser. This is optional.
        '''</summary>
        Public Property Title() As String
            Get
                Return Me.titleField
            End Get
            Set
                Me.titleField = value
            End Set
        End Property
        
        '''<summary>
        '''The column element can appear multiple times. It can contain ColumnName, ColumnDescription and ColumnKey.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Column")>  _
        Public Property ColumnCollection() As List(Of Column)
            Get
                Return Me.columnField
            End Get
            Set
                Me.columnField = value
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
    Partial Public Class Column
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnKeyField As ColumnKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnKeyFieldSpecified As Boolean
        
        '''<summary>
        '''This is the column name of the data to be returned.
        '''</summary>
        Public Property ColumnName() As String
            Get
                Return Me.columnNameField
            End Get
            Set
                Me.columnNameField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the description to appear against this column. If it is blank then the standard column name for this column is used.
        '''</summary>
        Public Property ColumnDescription() As String
            Get
                Return Me.columnDescriptionField
            End Get
            Set
                Me.columnDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''If this element contains YES it specifies that the data against this column is to be underlined to make it a hyperlink. If multiple columns have this element set to YES then only the last one will be used.
        '''</summary>
        Public Property ColumnKey() As ColumnKey
            Get
                Return Me.columnKeyField
            End Get
            Set
                Me.columnKeyField = value
                Me.ColumnKeyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ColumnKeySpecified() As Boolean
            Get
                Return Me.columnKeyFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ColumnKey
        
        '''<remarks/>
        Yes
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        No
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BrowseFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnFilterNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnFilterValueField As String
        
        Public Property ColumnFilterName() As String
            Get
                Return Me.columnFilterNameField
            End Get
            Set
                Me.columnFilterNameField = value
            End Set
        End Property
        
        Public Property ColumnFilterValue() As String
            Get
                Return Me.columnFilterValueField
            End Get
            Set
                Me.columnFilterValueField = value
            End Set
        End Property
    End Class
End Namespace
