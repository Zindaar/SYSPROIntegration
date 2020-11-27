Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace APPrimaryQuery.SupplierQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ApQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ApQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As ApQuerySupplier
        
        Public Sub New()
            MyBase.New
            If (Me.supplierField Is Nothing) Then
                Me.supplierField = New ApQuerySupplier
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ApQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ApQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property Supplier() As ApQuerySupplier
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySystemInformation
        
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
    Partial Public Class ApQuerySupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private enquiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLAPT_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aPSBNK_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLCUR_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aPSBRN_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultChequeDayField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankAccountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxRegnNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchOrdAllowedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private firstPurchDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPurchDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poDefaultDocField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediTypeFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediReceiverCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdMerchValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdFreightValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdOtherValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDsbValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdTaxValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdTax2ValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdMerchValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdFreightValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdOtherValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdDsbValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdTaxValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdTax2ValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pyrMerchValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pyrFreightValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pyrOtherValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pyrDsbValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthlyPurchasesField As ApQuerySupplierMonthlyPurchases
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChequeDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChequeValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChequeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChequeBankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateSuppAddedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private managementNotesField As ApQuerySupplierManagementNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private imageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customFormField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoicesField As List(Of ApQuerySupplierInvoiceDetail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private registeredInvoicesField As ApQuerySupplierRegisteredInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cashProjectionField As ApQuerySupplierCashProjection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private goodsReceivedNotesField As List(Of ApQuerySupplierGRNDetail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptsField As List(Of ApQuerySupplierReceiptDetail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapAndRejectField As List(Of ApQuerySupplierScrapAndRejectDetail)
        
        Public Sub New()
            MyBase.New
            If (Me.scrapAndRejectField Is Nothing) Then
                Me.scrapAndRejectField = New List(Of ApQuerySupplierScrapAndRejectDetail)
            End If
            If (Me.receiptsField Is Nothing) Then
                Me.receiptsField = New List(Of ApQuerySupplierReceiptDetail)
            End If
            If (Me.goodsReceivedNotesField Is Nothing) Then
                Me.goodsReceivedNotesField = New List(Of ApQuerySupplierGRNDetail)
            End If
            If (Me.cashProjectionField Is Nothing) Then
                Me.cashProjectionField = New ApQuerySupplierCashProjection
            End If
            If (Me.registeredInvoicesField Is Nothing) Then
                Me.registeredInvoicesField = New ApQuerySupplierRegisteredInvoices
            End If
            If (Me.invoicesField Is Nothing) Then
                Me.invoicesField = New List(Of ApQuerySupplierInvoiceDetail)
            End If
            If (Me.managementNotesField Is Nothing) Then
                Me.managementNotesField = New ApQuerySupplierManagementNotes
            End If
            If (Me.monthlyPurchasesField Is Nothing) Then
                Me.monthlyPurchasesField = New ApQuerySupplierMonthlyPurchases
            End If
        End Sub
        
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
        
        Public Property EnquiryDate() As String
            Get
                Return Me.enquiryDateField
            End Get
            Set
                Me.enquiryDateField = value
            End Set
        End Property
        
        Public Property SupplierType() As String
            Get
                Return Me.supplierTypeField
            End Get
            Set
                Me.supplierTypeField = value
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
        
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
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
        
        Public Property OnHold() As String
            Get
                Return Me.onHoldField
            End Get
            Set
                Me.onHoldField = value
            End Set
        End Property
        
        Public Property DiscPct() As String
            Get
                Return Me.discPctField
            End Get
            Set
                Me.discPctField = value
            End Set
        End Property
        
        Public Property TBLAPT_Description() As String
            Get
                Return Me.tBLAPT_DescriptionField
            End Get
            Set
                Me.tBLAPT_DescriptionField = value
            End Set
        End Property
        
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        Public Property APSBNK_Description() As String
            Get
                Return Me.aPSBNK_DescriptionField
            End Get
            Set
                Me.aPSBNK_DescriptionField = value
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
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property APSBRN_Description() As String
            Get
                Return Me.aPSBRN_DescriptionField
            End Get
            Set
                Me.aPSBRN_DescriptionField = value
            End Set
        End Property
        
        Public Property SupplierClass() As String
            Get
                Return Me.supplierClassField
            End Get
            Set
                Me.supplierClassField = value
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
        
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        Public Property DefaultChequeDay() As String
            Get
                Return Me.defaultChequeDayField
            End Get
            Set
                Me.defaultChequeDayField = value
            End Set
        End Property
        
        Public Property BankAccount() As String
            Get
                Return Me.bankAccountField
            End Get
            Set
                Me.bankAccountField = value
            End Set
        End Property
        
        Public Property BankBranch() As String
            Get
                Return Me.bankBranchField
            End Get
            Set
                Me.bankBranchField = value
            End Set
        End Property
        
        Public Property TaxRegnNum() As String
            Get
                Return Me.taxRegnNumField
            End Get
            Set
                Me.taxRegnNumField = value
            End Set
        End Property
        
        Public Property SupAddr1() As String
            Get
                Return Me.supAddr1Field
            End Get
            Set
                Me.supAddr1Field = value
            End Set
        End Property
        
        Public Property SupAddr2() As String
            Get
                Return Me.supAddr2Field
            End Get
            Set
                Me.supAddr2Field = value
            End Set
        End Property
        
        Public Property SupAddr3() As String
            Get
                Return Me.supAddr3Field
            End Get
            Set
                Me.supAddr3Field = value
            End Set
        End Property
        
        Public Property SupAddr4() As String
            Get
                Return Me.supAddr4Field
            End Get
            Set
                Me.supAddr4Field = value
            End Set
        End Property
        
        Public Property SupAddr5() As String
            Get
                Return Me.supAddr5Field
            End Get
            Set
                Me.supAddr5Field = value
            End Set
        End Property
        
        Public Property SupPostalCode() As String
            Get
                Return Me.supPostalCodeField
            End Get
            Set
                Me.supPostalCodeField = value
            End Set
        End Property
        
        Public Property RemitName() As String
            Get
                Return Me.remitNameField
            End Get
            Set
                Me.remitNameField = value
            End Set
        End Property
        
        Public Property RemitAddr1() As String
            Get
                Return Me.remitAddr1Field
            End Get
            Set
                Me.remitAddr1Field = value
            End Set
        End Property
        
        Public Property RemitAddr2() As String
            Get
                Return Me.remitAddr2Field
            End Get
            Set
                Me.remitAddr2Field = value
            End Set
        End Property
        
        Public Property RemitAddr3() As String
            Get
                Return Me.remitAddr3Field
            End Get
            Set
                Me.remitAddr3Field = value
            End Set
        End Property
        
        Public Property RemitAddr4() As String
            Get
                Return Me.remitAddr4Field
            End Get
            Set
                Me.remitAddr4Field = value
            End Set
        End Property
        
        Public Property RemitAddr5() As String
            Get
                Return Me.remitAddr5Field
            End Get
            Set
                Me.remitAddr5Field = value
            End Set
        End Property
        
        Public Property RemitPostalCode() As String
            Get
                Return Me.remitPostalCodeField
            End Get
            Set
                Me.remitPostalCodeField = value
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
        
        Public Property PurchOrdAllowed() As String
            Get
                Return Me.purchOrdAllowedField
            End Get
            Set
                Me.purchOrdAllowedField = value
            End Set
        End Property
        
        Public Property Contracts() As String
            Get
                Return Me.contractsField
            End Get
            Set
                Me.contractsField = value
            End Set
        End Property
        
        Public Property FirstPurchDate() As String
            Get
                Return Me.firstPurchDateField
            End Get
            Set
                Me.firstPurchDateField = value
            End Set
        End Property
        
        Public Property LastPurchDate() As String
            Get
                Return Me.lastPurchDateField
            End Get
            Set
                Me.lastPurchDateField = value
            End Set
        End Property
        
        Public Property MinPoVal() As String
            Get
                Return Me.minPoValField
            End Get
            Set
                Me.minPoValField = value
            End Set
        End Property
        
        Public Property MinPoMass() As String
            Get
                Return Me.minPoMassField
            End Get
            Set
                Me.minPoMassField = value
            End Set
        End Property
        
        Public Property MinPoVolume() As String
            Get
                Return Me.minPoVolumeField
            End Get
            Set
                Me.minPoVolumeField = value
            End Set
        End Property
        
        Public Property PoDefaultDoc() As String
            Get
                Return Me.poDefaultDocField
            End Get
            Set
                Me.poDefaultDocField = value
            End Set
        End Property
        
        Public Property MerchGlCode() As String
            Get
                Return Me.merchGlCodeField
            End Get
            Set
                Me.merchGlCodeField = value
            End Set
        End Property
        
        Public Property FreightGlCode() As String
            Get
                Return Me.freightGlCodeField
            End Get
            Set
                Me.freightGlCodeField = value
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
        
        Public Property FaxContact() As String
            Get
                Return Me.faxContactField
            End Get
            Set
                Me.faxContactField = value
            End Set
        End Property
        
        Public Property EdiFax() As String
            Get
                Return Me.ediFaxField
            End Get
            Set
                Me.ediFaxField = value
            End Set
        End Property
        
        Public Property EdiTypeFlag() As String
            Get
                Return Me.ediTypeFlagField
            End Get
            Set
                Me.ediTypeFlagField = value
            End Set
        End Property
        
        Public Property EdiReceiverCode() As String
            Get
                Return Me.ediReceiverCodeField
            End Get
            Set
                Me.ediReceiverCodeField = value
            End Set
        End Property
        
        Public Property FaxRemitFlag() As String
            Get
                Return Me.faxRemitFlagField
            End Get
            Set
                Me.faxRemitFlagField = value
            End Set
        End Property
        
        Public Property FaxRemitNum() As String
            Get
                Return Me.faxRemitNumField
            End Get
            Set
                Me.faxRemitNumField = value
            End Set
        End Property
        
        Public Property FaxRemitContact() As String
            Get
                Return Me.faxRemitContactField
            End Get
            Set
                Me.faxRemitContactField = value
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
        
        Public Property MtdMerchVal() As String
            Get
                Return Me.mtdMerchValField
            End Get
            Set
                Me.mtdMerchValField = value
            End Set
        End Property
        
        Public Property MtdFreightVal() As String
            Get
                Return Me.mtdFreightValField
            End Get
            Set
                Me.mtdFreightValField = value
            End Set
        End Property
        
        Public Property MtdOtherVal() As String
            Get
                Return Me.mtdOtherValField
            End Get
            Set
                Me.mtdOtherValField = value
            End Set
        End Property
        
        Public Property MtdDsbVal() As String
            Get
                Return Me.mtdDsbValField
            End Get
            Set
                Me.mtdDsbValField = value
            End Set
        End Property
        
        Public Property MtdTaxVal() As String
            Get
                Return Me.mtdTaxValField
            End Get
            Set
                Me.mtdTaxValField = value
            End Set
        End Property
        
        Public Property MtdTax2Val() As String
            Get
                Return Me.mtdTax2ValField
            End Get
            Set
                Me.mtdTax2ValField = value
            End Set
        End Property
        
        Public Property YtdMerchVal() As String
            Get
                Return Me.ytdMerchValField
            End Get
            Set
                Me.ytdMerchValField = value
            End Set
        End Property
        
        Public Property YtdFreightVal() As String
            Get
                Return Me.ytdFreightValField
            End Get
            Set
                Me.ytdFreightValField = value
            End Set
        End Property
        
        Public Property YtdOtherVal() As String
            Get
                Return Me.ytdOtherValField
            End Get
            Set
                Me.ytdOtherValField = value
            End Set
        End Property
        
        Public Property YtdDsbVal() As String
            Get
                Return Me.ytdDsbValField
            End Get
            Set
                Me.ytdDsbValField = value
            End Set
        End Property
        
        Public Property YtdTaxVal() As String
            Get
                Return Me.ytdTaxValField
            End Get
            Set
                Me.ytdTaxValField = value
            End Set
        End Property
        
        Public Property YtdTax2Val() As String
            Get
                Return Me.ytdTax2ValField
            End Get
            Set
                Me.ytdTax2ValField = value
            End Set
        End Property
        
        Public Property PyrMerchVal() As String
            Get
                Return Me.pyrMerchValField
            End Get
            Set
                Me.pyrMerchValField = value
            End Set
        End Property
        
        Public Property PyrFreightVal() As String
            Get
                Return Me.pyrFreightValField
            End Get
            Set
                Me.pyrFreightValField = value
            End Set
        End Property
        
        Public Property PyrOtherVal() As String
            Get
                Return Me.pyrOtherValField
            End Get
            Set
                Me.pyrOtherValField = value
            End Set
        End Property
        
        Public Property PyrDsbVal() As String
            Get
                Return Me.pyrDsbValField
            End Get
            Set
                Me.pyrDsbValField = value
            End Set
        End Property
        
        Public Property MonthlyPurchases() As ApQuerySupplierMonthlyPurchases
            Get
                Return Me.monthlyPurchasesField
            End Get
            Set
                Me.monthlyPurchasesField = value
            End Set
        End Property
        
        Public Property LastChequeDate() As String
            Get
                Return Me.lastChequeDateField
            End Get
            Set
                Me.lastChequeDateField = value
            End Set
        End Property
        
        Public Property LastChequeVal() As String
            Get
                Return Me.lastChequeValField
            End Get
            Set
                Me.lastChequeValField = value
            End Set
        End Property
        
        Public Property LastCheque() As String
            Get
                Return Me.lastChequeField
            End Get
            Set
                Me.lastChequeField = value
            End Set
        End Property
        
        Public Property LastChequeBank() As String
            Get
                Return Me.lastChequeBankField
            End Get
            Set
                Me.lastChequeBankField = value
            End Set
        End Property
        
        Public Property DateSuppAdded() As String
            Get
                Return Me.dateSuppAddedField
            End Get
            Set
                Me.dateSuppAddedField = value
            End Set
        End Property
        
        Public Property ManagementNotes() As ApQuerySupplierManagementNotes
            Get
                Return Me.managementNotesField
            End Get
            Set
                Me.managementNotesField = value
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
        
        <System.Xml.Serialization.XmlArrayItemAttribute("InvoiceDetail", IsNullable:=false)>  _
        Public Property InvoicesCollection() As List(Of ApQuerySupplierInvoiceDetail)
            Get
                Return Me.invoicesField
            End Get
            Set
                Me.invoicesField = value
            End Set
        End Property
        
        Public Property RegisteredInvoices() As ApQuerySupplierRegisteredInvoices
            Get
                Return Me.registeredInvoicesField
            End Get
            Set
                Me.registeredInvoicesField = value
            End Set
        End Property
        
        Public Property CashProjection() As ApQuerySupplierCashProjection
            Get
                Return Me.cashProjectionField
            End Get
            Set
                Me.cashProjectionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("GRNDetail", IsNullable:=false)>  _
        Public Property GoodsReceivedNotesCollection() As List(Of ApQuerySupplierGRNDetail)
            Get
                Return Me.goodsReceivedNotesField
            End Get
            Set
                Me.goodsReceivedNotesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("ReceiptDetail", IsNullable:=false)>  _
        Public Property ReceiptsCollection() As List(Of ApQuerySupplierReceiptDetail)
            Get
                Return Me.receiptsField
            End Get
            Set
                Me.receiptsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("ScrapAndRejectDetail", IsNullable:=false)>  _
        Public Property ScrapAndRejectCollection() As List(Of ApQuerySupplierScrapAndRejectDetail)
            Get
                Return Me.scrapAndRejectField
            End Get
            Set
                Me.scrapAndRejectField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierMonthlyPurchases
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchValMth12Field As String
        
        Public Property PurchValMth1() As String
            Get
                Return Me.purchValMth1Field
            End Get
            Set
                Me.purchValMth1Field = value
            End Set
        End Property
        
        Public Property PurchValMth2() As String
            Get
                Return Me.purchValMth2Field
            End Get
            Set
                Me.purchValMth2Field = value
            End Set
        End Property
        
        Public Property PurchValMth3() As String
            Get
                Return Me.purchValMth3Field
            End Get
            Set
                Me.purchValMth3Field = value
            End Set
        End Property
        
        Public Property PurchValMth4() As String
            Get
                Return Me.purchValMth4Field
            End Get
            Set
                Me.purchValMth4Field = value
            End Set
        End Property
        
        Public Property PurchValMth5() As String
            Get
                Return Me.purchValMth5Field
            End Get
            Set
                Me.purchValMth5Field = value
            End Set
        End Property
        
        Public Property PurchValMth6() As String
            Get
                Return Me.purchValMth6Field
            End Get
            Set
                Me.purchValMth6Field = value
            End Set
        End Property
        
        Public Property PurchValMth7() As String
            Get
                Return Me.purchValMth7Field
            End Get
            Set
                Me.purchValMth7Field = value
            End Set
        End Property
        
        Public Property PurchValMth8() As String
            Get
                Return Me.purchValMth8Field
            End Get
            Set
                Me.purchValMth8Field = value
            End Set
        End Property
        
        Public Property PurchValMth9() As String
            Get
                Return Me.purchValMth9Field
            End Get
            Set
                Me.purchValMth9Field = value
            End Set
        End Property
        
        Public Property PurchValMth10() As String
            Get
                Return Me.purchValMth10Field
            End Get
            Set
                Me.purchValMth10Field = value
            End Set
        End Property
        
        Public Property PurchValMth11() As String
            Get
                Return Me.purchValMth11Field
            End Get
            Set
                Me.purchValMth11Field = value
            End Set
        End Property
        
        Public Property PurchValMth12() As String
            Get
                Return Me.purchValMth12Field
            End Get
            Set
                Me.purchValMth12Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierManagementNotes
        
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
    Partial Public Class ApQuerySupplierInvoiceDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origInvValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mthInvBalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymGrossValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private baseCurrencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignToLocalConversionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentsField As ApQuerySupplierInvoiceDetailPayments
        
        Public Sub New()
            MyBase.New
            If (Me.paymentsField Is Nothing) Then
                Me.paymentsField = New ApQuerySupplierInvoiceDetailPayments
            End If
        End Sub
        
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
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
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
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
        
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set
                Me.invoiceDateField = value
            End Set
        End Property
        
        Public Property DiscountDate() As String
            Get
                Return Me.discountDateField
            End Get
            Set
                Me.discountDateField = value
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
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property OrigInvValue() As String
            Get
                Return Me.origInvValueField
            End Get
            Set
                Me.origInvValueField = value
            End Set
        End Property
        
        Public Property OrigDiscValue() As String
            Get
                Return Me.origDiscValueField
            End Get
            Set
                Me.origDiscValueField = value
            End Set
        End Property
        
        Public Property MthInvBal() As String
            Get
                Return Me.mthInvBalField
            End Get
            Set
                Me.mthInvBalField = value
            End Set
        End Property
        
        Public Property InvoiceStatus() As String
            Get
                Return Me.invoiceStatusField
            End Get
            Set
                Me.invoiceStatusField = value
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
        
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        Public Property PaymGrossValue() As String
            Get
                Return Me.paymGrossValueField
            End Get
            Set
                Me.paymGrossValueField = value
            End Set
        End Property
        
        Public Property PaymDiscValue() As String
            Get
                Return Me.paymDiscValueField
            End Get
            Set
                Me.paymDiscValueField = value
            End Set
        End Property
        
        Public Property InvoiceYear() As String
            Get
                Return Me.invoiceYearField
            End Get
            Set
                Me.invoiceYearField = value
            End Set
        End Property
        
        Public Property InvoiceMonth() As String
            Get
                Return Me.invoiceMonthField
            End Get
            Set
                Me.invoiceMonthField = value
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
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
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
        
        Public Property ForeignToLocalConversion() As String
            Get
                Return Me.foreignToLocalConversionField
            End Get
            Set
                Me.foreignToLocalConversionField = value
            End Set
        End Property
        
        Public Property Payments() As ApQuerySupplierInvoiceDetailPayments
            Get
                Return Me.paymentsField
            End Get
            Set
                Me.paymentsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierInvoiceDetailPayments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentDetailField As ApQuerySupplierInvoiceDetailPaymentsPaymentDetail
        
        Public Sub New()
            MyBase.New
            If (Me.paymentDetailField Is Nothing) Then
                Me.paymentDetailField = New ApQuerySupplierInvoiceDetailPaymentsPaymentDetail
            End If
        End Sub
        
        Public Property PaymentDetail() As ApQuerySupplierInvoiceDetailPaymentsPaymentDetail
            Get
                Return Me.paymentDetailField
            End Get
            Set
                Me.paymentDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierInvoiceDetailPaymentsPaymentDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postMulDivField As String
        
        Public Property EntryNumber() As String
            Get
                Return Me.entryNumberField
            End Get
            Set
                Me.entryNumberField = value
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
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        Public Property PaymentReference() As String
            Get
                Return Me.paymentReferenceField
            End Get
            Set
                Me.paymentReferenceField = value
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
        
        Public Property TrnType() As String
            Get
                Return Me.trnTypeField
            End Get
            Set
                Me.trnTypeField = value
            End Set
        End Property
        
        Public Property PostValue() As String
            Get
                Return Me.postValueField
            End Get
            Set
                Me.postValueField = value
            End Set
        End Property
        
        Public Property PostCurrency() As String
            Get
                Return Me.postCurrencyField
            End Get
            Set
                Me.postCurrencyField = value
            End Set
        End Property
        
        Public Property PostConvRate() As String
            Get
                Return Me.postConvRateField
            End Get
            Set
                Me.postConvRateField = value
            End Set
        End Property
        
        Public Property PostMulDiv() As String
            Get
                Return Me.postMulDivField
            End Get
            Set
                Me.postMulDivField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierRegisteredInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private registeredInvoiceDetailField As ApQuerySupplierRegisteredInvoicesRegisteredInvoiceDetail
        
        Public Sub New()
            MyBase.New
            If (Me.registeredInvoiceDetailField Is Nothing) Then
                Me.registeredInvoiceDetailField = New ApQuerySupplierRegisteredInvoicesRegisteredInvoiceDetail
            End If
        End Sub
        
        Public Property RegisteredInvoiceDetail() As ApQuerySupplierRegisteredInvoicesRegisteredInvoiceDetail
            Get
                Return Me.registeredInvoiceDetailField
            End Get
            Set
                Me.registeredInvoiceDetailField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierRegisteredInvoicesRegisteredInvoiceDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discActiveFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchRateAtEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorisingPersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateInvoiceSentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateApprOrPurgField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private followUpDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invRegnStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceModifiedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastModifiedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invAppliedToLctField As String
        
        Public Property Invoice() As String
            Get
                Return Me.invoiceField
            End Get
            Set
                Me.invoiceField = value
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
        
        Public Property EntryDate() As String
            Get
                Return Me.entryDateField
            End Get
            Set
                Me.entryDateField = value
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
        
        Public Property DiscountDate() As String
            Get
                Return Me.discountDateField
            End Get
            Set
                Me.discountDateField = value
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
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property InvoiceValue() As String
            Get
                Return Me.invoiceValueField
            End Get
            Set
                Me.invoiceValueField = value
            End Set
        End Property
        
        Public Property DiscountValue() As String
            Get
                Return Me.discountValueField
            End Get
            Set
                Me.discountValueField = value
            End Set
        End Property
        
        Public Property DiscActiveFlag() As String
            Get
                Return Me.discActiveFlagField
            End Get
            Set
                Me.discActiveFlagField = value
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
        
        Public Property ExchRateAtEntry() As String
            Get
                Return Me.exchRateAtEntryField
            End Get
            Set
                Me.exchRateAtEntryField = value
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
        
        Public Property AuthorisingPerson() As String
            Get
                Return Me.authorisingPersonField
            End Get
            Set
                Me.authorisingPersonField = value
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
        
        Public Property DateInvoiceSent() As String
            Get
                Return Me.dateInvoiceSentField
            End Get
            Set
                Me.dateInvoiceSentField = value
            End Set
        End Property
        
        Public Property DateApprOrPurg() As String
            Get
                Return Me.dateApprOrPurgField
            End Get
            Set
                Me.dateApprOrPurgField = value
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
        
        Public Property Department() As String
            Get
                Return Me.departmentField
            End Get
            Set
                Me.departmentField = value
            End Set
        End Property
        
        Public Property InvRegnStatus() As String
            Get
                Return Me.invRegnStatusField
            End Get
            Set
                Me.invRegnStatusField = value
            End Set
        End Property
        
        Public Property InvoiceModified() As String
            Get
                Return Me.invoiceModifiedField
            End Get
            Set
                Me.invoiceModifiedField = value
            End Set
        End Property
        
        Public Property DateLastModified() As String
            Get
                Return Me.dateLastModifiedField
            End Get
            Set
                Me.dateLastModifiedField = value
            End Set
        End Property
        
        Public Property [Operator]() As String
            Get
                Return Me.operatorField
            End Get
            Set
                Me.operatorField = value
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
        
        Public Property InvAppliedToLct() As String
            Get
                Return Me.invAppliedToLctField
            End Get
            Set
                Me.invAppliedToLctField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pastDueField As ApQuerySupplierCashProjectionPastDue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentField As ApQuerySupplierCashProjectionCurrent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private age1Field As ApQuerySupplierCashProjectionAge1
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private age2Field As ApQuerySupplierCashProjectionAge2
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageOverField As ApQuerySupplierCashProjectionAgeOver
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalsField As ApQuerySupplierCashProjectionTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unapprovedField As ApQuerySupplierCashProjectionUnapproved
        
        Public Sub New()
            MyBase.New
            If (Me.unapprovedField Is Nothing) Then
                Me.unapprovedField = New ApQuerySupplierCashProjectionUnapproved
            End If
            If (Me.totalsField Is Nothing) Then
                Me.totalsField = New ApQuerySupplierCashProjectionTotals
            End If
            If (Me.ageOverField Is Nothing) Then
                Me.ageOverField = New ApQuerySupplierCashProjectionAgeOver
            End If
            If (Me.age2Field Is Nothing) Then
                Me.age2Field = New ApQuerySupplierCashProjectionAge2
            End If
            If (Me.age1Field Is Nothing) Then
                Me.age1Field = New ApQuerySupplierCashProjectionAge1
            End If
            If (Me.currentField Is Nothing) Then
                Me.currentField = New ApQuerySupplierCashProjectionCurrent
            End If
            If (Me.pastDueField Is Nothing) Then
                Me.pastDueField = New ApQuerySupplierCashProjectionPastDue
            End If
        End Sub
        
        Public Property PastDue() As ApQuerySupplierCashProjectionPastDue
            Get
                Return Me.pastDueField
            End Get
            Set
                Me.pastDueField = value
            End Set
        End Property
        
        Public Property Current() As ApQuerySupplierCashProjectionCurrent
            Get
                Return Me.currentField
            End Get
            Set
                Me.currentField = value
            End Set
        End Property
        
        Public Property Age1() As ApQuerySupplierCashProjectionAge1
            Get
                Return Me.age1Field
            End Get
            Set
                Me.age1Field = value
            End Set
        End Property
        
        Public Property Age2() As ApQuerySupplierCashProjectionAge2
            Get
                Return Me.age2Field
            End Get
            Set
                Me.age2Field = value
            End Set
        End Property
        
        Public Property AgeOver() As ApQuerySupplierCashProjectionAgeOver
            Get
                Return Me.ageOverField
            End Get
            Set
                Me.ageOverField = value
            End Set
        End Property
        
        Public Property Totals() As ApQuerySupplierCashProjectionTotals
            Get
                Return Me.totalsField
            End Get
            Set
                Me.totalsField = value
            End Set
        End Property
        
        Public Property Unapproved() As ApQuerySupplierCashProjectionUnapproved
            Get
                Return Me.unapprovedField
            End Get
            Set
                Me.unapprovedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionPastDue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionCurrent
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionAge1
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysFromField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysToField As String
        
        Public Sub New()
            MyBase.New
            If (Me.numberofInvoicesField Is Nothing) Then
                Me.numberofInvoicesField = New List(Of String)
            End If
        End Sub
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("NumberofInvoices")>  _
        Public Property NumberofInvoicesCollection() As List(Of String)
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
        
        Public Property DaysFrom() As String
            Get
                Return Me.daysFromField
            End Get
            Set
                Me.daysFromField = value
            End Set
        End Property
        
        Public Property DaysTo() As String
            Get
                Return Me.daysToField
            End Get
            Set
                Me.daysToField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionAge2
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysFromField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysToField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
        
        Public Property DaysFrom() As String
            Get
                Return Me.daysFromField
            End Get
            Set
                Me.daysFromField = value
            End Set
        End Property
        
        Public Property DaysTo() As String
            Get
                Return Me.daysToField
            End Get
            Set
                Me.daysToField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionAgeOver
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysOverField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
        
        Public Property DaysOver() As String
            Get
                Return Me.daysOverField
            End Get
            Set
                Me.daysOverField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierCashProjectionUnapproved
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberofInvoicesField As String
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
            End Set
        End Property
        
        Public Property NumberofInvoices() As String
            Get
                Return Me.numberofInvoicesField
            End Get
            Set
                Me.numberofInvoicesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierGRNDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnSourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origReceiptDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private curGrnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private matchedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnMatchedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReleaseField As String
        
        Public Property Grn() As String
            Get
                Return Me.grnField
            End Get
            Set
                Me.grnField = value
            End Set
        End Property
        
        Public Property GrnSource() As String
            Get
                Return Me.grnSourceField
            End Get
            Set
                Me.grnSourceField = value
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
        
        Public Property JournalEntry() As String
            Get
                Return Me.journalEntryField
            End Get
            Set
                Me.journalEntryField = value
            End Set
        End Property
        
        Public Property OrigReceiptDate() As String
            Get
                Return Me.origReceiptDateField
            End Get
            Set
                Me.origReceiptDateField = value
            End Set
        End Property
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
        
        Public Property QtyReceived() As String
            Get
                Return Me.qtyReceivedField
            End Get
            Set
                Me.qtyReceivedField = value
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
        
        Public Property CurGrnValue() As String
            Get
                Return Me.curGrnValueField
            End Get
            Set
                Me.curGrnValueField = value
            End Set
        End Property
        
        Public Property MatchedValue() As String
            Get
                Return Me.matchedValueField
            End Get
            Set
                Me.matchedValueField = value
            End Set
        End Property
        
        Public Property GrnMatchedFlag() As String
            Get
                Return Me.grnMatchedFlagField
            End Get
            Set
                Me.grnMatchedFlagField = value
            End Set
        End Property
        
        Public Property MVersion() As String
            Get
                Return Me.mVersionField
            End Get
            Set
                Me.mVersionField = value
            End Set
        End Property
        
        Public Property MRelease() As String
            Get
                Return Me.mReleaseField
            End Get
            Set
                Me.mReleaseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierReceiptDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origPurchPrcForField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
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
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property PurchaseOrderLin() As String
            Get
                Return Me.purchaseOrderLinField
            End Get
            Set
                Me.purchaseOrderLinField = value
            End Set
        End Property
        
        Public Property QtyReceived() As String
            Get
                Return Me.qtyReceivedField
            End Get
            Set
                Me.qtyReceivedField = value
            End Set
        End Property
        
        Public Property PriceReceived() As String
            Get
                Return Me.priceReceivedField
            End Get
            Set
                Me.priceReceivedField = value
            End Set
        End Property
        
        Public Property OrigPurchPrcFor() As String
            Get
                Return Me.origPurchPrcForField
            End Get
            Set
                Me.origPurchPrcForField = value
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
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property AddReference() As String
            Get
                Return Me.addReferenceField
            End Get
            Set
                Me.addReferenceField = value
            End Set
        End Property
        
        Public Property JnlDate() As String
            Get
                Return Me.jnlDateField
            End Get
            Set
                Me.jnlDateField = value
            End Set
        End Property
        
        Public Property PoDate() As String
            Get
                Return Me.poDateField
            End Get
            Set
                Me.poDateField = value
            End Set
        End Property
        
        Public Property LineDueDate() As String
            Get
                Return Me.lineDueDateField
            End Get
            Set
                Me.lineDueDateField = value
            End Set
        End Property
        
        Public Property DateReceived() As String
            Get
                Return Me.dateReceivedField
            End Get
            Set
                Me.dateReceivedField = value
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ApQuerySupplierScrapAndRejectDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapRejectFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapRejectQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origLineDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapRejectDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
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
        
        Public Property ScrapRejectFlag() As String
            Get
                Return Me.scrapRejectFlagField
            End Get
            Set
                Me.scrapRejectFlagField = value
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
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
        
        Public Property ScrapRejectQty() As String
            Get
                Return Me.scrapRejectQtyField
            End Get
            Set
                Me.scrapRejectQtyField = value
            End Set
        End Property
        
        Public Property DocumentNum() As String
            Get
                Return Me.documentNumField
            End Get
            Set
                Me.documentNumField = value
            End Set
        End Property
        
        Public Property PoDate() As String
            Get
                Return Me.poDateField
            End Get
            Set
                Me.poDateField = value
            End Set
        End Property
        
        Public Property RejectCode() As String
            Get
                Return Me.rejectCodeField
            End Get
            Set
                Me.rejectCodeField = value
            End Set
        End Property
        
        Public Property Grn() As String
            Get
                Return Me.grnField
            End Get
            Set
                Me.grnField = value
            End Set
        End Property
        
        Public Property OrigLineDueDate() As String
            Get
                Return Me.origLineDueDateField
            End Get
            Set
                Me.origLineDueDateField = value
            End Set
        End Property
        
        Public Property ScrapRejectDate() As String
            Get
                Return Me.scrapRejectDateField
            End Get
            Set
                Me.scrapRejectDateField = value
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
    End Class
End Namespace
