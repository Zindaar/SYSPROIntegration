Imports Codewell.SysproIntegration

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting.CreditNoteFromExistingInvoiceDispatchNote.Data



'''<summary>
'''This is a test class for SOCreditNoteHeaderTest and is intended
'''to contain all SOCreditNoteHeaderTest Unit Tests
'''</summary>
<TestClass()> _
Public Class SOCreditNoteFromInvoiceTest


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
        Dim target As New PostCreditFromInvoice


        
        Dim item1 As New PostCreditFromInvoiceItem
        item1.InvoiceNumber = "123INV"
        Dim line1 As New PostCreditFromInvoiceItemLines()
        line1.LineNumber = "1"
        item1.Lines.Add(line1)
        Dim line2 As New PostCreditFromInvoiceItemLines()
        line2.LineNumber = "2"
        item1.Lines.Add(line2)

        target.Item = item1

        Assert.IsFalse(target.XmlOut.Contains("Error"), target.XmlOut)

    End Sub


End Class
