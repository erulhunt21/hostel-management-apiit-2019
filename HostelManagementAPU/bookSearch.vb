Imports System.Data.OleDb
Imports System.Data

Public Class bookSearch



    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim dr As OleDb.OleDbDataReader
    Dim cmd As OleDb.OleDbCommand

    Dim dbprovider As String    'define version
    Dim dbsource As String  'name access file
    Dim dss As New DataSet 'profileStudent
    Dim daa As OleDb.OleDbDataAdapter




    Dim searchID, searchName, sql, readID As String


    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        'MsgBox(" connection open-")

        sql = "Select * FROM students WHERE [studentID] ='" & searchID & "'"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()



        If dr.HasRows = True Then

            txtstudentID.Text = dr.Item("studentID")
            txtCode.Text = dr.Item("intakeCode")
            txtFirstn.Text = dr.Item("firstName")
            txtLastname.Text = dr.Item("lastName")
            txtNumb.Text = dr.Item("contactNumber")
            txtEmail.Text = dr.Item("email")

        Else
            MessageBox.Show("No record of student found in database ", "Hostel Management Booking Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
        txtSearchstudentID.Focus()
        dr.Close()
        con.Close()
        btnProceed.Enabled = True
        ' MsgBox(" connection close")

    End Sub

    Private Sub bookSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Search Student for Assign New Hostel Booking"

        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource


        con.Open()
        'MsgBox(" connection open-load")

        sql = "Select * From students"
        daa = New OleDb.OleDbDataAdapter(sql, con)
        daa.Fill(dss, "studentProfile") 'fill dataset from Table students




        con.Close()
        'MsgBox(" connection close-load")



        AcceptButton = btnSearchBook
        txtSearchstudentID.Focus()
        Enable_Disable(True)
        btnProceed.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        login.Show()
        login.txtUser.Clear()
        login.txtPwd.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        lblAdmin.Text = mainMenu.Label1.Text


        Me.Close()
        mainMenu.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pboxLogo.Click
        Me.Close()
        mainMenu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        ' MsgBox(" connection open-")

        sql = "Select * FROM students WHERE [studentID] ='" & searchID & "'"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()

        hostelBook.Show()





        'set the display position & show the welcome window

        hostelBook.txtstudentID.Text = dr.Item("studentID")
        hostelBook.txtFirstn.Text = dr.Item("firstName")

    End Sub


    Sub Enable_Disable(ByVal flag As Boolean)

        txtstudentID.ReadOnly = flag
        txtFirstn.ReadOnly = flag
        txtLastname.ReadOnly = flag
        txtNumb.ReadOnly = flag
        txtEmail.ReadOnly = flag
        txtCode.ReadOnly = flag

    End Sub


    Private Sub txtSearchstudentID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchstudentID.TextChanged
        searchID = txtSearchstudentID.Text
    End Sub



End Class