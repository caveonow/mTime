Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class DEPARTMENTEMPLOYEE

        Public Property TOTALCOUNT As Integer

        Public Property DEPARMENT As List(Of DEPARTMENT)

    End Class

    Public Class DEPARTMENT

        Public Property DEPARTMENTID As Integer

        <Required(ErrorMessage:="Department Name is Required")>
        Public Property DEPARTMENTNAME As String
        Public Property DIVISIONNAME As String
        Public Property UNITNAME As String
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class


End Namespace



