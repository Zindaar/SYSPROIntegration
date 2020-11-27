Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.GeneralLedgerPrimaryPosting.GlAnalysisPosting

<TestClass()> _
Public Class TestPostGLAnalysis


    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    <TestMethod()> _
    Public Sub TestPostGLAnalysis()

        Dim postingObject As New Data.PostGlAnalysis
        postingObject.ItemCollection.Add(New Data.PostGlAnalysisItem)
        Dim item As New Data.PostGlAnalysisItem

    End Sub


End Class
