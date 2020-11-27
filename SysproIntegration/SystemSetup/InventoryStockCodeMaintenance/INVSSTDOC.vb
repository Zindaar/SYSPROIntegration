Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemSetup.InventoryStockCodeMaintenance.Data
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AbcAnalysisReq
        
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
    Public Enum AbcCostingReq
        
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
    Public Enum Basis
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        V
        
        '''<remarks/>
        M
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BatchBill
        
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
    Public Enum BulkIssueFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        F
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum BuyingRule
        
        '''<remarks/>
        A
        
        '''<remarks/>
        B
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        E
        
        '''<remarks/>
        F
        
        '''<remarks/>
        G
        
        '''<remarks/>
        H
        
        '''<remarks/>
        I
        
        '''<remarks/>
        J
        
        '''<remarks/>
        K
        
        '''<remarks/>
        L
        
        '''<remarks/>
        M
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        P
        
        '''<remarks/>
        Q
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ClearingFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        T
        
        '''<remarks/>
        C
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ConvMulDiv
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum Decimals
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("3")>  _
        Item3
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("2")>  _
        Item2
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("1")>  _
        Item1
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("0")>  _
        Item0
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum EbqPan
        
        '''<remarks/>
        E
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum EccFlag
        
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
    Public Enum GrossReqRule
        
        '''<remarks/>
        I
        
        '''<remarks/>
        H
        
        '''<remarks/>
        C
        
        '''<remarks/>
        A
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InclInStrValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class SetupInvMaster
        Implements Codewell.SysproIntegration.ISetup
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private itemField As List(Of Item)
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private _setupActionTypeField As CommonEnums.ActionType_Setup
        
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
        '''This element contains information to maintain a stock item.
        '''NOTE: The information held within the key element is mandatory for all functions. Information held outside the key element is optional for Add/Update and is not required for Delete.
        '''
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
        
        Public Overridable Property SetupActionType() As CommonEnums.ActionType_Setup Implements ISetup.SetupActionType
            Get
                Return _setupActionTypeField
            End Get
            Set
                Me._setupActionTypeField = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property XmlOut() As String Implements ISetup.XmlOut
            Get
                Return _xmlOut
            End Get
        End Property
        
        Public Overridable ReadOnly Property BusinessObject() As String Implements ISetup.BusinessObject
            Get
                Return "INVSST"
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
        
        Public Overridable ReadOnly Property XMLData() As String Implements ISetup.XMLData
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
        
        Public Overridable ReadOnly Property XmlParam() As String Implements ISetup.XmlParam
            Get
                Dim objParams As Params.SetupInvMaster
                objParams = New Params.SetupInvMaster
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
        
        Public Overridable Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean) Implements ISetup.Post
            If (Me._setupActionTypeField = 0) Then
                Me._xmlOut = SetupObject.Add(Me)
                Return
            End If
            If (Me._setupActionTypeField = 1) Then
                Me._xmlOut = SetupObject.Update(Me)
                Return
            End If
            If (Me._setupActionTypeField = 2) Then
                Me._xmlOut = SetupObject.Delete(Me)
                Return
            End If
            If blnThrowExceptionOnErrorInXMLOut Then
                Common.SysproUtilities.CheckXMLOut(XMLData, XMLParam, XmlOut)
            End If
        End Sub
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
        Private keyField As Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKey1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateKey2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccUserField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private alternateUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactAltUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convMulDivField As ConvMulDiv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convMulDivFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private convFactOthUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivField As MulDiv
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mulDivFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private massField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private volumeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsField As Decimals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decimalsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryField As PriceCategory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceCategoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodField As PriceMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnableItemField As ReturnableItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private returnableItemFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplierField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cycleCountField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productClassField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private taxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private otherTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private listPriceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialMethodField As SerialMethod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialMethodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialPrefixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serialSuffixField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitTypeField As KitType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private kitTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private plannerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeField As TraceableType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private traceableTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagField As InspectionFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inspectionFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mpsFlagField As MpsFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mpsFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bulkIssueFlagField As BulkIssueFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bulkIssueFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private leadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockMovementReqField As StockMovementReq
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockMovementReqFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private clearingFlagField As ClearingFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private clearingFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supercessionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcAnalysisReqField As AbcAnalysisReq
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcAnalysisReqFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCostingReqField As AbcCostingReq
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private abcCostingReqFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagField As ManualCostFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualCostFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private costUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private minPricePctField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private labourCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private materialCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixOverheadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private subContractCostField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private variableOverheadField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryField As PartCategory
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private partCategoryFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private drawOfficeNumField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingRuleField As BuyingRule
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private buyingRuleFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private specificGravityField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private fixTimePeriodField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private panSizeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dockToStockField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outputMassFlagField As OutputMassFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private outputMassFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private shelfLifeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private demandTimeFenceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderFlagField As MakeToOrderFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manufLeadTimeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossReqRuleField As GrossReqRule
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private grossReqRuleFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private percentageYieldField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private wipCtlGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private resourceCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gstTaxCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prcInclGstField As PrcInclGst
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private prcInclGstFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serEntryAtSaleField As SerEntryAtSale
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private serEntryAtSaleFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField1Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField2Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField3Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField4Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private userField5Field As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private tariffCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitField As SupplementaryUnit
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplementaryUnitFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqPanField As EbqPan
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ebqPanFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctRequiredField As LctRequired
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private lctRequiredFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issMultLotsFlagField As IssMultLotsFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private issMultLotsFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclInStrValidField As InclInStrValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private inclInStrValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private countryOfOriginField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldField As StockOnHold
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockOnHoldReasonField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccFlagField As EccFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private eccFlagFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockAndAltUmField As StockAndAltUm
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockAndAltUmFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private batchBillField As BatchBill
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private batchBillFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private distWarehouseToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private jobClassificationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private productGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceTypeField As PriceType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private priceTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private basisField As Basis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private basisFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.returnableItemField = ReturnableItem.N
            Me.manualCostFlagField = ManualCostFlag.N
            If (Me.keyField Is Nothing) Then
                Me.keyField = New Key
            End If
        End Sub
        
        '''<summary>
        '''This element contains the key information required to maintain a stock item.
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
        '''This is the description to appear against the stock code. The format is 30 characters, alphanumeric.
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
        '''This is an additional description to appear against the stock code. The format is 30 characters, alphanumeric.
        '''</summary>
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        '''<summary>
        '''Additional information assigned to the stock item which can be used as selection criteria when browsing on stock codes. It can also be used to change the sequence in which items are displayed when browsing on stock codes. The format is 20 characters, alphanumeric.
        '''</summary>
        Public Property AlternateKey1() As String
            Get
                Return Me.alternateKey1Field
            End Get
            Set
                Me.alternateKey1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Additional information assigned to the stock item which can be used as selection criteria when browsing on stock codes. It can also be used to change the sequence in which items are displayed when browsing on stock codes. The format is 20 characters, alphanumeric.
        '''</summary>
        Public Property AlternateKey2() As String
            Get
                Return Me.alternateKey2Field
            End Get
            Set
                Me.alternateKey2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Responsible ECC user is the engineering user assigned to the stock item. This enables you to notify the appropriate person(s) of changes to the status of stock codes under their control. If this field is left blank, then the default ECC user configured within the Bill of Materials Setup program is used. The format is 6 characters, alphanumeric.
        '''</summary>
        Public Property EccUser() As String
            Get
                Return Me.eccUserField
            End Get
            Set
                Me.eccUserField = value
            End Set
        End Property
        
        '''<summary>
        '''Stocking unit of measure is the unit of measure in which the stock item is held on file. Note: A stocking unit of measure entry must be assigned to a stock item. The format is 3 characters, alphanumeric.
        '''</summary>
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Alternate unit of measure is an alternative unit of measure for the sale or purchase quantity of an item and the pricing. A conversion factor (ConvFactAltUom and ConvMulDiv) enables you to convert the alternate unit of measure into the stocking unit of measure. 
        '''Note: The field is used by the Sales Order module if you have indicated that the unit of measure must be requested for order quantities (Sales Order Setup). In addition, it is used by the Purchase Order module if you have indicated that the alternate unit of measure must be used for order quantities (Purchase Order Setup). The format is 3 characters, alphanumeric.
        '''</summary>
        Public Property AlternateUom() As String
            Get
                Return Me.alternateUomField
            End Get
            Set
                Me.alternateUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Other unit of measure is an additional unit of measure for the sale or purchase quantity of an item and the pricing. A conversion factor (ConvFactOthUom and MulDiv) enables you to convert the alternate unit of measure into the stocking unit of measure.
        '''Note: The field is used by the Sales Order module if you have indicated that the unit of measure must be requested for order quantities (Sales Order Setup). In addition, it is used by the Purchase Order module if you have indicated that the alternate unit of measure must be used for order quantities (Purchase Order Setup). The format is 3 characters, alphanumeric.
        '''</summary>
        Public Property OtherUom() As String
            Get
                Return Me.otherUomField
            End Get
            Set
                Me.otherUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Alternate conversion factor is the conversion factor between the stocking unit of measure (StockUom) and the alternate unit of measure (AlternateUom) and is used in conjunction with the conversion method (ConvMulDiv). The format is 6.4 positive numeric.
        '''</summary>
        Public Property ConvFactAltUom() As String
            Get
                Return Me.convFactAltUomField
            End Get
            Set
                Me.convFactAltUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Alternate conversion method is the conversion method between the stocking unit of measure (StockUom) and the alternate unit of measure (AlternateUom) and is used in conjunction with the conversion factor (ConvFactAltUom). (M - Multiply, D - Divide),
        '''</summary>
        Public Property ConvMulDiv() As ConvMulDiv
            Get
                Return Me.convMulDivField
            End Get
            Set
                Me.convMulDivField = value
                Me.ConvMulDivFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ConvMulDivSpecified() As Boolean
            Get
                Return Me.convMulDivFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Other conversion factor is the conversion factor between the stocking unit of measure (StockUom) and the other unit of measure (OtherUom) and is used in conjunction with the conversion method (MulDiv). The format is 6.4 positive numeric.
        '''</summary>
        Public Property ConvFactOthUom() As String
            Get
                Return Me.convFactOthUomField
            End Get
            Set
                Me.convFactOthUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Other conversion method is the conversion method between the stocking unit of measure (StockUom) and the other unit of measure (OtherUom) and is used in conjunction with the conversion factor (ConvFactOthUom). (M - Multiply, D - Divide)
        '''</summary>
        Public Property MulDiv() As MulDiv
            Get
                Return Me.mulDivField
            End Get
            Set
                Me.mulDivField = value
                Me.MulDivFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MulDivSpecified() As Boolean
            Get
                Return Me.mulDivFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Mass per stocking unit is the weight of a single unit of the stock item in the stocking unit of measure. It is used for reporting purposes (Inventory and Sales Analysis) and can be printed on inventory and sales documents. The format is 6.6 positive numeric.
        '''</summary>
        Public Property Mass() As String
            Get
                Return Me.massField
            End Get
            Set
                Me.massField = value
            End Set
        End Property
        
        '''<summary>
        '''Volume per stocking unit is the volume of a single unit of the stock item in the stocking unit of measure. It is used for reporting and query purposes. In addition, the stock unit volume, the order line volume and total volume can be printed on delivery notes and invoices. The format is 6.6 positive numeric.
        '''</summary>
        Public Property Volume() As String
            Get
                Return Me.volumeField
            End Get
            Set
                Me.volumeField = value
            End Set
        End Property
        
        '''<summary>
        '''Number of decimals to which you want to store and print stock quantities. You can specify between 0 and 3 decimals
        '''</summary>
        Public Property Decimals() As Decimals
            Get
                Return Me.decimalsField
            End Get
            Set
                Me.decimalsField = value
                Me.DecimalsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DecimalsSpecified() As Boolean
            Get
                Return Me.decimalsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Pricing category is the price or discount entry associated with the item if extended pricing is in use.
        '''With extended pricing, the price of a stock item is established by matching the stock item's Price category to a position in the customer's Price category/code table (Customer Setup).
        '''</summary>
        Public Property PriceCategory() As PriceCategory
            Get
                Return Me.priceCategoryField
            End Get
            Set
                Me.priceCategoryField = value
                Me.PriceCategoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceCategorySpecified() As Boolean
            Get
                Return Me.priceCategoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Pricing method descibes how the customer's price code is to be used against this item. The options are as follows: 
        '''C - Coded means that the customer's price code must be used to determine the price code for the stock item.
        '''D - Discounted means that the customer's price code must be used to determine which entry in the discount table must be applied to the first selling price of the stock item.
        '''Q - Quantity discounted means that the customer's price code must be used according to the quantity discount breaks defined for the price code.
        '''</summary>
        Public Property PriceMethod() As PriceMethod
            Get
                Return Me.priceMethodField
            End Get
            Set
                Me.priceMethodField = value
                Me.PriceMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceMethodSpecified() As Boolean
            Get
                Return Me.priceMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Returnable item flag. Set to 'Y' if this stock code is a returnable stock item. Defaults to 'N'. A stock code cannot be set to returnable if it is traceable, serialized, ECC-controlled, has Unit Quantity processing switched on, is part of a kit or has decimals. Valid values are 'N' or 'Y'.
        '''</summary>
        Public Property ReturnableItem() As ReturnableItem
            Get
                Return Me.returnableItemField
            End Get
            Set
                Me.returnableItemField = value
                Me.ReturnableItemFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReturnableItemSpecified() As Boolean
            Get
                Return Me.returnableItemFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Supplier from whom you purchase the stock item if it is bought out. The format is up to 7 characters, alphanumeric or numeric depending on a configuration option within SYSPRO.
        '''</summary>
        Public Property Supplier() As String
            Get
                Return Me.supplierField
            End Get
            Set
                Me.supplierField = value
            End Set
        End Property
        
        '''<summary>
        '''Cycle count is the number of times that you want to count the stock item during the year. The format is 2 characters positiive numeric.
        '''</summary>
        Public Property CycleCount() As String
            Get
                Return Me.cycleCountField
            End Get
            Set
                Me.cycleCountField = value
            End Set
        End Property
        
        '''<summary>
        '''Product class is the category to which the item is assigned. It is used for reporting purposes (Sales Analysis) and as a method of defining your integration to the General Ledger module.
        '''Note: Although a product class must be assigned to a stock item, your entry is validated only at the time of generating a sales order. 
        '''The format is 4 characters alphanumeric.
        '''</summary>
        Public Property ProductClass() As String
            Get
                Return Me.productClassField
            End Get
            Set
                Me.productClassField = value
            End Set
        End Property
        
        '''<summary>
        '''Tax code against which the tax percentage applicable to the stock item is held. The format is 1 character alphanumeric.
        '''</summary>
        Public Property TaxCode() As String
            Get
                Return Me.taxCodeField
            End Get
            Set
                Me.taxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Other or alternative tax code for the stock item which is used only if the stock item is sold to a customer against whom you indicated that the Other tax code must be used (Customer Setup). The format is 1 character alphanumeric.
        '''</summary>
        Public Property OtherTaxCode() As String
            Get
                Return Me.otherTaxCodeField
            End Get
            Set
                Me.otherTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''List price code is the standard price code for the stock item on which discounts can be based during Sales Order Entry processing. This field can be blank if you selected the Allow blank list price codes option (Inventory Setup). The format is 2 characters alphanumeric.
        '''</summary>
        Public Property ListPriceCode() As String
            Get
                Return Me.listPriceCodeField
            End Get
            Set
                Me.listPriceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial tracking method flag indicates the serial tracking method to use for the stock item if serial tracking is installed. Settings are as follows: 
        '''N - No serial tracking.
        '''M - Manual indicates that a unique serial number must be allocated against each individual item.
        '''B - Batch indicates that a unique serial number is allocated to a batch of items.
        '''Note: Stock items cannot be serialized if it is flagged as one, or more, of the following: Temporary stock item (ClearingFlag = "T"), Kit type is "K" or "S" (KitType = K or S), Bulk issue or Floorstock (BulkIssueFlag = "Y" or "F") or Unit quantity processing is set (StockAndAltUm = "Y") and the serial tracking method is manual.
        '''</summary>
        Public Property SerialMethod() As SerialMethod
            Get
                Return Me.serialMethodField
            End Get
            Set
                Me.serialMethodField = value
                Me.SerialMethodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SerialMethodSpecified() As Boolean
            Get
                Return Me.serialMethodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Serial Prefix may be used if stock code is manual serialized, serial key type is alphanumeric and serial suffix is defined at stock code level. Serial Prefix may not contain leading spaces and Serial prefix + Serial Suffix may not exceed 20 characters.
        '''</summary>
        Public Property SerialPrefix() As String
            Get
                Return Me.serialPrefixField
            End Get
            Set
                Me.serialPrefixField = value
            End Set
        End Property
        
        '''<summary>
        '''Serial Suffix may be used if stock code is manual serialized, serial key type is alphanumeric and serial suffix is defined at stock code level. Serial suffix must only contain numeric characters and Serial prefix + Serial Suffix may not exceed 20 characters.
        '''</summary>
        Public Property SerialSuffix() As String
            Get
                Return Me.serialSuffixField
            End Get
            Set
                Me.serialSuffixField = value
            End Set
        End Property
        
        '''<summary>
        '''Kit type flag indicates whether, in Sales Orders, the stock item is sold using its bill of materials. Settings are as follows:
        '''N - None indicates that the stock item is not to be treated as a kit type.
        '''F - Finished type indicates that the stock item is a finished part. The cost, price and quantity is determined by the finished part, while components are treated as comment lines.
        '''K - Kit type indicates that first level components from the bill of material are automatically received into stock when this stock item is received into stock. The cost, price and quantity is determined by the components and the finished part is treated as a comment line.
        '''S - Sub type indicates that the price is determined by the finished part and the cost and quantity is determined by the components.
        '''</summary>
        Public Property KitType() As KitType
            Get
                Return Me.kitTypeField
            End Get
            Set
                Me.kitTypeField = value
                Me.KitTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property KitTypeSpecified() As Boolean
            Get
                Return Me.kitTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Buyer is the person responsible for purchasing the stock item. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Buyer() As String
            Get
                Return Me.buyerField
            End Get
            Set
                Me.buyerField = value
            End Set
        End Property
        
        '''<summary>
        '''Planner is the person responsible for the production planning of the stock item. The format is 3 characters alphanumeric.
        '''</summary>
        Public Property Planner() As String
            Get
                Return Me.plannerField
            End Get
            Set
                Me.plannerField = value
            End Set
        End Property
        
        '''<summary>
        '''Lot traceable flag indicates whether the stock item is traceable or not. Settings are as follows:
        '''N - Non traceable indicates that the stock item is neither traceable nor requires inspection.
        '''T - Traceable indicates that the item is traceable and also requires an inspection phases when processing a purchase order receipt for the item. 
        '''I - Inspection required indicates that an inspection phase is required when processing a purchase order receipt for the item.
        '''Note: Stock items cannot be traceable if Lot Traceability is not installed or if it is flagged as one, or more, of the following: 
        '''Temporary stock item (ClearingFlag = "T"), 
        '''Kit type is "K" or "S" (KitType = K or S), 
        '''Bulk issue or Floorstock (BulkIssueFlag = "Y" or "F").
        '''</summary>
        Public Property TraceableType() As TraceableType
            Get
                Return Me.traceableTypeField
            End Get
            Set
                Me.traceableTypeField = value
                Me.TraceableTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TraceableTypeSpecified() As Boolean
            Get
                Return Me.traceableTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Inspection flag may be used if stock code is traceable. It indicates whether the stock code requires inspection, does not require inspection or requires inspection of a sample quantity only. Valid values are 'Y', 'N' or 'P' which will prompt the user for the sample quantity to be inspected. Default is 'Y' for traceable stock items..
        '''</summary>
        Public Property InspectionFlag() As InspectionFlag
            Get
                Return Me.inspectionFlagField
            End Get
            Set
                Me.inspectionFlagField = value
                Me.InspectionFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InspectionFlagSpecified() As Boolean
            Get
                Return Me.inspectionFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''MPS flag indicates whether or not the stock item is used in the Master Production Schedule. Settings are as follows:
        '''Y - MPS item indicates that the stock item is used in the Master Production Schedule system.
        '''N - Non-MPS indicates that the item is a normal stock code that is included in the Requirements Calculation program.
        '''S - Statistical item indicates that the item is always in stock and its lead time is ignored when calculating the cumulative lead time and/or manufacturing lead time of its parent.
        '''</summary>
        Public Property MpsFlag() As MpsFlag
            Get
                Return Me.mpsFlagField
            End Get
            Set
                Me.mpsFlagField = value
                Me.MpsFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MpsFlagSpecified() As Boolean
            Get
                Return Me.mpsFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Bulk issue flag indicates whether the stock item relates to an inexpensive production part held in the factory from which production workers can draw without requisitions. Settings are as follows:
        '''F - Floorstock item indicates that the stock item can be issued automatically to a job upon confirmation of the job. It is included in the costing process. 
        '''Y - Bulk issue item indicates that the stock item can be issued automatically as a material allocation to a job without affecting the on hand quantity of the item. The item is included as a component in the costing process.
        '''N - The item is neither a Floorstock or a Bulk issue item.
        '''Note: Serialized and traceable items cannot be defined as being either a Floorstock item or a Bulk issue item.
        '''</summary>
        Public Property BulkIssueFlag() As BulkIssueFlag
            Get
                Return Me.bulkIssueFlagField
            End Get
            Set
                Me.bulkIssueFlagField = value
                Me.BulkIssueFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BulkIssueFlagSpecified() As Boolean
            Get
                Return Me.bulkIssueFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Lead time is the number of days in which to either buy out or manufacture the stock item. The former is maintained by the user while the latter is calculated by the Lead Time Calculation program. 
        '''It is also used in the calculation performed by the Minimum Quantity Calculation program to establish the minimum quantity required for each stock code and warehouse.
        '''The lead time is also used in the Requirements Planning and Bill of Materials modules. 
        '''The format is 3 characters positive numeric.
        '''</summary>
        Public Property LeadTime() As String
            Get
                Return Me.leadTimeField
            End Get
            Set
                Me.leadTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''Stock movement required flag indicates whether you want to store on file all transaction movements processed against the stock item (Y - Yes, N - No).
        '''</summary>
        Public Property StockMovementReq() As StockMovementReq
            Get
                Return Me.stockMovementReqField
            End Get
            Set
                Me.stockMovementReqField = value
                Me.StockMovementReqFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockMovementReqSpecified() As Boolean
            Get
                Return Me.stockMovementReqFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Stock code status flag. Settings are as follows:
        '''N - Normal indicates that the stock code is a normal stock item.
        '''T - Temporary indicates that you require the stock item to be deleted automatically when you run the Month end function of the Period End Processing program (providing the item meets all the requirements for the deletion of a stock code). Note: Serialized or traceable items cannot be defined as temporary items.
        '''C - Clear indicates that the stock item must be sold or cleared as a matter of urgency. This option can also be used by the Superseded/Clearing Stock report as a criterion according to which stock items are selected for printing.
        '''</summary>
        Public Property ClearingFlag() As ClearingFlag
            Get
                Return Me.clearingFlagField
            End Get
            Set
                Me.clearingFlagField = value
                Me.ClearingFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ClearingFlagSpecified() As Boolean
            Get
                Return Me.clearingFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Date of supersession is the date on which the stock item should no longer be sold. Zero indicates no supersession date.  
        '''The format is CCYY-MM-DD.
        '''</summary>
        Public Property SupercessionDate() As String
            Get
                Return Me.supercessionDateField
            End Get
            Set
                Me.supercessionDateField = value
            End Set
        End Property
        
        '''<summary>
        '''ABC analysis flag indicates whether you want to include the stock item in the calculations performed by the ABC Analysis report program.
        '''The ABC Analysis report program is used to print a list of stock items in descending order of usage value, based on the value of stock used over the last 12 months. 
        '''The report indicates what your most used and least used items are, enabling you to determine what quantities of selected stock items should be included in your inventory.
        '''</summary>
        Public Property AbcAnalysisReq() As AbcAnalysisReq
            Get
                Return Me.abcAnalysisReqField
            End Get
            Set
                Me.abcAnalysisReqField = value
                Me.AbcAnalysisReqFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AbcAnalysisReqSpecified() As Boolean
            Get
                Return Me.abcAnalysisReqFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Activity based costing flag indicates whether you want to more accurately accumulate overhead costs to specific products by applying these costs at the points of transition in the procurement, manufacturing and sales cycle (activity based costing).
        '''Note: You must indicate that the activity based costing system is required (Bill of Materials Setup) before you can enable this against a stock item.
        '''</summary>
        Public Property AbcCostingReq() As AbcCostingReq
            Get
                Return Me.abcCostingReqField
            End Get
            Set
                Me.abcCostingReqField = value
                Me.AbcCostingReqFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AbcCostingReqSpecified() As Boolean
            Get
                Return Me.abcCostingReqFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This indicates whether the BOM Costs Roll-up must update the BOM costs or not. Valid values are 'Y' or 'N'. Default is 'N.
        '''</summary>
        Public Property ManualCostFlag() As ManualCostFlag
            Get
                Return Me.manualCostFlagField
            End Get
            Set
                Me.manualCostFlagField = value
                Me.ManualCostFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ManualCostFlagSpecified() As Boolean
            Get
                Return Me.manualCostFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Cost unit of measure is the unit of measure to be used for the inventory cost of the item.
        '''Note: A costing unit of measure can be assigned to the item only if you indicated that your inventory costs must be held in a unit of measure other than stocked (Inventory Setup). The cost unit of measure can only be set when adding a stock item.
        '''The format is 3 characters alphanumeric.
        '''</summary>
        Public Property CostUom() As String
            Get
                Return Me.costUomField
            End Get
            Set
                Me.costUomField = value
            End Set
        End Property
        
        '''<summary>
        '''Minimum percentage by which the price of stocked order lines must exceed the cost of the item. If this is defined as zero against the stock item, then the minimum price percentage above cost defined within the Sales Order Setup program is used.
        '''The minimum % above cost defined against the item is used only if you indicated that the stock code margin (instead of the company margin) must be used (Sales Order Setup). 
        '''You can indicate whether the margin check is based on the gross or net value (Sales Order Setup) and you can override this margin if you have indicated that this override is allowed (Sales Order Setup).
        '''The format is 2 characters positive numeric.
        '''</summary>
        Public Property MinPricePct() As String
            Get
                Return Me.minPricePctField
            End Get
            Set
                Me.minPricePctField = value
            End Set
        End Property
        
        '''<summary>
        '''BOM operation cost is the total cost of all operations for items included in the stock item's structure. 
        '''This is updated for all parent parts by the Bill of Materials Cost Implosion program. 
        '''The format is 10.5 positive or negative numeric.
        '''</summary>
        Public Property LabourCost() As String
            Get
                Return Me.labourCostField
            End Get
            Set
                Me.labourCostField = value
            End Set
        End Property
        
        '''<summary>
        '''BOM material cost is the total cost of all materials for items included in the stock item's structure .
        '''This is updated for all parent parts by the Bill of Materials Cost Implosion program.
        '''The format is 10.5 positive or negative numeric.
        '''</summary>
        Public Property MaterialCost() As String
            Get
                Return Me.materialCostField
            End Get
            Set
                Me.materialCostField = value
            End Set
        End Property
        
        '''<summary>
        '''BOM fixed overhead is the total cost of all fixed overheads for items included in the stock item's structure.
        '''This is updated for all parent parts by the Bill of Materials Cost Implosion program.
        '''The format is 10.5 positive or negative numeric.
        '''</summary>
        Public Property FixOverhead() As String
            Get
                Return Me.fixOverheadField
            End Get
            Set
                Me.fixOverheadField = value
            End Set
        End Property
        
        '''<summary>
        '''BOM subcontract cost is the total cost of all subcontract costs for items included in the stock item's structure. This is updated for all parent parts by the Bill of Materials Cost Implosion program. The format is 10.5 positive or negative numeric.
        '''</summary>
        Public Property SubContractCost() As String
            Get
                Return Me.subContractCostField
            End Get
            Set
                Me.subContractCostField = value
            End Set
        End Property
        
        '''<summary>
        '''BOM variable overhead is the total cost of all variable overheads for items included in the stock item's structure.
        '''This is updated for all parent parts by the Bill of Materials Cost Implosion program.
        '''The format is 10.5 positive or negative numeric.
        '''</summary>
        Public Property VariableOverhead() As String
            Get
                Return Me.variableOverheadField
            End Get
            Set
                Me.variableOverheadField = value
            End Set
        End Property
        
        '''<summary>
        '''Part category for the stock item. Settings are as follows:
        '''B - Bought-out indicates that the item is purchased from an external supplier.
        '''M - Made-in indicates that the item is manufactured internally.
        '''S - Subcontracted indicates that the item is a made-in part that has been assigned at least one subcontract operation.
        '''G - Phantom part indicates that the item is a parent part in a bill of material, but will typically not be booked into stock for issuing purposes.It can be used as a grouping mechanism to reflect the way in which a product is built, as well as to facilitate the use of common bills of material for engineering and manufacturing. It is used for subassemblies that are typically non-stocked, and permits MRP logic to drive requirements straight through the phantom item to its components. However, the MRP system usually retains its ability to net against any occasional inventories of the item (e.g. if you add an allocation to a phantom manually and then run a Requirements Calculation, existing stock of the phantom will be netted off and a job suggested for the net requirement).
        '''P - Planning bill indicates that the item is an artificial part used to assist in forecasting. It cannot be stocked, sold, or bought out and is used merely to allow the forecasting of a family of products as an entity. This allows you to generate gross requirements into the MPS or MRP (see the Requirements Planning module) independantly for each member of the family.
        '''K - Kit part indicates that the stock code represents one item from a group of items which together comprise one manufactured inventory item. Note: If selected here, then at the Kit type field of the Sales tab, you can only select the Kit type and Sub type options.
        '''C - Co-product. 
        '''Y - By-product. 
        '''N - Notional part. 
        '''Note: It is important that the correct part category is assigned to a stock item as it has different implications when used with other SYSPRO modules.
        '''</summary>
        Public Property PartCategory() As PartCategory
            Get
                Return Me.partCategoryField
            End Get
            Set
                Me.partCategoryField = value
                Me.PartCategoryFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PartCategorySpecified() As Boolean
            Get
                Return Me.partCategoryFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Drawing register number is documentary unless the item is ECC controlled in which case the item can be associated to the drawing register entered. 
        '''The format is 32 character alphanumeric.
        '''</summary>
        Public Property DrawOfficeNum() As String
            Get
                Return Me.drawOfficeNumField
            End Get
            Set
                Me.drawOfficeNumField = value
            End Set
        End Property
        
        '''<summary>
        '''Warehouse to use is the warehouse that must be used to extract the quantities of stock required by the Bill of Materials module when performing functions such as a cost implosion and creating material allocations. 
        '''This is also the default warehouse used for the parent when adding a job and is used to calculate the new landed cost of an item. 
        '''Note: If you are using the full Goods in Transit transfers facility then the warehouse to use defaults to being the top level warehouse for the item. You will be unable to specify a warehouse to use if it is supplied by another warehouse.
        '''The format is 2 character alphanumeric.
        '''</summary>
        Public Property WarehouseToUse() As String
            Get
                Return Me.warehouseToUseField
            End Get
            Set
                Me.warehouseToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''Batching (or buying rule) for the stock item.
        '''This is used by the Requirements Planning module to indicate how you want to address quantity shortages encountered for the stock item. 
        '''This enables you to calculate correctly the order quantities that are required. 
        '''Batching rules are applied to MPS items when producing the Master Production Schedule and to non-MPS items when running the Requirements Calculation program.
        '''Settings are as follows:
        '''A - Lot for lot.
        '''B - Multiples of EBQ.
        '''C - Fixed time period.
        '''D - Order to maximum if shortage.
        '''E - Order to maximum if less than minimum.
        '''F - Multiples of pan.
        '''G - Multiple EBQ lots.
        '''H - Multiple pan lots.
        '''I - Minimum of EBQ.
        '''J - Minimum of pan.
        '''K - Multiples of EBQ (fixed time period).
        '''L - Multiples of pan (fixed time period).
        '''M - Multiple EBQ lots (fixed time period).
        '''N - Multiple pan lots (fixed time period).
        '''O - Minimum of EBQ thereafter multiples of pan.
        '''P - Suppress MRP ordering.
        '''Q - Apply warehouse order policy.
        '''</summary>
        Public Property BuyingRule() As BuyingRule
            Get
                Return Me.buyingRuleField
            End Get
            Set
                Me.buyingRuleField = value
                Me.BuyingRuleFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BuyingRuleSpecified() As Boolean
            Get
                Return Me.buyingRuleFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Specific gravity of an item. It is for documentary purposes only.
        '''The format is 2.4 positive numeric.
        '''</summary>
        Public Property SpecificGravity() As String
            Get
                Return Me.specificGravityField
            End Get
            Set
                Me.specificGravityField = value
            End Set
        End Property
        
        '''<summary>
        '''Economic batch quantity is used to determine the costing of a bill of materials. It is also used within the Requirements Planning module together with batching rules B, G, I, K, M and O. 
        '''Note: This is used instead of the Pan size, depending on your selection at the Manufacturing basis field for the item.
        '''The format is 7.3 positive numeric.
        '''</summary>
        Public Property Ebq() As String
            Get
                Return Me.ebqField
            End Get
            Set
                Me.ebqField = value
            End Set
        End Property
        
        '''<summary>
        '''Fixed time period is the number of working days that represents a fixed time period.
        '''For example: A fixed time period of 1 day indicates that if a shortage is encountered, that the total shortage for today and the next working day is used as if the shortage falls today. 
        '''The entry made here is used for all time-based buying rules (i.e. C, K, L, M and N) within the Requirements Planning module.
        '''The format is 2 character positive numeric.
        '''</summary>
        Public Property FixTimePeriod() As String
            Get
                Return Me.fixTimePeriodField
            End Get
            Set
                Me.fixTimePeriodField = value
            End Set
        End Property
        
        '''<summary>
        '''Pan size can be likened to a container size. Within the Bill of Materials module you can indicate whether the elapsed time against work centers or cost centers is based on the pan size or the economic batch quantity.
        '''Note: This is used instead of the Economic batch quantity, depending on your selection at the Manufacturing basis field for the item.
        '''The format is 7.3 positive numeric.
        '''</summary>
        Public Property PanSize() As String
            Get
                Return Me.panSizeField
            End Get
            Set
                Me.panSizeField = value
            End Set
        End Property
        
        '''<summary>
        '''Dock to stock is the number of days that a bought out or made in stock item must be in stock prior to usage (dock to stock).
        '''This enables you to calculate an earlier due date for jobs or purchase orders and, from these, an earlier start date.The format is 3 characters positive numeric.
        '''</summary>
        Public Property DockToStock() As String
            Get
                Return Me.dockToStockField
            End Get
            Set
                Me.dockToStockField = value
            End Set
        End Property
        
        '''<summary>
        '''Sales weight analysis flag. Settings are as follows:
        '''F - Fixed indicates that the item has a fixed weight.
        '''R - Random indicates that the item has a random weight and requires a manually entered conversion factor to be specified during Sales Order Entry. This facility caters for items that are sold in a certain unit of measure, but where the weight of each item sold differs from unit to unit.
        '''</summary>
        Public Property OutputMassFlag() As OutputMassFlag
            Get
                Return Me.outputMassFlagField
            End Get
            Set
                Me.outputMassFlagField = value
                Me.OutputMassFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property OutputMassFlagSpecified() As Boolean
            Get
                Return Me.outputMassFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Shelf life (in days) of the stock item. It is used to calculate the expiry date of a traceable item and is used when performing a Two-stage Receipt of the item into stock.
        '''The format is 4 character positive numeric.
        '''</summary>
        Public Property ShelfLife() As String
            Get
                Return Me.shelfLifeField
            End Get
            Set
                Me.shelfLifeField = value
            End Set
        End Property
        
        '''<summary>
        '''Revision indicates major design changes made to the stock item (Revision).
        '''Note: You will be unable to access this field if the item is ECC controlled and engineering changes are being controlled at stock code level (Bill of Materials Setup).  
        '''The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
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
        '''Release indicates minor design changes to the stock item (Release).
        '''Note: You will be unable to access this field ifthe item is ECC controlled and engineering changes are being controlled at stock code or revision level (Bill of Materials Setup). 
        '''The format is 3 characters alphanumeric or numeric depending on a configuration option within Bill of Materials Setup.
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
        '''Demand time fence is the number of days from the time an order is placed until it can be fulfilled (demand time fence). 
        '''This is used in the calculations performed by the Master Production Schedule.
        '''It is ignored if an entry of 0 is assigned to the field, or you have not indicated that the stock code is a make-to-order item.
        '''The format is 3 characters positive numeric. 
        '''</summary>
        Public Property DemandTimeFence() As String
            Get
                Return Me.demandTimeFenceField
            End Get
            Set
                Me.demandTimeFenceField = value
            End Set
        End Property
        
        '''<summary>
        '''Make to order flaq indicates whether the stock item must be manufactured only if an order for the item has been placed (make to order item)
        '''If this is not a make-to-order item, then it is manufactured according to the gross requirements rule, regardless of whether a sales order exists.
        '''(Y - Yes, N - No)
        '''</summary>
        Public Property MakeToOrderFlag() As MakeToOrderFlag
            Get
                Return Me.makeToOrderFlagField
            End Get
            Set
                Me.makeToOrderFlagField = value
                Me.MakeToOrderFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property MakeToOrderFlagSpecified() As Boolean
            Get
                Return Me.makeToOrderFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Manufacturing lead time is the number of days it takes to build the stock item, assuming that all the raw materials are available (i.e. it is the longest cumulative manufacturing time, established from the sum of the elapsed time and inter-operation movement time). 
        '''It is calculated by the Lead Time Calculation program (Bill of Materials).The format is 3 characters positive numeric.
        '''</summary>
        Public Property ManufLeadTime() As String
            Get
                Return Me.manufLeadTimeField
            End Get
            Set
                Me.manufLeadTimeField = value
            End Set
        End Property
        
        '''<summary>
        '''Gross requirements rule for the stock item. This is used by the Master Production Schedule (Requirements Planning) to indicate how you want to calculate the demand for a component prior to the netting off of on hand inventory and scheduled receipts. It is used to calculate the projected available stock and the suggested build schedule. Settings are as follows:
        '''H - Highest of forecasts and sales orders indicates that you want to use either forecasts or sales orders (whichever is the highest figure) as the gross requirement.
        '''C - Cumulative highest of forecasts and s/orders indicates that you want to use the forecasts or sales orders (whichever is the cumulative highest figure) as the gross requirement. This is calculated as the cumulative highest figure less the cumulative gross requirement of the previous period.
        '''A - Sum of forecasts and sales orders indicates that you want to use both the forecasts and sales orders as the gross requirement.
        '''I - Forecasts only indicates that you want to use only forecasts as the gross requirement.
        '''S - Sales orders only indicates that you want to use only sales orders as the gross requirement.
        '''</summary>
        Public Property GrossReqRule() As GrossReqRule
            Get
                Return Me.grossReqRuleField
            End Get
            Set
                Me.grossReqRuleField = value
                Me.GrossReqRuleFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GrossReqRuleSpecified() As Boolean
            Get
                Return Me.grossReqRuleFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Percentage yield is the percentage of the item is lost in the manufacturing process so that a shortfall in actual production does not cause an unexpected inability to meet demand on time.
        '''For example: If a quantity of 10 is required to be manufactured for an item with a yield percentage of 50, then you must schedule 20 in order to meet the demand of 10. This field applies only to MPS items.
        '''The format is 3 characters positive numeric.
        '''</summary>
        Public Property PercentageYield() As String
            Get
                Return Me.percentageYieldField
            End Get
            Set
                Me.percentageYieldField = value
            End Set
        End Property
        
        '''<summary>
        '''WIP ledger control account is the default account to which you want to post the value of work in progress when a job is created for this stock item. 
        '''If not defined against the stock item, then the Work in Progress G/L control account (General Ledger Integration Setup) is used as the default instead. However, at the time of creating the job (Job Maintenance) the ledger code entered at the WIP ledger code field overrides these defaults. The format is 15 characters alphanumeric.
        '''</summary>
        Public Property WipCtlGlCode() As String
            Get
                Return Me.wipCtlGlCodeField
            End Get
            Set
                Me.wipCtlGlCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Resource code is the parent of a resource structure of critical resources for the stock code. It is the default resource parent which can be changed within the Build Schedule Maintenance program. 
        '''This resource parent is applied only to new build schedules; existing build schedules must be maintained to reflect the resource parent.
        '''This is used by the Resource Planning system.
        '''The format is 15 characters alphanumeric.
        '''</summary>
        Public Property ResourceCode() As String
            Get
                Return Me.resourceCodeField
            End Get
            Set
                Me.resourceCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This is the GST code that holds the GST percentage assigned to the stock item. 
        '''This is only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup).
        '''Note: If you do not assign default tax codes to a stock item, then SYSPRO assumes that the item is exempt from tax. In addition, however, if you select the Canadian GST required and Tax by geographic area options (Tax Options Setup) SYSPRO disregards the tax code assigned to the geographic area when calculating tax for that item on a sales order.
        '''The format is 1 character alphanumeric.
        '''</summary>
        Public Property GstTaxCode() As String
            Get
                Return Me.gstTaxCodeField
            End Get
            Set
                Me.gstTaxCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''GST included in price flag indicates whether the calculated tax amount must be included in the price of the item during sales order processing (Y - Yes, N - No). This is only required if your nationality code is defined as CAN (System Setup) and you indicated that the Canadian GST system is required (Tax Options Setup).
        '''Note: If you do not assign default tax codes to a stock item, then SYSPRO assumes that the item is exempt from tax. In addition, however, if you select the Canadian GST required and Tax by geographic area options (Tax Options Setup) SYSPRO disregards the tax code assigned to the geographic area when calculating tax for that item on a sales order.
        '''</summary>
        Public Property PrcInclGst() As PrcInclGst
            Get
                Return Me.prcInclGstField
            End Get
            Set
                Me.prcInclGstField = value
                Me.PrcInclGstFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PrcInclGstSpecified() As Boolean
            Get
                Return Me.prcInclGstFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Capture and record serial numbers at the time of placing an order for a serialized item, or at the time of receipting a serialized item into stock. (Y - Capture serials at time of placing order)
        '''Note: Serial numbers for traceable items are recorded only at the time of processing a receipt. 
        '''</summary>
        Public Property SerEntryAtSale() As SerEntryAtSale
            Get
                Return Me.serEntryAtSaleField
            End Get
            Set
                Me.serEntryAtSaleField = value
                Me.SerEntryAtSaleFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SerEntryAtSaleSpecified() As Boolean
            Get
                Return Me.serEntryAtSaleFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This is a ten character alphanumeric user defined field.
        '''</summary>
        Public Property UserField1() As String
            Get
                Return Me.userField1Field
            End Get
            Set
                Me.userField1Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a 12.5 positive or negative numeric user defined field.
        '''</summary>
        Public Property UserField2() As String
            Get
                Return Me.userField2Field
            End Get
            Set
                Me.userField2Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character alphanumeric user defined field.
        '''</summary>
        Public Property UserField3() As String
            Get
                Return Me.userField3Field
            End Get
            Set
                Me.userField3Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character alphanumeric user defined field.
        '''</summary>
        Public Property UserField4() As String
            Get
                Return Me.userField4Field
            End Get
            Set
                Me.userField4Field = value
            End Set
        End Property
        
        '''<summary>
        '''This is a single character alphanumeric user defined field.
        '''</summary>
        Public Property UserField5() As String
            Get
                Return Me.userField5Field
            End Get
            Set
                Me.userField5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Tariff code for the stock item. This is used in the Landed Cost Tracking system to determine the duty rate applicable to an imported item. 
        '''The tariff code is also used in the EC VAT system to determine the tax rates to be used for items sold across EC borders. 
        '''The format is 15 characters alphanumeric.
        '''</summary>
        Public Property TariffCode() As String
            Get
                Return Me.tariffCodeField
            End Get
            Set
                Me.tariffCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''This indicates whether supplementary units apply to the entry made at the Tariff code field and is printed on the Supplementary Declaration - Despatches report for items sold to an EC country (Y - Yes, N - No). 
        '''Note: This is only relevent if the EC VAT system is in use.
        '''</summary>
        Public Property SupplementaryUnit() As SupplementaryUnit
            Get
                Return Me.supplementaryUnitField
            End Get
            Set
                Me.supplementaryUnitField = value
                Me.SupplementaryUnitFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property SupplementaryUnitSpecified() As Boolean
            Get
                Return Me.supplementaryUnitFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Manufacturing quantity basis is the basis of the elapsed time calculated against work centers or cost centers. Settings are as follows:
        '''E - Economic batch quantity
        '''P - Pan size
        '''</summary>
        Public Property EbqPan() As EbqPan
            Get
                Return Me.ebqPanField
            End Get
            Set
                Me.ebqPanField = value
                Me.EbqPanFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EbqPanSpecified() As Boolean
            Get
                Return Me.ebqPanFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Landed cost tracking required for this item. (N - No, Y - Yes). 
        '''Note:This can only be selected only for bought-out items and it cannot be turned off if a bill of landed costs is attached to the item.
        '''</summary>
        Public Property LctRequired() As LctRequired
            Get
                Return Me.lctRequiredField
            End Get
            Set
                Me.lctRequiredField = value
                Me.LctRequiredFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property LctRequiredSpecified() As Boolean
            Get
                Return Me.lctRequiredFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Issue from multiple lots when processing a sales order for a traceable item and when issuing a traceable item to a job (Y - Yes, N - No). 
        '''Note: You will not be allowed to issue from multiple lots when making a single delivery.
        '''</summary>
        Public Property IssMultLotsFlag() As IssMultLotsFlag
            Get
                Return Me.issMultLotsFlagField
            End Get
            Set
                Me.issMultLotsFlagField = value
                Me.IssMultLotsFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IssMultLotsFlagSpecified() As Boolean
            Get
                Return Me.issMultLotsFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Include in relationship validation flag indicates whether the stock item is included in the processing performed by the Relationship Validation program (Bill of Materials). (Y - Yes, N - No)
        '''</summary>
        Public Property InclInStrValid() As InclInStrValid
            Get
                Return Me.inclInStrValidField
            End Get
            Set
                Me.inclInStrValidField = value
                Me.InclInStrValidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property InclInStrValidSpecified() As Boolean
            Get
                Return Me.inclInStrValidFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Country of origin is the nationality code assigned to the item. It is used for reporting purposes if the EC VAT system is installed.  The format is 3 characters alphanumeric.
        '''</summary>
        Public Property CountryOfOrigin() As String
            Get
                Return Me.countryOfOriginField
            End Get
            Set
                Me.countryOfOriginField = value
            End Set
        End Property
        
        '''<summary>
        '''Hold status flag indicates whether or not the stock item is on hold or not. 
        '''Settings are as follows:
        '''Space - No hold
        '''P - Partial hold limit the transactions that can be processed against a stock item to: moving it from back order to ship (Order Entry) or issuing the item (Inventory Movements).
        '''F - Full hold prevent any transactions from being processed against a stock item. 
        '''</summary>
        Public Property StockOnHold() As StockOnHold
            Get
                Return Me.stockOnHoldField
            End Get
            Set
                Me.stockOnHoldField = value
                Me.StockOnHoldFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockOnHoldSpecified() As Boolean
            Get
                Return Me.stockOnHoldFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Reason code for hold status is the reason for changing the hold status on a stock item. Format is 6 characters alphanumeric.
        '''</summary>
        Public Property StockOnHoldReason() As String
            Get
                Return Me.stockOnHoldReasonField
            End Get
            Set
                Me.stockOnHoldReasonField = value
            End Set
        End Property
        
        '''<summary>
        '''ECC control flag indicates whether the stock item is regulated by the Engineering Change Control system (N - No, Y - Yes). 
        '''Configuring a stock item to be engineering change controlled means that any changes to that item within a bill of materials can only be made by means of an engineering change order.
        '''</summary>
        Public Property EccFlag() As EccFlag
            Get
                Return Me.eccFlagField
            End Get
            Set
                Me.eccFlagField = value
                Me.EccFlagFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property EccFlagSpecified() As Boolean
            Get
                Return Me.eccFlagFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Unit quantity processing flag indicates that the integer portion of the quantity of this item is always expressed as whole numbers of the stocking unit of measure, and the decimal portion as whole numbers of the alternate unit of measure. e.g 10.5 is 10/06. When there are 12 alternates to 1 stocking.
        ''' (N - No, Y - Yes).
        '''Note: If Yes then following must apply:
        '''1. The stocking unit of measure (StockUom)  must differ from the alternate unit of measure (AlternateUom), and  the conversion factor (ConvFactAltUom) must be a whole number and the conversion method (ConvMulDiv) must be divide.
        '''2. The stocking item must not be attached to any other item that is not a planning bill part.
        '''3. The item cannot be manual serialized.
        '''</summary>
        Public Property StockAndAltUm() As StockAndAltUm
            Get
                Return Me.stockAndAltUmField
            End Get
            Set
                Me.stockAndAltUmField = value
                Me.StockAndAltUmFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property StockAndAltUmSpecified() As Boolean
            Get
                Return Me.stockAndAltUmFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Batch bill of materials flag Indicates whether the stock item uses a percentage batch bill of materials. (N - No, Y - Yes)
        '''</summary>
        Public Property BatchBill() As BatchBill
            Get
                Return Me.batchBillField
            End Get
            Set
                Me.batchBillField = value
                Me.BatchBillFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BatchBillSpecified() As Boolean
            Get
                Return Me.batchBillFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Distribution warehouse to use. Format is 2 characters alphanumeric.
        '''</summary>
        Public Property DistWarehouseToUse() As String
            Get
                Return Me.distWarehouseToUseField
            End Get
            Set
                Me.distWarehouseToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''JobClassification is the default job class which you want to use in work in progress when maintaining jobs for this stock item. The format is 4 characters alphanumeric.
        '''</summary>
        Public Property JobClassification() As String
            Get
                Return Me.jobClassificationField
            End Get
            Set
                Me.jobClassificationField = value
            End Set
        End Property
        
        '''<summary>
        '''This element defines the product group to which this item belongs, and is used by the TPM module. If entered, then it must be a valid TPM product group code.
        '''</summary>
        Public Property ProductGroup() As String
            Get
                Return Me.productGroupField
            End Get
            Set
                Me.productGroupField = value
            End Set
        End Property
        
        '''<summary>
        '''This element defines the type of price grouping relevant to this item and is used by the TPM module. If entered, then it must be a valid TPM price type - 'S' - stock code, 'P' - Product class, 'D' - Department, 'G' - Product group.
        '''</summary>
        Public Property PriceType() As PriceType
            Get
                Return Me.priceTypeField
            End Get
            Set
                Me.priceTypeField = value
                Me.PriceTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PriceTypeSpecified() As Boolean
            Get
                Return Me.priceTypeFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element defines the basis on which a price is calcualted and is used by the TPM module. If entered, then it must be a valid TPM price basis, 'Q' - Quantity, 'V' - Volume, and 'M' - Mass / Wieght.
        '''</summary>
        Public Property Basis() As Basis
            Get
                Return Me.basisField
            End Get
            Set
                Me.basisField = value
                Me.BasisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property BasisSpecified() As Boolean
            Get
                Return Me.basisFieldSpecified
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        '''<summary>
        '''Stock code being maintained. The format is up to 30 characters alphanumeric, or 15 characters numeric depending on a configuration option within SYSPRO.
        '''
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MulDiv
        
        '''<remarks/>
        M
        
        '''<remarks/>
        D
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PriceCategory
        
        '''<remarks/>
        A
        
        '''<remarks/>
        B
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        E
        
        '''<remarks/>
        F
        
        '''<remarks/>
        G
        
        '''<remarks/>
        H
        
        '''<remarks/>
        I
        
        '''<remarks/>
        J
        
        '''<remarks/>
        K
        
        '''<remarks/>
        L
        
        '''<remarks/>
        M
        
        '''<remarks/>
        N
        
        '''<remarks/>
        O
        
        '''<remarks/>
        P
        
        '''<remarks/>
        Q
        
        '''<remarks/>
        R
        
        '''<remarks/>
        S
        
        '''<remarks/>
        T
        
        '''<remarks/>
        U
        
        '''<remarks/>
        V
        
        '''<remarks/>
        W
        
        '''<remarks/>
        X
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        Z
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum PriceMethod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        D
        
        '''<remarks/>
        Q
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ReturnableItem
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SerialMethod
        
        '''<remarks/>
        N
        
        '''<remarks/>
        M
        
        '''<remarks/>
        B
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum KitType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        F
        
        '''<remarks/>
        K
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TraceableType
        
        '''<remarks/>
        N
        
        '''<remarks/>
        T
        
        '''<remarks/>
        I
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum InspectionFlag
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
        
        '''<remarks/>
        P
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MpsFlag
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        S
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StockMovementReq
        
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
    Public Enum ManualCostFlag
        
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
    Public Enum PartCategory
        
        '''<remarks/>
        B
        
        '''<remarks/>
        M
        
        '''<remarks/>
        S
        
        '''<remarks/>
        G
        
        '''<remarks/>
        P
        
        '''<remarks/>
        K
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        C
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum OutputMassFlag
        
        '''<remarks/>
        F
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum MakeToOrderFlag
        
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
    Public Enum PrcInclGst
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute(" ")>  _
        Item
        
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
    Public Enum SerEntryAtSale
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum SupplementaryUnit
        
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
    Public Enum LctRequired
        
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
    Public Enum IssMultLotsFlag
        
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
    Public Enum StockOnHold
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
        
        '''<remarks/>
        P
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum StockAndAltUm
        
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
    Public Enum PriceType
        
        '''<remarks/>
        S
        
        '''<remarks/>
        P
        
        '''<remarks/>
        D
        
        '''<remarks/>
        G
        
        '''<remarks/>
        <System.Xml.Serialization.XmlEnumAttribute("")>  _
        Item
    End Enum
End Namespace
