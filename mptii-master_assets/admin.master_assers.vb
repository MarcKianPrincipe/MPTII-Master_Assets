Imports System.Data.SqlClient

Public Class adminForm
    Private laptopNumber As Integer
    Private dataTable As DataTable ' Declare a class-level variable to hold the data

    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"

        ' SQL query to fetch the data from the table
        Dim query As String = "SELECT [Laptop Number], [Purchase Date], [Year Age], [Isuued To], [Department], [Brand], [Processor], [Windows], [O365 Expiration], [Active Directory] FROM [TBmptii-assets]"

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
        ' Set the font size of the text in the table
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the values from the input controls
        Dim yearAge As Double
        Dim purchaseDate As DateTime
        Dim issuedTo As String
        Dim department As String
        Dim brand As String
        Dim processor As String
        Dim windows As String
        Dim o365Expiration As String
        Dim activeDirectory As String

        ' Exception handling for null values
        Try
            yearAge = Double.Parse(txtYearAge.Text)
            purchaseDate = dtpPurchaseDate.Value
            issuedTo = txtIssuedTo.Text
            department = cbDepartment.Text
            brand = txtBrand.Text
            processor = txtProcessor.Text
            windows = cbWindows.Text
            o365Expiration = txtOffice.Text
            activeDirectory = cbActiveDirectory.Text
        Catch ex As Exception
            MessageBox.Show("Please enter valid values for all fields.")
            Return
        End Try

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"

        ' SQL query to get the maximum existing laptop number
        Dim maxLaptopNumberQuery As String = "SELECT MAX([Laptop Number]) FROM [TBmptii-assets]"

        ' Create a new SqlConnection using the connection string
        Using connection As New SqlConnection(connectionString)
            ' Create a new SqlCommand to execute the maxLaptopNumberQuery
            Using command As New SqlCommand(maxLaptopNumberQuery, connection)
                ' Open the connection
                connection.Open()

                ' Execute the maxLaptopNumberQuery and retrieve the maximum laptop number
                Dim maxLaptopNumber As Object = command.ExecuteScalar()

                ' Check if a maximum laptop number exists
                If maxLaptopNumber IsNot DBNull.Value Then
                    ' Increment the maximum laptop number by 1 to get the new laptop number
                    laptopNumber = Convert.ToInt32(maxLaptopNumber) + 1
                Else
                    ' If no laptop number exists, start from 1
                    laptopNumber = 1
                End If

                ' SQL query to insert the data into the table
                Dim query As String = "INSERT INTO [TBmptii-assets] ([Laptop Number], [Purchase Date], [Year Age], [Isuued To], [Department], [Brand], [Processor], [Windows], [O365 Expiration], [Active Directory]) VALUES (@LaptopNumber, @PurchaseDate, @YearAge, @IssuedTo, @Department, @Brand, @Processor, @Windows, @O365Expiration, @ActiveDirectory)"

                ' Create a new SqlCommand using the query and connection
                Using insertCommand As New SqlCommand(query, connection)
                    ' Add parameters to the insertCommand
                    insertCommand.Parameters.AddWithValue("@LaptopNumber", laptopNumber)
                    insertCommand.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                    insertCommand.Parameters.AddWithValue("@YearAge", yearAge)
                    insertCommand.Parameters.AddWithValue("@IssuedTo", issuedTo)
                    insertCommand.Parameters.AddWithValue("@Department", department)
                    insertCommand.Parameters.AddWithValue("@Brand", brand)
                    insertCommand.Parameters.AddWithValue("@Processor", processor)
                    insertCommand.Parameters.AddWithValue("@Windows", windows)
                    insertCommand.Parameters.AddWithValue("@O365Expiration", o365Expiration)
                    insertCommand.Parameters.AddWithValue("@ActiveDirectory", activeDirectory)

                    ' Execute the insertCommand
                    Dim rowsAffected As Integer = insertCommand.ExecuteNonQuery()

                    ' Close the connection
                    connection.Close()

                    ' Check if the data was successfully inserted
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data added to the table successfully.")
                    Else
                        MessageBox.Show("Failed to add data to the table.")
                    End If
                End Using
            End Using
        End Using

        ' Refresh the data in the DataGridView
        RefreshData()
    End Sub




    Private Sub RefreshData()
        ' Clear the input controls
        txtLaptopNumber.Text = String.Empty
        dtpPurchaseDate.Value = DateTime.Now
        txtYearAge.Text = String.Empty
        txtIssuedTo.Text = String.Empty
        cbDepartment.Text = String.Empty
        txtBrand.Text = String.Empty
        txtProcessor.Text = String.Empty
        cbWindows.Text = String.Empty
        txtOffice.Text = String.Empty
        cbActiveDirectory.Text = String.Empty

        ' Retrieve the updated data from the database and bind it to the table form controls
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"
        Dim query As String = "SELECT * FROM [TBmptii-assets] ORDER BY [Laptop Number] ASC"

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
                txtLaptopNumber.Text = clickedRow.Cells("Laptop Number").Value.ToString()
                dtpPurchaseDate.Value = DateTime.Parse(clickedRow.Cells("Purchase Date").Value.ToString())
                txtYearAge.Text = clickedRow.Cells("Year Age").Value.ToString()
                txtIssuedTo.Text = clickedRow.Cells("Isuued To").Value.ToString()
                cbDepartment.Text = clickedRow.Cells("Department").Value.ToString()
                txtBrand.Text = clickedRow.Cells("Brand").Value.ToString()
                txtProcessor.Text = clickedRow.Cells("Processor").Value.ToString()
                cbWindows.Text = clickedRow.Cells("Windows").Value.ToString()
                txtOffice.Text = clickedRow.Cells("O365 Expiration").Value.ToString()
                cbActiveDirectory.Text = clickedRow.Cells("Active Directory").Value.ToString()
            End If
        End If
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Get the values from the input controls
        Dim laptopNumber As Integer
        Dim yearAge As Double
        Dim purchaseDate As DateTime
        Dim issuedTo As String
        Dim department As String
        Dim brand As String
        Dim processor As String
        Dim windows As String
        Dim o365Expiration As String
        Dim activeDirectory As String

        ' Exception handling for null values
        Try
            laptopNumber = Integer.Parse(txtLaptopNumber.Text)
            yearAge = Double.Parse(txtYearAge.Text)
            purchaseDate = dtpPurchaseDate.Value
            issuedTo = txtIssuedTo.Text
            department = cbDepartment.Text
            brand = txtBrand.Text
            processor = txtProcessor.Text
            windows = cbWindows.Text
            o365Expiration = txtOffice.Text
            activeDirectory = cbActiveDirectory.Text
        Catch ex As Exception
            MessageBox.Show("Please enter valid values for all fields.")
            Return
        End Try

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=MKP-PERSONAL\SQLEXPRESS01;Initial Catalog=DBmptii_master-asset;Persist Security Info=True;User ID=sa;Password=password"

        ' SQL query to update the data in the table
        Dim query As String = "UPDATE [TBmptii-assets] SET [Purchase Date] = @PurchaseDate, [Year Age] = @YearAge, [Isuued To] = @IssuedTo, [Department] = @Department, [Brand] = @Brand, [Processor] = @Processor, [Windows] = @Windows, [O365 Expiration] = @O365Expiration, [Active Directory] = @ActiveDirectory WHERE [Laptop Number] = @LaptopNumber"

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
                command.Parameters.AddWithValue("@Processor", processor)
                command.Parameters.AddWithValue("@Windows", windows)
                command.Parameters.AddWithValue("@O365Expiration", o365Expiration)
                command.Parameters.AddWithValue("@ActiveDirectory", activeDirectory)
                command.Parameters.AddWithValue("@LaptopNumber", laptopNumber)

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

End Class
