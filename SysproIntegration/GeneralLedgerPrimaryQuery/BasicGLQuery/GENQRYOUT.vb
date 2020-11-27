Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.BasicGLQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class LedgerQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As LedgerQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gENGRP_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numDetailCurYrField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private controlAccFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accOnHldFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordInUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prevPerEndBalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ptdDrValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ptdCrValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customFormField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balancesAtPeriodEndField As LedgerQueryBalancesAtPeriodEnd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetsField As LedgerQueryBudgets
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionsField As List(Of LedgerQueryItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextPrevKeyField As LedgerQueryNextPrevKey
        
        Public Sub New()
            MyBase.New
            If (Me.nextPrevKeyField Is Nothing) Then
                Me.nextPrevKeyField = New LedgerQueryNextPrevKey
            End If
            If (Me.transactionsField Is Nothing) Then
                Me.transactionsField = New List(Of LedgerQueryItem)
            End If
            If (Me.budgetsField Is Nothing) Then
                Me.budgetsField = New LedgerQueryBudgets
            End If
            If (Me.balancesAtPeriodEndField Is Nothing) Then
                Me.balancesAtPeriodEndField = New LedgerQueryBalancesAtPeriodEnd
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New LedgerQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As LedgerQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
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
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property GlYear() As String
            Get
                Return Me.glYearField
            End Get
            Set
                Me.glYearField = value
            End Set
        End Property
        
        Public Property GlPeriod() As String
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
        
        Public Property AccountType() As String
            Get
                Return Me.accountTypeField
            End Get
            Set
                Me.accountTypeField = value
            End Set
        End Property
        
        Public Property GlGroup() As String
            Get
                Return Me.glGroupField
            End Get
            Set
                Me.glGroupField = value
            End Set
        End Property
        
        Public Property GENGRP_Description() As String
            Get
                Return Me.gENGRP_DescriptionField
            End Get
            Set
                Me.gENGRP_DescriptionField = value
            End Set
        End Property
        
        Public Property NumDetailCurYr() As String
            Get
                Return Me.numDetailCurYrField
            End Get
            Set
                Me.numDetailCurYrField = value
            End Set
        End Property
        
        Public Property ControlAccFlag() As String
            Get
                Return Me.controlAccFlagField
            End Get
            Set
                Me.controlAccFlagField = value
            End Set
        End Property
        
        Public Property AccOnHldFlag() As String
            Get
                Return Me.accOnHldFlagField
            End Get
            Set
                Me.accOnHldFlagField = value
            End Set
        End Property
        
        Public Property PasswordInUse() As String
            Get
                Return Me.passwordInUseField
            End Get
            Set
                Me.passwordInUseField = value
            End Set
        End Property
        
        Public Property PrevPerEndBal() As String
            Get
                Return Me.prevPerEndBalField
            End Get
            Set
                Me.prevPerEndBalField = value
            End Set
        End Property
        
        Public Property PtdDrValue() As String
            Get
                Return Me.ptdDrValueField
            End Get
            Set
                Me.ptdDrValueField = value
            End Set
        End Property
        
        Public Property PtdCrValue() As String
            Get
                Return Me.ptdCrValueField
            End Get
            Set
                Me.ptdCrValueField = value
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
        
        Public Property CustomForm() As String
            Get
                Return Me.customFormField
            End Get
            Set
                Me.customFormField = value
            End Set
        End Property
        
        Public Property BalancesAtPeriodEnd() As LedgerQueryBalancesAtPeriodEnd
            Get
                Return Me.balancesAtPeriodEndField
            End Get
            Set
                Me.balancesAtPeriodEndField = value
            End Set
        End Property
        
        Public Property Budgets() As LedgerQueryBudgets
            Get
                Return Me.budgetsField
            End Get
            Set
                Me.budgetsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable:=false)>  _
        Public Property TransactionsCollection() As List(Of LedgerQueryItem)
            Get
                Return Me.transactionsField
            End Get
            Set
                Me.transactionsField = value
            End Set
        End Property
        
        Public Property NextPrevKey() As LedgerQueryNextPrevKey
            Get
                Return Me.nextPrevKeyField
            End Get
            Set
                Me.nextPrevKeyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQuerySystemInformation
        
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
    Partial Public Class LedgerQueryBalancesAtPeriodEnd
        
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
    Partial Public Class LedgerQueryBudgets
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeField As String
        
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
        
        Public Property BudgetType() As String
            Get
                Return Me.budgetTypeField
            End Get
            Set
                Me.budgetTypeField = value
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
    Partial Public Class LedgerQueryItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jnlDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maintainedFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originZoomKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private originField As String
        
        Public Property GlPeriod() As String
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
        
        Public Property Source() As String
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = value
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
        
        Public Property JnlDate() As String
            Get
                Return Me.jnlDateField
            End Get
            Set
                Me.jnlDateField = value
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
        
        Public Property EntryValue() As String
            Get
                Return Me.entryValueField
            End Get
            Set
                Me.entryValueField = value
            End Set
        End Property
        
        Public Property MaintainedFlag() As String
            Get
                Return Me.maintainedFlagField
            End Get
            Set
                Me.maintainedFlagField = value
            End Set
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property OriginZoomKey() As String
            Get
                Return Me.originZoomKeyField
            End Get
            Set
                Me.originZoomKeyField = value
            End Set
        End Property
        
        Public Property Origin() As String
            Get
                Return Me.originField
            End Get
            Set
                Me.originField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryNextPrevKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private forwardField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private backField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextKeyField As LedgerQueryNextPrevKeyNextKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prevKeyField As LedgerQueryNextPrevKeyPrevKey
        
        Public Sub New()
            MyBase.New
            If (Me.prevKeyField Is Nothing) Then
                Me.prevKeyField = New LedgerQueryNextPrevKeyPrevKey
            End If
            If (Me.nextKeyField Is Nothing) Then
                Me.nextKeyField = New LedgerQueryNextPrevKeyNextKey
            End If
        End Sub
        
        Public Property Forward() As String
            Get
                Return Me.forwardField
            End Get
            Set
                Me.forwardField = value
            End Set
        End Property
        
        Public Property Back() As String
            Get
                Return Me.backField
            End Get
            Set
                Me.backField = value
            End Set
        End Property
        
        Public Property NextKey() As LedgerQueryNextPrevKeyNextKey
            Get
                Return Me.nextKeyField
            End Get
            Set
                Me.nextKeyField = value
            End Set
        End Property
        
        Public Property PrevKey() As LedgerQueryNextPrevKeyPrevKey
            Get
                Return Me.prevKeyField
            End Get
            Set
                Me.prevKeyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryNextPrevKeyNextKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        Public Property Period() As String
            Get
                Return Me.periodField
            End Get
            Set
                Me.periodField = value
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class LedgerQueryNextPrevKeyPrevKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        Public Property Period() As String
            Get
                Return Me.periodField
            End Get
            Set
                Me.periodField = value
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
    End Class
End Namespace
