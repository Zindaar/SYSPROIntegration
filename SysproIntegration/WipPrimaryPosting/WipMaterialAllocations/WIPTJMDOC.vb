Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.WipMaterialAllocations.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ComponentWhToUse
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ExplodeIfKitPart
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ExplodeIfPhantomPart
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class HierarchyJob
        
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
        
        '''<summary>
        '''Head is part of a unique key to identify a hierarchy. Mandatory when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Head() As String
            Get
                Return Me.headField
            End Get
            Set
                Me.headField = value
            End Set
        End Property
        
        '''<summary>
        '''Section1 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section2 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section3 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Section4 is part of a unique key to identify a hierarchy. Used when the job is a hierarchical job. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedField As NonStocked
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private explodeIfPhantomPartField As ExplodeIfPhantomPart
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private explodeIfKitPartField As ExplodeIfKitPart
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentWhToUseField As ComponentWhToUse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockDescriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReqdTypeField As QtyReqdType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyReqdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerFlagField As ItemFixedQtyPerFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationOffsetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagField As OpOffsetFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyJobField As HierarchyJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        Public Sub New()
            MyBase.New
            Me.nonStockedField = NonStocked.N
            Me.explodeIfPhantomPartField = ExplodeIfPhantomPart.N
            Me.explodeIfKitPartField = ExplodeIfKitPart.N
            Me.componentWhToUseField = ComponentWhToUse.N
            Me.qtyReqdTypeField = QtyReqdType.U
            Me.fixedQtyPerFlagField = ItemFixedQtyPerFlag.N
            Me.opOffsetFlagField = OpOffsetFlag.O
            If (Me.hierarchyJobField Is Nothing) Then
                Me.hierarchyJobField = New HierarchyJob
            End If
        End Sub
        
        '''<summary>
        '''Job specifies the job for which the allocations are being maintained. The format
        '''is 8 characters alphanumeric or 8 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        '''<summary>
        '''NonStocked specifies whether the allocation being maintained is non-stocked or not. (Y - non-stocked, N - Stocked)
        '''</summary>
        Public Property NonStocked() As NonStocked
            Get
                Return Me.nonStockedField
            End Get
            Set
                Me.nonStockedField = value
            End Set
        End Property
        
        '''<summary>
        '''The StockCode indicates the component for the job to be maintained. The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Warehouse specifies the warehouse to use of the allocation. If non-stocked this field will be ignored else the warehouse will be required for stocked items. When updating and consolidated warehouses are used - the warehouse supplied must be '--'. Format is 2 characters alphanumeric.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''NewWarehouse specifies the new warehouse to be added to an existing allocation. Only used when updating and nothing has been issued for this allocation, consolidated warehouses are not being used, snapshot allocations are not being maintained and  the allocations are not for a hierachical job. Format is 2 characters alphanumeric.
        '''</summary>
        Public Property NewWarehouse() As String
            Get
                Return Me.newWarehouseField
            End Get
            Set
                Me.newWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''Line specifies the line number of allocations. When adding this line will be generated automatically - i.e. should not be supplied. When updating or deleting this number must be supplied. Format is 2 characters alphanumeric .
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''ExplodeIfPhantomPart specifies whether to add the components of a phantom part or not ( Y -add components of phantom, N - add phantom part ) 
        '''</summary>
        Public Property ExplodeIfPhantomPart() As ExplodeIfPhantomPart
            Get
                Return Me.explodeIfPhantomPartField
            End Get
            Set
                Me.explodeIfPhantomPartField = value
            End Set
        End Property
        
        '''<summary>
        '''ExplodeIfKitPart specifies whether to add the components of a kit type part 
        '''or not ( Y -add components of kit, N - add kit part) 
        '''</summary>
        Public Property ExplodeIfKitPart() As ExplodeIfKitPart
            Get
                Return Me.explodeIfKitPartField
            End Get
            Set
                Me.explodeIfKitPartField = value
            End Set
        End Property
        
        '''<summary>
        '''ComponentWhToUse specifies whether or not to use the warehouses of the components of exploded kit or phantom parts ( Y - yes, N - no)
        '''</summary>
        Public Property ComponentWhToUse() As ComponentWhToUse
            Get
                Return Me.componentWhToUseField
            End Get
            Set
                Me.componentWhToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''StockDescription describes the stock code. The stock code description for a stocked item will be retrieved from the inventory master file but a description can be entered for a non-stocked item. The format is 30 characters alphanumeric.
        '''</summary>
        Public Property StockDescription() As String
            Get
                Return Me.stockDescriptionField
            End Get
            Set
                Me.stockDescriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''QtyReqdType indicates whether the total quantity or the quantity per will be used for the allocation. (U - Quantity per, T - Total quantity).
        '''</summary>
        Public Property QtyReqdType() As QtyReqdType
            Get
                Return Me.qtyReqdTypeField
            End Get
            Set
                Me.qtyReqdTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''QtyReqd indicates either total quantity or the quantity per of the allocation. The value supplied in the QtyReqdType will allow you to either add the total quantity or the quantity per of the allocation.  For a non-stocked item this value may not be zero. The format is signed 6.6
        '''</summary>
        Public Property QtyReqd() As String
            Get
                Return Me.qtyReqdField
            End Get
            Set
                Me.qtyReqdField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemFixedQtyPerFlag.N)>  _
        Public Property FixedQtyPerFlag() As ItemFixedQtyPerFlag
            Get
                Return Me.fixedQtyPerFlagField
            End Get
            Set
                Me.fixedQtyPerFlagField = value
            End Set
        End Property
        
        Public Property FixedQtyPer() As String
            Get
                Return Me.fixedQtyPerField
            End Get
            Set
                Me.fixedQtyPerField = value
            End Set
        End Property
        
        '''<summary>
        '''UnitCost indicates the unit cost of the allocation. For a non-stocked item the cost must be entered and be greater than zero. For a stocked item the cost will be calculated and this field will be ignored. The format is signed 10.5.
        '''</summary>
        Public Property UnitCost() As String
            Get
                Return Me.unitCostField
            End Get
            Set
                Me.unitCostField = value
            End Set
        End Property
        
        '''<summary>
        '''OperationOffset indicates either the operation number or the offset days for the allocation. If the operation flag has been set - this field may not be zero. If it is not 1 - the field will be validated against the job master operation number. Format is numeric 4.
        '''</summary>
        Public Property OperationOffset() As String
            Get
                Return Me.operationOffsetField
            End Get
            Set
                Me.operationOffsetField = value
            End Set
        End Property
        
        '''<summary>
        '''OpOffsetFlag indicates whether offset days or operation offset is used. (D - Offset Days, O - Operation Offset)
        '''</summary>
        Public Property OpOffsetFlag() As OpOffsetFlag
            Get
                Return Me.opOffsetFlagField
            End Get
            Set
                Me.opOffsetFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''Uom indicates the quantity unit of measure. For a non-stocked item this field must be supplied. The unit of measure will be retrieved from the inventory master for a stock item. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Uom() As String
            Get
                Return Me.uomField
            End Get
            Set
                Me.uomField = value
            End Set
        End Property
        
        '''<summary>
        '''SequenceNum is the seq number of the allocation. The format
        '''is 6 characters alphanumeric or 6 chararcters numeric depending on the configuration option within Bill of Materials setup.
        '''</summary>
        Public Property SequenceNum() As String
            Get
                Return Me.sequenceNumField
            End Get
            Set
                Me.sequenceNumField = value
            End Set
        End Property
        
        '''<summary>
        '''This element contains part of the unique key for the hierarchy. The job number will be used to complete the key.
        '''</summary>
        Public Property HierarchyJob() As HierarchyJob
            Get
                Return Me.hierarchyJobField
            End Get
            Set
                Me.hierarchyJobField = value
            End Set
        End Property
        
        '''<summary>
        '''Version indicates the ECC version number of the component part. Ignore if not an ECC controlled item, or if ECC controlled at a stocking level. The format is 3 characters alphanumeric or 3 chararcters numeric depending on the configuration option within Bill of Materials setup.
        '''</summary>
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        '''<summary>
        '''Release indicates the ECC release number of the component part. Ignore if not an ECC controlled item, or if ECC controlled at a stocking/revision level. The format is 3 characters alphanumeric or 3 chararcters numeric depending on the configuration option within Bill of Materials setup.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum NonStocked
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum QtyReqdType
        
        '''<remarks/>
        U
        
        '''<remarks/>
        T
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemFixedQtyPerFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OpOffsetFlag
        
        '''<remarks/>
        O
        
        '''<remarks/>
        D
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostMaterialAllocations
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemCollectionField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain an allocation. 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
        Public Property ItemCollection() As List(Of Item)
            Get
                If Me.itemCollectionField Is Nothing Then
                    Me.itemCollectionField = New List(Of Item)
                End If
                Return Me.itemCollectionField
            End Get
            Set(ByVal value As List(Of Item))
                Me.itemCollectionField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTJM"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
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
                Dim objParams As Params.PostMaterialAllocations
                objParams = New Params.PostMaterialAllocations
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
End Namespace
