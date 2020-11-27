Namespace TransactionObjects
    ''' <summary>
    ''' E.Net Inventory Adjustments Business Object.  Use with Transaction.Post method.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[shawn]	20/04/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class InventoryAdjustment

#Region "Local Variables"

        Private _Warehouse As String 'max 2
        Private _StockCode As String 'max 30
        Private _Version As String  'max 3
        Private _Release As String  'max 3
        Private _Quantity As Decimal '6.3 numeric
        Private _UnitOfMeasure As String  'max 3
        Private _Units As Integer  'max 7 digits
        Private _Pieces As Integer  'max 3 digits
        Private _BinLocation As String 'max 6
        Private _FifoBucket As String  'max 6
        Private _Lot As String  'max 10
        Private _Reference As String 'max 9
        Private _Notation As String 'max 45
        Private _LedgerCode As String 'max 15
        Private _PasswordForLedgerCode As String  'max 4
        Private _MySerials As New Collections.Generic.List(Of Common.SerialNumber)
        Private _MySerialAllocations As New Collections.Generic.List(Of Common.SerialAllocation)

        Private _TransactionDate As Date = Now
        Private _PhysicalCount As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No
        Private _PostingPeriod As CommonEnums.PostingPeriodEnum = CommonEnums.PostingPeriodEnum.Current
        Private _IgnoreWarnings As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ApplyIfEntireDocumentValid As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.Yes
        Private _ValidateOnly As CommonEnums.YesNoEnum = CommonEnums.YesNoEnum.No

#End Region

