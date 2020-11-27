Namespace TransactionObjects.PurchaseOrder
    <Serializable()> Public Class PurchaseOrder
        Implements ITransaction

#Region "Local Variables"
        'Pameters
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.IgnoreWarningsEnum = CommonEnums.IgnoreWarningsEnum.Warnings
        Private _AllowNonStockItems As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AllowZeroPrice As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ValidateWorkingDays As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AllowPoWhenBlanketPo As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _DefaultMemoCode As String = "" 'max length 1
        Private _FixedExchangeRate As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _DefaultMemoDays As Integer 'max 3 digits
        Private _AllowBlankLedgerCode As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _DefaultDeliveryAddress As String = "" 'max length 5
        Private _CalcDueDate As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _InsertDangerousGoodsText As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _InsertAdditionalPOText As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _Status As Integer = 1

        'Data
        Private _OrderActionType As CommonEnums.ActionTypeEnum
        Private _Supplier As String 'max 7
        Private _ExchRateFixed As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ExchangeRate As Decimal 'format 6.6
        Private _OrderType As CommonEnums.PurchaseOrderTypeEnum = CommonEnums.PurchaseOrderTypeEnum.Local
        Private _Customer As String 'max 6
        Private _TaxStatus As CommonEnums.TaxStatusEnum = CommonEnums.TaxStatusEnum.NotExempt
        Private _PaymentTerms As String 'max 3 chars
        Private _InvoiceTerms As String 'max 2 chars
        Private _CustomerPoNumber As String 'max 5 chars
        Private _ShippingInstrs As String '30 chars
        Private _OrderDate As Date
        Private _DueDate As Date
        Private _MemoDate As Date
        Private _ApplyDueDateToLines As CommonEnums.ApplyDueDateToLinesEnum = CommonEnums.ApplyDueDateToLinesEnum.All
        Private _MemoCode As String 'max 1 char
        Private _Buyer As String '3 chars
        Private _DeliveryName As String '30 chars
        Private _DeliveryAddr1 As String '40 chars
        Private _DeliveryAddr2 As String '40 chars
        Private _DeliveryAddr3 As String '40 chars
        Private _DeliveryAddr4 As String '40 chars
        Private _DeliveryAddr5 As String '40 chars
        Private _PostalCode As String '9 chars
        Private _Warehouse As String '2 chars
        Private _DiscountLessPlus As CommonEnums.DiscountLessPlussEnum = CommonEnums.DiscountLessPlussEnum.Less
        Private _DiscPercent1 As Decimal '3.2
        Private _DiscPercent2 As Decimal '2.2
        Private _DiscPercent3 As Decimal '2.2
        Private _PurchaseOrder As String 'max 6 chars
        Private _ChgPOStatToReadyToPrint As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        'Collections
        Private _StockLines As New ArrayList
        Private _CommentLines As New ArrayList
        Private _MiscChargeLines As New ArrayList
        Private _FreightLines As New ArrayList

#End Region

