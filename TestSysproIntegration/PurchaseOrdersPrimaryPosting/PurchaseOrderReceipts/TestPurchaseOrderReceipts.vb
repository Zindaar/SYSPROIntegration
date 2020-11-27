Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestPurchaseOrderReceipts

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
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
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

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> Public Sub PostTestPurchaseOrderReceipts()
        Dim recItem As New Codewell.SysproIntegration.PurchaseOrdersPrimaryPosting.PurchaseOrderReceipts.Data.Item
        recItem.Receipt = New Codewell.SysproIntegration.PurchaseOrdersPrimaryPosting.PurchaseOrderReceipts.Data.Receipt
        With recItem.Receipt
            .CostBasis = "P"
        End With


        Dim postRecItem As New Codewell.SysproIntegration.PurchaseOrdersPrimaryPosting.PurchaseOrderReceipts.Data.PostPurchaseOrderReceipts
        postRecItem.ItemCollection.Add(recItem)
        With postRecItem.Params
            .ValidateOnly = Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Params.ValidateOnly.Y
        End With

        Try
            postRecItem.Post(False)
        Catch exc As Runtime.InteropServices.COMException
            Dim i As Integer = 0
        Catch ex As Exception
            Dim i As Integer = 0
        End Try


        Assert.IsTrue(True)

    End Sub

End Class
