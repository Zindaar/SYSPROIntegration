Imports System.Data
Namespace SalesOrdersPrimaryQuery.DispatchInvoiceQuery.QueryData.Output
    <Serializable()> _
    Public Class DispatchInvoiceTotalSection

#Region " Fields "
        Private _HashQuantity As String = ""
        Private _HashQuantityOrd As String = ""
        Private _HashQuantityShip As String = ""
        Private _HashQuantityUnits As String = ""
        Private _HashQuantityPieces As String = ""
        Private _TotalMass As String = ""
        Private _TotalVolume As String = ""
        Private _TotalMassRounded As String = ""
        Private _TotalVolumeRounded As String = ""
        Private _TotalGrossAmount As String = ""
        Private _TotalNetAmount As String = ""
        Private _TotalLineDiscount As String = ""
        Private _TotalInvDiscountAmt As String = ""
        Private _DiscPct1 As String = ""
        Private _DiscPct2 As String = ""
        Private _DiscPct3 As String = ""
        Private _TotalNetAmtInclTax As String = ""
        Private _TotalSalesTax As String = ""
        Private _TotalInvoiceAmount As String = ""
        Private _TotalInvAmtExclTax As String = ""
        Private _TotalFreightAmount As String = ""
        Private _TotalMiscChargesAmt As String = ""
        Private _TotalFreightTax As String = ""
        Private _TotalMiscChgTax As String = ""
        Private _TotalFrghtAmtIncTax As String = ""
        Private _TotalMiscChgIncTax As String = ""
        Private _TotalTaxBeforeRounding As String = ""
        Private _TotalInvBeforeRounding As String = ""
        Private _TaxRoundingValue As String = ""
        Private _InvoiceRoundingValue As String = ""
        Private _TotalRoundingValue As String = ""
        Private _CommentText1 As String = ""
        Private _CommentText2 As String = ""
        Private _CommentText3 As String = ""
        Private _CommentText4 As String = ""
        Private _TotalCashDiscount As String = ""
        Private _TotalInvLessDisc As String = ""
        Private _TotalCustRetail As String = ""
        Private _CashDiscExpDate As String = ""
        Private _InvoiceDueDate As String = ""

#End Region

