Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class ATTENDANCESTATUS

        <Required(ErrorMessage:="Attendance status is required")>
        Public Property ATTENDANCESTATUSID As String

        <Required(ErrorMessage:="Description is required")>
        Public Property DESCRIPTION As String
        <Required(ErrorMessage:="Condition is required")>
        Public Property CONDITION As String
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


