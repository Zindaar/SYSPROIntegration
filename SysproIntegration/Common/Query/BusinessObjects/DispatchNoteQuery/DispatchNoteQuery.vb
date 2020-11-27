Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Xml
Imports System.IO
Namespace QueryObjects.DispatchNoteQuery
    <Serializable()> Public Class DispatchNoteQuery
        Implements IQuery


#Region "Private Data Members"

        Dim _xQuery As String = String.Empty
        Dim _Key As String = String.Empty
        Dim _DispatchNote As String = String.Empty
        Dim _xOption As String = String.Empty
        Dim _IncludeStockedLines As DispatchNoteQuery_IncludeStockedLines_Enum = DispatchNoteQuery_IncludeStockedLines_Enum.IncludeStockedLines_Upper_Y
        Dim _IncludeNonStockedLines As DispatchNoteQuery_IncludeNonStockedLines_Enum = DispatchNoteQuery_IncludeNonStockedLines_Enum.IncludeNonStockedLines_Upper_Y
        Dim _IncludeFreightLines As DispatchNoteQuery_IncludeFreightLines_Enum = DispatchNoteQuery_IncludeFreightLines_Enum.IncludeFreightLines_Upper_Y
        Dim _IncludeMiscellaneousLines As DispatchNoteQuery_IncludeMiscellaneousLines_Enum = DispatchNoteQuery_IncludeMiscellaneousLines_Enum.IncludeMiscellaneousLines_Upper_Y
        Dim _IncludeCommentLines As DispatchNoteQuery_IncludeCommentLines_Enum = DispatchNoteQuery_IncludeCommentLines_Enum.IncludeCommentLines_Upper_Y
        Dim _IncludeLots As DispatchNoteQuery_IncludeLots_Enum = DispatchNoteQuery_IncludeLots_Enum.IncludeLots_Upper_Y
        Dim _IncludeBins As DispatchNoteQuery_IncludeBins_Enum = DispatchNoteQuery_IncludeBins_Enum.IncludeBins_Upper_Y
        Dim _IncludeSerials As DispatchNoteQuery_IncludeSerials_Enum = DispatchNoteQuery_IncludeSerials_Enum.IncludeSerials_Upper_Y
        Dim _IncludeCustomForms As String = String.Empty
        Dim _XslStylesheet As String = String.Empty


#End Region

#Region "Public Properties"

        ''' <summary> 
        '''  The root element
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
        '''  The key to use for this query.
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
        '''  The query key is mandatory, and should contain a valid dispatch note. If the key is missing an error message is returned. Again if the dispatch note is not on file, an error message is returned.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property DispatchNote() As String
            Get
                Return _DispatchNote
            End Get
            Set(ByVal Value As String)
                _DispatchNote = Value
            End Set
        End Property

        ''' <summary> 
        '''  List of options
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
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include line type 1 merchandise lines attached in a dispatch note.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeStockedLines() As DispatchNoteQuery_IncludeStockedLines_Enum
            Get
                Return _IncludeStockedLines
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeStockedLines_Enum)
                _IncludeStockedLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include line type 7 merchandise lines in a dispatch note.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeNonStockedLines() As DispatchNoteQuery_IncludeNonStockedLines_Enum
            Get
                Return _IncludeNonStockedLines
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeNonStockedLines_Enum)
                _IncludeNonStockedLines = Value
            End Set
        End Property

        ''' <summary> 
        '''   (Y - Yes, N - No, Default to Y) - you use this option to include freight lines in a dispatch note.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeFreightLines() As DispatchNoteQuery_IncludeFreightLines_Enum
            Get
                Return _IncludeFreightLines
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeFreightLines_Enum)
                _IncludeFreightLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include miscellaneous lines in a dispatch note.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeMiscellaneousLines() As DispatchNoteQuery_IncludeMiscellaneousLines_Enum
            Get
                Return _IncludeMiscellaneousLines
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeMiscellaneousLines_Enum)
                _IncludeMiscellaneousLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include comment lines in a dispatch note.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCommentLines() As DispatchNoteQuery_IncludeCommentLines_Enum
            Get
                Return _IncludeCommentLines
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeCommentLines_Enum)
                _IncludeCommentLines = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to N) - you use this option to include dispatch note lots information. 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeLots() As DispatchNoteQuery_IncludeLots_Enum
            Get
                Return _IncludeLots
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeLots_Enum)
                _IncludeLots = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include dispatch note bins information.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeBins() As DispatchNoteQuery_IncludeBins_Enum
            Get
                Return _IncludeBins
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeBins_Enum)
                _IncludeBins = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to Y) - you use this option to include dispatch note serial numbers.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeSerials() As DispatchNoteQuery_IncludeSerials_Enum
            Get
                Return _IncludeSerials
            End Get
            Set(ByVal Value As DispatchNoteQuery_IncludeSerials_Enum)
                _IncludeSerials = Value
            End Set
        End Property

        ''' <summary> 
        '''  (Y - Yes, N - No, Default to N) - you use this option to include custom forms defined against the dispatch note number.
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks></remarks> 
        Public Property IncludeCustomForms() As String
            Get
                Return _IncludeCustomForms
            End Get
            Set(ByVal Value As String)
                _IncludeCustomForms = Value
            End Set
        End Property

        ''' <summary> 
        '''  XSL Stylesheet to use
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



