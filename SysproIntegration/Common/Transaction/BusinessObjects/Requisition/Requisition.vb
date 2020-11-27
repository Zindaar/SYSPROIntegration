Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects.Requisition
    <Serializable()> Public Class Requisition
        Implements Tallbridge.SysproIntegration.ITransaction

#Region "Private Parameter Data Members"

        Dim _AcceptGLCodeforStocked As PORTRQ_AcceptGLCodeforStocked_Enum = PORTRQ_AcceptGLCodeforStocked_Enum.AcceptGLCodeforStocked_Upper_N
        Dim _AllowNonStockedItems As PORTRQ_AllowNonStockedItems_Enum = PORTRQ_AllowNonStockedItems_Enum.AllowNonStockedItems_Upper_N
        Dim _ActionType As CommonEnums.ActionType_Transaction
        Dim _RequisitionActionType As PORTRQ_ActionType_Enum
        Dim _Parameters As String = String.Empty


#End Region

#Region "Private Document Data Members"

        Dim _Buyer As String = String.Empty
        Dim _CapexNumber As String = String.Empty
        Dim _Catalogue As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _CustomerPoNumber As String = String.Empty
        Dim _Description As String = String.Empty
        Dim _DiscPercent1 As String = String.Empty
        Dim _DiscPercent2 As String = String.Empty
        Dim _DiscPercent3 As String = String.Empty
        Dim _DiscountCode As String = String.Empty
        Dim _DueDate As String = String.Empty
        Dim _Item As String = String.Empty
        Dim _Job As String = String.Empty
        Dim _LedgerCode As String = String.Empty
        Dim _LessPlusDisc As PORTRQ_LessPlusDisc_Enum = PORTRQ_LessPlusDisc_Enum.LessPlusDisc_Upper_L
        Dim _Notes As String = String.Empty
        Dim _Operation As String = String.Empty
        Dim _PasswordForLedgerCode As String = String.Empty
        Dim _PurchaseOrderComments As String = String.Empty
        Dim _Pieces As String = String.Empty
        Dim _PostRequisition As String = String.Empty
        Dim _Price As String = String.Empty
        Dim _PriceUom As String = String.Empty
        Dim _ProductClass As String = String.Empty
        Dim _Quantity As String = String.Empty
        Dim _Reason As String = String.Empty
        Dim _ReceiptIntoInspection As PORTRQ_ReceiptIntoInspection_Enum
        Dim _Release As String = String.Empty
        Dim _RequisitionLine As String = String.Empty
        Dim _RequisitionNumber As String = String.Empty
        Dim _Revision As String = String.Empty
        Dim _RouteNotation As String = String.Empty
        Dim _RouteToUser As String = String.Empty
        Dim _StockCode As String = String.Empty
        Dim _Supplier As String = String.Empty
        Dim _TaxCode As String = String.Empty
        Dim _UnitOfMeasure As String = String.Empty
        Dim _Units As String = String.Empty
        Dim _User As String = String.Empty
        Dim _UserPassword As String = String.Empty
        Dim _Warehouse As String = String.Empty
        Dim _Originator As String = String.Empty

#End Region

#Region "Collection Data Members"
        Private _RequisitionItems As New ArrayList
#End Region

#Region "Collection Properties"
        Public Property RequisitionItems() As ArrayList
            Get
                Return _RequisitionItems
            End Get
            Set(ByVal Value As ArrayList)
                _RequisitionItems = Value
            End Set
        End Property
#End Region

        Dim _ReturnValue As String
        'Return Value
        Public Property ReturnValue() As String
            Get
                Return _ReturnValue
            End Get
            Set(ByVal value As String)
                _ReturnValue = value
            End Set
        End Property

        Public Property Originator() As String
            Get
                Return _Originator
            End Get
            Set(ByVal value As String)
                _Originator = value
            End Set
        End Property

