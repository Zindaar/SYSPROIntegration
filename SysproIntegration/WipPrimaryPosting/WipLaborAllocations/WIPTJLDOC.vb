Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.WipLaborAllocations.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class HierarchyJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        '''<summary>
        '''Head is part of a unique key to identify a hierarchy. Mandatory when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Head() As String
            Get
                Return Me.headField
            End Get
            Set
                Me.headField = value
            End Set
        End Property
        
        '''<summary>
        '''Section1 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section2 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section3 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section4 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedQueueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedEndDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedElapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitNumOfPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private milestoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minorSetupCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minorSetupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolSetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolSetQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toolConsumptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queueTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyJobField As HierarchyJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private previousOpMovementField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextOpQueueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private calculateDatesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMachineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iExpUnitRunTimField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iExpSetUpTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iExpStartupTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iExpShutdownTimField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iWaitTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iWcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iStartupQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overrideCalcCapField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iCapacityReqdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxWorkOpertrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxProdUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subSupplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supPoStkCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subUnitValueField As String
        
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
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
        Public Sub New()
            MyBase.New
            Me.fixedElapsedTimeField = "N"
            Me.inspectionFlagField = "N"
            Me.milestoneField = "Y"
            If (Me.hierarchyJobField Is Nothing) Then
                Me.hierarchyJobField = New HierarchyJob
            End If
        End Sub
        
        '''<summary>
        '''This field specifies the job for which the allocations are being maintained. The format
        '''is 8 characters alphanumeric or 8 characters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is used to assign an operation to a job. If you enter an operation that already exists, you can select the Add function to insert this as a new operation. If you are doing a multiple item delete, you must delete from the highest operation down, as when you delete an operation, all operations after the deleted operation shift down e.g if you delete operation number 2, operation number 3 becomes operation number 2. The format is 4 characters positive numeric.
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
        '''This field indicates the work center  in which the operation must be performed. The format is a 6 character alphanumeric.
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
        '''This field specifies the queue date for the operation. It is only required if the job date calculation method is manual. If the date is left blank, it will default to the system date. The format is CCYY-MM-DD.
        '''</summary>
        Public Property PlannedQueueDate() As String
            Get
                Return Me.plannedQueueDateField
            End Get
            Set
                Me.plannedQueueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This field specifies the start date for the operation. It is only required if the job date calculation method is manual. If the date is left blank, it will default to the system date. The format is CCYY-MM-DD.
        '''</summary>
        Public Property PlannedStartDate() As String
            Get
                Return Me.plannedStartDateField
            End Get
            Set
                Me.plannedStartDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This field specifies the end date for the operation. It is only required if the job date calculation method is manual. If the date is left blank, it will default to the system date. The format is CCYY-MM-DD.
        '''</summary>
        Public Property PlannedEndDate() As String
            Get
                Return Me.plannedEndDateField
            End Get
            Set
                Me.plannedEndDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This field specifies the standard narration code for the operation. The format is a 4 character alphanumeric.
        '''</summary>
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
            End Set
        End Property
        
        '''<summary>
        '''This field describes the work center. When adding an operation, if the parameter is not provided, the description will be taken from the work center file. The format is a 30 character alphanumeric.
        '''</summary>
        Public Property WorkCentreDesc() As String
            Get
                Return Me.workCentreDescField
            End Get
            Set
                Me.workCentreDescField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates whether the elapsed time of the operation must be dynamically calculated, or manually entered as a fixed number of days. (Y - Fixed, N - Calculated).
        '''</summary>
        Public Property FixedElapsedTime() As String
            Get
                Return Me.fixedElapsedTimeField
            End Get
            Set
                Me.fixedElapsedTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the elapsed time for the operation if the elapsed time is fixed. The format is 3 characters positive numeric.
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
        '''This field indicates the time required for the operation to move between work centers. The entry made here is only used if you have not defined a movement matrix for the work center. The format is 3 characters numeric positive or negative.
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
        '''This field indicates the number of pieces involved in the operation. This enables you to mark quantities in a measure that is meaningful to you.
        '''The format is 5 characters numeric.
        '''</summary>
        Public Property UnitNumOfPieces() As String
            Get
                Return Me.unitNumOfPiecesField
            End Get
            Set
                Me.unitNumOfPiecesField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag indicates the level of inspection for the operation. (N - No inspection, S - Sample inspection required, F - Full inspection required.) On an add, the default is N.
        '''</summary>
        Public Property InspectionFlag() As String
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag indicates whether the operation is a milestone operation or not. This enables you to post labor to key operations and update all prior operations with labor postings. (Y - Yes, N - No). On an add, the default is Y.
        '''</summary>
        Public Property Milestone() As String
            Get
                Return Me.milestoneField
            End Get
            Set
                Me.milestoneField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is for documentary purposes and is printed on the dispatch List in the Work in Progress and Requirements Planning modules. The format is 4 alphanumeric characters.
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
        '''This field is for documentary purposes and is printed on the dispatch List in the Work in Progress and Requirements Planning modules. The entry made here cannot exceed the set-up time for the operation. The format is 5.4 characters positive numeric.
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
        '''This field indicates the tool set number for the operation. This can be printed on your factory documentation. The format is 15 characters alphanumeric.
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
        '''This field indicates the tool set quantity for the operation. The entry made here cannot exceed the quantity assigned to the tool set. This can be printed on your factory documentation. The format is 7.3 characters positive numeric.
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
        '''This field indicates the tool set consumption for the operation. This can be printed on your factory documentation. The format is 8 characters  positive numeric.
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
        '''This field specifies the queue time for the operation. When adding the queue time is taken from the work center file. The format is 3 characters positive numeric.
        '''</summary>
        Public Property QueueTime() As String
            Get
                Return Me.queueTimeField
            End Get
            Set
                Me.queueTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains part of the unique key for the hierarchy. The job number will be used to complete the key.
        '''</summary>
        Public Property HierarchyJob() As HierarchyJob
            Get
                Return Me.hierarchyJobField
            End Get
            Set
                Me.hierarchyJobField = value
            End Set
        End Property
        
        '''<summary>
        '''This field specifies the previous operation movement time. It is only on an update that this field is used and if there is a previous operation. The format is a 3 character signed numeric.
        '''</summary>
        Public Property PreviousOpMovement() As String
            Get
                Return Me.previousOpMovementField
            End Get
            Set
                Me.previousOpMovementField = value
            End Set
        End Property
        
        '''<summary>
        '''This field specifies the next operation queue time. It is only on an update that this field is used and if there is a next operation. The format is a 3 character positive numeric.
        '''</summary>
        Public Property NextOpQueue() As String
            Get
                Return Me.nextOpQueueField
            End Get
            Set
                Me.nextOpQueueField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag is to indicate whether to calculate the start and end date. It is only used on a change and if the job calculation date is manual. (Y- Yes, N - No) The default is N.
        '''</summary>
        Public Property CalculateDates() As String
            Get
                Return Me.calculateDatesField
            End Get
            Set
                Me.calculateDatesField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is used for documentary purposes and to indicate the default machine for the operation during labor postings. The format is 6 characters alphanumeric.
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
        '''This field indicates the time taken to produce one unit during full speed production. It forms part of elapsed time. The format is 5.4 characters positive numeric.
        '''</summary>
        Public Property IExpUnitRunTim() As String
            Get
                Return Me.iExpUnitRunTimField
            End Get
            Set
                Me.iExpUnitRunTimField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the time taken to ready a specific machine, process or work center for use. No usable items are produced during the setup period. It forms part of the operation elapsed time. The format is 5.4 characters positive numeric.
        '''</summary>
        Public Property IExpSetUpTime() As String
            Get
                Return Me.iExpSetUpTimeField
            End Get
            Set
                Me.iExpSetUpTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the time taken to gradually bring the specific machine, line or work center up to full production speed while producing usable product. It forms part of the operation elapsed time. The format is 5.4 characters positive numeric.
        '''</summary>
        Public Property IExpStartupTime() As String
            Get
                Return Me.iExpStartupTimeField
            End Get
            Set
                Me.iExpStartupTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the time taken to close down the specific machine, line or work center used in the operation after production is complete. It forms part of the elapsed time. Typically, no usable items are produced during the teardown period. The format is 5.4 characters positive numeric.
        '''</summary>
        Public Property IExpShutdownTim() As String
            Get
                Return Me.iExpShutdownTimField
            End Get
            Set
                Me.iExpShutdownTimField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the amount of time between the end of the current operation and the availability of the product to be moved to the next work center. This forms part of elapsed time. Wait time is not included in the calculation of capacity required or in the costing calculations.
        '''The format is 5.4 characters positive numeric.
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
        '''This field indicates the work center rate applicable to this operation.
        '''The format is 1 character positive numeric.
        '''</summary>
        Public Property IWcRateInd() As String
            Get
                Return Me.iWcRateIndField
            End Get
            Set
                Me.iWcRateIndField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the quantity of product manufactured during the start up period and is deducted from the actual quantity to be manufactured when the run time is calculated. The format is 7.3 characters positive numeric.
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
        '''This field is to specify whether to override the calculated capacity or not. (Y-Yes, N- No).
        '''</summary>
        Public Property OverrideCalcCap() As String
            Get
                Return Me.overrideCalcCapField
            End Get
            Set
                Me.overrideCalcCapField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the capacity required for the operation (if the flag to override the calculated capacity is set to "Y"). The format is 7.3 characters positive numeric.
        '''</summary>
        Public Property ICapacityReqd() As String
            Get
                Return Me.iCapacityReqdField
            End Get
            Set
                Me.iCapacityReqdField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the maximum number of operators permitted to process the operation. This may not exceed the number of operators assigned to the work center. The format is 3.2 characters positive numeric.
        '''</summary>
        Public Property IMaxWorkOpertrs() As String
            Get
                Return Me.iMaxWorkOpertrsField
            End Get
            Set
                Me.iMaxWorkOpertrsField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the maximum number of productive units available in the work center that can be used on the operation. This value is used in the calculation of capacity required and elapsed time. The format is 3.2 characters positive numeric.
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
        '''This field indicates the preferred supplier of the service.  The format is up to 7 characters alphanumeric, or 7 characters numeric depending on a configuration option within Syspro.
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
        '''This field indicates the notation that will be entered under the stock code when a purchase order is generated. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within Syspro.
        '''</summary>
        Public Property SupPoStkCode() As String
            Get
                Return Me.supPoStkCodeField
            End Get
            Set
                Me.supPoStkCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is used for documentary purposes only and enables you to indicate the quantity of the purchased service required to make a single parent stock code. The format is 6.6 characters positive numeric.
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
        '''This field is used for documentary purposes only. The format is 3 characters alphanumeric.
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
        '''This field indicates the subcontract value of the operation. The format is 10.5 characters positive numeric.
        '''</summary>
        Public Property SubUnitValue() As String
            Get
                Return Me.subUnitValueField
            End Get
            Set
                Me.subUnitValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This field indicates the planner for this operation. On an add, if the parameter is not provided, the default against the work center file will be used. The format is 3 characters alphanumeric.
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
        '''This field is used to indicate the buyer for this operation. On an add, if no parameter is provided, the default against the work center file will be used. The format is 3 characters alphanumeric.
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
        '''This field is used to establish the date on which a purchase order should be raised to reserve capacity at the subcontractor. The format is 3 characters positive numeric.
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
        '''This field indicates the number of days required for the inspection of the item. This is added to the offsite time to establish the elapsed time of the operation. The due date of the purchase order is set as the due date of the operation less the dock to stock time. The format is 3 characters positive numeric.
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
        '''This field indicates the number of days that the component is off site. This is added to any dock to stock days to determine the elapsed time. The format is 3 characters positive numeric.
        '''</summary>
        Public Property SubOffsiteDays() As String
            Get
                Return Me.subOffsiteDaysField
            End Get
            Set
                Me.subOffsiteDaysField = value
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
    Partial Public Class PostLabourAllocations
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemCollectionField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain an allocation.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of Item)
            Get
                If Me.itemCollectionField Is Nothing Then
                    Me.itemCollectionField = New List(Of Item)
                End If
                Return Me.itemCollectionField
            End Get
            Set(ByVal value As List(Of Item))
                Me.itemCollectionField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTJL"
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
                Dim objParams As Params.PostLabourAllocations
                objParams = New Params.PostLabourAllocations
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
End Namespace
