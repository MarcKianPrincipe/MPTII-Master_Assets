<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(userForm))
        Panel1 = New Panel()
        pictureAccount = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        dgAssets = New DataGridView()
        Panel3 = New Panel()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        pbDesktop = New PictureBox()
        pbLaptop = New PictureBox()
        pbTotal = New PictureBox()
        pbActive = New PictureBox()
        pbInactive = New PictureBox()
        pbDispose = New PictureBox()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel4 = New Panel()
        pbClearButton = New PictureBox()
        Panel7 = New Panel()
        lblDesktopNumber = New Label()
        PictureBox5 = New PictureBox()
        Panel5 = New Panel()
        lblLaptopNumber = New Label()
        PictureBox3 = New PictureBox()
        Panel6 = New Panel()
        lblTotalNumber = New Label()
        PictureBox6 = New PictureBox()
        Panel8 = New Panel()
        lblActiveNumber = New Label()
        PictureBox8 = New PictureBox()
        Panel9 = New Panel()
        lblInactiveNumber = New Label()
        PictureBox10 = New PictureBox()
        Panel10 = New Panel()
        lblDisposeNumber = New Label()
        PictureBox12 = New PictureBox()
        Panel1.SuspendLayout()
        CType(pictureAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgAssets, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(pbDesktop, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbLaptop, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTotal, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbActive, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbInactive, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDispose, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(pbClearButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(pictureAccount)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1506, 92)
        Panel1.TabIndex = 3
        ' 
        ' pictureAccount
        ' 
        pictureAccount.Image = CType(resources.GetObject("pictureAccount.Image"), Image)
        pictureAccount.Location = New Point(1423, 26)
        pictureAccount.Name = "pictureAccount"
        pictureAccount.Size = New Size(41, 45)
        pictureAccount.SizeMode = PictureBoxSizeMode.Zoom
        pictureAccount.TabIndex = 1
        pictureAccount.TabStop = False
        ToolTip1.SetToolTip(pictureAccount, "Logout")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-33, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(321, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(dgAssets)
        Panel2.Location = New Point(26, 170)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1449, 746)
        Panel2.TabIndex = 4
        ' 
        ' dgAssets
        ' 
        dgAssets.BackgroundColor = Color.White
        dgAssets.GridColor = SystemColors.ControlDarkDark
        dgAssets.Location = New Point(17, 17)
        dgAssets.Name = "dgAssets"
        dgAssets.ReadOnly = True
        dgAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgAssets.RowTemplate.Height = 25
        dgAssets.Size = New Size(1416, 714)
        dgAssets.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(-1, 922)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1506, 41)
        Panel3.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Location = New Point(503, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright @ 2023 Much Prosperity Trading Inc.. All Rights Reserved."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbDesktop
        ' 
        pbDesktop.Image = CType(resources.GetObject("pbDesktop.Image"), Image)
        pbDesktop.Location = New Point(0, 0)
        pbDesktop.Name = "pbDesktop"
        pbDesktop.Size = New Size(78, 67)
        pbDesktop.SizeMode = PictureBoxSizeMode.Zoom
        pbDesktop.TabIndex = 1
        pbDesktop.TabStop = False
        ToolTip1.SetToolTip(pbDesktop, "Desktop")
        ' 
        ' pbLaptop
        ' 
        pbLaptop.Image = CType(resources.GetObject("pbLaptop.Image"), Image)
        pbLaptop.Location = New Point(3, 7)
        pbLaptop.Name = "pbLaptop"
        pbLaptop.Size = New Size(69, 53)
        pbLaptop.SizeMode = PictureBoxSizeMode.Zoom
        pbLaptop.TabIndex = 1
        pbLaptop.TabStop = False
        ToolTip1.SetToolTip(pbLaptop, "Laptop")
        ' 
        ' pbTotal
        ' 
        pbTotal.Image = CType(resources.GetObject("pbTotal.Image"), Image)
        pbTotal.Location = New Point(6, 10)
        pbTotal.Name = "pbTotal"
        pbTotal.Size = New Size(61, 46)
        pbTotal.SizeMode = PictureBoxSizeMode.Zoom
        pbTotal.TabIndex = 1
        pbTotal.TabStop = False
        ToolTip1.SetToolTip(pbTotal, "All")
        ' 
        ' pbActive
        ' 
        pbActive.Image = CType(resources.GetObject("pbActive.Image"), Image)
        pbActive.Location = New Point(13, 10)
        pbActive.Name = "pbActive"
        pbActive.Size = New Size(56, 45)
        pbActive.SizeMode = PictureBoxSizeMode.Zoom
        pbActive.TabIndex = 1
        pbActive.TabStop = False
        ToolTip1.SetToolTip(pbActive, "Active")
        ' 
        ' pbInactive
        ' 
        pbInactive.Image = CType(resources.GetObject("pbInactive.Image"), Image)
        pbInactive.Location = New Point(12, 10)
        pbInactive.Name = "pbInactive"
        pbInactive.Size = New Size(56, 45)
        pbInactive.SizeMode = PictureBoxSizeMode.Zoom
        pbInactive.TabIndex = 6
        pbInactive.TabStop = False
        ToolTip1.SetToolTip(pbInactive, "Inactive")
        ' 
        ' pbDispose
        ' 
        pbDispose.Image = CType(resources.GetObject("pbDispose.Image"), Image)
        pbDispose.Location = New Point(12, 10)
        pbDispose.Name = "pbDispose"
        pbDispose.Size = New Size(56, 45)
        pbDispose.SizeMode = PictureBoxSizeMode.Zoom
        pbDispose.TabIndex = 6
        pbDispose.TabStop = False
        ToolTip1.SetToolTip(pbDispose, "Dispose")
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(413, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(114, 33)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(21, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(386, 33)
        txtSearch.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(pbClearButton)
        Panel4.Controls.Add(txtSearch)
        Panel4.Controls.Add(btnSearch)
        Panel4.Location = New Point(932, 97)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(543, 67)
        Panel4.TabIndex = 6
        ' 
        ' pbClearButton
        ' 
        pbClearButton.Cursor = Cursors.Hand
        pbClearButton.Image = CType(resources.GetObject("pbClearButton.Image"), Image)
        pbClearButton.Location = New Point(378, 25)
        pbClearButton.Name = "pbClearButton"
        pbClearButton.Size = New Size(22, 18)
        pbClearButton.SizeMode = PictureBoxSizeMode.Zoom
        pbClearButton.TabIndex = 7
        pbClearButton.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(lblDesktopNumber)
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(pbDesktop)
        Panel7.Location = New Point(176, 97)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(144, 67)
        Panel7.TabIndex = 11
        ' 
        ' lblDesktopNumber
        ' 
        lblDesktopNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDesktopNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDesktopNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblDesktopNumber.Location = New Point(82, 14)
        lblDesktopNumber.Name = "lblDesktopNumber"
        lblDesktopNumber.Size = New Size(57, 37)
        lblDesktopNumber.TabIndex = 5
        lblDesktopNumber.Text = "0"
        lblDesktopNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(506, 30)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 50)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(lblLaptopNumber)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(pbLaptop)
        Panel5.Location = New Point(326, 97)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(144, 67)
        Panel5.TabIndex = 12
        ' 
        ' lblLaptopNumber
        ' 
        lblLaptopNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblLaptopNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblLaptopNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblLaptopNumber.Location = New Point(76, 14)
        lblLaptopNumber.Name = "lblLaptopNumber"
        lblLaptopNumber.Size = New Size(65, 37)
        lblLaptopNumber.TabIndex = 5
        lblLaptopNumber.Text = "0"
        lblLaptopNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(506, 30)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 50)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(lblTotalNumber)
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(pbTotal)
        Panel6.Location = New Point(26, 97)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(144, 67)
        Panel6.TabIndex = 13
        ' 
        ' lblTotalNumber
        ' 
        lblTotalNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblTotalNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblTotalNumber.Location = New Point(71, 14)
        lblTotalNumber.Name = "lblTotalNumber"
        lblTotalNumber.Size = New Size(68, 37)
        lblTotalNumber.TabIndex = 5
        lblTotalNumber.Text = "0"
        lblTotalNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Location = New Point(506, 30)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(100, 50)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(lblActiveNumber)
        Panel8.Controls.Add(PictureBox8)
        Panel8.Controls.Add(pbActive)
        Panel8.Location = New Point(476, 97)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(144, 67)
        Panel8.TabIndex = 14
        ' 
        ' lblActiveNumber
        ' 
        lblActiveNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblActiveNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblActiveNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblActiveNumber.Location = New Point(73, 14)
        lblActiveNumber.Name = "lblActiveNumber"
        lblActiveNumber.Size = New Size(66, 37)
        lblActiveNumber.TabIndex = 5
        lblActiveNumber.Text = "0"
        lblActiveNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Location = New Point(506, 30)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(100, 50)
        PictureBox8.TabIndex = 4
        PictureBox8.TabStop = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(pbInactive)
        Panel9.Controls.Add(lblInactiveNumber)
        Panel9.Controls.Add(PictureBox10)
        Panel9.Location = New Point(626, 97)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(144, 67)
        Panel9.TabIndex = 14
        ' 
        ' lblInactiveNumber
        ' 
        lblInactiveNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblInactiveNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblInactiveNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblInactiveNumber.Location = New Point(72, 14)
        lblInactiveNumber.Name = "lblInactiveNumber"
        lblInactiveNumber.Size = New Size(67, 37)
        lblInactiveNumber.TabIndex = 5
        lblInactiveNumber.Text = "0"
        lblInactiveNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Location = New Point(506, 30)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(100, 50)
        PictureBox10.TabIndex = 4
        PictureBox10.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(pbDispose)
        Panel10.Controls.Add(lblDisposeNumber)
        Panel10.Controls.Add(PictureBox12)
        Panel10.Location = New Point(776, 97)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(144, 67)
        Panel10.TabIndex = 14
        ' 
        ' lblDisposeNumber
        ' 
        lblDisposeNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDisposeNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDisposeNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblDisposeNumber.Location = New Point(72, 14)
        lblDisposeNumber.Name = "lblDisposeNumber"
        lblDisposeNumber.Size = New Size(67, 37)
        lblDisposeNumber.TabIndex = 5
        lblDisposeNumber.Text = "0"
        lblDisposeNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Location = New Point(506, 30)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(100, 50)
        PictureBox12.TabIndex = 4
        PictureBox12.TabStop = False
        ' 
        ' userForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1500, 962)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel5)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "userForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user"
        Panel1.ResumeLayout(False)
        CType(pictureAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgAssets, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(pbDesktop, ComponentModel.ISupportInitialize).EndInit()
        CType(pbLaptop, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTotal, ComponentModel.ISupportInitialize).EndInit()
        CType(pbActive, ComponentModel.ISupportInitialize).EndInit()
        CType(pbInactive, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDispose, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(pbClearButton, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgAssets As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pictureAccount As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblDesktopNumber As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pbDesktop As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblLaptopNumber As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbLaptop As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblTotalNumber As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents pbTotal As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblActiveNumber As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents pbActive As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblInactiveNumber As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblDisposeNumber As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents pbInactive As PictureBox
    Friend WithEvents pbDispose As PictureBox
    Friend WithEvents pbClearButton As PictureBox
End Class