#Region "Public Parameter Properties"

        ''' <summary> 
        '''  Do you wish to add a General Ledger code to the requisition created for a stocked item? (N - No, Y - Yes) The ledger code added to the requisition is for documentary purposes only, and will not be used by SYSPRO.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AcceptGLCodeforStocked() As PORTRQ_AcceptGLCodeforStocked_Enum
            Get
                Return _AcceptGLCodeforStocked
            End Get
            Set(ByVal Value As PORTRQ_AcceptGLCodeforStocked_Enum)
                _AcceptGLCodeforStocked = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to allow for non-stocked items ? (N - No, Y - Yes) If this option is set as 'N" then a non-existent stock code will be rejected.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AllowNonStockedItems() As PORTRQ_AllowNonStockedItems_Enum
            Get
                Return _AllowNonStockedItems
            End Get
            Set(ByVal Value As PORTRQ_AllowNonStockedItems_Enum)
                _AllowNonStockedItems = Value
            End Set
        End Property

        ''' <summary> 
        '''  Add or Change action type (A - Add a requisition, C - Change a requisition) The ADD action type will automatically generate a new requisition number (assuming requisition auto numbering) for each new requisition. Requisition lines can be added to an existing requisition if an existing requisition number is supplied in the RequisitionNumber element. The CHANGE action type requires the input of both the RequisitionNumber and RequisitionLine.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionActionType() As PORTRQ_ActionType_Enum
            Get
                Return _RequisitionActionType
            End Get
            Set(ByVal Value As PORTRQ_ActionType_Enum)
                _RequisitionActionType = Value
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



#End Region

