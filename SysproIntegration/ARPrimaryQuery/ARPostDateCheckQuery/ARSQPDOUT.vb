Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryQuery.ARPostDateCheckQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ARListofPostDatedChecks
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As ARListofPostDatedChecksSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queryOptionsField As ARListofPostDatedChecksQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postDatedbyMonthField As List(Of ARListofPostDatedChecksPostDatedbyMonth)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTotalsField As ARListofPostDatedChecksCompanyTotals
        
        Public Sub New()
            MyBase.New
            If (Me.companyTotalsField Is Nothing) Then
                Me.companyTotalsField = New ARListofPostDatedChecksCompanyTotals
            End If
            If (Me.postDatedbyMonthField Is Nothing) Then
                Me.postDatedbyMonthField = New List(Of ARListofPostDatedChecksPostDatedbyMonth)
            End If
            If (Me.queryOptionsField Is Nothing) Then
                Me.queryOptionsField = New ARListofPostDatedChecksQueryOptions
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New ARListofPostDatedChecksSystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As ARListofPostDatedChecksSystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property QueryOptions() As ARListofPostDatedChecksQueryOptions
            Get
                Return Me.queryOptionsField
            End Get
            Set
                Me.queryOptionsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("PostDatedbyMonth")>  _
        Public Property PostDatedbyMonthCollection() As List(Of ARListofPostDatedChecksPostDatedbyMonth)
            Get
                Return Me.postDatedbyMonthField
            End Get
            Set
                Me.postDatedbyMonthField = value
            End Set
        End Property
        
        Public Property CompanyTotals() As ARListofPostDatedChecksCompanyTotals
            Get
                Return Me.companyTotalsField
            End Get
            Set
                Me.companyTotalsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksSystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As ARListofPostDatedChecksSystemInformationCssStyle
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorEmailAddressField As ARListofPostDatedChecksSystemInformationOperatorEmailAddress
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As ARListofPostDatedChecksSystemInformationOperatorLocation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        Public Sub New()
            MyBase.New
            If (Me.operatorLocationField Is Nothing) Then
                Me.operatorLocationField = New ARListofPostDatedChecksSystemInformationOperatorLocation
            End If
            If (Me.operatorEmailAddressField Is Nothing) Then
                Me.operatorEmailAddressField = New ARListofPostDatedChecksSystemInformationOperatorEmailAddress
            End If
            If (Me.cssStyleField Is Nothing) Then
                Me.cssStyleField = New ARListofPostDatedChecksSystemInformationCssStyle
            End If
        End Sub
        
        Public Property CssStyle() As ARListofPostDatedChecksSystemInformationCssStyle
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property

        <CLSCompliant(False)> _
        Public Property Language() As SByte
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As SByte)
                Me.languageField = value
                Me.languageFieldSpecified = True
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LanguageSpecified() As Boolean
            Get
                Return Me.languageFieldSpecified
            End Get
        End Property
        
        Public Property DecFormat() As Boolean
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
                Me.DecFormatFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DecFormatSpecified() As Boolean
            Get
                Return Me.decFormatFieldSpecified
            End Get
        End Property
        
        <CLSCompliant(False)> _
        Public Property DateFormat() As SByte
            Get
                Return Me.dateFormatField
            End Get
            Set(ByVal value As SByte)
                Me.dateFormatField = value
                Me.dateFormatFieldSpecified = True
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DateFormatSpecified() As Boolean
            Get
                Return Me.dateFormatFieldSpecified
            End Get
        End Property
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property CompanyId() As Boolean
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = value
                Me.CompanyIdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CompanyIdSpecified() As Boolean
            Get
                Return Me.companyIdFieldSpecified
            End Get
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
        
        Public Property OperatorEmailAddress() As ARListofPostDatedChecksSystemInformationOperatorEmailAddress
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As ARListofPostDatedChecksSystemInformationOperatorLocation
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
    Partial Public Class ARListofPostDatedChecksSystemInformationCssStyle
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksSystemInformationOperatorEmailAddress
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksSystemInformationOperatorLocation
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportSequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerFilterValueField As ARListofPostDatedChecksQueryOptionsCustomerFilterValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchFilterValueField As ARListofPostDatedChecksQueryOptionsBranchFilterValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonFilterValueField As ARListofPostDatedChecksQueryOptionsSalespersonFilterValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaFilterValueField As ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postDatedChequeDateFilterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postDatedChequeDateFilterValueField As ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue
        
        Public Sub New()
            MyBase.New
            If (Me.postDatedChequeDateFilterValueField Is Nothing) Then
                Me.postDatedChequeDateFilterValueField = New ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue
            End If
            If (Me.geographicAreaFilterValueField Is Nothing) Then
                Me.geographicAreaFilterValueField = New ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue
            End If
            If (Me.salespersonFilterValueField Is Nothing) Then
                Me.salespersonFilterValueField = New ARListofPostDatedChecksQueryOptionsSalespersonFilterValue
            End If
            If (Me.branchFilterValueField Is Nothing) Then
                Me.branchFilterValueField = New ARListofPostDatedChecksQueryOptionsBranchFilterValue
            End If
            If (Me.customerFilterValueField Is Nothing) Then
                Me.customerFilterValueField = New ARListofPostDatedChecksQueryOptionsCustomerFilterValue
            End If
        End Sub
        
        Public Property ReportSequence() As String
            Get
                Return Me.reportSequenceField
            End Get
            Set
                Me.reportSequenceField = value
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
        
        Public Property CustomerFilterType() As String
            Get
                Return Me.customerFilterTypeField
            End Get
            Set
                Me.customerFilterTypeField = value
            End Set
        End Property
        
        Public Property CustomerFilterValue() As ARListofPostDatedChecksQueryOptionsCustomerFilterValue
            Get
                Return Me.customerFilterValueField
            End Get
            Set
                Me.customerFilterValueField = value
            End Set
        End Property
        
        Public Property BranchFilterType() As String
            Get
                Return Me.branchFilterTypeField
            End Get
            Set
                Me.branchFilterTypeField = value
            End Set
        End Property
        
        Public Property BranchFilterValue() As ARListofPostDatedChecksQueryOptionsBranchFilterValue
            Get
                Return Me.branchFilterValueField
            End Get
            Set
                Me.branchFilterValueField = value
            End Set
        End Property
        
        Public Property SalespersonFilterType() As String
            Get
                Return Me.salespersonFilterTypeField
            End Get
            Set
                Me.salespersonFilterTypeField = value
            End Set
        End Property
        
        Public Property SalespersonFilterValue() As ARListofPostDatedChecksQueryOptionsSalespersonFilterValue
            Get
                Return Me.salespersonFilterValueField
            End Get
            Set
                Me.salespersonFilterValueField = value
            End Set
        End Property
        
        Public Property GeographicAreaFilterType() As String
            Get
                Return Me.geographicAreaFilterTypeField
            End Get
            Set
                Me.geographicAreaFilterTypeField = value
            End Set
        End Property
        
        Public Property GeographicAreaFilterValue() As ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue
            Get
                Return Me.geographicAreaFilterValueField
            End Get
            Set
                Me.geographicAreaFilterValueField = value
            End Set
        End Property
        
        Public Property PostDatedChequeDateFilterType() As String
            Get
                Return Me.postDatedChequeDateFilterTypeField
            End Get
            Set
                Me.postDatedChequeDateFilterTypeField = value
            End Set
        End Property
        
        Public Property PostDatedChequeDateFilterValue() As ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue
            Get
                Return Me.postDatedChequeDateFilterValueField
            End Get
            Set
                Me.postDatedChequeDateFilterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptionsCustomerFilterValue
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptionsBranchFilterValue
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptionsSalespersonFilterValue
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksPostDatedbyMonth
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthCheckDatedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postDatedCheckField As List(Of ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck)
        
        Public Sub New()
            MyBase.New
            If (Me.postDatedCheckField Is Nothing) Then
                Me.postDatedCheckField = New List(Of ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck)
            End If
        End Sub
        
        Public Property MonthCheckDated() As String
            Get
                Return Me.monthCheckDatedField
            End Get
            Set
                Me.monthCheckDatedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("PostDatedCheck")>  _
        Public Property PostDatedCheckCollection() As List(Of ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck)
            Get
                Return Me.postDatedCheckField
            End Get
            Set
                Me.postDatedCheckField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private aRSMST_NameField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chequeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availableDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALBRN_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tBLARC_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALARE_DescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sALSLS_NameField As String
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property ARSMST_Name() As Object
            Get
                Return Me.aRSMST_NameField
            End Get
            Set
                Me.aRSMST_NameField = value
            End Set
        End Property
        
        Public Property Cheque() As Short
            Get
                Return Me.chequeField
            End Get
            Set
                Me.chequeField = value
                Me.ChequeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ChequeSpecified() As Boolean
            Get
                Return Me.chequeFieldSpecified
            End Get
        End Property
        
        Public Property AvailableDate() As String
            Get
                Return Me.availableDateField
            End Get
            Set
                Me.availableDateField = value
            End Set
        End Property
        
        Public Property Amount() As Decimal
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
                Me.AmountFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AmountSpecified() As Boolean
            Get
                Return Me.amountFieldSpecified
            End Get
        End Property
        
        <CLSCompliant(False)> _
        Public Property Branch() As SByte
            Get
                Return Me.branchField
            End Get
            Set(ByVal value As SByte)
                Me.branchField = value
                Me.branchFieldSpecified = True
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BranchSpecified() As Boolean
            Get
                Return Me.branchFieldSpecified
            End Get
        End Property
        
        Public Property SALBRN_Description() As String
            Get
                Return Me.sALBRN_DescriptionField
            End Get
            Set
                Me.sALBRN_DescriptionField = value
            End Set
        End Property
        
        Public Property [Class]() As String
            Get
                Return Me.classField
            End Get
            Set
                Me.classField = value
            End Set
        End Property
        
        Public Property TBLARC_Description() As String
            Get
                Return Me.tBLARC_DescriptionField
            End Get
            Set
                Me.tBLARC_DescriptionField = value
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
        
        Public Property Salesperson() As Object
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        Public Property SALSLS_Name() As String
            Get
                Return Me.sALSLS_NameField
            End Get
            Set
                Me.sALSLS_NameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksCompanyTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalsbyMonthDueField As List(Of ARListofPostDatedChecksCompanyTotalsMonthDueTotals)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportCurrencyDescField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalPostDatedChField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalPostDatedChFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            If (Me.totalsbyMonthDueField Is Nothing) Then
                Me.totalsbyMonthDueField = New List(Of ARListofPostDatedChecksCompanyTotalsMonthDueTotals)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlArrayItemAttribute("MonthDueTotals", IsNullable:=false)>  _
        Public Property TotalsbyMonthDueCollection() As List(Of ARListofPostDatedChecksCompanyTotalsMonthDueTotals)
            Get
                Return Me.totalsbyMonthDueField
            End Get
            Set
                Me.totalsbyMonthDueField = value
            End Set
        End Property
        
        Public Property ReportCurrency() As String
            Get
                Return Me.reportCurrencyField
            End Get
            Set
                Me.reportCurrencyField = value
            End Set
        End Property
        
        Public Property ReportCurrencyDesc() As Object
            Get
                Return Me.reportCurrencyDescField
            End Get
            Set
                Me.reportCurrencyDescField = value
            End Set
        End Property
        
        <CLSCompliant(False)> _
        Public Property TotalPostDatedCh() As SByte
            Get
                Return Me.totalPostDatedChField
            End Get
            Set(ByVal value As SByte)
                Me.totalPostDatedChField = Value
                Me.totalPostDatedChFieldSpecified = True
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TotalPostDatedChSpecified() As Boolean
            Get
                Return Me.totalPostDatedChFieldSpecified
            End Get
        End Property
        
        Public Property Total() As Decimal
            Get
                Return Me.totalField
            End Get
            Set
                Me.totalField = value
                Me.TotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TotalSpecified() As Boolean
            Get
                Return Me.totalFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ARListofPostDatedChecksCompanyTotalsMonthDueTotals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthDueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthTotalField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthTotalFieldSpecified As Boolean
        
        Public Property MonthDue() As String
            Get
                Return Me.monthDueField
            End Get
            Set
                Me.monthDueField = value
            End Set
        End Property
        
        Public Property MonthTotal() As Decimal
            Get
                Return Me.monthTotalField
            End Get
            Set
                Me.monthTotalField = value
                Me.MonthTotalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MonthTotalSpecified() As Boolean
            Get
                Return Me.monthTotalFieldSpecified
            End Get
        End Property
    End Class
End Namespace
