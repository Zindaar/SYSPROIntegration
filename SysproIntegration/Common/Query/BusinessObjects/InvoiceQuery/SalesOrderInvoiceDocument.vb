Namespace QueryObjects.InvoiceQuery

    <Serializable()> Public Class SalesOrderInvoiceDocument

#Region " Private Variables "

        Private _DocumentNumber As String
        Private _DocumentType As String
        Private _Reprint As String

        Private _myDocumentHeader As DocumentHeader
        Private _myTotalsSection As TotalsSection
        Private _myInvoiceLineCollection As InvoiceLineCollection
#End Region

#Region " Public Properties "

        Public Property DocumentNumber() As String
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property DocumentType() As String
            Get
                Return _DocumentType
            End Get
            Set(ByVal Value As String)
                _DocumentType = Value
            End Set
        End Property
        Public Property Reprint() As String
            Get
                Return _Reprint
            End Get
            Set(ByVal Value As String)
                _Reprint = Value
            End Set
        End Property

        Public Property myDocumentHeader() As DocumentHeader
            Get
                Return _myDocumentHeader
            End Get
            Set(ByVal Value As DocumentHeader)
                _myDocumentHeader = Value
            End Set
        End Property
        Public Property myTotalsSection() As TotalsSection
            Get
                Return _myTotalsSection
            End Get
            Set(ByVal Value As TotalsSection)
                _myTotalsSection = Value
            End Set
        End Property
        Public Property myInvoiceLineCollection() As InvoiceLineCollection
            Get
                Return _myInvoiceLineCollection
            End Get
            Set(ByVal Value As InvoiceLineCollection)
                _myInvoiceLineCollection = Value
            End Set
        End Property

#End Region

#Region " Instantiation "

        Public Shared Function NewFromSYSPROInvoiceQuery(ByVal strInvoiceNumber As String, ByVal blnReprint As Boolean, ByVal strDocumentType As String) As SalesOrderInvoiceDocument

            Dim qry As New QueryObjects.InvoiceQuery.InvoiceQuery
            qry.ActionType = CommonEnums.ActionType_Query.Query
            qry.InvoiceNumber_FilterType = QueryObjects.InvoiceQuery.InvoiceQuery.InvoiceQuery_InvoiceNumber_FilterType_Enum.InvoiceNumber_FilterType_Upper_L
            qry.Reprint = QueryObjects.InvoiceQuery.InvoiceQuery.InvoiceQuery_Reprint_Enum.Reprint_Upper_N 'IIf(blnReprint, QueryObjects.InvoiceQuery.InvoiceQuery_Reprint_Enum.Reprint_Upper_Y, QueryObjects.InvoiceQuery.InvoiceQuery_Reprint_Enum.Reprint_Upper_N)
            If strDocumentType = "I" Then
                qry.DocumentType = QueryObjects.InvoiceQuery.InvoiceQuery.InvoiceQuery_DocumentType_Enum.DocumentType_Upper_I
            Else
                qry.DocumentType = QueryObjects.InvoiceQuery.InvoiceQuery.InvoiceQuery_DocumentType_Enum.DocumentType_Upper_C
            End If
            qry.InvoiceNumber_FilterValue = strInvoiceNumber
            qry.Post()

            Dim ds As New DataSet
            Dim myStreamReader As IO.StringReader = Nothing
            Try
                'fs = New IO.FileStream("D:\My Documents\My Programming Support\SYSPRO E.Net Reference\SORQID\SORQIDOUT.XML", IO.FileMode.Open)

                myStreamReader = New IO.StringReader(qry.xmlOut)
                'myStreamReader = New IO.StringReader(fs.ToString)
                ds.ReadXml(New System.Xml.XmlTextReader(myStreamReader))
                ' Test: ds.ReadXml(New System.Xml.XmlTextReader("D:\My Documents\My Programming Support\SYSPRO E.Net Reference\SORQID\SORQIDOUT.XML"))

            Finally
                'fs.Dispose()
                myStreamReader.Dispose()
            End Try

            Return New SalesOrderInvoiceDocument(ds)

        End Function

        Public Sub New(ByVal ds As DataSet)
            ObjectTreeFromDataset(ds)
        End Sub

        ''' <summary>
        ''' Instantiates and returns a new instance of ATPResultStockItem with properties populated from the given XML String
        ''' </summary>
        Private Sub ObjectTreeFromDataset(ByVal ds As DataSet)
            Dim rootTable As DataTable = ds.Tables("SalesOrderInvoiceDocument")
            Dim rootRow As DataRow = Nothing
            Try
                rootRow = rootTable.Rows(0)
            Catch ex As NullReferenceException
                Throw New ApplicationException("No data returned from SYSPRO for this document", ex)
            End Try

            _DocumentNumber = rootRow.Item("DocumentNumber").ToString
            _DocumentType = rootRow.Item("DocumentType").ToString
            _Reprint = rootRow.Item("Reprint").ToString

            _myDocumentHeader = DocumentHeader.NewFromDS(ds)
            _myInvoiceLineCollection = InvoiceLineCollection.NewFromDS(ds)
            _myTotalsSection = TotalsSection.NewFromDS(ds)

        End Sub
#End Region


    End Class
End Namespace
