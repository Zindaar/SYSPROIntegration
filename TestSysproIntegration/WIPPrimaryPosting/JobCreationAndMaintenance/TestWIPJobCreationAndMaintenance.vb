Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestWIPJobCreationAndMaintenance

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

    <TestMethod()> Public Sub TestWIPJobCreationAndMaintenance()
        Dim jobItem As New Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Data.Item
        With jobItem
            .Job = "00000573" 'Me.Job
            .ConfirmedFlag = Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Data.ConfirmedFlag.Y
        End With

        Dim coProduct As New Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Data.ItemCoProduct
        With coProduct
            .CoProductLine = 1
            .QtyToMake = 2
        End With

        jobItem.CoProductsCollection.Add(coProduct)

        Dim CreateWIPPostingObj As New Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Data.PostJob
        CreateWIPPostingObj.ItemCollection = New List(Of Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Data.Item)
        CreateWIPPostingObj.ItemCollection.Add(jobItem)
        With CreateWIPPostingObj.Params
            .ActionType = Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Params.ActionType.C
            .ValidateOnly = Codewell.SysproIntegration.WipPrimaryPosting.JobCreationAndMaintenance.Params.ValidateOnly.Y
        End With

        'Try
        CreateWIPPostingObj.Post(False)
        'Catch exc As Runtime.InteropServices.COMException
        '    Dim i As Integer = 0
        'Catch ex As Exception
        '    Dim i As Integer = 0
        'End Try


        Assert.IsTrue(CreateWIPPostingObj.XMLData.Contains("<CoProducts"), "CoProducts does not exist!")
        Assert.IsFalse(CreateWIPPostingObj.XMLData.Contains("<CoProductsCollection"), "CoProductsCollection exists!")

    End Sub

End Class
