Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Codewell.SysproIntegration.SystemQuery.ComGenericFind


<TestClass()> Public Class TestCOMGenericFetch

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub


    <TestMethod()> _
    Public Sub TestCOMGenericFetchOnInvMaster()

        Dim stockCode As String = "A100"
        Dim expectedMass As Integer = 10

        Dim postObject As New Codewell.SysproIntegration.SystemQuery.ComGenericFetch.Fetch
        With postObject
            .Key = stockCode
            .TableName = "InvMaster"
            .FullKeyProvided = Codewell.SysproIntegration.SystemQuery.ComGenericFetch.FetchFullKeyProvided.Y
            .Post(False)
        End With

        Assert.AreEqual(stockCode, Codewell.SysproIntegration.Common.SysproUtilities.CheckXMLOut("", "", postObject.XmlOut, "InvMaster//StockCode"))

        Dim actualMass As Integer = CInt(Codewell.SysproIntegration.Common.SysproUtilities.CheckXMLOut("", "", postObject.XmlOut, "InvMaster//Mass"))
        Assert.AreEqual(expectedMass, actualMass)

    End Sub

End Class
