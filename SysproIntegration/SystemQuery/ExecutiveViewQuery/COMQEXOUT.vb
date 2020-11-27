Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ExecutiveViewQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ExecutiveViewQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ExecutiveViewQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankBalanceField As List(Of ExecutiveViewQueryBankItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private apBalanceField As ExecutiveViewQueryApBalance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arBalanceField As ExecutiveViewQueryArBalance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inventoryValuationField As List(Of ExecutiveViewQueryWarehouseItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipValuationField As ExecutiveViewQueryWipValuation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersTakenField As ExecutiveViewQueryOrdersTaken
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lostSalesField As ExecutiveViewQueryLostSales
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderValuesField As ExecutiveViewQueryPurchaseOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderValuesField As ExecutiveViewQuerySalesOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sOAgedValuesField As ExecutiveViewQuerySOAgedValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesByProductClassField As ExecutiveViewQuerySalesByProductClass
        
        Public Sub New()
            MyBase.New
            If (Me.salesByProductClassField Is Nothing) Then
                Me.salesByProductClassField = New ExecutiveViewQuerySalesByProductClass
            End If
            If (Me.sOAgedValuesField Is Nothing) Then
                Me.sOAgedValuesField = New ExecutiveViewQuerySOAgedValues
            End If
            If (Me.salesOrderValuesField Is Nothing) Then
                Me.salesOrderValuesField = New ExecutiveViewQuerySalesOrderValues
            End If
            If (Me.purchaseOrderValuesField Is Nothing) Then
                Me.purchaseOrderValuesField = New ExecutiveViewQueryPurchaseOrderValues
            End If
            If (Me.lostSalesField Is Nothing) Then
                Me.lostSalesField = New ExecutiveViewQueryLostSales
            End If
            If (Me.ordersTakenField Is Nothing) Then
                Me.ordersTakenField = New ExecutiveViewQueryOrdersTaken
            End If
            If (Me.wipValuationField Is Nothing) Then
                Me.wipValuationField = New ExecutiveViewQueryWipValuation
            End If
            If (Me.inventoryValuationField Is Nothing) Then
                Me.inventoryValuationField = New List(Of ExecutiveViewQueryWarehouseItem)
            End If
            If (Me.arBalanceField Is Nothing) Then
                Me.arBalanceField = New ExecutiveViewQueryArBalance
            End If
            If (Me.apBalanceField Is Nothing) Then
                Me.apBalanceField = New ExecutiveViewQueryApBalance
            End If
            If (Me.bankBalanceField Is Nothing) Then
                Me.bankBalanceField = New List(Of ExecutiveViewQueryBankItem)
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ExecutiveViewQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ExecutiveViewQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("BankItem", IsNullable:=false)>  _
        Public Property BankBalanceCollection() As List(Of ExecutiveViewQueryBankItem)
            Get
                Return Me.bankBalanceField
            End Get
            Set
                Me.bankBalanceField = value
            End Set
        End Property
        
        Public Property ApBalance() As ExecutiveViewQueryApBalance
            Get
                Return Me.apBalanceField
            End Get
            Set
                Me.apBalanceField = value
            End Set
        End Property
        
        Public Property ArBalance() As ExecutiveViewQueryArBalance
            Get
                Return Me.arBalanceField
            End Get
            Set
                Me.arBalanceField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("WarehouseItem", IsNullable:=false)>  _
        Public Property InventoryValuationCollection() As List(Of ExecutiveViewQueryWarehouseItem)
            Get
                Return Me.inventoryValuationField
            End Get
            Set
                Me.inventoryValuationField = value
            End Set
        End Property
        
        Public Property WipValuation() As ExecutiveViewQueryWipValuation
            Get
                Return Me.wipValuationField
            End Get
            Set
                Me.wipValuationField = value
            End Set
        End Property
        
        Public Property OrdersTaken() As ExecutiveViewQueryOrdersTaken
            Get
                Return Me.ordersTakenField
            End Get
            Set
                Me.ordersTakenField = value
            End Set
        End Property
        
        Public Property LostSales() As ExecutiveViewQueryLostSales
            Get
                Return Me.lostSalesField
            End Get
            Set
                Me.lostSalesField = value
            End Set
        End Property
        
        Public Property PurchaseOrderValues() As ExecutiveViewQueryPurchaseOrderValues
            Get
                Return Me.purchaseOrderValuesField
            End Get
            Set
                Me.purchaseOrderValuesField = value
            End Set
        End Property
        
        Public Property SalesOrderValues() As ExecutiveViewQuerySalesOrderValues
            Get
                Return Me.salesOrderValuesField
            End Get
            Set
                Me.salesOrderValuesField = value
            End Set
        End Property
        
        Public Property SOAgedValues() As ExecutiveViewQuerySOAgedValues
            Get
                Return Me.sOAgedValuesField
            End Get
            Set
                Me.sOAgedValuesField = value
            End Set
        End Property
        
        Public Property SalesByProductClass() As ExecutiveViewQuerySalesByProductClass
            Get
                Return Me.salesByProductClassField
            End Get
            Set
                Me.salesByProductClassField = value
            End Set
        End Property

    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As Object
        
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
        Private operatorEmailAddressField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        Public Property CssStyle() As Object
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
        
        Public Property OperatorEmailAddress() As Object
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As Object
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
    Partial Public Class ExecutiveViewQueryBankItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBal1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBal2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBal3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBalLoc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBalLoc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbStmtBalLoc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBal1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBal2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBal3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBalLoc1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBalLoc2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbCurBalLoc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyExchangeRateField As String
        
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
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
        
        Public Property CbStmtBal1() As String
            Get
                Return Me.cbStmtBal1Field
            End Get
            Set
                Me.cbStmtBal1Field = value
            End Set
        End Property
        
        Public Property CbStmtBal2() As String
            Get
                Return Me.cbStmtBal2Field
            End Get
            Set
                Me.cbStmtBal2Field = value
            End Set
        End Property
        
        Public Property CbStmtBal3() As String
            Get
                Return Me.cbStmtBal3Field
            End Get
            Set
                Me.cbStmtBal3Field = value
            End Set
        End Property
        
        Public Property CbStmtBalLoc1() As String
            Get
                Return Me.cbStmtBalLoc1Field
            End Get
            Set
                Me.cbStmtBalLoc1Field = value
            End Set
        End Property
        
        Public Property CbStmtBalLoc2() As String
            Get
                Return Me.cbStmtBalLoc2Field
            End Get
            Set
                Me.cbStmtBalLoc2Field = value
            End Set
        End Property
        
        Public Property CbStmtBalLoc3() As String
            Get
                Return Me.cbStmtBalLoc3Field
            End Get
            Set
                Me.cbStmtBalLoc3Field = value
            End Set
        End Property
        
        Public Property CbCurBal1() As String
            Get
                Return Me.cbCurBal1Field
            End Get
            Set
                Me.cbCurBal1Field = value
            End Set
        End Property
        
        Public Property CbCurBal2() As String
            Get
                Return Me.cbCurBal2Field
            End Get
            Set
                Me.cbCurBal2Field = value
            End Set
        End Property
        
        Public Property CbCurBal3() As String
            Get
                Return Me.cbCurBal3Field
            End Get
            Set
                Me.cbCurBal3Field = value
            End Set
        End Property
        
        Public Property CbCurBalLoc1() As String
            Get
                Return Me.cbCurBalLoc1Field
            End Get
            Set
                Me.cbCurBalLoc1Field = value
            End Set
        End Property
        
        Public Property CbCurBalLoc2() As String
            Get
                Return Me.cbCurBalLoc2Field
            End Get
            Set
                Me.cbCurBalLoc2Field = value
            End Set
        End Property
        
        Public Property CbCurBalLoc3() As String
            Get
                Return Me.cbCurBalLoc3Field
            End Get
            Set
                Me.cbCurBalLoc3Field = value
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
        
        Public Property BuyExchangeRate() As String
            Get
                Return Me.buyExchangeRateField
            End Get
            Set
                Me.buyExchangeRateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryApBalance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private curBalance1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private curBalance2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private curBalance3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdInvoices1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdInvoices2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdInvoices3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebit1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebit2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebit3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredit1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredit2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredit3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustment1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustment2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustment3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDisburse1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDisburse2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDisburse3Field As String
        
        Public Property CurBalance1() As String
            Get
                Return Me.curBalance1Field
            End Get
            Set
                Me.curBalance1Field = value
            End Set
        End Property
        
        Public Property CurBalance2() As String
            Get
                Return Me.curBalance2Field
            End Get
            Set
                Me.curBalance2Field = value
            End Set
        End Property
        
        Public Property CurBalance3() As String
            Get
                Return Me.curBalance3Field
            End Get
            Set
                Me.curBalance3Field = value
            End Set
        End Property
        
        Public Property OpeningBalance1() As String
            Get
                Return Me.openingBalance1Field
            End Get
            Set
                Me.openingBalance1Field = value
            End Set
        End Property
        
        Public Property OpeningBalance2() As String
            Get
                Return Me.openingBalance2Field
            End Get
            Set
                Me.openingBalance2Field = value
            End Set
        End Property
        
        Public Property OpeningBalance3() As String
            Get
                Return Me.openingBalance3Field
            End Get
            Set
                Me.openingBalance3Field = value
            End Set
        End Property
        
        Public Property MtdInvoices1() As String
            Get
                Return Me.mtdInvoices1Field
            End Get
            Set
                Me.mtdInvoices1Field = value
            End Set
        End Property
        
        Public Property MtdInvoices2() As String
            Get
                Return Me.mtdInvoices2Field
            End Get
            Set
                Me.mtdInvoices2Field = value
            End Set
        End Property
        
        Public Property MtdInvoices3() As String
            Get
                Return Me.mtdInvoices3Field
            End Get
            Set
                Me.mtdInvoices3Field = value
            End Set
        End Property
        
        Public Property MtdDebit1() As String
            Get
                Return Me.mtdDebit1Field
            End Get
            Set
                Me.mtdDebit1Field = value
            End Set
        End Property
        
        Public Property MtdDebit2() As String
            Get
                Return Me.mtdDebit2Field
            End Get
            Set
                Me.mtdDebit2Field = value
            End Set
        End Property
        
        Public Property MtdDebit3() As String
            Get
                Return Me.mtdDebit3Field
            End Get
            Set
                Me.mtdDebit3Field = value
            End Set
        End Property
        
        Public Property MtdCredit1() As String
            Get
                Return Me.mtdCredit1Field
            End Get
            Set
                Me.mtdCredit1Field = value
            End Set
        End Property
        
        Public Property MtdCredit2() As String
            Get
                Return Me.mtdCredit2Field
            End Get
            Set
                Me.mtdCredit2Field = value
            End Set
        End Property
        
        Public Property MtdCredit3() As String
            Get
                Return Me.mtdCredit3Field
            End Get
            Set
                Me.mtdCredit3Field = value
            End Set
        End Property
        
        Public Property MtdAdjustment1() As String
            Get
                Return Me.mtdAdjustment1Field
            End Get
            Set
                Me.mtdAdjustment1Field = value
            End Set
        End Property
        
        Public Property MtdAdjustment2() As String
            Get
                Return Me.mtdAdjustment2Field
            End Get
            Set
                Me.mtdAdjustment2Field = value
            End Set
        End Property
        
        Public Property MtdAdjustment3() As String
            Get
                Return Me.mtdAdjustment3Field
            End Get
            Set
                Me.mtdAdjustment3Field = value
            End Set
        End Property
        
        Public Property MtdDisburse1() As String
            Get
                Return Me.mtdDisburse1Field
            End Get
            Set
                Me.mtdDisburse1Field = value
            End Set
        End Property
        
        Public Property MtdDisburse2() As String
            Get
                Return Me.mtdDisburse2Field
            End Get
            Set
                Me.mtdDisburse2Field = value
            End Set
        End Property
        
        Public Property MtdDisburse3() As String
            Get
                Return Me.mtdDisburse3Field
            End Get
            Set
                Me.mtdDisburse3Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryArBalance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arBalance1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arBalance2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arBalance3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdTax1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdTax2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdTax3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdIbt1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdIbt2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdIb3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustments1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustments2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdAdjustments3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDiscounts1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDiscounts2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDiscounts3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebits1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebits2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdDebits3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdPayments1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdPayments2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdPayments3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredits1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredits2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdCredits3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private openingBalance3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdSalesInvoiced1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdSalesInvoiced2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdSalesInvoiced3Field As String
        
        Public Property ArBalance1() As String
            Get
                Return Me.arBalance1Field
            End Get
            Set
                Me.arBalance1Field = value
            End Set
        End Property
        
        Public Property ArBalance2() As String
            Get
                Return Me.arBalance2Field
            End Get
            Set
                Me.arBalance2Field = value
            End Set
        End Property
        
        Public Property ArBalance3() As String
            Get
                Return Me.arBalance3Field
            End Get
            Set
                Me.arBalance3Field = value
            End Set
        End Property
        
        Public Property MtdTax1() As String
            Get
                Return Me.mtdTax1Field
            End Get
            Set
                Me.mtdTax1Field = value
            End Set
        End Property
        
        Public Property MtdTax2() As String
            Get
                Return Me.mtdTax2Field
            End Get
            Set
                Me.mtdTax2Field = value
            End Set
        End Property
        
        Public Property MtdTax3() As String
            Get
                Return Me.mtdTax3Field
            End Get
            Set
                Me.mtdTax3Field = value
            End Set
        End Property
        
        Public Property MtdIbt1() As String
            Get
                Return Me.mtdIbt1Field
            End Get
            Set
                Me.mtdIbt1Field = value
            End Set
        End Property
        
        Public Property MtdIbt2() As String
            Get
                Return Me.mtdIbt2Field
            End Get
            Set
                Me.mtdIbt2Field = value
            End Set
        End Property
        
        Public Property MtdIb3() As String
            Get
                Return Me.mtdIb3Field
            End Get
            Set
                Me.mtdIb3Field = value
            End Set
        End Property
        
        Public Property MtdAdjustments1() As String
            Get
                Return Me.mtdAdjustments1Field
            End Get
            Set
                Me.mtdAdjustments1Field = value
            End Set
        End Property
        
        Public Property MtdAdjustments2() As String
            Get
                Return Me.mtdAdjustments2Field
            End Get
            Set
                Me.mtdAdjustments2Field = value
            End Set
        End Property
        
        Public Property MtdAdjustments3() As String
            Get
                Return Me.mtdAdjustments3Field
            End Get
            Set
                Me.mtdAdjustments3Field = value
            End Set
        End Property
        
        Public Property MtdDiscounts1() As String
            Get
                Return Me.mtdDiscounts1Field
            End Get
            Set
                Me.mtdDiscounts1Field = value
            End Set
        End Property
        
        Public Property MtdDiscounts2() As String
            Get
                Return Me.mtdDiscounts2Field
            End Get
            Set
                Me.mtdDiscounts2Field = value
            End Set
        End Property
        
        Public Property MtdDiscounts3() As String
            Get
                Return Me.mtdDiscounts3Field
            End Get
            Set
                Me.mtdDiscounts3Field = value
            End Set
        End Property
        
        Public Property MtdDebits1() As String
            Get
                Return Me.mtdDebits1Field
            End Get
            Set
                Me.mtdDebits1Field = value
            End Set
        End Property
        
        Public Property MtdDebits2() As String
            Get
                Return Me.mtdDebits2Field
            End Get
            Set
                Me.mtdDebits2Field = value
            End Set
        End Property
        
        Public Property MtdDebits3() As String
            Get
                Return Me.mtdDebits3Field
            End Get
            Set
                Me.mtdDebits3Field = value
            End Set
        End Property
        
        Public Property MtdPayments1() As String
            Get
                Return Me.mtdPayments1Field
            End Get
            Set
                Me.mtdPayments1Field = value
            End Set
        End Property
        
        Public Property MtdPayments2() As String
            Get
                Return Me.mtdPayments2Field
            End Get
            Set
                Me.mtdPayments2Field = value
            End Set
        End Property
        
        Public Property MtdPayments3() As String
            Get
                Return Me.mtdPayments3Field
            End Get
            Set
                Me.mtdPayments3Field = value
            End Set
        End Property
        
        Public Property MtdCredits1() As String
            Get
                Return Me.mtdCredits1Field
            End Get
            Set
                Me.mtdCredits1Field = value
            End Set
        End Property
        
        Public Property MtdCredits2() As String
            Get
                Return Me.mtdCredits2Field
            End Get
            Set
                Me.mtdCredits2Field = value
            End Set
        End Property
        
        Public Property MtdCredits3() As String
            Get
                Return Me.mtdCredits3Field
            End Get
            Set
                Me.mtdCredits3Field = value
            End Set
        End Property
        
        Public Property OpeningBalance1() As String
            Get
                Return Me.openingBalance1Field
            End Get
            Set
                Me.openingBalance1Field = value
            End Set
        End Property
        
        Public Property OpeningBalance2() As String
            Get
                Return Me.openingBalance2Field
            End Get
            Set
                Me.openingBalance2Field = value
            End Set
        End Property
        
        Public Property OpeningBalance3() As String
            Get
                Return Me.openingBalance3Field
            End Get
            Set
                Me.openingBalance3Field = value
            End Set
        End Property
        
        Public Property MtdSalesInvoiced1() As String
            Get
                Return Me.mtdSalesInvoiced1Field
            End Get
            Set
                Me.mtdSalesInvoiced1Field = value
            End Set
        End Property
        
        Public Property MtdSalesInvoiced2() As String
            Get
                Return Me.mtdSalesInvoiced2Field
            End Get
            Set
                Me.mtdSalesInvoiced2Field = value
            End Set
        End Property
        
        Public Property MtdSalesInvoiced3() As String
            Get
                Return Me.mtdSalesInvoiced3Field
            End Get
            Set
                Me.mtdSalesInvoiced3Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryWarehouseItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseValueCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseValuePrev1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseValuePrev2Field As String
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
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
        
        Public Property WarehouseValueCur() As String
            Get
                Return Me.warehouseValueCurField
            End Get
            Set
                Me.warehouseValueCurField = value
            End Set
        End Property
        
        Public Property WarehouseValuePrev1() As String
            Get
                Return Me.warehouseValuePrev1Field
            End Get
            Set
                Me.warehouseValuePrev1Field = value
            End Set
        End Property
        
        Public Property WarehouseValuePrev2() As String
            Get
                Return Me.warehouseValuePrev2Field
            End Get
            Set
                Me.warehouseValuePrev2Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryWipValuation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipValueCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipValuePrev1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipValuePrev2Field As String
        
        Public Property WipValueCur() As String
            Get
                Return Me.wipValueCurField
            End Get
            Set
                Me.wipValueCurField = value
            End Set
        End Property
        
        Public Property WipValuePrev1() As String
            Get
                Return Me.wipValuePrev1Field
            End Get
            Set
                Me.wipValuePrev1Field = value
            End Set
        End Property
        
        Public Property WipValuePrev2() As String
            Get
                Return Me.wipValuePrev2Field
            End Get
            Set
                Me.wipValuePrev2Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryOrdersTaken
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thisWeekField As ExecutiveViewQueryOrdersTakenThisWeek
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yesterdayField As ExecutiveViewQueryOrdersTakenYesterday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private todayField As ExecutiveViewQueryOrdersTakenToday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private topField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As String
        
        Public Sub New()
            MyBase.New
            If (Me.todayField Is Nothing) Then
                Me.todayField = New ExecutiveViewQueryOrdersTakenToday
            End If
            If (Me.yesterdayField Is Nothing) Then
                Me.yesterdayField = New ExecutiveViewQueryOrdersTakenYesterday
            End If
            If (Me.thisWeekField Is Nothing) Then
                Me.thisWeekField = New ExecutiveViewQueryOrdersTakenThisWeek
            End If
        End Sub
        
        Public Property ThisWeek() As ExecutiveViewQueryOrdersTakenThisWeek
            Get
                Return Me.thisWeekField
            End Get
            Set
                Me.thisWeekField = value
            End Set
        End Property
        
        Public Property Yesterday() As ExecutiveViewQueryOrdersTakenYesterday
            Get
                Return Me.yesterdayField
            End Get
            Set
                Me.yesterdayField = value
            End Set
        End Property
        
        Public Property Today() As ExecutiveViewQueryOrdersTakenToday
            Get
                Return Me.todayField
            End Get
            Set
                Me.todayField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Top() As String
            Get
                Return Me.topField
            End Get
            Set
                Me.topField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FromDate() As String
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property ToDate() As String
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryOrdersTakenThisWeek
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelledField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private topField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        Public Property Added() As String
            Get
                Return Me.addedField
            End Get
            Set
                Me.addedField = value
            End Set
        End Property
        
        Public Property Changed() As String
            Get
                Return Me.changedField
            End Get
            Set
                Me.changedField = value
            End Set
        End Property
        
        Public Property Cancelled() As String
            Get
                Return Me.cancelledField
            End Get
            Set
                Me.cancelledField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Top() As String
            Get
                Return Me.topField
            End Get
            Set
                Me.topField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Neg() As String
            Get
                Return Me.negField
            End Get
            Set
                Me.negField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryOrdersTakenYesterday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelledField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private topField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        Public Property Added() As String
            Get
                Return Me.addedField
            End Get
            Set
                Me.addedField = value
            End Set
        End Property
        
        Public Property Changed() As String
            Get
                Return Me.changedField
            End Get
            Set
                Me.changedField = value
            End Set
        End Property
        
        Public Property Cancelled() As String
            Get
                Return Me.cancelledField
            End Get
            Set
                Me.cancelledField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Top() As String
            Get
                Return Me.topField
            End Get
            Set
                Me.topField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Neg() As String
            Get
                Return Me.negField
            End Get
            Set
                Me.negField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryOrdersTakenToday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private changedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cancelledField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private topField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        Public Property Added() As String
            Get
                Return Me.addedField
            End Get
            Set
                Me.addedField = value
            End Set
        End Property
        
        Public Property Changed() As String
            Get
                Return Me.changedField
            End Get
            Set
                Me.changedField = value
            End Set
        End Property
        
        Public Property Cancelled() As String
            Get
                Return Me.cancelledField
            End Get
            Set
                Me.cancelledField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Top() As String
            Get
                Return Me.topField
            End Get
            Set
                Me.topField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Neg() As String
            Get
                Return Me.negField
            End Get
            Set
                Me.negField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryLostSales
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private todayField As ExecutiveViewQueryLostSalesToday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yesterdayField As ExecutiveViewQueryLostSalesYesterday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thisWeekField As ExecutiveViewQueryLostSalesThisWeek
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private topField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As String
        
        Public Sub New()
            MyBase.New
            If (Me.thisWeekField Is Nothing) Then
                Me.thisWeekField = New ExecutiveViewQueryLostSalesThisWeek
            End If
            If (Me.yesterdayField Is Nothing) Then
                Me.yesterdayField = New ExecutiveViewQueryLostSalesYesterday
            End If
            If (Me.todayField Is Nothing) Then
                Me.todayField = New ExecutiveViewQueryLostSalesToday
            End If
        End Sub
        
        Public Property Today() As ExecutiveViewQueryLostSalesToday
            Get
                Return Me.todayField
            End Get
            Set
                Me.todayField = value
            End Set
        End Property
        
        Public Property Yesterday() As ExecutiveViewQueryLostSalesYesterday
            Get
                Return Me.yesterdayField
            End Get
            Set
                Me.yesterdayField = value
            End Set
        End Property
        
        Public Property ThisWeek() As ExecutiveViewQueryLostSalesThisWeek
            Get
                Return Me.thisWeekField
            End Get
            Set
                Me.thisWeekField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Top() As String
            Get
                Return Me.topField
            End Get
            Set
                Me.topField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FromDate() As String
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property ToDate() As String
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryLostSalesToday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
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
    Partial Public Class ExecutiveViewQueryLostSalesYesterday
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
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
    Partial Public Class ExecutiveViewQueryLostSalesThisWeek
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property FromDate() As Date
            Get
                Return Me.fromDateField
            End Get
            Set
                Me.fromDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>  _
        Public Property ToDate() As Date
            Get
                Return Me.toDateField
            End Get
            Set
                Me.toDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
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
    Partial Public Class ExecutiveViewQueryPurchaseOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Period", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Value", GetType(ExecutiveViewQueryPurchaseOrderValuesValue))>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQueryPurchaseOrderValuesValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scaleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negSalesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Scale() As String
            Get
                Return Me.scaleField
            End Get
            Set
                Me.scaleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property NegSales() As String
            Get
                Return Me.negSalesField
            End Get
            Set
                Me.negSalesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
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
    Partial Public Class ExecutiveViewQuerySalesOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Period", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Value", GetType(ExecutiveViewQuerySalesOrderValuesValue))>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesOrderValuesValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scaleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negSalesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Scale() As String
            Get
                Return Me.scaleField
            End Get
            Set
                Me.scaleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property NegSales() As String
            Get
                Return Me.negSalesField
            End Get
            Set
                Me.negSalesField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
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
    Partial Public Class ExecutiveViewQuerySOAgedValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of String)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Period", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Value", GetType(String)),  _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>  _
        Public Property ItemsCollection() As List(Of String)
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
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType
        
        '''<remarks/>
        Period
        
        '''<remarks/>
        Value
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesByProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateLastUpdateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesByMonthField As List(Of ExecutiveViewQuerySalesByProductClassMonth)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthToDateField As ExecutiveViewQuerySalesByProductClassMonthToDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private previousMonthField As ExecutiveViewQuerySalesByProductClassPreviousMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearToDateField As ExecutiveViewQuerySalesByProductClassYearToDate
        
        Public Sub New()
            MyBase.New
            If (Me.yearToDateField Is Nothing) Then
                Me.yearToDateField = New ExecutiveViewQuerySalesByProductClassYearToDate
            End If
            If (Me.previousMonthField Is Nothing) Then
                Me.previousMonthField = New ExecutiveViewQuerySalesByProductClassPreviousMonth
            End If
            If (Me.monthToDateField Is Nothing) Then
                Me.monthToDateField = New ExecutiveViewQuerySalesByProductClassMonthToDate
            End If
            If (Me.salesByMonthField Is Nothing) Then
                Me.salesByMonthField = New List(Of ExecutiveViewQuerySalesByProductClassMonth)
            End If
        End Sub
        
        Public Property CurrentMonth() As String
            Get
                Return Me.currentMonthField
            End Get
            Set
                Me.currentMonthField = value
            End Set
        End Property
        
        Public Property DateLastUpdate() As String
            Get
                Return Me.dateLastUpdateField
            End Get
            Set
                Me.dateLastUpdateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Month", IsNullable:=false)>  _
        Public Property SalesByMonthCollection() As List(Of ExecutiveViewQuerySalesByProductClassMonth)
            Get
                Return Me.salesByMonthField
            End Get
            Set
                Me.salesByMonthField = value
            End Set
        End Property
        
        Public Property MonthToDate() As ExecutiveViewQuerySalesByProductClassMonthToDate
            Get
                Return Me.monthToDateField
            End Get
            Set
                Me.monthToDateField = value
            End Set
        End Property
        
        Public Property PreviousMonth() As ExecutiveViewQuerySalesByProductClassPreviousMonth
            Get
                Return Me.previousMonthField
            End Get
            Set
                Me.previousMonthField = value
            End Set
        End Property
        
        Public Property YearToDate() As ExecutiveViewQuerySalesByProductClassYearToDate
            Get
                Return Me.yearToDateField
            End Get
            Set
                Me.yearToDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesByProductClassMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetField As String
        
        Public Property Actual() As String
            Get
                Return Me.actualField
            End Get
            Set
                Me.actualField = value
            End Set
        End Property
        
        Public Property Budget() As String
            Get
                Return Me.budgetField
            End Get
            Set
                Me.budgetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesByProductClassMonthToDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        Public Property Sales() As String
            Get
                Return Me.salesField
            End Get
            Set
                Me.salesField = value
            End Set
        End Property
        
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
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
        
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesByProductClassPreviousMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        Public Property Sales() As String
            Get
                Return Me.salesField
            End Get
            Set
                Me.salesField = value
            End Set
        End Property
        
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
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
        
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ExecutiveViewQuerySalesByProductClassYearToDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        Public Property Sales() As String
            Get
                Return Me.salesField
            End Get
            Set
                Me.salesField = value
            End Set
        End Property
        
        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set
                Me.costField = value
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
        
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
    End Class
End Namespace
