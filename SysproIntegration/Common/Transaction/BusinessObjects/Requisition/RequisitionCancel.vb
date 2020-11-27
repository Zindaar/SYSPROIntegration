Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace TransactionObjects.Requisition
    <Serializable()> Public Class RequisitionCancel
        Implements Tallbridge.SysproIntegration.ITransaction

#Region "Private Data Members"

        Dim _Item As String = String.Empty
        Dim _PostReqCancel As String = String.Empty
        Dim _RequisitionLine As String = String.Empty
        Dim _RequisitionNumber As String = String.Empty
        Dim _User As String = String.Empty
        Dim _UserPassword As String = String.Empty


#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  This is the top element for all data required for the transaction.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property Item() As String
            Get
                Return _Item
            End Get
            Set(ByVal Value As String)
                _Item = Value
            End Set
        End Property

        ''' <summary> 
        '''  This is the root element.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property PostReqCancel() As String
            Get
                Return _PostReqCancel
            End Get
            Set(ByVal Value As String)
                _PostReqCancel = Value
            End Set
        End Property

        ''' <summary> 
        '''  The line number of the requisition to be cancelled. Set this element to be zero (or blank) if all lines for the requisition are to be cancelled.
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
        '''  The requisition to be cancelled. All lines of a requisition can be cancelled by setting the RequisitionLine to be zero.
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
        '''  The user who is cancelling the requisition. If the user is not supplied then the user associated with the operator will be assumed. The user must be valid. The user must be the originator of the requisition to be able to cancel it.
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
        '''  The password associated with the user. The password is only required to be supplied if the user element was supplied and it differs from the user associated with the operator default.
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

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim Item As System.Xml.XmlElement = xmlDoc.CreateElement("Item")
            Dim PostReqCancel As System.Xml.XmlElement = xmlDoc.CreateElement("PostReqCancel")
            Dim RequisitionLine As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionLine")
            Dim RequisitionNumber As System.Xml.XmlElement = xmlDoc.CreateElement("RequisitionNumber")
            Dim User As System.Xml.XmlElement = xmlDoc.CreateElement("User")
            Dim UserPassword As System.Xml.XmlElement = xmlDoc.CreateElement("UserPassword")

            xmlDoc.AppendChild(PostReqCancel)
            Common.SysproUtilities.AppendXMLElement(PostReqCancel, Item, _Item.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionLine, _RequisitionLine.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, RequisitionNumber, _RequisitionNumber.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, User, _User.ToString)
            Common.SysproUtilities.AppendXMLElement(Item, UserPassword, _UserPassword.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region "Common Variables"
        Private _xmlParam As String
        Private _xmlIn As String
        Private _xmlOut As String
        Private _BusinessObject As String = "PORTRC"
        Private _ProcessedElement As String
        Private _ActionType As CommonEnums.ActionType_Transaction

        Public ReadOnly Property ProcessedElement() As String
            Get
                Dim xmlDoc As System.Xml.XmlDocument
                Dim xmlNode As System.Xml.XmlNode

                xmlDoc = New System.Xml.XmlDocument
                xmlDoc.LoadXml(_xmlOut)

                'Check return XML for errors by looking for any XML elements containing ErrorDescription
                xmlNode = xmlDoc.DocumentElement.SelectSingleNode("item/Requisition")
                If xmlNode Is Nothing Then
                    Return "0"
                Else
                    Return xmlNode.InnerText
                End If
            End Get
        End Property

        Public ReadOnly Property BusinessObject() As String Implements ITransaction.BusinessObject
            Get
                Return _BusinessObject
            End Get
        End Property

        Public ReadOnly Property xmlOut() As String Implements ITransaction.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

        Public Property ActionType() As CommonEnums.ActionType_Transaction Implements ITransaction.TransactionActionType
            Get
                Return _ActionType
            End Get
            Set(ByVal value As CommonEnums.ActionType_Transaction)
                _ActionType = value
            End Set
        End Property

        Public Sub Post() Implements ITransaction.Post
            _xmlOut = Transaction.Post(Me)
            Common.SysproUtilities.CheckXMLOut(xmlData, xmlParam, xmlOut, "Requisition")
        End Sub

        Public ReadOnly Property xmlData() As String Implements ITransaction.xmlData
            Get
                Return Me.ConstructXML
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
