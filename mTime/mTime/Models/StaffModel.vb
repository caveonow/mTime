Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class STAFF

        <Required(ErrorMessage:="NRIC is required")>
        Public Property NRIC As String
        <Required(ErrorMessage:="STAFFNO is required")>
        Public Property STAFFNO As String
        <Required(ErrorMessage:="FIRSTNAME is required")>
        Public Property FIRSTNAME As String
        Public Property LASTNAME As String
        <Required(ErrorMessage:="STAFFGROUPID is required")>
        Public Property STAFFGROUPID As String
        Public Property GENDER As String
        Public Property GRADE As String
        Public Property CONTACTNO1 As String
        Public Property CONTACTNO2 As String
        Public Property ADDRESS As String
        Public Property EMAIL As String
        Public Property DEPARTMENTID As String
        Public Property STATUS As String
        Public Property PASSWORD As String
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


