Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class POORATTENDANCEREASON

        <Required(ErrorMessage:="Reason Code is required")>
        Public Property POORATTENDANCEREASONID As String

        <Required(ErrorMessage:="Description is required")>
        Public Property DESCRIPTION As String
        Public Property ISFORLATEIN As Boolean
        Public Property ISFOREARLYOUT As Boolean
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


