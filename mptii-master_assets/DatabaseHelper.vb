Public Class DatabaseHelper
    Public Shared Function GetConnectionString() As String
        ' Replace the connection string details with your own
        Dim connectionString As String = "Data Source=192.168.1.253;Initial Catalog=OJRS;Persist Security Info=True;User ID=sa;Password=mucong-adm"
        Return connectionString
    End Function
End Class