#End Region

#Region "Enumerations"

        Public Enum DispatchNoteQuery_IncludeStockedLines_Enum
            IncludeStockedLines_Upper_Y
            IncludeStockedLines_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeNonStockedLines_Enum
            IncludeNonStockedLines_Upper_Y
            IncludeNonStockedLines_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeFreightLines_Enum
            IncludeFreightLines_Upper_Y
            IncludeFreightLines_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeMiscellaneousLines_Enum
            IncludeMiscellaneousLines_Upper_Y
            IncludeMiscellaneousLines_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeCommentLines_Enum
            IncludeCommentLines_Upper_Y
            IncludeCommentLines_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeLots_Enum
            IncludeLots_Upper_Y
            IncludeLots_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeBins_Enum
            IncludeBins_Upper_Y
            IncludeBins_Upper_N
        End Enum
        Public Enum DispatchNoteQuery_IncludeSerials_Enum
            IncludeSerials_Upper_Y
            IncludeSerials_Upper_N
        End Enum


#End Region

#Region "XML String Constructor"

        Private Function ConstructXML() As String

            Dim xmlDoc As New System.Xml.XmlDocument

            Dim xQuery As System.Xml.XmlElement = xmlDoc.CreateElement("Query")
            Dim Key As System.Xml.XmlElement = xmlDoc.CreateElement("Key")
            Dim DispatchNote As System.Xml.XmlElement = xmlDoc.CreateElement("DispatchNote")
            Dim xOption As System.Xml.XmlElement = xmlDoc.CreateElement("Option")
            Dim IncludeStockedLines As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeStockedLines")
            Dim IncludeNonStockedLines As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeNonStockedLines")
            Dim IncludeFreightLines As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeFreightLines")
            Dim IncludeMiscellaneousLines As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeMiscellaneousLines")
            Dim IncludeCommentLines As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCommentLines")
            Dim IncludeLots As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeLots")
            Dim IncludeBins As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeBins")
            Dim IncludeSerials As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeSerials")
            Dim IncludeCustomForms As System.Xml.XmlElement = xmlDoc.CreateElement("IncludeCustomForms")
            Dim XslStylesheet As System.Xml.XmlElement = xmlDoc.CreateElement("XslStylesheet")

            xmlDoc.AppendChild(xQuery)
            Common.SysproUtilities.AppendXMLElement(xQuery, Key, _Key.ToString)
            Common.SysproUtilities.AppendXMLElement(Key, DispatchNote, _DispatchNote.ToString)
            Common.SysproUtilities.AppendXMLElement(xQuery, xOption, _xOption.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeStockedLines, Common.SysproUtilities.GetEnumValue(_IncludeStockedLines.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeNonStockedLines, Common.SysproUtilities.GetEnumValue(_IncludeNonStockedLines.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeFreightLines, Common.SysproUtilities.GetEnumValue(_IncludeFreightLines.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeMiscellaneousLines, Common.SysproUtilities.GetEnumValue(_IncludeMiscellaneousLines.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCommentLines, Common.SysproUtilities.GetEnumValue(_IncludeCommentLines.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeLots, Common.SysproUtilities.GetEnumValue(_IncludeLots.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeBins, Common.SysproUtilities.GetEnumValue(_IncludeBins.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeSerials, Common.SysproUtilities.GetEnumValue(_IncludeSerials.ToString))
            Common.SysproUtilities.AppendXMLElement(xOption, IncludeCustomForms, _IncludeCustomForms.ToString)
            Common.SysproUtilities.AppendXMLElement(xOption, XslStylesheet, _XslStylesheet.ToString)

            Return xmlDoc.OuterXml

        End Function

#End Region

#Region " IQuery Interface "

        Private _actiontype As CommonEnums.ActionType_Query
        Public Property ActionType() As CommonEnums.ActionType_Query Implements IQuery.ActionType
            Get
                Return _actiontype
            End Get
            Set(ByVal value As CommonEnums.ActionType_Query)
                _actiontype = value
            End Set
        End Property

        Public ReadOnly Property BusinessObject() As String Implements IQuery.BusinessObject
            Get
                Return "SORQDN"
            End Get
        End Property

        Public Sub Post() Implements IQuery.Post
            Select Case _actiontype
                Case CommonEnums.ActionType_Query.Browse
                    _xmlOut = Query.Browse(Me)
                Case CommonEnums.ActionType_Query.Fetch
                    _xmlOut = Query.Fetch(Me)
                Case CommonEnums.ActionType_Query.NextKey
                    _xmlOut = Query.NextKey(Me)
                Case CommonEnums.ActionType_Query.PreviousKey
                    _xmlOut = Query.PreviousKey(Me)
                Case CommonEnums.ActionType_Query.Query
                    _xmlOut = Query.Query(Me)
            End Select
        End Sub

        Public ReadOnly Property xmlData() As String Implements IQuery.xmlData
            Get
                Return ConstructXML()
            End Get
        End Property

        Private _xmlOut As String
        Public ReadOnly Property xmlOut() As String Implements IQuery.xmlOut
            Get
                Return _xmlOut
            End Get
        End Property

#End Region

    End Class

End Namespace
