Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipProjectsAndContracts.PCJobHeirarchyMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostJobHierarchy
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As PostJobHierarchyItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostJobHierarchyParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New PostJobHierarchyItem
            End If
        End Sub
        
        Public Property Item() As PostJobHierarchyItem
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
                Return "PRJTJH"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostJobHierarchyParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostJobHierarchyParameters
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
                Dim objParams As Params.PostJobHierarchy
                objParams = New Params.PostJobHierarchy
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
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostJobHierarchyItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierarchyTypeField As PostJobHierarchyItemHierarchyType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobQuoteField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quoteLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private hierHeadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private section4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anticipatedVal1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anticipatedVal2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private anticipatedVal3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trackCostsOnlyField As PostJobHierarchyItemTrackCostsOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCostTrkGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowStkTranField As PostJobHierarchyItemAllowStkTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowNonTranField As PostJobHierarchyItemAllowNonTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowLabTranField As PostJobHierarchyItemAllowLabTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowSubTranField As PostJobHierarchyItemAllowSubTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowSlsTranField As PostJobHierarchyItemAllowSlsTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowSlsTranFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private allowPorTranField As PostJobHierarchyItemAllowPorTran
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private pctLimitField As PostJobHierarchyItemPctLimit
        
        Public Sub New()
            MyBase.New
            Me.hierarchyTypeField = PostJobHierarchyItemHierarchyType.J
            Me.trackCostsOnlyField = PostJobHierarchyItemTrackCostsOnly.N
            Me.allowStkTranField = PostJobHierarchyItemAllowStkTran.N
            Me.allowNonTranField = PostJobHierarchyItemAllowNonTran.N
            Me.allowLabTranField = PostJobHierarchyItemAllowLabTran.N
            Me.allowSubTranField = PostJobHierarchyItemAllowSubTran.N
            Me.allowPorTranField = PostJobHierarchyItemAllowPorTran.N
        End Sub
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemHierarchyType.J)>  _
        Public Property HierarchyType() As PostJobHierarchyItemHierarchyType
            Get
                Return Me.hierarchyTypeField
            End Get
            Set
                Me.hierarchyTypeField = value
            End Set
        End Property
        
        Public Property JobQuote() As String
            Get
                Return Me.jobQuoteField
            End Get
            Set
                Me.jobQuoteField = value
            End Set
        End Property
        
        Public Property QuoteLine() As String
            Get
                Return Me.quoteLineField
            End Get
            Set
                Me.quoteLineField = value
            End Set
        End Property
        
        Public Property HierHead() As String
            Get
                Return Me.hierHeadField
            End Get
            Set
                Me.hierHeadField = value
            End Set
        End Property
        
        Public Property Section1() As String
            Get
                Return Me.section1Field
            End Get
            Set
                Me.section1Field = value
            End Set
        End Property
        
        Public Property Section2() As String
            Get
                Return Me.section2Field
            End Get
            Set
                Me.section2Field = value
            End Set
        End Property
        
        Public Property Section3() As String
            Get
                Return Me.section3Field
            End Get
            Set
                Me.section3Field = value
            End Set
        End Property
        
        Public Property Section4() As String
            Get
                Return Me.section4Field
            End Get
            Set
                Me.section4Field = value
            End Set
        End Property
        
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        Public Property AnticipatedVal1() As String
            Get
                Return Me.anticipatedVal1Field
            End Get
            Set
                Me.anticipatedVal1Field = value
            End Set
        End Property
        
        Public Property AnticipatedVal2() As String
            Get
                Return Me.anticipatedVal2Field
            End Get
            Set
                Me.anticipatedVal2Field = value
            End Set
        End Property
        
        Public Property AnticipatedVal3() As String
            Get
                Return Me.anticipatedVal3Field
            End Get
            Set
                Me.anticipatedVal3Field = value
            End Set
        End Property
        
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemTrackCostsOnly.N)>  _
        Public Property TrackCostsOnly() As PostJobHierarchyItemTrackCostsOnly
            Get
                Return Me.trackCostsOnlyField
            End Get
            Set
                Me.trackCostsOnlyField = value
            End Set
        End Property
        
        Public Property WipCostTrkGlCode() As String
            Get
                Return Me.wipCostTrkGlCodeField
            End Get
            Set
                Me.wipCostTrkGlCodeField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowStkTran.N)>  _
        Public Property AllowStkTran() As PostJobHierarchyItemAllowStkTran
            Get
                Return Me.allowStkTranField
            End Get
            Set
                Me.allowStkTranField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowNonTran.N)>  _
        Public Property AllowNonTran() As PostJobHierarchyItemAllowNonTran
            Get
                Return Me.allowNonTranField
            End Get
            Set
                Me.allowNonTranField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowLabTran.N)>  _
        Public Property AllowLabTran() As PostJobHierarchyItemAllowLabTran
            Get
                Return Me.allowLabTranField
            End Get
            Set
                Me.allowLabTranField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowSubTran.N)>  _
        Public Property AllowSubTran() As PostJobHierarchyItemAllowSubTran
            Get
                Return Me.allowSubTranField
            End Get
            Set
                Me.allowSubTranField = value
            End Set
        End Property
        
        Public Property AllowSlsTran() As PostJobHierarchyItemAllowSlsTran
            Get
                Return Me.allowSlsTranField
            End Get
            Set
                Me.allowSlsTranField = value
                Me.AllowSlsTranFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AllowSlsTranSpecified() As Boolean
            Get
                Return Me.allowSlsTranFieldSpecified
            End Get
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowPorTran.N)>  _
        Public Property AllowPorTran() As PostJobHierarchyItemAllowPorTran
            Get
                Return Me.allowPorTranField
            End Get
            Set
                Me.allowPorTranField = value
            End Set
        End Property
        
        Public Property PctLimit() As PostJobHierarchyItemPctLimit
            Get
                Return Me.pctLimitField
            End Get
            Set
                Me.pctLimitField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemHierarchyType
        
        '''<remarks/>
        J
        
        '''<remarks/>
        E
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemTrackCostsOnly
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowStkTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowNonTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowLabTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowSubTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowSlsTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemAllowPorTran
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostJobHierarchyItemPctLimit
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
