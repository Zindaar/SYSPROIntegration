Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.InventoryPrimaryQuery.InventoryAvailableToPromiseQuery



'''<summary>
'''This is a test class for AtpQueryTest and is intended
'''to contain all AtpQueryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class AtpQueryTest


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
    '''A test for creating an AtpQuery object from the XMLOut
    '''</summary>
    <TestMethod()> _
    Public Sub ATPQueryCreateFromXMLOutTest()
        Dim target As New QueryData.Query
        Dim blnThrowExceptionOnErrorInXMLOut As Boolean = False ' TODO: Initialize to an appropriate value
        With target
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            .Key.StockCode = "B100"
            .[Option].Warehouse = "FG"
            .Post(blnThrowExceptionOnErrorInXMLOut)
        End With

        Assert.AreNotEqual(Of String)("", target.XmlOut, "No XMLOut was generated!")
        Assert.IsFalse(target.XmlOut.Contains("Error"), "There are errors in the XMLOut")


        Dim qryOut As Output.AtpQuery = Output.AtpQuery.CreateFromXMLOut(target.XmlOut) '.Replace("AtpDetails>", "AtpDetailsCollection>"))

        Assert.IsNotNull(qryOut, "qryOut has not been created from the XMLOut!")
        Assert.IsTrue(qryOut.AtpDetailsCollection.Count > 0, "There are no ATPDetail objects created!")
    End Sub

    <TestMethod()> _
    Public Sub ATPSerializeAndDeserializeATPQuery()
        Dim target As New Output.AtpQuery
        With target.StockItem
            .StockCode = "B100"
            .Description = "Bicycle"
            .LongDesc = "Parent"
            .StockUom = "EA"
            .MakeToOrderFlag = "N"
            .Warehouse = "FG"
            .WhDesc = "Finished Goods Warehouse"
            .RunDate = "2008-09-23"
            .DtfFormula = "DTF = Today + Demand time fence + DTS"
            .DtfCalculation = "DTF = Not required"
            .TtfFormula = "TTF = Today + WH lead time + DTS"
            .TtfCalculation = "TTF = Not required"
            .MtfFormula = "MTF = Today + Man. lead time + Plan freq. + DTS"
            .MtfCalculation = "MTF    = 2008-09-23 +  20 +   0 +   0 = 2008-10-13"
            .PtfFormula = "PTF = Today + Lead time + Plan freq. + DTS"
            .PtfCalculation = "PTF    = 2008-09-23 +  25 +   0 +   0 = 2008-10-18"
            .PhFormula = "PH = Planning time fence + visibility factor"
            .PhCalculation = "PH     = 2008/10/18 + 180 = 2009/04/16"
        End With
        Dim det1 As New Output.AtpQueryAtpLine
        With det1
            .Date = "2008-10-13"
            .Source = "m"
            .Description = "******** MTF ********"
        End With
        Dim det2 As New Output.AtpQueryAtpLine
        With det2
            .Date = "2008-10-18"
            .Source = "p"
            .Description = "******** PTF ********"
        End With
        Dim det3 As New Output.AtpQueryAtpLine
        With det3
            .Date = "2009-04-16"
            .Source = "z"
            .Description = "******** PH ********"
        End With

        target.AtpDetailsCollection.Add(det1)
        target.AtpDetailsCollection.Add(det2)
        target.AtpDetailsCollection.Add(det3)

        ' Serialize
        Dim objStreamWriter As New IO.StreamWriter("D:\AtpQuery.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(target.GetType)
        x.Serialize(objStreamWriter, target)
        objStreamWriter.Close()

        'Deserialize text file to a new object.
        Dim objStreamReader As New IO.StreamReader("D:\AtpQuery.xml")
        Dim p2 As Output.AtpQuery
        p2 = x.Deserialize(objStreamReader)
        objStreamReader.Close()


        Assert.IsNotNull(p2, "qryOut has not been created from the XMLOut!")
        Assert.IsTrue(p2.AtpDetailsCollection.Count > 0, "There are no ATPDetail objects created!")

    End Sub


End Class
