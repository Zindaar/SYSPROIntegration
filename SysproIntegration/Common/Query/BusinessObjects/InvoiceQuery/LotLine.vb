Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class LotLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0002</LineNumber> 
        Private _Lot As String = "" '>0000076544</Lot> 
        Private _Version As String = "" '>05</Version> 
        Private _Release As String = "" '>01</Release> 
        Private _Certificate As String = "" '>Vnt6</Certificate> 
        Private _StockQtyToShip As String = "" '>5.000</StockQtyToShip> 
        Private _LotExpiryDate As String = "" '>2006-12-01</LotExpiryDate> 

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
        Public Property Lot() As String
            Get
                Return _Lot
            End Get
            Set(ByVal Value As String)
                _Lot = Value
            End Set
        End Property
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal Value As String)
                _Version = Value
            End Set
        End Property
        Public Property Release() As String
            Get
                Return _Release
            End Get
            Set(ByVal Value As String)
                _Release = Value
            End Set
        End Property
        Public Property Certificate() As String
            Get
                Return _Certificate
            End Get
            Set(ByVal Value As String)
                _Certificate = Value
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
        Public Property LotExpiryDate() As String
            Get
                Return _LotExpiryDate
            End Get
            Set(ByVal Value As String)
                _LotExpiryDate = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As LotLine

            Dim lLine As New LotLine

            With lLine
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                .Lot = rootRow.Item("Lot").ToString
                .Version = rootRow.Item("Version").ToString
                .Release = rootRow.Item("Release").ToString
                .Certificate = rootRow.Item("Certificate").ToString
                .StockQtyToShip = rootRow.Item("StockQtyToShip").ToString
                .LotExpiryDate = rootRow.Item("LotExpiryDate").ToString
            End With

            Return lLine

        End Function
    End Class
End Namespace
