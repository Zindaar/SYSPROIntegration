Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> Public Class DispatchInvoiceDocument

#Region " Private Variables "

        Private _documentNumber As String
        Private _myDocumentHeader As Header
        Private _documentType As String
        Private _reprint As String
        Private _myDispatchInvoiceLineCollection As DispatchInvoiceLineCollection
        Private _myTotalSection As DispatchInvoiceTotalSection

#End Region

#Region " Public Properties "

        Public Property DocumentNumber() As String
            Get
                Return _documentNumber
            End Get
            Set(ByVal Value As String)
                _documentNumber = Value
            End Set
        End Property

        Public Property DocumentType() As String
            Get
                Return _documentType
            End Get
            Set(ByVal Value As String)
                _documentType = Value
            End Set
        End Property

        Public Property Reprint() As String
            Get
                Return _reprint
            End Get
            Set(ByVal Value As String)
                _reprint = Value
            End Set
        End Property

        Public Property MyDocumentHeader() As Header
            Get
                Return _myDocumentHeader
            End Get
            Set(ByVal Value As Header)
                _myDocumentHeader = Value
            End Set
        End Property

        Public Property MyDispatchInvoiceLineCollection() As DispatchInvoiceLineCollection
            Get
                Return _myDispatchInvoiceLineCollection
            End Get
            Set(ByVal Value As DispatchInvoiceLineCollection)
                _myDispatchInvoiceLineCollection = Value
            End Set
        End Property

        Public Property MyTotalSection() As DispatchInvoiceTotalSection
            Get
                Return _myTotalSection
            End Get
            Set(ByVal value As DispatchInvoiceTotalSection)
                _myTotalSection = value
            End Set
        End Property

#End Region

#Region " Instantiation "

        Public Shared Function NewFromSYSPRODispatchInvoiceQuery(ByVal strdocumentNumber As String) As DispatchInvoiceDocument

            Dim qry As New DispatchInvoiceQuery.QueryData.Query
            qry.QueryActionType = CommonEnums.ActionType_Query.Query
            qry.Option.IgnorePrintStatus = QueryOptionIgnorePrintStatus.Y
            qry.Filter.InvoiceNumber.FilterType = QueryFilterInvoiceNumberFilterType.L
            qry.Filter.InvoiceNumber.FilterValue = strdocumentNumber
            qry.Post(True)

            Dim ds As New DataSet
            Dim myStreamReader As IO.StringReader = Nothing
            Try
                myStreamReader = New IO.StringReader(qry.XmlOut)
                ds.ReadXml(New System.Xml.XmlTextReader(myStreamReader))

            Finally
                'fs.Dispose()
                myStreamReader.Dispose()
            End Try

            Return New DispatchInvoiceDocument(ds)

        End Function

        Public Sub New(ByVal ds As DataSet)
            ObjectTreeFromDataset(ds)
        End Sub

        ''' <summary>
        ''' Instantiates and returns a new instance of ATPResultStockItem with properties populated from the given XML String
        ''' </summary>
        Private Sub ObjectTreeFromDataset(ByVal ds As DataSet)
            Dim rootTable As DataTable = ds.Tables("DispatchInvoiceDocument")
            Dim rootRow As DataRow = Nothing
            Try
                rootRow = rootTable.Rows(0)
            Catch ex As NullReferenceException
                Throw New ApplicationException("No data returned from SYSPRO for this document", ex)
            End Try

            _documentNumber = rootRow.Item("DocumentNumber").ToString
            _documentType = rootRow.Item("DocumentType").ToString
            _reprint = rootRow.Item("Reprint").ToString

            _myDocumentHeader = Header.NewFromDS(ds)
            _myDispatchInvoiceLineCollection = DispatchInvoiceLineCollection.NewFromDS(ds)
            _myTotalSection = DispatchInvoiceTotalSection.NewFromDS(ds)
        End Sub
#End Region

    End Class
End Namespace
