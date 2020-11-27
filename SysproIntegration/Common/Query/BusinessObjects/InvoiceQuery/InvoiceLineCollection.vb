Imports System
Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class InvoiceLineCollection
        Inherits System.Collections.Generic.List(Of IInvoiceLine)


        Public Shared Function NewFromDS(ByVal ds As DataSet) As InvoiceLineCollection

            Dim col As New InvoiceLineCollection
            Dim maxLineFound As Integer = 1

            'Check for existence of Merchandise lines (in case the invoice is only for Freight or Misc
            If ds.Tables.Contains("Merchandise") Then
                For Each merchRow As DataRow In ds.Tables("Merchandise").Rows
                    Dim merchLine As MerchandiseLine = MerchandiseLine.NewFromDataRow(merchRow)
                    If merchLine.LineNumber > maxLineFound Then
                        maxLineFound = merchLine.LineNumber
                    End If

                    'Add Bins that may be linked to the line
                    merchLine.AddBinsFromDS(ds)

                    'Add Lots that may be linked to the line
                    merchLine.AddLotsFromDS(ds)

                    'Add Serials that may be linked to the line
                    merchLine.AddSerialsFromDS(ds)

                    col.Add(merchLine)
                Next merchRow
            End If

            If ds.Tables.Contains("Freight") Then
                For Each frtRow As DataRow In ds.Tables("Freight").Rows
                    Dim frtLine As FreightLine = FreightLine.NewFromDataRow(frtRow)
                    If frtLine.LineNumber > maxLineFound Then
                        maxLineFound = frtLine.LineNumber
                    End If
                    col.Add(frtLine)
                Next frtRow
            End If

            If ds.Tables.Contains("MiscCharge") Then
                For Each miscRow As DataRow In ds.Tables("MiscCharge").Rows
                    Dim miscLine As MiscChargeLine = MiscChargeLine.NewFromDataRow(miscRow)
                    If miscLine.LineNumber > maxLineFound Then
                        maxLineFound = miscLine.LineNumber
                    End If
                    col.Add(miscLine)
                Next miscRow
            End If

            If ds.Tables.Contains("Comment") Then
                For Each cmtRow As DataRow In ds.Tables("Comment").Rows
                    Dim cmtLine As CommentLine = CommentLine.NewFromDataRow(cmtRow)
                    If cmtLine.LineNumber > maxLineFound Then
                        maxLineFound = cmtLine.LineNumber
                    End If
                    col.Add(cmtLine)
                Next cmtRow
            End If

            Dim sortedCol As New InvoiceLineCollection

            For i As Integer = 1 To maxLineFound
                For Each line As IInvoiceLine In col
                    If CType(line.LineNumber, Integer) = i Then
                        sortedCol.Add(line)
                        Exit For
                    End If
                Next
            Next

            If sortedCol.Count <> col.Count Then
                Throw New Exception("Something went wrong in the sorting of the invoice lines. Col has " & col.Count & " lines.  SortedCol has " & sortedCol.Count & " lines!")
            End If

            Return sortedCol
        End Function

    End Class
End Namespace
