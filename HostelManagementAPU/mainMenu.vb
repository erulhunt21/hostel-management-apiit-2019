Public Class mainMenu


    Dim con As New OleDb.OleDbConnection  'connect access database
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim sql As String
    Public Property id As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        bookSearch.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        staffRegister.Show()


    End Sub


    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PaleTurquoise
        Me.ForeColor = Color.Navy
        Me.Text = "Main Menu Apu Hostel Management System"




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        login.Show()
        login.txtUser.Clear()
        login.txtPwd.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class