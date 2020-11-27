Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.WipPrimaryQuery



'''<summary>
'''This is a test class for WipQueryTest and is intended
'''to contain all WipQueryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class WipQueryTest


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


    '''<summary>
    '''A test for CreateFromXMLOut
    '''</summary>
    <TestMethod()> _
    Public Sub CreateWipQueryFromXMLOutTest()

        Dim strJob As String = "00000137"
        Dim expectedMaterialPostings As Integer = 5
        Dim strFirstMaterialPostingStockCode As String = "B111"
        Dim expectedLabourPostings As Integer = 3
        Dim strSecondLabourPostingWC As String = "MBQA"
        Dim expectedMaterialAllocations As Integer = 5
        Dim strFourthMaterialAllocationStockCode As String = "B114"
        Dim expectedLabourAllocations As Integer = 3
        Dim strThirdLabourAllocationWC As String = "MBCC"

        Dim strXMLOut As String = String.Empty

        Dim qry As New WipQuery.QueryData.Query
        With qry
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            .Key.Job = strJob
            .Option.IncludeMaterialTransactions = WipQuery.QueryData.IncludeMaterialTransactions.Y
            .Option.IncludeOperationTransactions = WipQuery.QueryData.IncludeOperationTransactions.Y
            .Option.IncludeMaterialAllocations = WipQuery.QueryData.IncludeMaterialAllocations.Y
            .Option.IncludeOperationAllocations = WipQuery.QueryData.IncludeOperationAllocations.Y
            .Post(False)
            strXMLOut = .XmlOut
        End With

        Dim actual As WipQuery.Output.WipQuery
        actual = WipQuery.Output.WipQuery.CreateFromXMLOut(strXMLOut)

        Assert.AreEqual(strJob, actual.JobHeader.Job)
        Assert.AreEqual(expectedMaterialPostings, actual.MaterialPostingCollection.Count, "Not 5 material postings")
        Assert.AreEqual(strFirstMaterialPostingStockCode, actual.MaterialPostingCollection.Item(0).MStockCode.Trim)
        Assert.AreEqual(expectedLabourPostings, actual.LabourIssueCollection.Count, "Not 3 material postings")
        Assert.AreEqual(strSecondLabourPostingWC, actual.LabourIssueCollection.Item(1).LWorkCentre.Trim)

        Assert.AreEqual(expectedMaterialAllocations, actual.MaterialAllocCollection.Count, "Not 5 material Allocations")
        Assert.AreEqual(strFourthMaterialAllocationStockCode, actual.MaterialAllocCollection.Item(3).StockCode.Trim)
        Assert.AreEqual(expectedLabourAllocations, actual.LabourAllocCollection.Count, "Not 3 material Allocations")
        Assert.AreEqual(strThirdLabourAllocationWC, actual.LabourAllocCollection.Item(2).WorkCentre.Trim)

    End Sub
End Class
