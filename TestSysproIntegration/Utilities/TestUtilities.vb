Imports Microsoft.VisualStudio.TestTools.UnitTesting
Namespace Utilities

    <TestClass()> _
    Public Class TestUtilities

        <TestInitialize()> _
        Public Sub SetLogonParameters()
            Common.CommonTestMethods.SetLogonParameters()
        End Sub

        <TestMethod()> _
        Public Sub TestLogon()
            Dim strGUID As String = Codewell.SysproIntegration.Utilities.Logon(True)

            Assert.IsNotNull(strGUID)
        End Sub


    End Class


End Namespace
