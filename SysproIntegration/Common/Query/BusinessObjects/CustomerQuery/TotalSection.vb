Namespace QueryObjects.CustomerQuery
    <Serializable()> Public Class TotalSection

#Region " Properties "
        Private _BalBroughtFwd As String
        Private _CurrentBalance As String
        Private _ValueFutureInv As String
        Private _Current As String
        Private _Days30 As String
        Private _Days60 As String
        Private _Days90 As String
        Private _Days120 As String
        Private _Days150 As String
        Private _Days180 As String
        Private _DiscountAvailable As String
        Private _CreditBalance As String
        Private _UnallocatedPDChqs As String
        Private _UnavailablePDChqs As String
        Private _CurrentLessPDChqs As String
        Private _CurrentMsg As String
        Private _Days30Msg As String
        Private _Days60Msg As String
        Private _Days90Msg As String
        Private _Days120Msg As String
        Private _Days150Msg As String
        Private _Days180Msg As String

        Public Property BalBroughtFwd() As String
            Get
                Return _BalBroughtFwd
            End Get
            Set(ByVal Value As String)
                _BalBroughtFwd = Value
            End Set
        End Property
        Public Property CurrentBalance() As Decimal
            Get
                Return _CurrentBalance
            End Get
            Set(ByVal Value As Decimal)
                _CurrentBalance = Value
            End Set
        End Property
        Public Property ValueFutureInv() As String
            Get
                Return _ValueFutureInv
            End Get
            Set(ByVal Value As String)
                _ValueFutureInv = Value
            End Set
        End Property
        Public Property Current() As Decimal
            Get
                Return _Current
            End Get
            Set(ByVal Value As Decimal)
                _Current = Value
            End Set
        End Property
        Public Property Days30() As Decimal
            Get
                Return _Days30
            End Get
            Set(ByVal Value As Decimal)
                _Days30 = Value
            End Set
        End Property
        Public Property Days60() As Decimal
            Get
                Return _Days60
            End Get
            Set(ByVal Value As Decimal)
                _Days60 = Value
            End Set
        End Property
        Public Property Days90() As Decimal
            Get
                Return _Days90
            End Get
            Set(ByVal Value As Decimal)
                _Days90 = Value
            End Set
        End Property
        Public Property Days120() As Decimal
            Get
                Return _Days120
            End Get
            Set(ByVal Value As Decimal)
                _Days120 = Value
            End Set
        End Property
        Public Property Days150() As Decimal
            Get
                Return _Days150
            End Get
            Set(ByVal Value As Decimal)
                _Days150 = Value
            End Set
        End Property
        Public Property Days180() As Decimal
            Get
                Return _Days180
            End Get
            Set(ByVal Value As Decimal)
                _Days180 = Value
            End Set
        End Property
        Public Property DiscountAvailable() As String
            Get
                Return _DiscountAvailable
            End Get
            Set(ByVal Value As String)
                _DiscountAvailable = Value
            End Set
        End Property
        Public Property CreditBalance() As String
            Get
                Return _CreditBalance
            End Get
            Set(ByVal Value As String)
                _CreditBalance = Value
            End Set
        End Property
        Public Property UnallocatedPDChqs() As String
            Get
                Return _UnallocatedPDChqs
            End Get
            Set(ByVal Value As String)
                _UnallocatedPDChqs = Value
            End Set
        End Property
        Public Property UnavailablePDChqs() As String
            Get
                Return _UnavailablePDChqs
            End Get
            Set(ByVal Value As String)
                _UnavailablePDChqs = Value
            End Set
        End Property
        Public Property CurrentLessPDChqs() As String
            Get
                Return _CurrentLessPDChqs
            End Get
            Set(ByVal Value As String)
                _CurrentLessPDChqs = Value
            End Set
        End Property
        Public Property CurrentMsg() As String
            Get
                Return _CurrentMsg
            End Get
            Set(ByVal Value As String)
                _CurrentMsg = Value
            End Set
        End Property
        Public Property Days30Msg() As String
            Get
                Return _Days30Msg
            End Get
            Set(ByVal Value As String)
                _Days30Msg = Value
            End Set
        End Property
        Public Property Days60Msg() As String
            Get
                Return _Days60Msg
            End Get
            Set(ByVal Value As String)
                _Days60Msg = Value
            End Set
        End Property
        Public Property Days90Msg() As String
            Get
                Return _Days90Msg
            End Get
            Set(ByVal Value As String)
                _Days90Msg = Value
            End Set
        End Property
        Public Property Days120Msg() As String
            Get
                Return _Days120Msg
            End Get
            Set(ByVal Value As String)
                _Days120Msg = Value
            End Set
        End Property
        Public Property Days150Msg() As String
            Get
                Return _Days150Msg
            End Get
            Set(ByVal Value As String)
                _Days150Msg = Value
            End Set
        End Property
        Public Property Days180Msg() As String
            Get
                Return _Days180Msg
            End Get
            Set(ByVal Value As String)
                _Days180Msg = Value
            End Set
        End Property

#End Region

        Friend Sub New(ByVal ds As DataSet)

            Dim r As DataRow
            If ds.Tables("TotalSection") Is Nothing Then
                Exit Sub
            Else
                r = ds.Tables("TotalSection").Rows(0)
            End If

            _BalBroughtFwd = Convert.ToString(r("BalBroughtFwd"))
            _CurrentBalance = Convert.ToDecimal(r("CurrentBalance"))
            _ValueFutureInv = Convert.ToString(r("ValueFutureInv"))
            _Current = Convert.ToDecimal(r("Current"))
            _Days30 = Convert.ToDecimal(r("Days30"))
            _Days60 = Convert.ToDecimal(r("Days60"))
            _Days90 = Convert.ToDecimal(r("Days90"))
            _Days120 = Convert.ToDecimal(r("Days120"))
            _Days150 = Convert.ToDecimal(r("Days150"))
            _Days180 = Convert.ToDecimal(r("Days180"))
            _DiscountAvailable = Convert.ToString(r("DiscountAvailable"))
            _CreditBalance = Convert.ToString(r("CreditBalance"))
            _UnallocatedPDChqs = Convert.ToString(r("UnallocatedPDChqs"))
            _UnavailablePDChqs = Convert.ToString(r("UnavailablePDChqs"))
            _CurrentLessPDChqs = Convert.ToString(r("CurrentLessPDChqs"))
            _CurrentMsg = Convert.ToString(r("CurrentMsg"))
            _Days30Msg = Convert.ToString(r("Days30Msg"))
            _Days60Msg = Convert.ToString(r("Days60Msg"))
            _Days90Msg = Convert.ToString(r("Days90Msg"))
            _Days120Msg = Convert.ToString(r("Days120Msg"))
            _Days150Msg = Convert.ToString(r("Days150Msg"))
            _Days180Msg = Convert.ToString(r("Days180Msg"))

        End Sub
    End Class
End Namespace

