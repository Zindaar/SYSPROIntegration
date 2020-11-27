Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderDispatchNotePosting.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchNotes
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteField As List(Of PostDispatchNotesDispatchNote)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostDispatchNotesParameters
        
        Public Sub New()
            MyBase.New
            If (Me.dispatchNoteField Is Nothing) Then
                Me.dispatchNoteField = New List(Of PostDispatchNotesDispatchNote)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("DispatchNote")>  _
        Public Property DispatchNoteCollection() As List(Of PostDispatchNotesDispatchNote)
            Get
                Return Me.dispatchNoteField
            End Get
            Set
                Me.dispatchNoteField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTDN"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostDispatchNotesParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostDispatchNotesParameters
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
                Dim objParams As Params.PostDispatchNotes
                objParams = New Params.PostDispatchNotes
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchHeaderField As PostDispatchNotesDispatchNoteDispatchHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchDetailsField As PostDispatchNotesDispatchNoteDispatchDetails
        
        Public Sub New()
            MyBase.New
            If (Me.dispatchDetailsField Is Nothing) Then
                Me.dispatchDetailsField = New PostDispatchNotesDispatchNoteDispatchDetails
            End If
            If (Me.dispatchHeaderField Is Nothing) Then
                Me.dispatchHeaderField = New PostDispatchNotesDispatchNoteDispatchHeader
            End If
        End Sub
        
        Public Property DispatchHeader() As PostDispatchNotesDispatchNoteDispatchHeader
            Get
                Return Me.dispatchHeaderField
            End Get
            Set
                Me.dispatchHeaderField = value
            End Set
        End Property
        
        Public Property DispatchDetails() As PostDispatchNotesDispatchNoteDispatchDetails
            Get
                Return Me.dispatchDetailsField
            End Get
            Set
                Me.dispatchDetailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchHeader
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shippingInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipAddress5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipPostalCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiShipCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specialInstrsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannedDispatchDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefined1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userDefined2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchCommentsField As List(Of String)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nationalityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryTermsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionNatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transportModeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countyZipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyTaxNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchStatusPrintedField As PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted
        
        Public Sub New()
            MyBase.New
            Me.dispatchStatusPrintedField = PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted.N
            If (Me.dispatchCommentsField Is Nothing) Then
                Me.dispatchCommentsField = New List(Of String)
            End If
        End Sub
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
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
        
        Public Property CustomerName() As String
            Get
                Return Me.customerNameField
            End Get
            Set
                Me.customerNameField = value
            End Set
        End Property
        
        Public Property ShipAddress1() As String
            Get
                Return Me.shipAddress1Field
            End Get
            Set
                Me.shipAddress1Field = value
            End Set
        End Property
        
        Public Property ShipAddress2() As String
            Get
                Return Me.shipAddress2Field
            End Get
            Set
                Me.shipAddress2Field = value
            End Set
        End Property
        
        Public Property ShipAddress3() As String
            Get
                Return Me.shipAddress3Field
            End Get
            Set
                Me.shipAddress3Field = value
            End Set
        End Property
        
        Public Property ShipAddress4() As String
            Get
                Return Me.shipAddress4Field
            End Get
            Set
                Me.shipAddress4Field = value
            End Set
        End Property
        
        Public Property ShipAddress5() As String
            Get
                Return Me.shipAddress5Field
            End Get
            Set
                Me.shipAddress5Field = value
            End Set
        End Property
        
        Public Property ShipPostalCode() As String
            Get
                Return Me.shipPostalCodeField
            End Get
            Set
                Me.shipPostalCodeField = value
            End Set
        End Property
        
        Public Property MultiShipCode() As String
            Get
                Return Me.multiShipCodeField
            End Get
            Set
                Me.multiShipCodeField = value
            End Set
        End Property
        
        Public Property SpecialInstrs() As String
            Get
                Return Me.specialInstrsField
            End Get
            Set
                Me.specialInstrsField = value
            End Set
        End Property
        
        Public Property PlannedDispatchDate() As String
            Get
                Return Me.plannedDispatchDateField
            End Get
            Set
                Me.plannedDispatchDateField = value
            End Set
        End Property
        
        Public Property UserDefined1() As String
            Get
                Return Me.userDefined1Field
            End Get
            Set
                Me.userDefined1Field = value
            End Set
        End Property
        
        Public Property UserDefined2() As String
            Get
                Return Me.userDefined2Field
            End Get
            Set
                Me.userDefined2Field = value
            End Set
        End Property
        
        Public Property DispatchNoteNumber() As String
            Get
                Return Me.dispatchNoteNumberField
            End Get
            Set
                Me.dispatchNoteNumberField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("DispatchComments")>  _
        Public Property DispatchCommentsCollection() As List(Of String)
            Get
                Return Me.dispatchCommentsField
            End Get
            Set
                Me.dispatchCommentsField = value
            End Set
        End Property
        
        Public Property Nationality() As String
            Get
                Return Me.nationalityField
            End Get
            Set
                Me.nationalityField = value
            End Set
        End Property
        
        Public Property DeliveryTerms() As String
            Get
                Return Me.deliveryTermsField
            End Get
            Set
                Me.deliveryTermsField = value
            End Set
        End Property
        
        Public Property TransactionNature() As String
            Get
                Return Me.transactionNatureField
            End Get
            Set
                Me.transactionNatureField = value
            End Set
        End Property
        
        Public Property TransportMode() As String
            Get
                Return Me.transportModeField
            End Get
            Set
                Me.transportModeField = value
            End Set
        End Property
        
        Public Property ProcessFlag() As String
            Get
                Return Me.processFlagField
            End Get
            Set
                Me.processFlagField = value
            End Set
        End Property
        
        Public Property State() As String
            Get
                Return Me.stateField
            End Get
            Set
                Me.stateField = value
            End Set
        End Property
        
        Public Property CountyZip() As String
            Get
                Return Me.countyZipField
            End Get
            Set
                Me.countyZipField = value
            End Set
        End Property
        
        Public Property City() As String
            Get
                Return Me.cityField
            End Get
            Set
                Me.cityField = value
            End Set
        End Property
        
        Public Property CompanyTaxNumber() As String
            Get
                Return Me.companyTaxNumberField
            End Get
            Set
                Me.companyTaxNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted.N)>  _
        Public Property DispatchStatusPrinted() As PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted
            Get
                Return Me.dispatchStatusPrintedField
            End Get
            Set
                Me.dispatchStatusPrintedField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseLineField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsCommentLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeLineField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsFreightLine)
        
        <System.Xml.Serialization.XmlElementAttribute("MerchandiseLine")>  _
        Public Property MerchandiseLineCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine)
            Get
                If Me.merchandiseLineField Is Nothing Then
                    Me.merchandiseLineField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine)
                End If
                Return Me.merchandiseLineField
            End Get
            Set
                Me.merchandiseLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CommentLine")>  _
        Public Property CommentLineCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsCommentLine)
            Get
                If Me.commentLineField Is Nothing Then
                    Me.commentLineField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsCommentLine)
                End If
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MiscChargeLine")>  _
        Public Property MiscChargeLineCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine)
            Get
                If Me.miscChargeLineField Is Nothing Then
                    Me.miscChargeLineField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine)
                End If
                Return Me.miscChargeLineField
            End Get
            Set
                Me.miscChargeLineField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("FreightLine")>  _
        Public Property FreightLineCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsFreightLine)
            Get
                If Me.freightLineField Is Nothing Then
                    Me.freightLineField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsFreightLine)
                End If
                Return Me.freightLineField
            End Get
            Set
                Me.freightLineField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockingDispatchQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overOrUnderDispatchField As PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchZeroQtyField As PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchZeroQtyFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.overOrUnderDispatchField = PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch.N
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins)
            End If
        End Sub
        
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        Public Property DispatchQty() As String
            Get
                Return Me.dispatchQtyField
            End Get
            Set
                Me.dispatchQtyField = value
            End Set
        End Property
        
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        Public Property StockingDispatchQty() As String
            Get
                Return Me.stockingDispatchQtyField
            End Get
            Set
                Me.stockingDispatchQtyField = value
            End Set
        End Property
        
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Bins")>  _
        Public Property BinsCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins)
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Serials")>  _
        Public Property SerialsCollection() As List(Of PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch.N)>  _
        Public Property OverOrUnderDispatch() As PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch
            Get
                Return Me.overOrUnderDispatchField
            End Get
            Set
                Me.overOrUnderDispatchField = value
            End Set
        End Property
        
        Public Property DispatchZeroQty() As PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty
            Get
                Return Me.dispatchZeroQtyField
            End Get
            Set
                Me.dispatchZeroQtyField = value
                Me.DispatchZeroQtyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DispatchZeroQtySpecified() As Boolean
            Get
                Return Me.dispatchZeroQtyFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binPiecesField As String
        
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = value
            End Set
        End Property
        
        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = value
            End Set
        End Property
        
        Public Property BinPieces() As String
            Get
                Return Me.binPiecesField
            End Get
            Set
                Me.binPiecesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPiecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialCreationDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialScrapDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
            End Set
        End Property
        
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        Public Property SerialUnits() As String
            Get
                Return Me.serialUnitsField
            End Get
            Set
                Me.serialUnitsField = value
            End Set
        End Property
        
        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = value
            End Set
        End Property
        
        Public Property SerialCreationDate() As String
            Get
                Return Me.serialCreationDateField
            End Get
            Set
                Me.serialCreationDateField = value
            End Set
        End Property
        
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
            End Set
        End Property
        
        Public Property SerialScrapDate() As String
            Get
                Return Me.serialScrapDateField
            End Get
            Set
                Me.serialScrapDateField = value
            End Set
        End Property
        
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        U
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachedLineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeField As PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType
        
        Public Sub New()
            MyBase.New
            Me.commentTypeField = PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType.I
        End Sub
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property AttachedLineNumber() As String
            Get
                Return Me.attachedLineNumberField
            End Get
            Set
                Me.attachedLineNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType.I)>  _
        Public Property CommentType() As PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType
            Get
                Return Me.commentTypeField
            End Get
            Set
                Me.commentTypeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType
        
        '''<remarks/>
        I
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableField As PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableField As PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscDescriptionField As String
        
        Public Property MiscChargeValue() As String
            Get
                Return Me.miscChargeValueField
            End Get
            Set
                Me.miscChargeValueField = value
            End Set
        End Property
        
        Public Property MiscChargeCost() As String
            Get
                Return Me.miscChargeCostField
            End Get
            Set
                Me.miscChargeCostField = value
            End Set
        End Property
        
        Public Property MiscProductClass() As String
            Get
                Return Me.miscProductClassField
            End Get
            Set
                Me.miscProductClassField = value
            End Set
        End Property
        
        Public Property MiscTaxCode() As String
            Get
                Return Me.miscTaxCodeField
            End Get
            Set
                Me.miscTaxCodeField = value
            End Set
        End Property
        
        Public Property MiscNotTaxable() As PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable
            Get
                Return Me.miscNotTaxableField
            End Get
            Set
                Me.miscNotTaxableField = value
                Me.MiscNotTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscNotTaxableSpecified() As Boolean
            Get
                Return Me.miscNotTaxableFieldSpecified
            End Get
        End Property
        
        Public Property MiscFstCode() As String
            Get
                Return Me.miscFstCodeField
            End Get
            Set
                Me.miscFstCodeField = value
            End Set
        End Property
        
        Public Property MiscNotFstTaxable() As PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable
            Get
                Return Me.miscNotFstTaxableField
            End Get
            Set
                Me.miscNotFstTaxableField = value
                Me.MiscNotFstTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MiscNotFstTaxableSpecified() As Boolean
            Get
                Return Me.miscNotFstTaxableFieldSpecified
            End Get
        End Property
        
        Public Property MiscDescription() As String
            Get
                Return Me.miscDescriptionField
            End Get
            Set
                Me.miscDescriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNotesDispatchNoteDispatchDetailsFreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableField As PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableField As PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableFieldSpecified As Boolean
        
        Public Property FreightValue() As String
            Get
                Return Me.freightValueField
            End Get
            Set
                Me.freightValueField = value
            End Set
        End Property
        
        Public Property FreightCost() As String
            Get
                Return Me.freightCostField
            End Get
            Set
                Me.freightCostField = value
            End Set
        End Property
        
        Public Property FreightTaxCode() As String
            Get
                Return Me.freightTaxCodeField
            End Get
            Set
                Me.freightTaxCodeField = value
            End Set
        End Property
        
        Public Property FreightNotTaxable() As PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable
            Get
                Return Me.freightNotTaxableField
            End Get
            Set
                Me.freightNotTaxableField = value
                Me.FreightNotTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightNotTaxableSpecified() As Boolean
            Get
                Return Me.freightNotTaxableFieldSpecified
            End Get
        End Property
        
        Public Property FreightFstCode() As String
            Get
                Return Me.freightFstCodeField
            End Get
            Set
                Me.freightFstCodeField = value
            End Set
        End Property
        
        Public Property FreightNotFstTaxable() As PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable
            Get
                Return Me.freightNotFstTaxableField
            End Get
            Set
                Me.freightNotFstTaxableField = value
                Me.FreightNotFstTaxableFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FreightNotFstTaxableSpecified() As Boolean
            Get
                Return Me.freightNotFstTaxableFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
