Namespace Common
    <Serializable()> Public Class SysproUtilities

        ''' <summary>
        ''' this method takes a value in string format and converts it to its respective enumeration
        ''' </summary>
        ''' <typeparam name="T">The Enum that the value must be converted to</typeparam>
        ''' <param name="Prefix">The prefix of the Enum Value</param>
        ''' <param name="ValueToConvert">The Value that must be converted to the Enumeration</param>
        ''' <returns>Returns a valid enumeration</returns>
        ''' <remarks></remarks>
        Friend Shared Function ConvertValueToEnum(Of T)(ByVal Prefix As String, ByVal ValueToConvert As String) As T

            If ValueToConvert = "" Then
                ValueToConvert = "Item"
            ElseIf ValueToConvert = " " Or ValueToConvert = "  " Then
                ValueToConvert = "Item"
                'Else
                '    If Not IsNumeric(ValueToConvert) Then
                '        If String.Compare(ValueToConvert, UCase(ValueToConvert)) = 0 Then
                '            ValueToConvert = "Upper_" & ValueToConvert
                '        Else
                '            ValueToConvert = "Lower_" & ValueToConvert
                '        End If
                '    End If

            End If

            Return CType(System.Enum.Parse(GetType(T), Prefix & "_" & ValueToConvert), T)

        End Function

        ''' <summary>
        ''' this method takes a value in string format and converts it to its respective enumeration
        ''' </summary>
        ''' <typeparam name="T">The Enum that the value must be converted to</typeparam>
        ''' <param name="ValueToConvert">The Value that must be converted to the Enumeration</param>
        ''' <returns>Returns a valid enumeration</returns>
        ''' <remarks></remarks>
        Friend Shared Function ConvertValueToEnum(Of T)(ByVal ValueToConvert As String) As T

            ValueToConvert = ValueToConvert.Trim
            If String.IsNullOrEmpty(ValueToConvert) Then
                ValueToConvert = "Item"
            ElseIf IsNumeric(ValueToConvert) Then
                ValueToConvert = "Item" & ValueToConvert
            End If

            Return CType(System.Enum.Parse(GetType(T), ValueToConvert), T)

        End Function

        ''' <summary>
        ''' this method takes a value in Boolean format and converts it to its respective enumeration
        ''' </summary>
        ''' <typeparam name="T">The Enum that the value must be converted to</typeparam>
        ''' <param name="Prefix">The prefix of the Enum Value</param>
        ''' <param name="BooleanToConvert">The Boolean Value that must be converted to the Enumeration</param>
        ''' <returns>Returns a valid enumeration</returns>
        ''' <remarks></remarks>
        Friend Shared Function ConvertValueToEnum(Of T)(ByVal Prefix As String, ByVal BooleanToConvert As Boolean) As T

            Dim Result As String

            If BooleanToConvert Then
                Result = "Upper_Y"
            Else
                Result = "Upper_N"
            End If

            Return CType(System.Enum.Parse(GetType(T), Prefix & "_" & Result), T)

        End Function


        ''' <summary>
        ''' This method checks to see if a value is Blank or a Space and returns the required value
        ''' </summary>
        ''' <param name="Enumeration"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared Function GetEnumValue(ByVal Enumeration As String) As String

            If Right(Enumeration, 5) = "Blank" Then
                Return ""
            End If

            If Right(Enumeration, 5) = "Space" Then
                Return " "
            End If

            Return Right(Enumeration.ToString, 1)

        End Function

        ''' <summary>
        ''' This method appends an element to its parent
        ''' </summary>
        ''' <param name="ParentElement">The Parent Element</param>
        ''' <param name="ChildElement">The Child Element to append to the Parent Element</param>
        ''' <param name="XMLValue">The value to check</param>
        ''' <remarks></remarks>
        Friend Shared Sub AppendXMLElement(ByRef ParentElement As Xml.XmlElement, ByVal ChildElement As Xml.XmlElement, ByVal XMLValue As String)

            ParentElement.AppendChild(ChildElement)
            ChildElement.InnerText = XMLValue

        End Sub

        ''' <summary>
        ''' This method appends an Attribute to its parent
        ''' </summary>
        ''' <param name="ParentElement">The Parent Element</param>
        ''' <param name="ChildAttribute">The Child Attribute to append to the Parent Element</param>
        ''' <param name="XMLValue">The value to check</param>
        ''' <remarks></remarks>
        Friend Shared Sub AppendXMLAttribute(ByRef ParentElement As Xml.XmlElement, ByVal ChildAttribute As Xml.XmlAttribute, ByVal XMLValue As String)

            ParentElement.Attributes.Append(ChildAttribute)
            ChildAttribute.InnerText = XMLValue

        End Sub

        ''' <summary>
        ''' This method appends two atrributes to an element. FilterType and FilterValue
        ''' FilterValue is only appended if it has a value
        ''' </summary>
        ''' <param name="ParentElement">The Parent Element</param>
        ''' <param name="filterTypeAttrubute">The FilterType value</param>
        ''' <param name="filterValueAttribute">The FilterValue value</param>
        ''' <remarks></remarks>
        Friend Shared Sub AppendAttributes(ByVal parentElement As Xml.XmlElement, ByVal filterTypeAttrubute As String, ByVal filterValueAttribute As String)

            parentElement.SetAttribute("FilterType", Common.SysproUtilities.GetEnumValue(filterTypeAttrubute))
            If filterValueAttribute <> "" Then
                parentElement.SetAttribute("FilterValue", filterValueAttribute)
            End If

        End Sub

        ''' <summary>
        ''' This method checks the strXMLOut for errors and if any are found it will throw a new SysproException detailing such errors
        ''' </summary>
        ''' <param name="strXMLIn">To be appended to the SysproException that is thrown</param>
        ''' <param name="strXMLParam">To be appended to the SysproException that is thrown</param>
        ''' <param name="strXMLOut">To be evaluated for errors and then be appended to the SysproException that is thrown</param>
        ''' <param name="strElementToFind">The element to be found that indicates what has been created in Syspro (like SalesOrder, PurchaseOrder or Journal)</param>
        ''' <remarks></remarks>
        Public Shared Function CheckXMLOut(ByVal strXMLIn As String, ByVal strXMLParam As String, ByVal strXMLOut As String, Optional ByVal strElementToFind As String = "") As String
            Dim xmlDoc As System.Xml.XmlDocument
            Dim xmlNodeList As System.Xml.XmlNodeList
            Dim xmlNode As System.Xml.XmlNode
            Dim strErrMsg As New System.Text.StringBuilder

            xmlDoc = New System.Xml.XmlDocument
            xmlDoc.LoadXml(strXMLOut)

            'Check return XML for errors by looking for any XML elements containing ErrorDescription
            If InStr(strXMLOut, "ErrorDescription") > 0 Then

                strErrMsg.Append("Syspro Error message(s):")

                'Load the returned XML error list
                xmlNodeList = xmlDoc.DocumentElement.SelectNodes("//ErrorDescription")
                For Each xmlNode In xmlNodeList
                    strErrMsg.Append(vbCrLf)
                    strErrMsg.Append(xmlNode.InnerText)
                Next xmlNode

                Throw New SysproException(strErrMsg.ToString, strXMLIn, strXMLParam, strXMLOut)
                'Return strErrMsg.ToString
            Else
                If strElementToFind = "" Then
                    Return "0"
                Else
                    xmlNode = xmlDoc.DocumentElement.SelectSingleNode("//" & strElementToFind)
                    If xmlNode Is Nothing Then
                        Return "0"
                    Else
                        Return xmlNode.InnerText
                    End If
                End If
            End If
        End Function

        Friend Shared Sub SortTheOrderLinesByCustomerPOLineNumber(ByRef doc As System.Xml.XmlDocument)
            'This method ensures that the order lines are sorted by CustomerPOLineNumber
            'It does this by taking out those xml elements pertaining to order lines and reinserting them in CustomerPOLineNumber order

            Dim ordersNodes As Xml.XmlNodeList = doc.SelectNodes("//Orders")

            For Each ordersNode As Xml.XmlNode In ordersNodes
                Dim orderDetailsNode As Xml.XmlNode = ordersNode.SelectSingleNode("//OrderDetails")
                Dim orderDetailsNodeClone As Xml.XmlNode = CType(orderDetailsNode, Xml.XmlElement).CloneNode(True)

                'Now orderDetailsNode will contain any number of StockLine, CommentLine, MiscChargeLine and FreightLine nodes
                'These will be grouped together by their respective type, ie, StockLines, then CommentLines, then MiscChargeLines, then FreightLines
                Dim lineNodes As Xml.XmlNodeList = orderDetailsNodeClone.ChildNodes

                'Get the minimum and maximum line numbers
                Dim minLineNumber, maxLineNumber As Integer
                minLineNumber = 1
                For i As Integer = 0 To lineNodes.Count - 1
                    Dim CustomerPoLine As Integer
                    Dim lineNode As System.Xml.XmlNode = lineNodes(i)

                    Try
                        CustomerPoLine = lineNode.Item("CustomerPoLine").InnerText
                    Catch ex As NullReferenceException
                        Throw New ApplicationException("Please specify a value for CustomerPoLine")
                    End Try
                    
                    If CustomerPoLine < minLineNumber Then
                        minLineNumber = CustomerPoLine
                    ElseIf CustomerPoLine > maxLineNumber Then
                        maxLineNumber = CustomerPoLine
                    End If
                Next i

                'Now clear the lineNodes
                orderDetailsNode.RemoveAll()

                'Now add back the lines nodes in CustomerPOLineNumber order
                Dim iNumberOfLines As Integer = lineNodes.Count
                For iLineNumber As Integer = minLineNumber To maxLineNumber
#If DEBUG Then
                    Debug.WriteLine("Processing iLineNumber " & iLineNumber & "...")
#End If
                    For Each lineNode As Xml.XmlNode In lineNodes

                        Select Case lineNode.LocalName
                            Case "StockLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is StockLine with CustomerPoLine " & lineNode.SelectSingleNode("//StockLine//CustomerPoLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//StockLine//CustomerPoLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//StockLine//CustomerPoLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    orderDetailsNode.AppendChild(lineNode)
                                End If
                            Case "CommentLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is CommentLine with CustomerPoLine " & lineNode.SelectSingleNode("//CommentLine//CustomerPoLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//CommentLine//CustomerPoLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//CommentLine//CustomerPoLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    orderDetailsNode.AppendChild(lineNode)
                                End If
                            Case "MiscChargeLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is StockLine with MiscChargeLine " & lineNode.SelectSingleNode("//MiscChargeLine//CustomerPoLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//MiscChargeLine//CustomerPoLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//MiscChargeLine//CustomerPoLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    orderDetailsNode.AppendChild(lineNode)
                                End If
                            Case "FreightLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is FreightLine with CustomerPoLine " & lineNode.SelectSingleNode("//FreightLine//CustomerPoLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//FreightLine//CustomerPoLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//FreightLine//CustomerPoLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    orderDetailsNode.AppendChild(lineNode)
                                End If
                            Case Else
                                Throw New ApplicationException("An unknown sales order line type node was encountered: " & lineNode.LocalName)
                        End Select
                    Next lineNode

                Next iLineNumber
            Next

        End Sub

        Friend Shared Sub SortTheQuoteLinesByQuotationLineNumber(ByRef doc As System.Xml.XmlDocument)
            'This method ensures that the quote lines are sorted by QuotationLine
            'It does this by taking out those xml elements pertaining to quote lines and reinserting them in QuotationLine quote

            Dim quotesNodes As Xml.XmlNodeList = doc.SelectNodes("//Item")

            For Each quotesNode As Xml.XmlNode In quotesNodes
                Dim quoteDetailsNode As Xml.XmlNode = quotesNode.SelectSingleNode("//QuotationDetails")
                Dim quoteDetailsNodeClone As Xml.XmlNode = CType(quoteDetailsNode, Xml.XmlElement).CloneNode(True)

                'Now quoteDetailsNode will contain any number of StockLine, CommentLine, MiscChargeLine and FreightLine nodes
                'These will be grouped together by their respective type, ie, StockLines, then CommentLines, then MiscChargeLines, then FreightLines
                Dim lineNodes As Xml.XmlNodeList = quoteDetailsNodeClone.ChildNodes

                'Get the minimum and maximum line numbers
                Dim minLineNumber, maxLineNumber As Integer
                minLineNumber = 1
                For i As Integer = 0 To lineNodes.Count - 1
                    Dim quotationLine As Integer
                    Dim lineNode As System.Xml.XmlNode = lineNodes(i)

                    quotationLine = lineNode.Item("QuotationLine").InnerText

                    If quotationLine < minLineNumber Then
                        minLineNumber = quotationLine
                    ElseIf quotationLine > maxLineNumber Then
                        maxLineNumber = quotationLine
                    End If
                Next i

                'Now clear the lineNodes
                quoteDetailsNode.RemoveAll()

                'Now add back the lines nodes in QuotationLineNumber quote
                Dim iNumberOfLines As Integer = lineNodes.Count
                For iLineNumber As Integer = minLineNumber To maxLineNumber
#If DEBUG Then
                    Debug.WriteLine("Processing iLineNumber " & iLineNumber & "...")
#End If
                    For Each lineNode As Xml.XmlNode In lineNodes

                        Select Case lineNode.LocalName
                            Case "StockLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is StockLine with QuotationLine " & lineNode.SelectSingleNode("//StockLine//QuotationLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//StockLine//QuotationLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//StockLine//QuotationLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    quoteDetailsNode.AppendChild(lineNode)
                                End If

                            Case "Non-stockedLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is Non-stockedLine with QuotationLine " & lineNode.SelectSingleNode("//Non-stockedLine//QuotationLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//Non-stockedLine//QuotationLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//Non-stockedLine//QuotationLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    quoteDetailsNode.AppendChild(lineNode)
                                End If


                            Case "CommentLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is CommentLine with QuotationLine " & lineNode.SelectSingleNode("//CommentLine//QuotationLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//CommentLine//QuotationLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//CommentLine//QuotationLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    quoteDetailsNode.AppendChild(lineNode)
                                End If
                            Case "MiscChargeLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is StockLine with MiscChargeLine " & lineNode.SelectSingleNode("//MiscChargeLine//QuotationLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//MiscChargeLine//QuotationLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//MiscChargeLine//QuotationLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    quoteDetailsNode.AppendChild(lineNode)
                                End If
                            Case "FreightLine"
#If DEBUG Then
                                Debug.WriteLine("   Case is FreightLine with QuotationLine " & lineNode.SelectSingleNode("//FreightLine//QuotationLine").InnerText)
#End If
                                If lineNode.SelectSingleNode("//FreightLine//QuotationLine").InnerText = iLineNumber OrElse lineNode.SelectSingleNode("//FreightLine//QuotationLine").InnerText = "" Then
#If DEBUG Then
                                    Debug.WriteLine("       Appending lineNode " & lineNode.OuterXml & vbCrLf & vbCrLf)
#End If
                                    quoteDetailsNode.AppendChild(lineNode)
                                End If
                            Case Else
                                Throw New ApplicationException("An unknown sales quote line type node was encountered: " & lineNode.LocalName)
                        End Select
                    Next lineNode

                Next iLineNumber
            Next

        End Sub

        Public Shared Function GetProcessedElement(ByVal strXMLToSearch As String, ByVal strXMLNodeToGet As String) As String
            Dim document As New System.Xml.XmlDocument()
            document.LoadXml(strXMLToSearch)
            Dim node As System.Xml.XmlNode = document.DocumentElement.SelectSingleNode(strXMLNodeToGet)
            If node Is Nothing Then
                Return "0"
            End If
            Return node.InnerText
        End Function

        Friend Shared Function SerializeToXMLString(ByVal oObjectToSerialize As Object) As String
            Dim doc As System.Xml.XmlDocument = SerializeToXMLDoc(oObjectToSerialize)
            Return doc.OuterXml
        End Function

        Friend Shared Function SerializeToXMLDoc(ByVal oObjectToSerialize As Object) As System.Xml.XmlDocument
            Dim ms As System.IO.MemoryStream
            Dim s As System.Xml.Serialization.XmlSerializer
            Dim tw As System.Xml.XmlTextWriter
            Dim doc As System.Xml.XmlDocument
            ms = New System.IO.MemoryStream
            s = New System.Xml.Serialization.XmlSerializer(oObjectToSerialize.GetType)
            tw = New System.Xml.XmlTextWriter(ms, Nothing)
            doc = New System.Xml.XmlDocument
            s.Serialize(tw, oObjectToSerialize)
            ms.Seek(0, 0)
            doc.Load(ms)
            Return doc
        End Function
    End Class
End Namespace
