Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class PostDated

#Region " Properties "
        Private _amount As String
        Public Property Cheque() As String
            Get
                Return _cheque
            End Get
            Set(ByVal value As String)
                _cheque = value
            End Set
        End Property

        Private _availableDate As String
        Public Property AvailableDate() As String
            Get
                Return _availableDate
            End Get
            Set(ByVal value As String)
                _availableDate = value
            End Set
        End Property

        Private _cheque As String
        Public Property Amount() As String
            Get
                Return _amount
            End Get
            Set(ByVal value As String)
                _amount = value
            End Set
        End Property

#End Region

        Friend Sub New(ByVal row As DataRow)
            _cheque = row.Item("Cheque").ToString
            _availableDate = row.Item("AvailableDate").ToString
            _amount = row.Item("Amount").ToString
        End Sub

    End Class

    <Serializable()> Public Class PostDatedCollection
        Inherits System.Collections.Generic.List(Of PostDated)

        Friend Sub New(ByVal ds As DataSet)
            Try
                Dim linesTable As DataTable = ds.Tables("PostDated")
                If linesTable Is Nothing Then Exit Sub
                For Each row As DataRow In linesTable.Rows
                    Me.Add(New PostDated(row))
                Next
            Catch ex As IndexOutOfRangeException
                'There is no PostDated table in the dataset, but don't worry about it
            End Try
        End Sub

    End Class

End Namespace