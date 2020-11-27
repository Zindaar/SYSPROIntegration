Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting

<TestClass()> _
Public Class TestDispatchNotePosting

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestThatDispatchNotePostingContainsValidParams()

        Dim dnHeader As New SalesOrderDispatchNotePosting.Data.PostDispatchNotesDispatchNoteDispatchHeader
        With dnHeader
            .SalesOrder = "123456"
        End With

        Dim dnMerchLine As New SalesOrderDispatchNotePosting.Data.PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine
        With dnMerchLine
            .SalesOrderLine = 1
        End With

        Dim dn As New SalesOrderDispatchNotePosting.Data.PostDispatchNotesDispatchNote
        dn.DispatchHeader = dnHeader
        dn.DispatchDetails.MerchandiseLineCollection.Add(dnMerchLine)

        Dim dnPosting As New SalesOrderDispatchNotePosting.Data.PostDispatchNotes
        With dnPosting
            .DispatchNoteCollection.Add(dn)

            With .Params
                .BasisForDispatch = SalesOrderDispatchNotePosting.Params.PostDispatchNotesParametersBasisForDispatch.B
                .ValidateOnly = SalesOrderDispatchNotePosting.Params.PostDispatchNotesParametersValidateOnly.N
            End With
            .Post(False)
            'An error here probably means that SYSPRO will not allow this order to go into a status of 1...so try the posting again putting it in a status of 2 instead of 1
        End With

        Assert.IsTrue(dnPosting.XmlParam.Contains("<ValidateOnly>"), "Params does NOT contain ValidateOnly")

    End Sub

End Class
