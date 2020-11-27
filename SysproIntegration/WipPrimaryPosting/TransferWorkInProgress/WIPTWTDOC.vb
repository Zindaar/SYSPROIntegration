Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.TransferWorkInProgress.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostWipTransfer
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostWipTransferItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostWipTransferParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostWipTransferItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostWipTransferItem)
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
                Return "WIPTWT"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostWipTransferParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostWipTransferParameters
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
                Dim objParams As Params.PostWipTransfer
                objParams = New Params.PostWipTransfer
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
    Partial Public Class PostWipTransferItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partBillingJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inventoryJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobCompleteField As PostWipTransferItemJobComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private closeDateField As PostWipTransferItemCloseDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipValueBasisField As PostWipTransferItemWipValueBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private laborValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As PostWipTransferItemCostBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotConcessionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotCertificateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialReferenceField As String
        
        Public Sub New()
            MyBase.New
            Me.jobCompleteField = PostWipTransferItemJobComplete.N
            Me.closeDateField = PostWipTransferItemCloseDate.N
            Me.wipValueBasisField = PostWipTransferItemWipValueBasis.A
        End Sub
        
        Public Property PartBillingJournal() As String
            Get
                Return Me.partBillingJournalField
            End Get
            Set
                Me.partBillingJournalField = value
            End Set
        End Property
        
        Public Property InventoryJournal() As String
            Get
                Return Me.inventoryJournalField
            End Get
            Set
                Me.inventoryJournalField = value
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
        
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipTransferItemJobComplete.N)>  _
        Public Property JobComplete() As PostWipTransferItemJobComplete
            Get
                Return Me.jobCompleteField
            End Get
            Set
                Me.jobCompleteField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostWipTransferItemCloseDate.N)>  _
        Public Property CloseDate() As PostWipTransferItemCloseDate
            Get
                Return Me.closeDateField
            End Get
            Set
                Me.closeDateField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(PostWipTransferItemWipValueBasis.A)>  _
        Public Property WipValueBasis() As PostWipTransferItemWipValueBasis
            Get
                Return Me.wipValueBasisField
            End Get
            Set
                Me.wipValueBasisField = value
            End Set
        End Property
        
        Public Property MaterialValue() As String
            Get
                Return Me.materialValueField
            End Get
            Set
                Me.materialValueField = value
            End Set
        End Property
        
        Public Property LaborValue() As String
            Get
                Return Me.laborValueField
            End Get
            Set
                Me.laborValueField = value
            End Set
        End Property
        
        Public Property CostBasis() As PostWipTransferItemCostBasis
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
                Me.CostBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CostBasisSpecified() As Boolean
            Get
                Return Me.costBasisFieldSpecified
            End Get
        End Property
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        Public Property LotConcession() As String
            Get
                Return Me.lotConcessionField
            End Get
            Set
                Me.lotConcessionField = value
            End Set
        End Property
        
        Public Property LotCertificate() As String
            Get
                Return Me.lotCertificateField
            End Get
            Set
                Me.lotCertificateField = value
            End Set
        End Property
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
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
        
        Public Property MaterialReference() As String
            Get
                Return Me.materialReferenceField
            End Get
            Set
                Me.materialReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipTransferItemJobComplete
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipTransferItemCloseDate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipTransferItemWipValueBasis
        
        '''<remarks/>
        A
        
        '''<remarks/>
        E
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostWipTransferItemCostBasis
        
        '''<remarks/>
        U
        
        '''<remarks/>
        T
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
