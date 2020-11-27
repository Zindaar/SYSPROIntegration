Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output

    Public Enum DispatchInvoiceLineTypeEnum
        Merchandise
        Freight
        MiscCharge
        Comment
    End Enum

    Public Interface IDispatchInvoiceLine

        Property DocumentNumber() As String
        Property LineNumber() As String
        ReadOnly Property LineType() As DispatchInvoiceLineTypeEnum

    End Interface

End Namespace
