Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipTwoStageReceipting.WipInspectionScrapMaintenance.Data

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostWIPInspectionScrap
        Implements Codewell.SysproIntegration.ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of PostWIPInspectionScrapItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.PostWIPInspectionScrapParameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of PostWIPInspectionScrapItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of PostWIPInspectionScrapItem)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of PostWIPInspectionScrapItem))
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
                Return "WIPTSI"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.PostWIPInspectionScrapParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostWIPInspectionScrapParameters
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
                Dim objParams As Params.PostWIPInspectionScrap
                objParams = New Params.PostWIPInspectionScrap
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
    Partial Public Class PostWIPInspectionScrapItem

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private inspectionReferenceField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private stockCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private lotField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private quantityScrappedField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private documentField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private scrapCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private narrationField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerCodeField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ledgerPasswordField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private journalField As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private selectAvailableSerialsField As PostWIPInspectionScrapItemSelectAvailableSerials

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reservedSerialsField As PostWIPInspectionScrapItemReservedSerials

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reservedSerialsFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private serialsField As List(Of PostWIPInspectionScrapItemSerials)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private reservedLotField As String

        Public Sub New()
            MyBase.New()
            Me.selectAvailableSerialsField = PostWIPInspectionScrapItemSelectAvailableSerials.N
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of PostWIPInspectionScrapItemSerials)
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

        Public Property QuantityScrapped() As String
            Get
                Return Me.quantityScrappedField
            End Get
            Set(ByVal value As String)
                Me.quantityScrappedField = value
            End Set
        End Property

        Public Property Document() As String
            Get
                Return Me.documentField
            End Get
            Set(ByVal value As String)
                Me.documentField = value
            End Set
        End Property

        Public Property ScrapCode() As String
            Get
                Return Me.scrapCodeField
            End Get
            Set(ByVal value As String)
                Me.scrapCodeField = value
            End Set
        End Property

        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set(ByVal value As String)
                Me.narrationField = value
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

        <System.ComponentModel.DefaultValueAttribute(PostWIPInspectionScrapItemSelectAvailableSerials.N)> _
        Public Property SelectAvailableSerials() As PostWIPInspectionScrapItemSelectAvailableSerials
            Get
                Return Me.selectAvailableSerialsField
            End Get
            Set(ByVal value As PostWIPInspectionScrapItemSelectAvailableSerials)
                Me.selectAvailableSerialsField = value
            End Set
        End Property

        Public Property ReservedSerials() As PostWIPInspectionScrapItemReservedSerials
            Get
                Return Me.reservedSerialsField
            End Get
            Set(ByVal value As PostWIPInspectionScrapItemReservedSerials)
                Me.reservedSerialsField = value
                Me.ReservedSerialsFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property ReservedSerialsSpecified() As Boolean
            Get
                Return Me.reservedSerialsFieldSpecified
            End Get
        End Property

        <System.Xml.Serialization.XmlElementAttribute("Serials")> _
        Public Property SerialsCollection() As List(Of PostWIPInspectionScrapItemSerials)
            Get
                Return Me.serialsField
            End Get
            Set(ByVal value As List(Of PostWIPInspectionScrapItemSerials))
                Me.serialsField = value
            End Set
        End Property

        Public Property ReservedLot() As String
            Get
                Return Me.reservedLotField
            End Get
            Set(ByVal value As String)
                Me.reservedLotField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectionScrapItemSelectAvailableSerials

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Public Enum PostWIPInspectionScrapItemReservedSerials

        '''<remarks/>
        R
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)> _
    Partial Public Class PostWIPInspectionScrapItemSerials

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
End Namespace
