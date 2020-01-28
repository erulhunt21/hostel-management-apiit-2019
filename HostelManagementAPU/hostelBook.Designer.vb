<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hostelBook
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
        Dim lblType As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hostelBook))
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.lblOccupyDate = New System.Windows.Forms.Label()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtUnitID = New System.Windows.Forms.TextBox()
        Me.lblUnitRent = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboxUnittype = New System.Windows.Forms.ComboBox()
        Me.txtstudentID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.txtFirstn = New System.Windows.Forms.TextBox()
        Me.gbVerify = New System.Windows.Forms.GroupBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.cboxUnitrent = New System.Windows.Forms.ComboBox()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.gbxBook = New System.Windows.Forms.GroupBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        lblType = New System.Windows.Forms.Label()
        Me.gbVerify.SuspendLayout()
        Me.gbxBook.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitID.Location = New System.Drawing.Point(6, 35)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(66, 20)
        Me.lblUnitID.TabIndex = 2
        Me.lblUnitID.Text = "Unit ID"
        '
        'lblOccupyDate
        '
        Me.lblOccupyDate.AutoSize = True
        Me.lblOccupyDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupyDate.Location = New System.Drawing.Point(6, 77)
        Me.lblOccupyDate.Name = "lblOccupyDate"
        Me.lblOccupyDate.Size = New System.Drawing.Size(136, 20)
        Me.lblOccupyDate.TabIndex = 3
        Me.lblOccupyDate.Text = "Occupying Date"
        '
        'lblType
        '
        lblType.AutoSize = True
        lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblType.Location = New System.Drawing.Point(241, 35)
        lblType.Name = "lblType"
        lblType.Size = New System.Drawing.Size(85, 20)
        lblType.TabIndex = 4
        lblType.Text = "Unit Type"
        '
        'lblRent
        '
        Me.lblRent.AutoSize = True
        Me.lblRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRent.Location = New System.Drawing.Point(241, 77)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(165, 20)
        Me.lblRent.TabIndex = 5
        Me.lblRent.Text = "Unit Rent ( Ringgit)"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(241, 133)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 20)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status"
        '
        'txtUnitID
        '
        Me.txtUnitID.Enabled = False
        Me.txtUnitID.Location = New System.Drawing.Point(98, 37)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.Size = New System.Drawing.Size(100, 26)
        Me.txtUnitID.TabIndex = 11
        '
        'lblUnitRent
        '
        Me.lblUnitRent.AutoSize = True
        Me.lblUnitRent.Location = New System.Drawing.Point(489, 363)
        Me.lblUnitRent.Name = "lblUnitRent"
        Me.lblUnitRent.Size = New System.Drawing.Size(0, 13)
        Me.lblUnitRent.TabIndex = 15
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(249, 198)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(146, 50)
        Me.btnBook.TabIndex = 17
        Me.btnBook.Text = "Book Now"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2018, 11, 13, 0, 0, 0, 0)
        '
        'cboxUnittype
        '
        Me.cboxUnittype.FormattingEnabled = True
        Me.cboxUnittype.Items.AddRange(New Object() {"Single", "Double"})
        Me.cboxUnittype.Location = New System.Drawing.Point(438, 37)
        Me.cboxUnittype.Name = "cboxUnittype"
        Me.cboxUnittype.Size = New System.Drawing.Size(120, 28)
        Me.cboxUnittype.TabIndex = 20
        '
        'txtstudentID
        '
        Me.txtstudentID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtstudentID.Location = New System.Drawing.Point(183, 43)
        Me.txtstudentID.Name = "txtstudentID"
        Me.txtstudentID.Size = New System.Drawing.Size(200, 26)
        Me.txtstudentID.TabIndex = 40
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(61, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(107, 20)
        Me.lblID.TabIndex = 39
        Me.lblID.Text = "Student ID :"
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStd.Location = New System.Drawing.Point(62, 75)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(106, 20)
        Me.lblStd.TabIndex = 29
        Me.lblStd.Text = "First Name :"
        '
        'txtFirstn
        '
        Me.txtFirstn.Location = New System.Drawing.Point(183, 75)
        Me.txtFirstn.Name = "txtFirstn"
        Me.txtFirstn.Size = New System.Drawing.Size(200, 26)
        Me.txtFirstn.TabIndex = 34
        '
        'gbVerify
        '
        Me.gbVerify.Controls.Add(Me.btnConfirm)
        Me.gbVerify.Controls.Add(Me.txtstudentID)
        Me.gbVerify.Controls.Add(Me.lblID)
        Me.gbVerify.Controls.Add(Me.lblStd)
        Me.gbVerify.Controls.Add(Me.txtFirstn)
        Me.gbVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVerify.Location = New System.Drawing.Point(51, 143)
        Me.gbVerify.Name = "gbVerify"
        Me.gbVerify.Size = New System.Drawing.Size(590, 176)
        Me.gbVerify.TabIndex = 26
        Me.gbVerify.TabStop = False
        Me.gbVerify.Text = "Student Details"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(183, 117)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(196, 50)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "Proceed Booking"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(403, 198)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(146, 50)
        Me.btnPayment.TabIndex = 28
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'cboxUnitrent
        '
        Me.cboxUnitrent.FormattingEnabled = True
        Me.cboxUnitrent.Items.AddRange(New Object() {"1050", "1500"})
        Me.cboxUnitrent.Location = New System.Drawing.Point(438, 77)
        Me.cboxUnitrent.Name = "cboxUnitrent"
        Me.cboxUnitrent.Size = New System.Drawing.Size(120, 28)
        Me.cboxUnitrent.TabIndex = 29
        '
        'cboxStatus
        '
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Items.AddRange(New Object() {"Available", "Occupied"})
        Me.cboxStatus.Location = New System.Drawing.Point(438, 125)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(120, 28)
        Me.cboxStatus.TabIndex = 30
        '
        'gbxBook
        '
        Me.gbxBook.Controls.Add(Me.lblOccupyDate)
        Me.gbxBook.Controls.Add(Me.cboxStatus)
        Me.gbxBook.Controls.Add(Me.lblUnitID)
        Me.gbxBook.Controls.Add(Me.btnBook)
        Me.gbxBook.Controls.Add(Me.btnPayment)
        Me.gbxBook.Controls.Add(Me.cboxUnitrent)
        Me.gbxBook.Controls.Add(Me.txtUnitID)
        Me.gbxBook.Controls.Add(Me.DateTimePicker1)
        Me.gbxBook.Controls.Add(Me.cboxUnittype)
        Me.gbxBook.Controls.Add(lblType)
        Me.gbxBook.Controls.Add(Me.lblRent)
        Me.gbxBook.Controls.Add(Me.lblStatus)
        Me.gbxBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBook.Location = New System.Drawing.Point(51, 338)
        Me.gbxBook.Name = "gbxBook"
        Me.gbxBook.Size = New System.Drawing.Size(590, 252)
        Me.gbxBook.TabIndex = 31
        Me.gbxBook.TabStop = False
        Me.gbxBook.Text = "Booking Details"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(34, 58)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(57, 20)
        Me.lblAdmin.TabIndex = 32
        Me.lblAdmin.Text = "Label1"
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(23, 22)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(143, 20)
        Me.lblStatement.TabIndex = 33
        Me.lblStatement.Text = "current log in as "
        '
        'picLogo
        '
        Me.picLogo.Image = Global.HostelManagementAPU.My.Resources.Resources.Webp_net_resizeimage__3_
        Me.picLogo.Location = New System.Drawing.Point(277, 1)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 150)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 34
        Me.picLogo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources.back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Location = New System.Drawing.Point(563, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 40)
        Me.btnBack.TabIndex = 41
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
        Me.btnExit.TabIndex = 40
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'hostelBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.gbxBook)
        Me.Controls.Add(Me.gbVerify)
        Me.Controls.Add(Me.lblUnitRent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "hostelBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "hostelBook"
        Me.gbVerify.ResumeLayout(False)
        Me.gbVerify.PerformLayout()
        Me.gbxBook.ResumeLayout(False)
        Me.gbxBook.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnitID As Label
    Friend WithEvents lblOccupyDate As Label
    Friend WithEvents lblRent As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents lblUnitRent As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cboxUnittype As ComboBox
    Friend WithEvents txtstudentID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblStd As Label
    Friend WithEvents txtFirstn As TextBox
    Friend WithEvents gbVerify As GroupBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents cboxUnitrent As ComboBox
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbxBook As GroupBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblStatement As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
End Class
