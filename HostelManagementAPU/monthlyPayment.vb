Public Class monthlyPayment
    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim dbprovider As String    'define version
    Dim dbsource As String  'name access file

    Dim cmd As OleDb.OleDbCommand
    Dim drr, dr As OleDb.OleDbDataReader

    Dim mcd As OleDb.OleDbCommand

    Dim ds As New DataSet 'bookingHostel
    Dim da As OleDb.OleDbDataAdapter 'bookingHostel
    Dim sql As String 'bookingHostel

    Dim dss As New DataSet 'savePayment
    Dim daa As OleDb.OleDbDataAdapter 'savePayment
    Dim sqlPay As String 'savePayment

    Dim stdSearch As String ' try con chechk registered StudentID in payment
    Dim indexP As Integer
    Dim index As Integer 'read all ID and Fname student row
    Dim maxSearch As Integer
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Index <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewrow As DataRow
            dsNewrow = ds.Tables("bookingHostel").NewRow


            dsNewrow.Item("studentID") = lblStudent.Text
            dsNewrow.Item("unitID") = lblUnit.Text
            dsNewrow.Item("occupyDate") = DateTimePicker1.Value.ToString
            dsNewrow.Item("unitType") = cboType.SelectedItem
            dsNewrow.Item("unitRent") = cboRinggit.SelectedItem
            dsNewrow.Item("status") = cboStatus.SelectedItem
            ds.Tables("bookingHostel").Rows.Add(dsNewrow)
            da.Update(ds, "bookingHostel")

            MsgBox("User Updated , Proceed to Payment", MsgBoxStyle.Information, "Added")

        End If


        If indexP <> -1 Then
            Dim ccbb As New OleDb.OleDbCommandBuilder(daa)
            Dim dssNewRow As DataRow
            dssNewRow = dss.Tables("savePayment").NewRow

            dssNewRow.Item("studentID") = lblStudent.Text
            dssNewRow.Item("unitID") = lblUnit.Text
            dssNewRow.Item("amountDue") = cboRinggit.Text
            dssNewRow.Item("dateEntry") = DateTimePicker1.Value.ToString
            dssNewRow.Item("loggedBy") = lblAdmin.Text
            dss.Tables("savePayment").Rows.Add(dssNewRow)
            daa.Update(dss, "savePayment")
            MsgBox("Details Successfully", MsgBoxStyle.Information, "Added")



        End If


        payment.Show()
        Me.Close()

    End Sub
    Private Sub NavigateRecords()

        DateTimePicker1 = ds.Tables("bookingHostel").Rows(index).Item(2)
        cboType.SelectedItem = ds.Tables("bookingHostel").Rows(index).Item(3)
        cboRinggit.Text = ds.Tables("bookingHostel").Rows(index).Item(4)
        cboStatus.SelectedItem = ds.Tables("bookingHostel").Rows(index).Item(5)
        lblStudent.Text = ds.Tables("bookingHostel").Rows(index).Item(5)
    End Sub
    Private Sub Paymentload()
        lblUnit.Text = dss.Tables("savePayment").Rows(indexP).Item(2) 'unit ID
        DateTimePicker1 = dss.Tables("savePayment").Rows(indexP).Item(3)    ' dateEntry
        cboRinggit.SelectedItem = dss.Tables("savePayment").Rows(indexP).Item(6) 'amount due
        lblStudent.Text = dss.Tables("savePayment").Rows(indexP).Item(1) 'student ID
    End Sub


    Function check() As Boolean

        Dim status As Boolean = False
        If cboType.Text = "" Then
            MsgBox("Choose a Unit Type", MsgBoxStyle.Information)

        ElseIf cboRinggit.Text = "" Then
            MsgBox("Choose a Unit Rent", MsgBoxStyle.Information)

        ElseIf cboType.Text = "Single" And cboRinggit.Text = "500" Then
            MsgBox("Wrong Unit Type & Unit Rent", MsgBoxStyle.Information)

        ElseIf cboType.Text = "Double" And cboRinggit.Text = "350" Then
            MsgBox("Wrong Unit Type & Unit Rent", MsgBoxStyle.Information)

        ElseIf cboStatus.Text = "" Then
            MsgBox("Please Update Status", MsgBoxStyle.Information)

        End If

        Return status

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        If check() = True Then
        Else
            btnConfirm.Enabled = True
            MsgBox("Details Complete", MsgBoxStyle.OkOnly, "Please Proceed Booking ")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        mainMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        login.Show()
        login.txtUser.Clear()
        login.txtPwd.Clear()
    End Sub

    Private Sub monthlyPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Book Accomodation"
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()

        sql = "Select * FROM hostel "
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bookingHostel")



        sqlPay = "Select * FROM payment"
        daa = New OleDb.OleDbDataAdapter(sqlPay, con)
        daa.Fill(dss, "savePayment")

        con.Close()

        maxSearch = ds.Tables("bookingHostel").Rows.Count

        btnVerify.Enabled = True
        btnConfirm.Enabled = False


    End Sub

    Private Sub lblUnitID_Click(sender As Object, e As EventArgs) Handles lblUnitID.Click

    End Sub
End Class