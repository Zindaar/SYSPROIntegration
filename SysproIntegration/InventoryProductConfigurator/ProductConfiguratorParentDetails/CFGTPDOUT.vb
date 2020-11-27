Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.ProductConfiguratorParentDetails.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class postconfiguration
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As postconfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New postconfigurationItem
            End If
        End Sub
        
        Public Property Item() As postconfigurationItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Language() As SByte
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As SByte)
                Me.languageField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property DecFormat() As Boolean
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property DateFormat() As SByte
            Get
                Return Me.dateFormatField
            End Get
            Set(ByVal value As SByte)
                Me.dateFormatField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Role() As SByte
            Get
                Return Me.roleField
            End Get
            Set(ByVal value As SByte)
                Me.roleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentDetailsField As postconfigurationItemParentDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentConfigurationObjectField As postconfigurationItemCurrentConfigurationObject
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As postconfigurationItemParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New postconfigurationItemParameters
            End If
            If (Me.parentDetailsField Is Nothing) Then
                Me.parentDetailsField = New postconfigurationItemParentDetails
            End If
        End Sub
        
        Public Property ParentDetails() As postconfigurationItemParentDetails
            Get
                Return Me.parentDetailsField
            End Get
            Set
                Me.parentDetailsField = value
            End Set
        End Property
        
        Public Property CurrentConfigurationObject() As postconfigurationItemCurrentConfigurationObject
            Get
                Return Me.currentConfigurationObjectField
            End Get
            Set
                Me.currentConfigurationObjectField = value
            End Set
        End Property
        
        Public Property Parameters() As postconfigurationItemParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemParentDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As postconfigurationItemParentDetailsType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOptionField As postconfigurationItemParentDetailsTypeOption
        
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
        Private overrideGeneratedFieldsField As postconfigurationItemParentDetailsOverrideGeneratedFields
        
        Public Property Type() As postconfigurationItemParentDetailsType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        Public Property TypeOption() As postconfigurationItemParentDetailsTypeOption
            Get
                Return Me.typeOptionField
            End Get
            Set
                Me.typeOptionField = value
            End Set
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
        
        Public Property OverrideGeneratedFields() As postconfigurationItemParentDetailsOverrideGeneratedFields
            Get
                Return Me.overrideGeneratedFieldsField
            End Get
            Set
                Me.overrideGeneratedFieldsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemParentDetailsType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemParentDetailsTypeOption
        
        '''<remarks/>
        S
        
        '''<remarks/>
        N
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemParentDetailsOverrideGeneratedFields
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemCurrentConfigurationObject
        
        '''<remarks/>
        CFGTPD
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class postconfigurationItemParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private functionField As postconfigurationItemParametersFunction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private configurationInstanceField As String
        
        Public Property [Function]() As postconfigurationItemParametersFunction
            Get
                Return Me.functionField
            End Get
            Set
                Me.functionField = value
            End Set
        End Property
        
        Public Property ConfigurationInstance() As String
            Get
                Return Me.configurationInstanceField
            End Get
            Set
                Me.configurationInstanceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum postconfigurationItemParametersFunction
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
    End Enum
End Namespace
