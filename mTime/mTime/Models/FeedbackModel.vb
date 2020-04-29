Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class FEEDBACK

        Public Property FEEDBACKID As Integer
        Public Property NRIC As String
        <Required(ErrorMessage:="Feedback is required")>
        Public Property CONTENT As String
        Public Property ISREPLIED As Boolean

        Public Property REPLIEDBY As String
        Public Property REPLIEDON As Nullable(Of Date)

        Public Property CREATEDBY As String
        Public Property CREATEDON As Nullable(Of Date)

    End Class

End Namespace