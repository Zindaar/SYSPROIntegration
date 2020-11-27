Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorSelectionCriteria.Data
    
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
                Return "CFGTSC"
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
        Private selectionCriteriaField As PostConfigurationItemSelectionCriteria
        
        Public Sub New()
            MyBase.New
            If (Me.selectionCriteriaField Is Nothing) Then
                Me.selectionCriteriaField = New PostConfigurationItemSelectionCriteria
            End If
        End Sub
        
        Public Property SelectionCriteria() As PostConfigurationItemSelectionCriteria
            Get
                Return Me.selectionCriteriaField
            End Get
            Set
                Me.selectionCriteriaField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostConfigurationItemSelectionCriteria
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private skipOptionalSelectionField As PostConfigurationItemSelectionCriteriaSkipOptionalSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private criteriaLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private criteriaValueField As String
        
        Public Sub New()
            MyBase.New
            Me.skipOptionalSelectionField = PostConfigurationItemSelectionCriteriaSkipOptionalSelection.N
        End Sub
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSelectionCriteriaSkipOptionalSelection.N)>  _
        Public Property SkipOptionalSelection() As PostConfigurationItemSelectionCriteriaSkipOptionalSelection
            Get
                Return Me.skipOptionalSelectionField
            End Get
            Set
                Me.skipOptionalSelectionField = value
            End Set
        End Property
        
        Public Property CriteriaLine() As String
            Get
                Return Me.criteriaLineField
            End Get
            Set
                Me.criteriaLineField = value
            End Set
        End Property
        
        Public Property CriteriaValue() As String
            Get
                Return Me.criteriaValueField
            End Get
            Set
                Me.criteriaValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSelectionCriteriaSkipOptionalSelection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
