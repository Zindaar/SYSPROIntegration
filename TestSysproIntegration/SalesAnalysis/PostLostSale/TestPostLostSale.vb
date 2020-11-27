Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> _
Public Class TestPostLostSale


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestPostLostSaleStructure()

        Dim postingObject As New Codewell.SysproIntegration.SalesAnalysis.LostSalesPosting.Data.PostLostSales
        Dim item As New Codewell.SysproIntegration.SalesAnalysis.LostSalesPosting.Data.PostLostSalesItem
        postingObject.Post(True)

        
    End Sub

End Class
