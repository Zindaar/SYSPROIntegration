Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace CashBookPrimaryQuery.CashBookTransactionQuery.QueryData
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum AsOfPeriod
        
        '''<remarks/>
        C
        
        '''<remarks/>
        P
        
        '''<remarks/>
        B
        
        '''<remarks/>
        F
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum DateSequence
        
        '''<remarks/>
        E
        
        '''<remarks/>
        L
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IncludeApInfo
        
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
    Public Enum IncludeArInfo
        
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
    Public Enum IncludeCurrencyInfo
        
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
    Public Enum IncludeDeposits
        
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
    Public Enum IncludeReconciled
        
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
    Public Enum IncludeUnreconciled
        
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
    Public Enum IncludeWithdrawals
        
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
    Partial Public Class Key
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private bankField As String
        
        '''<summary>
        '''This is a mandatory element and must contain a valid SYSPRO Bank code. The format is two characters, alphanumeric.
        '''</summary>
        Public Property Bank() As String
            Get
                Return Me.bankField
            End Get
            Set
                Me.bankField = value
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
        Private includeDepositsField As IncludeDeposits
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeDepositsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWithdrawalsField As IncludeWithdrawals
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeWithdrawalsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReconciledField As IncludeReconciled
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeReconciledFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUnreconciledField As IncludeUnreconciled
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeUnreconciledFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateSequenceField As DateSequence
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private dateSequenceFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrencyInfoField As IncludeCurrencyInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeCurrencyInfoFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private asOfPeriodField As AsOfPeriod
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private asOfPeriodFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnToViewField As TrnToView
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private trnToViewFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApInfoField As IncludeApInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeApInfoFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeArInfoField As IncludeArInfo
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private includeArInfoFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private xslStylesheetField As String
        
        Public Sub New()
            MyBase.New
            Me.includeDepositsField = IncludeDeposits.Y
            Me.includeWithdrawalsField = IncludeWithdrawals.Y
            Me.includeReconciledField = IncludeReconciled.Y
            Me.includeUnreconciledField = IncludeUnreconciled.Y
            Me.dateSequenceField = DateSequence.E
            Me.includeCurrencyInfoField = IncludeCurrencyInfo.N
            Me.asOfPeriodField = AsOfPeriod.C
            Me.trnToViewField = TrnToView.A
            Me.includeApInfoField = IncludeApInfo.N
            Me.includeArInfoField = IncludeArInfo.N
        End Sub
        
        '''<summary>
        '''Used to include or exclude cash book deposits in the returned data (Y - Yes, N - No). If this element is not provided the default is Y.
        '''</summary>
        Public Property IncludeDeposits() As IncludeDeposits
            Get
                Return Me.includeDepositsField
            End Get
            Set
                Me.includeDepositsField = value
                Me.IncludeDepositsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeDepositsSpecified() As Boolean
            Get
                Return Me.includeDepositsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Used to include or exclude cash book withdrawals in the returned data (Y - Yes, N - No). If this element is not provided the default  is Y.
        '''</summary>
        Public Property IncludeWithdrawals() As IncludeWithdrawals
            Get
                Return Me.includeWithdrawalsField
            End Get
            Set
                Me.includeWithdrawalsField = value
                Me.IncludeWithdrawalsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeWithdrawalsSpecified() As Boolean
            Get
                Return Me.includeWithdrawalsFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Used to include or exclude reconciled entries from the cash book in the returned data (Y - Yes, N - No). If this element is not provided the default is Y.
        '''</summary>
        Public Property IncludeReconciled() As IncludeReconciled
            Get
                Return Me.includeReconciledField
            End Get
            Set
                Me.includeReconciledField = value
                Me.IncludeReconciledFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeReconciledSpecified() As Boolean
            Get
                Return Me.includeReconciledFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Used to include or exclude unreconciled entries from the cash book in the returned data (Y - Yes, N - No). If this element is not provided the default is Y.
        '''</summary>
        Public Property IncludeUnreconciled() As IncludeUnreconciled
            Get
                Return Me.includeUnreconciledField
            End Get
            Set
                Me.includeUnreconciledField = value
                Me.IncludeUnreconciledFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeUnreconciledSpecified() As Boolean
            Get
                Return Me.includeUnreconciledFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The posting date sequence that the cash book entries are to be returned (E - Earliest records are returned first, L - Latest records are returned first). If the element is not provided the default is E.
        '''</summary>
        Public Property DateSequence() As DateSequence
            Get
                Return Me.dateSequenceField
            End Get
            Set
                Me.dateSequenceField = value
                Me.DateSequenceFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property DateSequenceSpecified() As Boolean
            Get
                Return Me.dateSequenceFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''Used to include or exclude information about the currency in the returned data (N - No, Y - Yes). If this element is not provided the default is N.
        '''</summary>
        Public Property IncludeCurrencyInfo() As IncludeCurrencyInfo
            Get
                Return Me.includeCurrencyInfoField
            End Get
            Set
                Me.includeCurrencyInfoField = value
                Me.IncludeCurrencyInfoFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeCurrencyInfoSpecified() As Boolean
            Get
                Return Me.includeCurrencyInfoFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element specifies the period from which to return data (C - transactions from the current cash book period backwards, P - transactions from the previous cash book period backwards, B - transactions from the cash book previous period two backwards, F - transactions from the current cash book period backwards including future transactions).If this element is not provided the default is C.
        '''</summary>
        Public Property AsOfPeriod() As AsOfPeriod
            Get
                Return Me.asOfPeriodField
            End Get
            Set
                Me.asOfPeriodField = value
                Me.AsOfPeriodFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property AsOfPeriodSpecified() As Boolean
            Get
                Return Me.asOfPeriodFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element is only relevant if the 'AsOfPeriod' selected is C. The valid values are:
        '''A - return all transactions for all periods up to and including the current cashbook period 
        '''C - only return transactions for the current cashbook period If this element is not provided the default is A.
        '''</summary>
        Public Property TrnToView() As TrnToView
            Get
                Return Me.trnToViewField
            End Get
            Set
                Me.trnToViewField = value
                Me.TrnToViewFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property TrnToViewSpecified() As Boolean
            Get
                Return Me.trnToViewFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include the Accounts Payable details associated with a Cash Book transaction originated from Accounts Payable (N - No, Y - Yes). If this element is not provided the default is N.
        '''</summary>
        Public Property IncludeApInfo() As IncludeApInfo
            Get
                Return Me.includeApInfoField
            End Get
            Set
                Me.includeApInfoField = value
                Me.IncludeApInfoFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeApInfoSpecified() As Boolean
            Get
                Return Me.includeApInfoFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This specifies whether to include the Accounts Receivable details associated with a Cash Book transaction originated from Accounts Receivable (N - No, Y - Yes). If this element is not provided the default is N.
        '''</summary>
        Public Property IncludeArInfo() As IncludeArInfo
            Get
                Return Me.includeArInfoField
            End Get
            Set
                Me.includeArInfoField = value
                Me.IncludeArInfoFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IncludeArInfoSpecified() As Boolean
            Get
                Return Me.includeArInfoFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''The XSL Stylesheet to be used.
        '''</summary>
        Public Property XslStylesheet() As String
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum TrnToView
        
        '''<remarks/>
        A
        
        '''<remarks/>
        C
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
        '''This element contains the key on which the query is to be performed.
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
        '''This element contains optional parameters to increase / decrease the amount of information returned, or change the sequence of the data returned.
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
                Return "CSHQRY"
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
