Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> Public Class FreightLine
        Implements IDispatchInvoiceLine

#Region " Private Variables "
        Private _LineType As DispatchInvoiceLineTypeEnum = DispatchInvoiceLineTypeEnum.Freight
        Private _DocumentNumber As String = ""
        Private _LineNumber As String = ""
        Private _SalesOrderLine As String = ""
        Private _NComment As String = ""
        Private _NMscChargeValue As String = ""
        Private _LineMscNetAmount As String = ""
        Private _NMscTaxCode As String = ""
        Private _LineMscChargeTaxAmt As String = ""
        
#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As DispatchInvoiceLineTypeEnum Implements IDispatchInvoiceLine.LineType
            Get
                Return _LineType
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IDispatchInvoiceLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IDispatchInvoiceLine.LineNumber
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

            Dim freightLine As New FreightLine

            With freightLine
                Try : .DocumentNumber = rootRow.Item("DocumentNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .LineNumber = rootRow.Item("LineNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .SalesOrderLine = rootRow.Item("SalesOrderInitLine").ToString : Catch ex As ArgumentException : End Try
                Try : .NComment = rootRow.Item("NComment").ToString : Catch ex As ArgumentException : End Try
                Try : .NMscChargeValue = rootRow.Item("NMscChargeValue").ToString : Catch ex As ArgumentException : End Try
                Try : .LineMscNetAmount = rootRow.Item("LineMscNetAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .NMscTaxCode = rootRow.Item("NMscTaxCode").ToString : Catch ex As ArgumentException : End Try
                Try : .LineMscChargeTaxAmt = rootRow.Item("LineMscChargeTaxAmt").ToString : Catch ex As ArgumentException : End Try
            End With

            Return freightLine

        End Function

    End Class
End Namespace
