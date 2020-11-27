Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.InventorySuppliersForTheApprovedManufacturerPartNumberMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Setupinvmanfsup
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As SetupinvmanfsupItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupinvmanfsupParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SetupinvmanfsupItem
            End If
        End Sub
        
        Public Property Item() As SetupinvmanfsupItem
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
                Return "INVSMS"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupinvmanfsupParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupinvmanfsupParameters
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
                Dim objParams As Params.Setupinvmanfsup
                objParams = New Params.Setupinvmanfsup
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
    Partial Public Class SetupinvmanfsupItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupinvmanfsupItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierInfo6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private preferredFlagField As SetupinvmanfsupItemPreferredFlag
        
        Public Sub New()
            MyBase.New
            Me.preferredFlagField = SetupinvmanfsupItemPreferredFlag.Y
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupinvmanfsupItemKey
            End If
        End Sub
        
        Public Property Key() As SetupinvmanfsupItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property SupplierInfo1() As String
            Get
                Return Me.supplierInfo1Field
            End Get
            Set
                Me.supplierInfo1Field = value
            End Set
        End Property
        
        Public Property SupplierInfo2() As String
            Get
                Return Me.supplierInfo2Field
            End Get
            Set
                Me.supplierInfo2Field = value
            End Set
        End Property
        
        Public Property SupplierInfo3() As String
            Get
                Return Me.supplierInfo3Field
            End Get
            Set
                Me.supplierInfo3Field = value
            End Set
        End Property
        
        Public Property SupplierInfo4() As String
            Get
                Return Me.supplierInfo4Field
            End Get
            Set
                Me.supplierInfo4Field = value
            End Set
        End Property
        
        Public Property SupplierInfo5() As String
            Get
                Return Me.supplierInfo5Field
            End Get
            Set
                Me.supplierInfo5Field = value
            End Set
        End Property
        
        Public Property SupplierInfo6() As String
            Get
                Return Me.supplierInfo6Field
            End Get
            Set
                Me.supplierInfo6Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupinvmanfsupItemPreferredFlag.Y)>  _
        Public Property PreferredFlag() As SetupinvmanfsupItemPreferredFlag
            Get
                Return Me.preferredFlagField
            End Get
            Set
                Me.preferredFlagField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupinvmanfsupItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As List(Of Byte)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private appManufacturerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manPartNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As SByte
        
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
        
        <CLSCompliant(False)> _
        Public Property Supplier() As SByte
            Get
                Return Me.supplierField
            End Get
            Set(ByVal value As SByte)
                Me.supplierField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupinvmanfsupItemPreferredFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
