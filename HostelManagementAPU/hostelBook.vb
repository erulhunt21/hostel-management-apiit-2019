Imports System.Data.OleDb
Public Class hostelBook
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

    Private Sub hostelBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        btnConfirm.Enabled = True
        btnPayment.Enabled = False
        btnBook.Enabled = False





    End Sub
    Private Sub NavigateRecords()

        DateTimePicker1 = ds.Tables("bookingHostel").Rows(index).Item(2)
        cboxUnittype.SelectedItem = ds.Tables("bookingHostel").Rows(index).Item(3)
        cboxUnitrent.Text = ds.Tables("bookingHostel").Rows(index).Item(4)
        cboxStatus.SelectedItem = ds.Tables("bookingHostel").Rows(index).Item(5)
    End Sub
    Private Sub Paymentload()
        txtUnitID.Text = dss.Tables("savePayment").Rows(indexP).Item(1)
        DateTimePicker1 = dss.Tables("savePayment").Rows(indexP).Item(3)
        cboxUnitrent.SelectedItem = dss.Tables("savePayment").Rows(indexP).Item(6)
        txtstudentID.Text = dss.Tables("savePayment").Rows(indexP).Item(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBook.Click


        If check() = True Then
        Else
            btnPayment.Enabled = True
            MsgBox("Details Updated", MsgBoxStyle.OkOnly, "Please Click Button Payment")
        End If



    End Sub
    Function check() As Boolean

        Dim status As Boolean = False
        If txtUnitID.Text = "" Then
            MsgBox("Please Click Proceed Button", MsgBoxStyle.Information)

        ElseIf cboxUnittype.Text = "" Then
            MsgBox("Choose a Unit Type", MsgBoxStyle.Information)

        ElseIf cboxUnitrent.Text = "" Then
            MsgBox("Choose a Unit Rent", MsgBoxStyle.Information)

        ElseIf cboxUnittype.Text = "Single" And cboxUnitrent.Text = "1500" Then
            MsgBox("Wrong Unit Type & Unit Rent", MsgBoxStyle.Information)

        ElseIf cboxUnittype.Text = "Double" And cboxUnitrent.Text = "1050" Then
            MsgBox("Wrong Unit Type & Unit Rent", MsgBoxStyle.Information)

        ElseIf cboxStatus.Text = "" Then
            MsgBox("Please Update Status", MsgBoxStyle.Information)

        End If

        Return status

    End Function



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click
        If index <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewrow As DataRow
            dsNewrow = ds.Tables("bookingHostel").NewRow


            dsNewrow.Item("studentID") = txtstudentID.Text
            dsNewrow.Item("unitID") = txtUnitID.Text
            dsNewrow.Item("occupyDate") = DateTimePicker1.Value.ToString
            dsNewrow.Item("unitType") = cboxUnittype.SelectedItem
            dsNewrow.Item("unitRent") = cboxUnitrent.SelectedItem
            dsNewrow.Item("status") = cboxStatus.SelectedItem
            ds.Tables("bookingHostel").Rows.Add(dsNewrow)
            da.Update(ds, "bookingHostel")

            MsgBox("User added , Please Proceed To Payment", MsgBoxStyle.Information, "Added")

        End If


        If indexP <> -1 Then
            Dim ccbb As New OleDb.OleDbCommandBuilder(daa)
            Dim dssNewRow As DataRow
            dssNewRow = dss.Tables("savePayment").NewRow

            dssNewRow.Item("studentID") = txtstudentID.Text
            dssNewRow.Item("unitID") = txtUnitID.Text
            dssNewRow.Item("amountDue") = cboxUnitrent.Text
            dssNewRow.Item("dateEntry") = DateTimePicker1.Value.ToString
            dssNewRow.Item("loggedBy") = lblAdmin.Text
            dss.Tables("savePayment").Rows.Add(dssNewRow)
            daa.Update(dss, "savePayment")
            MsgBox("Details Successfully", MsgBoxStyle.Information, "Added")


            If check() = True Then
                Me.Close()
                payment.Show()

            End If

        End If



    End Sub

    Private Sub unit()
        txtUnitID.Text = ds.Tables("bookingHostel").Rows(index).Item(0)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        'MsgBox(" connection open-")
        'Dim priceRent As String

        sql = "Select * FROM hostel WHERE [studentID] ='" & stdSearch & "'"
        cmd = New OleDbCommand(sql, con)
        drr = cmd.ExecuteReader
        drr.Read()

        If drr.HasRows = True Then

            'set the display position & show the welcome window

            monthlyPayment.lblStudent.Text = drr.Item("studentID")
            monthlyPayment.lblUnit.Text = drr.Item("unitID")
            monthlyPayment.cboType.Text = drr.Item("unitType")
            monthlyPayment.cboRinggit.Text = drr.Item("unitRent")
            monthlyPayment.cboStatus.Text = drr.Item("status")
            monthlyPayment.lblDate.Text = drr.Item("occupyDate")


            MsgBox("student details already assign Unit ID, Monthly Payment")
            monthlyPayment.Show()
            Me.Close()



        Else

            MsgBox("Rental in advance 2 month will be charge")
            'success
        End If


        drr.Close()
        con.Close()
        txtUnitID.Text = maxSearch + 1
        btnConfirm.Enabled = False
        btnBook.Enabled = True
        btnPayment.Enabled = False




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        mainMenu.Show()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        login.Show()
        login.txtUser.Clear()
        login.txtPwd.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        mainMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtstudentID_TextChanged(sender As Object, e As EventArgs) Handles txtstudentID.TextChanged
        stdSearch = txtstudentID.Text
    End Sub
End Class