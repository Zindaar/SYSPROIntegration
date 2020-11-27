Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipTwoStageReceipting.WipInspectionAcceptIntoStock.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostWIPInspectAccept
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemsField As List(Of PostWIPInspectAcceptItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostWIPInspectAcceptParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of PostWIPInspectAcceptItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemsCollection() As List(Of PostWIPInspectAcceptItem)
            Get
                Return Me.itemsField
            End Get
            Set(ByVal value As List(Of PostWIPInspectAcceptItem))
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
                Return "WIPTAI"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostWIPInspectAcceptParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostWIPInspectAcceptParameters
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
                Dim objParams As Params.PostWIPInspectAccept
                objParams = New Params.PostWIPInspectAccept
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
    Partial Public Class PostWIPInspectAcceptItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private inspectionReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private acceptQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private concessionField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private notationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerPasswordField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private acceptIntoAlternateWarehouseField As PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private alternateWarehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private acceptIntoAlternateBinField As PostWIPInspectAcceptItemAcceptIntoAlternateBin

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private alternateBinField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private acceptAsAlternateStockField As PostWIPInspectAcceptItemAcceptAsAlternateStock

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private alternateStockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private increaseSalesOrderQuantityField As PostWIPInspectAcceptItemIncreaseSalesOrderQuantity

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private salesOrderCompleteField As PostWIPInspectAcceptItemSalesOrderComplete

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private useSingleTypeABCElementsField As PostWIPInspectAcceptItemUseSingleTypeABCElements

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private selectAvailableSerialsField As PostWIPInspectAcceptItemSelectAvailableSerials

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialsField As List(Of PostWIPInspectAcceptItemSerials)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialRangeField As PostWIPInspectAcceptItemSerialRange

        Public Sub New()
            MyBase.New()
            Me.acceptIntoAlternateWarehouseField = PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse.N
            Me.acceptIntoAlternateBinField = PostWIPInspectAcceptItemAcceptIntoAlternateBin.N
            Me.acceptAsAlternateStockField = PostWIPInspectAcceptItemAcceptAsAlternateStock.N
            Me.increaseSalesOrderQuantityField = PostWIPInspectAcceptItemIncreaseSalesOrderQuantity.N
            Me.salesOrderCompleteField = PostWIPInspectAcceptItemSalesOrderComplete.N
            Me.useSingleTypeABCElementsField = PostWIPInspectAcceptItemUseSingleTypeABCElements.N
            Me.selectAvailableSerialsField = PostWIPInspectAcceptItemSelectAvailableSerials.N
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New PostWIPInspectAcceptItemSerialRange
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostWIPInspectAcceptItemSerials)
            End If
        End Sub

        Public Property InspectionReference() As String
            Get
                Return Me.inspectionReferenceField
            End Get
            Set(ByVal value As String)
                Me.inspectionReferenceField = value
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

        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set(ByVal value As String)
                Me.lotField = value
            End Set
        End Property

        Public Property LotExpiryDate() As String
            Get
                Return Me.lotExpiryDateField
            End Get
            Set(ByVal value As String)
                Me.lotExpiryDateField = value
            End Set
        End Property

        Public Property AcceptQuantity() As String
            Get
                Return Me.acceptQuantityField
            End Get
            Set(ByVal value As String)
                Me.acceptQuantityField = value
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

        Public Property LedgerPassword() As String
            Get
                Return Me.ledgerPasswordField
            End Get
            Set(ByVal value As String)
                Me.ledgerPasswordField = value
            End Set
        End Property

        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set(ByVal value As String)
                Me.journalField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse.N)> _
        Public Property AcceptIntoAlternateWarehouse() As PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse
            Get
                Return Me.acceptIntoAlternateWarehouseField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse)
                Me.acceptIntoAlternateWarehouseField = value
            End Set
        End Property

        Public Property AlternateWarehouse() As String
            Get
                Return Me.alternateWarehouseField
            End Get
            Set(ByVal value As String)
                Me.alternateWarehouseField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemAcceptIntoAlternateBin.N)> _
        Public Property AcceptIntoAlternateBin() As PostWIPInspectAcceptItemAcceptIntoAlternateBin
            Get
                Return Me.acceptIntoAlternateBinField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemAcceptIntoAlternateBin)
                Me.acceptIntoAlternateBinField = value
            End Set
        End Property

        Public Property AlternateBin() As String
            Get
                Return Me.alternateBinField
            End Get
            Set(ByVal value As String)
                Me.alternateBinField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemAcceptAsAlternateStock.N)> _
        Public Property AcceptAsAlternateStock() As PostWIPInspectAcceptItemAcceptAsAlternateStock
            Get
                Return Me.acceptAsAlternateStockField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemAcceptAsAlternateStock)
                Me.acceptAsAlternateStockField = value
            End Set
        End Property

        Public Property AlternateStockCode() As String
            Get
                Return Me.alternateStockCodeField
            End Get
            Set(ByVal value As String)
                Me.alternateStockCodeField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemIncreaseSalesOrderQuantity.N)> _
        Public Property IncreaseSalesOrderQuantity() As PostWIPInspectAcceptItemIncreaseSalesOrderQuantity
            Get
                Return Me.increaseSalesOrderQuantityField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemIncreaseSalesOrderQuantity)
                Me.increaseSalesOrderQuantityField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemSalesOrderComplete.N)> _
        Public Property SalesOrderComplete() As PostWIPInspectAcceptItemSalesOrderComplete
            Get
                Return Me.salesOrderCompleteField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemSalesOrderComplete)
                Me.salesOrderCompleteField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemUseSingleTypeABCElements.N)> _
        Public Property UseSingleTypeABCElements() As PostWIPInspectAcceptItemUseSingleTypeABCElements
            Get
                Return Me.useSingleTypeABCElementsField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemUseSingleTypeABCElements)
                Me.useSingleTypeABCElementsField = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectAcceptItemSelectAvailableSerials.N)> _
        Public Property SelectAvailableSerials() As PostWIPInspectAcceptItemSelectAvailableSerials
            Get
                Return Me.selectAvailableSerialsField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemSelectAvailableSerials)
                Me.selectAvailableSerialsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Serials")> _
        Public Property SerialsCollection() As List(Of PostWIPInspectAcceptItemSerials)
            Get
                Return Me.serialsField
            End Get
            Set(ByVal value As List(Of PostWIPInspectAcceptItemSerials))
                Me.serialsField = value
            End Set
        End Property

        Public Property SerialRange() As PostWIPInspectAcceptItemSerialRange
            Get
                Return Me.serialRangeField
            End Get
            Set(ByVal value As PostWIPInspectAcceptItemSerialRange)
                Me.serialRangeField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemAcceptIntoAlternateWarehouse

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemAcceptIntoAlternateBin

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemAcceptAsAlternateStock

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemIncreaseSalesOrderQuantity

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemSalesOrderComplete

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemUseSingleTypeABCElements

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectAcceptItemSelectAvailableSerials

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
    Partial Public Class PostWIPInspectAcceptItemSerials

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialLocationField As String

        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set(ByVal value As String)
                Me.serialNumberField = value
            End Set
        End Property

        '''<summary>
        '''This element is only applicable for batch serialized items and indicates the quantity that will be taken into stock for the serial or when supplying a range of serials this element specifies the total quantity to be received for the specified range. The format is up to 11 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set(ByVal value As String)
                Me.serialQuantityField = value
            End Set
        End Property

        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being accepted into stock. The expiry date must be in a CCYY-MM-DD format. 
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set(ByVal value As String)
                Me.serialExpiryDateField = value
            End Set
        End Property

        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being accepted into stock. The format is up to 8 characters alphanumeric.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set(ByVal value As String)
                Me.serialLocationField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostWIPInspectAcceptItemSerialRange

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialPrefixField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialSuffixField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private startSerialNumberField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialLocationField As String

        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set(ByVal value As String)
                Me.serialPrefixField = value
            End Set
        End Property

        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set(ByVal value As String)
                Me.serialSuffixField = value
            End Set
        End Property

        Public Property StartSerialNumber() As String
            Get
                Return Me.startSerialNumberField
            End Get
            Set(ByVal value As String)
                Me.startSerialNumberField = value
            End Set
        End Property

        '''<summary>
        '''This element is only applicable for batch serialized items and indicates the quantity that will be taken into stock for the serial or when supplying a range of serials this element specifies the total quantity to be received for the specified range. The format is up to 11 characters numeric with 7 integers and 3 decimals.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set(ByVal value As String)
                Me.serialQuantityField = value
            End Set
        End Property

        '''<summary>
        '''This element contains the expiry date of a new serial number or range of serial numbers being accepted into stock. The expiry date must be in a CCYY-MM-DD format. 
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set(ByVal value As String)
                Me.serialExpiryDateField = value
            End Set
        End Property

        '''<summary>
        '''This element contains the location of the serial number or range of serial numbers being accepted into stock. The format is up to 8 characters alphanumeric.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set(ByVal value As String)
                Me.serialLocationField = value
            End Set
        End Property
    End Class
End Namespace
