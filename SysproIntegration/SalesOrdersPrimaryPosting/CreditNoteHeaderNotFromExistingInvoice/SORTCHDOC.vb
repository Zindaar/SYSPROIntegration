Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.CreditNoteHeaderNotFromExistingInvoice.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class SOCreditNoteHeader
        Implements ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As SOCreditNoteHeaderItem

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.SOCreditNoteHeaderParameters

        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New SOCreditNoteHeaderItem()
            End If
        End Sub

        Public Property Item() As SOCreditNoteHeaderItem
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTCH"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.SOCreditNoteHeaderParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.SOCreditNoteHeaderParameters()
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.SOCreditNoteHeader
                objParams = New Params.SOCreditNoteHeader()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class SOCreditNoteHeaderItem

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private customerField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private creditNoteNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private customerPoNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private creditNoteDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private invoiceNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private branchField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private salespersonField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private aRInvoiceTermsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private paymentMethodField As SOCreditNoteHeaderItemPaymentMethod

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private geographicAreaField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private alternateReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private multipleShipCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shippingInstrsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shippingInstrsCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress3LocalityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipAddress5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipPostalCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipGPSLatField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shipGPSLongField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private languageCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private emailField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private specialInstrsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderDiscPercent1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderDiscPercent2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderDiscPercent3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private nationalityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private deliveryTermsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private shippingLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private transactionNatureField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private transportModeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private processFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private taxExemptNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private taxExemptStatusField As SOCreditNoteHeaderItemTaxExemptStatus

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private taxExemptStatusFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private gstExemptNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private gstExemptStatusField As SOCreditNoteHeaderItemGstExemptStatus

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private gstExemptStatusFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private companyTaxNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private stateField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private countyZipField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private cityField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private orderCommentsField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private documentFormatField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private eSignatureField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private pOSSalesOrderField As String

        Public Sub New()
            MyBase.New
            Me.paymentMethodField = SOCreditNoteHeaderItemPaymentMethod.CR
        End Sub

        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = Value
            End Set
        End Property

        Public Property CreditNoteNumber() As String
            Get
                Return Me.creditNoteNumberField
            End Get
            Set
                Me.creditNoteNumberField = Value
            End Set
        End Property

        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = Value
            End Set
        End Property

        Public Property CreditNoteDate() As String
            Get
                Return Me.creditNoteDateField
            End Get
            Set
                Me.creditNoteDateField = Value
            End Set
        End Property

        Public Property InvoiceNumber() As String
            Get
                Return Me.invoiceNumberField
            End Get
            Set
                Me.invoiceNumberField = Value
            End Set
        End Property

        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = Value
            End Set
        End Property

        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set
                Me.salespersonField = Value
            End Set
        End Property

        Public Property ARInvoiceTerms() As String
            Get
                Return Me.aRInvoiceTermsField
            End Get
            Set
                Me.aRInvoiceTermsField = Value
            End Set
        End Property

        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(SOCreditNoteHeaderItemPaymentMethod.CR)>
        Public Property PaymentMethod() As SOCreditNoteHeaderItemPaymentMethod
            Get
                Return Me.paymentMethodField
            End Get
            Set
                Me.paymentMethodField = Value
            End Set
        End Property

        Public Property GeographicArea() As String
            Get
                Return Me.geographicAreaField
            End Get
            Set
                Me.geographicAreaField = Value
            End Set
        End Property

        Public Property AlternateReference() As String
            Get
                Return Me.alternateReferenceField
            End Get
            Set
                Me.alternateReferenceField = Value
            End Set
        End Property

        Public Property MultipleShipCode() As String
            Get
                Return Me.multipleShipCodeField
            End Get
            Set
                Me.multipleShipCodeField = Value
            End Set
        End Property

        Public Property ShipDate() As String
            Get
                Return Me.shipDateField
            End Get
            Set
                Me.shipDateField = Value
            End Set
        End Property

        Public Property ShipName() As String
            Get
                Return Me.shipNameField
            End Get
            Set
                Me.shipNameField = Value
            End Set
        End Property

        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = Value
            End Set
        End Property

        Public Property ShippingInstrsCode() As String
            Get
                Return Me.shippingInstrsCodeField
            End Get
            Set
                Me.shippingInstrsCodeField = Value
            End Set
        End Property

        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = Value
            End Set
        End Property

        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = Value
            End Set
        End Property

        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = Value
            End Set
        End Property

        Public Property ShipAddress3Locality() As String
            Get
                Return Me.shipAddress3LocalityField
            End Get
            Set
                Me.shipAddress3LocalityField = Value
            End Set
        End Property

        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = Value
            End Set
        End Property

        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = Value
            End Set
        End Property

        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = Value
            End Set
        End Property

        Public Property ShipGPSLat() As String
            Get
                Return Me.shipGPSLatField
            End Get
            Set
                Me.shipGPSLatField = Value
            End Set
        End Property

        Public Property ShipGPSLong() As String
            Get
                Return Me.shipGPSLongField
            End Get
            Set
                Me.shipGPSLongField = Value
            End Set
        End Property

        Public Property LanguageCode() As String
            Get
                Return Me.languageCodeField
            End Get
            Set
                Me.languageCodeField = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = Value
            End Set
        End Property

        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = Value
            End Set
        End Property

        Public Property OrderDiscPercent1() As String
            Get
                Return Me.orderDiscPercent1Field
            End Get
            Set
                Me.orderDiscPercent1Field = Value
            End Set
        End Property

        Public Property OrderDiscPercent2() As String
            Get
                Return Me.orderDiscPercent2Field
            End Get
            Set
                Me.orderDiscPercent2Field = Value
            End Set
        End Property

        Public Property OrderDiscPercent3() As String
            Get
                Return Me.orderDiscPercent3Field
            End Get
            Set
                Me.orderDiscPercent3Field = Value
            End Set
        End Property

        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = Value
            End Set
        End Property

        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = Value
            End Set
        End Property

        Public Property ShippingLocation() As String
            Get
                Return Me.shippingLocationField
            End Get
            Set
                Me.shippingLocationField = Value
            End Set
        End Property

        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set
                Me.transactionNatureField = Value
            End Set
        End Property

        Public Property TransportMode() As String
            Get
                Return Me.transportModeField
            End Get
            Set
                Me.transportModeField = Value
            End Set
        End Property

        Public Property ProcessFlag() As String
            Get
                Return Me.processFlagField
            End Get
            Set
                Me.processFlagField = Value
            End Set
        End Property

        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set
                Me.taxExemptNumberField = Value
            End Set
        End Property

        Public Property TaxExemptStatus() As SOCreditNoteHeaderItemTaxExemptStatus
            Get
                Return Me.taxExemptStatusField
            End Get
            Set
                Me.taxExemptStatusField = Value
                Me.taxExemptStatusFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property TaxExemptStatusSpecified() As Boolean
            Get
                Return Me.taxExemptStatusFieldSpecified
            End Get
        End Property

        Public Property GstExemptNumber() As String
            Get
                Return Me.gstExemptNumberField
            End Get
            Set
                Me.gstExemptNumberField = Value
            End Set
        End Property

        Public Property GstExemptStatus() As SOCreditNoteHeaderItemGstExemptStatus
            Get
                Return Me.gstExemptStatusField
            End Get
            Set
                Me.gstExemptStatusField = Value
                Me.gstExemptStatusFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReadOnly Property GstExemptStatusSpecified() As Boolean
            Get
                Return Me.gstExemptStatusFieldSpecified
            End Get
        End Property

        Public Property CompanyTaxNumber() As String
            Get
                Return Me.companyTaxNumberField
            End Get
            Set
                Me.companyTaxNumberField = Value
            End Set
        End Property

        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = Value
            End Set
        End Property

        Public Property CountyZip() As String
            Get
                Return Me.countyZipField
            End Get
            Set
                Me.countyZipField = Value
            End Set
        End Property

        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = Value
            End Set
        End Property

        Public Property OrderComments() As String
            Get
                Return Me.orderCommentsField
            End Get
            Set
                Me.orderCommentsField = Value
            End Set
        End Property

        Public Property DocumentFormat() As String
            Get
                Return Me.documentFormatField
            End Get
            Set
                Me.documentFormatField = Value
            End Set
        End Property

        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = Value
            End Set
        End Property

        Public Property POSSalesOrder() As String
            Get
                Return Me.pOSSalesOrderField
            End Get
            Set
                Me.pOSSalesOrderField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum SOCreditNoteHeaderItemPaymentMethod

        '''<remarks/>
        CR

        '''<remarks/>
        CS
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum SOCreditNoteHeaderItemTaxExemptStatus

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        N

        '''<remarks/>
        O

        '''<remarks/>
        E
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum SOCreditNoteHeaderItemGstExemptStatus

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>
        Item

        '''<remarks/>
        N

        '''<remarks/>
        O

        '''<remarks/>
        E
    End Enum
End Namespace
