Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryQuery.CustomerQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ARStatement
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ARStatementSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headerField As ARStatementHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDetailField As List(Of ARStatementInvoiceDetail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payDetailField As ARStatementPayDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postDatedField As ARStatementPostDated
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalSectionField As ARStatementTotalSection
        
        Public Sub New()
            MyBase.New
            If (Me.totalSectionField Is Nothing) Then
                Me.totalSectionField = New ARStatementTotalSection
            End If
            If (Me.postDatedField Is Nothing) Then
                Me.postDatedField = New ARStatementPostDated
            End If
            If (Me.payDetailField Is Nothing) Then
                Me.payDetailField = New ARStatementPayDetail
            End If
            If (Me.invoiceDetailField Is Nothing) Then
                Me.invoiceDetailField = New List(Of ARStatementInvoiceDetail)
            End If
            If (Me.headerField Is Nothing) Then
                Me.headerField = New ARStatementHeader
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ARStatementSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ARStatementSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property Header() As ARStatementHeader
            Get
                Return Me.headerField
            End Get
            Set
                Me.headerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("InvoiceDetail")>  _
        Public Property InvoiceDetailCollection() As List(Of ARStatementInvoiceDetail)
            Get
                Return Me.invoiceDetailField
            End Get
            Set
                Me.invoiceDetailField = value
            End Set
        End Property
        
        Public Property PayDetail() As ARStatementPayDetail
            Get
                Return Me.payDetailField
            End Get
            Set
                Me.payDetailField = value
            End Set
        End Property
        
        Public Property PostDated() As ARStatementPostDated
            Get
                Return Me.postDatedField
            End Get
            Set
                Me.postDatedField = value
            End Set
        End Property
        
        Public Property TotalSection() As ARStatementTotalSection
            Get
                Return Me.totalSectionField
            End Get
            Set
                Me.totalSectionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementSystemInformation
        
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
    Partial Public Class ARStatementHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compTaxNoField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private compRegNoField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
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
        Private soldPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALSLS_NameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statementDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private termsCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLART_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLCUR_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditLimitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditCheckFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shortNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private masterAccountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private storeNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balanceTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastSaleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastPayField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstOrdValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numOutstOrdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addTelephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telexField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneExtnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractPrcReqdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private backOrdReqdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCustAddedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private highestBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerOnHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediSenderCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private docFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private docFaxContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALBRN_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNotesField As ARStatementHeaderCustomerNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private managementNotesField As ARStatementHeaderManagementNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private additionalNotesField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private imageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customFormField As String
        
        Public Sub New()
            MyBase.New
            If (Me.additionalNotesField Is Nothing) Then
                Me.additionalNotesField = New List(Of String)
            End If
            If (Me.managementNotesField Is Nothing) Then
                Me.managementNotesField = New ARStatementHeaderManagementNotes
            End If
            If (Me.customerNotesField Is Nothing) Then
                Me.customerNotesField = New ARStatementHeaderCustomerNotes
            End If
        End Sub
        
        Public Property CompanyName() As String
            Get
                Return Me.companyNameField
            End Get
            Set
                Me.companyNameField = value
            End Set
        End Property
        
        Public Property CompAddress1() As String
            Get
                Return Me.compAddress1Field
            End Get
            Set
                Me.compAddress1Field = value
            End Set
        End Property
        
        Public Property CompAddress2() As String
            Get
                Return Me.compAddress2Field
            End Get
            Set
                Me.compAddress2Field = value
            End Set
        End Property
        
        Public Property CompAddress3() As String
            Get
                Return Me.compAddress3Field
            End Get
            Set
                Me.compAddress3Field = value
            End Set
        End Property
        
        Public Property CompTaxNo() As String
            Get
                Return Me.compTaxNoField
            End Get
            Set
                Me.compTaxNoField = value
            End Set
        End Property
        
        Public Property CompRegNo() As String
            Get
                Return Me.compRegNoField
            End Get
            Set
                Me.compRegNoField = value
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
        
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
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
        
        Public Property SoldPostalCode() As String
            Get
                Return Me.soldPostalCodeField
            End Get
            Set
                Me.soldPostalCodeField = value
            End Set
        End Property
        
        Public Property SALSLS_Name() As String
            Get
                Return Me.sALSLS_NameField
            End Get
            Set
                Me.sALSLS_NameField = value
            End Set
        End Property
        
        Public Property StatementDate() As String
            Get
                Return Me.statementDateField
            End Get
            Set
                Me.statementDateField = value
            End Set
        End Property
        
        Public Property TermsCode() As String
            Get
                Return Me.termsCodeField
            End Get
            Set
                Me.termsCodeField = value
            End Set
        End Property
        
        Public Property TBLART_Description() As String
            Get
                Return Me.tBLART_DescriptionField
            End Get
            Set
                Me.tBLART_DescriptionField = value
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
        
        Public Property TBLCUR_Description() As String
            Get
                Return Me.tBLCUR_DescriptionField
            End Get
            Set
                Me.tBLCUR_DescriptionField = value
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
        
        Public Property CreditLimit() As String
            Get
                Return Me.creditLimitField
            End Get
            Set
                Me.creditLimitField = value
            End Set
        End Property
        
        Public Property CreditCheckFlag() As String
            Get
                Return Me.creditCheckFlagField
            End Get
            Set
                Me.creditCheckFlagField = value
            End Set
        End Property
        
        Public Property ShortName() As String
            Get
                Return Me.shortNameField
            End Get
            Set
                Me.shortNameField = value
            End Set
        End Property
        
        Public Property CustomerType() As String
            Get
                Return Me.customerTypeField
            End Get
            Set
                Me.customerTypeField = value
            End Set
        End Property
        
        Public Property MasterAccount() As String
            Get
                Return Me.masterAccountField
            End Get
            Set
                Me.masterAccountField = value
            End Set
        End Property
        
        Public Property StoreNumber() As String
            Get
                Return Me.storeNumberField
            End Get
            Set
                Me.storeNumberField = value
            End Set
        End Property
        
        Public Property CreditStatus() As String
            Get
                Return Me.creditStatusField
            End Get
            Set
                Me.creditStatusField = value
            End Set
        End Property
        
        Public Property InvoiceCount() As String
            Get
                Return Me.invoiceCountField
            End Get
            Set
                Me.invoiceCountField = value
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
        
        Public Property CustomerClass() As String
            Get
                Return Me.customerClassField
            End Get
            Set
                Me.customerClassField = value
            End Set
        End Property
        
        Public Property InvDiscCode() As String
            Get
                Return Me.invDiscCodeField
            End Get
            Set
                Me.invDiscCodeField = value
            End Set
        End Property
        
        Public Property LineDiscCode() As String
            Get
                Return Me.lineDiscCodeField
            End Get
            Set
                Me.lineDiscCodeField = value
            End Set
        End Property
        
        Public Property BalanceType() As String
            Get
                Return Me.balanceTypeField
            End Get
            Set
                Me.balanceTypeField = value
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
        
        Public Property TaxStatus() As String
            Get
                Return Me.taxStatusField
            End Get
            Set
                Me.taxStatusField = value
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
        
        Public Property DateLastSale() As String
            Get
                Return Me.dateLastSaleField
            End Get
            Set
                Me.dateLastSaleField = value
            End Set
        End Property
        
        Public Property DateLastPay() As String
            Get
                Return Me.dateLastPayField
            End Get
            Set
                Me.dateLastPayField = value
            End Set
        End Property
        
        Public Property OutstOrdVal() As String
            Get
                Return Me.outstOrdValField
            End Get
            Set
                Me.outstOrdValField = value
            End Set
        End Property
        
        Public Property NumOutstOrd() As String
            Get
                Return Me.numOutstOrdField
            End Get
            Set
                Me.numOutstOrdField = value
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
        
        Public Property AddTelephone() As String
            Get
                Return Me.addTelephoneField
            End Get
            Set
                Me.addTelephoneField = value
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
        
        Public Property TelephoneExtn() As String
            Get
                Return Me.telephoneExtnField
            End Get
            Set
                Me.telephoneExtnField = value
            End Set
        End Property
        
        Public Property UserField1() As String
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
        
        Public Property GstExemptFlag() As String
            Get
                Return Me.gstExemptFlagField
            End Get
            Set
                Me.gstExemptFlagField = value
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
        
        Public Property ContractPrcReqd() As String
            Get
                Return Me.contractPrcReqdField
            End Get
            Set
                Me.contractPrcReqdField = value
            End Set
        End Property
        
        Public Property BackOrdReqd() As String
            Get
                Return Me.backOrdReqdField
            End Get
            Set
                Me.backOrdReqdField = value
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
        
        Public Property StateCode() As String
            Get
                Return Me.stateCodeField
            End Get
            Set
                Me.stateCodeField = value
            End Set
        End Property
        
        Public Property DateCustAdded() As String
            Get
                Return Me.dateCustAddedField
            End Get
            Set
                Me.dateCustAddedField = value
            End Set
        End Property
        
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        Public Property HighestBalance() As String
            Get
                Return Me.highestBalanceField
            End Get
            Set
                Me.highestBalanceField = value
            End Set
        End Property
        
        Public Property CustomerOnHold() As String
            Get
                Return Me.customerOnHoldField
            End Get
            Set
                Me.customerOnHoldField = value
            End Set
        End Property
        
        Public Property EdiSenderCode() As String
            Get
                Return Me.ediSenderCodeField
            End Get
            Set
                Me.ediSenderCodeField = value
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
        
        Public Property DocFax() As String
            Get
                Return Me.docFaxField
            End Get
            Set
                Me.docFaxField = value
            End Set
        End Property
        
        Public Property DocFaxContact() As String
            Get
                Return Me.docFaxContactField
            End Get
            Set
                Me.docFaxContactField = value
            End Set
        End Property
        
        Public Property ShipToAddr1() As String
            Get
                Return Me.shipToAddr1Field
            End Get
            Set
                Me.shipToAddr1Field = value
            End Set
        End Property
        
        Public Property ShipToAddr2() As String
            Get
                Return Me.shipToAddr2Field
            End Get
            Set
                Me.shipToAddr2Field = value
            End Set
        End Property
        
        Public Property ShipToAddr3() As String
            Get
                Return Me.shipToAddr3Field
            End Get
            Set
                Me.shipToAddr3Field = value
            End Set
        End Property
        
        Public Property ShipToAddr4() As String
            Get
                Return Me.shipToAddr4Field
            End Get
            Set
                Me.shipToAddr4Field = value
            End Set
        End Property
        
        Public Property ShipToAddr5() As String
            Get
                Return Me.shipToAddr5Field
            End Get
            Set
                Me.shipToAddr5Field = value
            End Set
        End Property
        
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
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
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property SALBRN_Description() As String
            Get
                Return Me.sALBRN_DescriptionField
            End Get
            Set
                Me.sALBRN_DescriptionField = value
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
        
        Public Property CustomerNotes() As ARStatementHeaderCustomerNotes
            Get
                Return Me.customerNotesField
            End Get
            Set
                Me.customerNotesField = value
            End Set
        End Property
        
        Public Property ManagementNotes() As ARStatementHeaderManagementNotes
            Get
                Return Me.managementNotesField
            End Get
            Set
                Me.managementNotesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable:=false)>  _
        Public Property AdditionalNotesCollection() As List(Of String)
            Get
                Return Me.additionalNotesField
            End Get
            Set
                Me.additionalNotesField = value
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
        
        Public Property CustomForm() As String
            Get
                Return Me.customFormField
            End Get
            Set
                Me.customFormField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementHeaderCustomerNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastModifiedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textField Is Nothing) Then
                Me.textField = New List(Of String)
            End If
        End Sub
        
        Public Property DateLastModified() As String
            Get
                Return Me.dateLastModifiedField
            End Get
            Set
                Me.dateLastModifiedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Text")>  _
        Public Property TextCollection() As List(Of String)
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementHeaderManagementNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastModifiedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private followUpDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private isFollowUpDateDueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private textField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.textField Is Nothing) Then
                Me.textField = New List(Of String)
            End If
        End Sub
        
        Public Property DateLastModified() As String
            Get
                Return Me.dateLastModifiedField
            End Get
            Set
                Me.dateLastModifiedField = value
            End Set
        End Property
        
        Public Property FollowUpDate() As String
            Get
                Return Me.followUpDateField
            End Get
            Set
                Me.followUpDateField = value
            End Set
        End Property
        
        Public Property IsFollowUpDateDue() As String
            Get
                Return Me.isFollowUpDateDueField
            End Get
            Set
                Me.isFollowUpDateDueField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Text")>  _
        Public Property TextCollection() As List(Of String)
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementInvoiceDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLART_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceBalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastDelNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private proofOfDeliveryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private podReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private podEntryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private baseCurrencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignToLocalConversionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transDetailField As ARStatementInvoiceDetailTransDetail
        
        Public Sub New()
            MyBase.New
            If (Me.transDetailField Is Nothing) Then
                Me.transDetailField = New ARStatementInvoiceDetailTransDetail
            End If
        End Sub
        
        Public Property DocumentType() As String
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
            End Set
        End Property
        
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
            End Set
        End Property
        
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set
                Me.invoiceDateField = value
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
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        Public Property CurrencyValue() As String
            Get
                Return Me.currencyValueField
            End Get
            Set
                Me.currencyValueField = value
            End Set
        End Property
        
        Public Property TBLART_Description() As String
            Get
                Return Me.tBLART_DescriptionField
            End Get
            Set
                Me.tBLART_DescriptionField = value
            End Set
        End Property
        
        Public Property InvoiceBal() As String
            Get
                Return Me.invoiceBalField
            End Get
            Set
                Me.invoiceBalField = value
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
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property LastDelNote() As String
            Get
                Return Me.lastDelNoteField
            End Get
            Set
                Me.lastDelNoteField = value
            End Set
        End Property
        
        Public Property ProofOfDelivery() As String
            Get
                Return Me.proofOfDeliveryField
            End Get
            Set
                Me.proofOfDeliveryField = value
            End Set
        End Property
        
        Public Property PodReference() As String
            Get
                Return Me.podReferenceField
            End Get
            Set
                Me.podReferenceField = value
            End Set
        End Property
        
        Public Property PodEntryDate() As String
            Get
                Return Me.podEntryDateField
            End Get
            Set
                Me.podEntryDateField = value
            End Set
        End Property
        
        Public Property BaseCurrencyValue() As String
            Get
                Return Me.baseCurrencyValueField
            End Get
            Set
                Me.baseCurrencyValueField = value
            End Set
        End Property
        
        Public Property ConvRate() As String
            Get
                Return Me.convRateField
            End Get
            Set
                Me.convRateField = value
            End Set
        End Property
        
        Public Property MulDiv() As String
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
            End Set
        End Property
        
        Public Property ForeignToLocalConversion() As String
            Get
                Return Me.foreignToLocalConversionField
            End Get
            Set
                Me.foreignToLocalConversionField = value
            End Set
        End Property
        
        Public Property TransDetail() As ARStatementInvoiceDetailTransDetail
            Get
                Return Me.transDetailField
            End Get
            Set
                Me.transDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementInvoiceDetailTransDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private baseCurrencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignToLocalConversionField As String
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property TrnValue() As String
            Get
                Return Me.trnValueField
            End Get
            Set
                Me.trnValueField = value
            End Set
        End Property
        
        Public Property JournalDate() As String
            Get
                Return Me.journalDateField
            End Get
            Set
                Me.journalDateField = value
            End Set
        End Property
        
        Public Property DiscValue() As String
            Get
                Return Me.discValueField
            End Get
            Set
                Me.discValueField = value
            End Set
        End Property
        
        Public Property BaseCurrencyValue() As String
            Get
                Return Me.baseCurrencyValueField
            End Get
            Set
                Me.baseCurrencyValueField = value
            End Set
        End Property
        
        Public Property ConvRate() As String
            Get
                Return Me.convRateField
            End Get
            Set
                Me.convRateField = value
            End Set
        End Property
        
        Public Property MulDiv() As String
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
            End Set
        End Property
        
        Public Property ForeignToLocalConversion() As String
            Get
                Return Me.foreignToLocalConversionField
            End Get
            Set
                Me.foreignToLocalConversionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementPayDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymMonthField As String
        
        Public Property ChequeReference() As String
            Get
                Return Me.chequeReferenceField
            End Get
            Set
                Me.chequeReferenceField = value
            End Set
        End Property
        
        Public Property PayDate() As String
            Get
                Return Me.payDateField
            End Get
            Set
                Me.payDateField = value
            End Set
        End Property
        
        Public Property PayValue() As String
            Get
                Return Me.payValueField
            End Get
            Set
                Me.payValueField = value
            End Set
        End Property
        
        Public Property PaymYear() As String
            Get
                Return Me.paymYearField
            End Get
            Set
                Me.paymYearField = value
            End Set
        End Property
        
        Public Property PaymMonth() As String
            Get
                Return Me.paymMonthField
            End Get
            Set
                Me.paymMonthField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementPostDated
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        Public Property Cheque() As String
            Get
                Return Me.chequeField
            End Get
            Set
                Me.chequeField = value
            End Set
        End Property
        
        Public Property AvailableDate() As String
            Get
                Return Me.availableDateField
            End Get
            Set
                Me.availableDateField = value
            End Set
        End Property
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARStatementTotalSection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balBroughtFwdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueFutureInvField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days30Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days60Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days90Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days120Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days150Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days180Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountAvailableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unallocatedPDChqsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unavailablePDChqsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentLessPDChqsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentMsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days30MsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days60MsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days90MsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days120MsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days150MsgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private days180MsgField As String
        
        Public Property BalBroughtFwd() As String
            Get
                Return Me.balBroughtFwdField
            End Get
            Set
                Me.balBroughtFwdField = value
            End Set
        End Property
        
        Public Property CurrentBalance() As String
            Get
                Return Me.currentBalanceField
            End Get
            Set
                Me.currentBalanceField = value
            End Set
        End Property
        
        Public Property ValueFutureInv() As String
            Get
                Return Me.valueFutureInvField
            End Get
            Set
                Me.valueFutureInvField = value
            End Set
        End Property
        
        Public Property Current() As String
            Get
                Return Me.currentField
            End Get
            Set
                Me.currentField = value
            End Set
        End Property
        
        Public Property Days30() As String
            Get
                Return Me.days30Field
            End Get
            Set
                Me.days30Field = value
            End Set
        End Property
        
        Public Property Days60() As String
            Get
                Return Me.days60Field
            End Get
            Set
                Me.days60Field = value
            End Set
        End Property
        
        Public Property Days90() As String
            Get
                Return Me.days90Field
            End Get
            Set
                Me.days90Field = value
            End Set
        End Property
        
        Public Property Days120() As String
            Get
                Return Me.days120Field
            End Get
            Set
                Me.days120Field = value
            End Set
        End Property
        
        Public Property Days150() As String
            Get
                Return Me.days150Field
            End Get
            Set
                Me.days150Field = value
            End Set
        End Property
        
        Public Property Days180() As String
            Get
                Return Me.days180Field
            End Get
            Set
                Me.days180Field = value
            End Set
        End Property
        
        Public Property DiscountAvailable() As String
            Get
                Return Me.discountAvailableField
            End Get
            Set
                Me.discountAvailableField = value
            End Set
        End Property
        
        Public Property CreditBalance() As String
            Get
                Return Me.creditBalanceField
            End Get
            Set
                Me.creditBalanceField = value
            End Set
        End Property
        
        Public Property UnallocatedPDChqs() As String
            Get
                Return Me.unallocatedPDChqsField
            End Get
            Set
                Me.unallocatedPDChqsField = value
            End Set
        End Property
        
        Public Property UnavailablePDChqs() As String
            Get
                Return Me.unavailablePDChqsField
            End Get
            Set
                Me.unavailablePDChqsField = value
            End Set
        End Property
        
        Public Property CurrentLessPDChqs() As String
            Get
                Return Me.currentLessPDChqsField
            End Get
            Set
                Me.currentLessPDChqsField = value
            End Set
        End Property
        
        Public Property CurrentMsg() As String
            Get
                Return Me.currentMsgField
            End Get
            Set
                Me.currentMsgField = value
            End Set
        End Property
        
        Public Property Days30Msg() As String
            Get
                Return Me.days30MsgField
            End Get
            Set
                Me.days30MsgField = value
            End Set
        End Property
        
        Public Property Days60Msg() As String
            Get
                Return Me.days60MsgField
            End Get
            Set
                Me.days60MsgField = value
            End Set
        End Property
        
        Public Property Days90Msg() As String
            Get
                Return Me.days90MsgField
            End Get
            Set
                Me.days90MsgField = value
            End Set
        End Property
        
        Public Property Days120Msg() As String
            Get
                Return Me.days120MsgField
            End Get
            Set
                Me.days120MsgField = value
            End Set
        End Property
        
        Public Property Days150Msg() As String
            Get
                Return Me.days150MsgField
            End Get
            Set
                Me.days150MsgField = value
            End Set
        End Property
        
        Public Property Days180Msg() As String
            Get
                Return Me.days180MsgField
            End Get
            Set
                Me.days180MsgField = value
            End Set
        End Property
    End Class
End Namespace
