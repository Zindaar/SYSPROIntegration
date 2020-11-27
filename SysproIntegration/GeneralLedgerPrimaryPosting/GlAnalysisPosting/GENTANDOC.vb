Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.GlAnalysisPosting.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostGlAnalysis
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of PostGlAnalysisItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostGlAnalysisParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostGlAnalysisItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of PostGlAnalysisItem)
            Get
                Return Me.itemField
            End Get
            Set(value As List(Of PostGlAnalysisItem))
                Me.itemField = Value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "GENTAN"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostGlAnalysisParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostGlAnalysisParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostGlAnalysis
                objParams = New Params.PostGlAnalysis
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
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
    Partial Public Class PostGlAnalysisItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private amountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private analysisEntryField As List(Of PostGlAnalysisItemAnalysisEntry)
        
        Public Sub New()
            MyBase.New
            If (Me.analysisEntryField Is Nothing) Then
                Me.analysisEntryField = New List(Of PostGlAnalysisItemAnalysisEntry)
            End If
        End Sub
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        Public Property AnalysisNumber() As String
            Get
                Return Me.analysisNumberField
            End Get
            Set
                Me.analysisNumberField = value
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
        
        Public Property GlPeriod() As String
            Get
                Return Me.glPeriodField
            End Get
            Set
                Me.glPeriodField = value
            End Set
        End Property
        
        Public Property Amount() As String
            Get
                Return Me.amountField
            End Get
            Set
                Me.amountField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("AnalysisEntry")> _
        Public Property AnalysisEntryCollection() As List(Of PostGlAnalysisItemAnalysisEntry)
            Get
                Return Me.analysisEntryField
            End Get
            Set(value As List(Of PostGlAnalysisItemAnalysisEntry))
                Me.analysisEntryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlAnalysisItemAnalysisEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analysisCode5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private entryAmountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set
                Me.analysisCode1Field = value
            End Set
        End Property
        
        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set
                Me.analysisCode2Field = value
            End Set
        End Property
        
        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set
                Me.analysisCode3Field = value
            End Set
        End Property
        
        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set
                Me.analysisCode4Field = value
            End Set
        End Property
        
        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set
                Me.analysisCode5Field = value
            End Set
        End Property
        
        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = value
            End Set
        End Property
        
        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = value
            End Set
        End Property
        
        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set
                Me.entryAmountField = value
            End Set
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
    End Class
End Namespace
