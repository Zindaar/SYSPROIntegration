Namespace TransactionObjects
    <Serializable()> Public Class WipLabour

#Region "Local Variables"
        'Local Variables
        Private _Journal As Integer 'max 5 digits
        Private _Job As String 'max 8
        Private _LOperation As Integer 'max 9999
        Private _LWorkCentre As String 'max 6
        Private _LWcRateInd As Integer = 1 '0 to 9
        Private _LEmployee As Integer '0 to 999999
        Private _LMachine As String 'max 6
        Private _LRunTimeHours As Decimal '5.2 signed decimal
        Private _LSetUpHours As Decimal '5.2 signed decimal
        Private _LStartupHours As Decimal '5.2 signed decimal
        Private _LTeardownHours As Decimal '5.2 signed decimal
        Private _NonProductiveCode As String 'max 2
        Private _ScrapCode As String 'max 2
        Private _LQtyComplete As Decimal '7.3 signed decimal
        Private _LQtyScrapped As Decimal '7.3 signed decimal
        Private _PiecesCompleted As Integer 'max 8 digits
        Private _OperCompleted As CommonEnums.YesNoEnum
        Private _LEmployeeRatInd As Integer '0 to 9
        Private _SubcontractValue As Decimal '12.2 signed decimal

        'Variables for Param Doc
        Private _TransactionDate As Date = Now()
        Private _PostingPeriod As CommonEnums.PostingPeriodEnum = CommonEnums.PostingPeriodEnum.Current
        Private _PasswordForPreviousPeriod As String 'max 4
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _UncompleteNonMile As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes

#End Region

