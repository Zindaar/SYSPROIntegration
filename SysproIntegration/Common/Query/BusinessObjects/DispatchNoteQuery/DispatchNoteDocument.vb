Namespace QueryObjects.DispatchNoteQuery
    <Serializable()> Public Class DispatchNoteDocument

#Region " Private Variables "

        Private _DocumentNumber As String

        Private _myDocumentHeader As Header
        Private _myDispatchNoteLineCollection As DispatchNoteLineCollection


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

        Public Property MyDocumentHeader() As Header
            Get
                Return _myDocumentHeader
            End Get
            Set(ByVal Value As Header)
                _myDocumentHeader = Value
            End Set
        End Property

        Public Property MyDispatchNoteLineCollection() As DispatchNoteLineCollection
            Get
                Return _myDispatchNoteLineCollection
            End Get
            Set(ByVal Value As DispatchNoteLineCollection)
                _myDispatchNoteLineCollection = Value
            End Set
        End Property

#End Region

#Region " Instantiation "

        Public Shared Function NewFromSYSPRODispatchNoteQuery(ByVal strDispatchNoteNumber As String) As DispatchNoteDocument

            Dim qry As New QueryObjects.DispatchNoteQuery.DispatchNoteQuery
            qry.ActionType = CommonEnums.ActionType_Query.Query
            qry.DispatchNote = strDispatchNoteNumber
            qry.Post()

            Dim ds As New DataSet
            Dim myStreamReader As IO.StringReader = Nothing
            Try
                myStreamReader = New IO.StringReader(qry.xmlOut)
                ds.ReadXml(New System.Xml.XmlTextReader(myStreamReader))

            Finally
                'fs.Dispose()
                myStreamReader.Dispose()
            End Try

            Return New DispatchNoteDocument(ds)

        End Function

        Public Sub New(ByVal ds As DataSet)
            ObjectTreeFromDataset(ds)
        End Sub

        ''' <summary>
        ''' Instantiates and returns a new instance of ATPResultStockItem with properties populated from the given XML String
        ''' </summary>
        Private Sub ObjectTreeFromDataset(ByVal ds As DataSet)
            Dim rootTable As DataTable = ds.Tables("DispatchNoteDetail")
            Dim rootRow As DataRow = Nothing
            Try
                rootRow = rootTable.Rows(0)
            Catch ex As NullReferenceException
                Throw New ApplicationException("No data returned from SYSPRO for this document", ex)
            End Try

            _DocumentNumber = rootRow.Item("DispatchNote").ToString

            _myDocumentHeader = Header.NewFromDS(ds)
            _myDispatchNoteLineCollection = DispatchNoteLineCollection.NewFromDS(ds)

        End Sub
#End Region

    End Class
End Namespace
