Public Interface IQuery

    ReadOnly Property BusinessObject() As String
    ReadOnly Property xmlOut() As String
    ReadOnly Property xmlData() As String
    Property QueryActionType() As CommonEnums.ActionType_Query
    Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean)

End Interface
