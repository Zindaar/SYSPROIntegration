Namespace TransactionObjects
    ''' <summary>
    '''     Use this object to create/maintain a WIP Job in Syspro
    ''' </summary>
    ''' <remarks>
    '''     These are remarks
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	20/04/2005	Created
    ''' </history>
    <Serializable()> Public Class WipJob
        Implements ITransaction


#Region "Local Variables"

        'LOCAL VARIABLES
        'Variables for JobDoc
        Private _Job As String 'max 8
        Private _JobDescription As String 'max 30
        Private _JobClassification As String 'max 4
        Private _Priority As Integer '1(lowest) to 99 (highest)
        Private _StockCode As String 'max 30
        Private _Version As String 'max 3
        Private _Release As String 'max 3
        Private _Warehouse As String 'max 2
        Private _QtyToMake As Decimal '7.3 Positive Numeric
        Private _Customer As String 'max 7
        Private _CustomerName As String 'max 30
        Private _JobTenderDate As Date = Date.Now 'yyyy-mm-dd
        Private _DateCalcMethod As CommonEnums.DateCalcMethodEnum = CommonEnums.DateCalcMethodEnum.Manual
        Private _IncludeOvertimePct As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _SetMethodToManual As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _JobStartDate As Date = Date.Now 'yyyy-mm-dd
        Private _JobDeliveryDate As Date = Date.Now 'yyyy-mm-dd
        Private _SeqCheckReq As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ConfirmedFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _HoldFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _Route As Integer '0 to 9
        Private _RoutePassword As String 'no max defined
        Private _WipCtlGlCode As String 'max 15
        Private _NonStocked As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _StockDescription As String 'max 30
        Private _ExpLabour As Decimal '10.5 numeric
        Private _ExpMaterial As Decimal '10.5 numeric
        Private _SellingPrice As Decimal '10.5 Positive Numeric
        Private _AddLabPct As Decimal '3.2 Positive Numeric
        Private _AddMatPct As Decimal '3.2 Positive Numeric
        Private _ProfitPct As Decimal '3.2 Positive Numeric
        Private _TraceableType As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _HierarchyFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _HierarchyContract As String 'max 20
        Private _HierarchyCode As String 'max 8
        Private _SalesOrder As String 'max 6
        Private _SalesOrderLine As Integer '0 to 9999
        Private _IncludeAllocations As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ComponentWarehouse As String 'Max 2
        Private _CreateSubJobs As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _SubJobPrefix As String 'max 5
        Private _SubJobSuffix As String 'max 8
        Private _UseGlForAllJobs As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _CheckLeadTime As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ReCalculateJobDates As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ChangeSalesOrderWarehouse As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

        'Variables for Param Doc
        Private _JobActionType As CommonEnums.ActionTypeEnum = CommonEnums.ActionTypeEnum.Add
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _Snapshot As CommonEnums.SnapshotEnum = CommonEnums.SnapshotEnum.No_LiveJob

#End Region

