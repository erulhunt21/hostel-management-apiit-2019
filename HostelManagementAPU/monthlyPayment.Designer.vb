<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthlyPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(monthlyPayment))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblOccupyDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbHold = New System.Windows.Forms.GroupBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.cboRinggit = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblDates = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.lblUnitRent = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHold.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources._exit
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Location = New System.Drawing.Point(613, 12)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 40)
        Me.btnExit.TabIndex = 48
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.HostelManagementAPU.My.Resources.Resources.Webp_net_resizeimage__3_
        Me.picLogo.Location = New System.Drawing.Point(267, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 150)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 47
        Me.picLogo.TabStop = False
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(12, 12)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(143, 20)
        Me.lblStatement.TabIndex = 46
        Me.lblStatement.Text = "current log in as "
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(15, 44)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(57, 20)
        Me.lblAdmin.TabIndex = 45
        Me.lblAdmin.Text = "Label1"
        '
        'lblOccupyDate
        '
        Me.lblOccupyDate.AutoSize = True
        Me.lblOccupyDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupyDate.Location = New System.Drawing.Point(336, 166)
        Me.lblOccupyDate.Name = "lblOccupyDate"
        Me.lblOccupyDate.Size = New System.Drawing.Size(162, 20)
        Me.lblOccupyDate.TabIndex = 3
        Me.lblOccupyDate.Text = "New Booking Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(340, 220)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2018, 11, 13, 0, 0, 0, 0)
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(35, 152)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(95, 20)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Unit Type :"
        '
        'lblRent
        '
        Me.lblRent.AutoSize = True
        Me.lblRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRent.Location = New System.Drawing.Point(35, 242)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(170, 20)
        Me.lblRent.TabIndex = 5
        Me.lblRent.Text = "Unit Rent ( Ringgit):"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(336, 43)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 20)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status :"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.HostelManagementAPU.My.Resources.Resources.back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Location = New System.Drawing.Point(555, 12)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 40)
        Me.btnBack.TabIndex = 49
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbHold
        '
        Me.gbHold.Controls.Add(Me.btnVerify)
        Me.gbHold.Controls.Add(Me.lblDate)
        Me.gbHold.Controls.Add(Me.cboStatus)
        Me.gbHold.Controls.Add(Me.lblUnit)
        Me.gbHold.Controls.Add(Me.lblStudent)
        Me.gbHold.Controls.Add(Me.cboRinggit)
        Me.gbHold.Controls.Add(Me.cboType)
        Me.gbHold.Controls.Add(Me.lblOccupyDate)
        Me.gbHold.Controls.Add(Me.lblDates)
        Me.gbHold.Controls.Add(Me.btnConfirm)
        Me.gbHold.Controls.Add(Me.lblID)
        Me.gbHold.Controls.Add(Me.lblUnitID)
        Me.gbHold.Controls.Add(Me.DateTimePicker1)
        Me.gbHold.Controls.Add(Me.lblType)
        Me.gbHold.Controls.Add(Me.lblStatus)
        Me.gbHold.Controls.Add(Me.lblRent)
        Me.gbHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHold.Location = New System.Drawing.Point(19, 164)
        Me.gbHold.Name = "gbHold"
        Me.gbHold.Size = New System.Drawing.Size(644, 435)
        Me.gbHold.TabIndex = 43
        Me.gbHold.TabStop = False
        Me.gbHold.Text = "Monthly Renew Booking"
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(228, 376)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(194, 50)
        Me.btnVerify.TabIndex = 52
        Me.btnVerify.Text = "Verify Details"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(427, 132)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(63, 20)
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "Label9"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Occupied"})
        Me.cboStatus.Location = New System.Drawing.Point(431, 35)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 28)
        Me.cboStatus.TabIndex = 50
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(191, 97)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(63, 20)
        Me.lblUnit.TabIndex = 49
        Me.lblUnit.Text = "Label9"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(191, 43)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(63, 20)
        Me.lblStudent.TabIndex = 48
        Me.lblStudent.Text = "Label3"
        '
        'cboRinggit
        '
        Me.cboRinggit.FormattingEnabled = True
        Me.cboRinggit.Items.AddRange(New Object() {"350", "500"})
        Me.cboRinggit.Location = New System.Drawing.Point(122, 276)
        Me.cboRinggit.Name = "cboRinggit"
        Me.cboRinggit.Size = New System.Drawing.Size(132, 28)
        Me.cboRinggit.TabIndex = 47
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"Single", "Double"})
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Single", "Double"})
        Me.cboType.Location = New System.Drawing.Point(122, 175)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(132, 28)
        Me.cboType.TabIndex = 46
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDates.Location = New System.Drawing.Point(336, 97)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Size = New System.Drawing.Size(196, 20)
        Me.lblDates.TabIndex = 42
        Me.lblDates.Text = "Previous Booking Date:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(442, 376)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(196, 50)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "Proceed Booking"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(35, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(107, 20)
        Me.lblID.TabIndex = 39
        Me.lblID.Text = "Student ID :"
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitID.Location = New System.Drawing.Point(35, 97)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(76, 20)
        Me.lblUnitID.TabIndex = 29
        Me.lblUnitID.Text = "Unit ID :"
        '
        'lblUnitRent
        '
        Me.lblUnitRent.AutoSize = True
        Me.lblUnitRent.Location = New System.Drawing.Point(481, 384)
        Me.lblUnitRent.Name = "lblUnitRent"
        Me.lblUnitRent.Size = New System.Drawing.Size(0, 13)
        Me.lblUnitRent.TabIndex = 42
        '
        'monthlyPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbHold)
        Me.Controls.Add(Me.lblUnitRent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "monthlyPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "monthlyPayment"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHold.ResumeLayout(False)
        Me.gbHold.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblStatement As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblOccupyDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblType As Label
    Friend WithEvents lblRent As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents gbHold As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblUnitID As Label
    Friend WithEvents lblUnitRent As Label
    Friend WithEvents lblDates As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents cboRinggit As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnVerify As Button
End Class
