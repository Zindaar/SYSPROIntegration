Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class SalesTaxDetailsSection

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _SalesTaxCode As String = "" '>A</SalesTaxCode> 
        Private _AmountTaxable As String = "" '>1450.00</AmountTaxable> 
        Private _SalesTaxPercentage As String = "" '>10.00</SalesTaxPercentage> 
        Private _SalesTaxAmount As String = "" '>145.00</SalesTaxAmount> 

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
        Public Property SalesTaxCode() As String
            Get
                Return _SalesTaxCode
            End Get
            Set(ByVal Value As String)
                _SalesTaxCode = Value
            End Set
        End Property
        Public Property AmountTaxable() As String
            Get
                Return _AmountTaxable
            End Get
            Set(ByVal Value As String)
                _AmountTaxable = Value
            End Set
        End Property
        Public Property SalesTaxPercentage() As String
            Get
                Return _SalesTaxPercentage
            End Get
            Set(ByVal Value As String)
                _SalesTaxPercentage = Value
            End Set
        End Property
        Public Property SalesTaxAmount() As String
            Get
                Return _SalesTaxAmount
            End Get
            Set(ByVal Value As String)
                _SalesTaxAmount = Value
            End Set
        End Property

#End Region

        Public Shared Function NewFromDS(ByVal ds As DataSet) As SalesTaxDetailsSection

            Dim std As New SalesTaxDetailsSection

            Dim rootTable As DataTable = ds.Tables("SalesTaxDetails")
            If Not rootTable Is Nothing Then

                Dim rootRow As DataRow = rootTable.Rows(0)

                With std
                    .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                    .SalesTaxCode = rootRow.Item("SalesTaxCode").ToString
                    .AmountTaxable = rootRow.Item("AmountTaxable").ToString
                    .SalesTaxPercentage = rootRow.Item("SalesTaxPercentage").ToString
                    .SalesTaxAmount = rootRow.Item("SalesTaxAmount").ToString
                End With
            Else
                With std
                    .DocumentNumber = ""
                    .SalesTaxCode = ""
                    .AmountTaxable = 0
                    .SalesTaxPercentage = 0
                    .SalesTaxAmount = 0
                End With
            End If

            Return std
        End Function
    End Class
End Namespace
