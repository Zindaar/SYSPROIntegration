Namespace Common
    ''' -----------------------------------------------------------------------------
    ''' Project	 : SysproIntegration
    ''' Class	 : SysproIntegration.SerialAllocation
    ''' 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Use this object to specify From and To serial numbers and a quantity for use in posting other business objects
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	20/04/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class SerialAllocation

        'Local Variables
        Private _FromSerialNumber As String 'max 20
        Private _ToSerialNumber As String 'max 20
        Private _SerialQuantity As Integer 'max length 20

        'Public properties
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element specifies the starting serial number to be allocated. (20 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property FromSerialNumber() As String
            Get
                Return _FromSerialNumber
            End Get
            Set(ByVal Value As String)
                _FromSerialNumber = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element specifies the ending serial number to be allocated. If this element is not supplied, serial numbers will be allocated starting at the FromSerialNumber until the specified quantity has been allocated.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property ToSerialNumber() As String
            Get
                Return _ToSerialNumber
            End Get
            Set(ByVal Value As String)
                _ToSerialNumber = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory and specifies the total quantity to be received for the specified range.
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
                _SerialQuantity = Value
            End Set
        End Property


        'Constructor
        Public Sub New(ByVal strFromSerialNumber As String, ByVal strToSerialNumber As String, ByVal iSerialQuantity As Integer)
            _FromSerialNumber = strFromSerialNumber
            _ToSerialNumber = strToSerialNumber
            _SerialQuantity = iSerialQuantity
        End Sub

    End Class

End Namespace
