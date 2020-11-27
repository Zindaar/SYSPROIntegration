Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace QueryObjects
    <Serializable()> Public Class PurchaseOrderList

        Implements IQuery

        Const _BusinessObject As String = "PORQPO"

#Region "Private Object Members"

        Private _xmlData As String
        Private _xmlOut As String
        Private _ActionType As CommonEnums.ActionType_Query

#End Region

#Region "Public Object Properties"

        Public ReadOnly Property xmlData() As String Implements IQuery.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Property ActionType() As CommonEnums.ActionType_Query Implements IQuery.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

#End Region

#Region "Private Data Members"

        Dim _Buyer As String = String.Empty
        Dim _Buyer_FilterType As PurchaseOrderList_Buyer_FilterType_Enum
        Dim _Buyer_FilterValue As String = String.Empty
        Dim _Currency As String = String.Empty
        Dim _Currency_FilterType As PurchaseOrderList_Currency_FilterType_Enum
        Dim _Currency_FilterValue As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _Customer_FilterType As PurchaseOrderList_Customer_FilterType_Enum
        Dim _Customer_FilterValue As String = String.Empty
        Dim _Filter As String = String.Empty
        Dim _IncludeCancelledOrders As PurchaseOrderList_IncludeCancelledOrders_Enum = PurchaseOrderList_IncludeCancelledOrders_Enum.IncludeCancelledOrders_Upper_N
        Dim _IncludeCompletedOrders As PurchaseOrderList_IncludeCompletedOrders_Enum = PurchaseOrderList_IncludeCompletedOrders_Enum.IncludeCompletedOrders_Upper_N
        Dim _XslStylesheet As String = String.Empty
        Dim _Memo As String = String.Empty
        Dim _Memo_FilterType As PurchaseOrderList_Memo_FilterType_Enum
        Dim _Memo_FilterValue As String = String.Empty
        Dim _xOption As String = String.Empty
        Dim _OrderDate As String = String.Empty
        Dim _OrderDate_FilterType As PurchaseOrderList_OrderDate_FilterType_Enum
        Dim _OrderDate_FilterValue As String = String.Empty
        Dim _PurchaseOrder As String = String.Empty
        Dim _PurchaseOrder_FilterType As PurchaseOrderList_PurchaseOrder_FilterType_Enum
        Dim _PurchaseOrder_FilterValue As String = String.Empty
        Dim _xQuery As String = String.Empty
        Dim _Supplier As String = String.Empty
        Dim _Supplier_FilterType As PurchaseOrderList_Supplier_FilterType_Enum
        Dim _Supplier_FilterValue As String = String.Empty


#End Region

