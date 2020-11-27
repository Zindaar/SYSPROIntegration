Namespace SetupObjects
    <Serializable()> Public Class InventoryWarehouse
        Implements ISetup

        Const _BusinessObject As String = "INVSWS"

#Region "Local Variables"

        Private _StockCode As String 'max 30
        Private _Warehouse As String 'max 2
        Private _CostMultiplier As Decimal = 1.0 '3.3 Positive numeric
        Private _MinimumQty As Decimal  '7.3 Positive numeric
        Private _MaximumQty As Decimal  '7.3 Positive numeric
        Private _UnitCost As Decimal  '10.5 Positive numeric
        Private _DefaultBin As String 'max 6
        Private _SafetyStockQty As Decimal  '7.3 Positive numeric
        Private _ReOrderQty As Decimal  '7.3 Positive numeric
        Private _PalletQty As Decimal  '7.3 Positive numeric
        Private _UserField1 As String  'max 1
        Private _UserField2 As String  'max 1
        Private _UserField3 As String  'max 1
        Private _TrfSuppliedItem As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No '
        Private _DefaultSourceWh As String  'max 2
        Private _TrfLeadTime As Integer 'max 3 digits
        Private _TrfCostGlCode As String  'max 15
        Private _TrfCostMultiply As Decimal  '3.3 Positive numeric
        Private _TrfReplenishWh As Integer = 0
        Private _TrfBuyingRule As CommonEnums.BuyingRuleEnum = CommonEnums.BuyingRuleEnum.A_Lot_for_lot '
        Private _TrfDockToStock As Integer  'max 3 digits
        Private _TrfFixTimePeriod As Integer  'max 2 digits

        Private _ActionType As CommonEnums.ActionTypeEnum
        Private _ApplyProductClassDefault As String
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
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
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property
        Public Property CostMultiplier() As Decimal
            Get
                Return _CostMultiplier
            End Get
            Set(ByVal Value As Decimal)
                _CostMultiplier = Value
            End Set
        End Property
        Public Property MinimumQty() As Decimal
            Get
                Return _MinimumQty
            End Get
            Set(ByVal Value As Decimal)
                _MinimumQty = Value
            End Set
        End Property
        Public Property MaximumQty() As Decimal
            Get
                Return _MaximumQty
            End Get
            Set(ByVal Value As Decimal)
                _MaximumQty = Value
            End Set
        End Property
        Public Property UnitCost() As Decimal
            Get
                Return _UnitCost
            End Get
            Set(ByVal Value As Decimal)
                _UnitCost = Value
            End Set
        End Property
        Public Property DefaultBin() As String
            Get
                Return _DefaultBin
            End Get
            Set(ByVal Value As String)
                _DefaultBin = Value
            End Set
        End Property
        Public Property SafetyStockQty() As Decimal
            Get
                Return _SafetyStockQty
            End Get
            Set(ByVal Value As Decimal)
                _SafetyStockQty = Value
            End Set
        End Property
        Public Property ReOrderQty() As Decimal
            Get
                Return _ReOrderQty
            End Get
            Set(ByVal Value As Decimal)
                _ReOrderQty = Value
            End Set
        End Property
        Public Property PalletQty() As Decimal
            Get
                Return _PalletQty
            End Get
            Set(ByVal Value As Decimal)
                _PalletQty = Value
            End Set
        End Property
        Public Property UserField1() As String
            Get
                Return _UserField1
            End Get
            Set(ByVal Value As String)
                _UserField1 = Value
            End Set
        End Property
        Public Property UserField2() As String
            Get
                Return _UserField2
            End Get
            Set(ByVal Value As String)
                _UserField2 = Value
            End Set
        End Property
        Public Property UserField3() As String
            Get
                Return _UserField3
            End Get
            Set(ByVal Value As String)
                _UserField3 = Value
            End Set
        End Property
        Public Property TrfSuppliedItem() As CommonEnums.YesNoEnum
            Get
                Return _TrfSuppliedItem
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _TrfSuppliedItem = Value
            End Set
        End Property
        Public Property DefaultSourceWh() As String
            Get
                Return _DefaultSourceWh
            End Get
            Set(ByVal Value As String)
                _DefaultSourceWh = Value
            End Set
        End Property
        Public Property TrfLeadTime() As Integer
            Get
                Return _TrfLeadTime
            End Get
            Set(ByVal Value As Integer)
                _TrfLeadTime = Value
            End Set
        End Property
        Public Property TrfCostGlCode() As String
            Get
                Return _TrfCostGlCode
            End Get
            Set(ByVal Value As String)
                _TrfCostGlCode = Value
            End Set
        End Property
        Public Property TrfCostMultiply() As Decimal
            Get
                Return _TrfCostMultiply
            End Get
            Set(ByVal Value As Decimal)
                _TrfCostMultiply = Value
            End Set
        End Property
        Public Property TrfReplenishWh() As Integer
            Get
                Return _TrfReplenishWh
            End Get
            Set(ByVal Value As Integer)
                _TrfReplenishWh = Value
            End Set
        End Property
        Public Property TrfBuyingRule() As CommonEnums.BuyingRuleEnum
            Get
                Return _TrfBuyingRule
            End Get
            Set(ByVal Value As CommonEnums.BuyingRuleEnum)
                _TrfBuyingRule = Value
            End Set
        End Property
        Public Property TrfDockToStock() As Integer
            Get
                Return _TrfDockToStock
            End Get
            Set(ByVal Value As Integer)
                _TrfDockToStock = Value
            End Set
        End Property
        Public Property TrfFixTimePeriod() As Integer
            Get
                Return _TrfFixTimePeriod
            End Get
            Set(ByVal Value As Integer)
                _TrfFixTimePeriod = Value
            End Set
        End Property

        Public Property ApplyProductClassDefault() As String
            Get
                Return _ApplyProductClassDefault
            End Get
            Set(ByVal Value As String)
                _ApplyProductClassDefault = Value
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

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        'Private _BusinessObject As String = "INVSWS"
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

        Public ReadOnly Property ConstructXML_Parameter() As String
            Get
                Dim sbXMLParam As New System.Text.StringBuilder
                sbXMLParam.Append("<SetupInvWarehouse>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ApplyProductClassDefault>{0}</ApplyProductClassDefault>", _ApplyProductClassDefault)
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(_IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(_ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(_ValidateOnly.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</SetupInvWarehouse>")

                Return sbXMLParam.ToString

            End Get
        End Property

        Public ReadOnly Property ConstructXML_Data() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder
                sbXMLin.Append("<SetupInvWarehouse>")
                sbXMLin.Append("<Item>")
                sbXMLin.Append("<Key>")
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.Append("</Key>")
                sbXMLin.AppendFormat("<CostMultiplier>{0}</CostMultiplier>", CostMultiplier)
                sbXMLin.AppendFormat("<MinimumQty >{0}</MinimumQty >", MinimumQty)
                sbXMLin.AppendFormat("<MaximumQty >{0}</MaximumQty >", MaximumQty)
                sbXMLin.AppendFormat("<UnitCost >{0}</UnitCost >", UnitCost)
                sbXMLin.AppendFormat("<DefaultBin>{0}</DefaultBin>", DefaultBin)
                sbXMLin.AppendFormat("<SafetyStockQty >{0}</SafetyStockQty >", SafetyStockQty)
                sbXMLin.AppendFormat("<ReOrderQty >{0}</ReOrderQty >", ReOrderQty)
                sbXMLin.AppendFormat("<PalletQty >{0}</PalletQty >", PalletQty)
                sbXMLin.AppendFormat("<UserField1 >{0}</UserField1 >", UserField1)
                sbXMLin.AppendFormat("<UserField2 >{0}</UserField2 >", UserField2)
                sbXMLin.AppendFormat("<UserField3 >{0}</UserField3 >", UserField3)
                sbXMLin.AppendFormat("<TrfSuppliedItem>{0}</TrfSuppliedItem>", Left(TrfSuppliedItem.ToString, 1))
                sbXMLin.AppendFormat("<DefaultSourceWh >{0}</DefaultSourceWh >", DefaultSourceWh)
                sbXMLin.AppendFormat("<TrfLeadTime>{0}</TrfLeadTime>", TrfLeadTime)
                sbXMLin.AppendFormat("<TrfCostGlCode >{0}</TrfCostGlCode >", TrfCostGlCode)
                sbXMLin.AppendFormat("<TrfCostMultiply >{0}</TrfCostMultiply >", TrfCostMultiply)
                sbXMLin.AppendFormat("<TrfReplenishWh>{0}</TrfReplenishWh>", TrfReplenishWh)
                sbXMLin.AppendFormat("<TrfBuyingRule>{0}</TrfBuyingRule>", Left(TrfBuyingRule.ToString, 1))
                sbXMLin.AppendFormat("<TrfDockToStock >{0}</TrfDockToStock >", TrfDockToStock)
                sbXMLin.AppendFormat("<TrfFixTimePeriod >{0}</TrfFixTimePeriod >", TrfFixTimePeriod)
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</SetupInvWarehouse>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

#Region "Public Object Properties"

        Public Property ActionType() As CommonEnums.ActionType_Setup Implements ISetup.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlData() As String Implements ISetup.xmlData
            Get
                Return ConstructXML_Data()
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ISetup.xmlParam
            Get
                Return ConstructXML_Parameter()
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property
#End Region

#Region "Post Method"
        Public Sub Post() Implements ISetup.Post

            Select Case _ActionType
                Case CommonEnums.ActionType_Setup.Add
                    _xmlOut = Setup.Add(Me)
                Case CommonEnums.ActionType_Setup.Delete
                    _xmlOut = Setup.Delete(Me)
                Case CommonEnums.ActionType_Setup.Update
                    _xmlOut = Setup.Update(Me)
            End Select

            'Tallbridge.SysproIntegration.Common.SysproUtilities.CheckXMLOut(Me.xmlData, Me.xmlParam, Me._xmlOut)
        End Sub
#End Region

        ''Constructor
        'Public Sub New(ByVal strActionType As CommonEnums.ActionTypeEnum)
        '    _ActionType = strActionType
        'End Sub

    End Class

End Namespace
