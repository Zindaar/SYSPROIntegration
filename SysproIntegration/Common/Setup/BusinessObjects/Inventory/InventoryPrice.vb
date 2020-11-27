Namespace SetupObjects
    <Serializable()> Public Class InventoryPrice
        Implements ISetup

#Region "Local Variables"

        Private _StockCode As String 'max 30
        Private _PriceCode As String 'max 2
        Private _SellingPrice As Decimal '12.2 positive numeric
        Private _PriceBasis As CommonEnums.PriceBasisEnum = CommonEnums.PriceBasisEnum.StockUom
        Private _CommissionCode As String 'max 2

        Private _ActionType As CommonEnums.ActionTypeEnum
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

#End Region

#Region "Properties"
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        Public Property PriceCode() As String
            Get
                Return _PriceCode
            End Get
            Set(ByVal Value As String)
                _PriceCode = Value
            End Set
        End Property
        Public Property SellingPrice() As Decimal
            Get
                Return _SellingPrice
            End Get
            Set(ByVal Value As Decimal)
                _SellingPrice = Value
            End Set
        End Property
        Public Property PriceBasis() As CommonEnums.PriceBasisEnum
            Get
                Return _PriceBasis
            End Get
            Set(ByVal Value As CommonEnums.PriceBasisEnum)
                _PriceBasis = Value
            End Set
        End Property
        Public Property CommissionCode() As String
            Get
                Return _CommissionCode
            End Get
            Set(ByVal Value As String)
                _CommissionCode = Value
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
        Public Property ValidateOnly() As CommonEnums.YesNoEnum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ValidateOnly = Value
            End Set
        End Property

#End Region

#Region " ISetup Interface "
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/StockCode")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Private _BusinessObject As String = "INVSPR"
        Public ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Private _xmlParam As String
        Public ReadOnly Property xmlParam() As String Implements ISetup.xmlParam
            Get
                Dim sbXMLParam As New System.Text.StringBuilder
                sbXMLParam.Append("<SetupInvPrice>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(_IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(_ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(_ValidateOnly.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</SetupInvPrice>")

                Return sbXMLParam.ToString

            End Get
        End Property

        Private _xmlIn As String
        Public ReadOnly Property xmlData() As String Implements ISetup.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<SetupInvPrice>")
                sbXMLin.Append("<Item>")
                sbXMLin.Append("<Key>")
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.Append("</Key>")
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<PriceCode>{0}</PriceCode>", PriceCode)
                sbXMLin.AppendFormat("<SellingPrice>{0}</SellingPrice>", SellingPrice)
                sbXMLin.AppendFormat("<PriceBasis>{0}</PriceBasis>", Left(PriceBasis.ToString, 1))
                sbXMLin.AppendFormat("<CommissionCode>{0}</CommissionCode>", CommissionCode)
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</SetupInvPrice>")

                Return sbXMLin.ToString
            End Get
        End Property

        'Constructor
        Public Sub New(ByVal strActionType As CommonEnums.ActionTypeEnum)
            _ActionType = strActionType
        End Sub

        Public Property ActionType() As CommonEnums.ActionType_Setup Implements ISetup.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                _ActionType = value
            End Set
        End Property

        Public Sub Post() Implements ISetup.Post
            Select Case _ActionType
                Case CommonEnums.ActionType_Setup.Add
                    _xmlOut = Setup.Add(Me)
                Case CommonEnums.ActionType_Setup.Delete
                    _xmlOut = Setup.Delete(Me)
                Case CommonEnums.ActionType_Setup.Update
                    _xmlOut = Setup.Update(Me)
            End Select
        End Sub

#End Region

    End Class

End Namespace
