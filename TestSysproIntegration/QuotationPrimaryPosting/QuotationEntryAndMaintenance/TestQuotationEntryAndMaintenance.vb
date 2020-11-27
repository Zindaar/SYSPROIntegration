Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.QuotationsPrimaryPosting

<TestClass()> _
Public Class TestQuotationEntryAndMaintenance


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestPostQuote()
        Dim qtItem As New Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.PostQuotationItem
        qtItem.QuotationHeader = New Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.PostQuotationItemQuotationHeader
        With qtItem.QuotationHeader
            .Customer = "1"
        End With
        Dim offer0 As New Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.Offer
        With offer0
            .OfferNumber = Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.OfferOfferNumber.Item1
            .Price = 500
            .Quantity = 2
            .QuantityUom = "EA"
        End With

        Dim det As New Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.PostQuotationItemQuotationDetailsStockLine
        With det
            .StockCode = "B100"
            .LineAction = Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.LineAction.A
            .Warehouse = "N"
            .DefaultOffer = Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.DefaultOffer.Item0
            .OfferCollection.Add(offer0)
        End With

        qtItem.QuotationDetails.StockLineCollection.Add(det)

        Dim bo As New Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Data.PostQuotation
        bo.ItemCollection.Add(qtItem)
        bo.Params.ActionType = Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Params.PostQuotationParametersActionType.A
        bo.Params.ValidateOnly = Codewell.SysproIntegration.QuotationsPrimaryPosting.QuotationEntryAndMaintenance.Params.PostQuotationParametersValidateOnly.Y
        bo.Post(True)

        'If we get here the validation worked!
        Assert.IsTrue(True)
    End Sub

    <TestMethod()> _
     Public Sub SetQuoteStatus()
        Dim postingStatusObject As New QuotationEntryAndMaintenance.Data.PostQuotation
        Dim itemStatusObject As New QuotationEntryAndMaintenance.Data.PostQuotationItem

        'Set the paramters
        With postingStatusObject.Params
            .ActionType = QuotationEntryAndMaintenance.Params.PostQuotationParametersActionType.C
            .ValidateOnly = QuotationEntryAndMaintenance.Params.PostQuotationParametersValidateOnly.N
            .IgnoreWarnings = QuotationEntryAndMaintenance.Params.PostQuotationParametersIgnoreWarnings.Y
        End With

        With itemStatusObject.QuotationHeader
            .Quote = "12345"
            .QuoteStatus = QuotationEntryAndMaintenance.Data.PostQuotationItemQuotationHeaderQuoteStatus.P
        End With

        postingStatusObject.ItemCollection.Add(itemStatusObject)

        Assert.IsTrue(postingStatusObject.XMLData.Contains("<QuoteStatus>P</QuoteStatus>"))
    End Sub
End Class
