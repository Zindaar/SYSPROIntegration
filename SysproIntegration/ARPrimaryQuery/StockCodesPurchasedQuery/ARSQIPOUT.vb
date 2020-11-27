Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryQuery.StockCodesPurchasedQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ItemsPurchasedQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ItemsPurchasedQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchasedItemField As ItemsPurchasedQueryPurchasedItem
        
        Public Sub New()
            MyBase.New
            If (Me.purchasedItemField Is Nothing) Then
                Me.purchasedItemField = New ItemsPurchasedQueryPurchasedItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ItemsPurchasedQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ItemsPurchasedQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
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
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
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
        
        Public Property PurchasedItem() As ItemsPurchasedQueryPurchasedItem
            Get
                Return Me.purchasedItemField
            End Get
            Set
                Me.purchasedItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemsPurchasedQuerySystemInformation
        
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
    Partial Public Class ItemsPurchasedQueryPurchasedItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPurch1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPricePaid1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUom1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoice1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDate1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private firstDiscPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private secondDisc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thirdDisc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitDiscFlag1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitDiscValue1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPurch2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPricePaid2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUom2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoice2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDate2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private firstDiscPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private secondDisc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thirdDisc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitDiscFlag2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitDiscValue2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentPriceUMField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentLineValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountPct3Field As String
        
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property PartCategory() As String
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
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
        
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        Public Property QtyPurch1() As String
            Get
                Return Me.qtyPurch1Field
            End Get
            Set
                Me.qtyPurch1Field = value
            End Set
        End Property
        
        Public Property LastPricePaid1() As String
            Get
                Return Me.lastPricePaid1Field
            End Get
            Set
                Me.lastPricePaid1Field = value
            End Set
        End Property
        
        Public Property PriceUom1() As String
            Get
                Return Me.priceUom1Field
            End Get
            Set
                Me.priceUom1Field = value
            End Set
        End Property
        
        Public Property Invoice1() As String
            Get
                Return Me.invoice1Field
            End Get
            Set
                Me.invoice1Field = value
            End Set
        End Property
        
        Public Property InvoiceDate1() As String
            Get
                Return Me.invoiceDate1Field
            End Get
            Set
                Me.invoiceDate1Field = value
            End Set
        End Property
        
        Public Property FirstDiscPct1() As String
            Get
                Return Me.firstDiscPct1Field
            End Get
            Set
                Me.firstDiscPct1Field = value
            End Set
        End Property
        
        Public Property SecondDisc1() As String
            Get
                Return Me.secondDisc1Field
            End Get
            Set
                Me.secondDisc1Field = value
            End Set
        End Property
        
        Public Property ThirdDisc1() As String
            Get
                Return Me.thirdDisc1Field
            End Get
            Set
                Me.thirdDisc1Field = value
            End Set
        End Property
        
        Public Property UnitDiscFlag1() As String
            Get
                Return Me.unitDiscFlag1Field
            End Get
            Set
                Me.unitDiscFlag1Field = value
            End Set
        End Property
        
        Public Property UnitDiscValue1() As String
            Get
                Return Me.unitDiscValue1Field
            End Get
            Set
                Me.unitDiscValue1Field = value
            End Set
        End Property
        
        Public Property QtyPurch2() As String
            Get
                Return Me.qtyPurch2Field
            End Get
            Set
                Me.qtyPurch2Field = value
            End Set
        End Property
        
        Public Property LastPricePaid2() As String
            Get
                Return Me.lastPricePaid2Field
            End Get
            Set
                Me.lastPricePaid2Field = value
            End Set
        End Property
        
        Public Property PriceUom2() As String
            Get
                Return Me.priceUom2Field
            End Get
            Set
                Me.priceUom2Field = value
            End Set
        End Property
        
        Public Property Invoice2() As String
            Get
                Return Me.invoice2Field
            End Get
            Set
                Me.invoice2Field = value
            End Set
        End Property
        
        Public Property InvoiceDate2() As String
            Get
                Return Me.invoiceDate2Field
            End Get
            Set
                Me.invoiceDate2Field = value
            End Set
        End Property
        
        Public Property FirstDiscPct2() As String
            Get
                Return Me.firstDiscPct2Field
            End Get
            Set
                Me.firstDiscPct2Field = value
            End Set
        End Property
        
        Public Property SecondDisc2() As String
            Get
                Return Me.secondDisc2Field
            End Get
            Set
                Me.secondDisc2Field = value
            End Set
        End Property
        
        Public Property ThirdDisc2() As String
            Get
                Return Me.thirdDisc2Field
            End Get
            Set
                Me.thirdDisc2Field = value
            End Set
        End Property
        
        Public Property UnitDiscFlag2() As String
            Get
                Return Me.unitDiscFlag2Field
            End Get
            Set
                Me.unitDiscFlag2Field = value
            End Set
        End Property
        
        Public Property UnitDiscValue2() As String
            Get
                Return Me.unitDiscValue2Field
            End Get
            Set
                Me.unitDiscValue2Field = value
            End Set
        End Property
        
        Public Property CurrentPrice() As String
            Get
                Return Me.currentPriceField
            End Get
            Set
                Me.currentPriceField = value
            End Set
        End Property
        
        Public Property CurrentPriceUM() As String
            Get
                Return Me.currentPriceUMField
            End Get
            Set
                Me.currentPriceUMField = value
            End Set
        End Property
        
        Public Property CurrentLineValue() As String
            Get
                Return Me.currentLineValueField
            End Get
            Set
                Me.currentLineValueField = value
            End Set
        End Property
        
        Public Property DiscountValueFlag() As String
            Get
                Return Me.discountValueFlagField
            End Get
            Set
                Me.discountValueFlagField = value
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
        
        Public Property DiscountPct1() As String
            Get
                Return Me.discountPct1Field
            End Get
            Set
                Me.discountPct1Field = value
            End Set
        End Property
        
        Public Property DiscountPct2() As String
            Get
                Return Me.discountPct2Field
            End Get
            Set
                Me.discountPct2Field = value
            End Set
        End Property
        
        Public Property DiscountPct3() As String
            Get
                Return Me.discountPct3Field
            End Get
            Set
                Me.discountPct3Field = value
            End Set
        End Property
    End Class
End Namespace