#Region "Parameter Properties"

        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value
            End Set
        End Property
        Public Property IgnoreWarnings() As CommonEnums.IgnoreWarningsEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.IgnoreWarningsEnum)
                _IgnoreWarnings = Value
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
        Public Property AllowZeroPrice() As CommonEnums.YesNoEnum
            Get
                Return _AllowZeroPrice
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowZeroPrice = Value
            End Set
        End Property
        Public Property ValidateWorkingDays() As CommonEnums.YesNoEnum
            Get
                Return _ValidateWorkingDays
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateWorkingDays = Value
            End Set
        End Property
        Public Property AllowPoWhenBlanketPo() As CommonEnums.YesNoEnum
            Get
                Return _AllowPoWhenBlanketPo
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowPoWhenBlanketPo = Value
            End Set
        End Property
        Public Property DefaultMemoCode() As String
            Get
                Return _DefaultMemoCode
            End Get
            Set(ByVal Value As String)
                _DefaultMemoCode = Value
            End Set
        End Property
        Public Property FixedExchangeRate() As CommonEnums.YesNoEnum
            Get
                Return _FixedExchangeRate
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _FixedExchangeRate = Value
            End Set
        End Property
        Public Property DefaultMemoDays() As Integer
            Get
                Return _DefaultMemoDays
            End Get
            Set(ByVal Value As Integer)
                _DefaultMemoDays = Value
            End Set
        End Property
        Public Property AllowBlankLedgerCode() As CommonEnums.YesNoEnum
            Get
                Return _AllowBlankLedgerCode
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllowBlankLedgerCode = Value
            End Set
        End Property
        Public Property DefaultDeliveryAddress() As String
            Get
                Return _DefaultDeliveryAddress
            End Get
            Set(ByVal Value As String)
                _DefaultDeliveryAddress = Value
            End Set
        End Property
        Public Property CalcDueDate() As CommonEnums.YesNoEnum
            Get
                Return _CalcDueDate
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CalcDueDate = Value
            End Set
        End Property
        Public Property InsertDangerousGoodsText() As CommonEnums.YesNoEnum
            Get
                Return _InsertDangerousGoodsText
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _InsertDangerousGoodsText = Value
            End Set
        End Property
        Public Property InsertAdditionalPOText() As CommonEnums.YesNoEnum
            Get
                Return _InsertAdditionalPOText
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _InsertAdditionalPOText = Value
            End Set
        End Property
        Public Property Status() As Integer
            Get
                Return _Status
            End Get
            Set(ByVal Value As Integer)
                _Status = Value
            End Set
        End Property

#End Region

