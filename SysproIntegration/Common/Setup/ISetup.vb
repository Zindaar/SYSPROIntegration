Public Interface ISetup


    ReadOnly Property xmlData() As String
    ReadOnly Property xmlOut() As String
    ReadOnly Property xmlParam() As String
    ReadOnly Property BusinessObject() As String
    Property SetupActionType() As CommonEnums.ActionType_Setup
    Sub Post(ByVal blnThrowExceptionOnErrorInXMLOut As Boolean)

End Interface
