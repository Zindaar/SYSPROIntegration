Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemPosting.ComPostEmailBusinessObject.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Email
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private senderCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recipientField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subjectField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bodyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priorityField As Priority
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priorityFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.priorityField = Priority.Item1
        End Sub
        
        '''<summary>
        '''Name of the person that is sending the email.  If blank ,the display email address from the document flow manager setup will be used.
        '''</summary>
        Public Property SenderCode() As String
            Get
                Return Me.senderCodeField
            End Get
            Set
                Me.senderCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The email address that the attachment must be sent to.  If blank, the display address from the document flow manager setup will be used.
        '''</summary>
        Public Property Recipient() As String
            Get
                Return Me.recipientField
            End Get
            Set
                Me.recipientField = value
            End Set
        End Property
        
        '''<summary>
        '''The email subject.
        '''</summary>
        Public Property Subject() As String
            Get
                Return Me.subjectField
            End Get
            Set
                Me.subjectField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for a message in the body of the Email
        '''
        '''</summary>
        Public Property Body() As String
            Get
                Return Me.bodyField
            End Get
            Set
                Me.bodyField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows you to set a priority in the Email. If blank it will default to 1.
        '''( 0 - Low, 1 - Medium, 3 - High ).
        '''</summary>
        Public Property Priority() As Priority
            Get
                Return Me.priorityField
            End Get
            Set
                Me.priorityField = value
                Me.PriorityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrioritySpecified() As Boolean
            Get
                Return Me.priorityFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Priority
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0 ")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2 ")>  _
        Item2
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fileExtensionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private smtpIpAddressField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As Email
        
        Public Sub New()
            MyBase.New
            Me.fileExtensionField = "XML"
            If (Me.emailField Is Nothing) Then
                Me.emailField = New Email
            End If
        End Sub
        
        '''<summary>
        '''The file extension to be used for the attachment that is going to be emailed.
        '''If blank it will default to XML
        '''</summary>
        Public Property FileExtension() As String
            Get
                Return Me.fileExtensionField
            End Get
            Set
                Me.fileExtensionField = value
            End Set
        End Property
        
        '''<summary>
        '''Compulsary element that contains the IP address of the SMTP server
        '''</summary>
        Public Property SmtpIpAddress() As String
            Get
                Return Me.smtpIpAddressField
            End Get
            Set
                Me.smtpIpAddressField = value
            End Set
        End Property
        
        '''<summary>
        '''Compulsary element that contains the email details
        '''
        '''</summary>
        Public Property Email() As Email
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
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
    Partial Public Class PostEmailDocument
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        '''<summary>
        '''Compulsary element that contains the parameters 
        '''
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
