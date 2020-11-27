Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO

Namespace QueryObjects.CustomerQuery

    <Serializable()> Public Class CustomerQuery
        Implements SysproIntegration.IQuery

#Region "Private Data Members"

        Dim _Customer As String = String.Empty
        Dim _Key As String = String.Empty
        Dim _xOption As String = String.Empty
        Dim _xQuery As String = String.Empty
        Dim _AgeingOption As CustomerQuery_AgeingOption_Enum
        Dim _AgeColumn1 As String = String.Empty
        Dim _AgeColumn2 As String = String.Empty
        Dim _AgeColumn3 As String = String.Empty
        Dim _AgeColumn4 As String = String.Empty
        Dim _AgeColumn5 As String = String.Empty
        Dim _AgeColumn6 As String = String.Empty
        Dim _AgeColumn7 As String = String.Empty
        Dim _XslStylesheet As String = String.Empty
        Dim _MultiMediaImageType As String = String.Empty
        Dim _IncludeFutures As CustomerQuery_IncludeFutures_Enum = CustomerQuery_IncludeFutures_Enum.IncludeFutures_Upper_N
        Dim _IncludeTransactions As CustomerQuery_IncludeTransactions_Enum = CustomerQuery_IncludeTransactions_Enum.IncludeTransactions_Upper_Y
        Dim _IncludeCheckPayments As CustomerQuery_IncludeCheckPayments_Enum = CustomerQuery_IncludeCheckPayments_Enum.IncludeCheckPayments_Upper_Y
        Dim _IncludePostDated As CustomerQuery_IncludePostDated_Enum = CustomerQuery_IncludePostDated_Enum.IncludePostDated_Upper_Y
        Dim _IncludeCustomForms As CustomerQuery_IncludeCustomForms_Enum = CustomerQuery_IncludeCustomForms_Enum.IncludeCustomForms_Upper_N
        Dim _IncludeZeroBalances As CustomerQuery_IncludeZeroBalances_Enum = CustomerQuery_IncludeZeroBalances_Enum.IncludeZeroBalances_Upper_N
        Dim _AsOfPeriod As CustomerQuery_AsOfPeriod_Enum = CustomerQuery_AsOfPeriod_Enum.AsOfPeriod_Upper_C


