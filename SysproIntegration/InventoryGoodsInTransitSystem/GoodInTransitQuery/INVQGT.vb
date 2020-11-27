Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryGoodsInTransitSystem.GoodInTransitQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Filter
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gtrReferenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceWarehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private targetWarehouseField As String
        
        '''<summary>
        '''This element specifies what GtrReference number to return. If this element is empty no GtrReference check is made. Default empty. 
        '''</summary>
        Public Property GtrReference() As String
            Get
                Return Me.gtrReferenceField
            End Get
            Set
                Me.gtrReferenceField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the source warehouse to use. If this element is empty no restriction on the source warehouse is made. That is if the source warehouse is empty and the target warehouse is not empty, then all the records with that target warehouse and any source warehouse are returned. 
        '''</summary>
        Public Property SourceWarehouse() As String
            Get
                Return Me.sourceWarehouseField
            End Get
            Set
                Me.sourceWarehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element specifies the target warehouse to use. If this element is empty no restriction on the target warehouse is made. That is if the source warehouse is not empty and the target warehouse is empty, then all the records with that source warehouse and any target warehouse are returned. 
        '''</summary>
        Public Property TargetWarehouse() As String
            Get
                Return Me.targetWarehouseField
            End Get
            Set
                Me.targetWarehouseField = value
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
    Partial Public Class [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWarehouseTransfersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeSupplyChainTransfersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedTransfersField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeZeroOutstandingQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCompletedLinesField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeTransactionsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeLotSerialField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeFifoBucketsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As XslStylesheet
        
        Public Sub New()
            MyBase.New
            Me.includeWarehouseTransfersField = "Y"
            Me.includeSupplyChainTransfersField = "Y"
            Me.includeCompletedTransfersField = "Y"
            Me.includeZeroOutstandingQtyField = "Y"
            Me.includeCompletedLinesField = "Y"
            Me.includeTransactionsField = "Y"
            Me.includeLotSerialField = "N"
            Me.includeFifoBucketsField = "N"
            If (Me.xslStylesheetField Is Nothing) Then
                Me.xslStylesheetField = New XslStylesheet
            End If
        End Sub
        
        '''<summary>
        '''This element gives an option to include records created during warehouse transfer. Y - Yes include , N -No do not include,  Default - Y (Yes).  
        '''</summary>
        Public Property IncludeWarehouseTransfers() As String
            Get
                Return Me.includeWarehouseTransfersField
            End Get
            Set
                Me.includeWarehouseTransfersField = value
            End Set
        End Property
        
        '''<summary>
        '''This element gives an option to include supply chain transfers. Y - Yes include , N -No do not include,  Default - Y (Yes).  
        '''</summary>
        Public Property IncludeSupplyChainTransfers() As String
            Get
                Return Me.includeSupplyChainTransfersField
            End Get
            Set
                Me.includeSupplyChainTransfersField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include complete transfers ? (Y - Yes, N - No)  Default Y - Yes
        '''</summary>
        Public Property IncludeCompletedTransfers() As String
            Get
                Return Me.includeCompletedTransfersField
            End Get
            Set
                Me.includeCompletedTransfersField = value
            End Set
        End Property
        
        '''<summary>
        '''This element gives an option to include records where the quantity received is the same as the original quantity. Y - Yes include , N -No do not include,  Default - Y (Yes).  
        '''</summary>
        Public Property IncludeZeroOutstandingQty() As String
            Get
                Return Me.includeZeroOutstandingQtyField
            End Get
            Set
                Me.includeZeroOutstandingQtyField = value
            End Set
        End Property
        
        '''<summary>
        '''Do you wish to include completed transfers lines? (Y - Yes, N - No)  Default Y - Yes
        '''</summary>
        Public Property IncludeCompletedLines() As String
            Get
                Return Me.includeCompletedLinesField
            End Get
            Set
                Me.includeCompletedLinesField = value
            End Set
        End Property
        
        '''<summary>
        '''A transfer (warehouse transfer or supply chain transfer) can be made up of a number of transactions. This element gives an option to return the query with the transfer transaction(s). Y - Yes include , N -No do not include,  Default - Y (Yes).  
        '''</summary>
        Public Property IncludeTransactions() As String
            Get
                Return Me.includeTransactionsField
            End Get
            Set
                Me.includeTransactionsField = value
            End Set
        End Property
        
        '''<summary>
        '''This element gives an option to include lots and serials. Lots are returned if they are installed and the item is traceable, and serials are returned if they are installed and the item is serialized, and they are both returned if (lots and serials) if both installed and the item is traceable and serialized.   Y - Yes include , N -No do not include,  Default - N (No).  
        '''</summary>
        Public Property IncludeLotSerial() As String
            Get
                Return Me.includeLotSerialField
            End Get
            Set
                Me.includeLotSerialField = value
            End Set
        End Property
        
        '''<summary>
        '''This element gives an option to include FifoBuckets. Fifo records will be returned if you have fifo installed.  Y - Yes include , N -No do not include,  Default - N (No).  
        '''</summary>
        Public Property IncludeFifoBuckets() As String
            Get
                Return Me.includeFifoBucketsField
            End Get
            Set
                Me.includeFifoBucketsField = value
            End Set
        End Property
        
        '''<summary>
        '''The Stylesheet to be applied
        '''</summary>
        Public Property XslStylesheet() As XslStylesheet
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
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
    Partial Public Class XslStylesheet
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private optionField As [Option]
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _queryActionTypeField As CommonEnums.ActionType_Query
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        '''<summary>
        '''The key specifies what records to return. If the key is empty, all the records will be returned.
        '''</summary>
        Public Property Key() As Key
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<summary>
        '''The list of options
        '''</summary>
        Public Property [Option]() As [Option]
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = value
            End Set
        End Property
        
        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "INVQGT"
            End Get
        End Property
        
        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.XMLData
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements IQuery.Post
            If (Me._queryActionTypeField = 1) Then
                Me._xmlOut = QueryObject.Browse(Me)
                Return
            End If
            If (Me._queryActionTypeField = 0) Then
                Me._xmlOut = QueryObject.Fetch(Me)
                Return
            End If
            If (Me._queryActionTypeField = 4) Then
                Me._xmlOut = QueryObject.Query(Me)
                Return
            End If
            If (Me._queryActionTypeField = 2) Then
                Me._xmlOut = QueryObject.NextKey(Me)
                Return
            End If
            If (Me._queryActionTypeField = 3) Then
                Me._xmlOut = QueryObject.PreviousKey(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class
End Namespace
