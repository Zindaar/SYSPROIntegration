Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.ContactManagementPrimaryPosting.ContactManagementAccountMaintenance.Data

<TestClass()> Public Class TestContactMngtAccountMaintenance

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

    <TestMethod()> Public Sub TestPostNewContact()
        Dim cnt As New SetupCmsAccount
        Dim cntItem As New Item
        cntItem.Key.Account = "000099"

        With cntItem
            .Name = "Main Account"
            .AccountOnHold = "N"
            .AccountType = "001"
            .Customer = "0000001"
            .CreditLimit = "0.00"
            .Salesperson = "001"
            .Branch = "10"
            .LineDiscCode = "1"
            .PoNumberMandatory = "N"
        End With

        cnt.ItemCollection.Add(cntItem)

        Assert.IsTrue(cnt.XMLData.Contains("<Key><Account>000099</Account>"), cnt.XMLData)

    End Sub

End Class
