Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryQuery

<TestClass()> _
Public Class TestSalesOrderValuationQuery

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestSOValueQuery()
        Dim obj As New SalesOrderValuationQuery.QueryData.Query
        With obj
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            '.Option.OrderHeader.Customer = "0000001"
            .Option.SalesOrder = "000792"
            .Post(True)
        End With

        Assert.IsNotNull(obj.XmlOut)
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
