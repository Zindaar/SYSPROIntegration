Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.AccountsReceivableCustomerMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyLineDisc
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyOrdDisc
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupArCustomer
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This element contains information to maintain a single customer.
        '''NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
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
                Return "ARSSCS"
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
                Dim objParams As Params.SetupArCustomer
                objParams = New Params.SetupArCustomer
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
                'Return
            End If
            If (Me._setupActionTypeField = 1) Then
                Me._xmlOut = SetupObject.Update(Me)
                'Return
            End If
            If (Me._setupActionTypeField = 2) Then
                Me._xmlOut = SetupObject.Delete(Me)
                'Return
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shortNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exemptFinChgField As ExemptFinChg
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exemptFinChgFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maintHistoryField As MaintHistory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maintHistoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditStatusField As CreditStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditLimitField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditCheckFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmCreditCheckField As TpmCreditCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmCreditCheckFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salespersonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesperson3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private termsCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balanceTypeField As BalanceType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private balanceTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineDiscCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusField As TaxStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxExemptNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryTableField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addTelephoneField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telexField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private telephoneExtnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptFlagField As GstExemptFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstExemptNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstLevelField As GstLevel
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstLevelFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private detailMoveReqdField As DetailMoveReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private detailMoveReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractPrcReqdField As ContractPrcReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractPrcReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingGroup5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statementReqdField As StatementReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statementReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private arStatementNoField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private backOrdReqdField As BackOrdReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private backOrdReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateCustAddedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockInterchangeField As StockInterchange
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockInterchangeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maintLastPrcPaidField As MaintLastPrcPaid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maintLastPrcPaidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ibtCustomerField As IbtCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ibtCustomerFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soDefaultDocField As SoDefaultDoc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soDefaultDocFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private counterSlsOnlyField As CounterSlsOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private counterSlsOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private highestBalanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerOnHoldField As CustomerOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerOnHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invCommentCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediSenderCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediFlagField As EdiFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ediFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soDefaultTypeField As SoDefaultType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soDefaultTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private emailField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyOrdDiscField As ApplyOrdDisc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyOrdDiscFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyLineDiscField As ApplyLineDisc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyLineDiscFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxInvoicesField As FaxInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxStatementsField As FaxStatements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxStatementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxQuotesField As ItemFaxQuotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private faxQuotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private docFaxField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private docFaxContactField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldToAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soldPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipToAddr5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private state1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZip1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private city1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultOrdTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poNumberMandatoryField As PoNumberMandatory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poNumberMandatoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private highInvField As HighInv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private highInvDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTaxNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureCField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsCField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmCustomerFlagField As TpmCustomerFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmCustomerFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmPricingFlagField As TpmPricingFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tpmPricingFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeDistanceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.faxInvoicesField = FaxInvoices.N
            If (Me.highInvField Is Nothing) Then
                Me.highInvField = New HighInv
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a customer.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the name of the customer and is used primarily to identify the customer. The format is 30 characters, alphanumeric.
        '''</summary>
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<summary>
        '''This is a short name and is used in searching for a customer. It is also used as selection criteria in some reports.The format is 10 characters, alphanumeric.
        '''</summary>
        Public Property ShortName() As String
            Get
                Return Me.shortNameField
            End Get
            Set
                Me.shortNameField = value
            End Set
        End Property
        
        '''<summary>
        '''Exempt from finance charge flag indicates whether the customer is exempt from finance charges calculated by the Finance Charge Calculation program. (Y - Exempt, N - Not exempt)
        '''</summary>
        Public Property ExemptFinChg() As ExemptFinChg
            Get
                Return Me.exemptFinChgField
            End Get
            Set
                Me.exemptFinChgField = value
                Me.ExemptFinChgFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExemptFinChgSpecified() As Boolean
            Get
                Return Me.exemptFinChgFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Detail history required flag indicates whether or not you require detail sales history to be recorded for any transaction processed against the customer. (Y - Yes, N - No)
        '''</summary>
        Public Property MaintHistory() As MaintHistory
            Get
                Return Me.maintHistoryField
            End Get
            Set
                Me.maintHistoryField = value
                Me.MaintHistoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MaintHistorySpecified() As Boolean
            Get
                Return Me.maintHistoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Credit status flag indicates the customer's current status based on the age of his oldest invoice. This is calculated by the Balance function of the Period End Processing program. The following describes the status code settings:
        '''0 - indicates only current invoices
        '''1 - indicates at least one invoice which is 30 days or over
        '''2 - indicates at least one invoice which is 60 days or over
        '''3 - indicates at least one invoice which is 90 days or over
        '''4 - indicates at least one invoice which is 120 days or over
        '''5 - indicates at least one invoice which is 150 days or over
        '''6 - indicates at least one invoice which is 180 days or over
        '''9 - indicates a manual hold on the account which suspends all credit for the customer
        '''</summary>
        Public Property CreditStatus() As CreditStatus
            Get
                Return Me.creditStatusField
            End Get
            Set
                Me.creditStatusField = value
                Me.CreditStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CreditStatusSpecified() As Boolean
            Get
                Return Me.creditStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Credit limit is the maximum limit that the customer's balance can reach, taking into account any outstanding order values. Format is 12 characters positive numeric.
        '''</summary>
        Public Property CreditLimit() As String
            Get
                Return Me.creditLimitField
            End Get
            Set
                Me.creditLimitField = value
            End Set
        End Property
        
        '''<summary>
        '''Credit checking method for customer. The format is 1 character alphanumeric. Valid values are T (check terms only), L (check limit only), B (check both), N (no checking), and Blank (use company method).
        '''</summary>
        Public Property CreditCheckFlag() As String
            Get
                Return Me.creditCheckFlagField
            End Get
            Set
                Me.creditCheckFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''Does the customer require Trade Promotions credit checking. This is only relevant if the custoemr is a Trade Promotions customer, and credit checking is required.
        '''</summary>
        Public Property TpmCreditCheck() As TpmCreditCheck
            Get
                Return Me.tpmCreditCheckField
            End Get
            Set
                Me.tpmCreditCheckField = value
                Me.TpmCreditCheckFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TpmCreditCheckSpecified() As Boolean
            Get
                Return Me.tpmCreditCheckFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Salesperson is the primary salesperson assigned to the customer and can be used as a selection criterion for various Sales Analysis reports. It is also be used to calculate commissions if you require the source of commission to be based on the salesperson, and not the price of the product being sold.
        '''Format is 3 characters alphanumeric.
        '''</summary>
        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = value
            End Set
        End Property
        
        '''<summary>
        '''First additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined.
        '''You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer. 
        '''Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order).
        '''Format is 3 characters alphanumeric.
        '''</summary>
        Public Property Salesperson1() As String
            Get
                Return Me.salesperson1Field
            End Get
            Set
                Me.salesperson1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Second additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined. It must be left blank if the first additional salesperson is not defined.
        '''You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer. 
        '''Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order).
        '''Format is 3 characters alphanumeric.
        '''</summary>
        Public Property Salesperson2() As String
            Get
                Return Me.salesperson2Field
            End Get
            Set
                Me.salesperson2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Third additional salesperson to be used if you are splitting commission. It cannot be the same as the primary salesperson or either of the other additional salespersons defined. It must be left blank if the second additional salesperson is not defined.
        '''You can assign three additional salespersons to share the commission earned for any sale made to this customer. You indicate the amount of commission that each salesperson should earn, at the end of capturing an order for this customer.
        '''Note: This facility is merely for documentation purposes (i.e. no calculations are actualy performed by the program at the time of capturing the order).
        '''Format is 3 characters alphanumeric.
        '''</summary>
        Public Property Salesperson3() As String
            Get
                Return Me.salesperson3Field
            End Get
            Set
                Me.salesperson3Field = value
            End Set
        End Property
        
        '''<summary>
        '''If you are using simple pricing, then the code entered here is used to establish the price (or discount code) applicable to a specific stock code for the customer, depending on whether the inventory pricing method is coded or discounted. Format is 2 characters alphanumeric.
        '''</summary>
        Public Property PriceCode() As String
            Get
                Return Me.priceCodeField
            End Get
            Set
                Me.priceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer class enables you to classify customers into categories for reports and sales history analysis.
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property CustomerClass() As String
            Get
                Return Me.customerClassField
            End Get
            Set
                Me.customerClassField = value
            End Set
        End Property
        
        '''<summary>
        '''Branch assigned to the customer is used to integrate sales and payments to the General Ledger module. 
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        '''<summary>
        '''Invoice terms is used to determine the default settlement terms required for a customer. SYSPRO uses the invoice terms to calculate discount amounts as well as discount dates and due dates of customer documents processed within the Invoice Posting and Permanent Entries programs. 
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property TermsCode() As String
            Get
                Return Me.termsCodeField
            End Get
            Set
                Me.termsCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Invoice disount code is used to establish the automatic discount applicable to the customer for each invoice entered in the Detail Invoice Posting and Sales Order Order Entry programs. A blank entry indicates that no automatic invoice discount is required for the customer. 
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property InvDiscCode() As String
            Get
                Return Me.invDiscCodeField
            End Get
            Set
                Me.invDiscCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Balance print type flag. Settings are as follows:
        '''I - Open item if you do not want the customer's balance to be brought forward at the end of each month. All transactions are retained on file until the outstanding balance reaches zero and the number of months to retain zero balance invoices has been reached (Accounts Receivable Setup).
        '''B - Balance forward if you want to accumulate the total amount owing by the customer at the end of each month and represent the figure as a balance brought forward from previous months on the debtors statement. If you require brought forward customers to be consolidated at month end (Accounts Receivable Setup) then at month end all details are accumulated into a series of aged balance figures. Payments, adjustments and transactions are made against a specific aged balance.
        '''</summary>
        Public Property BalanceType() As BalanceType
            Get
                Return Me.balanceTypeField
            End Get
            Set
                Me.balanceTypeField = value
                Me.BalanceTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BalanceTypeSpecified() As Boolean
            Get
                Return Me.balanceTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Geographic area is used to classify the customer's location. If you require tax by geographic area (Tax Options Setup) then the tax code assigned to the customer's geographic area can be used to override the tax codes normally used throughout the system. Format is 2 characters alphanumeric.
        '''</summary>
        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set
                Me.areaField = value
            End Set
        End Property
        
        '''<summary>
        '''Line discount code is used to establish the automatic discount applicable to the customer for each order line entered in the Detail Invoice Posting and Sales Order Order Entry programs. A blank entry indicates that no automatic line discount is required for the customer. 
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property LineDiscCode() As String
            Get
                Return Me.lineDiscCodeField
            End Get
            Set
                Me.lineDiscCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Tax status flag. Settings are as follows:
        '''E - Exempt to exempt the customer from sales tax.
        '''N - To indicate that sales tax is applicable to the customer.
        '''O - Other tax code if the tax entry held in the Other tax code field against the stock item is to be used when making a sale against the customer in the Invoice Posting or Sales Order Entry programs.
        '''</summary>
        Public Property TaxStatus() As TaxStatus
            Get
                Return Me.taxStatusField
            End Get
            Set
                Me.taxStatusField = value
                Me.TaxStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxStatusSpecified() As Boolean
            Get
                Return Me.taxStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Customer's tax exempt number. Format is 30 characters alphanumeric.
        '''</summary>
        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set
                Me.taxExemptNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''Special instructions is used in the Sales Order Entry program and can be printed on invoices and reports. Format is 30 character alphanumeric.
        '''</summary>
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
            End Set
        End Property
        
        '''<summary>
        '''Price category table. If you are using extended pricing, then you can enter up to 26 codes, each 2 characters long, determining the price or discount code applicable to a category (A - Z) of products being sold . The pricing category from the inventory file is used to locate a place in the customer's price category/code table. Depending on whether the inventory pricing method is coded or discounted, the price code found in this table is used against the discount table to locate the required discount or to locate a price entry in the inventory file. Format is 26 X 2 alphanumeric characters that match up to category.
        '''</summary>
        Public Property PriceCategoryTable() As String
            Get
                Return Me.priceCategoryTableField
            End Get
            Set
                Me.priceCategoryTableField = value
            End Set
        End Property
        
        '''<summary>
        '''Telephone number for the customer. Format is 20 characters alphanumeric.
        '''</summary>
        Public Property Telephone() As String
            Get
                Return Me.telephoneField
            End Get
            Set
                Me.telephoneField = value
            End Set
        End Property
        
        '''<summary>
        '''Contact name for the customer. Format is 30 characters alphanumeric.
        '''</summary>
        Public Property Contact() As String
            Get
                Return Me.contactField
            End Get
            Set
                Me.contactField = value
            End Set
        End Property
        
        '''<summary>
        '''Additional telephone number for the customer. Format is 20 characters alphanumeric.
        '''</summary>
        Public Property AddTelephone() As String
            Get
                Return Me.addTelephoneField
            End Get
            Set
                Me.addTelephoneField = value
            End Set
        End Property
        
        '''<summary>
        '''Fax number for the customer.  Format is 20 characters alphanumeric.
        '''</summary>
        Public Property Fax() As String
            Get
                Return Me.faxField
            End Get
            Set
                Me.faxField = value
            End Set
        End Property
        
        '''<summary>
        '''Telex number for the customer. Format is 10 characters alphanumeric.
        '''</summary>
        Public Property Telex() As String
            Get
                Return Me.telexField
            End Get
            Set
                Me.telexField = value
            End Set
        End Property
        
        '''<summary>
        '''Telephone extension for the customer. Format is 5 characters alphanumeric.
        '''</summary>
        Public Property TelephoneExtn() As String
            Get
                Return Me.telephoneExtnField
            End Get
            Set
                Me.telephoneExtnField = value
            End Set
        End Property
        
        '''<summary>
        '''Currency code used to determine the currency in which to process invoices for the customer. 
        '''Note: If foreign currency sales are not required (Accounts Receivable Setup)  or a blank entry is made then the local currency is used.  
        '''You cannot change a customer's currency once transactions (sales orders etc.) have been processed for that customer. 
        '''Format is 3 characters alphanumeric.
        '''
        '''</summary>
        Public Property Currency() As String
            Get
                Return Me.currencyField
            End Get
            Set
                Me.currencyField = value
            End Set
        End Property
        
        '''<summary>
        '''This is a 10 character free format alphanumeric user defined field.
        '''</summary>
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a 12.2 positive or negative numeric user defined field.
        '''</summary>
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Canadian GST exemption flag. Settings are as follows:
        '''E - Exempt to exempt the customer from GST.
        '''N - To indicate that GST is applicable to the customer. Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup) 
        '''</summary>
        Public Property GstExemptFlag() As GstExemptFlag
            Get
                Return Me.gstExemptFlagField
            End Get
            Set
                Me.gstExemptFlagField = value
                Me.GstExemptFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GstExemptFlagSpecified() As Boolean
            Get
                Return Me.gstExemptFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Canadian GST exempt number for customer. 
        '''Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup).
        '''Format is 15 characters alphanumeric.
        '''</summary>
        Public Property GstExemptNum() As String
            Get
                Return Me.gstExemptNumField
            End Get
            Set
                Me.gstExemptNumField = value
            End Set
        End Property
        
        '''<summary>
        '''Canadian GST shown by flag. Settings as follows:
        '''I - Invoice if you want GST that is calculated on invoice lines to be shown separately in the invoice totals, and not included in the prices.
        '''L - Line if you want the GST that is calculated on invoice lines to be included in the line values.
        '''For stocked items that have GST included in the price, this option has no effect for non-exempt customers as the GST is already part of the price shown at line level. For exempt customers, the GST value that is part of the price is deducted from the line or the total GST value, depending on your selection at this field.
        '''Note: Only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup)
        '''</summary>
        Public Property GstLevel() As GstLevel
            Get
                Return Me.gstLevelField
            End Get
            Set
                Me.gstLevelField = value
                Me.GstLevelFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GstLevelSpecified() As Boolean
            Get
                Return Me.gstLevelFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Retain detail sales movements against the customer. These detail stock movements can be viewed in the Customer Query program and reported on in the Customer Movements program. (Y - Yes, N - No)
        '''</summary>
        Public Property DetailMoveReqd() As DetailMoveReqd
            Get
                Return Me.detailMoveReqdField
            End Get
            Set
                Me.detailMoveReqdField = value
                Me.DetailMoveReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DetailMoveReqdSpecified() As Boolean
            Get
                Return Me.detailMoveReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Contract pricing flag. Select this option if you require special prices (or price discounts) for stock items to be available for the customer over a fixed time period. During Sales Order Entry the lowest contract price for the customer is used as the price for the order line. (Y - Yes, N - No)
        '''</summary>
        Public Property ContractPrcReqd() As ContractPrcReqd
            Get
                Return Me.contractPrcReqdField
            End Get
            Set
                Me.contractPrcReqdField = value
                Me.ContractPrcReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ContractPrcReqdSpecified() As Boolean
            Get
                Return Me.contractPrcReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''First buying group to which the customer is associated. This must be different to all the other buying groups.
        '''Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer.
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property BuyingGroup1() As String
            Get
                Return Me.buyingGroup1Field
            End Get
            Set
                Me.buyingGroup1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Second buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the first is blank.
        '''Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer. 
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property BuyingGroup2() As String
            Get
                Return Me.buyingGroup2Field
            End Get
            Set
                Me.buyingGroup2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Third buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the second is blank.
        '''Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer.
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property BuyingGroup3() As String
            Get
                Return Me.buyingGroup3Field
            End Get
            Set
                Me.buyingGroup3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fourth buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the third is blank.
        '''Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer.
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property BuyingGroup4() As String
            Get
                Return Me.buyingGroup4Field
            End Get
            Set
                Me.buyingGroup4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fifth buying group to which the customer is associated. This must be different to all the other buying groups and cannot be entered if the fourth is blank.
        '''Buying groups enable you to classify a number of contract customers into a common group for use within the Contract Pricing program. A maximum of five buying groups can be assigned to the customer.
        '''Format is 2 characters alphanumeric.
        '''</summary>
        Public Property BuyingGroup5() As String
            Get
                Return Me.buyingGroup5Field
            End Get
            Set
                Me.buyingGroup5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Statements required flag. Select this option if you want to include this customer for selection when statements are produced for customers using the Statement Print program. (Y - Yes, N - No)
        '''</summary>
        Public Property StatementReqd() As StatementReqd
            Get
                Return Me.statementReqdField
            End Get
            Set
                Me.statementReqdField = value
                Me.StatementReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StatementReqdSpecified() As Boolean
            Get
                Return Me.statementReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Statement format for customer.
        '''</summary>
        Public Property ArStatementNo() As String
            Get
                Return Me.arStatementNoField
            End Get
            Set
                Me.arStatementNoField = value
            End Set
        End Property
        
        '''<summary>
        '''Back orders allowed. Select this option to allow backorder quantities to be entered against the customer during processing in the Sales Order Entry.
        '''</summary>
        Public Property BackOrdReqd() As BackOrdReqd
            Get
                Return Me.backOrdReqdField
            End Get
            Set
                Me.backOrdReqdField = value
                Me.BackOrdReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BackOrdReqdSpecified() As Boolean
            Get
                Return Me.backOrdReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Ship via is the default shipping instruction message to be used for this customer in the Sales Order Entry program. If you leave this field blank, then the default shipping message defined in the Sales Order module (Sales Order Setup) is used. Format is 30 characters alphanumeric.
        '''However, if in SYSPRO Sales Order Setup, the format of the shipping instructions is defined as 'Coded', the first 2 characters designate an existing code and the shipping instructions will be picked up from the code's description. If this code does not exist, the shipping instructions will be saved as entered.
        '''</summary>
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        '''<summary>
        '''State code for customer. Format is 3 character alphanumeric.
        '''</summary>
        Public Property StateCode() As String
            Get
                Return Me.stateCodeField
            End Get
            Set
                Me.stateCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Date created is the date the customer was initially taken on. If zero then the system date is used.
        '''Format is CCYY-MM-DD
        '''</summary>
        Public Property DateCustAdded() As String
            Get
                Return Me.dateCustAddedField
            End Get
            Set
                Me.dateCustAddedField = value
            End Set
        End Property
        
        '''<summary>
        '''Stock code interchange required. Select this option if you want the customer's stock codes to be converted to the standard SYSPRO stock code during processing in Sales Order Entry. (Y - Yes, N - No)
        '''</summary>
        Public Property StockInterchange() As StockInterchange
            Get
                Return Me.stockInterchangeField
            End Get
            Set
                Me.stockInterchangeField = value
                Me.StockInterchangeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockInterchangeSpecified() As Boolean
            Get
                Return Me.stockInterchangeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Customer/stock code cross-reference required. Select this option if you want to retain the last two sales details of any stock item sold to the customer. At the time of entering sales order detail lines you can retrieve this information if you want to enter the same details that were previously processed for the customer. (Y - Yes, N - No)
        '''</summary>
        Public Property MaintLastPrcPaid() As MaintLastPrcPaid
            Get
                Return Me.maintLastPrcPaidField
            End Get
            Set
                Me.maintLastPrcPaidField = value
                Me.MaintLastPrcPaidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MaintLastPrcPaidSpecified() As Boolean
            Get
                Return Me.maintLastPrcPaidFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''IBT customer. Select this option if you want to be able to enter inter-branch transfers for this customer during Sales Order Entry. (Y - Yes, N - No)
        '''</summary>
        Public Property IbtCustomer() As IbtCustomer
            Get
                Return Me.ibtCustomerField
            End Get
            Set
                Me.ibtCustomerField = value
                Me.IbtCustomerFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IbtCustomerSpecified() As Boolean
            Get
                Return Me.ibtCustomerFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Default document format is a default document format for the customer used when batch invoices and/or delivery notes are printed.
        '''</summary>
        Public Property SoDefaultDoc() As SoDefaultDoc
            Get
                Return Me.soDefaultDocField
            End Get
            Set
                Me.soDefaultDocField = value
                Me.SoDefaultDocFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SoDefaultDocSpecified() As Boolean
            Get
                Return Me.soDefaultDocFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Counter sales only. Select this option if you only require counter sales orders to be accepted for the customer during processing in the Sales Order Entry program. This also prevents any part of a counter sales invoice from being placed on account. This option is only used if the Counter Sales module is installed. (Y - Yes, N - No)
        '''</summary>
        Public Property CounterSlsOnly() As CounterSlsOnly
            Get
                Return Me.counterSlsOnlyField
            End Get
            Set
                Me.counterSlsOnlyField = value
                Me.CounterSlsOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CounterSlsOnlySpecified() As Boolean
            Get
                Return Me.counterSlsOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Nationality code. If the EC tax system is installed (Tax Options Setup) then you assign a Nationality code to the customer. This is required by EC Vat regulations to generate various reports required for the proper administration of the EC tax system. Format is 3 characters alphanumeric.
        '''</summary>
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is usually one entered during the takeon of a debtors book.Highest balance attained represents the highest balance ever held by the customer and is updated automatically by the system after the initial takeon. Format is 12.2 positive numeric. 
        '''
        '''</summary>
        Public Property HighestBalance() As String
            Get
                Return Me.highestBalanceField
            End Get
            Set
                Me.highestBalanceField = value
            End Set
        End Property
        
        '''<summary>
        '''Customer on hold flag. Select this option if you want to prohibit new orders from being processed for the customer in the Invoice Posting and Sales Order Entry programs. You will also be unable to process adjustments against the customer in the Payments and Adjustments program. 
        '''( Y - On hold, N - Not on hold)
        '''</summary>
        Public Property CustomerOnHold() As CustomerOnHold
            Get
                Return Me.customerOnHoldField
            End Get
            Set
                Me.customerOnHoldField = value
                Me.CustomerOnHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CustomerOnHoldSpecified() As Boolean
            Get
                Return Me.customerOnHoldFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Standard comment code is the standard sales order comments to be used for the customer during processing in Sales Order Entry.
        '''</summary>
        Public Property InvCommentCode() As String
            Get
                Return Me.invCommentCodeField
            End Get
            Set
                Me.invCommentCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''EDI sender code. You use this field to indicate the Sender code of the company from which you import orders electronically via an ASCII file. You can import this file (EDI Sales Order Import) providing that the entry made here matches the sender code of the company transmitting the file (Interface Setup, Local Site). Format is 40 characters alphanumeric.
        '''</summary>
        Public Property EdiSenderCode() As String
            Get
                Return Me.ediSenderCodeField
            End Get
            Set
                Me.ediSenderCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''EDI trading partner. Select this option to indicate that the Electronic Data Interchange (EDI) system can be used to generate orders for this customer. (Y - Yes, N - No)
        '''</summary>
        Public Property EdiFlag() As EdiFlag
            Get
                Return Me.ediFlagField
            End Get
            Set
                Me.ediFlagField = value
                Me.EdiFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EdiFlagSpecified() As Boolean
            Get
                Return Me.ediFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Default type of sales order that applies to the customer. Settings are as follows:
        '''Space - Operator default
        '''O - Sales order
        '''B - Billing
        '''S - Scheduled order
        '''C - Credit note
        '''D - Debit note
        '''F - Forward order
        '''U - Counter sale
        '''I - IBT
        '''H - Hierachical order
        '''</summary>
        Public Property SoDefaultType() As SoDefaultType
            Get
                Return Me.soDefaultTypeField
            End Get
            Set
                Me.soDefaultTypeField = value
                Me.SoDefaultTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SoDefaultTypeSpecified() As Boolean
            Get
                Return Me.soDefaultTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the e-mail address for the customer. Format is 50 characters alphanumeric. If the 'FaxInvoices' element or the 'FaxStatements' element has been set to email documents, this element cannot be spaces.
        '''</summary>
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        '''<summary>
        '''Calculate order discount based on order value/quantity flag. Select this option if you want to be able to assign order discount breaks to this customer. These discounts are applied to the total value or total quantity of an order processed against the customer within the Sales Order Order Entry program. (Y - Yes, N - No)
        '''</summary>
        Public Property ApplyOrdDisc() As ApplyOrdDisc
            Get
                Return Me.applyOrdDiscField
            End Get
            Set
                Me.applyOrdDiscField = value
                Me.ApplyOrdDiscFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyOrdDiscSpecified() As Boolean
            Get
                Return Me.applyOrdDiscFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Calculate order line discounts according to product class sold. Select this option if you want to be able to assign order discount breaks to specific customer/product class combinations. These discounts are applied to the order line value or order line quantity of orders processed against the customer within the Sales Order Order Entry program. All common product classes for an order are accumulated and the total of each product class is compared to the discount break tables and the discount applied to each line accordingly.  (Y - Yes, N - No)
        '''</summary>
        Public Property ApplyLineDisc() As ApplyLineDisc
            Get
                Return Me.applyLineDiscField
            End Get
            Set
                Me.applyLineDiscField = value
                Me.ApplyLineDiscFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyLineDiscSpecified() As Boolean
            Get
                Return Me.applyLineDiscFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Fax invoices flag. This element indicates which S/O documents, if any, are to be automatically faxed or emailed. The valid values are:
        '''Spaces or 'N' - No documents faxed or emailed (Default)
        '''A' - Fax Order ack and Delivery note
        '''B' - Fax Order ack and Dispatch note
        '''C' - Fax Order ack and Invoice
        '''D' - Fax Delivery note and Dispatch note
        '''E' - Fax Delivery note and Invoice
        '''F' - Fax Dispatch note and Invoice
        '''G' - Fax Order ack, Delivery note and Dispatch note
        '''H' - Fax Order ack, Delivery note and Invoice
        '''I' - Fax Order ack, Dispatch note and Invoice
        '''J' - Fax Delivery note, Dispatch note and Invoice
        '''K' - Fax Order ack, Delivery note, Dispatch note and invoice
        '''W' - Order ack
        '''X' - Delivery note
        '''Y' - Invoice
        '''Z' - Dispatch note
        '''The above codes in lower case will indicate the same combination of documents but to be emailed, eg,
        '''a' - Email Order ack and Delivery note
        '''b' - Email Order ack and Dispatch note
        '''and so on....
        '''</summary>
        Public Property FaxInvoices() As FaxInvoices
            Get
                Return Me.faxInvoicesField
            End Get
            Set
                Me.faxInvoicesField = value
                Me.FaxInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FaxInvoicesSpecified() As Boolean
            Get
                Return Me.faxInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Fax statements flag. Select this option if you wish to automatically fax statements to the customer. (Y - Fax, E - Email, N - Print).
        '''</summary>
        Public Property FaxStatements() As FaxStatements
            Get
                Return Me.faxStatementsField
            End Get
            Set
                Me.faxStatementsField = value
                Me.FaxStatementsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FaxStatementsSpecified() As Boolean
            Get
                Return Me.faxStatementsFieldSpecified
            End Get
        End Property
        
        Public Property FaxQuotes() As ItemFaxQuotes
            Get
                Return Me.faxQuotesField
            End Get
            Set
                Me.faxQuotesField = value
                Me.FaxQuotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FaxQuotesSpecified() As Boolean
            Get
                Return Me.faxQuotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Fax number to use when automatically faxing invoices (FaxInvoices = "Y") and or statements  (FaxStatements = "Y") to the customer. If either are set to "Y" then this entry cannot be blank. Format is 20 characters alphanumeric.
        '''</summary>
        Public Property DocFax() As String
            Get
                Return Me.docFaxField
            End Get
            Set
                Me.docFaxField = value
            End Set
        End Property
        
        '''<summary>
        '''Contact name to add to the invoices/statements being automatically faxed. Format is 40 character alphanumeric.
        '''</summary>
        Public Property DocFaxContact() As String
            Get
                Return Me.docFaxContactField
            End Get
            Set
                Me.docFaxContactField = value
            End Set
        End Property
        
        '''<summary>
        '''First line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property SoldToAddr1() As String
            Get
                Return Me.soldToAddr1Field
            End Get
            Set
                Me.soldToAddr1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Second line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property SoldToAddr2() As String
            Get
                Return Me.soldToAddr2Field
            End Get
            Set
                Me.soldToAddr2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Third line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property SoldToAddr3() As String
            Get
                Return Me.soldToAddr3Field
            End Get
            Set
                Me.soldToAddr3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fourth line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property SoldToAddr4() As String
            Get
                Return Me.soldToAddr4Field
            End Get
            Set
                Me.soldToAddr4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fifth line of the Sold to address. Sold to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property SoldToAddr5() As String
            Get
                Return Me.soldToAddr5Field
            End Get
            Set
                Me.soldToAddr5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Postal/zip code for the sold to address. Sold to address can be printed on invoices and faxes. Format is 9 characters alphanumeric.
        '''</summary>
        Public Property SoldPostalCode() As String
            Get
                Return Me.soldPostalCodeField
            End Get
            Set
                Me.soldPostalCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''First line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property ShipToAddr1() As String
            Get
                Return Me.shipToAddr1Field
            End Get
            Set
                Me.shipToAddr1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Second line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property ShipToAddr2() As String
            Get
                Return Me.shipToAddr2Field
            End Get
            Set
                Me.shipToAddr2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Third line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property ShipToAddr3() As String
            Get
                Return Me.shipToAddr3Field
            End Get
            Set
                Me.shipToAddr3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fourth line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property ShipToAddr4() As String
            Get
                Return Me.shipToAddr4Field
            End Get
            Set
                Me.shipToAddr4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Fifth line of the Ship to address. Ship to address can be printed on invoices and faxes. Format is 40 characters alphanumeric.
        '''</summary>
        Public Property ShipToAddr5() As String
            Get
                Return Me.shipToAddr5Field
            End Get
            Set
                Me.shipToAddr5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Postal/zip code for the ship to address. Ship to address can be printed on invoices and faxes. Format is 9 characters alphanumeric.
        '''</summary>
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the state code that is part of the extended tax code applicable to the sold to address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 2 character alphanumeric.
        '''</summary>
        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the county or zip code that is part of the extended tax code applicable to the sold to address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 5 character alphanumeric.
        '''</summary>
        Public Property CountyZip() As String
            Get
                Return Me.countyZipField
            End Get
            Set
                Me.countyZipField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the city code that is part of the extended tax code applicable to the sold to address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 3 character alphanumeric.
        '''</summary>
        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the state code that is part of the extended tax code applicable to the ship to address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 2 character alphanumeric.
        '''</summary>
        Public Property State1() As String
            Get
                Return Me.state1Field
            End Get
            Set
                Me.state1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the county or zip code that is part of the extended tax code applicable to the shipto address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 5 character alphanumeric.
        '''</summary>
        Public Property CountyZip1() As String
            Get
                Return Me.countyZip1Field
            End Get
            Set
                Me.countyZip1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is the city code that is part of the extended tax code applicable to the sold to address. 
        '''Note: The Extended tax code field is only displayed if your nationality code is defined as USA and either the AVP sales tax system is required or you require tax by advanced geocodes (Tax Options Setup).
        '''Format is 3 character alphanumeric.
        '''</summary>
        Public Property City1() As String
            Get
                Return Me.city1Field
            End Get
            Set
                Me.city1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Default order type to be used when an order is generated for this customer at header level in the Sales Order Entry program. The entry made here overrides whatever default order type is defined within the Sales Order module. Format is 2 character alphanumeric.
        '''</summary>
        Public Property DefaultOrdType() As String
            Get
                Return Me.defaultOrdTypeField
            End Get
            Set
                Me.defaultOrdTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Is a customer purchase order required when entering a sales order?
        '''</summary>
        Public Property PoNumberMandatory() As PoNumberMandatory
            Get
                Return Me.poNumberMandatoryField
            End Get
            Set
                Me.poNumberMandatoryField = value
                Me.PoNumberMandatoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PoNumberMandatorySpecified() As Boolean
            Get
                Return Me.poNumberMandatoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Invoice number of oldest outstanding invoice. These fields are normally updated by the system only. However, during the 'takeon' process of a 'Debtors Book' (New installation or new module) - this information may be available and is useful to the credit controller. Format is 6 characters alphanumeric.
        '''</summary>
        Public Property HighInv() As HighInv
            Get
                Return Me.highInvField
            End Get
            Set
                Me.highInvField = value
            End Set
        End Property
        
        '''<summary>
        '''Age of oldest outstanding invoice. These fields are normally updated by the system only. However, during the 'takeon' process of a 'Debtors Book' (New installation or new module) - this information may be available and is useful to the credit 	controller. Format is 3 characters alphanumeric.
        '''</summary>
        Public Property HighInvDays() As String
            Get
                Return Me.highInvDaysField
            End Get
            Set
                Me.highInvDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''Company registration number
        '''</summary>
        Public Property CompanyTaxNumber() As String
            Get
                Return Me.companyTaxNumberField
            End Get
            Set
                Me.companyTaxNumberField = value
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
        
        Public Property TransactionNatureC() As String
            Get
                Return Me.transactionNatureCField
            End Get
            Set
                Me.transactionNatureCField = value
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
        
        Public Property DeliveryTermsC() As String
            Get
                Return Me.deliveryTermsCField
            End Get
            Set
                Me.deliveryTermsCField = value
            End Set
        End Property
        
        '''<summary>
        '''Is the customer a Trade Promotions customer?
        '''</summary>
        Public Property TpmCustomerFlag() As TpmCustomerFlag
            Get
                Return Me.tpmCustomerFlagField
            End Get
            Set
                Me.tpmCustomerFlagField = value
                Me.TpmCustomerFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TpmCustomerFlagSpecified() As Boolean
            Get
                Return Me.tpmCustomerFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Does the customer require Trade Promotions pricing. This is only relevant if the customer is a Trade Promotions customer.
        '''</summary>
        Public Property TpmPricingFlag() As TpmPricingFlag
            Get
                Return Me.tpmPricingFlagField
            End Get
            Set
                Me.tpmPricingFlagField = value
                Me.TpmPricingFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TpmPricingFlagSpecified() As Boolean
            Get
                Return Me.tpmPricingFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the default delivery route to be used in Load Planning is required. If entered, it must be a valid SYSPRO load planning route code.
        '''</summary>
        Public Property RouteCode() As String
            Get
                Return Me.routeCodeField
            End Get
            Set
                Me.routeCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the distance or sequence to be used against all loads for this customer. It is used to determine the order of loading items. The fields is numeric, 4 integers.
        '''</summary>
        Public Property RouteDistance() As String
            Get
                Return Me.routeDistanceField
            End Get
            Set
                Me.routeDistanceField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the default warehouse to be used for this customer when entering a sales order. If entered, it must be a valid SYSPRO warehouse.
        '''</summary>
        Public Property SalesWarehouse() As String
            Get
                Return Me.salesWarehouseField
            End Get
            Set
                Me.salesWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''GUID for eSignature
        '''</summary>
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        '''<summary>
        '''This is the key to the customer being maintained. This is mandatory.The format is up to 7 characters, alphanumeric or numeric depending on a configuration option within SYSPRO.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ExemptFinChg
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MaintHistory
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CreditStatus
        
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
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TpmCreditCheck
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BalanceType
        
        '''<remarks/>
        I
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TaxStatus
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GstExemptFlag
        
        '''<remarks/>
        E
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GstLevel
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        I
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DetailMoveReqd
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ContractPrcReqd
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StatementReqd
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BackOrdReqd
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StockInterchange
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MaintLastPrcPaid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IbtCustomer
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SoDefaultDoc
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item01
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CounterSlsOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CustomerOnHold
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum EdiFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SoDefaultType
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        O
        
        '''<remarks/>
        B
        
        '''<remarks/>
        S
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        F
        
        '''<remarks/>
        U
        
        '''<remarks/>
        I
        
        '''<remarks/>
        H
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FaxInvoices
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
        
        '''<remarks/>
        N
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FaxStatements
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemFaxQuotes
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PoNumberMandatory
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class HighInv
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TpmCustomerFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TpmPricingFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
