Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipProjectsAndContracts.PCRetentionHeaderCreation.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostRetentions
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostRetentionsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostRetentionsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostRetentionsItem
            End If
        End Sub
        
        Public Property Item() As PostRetentionsItem
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
                Return "PRJTRH"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostRetentionsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostRetentionsParameters
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
                Dim objParams As Params.PostRetentions
                objParams = New Params.PostRetentions
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostRetentionsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionTypeField As PostRetentionsItemRetentionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionRemainingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionCustomerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstTaxCodeField As String
        
        Public Sub New()
            MyBase.New
            Me.retentionTypeField = PostRetentionsItemRetentionType.P
        End Sub
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property RetentionType() As PostRetentionsItemRetentionType
            Get
                Return Me.retentionTypeField
            End Get
            Set
                Me.retentionTypeField = value
            End Set
        End Property
        
        Public Property RetentionPercent() As String
            Get
                Return Me.retentionPercentField
            End Get
            Set
                Me.retentionPercentField = value
            End Set
        End Property
        
        Public Property RetentionValue() As String
            Get
                Return Me.retentionValueField
            End Get
            Set
                Me.retentionValueField = value
            End Set
        End Property
        
        Public Property RetentionRemaining() As String
            Get
                Return Me.retentionRemainingField
            End Get
            Set
                Me.retentionRemainingField = value
            End Set
        End Property
        
        Public Property RetentionCustomer() As String
            Get
                Return Me.retentionCustomerField
            End Get
            Set
                Me.retentionCustomerField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        Public Property GstTaxCode() As String
            Get
                Return Me.gstTaxCodeField
            End Get
            Set
                Me.gstTaxCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostRetentionsItemRetentionType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
    End Enum
End Namespace
