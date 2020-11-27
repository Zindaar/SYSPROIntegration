Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.ValidateALedgerCodeEntry.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GLStructureQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As GLStructureQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerDetailsField As GLStructureQueryLedgerDetails
        
        Public Sub New()
            MyBase.New
            If (Me.ledgerDetailsField Is Nothing) Then
                Me.ledgerDetailsField = New GLStructureQueryLedgerDetails
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New GLStructureQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As GLStructureQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property LedgerDetails() As GLStructureQueryLedgerDetails
            Get
                Return Me.ledgerDetailsField
            End Get
            Set
                Me.ledgerDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class GLStructureQuerySystemInformation
        
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
    Partial Public Class GLStructureQueryLedgerDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private expenseTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private controlAccFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private altCurIndicatorField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private integrationMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tax2CodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revalCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glUnitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processTypesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountPasswordField As String
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
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
        
        Public Property ExpenseType() As String
            Get
                Return Me.expenseTypeField
            End Get
            Set
                Me.expenseTypeField = value
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
        
        Public Property AltCurIndicator() As String
            Get
                Return Me.altCurIndicatorField
            End Get
            Set
                Me.altCurIndicatorField = value
            End Set
        End Property
        
        Public Property BudgetMethod() As String
            Get
                Return Me.budgetMethodField
            End Get
            Set
                Me.budgetMethodField = value
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
        
        Public Property IntegrationMethod() As String
            Get
                Return Me.integrationMethodField
            End Get
            Set
                Me.integrationMethodField = value
            End Set
        End Property
        
        Public Property Tax2Code() As String
            Get
                Return Me.tax2CodeField
            End Get
            Set
                Me.tax2CodeField = value
            End Set
        End Property
        
        Public Property RevalCategory() As String
            Get
                Return Me.revalCategoryField
            End Get
            Set
                Me.revalCategoryField = value
            End Set
        End Property
        
        Public Property GlUnitOfMeasure() As String
            Get
                Return Me.glUnitOfMeasureField
            End Get
            Set
                Me.glUnitOfMeasureField = value
            End Set
        End Property
        
        Public Property ProcessTypes() As String
            Get
                Return Me.processTypesField
            End Get
            Set
                Me.processTypesField = value
            End Set
        End Property
        
        Public Property AccountPassword() As String
            Get
                Return Me.accountPasswordField
            End Get
            Set
                Me.accountPasswordField = value
            End Set
        End Property
    End Class
End Namespace
