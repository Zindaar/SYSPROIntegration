Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipShopFloorDataCollection.WipBuildMaterialIssue.BuildData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Build
        Implements Codewell.SysproIntegration.IBuild
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As BuildParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterField As BuildFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New BuildFilter
            End If
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New BuildParameters
            End If
        End Sub
        
        Public Property Parameters() As BuildParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
        
        Public Property Filter() As BuildFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IBuild.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IBuild.BusinessObject
            Get
                Return "WIPRMI"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IBuild.XMLData
            Get
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, Me)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IBuild.Post
            Me._xmlOut = TransactionObject.Build(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BuildParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitQuantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issueNonStockedMaterialField As BuildParametersIssueNonStockedMaterial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issueNegativeAllocationsField As BuildParametersIssueNegativeAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issueCompletedAllocationsField As BuildParametersIssueCompletedAllocations
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issueToMaxOutstandingField As BuildParametersIssueToMaxOutstanding
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnValidMaterialsOnlyField As BuildParametersReturnValidMaterialsOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As BuildParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFloorstockField As BuildParametersIncludeFloorstock
        
        Public Sub New()
            MyBase.New
            Me.issueNonStockedMaterialField = BuildParametersIssueNonStockedMaterial.Y
            Me.issueNegativeAllocationsField = BuildParametersIssueNegativeAllocations.Y
            Me.issueCompletedAllocationsField = BuildParametersIssueCompletedAllocations.Y
            Me.issueToMaxOutstandingField = BuildParametersIssueToMaxOutstanding.N
            Me.returnValidMaterialsOnlyField = BuildParametersReturnValidMaterialsOnly.Y
            Me.ignoreWarningsField = BuildParametersIgnoreWarnings.Y
            Me.includeFloorstockField = BuildParametersIncludeFloorstock.N
        End Sub
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        Public Property KitQuantity() As String
            Get
                Return Me.kitQuantityField
            End Get
            Set
                Me.kitQuantityField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIssueNonStockedMaterial.Y)>  _
        Public Property IssueNonStockedMaterial() As BuildParametersIssueNonStockedMaterial
            Get
                Return Me.issueNonStockedMaterialField
            End Get
            Set
                Me.issueNonStockedMaterialField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIssueNegativeAllocations.Y)>  _
        Public Property IssueNegativeAllocations() As BuildParametersIssueNegativeAllocations
            Get
                Return Me.issueNegativeAllocationsField
            End Get
            Set
                Me.issueNegativeAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIssueCompletedAllocations.Y)>  _
        Public Property IssueCompletedAllocations() As BuildParametersIssueCompletedAllocations
            Get
                Return Me.issueCompletedAllocationsField
            End Get
            Set
                Me.issueCompletedAllocationsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIssueToMaxOutstanding.N)>  _
        Public Property IssueToMaxOutstanding() As BuildParametersIssueToMaxOutstanding
            Get
                Return Me.issueToMaxOutstandingField
            End Get
            Set
                Me.issueToMaxOutstandingField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersReturnValidMaterialsOnly.Y)>  _
        Public Property ReturnValidMaterialsOnly() As BuildParametersReturnValidMaterialsOnly
            Get
                Return Me.returnValidMaterialsOnlyField
            End Get
            Set
                Me.returnValidMaterialsOnlyField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIgnoreWarnings.Y)>  _
        Public Property IgnoreWarnings() As BuildParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(BuildParametersIncludeFloorstock.N)>  _
        Public Property IncludeFloorstock() As BuildParametersIncludeFloorstock
            Get
                Return Me.includeFloorstockField
            End Get
            Set
                Me.includeFloorstockField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIssueNonStockedMaterial
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIssueNegativeAllocations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIssueCompletedAllocations
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIssueToMaxOutstanding
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersReturnValidMaterialsOnly
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIgnoreWarnings
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum BuildParametersIncludeFloorstock
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        O
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BuildFilter
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As BuildFilterOperation
        
        Public Sub New()
            MyBase.New
            If (Me.operationField Is Nothing) Then
                Me.operationField = New BuildFilterOperation
            End If
        End Sub
        
        Public Property Operation() As BuildFilterOperation
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class BuildFilterOperation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterTypeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private filterValueField As String
        
        Public Sub New()
            MyBase.New
            Me.filterTypeField = "A"
        End Sub
        
        <System.Xml.Serialization.XmlAttributeAttribute(),  _
         System.ComponentModel.DefaultValueAttribute("A")>  _
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlAttributeAttribute()>  _
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = value
            End Set
        End Property
    End Class
End Namespace
