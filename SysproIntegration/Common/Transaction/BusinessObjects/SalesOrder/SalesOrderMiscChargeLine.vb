Namespace TransactionObjects.SalesOrder
    <Serializable()> Public Class SalesOrderMiscChargeLine
        Private _CustomerPoLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _LineCancelCode As String  'max 6
        Private _MiscChargeValue As Decimal '12.2 numeric
        Private _MiscChargeCost As Decimal '12.2 numeric
        Private _MiscQuantity As Decimal '7.3 numeric
        Private _MiscProductClass As String 'max 4
        Private _MiscTaxCode As String 'max 1
        Private _MiscNotTaxable As String = "" 'Y or blank
        Private _MiscFstCode As Integer '1 digit
        Private _MiscNotFstTaxable As String = ""  'Y or blank
        Private _MiscDescription As String 'max 45

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
        Public Property MiscChargeValue() As Decimal
            Get
                Return _MiscChargeValue
            End Get
            Set(ByVal Value As Decimal)
                _MiscChargeValue = Value
            End Set
        End Property
        Public Property MiscChargeCost() As Decimal
            Get
                Return _MiscChargeCost
            End Get
            Set(ByVal Value As Decimal)
                _MiscChargeCost = Value
            End Set
        End Property
        Public Property MiscQuantity() As Decimal
            Get
                Return _MiscQuantity
            End Get
            Set(ByVal Value As Decimal)
                _MiscQuantity = Value
            End Set
        End Property
        Public Property MiscProductClass() As String
            Get
                Return HandleSpecialCharacters(_MiscProductClass)
            End Get
            Set(ByVal Value As String)
                _MiscProductClass = Value
            End Set
        End Property
        Public Property MiscTaxCode() As String
            Get
                Return HandleSpecialCharacters(_MiscTaxCode)
            End Get
            Set(ByVal Value As String)
                _MiscTaxCode = Value
            End Set
        End Property
        Public Property MiscNotTaxable() As String
            Get
                Return HandleSpecialCharacters(_MiscNotTaxable)
            End Get
            Set(ByVal Value As String)
                _MiscNotTaxable = Value
            End Set
        End Property
        Public Property MiscFstCode() As Integer
            Get
                Return _MiscFstCode
            End Get
            Set(ByVal Value As Integer)
                _MiscFstCode = Value
            End Set
        End Property
        Public Property MiscNotFstTaxable() As String
            Get
                Return HandleSpecialCharacters(_MiscNotFstTaxable)
            End Get
            Set(ByVal Value As String)
                _MiscNotFstTaxable = Value
            End Set
        End Property
        Public Property MiscDescription() As String
            Get
                Return HandleSpecialCharacters(_MiscDescription)
            End Get
            Set(ByVal Value As String)
                _MiscDescription = Value
            End Set
        End Property

        Public Sub AppendMiscChargeLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<MiscChargeLine>" & vbCrLf)
            sbXMLin.AppendFormat("<CustomerPoLine>{0}</CustomerPoLine>" & vbCrLf, CustomerPoLine)
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>" & vbCrLf, Left(LineActionType.ToString, 1))
            sbXMLin.AppendFormat("<LineCancelCode>{0}</LineCancelCode>" & vbCrLf, LineCancelCode)
            sbXMLin.AppendFormat("<MiscChargeValue>{0}</MiscChargeValue>" & vbCrLf, MiscChargeValue)
            sbXMLin.AppendFormat("<MiscChargeCost>{0}</MiscChargeCost>" & vbCrLf, MiscChargeCost)
            sbXMLin.AppendFormat("<MiscQuantity>{0}</MiscQuantity>" & vbCrLf, MiscQuantity)
            sbXMLin.AppendFormat("<MiscProductClass>{0}</MiscProductClass>" & vbCrLf, MiscProductClass)
            sbXMLin.AppendFormat("<MiscTaxCode>{0}</MiscTaxCode>" & vbCrLf, MiscTaxCode)
            sbXMLin.AppendFormat("<MiscNotTaxable>{0}</MiscNotTaxable>" & vbCrLf, MiscNotTaxable)
            sbXMLin.AppendFormat("<MiscFstCode>{0}</MiscFstCode>" & vbCrLf, MiscFstCode)
            sbXMLin.AppendFormat("<MiscNotFstTaxable>{0}</MiscNotFstTaxable>" & vbCrLf, MiscNotFstTaxable)
            sbXMLin.AppendFormat("<MiscDescription>{0}</MiscDescription>" & vbCrLf, MiscDescription)
            sbXMLin.Append("</MiscChargeLine>" & vbCrLf)

        End Sub


    End Class
End Namespace
