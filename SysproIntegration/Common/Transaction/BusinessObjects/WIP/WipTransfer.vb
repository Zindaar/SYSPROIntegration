Namespace TransactionObjects
    <Serializable()> Public Class WipTransfer

        Private _blnCostBasisSpecified As Boolean = False
        Private _blnLotStuffSpecified As Boolean = False

#Region "Local Variables"
        Private _PartBillingJournal As Integer 'max 5 digits
        Private _InventoryJournal As Integer 'max 5 digits
        Private _Job As String 'max 8
        Private _Quantity As Decimal '7.3 signed numeric
        Private _JobComplete As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _CloseDate As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ProductClass As String 'max 4
        Private _WipValueBasis As CommonEnums.WipValueBasisEnum = CommonEnums.WipValueBasisEnum.ActualCost
        Private _MaterialValue As Decimal '12.2 signed decimal
        Private _LaborValue As Decimal '12.2 signed decimal
        Private _CostBasis As CommonEnums.QtyReqdTypeEnum
        Private _Lot As String 'max 10
        Private _LotConcession As String 'max 10
        Private _LotCertificate As String 'max 10
        Private _Reference As String 'max 9
        Private _Notation As String 'max 45

        'Variables for Param Doc
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _PasswordForPostingToCompletedJob As String 'max 4
        Private _TransactionDate As Date
        Private _NonStockedWhToUse As String

#End Region

