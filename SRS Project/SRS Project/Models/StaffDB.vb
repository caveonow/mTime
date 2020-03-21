Imports System.Data.Entity

Namespace Model
    Public Class StaffDB
        Public Property NRIC As Integer
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Password As String

    End Class

    Public Class StaffDbContext
        Inherits DbContext

        Public Property Movies As DbSet(Of StaffDB)
    End Class

End Namespace