#Region "Public Data Properties"

        ''' <summary> 
        '''  Buyer to be selected (FilterType of A - All, S - Single buyer, FilterValue contains the selected buyer if FilterType is S)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Buyer() As String
            Get
                Return _Buyer
            End Get
            Set(ByVal Value As String)
                _Buyer = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Buyer_FilterType() As PurchaseOrderList_Buyer_FilterType_Enum
            Get
                Return _Buyer_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_Buyer_FilterType_Enum)
                _Buyer_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Buyer_FilterValue() As String
            Get
                Return _Buyer_FilterValue
            End Get
            Set(ByVal Value As String)
                _Buyer_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Currency to be selected (FilterType of A - All, S - Single currency, FilterValue contains the selected currency if FilterType is S)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Currency_FilterType() As PurchaseOrderList_Currency_FilterType_Enum
            Get
                Return _Currency_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_Currency_FilterType_Enum)
                _Currency_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Currency_FilterValue() As String
            Get
                Return _Currency_FilterValue
            End Get
            Set(ByVal Value As String)
                _Currency_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Customer to be selected (FilterType of A - All, S - Single customer, FilterValue contains the selected customer if FilterType is S)
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
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer_FilterType() As PurchaseOrderList_Customer_FilterType_Enum
            Get
                Return _Customer_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_Customer_FilterType_Enum)
                _Customer_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer_FilterValue() As String
            Get
                Return _Customer_FilterValue
            End Get
            Set(ByVal Value As String)
                _Customer_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  This contains one or more filters to restrict the amount of data returned
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Filter() As String
            Get
                Return _Filter
            End Get
            Set(ByVal Value As String)
                _Filter = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include cancelled orders? (N - No, Y - Yes)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCancelledOrders() As PurchaseOrderList_IncludeCancelledOrders_Enum
            Get
                Return _IncludeCancelledOrders
            End Get
            Set(ByVal Value As PurchaseOrderList_IncludeCancelledOrders_Enum)
                _IncludeCancelledOrders = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include completed orders ?(N - No, Y - Yes)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCompletedOrders() As PurchaseOrderList_IncludeCompletedOrders_Enum
            Get
                Return _IncludeCompletedOrders
            End Get
            Set(ByVal Value As PurchaseOrderList_IncludeCompletedOrders_Enum)
                _IncludeCompletedOrders = Value
            End Set
        End Property


        ''' <summary> 
        '''  The XSL Stylesheet to be used
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property XslStylesheet() As String
            Get
                Return _XslStylesheet
            End Get
            Set(ByVal Value As String)
                _XslStylesheet = Value
            End Set
        End Property

        ''' <summary> 
        '''  Memo to be selected (FilterType of A - All, S - Single memo, FilterValue contains the selected memo if FilterType is S)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Memo() As String
            Get
                Return _Memo
            End Get
            Set(ByVal Value As String)
                _Memo = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Memo_FilterType() As PurchaseOrderList_Memo_FilterType_Enum
            Get
                Return _Memo_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_Memo_FilterType_Enum)
                _Memo_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Memo_FilterValue() As String
            Get
                Return _Memo_FilterValue
            End Get
            Set(ByVal Value As String)
                _Memo_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xOption() As String
            Get
                Return _xOption
            End Get
            Set(ByVal Value As String)
                _xOption = Value
            End Set
        End Property

        ''' <summary> 
        '''  Purchase order due dates selected (FilterType of A - All, R - Range, FilterValue is range of order due dates separated by a comma if FilterType is R).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderDate() As String
            Get
                Return _OrderDate
            End Get
            Set(ByVal Value As String)
                _OrderDate = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderDate_FilterType() As PurchaseOrderList_OrderDate_FilterType_Enum
            Get
                Return _OrderDate_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_OrderDate_FilterType_Enum)
                _OrderDate_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property OrderDate_FilterValue() As String
            Get
                Return _OrderDate_FilterValue
            End Get
            Set(ByVal Value As String)
                _OrderDate_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Purchase orders selected (FilterType of A - All, R - Range, FilterValue is range of purchase orders separated by a comma if FilterType is R).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PurchaseOrder() As String
            Get
                Return _PurchaseOrder
            End Get
            Set(ByVal Value As String)
                _PurchaseOrder = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PurchaseOrder_FilterType() As PurchaseOrderList_PurchaseOrder_FilterType_Enum
            Get
                Return _PurchaseOrder_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_PurchaseOrder_FilterType_Enum)
                _PurchaseOrder_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PurchaseOrder_FilterValue() As String
            Get
                Return _PurchaseOrder_FilterValue
            End Get
            Set(ByVal Value As String)
                _PurchaseOrder_FilterValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the root element
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xQuery() As String
            Get
                Return _xQuery
            End Get
            Set(ByVal Value As String)
                _xQuery = Value
            End Set
        End Property

        ''' <summary> 
        '''  Supplier to be selected (FilterType of A - All, S - Single supplier, FilterValue contains the selected supplier if FilterType is S)
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
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Supplier_FilterType() As PurchaseOrderList_Supplier_FilterType_Enum
            Get
                Return _Supplier_FilterType
            End Get
            Set(ByVal Value As PurchaseOrderList_Supplier_FilterType_Enum)
                _Supplier_FilterType = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Supplier_FilterValue() As String
            Get
                Return _Supplier_FilterValue
            End Get
            Set(ByVal Value As String)
                _Supplier_FilterValue = Value
            End Set
        End Property



#End Region

