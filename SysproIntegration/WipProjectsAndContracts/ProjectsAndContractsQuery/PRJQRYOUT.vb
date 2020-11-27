Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipProjectsAndContracts.ProjectsAndContractsQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PrjQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As PrjQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDetailsField As PrjQueryContractDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDetailsField As List(Of PrjQueryJobDetails)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractValuesField As PrjQueryContractValues
        
        Public Sub New()
            MyBase.New
            If (Me.contractValuesField Is Nothing) Then
                Me.contractValuesField = New PrjQueryContractValues
            End If
            If (Me.jobDetailsField Is Nothing) Then
                Me.jobDetailsField = New List(Of PrjQueryJobDetails)
            End If
            If (Me.contractDetailsField Is Nothing) Then
                Me.contractDetailsField = New PrjQueryContractDetails
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New PrjQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As PrjQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property ContractDetails() As PrjQueryContractDetails
            Get
                Return Me.contractDetailsField
            End Get
            Set
                Me.contractDetailsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("JobDetails")>  _
        Public Property JobDetailsCollection() As List(Of PrjQueryJobDetails)
            Get
                Return Me.jobDetailsField
            End Get
            Set
                Me.jobDetailsField = value
            End Set
        End Property
        
        Public Property ContractValues() As PrjQueryContractValues
            Get
                Return Me.contractValuesField
            End Get
            Set
                Me.contractValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQuerySystemInformation
        
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
    Partial Public Class PrjQueryContractDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc3Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc4Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc5Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private responsibilityCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private responsiblePersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private estCompletionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextReviewDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextBillingDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastReviewDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actCompletionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private imageField As String
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property ContractDesc1() As String
            Get
                Return Me.contractDesc1Field
            End Get
            Set
                Me.contractDesc1Field = value
            End Set
        End Property
        
        Public Property ContractDesc2() As String
            Get
                Return Me.contractDesc2Field
            End Get
            Set
                Me.contractDesc2Field = value
            End Set
        End Property
        
        Public Property ContractDesc3() As Object
            Get
                Return Me.contractDesc3Field
            End Get
            Set
                Me.contractDesc3Field = value
            End Set
        End Property
        
        Public Property ContractDesc4() As Object
            Get
                Return Me.contractDesc4Field
            End Get
            Set
                Me.contractDesc4Field = value
            End Set
        End Property
        
        Public Property ContractDesc5() As Object
            Get
                Return Me.contractDesc5Field
            End Get
            Set
                Me.contractDesc5Field = value
            End Set
        End Property
        
        Public Property ResponsibilityCode() As String
            Get
                Return Me.responsibilityCodeField
            End Get
            Set
                Me.responsibilityCodeField = value
            End Set
        End Property
        
        Public Property ResponsiblePerson() As String
            Get
                Return Me.responsiblePersonField
            End Get
            Set
                Me.responsiblePersonField = value
            End Set
        End Property
        
        Public Property EstCompletionDate() As String
            Get
                Return Me.estCompletionDateField
            End Get
            Set
                Me.estCompletionDateField = value
            End Set
        End Property
        
        Public Property NextReviewDate() As String
            Get
                Return Me.nextReviewDateField
            End Get
            Set
                Me.nextReviewDateField = value
            End Set
        End Property
        
        Public Property NextBillingDate() As String
            Get
                Return Me.nextBillingDateField
            End Get
            Set
                Me.nextBillingDateField = value
            End Set
        End Property
        
        Public Property LastReviewDate() As String
            Get
                Return Me.lastReviewDateField
            End Get
            Set
                Me.lastReviewDateField = value
            End Set
        End Property
        
        Public Property ActCompletionDate() As String
            Get
                Return Me.actCompletionDateField
            End Get
            Set
                Me.actCompletionDateField = value
            End Set
        End Property
        
        Public Property Image() As String
            Get
                Return Me.imageField
            End Get
            Set
                Me.imageField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("ActCompletionDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("BillingAndCostOfSalesDetails", GetType(PrjQueryJobDetailsBillingAndCostOfSalesDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("CommittedLaborDetails", GetType(PrjQueryJobDetailsCommittedLaborDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("CommittedMaterialDetails", GetType(PrjQueryJobDetailsCommittedMaterialDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("CommittedPurchaseOrderDetails", GetType(PrjQueryJobDetailsCommittedPurchaseOrderDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("CommittedSubContractDetails", GetType(PrjQueryJobDetailsCommittedSubContractDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("CompleteFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ConfirmedFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Customer", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomerName", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("HierarchyDetails", GetType(PrjQueryJobDetailsHierarchyDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("HoldFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Image", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Job", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("JobClassification", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("JobDeliveryDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("JobDescription", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("JobStartDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("JobValues", GetType(PrjQueryJobDetailsJobValues)),  _
         System.Xml.Serialization.XmlElementAttribute("MasterJob", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("QtyManufactured", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("QtyToMake", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesAndAdjustmentsDetails", GetType(PrjQueryJobDetailsSalesAndAdjustmentsDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrder", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrderLine", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("StockCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("StockDescription", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("UnCommittedLaborDetails", GetType(PrjQueryJobDetailsUnCommittedLaborDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("UnCommittedMaterialDetails", GetType(PrjQueryJobDetailsUnCommittedMaterialDetails)),  _
         System.Xml.Serialization.XmlElementAttribute("UnCommittedSubContractDetails", GetType(PrjQueryJobDetailsUnCommittedSubContractDetails)),  _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ItemsElementName"),  _
         System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ItemsElementNameCollection() As List(Of ItemsChoiceType)
            Get
                Return Me.itemsElementNameField
            End Get
            Set
                Me.itemsElementNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsBillingAndCostOfSalesDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUnitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityReleasedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partBillingJournalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partBillingJournalEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postedToJobField As Object
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
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
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
            End Set
        End Property
        
        Public Property TransactionDate() As String
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = value
            End Set
        End Property
        
        Public Property TransactionType() As String
            Get
                Return Me.transactionTypeField
            End Get
            Set
                Me.transactionTypeField = value
            End Set
        End Property
        
        Public Property CostOfSalesValue() As String
            Get
                Return Me.costOfSalesValueField
            End Get
            Set
                Me.costOfSalesValueField = value
            End Set
        End Property
        
        Public Property BillingValue() As String
            Get
                Return Me.billingValueField
            End Get
            Set
                Me.billingValueField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property SalesOrder() As UShort
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As UShort)
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
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
        
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property SalesOrderLineType() As String
            Get
                Return Me.salesOrderLineTypeField
            End Get
            Set
                Me.salesOrderLineTypeField = value
            End Set
        End Property
        
        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
            End Set
        End Property
        
        Public Property OrderUnitOfMeasure() As String
            Get
                Return Me.orderUnitOfMeasureField
            End Get
            Set
                Me.orderUnitOfMeasureField = value
            End Set
        End Property
        
        Public Property QuantityReleased() As String
            Get
                Return Me.quantityReleasedField
            End Get
            Set
                Me.quantityReleasedField = value
            End Set
        End Property
        
        Public Property PartBillingJournal() As String
            Get
                Return Me.partBillingJournalField
            End Get
            Set
                Me.partBillingJournalField = value
            End Set
        End Property
        
        Public Property PartBillingJournalEntry() As String
            Get
                Return Me.partBillingJournalEntryField
            End Get
            Set
                Me.partBillingJournalEntryField = value
            End Set
        End Property
        
        Public Property PostedToJob() As Object
            Get
                Return Me.postedToJobField
            End Get
            Set
                Me.postedToJobField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsCommittedLaborDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private machineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private employeeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setupTimeIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startupTimeIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runTimeIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private teardownTimeIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueIssuedField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCenter() As String
            Get
                Return Me.workCenterField
            End Get
            Set
                Me.workCenterField = value
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
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
            End Set
        End Property
        
        Public Property Machine() As String
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
        
        Public Property Employee() As String
            Get
                Return Me.employeeField
            End Get
            Set
                Me.employeeField = value
            End Set
        End Property
        
        Public Property SetupTimeIssued() As String
            Get
                Return Me.setupTimeIssuedField
            End Get
            Set
                Me.setupTimeIssuedField = value
            End Set
        End Property
        
        Public Property StartupTimeIssued() As String
            Get
                Return Me.startupTimeIssuedField
            End Get
            Set
                Me.startupTimeIssuedField = value
            End Set
        End Property
        
        Public Property RunTimeIssued() As String
            Get
                Return Me.runTimeIssuedField
            End Get
            Set
                Me.runTimeIssuedField = value
            End Set
        End Property
        
        Public Property TeardownTimeIssued() As String
            Get
                Return Me.teardownTimeIssuedField
            End Get
            Set
                Me.teardownTimeIssuedField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        Public Property ValueIssued() As String
            Get
                Return Me.valueIssuedField
            End Get
            Set
                Me.valueIssuedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsCommittedMaterialDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revisionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costUnitOfMeasureField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueIssuedField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
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
        
        Public Property Revision() As Object
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = value
            End Set
        End Property
        
        Public Property Release() As Object
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property QuantityIssued() As String
            Get
                Return Me.quantityIssuedField
            End Get
            Set
                Me.quantityIssuedField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
            End Set
        End Property
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
            End Set
        End Property
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
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
        
        Public Property CostUnitOfMeasure() As Object
            Get
                Return Me.costUnitOfMeasureField
            End Get
            Set
                Me.costUnitOfMeasureField = value
            End Set
        End Property
        
        Public Property ValueIssued() As String
            Get
                Return Me.valueIssuedField
            End Get
            Set
                Me.valueIssuedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsCommittedPurchaseOrderDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityOutstandingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUnitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueOutstandingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subContractOperationField As Object
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property PurchaseOrder() As UShort
            Get
                Return Me.purchaseOrderField
            End Get
            Set(ByVal value As UShort)
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
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
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
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
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
            End Set
        End Property
        
        Public Property QuantityOutstanding() As String
            Get
                Return Me.quantityOutstandingField
            End Get
            Set
                Me.quantityOutstandingField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property PriceUnitOfMeasure() As String
            Get
                Return Me.priceUnitOfMeasureField
            End Get
            Set
                Me.priceUnitOfMeasureField = value
            End Set
        End Property
        
        Public Property ValueOutstanding() As String
            Get
                Return Me.valueOutstandingField
            End Get
            Set
                Me.valueOutstandingField = value
            End Set
        End Property
        
        Public Property SubContractOperation() As Object
            Get
                Return Me.subContractOperationField
            End Get
            Set
                Me.subContractOperationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsCommittedSubContractDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueIssuedField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCenter() As String
            Get
                Return Me.workCenterField
            End Get
            Set
                Me.workCenterField = value
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
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
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
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        Public Property ValueIssued() As String
            Get
                Return Me.valueIssuedField
            End Get
            Set
                Me.valueIssuedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsHierarchyDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private imageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentLevelValuesField As PrjQueryJobDetailsHierarchyDetailsCurrentLevelValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rolledUpValuesField As PrjQueryJobDetailsHierarchyDetailsRolledUpValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anticipatedValue1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anticipatedValue2Field As String
        
        Public Sub New()
            MyBase.New
            If (Me.rolledUpValuesField Is Nothing) Then
                Me.rolledUpValuesField = New PrjQueryJobDetailsHierarchyDetailsRolledUpValues
            End If
            If (Me.currentLevelValuesField Is Nothing) Then
                Me.currentLevelValuesField = New PrjQueryJobDetailsHierarchyDetailsCurrentLevelValues
            End If
        End Sub
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property HierarchyDescription() As String
            Get
                Return Me.hierarchyDescriptionField
            End Get
            Set
                Me.hierarchyDescriptionField = value
            End Set
        End Property
        
        Public Property Image() As String
            Get
                Return Me.imageField
            End Get
            Set
                Me.imageField = value
            End Set
        End Property
        
        Public Property CurrentLevelValues() As PrjQueryJobDetailsHierarchyDetailsCurrentLevelValues
            Get
                Return Me.currentLevelValuesField
            End Get
            Set
                Me.currentLevelValuesField = value
            End Set
        End Property
        
        Public Property RolledUpValues() As PrjQueryJobDetailsHierarchyDetailsRolledUpValues
            Get
                Return Me.rolledUpValuesField
            End Get
            Set
                Me.rolledUpValuesField = value
            End Set
        End Property
        
        Public Property AnticipatedValue1() As String
            Get
                Return Me.anticipatedValue1Field
            End Get
            Set
                Me.anticipatedValue1Field = value
            End Set
        End Property
        
        Public Property AnticipatedValue2() As String
            Get
                Return Me.anticipatedValue2Field
            End Get
            Set
                Me.anticipatedValue2Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsHierarchyDetailsCurrentLevelValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesRevenueOriginalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedSubcontractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedSubContractField As String
        
        Public Property SalesRevenueOriginal() As String
            Get
                Return Me.salesRevenueOriginalField
            End Get
            Set
                Me.salesRevenueOriginalField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisPeriod() As String
            Get
                Return Me.salesAdjustmentsThisPeriodField
            End Get
            Set
                Me.salesAdjustmentsThisPeriodField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisYear() As String
            Get
                Return Me.salesAdjustmentsThisYearField
            End Get
            Set
                Me.salesAdjustmentsThisYearField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsPriorYears() As String
            Get
                Return Me.salesAdjustmentsPriorYearsField
            End Get
            Set
                Me.salesAdjustmentsPriorYearsField = value
            End Set
        End Property
        
        Public Property BillingsThisPeriod() As String
            Get
                Return Me.billingsThisPeriodField
            End Get
            Set
                Me.billingsThisPeriodField = value
            End Set
        End Property
        
        Public Property BillingsThisYear() As String
            Get
                Return Me.billingsThisYearField
            End Get
            Set
                Me.billingsThisYearField = value
            End Set
        End Property
        
        Public Property BillingsPriorYears() As String
            Get
                Return Me.billingsPriorYearsField
            End Get
            Set
                Me.billingsPriorYearsField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisPeriod() As String
            Get
                Return Me.costOfSalesThisPeriodField
            End Get
            Set
                Me.costOfSalesThisPeriodField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisYear() As String
            Get
                Return Me.costOfSalesThisYearField
            End Get
            Set
                Me.costOfSalesThisYearField = value
            End Set
        End Property
        
        Public Property CostOfSalesPriorYears() As String
            Get
                Return Me.costOfSalesPriorYearsField
            End Get
            Set
                Me.costOfSalesPriorYearsField = value
            End Set
        End Property
        
        Public Property OriginalExpectedMaterial() As String
            Get
                Return Me.originalExpectedMaterialField
            End Get
            Set
                Me.originalExpectedMaterialField = value
            End Set
        End Property
        
        Public Property OriginalExpectedLabor() As String
            Get
                Return Me.originalExpectedLaborField
            End Get
            Set
                Me.originalExpectedLaborField = value
            End Set
        End Property
        
        Public Property OriginalExpectedSubcontract() As String
            Get
                Return Me.originalExpectedSubcontractField
            End Get
            Set
                Me.originalExpectedSubcontractField = value
            End Set
        End Property
        
        Public Property CommittedMaterialPurchaseOrders() As String
            Get
                Return Me.committedMaterialPurchaseOrdersField
            End Get
            Set
                Me.committedMaterialPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedSubContractPurchaseOrders() As String
            Get
                Return Me.committedSubContractPurchaseOrdersField
            End Get
            Set
                Me.committedSubContractPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedMaterial() As String
            Get
                Return Me.committedMaterialField
            End Get
            Set
                Me.committedMaterialField = value
            End Set
        End Property
        
        Public Property CommittedLabor() As String
            Get
                Return Me.committedLaborField
            End Get
            Set
                Me.committedLaborField = value
            End Set
        End Property
        
        Public Property CommittedSubContract() As String
            Get
                Return Me.committedSubContractField
            End Get
            Set
                Me.committedSubContractField = value
            End Set
        End Property
        
        Public Property UncommittedMaterial() As String
            Get
                Return Me.uncommittedMaterialField
            End Get
            Set
                Me.uncommittedMaterialField = value
            End Set
        End Property
        
        Public Property UncommittedLabor() As String
            Get
                Return Me.uncommittedLaborField
            End Get
            Set
                Me.uncommittedLaborField = value
            End Set
        End Property
        
        Public Property UncommittedSubContract() As String
            Get
                Return Me.uncommittedSubContractField
            End Get
            Set
                Me.uncommittedSubContractField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsHierarchyDetailsRolledUpValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lowerLevelsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesRevenueOriginalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedSubcontractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedSubContractField As String
        
        Public Property LowerLevels() As String
            Get
                Return Me.lowerLevelsField
            End Get
            Set
                Me.lowerLevelsField = value
            End Set
        End Property
        
        Public Property SalesRevenueOriginal() As String
            Get
                Return Me.salesRevenueOriginalField
            End Get
            Set
                Me.salesRevenueOriginalField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisPeriod() As String
            Get
                Return Me.salesAdjustmentsThisPeriodField
            End Get
            Set
                Me.salesAdjustmentsThisPeriodField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisYear() As String
            Get
                Return Me.salesAdjustmentsThisYearField
            End Get
            Set
                Me.salesAdjustmentsThisYearField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsPriorYears() As String
            Get
                Return Me.salesAdjustmentsPriorYearsField
            End Get
            Set
                Me.salesAdjustmentsPriorYearsField = value
            End Set
        End Property
        
        Public Property BillingsThisPeriod() As String
            Get
                Return Me.billingsThisPeriodField
            End Get
            Set
                Me.billingsThisPeriodField = value
            End Set
        End Property
        
        Public Property BillingsThisYear() As String
            Get
                Return Me.billingsThisYearField
            End Get
            Set
                Me.billingsThisYearField = value
            End Set
        End Property
        
        Public Property BillingsPriorYears() As String
            Get
                Return Me.billingsPriorYearsField
            End Get
            Set
                Me.billingsPriorYearsField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisPeriod() As String
            Get
                Return Me.costOfSalesThisPeriodField
            End Get
            Set
                Me.costOfSalesThisPeriodField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisYear() As String
            Get
                Return Me.costOfSalesThisYearField
            End Get
            Set
                Me.costOfSalesThisYearField = value
            End Set
        End Property
        
        Public Property CostOfSalesPriorYears() As String
            Get
                Return Me.costOfSalesPriorYearsField
            End Get
            Set
                Me.costOfSalesPriorYearsField = value
            End Set
        End Property
        
        Public Property OriginalExpectedMaterial() As String
            Get
                Return Me.originalExpectedMaterialField
            End Get
            Set
                Me.originalExpectedMaterialField = value
            End Set
        End Property
        
        Public Property OriginalExpectedLabor() As String
            Get
                Return Me.originalExpectedLaborField
            End Get
            Set
                Me.originalExpectedLaborField = value
            End Set
        End Property
        
        Public Property OriginalExpectedSubcontract() As String
            Get
                Return Me.originalExpectedSubcontractField
            End Get
            Set
                Me.originalExpectedSubcontractField = value
            End Set
        End Property
        
        Public Property CommittedMaterialPurchaseOrders() As String
            Get
                Return Me.committedMaterialPurchaseOrdersField
            End Get
            Set
                Me.committedMaterialPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedSubContractPurchaseOrders() As String
            Get
                Return Me.committedSubContractPurchaseOrdersField
            End Get
            Set
                Me.committedSubContractPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedMaterial() As String
            Get
                Return Me.committedMaterialField
            End Get
            Set
                Me.committedMaterialField = value
            End Set
        End Property
        
        Public Property CommittedLabor() As String
            Get
                Return Me.committedLaborField
            End Get
            Set
                Me.committedLaborField = value
            End Set
        End Property
        
        Public Property CommittedSubContract() As String
            Get
                Return Me.committedSubContractField
            End Get
            Set
                Me.committedSubContractField = value
            End Set
        End Property
        
        Public Property UncommittedMaterial() As String
            Get
                Return Me.uncommittedMaterialField
            End Get
            Set
                Me.uncommittedMaterialField = value
            End Set
        End Property
        
        Public Property UncommittedLabor() As String
            Get
                Return Me.uncommittedLaborField
            End Get
            Set
                Me.uncommittedLaborField = value
            End Set
        End Property
        
        Public Property UncommittedSubContract() As String
            Get
                Return Me.uncommittedSubContractField
            End Get
            Set
                Me.uncommittedSubContractField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsJobValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lowerLevelsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesRevenueOriginalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedSubcontractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedSubContractField As String
        
        Public Property LowerLevels() As String
            Get
                Return Me.lowerLevelsField
            End Get
            Set
                Me.lowerLevelsField = value
            End Set
        End Property
        
        Public Property SalesRevenueOriginal() As String
            Get
                Return Me.salesRevenueOriginalField
            End Get
            Set
                Me.salesRevenueOriginalField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisPeriod() As String
            Get
                Return Me.salesAdjustmentsThisPeriodField
            End Get
            Set
                Me.salesAdjustmentsThisPeriodField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisYear() As String
            Get
                Return Me.salesAdjustmentsThisYearField
            End Get
            Set
                Me.salesAdjustmentsThisYearField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsPriorYears() As String
            Get
                Return Me.salesAdjustmentsPriorYearsField
            End Get
            Set
                Me.salesAdjustmentsPriorYearsField = value
            End Set
        End Property
        
        Public Property BillingsThisPeriod() As String
            Get
                Return Me.billingsThisPeriodField
            End Get
            Set
                Me.billingsThisPeriodField = value
            End Set
        End Property
        
        Public Property BillingsThisYear() As String
            Get
                Return Me.billingsThisYearField
            End Get
            Set
                Me.billingsThisYearField = value
            End Set
        End Property
        
        Public Property BillingsPriorYears() As String
            Get
                Return Me.billingsPriorYearsField
            End Get
            Set
                Me.billingsPriorYearsField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisPeriod() As String
            Get
                Return Me.costOfSalesThisPeriodField
            End Get
            Set
                Me.costOfSalesThisPeriodField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisYear() As String
            Get
                Return Me.costOfSalesThisYearField
            End Get
            Set
                Me.costOfSalesThisYearField = value
            End Set
        End Property
        
        Public Property CostOfSalesPriorYears() As String
            Get
                Return Me.costOfSalesPriorYearsField
            End Get
            Set
                Me.costOfSalesPriorYearsField = value
            End Set
        End Property
        
        Public Property OriginalExpectedMaterial() As String
            Get
                Return Me.originalExpectedMaterialField
            End Get
            Set
                Me.originalExpectedMaterialField = value
            End Set
        End Property
        
        Public Property OriginalExpectedLabor() As String
            Get
                Return Me.originalExpectedLaborField
            End Get
            Set
                Me.originalExpectedLaborField = value
            End Set
        End Property
        
        Public Property OriginalExpectedSubcontract() As String
            Get
                Return Me.originalExpectedSubcontractField
            End Get
            Set
                Me.originalExpectedSubcontractField = value
            End Set
        End Property
        
        Public Property CommittedMaterialPurchaseOrders() As String
            Get
                Return Me.committedMaterialPurchaseOrdersField
            End Get
            Set
                Me.committedMaterialPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedSubContractPurchaseOrders() As String
            Get
                Return Me.committedSubContractPurchaseOrdersField
            End Get
            Set
                Me.committedSubContractPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedMaterial() As String
            Get
                Return Me.committedMaterialField
            End Get
            Set
                Me.committedMaterialField = value
            End Set
        End Property
        
        Public Property CommittedLabor() As String
            Get
                Return Me.committedLaborField
            End Get
            Set
                Me.committedLaborField = value
            End Set
        End Property
        
        Public Property CommittedSubContract() As String
            Get
                Return Me.committedSubContractField
            End Get
            Set
                Me.committedSubContractField = value
            End Set
        End Property
        
        Public Property UncommittedMaterial() As String
            Get
                Return Me.uncommittedMaterialField
            End Get
            Set
                Me.uncommittedMaterialField = value
            End Set
        End Property
        
        Public Property UncommittedLabor() As String
            Get
                Return Me.uncommittedLaborField
            End Get
            Set
                Me.uncommittedLaborField = value
            End Set
        End Property
        
        Public Property UncommittedSubContract() As String
            Get
                Return Me.uncommittedSubContractField
            End Get
            Set
                Me.uncommittedSubContractField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsSalesAndAdjustmentsDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entrySourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePostedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonMerDescriptionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalSalesValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodToDateAdjustField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearToDateAdjustField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private previousYearAdjustField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineShipDateField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property EntrySource() As String
            Get
                Return Me.entrySourceField
            End Get
            Set
                Me.entrySourceField = value
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
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property Entry() As String
            Get
                Return Me.entryField
            End Get
            Set
                Me.entryField = value
            End Set
        End Property
        
        Public Property SalesOrderLineType() As String
            Get
                Return Me.salesOrderLineTypeField
            End Get
            Set
                Me.salesOrderLineTypeField = value
            End Set
        End Property
        
        Public Property DatePosted() As String
            Get
                Return Me.datePostedField
            End Get
            Set
                Me.datePostedField = value
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
        
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        Public Property NonMerDescription() As Object
            Get
                Return Me.nonMerDescriptionField
            End Get
            Set
                Me.nonMerDescriptionField = value
            End Set
        End Property
        
        Public Property OriginalSalesValue() As String
            Get
                Return Me.originalSalesValueField
            End Get
            Set
                Me.originalSalesValueField = value
            End Set
        End Property
        
        Public Property PeriodToDateAdjust() As String
            Get
                Return Me.periodToDateAdjustField
            End Get
            Set
                Me.periodToDateAdjustField = value
            End Set
        End Property
        
        Public Property YearToDateAdjust() As String
            Get
                Return Me.yearToDateAdjustField
            End Get
            Set
                Me.yearToDateAdjustField = value
            End Set
        End Property
        
        Public Property PreviousYearAdjust() As String
            Get
                Return Me.previousYearAdjustField
            End Get
            Set
                Me.previousYearAdjustField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property LineShipDate() As String
            Get
                Return Me.lineShipDateField
            End Get
            Set
                Me.lineShipDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsUnCommittedLaborDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private machineField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setupTimeRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startupTimeRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runTimeRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private teardownTimeRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueRequiredField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCenter() As String
            Get
                Return Me.workCenterField
            End Get
            Set
                Me.workCenterField = value
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
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
            End Set
        End Property
        
        Public Property Machine() As Object
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
        
        Public Property SetupTimeRequired() As String
            Get
                Return Me.setupTimeRequiredField
            End Get
            Set
                Me.setupTimeRequiredField = value
            End Set
        End Property
        
        Public Property StartupTimeRequired() As String
            Get
                Return Me.startupTimeRequiredField
            End Get
            Set
                Me.startupTimeRequiredField = value
            End Set
        End Property
        
        Public Property RunTimeRequired() As String
            Get
                Return Me.runTimeRequiredField
            End Get
            Set
                Me.runTimeRequiredField = value
            End Set
        End Property
        
        Public Property TeardownTimeRequired() As String
            Get
                Return Me.teardownTimeRequiredField
            End Get
            Set
                Me.teardownTimeRequiredField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property ValueRequired() As String
            Get
                Return Me.valueRequiredField
            End Get
            Set
                Me.valueRequiredField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsUnCommittedMaterialDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revisionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityIssuedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costUnitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueRequiredField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
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
        
        Public Property Revision() As Object
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = value
            End Set
        End Property
        
        Public Property Release() As Object
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
            End Set
        End Property
        
        Public Property QuantityRequired() As String
            Get
                Return Me.quantityRequiredField
            End Get
            Set
                Me.quantityRequiredField = value
            End Set
        End Property
        
        Public Property QuantityIssued() As String
            Get
                Return Me.quantityIssuedField
            End Get
            Set
                Me.quantityIssuedField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
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
        
        Public Property CostUnitOfMeasure() As String
            Get
                Return Me.costUnitOfMeasureField
            End Get
            Set
                Me.costUnitOfMeasureField = value
            End Set
        End Property
        
        Public Property ValueRequired() As String
            Get
                Return Me.valueRequiredField
            End Get
            Set
                Me.valueRequiredField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryJobDetailsUnCommittedSubContractDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueRequiredField As String
        
        Public Property Hierarchy() As String
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
        
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        Public Property WorkCenter() As String
            Get
                Return Me.workCenterField
            End Get
            Set
                Me.workCenterField = value
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
        
        Public Property SubJob() As Object
            Get
                Return Me.subJobField
            End Get
            Set
                Me.subJobField = value
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
        
        Public Property ValueRequired() As String
            Get
                Return Me.valueRequiredField
            End Get
            Set
                Me.valueRequiredField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType
        
        '''<remarks/>
        ActCompletionDate
        
        '''<remarks/>
        BillingAndCostOfSalesDetails
        
        '''<remarks/>
        CommittedLaborDetails
        
        '''<remarks/>
        CommittedMaterialDetails
        
        '''<remarks/>
        CommittedPurchaseOrderDetails
        
        '''<remarks/>
        CommittedSubContractDetails
        
        '''<remarks/>
        CompleteFlag
        
        '''<remarks/>
        ConfirmedFlag
        
        '''<remarks/>
        Customer
        
        '''<remarks/>
        CustomerName
        
        '''<remarks/>
        HierarchyDetails
        
        '''<remarks/>
        HoldFlag
        
        '''<remarks/>
        Image
        
        '''<remarks/>
        Job
        
        '''<remarks/>
        JobClassification
        
        '''<remarks/>
        JobDeliveryDate
        
        '''<remarks/>
        JobDescription
        
        '''<remarks/>
        JobStartDate
        
        '''<remarks/>
        JobValues
        
        '''<remarks/>
        MasterJob
        
        '''<remarks/>
        QtyManufactured
        
        '''<remarks/>
        QtyToMake
        
        '''<remarks/>
        SalesAndAdjustmentsDetails
        
        '''<remarks/>
        SalesOrder
        
        '''<remarks/>
        SalesOrderLine
        
        '''<remarks/>
        StockCode
        
        '''<remarks/>
        StockDescription
        
        '''<remarks/>
        UnCommittedLaborDetails
        
        '''<remarks/>
        UnCommittedMaterialDetails
        
        '''<remarks/>
        UnCommittedSubContractDetails
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PrjQueryContractValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lowerLevelsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesRevenueOriginalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesAdjustmentsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingsPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesThisYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesPriorYearsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalExpectedSubcontractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractPurchaseOrdersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private committedSubContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedMaterialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedLaborField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uncommittedSubContractField As String
        
        Public Property LowerLevels() As String
            Get
                Return Me.lowerLevelsField
            End Get
            Set
                Me.lowerLevelsField = value
            End Set
        End Property
        
        Public Property SalesRevenueOriginal() As String
            Get
                Return Me.salesRevenueOriginalField
            End Get
            Set
                Me.salesRevenueOriginalField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisPeriod() As String
            Get
                Return Me.salesAdjustmentsThisPeriodField
            End Get
            Set
                Me.salesAdjustmentsThisPeriodField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsThisYear() As String
            Get
                Return Me.salesAdjustmentsThisYearField
            End Get
            Set
                Me.salesAdjustmentsThisYearField = value
            End Set
        End Property
        
        Public Property SalesAdjustmentsPriorYears() As String
            Get
                Return Me.salesAdjustmentsPriorYearsField
            End Get
            Set
                Me.salesAdjustmentsPriorYearsField = value
            End Set
        End Property
        
        Public Property BillingsThisPeriod() As String
            Get
                Return Me.billingsThisPeriodField
            End Get
            Set
                Me.billingsThisPeriodField = value
            End Set
        End Property
        
        Public Property BillingsThisYear() As String
            Get
                Return Me.billingsThisYearField
            End Get
            Set
                Me.billingsThisYearField = value
            End Set
        End Property
        
        Public Property BillingsPriorYears() As String
            Get
                Return Me.billingsPriorYearsField
            End Get
            Set
                Me.billingsPriorYearsField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisPeriod() As String
            Get
                Return Me.costOfSalesThisPeriodField
            End Get
            Set
                Me.costOfSalesThisPeriodField = value
            End Set
        End Property
        
        Public Property CostOfSalesThisYear() As String
            Get
                Return Me.costOfSalesThisYearField
            End Get
            Set
                Me.costOfSalesThisYearField = value
            End Set
        End Property
        
        Public Property CostOfSalesPriorYears() As String
            Get
                Return Me.costOfSalesPriorYearsField
            End Get
            Set
                Me.costOfSalesPriorYearsField = value
            End Set
        End Property
        
        Public Property OriginalExpectedMaterial() As String
            Get
                Return Me.originalExpectedMaterialField
            End Get
            Set
                Me.originalExpectedMaterialField = value
            End Set
        End Property
        
        Public Property OriginalExpectedLabor() As String
            Get
                Return Me.originalExpectedLaborField
            End Get
            Set
                Me.originalExpectedLaborField = value
            End Set
        End Property
        
        Public Property OriginalExpectedSubcontract() As String
            Get
                Return Me.originalExpectedSubcontractField
            End Get
            Set
                Me.originalExpectedSubcontractField = value
            End Set
        End Property
        
        Public Property CommittedMaterialPurchaseOrders() As String
            Get
                Return Me.committedMaterialPurchaseOrdersField
            End Get
            Set
                Me.committedMaterialPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedSubContractPurchaseOrders() As String
            Get
                Return Me.committedSubContractPurchaseOrdersField
            End Get
            Set
                Me.committedSubContractPurchaseOrdersField = value
            End Set
        End Property
        
        Public Property CommittedMaterial() As String
            Get
                Return Me.committedMaterialField
            End Get
            Set
                Me.committedMaterialField = value
            End Set
        End Property
        
        Public Property CommittedLabor() As String
            Get
                Return Me.committedLaborField
            End Get
            Set
                Me.committedLaborField = value
            End Set
        End Property
        
        Public Property CommittedSubContract() As String
            Get
                Return Me.committedSubContractField
            End Get
            Set
                Me.committedSubContractField = value
            End Set
        End Property
        
        Public Property UncommittedMaterial() As String
            Get
                Return Me.uncommittedMaterialField
            End Get
            Set
                Me.uncommittedMaterialField = value
            End Set
        End Property
        
        Public Property UncommittedLabor() As String
            Get
                Return Me.uncommittedLaborField
            End Get
            Set
                Me.uncommittedLaborField = value
            End Set
        End Property
        
        Public Property UncommittedSubContract() As String
            Get
                Return Me.uncommittedSubContractField
            End Get
            Set
                Me.uncommittedSubContractField = value
            End Set
        End Property
    End Class
End Namespace
