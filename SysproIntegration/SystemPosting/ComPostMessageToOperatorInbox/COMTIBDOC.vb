Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemPosting.ComPostMessageToOperatorInbox.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CompanyId
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Date]
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class FromName
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class FromOperator
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As CompanyId
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorField As [Operator]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As [Date]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeField As Time
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private messageTypeField As MessageType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subjectField As Subject
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromOperatorField As FromOperator
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromNameField As FromName
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private programToRunField As ProgramToRun
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private programParametersField As ProgramParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preventDuplicateField As PreventDuplicate
        
        Public Sub New()
            MyBase.New
            If (Me.preventDuplicateField Is Nothing) Then
                Me.preventDuplicateField = New PreventDuplicate
            End If
            If (Me.programParametersField Is Nothing) Then
                Me.programParametersField = New ProgramParameters
            End If
            If (Me.programToRunField Is Nothing) Then
                Me.programToRunField = New ProgramToRun
            End If
            If (Me.fromNameField Is Nothing) Then
                Me.fromNameField = New FromName
            End If
            If (Me.fromOperatorField Is Nothing) Then
                Me.fromOperatorField = New FromOperator
            End If
            If (Me.subjectField Is Nothing) Then
                Me.subjectField = New Subject
            End If
            If (Me.messageTypeField Is Nothing) Then
                Me.messageTypeField = New MessageType
            End If
            If (Me.timeField Is Nothing) Then
                Me.timeField = New Time
            End If
            If (Me.dateField Is Nothing) Then
                Me.dateField = New [Date]
            End If
            If (Me.operatorField Is Nothing) Then
                Me.operatorField = New [Operator]
            End If
            If (Me.companyIdField Is Nothing) Then
                Me.companyIdField = New CompanyId
            End If
        End Sub
        
        '''<summary>
        '''Company id to which to post message. Defaults to current company.
        '''</summary>
        Public Property CompanyId() As CompanyId
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = value
            End Set
        End Property
        
        '''<summary>
        '''The operator for whom the message is intended. The operator must be valid.
        '''</summary>
        Public Property [Operator]() As [Operator]
            Get
                Return Me.operatorField
            End Get
            Set
                Me.operatorField = value
            End Set
        End Property
        
        '''<summary>
        '''The date on which the message is to be actioned. If no date is supplied then the action date will be 'zeroes' indicating that the message should be actioned immediately.
        '''</summary>
        Public Property [Date]() As [Date]
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        '''<summary>
        '''The time of the message in the format   HHMMSSHH (hours, minutes, seconds, hundreds of second). No validation is performed on the time format supplied.
        '''If no time is supplied a default of zeroes is assumed. A time element can be useful to uniquely identify each message, if posting many messages to the same operator on the same date.
        '''
        '''</summary>
        Public Property Time() As Time
            Get
                Return Me.timeField
            End Get
            Set
                Me.timeField = value
            End Set
        End Property
        
        '''<summary>
        '''Messages can be indentified uniquely using a message type. If no type is supplied the object will default to 'USR'. 
        '''</summary>
        Public Property MessageType() As MessageType
            Get
                Return Me.messageTypeField
            End Get
            Set
                Me.messageTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''The subject text of the message.
        '''</summary>
        Public Property Subject() As Subject
            Get
                Return Me.subjectField
            End Get
            Set
                Me.subjectField = value
            End Set
        End Property
        
        '''<summary>
        '''The operator id from whom the message was sent.
        '''</summary>
        Public Property FromOperator() As FromOperator
            Get
                Return Me.fromOperatorField
            End Get
            Set
                Me.fromOperatorField = value
            End Set
        End Property
        
        '''<summary>
        '''The name of the operator from whom the message was sent.
        '''</summary>
        Public Property FromName() As FromName
            Get
                Return Me.fromNameField
            End Get
            Set
                Me.fromNameField = value
            End Set
        End Property
        
        '''<summary>
        '''The name of a SYSPRO program to run when the message is 'read' by the operator.
        '''</summary>
        Public Property ProgramToRun() As ProgramToRun
            Get
                Return Me.programToRunField
            End Get
            Set
                Me.programToRunField = value
            End Set
        End Property
        
        '''<summary>
        '''Programs in SYSPRO can accept special parameters being passed to them so that they perform specific tasks automatically. You can define these parameters in this element.
        '''</summary>
        Public Property ProgramParameters() As ProgramParameters
            Get
                Return Me.programParametersField
            End Get
            Set
                Me.programParametersField = value
            End Set
        End Property
        
        '''<summary>
        '''Set this parameter to 'Y' if you wish to prevent messages containing the same message text being displayed in the operator's message inbox. The default is 'N'.
        '''</summary>
        Public Property PreventDuplicate() As PreventDuplicate
            Get
                Return Me.preventDuplicateField
            End Get
            Set
                Me.preventDuplicateField = value
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
    Partial Public Class [Operator]
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Time
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class MessageType
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Subject
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ProgramToRun
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ProgramParameters
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PreventDuplicate
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Message
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New Item
            End If
        End Sub
        
        Public Property Item() As Item
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "COMTIB"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Return ""
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
