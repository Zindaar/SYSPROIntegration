Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.SalesOrdersPrimaryQuery.DispatchNoteQuery.QueryData.Output



'''<summary>
'''This is a test class for DispatchNoteDocumentTest and is intended
'''to contain all DispatchNoteDocumentTest Unit Tests
'''</summary>
<TestClass()> _
Public Class DispatchNoteDocumentTest


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
    '''A test for NewFromSYSPRODispatchNoteQuery
    '''</summary>
    <TestMethod()> _
    Public Sub NewFromSYSPRODispatchNoteQueryTest()
        Dim strDispatchNoteNumber As String = "599541/0001"
        Dim actual As DispatchNoteDocument
        actual = DispatchNoteDocument.NewFromSYSPRODispatchNoteQuery(strDispatchNoteNumber)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
