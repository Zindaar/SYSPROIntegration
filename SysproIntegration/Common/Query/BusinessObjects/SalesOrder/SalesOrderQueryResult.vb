Imports System.IO
Namespace QueryObjects
    <Serializable()> Public Class SalesOrderQueryResult

        Public Function SalesOrderQueryResult(ByVal xmlOut As String) As DataSet

            Dim resultDataSet As DataSet
            Dim writer As StreamWriter = New StreamWriter("myXML.xml")

            resultDataSet = New DataSet

            '**Create xml file, so that it can be set as the datasource
            writer.WriteLine(xmlOut)
            writer.Close()

            resultDataSet.ReadXml("myXML.xml")
            resultDataSet = New DataSet

            resultDataSet.ReadXml(xmlOut)
            Return resultDataSet

        End Function

    End Class

End Namespace
