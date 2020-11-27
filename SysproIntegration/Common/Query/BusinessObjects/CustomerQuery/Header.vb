Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class Header

#Region " Properties "
        Private _CompanyName As String
        Private _CompAddress1 As String
        Private _CompAddress2 As String
        Private _CompAddress3 As String
        Private _CompTaxNo As String
        Private _CompRegNo As String
        Private _Customer As String
        Private _Name As String
        Private _SoldToAddr1 As String
        Private _SoldToAddr2 As String
        Private _SoldToAddr3 As String
        Private _SoldToAddr4 As String
        Private _SoldToAddr5 As String
        Private _SoldPostalCode As String
        Private _SALSLS_Name As String
        Private _StatementDate As Date
        Private _TermsCode As String
        Private _TBLART_Description As String
        Private _Currency As String
        Private _TBLCUR_Description As String
        Private _Contact As String
        Private _CreditLimit As String
        Private _CreditCheckFlag As String
        Private _ShortName As String
        Private _CustomerType As String
        Private _MasterAccount As String
        Private _StoreNumber As String
        Private _CreditStatus As String
        Private _InvoiceCount As String
        Private _Salesperson As String
        Private _CustomerClass As String
        Private _InvDiscCode As String
        Private _LineDiscCode As String
        Private _BalanceType As String
        Private _Area As String
        Private _TaxStatus As String
        Private _SpecialInstrs As String
        Private _DateLastSale As String
        Private _DateLastPay As String
        Private _OutstOrdVal As String
        Private _NumOutstOrd As String
        Private _Telephone As String
        Private _AddTelephone As String
        Private _Fax As String
        Private _Telex As String
        Private _TelephoneExtn As String
        Private _UserField1 As String
        Private _UserField2 As String
        Private _GstExemptFlag As String
        Private _GstExemptNum As String
        Private _ContractPrcReqd As String
        Private _BackOrdReqd As String
        Private _ShippingInstrs As String
        Private _StateCode As String
        Private _DateCustAdded As String
        Private _Nationality As String
        Private _HighestBalance As String
        Private _CustomerOnHold As String
        Private _EdiSenderCode As String
        Private _Email As String
        Private _DocFax As String
        Private _DocFaxContact As String
        Private _ShipToAddr1 As String
        Private _ShipToAddr2 As String
        Private _ShipToAddr3 As String
        Private _ShipToAddr4 As String
        Private _ShipToAddr5 As String
        Private _ShipPostalCode As String
        Private _TaxExemptNumber As String
        Private _Branch As String
        Private _SALBRN_Description As String
        Private _BranchAddr1 As String
        Private _BranchAddr2 As String
        Private _BranchAddr3 As String

        Public Property CompanyName() As String
            Get
                Return _CompanyName
            End Get
            Set(ByVal Value As String)
                _CompanyName = Value
            End Set
        End Property
        Public Property CompAddress1() As String
            Get
                Return _CompAddress1
            End Get
            Set(ByVal Value As String)
                _CompAddress1 = Value
            End Set
        End Property
        Public Property CompAddress2() As String
            Get
                Return _CompAddress2
            End Get
            Set(ByVal Value As String)
                _CompAddress2 = Value
            End Set
        End Property
        Public Property CompAddress3() As String
            Get
                Return _CompAddress3
            End Get
            Set(ByVal Value As String)
                _CompAddress3 = Value
            End Set
        End Property
        Public Property CompTaxNo() As String
            Get
                Return _CompTaxNo
            End Get
            Set(ByVal Value As String)
                _CompTaxNo = Value
            End Set
        End Property
        Public Property CompRegNo() As String
            Get
                Return _CompRegNo
            End Get
            Set(ByVal Value As String)
                _CompRegNo = Value
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
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
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
        Public Property SoldPostalCode() As String
            Get
                Return _SoldPostalCode
            End Get
            Set(ByVal Value As String)
                _SoldPostalCode = Value
            End Set
        End Property
        Public Property SALSLS_Name() As String
            Get
                Return _SALSLS_Name
            End Get
            Set(ByVal Value As String)
                _SALSLS_Name = Value
            End Set
        End Property
        Public Property StatementDate() As Date
            Get
                Return _StatementDate
            End Get
            Set(ByVal Value As Date)
                _StatementDate = Value
            End Set
        End Property
        Public Property TermsCode() As String
            Get
                Return _TermsCode
            End Get
            Set(ByVal Value As String)
                _TermsCode = Value
            End Set
        End Property
        Public Property TBLART_Description() As String
            Get
                Return _TBLART_Description
            End Get
            Set(ByVal Value As String)
                _TBLART_Description = Value
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
        Public Property TBLCUR_Description() As String
            Get
                Return _TBLCUR_Description
            End Get
            Set(ByVal Value As String)
                _TBLCUR_Description = Value
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
        Public Property CreditLimit() As String
            Get
                Return _CreditLimit
            End Get
            Set(ByVal Value As String)
                _CreditLimit = Value
            End Set
        End Property
        Public Property CreditCheckFlag() As String
            Get
                Return _CreditCheckFlag
            End Get
            Set(ByVal Value As String)
                _CreditCheckFlag = Value
            End Set
        End Property
        Public Property ShortName() As String
            Get
                Return _ShortName
            End Get
            Set(ByVal Value As String)
                _ShortName = Value
            End Set
        End Property
        Public Property CustomerType() As String
            Get
                Return _CustomerType
            End Get
            Set(ByVal Value As String)
                _CustomerType = Value
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
        Public Property CreditStatus() As String
            Get
                Return _CreditStatus
            End Get
            Set(ByVal Value As String)
                _CreditStatus = Value
            End Set
        End Property
        Public Property InvoiceCount() As String
            Get
                Return _InvoiceCount
            End Get
            Set(ByVal Value As String)
                _InvoiceCount = Value
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
        Public Property CustomerClass() As String
            Get
                Return _CustomerClass
            End Get
            Set(ByVal Value As String)
                _CustomerClass = Value
            End Set
        End Property
        Public Property InvDiscCode() As String
            Get
                Return _InvDiscCode
            End Get
            Set(ByVal Value As String)
                _InvDiscCode = Value
            End Set
        End Property
        Public Property LineDiscCode() As String
            Get
                Return _LineDiscCode
            End Get
            Set(ByVal Value As String)
                _LineDiscCode = Value
            End Set
        End Property
        Public Property BalanceType() As String
            Get
                Return _BalanceType
            End Get
            Set(ByVal Value As String)
                _BalanceType = Value
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
        Public Property TaxStatus() As String
            Get
                Return _TaxStatus
            End Get
            Set(ByVal Value As String)
                _TaxStatus = Value
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
        Public Property DateLastSale() As String
            Get
                Return _DateLastSale
            End Get
            Set(ByVal Value As String)
                _DateLastSale = Value
            End Set
        End Property
        Public Property DateLastPay() As String
            Get
                Return _DateLastPay
            End Get
            Set(ByVal Value As String)
                _DateLastPay = Value
            End Set
        End Property
        Public Property OutstOrdVal() As String
            Get
                Return _OutstOrdVal
            End Get
            Set(ByVal Value As String)
                _OutstOrdVal = Value
            End Set
        End Property
        Public Property NumOutstOrd() As String
            Get
                Return _NumOutstOrd
            End Get
            Set(ByVal Value As String)
                _NumOutstOrd = Value
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
        Public Property AddTelephone() As String
            Get
                Return _AddTelephone
            End Get
            Set(ByVal Value As String)
                _AddTelephone = Value
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
        Public Property TelephoneExtn() As String
            Get
                Return _TelephoneExtn
            End Get
            Set(ByVal Value As String)
                _TelephoneExtn = Value
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
        Public Property GstExemptFlag() As String
            Get
                Return _GstExemptFlag
            End Get
            Set(ByVal Value As String)
                _GstExemptFlag = Value
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
        Public Property ContractPrcReqd() As String
            Get
                Return _ContractPrcReqd
            End Get
            Set(ByVal Value As String)
                _ContractPrcReqd = Value
            End Set
        End Property
        Public Property BackOrdReqd() As String
            Get
                Return _BackOrdReqd
            End Get
            Set(ByVal Value As String)
                _BackOrdReqd = Value
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
        Public Property StateCode() As String
            Get
                Return _StateCode
            End Get
            Set(ByVal Value As String)
                _StateCode = Value
            End Set
        End Property
        Public Property DateCustAdded() As String
            Get
                Return _DateCustAdded
            End Get
            Set(ByVal Value As String)
                _DateCustAdded = Value
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
        Public Property HighestBalance() As String
            Get
                Return _HighestBalance
            End Get
            Set(ByVal Value As String)
                _HighestBalance = Value
            End Set
        End Property
        Public Property CustomerOnHold() As String
            Get
                Return _CustomerOnHold
            End Get
            Set(ByVal Value As String)
                _CustomerOnHold = Value
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
        Public Property ShipToAddr1() As String
            Get
                Return _ShipToAddr1
            End Get
            Set(ByVal Value As String)
                _ShipToAddr1 = Value
            End Set
        End Property
        Public Property ShipToAddr2() As String
            Get
                Return _ShipToAddr2
            End Get
            Set(ByVal Value As String)
                _ShipToAddr2 = Value
            End Set
        End Property
        Public Property ShipToAddr3() As String
            Get
                Return _ShipToAddr3
            End Get
            Set(ByVal Value As String)
                _ShipToAddr3 = Value
            End Set
        End Property
        Public Property ShipToAddr4() As String
            Get
                Return _ShipToAddr4
            End Get
            Set(ByVal Value As String)
                _ShipToAddr4 = Value
            End Set
        End Property
        Public Property ShipToAddr5() As String
            Get
                Return _ShipToAddr5
            End Get
            Set(ByVal Value As String)
                _ShipToAddr5 = Value
            End Set
        End Property
        Public Property ShipPostalCode() As String
            Get
                Return _ShipPostalCode
            End Get
            Set(ByVal Value As String)
                _ShipPostalCode = Value
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
        Public Property Branch() As String
            Get
                Return _Branch
            End Get
            Set(ByVal Value As String)
                _Branch = Value
            End Set
        End Property
        Public Property SALBRN_Description() As String
            Get
                Return _SALBRN_Description
            End Get
            Set(ByVal Value As String)
                _SALBRN_Description = Value
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

