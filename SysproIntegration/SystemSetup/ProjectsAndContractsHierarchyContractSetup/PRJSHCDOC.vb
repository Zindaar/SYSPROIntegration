Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.ProjectsAndContractsHierarchyContractSetup.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupPrjContMaster
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As SetupPrjContMasterItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupPrjContMasterParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SetupPrjContMasterItem
            End If
        End Sub
        
        Public Property Item() As SetupPrjContMasterItem
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
                Return "PRJSHC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupPrjContMasterParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupPrjContMasterParameters
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
                Dim objParams As Params.SetupPrjContMaster
                objParams = New Params.SetupPrjContMaster
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
    Partial Public Class SetupPrjContMasterItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As List(Of SetupPrjContMasterItemKey)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc1Field As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc2Field As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc3Field As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc4Field As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractDesc5Field As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private responsibilityField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private respPersonField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private estComplDateField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextReviewDateField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nextBillingDateField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastReviewDateField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualComplDateField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyCodeField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionCustomerField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private retentionPctField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prgBillingMethodField As List(Of SetupPrjContMasterItemPrgBillingMethod)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notionalBillValField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositRequiredField As List(Of SetupPrjContMasterItemDepositRequired)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositProductClassField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositMethodField As List(Of SetupPrjContMasterItemDepositMethod)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositTypeField As List(Of SetupPrjContMasterItemDepositType)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositPercentField As List(Of String)
        
        Public Sub New()
            MyBase.New
            If (Me.depositPercentField Is Nothing) Then
                Me.depositPercentField = New List(Of String)
            End If
            If (Me.depositTypeField Is Nothing) Then
                Me.depositTypeField = New List(Of SetupPrjContMasterItemDepositType)
            End If
            If (Me.depositMethodField Is Nothing) Then
                Me.depositMethodField = New List(Of SetupPrjContMasterItemDepositMethod)
            End If
            If (Me.depositProductClassField Is Nothing) Then
                Me.depositProductClassField = New List(Of String)
            End If
            If (Me.depositRequiredField Is Nothing) Then
                Me.depositRequiredField = New List(Of SetupPrjContMasterItemDepositRequired)
            End If
            If (Me.notionalBillValField Is Nothing) Then
                Me.notionalBillValField = New List(Of String)
            End If
            If (Me.prgBillingMethodField Is Nothing) Then
                Me.prgBillingMethodField = New List(Of SetupPrjContMasterItemPrgBillingMethod)
            End If
            If (Me.retentionPctField Is Nothing) Then
                Me.retentionPctField = New List(Of String)
            End If
            If (Me.retentionCustomerField Is Nothing) Then
                Me.retentionCustomerField = New List(Of String)
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New List(Of String)
            End If
            If (Me.hierarchyCodeField Is Nothing) Then
                Me.hierarchyCodeField = New List(Of String)
            End If
            If (Me.actualComplDateField Is Nothing) Then
                Me.actualComplDateField = New List(Of String)
            End If
            If (Me.lastReviewDateField Is Nothing) Then
                Me.lastReviewDateField = New List(Of String)
            End If
            If (Me.nextBillingDateField Is Nothing) Then
                Me.nextBillingDateField = New List(Of String)
            End If
            If (Me.nextReviewDateField Is Nothing) Then
                Me.nextReviewDateField = New List(Of String)
            End If
            If (Me.estComplDateField Is Nothing) Then
                Me.estComplDateField = New List(Of String)
            End If
            If (Me.respPersonField Is Nothing) Then
                Me.respPersonField = New List(Of String)
            End If
            If (Me.responsibilityField Is Nothing) Then
                Me.responsibilityField = New List(Of String)
            End If
            If (Me.contractDesc5Field Is Nothing) Then
                Me.contractDesc5Field = New List(Of String)
            End If
            If (Me.contractDesc4Field Is Nothing) Then
                Me.contractDesc4Field = New List(Of String)
            End If
            If (Me.contractDesc3Field Is Nothing) Then
                Me.contractDesc3Field = New List(Of String)
            End If
            If (Me.contractDesc2Field Is Nothing) Then
                Me.contractDesc2Field = New List(Of String)
            End If
            If (Me.contractDesc1Field Is Nothing) Then
                Me.contractDesc1Field = New List(Of String)
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New List(Of SetupPrjContMasterItemKey)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Key")>  _
        Public Property KeyCollection() As List(Of SetupPrjContMasterItemKey)
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContractDesc1")>  _
        Public Property ContractDesc1Collection() As List(Of String)
            Get
                Return Me.contractDesc1Field
            End Get
            Set
                Me.contractDesc1Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContractDesc2")>  _
        Public Property ContractDesc2Collection() As List(Of String)
            Get
                Return Me.contractDesc2Field
            End Get
            Set
                Me.contractDesc2Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContractDesc3")>  _
        Public Property ContractDesc3Collection() As List(Of String)
            Get
                Return Me.contractDesc3Field
            End Get
            Set
                Me.contractDesc3Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContractDesc4")>  _
        Public Property ContractDesc4Collection() As List(Of String)
            Get
                Return Me.contractDesc4Field
            End Get
            Set
                Me.contractDesc4Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ContractDesc5")>  _
        Public Property ContractDesc5Collection() As List(Of String)
            Get
                Return Me.contractDesc5Field
            End Get
            Set
                Me.contractDesc5Field = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Responsibility")>  _
        Public Property ResponsibilityCollection() As List(Of String)
            Get
                Return Me.responsibilityField
            End Get
            Set
                Me.responsibilityField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("RespPerson")>  _
        Public Property RespPersonCollection() As List(Of String)
            Get
                Return Me.respPersonField
            End Get
            Set
                Me.respPersonField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("EstComplDate")>  _
        Public Property EstComplDateCollection() As List(Of String)
            Get
                Return Me.estComplDateField
            End Get
            Set
                Me.estComplDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("NextReviewDate")>  _
        Public Property NextReviewDateCollection() As List(Of String)
            Get
                Return Me.nextReviewDateField
            End Get
            Set
                Me.nextReviewDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("NextBillingDate")>  _
        Public Property NextBillingDateCollection() As List(Of String)
            Get
                Return Me.nextBillingDateField
            End Get
            Set
                Me.nextBillingDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("LastReviewDate")>  _
        Public Property LastReviewDateCollection() As List(Of String)
            Get
                Return Me.lastReviewDateField
            End Get
            Set
                Me.lastReviewDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ActualComplDate")>  _
        Public Property ActualComplDateCollection() As List(Of String)
            Get
                Return Me.actualComplDateField
            End Get
            Set
                Me.actualComplDateField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("HierarchyCode")>  _
        Public Property HierarchyCodeCollection() As List(Of String)
            Get
                Return Me.hierarchyCodeField
            End Get
            Set
                Me.hierarchyCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Customer")>  _
        Public Property CustomerCollection() As List(Of String)
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("RetentionCustomer")>  _
        Public Property RetentionCustomerCollection() As List(Of String)
            Get
                Return Me.retentionCustomerField
            End Get
            Set
                Me.retentionCustomerField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("RetentionPct")>  _
        Public Property RetentionPctCollection() As List(Of String)
            Get
                Return Me.retentionPctField
            End Get
            Set
                Me.retentionPctField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("PrgBillingMethod")>  _
        Public Property PrgBillingMethodCollection() As List(Of SetupPrjContMasterItemPrgBillingMethod)
            Get
                Return Me.prgBillingMethodField
            End Get
            Set
                Me.prgBillingMethodField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("NotionalBillVal")>  _
        Public Property NotionalBillValCollection() As List(Of String)
            Get
                Return Me.notionalBillValField
            End Get
            Set
                Me.notionalBillValField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DepositRequired")>  _
        Public Property DepositRequiredCollection() As List(Of SetupPrjContMasterItemDepositRequired)
            Get
                Return Me.depositRequiredField
            End Get
            Set
                Me.depositRequiredField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DepositProductClass")>  _
        Public Property DepositProductClassCollection() As List(Of String)
            Get
                Return Me.depositProductClassField
            End Get
            Set
                Me.depositProductClassField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DepositMethod")>  _
        Public Property DepositMethodCollection() As List(Of SetupPrjContMasterItemDepositMethod)
            Get
                Return Me.depositMethodField
            End Get
            Set
                Me.depositMethodField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DepositType")>  _
        Public Property DepositTypeCollection() As List(Of SetupPrjContMasterItemDepositType)
            Get
                Return Me.depositTypeField
            End Get
            Set
                Me.depositTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DepositPercent")>  _
        Public Property DepositPercentCollection() As List(Of String)
            Get
                Return Me.depositPercentField
            End Get
            Set
                Me.depositPercentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupPrjContMasterItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupPrjContMasterItemPrgBillingMethod
        
        '''<remarks/>
        M
        
        '''<remarks/>
        F
        
        '''<remarks/>
        S
        
        '''<remarks/>
        P
        
        '''<remarks/>
        A
        
        '''<remarks/>
        N
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupPrjContMasterItemDepositRequired
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupPrjContMasterItemDepositMethod
        
        '''<remarks/>
        P
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupPrjContMasterItemDepositType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        V
    End Enum
End Namespace
