Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryQuery.GLJournalQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "GENQJR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeField As QueryOptionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintField As QueryOptionReprint
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updatePrintedFlagField As QueryOptionUpdatePrintedFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private yearField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private periodSelectionField As QueryOptionPeriodSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerPeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalNumberSelectionField As QueryOptionJournalNumberSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromJournalNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toJournalNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private authorizedJournalsField As QueryOptionAuthorizedJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printNormalJournalsField As QueryOptionPrintNormalJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printProvisionalJournalsField As QueryOptionPrintProvisionalJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printUserDefinedJournalsField As QueryOptionPrintUserDefinedJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printInterCompanyJournalsField As QueryOptionPrintInterCompanyJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printPeriodEndAdjustmentsField As QueryOptionPrintPeriodEndAdjustments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printAuditorsAdjustmentsField As QueryOptionPrintAuditorsAdjustments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printStatisticalJournalsField As QueryOptionPrintStatisticalJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printAlternateCurrencyJournalsField As QueryOptionPrintAlternateCurrencyJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printJournalsNotPostedField As QueryOptionPrintJournalsNotPosted
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printJournalsOnHoldField As QueryOptionPrintJournalsOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printCancelledJournalsField As QueryOptionPrintCancelledJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private printPostedJournalsField As QueryOptionPrintPostedJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private standardJournalSelectionField As QueryOptionStandardJournalSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private standardFromField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private standardToField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recurringJournalSelectionField As QueryOptionRecurringJournalSelection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recurringFromField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recurringToField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private recurringAuthJournalsField As QueryOptionRecurringAuthJournals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newPagePerJournalField As QueryOptionNewPagePerJournal
        
        Public Sub New()
            MyBase.New
            Me.typeField = QueryOptionType.N
            Me.reprintField = QueryOptionReprint.N
            Me.updatePrintedFlagField = QueryOptionUpdatePrintedFlag.N
            Me.yearField = " "
            Me.periodSelectionField = QueryOptionPeriodSelection.A
            Me.journalNumberSelectionField = QueryOptionJournalNumberSelection.A
            Me.fromJournalNumberField = "1"
            Me.toJournalNumberField = "99999"
            Me.authorizedJournalsField = QueryOptionAuthorizedJournals.B
            Me.printNormalJournalsField = QueryOptionPrintNormalJournals.Y
            Me.printProvisionalJournalsField = QueryOptionPrintProvisionalJournals.Y
            Me.printUserDefinedJournalsField = QueryOptionPrintUserDefinedJournals.Y
            Me.printInterCompanyJournalsField = QueryOptionPrintInterCompanyJournals.Y
            Me.printPeriodEndAdjustmentsField = QueryOptionPrintPeriodEndAdjustments.Y
            Me.printAuditorsAdjustmentsField = QueryOptionPrintAuditorsAdjustments.Y
            Me.printStatisticalJournalsField = QueryOptionPrintStatisticalJournals.Y
            Me.printAlternateCurrencyJournalsField = QueryOptionPrintAlternateCurrencyJournals.Y
            Me.printJournalsNotPostedField = QueryOptionPrintJournalsNotPosted.Y
            Me.printJournalsOnHoldField = QueryOptionPrintJournalsOnHold.Y
            Me.printCancelledJournalsField = QueryOptionPrintCancelledJournals.Y
            Me.printPostedJournalsField = QueryOptionPrintPostedJournals.Y
            Me.standardJournalSelectionField = QueryOptionStandardJournalSelection.A
            Me.recurringJournalSelectionField = QueryOptionRecurringJournalSelection.A
            Me.recurringAuthJournalsField = QueryOptionRecurringAuthJournals.B
            Me.newPagePerJournalField = QueryOptionNewPagePerJournal.N
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionType.N)>  _
        Public Property Type() As QueryOptionType
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionReprint.N)>  _
        Public Property Reprint() As QueryOptionReprint
            Get
                Return Me.reprintField
            End Get
            Set
                Me.reprintField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionUpdatePrintedFlag.N)>  _
        Public Property UpdatePrintedFlag() As QueryOptionUpdatePrintedFlag
            Get
                Return Me.updatePrintedFlagField
            End Get
            Set
                Me.updatePrintedFlagField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(" ")>  _
        Public Property Year() As String
            Get
                Return Me.yearField
            End Get
            Set
                Me.yearField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPeriodSelection.A)>  _
        Public Property PeriodSelection() As QueryOptionPeriodSelection
            Get
                Return Me.periodSelectionField
            End Get
            Set
                Me.periodSelectionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LedgerPeriod() As String
            Get
                Return Me.ledgerPeriodField
            End Get
            Set
                Me.ledgerPeriodField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionJournalNumberSelection.A)>  _
        Public Property JournalNumberSelection() As QueryOptionJournalNumberSelection
            Get
                Return Me.journalNumberSelectionField
            End Get
            Set
                Me.journalNumberSelectionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute("1")>  _
        Public Property FromJournalNumber() As String
            Get
                Return Me.fromJournalNumberField
            End Get
            Set
                Me.fromJournalNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute("99999")>  _
        Public Property ToJournalNumber() As String
            Get
                Return Me.toJournalNumberField
            End Get
            Set
                Me.toJournalNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionAuthorizedJournals.B)>  _
        Public Property AuthorizedJournals() As QueryOptionAuthorizedJournals
            Get
                Return Me.authorizedJournalsField
            End Get
            Set
                Me.authorizedJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintNormalJournals.Y)>  _
        Public Property PrintNormalJournals() As QueryOptionPrintNormalJournals
            Get
                Return Me.printNormalJournalsField
            End Get
            Set
                Me.printNormalJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintProvisionalJournals.Y)>  _
        Public Property PrintProvisionalJournals() As QueryOptionPrintProvisionalJournals
            Get
                Return Me.printProvisionalJournalsField
            End Get
            Set
                Me.printProvisionalJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintUserDefinedJournals.Y)>  _
        Public Property PrintUserDefinedJournals() As QueryOptionPrintUserDefinedJournals
            Get
                Return Me.printUserDefinedJournalsField
            End Get
            Set
                Me.printUserDefinedJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintInterCompanyJournals.Y)>  _
        Public Property PrintInterCompanyJournals() As QueryOptionPrintInterCompanyJournals
            Get
                Return Me.printInterCompanyJournalsField
            End Get
            Set
                Me.printInterCompanyJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintPeriodEndAdjustments.Y)>  _
        Public Property PrintPeriodEndAdjustments() As QueryOptionPrintPeriodEndAdjustments
            Get
                Return Me.printPeriodEndAdjustmentsField
            End Get
            Set
                Me.printPeriodEndAdjustmentsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintAuditorsAdjustments.Y)>  _
        Public Property PrintAuditorsAdjustments() As QueryOptionPrintAuditorsAdjustments
            Get
                Return Me.printAuditorsAdjustmentsField
            End Get
            Set
                Me.printAuditorsAdjustmentsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintStatisticalJournals.Y)>  _
        Public Property PrintStatisticalJournals() As QueryOptionPrintStatisticalJournals
            Get
                Return Me.printStatisticalJournalsField
            End Get
            Set
                Me.printStatisticalJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintAlternateCurrencyJournals.Y)>  _
        Public Property PrintAlternateCurrencyJournals() As QueryOptionPrintAlternateCurrencyJournals
            Get
                Return Me.printAlternateCurrencyJournalsField
            End Get
            Set
                Me.printAlternateCurrencyJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintJournalsNotPosted.Y)>  _
        Public Property PrintJournalsNotPosted() As QueryOptionPrintJournalsNotPosted
            Get
                Return Me.printJournalsNotPostedField
            End Get
            Set
                Me.printJournalsNotPostedField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintJournalsOnHold.Y)>  _
        Public Property PrintJournalsOnHold() As QueryOptionPrintJournalsOnHold
            Get
                Return Me.printJournalsOnHoldField
            End Get
            Set
                Me.printJournalsOnHoldField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintCancelledJournals.Y)>  _
        Public Property PrintCancelledJournals() As QueryOptionPrintCancelledJournals
            Get
                Return Me.printCancelledJournalsField
            End Get
            Set
                Me.printCancelledJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionPrintPostedJournals.Y)>  _
        Public Property PrintPostedJournals() As QueryOptionPrintPostedJournals
            Get
                Return Me.printPostedJournalsField
            End Get
            Set
                Me.printPostedJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionStandardJournalSelection.A)>  _
        Public Property StandardJournalSelection() As QueryOptionStandardJournalSelection
            Get
                Return Me.standardJournalSelectionField
            End Get
            Set
                Me.standardJournalSelectionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property StandardFrom() As String
            Get
                Return Me.standardFromField
            End Get
            Set
                Me.standardFromField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property StandardTo() As String
            Get
                Return Me.standardToField
            End Get
            Set
                Me.standardToField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionRecurringJournalSelection.A)>  _
        Public Property RecurringJournalSelection() As QueryOptionRecurringJournalSelection
            Get
                Return Me.recurringJournalSelectionField
            End Get
            Set
                Me.recurringJournalSelectionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property RecurringFrom() As String
            Get
                Return Me.recurringFromField
            End Get
            Set
                Me.recurringFromField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property RecurringTo() As String
            Get
                Return Me.recurringToField
            End Get
            Set
                Me.recurringToField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionRecurringAuthJournals.B)>  _
        Public Property RecurringAuthJournals() As QueryOptionRecurringAuthJournals
            Get
                Return Me.recurringAuthJournalsField
            End Get
            Set
                Me.recurringAuthJournalsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.ComponentModel.DefaultValueAttribute(QueryOptionNewPagePerJournal.N)>  _
        Public Property NewPagePerJournal() As QueryOptionNewPagePerJournal
            Get
                Return Me.newPagePerJournalField
            End Get
            Set
                Me.newPagePerJournalField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        S
        
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
    Public Enum QueryOptionReprint
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        O
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionUpdatePrintedFlag
        
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
    Public Enum QueryOptionPeriodSelection
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionJournalNumberSelection
        
        '''<remarks/>
        A
        
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
    Public Enum QueryOptionAuthorizedJournals
        
        '''<remarks/>
        B
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintNormalJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintProvisionalJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintUserDefinedJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintInterCompanyJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintPeriodEndAdjustments
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintAuditorsAdjustments
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintStatisticalJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintAlternateCurrencyJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintJournalsNotPosted
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintJournalsOnHold
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintCancelledJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionPrintPostedJournals
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionStandardJournalSelection
        
        '''<remarks/>
        A
        
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
    Public Enum QueryOptionRecurringJournalSelection
        
        '''<remarks/>
        A
        
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
    Public Enum QueryOptionRecurringAuthJournals
        
        '''<remarks/>
        B
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionNewPagePerJournal
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
