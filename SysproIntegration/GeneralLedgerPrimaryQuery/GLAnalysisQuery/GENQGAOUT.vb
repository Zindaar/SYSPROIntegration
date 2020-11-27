Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GLAnalysisQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GLAnalysisQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As GLAnalysisQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionField As GLAnalysisQuerySection
        
        Public Sub New()
            MyBase.New
            If (Me.sectionField Is Nothing) Then
                Me.sectionField = New GLAnalysisQuerySection
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New GLAnalysisQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As GLAnalysisQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property Section() As GLAnalysisQuerySection
            Get
                Return Me.sectionField
            End Get
            Set
                Me.sectionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySystemInformation
        
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
    Partial Public Class GLAnalysisQuerySection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionNumberDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentSectionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentSectionDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentLedgerYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentLedgerPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerPeriodsInYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balancesAtPeriodEndField As GLAnalysisQuerySectionBalancesAtPeriodEnd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetsField As GLAnalysisQuerySectionBudgets
        
        Public Sub New()
            MyBase.New
            If (Me.budgetsField Is Nothing) Then
                Me.budgetsField = New GLAnalysisQuerySectionBudgets
            End If
            If (Me.balancesAtPeriodEndField Is Nothing) Then
                Me.balancesAtPeriodEndField = New GLAnalysisQuerySectionBalancesAtPeriodEnd
            End If
        End Sub
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property Company() As String
            Get
                Return Me.companyField
            End Get
            Set
                Me.companyField = value
            End Set
        End Property
        
        Public Property SectionNumber() As String
            Get
                Return Me.sectionNumberField
            End Get
            Set
                Me.sectionNumberField = value
            End Set
        End Property
        
        Public Property SectionNumberDescription() As String
            Get
                Return Me.sectionNumberDescriptionField
            End Get
            Set
                Me.sectionNumberDescriptionField = value
            End Set
        End Property
        
        Public Property SectionCode() As String
            Get
                Return Me.sectionCodeField
            End Get
            Set
                Me.sectionCodeField = value
            End Set
        End Property
        
        Public Property ParentSectionCode() As String
            Get
                Return Me.parentSectionCodeField
            End Get
            Set
                Me.parentSectionCodeField = value
            End Set
        End Property
        
        Public Property ParentSectionDescription() As String
            Get
                Return Me.parentSectionDescriptionField
            End Get
            Set
                Me.parentSectionDescriptionField = value
            End Set
        End Property
        
        Public Property CurrentLedgerYear() As String
            Get
                Return Me.currentLedgerYearField
            End Get
            Set
                Me.currentLedgerYearField = value
            End Set
        End Property
        
        Public Property CurrentLedgerPeriod() As String
            Get
                Return Me.currentLedgerPeriodField
            End Get
            Set
                Me.currentLedgerPeriodField = value
            End Set
        End Property
        
        Public Property LedgerPeriodsInYear() As String
            Get
                Return Me.ledgerPeriodsInYearField
            End Get
            Set
                Me.ledgerPeriodsInYearField = value
            End Set
        End Property
        
        Public Property BalancesAtPeriodEnd() As GLAnalysisQuerySectionBalancesAtPeriodEnd
            Get
                Return Me.balancesAtPeriodEndField
            End Get
            Set
                Me.balancesAtPeriodEndField = value
            End Set
        End Property
        
        Public Property Budgets() As GLAnalysisQuerySectionBudgets
            Get
                Return Me.budgetsField
            End Get
            Set
                Me.budgetsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEnd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetField As GLAnalysisQuerySectionBalancesAtPeriodEndAsset
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capitalField As GLAnalysisQuerySectionBalancesAtPeriodEndCapital
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private liabilityField As GLAnalysisQuerySectionBalancesAtPeriodEndLiability
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revenueField As GLAnalysisQuerySectionBalancesAtPeriodEndRevenue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expenseField As GLAnalysisQuerySectionBalancesAtPeriodEndExpense
        
        Public Sub New()
            MyBase.New
            If (Me.expenseField Is Nothing) Then
                Me.expenseField = New GLAnalysisQuerySectionBalancesAtPeriodEndExpense
            End If
            If (Me.revenueField Is Nothing) Then
                Me.revenueField = New GLAnalysisQuerySectionBalancesAtPeriodEndRevenue
            End If
            If (Me.liabilityField Is Nothing) Then
                Me.liabilityField = New GLAnalysisQuerySectionBalancesAtPeriodEndLiability
            End If
            If (Me.capitalField Is Nothing) Then
                Me.capitalField = New GLAnalysisQuerySectionBalancesAtPeriodEndCapital
            End If
            If (Me.assetField Is Nothing) Then
                Me.assetField = New GLAnalysisQuerySectionBalancesAtPeriodEndAsset
            End If
        End Sub
        
        Public Property GlYear() As String
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
        
        Public Property Asset() As GLAnalysisQuerySectionBalancesAtPeriodEndAsset
            Get
                Return Me.assetField
            End Get
            Set
                Me.assetField = value
            End Set
        End Property
        
        Public Property Capital() As GLAnalysisQuerySectionBalancesAtPeriodEndCapital
            Get
                Return Me.capitalField
            End Get
            Set
                Me.capitalField = value
            End Set
        End Property
        
        Public Property Liability() As GLAnalysisQuerySectionBalancesAtPeriodEndLiability
            Get
                Return Me.liabilityField
            End Get
            Set
                Me.liabilityField = value
            End Set
        End Property
        
        Public Property Revenue() As GLAnalysisQuerySectionBalancesAtPeriodEndRevenue
            Get
                Return Me.revenueField
            End Get
            Set
                Me.revenueField = value
            End Set
        End Property
        
        Public Property Expense() As GLAnalysisQuerySectionBalancesAtPeriodEndExpense
            Get
                Return Me.expenseField
            End Get
            Set
                Me.expenseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEndAsset
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private beginYearBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property BeginYearBalance() As String
            Get
                Return Me.beginYearBalanceField
            End Get
            Set
                Me.beginYearBalanceField = value
            End Set
        End Property
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEndCapital
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private beginYearBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property BeginYearBalance() As String
            Get
                Return Me.beginYearBalanceField
            End Get
            Set
                Me.beginYearBalanceField = value
            End Set
        End Property
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEndLiability
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private beginYearBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property BeginYearBalance() As String
            Get
                Return Me.beginYearBalanceField
            End Get
            Set
                Me.beginYearBalanceField = value
            End Set
        End Property
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEndRevenue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private beginYearBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property BeginYearBalance() As String
            Get
                Return Me.beginYearBalanceField
            End Get
            Set
                Me.beginYearBalanceField = value
            End Set
        End Property
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBalancesAtPeriodEndExpense
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private beginYearBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property BeginYearBalance() As String
            Get
                Return Me.beginYearBalanceField
            End Get
            Set
                Me.beginYearBalanceField = value
            End Set
        End Property
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgets
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetField As GLAnalysisQuerySectionBudgetsAsset
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capitalField As GLAnalysisQuerySectionBudgetsCapital
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private liabilityField As GLAnalysisQuerySectionBudgetsLiability
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revenueField As GLAnalysisQuerySectionBudgetsRevenue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expenseField As GLAnalysisQuerySectionBudgetsExpense
        
        Public Sub New()
            MyBase.New
            If (Me.expenseField Is Nothing) Then
                Me.expenseField = New GLAnalysisQuerySectionBudgetsExpense
            End If
            If (Me.revenueField Is Nothing) Then
                Me.revenueField = New GLAnalysisQuerySectionBudgetsRevenue
            End If
            If (Me.liabilityField Is Nothing) Then
                Me.liabilityField = New GLAnalysisQuerySectionBudgetsLiability
            End If
            If (Me.capitalField Is Nothing) Then
                Me.capitalField = New GLAnalysisQuerySectionBudgetsCapital
            End If
            If (Me.assetField Is Nothing) Then
                Me.assetField = New GLAnalysisQuerySectionBudgetsAsset
            End If
        End Sub
        
        Public Property BudgetType() As String
            Get
                Return Me.budgetTypeField
            End Get
            Set
                Me.budgetTypeField = value
            End Set
        End Property
        
        Public Property Asset() As GLAnalysisQuerySectionBudgetsAsset
            Get
                Return Me.assetField
            End Get
            Set
                Me.assetField = value
            End Set
        End Property
        
        Public Property Capital() As GLAnalysisQuerySectionBudgetsCapital
            Get
                Return Me.capitalField
            End Get
            Set
                Me.capitalField = value
            End Set
        End Property
        
        Public Property Liability() As GLAnalysisQuerySectionBudgetsLiability
            Get
                Return Me.liabilityField
            End Get
            Set
                Me.liabilityField = value
            End Set
        End Property
        
        Public Property Revenue() As GLAnalysisQuerySectionBudgetsRevenue
            Get
                Return Me.revenueField
            End Get
            Set
                Me.revenueField = value
            End Set
        End Property
        
        Public Property Expense() As GLAnalysisQuerySectionBudgetsExpense
            Get
                Return Me.expenseField
            End Get
            Set
                Me.expenseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgetsAsset
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgetsCapital
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgetsLiability
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgetsRevenue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLAnalysisQuerySectionBudgetsExpense
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period14Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private period15Field As String
        
        Public Property Period1() As String
            Get
                Return Me.period1Field
            End Get
            Set
                Me.period1Field = value
            End Set
        End Property
        
        Public Property Period2() As String
            Get
                Return Me.period2Field
            End Get
            Set
                Me.period2Field = value
            End Set
        End Property
        
        Public Property Period3() As String
            Get
                Return Me.period3Field
            End Get
            Set
                Me.period3Field = value
            End Set
        End Property
        
        Public Property Period4() As String
            Get
                Return Me.period4Field
            End Get
            Set
                Me.period4Field = value
            End Set
        End Property
        
        Public Property Period5() As String
            Get
                Return Me.period5Field
            End Get
            Set
                Me.period5Field = value
            End Set
        End Property
        
        Public Property Period6() As String
            Get
                Return Me.period6Field
            End Get
            Set
                Me.period6Field = value
            End Set
        End Property
        
        Public Property Period7() As String
            Get
                Return Me.period7Field
            End Get
            Set
                Me.period7Field = value
            End Set
        End Property
        
        Public Property Period8() As String
            Get
                Return Me.period8Field
            End Get
            Set
                Me.period8Field = value
            End Set
        End Property
        
        Public Property Period9() As String
            Get
                Return Me.period9Field
            End Get
            Set
                Me.period9Field = value
            End Set
        End Property
        
        Public Property Period10() As String
            Get
                Return Me.period10Field
            End Get
            Set
                Me.period10Field = value
            End Set
        End Property
        
        Public Property Period11() As String
            Get
                Return Me.period11Field
            End Get
            Set
                Me.period11Field = value
            End Set
        End Property
        
        Public Property Period12() As String
            Get
                Return Me.period12Field
            End Get
            Set
                Me.period12Field = value
            End Set
        End Property
        
        Public Property Period13() As String
            Get
                Return Me.period13Field
            End Get
            Set
                Me.period13Field = value
            End Set
        End Property
        
        Public Property Period14() As String
            Get
                Return Me.period14Field
            End Get
            Set
                Me.period14Field = value
            End Set
        End Property
        
        Public Property Period15() As String
            Get
                Return Me.period15Field
            End Get
            Set
                Me.period15Field = value
            End Set
        End Property
    End Class
End Namespace
