Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class SerialLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0002</LineNumber> 
        Private _Serial As String = "" '>100</Serial> 
        Private _Lot As String = "" '>0000076544</Lot> 
        Private _StockQtyToShip As String = "" '>5.000</StockQtyToShip> 
        Private _SerialDescription As String = "" '>Serial no 100 - batch</SerialDescription> 
        Private _ExpiryDate As String = "" '>2010-12-12</ExpiryDate> 
        Private _Location As String = "" '>A24</Location> 

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
        Public Property Serial() As String
            Get
                Return _Serial
            End Get
            Set(ByVal Value As String)
                _Serial = Value
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
        Public Property SerialDescription() As String
            Get
                Return _SerialDescription
            End Get
            Set(ByVal Value As String)
                _SerialDescription = Value
            End Set
        End Property
        Public Property ExpiryDate() As String
            Get
                Return _ExpiryDate
            End Get
            Set(ByVal Value As String)
                _ExpiryDate = Value
            End Set
        End Property
        Public Property Location() As String
            Get
                Return _Location
            End Get
            Set(ByVal Value As String)
                _Location = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As SerialLine

            Dim sLine As New SerialLine

            With sLine
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                .Serial = rootRow.Item("Serial").ToString
                .Lot = rootRow.Item("Lot").ToString
                .StockQtyToShip = rootRow.Item("StockQtyToShip").ToString
                .SerialDescription = rootRow.Item("SerialDescription").ToString
                .ExpiryDate = rootRow.Item("ExpiryDate").ToString
                .Location = rootRow.Item("Location").ToString
            End With

            Return sLine

        End Function
    End Class
End Namespace
