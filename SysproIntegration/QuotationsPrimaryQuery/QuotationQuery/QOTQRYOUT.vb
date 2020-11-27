Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace QuotationsPrimaryQuery.QuotationQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class QuotationQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As QuotationQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private probabilityFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesPersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALBRN_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invTermsOverrideField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLART_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALARE_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
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
        Private shipAddress6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateEnquiryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateTenderReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateDeliveryReqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePrintedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationDetailsField As QuotationQueryQuotationDetails
        
        Public Sub New()
            MyBase.New
            If (Me.quotationDetailsField Is Nothing) Then
                Me.quotationDetailsField = New QuotationQueryQuotationDetails
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New QuotationQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As QuotationQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
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
        
        Public Property QuoteDescription() As String
            Get
                Return Me.quoteDescriptionField
            End Get
            Set
                Me.quoteDescriptionField = value
            End Set
        End Property
        
        Public Property QuoteStatus() As String
            Get
                Return Me.quoteStatusField
            End Get
            Set
                Me.quoteStatusField = value
            End Set
        End Property
        
        Public Property Classification() As String
            Get
                Return Me.classificationField
            End Get
            Set
                Me.classificationField = value
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
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property ProbabilityFlag() As String
            Get
                Return Me.probabilityFlagField
            End Get
            Set
                Me.probabilityFlagField = value
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
        
        Public Property SalesPerson() As String
            Get
                Return Me.salesPersonField
            End Get
            Set
                Me.salesPersonField = value
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
        
        Public Property InvTermsOverride() As String
            Get
                Return Me.invTermsOverrideField
            End Get
            Set
                Me.invTermsOverrideField = value
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
        
        Public Property OrderType() As Object
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
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
        
        Public Property SALARE_Description() As String
            Get
                Return Me.sALARE_DescriptionField
            End Get
            Set
                Me.sALARE_DescriptionField = value
            End Set
        End Property
        
        Public Property TaxExemptFlag() As String
            Get
                Return Me.taxExemptFlagField
            End Get
            Set
                Me.taxExemptFlagField = value
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
        
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
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
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
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
        
        Public Property ShipAddress6() As String
            Get
                Return Me.shipAddress6Field
            End Get
            Set
                Me.shipAddress6Field = value
            End Set
        End Property
        
        Public Property ReasonCode() As String
            Get
                Return Me.reasonCodeField
            End Get
            Set
                Me.reasonCodeField = value
            End Set
        End Property
        
        Public Property DateEnquiry() As String
            Get
                Return Me.dateEnquiryField
            End Get
            Set
                Me.dateEnquiryField = value
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
        
        Public Property DateTenderReq() As String
            Get
                Return Me.dateTenderReqField
            End Get
            Set
                Me.dateTenderReqField = value
            End Set
        End Property
        
        Public Property DateDeliveryReq() As String
            Get
                Return Me.dateDeliveryReqField
            End Get
            Set
                Me.dateDeliveryReqField = value
            End Set
        End Property
        
        Public Property DatePrinted() As String
            Get
                Return Me.datePrintedField
            End Get
            Set
                Me.datePrintedField = value
            End Set
        End Property
        
        Public Property QuotationDetails() As QuotationQueryQuotationDetails
            Get
                Return Me.quotationDetailsField
            End Get
            Set
                Me.quotationDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQuerySystemInformation
        
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
    Partial Public Class QuotationQueryQuotationDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockLineField As List(Of QuotationQueryQuotationDetailsStockLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As List(Of QuotationQueryQuotationDetailsCommentLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As QuotationQueryQuotationDetailsFreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockLineField As QuotationQueryQuotationDetailsNonStockLine
        
        Public Sub New()
            MyBase.New
            If (Me.nonStockLineField Is Nothing) Then
                Me.nonStockLineField = New QuotationQueryQuotationDetailsNonStockLine
            End If
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New QuotationQueryQuotationDetailsFreightLine
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New List(Of QuotationQueryQuotationDetailsCommentLine)
            End If
            If (Me.stockLineField Is Nothing) Then
                Me.stockLineField = New List(Of QuotationQueryQuotationDetailsStockLine)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("StockLine")>  _
        Public Property StockLineCollection() As List(Of QuotationQueryQuotationDetailsStockLine)
            Get
                Return Me.stockLineField
            End Get
            Set
                Me.stockLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CommentLine")>  _
        Public Property CommentLineCollection() As List(Of QuotationQueryQuotationDetailsCommentLine)
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        Public Property FreightLine() As QuotationQueryQuotationDetailsFreightLine
            Get
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Non-StockLine")>  _
        Public Property NonStockLine() As QuotationQueryQuotationDetailsNonStockLine
            Get
                Return Me.nonStockLineField
            End Get
            Set
                Me.nonStockLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsStockLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultEntryField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fedSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mstockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mwarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDecimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusRetailPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mSalesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBomFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mParentKitTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPrintComponentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mComponentSeqField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOptionalFlagField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerLinesField As List(Of QuotationQueryQuotationDetailsStockLineOffer)
        
        Public Sub New()
            MyBase.New
            If (Me.offerLinesField Is Nothing) Then
                Me.offerLinesField = New List(Of QuotationQueryQuotationDetailsStockLineOffer)
            End If
        End Sub
        
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        Public Property DefaultEntry() As Object
            Get
                Return Me.defaultEntryField
            End Get
            Set
                Me.defaultEntryField = value
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
        
        Public Property FedSalesTax() As String
            Get
                Return Me.fedSalesTaxField
            End Get
            Set
                Me.fedSalesTaxField = value
            End Set
        End Property
        
        Public Property MstockCode() As String
            Get
                Return Me.mstockCodeField
            End Get
            Set
                Me.mstockCodeField = value
            End Set
        End Property
        
        Public Property MDescription() As String
            Get
                Return Me.mDescriptionField
            End Get
            Set
                Me.mDescriptionField = value
            End Set
        End Property
        
        Public Property Mwarehouse() As String
            Get
                Return Me.mwarehouseField
            End Get
            Set
                Me.mwarehouseField = value
            End Set
        End Property
        
        Public Property MUom() As String
            Get
                Return Me.mUomField
            End Get
            Set
                Me.mUomField = value
            End Set
        End Property
        
        Public Property MDecimals() As String
            Get
                Return Me.mDecimalsField
            End Get
            Set
                Me.mDecimalsField = value
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
        
        Public Property MCusStockCode() As String
            Get
                Return Me.mCusStockCodeField
            End Get
            Set
                Me.mCusStockCodeField = value
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
        
        Public Property MMass() As String
            Get
                Return Me.mMassField
            End Get
            Set
                Me.mMassField = value
            End Set
        End Property
        
        Public Property MVolume() As String
            Get
                Return Me.mVolumeField
            End Get
            Set
                Me.mVolumeField = value
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
        
        Public Property MSalesOrderLine() As String
            Get
                Return Me.mSalesOrderLineField
            End Get
            Set
                Me.mSalesOrderLineField = value
            End Set
        End Property
        
        Public Property MBomFlag() As String
            Get
                Return Me.mBomFlagField
            End Get
            Set
                Me.mBomFlagField = value
            End Set
        End Property
        
        Public Property MParentKitType() As String
            Get
                Return Me.mParentKitTypeField
            End Get
            Set
                Me.mParentKitTypeField = value
            End Set
        End Property
        
        Public Property MQtyPer() As String
            Get
                Return Me.mQtyPerField
            End Get
            Set
                Me.mQtyPerField = value
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
        
        Public Property MPrintComponent() As String
            Get
                Return Me.mPrintComponentField
            End Get
            Set
                Me.mPrintComponentField = value
            End Set
        End Property
        
        Public Property MComponentSeq() As Object
            Get
                Return Me.mComponentSeqField
            End Get
            Set
                Me.mComponentSeqField = value
            End Set
        End Property
        
        Public Property MOptionalFlag() As Object
            Get
                Return Me.mOptionalFlagField
            End Get
            Set
                Me.mOptionalFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Offer", IsNullable:=false)>  _
        Public Property OfferLinesCollection() As List(Of QuotationQueryQuotationDetailsStockLineOffer)
            Get
                Return Me.offerLinesField
            End Get
            Set
                Me.offerLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsStockLineOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mquantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mShipUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mConvFactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mrouteToUseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMarkupMarginField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceOverrideField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceConvFactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceFactCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscountFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mNetValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCommissionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mContractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBuyingGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mContractExpiryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mFixedMarkupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mRollupFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mRouteUsedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mQtyChangesFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberField As String
        
        Public Property Mquantity() As String
            Get
                Return Me.mquantityField
            End Get
            Set
                Me.mquantityField = value
            End Set
        End Property
        
        Public Property MShipUom() As String
            Get
                Return Me.mShipUomField
            End Get
            Set
                Me.mShipUomField = value
            End Set
        End Property
        
        Public Property MConvFact() As String
            Get
                Return Me.mConvFactField
            End Get
            Set
                Me.mConvFactField = value
            End Set
        End Property
        
        Public Property MMulDiv() As String
            Get
                Return Me.mMulDivField
            End Get
            Set
                Me.mMulDivField = value
            End Set
        End Property
        
        Public Property MrouteToUse() As Object
            Get
                Return Me.mrouteToUseField
            End Get
            Set
                Me.mrouteToUseField = value
            End Set
        End Property
        
        Public Property MMarkupMargin() As String
            Get
                Return Me.mMarkupMarginField
            End Get
            Set
                Me.mMarkupMarginField = value
            End Set
        End Property
        
        Public Property MPriceOverride() As String
            Get
                Return Me.mPriceOverrideField
            End Get
            Set
                Me.mPriceOverrideField = value
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
        
        Public Property MPriceUom() As String
            Get
                Return Me.mPriceUomField
            End Get
            Set
                Me.mPriceUomField = value
            End Set
        End Property
        
        Public Property MPriceConvFact() As String
            Get
                Return Me.mPriceConvFactField
            End Get
            Set
                Me.mPriceConvFactField = value
            End Set
        End Property
        
        Public Property MPriceFactCode() As String
            Get
                Return Me.mPriceFactCodeField
            End Get
            Set
                Me.mPriceFactCodeField = value
            End Set
        End Property
        
        Public Property MLineDisc1() As String
            Get
                Return Me.mLineDisc1Field
            End Get
            Set
                Me.mLineDisc1Field = value
            End Set
        End Property
        
        Public Property MLineDisc2() As String
            Get
                Return Me.mLineDisc2Field
            End Get
            Set
                Me.mLineDisc2Field = value
            End Set
        End Property
        
        Public Property MLineDisc3() As String
            Get
                Return Me.mLineDisc3Field
            End Get
            Set
                Me.mLineDisc3Field = value
            End Set
        End Property
        
        Public Property MDiscountFlag() As String
            Get
                Return Me.mDiscountFlagField
            End Get
            Set
                Me.mDiscountFlagField = value
            End Set
        End Property
        
        Public Property MDiscountValue() As String
            Get
                Return Me.mDiscountValueField
            End Get
            Set
                Me.mDiscountValueField = value
            End Set
        End Property
        
        Public Property MNetValue() As String
            Get
                Return Me.mNetValueField
            End Get
            Set
                Me.mNetValueField = value
            End Set
        End Property
        
        Public Property MCommissionCode() As String
            Get
                Return Me.mCommissionCodeField
            End Get
            Set
                Me.mCommissionCodeField = value
            End Set
        End Property
        
        Public Property MContract() As String
            Get
                Return Me.mContractField
            End Get
            Set
                Me.mContractField = value
            End Set
        End Property
        
        Public Property MBuyingGroup() As String
            Get
                Return Me.mBuyingGroupField
            End Get
            Set
                Me.mBuyingGroupField = value
            End Set
        End Property
        
        Public Property MContractExpiry() As String
            Get
                Return Me.mContractExpiryField
            End Get
            Set
                Me.mContractExpiryField = value
            End Set
        End Property
        
        Public Property MFixedMarkup() As String
            Get
                Return Me.mFixedMarkupField
            End Get
            Set
                Me.mFixedMarkupField = value
            End Set
        End Property
        
        Public Property MRollupFlag() As String
            Get
                Return Me.mRollupFlagField
            End Get
            Set
                Me.mRollupFlagField = value
            End Set
        End Property
        
        Public Property MCost() As String
            Get
                Return Me.mCostField
            End Get
            Set
                Me.mCostField = value
            End Set
        End Property
        
        Public Property MLeadTime() As String
            Get
                Return Me.mLeadTimeField
            End Get
            Set
                Me.mLeadTimeField = value
            End Set
        End Property
        
        Public Property MRouteUsed() As String
            Get
                Return Me.mRouteUsedField
            End Get
            Set
                Me.mRouteUsedField = value
            End Set
        End Property
        
        Public Property MQtyChangesFlag() As String
            Get
                Return Me.mQtyChangesFlagField
            End Get
            Set
                Me.mQtyChangesFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OfferNumber() As String
            Get
                Return Me.offerNumberField
            End Get
            Set
                Me.offerNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentTextTypField As String
        
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
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
        
        Public Property NCommentFromLin() As String
            Get
                Return Me.nCommentFromLinField
            End Get
            Set
                Me.nCommentFromLinField = value
            End Set
        End Property
        
        Public Property NCommentType() As String
            Get
                Return Me.nCommentTypeField
            End Get
            Set
                Me.nCommentTypeField = value
            End Set
        End Property
        
        Public Property NCommentTextTyp() As String
            Get
                Return Me.nCommentTextTypField
            End Get
            Set
                Me.nCommentTextTypField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsFreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fedSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerLinesField As QuotationQueryQuotationDetailsFreightLineOfferLines
        
        Public Sub New()
            MyBase.New
            If (Me.offerLinesField Is Nothing) Then
                Me.offerLinesField = New QuotationQueryQuotationDetailsFreightLineOfferLines
            End If
        End Sub
        
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        Public Property DefaultEntry() As String
            Get
                Return Me.defaultEntryField
            End Get
            Set
                Me.defaultEntryField = value
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
        
        Public Property FedSalesTax() As String
            Get
                Return Me.fedSalesTaxField
            End Get
            Set
                Me.fedSalesTaxField = value
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
        
        Public Property NCommentFromLin() As String
            Get
                Return Me.nCommentFromLinField
            End Get
            Set
                Me.nCommentFromLinField = value
            End Set
        End Property
        
        Public Property OfferLines() As QuotationQueryQuotationDetailsFreightLineOfferLines
            Get
                Return Me.offerLinesField
            End Get
            Set
                Me.offerLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsFreightLineOfferLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As QuotationQueryQuotationDetailsFreightLineOfferLinesOffer
        
        Public Sub New()
            MyBase.New
            If (Me.offerField Is Nothing) Then
                Me.offerField = New QuotationQueryQuotationDetailsFreightLineOfferLinesOffer
            End If
        End Sub
        
        Public Property Offer() As QuotationQueryQuotationDetailsFreightLineOfferLinesOffer
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsFreightLineOfferLinesOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscUnitPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscUnitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberField As String
        
        Public Property MiscChargeVal() As String
            Get
                Return Me.miscChargeValField
            End Get
            Set
                Me.miscChargeValField = value
            End Set
        End Property
        
        Public Property MiscChargeCost() As String
            Get
                Return Me.miscChargeCostField
            End Get
            Set
                Me.miscChargeCostField = value
            End Set
        End Property
        
        Public Property MiscChargeQty() As String
            Get
                Return Me.miscChargeQtyField
            End Get
            Set
                Me.miscChargeQtyField = value
            End Set
        End Property
        
        Public Property MiscUnitPrice() As String
            Get
                Return Me.miscUnitPriceField
            End Get
            Set
                Me.miscUnitPriceField = value
            End Set
        End Property
        
        Public Property MiscUnitCost() As String
            Get
                Return Me.miscUnitCostField
            End Get
            Set
                Me.miscUnitCostField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OfferNumber() As String
            Get
                Return Me.offerNumberField
            End Get
            Set
                Me.offerNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsNonStockLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fedSalesTaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mstockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mwarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDecimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCusRetailPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mSalesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBomFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mParentKitTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPrintComponentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mComponentSeqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOptionalFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerLinesField As QuotationQueryQuotationDetailsNonStockLineOfferLines
        
        Public Sub New()
            MyBase.New
            If (Me.offerLinesField Is Nothing) Then
                Me.offerLinesField = New QuotationQueryQuotationDetailsNonStockLineOfferLines
            End If
        End Sub
        
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        Public Property DefaultEntry() As String
            Get
                Return Me.defaultEntryField
            End Get
            Set
                Me.defaultEntryField = value
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
        
        Public Property FedSalesTax() As String
            Get
                Return Me.fedSalesTaxField
            End Get
            Set
                Me.fedSalesTaxField = value
            End Set
        End Property
        
        Public Property MstockCode() As String
            Get
                Return Me.mstockCodeField
            End Get
            Set
                Me.mstockCodeField = value
            End Set
        End Property
        
        Public Property MDescription() As String
            Get
                Return Me.mDescriptionField
            End Get
            Set
                Me.mDescriptionField = value
            End Set
        End Property
        
        Public Property Mwarehouse() As String
            Get
                Return Me.mwarehouseField
            End Get
            Set
                Me.mwarehouseField = value
            End Set
        End Property
        
        Public Property MUom() As String
            Get
                Return Me.mUomField
            End Get
            Set
                Me.mUomField = value
            End Set
        End Property
        
        Public Property MDecimals() As String
            Get
                Return Me.mDecimalsField
            End Get
            Set
                Me.mDecimalsField = value
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
        
        Public Property MCusStockCode() As String
            Get
                Return Me.mCusStockCodeField
            End Get
            Set
                Me.mCusStockCodeField = value
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
        
        Public Property MMass() As String
            Get
                Return Me.mMassField
            End Get
            Set
                Me.mMassField = value
            End Set
        End Property
        
        Public Property MVolume() As String
            Get
                Return Me.mVolumeField
            End Get
            Set
                Me.mVolumeField = value
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
        
        Public Property MSalesOrderLine() As String
            Get
                Return Me.mSalesOrderLineField
            End Get
            Set
                Me.mSalesOrderLineField = value
            End Set
        End Property
        
        Public Property MBomFlag() As String
            Get
                Return Me.mBomFlagField
            End Get
            Set
                Me.mBomFlagField = value
            End Set
        End Property
        
        Public Property MParentKitType() As String
            Get
                Return Me.mParentKitTypeField
            End Get
            Set
                Me.mParentKitTypeField = value
            End Set
        End Property
        
        Public Property MQtyPer() As String
            Get
                Return Me.mQtyPerField
            End Get
            Set
                Me.mQtyPerField = value
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
        
        Public Property MPrintComponent() As String
            Get
                Return Me.mPrintComponentField
            End Get
            Set
                Me.mPrintComponentField = value
            End Set
        End Property
        
        Public Property MComponentSeq() As String
            Get
                Return Me.mComponentSeqField
            End Get
            Set
                Me.mComponentSeqField = value
            End Set
        End Property
        
        Public Property MOptionalFlag() As String
            Get
                Return Me.mOptionalFlagField
            End Get
            Set
                Me.mOptionalFlagField = value
            End Set
        End Property
        
        Public Property OfferLines() As QuotationQueryQuotationDetailsNonStockLineOfferLines
            Get
                Return Me.offerLinesField
            End Get
            Set
                Me.offerLinesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsNonStockLineOfferLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerField As QuotationQueryQuotationDetailsNonStockLineOfferLinesOffer
        
        Public Sub New()
            MyBase.New
            If (Me.offerField Is Nothing) Then
                Me.offerField = New QuotationQueryQuotationDetailsNonStockLineOfferLinesOffer
            End If
        End Sub
        
        Public Property Offer() As QuotationQueryQuotationDetailsNonStockLineOfferLinesOffer
            Get
                Return Me.offerField
            End Get
            Set
                Me.offerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QuotationQueryQuotationDetailsNonStockLineOfferLinesOffer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mquantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mShipUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mConvFactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mrouteToUseField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mMarkupMarginField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceOverrideField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceConvFactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceFactCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineDisc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscountFlagField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mNetValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCommissionCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mContractField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBuyingGroupField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mContractExpiryField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mFixedMarkupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mRollupFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mRouteUsedField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mQtyChangesFlagField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private offerNumberField As String
        
        Public Property Mquantity() As String
            Get
                Return Me.mquantityField
            End Get
            Set
                Me.mquantityField = value
            End Set
        End Property
        
        Public Property MShipUom() As String
            Get
                Return Me.mShipUomField
            End Get
            Set
                Me.mShipUomField = value
            End Set
        End Property
        
        Public Property MConvFact() As String
            Get
                Return Me.mConvFactField
            End Get
            Set
                Me.mConvFactField = value
            End Set
        End Property
        
        Public Property MMulDiv() As String
            Get
                Return Me.mMulDivField
            End Get
            Set
                Me.mMulDivField = value
            End Set
        End Property
        
        Public Property MrouteToUse() As Object
            Get
                Return Me.mrouteToUseField
            End Get
            Set
                Me.mrouteToUseField = value
            End Set
        End Property
        
        Public Property MMarkupMargin() As String
            Get
                Return Me.mMarkupMarginField
            End Get
            Set
                Me.mMarkupMarginField = value
            End Set
        End Property
        
        Public Property MPriceOverride() As String
            Get
                Return Me.mPriceOverrideField
            End Get
            Set
                Me.mPriceOverrideField = value
            End Set
        End Property
        
        Public Property MPriceCode() As Object
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
        
        Public Property MPriceUom() As String
            Get
                Return Me.mPriceUomField
            End Get
            Set
                Me.mPriceUomField = value
            End Set
        End Property
        
        Public Property MPriceConvFact() As String
            Get
                Return Me.mPriceConvFactField
            End Get
            Set
                Me.mPriceConvFactField = value
            End Set
        End Property
        
        Public Property MPriceFactCode() As String
            Get
                Return Me.mPriceFactCodeField
            End Get
            Set
                Me.mPriceFactCodeField = value
            End Set
        End Property
        
        Public Property MLineDisc1() As String
            Get
                Return Me.mLineDisc1Field
            End Get
            Set
                Me.mLineDisc1Field = value
            End Set
        End Property
        
        Public Property MLineDisc2() As String
            Get
                Return Me.mLineDisc2Field
            End Get
            Set
                Me.mLineDisc2Field = value
            End Set
        End Property
        
        Public Property MLineDisc3() As String
            Get
                Return Me.mLineDisc3Field
            End Get
            Set
                Me.mLineDisc3Field = value
            End Set
        End Property
        
        Public Property MDiscountFlag() As Object
            Get
                Return Me.mDiscountFlagField
            End Get
            Set
                Me.mDiscountFlagField = value
            End Set
        End Property
        
        Public Property MDiscountValue() As String
            Get
                Return Me.mDiscountValueField
            End Get
            Set
                Me.mDiscountValueField = value
            End Set
        End Property
        
        Public Property MNetValue() As String
            Get
                Return Me.mNetValueField
            End Get
            Set
                Me.mNetValueField = value
            End Set
        End Property
        
        Public Property MCommissionCode() As Object
            Get
                Return Me.mCommissionCodeField
            End Get
            Set
                Me.mCommissionCodeField = value
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
        
        Public Property MContractExpiry() As Object
            Get
                Return Me.mContractExpiryField
            End Get
            Set
                Me.mContractExpiryField = value
            End Set
        End Property
        
        Public Property MFixedMarkup() As String
            Get
                Return Me.mFixedMarkupField
            End Get
            Set
                Me.mFixedMarkupField = value
            End Set
        End Property
        
        Public Property MRollupFlag() As String
            Get
                Return Me.mRollupFlagField
            End Get
            Set
                Me.mRollupFlagField = value
            End Set
        End Property
        
        Public Property MCost() As String
            Get
                Return Me.mCostField
            End Get
            Set
                Me.mCostField = value
            End Set
        End Property
        
        Public Property MLeadTime() As String
            Get
                Return Me.mLeadTimeField
            End Get
            Set
                Me.mLeadTimeField = value
            End Set
        End Property
        
        Public Property MRouteUsed() As Object
            Get
                Return Me.mRouteUsedField
            End Get
            Set
                Me.mRouteUsedField = value
            End Set
        End Property
        
        Public Property MQtyChangesFlag() As Object
            Get
                Return Me.mQtyChangesFlagField
            End Get
            Set
                Me.mQtyChangesFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OfferNumber() As String
            Get
                Return Me.offerNumberField
            End Get
            Set
                Me.offerNumberField = value
            End Set
        End Property
    End Class
End Namespace
