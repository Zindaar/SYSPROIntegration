Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ContactManagementPrimaryPosting.ContactPostContact.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostContact
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of PostContactItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostContactParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostContactItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of PostContactItem)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of PostContactItem))
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "CMSTCO"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostContactParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostContactParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
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
                Dim str As String = doc.OuterXml
                str = str.Replace("<PostContactItemCustomer>", "")
                str = str.Replace("</PostContactItemCustomer>", "")
                str = str.Replace("<PostContactItemSupplier>", "")
                str = str.Replace("</PostContactItemSupplier>", "")
                str = str.Replace("<PostContactItemAccount>", "")
                str = str.Replace("</PostContactItemAccount>", "")
                Return str
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostContact
                objParams = New Params.PostContact
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostContactItem
        
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
        Private genderField As PostContactItemGender
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateOfBirthField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private governmentIdField As Long
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobTitleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private departmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private officeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private territoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private propertyField As PostContactItemProperty
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactCategoryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private influenceField As PostContactItemInfluence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactStatusField As PostContactItemContactStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultContactField As PostContactItemDefaultContact
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private managerNameField As PostContactItemManagerName
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assistantNameField As PostContactItemAssistantName
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactMethodField As PostContactItemContactMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactOwnerField As PostContactItemContactOwner
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotPhoneField As PostContactItemDoNotPhone
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotEmailField As PostContactItemDoNotEmail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotSmsField As PostContactItemDoNotSms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotFaxField As PostContactItemDoNotFax
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotPostField As PostContactItemDoNotPost
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkEmailField As PostContactItemDoNotBulkEmail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkSmsField As PostContactItemDoNotBulkSms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkFaxField As PostContactItemDoNotBulkFax
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private doNotBulkPostField As PostContactItemDoNotBulkPost
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customersField As List(Of PostContactItemCustomer)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private suppliersField As List(Of PostContactItemSupplier)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private accountsField As List(Of PostContactItemAccount)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressListField As List(Of PostContactItemSingleAddress)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phoneListField As List(Of PostContactItemSinglePhone)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailListField As List(Of PostContactItemSingleEmail)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateListField As List(Of PostContactItemSingleDate)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlListField As List(Of PostContactItemSingleUrl)

        Public Sub New()
            MyBase.New()
            If (Me.contactOwnerField Is Nothing) Then
                Me.contactOwnerField = New PostContactItemContactOwner
            End If
            If (Me.assistantNameField Is Nothing) Then
                Me.assistantNameField = New PostContactItemAssistantName
            End If
            If (Me.managerNameField Is Nothing) Then
                Me.managerNameField = New PostContactItemManagerName
            End If
        End Sub

        Public Property FullName() As String
            Get
                Return Me.fullNameField
            End Get
            Set(ByVal value As String)
                Me.fullNameField = value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return Me.titleField
            End Get
            Set(ByVal value As String)
                Me.titleField = value
            End Set
        End Property

        Public Property FirstName() As String
            Get
                Return Me.firstNameField
            End Get
            Set(ByVal value As String)
                Me.firstNameField = value
            End Set
        End Property

        Public Property MiddleName() As String
            Get
                Return Me.middleNameField
            End Get
            Set(ByVal value As String)
                Me.middleNameField = value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return Me.lastNameField
            End Get
            Set(ByVal value As String)
                Me.lastNameField = value
            End Set
        End Property

        Public Property Suffix() As String
            Get
                Return Me.suffixField
            End Get
            Set(ByVal value As String)
                Me.suffixField = value
            End Set
        End Property

        Public Property PreferredName() As String
            Get
                Return Me.preferredNameField
            End Get
            Set(ByVal value As String)
                Me.preferredNameField = value
            End Set
        End Property

        Public Property PartnerName() As String
            Get
                Return Me.partnerNameField
            End Get
            Set(ByVal value As String)
                Me.partnerNameField = value
            End Set
        End Property

        Public Property Gender() As PostContactItemGender
            Get
                Return Me.genderField
            End Get
            Set(ByVal value As PostContactItemGender)
                Me.genderField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")> _
        Public Property DateOfBirth() As Date
            Get
                Return Me.dateOfBirthField
            End Get
            Set(ByVal value As Date)
                Me.dateOfBirthField = value
            End Set
        End Property

        Public Property GovernmentId() As Long
            Get
                Return Me.governmentIdField
            End Get
            Set(ByVal value As Long)
                Me.governmentIdField = value
            End Set
        End Property

        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As String)
                Me.languageField = value
            End Set
        End Property

        Public Property JobTitle() As String
            Get
                Return Me.jobTitleField
            End Get
            Set(ByVal value As String)
                Me.jobTitleField = value
            End Set
        End Property

        Public Property Department() As String
            Get
                Return Me.departmentField
            End Get
            Set(ByVal value As String)
                Me.departmentField = value
            End Set
        End Property

        Public Property Office() As String
            Get
                Return Me.officeField
            End Get
            Set(ByVal value As String)
                Me.officeField = value
            End Set
        End Property

        Public Property Territory() As String
            Get
                Return Me.territoryField
            End Get
            Set(ByVal value As String)
                Me.territoryField = value
            End Set
        End Property

        Public Property [Property]() As PostContactItemProperty
            Get
                Return Me.propertyField
            End Get
            Set(ByVal value As PostContactItemProperty)
                Me.propertyField = value
            End Set
        End Property

        Public Property ContactClass() As String
            Get
                Return Me.contactClassField
            End Get
            Set(ByVal value As String)
                Me.contactClassField = value
            End Set
        End Property

        Public Property ContactType() As String
            Get
                Return Me.contactTypeField
            End Get
            Set(ByVal value As String)
                Me.contactTypeField = value
            End Set
        End Property

        Public Property ContactCategory() As String
            Get
                Return Me.contactCategoryField
            End Get
            Set(ByVal value As String)
                Me.contactCategoryField = value
            End Set
        End Property

        Public Property Influence() As PostContactItemInfluence
            Get
                Return Me.influenceField
            End Get
            Set(ByVal value As PostContactItemInfluence)
                Me.influenceField = value
            End Set
        End Property

        Public Property ContactStatus() As PostContactItemContactStatus
            Get
                Return Me.contactStatusField
            End Get
            Set(ByVal value As PostContactItemContactStatus)
                Me.contactStatusField = value
            End Set
        End Property

        Public Property DefaultContact() As PostContactItemDefaultContact
            Get
                Return Me.defaultContactField
            End Get
            Set(ByVal value As PostContactItemDefaultContact)
                Me.defaultContactField = value
            End Set
        End Property

        Public Property ManagerName() As PostContactItemManagerName
            Get
                Return Me.managerNameField
            End Get
            Set(ByVal value As PostContactItemManagerName)
                Me.managerNameField = value
            End Set
        End Property

        Public Property AssistantName() As PostContactItemAssistantName
            Get
                Return Me.assistantNameField
            End Get
            Set(ByVal value As PostContactItemAssistantName)
                Me.assistantNameField = value
            End Set
        End Property

        Public Property ContactMethod() As PostContactItemContactMethod
            Get
                Return Me.contactMethodField
            End Get
            Set(ByVal value As PostContactItemContactMethod)
                Me.contactMethodField = value
            End Set
        End Property

        Public Property ContactOwner() As PostContactItemContactOwner
            Get
                Return Me.contactOwnerField
            End Get
            Set(ByVal value As PostContactItemContactOwner)
                Me.contactOwnerField = value
            End Set
        End Property

        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set(ByVal value As String)
                Me.commentField = value
            End Set
        End Property

        Public Property DoNotPhone() As PostContactItemDoNotPhone
            Get
                Return Me.doNotPhoneField
            End Get
            Set(ByVal value As PostContactItemDoNotPhone)
                Me.doNotPhoneField = value
            End Set
        End Property

        Public Property DoNotEmail() As PostContactItemDoNotEmail
            Get
                Return Me.doNotEmailField
            End Get
            Set(ByVal value As PostContactItemDoNotEmail)
                Me.doNotEmailField = value
            End Set
        End Property

        Public Property DoNotSms() As PostContactItemDoNotSms
            Get
                Return Me.doNotSmsField
            End Get
            Set(ByVal value As PostContactItemDoNotSms)
                Me.doNotSmsField = value
            End Set
        End Property

        Public Property DoNotFax() As PostContactItemDoNotFax
            Get
                Return Me.doNotFaxField
            End Get
            Set(ByVal value As PostContactItemDoNotFax)
                Me.doNotFaxField = value
            End Set
        End Property

        Public Property DoNotPost() As PostContactItemDoNotPost
            Get
                Return Me.doNotPostField
            End Get
            Set(ByVal value As PostContactItemDoNotPost)
                Me.doNotPostField = value
            End Set
        End Property

        Public Property DoNotBulkEmail() As PostContactItemDoNotBulkEmail
            Get
                Return Me.doNotBulkEmailField
            End Get
            Set(ByVal value As PostContactItemDoNotBulkEmail)
                Me.doNotBulkEmailField = value
            End Set
        End Property

        Public Property DoNotBulkSms() As PostContactItemDoNotBulkSms
            Get
                Return Me.doNotBulkSmsField
            End Get
            Set(ByVal value As PostContactItemDoNotBulkSms)
                Me.doNotBulkSmsField = value
            End Set
        End Property

        Public Property DoNotBulkFax() As PostContactItemDoNotBulkFax
            Get
                Return Me.doNotBulkFaxField
            End Get
            Set(ByVal value As PostContactItemDoNotBulkFax)
                Me.doNotBulkFaxField = value
            End Set
        End Property

        Public Property DoNotBulkPost() As PostContactItemDoNotBulkPost
            Get
                Return Me.doNotBulkPostField
            End Get
            Set(ByVal value As PostContactItemDoNotBulkPost)
                Me.doNotBulkPostField = value
            End Set
        End Property

        Public Property Customers() As List(Of PostContactItemCustomer)
            Get
                Return Me.customersField
            End Get
            Set(ByVal value As List(Of PostContactItemCustomer))
                Me.customersField = value
            End Set
        End Property

        Public Property Suppliers() As List(Of PostContactItemSupplier)
            Get
                Return Me.suppliersField
            End Get
            Set(ByVal value As List(Of PostContactItemSupplier))
                Me.suppliersField = value
            End Set
        End Property

        Public Property Accounts() As List(Of PostContactItemAccount)
            Get
                Return Me.accountsField
            End Get
            Set(ByVal value As List(Of PostContactItemAccount))
                Me.accountsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("SingleAddress", IsNullable:=False)> _
        Public Property AddressList() As List(Of PostContactItemSingleAddress)
            Get
                Return Me.addressListField
            End Get
            Set(ByVal value As List(Of PostContactItemSingleAddress))
                Me.addressListField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("SinglePhone", IsNullable:=False)> _
        Public Property PhoneList() As List(Of PostContactItemSinglePhone)
            Get
                Return Me.phoneListField
            End Get
            Set(ByVal value As List(Of PostContactItemSinglePhone))
                Me.phoneListField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("SingleEmail", IsNullable:=False)> _
        Public Property EmailList() As List(Of PostContactItemSingleEmail)
            Get
                Return Me.emailListField
            End Get
            Set(ByVal value As List(Of PostContactItemSingleEmail))
                Me.emailListField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("SingleDate", IsNullable:=False)> _
        Public Property DateList() As List(Of PostContactItemSingleDate)
            Get
                Return Me.dateListField
            End Get
            Set(ByVal value As List(Of PostContactItemSingleDate))
                Me.dateListField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlArrayItemAttribute("SingleUrl", IsNullable:=False)> _
        Public Property UrlList() As List(Of PostContactItemSingleUrl)
            Get
                Return Me.urlListField
            End Get
            Set(ByVal value As List(Of PostContactItemSingleUrl))
                Me.urlListField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemGender

        '''<remarks/>
        M

        '''<remarks/>
        F

        '''<remarks/>
        U
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemProperty

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")> _
        Item0

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")> _
        Item2

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")> _
        Item5

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")> _
        Item6

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")> _
        Item7
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemInfluence

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")> _
        Item1

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")> _
        Item5

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")> _
        Item7

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("9")> _
        Item9
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemContactStatus

        '''<remarks/>
        N

        '''<remarks/>
        H
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDefaultContact

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemManagerName
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemAssistantName
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemContactMethod

        '''<remarks/>
        N

        '''<remarks/>
        T

        '''<remarks/>
        E

        '''<remarks/>
        S

        '''<remarks/>
        F

        '''<remarks/>
        P
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemContactOwner
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotPhone

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotEmail

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotSms

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotFax

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotPost

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotBulkEmail

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotBulkSms

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotBulkFax

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemDoNotBulkPost

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemCustomer

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerField As String

        <CLSCompliant(False)> _
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set(ByVal value As String)
                Me.customerField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSupplier

        <EditorBrowsable(EditorBrowsableState.Never)> _
       Private supplierField As String

        <CLSCompliant(False)> _
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set(ByVal value As String)
                Me.supplierField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemAccount
        <EditorBrowsable(EditorBrowsableState.Never)> _
       Private accountField As String

        <CLSCompliant(False)> _
        Public Property Account() As String
            Get
                Return Me.accountField
            End Get
            Set(ByVal value As String)
                Me.accountField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSingleAddress

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private buildingField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private streetField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private localityField As PostContactItemSingleAddressLocality

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private countryField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private zipField As Short

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressWorkHomeFlagField As PostContactItemSingleAddressAddressWorkHomeFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressPreferredField As PostContactItemSingleAddressAddressPreferred

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addressPrivateField As PostContactItemSingleAddressAddressPrivate

        Public Sub New()
            MyBase.New()
            If (Me.localityField Is Nothing) Then
                Me.localityField = New PostContactItemSingleAddressLocality
            End If
        End Sub

        <CLSCompliant(False)> _
        Public Property AddressType() As String
            Get
                Return Me.addressTypeField
            End Get
            Set(ByVal value As String)
                Me.addressTypeField = value
            End Set
        End Property

        Public Property AddressDescription() As String
            Get
                Return Me.addressDescriptionField
            End Get
            Set(ByVal value As String)
                Me.addressDescriptionField = Value
            End Set
        End Property

        Public Property Building() As String
            Get
                Return Me.buildingField
            End Get
            Set(ByVal value As String)
                Me.buildingField = Value
            End Set
        End Property

        Public Property Street() As String
            Get
                Return Me.streetField
            End Get
            Set(ByVal value As String)
                Me.streetField = Value
            End Set
        End Property

        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set(ByVal value As String)
                Me.cityField = Value
            End Set
        End Property

        Public Property Locality() As PostContactItemSingleAddressLocality
            Get
                Return Me.localityField
            End Get
            Set(ByVal value As PostContactItemSingleAddressLocality)
                Me.localityField = Value
            End Set
        End Property

        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set(ByVal value As String)
                Me.stateField = Value
            End Set
        End Property

        Public Property Country() As String
            Get
                Return Me.countryField
            End Get
            Set(ByVal value As String)
                Me.countryField = Value
            End Set
        End Property

        Public Property Zip() As Short
            Get
                Return Me.zipField
            End Get
            Set(ByVal value As Short)
                Me.zipField = Value
            End Set
        End Property

        Public Property AddressWorkHomeFlag() As PostContactItemSingleAddressAddressWorkHomeFlag
            Get
                Return Me.addressWorkHomeFlagField
            End Get
            Set(ByVal value As PostContactItemSingleAddressAddressWorkHomeFlag)
                Me.addressWorkHomeFlagField = Value
            End Set
        End Property

        Public Property AddressPreferred() As PostContactItemSingleAddressAddressPreferred
            Get
                Return Me.addressPreferredField
            End Get
            Set(ByVal value As PostContactItemSingleAddressAddressPreferred)
                Me.addressPreferredField = Value
            End Set
        End Property

        Public Property AddressPrivate() As PostContactItemSingleAddressAddressPrivate
            Get
                Return Me.addressPrivateField
            End Get
            Set(ByVal value As PostContactItemSingleAddressAddressPrivate)
                Me.addressPrivateField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSingleAddressLocality
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleAddressAddressWorkHomeFlag

        '''<remarks/>
        H

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleAddressAddressPreferred

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleAddressAddressPrivate

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSinglePhone

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private telephoneTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phoneDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private telephoneField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private telephoneExtnField As Short

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private telephoneExtnFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phoneWorkHomeFlagField As PostContactItemSinglePhonePhoneWorkHomeFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phoneWorkHomeFlagFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phonePreferredField As PostContactItemSinglePhonePhonePreferred

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private phonePrivateField As PostContactItemSinglePhonePhonePrivate

        <CLSCompliant(False)> _
        Public Property TelephoneType() As String
            Get
                Return Me.telephoneTypeField
            End Get
            Set(ByVal value As String)
                Me.telephoneTypeField = value
            End Set
        End Property

        Public Property PhoneDescription() As String
            Get
                Return Me.phoneDescriptionField
            End Get
            Set(ByVal value As String)
                Me.phoneDescriptionField = Value
            End Set
        End Property

        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set(ByVal value As String)
                Me.telephoneField = value
            End Set
        End Property

        Public Property TelephoneExtn() As Short
            Get
                Return Me.telephoneExtnField
            End Get
            Set(ByVal value As Short)
                Me.telephoneExtnField = Value
                Me.telephoneExtnFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property TelephoneExtnSpecified() As Boolean
            Get
                Return Me.telephoneExtnFieldSpecified
            End Get
        End Property

        Public Property PhoneWorkHomeFlag() As PostContactItemSinglePhonePhoneWorkHomeFlag
            Get
                Return Me.phoneWorkHomeFlagField
            End Get
            Set(ByVal value As PostContactItemSinglePhonePhoneWorkHomeFlag)
                Me.phoneWorkHomeFlagField = Value
                Me.phoneWorkHomeFlagFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property PhoneWorkHomeFlagSpecified() As Boolean
            Get
                Return Me.phoneWorkHomeFlagFieldSpecified
            End Get
        End Property

        Public Property PhonePreferred() As PostContactItemSinglePhonePhonePreferred
            Get
                Return Me.phonePreferredField
            End Get
            Set(ByVal value As PostContactItemSinglePhonePhonePreferred)
                Me.phonePreferredField = Value
            End Set
        End Property

        Public Property PhonePrivate() As PostContactItemSinglePhonePhonePrivate
            Get
                Return Me.phonePrivateField
            End Get
            Set(ByVal value As PostContactItemSinglePhonePhonePrivate)
                Me.phonePrivateField = Value
            End Set
        End Property
    End Class


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSinglePhonePhoneWorkHomeFlag

        '''<remarks/>
        H

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSinglePhonePhonePreferred

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSinglePhonePhonePrivate

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSingleEmail

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailDisplayAsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailWorkHomeFlagField As PostContactItemSingleEmailEmailWorkHomeFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailPreferredField As PostContactItemSingleEmailEmailPreferred

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private emailPrivateField As PostContactItemSingleEmailEmailPrivate

        <CLSCompliant(False)> _
        Public Property EmailType() As String
            Get
                Return Me.emailTypeField
            End Get
            Set(ByVal value As String)
                Me.emailTypeField = value
            End Set
        End Property

        Public Property EmailDescription() As String
            Get
                Return Me.emailDescriptionField
            End Get
            Set(ByVal value As String)
                Me.emailDescriptionField = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set(ByVal value As String)
                Me.emailField = value
            End Set
        End Property

        Public Property EmailDisplayAs() As String
            Get
                Return Me.emailDisplayAsField
            End Get
            Set(ByVal value As String)
                Me.emailDisplayAsField = Value
            End Set
        End Property

        Public Property EmailWorkHomeFlag() As PostContactItemSingleEmailEmailWorkHomeFlag
            Get
                Return Me.emailWorkHomeFlagField
            End Get
            Set(ByVal value As PostContactItemSingleEmailEmailWorkHomeFlag)
                Me.emailWorkHomeFlagField = Value
            End Set
        End Property

        Public Property EmailPreferred() As PostContactItemSingleEmailEmailPreferred
            Get
                Return Me.emailPreferredField
            End Get
            Set(ByVal value As PostContactItemSingleEmailEmailPreferred)
                Me.emailPreferredField = Value
            End Set
        End Property

        Public Property EmailPrivate() As PostContactItemSingleEmailEmailPrivate
            Get
                Return Me.emailPrivateField
            End Get
            Set(ByVal value As PostContactItemSingleEmailEmailPrivate)
                Me.emailPrivateField = Value
            End Set
        End Property
    End Class


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleEmailEmailWorkHomeFlag

        '''<remarks/>
        H

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleEmailEmailPreferred

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleEmailEmailPrivate

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSingleDate

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private dateDescriptionField As PostContactItemSingleDateDateDescription

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private contactDateField As Date

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reminderField As PostContactItemSingleDateReminder

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private datePrivateField As PostContactItemSingleDateDatePrivate

        <CLSCompliant(False)> _
        Public Property DateType() As String
            Get
                Return Me.dateTypeField
            End Get
            Set(ByVal value As String)
                Me.dateTypeField = value
            End Set
        End Property

        Public Property DateDescription() As PostContactItemSingleDateDateDescription
            Get
                Return Me.dateDescriptionField
            End Get
            Set(ByVal value As PostContactItemSingleDateDateDescription)
                Me.dateDescriptionField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")> _
        Public Property ContactDate() As Date
            Get
                Return Me.contactDateField
            End Get
            Set(ByVal value As Date)
                Me.contactDateField = Value
            End Set
        End Property

        Public Property Reminder() As PostContactItemSingleDateReminder
            Get
                Return Me.reminderField
            End Get
            Set(ByVal value As PostContactItemSingleDateReminder)
                Me.reminderField = Value
            End Set
        End Property

        Public Property DatePrivate() As PostContactItemSingleDateDatePrivate
            Get
                Return Me.datePrivateField
            End Get
            Set(ByVal value As PostContactItemSingleDateDatePrivate)
                Me.datePrivateField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleDateDateDescription

        '''<remarks/>
        Anniversary

        '''<remarks/>
        Birthday
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleDateReminder

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostContactItemSingleDateDatePrivate

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostContactItemSingleUrl

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlPreferredField As PostContactItemSingleUrlUrlPreferred

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private urlPrivateField As PostContactItemSingleUrlUrlPrivate

        <CLSCompliant(False)> _
        Public Property UrlType() As String
            Get
                Return Me.urlTypeField
            End Get
            Set(ByVal value As String)
                Me.urlTypeField = value
            End Set
        End Property

        Public Property UrlDescription() As String
            Get
                Return Me.urlDescriptionField
            End Get
            Set(ByVal value As String)
                Me.urlDescriptionField = Value
            End Set
        End Property

        Public Property Url() As String
            Get
                Return Me.urlField
            End Get
            Set(ByVal value As String)
                Me.urlField = value
            End Set
        End Property

        Public Property UrlPreferred() As PostContactItemSingleUrlUrlPreferred
            Get
                Return Me.urlPreferredField
            End Get
            Set(ByVal value As PostContactItemSingleUrlUrlPreferred)
                Me.urlPreferredField = Value
            End Set
        End Property

        Public Property UrlPrivate() As PostContactItemSingleUrlUrlPrivate
            Get
                Return Me.urlPrivateField
            End Get
            Set(ByVal value As PostContactItemSingleUrlUrlPrivate)
                Me.urlPrivateField = Value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostContactItemSingleUrlUrlPreferred
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostContactItemSingleUrlUrlPrivate
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
