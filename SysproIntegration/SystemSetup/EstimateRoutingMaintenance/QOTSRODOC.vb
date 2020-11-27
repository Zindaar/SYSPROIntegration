Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.EstimateRoutingMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ElapsedTimeCal
        
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
    Public Enum InspectionFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        S
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
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
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iSetupTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iRunTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iStartupTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iTeardownTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iWaitTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iStartupQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMachineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxOperatorsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxProdUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iTimeTakenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iBlockQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subSupplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subPoStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOpUnitValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subPlannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subBuyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subDockToStockField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOffsiteDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private milestoneField As Milestone
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private milestoneFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeCalField As ElapsedTimeCal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeCalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As InspectionFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minorSetupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minorSetupCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolSetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolSetQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolConsumptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sellBasisField As SellBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sellBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sellRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private markupMarginPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
        Public Sub New()
            MyBase.New
            Me.milestoneField = Milestone.Y
            Me.elapsedTimeCalField = ElapsedTimeCal.Y
            Me.inspectionFlagField = InspectionFlag.N
            Me.sellBasisField = SellBasis.M
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain an estimate routing record.
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
        '''Indicates the work centre in which the operation must be performed. Depending on whether you specified an internal or subcontract work centre, the fields that can be defined changes accordingly. This is a mandatory element when adding an operation. The format is up to 6 characters alphanumeric.
        '''</summary>
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicate the work centre rate applicable to this operation. These rates are used to cost labor and overheads for an operation that takes place in the work center. The format is 1 character numeric. Default to 1.
        '''</summary>
        Public Property WorkRateInd() As String
            Get
                Return Me.workRateIndField
            End Get
            Set
                Me.workRateIndField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to ready a specific machine, process or work centre for use. No usable items are produced during the setup period. It forms part of the operation elapsed time. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property ISetupTime() As String
            Get
                Return Me.iSetupTimeField
            End Get
            Set
                Me.iSetupTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to produce one unit during full speed production. It forms part of elapsed time. This field is only applicable when your Run time calculation method for your work centre is Unit. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property IRunTime() As String
            Get
                Return Me.iRunTimeField
            End Get
            Set
                Me.iRunTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to gradually bring the specific machine, line or work centre up to full production speed while producing usable product. It forms part of the operation elapsed time. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property IStartupTime() As String
            Get
                Return Me.iStartupTimeField
            End Get
            Set
                Me.iStartupTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to close down the specific machine, line or work centre used in the operation after production is complete. It forms part of the elapsed time. Typically, no usable items are produced during the teardown period.  The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property ITeardownTime() As String
            Get
                Return Me.iTeardownTimeField
            End Get
            Set
                Me.iTeardownTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the amount of time between the end of the current operation and the availability of the product to be moved to the next work centre. This forms part of elapsed time. Wait time is not included in the calculation of capacity required or in the costing calculations. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property IWaitTime() As String
            Get
                Return Me.iWaitTimeField
            End Get
            Set
                Me.iWaitTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the quantity of product manufactured during the start up period. This is deducted from the actual quantity to be manufactured when the run time is calculated. The format is up to 11 characters positive numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property IStartupQty() As String
            Get
                Return Me.iStartupQtyField
            End Get
            Set
                Me.iStartupQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the default machine for the operation. The format is up to 6 characters alphanumeric.
        '''</summary>
        Public Property IMachine() As String
            Get
                Return Me.iMachineField
            End Get
            Set
                Me.iMachineField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the maximum number of operators permitted to process the operation. This may not exceed the number of operators assigned to the work centre. The format is up to 6 characters positive numeric with 3 integers and 2 decimals. Default to 1.
        '''</summary>
        Public Property IMaxOperators() As String
            Get
                Return Me.iMaxOperatorsField
            End Get
            Set
                Me.iMaxOperatorsField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the maximum number of productive units available in the work centre that can be used on the operation. This value is used in the calculation of capacity required and elapsed time. The format is up to 6 characters positive numeric with 3 integers and 2 decimals. Default to 1.
        '''</summary>
        Public Property IMaxProdUnits() As String
            Get
                Return Me.iMaxProdUnitsField
            End Get
            Set
                Me.iMaxProdUnitsField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to calculate the unit run time when your Run time calculation method for your work centre is either Block or Rate. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property ITimeTaken() As String
            Get
                Return Me.iTimeTakenField
            End Get
            Set
                Me.iTimeTakenField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the quantity of the item that will be produced in the amount of time specific in the element ‘Time Taken’, used to calculate the unit run time when your Run time calculation method for your work centre is Rate. The format is up to 11 character positive numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property IBlockQty() As String
            Get
                Return Me.iBlockQtyField
            End Get
            Set
                Me.iBlockQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the supplier providing the service. This defaults to the supplier assigned to work centre. The format is up to 7 characters alphanumeric or numeric depending on the key configuration setting within SYSPRO.
        '''</summary>
        Public Property SubSupplier() As String
            Get
                Return Me.subSupplierField
            End Get
            Set
                Me.subSupplierField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the notation that will be entered under the stock code when a purchase order is generated. The format is up to 30 characters alphanumeric or 15 characters field, numeric, depending on the key configuration setup within SYSPRO.
        '''</summary>
        Public Property SubPoStockCode() As String
            Get
                Return Me.subPoStockCodeField
            End Get
            Set
                Me.subPoStockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the quantity of components needed to make one of the parent item. The format is up to 13 characters positive numeric with 6 integers and 6 decimals.
        '''</summary>
        Public Property SubQtyPer() As String
            Get
                Return Me.subQtyPerField
            End Get
            Set
                Me.subQtyPerField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the unit of measure for the operation. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property SubOrderUom() As String
            Get
                Return Me.subOrderUomField
            End Get
            Set
                Me.subOrderUomField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the subcontract value of the operation. The format is up to 16 characters positive numeric with 10 integers and 5 decimals.
        '''</summary>
        Public Property SubOpUnitValue() As String
            Get
                Return Me.subOpUnitValueField
            End Get
            Set
                Me.subOpUnitValueField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the planner for this operation. This defaults to the planner assigned to work centre. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property SubPlanner() As String
            Get
                Return Me.subPlannerField
            End Get
            Set
                Me.subPlannerField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the buyer for this operation. This defaults to the buyer assigned to work centre. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property SubBuyer() As String
            Get
                Return Me.subBuyerField
            End Get
            Set
                Me.subBuyerField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the number of days before this operation which are needed to raise a purchase order and reserve capacity at the subcontractor. The format is up to 3 characters positive numeric.
        '''</summary>
        Public Property SubLeadTime() As String
            Get
                Return Me.subLeadTimeField
            End Get
            Set
                Me.subLeadTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the number of days required for the inspection of the item. This is added to the offsite time to establish the elapsed time of the operation. The format is up to 3 characters positive numeric.
        '''
        '''</summary>
        Public Property SubDockToStock() As String
            Get
                Return Me.subDockToStockField
            End Get
            Set
                Me.subDockToStockField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the number of days that the component is off site. This is added to any dock to stock days to determine the elapsed time. The format is up to 3 characters positive numeric.
        '''</summary>
        Public Property SubOffsiteDays() As String
            Get
                Return Me.subOffsiteDaysField
            End Get
            Set
                Me.subOffsiteDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate whether this is a milestone operation. This enables you to post labor to key operations and update all prior operations with labor postings. Possible values: Y (yes) or N (no). Default to: Y (yes).
        '''</summary>
        Public Property Milestone() As Milestone
            Get
                Return Me.milestoneField
            End Get
            Set
                Me.milestoneField = value
                Me.MilestoneFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MilestoneSpecified() As Boolean
            Get
                Return Me.milestoneFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this field to indicate whether the elapsed time of the operation must be dynamically calculated, or manually entered as a fixed number of days. Possible values: N (no calculation, fixed elapsed time must be supplied) or Y (calculate elapsed time automatically). Default to: Y (yes).
        '''</summary>
        Public Property ElapsedTimeCal() As ElapsedTimeCal
            Get
                Return Me.elapsedTimeCalField
            End Get
            Set
                Me.elapsedTimeCalField = value
                Me.ElapsedTimeCalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ElapsedTimeCalSpecified() As Boolean
            Get
                Return Me.elapsedTimeCalFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this field to indicate a fixed number of days for the elapsed time, used when the element ‘Elapsed Time Cal’ is set to N (no calculation). The format is up to 3 characters positive numeric. Default to: 1.
        '''</summary>
        Public Property ElapsedTime() As String
            Get
                Return Me.elapsedTimeField
            End Get
            Set
                Me.elapsedTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time required for the operation to move between work centers. The format is up to 4 characters signed numeric.
        '''</summary>
        Public Property MovementTime() As String
            Get
                Return Me.movementTimeField
            End Get
            Set
                Me.movementTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate a standard narration code. This element is only applicable if you have selected the Bill of Material setup option: ‘Standard narrations for operations required’. The format is up to 4 characters alphanumeric.
        '''</summary>
        Public Property NarrationCode() As String
            Get
                Return Me.narrationCodeField
            End Get
            Set
                Me.narrationCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the number of pieces involved in the operation. This enables you to mark quantities in a measure that is meaningful to you. The format is up to 5 characters positive numeric.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the level of inspection required for the operation. Possible values: N (No inspection), S (Sample inspection) or F (Full inspection). Default to: N.
        '''</summary>
        Public Property InspectionFlag() As InspectionFlag
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
                Me.InspectionFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InspectionFlagSpecified() As Boolean
            Get
                Return Me.inspectionFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to make any minor adjustments for a machine, production line or work center for the operation. The format is up to 10 characters positive numeric with 5 integers and 4 decimals.
        '''</summary>
        Public Property MinorSetup() As String
            Get
                Return Me.minorSetupField
            End Get
            Set
                Me.minorSetupField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the code for any minor set up which is required for a machine, production line or work center, for example: adjusting cutters. The format is up to 4 characters alphanumeric.
        '''</summary>
        Public Property MinorSetupCode() As String
            Get
                Return Me.minorSetupCodeField
            End Get
            Set
                Me.minorSetupCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the tool set number for the operation. This can be printed on your factory documentation. The format is up to 15 characters alphanumeric.
        '''</summary>
        Public Property ToolSet() As String
            Get
                Return Me.toolSetField
            End Get
            Set
                Me.toolSetField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the tool set quantity for the operation. This can be printed on your factory documentation. The format is up to 11 characters positive numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property ToolSetQty() As String
            Get
                Return Me.toolSetQtyField
            End Get
            Set
                Me.toolSetQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate quantity of the tool sets used during the operation. This can be printed on your factory documentation. The format is up to 1 character positive numeric.
        '''</summary>
        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set
                Me.toolConsumptionField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the pricing method. Possible values: M (if you want a markup or margin percentage to be added to the total cost of the operation) or R (if you want to calculate the price that the customer will be charged for this operation according to the selling rate supplied in the element ‘Sell Rate Ind’). This element is only applicable if you have selected that changes to the markup or margin percentage for labor are allowed at estimate level in the quotation setup within SYSPRO.
        '''</summary>
        Public Property SellBasis() As SellBasis
            Get
                Return Me.sellBasisField
            End Get
            Set
                Me.sellBasisField = value
                Me.SellBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SellBasisSpecified() As Boolean
            Get
                Return Me.sellBasisFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''You use this field to indicate the selling rate that will be used to calculate the price that the customer will be charged for this operation, when you have selected a ‘Sell Basis’ of ‘R’. This element is only applicable if you have selected that changes to the markup or margin percentage for labor are allowed at estimate level in the quotation setup within SYSPRO. The format is 1 character positive numeric. Default to: 1.
        '''</summary>
        Public Property SellRateInd() As String
            Get
                Return Me.sellRateIndField
            End Get
            Set
                Me.sellRateIndField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the markup or margin percentage to be added to the total cost of the operation, when you have selected a ‘Sell Basis’ of ‘M’. This element is only applicable if you have selected that changes to the markup or margin percentage for labor are allowed at estimate level in the quotation setup within SYSPRO. The format is up to 7 characters signed numeric with 3 integers and 2 decimals.
        '''
        '''</summary>
        Public Property MarkupMarginPct() As String
            Get
                Return Me.markupMarginPctField
            End Get
            Set
                Me.markupMarginPctField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the work center description. The format is up to 30 characters alphanumeric.
        '''</summary>
        Public Property WorkCentreDesc() As String
            Get
                Return Me.workCentreDescField
            End Get
            Set
                Me.workCentreDescField = value
            End Set
        End Property
        
        Public Property OperYieldPct() As String
            Get
                Return Me.operYieldPctField
            End Get
            Set
                Me.operYieldPctField = value
            End Set
        End Property
        
        Public Property OperYieldQty() As String
            Get
                Return Me.operYieldQtyField
            End Get
            Set
                Me.operYieldQtyField = value
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
        Private nonStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        Public Sub New()
            MyBase.New
            Me.routeField = "0"
        End Sub
        
        '''<summary>
        '''The non-stocked parent code for which you want to create or maintain the estimate. You may not create estimates for stock codes or non-stocked codes that are defined as bought out items or phantom parts. The format is up to 30 characters alphanumeric or 15 characters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property NonStockCode() As String
            Get
                Return Me.nonStockCodeField
            End Get
            Set
                Me.nonStockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This field enables you to select a specific routing for which you want to maintain an estimate. You may only select routes that are required for the non-stocked parent code. The format is a 1 character alphanumeric field. Default to 0.
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
        '''You use this field to assign an operation to the parent stock code. If you enter an operation that already exists, and you are adding an operation, it will be inserted as a new operation. The format is a 3 characters numeric field.
        '''</summary>
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Milestone
        
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
    Public Enum SellBasis
        
        '''<remarks/>
        M
        
        '''<remarks/>
        R
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupQotRouting
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
        '''This element contains the information to maintain an operation for an estimate. The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
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
                Return "QOTSRO"
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
                Dim objParams As Params.SetupQotRouting
                objParams = New Params.SetupQotRouting
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
