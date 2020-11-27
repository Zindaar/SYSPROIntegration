Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.BasicGLQuery.QueryData
    
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
        Private keyField As QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New QueryKey
            End If
        End Sub
        
        Public Property Key() As QueryKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
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
                Return "GENQRY"
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodePasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeField As QueryOptionBudgetType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addSeparatorsField As QueryOptionAddSeparators
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As QueryOptionIncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeTransactionsField As QueryOptionIncludeTransactions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionsField As QueryOptionTransactions
        
        Public Sub New()
            MyBase.New
            Me.addSeparatorsField = QueryOptionAddSeparators.N
            Me.includeCustomFormsField = QueryOptionIncludeCustomForms.N
            Me.includeTransactionsField = QueryOptionIncludeTransactions.N
            If (Me.transactionsField Is Nothing) Then
                Me.transactionsField = New QueryOptionTransactions
            End If
        End Sub
        
        Public Property LedgerCodePassword() As String
            Get
                Return Me.ledgerCodePasswordField
            End Get
            Set
                Me.ledgerCodePasswordField = value
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
        
        Public Property BudgetType() As QueryOptionBudgetType
            Get
                Return Me.budgetTypeField
            End Get
            Set
                Me.budgetTypeField = value
                Me.BudgetTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BudgetTypeSpecified() As Boolean
            Get
                Return Me.budgetTypeFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionAddSeparators.N)>  _
        Public Property AddSeparators() As QueryOptionAddSeparators
            Get
                Return Me.addSeparatorsField
            End Get
            Set
                Me.addSeparatorsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomForms.N)>  _
        Public Property IncludeCustomForms() As QueryOptionIncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeTransactions.N)>  _
        Public Property IncludeTransactions() As QueryOptionIncludeTransactions
            Get
                Return Me.includeTransactionsField
            End Get
            Set
                Me.includeTransactionsField = value
            End Set
        End Property
        
        Public Property Transactions() As QueryOptionTransactions
            Get
                Return Me.transactionsField
            End Get
            Set
                Me.transactionsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionBudgetType
        
        '''<remarks/>
        C
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")>  _
        Item5
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")>  _
        Item6
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionAddSeparators
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCustomForms
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeTransactions
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionTransactions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxRowsToReturnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceCodeField As QueryOptionTransactionsSourceCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceCodeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startAtKeyField As QueryOptionTransactionsStartAtKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private directionField As QueryOptionTransactionsDirection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private directionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As QueryOptionTransactionsFilter
        
        Public Sub New()
            MyBase.New
            Me.maxRowsToReturnField = "100"
            If (Me.filterField Is Nothing) Then
                Me.filterField = New QueryOptionTransactionsFilter
            End If
            If (Me.startAtKeyField Is Nothing) Then
                Me.startAtKeyField = New QueryOptionTransactionsStartAtKey
            End If
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute("100")>  _
        Public Property MaxRowsToReturn() As String
            Get
                Return Me.maxRowsToReturnField
            End Get
            Set
                Me.maxRowsToReturnField = value
            End Set
        End Property
        
        Public Property SourceCode() As QueryOptionTransactionsSourceCode
            Get
                Return Me.sourceCodeField
            End Get
            Set
                Me.sourceCodeField = value
                Me.SourceCodeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SourceCodeSpecified() As Boolean
            Get
                Return Me.sourceCodeFieldSpecified
            End Get
        End Property
        
        Public Property StartAtKey() As QueryOptionTransactionsStartAtKey
            Get
                Return Me.startAtKeyField
            End Get
            Set
                Me.startAtKeyField = value
            End Set
        End Property
        
        Public Property Direction() As QueryOptionTransactionsDirection
            Get
                Return Me.directionField
            End Get
            Set
                Me.directionField = value
                Me.DirectionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DirectionSpecified() As Boolean
            Get
                Return Me.directionFieldSpecified
            End Get
        End Property
        
        Public Property Filter() As QueryOptionTransactionsFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionTransactionsSourceCode
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        AP
        
        '''<remarks/>
        AR
        
        '''<remarks/>
        SA
        
        '''<remarks/>
        CS
        
        '''<remarks/>
        [IN]
        
        '''<remarks/>
        GR
        
        '''<remarks/>
        [AS]
        
        '''<remarks/>
        PA
        
        '''<remarks/>
        WP
        
        '''<remarks/>
        JE
        
        '''<remarks/>
        PV
        
        '''<remarks/>
        RV
        
        '''<remarks/>
        IC
        
        '''<remarks/>
        PE
        
        '''<remarks/>
        AV
        
        '''<remarks/>
        YE
        
        '''<remarks/>
        HM
        
        '''<remarks/>
        ST
        
        '''<remarks/>
        AC
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionTransactionsStartAtKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        Public Sub New()
            MyBase.New
            Me.periodField = "0"
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute("0")>  _
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionTransactionsDirection
        
        '''<remarks/>
        pagedown
        
        '''<remarks/>
        pageup
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionTransactionsFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private selectPeriodsField As QueryOptionTransactionsFilterSelectPeriods
        
        Public Property SelectPeriods() As QueryOptionTransactionsFilterSelectPeriods
            Get
                Return Me.selectPeriodsField
            End Get
            Set
                Me.selectPeriodsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOptionTransactionsFilterSelectPeriods
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueField As String
        
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
        
        <System.Xml.Serialization.XmlTextAttribute()>  _
        Public Property Value() As String
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
End Namespace