#Region " Data Properties "

        Public Property OrderActionType() As CommonEnums.ActionTypeEnum
            Get
                Return _OrderActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _OrderActionType = Value
            End Set
        End Property
        Public Property Supplier() As String
            Get
                Return _Supplier
            End Get
            Set(ByVal Value As String)
                _Supplier = Value
            End Set
        End Property
        Public Property ExchRateFixed() As CommonEnums.YesNoEnum
            Get
                Return _ExchRateFixed
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ExchRateFixed = Value
            End Set
        End Property
        Public Property ExchangeRate() As Decimal
            Get
                Return _ExchangeRate
            End Get
            Set(ByVal Value As Decimal)
                _ExchangeRate = Value
            End Set
        End Property
        Public Property OrderType() As CommonEnums.PurchaseOrderTypeEnum
            Get
                Return _OrderType
            End Get
            Set(ByVal Value As CommonEnums.PurchaseOrderTypeEnum)
                _OrderType = Value
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
        Public Property TaxStatus() As CommonEnums.TaxStatusEnum
            Get
                Return _TaxStatus
            End Get
            Set(ByVal Value As CommonEnums.TaxStatusEnum)
                _TaxStatus = Value
            End Set
        End Property
        Public Property PaymentTerms() As String
            Get
                Return _PaymentTerms
            End Get
            Set(ByVal Value As String)
                _PaymentTerms = Value
            End Set
        End Property
        Public Property InvoiceTerms() As String
            Get
                Return _InvoiceTerms
            End Get
            Set(ByVal Value As String)
                _InvoiceTerms = Value
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
        Public Property ShippingInstrs() As String
            Get
                Return _ShippingInstrs
            End Get
            Set(ByVal Value As String)
                _ShippingInstrs = Value
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
        Public Property DueDate() As Date
            Get
                Return _DueDate
            End Get
            Set(ByVal Value As Date)
                _DueDate = Value
            End Set
        End Property
        Public Property MemoDate() As Date
            Get
                Return _MemoDate
            End Get
            Set(ByVal Value As Date)
                _MemoDate = Value
            End Set
        End Property
        Public Property ApplyDueDateToLines() As CommonEnums.ApplyDueDateToLinesEnum
            Get
                Return _ApplyDueDateToLines
            End Get
            Set(ByVal Value As CommonEnums.ApplyDueDateToLinesEnum)
                _ApplyDueDateToLines = Value
            End Set
        End Property
        Public Property MemoCode() As String
            Get
                Return _MemoCode
            End Get
            Set(ByVal Value As String)
                _MemoCode = Value
            End Set
        End Property
        Public Property Buyer() As String
            Get
                Return _Buyer
            End Get
            Set(ByVal Value As String)
                _Buyer = Value
            End Set
        End Property
        Public Property DeliveryName() As String
            Get
                Return _DeliveryName
            End Get
            Set(ByVal Value As String)
                _DeliveryName = Value
            End Set
        End Property
        Public Property DeliveryAddr1() As String
            Get
                Return _DeliveryAddr1
            End Get
            Set(ByVal Value As String)
                _DeliveryAddr1 = Value
            End Set
        End Property
        Public Property DeliveryAddr2() As String
            Get
                Return _DeliveryAddr2
            End Get
            Set(ByVal Value As String)
                _DeliveryAddr2 = Value
            End Set
        End Property
        Public Property DeliveryAddr3() As String
            Get
                Return _DeliveryAddr3
            End Get
            Set(ByVal Value As String)
                _DeliveryAddr3 = Value
            End Set
        End Property
        Public Property DeliveryAddr4() As String
            Get
                Return _DeliveryAddr4
            End Get
            Set(ByVal Value As String)
                _DeliveryAddr4 = Value
            End Set
        End Property
        Public Property DeliveryAddr5() As String
            Get
                Return _DeliveryAddr5
            End Get
            Set(ByVal Value As String)
                _DeliveryAddr5 = Value
            End Set
        End Property
        Public Property PostalCode() As String
            Get
                Return _PostalCode
            End Get
            Set(ByVal Value As String)
                _PostalCode = Value
            End Set
        End Property
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property
        Public Property DiscountLessPlus() As CommonEnums.DiscountLessPlussEnum
            Get
                Return _DiscountLessPlus
            End Get
            Set(ByVal Value As CommonEnums.DiscountLessPlussEnum)
                _DiscountLessPlus = Value
            End Set
        End Property
        Public Property DiscPercent1() As Decimal
            Get
                Return _DiscPercent1
            End Get
            Set(ByVal Value As Decimal)
                _DiscPercent1 = Value
            End Set
        End Property
        Public Property DiscPercent2() As Decimal
            Get
                Return _DiscPercent2
            End Get
            Set(ByVal Value As Decimal)
                _DiscPercent2 = Value
            End Set
        End Property
        Public Property DiscPercent3() As Decimal
            Get
                Return _DiscPercent3
            End Get
            Set(ByVal Value As Decimal)
                _DiscPercent3 = Value
            End Set
        End Property
        Public Property PurchaseOrder() As String
            Get
                Return _PurchaseOrder
            End Get
            Set(ByVal Value As String)
                _PurchaseOrder = Value
            End Set
        End Property
        Public Property ChgPOStatToReadyToPrint() As CommonEnums.YesNoEnum
            Get
                Return _ChgPOStatToReadyToPrint
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ChgPOStatToReadyToPrint = Value
            End Set
        End Property

#End Region

#Region " Collection Properties "
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

#End Region

#Region " Constructors "
        Public Sub New()
        End Sub
#End Region

