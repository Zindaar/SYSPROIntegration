Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.WipJobReceipts.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostJobReceipts
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of PostJobReceiptsItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostJobReceiptsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of PostJobReceiptsItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemsCollection() As List(Of PostJobReceiptsItem)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTJR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostJobReceiptsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostJobReceiptsParameters
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
                Dim objParams As Params.PostJobReceipts
                objParams = New Params.PostJobReceipts
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
    Partial Public Class PostJobReceiptsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ledgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordForLedgerCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As PostJobReceiptsItemInspectionFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costBasisField As PostJobReceiptsItemCostBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private receiptCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSingleTypeABCElementsField As PostJobReceiptsItemUseSingleTypeABCElements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialDistributionValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private laborDistributionValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobCompleteField As PostJobReceiptsItemJobComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductCompleteField As PostJobReceiptsItemCoProductComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductCompleteFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private notationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private increaseSalesOrderQuantityField As PostJobReceiptsItemIncreaseSalesOrderQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderCompleteField As PostJobReceiptsItemSalesOrderComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotConcessionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotExpiryDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binOnHoldField As PostJobReceiptsItemBinOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binOnHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binOnHoldReasonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUpdateWhDefaultField As PostJobReceiptsItemBinUpdateWhDefault
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fifoBucketField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of PostJobReceiptsItemSerials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialRangeField As List(Of PostJobReceiptsItemSerialRange)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialAllocationField As List(Of PostJobReceiptsItemSerialAllocation)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipInspectionReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipInspectionNarrationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyJobField As PostJobReceiptsItemHierarchyJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialReferenceField As String
        
        Public Sub New()
            MyBase.New
            Me.inspectionFlagField = PostJobReceiptsItemInspectionFlag.N
            Me.costBasisField = PostJobReceiptsItemCostBasis.C
            Me.useSingleTypeABCElementsField = PostJobReceiptsItemUseSingleTypeABCElements.N
            Me.jobCompleteField = PostJobReceiptsItemJobComplete.Item
            Me.increaseSalesOrderQuantityField = PostJobReceiptsItemIncreaseSalesOrderQuantity.N
            Me.salesOrderCompleteField = PostJobReceiptsItemSalesOrderComplete.N
            Me.binUpdateWhDefaultField = PostJobReceiptsItemBinUpdateWhDefault.N
            If (Me.hierarchyJobField Is Nothing) Then
                Me.hierarchyJobField = New PostJobReceiptsItemHierarchyJob
            End If
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of PostJobReceiptsItemSerialAllocation)
            End If
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New List(Of PostJobReceiptsItemSerialRange)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostJobReceiptsItemSerials)
            End If
        End Sub
        
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property CoProductLine() As String
            Get
                Return Me.coProductLineField
            End Get
            Set
                Me.coProductLineField = value
            End Set
        End Property
        
        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set
                Me.ledgerCodeField = value
            End Set
        End Property
        
        Public Property PasswordForLedgerCode() As String
            Get
                Return Me.passwordForLedgerCodeField
            End Get
            Set
                Me.passwordForLedgerCodeField = value
            End Set
        End Property
        
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemInspectionFlag.N)>  _
        Public Property InspectionFlag() As PostJobReceiptsItemInspectionFlag
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemCostBasis.C)>  _
        Public Property CostBasis() As PostJobReceiptsItemCostBasis
            Get
                Return Me.costBasisField
            End Get
            Set
                Me.costBasisField = value
            End Set
        End Property
        
        Public Property ReceiptCost() As String
            Get
                Return Me.receiptCostField
            End Get
            Set
                Me.receiptCostField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemUseSingleTypeABCElements.N)>  _
        Public Property UseSingleTypeABCElements() As PostJobReceiptsItemUseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set
                Me.useSingleTypeABCElementsField = value
            End Set
        End Property
        
        Public Property MaterialDistributionValue() As String
            Get
                Return Me.materialDistributionValueField
            End Get
            Set
                Me.materialDistributionValueField = value
            End Set
        End Property
        
        Public Property LaborDistributionValue() As String
            Get
                Return Me.laborDistributionValueField
            End Get
            Set
                Me.laborDistributionValueField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemJobComplete.Item)>  _
        Public Property JobComplete() As PostJobReceiptsItemJobComplete
            Get
                Return Me.jobCompleteField
            End Get
            Set
                Me.jobCompleteField = value
            End Set
        End Property
        
        Public Property CoProductComplete() As PostJobReceiptsItemCoProductComplete
            Get
                Return Me.coProductCompleteField
            End Get
            Set
                Me.coProductCompleteField = value
                Me.CoProductCompleteFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CoProductCompleteSpecified() As Boolean
            Get
                Return Me.coProductCompleteFieldSpecified
            End Get
        End Property
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set
                Me.notationField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemIncreaseSalesOrderQuantity.N)>  _
        Public Property IncreaseSalesOrderQuantity() As PostJobReceiptsItemIncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set
                Me.increaseSalesOrderQuantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemSalesOrderComplete.N)>  _
        Public Property SalesOrderComplete() As PostJobReceiptsItemSalesOrderComplete
            Get
                Return Me.salesOrderCompleteField
            End Get
            Set
                Me.salesOrderCompleteField = value
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
        
        Public Property LotConcession() As String
            Get
                Return Me.lotConcessionField
            End Get
            Set
                Me.lotConcessionField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property LotExpiryDate() As Date
            Get
                Return Me.lotExpiryDateField
            End Get
            Set
                Me.lotExpiryDateField = value
                Me.LotExpiryDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LotExpiryDateSpecified() As Boolean
            Get
                Return Me.lotExpiryDateFieldSpecified
            End Get
        End Property
        
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        Public Property BinOnHold() As PostJobReceiptsItemBinOnHold
            Get
                Return Me.binOnHoldField
            End Get
            Set
                Me.binOnHoldField = value
                Me.BinOnHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BinOnHoldSpecified() As Boolean
            Get
                Return Me.binOnHoldFieldSpecified
            End Get
        End Property
        
        Public Property BinOnHoldReason() As String
            Get
                Return Me.binOnHoldReasonField
            End Get
            Set
                Me.binOnHoldReasonField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobReceiptsItemBinUpdateWhDefault.N)>  _
        Public Property BinUpdateWhDefault() As PostJobReceiptsItemBinUpdateWhDefault
            Get
                Return Me.binUpdateWhDefaultField
            End Get
            Set
                Me.binUpdateWhDefaultField = value
            End Set
        End Property
        
        Public Property FifoBucket() As String
            Get
                Return Me.fifoBucketField
            End Get
            Set
                Me.fifoBucketField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("Serials")>  _
        Public Property SerialsCollection() As List(Of PostJobReceiptsItemSerials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SerialRange")>  _
        Public Property SerialRangeCollection() As List(Of PostJobReceiptsItemSerialRange)
            Get
                Return Me.serialRangeField
            End Get
            Set
                Me.serialRangeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("SerialAllocation")>  _
        Public Property SerialAllocationCollection() As List(Of PostJobReceiptsItemSerialAllocation)
            Get
                Return Me.serialAllocationField
            End Get
            Set
                Me.serialAllocationField = value
            End Set
        End Property
        
        Public Property WipInspectionReference() As String
            Get
                Return Me.wipInspectionReferenceField
            End Get
            Set
                Me.wipInspectionReferenceField = value
            End Set
        End Property
        
        Public Property WipInspectionNarration() As String
            Get
                Return Me.wipInspectionNarrationField
            End Get
            Set
                Me.wipInspectionNarrationField = value
            End Set
        End Property
        
        Public Property HierarchyJob() As PostJobReceiptsItemHierarchyJob
            Get
                Return Me.hierarchyJobField
            End Get
            Set
                Me.hierarchyJobField = value
            End Set
        End Property
        
        Public Property AddReference() As String
            Get
                Return Me.addReferenceField
            End Get
            Set
                Me.addReferenceField = value
            End Set
        End Property
        
        Public Property MaterialReference() As String
            Get
                Return Me.materialReferenceField
            End Get
            Set
                Me.materialReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemInspectionFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemCostBasis
        
        '''<remarks/>
        C
        
        '''<remarks/>
        W
        
        '''<remarks/>
        A
        
        '''<remarks/>
        E
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemUseSingleTypeABCElements
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemJobComplete
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemCoProductComplete
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemIncreaseSalesOrderQuantity
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemSalesOrderComplete
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemBinOnHold
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobReceiptsItemBinUpdateWhDefault
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostJobReceiptsItemSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateFieldSpecified As Boolean
        
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
        
        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1.  If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property SerialExpiryDate() As Date
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
                Me.SerialExpiryDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SerialExpiryDateSpecified() As Boolean
            Get
                Return Me.serialExpiryDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt. 
        '''</summary>
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostJobReceiptsItemSerialRange
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPrefixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set
                Me.serialPrefixField = value
            End Set
        End Property
        
        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set
                Me.serialSuffixField = value
            End Set
        End Property
        
        Public Property StartSerialNumber() As String
            Get
                Return Me.startSerialNumberField
            End Get
            Set
                Me.startSerialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1.  If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being received into stock.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property SerialExpiryDate() As Date
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
                Me.SerialExpiryDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SerialExpiryDateSpecified() As Boolean
            Get
                Return Me.serialExpiryDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being received when processing a positive receipt. 
        '''</summary>
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostJobReceiptsItemSerialAllocation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fromSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private toSerialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        Public Property FromSerialNumber() As String
            Get
                Return Me.fromSerialNumberField
            End Get
            Set
                Me.fromSerialNumberField = value
            End Set
        End Property
        
        Public Property ToSerialNumber() As String
            Get
                Return Me.toSerialNumberField
            End Get
            Set
                Me.toSerialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory and specifies the quantity to receive for the specified serial number. If within the 'Serials' group and manual serial, it can only be 1.  If within the 'SerialRange' or 'SerialAllocation' group, it is the total quantity to be received for the specified range.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostJobReceiptsItemHierarchyJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costOfSalesAmountField As String
        
        Public Property Head() As String
            Get
                Return Me.headField
            End Get
            Set
                Me.headField = value
            End Set
        End Property
        
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
        
        Public Property CostOfSalesAmount() As String
            Get
                Return Me.costOfSalesAmountField
            End Get
            Set
                Me.costOfSalesAmountField = value
            End Set
        End Property
    End Class
End Namespace
