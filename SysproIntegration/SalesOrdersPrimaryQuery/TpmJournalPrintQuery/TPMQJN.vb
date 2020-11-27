Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.TpmJournalPrintQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalSelectionField As JournalSelection
        
        Public Sub New()
            MyBase.New
            If (Me.journalSelectionField Is Nothing) Then
                Me.journalSelectionField = New JournalSelection()
            End If
        End Sub
        
        '''<summary>
        '''This sequence is used to indicate the journal number selection.The default is A and the other valid options are R and S.
        '''</summary>
        Public Property JournalSelection() As JournalSelection
            Get
                Return Me.journalSelectionField
            End Get
            Set
                Me.journalSelectionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class JournalSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As JournalSelectionFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = JournalSelectionFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(JournalSelectionFilterType.A)>  _
        Public Property FilterType() As JournalSelectionFilterType
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum JournalSelectionFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MonthSelection
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")>  _
        Item01
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")>  _
        Item02
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("03")>  _
        Item03
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")>  _
        Item04
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")>  _
        Item05
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("06")>  _
        Item06
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("07")>  _
        Item07
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("08")>  _
        Item08
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("09")>  _
        Item09
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("10")>  _
        Item10
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")>  _
        Item11
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("12")>  _
        Item12
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("13")>  _
        Item13
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthSelectionField As MonthSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthSelectionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearSelectionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintField As Reprint
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet()
            End If
        End Sub
        
        '''<summary>
        '''This sequence is used to indicate the month for the period selection.
        '''</summary>
        Public Property MonthSelection() As MonthSelection
            Get
                Return Me.monthSelectionField
            End Get
            Set
                Me.monthSelectionField = value
                Me.MonthSelectionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MonthSelectionSpecified() As Boolean
            Get
                Return Me.monthSelectionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This sequence is used to indicate the year for the period selection.
        '''</summary>
        Public Property YearSelection() As String
            Get
                Return Me.yearSelectionField
            End Get
            Set
                Me.yearSelectionField = value
            End Set
        End Property
        
        '''<summary>
        '''This sequence is used to indicate the reprint journal report option.The default is N and the other valid option is Y.
        '''</summary>
        Public Property Reprint() As Reprint
            Get
                Return Me.reprintField
            End Get
            Set
                Me.reprintField = value
                Me.ReprintFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReprintSpecified() As Boolean
            Get
                Return Me.reprintFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the style sheet to be applied.
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Reprint
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class XslStylesheet
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PrintNewPage
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
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
                Me.filterField = New Filter()
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]()
            End If
        End Sub
        
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
                Return "TPMQJN"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
