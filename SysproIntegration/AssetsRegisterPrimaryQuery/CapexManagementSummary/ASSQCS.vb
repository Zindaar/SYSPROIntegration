Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryQuery.CapexManagementSummary.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class AssetCostCenter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As AssetCostCenterFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = AssetCostCenterFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(AssetCostCenterFilterType.A)>  _
        Public Property FilterType() As AssetCostCenterFilterType
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
    Public Enum AssetCostCenterFilterType
        
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
    Partial Public Class AssetGroupCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As AssetGroupCodeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = AssetGroupCodeFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(AssetGroupCodeFilterType.A)>  _
        Public Property FilterType() As AssetGroupCodeFilterType
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
    Public Enum AssetGroupCodeFilterType
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class CapexClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CapexClassFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CapexClassFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CapexClassFilterType.A)>  _
        Public Property FilterType() As CapexClassFilterType
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
    Public Enum CapexClassFilterType
        
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
    Partial Public Class CapexItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As CapexItemFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = CapexItemFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(CapexItemFilterType.A)>  _
        Public Property FilterType() As CapexItemFilterType
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
    Public Enum CapexItemFilterType
        
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
        Private capexItemField As CapexItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As Branch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetGroupCodeField As AssetGroupCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostCenterField As AssetCostCenter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexClassField As CapexClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearField As Year
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodField As Period
        
        Public Sub New()
            MyBase.New
            If (Me.periodField Is Nothing) Then
                Me.periodField = New Period
            End If
            If (Me.yearField Is Nothing) Then
                Me.yearField = New Year
            End If
            If (Me.capexClassField Is Nothing) Then
                Me.capexClassField = New CapexClass
            End If
            If (Me.assetCostCenterField Is Nothing) Then
                Me.assetCostCenterField = New AssetCostCenter
            End If
            If (Me.assetGroupCodeField Is Nothing) Then
                Me.assetGroupCodeField = New AssetGroupCode
            End If
            If (Me.branchField Is Nothing) Then
                Me.branchField = New Branch
            End If
            If (Me.capexItemField Is Nothing) Then
                Me.capexItemField = New CapexItem
            End If
        End Sub
        
        '''<summary>
        '''All,  Single, Range of capex items to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property CapexItem() As CapexItem
            Get
                Return Me.capexItemField
            End Get
            Set
                Me.capexItemField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of asset branches to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
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
        '''All,  Single, Range of asset groups to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property AssetGroupCode() As AssetGroupCode
            Get
                Return Me.assetGroupCodeField
            End Get
            Set
                Me.assetGroupCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of cost centers to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property AssetCostCenter() As AssetCostCenter
            Get
                Return Me.assetCostCenterField
            End Get
            Set
                Me.assetCostCenterField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of capex classifications to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All).
        '''</summary>
        Public Property CapexClass() As CapexClass
            Get
                Return Me.capexClassField
            End Get
            Set
                Me.capexClassField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of capex line start years to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All). It is important to note that this year will be combined with the period selection to form a period number to select
        '''</summary>
        Public Property Year() As Year
            Get
                Return Me.yearField
            End Get
            Set
                Me.yearField = value
            End Set
        End Property
        
        '''<summary>
        '''All,  Single, Range of capex line start periods to be returned.  FilterType options - A(All), (S)Single, (R)Range. Default to A(All). It is important to note that this period number will be combined with the year selection to form a period number to select
        '''</summary>
        Public Property Period() As Period
            Get
                Return Me.periodField
            End Get
            Set
                Me.periodField = value
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
    Partial Public Class Year
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As YearFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = YearFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(YearFilterType.A)>  _
        Public Property FilterType() As YearFilterType
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
    Public Enum YearFilterType
        
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
    Partial Public Class Period
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As PeriodFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = PeriodFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(PeriodFilterType.A)>  _
        Public Property FilterType() As PeriodFilterType
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
    Public Enum PeriodFilterType
        
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
    Public Enum IncludeClosed
        
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
    Public Enum IncludeDenied
        
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
        Private reportSequenceField As ReportSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeClosedField As IncludeClosed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDeniedField As IncludeDenied
        
        '''<summary>
        '''Defines the sequence in which the report will be printed. (C - Capex item, B - Branch,G - Group, O - Branch/Cost center, L - Classification). If no value is supplied a default of 'C' will be used. If a value of  'B' is passed there will be totalling by branch. If a value of "G" is passed, there will be totalling by group.If a value of "O" is passed, there will be totalling by both branch and cost center. If a value of "L" is passed, there will be totalling by classification.
        '''</summary>
        Public Property ReportSequence() As ReportSequence
            Get
                Return Me.reportSequenceField
            End Get
            Set
                Me.reportSequenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether to include capex items with an approval status of "Closed". (Y - yes and N - No). If no value is supplied then a default value of 'Y' will be used. 
        '''</summary>
        Public Property IncludeClosed() As IncludeClosed
            Get
                Return Me.includeClosedField
            End Get
            Set
                Me.includeClosedField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether to include capex items with an approval status of "Denied". (Y - yes and N - No). If no value is supplied then a default value of 'Y' will be used. 
        '''</summary>
        Public Property IncludeDenied() As IncludeDenied
            Get
                Return Me.includeDeniedField
            End Get
            Set
                Me.includeDeniedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReportSequence
        
        '''<remarks/>
        C
        
        '''<remarks/>
        B
        
        '''<remarks/>
        G
        
        '''<remarks/>
        O
        
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
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New Filter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
        End Sub
        
        '''<summary>
        '''The parent option element
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
        '''The parent filter element
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
                Return "ASSQCS"
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
