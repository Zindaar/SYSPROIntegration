Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace LotTraceability.LotTraceabilityQuery.QueryData
    
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
                Return "LOTQRY"
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
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotJobField As String
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property LotJob() As String
            Get
                Return Me.lotJobField
            End Get
            Set
                Me.lotJobField = value
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
        Private multiMediaImageTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroQtyLotsField As QueryOptionIncludeZeroQtyLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeTransactionsField As QueryOptionIncludeTransactions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInspectionGoodsField As QueryOptionIncludeInspectionGoods
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWipInspectionGoodsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As QueryOptionXslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.includeZeroQtyLotsField = QueryOptionIncludeZeroQtyLots.N
            Me.includeTransactionsField = QueryOptionIncludeTransactions.N
            Me.includeInspectionGoodsField = QueryOptionIncludeInspectionGoods.N
            Me.includeWipInspectionGoodsField = "N"
            Me.includeCustomFormsField = "N"
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New QueryOptionXslStylesheet
            End If
        End Sub
        
        Public Property MultiMediaImageType() As String
            Get
                Return Me.multiMediaImageTypeField
            End Get
            Set
                Me.multiMediaImageTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeZeroQtyLots.N)>  _
        Public Property IncludeZeroQtyLots() As QueryOptionIncludeZeroQtyLots
            Get
                Return Me.includeZeroQtyLotsField
            End Get
            Set
                Me.includeZeroQtyLotsField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeInspectionGoods.N)>  _
        Public Property IncludeInspectionGoods() As QueryOptionIncludeInspectionGoods
            Get
                Return Me.includeInspectionGoodsField
            End Get
            Set
                Me.includeInspectionGoodsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("N")>  _
        Public Property IncludeWipInspectionGoods() As String
            Get
                Return Me.includeWipInspectionGoodsField
            End Get
            Set
                Me.includeWipInspectionGoodsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute("N")>  _
        Public Property IncludeCustomForms() As String
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As QueryOptionXslStylesheet
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
    Public Enum QueryOptionIncludeZeroQtyLots
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeInspectionGoods
        
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
    Partial Public Class QueryOptionXslStylesheet
    End Class
End Namespace
