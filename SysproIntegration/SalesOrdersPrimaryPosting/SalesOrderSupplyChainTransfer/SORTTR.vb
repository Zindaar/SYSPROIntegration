Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.SalesOrderSupplyChainTransfer.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSalesOrdersSCT
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostSalesOrdersSCTParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostSalesOrdersSCTParameters
            End If
        End Sub
        
        Public Property Parameters() As PostSalesOrdersSCTParameters
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
    Partial Public Class PostSalesOrdersSCTParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private targetWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipFromDefaultBinField As PostSalesOrdersSCTParametersShipFromDefaultBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipFromDefaultBinFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addStockSalesOrderTextField As PostSalesOrdersSCTParametersAddStockSalesOrderText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addDangerousGoodsTextField As PostSalesOrdersSCTParametersAddDangerousGoodsText
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionField As PostSalesOrdersSCTParametersAllocationAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allocationActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostSalesOrdersSCTParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostSalesOrdersSCTParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostSalesOrdersSCTParametersIgnoreWarnings
        
        Public Sub New()
            MyBase.New
            Me.addStockSalesOrderTextField = PostSalesOrdersSCTParametersAddStockSalesOrderText.N
            Me.addDangerousGoodsTextField = PostSalesOrdersSCTParametersAddDangerousGoodsText.N
            Me.applyIfEntireDocumentValidField = PostSalesOrdersSCTParametersApplyIfEntireDocumentValid.N
            Me.validateOnlyField = PostSalesOrdersSCTParametersValidateOnly.N
            Me.ignoreWarningsField = PostSalesOrdersSCTParametersIgnoreWarnings.N
        End Sub
        
        Public Property SourceWarehouse() As String
            Get
                Return Me.sourceWarehouseField
            End Get
            Set
                Me.sourceWarehouseField = value
            End Set
        End Property
        
        Public Property TargetWarehouse() As String
            Get
                Return Me.targetWarehouseField
            End Get
            Set
                Me.targetWarehouseField = value
            End Set
        End Property
        
        Public Property ShipFromDefaultBin() As PostSalesOrdersSCTParametersShipFromDefaultBin
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
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrdersSCTParametersAddStockSalesOrderText.N)>  _
        Public Property AddStockSalesOrderText() As PostSalesOrdersSCTParametersAddStockSalesOrderText
            Get
                Return Me.addStockSalesOrderTextField
            End Get
            Set
                Me.addStockSalesOrderTextField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrdersSCTParametersAddDangerousGoodsText.N)>  _
        Public Property AddDangerousGoodsText() As PostSalesOrdersSCTParametersAddDangerousGoodsText
            Get
                Return Me.addDangerousGoodsTextField
            End Get
            Set
                Me.addDangerousGoodsTextField = value
            End Set
        End Property
        
        Public Property AllocationAction() As PostSalesOrdersSCTParametersAllocationAction
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
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrdersSCTParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As PostSalesOrdersSCTParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrdersSCTParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostSalesOrdersSCTParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSalesOrdersSCTParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostSalesOrdersSCTParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersShipFromDefaultBin
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersAddStockSalesOrderText
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersAddDangerousGoodsText
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersAllocationAction
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersApplyIfEntireDocumentValid
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersValidateOnly
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSalesOrdersSCTParametersIgnoreWarnings
        
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
End Namespace
