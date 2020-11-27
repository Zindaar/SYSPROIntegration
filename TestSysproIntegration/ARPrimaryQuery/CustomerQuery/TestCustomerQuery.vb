Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration

<TestClass()> Public Class TestCustomerQuery

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

    <TestMethod()> Public Sub TestCustomerQueryQuery()

        Dim _Query As New ARPrimaryQuery.CustomerQuery.QueryData.Query
        _Query.Key.Customer = "000010"
        With _Query.Option
            .IncludeFutures = ARPrimaryQuery.CustomerQuery.QueryData.IncludeFutures.N
            .IncludeTransactions = ARPrimaryQuery.CustomerQuery.QueryData.IncludeTransactions.Y
            .IncludeTransactions = ARPrimaryQuery.CustomerQuery.QueryData.IncludeTransactions.Y
            .IncludeCheckPayments = ARPrimaryQuery.CustomerQuery.QueryData.IncludeCheckPayments.Y
            .IncludePostDated = ARPrimaryQuery.CustomerQuery.QueryData.IncludePostDated.Y
            .IncludeZeroBalances = ARPrimaryQuery.CustomerQuery.QueryData.IncludeZeroBalances.N
            .IncludeCustomForms = ARPrimaryQuery.CustomerQuery.QueryData.IncludeCustomForms.N
            .AsOfPeriod = ARPrimaryQuery.CustomerQuery.QueryData.AsOfPeriod.C
            .AgeingOption = ARPrimaryQuery.CustomerQuery.QueryData.OptionAgeingOption.S
            .AgeColumn1 = "30"
            .AgeColumn2 = "60"
            .AgeColumn3 = "90"
            .AgeColumn4 = "120"
            .AgeColumn5 = "150"
            .AgeColumn6 = "180"
            .AgeColumn7 = "210"

        End With
        _Query.QueryActionType = CommonEnums.ActionType_Query.Query
        _Query.Post(False)

        Debug.WriteLine(_Query.XmlOut)

        Assert.Inconclusive()
    End Sub

End Class
