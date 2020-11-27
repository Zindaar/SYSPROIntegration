Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class SystemInformation

#Region " Properties "

        Private _CssStyle As String
        Private _Language As String
        Private _DecFormat As String
        Private _DateFormat As String
        Private _Role As String
        Private _Version As String
        Private _CompanyId As String
        Private _CompanyName As String
        Private _OperatorCode As String
        Private _OperatorName As String
        Private _OperatorGroup As String
        Private _OperatorEmailAddress As String
        Private _OperatorLocation As String
        Private _ReportDate As String
        Private _UseSeparatorOnReports As String
        Private _SeparatorToUse As String

        Public Property CssStyle() As String
            Get
                Return _CssStyle
            End Get
            Set(ByVal Value As String)
                _CssStyle = Value
            End Set
        End Property
        Public Property Language() As String
            Get
                Return _Language
            End Get
            Set(ByVal Value As String)
                _Language = Value
            End Set
        End Property
        Public Property DecFormat() As String
            Get
                Return _DecFormat
            End Get
            Set(ByVal Value As String)
                _DecFormat = Value
            End Set
        End Property
        Public Property DateFormat() As String
            Get
                Return _DateFormat
            End Get
            Set(ByVal Value As String)
                _DateFormat = Value
            End Set
        End Property
        Public Property Role() As String
            Get
                Return _Role
            End Get
            Set(ByVal Value As String)
                _Role = Value
            End Set
        End Property
        Public Property Version() As String
            Get
                Return _Version
            End Get
            Set(ByVal Value As String)
                _Version = Value
            End Set
        End Property
        Public Property CompanyId() As String
            Get
                Return _CompanyId
            End Get
            Set(ByVal Value As String)
                _CompanyId = Value
            End Set
        End Property
        Public Property CompanyName() As String
            Get
                Return _CompanyName
            End Get
            Set(ByVal Value As String)
                _CompanyName = Value
            End Set
        End Property
        Public Property OperatorCode() As String
            Get
                Return _OperatorCode
            End Get
            Set(ByVal Value As String)
                _OperatorCode = Value
            End Set
        End Property
        Public Property OperatorName() As String
            Get
                Return _OperatorName
            End Get
            Set(ByVal Value As String)
                _OperatorName = Value
            End Set
        End Property
        Public Property OperatorGroup() As String
            Get
                Return _OperatorGroup
            End Get
            Set(ByVal Value As String)
                _OperatorGroup = Value
            End Set
        End Property
        Public Property OperatorEmailAddress() As String
            Get
                Return _OperatorEmailAddress
            End Get
            Set(ByVal Value As String)
                _OperatorEmailAddress = Value
            End Set
        End Property
        Public Property OperatorLocation() As String
            Get
                Return _OperatorLocation
            End Get
            Set(ByVal Value As String)
                _OperatorLocation = Value
            End Set
        End Property
        Public Property ReportDate() As String
            Get
                Return _ReportDate
            End Get
            Set(ByVal Value As String)
                _ReportDate = Value
            End Set
        End Property
        Public Property UseSeparatorOnReports() As String
            Get
                Return _UseSeparatorOnReports
            End Get
            Set(ByVal Value As String)
                _UseSeparatorOnReports = Value
            End Set
        End Property
        Public Property SeparatorToUse() As String
            Get
                Return _SeparatorToUse
            End Get
            Set(ByVal Value As String)
                _SeparatorToUse = Value
            End Set
        End Property

#End Region

        Friend Sub New(ByVal ds As DataSet)
            Dim r As DataRow
            If ds.Tables("SystemInformation") Is Nothing Then
                Exit Sub
            Else
                r = ds.Tables("SystemInformation").Rows(0)
            End If

            _CssStyle = Convert.ToString(r("CssStyle"))
            _Language = Convert.ToString(r("Language"))
            _DecFormat = Convert.ToString(r("DecFormat"))
            _DateFormat = Convert.ToString(r("DateFormat"))
            _Role = Convert.ToString(r("Role"))
            _Version = Convert.ToString(r("Version"))
            _CompanyId = Convert.ToString(r("CompanyId"))
            _CompanyName = Convert.ToString(r("CompanyName"))
            _OperatorCode = Convert.ToString(r("OperatorCode"))
            _OperatorName = Convert.ToString(r("OperatorName"))
            _OperatorGroup = Convert.ToString(r("OperatorGroup"))
            _OperatorEmailAddress = Convert.ToString(r("OperatorEmailAddress"))
            _OperatorLocation = Convert.ToString(r("OperatorLocation"))
            _ReportDate = Convert.ToString(r("ReportDate"))
            _UseSeparatorOnReports = Convert.ToString(r("UseSeparatorOnReports"))
            _SeparatorToUse = Convert.ToString(r("SeparatorToUse"))

        End Sub
    End Class

End Namespace