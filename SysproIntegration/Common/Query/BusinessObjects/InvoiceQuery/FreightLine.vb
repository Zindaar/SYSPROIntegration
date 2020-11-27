Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class FreightLine
        Implements IInvoiceLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0003</LineNumber> 
        Private _SalesOrderLine As String = "" '>3</SalesOrderLine> 
        Private _NComment As String = "" '>FREIGHT CHARGE</NComment> 
        Private _NMscChargeValue As String = "" '>200.00</NMscChargeValue> 
        Private _LineMscNetAmount As String = "" '>200.00</LineMscNetAmount> 
        Private _NMscTaxCode As String = "" ' /> 
        Private _LineMscChargeTaxAmt As String = "" '>0.00</LineMscChargeTaxAmt> 

#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As InvoiceLineTypeEnum Implements IInvoiceLine.LineType
            Get
                Return InvoiceLineTypeEnum.Freight
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IInvoiceLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IInvoiceLine.LineNumber
            Get
                Return _LineNumber
            End Get
            Set(ByVal Value As String)
                _LineNumber = Value
            End Set
        End Property

        Public Property SalesOrderLine() As String
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As String)
                _SalesOrderLine = Value
            End Set
        End Property
        Public Property NComment() As String
            Get
                Return _NComment
            End Get
            Set(ByVal Value As String)
                _NComment = Value
            End Set
        End Property
        Public Property NMscChargeValue() As String
            Get
                Return _NMscChargeValue
            End Get
            Set(ByVal Value As String)
                _NMscChargeValue = Value
            End Set
        End Property
        Public Property LineMscNetAmount() As String
            Get
                Return _LineMscNetAmount
            End Get
            Set(ByVal Value As String)
                _LineMscNetAmount = Value
            End Set
        End Property
        Public Property NMscTaxCode() As String
            Get
                Return _NMscTaxCode
            End Get
            Set(ByVal Value As String)
                _NMscTaxCode = Value
            End Set
        End Property
        Public Property LineMscChargeTaxAmt() As String
            Get
                Return _LineMscChargeTaxAmt
            End Get
            Set(ByVal Value As String)
                _LineMscChargeTaxAmt = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As FreightLine

            Dim frtLine As New FreightLine

            With frtLine
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                .SalesOrderLine = rootRow.Item("SalesOrderLine").ToString
                .NComment = rootRow.Item("NComment").ToString
                .NMscChargeValue = rootRow.Item("NMscChargeValue").ToString
                .LineMscNetAmount = rootRow.Item("LineMscNetAmount").ToString
                .NMscTaxCode = rootRow.Item("NMscTaxCode").ToString
                .LineMscChargeTaxAmt = rootRow.Item("LineMscChargeTaxAmt").ToString
            End With

            Return frtLine
        End Function

    End Class
End Namespace
