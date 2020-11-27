Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.GeneralLedgerPrimaryPosting.PostJournalsToGLSystemNormalProvisionalUserDefinedStatisticalAlternateCurrency

<TestClass()> _
Public Class TestPostGLJournal


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestPostGLJournal()

        Dim debitEntry As New Data.PostGlJournalItemJournalDetails
        debitEntry.LedgerCode = ""
        debitEntry.EntryAmount = 100
        debitEntry.Comment = "Debit comment"

        Dim creditEntry As New Data.PostGlJournalItemJournalDetails
        creditEntry.LedgerCode = ""
        creditEntry.EntryAmount = -100
        creditEntry.Comment = "Credit Comment"

        Dim item As New Data.PostGlJournalItem

        With item
            .JournalType = Data.PostGlJournalItemJournalType.N
            .CancelJournal = Data.PostGlJournalItemCancelJournal.N
            .HoldJournal = Data.PostGlJournalItemHoldJournal.N
            .JournalReference = "Test Ref"

            .SourceCode = "CA"
            .PostingYear = 2008
            .PostingPeriod = 8

            .Notation = "COS Adjustment Journal"

            .JournalDetailsCollection.Add(debitEntry)
            .JournalDetailsCollection.Add(creditEntry)
        End With

        Dim SYSJnl As New Data.PostGlJournal
        With SYSJnl
            With .Params
                .IgnoreWarnings = Params.PostGlJournalParametersIgnoreWarnings.N
                .ApplyIfEntireDocumentValid = Params.PostGlJournalParametersApplyIfEntireDocumentValid.Y
                .ValidateOnly = Params.PostGlJournalParametersValidateOnly.Y
                .ActionType = Params.PostGlJournalParametersActionType.A
            End With
            .Item = item
            .Post(True)
        End With

    End Sub


End Class
