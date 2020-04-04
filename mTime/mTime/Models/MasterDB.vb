Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class MasterDB
        Inherits DbContext
        Public Property HYPERLINK() As DbSet(Of HYPERLINK)
        Public Property DEPARTMENT() As DbSet(Of DEPARTMENT)

        Public Property POORATTENDANCEREASON() As DbSet(Of POORATTENDANCEREASON)


        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()

        End Sub

    End Class

End Namespace
