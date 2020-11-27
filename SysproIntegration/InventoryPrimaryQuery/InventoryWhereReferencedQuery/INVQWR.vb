Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryWhereReferencedQuery.QueryData
    
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
        Private keyField As QueryKey
        
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
            If (Me.keyField Is Nothing) Then
                Me.keyField = New QueryKey
            End If
        End Sub
        
        Public Property Key() As QueryKey
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
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
                Return "INVQWR"
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
    Partial Public Class QueryKey
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsField As QueryOptionIncludeLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMultipleBinsField As QueryOptionIncludeMultipleBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFIFOBucketsField As QueryOptionIncludeFIFOBuckets
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGoodsInInspectionField As QueryOptionIncludeGoodsInInspection
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeGoodsInTransitField As QueryOptionIncludeGoodsInTransit
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSupplyChainTransfersField As QueryOptionIncludeSupplyChainTransfers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialTrackingField As QueryOptionIncludeSerialTracking
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateStkField As QueryOptionIncludeAlternateStk
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeAlternateSupplierField As QueryOptionIncludeAlternateSupplier
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeECCRevisionReleaseField As QueryOptionIncludeECCRevisionRelease
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLctRoutesField As QueryOptionIncludeLctRoutes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrdersField As QueryOptionIncludePurchaseOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBlanketPOrdersField As QueryOptionIncludeBlanketPOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeForeignPricesField As QueryOptionIncludeForeignPrices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBomWhereUsedField As QueryOptionIncludeBomWhereUsed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWorkInProgressField As QueryOptionIncludeWorkInProgress
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobsCompletedField As QueryOptionIncludeJobsCompleted
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSubJobsField As QueryOptionIncludeSubJobs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSubJobsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWipAllocationsField As QueryOptionIncludeWipAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBomRoutingsField As QueryOptionIncludeBomRoutings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBuildScheduleField As QueryOptionIncludeBuildSchedule
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBomStructuresField As QueryOptionIncludeBomStructures
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrdersField As QueryOptionIncludeSalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDispatchNotesField As QueryOptionIncludeDispatchNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePricingField As QueryOptionIncludePricing
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSupplierStockCodeField As QueryOptionIncludeSupplierStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomerStockCodeField As QueryOptionIncludeCustomerStockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeRequisitionsField As QueryOptionIncludeRequisitions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesHistoryField As QueryOptionIncludeSalesHistory
        
        Public Sub New()
            MyBase.New
            Me.includeLotsField = QueryOptionIncludeLots.N
            Me.includeMultipleBinsField = QueryOptionIncludeMultipleBins.N
            Me.includeFIFOBucketsField = QueryOptionIncludeFIFOBuckets.N
            Me.includeGoodsInInspectionField = QueryOptionIncludeGoodsInInspection.N
            Me.includeGoodsInTransitField = QueryOptionIncludeGoodsInTransit.N
            Me.includeSupplyChainTransfersField = QueryOptionIncludeSupplyChainTransfers.N
            Me.includeSerialTrackingField = QueryOptionIncludeSerialTracking.N
            Me.includeAlternateStkField = QueryOptionIncludeAlternateStk.N
            Me.includeAlternateSupplierField = QueryOptionIncludeAlternateSupplier.N
            Me.includeECCRevisionReleaseField = QueryOptionIncludeECCRevisionRelease.N
            Me.includeLctRoutesField = QueryOptionIncludeLctRoutes.N
            Me.includePurchaseOrdersField = QueryOptionIncludePurchaseOrders.N
            Me.includeBlanketPOrdersField = QueryOptionIncludeBlanketPOrders.N
            Me.includeForeignPricesField = QueryOptionIncludeForeignPrices.N
            Me.includeBomWhereUsedField = QueryOptionIncludeBomWhereUsed.N
            Me.includeWorkInProgressField = QueryOptionIncludeWorkInProgress.N
            Me.includeJobsCompletedField = QueryOptionIncludeJobsCompleted.I
            Me.includeWipAllocationsField = QueryOptionIncludeWipAllocations.N
            Me.includeBomRoutingsField = QueryOptionIncludeBomRoutings.N
            Me.includeBuildScheduleField = QueryOptionIncludeBuildSchedule.N
            Me.includeBomStructuresField = QueryOptionIncludeBomStructures.N
            Me.includeSalesOrdersField = QueryOptionIncludeSalesOrders.N
            Me.includeDispatchNotesField = QueryOptionIncludeDispatchNotes.N
            Me.includePricingField = QueryOptionIncludePricing.N
            Me.includeSupplierStockCodeField = QueryOptionIncludeSupplierStockCode.N
            Me.includeCustomerStockCodeField = QueryOptionIncludeCustomerStockCode.N
            Me.includeRequisitionsField = QueryOptionIncludeRequisitions.N
            Me.includeSalesHistoryField = QueryOptionIncludeSalesHistory.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeLots.N)>  _
        Public Property IncludeLots() As QueryOptionIncludeLots
            Get
                Return Me.includeLotsField
            End Get
            Set
                Me.includeLotsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeMultipleBins.N)>  _
        Public Property IncludeMultipleBins() As QueryOptionIncludeMultipleBins
            Get
                Return Me.includeMultipleBinsField
            End Get
            Set
                Me.includeMultipleBinsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeFIFOBuckets.N)>  _
        Public Property IncludeFIFOBuckets() As QueryOptionIncludeFIFOBuckets
            Get
                Return Me.includeFIFOBucketsField
            End Get
            Set
                Me.includeFIFOBucketsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeGoodsInInspection.N)>  _
        Public Property IncludeGoodsInInspection() As QueryOptionIncludeGoodsInInspection
            Get
                Return Me.includeGoodsInInspectionField
            End Get
            Set
                Me.includeGoodsInInspectionField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeGoodsInTransit.N)>  _
        Public Property IncludeGoodsInTransit() As QueryOptionIncludeGoodsInTransit
            Get
                Return Me.includeGoodsInTransitField
            End Get
            Set
                Me.includeGoodsInTransitField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSupplyChainTransfers.N)>  _
        Public Property IncludeSupplyChainTransfers() As QueryOptionIncludeSupplyChainTransfers
            Get
                Return Me.includeSupplyChainTransfersField
            End Get
            Set
                Me.includeSupplyChainTransfersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSerialTracking.N)>  _
        Public Property IncludeSerialTracking() As QueryOptionIncludeSerialTracking
            Get
                Return Me.includeSerialTrackingField
            End Get
            Set
                Me.includeSerialTrackingField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeAlternateStk.N)>  _
        Public Property IncludeAlternateStk() As QueryOptionIncludeAlternateStk
            Get
                Return Me.includeAlternateStkField
            End Get
            Set
                Me.includeAlternateStkField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeAlternateSupplier.N)>  _
        Public Property IncludeAlternateSupplier() As QueryOptionIncludeAlternateSupplier
            Get
                Return Me.includeAlternateSupplierField
            End Get
            Set
                Me.includeAlternateSupplierField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeECCRevisionRelease.N)>  _
        Public Property IncludeECCRevisionRelease() As QueryOptionIncludeECCRevisionRelease
            Get
                Return Me.includeECCRevisionReleaseField
            End Get
            Set
                Me.includeECCRevisionReleaseField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeLctRoutes.N)>  _
        Public Property IncludeLctRoutes() As QueryOptionIncludeLctRoutes
            Get
                Return Me.includeLctRoutesField
            End Get
            Set
                Me.includeLctRoutesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludePurchaseOrders.N)>  _
        Public Property IncludePurchaseOrders() As QueryOptionIncludePurchaseOrders
            Get
                Return Me.includePurchaseOrdersField
            End Get
            Set
                Me.includePurchaseOrdersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBlanketPOrders.N)>  _
        Public Property IncludeBlanketPOrders() As QueryOptionIncludeBlanketPOrders
            Get
                Return Me.includeBlanketPOrdersField
            End Get
            Set
                Me.includeBlanketPOrdersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeForeignPrices.N)>  _
        Public Property IncludeForeignPrices() As QueryOptionIncludeForeignPrices
            Get
                Return Me.includeForeignPricesField
            End Get
            Set
                Me.includeForeignPricesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBomWhereUsed.N)>  _
        Public Property IncludeBomWhereUsed() As QueryOptionIncludeBomWhereUsed
            Get
                Return Me.includeBomWhereUsedField
            End Get
            Set
                Me.includeBomWhereUsedField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeWorkInProgress.N)>  _
        Public Property IncludeWorkInProgress() As QueryOptionIncludeWorkInProgress
            Get
                Return Me.includeWorkInProgressField
            End Get
            Set
                Me.includeWorkInProgressField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeJobsCompleted.I)>  _
        Public Property IncludeJobsCompleted() As QueryOptionIncludeJobsCompleted
            Get
                Return Me.includeJobsCompletedField
            End Get
            Set
                Me.includeJobsCompletedField = value
            End Set
        End Property
        
        Public Property IncludeSubJobs() As QueryOptionIncludeSubJobs
            Get
                Return Me.includeSubJobsField
            End Get
            Set
                Me.includeSubJobsField = value
                Me.IncludeSubJobsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeSubJobsSpecified() As Boolean
            Get
                Return Me.includeSubJobsFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeWipAllocations.N)>  _
        Public Property IncludeWipAllocations() As QueryOptionIncludeWipAllocations
            Get
                Return Me.includeWipAllocationsField
            End Get
            Set
                Me.includeWipAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBomRoutings.N)>  _
        Public Property IncludeBomRoutings() As QueryOptionIncludeBomRoutings
            Get
                Return Me.includeBomRoutingsField
            End Get
            Set
                Me.includeBomRoutingsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBuildSchedule.N)>  _
        Public Property IncludeBuildSchedule() As QueryOptionIncludeBuildSchedule
            Get
                Return Me.includeBuildScheduleField
            End Get
            Set
                Me.includeBuildScheduleField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBomStructures.N)>  _
        Public Property IncludeBomStructures() As QueryOptionIncludeBomStructures
            Get
                Return Me.includeBomStructuresField
            End Get
            Set
                Me.includeBomStructuresField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesOrders.N)>  _
        Public Property IncludeSalesOrders() As QueryOptionIncludeSalesOrders
            Get
                Return Me.includeSalesOrdersField
            End Get
            Set
                Me.includeSalesOrdersField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeDispatchNotes.N)>  _
        Public Property IncludeDispatchNotes() As QueryOptionIncludeDispatchNotes
            Get
                Return Me.includeDispatchNotesField
            End Get
            Set
                Me.includeDispatchNotesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludePricing.N)>  _
        Public Property IncludePricing() As QueryOptionIncludePricing
            Get
                Return Me.includePricingField
            End Get
            Set
                Me.includePricingField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSupplierStockCode.N)>  _
        Public Property IncludeSupplierStockCode() As QueryOptionIncludeSupplierStockCode
            Get
                Return Me.includeSupplierStockCodeField
            End Get
            Set
                Me.includeSupplierStockCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomerStockCode.N)>  _
        Public Property IncludeCustomerStockCode() As QueryOptionIncludeCustomerStockCode
            Get
                Return Me.includeCustomerStockCodeField
            End Get
            Set
                Me.includeCustomerStockCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeRequisitions.N)>  _
        Public Property IncludeRequisitions() As QueryOptionIncludeRequisitions
            Get
                Return Me.includeRequisitionsField
            End Get
            Set
                Me.includeRequisitionsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesHistory.N)>  _
        Public Property IncludeSalesHistory() As QueryOptionIncludeSalesHistory
            Get
                Return Me.includeSalesHistoryField
            End Get
            Set
                Me.includeSalesHistoryField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeLots
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeMultipleBins
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeFIFOBuckets
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeGoodsInInspection
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeGoodsInTransit
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSupplyChainTransfers
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSerialTracking
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeAlternateStk
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeAlternateSupplier
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeECCRevisionRelease
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeLctRoutes
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludePurchaseOrders
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBlanketPOrders
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeForeignPrices
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBomWhereUsed
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeWorkInProgress
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeJobsCompleted
        
        '''<remarks/>
        I
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSubJobs
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeWipAllocations
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBomRoutings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBuildSchedule
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBomStructures
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSalesOrders
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeDispatchNotes
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludePricing
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSupplierStockCode
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCustomerStockCode
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeRequisitions
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSalesHistory
        
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
    Partial Public Class QueryFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As QueryFilterWarehouse
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New QueryFilterWarehouse
            End If
        End Sub
        
        Public Property Warehouse() As QueryFilterWarehouse
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
    End Class
    
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
        S
    End Enum
End Namespace
