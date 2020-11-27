Namespace QueryObjects.DispatchNoteQuery

    Public Enum DispatchNoteLineTypeEnum
        Merchandise
        Freight
        MiscCharge
        Comment
    End Enum

    Public Interface IDispatchNoteLine

        Property DocumentNumber() As String
        Property LineNumber() As String
        ReadOnly Property LineType() As DispatchNoteLineTypeEnum

    End Interface

End Namespace
