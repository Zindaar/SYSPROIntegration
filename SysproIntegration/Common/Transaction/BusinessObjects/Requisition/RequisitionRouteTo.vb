Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects.Requisition
    <Serializable()> Public Class RequisitionRouteTo
        Implements Tallbridge.SysproIntegration.ITransaction

#Region "Private Parameter Data Members"

#End Region

#Region "Private Document Data Members"
        Dim _Item As String = String.Empty
        Dim _RequisitionLine As String = String.Empty
        Dim _RequisitionNumber As String = String.Empty
        Dim _RouteNotation As String = String.Empty
        Dim _RouteToUser As String = String.Empty
        Dim _User As String = String.Empty
        Dim _UserPassword As String = String.Empty
#End Region

#Region "Public Parameter Properties"

#End Region

#Region "Public Properties"
        ''' <summary> 
        '''  The line number of the requisition to be routed. Set this element to be zero (or blank) if all lines for the requisition are to be routed to the same user.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RequisitionLine() As String
            Get
                Return _RequisitionLine
            End Get
            Set(ByVal Value As String)
                _RequisitionLine = Value
            End Set
        End Property

        ''' <summary> 
        '''  The requisition to be routed. All lines of a requisition can be routed by setting the RequisitionLine to be zero.
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

        ''' <summary> 
        '''  Notation to be associated with the routing to the new user.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteNotation() As String
            Get
                Return _RouteNotation
            End Get
            Set(ByVal Value As String)
                _RouteNotation = Value
            End Set
        End Property

        ''' <summary> 
        '''  The user for whom the requisition is intended to be routed. The user must be valid.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property RouteToUser() As String
            Get
                Return _RouteToUser
            End Get
            Set(ByVal Value As String)
                _RouteToUser = Value
            End Set
        End Property

        ''' <summary> 
        '''  The user who is routing the requisition. If the user is not supplied then the user associated with the operator will be assumed. The user must be the current holder of the requisition to be able to route it to another user.
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

#End Region

#Region "Enumerations"

#End Region

#Region "XML String Constructor"
        Private Function ConstructDocumentXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim PostReqRoute As System.Xml.XmlElement = xmlDoc.CreateElement("PostReqRoute")
            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim User As System.Xml.XmlElement = xmlDoc.CreateElement("User")
            Dim UserPassword As System.Xml.XmlElement = xmlDoc.CreateElement("UserPassword")
            Dim RequisitionNumber As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionNumber")
            Dim RequisitionLine As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionLine")
            Dim RouteToUser As System.Xml.XmlElement = xmlDoc.CreateElement("RouteToUser")
            Dim RouteNotation As System.Xml.XmlElement = xmlDoc.CreateElement("RouteNotation")

            xmlDoc.AppendChild(PostReqRoute)
            Common.SysproUtilities.AppendXMLElement(PostReqRoute, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, User, _User.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UserPassword, _UserPassword.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionNumber, _RequisitionNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionLine, _RequisitionLine.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RouteToUser, _RouteToUser.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RouteNotation, _RouteNotation.ToString)

            Return xmlDoc.OuterXml
        End Function
#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "PORTRR"
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
                Return ""
            End Get
        End Property
#End Region


    End Class
End Namespace
