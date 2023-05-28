Imports System.Data.SqlClient

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
    End Sub



    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
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