#Region " Properties "
        Public Property HashQuantity() As String
            Get
                Return _HashQuantity
            End Get
            Set(ByVal Value As String)
                _HashQuantity = Value
            End Set
        End Property
        Public Property HashQuantityOrd() As String
            Get
                Return _HashQuantityOrd
            End Get
            Set(ByVal Value As String)
                _HashQuantityOrd = Value
            End Set
        End Property
        Public Property HashQuantityShip() As String
            Get
                Return _HashQuantityShip
            End Get
            Set(ByVal Value As String)
                _HashQuantityShip = Value
            End Set
        End Property
        Public Property HashQuantityUnits() As String
            Get
                Return _HashQuantityUnits
            End Get
            Set(ByVal Value As String)
                _HashQuantityUnits = Value
            End Set
        End Property
        Public Property HashQuantityPieces() As String
            Get
                Return _HashQuantityPieces
            End Get
            Set(ByVal Value As String)
                _HashQuantityPieces = Value
            End Set
        End Property
        Public Property TotalMass() As String
            Get
                Return _TotalMass
            End Get
            Set(ByVal Value As String)
                _TotalMass = Value
            End Set
        End Property
        Public Property TotalVolume() As String
            Get
                Return _TotalVolume
            End Get
            Set(ByVal Value As String)
                _TotalVolume = Value
            End Set
        End Property
        Public Property TotalMassRounded() As String
            Get
                Return _TotalMassRounded
            End Get
            Set(ByVal Value As String)
                _TotalMassRounded = Value
            End Set
        End Property
        Public Property TotalVolumeRounded() As String
            Get
                Return _TotalVolumeRounded
            End Get
            Set(ByVal Value As String)
                _TotalVolumeRounded = Value
            End Set
        End Property
        Public Property TotalGrossAmount() As String
            Get
                Return _TotalGrossAmount
            End Get
            Set(ByVal Value As String)
                _TotalGrossAmount = Value
            End Set
        End Property
        Public Property TotalNetAmount() As String
            Get
                Return _TotalNetAmount
            End Get
            Set(ByVal Value As String)
                _TotalNetAmount = Value
            End Set
        End Property
        Public Property TotalLineDiscount() As String
            Get
                Return _TotalLineDiscount
            End Get
            Set(ByVal Value As String)
                _TotalLineDiscount = Value
            End Set
        End Property
        Public Property TotalInvDiscountAmt() As String
            Get
                Return _TotalInvDiscountAmt
            End Get
            Set(ByVal Value As String)
                _TotalInvDiscountAmt = Value
            End Set
        End Property
        Public Property DiscPct1() As String
            Get
                Return _DiscPct1
            End Get
            Set(ByVal Value As String)
                _DiscPct1 = Value
            End Set
        End Property
        Public Property DiscPct2() As String
            Get
                Return _DiscPct2
            End Get
            Set(ByVal Value As String)
                _DiscPct2 = Value
            End Set
        End Property
        Public Property DiscPct3() As String
            Get
                Return _DiscPct3
            End Get
            Set(ByVal Value As String)
                _DiscPct3 = Value
            End Set
        End Property
        Public Property TotalNetAmtInclTax() As String
            Get
                Return _TotalNetAmtInclTax
            End Get
            Set(ByVal Value As String)
                _TotalNetAmtInclTax = Value
            End Set
        End Property
        Public Property TotalSalesTax() As String
            Get
                Return _TotalSalesTax
            End Get
            Set(ByVal Value As String)
                _TotalSalesTax = Value
            End Set
        End Property
        Public Property TotalInvoiceAmount() As String
            Get
                Return _TotalInvoiceAmount
            End Get
            Set(ByVal Value As String)
                _TotalInvoiceAmount = Value
            End Set
        End Property
        Public Property TotalInvAmtExclTax() As String
            Get
                Return _TotalInvAmtExclTax
            End Get
            Set(ByVal Value As String)
                _TotalInvAmtExclTax = Value
            End Set
        End Property
        Public Property TotalFreightAmount() As String
            Get
                Return _TotalFreightAmount
            End Get
            Set(ByVal Value As String)
                _TotalFreightAmount = Value
            End Set
        End Property
        Public Property TotalMiscChargesAmt() As String
            Get
                Return _TotalMiscChargesAmt
            End Get
            Set(ByVal Value As String)
                _TotalMiscChargesAmt = Value
            End Set
        End Property
        Public Property TotalFreightTax() As String
            Get
                Return _TotalFreightTax
            End Get
            Set(ByVal Value As String)
                _TotalFreightTax = Value
            End Set
        End Property
        Public Property TotalMiscChgTax() As String
            Get
                Return _TotalMiscChgTax
            End Get
            Set(ByVal Value As String)
                _TotalMiscChgTax = Value
            End Set
        End Property
        Public Property TotalFrghtAmtIncTax() As String
            Get
                Return _TotalFrghtAmtIncTax
            End Get
            Set(ByVal Value As String)
                _TotalFrghtAmtIncTax = Value
            End Set
        End Property
        Public Property TotalMiscChgIncTax() As String
            Get
                Return _TotalMiscChgIncTax
            End Get
            Set(ByVal Value As String)
                _TotalMiscChgIncTax = Value
            End Set
        End Property
        Public Property TotalTaxBeforeRounding() As String
            Get
                Return _TotalTaxBeforeRounding
            End Get
            Set(ByVal Value As String)
                _TotalTaxBeforeRounding = Value
            End Set
        End Property
        Public Property TotalInvBeforeRounding() As String
            Get
                Return _TotalInvBeforeRounding
            End Get
            Set(ByVal Value As String)
                _TotalInvBeforeRounding = Value
            End Set
        End Property
        Public Property TaxRoundingValue() As String
            Get
                Return _TaxRoundingValue
            End Get
            Set(ByVal Value As String)
                _TaxRoundingValue = Value
            End Set
        End Property
        Public Property InvoiceRoundingValue() As String
            Get
                Return _InvoiceRoundingValue
            End Get
            Set(ByVal Value As String)
                _InvoiceRoundingValue = Value
            End Set
        End Property
        Public Property TotalRoundingValue() As String
            Get
                Return _TotalRoundingValue
            End Get
            Set(ByVal Value As String)
                _TotalRoundingValue = Value
            End Set
        End Property
        Public Property CommentText1() As String
            Get
                Return _CommentText1
            End Get
            Set(ByVal Value As String)
                _CommentText1 = Value
            End Set
        End Property
        Public Property CommentText2() As String
            Get
                Return _CommentText2
            End Get
            Set(ByVal Value As String)
                _CommentText2 = Value
            End Set
        End Property
        Public Property CommentText3() As String
            Get
                Return _CommentText3
            End Get
            Set(ByVal Value As String)
                _CommentText3 = Value
            End Set
        End Property
        Public Property CommentText4() As String
            Get
                Return _CommentText4
            End Get
            Set(ByVal Value As String)
                _CommentText4 = Value
            End Set
        End Property
        Public Property TotalCashDiscount() As String
            Get
                Return _TotalCashDiscount
            End Get
            Set(ByVal Value As String)
                _TotalCashDiscount = Value
            End Set
        End Property
        Public Property TotalInvLessDisc() As String
            Get
                Return _TotalInvLessDisc
            End Get
            Set(ByVal Value As String)
                _TotalInvLessDisc = Value
            End Set
        End Property
        Public Property TotalCustRetail() As String
            Get
                Return _TotalCustRetail
            End Get
            Set(ByVal Value As String)
                _TotalCustRetail = Value
            End Set
        End Property
        Public Property CashDiscExpDate() As String
            Get
                Return _CashDiscExpDate
            End Get
            Set(ByVal Value As String)
                _CashDiscExpDate = Value
            End Set
        End Property
        Public Property InvoiceDueDate() As String
            Get
                Return _InvoiceDueDate
            End Get
            Set(ByVal Value As String)
                _InvoiceDueDate = Value
            End Set
        End Property

