Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Threading.Tasks
Imports System.Diagnostics


'''<summary>
'''This is a test class for UtilitiesTest and is intended
'''to contain all UtilitiesTest Unit Tests
'''</summary>
<TestClass()> _
Public Class UtilitiesTest


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
            testContextInstance = value
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


    <TestMethod()> _
    Public Sub TestLogon()
        Common.CommonTestMethods.SetLogonParameters()
        Dim strGUID As String = Codewell.SysproIntegration.Utilities.Logon(True)

        Assert.IsNotNull(strGUID)
    End Sub

     <TestMethod()> _
    Public Sub TestWCFLogon()
        Common.CommonTestMethods.SetWCFLogonParameters()
        Dim strGUID As String = Codewell.SysproIntegration.Utilities.Logon(True)

        Assert.IsNotNull(strGUID)
    End Sub

    '''<summary>
    '''A test for GetLogonProfile
    '''</summary>
    <TestMethod()> _
    Public Sub LogonGetLogonProfileLogoffTest()

        Dim sw As New Stopwatch
        sw.Start()

        Dim testOperator As String = "SHAWN"

        Codewell.SysproIntegration.LogonDetails.SetLogonDetails(testOperator, "", "0", "", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.COMDCOM)

        For i As Integer = 1 To 10
            Debug.WriteLine(sw.ElapsedMilliseconds & " Iteration " & i.ToString)

            Codewell.SysproIntegration.Utilities.Logon(True)
            Debug.WriteLine(sw.ElapsedMilliseconds & " Loggged On")

            Dim actual As String = Codewell.SysproIntegration.Utilities.GetLogonProfile
            Debug.WriteLine(sw.ElapsedMilliseconds & " Got Profile")
            Assert.IsTrue(actual.Contains("<OperatorCode>" & testOperator & "</OperatorCode>"), actual)

            Codewell.SysproIntegration.Utilities.Logoff()
            Debug.WriteLine(sw.ElapsedMilliseconds & " Loggged Off")
        Next
        Debug.WriteLine(sw.ElapsedMilliseconds & " All Done")

    End Sub

     '''<summary>
    '''A test for GetLogonProfile
    '''</summary>
    <TestMethod()> _
    Public Sub WCFLogonGetLogonProfileLogoffTest()

        Dim sw As New Stopwatch
        sw.Start()

        Dim testOperator As String = "ADMIN"

        Common.CommonTestMethods.SetWCFLogonParameters()

        For i As Integer = 1 To 10
            Debug.WriteLine(sw.ElapsedMilliseconds & " Iteration " & i.ToString)

            Codewell.SysproIntegration.Utilities.Logon(True)
            Debug.WriteLine(sw.ElapsedMilliseconds & " Loggged On")

            Dim actual As String = Codewell.SysproIntegration.Utilities.GetLogonProfile
            Debug.WriteLine(sw.ElapsedMilliseconds & " Got Profile")
            Assert.IsTrue(actual.Contains("<OperatorCode>" & testOperator & "</OperatorCode>"), actual)

            Codewell.SysproIntegration.Utilities.Logoff()
            Debug.WriteLine(sw.ElapsedMilliseconds & " Loggged Off")
        Next
        Debug.WriteLine(sw.ElapsedMilliseconds & " All Done")

    End Sub

    <TestMethod()> _
    Public Sub SetGUID()
        Dim strGuid As String = "489BFBF662B134499E12FBA29160AFD30"

        Codewell.SysproIntegration.LogonDetails.SetLogonDetails(strGuid, Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.COMDCOM)

        Dim profile As String = Codewell.SysproIntegration.Utilities.GetLogonProfile()

        Assert.IsTrue(profile.Contains("<OperatorCode>ADMIN</OperatorCode>"))

    End Sub

    <TestMethod()> _
    Public Sub ProfileTestWithMultipleThreads()

        Codewell.SysproIntegration.LogonDetails.SetLogonDetails("ADMIN", "", "0", "", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.COMDCOM)
        Dim error1 As String = ""
        Dim error2 As String = ""

        Debug.WriteLine("Here we go on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
        Dim t1 As New Task(Of String)(Function() As String
                                          Debug.WriteLine("Task 1 is on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                          'Codewell.SysproIntegration.Utilities.Logon(False)
                                          Dim retVal As String = Codewell.SysproIntegration.Utilities.GetLogonProfile()
                                          Codewell.SysproIntegration.Utilities.Logoff()
                                          Return retVal
                                      End Function)

        Dim t2 As New Task(Of String)(Function() As String
                                          Debug.WriteLine("Task 2 is on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                          'Codewell.SysproIntegration.Utilities.Logon(False)
                                          'Threading.Thread.Sleep(1000)
                                          Dim retVal As String = Codewell.SysproIntegration.Utilities.GetLogonProfile()
                                          Codewell.SysproIntegration.Utilities.Logoff()
                                          Return retVal
                                      End Function)


        Dim e1 As Task = t1.ContinueWith(Sub(t)
                                             Debug.WriteLine("Handling error for task1 " & t.Status.ToString & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                             Debug.WriteLine("Error on task1 is: " & t.Exception.ToString)
                                             error1 = t.Exception.ToString()
                                         End Sub, continuationOptions:=TaskContinuationOptions.OnlyOnFaulted)

        Dim e2 As Task = t2.ContinueWith(Sub(t)
                                             Debug.WriteLine("Handling error for task2 " & t.Status.ToString & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                             Debug.WriteLine("Error on task2 is: " & t.Exception.ToString)
                                             error2 = t.Exception.ToString()
                                         End Sub, continuationOptions:=TaskContinuationOptions.OnlyOnFaulted)

        Debug.WriteLine("Status of task1 is " & t1.Status.ToString)
        Debug.WriteLine("Status of task2 is " & t1.Status.ToString)
        Debug.WriteLine("Status of e1 is " & e1.Status.ToString)
        Debug.WriteLine("Status of e2 is " & e2.Status.ToString)

        t1.Start()
        t2.Start()

        Debug.WriteLine("Status of task1 is " & t1.Status.ToString)
        Debug.WriteLine("Status of task2 is " & t2.Status.ToString)
        Debug.WriteLine("Status of e1 is " & e1.Status.ToString)
        Debug.WriteLine("Status of e2 is " & e2.Status.ToString)

        Try
            Task.WaitAll(t1, t2, e1, e2)
            Codewell.SysproIntegration.Utilities.Logoff()
        Catch ex As Exception
            'This is ok, any errors are recorded in the in the error1 and error2 strings
            Debug.WriteLine("************************************************")
            Debug.WriteLine(ex.ToString())
            Debug.WriteLine("************************************************")
        End Try

        Try
            Debug.WriteLine("Status of task1 is " & t1.Status.ToString)
            Debug.WriteLine("Status of task2 is " & t2.Status.ToString)
            Debug.WriteLine("Status of e1 is " & e1.Status.ToString)
            Debug.WriteLine("Status of e2 is " & e2.Status.ToString)
        Catch ex As Exception
            'This is ok, any errors are recorded in the in the error1 and error2 strings
            Debug.WriteLine("************************************************")
            Debug.WriteLine("************************************************")
            Debug.WriteLine(ex.ToString())
            Debug.WriteLine("************************************************")
            Debug.WriteLine("************************************************")
        End Try


        Assert.IsTrue(String.IsNullOrEmpty(error1), "Error on Thread 1:" & error1)
        Assert.IsTrue(String.IsNullOrEmpty(error2), "Error on Thread 2:" & error2)

    End Sub

    <TestMethod()> _
    Public Sub CustomerQueryTestWithMultipleThreads()

        Codewell.SysproIntegration.LogonDetails.SetLogonDetails("ADMIN", "", "0", "", Codewell.SysproIntegration.LogonDetails.CommunicationMethodEnum.COMDCOM)
        Dim error1 As String = ""
        Dim error2 As String = ""

        Debug.WriteLine("Here we go on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
        Dim t1 As New Task(Of String)(Function() As String
                                          Debug.WriteLine("Task 1 is on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                          Return QueryCustomer("0000017")
                                      End Function)

        Dim t2 As New Task(Of String)(Function() As String
                                          Debug.WriteLine("Task 2 is on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                          Return QueryCustomer("0000019")
                                      End Function)

        Dim e1 As Task = t1.ContinueWith(Sub(t)
                                             Debug.WriteLine("Handling error for task1 " & t.Status.ToString & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                             Debug.WriteLine("Error on task1 is: " & t.Exception.ToString)
                                             error1 = t.Exception.ToString()
                                         End Sub, continuationOptions:=TaskContinuationOptions.OnlyOnFaulted)

        Dim e2 As Task = t2.ContinueWith(Sub(t)
                                             Debug.WriteLine("Handling error for task2 " & t.Status.ToString & " on thread " & Threading.Thread.CurrentThread.ManagedThreadId)
                                             Debug.WriteLine("Error on task2 is: " & t.Exception.ToString)
                                             error2 = t.Exception.ToString()
                                         End Sub, continuationOptions:=TaskContinuationOptions.OnlyOnFaulted)

        t1.Start()
        t2.Start()

        Try
            Task.WaitAll(t1, t2, e1, e2)
            Codewell.SysproIntegration.Utilities.Logoff()
        Catch ex As Exception
            'This is ok, any errors are recorded in the in the error1 and error2 strings
            Debug.WriteLine("************************************************")
            Debug.WriteLine(ex.ToString())
            Debug.WriteLine("************************************************")
        End Try

        Assert.IsTrue(String.IsNullOrEmpty(error1), "Error on Thread 1:" & error1)
        Assert.IsTrue(String.IsNullOrEmpty(error2), "Error on Thread 2:" & error2)

    End Sub

    Shared Function QueryCustomer(customer As String) As String
        Dim CustomerQuery As New Codewell.SysproIntegration.ARPrimaryQuery.CustomerQuery.QueryData.Query

        CustomerQuery.Key.Customer = customer
        CustomerQuery.Option.IncludeTransactions = Codewell.SysproIntegration.ARPrimaryQuery.CustomerQuery.QueryData.IncludeTransactions.N
        CustomerQuery.QueryActionType = Codewell.SysproIntegration.CommonEnums.ActionType_Query.Query
        CustomerQuery.Post(False)

        Return CustomerQuery.XmlOut
    End Function


End Class
