Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class PERSONALMESSAGE

        Public Property PERSONALMESSAGEID As Integer

        <Required(ErrorMessage:="Staff is required")>
        Public Property NRIC As String

        <Required(ErrorMessage:="Title is required")>
        Public Property ABOUT As String

        <Required(ErrorMessage:="Content is required")>
        Public Property CONTENT As String

        Public Property FEEDBACKID As Nullable(Of Integer)

        Public Property ISREAD As Boolean
        Public Property READON As Nullable(Of Date)

        Public Property ISDELETED As Boolean
        Public Property DELETEBY As String
        Public Property DELETEON As Nullable(Of Date)

        Public Property CREATEDBY As String
        Public Property CREATEDON As Date

    End Class

End Namespace