#Region "Public Document Properties"

        ''' <summary> 
        '''  The buyer code to be associated with the requisition. If enrered, it must be a valid SYSPRO buyer code.
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
        '''  The capex number. Must be valid if supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CapexNumber() As String
            Get
                Return _CapexNumber
            End Get
            Set(ByVal Value As String)
                _CapexNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  The supplier's catalogue number for the supplied stock code.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Catalogue() As String
            Get
                Return _Catalogue
            End Get
            Set(ByVal Value As String)
                _Catalogue = Value
            End Set
        End Property

        ''' <summary> 
        '''  The customer number. Does not have to valid when supplied.
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
        '''  The customer's purchase order number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CustomerPoNumber() As String
            Get
                Return _CustomerPoNumber
            End Get
            Set(ByVal Value As String)
                _CustomerPoNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  The description of the stock code. If not supplied will default to the description of the stock code itself. A non-blank description must be supplied for a non-stocked item.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property

        ''' <summary> 
        '''  First discount percentage. May be positive or negative. Discount percentages will only be used if the DiscountCode element is not supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DiscPercent1() As String
            Get
                Return _DiscPercent1
            End Get
            Set(ByVal Value As String)
                _DiscPercent1 = Value
            End Set
        End Property

        ''' <summary> 
        '''  Second discount percentage.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DiscPercent2() As String
            Get
                Return _DiscPercent2
            End Get
            Set(ByVal Value As String)
                _DiscPercent2 = Value
            End Set
        End Property

        ''' <summary> 
        '''  Third discount percentage.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DiscPercent3() As String
            Get
                Return _DiscPercent3
            End Get
            Set(ByVal Value As String)
                _DiscPercent3 = Value
            End Set
        End Property

        ''' <summary> 
        '''  Discount code. Must be valid if supplied. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DiscountCode() As String
            Get
                Return _DiscountCode
            End Get
            Set(ByVal Value As String)
                _DiscountCode = Value
            End Set
        End Property

        ''' <summary> 
        '''  The due date for the requisition line. Defaults to today's date.
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
        '''  The job number. The job number does not have to be valid if supplied. However, if the job is valid then the job classification of that job is checked for security access.
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
        '''  The G/L account code. This may only be supplied for a non-stocked item, and will be ignored for a stocked item and ignored for any item that contains a job number. Defaults to the inventory non-stocked control account if not specifically supplied.
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
        '''  Indicates whether the discount percentages should be applied as LESS (L) or PLUS (P).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property LessPlusDisc() As PORTRQ_LessPlusDisc_Enum
            Get
                Return _LessPlusDisc
            End Get
            Set(ByVal Value As PORTRQ_LessPlusDisc_Enum)
                _LessPlusDisc = Value
            End Set
        End Property

        ''' <summary> 
        '''  Requisition notes.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Notes() As String
            Get
                Return _Notes
            End Get
            Set(ByVal Value As String)
                _Notes = Value
            End Set
        End Property

        ''' <summary> 
        '''  Subcontract operation number if a job has been supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Operation() As String
            Get
                Return _Operation
            End Get
            Set(ByVal Value As String)
                _Operation = Value
            End Set
        End Property

        ''' <summary> 
        '''  If ledger codes require a password, this element must contain the relevant password.
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
        '''  Comments to be applied to the purchase order when created from this requisition line.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PurchaseOrderComments() As String
            Get
                Return _PurchaseOrderComments
            End Get
            Set(ByVal Value As String)
                _PurchaseOrderComments = Value
            End Set
        End Property

        ''' <summary> 
        '''  If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
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
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostRequisition() As String
            Get
                Return _PostRequisition
            End Get
            Set(ByVal Value As String)
                _PostRequisition = Value
            End Set
        End Property

        ''' <summary> 
        '''  The price quoted by the supplier.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Price() As String
            Get
                Return _Price
            End Get
            Set(ByVal Value As String)
                _Price = Value
            End Set
        End Property

        ''' <summary> 
        '''  The price unit of measure.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PriceUom() As String
            Get
                Return _PriceUom
            End Get
            Set(ByVal Value As String)
                _PriceUom = Value
            End Set
        End Property

        ''' <summary> 
        '''  The product class to be applied for a non-stocked item only.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ProductClass() As String
            Get
                Return _ProductClass
            End Get
            Set(ByVal Value As String)
                _ProductClass = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element is mandatory if the stock code is not a unit-qty type stock code.
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
        '''  The reason for the requisition being raised.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Reason() As String
            Get
                Return _Reason
            End Get
            Set(ByVal Value As String)
                _Reason = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element allows a non-stocked requisition to be flagged as requiring inspection. Valid entries are 'N' - No, 'Y' - Yes. If blank, then 'N' is assumed. This is only used for a non-stocked item.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ReceiptIntoInspection() As PORTRQ_ReceiptIntoInspection_Enum
            Get
                Return _ReceiptIntoInspection
            End Get
            Set(ByVal Value As PORTRQ_ReceiptIntoInspection_Enum)
                _ReceiptIntoInspection = Value
            End Set
        End Property

        ''' <summary> 
        '''  The release of the stock code.
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
        '''  The line number of the requisition. The line is applied when changing an existing requisition.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionLine() As String
            Get
                Return _RequisitionLine
            End Get
            Set(ByVal Value As String)
                _RequisitionLine = Value
            End Set
        End Property

        ''' <summary> 
        '''  The number is used when changing an existing requisition, or when adding new lines to an existing requisition, or when adding a requisition for the first time, and requisition numbering is manual.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionNumber() As String
            Get
                Return _RequisitionNumber
            End Get
            Set(ByVal Value As String)
                _RequisitionNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  The revision of the stock code.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Revision() As String
            Get
                Return _Revision
            End Get
            Set(ByVal Value As String)
                _Revision = Value
            End Set
        End Property

        ''' <summary> 
        '''  The notation to be applied if the requisition is to be routed to another user.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteNotation() As String
            Get
                Return _RouteNotation
            End Get
            Set(ByVal Value As String)
                _RouteNotation = Value
            End Set
        End Property

        ''' <summary> 
        '''  The user to whom the requisition should be routed.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteToUser() As String
            Get
                Return _RouteToUser
            End Get
            Set(ByVal Value As String)
                _RouteToUser = Value
            End Set
        End Property

        ''' <summary> 
        '''  The stock code for the requisition. This must be non-blank. The stock code must be valid if the XML parameter option AllowNonStocked is defined as N.
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
        '''  The supplier of the stock item. If the supplier is valid then it is checked to see if the supplier is on hold and for security access on the A/P branch.
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
        '''  The tax code is only used if the item is non-stocked.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TaxCode() As String
            Get
                Return _TaxCode
            End Get
            Set(ByVal Value As String)
                _TaxCode = Value
            End Set
        End Property

        ''' <summary> 
        '''  The unit of measure for the quantity supplied. The u/m must be either the stocking or alternate u/m's associated with the stock code. If not supplied then the stocking unit of measure is assumed.
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
        '''  If the stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
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
        '''  The user who is adding the requisition. If the user is not supplied then the user associated with the operator will be assumed. The user must be valid.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property User() As String
            Get
                Return _User
            End Get
            Set(ByVal Value As String)
                _User = Value
            End Set
        End Property

        ''' <summary> 
        '''  The password associated with the user. The password is only required to be supplied if the user element was supplied and it differs from the user associated with the operator default. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UserPassword() As String
            Get
                Return _UserPassword
            End Get
            Set(ByVal Value As String)
                _UserPassword = Value
            End Set
        End Property

        ''' <summary> 
        '''  The warehouse for the stock code into which the goods will be supplied. The entry supplied here will be overwritten if there is a warehouse defined against the requisition user.
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
#End Region