#Region "Public Properties"
        Public Property NonStockedWhToUse() As String
            Get
                Return _NonStockedWhToUse
            End Get
            Set(ByVal Value As String)
                _NonStockedWhToUse = Value
            End Set
        End Property
        Public Property PartBillingJournal() As Integer
            Get
                Return _PartBillingJournal
            End Get
            Set(ByVal Value As Integer)
                _PartBillingJournal = Value
            End Set
        End Property
        Public Property InventoryJournal() As Integer
            Get
                Return _InventoryJournal
            End Get
            Set(ByVal Value As Integer)
                _InventoryJournal = Value
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
        Public Property Quantity() As Decimal
            Get
                Return _Quantity
            End Get
            Set(ByVal Value As Decimal)
                _Quantity = Value
            End Set
        End Property
        Public Property JobComplete() As CommonEnums.YesNoEnum
            Get
                Return _JobComplete
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _JobComplete = Value
            End Set
        End Property
        Public Property CloseDate() As CommonEnums.YesNoEnum
            Get
                Return _CloseDate
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CloseDate = Value
            End Set
        End Property
        Public Property ProductClass() As String
            Get
                Return _ProductClass
            End Get
            Set(ByVal Value As String)
                _ProductClass = Value
            End Set
        End Property
        Public Property WipValueBasis() As CommonEnums.WipValueBasisEnum
            Get
                Return _WipValueBasis
            End Get
            Set(ByVal Value As CommonEnums.WipValueBasisEnum)
                _WipValueBasis = Value
            End Set
        End Property
        Public Property MaterialValue() As Decimal
            Get
                Return _MaterialValue
            End Get
            Set(ByVal Value As Decimal)
                _MaterialValue = Value
            End Set
        End Property
        Public Property LaborValue() As Decimal
            Get
                Return _LaborValue
            End Get
            Set(ByVal Value As Decimal)
                _LaborValue = Value
            End Set
        End Property
        Public Property CostBasis() As CommonEnums.QtyReqdTypeEnum
            Get
                Return _CostBasis
            End Get
            Set(ByVal Value As CommonEnums.QtyReqdTypeEnum)
                _CostBasis = Value
                _blnCostBasisSpecified = True
            End Set
        End Property
        Public Property Lot() As String
            Get
                Return _Lot
            End Get
            Set(ByVal Value As String)
                _Lot = Value
                _blnLotStuffSpecified = True
            End Set
        End Property
        Public Property LotConcession() As String
            Get
                Return _LotConcession
            End Get
            Set(ByVal Value As String)
                _LotConcession = Value
                _blnLotStuffSpecified = True
            End Set
        End Property
        Public Property LotCertificate() As String
            Get
                Return _LotCertificate
            End Get
            Set(ByVal Value As String)
                _LotCertificate = Value
                _blnLotStuffSpecified = True
            End Set
        End Property
        Public Property Reference() As String
            Get
                Return _Reference
            End Get
            Set(ByVal Value As String)
                _Reference = Value
            End Set
        End Property
        Public Property Notation() As String
            Get
                Return _Notation
            End Get
            Set(ByVal Value As String)
                _Notation = Value
            End Set
        End Property


        'Parameter Properties
        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value
            End Set
        End Property
        Public Property ApplyIfEntireDocumentValid() As CommonEnums.YesNoEnum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ApplyIfEntireDocumentValid = Value
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
        Public Property PasswordForPostingToCompletedJob() As String
            Get
                Return _PasswordForPostingToCompletedJob
            End Get
            Set(ByVal Value As String)
                _PasswordForPostingToCompletedJob = Value
            End Set
        End Property
        Public Property TransactionDate() As Date
            Get
                Return _TransactionDate
            End Get
            Set(ByVal Value As Date)
                _TransactionDate = Value
            End Set
        End Property

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTWT"
        Private _ProcessedElement As String


        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("ItemsProcessed")
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

                sbXMLParam.Append("<PostWipTransfer>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<PasswordForPostingToCompletedJob>{0}</PasswordForPostingToCompletedJob>", PasswordForPostingToCompletedJob)
                sbXMLParam.AppendFormat("<TransactionDate>{0}</TransactionDate>", Format(TransactionDate, "yyyy-MM-dd"))
                sbXMLParam.AppendFormat("<NonStockedWhToUse>{0}</NonStockedWhToUse>", NonStockedWhToUse)
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostWipTransfer>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostWipTransfer>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<PartBillingJournal>{0}</PartBillingJournal>", PartBillingJournal)
                sbXMLin.AppendFormat("<InventoryJournal>{0}</InventoryJournal>", InventoryJournal)
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<Quantity>{0}</Quantity>", Quantity)
                sbXMLin.AppendFormat("<JobComplete>{0}</JobComplete>", Left(JobComplete.ToString, 1))
                sbXMLin.AppendFormat("<CloseDate>{0}</CloseDate>", Left(CloseDate.ToString, 1))
                sbXMLin.AppendFormat("<ProductClass>{0}</ProductClass>", ProductClass)
                sbXMLin.AppendFormat("<WipValueBasis>{0}</WipValueBasis>", Left(WipValueBasis.ToString, 1))
                If MaterialValue = 0 Then
                    sbXMLin.Append("<MaterialValue/>")
                Else
                    sbXMLin.AppendFormat("<MaterialValue>{0}</MaterialValue>", MaterialValue)
                End If
                If LaborValue = 0 Then
                    sbXMLin.Append("<LaborValue/>")
                Else
                    sbXMLin.AppendFormat("<LaborValue>{0}</LaborValue>", LaborValue)
                End If
                If _blnCostBasisSpecified Then
                    sbXMLin.AppendFormat("<CostBasis>{0}</CostBasis>", Left(CostBasis.ToString, 1))
                Else
                    sbXMLin.Append("<CostBasis/>")
                End If
                If _blnLotStuffSpecified Then
                    sbXMLin.AppendFormat("<Lot>{0}</Lot>", Lot)
                    sbXMLin.AppendFormat("<LotConcession>{0}</LotConcession>", LotConcession)
                    sbXMLin.AppendFormat("<LotCertificate>{0}</LotCertificate>", LotCertificate)
                Else
                    sbXMLin.Append("<Lot/>")
                    sbXMLin.Append("<LotConcession/>")
                    sbXMLin.Append("<LotCertificate/>")
                End If
                sbXMLin.AppendFormat("<Reference>{0}</Reference>", Reference)
                sbXMLin.AppendFormat("<Notation>{0}</Notation>", Notation)
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostWipTransfer>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strJobID As String)
            _Job = strJobID
        End Sub

    End Class

End Namespace
