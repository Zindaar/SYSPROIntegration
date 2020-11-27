Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class COMSFMTest

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
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region


    <TestMethod(), ExpectedException(GetType(Codewell.SysproIntegration.SysproException))> Public Sub ThrowsExceptionWhenCustomFormFieldNotExists()

        Dim CustomLinePost As New Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Data.SetupCustomForm

        Dim CustomPriceMatrixIDPerLine As New Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Data.SetupCustomFormItem
        With CustomPriceMatrixIDPerLine
            .Key.FormType = "QOTDET"
            .Key.KeyField = "SOMEQUOTELINE"
            .Key.FieldName = "SOMFLD"
            .NumericValue = 0
        End With

        CustomLinePost.ItemCollection.Add(CustomPriceMatrixIDPerLine)

        CustomLinePost.Params.ValidateOnly = Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Params.SetupCustomFormParametersValidateOnly.Y

        CustomLinePost.Post(True)
    End Sub

    <TestMethod()> Public Sub SpecifyingValidateOnlyYIncludesTheParameterInTheXMLParams()

        Dim CustomLinePost As New Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Data.SetupCustomForm
        
        CustomLinePost.Params.ValidateOnly = Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Params.SetupCustomFormParametersValidateOnly.Y

        Assert.IsTrue(CustomLinePost.XmlParam.Contains("ValidateOnly>Y"))

    End Sub

    <TestMethod()> Public Sub SpecifyingValidateOnlyNIncludesTheParameterInTheXMLParams()

        Dim CustomLinePost As New Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Data.SetupCustomForm

        CustomLinePost.Params.ValidateOnly = Codewell.SysproIntegration.SystemSetup.CustomFormSetup.Params.SetupCustomFormParametersValidateOnly.N

        Assert.IsTrue(CustomLinePost.XmlParam.Contains("ValidateOnly>N"))

    End Sub

End Class
