Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.BomRoutingMaintenance.Data
    
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
        Private wcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iSetUpTimeField As String
        
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
        Private iUnitCapacityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxWorkOpertrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iMaxProdUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iTimeTakenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iQuantityField As String
        
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
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfPiecesField As String
        
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
        Private transferQtyOrPctField As ItemTransferQtyOrPct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transferQtyOrPctFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transferQtyPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeCalcFlagField As TimeCalcFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeCalcFlagFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.milestoneField = Milestone.Y
            Me.inspectionFlagField = InspectionFlag.N
            Me.timeCalcFlagField = TimeCalcFlag.Y
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a BOM routing.
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
        '''You use this field to indicate the work center in which the operation must be performed. Depending on whether you specified an internal or subcontract work center, the fields that can be defined changes accordingly. The format is 6 characters alphanumeric.
        '''
        '''
        '''
        '''
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
        '''You use this field to indicate the work center rate applicable to this operation.
        '''The format is 1 character positive numeric.
        '''</summary>
        Public Property WcRateInd() As String
            Get
                Return Me.wcRateIndField
            End Get
            Set
                Me.wcRateIndField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to ready a specific machine, process or work center for use. No usable items are produced during the setup period. It forms part of the operation elapsed time. The format is 5.4 characters positive numeric.
        '''</summary>
        Public Property ISetUpTime() As String
            Get
                Return Me.iSetUpTimeField
            End Get
            Set
                Me.iSetUpTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the time taken to produce one unit during full speed production. It forms part of elapsed time. The format is 5.4 characters positive numeric.
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
        '''You use this field to indicate the time taken to gradually bring the specific machine, line or work center up to full production speed while producing usable product. It forms part of the operation elapsed time. The format is 5.4 characters positive numeric.
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
        '''You use this field to indicate the time taken to close down the specific machine, line or work center used in the operation after production is complete. It forms part of the elapsed time. Typically, no usable items are produced during the teardown period. The format is 5.4 characters positive numeric.
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
        '''You use this field to indicate the amount of time between the end of the current operation and the availability of the product to be moved to the next work center. This forms part of elapsed time. Wait time is not included in the calculation of capacity required or in the costing calculations.
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
        '''You use this field to indicate the quantity of product manufactured during the start up period and is deducted from the actual quantity to be manufactured when the run time is calculated. The format is 7.3 characters positive numeric.
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
        '''You use this field for documentary purposes and to indicate the default machine for the operation during labor postings. The format is 6 characters alphanumeric.
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
        '''This field indicates the capacity required for the operation. The format is 7.3 characters positive numeric.
        '''</summary>
        Public Property IUnitCapacity() As String
            Get
                Return Me.iUnitCapacityField
            End Get
            Set
                Me.iUnitCapacityField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the maximum number of operators permitted to process the operation. This may not exceed the number of operators assigned to the work center. The format is 3.2 characters positive numeric.
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
        '''You use this field to indicate the maximum number of productive units available in the work center that can be used on the operation. This value is used in the calculation of capacity required and elapsed time. The format is 3.2 characters positive numeric.
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
        '''You use this field to calculate the unit run time when using block or rate method. The format is 5.4 characters positive numeric.
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
        '''You use this field to indicate the unit to base the cost center's run time calculation on the time it takes to produce one unit of an item or 
        '''block to base the cost center's run time calculation on a fixed block of time.
        '''The format is 7.3 numeric positive.
        ''' 
        '''
        '''
        '''
        '''</summary>
        Public Property IQuantity() As String
            Get
                Return Me.iQuantityField
            End Get
            Set
                Me.iQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the preferred supplier of the service. This defaults to the supplier assigned to work center. The format is up to 7 characters alphanumeric, or 7 characters numeric depending on a configuration option within Syspro.
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
        '''You use this field to indicate the notation that will be entered under the stock code when a purchase order is generated. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within Syspro.
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
        '''You use this field to indicate the subcontract value of the operation. The format is 10.5 characters positive numeric.
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
        '''You use this field to indicate the planner for this operation. The format is 3 characters alphanumeric.
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
        '''You use this field to indicate the buyer for this operation. The format is 3 characters alphanumeric.
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
        '''You use this field to establish the date on which a purchase order should be raised to reserve capacity at the subcontractor. The format is 3 characters positive numeric.
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
        '''You use this field to indicate the number of days required for the inspection of the item. This is added to the offsite time to establish the elapsed time of the operation. The due date of the purchase order is set as the due date of the operation less the dock to stock time. The format is 3 characters positive numeric.
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
        '''You use this field to indicate the number of days that the component is off site. This is added to any dock to stock days to determine the elapsed time. The format is 3 characters positive numeric.
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
        '''You use this field to indicate whether this is a milestone operation. This enables you to post labor to key operations and update all prior operations with labor postings. (Y -Yes, N -No)
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
        '''You use this field to indicate whether the elapsed time of the operation must be dynamically calculated, or manually entered as a fixed number of days. The format is 3 characters positive numeric.
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
        '''You use this field to indicate the time required for the operation to move between work centers. The entry made here is only used if you have not defined a movement matrix for the work center. The format is 3 characters numeric positive or negative.
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
        '''You use this field to indicate a standard narration code. The format is 4 characters alphanumeric 
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
        '''You use this field to indicate the number of pieces involved in the operation. This enables you to mark quantities in a measure that is meaningful to you.
        '''The format is 5 characters numeric.
        '''
        '''
        '''</summary>
        Public Property NumOfPieces() As String
            Get
                Return Me.numOfPiecesField
            End Get
            Set
                Me.numOfPiecesField = value
            End Set
        End Property
        
        '''<summary>
        '''You use this field to indicate the level of inspection required for the operation.
        '''(N- No inspection, S- Sample inspection, F- Full inspection)
        '''
        '''
        '''
        '''
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
        '''You use this field for documentary purposes and is printed on the Despatch List in the Work in Progress and Requirements Planning modules. The entry made here cannot exceed the set-up time for the operation. The format is 5.4 characters positive numeric.
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
        '''You use this field for documentary purposes and is printed on the Despatch List in the Work in Progress and Requirements Planning modules. The format is 4 alphanumeric characters.
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
        '''You use this field to indicate the tool set number for the operation. This can be printed on your factory documentation. The format is 15 characters alphanumeric.
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
        '''You use this field to indicate the tool set quantity for the operation. The entry made here cannot exceed the quantity assigned to the tool set. This can be printed on your factory documentation. The format is 7.3 characters positive numeric.
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
        '''You use this field to indicate the tool set consumption for the operation. This can be printed on your factory documentation. The format is 8 characters  positive numeric.
        '''</summary>
        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set
                Me.toolConsumptionField = value
            End Set
        End Property
        
        Public Property TransferQtyOrPct() As ItemTransferQtyOrPct
            Get
                Return Me.transferQtyOrPctField
            End Get
            Set
                Me.transferQtyOrPctField = value
                Me.TransferQtyOrPctFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TransferQtyOrPctSpecified() As Boolean
            Get
                Return Me.transferQtyOrPctFieldSpecified
            End Get
        End Property
        
        Public Property TransferQtyPct() As String
            Get
                Return Me.transferQtyPctField
            End Get
            Set
                Me.transferQtyPctField = value
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
        
        '''<summary>
        '''You use this field to indicate whether to calculate elapsed time or enter it manually. (Y- Yes, N -No)
        '''</summary>
        Public Property TimeCalcFlag() As TimeCalcFlag
            Get
                Return Me.timeCalcFlagField
            End Get
            Set
                Me.timeCalcFlagField = value
                Me.TimeCalcFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TimeCalcFlagSpecified() As Boolean
            Get
                Return Me.timeCalcFlagFieldSpecified
            End Get
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
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        '''<summary>
        '''The Parent stock code  indicates which item you want to maintain operations for. A warning is displayed if the entered parent stock code is defined as a bought out item. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within Syspro.
        '''
        '''
        '''
        '''
        '''
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
        '''This field is used to indicate the version of the current operation. The only time any field will be valid is if it is the current version and it is maintained by an engineering change order. The format is 3 characters alphanumeric, or  numeric depending on a configuration option within Bill of Materials setup.
        '''
        '''
        '''</summary>
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is used to indicate the release of the current operation. The only time any field will be valid is if it is the current release and it is maintained by an engineering change order. The format is 3 characters alphanumeric, or numeric depending on a configuration option within Bill of Materials setup.
        '''
        '''
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''The Routing field is displayed only if you indicated that alternate routings are required (Bill of Materials Setup). This field enables you to select a specific routing for which you want to maintain operations, and is used for what-if purposes and within the Work in Progress module when creating a job.
        '''The format is 1 character alphanumeric
        '''
        '''
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
        '''You use this field to assign an operation to the parent stock code. If you enter an operation that already exists, and you are adding an operation, it will be inserted as a new operation. The format is 3 characters positive numeric. If you want to do multiple deletions to the same parent, you should delete the operations in reverse order i.e., if you want to delete operations 1, 3 and 5 you should start with 5, then delete 3 and then delete 1.  This is because the program resequences the operations when they are deleted, so if you delete operation 1, operation 2 will be renumbered as '1', so operation 3 will be the old operation 4, and operation 5 will have been operation 7 before you deleted operation 1 and 3. 
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
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemTransferQtyOrPct
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TimeCalcFlag
        
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
    Partial Public Class SetupBomRouting
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters

        Public Sub New()
            itemField = New List(Of Item)
        End Sub

        '''<summary>
        '''This element contains information to maintain a BOM routing. NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of Item))
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
                Return "BOMSRO"
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
                Dim objParams As Params.SetupBomRouting
                objParams = New Params.SetupBomRouting
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
