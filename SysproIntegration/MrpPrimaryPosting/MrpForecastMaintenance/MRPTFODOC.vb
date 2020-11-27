Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace MrpPrimaryPosting.MrpForecastMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InactiveFlag
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        I
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
        Private forecastWhField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedFlagField As NonStockedFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private forecastDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private forecastQtyOutstField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private referenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private customerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private resourceParentField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inactiveFlagField As InactiveFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inactiveFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private forecastTypeField As String
        
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
            Me.nonStockedFlagField = NonStockedFlag.N
        End Sub
        
        '''<summary>
        '''Enter a valid warehouse code. If the Inventory control module is not installed, then all entries are assumed to be non-stocked. The warehouse field is a mandatory field.  The format is 2 characters alphanumeric.
        '''</summary>
        Public Property ForecastWh() As String
            Get
                Return Me.forecastWhField
            End Get
            Set
                Me.forecastWhField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter a non-blank stock code for which you want to maintain a forecast. This is mandatory The format is 30 characters alphanumeric or 15 chararcters numeric depending on the configuration option within SYSPRO. 
        '''</summary>
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Select this option to create/change forecasts for non-stocked items. The default is 'N'
        '''</summary>
        Public Property NonStockedFlag() As NonStockedFlag
            Get
                Return Me.nonStockedFlagField
            End Get
            Set
                Me.nonStockedFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''Date the forecast is required.  The date required field is mandatory.  If the IgnoreWarnings parameter is set to 'N' and the ActionType is 'A' then a check is made to see if the date entered is a working day and if not an error message is returned. 
        '''</summary>
        Public Property ForecastDate() As String
            Get
                Return Me.forecastDateField
            End Get
            Set
                Me.forecastDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The line number is used to distinguish between forecasts for the same stock code and date required.  The line number is mandatory when the ActionType  is 'C' or 'D'
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
        '''Enter the outstanding quantity to make.  If changing a forecast and the outstanding quantity to make is not provided or is zero then the quantity that is on file is used.  When deleting a forecast the outstanding quantity to make is not checked.  When adding a forecast the outstanding quantity to make must be entered and cannot be zero. The format is 7.3 positive numeric.
        '''</summary>
        Public Property ForecastQtyOutst() As String
            Get
                Return Me.forecastQtyOutstField
            End Get
            Set
                Me.forecastQtyOutstField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter up to 30 characters to describe the forecast. 
        '''</summary>
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
        
        '''<summary>
        '''Enter a reference for the forecast.  Maximum length is 30 characters.
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
        '''Enter a customer number.   The maximum length is 7 characters.
        '''</summary>
        Public Property Customer() As String
            Get
                Return Me.customerField
            End Get
            Set
                Me.customerField = value
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
        '''You use the Activate/Inactivate function to activate or inactivate the forecast selected. If a forecast is inactivated it will be excluded when creating the Master Production Schedule.  The default is spaces.  Set this flag to 'I' if you want to inactivate the forecast.
        '''</summary>
        Public Property InactiveFlag() As InactiveFlag
            Get
                Return Me.inactiveFlagField
            End Get
            Set
                Me.inactiveFlagField = value
                Me.InactiveFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InactiveFlagSpecified() As Boolean
            Get
                Return Me.inactiveFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Enter a single character to be used as a selection criteria for forecasts.
        '''</summary>
        Public Property ForecastType() As String
            Get
                Return Me.forecastTypeField
            End Get
            Set
                Me.forecastTypeField = value
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
        '''If this flag is set to 'Y' then the current revision and release will be used and the value of revision and release will be, '---'.  The default is 'N'.
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
        '''If you want to change the date the forecast is required you put the new date in this element.
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
    Public Enum NonStockedFlag
        
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
    Partial Public Class PostForecastMaintenance
        Implements Codewell.SysproIntegration.ITransaction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As Item
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _xmlOut As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _params As Params.Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.itemField Is Nothing) Then
                Me.itemField = New Item
            End If
        End Sub
        
        '''<summary>
        '''This element contains information to maintain a forecast.
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
                Return "MRPTFO"
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
                Dim objParams As Params.PostForecastMaintenance
                objParams = New Params.PostForecastMaintenance
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
