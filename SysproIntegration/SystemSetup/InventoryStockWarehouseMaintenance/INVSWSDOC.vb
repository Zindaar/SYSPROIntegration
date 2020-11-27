Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.InventoryStockWarehouseMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupInvWarehouse
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This element contains information to maintain a single warehouse for a stock code. 
        '''NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
        '''
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
                Return "INVSWS"
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
                Dim objParams As Params.SetupInvWarehouse
                objParams = New Params.SetupInvWarehouse
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
        Private costMultiplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private maximumQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultBinField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private safetyStockQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reOrderQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private palletQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderPolicyField As OrderPolicy
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderPolicyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private majorOrderMultField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minorOrderMultField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderMinimumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderMaximumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderFixPeriodField As OrderFixPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderFixPeriodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfSuppliedItemField As TrfSuppliedItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfSuppliedItemFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private defaultSourceWhField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfCostGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfCostMultiplyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfReplenishWhField As TrfReplenishWh
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfReplenishWhFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfBuyingRuleField As TrfBuyingRule
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfBuyingRuleFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfDockToStockField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trfFixTimePeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labourCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixedOverheadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private variableOverheadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagField As ManualCostFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.orderPolicyField = OrderPolicy.C
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a warehouse for a stock code.
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
        '''Cost multiplier is the portion of the transaction value of the stock item comprises non-merchandise costs (e.g. freight, duty, tax, etc.). It is used within Inventory Movements when processing a receipt, but only if you have indicated that you want to apply a cost multiplier when processing receipts (Inventory Setup).
        '''The format is 3.3 positive numeric.
        '''</summary>
        Public Property CostMultiplier() As String
            Get
                Return Me.costMultiplierField
            End Get
            Set
                Me.costMultiplierField = value
            End Set
        End Property
        
        '''<summary>
        '''Minimum quantity of the item required to be stocked in the warehouse at any point in time. The format is 7.3 positive numeric.
        '''</summary>
        Public Property MinimumQty() As String
            Get
                Return Me.minimumQtyField
            End Get
            Set
                Me.minimumQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Maximum quantity of the item required to be stocked in the warehouse at any point in time. The format is 7.3 positive numeric.
        '''</summary>
        Public Property MaximumQty() As String
            Get
                Return Me.maximumQtyField
            End Get
            Set
                Me.maximumQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Unit cost is the cost of one unit of the stock item in a particular warehouse.
        '''NOTE: The Unit cost for a stock item in a warehouse can only be set when adding a new warehouse for a stock item. Thereafter you can only change this value using Inventory Movements.The format is 10.5 positive numeric.
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
        '''Default bin location of the stock item in a particular warehouse. If it is blank then it defaults to the warehouse code if you have activated the multiple bins options (Inventory Setup).This is also the location from which stock is issued during the Backflushing function of Inventory Movements. The format is 6 characters, alphanumeric.
        '''</summary>
        Public Property DefaultBin() As String
            Get
                Return Me.defaultBinField
            End Get
            Set
                Me.defaultBinField = value
            End Set
        End Property
        
        '''<summary>
        '''Safety stock quantity. This stock control feature highlights instances where stock falls below a prescribed level and is used within the Requirements Planning module.The safety stock level is usually set to be above the minimum stock level. 
        '''</summary>
        Public Property SafetyStockQty() As String
            Get
                Return Me.safetyStockQtyField
            End Get
            Set
                Me.safetyStockQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Re-order quantity is the quantity at which you should place an order for more of a particular stock item, and is printed on the Purchasing Work Sheet report. The format is 7.3 positive numeric.
        '''</summary>
        Public Property ReOrderQty() As String
            Get
                Return Me.reOrderQtyField
            End Get
            Set
                Me.reOrderQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Pallet quantity is the default quantity of the stock item that is required to be held in each bin, and is used when processing a purchase order receipt. The format is 7.3 positive numeric.
        '''</summary>
        Public Property PalletQty() As String
            Get
                Return Me.palletQtyField
            End Get
            Set
                Me.palletQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character free format user defined field.
        '''</summary>
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character free format user defined field.
        '''</summary>
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character free format user defined field.
        '''</summary>
        Public Property UserField3() As String
            Get
                Return Me.userField3Field
            End Get
            Set
                Me.userField3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates the order policy to be used.
        '''Valid values are:
        '''C - Cover shortages (default)
        '''S - Order to maximum if shortages
        '''M - Order to maximum if less than minimum
        '''P - Suppress MRP ordering
        '''</summary>
        Public Property OrderPolicy() As OrderPolicy
            Get
                Return Me.orderPolicyField
            End Get
            Set
                Me.orderPolicyField = value
                Me.OrderPolicyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderPolicySpecified() As Boolean
            Get
                Return Me.orderPolicyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If this element is supplied with anything other than zeros, the order quantity will be calculated as a multiple of the entered value. It cannot be less than the value supplied in the element 'MinorOrderMult'.
        '''</summary>
        Public Property MajorOrderMult() As String
            Get
                Return Me.majorOrderMultField
            End Get
            Set
                Me.majorOrderMultField = value
            End Set
        End Property
        
        '''<summary>
        '''If this element is supplied with anything other than zeros, the order quantity will be calculated as a multiple of the entered value.
        '''</summary>
        Public Property MinorOrderMult() As String
            Get
                Return Me.minorOrderMultField
            End Get
            Set
                Me.minorOrderMultField = value
            End Set
        End Property
        
        '''<summary>
        '''If this element is supplied with anything other than zeros, the order quantity will be at least the supplied value even if the requirement is less.
        '''</summary>
        Public Property OrderMinimum() As String
            Get
                Return Me.orderMinimumField
            End Get
            Set
                Me.orderMinimumField = value
            End Set
        End Property
        
        '''<summary>
        '''If this element is supplied with anything other than zeros, the order quantity will not exceed. If the requirement is greater than the value supplied, multiple orders will be required. If this value is not zero, it cannot be less than the value supplied in the  element 'OrderMinimum'.
        '''</summary>
        Public Property OrderMaximum() As String
            Get
                Return Me.orderMaximumField
            End Get
            Set
                Me.orderMaximumField = value
            End Set
        End Property
        
        '''<summary>
        '''All policies will take this into account. If 1 or zero then the orders will be raised on the date required. Any value greater than zero will cause requirements planning to apply the time period to scheduling demand and raising suggestions
        '''</summary>
        Public Property OrderFixPeriod() As OrderFixPeriod
            Get
                Return Me.orderFixPeriodField
            End Get
            Set
                Me.orderFixPeriodField = value
                Me.OrderFixPeriodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderFixPeriodSpecified() As Boolean
            Get
                Return Me.orderFixPeriodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Transfer supplied item flag is used to indicate whether the stock item for this warehouse is supplied by another warehouse. (Y - Transfer supplied, N - Not transfer supplied).
        '''NOTE: This is documentary only unless Goods in Transit is installed. You must select this option if you want to be able to create supply chain transfer orders for this warehouse/stock code combination using the Back Order Review program. This option must also be selected if you want the Requirements Planning system to take account of supply chain transfer orders. 
        '''NOTE: If the warehouse being maintained for the stock item is the same as that assigned to the Warehouse to use field for the stock item then it cannot be transfer supplied.
        '''</summary>
        Public Property TrfSuppliedItem() As TrfSuppliedItem
            Get
                Return Me.trfSuppliedItemField
            End Get
            Set
                Me.trfSuppliedItemField = value
                Me.TrfSuppliedItemFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TrfSuppliedItemSpecified() As Boolean
            Get
                Return Me.trfSuppliedItemFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Source warehouse is the default supplying warehouse from which stock will be transferred to replenish the warehouse you are maintaining if flagged as transfer supplied (TrfSuppliedItem = "Y") . If left blank then an entry in the warehouse move matrix may be used.
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 2 characters, alphanumeric.
        '''</summary>
        Public Property DefaultSourceWh() As String
            Get
                Return Me.defaultSourceWhField
            End Get
            Set
                Me.defaultSourceWhField = value
            End Set
        End Property
        
        '''<summary>
        '''Transfer lead time (days) is the number of days it takes to move the stock item from the source warehouse to the target warehouse if flagged as transfer supplied (TrfSuppliedItem = "Y") . It is used to calculate the expected delivery date.
        '''NOTE: If this field is left blank, then the the entry defined in the Warehouse Move Matrix is used. If the entry in the matrix is blank, then this field defaults to zero (0). Within requirements calculation, the lead time entered here is added to the dock to stock days and the entry defined at the Number of days after stock arrives that it can be used field (Requirements Planning Setup).
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 3 characters, numeric.
        '''</summary>
        Public Property TrfLeadTime() As String
            Get
                Return Me.trfLeadTimeField
            End Get
            Set
                Me.trfLeadTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''Transfer cost Ledger account to which you want to disburse the non-merchandise value arising from the transfer of goods if flagged as transfer supplied (TrfSuppliedItem = "Y").
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 15 characters, alphanumeric
        '''</summary>
        Public Property TrfCostGlCode() As String
            Get
                Return Me.trfCostGlCodeField
            End Get
            Set
                Me.trfCostGlCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Transfer cost multiplier. This is used to  calculate the additional non-merchandise costs that you want to add to the cost of transferring goods (e.g. freight and handling charges) if flagged as transfer supplied (TrfSuppliedItem = "Y").
        '''NOTE: Your entry made here is only applied if you selected to apply a cost multiplier when processing receipts (Inventory Setup).
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 3.3 positive numeric.
        '''</summary>
        Public Property TrfCostMultiply() As String
            Get
                Return Me.trfCostMultiplyField
            End Get
            Set
                Me.trfCostMultiplyField = value
            End Set
        End Property
        
        '''<summary>
        '''Use warehouse buying rule flag is to indicate whether to use the replenishment details defined against the warehouse or those defined against the stock code, if the warehouse is transfer supplied (TrfSuppliedItem = 'Y'), when running requirements calculation. (1 - Warehouse, 0 - Stock code)
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''</summary>
        Public Property TrfReplenishWh() As TrfReplenishWh
            Get
                Return Me.trfReplenishWhField
            End Get
            Set
                Me.trfReplenishWhField = value
                Me.TrfReplenishWhFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TrfReplenishWhSpecified() As Boolean
            Get
                Return Me.trfReplenishWhFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Batching (or buying rule) to be applied in requirements calculation if the warehouse is transfer supplied (TrfSuppliedItem = 'Y') and you are using warehouse replenishment details (TrfReplenishWh = 1).  Settings are as follows:
        '''A - Lot for lot.
        '''B - Multiples of EBQ.
        '''C - Fixed time period.
        '''D - Order to maximum if shortage.
        '''E - Order to maximum if less than minimum.
        '''F - Multiples of pan.
        '''G - Multiple EBQ lots.
        '''H - Multiple pan lots.
        '''I - Minimum of EBQ.
        '''J - Minimum of pan.
        '''K - Multiples of EBQ (fixed time period).
        '''L - Multiples of pan (fixed time period).
        '''M - Multiple EBQ lots (fixed time period).
        '''N - Multiple pan lots (fixed time period).
        '''O - Minimum of EBQ thereafter multiples of pan.
        '''P - Suppress MRP ordering.
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''</summary>
        Public Property TrfBuyingRule() As TrfBuyingRule
            Get
                Return Me.trfBuyingRuleField
            End Get
            Set
                Me.trfBuyingRuleField = value
                Me.TrfBuyingRuleFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TrfBuyingRuleSpecified() As Boolean
            Get
                Return Me.trfBuyingRuleFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Transfer dock to stock is the number of days a stock item is required to be in stock at the source warehouse prior to transfer if the warehouse is transfer supplied (TrfSuppliedItem = 'Y'). 
        '''NOTE: Within MRP, the dock to stock days entered here is added to the lead time and the entry defined at the Number of days after stock arrives that it can be used field (Requirements Planning Setup).
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 3 characters, numeric.
        '''</summary>
        Public Property TrfDockToStock() As String
            Get
                Return Me.trfDockToStockField
            End Get
            Set
                Me.trfDockToStockField = value
            End Set
        End Property
        
        '''<summary>
        '''Fixed time period (days). Number of working days that represents a fixed time period, if the warehouse is transfer supplied (TrfSuppliedItem = 'Y') and you are using warehouse replenishment details (TrfReplenishWh = 1) . 
        '''For example: A fixed time period of 1 day indicates that if a shortage is encountered, that the total shortage for today and the next working day is used as if the shortage falls today.
        '''The entry made here is used for all time-based buying rules (i.e. C, K, L, M and N) to be applied in requirements calculation.
        '''NOTE: This is documentary only unless Goods in Transit is installed.
        '''The format is 2 characters, numeric.
        '''</summary>
        Public Property TrfFixTimePeriod() As String
            Get
                Return Me.trfFixTimePeriodField
            End Get
            Set
                Me.trfFixTimePeriodField = value
            End Set
        End Property
        
        Public Property LabourCost() As String
            Get
                Return Me.labourCostField
            End Get
            Set
                Me.labourCostField = value
            End Set
        End Property
        
        Public Property MaterialCost() As String
            Get
                Return Me.materialCostField
            End Get
            Set
                Me.materialCostField = value
            End Set
        End Property
        
        Public Property FixedOverhead() As String
            Get
                Return Me.fixedOverheadField
            End Get
            Set
                Me.fixedOverheadField = value
            End Set
        End Property
        
        Public Property VariableOverhead() As String
            Get
                Return Me.variableOverheadField
            End Get
            Set
                Me.variableOverheadField = value
            End Set
        End Property
        
        Public Property SubContractCost() As String
            Get
                Return Me.subContractCostField
            End Get
            Set
                Me.subContractCostField = value
            End Set
        End Property
        
        Public Property ManualCostFlag() As ManualCostFlag
            Get
                Return Me.manualCostFlagField
            End Get
            Set
                Me.manualCostFlagField = value
                Me.ManualCostFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ManualCostFlagSpecified() As Boolean
            Get
                Return Me.manualCostFlagFieldSpecified
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
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        '''<summary>
        '''Stock code to which the Warehouse being maintained, is attached. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within SYSPRO.
        '''
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
        '''Warehouse being Added/Maintained or Deleted for the stock item. The format is 2 characters, alphanumeric.
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderPolicy
        
        '''<remarks/>
        C
        
        '''<remarks/>
        S
        
        '''<remarks/>
        M
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OrderFixPeriod
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("01")>  _
        Item01
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TrfSuppliedItem
        
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
    Public Enum TrfReplenishWh
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TrfBuyingRule
        
        '''<remarks/>
        A
        
        '''<remarks/>
        B
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        E
        
        '''<remarks/>
        F
        
        '''<remarks/>
        G
        
        '''<remarks/>
        H
        
        '''<remarks/>
        I
        
        '''<remarks/>
        J
        
        '''<remarks/>
        K
        
        '''<remarks/>
        L
        
        '''<remarks/>
        M
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ManualCostFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
End Namespace
