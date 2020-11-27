Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SalesOrdersPrimaryQuery.TpmPromotionCodeQuery.QueryData

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Query
        Implements Codewell.SysproIntegration.IQuery

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private optionField As QueryOption

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterField As QueryFilter

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _queryActionTypeField As CommonEnums.ActionType_Query

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private _xmlOut As String

        Public Sub New()
            MyBase.New
            If (Me.filterField Is Nothing) Then
                Me.filterField = New QueryFilter()
            End If
            If (Me.optionField Is Nothing) Then
                Me.optionField = New QueryOption()
            End If
        End Sub

        Public Property [Option]() As QueryOption
            Get
                Return Me.optionField
            End Get
            Set
                Me.optionField = Value
            End Set
        End Property

        Public Property Filter() As QueryFilter
            Get
                Return Me.filterField
            End Get
            Set
                Me.filterField = Value
            End Set
        End Property

        Public Overridable Property QueryActionType() As CommonEnums.ActionType_Query Implements IQuery.QueryActionType
            Get
                Return _queryActionTypeField
            End Get
            Set
                Me._queryActionTypeField = Value
            End Set
        End Property

        Public Overridable ReadOnly Property XmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Overridable ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "TPMQPC"
            End Get
        End Property

        Public Overridable ReadOnly Property XMLData() As String Implements IQuery.xmlData
            Get
                Return Common.SysproUtilities.SerializeToXMLString(Me)
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
            If (blnThrowExceptionOnErrorInXMLOut = True) Then
                Common.SysproUtilities.CheckXMLOut(XMLData, "", XmlOut)
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryOption

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private includeExpiredPromotionsField As QueryOptionIncludeExpiredPromotions

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private globalPromotionsField As QueryOptionGlobalPromotions

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private xslStylesheetField As String

        Public Sub New()
            MyBase.New
            Me.includeExpiredPromotionsField = QueryOptionIncludeExpiredPromotions.N
            Me.globalPromotionsField = QueryOptionGlobalPromotions.I
        End Sub

        <System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeExpiredPromotions.N)>
        Public Property IncludeExpiredPromotions() As QueryOptionIncludeExpiredPromotions
            Get
                Return Me.includeExpiredPromotionsField
            End Get
            Set
                Me.includeExpiredPromotionsField = Value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(QueryOptionGlobalPromotions.I)>
        Public Property GlobalPromotions() As QueryOptionGlobalPromotions
            Get
                Return Me.globalPromotionsField
            End Get
            Set
                Me.globalPromotionsField = Value
            End Set
        End Property

        Public Property XslStylesheet() As String
            Get
                Return Me.xslStylesheetField
            End Get
            Set
                Me.xslStylesheetField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum QueryOptionIncludeExpiredPromotions

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum QueryOptionGlobalPromotions

        '''<remarks/>
        I

        '''<remarks/>
        E

        '''<remarks/>
        O
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryFilter

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private promotionCodeField As QueryFilterPromotionCode

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private promotionTypeField As QueryFilterPromotionType

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private expiryDateField As QueryFilterExpiryDate

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private startDateField As QueryFilterStartDate

        Public Sub New()
            MyBase.New
            If (Me.startDateField Is Nothing) Then
                Me.startDateField = New QueryFilterStartDate()
            End If
            If (Me.expiryDateField Is Nothing) Then
                Me.expiryDateField = New QueryFilterExpiryDate()
            End If
            If (Me.promotionTypeField Is Nothing) Then
                Me.promotionTypeField = New QueryFilterPromotionType()
            End If
            If (Me.promotionCodeField Is Nothing) Then
                Me.promotionCodeField = New QueryFilterPromotionCode()
            End If
        End Sub

        Public Property PromotionCode() As QueryFilterPromotionCode
            Get
                Return Me.promotionCodeField
            End Get
            Set
                Me.promotionCodeField = Value
            End Set
        End Property

        Public Property PromotionType() As QueryFilterPromotionType
            Get
                Return Me.promotionTypeField
            End Get
            Set
                Me.promotionTypeField = Value
            End Set
        End Property

        Public Property ExpiryDate() As QueryFilterExpiryDate
            Get
                Return Me.expiryDateField
            End Get
            Set
                Me.expiryDateField = Value
            End Set
        End Property

        Public Property StartDate() As QueryFilterStartDate
            Get
                Return Me.startDateField
            End Get
            Set
                Me.startDateField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryFilterPromotionCode

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterValueField As String

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryFilterPromotionType

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterValueField As String

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryFilterExpiryDate

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterValueField As String

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("StandaloneXSDGenerator", "1.0.0.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class QueryFilterStartDate

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterTypeField As String

        <EditorBrowsable(EditorBrowsableState.Never)>
        Private filterValueField As String

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterType() As String
            Get
                Return Me.filterTypeField
            End Get
            Set
                Me.filterTypeField = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property FilterValue() As String
            Get
                Return Me.filterValueField
            End Get
            Set
                Me.filterValueField = Value
            End Set
        End Property
    End Class
End Namespace
