Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.InventoryStockTakeImport.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CaptureTicketNumbers
        
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
    Public Enum CreateBins
        
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
    Public Enum CreateLots
        
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
    Public Enum CreateSerials
        
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
    Public Enum IgnoreOtherWhsItems
        
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
        Private warehouseCodeField As String
        
        '''<summary>
        '''Warehouse to use for Stock Take. This is the warehouse in which the stock take is to take place. 
        '''
        '''Although you can count stock in more than one warehouse at a time, the program treats each warehouse separately in the stock count. 
        '''
        '''
        '''</summary>
        Public Property WarehouseCode() As String
            Get
                Return Me.warehouseCodeField
            End Get
            Set
                Me.warehouseCodeField = value
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
        Private createBinsField As CreateBins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createSerialsField As CreateSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private createLotsField As CreateLots
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateReturnsAllField As ValidateReturnsAll
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreOtherWhsItemsField As IgnoreOtherWhsItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private captureTicketNumbersField As CaptureTicketNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ticketNumbersExistField As TicketNumbersExist
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultCaptureMethodField As DefaultCaptureMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultCaptureMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.createBinsField = CreateBins.N
            Me.createSerialsField = CreateSerials.N
            Me.createLotsField = CreateLots.N
            Me.validateReturnsAllField = ValidateReturnsAll.N
            Me.validateOnlyField = ValidateOnly.N
            Me.ignoreOtherWhsItemsField = IgnoreOtherWhsItems.Y
            Me.captureTicketNumbersField = CaptureTicketNumbers.N
            Me.ticketNumbersExistField = TicketNumbersExist.N
            Me.defaultCaptureMethodField = DefaultCaptureMethod.I
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''Create Bins if they don't exist (N - No, Y - Yes). Default is N.
        '''However, if the Inventory setup option 'Allow creation of bins when processing Inventory transactions' is not set, this option is ignored and 'N' is assumed.
        '''</summary>
        Public Property CreateBins() As CreateBins
            Get
                Return Me.createBinsField
            End Get
            Set
                Me.createBinsField = value
            End Set
        End Property
        
        '''<summary>
        '''Create Serials if they don't exist (N - No, Y - Yes). Default is N.
        '''</summary>
        Public Property CreateSerials() As CreateSerials
            Get
                Return Me.createSerialsField
            End Get
            Set
                Me.createSerialsField = value
            End Set
        End Property
        
        '''<summary>
        '''Create Lots if they don't exist (N - No, Y - Yes). Default is N.
        '''</summary>
        Public Property CreateLots() As CreateLots
            Get
                Return Me.createLotsField
            End Get
            Set
                Me.createLotsField = value
            End Set
        End Property
        
        '''<summary>
        '''Validate returns all records (N - No, Y - Yes). Default is N.
        '''</summary>
        Public Property ValidateReturnsAll() As ValidateReturnsAll
            Get
                Return Me.validateReturnsAllField
            End Get
            Set
                Me.validateReturnsAllField = value
            End Set
        End Property
        
        '''<summary>
        '''If Y = Yes then only validate. If N=No then validate and import. Default is N.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        '''<summary>
        '''(N - No, Y - Yes). Default is Y. This is an option to ignore items of other warehouses, other than the key warehouse. If you selected "N" you can leave the warehouse tag empty or put an invalid warehouse, and the program will ignore this item. If you select "Y" all the warehouses will be validated and a error message will be returned for invalid warehouses.
        '''</summary>
        Public Property IgnoreOtherWhsItems() As IgnoreOtherWhsItems
            Get
                Return Me.ignoreOtherWhsItemsField
            End Get
            Set
                Me.ignoreOtherWhsItemsField = value
            End Set
        End Property
        
        '''<summary>
        '''(N - No, Y - Yes). Default is N. When this option is 'Y' the ticket number details entered will be captured. If the ticket number is found on file, the stock code and the bin must be the same as the stock code and bin held against the ticket number. 
        '''</summary>
        Public Property CaptureTicketNumbers() As CaptureTicketNumbers
            Get
                Return Me.captureTicketNumbersField
            End Get
            Set
                Me.captureTicketNumbersField = value
            End Set
        End Property
        
        '''<summary>
        '''(N - No, Y - Yes). Default is N. When this option is 'Y', the program will only take ticket numbers that already exist. The stock code and the bin captured should be the same as the stock code and the ticket held against the ticket number. If the stock code is not entered a stock code held against the ticket number is used. If the bin location is not entered a bin location held against the ticket number is used. 
        '''</summary>
        Public Property TicketNumbersExist() As TicketNumbersExist
            Get
                Return Me.ticketNumbersExistField
            End Get
            Set
                Me.ticketNumbersExistField = value
            End Set
        End Property
        
        '''<summary>
        '''I - Increase quanity, R - replace quantity. You use this option to increase or replace already captured quantity. Default is I - Increase quantity.
        '''</summary>
        Public Property DefaultCaptureMethod() As DefaultCaptureMethod
            Get
                Return Me.defaultCaptureMethodField
            End Get
            Set
                Me.defaultCaptureMethodField = value
                Me.DefaultCaptureMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DefaultCaptureMethodSpecified() As Boolean
            Get
                Return Me.defaultCaptureMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used.
        '''</summary>
        Public Property XslStylesheet() As XslStylesheet
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
    Public Enum ValidateReturnsAll
        
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
    Public Enum ValidateOnly
        
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
    Public Enum TicketNumbersExist
        
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
    Public Enum DefaultCaptureMethod
        
        '''<remarks/>
        I
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class XslStylesheet
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class StockTake
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        '''<summary>
        '''The key root element contains only the warehouse. The key element is mandatory. 
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
        '''The stock take option element consists of: 
        '''  1. CreateBins, 
        '''  2. CreateSerials,
        '''   3. CreateLots,
        '''  4. ValidateReturnsAll,
        '''  5. ValidateOnly,
        '''  6. IgnoreOtherWhsItems,
        '''  7. CaptureTicketNumbers,
        '''  8. TicketNumbersExist, and
        '''  9. XslStylesheet.  
        '''If these options are not supplied, the option defaults will take over.
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
    End Class
End Namespace
