Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryInspectionSystem.PurchaseOrderInspections.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InspectionCompleted
        
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
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNNumberField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private quantityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitOfMeasureField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private unitsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private piecesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private documentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionCompletedField As InspectionCompleted
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionCompletedFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.inspectionCompletedField = InspectionCompleted.N
        End Sub
        
        '''<summary>
        '''This element must contain a valid GRN number and is mandatory.
        '''</summary>
        Public Property GRNNumber() As String
            Get
                Return Me.gRNNumberField
            End Get
            Set
                Me.gRNNumberField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is mandatory if stock code is not a unit-qty type stock code. If it is a unit-qty type stock code and this element is supplied, the units and pieces elements must NOT be supplied.
        '''The total quantity inspected may not exceed the total quantity counted to date.
        '''</summary>
        Public Property Quantity() As String
            Get
                Return Me.quantityField
            End Get
            Set
                Me.quantityField = value
            End Set
        End Property
        
        '''<summary>
        '''If quantity was supplied in a unit of measure different to the stocking unit of measure, this element must be supplied to indicate the alternate unit of measure.
        '''</summary>
        Public Property UnitOfMeasure() As String
            Get
                Return Me.unitOfMeasureField
            End Get
            Set
                Me.unitOfMeasureField = value
            End Set
        End Property
        
        '''<summary>
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
        '''The total quantity inspected may not exceed the total quantity counted to date.
        '''</summary>
        Public Property Units() As String
            Get
                Return Me.unitsField
            End Get
            Set
                Me.unitsField = value
            End Set
        End Property
        
        '''<summary>
        '''If stock code is a unit-qty type stock code and quantity element is not supplied, the quantity of the transaction must be supplied as units and pieces. At least one of these elements must be supplied.
        '''The total quantity inspected may not exceed the total quantity counted to date.
        '''</summary>
        Public Property Pieces() As String
            Get
                Return Me.piecesField
            End Get
            Set
                Me.piecesField = value
            End Set
        End Property
        
        '''<summary>
        '''This element is optional and contains the document number.
        '''</summary>
        Public Property Document() As String
            Get
                Return Me.documentField
            End Get
            Set
                Me.documentField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not the inspection is complete. If not supplied it defaults to 'N. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property InspectionCompleted() As InspectionCompleted
            Get
                Return Me.inspectionCompletedField
            End Get
            Set
                Me.inspectionCompletedField = value
                Me.InspectionCompletedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InspectionCompletedSpecified() As Boolean
            Get
                Return Me.inspectionCompletedFieldSpecified
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
    Partial Public Class PostInspections
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New List(Of Item)
            End If
        End Sub
        
        '''<summary>
        '''This is the top element for all data required for the transaction.
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
                Return "PORTII"
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
                Dim objParams As Params.PostInspections
                objParams = New Params.PostInspections
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
