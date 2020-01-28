Imports System.Data.OleDb
Imports System.Data
Public Class staffRegister

    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim dbprovider As String    'define version
    Dim dbsource As String  'name access file

    Dim dr As OleDb.OleDbDataReader
    Dim cmd As OleDb.OleDbCommand
    Dim sql As String

    Dim dss As New DataSet '
    Dim daa As OleDb.OleDbDataAdapter

    Dim intel As Integer





    Private Sub staffRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Register Staff"

        dbprovider = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
        dbsource = "Data Source = vbHostel.mdb"
        con.ConnectionString = dbprovider & dbsource


        con.Open()
        'MsgBox(" connection open-load")

        sql = "Select * From credentials"
        daa = New OleDb.OleDbDataAdapter(sql, con)
        daa.Fill(dss, "staffManage") 'fill dataset from Table credentials




        con.Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        'If chkStaff() = True Then
        'MsgBox("Updating Data in Adminstration", MsgBoxStyle.Information, "new staff")
        'End If

        If intel <> -1 Then

            Dim cmdb As New OleDb.OleDbCommandBuilder(daa)
            Dim ddsNewrow As DataRow
            ddsNewrow = dss.Tables("staffManage").NewRow



            ddsNewrow.Item("username") = txtUsername.Text
            ddsNewrow.Item("password") = txtPassword.Text
            ddsNewrow.Item("role") = cbxRole.SelectedItem
            ddsNewrow.Item("firstname") = txtFname.Text
            ddsNewrow.Item("lastname") = txtLname.Text
            ' ddsNewrow.Item("contactNumb") = txtContact.Text
            'ddsNewrow.Item("email") = txtEmail.Text


            dss.Tables("staffManage").Rows.Add(ddsNewrow)
            daa.Update(dss, "staffManage")

            MsgBox("User added , Please Proceed To Payment", MsgBoxStyle.Information, "Added")


        End If

    End Sub


    Private Sub registerData()

        txtUsername.Text = dss.Tables("bookStaff").Rows(intel).Item(1)
        txtPassword.Text = dss.Tables("bookStaff").Rows(intel).Item(2)
        cbxRole.SelectedItem = dss.Tables("bookStaff").Rows(intel).Item(3)
        txtFname.Text = dss.Tables("bookStaff").Rows(intel).Item(4)
        txtLname.Text = dss.Tables("bookStaff").Rows(intel).Item(5)
        txtContact.Text = dss.Tables("bookStaff").Rows(intel).Item(6)
        txtEmail.Text = dss.Tables("bookStaff").Rows(intel).Item(7)

    End Sub

End Class