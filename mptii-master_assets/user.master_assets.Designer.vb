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
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel3 = New Panel()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        CType(pictureAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgAssets, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(pictureAccount)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1506, 123)
        Panel1.TabIndex = 3
        ' 
        ' pictureAccount
        ' 
        pictureAccount.Image = CType(resources.GetObject("pictureAccount.Image"), Image)
        pictureAccount.Location = New Point(1415, 36)
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
        PictureBox1.Location = New Point(-20, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(401, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(dgAssets)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(txtSearch)
        Panel2.Location = New Point(26, 151)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1449, 726)
        Panel2.TabIndex = 4
        ' 
        ' dgAssets
        ' 
        dgAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgAssets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgAssets.BackgroundColor = Color.White
        dgAssets.GridColor = SystemColors.ControlDarkDark
        dgAssets.Location = New Point(17, 59)
        dgAssets.Name = "dgAssets"
        dgAssets.ReadOnly = True
        dgAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgAssets.RowTemplate.Height = 25
        dgAssets.Size = New Size(1416, 649)
        dgAssets.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(1319, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(114, 33)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(927, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(386, 33)
        txtSearch.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(-1, 898)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1506, 65)
        Panel3.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Location = New Point(530, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright @ 2023 Much Prosperity Trading Inc.. All Rights Reserved."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' userForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1500, 962)
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
        Panel2.PerformLayout()
        CType(dgAssets, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgAssets As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pictureAccount As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
End Class
