Namespace TransactionObjects.SalesOrder
    <Serializable()> Public Class SalesOrderCommentLine

        Private _CustomerPoLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _Comment As String 'max 45
        Private _AttachedLineNumber As Integer '4 digits positive
        Private _CommentType As CommonEnums.CommentTypeEnum = CommonEnums.CommentTypeEnum.InvoiceAndOrder  '

        Public ReadOnly Property HandleSpecialCharacters(ByVal strStringToCheck As String) As String
            Get
                strStringToCheck = Replace(strStringToCheck, "&", "&amp;")
                strStringToCheck = Replace(strStringToCheck, "'", "&apos;")
                strStringToCheck = Replace(strStringToCheck, """", "&quot;")
                strStringToCheck = Replace(strStringToCheck, "<", "&lt;")
                strStringToCheck = Replace(strStringToCheck, ">", "&gt;")
                Return strStringToCheck
            End Get
        End Property

        Public Property CustomerPoLine() As Integer
            Get
                Return _CustomerPoLine
            End Get
            Set(ByVal Value As Integer)
                _CustomerPoLine = Value
            End Set
        End Property
        Public Property LineActionType() As CommonEnums.ActionTypeEnum
            Get
                Return _LineActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _LineActionType = Value
            End Set
        End Property
        Public Property Comment() As String
            Get
                Return HandleSpecialCharacters(_Comment)
            End Get
            Set(ByVal Value As String)
                _Comment = Value
            End Set
        End Property
        Public Property AttachedLineNumber() As Integer
            Get
                Return _AttachedLineNumber
            End Get
            Set(ByVal Value As Integer)
                _AttachedLineNumber = Value
            End Set
        End Property
        Public Property CommentType() As CommonEnums.CommentTypeEnum
            Get
                Return _CommentType
            End Get
            Set(ByVal Value As CommonEnums.CommentTypeEnum)
                _CommentType = Value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub AppendCommentLine(ByRef sbXMLin As System.Text.StringBuilder)
            sbXMLin.Append("<CommentLine>" & vbCrLf)
            sbXMLin.AppendFormat("<CustomerPoLine>{0}</CustomerPoLine>" & vbCrLf, CustomerPoLine)
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>" & vbCrLf, Left(LineActionType.ToString, 1))
            sbXMLin.AppendFormat("<Comment>{0}</Comment>" & vbCrLf, Comment)
            sbXMLin.AppendFormat("<AttachedLineNumber>{0}</AttachedLineNumber>" & vbCrLf, AttachedLineNumber)
            sbXMLin.AppendFormat("<CommentType>{0}</CommentType>" & vbCrLf, Left(CommentType.ToString, 1))
            sbXMLin.Append("</CommentLine>" & vbCrLf)
        End Sub
    End Class

End Namespace
