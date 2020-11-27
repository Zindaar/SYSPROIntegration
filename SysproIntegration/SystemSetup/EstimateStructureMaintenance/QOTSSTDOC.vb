Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.EstimateStructureMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationFlagField As OperationFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPrintField As ScrapPrint
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPrintFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitIssueFlagField As KitIssueFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitIssueFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockComField As NonStockCom
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockComFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private marginMarkupPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagField As ManualCostFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerFlagField As ItemFixedQtyPerFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerField As String
        
        Public Sub New()
            MyBase.New
            Me.operationFlagField = OperationFlag.O
            Me.scrapPrintField = ScrapPrint.Y
            Me.kitIssueFlagField = KitIssueFlag.Y
            Me.nonStockComField = NonStockCom.N
            Me.manualCostFlagField = ManualCostFlag.N
            Me.fixedQtyPerFlagField = ItemFixedQtyPerFlag.N
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain an estimate structure record.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates either the number of the operation for which you need the component or the number of offset days when the component will be needed. If the element ‘Operation Flag’ contains 'O' this field will indicate an operation number, else if the element ‘Operation Flag’ contains 'D' this field will indicate the number of offset days. The format is up to 3 characters numeric field. Default to 1.
        '''</summary>
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the usage of the Operation element. Possible values 'O' (an operation number) or 'D' (offset days). Default to O.
        '''</summary>
        Public Property OperationFlag() As OperationFlag
            Get
                Return Me.operationFlagField
            End Get
            Set
                Me.operationFlagField = value
                Me.OperationFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OperationFlagSpecified() As Boolean
            Get
                Return Me.operationFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Quantity Per is used to indicate the quantity of the component stock code that is required to make one of the parent stock code. This relationship is based on the units of measure of the parent part and the component. The number of decimals that can be entered (0 to 6) is determined by your entry at the Maximum number of decimals in quantity per option (Bill of Materials Setup). The format is up to 14 characters signed numeric with 6 integers and 6 decimals.
        '''</summary>
        Public Property QtyPer() As String
            Get
                Return Me.qtyPerField
            End Get
            Set
                Me.qtyPerField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the percentage factor by which the quantity per must be increased, to take account of scrap. The format is up to 5 characters positive numeric with 2 integers and 2 decimals.
        '''</summary>
        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set
                Me.scrapPercentageField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the quantity which must be added to the components issued, to take account of scrap. The format is up to 8 characters positive numeric with 4 integers and 3 decimals.
        '''</summary>
        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set
                Me.scrapQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''Valid entries are:                Y - Issue material and progressive scrap automatically
        '''N - Material and progressive scrap are not automatically issued
        '''M - Issue only material scrap automatically
        '''P - Issue only progressive scrap automatically
        '''</summary>
        Public Property ScrapPrint() As ScrapPrint
            Get
                Return Me.scrapPrintField
            End Get
            Set
                Me.scrapPrintField = value
                Me.ScrapPrintFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ScrapPrintSpecified() As Boolean
            Get
                Return Me.scrapPrintFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates why the estimate has changed. The format is up to 10 characters alphanumeric.
        '''</summary>
        Public Property ReasonChange() As String
            Get
                Return Me.reasonChangeField
            End Get
            Set
                Me.reasonChangeField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the component should be included in kit issues. Possible Values: Y (yes, include component in kit issues) or N (no, do not included component in kit issues). Default to Y.
        '''</summary>
        Public Property KitIssueFlag() As KitIssueFlag
            Get
                Return Me.kitIssueFlagField
            End Get
            Set
                Me.kitIssueFlagField = value
                Me.KitIssueFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property KitIssueFlagSpecified() As Boolean
            Get
                Return Me.kitIssueFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates if the component is a non-stocked item. Possible Values: Y (yes, non-stocked item) or N (no, stocked item). Default to N.
        '''</summary>
        Public Property NonStockCom() As NonStockCom
            Get
                Return Me.nonStockComField
            End Get
            Set
                Me.nonStockComField = value
                Me.NonStockComFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NonStockComSpecified() As Boolean
            Get
                Return Me.nonStockComFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the markup or margin percentage which will be added to the total cost of the operation. The percentage will default to the value defined for estimates in the quotation setup within SYSPRO. The format is up to 7 characters signed numeric with 3 integers and 2 decimals.
        '''</summary>
        Public Property MarginMarkupPct() As String
            Get
                Return Me.marginMarkupPctField
            End Get
            Set
                Me.marginMarkupPctField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the cost of the component for this estimate. The element is only applicable if the element ‘Manual Cost Flag’ contains Y. The format is up to 17 characters, signed numeric with 10 integers and 5 decimals.
        '''</summary>
        Public Property ManualCost() As String
            Get
                Return Me.manualCostField
            End Get
            Set
                Me.manualCostField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if the manually entered cost should be used for this component instead of the warehouse cost for stocked components or unit cost for non-stocked components. Possible Values: Y (yes) or N (no). Default to N.
        '''</summary>
        Public Property ManualCostFlag() As ManualCostFlag
            Get
                Return Me.manualCostFlagField
            End Get
            Set
                Me.manualCostFlagField = value
                Me.ManualCostFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ManualCostFlagSpecified() As Boolean
            Get
                Return Me.manualCostFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the warehouse from which the cost of the component will be retrieved. Only applicable for stocked components. The format is up to 2 characters alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemFixedQtyPerFlag.N)>  _
        Public Property FixedQtyPerFlag() As ItemFixedQtyPerFlag
            Get
                Return Me.fixedQtyPerFlagField
            End Get
            Set
                Me.fixedQtyPerFlagField = value
            End Set
        End Property
        
        Public Property FixedQtyPer() As String
            Get
                Return Me.fixedQtyPerField
            End Get
            Set
                Me.fixedQtyPerField = value
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        Public Sub New()
            MyBase.New
            Me.routeField = "0"
        End Sub
        
        '''<summary>
        '''The non-stocked parent code for which you want to create or maintain the estimate. You may not create estimates for stock codes or for non-stocked codes that are defined as bought out items. The format is up to 30 characters alphanumeric or 15 characters numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
        '''<summary>
        '''This field enables you to select a specific routing for which you want to maintain an estimate. You may only select routes that are required for the non-stocked parent code. The format is a 1 character numeric field. Default to 0.
        '''</summary>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        '''<summary>
        '''The Sequence number field is used to indicate the sequence number for the component in relation to the parent stock code. This number is used to show more than one occurrence of the parent/component relationship. This field will only be used if you have indicated that structure sequencing is required (Bill of Materials Setup). The format is up to 6 characters alphanumeric or numeric field, depending on the sequence number setup defined in the Bill of Material setup within SYSPRO.
        '''</summary>
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        '''<summary>
        '''Component is a stocked or non-stocked item used in the process of creating an estimate for a parent part. The format is up to 30 characters alphanumeric or 15 characters numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OperationFlag
        
        '''<remarks/>
        O
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ScrapPrint
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        M
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum KitIssueFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum NonStockCom
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ManualCostFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemFixedQtyPerFlag
        
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
    Partial Public Class SetupQotStructure
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains the information to maintain a component for an estimate. The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
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
                Return "QOTSST"
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
                Dim objParams As Params.SetupQotStructure
                objParams = New Params.SetupQotStructure
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
End Namespace
