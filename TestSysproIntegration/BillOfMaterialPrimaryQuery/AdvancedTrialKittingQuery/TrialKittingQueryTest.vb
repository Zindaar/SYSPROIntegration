Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.BillOfMaterialPrimaryQuery.AdvancedTrialKittingQuery.Output



'''<summary>
'''This is a test class for TrialKittingQueryTest and is intended
'''to contain all TrialKittingQueryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class TrialKittingQueryTest


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
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
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
    Public Sub CreateFromXMLOut_UseSysproSampleXMLOut()

        Dim strXMLOut As String = My.Computer.FileSystem.ReadAllText("C:\My Documents\My Programming Support\SYSPRO E.Net Reference\BOMQTKOUT.XML")
        Dim actual As TrialKittingQuery
        actual = TrialKittingQuery.CreateFromXMLOut(strXMLOut)

        Dim expectedComponents As Integer = 1
        Dim expectedComponentLevels As Integer = 2
        Dim expectedSupplyDemands = 8
        Assert.AreEqual(expectedComponents, actual.ComponentCollection.Count)
        Assert.AreEqual(expectedComponentLevels, actual.ComponentCollection.Item(0).ComponentLevelCollection.Count)
        Assert.AreEqual(expectedSupplyDemands, actual.ComponentCollection.Item(0).SupplyDemandCollection.Count)
    End Sub
End Class
