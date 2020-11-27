Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class TransDetail

#Region " Properties "
        Private _Reference As String
        Public Property Reference() As String
            Get
                Return _Reference
            End Get
            Set(ByVal value As String)
                _Reference = value
            End Set
        End Property

        Private _TrnValue As String
        Public Property TrnValue() As String
            Get
                Return _TrnValue
            End Get
            Set(ByVal value As String)
                _TrnValue = value
            End Set
        End Property

        Private _JournalDate As String
        Public Property JournalDate() As String
            Get
                Return _JournalDate
            End Get
            Set(ByVal value As String)
                _JournalDate = value
            End Set
        End Property

        Private _DiscValue As String
        Public Property DiscValue() As String
            Get
                Return _DiscValue
            End Get
            Set(ByVal value As String)
                _DiscValue = value
            End Set
        End Property

        Private _BaseCurrencyValue As String
        Public Property BaseCurrencyValue() As String
            Get
                Return _BaseCurrencyValue
            End Get
            Set(ByVal value As String)
                _BaseCurrencyValue = value
            End Set
        End Property

        Private _ConvRate As String
        Public Property ConvRate() As String
            Get
                Return _ConvRate
            End Get
            Set(ByVal value As String)
                _ConvRate = value
            End Set
        End Property

        Private _MulDiv As String
        Public Property MulDiv() As String
            Get
                Return _MulDiv
            End Get
            Set(ByVal value As String)
                _MulDiv = value
            End Set
        End Property

        Private _ForeignToLocalConversion As String
        Public Property ForeignToLocalConversion() As String
            Get
                Return _ForeignToLocalConversion
            End Get
            Set(ByVal value As String)
                _ForeignToLocalConversion = value
            End Set
        End Property

#End Region

        Friend Sub New(ByVal row As DataRow)
            _Reference = row.Item("Reference").ToString
            _TrnValue = row.Item("TrnValue").ToString
            _JournalDate = row.Item("JournalDate").ToString
            Try
                _DiscValue = row.Item("DiscValue").ToString
            Catch ex As Exception
                _DiscValue = 0
            End Try
            Try
                _BaseCurrencyValue = row.Item("BaseCurrencyValue").ToString
                _ConvRate = row.Item("ConvRate").ToString
                _MulDiv = row.Item("MulDiv").ToString
                _ForeignToLocalConversion = row.Item("ForeignToLocalConversion").ToString
            Catch ex As Exception
                'This is a local currency transaction
                _BaseCurrencyValue = _TrnValue
                _ConvRate = 1
                _MulDiv = "M"
                _ForeignToLocalConversion = ""
            End Try

        End Sub

    End Class

    <Serializable()> Public Class TransDetailCollection
        Inherits System.Collections.Generic.List(Of TransDetail)

        Friend Sub New(ByVal ds As DataSet, ByVal iInvoiceDetailID As Integer)
            Try
                If ds Is Nothing Then Exit Sub
                Dim linesTable As DataTable = ds.Tables("TransDetail")
                If linesTable Is Nothing Then Exit Sub
                For Each row As DataRow In linesTable.Rows
                    If row.Item("InvoiceDetail_id").ToString = iInvoiceDetailID.ToString Then
                        Me.Add(New TransDetail(row))
                    End If
                Next
            Catch ex As IndexOutOfRangeException
                'There is no PostDated table in the dataset, but don't worry about it
            End Try
        End Sub
    End Class

End Namespace