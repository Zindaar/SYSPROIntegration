Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryPosting.BackOrderReleasesImport.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AddQuantityToBatchSerial
        
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
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        W
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreAutoDepletion
        
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
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addQuantityToBatchSerialField As AddQuantityToBatchSerial
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private addQuantityToBatchSerialFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreAutoDepletionField As IgnoreAutoDepletion
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreAutoDepletionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipKitFromDefaultBinField As ShipKitFromDefaultBin
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shipKitFromDefaultBinFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.Y
            Me.addQuantityToBatchSerialField = AddQuantityToBatchSerial.N
            Me.ignoreAutoDepletionField = IgnoreAutoDepletion.N
            Me.shipKitFromDefaultBinField = ShipKitFromDefaultBin.N
        End Sub
        
        '''<summary>
        '''Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned, W - warnings will be returned as warnings in the XML returned).
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
                Me.IgnoreWarningsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether the entire document must be validated first before applying the function (N - apply function for each valid item, Y - all items must be valid before function is applied).
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
                Me.ApplyIfEntireDocumentValidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specifies whether to only validate the contents of the document. (N - validate and apply function, Y - only validate the document).
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
                Me.ValidateOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This parameter will determine if additional quantities may be added to a batch serial when the stock item is set to capture serial numbers during order entry. When this option is set to "Y" and the program reads a batch serial number for a stock item that is set to capture serial numbers during order entry - it will not check the Available quantity for the serial and will update the Total receipt quantity and Qty On Hand for the serial.  This parameter needs to be selected if a sales order line quantity is set to zero for a batch serial stock item with no serial allocations.  
        '''
        '''
        '''</summary>
        Public Property AddQuantityToBatchSerial() As AddQuantityToBatchSerial
            Get
                Return Me.addQuantityToBatchSerialField
            End Get
            Set
                Me.addQuantityToBatchSerialField = value
                Me.AddQuantityToBatchSerialFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AddQuantityToBatchSerialSpecified() As Boolean
            Get
                Return Me.addQuantityToBatchSerialFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the SYSPRO option to auto-deplete lots and bins for sales orders has been selected. If set to 'Y', then any processing will be carried out as if auto-depletion were not required, and the relevant lot and bin numbers must be supplied in the data XML. 
        '''</summary>
        Public Property IgnoreAutoDepletion() As IgnoreAutoDepletion
            Get
                Return Me.ignoreAutoDepletionField
            End Get
            Set
                Me.ignoreAutoDepletionField = value
                Me.IgnoreAutoDepletionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreAutoDepletionSpecified() As Boolean
            Get
                Return Me.ignoreAutoDepletionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if multiple bins are installed. If set to 'Y' then a kit parent may be shipped when mutliple bins are installed, and none of the components are lot traceable, serialized or ECC controlled. There must be sufficient quantity in the default bin of each component.
        '''</summary>
        Public Property ShipKitFromDefaultBin() As ShipKitFromDefaultBin
            Get
                Return Me.shipKitFromDefaultBinField
            End Get
            Set
                Me.shipKitFromDefaultBinField = value
                Me.ShipKitFromDefaultBinFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ShipKitFromDefaultBinSpecified() As Boolean
            Get
                Return Me.shipKitFromDefaultBinFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
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
    Public Enum ShipKitFromDefaultBin
        
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
    Partial Public Class PostSorBackOrderRelease
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub
        
        '''<summary>
        '''This element contains the optional parameter elements.
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
