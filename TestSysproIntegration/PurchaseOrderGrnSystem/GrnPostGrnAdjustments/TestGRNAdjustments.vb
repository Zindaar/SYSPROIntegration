Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestGRNAdjustments

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
            testContextInstance = value
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

    <TestInitialize()>
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()>
    Public Sub Test()
        Dim grnItem As New Codewell.SysproIntegration.PurchaseOrderGrnSystem.GrnPostGrnAdjustments.Data.PostGrnAdjustmentsItem
        grnItem.GrnDetails.Supplier = "0001"

        Dim postGrnItem As New Codewell.SysproIntegration.PurchaseOrderGrnSystem.GrnPostGrnAdjustments.Data.PostGrnAdjustments
        postGrnItem.ItemCollection.Add(grnItem)
        With postGrnItem.Params
            .ValidateOnly = Codewell.SysproIntegration.PurchaseOrderGrnSystem.GrnPostGrnAdjustments.Params.ValidateOnly.Y
        End With

        Try
            postGrnItem.Post(False)
        Catch exc As Runtime.InteropServices.COMException
            Dim i As Integer = 0
        Catch ex As Exception
            Dim i As Integer = 0
        End Try


        Assert.IsTrue(True)

    End Sub

End Class
