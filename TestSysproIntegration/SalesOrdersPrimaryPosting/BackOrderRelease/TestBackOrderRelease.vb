Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.SalesOrdersPrimaryPosting

<TestClass()> _
Public Class TestBackOrderRelease


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub CanAddMultipleItems()

        Dim postObject As New BackOrderReleasesImport.Data.PostSorBackOrderRelease

        Dim item1 As New BackOrderReleasesImport.Data.Item
        item1.StockCode = "A"

        Dim item2 As New BackOrderReleasesImport.Data.Item
        item2.StockCode = "B"

        postObject.Itemcollection.add(item1)
        postObject.ItemCollection.add(item2)

        Dim xmlData As String = postObject.XMLData

        Assert.IsTrue(xmlData.Contains("StockCode>A</StockCode"))
        Assert.IsTrue(xmlData.Contains("StockCode>B</StockCode"))


    End Sub

End Class
