Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects
    <Serializable()> Public Class ARDocument
        Implements ITransaction


#Region "Private Data Members"

        Dim _ApplyIfEntireDocumentValid As ARDocument_ApplyIfEntireDocumentValid_Enum = ARDocument_ApplyIfEntireDocumentValid_Enum.ApplyIfEntireDocumentValid_Upper_Y
        Dim _IgnoreWarnings As ARDocument_IgnoreWarnings_Enum = ARDocument_IgnoreWarnings_Enum.IgnoreWarnings_Upper_N
        Dim _Parameters As String = String.Empty
        Dim _PostArInvoices As String = String.Empty
        Dim _PostingPeriod As ARDocument_PostingPeriod_Enum = ARDocument_PostingPeriod_Enum.PostingPeriod_Upper_C
        Dim _ValidateOnly As ARDocument_ValidateOnly_Enum = ARDocument_ValidateOnly_Enum.ValidateOnly_Upper_N

        Dim _Item As String = String.Empty
        Dim _Branch As String = String.Empty
        Dim _CostValue As String = String.Empty
        Dim _Customer As String = String.Empty
        Dim _ExchangeRate As String = String.Empty
        Dim _GSTValue As String = String.Empty
        Dim _GenerateInvoiceNumber As ARDocument_GenerateInvoiceNumber_Enum = ARDocument_GenerateInvoiceNumber_Enum.GenerateInvoiceNumber_Upper_N
        Dim _GeographicArea As String = String.Empty
        Dim _Invoice As String = String.Empty
        Dim _InvoiceDate As String = String.Empty
        Dim _InvoiceTerms As String = String.Empty
        Dim _InvoiceValue As String = String.Empty
        Dim _PostToExistingInvoice As ARDocument_PostToExistingInvoice_Enum = ARDocument_PostToExistingInvoice_Enum.PostToExistingInvoice_Upper_N
        Dim _ProductClass As String = String.Empty
        Dim _Reference As String = String.Empty
        Dim _Salesperson As String = String.Empty
        Dim _TaxValue As String = String.Empty
        Dim _TransactionType As ARDocument_TransactionType_Enum = ARDocument_TransactionType_Enum.TransactionType_Upper_I

