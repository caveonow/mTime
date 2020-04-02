Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class HYPERLINK


        Public Property HYPERLINKID As Integer

        <Required(ErrorMessage:="Title is required")>
        Public Property TITLE As String

        <Required(ErrorMessage:="URL is required")>
        Public Property URL As String

        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

    Public Class MasterDB
        Inherits DbContext
        Public Property HYPERLINK() As DbSet(Of HYPERLINK)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()

        End Sub

    End Class

End Namespace


