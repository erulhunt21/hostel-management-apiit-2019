<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookSearch))
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.gbStd = New System.Windows.Forms.GroupBox()
        Me.txtFirstn = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtNumb = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtstudentID = New System.Windows.Forms.TextBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtSearchstudentID = New System.Windows.Forms.TextBox()
        Me.labelID = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pboxLogo = New System.Windows.Forms.PictureBox()
        Me.gbStd.SuspendLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Location = New System.Drawing.Point(442, 187)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(129, 52)
        Me.btnSearchBook.TabIndex = 15
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(239, 73)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(176, 26)
        Me.txtCode.TabIndex = 22
        '
        'gbStd
        '
        Me.gbStd.Controls.Add(Me.txtFirstn)
        Me.gbStd.Controls.Add(Me.txtLastname)
        Me.gbStd.Controls.Add(Me.txtNumb)
        Me.gbStd.Controls.Add(Me.txtEmail)
        Me.gbStd.Controls.Add(Me.txtstudentID)
        Me.gbStd.Controls.Add(Me.btnProceed)
        Me.gbStd.Controls.Add(Me.lblCode)
        Me.gbStd.Controls.Add(Me.lblStd)
        Me.gbStd.Controls.Add(Me.txtCode)
        Me.gbStd.Controls.Add(Me.lblF)
        Me.gbStd.Controls.Add(Me.lblL)
        Me.gbStd.Controls.Add(Me.lblEmail)
        Me.gbStd.Controls.Add(Me.lblContact)
        Me.gbStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStd.Location = New System.Drawing.Point(12, 262)
        Me.gbStd.Name = "gbStd"
        Me.gbStd.Size = New System.Drawing.Size(645, 317)
        Me.gbStd.TabIndex = 34
        Me.gbStd.TabStop = False
        Me.gbStd.Text = "Student Preview Details"
        '
        'txtFirstn
        '
        Me.txtFirstn.Location = New System.Drawing.Point(239, 154)
        Me.txtFirstn.Name = "txtFirstn"
        Me.txtFirstn.Size = New System.Drawing.Size(176, 26)
        Me.txtFirstn.TabIndex = 33
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(239, 204)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(176, 26)
        Me.txtLastname.TabIndex = 32
        '
        'txtNumb
        '
        Me.txtNumb.Location = New System.Drawing.Point(239, 256)
        Me.txtNumb.Name = "txtNumb"
        Me.txtNumb.Size = New System.Drawing.Size(176, 26)
        Me.txtNumb.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(239, 109)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 26)
        Me.txtEmail.TabIndex = 30
        '
        'txtstudentID
        '
        Me.txtstudentID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtstudentID.Location = New System.Drawing.Point(239, 32)
        Me.txtstudentID.Name = "txtstudentID"
        Me.txtstudentID.Size = New System.Drawing.Size(176, 26)
        Me.txtstudentID.TabIndex = 28
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(440, 122)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(137, 55)
        Me.btnProceed.TabIndex = 26
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(54, 79)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(112, 20)
        Me.lblCode.TabIndex = 17
        Me.lblCode.Text = "Intake Code:"
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStd.Location = New System.Drawing.Point(59, 38)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(107, 20)
        Me.lblStd.TabIndex = 27
        Me.lblStd.Text = "Student ID :"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(61, 160)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(106, 20)
        Me.lblF.TabIndex = 11
        Me.lblF.Text = "First Name :"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.Location = New System.Drawing.Point(61, 210)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(105, 20)
        Me.lblL.TabIndex = 16
        Me.lblL.Text = "Last Name :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(103, 122)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 20)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email :"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(17, 256)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(149, 20)
        Me.lblContact.TabIndex = 18
        Me.lblContact.Text = "Contact Number :"
        '
        'txtSearchstudentID
        '
        Me.txtSearchstudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchstudentID.Location = New System.Drawing.Point(251, 204)
        Me.txtSearchstudentID.Name = "txtSearchstudentID"
        Me.txtSearchstudentID.Size = New System.Drawing.Size(150, 26)
        Me.txtSearchstudentID.TabIndex = 31
        Me.txtSearchstudentID.Text = "TP"
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelID.Location = New System.Drawing.Point(58, 204)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(159, 20)
        Me.labelID.TabIndex = 30
        Me.labelID.Text = "Search Student ID"
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(12, 9)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(143, 20)
        Me.lblStatement.TabIndex = 36
        Me.lblStatement.Text = "current log in as "
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(12, 29)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(57, 20)
        Me.lblAdmin.TabIndex = 35
        Me.lblAdmin.Text = "Label2"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources.back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Location = New System.Drawing.Point(563, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 40)
        Me.btnBack.TabIndex = 39
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources._exit
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Location = New System.Drawing.Point(621, 14)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 40)
        Me.btnExit.TabIndex = 38
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pboxLogo
        '
        Me.pboxLogo.Image = Global.HostelManagementAPU.My.Resources.Resources.Webp_net_resizeimage__3_
        Me.pboxLogo.Location = New System.Drawing.Point(260, 13)
        Me.pboxLogo.Name = "pboxLogo"
        Me.pboxLogo.Size = New System.Drawing.Size(150, 150)
        Me.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pboxLogo.TabIndex = 37
        Me.pboxLogo.TabStop = False
        '
        'bookSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pboxLogo)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.gbStd)
        Me.Controls.Add(Me.txtSearchstudentID)
        Me.Controls.Add(Me.labelID)
        Me.Controls.Add(Me.btnSearchBook)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bookSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bookSearch"
        Me.gbStd.ResumeLayout(False)
        Me.gbStd.PerformLayout()
        CType(Me.pboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchBook As Button
    Friend WithEvents txtCode As TextBox
    Friend WithEvents gbStd As GroupBox
    Friend WithEvents txtstudentID As TextBox
    Friend WithEvents btnProceed As Button
    Friend WithEvents lblCode As Label
    Friend WithEvents lblStd As Label
    Friend WithEvents lblF As Label
    Friend WithEvents lblL As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents txtSearchstudentID As TextBox
    Friend WithEvents labelID As Label
    Friend WithEvents txtFirstn As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtNumb As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pboxLogo As PictureBox
    Friend WithEvents lblStatement As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
End Class
