Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.NonStockedCodeMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupQotNonStock
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of SetupQotNonStockItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupQotNonStockParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of SetupQotNonStockItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of SetupQotNonStockItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set
                Me._setupActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "QOTSNS"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupQotNonStockParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupQotNonStockParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.XmlParam
            Get
                Dim objParams As Params.SetupQotNonStock
                objParams = New Params.SetupQotNonStock
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ISetup.Post
            If (Me._setupActionTypeField = 0) Then
                Me._xmlOut = SetupObject.Add(Me)
                Return
            End If
            If (Me._setupActionTypeField = 1) Then
                Me._xmlOut = SetupObject.Update(Me)
                Return
            End If
            If (Me._setupActionTypeField = 2) Then
                Me._xmlOut = SetupObject.Delete(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XMLParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupQotNonStockItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupQotNonStockItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxDecimalsField As SetupQotNonStockItemMaxDecimals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxDecimalsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As SetupQotNonStockItemTraceableType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private leadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As SetupQotNonStockItemPartCategory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dockToStockField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitField As SetupQotNonStockItemSupplementaryUnit
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeReqd2Field As SetupQotNonStockItemRouteReqd2
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeReqd3Field As SetupQotNonStockItemRouteReqd3
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeReqd4Field As SetupQotNonStockItemRouteReqd4
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeReqd5Field As SetupQotNonStockItemRouteReqd5
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeReqd6Field As SetupQotNonStockItemRouteReqd6
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDesc6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costingMethodField As SetupQotNonStockItemCostingMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costingMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        Public Sub New()
            MyBase.New
            Me.massField = "1"
            Me.traceableTypeField = SetupQotNonStockItemTraceableType.N
            Me.supplementaryUnitField = SetupQotNonStockItemSupplementaryUnit.N
            Me.routeReqd2Field = SetupQotNonStockItemRouteReqd2.Item0
            Me.routeReqd3Field = SetupQotNonStockItemRouteReqd3.Item0
            Me.routeReqd4Field = SetupQotNonStockItemRouteReqd4.Item0
            Me.routeReqd5Field = SetupQotNonStockItemRouteReqd5.Item0
            Me.routeReqd6Field = SetupQotNonStockItemRouteReqd6.Item0
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupQotNonStockItemKey
            End If
        End Sub
        
        Public Property Key() As SetupQotNonStockItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
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
        
        Public Property Uom() As String
            Get
                Return Me.uomField
            End Get
            Set
                Me.uomField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("1")>  _
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
        
        Public Property Volume() As String
            Get
                Return Me.volumeField
            End Get
            Set
                Me.volumeField = value
            End Set
        End Property
        
        Public Property MaxDecimals() As SetupQotNonStockItemMaxDecimals
            Get
                Return Me.maxDecimalsField
            End Get
            Set
                Me.maxDecimalsField = value
                Me.MaxDecimalsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MaxDecimalsSpecified() As Boolean
            Get
                Return Me.maxDecimalsFieldSpecified
            End Get
        End Property
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemTraceableType.N)>  _
        Public Property TraceableType() As SetupQotNonStockItemTraceableType
            Get
                Return Me.traceableTypeField
            End Get
            Set
                Me.traceableTypeField = value
            End Set
        End Property
        
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        Public Property Planner() As String
            Get
                Return Me.plannerField
            End Get
            Set
                Me.plannerField = value
            End Set
        End Property
        
        Public Property LeadTime() As String
            Get
                Return Me.leadTimeField
            End Get
            Set
                Me.leadTimeField = value
            End Set
        End Property
        
        Public Property PartCategory() As SetupQotNonStockItemPartCategory
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
                Me.PartCategoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PartCategorySpecified() As Boolean
            Get
                Return Me.partCategoryFieldSpecified
            End Get
        End Property
        
        Public Property DockToStock() As String
            Get
                Return Me.dockToStockField
            End Get
            Set
                Me.dockToStockField = value
            End Set
        End Property
        
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemSupplementaryUnit.N)>  _
        Public Property SupplementaryUnit() As SetupQotNonStockItemSupplementaryUnit
            Get
                Return Me.supplementaryUnitField
            End Get
            Set
                Me.supplementaryUnitField = value
            End Set
        End Property
        
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        Public Property RouteDesc1() As String
            Get
                Return Me.routeDesc1Field
            End Get
            Set
                Me.routeDesc1Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemRouteReqd2.Item0)>  _
        Public Property RouteReqd2() As SetupQotNonStockItemRouteReqd2
            Get
                Return Me.routeReqd2Field
            End Get
            Set
                Me.routeReqd2Field = value
            End Set
        End Property
        
        Public Property RouteDesc2() As String
            Get
                Return Me.routeDesc2Field
            End Get
            Set
                Me.routeDesc2Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemRouteReqd3.Item0)>  _
        Public Property RouteReqd3() As SetupQotNonStockItemRouteReqd3
            Get
                Return Me.routeReqd3Field
            End Get
            Set
                Me.routeReqd3Field = value
            End Set
        End Property
        
        Public Property RouteDesc3() As String
            Get
                Return Me.routeDesc3Field
            End Get
            Set
                Me.routeDesc3Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemRouteReqd4.Item0)>  _
        Public Property RouteReqd4() As SetupQotNonStockItemRouteReqd4
            Get
                Return Me.routeReqd4Field
            End Get
            Set
                Me.routeReqd4Field = value
            End Set
        End Property
        
        Public Property RouteDesc4() As String
            Get
                Return Me.routeDesc4Field
            End Get
            Set
                Me.routeDesc4Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemRouteReqd5.Item0)>  _
        Public Property RouteReqd5() As SetupQotNonStockItemRouteReqd5
            Get
                Return Me.routeReqd5Field
            End Get
            Set
                Me.routeReqd5Field = value
            End Set
        End Property
        
        Public Property RouteDesc5() As String
            Get
                Return Me.routeDesc5Field
            End Get
            Set
                Me.routeDesc5Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupQotNonStockItemRouteReqd6.Item0)>  _
        Public Property RouteReqd6() As SetupQotNonStockItemRouteReqd6
            Get
                Return Me.routeReqd6Field
            End Get
            Set
                Me.routeReqd6Field = value
            End Set
        End Property
        
        Public Property RouteDesc6() As String
            Get
                Return Me.routeDesc6Field
            End Get
            Set
                Me.routeDesc6Field = value
            End Set
        End Property
        
        Public Property CostingMethod() As SetupQotNonStockItemCostingMethod
            Get
                Return Me.costingMethodField
            End Get
            Set
                Me.costingMethodField = value
                Me.CostingMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CostingMethodSpecified() As Boolean
            Get
                Return Me.costingMethodFieldSpecified
            End Get
        End Property
        
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupQotNonStockItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockCodeField As String
        
        Public Property NonStockCode() As String
            Get
                Return Me.nonStockCodeField
            End Get
            Set
                Me.nonStockCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemMaxDecimals
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemTraceableType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        T
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemPartCategory
        
        '''<remarks/>
        B
        
        '''<remarks/>
        M
        
        '''<remarks/>
        S
        
        '''<remarks/>
        G
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemSupplementaryUnit
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemRouteReqd2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemRouteReqd3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemRouteReqd4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemRouteReqd5
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemRouteReqd6
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupQotNonStockItemCostingMethod
        
        '''<remarks/>
        U
        
        '''<remarks/>
        P
    End Enum
End Namespace
