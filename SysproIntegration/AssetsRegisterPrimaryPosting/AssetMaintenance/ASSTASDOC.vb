Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryPosting.AssetMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostAssetMaintenance
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostAssetMaintenanceItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostAssetMaintenanceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostAssetMaintenanceItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostAssetMaintenanceItem)
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
                Return "ASSTAS"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostAssetMaintenanceParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostAssetMaintenanceParameters
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
                Dim objParams As Params.PostAssetMaintenance
                objParams = New Params.PostAssetMaintenance
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
    Partial Public Class PostAssetMaintenanceItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private locationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostCenterField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetGroupCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private glCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxPaidField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetStatusField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDepnPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private respUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetOwnerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValDepField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDepField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnStartPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValResidualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thruputAnnumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalPeriodsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private suspendField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValDepDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wearTearDepField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wearDepStDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wearTearResidualField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStartPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private investAllowPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private initialAllowPctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capitalGainsTaxValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private agreementNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private totalInterestField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private leasePeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private firstInstalDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private monthlyInstalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private finalInstallmentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private registrationNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chassisNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private engineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private agreementCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newOldFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newValueAlt1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValCodeAlt1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newValueAlt2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValCodeAlt2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newValueAlt3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bookValCodeAlt3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnValue13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr6Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr7Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr8Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr9Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr10Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr11Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr12Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYr13Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accumDepnBfField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Property Asset() As String
            Get
                Return Me.assetField
            End Get
            Set
                Me.assetField = value
            End Set
        End Property
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property Location() As String
            Get
                Return Me.locationField
            End Get
            Set
                Me.locationField = value
            End Set
        End Property
        
        Public Property AssetType() As String
            Get
                Return Me.assetTypeField
            End Get
            Set
                Me.assetTypeField = value
            End Set
        End Property
        
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property AssetCostCenter() As String
            Get
                Return Me.assetCostCenterField
            End Get
            Set
                Me.assetCostCenterField = value
            End Set
        End Property
        
        Public Property AssetGroupCode() As String
            Get
                Return Me.assetGroupCodeField
            End Get
            Set
                Me.assetGroupCodeField = value
            End Set
        End Property
        
        Public Property GlCode() As String
            Get
                Return Me.glCodeField
            End Get
            Set
                Me.glCodeField = value
            End Set
        End Property
        
        Public Property PurchaseDate() As String
            Get
                Return Me.purchaseDateField
            End Get
            Set
                Me.purchaseDateField = value
            End Set
        End Property
        
        Public Property DepositValue() As String
            Get
                Return Me.depositValueField
            End Get
            Set
                Me.depositValueField = value
            End Set
        End Property
        
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        Public Property TaxPaid() As String
            Get
                Return Me.taxPaidField
            End Get
            Set
                Me.taxPaidField = value
            End Set
        End Property
        
        Public Property AssetQty() As String
            Get
                Return Me.assetQtyField
            End Get
            Set
                Me.assetQtyField = value
            End Set
        End Property
        
        Public Property AssetStatus() As String
            Get
                Return Me.assetStatusField
            End Get
            Set
                Me.assetStatusField = value
            End Set
        End Property
        
        Public Property StartDepnPeriod() As String
            Get
                Return Me.startDepnPeriodField
            End Get
            Set
                Me.startDepnPeriodField = value
            End Set
        End Property
        
        Public Property CapexCode() As String
            Get
                Return Me.capexCodeField
            End Get
            Set
                Me.capexCodeField = value
            End Set
        End Property
        
        Public Property CapexLine() As String
            Get
                Return Me.capexLineField
            End Get
            Set
                Me.capexLineField = value
            End Set
        End Property
        
        Public Property RespUser() As String
            Get
                Return Me.respUserField
            End Get
            Set
                Me.respUserField = value
            End Set
        End Property
        
        Public Property AssetOwner() As String
            Get
                Return Me.assetOwnerField
            End Get
            Set
                Me.assetOwnerField = value
            End Set
        End Property
        
        Public Property CycleCount() As String
            Get
                Return Me.cycleCountField
            End Get
            Set
                Me.cycleCountField = value
            End Set
        End Property
        
        Public Property BookValDep() As String
            Get
                Return Me.bookValDepField
            End Get
            Set
                Me.bookValDepField = value
            End Set
        End Property
        
        Public Property StartDep() As String
            Get
                Return Me.startDepField
            End Get
            Set
                Me.startDepField = value
            End Set
        End Property
        
        Public Property DepnStartPeriod() As String
            Get
                Return Me.depnStartPeriodField
            End Get
            Set
                Me.depnStartPeriodField = value
            End Set
        End Property
        
        Public Property BookValResidual() As String
            Get
                Return Me.bookValResidualField
            End Get
            Set
                Me.bookValResidualField = value
            End Set
        End Property
        
        Public Property ThruputAnnum() As String
            Get
                Return Me.thruputAnnumField
            End Get
            Set
                Me.thruputAnnumField = value
            End Set
        End Property
        
        Public Property StatGlCode() As String
            Get
                Return Me.statGlCodeField
            End Get
            Set
                Me.statGlCodeField = value
            End Set
        End Property
        
        Public Property TotalPeriods() As String
            Get
                Return Me.totalPeriodsField
            End Get
            Set
                Me.totalPeriodsField = value
            End Set
        End Property
        
        Public Property Suspend() As String
            Get
                Return Me.suspendField
            End Get
            Set
                Me.suspendField = value
            End Set
        End Property
        
        Public Property BookValDepDate() As String
            Get
                Return Me.bookValDepDateField
            End Get
            Set
                Me.bookValDepDateField = value
            End Set
        End Property
        
        Public Property WearTearDep() As String
            Get
                Return Me.wearTearDepField
            End Get
            Set
                Me.wearTearDepField = value
            End Set
        End Property
        
        Public Property WearDepStDate() As String
            Get
                Return Me.wearDepStDateField
            End Get
            Set
                Me.wearDepStDateField = value
            End Set
        End Property
        
        Public Property WearTearResidual() As String
            Get
                Return Me.wearTearResidualField
            End Get
            Set
                Me.wearTearResidualField = value
            End Set
        End Property
        
        Public Property TaxStartPeriod() As String
            Get
                Return Me.taxStartPeriodField
            End Get
            Set
                Me.taxStartPeriodField = value
            End Set
        End Property
        
        Public Property InvestAllowPct() As String
            Get
                Return Me.investAllowPctField
            End Get
            Set
                Me.investAllowPctField = value
            End Set
        End Property
        
        Public Property InitialAllowPct() As String
            Get
                Return Me.initialAllowPctField
            End Get
            Set
                Me.initialAllowPctField = value
            End Set
        End Property
        
        Public Property CapitalGainsTaxVal() As String
            Get
                Return Me.capitalGainsTaxValField
            End Get
            Set
                Me.capitalGainsTaxValField = value
            End Set
        End Property
        
        Public Property AgreementNum() As String
            Get
                Return Me.agreementNumField
            End Get
            Set
                Me.agreementNumField = value
            End Set
        End Property
        
        Public Property TotalInterest() As String
            Get
                Return Me.totalInterestField
            End Get
            Set
                Me.totalInterestField = value
            End Set
        End Property
        
        Public Property LeasePeriod() As String
            Get
                Return Me.leasePeriodField
            End Get
            Set
                Me.leasePeriodField = value
            End Set
        End Property
        
        Public Property FirstInstalDate() As String
            Get
                Return Me.firstInstalDateField
            End Get
            Set
                Me.firstInstalDateField = value
            End Set
        End Property
        
        Public Property MonthlyInstal() As String
            Get
                Return Me.monthlyInstalField
            End Get
            Set
                Me.monthlyInstalField = value
            End Set
        End Property
        
        Public Property FinalInstallment() As String
            Get
                Return Me.finalInstallmentField
            End Get
            Set
                Me.finalInstallmentField = value
            End Set
        End Property
        
        Public Property RegistrationNum() As String
            Get
                Return Me.registrationNumField
            End Get
            Set
                Me.registrationNumField = value
            End Set
        End Property
        
        Public Property ChassisNum() As String
            Get
                Return Me.chassisNumField
            End Get
            Set
                Me.chassisNumField = value
            End Set
        End Property
        
        Public Property Engine() As String
            Get
                Return Me.engineField
            End Get
            Set
                Me.engineField = value
            End Set
        End Property
        
        Public Property AssetId() As String
            Get
                Return Me.assetIdField
            End Get
            Set
                Me.assetIdField = value
            End Set
        End Property
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property AgreementCode() As String
            Get
                Return Me.agreementCodeField
            End Get
            Set
                Me.agreementCodeField = value
            End Set
        End Property
        
        Public Property NewOldFlag() As String
            Get
                Return Me.newOldFlagField
            End Get
            Set
                Me.newOldFlagField = value
            End Set
        End Property
        
        Public Property NewValueAlt1() As String
            Get
                Return Me.newValueAlt1Field
            End Get
            Set
                Me.newValueAlt1Field = value
            End Set
        End Property
        
        Public Property BookValCodeAlt1() As String
            Get
                Return Me.bookValCodeAlt1Field
            End Get
            Set
                Me.bookValCodeAlt1Field = value
            End Set
        End Property
        
        Public Property NewValueAlt2() As String
            Get
                Return Me.newValueAlt2Field
            End Get
            Set
                Me.newValueAlt2Field = value
            End Set
        End Property
        
        Public Property BookValCodeAlt2() As String
            Get
                Return Me.bookValCodeAlt2Field
            End Get
            Set
                Me.bookValCodeAlt2Field = value
            End Set
        End Property
        
        Public Property NewValueAlt3() As String
            Get
                Return Me.newValueAlt3Field
            End Get
            Set
                Me.newValueAlt3Field = value
            End Set
        End Property
        
        Public Property BookValCodeAlt3() As String
            Get
                Return Me.bookValCodeAlt3Field
            End Get
            Set
                Me.bookValCodeAlt3Field = value
            End Set
        End Property
        
        Public Property DepnValue1() As String
            Get
                Return Me.depnValue1Field
            End Get
            Set
                Me.depnValue1Field = value
            End Set
        End Property
        
        Public Property DepnValue2() As String
            Get
                Return Me.depnValue2Field
            End Get
            Set
                Me.depnValue2Field = value
            End Set
        End Property
        
        Public Property DepnValue3() As String
            Get
                Return Me.depnValue3Field
            End Get
            Set
                Me.depnValue3Field = value
            End Set
        End Property
        
        Public Property DepnValue4() As String
            Get
                Return Me.depnValue4Field
            End Get
            Set
                Me.depnValue4Field = value
            End Set
        End Property
        
        Public Property DepnValue5() As String
            Get
                Return Me.depnValue5Field
            End Get
            Set
                Me.depnValue5Field = value
            End Set
        End Property
        
        Public Property DepnValue6() As String
            Get
                Return Me.depnValue6Field
            End Get
            Set
                Me.depnValue6Field = value
            End Set
        End Property
        
        Public Property DepnValue7() As String
            Get
                Return Me.depnValue7Field
            End Get
            Set
                Me.depnValue7Field = value
            End Set
        End Property
        
        Public Property DepnValue8() As String
            Get
                Return Me.depnValue8Field
            End Get
            Set
                Me.depnValue8Field = value
            End Set
        End Property
        
        Public Property DepnValue9() As String
            Get
                Return Me.depnValue9Field
            End Get
            Set
                Me.depnValue9Field = value
            End Set
        End Property
        
        Public Property DepnValue10() As String
            Get
                Return Me.depnValue10Field
            End Get
            Set
                Me.depnValue10Field = value
            End Set
        End Property
        
        Public Property DepnValue11() As String
            Get
                Return Me.depnValue11Field
            End Get
            Set
                Me.depnValue11Field = value
            End Set
        End Property
        
        Public Property DepnValue12() As String
            Get
                Return Me.depnValue12Field
            End Get
            Set
                Me.depnValue12Field = value
            End Set
        End Property
        
        Public Property DepnValue13() As String
            Get
                Return Me.depnValue13Field
            End Get
            Set
                Me.depnValue13Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr1() As String
            Get
                Return Me.depnPrevYr1Field
            End Get
            Set
                Me.depnPrevYr1Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr2() As String
            Get
                Return Me.depnPrevYr2Field
            End Get
            Set
                Me.depnPrevYr2Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr3() As String
            Get
                Return Me.depnPrevYr3Field
            End Get
            Set
                Me.depnPrevYr3Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr4() As String
            Get
                Return Me.depnPrevYr4Field
            End Get
            Set
                Me.depnPrevYr4Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr5() As String
            Get
                Return Me.depnPrevYr5Field
            End Get
            Set
                Me.depnPrevYr5Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr6() As String
            Get
                Return Me.depnPrevYr6Field
            End Get
            Set
                Me.depnPrevYr6Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr7() As String
            Get
                Return Me.depnPrevYr7Field
            End Get
            Set
                Me.depnPrevYr7Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr8() As String
            Get
                Return Me.depnPrevYr8Field
            End Get
            Set
                Me.depnPrevYr8Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr9() As String
            Get
                Return Me.depnPrevYr9Field
            End Get
            Set
                Me.depnPrevYr9Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr10() As String
            Get
                Return Me.depnPrevYr10Field
            End Get
            Set
                Me.depnPrevYr10Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr11() As String
            Get
                Return Me.depnPrevYr11Field
            End Get
            Set
                Me.depnPrevYr11Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr12() As String
            Get
                Return Me.depnPrevYr12Field
            End Get
            Set
                Me.depnPrevYr12Field = value
            End Set
        End Property
        
        Public Property DepnPrevYr13() As String
            Get
                Return Me.depnPrevYr13Field
            End Get
            Set
                Me.depnPrevYr13Field = value
            End Set
        End Property
        
        Public Property AccumDepnBf() As String
            Get
                Return Me.accumDepnBfField
            End Get
            Set
                Me.accumDepnBfField = value
            End Set
        End Property
        
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
End Namespace
