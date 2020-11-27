Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.BackOrderReleasesImport.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AdjustOrderQuantity
        
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
    Public Enum AllocateSerialNumbers
        
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
    Partial Public Class Bins
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binPiecesField As String
        
        '''<summary>
        '''At least one bin must be supplied if the company makes use of multiple bins, and the warehouse on the detail line also uses multiple bins. BinLocation may not be more than 6 characters. Will be validated against the inventory Bin file for the stock code. Take note that the bins do not have to be supplied when ZeroShipQuantity is selected - all bins for the line will be de-allocated automatically when this option is selected. The quantities supplied for all bins must add up to the import quantity supplied for the line when releasing the back order quantity to ship. When changing the ship quantity (not setting to zero) to less than the original ship quantity - therefore creating a back order quantity - only bins that needs to be de-allocated must be supplied. Bins do not have to be supplied if Automatic depletion is in use - unless the stock item is both lot traceable and serialized.
        '''</summary>
        Public Property BinLocation() As String
            Get
                Return Me.binLocationField
            End Get
            Set
                Me.binLocationField = value
            End Set
        End Property
        
        '''<summary>
        '''A bin quantity must be supplied for every bin location supplied if the stock code does not make use of unit quantity processing. If the stock item makes use of unit processing - the quantity can either be supplied as a decimal value or else as Units and Pieces. The bin quantity may not have more than 7 characters for integers and 3 characters for decimals. 
        '''</summary>
        Public Property BinQuantity() As String
            Get
                Return Me.binQuantityField
            End Get
            Set
                Me.binQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of units to import for a Bin location for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value.  May not be more than 7 characters.  
        '''</summary>
        Public Property BinUnits() As String
            Get
                Return Me.binUnitsField
            End Get
            Set
                Me.binUnitsField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of pieces to import for a Bin location for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value.  May not be more than 3 characters.
        '''</summary>
        Public Property BinPieces() As String
            Get
                Return Me.binPiecesField
            End Get
            Set
                Me.binPiecesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CompleteLine
        
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private latestAcceptedLotExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private latestAcceptedSerialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private latestAcceptedSerialScrapDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleAllocateDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private scheduleLineShipDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actualShipQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseFromMultipleLinesField As ReleaseFromMultipleLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseFromMultipleLinesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeLineField As CompleteLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private completeLineFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private adjustOrderQuantityField As AdjustOrderQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private adjustOrderQuantityFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialsField As List(Of Serials)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lotField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private binsField As List(Of Bins)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As OrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseFromShipField As ReleaseFromShip
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseFromShipFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private zeroShipQuantityField As ZeroShipQuantity
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private zeroShipQuantityFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocateSerialNumbersField As AllocateSerialNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocateSerialNumbersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eSignatureField As String
        
        Public Sub New()
            MyBase.New
            Me.releaseFromMultipleLinesField = ReleaseFromMultipleLines.N
            Me.completeLineField = CompleteLine.N
            Me.adjustOrderQuantityField = AdjustOrderQuantity.N
            Me.releaseFromShipField = ReleaseFromShip.N
            Me.zeroShipQuantityField = ZeroShipQuantity.N
            Me.allocateSerialNumbersField = AllocateSerialNumbers.N
            If (Me.binsField Is Nothing) Then
                Me.binsField = New List(Of Bins)
            End If
            If (Me.serialsField Is Nothing) Then
                Me.serialsField = New List(Of Serials)
            End If
        End Sub
        
        '''<summary>
        '''The lot expiry date must be in format CCYY-MM-DD. The lot expiry date supplied will be used to verify if the Lot has already expired.
        '''</summary>
        Public Property LatestAcceptedLotExpiryDate() As String
            Get
                Return Me.latestAcceptedLotExpiryDateField
            End Get
            Set
                Me.latestAcceptedLotExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Latest accepted serial expiry date must be in format CCYY-MM-DD. The serial expiry date will be used to verify if any of the Serials has already expired.
        '''</summary>
        Public Property LatestAcceptedSerialExpiryDate() As String
            Get
                Return Me.latestAcceptedSerialExpiryDateField
            End Get
            Set
                Me.latestAcceptedSerialExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial scrap date must be in format CCYY-MM-DD. The serial scrap date will be used to verify if the Serial has been scrapped.
        '''</summary>
        Public Property LatestAcceptedSerialScrapDate() As String
            Get
                Return Me.latestAcceptedSerialScrapDateField
            End Get
            Set
                Me.latestAcceptedSerialScrapDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Schedule allocate date must be in format CCYY-MM-DD. The schedule allocate date will be used to verify whether the number of days within which a scheduled order will be allocated has been exceeded. Check only performed if it is a scheduled order, the number of days within which scheduled orders will be allocated is not 999 and a ScheduleAllocateDate has been supplied.
        '''</summary>
        Public Property ScheduleAllocateDate() As String
            Get
                Return Me.scheduleAllocateDateField
            End Get
            Set
                Me.scheduleAllocateDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Schedule line ship date must be in format CCYY-MM-DD. The schedule line ship date will be used as Detail line ship date for scheduled orders.
        '''</summary>
        Public Property ScheduleLineShipDate() As String
            Get
                Return Me.scheduleLineShipDateField
            End Get
            Set
                Me.scheduleLineShipDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Entry in the Customer element is optional, but if supplied will be validated against the Sales order header file. May not be more than 7 characters. If customer numeric key - must be a valid numeric value.  
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
            End Set
        End Property
        
        '''<summary>
        '''Must be supplied. May contain a maximum of 6 characters. Must be a valid numeric value if sales order key for the company is numeric. Sales order must be on file. Changes to sales order in status 4 (changing the ship qty) will only be allowed when the sales order set-up option to allow changes to status 4 orders when import status is 8 is selected - General tab 3. Sales order status may not be cancelled, complete, In process, a Forward order or in suspense. 
        '''</summary>
        Public Property SalesOrder() As String
            Get
                Return Me.salesOrderField
            End Get
            Set
                Me.salesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''Stock code must be supplied if release from multiple lines is selected. May not be more than 30 characters for alphanumeric key type and 15 characters for numeric key type (must be valid numeric value if numeric key type). Stock code will be validated against the Inventory master file. 
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
        '''Warehouse must be supplied if release from multiple lines is selected. Stock code supplied must be stocked in this warehouse. May not be more than 2 characters.
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
        '''Must be supplied for a stock code that does not make use of unit quantity processing. The quantity can still be supplied for a stock code that makes use of unit quantity processing , but then the units and pieces must NOT be supplied for that item. May not have more than 7 characters for integers and 3 characters for decimals. The number of decimals will be validated against the number of decimals required for the stock code. If the ZeroShipQuantity option is selected then this element must contain zero. The quantity supplied must be in the stocking unit of measure.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''This quantity is only used to define the actual quantity to ship for a specific line where the order quantity is not in the stocking unit of measure, and the SYSPRO option 'Unit of measure conversion factors are theoretical' is in use. It is only valid if the 'ReleaseFromShip' element is 'A', and the order is in a status of '4' or '8'. May not have more than 7 characters for integers and 3 characters for decimals. The number of decimals will be validated against the number of decimals required for the stock code.
        '''</summary>
        Public Property ActualShipQty() As String
            Get
                Return Me.actualShipQtyField
            End Get
            Set
                Me.actualShipQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Unit of measure of the stock being released. This unit of measure will apply to all quantity elements supplied (eg. BinQuantity and SerialQuantity). If the element is not supplied it will default to the stocking unit of measure for the stock code.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of units to import for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value. Either the quantity or Units and Pieces must be supplied for the item.  May not be more than 7 characters.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of pieces to import for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value.  May not be more than 3 characters. 
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''To release the back order qty from several lines for the same stock code. Stock code and Warehouse must be supplied if selected. Line Number must not be supplied when selected. May not be selected when either ReleaseFromShip or CompleteLine or AdjustOrderQuantity has been selected. Serial numbers must be supplied for a serialized item. The quantities supplied for all serial numbers must add up to the import quantity supplied for the stock code. Serial numbers will be allocated to sales order lines from top to bottom in the file. Example - if you have a sales order with two lines for a manual stock code and each line has a back order quantity of 2 - four serial numbers must be supplied. The first two serials will be allocated to the first sales order line and the next two to the second sales order line.  Bin location must be supplied if multiple bins is in use. Bin numbers will also be allocated from top to bottom in the file as described for serials above
        '''</summary>
        Public Property ReleaseFromMultipleLines() As ReleaseFromMultipleLines
            Get
                Return Me.releaseFromMultipleLinesField
            End Get
            Set
                Me.releaseFromMultipleLinesField = value
                Me.ReleaseFromMultipleLinesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReleaseFromMultipleLinesSpecified() As Boolean
            Get
                Return Me.releaseFromMultipleLinesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Must be supplied if option to release from multiple lines is not selected. Must be a valid numeric value. Sales order line must exists on the sales order detail file and must be a stocked line. 
        '''</summary>
        Public Property SalesOrderLine() As String
            Get
                Return Me.salesOrderLineField
            End Get
            Set
                Me.salesOrderLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Forces the sales order line to be marked as complete - regardless of whether there is a remaining back order quantity (i.e. the back order quantity against the sales order line is set to zero, even if there should have been a back order quantity remaining after the import).
        '''</summary>
        Public Property CompleteLine() As CompleteLine
            Get
                Return Me.completeLineField
            End Get
            Set
                Me.completeLineField = value
                Me.CompleteLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CompleteLineSpecified() As Boolean
            Get
                Return Me.completeLineFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This option forces the order quantity against the sales order line to equal the quantity that is being imported - when the quantity being imported is greater than the current order quantity.
        '''</summary>
        Public Property AdjustOrderQuantity() As AdjustOrderQuantity
            Get
                Return Me.adjustOrderQuantityField
            End Get
            Set
                Me.adjustOrderQuantityField = value
                Me.AdjustOrderQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AdjustOrderQuantitySpecified() As Boolean
            Get
                Return Me.adjustOrderQuantityFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''It is now possible to import several serials for the same order line instead of just one serial per line. Take note that the serial numbers do not have to be supplied when ZeroShipQuantity is selected - all serials for the line will be de-allocated automatically. The quantities supplied for all serial numbers must add up to the import quantity supplied for the line when releasing the back order quantity to ship. If you are changing the ship quantity and a back order quantity is created - the total quantity for all the serials supplied must add up to the quantity that needs to be moved to back order (i.e. only supply the serial numbers that need to be de-allocated when a back order quantity is created when changing the sales order line ship quantity) .
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Serials")>  _
        Public Property SerialsCollection() As List(Of Serials)
            Get
                Return Me.serialsField
            End Get
            Set
                Me.serialsField = value
            End Set
        End Property
        
        '''<summary>
        '''A lot must be supplied if the stock code is lot traceable. The lot may not be more than 10 characters. If the key lot type for the company is numeric the lot supplied must be a valid numeric value. The lot supplied will be validated against the Lot traceable file for the stock code. Lots do not have to be supplied if Automatic depletion is in use - unless the stock item is both lot traceable and serialized.
        '''</summary>
        Public Property Lot() As String
            Get
                Return Me.lotField
            End Get
            Set
                Me.lotField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the top element for the set of bins affected by this transaction, if multiple bins is installed. If the warehouse for the associated detail line does not make use of multiple bins, then any entries in the 'Bins' node will be ignored. It is possible to import several bins for the same order line instead of just one bin per line. Take note that the bins do not have to be supplied when ZeroShipQuantity is selected - all bins for the line will be de-allocated automatically when this option is selected. The quantities supplied for all bins must add up to the import quantity supplied for the line when releasing the back order quantity to ship. When changing the ship quantity (not setting to zero) to less than the original ship quantity - therefore creating a back order quantity - only bins that needs to be de-allocated must be supplied. Bins do not have to be supplied if Automatic depletion is in use - unless the stock item is both lot traceable and serialized.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Bins")>  _
        Public Property BinsCollection() As List(Of Bins)
            Get
                Return Me.binsField
            End Get
            Set
                Me.binsField = value
            End Set
        End Property
        
        '''<summary>
        '''OrderStatus must be supplied.  If selected "3" - order that are in status 2 will be set to status 3 after releasing back order qty. If selected "8" then the order will be set to status 8 provided there are no serialized items with ship quantities for which serials must still be allocated. Order status must contain 8 when ReleaseFromShip is selected  only when ZeroShipQuantity is not selected. If selected "N" - order will be in the same status as before the update - recommended if you are changing the ship quantity to zero and would like the order status to stay the same. If the set-up option to capture serial numbers for orders (Sales order set-up - Detail tab) is not selected and the stock item is serialized - but Capture Serials during Order Entry is selected - it will be possible to have an order in a status 4 with no serials allocated - order status may not be changed to 8 for such an order.  
        '''</summary>
        Public Property OrderStatus() As OrderStatus
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
            End Set
        End Property
        
        '''<summary>
        '''If this option is selected 'Y' - changes will be made to the ship quantity instead of the back order quantity. Must be selected if you want to set the ship quantity to zero or allocate serial numbers. May not be selected when ReleaseFromMultipleLines is selected. an entry of 'A', Actual means that the quantity will be taken from the element 'ActualShipQty' and applied to the stocking quantity to ship.
        '''</summary>
        Public Property ReleaseFromShip() As ReleaseFromShip
            Get
                Return Me.releaseFromShipField
            End Get
            Set
                Me.releaseFromShipField = value
                Me.ReleaseFromShipFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReleaseFromShipSpecified() As Boolean
            Get
                Return Me.releaseFromShipFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The sales order line ship quantity will be set to zero, all quantities will be moved to back order and all serial, bins and lots will be de-allocated.  The Quantity supplied must be zero if this option is selected. Zero ship quantity may not be selected when ReleaseFromMultipleLines is selected. When zero ship quantity is selected - ReleaseFromShip must be selected. 
        '''</summary>
        Public Property ZeroShipQuantity() As ZeroShipQuantity
            Get
                Return Me.zeroShipQuantityField
            End Get
            Set
                Me.zeroShipQuantityField = value
                Me.ZeroShipQuantityFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ZeroShipQuantitySpecified() As Boolean
            Get
                Return Me.zeroShipQuantityFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If you select this option the program will confirm the ship quantity for the sales order line and allocate the serials supplied to the sales order line. If you select this option - ReleaseFromShip must be selected. The Quantity supplied must equal the current sales order line ship quantity. The stock Item must be a serialized item and serial tracking must be in use. All serial numbers must be supplied. The total quantity supplied for all serials must be the same as the Quantity for the line. The stock code may not have any previous serial allocation. The stock item should be set-up to capture serial numbers during order entry and flagged as enter serial numbers at sale time only. The sales order set-up option to capture serial numbers for orders - should not be selected. This option may not be selected if you have selected either AdjustOrderQuantity or CompleteLine or ZeroShipQuantity or ReleaseFromMultipleLines.
        '''</summary>
        Public Property AllocateSerialNumbers() As AllocateSerialNumbers
            Get
                Return Me.allocateSerialNumbersField
            End Get
            Set
                Me.allocateSerialNumbersField = value
                Me.AllocateSerialNumbersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllocateSerialNumbersSpecified() As Boolean
            Get
                Return Me.allocateSerialNumbersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If required, this element must contain a GUID, for the eSignature system to accept the transaction as having been authenticated. The GUID format is in the format {36303032-3330-3031-3038-323434363433}, where the numbers can be replaced with any character. It is up to the developer to have requested a password to protect the transaction. An example is that a GUID associated with the act of entering a valid password could be obtained and presented.
        '''</summary>
        Public Property eSignature() As String
            Get
                Return Me.eSignatureField
            End Get
            Set
                Me.eSignatureField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReleaseFromMultipleLines
        
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
    Partial Public Class Serials
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialCreationDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialExpiryDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialScrapDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialUnitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPiecesField As String
        
        Public Sub New()
            MyBase.New
            Me.serialExpiryDateField = " "
        End Sub
        
        '''<summary>
        '''At least one serial number must be supplied if Serial tracking is required and the stock item is a serialized item - unless ZeroShipQuantity is selected. May not be more than 20 characters for alphanumeric key type and 15 characters for numeric key type (must be valid numeric value if numeric key type).  Serial number must exist on file and have stock for manual and batch serial numbers if stock code is flagged as captures serial numbers at receipt. When updating a sales order line for a batch serial number for a stock item that is set to capture serial numbers during order entry - the parameter AddQuantityToBatchSerial must be selected. The batch serial will be created and the Total receipt quantity and Qty On Hand for the serial will be updated with the new quantity - leaving the Available qty as zero.  When changing the ship quantity (not setting to zero) to less than the original ship quantity - therefore creating a back order quantity - only serials that needs to be de-allocated.
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
        '''A serial quantity must be supplied for each serial number if the stock code does not make use of unit quantity processing. If the stock item makes use of unit processing - the quantity can either be supplied as a decimal value or else as Units and Pieces. Unit quantity processing will only apply to a batch serial item. Serial quantity may not have more than 7 characters for integer and 3 characters for decimals.
        '''</summary>
        Public Property SerialQuantity() As String
            Get
                Return Me.serialQuantityField
            End Get
            Set
                Me.serialQuantityField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial creation date must be in format CCYY-MM-DD. The serial creation date will be saved in the serial tracking master header file against the serial number.
        '''</summary>
        Public Property SerialCreationDate() As String
            Get
                Return Me.serialCreationDateField
            End Get
            Set
                Me.serialCreationDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial expiry date must be in format CCYY-MM-DD. When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial expiry date will be saved against the serial number.
        '''</summary>
        Public Property SerialExpiryDate() As String
            Get
                Return Me.serialExpiryDateField
            End Get
            Set
                Me.serialExpiryDateField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial scrap date must be in format CCYY-MM-DD. When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial scrap date will be saved against the serial number.
        '''</summary>
        Public Property SerialScrapDate() As String
            Get
                Return Me.serialScrapDateField
            End Get
            Set
                Me.serialScrapDateField = value
            End Set
        End Property
        
        '''<summary>
        '''When adding a new serial for a stock code that is flagged as capture serials during order entry - the serial location will be saved against the serial number.
        '''</summary>
        Public Property SerialLocation() As String
            Get
                Return Me.serialLocationField
            End Get
            Set
                Me.serialLocationField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of units to import for a batch Serial for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value.  May not be more than 7 characters.  
        '''</summary>
        Public Property SerialUnits() As String
            Get
                Return Me.serialUnitsField
            End Get
            Set
                Me.serialUnitsField = value
            End Set
        End Property
        
        '''<summary>
        '''Must contain the number of pieces to import for a batch Serial for a stock code that makes use of unit quantity processing, if the quantity is not supplied as a decimal value.  May not be more than 3 characters.
        '''</summary>
        Public Property SerialPieces() As String
            Get
                Return Me.serialPiecesField
            End Get
            Set
                Me.serialPiecesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderStatus
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReleaseFromShip
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ZeroShipQuantity
        
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
    Partial Public Class PostSorBackOrderRelease
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private _params As Params.Parameters

        Public Sub New()
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub

        '''<summary>
        '''The element Item must be used to identify the start and end of the import information for each sales order line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")> _
       Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set(ByVal value As List(Of Item))
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "SORTBO"
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
                Dim objParams As Params.PostSorBackOrderRelease
                objParams = New Params.PostSorBackOrderRelease
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
