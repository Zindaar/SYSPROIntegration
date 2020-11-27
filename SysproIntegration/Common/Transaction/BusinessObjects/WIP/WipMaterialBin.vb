Namespace TransactionObjects
    <Serializable()> Public Class WipMaterialBin

        'Private Variables
        Private _BinLocation As String 'max  6
        Private _BinQuantity As Decimal 'signed decimal max 11 digits

        'Public Properties
        Public Property BinLocation() As String
            Get
                Return _BinLocation
            End Get
            Set(ByVal Value As String)
                _BinLocation = Value
            End Set
        End Property
        Public Property BinQuantity() As Decimal
            Get
                Return _BinQuantity
            End Get
            Set(ByVal Value As Decimal)
                _BinQuantity = Value
            End Set
        End Property

        'Constructor
        Public Sub New(ByVal strBinLocation As String, ByVal dBinQuantity As Decimal)
            _BinLocation = strBinLocation
            _BinQuantity = dBinQuantity
        End Sub

    End Class

End Namespace
