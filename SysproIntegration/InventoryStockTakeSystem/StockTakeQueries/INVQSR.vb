Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.StockTakeQueries.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class BinLocation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As BinLocation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As UnitOfMeasure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ticketField As Ticket
        
        Public Sub New()
            MyBase.New
            If (Me.ticketField Is Nothing) Then
                Me.ticketField = New Ticket
            End If
            If (Me.productClassField Is Nothing) Then
                Me.productClassField = New ProductClass
            End If
            If (Me.unitOfMeasureField Is Nothing) Then
                Me.unitOfMeasureField = New UnitOfMeasure
            End If
            If (Me.binLocationField Is Nothing) Then
                Me.binLocationField = New BinLocation
            End If
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New StockCode
            End If
        End Sub
        
        '''<summary>
        '''This specifies the selection of stock code ( A - All, S - Single, R - Range).  
        '''</summary>
        Public Property StockCode() As StockCode
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of bin location ( A - All, S - Single, R - Range).  
        '''</summary>
        Public Property BinLocation() As BinLocation
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of unit of measure ( A - All, S - Single).  
        '''</summary>
        Public Property UnitOfMeasure() As UnitOfMeasure
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of product class ( A - All, S - Single, R - Range).  
        '''</summary>
        Public Property ProductClass() As ProductClass
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''This specifies the selection of ticket ( A - All, S - Single, R - Range). This is only validated in a ticket query, otherwise will be ignored.
        '''</summary>
        Public Property Ticket() As Ticket
            Get
                Return Me.ticketField
            End Get
            Set
                Me.ticketField = value
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
    Partial Public Class StockCode
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class UnitOfMeasure
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class ProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Ticket
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterType() As String
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        '''<summary>
        '''This is the warehouse in which the stock take is taking place. Although stock take selection can be done in more than one warehouse at one time, only one warehouse (selected warehouse) details will be displayed. This is a mandatory element and should be valid. 
        '''</summary>
        Public Property Warehouse() As String
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private valueStockAtField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private onlyShowExceptionLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeTicketsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeZeroLotsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroSaveQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeQtyNotCapturedField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchSerialsField As OptionIncludeBatchSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeBatchSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeManualSerialsField As OptionIncludeManualSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeManualSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeZeroSerialsField As OptionExcludeZeroSerials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private excludeZeroSerialsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''The query can be ordered in stock code or bin location sequence. Input S/B, S - Stock code or  B - Bin location sequence, if multiple bins are installed, else will default to stock code. If anything else is entered, an error message will be returned.
        '''</summary>
        Public Property Sequence() As String
            Get
                Return Me.sequenceField
            End Get
            Set
                Me.sequenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Stock can be values in Cost on warehouse file - value stock at the unit cost currently held against the warehouse. (For FIFO costing the unit cost is the last cost.) OR cost on stock take file - value stock in the stock take file at the unit cost prevailing at the time the stock take selection was run, regardless of any cost changes that may have occurred since the stock take was selected. Enter "W" to select Cost on warehouse file and "S" to select cost on stock take file.  If anything else is entered, an error message will be returned.
        '''
        '''</summary>
        Public Property ValueStockAt() As String
            Get
                Return Me.valueStockAtField
            End Get
            Set
                Me.valueStockAtField = value
            End Set
        End Property
        
        '''<summary>
        ''' Input Y/N , if anything else is entered, an error message will be returned. If "Y" is selected - Shows a list of stock codes where the captured quantity differs from the original quantity on hand by a specific variance. This variance is specified at the Maximum permitted stock take variance option in Setup Distribution Setup, Inventory, Options.
        '''</summary>
        Public Property OnlyShowExceptionLines() As String
            Get
                Return Me.onlyShowExceptionLinesField
            End Get
            Set
                Me.onlyShowExceptionLinesField = value
            End Set
        End Property
        
        '''<summary>
        '''Input Y/N , if anything else is entered, an error message will be returned. If "Y" a list of stock codes with their corresponding lots showing captured quantities is displayed.  
        '''</summary>
        Public Property IncludeLots() As String
            Get
                Return Me.includeLotsField
            End Get
            Set
                Me.includeLotsField = value
            End Set
        End Property
        
        '''<summary>
        '''All ticket numbers for a bin(if bins are installed), stock code will be returned when this element is Y. The default for this element is N . Options Y - Yes, and N - No.
        '''</summary>
        Public Property IncludeTickets() As String
            Get
                Return Me.includeTicketsField
            End Get
            Set
                Me.includeTicketsField = value
            End Set
        End Property
        
        '''<summary>
        '''Input Y/N , if anything else is entered, an error message will be returned.
        '''</summary>
        Public Property ExcludeZeroLots() As String
            Get
                Return Me.excludeZeroLotsField
            End Get
            Set
                Me.excludeZeroLotsField = value
            End Set
        End Property
        
        '''<summary>
        '''Input Y/N , if anything else is entered, an error message will be returned. If "Y" a list of stock codes with zero quantity on hand is included in the query.
        '''</summary>
        Public Property IncludeZeroSaveQty() As String
            Get
                Return Me.includeZeroSaveQtyField
            End Get
            Set
                Me.includeZeroSaveQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Input Y/N , if anything else is entered, an error message will be returned. If "Y" a list of stock codes with quantities not captured is included.
        '''</summary>
        Public Property IncludeQtyNotCaptured() As String
            Get
                Return Me.includeQtyNotCapturedField
            End Get
            Set
                Me.includeQtyNotCapturedField = value
            End Set
        End Property
        
        Public Property IncludeBatchSerials() As OptionIncludeBatchSerials
            Get
                Return Me.includeBatchSerialsField
            End Get
            Set
                Me.includeBatchSerialsField = value
                Me.IncludeBatchSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeBatchSerialsSpecified() As Boolean
            Get
                Return Me.includeBatchSerialsFieldSpecified
            End Get
        End Property
        
        Public Property IncludeManualSerials() As OptionIncludeManualSerials
            Get
                Return Me.includeManualSerialsField
            End Get
            Set
                Me.includeManualSerialsField = value
                Me.IncludeManualSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeManualSerialsSpecified() As Boolean
            Get
                Return Me.includeManualSerialsFieldSpecified
            End Get
        End Property
        
        Public Property ExcludeZeroSerials() As OptionExcludeZeroSerials
            Get
                Return Me.excludeZeroSerialsField
            End Get
            Set
                Me.excludeZeroSerialsField = value
                Me.ExcludeZeroSerialsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ExcludeZeroSerialsSpecified() As Boolean
            Get
                Return Me.excludeZeroSerialsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter the name of the xsd Stylesheet to use.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeBatchSerials
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIncludeManualSerials
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionExcludeZeroSerials
        
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
    Partial Public Class XslStylesheet
    End Class
    
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
        '''The key consists of only one element, the warehouse. The warehouse should be on file, in the stock take selection, and the operator should have access to the warehouse. Otherwise an error will be returned.  The key is mandatory.
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
        '''The root element.
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        '''<summary>
        '''The root element.
        '''</summary>
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
                Return "INVQSR"
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
