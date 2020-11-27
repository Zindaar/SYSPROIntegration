Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipProjectsAndContracts.PCScheduleCreation.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostBillSchedules
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostBillSchedulesItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostBillSchedulesParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostBillSchedulesItem
            End If
        End Sub
        
        Public Property Item() As PostBillSchedulesItem
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
                Return "PRJTSH"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostBillSchedulesParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostBillSchedulesParameters
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
                Dim objParams As Params.PostBillSchedules
                objParams = New Params.PostBillSchedules
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
    Partial Public Class PostBillSchedulesItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billingTypeField As PostBillSchedulesItemBillingType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private schedulePostedField As PostBillSchedulesItemSchedulePosted
        
        Public Sub New()
            MyBase.New
            Me.billingTypeField = PostBillSchedulesItemBillingType.V
            Me.schedulePostedField = PostBillSchedulesItemSchedulePosted.N
        End Sub
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property HierHead() As String
            Get
                Return Me.hierHeadField
            End Get
            Set
                Me.hierHeadField = value
            End Set
        End Property
        
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
        
        Public Property ScheduleDate() As String
            Get
                Return Me.scheduleDateField
            End Get
            Set
                Me.scheduleDateField = value
            End Set
        End Property
        
        Public Property BillingType() As PostBillSchedulesItemBillingType
            Get
                Return Me.billingTypeField
            End Get
            Set
                Me.billingTypeField = value
            End Set
        End Property
        
        Public Property BillPercent() As String
            Get
                Return Me.billPercentField
            End Get
            Set
                Me.billPercentField = value
            End Set
        End Property
        
        Public Property BillValue() As String
            Get
                Return Me.billValueField
            End Get
            Set
                Me.billValueField = value
            End Set
        End Property
        
        Public Property SchedulePosted() As PostBillSchedulesItemSchedulePosted
            Get
                Return Me.schedulePostedField
            End Get
            Set
                Me.schedulePostedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostBillSchedulesItemBillingType
        
        '''<remarks/>
        V
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostBillSchedulesItemSchedulePosted
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
