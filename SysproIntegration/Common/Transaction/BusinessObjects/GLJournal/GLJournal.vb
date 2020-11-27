Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO

Namespace TransactionObjects
    <Serializable()> Public Class GLJournal
        Implements ITransaction

#Region "Private Data Members"

        Dim _PostGlJournal As String = String.Empty
        Dim _Parameters As String = String.Empty
        Dim _IgnoreWarnings As GLJournal_IgnoreWarnings_Enum
        Dim _ApplyIfEntireDocumentValid As GLJournal_ApplyIfEntireDocumentValid_Enum
        Dim _ValidateOnly As GLJournal_ValidateOnly_Enum
        Dim _ActionType As GLJournal_ActionType_Enum

        Dim _Item As String = String.Empty
        Dim _JournalType As GLJournal_JournalType_Enum
        Dim _JournalNumber As String = String.Empty
        Dim _AuthorizeJournal As GLJournal_AuthorizeJournal_Enum
        Dim _PostJournal As GLJournal_PostJournal_Enum = GLJournal_PostJournal_Enum.PostJournal_Upper_N
        Dim _CancelJournal As GLJournal_CancelJournal_Enum
        Dim _HoldJournal As GLJournal_HoldJournal_Enum
        Dim _JournalDate As String = String.Empty
        Dim _JournalReference As String = String.Empty
        Dim _Notation As String = String.Empty
        Dim _PostingPeriod As String = String.Empty
        Dim _PostingYear As String = String.Empty
        Dim _SourceCode As String = String.Empty
        Dim _Currency As String = String.Empty
        Dim _JournalDetails As Collection

#End Region

