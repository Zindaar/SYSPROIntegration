Namespace TransactionObjects
    <Serializable()> Public Class WipLabourAllocation

#Region "Local Variables"

        Private bPlannedQueueDateSpecified As Boolean = False
        Private bPlannedStartDateSpecified As Boolean = False
        Private bPlannedEndDateSpecified As Boolean = False

        'Private Local Variables
        Private _Job As String 'max 8
        Private _Operation As Integer '4 digits positive numeric
        Private _WorkCentre As String 'max 6
        Private _PlannedQueueDate As Date = Now
        Private _PlannedStartDate As Date = Now
        Private _PlannedEndDate As Date = Now
        Private _Narration As String 'max 4
        Private _WorkCentreDesc As String 'max 30
        Private _FixedElapsedTime As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ElapsedTime As Integer '3 digits positive numeric
        Private _MovementTime As Integer 'signed integer -999 to 999
        Private _UnitNumOfPieces As Integer '5 digits max
        Private _InspectionFlag As CommonEnums.InspectionEnum = CommonEnums.InspectionEnum.NoInspection
        Private _Milestone As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _MinorSetupCode As String 'max 4
        Private _MinorSetup As Decimal '5.4 positive numeric
        Private _ToolSet As String 'max 15
        Private _ToolSetQty As Decimal '7.3 positive numeric
        Private _ToolConsumption As Integer '8 digits positive numeric
        Private _QueueTime As Integer '3 digits positive numeric
        Private _Head As String 'max 3
        Private _Section1 As String 'max 3
        Private _Section2 As String 'max 3
        Private _Section3 As String 'max 3
        Private _Section4 As String 'max 3
        Private _PreviousOpMovement As Integer ' -99 to 99
        Private _NextOpQueue As Integer '3 digits positive numeric
        Private _CalculateDates As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IMachine As String 'max 6
        Private _IExpUnitRunTime As Decimal '5.4 positive numeric
        Private _IExpSetUpTime As Decimal '5.4 positive numeric
        Private _IExpStartupTime As Decimal '5.4 positive numeric
        Private _IExpShutdownTime As Decimal '5.4 positive numeric
        Private _IWaitTime As Decimal '5.4 positive numeric
        Private _IWcRateInd As Integer = 1 '1 to 9
        Private _IStartupQty As Decimal '7.3 positive numeric
        Private _OverrideCalcCap As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ICapacityReqd As Decimal '7.3 positive numeric
        Private _IMaxWorkOpertrs As Decimal = 1 '3.2 positive numeric
        Private _IMaxProdUnits As Decimal = 1 '3.2 positive numeric
        Private _SubSupplier As String 'max 7
        Private _SupPoStkCode As String 'max 30
        Private _SubQtyPer As Decimal '6.6 positive numeric
        Private _SubOrderUom As String 'max 3
        Private _SubUnitValue As Decimal '10.5 positive numeric
        Private _SubPlanner As String 'max 3
        Private _SubBuyer As String 'max 3
        Private _SubLeadTime As Integer '3 digits positive numeric
        Private _SubDockToStock As Integer '3 digits positive numeric
        Private _SubOffsiteDays As Integer '3 digits positive numeric

        'Variables for Param Doc
        Private _ActionType As CommonEnums.ActionTypeEnum = CommonEnums.ActionTypeEnum.Add 'A/C/D
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _Snapshot As CommonEnums.SnapshotEnum = CommonEnums.SnapshotEnum.No_LiveJob

#End Region

