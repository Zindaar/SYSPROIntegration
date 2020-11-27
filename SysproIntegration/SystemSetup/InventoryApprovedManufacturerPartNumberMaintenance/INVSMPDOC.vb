Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.InventoryApprovedManufacturerPartNumberMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupManufPartNo
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As SetupManufPartNoItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupManufPartNoParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SetupManufPartNoItem
            End If
        End Sub
        
        Public Property Item() As SetupManufPartNoItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set
                Me._setupActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "INVSMP"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupManufPartNoParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupManufPartNoParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.XmlParam
            Get
                Dim objParams As Params.SetupManufPartNo
                objParams = New Params.SetupManufPartNo
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ISetup.Post
            If (Me._setupActionTypeField = 0) Then
                Me._xmlOut = SetupObject.Add(Me)
                Return
            End If
            If (Me._setupActionTypeField = 1) Then
                Me._xmlOut = SetupObject.Update(Me)
                Return
            End If
            If (Me._setupActionTypeField = 2) Then
                Me._xmlOut = SetupObject.Delete(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XMLParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupManufPartNoItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo3Field As SetupManufPartNoItemManPartInfo3
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo4Field As SetupManufPartNoItemManPartInfo4
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo5Field As SetupManufPartNoItemManPartInfo5
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartInfo6Field As SetupManufPartNoItemManPartInfo6
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preferredFlagField As SetupManufPartNoItemPreferredFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusField As SetupManufPartNoItemStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revisionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private effectiveDateField As Date
        
        Public Sub New()
            MyBase.New
            Me.preferredFlagField = SetupManufPartNoItemPreferredFlag.Y
            If (Me.manPartInfo6Field Is Nothing) Then
                Me.manPartInfo6Field = New SetupManufPartNoItemManPartInfo6
            End If
            If (Me.manPartInfo5Field Is Nothing) Then
                Me.manPartInfo5Field = New SetupManufPartNoItemManPartInfo5
            End If
            If (Me.manPartInfo4Field Is Nothing) Then
                Me.manPartInfo4Field = New SetupManufPartNoItemManPartInfo4
            End If
            If (Me.manPartInfo3Field Is Nothing) Then
                Me.manPartInfo3Field = New SetupManufPartNoItemManPartInfo3
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupManufPartNoItemKey
            End If
        End Sub
        
        Public Property Key() As SetupManufPartNoItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property ManPartInfo1() As String
            Get
                Return Me.manPartInfo1Field
            End Get
            Set
                Me.manPartInfo1Field = value
            End Set
        End Property
        
        Public Property ManPartInfo2() As String
            Get
                Return Me.manPartInfo2Field
            End Get
            Set
                Me.manPartInfo2Field = value
            End Set
        End Property
        
        Public Property ManPartInfo3() As SetupManufPartNoItemManPartInfo3
            Get
                Return Me.manPartInfo3Field
            End Get
            Set
                Me.manPartInfo3Field = value
            End Set
        End Property
        
        Public Property ManPartInfo4() As SetupManufPartNoItemManPartInfo4
            Get
                Return Me.manPartInfo4Field
            End Get
            Set
                Me.manPartInfo4Field = value
            End Set
        End Property
        
        Public Property ManPartInfo5() As SetupManufPartNoItemManPartInfo5
            Get
                Return Me.manPartInfo5Field
            End Get
            Set
                Me.manPartInfo5Field = value
            End Set
        End Property
        
        Public Property ManPartInfo6() As SetupManufPartNoItemManPartInfo6
            Get
                Return Me.manPartInfo6Field
            End Get
            Set
                Me.manPartInfo6Field = value
            End Set
        End Property
        
        Public Property PreferredFlag() As SetupManufPartNoItemPreferredFlag
            Get
                Return Me.preferredFlagField
            End Get
            Set
                Me.preferredFlagField = value
            End Set
        End Property
        
        Public Property Status() As SetupManufPartNoItemStatus
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
            End Set
        End Property
        
        Public Property RevisionNumber() As String
            Get
                Return Me.revisionNumberField
            End Get
            Set
                Me.revisionNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property EffectiveDate() As Date
            Get
                Return Me.effectiveDateField
            End Get
            Set
                Me.effectiveDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As List(Of Byte)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private appManufacturerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartNumberField As String
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property StockCodeCollection() As List(Of Byte)
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property AppManufacturer() As String
            Get
                Return Me.appManufacturerField
            End Get
            Set
                Me.appManufacturerField = value
            End Set
        End Property
        
        Public Property ManPartNumber() As String
            Get
                Return Me.manPartNumberField
            End Get
            Set
                Me.manPartNumberField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItemManPartInfo3
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItemManPartInfo4
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItemManPartInfo5
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufPartNoItemManPartInfo6
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupManufPartNoItemPreferredFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupManufPartNoItemStatus
        
        '''<remarks/>
        I
        
        '''<remarks/>
        A
    End Enum
End Namespace
