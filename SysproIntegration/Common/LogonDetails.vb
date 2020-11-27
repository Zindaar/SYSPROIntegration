''' <summary>
''' This class follows the singleton pattern to provide the parameters that are used by the Utilities.Logon method.
''' </summary>
''' <remarks>It needs to be set (by calling its SetLogonDetails method) at least once during the lifetime of the application, as well as everytime the parameters with which you wish to logon to SYSPRO change.
''' To have the SysproIntegration functionality work with Web Services (as opposed to DCOM), you need to define the path to the installed Syspro Web Services by way of the following four keys in your application's configuration file:
''' 	<add key="Codewell_SysproIntegration_SysproWS_Setup" value="http://[your server]/sysprowebservices/Setup.asmx" />
'''		<add key="Codewell_SysproIntegration_SysproWS_Transaction" value="http://[your server]/sysprowebservices/Transaction.asmx" />
'''		<add key="Codewell_SysproIntegration_SysproWS_Utilities" value="http://[your server]/sysprowebservices/Utilities.asmx" />
'''		<add key="Codewell_SysproIntegration_SysproWS_Query" value="http://[your server]/sysprowebservices/Query.asmx" />
'''</remarks>
Public Class LogonDetails
    Public Enum CommunicationMethodEnum
        WebServices
        COMDCOM
        WCF
    End Enum

    Private Shared _logonDetails As LogonDetails

    Private _SysproOperator As String
    Private _SysproOperatorPassword As String
    Private _Company As String
    Private _CompanyPassword As String
    Private _languageCode As SysproWS_Utilities.Language
    Private _logDetail As SysproWS_Utilities.LogDetail
    Private _SYSPROInstance As SysproWS_Utilities.Instance
    Private _xmlIn As String
    Private _communicationMethod As CommunicationMethodEnum = CommunicationMethodEnum.WebServices
    Private _logonGUID As String
    Private _baseAddress As String

    Private Sub New(ByVal strSysproOperator As String, _
                    ByVal strSysproOperatorPassword As String, _
                    ByVal strCompany As String, _
                    ByVal strCompanyPassword As String, _
                    ByVal blnLogoff As Boolean, _
                    ByVal enCommunicationMethod As CommunicationMethodEnum, _
                    ByVal baseAddress As String)
        _SysproOperator = strSysproOperator
        _SysproOperatorPassword = strSysproOperatorPassword
        _Company = strCompany
        _CompanyPassword = strCompanyPassword
        _communicationMethod = enCommunicationMethod
        _languageCode = SysproWS_Utilities.Language.ENGLISH
        _logDetail = SysproWS_Utilities.LogDetail.ldNoDebug
        _SYSPROInstance = SysproWS_Utilities.Instance.EncoreInstance_0
        _xmlIn = ""
        _baseAddress = baseAddress

        If blnLogoff Then
            Utilities.Logoff()
        End If
    End Sub

    Private Sub New(ByVal strSysproOperator As String, _
        ByVal strSysproOperatorPassword As String, _
        ByVal strCompany As String, _
        ByVal strCompanyPassword As String, _
        ByVal LanguageCode As SysproWS_Utilities.Language, _
        ByVal LogDetail As SysproWS_Utilities.LogDetail, _
        ByVal SYSPROInstance As SysproWS_Utilities.Instance, _
        ByVal strXmlIn As String, _
        ByVal blnLogoff As Boolean, _
        ByVal enCommunicationMethod As CommunicationMethodEnum, _
        ByVal baseAddress As String)

        _SysproOperator = strSysproOperator
        _SysproOperatorPassword = strSysproOperatorPassword
        _Company = strCompany
        _CompanyPassword = strCompanyPassword
        _languageCode = LanguageCode
        _logDetail = LogDetail
        _SYSPROInstance = SYSPROInstance
        _xmlIn = strXmlIn
        _communicationMethod = enCommunicationMethod
        _baseAddress = baseAddress

        If blnLogoff Then
            Try
                Utilities.Logoff()
            Catch ex As Exception
                'gulp
            End Try
        End If
    End Sub

    Private Sub New(ByVal strLogonGUID As String, ByVal enCommunicationMethod As CommunicationMethodEnum, baseAddress As String)
        _logonGUID = strLogonGUID
        _communicationMethod = enCommunicationMethod
        _languageCode = SysproWS_Utilities.Language.ENGLISH
        _logDetail = SysproWS_Utilities.LogDetail.ldNoDebug
        _SYSPROInstance = SysproWS_Utilities.Instance.EncoreInstance_0
        _xmlIn = ""
        _baseAddress = baseAddress
    End Sub

    ''' <summary>
    ''' Sets the logon details to be used for the next logon to SYSPRO.  If there are existing logon details and they are different to these provided, then a SYSPRO Logoff is processed for the existing details first.
    ''' </summary>
    ''' <param name="strSysproOperator"></param>
    ''' <param name="strSysproOperatorPassword"></param>
    ''' <param name="strCompany"></param>
    ''' <param name="strCompanyPassword"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetLogonDetails(ByVal strSysproOperator As String, _
                                      ByVal strSysproOperatorPassword As String, _
                                      ByVal strCompany As String, _
                                      ByVal strCompanyPassword As String, _
                                      Optional ByVal enCommunicationMethod As CommunicationMethodEnum = CommunicationMethodEnum.WebServices, _
                                      Optional ByVal baseAddress As String = "")
        Dim blnLogoff As Boolean = False
        If Not GetInstance() Is Nothing Then
            'If any of the parameters now being specified have changed we need to log off
            If Not Equals(GetInstance.SysproOperator, strSysproOperator) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.SysproOperatorPassword, strSysproOperatorPassword) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.Company, strCompany) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.CompanyPassword, strCompanyPassword) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.CommunicationMethod, enCommunicationMethod) Then
                blnLogoff = True
            End If
        End If
        _logonDetails = New LogonDetails(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, _
        SysproWS_Utilities.Language.AUTO, SysproWS_Utilities.LogDetail.ldNoDebug, SysproWS_Utilities.Instance.EncoreInstance_0, "", blnLogoff, enCommunicationMethod, baseAddress)

    End Sub

    ''' <summary>
    ''' Sets the logon details to be used for the next logon to SYSPRO.  If there are existing logon details and they are different to these provided, then a SYSPRO Logoff is processed for the existing details first.
    ''' </summary>
    ''' <param name="strSysproOperator"></param>
    ''' <param name="strSysproOperatorPassword"></param>
    ''' <param name="strCompany"></param>
    ''' <param name="strCompanyPassword"></param>
    ''' <param name="LanguageCode"></param>
    ''' <param name="LogDetail"></param>
    ''' <param name="SYSPROInstance"></param>
    ''' <param name="strXmlIn"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetLogonDetails(ByVal strSysproOperator As String, _
        ByVal strSysproOperatorPassword As String, _
        ByVal strCompany As String, _
        ByVal strCompanyPassword As String, _
        ByVal LanguageCode As SysproWS_Utilities.Language, _
        ByVal LogDetail As SysproWS_Utilities.LogDetail, _
        ByVal SYSPROInstance As SysproWS_Utilities.Instance, _
        ByVal strXmlIn As String, _
        Optional ByVal enCommunicationMethod As CommunicationMethodEnum = CommunicationMethodEnum.WebServices, _
        Optional ByVal baseAddress As String = "")

        Dim blnLogoff As Boolean = False

        If Not GetInstance() Is Nothing Then
            'If any of the parameters now being specified have changed we need to log off
            If Not Equals(GetInstance.SysproOperator, strSysproOperator) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.SysproOperatorPassword, strSysproOperatorPassword) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.Company, strCompany) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.CompanyPassword, strCompanyPassword) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.LanguageCode, LanguageCode) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.LogDetail, LogDetail) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.SYSPROInstance, SYSPROInstance) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.XMLIn, strXmlIn) Then
                blnLogoff = True
            End If
            If Not Equals(GetInstance.CommunicationMethod, enCommunicationMethod) Then
                blnLogoff = True
            End If

        End If
        _logonDetails = New LogonDetails(strSysproOperator, strSysproOperatorPassword, strCompany, strCompanyPassword, _
        LanguageCode, LogDetail, SYSPROInstance, strXmlIn, blnLogoff, enCommunicationMethod, baseAddress)

    End Sub

    ''' <summary>
    ''' Sets the logon GUID to be used for e.Net postings to Syspro
    ''' </summary>
    ''' <param name="strLogonGUID"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetLogonDetails(ByVal strLogonGUID As String, _
                                      Optional ByVal enCommunicationMethod As CommunicationMethodEnum = CommunicationMethodEnum.WebServices, _
                                      Optional ByVal baseAddress As String = "")
        _logonDetails = New LogonDetails(strLogonGUID, enCommunicationMethod, baseAddress)
        Utilities.SetExistingSessionID(strLogonGUID)
    End Sub

    ''' <summary>
    ''' Returns the current instance of LogonDetails
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetInstance() As LogonDetails
        Return _logonDetails
    End Function

