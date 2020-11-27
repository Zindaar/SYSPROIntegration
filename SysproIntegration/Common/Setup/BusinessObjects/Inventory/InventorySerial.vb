Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace SetupObjects
    <Serializable()> Public Class InventorySerial
        Implements ISetup

#Region " Params "

#Region "Private Data Members"

        Dim _SetupInvSerialHead As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _IgnoreWarnings As SetupInvSerialHead_IgnoreWarnings_Enum = SetupInvSerialHead_IgnoreWarnings_Enum.IgnoreWarnings_Upper_Y
        Dim _ApplyIfEntireDocumentValid As SetupInvSerialHead_ApplyIfEntireDocumentValid_Enum = SetupInvSerialHead_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_N
        Dim _ValidateOnly As SetupInvSerialHead_ValidateOnly_Enum = SetupInvSerialHead_ValidateOnly_Enum.ValidateOnly_Upper_N
        Dim _Notation As String = String.Empty
        Dim _UnitQuantities As SetupInvSerialHead_UnitQuantities_Enum = SetupInvSerialHead_UnitQuantities_Enum.UnitQuantities_Reject

#End Region

#Region "Public Properties"

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
        '''  Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a batch serial number already exists for the stock code in another warehouse, it is okay to write the record away as such but you may want the warning supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As SetupInvSerialHead_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As SetupInvSerialHead_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'N'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As SetupInvSerialHead_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As SetupInvSerialHead_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As SetupInvSerialHead_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As SetupInvSerialHead_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

        ''' <summary> 
        '''  A notation may be given to be saved against each transaction record.
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
        '''  This element is used to determine how the quantity for a units/pieces item is treated. Possible values are 'Reject' and 'Round'. If the 'QtyReceived' element supplied does not convert to a valid number of units and pieces, the transaction will either be rejected or updated with the nearest valid quantity after conversion.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UnitQuantities() As SetupInvSerialHead_UnitQuantities_Enum
            Get
                Return _UnitQuantities
            End Get
            Set(ByVal Value As SetupInvSerialHead_UnitQuantities_Enum)
                _UnitQuantities = Value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum SetupInvSerialHead_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_N
        End Enum
        Public Enum SetupInvSerialHead_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_N
            ApplyIfEntireDocumentValid_Upper_Y
        End Enum
        Public Enum SetupInvSerialHead_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum
        Public Enum SetupInvSerialHead_UnitQuantities_Enum
            UnitQuantities_Reject
            UnitQuantities_Round
        End Enum

#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim SetupInvSerialHead As System.Xml.XmlElement = xmlDoc.CreateElement("SetupInvSerialHead")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")
            Dim Notation As System.Xml.XmlElement = xmlDoc.CreateElement("Notation")
            Dim UnitQuantities As System.Xml.XmlElement = xmlDoc.CreateElement("UnitQuantities")

            xmlDoc.AppendChild(SetupInvSerialHead)
            Common.SysproUtilities.AppendXMLElement(SetupInvSerialHead, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, Notation, _Notation.ToString)
            If _UnitQuantities = SetupInvSerialHead_UnitQuantities_Enum.UnitQuantities_Reject Then
                Common.SysproUtilities.AppendXMLElement(Parameters, UnitQuantities, "Reject")
            Else
                Common.SysproUtilities.AppendXMLElement(Parameters, UnitQuantities, "Round")
            End If

            Return xmlDoc.OuterXml

        End Function

#End Region

#End Region

#Region " Data "

