Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class DocumentHeader

#Region " Private Variables "
        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _CompanyName As String = "" '>The OUTDOORS Company</CompanyName> 
        Private _CompanyAddress1 As String = "" '>P O Box 777</CompanyAddress1> 
        Private _CompanyAddress2 As String = "" '>Great Outdoors</CompanyAddress2> 
        Private _CompanyAddress3 As String = "" ' /> 
        Private _CompanyTaxNumber As String = "" ' /> 
        Private _CompanyRegNumber As String = "" ' /> 
        Private _Customer As String = "" '>0000001</Customer> 
        Private _CustomerName As String = "" '>Bayside Bikes</CustomerName> 
        Private _SoldToAddr1 As String = "" '>P O Box 8</SoldToAddr1> 
        Private _SoldToAddr2 As String = "" '>Bayside</SoldToAddr2> 
        Private _SoldToAddr3 As String = "" '>South</SoldToAddr3> 
        Private _SoldToAddr4 As String = "" ' /> 
        Private _SoldToAddr5 As String = "" ' /> 
        Private _SoldPostalcode As String = "" ' /> 
        Private _StateCode As String = "" ' /> 
        Private _ShipCustomerName As String = "" '>Bayside Bikes</ShipCustomerName> 
        Private _ShipAddress1 As String = "" '>3 Beach Road</ShipAddress1> 
        Private _ShipAddress2 As String = "" '>Bayside</ShipAddress2> 
        Private _ShipAddress3 As String = "" '>South</ShipAddress3> 
        Private _ShipAddress4 As String = "" ' /> 
        Private _ShipAddress5 As String = "" ' /> 
        Private _ShipPostalcode As String = "" ' /> 
        Private _MultiShipCode As String = "" ' /> 
        Private _MasterAccount As String = "" ' /> 
        Private _StoreNumber As String = "" ' /> 
        Private _Salesperson As String = "" '>200</Salesperson> 
        Private _SalespersonName As String = "" '>Barry Jones</SalespersonName> 
        Private _CustomerPoNumber As String = "" '>PO gT56</CustomerPoNumber> 
        Private _CompanyTaxNo As String = "" ' /> 
        Private _OrderDate As String = "" '>2006-06-07</OrderDate> 
        Private _ReqShipDate As String = "" '>2006-06-07</ReqShipDate> 
        Private _EntInvoiceDate As String = "" '>2006-06-07</EntInvoiceDate> 
        Private _SystemDate As String = "" '>2006-06-07</SystemDate> 
        Private _SystemTime As String = "" '>11:38:45.000</SystemTime> 
        Private _ShippingInstrs As String = "" ' /> 
        Private _SpecialInstrs As String = "" ' /> 
        Private _SalesOrder As String = "" '>000244</SalesOrder> 
        Private _DelNoteSuffix As String = "" '>00</DelNoteSuffix> 
        Private _OrderType As String = "" '>T</OrderType> 
        Private _CreditAuthority As String = "" ' /> 
        Private _Area As String = "" '>S2</Area> 
        Private _AreaDescription As String = "" '>South - Suburbs</AreaDescription> 
        Private _Branch As String = "" '>20</Branch> 
        Private _BranchDescription As String = "" '>Accounts Receivable - South</BranchDescription> 
        Private _BranchAddr1 As String = "" '>44 Tenth Street</BranchAddr1> 
        Private _BranchAddr2 As String = "" '>South</BranchAddr2> 
        Private _BranchAddr3 As String = "" ' /> 
        Private _InvTermsOverride As String = "" '>1</InvTermsOverride> 
        Private _InvoiceTermsDescription As String = "" '>30 Days - 2.5%</InvoiceTermsDescription> 
        Private _Nationality As String = "" ' /> 
        Private _DeliveryTerms As String = "" ' /> 
        Private _DeliveryTermsDescription As String = "" ' /> 
        Private _TransactionNature As String = "" ' /> 
        Private _NatureOfTransDescription As String = "" ' /> 
        Private _TransportMode As String = "" ' /> 
        Private _ProcessFlag As String = "" ' /> 
        Private _LastOperator As String = "" '>SUEE</LastOperator> 
        Private _CustomerComment As String = "" ' /> 
        Private _AlternateKey As String = "" '>S2</AlternateKey> 
        Private _DeliveryNote As String = "" '>000043</DeliveryNote> 
        Private _TaxExemptNumber As String = "" ' /> 
        Private _GstExemptNum As String = "" ' /> 
        Private _Currency As String = "" '>$</Currency> 
        Private _CurrencyDescription As String = "" '>Dollars</CurrencyDescription> 
        Private _ExchangeRate As String = "" '>1.000000</ExchangeRate> 
        Private _MulDiv As String = "" 'M</MulDiv> 
        Private _Contact As String = "" '>Karen Saunders</Contact> 
        Private _Telephone As String = "" '>555-4562</Telephone> 
        Private _TelephoneExtn As String = "" ' /> 
        Private _Fax As String = "" ' /> 
        Private _Telex As String = "" ' /> 
        Private _Email As String = "" ' /> 
        Private _OrderStatus As String = "" '>0</OrderStatus> 
        Private _EdiSendReceive As String = "" ' /> 
        Private _EdiSenderCode As String = "" ' /> 
        Private _Quote As String = "" ' /> 
        Private _RmaNumber As String = "" ' /> 

