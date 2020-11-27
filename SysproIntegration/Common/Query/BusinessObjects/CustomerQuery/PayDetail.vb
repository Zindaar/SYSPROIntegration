Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class PayDetail

#Region " Properties "

        Private _chequeReference As String
        Public Property ChequeReference() As String
            Get
                Return _chequeReference
            End Get
            Set(ByVal value As String)
                _chequeReference = value
            End Set
        End Property

        Private _PayDate As String
        Public Property PayDate() As String
            Get
                Return _PayDate
            End Get
            Set(ByVal value As String)
                _PayDate = value
            End Set
        End Property

        Private _PayValue As String
        Public Property PayValue() As String
            Get
                Return _PayValue
            End Get
            Set(ByVal value As String)
                _PayValue = value
            End Set
        End Property

        Private _PaymYear As String
        Public Property PaymYear() As String
            Get
                Return _PaymYear
            End Get
            Set(ByVal value As String)
                _PaymYear = value
            End Set
        End Property

        Private _PaymMonth As String
        Public Property PaymMonth() As String
            Get
                Return _PaymMonth
            End Get
            Set(ByVal value As String)
                _PaymMonth = value
            End Set
        End Property
#End Region

        Friend Sub New(ByVal row As DataRow)
            _chequeReference = row.Item("ChequeReference").ToString
            _PayDate = row.Item("PayDate").ToString
            _PayValue = row.Item("PayValue").ToString
            _PaymYear = row.Item("PaymYear").ToString
            _PaymMonth = row.Item("PaymMonth").ToString

        End Sub
    End Class

    <Serializable()> Public Class PayDetailCollection
        Inherits System.Collections.Generic.List(Of PayDetail)

        Friend Sub New(ByVal ds As DataSet)
            Try
                Dim linesTable As DataTable = ds.Tables("PayDetail")
                If linesTable Is Nothing Then Exit Sub
                For Each row As DataRow In linesTable.Rows
                    Me.Add(New PayDetail(row))
                Next
            Catch ex As IndexOutOfRangeException
                'There is no PostDated table in the dataset, but don't worry about it
            End Try
        End Sub
    End Class

End Namespace