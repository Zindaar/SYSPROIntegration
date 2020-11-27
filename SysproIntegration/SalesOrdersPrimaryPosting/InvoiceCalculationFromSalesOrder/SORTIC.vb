Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.InvoiceCalculationFromSalesOrder.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSalesOrderInvoice
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostSalesOrderInvoiceParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostSalesOrderInvoiceParameters
            End If
        End Sub
        
        Public Property Parameters() As PostSalesOrderInvoiceParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSalesOrderInvoiceParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private orderTypeField As PostSalesOrderInvoiceParametersOrderType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostSalesOrderInvoiceParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostSalesOrderInvoiceParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostSalesOrderInvoiceParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostSalesOrderInvoiceParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateAllLinesField As PostSalesOrderInvoiceParametersValidateAllLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceOnlyIfMerchLinesField As PostSalesOrderInvoiceParametersInvoiceOnlyIfMerchLines
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private invoiceChgWithoutMerchLineField As PostSalesOrderInvoiceParametersInvoiceChgWithoutMerchLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updateStatusWhenNoInvoiceField As PostSalesOrderInvoiceParametersUpdateStatusWhenNoInvoice
        
        Public Sub New()
            MyBase.New
            Me.orderTypeField = PostSalesOrderInvoiceParametersOrderType.I
            Me.postingPeriodField = PostSalesOrderInvoiceParametersPostingPeriod.C
            Me.ignoreWarningsField = PostSalesOrderInvoiceParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostSalesOrderInvoiceParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostSalesOrderInvoiceParametersValidateOnly.N
            Me.validateAllLinesField = PostSalesOrderInvoiceParametersValidateAllLines.N
            Me.invoiceOnlyIfMerchLinesField = PostSalesOrderInvoiceParametersInvoiceOnlyIfMerchLines.N
            Me.invoiceChgWithoutMerchLineField = PostSalesOrderInvoiceParametersInvoiceChgWithoutMerchLine.Y
            Me.updateStatusWhenNoInvoiceField = PostSalesOrderInvoiceParametersUpdateStatusWhenNoInvoice.N
        End Sub
        
        Public Property InvoiceDate() As String
            Get
                Return Me.invoiceDateField
            End Get
            Set
                Me.invoiceDateField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersOrderType.I)>  _
        Public Property OrderType() As PostSalesOrderInvoiceParametersOrderType
            Get
                Return Me.orderTypeField
            End Get
            Set
                Me.orderTypeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostSalesOrderInvoiceParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostSalesOrderInvoiceParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostSalesOrderInvoiceParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostSalesOrderInvoiceParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersValidateAllLines.N)>  _
        Public Property ValidateAllLines() As PostSalesOrderInvoiceParametersValidateAllLines
            Get
                Return Me.validateAllLinesField
            End Get
            Set
                Me.validateAllLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersInvoiceOnlyIfMerchLines.N)>  _
        Public Property InvoiceOnlyIfMerchLines() As PostSalesOrderInvoiceParametersInvoiceOnlyIfMerchLines
            Get
                Return Me.invoiceOnlyIfMerchLinesField
            End Get
            Set
                Me.invoiceOnlyIfMerchLinesField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersInvoiceChgWithoutMerchLine.Y)>  _
        Public Property InvoiceChgWithoutMerchLine() As PostSalesOrderInvoiceParametersInvoiceChgWithoutMerchLine
            Get
                Return Me.invoiceChgWithoutMerchLineField
            End Get
            Set
                Me.invoiceChgWithoutMerchLineField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrderInvoiceParametersUpdateStatusWhenNoInvoice.N)>  _
        Public Property UpdateStatusWhenNoInvoice() As PostSalesOrderInvoiceParametersUpdateStatusWhenNoInvoice
            Get
                Return Me.updateStatusWhenNoInvoiceField
            End Get
            Set
                Me.updateStatusWhenNoInvoiceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersOrderType
        
        '''<remarks/>
        I
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersPostingPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersIgnoreWarnings
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersValidateAllLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersInvoiceOnlyIfMerchLines
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersInvoiceChgWithoutMerchLine
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrderInvoiceParametersUpdateStatusWhenNoInvoice
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
