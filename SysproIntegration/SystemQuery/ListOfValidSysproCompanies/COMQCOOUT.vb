Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace SystemQuery.ListOfValidSysproCompanies.Output
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Companies
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyField As CompaniesCompany
        
        Public Sub New()
            MyBase.New
            If (Me.companyField Is Nothing) Then
                Me.companyField = New CompaniesCompany
            End If
        End Sub
        
        Public Property Company() As CompaniesCompany
            Get
                Return Me.companyField
            End Get
            Set
                Me.companyField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class CompaniesCompany
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIdField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyNameField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private databaseFormatField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private sysproAnalyticsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private analyticsViewerField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyVersionField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyIssueField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private companyServicePackField As String
        
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
        
        Public Property DatabaseFormat() As String
            Get
                Return Me.databaseFormatField
            End Get
            Set
                Me.databaseFormatField = value
            End Set
        End Property
        
        Public Property SysproAnalytics() As String
            Get
                Return Me.sysproAnalyticsField
            End Get
            Set
                Me.sysproAnalyticsField = value
            End Set
        End Property
        
        Public Property AnalyticsViewer() As String
            Get
                Return Me.analyticsViewerField
            End Get
            Set
                Me.analyticsViewerField = value
            End Set
        End Property
        
        Public Property CompanyVersion() As String
            Get
                Return Me.companyVersionField
            End Get
            Set
                Me.companyVersionField = value
            End Set
        End Property
        
        Public Property CompanyIssue() As String
            Get
                Return Me.companyIssueField
            End Get
            Set
                Me.companyIssueField = value
            End Set
        End Property
        
        Public Property CompanyServicePack() As String
            Get
                Return Me.companyServicePackField
            End Get
            Set
                Me.companyServicePackField = value
            End Set
        End Property
    End Class
End Namespace
