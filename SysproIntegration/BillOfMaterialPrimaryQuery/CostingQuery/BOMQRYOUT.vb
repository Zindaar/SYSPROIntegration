Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace BillOfMaterialPrimaryQuery.CostingQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class BomQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As BomQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentField As BomQueryParent
        
        Public Sub New()
            MyBase.New
            If (Me.parentField Is Nothing) Then
                Me.parentField = New BomQueryParent
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New BomQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As BomQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property Parent() As BomQueryParent
            Get
                Return Me.parentField
            End Get
            Set
                Me.parentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorEmailAddressField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set
                Me.languageField = value
            End Set
        End Property
        
        Public Property DecFormat() As String
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        Public Property DateFormat() As String
            Get
                Return Me.dateFormatField
            End Get
            Set
                Me.dateFormatField = value
            End Set
        End Property
        
        Public Property Role() As String
            Get
                Return Me.roleField
            End Get
            Set
                Me.roleField = value
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
        
        Public Property CompanyId() As String
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = value
            End Set
        End Property
        
        Public Property CompanyName() As String
            Get
                Return Me.companyNameField
            End Get
            Set
                Me.companyNameField = value
            End Set
        End Property
        
        Public Property OperatorCode() As String
            Get
                Return Me.operatorCodeField
            End Get
            Set
                Me.operatorCodeField = value
            End Set
        End Property
        
        Public Property OperatorName() As String
            Get
                Return Me.operatorNameField
            End Get
            Set
                Me.operatorNameField = value
            End Set
        End Property
        
        Public Property OperatorGroup() As String
            Get
                Return Me.operatorGroupField
            End Get
            Set
                Me.operatorGroupField = value
            End Set
        End Property
        
        Public Property OperatorEmailAddress() As String
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As String
            Get
                Return Me.operatorLocationField
            End Get
            Set
                Me.operatorLocationField = value
            End Set
        End Property
        
        Public Property ReportDate() As String
            Get
                Return Me.reportDateField
            End Get
            Set
                Me.reportDateField = value
            End Set
        End Property
        
        Public Property UseSeparatorOnReports() As String
            Get
                Return Me.useSeparatorOnReportsField
            End Get
            Set
                Me.useSeparatorOnReportsField = value
            End Set
        End Property
        
        Public Property SeparatorToUse() As String
            Get
                Return Me.separatorToUseField
            End Get
            Set
                Me.separatorToUseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCostingReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bOMROU_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of BomQueryParentOperation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of BomQueryParentComponent)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcElementField As BomQueryParentAbcElement
        
        Public Sub New()
            MyBase.New
            If (Me.abcElementField Is Nothing) Then
                Me.abcElementField = New BomQueryParentAbcElement
            End If
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of BomQueryParentComponent)
            End If
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of BomQueryParentOperation)
            End If
        End Sub
        
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
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
        
        Public Property AbcCostingReq() As String
            Get
                Return Me.abcCostingReqField
            End Get
            Set
                Me.abcCostingReqField = value
            End Set
        End Property
        
        Public Property WarehouseToUse() As String
            Get
                Return Me.warehouseToUseField
            End Get
            Set
                Me.warehouseToUseField = value
            End Set
        End Property
        
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
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
        
        Public Property BOMROU_Description() As String
            Get
                Return Me.bOMROU_DescriptionField
            End Get
            Set
                Me.bOMROU_DescriptionField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Operation")>  _
        Public Property OperationCollection() As List(Of BomQueryParentOperation)
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of BomQueryParentComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        Public Property AbcElement() As BomQueryParentAbcElement
            Get
                Return Me.abcElementField
            End Get
            Set
                Me.abcElementField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whatIfWcIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractFlagField As String
        
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
        Private subWhatIfValueField As String
        
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
        Private milestoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
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
        Private timeCalcFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        Public Sub New()
            MyBase.New
            If (Me.narrationsField Is Nothing) Then
                Me.narrationsField = New List(Of String)
            End If
        End Sub
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
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
        
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set
                Me.timeUomField = value
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
        
        Public Property WcRateInd() As String
            Get
                Return Me.wcRateIndField
            End Get
            Set
                Me.wcRateIndField = value
            End Set
        End Property
        
        Public Property WhatIfWcInd() As String
            Get
                Return Me.whatIfWcIndField
            End Get
            Set
                Me.whatIfWcIndField = value
            End Set
        End Property
        
        Public Property SubcontractFlag() As String
            Get
                Return Me.subcontractFlagField
            End Get
            Set
                Me.subcontractFlagField = value
            End Set
        End Property
        
        Public Property ISetUpTime() As String
            Get
                Return Me.iSetUpTimeField
            End Get
            Set
                Me.iSetUpTimeField = value
            End Set
        End Property
        
        Public Property IRunTime() As String
            Get
                Return Me.iRunTimeField
            End Get
            Set
                Me.iRunTimeField = value
            End Set
        End Property
        
        Public Property IStartupTime() As String
            Get
                Return Me.iStartupTimeField
            End Get
            Set
                Me.iStartupTimeField = value
            End Set
        End Property
        
        Public Property ITeardownTime() As String
            Get
                Return Me.iTeardownTimeField
            End Get
            Set
                Me.iTeardownTimeField = value
            End Set
        End Property
        
        Public Property IWaitTime() As String
            Get
                Return Me.iWaitTimeField
            End Get
            Set
                Me.iWaitTimeField = value
            End Set
        End Property
        
        Public Property IStartupQty() As String
            Get
                Return Me.iStartupQtyField
            End Get
            Set
                Me.iStartupQtyField = value
            End Set
        End Property
        
        Public Property IMachine() As String
            Get
                Return Me.iMachineField
            End Get
            Set
                Me.iMachineField = value
            End Set
        End Property
        
        Public Property IUnitCapacity() As String
            Get
                Return Me.iUnitCapacityField
            End Get
            Set
                Me.iUnitCapacityField = value
            End Set
        End Property
        
        Public Property IMaxWorkOpertrs() As String
            Get
                Return Me.iMaxWorkOpertrsField
            End Get
            Set
                Me.iMaxWorkOpertrsField = value
            End Set
        End Property
        
        Public Property IMaxProdUnits() As String
            Get
                Return Me.iMaxProdUnitsField
            End Get
            Set
                Me.iMaxProdUnitsField = value
            End Set
        End Property
        
        Public Property ITimeTaken() As String
            Get
                Return Me.iTimeTakenField
            End Get
            Set
                Me.iTimeTakenField = value
            End Set
        End Property
        
        Public Property IQuantity() As String
            Get
                Return Me.iQuantityField
            End Get
            Set
                Me.iQuantityField = value
            End Set
        End Property
        
        Public Property SubSupplier() As String
            Get
                Return Me.subSupplierField
            End Get
            Set
                Me.subSupplierField = value
            End Set
        End Property
        
        Public Property SubPoStockCode() As String
            Get
                Return Me.subPoStockCodeField
            End Get
            Set
                Me.subPoStockCodeField = value
            End Set
        End Property
        
        Public Property SubQtyPer() As String
            Get
                Return Me.subQtyPerField
            End Get
            Set
                Me.subQtyPerField = value
            End Set
        End Property
        
        Public Property SubOrderUom() As String
            Get
                Return Me.subOrderUomField
            End Get
            Set
                Me.subOrderUomField = value
            End Set
        End Property
        
        Public Property SubOpUnitValue() As String
            Get
                Return Me.subOpUnitValueField
            End Get
            Set
                Me.subOpUnitValueField = value
            End Set
        End Property
        
        Public Property SubWhatIfValue() As String
            Get
                Return Me.subWhatIfValueField
            End Get
            Set
                Me.subWhatIfValueField = value
            End Set
        End Property
        
        Public Property SubPlanner() As String
            Get
                Return Me.subPlannerField
            End Get
            Set
                Me.subPlannerField = value
            End Set
        End Property
        
        Public Property SubBuyer() As String
            Get
                Return Me.subBuyerField
            End Get
            Set
                Me.subBuyerField = value
            End Set
        End Property
        
        Public Property SubLeadTime() As String
            Get
                Return Me.subLeadTimeField
            End Get
            Set
                Me.subLeadTimeField = value
            End Set
        End Property
        
        Public Property SubDockToStock() As String
            Get
                Return Me.subDockToStockField
            End Get
            Set
                Me.subDockToStockField = value
            End Set
        End Property
        
        Public Property SubOffsiteDays() As String
            Get
                Return Me.subOffsiteDaysField
            End Get
            Set
                Me.subOffsiteDaysField = value
            End Set
        End Property
        
        Public Property Milestone() As String
            Get
                Return Me.milestoneField
            End Get
            Set
                Me.milestoneField = value
            End Set
        End Property
        
        Public Property ElapsedTime() As String
            Get
                Return Me.elapsedTimeField
            End Get
            Set
                Me.elapsedTimeField = value
            End Set
        End Property
        
        Public Property MovementTime() As String
            Get
                Return Me.movementTimeField
            End Get
            Set
                Me.movementTimeField = value
            End Set
        End Property
        
        Public Property NarrationCode() As String
            Get
                Return Me.narrationCodeField
            End Get
            Set
                Me.narrationCodeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property NumOfPieces() As String
            Get
                Return Me.numOfPiecesField
            End Get
            Set
                Me.numOfPiecesField = value
            End Set
        End Property
        
        Public Property InspectionFlag() As String
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
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
        
        Public Property MinorSetup() As String
            Get
                Return Me.minorSetupField
            End Get
            Set
                Me.minorSetupField = value
            End Set
        End Property
        
        Public Property MinorSetupCode() As String
            Get
                Return Me.minorSetupCodeField
            End Get
            Set
                Me.minorSetupCodeField = value
            End Set
        End Property
        
        Public Property ToolSet() As String
            Get
                Return Me.toolSetField
            End Get
            Set
                Me.toolSetField = value
            End Set
        End Property
        
        Public Property ToolSetQty() As String
            Get
                Return Me.toolSetQtyField
            End Get
            Set
                Me.toolSetQtyField = value
            End Set
        End Property
        
        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set
                Me.toolConsumptionField = value
            End Set
        End Property
        
        Public Property TimeCalcFlag() As String
            Get
                Return Me.timeCalcFlagField
            End Get
            Set
                Me.timeCalcFlagField = value
            End Set
        End Property
        
        Public Property OprSubContract() As String
            Get
                Return Me.oprSubContractField
            End Get
            Set
                Me.oprSubContractField = value
            End Set
        End Property
        
        Public Property OprSubContractCost() As String
            Get
                Return Me.oprSubContractCostField
            End Get
            Set
                Me.oprSubContractCostField = value
            End Set
        End Property
        
        Public Property OprLabour() As String
            Get
                Return Me.oprLabourField
            End Get
            Set
                Me.oprLabourField = value
            End Set
        End Property
        
        Public Property OprFixedOverHead() As String
            Get
                Return Me.oprFixedOverHeadField
            End Get
            Set
                Me.oprFixedOverHeadField = value
            End Set
        End Property
        
        Public Property OprVariableOverHead() As String
            Get
                Return Me.oprVariableOverHeadField
            End Get
            Set
                Me.oprVariableOverHeadField = value
            End Set
        End Property
        
        Public Property OperationCostTotal() As String
            Get
                Return Me.operationCostTotalField
            End Get
            Set
                Me.operationCostTotalField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Narration", IsNullable:=false)>  _
        Public Property NarrationsCollection() As List(Of String)
            Get
                Return Me.narrationsField
            End Get
            Set
                Me.narrationsField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOffDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationOffsetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soOptionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soPrintFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclScrapFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclKitIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wetWeightPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeToJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subAssemblyField As List(Of BomQueryParentComponentSubAssembly)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentsAttachedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationsAttachedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private levelErrorMessageField As String
        
        Public Sub New()
            MyBase.New
            If (Me.subAssemblyField Is Nothing) Then
                Me.subAssemblyField = New List(Of BomQueryParentComponentSubAssembly)
            End If
        End Sub
        
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
            End Set
        End Property
        
        Public Property ComVersion() As String
            Get
                Return Me.comVersionField
            End Get
            Set
                Me.comVersionField = value
            End Set
        End Property
        
        Public Property ComRelease() As String
            Get
                Return Me.comReleaseField
            End Get
            Set
                Me.comReleaseField = value
            End Set
        End Property
        
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        Public Property StructureOnDate() As String
            Get
                Return Me.structureOnDateField
            End Get
            Set
                Me.structureOnDateField = value
            End Set
        End Property
        
        Public Property StructureOffDate() As String
            Get
                Return Me.structureOffDateField
            End Get
            Set
                Me.structureOffDateField = value
            End Set
        End Property
        
        Public Property OpOffsetFlag() As String
            Get
                Return Me.opOffsetFlagField
            End Get
            Set
                Me.opOffsetFlagField = value
            End Set
        End Property
        
        Public Property OperationOffset() As String
            Get
                Return Me.operationOffsetField
            End Get
            Set
                Me.operationOffsetField = value
            End Set
        End Property
        
        Public Property QtyPer() As String
            Get
                Return Me.qtyPerField
            End Get
            Set
                Me.qtyPerField = value
            End Set
        End Property
        
        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set
                Me.scrapPercentageField = value
            End Set
        End Property
        
        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set
                Me.scrapQuantityField = value
            End Set
        End Property
        
        Public Property SoOptionFlag() As String
            Get
                Return Me.soOptionFlagField
            End Get
            Set
                Me.soOptionFlagField = value
            End Set
        End Property
        
        Public Property SoPrintFlag() As String
            Get
                Return Me.soPrintFlagField
            End Get
            Set
                Me.soPrintFlagField = value
            End Set
        End Property
        
        Public Property InclScrapFlag() As String
            Get
                Return Me.inclScrapFlagField
            End Get
            Set
                Me.inclScrapFlagField = value
            End Set
        End Property
        
        Public Property ReasonForChange() As String
            Get
                Return Me.reasonForChangeField
            End Get
            Set
                Me.reasonForChangeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property InclKitIssues() As String
            Get
                Return Me.inclKitIssuesField
            End Get
            Set
                Me.inclKitIssuesField = value
            End Set
        End Property
        
        Public Property CreateSubJob() As String
            Get
                Return Me.createSubJobField
            End Get
            Set
                Me.createSubJobField = value
            End Set
        End Property
        
        Public Property WetWeightPercent() As String
            Get
                Return Me.wetWeightPercentField
            End Get
            Set
                Me.wetWeightPercentField = value
            End Set
        End Property
        
        Public Property IncludeBatch() As String
            Get
                Return Me.includeBatchField
            End Get
            Set
                Me.includeBatchField = value
            End Set
        End Property
        
        Public Property IncludeFromJob() As String
            Get
                Return Me.includeFromJobField
            End Get
            Set
                Me.includeFromJobField = value
            End Set
        End Property
        
        Public Property IncludeToJob() As String
            Get
                Return Me.includeToJobField
            End Get
            Set
                Me.includeToJobField = value
            End Set
        End Property
        
        Public Property ComMaterial() As String
            Get
                Return Me.comMaterialField
            End Get
            Set
                Me.comMaterialField = value
            End Set
        End Property
        
        Public Property ComSubContractCost() As String
            Get
                Return Me.comSubContractCostField
            End Get
            Set
                Me.comSubContractCostField = value
            End Set
        End Property
        
        Public Property ComLabour() As String
            Get
                Return Me.comLabourField
            End Get
            Set
                Me.comLabourField = value
            End Set
        End Property
        
        Public Property ComFixedOverHead() As String
            Get
                Return Me.comFixedOverHeadField
            End Get
            Set
                Me.comFixedOverHeadField = value
            End Set
        End Property
        
        Public Property ComVariableOverHead() As String
            Get
                Return Me.comVariableOverHeadField
            End Get
            Set
                Me.comVariableOverHeadField = value
            End Set
        End Property
        
        Public Property ComponentCostTotal() As String
            Get
                Return Me.componentCostTotalField
            End Get
            Set
                Me.componentCostTotalField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SubAssembly")>  _
        Public Property SubAssemblyCollection() As List(Of BomQueryParentComponentSubAssembly)
            Get
                Return Me.subAssemblyField
            End Get
            Set
                Me.subAssemblyField = value
            End Set
        End Property
        
        Public Property FixedQtyPerFlag() As String
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
        
        Public Property ComponentsAttached() As String
            Get
                Return Me.componentsAttachedField
            End Get
            Set
                Me.componentsAttachedField = value
            End Set
        End Property
        
        Public Property OperationsAttached() As String
            Get
                Return Me.operationsAttachedField
            End Get
            Set
                Me.operationsAttachedField = value
            End Set
        End Property
        
        Public Property LevelErrorMessage() As String
            Get
                Return Me.levelErrorMessageField
            End Get
            Set
                Me.levelErrorMessageField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssembly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of BomQueryParentComponentSubAssemblyComponent)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of BomQueryParentComponentSubAssemblyOperation)
        
        Public Sub New()
            MyBase.New
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of BomQueryParentComponentSubAssemblyOperation)
            End If
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of BomQueryParentComponentSubAssemblyComponent)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of BomQueryParentComponentSubAssemblyComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Operation")>  _
        Public Property OperationCollection() As List(Of BomQueryParentComponentSubAssemblyOperation)
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssemblyComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOffDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationOffsetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soOptionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soPrintFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclScrapFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclKitIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wetWeightPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeToJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subAssemblyField As List(Of BomQueryParentComponentSubAssemblyComponentSubAssembly)
        
        Public Sub New()
            MyBase.New
            If (Me.subAssemblyField Is Nothing) Then
                Me.subAssemblyField = New List(Of BomQueryParentComponentSubAssemblyComponentSubAssembly)
            End If
        End Sub
        
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
            End Set
        End Property
        
        Public Property ComVersion() As String
            Get
                Return Me.comVersionField
            End Get
            Set
                Me.comVersionField = value
            End Set
        End Property
        
        Public Property ComRelease() As String
            Get
                Return Me.comReleaseField
            End Get
            Set
                Me.comReleaseField = value
            End Set
        End Property
        
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        Public Property StructureOnDate() As String
            Get
                Return Me.structureOnDateField
            End Get
            Set
                Me.structureOnDateField = value
            End Set
        End Property
        
        Public Property StructureOffDate() As String
            Get
                Return Me.structureOffDateField
            End Get
            Set
                Me.structureOffDateField = value
            End Set
        End Property
        
        Public Property OpOffsetFlag() As String
            Get
                Return Me.opOffsetFlagField
            End Get
            Set
                Me.opOffsetFlagField = value
            End Set
        End Property
        
        Public Property OperationOffset() As String
            Get
                Return Me.operationOffsetField
            End Get
            Set
                Me.operationOffsetField = value
            End Set
        End Property
        
        Public Property QtyPer() As String
            Get
                Return Me.qtyPerField
            End Get
            Set
                Me.qtyPerField = value
            End Set
        End Property
        
        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set
                Me.scrapPercentageField = value
            End Set
        End Property
        
        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set
                Me.scrapQuantityField = value
            End Set
        End Property
        
        Public Property SoOptionFlag() As String
            Get
                Return Me.soOptionFlagField
            End Get
            Set
                Me.soOptionFlagField = value
            End Set
        End Property
        
        Public Property SoPrintFlag() As String
            Get
                Return Me.soPrintFlagField
            End Get
            Set
                Me.soPrintFlagField = value
            End Set
        End Property
        
        Public Property InclScrapFlag() As String
            Get
                Return Me.inclScrapFlagField
            End Get
            Set
                Me.inclScrapFlagField = value
            End Set
        End Property
        
        Public Property ReasonForChange() As String
            Get
                Return Me.reasonForChangeField
            End Get
            Set
                Me.reasonForChangeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property InclKitIssues() As String
            Get
                Return Me.inclKitIssuesField
            End Get
            Set
                Me.inclKitIssuesField = value
            End Set
        End Property
        
        Public Property CreateSubJob() As String
            Get
                Return Me.createSubJobField
            End Get
            Set
                Me.createSubJobField = value
            End Set
        End Property
        
        Public Property WetWeightPercent() As String
            Get
                Return Me.wetWeightPercentField
            End Get
            Set
                Me.wetWeightPercentField = value
            End Set
        End Property
        
        Public Property IncludeBatch() As String
            Get
                Return Me.includeBatchField
            End Get
            Set
                Me.includeBatchField = value
            End Set
        End Property
        
        Public Property IncludeFromJob() As String
            Get
                Return Me.includeFromJobField
            End Get
            Set
                Me.includeFromJobField = value
            End Set
        End Property
        
        Public Property IncludeToJob() As String
            Get
                Return Me.includeToJobField
            End Get
            Set
                Me.includeToJobField = value
            End Set
        End Property
        
        Public Property ComMaterial() As String
            Get
                Return Me.comMaterialField
            End Get
            Set
                Me.comMaterialField = value
            End Set
        End Property
        
        Public Property ComSubContractCost() As String
            Get
                Return Me.comSubContractCostField
            End Get
            Set
                Me.comSubContractCostField = value
            End Set
        End Property
        
        Public Property ComLabour() As String
            Get
                Return Me.comLabourField
            End Get
            Set
                Me.comLabourField = value
            End Set
        End Property
        
        Public Property ComFixedOverHead() As String
            Get
                Return Me.comFixedOverHeadField
            End Get
            Set
                Me.comFixedOverHeadField = value
            End Set
        End Property
        
        Public Property ComVariableOverHead() As String
            Get
                Return Me.comVariableOverHeadField
            End Get
            Set
                Me.comVariableOverHeadField = value
            End Set
        End Property
        
        Public Property ComponentCostTotal() As String
            Get
                Return Me.componentCostTotalField
            End Get
            Set
                Me.componentCostTotalField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SubAssembly")>  _
        Public Property SubAssemblyCollection() As List(Of BomQueryParentComponentSubAssemblyComponentSubAssembly)
            Get
                Return Me.subAssemblyField
            End Get
            Set
                Me.subAssemblyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssemblyComponentSubAssembly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyComponent)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyOperation)
        
        Public Sub New()
            MyBase.New
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyOperation)
            End If
            If (Me.componentField Is Nothing) Then
                Me.componentField = New List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyComponent)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Component")>  _
        Public Property ComponentCollection() As List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyComponent)
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Operation")>  _
        Public Property OperationCollection() As List(Of BomQueryParentComponentSubAssemblyComponentSubAssemblyOperation)
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssemblyComponentSubAssemblyComponent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOffDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationOffsetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soOptionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soPrintFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclScrapFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclKitIssuesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wetWeightPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeToJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
            End Set
        End Property
        
        Public Property ComVersion() As String
            Get
                Return Me.comVersionField
            End Get
            Set
                Me.comVersionField = value
            End Set
        End Property
        
        Public Property ComRelease() As String
            Get
                Return Me.comReleaseField
            End Get
            Set
                Me.comReleaseField = value
            End Set
        End Property
        
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        Public Property StructureOnDate() As String
            Get
                Return Me.structureOnDateField
            End Get
            Set
                Me.structureOnDateField = value
            End Set
        End Property
        
        Public Property StructureOffDate() As String
            Get
                Return Me.structureOffDateField
            End Get
            Set
                Me.structureOffDateField = value
            End Set
        End Property
        
        Public Property OpOffsetFlag() As String
            Get
                Return Me.opOffsetFlagField
            End Get
            Set
                Me.opOffsetFlagField = value
            End Set
        End Property
        
        Public Property OperationOffset() As String
            Get
                Return Me.operationOffsetField
            End Get
            Set
                Me.operationOffsetField = value
            End Set
        End Property
        
        Public Property QtyPer() As String
            Get
                Return Me.qtyPerField
            End Get
            Set
                Me.qtyPerField = value
            End Set
        End Property
        
        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set
                Me.scrapPercentageField = value
            End Set
        End Property
        
        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set
                Me.scrapQuantityField = value
            End Set
        End Property
        
        Public Property SoOptionFlag() As String
            Get
                Return Me.soOptionFlagField
            End Get
            Set
                Me.soOptionFlagField = value
            End Set
        End Property
        
        Public Property SoPrintFlag() As String
            Get
                Return Me.soPrintFlagField
            End Get
            Set
                Me.soPrintFlagField = value
            End Set
        End Property
        
        Public Property InclScrapFlag() As String
            Get
                Return Me.inclScrapFlagField
            End Get
            Set
                Me.inclScrapFlagField = value
            End Set
        End Property
        
        Public Property ReasonForChange() As String
            Get
                Return Me.reasonForChangeField
            End Get
            Set
                Me.reasonForChangeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property InclKitIssues() As String
            Get
                Return Me.inclKitIssuesField
            End Get
            Set
                Me.inclKitIssuesField = value
            End Set
        End Property
        
        Public Property CreateSubJob() As String
            Get
                Return Me.createSubJobField
            End Get
            Set
                Me.createSubJobField = value
            End Set
        End Property
        
        Public Property WetWeightPercent() As String
            Get
                Return Me.wetWeightPercentField
            End Get
            Set
                Me.wetWeightPercentField = value
            End Set
        End Property
        
        Public Property IncludeBatch() As String
            Get
                Return Me.includeBatchField
            End Get
            Set
                Me.includeBatchField = value
            End Set
        End Property
        
        Public Property IncludeFromJob() As String
            Get
                Return Me.includeFromJobField
            End Get
            Set
                Me.includeFromJobField = value
            End Set
        End Property
        
        Public Property IncludeToJob() As String
            Get
                Return Me.includeToJobField
            End Get
            Set
                Me.includeToJobField = value
            End Set
        End Property
        
        Public Property ComMaterial() As String
            Get
                Return Me.comMaterialField
            End Get
            Set
                Me.comMaterialField = value
            End Set
        End Property
        
        Public Property ComSubContractCost() As String
            Get
                Return Me.comSubContractCostField
            End Get
            Set
                Me.comSubContractCostField = value
            End Set
        End Property
        
        Public Property ComLabour() As String
            Get
                Return Me.comLabourField
            End Get
            Set
                Me.comLabourField = value
            End Set
        End Property
        
        Public Property ComFixedOverHead() As String
            Get
                Return Me.comFixedOverHeadField
            End Get
            Set
                Me.comFixedOverHeadField = value
            End Set
        End Property
        
        Public Property ComVariableOverHead() As String
            Get
                Return Me.comVariableOverHeadField
            End Get
            Set
                Me.comVariableOverHeadField = value
            End Set
        End Property
        
        Public Property ComponentCostTotal() As String
            Get
                Return Me.componentCostTotalField
            End Get
            Set
                Me.componentCostTotalField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssemblyComponentSubAssemblyOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whatIfWcIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractFlagField As String
        
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
        Private milestoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
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
        Private timeCalcFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        Public Sub New()
            MyBase.New
            If (Me.narrationsField Is Nothing) Then
                Me.narrationsField = New List(Of String)
            End If
        End Sub
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
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
        
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set
                Me.timeUomField = value
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
        
        Public Property WcRateInd() As String
            Get
                Return Me.wcRateIndField
            End Get
            Set
                Me.wcRateIndField = value
            End Set
        End Property
        
        Public Property WhatIfWcInd() As String
            Get
                Return Me.whatIfWcIndField
            End Get
            Set
                Me.whatIfWcIndField = value
            End Set
        End Property
        
        Public Property SubcontractFlag() As String
            Get
                Return Me.subcontractFlagField
            End Get
            Set
                Me.subcontractFlagField = value
            End Set
        End Property
        
        Public Property ISetUpTime() As String
            Get
                Return Me.iSetUpTimeField
            End Get
            Set
                Me.iSetUpTimeField = value
            End Set
        End Property
        
        Public Property IRunTime() As String
            Get
                Return Me.iRunTimeField
            End Get
            Set
                Me.iRunTimeField = value
            End Set
        End Property
        
        Public Property IStartupTime() As String
            Get
                Return Me.iStartupTimeField
            End Get
            Set
                Me.iStartupTimeField = value
            End Set
        End Property
        
        Public Property ITeardownTime() As String
            Get
                Return Me.iTeardownTimeField
            End Get
            Set
                Me.iTeardownTimeField = value
            End Set
        End Property
        
        Public Property IWaitTime() As String
            Get
                Return Me.iWaitTimeField
            End Get
            Set
                Me.iWaitTimeField = value
            End Set
        End Property
        
        Public Property IStartupQty() As String
            Get
                Return Me.iStartupQtyField
            End Get
            Set
                Me.iStartupQtyField = value
            End Set
        End Property
        
        Public Property IMachine() As String
            Get
                Return Me.iMachineField
            End Get
            Set
                Me.iMachineField = value
            End Set
        End Property
        
        Public Property IUnitCapacity() As String
            Get
                Return Me.iUnitCapacityField
            End Get
            Set
                Me.iUnitCapacityField = value
            End Set
        End Property
        
        Public Property IMaxWorkOpertrs() As String
            Get
                Return Me.iMaxWorkOpertrsField
            End Get
            Set
                Me.iMaxWorkOpertrsField = value
            End Set
        End Property
        
        Public Property IMaxProdUnits() As String
            Get
                Return Me.iMaxProdUnitsField
            End Get
            Set
                Me.iMaxProdUnitsField = value
            End Set
        End Property
        
        Public Property ITimeTaken() As String
            Get
                Return Me.iTimeTakenField
            End Get
            Set
                Me.iTimeTakenField = value
            End Set
        End Property
        
        Public Property IQuantity() As String
            Get
                Return Me.iQuantityField
            End Get
            Set
                Me.iQuantityField = value
            End Set
        End Property
        
        Public Property Milestone() As String
            Get
                Return Me.milestoneField
            End Get
            Set
                Me.milestoneField = value
            End Set
        End Property
        
        Public Property ElapsedTime() As String
            Get
                Return Me.elapsedTimeField
            End Get
            Set
                Me.elapsedTimeField = value
            End Set
        End Property
        
        Public Property MovementTime() As String
            Get
                Return Me.movementTimeField
            End Get
            Set
                Me.movementTimeField = value
            End Set
        End Property
        
        Public Property NarrationCode() As String
            Get
                Return Me.narrationCodeField
            End Get
            Set
                Me.narrationCodeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property NumOfPieces() As String
            Get
                Return Me.numOfPiecesField
            End Get
            Set
                Me.numOfPiecesField = value
            End Set
        End Property
        
        Public Property InspectionFlag() As String
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
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
        
        Public Property MinorSetup() As String
            Get
                Return Me.minorSetupField
            End Get
            Set
                Me.minorSetupField = value
            End Set
        End Property
        
        Public Property MinorSetupCode() As String
            Get
                Return Me.minorSetupCodeField
            End Get
            Set
                Me.minorSetupCodeField = value
            End Set
        End Property
        
        Public Property ToolSet() As String
            Get
                Return Me.toolSetField
            End Get
            Set
                Me.toolSetField = value
            End Set
        End Property
        
        Public Property ToolSetQty() As String
            Get
                Return Me.toolSetQtyField
            End Get
            Set
                Me.toolSetQtyField = value
            End Set
        End Property
        
        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set
                Me.toolConsumptionField = value
            End Set
        End Property
        
        Public Property TimeCalcFlag() As String
            Get
                Return Me.timeCalcFlagField
            End Get
            Set
                Me.timeCalcFlagField = value
            End Set
        End Property
        
        Public Property OprSubContract() As String
            Get
                Return Me.oprSubContractField
            End Get
            Set
                Me.oprSubContractField = value
            End Set
        End Property
        
        Public Property OprSubContractCost() As String
            Get
                Return Me.oprSubContractCostField
            End Get
            Set
                Me.oprSubContractCostField = value
            End Set
        End Property
        
        Public Property OprLabour() As String
            Get
                Return Me.oprLabourField
            End Get
            Set
                Me.oprLabourField = value
            End Set
        End Property
        
        Public Property OprFixedOverHead() As String
            Get
                Return Me.oprFixedOverHeadField
            End Get
            Set
                Me.oprFixedOverHeadField = value
            End Set
        End Property
        
        Public Property OprVariableOverHead() As String
            Get
                Return Me.oprVariableOverHeadField
            End Get
            Set
                Me.oprVariableOverHeadField = value
            End Set
        End Property
        
        Public Property OperationCostTotal() As String
            Get
                Return Me.operationCostTotalField
            End Get
            Set
                Me.operationCostTotalField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Narration", IsNullable:=false)>  _
        Public Property NarrationsCollection() As List(Of String)
            Get
                Return Me.narrationsField
            End Get
            Set
                Me.narrationsField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentComponentSubAssemblyOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private timeUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whatIfWcIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractFlagField As String
        
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
        Private milestoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private elapsedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoNarrCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOfPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operYieldQtyField As String
        
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
        Private timeCalcFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprSubContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprFixedOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private oprVariableOverHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationCostTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconOpenField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private iconClosedField As String
        
        Public Sub New()
            MyBase.New
            If (Me.narrationsField Is Nothing) Then
                Me.narrationsField = New List(Of String)
            End If
        End Sub
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
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
        
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set
                Me.timeUomField = value
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
        
        Public Property WcRateInd() As String
            Get
                Return Me.wcRateIndField
            End Get
            Set
                Me.wcRateIndField = value
            End Set
        End Property
        
        Public Property WhatIfWcInd() As String
            Get
                Return Me.whatIfWcIndField
            End Get
            Set
                Me.whatIfWcIndField = value
            End Set
        End Property
        
        Public Property SubcontractFlag() As String
            Get
                Return Me.subcontractFlagField
            End Get
            Set
                Me.subcontractFlagField = value
            End Set
        End Property
        
        Public Property ISetUpTime() As String
            Get
                Return Me.iSetUpTimeField
            End Get
            Set
                Me.iSetUpTimeField = value
            End Set
        End Property
        
        Public Property IRunTime() As String
            Get
                Return Me.iRunTimeField
            End Get
            Set
                Me.iRunTimeField = value
            End Set
        End Property
        
        Public Property IStartupTime() As String
            Get
                Return Me.iStartupTimeField
            End Get
            Set
                Me.iStartupTimeField = value
            End Set
        End Property
        
        Public Property ITeardownTime() As String
            Get
                Return Me.iTeardownTimeField
            End Get
            Set
                Me.iTeardownTimeField = value
            End Set
        End Property
        
        Public Property IWaitTime() As String
            Get
                Return Me.iWaitTimeField
            End Get
            Set
                Me.iWaitTimeField = value
            End Set
        End Property
        
        Public Property IStartupQty() As String
            Get
                Return Me.iStartupQtyField
            End Get
            Set
                Me.iStartupQtyField = value
            End Set
        End Property
        
        Public Property IMachine() As String
            Get
                Return Me.iMachineField
            End Get
            Set
                Me.iMachineField = value
            End Set
        End Property
        
        Public Property IUnitCapacity() As String
            Get
                Return Me.iUnitCapacityField
            End Get
            Set
                Me.iUnitCapacityField = value
            End Set
        End Property
        
        Public Property IMaxWorkOpertrs() As String
            Get
                Return Me.iMaxWorkOpertrsField
            End Get
            Set
                Me.iMaxWorkOpertrsField = value
            End Set
        End Property
        
        Public Property IMaxProdUnits() As String
            Get
                Return Me.iMaxProdUnitsField
            End Get
            Set
                Me.iMaxProdUnitsField = value
            End Set
        End Property
        
        Public Property ITimeTaken() As String
            Get
                Return Me.iTimeTakenField
            End Get
            Set
                Me.iTimeTakenField = value
            End Set
        End Property
        
        Public Property IQuantity() As String
            Get
                Return Me.iQuantityField
            End Get
            Set
                Me.iQuantityField = value
            End Set
        End Property
        
        Public Property Milestone() As String
            Get
                Return Me.milestoneField
            End Get
            Set
                Me.milestoneField = value
            End Set
        End Property
        
        Public Property ElapsedTime() As String
            Get
                Return Me.elapsedTimeField
            End Get
            Set
                Me.elapsedTimeField = value
            End Set
        End Property
        
        Public Property MovementTime() As String
            Get
                Return Me.movementTimeField
            End Get
            Set
                Me.movementTimeField = value
            End Set
        End Property
        
        Public Property NarrationCode() As String
            Get
                Return Me.narrationCodeField
            End Get
            Set
                Me.narrationCodeField = value
            End Set
        End Property
        
        Public Property AutoNarrCode() As String
            Get
                Return Me.autoNarrCodeField
            End Get
            Set
                Me.autoNarrCodeField = value
            End Set
        End Property
        
        Public Property NumOfPieces() As String
            Get
                Return Me.numOfPiecesField
            End Get
            Set
                Me.numOfPiecesField = value
            End Set
        End Property
        
        Public Property InspectionFlag() As String
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
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
        
        Public Property MinorSetup() As String
            Get
                Return Me.minorSetupField
            End Get
            Set
                Me.minorSetupField = value
            End Set
        End Property
        
        Public Property MinorSetupCode() As String
            Get
                Return Me.minorSetupCodeField
            End Get
            Set
                Me.minorSetupCodeField = value
            End Set
        End Property
        
        Public Property ToolSet() As String
            Get
                Return Me.toolSetField
            End Get
            Set
                Me.toolSetField = value
            End Set
        End Property
        
        Public Property ToolSetQty() As String
            Get
                Return Me.toolSetQtyField
            End Get
            Set
                Me.toolSetQtyField = value
            End Set
        End Property
        
        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set
                Me.toolConsumptionField = value
            End Set
        End Property
        
        Public Property TimeCalcFlag() As String
            Get
                Return Me.timeCalcFlagField
            End Get
            Set
                Me.timeCalcFlagField = value
            End Set
        End Property
        
        Public Property OprSubContract() As String
            Get
                Return Me.oprSubContractField
            End Get
            Set
                Me.oprSubContractField = value
            End Set
        End Property
        
        Public Property OprSubContractCost() As String
            Get
                Return Me.oprSubContractCostField
            End Get
            Set
                Me.oprSubContractCostField = value
            End Set
        End Property
        
        Public Property OprLabour() As String
            Get
                Return Me.oprLabourField
            End Get
            Set
                Me.oprLabourField = value
            End Set
        End Property
        
        Public Property OprFixedOverHead() As String
            Get
                Return Me.oprFixedOverHeadField
            End Get
            Set
                Me.oprFixedOverHeadField = value
            End Set
        End Property
        
        Public Property OprVariableOverHead() As String
            Get
                Return Me.oprVariableOverHeadField
            End Get
            Set
                Me.oprVariableOverHeadField = value
            End Set
        End Property
        
        Public Property OperationCostTotal() As String
            Get
                Return Me.operationCostTotalField
            End Get
            Set
                Me.operationCostTotalField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Narration", IsNullable:=false)>  _
        Public Property NarrationsCollection() As List(Of String)
            Get
                Return Me.narrationsField
            End Get
            Set
                Me.narrationsField = value
            End Set
        End Property
        
        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set
                Me.iconOpenField = value
            End Set
        End Property
        
        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set
                Me.iconClosedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BomQueryParentAbcElement
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcDirectField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcLessDirectField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCumPreProdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCumManufField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcFactoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcSalesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcTotalField As String
        
        Public Property AbcDirect() As String
            Get
                Return Me.abcDirectField
            End Get
            Set
                Me.abcDirectField = value
            End Set
        End Property
        
        Public Property AbcLessDirect() As String
            Get
                Return Me.abcLessDirectField
            End Get
            Set
                Me.abcLessDirectField = value
            End Set
        End Property
        
        Public Property AbcCumPreProd() As String
            Get
                Return Me.abcCumPreProdField
            End Get
            Set
                Me.abcCumPreProdField = value
            End Set
        End Property
        
        Public Property AbcCumManuf() As String
            Get
                Return Me.abcCumManufField
            End Get
            Set
                Me.abcCumManufField = value
            End Set
        End Property
        
        Public Property AbcFactory() As String
            Get
                Return Me.abcFactoryField
            End Get
            Set
                Me.abcFactoryField = value
            End Set
        End Property
        
        Public Property AbcSales() As String
            Get
                Return Me.abcSalesField
            End Get
            Set
                Me.abcSalesField = value
            End Set
        End Property
        
        Public Property AbcTotal() As String
            Get
                Return Me.abcTotalField
            End Get
            Set
                Me.abcTotalField = value
            End Set
        End Property
    End Class
End Namespace
