Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class MasterDB
        Inherits DbContext
        Public Property HYPERLINK() As DbSet(Of HYPERLINK)
        Public Property DEPARTMENT() As DbSet(Of DEPARTMENT)
        Public Property HOLIDAY() As DbSet(Of HOLIDAY)
        Public Property POORATTENDANCEREASON() As DbSet(Of POORATTENDANCEREASON)
        Public Property ATTENDANCESTATUS() As DbSet(Of ATTENDANCESTATUS)
        Public Property SHIFT() As DbSet(Of SHIFT)
        Public Property STAFF() As DbSet(Of STAFF)
        Public Property STAFFSHIFT() As DbSet(Of STAFFSHIFT)
        Public Property COMPANY() As DbSet(Of COMPANY)
        ' Public Property Staff() As DbSet(Of STAFF)
        Public Property ANNOUNCEMENT() As DbSet(Of ANNOUNCEMENT)
        Public Property PERSONALMESSAGE() As DbSet(Of PERSONALMESSAGE)
        Public Property FEEDBACK() As DbSet(Of FEEDBACK)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()

        End Sub

    End Class

End Namespace
