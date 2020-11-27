Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorParentDetails.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostConfiguration
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostConfigurationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostConfigurationItem
            End If
        End Sub
        
        Public Property Item() As PostConfigurationItem
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
                Return "CFGTPD"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostConfigurationParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostConfigurationParameters
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
                Dim objParams As Params.PostConfiguration
                objParams = New Params.PostConfiguration
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
    Partial Public Class PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentDetailsField As PostConfigurationItemParentDetails
        
        Public Sub New()
            MyBase.New
            If (Me.parentDetailsField Is Nothing) Then
                Me.parentDetailsField = New PostConfigurationItemParentDetails
            End If
        End Sub
        
        Public Property ParentDetails() As PostConfigurationItemParentDetails
            Get
                Return Me.parentDetailsField
            End Get
            Set
                Me.parentDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemParentDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As PostConfigurationItemParentDetailsType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useExistingParentField As PostConfigurationItemParentDetailsUseExistingParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentCompWhField As PostConfigurationItemParentDetailsUseParentCompWh
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentCompWhFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.useExistingParentField = PostConfigurationItemParentDetailsUseExistingParent.N
        End Sub
        
        Public Property Type() As PostConfigurationItemParentDetailsType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
                Me.TypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property LongDescription() As String
            Get
                Return Me.longDescriptionField
            End Get
            Set
                Me.longDescriptionField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemParentDetailsUseExistingParent.N)>  _
        Public Property UseExistingParent() As PostConfigurationItemParentDetailsUseExistingParent
            Get
                Return Me.useExistingParentField
            End Get
            Set
                Me.useExistingParentField = value
            End Set
        End Property
        
        Public Property UseParentCompWh() As PostConfigurationItemParentDetailsUseParentCompWh
            Get
                Return Me.useParentCompWhField
            End Get
            Set
                Me.useParentCompWhField = value
                Me.UseParentCompWhFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseParentCompWhSpecified() As Boolean
            Get
                Return Me.useParentCompWhFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemParentDetailsType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemParentDetailsUseExistingParent
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemParentDetailsUseParentCompWh
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
