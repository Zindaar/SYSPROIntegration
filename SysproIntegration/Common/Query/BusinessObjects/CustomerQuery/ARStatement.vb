Namespace QueryObjects.CustomerQuery
    <Serializable()> Public Class ARStatement

#Region " Properties "
        Private _mySystemInformation As SystemInformation
        Private _myHeader As Header
        Private _myInvoiceDetails As InvoiceDetailCollection
        Private _myPayDetails As PayDetailCollection
        Private _myPostDateds As PostDatedCollection
        Private _myTotalSection As TotalSection

        Public Property mySystemInformation() As SystemInformation
            Get
                Return _mySystemInformation
            End Get
            Set(ByVal Value As SystemInformation)
                _mySystemInformation = Value
            End Set
        End Property
        Public Property myHeader() As Header
            Get
                Return _myHeader
            End Get
            Set(ByVal Value As Header)
                _myHeader = Value
            End Set
        End Property
        Public Property myInvoiceDetails() As InvoiceDetailCollection
            Get
                Return _myInvoiceDetails
            End Get
            Set(ByVal Value As InvoiceDetailCollection)
                _myInvoiceDetails = Value
            End Set
        End Property
        Public ReadOnly Property mySortedInvoiceDetails() As InvoiceDetailCollection
            Get
                'then sorting the list and pass the sorted list out for use.
                Dim sortedList As System.Collections.Generic.List(Of InvoiceDetail)
                sortedList = myInvoiceDetails
                Dim dc As New DateComparer
                sortedList.Sort(0, myInvoiceDetails.Count, dc)
                Return sortedList
            End Get

        End Property
        Public Property myPayDetails() As PayDetailCollection
            Get
                Return _myPayDetails
            End Get
            Set(ByVal Value As PayDetailCollection)
                _myPayDetails = Value
            End Set
        End Property
        Public Property myPostDateds() As PostDatedCollection
            Get
                Return _myPostDateds
            End Get
            Set(ByVal Value As PostDatedCollection)
                _myPostDateds = Value
            End Set
        End Property
        Public Property myTotalSection() As TotalSection
            Get
                Return _myTotalSection
            End Get
            Set(ByVal Value As TotalSection)
                _myTotalSection = Value
            End Set
        End Property
#End Region

#Region " Instantiation "

        Public Shared Function FromSYSPROARSQuery(ByVal strCustomer As String, _
         Optional ByVal MultiMediaImageType As String = "GIF", _
         Optional ByVal IncludeFutures As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeFutures_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeFutures_Enum.IncludeFutures_Upper_N, _
         Optional ByVal IncludeTransactions As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeTransactions_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeTransactions_Enum.IncludeTransactions_Upper_Y, _
         Optional ByVal IncludeCheckPayments As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeCheckPayments_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeCheckPayments_Enum.IncludeCheckPayments_Upper_Y, _
         Optional ByVal IncludePostDated As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludePostDated_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludePostDated_Enum.IncludePostDated_Upper_Y, _
         Optional ByVal IncludeZeroBalances As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeZeroBalances_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeZeroBalances_Enum.IncludeZeroBalances_Upper_N, _
         Optional ByVal IncludeCustomForms As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeCustomForms_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_IncludeCustomForms_Enum.IncludeCustomForms_Upper_N, _
         Optional ByVal AsOfPeriod As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_AsOfPeriod_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_AsOfPeriod_Enum.AsOfPeriod_Upper_C, _
         Optional ByVal AgeingOption As QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_AgeingOption_Enum = QueryObjects.CustomerQuery.CustomerQuery.CustomerQuery_AgeingOption_Enum.AgeingOption_Upper_S, _
         Optional ByVal AgeColumn1 As Integer = 30, _
         Optional ByVal AgeColumn2 As Integer = 60, _
         Optional ByVal AgeColumn3 As Integer = 90, _
         Optional ByVal AgeColumn4 As Integer = 120, _
         Optional ByVal AgeColumn5 As Integer = 150, _
         Optional ByVal AgeColumn6 As Integer = 180, _
         Optional ByVal AgeColumn7 As Integer = 210, _
         Optional ByVal XslStylesheet As String = "") As ARStatement

            Dim qry As New QueryObjects.CustomerQuery.CustomerQuery
            With qry
                .ActionType = CommonEnums.ActionType_Query.Query
                .Customer = strCustomer
                .MultiMediaImageType = MultiMediaImageType
                .IncludeFutures = IncludeFutures
                .IncludeTransactions = IncludeTransactions
                .IncludeCheckPayments = IncludeCheckPayments
                .IncludePostDated = IncludePostDated
                .IncludeZeroBalances = IncludeZeroBalances
                .IncludeCustomForms = IncludeCustomForms
                .AsOfPeriod = AsOfPeriod
                .AgeingOption = AgeingOption
                .AgeColumn1 = AgeColumn1
                .AgeColumn2 = AgeColumn2
                .AgeColumn3 = AgeColumn3
                .AgeColumn4 = AgeColumn4
                .AgeColumn5 = AgeColumn5
                .AgeColumn6 = AgeColumn6
                .AgeColumn7 = AgeColumn7
                .XslStylesheet = XslStylesheet
                .Post()
            End With

            Dim ds As New DataSet
            Dim myStreamReader As IO.StringReader = Nothing
            Try
                'replace the ":" with "_"
                Dim strNoColonXmlOut As String = qry.xmlOut
                strNoColonXmlOut = strNoColonXmlOut.Replace(":", "_")
                myStreamReader = New IO.StringReader(strNoColonXmlOut)

                ds.ReadXml(New System.Xml.XmlTextReader(myStreamReader))
                'ds.ReadXml("C:\Documents and Settings\Shawn.PROACTIVE.000\Desktop\qrQuery.xml") ''This is for testing only: 

            Finally
                myStreamReader.Dispose()
            End Try

            Return New ARStatement(ds)

        End Function

#End Region

#Region " Constructor "

        Private Sub New(ByVal ds As DataSet)
            _mySystemInformation = New SystemInformation(ds)
            _myHeader = New Header(ds)
            _myInvoiceDetails = New InvoiceDetailCollection(ds)
            _myPayDetails = New PayDetailCollection(ds)
            _myPostDateds = New PostDatedCollection(ds)
            _myTotalSection = New TotalSection(ds)
        End Sub

#End Region

    End Class
End Namespace
