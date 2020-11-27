Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.MultimediaQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multimediaFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyFieldField As List(Of Byte)
        
        Public Sub New()
            MyBase.New
            If (Me.keyFieldField Is Nothing) Then
                Me.keyFieldField = New List(Of Byte)
            End If
        End Sub
        
        '''<summary>
        '''This is the type of item that we are searching against, i.e. stock code, operator code etc.
        '''</summary>
        Public Property MultimediaFlag() As String
            Get
                Return Me.multimediaFlagField
            End Get
            Set
                Me.multimediaFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the actual stock code or operator code that we are searching against.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property KeyFieldCollection() As List(Of Byte)
            Get
                Return Me.keyFieldField
            End Get
            Set
                Me.keyFieldField = value
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
    Partial Public Class [Object]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private objectTypeField As ObjectType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private objectTextField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multimediaObjectField As String
        
        '''<summary>
        '''This is the type of multimedia that we are looking for, i.e. a GIF, DOC, BMP etc.
        '''</summary>
        Public Property ObjectType() As ObjectType
            Get
                Return Me.objectTypeField
            End Get
            Set
                Me.objectTypeField = value
            End Set
        End Property

        Private Function StrToByteArray(ByVal str As String) As Byte()
            Dim encoding As New System.Text.ASCIIEncoding()
            Return encoding.GetBytes(str)
        End Function 'StrToByteArray

        Public Function ToImage() As System.Drawing.Image
            If objectTypeField <> Output.ObjectType.BMP AndAlso objectTypeField <> Output.ObjectType.GIF Then
                Throw New ApplicationException("ObjectType is not an image")
            End If
            Dim byteArray As Byte() = StrToByteArray(multimediaObjectField)
            Using ms As New System.IO.MemoryStream(byteArray, 0, byteArray.Length)
                ms.Write(byteArray, 0, byteArray.Length)
                Return System.Drawing.Image.FromStream(ms, True)
            End Using
        End Function

        '''<summary>
        '''This is a description of the ObjectType.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the path to the object. May make use of default placeholders, i.e. %media, %stock etc.
        '''</summary>
        Public Property ObjectText() As String
            Get
                Return Me.objectTextField
            End Get
            Set
                Me.objectTextField = value
            End Set
        End Property
        
        '''<summary>
        '''This contains a CDATA section which contains the object.
        '''</summary>
        Public Property MultimediaObject() As String
            Get
                Return Me.multimediaObjectField
            End Get
            Set
                Me.multimediaObjectField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ObjectType
        
        '''<remarks/>
        BMP
        
        '''<remarks/>
        DOC

        '''<remarks/>
        GIF

    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private objectField As List(Of [Object])
        
        Public Sub New()
            MyBase.New
            If (Me.objectField Is Nothing) Then
                Me.objectField = New List(Of [Object])
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub

        Public Shared Function CreateFromXMLOut(ByVal strXMLOut As String) As Query
            Using stream As New IO.StringReader(strXMLOut)

                Dim s As New System.Xml.Serialization.XmlSerializer(GetType(Query))

                Dim qry As Query = s.Deserialize(stream)

                Return qry
            End Using
        End Function


        '''<summary>
        '''This is used to search for a particular object(s) against a item code.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set(ByVal value As Key)
                Me.keyField = value
            End Set
        End Property

        '''<summary>
        '''Contains the information for each object. Multiple objects can be defined against an item code.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Object")> _
        Public Property ObjectCollection() As List(Of [Object])
            Get
                Return Me.objectField
            End Get
            Set(ByVal value As List(Of [Object]))
                Me.objectField = value
            End Set
        End Property
    End Class
End Namespace

