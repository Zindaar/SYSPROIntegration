Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace InventoryPrimaryQuery.InventoryAvailableToPromiseQuery.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class AtpQuery
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private systemInformationField As AtpQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockItemField As AtpQueryStockItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private atpDetailsField As List(Of AtpQueryAtpLine)
        
        Public Sub New()
            MyBase.New
            If (Me.atpDetailsField Is Nothing) Then
                Me.atpDetailsField = New List(Of AtpQueryAtpLine)
            End If
            If (Me.stockItemField Is Nothing) Then
                Me.stockItemField = New AtpQueryStockItem
            End If
            If (Me.systemInformationField Is Nothing) Then
                Me.systemInformationField = New AtpQuerySystemInformation
            End If
        End Sub
        
        Public Property SystemInformation() As AtpQuerySystemInformation
            Get
                Return Me.systemInformationField
            End Get
            Set
                Me.systemInformationField = value
            End Set
        End Property
        
        Public Property StockItem() As AtpQueryStockItem
            Get
                Return Me.stockItemField
            End Get
            Set
                Me.stockItemField = value
            End Set
        End Property
        
        <System.Xml.Serialization.XmlArrayItemAttribute("AtpLine", IsNullable:=False)> _
        Public Property AtpDetailsCollection() As List(Of AtpQueryAtpLine)
            Get
                Return Me.atpDetailsField
            End Get
            Set(ByVal value As List(Of AtpQueryAtpLine))
                Me.atpDetailsField = value
            End Set
        End Property

        Public Shared Function CreateFromXMLOut(ByVal strXMLOut As String) As AtpQuery
            Using stream As New IO.StringReader(strXMLOut)

                Dim s As New System.Xml.Serialization.XmlSerializer(GetType(AtpQuery))

                Dim qry As AtpQuery = s.Deserialize(stream)

                Return qry
            End Using
        End Function

    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class AtpQuerySystemInformation
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cssStyleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private languageField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private decFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private roleField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorGroupField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorEmailAddressField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private operatorLocationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private reportDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useSeparatorOnReportsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private separatorToUseField As String
        
        Public Property CssStyle() As String
            Get
                Return Me.cssStyleField
            End Get
            Set
                Me.cssStyleField = value
            End Set
        End Property
        
        Public Property Language() As String
            Get
                Return Me.languageField
            End Get
            Set
                Me.languageField = value
            End Set
        End Property
        
        Public Property DecFormat() As String
            Get
                Return Me.decFormatField
            End Get
            Set
                Me.decFormatField = value
            End Set
        End Property
        
        Public Property DateFormat() As String
            Get
                Return Me.dateFormatField
            End Get
            Set
                Me.dateFormatField = value
            End Set
        End Property
        
        Public Property Role() As String
            Get
                Return Me.roleField
            End Get
            Set
                Me.roleField = value
            End Set
        End Property
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property CompanyId() As String
            Get
                Return Me.companyIdField
            End Get
            Set
                Me.companyIdField = value
            End Set
        End Property
        
        Public Property CompanyName() As String
            Get
                Return Me.companyNameField
            End Get
            Set
                Me.companyNameField = value
            End Set
        End Property
        
        Public Property OperatorCode() As String
            Get
                Return Me.operatorCodeField
            End Get
            Set
                Me.operatorCodeField = value
            End Set
        End Property
        
        Public Property OperatorName() As String
            Get
                Return Me.operatorNameField
            End Get
            Set
                Me.operatorNameField = value
            End Set
        End Property
        
        Public Property OperatorGroup() As String
            Get
                Return Me.operatorGroupField
            End Get
            Set
                Me.operatorGroupField = value
            End Set
        End Property
        
        Public Property OperatorEmailAddress() As String
            Get
                Return Me.operatorEmailAddressField
            End Get
            Set
                Me.operatorEmailAddressField = value
            End Set
        End Property
        
        Public Property OperatorLocation() As String
            Get
                Return Me.operatorLocationField
            End Get
            Set
                Me.operatorLocationField = value
            End Set
        End Property
        
        Public Property ReportDate() As String
            Get
                Return Me.reportDateField
            End Get
            Set
                Me.reportDateField = value
            End Set
        End Property
        
        Public Property UseSeparatorOnReports() As String
            Get
                Return Me.useSeparatorOnReportsField
            End Get
            Set
                Me.useSeparatorOnReportsField = value
            End Set
        End Property
        
        Public Property SeparatorToUse() As String
            Get
                Return Me.separatorToUseField
            End Get
            Set
                Me.separatorToUseField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class AtpQueryStockItem
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private longDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private versionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private releaseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private stockUomField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private makeToOrderFlagField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private warehouseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private whDescField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private runDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dtfFormulaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dtfCalculationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ttfFormulaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ttfCalculationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtfFormulaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private mtfCalculationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ptfFormulaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ptfCalculationField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phFormulaField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private phCalculationField As String
        
        Public Property StockCode() As String
            Get
                Return Me.stockCodeField
            End Get
            Set
                Me.stockCodeField = value
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
        
        Public Property LongDesc() As String
            Get
                Return Me.longDescField
            End Get
            Set
                Me.longDescField = value
            End Set
        End Property
        
        Public Property Version() As String
            Get
                Return Me.versionField
            End Get
            Set
                Me.versionField = value
            End Set
        End Property
        
        Public Property Release() As String
            Get
                Return Me.releaseField
            End Get
            Set
                Me.releaseField = value
            End Set
        End Property
        
        Public Property StockUom() As String
            Get
                Return Me.stockUomField
            End Get
            Set
                Me.stockUomField = value
            End Set
        End Property
        
        Public Property MakeToOrderFlag() As String
            Get
                Return Me.makeToOrderFlagField
            End Get
            Set
                Me.makeToOrderFlagField = value
            End Set
        End Property
        
        Public Property Warehouse() As String
            Get
                Return Me.warehouseField
            End Get
            Set
                Me.warehouseField = value
            End Set
        End Property
        
        Public Property WhDesc() As String
            Get
                Return Me.whDescField
            End Get
            Set
                Me.whDescField = value
            End Set
        End Property
        
        Public Property RunDate() As String
            Get
                Return Me.runDateField
            End Get
            Set
                Me.runDateField = value
            End Set
        End Property
        
        Public Property DtfFormula() As String
            Get
                Return Me.dtfFormulaField
            End Get
            Set
                Me.dtfFormulaField = value
            End Set
        End Property
        
        Public Property DtfCalculation() As String
            Get
                Return Me.dtfCalculationField
            End Get
            Set
                Me.dtfCalculationField = value
            End Set
        End Property
        
        Public Property TtfFormula() As String
            Get
                Return Me.ttfFormulaField
            End Get
            Set
                Me.ttfFormulaField = value
            End Set
        End Property
        
        Public Property TtfCalculation() As String
            Get
                Return Me.ttfCalculationField
            End Get
            Set
                Me.ttfCalculationField = value
            End Set
        End Property
        
        Public Property MtfFormula() As String
            Get
                Return Me.mtfFormulaField
            End Get
            Set
                Me.mtfFormulaField = value
            End Set
        End Property
        
        Public Property MtfCalculation() As String
            Get
                Return Me.mtfCalculationField
            End Get
            Set
                Me.mtfCalculationField = value
            End Set
        End Property
        
        Public Property PtfFormula() As String
            Get
                Return Me.ptfFormulaField
            End Get
            Set
                Me.ptfFormulaField = value
            End Set
        End Property
        
        Public Property PtfCalculation() As String
            Get
                Return Me.ptfCalculationField
            End Get
            Set
                Me.ptfCalculationField = value
            End Set
        End Property
        
        Public Property PhFormula() As String
            Get
                Return Me.phFormulaField
            End Get
            Set
                Me.phFormulaField = value
            End Set
        End Property
        
        Public Property PhCalculation() As String
            Get
                Return Me.phCalculationField
            End Get
            Set
                Me.phCalculationField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class AtpQueryAtpLine
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private descriptionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceKeyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sourceKeyLineField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private supplyQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private demandQtyField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private projOnHandField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private availToPromiseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private cumeAvailToPromiseField As String
        
        Public Property [Date]() As String
            Get
                Return Me.dateField
            End Get
            Set
                Me.dateField = value
            End Set
        End Property
        
        Public Property Source() As String
            Get
                Return Me.sourceField
            End Get
            Set
                Me.sourceField = value
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
        
        Public Property SourceKey() As String
            Get
                Return Me.sourceKeyField
            End Get
            Set
                Me.sourceKeyField = value
            End Set
        End Property
        
        Public Property SourceKeyLine() As String
            Get
                Return Me.sourceKeyLineField
            End Get
            Set
                Me.sourceKeyLineField = value
            End Set
        End Property
        
        Public Property SupplyQty() As String
            Get
                Return Me.supplyQtyField
            End Get
            Set
                Me.supplyQtyField = value
            End Set
        End Property
        
        Public Property DemandQty() As String
            Get
                Return Me.demandQtyField
            End Get
            Set
                Me.demandQtyField = value
            End Set
        End Property
        
        Public Property ProjOnHand() As String
            Get
                Return Me.projOnHandField
            End Get
            Set
                Me.projOnHandField = value
            End Set
        End Property
        
        Public Property AvailToPromise() As String
            Get
                Return Me.availToPromiseField
            End Get
            Set
                Me.availToPromiseField = value
            End Set
        End Property
        
        Public Property CumeAvailToPromise() As String
            Get
                Return Me.cumeAvailToPromiseField
            End Get
            Set
                Me.cumeAvailToPromiseField = value
            End Set
        End Property
    End Class
End Namespace