#Region " Properties "

    Public ReadOnly Property SysproOperator() As String
        Get
            Return _SysproOperator
        End Get
    End Property

    Public ReadOnly Property SysproOperatorPassword() As String
        Get
            Return _SysproOperatorPassword
        End Get
    End Property

    Public ReadOnly Property Company() As String
        Get
            Return _Company
        End Get
    End Property

    Public ReadOnly Property CompanyPassword() As String
        Get
            Return _CompanyPassword
        End Get
    End Property

    Public ReadOnly Property LanguageCode() As SysproWS_Utilities.Language
        Get
            Return _languageCode
        End Get
    End Property

    Public ReadOnly Property LogDetail() As SysproWS_Utilities.LogDetail
        Get
            Return _logDetail
        End Get
    End Property

    Public ReadOnly Property SYSPROInstance() As SysproWS_Utilities.Instance
        Get
            Return _SYSPROInstance
        End Get
    End Property

    Public ReadOnly Property XMLIn() As String
        Get
            Return _xmlIn
        End Get
    End Property

    Public ReadOnly Property CommunicationMethod() As CommunicationMethodEnum
        Get
            Return _communicationMethod
        End Get
    End Property

    Public ReadOnly Property BaseAddress As String
        Get
            Return _baseAddress
        End Get
    End Property
#End Region

End Class
