Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestPostWIPJobReceipts

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

    <TestMethod()> Public Sub TestPostWIPJobReceipts()
        Dim jobItem As New Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceiptsItem

        With jobItem
            .Job = "123"
            .JobComplete = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceiptsItemJobComplete.Y
            .SalesOrderComplete = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceiptsItemSalesOrderComplete.Y
        End With

        Dim CreateWIPPostingObj As New Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceipts
        CreateWIPPostingObj.ItemsCollection.Add(jobItem)
        With CreateWIPPostingObj
            .Params.ApplyIfEntireDocumentValid = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Params.PostJobReceiptsParametersApplyIfEntireDocumentValid.Y
            .Params.ValidateOnly = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Params.PostJobReceiptsParametersValidateOnly.Y
        End With

        Try
            CreateWIPPostingObj.Post(True)
        Catch ex As Exception
            Assert.IsTrue(False, ex.Message)
        End Try

        Assert.IsTrue(True)

    End Sub

    <TestMethod()> _
    Public Sub TextXMLElementBlankNotRecognised()

        Dim jobItem As New Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceiptsItem

        With jobItem
            .Job = "12345"
            .Quantity = 1
            .InspectionFlag = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceiptsItemInspectionFlag.Y
        End With

        Dim CreateWIPPostingObj As New Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Data.PostJobReceipts
        CreateWIPPostingObj.ItemsCollection.Add(jobItem)
        With CreateWIPPostingObj.Params
            .ValidateOnly = Codewell.SysproIntegration.WipPrimaryPosting.WipJobReceipts.Params.PostJobReceiptsParametersValidateOnly.Y
        End With

        Try
            CreateWIPPostingObj.Post(True)
        Catch ex As Exception
            Assert.IsTrue(False, ex.Message)
        End Try
        
        Assert.IsTrue(True)
    End Sub

End Class
