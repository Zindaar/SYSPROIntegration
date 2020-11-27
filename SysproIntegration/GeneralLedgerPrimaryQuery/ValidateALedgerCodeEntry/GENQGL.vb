Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.ValidateALedgerCodeEntry.QueryData
    
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
        Private xslStylesheetField As Object
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New QueryKey
            End If
        End Sub
        
        Public Property key() As QueryKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As Object
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
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
                Return "GENQGL"
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
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private securityTypeField As QueryKeySecurityType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateStructureField As QueryKeyValidateStructure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateFlagsField As QueryKeyValidateFlags
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private businessProcessField As String
        
        Public Sub New()
            MyBase.New
            Me.securityTypeField = QueryKeySecurityType.P
            Me.validateStructureField = QueryKeyValidateStructure.Y
            Me.validateFlagsField = QueryKeyValidateFlags.Y
        End Sub
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(QueryKeySecurityType.P)>  _
        Public Property SecurityType() As QueryKeySecurityType
            Get
                Return Me.securityTypeField
            End Get
            Set
                Me.securityTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryKeyValidateStructure.Y)>  _
        Public Property ValidateStructure() As QueryKeyValidateStructure
            Get
                Return Me.validateStructureField
            End Get
            Set
                Me.validateStructureField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryKeyValidateFlags.Y)>  _
        Public Property ValidateFlags() As QueryKeyValidateFlags
            Get
                Return Me.validateFlagsField
            End Get
            Set
                Me.validateFlagsField = value
            End Set
        End Property
        
        Public Property BusinessProcess() As String
            Get
                Return Me.businessProcessField
            End Get
            Set
                Me.businessProcessField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryKeySecurityType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryKeyValidateStructure
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryKeyValidateFlags
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
