Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestWIPMaterialISsue


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestIssue()
        Dim wipItem As New Codewell.SysproIntegration.WipShopFloorDataCollection.WipSpecificIssues.Data.PostMaterialItem
        With wipItem
            .LedgerCode = ""
        End With

        Dim postobj As New Codewell.SysproIntegration.WipShopFloorDataCollection.WipSpecificIssues.Data.PostMaterial
        postobj.ItemsCollection.Add(wipItem)
        With postobj.Params
            .IgnoreWarnings = Codewell.SysproIntegration.WipShopFloorDataCollection.WipSpecificIssues.Params.PostMaterialParametersIgnoreWarnings.Y
            .ValidateOnly = Codewell.SysproIntegration.WipShopFloorDataCollection.WipSpecificIssues.Params.PostMaterialParametersValidateOnly.Y
        End With
        postobj.Post(True)

        'If we get here the validation worked!
        Assert.IsTrue(True)


    End Sub

End Class
