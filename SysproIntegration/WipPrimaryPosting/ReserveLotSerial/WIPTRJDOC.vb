Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.ReserveLotSerial.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostReserveLotSerial
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of PostReserveLotSerialItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostReserveLotSerialParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostReserveLotSerialItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of PostReserveLotSerialItem)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of PostReserveLotSerialItem))
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
                Return "WIPTRJ"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostReserveLotSerialParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostReserveLotSerialParameters
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
                Dim objParams As Params.PostReserveLotSerial
                objParams = New Params.PostReserveLotSerial
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostReserveLotSerialItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private jobField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private warehouseField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private allocationLineField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reserveLotSerialField As List(Of PostReserveLotSerialItemReserveLotSerial)

        Public Sub New()
            MyBase.New()
            If (Me.reserveLotSerialField Is Nothing) Then
                Me.reserveLotSerialField = New List(Of PostReserveLotSerialItemReserveLotSerial)
            End If
        End Sub

        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set(ByVal value As String)
                Me.jobField = value
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

        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set(ByVal value As String)
                Me.warehouseField = value
            End Set
        End Property

        Public Property AllocationLine() As String
            Get
                Return Me.allocationLineField
            End Get
            Set(ByVal value As String)
                Me.allocationLineField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("ReserveLotSerial")> _
        Public Property ReserveLotSerialCollection() As List(Of PostReserveLotSerialItemReserveLotSerial)
            Get
                Return Me.reserveLotSerialField
            End Get
            Set(ByVal value As List(Of PostReserveLotSerialItemReserveLotSerial))
                Me.reserveLotSerialField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostReserveLotSerialItemReserveLotSerial

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotExpiryDateField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotQuantityField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private binsField As List(Of PostReserveLotSerialItemReserveLotSerialBins)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialsField As List(Of PostReserveLotSerialItemReserveLotSerialSerials)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialRangeField As PostReserveLotSerialItemReserveLotSerialSerialRange

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialAllocationField As PostReserveLotSerialItemReserveLotSerialSerialAllocation

        Public Sub New()
            MyBase.New()
            If (Me.serialAllocationField Is Nothing) Then
                Me.serialAllocationField = New PostReserveLotSerialItemReserveLotSerialSerialAllocation
            End If
            If (Me.serialRangeField Is Nothing) Then
                Me.serialRangeField = New PostReserveLotSerialItemReserveLotSerialSerialRange
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostReserveLotSerialItemReserveLotSerialSerials)
            End If
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of PostReserveLotSerialItemReserveLotSerialBins)
            End If
        End Sub

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

        Public Property LotQuantity() As String
            Get
                Return Me.lotQuantityField
            End Get
            Set(ByVal value As String)
                Me.lotQuantityField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Bins")> _
        Public Property BinsCollection() As List(Of PostReserveLotSerialItemReserveLotSerialBins)
            Get
                Return Me.binsField
            End Get
            Set(ByVal value As List(Of PostReserveLotSerialItemReserveLotSerialBins))
                Me.binsField = value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Serials")> _
        Public Property SerialsCollection() As List(Of PostReserveLotSerialItemReserveLotSerialSerials)
            Get
                Return Me.serialsField
            End Get
            Set(ByVal value As List(Of PostReserveLotSerialItemReserveLotSerialSerials))
                Me.serialsField = value
            End Set
        End Property

        Public Property SerialRange() As PostReserveLotSerialItemReserveLotSerialSerialRange
            Get
                Return Me.serialRangeField
            End Get
            Set(ByVal value As PostReserveLotSerialItemReserveLotSerialSerialRange)
                Me.serialRangeField = value
            End Set
        End Property

        Public Property SerialAllocation() As PostReserveLotSerialItemReserveLotSerialSerialAllocation
            Get
                Return Me.serialAllocationField
            End Get
            Set(ByVal value As PostReserveLotSerialItemReserveLotSerialSerialAllocation)
                Me.serialAllocationField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostReserveLotSerialItemReserveLotSerialBins

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
    Partial Public Class PostReserveLotSerialItemReserveLotSerialSerials

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
        '''This indicates the quantity to reserve for the serial. If within the 'Serials' group and a manual serial, it can only be 1. If within the 'Serials' group this element only applies when adding or changing a reserved serial. If within the 'SerialRange' group, it is the total quantity to be reserved for the specified range. If within the 'SerialAllocation' group, it is the total quantity to be reserved for an allocation or released for the parent part or allocation or deleted for the parent part or allocation, for the specified range.The serial must have an available quantity, equal or greater than the quantity to reserve, in stock when adding reserved serials for allocations with a positive quantity per. The format is numeric, with up to 7 integers and up to 3 decimals.
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
        '''This indicates the expiry date for the reserved serial or range of reserved serial numbers. This element is optional and only applies when adding or changing a reserved serial for the parent part where the serial is not in stock already. If supplied it must contain a valid date in the format CCYY-MM-DD.
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
        '''This indicates the location of the reserved serial number or range of reserved serial numbers. This element is optional and only applies when adding or changing a reserved serial for the parent part where the serial is not in stock already. The format is up to 8 characters alphanumeric.
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
    Partial Public Class PostReserveLotSerialItemReserveLotSerialSerialRange

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
        '''This indicates the quantity to reserve for the serial. If within the 'Serials' group and a manual serial, it can only be 1. If within the 'Serials' group this element only applies when adding or changing a reserved serial. If within the 'SerialRange' group, it is the total quantity to be reserved for the specified range. If within the 'SerialAllocation' group, it is the total quantity to be reserved for an allocation or released for the parent part or allocation or deleted for the parent part or allocation, for the specified range.The serial must have an available quantity, equal or greater than the quantity to reserve, in stock when adding reserved serials for allocations with a positive quantity per. The format is numeric, with up to 7 integers and up to 3 decimals.
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
        '''This indicates the expiry date for the reserved serial or range of reserved serial numbers. This element is optional and only applies when adding or changing a reserved serial for the parent part where the serial is not in stock already. If supplied it must contain a valid date in the format CCYY-MM-DD.
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
        '''This indicates the location of the reserved serial number or range of reserved serial numbers. This element is optional and only applies when adding or changing a reserved serial for the parent part where the serial is not in stock already. The format is up to 8 characters alphanumeric.
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
    Partial Public Class PostReserveLotSerialItemReserveLotSerialSerialAllocation

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

        '''<summary>
        '''This indicates the quantity to reserve for the serial. If within the 'Serials' group and a manual serial, it can only be 1. If within the 'Serials' group this element only applies when adding or changing a reserved serial. If within the 'SerialRange' group, it is the total quantity to be reserved for the specified range. If within the 'SerialAllocation' group, it is the total quantity to be reserved for an allocation or released for the parent part or allocation or deleted for the parent part or allocation, for the specified range.The serial must have an available quantity, equal or greater than the quantity to reserve, in stock when adding reserved serials for allocations with a positive quantity per. The format is numeric, with up to 7 integers and up to 3 decimals.
        '''</summary>
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
