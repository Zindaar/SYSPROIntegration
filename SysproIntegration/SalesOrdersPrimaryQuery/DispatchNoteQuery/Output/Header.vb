Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchNoteQuery.QueryData.Output
    <Serializable()> Public Class Header

#Region " Private Fields "

        Private _DispatchNote As String = ""
        Private _NextDetailLine As String = ""
        Private _SalesOrder As String = ""
        Private _Customer As String = ""
        Private _CustomerName As String = ""
        Private _ShippingInstrs As String = ""
        Private _SpecialInstrs As String = ""
        Private _DispatchComments1 As String = ""
        Private _DispatchComments2 As String = ""
        Private _DispatchComments3 As String = ""
        Private _DispatchComments4 As String = ""
        Private _UserField1 As String = ""
        Private _UserField2 As String = ""
        Private _Salesperson As String = ""
        Private _Branch As String = ""
        Private _Area As String = ""
        Private _FixExchangeRate As String = ""
        Private _ExchangeRate As String = ""
        Private _MulDiv As String = ""
        Private _Currency As String = ""
        Private _CurrencyDescription As String = ""
        Private _DiscPct1 As String = ""
        Private _DiscPct2 As String = ""
        Private _DiscPct3 As String = ""
        Private _OrderType As String = ""
        Private _InvTermsOverride As String = ""
        Private _ReprintFormat As String = ""
        Private _TaxExemptFlag As String = ""
        Private _TaxExemptOverride As String = ""
        Private _DispatchName As String = ""
        Private _PlannedDeliverDate As String = ""
        Private _ActualDeliveryDate As String = ""
        Private _ShipAddressFlag As String = ""
        Private _CustomerPoNumber As String = ""
        Private _CompanyTaxNo As String = ""
        Private _Invoice As String = ""
        Private _InvoiceCreatedDate As String = ""
        Private _DateLastInvPrt As String = ""
        Private _ConsolidateInvFlag As String = ""
        Private _TaxExemptNumber As String = ""
        Private _DispatchNoteStatus As String = ""
        Private _PrevStatus As String = ""
        Private _Reason As String = ""
        Private _StatusWhenHeld As String = ""
        Private _Nationality As String = ""
        Private _DeliveryTerms As String = ""
        Private _TransactionNature As String = ""
        Private _TransportMode As String = ""
        Private _ProcessFlag As String = ""
        Private _WebCreated As String = ""
        Private _Email As String = ""
        Private _DispatchCustName As String = ""
        Private _DispatchAddress1 As String = ""
        Private _DispatchAddress2 As String = ""
        Private _DispatchAddress3 As String = ""
        Private _DispatchAddress4 As String = ""
        Private _DispatchAddress5 As String = ""
        Private _DispatchPostalCode As String = ""
        Private _State As String = ""
        Private _CountyZip As String = ""
        Private _ExtendedTaxCode As String = ""
        Private _MultiShipCode As String = ""
        Private _Quote As String = ""
        Private _GtrReference As String = ""
        Private _LastOperator As String = ""
        Private _CreditAuthority As String = ""
#End Region

#Region " Properties "
        Public Property DispatchNote() As String
            Get
                Return _DispatchNote
            End Get
            Set(ByVal Value As String)
                _DispatchNote = Value
            End Set
        End Property
        Public Property NextDetailLine() As String
            Get
                Return _NextDetailLine
            End Get
            Set(ByVal Value As String)
                _NextDetailLine = Value
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
        Public Property DispatchComments1() As String
            Get
                Return _DispatchComments1
            End Get
            Set(ByVal Value As String)
                _DispatchComments1 = Value
            End Set
        End Property
        Public Property DispatchComments2() As String
            Get
                Return _DispatchComments2
            End Get
            Set(ByVal Value As String)
                _DispatchComments2 = Value
            End Set
        End Property
        Public Property DispatchComments3() As String
            Get
                Return _DispatchComments3
            End Get
            Set(ByVal Value As String)
                _DispatchComments3 = Value
            End Set
        End Property
        Public Property DispatchComments4() As String
            Get
                Return _DispatchComments4
            End Get
            Set(ByVal Value As String)
                _DispatchComments4 = Value
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
        Public Property Salesperson() As String
            Get
                Return _Salesperson
            End Get
            Set(ByVal Value As String)
                _Salesperson = Value
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
        Public Property Area() As String
            Get
                Return _Area
            End Get
            Set(ByVal Value As String)
                _Area = Value
            End Set
        End Property
        Public Property FixExchangeRate() As String
            Get
                Return _FixExchangeRate
            End Get
            Set(ByVal Value As String)
                _FixExchangeRate = Value
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
        Public Property DiscPct1() As String
            Get
                Return _DiscPct1
            End Get
            Set(ByVal Value As String)
                _DiscPct1 = Value
            End Set
        End Property
        Public Property DiscPct2() As String
            Get
                Return _DiscPct2
            End Get
            Set(ByVal Value As String)
                _DiscPct2 = Value
            End Set
        End Property
        Public Property DiscPct3() As String
            Get
                Return _DiscPct3
            End Get
            Set(ByVal Value As String)
                _DiscPct3 = Value
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
        Public Property InvTermsOverride() As String
            Get
                Return _InvTermsOverride
            End Get
            Set(ByVal Value As String)
                _InvTermsOverride = Value
            End Set
        End Property
        Public Property ReprintFormat() As String
            Get
                Return _ReprintFormat
            End Get
            Set(ByVal Value As String)
                _ReprintFormat = Value
            End Set
        End Property
        Public Property TaxExemptFlag() As String
            Get
                Return _TaxExemptFlag
            End Get
            Set(ByVal Value As String)
                _TaxExemptFlag = Value
            End Set
        End Property
        Public Property TaxExemptOverride() As String
            Get
                Return _TaxExemptOverride
            End Get
            Set(ByVal Value As String)
                _TaxExemptOverride = Value
            End Set
        End Property
        Public Property DispatchName() As String
            Get
                Return _DispatchName
            End Get
            Set(ByVal Value As String)
                _DispatchName = Value
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
        Public Property ShipAddressFlag() As String
            Get
                Return _ShipAddressFlag
            End Get
            Set(ByVal Value As String)
                _ShipAddressFlag = Value
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
        Public Property Invoice() As String
            Get
                Return _Invoice
            End Get
            Set(ByVal Value As String)
                _Invoice = Value
            End Set
        End Property
        Public Property InvoiceCreatedDate() As String
            Get
                Return _InvoiceCreatedDate
            End Get
            Set(ByVal Value As String)
                _InvoiceCreatedDate = Value
            End Set
        End Property
        Public Property DateLastInvPrt() As String
            Get
                Return _DateLastInvPrt
            End Get
            Set(ByVal Value As String)
                _DateLastInvPrt = Value
            End Set
        End Property
        Public Property ConsolidateInvFlag() As String
            Get
                Return _ConsolidateInvFlag
            End Get
            Set(ByVal Value As String)
                _ConsolidateInvFlag = Value
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
        Public Property DispatchNoteStatus() As String
            Get
                Return _DispatchNoteStatus
            End Get
            Set(ByVal Value As String)
                _DispatchNoteStatus = Value
            End Set
        End Property
        Public Property PrevStatus() As String
            Get
                Return _PrevStatus
            End Get
            Set(ByVal Value As String)
                _PrevStatus = Value
            End Set
        End Property
        Public Property Reason() As String
            Get
                Return _Reason
            End Get
            Set(ByVal Value As String)
                _Reason = Value
            End Set
        End Property
        Public Property StatusWhenHeld() As String
            Get
                Return _StatusWhenHeld
            End Get
            Set(ByVal Value As String)
                _StatusWhenHeld = Value
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
        Public Property TransactionNature() As String
            Get
                Return _TransactionNature
            End Get
            Set(ByVal Value As String)
                _TransactionNature = Value
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
        Public Property WebCreated() As String
            Get
                Return _WebCreated
            End Get
            Set(ByVal Value As String)
                _WebCreated = Value
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
        Public Property DispatchCustName() As String
            Get
                Return _DispatchCustName
            End Get
            Set(ByVal Value As String)
                _DispatchCustName = Value
            End Set
        End Property
        Public Property DispatchAddress1() As String
            Get
                Return _DispatchAddress1
            End Get
            Set(ByVal Value As String)
                _DispatchAddress1 = Value
            End Set
        End Property
        Public Property DispatchAddress2() As String
            Get
                Return _DispatchAddress2
            End Get
            Set(ByVal Value As String)
                _DispatchAddress2 = Value
            End Set
        End Property
        Public Property DispatchAddress3() As String
            Get
                Return _DispatchAddress3
            End Get
            Set(ByVal Value As String)
                _DispatchAddress3 = Value
            End Set
        End Property
        Public Property DispatchAddress4() As String
            Get
                Return _DispatchAddress4
            End Get
            Set(ByVal Value As String)
                _DispatchAddress4 = Value
            End Set
        End Property
        Public Property DispatchAddress5() As String
            Get
                Return _DispatchAddress5
            End Get
            Set(ByVal Value As String)
                _DispatchAddress5 = Value
            End Set
        End Property
        Public Property DispatchPostalCode() As String
            Get
                Return _DispatchPostalCode
            End Get
            Set(ByVal Value As String)
                _DispatchPostalCode = Value
            End Set
        End Property
        Public Property State() As String
            Get
                Return _State
            End Get
            Set(ByVal Value As String)
                _State = Value
            End Set
        End Property
        Public Property CountyZip() As String
            Get
                Return _CountyZip
            End Get
            Set(ByVal Value As String)
                _CountyZip = Value
            End Set
        End Property
        Public Property ExtendedTaxCode() As String
            Get
                Return _ExtendedTaxCode
            End Get
            Set(ByVal Value As String)
                _ExtendedTaxCode = Value
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
        Public Property Quote() As String
            Get
                Return _Quote
            End Get
            Set(ByVal Value As String)
                _Quote = Value
            End Set
        End Property
        Public Property GtrReference() As String
            Get
                Return _GtrReference
            End Get
            Set(ByVal Value As String)
                _GtrReference = Value
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
        Public Property CreditAuthority() As String
            Get
                Return _CreditAuthority
            End Get
            Set(ByVal Value As String)
                _CreditAuthority = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDS(ByVal ds As DataSet) As Header

            Dim dh As New Header

            Dim rootTable As DataTable = ds.Tables("DispatchNoteDetail")
            Dim rootRow As DataRow = rootTable.Rows(0)

            With dh
                Try : .DispatchNote = rootRow.Item("DispatchNote").ToString : Catch ex As ArgumentException : End Try
                Try : .NextDetailLine = rootRow.Item("NextDetailLine").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrder = rootRow.Item("SalesOrder").ToString : Catch ex As ArgumentException : End Try
                Try : .Customer = rootRow.Item("Customer").ToString : Catch ex As ArgumentException : End Try
                Try : .CustomerName = rootRow.Item("CustomerName").ToString : Catch ex As ArgumentException : End Try
                Try : .ShippingInstrs = rootRow.Item("ShippingInstrs").ToString : Catch ex As ArgumentException : End Try
                Try : .SpecialInstrs = rootRow.Item("SpecialInstrs").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchComments1 = rootRow.Item("DispatchComments1").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchComments2 = rootRow.Item("DispatchComments2").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchComments3 = rootRow.Item("DispatchComments3").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchComments4 = rootRow.Item("DispatchComments4").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField1 = rootRow.Item("UserField1").ToString : Catch ex As ArgumentException : End Try
                Try : .UserField2 = rootRow.Item("UserField2").ToString : Catch ex As ArgumentException : End Try
                Try : .Salesperson = rootRow.Item("Salesperson").ToString : Catch ex As ArgumentException : End Try
                Try : .Branch = rootRow.Item("Branch").ToString : Catch ex As ArgumentException : End Try
                Try : .Area = rootRow.Item("Area").ToString : Catch ex As ArgumentException : End Try
                Try : .FixExchangeRate = rootRow.Item("FixExchangeRate").ToString : Catch ex As ArgumentException : End Try
                Try : .ExchangeRate = rootRow.Item("ExchangeRate").ToString : Catch ex As ArgumentException : End Try
                Try : .MulDiv = rootRow.Item("MulDiv").ToString : Catch ex As ArgumentException : End Try
                Try : .Currency = rootRow.Item("Currency").ToString : Catch ex As ArgumentException : End Try
                Try : .CurrencyDescription = rootRow.Item("CurrencyDescription").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct1 = rootRow.Item("DiscPct1").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct2 = rootRow.Item("DiscPct2").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct3 = rootRow.Item("DiscPct3").ToString : Catch ex As ArgumentException : End Try
                Try : .OrderType = rootRow.Item("OrderType").ToString : Catch ex As ArgumentException : End Try
                Try : .InvTermsOverride = rootRow.Item("InvTermsOverride").ToString : Catch ex As ArgumentException : End Try
                Try : .ReprintFormat = rootRow.Item("ReprintFormat").ToString : Catch ex As ArgumentException : End Try
                Try : .TaxExemptFlag = rootRow.Item("TaxExemptFlag").ToString : Catch ex As ArgumentException : End Try
                Try : .TaxExemptOverride = rootRow.Item("TaxExemptOverride").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchName = rootRow.Item("DispatchName").ToString : Catch ex As ArgumentException : End Try
                Try : .PlannedDeliverDate = rootRow.Item("PlannedDeliverDate").ToString : Catch ex As ArgumentException : End Try
                Try : .ActualDeliveryDate = rootRow.Item("ActualDeliveryDate").ToString : Catch ex As ArgumentException : End Try
                Try : .ShipAddressFlag = rootRow.Item("ShipAddressFlag").ToString : Catch ex As ArgumentException : End Try
                Try : .CustomerPoNumber = rootRow.Item("CustomerPoNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .CompanyTaxNo = rootRow.Item("CompanyTaxNo").ToString : Catch ex As ArgumentException : End Try
                Try : .Invoice = rootRow.Item("Invoice").ToString : Catch ex As ArgumentException : End Try
                Try : .InvoiceCreatedDate = rootRow.Item("InvoiceCreatedDate").ToString : Catch ex As ArgumentException : End Try
                Try : .DateLastInvPrt = rootRow.Item("DateLastInvPrt").ToString : Catch ex As ArgumentException : End Try
                Try : .ConsolidateInvFlag = rootRow.Item("ConsolidateInvFlag").ToString : Catch ex As ArgumentException : End Try
                Try : .TaxExemptNumber = rootRow.Item("TaxExemptNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchNoteStatus = rootRow.Item("DispatchNoteStatus").ToString : Catch ex As ArgumentException : End Try
                Try : .PrevStatus = rootRow.Item("PrevStatus").ToString : Catch ex As ArgumentException : End Try
                Try : .Reason = rootRow.Item("Reason").ToString : Catch ex As ArgumentException : End Try
                Try : .StatusWhenHeld = rootRow.Item("StatusWhenHeld").ToString : Catch ex As ArgumentException : End Try
                Try : .Nationality = rootRow.Item("Nationality").ToString : Catch ex As ArgumentException : End Try
                Try : .DeliveryTerms = rootRow.Item("DeliveryTerms").ToString : Catch ex As ArgumentException : End Try
                Try : .TransactionNature = rootRow.Item("TransactionNature").ToString : Catch ex As ArgumentException : End Try
                Try : .TransportMode = rootRow.Item("TransportMode").ToString : Catch ex As ArgumentException : End Try
                Try : .ProcessFlag = rootRow.Item("ProcessFlag").ToString : Catch ex As ArgumentException : End Try
                Try : .WebCreated = rootRow.Item("WebCreated").ToString : Catch ex As ArgumentException : End Try
                Try : .Email = rootRow.Item("Email").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchCustName = rootRow.Item("DispatchCustName").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchAddress1 = rootRow.Item("DispatchAddress1").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchAddress2 = rootRow.Item("DispatchAddress2").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchAddress3 = rootRow.Item("DispatchAddress3").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchAddress4 = rootRow.Item("DispatchAddress4").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchAddress5 = rootRow.Item("DispatchAddress5").ToString : Catch ex As ArgumentException : End Try
                Try : .DispatchPostalCode = rootRow.Item("DispatchPostalCode").ToString : Catch ex As ArgumentException : End Try
                Try : .State = rootRow.Item("State").ToString : Catch ex As ArgumentException : End Try
                Try : .CountyZip = rootRow.Item("CountyZip").ToString : Catch ex As ArgumentException : End Try
                Try : .ExtendedTaxCode = rootRow.Item("ExtendedTaxCode").ToString : Catch ex As ArgumentException : End Try
                Try : .MultiShipCode = rootRow.Item("MultiShipCode").ToString : Catch ex As ArgumentException : End Try
                Try : .Quote = rootRow.Item("Quote").ToString : Catch ex As ArgumentException : End Try
                Try : .GtrReference = rootRow.Item("GtrReference").ToString : Catch ex As ArgumentException : End Try
                Try : .LastOperator = rootRow.Item("LastOperator").ToString : Catch ex As ArgumentException : End Try
                Try : .CreditAuthority = rootRow.Item("CreditAuthority").ToString : Catch ex As ArgumentException : End Try

            End With

            Return dh

        End Function
    End Class
End Namespace
