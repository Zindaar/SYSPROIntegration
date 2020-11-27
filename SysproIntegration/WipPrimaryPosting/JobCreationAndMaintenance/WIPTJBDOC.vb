Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.JobCreationAndMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ChangeSalesOrderWarehouse
        
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
    Public Enum CheckLeadTime
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ConfirmedFlag
        
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
    Public Enum DateCalcMethod
        
        '''<remarks/>
        D
        
        '''<remarks/>
        S
        
        '''<remarks/>
        M
        
        '''<remarks/>
        F
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum HierarchyFlag
        
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
    Public Enum HoldFlag
        
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
    Public Enum IncludeAllocations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeOvertimePct
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priorityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossQuantityFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobTenderDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodField As DateCalcMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOvertimePctField As IncludeOvertimePct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOvertimePctFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setMethodToManualField As SetMethodToManual
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setMethodToManualFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDeliveryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private seqCheckReqField As SeqCheckReq
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private seqCheckReqFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedFlagField As ConfirmedFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdFlagField As HoldFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holdFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routePasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedField As NonStocked
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expLabourField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sellingPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addLabPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addMatPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private profitPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As TraceableType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyFlagField As HierarchyFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAllocationsField As IncludeAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAllocationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobOptionsField As SubJobOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkLeadTimeField As CheckLeadTime
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkLeadTimeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reCalculateJobDatesField As ReCalculateJobDates
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reCalculateJobDatesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderWarehouseField As ChangeSalesOrderWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changeSalesOrderWarehouseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyMaterialField As ItemCopyMaterial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyLaborField As ItemCopyLabor
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyVerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyRelField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private copyFromJobField As ItemCopyFromJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductsField As List(Of ItemCoProduct)
        
        Public Sub New()
            MyBase.New
            Me.grossQuantityFlagField = "N"
            Me.includeOvertimePctField = IncludeOvertimePct.N
            Me.setMethodToManualField = SetMethodToManual.N
            Me.holdFlagField = HoldFlag.N
            Me.nonStockedField = NonStocked.N
            Me.traceableTypeField = TraceableType.N
            Me.hierarchyFlagField = HierarchyFlag.N
            Me.checkLeadTimeField = CheckLeadTime.N
            Me.reCalculateJobDatesField = ReCalculateJobDates.N
            Me.changeSalesOrderWarehouseField = ChangeSalesOrderWarehouse.N
            Me.copyMaterialField = ItemCopyMaterial.N
            Me.copyLaborField = ItemCopyLabor.N
            If (Me.coProductsField Is Nothing) Then
                Me.coProductsField = New List(Of ItemCoProduct)
            End If
            If (Me.copyFromJobField Is Nothing) Then
                Me.copyFromJobField = New ItemCopyFromJob
            End If
            If (Me.copyRelField Is Nothing) Then
                Me.copyRelField = New List(Of String)
            End If
            If (Me.subJobOptionsField Is Nothing) Then
                Me.subJobOptionsField = New SubJobOptions
            End If
        End Sub
        
        '''<summary>
        '''Job specifies the job being maintained. 
        '''This is mandatory if changing or deleting a job or adding/copying and the job numbering method is manual.
        '''If deleting a job then this is the only element required.
        '''The format is 8 characters alphanumeric or 8 chararcters numeric depending on the configuration option within SYSPRO. 
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
        '''This is the description to appear against the job.  If not defined when adding/copying a job for a stocked item then the stock description is used. The format is 30 characters, alphanumeric.
        '''</summary>
        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set
                Me.jobDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''Job classification for the job. If not supplied when adding a job then this defaults to the job classification held against the stock code if stocked or the job classification against the operator. 
        '''If job numbering method is by job class then this is used to generate the job on an add. 
        '''The format is 4 characters alphanumeric.
        '''</summary>
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        '''<summary>
        '''Priority of the job (1-99). 1 indicates the lowest priority and 99 indicates the highest priority. The format is 3 characters positive numeric.
        '''</summary>
        Public Property Priority() As String
            Get
                Return Me.priorityField
            End Get
            Set
                Me.priorityField = value
            End Set
        End Property
        
        '''<summary>
        '''Stock code of the finished item that is required to be made. This is mandatory when adding unless created from a sales order (see SalesOrder).
        '''When changing a job this can only be changed if maintaining a non-stocked live job and the job is not for a capex item.
        '''The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within SYSPRO.
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
        '''Version indicates the ECC version number of the stock code to make. Ignore if not an ECC controlled item, or if ECC controlled at a stocking level. 
        '''When adding and this is not supplied then defaults to the current version number for the stock code. 
        '''This cannot be changed.
        '''The format is 3 characters alphanumeric or 3 chararcters numeric depending on the configuration option within Bill of Materials setup.
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
        '''Release indicates the ECC release number of the component part. Ignored if not an ECC controlled item, or if ECC controlled at a stocking/revision level. 
        '''When adding and this is not supplied then defaults to the current release number for the stock code. 
        '''This cannot be changed.
        '''The format is 3 characters alphanumeric or 3 characters numeric depending on the configuration option within Bill of Materials setup.
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
        '''This is the warehouse to use for the finished stock code. When adding and this is not supplied then the finished stock code's warehouse to use is applied. 
        '''If the non-stocked flag is set then this is ignored. The format is 2 characters alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''Quantity required to make. If adding this is zero then the quantity to make is calculated based on the manufacturing basis defined against the stock code. This cannot be changed against a hierarchical job. The format is 7.3 positive numeric. 
        '''
        '''Quantity required to make within the co-product node allows you to individually add co-product quantities. The highest calculated notional part quantity will be used as the notional part quantity and is calculated as follows: (co-product quantity / co-product quantity per = notional part quantity). The default notional part quantity will be the qtytomake supplied or calculated for the notional part within the item node. If not all co-products are individually changed and the default notional part quantity is still the highest notional part quantity then it will be used as the notional part quantity. Co-products which are not individually changed will be driven by the notional part quantity. This element is only applicable when the WIP setup option 'Quantity capture co-product jobs' is a "C" - Co-product. This element is not applicable for proportional co-products. The format is 7.3 positive numeric. 
        '''</summary>
        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set
                Me.qtyToMakeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("N")>  _
        Public Property GrossQuantityFlag() As String
            Get
                Return Me.grossQuantityFlagField
            End Get
            Set
                Me.grossQuantityFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer to be used to create a sales order if a part billing is required. The format is up to 7 characters, alphanumeric or numeric depending on a configuration option within SYSPRO.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer name. This is overwritten by the customer's name held on file. 
        '''</summary>
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        '''<summary>
        '''Tender date required. This date is only used for documentation purposes. If adding a job and this is not returned the date defaults to today.
        '''</summary>
        Public Property JobTenderDate() As String
            Get
                Return Me.jobTenderDateField
            End Get
            Set
                Me.jobTenderDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This flag indicates the calculation method to be applied when calculating the job's start/delivery date based on attached labor allocations.
        '''D - Delivery date based on the start date using forward infinite scheduling.
        '''S - Start date based on the delivery date using backward infinite scheduling.
        '''M - Do not calculate start or delivery date.
        '''F - Delivery date based on the start date using forward finite scheduling. This option is available if the WIP installation option "Load Levelling Required" is set to 'Y' and allocations are attached to the job. If not then it is changed to date method 'D'.
        '''To calculate the delivery date from the start date the program processes each operation attached to the finished part and assumes the queue date of the first operation to be the start date of the job.
        '''The finish date of the first operation is calculated by adding the queue and elapsed time of that operation. The start date of the next operation is the finish date of the previous operation, plus movement time plus one day. The delivery date of the job is the finish date of the last operation plus movement time. 
        '''The reverse is true if calculating the start date.
        '''If creating sub jobs (CreateSubJob = 'Y') or job is linked to a sales order then the date calculation method is set to 'S'. This element can be supplied when doing a job copy.
        '''</summary>
        Public Property DateCalcMethod() As DateCalcMethod
            Get
                Return Me.dateCalcMethodField
            End Get
            Set
                Me.dateCalcMethodField = value
                Me.DateCalcMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DateCalcMethodSpecified() As Boolean
            Get
                Return Me.dateCalcMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Include overtime percentage in forward finite date calculation (DateMethod = 'F'). The overtime percentage is held against the work centers and is used when calculating capacity available on a given day and when calculating the capacity required by the operation for the day.
        '''If not returned then will use the WIP setup option 'Apply overtime percentage to forward finite calculation by default '. This element can be supplied when doing a job copy.
        '''</summary>
        Public Property IncludeOvertimePct() As IncludeOvertimePct
            Get
                Return Me.includeOvertimePctField
            End Get
            Set
                Me.includeOvertimePctField = value
                Me.IncludeOvertimePctFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeOvertimePctSpecified() As Boolean
            Get
                Return Me.includeOvertimePctFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This option will fix the calculated dates by setting the calculation method to manual (DateMethod = 'M'). This element can be supplied when doing a job copy.
        '''</summary>
        Public Property SetMethodToManual() As SetMethodToManual
            Get
                Return Me.setMethodToManualField
            End Get
            Set
                Me.setMethodToManualField = value
                Me.SetMethodToManualFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SetMethodToManualSpecified() As Boolean
            Get
                Return Me.setMethodToManualFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Date on which the job is to start.  If adding/copying a job and this is not returned the date defaults to today.
        '''</summary>
        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set
                Me.jobStartDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Date on which the job is due for completion.  If adding/copying a job and this is not returned the date defaults to today.
        '''</summary>
        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set
                Me.jobDeliveryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Flag indicates whether or not sequence checking is required on operations when posting labor  (i.e. an operation number cannot be posted to if work has not already commenced on the previous operation. If adding a job and this is not returned then will use the WIP setup option 'Sequence checking required by default'
        '''</summary>
        Public Property SeqCheckReq() As SeqCheckReq
            Get
                Return Me.seqCheckReqField
            End Get
            Set
                Me.seqCheckReqField = value
                Me.SeqCheckReqFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SeqCheckReqSpecified() As Boolean
            Get
                Return Me.seqCheckReqFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Flag indicates whether or not the job is confirmed. If adding or copying a job and this is not returned then the WIP setup option 'Jobs confirmed by default' will be used.
        '''Material and labor postings cannot be made to an unconfirmed job. Furthermore unconfirmed jobs can be excluded from requirements planning.
        '''A job can be confirmed at any time but jobs cannot be 'unconfirmed' if the job has been started (i.e. issues of labor hours or materials have been made).
        '''</summary>
        Public Property ConfirmedFlag() As ConfirmedFlag
            Get
                Return Me.confirmedFlagField
            End Get
            Set
                Me.confirmedFlagField = value
                Me.ConfirmedFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConfirmedFlagSpecified() As Boolean
            Get
                Return Me.confirmedFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Flag indicates whether a job is on hold. Set to 'Y'  to suspend processing for the job.
        '''</summary>
        Public Property HoldFlag() As HoldFlag
            Get
                Return Me.holdFlagField
            End Get
            Set
                Me.holdFlagField = value
                Me.HoldFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property HoldFlagSpecified() As Boolean
            Get
                Return Me.holdFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Bill of materials route from which to create the job allocatons. This is only required when adding a job and 'Bill of Materials' is installed and the BOM setup option 'Alternate routings required' is set. This can also be used when copying material and labor allocations for a non-stocked job and specifies the route from which you want to copy. If not supplied then defaults to the standard route (0).
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
        '''The password associated with the Bill of Material route. This element can be supplied when copying a job.
        '''</summary>
        Public Property RoutePassword() As String
            Get
                Return Me.routePasswordField
            End Get
            Set
                Me.routePasswordField = value
            End Set
        End Property
        
        '''<summary>
        '''Work in progress control account to which the value of work in progress is to be posted. When adding a job and this is blank then uses the account defined against the stock code, if that is blank then the account defined in GL integration is used.This cannot be changed once the job has been confirmed and transactions have been posted to the job or the job is for a capex item.
        '''</summary>
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''When adding a job this flag indicates whether the item to make is non-stocked. If the warehouse to use is set to '**' then this flag is set to 'Y'.
        '''</summary>
        Public Property NonStocked() As NonStocked
            Get
                Return Me.nonStockedField
            End Get
            Set
                Me.nonStockedField = value
                Me.NonStockedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property NonStockedSpecified() As Boolean
            Get
                Return Me.nonStockedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Description of the item to make. If a job for a stocked item is being processed then the description held against the item is used.
        '''</summary>
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''Expected unit labor cost of the item to make. This is ignored if the item to make is stocked. The format is 10.5 numeric.
        '''</summary>
        Public Property ExpLabour() As String
            Get
                Return Me.expLabourField
            End Get
            Set
                Me.expLabourField = value
            End Set
        End Property
        
        '''<summary>
        '''Expected unit material cost of the item to make. This is ignored if the item to make is stocked. The format is 10.5 numeric.
        '''</summary>
        Public Property ExpMaterial() As String
            Get
                Return Me.expMaterialField
            End Get
            Set
                Me.expMaterialField = value
            End Set
        End Property
        
        '''<summary>
        '''Unit selling price to be used in part billings to determine the value of the sales order.This is ignored if the item to make is stocked. When changing a job if the job is for a capex item then this is also ignored. The format is 10.5 positive numeric.
        '''</summary>
        Public Property SellingPrice() As String
            Get
                Return Me.sellingPriceField
            End Get
            Set
                Me.sellingPriceField = value
            End Set
        End Property
        
        '''<summary>
        '''Additional charge percentage for labor to be used in part billings as a means of increasing the value of un-billed labor entries held against the job.This is ignored if the item to make is stocked. The format is 3.2 positive numeric.
        '''</summary>
        Public Property AddLabPct() As String
            Get
                Return Me.addLabPctField
            End Get
            Set
                Me.addLabPctField = value
            End Set
        End Property
        
        '''<summary>
        '''Additional charge percentage for material to be used in part billings as a means of increasing the value of un-billed material entries held against the job.This is ignored if the item to make is stocked. The format is 3.2 positive numeric.
        '''</summary>
        Public Property AddMatPct() As String
            Get
                Return Me.addMatPctField
            End Get
            Set
                Me.addMatPctField = value
            End Set
        End Property
        
        '''<summary>
        '''Additional percentage profit charge to be used in part billings as a means of increasing the value to be invoiced.This is ignored if the item to make is stocked. The format is 3.2 positive numeric.
        '''</summary>
        Public Property ProfitPct() As String
            Get
                Return Me.profitPctField
            End Get
            Set
                Me.profitPctField = value
            End Set
        End Property
        
        '''<summary>
        '''Flag to indicate whether a non-stocked item to make is traceable. Ignored if not adding a job, if lot traceability is not installed or the item to make is stocked.
        '''</summary>
        Public Property TraceableType() As TraceableType
            Get
                Return Me.traceableTypeField
            End Get
            Set
                Me.traceableTypeField = value
                Me.TraceableTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TraceableTypeSpecified() As Boolean
            Get
                Return Me.traceableTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Flag to indicate whether the job being added is hierarchical. Ignored if not adding a job, if projects and contracts is not installed or the item to make is a notional part or multi-grade coproduct part
        '''</summary>
        Public Property HierarchyFlag() As HierarchyFlag
            Get
                Return Me.hierarchyFlagField
            End Get
            Set
                Me.hierarchyFlagField = value
                Me.HierarchyFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property HierarchyFlagSpecified() As Boolean
            Get
                Return Me.hierarchyFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If the job is hierarchical (HierarchyFlag = 'Y') and the job is attached to a contract then the contract must be entered here. Ignored if not adding a job.
        '''Any number of jobs can be annotated to form part of an overall contract. Transactions cannot be made to the contract; only to a constituent job.
        '''</summary>
        Public Property HierarchyContract() As String
            Get
                Return Me.hierarchyContractField
            End Get
            Set
                Me.hierarchyContractField = value
            End Set
        End Property
        
        '''<summary>
        '''If the job is hierarchical (HierarchyFlag = 'Y') then a hierarchy library code can be entered here to create the job's hierarchy of heads and sections. Ignored if not adding a job.
        '''At the time of creating a job you can assign a hierarchy of heads and sections. A head is the top level section for a job. An unlimited number of heads can be assigned. To each head, an unlimited number of sections can be attached and, again, an unlimited number of sections can be attached to each section. The process can continue through four levels of sections.
        '''Currently user defined hierarchy is not supported by this object.
        '''</summary>
        Public Property HierarchyCode() As String
            Get
                Return Me.hierarchyCodeField
            End Get
            Set
                Me.hierarchyCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Sales order for which the job is to be added. Ignored if not adding a job or sales orders is not installed or the sales order line os not returned.The format is up to 6 characters alphanumeric, or numeric depending on the sales order key type option within SYSPRO.
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''Sales order line for which the job is to be added. Ignored if not adding a job or sales orders is not installed or the sales order is not returned.
        '''If valid then the information for creating the job (stock code, warehouse, quantity etc.) is all obtained from the sales order line.
        '''The line can be between 0 and 9999.
        '''</summary>
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Flag to indicate whether to include allocations when adding a job. This flag is ignored if creating a non-stocked item or Bill of Materials is not installed and is set to 'N'.
        '''If set to 'Y' material and labor allocations are added against the job based on the structure and routings defined in the bill of materials for this parent on this route.
        '''</summary>
        Public Property IncludeAllocations() As IncludeAllocations
            Get
                Return Me.includeAllocationsField
            End Get
            Set
                Me.includeAllocationsField = value
                Me.IncludeAllocationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeAllocationsSpecified() As Boolean
            Get
                Return Me.includeAllocationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter a specific warehouse that must be used when issuing all material to the job. Otherwise the warehouse to use held against each component (specified at the Warehouse to use field of the Stock Codes Setup program) is used when allocating material to the job. This is ignored if not adding a job or allocations are not included.
        '''</summary>
        Public Property ComponentWarehouse() As String
            Get
                Return Me.componentWarehouseField
            End Get
            Set
                Me.componentWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''Options required when creating sub jobs for attached components
        '''</summary>
        Public Property SubJobOptions() As SubJobOptions
            Get
                Return Me.subJobOptionsField
            End Get
            Set
                Me.subJobOptionsField = value
            End Set
        End Property
        
        '''<summary>
        '''Flag indicating whether to calculate a start date based on the delivery date entered and the lead time against the stock code to see whether the job can be done. Ignored if not adding a new job or the date calculation method (DateCalcMethod) is not set to 'S' or 'M'
        '''</summary>
        Public Property CheckLeadTime() As CheckLeadTime
            Get
                Return Me.checkLeadTimeField
            End Get
            Set
                Me.checkLeadTimeField = value
                Me.CheckLeadTimeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CheckLeadTimeSpecified() As Boolean
            Get
                Return Me.checkLeadTimeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Set this flag to force recalculation of start and delivery dates when updating a job. This flag is ignored and date recalculation automatically takes place if one of the following has been changed; quantity (QtyToMake), date calculation method (DateCalcMethod), start date (JobStartDate) or delivery date (JobDeliveryDate).
        '''</summary>
        Public Property ReCalculateJobDates() As ReCalculateJobDates
            Get
                Return Me.reCalculateJobDatesField
            End Get
            Set
                Me.reCalculateJobDatesField = value
                Me.ReCalculateJobDatesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReCalculateJobDatesSpecified() As Boolean
            Get
                Return Me.reCalculateJobDatesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Set this flag to change the sales order warehouse if changing the warehouse (Warehouse) against a job that is attached to a sales order.
        '''</summary>
        Public Property ChangeSalesOrderWarehouse() As ChangeSalesOrderWarehouse
            Get
                Return Me.changeSalesOrderWarehouseField
            End Get
            Set
                Me.changeSalesOrderWarehouseField = value
                Me.ChangeSalesOrderWarehouseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChangeSalesOrderWarehouseSpecified() As Boolean
            Get
                Return Me.changeSalesOrderWarehouseFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyMaterial.N)>  _
        Public Property CopyMaterial() As ItemCopyMaterial
            Get
                Return Me.copyMaterialField
            End Get
            Set
                Me.copyMaterialField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyLabor.N)>  _
        Public Property CopyLabor() As ItemCopyLabor
            Get
                Return Me.copyLaborField
            End Get
            Set
                Me.copyLaborField = value
            End Set
        End Property
        
        Public Property CopyStockCode() As String
            Get
                Return Me.copyStockCodeField
            End Get
            Set
                Me.copyStockCodeField = value
            End Set
        End Property
        
        Public Property CopyVer() As String
            Get
                Return Me.copyVerField
            End Get
            Set
                Me.copyVerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CopyRel")>  _
        Public Property CopyRelCollection() As List(Of String)
            Get
                Return Me.copyRelField
            End Get
            Set
                Me.copyRelField = value
            End Set
        End Property
        
        Public Property CopyFromJob() As ItemCopyFromJob
            Get
                Return Me.copyFromJobField
            End Get
            Set
                Me.copyFromJobField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("CoProduct", IsNullable:=False), _
        System.Xml.Serialization.XmlArray("CoProducts")> _
        Public Property CoProductsCollection() As List(Of ItemCoProduct)
            Get
                Return Me.coProductsField
            End Get
            Set(ByVal value As List(Of ItemCoProduct))
                Me.coProductsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SetMethodToManual
        
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
    Public Enum SeqCheckReq
        
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
    Public Enum NonStocked
        
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
    Public Enum TraceableType
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SubJobOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobsField As CreateSubJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobPrefixField As SubJobPrefix
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobPrefixFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useGlForAllJobsField As UseGlForAllJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useGlForAllJobsFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.createSubJobsField = CreateSubJobs.N
            Me.useGlForAllJobsField = UseGlForAllJobs.N
        End Sub
        
        '''<summary>
        '''Flag to indicate whether or not to create the required sub jobs for all components in a structure against which you indicated that a sub job must be raised (within the Bill of Materials Structures and Routings program). This will create, in effect, a bill of jobs for all relevant components down the BOM chain.
        '''Ignored if not adding a new job and if not including allocations (IncludeAllocations = 'N')
        '''</summary>
        Public Property CreateSubJobs() As CreateSubJobs
            Get
                Return Me.createSubJobsField
            End Get
            Set
                Me.createSubJobsField = value
                Me.CreateSubJobsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CreateSubJobsSpecified() As Boolean
            Get
                Return Me.createSubJobsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If creating sub jobs for components (CreateSubJobs = 'Y') and job numbering is set to Manual. This prefix is strung together with the sub job suffix (SubJobSuffix) to create the job for each sub job.The format is up to 5 characters alphanumeric, or numeric depending on the job key type option within SYSPRO.
        '''</summary>
        Public Property SubJobPrefix() As SubJobPrefix
            Get
                Return Me.subJobPrefixField
            End Get
            Set
                Me.subJobPrefixField = value
                Me.SubJobPrefixFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SubJobPrefixSpecified() As Boolean
            Get
                Return Me.subJobPrefixFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If creating sub jobs for components (CreateSubJobs = 'Y') and job numbering is set to Manual. This suffix is strung together with the sub job prefix (SubJobPrefix) to create the job for each sub job.The format is up to 8 characters numeric. 
        '''</summary>
        Public Property SubJobSuffix() As String
            Get
                Return Me.subJobSuffixField
            End Get
            Set
                Me.subJobSuffixField = value
            End Set
        End Property
        
        '''<summary>
        '''Set this flag to 'Y' to use the work in progress control account against the parent job for all sub jobs when creating sub jobs for components (CreateSubJobs = 'Y') 
        '''</summary>
        Public Property UseGlForAllJobs() As UseGlForAllJobs
            Get
                Return Me.useGlForAllJobsField
            End Get
            Set
                Me.useGlForAllJobsField = value
                Me.UseGlForAllJobsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseGlForAllJobsSpecified() As Boolean
            Get
                Return Me.useGlForAllJobsFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CreateSubJobs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SubJobPrefix
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseGlForAllJobs
        
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
    Public Enum ReCalculateJobDates
        
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
    Public Enum ItemCopyMaterial
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyLabor
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemCopyFromJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private archivedJobField As ItemCopyFromJobArchivedJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private archiveNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedOrBuiltField As ItemCopyFromJobPlannedOrBuilt
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialAllocsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLaborAllocsField As ItemCopyFromJobIncludeLaborAllocs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNotepadField As ItemCopyFromJobIncludeNotepad
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As ItemCopyFromJobIncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNarrationsField As ItemCopyFromJobIncludeNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMultimediaField As ItemCopyFromJobIncludeMultimedia
        
        Public Sub New()
            MyBase.New
            Me.archivedJobField = ItemCopyFromJobArchivedJob.N
            Me.plannedOrBuiltField = ItemCopyFromJobPlannedOrBuilt.P
            Me.includeMaterialAllocsField = "N"
            Me.includeLaborAllocsField = ItemCopyFromJobIncludeLaborAllocs.N
            Me.includeNotepadField = ItemCopyFromJobIncludeNotepad.N
            Me.includeCustomFormsField = ItemCopyFromJobIncludeCustomForms.N
            Me.includeNarrationsField = ItemCopyFromJobIncludeNarrations.N
            Me.includeMultimediaField = ItemCopyFromJobIncludeMultimedia.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobArchivedJob.N)>  _
        Public Property ArchivedJob() As ItemCopyFromJobArchivedJob
            Get
                Return Me.archivedJobField
            End Get
            Set
                Me.archivedJobField = value
            End Set
        End Property
        
        Public Property ArchiveNumber() As String
            Get
                Return Me.archiveNumberField
            End Get
            Set
                Me.archiveNumberField = value
            End Set
        End Property
        
        Public Property FromJob() As String
            Get
                Return Me.fromJobField
            End Get
            Set
                Me.fromJobField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobPlannedOrBuilt.P)>  _
        Public Property PlannedOrBuilt() As ItemCopyFromJobPlannedOrBuilt
            Get
                Return Me.plannedOrBuiltField
            End Get
            Set
                Me.plannedOrBuiltField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("N")>  _
        Public Property IncludeMaterialAllocs() As String
            Get
                Return Me.includeMaterialAllocsField
            End Get
            Set
                Me.includeMaterialAllocsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobIncludeLaborAllocs.N)>  _
        Public Property IncludeLaborAllocs() As ItemCopyFromJobIncludeLaborAllocs
            Get
                Return Me.includeLaborAllocsField
            End Get
            Set
                Me.includeLaborAllocsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobIncludeNotepad.N)>  _
        Public Property IncludeNotepad() As ItemCopyFromJobIncludeNotepad
            Get
                Return Me.includeNotepadField
            End Get
            Set
                Me.includeNotepadField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobIncludeCustomForms.N)>  _
        Public Property IncludeCustomForms() As ItemCopyFromJobIncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobIncludeNarrations.N)>  _
        Public Property IncludeNarrations() As ItemCopyFromJobIncludeNarrations
            Get
                Return Me.includeNarrationsField
            End Get
            Set
                Me.includeNarrationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCopyFromJobIncludeMultimedia.N)>  _
        Public Property IncludeMultimedia() As ItemCopyFromJobIncludeMultimedia
            Get
                Return Me.includeMultimediaField
            End Get
            Set
                Me.includeMultimediaField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobArchivedJob
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobPlannedOrBuilt
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobIncludeLaborAllocs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobIncludeNotepad
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobIncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobIncludeNarrations
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCopyFromJobIncludeMultimedia
        
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
    Partial Public Class ItemCoProduct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerNotionalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeCoProductField As ItemCoProductExcludeCoProduct
        
        Public Sub New()
            MyBase.New
            Me.excludeCoProductField = ItemCoProductExcludeCoProduct.N
        End Sub
        
        Public Property CoProductLine() As String
            Get
                Return Me.coProductLineField
            End Get
            Set
                Me.coProductLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Quantity required to make. If adding this is zero then the quantity to make is calculated based on the manufacturing basis defined against the stock code. This cannot be changed against a hierarchical job. The format is 7.3 positive numeric. 
        '''
        '''Quantity required to make within the co-product node allows you to individually add co-product quantities. The highest calculated notional part quantity will be used as the notional part quantity and is calculated as follows: (co-product quantity / co-product quantity per = notional part quantity). The default notional part quantity will be the qtytomake supplied or calculated for the notional part within the item node. If not all co-products are individually changed and the default notional part quantity is still the highest notional part quantity then it will be used as the notional part quantity. Co-products which are not individually changed will be driven by the notional part quantity. This element is only applicable when the WIP setup option 'Quantity capture co-product jobs' is a "C" - Co-product. This element is not applicable for proportional co-products. The format is 7.3 positive numeric. 
        '''</summary>
        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set
                Me.qtyToMakeField = value
            End Set
        End Property
        
        Public Property QtyPerNotional() As String
            Get
                Return Me.qtyPerNotionalField
            End Get
            Set
                Me.qtyPerNotionalField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemCoProductExcludeCoProduct.N)>  _
        Public Property ExcludeCoProduct() As ItemCoProductExcludeCoProduct
            Get
                Return Me.excludeCoProductField
            End Get
            Set
                Me.excludeCoProductField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemCoProductExcludeCoProduct
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostJob
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain a job.
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
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTJB"
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
                Return Common.SysproUtilities.SerializeToXMLString(Me) ').Replace("CoProductsCollection", "CoProducts")
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostJob
                objParams = New Params.PostJob
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
