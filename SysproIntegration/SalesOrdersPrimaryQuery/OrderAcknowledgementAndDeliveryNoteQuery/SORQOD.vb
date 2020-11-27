Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.OrderAcknowledgementAndDeliveryNoteQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New QueryFilter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption
            End If
        End Sub
        
        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Filter() As QueryFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "SORQOD"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reprintField As QueryOptionReprint
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentTypeField As QueryOptionDocumentType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOnlyIfMerchLinesField As QueryOptionIncludeOnlyIfMerchLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeChgWithoutMerchLineField As QueryOptionIncludeChgWithoutMerchLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateToCheckField As QueryOptionDateToCheck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deliveryNoteCompleteField As QueryOptionDeliveryNoteComplete
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNonStockedField As QueryOptionIncludeNonStocked
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueOrderAckWithShipQtyField As QueryOptionValueOrderAckWithShipQty
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCredDebForOrderAckField As QueryOptionIncludeCredDebForOrderAck
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSCTField As QueryOptionIncludeSCT
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFormsField As QueryOptionIncludeForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomerFormsField As QueryOptionIncludeCustomerForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeStockFormsField As QueryOptionIncludeStockForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDetailFormsField As QueryOptionIncludeDetailForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeNotesField As QueryOptionIncludeNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignorePrintStatusField As QueryOptionIgnorePrintStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roundMassField As QueryOptionRoundMass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roundMassDecsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roundVolumeField As QueryOptionRoundVolume
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roundVolumeDecsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.reprintField = QueryOptionReprint.N
            Me.documentTypeField = QueryOptionDocumentType.D
            Me.includeOnlyIfMerchLinesField = QueryOptionIncludeOnlyIfMerchLines.N
            Me.includeChgWithoutMerchLineField = QueryOptionIncludeChgWithoutMerchLine.Y
            Me.dateToCheckField = QueryOptionDateToCheck.N
            Me.deliveryNoteCompleteField = QueryOptionDeliveryNoteComplete.Y
            Me.includeNonStockedField = QueryOptionIncludeNonStocked.N
            Me.valueOrderAckWithShipQtyField = QueryOptionValueOrderAckWithShipQty.N
            Me.includeCredDebForOrderAckField = QueryOptionIncludeCredDebForOrderAck.N
            Me.includeSCTField = QueryOptionIncludeSCT.I
            Me.includeFormsField = QueryOptionIncludeForms.N
            Me.includeCustomerFormsField = QueryOptionIncludeCustomerForms.N
            Me.includeStockFormsField = QueryOptionIncludeStockForms.N
            Me.includeDetailFormsField = QueryOptionIncludeDetailForms.N
            Me.includeNotesField = QueryOptionIncludeNotes.N
            Me.ignorePrintStatusField = QueryOptionIgnorePrintStatus.N
            Me.roundMassField = QueryOptionRoundMass.O
            Me.roundVolumeField = QueryOptionRoundVolume.O
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionReprint.N)>  _
        Public Property Reprint() As QueryOptionReprint
            Get
                Return Me.reprintField
            End Get
            Set
                Me.reprintField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionDocumentType.D)>  _
        Public Property DocumentType() As QueryOptionDocumentType
            Get
                Return Me.documentTypeField
            End Get
            Set
                Me.documentTypeField = value
            End Set
        End Property
        
        Public Property DocumentDate() As String
            Get
                Return Me.documentDateField
            End Get
            Set
                Me.documentDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeOnlyIfMerchLines.N)>  _
        Public Property IncludeOnlyIfMerchLines() As QueryOptionIncludeOnlyIfMerchLines
            Get
                Return Me.includeOnlyIfMerchLinesField
            End Get
            Set
                Me.includeOnlyIfMerchLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeChgWithoutMerchLine.Y)>  _
        Public Property IncludeChgWithoutMerchLine() As QueryOptionIncludeChgWithoutMerchLine
            Get
                Return Me.includeChgWithoutMerchLineField
            End Get
            Set
                Me.includeChgWithoutMerchLineField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionDateToCheck.N)>  _
        Public Property DateToCheck() As QueryOptionDateToCheck
            Get
                Return Me.dateToCheckField
            End Get
            Set
                Me.dateToCheckField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionDeliveryNoteComplete.Y)>  _
        Public Property DeliveryNoteComplete() As QueryOptionDeliveryNoteComplete
            Get
                Return Me.deliveryNoteCompleteField
            End Get
            Set
                Me.deliveryNoteCompleteField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStocked.N)>  _
        Public Property IncludeNonStocked() As QueryOptionIncludeNonStocked
            Get
                Return Me.includeNonStockedField
            End Get
            Set
                Me.includeNonStockedField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionValueOrderAckWithShipQty.N)>  _
        Public Property ValueOrderAckWithShipQty() As QueryOptionValueOrderAckWithShipQty
            Get
                Return Me.valueOrderAckWithShipQtyField
            End Get
            Set
                Me.valueOrderAckWithShipQtyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCredDebForOrderAck.N)>  _
        Public Property IncludeCredDebForOrderAck() As QueryOptionIncludeCredDebForOrderAck
            Get
                Return Me.includeCredDebForOrderAckField
            End Get
            Set
                Me.includeCredDebForOrderAckField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSCT.I)>  _
        Public Property IncludeSCT() As QueryOptionIncludeSCT
            Get
                Return Me.includeSCTField
            End Get
            Set
                Me.includeSCTField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeForms.N)>  _
        Public Property IncludeForms() As QueryOptionIncludeForms
            Get
                Return Me.includeFormsField
            End Get
            Set
                Me.includeFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomerForms.N)>  _
        Public Property IncludeCustomerForms() As QueryOptionIncludeCustomerForms
            Get
                Return Me.includeCustomerFormsField
            End Get
            Set
                Me.includeCustomerFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeStockForms.N)>  _
        Public Property IncludeStockForms() As QueryOptionIncludeStockForms
            Get
                Return Me.includeStockFormsField
            End Get
            Set
                Me.includeStockFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeDetailForms.N)>  _
        Public Property IncludeDetailForms() As QueryOptionIncludeDetailForms
            Get
                Return Me.includeDetailFormsField
            End Get
            Set
                Me.includeDetailFormsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNotes.N)>  _
        Public Property IncludeNotes() As QueryOptionIncludeNotes
            Get
                Return Me.includeNotesField
            End Get
            Set
                Me.includeNotesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIgnorePrintStatus.N)>  _
        Public Property IgnorePrintStatus() As QueryOptionIgnorePrintStatus
            Get
                Return Me.ignorePrintStatusField
            End Get
            Set
                Me.ignorePrintStatusField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionRoundMass.O)>  _
        Public Property RoundMass() As QueryOptionRoundMass
            Get
                Return Me.roundMassField
            End Get
            Set
                Me.roundMassField = value
            End Set
        End Property
        
        Public Property RoundMassDecs() As String
            Get
                Return Me.roundMassDecsField
            End Get
            Set
                Me.roundMassDecsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionRoundVolume.O)>  _
        Public Property RoundVolume() As QueryOptionRoundVolume
            Get
                Return Me.roundVolumeField
            End Get
            Set
                Me.roundVolumeField = value
            End Set
        End Property
        
        Public Property RoundVolumeDecs() As String
            Get
                Return Me.roundVolumeDecsField
            End Get
            Set
                Me.roundVolumeDecsField = value
            End Set
        End Property
        
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionReprint
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionDocumentType
        
        '''<remarks/>
        D
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeOnlyIfMerchLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeChgWithoutMerchLine
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionDateToCheck
        
        '''<remarks/>
        N
        
        '''<remarks/>
        L
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionDeliveryNoteComplete
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNonStocked
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionValueOrderAckWithShipQty
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCredDebForOrderAck
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSCT
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
        
        '''<remarks/>
        O
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeForms
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCustomerForms
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeStockForms
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeDetailForms
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeNotes
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIgnorePrintStatus
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionRoundMass
        
        '''<remarks/>
        O
        
        '''<remarks/>
        U
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionRoundVolume
        
        '''<remarks/>
        O
        
        '''<remarks/>
        U
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private branchField As QueryFilterBranch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As QueryFilterCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As QueryFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As QueryFilterOrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerPoField As QueryFilterCustomerPo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As QueryFilterSalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderDateField As QueryFilterOrderDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorField As QueryFilterOperator
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private geographicAreaField As QueryFilterGeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private requestedDateField As QueryFilterRequestedDate
        
        Public Sub New()
            MyBase.New
            If (Me.requestedDateField Is Nothing) Then
                Me.requestedDateField = New QueryFilterRequestedDate
            End If
            If (Me.geographicAreaField Is Nothing) Then
                Me.geographicAreaField = New QueryFilterGeographicArea
            End If
            If (Me.operatorField Is Nothing) Then
                Me.operatorField = New QueryFilterOperator
            End If
            If (Me.orderDateField Is Nothing) Then
                Me.orderDateField = New QueryFilterOrderDate
            End If
            If (Me.salesOrderField Is Nothing) Then
                Me.salesOrderField = New QueryFilterSalesOrder
            End If
            If (Me.customerPoField Is Nothing) Then
                Me.customerPoField = New QueryFilterCustomerPo
            End If
            If (Me.orderTypeField Is Nothing) Then
                Me.orderTypeField = New QueryFilterOrderType
            End If
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New QueryFilterWarehouse
            End If
            If (Me.customerField Is Nothing) Then
                Me.customerField = New QueryFilterCustomer
            End If
            If (Me.branchField Is Nothing) Then
                Me.branchField = New QueryFilterBranch
            End If
        End Sub
        
        Public Property Branch() As QueryFilterBranch
            Get
                Return Me.branchField
            End Get
            Set
                Me.branchField = value
            End Set
        End Property
        
        Public Property Customer() As QueryFilterCustomer
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        Public Property Warehouse() As QueryFilterWarehouse
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property OrderType() As QueryFilterOrderType
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        Public Property CustomerPo() As QueryFilterCustomerPo
            Get
                Return Me.customerPoField
            End Get
            Set
                Me.customerPoField = value
            End Set
        End Property
        
        Public Property SalesOrder() As QueryFilterSalesOrder
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        Public Property OrderDate() As QueryFilterOrderDate
            Get
                Return Me.orderDateField
            End Get
            Set
                Me.orderDateField = value
            End Set
        End Property
        
        Public Property [Operator]() As QueryFilterOperator
            Get
                Return Me.operatorField
            End Get
            Set
                Me.operatorField = value
            End Set
        End Property
        
        Public Property GeographicArea() As QueryFilterGeographicArea
            Get
                Return Me.geographicAreaField
            End Get
            Set
                Me.geographicAreaField = value
            End Set
        End Property
        
        Public Property RequestedDate() As QueryFilterRequestedDate
            Get
                Return Me.requestedDateField
            End Get
            Set
                Me.requestedDateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterBranch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterBranchFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterBranchFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterBranchFilterType.A)>  _
        Public Property FilterType() As QueryFilterBranchFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterBranchFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterCustomer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterCustomerFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterCustomerFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerFilterType.A)>  _
        Public Property FilterType() As QueryFilterCustomerFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterCustomerFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
        
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
    Partial Public Class QueryFilterWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterWarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterWarehouseFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterWarehouseFilterType.A)>  _
        Public Property FilterType() As QueryFilterWarehouseFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterWarehouseFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryFilterOrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterOrderTypeFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterOrderTypeFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterOrderTypeFilterType.A)>  _
        Public Property FilterType() As QueryFilterOrderTypeFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterOrderTypeFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterCustomerPo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterCustomerPoFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As QueryFilterCustomerPoFilterValue
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterCustomerPoFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerPoFilterType.A)>  _
        Public Property FilterType() As QueryFilterCustomerPoFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As QueryFilterCustomerPoFilterValue
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
                Me.FilterValueFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FilterValueSpecified() As Boolean
            Get
                Return Me.filterValueFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterCustomerPoFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterCustomerPoFilterValue
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterSalesOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterSalesOrderFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterSalesOrderFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterSalesOrderFilterType.A)>  _
        Public Property FilterType() As QueryFilterSalesOrderFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterSalesOrderFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
        
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
    Partial Public Class QueryFilterOrderDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterOrderDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterOrderDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterOrderDateFilterType.A)>  _
        Public Property FilterType() As QueryFilterOrderDateFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterOrderDateFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterOperator
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterOperatorFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterOperatorFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterOperatorFilterType.A)>  _
        Public Property FilterType() As QueryFilterOperatorFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterOperatorFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterGeographicArea
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterGeographicAreaFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterGeographicAreaFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterGeographicAreaFilterType.A)>  _
        Public Property FilterType() As QueryFilterGeographicAreaFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterGeographicAreaFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
        
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
    Partial Public Class QueryFilterRequestedDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As QueryFilterRequestedDateFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = QueryFilterRequestedDateFilterType.A
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute(QueryFilterRequestedDateFilterType.A)>  _
        Public Property FilterType() As QueryFilterRequestedDateFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryFilterRequestedDateFilterType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
