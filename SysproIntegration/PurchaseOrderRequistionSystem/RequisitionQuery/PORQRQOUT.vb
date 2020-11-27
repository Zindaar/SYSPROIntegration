Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ReqQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ReqQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionItemField As List(Of ReqQueryRequisitionItem)
        
        Public Sub New()
            MyBase.New
            If (Me.requisitionItemField Is Nothing) Then
                Me.requisitionItemField = New List(Of ReqQueryRequisitionItem)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ReqQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ReqQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
        
        Public Property UserCode() As String
            Get
                Return Me.userCodeField
            End Get
            Set
                Me.userCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("RequisitionItem")>  _
        Public Property RequisitionItemCollection() As List(Of ReqQueryRequisitionItem)
            Get
                Return Me.requisitionItemField
            End Get
            Set
                Me.requisitionItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ReqQuerySystemInformation
        
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
    Partial Public Class ReqQueryRequisitionItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForReqnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private showCommitmentStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnIfBudgetExceededField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromUserInformationField As ReqQueryRequisitionItemFromUserInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeNarrativeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lessPlusDiscField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateReqnRaisedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastReceiptField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePoConfirmedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateActionedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reqnStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pOStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supCatalogueNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteLineNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bpoApprovedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOperationNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorInformationField As ReqQueryRequisitionItemOriginatorInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedPoNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private confirmedPoLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private holderInformationField As ReqQueryRequisitionItemHolderInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private approvedInformationField As ReqQueryRequisitionItemApprovedInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notesField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentsField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.commentsField Is Nothing) Then
                Me.commentsField = New List(Of String)
            End If
            If (Me.notesField Is Nothing) Then
                Me.notesField = New List(Of String)
            End If
            If (Me.approvedInformationField Is Nothing) Then
                Me.approvedInformationField = New ReqQueryRequisitionItemApprovedInformation
            End If
            If (Me.holderInformationField Is Nothing) Then
                Me.holderInformationField = New ReqQueryRequisitionItemHolderInformation
            End If
            If (Me.originatorInformationField Is Nothing) Then
                Me.originatorInformationField = New ReqQueryRequisitionItemOriginatorInformation
            End If
            If (Me.fromUserInformationField Is Nothing) Then
                Me.fromUserInformationField = New ReqQueryRequisitionItemFromUserInformation
            End If
        End Sub
        
        Public Property Requisition() As String
            Get
                Return Me.requisitionField
            End Get
            Set
                Me.requisitionField = value
            End Set
        End Property
        
        Public Property ReasonForReqn() As String
            Get
                Return Me.reasonForReqnField
            End Get
            Set
                Me.reasonForReqnField = value
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
        
        Public Property ShowCommitmentStatus() As String
            Get
                Return Me.showCommitmentStatusField
            End Get
            Set
                Me.showCommitmentStatusField = value
            End Set
        End Property
        
        Public Property WarnIfBudgetExceeded() As String
            Get
                Return Me.warnIfBudgetExceededField
            End Get
            Set
                Me.warnIfBudgetExceededField = value
            End Set
        End Property
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        Public Property FromUserInformation() As ReqQueryRequisitionItemFromUserInformation
            Get
                Return Me.fromUserInformationField
            End Get
            Set
                Me.fromUserInformationField = value
            End Set
        End Property
        
        Public Property RouteNarrative() As String
            Get
                Return Me.routeNarrativeField
            End Get
            Set
                Me.routeNarrativeField = value
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
        
        Public Property SupplierName() As String
            Get
                Return Me.supplierNameField
            End Get
            Set
                Me.supplierNameField = value
            End Set
        End Property
        
        Public Property SupplierCurrency() As String
            Get
                Return Me.supplierCurrencyField
            End Get
            Set
                Me.supplierCurrencyField = value
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
        
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property DiscountCode() As String
            Get
                Return Me.discountCodeField
            End Get
            Set
                Me.discountCodeField = value
            End Set
        End Property
        
        Public Property LessPlusDisc() As String
            Get
                Return Me.lessPlusDiscField
            End Get
            Set
                Me.lessPlusDiscField = value
            End Set
        End Property
        
        Public Property DiscPct1() As String
            Get
                Return Me.discPct1Field
            End Get
            Set
                Me.discPct1Field = value
            End Set
        End Property
        
        Public Property DiscPct2() As String
            Get
                Return Me.discPct2Field
            End Get
            Set
                Me.discPct2Field = value
            End Set
        End Property
        
        Public Property DiscPct3() As String
            Get
                Return Me.discPct3Field
            End Get
            Set
                Me.discPct3Field = value
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
        
        Public Property EccHold() As String
            Get
                Return Me.eccHoldField
            End Get
            Set
                Me.eccHoldField = value
            End Set
        End Property
        
        Public Property OrderQty() As String
            Get
                Return Me.orderQtyField
            End Get
            Set
                Me.orderQtyField = value
            End Set
        End Property
        
        Public Property OrderUom() As String
            Get
                Return Me.orderUomField
            End Get
            Set
                Me.orderUomField = value
            End Set
        End Property
        
        Public Property DateReqnRaised() As String
            Get
                Return Me.dateReqnRaisedField
            End Get
            Set
                Me.dateReqnRaisedField = value
            End Set
        End Property
        
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        Public Property DateLastReceipt() As String
            Get
                Return Me.dateLastReceiptField
            End Get
            Set
                Me.dateLastReceiptField = value
            End Set
        End Property
        
        Public Property DatePoConfirmed() As String
            Get
                Return Me.datePoConfirmedField
            End Get
            Set
                Me.datePoConfirmedField = value
            End Set
        End Property
        
        Public Property DateActioned() As String
            Get
                Return Me.dateActionedField
            End Get
            Set
                Me.dateActionedField = value
            End Set
        End Property
        
        Public Property ReqnStatus() As String
            Get
                Return Me.reqnStatusField
            End Get
            Set
                Me.reqnStatusField = value
            End Set
        End Property
        
        Public Property POStatus() As String
            Get
                Return Me.pOStatusField
            End Get
            Set
                Me.pOStatusField = value
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
        
        Public Property SupCatalogueNum() As String
            Get
                Return Me.supCatalogueNumField
            End Get
            Set
                Me.supCatalogueNumField = value
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
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
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
        
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
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
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
        
        Public Property QuoteLineNum() As String
            Get
                Return Me.quoteLineNumField
            End Get
            Set
                Me.quoteLineNumField = value
            End Set
        End Property
        
        Public Property CapexNum() As String
            Get
                Return Me.capexNumField
            End Get
            Set
                Me.capexNumField = value
            End Set
        End Property
        
        Public Property BpoApproved() As String
            Get
                Return Me.bpoApprovedField
            End Get
            Set
                Me.bpoApprovedField = value
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
        
        Public Property JobDescription() As String
            Get
                Return Me.jobDescriptionField
            End Get
            Set
                Me.jobDescriptionField = value
            End Set
        End Property
        
        Public Property SubOperationNum() As String
            Get
                Return Me.subOperationNumField
            End Get
            Set
                Me.subOperationNumField = value
            End Set
        End Property
        
        Public Property OriginatorInformation() As ReqQueryRequisitionItemOriginatorInformation
            Get
                Return Me.originatorInformationField
            End Get
            Set
                Me.originatorInformationField = value
            End Set
        End Property
        
        Public Property ConfirmedPoNum() As String
            Get
                Return Me.confirmedPoNumField
            End Get
            Set
                Me.confirmedPoNumField = value
            End Set
        End Property
        
        Public Property ConfirmedPoLine() As String
            Get
                Return Me.confirmedPoLineField
            End Get
            Set
                Me.confirmedPoLineField = value
            End Set
        End Property
        
        Public Property HolderInformation() As ReqQueryRequisitionItemHolderInformation
            Get
                Return Me.holderInformationField
            End Get
            Set
                Me.holderInformationField = value
            End Set
        End Property
        
        Public Property ApprovedInformation() As ReqQueryRequisitionItemApprovedInformation
            Get
                Return Me.approvedInformationField
            End Get
            Set
                Me.approvedInformationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property NotesCollection() As List(Of String)
            Get
                Return Me.notesField
            End Get
            Set
                Me.notesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property CommentsCollection() As List(Of String)
            Get
                Return Me.commentsField
            End Get
            Set
                Me.commentsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ReqQueryRequisitionItemFromUserInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userNameField As String
        
        Public Property FromUser() As String
            Get
                Return Me.fromUserField
            End Get
            Set
                Me.fromUserField = value
            End Set
        End Property
        
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ReqQueryRequisitionItemOriginatorInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userNameField As String
        
        Public Property Originator() As String
            Get
                Return Me.originatorField
            End Get
            Set
                Me.originatorField = value
            End Set
        End Property
        
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ReqQueryRequisitionItemHolderInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentHolderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userNameField As String
        
        Public Property CurrentHolder() As String
            Get
                Return Me.currentHolderField
            End Get
            Set
                Me.currentHolderField = value
            End Set
        End Property
        
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ReqQueryRequisitionItemApprovedInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userNameField As String
        
        Public Property UserCode() As String
            Get
                Return Me.userCodeField
            End Get
            Set
                Me.userCodeField = value
            End Set
        End Property
        
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
    End Class
End Namespace