#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  The customer for which the statement is required
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal Value As String)
                _Customer = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Key() As String
            Get
                Return _Key
            End Get
            Set(ByVal Value As String)
                _Key = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xOption() As String
            Get
                Return _xOption
            End Get
            Set(ByVal Value As String)
                _xOption = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property xQuery() As String
            Get
                Return _xQuery
            End Get
            Set(ByVal Value As String)
                _xQuery = Value
            End Set
        End Property

        ''' <summary> 
        '''  Indicates the ageing option that should be used for the run of the program. If no ageing option is used then the default ageing option for the company will be used. Valid ageing options are S - By Statement or A - By aged statement or I - By invoice date or D - By invoice due date.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeingOption() As CustomerQuery_AgeingOption_Enum
            Get
                Return _AgeingOption
            End Get
            Set(ByVal Value As CustomerQuery_AgeingOption_Enum)
                _AgeingOption = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the first column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn1() As String
            Get
                Return _AgeColumn1
            End Get
            Set(ByVal Value As String)
                _AgeColumn1 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the second column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn2() As String
            Get
                Return _AgeColumn2
            End Get
            Set(ByVal Value As String)
                _AgeColumn2 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the third column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn3() As String
            Get
                Return _AgeColumn3
            End Get
            Set(ByVal Value As String)
                _AgeColumn3 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the fourth column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn4() As String
            Get
                Return _AgeColumn4
            End Get
            Set(ByVal Value As String)
                _AgeColumn4 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the fifth column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn5() As String
            Get
                Return _AgeColumn5
            End Get
            Set(ByVal Value As String)
                _AgeColumn5 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the sixth column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn6() As String
            Get
                Return _AgeColumn6
            End Get
            Set(ByVal Value As String)
                _AgeColumn6 = Value
            End Set
        End Property

        ''' <summary> 
        '''  The value supplied will be used for the seventh column of ageing. If no value is supplied then the ageing value against the customers default statement format will be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AgeColumn7() As String
            Get
                Return _AgeColumn7
            End Get
            Set(ByVal Value As String)
                _AgeColumn7 = Value
            End Set
        End Property

        ''' <summary> 
        '''  Indicates what style sheet should be used.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property XslStylesheet() As String
            Get
                Return _XslStylesheet
            End Get
            Set(ByVal Value As String)
                _XslStylesheet = Value
            End Set
        End Property

        ''' <summary> 
        '''  Image type to retrieve (for example: GIF, JPG)
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property MultiMediaImageType() As String
            Get
                Return _MultiMediaImageType
            End Get
            Set(ByVal Value As String)
                _MultiMediaImageType = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include future invoices ? (Y - Yes, N - No))
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeFutures() As CustomerQuery_IncludeFutures_Enum
            Get
                Return _IncludeFutures
            End Get
            Set(ByVal Value As CustomerQuery_IncludeFutures_Enum)
                _IncludeFutures = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include invoice transaction details ? (Y - Yes, N - No))
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeTransactions() As CustomerQuery_IncludeTransactions_Enum
            Get
                Return _IncludeTransactions
            End Get
            Set(ByVal Value As CustomerQuery_IncludeTransactions_Enum)
                _IncludeTransactions = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include check payment details ? (Y - Yes, N - No))
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCheckPayments() As CustomerQuery_IncludeCheckPayments_Enum
            Get
                Return _IncludeCheckPayments
            End Get
            Set(ByVal Value As CustomerQuery_IncludeCheckPayments_Enum)
                _IncludeCheckPayments = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include post dated check details ? (Y - Yes, N - No))
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludePostDated() As CustomerQuery_IncludePostDated_Enum
            Get
                Return _IncludePostDated
            End Get
            Set(ByVal Value As CustomerQuery_IncludePostDated_Enum)
                _IncludePostDated = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include fields from custom forms ? (N - No, Y - Yes,). Default is N - No.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCustomForms() As CustomerQuery_IncludeCustomForms_Enum
            Get
                Return _IncludeCustomForms
            End Get
            Set(ByVal Value As CustomerQuery_IncludeCustomForms_Enum)
                _IncludeCustomForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  Do you wish to include invoices with a zero balance ? (Y - Yes, N - No))
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeZeroBalances() As CustomerQuery_IncludeZeroBalances_Enum
            Get
                Return _IncludeZeroBalances
            End Get
            Set(ByVal Value As CustomerQuery_IncludeZeroBalances_Enum)
                _IncludeZeroBalances = Value
            End Set
        End Property

        ''' <summary> 
        '''  This element specifies the period from which to return data (C - current period backwards, P - the previous period backwards, 2 - previous period two backwards). If this element is not provided the default is C.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property AsOfPeriod() As CustomerQuery_AsOfPeriod_Enum
            Get
                Return _AsOfPeriod
            End Get
            Set(ByVal Value As CustomerQuery_AsOfPeriod_Enum)
                _AsOfPeriod = Value
            End Set
        End Property



#End Region

