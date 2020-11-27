Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace QuotationsPrimaryPosting.QuotationHierarchyMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum EstimateFlag
        
        '''<remarks/>
        O
        
        '''<remarks/>
        C
        
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
    Partial Public Class Hierarchy
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private headField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        '''<summary>
        '''Indicates the head code of the hierarchy that you want to associate with the component or operation. This is a mandatory field. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Head() As String
            Get
                Return Me.headField
            End Get
            Set
                Me.headField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the first section of the hierarchy that you want to associate with the component or operation. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the second section of the hierarchy that you want to associate with the component or operation. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the third section of the hierarchy that you want to associate with the component or operation. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the last section of the hierarchy that you want to associate with the component or operation. The format is up to 3 characters alphanumeric.
        '''</summary>
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parentPartField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private routeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quotationLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private estimateFlagField As EstimateFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private estimateFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sequenceNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private componentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyField As Hierarchy
        
        Public Sub New()
            MyBase.New
            Me.routeField = "0"
            Me.estimateFlagField = EstimateFlag.O
            If (Me.hierarchyField Is Nothing) Then
                Me.hierarchyField = New Hierarchy
            End If
        End Sub
        
        '''<summary>
        '''The non-stocked parent code for which you want to maintain hierarchies. This is a mandatory element. The format is up to 30 characters alphanumeric or 15 characters numeric depending on the configuration option within SYSPRO.
        '''</summary>
        Public Property ParentPart() As String
            Get
                Return Me.parentPartField
            End Get
            Set
                Me.parentPartField = value
            End Set
        End Property
        
        '''<summary>
        '''This field enables you to select a specific routing for which you want to maintain the estimate hierarchy. You may only select routes that are required for the non-stocked parent code. The format is a 1 character numeric field. Default to: 0.
        '''</summary>
        Public Property Route() As String
            Get
                Return Me.routeField
            End Get
            Set
                Me.routeField = value
            End Set
        End Property
        
        '''<summary>
        '''The quotation number associated with the estimate for which you want to maintain the hierarchies. This is a mandatory element. The quote must be in a status of ‘In Progress’ in order to maintain hierarchies for it. The format is up to 8 characters either alphanumeric or numeric depending on the key configuration option for quotations within SYSPRO.
        '''</summary>
        Public Property Quote() As String
            Get
                Return Me.quoteField
            End Get
            Set
                Me.quoteField = value
            End Set
        End Property
        
        '''<summary>
        '''The quotation line number associated with the estimate for which you want to maintain the hierarchies. This is a mandatory element. The format is up to 4 characters positive numeric.
        '''</summary>
        Public Property QuotationLine() As String
            Get
                Return Me.quotationLineField
            End Get
            Set
                Me.quotationLineField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates if you are maintaining hierarchies for operations (O) or components (C). Default to: O.
        '''</summary>
        Public Property EstimateFlag() As EstimateFlag
            Get
                Return Me.estimateFlagField
            End Get
            Set
                Me.estimateFlagField = value
                Me.EstimateFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EstimateFlagSpecified() As Boolean
            Get
                Return Me.estimateFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Indicates the operation for which you are maintaining hierarchies. This element is mandatory when the element ‘Estimate Flag’ contains ‘O’. The format is up to 3 characters positive numeric. Possible values: 1 to 999.
        '''</summary>
        Public Property Operation() As String
            Get
                Return Me.operationField
            End Get
            Set
                Me.operationField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicate the sequence number for the component for which you are maintaining hierarchies. This field will only be used if you have indicated that structure sequencing is required (Bill of Materials Setup). The format is up to 6 characters alphanumeric or numeric depending on the sequence key Bill of Material setup option within SYSPRO.
        '''</summary>
        Public Property SequenceNumber() As String
            Get
                Return Me.sequenceNumberField
            End Get
            Set
                Me.sequenceNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicates the component for which you are maintaining hierarchies. This element is mandatory when the element ‘Estimate Flag’ contains ‘C’. The format is up to 30 characters alphanumeric or 15 characters numeric depending on the key configuration option for quotations within SYSPRO.
        '''</summary>
        Public Property Component() As String
            Get
                Return Me.componentField
            End Get
            Set
                Me.componentField = value
            End Set
        End Property
        
        '''<summary>
        '''Indicate the hierarchy that you want to associate with the component or operation. The hierarchy can consist of a head code and up to four section codes.
        '''</summary>
        Public Property Hierarchy() As Hierarchy
            Get
                Return Me.hierarchyField
            End Get
            Set
                Me.hierarchyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostQotHierarchy
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains the information to assign a hierarchy to a component or an operation for an estimate, for a specific quotation detail line.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemCollection() As List(Of Item)
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "QOTTHR"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.Parameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.Parameters
                End If
                Return Me._params
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements ITransaction.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ITransaction.XmlParam
            Get
                Dim objParams As Params.PostQotHierarchy
                objParams = New Params.PostQotHierarchy
                objParams.Parameters = Me.Params
                Dim ms As System.IO.MemoryStream
                Dim s As System.Xml.Serialization.XmlSerializer
                Dim tw As System.Xml.XmlTextWriter
                Dim doc As System.Xml.XmlDocument
                ms = New System.IO.MemoryStream
                s = New System.Xml.Serialization.XmlSerializer(objParams.GetType)
                tw = New System.Xml.XmlTextWriter(ms, Nothing)
                doc = New System.Xml.XmlDocument
                s.Serialize(tw, objParams)
                ms.Seek(0, 0)
                doc.Load(ms)
                Return doc.OuterXml
            End Get
        End Property
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ITransaction.Post
            Me._xmlOut = TransactionObject.Post(Me)
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XmlParam, XmlOut)
            End If
        End Sub
    End Class
End Namespace
