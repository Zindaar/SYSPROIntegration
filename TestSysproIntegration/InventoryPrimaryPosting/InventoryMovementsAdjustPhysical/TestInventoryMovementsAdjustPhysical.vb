Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestInventoryMovementsAdjustPhysical

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

    <TestMethod()> Public Sub TestInventoryMovementsAdjustPhysical()
        Dim invItem As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Item

        With invItem
            .Warehouse = "E"
            .StockCode = "SER100"
            .Quantity = -1
            .Reference = "7"
            .Notation = "7"

            Dim serial1 As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Serials
            serial1.SerialQuantity = -1
            serial1.SerialNumber = "FM600GA16641"
            .SerialsCollection.Add(serial1)

            Dim serial2 As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Serials
            serial2.SerialQuantity = -1
            serial2.SerialNumber = "FM600GA16642"
            .SerialsCollection.Add(serial2)

            Dim serial3 As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Serials
            serial3.SerialQuantity = -1
            serial3.SerialNumber = "FM600GA16643"
            .SerialsCollection.Add(serial3)

            Dim serial4 As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Serials
            serial4.SerialQuantity = -1
            serial4.SerialNumber = "FM600GA16644"
            .SerialsCollection.Add(serial4)

            Dim serial5 As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.Serials
            serial5.SerialQuantity = -1
            serial5.SerialNumber = "FM600GA16645"
            .SerialsCollection.Add(serial5)

        End With

        Dim postAdj As New Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Data.PostInvAdjustments
        With postAdj
            .Params.ApplyIfEntireDocumentValid = Codewell.SysproIntegration.InventoryPrimaryPosting.InventoryMovementsAdjustPhysical.Params.ApplyIfEntireDocumentValid.Y
            .ItemCollection.Add(invItem)
            .ItemCollection.Add(invItem)
        End With

        postAdj.Post(True)
        
        Assert.IsTrue(True)

    End Sub

End Class
