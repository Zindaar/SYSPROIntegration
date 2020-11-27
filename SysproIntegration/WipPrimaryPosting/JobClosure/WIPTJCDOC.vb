Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.JobClosure.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Complete
        
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
    Partial Public Class Distribution
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        '''<summary>
        '''Your entry at the Ledger code field is validated only if the Work in Progress module is integrated to General Ledger in detail or summary
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use the LedgerAmount field to assign the outstanding amount to the specified ledger code.
        '''
        '''
        '''</summary>
        Public Property LedgerAmount() As String
            Get
                Return Me.ledgerAmountField
            End Get
            Set
                Me.ledgerAmountField = value
            End Set
        End Property
        
        '''<summary>
        '''If ledger codes require a password, this element must contain the relevant password for the specified ledger code.
        '''</summary>
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeField As Complete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labourValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private distributionField As List(Of Distribution)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setJobCloseDateField As ItemSetJobCloseDate
        
        Public Sub New()
            MyBase.New
            Me.completeField = Complete.Y
            Me.setJobCloseDateField = ItemSetJobCloseDate.Y
            If (Me.distributionField Is Nothing) Then
                Me.distributionField = New List(Of Distribution)
            End If
        End Sub
        
        '''<summary>
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the specified posting period. If not supplied, a new journal will be created. 
        '''</summary>
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        '''<summary>
        '''Job specifies the job for which the allocations are being maintained. The format
        '''is 8 characters alphanumeric or 8 characters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''Complete job specifies whether to flag the job as complete or not ( Y -complete, N - not complete) 
        '''</summary>
        Public Property Complete() As Complete
            Get
                Return Me.completeField
            End Get
            Set
                Me.completeField = value
                Me.CompleteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CompleteSpecified() As Boolean
            Get
                Return Me.completeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''WIP material value. You use this field to indicate the outstanding material value that must be distributed for the job. This should be the outstanding work in progress material value for the job. 
        '''</summary>
        Public Property MaterialValue() As String
            Get
                Return Me.materialValueField
            End Get
            Set
                Me.materialValueField = value
            End Set
        End Property
        
        '''<summary>
        '''WIP labor value. You use this field to indicate the outstanding labor value that must be distributed for the job. This should be the outstanding work in progress labor value for the job.
        '''</summary>
        Public Property LabourValue() As String
            Get
                Return Me.labourValueField
            End Get
            Set
                Me.labourValueField = value
            End Set
        End Property
        
        '''<summary>
        '''You use the G/L Distribution function to distribute any outstanding work in progress values to the General Ledger module.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Distribution")>  _
        Public Property DistributionCollection() As List(Of Distribution)
            Get
                Return Me.distributionField
            End Get
            Set
                Me.distributionField = value
            End Set
        End Property
        
        Public Property AddReference() As String
            Get
                Return Me.addReferenceField
            End Get
            Set
                Me.addReferenceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemSetJobCloseDate.Y)>  _
        Public Property SetJobCloseDate() As ItemSetJobCloseDate
            Get
                Return Me.setJobCloseDateField
            End Get
            Set
                Me.setJobCloseDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemSetJobCloseDate
        
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
    Partial Public Class PostJobClosure
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain an allocation. 
        '''</summary>
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
                Return "WIPTJC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
                End If
                Return Me._params
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
                Dim objParams As Params.PostJobClosure
                objParams = New Params.PostJobClosure
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
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