#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  Specifies whether the entire document must be validated first before applying the function (N - apply function for each valid item, Y - all items must be valid before function is applied). If not supplied it defaults to 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As ARDocument_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As ARDocument_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether or not a transaction must be rejected if there are any warnings such as "Document value is zero". (N - No, Y - Yes) If not supplied it defaults to 'N'. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As ARDocument_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As ARDocument_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
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
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostArInvoices() As String
            Get
                Return _PostArInvoices
            End Get
            Set(ByVal Value As String)
                _PostArInvoices = Value
            End Set
        End Property

        ''' <summary> 
        '''  This specifies the period to which the transaction must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2).
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostingPeriod() As ARDocument_PostingPeriod_Enum
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As ARDocument_PostingPeriod_Enum)
                _PostingPeriod = Value
            End Set
        End Property


        ''' <summary> 
        '''  Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document). If not supplied it defaults to 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As ARDocument_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As ARDocument_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property


        ''' <summary> 
        '''  Optional element.If this element is not supplied or if spaces are specified against this element, then the branch against the SYSPRO customer will be used, otherwise the branch supplied against this element will be used. The branch must be a valid SYSPRO branch.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Branch() As String
            Get
                Return _Branch
            End Get
            Set(ByVal Value As String)
                _Branch = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. This is the cost value of the transaction in local currency.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CostValue() As String
            Get
                Return _CostValue
            End Get
            Set(ByVal Value As String)
                _CostValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. Enter the SYSPRO customer applicable to the transaction. This must be a valid SYSPRO customer.
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
        '''  Optional element. If the SYSPRO customer is a local currency customer the value of this element is ignored and an exchange rate of 1 is always used. For foreign currency SYSPRO customers, the following rules apply: If this element is not supplied or a value of zero is supplied, the exchange rate against the SYSPRO currency code is used as the default. If this element is supplied and the SYSPRO currency code is setup with a non-fixed exchange rate, then the value against the element is used. If this element is supplied and the SYSPRO currency code is setup with a fixed exchange rate, then the value against the element must match the exchange rate setup against the SYSPRO currency code. If a debit or credit note is posted against an existing invoice, the exchange rate against the original invoice is used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ExchangeRate() As String
            Get
                Return _ExchangeRate
            End Get
            Set(ByVal Value As String)
                _ExchangeRate = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. This is the GST value of the transaction in the customers currency. This will only be used if the customer is defined as non-exempt from GST in the Customer setup and if the SYSPRO nationality code is defined as CAN.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GSTValue() As String
            Get
                Return _GSTValue
            End Get
            Set(ByVal Value As String)
                _GSTValue = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. If invoice numbering is by 'Company', then this is only available if A/R invoice key type is numeric. If invoice numbering is by 'Branch', then this element is available irrespective of the A/R invoice key type.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GenerateInvoiceNumber() As ARDocument_GenerateInvoiceNumber_Enum
            Get
                Return _GenerateInvoiceNumber
            End Get
            Set(ByVal Value As ARDocument_GenerateInvoiceNumber_Enum)
                _GenerateInvoiceNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element.If this element is not supplied or if spaces are specified against this element, then the geographic area against the SYSPRO customer will be used, otherwise the geographic area supplied against this element will be used. The geographic area must be a valid SYSPRO geographic area.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property GeographicArea() As String
            Get
                Return _GeographicArea
            End Get
            Set(ByVal Value As String)
                _GeographicArea = Value
            End Set
        End Property

        ''' <summary> 
        '''  Enter the invoice number for the transaction if not selecting to Generate Invoice Number. If the A/R invoice key type is alphanumeric then an invoice number is mandatory. If an invoice number is given as well as the 'Generate Invoice Number' being set to yes, this invoice number will be ignored and a system number will be generated.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Invoice() As String
            Get
                Return _Invoice
            End Get
            Set(ByVal Value As String)
                _Invoice = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. If this element is not supplied or if zeroes are entered against this element, the current system date will be used as the default.
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
        '''  Optional element.If this element is not supplied or if spaces are specified against this element, then the invoice terms against the SYSPRO customer will be used, otherwise the invoice terms supplied against this element will be used. The invoice terms must be a valid SYSPRO invoice terms.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceTerms() As String
            Get
                Return _InvoiceTerms
            End Get
            Set(ByVal Value As String)
                _InvoiceTerms = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. Enter the transaction value in the customer's currency. This may not be a negative value, the system will convert it to be negative for credit notes.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property InvoiceValue() As String
            Get
                Return _InvoiceValue
            End Get
            Set(ByVal Value As String)
                _InvoiceValue = Value
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
        '''  Optional element. This is only available when processing a credit note or debit note, and the 'Generate Invoice Number' option is set to No. The existing invoice number must then be input in the Invoice element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostToExistingInvoice() As ARDocument_PostToExistingInvoice_Enum
            Get
                Return _PostToExistingInvoice
            End Get
            Set(ByVal Value As ARDocument_PostToExistingInvoice_Enum)
                _PostToExistingInvoice = Value
            End Set
        End Property

        ''' <summary> 
        '''  Mandatory element. Enter the SYSPRO product class applicable to the transaction. This must be a valid SYSPRO product class.
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
        '''  Optional element. If the transaction is being posted to a Sub Account and the user has not given a Reference, then the store number from the customer master file will be used as the reference.
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
        '''  Optional element.If this element is not supplied or if spaces are specified against this element, then the salesperson against the SYSPRO customer will be used, otherwise the salesperson supplied against this element will be used. The salesperson must be a valid SYSPRO salesperson.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Salesperson() As String
            Get
                Return _Salesperson
            End Get
            Set(ByVal Value As String)
                _Salesperson = Value
            End Set
        End Property

        ''' <summary> 
        '''  Optional element. This is the tax value of the transaction in the customers currency. This will only be used if the customer is defined as non-exempt from tax in the Customer setup.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property TaxValue() As String
            Get
                Return _TaxValue
            End Get
            Set(ByVal Value As String)
                _TaxValue = Value
            End Set
        End Property

        ''' <summary>
        ''' Mandatory element. Enter the transaction type. 'I' = Invoice, 'D' = Debit note, 'C' = Credit note
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TransactionType() As ARDocument_TransactionType_Enum
            Get
                Return _TransactionType
            End Get
            Set(ByVal value As ARDocument_TransactionType_Enum)
                _TransactionType = value
            End Set
        End Property

#End Region

#Region "Enumerations"

        Public Enum ARDocument_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_Y
            ApplyIfEntireDocumentValid_Upper_N
        End Enum
        Public Enum ARDocument_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_N
        End Enum
        Public Enum ARDocument_PostingPeriod_Enum
            PostingPeriod_Upper_C
            PostingPeriod_Upper_P
            PostingPeriod_Upper_B
        End Enum
        Public Enum ARDocument_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum

        Public Enum ARDocument_GenerateInvoiceNumber_Enum
            GenerateInvoiceNumber_Upper_Y
            GenerateInvoiceNumber_Upper_N
        End Enum
        Public Enum ARDocument_PostToExistingInvoice_Enum
            PostToExistingInvoice_Upper_Y
            PostToExistingInvoice_Upper_N
        End Enum
        Public Enum ARDocument_TransactionType_Enum
            TransactionType_Upper_I
            TransactionType_Upper_C
            TransactionType_Upper_D
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim PostArInvoices As System.Xml.XmlElement = xmlDoc.CreateElement("PostArInvoices")
            Dim PostingPeriod As System.Xml.XmlElement = xmlDoc.CreateElement("PostingPeriod")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")


            xmlDoc.AppendChild(PostArInvoices)
            Common.SysproUtilities.AppendXMLElement(PostArInvoices, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, PostingPeriod, Common.SysproUtilities.GetEnumValue(_PostingPeriod.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim Branch As System.Xml.XmlElement = xmlDoc.CreateElement("Branch")
            Dim CostValue As System.Xml.XmlElement = xmlDoc.CreateElement("CostValue")
            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim ExchangeRate As System.Xml.XmlElement = xmlDoc.CreateElement("ExchangeRate")
            Dim GSTValue As System.Xml.XmlElement = xmlDoc.CreateElement("GSTValue")
            Dim GenerateInvoiceNumber As System.Xml.XmlElement = xmlDoc.CreateElement("GenerateInvoiceNumber")
            Dim GeographicArea As System.Xml.XmlElement = xmlDoc.CreateElement("GeographicArea")
            Dim Invoice As System.Xml.XmlElement = xmlDoc.CreateElement("Invoice")
            Dim InvoiceDate As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceDate")
            Dim InvoiceTerms As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceTerms")
            Dim InvoiceValue As System.Xml.XmlElement = xmlDoc.CreateElement("InvoiceValue")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim PostArInvoices As System.Xml.XmlElement = xmlDoc.CreateElement("PostArInvoices")
            Dim PostToExistingInvoice As System.Xml.XmlElement = xmlDoc.CreateElement("PostToExistingInvoice")
            Dim ProductClass As System.Xml.XmlElement = xmlDoc.CreateElement("ProductClass")
            Dim Reference As System.Xml.XmlElement = xmlDoc.CreateElement("Reference")
            Dim Salesperson As System.Xml.XmlElement = xmlDoc.CreateElement("Salesperson")
            Dim TaxValue As System.Xml.XmlElement = xmlDoc.CreateElement("TaxValue")
            Dim TransactionType As System.Xml.XmlElement = xmlDoc.CreateElement("TransactionType")

            xmlDoc.AppendChild(PostArInvoices)
            Common.SysproUtilities.AppendXMLElement(PostArInvoices, Item, _Item.ToString)
            If _Branch.Trim.Length > 0 Then
                Common.SysproUtilities.AppendXMLElement(Item, Branch, _Branch.ToString)
            End If

            Common.SysproUtilities.AppendXMLElement(Item, CostValue, _CostValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, ExchangeRate, _ExchangeRate.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, GSTValue, _GSTValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, GenerateInvoiceNumber, Common.SysproUtilities.GetEnumValue(_GenerateInvoiceNumber.ToString))
            If _GeographicArea.Trim.Length > 0 Then
                Common.SysproUtilities.AppendXMLElement(Item, GeographicArea, _GeographicArea.ToString)
            End If
            Common.SysproUtilities.AppendXMLElement(Item, Invoice, _Invoice.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, InvoiceDate, _InvoiceDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, InvoiceTerms, _InvoiceTerms.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, InvoiceValue, _InvoiceValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PostToExistingInvoice, Common.SysproUtilities.GetEnumValue(_PostToExistingInvoice.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, ProductClass, _ProductClass.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Reference, _Reference.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Salesperson, _Salesperson.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, TaxValue, _TaxValue.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, TransactionType, Common.SysproUtilities.GetEnumValue(_TransactionType.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region " Interface "

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
                Return "ARSTIN"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            Select Case ActionType
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

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode
                Dim str As String = ""
                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Item/Invoice")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If

            End Get
        End Property

    End Class

End Namespace
