Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryQuery.PurchaseOrderQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCommentLines
        
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
    Public Enum IncludeCompletedLines
        
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
    Public Enum IncludeFreightLines
        
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
    Public Enum IncludeGrns
        
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
    Public Enum IncludeHistory
        
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
    Public Enum IncludeLctDetails
        
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
    Public Enum IncludeMiscellaneousLines
        
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
    Public Enum IncludeNonStockedLines
        
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
    Public Enum IncludeRequisitionDetails
        
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
    Public Enum IncludeRequisitionRouting
        
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
    Public Enum IncludeSalesOrders
        
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
    Public Enum IncludeStockedLines
        
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
    Public Enum IncludeCustomForms
        
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderField As String
        
        '''<summary>
        '''Enter the purchase order(key) on file. If the key (purchase order) is empty or if the purchase order is not valid. - error message will show.
        '''
        '''</summary>
        Public Property PurchaseOrder() As String
            Get
                Return Me.purchaseOrderField
            End Get
            Set
                Me.purchaseOrderField = value
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockedLinesField As IncludeStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedLinesField As IncludeNonStockedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFreightLinesField As IncludeFreightLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFreightLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMiscellaneousLinesField As IncludeMiscellaneousLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMiscellaneousLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommentLinesField As IncludeCommentLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommentLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedLinesField As IncludeCompletedLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGrnsField As IncludeGrns
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGrnsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeHistoryField As IncludeHistory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeHistoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLctDetailsField As IncludeLctDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLctDetailsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRequisitionDetailsField As IncludeRequisitionDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRequisitionDetailsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRequisitionRoutingField As IncludeRequisitionRouting
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRequisitionRoutingFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrdersField As IncludeSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As IncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeStockedLinesField = IncludeStockedLines.Y
            Me.includeNonStockedLinesField = IncludeNonStockedLines.Y
            Me.includeFreightLinesField = IncludeFreightLines.Y
            Me.includeMiscellaneousLinesField = IncludeMiscellaneousLines.Y
            Me.includeCommentLinesField = IncludeCommentLines.Y
            Me.includeCompletedLinesField = IncludeCompletedLines.Y
            Me.includeGrnsField = IncludeGrns.Y
            Me.includeHistoryField = IncludeHistory.Y
            Me.includeLctDetailsField = IncludeLctDetails.N
            Me.includeRequisitionDetailsField = IncludeRequisitionDetails.N
            Me.includeRequisitionRoutingField = IncludeRequisitionRouting.N
            Me.includeSalesOrdersField = IncludeSalesOrders.N
            Me.includeCustomFormsField = IncludeCustomForms.N
        End Sub
        
        '''<summary>
        '''This element gives an option to include stocked lines attached to the purchase order. Input Y/N . If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeStockedLines() As IncludeStockedLines
            Get
                Return Me.includeStockedLinesField
            End Get
            Set
                Me.includeStockedLinesField = value
                Me.IncludeStockedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeStockedLinesSpecified() As Boolean
            Get
                Return Me.includeStockedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include non-stocked lines attached to  the purchase order. Input Y/N , if anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeNonStockedLines() As IncludeNonStockedLines
            Get
                Return Me.includeNonStockedLinesField
            End Get
            Set
                Me.includeNonStockedLinesField = value
                Me.IncludeNonStockedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeNonStockedLinesSpecified() As Boolean
            Get
                Return Me.includeNonStockedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include freight lines attached to the purchase order. Input Y/N . If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeFreightLines() As IncludeFreightLines
            Get
                Return Me.includeFreightLinesField
            End Get
            Set
                Me.includeFreightLinesField = value
                Me.IncludeFreightLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeFreightLinesSpecified() As Boolean
            Get
                Return Me.includeFreightLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include Miscellaneous lines against the purchase order. Input Y/N . If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeMiscellaneousLines() As IncludeMiscellaneousLines
            Get
                Return Me.includeMiscellaneousLinesField
            End Get
            Set
                Me.includeMiscellaneousLinesField = value
                Me.IncludeMiscellaneousLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMiscellaneousLinesSpecified() As Boolean
            Get
                Return Me.includeMiscellaneousLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include comment lines attached to the purchase order. Input Y/N. If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeCommentLines() As IncludeCommentLines
            Get
                Return Me.includeCommentLinesField
            End Get
            Set
                Me.includeCommentLinesField = value
                Me.IncludeCommentLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCommentLinesSpecified() As Boolean
            Get
                Return Me.includeCommentLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include completed lines attached to the purchase order. Input Y/N.  If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeCompletedLines() As IncludeCompletedLines
            Get
                Return Me.includeCompletedLinesField
            End Get
            Set
                Me.includeCompletedLinesField = value
                Me.IncludeCompletedLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCompletedLinesSpecified() As Boolean
            Get
                Return Me.includeCompletedLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include Grn's attached to the purchase order. Input Y/N. If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeGrns() As IncludeGrns
            Get
                Return Me.includeGrnsField
            End Get
            Set
                Me.includeGrnsField = value
                Me.IncludeGrnsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeGrnsSpecified() As Boolean
            Get
                Return Me.includeGrnsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include history attached to the purchase order.Input Y/N. If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeHistory() As IncludeHistory
            Get
                Return Me.includeHistoryField
            End Get
            Set
                Me.includeHistoryField = value
                Me.IncludeHistoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeHistorySpecified() As Boolean
            Get
                Return Me.includeHistoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include Lct record attached to the purchase order. Input Y/N. If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeLctDetails() As IncludeLctDetails
            Get
                Return Me.includeLctDetailsField
            End Get
            Set
                Me.includeLctDetailsField = value
                Me.IncludeLctDetailsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeLctDetailsSpecified() As Boolean
            Get
                Return Me.includeLctDetailsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include requisition details for the purchase order. This option will be effective if requisition module is installed. Input Y/N , if anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeRequisitionDetails() As IncludeRequisitionDetails
            Get
                Return Me.includeRequisitionDetailsField
            End Get
            Set
                Me.includeRequisitionDetailsField = value
                Me.IncludeRequisitionDetailsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeRequisitionDetailsSpecified() As Boolean
            Get
                Return Me.includeRequisitionDetailsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include requisition routing details. This option will be effective if requisitions are included. Input Y/N , if anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeRequisitionRouting() As IncludeRequisitionRouting
            Get
                Return Me.includeRequisitionRoutingField
            End Get
            Set
                Me.includeRequisitionRoutingField = value
                Me.IncludeRequisitionRoutingFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeRequisitionRoutingSpecified() As Boolean
            Get
                Return Me.includeRequisitionRoutingFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element gives an option to include sales orders details created against the purchase order.  Input Y/N , if anything else is entered, an error message will be returned.
        '''</summary>
        Public Property IncludeSalesOrders() As IncludeSalesOrders
            Get
                Return Me.includeSalesOrdersField
            End Get
            Set
                Me.includeSalesOrdersField = value
                Me.IncludeSalesOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeSalesOrdersSpecified() As Boolean
            Get
                Return Me.includeSalesOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include fields from custom forms ? (N - No, Y - Yes,). Default is N - No.
        '''</summary>
        Public Property IncludeCustomForms() As IncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
                Me.IncludeCustomFormsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCustomFormsSpecified() As Boolean
            Get
                Return Me.includeCustomFormsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the name of the xsd Stylesheet to use
        '''</summary>
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''The list of keys 
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
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
                Return "PORQRY"
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
