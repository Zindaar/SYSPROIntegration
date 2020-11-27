Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Codewell.SysproIntegration.ContactManagementPrimaryPosting.ContactPostContact.Data

<TestClass()> Public Class TestPostContact

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
    <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
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

    <TestMethod()> Public Sub TestPostNewContact()
        Dim cnt As New PostContact
        Dim cntItem As New PostContactItem
        Dim email1 As New PostContactItemSingleEmail
        email1.Email = "joe@soap.com"
        email1.EmailWorkHomeFlag = PostContactItemSingleEmailEmailWorkHomeFlag.W
        email1.EmailPreferred = PostContactItemSingleEmailEmailPreferred.Y
        email1.EmailPrivate = PostContactItemSingleEmailEmailPrivate.Y

        cntItem.EmailList = New List(Of PostContactItemSingleEmail)
        cntItem.EmailList.Add(email1)

        cnt.ItemCollection.Add(cntItem)

        Assert.IsFalse(cnt.XMLData.Contains("<EmailListCollection>"), "XML incorrectly contains <EmailListCollection>")

    End Sub

    <TestMethod()> Public Sub AddCustomers_RendersCorrectly()
        Dim cnt As New PostContact
        Dim cntItem As New PostContactItem
        Dim cust1 As New PostContactItemCustomer
        cust1.Customer = "ABC"

        Dim cust2 As New PostContactItemCustomer
        cust2.Customer = "DEF"

        cntItem.Customers = New List(Of PostContactItemCustomer)
        cntItem.Customers.Add(cust1)
        cntItem.Customers.Add(cust2)

        cnt.ItemCollection.Add(cntItem)

        Assert.IsTrue(cnt.XMLData.Contains("<Customers><Customer>ABC</Customer><Customer>DEF</Customer></Customers>"), "XML has not generated correctly: " & vbCrLf & cnt.XMLData)

    End Sub

    <TestMethod()> Public Sub TestPostNewContact_EmptyListNotInXML()
        Dim cnt As New PostContact
        Dim cntItem As New PostContactItem
        
        cnt.ItemCollection.Add(cntItem)

        Assert.IsFalse(cnt.XMLData.Contains("<AddressList />"), "XML incorrectly contains <AddressList />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<UrlList />"), "XML incorrectly contains <UrlList />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<DateList />"), "XML incorrectly contains <DateList />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<PhoneList />"), "XML incorrectly contains <PhoneList />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<EmailList />"), "XML incorrectly contains <EmailList />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<Customers />"), "XML incorrectly contains <Customers />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<Suppliers />"), "XML incorrectly contains <Suppliers />:" & vbCrLf & cnt.XMLData)
        Assert.IsFalse(cnt.XMLData.Contains("<Accounts />"), "XML incorrectly contains <Accounts />:" & vbCrLf & cnt.XMLData)

    End Sub
End Class
