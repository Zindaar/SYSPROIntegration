Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeApproved
        
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
        Private requisitionUserField As String
        
        '''<summary>
        '''The user who is querying requisitions. If the user is not supplied then the user associated with the operator will be assumed. The user must be valid.
        '''</summary>
        Public Property RequisitionUser() As String
            Get
                Return Me.requisitionUserField
            End Get
            Set
                Me.requisitionUserField = value
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
        Private userPasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfRequisitionField As TypeOfRequisition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfRequisitionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApprovedField As IncludeApproved
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApprovedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNotesField As IncludeNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrderCommentsField As IncludePurchaseOrderComments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrderCommentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.typeOfRequisitionField = TypeOfRequisition.O
            Me.includeApprovedField = IncludeApproved.N
            Me.includeNotesField = IncludeNotes.N
            Me.includePurchaseOrderCommentsField = IncludePurchaseOrderComments.N
        End Sub
        
        '''<summary>
        '''The password associated with the user. The password is only required to be supplied if the user element was supplied and it differs from the user associated with the operator default. 
        '''</summary>
        Public Property UserPassword() As String
            Get
                Return Me.userPasswordField
            End Get
            Set
                Me.userPasswordField = value
            End Set
        End Property
        
        '''<summary>
        '''Type of requisition details to be returned (O = all requisitions originated by this user, R = all requisitions routed to this user , S = a single requisition originated by this user, using the values against the RequisitionNumber and RequisitionLine elements, T = a single requisition routed to this user, using the values against the RequisitionNumber and RequisitionLine elements.)
        '''</summary>
        Public Property TypeOfRequisition() As TypeOfRequisition
            Get
                Return Me.typeOfRequisitionField
            End Get
            Set
                Me.typeOfRequisitionField = value
                Me.TypeOfRequisitionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeOfRequisitionSpecified() As Boolean
            Get
                Return Me.typeOfRequisitionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The requisition number of the details to be returned (only used if TypeOfRequisition = S or T)
        '''</summary>
        Public Property RequisitionNumber() As String
            Get
                Return Me.requisitionNumberField
            End Get
            Set
                Me.requisitionNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The requisition line number of the details to be returned (only used if TypeOfRequisition = S or T). If the line number is not supplied then all lines for the specified requisition will be returned.
        '''</summary>
        Public Property RequisitionLine() As String
            Get
                Return Me.requisitionLineField
            End Get
            Set
                Me.requisitionLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include approved requisitions ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeApproved() As IncludeApproved
            Get
                Return Me.includeApprovedField
            End Get
            Set
                Me.includeApprovedField = value
                Me.IncludeApprovedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeApprovedSpecified() As Boolean
            Get
                Return Me.includeApprovedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include requisition notes ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeNotes() As IncludeNotes
            Get
                Return Me.includeNotesField
            End Get
            Set
                Me.includeNotesField = value
                Me.IncludeNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeNotesSpecified() As Boolean
            Get
                Return Me.includeNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include comments for purchase order ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludePurchaseOrderComments() As IncludePurchaseOrderComments
            Get
                Return Me.includePurchaseOrderCommentsField
            End Get
            Set
                Me.includePurchaseOrderCommentsField = value
                Me.IncludePurchaseOrderCommentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludePurchaseOrderCommentsSpecified() As Boolean
            Get
                Return Me.includePurchaseOrderCommentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to use
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TypeOfRequisition
        
        '''<remarks/>
        O
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
        '''<remarks/>
        T
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeNotes
        
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
    Public Enum IncludePurchaseOrderComments
        
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
        '''The key to use for this query.
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
                Return "PORQRQ"
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
