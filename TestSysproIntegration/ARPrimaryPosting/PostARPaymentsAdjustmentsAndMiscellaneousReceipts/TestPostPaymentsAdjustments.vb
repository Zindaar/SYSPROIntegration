Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.ARPrimaryPosting

<TestClass()> Public Class TestPostPaymentsAdjustments

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
    Public Sub TestPostPaymentsAdjustmentsForNoOccurrenceOfItemCollectionInXML()
        Dim Payment As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.Payment
        Dim postObject As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.PostArPayment

        With postObject.Params
            .ValidateOnly = AccountsReceivableInvoicePosting.Params.ValidateOnly.Y
            .PostingPeriod = AccountsReceivableInvoicePosting.Params.PostingPeriod.C
            .IgnoreWarnings = AccountsReceivableInvoicePosting.Params.IgnoreWarnings.N
        End With

        With Payment
            .Bank = "FB"
            .Customer = "000010"
        End With

        
        postObject.ItemCollection.Add(Payment)
        
        Assert.IsFalse(postObject.XMLData.Contains("ItemCollection"), "Sorry, the XML contains ItemCollection")

    End Sub

    <TestMethod()> _
    Public Sub TestPostPaymentsAdjustmentsThatEachItemIsIndividuallySpecified()
        Dim Payment As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.Payment
        Dim adjustment As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.Adjustments
        Dim postObject As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.PostArPayment

        With postObject.Params
            .ValidateOnly = AccountsReceivableInvoicePosting.Params.ValidateOnly.Y
            .PostingPeriod = AccountsReceivableInvoicePosting.Params.PostingPeriod.C
            .IgnoreWarnings = AccountsReceivableInvoicePosting.Params.IgnoreWarnings.N
        End With

        With Payment
            .Bank = "FB"
            .Customer = "000010"
        End With

        With adjustment
            .Bank = "FB"
            .Customer = "000010"
        End With

        postObject.ItemCollection.Add(Payment)
        postObject.ItemCollection.Add(adjustment)

        Dim expectedItems As Integer = 2

        Dim xmlDoc As System.Xml.XmlDocument
        Dim xmlNodeList As System.Xml.XmlNodeList

        xmlDoc = New System.Xml.XmlDocument
        xmlDoc.LoadXml(postObject.XMLData)

        xmlNodeList = xmlDoc.DocumentElement.SelectNodes("//Item")

        Assert.AreEqual(expectedItems, xmlNodeList.Count, "Sorry, count of items is not as expected")

    End Sub

    <TestMethod()> _
    Public Sub TestPostPaymentsAdjustmentsThatItemNodeNotDuplicated()
        Dim Payment As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.Payment
        Dim adjustment As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.Adjustments
        Dim postObject As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.PostArPayment

        With postObject.Params
            .ValidateOnly = AccountsReceivableInvoicePosting.Params.ValidateOnly.Y
            .PostingPeriod = AccountsReceivableInvoicePosting.Params.PostingPeriod.C
            .IgnoreWarnings = AccountsReceivableInvoicePosting.Params.IgnoreWarnings.N
        End With

        With Payment
            .Bank = "FB"
            .Customer = "000010"
        End With

        With adjustment
            .Bank = "FB"
            .Customer = "000010"
        End With

        postObject.ItemCollection.Add(Payment)
        postObject.ItemCollection.Add(adjustment)

        Dim expectedFirstNode As String = "Payment"
        Dim expectedSecondNode As String = "Adjustments"

        Dim xmlDoc As System.Xml.XmlDocument
        Dim xmlNodeList As System.Xml.XmlNodeList

        xmlDoc = New System.Xml.XmlDocument
        xmlDoc.LoadXml(postObject.XMLData)

        xmlNodeList = xmlDoc.DocumentElement.SelectNodes("//Item")


        Assert.AreEqual(expectedFirstNode, xmlNodeList.Item(0).FirstChild.Name)
        Assert.AreEqual(expectedSecondNode, xmlNodeList.Item(1).FirstChild.Name)

    End Sub

    <TestMethod()> _
    Public Sub TestPostPaymentsAdjustmentsThatValidateOnlyIsYWhenSetSo()
        Dim postObject As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.PostArPayment

        With postObject.Params
            .ValidateOnly = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.ValidateOnly.Y
            .PostingPeriod = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.PostingPeriod.C
            .IgnoreWarnings = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.IgnoreWarnings.N
        End With

        Debug.WriteLine(postObject.XmlParam)

        Assert.IsTrue(postObject.XmlParam.Contains("<ValidateOnly>Y"), "ValidateOnly is NOT Y")

    End Sub

    <TestMethod()> _
    Public Sub TestPostPaymentsAdjustmentsThatValidateOnlyIsNWhenSetSo()
        Dim postObject As New PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Data.PostArPayment

        With postObject.Params
            .ValidateOnly = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.ValidateOnly.N
            .PostingPeriod = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.PostingPeriod.C
            .IgnoreWarnings = PostARPaymentsAdjustmentsAndMiscellaneousReceipts.Params.IgnoreWarnings.N
        End With

        Debug.WriteLine(postObject.XmlParam)

        Assert.IsTrue(postObject.XmlParam.Contains("<ValidateOnly>N"), "ValidateOnly is NOT N")

    End Sub

End Class
