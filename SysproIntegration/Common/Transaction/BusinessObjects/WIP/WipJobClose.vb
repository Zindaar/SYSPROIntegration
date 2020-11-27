Namespace TransactionObjects
    <Serializable()> Public Class WipJobClose
        Implements ITransaction

        Private _blnTransactionDateSpecified As Boolean = False
        Private _blnJournalSpecified As Boolean = False
        Private _blnMaterialValueSpecified As Boolean = False
        Private _blnLabourValueSpecified As Boolean = False

#Region "Local Variables"
        Private _Journal As Integer 'max 5 digits
        Private _Job As String 'max 8
        Private _Complete As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _MaterialValue As Decimal '12.2 signed decimal
        Private _LabourValue As Decimal '12.2 signed decimal
        Private _DistributionLines As New ArrayList

        'Variables for Param Doc
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _PostingPeriod As CommonEnums.PostingPeriodEnum = CommonEnums.PostingPeriodEnum.Current
        Private _TransactionDate As Date

#End Region

#Region "Public Properties"
        Public Property Journal() As Integer
            Get
                Return _Journal
            End Get
            Set(ByVal Value As Integer)
                _Journal = Value
                _blnJournalSpecified = True
            End Set
        End Property
        Public Property Job() As String
            Get
                Return _Job
            End Get
            Set(ByVal Value As String)
                _Job = Value
            End Set
        End Property
        Public Property Complete() As CommonEnums.YesNoEnum
            Get
                Return _Complete
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _Complete = Value
            End Set
        End Property
        Public Property MaterialValue() As Decimal
            Get
                Return _MaterialValue
            End Get
            Set(ByVal Value As Decimal)
                _MaterialValue = Value
                _blnMaterialValueSpecified = True
            End Set
        End Property
        Public Property LabourValue() As Decimal
            Get
                Return _LabourValue
            End Get
            Set(ByVal Value As Decimal)
                _LabourValue = Value
                _blnLabourValueSpecified = True
            End Set
        End Property
        Public ReadOnly Property DistributionLines() As ArrayList
            Get
                Return _DistributionLines
            End Get
        End Property

        'Parameter Properties
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = Value
            End Set
        End Property
        Public Property PostingPeriod() As CommonEnums.PostingPeriodEnum
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As CommonEnums.PostingPeriodEnum)
                _PostingPeriod = Value
            End Set
        End Property
        Public Property TransactionDate() As Date
            Get
                Return _TransactionDate
            End Get
            Set(ByVal Value As Date)
                _TransactionDate = Value
                _blnTransactionDateSpecified = True
            End Set
        End Property

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTJC"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item\Job")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim sbXMLParam As New System.Text.StringBuilder

                sbXMLParam.Append("<PostJobClosure>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<PostingPeriod>{0}</PostingPeriod>", Left(PostingPeriod.ToString, 1))
                If _blnTransactionDateSpecified = True Then
                    sbXMLParam.AppendFormat("<TransactionDate>{0}</TransactionDate>", Format(TransactionDate, "yyyy-MM-dd"))
                Else
                    sbXMLParam.Append("<TransactionDate/>")
                End If
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostJobClosure>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostJobClosure>")
                sbXMLin.Append("<Item>")
                If _blnJournalSpecified Then
                    sbXMLin.AppendFormat("<Journal>{0}</Journal>", Journal)
                Else
                    sbXMLin.AppendFormat("<Journal/>")
                End If
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<Complete>{0}</Complete>", Left(Complete.ToString, 1))
                If _blnMaterialValueSpecified Then
                    sbXMLin.AppendFormat("<MaterialValue>{0}</MaterialValue>", MaterialValue)
                Else
                    sbXMLin.Append("<MaterialValue/>")
                End If
                If _blnLabourValueSpecified Then
                    sbXMLin.AppendFormat("<LabourValue>{0}</LabourValue>", LabourValue)
                Else
                    sbXMLin.Append("<LabourValue/>")
                End If
                For Each lin As WipJobCloseDistribution In DistributionLines
                    lin.AppendDistributionLine(sbXMLin)
                Next
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostJobClosure>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strJobID As String)
            _Job = strJobID
        End Sub

        Private _actionType As CommonEnums.ActionType_Transaction
        Public Property TransactionActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _actionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _actionType = value
            End Set
        End Property

        Public Sub Post() Implements ITransaction.Post
            If TransactionActionType = CommonEnums.ActionType_Transaction.Build Then
                _xmlOut = Transaction.Build(Me)
            ElseIf TransactionActionType = CommonEnums.ActionType_Transaction.Post Then
                _xmlOut = Transaction.Post(Me)
            End If

        End Sub

    End Class

End Namespace
