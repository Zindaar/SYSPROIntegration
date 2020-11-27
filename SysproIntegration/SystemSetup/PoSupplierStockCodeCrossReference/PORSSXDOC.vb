Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.PoSupplierStockCodeCrossReference.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class SetupSupplierStockXref
        Implements ISetup

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of SetupSupplierStockXrefItem)

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.Parameters

        Public Sub New()
            MyBase.New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of SetupSupplierStockXrefItem)
            End If
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property Item() As List(Of SetupSupplierStockXrefItem)
            Get
                Return Me.itemField
            End Get
            Set(value As List(Of SetupSupplierStockXrefItem))
                Me.itemField = value
            End Set
        End Property

        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set(value As CommonEnums.ActionType_Setup)
                Me._setupActionTypeField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "PORSSX"
            End Get
        End Property

        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters()
                End If
                Return Me._params
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.xmlParam
            Get
                Dim objParams As Params.SetupSupplierStockXref
                objParams = New Params.SetupSupplierStockXref()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ISetup.Post
            If (Me._setupActionTypeField = 0) Then
                Me._xmlOut = SetupObject.Add(Me)
                Return
            End If
            If (Me._setupActionTypeField = 1) Then
                Me._xmlOut = SetupObject.Update(Me)
                Return
            End If
            If (Me._setupActionTypeField = 2) Then
                Me._xmlOut = SetupObject.Delete(Me)
                Return
            End If
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
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
    Partial Public Class SetupSupplierStockXrefItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As SetupSupplierStockXrefItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supCatalogueNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private demoLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPricePaidField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastReceiptDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastReceiptQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderQtyUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supStockDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supLongDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poText1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poText2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poText3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private poText4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctmerchPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultPriceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemFlagField As SetupSupplierStockXrefItemStockItemFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultPrcUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lastPrcUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private altDocPriceField As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New SetupSupplierStockXrefItemKey()
            End If
        End Sub
        
        Public Property Key() As SetupSupplierStockXrefItemKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        Public Property SupCatalogueNum() As String
            Get
                Return Me.supCatalogueNumField
            End Get
            Set
                Me.supCatalogueNumField = value
            End Set
        End Property
        
        Public Property DemoLeadTime() As String
            Get
                Return Me.demoLeadTimeField
            End Get
            Set
                Me.demoLeadTimeField = value
            End Set
        End Property
        
        Public Property LastPricePaid() As String
            Get
                Return Me.lastPricePaidField
            End Get
            Set
                Me.lastPricePaidField = value
            End Set
        End Property
        
        Public Property LastReceiptDate() As String
            Get
                Return Me.lastReceiptDateField
            End Get
            Set
                Me.lastReceiptDateField = value
            End Set
        End Property
        
        Public Property LastReceiptQty() As String
            Get
                Return Me.lastReceiptQtyField
            End Get
            Set
                Me.lastReceiptQtyField = value
            End Set
        End Property
        
        Public Property OrderQtyUom() As String
            Get
                Return Me.orderQtyUomField
            End Get
            Set
                Me.orderQtyUomField = value
            End Set
        End Property
        
        Public Property SupStockDesc() As String
            Get
                Return Me.supStockDescField
            End Get
            Set
                Me.supStockDescField = value
            End Set
        End Property
        
        Public Property SupLongDesc() As String
            Get
                Return Me.supLongDescField
            End Get
            Set
                Me.supLongDescField = value
            End Set
        End Property
        
        Public Property PoText1() As String
            Get
                Return Me.poText1Field
            End Get
            Set
                Me.poText1Field = value
            End Set
        End Property
        
        Public Property PoText2() As String
            Get
                Return Me.poText2Field
            End Get
            Set
                Me.poText2Field = value
            End Set
        End Property
        
        Public Property PoText3() As String
            Get
                Return Me.poText3Field
            End Get
            Set
                Me.poText3Field = value
            End Set
        End Property
        
        Public Property PoText4() As String
            Get
                Return Me.poText4Field
            End Get
            Set
                Me.poText4Field = value
            End Set
        End Property
        
        Public Property LctmerchPrice() As String
            Get
                Return Me.lctmerchPriceField
            End Get
            Set
                Me.lctmerchPriceField = value
            End Set
        End Property
        
        Public Property DefaultPrice() As String
            Get
                Return Me.defaultPriceField
            End Get
            Set
                Me.defaultPriceField = value
            End Set
        End Property
        
        Public Property StockItemFlag() As SetupSupplierStockXrefItemStockItemFlag
            Get
                Return Me.stockItemFlagField
            End Get
            Set
                Me.stockItemFlagField = value
                Me.StockItemFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockItemFlagSpecified() As Boolean
            Get
                Return Me.stockItemFlagFieldSpecified
            End Get
        End Property
        
        Public Property DefaultPrcUom() As String
            Get
                Return Me.defaultPrcUomField
            End Get
            Set
                Me.defaultPrcUomField = value
            End Set
        End Property
        
        Public Property LastPrcUom() As String
            Get
                Return Me.lastPrcUomField
            End Get
            Set
                Me.lastPrcUomField = value
            End Set
        End Property
        
        Public Property AltDocPrice() As String
            Get
                Return Me.altDocPriceField
            End Get
            Set
                Me.altDocPriceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class SetupSupplierStockXrefItemKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum SetupSupplierStockXrefItemStockItemFlag
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
