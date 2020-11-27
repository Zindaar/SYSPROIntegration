Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryAvailableToPromiseQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum CumeMaintenance
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        '''<summary>
        '''This is the stock code to be used for the ATP query. This field is mandatory.
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
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
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runDateFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBuildSchField As UseBuildSch
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBuildSchFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnTypeField As ReturnType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeMaintenanceField As CumeMaintenance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeMaintenanceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeSalesOrderField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeShipDaysField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeSoFileField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tmpAtpFileField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignorePlanningTimeFenceField As OptionIgnorePlanningTimeFence
        
        Public Sub New()
            MyBase.New
            Me.ignorePlanningTimeFenceField = OptionIgnorePlanningTimeFence.N
        End Sub
        
        '''<summary>
        '''If this item is under the control of ECC and this value is blank, the current revision is used.
        '''</summary>
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the required release level if ECC is installed. If it is blank the current release level is used.
        '''</summary>
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        '''<summary>
        '''The warehouse to use for the ATP calculation. If blank the operator's warehouse is used. If this is also blank the warehouse against the stock code is used.
        '''</summary>
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        '''<summary>
        '''The date on which to base the time fence calculations. If blank, the system run date is used.
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property RunDate() As Date
            Get
                Return Me.runDateField
            End Get
            Set
                Me.runDateField = value
                Me.RunDateFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property RunDateSpecified() As Boolean
            Get
                Return Me.runDateFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Use the build schedule in the ATP calculation if the stock code is an MPS item.
        '''</summary>
        Public Property UseBuildSch() As UseBuildSch
            Get
                Return Me.useBuildSchField
            End Get
            Set
                Me.useBuildSchField = value
                Me.UseBuildSchFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseBuildSchSpecified() As Boolean
            Get
                Return Me.useBuildSchFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This defines the type of data to be returned (S - Summary (only ATP lines and time fences are returned), D - Detail (all the supply and demand lines are also returned)).
        '''</summary>
        Public Property ReturnType() As ReturnType
            Get
                Return Me.returnTypeField
            End Get
            Set
                Me.returnTypeField = value
                Me.ReturnTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReturnTypeSpecified() As Boolean
            Get
                Return Me.returnTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The flag specifying whether the program has been called by the Blanket S/O review and Confirmation program (Y - Yes, N - No). This is not used for COM.
        '''</summary>
        Public Property CumeMaintenance() As CumeMaintenance
            Get
                Return Me.cumeMaintenanceField
            End Get
            Set
                Me.cumeMaintenanceField = value
                Me.CumeMaintenanceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property CumeMaintenanceSpecified() As Boolean
            Get
                Return Me.cumeMaintenanceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If the element CumeMaintenance contains a Y the sales order in this element is ignored when collating data from the sales order file. Not used in for COM.
        '''</summary>
        Public Property CumeSalesOrder() As String
            Get
                Return Me.cumeSalesOrderField
            End Get
            Set
                Me.cumeSalesOrderField = value
            End Set
        End Property
        
        '''<summary>
        '''The number of days to be added to the ship dates held in the temporary file. This is not used for COM.
        '''</summary>
        Public Property CumeShipDays() As String
            Get
                Return Me.cumeShipDaysField
            End Get
            Set
                Me.cumeShipDaysField = value
            End Set
        End Property
        
        '''<summary>
        '''The name of a temporary file containing details of the Blanket Sales Order being maintained. This is not used for COM.
        '''</summary>
        Public Property CumeSoFile() As String
            Get
                Return Me.cumeSoFileField
            End Get
            Set
                Me.cumeSoFileField = value
            End Set
        End Property
        
        '''<summary>
        '''The name of the temporary file holding the ATP records and supply and demand details. This is not used for COM.
        '''</summary>
        Public Property TmpAtpFile() As String
            Get
                Return Me.tmpAtpFileField
            End Get
            Set
                Me.tmpAtpFileField = value
            End Set
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used for translations.
        '''</summary>
        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = value
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(OptionIgnorePlanningTimeFence.N)>  _
        Public Property IgnorePlanningTimeFence() As OptionIgnorePlanningTimeFence
            Get
                Return Me.ignorePlanningTimeFenceField
            End Get
            Set
                Me.ignorePlanningTimeFenceField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseBuildSch
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReturnType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum OptionIgnorePlanningTimeFence
        
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
        
        Public Sub New()
            MyBase.New
            If (Me.optionField Is Nothing) Then
                Me.optionField = New [Option]
            End If
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This contains the key element.
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
        '''This contains the optional elements.
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
                Return _xmlOut.Replace("AtpDetails>", "AtpDetailsCollection>")
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "INVQAT"
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