#Region "Public Properties"

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostGlJournal() As String
            Get
                Return _PostGlJournal
            End Get
            Set(ByVal Value As String)
                _PostGlJournal = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Parameters() As String
            Get
                Return _Parameters
            End Get
            Set(ByVal Value As String)
                _Parameters = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether or not a transaction must be rejected if there are any warnings such as 'Ledger code on hold'. (N - No, Y - Yes, W - give a warning message but don't reject the transaction) Default is 'N'
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As GLJournal_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As GLJournal_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether the entire document must be validated prior to any posting taking place. If set to 'N', each item is validated and rejected if in error or posted if correct. This is the fastest option. If set to 'Y', all items in the document are first validated.If the entire document is valid then items are posted.Default is 'Y'. Valid values are 'Y' and 'N'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ApplyIfEntireDocumentValid() As GLJournal_ApplyIfEntireDocumentValid_Enum
            Get
                Return _ApplyIfEntireDocumentValid
            End Get
            Set(ByVal Value As GLJournal_ApplyIfEntireDocumentValid_Enum)
                _ApplyIfEntireDocumentValid = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No posting will take place. If set to 'N', each item is validated and posting is performed based on the value of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ValidateOnly() As GLJournal_ValidateOnly_Enum
            Get
                Return _ValidateOnly
            End Get
            Set(ByVal Value As GLJournal_ValidateOnly_Enum)
                _ValidateOnly = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element indicates whether you are adding new journals or maintaining existing journals. The valid values that can be passed are 'A'-Add or 'M' -Maintain. If no value is passed then a default value of 'A' will be used
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property ActionType() As GLJournal_ActionType_Enum
            Get
                Return _ActionType
            End Get
            Set(ByVal Value As GLJournal_ActionType_Enum)
                _ActionType = Value
            End Set
        End Property


        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Item() As String
            Get
                Return _Item
            End Get
            Set(ByVal Value As String)
                _Item = Value
            End Set
        End Property

        ''' <summary> 
        '''  The JournalType is used to indicate what type of journal you want to capture. (N-Normal journal, P-Provisional journal, U-User defined journal, S-Statistical journal and L-Alternate currency journal). If no value is supplied then a default value of "N" will be used. When maintaining a journal you may not change the journal type.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property JournalType() As GLJournal_JournalType_Enum
            Get
                Return _JournalType
            End Get
            Set(ByVal Value As GLJournal_JournalType_Enum)
                _JournalType = Value
            End Set
        End Property

        ''' <summary> 
        '''  The JournalNumber is used to indicated what journal number you will be maintaining. If a JournalNumber value is supplied then that journal number must already exist. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property JournalNumber() As String
            Get
                Return _JournalNumber
            End Get
            Set(ByVal Value As String)
                _JournalNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  The AuthorizeJournal option is used to flag a journal as being authorized. This flag is only necessary if the 'Authorization of journals before posting is required' flag is ticked under the G/l setup. The flag can be set as follows D-Do not change authorization status, A-Authorize journal, U-Unauthorize journal. If no value is supplied then a default value of 'D' will be used. The operator must have authorization access before they can authorize a journal.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AuthorizeJournal() As GLJournal_AuthorizeJournal_Enum
            Get
                Return _AuthorizeJournal
            End Get
            Set(ByVal Value As GLJournal_AuthorizeJournal_Enum)
                _AuthorizeJournal = Value
            End Set
        End Property

        ''' <summary> 
        '''  The PostJournal is used to indicate whether or not a journal should be posted. Valid values that can be supplied are - Y-Yes, N-No. If no value is supplied then a default value of 'Y' will be used. An operator must have post access before they will be allowed to post a journal.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostJournal() As GLJournal_PostJournal_Enum
            Get
                Return _PostJournal
            End Get
            Set(ByVal Value As GLJournal_PostJournal_Enum)
                _PostJournal = Value
            End Set
        End Property

        ''' <summary> 
        '''  The CancelJournal is used to cancel a journal that has already been created. The valid values that can be supplied is N-No and Y-Yes. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property CancelJournal() As GLJournal_CancelJournal_Enum
            Get
                Return _CancelJournal
            End Get
            Set(ByVal Value As GLJournal_CancelJournal_Enum)
                _CancelJournal = Value
            End Set
        End Property

        ''' <summary> 
        '''  The HoldlJournal is used to place a journal on hold or take a journal off hold. The valid values that can be supplied is N-No and Y-Yes. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property HoldJournal() As GLJournal_HoldJournal_Enum
            Get
                Return _HoldJournal
            End Get
            Set(ByVal Value As GLJournal_HoldJournal_Enum)
                _HoldJournal = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the date that will be posted against the journal when it is created. If no date is supplied then the system date will be used by default. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property JournalDate() As String
            Get
                Return _JournalDate
            End Get
            Set(ByVal Value As String)
                _JournalDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  The JournalReference is the reference text that will be captured against the journal. If no value is supplied then the journal created will have no reference.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property JournalReference() As String
            Get
                Return _JournalReference
            End Get
            Set(ByVal Value As String)
                _JournalReference = Value
            End Set
        End Property

        ''' <summary> 
        '''  The Notation is the notation text that will be captured against the journal. If no value is supplied then the journal created will have no notation.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Notation() As String
            Get
                Return _Notation
            End Get
            Set(ByVal Value As String)
                _Notation = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the posting period for the journal created. If no period is supplied then the program will default to the current G/L financial period. The period that you are posting to must be open. You will not be able to post journals that are in a future period.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostingPeriod() As String
            Get
                Return _PostingPeriod
            End Get
            Set(ByVal Value As String)
                _PostingPeriod = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the posting year for the journal created. If no year is supplied then the program will default to the current G/L financial year. You can only create a journal in the current or previous financial year.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostingYear() As String
            Get
                Return _PostingYear
            End Get
            Set(ByVal Value As String)
                _PostingYear = Value
            End Set
        End Property

        ''' <summary> 
        '''  This will be the source code for a user defined journal. The source code must exist on TblGlUserJnl and may not be the same code as any of the sub-module ledger sources.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property SourceCode() As String
            Get
                Return _SourceCode
            End Get
            Set(ByVal Value As String)
                _SourceCode = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the currency code for alternate currency journals. The currency code must exit in TblCurrency and must be defined as an alternate reporting currency.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property

        ''' <summary> 
        ''' The collection of JournalLines
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property JournalDetails() As Collection
            Get
                If _JournalDetails Is Nothing Then
                    _JournalDetails = New Collection
                End If
                Return _JournalDetails
            End Get
            Set(ByVal Value As Collection)
                _JournalDetails = Value
            End Set
        End Property


#End Region

#Region "Enumerations"

        Public Enum GLJournal_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_W
        End Enum
        Public Enum GLJournal_ApplyIfEntireDocumentValid_Enum
            ApplyIfEntireDocumentValid_Upper_Y
            ApplyIfEntireDocumentValid_Upper_N
        End Enum
        Public Enum GLJournal_ValidateOnly_Enum
            ValidateOnly_Upper_N
            ValidateOnly_Upper_Y
        End Enum
        Public Enum GLJournal_ActionType_Enum
            ActionType_Upper_A
            ActionType_Upper_M
        End Enum

        Public Enum GLJournal_JournalType_Enum
            JournalType_Upper_N
            JournalType_Upper_P
            JournalType_Upper_U
            JournalType_Upper_S
            JournalType_Upper_L
        End Enum
        Public Enum GLJournal_AuthorizeJournal_Enum
            AuthorizeJournal_Upper_D
            AuthorizeJournal_Upper_A
            AuthorizeJournal_Upper_U
        End Enum
        Public Enum GLJournal_PostJournal_Enum
            PostJournal_Upper_Y
            PostJournal_Upper_N
        End Enum
        Public Enum GLJournal_CancelJournal_Enum
            CancelJournal_Upper_N
            CancelJournal_Upper_Y
        End Enum
        Public Enum GLJournal_HoldJournal_Enum
            HoldJournal_Upper_N
            HoldJournal_Upper_Y
        End Enum

#End Region

#Region "XML String Constructor"

        Private Function ConstructXMLParam() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostGlJournal As System.Xml.XmlElement = xmlDoc.CreateElement("PostGlJournal")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")
            Dim ApplyIfEntireDocumentValid As System.Xml.XmlElement = xmlDoc.CreateElement("ApplyIfEntireDocumentValid")
            Dim ValidateOnly As System.Xml.XmlElement = xmlDoc.CreateElement("ValidateOnly")
            Dim ActionType As System.Xml.XmlElement = xmlDoc.CreateElement("ActionType")

            xmlDoc.AppendChild(PostGlJournal)
            Common.SysproUtilities.AppendXMLElement(PostGlJournal, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ApplyIfEntireDocumentValid, Common.SysproUtilities.GetEnumValue(_ApplyIfEntireDocumentValid.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ValidateOnly, Common.SysproUtilities.GetEnumValue(_ValidateOnly.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, ActionType, Common.SysproUtilities.GetEnumValue(_ActionType.ToString))

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostGlJournal As System.Xml.XmlElement = xmlDoc.CreateElement("PostGlJournal")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim JournalType As System.Xml.XmlElement = xmlDoc.CreateElement("JournalType")
            Dim JournalNumber As System.Xml.XmlElement = xmlDoc.CreateElement("JournalNumber")
            Dim AuthorizeJournal As System.Xml.XmlElement = xmlDoc.CreateElement("AuthorizeJournal")
            Dim PostJournal As System.Xml.XmlElement = xmlDoc.CreateElement("PostJournal")
            Dim CancelJournal As System.Xml.XmlElement = xmlDoc.CreateElement("CancelJournal")
            Dim HoldJournal As System.Xml.XmlElement = xmlDoc.CreateElement("HoldJournal")
            Dim JournalDate As System.Xml.XmlElement = xmlDoc.CreateElement("JournalDate")
            Dim JournalReference As System.Xml.XmlElement = xmlDoc.CreateElement("JournalReference")
            Dim Notation As System.Xml.XmlElement = xmlDoc.CreateElement("Notation")
            Dim PostingPeriod As System.Xml.XmlElement = xmlDoc.CreateElement("PostingPeriod")
            Dim PostingYear As System.Xml.XmlElement = xmlDoc.CreateElement("PostingYear")
            Dim SourceCode As System.Xml.XmlElement = xmlDoc.CreateElement("SourceCode")
            Dim Currency As System.Xml.XmlElement = xmlDoc.CreateElement("Currency")

            xmlDoc.AppendChild(PostGlJournal)
            Common.SysproUtilities.AppendXMLElement(PostGlJournal, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, JournalType, Common.SysproUtilities.GetEnumValue(_JournalType.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, JournalNumber, _JournalNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, AuthorizeJournal, Common.SysproUtilities.GetEnumValue(_AuthorizeJournal.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, PostJournal, Common.SysproUtilities.GetEnumValue(_PostJournal.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, CancelJournal, Common.SysproUtilities.GetEnumValue(_CancelJournal.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, HoldJournal, Common.SysproUtilities.GetEnumValue(_HoldJournal.ToString))
            Common.SysproUtilities.AppendXMLElement(Item, JournalDate, _JournalDate.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, JournalReference, _JournalReference.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Notation, _Notation.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PostingPeriod, _PostingPeriod.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, PostingYear, _PostingYear.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, SourceCode, _SourceCode.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, Currency, _Currency.ToString)
            For Each jnlDet As GLJournalLine In JournalDetails
                Item.AppendChild(jnlDet.XmlElement(xmlDoc))
            Next

            Return xmlDoc.OuterXml

        End Function


#End Region

#Region " Interface "

        Private _ActionTypeTrn As CommonEnums.ActionType_Transaction
        Public Property ActionTypeTrn() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionTypeTrn
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionTypeTrn = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return "GENTJL"
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            If ActionTypeTrn = CommonEnums.ActionType_Transaction.Build Then
                _xmlOut = Transaction.Build(Me)
            ElseIf ActionTypeTrn = CommonEnums.ActionType_Transaction.Post Then
                _xmlOut = Transaction.Post(Me)
            End If

        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Return ConstructXMLParam()
            End Get
        End Property

#End Region

    End Class

End Namespace
