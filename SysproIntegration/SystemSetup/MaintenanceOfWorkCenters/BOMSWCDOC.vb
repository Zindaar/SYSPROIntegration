Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.MaintenanceOfWorkCenters.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupBomWorkCentre
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of SetupBomWorkCentreItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.SetupBomWorkCentreParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of SetupBomWorkCentreItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of SetupBomWorkCentreItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlIgnore()> _
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                Me._setupActionTypeField = Value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "BOMSWC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.SetupBomWorkCentreParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SetupBomWorkCentreParameters
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
                Dim objParams As Params.SetupBomWorkCentre
                objParams = New Params.SetupBomWorkCentre
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
    Partial Public Class SetupBomWorkCentreItem
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private keyField As SetupBomWorkCentreItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private descriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costCentreField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate6Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate7Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate8Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setUpRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixOverRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varOverRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startupRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownRate9Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timeUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private etCalcMethField As SetupBomWorkCentreItemEtCalcMeth = SetupBomWorkCentreItemEtCalcMeth.U

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private capacityUomField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cstToCapFactField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cstToCapMulDivField As SetupBomWorkCentreItemCstToCapMulDiv = SetupBomWorkCentreItemCstToCapMulDiv.M

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prodUnitDescField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private useEmployeeRateField As SetupBomWorkCentreItemUseEmployeeRate = SetupBomWorkCentreItemUseEmployeeRate.N

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private productClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private runTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private setupTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private varTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private teardownTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonRunTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonSetupTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonFixTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonVarTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonStartTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonTearTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private utilisePctField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private overtimeCapPctField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private useOvertimeCapField As SetupBomWorkCentreItemUseOvertimeCap = SetupBomWorkCentreItemUseOvertimeCap.N

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private normalCapacityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private queueTimeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defSubSupplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defSubPlannerField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private defSubBuyerField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private workOperatorsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private prodUnitsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private timePerUnitField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private calcCapConvFactField As SetupBomWorkCentreItemCalcCapConvFact = SetupBomWorkCentreItemCalcCapConvFact.Y

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cellIdField As String

        Public Sub New()
            Me.keyField = New SetupBomWorkCentreItemKey
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Key")> _
        Public Property Key() As SetupBomWorkCentreItemKey
            Get
                Return Me.keyField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemKey)
                Me.keyField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Description")> _
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set(ByVal value As String)
                Me.descriptionField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("CostCentre")> _
        Public Property CostCentre() As String
            Get
                Return Me.costCentreField
            End Get
            Set(ByVal value As String)
                Me.costCentreField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate1")> _
        Public Property SetUpRate1() As String
            Get
                Return Me.setUpRate1Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate1")> _
        Public Property RunTimeRate1() As String
            Get
                Return Me.runTimeRate1Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate1")> _
        Public Property FixOverRate1() As String
            Get
                Return Me.fixOverRate1Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate1")> _
        Public Property VarOverRate1() As String
            Get
                Return Me.varOverRate1Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate1")> _
        Public Property StartupRate1() As String
            Get
                Return Me.startupRate1Field
            End Get
            Set(ByVal value As String)
                Me.startupRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate1")> _
        Public Property TeardownRate1() As String
            Get
                Return Me.teardownRate1Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate1Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate2")> _
        Public Property SetUpRate2() As String
            Get
                Return Me.setUpRate2Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate2")> _
        Public Property RunTimeRate2() As String
            Get
                Return Me.runTimeRate2Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate2")> _
        Public Property FixOverRate2() As String
            Get
                Return Me.fixOverRate2Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate2")> _
        Public Property VarOverRate2() As String
            Get
                Return Me.varOverRate2Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate2")> _
        Public Property StartupRate2() As String
            Get
                Return Me.startupRate2Field
            End Get
            Set(ByVal value As String)
                Me.startupRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate2")> _
        Public Property TeardownRate2() As String
            Get
                Return Me.teardownRate2Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate2Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate3")> _
        Public Property SetUpRate3() As String
            Get
                Return Me.setUpRate3Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate3")> _
        Public Property RunTimeRate3() As String
            Get
                Return Me.runTimeRate3Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate3")> _
        Public Property FixOverRate3() As String
            Get
                Return Me.fixOverRate3Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate3")> _
        Public Property VarOverRate3() As String
            Get
                Return Me.varOverRate3Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate3")> _
        Public Property StartupRate3() As String
            Get
                Return Me.startupRate3Field
            End Get
            Set(ByVal value As String)
                Me.startupRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate3")> _
        Public Property TeardownRate3() As String
            Get
                Return Me.teardownRate3Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate3Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate4")> _
        Public Property SetUpRate4() As String
            Get
                Return Me.setUpRate4Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate4")> _
        Public Property RunTimeRate4() As String
            Get
                Return Me.runTimeRate4Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate4")> _
        Public Property FixOverRate4() As String
            Get
                Return Me.fixOverRate4Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate4")> _
        Public Property VarOverRate4() As String
            Get
                Return Me.varOverRate4Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate4")> _
        Public Property StartupRate4() As String
            Get
                Return Me.startupRate4Field
            End Get
            Set(ByVal value As String)
                Me.startupRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate4")> _
        Public Property TeardownRate4() As String
            Get
                Return Me.teardownRate4Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate4Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate5")> _
        Public Property SetUpRate5() As String
            Get
                Return Me.setUpRate5Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate5")> _
        Public Property RunTimeRate5() As String
            Get
                Return Me.runTimeRate5Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate5")> _
        Public Property FixOverRate5() As String
            Get
                Return Me.fixOverRate5Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate5")> _
        Public Property VarOverRate5() As String
            Get
                Return Me.varOverRate5Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate5")> _
        Public Property StartupRate5() As String
            Get
                Return Me.startupRate5Field
            End Get
            Set(ByVal value As String)
                Me.startupRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate5")> _
        Public Property TeardownRate5() As String
            Get
                Return Me.teardownRate5Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate5Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate6")> _
        Public Property SetUpRate6() As String
            Get
                Return Me.setUpRate6Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate6")> _
        Public Property RunTimeRate6() As String
            Get
                Return Me.runTimeRate6Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate6")> _
        Public Property FixOverRate6() As String
            Get
                Return Me.fixOverRate6Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate6")> _
        Public Property VarOverRate6() As String
            Get
                Return Me.varOverRate6Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate6")> _
        Public Property StartupRate6() As String
            Get
                Return Me.startupRate6Field
            End Get
            Set(ByVal value As String)
                Me.startupRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate6")> _
        Public Property TeardownRate6() As String
            Get
                Return Me.teardownRate6Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate6Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate7")> _
        Public Property SetUpRate7() As String
            Get
                Return Me.setUpRate7Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate7")> _
        Public Property RunTimeRate7() As String
            Get
                Return Me.runTimeRate7Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate7")> _
        Public Property FixOverRate7() As String
            Get
                Return Me.fixOverRate7Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate7")> _
        Public Property VarOverRate7() As String
            Get
                Return Me.varOverRate7Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate7")> _
        Public Property StartupRate7() As String
            Get
                Return Me.startupRate7Field
            End Get
            Set(ByVal value As String)
                Me.startupRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate7")> _
        Public Property TeardownRate7() As String
            Get
                Return Me.teardownRate7Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate7Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate8")> _
        Public Property SetUpRate8() As String
            Get
                Return Me.setUpRate8Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate8")> _
        Public Property RunTimeRate8() As String
            Get
                Return Me.runTimeRate8Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate8")> _
        Public Property FixOverRate8() As String
            Get
                Return Me.fixOverRate8Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate8")> _
        Public Property VarOverRate8() As String
            Get
                Return Me.varOverRate8Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate8")> _
        Public Property StartupRate8() As String
            Get
                Return Me.startupRate8Field
            End Get
            Set(ByVal value As String)
                Me.startupRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate8")> _
        Public Property TeardownRate8() As String
            Get
                Return Me.teardownRate8Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate8Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetUpRate9")> _
        Public Property SetUpRate9() As String
            Get
                Return Me.setUpRate9Field
            End Get
            Set(ByVal value As String)
                Me.setUpRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTimeRate9")> _
        Public Property RunTimeRate9() As String
            Get
                Return Me.runTimeRate9Field
            End Get
            Set(ByVal value As String)
                Me.runTimeRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixOverRate9")> _
        Public Property FixOverRate9() As String
            Get
                Return Me.fixOverRate9Field
            End Get
            Set(ByVal value As String)
                Me.fixOverRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarOverRate9")> _
        Public Property VarOverRate9() As String
            Get
                Return Me.varOverRate9Field
            End Get
            Set(ByVal value As String)
                Me.varOverRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartupRate9")> _
        Public Property StartupRate9() As String
            Get
                Return Me.startupRate9Field
            End Get
            Set(ByVal value As String)
                Me.startupRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownRate9")> _
        Public Property TeardownRate9() As String
            Get
                Return Me.teardownRate9Field
            End Get
            Set(ByVal value As String)
                Me.teardownRate9Field = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TimeUom")> _
        Public Property TimeUom() As String
            Get
                Return Me.timeUomField
            End Get
            Set(ByVal value As String)
                Me.timeUomField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreItemEtCalcMeth.U)> _
        Public Property EtCalcMethCollection() As SetupBomWorkCentreItemEtCalcMeth
            Get
                Return Me.etCalcMethField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemEtCalcMeth)
                Me.etCalcMethField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("CapacityUom")> _
        Public Property CapacityUom() As String
            Get
                Return Me.capacityUomField
            End Get
            Set(ByVal value As String)
                Me.capacityUomField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("CstToCapFact")> _
        Public Property CstToCapFact() As String
            Get
                Return Me.cstToCapFactField
            End Get
            Set(ByVal value As String)
                Me.cstToCapFactField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreItemCstToCapMulDiv.M)> _
        Public Property CstToCapMulDivCollection() As SetupBomWorkCentreItemCstToCapMulDiv
            Get
                Return Me.cstToCapMulDivField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemCstToCapMulDiv)
                Me.cstToCapMulDivField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("ProdUnitDesc")> _
        Public Property ProdUnitDesc() As String
            Get
                Return Me.prodUnitDescField
            End Get
            Set(ByVal value As String)
                Me.prodUnitDescField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreItemUseEmployeeRate.N)> _
        Public Property UseEmployeeRateCollection() As SetupBomWorkCentreItemUseEmployeeRate
            Get
                Return Me.useEmployeeRateField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemUseEmployeeRate)
                Me.useEmployeeRateField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("ProductClass")> _
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set(ByVal value As String)
                Me.productClassField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("RunTime")> _
        Public Property RunTime() As String
            Get
                Return Me.runTimeField
            End Get
            Set(ByVal value As String)
                Me.runTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SetupTime")> _
        Public Property SetupTime() As String
            Get
                Return Me.setupTimeField
            End Get
            Set(ByVal value As String)
                Me.setupTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("FixTime")> _
        Public Property FixTime() As String
            Get
                Return Me.fixTimeField
            End Get
            Set(ByVal value As String)
                Me.fixTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("VarTime")> _
        Public Property VarTime() As String
            Get
                Return Me.varTimeField
            End Get
            Set(ByVal value As String)
                Me.varTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("StartTime")> _
        Public Property StartTime() As String
            Get
                Return Me.startTimeField
            End Get
            Set(ByVal value As String)
                Me.startTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TeardownTime")> _
        Public Property TeardownTime() As String
            Get
                Return Me.teardownTimeField
            End Get
            Set(ByVal value As String)
                Me.teardownTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonRunTime")> _
        Public Property NonRunTime() As String
            Get
                Return Me.nonRunTimeField
            End Get
            Set(ByVal value As String)
                Me.nonRunTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonSetupTime")> _
        Public Property NonSetupTime() As String
            Get
                Return Me.nonSetupTimeField
            End Get
            Set(ByVal value As String)
                Me.nonSetupTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonFixTime")> _
        Public Property NonFixTime() As String
            Get
                Return Me.nonFixTimeField
            End Get
            Set(ByVal value As String)
                Me.nonFixTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonVarTime")> _
        Public Property NonVarTime() As String
            Get
                Return Me.nonVarTimeField
            End Get
            Set(ByVal value As String)
                Me.nonVarTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonStartTime")> _
        Public Property NonStartTime() As String
            Get
                Return Me.nonStartTimeField
            End Get
            Set(ByVal value As String)
                Me.nonStartTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NonTearTime")> _
        Public Property NonTearTime() As String
            Get
                Return Me.nonTearTimeField
            End Get
            Set(ByVal value As String)
                Me.nonTearTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("UtilisePct")> _
        Public Property UtilisePct() As String
            Get
                Return Me.utilisePctField
            End Get
            Set(ByVal value As String)
                Me.utilisePctField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("OvertimeCapPct")> _
        Public Property OvertimeCapPct() As String
            Get
                Return Me.overtimeCapPctField
            End Get
            Set(ByVal value As String)
                Me.overtimeCapPctField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreItemUseOvertimeCap.N)> _
        Public Property UseOvertimeCapCollection() As SetupBomWorkCentreItemUseOvertimeCap
            Get
                Return Me.useOvertimeCapField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemUseOvertimeCap)
                Me.useOvertimeCapField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("NormalCapacity")> _
        Public Property NormalCapacity() As String
            Get
                Return Me.normalCapacityField
            End Get
            Set(ByVal value As String)
                Me.normalCapacityField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("QueueTime")> _
        Public Property QueueTime() As String
            Get
                Return Me.queueTimeField
            End Get
            Set(ByVal value As String)
                Me.queueTimeField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("DefSubSupplier")> _
        Public Property DefSubSupplier() As String
            Get
                Return Me.defSubSupplierField
            End Get
            Set(ByVal value As String)
                Me.defSubSupplierField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("DefSubPlanner")> _
        Public Property DefSubPlanner() As String
            Get
                Return Me.defSubPlannerField
            End Get
            Set(ByVal value As String)
                Me.defSubPlannerField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("DefSubBuyer")> _
        Public Property DefSubBuyer() As String
            Get
                Return Me.defSubBuyerField
            End Get
            Set(ByVal value As String)
                Me.defSubBuyerField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("WorkOperators")> _
        Public Property WorkOperators() As String
            Get
                Return Me.workOperatorsField
            End Get
            Set(ByVal value As String)
                Me.workOperatorsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("ProdUnits")> _
        Public Property ProdUnits() As String
            Get
                Return Me.prodUnitsField
            End Get
            Set(ByVal value As String)
                Me.prodUnitsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("TimePerUnit")> _
        Public Property TimePerUnit() As String
            Get
                Return Me.timePerUnitField
            End Get
            Set(ByVal value As String)
                Me.timePerUnitField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SetupBomWorkCentreItemCalcCapConvFact.Y)> _
        Public Property CalcCapConvFactCollection() As SetupBomWorkCentreItemCalcCapConvFact
            Get
                Return Me.calcCapConvFactField
            End Get
            Set(ByVal value As SetupBomWorkCentreItemCalcCapConvFact)
                Me.calcCapConvFactField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("CellId")> _
        Public Property CellId() As String
            Get
                Return Me.cellIdField
            End Get
            Set(ByVal value As String)
                Me.cellIdField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupBomWorkCentreItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private workCentreField As String
        
        Public Property WorkCentre() As String
            Get
                Return Me.workCentreField
            End Get
            Set
                Me.workCentreField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreItemEtCalcMeth
        
        '''<remarks/>
        U
        
        '''<remarks/>
        B
        
        '''<remarks/>
        R
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreItemCstToCapMulDiv
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreItemUseEmployeeRate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreItemUseOvertimeCap
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupBomWorkCentreItemCalcCapConvFact
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
