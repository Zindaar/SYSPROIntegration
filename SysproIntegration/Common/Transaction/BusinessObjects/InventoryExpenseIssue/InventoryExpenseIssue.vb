Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class InventoryExpenseIssue
        Implements ITransaction

#Region " Params "

#Region "Private Data Members"

        Dim _ApplyIfEntireDocumentValid As InventoryExpenseIssue_ApplyIfEntireDocumentValid_Enum = InventoryExpenseIssue_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_Y
        Dim _CreateLotNumber As InventoryExpenseIssue_CreateLotNumber_Enum = InventoryExpenseIssue_CreateLotNumber_Enum.CreateLotNumber_Upper_N
        Dim _PostInvExpenseIssues As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _PostingPeriod As InventoryExpenseIssue_PostingPeriod_Enum = InventoryExpenseIssue_PostingPeriod_Enum.PostingPeriod_Upper_C
        Dim _TransactionDate As String = String.Empty
        Dim _IgnoreWarnings As InventoryExpenseIssue_IgnoreWarnings_Enum = InventoryExpenseIssue_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _ValidateOnly As InventoryExpenseIssue_ValidateOnly_Enum = InventoryExpenseIssue_ValidateOnly_Enum.ValidateOnly_Upper_N

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As InventoryExpenseIssue_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As InventoryExpenseIssue_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This indicates whether a lot must be created, if it does not exist. It is only allowed if processing a positive transaction. If it is not supplied, it defaults to 'N'. Valid values are 'N' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CreateLotNumber() As InventoryExpenseIssue_CreateLotNumber_Enum
            Get
                Return _CreateLotNumber
            End Get
            Set(ByVal Value As InventoryExpenseIssue_CreateLotNumber_Enum)
                _CreateLotNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  This contains parameters.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Parameters() As String
            Get
                Return _Parameters
            End Get
            Set(ByVal Value As String)
                _Parameters = Value
            End Set
        End Property

        ''' <summary> 
        '''  Period to which transaction must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostingPeriod() As InventoryExpenseIssue_PostingPeriod_Enum
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As InventoryExpenseIssue_PostingPeriod_Enum)
                _PostingPeriod = Value
            End Set
        End Property

        ''' <summary> 
        '''  Date transaction raised. If it is not supplied, rundate is assumed.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TransactionDate() As String
            Get
                Return _TransactionDate
            End Get
            Set(ByVal Value As String)
                _TransactionDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether or not a transaction must be rejected if there are any warnings such as a stock item being on hold. If 'W' is supplied, the error will be reported as a warning. If not supplied it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As InventoryExpenseIssue_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As InventoryExpenseIssue_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        Public Property ValidateOnly() As InventoryExpenseIssue_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal value As InventoryExpenseIssue_ValidateOnly_Enum)
                _ValidateOnly = value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum InventoryExpenseIssue_ValidateOnly_Enum
            ValidateOnly_Upper_Y
            ValidateOnly_Upper_N
        End Enum
        Public Enum InventoryExpenseIssue_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_Y
            ApplyIfEntireDocumentValid_Upper_N
        End Enum
        Public Enum InventoryExpenseIssue_CreateLotNumber_Enum
            CreateLotNumber_Upper_N
            CreateLotNumber_Upper_Y
        End Enum
        Public Enum InventoryExpenseIssue_PostingPeriod_Enum
            PostingPeriod_Upper_C
            PostingPeriod_Upper_P
            PostingPeriod_Upper_B
        End Enum
        Public Enum InventoryExpenseIssue_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_W
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParams() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim CreateLotNumber As System.Xml.XmlElement = xmlDoc.CreateElement("CreateLotNumber")
            Dim PostInvExpenseIssues As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvExpenseIssues")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim PostingPeriod As System.Xml.XmlElement = xmlDoc.CreateElement("PostingPeriod")
            Dim TransactionDate As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionDate")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")

            xmlDoc.AppendChild(PostInvExpenseIssues)
            Common.SysproUtilities.AppendXMLElement(PostInvExpenseIssues, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, CreateLotNumber, Common.SysproUtilities.GetEnumValue(_CreateLotNumber.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, PostingPeriod, Common.SysproUtilities.GetEnumValue(_PostingPeriod.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, TransactionDate, _TransactionDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region

#End Region

#Region " Data "

        Private _myInventoryExpenseIssueItemCollection As InventoryExpenseIssueItemCollection
        Public ReadOnly Property MyInventoryExpenseIssueItemCollection() As InventoryExpenseIssueItemCollection
            Get
                If _myInventoryExpenseIssueItemCollection Is Nothing Then
                    _myInventoryExpenseIssueItemCollection = New InventoryExpenseIssueItemCollection
                End If
                Return _myInventoryExpenseIssueItemCollection
            End Get
        End Property

#Region " Item SubClass "

        <Serializable()> Public Class InventoryExpenseIssueItem

#Region " Private Variables "

            Dim _BinLocation As String = String.Empty
            Dim _FifoBucket As String = String.Empty
            Dim _Item As String = String.Empty
            Dim _Journal As String = String.Empty
            Dim _LedgerCode As String = String.Empty
            Dim _Lot As String = String.Empty
            Dim _Notation As String = String.Empty
            Dim _PasswordForLedgerCode As String = String.Empty
            Dim _Pieces As String = String.Empty
            Dim _Quantity As String = String.Empty
            Dim _Reference As String = String.Empty
            Dim _Release As String = String.Empty
            Dim _Serials As String = String.Empty
            Dim _SerialAllocation As String = String.Empty
            Dim _FromSerialNumber As String = String.Empty
            Dim _ToSerialNumber As String = String.Empty
            Dim _StockCode As String = String.Empty
            Dim _UnitOfMeasure As String = String.Empty
            Dim _Units As String = String.Empty
            Dim _Version As String = String.Empty
            Dim _Warehouse As String = String.Empty
            Dim _SerialQuantity As String = String.Empty
            Private _myInventoryExpenseIssueItemSerialCollection As InventoryExpenseIssueItemSerialCollection

#End Region

#Region " Public Properties "

            ''' <summary> 
            '''  This element is mandatory if multiple bins are installed. It must exist in the specified warehouse.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property BinLocation() As String
                Get
                    Return _BinLocation
                End Get
                Set(ByVal Value As String)
                    _BinLocation = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is optional. It is only available if FIFO is installed and processing a negative expense issue.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property FifoBucket() As String
                Get
                    Return _FifoBucket
                End Get
                Set(ByVal Value As String)
                    _FifoBucket = Value
                End Set
            End Property

            ''' <summary> 
            '''  This is the journal number to which the transaction journal entries will be added. It must be valid for the specified posting period and warehouse and may not have been printed already. If not supplied, a new journal will be created.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Journal() As String
                Get
                    Return _Journal
                End Get
                Set(ByVal Value As String)
                    _Journal = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is only used if Inventory is integrated to General Ledger or requires a Report, and ledger codes are required for this type of inventory transaction. If entered and used, it must be a valid ledger code, and must not be on hold.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property LedgerCode() As String
                Get
                    Return _LedgerCode
                End Get
                Set(ByVal Value As String)
                    _LedgerCode = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory if stock item is lot traceable. It must exist unless the 'CreateLotNumber' parameter is set to 'Y' in which case it will be created.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Lot() As String
                Get
                    Return _Lot
                End Get
                Set(ByVal Value As String)
                    _Lot = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is optional.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Notation() As String
                Get
                    Return _Notation
                End Get
                Set(ByVal Value As String)
                    _Notation = Value
                End Set
            End Property

            ''' <summary> 
            '''  If ledger codes require a password, this element must contain the relevant password for the specified ledger code.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property PasswordForLedgerCode() As String
                Get
                    Return _PasswordForLedgerCode
                End Get
                Set(ByVal Value As String)
                    _PasswordForLedgerCode = Value
                End Set
            End Property

            ''' <summary> 
            '''  If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied in units and pieces. At least one of these elements must be supplied.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Pieces() As String
                Get
                    Return _Pieces
                End Get
                Set(ByVal Value As String)
                    _Pieces = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory if stock item is not a unit-qty type stock item. If it is and this element is supplied, the units and pieces elements must NOT be supplied.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Quantity() As String
                Get
                    Return _Quantity
                End Get
                Set(ByVal Value As String)
                    _Quantity = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is optional.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Reference() As String
                Get
                    Return _Reference
                End Get
                Set(ByVal Value As String)
                    _Reference = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory if stock is ECC-controlled at release level.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Release() As String
                Get
                    Return _Release
                End Get
                Set(ByVal Value As String)
                    _Release = Value
                End Set
            End Property


            ''' <summary> 
            '''  This element specifies the starting serial number to be allocated.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property FromSerialNumber() As String
                Get
                    Return _FromSerialNumber
                End Get
                Set(ByVal Value As String)
                    _FromSerialNumber = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element specifies the ending serial number to be allocated. If this element is not supplied, serial numbers will be allocated starting at the FromSerialNumber until the specified quantity has been allocated.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property ToSerialNumber() As String
                Get
                    Return _ToSerialNumber
                End Get
                Set(ByVal Value As String)
                    _ToSerialNumber = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory and must be stocked in specified warehouse.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property StockCode() As String
                Get
                    Return _StockCode
                End Get
                Set(ByVal Value As String)
                    _StockCode = Value
                End Set
            End Property

            ''' <summary> 
            '''  If quantity was supplied in a unit of measure different to the stocking unit of measure, this element may be supplied to indicate the alternate unit of measure.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property UnitOfMeasure() As String
                Get
                    Return _UnitOfMeasure
                End Get
                Set(ByVal Value As String)
                    _UnitOfMeasure = Value
                End Set
            End Property

            ''' <summary> 
            '''  If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied in units and pieces. At least one of these elements must be supplied.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Units() As String
                Get
                    Return _Units
                End Get
                Set(ByVal Value As String)
                    _Units = Value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory if stock is ECC-controlled at version or release level.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property Version() As String
                Get
                    Return _Version
                End Get
                Set(ByVal Value As String)
                    _Version = Value
                End Set
            End Property

            Public Property Warehouse() As String
                Get
                    Return _Warehouse
                End Get
                Set(ByVal value As String)
                    _Warehouse = value
                End Set
            End Property

            ''' <summary> 
            '''  This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be received for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
            ''' </summary> 
            ''' <returns></returns> 
            ''' <remarks></remarks> 
            Public Property SerialQuantity() As String
                Get
                    Return _SerialQuantity
                End Get
                Set(ByVal Value As String)
                    _SerialQuantity = Value
                End Set
            End Property

            Public ReadOnly Property MyInventoryExpenseIssueItemSerialCollection() As InventoryExpenseIssueItemSerialCollection
                Get
                    If _myInventoryExpenseIssueItemSerialCollection Is Nothing Then
                        _myInventoryExpenseIssueItemSerialCollection = New InventoryExpenseIssueItemSerialCollection
                    End If
                    Return _myInventoryExpenseIssueItemSerialCollection
                End Get
            End Property

#End Region

            Public Function XmlElement(ByVal xmlDoc As Xml.XmlDocument) As Xml.XmlElement

                Dim BinLocation As System.Xml.XmlElement = xmlDoc.CreateElement("BinLocation")
                Dim FifoBucket As System.Xml.XmlElement = xmlDoc.CreateElement("FifoBucket")
                Dim Journal As System.Xml.XmlElement = xmlDoc.CreateElement("Journal")
                Dim LedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("LedgerCode")
                Dim Lot As System.Xml.XmlElement = xmlDoc.CreateElement("Lot")
                Dim Notation As System.Xml.XmlElement = xmlDoc.CreateElement("Notation")
                Dim PasswordForLedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("PasswordForLedgerCode")
                Dim Pieces As System.Xml.XmlElement = xmlDoc.CreateElement("Pieces")
                Dim Quantity As System.Xml.XmlElement = xmlDoc.CreateElement("Quantity")
                Dim Reference As System.Xml.XmlElement = xmlDoc.CreateElement("Reference")
                Dim Release As System.Xml.XmlElement = xmlDoc.CreateElement("Release")
                Dim SerialAllocation As System.Xml.XmlElement = xmlDoc.CreateElement("SerialAllocation")
                Dim FromSerialNumber As System.Xml.XmlElement = xmlDoc.CreateElement("FromSerialNumber")
                Dim ToSerialNumber As System.Xml.XmlElement = xmlDoc.CreateElement("ToSerialNumber")
                Dim SerialQuantity As System.Xml.XmlElement = xmlDoc.CreateElement("SerialQuantity")
                Dim StockCode As System.Xml.XmlElement = xmlDoc.CreateElement("StockCode")
                Dim UnitOfMeasure As System.Xml.XmlElement = xmlDoc.CreateElement("UnitOfMeasure")
                Dim Units As System.Xml.XmlElement = xmlDoc.CreateElement("Units")
                Dim Version As System.Xml.XmlElement = xmlDoc.CreateElement("Version")
                Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")

                Dim ItemElement As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
                Common.SysproUtilities.AppendXMLElement(ItemElement, Journal, _Journal.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Warehouse, _Warehouse.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, StockCode, _StockCode.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Version, _Version.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Release, _Release.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Quantity, _Quantity.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, UnitOfMeasure, _UnitOfMeasure.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Units, _Units.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Pieces, _Pieces.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, BinLocation, _BinLocation.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, FifoBucket, _FifoBucket.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, LedgerCode, _LedgerCode.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Lot, _Lot.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Reference, _Reference.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, Notation, _Notation.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, PasswordForLedgerCode, _PasswordForLedgerCode.ToString)
                Common.SysproUtilities.AppendXMLElement(ItemElement, SerialAllocation, _SerialAllocation.ToString)
                For Each serial As InventoryExpenseIssueItemSerial In Me.MyInventoryExpenseIssueItemSerialCollection
                    ItemElement.AppendChild(serial.XmlElement(xmlDoc))
                Next
                Common.SysproUtilities.AppendXMLElement(SerialAllocation, FromSerialNumber, _FromSerialNumber.ToString)
                Common.SysproUtilities.AppendXMLElement(SerialAllocation, ToSerialNumber, _ToSerialNumber.ToString)
                Common.SysproUtilities.AppendXMLElement(SerialAllocation, SerialQuantity, _SerialQuantity.ToString)

                Return ItemElement

            End Function

            <Serializable()> Public Class InventoryExpenseIssueItemSerial

#Region " Private Variables "
                Dim _SerialNumber As String = String.Empty
                Dim _SerialQuantity As String = String.Empty
                Dim _SerialUnits As String = String.Empty
                Dim _SerialPieces As String = String.Empty
                Dim _SerialExpiryDate As String = String.Empty
                Dim _SerialLocation As String = String.Empty
#End Region

#Region " Public Properties "
                ''' <summary> 
                '''  This element is optional and is only allowed if stock item is serialized. Used when processing a negative expense issue.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialExpiryDate() As String
                    Get
                        Return _SerialExpiryDate
                    End Get
                    Set(ByVal Value As String)
                        _SerialExpiryDate = Value
                    End Set
                End Property

                ''' <summary> 
                '''  This element is optional and is only allowed if stock item is serialized. Used when processing a negative expense issue.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialLocation() As String
                    Get
                        Return _SerialLocation
                    End Get
                    Set(ByVal Value As String)
                        _SerialLocation = Value
                    End Set
                End Property

                ''' <summary> 
                '''  Serial number from which serial quantity must be issued.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialNumber() As String
                    Get
                        Return _SerialNumber
                    End Get
                    Set(ByVal Value As String)
                        _SerialNumber = Value
                    End Set
                End Property

                ''' <summary> 
                '''  This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1 or -1. If within the 'SerialAllocation' group, it is the total quantity to be received for the specified range. The total quantity for all serial numbers specified must match the quantity specified for the transaction.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialQuantity() As String
                    Get
                        Return _SerialQuantity
                    End Get
                    Set(ByVal Value As String)
                        _SerialQuantity = Value
                    End Set
                End Property

                ''' <summary> 
                '''  If stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied in units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialUnits() As String
                    Get
                        Return _SerialUnits
                    End Get
                    Set(ByVal Value As String)
                        _SerialUnits = Value
                    End Set
                End Property

                ''' <summary> 
                '''  If stock item is a unit-qty type stock item and serialquantity element is not supplied, the quantity of the transaction must be supplied in units and pieces. At least one of these elements must be supplied. This element is only valid for batch serialized items.
                ''' </summary> 
                ''' <returns></returns> 
                ''' <remarks></remarks> 
                Public Property SerialPieces() As String
                    Get
                        Return _SerialPieces
                    End Get
                    Set(ByVal Value As String)
                        _SerialPieces = Value
                    End Set
                End Property
#End Region

                Public Function XmlElement(ByVal xmlDoc As Xml.XmlDocument) As Xml.XmlElement

                    Dim SerialExpiryDate As System.Xml.XmlElement = xmlDoc.CreateElement("SerialExpiryDate")
                    Dim SerialLocation As System.Xml.XmlElement = xmlDoc.CreateElement("SerialLocation")
                    Dim SerialNumber As System.Xml.XmlElement = xmlDoc.CreateElement("SerialNumber")
                    Dim SerialQuantity As System.Xml.XmlElement = xmlDoc.CreateElement("SerialQuantity")
                    Dim SerialUnits As System.Xml.XmlElement = xmlDoc.CreateElement("SerialUnits")
                    Dim SerialPieces As System.Xml.XmlElement = xmlDoc.CreateElement("SerialPieces")

                    Dim SerialsElement As System.Xml.XmlElement = xmlDoc.CreateElement("Serials")
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialExpiryDate, _SerialExpiryDate.ToString)
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialLocation, _SerialLocation.ToString)
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialNumber, _SerialNumber.ToString)
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialQuantity, _SerialQuantity.ToString)
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialUnits, _SerialUnits.ToString)
                    Common.SysproUtilities.AppendXMLElement(SerialsElement, SerialPieces, _SerialPieces.ToString)

                    Return SerialsElement

                End Function

            End Class

            <Serializable()> Public Class InventoryExpenseIssueItemSerialCollection
                Inherits Collections.Generic.List(Of InventoryExpenseIssueItemSerial)
            End Class

        End Class

        <Serializable()> Public Class InventoryExpenseIssueItemCollection
            Inherits Collections.Generic.List(Of InventoryExpenseIssueItem)
        End Class

#End Region

#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLData() As String

            Dim xmlDoc As New System.Xml.XmlDocument
            Dim PostInvExpenseIssues As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvExpenseIssues")

            xmlDoc.AppendChild(PostInvExpenseIssues)
            For Each item As InventoryExpenseIssueItem In MyInventoryExpenseIssueItemCollection
                PostInvExpenseIssues.AppendChild(item.XmlElement(xmlDoc))
            Next

            Return xmlDoc.OuterXml

        End Function

#End Region

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode
                Dim str As String = ""
                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Key/Journal")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    str = CDbl(xmlNode.InnerText)
                End If
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Key/EntryNumber")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    str &= ("/" & CDbl(xmlNode.InnerText))
                End If
                Return str

            End Get
        End Property

#Region " Interface "

        Private _actionType As CommonEnums.ActionType_Transaction
        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _actionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _actionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "INVTME"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            Select Case _actionType
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select
        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return ConstructXMLData()
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Return ConstructXMLParams()
            End Get
        End Property

#End Region

    End Class

End Namespace
