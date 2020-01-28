<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 102)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 150)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Student Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(460, 102)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(200, 150)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources.booking
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.Image = Global.HostelManagementAPU.My.Resources.Resources.booking
        Me.btnBook.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBook.Location = New System.Drawing.Point(23, 347)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBook.Size = New System.Drawing.Size(200, 150)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Book Hostel"
        Me.btnBook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(460, 347)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 150)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Report"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(166, 23)
        Me.lblAdmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(57, 20)
        Me.lblAdmin.TabIndex = 7
        Me.lblAdmin.Text = "Label1"
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(19, 21)
        Me.lblStatement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(129, 20)
        Me.lblStatement.TabIndex = 34
        Me.lblStatement.Text = "current log in as "
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources._exit
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Location = New System.Drawing.Point(616, 14)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 53)
        Me.btnExit.TabIndex = 6
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(238, 347)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 150)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Student Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(238, 102)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 150)
        Me.Button7.TabIndex = 36
        Me.Button7.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblStatement As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
End Class
