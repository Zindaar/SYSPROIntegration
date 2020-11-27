Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryQuery.CreditManagementQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AgeingMethod
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        I
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BalanceTypeSelection
        
        '''<remarks/>
        A
        
        '''<remarks/>
        D
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BranchSelectionBy
        
        '''<remarks/>
        C
        
        '''<remarks/>
        I
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Branch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As BranchFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = BranchFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(BranchFilterType.A)>  _
        Public Property FilterType() As BranchFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BranchFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ConvertToLocalCurrency
        
        '''<remarks/>
        E
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CreditNarrations
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Currency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CurrencyFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CurrencyFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CurrencyFilterType.A)>  _
        Public Property FilterType() As CurrencyFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum CurrencyFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CurrencyValues
        
        '''<remarks/>
        L
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CustomerFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CustomerFilterType.A)>  _
        Public Property FilterType() As CustomerFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum CustomerFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CustomerClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CustomerClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CustomerClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CustomerClassFilterType.A)>  _
        Public Property FilterType() As CustomerClassFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum CustomerClassFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CustomerDetail
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CustomerLimitandTermsBy
        
        '''<remarks/>
        A
        
        '''<remarks/>
        L
        
        '''<remarks/>
        T
        
        '''<remarks/>
        C
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CustomersOnHold
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shortNameField As ShortName
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As Branch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private termsField As Terms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As Currency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaField As GeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerClassField As CustomerClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesPersonField As SalesPerson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private followupDateField As FollowupDate
        
        Public Sub New()
            MyBase.New
            If (Me.followupDateField Is Nothing) Then
                Me.followupDateField = New FollowupDate
            End If
            If (Me.salesPersonField Is Nothing) Then
                Me.salesPersonField = New SalesPerson
            End If
            If (Me.customerClassField Is Nothing) Then
                Me.customerClassField = New CustomerClass
            End If
            If (Me.geographicAreaField Is Nothing) Then
                Me.geographicAreaField = New GeographicArea
            End If
            If (Me.currencyField Is Nothing) Then
                Me.currencyField = New Currency
            End If
            If (Me.termsField Is Nothing) Then
                Me.termsField = New Terms
            End If
            If (Me.branchField Is Nothing) Then
                Me.branchField = New Branch
            End If
            If (Me.shortNameField Is Nothing) Then
                Me.shortNameField = New ShortName
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
        End Sub
        
        '''<summary>
        '''All,  Single, Range of customers to be returned. FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property Customer() As Customer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of shortname for customers to be returned. FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property ShortName() As ShortName
            Get
                Return Me.shortNameField
            End Get
            Set
                Me.shortNameField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of branches for customers to be returned. FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property Branch() As Branch
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single selection of customer terms for customers to be returned. FilterType options - A(All), (S)Single. Default to A(All).
        '''</summary>
        Public Property Terms() As Terms
            Get
                Return Me.termsField
            End Get
            Set
                Me.termsField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single selection of customer terms for customers to be returned. FilterType options - A(All), (S)Single. Default to A(All).
        '''</summary>
        Public Property Currency() As Currency
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single selection of geographic area for customers to be returned. FilterType options - A(All), (S)Single. Default to A(All).
        '''</summary>
        Public Property GeographicArea() As GeographicArea
            Get
                Return Me.geographicAreaField
            End Get
            Set
                Me.geographicAreaField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single selection of customer class for customers to be returned. FilterType options - A(All), (S)Single. Default to A(All).
        '''</summary>
        Public Property CustomerClass() As CustomerClass
            Get
                Return Me.customerClassField
            End Get
            Set
                Me.customerClassField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single selection of salesperson for customers to be returned. FilterType options - A(All), (S)Single. Default to A(All).
        '''</summary>
        Public Property SalesPerson() As SalesPerson
            Get
                Return Me.salesPersonField
            End Get
            Set
                Me.salesPersonField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of followup dates for customers to be returned. This filter will only be used if CreditNarrations is 'F'. FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property FollowupDate() As FollowupDate
            Get
                Return Me.followupDateField
            End Get
            Set
                Me.followupDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ShortName
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ShortNameFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ShortNameFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ShortNameFilterType.A)>  _
        Public Property FilterType() As ShortNameFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ShortNameFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Terms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As TermsFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = TermsFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(TermsFilterType.A)>  _
        Public Property FilterType() As TermsFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum TermsFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As GeographicAreaFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = GeographicAreaFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(GeographicAreaFilterType.A)>  _
        Public Property FilterType() As GeographicAreaFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum GeographicAreaFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SalesPerson
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SalesPersonFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = SalesPersonFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(SalesPersonFilterType.A)>  _
        Public Property FilterType() As SalesPersonFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SalesPersonFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class FollowupDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As FollowupDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = FollowupDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(FollowupDateFilterType.A)>  _
        Public Property FilterType() As FollowupDateFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum FollowupDateFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCrNotAvail
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeFutureInvoices
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludePostDatedChecks
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeRetainedInvoices
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeZeroBalanceCurrentInvoice
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeZeroBalanceCustomers
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportAsOfField As ReportAsOf
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportsSequenceField As ReportsSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customersOnHoldField As CustomersOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroBalanceCustomersField As IncludeZeroBalanceCustomers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFutureInvoicesField As IncludeFutureInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePostDatedChecksField As IncludePostDatedChecks
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRetainedInvoicesField As IncludeRetainedInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroBalanceCurrentInvoiceField As IncludeZeroBalanceCurrentInvoice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printFullAddressField As PrintFullAddress
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyValuesField As CurrencyValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convertToLocalCurrencyField As ConvertToLocalCurrency
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageingMethodField As AgeingMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageingDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useStandardAgeingColumnsField As UseStandardAgeingColumns
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageColumn1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageColumn2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageColumn3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageColumn4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ageColumn5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditNarrationsField As CreditNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balanceTypeSelectionField As BalanceTypeSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumBalanceAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerLimitandTermsByField As CustomerLimitandTermsBy
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overLimitAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private termsCheckingBasedOnField As TermsCheckingBasedOn
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private daysOverTermsField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnNotesinBlockField As ReturnNotesinBlock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportTypeField As ReportType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tagFileField As TagFile
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerDetailField As CustomerDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchSelectionByField As OptionBranchSelectionBy
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchSelectionByFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCrNotAvailField As IncludeCrNotAvail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSubAttachedMasterField As OptionIncludeSubAttachedMaster
        
        Public Sub New()
            MyBase.New
            Me.includeSubAttachedMasterField = OptionIncludeSubAttachedMaster.N
            If (Me.tagFileField Is Nothing) Then
                Me.tagFileField = New TagFile
            End If
        End Sub
        
        '''<summary>
        '''Defines the financial period for which the report will be run. (C - Current, P1 - Previous period 1 and P2 - Previous period 2 ). If no value is supplied a default of 'C' will be used.  
        '''</summary>
        Public Property ReportAsOf() As ReportAsOf
            Get
                Return Me.reportAsOfField
            End Get
            Set
                Me.reportAsOfField = value
            End Set
        End Property
        
        '''<summary>
        '''Defines the sequence in which the report will be printed. ( C - Customer number, S - Shortname, B - Branch, L - Customer class, G - Geographical area, P - Salesperson and U - user defained sequence). If no value is supplied a default of 'C' will be used. If a value of  'B' or 'P' is passed there will be special totalling by branch or by salesperson. If a value of 'U' is passed then a tag file must be supplied indicating the sequence of customers.
        '''</summary>
        Public Property ReportsSequence() As ReportsSequence
            Get
                Return Me.reportsSequenceField
            End Get
            Set
                Me.reportsSequenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether customers on hold should be included. (I - Include, E -Exclude and O - Only print customers on hold) If no value is passed a default value of 'I' will be used. 
        '''</summary>
        Public Property CustomersOnHold() As CustomersOnHold
            Get
                Return Me.customersOnHoldField
            End Get
            Set
                Me.customersOnHoldField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether customers with a zero balance should be included. ( Y - yes and N - No ). If no value is supplied then a default value of 'Y' will be used. 
        '''</summary>
        Public Property IncludeZeroBalanceCustomers() As IncludeZeroBalanceCustomers
            Get
                Return Me.includeZeroBalanceCustomersField
            End Get
            Set
                Me.includeZeroBalanceCustomersField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether future invoices should be included. (Y - yes and N - No). If no value is supplied then a default cvalue of 'Y' will be used. 
        '''</summary>
        Public Property IncludeFutureInvoices() As IncludeFutureInvoices
            Get
                Return Me.includeFutureInvoicesField
            End Get
            Set
                Me.includeFutureInvoicesField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether post dated checks should be included. (N - No and Y - Yes). If no value is supplied then a default value of 'N' will be used. 
        '''</summary>
        Public Property IncludePostDatedChecks() As IncludePostDatedChecks
            Get
                Return Me.includePostDatedChecksField
            End Get
            Set
                Me.includePostDatedChecksField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether retained invoices should be included. ( N - No and Y - Yes). If no value is supplied then a default value of 'N'  wil be used. 
        '''</summary>
        Public Property IncludeRetainedInvoices() As IncludeRetainedInvoices
            Get
                Return Me.includeRetainedInvoicesField
            End Get
            Set
                Me.includeRetainedInvoicesField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether current invoices with a zero balance should be included. (Y - Yes and N - No). If no value is supplied then a default value of 'Y' will be used. 
        '''</summary>
        Public Property IncludeZeroBalanceCurrentInvoice() As IncludeZeroBalanceCurrentInvoice
            Get
                Return Me.includeZeroBalanceCurrentInvoiceField
            End Get
            Set
                Me.includeZeroBalanceCurrentInvoiceField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether the full customer address line should be returned. (N - No and Y - Yes). If no value is supplied then a default value of 'N' will be used. When a value of 'N' is used only the first address line will be returned. If a value of 'Y' is supplied then all 5 address lines will be returned as welll as the postal code. 
        '''</summary>
        Public Property PrintFullAddress() As PrintFullAddress
            Get
                Return Me.printFullAddressField
            End Get
            Set
                Me.printFullAddressField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates what currency the values must be returned in. (L - Local and F - Foreign). If no value is supplied then a default value of 'L' will be used.
        '''</summary>
        Public Property CurrencyValues() As CurrencyValues
            Get
                Return Me.currencyValuesField
            End Get
            Set
                Me.currencyValuesField = value
            End Set
        End Property
        
        '''<summary>
        '''Only if CurrencyValues has a vaue of 'L' then the ConvertToLocalCurrency is used to indicate whether the transaction must be converted to local currency at the entry time exchange rate (E) or the current exchange rate (C). If no value is supplied then a default value of 'E' will be used. 
        '''</summary>
        Public Property ConvertToLocalCurrency() As ConvertToLocalCurrency
            Get
                Return Me.convertToLocalCurrencyField
            End Get
            Set
                Me.convertToLocalCurrencyField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates what ageing method should be applied when aging transactions. (S - statement, A - Aged statement, I - Invoice date and D - Invoice due date) If no value is supllied the aging option in the AR setup program will be used. 
        '''</summary>
        Public Property AgeingMethod() As AgeingMethod
            Get
                Return Me.ageingMethodField
            End Get
            Set
                Me.ageingMethodField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the ageing date to be applied to the transactions. The program will default to the ageing date for the ReportAsOf period supplied. 
        '''</summary>
        Public Property AgeingDate() As String
            Get
                Return Me.ageingDateField
            End Get
            Set
                Me.ageingDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether the standard aging methods should be used. (Y - Yes and N - No). If no value is supplied then a default of 'Y' will be used. If a value of 'N' is supplied then the aging columns supplied in AgeColumn1, AgeColumn2, AgeColumn3, AgeColumn4 and AgeColumn5 will be used. 
        '''</summary>
        Public Property UseStandardAgeingColumns() As UseStandardAgeingColumns
            Get
                Return Me.useStandardAgeingColumnsField
            End Get
            Set
                Me.useStandardAgeingColumnsField = value
            End Set
        End Property
        
        '''<summary>
        '''The value supplied will be used for the first column of ageing. If no value is supplied then a default value of 30 will be used. If the value supplied for UseStandardAgeingColumns is a 'Y' then the value supplied for AgeColumn1 will be ignored.
        '''</summary>
        Public Property AgeColumn1() As String
            Get
                Return Me.ageColumn1Field
            End Get
            Set
                Me.ageColumn1Field = value
            End Set
        End Property
        
        '''<summary>
        '''The value supplied will be used for the second column of ageing. If no value is supplied then a default value of 60 will be used. If the value supplied for UseStandardAgeingColumns is a 'Y' then the value supplied for AgeColumn2 will be ignored.
        '''</summary>
        Public Property AgeColumn2() As String
            Get
                Return Me.ageColumn2Field
            End Get
            Set
                Me.ageColumn2Field = value
            End Set
        End Property
        
        '''<summary>
        '''The value supplied will be used for the third column of ageing. If no value is supplied then a default value of 90 will be used. If the value supplied for UseStandardAgeingColumns is a 'Y' then the value supplied for AgeColumn3 will be ignored.
        '''</summary>
        Public Property AgeColumn3() As String
            Get
                Return Me.ageColumn3Field
            End Get
            Set
                Me.ageColumn3Field = value
            End Set
        End Property
        
        '''<summary>
        '''The value supplied will be used for the fourth column of ageing. If no value is supplied then a default value of 120 will be used. If the value supplied for UseStandardAgeingColumns is a 'Y' then the value supplied for AgeColumn4 will be ignored.
        '''</summary>
        Public Property AgeColumn4() As String
            Get
                Return Me.ageColumn4Field
            End Get
            Set
                Me.ageColumn4Field = value
            End Set
        End Property
        
        '''<summary>
        '''The value supplied will be used for the fifth column of ageing. If no value is supplied then a default value of 150 will be used. If the value supplied for UseStandardAgeingColumns is a 'Y' then the value supplied for AgeColumn5 will be ignored.
        '''</summary>
        Public Property AgeColumn5() As String
            Get
                Return Me.ageColumn5Field
            End Get
            Set
                Me.ageColumn5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether credit narrations should be returned. (I - Include, E - Exclude and F - Followup date). If no value is supplied then a default value of 'I' will be used. If a value of 'F' is return then credit narrations will be returned depending on the date range selected for the FollowupDate. If a value of 'I' or 'E' is returned then the FollowupDate will be ignored.
        '''</summary>
        Public Property CreditNarrations() As CreditNarrations
            Get
                Return Me.creditNarrationsField
            End Get
            Set
                Me.creditNarrationsField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether customers with certain balances should be included. (A - All, D - Debit and C - Credit). If no value is supplied then a default value of  'A' will be used. 
        '''</summary>
        Public Property BalanceTypeSelection() As BalanceTypeSelection
            Get
                Return Me.balanceTypeSelectionField
            End Get
            Set
                Me.balanceTypeSelectionField = value
            End Set
        End Property
        
        '''<summary>
        '''The minimum balance that a customer should have before that customers data is returned. This is only applicable if CustomerLimitandTermsBy is 'M'. If no value is supplied and CustomerLimitandTermsBy is 'M' then a default value of 999999999999.99 will be used. 
        '''</summary>
        Public Property MinimumBalanceAmount() As String
            Get
                Return Me.minimumBalanceAmountField
            End Get
            Set
                Me.minimumBalanceAmountField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates what selection criteria will be used against the customer. (A - All customers, L - Limit checking, T - Terms checking, C - limit and terms checking and M - Minimum balance checking). If no value is supplied then a default value of 'C' will be used. 
        '''</summary>
        Public Property CustomerLimitandTermsBy() As CustomerLimitandTermsBy
            Get
                Return Me.customerLimitandTermsByField
            End Get
            Set
                Me.customerLimitandTermsByField = value
            End Set
        End Property
        
        '''<summary>
        '''The maximum balance that a customer should have before that customers data is returned. This is only applicable if CustomerLimitandTermsBy is  'L' or 'C'.
        '''</summary>
        Public Property OverLimitAmount() As String
            Get
                Return Me.overLimitAmountField
            End Get
            Set
                Me.overLimitAmountField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates what method should be used for terms checking. (S - standard ageing and A - actual days). If no value is supplied then a default value of 'S' will be used. This is only applicable if CustomerLimitandTermsBy is a 'T' or 'C'.
        '''</summary>
        Public Property TermsCheckingBasedOn() As TermsCheckingBasedOn
            Get
                Return Me.termsCheckingBasedOnField
            End Get
            Set
                Me.termsCheckingBasedOnField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the number of days that the customer should be over his terms before being selected for the report. If no value is supplied then the default value of zeroes will be used. This will be ignored if CustomerLimitandTermsBy is not a 'T' or a 'C'.
        '''</summary>
        Public Property DaysOverTerms() As Boolean
            Get
                Return Me.daysOverTermsField
            End Get
            Set
                Me.daysOverTermsField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether notes should be returned combined in a block. (N - No and Y - Yes). If no value is supplied then a default value of 'N' will be used. 
        '''</summary>
        Public Property ReturnNotesinBlock() As ReturnNotesinBlock
            Get
                Return Me.returnNotesinBlockField
            End Get
            Set
                Me.returnNotesinBlockField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates how much detail should be returned (S - summary - only customer details and balances , I - include invoice detail and D - include transaction details). If not value is supplied then a default value of 'S' will be used. 
        '''</summary>
        Public Property ReportType() As ReportType
            Get
                Return Me.reportTypeField
            End Get
            Set
                Me.reportTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the path for the file which must be used for the user defined entry. This will only be used if ReportSequnce has a value of 'U'.
        '''</summary>
        Public Property TagFile() As TagFile
            Get
                Return Me.tagFileField
            End Get
            Set
                Me.tagFileField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates how much custromer detail should be returned (N - summary only customer name and number l and Y - detailed customer information). If not value is supplied then a default value of 'Y' will be used. 
        '''</summary>
        Public Property CustomerDetail() As CustomerDetail
            Get
                Return Me.customerDetailField
            End Get
            Set
                Me.customerDetailField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether the branch selection should be made on the Customer branch(C) or the Invoice branch (I). If no value is supplied then a default value of C will be used.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property BranchSelectionBy() As OptionBranchSelectionBy
            Get
                Return Me.branchSelectionByField
            End Get
            Set
                Me.branchSelectionByField = value
                Me.BranchSelectionByFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BranchSelectionBySpecified() As Boolean
            Get
                Return Me.branchSelectionByFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates whether customers without credit available should be included. (Y - yes and N - No). If no value is supplied then a default value of 'N' will be used. 
        '''</summary>
        Public Property IncludeCrNotAvail() As IncludeCrNotAvail
            Get
                Return Me.includeCrNotAvailField
            End Get
            Set
                Me.includeCrNotAvailField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(OptionIncludeSubAttachedMaster.N)>  _
        Public Property IncludeSubAttachedMaster() As OptionIncludeSubAttachedMaster
            Get
                Return Me.includeSubAttachedMasterField
            End Get
            Set
                Me.includeSubAttachedMasterField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReportAsOf
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P1
        
        '''<remarks/>
        P2
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReportsSequence
        
        '''<remarks/>
        C
        
        '''<remarks/>
        S
        
        '''<remarks/>
        B
        
        '''<remarks/>
        L
        
        '''<remarks/>
        G
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PrintFullAddress
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseStandardAgeingColumns
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TermsCheckingBasedOn
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReturnNotesinBlock
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReportType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        I
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class TagFile
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionBranchSelectionBy
        
        '''<remarks/>
        C
        
        '''<remarks/>
        I
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeSubAttachedMaster
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Filter() As Filter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "ARSQCR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
