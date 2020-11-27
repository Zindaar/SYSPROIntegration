Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WorkInProgress.WipShopFloorDataCollection.WipLaborPosting.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private journalField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemTransactionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As ItemUnitOfMeasure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lOperationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lWorkCentreField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lWcRateIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lEmployeeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lMachineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lRunTimeHoursField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lSetUpHoursField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lStartupHoursField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lTeardownHoursField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualWorkCenterRatesField As ManualWorkCenterRates
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualWorkCenterRatesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualRatesField As List(Of ManualRates)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonProductiveCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private additionalReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multipleScrapEntriesField As ItemMultipleScrapEntries
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scrapCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multipleScrapField As List(Of ItemMultipleScrap)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductScrapField As List(Of ItemCoProductScrap)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lQtyCompleteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lQtyScrappedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesCompletedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operCompletedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lEmployeeRatIndField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subcontractValueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private esignatureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reservedLotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reservedSerialsField As List(Of ItemReservedSerials)
        
        Public Sub New()
            MyBase.New
            Me.unitOfMeasureField = ItemUnitOfMeasure.S
            Me.manualWorkCenterRatesField = ManualWorkCenterRates.N
            Me.multipleScrapEntriesField = ItemMultipleScrapEntries.N
            If (Me.reservedSerialsField Is Nothing) Then
                Me.reservedSerialsField = New List(Of ItemReservedSerials)()
            End If
            If (Me.coProductScrapField Is Nothing) Then
                Me.coProductScrapField = New List(Of ItemCoProductScrap)()
            End If
            If (Me.multipleScrapField Is Nothing) Then
                Me.multipleScrapField = New List(Of ItemMultipleScrap)()
            End If
            If (Me.manualRatesField Is Nothing) Then
                Me.manualRatesField = New List(Of ManualRates)()
            End If
        End Sub
        
        '''<summary>
        '''This is the journal number to which the transaction journal entries generated will be added. It must be valid for the specified posting period and  may not have been printed already. If not supplied, a new journal will be created.
        '''</summary>
        Public Property Journal() As String
            Get
                Return Me.journalField
            End Get
            Set
                Me.journalField = value
            End Set
        End Property
        
        '''<summary>
        '''Date transaction raised. If the transaction date is entered at this point, the date supplied in the parameters will be overwritten.
        '''</summary>
        Public Property ItemTransactionDate() As String
            Get
                Return Me.itemTransactionDateField
            End Get
            Set
                Me.itemTransactionDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Time transaction raised. This will default to current system time if no time is specified in this elememt
        '''</summary>
        Public Property TransactionTime() As String
            Get
                Return Me.transactionTimeField
            End Get
            Set
                Me.transactionTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional. It specifies the job to which the labor is being posted to. If this is blank then a valid Non-productive code must be entered. The format is alphanumeric or numeric depending on the configuration option within SYSPRO. 
        '''</summary>
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property UnitOfMeasure() As ItemUnitOfMeasure
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the operation to which postings are to be made. If no operation is passed and all the existing operations are complete then a new (dummy) operation using the next operation number will be created. If all operatinos are not complete, then an operation number must be passed.
        '''</summary>
        Public Property LOperation() As String
            Get
                Return Me.lOperationField
            End Get
            Set
                Me.lOperationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the work center. If warnings are being ignored and the work center is spaces, it defaults to the operation work center.
        '''</summary>
        Public Property LWorkCentre() As String
            Get
                Return Me.lWorkCentreField
            End Get
            Set
                Me.lWorkCentreField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the work center rate to be used.
        '''</summary>
        Public Property LWcRateInd() As String
            Get
                Return Me.lWcRateIndField
            End Get
            Set
                Me.lWcRateIndField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if the option in WIP setup to validate employee during labor posting is set on or if the work center uses employee rate.  It indicates the employee against whom postings are being made.
        '''</summary>
        Public Property LEmployee() As String
            Get
                Return Me.lEmployeeField
            End Get
            Set
                Me.lEmployeeField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if the option in WIP setup to validate machine code during labor posting is set on. It indicates the machine against which postings are to be made.
        '''</summary>
        Public Property LMachine() As String
            Get
                Return Me.lMachineField
            End Get
            Set
                Me.lMachineField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies  the run time you are going to be posting.
        '''</summary>
        Public Property LRunTimeHours() As String
            Get
                Return Me.lRunTimeHoursField
            End Get
            Set
                Me.lRunTimeHoursField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the setup time you are going to be posting.
        '''</summary>
        Public Property LSetUpHours() As String
            Get
                Return Me.lSetUpHoursField
            End Get
            Set
                Me.lSetUpHoursField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the startup time you are going to be posting.
        '''</summary>
        Public Property LStartupHours() As String
            Get
                Return Me.lStartupHoursField
            End Get
            Set
                Me.lStartupHoursField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the teardown time you are going to be posting.
        '''</summary>
        Public Property LTeardownHours() As String
            Get
                Return Me.lTeardownHoursField
            End Get
            Set
                Me.lTeardownHoursField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies whether you are entering manual work center rates. If set to 'Y' then the entered rates will override the rates of the selected work center: Y -Yes, N - No (default - N).
        '''</summary>
        Public Property ManualWorkCenterRates() As ManualWorkCenterRates
            Get
                Return Me.manualWorkCenterRatesField
            End Get
            Set
                Me.manualWorkCenterRatesField = value
                Me.ManualWorkCenterRatesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ManualWorkCenterRatesSpecified() As Boolean
            Get
                Return Me.manualWorkCenterRatesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the group where you specify the rates that will override those of the selected work center. They will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("ManualRates")>  _
        Public Property ManualRatesCollection() As List(Of ManualRates)
            Get
                Return Me.manualRatesField
            End Get
            Set
                Me.manualRatesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the non-productive code to which non-productive time is posted. If the job is spaces then this field is mandatory as non-productive time is being posted.
        '''</summary>
        Public Property NonProductiveCode() As String
            Get
                Return Me.nonProductiveCodeField
            End Get
            Set
                Me.nonProductiveCodeField = value
            End Set
        End Property
        
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        Public Property AdditionalReference() As String
            Get
                Return Me.additionalReferenceField
            End Get
            Set
                Me.additionalReferenceField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ItemMultipleScrapEntries.N)>  _
        Public Property MultipleScrapEntries() As ItemMultipleScrapEntries
            Get
                Return Me.multipleScrapEntriesField
            End Get
            Set
                Me.multipleScrapEntriesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if a scrapped qty has been entered and you are not using multiple scrap entries.
        '''</summary>
        Public Property ScrapCode() As String
            Get
                Return Me.scrapCodeField
            End Get
            Set
                Me.scrapCodeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("MultipleScrap")>  _
        Public Property MultipleScrapCollection() As List(Of ItemMultipleScrap)
            Get
                Return Me.multipleScrapField
            End Get
            Set
                Me.multipleScrapField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CoProductScrap")>  _
        Public Property CoProductScrapCollection() As List(Of ItemCoProductScrap)
            Get
                Return Me.coProductScrapField
            End Get
            Set
                Me.coProductScrapField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the qty complete for this operation.
        '''</summary>
        Public Property LQtyComplete() As String
            Get
                Return Me.lQtyCompleteField
            End Get
            Set
                Me.lQtyCompleteField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the total quantity scrapped for this operation.
        '''</summary>
        Public Property LQtyScrapped() As String
            Get
                Return Me.lQtyScrappedField
            End Get
            Set
                Me.lQtyScrappedField = value
            End Set
        End Property
        
        '''<summary>
        '''This element  specifies the number of pieces completed for this operation.
        '''</summary>
        Public Property PiecesCompleted() As String
            Get
                Return Me.piecesCompletedField
            End Get
            Set
                Me.piecesCompletedField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if posting to a job and specifies whether the operation is complete. Y - Yes, N - No.
        '''</summary>
        Public Property OperCompleted() As String
            Get
                Return Me.operCompletedField
            End Get
            Set
                Me.operCompletedField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the employee rate to be used.
        '''</summary>
        Public Property LEmployeeRatInd() As String
            Get
                Return Me.lEmployeeRatIndField
            End Get
            Set
                Me.lEmployeeRatIndField = value
            End Set
        End Property
        
        '''<summary>
        ''' This is the subcontract value if the work center is a subcontracted work center.
        '''</summary>
        Public Property SubcontractValue() As String
            Get
                Return Me.subcontractValueField
            End Get
            Set
                Me.subcontractValueField = value
            End Set
        End Property
        
        Public Property Esignature() As String
            Get
                Return Me.esignatureField
            End Get
            Set
                Me.esignatureField = value
            End Set
        End Property
        
        Public Property ReservedLot() As String
            Get
                Return Me.reservedLotField
            End Get
            Set
                Me.reservedLotField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ReservedSerials")>  _
        Public Property ReservedSerialsCollection() As List(Of ItemReservedSerials)
            Get
                Return Me.reservedSerialsField
            End Get
            Set
                Me.reservedSerialsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemUnitOfMeasure
        
        '''<remarks/>
        S
        
        '''<remarks/>
        A
        
        '''<remarks/>
        O
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ManualWorkCenterRates
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ManualRates
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private setupRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedOverheadRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private variableOverheadRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startupRateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private teardownRateField As String
        
        Public Sub New()
            MyBase.New
            Me.setupRateField = "0.0000"
            Me.runRateField = "0.0000"
            Me.fixedOverheadRateField = "0.0000"
            Me.variableOverheadRateField = "0.0000"
            Me.startupRateField = "0.0000"
            Me.teardownRateField = "0.0000"
        End Sub
        
        '''<summary>
        '''This will override the setup rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property SetupRate() As String
            Get
                Return Me.setupRateField
            End Get
            Set
                Me.setupRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This will override the run rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property RunRate() As String
            Get
                Return Me.runRateField
            End Get
            Set
                Me.runRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This will override the fixed overhead rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property FixedOverheadRate() As String
            Get
                Return Me.fixedOverheadRateField
            End Get
            Set
                Me.fixedOverheadRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This will override the variable overhead rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property VariableOverheadRate() As String
            Get
                Return Me.variableOverheadRateField
            End Get
            Set
                Me.variableOverheadRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This will override the start up rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property StartupRate() As String
            Get
                Return Me.startupRateField
            End Get
            Set
                Me.startupRateField = value
            End Set
        End Property
        
        '''<summary>
        '''This will override the tear down rate of the selected work center. This will only come into effect if you have set Manual Work Center Rates to 'Y'.
        '''</summary>
        Public Property TeardownRate() As String
            Get
                Return Me.teardownRateField
            End Get
            Set
                Me.teardownRateField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ItemMultipleScrapEntries
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemMultipleScrap
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multipleScrapCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private multipleScrapQtyField As String
        
        Public Property MultipleScrapCode() As String
            Get
                Return Me.multipleScrapCodeField
            End Get
            Set
                Me.multipleScrapCodeField = value
            End Set
        End Property
        
        Public Property MultipleScrapQty() As String
            Get
                Return Me.multipleScrapQtyField
            End Get
            Set
                Me.multipleScrapQtyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemCoProductScrap
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductLineNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductScrapCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductScrapQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductReservedLotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private coProductReservedSerialsField As List(Of ItemCoProductScrapCoProductReservedSerials)
        
        Public Property CoProductLineNumber() As String
            Get
                Return Me.coProductLineNumberField
            End Get
            Set
                Me.coProductLineNumberField = value
            End Set
        End Property
        
        Public Property CoProductScrapCode() As String
            Get
                Return Me.coProductScrapCodeField
            End Get
            Set
                Me.coProductScrapCodeField = value
            End Set
        End Property
        
        Public Property CoProductScrapQty() As String
            Get
                Return Me.coProductScrapQtyField
            End Get
            Set
                Me.coProductScrapQtyField = value
            End Set
        End Property
        
        Public Property CoProductReservedLot() As String
            Get
                Return Me.coProductReservedLotField
            End Get
            Set
                Me.coProductReservedLotField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("CoProductReservedSerials")>  _
        Public Property CoProductReservedSerialsCollection() As List(Of ItemCoProductScrapCoProductReservedSerials)
            Get
                Return Me.coProductReservedSerialsField
            End Get
            Set
                Me.coProductReservedSerialsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemCoProductScrapCoProductReservedSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        '''<summary>
        '''This indicates the serial number that you want to scrap. The format is either alphanumeric or numeric depending on the key configuration for serials within SYSPRO.
        '''</summary>
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the quantity that will be scrapped for the reserved serial. The quantity can only be 1 for manual serials.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class ItemReservedSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        '''<summary>
        '''This indicates the serial number that you want to scrap. The format is either alphanumeric or numeric depending on the key configuration for serials within SYSPRO.
        '''</summary>
        Public Property SerialNumber() As String
            Get
                Return Me.serialNumberField
            End Get
            Set
                Me.serialNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the quantity that will be scrapped for the reserved serial. The quantity can only be 1 for manual serials.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PostLabour
        Implements ITransaction

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private itemField As List(Of Item)

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _params As Params.Parameters

        '''<summary>
        '''This is the top element for all data required for the transaction.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTLP"
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

        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
            End Get
        End Property

        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.xmlParam
            Get
                Dim objParams As Params.PostLabour
                objParams = New Params.PostLabour()
                objParams.Parameters = Me.Params
                Return Common.SysproUtilities.SerializeToXMLString(objParams)
            End Get
        End Property

        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
