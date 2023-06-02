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
        pbDesktop = New PictureBox()
        pbViewSummary = New PictureBox()
        pbLaptop = New PictureBox()
        pbTotal = New PictureBox()
        pbActive = New PictureBox()
        pbInactive = New PictureBox()
        pbDispose = New PictureBox()
        Panel2 = New Panel()
        dgAssets = New DataGridView()
        Panel4 = New Panel()
        txtRemarks = New TextBox()
        Label17 = New Label()
        txtItemCode = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        cbAssetType = New ComboBox()
        cbBrand = New ComboBox()
        cbStatus = New ComboBox()
        Label14 = New Label()
        txtModel = New TextBox()
        Label13 = New Label()
        txtCurrentUser = New TextBox()
        Label12 = New Label()
        dtpO365 = New DateTimePicker()
        btnAdd = New Button()
        btnUpdate = New Button()
        cbActiveDirectory = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        cbWindows = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        txtProcessor = New TextBox()
        Label7 = New Label()
        cbDepartment = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        txtSerialNumber = New TextBox()
        Label4 = New Label()
        txtYearAge = New TextBox()
        dtpPurchaseDate = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        txtUnitNumber = New TextBox()
        Panel5 = New Panel()
        pbClearButton = New PictureBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        Panel7 = New Panel()
        lblDesktopNumber = New Label()
        PictureBox5 = New PictureBox()
        pnViewSummary = New Panel()
        lblViewSummary = New Label()
        PictureBox8 = New PictureBox()
        Panel8 = New Panel()
        lblLaptopNumber = New Label()
        PictureBox3 = New PictureBox()
        Panel9 = New Panel()
        lblTotalNumber = New Label()
        PictureBox6 = New PictureBox()
        Panel11 = New Panel()
        lblActiveNumber = New Label()
        PictureBox10 = New PictureBox()
        Panel12 = New Panel()
        lblInactiveNumber = New Label()
        PictureBox12 = New PictureBox()
        Panel13 = New Panel()
        lblDisposeNumber = New Label()
        PictureBox14 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        CType(pictureAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(pbDesktop, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbViewSummary, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbLaptop, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTotal, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbActive, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbInactive, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbDispose, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgAssets, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(pbClearButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        pnViewSummary.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        Panel12.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 4
        ' 
        ' pictureAccount
        ' 
        pictureAccount.Cursor = Cursors.Hand
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(-1, 922)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1506, 41)
        Panel3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label1.Location = New Point(0, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(1503, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright @ 2023 Much Prosperity Trading Inc.. All Rights Reserved."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbDesktop
        ' 
        pbDesktop.Image = CType(resources.GetObject("pbDesktop.Image"), Image)
        pbDesktop.Location = New Point(0, 0)
        pbDesktop.Name = "pbDesktop"
        pbDesktop.Size = New Size(69, 56)
        pbDesktop.SizeMode = PictureBoxSizeMode.Zoom
        pbDesktop.TabIndex = 1
        pbDesktop.TabStop = False
        ToolTip1.SetToolTip(pbDesktop, "Desktop")
        ' 
        ' pbViewSummary
        ' 
        pbViewSummary.Image = CType(resources.GetObject("pbViewSummary.Image"), Image)
        pbViewSummary.Location = New Point(0, 6)
        pbViewSummary.Name = "pbViewSummary"
        pbViewSummary.Size = New Size(78, 43)
        pbViewSummary.SizeMode = PictureBoxSizeMode.Zoom
        pbViewSummary.TabIndex = 1
        pbViewSummary.TabStop = False
        ToolTip1.SetToolTip(pbViewSummary, "View Full Summary")
        ' 
        ' pbLaptop
        ' 
        pbLaptop.Image = CType(resources.GetObject("pbLaptop.Image"), Image)
        pbLaptop.Location = New Point(0, 4)
        pbLaptop.Name = "pbLaptop"
        pbLaptop.Size = New Size(63, 50)
        pbLaptop.SizeMode = PictureBoxSizeMode.Zoom
        pbLaptop.TabIndex = 1
        pbLaptop.TabStop = False
        ToolTip1.SetToolTip(pbLaptop, "Laptop")
        ' 
        ' pbTotal
        ' 
        pbTotal.Image = CType(resources.GetObject("pbTotal.Image"), Image)
        pbTotal.Location = New Point(5, 6)
        pbTotal.Name = "pbTotal"
        pbTotal.Size = New Size(47, 45)
        pbTotal.SizeMode = PictureBoxSizeMode.Zoom
        pbTotal.TabIndex = 1
        pbTotal.TabStop = False
        ToolTip1.SetToolTip(pbTotal, "All")
        ' 
        ' pbActive
        ' 
        pbActive.Image = CType(resources.GetObject("pbActive.Image"), Image)
        pbActive.Location = New Point(5, 6)
        pbActive.Name = "pbActive"
        pbActive.Size = New Size(47, 45)
        pbActive.SizeMode = PictureBoxSizeMode.Zoom
        pbActive.TabIndex = 1
        pbActive.TabStop = False
        ToolTip1.SetToolTip(pbActive, "Active")
        ' 
        ' pbInactive
        ' 
        pbInactive.Image = CType(resources.GetObject("pbInactive.Image"), Image)
        pbInactive.Location = New Point(5, 6)
        pbInactive.Name = "pbInactive"
        pbInactive.Size = New Size(47, 45)
        pbInactive.SizeMode = PictureBoxSizeMode.Zoom
        pbInactive.TabIndex = 1
        pbInactive.TabStop = False
        ToolTip1.SetToolTip(pbInactive, "Inactive")
        ' 
        ' pbDispose
        ' 
        pbDispose.Image = CType(resources.GetObject("pbDispose.Image"), Image)
        pbDispose.Location = New Point(5, 6)
        pbDispose.Name = "pbDispose"
        pbDispose.Size = New Size(47, 45)
        pbDispose.SizeMode = PictureBoxSizeMode.Zoom
        pbDispose.TabIndex = 1
        pbDispose.TabStop = False
        ToolTip1.SetToolTip(pbDispose, "Dispose")
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(dgAssets)
        Panel2.Location = New Point(23, 159)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1092, 694)
        Panel2.TabIndex = 7
        ' 
        ' dgAssets
        ' 
        dgAssets.BackgroundColor = Color.White
        dgAssets.Location = New Point(13, 18)
        dgAssets.Name = "dgAssets"
        dgAssets.ReadOnly = True
        dgAssets.RowTemplate.Height = 25
        dgAssets.Size = New Size(1065, 660)
        dgAssets.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(txtRemarks)
        Panel4.Controls.Add(Label17)
        Panel4.Controls.Add(txtItemCode)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(cbAssetType)
        Panel4.Controls.Add(cbBrand)
        Panel4.Controls.Add(cbStatus)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(txtModel)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(txtCurrentUser)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(dtpO365)
        Panel4.Controls.Add(btnAdd)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Controls.Add(cbActiveDirectory)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(cbWindows)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(txtProcessor)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(cbDepartment)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(txtSerialNumber)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtYearAge)
        Panel4.Controls.Add(dtpPurchaseDate)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(txtUnitNumber)
        Panel4.Location = New Point(1121, 97)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(353, 819)
        Panel4.TabIndex = 8
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtRemarks.Location = New Point(10, 747)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(332, 25)
        txtRemarks.TabIndex = 37
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(10, 727)
        Label17.Name = "Label17"
        Label17.Size = New Size(61, 17)
        Label17.TabIndex = 36
        Label17.Text = "Remarks:"
        ' 
        ' txtItemCode
        ' 
        txtItemCode.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtItemCode.Location = New Point(10, 75)
        txtItemCode.Name = "txtItemCode"
        txtItemCode.Size = New Size(332, 25)
        txtItemCode.TabIndex = 35
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(10, 55)
        Label16.Name = "Label16"
        Label16.Size = New Size(71, 17)
        Label16.TabIndex = 34
        Label16.Text = "Item Code:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(9, 103)
        Label15.Name = "Label15"
        Label15.Size = New Size(70, 17)
        Label15.TabIndex = 33
        Label15.Text = "Asset Type"
        ' 
        ' cbAssetType
        ' 
        cbAssetType.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbAssetType.FormattingEnabled = True
        cbAssetType.Items.AddRange(New Object() {"Desktop", "Laptop"})
        cbAssetType.Location = New Point(10, 123)
        cbAssetType.Name = "cbAssetType"
        cbAssetType.Size = New Size(332, 25)
        cbAssetType.TabIndex = 32
        ' 
        ' cbBrand
        ' 
        cbBrand.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbBrand.FormattingEnabled = True
        cbBrand.Items.AddRange(New Object() {"Acer", "Dell", "Lenovo"})
        cbBrand.Location = New Point(10, 411)
        cbBrand.Name = "cbBrand"
        cbBrand.Size = New Size(332, 25)
        cbBrand.TabIndex = 31
        ' 
        ' cbStatus
        ' 
        cbStatus.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Active", "Inactive", "Dispose"})
        cbStatus.Location = New Point(10, 699)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(332, 25)
        cbStatus.TabIndex = 30
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(10, 679)
        Label14.Name = "Label14"
        Label14.Size = New Size(46, 17)
        Label14.TabIndex = 29
        Label14.Text = "Status:"
        ' 
        ' txtModel
        ' 
        txtModel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.Location = New Point(10, 459)
        txtModel.Name = "txtModel"
        txtModel.Size = New Size(332, 25)
        txtModel.TabIndex = 28
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(10, 439)
        Label13.Name = "Label13"
        Label13.Size = New Size(49, 17)
        Label13.TabIndex = 27
        Label13.Text = "Model:"
        ' 
        ' txtCurrentUser
        ' 
        txtCurrentUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCurrentUser.Location = New Point(10, 171)
        txtCurrentUser.Name = "txtCurrentUser"
        txtCurrentUser.Size = New Size(332, 25)
        txtCurrentUser.TabIndex = 26
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(10, 151)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 17)
        Label12.TabIndex = 25
        Label12.Text = "Current User"
        ' 
        ' dtpO365
        ' 
        dtpO365.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpO365.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpO365.Location = New Point(10, 603)
        dtpO365.Name = "dtpO365"
        dtpO365.Size = New Size(332, 25)
        dtpO365.TabIndex = 24
        ' 
        ' btnAdd
        ' 
        btnAdd.Cursor = Cursors.Hand
        btnAdd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(178, 778)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(164, 33)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.Location = New Point(10, 778)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(162, 33)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cbActiveDirectory
        ' 
        cbActiveDirectory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbActiveDirectory.FormattingEnabled = True
        cbActiveDirectory.Items.AddRange(New Object() {"With Active Directory", "Without Active Directory"})
        cbActiveDirectory.Location = New Point(10, 651)
        cbActiveDirectory.Name = "cbActiveDirectory"
        cbActiveDirectory.Size = New Size(332, 25)
        cbActiveDirectory.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(10, 631)
        Label11.Name = "Label11"
        Label11.Size = New Size(102, 17)
        Label11.TabIndex = 20
        Label11.Text = "Active Directory:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(9, 583)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 17)
        Label10.TabIndex = 18
        Label10.Text = "O365 Expiration:"
        ' 
        ' cbWindows
        ' 
        cbWindows.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbWindows.FormattingEnabled = True
        cbWindows.Items.AddRange(New Object() {"Windows 10 Pro", "Windows 11 Pro"})
        cbWindows.Location = New Point(10, 555)
        cbWindows.Name = "cbWindows"
        cbWindows.Size = New Size(332, 25)
        cbWindows.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(10, 535)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 17)
        Label9.TabIndex = 16
        Label9.Text = "Windows:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(9, 487)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 17)
        Label8.TabIndex = 15
        Label8.Text = "Processor:"
        ' 
        ' txtProcessor
        ' 
        txtProcessor.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtProcessor.Location = New Point(10, 507)
        txtProcessor.Name = "txtProcessor"
        txtProcessor.Size = New Size(332, 25)
        txtProcessor.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(10, 391)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 17)
        Label7.TabIndex = 13
        Label7.Text = "Brand:"
        ' 
        ' cbDepartment
        ' 
        cbDepartment.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbDepartment.FormattingEnabled = True
        cbDepartment.Items.AddRange(New Object() {"IT", "Sales", "Accounting", "Creative", "HR", "Marketing", "Finance"})
        cbDepartment.Location = New Point(10, 363)
        cbDepartment.Name = "cbDepartment"
        cbDepartment.Size = New Size(332, 25)
        cbDepartment.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(10, 343)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 17)
        Label6.TabIndex = 10
        Label6.Text = "Department:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(10, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 17)
        Label5.TabIndex = 8
        Label5.Text = "Serial Number:"
        ' 
        ' txtSerialNumber
        ' 
        txtSerialNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSerialNumber.Location = New Point(10, 315)
        txtSerialNumber.Name = "txtSerialNumber"
        txtSerialNumber.Size = New Size(332, 25)
        txtSerialNumber.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(9, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 17)
        Label4.TabIndex = 6
        Label4.Text = "Year Age:"
        ' 
        ' txtYearAge
        ' 
        txtYearAge.Enabled = False
        txtYearAge.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtYearAge.Location = New Point(10, 267)
        txtYearAge.Name = "txtYearAge"
        txtYearAge.Size = New Size(332, 25)
        txtYearAge.TabIndex = 5
        ' 
        ' dtpPurchaseDate
        ' 
        dtpPurchaseDate.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpPurchaseDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpPurchaseDate.Location = New Point(10, 219)
        dtpPurchaseDate.Name = "dtpPurchaseDate"
        dtpPurchaseDate.Size = New Size(332, 25)
        dtpPurchaseDate.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 17)
        Label3.TabIndex = 3
        Label3.Text = "Purchase Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(10, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 17)
        Label2.TabIndex = 1
        Label2.Text = "Unit Number:"
        ' 
        ' txtUnitNumber
        ' 
        txtUnitNumber.Enabled = False
        txtUnitNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUnitNumber.Location = New Point(10, 27)
        txtUnitNumber.Name = "txtUnitNumber"
        txtUnitNumber.Size = New Size(332, 25)
        txtUnitNumber.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(pbClearButton)
        Panel5.Controls.Add(txtSearch)
        Panel5.Controls.Add(btnSearch)
        Panel5.Location = New Point(23, 97)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1092, 56)
        Panel5.TabIndex = 9
        ' 
        ' pbClearButton
        ' 
        pbClearButton.Cursor = Cursors.Hand
        pbClearButton.Image = CType(resources.GetObject("pbClearButton.Image"), Image)
        pbClearButton.Location = New Point(956, 16)
        pbClearButton.Name = "pbClearButton"
        pbClearButton.Size = New Size(16, 18)
        pbClearButton.SizeMode = PictureBoxSizeMode.Zoom
        pbClearButton.TabIndex = 2
        pbClearButton.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(660, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 27)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.Location = New Point(987, 12)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(91, 27)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(lblDesktopNumber)
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(pbDesktop)
        Panel7.Location = New Point(158, 859)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(129, 56)
        Panel7.TabIndex = 10
        ' 
        ' lblDesktopNumber
        ' 
        lblDesktopNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDesktopNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDesktopNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblDesktopNumber.Location = New Point(72, 8)
        lblDesktopNumber.Name = "lblDesktopNumber"
        lblDesktopNumber.Size = New Size(51, 37)
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
        ' pnViewSummary
        ' 
        pnViewSummary.BackColor = Color.White
        pnViewSummary.Controls.Add(lblViewSummary)
        pnViewSummary.Controls.Add(PictureBox8)
        pnViewSummary.Controls.Add(pbViewSummary)
        pnViewSummary.Cursor = Cursors.Hand
        pnViewSummary.Location = New Point(833, 859)
        pnViewSummary.Name = "pnViewSummary"
        pnViewSummary.Size = New Size(282, 56)
        pnViewSummary.TabIndex = 13
        ' 
        ' lblViewSummary
        ' 
        lblViewSummary.AutoSize = True
        lblViewSummary.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblViewSummary.ForeColor = Color.FromArgb(CByte(15), CByte(29), CByte(65))
        lblViewSummary.Location = New Point(91, 16)
        lblViewSummary.Name = "lblViewSummary"
        lblViewSummary.Size = New Size(177, 25)
        lblViewSummary.TabIndex = 5
        lblViewSummary.Text = "View Full Summary"
        lblViewSummary.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Location = New Point(506, 30)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(100, 50)
        PictureBox8.TabIndex = 4
        PictureBox8.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(lblLaptopNumber)
        Panel8.Controls.Add(PictureBox3)
        Panel8.Controls.Add(pbLaptop)
        Panel8.Location = New Point(293, 859)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(129, 56)
        Panel8.TabIndex = 11
        ' 
        ' lblLaptopNumber
        ' 
        lblLaptopNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblLaptopNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblLaptopNumber.Location = New Point(67, 8)
        lblLaptopNumber.Name = "lblLaptopNumber"
        lblLaptopNumber.Size = New Size(57, 37)
        lblLaptopNumber.TabIndex = 6
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
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(lblTotalNumber)
        Panel9.Controls.Add(PictureBox6)
        Panel9.Controls.Add(pbTotal)
        Panel9.Location = New Point(23, 859)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(129, 56)
        Panel9.TabIndex = 12
        ' 
        ' lblTotalNumber
        ' 
        lblTotalNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblTotalNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblTotalNumber.Location = New Point(56, 8)
        lblTotalNumber.Name = "lblTotalNumber"
        lblTotalNumber.Size = New Size(68, 37)
        lblTotalNumber.TabIndex = 7
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
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(lblActiveNumber)
        Panel11.Controls.Add(PictureBox10)
        Panel11.Controls.Add(pbActive)
        Panel11.Location = New Point(428, 859)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(129, 56)
        Panel11.TabIndex = 13
        ' 
        ' lblActiveNumber
        ' 
        lblActiveNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblActiveNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblActiveNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblActiveNumber.Location = New Point(57, 8)
        lblActiveNumber.Name = "lblActiveNumber"
        lblActiveNumber.Size = New Size(68, 37)
        lblActiveNumber.TabIndex = 8
        lblActiveNumber.Text = "0"
        lblActiveNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Location = New Point(506, 30)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(100, 50)
        PictureBox10.TabIndex = 4
        PictureBox10.TabStop = False
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(lblInactiveNumber)
        Panel12.Controls.Add(PictureBox12)
        Panel12.Controls.Add(pbInactive)
        Panel12.Location = New Point(563, 859)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(129, 56)
        Panel12.TabIndex = 14
        ' 
        ' lblInactiveNumber
        ' 
        lblInactiveNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblInactiveNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblInactiveNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblInactiveNumber.Location = New Point(58, 9)
        lblInactiveNumber.Name = "lblInactiveNumber"
        lblInactiveNumber.Size = New Size(68, 37)
        lblInactiveNumber.TabIndex = 9
        lblInactiveNumber.Text = "0"
        lblInactiveNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Location = New Point(506, 30)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(100, 50)
        PictureBox12.TabIndex = 4
        PictureBox12.TabStop = False
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Controls.Add(lblDisposeNumber)
        Panel13.Controls.Add(PictureBox14)
        Panel13.Controls.Add(pbDispose)
        Panel13.Location = New Point(698, 859)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(129, 56)
        Panel13.TabIndex = 15
        ' 
        ' lblDisposeNumber
        ' 
        lblDisposeNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDisposeNumber.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDisposeNumber.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblDisposeNumber.Location = New Point(58, 8)
        lblDisposeNumber.Name = "lblDisposeNumber"
        lblDisposeNumber.Size = New Size(68, 37)
        lblDisposeNumber.TabIndex = 10
        lblDisposeNumber.Text = "0"
        lblDisposeNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Location = New Point(506, 30)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(100, 50)
        PictureBox14.TabIndex = 4
        PictureBox14.TabStop = False
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1500, 962)
        Controls.Add(Panel13)
        Controls.Add(Panel7)
        Controls.Add(Panel12)
        Controls.Add(Panel11)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(pnViewSummary)
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
        CType(pbDesktop, ComponentModel.ISupportInitialize).EndInit()
        CType(pbViewSummary, ComponentModel.ISupportInitialize).EndInit()
        CType(pbLaptop, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTotal, ComponentModel.ISupportInitialize).EndInit()
        CType(pbActive, ComponentModel.ISupportInitialize).EndInit()
        CType(pbInactive, ComponentModel.ISupportInitialize).EndInit()
        CType(pbDispose, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dgAssets, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(pbClearButton, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        pnViewSummary.ResumeLayout(False)
        pnViewSummary.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        Panel12.ResumeLayout(False)
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPurchaseDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYearAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents cbDepartment As ComboBox
    Friend WithEvents cbWindows As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbActiveDirectory As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtpO365 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCurrentUser As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cbBrand As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pbDesktop As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pnViewSummary As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents pbViewSummary As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbLaptop As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents pbTotal As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents pbActive As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents pbInactive As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents pbDispose As PictureBox
    Friend WithEvents lblViewSummary As Label
    Friend WithEvents cbAssetType As ComboBox
    Friend WithEvents lblDesktopNumber As Label
    Friend WithEvents lblLaptopNumber As Label
    Friend WithEvents lblTotalNumber As Label
    Friend WithEvents lblActiveNumber As Label
    Friend WithEvents lblDisposeNumber As Label
    Friend WithEvents lblInactiveNumber As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pbClearButton As PictureBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtRemarks As TextBox
End Class
