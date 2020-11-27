Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class ChangeSalesOrderStatus
        Implements ITransaction

#Region " Param Members "
#Region "Private Data Members"

        Dim _Parameters As String = String.Empty
        Dim _ApplyIfEntireDocumentValid As ChangeSalesOrderStatusParam_ApplyIfEntireDocumentValid_Enum
        Dim _ValidateOnly As ChangeSalesOrderStatusParam_ValidateOnly_Enum = ChangeSalesOrderStatusParam_ValidateOnly_Enum.ValidateOnly_Upper_N
        Dim _AllowInvoiceInformationEntry As ChangeSalesOrderStatusParam_AllowInvoiceInformationEntry_Enum = ChangeSalesOrderStatusParam_AllowInvoiceInformationEntry_Enum.AllowInvoiceInformationEntry_Upper_N
        Dim _InBoxMsgReqd As ChangeSalesOrderStatusParam_InBoxMsgReqd_Enum = ChangeSalesOrderStatusParam_InBoxMsgReqd_Enum.InBoxMsgReqd_Upper_N
        Dim _IgnoreWarnings As ChangeSalesOrderStatusParam_IgnoreWarnings_Enum = ChangeSalesOrderStatusParam_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _ParamPostSorOrderStatus As String = String.Empty


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
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'N'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As ChangeSalesOrderStatusParam_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As ChangeSalesOrderStatusParam_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether to Validate or Post the document to SYSPRO
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As ChangeSalesOrderStatusParam_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As ChangeSalesOrderStatusParam_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

        ''' <summary> 
        '''  Specifies whether invoice information (invoice number and invoice date) may be entered for an order that is to be changed to ready to invoice, status 8 (Y - Yes, N - No). If set, this overrides any other SYSPRO configuration rules for supplying invoice numbers. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AllowInvoiceInformationEntry() As ChangeSalesOrderStatusParam_AllowInvoiceInformationEntry_Enum
            Get
                Return _AllowInvoiceInformationEntry
            End Get
            Set(ByVal Value As ChangeSalesOrderStatusParam_AllowInvoiceInformationEntry_Enum)
                _AllowInvoiceInformationEntry = Value
            End Set
        End Property

        ''' <summary> 
        '''  Write an entry to the ADMMSG file for the logged in operator (N or blank - No, Y - Yes). This message is made available in the Orders Created Externally option of SYSPRO. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InBoxMsgReqd() As ChangeSalesOrderStatusParam_InBoxMsgReqd_Enum
            Get
                Return _InBoxMsgReqd
            End Get
            Set(ByVal Value As ChangeSalesOrderStatusParam_InBoxMsgReqd_Enum)
                _InBoxMsgReqd = Value
            End Set
        End Property

        ''' <summary> 
        '''  Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned, W - warnings will be returned as warnings in the XML returned).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As ChangeSalesOrderStatusParam_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As ChangeSalesOrderStatusParam_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ParamPostSorOrderStatus() As String
            Get
                Return _ParamPostSorOrderStatus
            End Get
            Set(ByVal Value As String)
                _ParamPostSorOrderStatus = Value
            End Set
        End Property