#Region "Public Properties"

        'Public Properties
        Public Property Job() As String
            Get
                Return _Job
            End Get
            Set(ByVal Value As String)
                _Job = Value
            End Set
        End Property
        Public Property Operation() As Integer
            Get
                Return _Operation
            End Get
            Set(ByVal Value As Integer)
                _Operation = Value
            End Set
        End Property
        Public Property WorkCentre() As String
            Get
                Return _WorkCentre
            End Get
            Set(ByVal Value As String)
                _WorkCentre = Value
            End Set
        End Property
        Public Property PlannedQueueDate() As Date
            Get
                Return _PlannedQueueDate
            End Get
            Set(ByVal Value As Date)
                _PlannedQueueDate = Value
                bPlannedQueueDateSpecified = True
            End Set
        End Property
        Public Property PlannedStartDate() As Date
            Get
                Return _PlannedStartDate
            End Get
            Set(ByVal Value As Date)
                _PlannedStartDate = Value
                bPlannedStartDateSpecified = True
            End Set
        End Property
        Public Property PlannedEndDate() As Date
            Get
                Return _PlannedEndDate
            End Get
            Set(ByVal Value As Date)
                _PlannedEndDate = Value
                bPlannedEndDateSpecified = True
            End Set
        End Property
        Public Property Narration() As String
            Get
                Return _Narration
            End Get
            Set(ByVal Value As String)
                _Narration = Value
            End Set
        End Property
        Public Property WorkCentreDesc() As String
            Get
                Return _WorkCentreDesc
            End Get
            Set(ByVal Value As String)
                _WorkCentreDesc = Value
            End Set
        End Property
        Public Property FixedElapsedTime() As CommonEnums.YesNoEnum
            Get
                Return _FixedElapsedTime
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _FixedElapsedTime = Value
            End Set
        End Property
        Public Property ElapsedTime() As Integer
            Get
                Return _ElapsedTime
            End Get
            Set(ByVal Value As Integer)
                _ElapsedTime = Value
            End Set
        End Property
        Public Property MovementTime() As Integer
            Get
                Return _MovementTime
            End Get
            Set(ByVal Value As Integer)
                _MovementTime = Value
            End Set
        End Property
        Public Property UnitNumOfPieces() As Integer
            Get
                Return _UnitNumOfPieces
            End Get
            Set(ByVal Value As Integer)
                _UnitNumOfPieces = Value
            End Set
        End Property
        Public Property InspectionFlag() As CommonEnums.InspectionEnum
            Get
                Return _InspectionFlag
            End Get
            Set(ByVal Value As CommonEnums.InspectionEnum)
                _InspectionFlag = Value
            End Set
        End Property
        Public Property Milestone() As CommonEnums.YesNoEnum
            Get
                Return _Milestone
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _Milestone = Value
            End Set
        End Property
        Public Property MinorSetupCode() As String
            Get
                Return _MinorSetupCode
            End Get
            Set(ByVal Value As String)
                _MinorSetupCode = Value
            End Set
        End Property
        Public Property MinorSetup() As Decimal
            Get
                Return _MinorSetup
            End Get
            Set(ByVal Value As Decimal)
                _MinorSetup = Value
            End Set
        End Property
        Public Property ToolSet() As String
            Get
                Return _ToolSet
            End Get
            Set(ByVal Value As String)
                _ToolSet = Value
            End Set
        End Property
        Public Property ToolSetQty() As Decimal
            Get
                Return _ToolSetQty
            End Get
            Set(ByVal Value As Decimal)
                _ToolSetQty = Value
            End Set
        End Property
        Public Property ToolConsumption() As Integer
            Get
                Return _ToolConsumption
            End Get
            Set(ByVal Value As Integer)
                _ToolConsumption = Value
            End Set
        End Property
        Public Property QueueTime() As Integer
            Get
                Return _QueueTime
            End Get
            Set(ByVal Value As Integer)
                _QueueTime = Value
            End Set
        End Property
        Public Property Head() As String
            Get
                Return _Head
            End Get
            Set(ByVal Value As String)
                _Head = Value
            End Set
        End Property
        Public Property Section1() As String
            Get
                Return _Section1
            End Get
            Set(ByVal Value As String)
                _Section1 = Value
            End Set
        End Property
        Public Property Section2() As String
            Get
                Return _Section2
            End Get
            Set(ByVal Value As String)
                _Section2 = Value
            End Set
        End Property
        Public Property Section3() As String
            Get
                Return _Section3
            End Get
            Set(ByVal Value As String)
                _Section3 = Value
            End Set
        End Property
        Public Property Section4() As String
            Get
                Return _Section4
            End Get
            Set(ByVal Value As String)
                _Section4 = Value
            End Set
        End Property
        Public Property PreviousOpMovement() As Integer
            Get
                Return _PreviousOpMovement
            End Get
            Set(ByVal Value As Integer)
                _PreviousOpMovement = Value
            End Set
        End Property
        Public Property NextOpQueue() As Integer
            Get
                Return _NextOpQueue
            End Get
            Set(ByVal Value As Integer)
                _NextOpQueue = Value
            End Set
        End Property
        Public Property CalculateDates() As CommonEnums.YesNoEnum
            Get
                Return _CalculateDates
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CalculateDates = Value
            End Set
        End Property
        Public Property IMachine() As String
            Get
                Return _IMachine
            End Get
            Set(ByVal Value As String)
                _IMachine = Value
            End Set
        End Property
        Public Property IExpUnitRunTime() As Decimal
            Get
                Return _IExpUnitRunTime
            End Get
            Set(ByVal Value As Decimal)
                _IExpUnitRunTime = Value
            End Set
        End Property
        Public Property IExpSetUpTime() As Decimal
            Get
                Return _IExpSetUpTime
            End Get
            Set(ByVal Value As Decimal)
                _IExpSetUpTime = Value
            End Set
        End Property
        Public Property IExpStartupTime() As Decimal
            Get
                Return _IExpStartupTime
            End Get
            Set(ByVal Value As Decimal)
                _IExpStartupTime = Value
            End Set
        End Property
        Public Property IExpShutdownTime() As Decimal
            Get
                Return _IExpShutdownTime
            End Get
            Set(ByVal Value As Decimal)
                _IExpShutdownTime = Value
            End Set
        End Property
        Public Property IWaitTime() As Decimal
            Get
                Return _IWaitTime
            End Get
            Set(ByVal Value As Decimal)
                _IWaitTime = Value
            End Set
        End Property
        Public Property IWcRateInd() As Integer
            Get
                Return _IWcRateInd
            End Get
            Set(ByVal Value As Integer)
                _IWcRateInd = Value
            End Set
        End Property
        Public Property IStartupQty() As Decimal
            Get
                Return _IStartupQty
            End Get
            Set(ByVal Value As Decimal)
                _IStartupQty = Value
            End Set
        End Property
        Public Property OverrideCalcCap() As CommonEnums.YesNoEnum
            Get
                Return _OverrideCalcCap
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _OverrideCalcCap = Value
            End Set
        End Property
        Public Property ICapacityReqd() As Decimal
            Get
                Return _ICapacityReqd
            End Get
            Set(ByVal Value As Decimal)
                _ICapacityReqd = Value
            End Set
        End Property
        Public Property IMaxWorkOpertrs() As Decimal
            Get
                Return _IMaxWorkOpertrs
            End Get
            Set(ByVal Value As Decimal)
                _IMaxWorkOpertrs = Value
            End Set
        End Property
        Public Property IMaxProdUnits() As Decimal
            Get
                Return _IMaxProdUnits
            End Get
            Set(ByVal Value As Decimal)
                _IMaxProdUnits = Value
            End Set
        End Property
        Public Property SubSupplier() As String
            Get
                Return _SubSupplier
            End Get
            Set(ByVal Value As String)
                _SubSupplier = Value
            End Set
        End Property
        Public Property SupPoStkCode() As String
            Get
                Return _SupPoStkCode
            End Get
            Set(ByVal Value As String)
                _SupPoStkCode = Value
            End Set
        End Property
        Public Property SubQtyPer() As Decimal
            Get
                Return _SubQtyPer
            End Get
            Set(ByVal Value As Decimal)
                _SubQtyPer = Value
            End Set
        End Property
        Public Property SubOrderUom() As String
            Get
                Return _SubOrderUom
            End Get
            Set(ByVal Value As String)
                _SubOrderUom = Value
            End Set
        End Property
        Public Property SubUnitValue() As Decimal
            Get
                Return _SubUnitValue
            End Get
            Set(ByVal Value As Decimal)
                _SubUnitValue = Value
            End Set
        End Property
        Public Property SubPlanner() As String
            Get
                Return _SubPlanner
            End Get
            Set(ByVal Value As String)
                _SubPlanner = Value
            End Set
        End Property
        Public Property SubBuyer() As String
            Get
                Return _SubBuyer
            End Get
            Set(ByVal Value As String)
                _SubBuyer = Value
            End Set
        End Property
        Public Property SubLeadTime() As Integer
            Get
                Return _SubLeadTime
            End Get
            Set(ByVal Value As Integer)
                _SubLeadTime = Value
            End Set
        End Property
        Public Property SubDockToStock() As Integer
            Get
                Return _SubDockToStock
            End Get
            Set(ByVal Value As Integer)
                _SubDockToStock = Value
            End Set
        End Property
        Public Property SubOffsiteDays() As Integer
            Get
                Return _SubOffsiteDays
            End Get
            Set(ByVal Value As Integer)
                _SubOffsiteDays = Value
            End Set
        End Property


        'xmlParam Properties
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
        Public Property Snapshot() As CommonEnums.SnapshotEnum
            Get
                Return _Snapshot
            End Get
            Set(ByVal Value As CommonEnums.SnapshotEnum)
                _Snapshot = Value
            End Set
        End Property

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTJL"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/Operation")
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

                sbXMLParam.Append("<PostLabourAllocations>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ActionType>{0}</ActionType>", Left(ActionType.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<Snapshot>{0}</Snapshot>", Left(Snapshot.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostLabourAllocations>")

                Return sbXMLParam.ToString

            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostLabourAllocations>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<Operation>{0}</Operation>", Operation)
                sbXMLin.AppendFormat("<WorkCentre>{0}</WorkCentre>", WorkCentre)
                If bPlannedQueueDateSpecified Then
                    sbXMLin.AppendFormat("<PlannedQueueDate>{0}</PlannedQueueDate>", Format(PlannedQueueDate, "yyyy-MM-dd"))
                Else
                    sbXMLin.AppendFormat("<PlannedQueueDate />")
                End If
                If bPlannedStartDateSpecified Then
                    sbXMLin.AppendFormat("<PlannedStartDate>{0}</PlannedStartDate>", Format(PlannedStartDate, "yyyy-MM-dd"))
                Else
                    sbXMLin.AppendFormat("<PlannedStartDate />")
                End If
                If bPlannedEndDateSpecified Then
                    sbXMLin.AppendFormat("<PlannedEndDate>{0}</PlannedEndDate>", Format(PlannedEndDate, "yyyy-MM-dd"))
                Else
                    sbXMLin.AppendFormat("<PlannedEndDate />")
                End If
                sbXMLin.AppendFormat("<Narration>{0}</Narration>", Narration)
                sbXMLin.AppendFormat("<WorkCentreDesc>{0}</WorkCentreDesc>", WorkCentreDesc)
                sbXMLin.AppendFormat("<FixedElapsedTime>{0}</FixedElapsedTime>", Left(FixedElapsedTime.ToString, 1))
                sbXMLin.AppendFormat("<ElapsedTime>{0}</ElapsedTime>", ElapsedTime)
                sbXMLin.AppendFormat("<MovementTime>{0}</MovementTime>", MovementTime)
                sbXMLin.AppendFormat("<UnitNumOfPieces>{0}</UnitNumOfPieces>", UnitNumOfPieces)
                sbXMLin.AppendFormat("<InspectionFlag>{0}</InspectionFlag>", Left(InspectionFlag.ToString, 1))
                sbXMLin.AppendFormat("<Milestone>{0}</Milestone>", Left(Milestone.ToString, 1))
                sbXMLin.AppendFormat("<MinorSetupCode>{0}</MinorSetupCode>", MinorSetupCode)
                sbXMLin.AppendFormat("<MinorSetup>{0}</MinorSetup>", MinorSetup)
                sbXMLin.AppendFormat("<ToolSet>{0}</ToolSet>", ToolSet)
                sbXMLin.AppendFormat("<ToolSetQty>{0}</ToolSetQty>", ToolSetQty)
                sbXMLin.AppendFormat("<ToolConsumption>{0}</ToolConsumption>", ToolConsumption)
                sbXMLin.AppendFormat("<QueueTime>{0}</QueueTime>", QueueTime)
                sbXMLin.Append("<HierarchyJob>")
                sbXMLin.AppendFormat("<Head>{0}</Head>", Head)
                sbXMLin.AppendFormat("<Section1>{0}</Section1>", Section1)
                sbXMLin.AppendFormat("<Section2>{0}</Section2>", Section2)
                sbXMLin.AppendFormat("<Section3>{0}</Section3>", Section3)
                sbXMLin.AppendFormat("<Section4>{0}</Section4>", Section4)
                sbXMLin.Append("</HierarchyJob>")
                sbXMLin.AppendFormat("<PreviousOpMovement>{0}</PreviousOpMovement>", PreviousOpMovement)
                sbXMLin.AppendFormat("<NextOpQueue>{0}</NextOpQueue>", NextOpQueue)
                sbXMLin.AppendFormat("<CalculateDates>{0}</CalculateDates>", Left(CalculateDates.ToString, 1))
                sbXMLin.AppendFormat("<IMachine>{0}</IMachine>", IMachine)
                sbXMLin.AppendFormat("<IExpUnitRunTim>{0}</IExpUnitRunTim>", Format(IExpUnitRunTime, "#####.####"))
                sbXMLin.AppendFormat("<IExpSetUpTime>{0}</IExpSetUpTime>", IExpSetUpTime)
                sbXMLin.AppendFormat("<IExpStartupTime>{0}</IExpStartupTime>", IExpStartupTime)
                sbXMLin.AppendFormat("<IExpShutdownTim>{0}</IExpShutdownTim>", IExpShutdownTime)
                sbXMLin.AppendFormat("<IWaitTime>{0}</IWaitTime>", IWaitTime)
                sbXMLin.AppendFormat("<IWcRateInd>{0}</IWcRateInd>", IWcRateInd)
                sbXMLin.AppendFormat("<IStartupQty>{0}</IStartupQty>", IStartupQty)
                sbXMLin.AppendFormat("<OverrideCalcCap>{0}</OverrideCalcCap>", Left(OverrideCalcCap.ToString, 1))
                sbXMLin.AppendFormat("<ICapacityReqd>{0}</ICapacityReqd>", ICapacityReqd)
                sbXMLin.AppendFormat("<IMaxWorkOpertrs>{0}</IMaxWorkOpertrs>", IMaxWorkOpertrs)
                sbXMLin.AppendFormat("<IMaxProdUnits>{0}</IMaxProdUnits>", IMaxProdUnits)
                sbXMLin.AppendFormat("<SubSupplier>{0}</SubSupplier>", SubSupplier)
                sbXMLin.AppendFormat("<SupPoStkCode>{0}</SupPoStkCode>", SupPoStkCode)
                sbXMLin.AppendFormat("<SubQtyPer>{0}</SubQtyPer>", SubQtyPer)
                sbXMLin.AppendFormat("<SubOrderUom>{0}</SubOrderUom>", SubOrderUom)
                sbXMLin.AppendFormat("<SubUnitValue>{0}</SubUnitValue>", SubUnitValue)
                sbXMLin.AppendFormat("<SubPlanner>{0}</SubPlanner>", SubPlanner)
                sbXMLin.AppendFormat("<SubBuyer>{0}</SubBuyer>", SubBuyer)
                sbXMLin.AppendFormat("<SubLeadTime>{0}</SubLeadTime>", SubLeadTime)
                sbXMLin.AppendFormat("<SubDockToStock>{0}</SubDockToStock>", SubDockToStock)
                sbXMLin.AppendFormat("<SubOffsiteDays>{0}</SubOffsiteDays>", IIf(SubOffsiteDays = 0, 1, SubOffsiteDays))
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostLabourAllocations>")

                Return sbXMLin.ToString

            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strActionType As CommonEnums.ActionTypeEnum, ByVal strJobID As String)
            _ActionType = strActionType
            _Job = strJobID

        End Sub

    End Class

End Namespace
