Namespace TransactionObjects
    <Serializable()> Public Class BackOrderRelease

        Implements ITransaction


#Region "Interface"

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

            Select Case _ActionType
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select

            Tallbridge.SysproIntegration.Common.SysproUtilities.CheckXMLOut(xmlIn, xmlParam, xmlOut)

        End Sub


#End Region

#Region "Local Variables"
        'Pameters
        Private _LatestAcceptedLotExpiryDate As Date
        Private _LatestAcceptedSerialExpiryDate As Date
        Private _LatestAcceptedSerialScrapDate As Date
        Private _ScheduleAllocateDate As Date
        Private _ScheduleLineShipDate As Date
        Private _Customer As String 'max 8 digits
        Private _SalesOrder As String 'max 8 digits
        Private _StockCode As String 'max 30 digits
        Private _Warehouse As String 'max 2 digits
        Private _Quantity As Decimal '7.3 numeric
        Private _UnitOfMeasure As String
        Private _Units As Integer 'max 7 digits
        Private _Pieces As Integer 'max 3 digits
        Private _ReleaseFromMultipleLines As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _SalesOrderLine As Integer 'max 4 digits
        Private _CompleteLine As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AdjustOrderQuantity As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _Lot As String 'max 10 characters
        Private _OrderStatus As CommonEnums.OrderStatusEnum
        Private _ReleaseFromShip As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ZeroShipQuantity As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AllocateSerialNumbers As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        'Parameters
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AddQuantityToBatchSerial As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        'Collections
        Private _Serials As New ArrayList
        Private _Bins As New ArrayList

#End Region

#Region "Public Properties"

        Public Property LatestAcceptedLotExpiryDate() As Date
            Get
                Return _LatestAcceptedLotExpiryDate
            End Get
            Set(ByVal Value As Date)
                _LatestAcceptedLotExpiryDate = Value
            End Set
        End Property
        Public Property LatestAcceptedSerialExpiryDate() As Date
            Get
                Return _LatestAcceptedSerialExpiryDate
            End Get
            Set(ByVal Value As Date)
                _LatestAcceptedSerialExpiryDate = Value
            End Set
        End Property
        Public Property LatestAcceptedSerialScrapDate() As Date
            Get
                Return _LatestAcceptedSerialScrapDate
            End Get
            Set(ByVal Value As Date)
                _LatestAcceptedSerialScrapDate = Value
            End Set
        End Property
        Public Property ScheduleAllocateDate() As Date
            Get
                Return _ScheduleAllocateDate
            End Get
            Set(ByVal Value As Date)
                _ScheduleAllocateDate = Value
            End Set
        End Property
        Public Property ScheduleLineShipDate() As Date
            Get
                Return _ScheduleLineShipDate
            End Get
            Set(ByVal Value As Date)
                _ScheduleLineShipDate = Value
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
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
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
        Public Property Quantity() As Decimal
            Get
                Return _Quantity
            End Get
            Set(ByVal Value As Decimal)
                _Quantity = Value
            End Set
        End Property
        Public Property UnitOfMeasure() As String
            Get
                Return _UnitOfMeasure
            End Get
            Set(ByVal Value As String)
                _UnitOfMeasure = Value
            End Set
        End Property
        Public Property Units() As Integer
            Get
                Return _Units
            End Get
            Set(ByVal Value As Integer)
                _Units = Value
            End Set
        End Property
        Public Property Pieces() As Integer
            Get
                Return _Pieces
            End Get
            Set(ByVal Value As Integer)
                _Pieces = Value
            End Set
        End Property
        Public Property ReleaseFromMultipleLines() As CommonEnums.YesNoEnum
            Get
                Return _ReleaseFromMultipleLines
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ReleaseFromMultipleLines = Value
            End Set
        End Property
        Public Property SalesOrderLine() As Integer
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As Integer)
                _SalesOrderLine = Value
            End Set
        End Property
        Public Property CompleteLine() As CommonEnums.YesNoEnum
            Get
                Return _CompleteLine
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CompleteLine = Value
            End Set
        End Property
        Public Property AdjustOrderQuantity() As CommonEnums.YesNoEnum
            Get
                Return _AdjustOrderQuantity
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AdjustOrderQuantity = Value
            End Set
        End Property
        Public Property Lot() As String
            Get
                Return _Lot
            End Get
            Set(ByVal Value As String)
                _Lot = Value
            End Set
        End Property
        Public Property OrderStatus() As CommonEnums.OrderStatusEnum
            Get
                Return _OrderStatus
            End Get
            Set(ByVal Value As CommonEnums.OrderStatusEnum)
                _OrderStatus = Value
            End Set
        End Property
        Public Property ReleaseFromShip() As CommonEnums.YesNoEnum
            Get
                Return _ReleaseFromShip
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ReleaseFromShip = Value
            End Set
        End Property
        Public Property ZeroShipQuantity() As CommonEnums.YesNoEnum
            Get
                Return _ZeroShipQuantity
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ZeroShipQuantity = Value
            End Set
        End Property
        Public Property AllocateSerialNumbers() As CommonEnums.YesNoEnum
            Get
                Return _AllocateSerialNumbers
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllocateSerialNumbers = Value
            End Set
        End Property



        'Parameters
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = Value
            End Set
        End Property
        Public Property ApplyIfEntireDocumentValid() As CommonEnums.YesNoEnum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property
        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value
            End Set
        End Property
        Public Property AddQuantityToBatchSerial() As CommonEnums.YesNoEnum
            Get
                Return _AddQuantityToBatchSerial
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AddQuantityToBatchSerial = Value
            End Set
        End Property

