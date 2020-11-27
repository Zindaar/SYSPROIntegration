Namespace TransactionObjects
    ''' -----------------------------------------------------------------------------
    ''' Project	 : SysproIntegration
    ''' Class	 : SysproIntegration.SerialNumber
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Use this object to specify serial numbers and related quantities for use in posting other business objects - specifically the BackOrderRelease Business Object
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	09/05/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class Serial
        Inherits Common.SerialNumber

        'Local Variables
        Private _SerialCreationDate As Date
        Private _SerialExpiryDate As Date
        Private _SerialScrapDate As Date
        Private _SerialLocation As String 'max 8 digits
        Private _SerialUnits As Integer 'max 7 digits
        Private _SerialPieces As Integer 'max 3 digits

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' The serial creation date will be saved in the serial tracking master header file against the serial number
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialCreationDate() As Date
            Get
                Return _SerialCreationDate
            End Get
            Set(ByVal Value As Date)
                _SerialCreationDate = Value
            End Set
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial expiry date will be saved against the serial number
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialExpiryDate() As Date
            Get
                Return _SerialExpiryDate
            End Get
            Set(ByVal Value As Date)
                _SerialExpiryDate = Value
            End Set
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial scrap date will be saved against the serial number
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialScrapDate() As Date
            Get
                Return _SerialScrapDate
            End Get
            Set(ByVal Value As Date)
                _SerialScrapDate = Value
            End Set
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial location will be saved against the serial number
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialLocation() As String
            Get
                Return _SerialLocation
            End Get
            Set(ByVal Value As String)
                _SerialLocation = Value
            End Set
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Must contain the number of units to import for a batch Serial for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value. May not be more than 7 characters
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialUnits() As Integer
            Get
                Return _SerialUnits
            End Get
            Set(ByVal Value As Integer)
                _SerialUnits = Value
            End Set
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Must contain the number of pieces to import for a batch Serial for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value. May not be more than 3 characters
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	09/05/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialPieces() As Integer
            Get
                Return _SerialPieces
            End Get
            Set(ByVal Value As Integer)
                _SerialPieces = Value
            End Set
        End Property

        Public Sub AppendSerial(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.AppendFormat("<SerialNumber>{0}</SerialNumber>", SerialNumber)
            sbXMLin.AppendFormat("<SerialQuantity>{0}</SerialQuantity>", SerialQuantity)
            If Format(SerialCreationDate, "yyyy-MM-dd") = "0001-01-01" Then
                sbXMLin.AppendFormat("<SerialCreationDate />")
            Else
                sbXMLin.AppendFormat("<SerialCreationDate>{0}</SerialCreationDate>", Format(SerialCreationDate, "yyyy-MM-dd"))
            End If
            If Format(SerialExpiryDate, "yyyy-MM-dd") = "0001-01-01" Then
                sbXMLin.AppendFormat("<SerialExpiryDate />")
            Else
                sbXMLin.AppendFormat("<SerialExpiryDate>{0}</SerialExpiryDate>", Format(SerialExpiryDate, "yyyy-MM-dd"))
            End If
            If Format(SerialScrapDate, "yyyy-MM-dd") = "0001-01-01" Then
                sbXMLin.AppendFormat("<SerialScrapDate />")
            Else
                sbXMLin.AppendFormat("<SerialScrapDate>{0}</SerialScrapDate>", Format(SerialScrapDate, "yyyy-MM-dd"))
            End If
            sbXMLin.AppendFormat("<SerialLocation>{0}</SerialLocation>", SerialLocation)
            sbXMLin.AppendFormat("<SerialUnits>{0}</SerialUnits>", SerialUnits)
            sbXMLin.AppendFormat("<SerialPieces>{0}</SerialPieces>", SerialPieces)
        End Sub

        'Constructor
        Public Sub New(ByVal strSerialNumber As String, ByVal iSerialQuantity As Integer)
            MyBase.New(strSerialNumber, iSerialQuantity)
        End Sub

    End Class

End Namespace
