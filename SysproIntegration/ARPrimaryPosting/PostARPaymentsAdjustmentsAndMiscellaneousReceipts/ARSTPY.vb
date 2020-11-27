Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace ARPrimaryPosting.PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyIfEntireDocumentValid
        
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
    Public Enum ApplySpecificBranch
        
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
    Public Enum AutoCalculateTax
        
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
    Public Enum AutoCorrectPaymentValue
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        U
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
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
    Public Enum IntegrateToCashBookInDetail
        
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
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoCorrectPaymentValueField As AutoCorrectPaymentValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applySpecificBranchField As ApplySpecificBranch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private areaToUseForLedgerIntegrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private integrateToCashBookInDetailField As IntegrateToCashBookInDetail
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private autoCalculateTaxField As AutoCalculateTax
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostingPeriod.C
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.N
            Me.autoCorrectPaymentValueField = AutoCorrectPaymentValue.N
            Me.applySpecificBranchField = ApplySpecificBranch.N
            Me.integrateToCashBookInDetailField = IntegrateToCashBookInDetail.N
            Me.autoCalculateTaxField = AutoCalculateTax.N
        End Sub
        
        '''<summary>
        '''Period to which transactions must be posted. Valid values are 'C' for current period, 'P' for previous period 1 and 'B' for before previous period 2.Default is 'C'
        '''</summary>
        Public Property PostingPeriod() As PostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings .  Default is 'N'. Valid values are 'N' or 'Y'.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether the entire document must be validated prior to any posting taking place. If set to 'N', each item is validated and rejected if in error or posted if correct. This is the fastest option. If set to 'Y', all items in the document are first validated.If the entire document is valid then items are posted.Default  is 'Y'. Valid values are 'Y' and 'N'.
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No posting will take place. If set to 'N', each item is validated and posting is performed based on the value of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As ValidateOnly)
                Me.validateOnlyField = value
            End Set
        End Property
        
        '''<summary>
        '''If a ‘N’ is supplied against this element , then the value supplied against 'PaymentValue' element must be fully distributed. If the value is not fully distributed, then the business object will reject the payment and give an error.
        '''If, however you do not want to get an error, you should supply ‘Y’ or 'U' against this element. If 'Y' is supplied,the payment value is then forced to be equal to the sum of the net values of each of the payments processed. If a 'U' is supplied then an 'unapplied' payment is automatically created for the undistributed value.If a ‘U’ is supplied then no error will be given and the undistributed  value will be created as an unapplied payment against the customer.The business object generates the invoice number to be allocated to the unapplied payment. The invoice numbers always starts ’_CRD’ and the ‘xx’ suffix is determined by getting the highest _CRD invoice number currently on file for the SYSPRO A/R customer, and incrementing this by one.  The default is 'N'. Valid values are 'N'  'Y' and 'U'.
        '''Please note that the value of this element is ignored if post dated checks have been selected for inclusion in the 'Item. The payment value + the value of the post dated checks must be fully distributed. If the value is not fully distributed you will get an error irrespective of the value supplied against this element.
        '''</summary>
        Public Property AutoCorrectPaymentValue() As AutoCorrectPaymentValue
            Get
                Return Me.autoCorrectPaymentValueField
            End Get
            Set
                Me.autoCorrectPaymentValueField = value
            End Set
        End Property
        
        '''<summary>
        '''This is only relevant for Miscellaneous receipts. If ‘N’ is supplied, then the branch supplied in 'MiscellaneousReceipt' 'Branch' element is used. If ‘Y’ then the branch supplied in 'BranchToUse element is used when posting a miscellaneous receipt. The default value is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ApplySpecificBranch() As ApplySpecificBranch
            Get
                Return Me.applySpecificBranchField
            End Get
            Set
                Me.applySpecificBranchField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if 'ApplySpecificBranch' element is 'Y'. It is the branch to be applied when posting a miscellaneous receipt. 
        '''Historically a 'blank' branch was valid in SYSPRO. If the user does not supply this element, or spaces or nulls are supplied against this element (and the user has selected to 'ApplySpecificBranch' Y), then the business object will assume that the branch to be used for miscellaneous receipts is branch ‘blank’.
        '''</summary>
        Public Property BranchToUse() As String
            Get
                Return Me.branchToUseField
            End Get
            Set
                Me.branchToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only used of SYSPRO G/L integration  is by both branch and geographic area, and you have selected 'Y' to 'ApplySpecificBranch'.
        '''</summary>
        Public Property AreaToUseForLedgerIntegration() As String
            Get
                Return Me.areaToUseForLedgerIntegrationField
            End Get
            Set
                Me.areaToUseForLedgerIntegrationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only used if in SYSPRO A/R Setup, payments are integrated to Cash Book by journal and the option ‘Allow operator override in A/R payments’ is selected( A/R setup/Integration tab).If the SYSPRO option is not selected, then the value of this element is completely ignored. A ‘Y’ against this element indicates that all payments processed will be integrated to Cash Book 'in detail' instead of ‘by journal’ as is defined in the SYSPRO A/R setup options. 
        '''If ‘N’ is supplied, then the SYSPRO A/R Setup options dictate the method by which payments are integrated to Cash Book. Valid values are 'N' and 'Y'. Default is 'N'. 
        '''
        '''</summary>
        Public Property IntegrateToCashBookInDetail() As IntegrateToCashBookInDetail
            Get
                Return Me.integrateToCashBookInDetailField
            End Get
            Set
                Me.integrateToCashBookInDetailField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only used if the SYSPRO A/R Setup 'Request tax portion for invoice adjustments/discounts' is set to 'Y'.  When processing a payment this element indicates whether the tax portion of the discount value is to be automatically calculated if the 'TaxPortionOfDiscount' element is not supplied.  When  processing an adjustment this element indicates whether the tax portion of the adjustment value is to be automatically calculated if the 'TaxPortionOfAdjustment' is not supplied. Valid values are 'N' and 'Y'. The default is 'N'. 
        '''</summary>
        Public Property AutoCalculateTax() As AutoCalculateTax
            Get
                Return Me.autoCalculateTaxField
            End Get
            Set
                Me.autoCalculateTaxField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PostingPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        B
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
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
    Partial Public Class PostArPayment
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This contains parameters.
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
