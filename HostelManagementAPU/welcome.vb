Public Class welcome
    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim dbprovider As String    'define version
    Dim dbsource As String  'name access file

    Dim dt As New DataSet 'adminStaff
    Dim dtr As OleDb.OleDbDataAdapter ''adminStaff
    Dim sqls As String 'adminStaff

    Dim idx As Integer
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Book Accomodation"
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        MsgBox("success")
        sqls = "Select * FROM credentials"
        dtr = New OleDb.OleDbDataAdapter(sqls, con)
        dtr.Fill(dt, "savePayment")

        con.Close()
        MsgBox("end")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainMenu.Show()
        Me.Show()

    End Sub
    Private Sub registerData()

        txtUsername.Text = dt.Tables("bookStaff").Rows(idx).Item(1)
        txtPassword.Text = dt.Tables("bookStaff").Rows(idx).Item(2)
        cbxRole.SelectedItem = dt.Tables("bookStaff").Rows(idx).Item(3)
        txtFname.Text = dt.Tables("bookStaff").Rows(idx).Item(4)
        txtLname.Text = dt.Tables("bookStaff").Rows(idx).Item(5)
        'txtContact.Text = dt.Tables("bookStaff").Rows(idx).Item(6)
        ' txtEmail.Text = dt.Tables("bookStaff").Rows(idx).Item(7)

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If idx <> -1 Then

            Dim ccb As New OleDb.OleDbCommandBuilder(dtr)
            Dim dsNewrow As DataRow
            dsNewrow = dt.Tables("bookStaff").NewRow


            dsNewrow.Item("username") = txtUsername.Text
            dsNewrow.Item("password") = txtPassword.Text
            dsNewrow.Item("role") = cbxRole.SelectedItem
            dsNewrow.Item("firstname") = txtFname.Text
            dsNewrow.Item("lastname") = txtLname.Text
            '   dsrNewrow.Item("contactNumb") = txtContact.Text
            '  dsrNewrow.Item("email") = txtEmail.Text

            dt.Tables("bookStaff").Rows.Add(dsNewrow)
            dtr.Update(dt, "bookStaff")

            MsgBox("User added , Please Proceed To Payment", MsgBoxStyle.Information, "Added")

        End If
    End Sub
End Class