#Region "Enumerations"

        Public Enum ChangeSalesOrderStatusParam_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_N
            ApplyIfEntireDocumentValid_Upper_Y
        End Enum
        Public Enum ChangeSalesOrderStatusParam_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum
        Public Enum ChangeSalesOrderStatusParam_AllowInvoiceInformationEntry_Enum
            AllowInvoiceInformationEntry_Upper_N
            AllowInvoiceInformationEntry_Upper_Y
        End Enum
        Public Enum ChangeSalesOrderStatusParam_InBoxMsgReqd_Enum
            InBoxMsgReqd_Upper_N
            InBoxMsgReqd_Upper_Y
        End Enum
        Public Enum ChangeSalesOrderStatusParam_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_W
            IgnoreWarnings_Upper_
        End Enum

        Private Function ConstructParamXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")
            Dim AllowInvoiceInformationEntry As System.Xml.XmlElement = xmlDoc.CreateElement("AllowInvoiceInformationEntry")
            Dim InBoxMsgReqd As System.Xml.XmlElement = xmlDoc.CreateElement("InBoxMsgReqd")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim PostSorOrderStatus As System.Xml.XmlElement = xmlDoc.CreateElement("PostSorOrderStatus")

            Common.SysproUtilities.AppendXMLElement(PostSorOrderStatus, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, AllowInvoiceInformationEntry, Common.SysproUtilities.GetEnumValue(_AllowInvoiceInformationEntry.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, InBoxMsgReqd, Common.SysproUtilities.GetEnumValue(_InBoxMsgReqd.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            xmlDoc.AppendChild(PostSorOrderStatus)

            Return xmlDoc.OuterXml

        End Function


#End Region


#End Region
#End Region

#Region "Private Data Members"

        Dim _ChangeFwdOrderToSched As ChangeSalesOrderStatus_ChangeFwdOrderToSched_Enum = ChangeSalesOrderStatus_ChangeFwdOrderToSched_Enum.ChangeFwdOrderToSched_Upper_N
        Dim _CreditAuthority As String = String.Empty
        Dim _DateDeliveryNotePrinted As String = String.Empty
        Dim _DeliveryNoteNumber As String = String.Empty
        Dim _InvoiceDateEntered As String = String.Empty
        Dim _InvoiceNumberEntered As String = String.Empty
        Dim _Item As String = String.Empty
        Dim _NewOrderStatus As ChangeSalesOrderStatus_NewOrderStatus_Enum
        Dim _OrderStatus As ChangeSalesOrderStatus_OrderStatus_Enum
        Dim _PostSorOrderStatus As String = String.Empty
        Dim _SalesOrder As String = String.Empty
        Dim _SctReference As String = String.Empty

        'Return Value
        Dim _ReturnValue As String = String.Empty


#End Region

#Region "Public Properties"

        'Return Value
        Public Property ReturnValue() As String
            Get
                Return _ReturnValue
            End Get
            Set(ByVal value As String)
                _ReturnValue = value
            End Set
        End Property

        ''' <summary> 
        '''  This element is only required when changing the status of a forward order. The valid entries are N (the default) and Y. If set to Y then the forward order will be converted to a scheduled order.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ChangeFwdOrderToSched() As ChangeSalesOrderStatus_ChangeFwdOrderToSched_Enum
            Get
                Return _ChangeFwdOrderToSched
            End Get
            Set(ByVal Value As ChangeSalesOrderStatus_ChangeFwdOrderToSched_Enum)
                _ChangeFwdOrderToSched = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element must contain a credit authority entry if the order is being released from suspense.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CreditAuthority() As String
            Get
                Return _CreditAuthority
            End Get
            Set(ByVal Value As String)
                _CreditAuthority = Value
            End Set
        End Property

        ''' <summary> 
        '''  The date delivery note printed may only be supplied if the sales order is to be changed to a status of 4. The format is CCYY-MM-DD. If not supplied then the current date will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DateDeliveryNotePrinted() As String
            Get
                Return _DateDeliveryNotePrinted
            End Get
            Set(ByVal Value As String)
                _DateDeliveryNotePrinted = Value
            End Set
        End Property

        ''' <summary> 
        '''  The delivery note number may only be supplied if the sales order is to be changed to a status of 4. It may only be supplied if the SYSPRO configuration rules allow it to be supplied. The entry must follow the SYSPRO configuration rules for the type of delivery note number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DeliveryNoteNumber() As String
            Get
                Return _DeliveryNoteNumber
            End Get
            Set(ByVal Value As String)
                _DeliveryNoteNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  The invoice date may only be supplied if the sales order is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The format is CCYY-MM-DD.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceDateEntered() As String
            Get
                Return _InvoiceDateEntered
            End Get
            Set(ByVal Value As String)
                _InvoiceDateEntered = Value
            End Set
        End Property

        ''' <summary> 
        '''  The invoice number may only be supplied if the sales order is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The entry must follow the SYSPRO configuration rules for the type of invoice number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceNumberEntered() As String
            Get
                Return _InvoiceNumberEntered
            End Get
            Set(ByVal Value As String)
                _InvoiceNumberEntered = Value
            End Set
        End Property

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
        '''  This element is mandatory. It must contain the new status for the selected sales order. The SYSPRO configuration rules will be used to validate the correct combination of existing order type and status, and the new order status requested. Valid status codes for a sales order are:- 1 - Open order, 2 - Open back order, 3 - Released back order, 4 - In warehouse (delivery note printed), 8 - Released for invoicing (or ready to transfer for an SCT), 9 - Complete, S - In suspense.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property NewOrderStatus() As ChangeSalesOrderStatus_NewOrderStatus_Enum
            Get
                Return _NewOrderStatus
            End Get
            Set(ByVal Value As ChangeSalesOrderStatus_NewOrderStatus_Enum)
                _NewOrderStatus = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element is optional. If entered, then it must contain the current status of the order selected.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderStatus() As ChangeSalesOrderStatus_OrderStatus_Enum
            Get
                Return _OrderStatus
            End Get
            Set(ByVal Value As ChangeSalesOrderStatus_OrderStatus_Enum)
                _OrderStatus = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the root element
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostSorOrderStatus() As String
            Get
                Return _PostSorOrderStatus
            End Get
            Set(ByVal Value As String)
                _PostSorOrderStatus = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element is mandatory and must contain a valid sales order number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property

        ''' <summary> 
        '''  The SCT reference may only be supplied if the sales order is an SCT order, and is to be changed to a status of 8. It may only be supplied if the SYSPRO configuration rules allow it to be supplied, or if the parameter AllowInvoiceInformationEntry is set. The entry must follow the SYSPRO configuration rules for the type of SCT reference number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SctReference() As String
            Get
                Return _SctReference
            End Get
            Set(ByVal Value As String)
                _SctReference = Value
            End Set
        End Property



#End Region

#Region "Enumerations"

        Public Enum ChangeSalesOrderStatus_ChangeFwdOrderToSched_Enum
            ChangeFwdOrderToSched_Upper_N
            ChangeFwdOrderToSched_Upper_Y
        End Enum
        Public Enum ChangeSalesOrderStatus_NewOrderStatus_Enum
            NewOrderStatus_1
            NewOrderStatus_2
            NewOrderStatus_3
            NewOrderStatus_4
            NewOrderStatus_8
            NewOrderStatus_Upper_S
        End Enum
        Public Enum ChangeSalesOrderStatus_OrderStatus_Enum
            OrderStatus_1
            OrderStatus_2
            OrderStatus_3
            OrderStatus_4
            OrderStatus_8
            OrderStatus_Upper_F
            OrderStatus_Upper_S
            OrderStatus_Upper_
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim ChangeFwdOrderToSched As System.Xml.XmlElement = xmlDoc.CreateElement("ChangeFwdOrderToSched")
            Dim CreditAuthority As System.Xml.XmlElement = xmlDoc.CreateElement("CreditAuthority")
            Dim DateDeliveryNotePrinted As System.Xml.XmlElement = xmlDoc.CreateElement("DateDeliveryNotePrinted")
            Dim DeliveryNoteNumber As System.Xml.XmlElement = xmlDoc.CreateElement("DeliveryNoteNumber")
            Dim InvoiceDateEntered As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceDateEntered")
            Dim InvoiceNumberEntered As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceNumberEntered")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim NewOrderStatus As System.Xml.XmlElement = xmlDoc.CreateElement("NewOrderStatus")
            ' Dim OrderStatus As System.Xml.XmlElement = xmlDoc.CreateElement("OrderStatus")
            Dim PostSorOrderStatus As System.Xml.XmlElement = xmlDoc.CreateElement("PostSorOrderStatus")
            Dim SalesOrder As System.Xml.XmlElement = xmlDoc.CreateElement("SalesOrder")
            Dim SctReference As System.Xml.XmlElement = xmlDoc.CreateElement("SctReference")

            xmlDoc.AppendChild(PostSorOrderStatus)
            Common.SysproUtilities.AppendXMLElement(PostSorOrderStatus, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, ChangeFwdOrderToSched, Common.SysproUtilities.GetEnumValue(_ChangeFwdOrderToSched.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, CreditAuthority, _CreditAuthority.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DateDeliveryNotePrinted, _DateDeliveryNotePrinted.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DeliveryNoteNumber, _DeliveryNoteNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, InvoiceDateEntered, _InvoiceDateEntered.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, InvoiceNumberEntered, _InvoiceNumberEntered.ToString)

            Common.SysproUtilities.AppendXMLElement(Item, NewOrderStatus, Common.SysproUtilities.GetEnumValue(_NewOrderStatus.ToString))
            '    Common.SysproUtilities.AppendXMLElement(Item, OrderStatus, Common.SysproUtilities.GetEnumValue(_OrderStatus.ToString))

            Common.SysproUtilities.AppendXMLElement(Item, SalesOrder, _SalesOrder.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SctReference, _SctReference.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region
        Private _ActionType As CommonEnums.ActionType_Transaction
        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTOS"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            Select Case ActionType
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select

            Me.ReturnValue = Tallbridge.SysproIntegration.Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, xmlOut, "ItemsInvalid")
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
                Return ConstructParamXML()
            End Get
        End Property
    End Class

End Namespace
