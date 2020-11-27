Namespace QueryObjects.DispatchNoteQuery
    <Serializable()> Public Class CommentLine
        Implements IDispatchNoteLine

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _DispatchNoteLine As String = "" '>0005</LineNumber> 
        Private _CommentFromLin As String = "" '>5</SalesOrderLine> 
        Private _NComment As String = "" '>07/06/04</NComment> 

#End Region

#Region " Public Properties "
        Public ReadOnly Property LineType() As DispatchNoteLineTypeEnum Implements IDispatchNoteLine.LineType
            Get
                Return DispatchNoteLineTypeEnum.Comment
            End Get
        End Property
        Public Property DocumentNumber() As String Implements IDispatchNoteLine.DocumentNumber
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property LineNumber() As String Implements IDispatchNoteLine.LineNumber
            Get
                Return _DispatchNoteLine
            End Get
            Set(ByVal Value As String)
                _DispatchNoteLine = Value
            End Set
        End Property
        Public Property SalesOrderLine() As String
            Get
                Return _CommentFromLin
            End Get
            Set(ByVal Value As String)
                _CommentFromLin = Value
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
                '.DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .LineNumber = rootRow.Item("DispatchNoteLine").ToString
                .SalesOrderLine = rootRow.Item("NCommentFromLin").ToString
                .NComment = rootRow.Item("NComment").ToString
            End With

            Return cmtLine
        End Function
    End Class
End Namespace
