Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.MultimediaSetup.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StatusOfItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recordsReadField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recordsInvalidField As Boolean
        
        '''<summary>
        '''The number of records matching the "key" element that were read.
        '''</summary>
        Public Property RecordsRead() As Boolean
            Get
                Return Me.recordsReadField
            End Get
            Set
                Me.recordsReadField = value
            End Set
        End Property
        
        '''<summary>
        '''The number of errors that occurred while a particular setup method was being performed.
        '''</summary>
        Public Property RecordsInvalid() As Boolean
            Get
                Return Me.recordsInvalidField
            End Get
            Set
                Me.recordsInvalidField = value
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
    Partial Public Class item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As key
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the multi-part key upon which a setup method is performed. The fields that make up the key are MultimediaFlag, KeyField and ObjectType.
        '''</summary>
        Public Property key() As key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
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
    Partial Public Class key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multimediaflagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyfieldField As List(Of Byte)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private objecttypeField As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyfieldField Is Nothing) Then
                Me.keyfieldField = New List(Of Byte)
            End If
        End Sub
        
        '''<summary>
        '''This is an indication of the field type that the KeyField will be referencing, i.e. STK - stock code, LDG - ledger code, CUR - currency, SUP - supplier etc.
        '''</summary>
        Public Property multimediaflag() As String
            Get
                Return Me.multimediaflagField
            End Get
            Set
                Me.multimediaflagField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the key value on which the search will be performed.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property keyfieldCollection() As List(Of Byte)
            Get
                Return Me.keyfieldField
            End Get
            Set
                Me.keyfieldField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the type of multimedia object returned, i.e. BMP, SND, VID etc.
        '''</summary>
        Public Property objecttype() As String
            Get
                Return Me.objecttypeField
            End Get
            Set
                Me.objecttypeField = value
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
    Partial Public Class setupmultimedia
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusOfItemsField As StatusOfItems
        
        Public Sub New()
            MyBase.New
            If (Me.statusOfItemsField Is Nothing) Then
                Me.statusOfItemsField = New StatusOfItems
            End If
            If (Me.itemField Is Nothing) Then
                Me.itemField = New item
            End If
        End Sub
        
        '''<summary>
        '''This element contains all the pertinent information regarding the stock code and the multimedia attached - or not - to said stock code.
        '''</summary>
        Public Property item() As item
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains information about the number of records read and how many were invalid.
        '''</summary>
        Public Property StatusOfItems() As StatusOfItems
            Get
                Return Me.statusOfItemsField
            End Get
            Set
                Me.statusOfItemsField = value
            End Set
        End Property
    End Class
End Namespace
