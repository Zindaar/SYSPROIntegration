Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryStockTakeSystem.ConfirmStockTake.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostStockTakeConfirmation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostStockTakeConfirmationParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostStockTakeConfirmationParameters
            End If
        End Sub
        
        Public Property Parameters() As PostStockTakeConfirmationParameters
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
    Partial Public Class PostStockTakeConfirmationParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostStockTakeConfirmationParametersPostingPeriod
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostStockTakeConfirmationParametersPostingPeriod.C
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostStockTakeConfirmationParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostStockTakeConfirmationParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostStockTakeConfirmationParametersPostingPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
    End Enum
End Namespace
