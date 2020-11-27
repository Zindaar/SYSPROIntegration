Namespace TransactionObjects

    ''' -----------------------------------------------------------------------------
    ''' Project	 : SysproIntegration
    ''' Class	 : SysproIntegration.BinNumber
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Use this object to specify Bin numbers and related quantities for use in posting other business objects - specifically the BackOrderRelease Business Object
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	09/05/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class Bin

        'Local Variables
        Private _BinLocation As String 'max 6
        Private _BinQuantity As Decimal '7.3 numeric
        Private _BinUnits As Integer 'max 7 digits
        Private _BinPieces As Integer 'max 3 digits

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' BinLocation may not be more than 6 characters. Will be validated against the inventory Bin file for the stock code
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property BinLocation() As String
            Get
                Return _BinLocation
            End Get
            Set(ByVal Value As String)
                _BinLocation = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' A bin quantity must be supplied for every bin location supplied if the stock code does not make use of unit quantity processing. If the stock item makes use of unit processing - the quantity can either be supplied as a decimal value or else as Units and Pieces. The bin quantity may not have more than 7 characters for integer and 3 characters for decimals
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property BinQuantity() As Decimal
            Get
                Return _BinQuantity
            End Get
            Set(ByVal Value As Decimal)
                _BinQuantity = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Must contain the number of units to import for a Bin location for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value. May not be more than 7 characters
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property BinUnits() As Integer
            Get
                Return _BinUnits
            End Get
            Set(ByVal Value As Integer)
                _BinUnits = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Must contain the number of pieces to import for a Bin location for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value. May not be more than 3 characters
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property BinPieces() As Integer
            Get
                Return _BinPieces
            End Get
            Set(ByVal Value As Integer)
                _BinPieces = Value
            End Set
        End Property

        Public Sub AppendBin(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.AppendFormat("<BinLocation>{0}</BinLocation>", BinLocation)
            sbXMLin.AppendFormat("<BinQuantity>{0}</BinQuantity>", BinQuantity)
            sbXMLin.AppendFormat("<BinUnits>{0}</BinUnits>", BinUnits)
            sbXMLin.AppendFormat("<BinPieces>{0}</BinPieces>", BinPieces)
        End Sub

        'Constructor
        Public Sub New(ByVal strBinLocation As String, ByVal dBinQuantity As Decimal)
            _BinLocation = strBinLocation
            _BinQuantity = dBinQuantity

        End Sub

    End Class

End Namespace
