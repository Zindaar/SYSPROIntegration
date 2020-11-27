Namespace TransactionObjects.SalesOrder
    <Serializable()> Public Class SalesOrderStockLine

        Private _CustomerPoLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _LineCancelCode As String  'max 6
        Private _StockCode As String 'max 30
        Private _StockDescription As String 'max 30
        Private _Warehouse As String 'max 2
        Private _CustomersPartNumber As String 'max 30
        Private _OrderQty As Decimal '7.3 numeric
        Private _OrderUom As String 'max 3
        Private _Price As Decimal '10.5 numeric
        Private _PriceUom As String 'max 3
        Private _Units As Integer  '7 digits
        Private _Pieces As Integer  'max 3 digits
        Private _LineDiscPercent1 As Decimal '3.2 numeric
        Private _LineDiscPercent2 As Decimal '2.2 numeric
        Private _LineDiscPercent3 As Decimal '2.2 numeric
        Private _CustRequestDate As Date = DateTime.Now '
        Private _LineShipDate As Date  '
        Private _LineDiscValue As Decimal '12.2 numeric
        Private _UserDefined As String 'max 4
        Private _NsProductClass As String 'max 4
        Private _AlwaysUsePriceEntered As CommonEnums.YesNoEnum
        Private _ProductClass As String 'max 4
        Private _CommissionCode As String 'max 2
        Private _OverrideCalculatedDiscount As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _NonStockedLine As CommonEnums.NonStockedLine = CommonEnums.NonStockedLine.Blank
        Private _NsUnitCost As Decimal '15.5 numeric
        Private _UnitMass As Decimal '6.6 numeric
        Private _UnitVolume As Decimal '6.6 numeric
        Private _StockTaxCode As String 'max 1
        Private _StockNotTaxable As CommonEnums.StockNotTaxable = CommonEnums.StockNotTaxable.Blank
        Private _StockFstCode As String 'max 1
        Private _StockNotFstTaxable As CommonEnums.StockNotFstTaxable = CommonEnums.StockNotFstTaxable.Blank
        Private _ConfigPrintInv As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ConfigPrintDel As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ConfigPrintAck As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes

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

        Public Property CustomerPoLine() As Integer
            Get
                Return _CustomerPoLine
            End Get
            Set(ByVal Value As Integer)
                _CustomerPoLine = Value
            End Set
        End Property
        Public Property LineActionType() As CommonEnums.ActionTypeEnum
            Get
                Return _LineActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _LineActionType = Value
            End Set
        End Property
        Public Property LineCancelCode() As String
            Get
                Return HandleSpecialCharacters(_LineCancelCode)
            End Get
            Set(ByVal Value As String)
                _LineCancelCode = Value
            End Set
        End Property
        Public Property StockCode() As String
            Get
                Return HandleSpecialCharacters(_StockCode)
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        Public Property StockDescription() As String
            Get
                Return HandleSpecialCharacters(_StockDescription)
            End Get
            Set(ByVal Value As String)
                _StockDescription = Value
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
        Public Property CustomersPartNumber() As String
            Get
                Return HandleSpecialCharacters(_CustomersPartNumber)
            End Get
            Set(ByVal Value As String)
                _CustomersPartNumber = Value
            End Set
        End Property
        Public Property OrderQty() As Decimal
            Get
                Return _OrderQty
            End Get
            Set(ByVal Value As Decimal)
                _OrderQty = Value
            End Set
        End Property
        Public Property OrderUom() As String
            Get
                Return HandleSpecialCharacters(_OrderUom)
            End Get
            Set(ByVal Value As String)
                _OrderUom = Value
            End Set
        End Property
        Public Property Price() As Decimal
            Get
                Return _Price
            End Get
            Set(ByVal Value As Decimal)
                _Price = Value
            End Set
        End Property
        Public Property PriceUom() As String
            Get
                Return HandleSpecialCharacters(_PriceUom)
            End Get
            Set(ByVal Value As String)
                _PriceUom = Value
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
        Public Property LineDiscPercent1() As Decimal
            Get
                Return _LineDiscPercent1
            End Get
            Set(ByVal Value As Decimal)
                _LineDiscPercent1 = Value
            End Set
        End Property
        Public Property LineDiscPercent2() As Decimal
            Get
                Return _LineDiscPercent2
            End Get
            Set(ByVal Value As Decimal)
                _LineDiscPercent2 = Value
            End Set
        End Property
        Public Property LineDiscPercent3() As Decimal
            Get
                Return _LineDiscPercent3
            End Get
            Set(ByVal Value As Decimal)
                _LineDiscPercent3 = Value
            End Set
        End Property
        Public Property CustRequestDate() As Date
            Get
                Return _CustRequestDate
            End Get
            Set(ByVal Value As Date)
                _CustRequestDate = Value
            End Set
        End Property
        Public Property LineShipDate() As Date
            Get
                Return _LineShipDate
            End Get
            Set(ByVal Value As Date)
                _LineShipDate = Value
            End Set
        End Property
        Public Property LineDiscValue() As Decimal
            Get
                Return _LineDiscValue
            End Get
            Set(ByVal Value As Decimal)
                _LineDiscValue = Value
            End Set
        End Property
        Public Property UserDefined() As String
            Get
                Return HandleSpecialCharacters(_UserDefined)
            End Get
            Set(ByVal Value As String)
                _UserDefined = Value
            End Set
        End Property
        Public Property NsProductClass() As String
            Get
                Return HandleSpecialCharacters(_NsProductClass)
            End Get
            Set(ByVal Value As String)
                _NsProductClass = Value
            End Set
        End Property
        Public Property AlwaysUsePriceEntered() As CommonEnums.YesNoEnum
            Get
                Return _AlwaysUsePriceEntered
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _AlwaysUsePriceEntered = value
            End Set
        End Property
        Public Property ProductClass() As String
            Get
                Return HandleSpecialCharacters(_ProductClass)
            End Get
            Set(ByVal value As String)
                _ProductClass = value
            End Set
        End Property
        Public Property CommissionCode() As String
            Get
                Return HandleSpecialCharacters(_CommissionCode)
            End Get
            Set(ByVal value As String)
                _CommissionCode = value
            End Set
        End Property
        Public Property OverrideCalculatedDiscount() As CommonEnums.YesNoEnum
            Get
                Return _OverrideCalculatedDiscount
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _OverrideCalculatedDiscount = value
            End Set
        End Property
        Public Property NonStockedLine() As CommonEnums.NonStockedLine
            Get
                Return _NonStockedLine
            End Get
            Set(ByVal value As CommonEnums.NonStockedLine)
                _NonStockedLine = value
            End Set
        End Property
        Public Property NsUnitCost() As Decimal
            Get
                Return _NsUnitCost
            End Get
            Set(ByVal value As Decimal)
                _NsUnitCost = value
            End Set
        End Property
        Public Property UnitMass() As Decimal
            Get
                Return _UnitMass
            End Get
            Set(ByVal value As Decimal)
                _UnitMass = value
            End Set
        End Property
        Public Property UnitVolume() As Decimal
            Get
                Return _UnitVolume
            End Get
            Set(ByVal value As Decimal)
                _UnitVolume = value
            End Set
        End Property
        Public Property StockTaxCode() As String
            Get
                Return HandleSpecialCharacters(_StockTaxCode)
            End Get
            Set(ByVal value As String)
                _StockTaxCode = value
            End Set
        End Property
        Public Property StockNotTaxable() As CommonEnums.StockNotTaxable
            Get
                Return _StockNotTaxable
            End Get
            Set(ByVal value As CommonEnums.StockNotTaxable)
                _StockNotTaxable = value
            End Set
        End Property
        Public Property StockFstCode() As String
            Get
                Return HandleSpecialCharacters(_StockFstCode)
            End Get
            Set(ByVal value As String)
                _StockFstCode = value
            End Set
        End Property
        Public Property StockNotFstTaxable() As CommonEnums.StockNotFstTaxable
            Get
                Return _StockNotFstTaxable
            End Get
            Set(ByVal value As CommonEnums.StockNotFstTaxable)
                _StockNotFstTaxable = value
            End Set
        End Property
        Public Property ConfigPrintInv() As CommonEnums.YesNoEnum
            Get
                Return _ConfigPrintInv
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _ConfigPrintInv = value
            End Set
        End Property
        Public Property ConfigPrintDel() As CommonEnums.YesNoEnum
            Get
                Return _ConfigPrintDel
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _ConfigPrintDel = value
            End Set
        End Property
        Public Property ConfigPrintAck() As CommonEnums.YesNoEnum
            Get
                Return _ConfigPrintAck
            End Get
            Set(ByVal value As CommonEnums.YesNoEnum)
                _ConfigPrintAck = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub AppendStockLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<StockLine>" & vbCrLf)
            If Not String.IsNullOrEmpty(CustomerPoLine) Then sbXMLin.AppendFormat("<CustomerPoLine>{0}</CustomerPoLine>" & vbCrLf, CustomerPoLine)
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>" & vbCrLf, Left(LineActionType.ToString, 1))
            If Not String.IsNullOrEmpty(LineCancelCode) Then sbXMLin.AppendFormat("<LineCancelCode>{0}</LineCancelCode>" & vbCrLf, LineCancelCode)
            If Not String.IsNullOrEmpty(StockCode) Then sbXMLin.AppendFormat("<StockCode>{0}</StockCode>" & vbCrLf, StockCode)
            If Not String.IsNullOrEmpty(StockDescription) Then sbXMLin.AppendFormat("<StockDescription>{0}</StockDescription>" & vbCrLf, StockDescription)
            If Not String.IsNullOrEmpty(Warehouse) Then sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>" & vbCrLf, Warehouse)
            If Not String.IsNullOrEmpty(CustomersPartNumber) Then sbXMLin.AppendFormat("<CustomersPartNumber>{0}</CustomersPartNumber>" & vbCrLf, CustomersPartNumber)
            sbXMLin.AppendFormat("<OrderQty>{0}</OrderQty>" & vbCrLf, OrderQty)
            If Not String.IsNullOrEmpty(OrderUom) Then sbXMLin.AppendFormat("<OrderUom>{0}</OrderUom>" & vbCrLf, OrderUom)
            sbXMLin.AppendFormat("<Price>{0}</Price>" & vbCrLf, Price)
            If Not String.IsNullOrEmpty(PriceUom) Then sbXMLin.AppendFormat("<PriceUom>{0}</PriceUom>" & vbCrLf, PriceUom)
            sbXMLin.AppendFormat("<Units>{0}</Units>" & vbCrLf, Units)
            sbXMLin.AppendFormat("<Pieces>{0}</Pieces>" & vbCrLf, Pieces)
            sbXMLin.AppendFormat("<LineDiscPercent1>{0}</LineDiscPercent1>" & vbCrLf, LineDiscPercent1)
            sbXMLin.AppendFormat("<LineDiscPercent2>{0}</LineDiscPercent2>" & vbCrLf, LineDiscPercent2)
            sbXMLin.AppendFormat("<LineDiscPercent3>{0}</LineDiscPercent3>" & vbCrLf, LineDiscPercent3)
            sbXMLin.AppendFormat("<CustRequestDate>{0}</CustRequestDate>" & vbCrLf, Format(CustRequestDate, "yyyy-MM-dd"))
            sbXMLin.AppendFormat("<LineShipDate>{0}</LineShipDate>" & vbCrLf, Format(LineShipDate, "yyyy-MM-dd"))
            sbXMLin.AppendFormat("<LineDiscValue>{0}</LineDiscValue>" & vbCrLf, LineDiscValue)
            If Not String.IsNullOrEmpty(UserDefined) Then sbXMLin.AppendFormat("<UserDefined>{0}</UserDefined>" & vbCrLf, UserDefined)
            If Not String.IsNullOrEmpty(NsProductClass) Then sbXMLin.AppendFormat("<NsProductClass>{0}</NsProductClass>" & vbCrLf, NsProductClass)
            sbXMLin.AppendFormat("<AlwaysUsePriceEntered>{0}</AlwaysUsePriceEntered>" & vbCrLf, Left(AlwaysUsePriceEntered.ToString, 1))
            If Not String.IsNullOrEmpty(ProductClass) Then sbXMLin.AppendFormat("<ProductClass>{0}</ProductClass>" & vbCrLf, ProductClass)
            If Not String.IsNullOrEmpty(CommissionCode) Then sbXMLin.AppendFormat("<CommissionCode>{0}</CommissionCode>" & vbCrLf, CommissionCode)
            sbXMLin.AppendFormat("<OverrideCalculatedDiscount>{0}</OverrideCalculatedDiscount>" & vbCrLf, Left(OverrideCalculatedDiscount.ToString, 1))
            If NonStockedLine = CommonEnums.NonStockedLine.Blank Then
                sbXMLin.AppendFormat("<NonStockedLine>{0}</NonStockedLine>" & vbCrLf, "")
            Else
                sbXMLin.AppendFormat("<NonStockedLine>{0}</NonStockedLine>" & vbCrLf, Left(NonStockedLine.ToString, 1))
            End If
            sbXMLin.AppendFormat("<NsUnitCost>{0}</NsUnitCost>" & vbCrLf, NsUnitCost)
            sbXMLin.AppendFormat("<UnitMass>{0}</UnitMass>" & vbCrLf, UnitMass)
            sbXMLin.AppendFormat("<UnitVolume>{0}</UnitVolume>" & vbCrLf, UnitVolume)
            If StockNotTaxable = CommonEnums.StockNotTaxable.Blank Then
                sbXMLin.AppendFormat("<StockNotTaxable>{0}</StockNotTaxable>" & vbCrLf, "")
            Else
                sbXMLin.AppendFormat("<StockNotTaxable>{0}</StockNotTaxable>" & vbCrLf, Left(StockNotTaxable.ToString, 1))
            End If
            If Not String.IsNullOrEmpty(StockTaxCode) Then sbXMLin.AppendFormat("<StockFstCode>{0}</StockFstCode>" & vbCrLf, StockTaxCode)
            If StockNotTaxable = CommonEnums.StockNotFstTaxable.Blank Then
                sbXMLin.AppendFormat("<StockNotFstTaxable>{0}</StockNotFstTaxable>" & vbCrLf, "")
            Else
                sbXMLin.AppendFormat("<StockNotFstTaxable>{0}</StockNotFstTaxable>" & vbCrLf, Left(StockNotFstTaxable.ToString, 1))
            End If
            sbXMLin.AppendFormat("<ConfigPrintInv>{0}</ConfigPrintInv>" & vbCrLf, Left(ConfigPrintInv.ToString, 1))
            sbXMLin.AppendFormat("<ConfigPrintDel>{0}</ConfigPrintDel>" & vbCrLf, Left(ConfigPrintDel.ToString, 1))
            sbXMLin.AppendFormat("<ConfigPrintAck>{0}</ConfigPrintAck>" & vbCrLf, Left(ConfigPrintInv.ToString, 1))
            sbXMLin.Append("</StockLine>" & vbCrLf)
        End Sub
    End Class

End Namespace
