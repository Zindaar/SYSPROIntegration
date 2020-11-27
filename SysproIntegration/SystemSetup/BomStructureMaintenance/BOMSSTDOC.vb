Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.BomStructureMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CreateSubJob
        
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
    Public Enum InclKitIssues
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InclScrapFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeBatch
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private comReleaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOnDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private structureOffDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagField As OpOffsetFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private opOffsetFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationOffsetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private qtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapPercentageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soOptionFlagField As SoOptionFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soOptionFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soPrintFlagField As SoPrintFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private soPrintFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclScrapFlagField As InclScrapFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclScrapFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reasonForChangeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclKitIssuesField As InclKitIssues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclKitIssuesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobField As CreateSubJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSubJobFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wetWeightPercentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchField As IncludeBatch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFromJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeToJobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerFlagField As FixedQtyPerFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedQtyPerFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rollUpCostField As RollUpCost
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private rollUpCostFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreFloorFlagField As IgnoreFloorFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreFloorFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomFlagField As UomFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private uomFlagFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.opOffsetFlagField = OpOffsetFlag.O
            Me.soOptionFlagField = SoOptionFlag.N
            Me.soPrintFlagField = SoPrintFlag.Y
            Me.inclScrapFlagField = InclScrapFlag.Y
            Me.inclKitIssuesField = InclKitIssues.Y
            Me.createSubJobField = CreateSubJob.N
            Me.fixedQtyPerFlagField = FixedQtyPerFlag.N
            Me.rollUpCostField = RollUpCost.Y
            Me.ignoreFloorFlagField = IgnoreFloorFlag.N
            Me.uomFlagField = UomFlag.S
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a bill of material structure record.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''ComVersion indicates major design changes made to the component (ComVersion). Note: this field will be ignored if the component is not ECC controlled at a revision or release level. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup. The field can have 3 dashes in it (---) indicating use current.
        '''</summary>
        Public Property ComVersion() As String
            Get
                Return Me.comVersionField
            End Get
            Set
                Me.comVersionField = value
            End Set
        End Property
        
        '''<summary>
        '''ComVersion indicates major design changes made to the component (ComVersion). Note: this field will be ignored if the component is not ECC controlled at a release level. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup. The field can have 3 dashes in it (---) indicating use current.
        '''</summary>
        Public Property ComRelease() As String
            Get
                Return Me.comReleaseField
            End Get
            Set
                Me.comReleaseField = value
            End Set
        End Property
        
        '''<summary>
        '''The StructureOnDate field is used to indicate when the component must become active in the structure. This field will be zero if structure on/off dates are not required (bill of materials setup) . The format is CCYY-MM-DD.
        '''</summary>
        Public Property StructureOnDate() As String
            Get
                Return Me.structureOnDateField
            End Get
            Set
                Me.structureOnDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The StructureOffDate field is used to indicate when the component must be de-activated from the structure. This field will be zero if structure on/off dates are not required (bill of materials setup) . The format is CCYY-MM-DD.
        '''</summary>
        Public Property StructureOffDate() As String
            Get
                Return Me.structureOffDateField
            End Get
            Set
                Me.structureOffDateField = value
            End Set
        End Property
        
        '''<summary>
        '''OpOffsetFlag indicates the usage of the OperationOffset field. The format is 1 character alphanumeric and can only be( 'O'- for an operation number or  'D'- for offset days).
        '''</summary>
        Public Property OpOffsetFlag() As OpOffsetFlag
            Get
                Return Me.opOffsetFlagField
            End Get
            Set
                Me.opOffsetFlagField = value
                Me.OpOffsetFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OpOffsetFlagSpecified() As Boolean
            Get
                Return Me.opOffsetFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''OperationOffset is dependent on the OpOffsetFlag. If 'O' this field wil indicate an operation number. If 'D' this field will indicate the number of offset days.The format is 3 characters numeric and can  be from 1 to 999 for operations. If you have selected an operation other than operation 1, it must be valid. 0 to 999 for offsetdays.
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
        '''QtyPer is used to indicate the quantity of the component stock code that is required to make one of the parent stock code. This relationship is based on the units of measure of the parent part and the component. If included in batch bills the quantity per is calculated and not entered. The number of decimals that can be entered (0 to 6) is determined by your entry at the Maximum number of decimals in quantity per option (Bill of Materials Setup). The format is 6.6 signed numeric.
        '''</summary>
        Public Property QtyPer() As String
            Get
                Return Me.qtyPerField
            End Get
            Set
                Me.qtyPerField = value
            End Set
        End Property
        
        '''<summary>
        '''The ScrapPercentage field is used to enter a percentage factor by which the quantity per must be increased, to take account of scrap. The format is 2.2 numeric positive.
        '''</summary>
        Public Property ScrapPercentage() As String
            Get
                Return Me.scrapPercentageField
            End Get
            Set
                Me.scrapPercentageField = value
            End Set
        End Property
        
        '''<summary>
        '''The ScrapQuantity field is used to increase the allocation quantity for this component, calculated at the time of creating a job. The format is 4.3 numeric positive.
        '''</summary>
        Public Property ScrapQuantity() As String
            Get
                Return Me.scrapQuantityField
            End Get
            Set
                Me.scrapQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''The SoOptionFlag option is used if you want to be able to make the decision at the time of order entry concerning whether to include the component on an order. Otherwise the component is regarded as mandatory and is inserted automatically into the sales order. This option will be ignored if you have not indicated that single level bill of materials are required (Sales Order Setup). The format is 1 character alphanumeric and can only be (N - No, Y - Yes).
        '''</summary>
        Public Property SoOptionFlag() As SoOptionFlag
            Get
                Return Me.soOptionFlagField
            End Get
            Set
                Me.soOptionFlagField = value
                Me.SoOptionFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SoOptionFlagSpecified() As Boolean
            Get
                Return Me.soOptionFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The SoPrintFlag option is used if you want component order lines to be printed on your order documents. You can override this option if the component is defined as optional. This option is ignored if you have not  indicated that single level bill of materials are required (Sales Order Setup). The format is 1 character (N - No, Y - Yes).
        '''</summary>
        Public Property SoPrintFlag() As SoPrintFlag
            Get
                Return Me.soPrintFlagField
            End Get
            Set
                Me.soPrintFlagField = value
                Me.SoPrintFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SoPrintFlagSpecified() As Boolean
            Get
                Return Me.soPrintFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''InclScrapFlag is a factory doc print flag to include any material or progressive scrap factor or % on any factory documentation and in kit issue.The format is 1 character alphanumeric and can only be (N - Nether, Y - Both, M - Material only, P - Progressive only).
        '''</summary>
        Public Property InclScrapFlag() As InclScrapFlag
            Get
                Return Me.inclScrapFlagField
            End Get
            Set
                Me.inclScrapFlagField = value
                Me.InclScrapFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InclScrapFlagSpecified() As Boolean
            Get
                Return Me.inclScrapFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''ReasonForChange is a field to indicate why the structure has changed. The format is alphanumeric 10.
        '''</summary>
        Public Property ReasonForChange() As String
            Get
                Return Me.reasonForChangeField
            End Get
            Set
                Me.reasonForChangeField = value
            End Set
        End Property
        
        '''<summary>
        '''InclKitIssues is used to include the component in the kit issue. The format is 1 character alphanumeric and can only be (N - No, Y - Yes).
        '''</summary>
        Public Property InclKitIssues() As InclKitIssues
            Get
                Return Me.inclKitIssuesField
            End Get
            Set
                Me.inclKitIssuesField = value
                Me.InclKitIssuesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InclKitIssuesSpecified() As Boolean
            Get
                Return Me.inclKitIssuesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The CreateSubJob flag is used to automatically create sub jobs for components which are subassemblies when creating a job. The parent part must be made-in, subcontracted, bought out or a phantom part. The component is made-in or subcontracted and is not a bulk issue or floorstock item. The format is 1 character alphanumeric and can only be (N - No, Y - Yes). 
        '''</summary>
        Public Property CreateSubJob() As CreateSubJob
            Get
                Return Me.createSubJobField
            End Get
            Set
                Me.createSubJobField = value
                Me.CreateSubJobFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CreateSubJobSpecified() As Boolean
            Get
                Return Me.createSubJobFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The WetWeightPercent is used to indicate the percentage of each component which accumulates to 100% for the batch. It is used with batch bills when the component is included in the batch bill calculation. The format is 2.2 signed numeric.
        '''</summary>
        Public Property WetWeightPercent() As String
            Get
                Return Me.wetWeightPercentField
            End Get
            Set
                Me.wetWeightPercentField = value
            End Set
        End Property
        
        '''<summary>
        '''IncludeBatch is used when a parent is a batch bill and the component is included in the batch bill calculation. The component has to have a specific gravity of greater than zero. The format is 1 character alphanumeric and can  be (N - No, Y - Yes) or spaces if not required.
        '''</summary>
        Public Property IncludeBatch() As IncludeBatch
            Get
                Return Me.includeBatchField
            End Get
            Set
                Me.includeBatchField = value
                Me.IncludeBatchFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBatchSpecified() As Boolean
            Get
                Return Me.includeBatchFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The include from job  is used when the Bill of Material setup option 'Component inclusion by job number' in Syspro is set on. It allows for the component to be included, excluded from the next job number used. This is the lowest limit of the component.The format is 8 characters alphanumeric or  8 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property IncludeFromJob() As String
            Get
                Return Me.includeFromJobField
            End Get
            Set
                Me.includeFromJobField = value
            End Set
        End Property
        
        '''<summary>
        '''The include to job  is used when the Bill of Material setup option 'Component inclusion by job number' in Syspro is set on. It allows for the component to be included, excluded from the next job number used. This is the highest limit of the component. The format is 8 characters alphanumeric or  8 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property IncludeToJob() As String
            Get
                Return Me.includeToJobField
            End Get
            Set
                Me.includeToJobField = value
            End Set
        End Property
        
        '''<summary>
        '''If the FixedQtyPer flag is set to yes, then this field indicates the parent per fixed qty 
        '''</summary>
        Public Property FixedQtyPer() As String
            Get
                Return Me.fixedQtyPerField
            End Get
            Set
                Me.fixedQtyPerField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates whether the quantity per is a one to one relationship between the component and the parent or the quantity per is for a grouping of parents (eg for every 10 parents apply the compoents qty per).  The format is 1 character alphanumeric (Y - Yes, N - No)
        '''</summary>
        Public Property FixedQtyPerFlag() As FixedQtyPerFlag
            Get
                Return Me.fixedQtyPerFlagField
            End Get
            Set
                Me.fixedQtyPerFlagField = value
                Me.FixedQtyPerFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FixedQtyPerFlagSpecified() As Boolean
            Get
                Return Me.fixedQtyPerFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the warehouse to use for this component. If left blank then the component's warehouse to use will be applied.
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
        '''The RollUpCost flag is used to indicate whether or not the costs from this component will be rolled up into the parent costs. The format is 1 character alphanumeric and can only be (N - No, Y - Yes). 
        '''</summary>
        Public Property RollUpCost() As RollUpCost
            Get
                Return Me.rollUpCostField
            End Get
            Set
                Me.rollUpCostField = value
                Me.RollUpCostFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property RollUpCostSpecified() As Boolean
            Get
                Return Me.rollUpCostFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The IgnoreFloorFlag flag is used to indicate whether or not processes, such as job creation ignore whether or not component is to  is flagged as a floorstock or bulk issue item. If set to Y then the component will be treated as a normal item. The format is 1 character alphanumeric and can only be (N - No, Y - Yes). 
        '''</summary>
        Public Property IgnoreFloorFlag() As IgnoreFloorFlag
            Get
                Return Me.ignoreFloorFlagField
            End Get
            Set
                Me.ignoreFloorFlagField = value
                Me.IgnoreFloorFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreFloorFlagSpecified() As Boolean
            Get
                Return Me.ignoreFloorFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The Manufacturing unit of measure flag is used to indicate which unit of measure the stock item is to use. Valid entries are S (stocking), O (other), A (alternate) or M (manufacturing).
        '''</summary>
        Public Property UomFlag() As UomFlag
            Get
                Return Me.uomFlagField
            End Get
            Set
                Me.uomFlagField = value
                Me.UomFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UomFlagSpecified() As Boolean
            Get
                Return Me.uomFlagFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        '''<summary>
        '''ParentPart indicates the parent of the components of the structure you are maintaining. The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
        '''<summary>
        '''Version indicates major design changes made to the parent (Version). Note: this field will be ignored if the component is not ECC controlled at a revision level. This field can only be the current revision which is reflected off the inventory master file in Syspro for the structure to be maintained. Another criteria is that there must be an engineering change order for the revision. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
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
        '''Release indicates major design changes made to the parent (Release). Note: this field will be ignored if the component is not ECC controlled at a revision or release level. This field can only be the current release which is reflected off the inventory master file in Syspro for the structure to be maintained. Another criteria is that there must be an engineering change order for the release.The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''The Route field is used only if you indicated that alternate routings are required (Bill of Materials Setup). This field enables you to select a specific routing for which you want to maintain structures, and is used for what-if purposes and within the Work in Progress module when creating a job and within the Engineering Change Control module for engineering change orders. The format is a 1 character alphanumeric field.
        '''</summary>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        '''<summary>
        '''The SequenceNum field is used to indicate the sequence number for the component in relation to the parent stock code. This field will be used if you have indicated that structure sequencing is required (Bill of Materials Setup). The format is 6 characters alphanumeric .
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
        '''Component is an item used in the process of creating a BOM for a parent part. The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within Syspro.
        '''</summary>
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
    End Class
    
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
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SoOptionFlag
        
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
    Public Enum SoPrintFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FixedQtyPerFlag
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum RollUpCost
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreFloorFlag
        
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
    Public Enum UomFlag
        
        '''<remarks/>
        S
        
        '''<remarks/>
        O
        
        '''<remarks/>
        A
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupBomStructure
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain a  bill of material structure record.. NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set
                Me._setupActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "BOMSST"
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
        
        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.XmlParam
            Get
                Dim objParams As Params.SetupBomStructure
                objParams = New Params.SetupBomStructure
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
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XMLParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
