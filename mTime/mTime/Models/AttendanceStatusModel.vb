Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class ATTENDANCESTATUS

        <Required(ErrorMessage:="Attendance Status Code is required")>
        Public Property ATTENDANCESTATUSID As String

        <Required(ErrorMessage:="Description is required")>
        Public Property DESCRIPTION As String

        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


