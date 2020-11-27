Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryQuery.WipQuery.QueryData
    
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
    Public Enum IncludeOperationsCustomForm
        
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
    Public Enum IncludeMaterialsCustomForm
        
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
    Public Enum IncludeIcons
        
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
    Public Enum IncludeJobNarrations
        
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
    Public Enum IncludeMaterialAllocations
        
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
    Public Enum IncludeMaterialBins
        
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
    Public Enum IncludeMaterialNarrations
        
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
    Public Enum IncludeMaterialSerials
        
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
    Public Enum IncludeMaterialTransactions
        
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
    Public Enum IncludeOperationAllocations
        
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
    Public Enum IncludeOperationNarrations
        
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
    Public Enum IncludeOperationTransactions
        
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
    Public Enum IncludePartBooked
        
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
    Public Enum IncludePurchaseOrders
        
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        '''<summary>
        '''The job to use for the query
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multiMediaImageTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsField As IncludeCustomForms
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCustomFormsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeIconsField As IncludeIcons
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeIconsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobNarrationsField As IncludeJobNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeJobNarrationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialAllocationsField As IncludeMaterialAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialAllocationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialNarrationsField As IncludeMaterialNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialNarrationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialTransactionsField As IncludeMaterialTransactions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialTransactionsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialBinsField As IncludeMaterialBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialBinsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialSerialsField As IncludeMaterialSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrdersField As IncludePurchaseOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrdersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationAllocationsField As IncludeOperationAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationAllocationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationNarrationsField As IncludeOperationNarrations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationNarrationsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationTransactionsField As IncludeOperationTransactions
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationTransactionsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePartBookedField As IncludePartBooked
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePartBookedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReservedLotsField As OptionIncludeReservedLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReservedSerialsField As OptionIncludeReservedSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialReservedLotsField As OptionIncludeMaterialReservedLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialReservedSerialsField As OptionIncludeMaterialReservedSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCoProductsField As OptionIncludeCoProducts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationsCustomFormField As IncludeOperationsCustomForm
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOperationsCustomFormFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialsCustomFormField As IncludeMaterialsCustomForm
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeMaterialsCustomFormFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeCustomFormsField = IncludeCustomForms.N
            Me.includeIconsField = IncludeIcons.N
            Me.includeJobNarrationsField = IncludeJobNarrations.N
            Me.includeMaterialAllocationsField = IncludeMaterialAllocations.N
            Me.includeMaterialNarrationsField = IncludeMaterialNarrations.N
            Me.includeMaterialTransactionsField = IncludeMaterialTransactions.N
            Me.includeMaterialBinsField = IncludeMaterialBins.N
            Me.includeMaterialSerialsField = IncludeMaterialSerials.N
            Me.includePurchaseOrdersField = IncludePurchaseOrders.N
            Me.includeOperationAllocationsField = IncludeOperationAllocations.N
            Me.includeOperationNarrationsField = IncludeOperationNarrations.N
            Me.includeOperationTransactionsField = IncludeOperationTransactions.N
            Me.includePartBookedField = IncludePartBooked.N
            Me.includeReservedLotsField = OptionIncludeReservedLots.N
            Me.includeReservedSerialsField = OptionIncludeReservedSerials.N
            Me.includeMaterialReservedLotsField = OptionIncludeMaterialReservedLots.N
            Me.includeMaterialReservedSerialsField = OptionIncludeMaterialReservedSerials.N
            Me.includeCoProductsField = OptionIncludeCoProducts.N
            Me.includeOperationsCustomFormField = IncludeOperationsCustomForm.N
            Me.includeMaterialsCustomFormField = IncludeMaterialsCustomForm.N
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
        '''Do you wish to attach icons against material and labor allocations ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeIcons() As IncludeIcons
            Get
                Return Me.includeIconsField
            End Get
            Set
                Me.includeIconsField = value
                Me.IncludeIconsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeIconsSpecified() As Boolean
            Get
                Return Me.includeIconsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include narrations attached to the job header ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeJobNarrations() As IncludeJobNarrations
            Get
                Return Me.includeJobNarrationsField
            End Get
            Set
                Me.includeJobNarrationsField = value
                Me.IncludeJobNarrationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeJobNarrationsSpecified() As Boolean
            Get
                Return Me.includeJobNarrationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include material allocations attached to the job ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeMaterialAllocations() As IncludeMaterialAllocations
            Get
                Return Me.includeMaterialAllocationsField
            End Get
            Set
                Me.includeMaterialAllocationsField = value
                Me.IncludeMaterialAllocationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialAllocationsSpecified() As Boolean
            Get
                Return Me.includeMaterialAllocationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include narrations attached to the material allocations ? (N - No, Y - Yes). This flag is ignored if material allocations are excluded (IncludeMaterialAllocations = N)
        '''</summary>
        Public Property IncludeMaterialNarrations() As IncludeMaterialNarrations
            Get
                Return Me.includeMaterialNarrationsField
            End Get
            Set
                Me.includeMaterialNarrationsField = value
                Me.IncludeMaterialNarrationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialNarrationsSpecified() As Boolean
            Get
                Return Me.includeMaterialNarrationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include transactions posted against the material allocations  ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeMaterialTransactions() As IncludeMaterialTransactions
            Get
                Return Me.includeMaterialTransactionsField
            End Get
            Set
                Me.includeMaterialTransactionsField = value
                Me.IncludeMaterialTransactionsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialTransactionsSpecified() As Boolean
            Get
                Return Me.includeMaterialTransactionsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include multiple bins against the material transactions  ? (N - No, Y - Yes). This flag is ignored if material transactions are excluded (IncludeMaterialTransactions = N)
        '''</summary>
        Public Property IncludeMaterialBins() As IncludeMaterialBins
            Get
                Return Me.includeMaterialBinsField
            End Get
            Set
                Me.includeMaterialBinsField = value
                Me.IncludeMaterialBinsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialBinsSpecified() As Boolean
            Get
                Return Me.includeMaterialBinsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include serial numbers against the material transactions  ? (N - No, Y - Yes). This flag is ignored if material transactions are excluded (IncludeMaterialTransactions = N)
        '''</summary>
        Public Property IncludeMaterialSerials() As IncludeMaterialSerials
            Get
                Return Me.includeMaterialSerialsField
            End Get
            Set
                Me.includeMaterialSerialsField = value
                Me.IncludeMaterialSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialSerialsSpecified() As Boolean
            Get
                Return Me.includeMaterialSerialsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include purchase orders raised against the material allocations  ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludePurchaseOrders() As IncludePurchaseOrders
            Get
                Return Me.includePurchaseOrdersField
            End Get
            Set
                Me.includePurchaseOrdersField = value
                Me.IncludePurchaseOrdersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludePurchaseOrdersSpecified() As Boolean
            Get
                Return Me.includePurchaseOrdersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include labor allocations attached to the job ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeOperationAllocations() As IncludeOperationAllocations
            Get
                Return Me.includeOperationAllocationsField
            End Get
            Set
                Me.includeOperationAllocationsField = value
                Me.IncludeOperationAllocationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeOperationAllocationsSpecified() As Boolean
            Get
                Return Me.includeOperationAllocationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include narrations attached to the labor allocations ? (N - No, Y - Yes). This flag is ignored if labor allocations are excluded (IncludeOperationAllocations = N)
        '''</summary>
        Public Property IncludeOperationNarrations() As IncludeOperationNarrations
            Get
                Return Me.includeOperationNarrationsField
            End Get
            Set
                Me.includeOperationNarrationsField = value
                Me.IncludeOperationNarrationsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeOperationNarrationsSpecified() As Boolean
            Get
                Return Me.includeOperationNarrationsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include transactions posted against the labor allocations  ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeOperationTransactions() As IncludeOperationTransactions
            Get
                Return Me.includeOperationTransactionsField
            End Get
            Set
                Me.includeOperationTransactionsField = value
                Me.IncludeOperationTransactionsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeOperationTransactionsSpecified() As Boolean
            Get
                Return Me.includeOperationTransactionsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include part bookings attached to the job ? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludePartBooked() As IncludePartBooked
            Get
                Return Me.includePartBookedField
            End Get
            Set
                Me.includePartBookedField = value
                Me.IncludePartBookedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludePartBookedSpecified() As Boolean
            Get
                Return Me.includePartBookedFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIncludeReservedLots.N)>  _
        Public Property IncludeReservedLots() As OptionIncludeReservedLots
            Get
                Return Me.includeReservedLotsField
            End Get
            Set
                Me.includeReservedLotsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIncludeReservedSerials.N)>  _
        Public Property IncludeReservedSerials() As OptionIncludeReservedSerials
            Get
                Return Me.includeReservedSerialsField
            End Get
            Set
                Me.includeReservedSerialsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIncludeMaterialReservedLots.N)>  _
        Public Property IncludeMaterialReservedLots() As OptionIncludeMaterialReservedLots
            Get
                Return Me.includeMaterialReservedLotsField
            End Get
            Set
                Me.includeMaterialReservedLotsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIncludeMaterialReservedSerials.N)>  _
        Public Property IncludeMaterialReservedSerials() As OptionIncludeMaterialReservedSerials
            Get
                Return Me.includeMaterialReservedSerialsField
            End Get
            Set
                Me.includeMaterialReservedSerialsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIncludeCoProducts.N)>  _
        Public Property IncludeCoProducts() As OptionIncludeCoProducts
            Get
                Return Me.includeCoProductsField
            End Get
            Set
                Me.includeCoProductsField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include field custom forms for operations? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeOperationsCustomForm() As IncludeOperationsCustomForm
            Get
                Return Me.includeOperationsCustomFormField
            End Get
            Set
                Me.includeOperationsCustomFormField = value
                Me.IncludeOperationsCustomFormFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeOperationsCustomFormSpecified() As Boolean
            Get
                Return Me.includeOperationsCustomFormFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to include field custom forms for materials? (N - No, Y - Yes,)
        '''</summary>
        Public Property IncludeMaterialsCustomForm() As IncludeMaterialsCustomForm
            Get
                Return Me.includeMaterialsCustomFormField
            End Get
            Set
                Me.includeMaterialsCustomFormField = value
                Me.IncludeMaterialsCustomFormFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeMaterialsCustomFormSpecified() As Boolean
            Get
                Return Me.includeMaterialsCustomFormFieldSpecified
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeReservedLots
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeReservedSerials
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeMaterialReservedLots
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeMaterialReservedSerials
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeCoProducts
        
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
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


        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                Me._queryActionTypeField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "WIPQRY"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
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
