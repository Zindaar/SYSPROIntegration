Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ComGenericFind
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CloseBracket
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(")")>  _
        Item
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("))")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(")))")>  _
        Item2
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Columns
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.columnField Is Nothing) Then
                Me.columnField = New List(Of String)
            End If
        End Sub
        
        '''<summary>
        '''This element is a child of the  "Columns" parent element. The value of this element can contain the SQL column name that must be returned.  This element’s occurrence is unbounded. At least one-column name must be supplied, hence making only one occurrence of the column element mandatory.  The value is case sensitive.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Column")>  _
        Public Property ColumnCollection() As List(Of String)
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Condition
        
        '''<remarks/>
        GT
        
        '''<remarks/>
        GE
        
        '''<remarks/>
        LT
        
        '''<remarks/>
        LE
        
        '''<remarks/>
        EQ
        
        '''<remarks/>
        NE
        
        '''<remarks/>
        [LIKE]
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Expression
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private andOrField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openBracketField As OpenBracket
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openBracketFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private conditionField As Condition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private closeBracketField As CloseBracket
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private closeBracketFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private columnNameField As String
        
        Public Sub New()
            MyBase.New
            Me.andOrField = "and"
        End Sub
        
        '''<summary>
        '''This element must contain an “and” or an “or”. If the value is not supplied a default of “and” will be used in your expression
        '''</summary>
        Public Property AndOr() As String
            Get
                Return Me.andOrField
            End Get
            Set
                Me.andOrField = value
            End Set
        End Property
        
        '''<summary>
        '''This element can only contain the values “(“,  “((“, “(((“.  This simply means that for each open bracket element under the expression parent node there is a maximum of 3 open brackets values.
        '''</summary>
        Public Property OpenBracket() As OpenBracket
            Get
                Return Me.openBracketField
            End Get
            Set
                Me.openBracketField = value
                Me.OpenBracketFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OpenBracketSpecified() As Boolean
            Get
                Return Me.openBracketFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is a child of the  "Columns" parent element. The value of this element can contain the SQL column name that must be returned.  This element’s occurrence is unbounded. At least one-column name must be supplied, hence making only one occurrence of the column element mandatory.  The value is case sensitive.
        '''</summary>
        Public Property Column() As Object
            Get
                Return Me.columnField
            End Get
            Set
                Me.columnField = value
            End Set
        End Property
        
        '''<summary>
        '''This element must contain the condition to the expression e.g. GT-Greater than, GE-Greater than equal too, LT-Less than, LE-Less than equal too, EQ-Equal too, NE-Not Equal too, LIKE-when you specify like as a condition, you can use 2 wild cards “*” and “?”. “*” - an infinate number of characters. “?” - any single character 
        '''</summary>
        Public Property Condition() As Condition
            Get
                Return Me.conditionField
            End Get
            Set
                Me.conditionField = value
            End Set
        End Property
        
        '''<summary>
        '''This element must contain the value you want to compare to the column of the expression.
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
        '''This element can only contain the values “)“,  “))“, “)))“.  This simply means that for each close bracket element under the expression parent node there is a maximum of 3 close brackets values.
        '''</summary>
        Public Property CloseBracket() As CloseBracket
            Get
                Return Me.closeBracketField
            End Get
            Set
                Me.closeBracketField = value
                Me.CloseBracketFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CloseBracketSpecified() As Boolean
            Get
                Return Me.closeBracketFieldSpecified
            End Get
        End Property
        
        Public Property ColumnName() As String
            Get
                Return Me.columnNameField
            End Get
            Set
                Me.columnNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OpenBracket
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("(")>  _
        Item
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("((")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("(((")>  _
        Item2
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


        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private tableNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private returnRowsField As Long

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private returnRowsFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private columnsField As List(Of String)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private whereField As List(Of Expression)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderByField As List(Of String)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        Public Sub New()
            MyBase.New()
            If (Me.orderByField Is Nothing) Then
                Me.orderByField = New List(Of String)
            End If
            If (Me.whereField Is Nothing) Then
                Me.whereField = New List(Of Expression)
            End If
            If (Me.columnsField Is Nothing) Then
                Me.columnsField = New List(Of String)
            End If
        End Sub

        '''<summary>
        '''This element must contain the name of the table that you would like to do a search on.  The element value must be the SQL table name.  This value is case sensitive and mandatory.
        '''</summary>
        Public Property TableName() As String
            Get
                Return Me.tableNameField
            End Get
            Set(ByVal value As String)
                Me.tableNameField = value
            End Set
        End Property

        '''<summary>
        '''This element can contain the maximum number of rows to be returned by the search.  If a value for the element is not supplied all the rows in the table will be returned. This value is optional. 
        '''</summary>
        Public Property ReturnRows() As Long
            Get
                Return Me.returnRowsField
            End Get
            Set(ByVal value As Long)
                Me.returnRowsField = value
                Me.returnRowsFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property ReturnRowsSpecified() As Boolean
            Get
                Return Me.returnRowsFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This is a parent element to the child nodes "Column".  This parent element is mandatory. It can only occur once.
        '''</summary>
        <System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable:=False)> _
        Public Property ColumnsCollection() As List(Of String)
            Get
                Return Me.columnsField
            End Get
            Set(ByVal value As List(Of String))
                Me.columnsField = value
            End Set
        End Property

        '''<summary>
        '''This element is a parent element of the child nodes "Expression".  It is mandatory only if you want to supply an expression to the search. This element can only occur once.
        '''</summary>
        <System.Xml.Serialization.XmlArrayItemAttribute("Expression", IsNullable:=False)> _
        Public Property WhereCollection() As List(Of Expression)
            Get
                Return Me.whereField
            End Get
            Set(ByVal value As List(Of Expression))
                Me.whereField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable:=False)> _
        Public Property OrderByCollection() As List(Of String)
            Get
                Return Me.orderByField
            End Get
            Set(ByVal value As List(Of String))
                Me.orderByField = value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "COMFND"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me).Replace("Collection", "").Replace(" xsi:type=""xsd:string""", "")
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            Me._xmlOut = QueryObject.Query(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub

        Public Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return CommonEnums.ActionType_Query.Query
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                'do nothing
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
    Partial Public Class Where
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expressionField As List(Of Expression)
        
        Public Sub New()
            MyBase.New
            If (Me.expressionField Is Nothing) Then
                Me.expressionField = New List(Of Expression)
            End If
        End Sub
        
        '''<summary>
        '''This element is parent to "AndOr", "OpenBracket", "Column", "Condition", "Value" and "CloseBracket" elements which are discussed below.  This element’s occurrence is unbounded.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Expression")>  _
        Public Property ExpressionCollection() As List(Of Expression)
            Get
                Return Me.expressionField
            End Get
            Set
                Me.expressionField = value
            End Set
        End Property
    End Class
End Namespace
