Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class InvoiceDetail

#Region " Properties "
        Private _DocumentType As String
        Private _Invoice As String
        Private _InvoiceDate As String
        Private _DueDate As String
        Private _CustomerPoNumber As String
        Private _CurrencyValue As Decimal
        Private _TBLART_Description As String
        Private _InvoiceBal As String
        Private _Branch As String
        Private _SalesOrder As String
        Private _LastDelNote As String
        Private _ProofOfDelivery As String
        Private _PodReference As String
        Private _PodEntryDate As String
        Private _BaseCurrencyValue As String
        Private _ConvRate As String
        Private _MulDiv As String
        Private _ForeignToLocalConversion As String
        Private _myTransDetailCollection As TransDetailCollection

        Public Property DocumentType() As String
            Get
                Return _DocumentType
            End Get
            Set(ByVal Value As String)
                _DocumentType = Value
            End Set
        End Property
        Public Property Invoice() As String
            Get
                Return _Invoice
            End Get
            Set(ByVal Value As String)
                _Invoice = Value
            End Set
        End Property
        Public Property InvoiceDate() As Date
            Get
                Return _InvoiceDate
            End Get
            Set(ByVal Value As Date)
                _InvoiceDate = Value
            End Set
        End Property
        Public Property DueDate() As String
            Get
                Return _DueDate
            End Get
            Set(ByVal Value As String)
                _DueDate = Value
            End Set
        End Property
        Public Property CustomerPoNumber() As String
            Get
                Return _CustomerPoNumber
            End Get
            Set(ByVal Value As String)
                _CustomerPoNumber = Value
            End Set
        End Property
        Public Property CurrencyValue() As Decimal
            Get
                Return _CurrencyValue
            End Get
            Set(ByVal Value As Decimal)
                _CurrencyValue = Value
            End Set
        End Property
        Public Property TBLART_Description() As String
            Get
                Return _TBLART_Description
            End Get
            Set(ByVal Value As String)
                _TBLART_Description = Value
            End Set
        End Property
        Public Property InvoiceBal() As Decimal
            Get
                Return _InvoiceBal
            End Get
            Set(ByVal Value As Decimal)
                _InvoiceBal = Value
            End Set
        End Property
        Public Property Branch() As String
            Get
                Return _Branch
            End Get
            Set(ByVal Value As String)
                _Branch = Value
            End Set
        End Property
        Public Property SalesOrder() As String
            Get
                Return _SalesOrder
            End Get
            Set(ByVal Value As String)
                _SalesOrder = Value
            End Set
        End Property
        Public Property LastDelNote() As String
            Get
                Return _LastDelNote
            End Get
            Set(ByVal Value As String)
                _LastDelNote = Value
            End Set
        End Property
        Public Property ProofOfDelivery() As String
            Get
                Return _ProofOfDelivery
            End Get
            Set(ByVal Value As String)
                _ProofOfDelivery = Value
            End Set
        End Property
        Public Property PodReference() As String
            Get
                Return _PodReference
            End Get
            Set(ByVal Value As String)
                _PodReference = Value
            End Set
        End Property
        Public Property PodEntryDate() As String
            Get
                Return _PodEntryDate
            End Get
            Set(ByVal Value As String)
                _PodEntryDate = Value
            End Set
        End Property
        Public Property BaseCurrencyValue() As String
            Get
                Return _BaseCurrencyValue
            End Get
            Set(ByVal Value As String)
                _BaseCurrencyValue = Value
            End Set
        End Property
        Public Property ConvRate() As String
            Get
                Return _ConvRate
            End Get
            Set(ByVal Value As String)
                _ConvRate = Value
            End Set
        End Property
        Public Property MulDiv() As String
            Get
                Return _MulDiv
            End Get
            Set(ByVal Value As String)
                _MulDiv = Value
            End Set
        End Property
        Public Property ForeignToLocalConversion() As String
            Get
                Return _ForeignToLocalConversion
            End Get
            Set(ByVal Value As String)
                _ForeignToLocalConversion = Value
            End Set
        End Property
        Public Property myTransDetailCollection() As TransDetailCollection
            Get
                Return _myTransDetailCollection
            End Get
            Set(ByVal Value As TransDetailCollection)
                _myTransDetailCollection = Value
            End Set
        End Property

#End Region

        Friend Sub New(ByVal r As DataRow, ByVal ds As DataSet)

            _DocumentType = Convert.ToString(r("DocumentType"))
            _Invoice = Convert.ToString(r("Invoice"))
            _InvoiceDate = Convert.ToDateTime(r("InvoiceDate"))
            _DueDate = Convert.ToString(r("DueDate"))
            _CustomerPoNumber = Convert.ToString(r("CustomerPoNumber"))
            _CurrencyValue = Convert.ToDecimal(r("CurrencyValue"))
            _TBLART_Description = Convert.ToString(r("TBLART_Description"))
            _InvoiceBal = Convert.ToDecimal(r("InvoiceBal"))
            _Branch = Convert.ToString(r("Branch"))
            _SalesOrder = Convert.ToString(r("SalesOrder"))
            _LastDelNote = Convert.ToString(r("LastDelNote"))
            _ProofOfDelivery = Convert.ToString(r("ProofOfDelivery"))
            _PodReference = Convert.ToString(r("PodReference"))
            _PodEntryDate = Convert.ToString(r("PodEntryDate"))
            Try
                _BaseCurrencyValue = Convert.ToString(r("BaseCurrencyValue"))
                _ConvRate = Convert.ToString(r("ConvRate"))
                _MulDiv = Convert.ToString(r("MulDiv"))
                _ForeignToLocalConversion = Convert.ToString(r("ForeignToLocalConversion"))
            Catch ex As Exception
                'The invoice is in local currency
                _BaseCurrencyValue = _CurrencyValue
                _ConvRate = 1
                _MulDiv = "M"
                _ForeignToLocalConversion = ""
            End Try

            Try
                _myTransDetailCollection = New TransDetailCollection(ds, r("InvoiceDetail_id"))
            Catch ex As Exception
                _myTransDetailCollection = New TransDetailCollection(Nothing, 0)
            End Try

        End Sub

    End Class

    <Serializable()> Public Class InvoiceDetailCollection
        Inherits System.Collections.Generic.List(Of InvoiceDetail)

        Friend Sub New(ByVal ds As DataSet)
            Try
                Dim linesTable As DataTable = ds.Tables("InvoiceDetail")
                If linesTable Is Nothing Then Exit Sub
                For Each row As DataRow In linesTable.Rows
                    Me.Add(New InvoiceDetail(row, ds))
                Next
            Catch ex As IndexOutOfRangeException
                'There is no PostDated table in the dataset, but don't worry about it
            End Try
        End Sub
    End Class

End Namespace