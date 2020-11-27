Namespace QueryObjects.InvoiceQuery
    <Serializable()> Public Class TotalsSection

#Region " Private Variables "

        Private _DocumentNumber As String = "" '>100288</DocumentNumber> 
        Private _MySalesTaxDetails As SalesTaxDetailsSection
        Private _HashQuantity As String = "" '>7.000</HashQuantity> 
        Private _HashQuantityOrd As String = "" '>7.000</HashQuantityOrd> 
        Private _HashQuantityShip As String = "" '>7.000</HashQuantityShip> 
        Private _HashQuantityUnits As String = "" '>0.000</HashQuantityUnits> 
        Private _HashQuantityPieces As String = "" '>0.000</HashQuantityPieces> 
        Private _TotalMass As String = "" '>7.000</TotalMass> 
        Private _TotalVolume As String = "" '>0.000000</TotalVolume> 
        Private _TotalMassRounded As String = "" '>7</TotalMassRounded> 
        Private _TotalVolumeRounded As String = "" '>0</TotalVolumeRounded> 
        Private _TotalGrossAmount As String = "" '>1450.00</TotalGrossAmount> 
        Private _TotalNetAmount As String = "" '>1450.00</TotalNetAmount> 
        Private _TotalLineDiscount As String = "" '>0.00</TotalLineDiscount> 
        Private _TotalInvDiscountAmt As String = "" '>0.00</TotalInvDiscountAmt> 
        Private _DiscPct1 As String = "" '>0.00</DiscPct1> 
        Private _DiscPct2 As String = "" '>0.00</DiscPct2> 
        Private _DiscPct3 As String = "" '>0.00</DiscPct3> 
        Private _TotalNetAmtInclTax As String = "" '>1505.00</TotalNetAmtInclTax> 
        Private _TotalSalesTax As String = "" '>145.00</TotalSalesTax> 
        Private _TotalInvoiceAmount As String = "" '>1797.00</TotalInvoiceAmount> 
        Private _TotalInvAmtExclTax As String = "" '>1652.00</TotalInvAmtExclTax> 
        Private _TotalFreightAmount As String = "" '>200.00</TotalFreightAmount> 
        Private _TotalMiscChargesAmt As String = "" '>2.00</TotalMiscChargesAmt> 
        Private _TotalFreightTax As String = "" '>45.00</TotalFreightTax> 
        Private _TotalMiscChgTax As String = "" '>45.00</TotalMiscChgTax> 
        Private _TotalFrghtAmtIncTax As String = "" '>245.00</TotalFrghtAmtIncTax> 
        Private _TotalMiscChgIncTax As String = "" '>47.00</TotalMiscChgIncTax> 
        Private _CommentText1 As String = "" ' /> 
        Private _CommentText2 As String = "" ' /> 
        Private _CommentText3 As String = "" ' /> 
        Private _CommentText4 As String = "" ' /> 
        Private _TotalCashDiscount As String = "" '>36.25</TotalCashDiscount> 
        Private _TotalInvLessDisc As String = "" '>1760.75</TotalInvLessDisc> 
        Private _TotalCustRetail As String = "" '>0.00</TotalCustRetail> 
        Private _CashDiscExpDate As String = "" '>2006-07-07</CashDiscExpDate> 
        Private _InvoiceDueDate As String = "" '>2006-07-07</InvoiceDueDate> 

#End Region

#Region " Public Properties "

        Public Property DocumentNumber() As String
            Get
                Return _DocumentNumber
            End Get
            Set(ByVal Value As String)
                _DocumentNumber = Value
            End Set
        End Property
        Public Property MySalesTaxDetails() As SalesTaxDetailsSection
            Get
                Return _MySalesTaxDetails
            End Get
            Set(ByVal value As SalesTaxDetailsSection)
                _MySalesTaxDetails = value
            End Set
        End Property
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

        Public Shared Function NewFromDS(ByVal ds As DataSet) As TotalsSection

            Dim ts As New TotalsSection

            Dim rootTable As DataTable = ds.Tables("Totals")
            Dim rootRow As DataRow = rootTable.Rows(0)

            With ts
                .DocumentNumber = rootRow.Item("DocumentNumber").ToString
                .HashQuantity = rootRow.Item("HashQuantity").ToString
                .HashQuantityOrd = rootRow.Item("HashQuantityOrd").ToString
                .HashQuantityShip = rootRow.Item("HashQuantityShip").ToString
                .HashQuantityUnits = rootRow.Item("HashQuantityUnits").ToString
                .HashQuantityPieces = rootRow.Item("HashQuantityPieces").ToString
                .TotalMass = rootRow.Item("TotalMass").ToString
                .TotalVolume = rootRow.Item("TotalVolume").ToString
                .TotalMassRounded = rootRow.Item("TotalMassRounded").ToString
                .TotalVolumeRounded = rootRow.Item("TotalVolumeRounded").ToString
                .TotalGrossAmount = rootRow.Item("TotalGrossAmount").ToString
                .TotalNetAmount = rootRow.Item("TotalNetAmount").ToString
                .TotalLineDiscount = rootRow.Item("TotalLineDiscount").ToString
                .TotalInvDiscountAmt = rootRow.Item("TotalInvDiscountAmt").ToString
                .DiscPct1 = rootRow.Item("DiscPct1").ToString
                .DiscPct2 = rootRow.Item("DiscPct2").ToString
                .DiscPct3 = rootRow.Item("DiscPct3").ToString
                .TotalNetAmtInclTax = rootRow.Item("TotalNetAmtInclTax").ToString
                .TotalSalesTax = rootRow.Item("TotalSalesTax").ToString
                .TotalInvoiceAmount = rootRow.Item("TotalInvoiceAmount").ToString
                .TotalInvAmtExclTax = rootRow.Item("TotalInvAmtExclTax").ToString
                .TotalFreightAmount = rootRow.Item("TotalFreightAmount").ToString
                .TotalMiscChargesAmt = rootRow.Item("TotalMiscChargesAmt").ToString
                .TotalFreightTax = rootRow.Item("TotalFreightTax").ToString
                .TotalMiscChgTax = rootRow.Item("TotalMiscChgTax").ToString
                .TotalFrghtAmtIncTax = rootRow.Item("TotalFrghtAmtIncTax").ToString
                .TotalMiscChgIncTax = rootRow.Item("TotalMiscChgIncTax").ToString
                .CommentText1 = rootRow.Item("CommentText1").ToString
                .CommentText2 = rootRow.Item("CommentText2").ToString
                .CommentText3 = rootRow.Item("CommentText3").ToString
                .CommentText4 = rootRow.Item("CommentText4").ToString
                .TotalCashDiscount = rootRow.Item("TotalCashDiscount").ToString
                .TotalInvLessDisc = rootRow.Item("TotalInvLessDisc").ToString
                .TotalCustRetail = rootRow.Item("TotalCustRetail").ToString
                .CashDiscExpDate = rootRow.Item("CashDiscExpDate").ToString
                .InvoiceDueDate = rootRow.Item("InvoiceDueDate").ToString
            End With

            ts.MySalesTaxDetails = SalesTaxDetailsSection.NewFromDS(ds)

            Return ts

        End Function
    End Class
End Namespace
