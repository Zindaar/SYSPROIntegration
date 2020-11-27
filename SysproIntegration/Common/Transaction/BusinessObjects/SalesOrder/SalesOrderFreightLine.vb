Namespace TransactionObjects.SalesOrder
    <Serializable()> Public Class SalesOrderFreightLine
        Private _CustomerPoLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _LineCancelCode As String  'max 6
        Private _FreightValue As Decimal '12.2 numeric
        Private _FreightCost As Decimal '12.2 numeric
        Private _FreightTaxCode As String 'max 1
        Private _FreightNotTaxable As String = ""  'Y or blank
        Private _FreightFstCode As String 'max 1
        Private _FreightNotFstTaxable As String = ""  'Y or blank

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
        Public Property FreightValue() As Decimal
            Get
                Return _FreightValue
            End Get
            Set(ByVal Value As Decimal)
                _FreightValue = Value
            End Set
        End Property
        Public Property FreightCost() As Decimal
            Get
                Return _FreightCost
            End Get
            Set(ByVal Value As Decimal)
                _FreightCost = Value
            End Set
        End Property
        Public Property FreightTaxCode() As String
            Get
                Return HandleSpecialCharacters(_FreightTaxCode)
            End Get
            Set(ByVal Value As String)
                _FreightTaxCode = Value
            End Set
        End Property
        Public Property FreightNotTaxable() As String
            Get
                Return HandleSpecialCharacters(_FreightNotTaxable)
            End Get
            Set(ByVal Value As String)
                _FreightNotTaxable = Value
            End Set
        End Property
        Public Property FreightFstCode() As String
            Get
                Return HandleSpecialCharacters(_FreightFstCode)
            End Get
            Set(ByVal Value As String)
                _FreightFstCode = Value
            End Set
        End Property
        Public Property FreightNotFstTaxable() As String
            Get
                Return HandleSpecialCharacters(_FreightNotFstTaxable)
            End Get
            Set(ByVal Value As String)
                _FreightNotFstTaxable = Value
            End Set
        End Property


        Public Sub AppendFreightLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<FreightLine>" & vbCrLf)
            sbXMLin.AppendFormat("<CustomerPoLine>{0}</CustomerPoLine>" & vbCrLf, CustomerPoLine)
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>" & vbCrLf, Left(LineActionType.ToString, 1))
            sbXMLin.AppendFormat("<LineCancelCode>{0}</LineCancelCode>" & vbCrLf, LineCancelCode)
            sbXMLin.AppendFormat("<FreightValue>{0}</FreightValue>" & vbCrLf, FreightValue)
            sbXMLin.AppendFormat("<FreightCost>{0}</FreightCost>" & vbCrLf, FreightCost)
            sbXMLin.AppendFormat("<FreightTaxCode>{0}</FreightTaxCode>" & vbCrLf, FreightTaxCode)
            sbXMLin.AppendFormat("<FreightNotTaxable>{0}</FreightNotTaxable>" & vbCrLf, FreightNotTaxable)
            sbXMLin.AppendFormat("<FreightFstCode>{0}</FreightFstCode>" & vbCrLf, FreightFstCode)
            sbXMLin.AppendFormat("<FreightNotFstTaxable>{0}</FreightNotFstTaxable>" & vbCrLf, FreightNotFstTaxable)
            sbXMLin.Append("</FreightLine>" & vbCrLf)

        End Sub


    End Class

End Namespace
