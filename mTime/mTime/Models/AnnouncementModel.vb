Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class ANNOUNCEMENT

        Public Property ANNOUNCEMENTID As Integer

        <Required(ErrorMessage:="Feedback is required")>
        Public Property TITLE As String
        Public Property REMARK As String
        <Required(ErrorMessage:="Valid from date is required")>
        Public Property VALIDFROM As Date
        <Required(ErrorMessage:="Valid to date is required")>
        Public Property VALIDTO As Date

        Public Property CREATEDBY As String
        Public Property CREATEDON As Date

    End Class

End Namespace