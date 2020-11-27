Namespace TransactionObjects
    <Serializable()> Public Class WipMaterialPost


#Region "Local Variables"
        Private _Journal As Integer 'max 5 digits
        Private _Job As String 'max 8
        Private _NonStockedFlag As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _Warehouse As String 'max 2
        Private _StockCode As String 'max 30
        Private _Line As Integer '0 to 99
        Private _QtyIssued As Decimal 'signed decimal max 11 digits
        Private _Reference As String 'max 9
        Private _Notation As String 'max 45
        Private _LedgerCode As String 'max 15
        Private _PasswordForLedgerCode As String 'max 4
        Private _ProductClass As String 'max 4
        Private _UnitCost As Decimal '10.5 positive numeric
        Private _AllocCompleted As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _FifoBucket As String 'max  6
        Private _Lot As String 'max 10
        Private _LotConcession As String 'max 10
        Private _MyBins As New ArrayList
        Private _MySerials As New ArrayList
        Private _MySerialAllocations As New ArrayList

        'Variables for Param Doc
        Private _TransactionDate As Date
        Private _PostingPeriod As CommonEnums.PostingPeriodEnum = CommonEnums.PostingPeriodEnum.Current
        Private _PasswordForPreviousPeriod As String 'max 4
        Private _PasswordForCompletedJobs As String 'max 4
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _AutoDepleteLotsBins As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

#End Region

