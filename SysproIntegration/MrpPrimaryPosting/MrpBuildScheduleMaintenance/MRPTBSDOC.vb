Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace MrpPrimaryPosting.MrpBuildScheduleMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As List(Of Byte)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateRequiredField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outstQtyToMakeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private resourceParentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private revisionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useCurrentRevisionReleaseField As UseCurrentRevisionRelease
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useCurrentRevisionReleaseFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private newDateRequiredField As String
        
        Public Sub New()
            MyBase.New
            Me.useCurrentRevisionReleaseField = UseCurrentRevisionRelease.N
            If (Me.stockCodeField Is Nothing) Then
                Me.stockCodeField = New List(Of Byte)
            End If
        End Sub
        
        '''<summary>
        '''Enter a MPS stock item. This is mandatory The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within SYSPRO. 
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property StockCodeCollection() As List(Of Byte)
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter a valid warehouse code for the MPS stock item. The warehouse field is a mandatory field.  The format is 2 characters alphanumeric.
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
        '''Date the build schedule is required.  The date required field is mandatory.  If the IgnoreWarnings parameter is set to 'N' and the ActionType is 'A' then a check is made to see if the date entered is a working day and if not an error message is returned. 
        '''</summary>
        Public Property DateRequired() As String
            Get
                Return Me.dateRequiredField
            End Get
            Set
                Me.dateRequiredField = value
            End Set
        End Property
        
        '''<summary>
        '''The line number is used to distinguish between build schedules for the same stock code and date required.  The line number is mandatory when the ActionType  is 'C' or 'D'
        '''</summary>
        Public Property Line() As String
            Get
                Return Me.lineField
            End Get
            Set
                Me.lineField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter the outstanding quantity to make.  If changing a build schedule and the outstanding quantity to make is not provided or is zero then the quantity that is on file is used.  When deleting a build schedule the outstanding quantity to make is not checked.  When adding a build schedule the outstanding quantity to make must me entered. The format is 7.3 positive numeric.
        '''</summary>
        Public Property OutstQtyToMake() As String
            Get
                Return Me.outstQtyToMakeField
            End Get
            Set
                Me.outstQtyToMakeField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter a reference for the build schedule.  Maximum length is 30 characters.
        '''</summary>
        Public Property Reference() As String
            Get
                Return Me.referenceField
            End Get
            Set
                Me.referenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Resource parent code.  If the resource parent code supplied does not exists and the the parameter IgnoreWarnings is set to 'N'  then an error message will be output.  If the parameter IgnoreWarnings is set to 'Y' then the resource  parent code will be saved without a warning.  The maximum length is 15 characters.
        '''</summary>
        Public Property ResourceParent() As String
            Get
                Return Me.resourceParentField
            End Get
            Set
                Me.resourceParentField = value
            End Set
        End Property
        
        '''<summary>
        '''Revision indicates the ECC version number of the stock code to make. Ignore if not an ECC controlled item, or if ECC controlled at a stocking level. 
        '''When adding and this is not supplied then defaults to the current version number for the stock code. 
        '''This cannot be changed.
        '''The format is 3 characters alphanumeric or 3 chararcters numeric depending on the configuration option within Bill of Materials setup.
        '''</summary>
        Public Property Revision() As String
            Get
                Return Me.revisionField
            End Get
            Set
                Me.revisionField = value
            End Set
        End Property
        
        '''<summary>
        '''Release indicates the ECC release number of the component part. Ignored if not an ECC controlled item, or if ECC controlled at a stocking/revision level. 
        '''When adding and this is not supplied then defaults to the current release number for the stock code. 
        '''This cannot be changed.
        '''The format is 3 characters alphanumeric or 3 characters numeric depending on the configuration option within Bill of Materials setup.
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
        '''If this flag is set to 'Y' then the currrent revision and release will be used and the value of revision and release will be, '---'.  The default is 'N'.
        '''</summary>
        Public Property UseCurrentRevisionRelease() As UseCurrentRevisionRelease
            Get
                Return Me.useCurrentRevisionReleaseField
            End Get
            Set
                Me.useCurrentRevisionReleaseField = value
                Me.UseCurrentRevisionReleaseFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property UseCurrentRevisionReleaseSpecified() As Boolean
            Get
                Return Me.useCurrentRevisionReleaseFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''If you want to change the date the build schedule is required you put the new date in this element.
        '''</summary>
        Public Property NewDateRequired() As String
            Get
                Return Me.newDateRequiredField
            End Get
            Set
                Me.newDateRequiredField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseCurrentRevisionRelease
        
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
    Partial Public Class PostBuildSchedule
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        '''<summary>
        '''This element contains information to maintain a build schedule.
        '''</summary>
        Public Property Item() As Item
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
                Return "MRPTBS"
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
                Dim objParams As Params.PostBuildSchedule
                objParams = New Params.PostBuildSchedule
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
