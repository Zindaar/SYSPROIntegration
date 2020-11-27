Namespace Common
    ''' -----------------------------------------------------------------------------
    ''' Project	 : SysproIntegration
    ''' Class	 : SysproIntegration.SerialNumber
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Use this object to specify serial numbers and related quantities for use in posting other business objects
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	20/04/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class SerialNumber

        'Local Variables
        Private _SerialNumber As String 'max 20
        Private _SerialQuantity As Integer 'max length 20
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Serial number for a serialized stock code. (20 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialNumber() As String
            Get
                Return _SerialNumber
            End Get
            Set(ByVal Value As String)
                _SerialNumber = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory and specifies the quantity applicable to the specified serial number. It can only be 1 or -1.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property SerialQuantity() As Integer
            Get
                Return _SerialQuantity
            End Get
            Set(ByVal Value As Integer)
                If Value <> 1 Or Value <> -1 Then
                    Throw New Exception("Qty for a serial number can only be 1 or -1")
                End If
                _SerialQuantity = Value
            End Set
        End Property


        'Constructor
        Public Sub New(ByVal strSerialNumber As String, ByVal iSerialQuantity As Integer)
            _SerialNumber = strSerialNumber
            _SerialQuantity = iSerialQuantity
        End Sub
    End Class

End Namespace
