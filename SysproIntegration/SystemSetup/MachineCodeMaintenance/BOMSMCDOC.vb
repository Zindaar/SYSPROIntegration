Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.MachineCodeMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupBomMachine
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As SetupBomMachineItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupBomMachineParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SetupBomMachineItem
            End If
        End Sub
        
        Public Property Item() As SetupBomMachineItem
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
                Return "BOMSMC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupBomMachineParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupBomMachineParameters
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
                Dim objParams As Params.SetupBomMachine
                objParams = New Params.SetupBomMachine
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
    Partial Public Class SetupBomMachineItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As List(Of SetupBomMachineItemKey)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtdStdHrsEarnedField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shiftIdField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stdHrsPerMonthField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.stdHrsPerMonthField Is Nothing) Then
                Me.stdHrsPerMonthField = New List(Of String)
            End If
            If (Me.shiftIdField Is Nothing) Then
                Me.shiftIdField = New List(Of String)
            End If
            If (Me.workCentreField Is Nothing) Then
                Me.workCentreField = New List(Of String)
            End If
            If (Me.mtdStdHrsEarnedField Is Nothing) Then
                Me.mtdStdHrsEarnedField = New List(Of String)
            End If
            If (Me.descriptionField Is Nothing) Then
                Me.descriptionField = New List(Of String)
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New List(Of SetupBomMachineItemKey)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Key")>  _
        Public Property KeyCollection() As List(Of SetupBomMachineItemKey)
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Description")>  _
        Public Property DescriptionCollection() As List(Of String)
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MtdStdHrsEarned")>  _
        Public Property MtdStdHrsEarnedCollection() As List(Of String)
            Get
                Return Me.mtdStdHrsEarnedField
            End Get
            Set
                Me.mtdStdHrsEarnedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("WorkCentre")>  _
        Public Property WorkCentreCollection() As List(Of String)
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ShiftId")>  _
        Public Property ShiftIdCollection() As List(Of String)
            Get
                Return Me.shiftIdField
            End Get
            Set
                Me.shiftIdField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("StdHrsPerMonth")>  _
        Public Property StdHrsPerMonthCollection() As List(Of String)
            Get
                Return Me.stdHrsPerMonthField
            End Get
            Set
                Me.stdHrsPerMonthField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupBomMachineItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private machineField As String
        
        Public Property Machine() As String
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
    End Class
End Namespace
