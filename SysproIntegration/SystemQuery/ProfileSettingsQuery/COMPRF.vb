Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ProfileSettingsQuery
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeActivities
        
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
    Public Enum IncludeApBranches
        
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
    Public Enum IncludeArBranches
        
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
    Public Enum IncludeBanks
        
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
    Public Enum IncludeDetails
        
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
    Public Enum IncludeFields
        
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
    Public Enum IncludeJobClassification
        
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
    Public Enum IncludeWarehouses
        
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
        Private includeDetailsField As IncludeDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDetailsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeModulesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private securityField As Security
        
        Public Sub New()
            MyBase.New()

            Me.includeDetailsField = IncludeDetails.Y
            If (Me.securityField Is Nothing) Then
                Me.securityField = New Security
            End If
        End Sub
        
        '''<summary>
        '''Do you wish to include a list of customer and warehouse details for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeDetails() As IncludeDetails
            Get
                Return Me.includeDetailsField
            End Get
            Set
                Me.includeDetailsField = value
                Me.IncludeDetailsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeDetailsSpecified() As Boolean
            Get
                Return Me.includeDetailsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Select the setup option subset(s) that you wish to have returned. Valid options are:
        '''tax         Tax options
        '''ar           Accounts Receivable
        '''ap          Accounts Payable
        '''csh         Cash Book
        '''sor          Sales orders
        '''por          Purchase orders
        '''gen          General ledger
        '''inv          Inventory
        '''wip          Work in Progress
        '''lot          Lot traceability
        '''bom          Bill of materials
        '''qot          Quotations
        '''rma          RMA
        '''dis          Dispatch Notes
        '''io           Inventory Optimization
        '''
        '''The single word ALL will return all setup options for all modules.
        '''</summary>
        Public Property IncludeModules() As String
            Get
                Return Me.includeModulesField
            End Get
            Set
                Me.includeModulesField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of Security Options
        '''</summary>
        Public Property Security() As Security
            Get
                Return Me.securityField
            End Get
            Set
                Me.securityField = value
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
    Partial Public Class Security
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWarehousesField As IncludeWarehouses
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWarehousesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeArBranchesField As IncludeArBranches
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeArBranchesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApBranchesField As IncludeApBranches
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApBranchesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBanksField As IncludeBanks
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBanksFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobClassificationField As IncludeJobClassification
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobClassificationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeActivitiesField As IncludeActivities
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeActivitiesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFieldsField As IncludeFields
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFieldsFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.includeWarehousesField = IncludeWarehouses.Y
            Me.includeArBranchesField = IncludeArBranches.Y
            Me.includeApBranchesField = IncludeApBranches.Y
            Me.includeBanksField = IncludeBanks.Y
            Me.includeJobClassificationField = IncludeJobClassification.Y
            Me.includeActivitiesField = IncludeActivities.Y
            Me.includeFieldsField = IncludeFields.Y
        End Sub
        
        '''<summary>
        '''Do you wish to include the  warehouse security  information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeWarehouses() As IncludeWarehouses
            Get
                Return Me.includeWarehousesField
            End Get
            Set
                Me.includeWarehousesField = value
                Me.IncludeWarehousesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWarehousesSpecified() As Boolean
            Get
                Return Me.includeWarehousesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the  AR Branch security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeArBranches() As IncludeArBranches
            Get
                Return Me.includeArBranchesField
            End Get
            Set
                Me.includeArBranchesField = value
                Me.IncludeArBranchesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeArBranchesSpecified() As Boolean
            Get
                Return Me.includeArBranchesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the  AP Branch security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeApBranches() As IncludeApBranches
            Get
                Return Me.includeApBranchesField
            End Get
            Set
                Me.includeApBranchesField = value
                Me.IncludeApBranchesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeApBranchesSpecified() As Boolean
            Get
                Return Me.includeApBranchesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the Bank security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeBanks() As IncludeBanks
            Get
                Return Me.includeBanksField
            End Get
            Set
                Me.includeBanksField = value
                Me.IncludeBanksFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBanksSpecified() As Boolean
            Get
                Return Me.includeBanksFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the Job Classification security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeJobClassification() As IncludeJobClassification
            Get
                Return Me.includeJobClassificationField
            End Get
            Set
                Me.includeJobClassificationField = value
                Me.IncludeJobClassificationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeJobClassificationSpecified() As Boolean
            Get
                Return Me.includeJobClassificationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the Activities security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeActivities() As IncludeActivities
            Get
                Return Me.includeActivitiesField
            End Get
            Set
                Me.includeActivitiesField = value
                Me.IncludeActivitiesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeActivitiesSpecified() As Boolean
            Get
                Return Me.includeActivitiesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include the Fields security information for the current operator (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeFields() As IncludeFields
            Get
                Return Me.includeFieldsField
            End Get
            Set
                Me.includeFieldsField = value
                Me.IncludeFieldsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeFieldsSpecified() As Boolean
            Get
                Return Me.includeFieldsFieldSpecified
            End Get
        End Property
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


        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private optionField As [Option]

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        '''<summary>
        '''The list of Options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                If Me.optionField Is Nothing Then
                    Me.optionField = New [Option]
                End If
                Return Me.optionField
            End Get
            Set(ByVal value As [Option])
                Me.optionField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "COMPRF"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
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

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _queryActionTypeField As CommonEnums.ActionType_Query = CommonEnums.ActionType_Query.Query
        Public Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                _queryActionTypeField = value
            End Set
        End Property

    End Class
End Namespace