#Region "Public Properties"
        'Public Properties
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        '''   This is the Job Number for the job.  It is limited to 8 characters,
        '''     numeric or alphanumeric dependent on the numbering setup in Syspro.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Job() As String
            Get
                Return _Job
            End Get
            Set(ByVal Value As String)
                _Job = Value
            End Set
        End Property
        Public Property JobDescription() As String
            Get
                Return _JobDescription
            End Get
            Set(ByVal Value As String)
                _JobDescription = Value
            End Set
        End Property
        Public Property JobClassification() As String
            Get
                Return _JobClassification
            End Get
            Set(ByVal Value As String)
                _JobClassification = Value
            End Set
        End Property
        Public Property Priority() As Integer
            Get
                Return _Priority
            End Get
            Set(ByVal Value As Integer)
                _Priority = Value
            End Set
        End Property
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal Value As String)
                _Version = Value
            End Set
        End Property
        Public Property Release() As String
            Get
                Return _Release
            End Get
            Set(ByVal Value As String)
                _Release = Value
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
        Public Property QtyToMake() As Decimal
            Get
                Return _QtyToMake
            End Get
            Set(ByVal Value As Decimal)
                _QtyToMake = Value
            End Set
        End Property
        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal Value As String)
                _Customer = Value
            End Set
        End Property
        Public Property CustomerName() As String
            Get
                Return _CustomerName
            End Get
            Set(ByVal Value As String)
                _CustomerName = Value
            End Set
        End Property
        Public Property JobTenderDate() As Date
            Get
                Return _JobTenderDate
            End Get
            Set(ByVal Value As Date)
                _JobTenderDate = Value
            End Set
        End Property
        Public Property DateCalcMethod() As CommonEnums.DateCalcMethodEnum
            Get
                Return _DateCalcMethod
            End Get
            Set(ByVal Value As CommonEnums.DateCalcMethodEnum)
                _DateCalcMethod = Value
            End Set
        End Property
        Public Property IncludeOvertimePct() As CommonEnums.YesNoEnum
            Get
                Return _IncludeOvertimePct
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IncludeOvertimePct = Value
            End Set
        End Property
        Public Property SetMethodToManual() As CommonEnums.YesNoEnum
            Get
                Return _SetMethodToManual
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _SetMethodToManual = Value
            End Set
        End Property
        Public Property JobStartDate() As Date
            Get
                Return _JobStartDate
            End Get
            Set(ByVal Value As Date)
                _JobStartDate = Value
            End Set
        End Property
        Public Property JobDeliveryDate() As Date
            Get
                Return _JobDeliveryDate
            End Get
            Set(ByVal Value As Date)
                _JobDeliveryDate = Value
            End Set
        End Property
        Public Property SeqCheckReq() As CommonEnums.YesNoEnum
            Get
                Return _SeqCheckReq
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _SeqCheckReq = Value
            End Set
        End Property
        Public Property ConfirmedFlag() As CommonEnums.YesNoEnum
            Get
                Return _ConfirmedFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ConfirmedFlag = Value
            End Set
        End Property
        Public Property HoldFlag() As CommonEnums.YesNoEnum
            Get
                Return _HoldFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _HoldFlag = Value
            End Set
        End Property
        Public Property Route() As Integer
            Get
                Return _Route
            End Get
            Set(ByVal Value As Integer)
                _Route = Value
            End Set
        End Property
        Public Property RoutePassword() As String
            Get
                Return _RoutePassword
            End Get
            Set(ByVal Value As String)
                _RoutePassword = Value
            End Set
        End Property
        Public Property WipCtlGlCode() As String
            Get
                Return _WipCtlGlCode
            End Get
            Set(ByVal Value As String)
                _WipCtlGlCode = Value
            End Set
        End Property
        Public Property NonStocked() As CommonEnums.YesNoEnum
            Get
                Return _NonStocked
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _NonStocked = Value
            End Set
        End Property
        Public Property StockDescription() As String
            Get
                Return _StockDescription
            End Get
            Set(ByVal Value As String)
                _StockDescription = Value
            End Set
        End Property
        Public Property ExpLabour() As Decimal
            Get
                Return _ExpLabour
            End Get
            Set(ByVal Value As Decimal)
                _ExpLabour = Value
            End Set
        End Property
        Public Property ExpMaterial() As Decimal
            Get
                Return _ExpMaterial
            End Get
            Set(ByVal Value As Decimal)
                _ExpMaterial = Value
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
        Public Property AddLabPct() As Decimal
            Get
                Return _AddLabPct
            End Get
            Set(ByVal Value As Decimal)
                _AddLabPct = Value
            End Set
        End Property
        Public Property AddMatPct() As Decimal
            Get
                Return _AddMatPct
            End Get
            Set(ByVal Value As Decimal)
                _AddMatPct = Value
            End Set
        End Property
        Public Property ProfitPct() As Decimal
            Get
                Return _ProfitPct
            End Get
            Set(ByVal Value As Decimal)
                _ProfitPct = Value
            End Set
        End Property
        Public Property TraceableType() As CommonEnums.YesNoEnum
            Get
                Return _TraceableType
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _TraceableType = Value
            End Set
        End Property
        Public Property HierarchyFlag() As CommonEnums.YesNoEnum
            Get
                Return _HierarchyFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _HierarchyFlag = Value
            End Set
        End Property
        Public Property HierarchyContract() As String
            Get
                Return _HierarchyContract
            End Get
            Set(ByVal Value As String)
                _HierarchyContract = Value
            End Set
        End Property
        Public Property HierarchyCode() As String
            Get
                Return _HierarchyCode
            End Get
            Set(ByVal Value As String)
                _HierarchyCode = Value
            End Set
        End Property
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property SalesOrderLine() As Integer
            Get
                Return _SalesOrderLine
            End Get
            Set(ByVal Value As Integer)
                _SalesOrderLine = Value
            End Set
        End Property
        Public Property IncludeAllocations() As CommonEnums.YesNoEnum
            Get
                Return _IncludeAllocations
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IncludeAllocations = Value
            End Set
        End Property
        Public Property ComponentWarehouse() As String
            Get
                Return _ComponentWarehouse
            End Get
            Set(ByVal Value As String)
                _ComponentWarehouse = Value
            End Set
        End Property
        Public Property CreateSubJobs() As CommonEnums.YesNoEnum
            Get
                Return _CreateSubJobs
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CreateSubJobs = Value
            End Set
        End Property
        Public Property SubJobPrefix() As String
            Get
                Return _SubJobPrefix
            End Get
            Set(ByVal Value As String)
                _SubJobPrefix = Value
            End Set
        End Property
        Public Property SubJobSuffix() As String
            Get
                Return _SubJobSuffix
            End Get
            Set(ByVal Value As String)
                _SubJobSuffix = Value
            End Set
        End Property
        Public Property UseGlForAllJobs() As CommonEnums.YesNoEnum
            Get
                Return _UseGlForAllJobs
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _UseGlForAllJobs = Value
            End Set
        End Property
        Public Property CheckLeadTime() As CommonEnums.YesNoEnum
            Get
                Return _CheckLeadTime
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _CheckLeadTime = Value
            End Set
        End Property
        Public Property ReCalculateJobDates() As CommonEnums.YesNoEnum
            Get
                Return _ReCalculateJobDates
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ReCalculateJobDates = Value
            End Set
        End Property
        Public Property ChangeSalesOrderWarehouse() As CommonEnums.YesNoEnum
            Get
                Return _ChangeSalesOrderWarehouse
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ChangeSalesOrderWarehouse = Value
            End Set
        End Property


        'Parameter Properties
        Public Property JobActionType() As CommonEnums.ActionTypeEnum
            Get
                Return _JobActionType
            End Get
            Set(ByVal Value As CommonEnums.ActionTypeEnum)
                _JobActionType = Value
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
        Private _BusinessObject As String = "WIPTJB"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Job")
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

                'Build an XML string to pass parameters
                sbXMLParam.Append("<PostJob>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ActionType>{0}</ActionType>", Left(JobActionType.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<Snapshot>{0}</Snapshot>", Left(Snapshot.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostJob>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Dim sbXMLin As New System.Text.StringBuilder
                sbXMLin.Append("<PostJob>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<JobDescription>{0}</JobDescription>", JobDescription)
                sbXMLin.AppendFormat("<JobClassification>{0}</JobClassification>", JobClassification)
                sbXMLin.AppendFormat("<Priority>{0}</Priority>", Priority)
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Version>{0}</Version>", Version)
                sbXMLin.AppendFormat("<Release>{0}</Release>", Release)
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<QtyToMake>{0}</QtyToMake>", QtyToMake)
                sbXMLin.AppendFormat("<Customer>{0}</Customer>", Customer)
                sbXMLin.AppendFormat("<CustomerName>{0}</CustomerName>", CustomerName)
                sbXMLin.AppendFormat("<JobTenderDate>{0}</JobTenderDate>", Format(JobTenderDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<DateCalcMethod>{0}</DateCalcMethod>", Left(DateCalcMethod.ToString, 1))
                sbXMLin.AppendFormat("<IncludeOvertimePct>{0}</IncludeOvertimePct>", Left(IncludeOvertimePct.ToString, 1))
                sbXMLin.AppendFormat("<SetMethodToManual>{0}</SetMethodToManual>", Left(SetMethodToManual.ToString, 1))
                sbXMLin.AppendFormat("<JobStartDate>{0}</JobStartDate>", Format(JobStartDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<JobDeliveryDate>{0}</JobDeliveryDate>", Format(JobDeliveryDate, "yyyy-MM-dd"))
                sbXMLin.AppendFormat("<SeqCheckReq>{0}</SeqCheckReq>", Left(SeqCheckReq.ToString, 1))
                sbXMLin.AppendFormat("<ConfirmedFlag>{0}</ConfirmedFlag>", Left(ConfirmedFlag.ToString, 1))
                sbXMLin.AppendFormat("<HoldFlag>{0}</HoldFlag>", Left(HoldFlag.ToString, 1))
                sbXMLin.AppendFormat("<Route>{0}</Route>", Route)
                sbXMLin.AppendFormat("<RoutePassword>{0}</RoutePassword>", RoutePassword)
                If WipCtlGlCode > "" Then
                    sbXMLin.AppendFormat("<WipCtlGlCode>{0}</WipCtlGlCode>", WipCtlGlCode)
                End If
                sbXMLin.AppendFormat("<NonStocked>{0}</NonStocked>", Left(NonStocked.ToString, 1))
                sbXMLin.AppendFormat("<StockDescription>{0}</StockDescription>", StockDescription)
                sbXMLin.AppendFormat("<ExpLabour>{0}</ExpLabour>", ExpLabour)
                sbXMLin.AppendFormat("<ExpMaterial>{0}</ExpMaterial>", ExpMaterial)
                sbXMLin.AppendFormat("<SellingPrice>{0}</SellingPrice>", SellingPrice)
                sbXMLin.AppendFormat("<AddLabPct>{0}</AddLabPct>", AddLabPct)
                sbXMLin.AppendFormat("<AddMatPct>{0}</AddMatPct>", AddMatPct)
                sbXMLin.AppendFormat("<ProfitPct>{0}</ProfitPct>", ProfitPct)
                sbXMLin.AppendFormat("<TraceableType>{0}</TraceableType>", Left(TraceableType.ToString, 1))
                sbXMLin.AppendFormat("<HierarchyFlag>{0}</HierarchyFlag>", Left(HierarchyFlag.ToString, 1))
                sbXMLin.AppendFormat("<HierarchyContract>{0}</HierarchyContract>", HierarchyContract)
                sbXMLin.AppendFormat("<HierarchyCode>{0}</HierarchyCode>", HierarchyCode)
                sbXMLin.AppendFormat("<SalesOrder>{0}</SalesOrder>", SalesOrder)
                sbXMLin.AppendFormat("<SalesOrderLine>{0}</SalesOrderLine>", SalesOrderLine)
                sbXMLin.AppendFormat("<IncludeAllocations>{0}</IncludeAllocations>", Left(IncludeAllocations.ToString, 1))
                sbXMLin.AppendFormat("<ComponentWarehouse>{0}</ComponentWarehouse>", ComponentWarehouse)
                sbXMLin.Append("<SubJobOptions>")
                sbXMLin.AppendFormat("<CreateSubJobs>{0}</CreateSubJobs>", Left(CreateSubJobs.ToString, 1))
                sbXMLin.AppendFormat("<SubJobPrefix>{0}</SubJobPrefix>", SubJobPrefix)
                sbXMLin.AppendFormat("<SubJobSuffix>{0}</SubJobSuffix>", SubJobSuffix)
                sbXMLin.AppendFormat("<UseGlForAllJobs>{0}</UseGlForAllJobs>", Left(UseGlForAllJobs.ToString, 1))
                sbXMLin.Append("</SubJobOptions>")
                sbXMLin.AppendFormat("<CheckLeadTime>{0}</CheckLeadTime>", Left(CheckLeadTime.ToString, 1))
                sbXMLin.AppendFormat("<ReCalculateJobDates>{0}</ReCalculateJobDates>", Left(ReCalculateJobDates.ToString, 1))
                sbXMLin.AppendFormat("<ChangeSalesOrderWarehouse>{0}</ChangeSalesOrderWarehouse>", Left(ChangeSalesOrderWarehouse.ToString, 1))
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostJob>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strActionType As CommonEnums.ActionTypeEnum, ByVal strJobID As String)
            _JobActionType = strActionType
            _Job = strJobID
        End Sub

        Private _TransactionType As CommonEnums.ActionType_Transaction
        Public Property TransactionActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _TransactionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _TransactionType = value
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
