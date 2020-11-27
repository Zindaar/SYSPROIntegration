Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderSupplierContracts.PurchaseOrderSupplierContract.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostScheduleInformation
        Implements Tallbridge.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostScheduleInformationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostScheduleInformationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostScheduleInformationItem
            End If
        End Sub
        
        Public Property Item() As PostScheduleInformationItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "PRETSH"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostScheduleInformationParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostScheduleInformationParameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostScheduleInformation
                objParams = New Params.PostScheduleInformation
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
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
    Partial Public Class PostScheduleInformationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCalcMethodField As PostScheduleInformationItemDateCalcMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleFlagField As PostScheduleInformationItemScheduleFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priorityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleStartTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleEndDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleEndTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As List(Of PostScheduleInformationItemOperation)
        
        Public Sub New()
            MyBase.New
            Me.dateCalcMethodField = PostScheduleInformationItemDateCalcMethod.M
            If (Me.operationField Is Nothing) Then
                Me.operationField = New List(Of PostScheduleInformationItemOperation)
            End If
        End Sub
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostScheduleInformationItemDateCalcMethod.M)>  _
        Public Property DateCalcMethod() As PostScheduleInformationItemDateCalcMethod
            Get
                Return Me.dateCalcMethodField
            End Get
            Set
                Me.dateCalcMethodField = value
            End Set
        End Property
        
        Public Property ScheduleFlag() As PostScheduleInformationItemScheduleFlag
            Get
                Return Me.scheduleFlagField
            End Get
            Set
                Me.scheduleFlagField = value
            End Set
        End Property
        
        Public Property Priority() As String
            Get
                Return Me.priorityField
            End Get
            Set
                Me.priorityField = value
            End Set
        End Property
        
        Public Property ScheduleStartDate() As String
            Get
                Return Me.scheduleStartDateField
            End Get
            Set
                Me.scheduleStartDateField = value
            End Set
        End Property
        
        Public Property ScheduleStartTime() As String
            Get
                Return Me.scheduleStartTimeField
            End Get
            Set
                Me.scheduleStartTimeField = value
            End Set
        End Property
        
        Public Property ScheduleEndDate() As String
            Get
                Return Me.scheduleEndDateField
            End Get
            Set
                Me.scheduleEndDateField = value
            End Set
        End Property
        
        Public Property ScheduleEndTime() As String
            Get
                Return Me.scheduleEndTimeField
            End Get
            Set
                Me.scheduleEndTimeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Operation")>  _
        Public Property OperationCollection() As List(Of PostScheduleInformationItemOperation)
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostScheduleInformationItemDateCalcMethod
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostScheduleInformationItemScheduleFlag
        
        '''<remarks/>
        U
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostScheduleInformationItemOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationStatusField As PostScheduleInformationItemOperationOperationStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private machineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationStartTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationEndDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationEndTimeField As String
        
        Public Sub New()
            MyBase.New
            Me.operationStatusField = PostScheduleInformationItemOperationOperationStatus.S
        End Sub
        
        Public Property OperationNumber() As String
            Get
                Return Me.operationNumberField
            End Get
            Set
                Me.operationNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostScheduleInformationItemOperationOperationStatus.S)>  _
        Public Property OperationStatus() As PostScheduleInformationItemOperationOperationStatus
            Get
                Return Me.operationStatusField
            End Get
            Set
                Me.operationStatusField = value
            End Set
        End Property
        
        Public Property Machine() As String
            Get
                Return Me.machineField
            End Get
            Set
                Me.machineField = value
            End Set
        End Property
        
        Public Property OperationStartDate() As String
            Get
                Return Me.operationStartDateField
            End Get
            Set
                Me.operationStartDateField = value
            End Set
        End Property
        
        Public Property OperationStartTime() As String
            Get
                Return Me.operationStartTimeField
            End Get
            Set
                Me.operationStartTimeField = value
            End Set
        End Property
        
        Public Property OperationEndDate() As String
            Get
                Return Me.operationEndDateField
            End Get
            Set
                Me.operationEndDateField = value
            End Set
        End Property
        
        Public Property OperationEndTime() As String
            Get
                Return Me.operationEndTimeField
            End Get
            Set
                Me.operationEndTimeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostScheduleInformationItemOperationOperationStatus
        
        '''<remarks/>
        S
        
        '''<remarks/>
        R
        
        '''<remarks/>
        H
        
        '''<remarks/>
        L
    End Enum
End Namespace
