Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderSupplierContracts.PurchaseOrderSupplierContract.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSupplierContract
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of PostSupplierContractItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostSupplierContractParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostSupplierContractItem)()
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of PostSupplierContractItem)
            Get
                Return Me.itemField
            End Get
            Set
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
                Return "PORTSC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostSupplierContractParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostSupplierContractParameters()
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
                Dim objParams As Params.PostSupplierContract
                objParams = New Params.PostSupplierContract()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSupplierContractItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private contractField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchasePriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private packSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceStartDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceQuoteDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightChargesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPct3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumQtyUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCommentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightCommentField As String
        
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Contract() As String
            Get
                Return Me.contractField
            End Get
            Set
                Me.contractField = value
            End Set
        End Property
        
        Public Property PriceReference() As String
            Get
                Return Me.priceReferenceField
            End Get
            Set
                Me.priceReferenceField = value
            End Set
        End Property
        
        Public Property PurchasePrice() As String
            Get
                Return Me.purchasePriceField
            End Get
            Set
                Me.purchasePriceField = value
            End Set
        End Property
        
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        Public Property DiscountCode() As String
            Get
                Return Me.discountCodeField
            End Get
            Set
                Me.discountCodeField = value
            End Set
        End Property
        
        Public Property PackSize() As String
            Get
                Return Me.packSizeField
            End Get
            Set
                Me.packSizeField = value
            End Set
        End Property
        
        Public Property MinimumQty() As String
            Get
                Return Me.minimumQtyField
            End Get
            Set
                Me.minimumQtyField = value
            End Set
        End Property
        
        Public Property PriceStartDate() As String
            Get
                Return Me.priceStartDateField
            End Get
            Set
                Me.priceStartDateField = value
            End Set
        End Property
        
        Public Property PriceExpiryDate() As String
            Get
                Return Me.priceExpiryDateField
            End Get
            Set
                Me.priceExpiryDateField = value
            End Set
        End Property
        
        Public Property PriceQuoteDate() As String
            Get
                Return Me.priceQuoteDateField
            End Get
            Set
                Me.priceQuoteDateField = value
            End Set
        End Property
        
        Public Property QuoteLeadTime() As String
            Get
                Return Me.quoteLeadTimeField
            End Get
            Set
                Me.quoteLeadTimeField = value
            End Set
        End Property
        
        Public Property FreightCharges() As String
            Get
                Return Me.freightChargesField
            End Get
            Set
                Me.freightChargesField = value
            End Set
        End Property
        
        Public Property DiscPct1() As String
            Get
                Return Me.discPct1Field
            End Get
            Set
                Me.discPct1Field = value
            End Set
        End Property
        
        Public Property DiscPct2() As String
            Get
                Return Me.discPct2Field
            End Get
            Set
                Me.discPct2Field = value
            End Set
        End Property
        
        Public Property DiscPct3() As String
            Get
                Return Me.discPct3Field
            End Get
            Set
                Me.discPct3Field = value
            End Set
        End Property
        
        Public Property MinimumQtyUom() As String
            Get
                Return Me.minimumQtyUomField
            End Get
            Set
                Me.minimumQtyUomField = value
            End Set
        End Property
        
        Public Property PriceComment() As String
            Get
                Return Me.priceCommentField
            End Get
            Set
                Me.priceCommentField = value
            End Set
        End Property
        
        Public Property ShippingInstrs() As String
            Get
                Return Me.shippingInstrsField
            End Get
            Set
                Me.shippingInstrsField = value
            End Set
        End Property
        
        Public Property FreightComment() As String
            Get
                Return Me.freightCommentField
            End Get
            Set
                Me.freightCommentField = value
            End Set
        End Property
    End Class
End Namespace
