Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace CashBookPrimaryPosting.PostDepositsAndWithdrawalsToCashBook.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class LedgerDistribution
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerNotationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerValueField As String
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        Public Property LedgerTaxCode() As String
            Get
                Return Me.ledgerTaxCodeField
            End Get
            Set
                Me.ledgerTaxCodeField = value
            End Set
        End Property
        
        Public Property LedgerNotation() As String
            Get
                Return Me.ledgerNotationField
            End Get
            Set
                Me.ledgerNotationField = value
            End Set
        End Property
        
        Public Property LedgerValue() As String
            Get
                Return Me.ledgerValueField
            End Get
            Set
                Me.ledgerValueField = value
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
    Partial Public Class PostCbDepositsWithdrawals
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostCbDepositsWithdrawalsItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostCbDepositsWithdrawalsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostCbDepositsWithdrawalsItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostCbDepositsWithdrawalsItem)
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
                Return "CSHTWD"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostCbDepositsWithdrawalsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostCbDepositsWithdrawalsParameters
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
                Dim objParams As Params.PostCbDepositsWithdrawals
                objParams = New Params.PostCbDepositsWithdrawals
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
    Partial Public Class PostCbDepositsWithdrawalsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Object
        
        <System.Xml.Serialization.XmlElementAttribute("AddTransaction", GetType(PostCbDepositsWithdrawalsItemAddTransaction)),  _
         System.Xml.Serialization.XmlElementAttribute("ChangeTransaction", GetType(PostCbDepositsWithdrawalsItemChangeTransaction)),  _
         System.Xml.Serialization.XmlElementAttribute("ReconOrUnreconByCheck", GetType(PostCbDepositsWithdrawalsItemReconOrUnreconByCheck)),  _
         System.Xml.Serialization.XmlElementAttribute("ReconOrUnreconByTransaction", GetType(PostCbDepositsWithdrawalsItemReconOrUnreconByTransaction)),  _
         System.Xml.Serialization.XmlElementAttribute("UnreconByPeriod", GetType(PostCbDepositsWithdrawalsItemUnreconByPeriod))>  _
        Public Property Item() As Object
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCbDepositsWithdrawalsItemAddTransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositOrWithdrawalField As PostCbDepositsWithdrawalsItemAddTransactionDepositOrWithdrawal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depositOrWithdrawalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconciledField As PostCbDepositsWithdrawalsItemAddTransactionReconciled
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private narrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private withdrawalTypeField As PostCbDepositsWithdrawalsItemAddTransactionWithdrawalType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eftBeneficiaryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingCurrencyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxBasisField As TaxBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerDistributionField As List(Of LedgerDistribution)
        
        Public Sub New()
            MyBase.New
            Me.reconciledField = PostCbDepositsWithdrawalsItemAddTransactionReconciled.N
            Me.withdrawalTypeField = PostCbDepositsWithdrawalsItemAddTransactionWithdrawalType.M
            Me.taxBasisField = TaxBasis.E
            If (Me.ledgerDistributionField Is Nothing) Then
                Me.ledgerDistributionField = New List(Of LedgerDistribution)
            End If
        End Sub
        
        '''<summary>
        '''This element is mandatory . This is the SYSPRO bank against which a deposit or withdrawal is being added, changed, reconciled or unreconciled. The value of this element must be a valid SYSPRO bank. If the element is not supplied or if spaces are supplied the bank defined against the SYSPRO operator is used as the default.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        Public Property DepositOrWithdrawal() As PostCbDepositsWithdrawalsItemAddTransactionDepositOrWithdrawal
            Get
                Return Me.depositOrWithdrawalField
            End Get
            Set
                Me.depositOrWithdrawalField = value
                Me.DepositOrWithdrawalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DepositOrWithdrawalSpecified() As Boolean
            Get
                Return Me.depositOrWithdrawalFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemAddTransactionReconciled.N)>  _
        Public Property Reconciled() As PostCbDepositsWithdrawalsItemAddTransactionReconciled
            Get
                Return Me.reconciledField
            End Get
            Set
                Me.reconciledField = value
            End Set
        End Property
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property TransactionValue() As String
            Get
                Return Me.transactionValueField
            End Get
            Set
                Me.transactionValueField = value
            End Set
        End Property
        
        Public Property TransactionDate() As String
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = value
            End Set
        End Property
        
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemAddTransactionWithdrawalType.M)>  _
        Public Property WithdrawalType() As PostCbDepositsWithdrawalsItemAddTransactionWithdrawalType
            Get
                Return Me.withdrawalTypeField
            End Get
            Set
                Me.withdrawalTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'ReconOrUnreconByCheck' hierarchy. This is the check number assigned to the transaction that you want to reconcile/unreconcile.This element is optional within the 'AddTransaction' hierarchy. This element is only relevant if adding a withdrawal and the value supplied in the 'WithdrawalType' element is 'M' or 'E'. If 'M' is supplied this is the manual check number. If 'E' is supplied this is the EFT payment number
        '''</summary>
        Public Property CheckNumber() As String
            Get
                Return Me.checkNumberField
            End Get
            Set
                Me.checkNumberField = value
            End Set
        End Property
        
        Public Property EftBeneficiary() As String
            Get
                Return Me.eftBeneficiaryField
            End Get
            Set
                Me.eftBeneficiaryField = value
            End Set
        End Property
        
        Public Property PostingCurrency() As String
            Get
                Return Me.postingCurrencyField
            End Get
            Set
                Me.postingCurrencyField = value
            End Set
        End Property
        
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element indicates whether the tax is exclusive or inclusive. Valid options are 'E' - exclusive or 'I' - inclusive. 
        '''</summary>
        Public Property TaxBasis() As TaxBasis
            Get
                Return Me.taxBasisField
            End Get
            Set
                Me.taxBasisField = value
                Me.TaxBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxBasisSpecified() As Boolean
            Get
                Return Me.taxBasisFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant it the value supplied in the 'TaxBasis' element is 'E'. This is the value of tax and must always be supplied in local currency.
        '''
        '''</summary>
        Public Property TaxValue() As String
            Get
                Return Me.taxValueField
            End Get
            Set
                Me.taxValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is an optional element. This is the top element for all data supplied for the distribution of the transaction value to the relevant  General Ledger accounts. This element can occur multiple times within the 'AddTransaction' hierarchy and the 'ChangeTransaction' hierarchy. Each occurrence represents all the data applicable to post a value to a SYSPRO General Ledger account.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("LedgerDistribution")>  _
        Public Property LedgerDistributionCollection() As List(Of LedgerDistribution)
            Get
                Return Me.ledgerDistributionField
            End Get
            Set
                Me.ledgerDistributionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemAddTransactionDepositOrWithdrawal
        
        '''<remarks/>
        D
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemAddTransactionReconciled
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemAddTransactionWithdrawalType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        M
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TaxBasis
        
        '''<remarks/>
        E
        
        '''<remarks/>
        I
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCbDepositsWithdrawalsItemChangeTransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newTransactionValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reCalculateLocalValueField As PostCbDepositsWithdrawalsItemChangeTransactionReCalculateLocalValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newTransactionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newCheckNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newNarrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newEftBeneficiaryField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxBasisField As TaxBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerDistributionField As List(Of LedgerDistribution)
        
        Public Sub New()
            MyBase.New
            Me.reCalculateLocalValueField = PostCbDepositsWithdrawalsItemChangeTransactionReCalculateLocalValue.Y
            Me.taxBasisField = TaxBasis.E
            If (Me.ledgerDistributionField Is Nothing) Then
                Me.ledgerDistributionField = New List(Of LedgerDistribution)
            End If
        End Sub
        
        '''<summary>
        '''This element is mandatory . This is the SYSPRO bank against which a deposit or withdrawal is being added, changed, reconciled or unreconciled. The value of this element must be a valid SYSPRO bank. If the element is not supplied or if spaces are supplied the bank defined against the SYSPRO operator is used as the default.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingYear' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingYear() As String
            Get
                Return Me.postingYearField
            End Get
            Set
                Me.postingYearField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingMonth' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingMonth() As String
            Get
                Return Me.postingMonthField
            End Get
            Set
                Me.postingMonthField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingDate' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingDate() As String
            Get
                Return Me.postingDateField
            End Get
            Set
                Me.postingDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingTime' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingTime() As String
            Get
                Return Me.postingTimeField
            End Get
            Set
                Me.postingTimeField = value
            End Set
        End Property
        
        Public Property NewReference() As String
            Get
                Return Me.newReferenceField
            End Get
            Set
                Me.newReferenceField = value
            End Set
        End Property
        
        Public Property NewTransactionValue() As String
            Get
                Return Me.newTransactionValueField
            End Get
            Set
                Me.newTransactionValueField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemChangeTransactionReCalculateLocalValue.Y)>  _
        Public Property ReCalculateLocalValue() As PostCbDepositsWithdrawalsItemChangeTransactionReCalculateLocalValue
            Get
                Return Me.reCalculateLocalValueField
            End Get
            Set
                Me.reCalculateLocalValueField = value
            End Set
        End Property
        
        Public Property NewTransactionDate() As String
            Get
                Return Me.newTransactionDateField
            End Get
            Set
                Me.newTransactionDateField = value
            End Set
        End Property
        
        Public Property NewCheckNumber() As String
            Get
                Return Me.newCheckNumberField
            End Get
            Set
                Me.newCheckNumberField = value
            End Set
        End Property
        
        Public Property NewNarration() As String
            Get
                Return Me.newNarrationField
            End Get
            Set
                Me.newNarrationField = value
            End Set
        End Property
        
        Public Property NewEftBeneficiary() As String
            Get
                Return Me.newEftBeneficiaryField
            End Get
            Set
                Me.newEftBeneficiaryField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element indicates whether the tax is exclusive or inclusive. Valid options are 'E' - exclusive or 'I' - inclusive. 
        '''</summary>
        Public Property TaxBasis() As TaxBasis
            Get
                Return Me.taxBasisField
            End Get
            Set
                Me.taxBasisField = value
                Me.TaxBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TaxBasisSpecified() As Boolean
            Get
                Return Me.taxBasisFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant it the value supplied in the 'TaxBasis' element is 'E'. This is the value of tax and must always be supplied in local currency.
        '''
        '''</summary>
        Public Property TaxValue() As String
            Get
                Return Me.taxValueField
            End Get
            Set
                Me.taxValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is an optional element. This is the top element for all data supplied for the distribution of the transaction value to the relevant  General Ledger accounts. This element can occur multiple times within the 'AddTransaction' hierarchy and the 'ChangeTransaction' hierarchy. Each occurrence represents all the data applicable to post a value to a SYSPRO General Ledger account.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("LedgerDistribution")>  _
        Public Property LedgerDistributionCollection() As List(Of LedgerDistribution)
            Get
                Return Me.ledgerDistributionField
            End Get
            Set
                Me.ledgerDistributionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemChangeTransactionReCalculateLocalValue
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCbDepositsWithdrawalsItemReconOrUnreconByCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconcileOrUnreconcileField As ReconcileOrUnreconcile
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconcileOrUnreconcileFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localCurrencyBankEquivalentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkTypeField As PostCbDepositsWithdrawalsItemReconOrUnreconByCheckCheckType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkTypeFieldSpecified As Boolean
        
        '''<summary>
        '''This element is mandatory . This is the SYSPRO bank against which a deposit or withdrawal is being added, changed, reconciled or unreconciled. The value of this element must be a valid SYSPRO bank. If the element is not supplied or if spaces are supplied the bank defined against the SYSPRO operator is used as the default.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element indicates if the transaction is to be set as reconciled or unreconciled. If this element is not supplied or spaces are supplied, then the business object will reverse the current status of the transaction. In other words if the transaction is already reconciled it will set it to unreconciled and if it is unreconciled it will set it as reconciled.
        '''</summary>
        Public Property ReconcileOrUnreconcile() As ReconcileOrUnreconcile
            Get
                Return Me.reconcileOrUnreconcileField
            End Get
            Set
                Me.reconcileOrUnreconcileField = value
                Me.ReconcileOrUnreconcileFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReconcileOrUnreconcileSpecified() As Boolean
            Get
                Return Me.reconcileOrUnreconcileFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory within the 'ReconOrUnreconByCheck' hierarchy. This is the check number assigned to the transaction that you want to reconcile/unreconcile.This element is optional within the 'AddTransaction' hierarchy. This element is only relevant if adding a withdrawal and the value supplied in the 'WithdrawalType' element is 'M' or 'E'. If 'M' is supplied this is the manual check number. If 'E' is supplied this is the EFT payment number
        '''</summary>
        Public Property CheckNumber() As String
            Get
                Return Me.checkNumberField
            End Get
            Set
                Me.checkNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if reconciling a transaction. If the currency exchange rate has changed and the bank has re-valued your transaction according to the new rate, then this element allows you to enter the new  local currency equivalent. Any difference is posted to the Exchange Variance Account as defined against the SYSPRO Bank .
        '''If this element is not supplied, the current value on the Cash Book SYSPRO file is used as the default. If spaces or nulls are supplied , the value defaults to zero.
        '''
        '''</summary>
        Public Property LocalCurrencyBankEquivalent() As String
            Get
                Return Me.localCurrencyBankEquivalentField
            End Get
            Set
                Me.localCurrencyBankEquivalentField = value
            End Set
        End Property
        
        Public Property CheckType() As PostCbDepositsWithdrawalsItemReconOrUnreconByCheckCheckType
            Get
                Return Me.checkTypeField
            End Get
            Set
                Me.checkTypeField = value
                Me.CheckTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CheckTypeSpecified() As Boolean
            Get
                Return Me.checkTypeFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReconcileOrUnreconcile
        
        '''<remarks/>
        R
        
        '''<remarks/>
        U
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemReconOrUnreconByCheckCheckType
        
        '''<remarks/>
        R
        
        '''<remarks/>
        M
        
        '''<remarks/>
        V
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCbDepositsWithdrawalsItemReconOrUnreconByTransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconcileOrUnreconcileField As ReconcileOrUnreconcile
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reconcileOrUnreconcileFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingYearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingMonthField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private localCurrencyBankEquivalentField As String
        
        '''<summary>
        '''This element is mandatory . This is the SYSPRO bank against which a deposit or withdrawal is being added, changed, reconciled or unreconciled. The value of this element must be a valid SYSPRO bank. If the element is not supplied or if spaces are supplied the bank defined against the SYSPRO operator is used as the default.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element indicates if the transaction is to be set as reconciled or unreconciled. If this element is not supplied or spaces are supplied, then the business object will reverse the current status of the transaction. In other words if the transaction is already reconciled it will set it to unreconciled and if it is unreconciled it will set it as reconciled.
        '''</summary>
        Public Property ReconcileOrUnreconcile() As ReconcileOrUnreconcile
            Get
                Return Me.reconcileOrUnreconcileField
            End Get
            Set
                Me.reconcileOrUnreconcileField = value
                Me.ReconcileOrUnreconcileFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReconcileOrUnreconcileSpecified() As Boolean
            Get
                Return Me.reconcileOrUnreconcileFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingYear' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingYear() As String
            Get
                Return Me.postingYearField
            End Get
            Set
                Me.postingYearField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingMonth' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingMonth() As String
            Get
                Return Me.postingMonthField
            End Get
            Set
                Me.postingMonthField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingDate' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingDate() As String
            Get
                Return Me.postingDateField
            End Get
            Set
                Me.postingDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory. The 'PostingTime' forms part of the key to an existing Cash Book transaction.In order to locate the correct transaction for changing or reconciling/unreconciling this element must be supplied.
        '''</summary>
        Public Property PostingTime() As String
            Get
                Return Me.postingTimeField
            End Get
            Set
                Me.postingTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. This element is only relevant if reconciling a transaction. If the currency exchange rate has changed and the bank has re-valued your transaction according to the new rate, then this element allows you to enter the new  local currency equivalent. Any difference is posted to the Exchange Variance Account as defined against the SYSPRO Bank .
        '''If this element is not supplied, the current value on the Cash Book SYSPRO file is used as the default. If spaces or nulls are supplied , the value defaults to zero.
        '''
        '''</summary>
        Public Property LocalCurrencyBankEquivalent() As String
            Get
                Return Me.localCurrencyBankEquivalentField
            End Get
            Set
                Me.localCurrencyBankEquivalentField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostCbDepositsWithdrawalsItemUnreconByPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodToUnreconField As PostCbDepositsWithdrawalsItemUnreconByPeriodPeriodToUnrecon
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unreconcileDepositsField As PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileDeposits
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unreconcileWithdrawalsField As PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileWithdrawals
        
        Public Sub New()
            MyBase.New
            Me.periodToUnreconField = PostCbDepositsWithdrawalsItemUnreconByPeriodPeriodToUnrecon.C
            Me.unreconcileDepositsField = PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileDeposits.N
            Me.unreconcileWithdrawalsField = PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileWithdrawals.N
        End Sub
        
        '''<summary>
        '''This element is mandatory . This is the SYSPRO bank against which a deposit or withdrawal is being added, changed, reconciled or unreconciled. The value of this element must be a valid SYSPRO bank. If the element is not supplied or if spaces are supplied the bank defined against the SYSPRO operator is used as the default.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemUnreconByPeriodPeriodToUnrecon.C)>  _
        Public Property PeriodToUnrecon() As PostCbDepositsWithdrawalsItemUnreconByPeriodPeriodToUnrecon
            Get
                Return Me.periodToUnreconField
            End Get
            Set
                Me.periodToUnreconField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileDeposits.N)>  _
        Public Property UnreconcileDeposits() As PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileDeposits
            Get
                Return Me.unreconcileDepositsField
            End Get
            Set
                Me.unreconcileDepositsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileWithdrawals.N)>  _
        Public Property UnreconcileWithdrawals() As PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileWithdrawals
            Get
                Return Me.unreconcileWithdrawalsField
            End Get
            Set
                Me.unreconcileWithdrawalsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemUnreconByPeriodPeriodToUnrecon
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileDeposits
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostCbDepositsWithdrawalsItemUnreconByPeriodUnreconcileWithdrawals
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
