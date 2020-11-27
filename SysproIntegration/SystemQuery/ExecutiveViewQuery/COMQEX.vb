Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ExecutiveViewQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum FifoValuation
        
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
    Public Enum IncludeApBalances
        
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
    Public Enum IncludeArBalances
        
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
    Public Enum IncludeBankBalances
        
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
    Public Enum IncludeInventoryValuation
        
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
    Public Enum IncludeOrdersTaken
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludePurchaseOrderValues
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeSalesOrderValues
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeWipValuation
        
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
    Public Enum IncludeSalesByProductClass
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        B
        
        '''<remarks/>
        P
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
        Private includeBankBalancesField As IncludeBankBalances
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApBalancesField As IncludeApBalances
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeArBalancesField As IncludeArBalances
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeOrdersTakenField As IncludeOrdersTaken
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersTakenFromDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ordersTakenToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeInventoryValuationField As IncludeInventoryValuation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fifoValuationField As FifoValuation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWipValuationField As IncludeWipValuation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includePurchaseOrderValuesField As IncludePurchaseOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderProjectPeriodField As PurchaseOrderProjectPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private purchaseOrderProjectDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesOrderValuesField As IncludeSalesOrderValues
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderProjectBasisField As SalesOrderProjectBasis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderProjectBasisFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderProjectPeriodField As SalesOrderProjectPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderProjectPeriodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private salesOrderProjectDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesByProductClassField As IncludeSalesByProductClass
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSalesByProductClassFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLostSalesField As IncludeLostSales
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLostSalesFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lostSalesFromDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lostSalesToDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeBankBalancesField = IncludeBankBalances.Y
            Me.includeApBalancesField = IncludeApBalances.Y
            Me.includeArBalancesField = IncludeArBalances.Y
            Me.includeOrdersTakenField = IncludeOrdersTaken.N
            Me.includeInventoryValuationField = IncludeInventoryValuation.N
            Me.fifoValuationField = FifoValuation.N
            Me.includeWipValuationField = IncludeWipValuation.N
            Me.includePurchaseOrderValuesField = IncludePurchaseOrderValues.N
            Me.purchaseOrderProjectPeriodField = PurchaseOrderProjectPeriod.D
            Me.includeSalesOrderValuesField = IncludeSalesOrderValues.N
            Me.salesOrderProjectBasisField = SalesOrderProjectBasis.O
            Me.salesOrderProjectPeriodField = SalesOrderProjectPeriod.D
            Me.includeSalesByProductClassField = IncludeSalesByProductClass.N
            Me.includeLostSalesField = IncludeLostSales.N
        End Sub
        
        '''<summary>
        '''This element specifies if the bank balance values (per bank) for current period, previous period 1 and previous period 2 are to be included in the returned data. (Y - Yes, N - No) 
        '''</summary>
        Public Property IncludeBankBalances() As IncludeBankBalances
            Get
                Return Me.includeBankBalancesField
            End Get
            Set
                Me.includeBankBalancesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the Accounts Payable balances for current period,previous period 1 and previous period 2 are to be included in the returned data. (Y - Yes, N - No) 
        '''</summary>
        Public Property IncludeApBalances() As IncludeApBalances
            Get
                Return Me.includeApBalancesField
            End Get
            Set
                Me.includeApBalancesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the Accounts Receivable balances for the current period, previous period 1 and previous period 2 are to be included in the returned data. (Y - Yes, N - No)
        '''</summary>
        Public Property IncludeArBalances() As IncludeArBalances
            Get
                Return Me.includeArBalancesField
            End Get
            Set
                Me.includeArBalancesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the values of sales orders added,changed and cancelled during this week, yesterday and today are included in the returned data. (N - No, Y - Yes, D - details) If 'D' is selected then details of the order lines are returned. The selection of order detail lines to be returned is based on the dates supplied in the 'OrdersTakenFromDate' and the 'OrdersTakenToDate'
        '''</summary>
        Public Property IncludeOrdersTaken() As IncludeOrdersTaken
            Get
                Return Me.includeOrdersTakenField
            End Get
            Set
                Me.includeOrdersTakenField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludeOrdersTaken' element. Details of a sales order line will be returned if the transaction date of the sales order line is greater than or equal to the date supplied. If this element is not supplied, or the value of this element is spaces or 0000-00-00, then the date selection will start from the lowest transaction date.
        '''</summary>
        Public Property OrdersTakenFromDate() As String
            Get
                Return Me.ordersTakenFromDateField
            End Get
            Set
                Me.ordersTakenFromDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludeOrdersTaken' element. Details of a sales order line will be returned if the transaction date of the sales order line is less than or equal to the date supplied. If this element is not supplied, or the value of this element is spaces or 0000-00-00, then the date selection will end at the highest transaction date.
        '''</summary>
        Public Property OrdersTakenToDate() As String
            Get
                Return Me.ordersTakenToDateField
            End Get
            Set
                Me.ordersTakenToDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the inventory values, by warehouse, for current period, previous period 1 and previous period 2 are to be included in the returned data. (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeInventoryValuation() As IncludeInventoryValuation
            Get
                Return Me.includeInventoryValuationField
            End Get
            Set
                Me.includeInventoryValuationField = value
            End Set
        End Property
        
        '''<summary>
        '''If you have selected 'Y' against  'IncludeInventoryValuation' then this element determines the method by which the value of inventory is calculated. (N - No, Y - Yes) It is invalid to enter 'Y' unless Fifo valuation is set in the SYSPRO Inventory Setup options.
        '''</summary>
        Public Property FifoValuation() As FifoValuation
            Get
                Return Me.fifoValuationField
            End Get
            Set
                Me.fifoValuationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the values of Work in Progress for the current period, previous period 1 and previous period 2 are to be included in the returned data. (N - No, Y - Yes)
        '''</summary>
        Public Property IncludeWipValuation() As IncludeWipValuation
            Get
                Return Me.includeWipValuationField
            End Get
            Set
                Me.includeWipValuationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the net values ofoutstanding purchase orders are to be included in the returned data. (N - No, Y - Yes, D - Details) .
        '''The data returned consists of 12 values and 12 dates . Details of the purchase orders that make up each of the net values are returned if a 'D' is supplied against this element.   
        '''</summary>
        Public Property IncludePurchaseOrderValues() As IncludePurchaseOrderValues
            Get
                Return Me.includePurchaseOrderValuesField
            End Get
            Set
                Me.includePurchaseOrderValuesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element determines if the outstanding purchase order net values returned represent daily values or monthly values. This element is only relevant if you have entered 'Y' against the 'IncludePurchaseOrderValues' element (D - Daily values, M - Monthly values) .  
        '''</summary>
        Public Property PurchaseOrderProjectPeriod() As PurchaseOrderProjectPeriod
            Get
                Return Me.purchaseOrderProjectPeriodField
            End Get
            Set
                Me.purchaseOrderProjectPeriodField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludePurchaseOrderValues'. If this element is not supplied,  or the value supplied is spaces or 000-00-00, then details of all sales orders will be returned.
        '''If a date is supplied then it must correspond  to the date of one of the twelve periods returned when the 'IncludePurchaseOrderValues' element has a value of 'Y' or 'D'. 
        '''</summary>
        Public Property PurchaseOrderProjectDate() As String
            Get
                Return Me.purchaseOrderProjectDateField
            End Get
            Set
                Me.purchaseOrderProjectDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if the net values of outstanding sales orders are to be included in the returned data. (N -No, Y - Yes, D - Details) The data returned consists of 12 values and 12 dates . Details of the sales orders that make up each of the net values are returned if a 'D' is supplied against this element. Additionally, 
        '''the net values of sales orders, where the customer request date for a given line is before today, are aggregated in 12 buckets in 7-day time periods backwards from yesterday. 
        '''  
        '''</summary>
        Public Property IncludeSalesOrderValues() As IncludeSalesOrderValues
            Get
                Return Me.includeSalesOrderValuesField
            End Get
            Set
                Me.includeSalesOrderValuesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element determines the ageing date to be used when calculating the outstanding  net value of sales orders. It is only relevent if you have entered 'Y' or 'D' against the 'IncludeSalesOrderValues' element. (O - the sales order is aged according to the order date, S - the sales order is aged according to the ship date)
        '''</summary>
        Public Property SalesOrderProjectBasis() As SalesOrderProjectBasis
            Get
                Return Me.salesOrderProjectBasisField
            End Get
            Set
                Me.salesOrderProjectBasisField = value
                Me.SalesOrderProjectBasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SalesOrderProjectBasisSpecified() As Boolean
            Get
                Return Me.salesOrderProjectBasisFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element determines if the outstanding sales order net values returned represent daily values, monthly values or 7-day time buckets. This element is only relevant if you have entered 'Y' or 'D' against the 'IncludeSalesOrderValues' element (D - Daily values, M - Monthly values, 7 - 7-day time buckets) .  
        '''</summary>
        Public Property SalesOrderProjectPeriod() As SalesOrderProjectPeriod
            Get
                Return Me.salesOrderProjectPeriodField
            End Get
            Set
                Me.salesOrderProjectPeriodField = value
                Me.SalesOrderProjectPeriodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SalesOrderProjectPeriodSpecified() As Boolean
            Get
                Return Me.salesOrderProjectPeriodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludeSalesOrderValues'. If this element is not supplied,  or the value supplied is spaces or 000-00-00, then details of all sales orders will be returned.
        '''If a date is supplied then it must correspond  to the date of one of the twelve periods returned when the 'IncludeSalesOrderValues' element has a value of 'Y' or 'D'. 
        '''</summary>
        Public Property SalesOrderProjectDate() As String
            Get
                Return Me.salesOrderProjectDateField
            End Get
            Set
                Me.salesOrderProjectDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies if sales and budgets derived from the Product Class table are to be included in the returned data. (N - No, Y - Yes, B - Branch details, P - Product class details)
        '''</summary>
        Public Property IncludeSalesByProductClass() As IncludeSalesByProductClass
            Get
                Return Me.includeSalesByProductClassField
            End Get
            Set
                Me.includeSalesByProductClassField = value
                Me.IncludeSalesByProductClassFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeSalesByProductClassSpecified() As Boolean
            Get
                Return Me.includeSalesByProductClassFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element specifies if the values of lost sales during this week, yesterday and today are included in the returned data. (N - No, Y - Yes, D - details) If 'D' is selected then details of the lost sales are returned. The selection of lost sales transactions to be returned is based on the dates supplied in the 'LostSalesFromDate' and the 'LostSalesToDate'
        '''</summary>
        Public Property IncludeLostSales() As IncludeLostSales
            Get
                Return Me.includeLostSalesField
            End Get
            Set
                Me.includeLostSalesField = value
                Me.IncludeLostSalesFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeLostSalesSpecified() As Boolean
            Get
                Return Me.includeLostSalesFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludeLostSales' element. Details of a lost sale will be returned if the transaction date of the lost sale transaction is greater than or equal to the date supplied. If this element is not supplied, or the value of this element is spaces or 0000-00-00, then the date selection will start from the lowest transaction date.
        '''</summary>
        Public Property LostSalesFromDate() As String
            Get
                Return Me.lostSalesFromDateField
            End Get
            Set
                Me.lostSalesFromDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is only relevant if a 'D' has been supplied against the 'IncludeLostSales' element. Details of a lost sale will be returned if the transaction date of the lost sale transaction is less than or equal to the date supplied. If this element is not supplied, or the value of this element is spaces or 0000-00-00, then the date selection will end at the highest transaction date.
        '''</summary>
        Public Property LostSalesToDate() As String
            Get
                Return Me.lostSalesToDateField
            End Get
            Set
                Me.lostSalesToDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The stylesheet to be applied.
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
    Public Enum PurchaseOrderProjectPeriod
        
        '''<remarks/>
        D
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SalesOrderProjectBasis
        
        '''<remarks/>
        O
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SalesOrderProjectPeriod
        
        '''<remarks/>
        D
        
        '''<remarks/>
        M
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("7")>  _
        Item7
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeLostSales
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
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
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
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
        End Sub
        
        '''<summary>
        '''This is the top element for all options available in the query.
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
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
                Return "COMQEX"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
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
            If (blnThrowExceptionOnErrorInXMLOut = true) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
