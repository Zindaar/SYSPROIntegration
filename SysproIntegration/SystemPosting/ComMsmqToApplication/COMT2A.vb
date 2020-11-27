Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemPosting.ComMsmqToApplication.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applicationToCallField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applicationParameterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentDropDirectoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extensionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preserveNullsField As String
        
        Public Sub New()
            MyBase.New
            Me.extensionField = "XML"
            Me.preserveNullsField = "Y"
        End Sub
        
        '''<summary>
        '''The name of the application that must be called.  Ensure that the full path and the name of the application is provided.  e.g. "C:\Program Files\Application\MyVB6.EXE".  If this element is blank no application will be called.
        '''</summary>
        Public Property ApplicationToCall() As String
            Get
                Return Me.applicationToCallField
            End Get
            Set
                Me.applicationToCallField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows a parameter to be passed to the application that is going to be called. The value of this element will only be used if the ApplicationToCall element is valid. If you want the path to the file that was created to be sent through as part of the parameter, simply include the word "$FILENAME" in this element
        '''</summary>
        Public Property ApplicationParameter() As String
            Get
                Return Me.applicationParameterField
            End Get
            Set
                Me.applicationParameterField = value
            End Set
        End Property
        
        '''<summary>
        '''A full path to where the document must be dropped.  This path must already exist as the program will not create the directory.  Do not include a filename as a temporary filename will be created using the extension specified in the Extension element. e.g. "c:\My Dropdirectory"
        '''</summary>
        Public Property DocumentDropDirectory() As String
            Get
                Return Me.documentDropDirectoryField
            End Get
            Set
                Me.documentDropDirectoryField = value
            End Set
        End Property
        
        '''<summary>
        '''A file extension to the document that is created in the dropdirectory. If blank the default extension is XML
        '''</summary>
        Public Property Extension() As String
            Get
                Return Me.extensionField
            End Get
            Set
                Me.extensionField = value
            End Set
        End Property
        
        Public Property PreserveNulls() As String
            Get
                Return Me.preserveNullsField
            End Get
            Set
                Me.preserveNullsField = value
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
    Partial Public Class PostTransApplication
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''Compulsary element that contains the parameters
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