#Region "Enumerations"

        Public Enum CustomerQuery_AgeingOption_Enum
            AgeingOption_Upper_S
            AgeingOption_Upper_A
            AgeingOption_Upper_I
            AgeingOption_Upper_D
        End Enum
        Public Enum CustomerQuery_IncludeFutures_Enum
            IncludeFutures_Upper_Y
            IncludeFutures_Upper_N
        End Enum
        Public Enum CustomerQuery_IncludeTransactions_Enum
            IncludeTransactions_Upper_Y
            IncludeTransactions_Upper_N
        End Enum
        Public Enum CustomerQuery_IncludeCheckPayments_Enum
            IncludeCheckPayments_Upper_Y
            IncludeCheckPayments_Upper_N
        End Enum
        Public Enum CustomerQuery_IncludePostDated_Enum
            IncludePostDated_Upper_Y
            IncludePostDated_Upper_N
        End Enum
        Public Enum CustomerQuery_IncludeCustomForms_Enum
            IncludeCustomForms_Upper_N
            IncludeCustomForms_Upper_Y
        End Enum
        Public Enum CustomerQuery_IncludeZeroBalances_Enum
            IncludeZeroBalances_Upper_Y
            IncludeZeroBalances_Upper_N
        End Enum
        Public Enum CustomerQuery_AsOfPeriod_Enum
            AsOfPeriod_Upper_C
            AsOfPeriod_Upper_P
            AsOfPeriod_2
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim Customer As System.Xml.XmlElement = xmlDoc.CreateElement("Customer")
            Dim xKey As System.Xml.XmlElement = xmlDoc.CreateElement("Key")
            Dim xOption As System.Xml.XmlElement = xmlDoc.CreateElement("Option")
            Dim xQuery As System.Xml.XmlElement = xmlDoc.CreateElement("Query")
            Dim AgeingOption As System.Xml.XmlElement = xmlDoc.CreateElement("AgeingOption")
            Dim AgeColumn1 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn1")
            Dim AgeColumn2 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn2")
            Dim AgeColumn3 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn3")
            Dim AgeColumn4 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn4")
            Dim AgeColumn5 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn5")
            Dim AgeColumn6 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn6")
            Dim AgeColumn7 As System.Xml.XmlElement = xmlDoc.CreateElement("AgeColumn7")
            Dim XslStylesheet As System.Xml.XmlElement = xmlDoc.CreateElement("XslStylesheet")
            Dim MultiMediaImageType As System.Xml.XmlElement = xmlDoc.CreateElement("MultiMediaImageType")
            Dim IncludeFutures As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeFutures")
            Dim IncludeTransactions As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeTransactions")
            Dim IncludeCheckPayments As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCheckPayments")
            Dim IncludePostDated As System.Xml.XmlElement = xmlDoc.CreateElement("IncludePostDated")
            Dim IncludeCustomForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCustomForms")
            Dim IncludeZeroBalances As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeZeroBalances")
            Dim AsOfPeriod As System.Xml.XmlElement = xmlDoc.CreateElement("AsOfPeriod")

            xmlDoc.AppendChild(xQuery) 'Common.SysproUtilities.AppendXMLElement(xmlDoc, xQuery, _xQuery.ToString)
            Common.SysproUtilities.AppendXMLElement(xQuery, xKey, _Key.ToString)
            Common.SysproUtilities.AppendXMLElement(xKey, Customer, _Customer.ToString)
            Common.SysproUtilities.AppendXMLElement(xQuery, xOption, _xOption.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeingOption, Common.SysproUtilities.GetEnumValue(_AgeingOption.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn1, _AgeColumn1.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn2, _AgeColumn2.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn3, _AgeColumn3.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn4, _AgeColumn4.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn5, _AgeColumn5.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn6, _AgeColumn6.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, AgeColumn7, _AgeColumn7.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, XslStylesheet, _XslStylesheet.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, MultiMediaImageType, _MultiMediaImageType.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeFutures, Common.SysproUtilities.GetEnumValue(_IncludeFutures.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeTransactions, Common.SysproUtilities.GetEnumValue(_IncludeTransactions.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCheckPayments, Common.SysproUtilities.GetEnumValue(_IncludeCheckPayments.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludePostDated, Common.SysproUtilities.GetEnumValue(_IncludePostDated.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCustomForms, Common.SysproUtilities.GetEnumValue(_IncludeCustomForms.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeZeroBalances, Common.SysproUtilities.GetEnumValue(_IncludeZeroBalances.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, AsOfPeriod, Common.SysproUtilities.GetEnumValue(_AsOfPeriod.ToString))

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region " Interface "

        Private _ActionType As CommonEnums.ActionType_Query
        Public Property ActionType() As CommonEnums.ActionType_Query Implements IQuery.ActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "ARSQRY"
            End Get
        End Property

        Public Sub Post() Implements IQuery.Post

            Select Case ActionType
                Case CommonEnums.ActionType_Query.Browse
                    _xmlout = Query.Browse(Me)
                Case CommonEnums.ActionType_Query.Fetch
                    _xmlout = Query.Fetch(Me)
                Case CommonEnums.ActionType_Query.NextKey
                    _xmlout = Query.NextKey(Me)
                Case CommonEnums.ActionType_Query.PreviousKey
                    _xmlout = Query.PreviousKey(Me)
                Case Else ' CommonEnums.ActionType_Query.Query
                    _xmlout = Query.Query(Me)
            End Select

        End Sub

        Public ReadOnly Property xmlData() As String Implements IQuery.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Private _xmlout As String = ""
        Public ReadOnly Property xmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlout
            End Get
        End Property

#End Region

    End Class


End Namespace