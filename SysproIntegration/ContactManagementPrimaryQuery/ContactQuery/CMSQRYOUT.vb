Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ContactManagementPrimaryQuery.ContactQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ContactQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As List(Of ContactQueryContact)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private language2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorPrimaryRoleField As String
        
        Public Sub New()
            MyBase.New
            If (Me.contactField Is Nothing) Then
                Me.contactField = New List(Of ContactQueryContact)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Contact", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactCollection() As List(Of ContactQueryContact)
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set
                Me.languageField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Language2() As String
            Get
                Return Me.language2Field
            End Get
            Set
                Me.language2Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property DecFormat() As String
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property DateFormat() As String
            Get
                Return Me.dateFormatField
            End Get
            Set
                Me.dateFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Role() As String
            Get
                Return Me.roleField
            End Get
            Set
                Me.roleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property OperatorPrimaryRole() As String
            Get
                Return Me.operatorPrimaryRoleField
            End Get
            Set
                Me.operatorPrimaryRoleField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContact
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private personalInfoField As List(Of ContactQueryContactPersonalInfo)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private organizationInfoField As List(Of ContactQueryContactOrganizationInfo)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private classificationInfoField As List(Of ContactQueryContactClassificationInfo)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactMethodInfoField As List(Of ContactQueryContactContactMethodInfo)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactHistoryInfoField As List(Of ContactQueryContactContactHistoryInfo)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressListField As List(Of ContactQueryContactAddressListSingleAddress)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phoneListField As List(Of ContactQueryContactPhoneListSinglePhone)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailListField As List(Of ContactQueryContactEmailListSingleEmail)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateListField As List(Of ContactQueryContactDateListSingleDate)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlListField As List(Of ContactQueryContactUrlListSingleUrl)
        
        Public Sub New()
            MyBase.New
            If (Me.urlListField Is Nothing) Then
                Me.urlListField = New List(Of ContactQueryContactUrlListSingleUrl)
            End If
            If (Me.dateListField Is Nothing) Then
                Me.dateListField = New List(Of ContactQueryContactDateListSingleDate)
            End If
            If (Me.emailListField Is Nothing) Then
                Me.emailListField = New List(Of ContactQueryContactEmailListSingleEmail)
            End If
            If (Me.phoneListField Is Nothing) Then
                Me.phoneListField = New List(Of ContactQueryContactPhoneListSinglePhone)
            End If
            If (Me.addressListField Is Nothing) Then
                Me.addressListField = New List(Of ContactQueryContactAddressListSingleAddress)
            End If
            If (Me.contactHistoryInfoField Is Nothing) Then
                Me.contactHistoryInfoField = New List(Of ContactQueryContactContactHistoryInfo)
            End If
            If (Me.contactMethodInfoField Is Nothing) Then
                Me.contactMethodInfoField = New List(Of ContactQueryContactContactMethodInfo)
            End If
            If (Me.classificationInfoField Is Nothing) Then
                Me.classificationInfoField = New List(Of ContactQueryContactClassificationInfo)
            End If
            If (Me.organizationInfoField Is Nothing) Then
                Me.organizationInfoField = New List(Of ContactQueryContactOrganizationInfo)
            End If
            If (Me.personalInfoField Is Nothing) Then
                Me.personalInfoField = New List(Of ContactQueryContactPersonalInfo)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("PersonalInfo", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PersonalInfoCollection() As List(Of ContactQueryContactPersonalInfo)
            Get
                Return Me.personalInfoField
            End Get
            Set
                Me.personalInfoField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("OrganizationInfo", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property OrganizationInfoCollection() As List(Of ContactQueryContactOrganizationInfo)
            Get
                Return Me.organizationInfoField
            End Get
            Set
                Me.organizationInfoField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ClassificationInfo", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ClassificationInfoCollection() As List(Of ContactQueryContactClassificationInfo)
            Get
                Return Me.classificationInfoField
            End Get
            Set
                Me.classificationInfoField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContactMethodInfo", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactMethodInfoCollection() As List(Of ContactQueryContactContactMethodInfo)
            Get
                Return Me.contactMethodInfoField
            End Get
            Set
                Me.contactMethodInfoField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContactHistoryInfo", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactHistoryInfoCollection() As List(Of ContactQueryContactContactHistoryInfo)
            Get
                Return Me.contactHistoryInfoField
            End Get
            Set
                Me.contactHistoryInfoField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("SingleAddress", GetType(ContactQueryContactAddressListSingleAddress), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property AddressListCollection() As List(Of ContactQueryContactAddressListSingleAddress)
            Get
                Return Me.addressListField
            End Get
            Set
                Me.addressListField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("SinglePhone", GetType(ContactQueryContactPhoneListSinglePhone), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property PhoneListCollection() As List(Of ContactQueryContactPhoneListSinglePhone)
            Get
                Return Me.phoneListField
            End Get
            Set
                Me.phoneListField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("SingleEmail", GetType(ContactQueryContactEmailListSingleEmail), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property EmailListCollection() As List(Of ContactQueryContactEmailListSingleEmail)
            Get
                Return Me.emailListField
            End Get
            Set
                Me.emailListField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("SingleDate", GetType(ContactQueryContactDateListSingleDate), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property DateListCollection() As List(Of ContactQueryContactDateListSingleDate)
            Get
                Return Me.dateListField
            End Get
            Set
                Me.dateListField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("SingleUrl", GetType(ContactQueryContactUrlListSingleUrl), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property UrlListCollection() As List(Of ContactQueryContactUrlListSingleUrl)
            Get
                Return Me.urlListField
            End Get
            Set
                Me.urlListField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactPersonalInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fullNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private titleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private firstNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private middleNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private suffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preferredNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partnerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private genderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateOfBirthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private governmentIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preferredLanguageField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FullName() As String
            Get
                Return Me.fullNameField
            End Get
            Set
                Me.fullNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Title() As String
            Get
                Return Me.titleField
            End Get
            Set
                Me.titleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FirstName() As String
            Get
                Return Me.firstNameField
            End Get
            Set
                Me.firstNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MiddleName() As String
            Get
                Return Me.middleNameField
            End Get
            Set
                Me.middleNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastName() As String
            Get
                Return Me.lastNameField
            End Get
            Set
                Me.lastNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Suffix() As String
            Get
                Return Me.suffixField
            End Get
            Set
                Me.suffixField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PreferredName() As String
            Get
                Return Me.preferredNameField
            End Get
            Set
                Me.preferredNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PartnerName() As String
            Get
                Return Me.partnerNameField
            End Get
            Set
                Me.partnerNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Gender() As String
            Get
                Return Me.genderField
            End Get
            Set
                Me.genderField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DateOfBirth() As String
            Get
                Return Me.dateOfBirthField
            End Get
            Set
                Me.dateOfBirthField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property GovernmentId() As String
            Get
                Return Me.governmentIdField
            End Get
            Set
                Me.governmentIdField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PreferredLanguage() As String
            Get
                Return Me.preferredLanguageField
            End Get
            Set
                Me.preferredLanguageField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactOrganizationInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobTitleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private officeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private managerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assistantNameField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property JobTitle() As String
            Get
                Return Me.jobTitleField
            End Get
            Set
                Me.jobTitleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Department() As String
            Get
                Return Me.departmentField
            End Get
            Set
                Me.departmentField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Office() As String
            Get
                Return Me.officeField
            End Get
            Set
                Me.officeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ManagerName() As String
            Get
                Return Me.managerNameField
            End Get
            Set
                Me.managerNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AssistantName() As String
            Get
                Return Me.assistantNameField
            End Get
            Set
                Me.assistantNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactClassificationInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactClassDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactTypeDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactCategoryDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private territoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private territoryDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactOwnerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactOwnerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private suppliersField As List(Of ContactQueryContactClassificationInfoSuppliersSupplier)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customersField As List(Of ContactQueryContactClassificationInfoCustomersCustomer)
        
        Public Sub New()
            MyBase.New
            If (Me.customersField Is Nothing) Then
                Me.customersField = New List(Of ContactQueryContactClassificationInfoCustomersCustomer)
            End If
            If (Me.suppliersField Is Nothing) Then
                Me.suppliersField = New List(Of ContactQueryContactClassificationInfoSuppliersSupplier)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactClass() As String
            Get
                Return Me.contactClassField
            End Get
            Set
                Me.contactClassField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactClassDescription() As String
            Get
                Return Me.contactClassDescriptionField
            End Get
            Set
                Me.contactClassDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactType() As String
            Get
                Return Me.contactTypeField
            End Get
            Set
                Me.contactTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactTypeDescription() As String
            Get
                Return Me.contactTypeDescriptionField
            End Get
            Set
                Me.contactTypeDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactCategory() As String
            Get
                Return Me.contactCategoryField
            End Get
            Set
                Me.contactCategoryField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactCategoryDescription() As String
            Get
                Return Me.contactCategoryDescriptionField
            End Get
            Set
                Me.contactCategoryDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Territory() As String
            Get
                Return Me.territoryField
            End Get
            Set
                Me.territoryField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TerritoryDescription() As String
            Get
                Return Me.territoryDescriptionField
            End Get
            Set
                Me.territoryDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactOwner() As String
            Get
                Return Me.contactOwnerField
            End Get
            Set
                Me.contactOwnerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactOwnerName() As String
            Get
                Return Me.contactOwnerNameField
            End Get
            Set
                Me.contactOwnerNameField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactStatus() As String
            Get
                Return Me.contactStatusField
            End Get
            Set
                Me.contactStatusField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("Supplier", GetType(ContactQueryContactClassificationInfoSuppliersSupplier), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property SuppliersCollection() As List(Of ContactQueryContactClassificationInfoSuppliersSupplier)
            Get
                Return Me.suppliersField
            End Get
            Set
                Me.suppliersField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("Customer", GetType(ContactQueryContactClassificationInfoCustomersCustomer), Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property CustomersCollection() As List(Of ContactQueryContactClassificationInfoCustomersCustomer)
            Get
                Return Me.customersField
            End Get
            Set
                Me.customersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactClassificationInfoSuppliersSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property SupplierCode() As String
            Get
                Return Me.supplierCodeField
            End Get
            Set
                Me.supplierCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property SupplierName() As String
            Get
                Return Me.supplierNameField
            End Get
            Set
                Me.supplierNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactClassificationInfoCustomersCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CustomerCode() As String
            Get
                Return Me.customerCodeField
            End Get
            Set
                Me.customerCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactContactMethodInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactMethodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotPhoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotEmailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotSmsTextField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotPostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkEmailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkSmsTextField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkPostField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactMethod() As String
            Get
                Return Me.contactMethodField
            End Get
            Set
                Me.contactMethodField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotPhone() As String
            Get
                Return Me.doNotPhoneField
            End Get
            Set
                Me.doNotPhoneField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotEmail() As String
            Get
                Return Me.doNotEmailField
            End Get
            Set
                Me.doNotEmailField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotSmsText() As String
            Get
                Return Me.doNotSmsTextField
            End Get
            Set
                Me.doNotSmsTextField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotFax() As String
            Get
                Return Me.doNotFaxField
            End Get
            Set
                Me.doNotFaxField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotPost() As String
            Get
                Return Me.doNotPostField
            End Get
            Set
                Me.doNotPostField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotBulkEmail() As String
            Get
                Return Me.doNotBulkEmailField
            End Get
            Set
                Me.doNotBulkEmailField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotBulkSmsText() As String
            Get
                Return Me.doNotBulkSmsTextField
            End Get
            Set
                Me.doNotBulkSmsTextField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotBulkFax() As String
            Get
                Return Me.doNotBulkFaxField
            End Get
            Set
                Me.doNotBulkFaxField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DoNotBulkPost() As String
            Get
                Return Me.doNotBulkPostField
            End Get
            Set
                Me.doNotBulkPostField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactContactHistoryInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createdDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createdTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createdByField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChangedDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChangedTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastChangedByField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastContactDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastContactTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastContactByField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CreatedDate() As String
            Get
                Return Me.createdDateField
            End Get
            Set
                Me.createdDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CreatedTime() As String
            Get
                Return Me.createdTimeField
            End Get
            Set
                Me.createdTimeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CreatedBy() As String
            Get
                Return Me.createdByField
            End Get
            Set
                Me.createdByField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastChangedDate() As String
            Get
                Return Me.lastChangedDateField
            End Get
            Set
                Me.lastChangedDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastChangedTime() As String
            Get
                Return Me.lastChangedTimeField
            End Get
            Set
                Me.lastChangedTimeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastChangedBy() As String
            Get
                Return Me.lastChangedByField
            End Get
            Set
                Me.lastChangedByField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastContactDate() As String
            Get
                Return Me.lastContactDateField
            End Get
            Set
                Me.lastContactDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastContactTime() As String
            Get
                Return Me.lastContactTimeField
            End Get
            Set
                Me.lastContactTimeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LastContactBy() As String
            Get
                Return Me.lastContactByField
            End Get
            Set
                Me.lastContactByField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactAddressListSingleAddress
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buildingField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private streetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private zipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressWorkHomeFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressPreferredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addressPrivateField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AddressType() As String
            Get
                Return Me.addressTypeField
            End Get
            Set
                Me.addressTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AddressDescription() As String
            Get
                Return Me.addressDescriptionField
            End Get
            Set
                Me.addressDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Building() As String
            Get
                Return Me.buildingField
            End Get
            Set
                Me.buildingField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Street() As String
            Get
                Return Me.streetField
            End Get
            Set
                Me.streetField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Locality() As String
            Get
                Return Me.localityField
            End Get
            Set
                Me.localityField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Country() As String
            Get
                Return Me.countryField
            End Get
            Set
                Me.countryField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Zip() As String
            Get
                Return Me.zipField
            End Get
            Set
                Me.zipField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AddressWorkHomeFlag() As String
            Get
                Return Me.addressWorkHomeFlagField
            End Get
            Set
                Me.addressWorkHomeFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AddressPreferred() As String
            Get
                Return Me.addressPreferredField
            End Get
            Set
                Me.addressPreferredField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property AddressPrivate() As String
            Get
                Return Me.addressPrivateField
            End Get
            Set
                Me.addressPrivateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactPhoneListSinglePhone
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phoneTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phoneDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneExtnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phoneWorkHomeFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phonePreferredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phonePrivateField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PhoneType() As String
            Get
                Return Me.phoneTypeField
            End Get
            Set
                Me.phoneTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PhoneDescription() As String
            Get
                Return Me.phoneDescriptionField
            End Get
            Set
                Me.phoneDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TelephoneExtn() As String
            Get
                Return Me.telephoneExtnField
            End Get
            Set
                Me.telephoneExtnField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PhoneWorkHomeFlag() As String
            Get
                Return Me.phoneWorkHomeFlagField
            End Get
            Set
                Me.phoneWorkHomeFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PhonePreferred() As String
            Get
                Return Me.phonePreferredField
            End Get
            Set
                Me.phonePreferredField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PhonePrivate() As String
            Get
                Return Me.phonePrivateField
            End Get
            Set
                Me.phonePrivateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactEmailListSingleEmail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailDisplayAsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailWorkHomeFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailPreferredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailPrivateField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailType() As String
            Get
                Return Me.emailTypeField
            End Get
            Set
                Me.emailTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailDescription() As String
            Get
                Return Me.emailDescriptionField
            End Get
            Set
                Me.emailDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailDisplayAs() As String
            Get
                Return Me.emailDisplayAsField
            End Get
            Set
                Me.emailDisplayAsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailWorkHomeFlag() As String
            Get
                Return Me.emailWorkHomeFlagField
            End Get
            Set
                Me.emailWorkHomeFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailPreferred() As String
            Get
                Return Me.emailPreferredField
            End Get
            Set
                Me.emailPreferredField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property EmailPrivate() As String
            Get
                Return Me.emailPrivateField
            End Get
            Set
                Me.emailPrivateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactDateListSingleDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reminderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reminderDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private datePrivateField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DateType() As String
            Get
                Return Me.dateTypeField
            End Get
            Set
                Me.dateTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DateDescription() As String
            Get
                Return Me.dateDescriptionField
            End Get
            Set
                Me.dateDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ContactDate() As String
            Get
                Return Me.contactDateField
            End Get
            Set
                Me.contactDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Reminder() As String
            Get
                Return Me.reminderField
            End Get
            Set
                Me.reminderField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ReminderDays() As String
            Get
                Return Me.reminderDaysField
            End Get
            Set
                Me.reminderDaysField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DatePrivate() As String
            Get
                Return Me.datePrivateField
            End Get
            Set
                Me.datePrivateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ContactQueryContactUrlListSingleUrl
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlPreferredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private urlPrivateField As String
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property UrlType() As String
            Get
                Return Me.urlTypeField
            End Get
            Set
                Me.urlTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property UrlDescription() As String
            Get
                Return Me.urlDescriptionField
            End Get
            Set
                Me.urlDescriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Url() As String
            Get
                Return Me.urlField
            End Get
            Set
                Me.urlField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property UrlPreferred() As String
            Get
                Return Me.urlPreferredField
            End Get
            Set
                Me.urlPreferredField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property UrlPrivate() As String
            Get
                Return Me.urlPrivateField
            End Get
            Set
                Me.urlPrivateField = value
            End Set
        End Property
    End Class
End Namespace
