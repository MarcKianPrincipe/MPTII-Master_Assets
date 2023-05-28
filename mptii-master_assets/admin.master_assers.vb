Imports System.Data.SqlClient

Public Class adminForm
    Private unitNumber As Integer
    Private dataTable As DataTable ' Declare a class-level variable to hold the data

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;User ID=sa;Password=password"

        ' SQL query to fetch the data from the table
        Dim query As String = "SELECT [Unit Number], [Asset Type], [Current User], [Purchase Date], [Year Age], [Issued To], [Department], [Brand], [Model], [Processor], [Windows], [O365 Expiration], [Active Directory], [Status] FROM [DBmptii_master-asset].[dbo].[TBmptii-assets]"
        ' Create a new DataTable to hold the data
        dataTable = New DataTable()

        ' Create a new SqlConnection using the connection string
        Using connection As New SqlConnection(connectionString)
            ' Create a new SqlDataAdapter using the query and connection
            Using adapter As New SqlDataAdapter(query, connection)
                ' Fill the DataTable with the data from the query
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Bind the DataTable to the DataGridView
        dgAssets.DataSource = dataTable

        ' Set the header color
        dgAssets.EnableHeadersVisualStyles = False
        dgAssets.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#d7d5d5")

        ' Manually adjust the vertical scrollbar
        dgAssets.ScrollBars = ScrollBars.Both

        ' Calculate and update the "Year Age" field for each row
        For Each row As DataRow In dataTable.Rows
            Dim purchaseDate As DateTime = CDate(row("Purchase Date"))
            Dim currentDate As DateTime = DateTime.Now

            ' Calculate the difference in months and fractional years
            Dim totalMonths As Integer = ((currentDate.Year - purchaseDate.Year) * 12) + (currentDate.Month - purchaseDate.Month)
            Dim yearAge As Double = totalMonths / 12

            ' Update the "Year Age" field in the DataTable
            row("Year Age") = yearAge.ToString("0.00")
        Next


        ' Desktop Counter
        Dim desktopCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Asset Type").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim assetType As String = cellValue.ToString()
                If assetType = "Desktop" Then
                    desktopCount += 1
                End If
            End If
        Next

        ' Laptop Counter
        Dim laptopCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Asset Type").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim assetType As String = cellValue.ToString()
                If assetType = "Laptop" Then
                    laptopCount += 1
                End If
            End If
        Next

        ' Calculate the total number of assets
        Dim totalAssetsCount As Integer = desktopCount + laptopCount

        ' Update the labels with the respective counts
        lblDesktopNumber.Text = desktopCount.ToString()
        lblLaptopNumber.Text = laptopCount.ToString()
        lblTotalNumber.Text = totalAssetsCount.ToString()

        ' Active Counter
        Dim activeCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Active" Then
                    activeCount += 1
                End If
            End If
        Next

        ' Inactive Counter
        Dim inactiveCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Inactive" Then
                    inactiveCount += 1
                End If
            End If
        Next

        ' Dispose Counter
        Dim disposeCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Dispose" Then
                    disposeCount += 1
                End If
            End If
        Next

        ' Update the labels with the respective counts
        lblActiveNumber.Text = activeCount.ToString()
        lblInactiveNumber.Text = inactiveCount.ToString()
        lblDisposeNumber.Text = disposeCount.ToString()


    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the values from the input controls
        Dim yearAge As Double
        Dim purchaseDate As DateTime
        Dim issuedTo As String
        Dim department As String
        Dim brand As String
        Dim model As String
        Dim processor As String
        Dim windows As String
        Dim o365Expiration As DateTime
        Dim activeDirectory As String
        Dim status As String
        Dim currentUser As String
        Dim assetType As String

        ' Exception handling for null values
        Try
            yearAge = Double.Parse(txtYearAge.Text)
            purchaseDate = dtpPurchaseDate.Value
            issuedTo = txtIssuedTo.Text
            department = cbDepartment.Text
            brand = cbBrand.Text
            model = txtModel.Text
            processor = txtProcessor.Text
            windows = cbWindows.Text
            o365Expiration = dtpO365.Value
            activeDirectory = cbActiveDirectory.Text
            status = cbStatus.Text
            currentUser = txtCurrentUser.Text
            assetType = cbAssetType.Text
        Catch ex As Exception
            MessageBox.Show("Please enter valid values for all fields.")
            Return
        End Try

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"

        ' SQL query to get the maximum existing unit number
        Dim maxUnitNumberQuery As String = "SELECT MAX([Unit Number]) FROM [TBmptii-assets]"

        ' Create a new SqlConnection using the connection string
        Using connection As New SqlConnection(connectionString)
            ' Create a new SqlCommand to execute the maxUnitNumberQuery
            Using command As New SqlCommand(maxUnitNumberQuery, connection)
                ' Open the connection
                connection.Open()

                ' Execute the maxUnitNumberQuery and retrieve the maximum Unit number
                Dim maxUnitNumber As Object = command.ExecuteScalar()

                ' Check if a maximum unit number exists
                If maxUnitNumber IsNot DBNull.Value Then
                    ' Increment the maximum unit number by 1 to get the new unit number
                    unitNumber = Convert.ToInt32(maxUnitNumber) + 1
                Else
                    ' If no unit number exists, start from 1
                    unitNumber = 1
                End If

                ' SQL query to insert the data into the table
                Dim query As String = "INSERT INTO [TBmptii-assets] ([Unit Number], [Asset Type], [Purchase Date], [Year Age], [Issued To], [Department], [Brand], [Model], [Processor], [Windows], [O365 Expiration], [Active Directory], [Status], [Current User]) VALUES (@UnitNumber, @AssetType, @PurchaseDate, @YearAge, @IssuedTo, @Department, @Brand, @Model, @Processor, @Windows, @O365Expiration, @ActiveDirectory, @Status, @CurrentUser)"

                ' Create a new SqlCommand using the query and connection
                Using insertCommand As New SqlCommand(query, connection)
                    ' Add parameters to the insertCommand
                    insertCommand.Parameters.AddWithValue("@UnitNumber", unitNumber)
                    insertCommand.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                    insertCommand.Parameters.AddWithValue("@YearAge", yearAge)
                    insertCommand.Parameters.AddWithValue("@IssuedTo", issuedTo)
                    insertCommand.Parameters.AddWithValue("@Department", department)
                    insertCommand.Parameters.AddWithValue("@Brand", brand)
                    insertCommand.Parameters.AddWithValue("@Model", model)
                    insertCommand.Parameters.AddWithValue("@Processor", processor)
                    insertCommand.Parameters.AddWithValue("@Windows", windows)
                    insertCommand.Parameters.AddWithValue("@O365Expiration", o365Expiration)
                    insertCommand.Parameters.AddWithValue("@ActiveDirectory", activeDirectory)
                    insertCommand.Parameters.AddWithValue("@Status", status)
                    insertCommand.Parameters.AddWithValue("@CurrentUser", currentUser)
                    insertCommand.Parameters.AddWithValue("@AssetType", assetType)

                    ' Execute the INSERT query
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using
        End Using

        ' Display a success message
        MessageBox.Show("Asset added successfully.")

        ' Clear the input fields
        ClearInputFields()
        ' Refresh the data in the DataGridView
        RefreshData()
    End Sub

    Private Sub ClearInputFields()
        ' Clear the input fields
        txtYearAge.Text = String.Empty
        dtpPurchaseDate.Value = DateTime.Now
        txtIssuedTo.Text = String.Empty
        cbDepartment.SelectedIndex = -1
        cbBrand.SelectedIndex = -1
        txtModel.Text = String.Empty
        txtProcessor.Text = String.Empty
        cbWindows.SelectedIndex = -1
        dtpO365.Value = DateTime.Now
        cbActiveDirectory.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        txtCurrentUser.Text = String.Empty
        cbAssetType.SelectedIndex = -1
    End Sub


    Private Sub RefreshData()
        ' Clear the input controls
        txtUnitNumber.Text = String.Empty
        dtpPurchaseDate.Value = DateTime.Now
        txtYearAge.Text = String.Empty
        txtIssuedTo.Text = String.Empty
        cbDepartment.Text = String.Empty
        cbBrand.Text = String.Empty
        txtProcessor.Text = String.Empty
        cbWindows.Text = String.Empty
        dtpO365.Text = DateTime.Now
        cbActiveDirectory.Text = String.Empty
        cbAssetType.Text = String.Empty
        txtCurrentUser.Text = String.Empty
        txtModel.Text = String.Empty
        cbStatus.Text = String.Empty

        ' Retrieve the updated data from the database and bind it to the table form controls
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"
        Dim query As String = "SELECT * FROM [TBmptii-assets] ORDER BY [Unit Number] ASC"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()

                connection.Open()
                adapter.Fill(dataSet, "Assets")
                connection.Close()

                ' Assuming you have a DataGridView named dgAssets
                dgAssets.DataSource = dataSet.Tables("Assets")
            End Using
        End Using


        ' Desktop Counter
        Dim desktopCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Asset Type").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim assetType As String = cellValue.ToString()
                If assetType = "Desktop" Then
                    desktopCount += 1
                End If
            End If
        Next

        ' Laptop Counter
        Dim laptopCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Asset Type").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim assetType As String = cellValue.ToString()
                If assetType = "Laptop" Then
                    laptopCount += 1
                End If
            End If
        Next

        ' Calculate the total number of assets
        Dim totalAssetsCount As Integer = desktopCount + laptopCount

        ' Update the labels with the respective counts
        lblDesktopNumber.Text = desktopCount.ToString()
        lblLaptopNumber.Text = laptopCount.ToString()
        lblTotalNumber.Text = totalAssetsCount.ToString()

        ' Active Counter
        Dim activeCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Active" Then
                    activeCount += 1
                End If
            End If
        Next

        ' Inactive Counter
        Dim inactiveCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Inactive" Then
                    inactiveCount += 1
                End If
            End If
        Next

        ' Dispose Counter
        Dim disposeCount As Integer = 0

        For Each row As DataGridViewRow In dgAssets.Rows
            Dim cellValue As Object = row.Cells("Status").Value
            If cellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(cellValue) Then
                Dim status As String = cellValue.ToString()
                If status = "Dispose" Then
                    disposeCount += 1
                End If
            End If
        Next

        ' Update the labels with the respective counts
        lblActiveNumber.Text = activeCount.ToString()
        lblInactiveNumber.Text = inactiveCount.ToString()
        lblDisposeNumber.Text = disposeCount.ToString()
    End Sub




    Private Sub dgAssets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAssets.CellClick
        ' Check if a valid row and cell is clicked
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgAssets.Rows.Count AndAlso e.ColumnIndex >= 0 AndAlso e.ColumnIndex < dgAssets.Columns.Count Then
            ' Get the clicked cell
            Dim clickedCell As DataGridViewCell = dgAssets.Rows(e.RowIndex).Cells(e.ColumnIndex)

            ' Check if the cell value is not empty
            If Not String.IsNullOrEmpty(clickedCell.Value?.ToString()) Then
                ' Get the clicked row
                Dim clickedRow As DataGridViewRow = dgAssets.Rows(e.RowIndex)

                ' Populate the input controls with the cell values
                txtUnitNumber.Text = clickedRow.Cells("Unit Number").Value.ToString()
                dtpPurchaseDate.Value = DateTime.Parse(clickedRow.Cells("Purchase Date").Value.ToString())
                txtYearAge.Text = clickedRow.Cells("Year Age").Value.ToString()
                txtIssuedTo.Text = clickedRow.Cells("Issued To").Value.ToString()
                cbDepartment.Text = clickedRow.Cells("Department").Value.ToString()
                cbBrand.Text = clickedRow.Cells("Brand").Value.ToString()
                txtModel.Text = clickedRow.Cells("Model").Value.ToString()
                txtProcessor.Text = clickedRow.Cells("Processor").Value.ToString()
                cbWindows.Text = clickedRow.Cells("Windows").Value.ToString()
                dtpO365.Value = DateTime.Parse(clickedRow.Cells("O365 Expiration").Value.ToString())
                cbActiveDirectory.Text = clickedRow.Cells("Active Directory").Value.ToString()
                txtCurrentUser.Text = clickedRow.Cells("Current User").Value.ToString()
                cbStatus.Text = clickedRow.Cells("Status").Value.ToString()
                cbAssetType.Text = clickedRow.Cells("Asset Type").Value.ToString()
            End If
        End If
    End Sub




    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Get the values from the input controls
        Dim unitNumber As Integer
        Dim yearAge As Double
        Dim purchaseDate As DateTime
        Dim issuedTo As String
        Dim department As String
        Dim brand As String
        Dim model As String ' Add the new variable for Model
        Dim processor As String
        Dim windows As String
        Dim o365Expiration As DateTime
        Dim activeDirectory As String
        Dim currentUser As String
        Dim status As String
        Dim assetType As String

        ' Exception handling for null values
        Try
            unitNumber = Integer.Parse(txtUnitNumber.Text)
            yearAge = Double.Parse(txtYearAge.Text)
            purchaseDate = dtpPurchaseDate.Value
            issuedTo = txtIssuedTo.Text
            department = cbDepartment.Text
            brand = cbBrand.Text
            model = txtModel.Text ' Get the value for Model
            processor = txtProcessor.Text
            windows = cbWindows.Text
            o365Expiration = dtpO365.Value
            activeDirectory = cbActiveDirectory.Text
            currentUser = txtCurrentUser.Text
            status = cbStatus.Text
            assetType = cbAssetType.Text
        Catch ex As Exception
            MessageBox.Show("Please enter valid values for all fields.")
            Return
        End Try

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"

        ' SQL query to update the data in the table
        Dim query As String = "UPDATE [TBmptii-assets] SET [Purchase Date] = @PurchaseDate, [Year Age] = @YearAge, [Issued To] = @IssuedTo, [Department] = @Department, [Brand] = @Brand, [Model] = @Model, [Processor] = @Processor, [Windows] = @Windows, [O365 Expiration] = @O365Expiration, [Active Directory] = @ActiveDirectory, [Asset Type] = @AssetType, [Current User] = @CurrentUser, [Status] = @Status WHERE [Unit Number] = @UnitNumber"

        ' Create a new SqlConnection using the connection string
        Using connection As New SqlConnection(connectionString)
            ' Create a new SqlCommand using the query and connection
            Using command As New SqlCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                command.Parameters.AddWithValue("@YearAge", yearAge)
                command.Parameters.AddWithValue("@IssuedTo", issuedTo)
                command.Parameters.AddWithValue("@Department", department)
                command.Parameters.AddWithValue("@Brand", brand)
                command.Parameters.AddWithValue("@Model", model) ' Add the parameter for Model
                command.Parameters.AddWithValue("@Processor", processor)
                command.Parameters.AddWithValue("@Windows", windows)
                command.Parameters.AddWithValue("@O365Expiration", o365Expiration)
                command.Parameters.AddWithValue("@ActiveDirectory", activeDirectory)
                command.Parameters.AddWithValue("@CurrentUser", currentUser)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@UnitNumber", unitNumber)
                command.Parameters.AddWithValue("@AssetType", assetType)

                ' Open the connection
                connection.Open()

                ' Execute the command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Close the connection
                connection.Close()

                ' Check if the data was successfully updated
                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated in the table successfully.")
                Else
                    MessageBox.Show("Failed to update data in the table.")
                End If
            End Using
        End Using

        ' Refresh the data in the DataGridView
        RefreshData()
    End Sub




    Private Sub pictureAccount_Click(sender As Object, e As EventArgs) Handles pictureAccount.Click
        ' Display the logout popup
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' Proceed to login form
            Dim loginForm As New loginForm()
            loginForm.Show()

            ' Close the current form if needed
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Get the original data from the class-level DataTable
        Dim filteredDataTable As DataTable = dataTable.Clone()

        ' Filter the data based on the search keyword
        Dim keyword As String = txtSearch.Text.Trim()
        If Not String.IsNullOrEmpty(keyword) Then
            For Each row As DataRow In dataTable.Rows
                For Each column As DataColumn In dataTable.Columns
                    If row(column.ColumnName).ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 Then
                        filteredDataTable.ImportRow(row)
                        Exit For ' Exit the inner loop once a match is found in the row
                    End If
                Next
            Next
        Else
            ' If the search keyword is empty, show all rows
            filteredDataTable = dataTable.Copy()
        End If

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub dtpPurchaseDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpPurchaseDate.ValueChanged
        ' Calculate the age based on the current date and the purchase date
        Dim purchaseDate As DateTime = dtpPurchaseDate.Value
        Dim currentDate As DateTime = DateTime.Now

        ' Calculate the difference in months and fractional years
        Dim totalMonths As Integer = ((currentDate.Year - purchaseDate.Year) * 12) + (currentDate.Month - purchaseDate.Month)
        Dim yearAge As Double = totalMonths / 12

        ' Display the calculated age in the corresponding textbox
        txtYearAge.Text = yearAge.ToString("0.00")
    End Sub

    Private Sub OpenNewForm(sender As Object, e As EventArgs)
        ' Create an instance of SummaryForm
        Dim summaryForm As New summaryForm()

        ' Hide the current form
        Me.Hide()

        ' Show the SummaryForm
        summaryForm.Show()
    End Sub

    Private Sub pnViewSummary_Click(sender As Object, e As EventArgs) Handles pnViewSummary.Click
        ' Call the OpenNewForm method
        OpenNewForm(sender, e)
    End Sub

    Private Sub pnViewSummary_Paint(sender As Object, e As PaintEventArgs) Handles pnViewSummary.Paint
        ' Assign the click event handler to the picture box
        AddHandler pbViewSummary.Click, AddressOf OpenNewForm

        ' Assign the click event handler to the label
        AddHandler lblViewSummary.Click, AddressOf OpenNewForm
    End Sub



End Class
