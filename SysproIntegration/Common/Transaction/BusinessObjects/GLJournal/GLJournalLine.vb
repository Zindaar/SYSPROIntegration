Namespace TransactionObjects
    <Serializable()> Public Class GLJournalLine

#Region " Private Variables "

        Dim _EntryNumber As String = String.Empty
        Dim _LedgerCode As String = String.Empty
        Dim _LedgerCodePassword As String = String.Empty
        Dim _xDate As String = String.Empty
        Dim _Reference As String = String.Empty
        Dim _EntryAmount As String = String.Empty
        Dim _DeleteEntry As GLJournal_DeleteEntry_Enum = GLJournal_DeleteEntry_Enum.DeleteEntry_Upper_N
        Dim _Comment As String = String.Empty

#End Region

#Region " Properties "
        ''' <summary> 
        '''  This is the line number of the G/L entry you wish to maintain. This line number must already exit.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property EntryNumber() As String
            Get
                Return _EntryNumber
            End Get
            Set(ByVal Value As String)
                _EntryNumber = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the ledger code for the G/L entry. This ledger code must exist on GenMaster. The ledger code may not be on hold. A warning message is generated if this is a control account.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property LedgerCode() As String
            Get
                Return _LedgerCode
            End Get
            Set(ByVal Value As String)
                _LedgerCode = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the password for the LedgerCode supplied. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property LedgerCodePassword() As String
            Get
                Return _LedgerCodePassword
            End Get
            Set(ByVal Value As String)
                _LedgerCodePassword = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the journal date for the specified line item. If no value is supplied the system date will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xDate() As String
            Get
                Return _xDate
            End Get
            Set(ByVal Value As String)
                _xDate = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the reference for this G/L line entry. If no value is supplied then the reference will be blank.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Reference() As String
            Get
                Return _Reference
            End Get
            Set(ByVal Value As String)
                _Reference = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the amount for this G/L entry. If a negative value is supplied then it will be a credit. If a positive value is supplied then it will be a debit entry.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property EntryAmount() As String
            Get
                Return _EntryAmount
            End Get
            Set(ByVal Value As String)
                _EntryAmount = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is a flag to indicate whether the G/L entry line should be deleted. You can only use this flag if the G/L entry line already exists and you are maintaining a journal. Valid entry values are N-No and Y-Yes. If no value is supplied then the entry will not be deleted.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DeleteEntry() As GLJournal_DeleteEntry_Enum
            Get
                Return _DeleteEntry
            End Get
            Set(ByVal Value As GLJournal_DeleteEntry_Enum)
                _DeleteEntry = Value
            End Set
        End Property

        ''' <summary>
        ''' This is the comment for this G/L line entry. If no value is supplied then the comment will be blank.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Comment() As String
            Get
                Return _Comment
            End Get
            Set(ByVal value As String)
                _Comment = value
            End Set
        End Property

#End Region

#Region " Enums "

        Public Enum GLJournal_DeleteEntry_Enum
            DeleteEntry_Upper_N
            DeleteEntry_Upper_Y
        End Enum

#End Region

        Public Function XmlElement(ByVal xmlDoc As Xml.XmlDocument) As Xml.XmlElement

            Dim EntryNumber As System.Xml.XmlElement = xmlDoc.CreateElement("EntryNumber")
            Dim LedgerCode As System.Xml.XmlElement = xmlDoc.CreateElement("LedgerCode")
            Dim LedgerCodePassword As System.Xml.XmlElement = xmlDoc.CreateElement("LedgerCodePassword")
            Dim xDate As System.Xml.XmlElement = xmlDoc.CreateElement("Date")
            Dim Reference As System.Xml.XmlElement = xmlDoc.CreateElement("Reference")
            Dim EntryAmount As System.Xml.XmlElement = xmlDoc.CreateElement("EntryAmount")
            Dim DeleteEntry As System.Xml.XmlElement = xmlDoc.CreateElement("DeleteEntry")
            Dim Comment As System.Xml.XmlElement = xmlDoc.CreateElement("Comment")

            Dim JournalDetailsElement As System.Xml.XmlElement = xmlDoc.CreateElement("JournalDetails")
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, EntryNumber, Me.EntryNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, LedgerCode, Me.LedgerCode.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, LedgerCodePassword, Me.LedgerCodePassword.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, xDate, Me.xDate.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, Reference, Me.Reference.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, EntryAmount, Me.EntryAmount.ToString)
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, DeleteEntry, Common.SysproUtilities.GetEnumValue(Me.DeleteEntry.ToString))
            Common.SysproUtilities.AppendXMLElement(JournalDetailsElement, Comment, Me.Comment.ToString)

            Return JournalDetailsElement

        End Function
    End Class
End Namespace