#End Region

#Region " Public Properties "
        Public Property DocumentNumber() As String
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
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
        Public Property ReqShipDate() As String
            Get
                Return _ReqShipDate
            End Get
            Set(ByVal Value As String)
                _ReqShipDate = Value
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
        Public Property SpecialInstrs() As String
            Get
                Return _SpecialInstrs
            End Get
            Set(ByVal Value As String)
                _SpecialInstrs = Value
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
        Public Property Nationality() As String
            Get
                Return _Nationality
            End Get
            Set(ByVal Value As String)
                _Nationality = Value
            End Set
        End Property
        Public Property DeliveryTerms() As String
            Get
                Return _DeliveryTerms
            End Get
            Set(ByVal Value As String)
                _DeliveryTerms = Value
            End Set
        End Property
        Public Property DeliveryTermsDescription() As String
            Get
                Return _DeliveryTermsDescription
            End Get
            Set(ByVal Value As String)
                _DeliveryTermsDescription = Value
            End Set
        End Property
        Public Property TransactionNature() As String
            Get
                Return _TransactionNature
            End Get
            Set(ByVal Value As String)
                _TransactionNature = Value
            End Set
        End Property
        Public Property NatureOfTransDescription() As String
            Get
                Return _NatureOfTransDescription
            End Get
            Set(ByVal Value As String)
                _NatureOfTransDescription = Value
            End Set
        End Property
        Public Property TransportMode() As String
            Get
                Return _TransportMode
            End Get
            Set(ByVal Value As String)
                _TransportMode = Value
            End Set
        End Property
        Public Property ProcessFlag() As String
            Get
                Return _ProcessFlag
            End Get
            Set(ByVal Value As String)
                _ProcessFlag = Value
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
        Public Property Quote() As String
            Get
                Return _Quote
            End Get
            Set(ByVal Value As String)
                _Quote = Value
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

