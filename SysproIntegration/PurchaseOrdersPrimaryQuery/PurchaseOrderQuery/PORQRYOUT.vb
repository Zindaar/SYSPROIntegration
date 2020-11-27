Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryQuery.PurchaseOrderQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PorDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As PorDetailSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderEntryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private memoCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private paymentTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDiscountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amendedCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customFormField As List(Of PorDetailField)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As List(Of PorDetailPurchaseOrderLine)
        
        Public Sub New()
            MyBase.New
            If (Me.purchaseOrderLineField Is Nothing) Then
                Me.purchaseOrderLineField = New List(Of PorDetailPurchaseOrderLine)
            End If
            If (Me.customFormField Is Nothing) Then
                Me.customFormField = New List(Of PorDetailField)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New PorDetailSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As PorDetailSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
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
        
        Public Property SupplierClass() As String
            Get
                Return Me.supplierClassField
            End Get
            Set
                Me.supplierClassField = value
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
        
        Public Property SupplierAddr1() As String
            Get
                Return Me.supplierAddr1Field
            End Get
            Set
                Me.supplierAddr1Field = value
            End Set
        End Property
        
        Public Property SupplierAddr2() As String
            Get
                Return Me.supplierAddr2Field
            End Get
            Set
                Me.supplierAddr2Field = value
            End Set
        End Property
        
        Public Property SupplierAddr3() As String
            Get
                Return Me.supplierAddr3Field
            End Get
            Set
                Me.supplierAddr3Field = value
            End Set
        End Property
        
        Public Property SupplierAddr4() As String
            Get
                Return Me.supplierAddr4Field
            End Get
            Set
                Me.supplierAddr4Field = value
            End Set
        End Property
        
        Public Property SupplierAddr5() As String
            Get
                Return Me.supplierAddr5Field
            End Get
            Set
                Me.supplierAddr5Field = value
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
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
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
        
        Public Property DeliveryName() As String
            Get
                Return Me.deliveryNameField
            End Get
            Set
                Me.deliveryNameField = value
            End Set
        End Property
        
        Public Property DeliveryAddr1() As String
            Get
                Return Me.deliveryAddr1Field
            End Get
            Set
                Me.deliveryAddr1Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr2() As String
            Get
                Return Me.deliveryAddr2Field
            End Get
            Set
                Me.deliveryAddr2Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr3() As String
            Get
                Return Me.deliveryAddr3Field
            End Get
            Set
                Me.deliveryAddr3Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr4() As String
            Get
                Return Me.deliveryAddr4Field
            End Get
            Set
                Me.deliveryAddr4Field = value
            End Set
        End Property
        
        Public Property DeliveryAddr5() As String
            Get
                Return Me.deliveryAddr5Field
            End Get
            Set
                Me.deliveryAddr5Field = value
            End Set
        End Property
        
        Public Property PostalCode() As String
            Get
                Return Me.postalCodeField
            End Get
            Set
                Me.postalCodeField = value
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
        
        Public Property OrderEntryDate() As String
            Get
                Return Me.orderEntryDateField
            End Get
            Set
                Me.orderEntryDateField = value
            End Set
        End Property
        
        Public Property OrderDueDate() As String
            Get
                Return Me.orderDueDateField
            End Get
            Set
                Me.orderDueDateField = value
            End Set
        End Property
        
        Public Property MemoDate() As String
            Get
                Return Me.memoDateField
            End Get
            Set
                Me.memoDateField = value
            End Set
        End Property
        
        Public Property MemoCode() As String
            Get
                Return Me.memoCodeField
            End Get
            Set
                Me.memoCodeField = value
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
        
        Public Property PaymentTerms() As String
            Get
                Return Me.paymentTermsField
            End Get
            Set
                Me.paymentTermsField = value
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
        
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        Public Property OrderDiscount() As String
            Get
                Return Me.orderDiscountField
            End Get
            Set
                Me.orderDiscountField = value
            End Set
        End Property
        
        Public Property AmendedCount() As String
            Get
                Return Me.amendedCountField
            End Get
            Set
                Me.amendedCountField = value
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
        
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        Public Property DocumentFormat() As String
            Get
                Return Me.documentFormatField
            End Get
            Set
                Me.documentFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable:=false)>  _
        Public Property CustomFormCollection() As List(Of PorDetailField)
            Get
                Return Me.customFormField
            End Get
            Set
                Me.customFormField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("PurchaseOrderLine")>  _
        Public Property PurchaseOrderLineCollection() As List(Of PorDetailPurchaseOrderLine)
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailSystemInformation
        
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
    Partial Public Class PorDetailField
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private promptField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lengthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNullField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        Public Property Sequence() As String
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
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
        
        Public Property Prompt() As String
            Get
                Return Me.promptField
            End Get
            Set
                Me.promptField = value
            End Set
        End Property
        
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        Public Property Length() As String
            Get
                Return Me.lengthField
            End Get
            Set
                Me.lengthField = value
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
        
        Public Property [Default]() As String
            Get
                Return Me.defaultField
            End Get
            Set
                Me.defaultField = value
            End Set
        End Property
        
        Public Property AllowNull() As String
            Get
                Return Me.allowNullField
            End Get
            Set
                Me.allowNullField = value
            End Set
        End Property
        
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeField As PorDetailPurchaseOrderLineMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightField As PorDetailPurchaseOrderLineFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As PorDetailPurchaseOrderLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseField As PorDetailPurchaseOrderLineMerchandise
        
        Public Sub New()
            MyBase.New
            If (Me.merchandiseField Is Nothing) Then
                Me.merchandiseField = New PorDetailPurchaseOrderLineMerchandise
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New PorDetailPurchaseOrderLineCommentLine
            End If
            If (Me.freightField Is Nothing) Then
                Me.freightField = New PorDetailPurchaseOrderLineFreight
            End If
            If (Me.miscChargeField Is Nothing) Then
                Me.miscChargeField = New PorDetailPurchaseOrderLineMiscCharge
            End If
        End Sub
        
        Public Property MiscCharge() As PorDetailPurchaseOrderLineMiscCharge
            Get
                Return Me.miscChargeField
            End Get
            Set
                Me.miscChargeField = value
            End Set
        End Property
        
        Public Property Freight() As PorDetailPurchaseOrderLineFreight
            Get
                Return Me.freightField
            End Get
            Set
                Me.freightField = value
            End Set
        End Property
        
        Public Property CommentLine() As PorDetailPurchaseOrderLineCommentLine
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        Public Property Merchandise() As PorDetailPurchaseOrderLineMerchandise
            Get
                Return Me.merchandiseField
            End Get
            Set
                Me.merchandiseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMiscCharge
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeForField As String
        
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
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
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        Public Property NMscChargeFor() As String
            Get
                Return Me.nMscChargeForField
            End Get
            Set
                Me.nMscChargeForField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineFreight
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nMscChargeForField As String
        
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
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
        
        Public Property NMscChargeValue() As String
            Get
                Return Me.nMscChargeValueField
            End Get
            Set
                Me.nMscChargeValueField = value
            End Set
        End Property
        
        Public Property NMscChargeFor() As String
            Get
                Return Me.nMscChargeForField
            End Get
            Set
                Me.nMscChargeForField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nCommentFromLinField As String
        
        Public Property PurchaseOrderLine() As String
            Get
                Return Me.purchaseOrderLineField
            End Get
            Set
                Me.purchaseOrderLineField = value
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandise
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockDesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptIntoFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOutstandingQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mReceivedQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCompleteFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mDiscValFlagField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mForeignPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignOrderValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLatestDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mSupCatalogueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As PorDetailPurchaseOrderLineMerchandiseSalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctDetailField As PorDetailPurchaseOrderLineMerchandiseLctDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private historyField As PorDetailPurchaseOrderLineMerchandiseHistory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As PorDetailPurchaseOrderLineMerchandiseGrn
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionField As PorDetailPurchaseOrderLineMerchandiseRequisition
        
        Public Sub New()
            MyBase.New
            If (Me.requisitionField Is Nothing) Then
                Me.requisitionField = New PorDetailPurchaseOrderLineMerchandiseRequisition
            End If
            If (Me.grnField Is Nothing) Then
                Me.grnField = New PorDetailPurchaseOrderLineMerchandiseGrn
            End If
            If (Me.historyField Is Nothing) Then
                Me.historyField = New PorDetailPurchaseOrderLineMerchandiseHistory
            End If
            If (Me.lctDetailField Is Nothing) Then
                Me.lctDetailField = New PorDetailPurchaseOrderLineMerchandiseLctDetail
            End If
            If (Me.salesOrderField Is Nothing) Then
                Me.salesOrderField = New PorDetailPurchaseOrderLineMerchandiseSalesOrder
            End If
        End Sub
        
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property TraceableType() As String
            Get
                Return Me.traceableTypeField
            End Get
            Set
                Me.traceableTypeField = value
            End Set
        End Property
        
        Public Property ReceiptIntoFlag() As String
            Get
                Return Me.receiptIntoFlagField
            End Get
            Set
                Me.receiptIntoFlagField = value
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
        
        Public Property MOutstandingQty() As String
            Get
                Return Me.mOutstandingQtyField
            End Get
            Set
                Me.mOutstandingQtyField = value
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
        
        Public Property MReceivedQty() As String
            Get
                Return Me.mReceivedQtyField
            End Get
            Set
                Me.mReceivedQtyField = value
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
        
        Public Property MCompleteFlag() As String
            Get
                Return Me.mCompleteFlagField
            End Get
            Set
                Me.mCompleteFlagField = value
            End Set
        End Property
        
        Public Property MJob() As String
            Get
                Return Me.mJobField
            End Get
            Set
                Me.mJobField = value
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
        
        Public Property OrderValue() As String
            Get
                Return Me.orderValueField
            End Get
            Set
                Me.orderValueField = value
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
        
        Public Property MDiscValue() As String
            Get
                Return Me.mDiscValueField
            End Get
            Set
                Me.mDiscValueField = value
            End Set
        End Property
        
        Public Property MDiscValFlag() As Object
            Get
                Return Me.mDiscValFlagField
            End Get
            Set
                Me.mDiscValFlagField = value
            End Set
        End Property
        
        Public Property MForeignPrice() As String
            Get
                Return Me.mForeignPriceField
            End Get
            Set
                Me.mForeignPriceField = value
            End Set
        End Property
        
        Public Property ForeignOrderValue() As String
            Get
                Return Me.foreignOrderValueField
            End Get
            Set
                Me.foreignOrderValueField = value
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
        
        Public Property MLatestDueDate() As String
            Get
                Return Me.mLatestDueDateField
            End Get
            Set
                Me.mLatestDueDateField = value
            End Set
        End Property
        
        Public Property MSupCatalogue() As String
            Get
                Return Me.mSupCatalogueField
            End Get
            Set
                Me.mSupCatalogueField = value
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
        
        Public Property SalesOrder() As PorDetailPurchaseOrderLineMerchandiseSalesOrder
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property LctDetail() As PorDetailPurchaseOrderLineMerchandiseLctDetail
            Get
                Return Me.lctDetailField
            End Get
            Set
                Me.lctDetailField = value
            End Set
        End Property
        
        Public Property History() As PorDetailPurchaseOrderLineMerchandiseHistory
            Get
                Return Me.historyField
            End Get
            Set
                Me.historyField = value
            End Set
        End Property
        
        Public Property Grn() As PorDetailPurchaseOrderLineMerchandiseGrn
            Get
                Return Me.grnField
            End Get
            Set
                Me.grnField = value
            End Set
        End Property
        
        Public Property Requisition() As PorDetailPurchaseOrderLineMerchandiseRequisition
            Get
                Return Me.requisitionField
            End Get
            Set
                Me.requisitionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseSalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mOrderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mShipQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mBackOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockQtyToShpField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockingUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mQtyDispatchedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mStockUnitVolField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mPriceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mLineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mCustRequestDatField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignOrderValueField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private foreignCurrencyField As Object
        
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
        
        Public Property MOrderQty() As String
            Get
                Return Me.mOrderQtyField
            End Get
            Set
                Me.mOrderQtyField = value
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
        
        Public Property MStockingUom() As String
            Get
                Return Me.mStockingUomField
            End Get
            Set
                Me.mStockingUomField = value
            End Set
        End Property
        
        Public Property MQtyDispatched() As String
            Get
                Return Me.mQtyDispatchedField
            End Get
            Set
                Me.mQtyDispatchedField = value
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
        
        Public Property MStockUnitVol() As String
            Get
                Return Me.mStockUnitVolField
            End Get
            Set
                Me.mStockUnitVolField = value
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
        
        Public Property MPriceCode() As String
            Get
                Return Me.mPriceCodeField
            End Get
            Set
                Me.mPriceCodeField = value
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
        
        Public Property MPriceUom() As String
            Get
                Return Me.mPriceUomField
            End Get
            Set
                Me.mPriceUomField = value
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
        
        Public Property MLineShipDate() As String
            Get
                Return Me.mLineShipDateField
            End Get
            Set
                Me.mLineShipDateField = value
            End Set
        End Property
        
        Public Property MCustRequestDat() As Object
            Get
                Return Me.mCustRequestDatField
            End Get
            Set
                Me.mCustRequestDatField = value
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
        
        Public Property ForeignOrderValue() As Object
            Get
                Return Me.foreignOrderValueField
            End Get
            Set
                Me.foreignOrderValueField = value
            End Set
        End Property
        
        Public Property ForeignCurrency() As Object
            Get
                Return Me.foreignCurrencyField
            End Get
            Set
                Me.foreignCurrencyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseLctDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private vesselField As UInteger
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private vesselNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departureDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private estArrivalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipmentReferenceField As String
        
        <CLSCompliant(False)> _
        Public Property Vessel() As UInteger
            Get
                Return Me.vesselField
            End Get
            Set(ByVal value As UInteger)
                Me.vesselField = value
            End Set
        End Property
        
        Public Property VesselName() As String
            Get
                Return Me.vesselNameField
            End Get
            Set
                Me.vesselNameField = value
            End Set
        End Property
        
        Public Property DepartureDate() As String
            Get
                Return Me.departureDateField
            End Get
            Set
                Me.departureDateField = value
            End Set
        End Property
        
        Public Property EstArrivalDate() As String
            Get
                Return Me.estArrivalDateField
            End Get
            Set
                Me.estArrivalDateField = value
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
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property ShipmentReference() As String
            Get
                Return Me.shipmentReferenceField
            End Get
            Set
                Me.shipmentReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseHistory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rejectCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origPurchPrcForField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addReferenceField As String
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
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
        
        Public Property DateReceived() As String
            Get
                Return Me.dateReceivedField
            End Get
            Set
                Me.dateReceivedField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property Reference() As UShort
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As UShort)
                Me.referenceField = value
            End Set
        End Property
        
        Public Property RejectCode() As Object
            Get
                Return Me.rejectCodeField
            End Get
            Set
                Me.rejectCodeField = value
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
        
        Public Property LineDueDate() As String
            Get
                Return Me.lineDueDateField
            End Get
            Set
                Me.lineDueDateField = value
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
        
        Public Property AddReference() As String
            Get
                Return Me.addReferenceField
            End Get
            Set
                Me.addReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseGrn
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnField As UShort
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private origReceiptDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnSourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalEntryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReceivedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnMatchedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractOpField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <CLSCompliant(False)> _
        Public Property Grn() As UShort
            Get
                Return Me.grnField
            End Get
            Set(ByVal value As UShort)
                Me.grnField = value
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
        
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = value
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
        
        Public Property QtyReceived() As String
            Get
                Return Me.qtyReceivedField
            End Get
            Set
                Me.qtyReceivedField = value
            End Set
        End Property
        
        Public Property OutstandingValue() As String
            Get
                Return Me.outstandingValueField
            End Get
            Set
                Me.outstandingValueField = value
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
        
        Public Property Job() As Object
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property SubcontractOp() As String
            Get
                Return Me.subcontractOpField
            End Get
            Set
                Me.subcontractOpField = value
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseRequisition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForReqnField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reqnStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subOperationNumField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexNumField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private extendedValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routingField As PorDetailPurchaseOrderLineMerchandiseRequisitionRouting
        
        Public Sub New()
            MyBase.New
            If (Me.routingField Is Nothing) Then
                Me.routingField = New PorDetailPurchaseOrderLineMerchandiseRequisitionRouting
            End If
        End Sub
        
        Public Property Originator() As String
            Get
                Return Me.originatorField
            End Get
            Set
                Me.originatorField = value
            End Set
        End Property
        
        Public Property Requisition() As String
            Get
                Return Me.requisitionField
            End Get
            Set
                Me.requisitionField = value
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
        
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
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
        
        Public Property ReasonForReqn() As Object
            Get
                Return Me.reasonForReqnField
            End Get
            Set
                Me.reasonForReqnField = value
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
        
        Public Property Discount() As String
            Get
                Return Me.discountField
            End Get
            Set
                Me.discountField = value
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
        
        Public Property Job() As Object
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property SubOperationNum() As Object
            Get
                Return Me.subOperationNumField
            End Get
            Set
                Me.subOperationNumField = value
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
        
        Public Property GlCode() As Object
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property Description() As Object
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property CapexNum() As Object
            Get
                Return Me.capexNumField
            End Get
            Set
                Me.capexNumField = value
            End Set
        End Property
        
        Public Property ExtendedValue() As String
            Get
                Return Me.extendedValueField
            End Get
            Set
                Me.extendedValueField = value
            End Set
        End Property
        
        Public Property Routing() As PorDetailPurchaseOrderLineMerchandiseRequisitionRouting
            Get
                Return Me.routingField
            End Get
            Set
                Me.routingField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PorDetailPurchaseOrderLineMerchandiseRequisitionRouting
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mRequisitionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routedUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeNarrativeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptDateField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingQtyField As String
        
        Public Property MRequisition() As String
            Get
                Return Me.mRequisitionField
            End Get
            Set
                Me.mRequisitionField = value
            End Set
        End Property
        
        Public Property RequisitionLine() As String
            Get
                Return Me.requisitionLineField
            End Get
            Set
                Me.requisitionLineField = value
            End Set
        End Property
        
        Public Property RoutedUser() As String
            Get
                Return Me.routedUserField
            End Get
            Set
                Me.routedUserField = value
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
        
        Public Property ReceiptDate() As Object
            Get
                Return Me.receiptDateField
            End Get
            Set
                Me.receiptDateField = value
            End Set
        End Property
        
        Public Property ReceiptQuantity() As String
            Get
                Return Me.receiptQuantityField
            End Get
            Set
                Me.receiptQuantityField = value
            End Set
        End Property
        
        Public Property OutstandingQty() As String
            Get
                Return Me.outstandingQtyField
            End Get
            Set
                Me.outstandingQtyField = value
            End Set
        End Property
    End Class
End Namespace
