Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchNoteQuery.QueryData.Output
    <Serializable()> Public Class BinLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0001</LineNumber> 
        Private _Bin As String = "" '>FG1</Bin> 
        Private _Lot As String = "" ' /> 
        Private _StockQtyToShip As String = "" '>2.000</StockQtyToShip> 

#End Region

#Region " Public Properties "

        Public Property DocumentNumber() As String
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String
            Get
                Return _LineNumber
            End Get
            Set(ByVal Value As String)
                _LineNumber = Value
            End Set
        End Property
        Public Property Bin() As String
            Get
                Return _Bin
            End Get
            Set(ByVal Value As String)
                _Bin = Value
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
        Public Property StockQtyToShip() As String
            Get
                Return _StockQtyToShip
            End Get
            Set(ByVal Value As String)
                _StockQtyToShip = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As BinLine

            Dim bLine As New BinLine

            With bLine
                Try : .DocumentNumber = rootRow.Item("DocumentNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .LineNumber = rootRow.Item("LineNumber").ToString : Catch ex As ArgumentException : End Try
                Try : .Bin = rootRow.Item("Bin").ToString : Catch ex As ArgumentException : End Try
                Try : .Lot = rootRow.Item("Lot").ToString : Catch ex As ArgumentException : End Try
                Try : .StockQtyToShip = rootRow.Item("StockQtyToShip").ToString : Catch ex As ArgumentException : End Try
            End With

            Return bLine
        End Function
    End Class
End Namespace

