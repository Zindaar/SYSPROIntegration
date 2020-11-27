Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace BillOfMaterialPrimaryQuery.BomProgressiveScrapQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionsField As QueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of QueryItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of QueryItem)
            End If
            If (Me.optionsField Is Nothing) Then
                Me.optionsField = New QueryOptions
            End If
        End Sub
        
        Public Property Options() As QueryOptions
            Get
                Return Me.optionsField
            End Get
            Set
                Me.optionsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of QueryItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "BOMQPS"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityBasisField As QueryOptionsQuantityBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossOrNetField As QueryOptionsGrossOrNet
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeComponentsField As QueryOptionsIncludeComponents
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationsField As QueryOptionsIncludeOperations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As QueryOptionsIncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNarrationsField As QueryOptionsIncludeNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCoProductField As QueryOptionsIncludeCoProduct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As QueryOptionsCostBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useWhRouteField As QueryOptionsUseWhRoute
        
        Public Sub New()
            MyBase.New
            Me.quantityBasisField = QueryOptionsQuantityBasis.M
            Me.grossOrNetField = QueryOptionsGrossOrNet.N
            Me.includeComponentsField = QueryOptionsIncludeComponents.N
            Me.includeOperationsField = QueryOptionsIncludeOperations.Y
            Me.includeCustomFormsField = QueryOptionsIncludeCustomForms.N
            Me.includeNarrationsField = QueryOptionsIncludeNarrations.N
            Me.includeCoProductField = QueryOptionsIncludeCoProduct.N
            Me.costBasisField = QueryOptionsCostBasis.N
            Me.useWhRouteField = QueryOptionsUseWhRoute.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsQuantityBasis.M)>  _
        Public Property QuantityBasis() As QueryOptionsQuantityBasis
            Get
                Return Me.quantityBasisField
            End Get
            Set
                Me.quantityBasisField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsGrossOrNet.N)>  _
        Public Property GrossOrNet() As QueryOptionsGrossOrNet
            Get
                Return Me.grossOrNetField
            End Get
            Set
                Me.grossOrNetField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsIncludeComponents.N)>  _
        Public Property IncludeComponents() As QueryOptionsIncludeComponents
            Get
                Return Me.includeComponentsField
            End Get
            Set
                Me.includeComponentsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsIncludeOperations.Y)>  _
        Public Property IncludeOperations() As QueryOptionsIncludeOperations
            Get
                Return Me.includeOperationsField
            End Get
            Set
                Me.includeOperationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsIncludeCustomForms.N)>  _
        Public Property IncludeCustomForms() As QueryOptionsIncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsIncludeNarrations.N)>  _
        Public Property IncludeNarrations() As QueryOptionsIncludeNarrations
            Get
                Return Me.includeNarrationsField
            End Get
            Set
                Me.includeNarrationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsIncludeCoProduct.N)>  _
        Public Property IncludeCoProduct() As QueryOptionsIncludeCoProduct
            Get
                Return Me.includeCoProductField
            End Get
            Set
                Me.includeCoProductField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsCostBasis.N)>  _
        Public Property CostBasis() As QueryOptionsCostBasis
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionsUseWhRoute.N)>  _
        Public Property UseWhRoute() As QueryOptionsUseWhRoute
            Get
                Return Me.useWhRouteField
            End Get
            Set
                Me.useWhRouteField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsQuantityBasis
        
        '''<remarks/>
        M
        
        '''<remarks/>
        S
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsGrossOrNet
        
        '''<remarks/>
        N
        
        '''<remarks/>
        G
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsIncludeComponents
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsIncludeOperations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsIncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsIncludeNarrations
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsIncludeCoProduct
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsCostBasis
        
        '''<remarks/>
        N
        
        '''<remarks/>
        B
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionsUseWhRoute
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
    End Class
End Namespace
