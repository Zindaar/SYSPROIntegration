Namespace TransactionObjects
    <Serializable()> Public Class WipJobCloseDistribution

        Private _LedgerCode As String
        Private _LedgerAmount As Decimal
        Private _PasswordForLedgerCode As String

        Private _blnLedgerCodeSpecified As Boolean = False
        Private _blnLedgerAmountSpecified As Boolean = False
        Private _blnPasswordForLedgerCodeSpecified As Boolean = False

        Public Property LedgerCode() As String
            Get
                Return _LedgerCode
            End Get
            Set(ByVal Value As String)
                _LedgerCode = Value
                _blnLedgerCodeSpecified = True
            End Set
        End Property

        Public Property LedgerAmount() As Decimal
            Get
                Return _LedgerAmount
            End Get
            Set(ByVal Value As Decimal)
                _LedgerAmount = Value
                _blnLedgerAmountSpecified = True
            End Set
        End Property

        Public Property PasswordForLedgerCode() As String
            Get
                Return _PasswordForLedgerCode
            End Get
            Set(ByVal Value As String)
                _PasswordForLedgerCode = Value
                _blnPasswordForLedgerCodeSpecified = True
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub AppendDistributionLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<Distribution>")
            If _blnLedgerCodeSpecified Then
                sbXMLin.AppendFormat("<LedgerCode>{0}</LedgerCode>", LedgerCode)
            Else
                sbXMLin.AppendFormat("<LedgerCode/>")
            End If
            If _blnLedgerAmountSpecified Then
                sbXMLin.AppendFormat("<LedgerAmount>{0}</LedgerAmount>", LedgerAmount)
            Else
                sbXMLin.AppendFormat("<LedgerAmount/>")
            End If
            If _blnPasswordForLedgerCodeSpecified Then
                sbXMLin.AppendFormat("<PasswordForLedgerCode>{0}</PasswordForLedgerCode>", PasswordForLedgerCode)
            Else
                sbXMLin.AppendFormat("<PasswordForLedgerCode/>")
            End If

            sbXMLin.Append("</Distribution>")
        End Sub

    End Class
End Namespace