#Region "Private Data Members"

        Dim _Item As String = String.Empty
        Dim _Key As String = String.Empty
        Dim _Serial As String = String.Empty
        Dim _StockCode As String = String.Empty
        Dim _Warehouse As String = String.Empty
        Dim _SerialDescription As String = String.Empty
        Dim _ExpiryDate As String = String.Empty
        Dim _ScrapDate As String = String.Empty
        Dim _QtyReceived As String = String.Empty
        Dim _Location As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _Version As String = String.Empty
        Dim _Release As String = String.Empty

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the root element
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SetupInvSerialHead() As String
            Get
                Return _SetupInvSerialHead
            End Get
            Set(ByVal Value As String)
                _SetupInvSerialHead = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element contains information to maintain a serial number. NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete. 
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
        '''  This element contains the key information required to maintain a serial number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Key() As String
            Get
                Return _Key
            End Get
            Set(ByVal Value As String)
                _Key = Value
            End Set
        End Property

        ''' <summary> 
        '''  Serial number being maintained. The format is up to 20 characters alphanumeric, or 15 characters numeric depending on a configuration option within SYSPRO. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Serial() As String
            Get
                Return _Serial
            End Get
            Set(ByVal Value As String)
                _Serial = Value
            End Set
        End Property

        ''' <summary> 
        '''  Stock code to which the serial number being added. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within SYSPRO. The stock code must have serials required set on in stock code setup. This element is mandatory for an Add function, and cannot be maintained in an Update function.
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
        '''  The warehouse being Added/Maintained or Deleted for Serial number. The format is 2 characters alphanumeric. 
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
        '''  This is the stock description to appear against the serial number. The format is 30 characters, alphanumeric.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SerialDescription() As String
            Get
                Return _SerialDescription
            End Get
            Set(ByVal Value As String)
                _SerialDescription = Value
            End Set
        End Property

        ''' <summary> 
        '''  Expiry date. Zero indicates no expiry date. The format is CCYY-MM-DD.
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

        ''' <summary> 
        '''  Scrap date. Zero indicates no scrap date. The format is CCYY-MM-DD.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ScrapDate() As String
            Get
                Return _ScrapDate
            End Get
            Set(ByVal Value As String)
                _ScrapDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  If a manual serial number is being added the quantity may only be 1 or zero. The number of decimals entered must match the number of decimals setup against the stock code. This element cannot be maintained in an Update function.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property QtyReceived() As String
            Get
                Return _QtyReceived
            End Get
            Set(ByVal Value As String)
                _QtyReceived = Value
            End Set
        End Property

        ''' <summary> 
        '''  The location indicates where the serialized item is stored. This element cannot be maintained in an Update function.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Location() As String
            Get
                Return _Location
            End Get
            Set(ByVal Value As String)
                _Location = Value
            End Set
        End Property

        ''' <summary> 
        '''  You can only access the customer field if you are taking on a manual serial number and the quantity is zero. The format is up to 7 characters, alphanumeric or numeric depending on a configuration option within SYSPRO. This element cannot be maintained in an Update function.
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
        '''  This element is mandatory if adding a serial number for a stock code that is ECC-controlled at version or release level. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup. This element cannot be maintained in an Update function.
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

        ''' <summary> 
        '''  This element is mandatory if adding a serial number for a stock code that is ECC-controlled at version or release level. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup. This element cannot be maintained in an Update function.
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

#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim SetupInvSerialHead As System.Xml.XmlElement = xmlDoc.CreateElement("SetupInvSerialHead")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim Key As System.Xml.XmlElement = xmlDoc.CreateElement("Key")
            Dim Serial As System.Xml.XmlElement = xmlDoc.CreateElement("Serial")
            Dim StockCode As System.Xml.XmlElement = xmlDoc.CreateElement("StockCode")
            Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")
            Dim SerialDescription As System.Xml.XmlElement = xmlDoc.CreateElement("SerialDescription")
            Dim ExpiryDate As System.Xml.XmlElement = xmlDoc.CreateElement("ExpiryDate")
            Dim ScrapDate As System.Xml.XmlElement = xmlDoc.CreateElement("ScrapDate")
            Dim QtyReceived As System.Xml.XmlElement = xmlDoc.CreateElement("QtyReceived")
            Dim Location As System.Xml.XmlElement = xmlDoc.CreateElement("Location")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim Version As System.Xml.XmlElement = xmlDoc.CreateElement("Version")
            Dim Release As System.Xml.XmlElement = xmlDoc.CreateElement("Release")

            xmlDoc.AppendChild(SetupInvSerialHead)
            Common.SysproUtilities.AppendXMLElement(SetupInvSerialHead, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Key, _Key.ToString)
            Common.SysproUtilities.AppendXMLElement(Key, Serial, _Serial.ToString)
            Common.SysproUtilities.AppendXMLElement(Key, StockCode, _StockCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Key, Warehouse, _Warehouse.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SerialDescription, _SerialDescription.ToString)
            If String.IsNullOrEmpty(_ExpiryDate) Then
                Common.SysproUtilities.AppendXMLElement(Item, ExpiryDate, "")
            Else
                Common.SysproUtilities.AppendXMLElement(Item, ExpiryDate, Format(_ExpiryDate, "yyyy-MM-dd"))
            End If
            If String.IsNullOrEmpty(_ScrapDate) Then
                Common.SysproUtilities.AppendXMLElement(Item, ScrapDate, "")
            Else
                Common.SysproUtilities.AppendXMLElement(Item, ScrapDate, Format(_ScrapDate, "yyyy-MM-dd"))
            End If
            Common.SysproUtilities.AppendXMLElement(Item, QtyReceived, _QtyReceived.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Location, _Location.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Version, _Version.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Release, _Release.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region

#End Region

#Region " ISetup Interface "

        Dim _actionType As CommonEnums.ActionType_Setup
        Public Property ActionType() As CommonEnums.ActionType_Setup Implements ISetup.ActionType
            Get
                Return _actionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Setup)
                _actionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "INVSSR"
            End Get
        End Property

        Public Sub Post() Implements ISetup.Post
            Select Case _actionType
                Case CommonEnums.ActionType_Setup.Add
                    _xmlOut = Setup.Add(Me)
                Case CommonEnums.ActionType_Setup.Delete
                    _xmlOut = Setup.Delete(Me)
                Case CommonEnums.ActionType_Setup.Update
                    _xmlOut = Setup.Update(Me)
            End Select
        End Sub

        Public ReadOnly Property xmlData() As String Implements ISetup.xmlData
            Get
                Return Me.ConstructXML
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ISetup.xmlParam
            Get
                Return Me.ConstructXMLParam
            End Get
        End Property

#End Region

    End Class

End Namespace
