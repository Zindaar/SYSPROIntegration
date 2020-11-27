Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.PurchaseOrderLctSystem.LctShipmentMaintenance.Data



'''<summary>
'''This is a test class for ShipmentMaintenanceTest and is intended
'''to contain all ShipmentMaintenanceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ShipmentMaintenanceTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
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
    '''A test for StripEpicentreFields
    '''</summary>
    <TestMethod(), DeploymentItem("PurchaseOrderLctSystem\ShipmentMaintenance\ShipmentMaintenanceTestData.xml")> _
    Public Sub StripEpicentreFieldsTest()
        Dim target As New ShipmentMaintenance

        Dim xmlData As String = String.Empty ' TODO: Initialize to an appropriate value
        Using stream As New System.IO.StreamReader("ShipmentMaintenanceTestData.xml")
            xmlData = stream.ReadToEnd()
        End Using

        Assert.IsTrue(xmlData.Contains("<Route>"), "xmlData should contain <Route> to start with")
        Assert.IsTrue(xmlData.Contains("</Route>"), "xmlData should contain </Route> to start with")

        Assert.IsTrue(xmlData.Contains("<VesselDescription>"), "xmlData should contain <VesselDescription> to start with")
        Assert.IsTrue(xmlData.Contains("</VesselDescription>"), "xmlData should contain </VesselDescription> to start with")

        Assert.IsTrue(xmlData.Contains("<EstimatedArrivalDate>"), "xmlData should contain <EstimatedArrivalDate> to start with")
        Assert.IsTrue(xmlData.Contains("</EstimatedArrivalDate>"), "xmlData should contain </EstimatedArrivalDate> to start with")

        Assert.IsTrue(xmlData.Contains("<ChargeableWeight>"), "xmlData should contain <ChargeableWeight> to start with")
        Assert.IsTrue(xmlData.Contains("</ChargeableWeight>"), "xmlData should contain </ChargeableWeight> to start with")

        Dim actual As String
        actual = target.StripEpicentreFields(xmlData)
        Assert.IsFalse(actual.Contains("<Route>"), "result should NOT contain <Route>")
        Assert.IsFalse(actual.Contains("</Route>"), "xmlData should NOT contain </Route>")

        Assert.IsFalse(actual.Contains("<VesselDescription>"), "result should NOT contain <VesselDescription>")
        Assert.IsFalse(actual.Contains("</VesselDescription>"), "xmlData should NOT contain </VesselDescription>")

        Assert.IsFalse(actual.Contains("<EstimatedArrivalDate>"), "result should NOT contain <EstimatedArrivalDate>")
        Assert.IsFalse(actual.Contains("</EstimatedArrivalDate>"), "xmlData should NOT contain </EstimatedArrivalDate>")

        Assert.IsFalse(actual.Contains("<ChargeableWeight>"), "result should NOT contain <ChargeableWeight>")
        Assert.IsFalse(actual.Contains("</ChargeableWeight>"), "xmlData should NOT contain </ChargeableWeight>")

    End Sub

    <TestMethod(), DeploymentItem("PurchaseOrderLctSystem\ShipmentMaintenance\ShipmentMaintenanceTestData.xml")> _
    Public Sub StripEpicentreFieldsTestWhenCalledInXMLData()
        Dim target As ShipmentMaintenance

        Using stream As New System.IO.StreamReader("ShipmentMaintenanceTestData.xml")
            Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(ShipmentMaintenance))

            target = serializer.Deserialize(stream)
        End Using

        
        Dim actual As String
        actual = target.XMLData
        Assert.IsFalse(actual.Contains("<Route>"), "result should NOT contain <Route>")
        Assert.IsFalse(actual.Contains("</Route>"), "xmlData should NOT contain </Route>")

        Assert.IsFalse(actual.Contains("<VesselDescription>"), "result should NOT contain <VesselDescription>")
        Assert.IsFalse(actual.Contains("</VesselDescription>"), "xmlData should NOT contain </VesselDescription>")

        Assert.IsFalse(actual.Contains("<EstimatedArrivalDate>"), "result should NOT contain <EstimatedArrivalDate>")
        Assert.IsFalse(actual.Contains("</EstimatedArrivalDate>"), "xmlData should NOT contain </EstimatedArrivalDate>")

        Assert.IsFalse(actual.Contains("<ChargeableWeight>"), "result should NOT contain <ChargeableWeight>")
        Assert.IsFalse(actual.Contains("</ChargeableWeight>"), "xmlData should NOT contain </ChargeableWeight>")

    End Sub
End Class