#Region "Public Variables"
        'Public Properties
        Public Property Journal() As Integer
            Get
                Return _Journal
            End Get
            Set(ByVal Value As Integer)
                _Journal = Value
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
        Public Property LOperation() As Integer
            Get
                Return _LOperation
            End Get
            Set(ByVal Value As Integer)
                _LOperation = Value
            End Set
        End Property
        Public Property LWorkCentre() As String
            Get
                Return _LWorkCentre
            End Get
            Set(ByVal Value As String)
                _LWorkCentre = Value
            End Set
        End Property
        Public Property LWcRateInd() As Integer
            Get
                Return _LWcRateInd
            End Get
            Set(ByVal Value As Integer)
                _LWcRateInd = Value
            End Set
        End Property
        Public Property LEmployee() As Integer
            Get
                Return _LEmployee
            End Get
            Set(ByVal Value As Integer)
                _LEmployee = Value
            End Set
        End Property
        Public Property LMachine() As String
            Get
                Return _LMachine
            End Get
            Set(ByVal Value As String)
                _LMachine = Value
            End Set
        End Property
        Public Property LRunTimeHours() As Decimal
            Get
                Return _LRunTimeHours
            End Get
            Set(ByVal Value As Decimal)
                _LRunTimeHours = Value
            End Set
        End Property
        Public Property LSetUpHours() As Decimal
            Get
                Return _LSetUpHours
            End Get
            Set(ByVal Value As Decimal)
                _LSetUpHours = Value
            End Set
        End Property
        Public Property LStartupHours() As Decimal
            Get
                Return _LStartupHours
            End Get
            Set(ByVal Value As Decimal)
                _LStartupHours = Value
            End Set
        End Property
        Public Property LTeardownHours() As Decimal
            Get
                Return _LTeardownHours
            End Get
            Set(ByVal Value As Decimal)
                _LTeardownHours = Value
            End Set
        End Property
        Public Property NonProductiveCode() As String
            Get
                Return _NonProductiveCode
            End Get
            Set(ByVal Value As String)
                _NonProductiveCode = Value
            End Set
        End Property
        Public Property ScrapCode() As String
            Get
                Return _ScrapCode
            End Get
            Set(ByVal Value As String)
                _ScrapCode = Value
            End Set
        End Property
        Public Property LQtyComplete() As Decimal
            Get
                Return _LQtyComplete
            End Get
            Set(ByVal Value As Decimal)
                _LQtyComplete = Value
            End Set
        End Property
        Public Property LQtyScrapped() As Decimal
            Get
                Return _LQtyScrapped
            End Get
            Set(ByVal Value As Decimal)
                _LQtyScrapped = Value
            End Set
        End Property
        Public Property PiecesCompleted() As Integer
            Get
                Return _PiecesCompleted
            End Get
            Set(ByVal Value As Integer)
                _PiecesCompleted = Value
            End Set
        End Property
        Public Property OperCompleted() As CommonEnums.YesNoEnum
            Get
                Return _OperCompleted
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _OperCompleted = Value
            End Set
        End Property
        Public Property LEmployeeRatInd() As Integer
            Get
                Return _LEmployeeRatInd
            End Get
            Set(ByVal Value As Integer)
                _LEmployeeRatInd = Value
            End Set
        End Property
        Public Property SubcontractValue() As Decimal
            Get
                Return _SubcontractValue
            End Get
            Set(ByVal Value As Decimal)
                _SubcontractValue = Value
            End Set
        End Property

        'xmlParam Properties
        Public Property TransactionDate() As Date
            Get
                Return _TransactionDate
            End Get
            Set(ByVal Value As Date)
                _TransactionDate = Value
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
        Public Property PasswordForPreviousPeriod() As String
            Get
                Return _PasswordForPreviousPeriod
            End Get
            Set(ByVal Value As String)
                _PasswordForPreviousPeriod = Value
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
        Public Property UncompleteNonMile() As CommonEnums.YesNoEnum
            Get
                Return _UncompleteNonMile
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _UncompleteNonMile = Value
            End Set
        End Property

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTLP"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/Journal")
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

        Public ReadOnly Property xlmParam() As String
            Get
                Dim sbXMLParam As New System.Text.StringBuilder
                sbXMLParam.Append("<PostLabour>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<TransactionDate>{0}</TransactionDate>", Format(TransactionDate, "yyyy-MM-dd"))
                sbXMLParam.AppendFormat("<PostingPeriod>{0}</PostingPeriod>", Left(PostingPeriod.ToString, 1))
                sbXMLParam.AppendFormat("<PasswordForPreviousPeriod>{0}</PasswordForPreviousPeriod>", PasswordForPreviousPeriod)
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<UncompleteNonMile>{0}</UncompleteNonMile>", Left(UncompleteNonMile.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostLabour>")
                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostLabour>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Journal>{0}</Journal>", Journal)
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<LOperation>{0}</LOperation>", LOperation)
                sbXMLin.AppendFormat("<LWorkCentre>{0}</LWorkCentre>", LWorkCentre)
                sbXMLin.AppendFormat("<LWcRateInd>{0}</LWcRateInd>", LWcRateInd)
                sbXMLin.AppendFormat("<LEmployee>{0}</LEmployee>", LEmployee)
                sbXMLin.AppendFormat("<LMachine>{0}</LMachine>", LMachine)
                sbXMLin.AppendFormat("<LRunTimeHours>{0}</LRunTimeHours>", LRunTimeHours)
                sbXMLin.AppendFormat("<LSetUpHours>{0}</LSetUpHours>", LSetUpHours)
                sbXMLin.AppendFormat("<LStartupHours>{0}</LStartupHours>", LStartupHours)
                sbXMLin.AppendFormat("<LTeardownHours>{0}</LTeardownHours>", LTeardownHours)
                sbXMLin.AppendFormat("<NonProductiveCode>{0}</NonProductiveCode>", NonProductiveCode)
                sbXMLin.AppendFormat("<ScrapCode>{0}</ScrapCode>", ScrapCode)
                sbXMLin.AppendFormat("<LQtyComplete>{0}</LQtyComplete>", LQtyComplete)
                sbXMLin.AppendFormat("<LQtyScrapped>{0}</LQtyScrapped>", LQtyScrapped)
                sbXMLin.AppendFormat("<PiecesCompleted>{0}</PiecesCompleted>", PiecesCompleted)
                sbXMLin.AppendFormat("<OperCompleted>{0}</OperCompleted>", Left(OperCompleted.ToString, 1))
                sbXMLin.AppendFormat("<LEmployeeRatInd>{0}</LEmployeeRatInd>", LEmployeeRatInd)
                sbXMLin.AppendFormat("<SubcontractValue>{0}</SubcontractValue>", SubcontractValue)
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostLabour>")

                Return sbXMLin.ToString
            End Get
        End Property


        Public Function xmlData() As String
            Dim outputdoc As New Xml.XmlDocument
            Dim postlabourkey As Xml.XmlElement = outputdoc.CreateElement("PostLabour")
            Dim itemkey As Xml.XmlElement = outputdoc.CreateElement("Item")
            Dim journalkey As Xml.XmlElement = outputdoc.CreateElement("Journal")
            Dim jobkey As Xml.XmlElement = outputdoc.CreateElement("Job")
            Dim loperationkey As Xml.XmlElement = outputdoc.CreateElement("LOperation")
            Dim lworkcentrekey As Xml.XmlElement = outputdoc.CreateElement("LWorkCentre")
            Dim lwcrateindkey As Xml.XmlElement = outputdoc.CreateElement("LWcRateInd")
            Dim lemployeekey As Xml.XmlElement = outputdoc.CreateElement("LEmployee")
            Dim lmachinekey As Xml.XmlElement = outputdoc.CreateElement("LMachine")
            Dim lruntimehourskey As Xml.XmlElement = outputdoc.CreateElement("LRunTimeHours")
            Dim lsetuphourskey As Xml.XmlElement = outputdoc.CreateElement("LSetUpHours")
            Dim lstartuphourskey As Xml.XmlElement = outputdoc.CreateElement("LStartupHours")
            Dim lteardownhourskey As Xml.XmlElement = outputdoc.CreateElement("LTeardownHours")
            Dim nonproductivecodekey As Xml.XmlElement = outputdoc.CreateElement("NonProductiveCode")
            Dim scrapcodekey As Xml.XmlElement = outputdoc.CreateElement("ScrapCode")
            Dim lqtycompletekey As Xml.XmlElement = outputdoc.CreateElement("LQtyComplete")
            Dim lqtyscrappedkey As Xml.XmlElement = outputdoc.CreateElement("LQtyScrapped")
            Dim lpiecescompletedkey As Xml.XmlElement = outputdoc.CreateElement("PiecesCompleted")
            Dim opercompletedkey As Xml.XmlElement = outputdoc.CreateElement("OperCompleted")
            Dim lemployeerateindkey As Xml.XmlElement = outputdoc.CreateElement("LEmployeeRatInd")
            Dim subcontractvaluekey As Xml.XmlElement = outputdoc.CreateElement("SubcontractValue")

            'Set the values of the elements
            journalkey.Value = ""

            outputdoc.CreateXmlDeclaration("1.0", "Windows-1252", "")
            With itemkey
                .AppendChild(jobkey)
                .AppendChild(loperationkey)
                .AppendChild(lworkcentrekey)
                .AppendChild(lwcrateindkey)
                .AppendChild(lemployeekey)
                .AppendChild(lmachinekey)
                .AppendChild(lruntimehourskey)
                .AppendChild(lsetuphourskey)
                .AppendChild(lstartuphourskey)
                .AppendChild(lteardownhourskey)
                .AppendChild(nonproductivecodekey)
                .AppendChild(scrapcodekey)
                .AppendChild(lqtycompletekey)
                .AppendChild(lqtyscrappedkey)
                .AppendChild(lpiecescompletedkey)
                .AppendChild(opercompletedkey)
                .AppendChild(lemployeerateindkey)
                .AppendChild(subcontractvaluekey)
            End With
            postlabourkey.AppendChild(itemkey)
            outputdoc.AppendChild(postlabourkey)

            ' Right, now we have the xml string to put into the business object.
            Return outputdoc.InnerXml

        End Function

#End Region

        'Constructor
        Public Sub New(ByVal strJobID As String)
            _Job = strJobID
        End Sub

    End Class

End Namespace