#End Region

        Friend Sub New(ByVal ds As DataSet)
            Dim r As DataRow = ds.Tables("Header").rows(0)

            _CompanyName = Convert.ToString(r("CompanyName"))
            _CompAddress1 = Convert.ToString(r("CompAddress1"))
            _CompAddress2 = Convert.ToString(r("CompAddress2"))
            _CompAddress3 = Convert.ToString(r("CompAddress3"))
            _CompTaxNo = Convert.ToString(r("CompTaxNo"))
            _CompRegNo = Convert.ToString(r("CompRegNo"))
            _Customer = Convert.ToString(r("Customer"))
            _Name = Convert.ToString(r("Name"))
            _SoldToAddr1 = Convert.ToString(r("SoldToAddr1"))
            _SoldToAddr2 = Convert.ToString(r("SoldToAddr2"))
            _SoldToAddr3 = Convert.ToString(r("SoldToAddr3"))
            _SoldToAddr4 = Convert.ToString(r("SoldToAddr4"))
            _SoldToAddr5 = Convert.ToString(r("SoldToAddr5"))
            _SoldPostalCode = Convert.ToString(r("SoldPostalCode"))
            _SALSLS_Name = Convert.ToString(r("SALSLS_Name"))
            _StatementDate = Convert.ToDateTime(r("StatementDate"))
            _TermsCode = Convert.ToString(r("TermsCode"))
            _TBLART_Description = Convert.ToString(r("TBLART_Description"))
            _Currency = Convert.ToString(r("Currency"))
            _TBLCUR_Description = Convert.ToString(r("TBLCUR_Description"))
            _Contact = Convert.ToString(r("Contact"))
            _CreditLimit = Convert.ToString(r("CreditLimit"))
            _CreditCheckFlag = Convert.ToString(r("CreditCheckFlag"))
            _ShortName = Convert.ToString(r("ShortName"))
            _CustomerType = Convert.ToString(r("CustomerType"))
            _MasterAccount = Convert.ToString(r("MasterAccount"))
            _StoreNumber = Convert.ToString(r("StoreNumber"))
            _CreditStatus = Convert.ToString(r("CreditStatus"))
            _InvoiceCount = Convert.ToString(r("InvoiceCount"))
            _Salesperson = Convert.ToString(r("Salesperson"))
            _CustomerClass = Convert.ToString(r("CustomerClass"))
            _InvDiscCode = Convert.ToString(r("InvDiscCode"))
            _LineDiscCode = Convert.ToString(r("LineDiscCode"))
            _BalanceType = Convert.ToString(r("BalanceType"))
            _Area = Convert.ToString(r("Area"))
            _TaxStatus = Convert.ToString(r("TaxStatus"))
            _SpecialInstrs = Convert.ToString(r("SpecialInstrs"))
            _DateLastSale = Convert.ToString(r("DateLastSale"))
            _DateLastPay = Convert.ToString(r("DateLastPay"))
            _OutstOrdVal = Convert.ToString(r("OutstOrdVal"))
            _NumOutstOrd = Convert.ToString(r("NumOutstOrd"))
            _Telephone = Convert.ToString(r("Telephone"))
            _AddTelephone = Convert.ToString(r("AddTelephone"))
            _Fax = Convert.ToString(r("Fax"))
            _Telex = Convert.ToString(r("Telex"))
            _TelephoneExtn = Convert.ToString(r("TelephoneExtn"))
            _UserField1 = Convert.ToString(r("UserField1"))
            _UserField2 = Convert.ToString(r("UserField2"))
            _GstExemptFlag = Convert.ToString(r("GstExemptFlag"))
            _GstExemptNum = Convert.ToString(r("GstExemptNum"))
            _ContractPrcReqd = Convert.ToString(r("ContractPrcReqd"))
            _BackOrdReqd = Convert.ToString(r("BackOrdReqd"))
            _ShippingInstrs = Convert.ToString(r("ShippingInstrs"))
            _StateCode = Convert.ToString(r("StateCode"))
            _DateCustAdded = Convert.ToString(r("DateCustAdded"))
            _Nationality = Convert.ToString(r("Nationality"))
            _HighestBalance = Convert.ToString(r("HighestBalance"))
            _CustomerOnHold = Convert.ToString(r("CustomerOnHold"))
            _EdiSenderCode = Convert.ToString(r("EdiSenderCode"))
            _Email = Convert.ToString(r("Email"))
            _DocFax = Convert.ToString(r("DocFax"))
            _DocFaxContact = Convert.ToString(r("DocFaxContact"))
            _ShipToAddr1 = Convert.ToString(r("ShipToAddr1"))
            _ShipToAddr2 = Convert.ToString(r("ShipToAddr2"))
            _ShipToAddr3 = Convert.ToString(r("ShipToAddr3"))
            _ShipToAddr4 = Convert.ToString(r("ShipToAddr4"))
            _ShipToAddr5 = Convert.ToString(r("ShipToAddr5"))
            _ShipPostalCode = Convert.ToString(r("ShipPostalCode"))
            _TaxExemptNumber = Convert.ToString(r("TaxExemptNumber"))
            _Branch = Convert.ToString(r("Branch"))
            _SALBRN_Description = Convert.ToString(r("SALBRN_Description"))
            _BranchAddr1 = Convert.ToString(r("BranchAddr1"))
            _BranchAddr2 = Convert.ToString(r("BranchAddr2"))
            _BranchAddr3 = Convert.ToString(r("BranchAddr3"))

        End Sub

    End Class

End Namespace