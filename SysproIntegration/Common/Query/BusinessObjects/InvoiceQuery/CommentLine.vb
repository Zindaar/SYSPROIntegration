Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class CommentLine
        Implements IInvoiceLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _LineNumber As String = "" '>0005</LineNumber> 
        Private _SalesOrderLine As String = "" '>5</SalesOrderLine> 
        Private _NComment As String = "" '>07/06/04</NComment> 

#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As InvoiceLineTypeEnum Implements IInvoiceLine.LineType
            Get
                Return InvoiceLineTypeEnum.Comment
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IInvoiceLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IInvoiceLine.LineNumber
            Get
                Return _LineNumber
            End Get
            Set(ByVal Value As String)
                _LineNumber = Value
            End Set
        End Property
        Public Property SalesOrderLine() As String
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As String)
                _SalesOrderLine = Value
            End Set
        End Property
        Public Property NComment() As String
            Get
                Return _NComment
            End Get
            Set(ByVal Value As String)
                _NComment = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDataRow(ByVal rootRow As DataRow) As CommentLine

            Dim cmtLine As New CommentLine

            With cmtLine
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("LineNumber").ToString
                .SalesOrderLine = rootRow.Item("SalesOrderLine").ToString
                .NComment = rootRow.Item("NComment").ToString
            End With

            Return cmtLine
        End Function
    End Class
End Namespace
