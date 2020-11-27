Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryQuery.WipQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class WipQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As WipQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobHeaderField As WipQueryJobHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialAllocField As List(Of WipQueryMaterialAlloc)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialPostingField As List(Of WipQueryMaterialPosting)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labourAllocField As List(Of WipQueryLabourAlloc)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labourIssueField As List(Of WipQueryLabourIssue)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partBookingField As List(Of WipQueryPartBooking)
        
        Public Sub New()
            MyBase.New
            If (Me.partBookingField Is Nothing) Then
                Me.partBookingField = New List(Of WipQueryPartBooking)
            End If
            If (Me.labourIssueField Is Nothing) Then
                Me.labourIssueField = New List(Of WipQueryLabourIssue)
            End If
            If (Me.labourAllocField Is Nothing) Then
                Me.labourAllocField = New List(Of WipQueryLabourAlloc)
            End If
            If (Me.materialPostingField Is Nothing) Then
                Me.materialPostingField = New List(Of WipQueryMaterialPosting)
            End If
            If (Me.materialAllocField Is Nothing) Then
                Me.materialAllocField = New List(Of WipQueryMaterialAlloc)
            End If
            If (Me.jobHeaderField Is Nothing) Then
                Me.jobHeaderField = New WipQueryJobHeader
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New WipQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As WipQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property JobHeader() As WipQueryJobHeader
            Get
                Return Me.jobHeaderField
            End Get
            Set
                Me.jobHeaderField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MaterialAlloc")>  _
        Public Property MaterialAllocCollection() As List(Of WipQueryMaterialAlloc)
            Get
                Return Me.materialAllocField
            End Get
            Set
                Me.materialAllocField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MaterialPosting")>  _
        Public Property MaterialPostingCollection() As List(Of WipQueryMaterialPosting)
            Get
                Return Me.materialPostingField
            End Get
            Set
                Me.materialPostingField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("LabourAlloc")>  _
        Public Property LabourAllocCollection() As List(Of WipQueryLabourAlloc)
            Get
                Return Me.labourAllocField
            End Get
            Set
                Me.labourAllocField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("LabourIssue")>  _
        Public Property LabourIssueCollection() As List(Of WipQueryLabourIssue)
            Get
                Return Me.labourIssueField
            End Get
            Set
                Me.labourIssueField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("PartBooking")>  _
        Public Property PartBookingCollection() As List(Of WipQueryPartBooking)
            Get
                Return Me.partBookingField
            End Get
            Set
                Me.partBookingField = value
            End Set
        End Property


        Public Shared Function CreateFromXMLOut(ByVal strXMLOut As String) As WipQuery
            Using stream As New IO.StringReader(strXMLOut)

                Dim s As New System.Xml.Serialization.XmlSerializer(GetType(WipQuery))

                Dim qry As WipQuery = s.Deserialize(stream)

                Return qry
            End Using
        End Function

    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQuerySystemInformation

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cssStyleField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private languageField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private decFormatField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateFormatField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private roleField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private versionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private companyIdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private companyNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operatorCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operatorNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operatorGroupField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operatorEmailAddressField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operatorLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reportDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private useSeparatorOnReportsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private separatorToUseField As String

        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set(ByVal value As String)
                Me.cssStyleField = Value
            End Set
        End Property

        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As String)
                Me.languageField = Value
            End Set
        End Property

        Public Property DecFormat() As String
            Get
                Return Me.decFormatField
            End Get
            Set(ByVal value As String)
                Me.decFormatField = Value
            End Set
        End Property

        Public Property DateFormat() As String
            Get
                Return Me.dateFormatField
            End Get
            Set(ByVal value As String)
                Me.dateFormatField = Value
            End Set
        End Property

        Public Property Role() As String
            Get
                Return Me.roleField
            End Get
            Set(ByVal value As String)
                Me.roleField = Value
            End Set
        End Property

        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set(ByVal value As String)
                Me.versionField = Value
            End Set
        End Property

        Public Property CompanyId() As String
            Get
                Return Me.companyIdField
            End Get
            Set(ByVal value As String)
                Me.companyIdField = Value
            End Set
        End Property

        Public Property CompanyName() As String
            Get
                Return Me.companyNameField
            End Get
            Set(ByVal value As String)
                Me.companyNameField = Value
            End Set
        End Property

        Public Property OperatorCode() As String
            Get
                Return Me.operatorCodeField
            End Get
            Set(ByVal value As String)
                Me.operatorCodeField = Value
            End Set
        End Property

        Public Property OperatorName() As String
            Get
                Return Me.operatorNameField
            End Get
            Set(ByVal value As String)
                Me.operatorNameField = Value
            End Set
        End Property

        Public Property OperatorGroup() As String
            Get
                Return Me.operatorGroupField
            End Get
            Set(ByVal value As String)
                Me.operatorGroupField = Value
            End Set
        End Property

        Public Property OperatorEmailAddress() As String
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set(ByVal value As String)
                Me.operatorEmailAddressField = Value
            End Set
        End Property

        Public Property OperatorLocation() As String
            Get
                Return Me.operatorLocationField
            End Get
            Set(ByVal value As String)
                Me.operatorLocationField = Value
            End Set
        End Property

        Public Property ReportDate() As String
            Get
                Return Me.reportDateField
            End Get
            Set(ByVal value As String)
                Me.reportDateField = Value
            End Set
        End Property

        Public Property UseSeparatorOnReports() As String
            Get
                Return Me.useSeparatorOnReportsField
            End Get
            Set(ByVal value As String)
                Me.useSeparatorOnReportsField = Value
            End Set
        End Property

        Public Property SeparatorToUse() As String
            Get
                Return Me.separatorToUseField
            End Get
            Set(ByVal value As String)
                Me.separatorToUseField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryJobHeader

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobClassificationField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private classDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private masterJobField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private priorityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private longDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerNameField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobTenderDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobDeliveryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobStartDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private actCompleteDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private completeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private seqCheckReqField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateCalcMethodField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private expLabourField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private expMaterialField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyToMakeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyManufacturedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private sourceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private estSourceNumField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nextDetailLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private pctCompleteFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prtFactDoc1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prtFactDoc2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prtFactDoc3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prtFactDoc4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private sellingPriceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addLabPctField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addMatPctField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private profitPctField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private materialBilledField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labourBilledField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nextOpForAllField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private highestOpPostedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private totalQtyScrappedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private confirmedFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private holdFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobCreatedStrucField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lstOrderCreatedField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private traceableTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nxtLinePartBookField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private routeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private descriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private wipCtlGlCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private decimalsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matCostToDate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labCostToDate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hrsBookToDate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matValueIssues1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labValueIssues1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matCostToDate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labCostToDate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hrsBookToDate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matValueIssues2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labValueIssues2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matCostToDate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labCostToDate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hrsBookToDate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private matValueIssues3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labValueIssues3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateJobLstUpdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timeJobLstUpdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyFlagField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nextLineHierField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ordEntSourceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private versionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private releaseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private issuesFromWIPField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private wIPValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private expectedMaterialCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private expectedOperationCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private totalOpsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customFormField As String

        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set(ByVal value As String)
                Me.jobField = Value
            End Set
        End Property

        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set(ByVal value As String)
                Me.jobDescriptionField = Value
            End Set
        End Property

        Public Property JobClassification() As Object
            Get
                Return Me.jobClassificationField
            End Get
            Set(ByVal value As Object)
                Me.jobClassificationField = Value
            End Set
        End Property

        Public Property ClassDescription() As String
            Get
                Return Me.classDescriptionField
            End Get
            Set(ByVal value As String)
                Me.classDescriptionField = Value
            End Set
        End Property

        Public Property JobType() As String
            Get
                Return Me.jobTypeField
            End Get
            Set(ByVal value As String)
                Me.jobTypeField = Value
            End Set
        End Property

        Public Property MasterJob() As Object
            Get
                Return Me.masterJobField
            End Get
            Set(ByVal value As Object)
                Me.masterJobField = Value
            End Set
        End Property

        Public Property Priority() As String
            Get
                Return Me.priorityField
            End Get
            Set(ByVal value As String)
                Me.priorityField = Value
            End Set
        End Property

        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set(ByVal value As String)
                Me.stockCodeField = Value
            End Set
        End Property

        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set(ByVal value As String)
                Me.stockDescriptionField = Value
            End Set
        End Property

        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set(ByVal value As String)
                Me.longDescField = Value
            End Set
        End Property

        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set(ByVal value As String)
                Me.warehouseField = Value
            End Set
        End Property

        Public Property Customer() As Object
            Get
                Return Me.customerField
            End Get
            Set(ByVal value As Object)
                Me.customerField = Value
            End Set
        End Property

        Public Property CustomerName() As Object
            Get
                Return Me.customerNameField
            End Get
            Set(ByVal value As Object)
                Me.customerNameField = Value
            End Set
        End Property

        Public Property JobTenderDate() As String
            Get
                Return Me.jobTenderDateField
            End Get
            Set(ByVal value As String)
                Me.jobTenderDateField = Value
            End Set
        End Property

        Public Property JobDeliveryDate() As String
            Get
                Return Me.jobDeliveryDateField
            End Get
            Set(ByVal value As String)
                Me.jobDeliveryDateField = Value
            End Set
        End Property

        Public Property JobStartDate() As String
            Get
                Return Me.jobStartDateField
            End Get
            Set(ByVal value As String)
                Me.jobStartDateField = Value
            End Set
        End Property

        Public Property ActCompleteDate() As String
            Get
                Return Me.actCompleteDateField
            End Get
            Set(ByVal value As String)
                Me.actCompleteDateField = Value
            End Set
        End Property

        Public Property Complete() As String
            Get
                Return Me.completeField
            End Get
            Set(ByVal value As String)
                Me.completeField = Value
            End Set
        End Property

        Public Property SeqCheckReq() As String
            Get
                Return Me.seqCheckReqField
            End Get
            Set(ByVal value As String)
                Me.seqCheckReqField = Value
            End Set
        End Property

        Public Property DateCalcMethod() As String
            Get
                Return Me.dateCalcMethodField
            End Get
            Set(ByVal value As String)
                Me.dateCalcMethodField = Value
            End Set
        End Property

        Public Property ExpLabour() As String
            Get
                Return Me.expLabourField
            End Get
            Set(ByVal value As String)
                Me.expLabourField = Value
            End Set
        End Property

        Public Property ExpMaterial() As String
            Get
                Return Me.expMaterialField
            End Get
            Set(ByVal value As String)
                Me.expMaterialField = Value
            End Set
        End Property

        Public Property QtyToMake() As String
            Get
                Return Me.qtyToMakeField
            End Get
            Set(ByVal value As String)
                Me.qtyToMakeField = Value
            End Set
        End Property

        Public Property QtyManufactured() As String
            Get
                Return Me.qtyManufacturedField
            End Get
            Set(ByVal value As String)
                Me.qtyManufacturedField = Value
            End Set
        End Property

        Public Property Source() As String
            Get
                Return Me.sourceField
            End Get
            Set(ByVal value As String)
                Me.sourceField = Value
            End Set
        End Property

        Public Property EstSourceNum() As Object
            Get
                Return Me.estSourceNumField
            End Get
            Set(ByVal value As Object)
                Me.estSourceNumField = Value
            End Set
        End Property

        Public Property NextDetailLine() As String
            Get
                Return Me.nextDetailLineField
            End Get
            Set(ByVal value As String)
                Me.nextDetailLineField = Value
            End Set
        End Property

        Public Property PctCompleteFlag() As String
            Get
                Return Me.pctCompleteFlagField
            End Get
            Set(ByVal value As String)
                Me.pctCompleteFlagField = Value
            End Set
        End Property

        Public Property PrtFactDoc1() As String
            Get
                Return Me.prtFactDoc1Field
            End Get
            Set(ByVal value As String)
                Me.prtFactDoc1Field = Value
            End Set
        End Property

        Public Property PrtFactDoc2() As String
            Get
                Return Me.prtFactDoc2Field
            End Get
            Set(ByVal value As String)
                Me.prtFactDoc2Field = Value
            End Set
        End Property

        Public Property PrtFactDoc3() As String
            Get
                Return Me.prtFactDoc3Field
            End Get
            Set(ByVal value As String)
                Me.prtFactDoc3Field = Value
            End Set
        End Property

        Public Property PrtFactDoc4() As String
            Get
                Return Me.prtFactDoc4Field
            End Get
            Set(ByVal value As String)
                Me.prtFactDoc4Field = Value
            End Set
        End Property

        Public Property SellingPrice() As String
            Get
                Return Me.sellingPriceField
            End Get
            Set(ByVal value As String)
                Me.sellingPriceField = Value
            End Set
        End Property

        Public Property AddLabPct() As String
            Get
                Return Me.addLabPctField
            End Get
            Set(ByVal value As String)
                Me.addLabPctField = Value
            End Set
        End Property

        Public Property AddMatPct() As String
            Get
                Return Me.addMatPctField
            End Get
            Set(ByVal value As String)
                Me.addMatPctField = Value
            End Set
        End Property

        Public Property ProfitPct() As String
            Get
                Return Me.profitPctField
            End Get
            Set(ByVal value As String)
                Me.profitPctField = Value
            End Set
        End Property

        Public Property SalesOrder() As Object
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As Object)
                Me.salesOrderField = Value
            End Set
        End Property

        Public Property MaterialBilled() As String
            Get
                Return Me.materialBilledField
            End Get
            Set(ByVal value As String)
                Me.materialBilledField = Value
            End Set
        End Property

        Public Property LabourBilled() As String
            Get
                Return Me.labourBilledField
            End Get
            Set(ByVal value As String)
                Me.labourBilledField = Value
            End Set
        End Property

        Public Property NextOpForAll() As String
            Get
                Return Me.nextOpForAllField
            End Get
            Set(ByVal value As String)
                Me.nextOpForAllField = Value
            End Set
        End Property

        Public Property HighestOpPosted() As String
            Get
                Return Me.highestOpPostedField
            End Get
            Set(ByVal value As String)
                Me.highestOpPostedField = Value
            End Set
        End Property

        Public Property TotalQtyScrapped() As String
            Get
                Return Me.totalQtyScrappedField
            End Get
            Set(ByVal value As String)
                Me.totalQtyScrappedField = Value
            End Set
        End Property

        Public Property ConfirmedFlag() As String
            Get
                Return Me.confirmedFlagField
            End Get
            Set(ByVal value As String)
                Me.confirmedFlagField = Value
            End Set
        End Property

        Public Property HoldFlag() As String
            Get
                Return Me.holdFlagField
            End Get
            Set(ByVal value As String)
                Me.holdFlagField = Value
            End Set
        End Property

        Public Property JobCreatedStruc() As String
            Get
                Return Me.jobCreatedStrucField
            End Get
            Set(ByVal value As String)
                Me.jobCreatedStrucField = Value
            End Set
        End Property

        Public Property LstOrderCreated() As Object
            Get
                Return Me.lstOrderCreatedField
            End Get
            Set(ByVal value As Object)
                Me.lstOrderCreatedField = Value
            End Set
        End Property

        Public Property TraceableType() As String
            Get
                Return Me.traceableTypeField
            End Get
            Set(ByVal value As String)
                Me.traceableTypeField = Value
            End Set
        End Property

        Public Property NxtLinePartBook() As String
            Get
                Return Me.nxtLinePartBookField
            End Get
            Set(ByVal value As String)
                Me.nxtLinePartBookField = Value
            End Set
        End Property

        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set(ByVal value As String)
                Me.routeField = Value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set(ByVal value As String)
                Me.descriptionField = Value
            End Set
        End Property

        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set(ByVal value As String)
                Me.wipCtlGlCodeField = Value
            End Set
        End Property

        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set(ByVal value As String)
                Me.decimalsField = Value
            End Set
        End Property

        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set(ByVal value As String)
                Me.salesOrderLineField = Value
            End Set
        End Property

        Public Property MatCostToDate1() As String
            Get
                Return Me.matCostToDate1Field
            End Get
            Set(ByVal value As String)
                Me.matCostToDate1Field = Value
            End Set
        End Property

        Public Property LabCostToDate1() As String
            Get
                Return Me.labCostToDate1Field
            End Get
            Set(ByVal value As String)
                Me.labCostToDate1Field = Value
            End Set
        End Property

        Public Property HrsBookToDate1() As String
            Get
                Return Me.hrsBookToDate1Field
            End Get
            Set(ByVal value As String)
                Me.hrsBookToDate1Field = Value
            End Set
        End Property

        Public Property MatValueIssues1() As String
            Get
                Return Me.matValueIssues1Field
            End Get
            Set(ByVal value As String)
                Me.matValueIssues1Field = Value
            End Set
        End Property

        Public Property LabValueIssues1() As String
            Get
                Return Me.labValueIssues1Field
            End Get
            Set(ByVal value As String)
                Me.labValueIssues1Field = Value
            End Set
        End Property

        Public Property MatCostToDate2() As String
            Get
                Return Me.matCostToDate2Field
            End Get
            Set(ByVal value As String)
                Me.matCostToDate2Field = Value
            End Set
        End Property

        Public Property LabCostToDate2() As String
            Get
                Return Me.labCostToDate2Field
            End Get
            Set(ByVal value As String)
                Me.labCostToDate2Field = Value
            End Set
        End Property

        Public Property HrsBookToDate2() As String
            Get
                Return Me.hrsBookToDate2Field
            End Get
            Set(ByVal value As String)
                Me.hrsBookToDate2Field = Value
            End Set
        End Property

        Public Property MatValueIssues2() As String
            Get
                Return Me.matValueIssues2Field
            End Get
            Set(ByVal value As String)
                Me.matValueIssues2Field = Value
            End Set
        End Property

        Public Property LabValueIssues2() As String
            Get
                Return Me.labValueIssues2Field
            End Get
            Set(ByVal value As String)
                Me.labValueIssues2Field = Value
            End Set
        End Property

        Public Property MatCostToDate3() As String
            Get
                Return Me.matCostToDate3Field
            End Get
            Set(ByVal value As String)
                Me.matCostToDate3Field = Value
            End Set
        End Property

        Public Property LabCostToDate3() As String
            Get
                Return Me.labCostToDate3Field
            End Get
            Set(ByVal value As String)
                Me.labCostToDate3Field = Value
            End Set
        End Property

        Public Property HrsBookToDate3() As String
            Get
                Return Me.hrsBookToDate3Field
            End Get
            Set(ByVal value As String)
                Me.hrsBookToDate3Field = Value
            End Set
        End Property

        Public Property MatValueIssues3() As String
            Get
                Return Me.matValueIssues3Field
            End Get
            Set(ByVal value As String)
                Me.matValueIssues3Field = Value
            End Set
        End Property

        Public Property LabValueIssues3() As String
            Get
                Return Me.labValueIssues3Field
            End Get
            Set(ByVal value As String)
                Me.labValueIssues3Field = Value
            End Set
        End Property

        Public Property DateJobLstUpd() As String
            Get
                Return Me.dateJobLstUpdField
            End Get
            Set(ByVal value As String)
                Me.dateJobLstUpdField = Value
            End Set
        End Property

        Public Property TimeJobLstUpd() As String
            Get
                Return Me.timeJobLstUpdField
            End Get
            Set(ByVal value As String)
                Me.timeJobLstUpdField = Value
            End Set
        End Property

        Public Property HierarchyFlag() As Object
            Get
                Return Me.hierarchyFlagField
            End Get
            Set(ByVal value As Object)
                Me.hierarchyFlagField = Value
            End Set
        End Property

        Public Property NextLineHier() As String
            Get
                Return Me.nextLineHierField
            End Get
            Set(ByVal value As String)
                Me.nextLineHierField = Value
            End Set
        End Property

        Public Property OrdEntSource() As String
            Get
                Return Me.ordEntSourceField
            End Get
            Set(ByVal value As String)
                Me.ordEntSourceField = Value
            End Set
        End Property

        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set(ByVal value As String)
                Me.versionField = Value
            End Set
        End Property

        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set(ByVal value As String)
                Me.releaseField = Value
            End Set
        End Property

        Public Property IssuesFromWIP() As String
            Get
                Return Me.issuesFromWIPField
            End Get
            Set(ByVal value As String)
                Me.issuesFromWIPField = Value
            End Set
        End Property

        Public Property WIPValue() As String
            Get
                Return Me.wIPValueField
            End Get
            Set(ByVal value As String)
                Me.wIPValueField = Value
            End Set
        End Property

        Public Property ExpectedMaterialCost() As String
            Get
                Return Me.expectedMaterialCostField
            End Get
            Set(ByVal value As String)
                Me.expectedMaterialCostField = Value
            End Set
        End Property

        Public Property ExpectedOperationCost() As String
            Get
                Return Me.expectedOperationCostField
            End Get
            Set(ByVal value As String)
                Me.expectedOperationCostField = Value
            End Set
        End Property

        Public Property TotalOps() As String
            Get
                Return Me.totalOpsField
            End Get
            Set(ByVal value As String)
                Me.totalOpsField = Value
            End Set
        End Property

        Public Property CustomForm() As String
            Get
                Return Me.customFormField
            End Get
            Set(ByVal value As String)
                Me.customFormField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryMaterialAlloc

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private longDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitQtyReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private totalQtyReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operationOffsetField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private opOffsetFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private uomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyBilledField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueBilledField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private decimalsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private allocCompletedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private sequenceNumField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phantomParentField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonConformFlagField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyCostUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costUomField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private bulkIssueItemField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private scrapPercentageField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private scrapQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private inclScrapOnDocField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dockToStockField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJob1Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJob2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJob3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJob4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJob5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private kitIssueItemField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private completedJobFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private versionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private releaseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subJobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconOpenField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconClosedField As String

        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set(ByVal value As String)
                Me.stockCodeField = Value
            End Set
        End Property

        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set(ByVal value As String)
                Me.warehouseField = Value
            End Set
        End Property

        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set(ByVal value As String)
                Me.lineField = Value
            End Set
        End Property

        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set(ByVal value As String)
                Me.stockDescriptionField = Value
            End Set
        End Property

        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set(ByVal value As String)
                Me.longDescField = Value
            End Set
        End Property

        Public Property UnitQtyReqd() As String
            Get
                Return Me.unitQtyReqdField
            End Get
            Set(ByVal value As String)
                Me.unitQtyReqdField = Value
            End Set
        End Property

        Public Property TotalQtyReqd() As String
            Get
                Return Me.totalQtyReqdField
            End Get
            Set(ByVal value As String)
                Me.totalQtyReqdField = Value
            End Set
        End Property

        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set(ByVal value As String)
                Me.unitCostField = Value
            End Set
        End Property

        Public Property OperationOffset() As String
            Get
                Return Me.operationOffsetField
            End Get
            Set(ByVal value As String)
                Me.operationOffsetField = Value
            End Set
        End Property

        Public Property OpOffsetFlag() As String
            Get
                Return Me.opOffsetFlagField
            End Get
            Set(ByVal value As String)
                Me.opOffsetFlagField = Value
            End Set
        End Property

        Public Property Uom() As String
            Get
                Return Me.uomField
            End Get
            Set(ByVal value As String)
                Me.uomField = Value
            End Set
        End Property

        Public Property Bin() As Object
            Get
                Return Me.binField
            End Get
            Set(ByVal value As Object)
                Me.binField = Value
            End Set
        End Property

        Public Property QtyIssued() As String
            Get
                Return Me.qtyIssuedField
            End Get
            Set(ByVal value As String)
                Me.qtyIssuedField = Value
            End Set
        End Property

        Public Property ValueReqd() As String
            Get
                Return Me.valueReqdField
            End Get
            Set(ByVal value As String)
                Me.valueReqdField = Value
            End Set
        End Property

        Public Property ValueIssued() As String
            Get
                Return Me.valueIssuedField
            End Get
            Set(ByVal value As String)
                Me.valueIssuedField = Value
            End Set
        End Property

        Public Property QtyBilled() As String
            Get
                Return Me.qtyBilledField
            End Get
            Set(ByVal value As String)
                Me.qtyBilledField = Value
            End Set
        End Property

        Public Property ValueBilled() As String
            Get
                Return Me.valueBilledField
            End Get
            Set(ByVal value As String)
                Me.valueBilledField = Value
            End Set
        End Property

        Public Property Decimals() As String
            Get
                Return Me.decimalsField
            End Get
            Set(ByVal value As String)
                Me.decimalsField = Value
            End Set
        End Property

        Public Property AllocCompleted() As String
            Get
                Return Me.allocCompletedField
            End Get
            Set(ByVal value As String)
                Me.allocCompletedField = Value
            End Set
        End Property

        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set(ByVal value As String)
                Me.sequenceNumField = Value
            End Set
        End Property

        Public Property PhantomParent() As Object
            Get
                Return Me.phantomParentField
            End Get
            Set(ByVal value As Object)
                Me.phantomParentField = Value
            End Set
        End Property

        Public Property NonConformFlag() As Object
            Get
                Return Me.nonConformFlagField
            End Get
            Set(ByVal value As Object)
                Me.nonConformFlagField = Value
            End Set
        End Property

        Public Property ApplyCostUom() As String
            Get
                Return Me.applyCostUomField
            End Get
            Set(ByVal value As String)
                Me.applyCostUomField = Value
            End Set
        End Property

        Public Property CostUom() As Object
            Get
                Return Me.costUomField
            End Get
            Set(ByVal value As Object)
                Me.costUomField = Value
            End Set
        End Property

        Public Property BulkIssueItem() As String
            Get
                Return Me.bulkIssueItemField
            End Get
            Set(ByVal value As String)
                Me.bulkIssueItemField = Value
            End Set
        End Property

        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set(ByVal value As String)
                Me.scrapPercentageField = Value
            End Set
        End Property

        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set(ByVal value As String)
                Me.scrapQuantityField = Value
            End Set
        End Property

        Public Property InclScrapOnDoc() As String
            Get
                Return Me.inclScrapOnDocField
            End Get
            Set(ByVal value As String)
                Me.inclScrapOnDocField = Value
            End Set
        End Property

        Public Property DockToStock() As String
            Get
                Return Me.dockToStockField
            End Get
            Set(ByVal value As String)
                Me.dockToStockField = Value
            End Set
        End Property

        Public Property HierarchyJob1() As Object
            Get
                Return Me.hierarchyJob1Field
            End Get
            Set(ByVal value As Object)
                Me.hierarchyJob1Field = Value
            End Set
        End Property

        Public Property HierarchyJob2() As String
            Get
                Return Me.hierarchyJob2Field
            End Get
            Set(ByVal value As String)
                Me.hierarchyJob2Field = Value
            End Set
        End Property

        Public Property HierarchyJob3() As String
            Get
                Return Me.hierarchyJob3Field
            End Get
            Set(ByVal value As String)
                Me.hierarchyJob3Field = Value
            End Set
        End Property

        Public Property HierarchyJob4() As String
            Get
                Return Me.hierarchyJob4Field
            End Get
            Set(ByVal value As String)
                Me.hierarchyJob4Field = Value
            End Set
        End Property

        Public Property HierarchyJob5() As String
            Get
                Return Me.hierarchyJob5Field
            End Get
            Set(ByVal value As String)
                Me.hierarchyJob5Field = Value
            End Set
        End Property

        Public Property KitIssueItem() As String
            Get
                Return Me.kitIssueItemField
            End Get
            Set(ByVal value As String)
                Me.kitIssueItemField = Value
            End Set
        End Property

        Public Property CompletedJobFlag() As String
            Get
                Return Me.completedJobFlagField
            End Get
            Set(ByVal value As String)
                Me.completedJobFlagField = Value
            End Set
        End Property

        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set(ByVal value As String)
                Me.versionField = Value
            End Set
        End Property

        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set(ByVal value As String)
                Me.releaseField = Value
            End Set
        End Property

        Public Property SubJob() As String
            Get
                Return Me.subJobField
            End Get
            Set(ByVal value As String)
                Me.subJobField = Value
            End Set
        End Property

        Public Property DateReqd() As String
            Get
                Return Me.dateReqdField
            End Get
            Set(ByVal value As String)
                Me.dateReqdField = Value
            End Set
        End Property

        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set(ByVal value As String)
                Me.iconOpenField = Value
            End Set
        End Property

        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set(ByVal value As String)
                Me.iconClosedField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryMaterialPosting

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mStockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private longDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mQtyIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mWarehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mProductClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mUnitCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mAddReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mLotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mConcessionNumField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mVersionNumField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mReleaseLevelField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mApplyCostUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mCostUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mPurchaseOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mBulkIssueItemField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mPurchaseOrdLinField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mAllocationLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mDecimalsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private mSubJobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchy1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchy2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchy3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchy4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchy5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postYearField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postMonthField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconOpenField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconClosedField As String

        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set(ByVal value As String)
                Me.lineField = Value
            End Set
        End Property

        Public Property TrnType() As String
            Get
                Return Me.trnTypeField
            End Get
            Set(ByVal value As String)
                Me.trnTypeField = Value
            End Set
        End Property

        Public Property MStockCode() As String
            Get
                Return Me.mStockCodeField
            End Get
            Set(ByVal value As String)
                Me.mStockCodeField = Value
            End Set
        End Property

        Public Property MDescription() As String
            Get
                Return Me.mDescriptionField
            End Get
            Set(ByVal value As String)
                Me.mDescriptionField = Value
            End Set
        End Property

        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set(ByVal value As String)
                Me.longDescField = Value
            End Set
        End Property

        Public Property MQtyIssued() As String
            Get
                Return Me.mQtyIssuedField
            End Get
            Set(ByVal value As String)
                Me.mQtyIssuedField = Value
            End Set
        End Property

        Public Property MUom() As String
            Get
                Return Me.mUomField
            End Get
            Set(ByVal value As String)
                Me.mUomField = Value
            End Set
        End Property

        Public Property MWarehouse() As String
            Get
                Return Me.mWarehouseField
            End Get
            Set(ByVal value As String)
                Me.mWarehouseField = Value
            End Set
        End Property

        Public Property MProductClass() As String
            Get
                Return Me.mProductClassField
            End Get
            Set(ByVal value As String)
                Me.mProductClassField = Value
            End Set
        End Property

        Public Property MUnitCost() As String
            Get
                Return Me.mUnitCostField
            End Get
            Set(ByVal value As String)
                Me.mUnitCostField = Value
            End Set
        End Property

        Public Property MReference() As String
            Get
                Return Me.mReferenceField
            End Get
            Set(ByVal value As String)
                Me.mReferenceField = Value
            End Set
        End Property

        Public Property MAddReference() As String
            Get
                Return Me.mAddReferenceField
            End Get
            Set(ByVal value As String)
                Me.mAddReferenceField = Value
            End Set
        End Property

        Public Property MLot() As String
            Get
                Return Me.mLotField
            End Get
            Set(ByVal value As String)
                Me.mLotField = Value
            End Set
        End Property

        Public Property MConcessionNum() As String
            Get
                Return Me.mConcessionNumField
            End Get
            Set(ByVal value As String)
                Me.mConcessionNumField = Value
            End Set
        End Property

        Public Property MVersionNum() As String
            Get
                Return Me.mVersionNumField
            End Get
            Set(ByVal value As String)
                Me.mVersionNumField = Value
            End Set
        End Property

        Public Property MReleaseLevel() As String
            Get
                Return Me.mReleaseLevelField
            End Get
            Set(ByVal value As String)
                Me.mReleaseLevelField = Value
            End Set
        End Property

        Public Property MApplyCostUom() As String
            Get
                Return Me.mApplyCostUomField
            End Get
            Set(ByVal value As String)
                Me.mApplyCostUomField = Value
            End Set
        End Property

        Public Property MCostUom() As String
            Get
                Return Me.mCostUomField
            End Get
            Set(ByVal value As String)
                Me.mCostUomField = Value
            End Set
        End Property

        Public Property MPurchaseOrder() As String
            Get
                Return Me.mPurchaseOrderField
            End Get
            Set(ByVal value As String)
                Me.mPurchaseOrderField = Value
            End Set
        End Property

        Public Property MBulkIssueItem() As String
            Get
                Return Me.mBulkIssueItemField
            End Get
            Set(ByVal value As String)
                Me.mBulkIssueItemField = Value
            End Set
        End Property

        Public Property MPurchaseOrdLin() As String
            Get
                Return Me.mPurchaseOrdLinField
            End Get
            Set(ByVal value As String)
                Me.mPurchaseOrdLinField = Value
            End Set
        End Property

        Public Property MAllocationLine() As String
            Get
                Return Me.mAllocationLineField
            End Get
            Set(ByVal value As String)
                Me.mAllocationLineField = Value
            End Set
        End Property

        Public Property MDecimals() As String
            Get
                Return Me.mDecimalsField
            End Get
            Set(ByVal value As String)
                Me.mDecimalsField = Value
            End Set
        End Property

        Public Property MSubJob() As String
            Get
                Return Me.mSubJobField
            End Get
            Set(ByVal value As String)
                Me.mSubJobField = Value
            End Set
        End Property

        Public Property TrnValue() As String
            Get
                Return Me.trnValueField
            End Get
            Set(ByVal value As String)
                Me.trnValueField = Value
            End Set
        End Property

        Public Property TrnDate() As String
            Get
                Return Me.trnDateField
            End Get
            Set(ByVal value As String)
                Me.trnDateField = Value
            End Set
        End Property

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = Value
            End Set
        End Property

        Public Property Hierarchy1() As String
            Get
                Return Me.hierarchy1Field
            End Get
            Set(ByVal value As String)
                Me.hierarchy1Field = Value
            End Set
        End Property

        Public Property Hierarchy2() As String
            Get
                Return Me.hierarchy2Field
            End Get
            Set(ByVal value As String)
                Me.hierarchy2Field = Value
            End Set
        End Property

        Public Property Hierarchy3() As String
            Get
                Return Me.hierarchy3Field
            End Get
            Set(ByVal value As String)
                Me.hierarchy3Field = Value
            End Set
        End Property

        Public Property Hierarchy4() As String
            Get
                Return Me.hierarchy4Field
            End Get
            Set(ByVal value As String)
                Me.hierarchy4Field = Value
            End Set
        End Property

        Public Property Hierarchy5() As String
            Get
                Return Me.hierarchy5Field
            End Get
            Set(ByVal value As String)
                Me.hierarchy5Field = Value
            End Set
        End Property

        Public Property PostYear() As String
            Get
                Return Me.postYearField
            End Get
            Set(ByVal value As String)
                Me.postYearField = Value
            End Set
        End Property

        Public Property PostMonth() As String
            Get
                Return Me.postMonthField
            End Get
            Set(ByVal value As String)
                Me.postMonthField = Value
            End Set
        End Property

        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set(ByVal value As String)
                Me.iconOpenField = Value
            End Set
        End Property

        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set(ByVal value As String)
                Me.iconClosedField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryLabourAlloc

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subcontractOpField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iMachineField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iExpUnitRunTimField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iExpSetUpTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iExpStartupTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iExpShutdownTimField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iWaitTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iWcRateIndField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iStartupQtyField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iCapacityReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iMaxWorkOpertrsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iMaxProdUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subSupplierField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subPoStkCodeField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subQtyPerField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subOrderUomField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subUnitValueField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subWhatIfValueField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subPlannerField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subBuyerField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subLeadTimeField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subDockToStockField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private subOffsiteDaysField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitValueReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startUpIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shutdownIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timeReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timeIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueReqdField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private piecesCompletedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private valueBilledField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operCompletedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyCompletedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyScrappedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lastScrapReasonField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private plannedQueueDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private plannedStartDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private plannedEndDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private actualQueueDateField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private actualStartDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private actualFinishDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private autoNarrCodeField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private narrationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private narrLine1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonConformFlagField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private workCentreField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private workCentreDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timeUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private capacityUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private elapsedTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private movementTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitNumOfPiecesField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private inspectionFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private milestoneField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private minorSetUpField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private minorSetUpCodeField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private toolSetField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private toolSetQtyField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private toolConsumptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private queueTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private milestoneCompField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private calcElapsedTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierHead1Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierHead2Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierHead3Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierHead4Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierHead5Field As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private capacityIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private quoteLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private opCompViaJobField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private narrationsField As List(Of String)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconOpenField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconClosedField As String

        Public Sub New()
            MyBase.New()
            If (Me.narrationsField Is Nothing) Then
                Me.narrationsField = New List(Of String)
            End If
        End Sub

        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set(ByVal value As String)
                Me.operationField = Value
            End Set
        End Property

        Public Property SubcontractOp() As String
            Get
                Return Me.subcontractOpField
            End Get
            Set(ByVal value As String)
                Me.subcontractOpField = Value
            End Set
        End Property

        Public Property IMachine() As Object
            Get
                Return Me.iMachineField
            End Get
            Set(ByVal value As Object)
                Me.iMachineField = Value
            End Set
        End Property

        Public Property IExpUnitRunTim() As String
            Get
                Return Me.iExpUnitRunTimField
            End Get
            Set(ByVal value As String)
                Me.iExpUnitRunTimField = Value
            End Set
        End Property

        Public Property IExpSetUpTime() As String
            Get
                Return Me.iExpSetUpTimeField
            End Get
            Set(ByVal value As String)
                Me.iExpSetUpTimeField = Value
            End Set
        End Property

        Public Property IExpStartupTime() As String
            Get
                Return Me.iExpStartupTimeField
            End Get
            Set(ByVal value As String)
                Me.iExpStartupTimeField = Value
            End Set
        End Property

        Public Property IExpShutdownTim() As String
            Get
                Return Me.iExpShutdownTimField
            End Get
            Set(ByVal value As String)
                Me.iExpShutdownTimField = Value
            End Set
        End Property

        Public Property IWaitTime() As String
            Get
                Return Me.iWaitTimeField
            End Get
            Set(ByVal value As String)
                Me.iWaitTimeField = Value
            End Set
        End Property

        Public Property IWcRateInd() As String
            Get
                Return Me.iWcRateIndField
            End Get
            Set(ByVal value As String)
                Me.iWcRateIndField = Value
            End Set
        End Property

        Public Property IStartupQty() As String
            Get
                Return Me.iStartupQtyField
            End Get
            Set(ByVal value As String)
                Me.iStartupQtyField = Value
            End Set
        End Property

        Public Property ICapacityReqd() As String
            Get
                Return Me.iCapacityReqdField
            End Get
            Set(ByVal value As String)
                Me.iCapacityReqdField = Value
            End Set
        End Property

        Public Property IMaxWorkOpertrs() As String
            Get
                Return Me.iMaxWorkOpertrsField
            End Get
            Set(ByVal value As String)
                Me.iMaxWorkOpertrsField = Value
            End Set
        End Property

        Public Property IMaxProdUnits() As String
            Get
                Return Me.iMaxProdUnitsField
            End Get
            Set(ByVal value As String)
                Me.iMaxProdUnitsField = Value
            End Set
        End Property

        Public Property SubSupplier() As Object
            Get
                Return Me.subSupplierField
            End Get
            Set(ByVal value As Object)
                Me.subSupplierField = Value
            End Set
        End Property

        Public Property SubPoStkCode() As Object
            Get
                Return Me.subPoStkCodeField
            End Get
            Set(ByVal value As Object)
                Me.subPoStkCodeField = Value
            End Set
        End Property

        Public Property SubQtyPer() As Object
            Get
                Return Me.subQtyPerField
            End Get
            Set(ByVal value As Object)
                Me.subQtyPerField = Value
            End Set
        End Property

        Public Property SubOrderUom() As Object
            Get
                Return Me.subOrderUomField
            End Get
            Set(ByVal value As Object)
                Me.subOrderUomField = Value
            End Set
        End Property

        Public Property SubUnitValue() As Object
            Get
                Return Me.subUnitValueField
            End Get
            Set(ByVal value As Object)
                Me.subUnitValueField = Value
            End Set
        End Property

        Public Property SubWhatIfValue() As Object
            Get
                Return Me.subWhatIfValueField
            End Get
            Set(ByVal value As Object)
                Me.subWhatIfValueField = Value
            End Set
        End Property

        Public Property SubPlanner() As Object
            Get
                Return Me.subPlannerField
            End Get
            Set(ByVal value As Object)
                Me.subPlannerField = Value
            End Set
        End Property

        Public Property SubBuyer() As Object
            Get
                Return Me.subBuyerField
            End Get
            Set(ByVal value As Object)
                Me.subBuyerField = Value
            End Set
        End Property

        Public Property SubLeadTime() As Object
            Get
                Return Me.subLeadTimeField
            End Get
            Set(ByVal value As Object)
                Me.subLeadTimeField = Value
            End Set
        End Property

        Public Property SubDockToStock() As Object
            Get
                Return Me.subDockToStockField
            End Get
            Set(ByVal value As Object)
                Me.subDockToStockField = Value
            End Set
        End Property

        Public Property SubOffsiteDays() As Object
            Get
                Return Me.subOffsiteDaysField
            End Get
            Set(ByVal value As Object)
                Me.subOffsiteDaysField = Value
            End Set
        End Property

        Public Property UnitValueReqd() As String
            Get
                Return Me.unitValueReqdField
            End Get
            Set(ByVal value As String)
                Me.unitValueReqdField = Value
            End Set
        End Property

        Public Property RunTimeIssued() As String
            Get
                Return Me.runTimeIssuedField
            End Get
            Set(ByVal value As String)
                Me.runTimeIssuedField = Value
            End Set
        End Property

        Public Property SetUpIssued() As String
            Get
                Return Me.setUpIssuedField
            End Get
            Set(ByVal value As String)
                Me.setUpIssuedField = Value
            End Set
        End Property

        Public Property StartUpIssued() As String
            Get
                Return Me.startUpIssuedField
            End Get
            Set(ByVal value As String)
                Me.startUpIssuedField = Value
            End Set
        End Property

        Public Property ShutdownIssued() As String
            Get
                Return Me.shutdownIssuedField
            End Get
            Set(ByVal value As String)
                Me.shutdownIssuedField = Value
            End Set
        End Property

        Public Property TimeReqd() As String
            Get
                Return Me.timeReqdField
            End Get
            Set(ByVal value As String)
                Me.timeReqdField = Value
            End Set
        End Property

        Public Property TimeIssued() As String
            Get
                Return Me.timeIssuedField
            End Get
            Set(ByVal value As String)
                Me.timeIssuedField = Value
            End Set
        End Property

        Public Property ValueReqd() As String
            Get
                Return Me.valueReqdField
            End Get
            Set(ByVal value As String)
                Me.valueReqdField = Value
            End Set
        End Property

        Public Property ValueIssued() As String
            Get
                Return Me.valueIssuedField
            End Get
            Set(ByVal value As String)
                Me.valueIssuedField = Value
            End Set
        End Property

        Public Property PiecesCompleted() As String
            Get
                Return Me.piecesCompletedField
            End Get
            Set(ByVal value As String)
                Me.piecesCompletedField = Value
            End Set
        End Property

        Public Property ValueBilled() As String
            Get
                Return Me.valueBilledField
            End Get
            Set(ByVal value As String)
                Me.valueBilledField = Value
            End Set
        End Property

        Public Property OperCompleted() As String
            Get
                Return Me.operCompletedField
            End Get
            Set(ByVal value As String)
                Me.operCompletedField = Value
            End Set
        End Property

        Public Property QtyCompleted() As String
            Get
                Return Me.qtyCompletedField
            End Get
            Set(ByVal value As String)
                Me.qtyCompletedField = Value
            End Set
        End Property

        Public Property QtyScrapped() As String
            Get
                Return Me.qtyScrappedField
            End Get
            Set(ByVal value As String)
                Me.qtyScrappedField = Value
            End Set
        End Property

        Public Property LastScrapReason() As Object
            Get
                Return Me.lastScrapReasonField
            End Get
            Set(ByVal value As Object)
                Me.lastScrapReasonField = Value
            End Set
        End Property

        Public Property PlannedQueueDate() As String
            Get
                Return Me.plannedQueueDateField
            End Get
            Set(ByVal value As String)
                Me.plannedQueueDateField = Value
            End Set
        End Property

        Public Property PlannedStartDate() As String
            Get
                Return Me.plannedStartDateField
            End Get
            Set(ByVal value As String)
                Me.plannedStartDateField = Value
            End Set
        End Property

        Public Property PlannedEndDate() As String
            Get
                Return Me.plannedEndDateField
            End Get
            Set(ByVal value As String)
                Me.plannedEndDateField = Value
            End Set
        End Property

        Public Property ActualQueueDate() As Object
            Get
                Return Me.actualQueueDateField
            End Get
            Set(ByVal value As Object)
                Me.actualQueueDateField = Value
            End Set
        End Property

        Public Property ActualStartDate() As String
            Get
                Return Me.actualStartDateField
            End Get
            Set(ByVal value As String)
                Me.actualStartDateField = Value
            End Set
        End Property

        Public Property ActualFinishDate() As String
            Get
                Return Me.actualFinishDateField
            End Get
            Set(ByVal value As String)
                Me.actualFinishDateField = Value
            End Set
        End Property

        Public Property AutoNarrCode() As Object
            Get
                Return Me.autoNarrCodeField
            End Get
            Set(ByVal value As Object)
                Me.autoNarrCodeField = Value
            End Set
        End Property

        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set(ByVal value As String)
                Me.narrationField = Value
            End Set
        End Property

        Public Property NarrLine1() As String
            Get
                Return Me.narrLine1Field
            End Get
            Set(ByVal value As String)
                Me.narrLine1Field = Value
            End Set
        End Property

        Public Property NonConformFlag() As Object
            Get
                Return Me.nonConformFlagField
            End Get
            Set(ByVal value As Object)
                Me.nonConformFlagField = Value
            End Set
        End Property

        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set(ByVal value As String)
                Me.workCentreField = Value
            End Set
        End Property

        Public Property WorkCentreDesc() As String
            Get
                Return Me.workCentreDescField
            End Get
            Set(ByVal value As String)
                Me.workCentreDescField = Value
            End Set
        End Property

        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set(ByVal value As String)
                Me.timeUomField = Value
            End Set
        End Property

        Public Property CapacityUom() As String
            Get
                Return Me.capacityUomField
            End Get
            Set(ByVal value As String)
                Me.capacityUomField = Value
            End Set
        End Property

        Public Property ElapsedTime() As String
            Get
                Return Me.elapsedTimeField
            End Get
            Set(ByVal value As String)
                Me.elapsedTimeField = Value
            End Set
        End Property

        Public Property MovementTime() As String
            Get
                Return Me.movementTimeField
            End Get
            Set(ByVal value As String)
                Me.movementTimeField = Value
            End Set
        End Property

        Public Property UnitNumOfPieces() As String
            Get
                Return Me.unitNumOfPiecesField
            End Get
            Set(ByVal value As String)
                Me.unitNumOfPiecesField = Value
            End Set
        End Property

        Public Property InspectionFlag() As String
            Get
                Return Me.inspectionFlagField
            End Get
            Set(ByVal value As String)
                Me.inspectionFlagField = Value
            End Set
        End Property

        Public Property Milestone() As String
            Get
                Return Me.milestoneField
            End Get
            Set(ByVal value As String)
                Me.milestoneField = Value
            End Set
        End Property

        Public Property MinorSetUp() As String
            Get
                Return Me.minorSetUpField
            End Get
            Set(ByVal value As String)
                Me.minorSetUpField = Value
            End Set
        End Property

        Public Property MinorSetUpCode() As Object
            Get
                Return Me.minorSetUpCodeField
            End Get
            Set(ByVal value As Object)
                Me.minorSetUpCodeField = Value
            End Set
        End Property

        Public Property ToolSet() As Object
            Get
                Return Me.toolSetField
            End Get
            Set(ByVal value As Object)
                Me.toolSetField = Value
            End Set
        End Property

        Public Property ToolSetQty() As String
            Get
                Return Me.toolSetQtyField
            End Get
            Set(ByVal value As String)
                Me.toolSetQtyField = Value
            End Set
        End Property

        Public Property ToolConsumption() As String
            Get
                Return Me.toolConsumptionField
            End Get
            Set(ByVal value As String)
                Me.toolConsumptionField = Value
            End Set
        End Property

        Public Property QueueTime() As String
            Get
                Return Me.queueTimeField
            End Get
            Set(ByVal value As String)
                Me.queueTimeField = Value
            End Set
        End Property

        Public Property MilestoneComp() As Object
            Get
                Return Me.milestoneCompField
            End Get
            Set(ByVal value As Object)
                Me.milestoneCompField = Value
            End Set
        End Property

        Public Property CalcElapsedTime() As String
            Get
                Return Me.calcElapsedTimeField
            End Get
            Set(ByVal value As String)
                Me.calcElapsedTimeField = Value
            End Set
        End Property

        Public Property HierHead1() As Object
            Get
                Return Me.hierHead1Field
            End Get
            Set(ByVal value As Object)
                Me.hierHead1Field = Value
            End Set
        End Property

        Public Property HierHead2() As Object
            Get
                Return Me.hierHead2Field
            End Get
            Set(ByVal value As Object)
                Me.hierHead2Field = Value
            End Set
        End Property

        Public Property HierHead3() As Object
            Get
                Return Me.hierHead3Field
            End Get
            Set(ByVal value As Object)
                Me.hierHead3Field = Value
            End Set
        End Property

        Public Property HierHead4() As Object
            Get
                Return Me.hierHead4Field
            End Get
            Set(ByVal value As Object)
                Me.hierHead4Field = Value
            End Set
        End Property

        Public Property HierHead5() As Object
            Get
                Return Me.hierHead5Field
            End Get
            Set(ByVal value As Object)
                Me.hierHead5Field = Value
            End Set
        End Property

        Public Property CapacityIssued() As String
            Get
                Return Me.capacityIssuedField
            End Get
            Set(ByVal value As String)
                Me.capacityIssuedField = Value
            End Set
        End Property

        Public Property QuoteLine() As String
            Get
                Return Me.quoteLineField
            End Get
            Set(ByVal value As String)
                Me.quoteLineField = Value
            End Set
        End Property

        Public Property OpCompViaJob() As Object
            Get
                Return Me.opCompViaJobField
            End Get
            Set(ByVal value As Object)
                Me.opCompViaJobField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("Narration", IsNullable:=False)> _
        Public Property NarrationsCollection() As List(Of String)
            Get
                Return Me.narrationsField
            End Get
            Set(ByVal value As List(Of String))
                Me.narrationsField = Value
            End Set
        End Property

        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set(ByVal value As String)
                Me.iconOpenField = Value
            End Set
        End Property

        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set(ByVal value As String)
                Me.iconClosedField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryLabourIssue

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lWorkCentreField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lWorkCentreDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lRunTimeHoursField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lSetUpHoursField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lStartupHoursField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lTeardownHoursField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private totalTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lOperationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lMachineField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lRunTimeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lSetUpTimeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lFixedTimeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lVarTimeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lStartTimeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lTeardownRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lSubcontractFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lEmployeeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lQtyScrappedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lQtyCompleteField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lWcRateIndField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lEmployeeRatIndField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postYearField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private postMonthField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconOpenField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private iconClosedField As String

        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set(ByVal value As String)
                Me.lineField = Value
            End Set
        End Property

        Public Property TrnType() As String
            Get
                Return Me.trnTypeField
            End Get
            Set(ByVal value As String)
                Me.trnTypeField = Value
            End Set
        End Property

        Public Property LWorkCentre() As String
            Get
                Return Me.lWorkCentreField
            End Get
            Set(ByVal value As String)
                Me.lWorkCentreField = Value
            End Set
        End Property

        Public Property LWorkCentreDesc() As String
            Get
                Return Me.lWorkCentreDescField
            End Get
            Set(ByVal value As String)
                Me.lWorkCentreDescField = Value
            End Set
        End Property

        Public Property LRunTimeHours() As String
            Get
                Return Me.lRunTimeHoursField
            End Get
            Set(ByVal value As String)
                Me.lRunTimeHoursField = Value
            End Set
        End Property

        Public Property LSetUpHours() As String
            Get
                Return Me.lSetUpHoursField
            End Get
            Set(ByVal value As String)
                Me.lSetUpHoursField = Value
            End Set
        End Property

        Public Property LStartupHours() As String
            Get
                Return Me.lStartupHoursField
            End Get
            Set(ByVal value As String)
                Me.lStartupHoursField = Value
            End Set
        End Property

        Public Property LTeardownHours() As String
            Get
                Return Me.lTeardownHoursField
            End Get
            Set(ByVal value As String)
                Me.lTeardownHoursField = Value
            End Set
        End Property

        Public Property TotalTime() As String
            Get
                Return Me.totalTimeField
            End Get
            Set(ByVal value As String)
                Me.totalTimeField = Value
            End Set
        End Property

        Public Property LOperation() As String
            Get
                Return Me.lOperationField
            End Get
            Set(ByVal value As String)
                Me.lOperationField = Value
            End Set
        End Property

        Public Property LMachine() As Object
            Get
                Return Me.lMachineField
            End Get
            Set(ByVal value As Object)
                Me.lMachineField = Value
            End Set
        End Property

        Public Property LRunTimeRate() As String
            Get
                Return Me.lRunTimeRateField
            End Get
            Set(ByVal value As String)
                Me.lRunTimeRateField = Value
            End Set
        End Property

        Public Property LSetUpTimeRate() As String
            Get
                Return Me.lSetUpTimeRateField
            End Get
            Set(ByVal value As String)
                Me.lSetUpTimeRateField = Value
            End Set
        End Property

        Public Property LFixedTimeRate() As String
            Get
                Return Me.lFixedTimeRateField
            End Get
            Set(ByVal value As String)
                Me.lFixedTimeRateField = Value
            End Set
        End Property

        Public Property LVarTimeRate() As String
            Get
                Return Me.lVarTimeRateField
            End Get
            Set(ByVal value As String)
                Me.lVarTimeRateField = Value
            End Set
        End Property

        Public Property LStartTimeRate() As String
            Get
                Return Me.lStartTimeRateField
            End Get
            Set(ByVal value As String)
                Me.lStartTimeRateField = Value
            End Set
        End Property

        Public Property LTeardownRate() As String
            Get
                Return Me.lTeardownRateField
            End Get
            Set(ByVal value As String)
                Me.lTeardownRateField = Value
            End Set
        End Property

        Public Property LSubcontractFlag() As String
            Get
                Return Me.lSubcontractFlagField
            End Get
            Set(ByVal value As String)
                Me.lSubcontractFlagField = Value
            End Set
        End Property

        Public Property LEmployee() As String
            Get
                Return Me.lEmployeeField
            End Get
            Set(ByVal value As String)
                Me.lEmployeeField = Value
            End Set
        End Property

        Public Property LQtyScrapped() As String
            Get
                Return Me.lQtyScrappedField
            End Get
            Set(ByVal value As String)
                Me.lQtyScrappedField = Value
            End Set
        End Property

        Public Property LQtyComplete() As String
            Get
                Return Me.lQtyCompleteField
            End Get
            Set(ByVal value As String)
                Me.lQtyCompleteField = Value
            End Set
        End Property

        Public Property LWcRateInd() As String
            Get
                Return Me.lWcRateIndField
            End Get
            Set(ByVal value As String)
                Me.lWcRateIndField = Value
            End Set
        End Property

        Public Property LEmployeeRatInd() As Object
            Get
                Return Me.lEmployeeRatIndField
            End Get
            Set(ByVal value As Object)
                Me.lEmployeeRatIndField = Value
            End Set
        End Property

        Public Property TrnValue() As String
            Get
                Return Me.trnValueField
            End Get
            Set(ByVal value As String)
                Me.trnValueField = Value
            End Set
        End Property

        Public Property TrnDate() As String
            Get
                Return Me.trnDateField
            End Get
            Set(ByVal value As String)
                Me.trnDateField = Value
            End Set
        End Property

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = Value
            End Set
        End Property

        Public Property PostYear() As String
            Get
                Return Me.postYearField
            End Get
            Set(ByVal value As String)
                Me.postYearField = Value
            End Set
        End Property

        Public Property PostMonth() As String
            Get
                Return Me.postMonthField
            End Get
            Set(ByVal value As String)
                Me.postMonthField = Value
            End Set
        End Property

        Public Property IconOpen() As String
            Get
                Return Me.iconOpenField
            End Get
            Set(ByVal value As String)
                Me.iconOpenField = Value
            End Set
        End Property

        Public Property IconClosed() As String
            Get
                Return Me.iconClosedField
            End Get
            Set(ByVal value As String)
                Me.iconClosedField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class WipQueryPartBooking

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtySuppliedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private trnDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private labourValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private materialValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private referenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addReferenceField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderField As Object

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private masterJobField As Object

        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set(ByVal value As String)
                Me.lineField = Value
            End Set
        End Property

        Public Property QtySupplied() As String
            Get
                Return Me.qtySuppliedField
            End Get
            Set(ByVal value As String)
                Me.qtySuppliedField = Value
            End Set
        End Property

        Public Property TrnDate() As String
            Get
                Return Me.trnDateField
            End Get
            Set(ByVal value As String)
                Me.trnDateField = Value
            End Set
        End Property

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = Value
            End Set
        End Property

        Public Property LabourValue() As String
            Get
                Return Me.labourValueField
            End Get
            Set(ByVal value As String)
                Me.labourValueField = Value
            End Set
        End Property

        Public Property MaterialValue() As String
            Get
                Return Me.materialValueField
            End Get
            Set(ByVal value As String)
                Me.materialValueField = Value
            End Set
        End Property

        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As String)
                Me.referenceField = Value
            End Set
        End Property

        Public Property AddReference() As Object
            Get
                Return Me.addReferenceField
            End Get
            Set(ByVal value As Object)
                Me.addReferenceField = Value
            End Set
        End Property

        Public Property SalesOrder() As Object
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As Object)
                Me.salesOrderField = Value
            End Set
        End Property

        Public Property MasterJob() As Object
            Get
                Return Me.masterJobField
            End Get
            Set(ByVal value As Object)
                Me.masterJobField = Value
            End Set
        End Property
    End Class
End Namespace
