Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace AssetsRegisterPrimaryQuery.AssetDepreciationCalculation.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class AssdepRec
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DepnPrevYrPeriod13
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DepnThisYrPeriod12
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class DepnThisYrPeriod13
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GenbudRec
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GenctlRec
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GenhstRec
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class GroupMinimumBalance
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class InitialAllowPct
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
        Private startDateField As Date
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetCostField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assetBookValueField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private accumDepnField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrField As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod1Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod2Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod3Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod4Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod5Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod6Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod7Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod8Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod9Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod10Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod11Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod12Field As DepnThisYrPeriod12
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnThisYrPeriod13Field As DepnThisYrPeriod13
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod1Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod2Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod3Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod4Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod5Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod6Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod7Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod8Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod9Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod10Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod11Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod12Field As Decimal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depnPrevYrPeriod13Field As DepnPrevYrPeriod13
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDepnPeriodField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private startDepnYearField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDepnPeriodField As SByte
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private endDepnYearField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private depreciationCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private residualValueField As Short
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private groupMinimumBalanceField As GroupMinimumBalance
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private initialAllowPctField As InitialAllowPct
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private statGlCodeField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private thruputAnnumField As Integer
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private numberOfPeriodsField As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private useBudgetsField As UseBudgets
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private residualFlagField As ResidualFlag
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assctlRecField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private assdepRecField As AssdepRec
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private genctlRecField As GenctlRec
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private genhstRecField As GenhstRec
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private genbudRecField As GenbudRec
        
        Public Sub New()
            MyBase.New
            If (Me.genbudRecField Is Nothing) Then
                Me.genbudRecField = New GenbudRec
            End If
            If (Me.genhstRecField Is Nothing) Then
                Me.genhstRecField = New GenhstRec
            End If
            If (Me.genctlRecField Is Nothing) Then
                Me.genctlRecField = New GenctlRec
            End If
            If (Me.assdepRecField Is Nothing) Then
                Me.assdepRecField = New AssdepRec
            End If
            If (Me.initialAllowPctField Is Nothing) Then
                Me.initialAllowPctField = New InitialAllowPct
            End If
            If (Me.groupMinimumBalanceField Is Nothing) Then
                Me.groupMinimumBalanceField = New GroupMinimumBalance
            End If
            If (Me.depnPrevYrPeriod13Field Is Nothing) Then
                Me.depnPrevYrPeriod13Field = New DepnPrevYrPeriod13
            End If
            If (Me.depnThisYrPeriod13Field Is Nothing) Then
                Me.depnThisYrPeriod13Field = New DepnThisYrPeriod13
            End If
            If (Me.depnThisYrPeriod12Field Is Nothing) Then
                Me.depnThisYrPeriod12Field = New DepnThisYrPeriod12
            End If
        End Sub
        
        '''<summary>
        '''Date from which asset is to be depreciated. If no Start depreciation date is supplied, start period and start year is to be supplied. If Varying depreciation method is used, this field is mandatory in order to determine the year number to use for calculation
        '''</summary>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>  _
        Public Property StartDate() As Date
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = value
            End Set
        End Property
        
        '''<summary>
        '''The value of the asset. This field is mandatory.
        '''</summary>
        Public Property AssetCost() As Decimal
            Get
                Return Me.assetCostField
            End Get
            Set
                Me.assetCostField = value
            End Set
        End Property
        
        '''<summary>
        '''The asset book value which would normally be the asset value less accumulated depreciation B/F. This field need only be supplied if the reducing depreciation method id used.
        '''</summary>
        Public Property AssetBookValue() As Decimal
            Get
                Return Me.assetBookValueField
            End Get
            Set
                Me.assetBookValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Accumulated depreciation B/F (if any) This field is not mandatory. 
        '''</summary>
        Public Property AccumDepn() As String
            Get
                Return Me.accumDepnField
            End Get
            Set
                Me.accumDepnField = value
            End Set
        End Property
        
        '''<summary>
        '''This field contains the total depreciation for the last financial year (if any). If you supply depreciation balances for previous year periods 1-13, it is advisable not to supply this field. If you supply both this field and the depreciation balances for previous years, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYr() As Decimal
            Get
                Return Me.depnPrevYrField
            End Get
            Set
                Me.depnPrevYrField = value
            End Set
        End Property
        
        '''<summary>
        '''This field contains the total depreciation for the current financial year (if any). If you supply depreciation balances for this year periods 1-13, it is advisable not to supply this field. If you supply both this field and the depreciation balances for this year, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYr() As Decimal
            Get
                Return Me.depnThisYrField
            End Get
            Set
                Me.depnThisYrField = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 1. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod1() As Decimal
            Get
                Return Me.depnThisYrPeriod1Field
            End Get
            Set
                Me.depnThisYrPeriod1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 2. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod2() As Decimal
            Get
                Return Me.depnThisYrPeriod2Field
            End Get
            Set
                Me.depnThisYrPeriod2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 3. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod3() As Decimal
            Get
                Return Me.depnThisYrPeriod3Field
            End Get
            Set
                Me.depnThisYrPeriod3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 4. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod4() As Decimal
            Get
                Return Me.depnThisYrPeriod4Field
            End Get
            Set
                Me.depnThisYrPeriod4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 5. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod5() As Decimal
            Get
                Return Me.depnThisYrPeriod5Field
            End Get
            Set
                Me.depnThisYrPeriod5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 6. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod6() As Decimal
            Get
                Return Me.depnThisYrPeriod6Field
            End Get
            Set
                Me.depnThisYrPeriod6Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 7. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod7() As Decimal
            Get
                Return Me.depnThisYrPeriod7Field
            End Get
            Set
                Me.depnThisYrPeriod7Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 8. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod8() As Decimal
            Get
                Return Me.depnThisYrPeriod8Field
            End Get
            Set
                Me.depnThisYrPeriod8Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 9. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod9() As Decimal
            Get
                Return Me.depnThisYrPeriod9Field
            End Get
            Set
                Me.depnThisYrPeriod9Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 10. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod10() As Decimal
            Get
                Return Me.depnThisYrPeriod10Field
            End Get
            Set
                Me.depnThisYrPeriod10Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 11. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod11() As Decimal
            Get
                Return Me.depnThisYrPeriod11Field
            End Get
            Set
                Me.depnThisYrPeriod11Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 12. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod12() As DepnThisYrPeriod12
            Get
                Return Me.depnThisYrPeriod12Field
            End Get
            Set
                Me.depnThisYrPeriod12Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance this year period 13. If you supply both this field and the depreciation depreciation this year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnThisYrPeriod13() As DepnThisYrPeriod13
            Get
                Return Me.depnThisYrPeriod13Field
            End Get
            Set
                Me.depnThisYrPeriod13Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 1. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod1() As Decimal
            Get
                Return Me.depnPrevYrPeriod1Field
            End Get
            Set
                Me.depnPrevYrPeriod1Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 2. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod2() As Decimal
            Get
                Return Me.depnPrevYrPeriod2Field
            End Get
            Set
                Me.depnPrevYrPeriod2Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 3. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod3() As Decimal
            Get
                Return Me.depnPrevYrPeriod3Field
            End Get
            Set
                Me.depnPrevYrPeriod3Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 4. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod4() As Decimal
            Get
                Return Me.depnPrevYrPeriod4Field
            End Get
            Set
                Me.depnPrevYrPeriod4Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 5. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod5() As Decimal
            Get
                Return Me.depnPrevYrPeriod5Field
            End Get
            Set
                Me.depnPrevYrPeriod5Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 6. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod6() As Decimal
            Get
                Return Me.depnPrevYrPeriod6Field
            End Get
            Set
                Me.depnPrevYrPeriod6Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 7. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod7() As Decimal
            Get
                Return Me.depnPrevYrPeriod7Field
            End Get
            Set
                Me.depnPrevYrPeriod7Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 8. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod8() As Decimal
            Get
                Return Me.depnPrevYrPeriod8Field
            End Get
            Set
                Me.depnPrevYrPeriod8Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 9. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod9() As Decimal
            Get
                Return Me.depnPrevYrPeriod9Field
            End Get
            Set
                Me.depnPrevYrPeriod9Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 10. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod10() As Decimal
            Get
                Return Me.depnPrevYrPeriod10Field
            End Get
            Set
                Me.depnPrevYrPeriod10Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 11. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod11() As Decimal
            Get
                Return Me.depnPrevYrPeriod11Field
            End Get
            Set
                Me.depnPrevYrPeriod11Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 12. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod12() As Decimal
            Get
                Return Me.depnPrevYrPeriod12Field
            End Get
            Set
                Me.depnPrevYrPeriod12Field = value
            End Set
        End Property
        
        '''<summary>
        '''Depreciation balance previous year period 13. If you supply both this field and the depreciation depreciation previous year field, they must balance to each other or an error will occur.
        '''</summary>
        Public Property DepnPrevYrPeriod13() As DepnPrevYrPeriod13
            Get
                Return Me.depnPrevYrPeriod13Field
            End Get
            Set
                Me.depnPrevYrPeriod13Field = value
            End Set
        End Property
        
        '''<summary>
        '''The start depreciation period from which depreciation is to be calculated. If not supplied and start date is supplied, this will be calculated from the start date. If neither start date or start period is suppled, the default will be the last depreciation period + 1. This field is mandatory if 13 periods
        '''</summary>
        <CLSCompliant(False)> _
        Public Property StartDepnPeriod() As SByte
            Get
                Return Me.startDepnPeriodField
            End Get
            Set(ByVal value As SByte)
                Me.startDepnPeriodField = Value
            End Set
        End Property
        
        '''<summary>
        '''The start depreciation year from which depreciation is to be calculated. If not supplied and start date is supplied, this will be calculated from the start date. If neither start date or start year is suppled, the default will be the current assets year
        '''</summary>
        Public Property StartDepnYear() As Short
            Get
                Return Me.startDepnYearField
            End Get
            Set
                Me.startDepnYearField = value
            End Set
        End Property
        
        '''<summary>
        '''The period up to which depreciation is to be calculated. It can be future or past. If not supplied, the default will be the last depreciation period + 1. This field is mandatory for 13 periods
        '''</summary>
        <CLSCompliant(False)> _
        Public Property EndDepnPeriod() As SByte
            Get
                Return Me.endDepnPeriodField
            End Get
            Set(ByVal value As SByte)
                Me.endDepnPeriodField = Value
            End Set
        End Property
        
        '''<summary>
        '''The year up to which depreciation is to be calculated. It can be future or past. If not supplied, the default will be the current asset year
        '''</summary>
        Public Property EndDepnYear() As Short
            Get
                Return Me.endDepnYearField
            End Get
            Set
                Me.endDepnYearField = value
            End Set
        End Property
        
        '''<summary>
        '''The depreciation code for which depreciation is to be calculated. This field is mandatory.
        '''</summary>
        Public Property DepreciationCode() As String
            Get
                Return Me.depreciationCodeField
            End Get
            Set
                Me.depreciationCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''Residual value down to which an asset will be depreciated
        '''</summary>
        Public Property ResidualValue() As Short
            Get
                Return Me.residualValueField
            End Get
            Set
                Me.residualValueField = value
            End Set
        End Property
        
        '''<summary>
        '''Group minimum balance field. This field is not mandatory
        '''</summary>
        Public Property GroupMinimumBalance() As GroupMinimumBalance
            Get
                Return Me.groupMinimumBalanceField
            End Get
            Set
                Me.groupMinimumBalanceField = value
            End Set
        End Property
        
        '''<summary>
        '''Initial allowance percent is applicable only when calculating depreciation for tax.
        '''</summary>
        Public Property InitialAllowPct() As InitialAllowPct
            Get
                Return Me.initialAllowPctField
            End Get
            Set
                Me.initialAllowPctField = value
            End Set
        End Property
        
        '''<summary>
        '''The Statistical G/L code is mandatory for Statistical EUL depreciation method
        '''</summary>
        Public Property StatGlCode() As String
            Get
                Return Me.statGlCodeField
            End Get
            Set
                Me.statGlCodeField = value
            End Set
        End Property
        
        '''<summary>
        '''The throughput EUL field is mandatory for Statistical EUL depreciation method
        '''</summary>
        Public Property ThruputAnnum() As Integer
            Get
                Return Me.thruputAnnumField
            End Get
            Set
                Me.thruputAnnumField = value
            End Set
        End Property
        
        '''<summary>
        '''Number of periods EUL is mandatory for Fixed EUL depreciation method
        '''</summary>
        Public Property NumberOfPeriods() As Boolean
            Get
                Return Me.numberOfPeriodsField
            End Get
            Set
                Me.numberOfPeriodsField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is used for statistical EUL depreciation method only. If this flag is "Y", G/L budgets will be used for calculating depreciation for any periods future to the current G/L period. For example, if you are printing a movements report for future periods, it is correct to use G/L budgets to estimate depreciation. However, if you are calculating actual book value depreciation, only actual throughput can be taken into account. If this field is not supplied, the default value is "N".
        '''</summary>
        Public Property UseBudgets() As UseBudgets
            Get
                Return Me.useBudgetsField
            End Get
            Set
                Me.useBudgetsField = value
            End Set
        End Property
        
        '''<summary>
        '''This field is only necessary if using a residual value. If this flag is = "Y", the residual value will be subtracted from the asset value before calculating depreciation. The default value is "N".
        '''</summary>
        Public Property ResidualFlag() As ResidualFlag
            Get
                Return Me.residualFlagField
            End Get
            Set
                Me.residualFlagField = value
            End Set
        End Property
        
        '''<summary>
        '''This field should only be used when the calling program is SQL-optimized and an extra read would slow the process down.It will contain the Asset Control record. If this field is not supplied, the program will open the table and read this record.
        '''</summary>
        Public Property AssctlRec() As String
            Get
                Return Me.assctlRecField
            End Get
            Set
                Me.assctlRecField = value
            End Set
        End Property
        
        '''<summary>
        '''This field should only be used only when the calling program is SQL-optimized and an extra read would slow the process down.It will contain the Asset depreciation record. If this field is not supplied, the program will open the table and read this record.
        '''</summary>
        Public Property AssdepRec() As AssdepRec
            Get
                Return Me.assdepRecField
            End Get
            Set
                Me.assdepRecField = value
            End Set
        End Property
        
        '''<summary>
        '''This field should only be used when the calling program is SQL-optimized and an extra read would slow the process down.It applies only to statistical EUL depreciation method and will contain the G/L control record. If this field is not supplied, the program will open the table and read this record.
        '''</summary>
        Public Property GenctlRec() As GenctlRec
            Get
                Return Me.genctlRecField
            End Get
            Set
                Me.genctlRecField = value
            End Set
        End Property
        
        '''<summary>
        '''This field should only be used when the calling program is SQL-optimized and an extra read would slow the process down.It applies only to statistical EUL depreciation method and will contain the G/L history record. If this field is not supplied, the program will open the table and read this record.
        '''</summary>
        Public Property GenhstRec() As GenhstRec
            Get
                Return Me.genhstRecField
            End Get
            Set
                Me.genhstRecField = value
            End Set
        End Property
        
        '''<summary>
        '''This field should only be used when the calling program is SQL-optimized and an extra read would slow the process down.It applies only to statistical EUL depreciation method and will contain the G/L budget record. If this field is not supplied, the program will open the table and read this record.
        '''</summary>
        Public Property GenbudRec() As GenbudRec
            Get
                Return Me.genbudRecField
            End Get
            Set
                Me.genbudRecField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum UseBudgets
        
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
    Public Enum ResidualFlag
        
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
        End Sub
        
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
                Return "ASSQDP"
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
