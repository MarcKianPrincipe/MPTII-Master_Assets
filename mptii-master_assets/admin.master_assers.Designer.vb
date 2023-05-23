<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(adminForm))
        Panel1 = New Panel()
        pictureAccount = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        Panel2 = New Panel()
        dgAssets = New DataGridView()
        Panel4 = New Panel()
        btnAdd = New Button()
        btnUpdate = New Button()
        cbActiveDirectory = New ComboBox()
        Label11 = New Label()
        txtOffice = New TextBox()
        Label10 = New Label()
        cbWindows = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        txtProcessor = New TextBox()
        Label7 = New Label()
        txtBrand = New TextBox()
        cbDepartment = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        txtIssuedTo = New TextBox()
        Label4 = New Label()
        txtYearAge = New TextBox()
        dtpPurchaseDate = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        txtLaptopNumber = New TextBox()
        Panel5 = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        CType(pictureAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgAssets, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
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
        Panel1.TabIndex = 4
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(-1, 898)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1506, 65)
        Panel3.TabIndex = 6
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(dgAssets)
        Panel2.Location = New Point(26, 146)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1079, 733)
        Panel2.TabIndex = 7
        ' 
        ' dgAssets
        ' 
        dgAssets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgAssets.BackgroundColor = Color.White
        dgAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAssets.Location = New Point(13, 12)
        dgAssets.Name = "dgAssets"
        dgAssets.ReadOnly = True
        dgAssets.RowTemplate.Height = 25
        dgAssets.Size = New Size(1052, 707)
        dgAssets.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(btnAdd)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Controls.Add(cbActiveDirectory)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(txtOffice)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(cbWindows)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(txtProcessor)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(txtBrand)
        Panel4.Controls.Add(cbDepartment)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(txtIssuedTo)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtYearAge)
        Panel4.Controls.Add(dtpPurchaseDate)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(txtLaptopNumber)
        Panel4.Location = New Point(1121, 212)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(353, 667)
        Panel4.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(181, 495)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(162, 33)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.Location = New Point(11, 495)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(163, 33)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cbActiveDirectory
        ' 
        cbActiveDirectory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbActiveDirectory.FormattingEnabled = True
        cbActiveDirectory.Location = New Point(11, 464)
        cbActiveDirectory.Name = "cbActiveDirectory"
        cbActiveDirectory.Size = New Size(332, 25)
        cbActiveDirectory.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(11, 444)
        Label11.Name = "Label11"
        Label11.Size = New Size(102, 17)
        Label11.TabIndex = 20
        Label11.Text = "Active Directory:"
        ' 
        ' txtOffice
        ' 
        txtOffice.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtOffice.Location = New Point(11, 416)
        txtOffice.Name = "txtOffice"
        txtOffice.Size = New Size(332, 25)
        txtOffice.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(11, 396)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 17)
        Label10.TabIndex = 18
        Label10.Text = "O365 Expiration:"
        ' 
        ' cbWindows
        ' 
        cbWindows.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbWindows.FormattingEnabled = True
        cbWindows.Location = New Point(11, 368)
        cbWindows.Name = "cbWindows"
        cbWindows.Size = New Size(332, 25)
        cbWindows.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(11, 348)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 17)
        Label9.TabIndex = 16
        Label9.Text = "Windows:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(11, 300)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 17)
        Label8.TabIndex = 15
        Label8.Text = "Processor:"
        ' 
        ' txtProcessor
        ' 
        txtProcessor.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtProcessor.Location = New Point(11, 320)
        txtProcessor.Name = "txtProcessor"
        txtProcessor.Size = New Size(332, 25)
        txtProcessor.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(10, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 17)
        Label7.TabIndex = 13
        Label7.Text = "Brand:"
        ' 
        ' txtBrand
        ' 
        txtBrand.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtBrand.Location = New Point(11, 272)
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(332, 25)
        txtBrand.TabIndex = 12
        ' 
        ' cbDepartment
        ' 
        cbDepartment.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbDepartment.FormattingEnabled = True
        cbDepartment.Items.AddRange(New Object() {"IT", "Sales", "Accounting", "Creative", "HRA", "Marketing", ""})
        cbDepartment.Location = New Point(11, 224)
        cbDepartment.Name = "cbDepartment"
        cbDepartment.Size = New Size(332, 25)
        cbDepartment.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(11, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 17)
        Label6.TabIndex = 10
        Label6.Text = "Department:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(10, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 17)
        Label5.TabIndex = 8
        Label5.Text = "Issued To:"
        ' 
        ' txtIssuedTo
        ' 
        txtIssuedTo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtIssuedTo.Location = New Point(11, 176)
        txtIssuedTo.Name = "txtIssuedTo"
        txtIssuedTo.Size = New Size(332, 25)
        txtIssuedTo.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 17)
        Label4.TabIndex = 6
        Label4.Text = "Year Age:"
        ' 
        ' txtYearAge
        ' 
        txtYearAge.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtYearAge.Location = New Point(11, 128)
        txtYearAge.Name = "txtYearAge"
        txtYearAge.Size = New Size(332, 25)
        txtYearAge.TabIndex = 5
        ' 
        ' dtpPurchaseDate
        ' 
        dtpPurchaseDate.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpPurchaseDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpPurchaseDate.Location = New Point(11, 80)
        dtpPurchaseDate.Name = "dtpPurchaseDate"
        dtpPurchaseDate.Size = New Size(332, 25)
        dtpPurchaseDate.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 17)
        Label3.TabIndex = 3
        Label3.Text = "Purchase Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(10, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 1
        Label2.Text = "Laptop Number:"
        ' 
        ' txtLaptopNumber
        ' 
        txtLaptopNumber.Enabled = False
        txtLaptopNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLaptopNumber.Location = New Point(11, 32)
        txtLaptopNumber.Name = "txtLaptopNumber"
        txtLaptopNumber.Size = New Size(332, 25)
        txtLaptopNumber.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(btnSearch)
        Panel5.Controls.Add(txtSearch)
        Panel5.Location = New Point(1121, 146)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(353, 60)
        Panel5.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Black
        btnSearch.Location = New Point(252, 14)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(91, 33)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(12, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(234, 33)
        txtSearch.TabIndex = 0
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1500, 962)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        CType(pictureAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgAssets, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pictureAccount As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgAssets As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLaptopNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPurchaseDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYearAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIssuedTo As TextBox
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents cbWindows As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtOffice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbActiveDirectory As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
End Class
