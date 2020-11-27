Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderGrnSystem.GrnPostGrnAdjustments.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostGrnAdjustments
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As List(Of PostGrnAdjustmentsItem)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.Parameters

        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostGrnAdjustmentsItem)()
            End If
        End Sub

        '''<summary>
        '''This contains the parameters for Grn Details 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>
        Public Property ItemCollection() As List(Of PostGrnAdjustmentsItem)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "PORTGN"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters()
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostGrnAdjustments
                objParams = New Params.PostGrnAdjustments()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PostGrnAdjustmentsItem

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnDetailsField As GrnDetails

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private changeGrnSupplierField As ChangeGrnSupplier

        Public Sub New()
            MyBase.New
            If (Me.changeGrnSupplierField Is Nothing) Then
                Me.changeGrnSupplierField = New ChangeGrnSupplier()
            End If
            If (Me.grnDetailsField Is Nothing) Then
                Me.grnDetailsField = New GrnDetails()
            End If
        End Sub

        '''<summary>
        '''This contains the parameters for Grn Details
        '''</summary>
        Public Property GrnDetails() As GrnDetails
            Get
                Return Me.grnDetailsField
            End Get
            Set
                Me.grnDetailsField = Value
            End Set
        End Property

        '''<summary>
        '''This contains the parameters to change the Supplier on the GRN
        '''</summary>
        Public Property ChangeGrnSupplier() As ChangeGrnSupplier
            Get
                Return Me.changeGrnSupplierField
            End Get
            Set
                Me.changeGrnSupplierField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class GrnDetails

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private supplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnNumberField As Object

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnSourceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnJournalField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnJournalEntryField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private unmatchField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private adjustmentValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private referenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private deliveryNoteField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private journalNotationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private ledgerPasswordField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private withholdingTaxExpenseTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisEntryField As Object

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisLineEntryField As AnalysisLineEntry

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private eSignatureField As String

        Public Sub New()
            MyBase.New
            If (Me.analysisLineEntryField Is Nothing) Then
                Me.analysisLineEntryField = New AnalysisLineEntry()
            End If
        End Sub

        '''<summary>
        '''This element is mandatory and must contain the Supplier code to which the Grn will be associated.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnNumber element is mandatory.
        '''</summary>
        Public Property GrnNumber() As Object
            Get
                Return Me.grnNumberField
            End Get
            Set
                Me.grnNumberField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnSource element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnSource() As String
            Get
                Return Me.grnSourceField
            End Get
            Set
                Me.grnSourceField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnJournal element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnJournal() As String
            Get
                Return Me.grnJournalField
            End Get
            Set
                Me.grnJournalField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnJournalEntry element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnJournalEntry() As String
            Get
                Return Me.grnJournalEntryField
            End Get
            Set
                Me.grnJournalEntryField = Value
            End Set
        End Property

        '''<summary>
        '''This element, when selected, will unmatch the entered GRN if it is already matched. When set to Y this will be the only function performed .
        '''</summary>
        Public Property Unmatch() As String
            Get
                Return Me.unmatchField
            End Get
            Set
                Me.unmatchField = Value
            End Set
        End Property

        '''<summary>
        '''This element contains the value to be posted to the GRN
        '''</summary>
        Public Property AdjustmentValue() As String
            Get
                Return Me.adjustmentValueField
            End Get
            Set
                Me.adjustmentValueField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional when changing a GRN and contains the GRN reference
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional when adding a GRN and contains the  delivery note.
        '''</summary>
        Public Property DeliveryNote() As String
            Get
                Return Me.deliveryNoteField
            End Get
            Set
                Me.deliveryNoteField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional when changing a GRN and contains the notation.
        '''</summary>
        Public Property JournalNotation() As String
            Get
                Return Me.journalNotationField
            End Get
            Set
                Me.journalNotationField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory and must contain a valid Ledger code if Company is integrated to General Ledger in detail or summary.
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = Value
            End Set
        End Property

        '''<summary>
        '''This element is optional and must contain the password for the debit ledger code if that code is password-secured.
        '''</summary>
        Public Property LedgerPassword() As String
            Get
                Return Me.ledgerPasswordField
            End Get
            Set
                Me.ledgerPasswordField = Value
            End Set
        End Property

        '''<summary>
        '''Only applies if withholding tax is in use. Expense type G = Goods, S = Service
        '''</summary>
        Public Property WithholdingTaxExpenseType() As String
            Get
                Return Me.withholdingTaxExpenseTypeField
            End Get
            Set
                Me.withholdingTaxExpenseTypeField = Value
            End Set
        End Property

        '''<summary>
        '''If an analysis entry number has been assigned to this detail line, then use this element to store the analysis entry number. If an analysis Line entry is passed then that will overwrite the analysis number supplied in the AnalysisEntry element. 
        '''</summary>
        Public Property AnalysisEntry() As Object
            Get
                Return Me.analysisEntryField
            End Get
            Set
                Me.analysisEntryField = Value
            End Set
        End Property

        '''<summary>
        '''If IgnoreAnalysis is set to 'Y", this node and all it's elements are ignored. If you are supplying your own AnalysisEntry Number ensure that you have set IgnoreAnalysis to "Y"
        '''</summary>
        Public Property AnalysisLineEntry() As AnalysisLineEntry
            Get
                Return Me.analysisLineEntryField
            End Get
            Set
                Me.analysisLineEntryField = Value
            End Set
        End Property

        '''<summary>
        '''If required, this element must contain a GUID, for the eSignature system to accept the transaction as having been authenticated. The GUID format is in the format {36303032-3330-3031-3038-323434363433}, where the numbers can be replaced with any character. It is up to the developer to have requested a password to protect the transaction. An example is that a GUID associated with the act of entering a valid password could be obtained and presented.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class AnalysisLineEntry

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisCode1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisCode2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisCode3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisCode4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private analysisCode5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private startDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private endDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private entryAmountField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private commentField As String

        Public Property AnalysisCode1() As String
            Get
                Return Me.analysisCode1Field
            End Get
            Set
                Me.analysisCode1Field = Value
            End Set
        End Property

        Public Property AnalysisCode2() As String
            Get
                Return Me.analysisCode2Field
            End Get
            Set
                Me.analysisCode2Field = Value
            End Set
        End Property

        Public Property AnalysisCode3() As String
            Get
                Return Me.analysisCode3Field
            End Get
            Set
                Me.analysisCode3Field = Value
            End Set
        End Property

        Public Property AnalysisCode4() As String
            Get
                Return Me.analysisCode4Field
            End Get
            Set
                Me.analysisCode4Field = Value
            End Set
        End Property

        Public Property AnalysisCode5() As String
            Get
                Return Me.analysisCode5Field
            End Get
            Set
                Me.analysisCode5Field = Value
            End Set
        End Property

        Public Property StartDate() As String
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = Value
            End Set
        End Property

        Public Property EndDate() As String
            Get
                Return Me.endDateField
            End Get
            Set
                Me.endDateField = Value
            End Set
        End Property

        Public Property EntryAmount() As String
            Get
                Return Me.entryAmountField
            End Get
            Set
                Me.entryAmountField = Value
            End Set
        End Property

        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class ChangeGrnSupplier

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private supplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private newSupplierField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnNumberField As Object

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnSourceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnJournalField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private grnJournalEntryField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private changeAllGrnLinesField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private eSignatureField As String

        '''<summary>
        '''This element is mandatory and must contain the Supplier code to which the Grn will be associated.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = Value
            End Set
        End Property

        '''<summary>
        '''This element is mandatory when changing a Supplier on a GRN.
        '''</summary>
        Public Property NewSupplier() As String
            Get
                Return Me.newSupplierField
            End Get
            Set
                Me.newSupplierField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnNumber element is mandatory.
        '''</summary>
        Public Property GrnNumber() As Object
            Get
                Return Me.grnNumberField
            End Get
            Set
                Me.grnNumberField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnSource element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnSource() As String
            Get
                Return Me.grnSourceField
            End Get
            Set
                Me.grnSourceField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnJournal element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnJournal() As String
            Get
                Return Me.grnJournalField
            End Get
            Set
                Me.grnJournalField = Value
            End Set
        End Property

        '''<summary>
        '''The GrnJournalEntry element is mandatory if changing a GRN.
        '''</summary>
        Public Property GrnJournalEntry() As String
            Get
                Return Me.grnJournalEntryField
            End Get
            Set
                Me.grnJournalEntryField = Value
            End Set
        End Property

        '''<summary>
        '''This element will change the supplier on all GRN's with the same number
        '''</summary>
        Public Property ChangeAllGrnLines() As String
            Get
                Return Me.changeAllGrnLinesField
            End Get
            Set
                Me.changeAllGrnLinesField = Value
            End Set
        End Property

        '''<summary>
        '''If required, this element must contain a GUID, for the eSignature system to accept the transaction as having been authenticated. The GUID format is in the format {36303032-3330-3031-3038-323434363433}, where the numbers can be replaced with any character. It is up to the developer to have requested a password to protect the transaction. An example is that a GUID associated with the act of entering a valid password could be obtained and presented.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Item
    End Class
End Namespace
