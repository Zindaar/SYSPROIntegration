Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As Warehouse
        
        Public Sub New()
            MyBase.New
            If (Me.warehouseField Is Nothing) Then
                Me.warehouseField = New Warehouse
            End If
        End Sub
        
        '''<summary>
        '''List or Range of warehouses separated by commas.
        '''</summary>
        Public Property Warehouse() As Warehouse
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Warehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As WarehouseFilterType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As WarehouseFilterType
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
                Me.FilterTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property FilterTypeSpecified() As Boolean
            Get
                Return Me.filterTypeFieldSpecified
            End Get
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
    Public Enum WarehouseFilterType
        
        '''<remarks/>
        R
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeCustomForms
        
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
    Public Enum IncludeBins
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Z
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeHistory
        
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
    Public Enum IncludeLots
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Z
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeMovementAdjustments
        
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
    Public Enum IncludeMovementBinTransfers
        
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
    Public Enum IncludeMovementCostChanges
        
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
    Public Enum IncludeMovementCostMods
        
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
    Public Enum IncludeMovementCreditNotes
        
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
    Public Enum IncludeMovementDebitNotes
        
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
    Public Enum IncludeMovementDispatchNotes
        
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
    Public Enum IncludeMovementInvoices
        
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
    Public Enum IncludeMovementIssues
        
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
    Public Enum IncludeMovementPhysical
        
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
    Public Enum IncludeMovementReceipts
        
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
    Public Enum IncludeEcc
        
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
    Public Enum IncludeMovements
        
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
    Public Enum IncludeMovementTransfers
        
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
    Public Enum IncludeSerials
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Z
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        '''<summary>
        '''The stock code to use for the query
        '''</summary>
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MovementDateSequence
        
        '''<remarks/>
        A
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiMediaImageTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeHistoryField As IncludeHistory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeHistoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBinsField As IncludeBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBinsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsField As IncludeLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialsField As IncludeSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementsField As IncludeMovements
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementDateSequenceField As MovementDateSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementDateSequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementStartDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private movementStartDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maxNumberMovementsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As IncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementIssuesField As IncludeMovementIssues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementIssuesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementTransfersField As IncludeMovementTransfers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementTransfersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementReceiptsField As IncludeMovementReceipts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementReceiptsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementPhysicalField As IncludeMovementPhysical
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementPhysicalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementAdjustmentsField As IncludeMovementAdjustments
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementAdjustmentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCostChangesField As IncludeMovementCostChanges
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCostChangesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCostModsField As IncludeMovementCostMods
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCostModsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementBinTransfersField As IncludeMovementBinTransfers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementBinTransfersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementInvoicesField As IncludeMovementInvoices
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementInvoicesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCreditNotesField As IncludeMovementCreditNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementCreditNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementDebitNotesField As IncludeMovementDebitNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementDebitNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementDispatchNotesField As IncludeMovementDispatchNotes
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMovementDispatchNotesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeEccField As IncludeEcc
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeEccFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApprovedManufField As IncludeApprovedManuf
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApprovedManufFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeHistoryField = IncludeHistory.Y
            Me.includeBinsField = IncludeBins.N
            Me.includeLotsField = IncludeLots.N
            Me.includeSerialsField = IncludeSerials.N
            Me.includeMovementsField = IncludeMovements.N
            Me.movementDateSequenceField = MovementDateSequence.A
            Me.includeCustomFormsField = IncludeCustomForms.N
            Me.includeMovementIssuesField = IncludeMovementIssues.Y
            Me.includeMovementTransfersField = IncludeMovementTransfers.Y
            Me.includeMovementReceiptsField = IncludeMovementReceipts.Y
            Me.includeMovementPhysicalField = IncludeMovementPhysical.Y
            Me.includeMovementAdjustmentsField = IncludeMovementAdjustments.Y
            Me.includeMovementCostChangesField = IncludeMovementCostChanges.Y
            Me.includeMovementCostModsField = IncludeMovementCostMods.Y
            Me.includeMovementBinTransfersField = IncludeMovementBinTransfers.Y
            Me.includeMovementInvoicesField = IncludeMovementInvoices.Y
            Me.includeMovementCreditNotesField = IncludeMovementCreditNotes.Y
            Me.includeMovementDebitNotesField = IncludeMovementDebitNotes.Y
            Me.includeMovementDispatchNotesField = IncludeMovementDispatchNotes.Y
            Me.includeEccField = IncludeEcc.Y
            Me.includeApprovedManufField = IncludeApprovedManuf.Y
        End Sub
        
        '''<summary>
        '''Image type to retrieve (for example: GIF, JPG)
        '''</summary>
        Public Property MultiMediaImageType() As String
            Get
                Return Me.multiMediaImageTypeField
            End Get
            Set
                Me.multiMediaImageTypeField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include history ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeHistory() As IncludeHistory
            Get
                Return Me.includeHistoryField
            End Get
            Set
                Me.includeHistoryField = value
                Me.IncludeHistoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeHistorySpecified() As Boolean
            Get
                Return Me.includeHistoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include multiple bins ? (N - No, Y - Yes Z - Include zero qty on hand bins)
        '''</summary>
        Public Property IncludeBins() As IncludeBins
            Get
                Return Me.includeBinsField
            End Get
            Set
                Me.includeBinsField = value
                Me.IncludeBinsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBinsSpecified() As Boolean
            Get
                Return Me.includeBinsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include lots ? (N - No, Y - Yes, Z - Include zero qty on hand lots)
        '''</summary>
        Public Property IncludeLots() As IncludeLots
            Get
                Return Me.includeLotsField
            End Get
            Set
                Me.includeLotsField = value
                Me.IncludeLotsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeLotsSpecified() As Boolean
            Get
                Return Me.includeLotsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include serial numbers ? (N - No, Y - Yes, Z=Include zero qty on hand serials)
        '''</summary>
        Public Property IncludeSerials() As IncludeSerials
            Get
                Return Me.includeSerialsField
            End Get
            Set
                Me.includeSerialsField = value
                Me.IncludeSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeSerialsSpecified() As Boolean
            Get
                Return Me.includeSerialsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include movements ? (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeMovements() As IncludeMovements
            Get
                Return Me.includeMovementsField
            End Get
            Set
                Me.includeMovementsField = value
                Me.IncludeMovementsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementsSpecified() As Boolean
            Get
                Return Me.includeMovementsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The sequence of the returned records (A - Ascending date sequence, D - Descending date sequence)
        '''</summary>
        Public Property MovementDateSequence() As MovementDateSequence
            Get
                Return Me.movementDateSequenceField
            End Get
            Set
                Me.movementDateSequenceField = value
                Me.MovementDateSequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MovementDateSequenceSpecified() As Boolean
            Get
                Return Me.movementDateSequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The date from which to extract movements
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property MovementStartDate() As Date
            Get
                Return Me.movementStartDateField
            End Get
            Set
                Me.movementStartDateField = value
                Me.MovementStartDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MovementStartDateSpecified() As Boolean
            Get
                Return Me.movementStartDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The maximum number of Movement entries to return (enter a value between 0 and 99999999 where 0 / blank returns all records)
        '''</summary>
        Public Property MaxNumberMovements() As String
            Get
                Return Me.maxNumberMovementsField
            End Get
            Set
                Me.maxNumberMovementsField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include fields from custom forms ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeCustomForms() As IncludeCustomForms
            Get
                Return Me.includeCustomFormsField
            End Get
            Set
                Me.includeCustomFormsField = value
                Me.IncludeCustomFormsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCustomFormsSpecified() As Boolean
            Get
                Return Me.includeCustomFormsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include issue movements ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementIssues() As IncludeMovementIssues
            Get
                Return Me.includeMovementIssuesField
            End Get
            Set
                Me.includeMovementIssuesField = value
                Me.IncludeMovementIssuesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementIssuesSpecified() As Boolean
            Get
                Return Me.includeMovementIssuesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include transfer movements ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementTransfers() As IncludeMovementTransfers
            Get
                Return Me.includeMovementTransfersField
            End Get
            Set
                Me.includeMovementTransfersField = value
                Me.IncludeMovementTransfersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementTransfersSpecified() As Boolean
            Get
                Return Me.includeMovementTransfersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include receipt movements ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementReceipts() As IncludeMovementReceipts
            Get
                Return Me.includeMovementReceiptsField
            End Get
            Set
                Me.includeMovementReceiptsField = value
                Me.IncludeMovementReceiptsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementReceiptsSpecified() As Boolean
            Get
                Return Me.includeMovementReceiptsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include physical movements ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementPhysical() As IncludeMovementPhysical
            Get
                Return Me.includeMovementPhysicalField
            End Get
            Set
                Me.includeMovementPhysicalField = value
                Me.IncludeMovementPhysicalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementPhysicalSpecified() As Boolean
            Get
                Return Me.includeMovementPhysicalFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include adjustments ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementAdjustments() As IncludeMovementAdjustments
            Get
                Return Me.includeMovementAdjustmentsField
            End Get
            Set
                Me.includeMovementAdjustmentsField = value
                Me.IncludeMovementAdjustmentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementAdjustmentsSpecified() As Boolean
            Get
                Return Me.includeMovementAdjustmentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include cost changes ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementCostChanges() As IncludeMovementCostChanges
            Get
                Return Me.includeMovementCostChangesField
            End Get
            Set
                Me.includeMovementCostChangesField = value
                Me.IncludeMovementCostChangesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementCostChangesSpecified() As Boolean
            Get
                Return Me.includeMovementCostChangesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include cost modifications ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementCostMods() As IncludeMovementCostMods
            Get
                Return Me.includeMovementCostModsField
            End Get
            Set
                Me.includeMovementCostModsField = value
                Me.IncludeMovementCostModsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementCostModsSpecified() As Boolean
            Get
                Return Me.includeMovementCostModsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include bin transfers ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementBinTransfers() As IncludeMovementBinTransfers
            Get
                Return Me.includeMovementBinTransfersField
            End Get
            Set
                Me.includeMovementBinTransfersField = value
                Me.IncludeMovementBinTransfersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementBinTransfersSpecified() As Boolean
            Get
                Return Me.includeMovementBinTransfersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include invoice movements? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementInvoices() As IncludeMovementInvoices
            Get
                Return Me.includeMovementInvoicesField
            End Get
            Set
                Me.includeMovementInvoicesField = value
                Me.IncludeMovementInvoicesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementInvoicesSpecified() As Boolean
            Get
                Return Me.includeMovementInvoicesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include credit notes ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementCreditNotes() As IncludeMovementCreditNotes
            Get
                Return Me.includeMovementCreditNotesField
            End Get
            Set
                Me.includeMovementCreditNotesField = value
                Me.IncludeMovementCreditNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementCreditNotesSpecified() As Boolean
            Get
                Return Me.includeMovementCreditNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include debit note movements ? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementDebitNotes() As IncludeMovementDebitNotes
            Get
                Return Me.includeMovementDebitNotesField
            End Get
            Set
                Me.includeMovementDebitNotesField = value
                Me.IncludeMovementDebitNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementDebitNotesSpecified() As Boolean
            Get
                Return Me.includeMovementDebitNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include dispatch note movements? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeMovementDispatchNotes() As IncludeMovementDispatchNotes
            Get
                Return Me.includeMovementDispatchNotesField
            End Get
            Set
                Me.includeMovementDispatchNotesField = value
                Me.IncludeMovementDispatchNotesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMovementDispatchNotesSpecified() As Boolean
            Get
                Return Me.includeMovementDispatchNotesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include ECC ? (Y - Yes, N - No). The default is Y.
        '''</summary>
        Public Property IncludeEcc() As IncludeEcc
            Get
                Return Me.includeEccField
            End Get
            Set
                Me.includeEccField = value
                Me.IncludeEccFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeEccSpecified() As Boolean
            Get
                Return Me.includeEccFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include a list of approved manufacturers for this stock code? (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeApprovedManuf() As IncludeApprovedManuf
            Get
                Return Me.includeApprovedManufField
            End Get
            Set
                Me.includeApprovedManufField = value
                Me.IncludeApprovedManufFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeApprovedManufSpecified() As Boolean
            Get
                Return Me.includeApprovedManufFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied
        '''</summary>
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeApprovedManuf
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
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
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New Filter
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''The key to use for this query.
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
        '''The list of options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Property Filter() As Filter
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
                Return "INVQRY"
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
End Namespace
