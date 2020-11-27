Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryProductConfigurator.InitialiseTheConfigurationGroupOfObjects.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostConfiguration
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostConfigurationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostConfigurationItem
            End If
        End Sub
        
        Public Property Item() As PostConfigurationItem
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
                Return "CFGTPC"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostConfigurationParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostConfigurationParameters
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
                Dim objParams As Params.PostConfiguration
                objParams = New Params.PostConfiguration
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
    Partial Public Class PostConfigurationItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private callSourceField As PostConfigurationItemCallSource
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private passwordField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overrideComponentWhField As PostConfigurationItemOverrideComponentWh
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private libraryCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrdersAndQuotesField As PostConfigurationItemSalesOrdersAndQuotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private billOfMaterialsAndEstimatesField As PostConfigurationItemBillOfMaterialsAndEstimates
        
        Public Sub New()
            MyBase.New
            Me.overrideComponentWhField = PostConfigurationItemOverrideComponentWh.N
            If (Me.billOfMaterialsAndEstimatesField Is Nothing) Then
                Me.billOfMaterialsAndEstimatesField = New PostConfigurationItemBillOfMaterialsAndEstimates
            End If
            If (Me.salesOrdersAndQuotesField Is Nothing) Then
                Me.salesOrdersAndQuotesField = New PostConfigurationItemSalesOrdersAndQuotes
            End If
        End Sub
        
        Public Property CallSource() As PostConfigurationItemCallSource
            Get
                Return Me.callSourceField
            End Get
            Set
                Me.callSourceField = value
            End Set
        End Property
        
        Public Property ProductCode() As String
            Get
                Return Me.productCodeField
            End Get
            Set
                Me.productCodeField = value
            End Set
        End Property
        
        Public Property Password() As String
            Get
                Return Me.passwordField
            End Get
            Set
                Me.passwordField = value
            End Set
        End Property
        
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemOverrideComponentWh.N)>  _
        Public Property OverrideComponentWh() As PostConfigurationItemOverrideComponentWh
            Get
                Return Me.overrideComponentWhField
            End Get
            Set
                Me.overrideComponentWhField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property LibraryCode() As String
            Get
                Return Me.libraryCodeField
            End Get
            Set
                Me.libraryCodeField = value
            End Set
        End Property
        
        Public Property SalesOrdersAndQuotes() As PostConfigurationItemSalesOrdersAndQuotes
            Get
                Return Me.salesOrdersAndQuotesField
            End Get
            Set
                Me.salesOrdersAndQuotesField = value
            End Set
        End Property
        
        Public Property BillOfMaterialsAndEstimates() As PostConfigurationItemBillOfMaterialsAndEstimates
            Get
                Return Me.billOfMaterialsAndEstimatesField
            End Get
            Set
                Me.billOfMaterialsAndEstimatesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemCallSource
        
        '''<remarks/>
        T
        
        '''<remarks/>
        S
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        B
        
        '''<remarks/>
        E
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemOverrideComponentWh
        
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
    Partial Public Class PostConfigurationItemSalesOrdersAndQuotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newSalesOrderQuoteField As PostConfigurationItemSalesOrdersAndQuotesNewSalesOrderQuote
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfOrderField As PostConfigurationItemSalesOrdersAndQuotesTypeOfOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixExchangeRateField As PostConfigurationItemSalesOrdersAndQuotesFixExchangeRate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private exchangeRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnZeroPriceField As PostConfigurationItemSalesOrdersAndQuotesWarnZeroPrice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private forceShipDateField As PostConfigurationItemSalesOrdersAndQuotesForceShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private currentOrderValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateReferenceField As String
        
        Public Sub New()
            MyBase.New
            Me.newSalesOrderQuoteField = PostConfigurationItemSalesOrdersAndQuotesNewSalesOrderQuote.Y
            Me.typeOfOrderField = PostConfigurationItemSalesOrdersAndQuotesTypeOfOrder.ORD
            Me.fixExchangeRateField = PostConfigurationItemSalesOrdersAndQuotesFixExchangeRate.N
            Me.warnZeroPriceField = PostConfigurationItemSalesOrdersAndQuotesWarnZeroPrice.N
            Me.forceShipDateField = PostConfigurationItemSalesOrdersAndQuotesForceShipDate.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSalesOrdersAndQuotesNewSalesOrderQuote.Y)>  _
        Public Property NewSalesOrderQuote() As PostConfigurationItemSalesOrdersAndQuotesNewSalesOrderQuote
            Get
                Return Me.newSalesOrderQuoteField
            End Get
            Set
                Me.newSalesOrderQuoteField = value
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
        
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
        
        Public Property CustomerPoNumber() As String
            Get
                Return Me.customerPoNumberField
            End Get
            Set
                Me.customerPoNumberField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSalesOrdersAndQuotesTypeOfOrder.ORD)>  _
        Public Property TypeOfOrder() As PostConfigurationItemSalesOrdersAndQuotesTypeOfOrder
            Get
                Return Me.typeOfOrderField
            End Get
            Set
                Me.typeOfOrderField = value
            End Set
        End Property
        
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSalesOrdersAndQuotesFixExchangeRate.N)>  _
        Public Property FixExchangeRate() As PostConfigurationItemSalesOrdersAndQuotesFixExchangeRate
            Get
                Return Me.fixExchangeRateField
            End Get
            Set
                Me.fixExchangeRateField = value
            End Set
        End Property
        
        Public Property ExchangeRate() As String
            Get
                Return Me.exchangeRateField
            End Get
            Set
                Me.exchangeRateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSalesOrdersAndQuotesWarnZeroPrice.N)>  _
        Public Property WarnZeroPrice() As PostConfigurationItemSalesOrdersAndQuotesWarnZeroPrice
            Get
                Return Me.warnZeroPriceField
            End Get
            Set
                Me.warnZeroPriceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostConfigurationItemSalesOrdersAndQuotesForceShipDate.N)>  _
        Public Property ForceShipDate() As PostConfigurationItemSalesOrdersAndQuotesForceShipDate
            Get
                Return Me.forceShipDateField
            End Get
            Set
                Me.forceShipDateField = value
            End Set
        End Property
        
        Public Property CurrentOrderValue() As String
            Get
                Return Me.currentOrderValueField
            End Get
            Set
                Me.currentOrderValueField = value
            End Set
        End Property
        
        Public Property AlternateReference() As String
            Get
                Return Me.alternateReferenceField
            End Get
            Set
                Me.alternateReferenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSalesOrdersAndQuotesNewSalesOrderQuote
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSalesOrdersAndQuotesTypeOfOrder
        
        '''<remarks/>
        ORD
        
        '''<remarks/>
        FWD
        
        '''<remarks/>
        SCH
        
        '''<remarks/>
        IBT
        
        '''<remarks/>
        BIL
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSalesOrdersAndQuotesFixExchangeRate
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSalesOrdersAndQuotesWarnZeroPrice
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostConfigurationItemSalesOrdersAndQuotesForceShipDate
        
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
    Partial Public Class PostConfigurationItemBillOfMaterialsAndEstimates
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
    End Class
End Namespace
