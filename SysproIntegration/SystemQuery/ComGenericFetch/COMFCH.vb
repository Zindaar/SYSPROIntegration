Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ComGenericFetch
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Fetch
        Implements Codewell.SysproIntegration.IQuery


        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private tableNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private keyField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey10Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey11Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionalKey12Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fullKeyProvidedField As FetchFullKeyProvided

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        Public Sub New()
            MyBase.New()
            Me.fullKeyProvidedField = FetchFullKeyProvided.N
        End Sub

        '''<summary>
        '''The table name of the table to be accessed.
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
        '''Key of the row to be returned. This is mandatory.
        '''</summary>
        Public Property Key() As String
            Get
                Return Me.keyField
            End Get
            Set(ByVal value As String)
                Me.keyField = value
            End Set
        End Property

        '''<summary>
        '''The first optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey1() As String
            Get
                Return Me.optionalKey1Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey1Field = value
            End Set
        End Property

        '''<summary>
        '''The second optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey2() As String
            Get
                Return Me.optionalKey2Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey2Field = value
            End Set
        End Property

        '''<summary>
        '''The third optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey3() As String
            Get
                Return Me.optionalKey3Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey3Field = value
            End Set
        End Property

        '''<summary>
        '''The fourth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey4() As String
            Get
                Return Me.optionalKey4Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey4Field = value
            End Set
        End Property

        '''<summary>
        '''The fifth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey5() As String
            Get
                Return Me.optionalKey5Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey5Field = value
            End Set
        End Property

        '''<summary>
        '''The sixth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey6() As String
            Get
                Return Me.optionalKey6Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey6Field = value
            End Set
        End Property

        '''<summary>
        '''The seventh optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey7() As String
            Get
                Return Me.optionalKey7Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey7Field = value
            End Set
        End Property

        '''<summary>
        '''The eighth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey8() As String
            Get
                Return Me.optionalKey8Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey8Field = value
            End Set
        End Property

        '''<summary>
        '''The ninth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey9() As String
            Get
                Return Me.optionalKey9Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey9Field = value
            End Set
        End Property

        '''<summary>
        '''The tenth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey10() As String
            Get
                Return Me.optionalKey10Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey10Field = value
            End Set
        End Property

        '''<summary>
        '''The eleventh optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey11() As String
            Get
                Return Me.optionalKey11Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey11Field = value
            End Set
        End Property

        '''<summary>
        '''The twelfth optional key for the row to be returned
        '''</summary>
        Public Property OptionalKey12() As String
            Get
                Return Me.optionalKey12Field
            End Get
            Set(ByVal value As String)
                Me.optionalKey12Field = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(FetchFullKeyProvided.N)> _
        Public Property FullKeyProvided() As FetchFullKeyProvided
            Get
                Return Me.fullKeyProvidedField
            End Get
            Set(ByVal value As FetchFullKeyProvided)
                Me.fullKeyProvidedField = value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "COMFCH"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            Me._xmlOut = QueryObject.Fetch(Me)
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum FetchFullKeyProvided
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
