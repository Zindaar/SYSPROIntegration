Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.PartBillings.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostPartBillings
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As PostPartBillingsItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostPartBillingsParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostPartBillingsItem
            End If
        End Sub

        Public Property Item() As PostPartBillingsItem
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As PostPartBillingsItem)
                Me.itemField = value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTPB"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostPartBillingsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostPartBillingsParameters
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostPartBillings
                objParams = New Params.PostPartBillings
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private quantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private quantityToBillFlagField As PostPartBillingsItemQuantityToBillFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private completeField As PostPartBillingsItemComplete

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private closeDateField As PostPartBillingsItemCloseDate

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private materialValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private laborValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costBasisField As PostPartBillingsItemCostBasis

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costBasisFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private wipValueBasisField As PostPartBillingsItemWipValueBasis

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private wipValueBasisFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private distributionField As PostPartBillingsItemDistribution

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyJobField As PostPartBillingsItemHierarchyJob

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderLinkField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private billingMethodField As PostPartBillingsItemBillingMethod

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private increaseSalesOrderQuantityField As PostPartBillingsItemIncreaseSalesOrderQuantity

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderHeaderField As PostPartBillingsItemOrderHeader

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderDetailsField As PostPartBillingsItemOrderDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private backOrderReleaseField As PostPartBillingsItemBackOrderRelease

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private addReferenceField As String

        Public Sub New()
            MyBase.New()
            Me.quantityToBillFlagField = PostPartBillingsItemQuantityToBillFlag.N
            Me.completeField = PostPartBillingsItemComplete.N
            Me.closeDateField = PostPartBillingsItemCloseDate.N
            Me.billingMethodField = PostPartBillingsItemBillingMethod.S
            Me.increaseSalesOrderQuantityField = PostPartBillingsItemIncreaseSalesOrderQuantity.N
            If (Me.backOrderReleaseField Is Nothing) Then
                Me.backOrderReleaseField = New PostPartBillingsItemBackOrderRelease
            End If
            If (Me.orderDetailsField Is Nothing) Then
                Me.orderDetailsField = New PostPartBillingsItemOrderDetails
            End If
            If (Me.orderHeaderField Is Nothing) Then
                Me.orderHeaderField = New PostPartBillingsItemOrderHeader
            End If
            If (Me.hierarchyJobField Is Nothing) Then
                Me.hierarchyJobField = New PostPartBillingsItemHierarchyJob
            End If
            If (Me.distributionField Is Nothing) Then
                Me.distributionField = New PostPartBillingsItemDistribution
            End If
        End Sub

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = value
            End Set
        End Property

        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set(ByVal value As String)
                Me.jobField = value
            End Set
        End Property

        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set(ByVal value As String)
                Me.quantityField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemQuantityToBillFlag.N)> _
        Public Property QuantityToBillFlag() As PostPartBillingsItemQuantityToBillFlag
            Get
                Return Me.quantityToBillFlagField
            End Get
            Set(ByVal value As PostPartBillingsItemQuantityToBillFlag)
                Me.quantityToBillFlagField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemComplete.N)> _
        Public Property Complete() As PostPartBillingsItemComplete
            Get
                Return Me.completeField
            End Get
            Set(ByVal value As PostPartBillingsItemComplete)
                Me.completeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemCloseDate.N)> _
        Public Property CloseDate() As PostPartBillingsItemCloseDate
            Get
                Return Me.closeDateField
            End Get
            Set(ByVal value As PostPartBillingsItemCloseDate)
                Me.closeDateField = value
            End Set
        End Property

        Public Property MaterialValue() As String
            Get
                Return Me.materialValueField
            End Get
            Set(ByVal value As String)
                Me.materialValueField = value
            End Set
        End Property

        Public Property LaborValue() As String
            Get
                Return Me.laborValueField
            End Get
            Set(ByVal value As String)
                Me.laborValueField = value
            End Set
        End Property

        Public Property CostBasis() As PostPartBillingsItemCostBasis
            Get
                Return Me.costBasisField
            End Get
            Set(ByVal value As PostPartBillingsItemCostBasis)
                Me.costBasisField = value
                Me.CostBasisFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property CostBasisSpecified() As Boolean
            Get
                Return Me.costBasisFieldSpecified
            End Get
        End Property

        Public Property WipValueBasis() As PostPartBillingsItemWipValueBasis
            Get
                Return Me.wipValueBasisField
            End Get
            Set(ByVal value As PostPartBillingsItemWipValueBasis)
                Me.wipValueBasisField = value
                Me.WipValueBasisFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property WipValueBasisSpecified() As Boolean
            Get
                Return Me.wipValueBasisFieldSpecified
            End Get
        End Property

        Public Property Distribution() As PostPartBillingsItemDistribution
            Get
                Return Me.distributionField
            End Get
            Set(ByVal value As PostPartBillingsItemDistribution)
                Me.distributionField = value
            End Set
        End Property

        Public Property HierarchyJob() As PostPartBillingsItemHierarchyJob
            Get
                Return Me.hierarchyJobField
            End Get
            Set(ByVal value As PostPartBillingsItemHierarchyJob)
                Me.hierarchyJobField = value
            End Set
        End Property

        Public Property SalesOrderLink() As String
            Get
                Return Me.salesOrderLinkField
            End Get
            Set(ByVal value As String)
                Me.salesOrderLinkField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemBillingMethod.S)> _
        Public Property BillingMethod() As PostPartBillingsItemBillingMethod
            Get
                Return Me.billingMethodField
            End Get
            Set(ByVal value As PostPartBillingsItemBillingMethod)
                Me.billingMethodField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemIncreaseSalesOrderQuantity.N)> _
        Public Property IncreaseSalesOrderQuantity() As PostPartBillingsItemIncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set(ByVal value As PostPartBillingsItemIncreaseSalesOrderQuantity)
                Me.increaseSalesOrderQuantityField = value
            End Set
        End Property

        Public Property OrderHeader() As PostPartBillingsItemOrderHeader
            Get
                Return Me.orderHeaderField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeader)
                Me.orderHeaderField = value
            End Set
        End Property

        Public Property OrderDetails() As PostPartBillingsItemOrderDetails
            Get
                Return Me.orderDetailsField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetails)
                Me.orderDetailsField = value
            End Set
        End Property

        Public Property BackOrderRelease() As PostPartBillingsItemBackOrderRelease
            Get
                Return Me.backOrderReleaseField
            End Get
            Set(ByVal value As PostPartBillingsItemBackOrderRelease)
                Me.backOrderReleaseField = value
            End Set
        End Property

        Public Property AddReference() As String
            Get
                Return Me.addReferenceField
            End Get
            Set(ByVal value As String)
                Me.addReferenceField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemQuantityToBillFlag

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemComplete

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemCloseDate

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemCostBasis

        '''<remarks/>
        U

        '''<remarks/>
        T
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemWipValueBasis

        '''<remarks/>
        W

        '''<remarks/>
        E

        '''<remarks/>
        A
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItemDistribution

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerAmountField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private passwordForLedgerCodeField As String

        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set(ByVal value As String)
                Me.ledgerCodeField = value
            End Set
        End Property

        Public Property LedgerAmount() As String
            Get
                Return Me.ledgerAmountField
            End Get
            Set(ByVal value As String)
                Me.ledgerAmountField = value
            End Set
        End Property

        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set(ByVal value As String)
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItemHierarchyJob

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private headField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private section1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private section2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private section3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private section4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private attachedTypeField As PostPartBillingsItemHierarchyJobAttachedType

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private hierarchyAttachedToField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costOfSalesAmountField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private billingAmountField As String

        Public Sub New()
            MyBase.New()
            Me.attachedTypeField = PostPartBillingsItemHierarchyJobAttachedType.M
        End Sub

        Public Property Head() As String
            Get
                Return Me.headField
            End Get
            Set(ByVal value As String)
                Me.headField = value
            End Set
        End Property

        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set(ByVal value As String)
                Me.section1Field = value
            End Set
        End Property

        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set(ByVal value As String)
                Me.section2Field = value
            End Set
        End Property

        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set(ByVal value As String)
                Me.section3Field = value
            End Set
        End Property

        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set(ByVal value As String)
                Me.section4Field = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemHierarchyJobAttachedType.M)> _
        Public Property AttachedType() As PostPartBillingsItemHierarchyJobAttachedType
            Get
                Return Me.attachedTypeField
            End Get
            Set(ByVal value As PostPartBillingsItemHierarchyJobAttachedType)
                Me.attachedTypeField = value
            End Set
        End Property

        Public Property HierarchyAttachedTo() As String
            Get
                Return Me.hierarchyAttachedToField
            End Get
            Set(ByVal value As String)
                Me.hierarchyAttachedToField = value
            End Set
        End Property

        Public Property CostOfSalesAmount() As String
            Get
                Return Me.costOfSalesAmountField
            End Get
            Set(ByVal value As String)
                Me.costOfSalesAmountField = value
            End Set
        End Property

        Public Property BillingAmount() As String
            Get
                Return Me.billingAmountField
            End Get
            Set(ByVal value As String)
                Me.billingAmountField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemHierarchyJobAttachedType

        '''<remarks/>
        M

        '''<remarks/>
        O

        '''<remarks/>
        P

        '''<remarks/>
        T
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemBillingMethod

        '''<remarks/>
        S

        '''<remarks/>
        P

        '''<remarks/>
        L
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemIncreaseSalesOrderQuantity

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItemOrderHeader

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerPoNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceTermsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private branchField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private areaField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shippingInstrsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private customerNameField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipAddress1Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipAddress2Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipAddress3Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipAddress4Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipAddress5Field As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipPostalCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private specialInstrsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private extendedTaxCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fixExchangeRateField As PostPartBillingsItemOrderHeaderFixExchangeRate

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private exchangeRateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private paymentMethodField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderStatusField As PostPartBillingsItemOrderHeaderOrderStatus

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private multiShipCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private alternateReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salespersonField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxStatusField As PostPartBillingsItemOrderHeaderTaxStatus

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxExemptNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private gstExemptFlagField As PostPartBillingsItemOrderHeaderGstExemptFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private gstRegistrationNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nationalityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private deliveryTermsField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transactionNatureField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private transportModeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private processFlagField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private requestedShipDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private shipLineCompleteField As PostPartBillingsItemOrderHeaderShipLineComplete

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private invoiceNumberEnteredField As String

        Public Sub New()
            MyBase.New()
            Me.fixExchangeRateField = PostPartBillingsItemOrderHeaderFixExchangeRate.N
            Me.orderStatusField = PostPartBillingsItemOrderHeaderOrderStatus.Item8
            Me.taxStatusField = PostPartBillingsItemOrderHeaderTaxStatus.E
            Me.gstExemptFlagField = PostPartBillingsItemOrderHeaderGstExemptFlag.E
            Me.shipLineCompleteField = PostPartBillingsItemOrderHeaderShipLineComplete.N
        End Sub

        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set(ByVal value As String)
                Me.customerPoNumberField = value
            End Set
        End Property

        Public Property InvoiceTerms() As String
            Get
                Return Me.invoiceTermsField
            End Get
            Set(ByVal value As String)
                Me.invoiceTermsField = value
            End Set
        End Property

        Public Property Branch() As String
            Get
                Return Me.branchField
            End Get
            Set(ByVal value As String)
                Me.branchField = value
            End Set
        End Property

        Public Property Area() As String
            Get
                Return Me.areaField
            End Get
            Set(ByVal value As String)
                Me.areaField = value
            End Set
        End Property

        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set(ByVal value As String)
                Me.shippingInstrsField = value
            End Set
        End Property

        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set(ByVal value As String)
                Me.customerNameField = value
            End Set
        End Property

        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set(ByVal value As String)
                Me.shipAddress1Field = value
            End Set
        End Property

        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set(ByVal value As String)
                Me.shipAddress2Field = value
            End Set
        End Property

        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set(ByVal value As String)
                Me.shipAddress3Field = value
            End Set
        End Property

        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set(ByVal value As String)
                Me.shipAddress4Field = value
            End Set
        End Property

        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set(ByVal value As String)
                Me.shipAddress5Field = value
            End Set
        End Property

        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set(ByVal value As String)
                Me.shipPostalCodeField = value
            End Set
        End Property

        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set(ByVal value As String)
                Me.specialInstrsField = value
            End Set
        End Property

        Public Property ExtendedTaxCode() As String
            Get
                Return Me.extendedTaxCodeField
            End Get
            Set(ByVal value As String)
                Me.extendedTaxCodeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderHeaderFixExchangeRate.N)> _
        Public Property FixExchangeRate() As PostPartBillingsItemOrderHeaderFixExchangeRate
            Get
                Return Me.fixExchangeRateField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeaderFixExchangeRate)
                Me.fixExchangeRateField = value
            End Set
        End Property

        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set(ByVal value As String)
                Me.exchangeRateField = value
            End Set
        End Property

        Public Property PaymentMethod() As String
            Get
                Return Me.paymentMethodField
            End Get
            Set(ByVal value As String)
                Me.paymentMethodField = value
            End Set
        End Property

        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set(ByVal value As String)
                Me.salesOrderField = value
            End Set
        End Property

        Public Property OrderType() As String
            Get
                Return Me.orderTypeField
            End Get
            Set(ByVal value As String)
                Me.orderTypeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderHeaderOrderStatus.Item8)> _
        Public Property OrderStatus() As PostPartBillingsItemOrderHeaderOrderStatus
            Get
                Return Me.orderStatusField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeaderOrderStatus)
                Me.orderStatusField = value
            End Set
        End Property

        Public Property MultiShipCode() As String
            Get
                Return Me.multiShipCodeField
            End Get
            Set(ByVal value As String)
                Me.multiShipCodeField = value
            End Set
        End Property

        Public Property AlternateReference() As String
            Get
                Return Me.alternateReferenceField
            End Get
            Set(ByVal value As String)
                Me.alternateReferenceField = value
            End Set
        End Property

        Public Property Salesperson() As String
            Get
                Return Me.salespersonField
            End Get
            Set(ByVal value As String)
                Me.salespersonField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderHeaderTaxStatus.E)> _
        Public Property TaxStatus() As PostPartBillingsItemOrderHeaderTaxStatus
            Get
                Return Me.taxStatusField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeaderTaxStatus)
                Me.taxStatusField = value
            End Set
        End Property

        Public Property TaxExemptNumber() As String
            Get
                Return Me.taxExemptNumberField
            End Get
            Set(ByVal value As String)
                Me.taxExemptNumberField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderHeaderGstExemptFlag.E)> _
        Public Property GstExemptFlag() As PostPartBillingsItemOrderHeaderGstExemptFlag
            Get
                Return Me.gstExemptFlagField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeaderGstExemptFlag)
                Me.gstExemptFlagField = value
            End Set
        End Property

        Public Property GstRegistrationNumber() As String
            Get
                Return Me.gstRegistrationNumberField
            End Get
            Set(ByVal value As String)
                Me.gstRegistrationNumberField = value
            End Set
        End Property

        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set(ByVal value As String)
                Me.nationalityField = value
            End Set
        End Property

        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set(ByVal value As String)
                Me.deliveryTermsField = value
            End Set
        End Property

        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set(ByVal value As String)
                Me.transactionNatureField = value
            End Set
        End Property

        Public Property TransportMode() As String
            Get
                Return Me.transportModeField
            End Get
            Set(ByVal value As String)
                Me.transportModeField = value
            End Set
        End Property

        Public Property ProcessFlag() As String
            Get
                Return Me.processFlagField
            End Get
            Set(ByVal value As String)
                Me.processFlagField = value
            End Set
        End Property

        Public Property RequestedShipDate() As String
            Get
                Return Me.requestedShipDateField
            End Get
            Set(ByVal value As String)
                Me.requestedShipDateField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderHeaderShipLineComplete.N)> _
        Public Property ShipLineComplete() As PostPartBillingsItemOrderHeaderShipLineComplete
            Get
                Return Me.shipLineCompleteField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderHeaderShipLineComplete)
                Me.shipLineCompleteField = value
            End Set
        End Property

        Public Property InvoiceNumberEntered() As String
            Get
                Return Me.invoiceNumberEnteredField
            End Get
            Set(ByVal value As String)
                Me.invoiceNumberEnteredField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderHeaderFixExchangeRate

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderHeaderOrderStatus

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")> _
        Item8

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")> _
        Item3

        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")> _
        Item4

        '''<remarks/>
        S
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderHeaderTaxStatus

        '''<remarks/>
        E

        '''<remarks/>
        N

        '''<remarks/>
        O
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderHeaderGstExemptFlag

        '''<remarks/>
        E

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderHeaderShipLineComplete

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItemOrderDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockDescriptionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private orderValueField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private productClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private commissionCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxableField As PostPartBillingsItemOrderDetailsTaxable

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private taxCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private gSTTaxableField As PostPartBillingsItemOrderDetailsGSTTaxable

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private federalSalesTaxField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private concessionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private certificateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private markupBasisField As PostPartBillingsItemOrderDetailsMarkupBasis

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private materialMarkupField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private laborMarkupField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyProductClassToStockField As PostPartBillingsItemOrderDetailsApplyProductClassToStock

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operationProductClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private createOperationDetailsField As PostPartBillingsItemOrderDetailsCreateOperationDetails

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private summariseByProductClassField As PostPartBillingsItemOrderDetailsSummariseByProductClass

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private operationCommentTextField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private useRecommendedCostField As PostPartBillingsItemOrderDetailsUseRecommendedCost

        Public Sub New()
            MyBase.New()
            Me.taxableField = PostPartBillingsItemOrderDetailsTaxable.N
            Me.gSTTaxableField = PostPartBillingsItemOrderDetailsGSTTaxable.N
            Me.markupBasisField = PostPartBillingsItemOrderDetailsMarkupBasis.L
            Me.applyProductClassToStockField = PostPartBillingsItemOrderDetailsApplyProductClassToStock.N
            Me.createOperationDetailsField = PostPartBillingsItemOrderDetailsCreateOperationDetails.N
            Me.summariseByProductClassField = PostPartBillingsItemOrderDetailsSummariseByProductClass.N
            Me.useRecommendedCostField = PostPartBillingsItemOrderDetailsUseRecommendedCost.N
        End Sub

        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set(ByVal value As String)
                Me.stockDescriptionField = value
            End Set
        End Property

        Public Property OrderValue() As String
            Get
                Return Me.orderValueField
            End Get
            Set(ByVal value As String)
                Me.orderValueField = value
            End Set
        End Property

        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set(ByVal value As String)
                Me.productClassField = value
            End Set
        End Property

        Public Property CommissionCode() As String
            Get
                Return Me.commissionCodeField
            End Get
            Set(ByVal value As String)
                Me.commissionCodeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsTaxable.N)> _
        Public Property Taxable() As PostPartBillingsItemOrderDetailsTaxable
            Get
                Return Me.taxableField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsTaxable)
                Me.taxableField = value
            End Set
        End Property

        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set(ByVal value As String)
                Me.taxCodeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsGSTTaxable.N)> _
        Public Property GSTTaxable() As PostPartBillingsItemOrderDetailsGSTTaxable
            Get
                Return Me.gSTTaxableField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsGSTTaxable)
                Me.gSTTaxableField = value
            End Set
        End Property

        Public Property FederalSalesTax() As String
            Get
                Return Me.federalSalesTaxField
            End Get
            Set(ByVal value As String)
                Me.federalSalesTaxField = value
            End Set
        End Property

        Public Property LotNumber() As String
            Get
                Return Me.lotNumberField
            End Get
            Set(ByVal value As String)
                Me.lotNumberField = value
            End Set
        End Property

        Public Property Concession() As String
            Get
                Return Me.concessionField
            End Get
            Set(ByVal value As String)
                Me.concessionField = value
            End Set
        End Property

        Public Property Certificate() As String
            Get
                Return Me.certificateField
            End Get
            Set(ByVal value As String)
                Me.certificateField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsMarkupBasis.L)> _
        Public Property MarkupBasis() As PostPartBillingsItemOrderDetailsMarkupBasis
            Get
                Return Me.markupBasisField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsMarkupBasis)
                Me.markupBasisField = value
            End Set
        End Property

        Public Property MaterialMarkup() As String
            Get
                Return Me.materialMarkupField
            End Get
            Set(ByVal value As String)
                Me.materialMarkupField = value
            End Set
        End Property

        Public Property LaborMarkup() As String
            Get
                Return Me.laborMarkupField
            End Get
            Set(ByVal value As String)
                Me.laborMarkupField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsApplyProductClassToStock.N)> _
        Public Property ApplyProductClassToStock() As PostPartBillingsItemOrderDetailsApplyProductClassToStock
            Get
                Return Me.applyProductClassToStockField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsApplyProductClassToStock)
                Me.applyProductClassToStockField = value
            End Set
        End Property

        Public Property OperationProductClass() As String
            Get
                Return Me.operationProductClassField
            End Get
            Set(ByVal value As String)
                Me.operationProductClassField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsCreateOperationDetails.N)> _
        Public Property CreateOperationDetails() As PostPartBillingsItemOrderDetailsCreateOperationDetails
            Get
                Return Me.createOperationDetailsField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsCreateOperationDetails)
                Me.createOperationDetailsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsSummariseByProductClass.N)> _
        Public Property SummariseByProductClass() As PostPartBillingsItemOrderDetailsSummariseByProductClass
            Get
                Return Me.summariseByProductClassField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsSummariseByProductClass)
                Me.summariseByProductClassField = value
            End Set
        End Property

        Public Property OperationCommentText() As String
            Get
                Return Me.operationCommentTextField
            End Get
            Set(ByVal value As String)
                Me.operationCommentTextField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemOrderDetailsUseRecommendedCost.N)> _
        Public Property UseRecommendedCost() As PostPartBillingsItemOrderDetailsUseRecommendedCost
            Get
                Return Me.useRecommendedCostField
            End Get
            Set(ByVal value As PostPartBillingsItemOrderDetailsUseRecommendedCost)
                Me.useRecommendedCostField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsTaxable

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsGSTTaxable

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsMarkupBasis

        '''<remarks/>
        L

        '''<remarks/>
        M

        '''<remarks/>
        C
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsApplyProductClassToStock

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsCreateOperationDetails

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsSummariseByProductClass

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemOrderDetailsUseRecommendedCost

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostPartBillingsItemBackOrderRelease

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private releaseQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private costField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private backOrderCostBasisField As PostPartBillingsItemBackOrderReleaseBackOrderCostBasis

        Public Sub New()
            MyBase.New()
            Me.backOrderCostBasisField = PostPartBillingsItemBackOrderReleaseBackOrderCostBasis.U
        End Sub

        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set(ByVal value As String)
                Me.stockCodeField = value
            End Set
        End Property

        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set(ByVal value As String)
                Me.salesOrderLineField = value
            End Set
        End Property

        Public Property ReleaseQuantity() As String
            Get
                Return Me.releaseQuantityField
            End Get
            Set(ByVal value As String)
                Me.releaseQuantityField = value
            End Set
        End Property

        Public Property Cost() As String
            Get
                Return Me.costField
            End Get
            Set(ByVal value As String)
                Me.costField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostPartBillingsItemBackOrderReleaseBackOrderCostBasis.U)> _
        Public Property BackOrderCostBasis() As PostPartBillingsItemBackOrderReleaseBackOrderCostBasis
            Get
                Return Me.backOrderCostBasisField
            End Get
            Set(ByVal value As PostPartBillingsItemBackOrderReleaseBackOrderCostBasis)
                Me.backOrderCostBasisField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostPartBillingsItemBackOrderReleaseBackOrderCostBasis

        '''<remarks/>
        U

        '''<remarks/>
        T
    End Enum
End Namespace
