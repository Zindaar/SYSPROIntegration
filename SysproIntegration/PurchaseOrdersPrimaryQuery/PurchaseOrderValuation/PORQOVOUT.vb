Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryQuery.PurchaseOrderValuation.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PurchaseOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As PurchaseOrderValuesSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As PurchaseOrderValuesPurchaseOrder
        
        Public Sub New()
            MyBase.New
            If (Me.purchaseOrderField Is Nothing) Then
                Me.purchaseOrderField = New PurchaseOrderValuesPurchaseOrder
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New PurchaseOrderValuesSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As PurchaseOrderValuesSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property PurchaseOrder() As PurchaseOrderValuesPurchaseOrder
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesSystemInformation
        
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
    Partial Public Class PurchaseOrderValuesPurchaseOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localCurrencyField As PurchaseOrderValuesPurchaseOrderLocalCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderCurrencyField As PurchaseOrderValuesPurchaseOrderOrderCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massToReceiveField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massOnOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeToReceiveField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeOnOrderField As String
        
        Public Sub New()
            MyBase.New
            If (Me.orderCurrencyField Is Nothing) Then
                Me.orderCurrencyField = New PurchaseOrderValuesPurchaseOrderOrderCurrency
            End If
            If (Me.localCurrencyField Is Nothing) Then
                Me.localCurrencyField = New PurchaseOrderValuesPurchaseOrderLocalCurrency
            End If
        End Sub
        
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
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
        
        Public Property LocalCurrency() As PurchaseOrderValuesPurchaseOrderLocalCurrency
            Get
                Return Me.localCurrencyField
            End Get
            Set
                Me.localCurrencyField = value
            End Set
        End Property
        
        Public Property OrderCurrency() As PurchaseOrderValuesPurchaseOrderOrderCurrency
            Get
                Return Me.orderCurrencyField
            End Get
            Set
                Me.orderCurrencyField = value
            End Set
        End Property
        
        Public Property MassToReceive() As String
            Get
                Return Me.massToReceiveField
            End Get
            Set
                Me.massToReceiveField = value
            End Set
        End Property
        
        Public Property MassOnOrder() As String
            Get
                Return Me.massOnOrderField
            End Get
            Set
                Me.massOnOrderField = value
            End Set
        End Property
        
        Public Property VolumeToReceive() As String
            Get
                Return Me.volumeToReceiveField
            End Get
            Set
                Me.volumeToReceiveField = value
            End Set
        End Property
        
        Public Property VolumeOnOrder() As String
            Get
                Return Me.volumeOnOrderField
            End Get
            Set
                Me.volumeOnOrderField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderLocalCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingValuesField As PurchaseOrderValuesPurchaseOrderLocalCurrencyOutstandingValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalValuesField As PurchaseOrderValuesPurchaseOrderLocalCurrencyOriginalValues
        
        Public Sub New()
            MyBase.New
            If (Me.originalValuesField Is Nothing) Then
                Me.originalValuesField = New PurchaseOrderValuesPurchaseOrderLocalCurrencyOriginalValues
            End If
            If (Me.outstandingValuesField Is Nothing) Then
                Me.outstandingValuesField = New PurchaseOrderValuesPurchaseOrderLocalCurrencyOutstandingValues
            End If
        End Sub
        
        Public Property OutstandingValues() As PurchaseOrderValuesPurchaseOrderLocalCurrencyOutstandingValues
            Get
                Return Me.outstandingValuesField
            End Get
            Set
                Me.outstandingValuesField = value
            End Set
        End Property
        
        Public Property OriginalValues() As PurchaseOrderValuesPurchaseOrderLocalCurrencyOriginalValues
            Get
                Return Me.originalValuesField
            End Get
            Set
                Me.originalValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderLocalCurrencyOutstandingValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netFreightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountTotalField As String
        
        Public Property NetMerchValue() As String
            Get
                Return Me.netMerchValueField
            End Get
            Set
                Me.netMerchValueField = value
            End Set
        End Property
        
        Public Property NetTotal() As String
            Get
                Return Me.netTotalField
            End Get
            Set
                Me.netTotalField = value
            End Set
        End Property
        
        Public Property NetFreightValue() As String
            Get
                Return Me.netFreightValueField
            End Get
            Set
                Me.netFreightValueField = value
            End Set
        End Property
        
        Public Property NetMiscValue() As String
            Get
                Return Me.netMiscValueField
            End Get
            Set
                Me.netMiscValueField = value
            End Set
        End Property
        
        Public Property GrossMerchValue() As String
            Get
                Return Me.grossMerchValueField
            End Get
            Set
                Me.grossMerchValueField = value
            End Set
        End Property
        
        Public Property GrossMerchTotal() As String
            Get
                Return Me.grossMerchTotalField
            End Get
            Set
                Me.grossMerchTotalField = value
            End Set
        End Property
        
        Public Property DiscMerchValue() As String
            Get
                Return Me.discMerchValueField
            End Get
            Set
                Me.discMerchValueField = value
            End Set
        End Property
        
        Public Property DiscountTotal() As String
            Get
                Return Me.discountTotalField
            End Get
            Set
                Me.discountTotalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderLocalCurrencyOriginalValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netFreightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountTotalField As String
        
        Public Property NetMerchValue() As String
            Get
                Return Me.netMerchValueField
            End Get
            Set
                Me.netMerchValueField = value
            End Set
        End Property
        
        Public Property NetTotal() As String
            Get
                Return Me.netTotalField
            End Get
            Set
                Me.netTotalField = value
            End Set
        End Property
        
        Public Property NetFreightValue() As String
            Get
                Return Me.netFreightValueField
            End Get
            Set
                Me.netFreightValueField = value
            End Set
        End Property
        
        Public Property NetMiscValue() As String
            Get
                Return Me.netMiscValueField
            End Get
            Set
                Me.netMiscValueField = value
            End Set
        End Property
        
        Public Property GrossMerchValue() As String
            Get
                Return Me.grossMerchValueField
            End Get
            Set
                Me.grossMerchValueField = value
            End Set
        End Property
        
        Public Property GrossMerchTotal() As String
            Get
                Return Me.grossMerchTotalField
            End Get
            Set
                Me.grossMerchTotalField = value
            End Set
        End Property
        
        Public Property DiscMerchValue() As String
            Get
                Return Me.discMerchValueField
            End Get
            Set
                Me.discMerchValueField = value
            End Set
        End Property
        
        Public Property DiscountTotal() As String
            Get
                Return Me.discountTotalField
            End Get
            Set
                Me.discountTotalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderOrderCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstandingValuesField As PurchaseOrderValuesPurchaseOrderOrderCurrencyOutstandingValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originalValuesField As PurchaseOrderValuesPurchaseOrderOrderCurrencyOriginalValues
        
        Public Sub New()
            MyBase.New
            If (Me.originalValuesField Is Nothing) Then
                Me.originalValuesField = New PurchaseOrderValuesPurchaseOrderOrderCurrencyOriginalValues
            End If
            If (Me.outstandingValuesField Is Nothing) Then
                Me.outstandingValuesField = New PurchaseOrderValuesPurchaseOrderOrderCurrencyOutstandingValues
            End If
        End Sub
        
        Public Property OutstandingValues() As PurchaseOrderValuesPurchaseOrderOrderCurrencyOutstandingValues
            Get
                Return Me.outstandingValuesField
            End Get
            Set
                Me.outstandingValuesField = value
            End Set
        End Property
        
        Public Property OriginalValues() As PurchaseOrderValuesPurchaseOrderOrderCurrencyOriginalValues
            Get
                Return Me.originalValuesField
            End Get
            Set
                Me.originalValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderOrderCurrencyOutstandingValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netFreightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountTotalField As String
        
        Public Property NetMerchValue() As String
            Get
                Return Me.netMerchValueField
            End Get
            Set
                Me.netMerchValueField = value
            End Set
        End Property
        
        Public Property NetTotal() As String
            Get
                Return Me.netTotalField
            End Get
            Set
                Me.netTotalField = value
            End Set
        End Property
        
        Public Property NetFreightValue() As String
            Get
                Return Me.netFreightValueField
            End Get
            Set
                Me.netFreightValueField = value
            End Set
        End Property
        
        Public Property NetMiscValue() As String
            Get
                Return Me.netMiscValueField
            End Get
            Set
                Me.netMiscValueField = value
            End Set
        End Property
        
        Public Property GrossMerchValue() As String
            Get
                Return Me.grossMerchValueField
            End Get
            Set
                Me.grossMerchValueField = value
            End Set
        End Property
        
        Public Property GrossMerchTotal() As String
            Get
                Return Me.grossMerchTotalField
            End Get
            Set
                Me.grossMerchTotalField = value
            End Set
        End Property
        
        Public Property DiscMerchValue() As String
            Get
                Return Me.discMerchValueField
            End Get
            Set
                Me.discMerchValueField = value
            End Set
        End Property
        
        Public Property DiscountTotal() As String
            Get
                Return Me.discountTotalField
            End Get
            Set
                Me.discountTotalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PurchaseOrderValuesPurchaseOrderOrderCurrencyOriginalValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netFreightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netMiscValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossMerchTotalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discMerchValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountTotalField As String
        
        Public Property NetMerchValue() As String
            Get
                Return Me.netMerchValueField
            End Get
            Set
                Me.netMerchValueField = value
            End Set
        End Property
        
        Public Property NetTotal() As String
            Get
                Return Me.netTotalField
            End Get
            Set
                Me.netTotalField = value
            End Set
        End Property
        
        Public Property NetFreightValue() As String
            Get
                Return Me.netFreightValueField
            End Get
            Set
                Me.netFreightValueField = value
            End Set
        End Property
        
        Public Property NetMiscValue() As String
            Get
                Return Me.netMiscValueField
            End Get
            Set
                Me.netMiscValueField = value
            End Set
        End Property
        
        Public Property GrossMerchValue() As String
            Get
                Return Me.grossMerchValueField
            End Get
            Set
                Me.grossMerchValueField = value
            End Set
        End Property
        
        Public Property GrossMerchTotal() As String
            Get
                Return Me.grossMerchTotalField
            End Get
            Set
                Me.grossMerchTotalField = value
            End Set
        End Property
        
        Public Property DiscMerchValue() As String
            Get
                Return Me.discMerchValueField
            End Get
            Set
                Me.discMerchValueField = value
            End Set
        End Property
        
        Public Property DiscountTotal() As String
            Get
                Return Me.discountTotalField
            End Get
            Set
                Me.discountTotalField = value
            End Set
        End Property
    End Class
End Namespace
