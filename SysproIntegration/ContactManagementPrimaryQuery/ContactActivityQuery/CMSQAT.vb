Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ContactManagementPrimaryQuery.ContactActivityQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Account
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As AccountFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = AccountFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(AccountFilterType.A)>  _
        Public Property FilterType() As AccountFilterType
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
    Public Enum AccountFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ActivityType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ActivityTypeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ActivityTypeFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ActivityTypeFilterType.A)>  _
        Public Property FilterType() As ActivityTypeFilterType
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
    Public Enum ActivityTypeFilterType
        
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
    Partial Public Class ContactId
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As ContactIdFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = ContactIdFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(ContactIdFilterType.A)>  _
        Public Property FilterType() As ContactIdFilterType
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
    Public Enum ContactIdFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        L
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
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class EndDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As EndDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = EndDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(EndDateFilterType.A)>  _
        Public Property FilterType() As EndDateFilterType
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
    Public Enum EndDateFilterType
        
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
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accountField As Account
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactIdField As ContactId
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private activityTypeField As ActivityType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDateField As StartDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDateField As EndDate
        
        Public Sub New()
            MyBase.New
            If (Me.endDateField Is Nothing) Then
                Me.endDateField = New EndDate
            End If
            If (Me.startDateField Is Nothing) Then
                Me.startDateField = New StartDate
            End If
            If (Me.activityTypeField Is Nothing) Then
                Me.activityTypeField = New ActivityType
            End If
            If (Me.contactIdField Is Nothing) Then
                Me.contactIdField = New ContactId
            End If
            If (Me.accountField Is Nothing) Then
                Me.accountField = New Account
            End If
            If (Me.supplierField Is Nothing) Then
                Me.supplierField = New Supplier
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
        End Sub
        
        '''<summary>
        '''Allows for the activites to be filtered on Customer. The default is "A".
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
        '''Allows for the activites to be filtered on Supplier. The default is "A".
        '''</summary>
        Public Property Supplier() As Supplier
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for the activites to be filtered on Account. The default is "A".
        '''</summary>
        Public Property Account() As Account
            Get
                Return Me.accountField
            End Get
            Set
                Me.accountField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for the activites to be filtered on ContactId. The default is "A".
        '''</summary>
        Public Property ContactId() As ContactId
            Get
                Return Me.contactIdField
            End Get
            Set
                Me.contactIdField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for the activites to be filtered on ActivityType. The default is "A".
        '''</summary>
        Public Property ActivityType() As ActivityType
            Get
                Return Me.activityTypeField
            End Get
            Set
                Me.activityTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for the activites to be filtered on StartDate. The default is "A".
        '''</summary>
        Public Property StartDate() As StartDate
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Allows for the activites to be filtered on EndDate. The default is "A".
        '''</summary>
        Public Property EndDate() As EndDate
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = value
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
    Partial Public Class Supplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As SupplierFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = SupplierFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(SupplierFilterType.A)>  _
        Public Property FilterType() As SupplierFilterType
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
    Public Enum SupplierFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StartDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As StartDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = StartDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(StartDateFilterType.A)>  _
        Public Property FilterType() As StartDateFilterType
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
    Public Enum StartDateFilterType
        
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
    Public Enum IncludeAttachments
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeAttendees
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCaptions
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCleared
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeContactInfo
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeFollowUpInformation
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeFullBody
        
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
    Partial Public Class Options
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFollowUpInformationField As IncludeFollowUpInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBottomActivitesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeClearedField As IncludeCleared
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFullBodyField As IncludeFullBody
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAttendeesField As IncludeAttendees
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAttachmentsField As IncludeAttachments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeContactInfoField As IncludeContactInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCaptionsField As IncludeCaptions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subjectSearchStringField As SubjectSearchString
        
        Public Sub New()
            MyBase.New
            Me.includeFollowUpInformationField = IncludeFollowUpInformation.N
            Me.includeClearedField = IncludeCleared.N
            Me.includeFullBodyField = IncludeFullBody.N
            Me.includeAttendeesField = IncludeAttendees.N
            Me.includeAttachmentsField = IncludeAttachments.N
            Me.includeContactInfoField = IncludeContactInfo.N
            Me.includeCaptionsField = IncludeCaptions.N
            If (Me.subjectSearchStringField Is Nothing) Then
                Me.subjectSearchStringField = New SubjectSearchString
            End If
        End Sub
        
        '''<summary>
        '''By setting the value to 'Y' followup information for the activity will be included. The default value is 'N'.
        '''</summary>
        Public Property IncludeFollowUpInformation() As IncludeFollowUpInformation
            Get
                Return Me.includeFollowUpInformationField
            End Get
            Set
                Me.includeFollowUpInformationField = value
            End Set
        End Property
        
        '''<summary>
        '''This allows you to specify how many activites needs to be returned for each contact. If you want all the activities to be returned use '{ALL}' as the value. Otherwise use '5' for example and it will return the last 5 activities for each contact. The default is 10.
        '''</summary>
        Public Property IncludeBottomActivites() As String
            Get
                Return Me.includeBottomActivitesField
            End Get
            Set
                Me.includeBottomActivitesField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' actvities that have been cleared will be included. By setting the value to 'N' activities cleared will NOT be included. By setting the value to 'A' both cleared and not cleared will be returned. The default value is 'N'.
        '''</summary>
        Public Property IncludeCleared() As IncludeCleared
            Get
                Return Me.includeClearedField
            End Get
            Set
                Me.includeClearedField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' the entire body text of the activity will be returned. The  default is "N".
        '''</summary>
        Public Property IncludeFullBody() As IncludeFullBody
            Get
                Return Me.includeFullBodyField
            End Get
            Set
                Me.includeFullBodyField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' all  the attendee related to the activity will be returned. The default is 'N'.
        '''</summary>
        Public Property IncludeAttendees() As IncludeAttendees
            Get
                Return Me.includeAttendeesField
            End Get
            Set
                Me.includeAttendeesField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' all  the attachments related to the activity will be returned. The default is 'N'.
        '''</summary>
        Public Property IncludeAttachments() As IncludeAttachments
            Get
                Return Me.includeAttachmentsField
            End Get
            Set
                Me.includeAttachmentsField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' all  the detailed infomation about the contact will be returned. The default is 'N'.
        '''</summary>
        Public Property IncludeContactInfo() As IncludeContactInfo
            Get
                Return Me.includeContactInfoField
            End Get
            Set
                Me.includeContactInfoField = value
            End Set
        End Property
        
        '''<summary>
        '''By setting the value to 'Y' captions will be returned against the element as an attribute. The captions will be a translated word that can be used when developing an application. The default is 'N'.
        '''</summary>
        Public Property IncludeCaptions() As IncludeCaptions
            Get
                Return Me.includeCaptionsField
            End Get
            Set
                Me.includeCaptionsField = value
            End Set
        End Property
        
        '''<summary>
        '''If a value is provided in this element each activities' subject will be searched and if the subject of the activity contains the value provided in ths element the activity will be returned.
        '''</summary>
        Public Property SubjectSearchString() As SubjectSearchString
            Get
                Return Me.subjectSearchStringField
            End Get
            Set
                Me.subjectSearchStringField = value
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
    Partial Public Class SubjectSearchString
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class QueryActivity
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionsField As Options
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        '''<summary>
        '''This is Parent Options element
        '''</summary>
        Public Property Options() As Options
            Get
                Return Me.optionsField
            End Get
            Set
                Me.optionsField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the Parent Filter element
        '''</summary>
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
                Return "CMSQAT"
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
