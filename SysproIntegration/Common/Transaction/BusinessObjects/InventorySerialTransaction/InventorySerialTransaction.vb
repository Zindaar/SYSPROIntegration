Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class InventorySerialTransaction
        Implements ITransaction

#Region " Params "

#Region "Private Data Members"

        Dim _PostInvSerialTransactions As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _IgnoreWarnings As InventorySerialTransaction_IgnoreWarnings_Enum = InventorySerialTransaction_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _ApplyIfEntireDocumentValid As InventorySerialTransaction_ApplyIfEntireDocumentValid_Enum = InventorySerialTransaction_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_Y
        Dim _ValidateOnly As InventorySerialTransaction_ValidateOnly_Enum = InventorySerialTransaction_ValidateOnly_Enum.ValidateOnly_Upper_N

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the root element
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostInvSerialTransactions() As String
            Get
                Return _PostInvSerialTransactions
            End Get
            Set(ByVal Value As String)
                _PostInvSerialTransactions = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element contains the optional parameter elements.
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
        '''  Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a customer specified for a transaction doesnt exist on the customer master file, it is okay to write the transaction but you may want the warning supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As InventorySerialTransaction_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As InventorySerialTransaction_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As InventorySerialTransaction_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As InventorySerialTransaction_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        Public Property ValidateOnly() As InventorySerialTransaction_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As InventorySerialTransaction_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum InventorySerialTransaction_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
        End Enum
        Public Enum InventorySerialTransaction_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_Y
            ApplyIfEntireDocumentValid_Upper_N
        End Enum
        Public Enum InventorySerialTransaction_ValidateOnly_Enum
            ValidateOnly_Upper_Y
            ValidateOnly_Upper_N
        End Enum

#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostInvSerialTransactions As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvSerialTransactions")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")

            xmlDoc.AppendChild(PostInvSerialTransactions)
            Common.SysproUtilities.AppendXMLElement(PostInvSerialTransactions, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region

#End Region

#Region " Data "

#Region "Private Data Members"

        Dim _Item As String = String.Empty
        Dim _TransactionType As InventorySerialTransaction_TransactionType_Enum
        Dim _TransactionCode As InventorySerialTransaction_Enum
        Dim _SerialNumber As String = String.Empty
        Dim _Warehouse As String = String.Empty
        Dim _TransactionDate As String = String.Empty
        Dim _Reference As String = String.Empty
        Dim _Notation As String = String.Empty
        Dim _Quantity As String = String.Empty
        Dim _Units As String = String.Empty
        Dim _Pieces As String = String.Empty
        Dim _Value As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _CustomerName As String = String.Empty
        Dim _Supplier As String = String.Empty
        Dim _SupplierName As String = String.Empty
        Dim _NewLocation As String = String.Empty
        Dim _NewWarehouse As String = String.Empty
        Dim _Job As String = String.Empty
        Dim _RevisionRef As String = String.Empty
        Dim _DueDate As String = String.Empty
        Dim _ExpiryDate As String = String.Empty

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the top element for all data required for the transaction.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Item() As String
            Get
                Return _Item
            End Get
            Set(ByVal Value As String)
                _Item = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. Enter the transaction type. 'S' = Standard, 'M' = Miscellaneous
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TransactionType() As InventorySerialTransaction_TransactionType_Enum
            Get
                Return _TransactionType
            End Get
            Set(ByVal Value As InventorySerialTransaction_TransactionType_Enum)
                _TransactionType = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. For a Standard transaction type, this Transaction Code must be one of the standard codes listed as an enumeration, for a Miscellaneous transaction type, this Transaction Code must be any code up to 6 characters, other than one of the standard codes.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TransactionCode() As InventorySerialTransaction_Enum
            Get
                Return _TransactionCode
            End Get
            Set(ByVal Value As InventorySerialTransaction_Enum)
                _TransactionCode = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. Serial number the transaction is against. The format is up to 20 characters alphanumeric, or 15 characters numeric depending on a configuration option within SYSPRO. 
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
        '''  The warehouse the serial number is in. The format is 2 characters alphanumeric. If the transaction is for a Batch type serial number, this element is mandatory and must be valid. If it is for a Manual type serial number, and the element is given, it must match the warehouse on file that the serial number is located in, if not given, the warehouse on file is used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal Value As String)
                _Warehouse = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. If this element is not supplied or if zeroes are entered against this element, the current system date will be used as the default. The format is CCYY-MM-DD.
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
        '''  Optional element. The format is 15 characters alphanumeric.
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
        '''  Optional element. The format is 45 characters alphanumeric.
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
        '''  If a manual serial number is being used the quantity is dependent on the Transaction Code. The number of decimals entered must match the number of decimals setup against the stock code.
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
        '''  If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. Units cannot be negative unless the TransactionCode is SALES or the TransactionType is M. This element is only applicable to batch serial numbers. 
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
        '''  If stock item is a unit-qty type stock item and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied. Pieces cannot be negative unless the TransactionCode is SALES or the TransactionType is M. This element is only applicable to batch serial numbers. 
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
        '''  Optional element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Value() As String
            Get
                Return _Value
            End Get
            Set(ByVal Value As String)
                _Value = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is up to 7 characters alphanumeric or numeric depending on a configuration option within SYSPRO. This element is available but not mandatory for a miscellaneous transaction type. It is mandatory for a "LOAN" transaction code, and for a "SALES" transaction code if the Quantity is not less than zero. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal Value As String)
                _Customer = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 30 characters alphanumeric. Should the customer given be valid on the customer master file, the customer name from the master file will be used. If the customer is not found on file, this name will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerName() As String
            Get
                Return _CustomerName
            End Get
            Set(ByVal Value As String)
                _CustomerName = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is up to 7 characters alphanumeric or numeric depending on a configuration option within SYSPRO. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Supplier() As String
            Get
                Return _Supplier
            End Get
            Set(ByVal Value As String)
                _Supplier = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 30 characters alphanumeric. Should the supplier given be valid on the supplier master file, the supplier name from the master file will be used. If the supplier is not found on file, this name will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SupplierName() As String
            Get
                Return _SupplierName
            End Get
            Set(ByVal Value As String)
                _SupplierName = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 8 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property NewLocation() As String
            Get
                Return _NewLocation
            End Get
            Set(ByVal Value As String)
                _NewLocation = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 2 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property NewWarehouse() As String
            Get
                Return _NewWarehouse
            End Get
            Set(ByVal Value As String)
                _NewWarehouse = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 8 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Job() As String
            Get
                Return _Job
            End Get
            Set(ByVal Value As String)
                _Job = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is 6 characters alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RevisionRef() As String
            Get
                Return _RevisionRef
            End Get
            Set(ByVal Value As String)
                _RevisionRef = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is CCYY-MM-DD.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DueDate() As String
            Get
                Return _DueDate
            End Get
            Set(ByVal Value As String)
                _DueDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. The format is CCYY-MM-DD.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ExpiryDate() As String
            Get
                Return _ExpiryDate
            End Get
            Set(ByVal Value As String)
                _ExpiryDate = Value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum InventorySerialTransaction_TransactionType_Enum
            TransactionType_Upper_S
            TransactionType_Upper_M
        End Enum
        Public Enum InventorySerialTransaction_Enum
            SALES
            MAINT
            SRVIN
            SRVRET
            LOAN
            RETURN_
            TRA
            REC
            NOTE
            WARR
            MOVE
            DEPOT
            DEPRET
            ISS
            PHY
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostInvSerialTransactions As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvSerialTransactions")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim TransactionType As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionType")
            Dim TransactionCode As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionCode")
            Dim SerialNumber As System.Xml.XmlElement = xmlDoc.CreateElement("SerialNumber")
            Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")
            Dim TransactionDate As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionDate")
            Dim Reference As System.Xml.XmlElement = xmlDoc.CreateElement("Reference")
            Dim Notation As System.Xml.XmlElement = xmlDoc.CreateElement("Notation")
            Dim Quantity As System.Xml.XmlElement = xmlDoc.CreateElement("Quantity")
            Dim Units As System.Xml.XmlElement = xmlDoc.CreateElement("Units")
            Dim Pieces As System.Xml.XmlElement = xmlDoc.CreateElement("Pieces")
            Dim Value As System.Xml.XmlElement = xmlDoc.CreateElement("Value")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim CustomerName As System.Xml.XmlElement = xmlDoc.CreateElement("CustomerName")
            Dim Supplier As System.Xml.XmlElement = xmlDoc.CreateElement("Supplier")
            Dim SupplierName As System.Xml.XmlElement = xmlDoc.CreateElement("SupplierName")
            Dim NewLocation As System.Xml.XmlElement = xmlDoc.CreateElement("NewLocation")
            Dim NewWarehouse As System.Xml.XmlElement = xmlDoc.CreateElement("NewWarehouse")
            Dim Job As System.Xml.XmlElement = xmlDoc.CreateElement("Job")
            Dim RevisionRef As System.Xml.XmlElement = xmlDoc.CreateElement("RevisionRef")
            Dim DueDate As System.Xml.XmlElement = xmlDoc.CreateElement("DueDate")
            Dim ExpiryDate As System.Xml.XmlElement = xmlDoc.CreateElement("ExpiryDate")

            xmlDoc.AppendChild(PostInvSerialTransactions)
            Common.SysproUtilities.AppendXMLElement(PostInvSerialTransactions, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, TransactionType, Common.SysproUtilities.GetEnumValue(_TransactionType.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, TransactionCode, _TransactionCode.ToString.Replace("_", ""))
            Common.SysproUtilities.AppendXMLElement(Item, SerialNumber, _SerialNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Warehouse, _Warehouse.ToString)
            If IsDate(_TransactionDate) Then
                Common.SysproUtilities.AppendXMLElement(Item, TransactionDate, Format(CDate(_TransactionDate), "yyyy-MM-dd"))
            End If
            Common.SysproUtilities.AppendXMLElement(Item, Reference, _Reference.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Notation, _Notation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Quantity, _Quantity.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Units, _Units.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Pieces, _Pieces.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Value, _Value.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, CustomerName, _CustomerName.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Supplier, _Supplier.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SupplierName, _SupplierName.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, NewLocation, _NewLocation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, NewWarehouse, _NewWarehouse.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Job, _Job.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RevisionRef, _RevisionRef.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DueDate, _DueDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, ExpiryDate, _ExpiryDate.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region


#End Region

#Region " Transaction Interface "

        Private _actiontype As CommonEnums.ActionType_Transaction = CommonEnums.ActionType_Transaction.Post
        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _actiontype
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _actiontype = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "INVTSR"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            Select Case _actiontype
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select
        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Private _xmlOut As String = ""

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Return ConstructXMLParam()
            End Get
        End Property

#End Region

    End Class

End Namespace
