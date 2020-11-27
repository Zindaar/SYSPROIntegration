Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> Public Class Header

#Region " Private Fields "

        Private _DocumentNumber As String = ""
        Private _DocumentDate As String = ""
        Private _CompanyName As String = ""
        Private _CompanyAddress1 As String = ""
        Private _CompanyAddress2 As String = ""
        Private _CompanyAddress3 As String = ""
        Private _CompanyTaxNumber As String = ""
        Private _CompanyRegNumber As String = ""
        Private _Customer As String = ""
        Private _CustomerName As String = ""
        Private _SoldToAddr1 As String = ""
        Private _SoldToAddr2 As String = ""
        Private _SoldToAddr3 As String = ""
        Private _SoldToAddr4 As String = ""
        Private _SoldToAddr5 As String = ""
        Private _SoldPostalcode As String = ""
        Private _StateCode As String = ""
        Private _ShipCustomerName As String = ""
        Private _ShipAddress1 As String = ""
        Private _ShipAddress2 As String = ""
        Private _ShipAddress3 As String = ""
        Private _ShipAddress4 As String = ""
        Private _ShipAddress5 As String = ""
        Private _ShipPostalcode As String = ""
        Private _MultiShipCode As String = ""
        Private _MasterAccount As String = ""
        Private _StoreNumber As String = ""
        Private _Salesperson As String = ""
        Private _SalespersonName As String = ""
        Private _CustomerPoNumber As String = ""
        Private _CompanyTaxNo As String = ""
        Private _OrderDate As String = ""
        Private _PlannedDeliverDate As String = ""
        Private _ActualDeliveryDate As String = ""
        Private _EntInvoiceDate As String = ""
        Private _SystemDate As String = ""
        Private _SystemTime As String = ""
        Private _ShippingInstrs As String = ""
        Private _ShippingInstrsCode As String = ""
        Private _SpecialInstrs As String = ""
        Private _InvoiceCredited As String = ""
        Private _SalesOrder As String = ""
        Private _DispatchNote As String = ""
        Private _DelNoteSuffix As String = ""
        Private _OrderType As String = ""
        Private _TypeDescription As String = ""
        Private _CreditAuthority As String = ""
        Private _Area As String = ""
        Private _AreaDescription As String = ""
        Private _Branch As String = ""
        Private _BranchDescription As String = ""
        Private _BranchAddr1 As String = ""
        Private _BranchAddr2 As String = ""
        Private _BranchAddr3 As String = ""
        Private _InvTermsOverride As String = ""
        Private _InvoiceTermsDescription As String = ""
        Private _LastOperator As String = ""
        Private _LastOperatorName As String = ""
        Private _CustomerComment As String = ""
        Private _AlternateKey As String = ""
        Private _DeliveryNote As String = ""
        Private _TaxExemptNumber As String = ""
        Private _GstExemptNum As String = ""
        Private _Currency As String = ""
        Private _CurrencyDescription As String = ""
        Private _ExchangeRate As String = ""
        Private _MulDiv As String = ""
        Private _Contact As String = ""
        Private _Telephone As String = ""
        Private _TelephoneExtn As String = ""
        Private _Fax As String = ""
        Private _Telex As String = ""
        Private _Email As String = ""
        Private _DocFax As String = ""
        Private _DocFaxContact As String = ""
        Private _UserField1 As String = ""
        Private _UserField2 As String = ""
        Private _OrderStatus As String = ""
        Private _EdiSendReceive As String = ""
        Private _EdiSenderCode As String = ""
        Private _Quotation As String = ""
        Private _RmaNumber As String = ""
        Private _SalesPerson2 As String = ""
        Private _SalespersonName2 As String = ""
        Private _SalesPerson3 As String = ""
        Private _SalespersonName3 As String = ""
        Private _SalesPerson4 As String = ""
        Private _SalespersonName4 As String = ""

#End Region

