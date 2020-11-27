Imports Codewell.SysproIntegration

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.InventoryPrimaryQuery.InventoryAvailableToPromiseQuery.QueryData



'''<summary>
'''This is a test class for QueryTest and is intended
'''to contain all QueryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class QueryTest


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

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    '''<summary>
    '''A test for the Post method of the ATP Query
    '''</summary>
    <TestMethod()> _
    Public Sub ATPPostTest()
        Dim target As Query = New Query ' TODO: Initialize to an appropriate value
        Dim blnThrowExceptionOnErrorInXMLOut As Boolean = False ' TODO: Initialize to an appropriate value
        With target
            .QueryActionType = CommonEnums.ActionType_Query.Query
            .Key.StockCode = "A100"
            .[Option].Warehouse = "E"
            .Post(blnThrowExceptionOnErrorInXMLOut)
        End With

        Assert.AreNotEqual(Of String)("", target.XmlOut, "No XMLOut was generated!")
        Assert.IsFalse(target.XmlOut.Contains("Error"), "There are errors in the XMLOut")
    End Sub

End Class
