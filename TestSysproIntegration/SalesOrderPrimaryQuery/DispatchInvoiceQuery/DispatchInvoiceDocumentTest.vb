Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output



'''<summary>
'''This is a test class for DispatchInvoiceDocumentTest and is intended
'''to contain all DispatchInvoiceDocumentTest Unit Tests
'''</summary>
<TestClass()> _
Public Class DispatchInvoiceDocumentTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    <ClassInitialize()> _
    Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
        Codewell.SysproIntegration.LogonDetails.SetLogonDetails("henk", "asd123!", "S", "NONO", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.WebServices)
    End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for NewFromSYSPRODispatchInvoiceQuery
    '''</summary>
    <TestMethod()> _
    Public Sub NewFromSYSPRODispatchInvoiceQueryTest()
        Dim strdocumentNumber As String = "729922"
        Dim actual As DispatchInvoiceDocument
        actual = DispatchInvoiceDocument.NewFromSYSPRODispatchInvoiceQuery(strdocumentNumber)
        Assert.AreEqual(1, actual.MyDispatchInvoiceLineCollection.Count, "Wrong number of lines!")
        Assert.AreEqual("60651", CType(actual.MyDispatchInvoiceLineCollection.Item(0), MerchandiseLine).MStockCode, "Stock Code for line 1 not right")
        'Assert.AreEqual("32526", CType(actual.MyDispatchInvoiceLineCollection.Item(1), MerchandiseLine).MStockCode, "Stock Code for line 2 not right")
        'Assert.AreEqual(Of Decimal)(CDec(6803.34), CDec(actual.MyTotalSection.TotalInvAmtExclTax), "Total Ex Tax not right")
        'Assert.AreEqual(Of Decimal)(CDec(7755.81), CDec(actual.MyTotalSection.TotalInvoiceAmount), "Total invoice amount not right")
        'Assert.AreEqual(Of Decimal)(CDec(952.47), CDec(actual.MyTotalSection.TotalSalesTax), "Total sales tax not right")
    End Sub
End Class