#End Region

        'Constructor
        Public Sub New()
        End Sub

#Region "Collections"
        Public Sub AddSerial(ByVal objSerial As Serial)
            _Serials.Add(objSerial)
        End Sub
        Public Sub RemoveSerial(ByVal objSerial As Serial)
            _Serials.Remove(objSerial)
        End Sub
        Public Sub AddBin(ByVal objBin As Bin)
            _Bins.Add(objBin)
        End Sub
        Public Sub RemoveBin(ByVal objBin As Bin)
            _Bins.Remove(objBin)
        End Sub

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "SORTBO"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/SalesOrder")
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
                sbXMLParam.Append("<PostSorBackOrderRelease>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<AddQuantityToBatchSerial>{0}</AddQuantityToBatchSerial>", Left(AddQuantityToBatchSerial.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostSorBackOrderRelease>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String Implements ITransaction.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostSorBackOrderRelease>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<LatestAcceptedLotExpiryDate>{0}</LatestAcceptedLotExpiryDate>", Format(LatestAcceptedLotExpiryDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<LatestAcceptedSerialExpiryDate>{0}</LatestAcceptedSerialExpiryDate>", Format(LatestAcceptedSerialExpiryDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<LatestAcceptedSerialScrapDate>{0}</LatestAcceptedSerialScrapDate>", Format(LatestAcceptedSerialScrapDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<ScheduleAllocateDate>{0}</ScheduleAllocateDate>", Format(ScheduleAllocateDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<ScheduleLineShipDate>{0}</ScheduleLineShipDate>", Format(ScheduleLineShipDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<Customer>{0}</Customer>", Customer)
                sbXMLin.AppendFormat("<SalesOrder>{0}</SalesOrder>", SalesOrder)
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<Quantity>{0}</Quantity>", Quantity)
                sbXMLin.AppendFormat("<UnitOfMeasure>{0}</UnitOfMeasure>", UnitOfMeasure)
                sbXMLin.AppendFormat("<Units>{0}</Units>", Units)
                sbXMLin.AppendFormat("<Pieces>{0}</Pieces>", Pieces)
                sbXMLin.AppendFormat("<ReleaseFromMultipleLines>{0}</ReleaseFromMultipleLines>", Left(ReleaseFromMultipleLines.ToString, 1))
                sbXMLin.AppendFormat("<SalesOrderLine>{0}</SalesOrderLine>", SalesOrderLine)
                sbXMLin.AppendFormat("<CompleteLine>{0}</CompleteLine>", Left(CompleteLine.ToString, 1))
                sbXMLin.AppendFormat("<AdjustOrderQuantity>{0}</AdjustOrderQuantity>", Left(AdjustOrderQuantity.ToString, 1))

                For Each oSerial As Serial In _Serials
                    sbXMLin.AppendFormat("<Serials>")
                    oSerial.AppendSerial(sbXMLin)
                    sbXMLin.AppendFormat("</Serials>")
                Next

                sbXMLin.AppendFormat("<Lot>{0}</Lot>", Lot)

                For Each oBin As Bin In _Bins
                    sbXMLin.AppendFormat("<Bins>")
                    oBin.AppendBin(sbXMLin)
                    sbXMLin.AppendFormat("</Bins>")
                Next

                sbXMLin.AppendFormat("<OrderStatus>{0}</OrderStatus>", Right(OrderStatus.ToString, 1)) 'Here we get the last character as an enum can't seem to have a digit as the first character
                sbXMLin.AppendFormat("<ReleaseFromShip>{0}</ReleaseFromShip>", Left(ReleaseFromShip.ToString, 1))
                sbXMLin.AppendFormat("<ZeroShipQuantity>{0}</ZeroShipQuantity>", Left(ZeroShipQuantity.ToString, 1))
                sbXMLin.AppendFormat("<AllocateSerialNumbers>{0}</AllocateSerialNumbers>", Left(AllocateSerialNumbers.ToString, 1))

                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostSorBackOrderRelease>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region


    End Class

End Namespace
