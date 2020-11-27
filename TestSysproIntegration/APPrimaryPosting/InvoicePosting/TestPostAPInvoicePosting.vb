Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration

<TestClass()> Public Class TestPostAPInvoicePosting

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
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
        Common.CommonTestMethods.SetLogonParameters()
    End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region


    <TestMethod()> _
    Public Sub TestPostWithGLDistribution()

        Dim Postobj As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.PostApInvoice
        Dim APitem As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.Item
        Dim GLItem As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.LedgerDistribution
        With APitem
            .Invoice = "GRNxyz"
            .TransactionValue = 1000
            .Supplier = "0000010"
            .TransactionCode = APPrimaryPosting.AccountsPayableInvoicePosting.Data.TransactionCode.I
            .Notation = ""
            .TransactionReference = ""
            GLItem.LedgerCode = "1100120"
            GLItem.LedgerValue = 1000
            .LedgerDistributionCollection.Add(GLItem)
        End With

        Postobj.ItemCollection = New List(Of APPrimaryPosting.AccountsPayableInvoicePosting.Data.Item)

        With Postobj.Params
            .ApplyIfEntireDocumentValid = APPrimaryPosting.AccountsPayableInvoicePosting.Params.ApplyIfEntireDocumentValid.Y
            .IgnoreWarnings = APPrimaryPosting.AccountsPayableInvoicePosting.Params.IgnoreWarnings.Y
            .ValidateOnly = APPrimaryPosting.AccountsPayableInvoicePosting.Params.ValidateOnly.Y
        End With

        Postobj.ItemCollection.Add(APitem)

        Postobj.Post(False)

        Assert.IsFalse(Postobj.XmlOut.Contains("Error"), Postobj.XmlOut)

    End Sub

    <TestMethod()>
    Public Sub TestXMLHasBlankTaxCode()

        Dim Postobj As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.PostApInvoice
        Dim APitem As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.Item
        Dim GLItem As New APPrimaryPosting.AccountsPayableInvoicePosting.Data.LedgerDistribution
        With APitem
            .Invoice = "GRNxyz"
            .TransactionValue = 1000
            .Supplier = "0000010"
            '.TransactionCode = APPrimaryPosting.AccountsPayableInvoicePosting.Data.TransactionCode.I
            .Notation = ""
            .TransactionReference = ""
            GLItem.LedgerCode = "1100120"
            GLItem.LedgerValue = 1000
            .LedgerDistributionCollection.Add(GLItem)
        End With

        Postobj.ItemCollection.Add(APitem)


        Assert.IsTrue(Postobj.XMLData.Contains("<TaxCode />"), Postobj.XMLData)

    End Sub


End Class
