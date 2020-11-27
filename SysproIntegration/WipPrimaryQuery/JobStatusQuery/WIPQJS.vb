Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryQuery.JobStatusQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CompletionDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CompletionDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CompletionDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CompletionDateFilterType.A)>  _
        Public Property FilterType() As CompletionDateFilterType
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
    Public Enum CompletionDateFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
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
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DeliveryDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As DeliveryDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = DeliveryDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(DeliveryDateFilterType.A)>  _
        Public Property FilterType() As DeliveryDateFilterType
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
    Public Enum DeliveryDateFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
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
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As Job
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassField As JobClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As Customer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryDateField As DeliveryDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completionDateField As CompletionDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        Public Sub New()
            MyBase.New
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
            If (Me.completionDateField Is Nothing) Then
                Me.completionDateField = New CompletionDate
            End If
            If (Me.deliveryDateField Is Nothing) Then
                Me.deliveryDateField = New DeliveryDate
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New Customer
            End If
            If (Me.jobClassField Is Nothing) Then
                Me.jobClassField = New JobClass
            End If
            If (Me.jobField Is Nothing) Then
                Me.jobField = New Job
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of jobs ( A - All, S - Single, R - Range).  If not provided the default is A.  If R is selected then separated by a -.  Example: 1-9
        '''</summary>
        Public Property Job() As Job
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the job class selection ( A - All, S - Single).  If not provided the default is A.  
        '''</summary>
        Public Property JobClass() As JobClass
            Get
                Return Me.jobClassField
            End Get
            Set
                Me.jobClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the customer selection ( A - All, S - Single).  If not provided the default is A.  
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
        '''This specifies the selection of planned delivery date ( A - All, S - Single, R - Range).  If not provided the default is A.  If R is selected then separated by a -.  Example: 08/26/02-09/26/02
        '''</summary>
        Public Property DeliveryDate() As DeliveryDate
            Get
                Return Me.deliveryDateField
            End Get
            Set
                Me.deliveryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of completion dates ( A - All, S - Single, R - Range).  If not provided the default is A.  If R is selected then separated by a -.  Example: 08/26/02-09/26/02
        '''</summary>
        Public Property CompletionDate() As CompletionDate
            Get
                Return Me.completionDateField
            End Get
            Set
                Me.completionDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the stock code selection ( A - All, R - Range, S - Single).  If not provided the default is A.  
        '''</summary>
        Public Property StockCode() As StockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
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
    Partial Public Class Job
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As JobFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filtervalueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = JobFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(JobFilterType.A)>  _
        Public Property FilterType() As JobFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Filtervalue() As String
            Get
                Return Me.filtervalueField
            End Get
            Set
                Me.filtervalueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum JobFilterType
        
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
    Partial Public Class JobClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As JobClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = JobClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(JobClassFilterType.A)>  _
        Public Property FilterType() As JobClassFilterType
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
    Public Enum JobClassFilterType
        
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
    Partial Public Class StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeJobsCompleted
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeJobsOnHold
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeJobsUnconfirmed
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OnlyCompletedJobsWithWip
        
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobsUnderMasterJobsField As SubJobsUnderMasterJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subJobsUnderMasterJobsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onlyCompletedJobsWithWipField As OnlyCompletedJobsWithWip
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onlyCompletedJobsWithWipFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsOnHoldField As IncludeJobsOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsOnHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsCompletedField As IncludeJobsCompleted
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsCompletedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsUnconfirmedField As IncludeJobsUnconfirmed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsUnconfirmedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.subJobsUnderMasterJobsField = SubJobsUnderMasterJobs.Y
            Me.onlyCompletedJobsWithWipField = OnlyCompletedJobsWithWip.N
            Me.includeJobsOnHoldField = IncludeJobsOnHold.I
            Me.includeJobsCompletedField = IncludeJobsCompleted.I
            Me.includeJobsUnconfirmedField = IncludeJobsUnconfirmed.I
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''This specifies whether to include sub jobs under master jobs( Y - Yes, N - No).  If not provided, the default is Y.
        '''</summary>
        Public Property SubJobsUnderMasterJobs() As SubJobsUnderMasterJobs
            Get
                Return Me.subJobsUnderMasterJobsField
            End Get
            Set
                Me.subJobsUnderMasterJobsField = value
                Me.SubJobsUnderMasterJobsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SubJobsUnderMasterJobsSpecified() As Boolean
            Get
                Return Me.subJobsUnderMasterJobsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include only completed jobs with WIP values ( Y - Yes, N - No).  If not provided, the default is N.
        '''</summary>
        Public Property OnlyCompletedJobsWithWip() As OnlyCompletedJobsWithWip
            Get
                Return Me.onlyCompletedJobsWithWipField
            End Get
            Set
                Me.onlyCompletedJobsWithWipField = value
                Me.OnlyCompletedJobsWithWipFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OnlyCompletedJobsWithWipSpecified() As Boolean
            Get
                Return Me.onlyCompletedJobsWithWipFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include jobs on hold ( I - Include, E - Exclude, O - Only).  If not provided, the default is I.
        '''</summary>
        Public Property IncludeJobsOnHold() As IncludeJobsOnHold
            Get
                Return Me.includeJobsOnHoldField
            End Get
            Set
                Me.includeJobsOnHoldField = value
                Me.IncludeJobsOnHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeJobsOnHoldSpecified() As Boolean
            Get
                Return Me.includeJobsOnHoldFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include completed jobs ( I - Include, E - Exclude, O - Only).  If not provided, the default is I.
        '''</summary>
        Public Property IncludeJobsCompleted() As IncludeJobsCompleted
            Get
                Return Me.includeJobsCompletedField
            End Get
            Set
                Me.includeJobsCompletedField = value
                Me.IncludeJobsCompletedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeJobsCompletedSpecified() As Boolean
            Get
                Return Me.includeJobsCompletedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include unconfirmed jobs ( I - Include, E - Exclude, O - Only).  If not provided, the default is I.
        '''</summary>
        Public Property IncludeJobsUnconfirmed() As IncludeJobsUnconfirmed
            Get
                Return Me.includeJobsUnconfirmedField
            End Get
            Set
                Me.includeJobsUnconfirmedField = value
                Me.IncludeJobsUnconfirmedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeJobsUnconfirmedSpecified() As Boolean
            Get
                Return Me.includeJobsUnconfirmedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied
        '''</summary>
        Public Property XslStylesheet() As XslStylesheet
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SubJobsUnderMasterJobs
        
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
    Partial Public Class XslStylesheet
    End Class
    
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
        
        '''<summary>
        '''The list of options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of filters
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
                Return "WIPQJS"
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
