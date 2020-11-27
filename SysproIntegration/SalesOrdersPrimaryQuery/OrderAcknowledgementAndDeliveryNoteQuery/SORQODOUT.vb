Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.OrderAcknowledgementAndDeliveryNoteQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SorSalesOrderDocuments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As SorSalesOrderDocumentsSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderDocumentField As SorSalesOrderDocumentsSalesOrderDocument
        
        Public Sub New()
            MyBase.New
            If (Me.salesOrderDocumentField Is Nothing) Then
                Me.salesOrderDocumentField = New SorSalesOrderDocumentsSalesOrderDocument
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New SorSalesOrderDocumentsSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As SorSalesOrderDocumentsSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property SalesOrderDocument() As SorSalesOrderDocumentsSalesOrderDocument
            Get
                Return Me.salesOrderDocumentField
            End Get
            Set
                Me.salesOrderDocumentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSystemInformation
        
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
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocument
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headerField As SorSalesOrderDocumentsSalesOrderDocumentHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notesField As SorSalesOrderDocumentsSalesOrderDocumentNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customDataField As SorSalesOrderDocumentsSalesOrderDocumentCustomData
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseField As List(Of SorSalesOrderDocumentsSalesOrderDocumentMerchandise)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightField As SorSalesOrderDocumentsSalesOrderDocumentFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeField As SorSalesOrderDocumentsSalesOrderDocumentMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As List(Of SorSalesOrderDocumentsSalesOrderDocumentComment)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalsField As SorSalesOrderDocumentsSalesOrderDocumentTotals
        
        Public Sub New()
            MyBase.New
            If (Me.totalsField Is Nothing) Then
                Me.totalsField = New SorSalesOrderDocumentsSalesOrderDocumentTotals
            End If
            If (Me.commentField Is Nothing) Then
                Me.commentField = New List(Of SorSalesOrderDocumentsSalesOrderDocumentComment)
            End If
            If (Me.miscChargeField Is Nothing) Then
                Me.miscChargeField = New SorSalesOrderDocumentsSalesOrderDocumentMiscCharge
            End If
            If (Me.freightField Is Nothing) Then
                Me.freightField = New SorSalesOrderDocumentsSalesOrderDocumentFreight
            End If
            If (Me.merchandiseField Is Nothing) Then
                Me.merchandiseField = New List(Of SorSalesOrderDocumentsSalesOrderDocumentMerchandise)
            End If
            If (Me.customDataField Is Nothing) Then
                Me.customDataField = New SorSalesOrderDocumentsSalesOrderDocumentCustomData
            End If
            If (Me.notesField Is Nothing) Then
                Me.notesField = New SorSalesOrderDocumentsSalesOrderDocumentNotes
            End If
            If (Me.headerField Is Nothing) Then
                Me.headerField = New SorSalesOrderDocumentsSalesOrderDocumentHeader
            End If
        End Sub
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property DocumentType() As String
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
            End Set
        End Property
        
        Public Property Reprint() As String
            Get
                Return Me.reprintField
            End Get
            Set
                Me.reprintField = value
            End Set
        End Property
        
        Public Property Header() As SorSalesOrderDocumentsSalesOrderDocumentHeader
            Get
                Return Me.headerField
            End Get
            Set
                Me.headerField = value
            End Set
        End Property
        
        Public Property Notes() As SorSalesOrderDocumentsSalesOrderDocumentNotes
            Get
                Return Me.notesField
            End Get
            Set
                Me.notesField = value
            End Set
        End Property
        
        Public Property CustomData() As SorSalesOrderDocumentsSalesOrderDocumentCustomData
            Get
                Return Me.customDataField
            End Get
            Set
                Me.customDataField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Merchandise")>  _
        Public Property MerchandiseCollection() As List(Of SorSalesOrderDocumentsSalesOrderDocumentMerchandise)
            Get
                Return Me.merchandiseField
            End Get
            Set
                Me.merchandiseField = value
            End Set
        End Property
        
        Public Property Freight() As SorSalesOrderDocumentsSalesOrderDocumentFreight
            Get
                Return Me.freightField
            End Get
            Set
                Me.freightField = value
            End Set
        End Property
        
        Public Property MiscCharge() As SorSalesOrderDocumentsSalesOrderDocumentMiscCharge
            Get
                Return Me.miscChargeField
            End Get
            Set
                Me.miscChargeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Comment")>  _
        Public Property CommentCollection() As List(Of SorSalesOrderDocumentsSalesOrderDocumentComment)
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property Totals() As SorSalesOrderDocumentsSalesOrderDocumentTotals
            Get
                Return Me.totalsField
            End Get
            Set
                Me.totalsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTaxNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyRegNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldPostalcodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipCustomerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalcodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTaxNoField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reqShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceCreditedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private delNoteSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditAuthorityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invTermsOverrideField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceTermsDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastOperatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneExtnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telexField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
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
        
        Public Property CompanyAddress1() As String
            Get
                Return Me.companyAddress1Field
            End Get
            Set
                Me.companyAddress1Field = value
            End Set
        End Property
        
        Public Property CompanyAddress2() As String
            Get
                Return Me.companyAddress2Field
            End Get
            Set
                Me.companyAddress2Field = value
            End Set
        End Property
        
        Public Property CompanyAddress3() As String
            Get
                Return Me.companyAddress3Field
            End Get
            Set
                Me.companyAddress3Field = value
            End Set
        End Property
        
        Public Property CompanyTaxNumber() As String
            Get
                Return Me.companyTaxNumberField
            End Get
            Set
                Me.companyTaxNumberField = value
            End Set
        End Property
        
        Public Property CompanyRegNumber() As String
            Get
                Return Me.companyRegNumberField
            End Get
            Set
                Me.companyRegNumberField = value
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
        
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        Public Property SoldToAddr1() As String
            Get
                Return Me.soldToAddr1Field
            End Get
            Set
                Me.soldToAddr1Field = value
            End Set
        End Property
        
        Public Property SoldToAddr2() As String
            Get
                Return Me.soldToAddr2Field
            End Get
            Set
                Me.soldToAddr2Field = value
            End Set
        End Property
        
        Public Property SoldToAddr3() As String
            Get
                Return Me.soldToAddr3Field
            End Get
            Set
                Me.soldToAddr3Field = value
            End Set
        End Property
        
        Public Property SoldToAddr4() As String
            Get
                Return Me.soldToAddr4Field
            End Get
            Set
                Me.soldToAddr4Field = value
            End Set
        End Property
        
        Public Property SoldToAddr5() As String
            Get
                Return Me.soldToAddr5Field
            End Get
            Set
                Me.soldToAddr5Field = value
            End Set
        End Property
        
        Public Property SoldPostalcode() As String
            Get
                Return Me.soldPostalcodeField
            End Get
            Set
                Me.soldPostalcodeField = value
            End Set
        End Property
        
        Public Property StateCode() As String
            Get
                Return Me.stateCodeField
            End Get
            Set
                Me.stateCodeField = value
            End Set
        End Property
        
        Public Property ShipCustomerName() As String
            Get
                Return Me.shipCustomerNameField
            End Get
            Set
                Me.shipCustomerNameField = value
            End Set
        End Property
        
        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = value
            End Set
        End Property
        
        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = value
            End Set
        End Property
        
        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = value
            End Set
        End Property
        
        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = value
            End Set
        End Property
        
        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = value
            End Set
        End Property
        
        Public Property ShipPostalcode() As String
            Get
                Return Me.shipPostalcodeField
            End Get
            Set
                Me.shipPostalcodeField = value
            End Set
        End Property
        
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        Public Property SalespersonName() As String
            Get
                Return Me.salespersonNameField
            End Get
            Set
                Me.salespersonNameField = value
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
        
        Public Property CompanyTaxNo() As String
            Get
                Return Me.companyTaxNoField
            End Get
            Set
                Me.companyTaxNoField = value
            End Set
        End Property
        
        Public Property OrderDate() As String
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        Public Property ReqShipDate() As String
            Get
                Return Me.reqShipDateField
            End Get
            Set
                Me.reqShipDateField = value
            End Set
        End Property
        
        Public Property SystemDate() As String
            Get
                Return Me.systemDateField
            End Get
            Set
                Me.systemDateField = value
            End Set
        End Property
        
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
            End Set
        End Property
        
        Public Property InvoiceCredited() As String
            Get
                Return Me.invoiceCreditedField
            End Get
            Set
                Me.invoiceCreditedField = value
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
        
        Public Property DelNoteSuffix() As String
            Get
                Return Me.delNoteSuffixField
            End Get
            Set
                Me.delNoteSuffixField = value
            End Set
        End Property
        
        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        Public Property CreditAuthority() As String
            Get
                Return Me.creditAuthorityField
            End Get
            Set
                Me.creditAuthorityField = value
            End Set
        End Property
        
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        Public Property AreaDescription() As String
            Get
                Return Me.areaDescriptionField
            End Get
            Set
                Me.areaDescriptionField = value
            End Set
        End Property
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property BranchDescription() As String
            Get
                Return Me.branchDescriptionField
            End Get
            Set
                Me.branchDescriptionField = value
            End Set
        End Property
        
        Public Property BranchAddr1() As String
            Get
                Return Me.branchAddr1Field
            End Get
            Set
                Me.branchAddr1Field = value
            End Set
        End Property
        
        Public Property BranchAddr2() As String
            Get
                Return Me.branchAddr2Field
            End Get
            Set
                Me.branchAddr2Field = value
            End Set
        End Property
        
        Public Property BranchAddr3() As String
            Get
                Return Me.branchAddr3Field
            End Get
            Set
                Me.branchAddr3Field = value
            End Set
        End Property
        
        Public Property InvTermsOverride() As String
            Get
                Return Me.invTermsOverrideField
            End Get
            Set
                Me.invTermsOverrideField = value
            End Set
        End Property
        
        Public Property InvoiceTermsDescription() As String
            Get
                Return Me.invoiceTermsDescriptionField
            End Get
            Set
                Me.invoiceTermsDescriptionField = value
            End Set
        End Property
        
        Public Property LastOperator() As String
            Get
                Return Me.lastOperatorField
            End Get
            Set
                Me.lastOperatorField = value
            End Set
        End Property
        
        Public Property CustomerComment() As String
            Get
                Return Me.customerCommentField
            End Get
            Set
                Me.customerCommentField = value
            End Set
        End Property
        
        Public Property AlternateKey() As String
            Get
                Return Me.alternateKeyField
            End Get
            Set
                Me.alternateKeyField = value
            End Set
        End Property
        
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = value
            End Set
        End Property
        
        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set
                Me.taxExemptNumberField = value
            End Set
        End Property
        
        Public Property GstExemptNum() As String
            Get
                Return Me.gstExemptNumField
            End Get
            Set
                Me.gstExemptNumField = value
            End Set
        End Property
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property CurrencyDescription() As String
            Get
                Return Me.currencyDescriptionField
            End Get
            Set
                Me.currencyDescriptionField = value
            End Set
        End Property
        
        Public Property Contact() As String
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
            End Set
        End Property
        
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        Public Property TelephoneExtn() As String
            Get
                Return Me.telephoneExtnField
            End Get
            Set
                Me.telephoneExtnField = value
            End Set
        End Property
        
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
            End Set
        End Property
        
        Public Property Telex() As String
            Get
                Return Me.telexField
            End Get
            Set
                Me.telexField = value
            End Set
        End Property
        
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        Public Property OrderStatus() As String
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentCustomData
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fieldField As List(Of SorSalesOrderDocumentsSalesOrderDocumentCustomDataField)
        
        Public Sub New()
            MyBase.New
            If (Me.fieldField Is Nothing) Then
                Me.fieldField = New List(Of SorSalesOrderDocumentsSalesOrderDocumentCustomDataField)
            End If
        End Sub
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Field")>  _
        Public Property FieldCollection() As List(Of SorSalesOrderDocumentsSalesOrderDocumentCustomDataField)
            Get
                Return Me.fieldField
            End Get
            Set
                Me.fieldField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentCustomDataField
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formPromptField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formLengthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formDecimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private formValueField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property FormName() As String
            Get
                Return Me.formNameField
            End Get
            Set
                Me.formNameField = value
            End Set
        End Property
        
        Public Property FormPrompt() As String
            Get
                Return Me.formPromptField
            End Get
            Set
                Me.formPromptField = value
            End Set
        End Property
        
        Public Property FormType() As String
            Get
                Return Me.formTypeField
            End Get
            Set
                Me.formTypeField = value
            End Set
        End Property
        
        Public Property FormLength() As String
            Get
                Return Me.formLengthField
            End Get
            Set
                Me.formLengthField = value
            End Set
        End Property
        
        Public Property FormDecimals() As String
            Get
                Return Me.formDecimalsField
            End Get
            Set
                Me.formDecimalsField = value
            End Set
        End Property
        
        Public Property FormValue() As String
            Get
                Return Me.formValueField
            End Get
            Set
                Me.formValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentMerchandise
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mShipQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBackOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockQtyToShpField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pricingQtyShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockingUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockDesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCustRequestDatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mContractField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBuyingGroupField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusSupStkCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusRetailPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cusGrossProfitPercField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private detCustTotalRetailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mUserDefField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitVolField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMassRoundedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineVolRoundedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netUnitPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitPriceInclTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitPriceInOrderUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mTariffcodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mSupplementaryUnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineGrossamountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNetAfterDiscField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineTaxPercField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNetInclTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mConvFactOrdUmField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private palletQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVersionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReleaseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotsField As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseSerials
        
        Public Sub New()
            MyBase.New
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New SorSalesOrderDocumentsSalesOrderDocumentMerchandiseSerials
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New SorSalesOrderDocumentsSalesOrderDocumentMerchandiseBins
            End If
            If (Me.lotsField Is Nothing) Then
                Me.lotsField = New SorSalesOrderDocumentsSalesOrderDocumentMerchandiseLots
            End If
        End Sub
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
        
        Public Property MOrderQty() As String
            Get
                Return Me.mOrderQtyField
            End Get
            Set
                Me.mOrderQtyField = value
            End Set
        End Property
        
        Public Property MShipQty() As String
            Get
                Return Me.mShipQtyField
            End Get
            Set
                Me.mShipQtyField = value
            End Set
        End Property
        
        Public Property MBackOrderQty() As String
            Get
                Return Me.mBackOrderQtyField
            End Get
            Set
                Me.mBackOrderQtyField = value
            End Set
        End Property
        
        Public Property MStockQtyToShp() As String
            Get
                Return Me.mStockQtyToShpField
            End Get
            Set
                Me.mStockQtyToShpField = value
            End Set
        End Property
        
        Public Property PricingQtyShip() As String
            Get
                Return Me.pricingQtyShipField
            End Get
            Set
                Me.pricingQtyShipField = value
            End Set
        End Property
        
        Public Property MOrderUom() As String
            Get
                Return Me.mOrderUomField
            End Get
            Set
                Me.mOrderUomField = value
            End Set
        End Property
        
        Public Property MStockingUom() As String
            Get
                Return Me.mStockingUomField
            End Get
            Set
                Me.mStockingUomField = value
            End Set
        End Property
        
        Public Property MStockCode() As String
            Get
                Return Me.mStockCodeField
            End Get
            Set
                Me.mStockCodeField = value
            End Set
        End Property
        
        Public Property MStockDes() As String
            Get
                Return Me.mStockDesField
            End Get
            Set
                Me.mStockDesField = value
            End Set
        End Property
        
        Public Property MWarehouse() As String
            Get
                Return Me.mWarehouseField
            End Get
            Set
                Me.mWarehouseField = value
            End Set
        End Property
        
        Public Property MBin() As String
            Get
                Return Me.mBinField
            End Get
            Set
                Me.mBinField = value
            End Set
        End Property
        
        Public Property MLineShipDate() As String
            Get
                Return Me.mLineShipDateField
            End Get
            Set
                Me.mLineShipDateField = value
            End Set
        End Property
        
        Public Property MCustRequestDat() As String
            Get
                Return Me.mCustRequestDatField
            End Get
            Set
                Me.mCustRequestDatField = value
            End Set
        End Property
        
        Public Property MContract() As Object
            Get
                Return Me.mContractField
            End Get
            Set
                Me.mContractField = value
            End Set
        End Property
        
        Public Property MBuyingGroup() As Object
            Get
                Return Me.mBuyingGroupField
            End Get
            Set
                Me.mBuyingGroupField = value
            End Set
        End Property
        
        Public Property MCusSupStkCode() As Object
            Get
                Return Me.mCusSupStkCodeField
            End Get
            Set
                Me.mCusSupStkCodeField = value
            End Set
        End Property
        
        Public Property MCusRetailPrice() As String
            Get
                Return Me.mCusRetailPriceField
            End Get
            Set
                Me.mCusRetailPriceField = value
            End Set
        End Property
        
        Public Property CusGrossProfitPerc() As String
            Get
                Return Me.cusGrossProfitPercField
            End Get
            Set
                Me.cusGrossProfitPercField = value
            End Set
        End Property
        
        Public Property DetCustTotalRetail() As String
            Get
                Return Me.detCustTotalRetailField
            End Get
            Set
                Me.detCustTotalRetailField = value
            End Set
        End Property
        
        Public Property LongDesc() As Object
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property OtherUm() As String
            Get
                Return Me.otherUmField
            End Get
            Set
                Me.otherUmField = value
            End Set
        End Property
        
        Public Property UserField1() As Object
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        Public Property UserField3() As String
            Get
                Return Me.userField3Field
            End Get
            Set
                Me.userField3Field = value
            End Set
        End Property
        
        Public Property UserField4() As String
            Get
                Return Me.userField4Field
            End Get
            Set
                Me.userField4Field = value
            End Set
        End Property
        
        Public Property UserField5() As String
            Get
                Return Me.userField5Field
            End Get
            Set
                Me.userField5Field = value
            End Set
        End Property
        
        Public Property MUserDef() As String
            Get
                Return Me.mUserDefField
            End Get
            Set
                Me.mUserDefField = value
            End Set
        End Property
        
        Public Property MStockUnitVol() As String
            Get
                Return Me.mStockUnitVolField
            End Get
            Set
                Me.mStockUnitVolField = value
            End Set
        End Property
        
        Public Property LineVolume() As String
            Get
                Return Me.lineVolumeField
            End Get
            Set
                Me.lineVolumeField = value
            End Set
        End Property
        
        Public Property MStockUnitMass() As String
            Get
                Return Me.mStockUnitMassField
            End Get
            Set
                Me.mStockUnitMassField = value
            End Set
        End Property
        
        Public Property LineMass() As String
            Get
                Return Me.lineMassField
            End Get
            Set
                Me.lineMassField = value
            End Set
        End Property
        
        Public Property LineMassRounded() As String
            Get
                Return Me.lineMassRoundedField
            End Get
            Set
                Me.lineMassRoundedField = value
            End Set
        End Property
        
        Public Property LineVolRounded() As String
            Get
                Return Me.lineVolRoundedField
            End Get
            Set
                Me.lineVolRoundedField = value
            End Set
        End Property
        
        Public Property MPriceCode() As String
            Get
                Return Me.mPriceCodeField
            End Get
            Set
                Me.mPriceCodeField = value
            End Set
        End Property
        
        Public Property MPrice() As String
            Get
                Return Me.mPriceField
            End Get
            Set
                Me.mPriceField = value
            End Set
        End Property
        
        Public Property NetUnitPrice() As String
            Get
                Return Me.netUnitPriceField
            End Get
            Set
                Me.netUnitPriceField = value
            End Set
        End Property
        
        Public Property UnitPriceInclTax() As String
            Get
                Return Me.unitPriceInclTaxField
            End Get
            Set
                Me.unitPriceInclTaxField = value
            End Set
        End Property
        
        Public Property UnitDiscount() As String
            Get
                Return Me.unitDiscountField
            End Get
            Set
                Me.unitDiscountField = value
            End Set
        End Property
        
        Public Property UnitPriceInOrderUm() As String
            Get
                Return Me.unitPriceInOrderUmField
            End Get
            Set
                Me.unitPriceInOrderUmField = value
            End Set
        End Property
        
        Public Property MTariffcode() As Object
            Get
                Return Me.mTariffcodeField
            End Get
            Set
                Me.mTariffcodeField = value
            End Set
        End Property
        
        Public Property MSupplementaryUn() As String
            Get
                Return Me.mSupplementaryUnField
            End Get
            Set
                Me.mSupplementaryUnField = value
            End Set
        End Property
        
        Public Property MPriceUom() As String
            Get
                Return Me.mPriceUomField
            End Get
            Set
                Me.mPriceUomField = value
            End Set
        End Property
        
        Public Property MDiscPct1() As String
            Get
                Return Me.mDiscPct1Field
            End Get
            Set
                Me.mDiscPct1Field = value
            End Set
        End Property
        
        Public Property MDiscPct2() As String
            Get
                Return Me.mDiscPct2Field
            End Get
            Set
                Me.mDiscPct2Field = value
            End Set
        End Property
        
        Public Property MDiscPct3() As String
            Get
                Return Me.mDiscPct3Field
            End Get
            Set
                Me.mDiscPct3Field = value
            End Set
        End Property
        
        Public Property LineDiscValue() As String
            Get
                Return Me.lineDiscValueField
            End Get
            Set
                Me.lineDiscValueField = value
            End Set
        End Property
        
        Public Property LineSalesTax() As String
            Get
                Return Me.lineSalesTaxField
            End Get
            Set
                Me.lineSalesTaxField = value
            End Set
        End Property
        
        Public Property LineGrossamount() As String
            Get
                Return Me.lineGrossamountField
            End Get
            Set
                Me.lineGrossamountField = value
            End Set
        End Property
        
        Public Property LineNetAfterDisc() As String
            Get
                Return Me.lineNetAfterDiscField
            End Get
            Set
                Me.lineNetAfterDiscField = value
            End Set
        End Property
        
        Public Property MTaxCode() As String
            Get
                Return Me.mTaxCodeField
            End Get
            Set
                Me.mTaxCodeField = value
            End Set
        End Property
        
        Public Property LineTaxPerc() As String
            Get
                Return Me.lineTaxPercField
            End Get
            Set
                Me.lineTaxPercField = value
            End Set
        End Property
        
        Public Property LineNetInclTax() As String
            Get
                Return Me.lineNetInclTaxField
            End Get
            Set
                Me.lineNetInclTaxField = value
            End Set
        End Property
        
        Public Property MConvFactOrdUm() As String
            Get
                Return Me.mConvFactOrdUmField
            End Get
            Set
                Me.mConvFactOrdUmField = value
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
        
        Public Property MProductClass() As String
            Get
                Return Me.mProductClassField
            End Get
            Set
                Me.mProductClassField = value
            End Set
        End Property
        
        Public Property PalletQty() As String
            Get
                Return Me.palletQtyField
            End Get
            Set
                Me.palletQtyField = value
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
        
        Public Property MVersion() As Object
            Get
                Return Me.mVersionField
            End Get
            Set
                Me.mVersionField = value
            End Set
        End Property
        
        Public Property MRelease() As Object
            Get
                Return Me.mReleaseField
            End Get
            Set
                Me.mReleaseField = value
            End Set
        End Property
        
        Public Property Lots() As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseLots
            Get
                Return Me.lotsField
            End Get
            Set
                Me.lotsField = value
            End Set
        End Property
        
        Public Property Bins() As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseBins
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        Public Property Serials() As SorSalesOrderDocumentsSalesOrderDocumentMerchandiseSerials
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentMerchandiseLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private certificateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
        
        Public Property Certificate() As String
            Get
                Return Me.certificateField
            End Get
            Set
                Me.certificateField = value
            End Set
        End Property
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
        
        Public Property LotExpiryDate() As String
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentMerchandiseBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
            End Set
        End Property
        
        Public Property Bin() As String
            Get
                Return Me.binField
            End Get
            Set
                Me.binField = value
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
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentMerchandiseSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockQtyToShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private locationField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
            End Set
        End Property
        
        Public Property Serial() As String
            Get
                Return Me.serialField
            End Get
            Set
                Me.serialField = value
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
        
        Public Property StockQtyToShip() As String
            Get
                Return Me.stockQtyToShipField
            End Get
            Set
                Me.stockQtyToShipField = value
            End Set
        End Property
        
        Public Property SerialDescription() As String
            Get
                Return Me.serialDescriptionField
            End Get
            Set
                Me.serialDescriptionField = value
            End Set
        End Property
        
        Public Property ExpiryDate() As String
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = value
            End Set
        End Property
        
        Public Property Location() As String
            Get
                Return Me.locationField
            End Get
            Set
                Me.locationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMscNetAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscTaxCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMscChargeTaxAmtField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        Public Property LineMscNetAmount() As String
            Get
                Return Me.lineMscNetAmountField
            End Get
            Set
                Me.lineMscNetAmountField = value
            End Set
        End Property
        
        Public Property NMscTaxCode() As Object
            Get
                Return Me.nMscTaxCodeField
            End Get
            Set
                Me.nMscTaxCodeField = value
            End Set
        End Property
        
        Public Property LineMscChargeTaxAmt() As String
            Get
                Return Me.lineMscChargeTaxAmtField
            End Get
            Set
                Me.lineMscChargeTaxAmtField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMscNetAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscTaxCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineMscChargeTaxAmtField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        Public Property LineMscNetAmount() As String
            Get
                Return Me.lineMscNetAmountField
            End Get
            Set
                Me.lineMscNetAmountField = value
            End Set
        End Property
        
        Public Property NMscTaxCode() As Object
            Get
                Return Me.nMscTaxCodeField
            End Get
            Set
                Me.nMscTaxCodeField = value
            End Set
        End Property
        
        Public Property LineMscChargeTaxAmt() As String
            Get
                Return Me.lineMscChargeTaxAmtField
            End Get
            Set
                Me.lineMscChargeTaxAmtField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentComment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property LineNumber() As String
            Get
                Return Me.lineNumberField
            End Get
            Set
                Me.lineNumberField = value
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
        
        Public Property NComment() As String
            Get
                Return Me.nCommentField
            End Get
            Set
                Me.nCommentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesTaxField As SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTax
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hashQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hashQuantityOrdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hashQuantityShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hashQuantityUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hashQuantityPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalMassRoundedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalVolumeRoundedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalGrossAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalNetAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalLineDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalInvDiscountAmtField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalNetAmtInclTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalInvoiceAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalInvAmtExclTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalFreightAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalMiscChargesAmtField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalFreightTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalMiscChgTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalFrghtAmtIncTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalMiscChgIncTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentText1Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentText2Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentText3Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentText4Field As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCashDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalInvLessDiscField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalCustRetailField As String
        
        Public Sub New()
            MyBase.New
            If (Me.salesTaxField Is Nothing) Then
                Me.salesTaxField = New SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTax
            End If
        End Sub
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property SalesTax() As SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTax
            Get
                Return Me.salesTaxField
            End Get
            Set
                Me.salesTaxField = value
            End Set
        End Property
        
        Public Property HashQuantity() As String
            Get
                Return Me.hashQuantityField
            End Get
            Set
                Me.hashQuantityField = value
            End Set
        End Property
        
        Public Property HashQuantityOrd() As String
            Get
                Return Me.hashQuantityOrdField
            End Get
            Set
                Me.hashQuantityOrdField = value
            End Set
        End Property
        
        Public Property HashQuantityShip() As String
            Get
                Return Me.hashQuantityShipField
            End Get
            Set
                Me.hashQuantityShipField = value
            End Set
        End Property
        
        Public Property HashQuantityUnits() As String
            Get
                Return Me.hashQuantityUnitsField
            End Get
            Set
                Me.hashQuantityUnitsField = value
            End Set
        End Property
        
        Public Property HashQuantityPieces() As String
            Get
                Return Me.hashQuantityPiecesField
            End Get
            Set
                Me.hashQuantityPiecesField = value
            End Set
        End Property
        
        Public Property TotalMass() As String
            Get
                Return Me.totalMassField
            End Get
            Set
                Me.totalMassField = value
            End Set
        End Property
        
        Public Property TotalVolume() As String
            Get
                Return Me.totalVolumeField
            End Get
            Set
                Me.totalVolumeField = value
            End Set
        End Property
        
        Public Property TotalMassRounded() As String
            Get
                Return Me.totalMassRoundedField
            End Get
            Set
                Me.totalMassRoundedField = value
            End Set
        End Property
        
        Public Property TotalVolumeRounded() As String
            Get
                Return Me.totalVolumeRoundedField
            End Get
            Set
                Me.totalVolumeRoundedField = value
            End Set
        End Property
        
        Public Property TotalGrossAmount() As String
            Get
                Return Me.totalGrossAmountField
            End Get
            Set
                Me.totalGrossAmountField = value
            End Set
        End Property
        
        Public Property TotalNetAmount() As String
            Get
                Return Me.totalNetAmountField
            End Get
            Set
                Me.totalNetAmountField = value
            End Set
        End Property
        
        Public Property TotalLineDiscount() As String
            Get
                Return Me.totalLineDiscountField
            End Get
            Set
                Me.totalLineDiscountField = value
            End Set
        End Property
        
        Public Property TotalInvDiscountAmt() As String
            Get
                Return Me.totalInvDiscountAmtField
            End Get
            Set
                Me.totalInvDiscountAmtField = value
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
        
        Public Property TotalNetAmtInclTax() As String
            Get
                Return Me.totalNetAmtInclTaxField
            End Get
            Set
                Me.totalNetAmtInclTaxField = value
            End Set
        End Property
        
        Public Property TotalSalesTax() As String
            Get
                Return Me.totalSalesTaxField
            End Get
            Set
                Me.totalSalesTaxField = value
            End Set
        End Property
        
        Public Property TotalInvoiceAmount() As String
            Get
                Return Me.totalInvoiceAmountField
            End Get
            Set
                Me.totalInvoiceAmountField = value
            End Set
        End Property
        
        Public Property TotalInvAmtExclTax() As String
            Get
                Return Me.totalInvAmtExclTaxField
            End Get
            Set
                Me.totalInvAmtExclTaxField = value
            End Set
        End Property
        
        Public Property TotalFreightAmount() As String
            Get
                Return Me.totalFreightAmountField
            End Get
            Set
                Me.totalFreightAmountField = value
            End Set
        End Property
        
        Public Property TotalMiscChargesAmt() As String
            Get
                Return Me.totalMiscChargesAmtField
            End Get
            Set
                Me.totalMiscChargesAmtField = value
            End Set
        End Property
        
        Public Property TotalFreightTax() As String
            Get
                Return Me.totalFreightTaxField
            End Get
            Set
                Me.totalFreightTaxField = value
            End Set
        End Property
        
        Public Property TotalMiscChgTax() As String
            Get
                Return Me.totalMiscChgTaxField
            End Get
            Set
                Me.totalMiscChgTaxField = value
            End Set
        End Property
        
        Public Property TotalFrghtAmtIncTax() As String
            Get
                Return Me.totalFrghtAmtIncTaxField
            End Get
            Set
                Me.totalFrghtAmtIncTaxField = value
            End Set
        End Property
        
        Public Property TotalMiscChgIncTax() As String
            Get
                Return Me.totalMiscChgIncTaxField
            End Get
            Set
                Me.totalMiscChgIncTaxField = value
            End Set
        End Property
        
        Public Property CommentText1() As Object
            Get
                Return Me.commentText1Field
            End Get
            Set
                Me.commentText1Field = value
            End Set
        End Property
        
        Public Property CommentText2() As Object
            Get
                Return Me.commentText2Field
            End Get
            Set
                Me.commentText2Field = value
            End Set
        End Property
        
        Public Property CommentText3() As Object
            Get
                Return Me.commentText3Field
            End Get
            Set
                Me.commentText3Field = value
            End Set
        End Property
        
        Public Property CommentText4() As Object
            Get
                Return Me.commentText4Field
            End Get
            Set
                Me.commentText4Field = value
            End Set
        End Property
        
        Public Property TotalCashDiscount() As String
            Get
                Return Me.totalCashDiscountField
            End Get
            Set
                Me.totalCashDiscountField = value
            End Set
        End Property
        
        Public Property TotalInvLessDisc() As String
            Get
                Return Me.totalInvLessDiscField
            End Get
            Set
                Me.totalInvLessDiscField = value
            End Set
        End Property
        
        Public Property TotalCustRetail() As String
            Get
                Return Me.totalCustRetailField
            End Get
            Set
                Me.totalCustRetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTax
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesTaxDetailsField As SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTaxSalesTaxDetails
        
        Public Sub New()
            MyBase.New
            If (Me.salesTaxDetailsField Is Nothing) Then
                Me.salesTaxDetailsField = New SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTaxSalesTaxDetails
            End If
        End Sub
        
        Public Property SalesTaxDetails() As SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTaxSalesTaxDetails
            Get
                Return Me.salesTaxDetailsField
            End Get
            Set
                Me.salesTaxDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SorSalesOrderDocumentsSalesOrderDocumentTotalsSalesTaxSalesTaxDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountTaxableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesTaxPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesTaxAmountField As String
        
        Public Property DocumentNumber() As String
            Get
                Return Me.documentNumberField
            End Get
            Set
                Me.documentNumberField = value
            End Set
        End Property
        
        Public Property SalesTaxCode() As String
            Get
                Return Me.salesTaxCodeField
            End Get
            Set
                Me.salesTaxCodeField = value
            End Set
        End Property
        
        Public Property AmountTaxable() As String
            Get
                Return Me.amountTaxableField
            End Get
            Set
                Me.amountTaxableField = value
            End Set
        End Property
        
        Public Property SalesTaxPercentage() As String
            Get
                Return Me.salesTaxPercentageField
            End Get
            Set
                Me.salesTaxPercentageField = value
            End Set
        End Property
        
        Public Property SalesTaxAmount() As String
            Get
                Return Me.salesTaxAmountField
            End Get
            Set
                Me.salesTaxAmountField = value
            End Set
        End Property
    End Class
End Namespace