#End Region

#Region " Instantiation "

        Public Shared Function NewFromDS(ByVal ds As DataSet) As DispatchInvoiceTotalSection

            Dim dh As New Header

            Dim rootTable As DataTable = ds.Tables("Totals")
            Dim rootRow As DataRow = rootTable.Rows(0)

            Dim totalSection As New DispatchInvoiceTotalSection

            With totalSection
                Try : .HashQuantity = rootRow.Item("HashQuantity").ToString : Catch ex As ArgumentException : End Try
                Try : .HashQuantityOrd = rootRow.Item("HashQuantityOrd").ToString : Catch ex As ArgumentException : End Try
                Try : .HashQuantityShip = rootRow.Item("HashQuantityShip").ToString : Catch ex As ArgumentException : End Try
                Try : .HashQuantityUnits = rootRow.Item("HashQuantityUnits").ToString : Catch ex As ArgumentException : End Try
                Try : .HashQuantityPieces = rootRow.Item("HashQuantityPieces").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalMass = rootRow.Item("TotalMass").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalVolume = rootRow.Item("TotalVolume").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalMassRounded = rootRow.Item("TotalMassRounded").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalVolumeRounded = rootRow.Item("TotalVolumeRounded").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalGrossAmount = rootRow.Item("TotalGrossAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalNetAmount = rootRow.Item("TotalNetAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalLineDiscount = rootRow.Item("TotalLineDiscount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalInvDiscountAmt = rootRow.Item("TotalInvDiscountAmt").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct1 = rootRow.Item("DiscPct1").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct2 = rootRow.Item("DiscPct2").ToString : Catch ex As ArgumentException : End Try
                Try : .DiscPct3 = rootRow.Item("DiscPct3").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalNetAmtInclTax = rootRow.Item("TotalNetAmtInclTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalSalesTax = rootRow.Item("TotalSalesTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalInvoiceAmount = rootRow.Item("TotalInvoiceAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalInvAmtExclTax = rootRow.Item("TotalInvAmtExclTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalFreightAmount = rootRow.Item("TotalFreightAmount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalMiscChargesAmt = rootRow.Item("TotalMiscChargesAmt").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalFreightTax = rootRow.Item("TotalFreightTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalMiscChgTax = rootRow.Item("TotalMiscChgTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalFrghtAmtIncTax = rootRow.Item("TotalFrghtAmtIncTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalMiscChgIncTax = rootRow.Item("TotalMiscChgIncTax").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalTaxBeforeRounding = rootRow.Item("TotalTaxBeforeRounding").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalInvBeforeRounding = rootRow.Item("TotalInvBeforeRounding").ToString : Catch ex As ArgumentException : End Try
                Try : .TaxRoundingValue = rootRow.Item("TaxRoundingValue").ToString : Catch ex As ArgumentException : End Try
                Try : .InvoiceRoundingValue = rootRow.Item("InvoiceRoundingValue").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalRoundingValue = rootRow.Item("TotalRoundingValue").ToString : Catch ex As ArgumentException : End Try
                Try : .CommentText1 = rootRow.Item("CommentText1").ToString : Catch ex As ArgumentException : End Try
                Try : .CommentText2 = rootRow.Item("CommentText2").ToString : Catch ex As ArgumentException : End Try
                Try : .CommentText3 = rootRow.Item("CommentText3").ToString : Catch ex As ArgumentException : End Try
                Try : .CommentText4 = rootRow.Item("CommentText4").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalCashDiscount = rootRow.Item("TotalCashDiscount").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalInvLessDisc = rootRow.Item("TotalInvLessDisc").ToString : Catch ex As ArgumentException : End Try
                Try : .TotalCustRetail = rootRow.Item("TotalCustRetail").ToString : Catch ex As ArgumentException : End Try
                Try : .CashDiscExpDate = rootRow.Item("CashDiscExpDate").ToString : Catch ex As ArgumentException : End Try
                Try : .InvoiceDueDate = rootRow.Item("InvoiceDueDate").ToString : Catch ex As ArgumentException : End Try

            End With

            Return totalSection
        End Function
#End Region

    End Class
End Namespace
