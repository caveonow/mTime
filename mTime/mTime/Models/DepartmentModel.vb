Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class DEPARTMENT

        <Required(ErrorMessage:=" Department ID is Required")>
        Public Property DEPARTMENTID As String
        <Required(ErrorMessage:="Department Name is Required")>
        Public Property DEPARTMENTNAME As String
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace



