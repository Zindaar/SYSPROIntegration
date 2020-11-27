Namespace TransactionObjects.SalesOrder
    <Serializable()> Public Class SalesOrder
        Implements ITransaction

#Region "Local Variables"
        'Pameters
        Private _InBoxMsgReqd As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _Process As CommonEnums.ProcessEnum = CommonEnums.ProcessEnum.Validate '
        Private _CustomerToUse As String  'max 7
        Private _WarehouseListToUse As String '
        Private _TypeOfOrder As CommonEnums.OrderTypeEnum = CommonEnums.OrderTypeEnum.ORD '
        Private _OrderStatus As String 'max 1
        Private _MinimumDaysToShip As Integer '2 digits
        Private _AllowNonStockItems As CommonEnums.YesNoEnum '
        Private _AcceptOrdersIfNoCredit As CommonEnums.YesNoEnum '
        Private _AcceptEarlierShipDate As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _OperatorToInform As String 'max 6
        Private _CreditFailMessage As String '
        Private _ValidProductClassList As String '
        Private _ShipFromDefaultBin As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes '
        Private _AllowDuplicateOrderNumbers As CommonEnums.YesNoAlwaysEnum = CommonEnums.YesNoAlwaysEnum.No '
        Private _AllowInvoiceInformationEntry As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No  '
        Private _AlwaysUsePriceEntered As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No  '
        Private _AllowZeroPrice As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No  '
        Private _AddStockSalesOrderText As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _AddDangerousGoodsText As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _UseStockDescSupplied As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No  '
        Private _ValidateShippingInstrs As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No  '
        Private _AddAttachedServiceCharges As CommonEnums.AddAttachedServiceCharges = CommonEnums.AddAttachedServiceCharges.No
        Private _AllocationAction As CommonEnums.AllocationAction
        Private _AllowChangeToZeroPrice As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _CheckForCustomerPoNumbers As CommonEnums.CheckForCustomerPoNumbers
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        'Transmission
        Private _TransmissionReference As String 'max 14
        Private _SenderCode As String 'max 40
        Private _ReceiverCode As String 'max 40
        Private _DatePrepared As Date = Now

        'Data
        Private _CustomerPoNumber As String 'max 30
        Private _OrderActionType As CommonEnums.ActionTypeEnum
        Private _NewCustomerPoNumber As String 'max 30
        Private _Supplier As String  'max 7
        Private _Customer As String 'max 7
        Private _OrderDate As Date '
        Private _InvoiceTerms As String 'max 2
        Private _Currency As String 'max 3
        Private _ShippingInstrs As String 'max 30
        Private _CustomerName As String 'max 30
        Private _ShipAddress1 As String 'max 40
        Private _ShipAddress2 As String 'max 40
        Private _ShipAddress3 As String 'max 40
        Private _ShipAddress4 As String 'max 40
        Private _ShipAddress5 As String 'max 40
        Private _ShipPostalCode As String 'max 9
        Private _Email As String 'max 50
        Private _OrderDiscPercent1 As Decimal '3.2 numeric
        Private _OrderDiscPercent2 As Decimal '2.2 numeric
        Private _OrderDiscPercent3 As Decimal '2.2 numeric
        Private _Warehouse As String 'max 2
        Private _SpecialInstrs As String 'max 30
        Private _SalesOrder As String 'max 6
        Private _OrderType As String 'max 2
        Private _MultiShipCode As String 'max 5
        Private _AlternateReference As String  '
        Private _Salesperson As String 'max 3
        Private _RequestedShipDate As Date '
        Private _InvoiceNumberEntered As String 'max 6
        Private _InvoiceDateEntered As Date
        Private _OrderComments As String  'max 180
        Private _Nationality As String  'max 3
        Private _DeliveryTerms As String  'max 3
        Private _TransactionNature As Integer  '3 digits
        Private _TransportMode As Integer  '2 digits
        Private _ProcessFlag As Integer  '1 digit
        Private _TaxExemptNumber As String  'max 30
        Private _GstExemptNumber As String  'max 15
        Private _CompanyTaxNumber As String  'max 15
        Private _CancelReasonCode As String   'max 6
        Private _Area As String 'max 2
        Private _Branch As String 'max 2
        Private _DocumentFormat As String 'max 1
        Private _State As String 'max 2
        Private _CountyZip As String 'max 5
        Private _City As String 'max 3


        'Collections
        Private _StockLines As New ArrayList
        Private _CommentLines As New ArrayList
        Private _MiscChargeLines As New ArrayList
        Private _FreightLines As New ArrayList

        'Interface variable
        Private _ActionType As CommonEnums.ActionType_Transaction

        'Return Value
        Private _ReturnValue As String 'SalesOrder
#End Region

#Region "Public Properties"
        Public ReadOnly Property HandleSpecialCharacters(ByVal strStringToCheck As String) As String
            Get
                strStringToCheck = Replace(strStringToCheck, "&", "&amp;")
                strStringToCheck = Replace(strStringToCheck, "'", "&apos;")
                strStringToCheck = Replace(strStringToCheck, """", "&quot;")
                strStringToCheck = Replace(strStringToCheck, "<", "&lt;")
                strStringToCheck = Replace(strStringToCheck, ">", "&gt;")
                Return strStringToCheck
            End Get
        End Property

        'Parameters
        Public Property InBoxMsgReqd() As CommonEnums.YesNoEnum
            Get
                Return _InBoxMsgReqd
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _InBoxMsgReqd = Value
            End Set
        End Property
        Public Property Process() As CommonEnums.ProcessEnum
            Get
                Return _Process
            End Get
            Set(ByVal Value As CommonEnums.ProcessEnum)
                _Process = Value
            End Set
        End Property
        Public Property CustomerToUse() As String
            Get
                Return HandleSpecialCharacters(_CustomerToUse)
            End Get
            Set(ByVal Value As String)
                _CustomerToUse = Value
            End Set
        End Property
        Public Property WarehouseListToUse() As String
            Get
                Return HandleSpecialCharacters(_WarehouseListToUse)
            End Get
            Set(ByVal Value As String)
                _WarehouseListToUse = Value
            End Set
        End Property
        Public Property TypeOfOrder() As CommonEnums.OrderTypeEnum
            Get
                Return _TypeOfOrder
            End Get
            Set(ByVal Value As CommonEnums.OrderTypeEnum)
                _TypeOfOrder = Value
            End Set
        End Property
        Public Property OrderStatus() As String
            Get
                Return HandleSpecialCharacters(_OrderStatus)
            End Get
            Set(ByVal Value As String)
                _OrderStatus = Value
            End Set
        End Property
        Public Property MinimumDaysToShip() As Integer
            Get
                Return _MinimumDaysToShip
            End Get
            Set(ByVal Value As Integer)
                _MinimumDaysToShip = Value
            End Set
        End Property
        Public Property AllowNonStockItems() As CommonEnums.YesNoEnum
            Get
                Return _AllowNonStockItems
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowNonStockItems = Value
            End Set
        End Property
        Public Property AcceptOrdersIfNoCredit() As CommonEnums.YesNoEnum
            Get
                Return _AcceptOrdersIfNoCredit
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AcceptOrdersIfNoCredit = Value
            End Set
        End Property
        Public Property AcceptEarlierShipDate() As CommonEnums.YesNoEnum
            Get
                Return _AcceptEarlierShipDate
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AcceptEarlierShipDate = Value
            End Set
        End Property
        Public Property OperatorToInform() As String
            Get
                Return HandleSpecialCharacters(_OperatorToInform)
            End Get
            Set(ByVal Value As String)
                _OperatorToInform = Value
            End Set
        End Property
        Public Property CreditFailMessage() As String
            Get
                Return HandleSpecialCharacters(_CreditFailMessage)
            End Get
            Set(ByVal Value As String)
                _CreditFailMessage = Value
            End Set
        End Property
        Public Property ValidProductClassList() As String
            Get
                Return HandleSpecialCharacters(_ValidProductClassList)
            End Get
            Set(ByVal Value As String)
                _ValidProductClassList = Value
            End Set
        End Property
        Public Property ShipFromDefaultBin() As CommonEnums.YesNoEnum
            Get
                Return _ShipFromDefaultBin
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ShipFromDefaultBin = Value
            End Set
        End Property
        Public Property AllowDuplicateOrderNumbers() As CommonEnums.YesNoAlwaysEnum
            Get
                Return _AllowDuplicateOrderNumbers
            End Get
            Set(ByVal Value As CommonEnums.YesNoAlwaysEnum)
                _AllowDuplicateOrderNumbers = Value
            End Set
        End Property
        Public Property AllowInvoiceInformationEntry() As CommonEnums.YesNoEnum
            Get
                Return _AllowInvoiceInformationEntry
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowInvoiceInformationEntry = Value
            End Set
        End Property
        Public Property AlwaysUsePriceEntered() As CommonEnums.YesNoEnum
            Get
                Return _AlwaysUsePriceEntered
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AlwaysUsePriceEntered = Value
            End Set
        End Property
        Public Property AllowZeroPrice() As CommonEnums.YesNoEnum
            Get
                Return _AllowZeroPrice
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowZeroPrice = Value
            End Set
        End Property
        Public Property AddStockSalesOrderText() As CommonEnums.YesNoEnum
            Get
                Return _AddStockSalesOrderText
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AddStockSalesOrderText = Value
            End Set
        End Property
        Public Property AddDangerousGoodsText() As CommonEnums.YesNoEnum
            Get
                Return _AddDangerousGoodsText
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AddDangerousGoodsText = Value
            End Set
        End Property
        Public Property UseStockDescSupplied() As CommonEnums.YesNoEnum
            Get
                Return _UseStockDescSupplied
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _UseStockDescSupplied = Value
            End Set
        End Property
        Public Property ValidateShippingInstrs() As CommonEnums.YesNoEnum
            Get
                Return _ValidateShippingInstrs
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateShippingInstrs = Value
            End Set
        End Property
        Public Property AddAttachedServiceCharges() As CommonEnums.AddAttachedServiceCharges
            Get
                Return _AddAttachedServiceCharges
            End Get
            Set(ByVal value As CommonEnums.AddAttachedServiceCharges)
                _AddAttachedServiceCharges = value
            End Set
        End Property
        Public Property AllocationAction() As CommonEnums.AllocationAction
            Get
                Return _AllocationAction
            End Get
            Set(ByVal value As CommonEnums.AllocationAction)
                _AllocationAction = value
            End Set
        End Property
        Public Property AllowChangeToZeroPrice() As CommonEnums.YesNoEnum
            Get
                Return _AllowChangeToZeroPrice
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _AllowChangeToZeroPrice = value
            End Set
        End Property
        Public Property CheckForCustomerPoNumbers() As CommonEnums.CheckForCustomerPoNumbers
            Get
                Return _CheckForCustomerPoNumbers
            End Get
            Set(ByVal value As CommonEnums.CheckForCustomerPoNumbers)
                _CheckForCustomerPoNumbers = value
            End Set
        End Property
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = value
            End Set
        End Property


        'Transmission
        Public Property TransmissionReference() As String
            Get
                Return HandleSpecialCharacters(_TransmissionReference)
            End Get
            Set(ByVal Value As String)
                _TransmissionReference = Value
            End Set
        End Property
        Public Property SenderCode() As String
            Get
                Return HandleSpecialCharacters(_SenderCode)
            End Get
            Set(ByVal Value As String)
                _SenderCode = Value
            End Set
        End Property
        Public Property ReceiverCode() As String
            Get
                Return HandleSpecialCharacters(_ReceiverCode)
            End Get
            Set(ByVal Value As String)
                _ReceiverCode = Value
            End Set
        End Property
        Public Property DatePrepared() As Date
            Get
                Return _DatePrepared
            End Get
            Set(ByVal Value As Date)
                _DatePrepared = Value
            End Set
        End Property


        'Data
        Public Property CustomerPoNumber() As String
            Get
                Return HandleSpecialCharacters(_CustomerPoNumber)
            End Get
            Set(ByVal Value As String)
                _CustomerPoNumber = Value
            End Set
        End Property
        Public Property OrderActionType() As CommonEnums.ActionTypeEnum  'CommonEnums.ActionType_Transaction Implements ITransaction.ActionType
            Get
                Return _OrderActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _OrderActionType = Value
            End Set
        End Property
        Public Property NewCustomerPoNumber() As String
            Get
                Return HandleSpecialCharacters(_NewCustomerPoNumber)
            End Get
            Set(ByVal Value As String)
                _NewCustomerPoNumber = Value
            End Set
        End Property
        Public Property Supplier() As String
            Get
                Return HandleSpecialCharacters(_Supplier)
            End Get
            Set(ByVal Value As String)
                _Supplier = Value
            End Set
        End Property
        Public Property Customer() As String
            Get
                Return HandleSpecialCharacters(_Customer)
            End Get
            Set(ByVal Value As String)
                _Customer = Value
            End Set
        End Property
        Public Property OrderDate() As Date
            Get
                Return _OrderDate
            End Get
            Set(ByVal Value As Date)
                _OrderDate = Value
            End Set
        End Property
        Public Property InvoiceTerms() As String
            Get
                Return HandleSpecialCharacters(_InvoiceTerms)
            End Get
            Set(ByVal Value As String)
                _InvoiceTerms = Value
            End Set
        End Property
        Public Property Currency() As String
            Get
                Return HandleSpecialCharacters(_Currency)
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property
        Public Property ShippingInstrs() As String
            Get
                Return HandleSpecialCharacters(_ShippingInstrs)
            End Get
            Set(ByVal Value As String)
                _ShippingInstrs = Value
            End Set
        End Property
        Public Property CustomerName() As String
            Get
                Return HandleSpecialCharacters(_CustomerName)
            End Get
            Set(ByVal Value As String)
                _CustomerName = Value
            End Set
        End Property
        Public Property ShipAddress1() As String
            Get
                Return HandleSpecialCharacters(_ShipAddress1)
            End Get
            Set(ByVal Value As String)
                _ShipAddress1 = Value
            End Set
        End Property
        Public Property ShipAddress2() As String
            Get
                Return HandleSpecialCharacters(_ShipAddress2)
            End Get
            Set(ByVal Value As String)
                _ShipAddress2 = Value
            End Set
        End Property
        Public Property ShipAddress3() As String
            Get
                Return HandleSpecialCharacters(_ShipAddress3)
            End Get
            Set(ByVal Value As String)
                _ShipAddress3 = Value
            End Set
        End Property
        Public Property ShipAddress4() As String
            Get
                Return HandleSpecialCharacters(_ShipAddress4)
            End Get
            Set(ByVal Value As String)
                _ShipAddress4 = Value
            End Set
        End Property
        Public Property ShipAddress5() As String
            Get
                Return HandleSpecialCharacters(_ShipAddress5)
            End Get
            Set(ByVal Value As String)
                _ShipAddress5 = Value
            End Set
        End Property
        Public Property ShipPostalCode() As String
            Get
                Return HandleSpecialCharacters(_ShipPostalCode)
            End Get
            Set(ByVal Value As String)
                _ShipPostalCode = Value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return HandleSpecialCharacters(_Email)
            End Get
            Set(ByVal Value As String)
                _Email = Value
            End Set
        End Property
        Public Property OrderDiscPercent1() As Decimal
            Get
                Return _OrderDiscPercent1
            End Get
            Set(ByVal Value As Decimal)
                _OrderDiscPercent1 = Value
            End Set
        End Property
        Public Property OrderDiscPercent2() As Decimal
            Get
                Return _OrderDiscPercent2
            End Get
            Set(ByVal Value As Decimal)
                _OrderDiscPercent2 = Value
            End Set
        End Property
        Public Property OrderDiscPercent3() As Decimal
            Get
                Return _OrderDiscPercent3
            End Get
            Set(ByVal Value As Decimal)
                _OrderDiscPercent3 = Value
            End Set
        End Property
        Public Property Warehouse() As String
            Get
                Return HandleSpecialCharacters(_Warehouse)
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property
        Public Property SpecialInstrs() As String
            Get
                Return HandleSpecialCharacters(_SpecialInstrs)
            End Get
            Set(ByVal Value As String)
                _SpecialInstrs = Value
            End Set
        End Property
        Public Property SalesOrder() As String
            Get
                Return HandleSpecialCharacters(_SalesOrder)
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property OrderType() As String
            Get
                Return HandleSpecialCharacters(_OrderType)
            End Get
            Set(ByVal Value As String)
                _OrderType = Value
            End Set
        End Property
        Public Property MultiShipCode() As String
            Get
                Return HandleSpecialCharacters(_MultiShipCode)
            End Get
            Set(ByVal Value As String)
                _MultiShipCode = Value
            End Set
        End Property
        Public Property AlternateReference() As String
            Get
                Return HandleSpecialCharacters(_AlternateReference)
            End Get
            Set(ByVal Value As String)
                _AlternateReference = Value
            End Set
        End Property
        Public Property Salesperson() As String
            Get
                Return HandleSpecialCharacters(_Salesperson)
            End Get
            Set(ByVal Value As String)
                _Salesperson = Value
            End Set
        End Property
        Public Property RequestedShipDate() As Date
            Get
                Return _RequestedShipDate
            End Get
            Set(ByVal Value As Date)
                _RequestedShipDate = Value
            End Set
        End Property
        Public Property InvoiceNumberEntered() As String
            Get
                Return HandleSpecialCharacters(_InvoiceNumberEntered)
            End Get
            Set(ByVal Value As String)
                _InvoiceNumberEntered = Value
            End Set
        End Property
        Public Property InvoiceDateEntered() As Date
            Get
                Return _InvoiceDateEntered
            End Get
            Set(ByVal Value As Date)
                _InvoiceDateEntered = Value
            End Set
        End Property
        Public Property OrderComments() As String
            Get
                Return HandleSpecialCharacters(_OrderComments)
            End Get
            Set(ByVal Value As String)
                _OrderComments = Value
            End Set
        End Property
        Public Property Nationality() As String
            Get
                Return HandleSpecialCharacters(_Nationality)
            End Get
            Set(ByVal Value As String)
                _Nationality = Value
            End Set
        End Property
        Public Property DeliveryTerms() As String
            Get
                Return HandleSpecialCharacters(_DeliveryTerms)
            End Get
            Set(ByVal Value As String)
                _DeliveryTerms = Value
            End Set
        End Property
        Public Property TransactionNature() As Integer
            Get
                Return _TransactionNature
            End Get
            Set(ByVal Value As Integer)
                _TransactionNature = Value
            End Set
        End Property
        Public Property TransportMode() As Integer
            Get
                Return _TransportMode
            End Get
            Set(ByVal Value As Integer)
                _TransportMode = Value
            End Set
        End Property
        Public Property ProcessFlag() As Integer
            Get
                Return _ProcessFlag
            End Get
            Set(ByVal Value As Integer)
                _ProcessFlag = Value
            End Set
        End Property
        Public Property TaxExemptNumber() As String
            Get
                Return HandleSpecialCharacters(_TaxExemptNumber)
            End Get
            Set(ByVal Value As String)
                _TaxExemptNumber = Value
            End Set
        End Property
        Public Property GstExemptNumber() As String
            Get
                Return HandleSpecialCharacters(_GstExemptNumber)
            End Get
            Set(ByVal Value As String)
                _GstExemptNumber = Value
            End Set
        End Property
        Public Property CompanyTaxNumber() As String
            Get
                Return HandleSpecialCharacters(_CompanyTaxNumber)
            End Get
            Set(ByVal Value As String)
                _CompanyTaxNumber = Value
            End Set
        End Property
        Public Property CancelReasonCode() As String
            Get
                Return HandleSpecialCharacters(_CancelReasonCode)
            End Get
            Set(ByVal Value As String)
                _CancelReasonCode = Value
            End Set
        End Property
        Public Property Area() As String
            Get
                Return HandleSpecialCharacters(_Area)
            End Get
            Set(ByVal Value As String)
                _Area = Value
            End Set
        End Property
        Public Property Branch() As String
            Get
                Return HandleSpecialCharacters(_Branch)
            End Get
            Set(ByVal Value As String)
                _Branch = Value
            End Set
        End Property

        'Collections
        Public Property StockLines() As ArrayList
            Get
                Return _StockLines
            End Get
            Set(ByVal Value As ArrayList)
                _StockLines = Value
            End Set
        End Property
        Public Property CommentLines() As ArrayList
            Get
                Return _CommentLines
            End Get
            Set(ByVal Value As ArrayList)
                _CommentLines = Value
            End Set
        End Property
        Public Property MiscChargeLines() As ArrayList
            Get
                Return _MiscChargeLines
            End Get
            Set(ByVal Value As ArrayList)
                _MiscChargeLines = Value
            End Set
        End Property
        Public Property FreightLines() As ArrayList
            Get
                Return _FreightLines
            End Get
            Set(ByVal Value As ArrayList)
                _FreightLines = Value
            End Set
        End Property
        Public Property DocumentFormat() As String
            Get
                Return HandleSpecialCharacters(_DocumentFormat)
            End Get
            Set(ByVal value As String)
                _DocumentFormat = value
            End Set
        End Property
        Public Property State() As String
            Get
                Return HandleSpecialCharacters(_State)
            End Get
            Set(ByVal value As String)
                _State = value
            End Set
        End Property
        Public Property CountyZip() As String
            Get
                Return HandleSpecialCharacters(_CountyZip)
            End Get
            Set(ByVal value As String)
                _CountyZip = value
            End Set
        End Property
        Public Property City() As String
            Get
                Return HandleSpecialCharacters(_City)
            End Get
            Set(ByVal value As String)
                _City = value
            End Set
        End Property

        'Return Value
        Public Property ReturnValue() As String
            Get
                Return _ReturnValue
            End Get
            Set(ByVal value As String)
                _ReturnValue = value
            End Set
        End Property

#End Region

        'Constructor
        Public Sub New()
        End Sub

#Region "Collections"
        Public Sub AddStockLine(ByVal StockLine As SalesOrderStockLine)
            _StockLines.Add(StockLine)
        End Sub
        Public Sub RemoveStockLine(ByVal StockLine As SalesOrderStockLine)
            _StockLines.Remove(StockLine)
        End Sub
        Public Sub AddCommentLine(ByVal CommentLine As SalesOrderCommentLine)
            _CommentLines.Add(CommentLine)
        End Sub
        Public Sub RemoveCommentLine(ByVal CommentLine As SalesOrderCommentLine)
            _CommentLines.Remove(CommentLine)
        End Sub
        Public Sub AddMiscChargeLine(ByVal MiscChargeLine As SalesOrderMiscChargeLine)
            _MiscChargeLines.Add(MiscChargeLine)
        End Sub
        Public Sub RemoveMiscChargeLine(ByVal MiscChargeLine As SalesOrderMiscChargeLine)
            _MiscChargeLines.Remove(MiscChargeLine)
        End Sub
        Public Sub AddFreightLine(ByVal FreightLine As SalesOrderFreightLine)
            _FreightLines.Add(FreightLine)
        End Sub
        Public Sub RemoveFreightLine(ByVal FreightLine As SalesOrderFreightLine)
            _FreightLines.Remove(FreightLine)
        End Sub
        Public Sub ClearStockLines()
            _StockLines.Clear()
        End Sub
        Public Sub ClearCommentLines()
            _CommentLines.Clear()
        End Sub
        Public Sub ClearMiscChargeLines()
            _MiscChargeLines.Clear()
        End Sub
        Public Sub ClearFreightLines()
            _FreightLines.Clear()
        End Sub

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "SORTOI"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Order/SalesOrder")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim sbXMLParam As New System.Text.StringBuilder

                'Build an XML string to pass parameters
                sbXMLParam.Append("<SalesOrders>" & vbCrLf)
                sbXMLParam.Append("<Parameters>" & vbCrLf)
                sbXMLParam.AppendFormat("<InBoxMsgReqd>{0}</InBoxMsgReqd>" & vbCrLf, Left(InBoxMsgReqd.ToString, 1))
                sbXMLParam.AppendFormat("<Process>{0}</Process>" & vbCrLf, Process.ToString)
                If Not String.IsNullOrEmpty(CustomerToUse) Then sbXMLParam.AppendFormat("<CustomerToUse>{0}</CustomerToUse>" & vbCrLf, CustomerToUse)
                If Not String.IsNullOrEmpty(WarehouseListToUse) Then sbXMLParam.AppendFormat("<WarehouseListToUse>{0}</WarehouseListToUse>" & vbCrLf, WarehouseListToUse)
                sbXMLParam.AppendFormat("<TypeOfOrder>{0}</TypeOfOrder>" & vbCrLf, TypeOfOrder.ToString)
                If Not String.IsNullOrEmpty(OrderStatus) Then sbXMLParam.AppendFormat("<OrderStatus>{0}</OrderStatus>" & vbCrLf, OrderStatus)
                sbXMLParam.AppendFormat("<MinimumDaysToShip>{0}</MinimumDaysToShip>" & vbCrLf, MinimumDaysToShip)
                sbXMLParam.AppendFormat("<AllowNonStockItems>{0}</AllowNonStockItems>" & vbCrLf, Left(AllowNonStockItems.ToString, 1))
                sbXMLParam.AppendFormat("<AcceptOrdersIfNoCredit>{0}</AcceptOrdersIfNoCredit>" & vbCrLf, Left(AcceptOrdersIfNoCredit.ToString, 1))
                sbXMLParam.AppendFormat("<AcceptEarlierShipDate>{0}</AcceptEarlierShipDate>" & vbCrLf, Left(AcceptEarlierShipDate.ToString, 1))
                If Not String.IsNullOrEmpty(OperatorToInform) Then sbXMLParam.AppendFormat("<OperatorToInform>{0}</OperatorToInform>" & vbCrLf, OperatorToInform)
                If Not String.IsNullOrEmpty(CreditFailMessage) Then sbXMLParam.AppendFormat("<CreditFailMessage>{0}</CreditFailMessage>" & vbCrLf, CreditFailMessage)
                If Not String.IsNullOrEmpty(ValidProductClassList) Then sbXMLParam.AppendFormat("<ValidProductClassList>{0}</ValidProductClassList>" & vbCrLf, ValidProductClassList)
                sbXMLParam.AppendFormat("<ShipFromDefaultBin>{0}</ShipFromDefaultBin>" & vbCrLf, Left(ShipFromDefaultBin.ToString, 1))
                sbXMLParam.AppendFormat("<AllowDuplicateOrderNumbers>{0}</AllowDuplicateOrderNumbers>" & vbCrLf, Left(AllowDuplicateOrderNumbers.ToString, 1))
                sbXMLParam.AppendFormat("<AllowInvoiceInformationEntry>{0}</AllowInvoiceInformationEntry>" & vbCrLf, Left(AllowInvoiceInformationEntry.ToString, 1))
                sbXMLParam.AppendFormat("<AlwaysUsePriceEntered>{0}</AlwaysUsePriceEntered>" & vbCrLf, Left(AlwaysUsePriceEntered.ToString, 1))
                sbXMLParam.AppendFormat("<AllowZeroPrice>{0}</AllowZeroPrice>" & vbCrLf, Left(AllowZeroPrice.ToString, 1))
                sbXMLParam.AppendFormat("<AddStockSalesOrderText>{0}</AddStockSalesOrderText>" & vbCrLf, Left(AddStockSalesOrderText.ToString, 1))
                sbXMLParam.AppendFormat("<AddDangerousGoodsText>{0}</AddDangerousGoodsText>" & vbCrLf, Left(AddDangerousGoodsText.ToString, 1))
                sbXMLParam.AppendFormat("<UseStockDescSupplied>{0}</UseStockDescSupplied>" & vbCrLf, Left(UseStockDescSupplied.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateShippingInstrs>{0}</ValidateShippingInstrs>" & vbCrLf, Left(ValidateShippingInstrs.ToString, 1))
                sbXMLParam.AppendFormat("<AddAttachedServiceCharges>{0}</AddAttachedServiceCharges>" & vbCrLf, Left(AddAttachedServiceCharges.ToString, 1))
                sbXMLParam.AppendFormat("<AllocationAction>{0}</AllocationAction>" & vbCrLf, Left(AllocationAction.ToString, 1))
                sbXMLParam.AppendFormat("<AllowChangeToZeroPrice>{0}</AllowChangeToZeroPrice>" & vbCrLf, Left(AllowChangeToZeroPrice.ToString, 1))
                sbXMLParam.AppendFormat("<CheckForCustomerPoNumbers>{0}</CheckForCustomerPoNumbers>" & vbCrLf, Left(CheckForCustomerPoNumbers.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>" & vbCrLf, Left(IgnoreWarnings.ToString, 1))

                sbXMLParam.Append("</Parameters>" & vbCrLf)
                sbXMLParam.Append("</SalesOrders>" & vbCrLf)

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<SalesOrders>" & vbCrLf)
                sbXMLin.Append("<TransmissionHeader>" & vbCrLf)
                If Not String.IsNullOrEmpty(TransmissionReference) Then sbXMLin.AppendFormat("<TransmissionReference>{0}</TransmissionReference>" & vbCrLf, TransmissionReference)
                If Not String.IsNullOrEmpty(SenderCode) Then sbXMLin.AppendFormat("<SenderCode>{0}</SenderCode>" & vbCrLf, SenderCode)
                If Not String.IsNullOrEmpty(ReceiverCode) Then sbXMLin.AppendFormat("<ReceiverCode>{0}</ReceiverCode>" & vbCrLf, ReceiverCode)
                If Not Format(DatePrepared, "yyyy-MM-dd") = "0001-01-01" Then sbXMLin.AppendFormat("<DatePrepared>{0}</DatePrepared>" & vbCrLf, Format(DatePrepared, "yyyy-MM-dd"))
                If Not Format(DatePrepared, "yyyy-MM-dd") = "0001-01-01" Then sbXMLin.AppendFormat("<TimePrepared>{0}</TimePrepared>" & vbCrLf, Format(DatePrepared, "t"))
                sbXMLin.Append("</TransmissionHeader>" & vbCrLf)

                sbXMLin.Append("<Orders>" & vbCrLf)
                sbXMLin.Append("<OrderHeader>" & vbCrLf)
                If Not String.IsNullOrEmpty(CustomerPoNumber) Then sbXMLin.AppendFormat("<CustomerPoNumber>{0}</CustomerPoNumber>" & vbCrLf, CustomerPoNumber)
                sbXMLin.AppendFormat("<OrderActionType>{0}</OrderActionType>" & vbCrLf, Left(OrderActionType.ToString, 1))
                If Not String.IsNullOrEmpty(CustomerPoNumber) Then sbXMLin.AppendFormat("<NewCustomerPoNumber>{0}</NewCustomerPoNumber>" & vbCrLf, NewCustomerPoNumber)
                If Not String.IsNullOrEmpty(Supplier) Then sbXMLin.AppendFormat("<Supplier>{0}</Supplier>" & vbCrLf, Supplier)
                If Not String.IsNullOrEmpty(Customer) Then sbXMLin.AppendFormat("<Customer>{0}</Customer>" & vbCrLf, Customer)
                If Not Format(OrderDate, "yyyy-MM-dd") = "0001-01-01" Then sbXMLin.AppendFormat("<OrderDate>{0}</OrderDate>" & vbCrLf, Format(OrderDate, "yyyy-MM-dd"))
                If Not String.IsNullOrEmpty(InvoiceTerms) Then sbXMLin.AppendFormat("<InvoiceTerms>{0}</InvoiceTerms>" & vbCrLf, InvoiceTerms)
                If Not String.IsNullOrEmpty(Currency) Then sbXMLin.AppendFormat("<Currency>{0}</Currency>" & vbCrLf, Currency)
                If Not String.IsNullOrEmpty(ShippingInstrs) Then sbXMLin.AppendFormat("<ShippingInstrs>{0}</ShippingInstrs>" & vbCrLf, ShippingInstrs)
                If Not String.IsNullOrEmpty(CustomerName) Then sbXMLin.AppendFormat("<CustomerName>{0}</CustomerName>" & vbCrLf, CustomerName)
                If Not String.IsNullOrEmpty(ShipAddress1) Then sbXMLin.AppendFormat("<ShipAddress1>{0}</ShipAddress1>" & vbCrLf, ShipAddress1)
                If Not String.IsNullOrEmpty(ShipAddress2) Then sbXMLin.AppendFormat("<ShipAddress2>{0}</ShipAddress2>" & vbCrLf, ShipAddress2)
                If Not String.IsNullOrEmpty(ShipAddress3) Then sbXMLin.AppendFormat("<ShipAddress3>{0}</ShipAddress3>" & vbCrLf, ShipAddress3)
                If Not String.IsNullOrEmpty(ShipAddress4) Then sbXMLin.AppendFormat("<ShipAddress4>{0}</ShipAddress4>" & vbCrLf, ShipAddress4)
                If Not String.IsNullOrEmpty(ShipAddress5) Then sbXMLin.AppendFormat("<ShipAddress5>{0}</ShipAddress5>" & vbCrLf, ShipAddress5)
                If Not String.IsNullOrEmpty(ShipPostalCode) Then sbXMLin.AppendFormat("<ShipPostalCode>{0}</ShipPostalCode>" & vbCrLf, ShipPostalCode)
                If Not String.IsNullOrEmpty(Email) Then sbXMLin.AppendFormat("<Email>{0}</Email>" & vbCrLf, Email)
                sbXMLin.AppendFormat("<OrderDiscPercent1>{0}</OrderDiscPercent1>" & vbCrLf, OrderDiscPercent1)
                sbXMLin.AppendFormat("<OrderDiscPercent2>{0}</OrderDiscPercent2>" & vbCrLf, OrderDiscPercent2)
                sbXMLin.AppendFormat("<OrderDiscPercent3>{0}</OrderDiscPercent3>" & vbCrLf, OrderDiscPercent3)
                If Not String.IsNullOrEmpty(Warehouse) Then sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>" & vbCrLf, Warehouse)
                If Not String.IsNullOrEmpty(SpecialInstrs) Then sbXMLin.AppendFormat("<SpecialInstrs>{0}</SpecialInstrs>" & vbCrLf, SpecialInstrs)
                If Not String.IsNullOrEmpty(SalesOrder) Then sbXMLin.AppendFormat("<SalesOrder>{0}</SalesOrder>" & vbCrLf, SalesOrder)
                If Not String.IsNullOrEmpty(OrderType) Then sbXMLin.AppendFormat("<OrderType>{0}</OrderType>" & vbCrLf, OrderType)
                If Not String.IsNullOrEmpty(MultiShipCode) Then sbXMLin.AppendFormat("<MultiShipCode>{0}</MultiShipCode>" & vbCrLf, MultiShipCode)
                If Not String.IsNullOrEmpty(AlternateReference) Then sbXMLin.AppendFormat("<AlternateReference>{0}</AlternateReference>" & vbCrLf, AlternateReference)
                If Not String.IsNullOrEmpty(Salesperson) Then sbXMLin.AppendFormat("<Salesperson>{0}</Salesperson>" & vbCrLf, Salesperson)
                sbXMLin.AppendFormat("<RequestedShipDate>{0}</RequestedShipDate>" & vbCrLf, Format(RequestedShipDate, "yyyy-MM-dd"))
                If Format(InvoiceDateEntered, "yyyy-MM-dd") = "0001-01-01" Then
                    sbXMLin.Append("<InvoiceNumberEntered />" & vbCrLf)
                    sbXMLin.Append("<InvoiceDateEntered />" & vbCrLf)
                Else
                    sbXMLin.AppendFormat("<InvoiceNumberEntered>{0}</InvoiceNumberEntered>" & vbCrLf, InvoiceNumberEntered)
                    sbXMLin.AppendFormat("<InvoiceDateEntered>{0}</InvoiceDateEntered>" & vbCrLf, Format(InvoiceDateEntered, "yyyy-MM-dd"))
                End If
                If Not String.IsNullOrEmpty(OrderComments) Then sbXMLin.AppendFormat("<OrderComments>{0}</OrderComments>" & vbCrLf, OrderComments)
                If Not String.IsNullOrEmpty(Nationality) Then sbXMLin.AppendFormat("<Nationality>{0}</Nationality>" & vbCrLf, Nationality)
                If Not String.IsNullOrEmpty(DeliveryTerms) Then sbXMLin.AppendFormat("<DeliveryTerms>{0}</DeliveryTerms>" & vbCrLf, DeliveryTerms)
                If Not String.IsNullOrEmpty(TransactionNature) Then sbXMLin.AppendFormat("<TransactionNature>{0}</TransactionNature>" & vbCrLf, TransactionNature)
                If Not String.IsNullOrEmpty(TransportMode) Then sbXMLin.AppendFormat("<TransportMode>{0}</TransportMode>" & vbCrLf, TransportMode)
                If Not String.IsNullOrEmpty(ProcessFlag) Then sbXMLin.AppendFormat("<ProcessFlag>{0}</ProcessFlag>" & vbCrLf, ProcessFlag)
                If Not String.IsNullOrEmpty(TaxExemptNumber) Then sbXMLin.AppendFormat("<TaxExemptNumber>{0}</TaxExemptNumber>" & vbCrLf, TaxExemptNumber)
                If Not String.IsNullOrEmpty(GstExemptNumber) Then sbXMLin.AppendFormat("<GstExemptNumber>{0}</GstExemptNumber>" & vbCrLf, GstExemptNumber)
                If Not String.IsNullOrEmpty(CompanyTaxNumber) Then sbXMLin.AppendFormat("<CompanyTaxNumber>{0}</CompanyTaxNumber>" & vbCrLf, CompanyTaxNumber)
                If Not String.IsNullOrEmpty(CancelReasonCode) Then sbXMLin.AppendFormat("<CancelReasonCode>{0}</CancelReasonCode>" & vbCrLf, CancelReasonCode)
                If Not String.IsNullOrEmpty(Area) Then sbXMLin.AppendFormat("<Area>{0}</Area>" & vbCrLf, Area)
                If Not String.IsNullOrEmpty(Branch) Then sbXMLin.AppendFormat("<Branch>{0}</Branch>" & vbCrLf, Branch)
                If Not String.IsNullOrEmpty(DocumentFormat) Then sbXMLin.AppendFormat("<DocumentFormat>{0}</DocumentFormat>" & vbCrLf, DocumentFormat)
                If Not String.IsNullOrEmpty(State) Then sbXMLin.AppendFormat("<State>{0}</State>" & vbCrLf, State)
                If Not String.IsNullOrEmpty(CountyZip) Then sbXMLin.AppendFormat("<CountyZip>{0}</CountyZip>" & vbCrLf, CountyZip)
                If Not String.IsNullOrEmpty(City) Then sbXMLin.AppendFormat("<City>{0}</City>" & vbCrLf, City)

                sbXMLin.Append("</OrderHeader>" & vbCrLf)
                sbXMLin.Append("<OrderDetails>" & vbCrLf)

                If OrderActionType = CommonEnums.ActionTypeEnum.Change Then
                    Dim blnLinesToAdd As Boolean = False
                    AddChangingOrderLines(sbXMLin, blnLinesToAdd)
                    If blnLinesToAdd Then
                        AddNewStockLines(sbXMLin)
                    End If
                ElseIf OrderActionType = CommonEnums.ActionTypeEnum.Add Then
                    'Add new lines in the order of their CustomerPOLineNumber
                    AddNewStockLines(sbXMLin)
                End If

                sbXMLin.Append("</OrderDetails>" & vbCrLf)
                sbXMLin.Append("</Orders>" & vbCrLf)
                sbXMLin.Append("</SalesOrders>" & vbCrLf)

                Return sbXMLin.ToString
            End Get
        End Property

        Private Sub AddChangingOrderLines(ByRef sbXMLin As System.Text.StringBuilder, ByRef blnLinesToAdd As Boolean)

            For Each lin As SalesOrderStockLine In StockLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Change Or lin.LineActionType = CommonEnums.ActionTypeEnum.Delete Then
                    lin.AppendStockLine(sbXMLin)
                ElseIf lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    blnLinesToAdd = True
                End If
            Next
            For Each lin As SalesOrderCommentLine In CommentLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Change Or lin.LineActionType = CommonEnums.ActionTypeEnum.Delete Then
                    lin.AppendCommentLine(sbXMLin)
                ElseIf lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    blnLinesToAdd = True
                End If
            Next
            For Each lin As SalesOrderMiscChargeLine In MiscChargeLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Change Or lin.LineActionType = CommonEnums.ActionTypeEnum.Delete Then
                    lin.AppendMiscChargeLine(sbXMLin)
                ElseIf lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    blnLinesToAdd = True
                End If
            Next
            For Each lin As SalesOrderFreightLine In FreightLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Change Or lin.LineActionType = CommonEnums.ActionTypeEnum.Delete Then
                    lin.AppendFreightLine(sbXMLin)
                ElseIf lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    blnLinesToAdd = True
                End If
            Next

        End Sub

        Private Sub AddNewStockLines(ByRef sbXMLin As System.Text.StringBuilder)

            'Determine how many lines need to be added, and at which line number to start
            Dim iLines As Integer = 0
            Dim iStartAtCustomerPOLine As Integer = Integer.MaxValue

            For Each lin As SalesOrderStockLine In StockLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    iLines += 1
                    If lin.CustomerPoLine < iStartAtCustomerPOLine Then
                        iStartAtCustomerPOLine = lin.CustomerPoLine
                    End If
                End If
            Next
            For Each lin As SalesOrderCommentLine In CommentLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    iLines += 1
                    If lin.CustomerPoLine < iStartAtCustomerPOLine Then
                        iStartAtCustomerPOLine = lin.CustomerPoLine
                    End If
                End If
            Next
            For Each lin As SalesOrderMiscChargeLine In MiscChargeLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    iLines += 1
                    If lin.CustomerPoLine < iStartAtCustomerPOLine Then
                        iStartAtCustomerPOLine = lin.CustomerPoLine
                    End If
                End If
            Next
            For Each lin As SalesOrderFreightLine In FreightLines
                If lin.LineActionType = CommonEnums.ActionTypeEnum.Add Then
                    iLines += 1
                    If lin.CustomerPoLine < iStartAtCustomerPOLine Then
                        iStartAtCustomerPOLine = lin.CustomerPoLine
                    End If
                End If
            Next

            'Now add the lines in the order order their CustomerPOLineNumber
            For iCustomerPOLineNumber As Integer = iStartAtCustomerPOLine To (iStartAtCustomerPOLine + iLines - 1)
                Dim bLineAdded As Boolean = False
                For Each stkLine As SalesOrderStockLine In StockLines
                    If stkLine.CustomerPoLine = iCustomerPOLineNumber Then
                        stkLine.AppendStockLine(sbXMLin)
                        bLineAdded = True
                        Exit For
                    End If
                Next stkLine

                If Not bLineAdded Then
                    For Each cmtLine As SalesOrderCommentLine In CommentLines
                        If cmtLine.CustomerPoLine = iCustomerPOLineNumber Then
                            cmtLine.AppendCommentLine(sbXMLin)
                            bLineAdded = True
                            Exit For
                        End If
                    Next
                End If

                If Not bLineAdded Then
                    For Each mcLine As SalesOrderMiscChargeLine In MiscChargeLines
                        If mcLine.CustomerPoLine = iCustomerPOLineNumber Then
                            mcLine.AppendMiscChargeLine(sbXMLin)
                            bLineAdded = True
                            Exit For
                        End If
                    Next
                End If

                If Not bLineAdded Then
                    For Each ftLine As SalesOrderFreightLine In FreightLines
                        If ftLine.CustomerPoLine = iCustomerPOLineNumber Then
                            ftLine.AppendFreightLine(sbXMLin)
                            bLineAdded = True
                            Exit For
                        End If
                    Next
                End If

                If Not bLineAdded Then
                    'mmm, none of the lines herewith attached have the customerPOLine we are looking for!!!!
                    Throw New Exception("A SalesOrderLine with CustomerPOLine " & iCustomerPOLineNumber.ToString & " was expected but not found in the sales order detail collections.")
                End If
            Next

        End Sub
#End Region


        Public Sub Post() Implements ITransaction.Post
            _xmlOut = Transaction.Post(Me)
            ReturnValue = Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, _xmlOut, "SalesOrder")
        End Sub
    End Class

End Namespace
