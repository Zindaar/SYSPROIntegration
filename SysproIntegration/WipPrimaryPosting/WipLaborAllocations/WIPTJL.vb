Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.WipLaborAllocations.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private snapshotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As String
        
        Public Sub New()
            MyBase.New
            Me.validateOnlyField = "Y"
            Me.ignoreWarningsField = "Y"
            Me.snapshotField = "N"
            Me.actionTypeField = "A"
        End Sub
        
        '''<summary>
        '''Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document).
        '''</summary>
        Public Property ValidateOnly() As String
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a ledger code entered is not the correct type of account, it is okay to write the record away as such but you may want the warning supplied.
        '''</summary>
        Public Property IgnoreWarnings() As String
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies whether to maintain live, suggested or snapshot allocations (N -  live,Y - snapshot, S- suggested) 
        '''</summary>
        Public Property Snapshot() As String
            Get
                Return Me.snapshotField
            End Get
            Set
                Me.snapshotField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies whether to add update or delete allocations (A - add,  C - update,  D - delete)
        '''</summary>
        Public Property ActionType() As String
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
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
    Partial Public Class PostLabourAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This element contains the optional parameter elements.
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
