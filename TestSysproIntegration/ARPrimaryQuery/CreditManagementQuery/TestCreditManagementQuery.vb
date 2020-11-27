'<TestClass()> _
Public Class TestCreditManagementQuery

    '<TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub

    '<TestMethod()> _
    Public Sub TestCreditManagementQuery()
        Dim qry As New Codewell.SysproIntegration.ARPrimaryQuery.CreditManagementQuery.QueryData.Query
        With qry
            .QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
            .Option = New Codewell.SysproIntegration.ARPrimaryQuery.CreditManagementQuery.QueryData.Option
            .Option.ReportType = Codewell.SysproIntegration.ARPrimaryQuery.CreditManagementQuery.QueryData.ReportType.I
            .Post(False)
        End With

        'Assert.IsTrue(True)
    End Sub

End Class