#End Region


        Public Shared Function NewFromDS(ByVal ds As DataSet) As DocumentHeader

            Dim dh As New DocumentHeader

            Dim rootTable As DataTable = ds.Tables("Header")
            Dim rootRow As DataRow = rootTable.Rows(0)

            With dh
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .CompanyName = rootRow.Item("CompanyName").ToString
                .CompanyAddress1 = rootRow.Item("CompanyAddress1").ToString
                .CompanyAddress2 = rootRow.Item("CompanyAddress2").ToString
                .CompanyAddress3 = rootRow.Item("CompanyAddress3").ToString
                .CompanyTaxNumber = rootRow.Item("CompanyTaxNumber").ToString
                .CompanyRegNumber = rootRow.Item("CompanyRegNumber").ToString
                .Customer = rootRow.Item("Customer").ToString
                .CustomerName = rootRow.Item("CustomerName").ToString
                .SoldToAddr1 = rootRow.Item("SoldToAddr1").ToString
                .SoldToAddr2 = rootRow.Item("SoldToAddr2").ToString
                .SoldToAddr3 = rootRow.Item("SoldToAddr3").ToString
                .SoldToAddr4 = rootRow.Item("SoldToAddr4").ToString
                .SoldToAddr5 = rootRow.Item("SoldToAddr5").ToString
                .SoldPostalcode = rootRow.Item("SoldPostalcode").ToString
                .StateCode = rootRow.Item("StateCode").ToString
                .ShipCustomerName = rootRow.Item("ShipCustomerName").ToString
                .ShipAddress1 = rootRow.Item("ShipAddress1").ToString
                .ShipAddress2 = rootRow.Item("ShipAddress2").ToString
                .ShipAddress3 = rootRow.Item("ShipAddress3").ToString
                .ShipAddress4 = rootRow.Item("ShipAddress4").ToString
                .ShipAddress5 = rootRow.Item("ShipAddress5").ToString
                .ShipPostalcode = rootRow.Item("ShipPostalcode").ToString
                .MultiShipCode = rootRow.Item("MultiShipCode").ToString
                .MasterAccount = rootRow.Item("MasterAccount").ToString
                .StoreNumber = rootRow.Item("StoreNumber").ToString
                .Salesperson = rootRow.Item("Salesperson").ToString
                .SalespersonName = rootRow.Item("SalespersonName").ToString
                .CustomerPoNumber = rootRow.Item("CustomerPoNumber").ToString
                .CompanyTaxNo = rootRow.Item("CompanyTaxNo").ToString
                .OrderDate = rootRow.Item("OrderDate").ToString
                .ReqShipDate = rootRow.Item("ReqShipDate").ToString
                .EntInvoiceDate = rootRow.Item("EntInvoiceDate").ToString
                .SystemDate = rootRow.Item("SystemDate").ToString
                .SystemTime = rootRow.Item("SystemTime").ToString
                .ShippingInstrs = rootRow.Item("ShippingInstrs").ToString
                .SpecialInstrs = rootRow.Item("SpecialInstrs").ToString
                .SalesOrder = rootRow.Item("SalesOrder").ToString
                .DelNoteSuffix = rootRow.Item("DelNoteSuffix").ToString
                .OrderType = rootRow.Item("OrderType").ToString
                .CreditAuthority = rootRow.Item("CreditAuthority").ToString
                .Area = rootRow.Item("Area").ToString
                .AreaDescription = rootRow.Item("AreaDescription").ToString
                .Branch = rootRow.Item("Branch").ToString
                .BranchDescription = rootRow.Item("BranchDescription").ToString
                .BranchAddr1 = rootRow.Item("BranchAddr1").ToString
                .BranchAddr2 = rootRow.Item("BranchAddr2").ToString
                .BranchAddr3 = rootRow.Item("BranchAddr3").ToString
                .InvTermsOverride = rootRow.Item("InvTermsOverride").ToString
                .InvoiceTermsDescription = rootRow.Item("InvoiceTermsDescription").ToString
                Try
                    'Demo/Loan invoices don't have these fields !?!?!
                    .Nationality = rootRow.Item("Nationality").ToString
                    .DeliveryTerms = rootRow.Item("DeliveryTerms").ToString
                    .DeliveryTermsDescription = rootRow.Item("DeliveryTermsDescription").ToString
                    .TransactionNature = rootRow.Item("TransactionNature").ToString
                    .NatureOfTransDescription = rootRow.Item("NatureOfTransDescription").ToString
                    .TransportMode = rootRow.Item("TransportMode").ToString
                    .ProcessFlag = rootRow.Item("ProcessFlag").ToString
                Catch ex As Exception
                End Try
                .LastOperator = rootRow.Item("LastOperator").ToString
                .CustomerComment = rootRow.Item("CustomerComment").ToString
                .AlternateKey = rootRow.Item("AlternateKey").ToString
                .DeliveryNote = rootRow.Item("DeliveryNote").ToString
                .TaxExemptNumber = rootRow.Item("TaxExemptNumber").ToString
                Try
                    .GstExemptNum = rootRow.Item("GstExemptNum").ToString
                Catch ex As Exception

                End Try
                .Currency = rootRow.Item("Currency").ToString
                .CurrencyDescription = rootRow.Item("CurrencyDescription").ToString
                .ExchangeRate = rootRow.Item("ExchangeRate").ToString
                .MulDiv = rootRow.Item("MulDiv").ToString
                .Contact = rootRow.Item("Contact").ToString
                .Telephone = rootRow.Item("Telephone").ToString
                .TelephoneExtn = rootRow.Item("TelephoneExtn").ToString
                .Fax = rootRow.Item("Fax").ToString
                .Telex = rootRow.Item("Telex").ToString
                .Email = rootRow.Item("Email").ToString
                .OrderStatus = rootRow.Item("OrderStatus").ToString
                .EdiSendReceive = rootRow.Item("EdiSendReceive").ToString
                .EdiSenderCode = rootRow.Item("EdiSenderCode").ToString
                Try
                    .Quote = rootRow.Item("Quotation").ToString
                Catch ex As Exception
                    Try
                        .Quote = rootRow.Item("Quote").ToString
                    Catch exc As Exception
                        .Quote = ""
                    End Try
                End Try
                .RmaNumber = rootRow.Item("RmaNumber").ToString
            End With

            Return dh

        End Function
    End Class
End Namespace