#Region "Public Properties"
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
        Public Property NonStockedFlag() As CommonEnums.YesNoEnum
            Get
                Return _NonStockedFlag
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _NonStockedFlag = Value
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
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        Public Property Line() As Integer
            Get
                Return _Line
            End Get
            Set(ByVal Value As Integer)
                _Line = Value
            End Set
        End Property
        Public Property QtyIssued() As Decimal
            Get
                Return _QtyIssued
            End Get
            Set(ByVal Value As Decimal)
                _QtyIssued = Value
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
        Public Property LedgerCode() As String
            Get
                Return _LedgerCode
            End Get
            Set(ByVal Value As String)
                _LedgerCode = Value
            End Set
        End Property
        Public Property PasswordForLedgerCode() As String
            Get
                Return _PasswordForLedgerCode
            End Get
            Set(ByVal Value As String)
                _PasswordForLedgerCode = Value
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
        Public Property UnitCost() As Decimal
            Get
                Return _UnitCost
            End Get
            Set(ByVal Value As Decimal)
                _UnitCost = Value
            End Set
        End Property
        Public Property AllocCompleted() As CommonEnums.YesNoEnum
            Get
                Return _AllocCompleted
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AllocCompleted = Value
            End Set
        End Property
        Public Property FifoBucket() As String
            Get
                Return _FifoBucket
            End Get
            Set(ByVal Value As String)
                _FifoBucket = Value
            End Set
        End Property
        Public Property Lot() As String
            Get
                Return _Lot
            End Get
            Set(ByVal Value As String)
                _Lot = Value
            End Set
        End Property
        Public Property LotConcession() As String
            Get
                Return _LotConcession
            End Get
            Set(ByVal Value As String)
                _LotConcession = Value
            End Set
        End Property
        Public ReadOnly Property MyBins() As ArrayList
            Get
                Return _MyBins
            End Get
        End Property
        Public ReadOnly Property MySerials() As ArrayList
            Get
                Return _MySerials
            End Get
        End Property
        Public ReadOnly Property MySerialAllocations() As ArrayList
            Get
                Return _MySerialAllocations
            End Get
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
        Public Property PasswordForCompletedJobs() As String
            Get
                Return _PasswordForCompletedJobs
            End Get
            Set(ByVal Value As String)
                _PasswordForCompletedJobs = Value
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
        Public Property AutoDepleteLotsBins() As CommonEnums.YesNoEnum
            Get
                Return _AutoDepleteLotsBins
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _AutoDepleteLotsBins = Value
            End Set
        End Property

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "WIPTMI"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Key/Journal")
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

                sbXMLParam.Append("<PostMaterial>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<TransactionDate>{0}</TransactionDate>", Format(TransactionDate, "yyyy-MM-dd"))
                sbXMLParam.AppendFormat("<PostingPeriod>{0}</PostingPeriod>", Left(PostingPeriod.ToString, 1))
                sbXMLParam.AppendFormat("<PasswordForPreviousPeriod>{0}</PasswordForPreviousPeriod>", PasswordForPreviousPeriod)
                sbXMLParam.AppendFormat("<PasswordForCompletedJobs>{0}</PasswordForCompletedJobs>", PasswordForCompletedJobs)
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<AutoDepleteLotsBins>{0}</AutoDepleteLotsBins>", Left(AutoDepleteLotsBins.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostMaterial>")

                Return sbXMLParam.ToString

            End Get
        End Property

        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostMaterial>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Journal>{0}</Journal>", Journal)
                sbXMLin.AppendFormat("<Job>{0}</Job>", Job)
                sbXMLin.AppendFormat("<NonStockedFlag>{0}</NonStockedFlag>", Left(NonStockedFlag.ToString, 1))
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Line>{0}</Line>", Line)
                sbXMLin.AppendFormat("<QtyIssued>{0}</QtyIssued>", QtyIssued)
                sbXMLin.AppendFormat("<Reference>{0}</Reference>", Reference)
                sbXMLin.AppendFormat("<Notation>{0}</Notation>", Notation)
                sbXMLin.AppendFormat("<LedgerCode>{0}</LedgerCode>", LedgerCode)
                sbXMLin.AppendFormat("<PasswordForLedgerCode>{0}</PasswordForLedgerCode>", PasswordForLedgerCode)
                sbXMLin.AppendFormat("<ProductClass>{0}</ProductClass>", ProductClass)
                sbXMLin.AppendFormat("<UnitCost>{0}</UnitCost>", UnitCost)
                sbXMLin.AppendFormat("<AllocCompleted>{0}</AllocCompleted>", Left(AllocCompleted.ToString, 1))
                sbXMLin.AppendFormat("<FifoBucket>{0}</FifoBucket>", FifoBucket)
                If MyBins.Count > 0 Then
                    sbXMLin.Append("Bins")
                    Dim tmpBin As WipMaterialBin
                    For Each tmpBin In MyBins
                        sbXMLin.AppendFormat("<BinLocation>{0}</BinLocation>", tmpBin.BinLocation)
                        sbXMLin.AppendFormat("<BinQuantity>{0}</BinQuantity>", tmpBin.BinQuantity)
                    Next
                    sbXMLin.Append("/Bins")
                End If
                sbXMLin.AppendFormat("<Lot>{0}</Lot>", Lot)
                sbXMLin.AppendFormat("<LotConcession>{0}</LotConcession>", LotConcession)
                If MySerials.Count > 0 Then
                    sbXMLin.Append("Serials")
                    Dim tmpSerial As Common.SerialNumber
                    For Each tmpSerial In MySerials
                        sbXMLin.AppendFormat("<SerialNumber>{0}</SerialNumber>", tmpSerial.SerialNumber)
                        sbXMLin.AppendFormat("<SerialQuantity>{0}</SerialQuantity>", tmpSerial.SerialQuantity)
                    Next
                    sbXMLin.Append("/Serials")
                End If
                If MySerialAllocations.Count > 0 Then
                    sbXMLin.Append("SerialAllocation")
                    Dim tmpSerialAllocation As Common.SerialAllocation
                    For Each tmpSerialAllocation In MySerialAllocations
                        sbXMLin.AppendFormat("<FromSerialNumber>{0}</FromSerialNumber>", tmpSerialAllocation.FromSerialNumber)
                        sbXMLin.AppendFormat("<ToSerialNumber>{0}</ToSerialNumber>", tmpSerialAllocation.ToSerialNumber)
                        sbXMLin.AppendFormat("<SerialQuantity>{0}</SerialQuantity>", tmpSerialAllocation.SerialQuantity)
                    Next
                    sbXMLin.Append("/SerialAllocation")
                End If
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostMaterial>")

                Return sbXMLin.ToString

            End Get
        End Property

#End Region

        'Constructor
        Public Sub New(ByVal strJobID As String)
            _Job = strJobID
        End Sub

        Public Sub AddBin(ByVal oBinToAdd As WipMaterialBin)
            _MyBins.Add(oBinToAdd)
        End Sub
        Public Sub AddSerial(ByVal oSerialToAdd As Common.SerialNumber)
            _MySerials.Add(oSerialToAdd)
        End Sub
        Public Sub AddSerialAllocation(ByVal oSerialAllocationToAdd As Common.SerialAllocation)
            _MySerialAllocations.Add(oSerialAllocationToAdd)
        End Sub
        Public Sub ClearBins()
            _MyBins = New ArrayList
        End Sub
        Public Sub ClearSerials()
            _MySerials = New ArrayList
        End Sub
        Public Sub ClearSerialAllocaitions()
            _MySerialAllocations = New ArrayList
        End Sub

    End Class

End Namespace
