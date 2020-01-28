Public Class test
    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim reply As MsgBoxResult

        reply = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reply = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub SignUpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem1.Click
        If SignUpToolStripMenuItem.Text = "Sign Up" Then

            staffRegister.MdiParent = Me
            'set the child window/form to the center of the parent
            staffRegister.StartPosition = FormStartPosition.CenterScreen
            staffRegister.Show() 'show the Login form
        ElseIf SignUpToolStripMenuItem.Text = "Sign Out" Then
            'when sign out is clicked, it will also disable all
            ' the view menuitems item
            Enable_DisableViewMenu(False)

            'closes all open MDI child form before signing out
            'using the for loop
            For Each childFrm In Me.MdiChildren
                childFrm.Close()
            Next
            'change the display text of the signout to sign in
            SignUpToolStripMenuItem.Text = "Sign Up"
        End If

    End Sub
    Public Sub Enable_DisableViewMenu(ByVal flag As Boolean)
        TableToolStripMenuItem.Enabled = flag

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enable_DisableViewMenu(False)
        'show the toolstrip on the right
        StatusStrip1.RightToLeft = Windows.Forms.RightToLeft.Yes
        'disable the text to display from left to right
        ToolStripStatusLabel1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongTimeString

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        tableStaff.MdiParent = Me
        tableStaff.Show()

    End Sub
End Class