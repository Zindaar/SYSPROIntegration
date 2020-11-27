Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.ChangeSalesOrderStatus.Params
    
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
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowInvoiceInformationEntryField As AllowInvoiceInformationEntry
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowInvoiceInformationEntryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnIfCustomerOnHoldField As WarnIfCustomerOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warnIfCustomerOnHoldFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.inBoxMsgReqdField = InBoxMsgReqd.N
            Me.validateOnlyField = ValidateOnly.Y
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.allowInvoiceInformationEntryField = AllowInvoiceInformationEntry.N
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
        '''This element indicates whether or not the contents of a change request should be validated  only. If so, it will be returned with errors listed as  found. The errors will appear after the element that caused the error. 
        '''
        '''Just prior to the closing of the root element will be ValidationStatus element which will have a sub-element of Status. This will contain either Successful or Failed.
        '''
        ''' If it is not supplied, it defaults to 'Y'. Valid values are 'N' and 'Y'.
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
        
        '''<summary>
        '''Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned, W - warnings will be returned as warnings in the XML returned).
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
        '''Specifies whether invoice information (invoice number and invoice date) may be entered for an order that is to be changed to ready to invoice, status 8 (Y - Yes, N - No). If set, this overrides any other SYSPRO configuration rules for supplying invoice numbers. 
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
        
        Public Property ApplyIfEntireDocumentValid() As ParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
                Me.ApplyIfEntireDocumentValidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use this element to affect the action taken when a customer is on hold. The default is 'N', which means that an order placed for a customer on hold will be rejected. If set to 'N', then the fact that a customer is on hold will be treated as a warning, and the setting of the paramter 'IgnoreWarnings' will be used to determine if the order is reported as an error, a warning or accepted.
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
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InBoxMsgReqd
        
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
    Public Enum ValidateOnly
        
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
    Public Enum AllowInvoiceInformationEntry
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostSorOrderStatus
        
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
