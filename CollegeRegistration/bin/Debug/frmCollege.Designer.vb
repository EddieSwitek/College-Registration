<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollege
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.TextBox()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.txtStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.radCraigHall = New System.Windows.Forms.RadioButton()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollegeRegistration.My.Resources.Resources.college
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(272, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 78)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Register for Classes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Bedford College"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.Location = New System.Drawing.Point(49, 183)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(91, 19)
        Me.lblStudentId.TabIndex = 2
        Me.lblStudentId.Text = "Student ID:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(49, 227)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(115, 19)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(49, 274)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(132, 19)
        Me.lblUnits.TabIndex = 4
        Me.lblUnits.Text = "Number of Units:"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(403, 310)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(55, 19)
        Me.lblMajor.TabIndex = 5
        Me.lblMajor.Text = "Major:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(330, 554)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(108, 19)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "XXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(165, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(142, 35)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Costs"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(464, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(187, 229)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(371, 27)
        Me.txtStudentName.TabIndex = 2
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(187, 276)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(27, 27)
        Me.txtNumberOfUnits.TabIndex = 3
        '
        'cboMajor
        '
        Me.cboMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Items.AddRange(New Object() {"App Development", "Biology", "Business", "Chemistry", "Programming", "Liberal Arts", "Mathematics", "Physics", "Sociology", "Technology Education"})
        Me.cboMajor.Location = New System.Drawing.Point(464, 312)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(196, 27)
        Me.cboMajor.TabIndex = 4
        Me.cboMajor.Text = "Select a Major"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOnCampus)
        Me.GroupBox1.Controls.Add(Me.radOffCampus)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 83)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Location = New System.Drawing.Point(6, 48)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(111, 23)
        Me.radOnCampus.TabIndex = 6
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Location = New System.Drawing.Point(6, 26)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(112, 23)
        Me.radOffCampus.TabIndex = 5
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(187, 180)
        Me.txtStudentID.Mask = "000-00-0000"
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(120, 27)
        Me.txtStudentID.TabIndex = 1
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.radJulianSuites)
        Me.grpHousingBoard.Controls.Add(Me.radCraigHall)
        Me.grpHousingBoard.Controls.Add(Me.radCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.Location = New System.Drawing.Point(187, 363)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(200, 100)
        Me.grpHousingBoard.TabIndex = 16
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing/Board"
        Me.grpHousingBoard.Visible = False
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Location = New System.Drawing.Point(7, 20)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(123, 23)
        Me.radCooperDorm.TabIndex = 0
        Me.radCooperDorm.TabStop = True
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'radCraigHall
        '
        Me.radCraigHall.AutoSize = True
        Me.radCraigHall.Location = New System.Drawing.Point(7, 44)
        Me.radCraigHall.Name = "radCraigHall"
        Me.radCraigHall.Size = New System.Drawing.Size(96, 23)
        Me.radCraigHall.TabIndex = 1
        Me.radCraigHall.TabStop = True
        Me.radCraigHall.Text = "Craig Hall"
        Me.radCraigHall.UseVisualStyleBackColor = True
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Location = New System.Drawing.Point(7, 67)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(115, 23)
        Me.radJulianSuites.TabIndex = 2
        Me.radJulianSuites.TabStop = True
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'frmCollege
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 604)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCollege"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College Registration Costs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtNumberOfUnits As TextBox
    Friend WithEvents cboMajor As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOnCampus As RadioButton
    Friend WithEvents radOffCampus As RadioButton
    Friend WithEvents txtStudentID As MaskedTextBox
    Friend WithEvents grpHousingBoard As GroupBox
    Friend WithEvents radJulianSuites As RadioButton
    Friend WithEvents radCraigHall As RadioButton
    Friend WithEvents radCooperDorm As RadioButton
End Class
