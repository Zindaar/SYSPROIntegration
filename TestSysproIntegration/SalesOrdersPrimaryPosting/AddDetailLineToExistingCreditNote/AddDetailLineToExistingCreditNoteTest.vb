Imports Codewell.SysproIntegration

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting.AddDetailLineToExistingCreditNote.Data



'''<summary>
'''This is a test class for SOCreditNoteHeaderTest and is intended
'''to contain all SOCreditNoteHeaderTest Unit Tests
'''</summary>
<TestClass()> _
Public Class AddDetailLineToExistingCreditNoteTest


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
        Common.CommonTestMethods.SetLogonParameters()
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


    <TestMethod()> _
    Public Sub PostTest()
        Dim target As New SOCreditNoteLine

        With target.Params
            .ApplyIfEntireDocumentValid = SalesOrdersPrimaryPosting.CreditNoteHeaderNotFromExistingInvoice.Params.SOCreditNoteHeaderParametersApplyIfEntireDocumentValid.Y
            .ValidateOnly = SalesOrdersPrimaryPosting.CreditNoteHeaderNotFromExistingInvoice.Params.SOCreditNoteHeaderParametersValidateOnly.Y
        End With

        Dim item1 As New Item
        item1.CreditNoteNumber = "800131"
        item1.StockCode = "B200"
        item1.Warehouse = "N"

        target.ItemCollection.Add(item1)


        Dim blnThrowExceptionOnErrorInXMLOut As Boolean = False
        target.Post(blnThrowExceptionOnErrorInXMLOut)
        Assert.IsTrue(target.XMLData.Contains("<CreditNoteNumber>800131</CreditNoteNumber>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XMLData.Contains("<StockCode>B200</StockCode>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XmlOut.Contains("<ItemsProcessed>000001</ItemsProcessed>"), "Should have processed 1 item")
        Assert.IsFalse(target.XmlOut.Contains("Error"), target.XmlOut)

    End Sub

    <TestMethod()> _
    Public Sub PostMultipleItemsTest()
        Dim target As New SOCreditNoteLine

        With target.Params
            .ApplyIfEntireDocumentValid = SalesOrdersPrimaryPosting.CreditNoteHeaderNotFromExistingInvoice.Params.SOCreditNoteHeaderParametersApplyIfEntireDocumentValid.Y
            .ValidateOnly = SalesOrdersPrimaryPosting.CreditNoteHeaderNotFromExistingInvoice.Params.SOCreditNoteHeaderParametersValidateOnly.Y
        End With

        Dim item1 As New Item
        item1.CreditNoteNumber = "800131"
        item1.StockCode = "B200"
        item1.Warehouse = "N"

        target.ItemCollection.Add(item1)

        Dim item2 As New Item
        item2.CreditNoteNumber = "800132"
        item2.Warehouse = "N"
        item2.StockCode = "A200"
        target.ItemCollection.Add(item2)


        Dim blnThrowExceptionOnErrorInXMLOut As Boolean = False
        target.Post(blnThrowExceptionOnErrorInXMLOut)

        Assert.IsTrue(target.XMLData.Contains("<CreditNoteNumber>800131</CreditNoteNumber>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XMLData.Contains("<StockCode>B200</StockCode>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XMLData.Contains("<CreditNoteNumber>800132</CreditNoteNumber>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XMLData.Contains("<StockCode>A200</StockCode>"), "Structure is not right!" & vbCrLf & target.XMLData)
        Assert.IsTrue(target.XmlOut.Contains("<ItemsProcessed>000002</ItemsProcessed>"), "Should have processed 2 items")
        Assert.IsFalse(target.XmlOut.Contains("Error"), target.XmlOut)


    End Sub

End Class
