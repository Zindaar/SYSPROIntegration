Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects.Requisition
    <Serializable()> Public Class RequisitionApproval
        Implements Tallbridge.SysproIntegration.ITransaction

#Region "Private Parameter Data Members"

        Dim _Parameters As String = String.Empty
        Dim _RequisitionActionType As PORTRA_ActionType_Enum = PORTRA_ActionType_Enum.ActionType_Upper_A
        Dim _IgnoreWarnings As PORTRA_IgnoreWarnings_Enum = PORTRA_IgnoreWarnings_Enum.IgnoreWarnings_Upper_Y

#End Region

#Region "Private Document Data Members"
        Dim _Item As String = String.Empty
        Dim _User As String = String.Empty
        Dim _UserPassword As String = String.Empty
        Dim _RequisitionNumber As String = String.Empty
        Dim _RequisitionLine As String = String.Empty
#End Region

#Region "Public Parameter Properties"


        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionActionType() As PORTRA_ActionType_Enum
            Get
                Return _RequisitionActionType
            End Get
            Set(ByVal Value As PORTRA_ActionType_Enum)
                _RequisitionActionType = Value
            End Set
        End Property

        ''' <summary> 
        '''  Specifies if warnings are to be ignored (Y - if the warnings are to be ignored, N - warnings will be returned as errors in the XML returned). An example of a warning is if a ledger code entered is not the correct type of account, it is okay to write the record away as such but you may want the warning supplied.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IgnoreWarnings() As PORTRA_IgnoreWarnings_Enum
            Get
                Return _IgnoreWarnings
            End Get
            Set(ByVal Value As PORTRA_IgnoreWarnings_Enum)
                _IgnoreWarnings = Value
            End Set
        End Property

#End Region

#Region "Public Properties"

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property User() As String
            Get
                Return _User
            End Get
            Set(ByVal Value As String)
                _User = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property UserPassword() As String
            Get
                Return _UserPassword
            End Get
            Set(ByVal Value As String)
                _UserPassword = Value
            End Set
        End Property

        ''' <summary> 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionNumber() As String
            Get
                Return _RequisitionNumber
            End Get
            Set(ByVal Value As String)
                _RequisitionNumber = Value
            End Set
        End Property

        Public Property RequisitionLine() As String
            Get
                Return _RequisitionLine
            End Get
            Set(ByVal value As String)
                _RequisitionLine = value
            End Set
        End Property

#End Region


#Region "Enumerations"
        Public Enum PORTRA_ActionType_Enum
            ActionType_Upper_A
            ActionType_Upper_C
        End Enum

        Public Enum PORTRA_IgnoreWarnings_Enum
            IgnoreWarnings_Upper_Y
            IgnoreWarnings_Upper_N
            IgnoreWarnings_Upper_W
        End Enum
#End Region

#Region "XML String Constructor"

        Private Function ConstructParamXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostReqApprove As System.Xml.XmlElement = xmlDoc.CreateElement("PostReqApprove")
            Dim Parameters As System.Xml.XmlElement = xmlDoc.CreateElement("Parameters")
            Dim ActionType As System.Xml.XmlElement = xmlDoc.CreateElement("ActionType")
            Dim IgnoreWarnings As System.Xml.XmlElement = xmlDoc.CreateElement("IgnoreWarnings")

            xmlDoc.AppendChild(PostReqApprove)
            Common.SysproUtilities.AppendXMLElement(PostReqApprove, Parameters, _Parameters.ToString)
            Common.SysproUtilities.AppendXMLElement(Parameters, ActionType, Common.SysproUtilities.GetEnumValue(_RequisitionActionType.ToString))
            Common.SysproUtilities.AppendXMLElement(Parameters, IgnoreWarnings, Common.SysproUtilities.GetEnumValue(_IgnoreWarnings.ToString))

            Return xmlDoc.OuterXml

        End Function

        Private Function ConstructDocumentXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostReqApprove As System.Xml.XmlElement = xmlDoc.CreateElement("PostReqApprove")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim User As System.Xml.XmlElement = xmlDoc.CreateElement("User")
            Dim UserPassword As System.Xml.XmlElement = xmlDoc.CreateElement("UserPassword")
            Dim RequisitionNumber As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionNumber")
            Dim RequisitionLine As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionLine")

            xmlDoc.AppendChild(PostReqApprove)
            Common.SysproUtilities.AppendXMLElement(PostReqApprove, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, User, _User.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UserPassword, _UserPassword.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionNumber, _RequisitionNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionLine, _RequisitionLine.ToString)

            Return xmlDoc.OuterXml

        End Function


#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "PORTRA"
        Private _ActionType As CommonEnums.ActionType_Transaction

        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public Sub Post() Implements ITransaction.Post
            _xmlOut = Transaction.Post(Me)
        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return Me.ConstructDocumentXML
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public ReadOnly Property xmlParam() As String Implements ITransaction.xmlParam
            Get
                Return Me.ConstructParamXML
            End Get
        End Property
#End Region

    End Class


End Namespace
