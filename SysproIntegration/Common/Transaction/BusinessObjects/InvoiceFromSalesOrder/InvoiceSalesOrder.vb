Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class InvoiceSalesOrder
        Implements SysproIntegration.ITransaction


#Region "Private Data Members"

        Dim _PostSalesOrderInvoice As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _InvoiceDate As String = String.Empty
        Dim _OrderType As InvoiceSalesOrder_OrderType_Enum = InvoiceSalesOrder_OrderType_Enum.OrderType_Upper_I
        Dim _PostingPeriod As InvoiceSalesOrder_PostingPeriod_Enum = InvoiceSalesOrder_PostingPeriod_Enum.PostingPeriod_Upper_C
        Dim _IgnoreWarnings As InvoiceSalesOrder_IgnoreWarnings_Enum = InvoiceSalesOrder_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _ApplyIfEntireDocumentValid As InvoiceSalesOrder_ApplyIfEntireDocumentValid_Enum = InvoiceSalesOrder_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_N
        Dim _ValidateOnly As InvoiceSalesOrder_ValidateOnly_Enum = InvoiceSalesOrder_ValidateOnly_Enum.ValidateOnly_Upper_N
        Dim _ValidateAllLines As InvoiceSalesOrder_ValidateAllLines_Enum = InvoiceSalesOrder_ValidateAllLines_Enum.ValidateAllLines_Upper_N
        Dim _InvoiceOnlyIfMerchLines As InvoiceSalesOrder_InvoiceOnlyIfMerchLines_Enum = InvoiceSalesOrder_InvoiceOnlyIfMerchLines_Enum.InvoiceOnlyIfMerchLines_Upper_N
        Dim _InvoiceChgWithoutMerchLine As InvoiceSalesOrder_InvoiceChgWithoutMerchLine_Enum = InvoiceSalesOrder_InvoiceChgWithoutMerchLine_Enum.InvoiceChgWithoutMerchLine_Upper_Y

        Dim _Item As String = String.Empty
        Dim _SalesOrder As String = String.Empty
        Dim _SalesOrderLineList As String = String.Empty

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the root element
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostSalesOrderInvoice() As String
            Get
                Return _PostSalesOrderInvoice
            End Get
            Set(ByVal Value As String)
                _PostSalesOrderInvoice = Value
            End Set
        End Property

        ''' <summary> 
        '''  This contains parameters
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
        '''  This contains a valid date of the format CCYY-MM-DD to be used as the invoice date. If not supplied, then the system date will be used as the invoice date. However, if an invoice date has already been recorded against the order, or the SYSPRO option to move order date to invoice date is selected, then this parameter is ignored.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceDate() As String
            Get
                Return _InvoiceDate
            End Get
            Set(ByVal Value As String)
                _InvoiceDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element contains the type of order to be invoiced. It may contain 'I' - normal order, 'C' - credit note, 'D' - debit note. The default is 'I'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderType() As InvoiceSalesOrder_OrderType_Enum
            Get
                Return _OrderType
            End Get
            Set(ByVal Value As InvoiceSalesOrder_OrderType_Enum)
                _OrderType = Value
            End Set
        End Property

        ''' <summary> 
        '''  Period to which transactions must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2). 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostingPeriod() As InvoiceSalesOrder_PostingPeriod_Enum
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As InvoiceSalesOrder_PostingPeriod_Enum)
                _PostingPeriod = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether or not an item must be rejected if there are any warnings, such as AR posting period one month behind the Inventory posting period. If it is not supplied, it defaults to 'N'. Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned, W - warnings will be returned as warnings in the XML returned).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As InvoiceSalesOrder_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As InvoiceSalesOrder_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'N'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As InvoiceSalesOrder_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As InvoiceSalesOrder_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As InvoiceSalesOrder_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As InvoiceSalesOrder_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element is used to specify if all lines in an order are to be checked prior to invoicing. If set to 'Y', then each order selected is also checked at line level for validity, and an invoice is only processed if all lines are valid. Note this only applies if entire order is requested, and the element 'ValidateOnly' is set to 'Y', or the element 'ApplyIfEntireDocumentValid' is set to 'Y'. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateAllLines() As InvoiceSalesOrder_ValidateAllLines_Enum
            Get
                Return _ValidateAllLines
            End Get
            Set(ByVal Value As InvoiceSalesOrder_ValidateAllLines_Enum)
                _ValidateAllLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines when an invoice is to be produced. If set to 'Y', then an invoice will only be produced if the selected order contains a valid merchandise line. Valid entries are 'N' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceOnlyIfMerchLines() As InvoiceSalesOrder_InvoiceOnlyIfMerchLines_Enum
            Get
                Return _InvoiceOnlyIfMerchLines
            End Get
            Set(ByVal Value As InvoiceSalesOrder_InvoiceOnlyIfMerchLines_Enum)
                _InvoiceOnlyIfMerchLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element determines whether service charges attached to a stocked line should be processed if the stocked line is not selected for invoicing - if set to 'Y' then the service charges will be processed with no reference to the stock line. Valid entries are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceChgWithoutMerchLine() As InvoiceSalesOrder_InvoiceChgWithoutMerchLine_Enum
            Get
                Return _InvoiceChgWithoutMerchLine
            End Get
            Set(ByVal Value As InvoiceSalesOrder_InvoiceChgWithoutMerchLine_Enum)
                _InvoiceChgWithoutMerchLine = Value
            End Set
        End Property




        ''' <summary> 
        '''  This element contains information to invoice a sales order.
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
        '''  The sales order number to be invoiced. It must be supplied. The format is six characters, either numeric or alphanumeric, depending on the configuration option within SYSPRO.
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
        '''  The list of sales order lines to be included in the invoice. If supplied, then the lines must be valid for the sales order, and must be ready to invoice. Each entry is separated by a comma, and must be numeric in the range 1 to 9999. If not supplied, then the entire order will be invoiced. This element is only valid for a normal order (parameter OrderType = 'I').
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SalesOrderLineList() As String
            Get
                Return _SalesOrderLineList
            End Get
            Set(ByVal Value As String)
                _SalesOrderLineList = Value
            End Set
        End Property



#End Region

#Region "Enumerations"

        Public Enum InvoiceSalesOrder_OrderType_Enum
            OrderType_Upper_I
            OrderType_Upper_C
            OrderType_Upper_D
        End Enum
        Public Enum InvoiceSalesOrder_PostingPeriod_Enum
            PostingPeriod_Upper_C
            PostingPeriod_Upper_P
            PostingPeriod_Upper_B
        End Enum
        Public Enum InvoiceSalesOrder_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_W
            IgnoreWarnings_Upper_
        End Enum
        Public Enum InvoiceSalesOrder_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_N
            ApplyIfEntireDocumentValid_Upper_Y
        End Enum
        Public Enum InvoiceSalesOrder_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum
        Public Enum InvoiceSalesOrder_ValidateAllLines_Enum
            ValidateAllLines_Upper_N
            ValidateAllLines_Upper_Y
        End Enum
        Public Enum InvoiceSalesOrder_InvoiceOnlyIfMerchLines_Enum
            InvoiceOnlyIfMerchLines_Upper_N
            InvoiceOnlyIfMerchLines_Upper_Y
        End Enum
        Public Enum InvoiceSalesOrder_InvoiceChgWithoutMerchLine_Enum
            InvoiceChgWithoutMerchLine_Upper_Y
            InvoiceChgWithoutMerchLine_Upper_N
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostSalesOrderInvoice As System.Xml.XmlElement = xmlDoc.CreateElement("PostSalesOrderInvoice")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim SalesOrder As System.Xml.XmlElement = xmlDoc.CreateElement("SalesOrder")
            Dim SalesOrderLineList As System.Xml.XmlElement = xmlDoc.CreateElement("SalesOrderLineList")

            xmlDoc.AppendChild(PostSalesOrderInvoice)
            Common.SysproUtilities.AppendXMLElement(PostSalesOrderInvoice, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SalesOrder, _SalesOrder.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SalesOrderLineList, _SalesOrderLineList.ToString)

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostSalesOrderInvoice As System.Xml.XmlElement = xmlDoc.CreateElement("PostSalesOrderInvoice")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim InvoiceDate As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceDate")
            Dim OrderType As System.Xml.XmlElement = xmlDoc.CreateElement("OrderType")
            Dim PostingPeriod As System.Xml.XmlElement = xmlDoc.CreateElement("PostingPeriod")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")
            Dim ValidateAllLines As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateAllLines")
            Dim InvoiceOnlyIfMerchLines As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceOnlyIfMerchLines")
            Dim InvoiceChgWithoutMerchLine As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceChgWithoutMerchLine")

            xmlDoc.AppendChild(PostSalesOrderInvoice)
            Common.SysproUtilities.AppendXMLElement(PostSalesOrderInvoice, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, InvoiceDate, _InvoiceDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, OrderType, Common.SysproUtilities.GetEnumValue(_OrderType.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, PostingPeriod, Common.SysproUtilities.GetEnumValue(_PostingPeriod.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateAllLines, Common.SysproUtilities.GetEnumValue(_ValidateAllLines.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, InvoiceOnlyIfMerchLines, Common.SysproUtilities.GetEnumValue(_InvoiceOnlyIfMerchLines.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, InvoiceChgWithoutMerchLine, Common.SysproUtilities.GetEnumValue(_InvoiceChgWithoutMerchLine.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region


        Private _ActionType As CommonEnums.ActionTypeEnum
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
                Return "SORTIC"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            Select Case ActionType
                Case CommonEnums.ActionType_Transaction.Build
                    _xmlOut = Transaction.Build(Me)
                Case CommonEnums.ActionType_Transaction.Post
                    _xmlOut = Transaction.Post(Me)
            End Select
            _returnInvoiceNumber = Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, _xmlOut, "InvoiceNumber")
        End Sub

        Private _returnInvoiceNumber As String
        Public ReadOnly Property ReturnInvoiceNumber() As String
            Get
                Return _returnInvoiceNumber
            End Get
        End Property
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
    End Class

End Namespace
