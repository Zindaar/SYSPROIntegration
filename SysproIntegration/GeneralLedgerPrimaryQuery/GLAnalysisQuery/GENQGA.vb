Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GLAnalysisQuery.QueryData
    
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
        End Sub
        
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
                Return "GENQGA"
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
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionField As QueryOptionSection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sectionCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gLYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gLComparisonYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeField As QueryOptionBudgetType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private budgetTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommitmentField As QueryOptionIncludeCommitment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whereUsedField As QueryOptionWhereUsed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.sectionField = QueryOptionSection.Item0
            Me.includeCommitmentField = QueryOptionIncludeCommitment.N
            Me.whereUsedField = QueryOptionWhereUsed.N
        End Sub
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property Company() As String
            Get
                Return Me.companyField
            End Get
            Set
                Me.companyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionSection.Item0)>  _
        Public Property Section() As QueryOptionSection
            Get
                Return Me.sectionField
            End Get
            Set
                Me.sectionField = value
            End Set
        End Property
        
        Public Property SectionCode() As String
            Get
                Return Me.sectionCodeField
            End Get
            Set
                Me.sectionCodeField = value
            End Set
        End Property
        
        Public Property GLYear() As String
            Get
                Return Me.gLYearField
            End Get
            Set
                Me.gLYearField = value
            End Set
        End Property
        
        Public Property GLComparisonYear() As String
            Get
                Return Me.gLComparisonYearField
            End Get
            Set
                Me.gLComparisonYearField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommitment.N)>  _
        Public Property IncludeCommitment() As QueryOptionIncludeCommitment
            Get
                Return Me.includeCommitmentField
            End Get
            Set
                Me.includeCommitmentField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionWhereUsed.N)>  _
        Public Property WhereUsed() As QueryOptionWhereUsed
            Get
                Return Me.whereUsedField
            End Get
            Set
                Me.whereUsedField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As String
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionSection
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
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
        <System.Xml.Serialization.XmlEnumAttribute("9")>  _
        Item9
    End Enum
    
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
    Public Enum QueryOptionIncludeCommitment
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionWhereUsed
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
