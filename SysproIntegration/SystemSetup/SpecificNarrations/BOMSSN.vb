Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.SpecificNarrations.Params
    
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
        Private narrationField As String
        
        Public Sub New()
            MyBase.New
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a narration.
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
        '''Narration is the text to be added as notes.  It can be 2700 alphanumeric characters which equals 60 lines by 45 characters. 
        '''</summary>
        Public Property Narration() As String
            Get
                Return Me.narrationField
            End Get
            Set
                Me.narrationField = value
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        '''<summary>
        '''This element contains the source that the narration is to be added to. 
        '''JOB - the narration is to be setup for a job.
        '''The key for JOB is JobNumber. 
        '''WIPMATERIAL - the narration is to be setup for WIP material.
        '''The key is JobNumber, Component, Warehouse, Line
        '''WIPLABOUR - the narration is to be setup for WIP labor.
        '''The key  is JobNumber, Operation.
        '''BOMSTRUCTURE - the narration is to be setup for BOM structure .  
        '''The key  is ParentPart, Version, Release, Route, Sequence, Component.
        '''BOMOPERATION - the narration is to be setup for BOM operations.
        '''The key is Stock code (must be entered in the ParentPart of the xmlin)
        '''Version, Release, Route, Operation.
        '''ESTSTRUCTURE - the narration is to be setup for estimates structure . 
        '''The key is ParentPart, Route, SequenceNum, Component.
        '''ESTOPERATION - the narration is to be setup for estimates operations.   
        '''The key is Stock code (must be entered in the ParentPart of the xmlin)
        ''', Route, Operation.
        '''
        '''</summary>
        Public Property Source() As String
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = value
            End Set
        End Property
        
        '''<summary>
        '''JobNumber is an item used as part of the key in the process of creating and updating a narration in WIP labor, WIP material and Job. The format is 8 characters alphanumeric or numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property JobNumber() As String
            Get
                Return Me.jobNumberField
            End Get
            Set
                Me.jobNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''ParentPart indicates the parent of the components of the structure you are maintaining.  ParentPart is used as part of the key to update or create a narration in Estimates operation, Estimates structure, BOM operation and BOM structure. The format is 30 characters alphanumeric or 15 characters numeric depending on the configuration option within SYSPRO.
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
        '''Version indicates major design changes made to the parent (Version). Note: this field will be ignored if the component is not ECC controlled at a Version level. This field can only be the current version which is reflected off the inventory master file in SYSPRO for the structure to be maintained. Another criteria is that there must be an engineering change order for the version.  Version is used as part of the key to create or update a narration in BOM operation and BOM structure. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
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
        '''Release indicates major design changes made to the parent (Release). Note: this field will be ignored if the component is not ECC controlled at a version or release level. This field can only be the current release which is reflected off the inventory master file in SYSPRO for the structure to be maintained. Another criteria is that there must be an engineering change order for the release.  Release is used as part of the key to create or update a narration in BOM operation, and BOM structure. The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
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
        '''Component is an item used as part of the key in the process of creating and updating a narration in BOM structure and Estimate structure. The format is 30 characters alphanumeric or 15 characters numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        '''<summary>
        '''The Route field is used only if you indicated that alternate routings are required (Bill of Materials Setup). The route field is used as part of the key when you want to create or update a narration in Estimates operations, Estimates structure, BOM operation and BOM structure. The format is a 1 character alphanumeric field.
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
        '''Operation is an item used as part of the key in the process of creating and updating a narration in BOM operation, Estimate operation and WIP labor. The format is 4 numeric characters.
        '''</summary>
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        '''<summary>
        '''The SequenceNum field is used to indicate the sequence number for the component in relation to the parent stock code. This field will be used if you have indicated that structure sequencing is required (Bill of Materials Setup). SequenceNum is used as part of the key to create or update a narration in estimates structure and BOM structure. The format is 6 characters alphanumeric .
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
        '''Warehouse is an item used as part of the key in the process of creating and updating a narration in  WIP material.  It is the warehouse that the component uses. The format is 2 alphanumeric characters.
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
        '''Line is an item used as part of the key in the process of creating and updating a narration in WIP material. The format is 2 alphanumeric  characters.
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
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
    Partial Public Class SetupBomNarration
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New Item
            End If
        End Sub
        
        '''<summary>
        '''This element contains information to maintain a narration.
        '''</summary>
        Public Property Item() As Item
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
End Namespace
