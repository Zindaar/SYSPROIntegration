Namespace Common
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' This class defines the various null-handling functions that can be called within the app.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    '''GAMALAP\Gamaroff	9/21/2006	Code Generated
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <Serializable()> Public Class NullHandler
        Public Shared Function ZeroIfEmptyString(ByVal ObjectToEvaluate As String) As Decimal
            If ObjectToEvaluate Is Nothing Then Return 0
            If ObjectToEvaluate.TrimEnd = "" Or ObjectToEvaluate = String.Empty Then
                Return 0
            Else
                Return CType(ObjectToEvaluate, Decimal)
            End If
        End Function
        Public Shared Function NullIfEmptyString(ByVal ObjectToEvaluate As String) As Object
            If ObjectToEvaluate Is Nothing Then Return DBNull.Value
            If ObjectToEvaluate.TrimEnd.Length = 0 Or ObjectToEvaluate = String.Empty Then
                Return DBNull.Value
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullStringIfEmptyString(ByVal ObjectToEvaluate As String) As Object
            If ObjectToEvaluate Is Nothing Then Return "NULL"
            If ObjectToEvaluate.TrimEnd.Length = 0 Or ObjectToEvaluate = String.Empty Then
                Return "NULL"
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function EmptyStringIfNull(ByVal ObjectToEvaluate As Object) As String
            If ObjectToEvaluate Is Nothing Then Return ""
            If CType(ObjectToEvaluate, String).Trim.Length = 0 Or CType(ObjectToEvaluate, String) = String.Empty Then
                Return ""
            Else
                Return CType(ObjectToEvaluate, String)
            End If
        End Function
        Public Shared Function NullIfNothing(ByVal ObjectToEvaluate As Object) As Object
            If ObjectToEvaluate Is Nothing Then
                Return DBNull.Value
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullStringIfNothing(ByVal ObjectToEvaluate As Object) As Object
            If ObjectToEvaluate Is Nothing Then
                Return "NULL"
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullIfZero(ByVal ObjectToEvaluate As Decimal) As Object
            If ObjectToEvaluate = 0 Then
                Return DBNull.Value
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullStringIfZero(ByVal ObjectToEvaluate As Decimal) As Object
            If ObjectToEvaluate = 0 Then
                Return "NULL"
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NothingIfNull(ByVal ObjectToEvaluate As Object) As Object
            If ObjectToEvaluate Is DBNull.Value Then
                Return Nothing
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullIfFalse(ByVal ObjectToEvaluate As Boolean) As Object
            If ObjectToEvaluate = False Then
                Return DBNull.Value
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function NullStringIfFalse(ByVal ObjectToEvaluate As Boolean) As Object
            If ObjectToEvaluate = False Then
                Return "NULL"
            Else
                Return ObjectToEvaluate
            End If
        End Function
        Public Shared Function FalseIfNull(ByVal ObjectToEvaluate As Object) As Boolean
            If ObjectToEvaluate Is DBNull.Value Then
                Return False
            Else
                Return CBool(ObjectToEvaluate)
            End If
        End Function
    End Class
End Namespace
