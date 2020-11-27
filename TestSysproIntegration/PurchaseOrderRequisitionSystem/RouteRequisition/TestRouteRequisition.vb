Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.PurchaseOrderRequistionSystem.RouteRequisition

<TestClass()> _
Public Class TestRouteRequisition


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestRouteReqn()
        Dim item As New Data.Item
        With item
            .RequisitionNumber = "1"
            .RouteToUser = "blah"
        End With

        Dim bo As New Data.PostReqRoute
        With bo
            .Item = item
            .Post(True)
        End With

        Assert.IsTrue(True)
    End Sub

End Class
