Namespace TransactionObjects.PurchaseOrder
    <Serializable()> Public Class PurchaseOrderFreightLine

        Private _PurchaseOrderLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _FreightValue As Decimal '12.2 numeric
        Private _FreightTaxCode As String 'max 1
        Private _FreightTaxable As CommonEnums.YesNoEnum
        Private _FreightFLoc As CommonEnums.POFreightTypeEnum

        Public Property PurchaseOrderLine() As Integer
            Get
                Return _PurchaseOrderLine
            End Get
            Set(ByVal Value As Integer)
                _PurchaseOrderLine = Value
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
        Public Property FreightValue() As Decimal
            Get
                Return _FreightValue
            End Get
            Set(ByVal Value As Decimal)
                _FreightValue = Value
            End Set
        End Property
        Public Property FreightTaxCode() As String
            Get
                Return _FreightTaxCode
            End Get
            Set(ByVal Value As String)
                _FreightTaxCode = Value
            End Set
        End Property
        Public Property FreightTaxable() As CommonEnums.YesNoEnum
            Get
                Return _FreightTaxable
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _FreightTaxable = Value
            End Set
        End Property
        Public Property FreightFLoc() As CommonEnums.POFreightTypeEnum
            Get
                Return _FreightFLoc
            End Get
            Set(ByVal Value As CommonEnums.POFreightTypeEnum)
                _FreightFLoc = Value
            End Set
        End Property


        Public Sub AppendFreightLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<FreightLine>")
            sbXMLin.AppendFormat("<PurchaseOrderLine>{0}</PurchaseOrderLine>", PurchaseOrderLine)
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>", Left(LineActionType.ToString, 1))
            sbXMLin.AppendFormat("<FreightValue>{0}</FreightValue>", FreightValue)
            sbXMLin.AppendFormat("<FreightTaxCode>{0}</FreightTaxCode>", FreightTaxCode)
            sbXMLin.AppendFormat("<FreightTaxable>{0}</FreightTaxable>", Left(FreightTaxable.ToString, 1))
            sbXMLin.AppendFormat("<FreightFLoc>{0}</FreightFLoc>", Left(FreightFLoc.ToString, 1))
            sbXMLin.Append("</FreightLine>")

        End Sub


    End Class

End Namespace
