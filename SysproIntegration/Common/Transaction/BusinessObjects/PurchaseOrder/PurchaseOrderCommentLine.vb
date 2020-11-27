Namespace TransactionObjects.PurchaseOrder
    <Serializable()> Public Class PurchaseOrderCommentLine

        Private _PurchaseOrderLine As Integer '4 digits positive
        Private _LineActionType As CommonEnums.ActionTypeEnum '
        Private _Comment As String 'max 45
        Private _AttachedToStkLineNumber As Integer '4 digits positive
        Private _DeleteAttachedCommentLines As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ChangeSingleCommentLine As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        Public Property PurchaseOrderLine() As Integer
            Get
                Return _PurchaseOrderLine
            End Get
            Set(ByVal Value As Integer)
                _PurchaseOrderLine = Value
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
                Return _Comment
            End Get
            Set(ByVal Value As String)
                _Comment = Value
            End Set
        End Property
        Public Property AttachedToStkLineNumber() As Integer
            Get
                Return _AttachedToStkLineNumber
            End Get
            Set(ByVal Value As Integer)
                _AttachedToStkLineNumber = Value
            End Set
        End Property
        Public Property DeleteAttachedCommentLines() As CommonEnums.YesNoEnum
            Get
                Return _DeleteAttachedCommentLines
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _DeleteAttachedCommentLines = Value
            End Set
        End Property
        Public Property ChangeSingleCommentLine() As CommonEnums.YesNoEnum
            Get
                Return _ChangeSingleCommentLine
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ChangeSingleCommentLine = Value
            End Set
        End Property


        Public Sub New()
        End Sub

        Public Sub AppendCommentLine(ByRef sbXMLin As System.Text.StringBuilder)

            sbXMLin.Append("<CommentLine>")
            If PurchaseOrderLine > 0 Then
                sbXMLin.AppendFormat("<PurchaseOrderLine>{0}</PurchaseOrderLine>", PurchaseOrderLine)
            End If
            sbXMLin.AppendFormat("<LineActionType>{0}</LineActionType>", Left(LineActionType.ToString, 1))
            sbXMLin.AppendFormat("<Comment>{0}</Comment>", Comment)
            sbXMLin.AppendFormat("<AttachedToStkLineNumber>{0}</AttachedToStkLineNumber>", AttachedToStkLineNumber)

            If DeleteAttachedCommentLines = CommonEnums.YesNoEnum.No Then
                sbXMLin.AppendFormat("<DeleteAttachedCommentLines />")
            Else
                sbXMLin.AppendFormat("<DeleteAttachedCommentLines>{0}</DeleteAttachedCommentLines>", Left(DeleteAttachedCommentLines.ToString, 1))
            End If

            If ChangeSingleCommentLine = CommonEnums.YesNoEnum.No Then
                sbXMLin.AppendFormat("<ChangeSingleCommentLine/>")
            Else
                sbXMLin.AppendFormat("<ChangeSingleCommentLine>{0}</ChangeSingleCommentLine>", Left(ChangeSingleCommentLine.ToString, 1))
            End If

            sbXMLin.Append("</CommentLine>")

        End Sub


    End Class

End Namespace
