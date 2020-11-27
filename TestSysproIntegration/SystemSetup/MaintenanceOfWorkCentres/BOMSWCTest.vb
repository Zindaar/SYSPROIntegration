Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class BOMSWCTest

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
    <TestInitialize()> _
    Public Sub SetLogonParameters()
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


    <TestMethod()> _
    Public Sub TestSingleItems()

        Dim setupObj As New Codewell.SysproIntegration.SystemSetup.MaintenanceOfWorkCenters.Data.SetupBomWorkCentre

        Dim newItem As New Codewell.SysproIntegration.SystemSetup.MaintenanceOfWorkCenters.Data.SetupBomWorkCentreItem
        setupObj.Params.ApplyIfEntireDocumentValid = Codewell.SysproIntegration.SystemSetup.MaintenanceOfWorkCenters.Params.SetupBomWorkCentreParametersApplyIfEntireDocumentValid.Y
        setupObj.Params.TriggerAps = Codewell.SysproIntegration.SystemSetup.MaintenanceOfWorkCenters.Params.SetupBomWorkCentreParametersTriggerAps.N

        newItem.Key.WorkCentre = "TESTWC"
        newItem.WorkOperators = "9"
        newItem.ProdUnits = "8"

        setupObj.ItemCollection.Add(newItem)

        setupObj.Post(False)

        Assert.IsTrue(setupObj.XMLData.Contains("<Item>"), setupObj.XMLData)
        Assert.IsTrue(setupObj.XMLData.Contains("<Key><WorkCentre>TESTWC</WorkCentre></Key>"), setupObj.XMLData)
        Assert.IsTrue(setupObj.XMLData.Contains("<WorkOperators>9</WorkOperators>"), setupObj.XMLData)
        Assert.IsTrue(setupObj.XMLData.Contains("<ProdUnits>8</ProdUnits>"), setupObj.XMLData)

    End Sub
End Class
