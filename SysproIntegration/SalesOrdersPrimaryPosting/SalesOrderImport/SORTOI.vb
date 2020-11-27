Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderImport.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AcceptKitOptional
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        E
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AcceptOrdersIfNoCredit
        
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
    Public Enum AcceptEarlierShipDate
        
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
    Public Enum AddStockSalesOrderText
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AddDangerousGoodsText
        
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
    Public Enum AddAttachedServiceCharges
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        M
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllocationAction
        
        '''<remarks/>
        F
        
        '''<remarks/>
        B
        
        '''<remarks/>
        A
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowBackOrderForNegativeMerchLine
        
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
    Public Enum AllowBackOrderForPartialHold
        
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
    Public Enum AllowBackOrderForSuperseded
        
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
    Public Enum AllowChangeToZeroPrice
        
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
    Public Enum AllowDuplicateOrderNumbers
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        A
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowInvoiceInformationEntry
        
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
    Public Enum AllowManualOrderNumberToBeUsed
        
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
    Public Enum AllowNonStockItems
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AllowZeroPrice
        
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
    Public Enum AlwaysUsePriceEntered
        
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
    Public Enum ApplyLeadTimeCalculation
        
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
    Public Enum ApplyParentDiscountToComponents
        
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
    Public Enum CheckForCustomerPoNumbers
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        C
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InBoxMsgReqd
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
    Public Enum OrderStatus
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("4")>  _
        Item4
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("8")>  _
        Item8
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OverrideCustomerBackOrder
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inBoxMsgReqdField As InBoxMsgReqd
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inBoxMsgReqdFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processField As Process
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private processFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseListToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useCustomerSalesWarehouseField As UseCustomerSalesWarehouse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useCustomerSalesWarehouseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfOrderField As TypeOfOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private typeOfOrderFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusField As OrderStatus
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderStatusFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minimumDaysToShipField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonStockItemsField As AllowNonStockItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonStockItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptOrdersIfNoCreditField As AcceptOrdersIfNoCredit
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptOrdersIfNoCreditFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptEarlierShipDateField As AcceptEarlierShipDate
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptEarlierShipDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorToInformField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private creditFailMessageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validProductClassListField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipFromDefaultBinField As ShipFromDefaultBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipFromDefaultBinFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowDuplicateOrderNumbersField As AllowDuplicateOrderNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowDuplicateOrderNumbersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkForCustomerPoNumbersField As CheckForCustomerPoNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkForCustomerPoNumbersFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowInvoiceInformationEntryField As AllowInvoiceInformationEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowInvoiceInformationEntryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUsePriceEnteredField As AlwaysUsePriceEntered
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysUsePriceEnteredFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowZeroPriceField As AllowZeroPrice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowZeroPriceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowChangeToZeroPriceField As AllowChangeToZeroPrice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowChangeToZeroPriceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addStockSalesOrderTextField As AddStockSalesOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addStockSalesOrderTextFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addDangerousGoodsTextField As AddDangerousGoodsText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addDangerousGoodsTextFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useStockDescSuppliedField As UseStockDescSupplied
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useStockDescSuppliedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateShippingInstrsField As ValidateShippingInstrs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateShippingInstrsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionField As AllocationAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addAttachedServiceChargesField As AddAttachedServiceCharges
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addAttachedServiceChargesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusInProcessField As StatusInProcess
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusInProcessFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusInProcessResponseField As StatusInProcessResponse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statusInProcessResponseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnIfCustomerOnHoldField As WarnIfCustomerOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnIfCustomerOnHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptKitOptionalField As AcceptKitOptional
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptKitOptionalFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForPartialHoldField As AllowBackOrderForPartialHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForPartialHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForSupersededField As AllowBackOrderForSuperseded
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForSupersededFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overrideCustomerBackOrderField As OverrideCustomerBackOrder
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private overrideCustomerBackOrderFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useMasterAccountForCustomerPartNoField As UseMasterAccountForCustomerPartNo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useMasterAccountForCustomerPartNoFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyLeadTimeCalculationField As ApplyLeadTimeCalculation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyLeadTimeCalculationFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyParentDiscountToComponentsField As ApplyParentDiscountToComponents
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyParentDiscountToComponentsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowManualOrderNumberToBeUsedField As AllowManualOrderNumberToBeUsed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowManualOrderNumberToBeUsedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockField As ReserveStock
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockRequestAllocsField As ReserveStockRequestAllocs
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reserveStockRequestAllocsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForNegativeMerchLineField As AllowBackOrderForNegativeMerchLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowBackOrderForNegativeMerchLineFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private putEntireQuantityOnNewLoadWhenChangedField As PutEntireQuantityOnNewLoadWhenChanged
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private putEntireQuantityOnNewLoadWhenChangedFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.inBoxMsgReqdField = InBoxMsgReqd.N
            Me.processField = Process.Validate
            Me.typeOfOrderField = TypeOfOrder.ORD
            Me.acceptEarlierShipDateField = AcceptEarlierShipDate.N
            Me.shipFromDefaultBinField = ShipFromDefaultBin.N
            Me.allowDuplicateOrderNumbersField = AllowDuplicateOrderNumbers.N
            Me.allowInvoiceInformationEntryField = AllowInvoiceInformationEntry.N
            Me.alwaysUsePriceEnteredField = AlwaysUsePriceEntered.N
            Me.allowZeroPriceField = AllowZeroPrice.N
            Me.addStockSalesOrderTextField = AddStockSalesOrderText.N
            Me.addDangerousGoodsTextField = AddDangerousGoodsText.N
            Me.useStockDescSuppliedField = UseStockDescSupplied.N
            Me.validateShippingInstrsField = ValidateShippingInstrs.N
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.warnIfCustomerOnHoldField = WarnIfCustomerOnHold.N
            Me.putEntireQuantityOnNewLoadWhenChangedField = PutEntireQuantityOnNewLoadWhenChanged.N
        End Sub
        
        '''<summary>
        '''Write an entry to the ADMMSG file for the logged in operator (N or blank - No, Y - Yes). This message is made available in the Orders Created Externally option of SYSPRO. 
        '''</summary>
        Public Property InBoxMsgReqd() As InBoxMsgReqd
            Get
                Return Me.inBoxMsgReqdField
            End Get
            Set
                Me.inBoxMsgReqdField = value
                Me.InBoxMsgReqdFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InBoxMsgReqdSpecified() As Boolean
            Get
                Return Me.inBoxMsgReqdFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the process to follow (Validate - validate contents only, Import - validate the contents and import only if there are no errors).
        '''
        '''If there are any errors the whole document is returned with all  errors found. The errors will appear at the end of the section in which the error occurred, such as the StockLine section. 
        '''
        '''The last entry in the XML returned from a validation process will be the ValidationStatus element which will have a sub-element of Status. This will contain either Successful or Failed.
        '''</summary>
        Public Property Process() As Process
            Get
                Return Me.processField
            End Get
            Set
                Me.processField = value
                Me.ProcessFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ProcessSpecified() As Boolean
            Get
                Return Me.processFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If no customer code exists in the sales order header and no sender code in the transmission header this becomes a mandatory entry. This must be a valid SYSPRO customer and they must be set as an EDI customer.
        '''</summary>
        Public Property CustomerToUse() As String
            Get
                Return Me.customerToUseField
            End Get
            Set
                Me.customerToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of warehouses to use. If there is no warehouse supplied on the individual stock lines or on the order header, a warehouse will be selected from this list, provided that the stock code is stocked in that warehouse. These are processed from left to right.
        '''</summary>
        Public Property WarehouseListToUse() As String
            Get
                Return Me.warehouseListToUseField
            End Get
            Set
                Me.warehouseListToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''If set to 'Y', then the default warehouse for a stocked line will be taken from the sales warehouse against the customer. If that warehouse is blank, then the normal rules for establishing a warehouse will be followed. A warehouse supplied against the detail line will always take precedence.
        '''</summary>
        Public Property UseCustomerSalesWarehouse() As UseCustomerSalesWarehouse
            Get
                Return Me.useCustomerSalesWarehouseField
            End Get
            Set
                Me.useCustomerSalesWarehouseField = value
                Me.UseCustomerSalesWarehouseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseCustomerSalesWarehouseSpecified() As Boolean
            Get
                Return Me.useCustomerSalesWarehouseFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates which type of order to create. The possible values are ORD - normal order, FWD - forward order, SCH - scheduled order, IBT - inter branch transfer, BIL - billing. If not provided the e.net solutions settings against the operator are used. If this is also not defined, the default is ORD.
        '''</summary>
        Public Property TypeOfOrder() As TypeOfOrder
            Get
                Return Me.typeOfOrderField
            End Get
            Set
                Me.typeOfOrderField = value
                Me.TypeOfOrderFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TypeOfOrderSpecified() As Boolean
            Get
                Return Me.typeOfOrderFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates the status that will be applied to the new order (1, 4,8 or S). If no status is provided the status against this operator in the e.net solutions configuration is used. If this is not present the default of 1 is used. A status of 'S' indicates that the order is to be placed straight into suspense, so that operator activity is required in the SYSPRO system before the order can be released. If the type of order requested is 'BIL' (billing), then this parameter is ignored, and the order status is set to 8 - to invoice.
        '''</summary>
        Public Property OrderStatus() As OrderStatus
            Get
                Return Me.orderStatusField
            End Get
            Set
                Me.orderStatusField = value
                Me.OrderStatusFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OrderStatusSpecified() As Boolean
            Get
                Return Me.orderStatusFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the minimum number of days before an order can be shipped. If this is not supplied the e.net solutions configuration against the operator is used. If this is not present the default is 0.
        '''</summary>
        Public Property MinimumDaysToShip() As String
            Get
                Return Me.minimumDaysToShipField
            End Get
            Set
                Me.minimumDaysToShipField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies whether non-stocked lines are allowed to be entered as detail lines on the sales order (Y - Yes, N - No, S Specify) . If not set this defaults to the e.net solutions setting against the operator. Note that the e.net soltions setting can only be allowed or not allowed. If the element 'AllowNonStockItems' is set to 'S', then a new non-stocked detail line must include the element 'NonStockedLine' with a value of 'Y'.
        '''</summary>
        Public Property AllowNonStockItems() As AllowNonStockItems
            Get
                Return Me.allowNonStockItemsField
            End Get
            Set
                Me.allowNonStockItemsField = value
                Me.AllowNonStockItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowNonStockItemsSpecified() As Boolean
            Get
                Return Me.allowNonStockItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if sales orders are allowed to be accepted if the customer has failed the credit check (Y - Yes, N - No). If not specified this defaults to the e.net solutions settings against the operator.
        '''</summary>
        Public Property AcceptOrdersIfNoCredit() As AcceptOrdersIfNoCredit
            Get
                Return Me.acceptOrdersIfNoCreditField
            End Get
            Set
                Me.acceptOrdersIfNoCreditField = value
                Me.AcceptOrdersIfNoCreditFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AcceptOrdersIfNoCreditSpecified() As Boolean
            Get
                Return Me.acceptOrdersIfNoCreditFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if sales orders are allowed to be accepted if the requested ship date supplied is earlier than the default ship date. Defaults to 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property AcceptEarlierShipDate() As AcceptEarlierShipDate
            Get
                Return Me.acceptEarlierShipDateField
            End Get
            Set
                Me.acceptEarlierShipDateField = value
                Me.AcceptEarlierShipDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AcceptEarlierShipDateSpecified() As Boolean
            Get
                Return Me.acceptEarlierShipDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is the operator to inform when a new order is created. This must be a valid SYSPRO operator code. If not supplied then the "operator to inform about new orders placed" option in the e.net solutions configuration against this operator will be used. If this is not set then the operator who is attempting to create the sales order will be informed.
        '''</summary>
        Public Property OperatorToInform() As String
            Get
                Return Me.operatorToInformField
            End Get
            Set
                Me.operatorToInformField = value
            End Set
        End Property
        
        '''<summary>
        '''The message to be returned if the customer fails the credit check.
        '''</summary>
        Public Property CreditFailMessage() As String
            Get
                Return Me.creditFailMessageField
            End Get
            Set
                Me.creditFailMessageField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of valid product classes for this customer. If this list is supplied, the e.net Product Class Security is ignored.
        '''</summary>
        Public Property ValidProductClassList() As String
            Get
                Return Me.validProductClassListField
            End Get
            Set
                Me.validProductClassListField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies whether stocked lines are to be shipped from the default bin (Y - Yes, N - No). This parameter is only relevant if multiple bins are in use, and the warehouse on the sales order line required multiple bins. If not set and multiple bins are in use, and the warehouse on the sales order line requires multiple bins , then stocked lines will be placed on back order.
        '''</summary>
        Public Property ShipFromDefaultBin() As ShipFromDefaultBin
            Get
                Return Me.shipFromDefaultBinField
            End Get
            Set
                Me.shipFromDefaultBinField = value
                Me.ShipFromDefaultBinFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShipFromDefaultBinSpecified() As Boolean
            Get
                Return Me.shipFromDefaultBinFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether duplicate order numbers are allowed to be entered  (Y - Yes, N - No,  A - Always). There is a SYSPRO option which forces a check for duplicate customer purchase order numbers. An entry of A - Always for this parameter will over-ride the SYSPRO option, and no checks will be made for duplicates at all. If the SYSPRO option is not selected, then this parameter is used to specify if duplicate order numbers are acceptable for the same customer - an entry of Y - Yes will mean that the same order number can be used more than once for a specific customer. If the SYSPRO check is in force, then the only relevant entry is A - Always.
        '''</summary>
        Public Property AllowDuplicateOrderNumbers() As AllowDuplicateOrderNumbers
            Get
                Return Me.allowDuplicateOrderNumbersField
            End Get
            Set
                Me.allowDuplicateOrderNumbersField = value
                Me.AllowDuplicateOrderNumbersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowDuplicateOrderNumbersSpecified() As Boolean
            Get
                Return Me.allowDuplicateOrderNumbersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element controls the checking of customer purchase orders against new orders. If set to 'Y' (the default), then the element 'CustomerPoNumber' must be supplied when adding a sales order. If set to 'N', then the element may be missing, or may be blank. If set to 'C' (customer) then the check is based on the setting of the SYSPRO Customer Maintenance option 'Customer purchase order number mandatory'.
        '''</summary>
        Public Property CheckForCustomerPoNumbers() As CheckForCustomerPoNumbers
            Get
                Return Me.checkForCustomerPoNumbersField
            End Get
            Set
                Me.checkForCustomerPoNumbersField = value
                Me.CheckForCustomerPoNumbersFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CheckForCustomerPoNumbersSpecified() As Boolean
            Get
                Return Me.checkForCustomerPoNumbersFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether invoice information (invoice number and invoice date) may be entered for an order that is defined as ready to invoice, status 8 (Y - Yes, N - No). If set, this overrides any other SYSPRO configuation rules for supplying invoice numbers. 
        '''</summary>
        Public Property AllowInvoiceInformationEntry() As AllowInvoiceInformationEntry
            Get
                Return Me.allowInvoiceInformationEntryField
            End Get
            Set
                Me.allowInvoiceInformationEntryField = value
                Me.AllowInvoiceInformationEntryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowInvoiceInformationEntrySpecified() As Boolean
            Get
                Return Me.allowInvoiceInformationEntryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies that the price supplied on the detail line on the sales order is to be used instead of any price calculated using the SYSPRO configuration parameters(Y - Yes, N - No). 
        '''</summary>
        Public Property AlwaysUsePriceEntered() As AlwaysUsePriceEntered
            Get
                Return Me.alwaysUsePriceEnteredField
            End Get
            Set
                Me.alwaysUsePriceEnteredField = value
                Me.AlwaysUsePriceEnteredFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AlwaysUsePriceEnteredSpecified() As Boolean
            Get
                Return Me.alwaysUsePriceEnteredFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies that the price supplied on the detail line on the sales order may be zero (Y - Yes, N - No). This only applies if the parameter AlwaysUsePriceEntered is set to 'Y'.
        '''</summary>
        Public Property AllowZeroPrice() As AllowZeroPrice
            Get
                Return Me.allowZeroPriceField
            End Get
            Set
                Me.allowZeroPriceField = value
                Me.AllowZeroPriceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowZeroPriceSpecified() As Boolean
            Get
                Return Me.allowZeroPriceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter controls the use of price on a changed merchandise line only. If set to 'Y', and the element 'Price' contains zero, then the price on that line will be changed to zero. Valid entries are 'N' - No, and 'Y' Yes. The default is no.
        '''</summary>
        Public Property AllowChangeToZeroPrice() As AllowChangeToZeroPrice
            Get
                Return Me.allowChangeToZeroPriceField
            End Get
            Set
                Me.allowChangeToZeroPriceField = value
                Me.AllowChangeToZeroPriceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowChangeToZeroPriceSpecified() As Boolean
            Get
                Return Me.allowChangeToZeroPriceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if standard sales order text associated with any stock item is to be added to the sales order with the appropriate merchandise line. The default is N (no text to be added).
        '''</summary>
        Public Property AddStockSalesOrderText() As AddStockSalesOrderText
            Get
                Return Me.addStockSalesOrderTextField
            End Get
            Set
                Me.addStockSalesOrderTextField = value
                Me.AddStockSalesOrderTextFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AddStockSalesOrderTextSpecified() As Boolean
            Get
                Return Me.addStockSalesOrderTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if dangerous goods text associated with any stock item is to be added to the sales order with the appropriate merchandise line. The default is N (no text to be added).
        '''</summary>
        Public Property AddDangerousGoodsText() As AddDangerousGoodsText
            Get
                Return Me.addDangerousGoodsTextField
            End Get
            Set
                Me.addDangerousGoodsTextField = value
                Me.AddDangerousGoodsTextFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AddDangerousGoodsTextSpecified() As Boolean
            Get
                Return Me.addDangerousGoodsTextFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies that the contents of the element StockDescription supplied for an added detail line must be used instead of the description from the Item Master. Valid entries are N - No, and  Y - Yes (default is N)
        '''</summary>
        Public Property UseStockDescSupplied() As UseStockDescSupplied
            Get
                Return Me.useStockDescSuppliedField
            End Get
            Set
                Me.useStockDescSuppliedField = value
                Me.UseStockDescSuppliedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseStockDescSuppliedSpecified() As Boolean
            Get
                Return Me.useStockDescSuppliedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies the validation that must be applied to the shipping instructions (Element 'ShippingInstrs' within 'OrderHeader'). Valid entries are N - No, and Y - Yes. This parameter is only used if the SYSPRO option to use coded shipping instructions is in use. If it is in use, then setting this parameter to Y (Yes) will force the entry in 'ShippingInstrs' to be validated against the table of Shipping Instructions in SYSPRO.
        '''</summary>
        Public Property ValidateShippingInstrs() As ValidateShippingInstrs
            Get
                Return Me.validateShippingInstrsField
            End Get
            Set
                Me.validateShippingInstrsField = value
                Me.ValidateShippingInstrsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateShippingInstrsSpecified() As Boolean
            Get
                Return Me.validateShippingInstrsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether merchandise lines are to be allocated or placed on back order. Valid entries are 'F'  - allocate only if full order quantity is available, 'B' -  place whole line on back order, 'A' - allocate available quantity if less than order quantity, and place the remainder on back order. If blank or not entered, 'F' is assumed. If set to 'B' (Back order), then the parameter 'ShipFromDefaultBin' is ignored. Note that any items which are kit items,  lot traceable or serialised will still be placed on back order.
        '''</summary>
        Public Property AllocationAction() As AllocationAction
            Get
                Return Me.allocationActionField
            End Get
            Set
                Me.allocationActionField = value
                Me.AllocationActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllocationActionSpecified() As Boolean
            Get
                Return Me.allocationActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned, W - warnings will be returned as warnings in the XML returned). An example of a warning is if margin checking is required, and the new or changed merchandise line fails the margin check, you may want the warning supplied.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
                Me.IgnoreWarningsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use of this element affects the processing of service charges attached to a stock code. It is only considered for the addition of a stocked detail line. Valid entries are 'Y' (Yes), add all service charges found, 'N' (No), do not add service charges, 'M' (Mandatory), add only charges which are not marked for review in order entry. Default is 'N'.
        '''</summary>
        Public Property AddAttachedServiceCharges() As AddAttachedServiceCharges
            Get
                Return Me.addAttachedServiceChargesField
            End Get
            Set
                Me.addAttachedServiceChargesField = value
                Me.AddAttachedServiceChargesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AddAttachedServiceChargesSpecified() As Boolean
            Get
                Return Me.addAttachedServiceChargesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter is only intended for use when the business object is called from scripting while processing a sales order with the SYSPRO Sales Order Entry program. It should be set to 'Y' in those circumstances, and will allow the business object to access the sales order that is currently held by SYSPRO. The only activity allowed is to add a line to the order. If this parameter is set to 'Y'  under any other circumstances, then the results will be unpredictable.
        '''</summary>
        Public Property StatusInProcess() As StatusInProcess
            Get
                Return Me.statusInProcessField
            End Get
            Set
                Me.statusInProcessField = value
                Me.StatusInProcessFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StatusInProcessSpecified() As Boolean
            Get
                Return Me.statusInProcessFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the StatusInProcess element is set to 'Y'. If used, it indicates that a full repsonse on the successful processing of the order is required in the output XML.
        '''</summary>
        Public Property StatusInProcessResponse() As StatusInProcessResponse
            Get
                Return Me.statusInProcessResponseField
            End Get
            Set
                Me.statusInProcessResponseField = value
                Me.StatusInProcessResponseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StatusInProcessResponseSpecified() As Boolean
            Get
                Return Me.statusInProcessResponseFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use this element to affect the action taken when a customer is on hold. The default is 'N', which means that an order placed for a customer on hold will be rejected. If set to 'Y', then the fact that a customer is on hold will be treated as a warning, and the setting of the paramter 'IgnoreWarnings' will be used to determine if the order is reported as an error, a warning or accepted.
        '''</summary>
        Public Property WarnIfCustomerOnHold() As WarnIfCustomerOnHold
            Get
                Return Me.warnIfCustomerOnHoldField
            End Get
            Set
                Me.warnIfCustomerOnHoldField = value
                Me.WarnIfCustomerOnHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property WarnIfCustomerOnHoldSpecified() As Boolean
            Get
                Return Me.warnIfCustomerOnHoldFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This option is only relevant if Single Level bills are in use. If set to 'Y' then any stock item that is a kit item, and has optional components will be accepted. If set to 'N' (the default), then it will be rejected. If set to 'E' then any optional component in a kit item will be iexcluded from the kit.
        '''</summary>
        Public Property AcceptKitOptional() As AcceptKitOptional
            Get
                Return Me.acceptKitOptionalField
            End Get
            Set
                Me.acceptKitOptionalField = value
                Me.AcceptKitOptionalFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AcceptKitOptionalSpecified() As Boolean
            Get
                Return Me.acceptKitOptionalFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if a merchandise line is to be accepted in back order for a stock item that has been placed on partial hold. Valid entries are N - No (the default), and 'Y' - Yes
        '''</summary>
        Public Property AllowBackOrderForPartialHold() As AllowBackOrderForPartialHold
            Get
                Return Me.allowBackOrderForPartialHoldField
            End Get
            Set
                Me.allowBackOrderForPartialHoldField = value
                Me.AllowBackOrderForPartialHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowBackOrderForPartialHoldSpecified() As Boolean
            Get
                Return Me.allowBackOrderForPartialHoldFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if a merchandise line is to be accepted in back order for a stock item that has been superseded. Valid entries are N - No (the default), and 'Y' - Yes
        '''</summary>
        Public Property AllowBackOrderForSuperseded() As AllowBackOrderForSuperseded
            Get
                Return Me.allowBackOrderForSupersededField
            End Get
            Set
                Me.allowBackOrderForSupersededField = value
                Me.AllowBackOrderForSupersededFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowBackOrderForSupersededSpecified() As Boolean
            Get
                Return Me.allowBackOrderForSupersededFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies if a merchandise line is to be accepted in back order even if the customer is not allowed back orders. Valid entries are N - No (the default), and 'Y' - Yes
        '''</summary>
        Public Property OverrideCustomerBackOrder() As OverrideCustomerBackOrder
            Get
                Return Me.overrideCustomerBackOrderField
            End Get
            Set
                Me.overrideCustomerBackOrderField = value
                Me.OverrideCustomerBackOrderFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OverrideCustomerBackOrderSpecified() As Boolean
            Get
                Return Me.overrideCustomerBackOrderFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This paramter is used to decide how the element 'CustomersPartNumber' in a merchandise line is checked for a sub-account. If used, it will over-ride the equivalent SYSPRO company option. Valid entries are  N - No the default  - 'CustomersPartNumber' is checked against the stock codes for the customer,  A - Always - always check the stock codes against those for the master account, C - Check - first check the customer stock codes, and if not found, check the stock codes for the master account
        '''</summary>
        Public Property UseMasterAccountForCustomerPartNo() As UseMasterAccountForCustomerPartNo
            Get
                Return Me.useMasterAccountForCustomerPartNoField
            End Get
            Set
                Me.useMasterAccountForCustomerPartNoField = value
                Me.UseMasterAccountForCustomerPartNoFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseMasterAccountForCustomerPartNoSpecified() As Boolean
            Get
                Return Me.useMasterAccountForCustomerPartNoFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Set this element to 'Y'  to apply the lead time calculation to the ship date of a line in a scheduled order where there is insufficient quantity to ship the entire line. This parameter is ignored if the AllocationAction is B - place line in back order. This calculation is not applied if a specfic date is given in the detail line element 'LineShipDate'
        '''</summary>
        Public Property ApplyLeadTimeCalculation() As ApplyLeadTimeCalculation
            Get
                Return Me.applyLeadTimeCalculationField
            End Get
            Set
                Me.applyLeadTimeCalculationField = value
                Me.ApplyLeadTimeCalculationFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyLeadTimeCalculationSpecified() As Boolean
            Get
                Return Me.applyLeadTimeCalculationFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Only applicable to a stocked line that is for a parent of kit type 'K'. If set to 'Y', then any percentage discount specified on that line will be used in each one of the components, and will over-ride any discount calculated on the component price. This only applies when adding a line.
        '''</summary>
        Public Property ApplyParentDiscountToComponents() As ApplyParentDiscountToComponents
            Get
                Return Me.applyParentDiscountToComponentsField
            End Get
            Set
                Me.applyParentDiscountToComponentsField = value
                Me.ApplyParentDiscountToComponentsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyParentDiscountToComponentsSpecified() As Boolean
            Get
                Return Me.applyParentDiscountToComponentsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter allows the company option for adding Sales Order Numbers to be over-ridden. If set to 'Y', then an order number can be given in the SalesOrder element when adding an order. If an order number is supplied, then it must not exist in SYSPRO.
        '''</summary>
        Public Property AllowManualOrderNumberToBeUsed() As AllowManualOrderNumberToBeUsed
            Get
                Return Me.allowManualOrderNumberToBeUsedField
            End Get
            Set
                Me.allowManualOrderNumberToBeUsedField = value
                Me.AllowManualOrderNumberToBeUsedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowManualOrderNumberToBeUsedSpecified() As Boolean
            Get
                Return Me.allowManualOrderNumberToBeUsedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the SO Option to allow reserving of stock is selected. If set to 'Y', then any attempt to allocate stock for a line will result in it being reserved, and not shipped. If set to 'N', then any attempt to allocate stock will result in it being shipped. If the element is not supplied, then the SYSPRO company setting will be used.
        '''</summary>
        Public Property ReserveStock() As ReserveStock
            Get
                Return Me.reserveStockField
            End Get
            Set
                Me.reserveStockField = value
                Me.ReserveStockFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReserveStockSpecified() As Boolean
            Get
                Return Me.reserveStockFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the SO Option to allow reserving of stock is selected, and stock is being reserved not shipped. If set to 'Y', then any lot bin or serial item can only be reserved using the ship rules.  If set to 'N', then a lot , serial or bin item can be reserved as detail allocations are not required. If the element is not supplied, then the SYSPRO company setting will be used.
        '''</summary>
        Public Property ReserveStockRequestAllocs() As ReserveStockRequestAllocs
            Get
                Return Me.reserveStockRequestAllocsField
            End Get
            Set
                Me.reserveStockRequestAllocsField = value
                Me.ReserveStockRequestAllocsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReserveStockRequestAllocsSpecified() As Boolean
            Get
                Return Me.reserveStockRequestAllocsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Allow negative merchandise line to be added with quantity in back order
        '''</summary>
        Public Property AllowBackOrderForNegativeMerchLine() As AllowBackOrderForNegativeMerchLine
            Get
                Return Me.allowBackOrderForNegativeMerchLineField
            End Get
            Set
                Me.allowBackOrderForNegativeMerchLineField = value
                Me.AllowBackOrderForNegativeMerchLineFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowBackOrderForNegativeMerchLineSpecified() As Boolean
            Get
                Return Me.allowBackOrderForNegativeMerchLineFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use this element when Load Planning is in use.  If the quantity on the detail line is changed, should the entire quantity be on a new load, or just the portion not allocated.  Default = N - Only portion not allocated will be on new load. Y - Entire quantity will be put on to new load.
        '''</summary>
        Public Property PutEntireQuantityOnNewLoadWhenChanged() As PutEntireQuantityOnNewLoadWhenChanged
            Get
                Return Me.putEntireQuantityOnNewLoadWhenChangedField
            End Get
            Set
                Me.putEntireQuantityOnNewLoadWhenChangedField = value
                Me.PutEntireQuantityOnNewLoadWhenChangedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PutEntireQuantityOnNewLoadWhenChangedSpecified() As Boolean
            Get
                Return Me.putEntireQuantityOnNewLoadWhenChangedFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Process
        VALIDATE
        IMPORT
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseCustomerSalesWarehouse
        
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
    Public Enum TypeOfOrder
        
        '''<remarks/>
        ORD
        
        '''<remarks/>
        FWD
        
        '''<remarks/>
        SCH
        
        '''<remarks/>
        IBT
        
        '''<remarks/>
        BIL
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ShipFromDefaultBin
        
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
    Public Enum UseStockDescSupplied
        
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
    Public Enum ValidateShippingInstrs
        
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
    Public Enum StatusInProcess
        
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
    Public Enum StatusInProcessResponse
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
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
    Public Enum WarnIfCustomerOnHold
        
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
    Public Enum UseMasterAccountForCustomerPartNo
        
        '''<remarks/>
        N
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReserveStock
        
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
    Public Enum ReserveStockRequestAllocs
        
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
    Public Enum PutEntireQuantityOnNewLoadWhenChanged
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SalesOrders
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters()
            End If
        End Sub
        
        '''<summary>
        '''This contains the parameters
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
