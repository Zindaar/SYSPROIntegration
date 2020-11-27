Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.InventoryApprovedManufactureMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupManufacturer
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As SetupManufacturerItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SetupManufacturerItem
            End If
        End Sub
        
        Public Property Item() As SetupManufacturerItem
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
                Return "INVSMC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
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
                Dim objParams As Params.SetupManufacturer
                objParams = New Params.SetupManufacturer
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
    Partial Public Class SetupManufacturerItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupManufacturerItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufacturerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufacturerInfo1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufacturerInfo2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufacturerInfo3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufacturerInfo4Field As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupManufacturerItemKey
            End If
        End Sub
        
        Public Property Key() As SetupManufacturerItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property ManufacturerName() As String
            Get
                Return Me.manufacturerNameField
            End Get
            Set
                Me.manufacturerNameField = value
            End Set
        End Property
        
        Public Property ManufacturerInfo1() As String
            Get
                Return Me.manufacturerInfo1Field
            End Get
            Set
                Me.manufacturerInfo1Field = value
            End Set
        End Property
        
        Public Property ManufacturerInfo2() As String
            Get
                Return Me.manufacturerInfo2Field
            End Get
            Set
                Me.manufacturerInfo2Field = value
            End Set
        End Property
        
        Public Property ManufacturerInfo3() As String
            Get
                Return Me.manufacturerInfo3Field
            End Get
            Set
                Me.manufacturerInfo3Field = value
            End Set
        End Property
        
        Public Property ManufacturerInfo4() As String
            Get
                Return Me.manufacturerInfo4Field
            End Get
            Set
                Me.manufacturerInfo4Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupManufacturerItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private appManufacturerField As String
        
        Public Property AppManufacturer() As String
            Get
                Return Me.appManufacturerField
            End Get
            Set
                Me.appManufacturerField = value
            End Set
        End Property
    End Class
End Namespace