#Region "Enumerations"

        Public Enum PurchaseOrderList_Buyer_FilterType_Enum
            Buyer_FilterType_Upper_S
            Buyer_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_Currency_FilterType_Enum
            Currency_FilterType_Upper_S
            Currency_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_Customer_FilterType_Enum
            Customer_FilterType_Upper_S
            Customer_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_IncludeCancelledOrders_Enum
            IncludeCancelledOrders_Upper_N
            IncludeCancelledOrders_Upper_Y
        End Enum
        Public Enum PurchaseOrderList_IncludeCompletedOrders_Enum
            IncludeCompletedOrders_Upper_N
            IncludeCompletedOrders_Upper_Y
        End Enum
        Public Enum PurchaseOrderList_Memo_FilterType_Enum
            Memo_FilterType_Upper_S
            Memo_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_OrderDate_FilterType_Enum
            OrderDate_FilterType_Upper_R
            OrderDate_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_PurchaseOrder_FilterType_Enum
            PurchaseOrder_FilterType_Upper_R
            PurchaseOrder_FilterType_Upper_A
        End Enum
        Public Enum PurchaseOrderList_Supplier_FilterType_Enum
            Supplier_FilterType_Upper_S
            Supplier_FilterType_Upper_A
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim xQuery As System.Xml.XmlElement = xmlDoc.CreateElement("Query")
            xmlDoc.AppendChild(xQuery)

            Dim xOption As System.Xml.XmlElement = xmlDoc.CreateElement("Option")
            Dim Filter As System.Xml.XmlElement = xmlDoc.CreateElement("Filter")

            Dim IncludeCancelledOrders As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCancelledOrders")
            Dim IncludeCompletedOrders As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCompletedOrders")
            Dim XslStylesheet As System.Xml.XmlElement = xmlDoc.CreateElement("XslStylesheet")

            Dim Buyer As System.Xml.XmlElement = xmlDoc.CreateElement("Buyer")
            Dim Buyer_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("Buyer_FilterType")
            Dim Buyer_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("Buyer_FilterValue")
            Dim Currency As System.Xml.XmlElement = xmlDoc.CreateElement("Currency")
            Dim Currency_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("Currency_FilterType")
            Dim Currency_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("Currency_FilterValue")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim Customer_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("Customer_FilterType")
            Dim Customer_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("Customer_FilterValue")

            Dim Memo As System.Xml.XmlElement = xmlDoc.CreateElement("Memo")
            Dim Memo_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("Memo_FilterType")
            Dim Memo_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("Memo_FilterValue")
            Dim OrderDate As System.Xml.XmlElement = xmlDoc.CreateElement("OrderDate")
            Dim OrderDate_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("OrderDate_FilterType")
            Dim OrderDate_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("OrderDate_FilterValue")
            Dim PurchaseOrder As System.Xml.XmlElement = xmlDoc.CreateElement("PurchaseOrder")
            Dim PurchaseOrder_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("PurchaseOrder_FilterType")
            Dim PurchaseOrder_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("PurchaseOrder_FilterValue")

            Dim Supplier As System.Xml.XmlElement = xmlDoc.CreateElement("Supplier")
            Dim Supplier_FilterType As System.Xml.XmlElement = xmlDoc.CreateElement("Supplier_FilterType")
            Dim Supplier_FilterValue As System.Xml.XmlElement = xmlDoc.CreateElement("Supplier_FilterValue")


            Common.SysproUtilities.AppendXMLElement(xQuery, xOption, _xOption.ToString)
            Common.SysproUtilities.AppendXMLElement(xQuery, Filter, _xQuery.ToString)

            '**Option's Children
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCancelledOrders, Common.SysproUtilities.GetEnumValue(_IncludeCancelledOrders.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCompletedOrders, Common.SysproUtilities.GetEnumValue(_IncludeCompletedOrders.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, XslStylesheet, _XslStylesheet.ToString)

            '**Filter's Children
            '***Supplier
            Common.SysproUtilities.AppendXMLElement(Filter, Supplier, _Supplier.ToString)
            Supplier.SetAttribute("FilterType", Common.SysproUtilities.GetEnumValue(_Supplier_FilterType.ToString))
            If _Supplier_FilterValue <> "" Then
                Supplier.SetAttribute("FilterValue", _Supplier_FilterValue.ToString)
            End If

            '***Customer
            Common.SysproUtilities.AppendXMLElement(Filter, Customer, _Customer.ToString)
            Customer.SetAttribute("FilterType", _Customer_FilterType)
            If _Customer_FilterValue <> "" Then
                Customer.SetAttribute("FilterType", _Customer_FilterValue.ToString)
            End If

            '***Currency
            Common.SysproUtilities.AppendXMLElement(Filter, Currency, _Currency.ToString)
            Currency.SetAttribute("FilterType", _Currency_FilterType)
            If _Currency_FilterValue <> "" Then
                Currency.SetAttribute("FilterType", _Currency_FilterValue.ToString)
            End If

            '***Buyer
            Common.SysproUtilities.AppendXMLElement(Filter, Buyer, _Buyer.ToString)
            Buyer.SetAttribute("FilterType", _Buyer_FilterType)
            If _Buyer_FilterValue <> "" Then
                Buyer.SetAttribute("FilterType", _Buyer_FilterValue.ToString)
            End If

            '***Memo
            Common.SysproUtilities.AppendXMLElement(Filter, Memo, _Memo.ToString)
            Memo.SetAttribute("FilterType", _Memo_FilterType)
            If _Memo_FilterValue <> "" Then
                Memo.SetAttribute("FilterType", _Memo_FilterValue.ToString)
            End If

            '***PurchaseOrder
            Common.SysproUtilities.AppendXMLElement(Filter, PurchaseOrder, _PurchaseOrder.ToString)
            PurchaseOrder.SetAttribute("FilterType", _PurchaseOrder_FilterType)
            If _PurchaseOrder_FilterValue <> "" Then
                PurchaseOrder.SetAttribute("FilterType", _PurchaseOrder_FilterValue.ToString)
            End If

            '***OrderDate
            Common.SysproUtilities.AppendXMLElement(Filter, OrderDate, _OrderDate.ToString)
            OrderDate.SetAttribute("FilterType", _OrderDate_FilterType)
            If _OrderDate_FilterValue <> "" Then
                OrderDate.SetAttribute("FilterType", _OrderDate_FilterValue.ToString)
            End If



            Return xmlDoc.OuterXml

        End Function

#End Region

#Region "Post Sub"

        Public Sub Post() Implements IQuery.Post

            Select Case _ActionType
                Case CommonEnums.ActionType_Query.Query
                    _xmlOut = Query.Query(Me)
                Case CommonEnums.ActionType_Query.Fetch
                    _xmlOut = Query.Fetch(Me)
                Case CommonEnums.ActionType_Query.Browse
                    _xmlOut = Query.Browse(Me)
                Case CommonEnums.ActionType_Query.NextKey
                    _xmlOut = Query.NextKey(Me)
                Case CommonEnums.ActionType_Query.PreviousKey
                    _xmlOut = Query.PreviousKey(Me)
            End Select

        End Sub

#End Region

    End Class

End Namespace
