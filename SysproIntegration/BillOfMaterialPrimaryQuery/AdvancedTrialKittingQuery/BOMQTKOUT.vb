Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace BillOfMaterialPrimaryQuery.AdvancedTrialKittingQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class TrialKittingQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of TrialKittingQueryComponent)
        
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
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of TrialKittingQueryComponent)
            End If
        End Sub

        Public Shared Function CreateFromXMLOut(ByVal strXMLOut As String) As TrialKittingQuery
            Using stream As New IO.StringReader(strXMLOut)

                Dim s As New System.Xml.Serialization.XmlSerializer(GetType(TrialKittingQuery))

                Dim qry As TrialKittingQuery = s.Deserialize(stream)

                Return qry
            End Using
        End Function

        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of TrialKittingQueryComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
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
                Me.roleField = Value
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
    Partial Public Class TrialKittingQueryComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentLevelField As List(Of TrialKittingQueryComponentComponentLevel)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplyDemandField As List(Of TrialKittingQueryComponentSupplyDemand)
        
        Public Sub New()
            MyBase.New
            If (Me.supplyDemandField Is Nothing) Then
                Me.supplyDemandField = New List(Of TrialKittingQueryComponentSupplyDemand)
            End If
            If (Me.componentLevelField Is Nothing) Then
                Me.componentLevelField = New List(Of TrialKittingQueryComponentComponentLevel)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("ComponentLevel")>  _
        Public Property ComponentLevelCollection() As List(Of TrialKittingQueryComponentComponentLevel)
            Get
                Return Me.componentLevelField
            End Get
            Set
                Me.componentLevelField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SupplyDemand")>  _
        Public Property SupplyDemandCollection() As List(Of TrialKittingQueryComponentSupplyDemand)
            Get
                Return Me.supplyDemandField
            End Get
            Set
                Me.supplyDemandField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class TrialKittingQueryComponentComponentLevel
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private levelField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQtyRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netQtyRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityAvailableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityOnOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shortageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partTypeField As TrialKittingQueryComponentComponentLevelPartType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As TrialKittingQueryComponentComponentLevelDecimals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private leadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldField As TrialKittingQueryComponentComponentLevelOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentSourceField As List(Of TrialKittingQueryComponentComponentLevelComponentSource)
        
        Public Sub New()
            MyBase.New
            If (Me.componentSourceField Is Nothing) Then
                Me.componentSourceField = New List(Of TrialKittingQueryComponentComponentLevelComponentSource)
            End If
        End Sub
        
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the component stock code/non-stock code required. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which warehouse was used to establish a quantity on hand for the component, as well as the warehouse that was used to establish the supply and demand affecting the component. If more than one warehouse was used then this element will contain '--'. The format is up to 2 characters alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
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
        
        Public Property Level() As String
            Get
                Return Me.levelField
            End Get
            Set
                Me.levelField = value
            End Set
        End Property
        
        Public Property StockCodeDescription() As String
            Get
                Return Me.stockCodeDescriptionField
            End Get
            Set
                Me.stockCodeDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the unit of measure. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property GrossQtyRequired() As String
            Get
                Return Me.grossQtyRequiredField
            End Get
            Set
                Me.grossQtyRequiredField = value
            End Set
        End Property
        
        Public Property NetQtyRequired() As String
            Get
                Return Me.netQtyRequiredField
            End Get
            Set
                Me.netQtyRequiredField = value
            End Set
        End Property
        
        Public Property QuantityAvailable() As String
            Get
                Return Me.quantityAvailableField
            End Get
            Set
                Me.quantityAvailableField = value
            End Set
        End Property
        
        Public Property QuantityOnOrder() As String
            Get
                Return Me.quantityOnOrderField
            End Get
            Set
                Me.quantityOnOrderField = value
            End Set
        End Property
        
        Public Property Shortage() As String
            Get
                Return Me.shortageField
            End Get
            Set
                Me.shortageField = value
            End Set
        End Property
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property PartType() As TrialKittingQueryComponentComponentLevelPartType
            Get
                Return Me.partTypeField
            End Get
            Set
                Me.partTypeField = value
            End Set
        End Property
        
        Public Property Decimals() As TrialKittingQueryComponentComponentLevelDecimals
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
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
        
        Public Property OnHold() As TrialKittingQueryComponentComponentLevelOnHold
            Get
                Return Me.onHoldField
            End Get
            Set
                Me.onHoldField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ComponentSource")>  _
        Public Property ComponentSourceCollection() As List(Of TrialKittingQueryComponentComponentLevelComponentSource)
            Get
                Return Me.componentSourceField
            End Get
            Set
                Me.componentSourceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TrialKittingQueryComponentComponentLevelPartType
        
        '''<remarks/>
        B
        
        '''<remarks/>
        M
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TrialKittingQueryComponentComponentLevelDecimals
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TrialKittingQueryComponentComponentLevelOnHold
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        P
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class TrialKittingQueryComponentComponentLevelComponentSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceField As TrialKittingQueryComponentComponentLevelComponentSourceSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceKeyField As TrialKittingQueryComponentComponentLevelComponentSourceSourceKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentReleaseField As String
        
        Public Sub New()
            MyBase.New
            If (Me.sourceKeyField Is Nothing) Then
                Me.sourceKeyField = New TrialKittingQueryComponentComponentLevelComponentSourceSourceKey
            End If
        End Sub
        
        Public Property Source() As TrialKittingQueryComponentComponentLevelComponentSourceSource
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = value
            End Set
        End Property
        
        Public Property SourceKey() As TrialKittingQueryComponentComponentLevelComponentSourceSourceKey
            Get
                Return Me.sourceKeyField
            End Get
            Set
                Me.sourceKeyField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the required date for the source or the date of the supply or demand. The date format is CCYY-MM-DD.
        '''</summary>
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the required quantity for the source or the supply or demand quantity. The format is a signed numeric with 7 integers with 3 decimals.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the unit of measure. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the stock code for the source or the parent part for the component within the BOM structure for supply and demand records. The format is either up to 30 characters alphanumeric or up to 15 characters numeric depending on the key configuration for stock code within SYSPRO. 
        '''</summary>
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
        Public Property ParentVersion() As String
            Get
                Return Me.parentVersionField
            End Get
            Set
                Me.parentVersionField = value
            End Set
        End Property
        
        Public Property ParentRelease() As String
            Get
                Return Me.parentReleaseField
            End Get
            Set
                Me.parentReleaseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TrialKittingQueryComponentComponentLevelComponentSourceSource
        
        '''<remarks/>
        P
        
        '''<remarks/>
        N
        
        '''<remarks/>
        S
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        J
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class TrialKittingQueryComponentComponentLevelComponentSourceSourceKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        '''<summary>
        '''This indicates the component stock code/non-stock code required. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
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
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class TrialKittingQueryComponentSupplyDemand
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As TrialKittingQueryComponentSupplyDemandType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As TrialKittingQueryComponentSupplyDemandKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentReleaseField As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New TrialKittingQueryComponentSupplyDemandKey
            End If
        End Sub
        
        '''<summary>
        '''This indicates the required date for the source or the date of the supply or demand. The date format is CCYY-MM-DD.
        '''</summary>
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        Public Property Type() As TrialKittingQueryComponentSupplyDemandType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        Public Property Key() As TrialKittingQueryComponentSupplyDemandKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the unit of measure. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the required quantity for the source or the supply or demand quantity. The format is a signed numeric with 7 integers with 3 decimals.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the stock code for the source or the parent part for the component within the BOM structure for supply and demand records. The format is either up to 30 characters alphanumeric or up to 15 characters numeric depending on the key configuration for stock code within SYSPRO. 
        '''</summary>
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
        Public Property ParentVersion() As String
            Get
                Return Me.parentVersionField
            End Get
            Set
                Me.parentVersionField = value
            End Set
        End Property
        
        Public Property ParentRelease() As String
            Get
                Return Me.parentReleaseField
            End Get
            Set
                Me.parentReleaseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TrialKittingQueryComponentSupplyDemandType
        
        '''<remarks/>
        M
        
        '''<remarks/>
        P
        
        '''<remarks/>
        J
        
        '''<remarks/>
        I
        
        '''<remarks/>
        N
        
        '''<remarks/>
        S
        
        '''<remarks/>
        C
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        W
        
        '''<remarks/>
        H
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class TrialKittingQueryComponentSupplyDemandKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipInspecReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
        
        Public Property Allocation() As String
            Get
                Return Me.allocationField
            End Get
            Set
                Me.allocationField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates which warehouse was used to establish a quantity on hand for the component, as well as the warehouse that was used to establish the supply and demand affecting the component. If more than one warehouse was used then this element will contain '--'. The format is up to 2 characters alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property GRN() As String
            Get
                Return Me.gRNField
            End Get
            Set
                Me.gRNField = value
            End Set
        End Property
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates the component stock code/non-stock code required. The format is either a 30 character alphanumeric field or 15 character numeric field depending on the key configuration for stock codes within SYSPRO.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property WipInspecReference() As String
            Get
                Return Me.wipInspecReferenceField
            End Get
            Set
                Me.wipInspecReferenceField = value
            End Set
        End Property
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
    End Class
End Namespace
