Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderSupplierContracts.PurchaseOrderSupplierContract.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSupplierContract
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostSupplierContractParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostSupplierContractParameters()
            End If
        End Sub
        
        Public Property Parameters() As PostSupplierContractParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostSupplierContractParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostSupplierContractParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSupplierStockCodeField As PostSupplierContractParametersUseSupplierStockCode
        
        Public Sub New()
            MyBase.New
            Me.validateOnlyField = PostSupplierContractParametersValidateOnly.N
            Me.useSupplierStockCodeField = PostSupplierContractParametersUseSupplierStockCode.N
        End Sub
        
        Public Property IgnoreWarnings() As String
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        Public Property ApplyIfEntireDocumentValid() As String
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSupplierContractParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostSupplierContractParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostSupplierContractParametersUseSupplierStockCode.N)>  _
        Public Property UseSupplierStockCode() As PostSupplierContractParametersUseSupplierStockCode
            Get
                Return Me.useSupplierStockCodeField
            End Get
            Set
                Me.useSupplierStockCodeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSupplierContractParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostSupplierContractParametersUseSupplierStockCode
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
