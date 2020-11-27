Imports System
Imports System.Data

Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> Public Class DispatchInvoiceLineCollection
        Inherits System.Collections.Generic.List(Of IDispatchInvoiceLine)

        Public Shared Function NewFromDS(ByVal ds As DataSet) As DispatchInvoiceLineCollection

            Dim col As New DispatchInvoiceLineCollection
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

                    'TODO: This was initially done for Schneider, who does not use Lots and serials...hence these are commented out for quicker delivery
                    ''Add Lots that may be linked to the line
                    'merchLine.AddLotsFromDS(ds)

                    ''Add Serials that may be linked to the line
                    'merchLine.AddSerialsFromDS(ds)

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

            Dim sortedCol As New DispatchInvoiceLineCollection

            For i As Integer = 1 To maxLineFound
                For Each line As IDispatchInvoiceLine In col
                    If CType(line.LineNumber, Integer) = i Then
                        sortedCol.Add(line)
                        Exit For
                    End If
                Next
            Next
            'Now add those lines that don't have a line number
            For Each line As IDispatchInvoiceLine In col
                If CType(line.LineNumber, Integer) = 0 Then
                    sortedCol.Add(line)
                End If
            Next

            'If sortedCol.Count <> col.Count Then
            '    Throw New Exception("Something went wrong in the sorting of the dispatch invoice lines. Col has " & col.Count & " lines.  SortedCol has " & sortedCol.Count & " lines!")
            'End If

            Return sortedCol
        End Function

    End Class
End Namespace