#Region "Properties"
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory and must contain a valid warehouse code (2 characters).
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory and must contain a valid stock code (30 characters).
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property StockCode() As String
            Get
                Return _StockCode
            End Get
            Set(ByVal Value As String)
                _StockCode = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory if stock is ECC-controlled at version or release level. (3 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal Value As String)
                _Version = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory if stock is ECC-controlled at release level.(3 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Release() As String
            Get
                Return _Release
            End Get
            Set(ByVal Value As String)
                _Release = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied. If processing a Physical Count, none of the quantity fields may be negative.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Quantity() As Decimal
            Get
                Return _Quantity
            End Get
            Set(ByVal Value As Decimal)
                _Quantity = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If quantity was supplied in a unit of measure different from the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property UnitOfMeasure() As String
            Get
                Return _UnitOfMeasure
            End Get
            Set(ByVal Value As String)
                _UnitOfMeasure = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative. (7 digits)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Units() As Integer
            Get
                Return _Units
            End Get
            Set(ByVal Value As Integer)
                _Units = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. If processing a Physical Count, none of the quantity fields may be negative.(3 digits)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Pieces() As Integer
            Get
                Return _Pieces
            End Get
            Set(ByVal Value As Integer)
                _Pieces = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If multiple bins are installed, this element is mandatory.(6 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property BinLocation() As String
            Get
                Return _BinLocation
            End Get
            Set(ByVal Value As String)
                _BinLocation = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is optional. It must be supplied if FIFO is installed or FIFO/LIFO costing is used and a specific FIFO/LIFO bucket is to be adjusted. Note that a FIFO bucket of zeros is valid and is the first bucket on file. (6 digits)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property FifoBucket() As String
            Get
                Return _FifoBucket
            End Get
            Set(ByVal Value As String)
                _FifoBucket = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory for lot traceable stock codes. Not allowed for unit-qty type stock codes. (10 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Lot() As String
            Get
                Return _Lot
            End Get
            Set(ByVal Value As String)
                _Lot = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is optional. (9 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Reference() As String
            Get
                Return _Reference
            End Get
            Set(ByVal Value As String)
                _Reference = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is optional. (45 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property Notation() As String
            Get
                Return _Notation
            End Get
            Set(ByVal Value As String)
                _Notation = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is mandatory if  Inventory is integrated to General Ledger or if ledger codes are required for this type of inventory transaction. (15 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property LedgerCode() As String
            Get
                Return _LedgerCode
            End Get
            Set(ByVal Value As String)
                _LedgerCode = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If ledger codes require a password, this element must contain the relevant password. (30 characters)
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property PasswordForLedgerCode() As String
            Get
                Return _PasswordForLedgerCode
            End Get
            Set(ByVal Value As String)
                _PasswordForLedgerCode = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' A set of serial numbers and relevant quantities to process may be supplied for serialized stock codes. Not allowed for unit-qty type stock codes.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property MySerials() As Collections.Generic.List(Of Common.SerialNumber)
            Get
                Return _MySerials
            End Get
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element is used to specify a range of serial numbers to be allocated. It is only valid when processing manual serialized stock items.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property MySerialAllocations() As Collections.Generic.List(Of Common.SerialAllocation)
            Get
                Return _MySerialAllocations
            End Get
        End Property

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Date transaction raised. Default = System.Now()
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property TransactionDate() As Date
            Get
                Return _TransactionDate
            End Get
            Set(ByVal Value As Date)
                _TransactionDate = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' If processing a Physical Count transaction, this element must contain be Yes. If it is not supplied or it is set to No an Adjustment is processed. Physical Count transactions are not allowed in previous periods. Default = No.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property PhysicalCount() As CommonEnums.YesNoEnum
            Get
                Return _PhysicalCount
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _PhysicalCount = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Period to which transactions must be posted. Default = Current
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property PostingPeriod() As CommonEnums.PostingPeriodEnum
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As CommonEnums.PostingPeriodEnum)
                _PostingPeriod = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element indicates whether or not a transaction must be rejected if there are any warnings. Default = Yes
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property IgnoreWarnings() As CommonEnums.YesNoEnum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _IgnoreWarnings = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element indicates whether to process entire document only if all items are valid. If set to No, each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is Yes.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property ApplyIfEntireDocumentValid() As CommonEnums.YesNoEnum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As CommonEnums.YesNoEnum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This element indicates which processing phases are to be performed. If set to Yes all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to No, each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is No.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
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
        Private _BusinessObject As String = "INVTMA"
        Private _ProcessedElement As String
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        '''   This returns the Journal number of the posted item after a successful post.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
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
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This returns the Syspro E.Net Business Object Code.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property BusinessObject() As String
            Get
                Return _BusinessObject
            End Get
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This returns the xml returned by the Transaction.Post method.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Property xmlOut() As String
            Get
                Return _xmlOut
            End Get
            Set(ByVal Value As String)
                _xmlOut = Value
            End Set
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This builds and returns the Parameters to be passed to the Transaction.Post method.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property xmlParam() As String
            Get
                Dim sbXMLParam As New System.Text.StringBuilder
                sbXMLParam.Append("<PostInvAdjustments>")
                sbXMLParam.Append("<Parameters>")
                sbXMLParam.AppendFormat("<TransactionDate>{0}</TransactionDate>", TransactionDate)
                sbXMLParam.AppendFormat("<PhysicalCount>{0}</PhysicalCount>", Left(PhysicalCount.ToString, 1))
                sbXMLParam.AppendFormat("<PostingPeriod>{0}</PostingPeriod>", PostingPeriod)
                sbXMLParam.AppendFormat("<IgnoreWarnings>{0}</IgnoreWarnings>", Left(IgnoreWarnings.ToString, 1))
                sbXMLParam.AppendFormat("<ApplyIfEntireDocumentValid>{0}</ApplyIfEntireDocumentValid>", Left(ApplyIfEntireDocumentValid.ToString, 1))
                sbXMLParam.AppendFormat("<ValidateOnly>{0}</ValidateOnly>", Left(ValidateOnly.ToString, 1))
                sbXMLParam.Append("</Parameters>")
                sbXMLParam.Append("</PostInvAdjustments>")

                Return sbXMLParam.ToString
            End Get
        End Property
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' This builds and returns the xml Data to be passed to the Transaction.Post method.
        ''' </summary>
        ''' <value></value>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property xmlIn() As String
            Get
                Dim sbXMLin As New System.Text.StringBuilder

                sbXMLin.Append("<PostInvAdjustments>")
                sbXMLin.Append("<Item>")
                sbXMLin.AppendFormat("<Warehouse>{0}</Warehouse>", Warehouse)
                sbXMLin.AppendFormat("<StockCode>{0}</StockCode>", StockCode)
                sbXMLin.AppendFormat("<Version >{0}</Version >", Version)
                sbXMLin.AppendFormat("<Release >{0}</Release >", Release)
                sbXMLin.AppendFormat("<Quantity>{0}</Quantity>", Quantity)
                sbXMLin.AppendFormat("<UnitOfMeasure >{0}</UnitOfMeasure >", UnitOfMeasure)
                sbXMLin.AppendFormat("<Units >{0}</Units >", Units)
                sbXMLin.AppendFormat("<Pieces >{0}</Pieces >", Pieces)
                sbXMLin.AppendFormat("<BinLocation>{0}</BinLocation>", BinLocation)
                sbXMLin.AppendFormat("<FifoBucket >{0}</FifoBucket >", FifoBucket)
                sbXMLin.AppendFormat("<Lot >{0}</Lot >", Lot)
                sbXMLin.AppendFormat("<Reference>{0}</Reference>", Reference)
                sbXMLin.AppendFormat("<Notation>{0}</Notation>", Notation)
                sbXMLin.AppendFormat("<LedgerCode>{0}</LedgerCode>", LedgerCode)
                sbXMLin.AppendFormat("<PasswordForLedgerCode >{0}</PasswordForLedgerCode >", PasswordForLedgerCode)
                If MySerials.Count > 0 Then
                    sbXMLin.Append("Serials")
                    For Each tmpSerial As Common.SerialNumber In MySerials
                        sbXMLin.AppendFormat("<SerialNumber>{0}</SerialNumber>", tmpSerial.SerialNumber)
                        sbXMLin.AppendFormat("<SerialQuantity>{0}</SerialQuantity>", tmpSerial.SerialQuantity)
                    Next
                    sbXMLin.Append("/Serials")
                End If
                If MySerialAllocations.Count > 0 Then
                    sbXMLin.Append("SerialAllocation")
                    For Each tmpSerialAllocation As Common.SerialAllocation In MySerialAllocations
                        sbXMLin.AppendFormat("<FromSerialNumber>{0}</FromSerialNumber>", tmpSerialAllocation.FromSerialNumber)
                        sbXMLin.AppendFormat("<ToSerialNumber>{0}</ToSerialNumber>", tmpSerialAllocation.ToSerialNumber)
                        sbXMLin.AppendFormat("<SerialQuantity>{0}</SerialQuantity>", tmpSerialAllocation.SerialQuantity)
                    Next
                    sbXMLin.Append("/SerialAllocation")
                End If
                sbXMLin.Append("</Item>")
                sbXMLin.Append("</PostInvAdjustments>")

                Return sbXMLin.ToString
            End Get
        End Property

#End Region

        'Constructor
        Public Sub New()
        End Sub
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Add a defined serial number to this object.
        ''' </summary>
        ''' <param name="oSerialToAdd"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub AddSerial(ByVal oSerialToAdd As Common.SerialNumber)
            _MySerials.Add(oSerialToAdd)
        End Sub
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Add a range of serial numbers to ths object.
        ''' </summary>
        ''' <param name="oSerialAllocationToAdd"></param>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub AddSerialAllocation(ByVal oSerialAllocationToAdd As Common.SerialAllocation)
            _MySerialAllocations.Add(oSerialAllocationToAdd)
        End Sub
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Clear the MySerials arraylist.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub ClearSerials()
            _MySerials = New Collections.Generic.List(Of Common.SerialNumber)
        End Sub
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Clear the MySerialAllocations arraylist.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[shawn]	20/04/2005	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub ClearSerialAllocations()
            _MySerialAllocations = New Collections.Generic.List(Of Common.SerialAllocation)
        End Sub

    End Class

End Namespace
