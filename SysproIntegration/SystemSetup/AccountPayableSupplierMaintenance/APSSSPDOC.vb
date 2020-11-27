Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.AccountPayableSupplierMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupApSupplier
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of SetupApSupplierItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of SetupApSupplierItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of SetupApSupplierItem)
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
                Return "APSSSP"
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
                Dim objParams As Params.SetupApSupplier
                objParams = New Params.SetupApSupplier
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
    Partial Public Class SetupApSupplierItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupApSupplierItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supShortNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierChNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private termsCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateSuppAddedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withTaxIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private remitPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxRegnNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultChequeDayField As SetupApSupplierItemDefaultChequeDay
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poDefaultDocField As SetupApSupplierItemPoDefaultDoc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onHoldField As SetupApSupplierItemOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitFlagField As SetupApSupplierItemFaxRemitFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxRemitContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierTypeField As SetupApSupplierItemSupplierType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numMthsBeforDelField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payByEftField As SetupApSupplierItemPayByEft
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankBranchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankAccountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eftUserField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eftUserField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eftStatementRefField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eftBankAccTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private chLanguageField As SetupApSupplierItemChLanguage
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private required1099Field As SetupApSupplierItemRequired1099
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultFmt1099Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private askYtdValue1099Field As SetupApSupplierItemAskYtdValue1099
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPay1099Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private payeRef1099Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ytdAmount1099Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchOrdAllowedField As SetupApSupplierItemPurchOrdAllowed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoValField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoMassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPoVolumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractsField As SetupApSupplierItemContracts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grnMatchReqdField As SetupApSupplierItemGrnMatchReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctRequiredField As SetupApSupplierItemLctRequired
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediTypeFlagField As SetupApSupplierItemEdiTypeFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediTypeFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediReceiverCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.defaultChequeDayField = SetupApSupplierItemDefaultChequeDay.Item00
            Me.poDefaultDocField = SetupApSupplierItemPoDefaultDoc.Item0
            Me.onHoldField = SetupApSupplierItemOnHold.N
            Me.faxRemitFlagField = SetupApSupplierItemFaxRemitFlag.N
            Me.supplierTypeField = SetupApSupplierItemSupplierType.P
            Me.payByEftField = SetupApSupplierItemPayByEft.N
            Me.chLanguageField = SetupApSupplierItemChLanguage.Item05
            Me.required1099Field = SetupApSupplierItemRequired1099.N
            Me.askYtdValue1099Field = SetupApSupplierItemAskYtdValue1099.N
            Me.purchOrdAllowedField = SetupApSupplierItemPurchOrdAllowed.Y
            Me.contractsField = SetupApSupplierItemContracts.N
            Me.grnMatchReqdField = SetupApSupplierItemGrnMatchReqd.Y
            Me.lctRequiredField = SetupApSupplierItemLctRequired.N
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupApSupplierItemKey
            End If
        End Sub
        
        Public Property Key() As SetupApSupplierItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property SupplierName() As String
            Get
                Return Me.supplierNameField
            End Get
            Set
                Me.supplierNameField = value
            End Set
        End Property
        
        Public Property SupShortName() As String
            Get
                Return Me.supShortNameField
            End Get
            Set
                Me.supShortNameField = value
            End Set
        End Property
        
        Public Property SupplierChName() As String
            Get
                Return Me.supplierChNameField
            End Get
            Set
                Me.supplierChNameField = value
            End Set
        End Property
        
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
            End Set
        End Property
        
        Public Property Contact() As String
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
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
        
        Public Property TermsCode() As String
            Get
                Return Me.termsCodeField
            End Get
            Set
                Me.termsCodeField = value
            End Set
        End Property
        
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        Public Property DateSuppAdded() As String
            Get
                Return Me.dateSuppAddedField
            End Get
            Set
                Me.dateSuppAddedField = value
            End Set
        End Property
        
        Public Property WithTaxId() As String
            Get
                Return Me.withTaxIdField
            End Get
            Set
                Me.withTaxIdField = value
            End Set
        End Property
        
        Public Property WithTaxCode() As String
            Get
                Return Me.withTaxCodeField
            End Get
            Set
                Me.withTaxCodeField = value
            End Set
        End Property
        
        Public Property SupAddr1() As String
            Get
                Return Me.supAddr1Field
            End Get
            Set
                Me.supAddr1Field = value
            End Set
        End Property
        
        Public Property SupAddr2() As String
            Get
                Return Me.supAddr2Field
            End Get
            Set
                Me.supAddr2Field = value
            End Set
        End Property
        
        Public Property SupAddr3() As String
            Get
                Return Me.supAddr3Field
            End Get
            Set
                Me.supAddr3Field = value
            End Set
        End Property
        
        Public Property SupAddr4() As String
            Get
                Return Me.supAddr4Field
            End Get
            Set
                Me.supAddr4Field = value
            End Set
        End Property
        
        Public Property SupAddr5() As String
            Get
                Return Me.supAddr5Field
            End Get
            Set
                Me.supAddr5Field = value
            End Set
        End Property
        
        Public Property SupPostalCode() As String
            Get
                Return Me.supPostalCodeField
            End Get
            Set
                Me.supPostalCodeField = value
            End Set
        End Property
        
        Public Property RemitName() As String
            Get
                Return Me.remitNameField
            End Get
            Set
                Me.remitNameField = value
            End Set
        End Property
        
        Public Property RemitAddr1() As String
            Get
                Return Me.remitAddr1Field
            End Get
            Set
                Me.remitAddr1Field = value
            End Set
        End Property
        
        Public Property RemitAddr2() As String
            Get
                Return Me.remitAddr2Field
            End Get
            Set
                Me.remitAddr2Field = value
            End Set
        End Property
        
        Public Property RemitAddr3() As String
            Get
                Return Me.remitAddr3Field
            End Get
            Set
                Me.remitAddr3Field = value
            End Set
        End Property
        
        Public Property RemitAddr4() As String
            Get
                Return Me.remitAddr4Field
            End Get
            Set
                Me.remitAddr4Field = value
            End Set
        End Property
        
        Public Property RemitAddr5() As String
            Get
                Return Me.remitAddr5Field
            End Get
            Set
                Me.remitAddr5Field = value
            End Set
        End Property
        
        Public Property RemitPostalCode() As String
            Get
                Return Me.remitPostalCodeField
            End Get
            Set
                Me.remitPostalCodeField = value
            End Set
        End Property
        
        Public Property SupplierClass() As String
            Get
                Return Me.supplierClassField
            End Get
            Set
                Me.supplierClassField = value
            End Set
        End Property
        
        Public Property LineDiscCode() As String
            Get
                Return Me.lineDiscCodeField
            End Get
            Set
                Me.lineDiscCodeField = value
            End Set
        End Property
        
        Public Property InvDiscCode() As String
            Get
                Return Me.invDiscCodeField
            End Get
            Set
                Me.invDiscCodeField = value
            End Set
        End Property
        
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        Public Property DefTaxCode() As String
            Get
                Return Me.defTaxCodeField
            End Get
            Set
                Me.defTaxCodeField = value
            End Set
        End Property
        
        Public Property TaxRegnNum() As String
            Get
                Return Me.taxRegnNumField
            End Get
            Set
                Me.taxRegnNumField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemDefaultChequeDay.Item00)>  _
        Public Property DefaultChequeDay() As SetupApSupplierItemDefaultChequeDay
            Get
                Return Me.defaultChequeDayField
            End Get
            Set
                Me.defaultChequeDayField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemPoDefaultDoc.Item0)>  _
        Public Property PoDefaultDoc() As SetupApSupplierItemPoDefaultDoc
            Get
                Return Me.poDefaultDocField
            End Get
            Set
                Me.poDefaultDocField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemOnHold.N)>  _
        Public Property OnHold() As SetupApSupplierItemOnHold
            Get
                Return Me.onHoldField
            End Get
            Set
                Me.onHoldField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemFaxRemitFlag.N)>  _
        Public Property FaxRemitFlag() As SetupApSupplierItemFaxRemitFlag
            Get
                Return Me.faxRemitFlagField
            End Get
            Set
                Me.faxRemitFlagField = value
            End Set
        End Property
        
        Public Property FaxRemitNum() As String
            Get
                Return Me.faxRemitNumField
            End Get
            Set
                Me.faxRemitNumField = value
            End Set
        End Property
        
        Public Property FaxRemitContact() As String
            Get
                Return Me.faxRemitContactField
            End Get
            Set
                Me.faxRemitContactField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemSupplierType.P)>  _
        Public Property SupplierType() As SetupApSupplierItemSupplierType
            Get
                Return Me.supplierTypeField
            End Get
            Set
                Me.supplierTypeField = value
            End Set
        End Property
        
        Public Property NumMthsBeforDel() As String
            Get
                Return Me.numMthsBeforDelField
            End Get
            Set
                Me.numMthsBeforDelField = value
            End Set
        End Property
        
        Public Property MerchGlCode() As String
            Get
                Return Me.merchGlCodeField
            End Get
            Set
                Me.merchGlCodeField = value
            End Set
        End Property
        
        Public Property FreightGlCode() As String
            Get
                Return Me.freightGlCodeField
            End Get
            Set
                Me.freightGlCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemPayByEft.N)>  _
        Public Property PayByEft() As SetupApSupplierItemPayByEft
            Get
                Return Me.payByEftField
            End Get
            Set
                Me.payByEftField = value
            End Set
        End Property
        
        Public Property BankBranch() As String
            Get
                Return Me.bankBranchField
            End Get
            Set
                Me.bankBranchField = value
            End Set
        End Property
        
        Public Property BankAccount() As String
            Get
                Return Me.bankAccountField
            End Get
            Set
                Me.bankAccountField = value
            End Set
        End Property
        
        Public Property EftUserField1() As String
            Get
                Return Me.eftUserField1Field
            End Get
            Set
                Me.eftUserField1Field = value
            End Set
        End Property
        
        Public Property EftUserField2() As String
            Get
                Return Me.eftUserField2Field
            End Get
            Set
                Me.eftUserField2Field = value
            End Set
        End Property
        
        Public Property EftStatementRef() As String
            Get
                Return Me.eftStatementRefField
            End Get
            Set
                Me.eftStatementRefField = value
            End Set
        End Property
        
        Public Property EftBankAccType() As String
            Get
                Return Me.eftBankAccTypeField
            End Get
            Set
                Me.eftBankAccTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemChLanguage.Item05)>  _
        Public Property ChLanguage() As SetupApSupplierItemChLanguage
            Get
                Return Me.chLanguageField
            End Get
            Set
                Me.chLanguageField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemRequired1099.N)>  _
        Public Property Required1099() As SetupApSupplierItemRequired1099
            Get
                Return Me.required1099Field
            End Get
            Set
                Me.required1099Field = value
            End Set
        End Property
        
        Public Property DefaultFmt1099() As String
            Get
                Return Me.defaultFmt1099Field
            End Get
            Set
                Me.defaultFmt1099Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemAskYtdValue1099.N)>  _
        Public Property AskYtdValue1099() As SetupApSupplierItemAskYtdValue1099
            Get
                Return Me.askYtdValue1099Field
            End Get
            Set
                Me.askYtdValue1099Field = value
            End Set
        End Property
        
        Public Property MinPay1099() As String
            Get
                Return Me.minPay1099Field
            End Get
            Set
                Me.minPay1099Field = value
            End Set
        End Property
        
        Public Property PayeRef1099() As String
            Get
                Return Me.payeRef1099Field
            End Get
            Set
                Me.payeRef1099Field = value
            End Set
        End Property
        
        Public Property YtdAmount1099() As String
            Get
                Return Me.ytdAmount1099Field
            End Get
            Set
                Me.ytdAmount1099Field = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemPurchOrdAllowed.Y)>  _
        Public Property PurchOrdAllowed() As SetupApSupplierItemPurchOrdAllowed
            Get
                Return Me.purchOrdAllowedField
            End Get
            Set
                Me.purchOrdAllowedField = value
            End Set
        End Property
        
        Public Property MinPoVal() As String
            Get
                Return Me.minPoValField
            End Get
            Set
                Me.minPoValField = value
            End Set
        End Property
        
        Public Property MinPoMass() As String
            Get
                Return Me.minPoMassField
            End Get
            Set
                Me.minPoMassField = value
            End Set
        End Property
        
        Public Property MinPoVolume() As String
            Get
                Return Me.minPoVolumeField
            End Get
            Set
                Me.minPoVolumeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemContracts.N)>  _
        Public Property Contracts() As SetupApSupplierItemContracts
            Get
                Return Me.contractsField
            End Get
            Set
                Me.contractsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemGrnMatchReqd.Y)>  _
        Public Property GrnMatchReqd() As SetupApSupplierItemGrnMatchReqd
            Get
                Return Me.grnMatchReqdField
            End Get
            Set
                Me.grnMatchReqdField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(SetupApSupplierItemLctRequired.N)>  _
        Public Property LctRequired() As SetupApSupplierItemLctRequired
            Get
                Return Me.lctRequiredField
            End Get
            Set
                Me.lctRequiredField = value
            End Set
        End Property
        
        Public Property EdiTypeFlag() As SetupApSupplierItemEdiTypeFlag
            Get
                Return Me.ediTypeFlagField
            End Get
            Set
                Me.ediTypeFlagField = value
                Me.EdiTypeFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EdiTypeFlagSpecified() As Boolean
            Get
                Return Me.ediTypeFlagFieldSpecified
            End Get
        End Property
        
        Public Property EdiReceiverCode() As String
            Get
                Return Me.ediReceiverCodeField
            End Get
            Set
                Me.ediReceiverCodeField = value
            End Set
        End Property
        
        Public Property EdiFax() As String
            Get
                Return Me.ediFaxField
            End Get
            Set
                Me.ediFaxField = value
            End Set
        End Property
        
        Public Property FaxContact() As String
            Get
                Return Me.faxContactField
            End Get
            Set
                Me.faxContactField = value
            End Set
        End Property
        
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set
                Me.transactionNatureField = value
            End Set
        End Property
        
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupApSupplierItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemDefaultChequeDay
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("00")>  _
        Item00
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")>  _
        Item01
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("02")>  _
        Item02
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("03")>  _
        Item03
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("04")>  _
        Item04
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")>  _
        Item05
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("06")>  _
        Item06
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("07")>  _
        Item07
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("08")>  _
        Item08
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("09")>  _
        Item09
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("10")>  _
        Item10
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")>  _
        Item11
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("12")>  _
        Item12
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("13")>  _
        Item13
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("14")>  _
        Item14
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("15")>  _
        Item15
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("16")>  _
        Item16
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("17")>  _
        Item17
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("18")>  _
        Item18
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("19")>  _
        Item19
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("20")>  _
        Item20
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("21")>  _
        Item21
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("22")>  _
        Item22
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("23")>  _
        Item23
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("24")>  _
        Item24
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("25")>  _
        Item25
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("26")>  _
        Item26
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("27")>  _
        Item27
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("28")>  _
        Item28
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemPoDefaultDoc
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("5")>  _
        Item5
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("6")>  _
        Item6
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("9")>  _
        Item9
        
        '''<remarks/>
        A
        
        '''<remarks/>
        B
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        E
        
        '''<remarks/>
        F
        
        '''<remarks/>
        G
        
        '''<remarks/>
        H
        
        '''<remarks/>
        I
        
        '''<remarks/>
        J
        
        '''<remarks/>
        K
        
        '''<remarks/>
        L
        
        '''<remarks/>
        M
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        P
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
        '''<remarks/>
        T
        
        '''<remarks/>
        U
        
        '''<remarks/>
        V
        
        '''<remarks/>
        W
        
        '''<remarks/>
        X
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Z
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemOnHold
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemFaxRemitFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemSupplierType
        
        '''<remarks/>
        P
        
        '''<remarks/>
        T
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemPayByEft
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemChLanguage
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("05")>  _
        Item05
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("07")>  _
        Item07
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("08")>  _
        Item08
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("11")>  _
        Item11
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("12")>  _
        Item12
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemRequired1099
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemAskYtdValue1099
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemPurchOrdAllowed
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemContracts
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemGrnMatchReqd
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemLctRequired
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupApSupplierItemEdiTypeFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        F
    End Enum
End Namespace
