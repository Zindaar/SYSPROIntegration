Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipProjectsAndContracts.ProjectsAndContractsQuery.QueryData
    
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
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
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
                Return "PRJQRY"
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
        Private contractOrJobField As QueryKeyContractOrJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private queryKey1Field As String
        
        Public Sub New()
            MyBase.New
            Me.contractOrJobField = QueryKeyContractOrJob.C
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryKeyContractOrJob.C)>  _
        Public Property ContractOrJob() As QueryKeyContractOrJob
            Get
                Return Me.contractOrJobField
            End Get
            Set
                Me.contractOrJobField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("QueryKey")>  _
        Public Property QueryKey1() As String
            Get
                Return Me.queryKey1Field
            End Get
            Set
                Me.queryKey1Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryKeyContractOrJob
        
        '''<remarks/>
        C
        
        '''<remarks/>
        J
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class QueryOption
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeHierarchyDetailsField As QueryOptionIncludeHierarchyDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesandAdjustmentsField As QueryOptionIncludeSalesandAdjustments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBillingsAndCostOfSalesField As QueryOptionIncludeBillingsAndCostOfSales
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommittedMaterialField As QueryOptionIncludeCommittedMaterial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommittedLaborField As QueryOptionIncludeCommittedLabor
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCommittedSubcontractField As QueryOptionIncludeCommittedSubcontract
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrdersField As QueryOptionIncludePurchaseOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUncommittedMaterialField As QueryOptionIncludeUncommittedMaterial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUncommittedLaborField As QueryOptionIncludeUncommittedLabor
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUncommittedSubcontractField As QueryOptionIncludeUncommittedSubcontract
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiMediaImageTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeHierarchyDetailsField = QueryOptionIncludeHierarchyDetails.Y
            Me.includeSalesandAdjustmentsField = QueryOptionIncludeSalesandAdjustments.Y
            Me.includeBillingsAndCostOfSalesField = QueryOptionIncludeBillingsAndCostOfSales.Y
            Me.includeCommittedMaterialField = QueryOptionIncludeCommittedMaterial.N
            Me.includeCommittedLaborField = QueryOptionIncludeCommittedLabor.N
            Me.includeCommittedSubcontractField = QueryOptionIncludeCommittedSubcontract.N
            Me.includePurchaseOrdersField = QueryOptionIncludePurchaseOrders.N
            Me.includeUncommittedMaterialField = QueryOptionIncludeUncommittedMaterial.N
            Me.includeUncommittedLaborField = QueryOptionIncludeUncommittedLabor.N
            Me.includeUncommittedSubcontractField = QueryOptionIncludeUncommittedSubcontract.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeHierarchyDetails.Y)>  _
        Public Property IncludeHierarchyDetails() As QueryOptionIncludeHierarchyDetails
            Get
                Return Me.includeHierarchyDetailsField
            End Get
            Set
                Me.includeHierarchyDetailsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesandAdjustments.Y)>  _
        Public Property IncludeSalesandAdjustments() As QueryOptionIncludeSalesandAdjustments
            Get
                Return Me.includeSalesandAdjustmentsField
            End Get
            Set
                Me.includeSalesandAdjustmentsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeBillingsAndCostOfSales.Y)>  _
        Public Property IncludeBillingsAndCostOfSales() As QueryOptionIncludeBillingsAndCostOfSales
            Get
                Return Me.includeBillingsAndCostOfSalesField
            End Get
            Set
                Me.includeBillingsAndCostOfSalesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommittedMaterial.N)>  _
        Public Property IncludeCommittedMaterial() As QueryOptionIncludeCommittedMaterial
            Get
                Return Me.includeCommittedMaterialField
            End Get
            Set
                Me.includeCommittedMaterialField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommittedLabor.N)>  _
        Public Property IncludeCommittedLabor() As QueryOptionIncludeCommittedLabor
            Get
                Return Me.includeCommittedLaborField
            End Get
            Set
                Me.includeCommittedLaborField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommittedSubcontract.N)>  _
        Public Property IncludeCommittedSubcontract() As QueryOptionIncludeCommittedSubcontract
            Get
                Return Me.includeCommittedSubcontractField
            End Get
            Set
                Me.includeCommittedSubcontractField = value
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
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeUncommittedMaterial.N)>  _
        Public Property IncludeUncommittedMaterial() As QueryOptionIncludeUncommittedMaterial
            Get
                Return Me.includeUncommittedMaterialField
            End Get
            Set
                Me.includeUncommittedMaterialField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeUncommittedLabor.N)>  _
        Public Property IncludeUncommittedLabor() As QueryOptionIncludeUncommittedLabor
            Get
                Return Me.includeUncommittedLaborField
            End Get
            Set
                Me.includeUncommittedLaborField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeUncommittedSubcontract.N)>  _
        Public Property IncludeUncommittedSubcontract() As QueryOptionIncludeUncommittedSubcontract
            Get
                Return Me.includeUncommittedSubcontractField
            End Get
            Set
                Me.includeUncommittedSubcontractField = value
            End Set
        End Property
        
        Public Property MultiMediaImageType() As String
            Get
                Return Me.multiMediaImageTypeField
            End Get
            Set
                Me.multiMediaImageTypeField = value
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
    Public Enum QueryOptionIncludeHierarchyDetails
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeSalesandAdjustments
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeBillingsAndCostOfSales
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCommittedMaterial
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCommittedLabor
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeCommittedSubcontract
        
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
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeUncommittedMaterial
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeUncommittedLabor
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum QueryOptionIncludeUncommittedSubcontract
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
