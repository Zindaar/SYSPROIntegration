Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.DispatchNoteAddLines.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostDispatchNoteLines
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteLineField As List(Of PostDispatchNoteLinesDispatchNoteLine)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostDispatchNoteLinesParameters
        
        Public Sub New()
            MyBase.New
            If (Me.dispatchNoteLineField Is Nothing) Then
                Me.dispatchNoteLineField = New List(Of PostDispatchNoteLinesDispatchNoteLine)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("DispatchNoteLine")>  _
        Public Property DispatchNoteLineCollection() As List(Of PostDispatchNoteLinesDispatchNoteLine)
            Get
                Return Me.dispatchNoteLineField
            End Get
            Set
                Me.dispatchNoteLineField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTDA"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostDispatchNoteLinesParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostDispatchNoteLinesParameters
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
                Dim objParams As Params.PostDispatchNoteLines
                objParams = New Params.PostDispatchNoteLines
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNoteLinesDispatchNoteLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private merchandiseLineField As PostDispatchNoteLinesDispatchNoteLineMerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentLineField As PostDispatchNoteLinesDispatchNoteLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeLineField As PostDispatchNoteLinesDispatchNoteLineMiscChargeLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightLineField As PostDispatchNoteLinesDispatchNoteLineFreightLine
        
        Public Sub New()
            MyBase.New
            If (Me.freightLineField Is Nothing) Then
                Me.freightLineField = New PostDispatchNoteLinesDispatchNoteLineFreightLine
            End If
            If (Me.miscChargeLineField Is Nothing) Then
                Me.miscChargeLineField = New PostDispatchNoteLinesDispatchNoteLineMiscChargeLine
            End If
            If (Me.commentLineField Is Nothing) Then
                Me.commentLineField = New PostDispatchNoteLinesDispatchNoteLineCommentLine
            End If
            If (Me.merchandiseLineField Is Nothing) Then
                Me.merchandiseLineField = New PostDispatchNoteLinesDispatchNoteLineMerchandiseLine
            End If
        End Sub
        
        Public Property MerchandiseLine() As PostDispatchNoteLinesDispatchNoteLineMerchandiseLine
            Get
                Return Me.merchandiseLineField
            End Get
            Set
                Me.merchandiseLineField = value
            End Set
        End Property
        
        Public Property CommentLine() As PostDispatchNoteLinesDispatchNoteLineCommentLine
            Get
                Return Me.commentLineField
            End Get
            Set
                Me.commentLineField = value
            End Set
        End Property
        
        Public Property MiscChargeLine() As PostDispatchNoteLinesDispatchNoteLineMiscChargeLine
            Get
                Return Me.miscChargeLineField
            End Get
            Set
                Me.miscChargeLineField = value
            End Set
        End Property
        
        Public Property FreightLine() As PostDispatchNoteLinesDispatchNoteLineFreightLine
            Get
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
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineMerchandiseLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
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
        Private binsField As List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineBins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineSerials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overOrUnderDispatchField As PostDispatchNoteLinesDispatchNoteLineMerchandiseLineOverOrUnderDispatch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchZeroQtyField As PostDispatchNoteLinesDispatchNoteLineMerchandiseLineDispatchZeroQty
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchZeroQtyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.overOrUnderDispatchField = PostDispatchNoteLinesDispatchNoteLineMerchandiseLineOverOrUnderDispatch.N
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineSerials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineBins)
            End If
        End Sub
        
        Public Property DispatchNoteNumber() As String
            Get
                Return Me.dispatchNoteNumberField
            End Get
            Set
                Me.dispatchNoteNumberField = value
            End Set
        End Property
        
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
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
        Public Property BinsCollection() As List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineBins)
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Serials")>  _
        Public Property SerialsCollection() As List(Of PostDispatchNoteLinesDispatchNoteLineMerchandiseLineSerials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesDispatchNoteLineMerchandiseLineOverOrUnderDispatch.N)>  _
        Public Property OverOrUnderDispatch() As PostDispatchNoteLinesDispatchNoteLineMerchandiseLineOverOrUnderDispatch
            Get
                Return Me.overOrUnderDispatchField
            End Get
            Set
                Me.overOrUnderDispatchField = value
            End Set
        End Property
        
        Public Property DispatchZeroQty() As PostDispatchNoteLinesDispatchNoteLineMerchandiseLineDispatchZeroQty
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
        
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineMerchandiseLineBins
        
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
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineMerchandiseLineSerials
        
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
    Public Enum PostDispatchNoteLinesDispatchNoteLineMerchandiseLineOverOrUnderDispatch
        
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
    Public Enum PostDispatchNoteLinesDispatchNoteLineMerchandiseLineDispatchZeroQty
        
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
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineCommentLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private attachLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private commentTypeField As PostDispatchNoteLinesDispatchNoteLineCommentLineCommentType
        
        Public Sub New()
            MyBase.New
            Me.commentTypeField = PostDispatchNoteLinesDispatchNoteLineCommentLineCommentType.I
        End Sub
        
        Public Property DispatchNoteNumber() As String
            Get
                Return Me.dispatchNoteNumberField
            End Get
            Set
                Me.dispatchNoteNumberField = value
            End Set
        End Property
        
        Public Property Comment() As String
            Get
                Return Me.commentField
            End Get
            Set
                Me.commentField = value
            End Set
        End Property
        
        Public Property AttachLine() As String
            Get
                Return Me.attachLineField
            End Get
            Set
                Me.attachLineField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostDispatchNoteLinesDispatchNoteLineCommentLineCommentType.I)>  _
        Public Property CommentType() As PostDispatchNoteLinesDispatchNoteLineCommentLineCommentType
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
    Public Enum PostDispatchNoteLinesDispatchNoteLineCommentLineCommentType
        
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
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineMiscChargeLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscChargeCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscProductClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableField As PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableField As PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscNotFstTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private miscDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Property DispatchNoteNumber() As String
            Get
                Return Me.dispatchNoteNumberField
            End Get
            Set
                Me.dispatchNoteNumberField = value
            End Set
        End Property
        
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
        
        Public Property MiscNotTaxable() As PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotTaxable
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
        
        Public Property MiscNotFstTaxable() As PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotFstTaxable
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
        
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotTaxable
        
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
    Public Enum PostDispatchNoteLinesDispatchNoteLineMiscChargeLineMiscNotFstTaxable
        
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
    Partial Public Class PostDispatchNoteLinesDispatchNoteLineFreightLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableField As PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightFstCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableField As PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotFstTaxable
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private freightNotFstTaxableFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Property DispatchNoteNumber() As String
            Get
                Return Me.dispatchNoteNumberField
            End Get
            Set
                Me.dispatchNoteNumberField = value
            End Set
        End Property
        
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
        
        Public Property FreightNotTaxable() As PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotTaxable
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
        
        Public Property FreightNotFstTaxable() As PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotFstTaxable
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
        
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotTaxable
        
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
    Public Enum PostDispatchNoteLinesDispatchNoteLineFreightLineFreightNotFstTaxable
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
