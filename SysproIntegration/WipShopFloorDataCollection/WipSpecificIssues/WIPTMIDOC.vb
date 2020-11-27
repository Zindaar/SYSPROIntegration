Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipShopFloorDataCollection.WipSpecificIssues.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostMaterial
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemsField As List(Of PostMaterialItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostMaterialParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of PostMaterialItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemsCollection() As List(Of PostMaterialItem)
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As List(Of PostMaterialItem))
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
                Return "WIPTMI"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostMaterialParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostMaterialParameters
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
                Dim objParams As Params.PostMaterial
                objParams = New Params.PostMaterial
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
    Partial Public Class PostMaterialItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private nonStockedFlagField As PostMaterialItemNonStockedFlag

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private qtyIssuedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private referenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private notationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private passwordForLedgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private productClassField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private unitCostField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private allocCompletedField As PostMaterialItemAllocCompleted

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private allocCompletedFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fifoBucketField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binsField As List(Of PostMaterialItemBins)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotConcessionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialsField As List(Of PostMaterialItemSerials)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialAllocationField As List(Of PostMaterialItemSerialAllocation)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private materialReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private coProductLineField As Object

        Public Sub New()
            MyBase.New()
            Me.nonStockedFlagField = PostMaterialItemNonStockedFlag.N
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New List(Of PostMaterialItemSerialAllocation)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostMaterialItemSerials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of PostMaterialItemBins)
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

        <System.ComponentModel.DefaultValueAttribute(PostMaterialItemNonStockedFlag.N)> _
        Public Property NonStockedFlag() As PostMaterialItemNonStockedFlag
            Get
                Return Me.nonStockedFlagField
            End Get
            Set(ByVal value As PostMaterialItemNonStockedFlag)
                Me.nonStockedFlagField = value
            End Set
        End Property

        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set(ByVal value As String)
                Me.warehouseField = value
            End Set
        End Property

        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set(ByVal value As String)
                Me.stockCodeField = value
            End Set
        End Property

        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set(ByVal value As String)
                Me.lineField = value
            End Set
        End Property

        Public Property QtyIssued() As String
            Get
                Return Me.qtyIssuedField
            End Get
            Set(ByVal value As String)
                Me.qtyIssuedField = value
            End Set
        End Property

        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set(ByVal value As String)
                Me.referenceField = value
            End Set
        End Property

        Public Property Notation() As String
            Get
                Return Me.notationField
            End Get
            Set(ByVal value As String)
                Me.notationField = value
            End Set
        End Property

        Public Property LedgerCode() As String
            Get
                Return Me.ledgerCodeField
            End Get
            Set(ByVal value As String)
                Me.ledgerCodeField = value
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

        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set(ByVal value As String)
                Me.productClassField = value
            End Set
        End Property

        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set(ByVal value As String)
                Me.unitCostField = value
            End Set
        End Property

        Public Property AllocCompleted() As PostMaterialItemAllocCompleted
            Get
                Return Me.allocCompletedField
            End Get
            Set(ByVal value As PostMaterialItemAllocCompleted)
                Me.allocCompletedField = value
                Me.AllocCompletedFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property AllocCompletedSpecified() As Boolean
            Get
                Return Me.allocCompletedFieldSpecified
            End Get
        End Property

        Public Property FifoBucket() As String
            Get
                Return Me.fifoBucketField
            End Get
            Set(ByVal value As String)
                Me.fifoBucketField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Bins")> _
        Public Property BinsCollection() As List(Of PostMaterialItemBins)
            Get
                Return Me.binsField
            End Get
            Set(ByVal value As List(Of PostMaterialItemBins))
                Me.binsField = value
            End Set
        End Property

        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set(ByVal value As String)
                Me.lotField = value
            End Set
        End Property

        Public Property LotConcession() As String
            Get
                Return Me.lotConcessionField
            End Get
            Set(ByVal value As String)
                Me.lotConcessionField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Serials")> _
        Public Property SerialsCollection() As List(Of PostMaterialItemSerials)
            Get
                Return Me.serialsField
            End Get
            Set(ByVal value As List(Of PostMaterialItemSerials))
                Me.serialsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("SerialAllocation")> _
        Public Property SerialAllocationCollection() As List(Of PostMaterialItemSerialAllocation)
            Get
                Return Me.serialAllocationField
            End Get
            Set(ByVal value As List(Of PostMaterialItemSerialAllocation))
                Me.serialAllocationField = value
            End Set
        End Property

        Public Property MaterialReference() As String
            Get
                Return Me.materialReferenceField
            End Get
            Set(ByVal value As String)
                Me.materialReferenceField = value
            End Set
        End Property

        Public Property CoProductLine() As Object
            Get
                Return Me.coProductLineField
            End Get
            Set(ByVal value As Object)
                Me.coProductLineField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostMaterialItemNonStockedFlag

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostMaterialItemAllocCompleted

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
    Partial Public Class PostMaterialItemBins

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binLocationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binQuantityField As String

        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set(ByVal value As String)
                Me.binLocationField = value
            End Set
        End Property

        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set(ByVal value As String)
                Me.binQuantityField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostMaterialItemSerials

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialQuantityField As String

        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set(ByVal value As String)
                Me.serialNumberField = value
            End Set
        End Property

        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set(ByVal value As String)
                Me.serialQuantityField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostMaterialItemSerialAllocation

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private fromSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private toSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialQuantityField As String

        Public Property FromSerialNumber() As String
            Get
                Return Me.fromSerialNumberField
            End Get
            Set(ByVal value As String)
                Me.fromSerialNumberField = value
            End Set
        End Property

        Public Property ToSerialNumber() As String
            Get
                Return Me.toSerialNumberField
            End Get
            Set(ByVal value As String)
                Me.toSerialNumberField = value
            End Set
        End Property

        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set(ByVal value As String)
                Me.serialQuantityField = value
            End Set
        End Property
    End Class
End Namespace
