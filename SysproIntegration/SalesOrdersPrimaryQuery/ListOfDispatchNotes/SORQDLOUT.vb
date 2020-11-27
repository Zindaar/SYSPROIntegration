Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.ListOfDispatchNotes.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DispatchNoteList
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dispatchNoteItemField As List(Of DispatchNoteListDispatchNoteItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        Public Sub New()
            MyBase.New
            If (Me.dispatchNoteItemField Is Nothing) Then
                Me.dispatchNoteItemField = New List(Of DispatchNoteListDispatchNoteItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("DispatchNoteItem")>  _
        Public Property DispatchNoteItemCollection() As List(Of DispatchNoteListDispatchNoteItem)
            Get
                Return Me.dispatchNoteItemField
            End Get
            Set
                Me.dispatchNoteItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Language() As SByte
            Get
                Return Me.languageField
            End Get
            Set(ByVal value As SByte)
                Me.languageField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property DecFormat() As Boolean
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property DateFormat() As SByte
            Get
                Return Me.dateFormatField
            End Get
            Set(ByVal value As SByte)
                Me.dateFormatField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute(), _
        CLSCompliant(False)> _
        Public Property Role() As SByte
            Get
                Return Me.roleField
            End Get
            Set(ByVal value As SByte)
                Me.roleField = Value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of Object)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsElementNameField As List(Of ItemsChoiceType)
        
        Public Sub New()
            MyBase.New
            If (Me.itemsElementNameField Is Nothing) Then
                Me.itemsElementNameField = New List(Of ItemsChoiceType)
            End If
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of Object)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("ActualDeliveryDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Area", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Branch", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CompanyTaxNo", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ConsolidateInvFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CountyZip", GetType(DispatchNoteListDispatchNoteItemCountyZip)),  _
         System.Xml.Serialization.XmlElementAttribute("CreditAuthority", GetType(DispatchNoteListDispatchNoteItemCreditAuthority)),  _
         System.Xml.Serialization.XmlElementAttribute("Currency", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Customer", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomerName", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("CustomerPoNumber", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", GetType(DispatchNoteListDispatchNoteItemDeliveryTerms)),  _
         System.Xml.Serialization.XmlElementAttribute("Description", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DiscPct1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DiscPct2", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DiscPct3", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchAddress1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchAddress2", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchAddress3", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchAddress4", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchAddress5", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchComments1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchComments2", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchComments3", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchComments4", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchCustName", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchName", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchNote", GetType(DispatchNoteListDispatchNoteItemDispatchNote)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchNoteStatus", GetType(SByte)),  _
         System.Xml.Serialization.XmlElementAttribute("DispatchPostalCode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ExchangeRate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ExtendedTaxCode", GetType(DispatchNoteListDispatchNoteItemExtendedTaxCode)),  _
         System.Xml.Serialization.XmlElementAttribute("FixExchangeRate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("GtrReference", GetType(DispatchNoteListDispatchNoteItemGtrReference)),  _
         System.Xml.Serialization.XmlElementAttribute("InvTermsOverride", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Invoice", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("InvoiceCreatedDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("LastOperator", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MulDiv", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("MultiShipCode", GetType(DispatchNoteListDispatchNoteItemMultiShipCode)),  _
         System.Xml.Serialization.XmlElementAttribute("Nationality", GetType(DispatchNoteListDispatchNoteItemNationality)),  _
         System.Xml.Serialization.XmlElementAttribute("NextDetailLine", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("OrderType", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("PlannedDeliverDate", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("PrevStatus", GetType(SByte)),  _
         System.Xml.Serialization.XmlElementAttribute("ProcessFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Quote", GetType(DispatchNoteListDispatchNoteItemQuote)),  _
         System.Xml.Serialization.XmlElementAttribute("Reason", GetType(DispatchNoteListDispatchNoteItemReason)),  _
         System.Xml.Serialization.XmlElementAttribute("ReprintFormat", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SalesOrder", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("Salesperson", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShipAddressFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("ShippingInstrs", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SourceWarehouse", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("SpecialInstrs", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("State", GetType(DispatchNoteListDispatchNoteItemState)),  _
         System.Xml.Serialization.XmlElementAttribute("StatusWhenHeld", GetType(SByte)),  _
         System.Xml.Serialization.XmlElementAttribute("TargetWarehouse", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TaxExemptFlag", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TaxExemptNumber", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TaxExemptOverride", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TransactionNature", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("TransportMode", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("UserField1", GetType(String)),  _
         System.Xml.Serialization.XmlElementAttribute("UserField2", GetType(String)),  _
         System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")>  _
        Public Property ItemsCollection() As List(Of Object)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute("ItemsElementName"),  _
         System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property ItemsElementNameCollection() As List(Of ItemsChoiceType)
            Get
                Return Me.itemsElementNameField
            End Get
            Set
                Me.itemsElementNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemCountyZip
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemCreditAuthority
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemDeliveryTerms
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum DispatchNoteListDispatchNoteItemDispatchNote
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000001")>  _
        Item000000000000001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000002")>  _
        Item000000000000002
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000003")>  _
        Item000000000000003
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000004")>  _
        Item000000000000004
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000005")>  _
        Item000000000000005
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000006")>  _
        Item000000000000006
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000007")>  _
        Item000000000000007
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000008")>  _
        Item000000000000008
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000009")>  _
        Item000000000000009
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000010")>  _
        Item000000000000010
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000011")>  _
        Item000000000000011
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000000000000012")>  _
        Item000000000000012
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000018/0001")>  _
        Item0000180001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000019/0001")>  _
        Item0000190001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000020/0001")>  _
        Item0000200001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000035/0001")>  _
        Item0000350001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000035/0002")>  _
        Item0000350002
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000035/0003")>  _
        Item0000350003
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000038/0001")>  _
        Item0000380001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000060/00000001")>  _
        Item00006000000001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000061/00000001")>  _
        Item00006100000001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000062/00000001")>  _
        Item00006200000001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000065/00000001")>  _
        Item00006500000001
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000065/00000002")>  _
        Item00006500000002
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("000066/00000001")>  _
        Item00006600000001
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemExtendedTaxCode
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemGtrReference
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemMultiShipCode
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum DispatchNoteListDispatchNoteItemNationality
        
        '''<remarks/>
        CAN
        
        '''<remarks/>
        GB
        
        '''<remarks/>
        RSA
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemQuote
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemReason
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class DispatchNoteListDispatchNoteItemState
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema:=false)>  _
    Public Enum ItemsChoiceType
        
        '''<remarks/>
        ActualDeliveryDate
        
        '''<remarks/>
        Area
        
        '''<remarks/>
        Branch
        
        '''<remarks/>
        CompanyTaxNo
        
        '''<remarks/>
        ConsolidateInvFlag
        
        '''<remarks/>
        CountyZip
        
        '''<remarks/>
        CreditAuthority
        
        '''<remarks/>
        Currency
        
        '''<remarks/>
        Customer
        
        '''<remarks/>
        CustomerName
        
        '''<remarks/>
        CustomerPoNumber
        
        '''<remarks/>
        DeliveryTerms
        
        '''<remarks/>
        Description
        
        '''<remarks/>
        DiscPct1
        
        '''<remarks/>
        DiscPct2
        
        '''<remarks/>
        DiscPct3
        
        '''<remarks/>
        DispatchAddress1
        
        '''<remarks/>
        DispatchAddress2
        
        '''<remarks/>
        DispatchAddress3
        
        '''<remarks/>
        DispatchAddress4
        
        '''<remarks/>
        DispatchAddress5
        
        '''<remarks/>
        DispatchComments1
        
        '''<remarks/>
        DispatchComments2
        
        '''<remarks/>
        DispatchComments3
        
        '''<remarks/>
        DispatchComments4
        
        '''<remarks/>
        DispatchCustName
        
        '''<remarks/>
        DispatchName
        
        '''<remarks/>
        DispatchNote
        
        '''<remarks/>
        DispatchNoteStatus
        
        '''<remarks/>
        DispatchPostalCode
        
        '''<remarks/>
        ExchangeRate
        
        '''<remarks/>
        ExtendedTaxCode
        
        '''<remarks/>
        FixExchangeRate
        
        '''<remarks/>
        GtrReference
        
        '''<remarks/>
        InvTermsOverride
        
        '''<remarks/>
        Invoice
        
        '''<remarks/>
        InvoiceCreatedDate
        
        '''<remarks/>
        LastOperator
        
        '''<remarks/>
        MulDiv
        
        '''<remarks/>
        MultiShipCode
        
        '''<remarks/>
        Nationality
        
        '''<remarks/>
        NextDetailLine
        
        '''<remarks/>
        OrderType
        
        '''<remarks/>
        PlannedDeliverDate
        
        '''<remarks/>
        PrevStatus
        
        '''<remarks/>
        ProcessFlag
        
        '''<remarks/>
        Quote
        
        '''<remarks/>
        Reason
        
        '''<remarks/>
        ReprintFormat
        
        '''<remarks/>
        SalesOrder
        
        '''<remarks/>
        Salesperson
        
        '''<remarks/>
        ShipAddressFlag
        
        '''<remarks/>
        ShippingInstrs
        
        '''<remarks/>
        SourceWarehouse
        
        '''<remarks/>
        SpecialInstrs
        
        '''<remarks/>
        State
        
        '''<remarks/>
        StatusWhenHeld
        
        '''<remarks/>
        TargetWarehouse
        
        '''<remarks/>
        TaxExemptFlag
        
        '''<remarks/>
        TaxExemptNumber
        
        '''<remarks/>
        TaxExemptOverride
        
        '''<remarks/>
        TransactionNature
        
        '''<remarks/>
        TransportMode
        
        '''<remarks/>
        UserField1
        
        '''<remarks/>
        UserField2
    End Enum
End Namespace
