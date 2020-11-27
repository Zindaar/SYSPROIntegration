Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderRequistionSystem.RequisitionEntry.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AcceptGLCodeforStocked
        
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
    Public Enum AllowNonStockedItems
        
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
    Public Enum ActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
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
        Private allowNonStockedItemsField As AllowNonStockedItems
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonStockedItemsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptGLCodeforStockedField As AcceptGLCodeforStocked
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private acceptGLCodeforStockedFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As ActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.allowNonStockedItemsField = AllowNonStockedItems.N
            Me.acceptGLCodeforStockedField = AcceptGLCodeforStocked.N
        End Sub
        
        '''<summary>
        '''Do you wish to allow for non-stocked items ? (N - No, Y - Yes)
        '''If this option is set as 'N" then a non-existent stock code will be rejected.
        '''</summary>
        Public Property AllowNonStockedItems() As AllowNonStockedItems
            Get
                Return Me.allowNonStockedItemsField
            End Get
            Set
                Me.allowNonStockedItemsField = value
                Me.AllowNonStockedItemsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowNonStockedItemsSpecified() As Boolean
            Get
                Return Me.allowNonStockedItemsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Do you wish to add a General Ledger code to the requisition created for a stocked item?  (N - No, Y - Yes) The ledger code added to the requisition is for documentary purposes only, and will not be used by SYSPRO.
        '''</summary>
        Public Property AcceptGLCodeforStocked() As AcceptGLCodeforStocked
            Get
                Return Me.acceptGLCodeforStockedField
            End Get
            Set
                Me.acceptGLCodeforStockedField = value
                Me.AcceptGLCodeforStockedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AcceptGLCodeforStockedSpecified() As Boolean
            Get
                Return Me.acceptGLCodeforStockedFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Add or Change action type (A - Add a requisition, C - Change a requisition)
        '''The ADD action type will automatically generate a new requisition number (assuming requisition auto numbering) for each new requisition. Requisition lines can be added to an existing requisition if an existing requisition number is supplied in the RequisitionNumber element.
        '''The CHANGE action type requires the input of both the RequisitionNumber and RequisitionLine.
        '''</summary>
        Public Property ActionType() As ActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
                Me.ActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ActionTypeSpecified() As Boolean
            Get
                Return Me.actionTypeFieldSpecified
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
    Partial Public Class PostRequisition
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This contains parameters.
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
