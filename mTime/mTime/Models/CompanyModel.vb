Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class COMPANY

        <Required(ErrorMessage:=" Company ID is Required")>
        Public Property COMPANYID As String
        <Required(ErrorMessage:="Company Name is Required")>
        Public Property COMPANYNAME As String
        Public Property ADDRESSLINE1 As String
        Public Property ADDRESSLINE2 As String
        Public Property ADDRESSLINE3 As String
        Public Property TELNO As String
        Public Property FAXNO As String
        Public Property COMPANYLOGOPATH As String
        Public Property COMPANYHEADERPATH As String
        Public Property HOMEPAGEHEADERPATH As String
        Public Property GRACEPERIOD As Integer
        Public Property MAXANNOUNCE As Integer
        Public Property ANNOUNCEEXPDAY As Integer
        Public Property DEFAULTLANGUAGE As String
        Public Property STARTEDON As Date
        Public Property ALLOWTOSUBMITREASONIN As Integer

    End Class

End Namespace