#Region " Properties "
        Public Property DocumentNumber() As String
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property DocumentDate() As String
            Get
                Return _DocumentDate
            End Get
            Set(ByVal Value As String)
                _DocumentDate = Value
            End Set
        End Property
        Public Property CompanyName() As String
            Get
                Return _CompanyName
            End Get
            Set(ByVal Value As String)
                _CompanyName = Value
            End Set
        End Property
        Public Property CompanyAddress1() As String
            Get
                Return _CompanyAddress1
            End Get
            Set(ByVal Value As String)
                _CompanyAddress1 = Value
            End Set
        End Property
        Public Property CompanyAddress2() As String
            Get
                Return _CompanyAddress2
            End Get
            Set(ByVal Value As String)
                _CompanyAddress2 = Value
            End Set
        End Property
        Public Property CompanyAddress3() As String
            Get
                Return _CompanyAddress3
            End Get
            Set(ByVal Value As String)
                _CompanyAddress3 = Value
            End Set
        End Property
        Public Property CompanyTaxNumber() As String
            Get
                Return _CompanyTaxNumber
            End Get
            Set(ByVal Value As String)
                _CompanyTaxNumber = Value
            End Set
        End Property
        Public Property CompanyRegNumber() As String
            Get
                Return _CompanyRegNumber
            End Get
            Set(ByVal Value As String)
                _CompanyRegNumber = Value
            End Set
        End Property
        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal Value As String)
                _Customer = Value
            End Set
        End Property
        Public Property CustomerName() As String
            Get
                Return _CustomerName
            End Get
            Set(ByVal Value As String)
                _CustomerName = Value
            End Set
        End Property
        Public Property SoldToAddr1() As String
            Get
                Return _SoldToAddr1
            End Get
            Set(ByVal Value As String)
                _SoldToAddr1 = Value
            End Set
        End Property
        Public Property SoldToAddr2() As String
            Get
                Return _SoldToAddr2
            End Get
            Set(ByVal Value As String)
                _SoldToAddr2 = Value
            End Set
        End Property
        Public Property SoldToAddr3() As String
            Get
                Return _SoldToAddr3
            End Get
            Set(ByVal Value As String)
                _SoldToAddr3 = Value
            End Set
        End Property
        Public Property SoldToAddr4() As String
            Get
                Return _SoldToAddr4
            End Get
            Set(ByVal Value As String)
                _SoldToAddr4 = Value
            End Set
        End Property
        Public Property SoldToAddr5() As String
            Get
                Return _SoldToAddr5
            End Get
            Set(ByVal Value As String)
                _SoldToAddr5 = Value
            End Set
        End Property
        Public Property SoldPostalcode() As String
            Get
                Return _SoldPostalcode
            End Get
            Set(ByVal Value As String)
                _SoldPostalcode = Value
            End Set
        End Property
        Public Property StateCode() As String
            Get
                Return _StateCode
            End Get
            Set(ByVal Value As String)
                _StateCode = Value
            End Set
        End Property
        Public Property ShipCustomerName() As String
            Get
                Return _ShipCustomerName
            End Get
            Set(ByVal Value As String)
                _ShipCustomerName = Value
            End Set
        End Property
        Public Property ShipAddress1() As String
            Get
                Return _ShipAddress1
            End Get
            Set(ByVal Value As String)
                _ShipAddress1 = Value
            End Set
        End Property
        Public Property ShipAddress2() As String
            Get
                Return _ShipAddress2
            End Get
            Set(ByVal Value As String)
                _ShipAddress2 = Value
            End Set
        End Property
        Public Property ShipAddress3() As String
            Get
                Return _ShipAddress3
            End Get
            Set(ByVal Value As String)
                _ShipAddress3 = Value
            End Set
        End Property
        Public Property ShipAddress4() As String
            Get
                Return _ShipAddress4
            End Get
            Set(ByVal Value As String)
                _ShipAddress4 = Value
            End Set
        End Property
        Public Property ShipAddress5() As String
            Get
                Return _ShipAddress5
            End Get
            Set(ByVal Value As String)
                _ShipAddress5 = Value
            End Set
        End Property
        Public Property ShipPostalcode() As String
            Get
                Return _ShipPostalcode
            End Get
            Set(ByVal Value As String)
                _ShipPostalcode = Value
            End Set
        End Property
        Public Property MultiShipCode() As String
            Get
                Return _MultiShipCode
            End Get
            Set(ByVal Value As String)
                _MultiShipCode = Value
            End Set
        End Property
        Public Property MasterAccount() As String
            Get
                Return _MasterAccount
            End Get
            Set(ByVal Value As String)
                _MasterAccount = Value
            End Set
        End Property
        Public Property StoreNumber() As String
            Get
                Return _StoreNumber
            End Get
            Set(ByVal Value As String)
                _StoreNumber = Value
            End Set
        End Property
        Public Property Salesperson() As String
            Get
                Return _Salesperson
            End Get
            Set(ByVal Value As String)
                _Salesperson = Value
            End Set
        End Property
        Public Property SalespersonName() As String
            Get
                Return _SalespersonName
            End Get
            Set(ByVal Value As String)
                _SalespersonName = Value
            End Set
        End Property
        Public Property CustomerPoNumber() As String
            Get
                Return _CustomerPoNumber
            End Get
            Set(ByVal Value As String)
                _CustomerPoNumber = Value
            End Set
        End Property
        Public Property CompanyTaxNo() As String
            Get
                Return _CompanyTaxNo
            End Get
            Set(ByVal Value As String)
                _CompanyTaxNo = Value
            End Set
        End Property
        Public Property OrderDate() As String
            Get
                Return _OrderDate
            End Get
            Set(ByVal Value As String)
                _OrderDate = Value
            End Set
        End Property
        Public Property PlannedDeliverDate() As String
            Get
                Return _PlannedDeliverDate
            End Get
            Set(ByVal Value As String)
                _PlannedDeliverDate = Value
            End Set
        End Property
        Public Property ActualDeliveryDate() As String
            Get
                Return _ActualDeliveryDate
            End Get
            Set(ByVal Value As String)
                _ActualDeliveryDate = Value
            End Set
        End Property
        Public Property EntInvoiceDate() As String
            Get
                Return _EntInvoiceDate
            End Get
            Set(ByVal Value As String)
                _EntInvoiceDate = Value
            End Set
        End Property
        Public Property SystemDate() As String
            Get
                Return _SystemDate
            End Get
            Set(ByVal Value As String)
                _SystemDate = Value
            End Set
        End Property
        Public Property SystemTime() As String
            Get
                Return _SystemTime
            End Get
            Set(ByVal Value As String)
                _SystemTime = Value
            End Set
        End Property
        Public Property ShippingInstrs() As String
            Get
                Return _ShippingInstrs
            End Get
            Set(ByVal Value As String)
                _ShippingInstrs = Value
            End Set
        End Property
        Public Property ShippingInstrsCode() As String
            Get
                Return _ShippingInstrsCode
            End Get
            Set(ByVal Value As String)
                _ShippingInstrsCode = Value
            End Set
        End Property
        Public Property SpecialInstrs() As String
            Get
                Return _SpecialInstrs
            End Get
            Set(ByVal Value As String)
                _SpecialInstrs = Value
            End Set
        End Property
        Public Property InvoiceCredited() As String
            Get
                Return _InvoiceCredited
            End Get
            Set(ByVal Value As String)
                _InvoiceCredited = Value
            End Set
        End Property
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property DispatchNote() As String
            Get
                Return _DispatchNote
            End Get
            Set(ByVal Value As String)
                _DispatchNote = Value
            End Set
        End Property
        Public Property DelNoteSuffix() As String
            Get
                Return _DelNoteSuffix
            End Get
            Set(ByVal Value As String)
                _DelNoteSuffix = Value
            End Set
        End Property
        Public Property OrderType() As String
            Get
                Return _OrderType
            End Get
            Set(ByVal Value As String)
                _OrderType = Value
            End Set
        End Property
        Public Property TypeDescription() As String
            Get
                Return _TypeDescription
            End Get
            Set(ByVal Value As String)
                _TypeDescription = Value
            End Set
        End Property
        Public Property CreditAuthority() As String
            Get
                Return _CreditAuthority
            End Get
            Set(ByVal Value As String)
                _CreditAuthority = Value
            End Set
        End Property
        Public Property Area() As String
            Get
                Return _Area
            End Get
            Set(ByVal Value As String)
                _Area = Value
            End Set
        End Property
        Public Property AreaDescription() As String
            Get
                Return _AreaDescription
            End Get
            Set(ByVal Value As String)
                _AreaDescription = Value
            End Set
        End Property
        Public Property Branch() As String
            Get
                Return _Branch
            End Get
            Set(ByVal Value As String)
                _Branch = Value
            End Set
        End Property
        Public Property BranchDescription() As String
            Get
                Return _BranchDescription
            End Get
            Set(ByVal Value As String)
                _BranchDescription = Value
            End Set
        End Property
        Public Property BranchAddr1() As String
            Get
                Return _BranchAddr1
            End Get
            Set(ByVal Value As String)
                _BranchAddr1 = Value
            End Set
        End Property
        Public Property BranchAddr2() As String
            Get
                Return _BranchAddr2
            End Get
            Set(ByVal Value As String)
                _BranchAddr2 = Value
            End Set
        End Property
        Public Property BranchAddr3() As String
            Get
                Return _BranchAddr3
            End Get
            Set(ByVal Value As String)
                _BranchAddr3 = Value
            End Set
        End Property
        Public Property InvTermsOverride() As String
            Get
                Return _InvTermsOverride
            End Get
            Set(ByVal Value As String)
                _InvTermsOverride = Value
            End Set
        End Property
        Public Property InvoiceTermsDescription() As String
            Get
                Return _InvoiceTermsDescription
            End Get
            Set(ByVal Value As String)
                _InvoiceTermsDescription = Value
            End Set
        End Property
        Public Property LastOperator() As String
            Get
                Return _LastOperator
            End Get
            Set(ByVal Value As String)
                _LastOperator = Value
            End Set
        End Property
        Public Property LastOperatorName() As String
            Get
                Return _LastOperatorName
            End Get
            Set(ByVal Value As String)
                _LastOperatorName = Value
            End Set
        End Property
        Public Property CustomerComment() As String
            Get
                Return _CustomerComment
            End Get
            Set(ByVal Value As String)
                _CustomerComment = Value
            End Set
        End Property
        Public Property AlternateKey() As String
            Get
                Return _AlternateKey
            End Get
            Set(ByVal Value As String)
                _AlternateKey = Value
            End Set
        End Property
        Public Property DeliveryNote() As String
            Get
                Return _DeliveryNote
            End Get
            Set(ByVal Value As String)
                _DeliveryNote = Value
            End Set
        End Property
        Public Property TaxExemptNumber() As String
            Get
                Return _TaxExemptNumber
            End Get
            Set(ByVal Value As String)
                _TaxExemptNumber = Value
            End Set
        End Property
        Public Property GstExemptNum() As String
            Get
                Return _GstExemptNum
            End Get
            Set(ByVal Value As String)
                _GstExemptNum = Value
            End Set
        End Property
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property
        Public Property CurrencyDescription() As String
            Get
                Return _CurrencyDescription
            End Get
            Set(ByVal Value As String)
                _CurrencyDescription = Value
            End Set
        End Property
        Public Property ExchangeRate() As String
            Get
                Return _ExchangeRate
            End Get
            Set(ByVal Value As String)
                _ExchangeRate = Value
            End Set
        End Property
        Public Property MulDiv() As String
            Get
                Return _MulDiv
            End Get
            Set(ByVal Value As String)
                _MulDiv = Value
            End Set
        End Property
        Public Property Contact() As String
            Get
                Return _Contact
            End Get
            Set(ByVal Value As String)
                _Contact = Value
            End Set
        End Property
        Public Property Telephone() As String
            Get
                Return _Telephone
            End Get
            Set(ByVal Value As String)
                _Telephone = Value
            End Set
        End Property
        Public Property TelephoneExtn() As String
            Get
                Return _TelephoneExtn
            End Get
            Set(ByVal Value As String)
                _TelephoneExtn = Value
            End Set
        End Property
        Public Property Fax() As String
            Get
                Return _Fax
            End Get
            Set(ByVal Value As String)
                _Fax = Value
            End Set
        End Property
        Public Property Telex() As String
            Get
                Return _Telex
            End Get
            Set(ByVal Value As String)
                _Telex = Value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal Value As String)
                _Email = Value
            End Set
        End Property
        Public Property DocFax() As String
            Get
                Return _DocFax
            End Get
            Set(ByVal Value As String)
                _DocFax = Value
            End Set
        End Property
        Public Property DocFaxContact() As String
            Get
                Return _DocFaxContact
            End Get
            Set(ByVal Value As String)
                _DocFaxContact = Value
            End Set
        End Property
        Public Property UserField1() As String
            Get
                Return _UserField1
            End Get
            Set(ByVal Value As String)
                _UserField1 = Value
            End Set
        End Property
        Public Property UserField2() As String
            Get
                Return _UserField2
            End Get
            Set(ByVal Value As String)
                _UserField2 = Value
            End Set
        End Property
        Public Property OrderStatus() As String
            Get
                Return _OrderStatus
            End Get
            Set(ByVal Value As String)
                _OrderStatus = Value
            End Set
        End Property
        Public Property EdiSendReceive() As String
            Get
                Return _EdiSendReceive
            End Get
            Set(ByVal Value As String)
                _EdiSendReceive = Value
            End Set
        End Property
        Public Property EdiSenderCode() As String
            Get
                Return _EdiSenderCode
            End Get
            Set(ByVal Value As String)
                _EdiSenderCode = Value
            End Set
        End Property
        Public Property Quotation() As String
            Get
                Return _Quotation
            End Get
            Set(ByVal Value As String)
                _Quotation = Value
            End Set
        End Property
        Public Property RmaNumber() As String
            Get
                Return _RmaNumber
            End Get
            Set(ByVal Value As String)
                _RmaNumber = Value
            End Set
        End Property
        Public Property SalesPerson2() As String
            Get
                Return _SalesPerson2
            End Get
            Set(ByVal Value As String)
                _SalesPerson2 = Value
            End Set
        End Property
        Public Property SalespersonName2() As String
            Get
                Return _SalespersonName2
            End Get
            Set(ByVal Value As String)
                _SalespersonName2 = Value
            End Set
        End Property
        Public Property SalesPerson3() As String
            Get
                Return _SalesPerson3
            End Get
            Set(ByVal Value As String)
                _SalesPerson3 = Value
            End Set
        End Property
        Public Property SalespersonName3() As String
            Get
                Return _SalespersonName3
            End Get
            Set(ByVal Value As String)
                _SalespersonName3 = Value
            End Set
        End Property
        Public Property SalesPerson4() As String
            Get
                Return _SalesPerson4
            End Get
            Set(ByVal Value As String)
                _SalesPerson4 = Value
            End Set
        End Property
        Public Property SalespersonName4() As String
            Get
                Return _SalespersonName4
            End Get
            Set(ByVal Value As String)
                _SalespersonName4 = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDS(ByVal ds As DataSet) As Header

            Dim dh As New Header

            Dim rootTable As DataTable = ds.Tables("Header")
            Dim rootRow As DataRow = rootTable.Rows(0)

            With dh
                Try : .DocumentNumber = rootRow.Item("DocumentNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .DocumentDate = rootRow.Item("DocumentDate").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyName = rootRow.Item("CompanyName").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyAddress1 = rootRow.Item("CompanyAddress1").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyAddress2 = rootRow.Item("CompanyAddress2").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyAddress3 = rootRow.Item("CompanyAddress3").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyTaxNumber = rootRow.Item("CompanyTaxNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyRegNumber = rootRow.Item("CompanyRegNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .Customer = rootRow.Item("Customer").ToString : Catch ex As ArgumentException : End Try
                Try : .CustomerName = rootRow.Item("CustomerName").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldToAddr1 = rootRow.Item("SoldToAddr1").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldToAddr2 = rootRow.Item("SoldToAddr2").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldToAddr3 = rootRow.Item("SoldToAddr3").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldToAddr4 = rootRow.Item("SoldToAddr4").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldToAddr5 = rootRow.Item("SoldToAddr5").ToString : Catch ex As ArgumentException : End Try
                Try : .SoldPostalcode = rootRow.Item("SoldPostalcode").ToString : Catch ex As ArgumentException : End Try
                Try : .StateCode = rootRow.Item("StateCode").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipCustomerName = rootRow.Item("ShipCustomerName").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddress1 = rootRow.Item("ShipAddress1").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddress2 = rootRow.Item("ShipAddress2").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddress3 = rootRow.Item("ShipAddress3").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddress4 = rootRow.Item("ShipAddress4").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddress5 = rootRow.Item("ShipAddress5").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipPostalcode = rootRow.Item("ShipPostalcode").ToString : Catch ex As ArgumentException : End Try
                Try : .MultiShipCode = rootRow.Item("MultiShipCode").ToString : Catch ex As ArgumentException : End Try
                Try : .MasterAccount = rootRow.Item("MasterAccount").ToString : Catch ex As ArgumentException : End Try
                Try : .StoreNumber = rootRow.Item("StoreNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .Salesperson = rootRow.Item("Salesperson").ToString : Catch ex As ArgumentException : End Try
                Try : .SalespersonName = rootRow.Item("SalespersonName").ToString : Catch ex As ArgumentException : End Try
                Try : .CustomerPoNumber = rootRow.Item("CustomerPoNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyTaxNo = rootRow.Item("CompanyTaxNo").ToString : Catch ex As ArgumentException : End Try
                Try : .OrderDate = rootRow.Item("OrderDate").ToString : Catch ex As ArgumentException : End Try
                Try : .PlannedDeliverDate = rootRow.Item("PlannedDeliverDate").ToString : Catch ex As ArgumentException : End Try
                Try : .ActualDeliveryDate = rootRow.Item("ActualDeliveryDate").ToString : Catch ex As ArgumentException : End Try
                Try : .EntInvoiceDate = rootRow.Item("EntInvoiceDate").ToString : Catch ex As ArgumentException : End Try
                Try : .SystemDate = rootRow.Item("SystemDate").ToString : Catch ex As ArgumentException : End Try
                Try : .SystemTime = rootRow.Item("SystemTime").ToString : Catch ex As ArgumentException : End Try
                Try : .ShippingInstrs = rootRow.Item("ShippingInstrs").ToString : Catch ex As ArgumentException : End Try
                Try : .ShippingInstrsCode = rootRow.Item("ShippingInstrsCode").ToString : Catch ex As ArgumentException : End Try
                Try : .SpecialInstrs = rootRow.Item("SpecialInstrs").ToString : Catch ex As ArgumentException : End Try
                Try : .InvoiceCredited = rootRow.Item("InvoiceCredited").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrder = rootRow.Item("SalesOrder").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchNote = rootRow.Item("DispatchNote").ToString : Catch ex As ArgumentException : End Try
                Try : .DelNoteSuffix = rootRow.Item("DelNoteSuffix").ToString : Catch ex As ArgumentException : End Try
                Try : .OrderType = rootRow.Item("OrderType").ToString : Catch ex As ArgumentException : End Try
                Try : .TypeDescription = rootRow.Item("TypeDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .CreditAuthority = rootRow.Item("CreditAuthority").ToString : Catch ex As ArgumentException : End Try
                Try : .Area = rootRow.Item("Area").ToString : Catch ex As ArgumentException : End Try
                Try : .AreaDescription = rootRow.Item("AreaDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .Branch = rootRow.Item("Branch").ToString : Catch ex As ArgumentException : End Try
                Try : .BranchDescription = rootRow.Item("BranchDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .BranchAddr1 = rootRow.Item("BranchAddr1").ToString : Catch ex As ArgumentException : End Try
                Try : .BranchAddr2 = rootRow.Item("BranchAddr2").ToString : Catch ex As ArgumentException : End Try
                Try : .BranchAddr3 = rootRow.Item("BranchAddr3").ToString : Catch ex As ArgumentException : End Try
                Try : .InvTermsOverride = rootRow.Item("InvTermsOverride").ToString : Catch ex As ArgumentException : End Try
                Try : .InvoiceTermsDescription = rootRow.Item("InvoiceTermsDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .LastOperator = rootRow.Item("LastOperator").ToString : Catch ex As ArgumentException : End Try
                Try : .LastOperatorName = rootRow.Item("LastOperatorName").ToString : Catch ex As ArgumentException : End Try
                Try : .CustomerComment = rootRow.Item("CustomerComment").ToString : Catch ex As ArgumentException : End Try
                Try : .AlternateKey = rootRow.Item("AlternateKey").ToString : Catch ex As ArgumentException : End Try
                Try : .DeliveryNote = rootRow.Item("DeliveryNote").ToString : Catch ex As ArgumentException : End Try
                Try : .TaxExemptNumber = rootRow.Item("TaxExemptNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .GstExemptNum = rootRow.Item("GstExemptNum").ToString : Catch ex As ArgumentException : End Try
                Try : .Currency = rootRow.Item("Currency").ToString : Catch ex As ArgumentException : End Try
                Try : .CurrencyDescription = rootRow.Item("CurrencyDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .ExchangeRate = rootRow.Item("ExchangeRate").ToString : Catch ex As ArgumentException : End Try
                Try : .MulDiv = rootRow.Item("MulDiv").ToString : Catch ex As ArgumentException : End Try
                Try : .Contact = rootRow.Item("Contact").ToString : Catch ex As ArgumentException : End Try
                Try : .Telephone = rootRow.Item("Telephone").ToString : Catch ex As ArgumentException : End Try
                Try : .TelephoneExtn = rootRow.Item("TelephoneExtn").ToString : Catch ex As ArgumentException : End Try
                Try : .Fax = rootRow.Item("Fax").ToString : Catch ex As ArgumentException : End Try
                Try : .Telex = rootRow.Item("Telex").ToString : Catch ex As ArgumentException : End Try
                Try : .Email = rootRow.Item("Email").ToString : Catch ex As ArgumentException : End Try
                Try : .DocFax = rootRow.Item("DocFax").ToString : Catch ex As ArgumentException : End Try
                Try : .DocFaxContact = rootRow.Item("DocFaxContact").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField1 = rootRow.Item("UserField1").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField2 = rootRow.Item("UserField2").ToString : Catch ex As ArgumentException : End Try
                Try : .OrderStatus = rootRow.Item("OrderStatus").ToString : Catch ex As ArgumentException : End Try
                Try : .EdiSendReceive = rootRow.Item("EdiSendReceive").ToString : Catch ex As ArgumentException : End Try
                Try : .EdiSenderCode = rootRow.Item("EdiSenderCode").ToString : Catch ex As ArgumentException : End Try
                Try : .Quotation = rootRow.Item("Quotation").ToString : Catch ex As ArgumentException : End Try
                Try : .RmaNumber = rootRow.Item("RmaNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesPerson2 = rootRow.Item("SalesPerson2").ToString : Catch ex As ArgumentException : End Try
                Try : .SalespersonName2 = rootRow.Item("SalespersonName2").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesPerson3 = rootRow.Item("SalesPerson3").ToString : Catch ex As ArgumentException : End Try
                Try : .SalespersonName3 = rootRow.Item("SalespersonName3").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesPerson4 = rootRow.Item("SalesPerson4").ToString : Catch ex As ArgumentException : End Try
                Try : .SalespersonName4 = rootRow.Item("SalespersonName4").ToString : Catch ex As ArgumentException : End Try
            End With

            Return dh

        End Function
    End Class
End Namespace
