Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class InventoryCostChange
        Implements ITransaction

#Region " xmlParams "

#Region "Private Data Members"

        Dim _PostInvCostChange As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _ApplyIfEntireDocumentValid As InventoryCostChange_ApplyIfEntireDocumentValid_Enum = InventoryCostChange_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_Y
        Dim _IgnoreWarnings As InventoryCostChange_IgnoreWarnings_Enum = InventoryCostChange_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _TransactionDate As String = String.Empty
        Dim _validateOnly As InventoryCostChange_ValidateOnly_Enum = InventoryCostChange_ValidateOnly_Enum.ValidateOnly_Upper_N

#End Region

#Region "Public Properties"

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
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As InventoryCostChange_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As InventoryCostChange_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether or not a transaction must be rejected if there are any warnings such as cost variance exceeded or a zero cost supplied.If 'W' is supplied, error will be reported as a warning If not supplied it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As InventoryCostChange_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As InventoryCostChange_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  Date transaction raised. If not supplied, rundate is assumed.
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

        Public Property ValidateOnly() As InventoryCostChange_ValidateOnly_Enum
            Get
                Return _validateOnly
            End Get
            Set(ByVal value As InventoryCostChange_ValidateOnly_Enum)
                _validateOnly = value
            End Set
        End Property

#End Region

#Region "Enumerations"


        Public Enum InventoryCostChange_ValidateOnly_Enum
            ValidateOnly_Upper_Y
            ValidateOnly_Upper_N
        End Enum
        Public Enum InventoryCostChange_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_Y
            ApplyIfEntireDocumentValid_Upper_N
        End Enum
        Public Enum InventoryCostChange_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_W
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostInvCostChange As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvCostChange")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim TransactionDate As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionDate")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")

            xmlDoc.AppendChild(PostInvCostChange)
            Common.SysproUtilities.AppendXMLElement(PostInvCostChange, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, TransactionDate, _TransactionDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_validateOnly.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region

#End Region

#Region " xmlData "

#Region "Private Data Members"

        Dim _FifoBucket As String = String.Empty
        Dim _Item As String = String.Empty
        Dim _Journal As String = String.Empty
        Dim _LedgerCode As String = String.Empty
        Dim _NewTotalCost As String = String.Empty
        Dim _NewUnitCost As String = String.Empty
        Dim _Notation As String = String.Empty
        Dim _PasswordForLedgerCode As String = String.Empty
        Dim _Reference As String = String.Empty
        Dim _StockCode As String = String.Empty
        Dim _UpdateLastCost As InventoryCostChange_UpdateLastCost_Enum = InventoryCostChange_UpdateLastCost_Enum.UpdateLastCost_Upper_Y
        Dim _Warehouse As String = String.Empty

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This element is optional. It must be supplied if FIFO is installed or FIFO/LIFO costing is used.
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
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostInvCostChange() As String
            Get
                Return _PostInvCostChange
            End Get
            Set(ByVal Value As String)
                _PostInvCostChange = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the top element for all data required to post the transaction.
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
        '''  This is the journal number to which the transaction journal entries generated will be added. It must be valid for the current posting period and warehouse and may not have been printed already. If not supplied, a new journal will be created.
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
        '''  This element is only used if Inventory is integrated to General Ledger or requires a Report, and ledger codes are required for this type of inventory transaction.
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
        '''  New cost of the total quantity on hand in the warehouse for this stock code. The new unit cost will be calculated. Only one of the costs may be supplied. The transaction will be rejected if both are supplied or if the cost supplied is zero and the 'IgnoreWarnings' parameter is set to 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property NewTotalCost() As String
            Get
                Return _NewTotalCost
            End Get
            Set(ByVal Value As String)
                _NewTotalCost = Value
            End Set
        End Property

        ''' <summary> 
        '''  New unit cost of the specified stock code. Only one of the costs may be supplied. The transaction will be rejected if both are supplied or if the cost supplied is zero and the 'IgnoreWarnings' parameter is set to 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property NewUnitCost() As String
            Get
                Return _NewUnitCost
            End Get
            Set(ByVal Value As String)
                _NewUnitCost = Value
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
        '''  If ledger codes required a password, this element must contain the relevant password for this ledger code.
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
        '''  This element is mandatory and must contain a valid stock code stocked in the specified warehouse.
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
        '''  This element indicates whether or not the last warehouse cost must be updated to the new unit cost. If not supplied it defaults to 'Y'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UpdateLastCost() As InventoryCostChange_UpdateLastCost_Enum
            Get
                Return _UpdateLastCost
            End Get
            Set(ByVal Value As InventoryCostChange_UpdateLastCost_Enum)
                _UpdateLastCost = Value
            End Set
        End Property

        ''' <summary>
        ''' This element is mandatory and must stock the specified stock code.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Warehouse() As String
            Get
                Return _Warehouse
            End Get
            Set(ByVal value As String)
                _Warehouse = value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum InventoryCostChange_UpdateLastCost_Enum
            UpdateLastCost_Upper_Y
            UpdateLastCost_Upper_N
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim FifoBucket As System.Xml.XmlElement = xmlDoc.CreateElement("FifoBucket")
            Dim PostInvCostChange As System.Xml.XmlElement = xmlDoc.CreateElement("PostInvCostChange")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim Journal As System.Xml.XmlElement = xmlDoc.CreateElement("Journal")
            Dim LedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("LedgerCode")
            Dim NewTotalCost As System.Xml.XmlElement = xmlDoc.CreateElement("NewTotalCost")
            Dim NewUnitCost As System.Xml.XmlElement = xmlDoc.CreateElement("NewUnitCost")
            Dim Notation As System.Xml.XmlElement = xmlDoc.CreateElement("Notation")
            Dim PasswordForLedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("PasswordForLedgerCode")
            Dim Reference As System.Xml.XmlElement = xmlDoc.CreateElement("Reference")
            Dim StockCode As System.Xml.XmlElement = xmlDoc.CreateElement("StockCode")
            Dim UpdateLastCost As System.Xml.XmlElement = xmlDoc.CreateElement("UpdateLastCost")
            Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")

            xmlDoc.AppendChild(PostInvCostChange)
            Common.SysproUtilities.AppendXMLElement(PostInvCostChange, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Warehouse, _Warehouse.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, StockCode, _StockCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, FifoBucket, _FifoBucket.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Journal, _Journal.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, LedgerCode, _LedgerCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, NewTotalCost, _NewTotalCost)
            If IsNumeric(_NewUnitCost) Then
                Common.SysproUtilities.AppendXMLElement(Item, NewUnitCost, Format(CDbl(_NewUnitCost), "#.00000"))
            Else
                Common.SysproUtilities.AppendXMLElement(Item, NewUnitCost, "0")
            End If
            Common.SysproUtilities.AppendXMLElement(Item, Notation, _Notation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PasswordForLedgerCode, _PasswordForLedgerCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Reference, _Reference.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UpdateLastCost, Common.SysproUtilities.GetEnumValue(_UpdateLastCost.ToString))

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

#End Region

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
                Return "INVTMC"
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
                Return ConstructXML()
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
                Return ConstructXMLParam()
            End Get
        End Property

#End Region

    End Class

End Namespace
