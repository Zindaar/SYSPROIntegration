Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace WipTwoStageReceipting.WipInspectionAcceptIntoStock.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostExpectedCosts
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemsField As List(Of PostExpectedCostsItem)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.PostExpectedCostsParameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemsField Is Nothing) Then
                Me.itemsField = New List(Of PostExpectedCostsItem)
            End If
        End Sub
        
        <System.Xml.Serialization.XmlElementAttribute("Item")>  _
        Public Property ItemsCollection() As List(Of PostExpectedCostsItem)
            Get
                Return Me.itemsField
            End Get
            Set
                Me.itemsField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ITransaction.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "WIPTCE"
            End Get
        End Property
        
        Public Overridable ReadOnly Property Params() As Params.PostExpectedCostsParameters
            Get
                If (Me._params Is Nothing) Then
                    Me._params = New Params.PostExpectedCostsParameters
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
                Dim objParams As Params.PostExpectedCosts
                objParams = New Params.PostExpectedCosts
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
    Partial Public Class PostExpectedCostsItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updateCurrentCostField As PostExpectedCostsItemUpdateCurrentCost
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updateOriginalCostField As PostExpectedCostsItemUpdateOriginalCost
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private updateHierarchyCostField As PostExpectedCostsItemUpdateHierarchyCost
        
        Public Sub New()
            MyBase.New
            Me.updateCurrentCostField = PostExpectedCostsItemUpdateCurrentCost.Y
            Me.updateOriginalCostField = PostExpectedCostsItemUpdateOriginalCost.N
            Me.updateHierarchyCostField = PostExpectedCostsItemUpdateHierarchyCost.N
        End Sub
        
        Public Property Job() As String
            Get
                Return Me.jobField
            End Get
            Set
                Me.jobField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostExpectedCostsItemUpdateCurrentCost.Y)>  _
        Public Property UpdateCurrentCost() As PostExpectedCostsItemUpdateCurrentCost
            Get
                Return Me.updateCurrentCostField
            End Get
            Set
                Me.updateCurrentCostField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostExpectedCostsItemUpdateOriginalCost.N)>  _
        Public Property UpdateOriginalCost() As PostExpectedCostsItemUpdateOriginalCost
            Get
                Return Me.updateOriginalCostField
            End Get
            Set
                Me.updateOriginalCostField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(PostExpectedCostsItemUpdateHierarchyCost.N)>  _
        Public Property UpdateHierarchyCost() As PostExpectedCostsItemUpdateHierarchyCost
            Get
                Return Me.updateHierarchyCostField
            End Get
            Set
                Me.updateHierarchyCostField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostExpectedCostsItemUpdateCurrentCost
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostExpectedCostsItemUpdateOriginalCost
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostExpectedCostsItemUpdateHierarchyCost
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
