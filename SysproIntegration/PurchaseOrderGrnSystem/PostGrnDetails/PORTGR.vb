Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrderGrnSystem.PostGrnDetails.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyIfEntireDocumentValid
        
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
    Public Enum IgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
    End Enum
    
    ''''<remarks/>
    '<System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
    ' System.SerializableAttribute(),  _
    ' System.Diagnostics.DebuggerStepThroughAttribute(),  _
    ' System.ComponentModel.DesignerCategoryAttribute("code"),  _
    ' System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
    ' System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    'Partial Public Class Parameters

    '    <EditorBrowsable(EditorBrowsableState.Never)>  _
    '    Private postingPeriodField As ParametersPostingPeriod

    '    <EditorBrowsable(EditorBrowsableState.Never)>  _
    '    Private ignoreWarningsField As ParametersIgnoreWarnings

    '    <EditorBrowsable(EditorBrowsableState.Never)>  _
    '    Private applyIfEntireDocumentValidField As ParametersApplyIfEntireDocumentValid

    '    <EditorBrowsable(EditorBrowsableState.Never)>  _
    '    Private validateOnlyField As ParametersValidateOnly

    '    Public Sub New()
    '        MyBase.New
    '        Me.postingPeriodField = ParametersPostingPeriod.C
    '        Me.ignoreWarningsField = ParametersIgnoreWarnings.N
    '        Me.applyIfEntireDocumentValidField = ParametersApplyIfEntireDocumentValid.Y
    '        Me.validateOnlyField = ParametersValidateOnly.N
    '    End Sub

    '    '''<summary>
    '    '''Period to which transactions must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2).
    '    '''If the Inventory module is not installed, transactions can only be posted to the current period.
    '    '''</summary>
    '    <System.ComponentModel.DefaultValueAttribute(ParametersPostingPeriod.C)>  _
    '    Public Property PostingPeriod() As ParametersPostingPeriod
    '        Get
    '            Return Me.postingPeriodField
    '        End Get
    '        Set
    '            Me.postingPeriodField = value
    '        End Set
    '    End Property

    '    '''<summary>
    '    '''This element indicates whether or not a transaction must be rejected if there are any warnings. If 'W' supplied, these errors will be reported as warnings. If it is not supplied, it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
    '    '''</summary>
    '    <System.ComponentModel.DefaultValueAttribute(ParametersIgnoreWarnings.N)>  _
    '    Public Property IgnoreWarnings() As ParametersIgnoreWarnings
    '        Get
    '            Return Me.ignoreWarningsField
    '        End Get
    '        Set
    '            Me.ignoreWarningsField = value
    '        End Set
    '    End Property

    '    '''<summary>
    '    '''This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
    '    '''</summary>
    '    <System.ComponentModel.DefaultValueAttribute(ParametersApplyIfEntireDocumentValid.Y)>  _
    '    Public Property ApplyIfEntireDocumentValid() As ParametersApplyIfEntireDocumentValid
    '        Get
    '            Return Me.applyIfEntireDocumentValidField
    '        End Get
    '        Set
    '            Me.applyIfEntireDocumentValidField = value
    '        End Set
    '    End Property

    '    '''<summary>
    '    '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
    '    '''</summary>
    '    <System.ComponentModel.DefaultValueAttribute(ParametersValidateOnly.N)>  _
    '    Public Property ValidateOnly() As ParametersValidateOnly
    '        Get
    '            Return Me.validateOnlyField
    '        End Get
    '        Set
    '            Me.validateOnlyField = value
    '        End Set
    '    End Property
    'End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersPostingPeriod
        
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
    Public Enum ParametersIgnoreWarnings
        
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
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum ParametersValidateOnly
        
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
    Partial Public Class PostGrnDetails
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostGrnDetailsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostGrnDetailsParameters
            End If
        End Sub
        
        '''<summary>
        '''This contains parameters.
        '''</summary>
        Public Property Parameters() As PostGrnDetailsParameters
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
    Partial Public Class PostGrnDetailsParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private postingPeriodField As PostGrnDetailsParametersPostingPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostGrnDetailsParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostGrnDetailsParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostGrnDetailsParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alwaysSupplyGrnNumbersField As PostGrnDetailsParametersAlwaysSupplyGrnNumbers
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private checkForDuplicateGrnsField As PostGrnDetailsParametersCheckForDuplicateGrns
        
        Public Sub New()
            MyBase.New
            Me.postingPeriodField = PostGrnDetailsParametersPostingPeriod.C
            Me.ignoreWarningsField = PostGrnDetailsParametersIgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = PostGrnDetailsParametersApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = PostGrnDetailsParametersValidateOnly.N
            Me.alwaysSupplyGrnNumbersField = PostGrnDetailsParametersAlwaysSupplyGrnNumbers.Y
            Me.checkForDuplicateGrnsField = PostGrnDetailsParametersCheckForDuplicateGrns.Y
        End Sub
        
        '''<summary>
        '''Period to which transactions must be posted. Valid values are 'C' for current period, 'P' for previous period and 'B' for before previous period (i.e. prior period 2).
        '''If the Inventory module is not installed, transactions can only be posted to the current period.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersPostingPeriod.C)>  _
        Public Property PostingPeriod() As PostGrnDetailsParametersPostingPeriod
            Get
                Return Me.postingPeriodField
            End Get
            Set
                Me.postingPeriodField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings. If 'W' supplied, these errors will be reported as warnings. If it is not supplied, it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersIgnoreWarnings.N)>  _
        Public Property IgnoreWarnings() As PostGrnDetailsParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersApplyIfEntireDocumentValid.Y)>  _
        Public Property ApplyIfEntireDocumentValid() As PostGrnDetailsParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersValidateOnly.N)>  _
        Public Property ValidateOnly() As PostGrnDetailsParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether GRN numbers must be supplied or not, regardless of GRN numbering settings in SYSPRO. If set to 'N', the SYSPRO GRN numbering rules are followed and if GRN numbering is set to 'Maunal', the GRN number must still be supplied. If set to 'Y', then 'GrnNumber' is mandatory.
        '''Default value is 'Y'.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersAlwaysSupplyGrnNumbers.Y)>  _
        Public Property AlwaysSupplyGrnNumbers() As PostGrnDetailsParametersAlwaysSupplyGrnNumbers
            Get
                Return Me.alwaysSupplyGrnNumbersField
            End Get
            Set
                Me.alwaysSupplyGrnNumbersField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether GRN number must be checked for duplicates.
        '''However, if set to 'Y' and the SYSPRO setup option to check for duplicate GRNs is set to 'N', this parameter is ignored because there is no GRN duplicates file to check aganist.
        '''</summary>
        <System.ComponentModel.DefaultValueAttribute(PostGrnDetailsParametersCheckForDuplicateGrns.Y)>  _
        Public Property CheckForDuplicateGrns() As PostGrnDetailsParametersCheckForDuplicateGrns
            Get
                Return Me.checkForDuplicateGrnsField
            End Get
            Set
                Me.checkForDuplicateGrnsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGrnDetailsParametersPostingPeriod
        
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
    Public Enum PostGrnDetailsParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGrnDetailsParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGrnDetailsParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGrnDetailsParametersAlwaysSupplyGrnNumbers
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGrnDetailsParametersCheckForDuplicateGrns
        
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
    Public Enum PostingPeriod
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
End Namespace
