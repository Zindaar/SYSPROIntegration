Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace CashBookPrimaryQuery.CashBookTransactionQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CshTrnQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As CshTrnQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankItemField As CshTrnQueryBankItem
        
        Public Sub New()
            MyBase.New
            If (Me.bankItemField Is Nothing) Then
                Me.bankItemField = New CshTrnQueryBankItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New CshTrnQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As CshTrnQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property BankItem() As CshTrnQueryBankItem
            Get
                Return Me.bankItemField
            End Get
            Set
                Me.bankItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CshTrnQuerySystemInformation
        
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
    Partial Public Class CshTrnQueryBankItem
        
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
        Private cbstmtBalLoc3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstDep1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstDep2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstDep3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstWith1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstWith2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstWith3Field As String
        
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
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankAccountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbOpenBal1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbOpenBal2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbOpenBal3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cshTrnItemField As List(Of CshTrnQueryBankItemCshTrnItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankNetValuesField As List(Of CshTrnQueryBankItemDate)
        
        Public Sub New()
            MyBase.New
            If (Me.bankNetValuesField Is Nothing) Then
                Me.bankNetValuesField = New List(Of CshTrnQueryBankItemDate)
            End If
            If (Me.cshTrnItemField Is Nothing) Then
                Me.cshTrnItemField = New List(Of CshTrnQueryBankItemCshTrnItem)
            End If
        End Sub
        
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
        
        Public Property CbstmtBalLoc3() As String
            Get
                Return Me.cbstmtBalLoc3Field
            End Get
            Set
                Me.cbstmtBalLoc3Field = value
            End Set
        End Property
        
        Public Property OutstDep1() As String
            Get
                Return Me.outstDep1Field
            End Get
            Set
                Me.outstDep1Field = value
            End Set
        End Property
        
        Public Property OutstDep2() As String
            Get
                Return Me.outstDep2Field
            End Get
            Set
                Me.outstDep2Field = value
            End Set
        End Property
        
        Public Property OutstDep3() As String
            Get
                Return Me.outstDep3Field
            End Get
            Set
                Me.outstDep3Field = value
            End Set
        End Property
        
        Public Property OutstWith1() As String
            Get
                Return Me.outstWith1Field
            End Get
            Set
                Me.outstWith1Field = value
            End Set
        End Property
        
        Public Property OutstWith2() As String
            Get
                Return Me.outstWith2Field
            End Get
            Set
                Me.outstWith2Field = value
            End Set
        End Property
        
        Public Property OutstWith3() As String
            Get
                Return Me.outstWith3Field
            End Get
            Set
                Me.outstWith3Field = value
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
        
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
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
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property CbOpenBal1() As String
            Get
                Return Me.cbOpenBal1Field
            End Get
            Set
                Me.cbOpenBal1Field = value
            End Set
        End Property
        
        Public Property CbOpenBal2() As String
            Get
                Return Me.cbOpenBal2Field
            End Get
            Set
                Me.cbOpenBal2Field = value
            End Set
        End Property
        
        Public Property CbOpenBal3() As String
            Get
                Return Me.cbOpenBal3Field
            End Get
            Set
                Me.cbOpenBal3Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CshTrnItem")>  _
        Public Property CshTrnItemCollection() As List(Of CshTrnQueryBankItemCshTrnItem)
            Get
                Return Me.cshTrnItemField
            End Get
            Set
                Me.cshTrnItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Date", IsNullable:=false)>  _
        Public Property BankNetValuesCollection() As List(Of CshTrnQueryBankItemDate)
            Get
                Return Me.bankNetValuesField
            End Get
            Set
                Me.bankNetValuesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CshTrnQueryBankItemCshTrnItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbTrnYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbTrnMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbTrnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cbTrnTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconciledFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconciledYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconciledMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private voidFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnSourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lCurrencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lPostCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lAccountCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lAccConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lAccMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lTriangCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lTriangRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lTriangMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private apTrnItemField As CshTrnQueryBankItemCshTrnItemApTrnItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arTrnItemField As CshTrnQueryBankItemCshTrnItemArTrnItem
        
        Public Sub New()
            MyBase.New
            If (Me.arTrnItemField Is Nothing) Then
                Me.arTrnItemField = New CshTrnQueryBankItemCshTrnItemArTrnItem
            End If
            If (Me.apTrnItemField Is Nothing) Then
                Me.apTrnItemField = New CshTrnQueryBankItemCshTrnItemApTrnItem
            End If
        End Sub
        
        Public Property CbTrnYear() As String
            Get
                Return Me.cbTrnYearField
            End Get
            Set
                Me.cbTrnYearField = value
            End Set
        End Property
        
        Public Property CbTrnMonth() As String
            Get
                Return Me.cbTrnMonthField
            End Get
            Set
                Me.cbTrnMonthField = value
            End Set
        End Property
        
        Public Property CbTrnDate() As String
            Get
                Return Me.cbTrnDateField
            End Get
            Set
                Me.cbTrnDateField = value
            End Set
        End Property
        
        Public Property CbTrnTime() As String
            Get
                Return Me.cbTrnTimeField
            End Get
            Set
                Me.cbTrnTimeField = value
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
        
        Public Property TrnReference() As String
            Get
                Return Me.trnReferenceField
            End Get
            Set
                Me.trnReferenceField = value
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
        
        Public Property TrnDate() As String
            Get
                Return Me.trnDateField
            End Get
            Set
                Me.trnDateField = value
            End Set
        End Property
        
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
            End Set
        End Property
        
        Public Property ReconciledFlag() As String
            Get
                Return Me.reconciledFlagField
            End Get
            Set
                Me.reconciledFlagField = value
            End Set
        End Property
        
        Public Property ReconciledYear() As String
            Get
                Return Me.reconciledYearField
            End Get
            Set
                Me.reconciledYearField = value
            End Set
        End Property
        
        Public Property ReconciledMonth() As String
            Get
                Return Me.reconciledMonthField
            End Get
            Set
                Me.reconciledMonthField = value
            End Set
        End Property
        
        Public Property Cheque() As String
            Get
                Return Me.chequeField
            End Get
            Set
                Me.chequeField = value
            End Set
        End Property
        
        Public Property ChequeType() As String
            Get
                Return Me.chequeTypeField
            End Get
            Set
                Me.chequeTypeField = value
            End Set
        End Property
        
        Public Property VoidFlag() As String
            Get
                Return Me.voidFlagField
            End Get
            Set
                Me.voidFlagField = value
            End Set
        End Property
        
        Public Property BankCurrency() As String
            Get
                Return Me.bankCurrencyField
            End Get
            Set
                Me.bankCurrencyField = value
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
        
        Public Property PostCurrency() As String
            Get
                Return Me.postCurrencyField
            End Get
            Set
                Me.postCurrencyField = value
            End Set
        End Property
        
        Public Property TrnSource() As String
            Get
                Return Me.trnSourceField
            End Get
            Set
                Me.trnSourceField = value
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
        
        Public Property AccountCur() As String
            Get
                Return Me.accountCurField
            End Get
            Set
                Me.accountCurField = value
            End Set
        End Property
        
        Public Property AccConvRate() As String
            Get
                Return Me.accConvRateField
            End Get
            Set
                Me.accConvRateField = value
            End Set
        End Property
        
        Public Property AccMulDiv() As String
            Get
                Return Me.accMulDivField
            End Get
            Set
                Me.accMulDivField = value
            End Set
        End Property
        
        Public Property TriangCurrency() As String
            Get
                Return Me.triangCurrencyField
            End Get
            Set
                Me.triangCurrencyField = value
            End Set
        End Property
        
        Public Property TriangRate() As String
            Get
                Return Me.triangRateField
            End Get
            Set
                Me.triangRateField = value
            End Set
        End Property
        
        Public Property TriangMulDiv() As String
            Get
                Return Me.triangMulDivField
            End Get
            Set
                Me.triangMulDivField = value
            End Set
        End Property
        
        Public Property LCurrencyValue() As String
            Get
                Return Me.lCurrencyValueField
            End Get
            Set
                Me.lCurrencyValueField = value
            End Set
        End Property
        
        Public Property LPostCurrency() As String
            Get
                Return Me.lPostCurrencyField
            End Get
            Set
                Me.lPostCurrencyField = value
            End Set
        End Property
        
        Public Property LConvRate() As String
            Get
                Return Me.lConvRateField
            End Get
            Set
                Me.lConvRateField = value
            End Set
        End Property
        
        Public Property LMulDiv() As String
            Get
                Return Me.lMulDivField
            End Get
            Set
                Me.lMulDivField = value
            End Set
        End Property
        
        Public Property LAccountCur() As String
            Get
                Return Me.lAccountCurField
            End Get
            Set
                Me.lAccountCurField = value
            End Set
        End Property
        
        Public Property LAccConvRate() As String
            Get
                Return Me.lAccConvRateField
            End Get
            Set
                Me.lAccConvRateField = value
            End Set
        End Property
        
        Public Property LAccMulDiv() As String
            Get
                Return Me.lAccMulDivField
            End Get
            Set
                Me.lAccMulDivField = value
            End Set
        End Property
        
        Public Property LTriangCurrency() As String
            Get
                Return Me.lTriangCurrencyField
            End Get
            Set
                Me.lTriangCurrencyField = value
            End Set
        End Property
        
        Public Property LTriangRate() As String
            Get
                Return Me.lTriangRateField
            End Get
            Set
                Me.lTriangRateField = value
            End Set
        End Property
        
        Public Property LTriangMulDiv() As String
            Get
                Return Me.lTriangMulDivField
            End Get
            Set
                Me.lTriangMulDivField = value
            End Set
        End Property
        
        Public Property ApTrnItem() As CshTrnQueryBankItemCshTrnItemApTrnItem
            Get
                Return Me.apTrnItemField
            End Get
            Set
                Me.apTrnItemField = value
            End Set
        End Property
        
        Public Property ArTrnItem() As CshTrnQueryBankItemCshTrnItemArTrnItem
            Get
                Return Me.arTrnItemField
            End Get
            Set
                Me.arTrnItemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CshTrnQueryBankItemCshTrnItemApTrnItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeRegisterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private negChequeFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rateEntryTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withTaxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossLocValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangMulDivField As String
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property Cheque() As String
            Get
                Return Me.chequeField
            End Get
            Set
                Me.chequeField = value
            End Set
        End Property
        
        Public Property ChequeType() As String
            Get
                Return Me.chequeTypeField
            End Get
            Set
                Me.chequeTypeField = value
            End Set
        End Property
        
        Public Property ChequeRegister() As String
            Get
                Return Me.chequeRegisterField
            End Get
            Set
                Me.chequeRegisterField = value
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
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property InvoiceType() As String
            Get
                Return Me.invoiceTypeField
            End Get
            Set
                Me.invoiceTypeField = value
            End Set
        End Property
        
        Public Property ChequeDate() As String
            Get
                Return Me.chequeDateField
            End Get
            Set
                Me.chequeDateField = value
            End Set
        End Property
        
        Public Property NegChequeFlag() As String
            Get
                Return Me.negChequeFlagField
            End Get
            Set
                Me.negChequeFlagField = value
            End Set
        End Property
        
        Public Property GrossValue() As String
            Get
                Return Me.grossValueField
            End Get
            Set
                Me.grossValueField = value
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
        
        Public Property NetValue() As String
            Get
                Return Me.netValueField
            End Get
            Set
                Me.netValueField = value
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
        
        Public Property RateEntryTime() As String
            Get
                Return Me.rateEntryTimeField
            End Get
            Set
                Me.rateEntryTimeField = value
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
        
        Public Property WithTaxValue() As String
            Get
                Return Me.withTaxValueField
            End Get
            Set
                Me.withTaxValueField = value
            End Set
        End Property
        
        Public Property GrossLocValue() As String
            Get
                Return Me.grossLocValueField
            End Get
            Set
                Me.grossLocValueField = value
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
        
        Public Property AccountCur() As String
            Get
                Return Me.accountCurField
            End Get
            Set
                Me.accountCurField = value
            End Set
        End Property
        
        Public Property AccountConvRate() As String
            Get
                Return Me.accountConvRateField
            End Get
            Set
                Me.accountConvRateField = value
            End Set
        End Property
        
        Public Property AccountMulDiv() As String
            Get
                Return Me.accountMulDivField
            End Get
            Set
                Me.accountMulDivField = value
            End Set
        End Property
        
        Public Property TriangCurrency() As String
            Get
                Return Me.triangCurrencyField
            End Get
            Set
                Me.triangCurrencyField = value
            End Set
        End Property
        
        Public Property TriangConvRate() As String
            Get
                Return Me.triangConvRateField
            End Get
            Set
                Me.triangConvRateField = value
            End Set
        End Property
        
        Public Property TriangMulDiv() As String
            Get
                Return Me.triangMulDivField
            End Get
            Set
                Me.triangMulDivField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CshTrnQueryBankItemCshTrnItemArTrnItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossPaymentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossPaymentForField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountAllowedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountAllowedForField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netPaymentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private netPaymentForField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payTaxAmtDiscField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountCurField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountMulDivField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangConvRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triangMulDivField As String
        
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
        
        Public Property DocumentType() As String
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
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
        
        Public Property GrossPayment() As String
            Get
                Return Me.grossPaymentField
            End Get
            Set
                Me.grossPaymentField = value
            End Set
        End Property
        
        Public Property GrossPaymentFor() As String
            Get
                Return Me.grossPaymentForField
            End Get
            Set
                Me.grossPaymentForField = value
            End Set
        End Property
        
        Public Property DiscountAllowed() As String
            Get
                Return Me.discountAllowedField
            End Get
            Set
                Me.discountAllowedField = value
            End Set
        End Property
        
        Public Property DiscountAllowedFor() As String
            Get
                Return Me.discountAllowedForField
            End Get
            Set
                Me.discountAllowedForField = value
            End Set
        End Property
        
        Public Property NetPayment() As String
            Get
                Return Me.netPaymentField
            End Get
            Set
                Me.netPaymentField = value
            End Set
        End Property
        
        Public Property NetPaymentFor() As String
            Get
                Return Me.netPaymentForField
            End Get
            Set
                Me.netPaymentForField = value
            End Set
        End Property
        
        Public Property PayTaxAmtDisc() As String
            Get
                Return Me.payTaxAmtDiscField
            End Get
            Set
                Me.payTaxAmtDiscField = value
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
        
        Public Property CurrencyValue() As String
            Get
                Return Me.currencyValueField
            End Get
            Set
                Me.currencyValueField = value
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
        
        Public Property AccountCur() As String
            Get
                Return Me.accountCurField
            End Get
            Set
                Me.accountCurField = value
            End Set
        End Property
        
        Public Property AccountConvRate() As String
            Get
                Return Me.accountConvRateField
            End Get
            Set
                Me.accountConvRateField = value
            End Set
        End Property
        
        Public Property AccountMulDiv() As String
            Get
                Return Me.accountMulDivField
            End Get
            Set
                Me.accountMulDivField = value
            End Set
        End Property
        
        Public Property TriangCurrency() As String
            Get
                Return Me.triangCurrencyField
            End Get
            Set
                Me.triangCurrencyField = value
            End Set
        End Property
        
        Public Property TriangConvRate() As String
            Get
                Return Me.triangConvRateField
            End Get
            Set
                Me.triangConvRateField = value
            End Set
        End Property
        
        Public Property TriangMulDiv() As String
            Get
                Return Me.triangMulDivField
            End Get
            Set
                Me.triangMulDivField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CshTrnQueryBankItemDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tranDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withValueField As String
        
        Public Property TranDate() As String
            Get
                Return Me.tranDateField
            End Get
            Set
                Me.tranDateField = value
            End Set
        End Property
        
        Public Property DepositValue() As String
            Get
                Return Me.depositValueField
            End Get
            Set
                Me.depositValueField = value
            End Set
        End Property
        
        Public Property WithValue() As String
            Get
                Return Me.withValueField
            End Get
            Set
                Me.withValueField = value
            End Set
        End Property
    End Class
End Namespace