#Region " Collection Methods "
        Public Sub AddStockLine(ByVal StockLine As PurchaseOrderStockLine)
            _StockLines.Add(StockLine)
        End Sub
        Public Sub RemoveStockLine(ByVal StockLine As PurchaseOrderStockLine)
            _StockLines.Remove(StockLine)
        End Sub
        Public Sub AddCommentLine(ByVal CommentLine As PurchaseOrderCommentLine)
            _CommentLines.Add(CommentLine)
        End Sub
        Public Sub RemoveCommentLine(ByVal CommentLine As PurchaseOrderCommentLine)
            _CommentLines.Remove(CommentLine)
        End Sub
        Public Sub AddMiscChargeLine(ByVal MiscChargeLine As PurchaseOrderMiscChargeLine)
            _MiscChargeLines.Add(MiscChargeLine)
        End Sub
        Public Sub RemoveMiscChargeLine(ByVal MiscChargeLine As PurchaseOrderMiscChargeLine)
            _MiscChargeLines.Remove(MiscChargeLine)
        End Sub
        Public Sub AddFreightLine(ByVal FreightLine As PurchaseOrderFreightLine)
            _FreightLines.Add(FreightLine)
        End Sub
        Public Sub RemoveFreightLine(ByVal FreightLine As PurchaseOrderFreightLine)
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
        Private _BusinessObject As String = "PORTOI"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Order/Key/PurchaseOrder")
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

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim sbXMLParam As New System.Text.StringBuilder

                'Build an XML string to pass parameters
                sbXMLParam.Append("<PostPurchaseOrders>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<AllowNonStockItems>{0}</AllowNonStockItems>", Left(AllowNonStockItems.ToString, 1))
                sbXMLParam.AppendFormat("<AllowZeroPrice>{0}</AllowZeroPrice>", Left(AllowZeroPrice.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateWorkingDays>{0}</ValidateWorkingDays>", Left(ValidateWorkingDays.ToString, 1))
                sbXMLParam.AppendFormat("<AllowPoWhenBlanketPo>{0}</AllowPoWhenBlanketPo>", Left(AllowPoWhenBlanketPo.ToString, 1))
                sbXMLParam.AppendFormat("<DefaultMemoCode>{0}</DefaultMemoCode>", DefaultMemoCode)
                sbXMLParam.AppendFormat("<FixedExchangeRate>{0}</FixedExchangeRate>", Left(FixedExchangeRate.ToString, 1))
                sbXMLParam.AppendFormat("<DefaultMemoDays>{0}</DefaultMemoDays>", DefaultMemoDays)
                sbXMLParam.AppendFormat("<AllowBlankLedgerCode>{0}</AllowBlankLedgerCode>", Left(AllowBlankLedgerCode.ToString, 1))
                sbXMLParam.AppendFormat("<DefaultDeliveryAddress>{0}</DefaultDeliveryAddress>", DefaultDeliveryAddress)
                sbXMLParam.AppendFormat("<CalcDueDate>{0}</CalcDueDate>", Left(CalcDueDate.ToString, 1))
                sbXMLParam.AppendFormat("<InsertDangerousGoodsText>{0}</InsertDangerousGoodsText>", Left(InsertDangerousGoodsText.ToString, 1))
                sbXMLParam.AppendFormat("<InsertAdditionalPOText>{0}</InsertAdditionalPOText>", Left(InsertAdditionalPOText.ToString, 1))
                sbXMLParam.AppendFormat("<Status>{0}</Status>", Status)
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostPurchaseOrders>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String Implements ITransaction.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostPurchaseOrders>")
                sbXMLin.Append("<Orders>")
                sbXMLin.Append("<OrderHeader>")
                sbXMLin.AppendFormat("<OrderActionType>{0}</OrderActionType>", Left(OrderActionType.ToString, 1))
                sbXMLin.AppendFormat("<Supplier>{0}</Supplier>", Supplier)
                sbXMLin.AppendFormat("<ExchRateFixed>{0}</ExchRateFixed>", Left(ExchRateFixed.ToString, 1))
                sbXMLin.AppendFormat("<ExchangeRate>{0}</ExchangeRate>", ExchangeRate)
                sbXMLin.AppendFormat("<OrderType>{0}</OrderType>", Left(OrderType.ToString, 1))
                sbXMLin.AppendFormat("<Customer>{0}</Customer>", Customer)
                sbXMLin.AppendFormat("<TaxStatus>{0}</TaxStatus>", Left(TaxStatus.ToString, 1))
                sbXMLin.AppendFormat("<PaymentTerms>{0}</PaymentTerms>", PaymentTerms)
                sbXMLin.AppendFormat("<InvoiceTerms>{0}</InvoiceTerms>", InvoiceTerms)
                sbXMLin.AppendFormat("<CustomerPoNumber>{0}</CustomerPoNumber>", CustomerPoNumber)
                sbXMLin.AppendFormat("<ShippingInstrs>{0}</ShippingInstrs>", ShippingInstrs)
                If Format(OrderDate, "yyyy-MM-dd") = "0001-01-01" Then
                    sbXMLin.Append("<OrderDate />")
                Else
                    sbXMLin.AppendFormat("<OrderDate>{0}</OrderDate>", Format(OrderDate, "yyyy-MM-dd"))
                End If
                If Format(DueDate, "yyyy-MM-dd") = "0001-01-01" Then
                    sbXMLin.Append("<DueDate />")
                Else
                    sbXMLin.AppendFormat("<DueDate>{0}</DueDate>", Format(DueDate, "yyyy-MM-dd"))
                End If
                If Format(MemoDate, "yyyy-MM-dd") = "0001-01-01" Then
                    sbXMLin.Append("<MemoDate />")
                Else
                    sbXMLin.AppendFormat("<MemoDate>{0}</MemoDate>", Format(MemoDate, "yyyy-MM-dd"))
                End If
                sbXMLin.AppendFormat("<ApplyDueDateToLines>{0}</ApplyDueDateToLines>", Left(ApplyDueDateToLines.ToString, 1))
                sbXMLin.AppendFormat("<MemoCode>{0}</MemoCode>", MemoCode)
                sbXMLin.AppendFormat("<Buyer>{0}</Buyer>", Buyer)
                sbXMLin.AppendFormat("<DeliveryName>{0}</DeliveryName>", DeliveryName)
                sbXMLin.AppendFormat("<DeliveryAddr1>{0}</DeliveryAddr1>", DeliveryAddr1)
                sbXMLin.AppendFormat("<DeliveryAddr2>{0}</DeliveryAddr2>", DeliveryAddr2)
                sbXMLin.AppendFormat("<DeliveryAddr3>{0}</DeliveryAddr3>", DeliveryAddr3)
                sbXMLin.AppendFormat("<DeliveryAddr4>{0}</DeliveryAddr4>", DeliveryAddr4)
                sbXMLin.AppendFormat("<DeliveryAddr5>{0}</DeliveryAddr5>", DeliveryAddr5)
                sbXMLin.AppendFormat("<PostalCode>{0}</PostalCode>", PostalCode)
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<DiscountLessPlus>{0}</DiscountLessPlus>", Left(DiscountLessPlus.ToString, 1))
                sbXMLin.AppendFormat("<DiscPercent1>{0}</DiscPercent1>", Format(DiscPercent1, "###.##"))
                sbXMLin.AppendFormat("<DiscPercent2>{0}</DiscPercent2>", Format(DiscPercent2, "##.##"))
                sbXMLin.AppendFormat("<DiscPercent3>{0}</DiscPercent3>", Format(DiscPercent3, "##.##"))
                sbXMLin.AppendFormat("<PurchaseOrder>{0}</PurchaseOrder>", PurchaseOrder)
                sbXMLin.AppendFormat("<ChgPOStatToReadyToPrint>{0}</ChgPOStatToReadyToPrint>", Left(ChgPOStatToReadyToPrint.ToString, 1))

                sbXMLin.Append("</OrderHeader>")

                sbXMLin.Append("<OrderDetails>")

                For Each stkLine As PurchaseOrderStockLine In StockLines
                    stkLine.AppendStockLine(sbXMLin)
                Next
                For Each cmtLine As PurchaseOrderCommentLine In CommentLines
                    cmtLine.AppendCommentLine(sbXMLin)
                Next
                For Each mcLine As PurchaseOrderMiscChargeLine In MiscChargeLines
                    mcLine.AppendMiscChargeLine(sbXMLin)
                Next
                For Each ftLine As PurchaseOrderFreightLine In FreightLines
                    ftLine.AppendFreightLine(sbXMLin)
                Next

                sbXMLin.Append("</OrderDetails>")
                sbXMLin.Append("</Orders>")
                sbXMLin.Append("</PostPurchaseOrders>")

                Return sbXMLin.ToString
            End Get
        End Property
        Private _ActionType As CommonEnums.ActionType_Transaction
        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property
        Public Sub Post() Implements ITransaction.Post
            Select Case ActionType
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select

            SysproIntegration.Common.SysproUtilities.CheckXMLOut(_xmlIn, _xmlParam, _xmlOut)

        End Sub


#End Region


    End Class

End Namespace
