Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TestProfileQuery

    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub


    <TestMethod()> _
    Public Sub TestProfileQuery()

        Dim postObject As New Codewell.SysproIntegration.SystemQuery.ProfileSettingsQuery.Query
        With postObject
            .Option.IncludeDetails = Codewell.SysproIntegration.SystemQuery.ProfileSettingsQuery.IncludeDetails.Y
            .Option.IncludeModules = "ALL"
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            .Post(False)
        End With
        Assert.IsFalse(String.IsNullOrEmpty(postObject.XmlOut))
    End Sub

End Class
