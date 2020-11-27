Namespace TransactionObjects
    <Serializable()> Public Class WipMasterSub


#Region "Local Variables"

        'LOCAL VARIABLES
        'Variables for JobDoc
        Private _SubJob As String 'max 8
        Private _MasterJob As String 'max 8
        Private _MasterAllocationLine As String 'max 2

        'Variables for Param Doc
        Private _ActionType As CommonEnums.ActionTypeEnum = CommonEnums.ActionTypeEnum.Add
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

#End Region

#Region "Public Properties"
        'Public Properties
        Public Property SubJob() As String
            Get
                Return _SubJob
            End Get
            Set(ByVal Value As String)
                _SubJob = Value
            End Set
        End Property
        Public Property MasterJob() As String
            Get
                Return _MasterJob
            End Get
            Set(ByVal Value As String)
                _MasterJob = Value
            End Set
        End Property
        Public Property MasterAllocationLine() As String
            Get
                Return _MasterAllocationLine
            End Get
            Set(ByVal Value As String)
                _MasterAllocationLine = Value
            End Set
        End Property


        'Parameter Properties
        Public Property ActionType() As CommonEnums.ActionTypeEnum
            Get
                Return _ActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _ActionType = Value
            End Set
        End Property
        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value
            End Set
        End Property
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = Value
            End Set
        End Property

#End Region


#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTSU"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/SubJob")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Public ReadOnly Property BusinessObject() As String
            Get
                Return _BusinessObject
            End Get
        End Property

        Public Property xmlOut() As String
            Get
                Return _xmlOut
            End Get
            Set(ByVal Value As String)
                _xmlOut = Value
            End Set
        End Property

        Public ReadOnly Property xmlParam() As String
            Get
                Dim sbXMLParam As New System.Text.StringBuilder

                'Build an XML string to pass parameters
                sbXMLParam.Append("<PostMasterSubJob>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ActionType>{0}</ActionType>", Left(ActionType.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostMasterSubJob>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder
                sbXMLin.Append("<PostMasterSubJob>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<SubJob>{0}</SubJob>", _SubJob)
                sbXMLin.AppendFormat("<MasterJob>{0}</MasterJob>", _MasterJob)
                If _MasterAllocationLine > "00" Then
                    sbXMLin.AppendFormat("<MasterAllocationLine>{0}</MasterAllocationLine>", _MasterAllocationLine)
                End If
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostMasterSubJob>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strActionType As CommonEnums.ActionTypeEnum, ByVal strSubJobID As String, ByVal strMasterJobID As String)
            _ActionType = strActionType
            _SubJob = strSubJobID
            _MasterJob = strMasterJobID

        End Sub

    End Class

End Namespace