#Region "Enumerations"

        Public Enum PORTRQ_AcceptGLCodeforStocked_Enum
            AcceptGLCodeforStocked_Upper_N
            AcceptGLCodeforStocked_Upper_Y
        End Enum
        Public Enum PORTRQ_AllowNonStockedItems_Enum
            AllowNonStockedItems_Upper_N
            AllowNonStockedItems_Upper_Y
        End Enum
        Public Enum PORTRQ_ActionType_Enum
            ActionType_Upper_A
            ActionType_Upper_C
        End Enum

        Public Enum PORTRQ_LessPlusDisc_Enum
            LessPlusDisc_Upper_L
            LessPlusDisc_Upper_P
        End Enum
        Public Enum PORTRQ_ReceiptIntoInspection_Enum
            ReceiptIntoInspection_Upper_N
            ReceiptIntoInspection_Upper_Y
            ReceiptIntoInspection_Upper_
        End Enum

#End Region

#Region "XML String Constructor"

        Private Function ConstructParamXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim AcceptGLCodeforStocked As System.Xml.XmlElement = xmlDoc.CreateElement("AcceptGLCodeforStocked")
            Dim AllowNonStockedItems As System.Xml.XmlElement = xmlDoc.CreateElement("AllowNonStockedItems")
            Dim ActionType As System.Xml.XmlElement = xmlDoc.CreateElement("ActionType")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim PostRequisition As System.Xml.XmlElement = xmlDoc.CreateElement("PostRequisition")

            xmlDoc.AppendChild(PostRequisition)
            Common.SysproUtilities.AppendXMLElement(PostRequisition, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, AcceptGLCodeforStocked, Common.SysproUtilities.GetEnumValue(_AcceptGLCodeforStocked.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, AllowNonStockedItems, Common.SysproUtilities.GetEnumValue(_AllowNonStockedItems.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ActionType, Common.SysproUtilities.GetEnumValue(_RequisitionActionType.ToString))

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructDocumentXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim Buyer As System.Xml.XmlElement = xmlDoc.CreateElement("Buyer")
            Dim CapexNumber As System.Xml.XmlElement = xmlDoc.CreateElement("CapexNumber")
            Dim Catalogue As System.Xml.XmlElement = xmlDoc.CreateElement("Catalogue")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim CustomerPoNumber As System.Xml.XmlElement = xmlDoc.CreateElement("CustomerPoNumber")
            Dim Description As System.Xml.XmlElement = xmlDoc.CreateElement("Description")
            Dim DiscPercent1 As System.Xml.XmlElement = xmlDoc.CreateElement("DiscPercent1")
            Dim DiscPercent2 As System.Xml.XmlElement = xmlDoc.CreateElement("DiscPercent2")
            Dim DiscPercent3 As System.Xml.XmlElement = xmlDoc.CreateElement("DiscPercent3")
            Dim DiscountCode As System.Xml.XmlElement = xmlDoc.CreateElement("DiscountCode")
            Dim DueDate As System.Xml.XmlElement = xmlDoc.CreateElement("DueDate")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim Job As System.Xml.XmlElement = xmlDoc.CreateElement("Job")
            Dim LedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("LedgerCode")
            Dim LessPlusDisc As System.Xml.XmlElement = xmlDoc.CreateElement("LessPlusDisc")
            Dim Notes As System.Xml.XmlElement = xmlDoc.CreateElement("Notes")
            Dim Operation As System.Xml.XmlElement = xmlDoc.CreateElement("Operation")
            Dim PasswordForLedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("PasswordForLedgerCode")
            Dim PurchaseOrderComments As System.Xml.XmlElement = xmlDoc.CreateElement("PurchaseOrderComments")
            Dim Pieces As System.Xml.XmlElement = xmlDoc.CreateElement("Pieces")
            Dim PostRequisition As System.Xml.XmlElement = xmlDoc.CreateElement("PostRequisition")
            Dim Price As System.Xml.XmlElement = xmlDoc.CreateElement("Price")
            Dim PriceUom As System.Xml.XmlElement = xmlDoc.CreateElement("PriceUom")
            Dim ProductClass As System.Xml.XmlElement = xmlDoc.CreateElement("ProductClass")
            Dim Quantity As System.Xml.XmlElement = xmlDoc.CreateElement("Quantity")
            Dim Reason As System.Xml.XmlElement = xmlDoc.CreateElement("Reason")
            Dim ReceiptIntoInspection As System.Xml.XmlElement = xmlDoc.CreateElement("ReceiptIntoInspection")
            Dim Release As System.Xml.XmlElement = xmlDoc.CreateElement("Release")
            Dim RequisitionLine As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionLine")
            Dim RequisitionNumber As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionNumber")
            Dim Revision As System.Xml.XmlElement = xmlDoc.CreateElement("Revision")
            Dim RouteNotation As System.Xml.XmlElement = xmlDoc.CreateElement("RouteNotation")
            Dim RouteToUser As System.Xml.XmlElement = xmlDoc.CreateElement("RouteToUser")
            Dim StockCode As System.Xml.XmlElement = xmlDoc.CreateElement("StockCode")
            Dim Supplier As System.Xml.XmlElement = xmlDoc.CreateElement("Supplier")
            Dim TaxCode As System.Xml.XmlElement = xmlDoc.CreateElement("TaxCode")
            Dim UnitOfMeasure As System.Xml.XmlElement = xmlDoc.CreateElement("UnitOfMeasure")
            Dim Units As System.Xml.XmlElement = xmlDoc.CreateElement("Units")
            Dim User As System.Xml.XmlElement = xmlDoc.CreateElement("User")
            Dim UserPassword As System.Xml.XmlElement = xmlDoc.CreateElement("UserPassword")
            Dim Warehouse As System.Xml.XmlElement = xmlDoc.CreateElement("Warehouse")

            xmlDoc.AppendChild(PostRequisition)
            Common.SysproUtilities.AppendXMLElement(PostRequisition, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Buyer, _Buyer.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, CapexNumber, _CapexNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Catalogue, _Catalogue.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, CustomerPoNumber, _CustomerPoNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Description, _Description.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DiscPercent1, _DiscPercent1.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DiscPercent2, _DiscPercent2.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, DiscPercent3, _DiscPercent3.ToString)
            If _DiscountCode.ToString <> "" Then
                Common.SysproUtilities.AppendXMLElement(Item, DiscountCode, _DiscountCode.ToString)
            End If
            Common.SysproUtilities.AppendXMLElement(Item, DueDate, _DueDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Job, _Job.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, LedgerCode, _LedgerCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, LessPlusDisc, Common.SysproUtilities.GetEnumValue(_LessPlusDisc.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, Notes, _Notes.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Operation, _Operation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PasswordForLedgerCode, _PasswordForLedgerCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PurchaseOrderComments, _PurchaseOrderComments.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Pieces, _Pieces.ToString)
            If IsNumeric(_Price) Then
                If CDbl(_Price) = 0 Then
                    Common.SysproUtilities.AppendXMLElement(Item, Price, "0.01")
                Else
                    Common.SysproUtilities.AppendXMLElement(Item, Price, _Price)
                End If
            Else
                Common.SysproUtilities.AppendXMLElement(Item, Price, "0.01")
            End If
            Common.SysproUtilities.AppendXMLElement(Item, PriceUom, _PriceUom.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, ProductClass, _ProductClass.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Quantity, _Quantity.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Reason, _Reason.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, ReceiptIntoInspection, Common.SysproUtilities.GetEnumValue(_ReceiptIntoInspection.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, Release, _Release.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionLine, _RequisitionLine.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionNumber, _RequisitionNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Revision, _Revision.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RouteNotation, _RouteNotation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RouteToUser, _RouteToUser.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, StockCode, _StockCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Supplier, _Supplier.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, TaxCode, _TaxCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UnitOfMeasure, _UnitOfMeasure.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Units, _Units.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, User, _User.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UserPassword, _UserPassword.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Warehouse, _Warehouse.ToString)

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructMultiLineDocumentXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument


            'Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim PostRequisition As System.Xml.XmlElement = xmlDoc.CreateElement("PostRequisition")

            xmlDoc.AppendChild(PostRequisition)
            'Common.SysproUtilities.AppendXMLElement(PostRequisition, Item, _Item.ToString)
            'Common.SysproUtilities.AppendXMLElement(Item, Buyer, _Buyer.ToString)
            For Each RequisitionItem As RequisitionItem In RequisitionItems
                RequisitionItem.AppendRequisitionItem(xmlDoc)
            Next

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "PORTRQ"
        Private _ProcessedElement As String

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("item/Requisition")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property

        Public Sub Post() Implements ITransaction.Post
            _xmlOut = Transaction.Post(Me)
            Me.Originator = Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, xmlOut, "Originator")
            Me.RequisitionNumber = Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, xmlOut, "Requisition")
            Me.RequisitionLine = Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, xmlOut, "Line")
        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return Me.ConstructDocumentXML
                'Return Me.ConstructMultiLineDocumentXML
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Return Me.ConstructParamXML
            End Get
        End Property
#End Region

    End Class


End Namespace
