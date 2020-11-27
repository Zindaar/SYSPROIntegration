Namespace QueryObjects.InvoiceQuery

    Public Enum InvoiceLineTypeEnum
        Merchandise
        Freight
        MiscCharge
        Comment
    End Enum

    Public Interface IInvoiceLine

        Property DocumentNumber() As String
        Property LineNumber() As String
        ReadOnly Property LineType() As InvoiceLineTypeEnum

    End Interface
End Namespace
