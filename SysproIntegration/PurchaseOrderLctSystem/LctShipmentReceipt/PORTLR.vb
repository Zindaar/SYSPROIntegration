Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderLctSystem.LctShipmentReceipt.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostLandedCostReceipts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostLandedCostReceiptsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostLandedCostReceiptsParameters
            End If
        End Sub
        
        Public Property Parameters() As PostLandedCostReceiptsParameters
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
    Partial Public Class PostLandedCostReceiptsParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostLandedCostReceiptsParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedWhToUseField As PostLandedCostReceiptsParametersNonStockedWhToUse
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostLandedCostReceiptsParametersValidateOnly
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = PostLandedCostReceiptsParametersIgnoreWarnings.N
            Me.validateOnlyField = PostLandedCostReceiptsParametersValidateOnly.N
            If (Me.nonStockedWhToUseField Is Nothing) Then
                Me.nonStockedWhToUseField = New PostLandedCostReceiptsParametersNonStockedWhToUse
            End If
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostLandedCostReceiptsParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostLandedCostReceiptsParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        Public Property NonStockedWhToUse() As PostLandedCostReceiptsParametersNonStockedWhToUse
            Get
                Return Me.nonStockedWhToUseField
            End Get
            Set
                Me.nonStockedWhToUseField = value
            End Set
        End Property
        
        Public Property ValidateOnly() As PostLandedCostReceiptsParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostLandedCostReceiptsParametersNonStockedWhToUse
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostLandedCostReceiptsParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
