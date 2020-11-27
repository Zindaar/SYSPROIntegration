Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryQuery

<TestClass()> _
Public Class TestSalesOrderInvoiceQuery

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestSOValueQuery()
        Dim query As New SalesOrderInvoiceQuery.QueryData.Query
        With query.Option
            .Reprint = SalesOrderInvoiceQuery.QueryData.QueryOptionReprint.Y
            .DocumentType = SalesOrderInvoiceQuery.QueryData.QueryOptionDocumentType.I
            .IncludeForms = SalesOrderInvoiceQuery.QueryData.QueryOptionIncludeForms.N
            .IncludeCustomerForms = SalesOrderInvoiceQuery.QueryData.QueryOptionIncludeCustomerForms.N
            .IncludeStockForms = SalesOrderInvoiceQuery.QueryData.QueryOptionIncludeStockForms.N
            .IncludeNotes = SalesOrderInvoiceQuery.QueryData.QueryOptionIncludeNotes.N
            .IgnorePrintStatus = SalesOrderInvoiceQuery.QueryData.QueryOptionIgnorePrintStatus.N
            .RoundMass = SalesOrderInvoiceQuery.QueryData.QueryOptionRoundMass.O
        End With

        With query.Filter
            .Branch.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterBranchFilterType.A
            .Customer.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterCustomerFilterType.L
            .Customer.FilterValue = "0000001"
            .SourceWarehouse.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterSourceWarehouseFilterType.A
            .TargetWarehouse.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterTargetWarehouseFilterType.A
            .OrderType.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterOrderTypeFilterType.A
            .CustomerPo.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterCustomerPoFilterType.A
            .InvoiceNumber.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterInvoiceNumberFilterType.L
            .InvoiceNumber.FilterValue = "100288"
            .GtrReference.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterGtrReferenceFilterType.A
            .SalesOrder.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterSalesOrderFilterType.A
            .InvoiceDate.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterInvoiceDateFilterType.A
            .Operator.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterOperatorFilterType.A
            .GeographicArea.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterGeographicAreaFilterType.A
        End With

        query.QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query

        Dim xmlData As String = query.XMLData
        Assert.IsFalse(xmlData.Contains("QueryActionType"), "The xmlData contains QueryActionType!")
        Assert.IsTrue(xmlData.Contains("<Reprint>Y</Reprint>"), "The xmlData does NOT contain ReprintY")

        query.Post(True)
        Dim xmlOut As String = query.XmlOut
        Assert.IsTrue(xmlOut.Contains("<DocumentNumber>100288</DocumentNumber>"), "Document not returned!")
    End Sub

    <TestMethod()> _
    Public Sub TestSOInvoiceQuery()
        Dim obj As New SalesOrderInvoiceQuery.QueryData.Query
        With obj
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            'Jaco This Reprint option is important.  If, according to SYSPRO, this invoice has not yet been printed,
            ' then you must pass No.  Then after invoking this Post, SYSRPO will flag the invoice has having been printed.
            ' Then if you want a reprint, you pass Yes.
            'If this setting is wrong SYSPRO will not return an invoice for you in the xmlout.
            .Option.Reprint = SalesOrderInvoiceQuery.QueryData.QueryOptionReprint.Y
            .Option.DocumentType = SalesOrderInvoiceQuery.QueryData.QueryOptionDocumentType.I
            .Option.IgnorePrintStatus = SalesOrderInvoiceQuery.QueryData.QueryOptionIgnorePrintStatus.Y
            .Filter.InvoiceNumber.FilterType = SalesOrderInvoiceQuery.QueryData.QueryFilterInvoiceNumberFilterType.L
            .Filter.InvoiceNumber.FilterValue = "000001"
            .Post(True)
        End With
        Assert.IsTrue(obj.XMLData.Contains("</Option>"))
        Assert.IsNotNull(obj.XmlOut)
    End Sub


End Class
