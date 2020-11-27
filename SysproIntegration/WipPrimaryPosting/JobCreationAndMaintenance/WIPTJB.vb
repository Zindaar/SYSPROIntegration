Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipPrimaryPosting.JobCreationAndMaintenance.Params
    
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
        
        '''<remarks/>
        P
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
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
        Private actionTypeField As ActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private snapshotField As Snapshot
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private snapshotFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private triggerApsField As ParametersTriggerAps
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentWhRouteField As ParametersUseParentWhRoute
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useParentCompWhField As ParametersUseParentCompWh
        
        Public Sub New()
            MyBase.New
            Me.actionTypeField = ActionType.A
            Me.validateOnlyField = ValidateOnly.N
            Me.applyIfEntireDocumentValidField = ParametersApplyIfEntireDocumentValid.N
            Me.snapshotField = Snapshot.N
            Me.triggerApsField = ParametersTriggerAps.Y
            Me.useParentWhRouteField = ParametersUseParentWhRoute.N
            Me.useParentCompWhField = ParametersUseParentCompWh.N
        End Sub
        
        '''<summary>
        '''Specifies whether to add update copy or delete jobs (A - add,  C - update,  P - copy,  D - delete). Only live jobs can be added and you cannot do a copy when in snapshot.
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
        
        '''<summary>
        '''Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document).
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
                Me.ValidateOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ParametersApplyIfEntireDocumentValid.N)>  _
        Public Property ApplyIfEntireDocumentValid() As ParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        '''<summary>
        '''Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a ledger code entered is not the correct type of account, it is okay to write the record away as such but you may want the warning supplied.
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
        '''Specifies whether maintaining a live, suggested or snapshot job (N -  live, Y - snapshot, S- suggested) 
        '''</summary>
        Public Property Snapshot() As Snapshot
            Get
                Return Me.snapshotField
            End Get
            Set
                Me.snapshotField = value
                Me.SnapshotFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SnapshotSpecified() As Boolean
            Get
                Return Me.snapshotFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies APS will be triggered or not. (Y - Trigger APS, N - will not trigger APS).
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(ParametersTriggerAps.Y)>  _
        Public Property TriggerAps() As ParametersTriggerAps
            Get
                Return Me.triggerApsField
            End Get
            Set
                Me.triggerApsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ParametersUseParentWhRoute.N)>  _
        Public Property UseParentWhRoute() As ParametersUseParentWhRoute
            Get
                Return Me.useParentWhRouteField
            End Get
            Set
                Me.useParentWhRouteField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(ParametersUseParentCompWh.N)>  _
        Public Property UseParentCompWh() As ParametersUseParentCompWh
            Get
                Return Me.useParentCompWhField
            End Get
            Set
                Me.useParentCompWhField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersApplyIfEntireDocumentValid
        
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
    Public Enum Snapshot
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersTriggerAps
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersUseParentWhRoute
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersUseParentCompWh
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostJob
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This element contains the optional parameter elements.
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TriggerAps
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
