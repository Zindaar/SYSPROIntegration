Namespace TransactionObjects
    <Serializable()> Public Class WipMaterialAllocation

#Region "Local Variables"

        'Private Variables
        Private _Job As String 'max 8
        Private _NonStocked As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _StockCode As String 'max 30
        Private _Warehouse As String 'max 2
        Private _NewWarehouse As String 'max 2
        Private _Line As String = "00" 'max 2
        Private _ExplodeIfPhantomPart As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ExplodeIfKitPart As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _ComponentWhToUse As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _StockDescription As String 'max 30
        Private _QtyReqdType As CommonEnums.QtyReqdTypeEnum = CommonEnums.QtyReqdTypeEnum.Unit
        Private _QtyReqd As Decimal 'signed 6.6
        Private _UnitCost As Decimal 'signed 10.5
        Private _OperationOffset As Integer 'max 9999
        Private _OpOffsetFlag As CommonEnums.OperationOffsetFlagEnum = CommonEnums.OperationOffsetFlagEnum.DaysOffset
        Private _Uom As String 'max 3
        Private _SequenceNum As String 'max 6
        Private _Head As String 'max 3
        Private _Section1 As String 'max 3
        Private _Section2 As String 'max 3
        Private _Section3 As String 'max 3
        Private _Section4 As String 'max 3
        Private _Version As String 'max 3
        Private _Release As String 'max 3

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
        Public Property NonStocked() As CommonEnums.YesNoEnum
            Get
                Return _NonStocked
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _NonStocked = Value
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
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property
        Public Property NewWarehouse() As String
            Get
                Return _NewWarehouse
            End Get
            Set(ByVal Value As String)
                _NewWarehouse = Value
            End Set
        End Property
        Public Property Line() As String
            Get
                Return _Line
            End Get
            Set(ByVal Value As String)
                _Line = Value
            End Set
        End Property
        Public Property ExplodeIfPhantomPart() As CommonEnums.YesNoEnum
            Get
                Return _ExplodeIfPhantomPart
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ExplodeIfPhantomPart = Value
            End Set
        End Property
        Public Property ExplodeIfKitPart() As CommonEnums.YesNoEnum
            Get
                Return _ExplodeIfKitPart
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ExplodeIfKitPart = Value
            End Set
        End Property
        Public Property ComponentWhToUse() As CommonEnums.YesNoEnum
            Get
                Return _ComponentWhToUse
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ComponentWhToUse = Value
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
        Public Property QtyReqdType() As CommonEnums.QtyReqdTypeEnum
            Get
                Return _QtyReqdType
            End Get
            Set(ByVal Value As CommonEnums.QtyReqdTypeEnum)
                _QtyReqdType = Value
            End Set
        End Property
        Public Property QtyReqd() As Decimal
            Get
                Return _QtyReqd
            End Get
            Set(ByVal Value As Decimal)
                _QtyReqd = Value
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
        Public Property OperationOffset() As Integer
            Get
                Return _OperationOffset
            End Get
            Set(ByVal Value As Integer)
                _OperationOffset = Value
            End Set
        End Property
        Public Property OpOffsetFlag() As CommonEnums.OperationOffsetFlagEnum
            Get
                Return _OpOffsetFlag
            End Get
            Set(ByVal Value As CommonEnums.OperationOffsetFlagEnum)
                _OpOffsetFlag = Value
            End Set
        End Property
        Public Property Uom() As String
            Get
                Return _Uom
            End Get
            Set(ByVal Value As String)
                _Uom = Value
            End Set
        End Property
        Public Property SequenceNum() As String
            Get
                Return _SequenceNum
            End Get
            Set(ByVal Value As String)
                _SequenceNum = Value
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
        Private _BusinessObject As String = "WIPTJM"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Key/Line")
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

                sbXMLParam.Append("<PostMaterialAllocations>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<ActionType>{0}</ActionType>", Left(ActionType.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<Snapshot>{0}</Snapshot>", Left(Snapshot.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostMaterialAllocations>")

                Return sbXMLParam.ToString
            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostMaterialAllocations>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<NonStocked>{0}</NonStocked>", Left(NonStocked.ToString, 1))
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<NewWarehouse>{0}</NewWarehouse>", NewWarehouse)
                sbXMLin.AppendFormat("<Line>{0}</Line>", Line)
                sbXMLin.AppendFormat("<ExplodeIfPhantomPart>{0}</ExplodeIfPhantomPart>", Left(ExplodeIfPhantomPart.ToString, 1))
                sbXMLin.AppendFormat("<ExplodeIfKitPart>{0}</ExplodeIfKitPart>", Left(ExplodeIfKitPart.ToString, 1))
                sbXMLin.AppendFormat("<ComponentWhToUse>{0}</ComponentWhToUse>", Left(ComponentWhToUse.ToString, 1))
                sbXMLin.AppendFormat("<StockDescription>{0}</StockDescription>", StockDescription)
                sbXMLin.AppendFormat("<QtyReqdType>{0}</QtyReqdType>", Left(QtyReqdType.ToString, 1))
                sbXMLin.AppendFormat("<QtyReqd>{0}</QtyReqd>", QtyReqd)
                sbXMLin.AppendFormat("<UnitCost>{0}</UnitCost>", UnitCost)
                sbXMLin.AppendFormat("<OperationOffset>{0}</OperationOffset>", OperationOffset)
                sbXMLin.AppendFormat("<OpOffsetFlag>{0}</OpOffsetFlag>", Left(OpOffsetFlag.ToString, 1))
                sbXMLin.AppendFormat("<Uom>{0}</Uom>", Uom)
                sbXMLin.AppendFormat("<SequenceNum>{0}</SequenceNum>", SequenceNum)
                sbXMLin.Append("<HierarchyJob>")
                sbXMLin.AppendFormat("<Head>{0}</Head>", Head)
                sbXMLin.AppendFormat("<Section1>{0}</Section1>", Section1)
                sbXMLin.AppendFormat("<Section2>{0}</Section2>", Section2)
                sbXMLin.AppendFormat("<Section3>{0}</Section3>", Section3)
                sbXMLin.AppendFormat("<Section4>{0}</Section4>", Section4)
                sbXMLin.Append("</HierarchyJob>")
                sbXMLin.AppendFormat("<Version>{0}</Version>", Version)
                sbXMLin.AppendFormat("<Release>{0}</Release>", Release)
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostMaterialAllocations>")

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
