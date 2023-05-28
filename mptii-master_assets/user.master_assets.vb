Imports System.Data.SqlClient
Imports System.DirectoryServices

Public Class userForm
    Private dataTable As DataTable ' Declare a class-level variable to hold the data

    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Check if any rows are found
        If filteredDataTable.Rows.Count > 0 Then
            ' Bind the filtered data to the DataGridView
            dgAssets.DataSource = filteredDataTable
        Else
            ' Display a custom message when no matching rows are found
            MessageBox.Show("No results found for the search criteria.")
        End If
    End Sub

    Private Sub pbClearButton_Click(sender As Object, e As EventArgs) Handles pbClearButton.Click
        txtSearch.Text = String.Empty
    End Sub

    Private Sub pbDesktop_Click(sender As Object, e As EventArgs) Handles pbDesktop.Click
        ' Get the original data from the class-level DataTable
        Dim filteredDataTable As DataTable = dataTable.Clone()

        ' Filter the data to show only desktop asset type
        For Each row As DataRow In dataTable.Rows
            Dim cellValue As Object = row("Asset Type")
            If cellValue IsNot Nothing AndAlso cellValue.ToString() = "Desktop" Then
                filteredDataTable.ImportRow(row)
            End If
        Next

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub pbLaptop_Click(sender As Object, e As EventArgs) Handles pbLaptop.Click
        ' Get the original data from the class-level DataTable
        Dim filteredDataTable As DataTable = dataTable.Clone()

        ' Filter the data to show only laptop asset type
        For Each row As DataRow In dataTable.Rows
            Dim cellValue As Object = row("Asset Type")
            If cellValue IsNot Nothing AndAlso cellValue.ToString() = "Laptop" Then
                filteredDataTable.ImportRow(row)
            End If
        Next

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub pbTotal_Click(sender As Object, e As EventArgs) Handles pbTotal.Click
        ' Bind the original data to the DataGridView
        dgAssets.DataSource = dataTable
    End Sub

    Private Sub pbActive_Click(sender As Object, e As EventArgs) Handles pbActive.Click
        ' Get the active assets from the original data
        Dim filteredDataTable As DataTable = dataTable.Clone()

        For Each row As DataRow In dataTable.Rows
            Dim status As String = row("Status").ToString()
            If status = "Active" Then
                filteredDataTable.ImportRow(row)
            End If
        Next

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub pbInactive_Click(sender As Object, e As EventArgs) Handles pbInactive.Click
        ' Get the inactive assets from the original data
        Dim filteredDataTable As DataTable = dataTable.Clone()

        For Each row As DataRow In dataTable.Rows
            Dim status As String = row("Status").ToString()
            If status = "Inactive" Then
                filteredDataTable.ImportRow(row)
            End If
        Next

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub pbDispose_Click(sender As Object, e As EventArgs) Handles pbDispose.Click
        ' Get the active assets from the original data
        Dim filteredDataTable As DataTable = dataTable.Clone()

        For Each row As DataRow In dataTable.Rows
            Dim status As String = row("Status").ToString()
            If status = "Dispose" Then
                filteredDataTable.ImportRow(row)
            End If
        Next

        ' Bind the filtered data to the DataGridView
        dgAssets.DataSource = filteredDataTable
    End Sub

    Private Sub RefreshData()

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RefreshData() ' Call the RefreshData function to refresh the data
    End Sub
End Class
