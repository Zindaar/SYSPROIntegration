Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionEntry.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userPasswordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requisitionLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revisionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dueDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeToUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeNotationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discountCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private discPercent3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lessPlusDiscField As LessPlusDisc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lessPlusDiscFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private catalogueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private capexNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderCommentsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptIntoInspectionField As ReceiptIntoInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptIntoInspectionFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.lessPlusDiscField = LessPlusDisc.L
        End Sub
        
        '''<summary>
        '''The user who is adding the requisition. If the user is not supplied then the user associated with the operator will be assumed. The user must be valid.
        '''</summary>
        Public Property User() As String
            Get
                Return Me.userField
            End Get
            Set
                Me.userField = value
            End Set
        End Property
        
        '''<summary>
        '''The password associated with the user. The password is only required to be supplied if the user element was supplied and it differs from the user associated with the operator default. 
        '''</summary>
        Public Property UserPassword() As String
            Get
                Return Me.userPasswordField
            End Get
            Set
                Me.userPasswordField = value
            End Set
        End Property
        
        '''<summary>
        '''The number is used when changing an existing requisition, or when adding new lines to an existing requisition, or when adding a requisition for the first time, and requisition  numbering is manual.
        '''</summary>
        Public Property RequisitionNumber() As String
            Get
                Return Me.requisitionNumberField
            End Get
            Set
                Me.requisitionNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The line number of the requisition. The line is applied when changing an existing requisition.
        '''</summary>
        Public Property RequisitionLine() As String
            Get
                Return Me.requisitionLineField
            End Get
            Set
                Me.requisitionLineField = value
            End Set
        End Property
        
        '''<summary>
        '''The stock code for the requisition. This must be non-blank. The stock code must be valid if the XML parameter option AllowNonStocked is defined as N.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The description of the stock code. If not supplied will default to the description of the stock code itself. A non-blank description must be supplied for a non-stocked item.
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''The revision of the stock code.
        '''</summary>
        Public Property Revision() As String
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = value
            End Set
        End Property
        
        '''<summary>
        '''The release of the stock code.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if the stock code is not a unit-qty type stock code.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''If the stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''The unit of measure for the quantity supplied. The u/m must be either the stocking or alternate u/m's associated with the stock code. If not supplied then the stocking unit of measure is assumed.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''The due date for the requisition line. Defaults to today's date.
        '''</summary>
        Public Property DueDate() As String
            Get
                Return Me.dueDateField
            End Get
            Set
                Me.dueDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The reason for the requisition being raised.
        '''</summary>
        Public Property Reason() As String
            Get
                Return Me.reasonField
            End Get
            Set
                Me.reasonField = value
            End Set
        End Property
        
        '''<summary>
        '''The user to whom the requisition should be routed.
        '''</summary>
        Public Property RouteToUser() As String
            Get
                Return Me.routeToUserField
            End Get
            Set
                Me.routeToUserField = value
            End Set
        End Property
        
        '''<summary>
        '''The notation to be applied if the requisition is to be routed to another user.
        '''</summary>
        Public Property RouteNotation() As String
            Get
                Return Me.routeNotationField
            End Get
            Set
                Me.routeNotationField = value
            End Set
        End Property
        
        '''<summary>
        '''The supplier of the stock item. If the supplier is valid then it is checked to see if the supplier is on hold and for security access on the A/P branch.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''The price quoted by the supplier.
        '''</summary>
        Public Property Price() As String
            Get
                Return Me.priceField
            End Get
            Set
                Me.priceField = value
            End Set
        End Property
        
        '''<summary>
        '''The price unit of measure.
        '''</summary>
        Public Property PriceUom() As String
            Get
                Return Me.priceUomField
            End Get
            Set
                Me.priceUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Discount code. Must be valid if supplied. 
        '''</summary>
        Public Property DiscountCode() As String
            Get
                Return Me.discountCodeField
            End Get
            Set
                Me.discountCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''First discount percentage. May be positive or negative.
        '''Discount percentages will only be used if the DiscountCode element is not supplied.
        '''</summary>
        Public Property DiscPercent1() As String
            Get
                Return Me.discPercent1Field
            End Get
            Set
                Me.discPercent1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Second discount percentage.
        '''</summary>
        Public Property DiscPercent2() As String
            Get
                Return Me.discPercent2Field
            End Get
            Set
                Me.discPercent2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Third discount percentage.
        '''</summary>
        Public Property DiscPercent3() As String
            Get
                Return Me.discPercent3Field
            End Get
            Set
                Me.discPercent3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates whether the discount percentages should be applied as LESS (L) or PLUS (P).
        '''</summary>
        Public Property LessPlusDisc() As LessPlusDisc
            Get
                Return Me.lessPlusDiscField
            End Get
            Set
                Me.lessPlusDiscField = value
                Me.LessPlusDiscFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LessPlusDiscSpecified() As Boolean
            Get
                Return Me.lessPlusDiscFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The warehouse for the stock code into which the goods will be supplied. The entry supplied here will be overwritten if there is a warehouse defined against the requisition user.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''The supplier's catalogue number for the supplied stock code.
        '''</summary>
        Public Property Catalogue() As String
            Get
                Return Me.catalogueField
            End Get
            Set
                Me.catalogueField = value
            End Set
        End Property
        
        '''<summary>
        '''The job number. The job number does not have to be valid if supplied. However, if the job is valid then the job classification of that job is checked for security access.
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''Subcontract operation number if a job has been supplied.
        '''</summary>
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        '''<summary>
        '''The G/L account code. This may only be supplied for a non-stocked item, and will be ignored for a stocked item and ignored for any item that contains a job number. Defaults to the inventory non-stocked control account if not specifically supplied.
        '''</summary>
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''If ledger codes require a password, this element must contain the relevant password.
        '''</summary>
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The product class to be applied for a non-stocked item only.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''The tax code is only used if the item is non-stocked.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The customer number. Does not have to valid when supplied.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''The customer's purchase order number.
        '''</summary>
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The capex number. Must be valid if supplied.
        '''</summary>
        Public Property CapexNumber() As String
            Get
                Return Me.capexNumberField
            End Get
            Set
                Me.capexNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''The buyer code to be associated with the requisition. If enrered, it must be a valid SYSPRO buyer code.
        '''</summary>
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        '''<summary>
        '''Requisition notes.
        '''</summary>
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set
                Me.notesField = value
            End Set
        End Property
        
        '''<summary>
        '''Comments to be applied to the purchase order when created from this requisition line.
        '''</summary>
        Public Property PurchaseOrderComments() As String
            Get
                Return Me.purchaseOrderCommentsField
            End Get
            Set
                Me.purchaseOrderCommentsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element allows a non-stocked requisition to be flagged as requiring inspection. Valid entries are 'N' - No, 'Y' - Yes. If blank, then 'N' is assumed. This is only used for a non-stocked item.
        '''</summary>
        Public Property ReceiptIntoInspection() As ReceiptIntoInspection
            Get
                Return Me.receiptIntoInspectionField
            End Get
            Set
                Me.receiptIntoInspectionField = value
                Me.ReceiptIntoInspectionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReceiptIntoInspectionSpecified() As Boolean
            Get
                Return Me.receiptIntoInspectionFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum LessPlusDisc
        
        '''<remarks/>
        L
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReceiptIntoInspection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostRequisition
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New Item
            End If
        End Sub
        
        '''<summary>
        '''This is the top element for all data required for the transaction.
        '''</summary>
        Public Property Item() As Item
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
                Return "PORTRQ"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostRequisition
                objParams = New Params.PostRequisition
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
