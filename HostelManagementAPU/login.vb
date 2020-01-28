Imports System.Data
Imports System.Data.OleDb
Public Class login

    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim sql As String
    Public Shared strRole As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;PROVIDER = Microsoft.JET.OLEDB.4.0;= vbHostel.mdb" ' a shared variable to all forms

    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim dbprovider As String    'define version
    Dim dbsource As String  'name access file

    Dim ds As New DataSet 'bookingHostel

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Welcome to APU hostel management system v2018"
        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource

        con.Open()
        ' MsgBox("connection success")

        sql = "Select * From credentials WHERE Username='" & txtUser.Text & "' AND Password='" & txtPwd.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con) 'take input
        da.Fill(ds, "login") 'fill dataset from Table Hostel
        con.Close()
        'MsgBox(" connection close")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource

        ' set up data set command object
        sql = "Select * From credentials WHERE Username='" & txtUser.Text & "' AND Password='" & txtPwd.Text & "'"
        con.Open()


        '
        If txtUser.Text = "" Or txtPwd.Text = "" Then
            'check for empty fields
            MessageBox.Show("User ID or password cannot be empty", "Incomplete Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            cmd = New OleDbCommand(sql, con) 'set the command object
            dr = cmd.ExecuteReader ' execute the reader
            dr.Read() 'reads the data
            If dr.HasRows = True Then


                'set the display position & show the welcome window

                mainMenu.lblAdmin.Text = dr.Item("FirstName") & " " & dr.Item("LastName")
                mainMenu.StartPosition = FormStartPosition.CenterScreen
                mainMenu.Show()

                staffRegister.lblAdmin.Text = dr.Item("FirstName") & " " & dr.Item("LastName")
                bookSearch.lblAdmin.Text = dr.Item("FirstName") & " " & dr.Item("LastName")
                hostelBook.lblAdmin.Text = dr.Item("FirstName") & " " & dr.Item("LastName")
                monthlyPayment.lblAdmin.Text = dr.Item("FirstName") & " " & dr.Item("LastName")
                'reads the role for the user
                strRole = dr.Item("Role")

                'check the role and enable only accesible menu items for that role: Admin
                If strRole.Equals("manager") Then
                    mainMenu.Button6.Enabled = True
                ElseIf strRole.Equals("staff") Then
                    mainMenu.Button6.Enabled = False

                End If

                ' 'close the login window
            Else
                MessageBox.Show("Incorrect username or password. Please retry.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUser.Focus()
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()

    End Sub


End Class