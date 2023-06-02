Imports System.Data.SqlClient

Public Class summaryForm
    Private Sub summaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the border color of the Asset Type Panel
        pnMainBoxDesktop.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxDesktop.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxLaptop.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxLaptop.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxTotal.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxTotal.BorderStyle = BorderStyle.FixedSingle

        ' Set the border color of the Status Panel
        pnMainBoxActive.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxActive.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxInactive.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxInactive.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxDispose.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxDispose.BorderStyle = BorderStyle.FixedSingle

        ' Set the border color of the Department Panel
        pnMainBoxHR.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxHR.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxIT.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxIT.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxMarketing.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxMarketing.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxSales.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxSales.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxAccounting.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxAccounting.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxFinance.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxFinance.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxCreative.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxCreative.BorderStyle = BorderStyle.FixedSingle

        ' Set the border color of the Brand Panel
        pnMainBoxAcer.BorderStyle = BorderStyle.FixedSingle
        pnMainBoxDell.BorderStyle = BorderStyle.FixedSingle
        pnMainBoxLenovo.BorderStyle = BorderStyle.FixedSingle

        ' Set the border color of the Year Age Panel
        pnMainBox3Below.BorderStyle = BorderStyle.FixedSingle
        pnSubBox3Below.BorderStyle = BorderStyle.FixedSingle

        pnMainBoxBetween.BorderStyle = BorderStyle.FixedSingle
        pnSubBoxBetween.BorderStyle = BorderStyle.FixedSingle

        pnMainBox5Above.BorderStyle = BorderStyle.FixedSingle
        pnSubBox5Above.BorderStyle = BorderStyle.FixedSingle

        ' Update the lblDesktopNumber label with the count of desktops
        Dim desktopCount As Integer = GetAssetCount("Desktop")
        lblDesktopNumber.Text = desktopCount.ToString()

        ' Update the lblLaptopNumber label with the count of laptops
        Dim laptopCount As Integer = GetAssetCount("Laptop")
        lblLaptopNumber.Text = laptopCount.ToString()

        ' Update the lblTotalNumber label with the total count of all rows
        Dim totalCount As Integer = GetTotalCount()
        lblTotalNumber.Text = totalCount.ToString()

        ' Update the lblActiveNumber label with the count of rows with status "Active"
        Dim activeCount As Integer = GetStatusCount("Active")
        lblActiveNumber.Text = activeCount.ToString()

        ' Update the lblInactiveNumber label with the count of rows with status "Inactive"
        Dim inactiveCount As Integer = GetStatusCount("Inactive")
        lblInactiveNumber.Text = inactiveCount.ToString()

        ' Update the lblDisposeNumber label with the count of rows with status "Dispose"
        Dim disposeCount As Integer = GetStatusCount("Dispose")
        lblDisposeNumber.Text = inactiveCount.ToString()

        ' Update the lblAcerNumber label with the count of rows with brand "Acer"
        Dim acerCount As Integer = GetBrandCount("Acer")
        lblAcerNumber.Text = acerCount.ToString()

        ' Update the lblDellNumber label with the count of rows with brand "Dell"
        Dim dellCount As Integer = GetBrandCount("Dell")
        lblDellNumber.Text = dellCount.ToString()

        ' Update the lblDellNumber label with the count of rows with brand "Dell"
        Dim lenovoCount As Integer = GetBrandCount("Lenovo")
        lblLenovoNumber.Text = lenovoCount.ToString()

        ' Update the lblDellNumber label with the count of rows with brand "Dell"
        Dim hrCount As Integer = GetDepartmentCount("HR")
        lblHRNumber.Text = hrCount.ToString()

        ' Update the lblITNumber label with the count of rows with department "IT"
        Dim itCount As Integer = GetDepartmentCount("IT")
        lblITNumber.Text = itCount.ToString()

        ' Update the lblMarketingNumber label with the count of rows with department "Marketing"
        Dim marketingCount As Integer = GetDepartmentCount("Marketing")
        lblMarketingNumber.Text = marketingCount.ToString()

        ' Update the lblSalesNumber label with the count of rows with department "Sales"
        Dim salesCount As Integer = GetDepartmentCount("Sales")
        lblSalesNumber.Text = salesCount.ToString()

        ' Update the lblAccountingNumber label with the count of rows with department "Accounting"
        Dim accountingCount As Integer = GetDepartmentCount("Accounting")
        lblAccountingNumber.Text = accountingCount.ToString()

        ' Update the lblFinanceNumber label with the count of rows with department "Finance"
        Dim financeCount As Integer = GetDepartmentCount("Finance")
        lblFinanceNumber.Text = financeCount.ToString()

        ' Update the lblFinanceNumber label with the count of rows with department "Finance"
        Dim creativeCount As Integer = GetDepartmentCount("Creative")
        lblCreativeNumber.Text = creativeCount.ToString()


        ' Update the lblBelowYears, lblBetweenYears, and lblAboveYears labels with the count of values in the "Year Age" column
        Dim belowYearsCount As Integer = GetAgeRangeCount(0, 3)
        lblBelowYears.Text = belowYearsCount.ToString()

        Dim betweenYearsCount As Integer = GetAgeRangeCount(3, 5)
        lblBetweenYears.Text = betweenYearsCount.ToString()

        Dim aboveYearsCount As Integer = GetAgeRangeCount(5, Single.MaxValue)
        lblAboveYears.Text = aboveYearsCount.ToString()
    End Sub

    Private Function GetAssetCount(assetType As String) As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = $"SELECT COUNT(*) AS AssetCount FROM [OJRS].[dbo].[TBmptii-assets] WHERE [Asset Type] = '{assetType}'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim assetCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return assetCount
            End Using
        End Using
    End Function

    Private Function GetTotalCount() As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = "SELECT COUNT(*) AS TotalCount FROM [OJRS].[dbo].[TBmptii-assets]"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim totalCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return totalCount
            End Using
        End Using
    End Function

    Private Function GetStatusCount(status As String) As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = $"SELECT COUNT(*) AS StatusCount FROM [OJRS].[dbo].[TBmptii-assets] WHERE [Status] = '{status}'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim statusCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return statusCount
            End Using
        End Using
    End Function

    Private Function GetBrandCount(brand As String) As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = $"SELECT COUNT(*) AS BrandCount FROM [OJRS].[dbo].[TBmptii-assets] WHERE [Brand] = '{brand}'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim brandCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return brandCount
            End Using
        End Using
    End Function

    Private Function GetDepartmentCount(department As String) As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = $"SELECT COUNT(*) AS BrandCount FROM [OJRS].[dbo].[TBmptii-assets] WHERE [Department] = '{department}'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim departmentCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return departmentCount
            End Using
        End Using
    End Function

    Private Function GetAgeRangeCount(minYears As Single, maxYears As Single) As Integer
        Dim connectionString As String = DatabaseHelper.GetConnectionString()
        Dim query As String = $"SELECT COUNT(*) AS AgeRangeCount FROM [OJRS].[dbo].[TBmptii-assets] WHERE [Year Age] >= {minYears} AND [Year Age] < {maxYears}"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim ageRangeCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return ageRangeCount
            End Using
        End Using
    End Function


    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' Create an instance of the adminForm
        Dim adminForm As New adminForm()

        ' Show the adminForm
        adminForm.Show()

        ' Hide the current form
        Me.Hide()
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

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        ' Update the lblDesktopNumber label with the count of desktops
        Dim desktopCount As Integer = GetAssetCount("Desktop")
        lblDesktopNumber.Text = desktopCount.ToString()

        ' Update the lblLaptopNumber label with the count of laptops
        Dim laptopCount As Integer = GetAssetCount("Laptop")
        lblLaptopNumber.Text = laptopCount.ToString()

        ' Update the lblTotalNumber label with the total count of all rows
        Dim totalCount As Integer = GetTotalCount()
        lblTotalNumber.Text = totalCount.ToString()

        ' Update the lblActiveNumber label with the count of rows with status "Active"
        Dim activeCount As Integer = GetStatusCount("Active")
        lblActiveNumber.Text = activeCount.ToString()

        ' Update the lblInactiveNumber label with the count of rows with status "Inactive"
        Dim inactiveCount As Integer = GetStatusCount("Inactive")
        lblInactiveNumber.Text = inactiveCount.ToString()

        ' Update the lblDisposeNumber label with the count of rows with status "Dispose"
        Dim disposeCount As Integer = GetStatusCount("Dispose")
        lblDisposeNumber.Text = disposeCount.ToString()

        ' Update the lblAcerNumber label with the count of rows with brand "Acer"
        Dim acerCount As Integer = GetBrandCount("Acer")
        lblAcerNumber.Text = acerCount.ToString()

        ' Update the lblDellNumber label with the count of rows with brand "Dell"
        Dim dellCount As Integer = GetBrandCount("Dell")
        lblDellNumber.Text = dellCount.ToString()

        ' Update the lblLenovoNumber label with the count of rows with brand "Lenovo"
        Dim lenovoCount As Integer = GetBrandCount("Lenovo")
        lblLenovoNumber.Text = lenovoCount.ToString()

        ' Update the lblHRNumber label with the count of rows with department "HR"
        Dim hrCount As Integer = GetDepartmentCount("HR")
        lblHRNumber.Text = hrCount.ToString()

        ' Update the lblITNumber label with the count of rows with department "IT"
        Dim itCount As Integer = GetDepartmentCount("IT")
        lblITNumber.Text = itCount.ToString()

        ' Update the lblMarketingNumber label with the count of rows with department "Marketing"
        Dim marketingCount As Integer = GetDepartmentCount("Marketing")
        lblMarketingNumber.Text = marketingCount.ToString()

        ' Update the lblSalesNumber label with the count of rows with department "Sales"
        Dim salesCount As Integer = GetDepartmentCount("Sales")
        lblSalesNumber.Text = salesCount.ToString()

        ' Update the lblAccountingNumber label with the count of rows with department "Accounting"
        Dim accountingCount As Integer = GetDepartmentCount("Accounting")
        lblAccountingNumber.Text = accountingCount.ToString()

        ' Update the lblFinanceNumber label with the count of rows with department "Finance"
        Dim financeCount As Integer = GetDepartmentCount("Finance")
        lblFinanceNumber.Text = financeCount.ToString()

        ' Update the lblCreativeNumber label with the count of rows with department "Creative"
        Dim creativeCount As Integer = GetDepartmentCount("Creative")
        lblCreativeNumber.Text = creativeCount.ToString()

        ' Update the lblBelowYears, lblBetweenYears, and lblAboveYears labels with the count of values in the "Year Age" column
        Dim belowYearsCount As Integer = GetAgeRangeCount(0, 3)
        lblBelowYears.Text = belowYearsCount.ToString()

        Dim betweenYearsCount As Integer = GetAgeRangeCount(3, 5)
        lblBetweenYears.Text = betweenYearsCount.ToString()

        Dim aboveYearsCount As Integer = GetAgeRangeCount(5, Single.MaxValue)
        lblAboveYears.Text = aboveYearsCount.ToString()
    End Sub

End Class
