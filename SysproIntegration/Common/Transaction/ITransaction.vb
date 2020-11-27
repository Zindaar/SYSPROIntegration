Public Interface ITransaction

    ReadOnly Property xmlData() As String
    ReadOnly Property xmlParam() As String
    ReadOnly Property xmlOut() As String
    ReadOnly Property BusinessObject() As String
    Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean)

End Interface
