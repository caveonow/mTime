Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class HOLIDAY

        Public Property HOLIDAYID As Integer

        <Required(ErrorMessage:="Holiday Name is required")>
        <Display(Name:="Holiday Name")>
        Public Property HOLIDAYNAME As String

        <Required(ErrorMessage:="Start Date is required")>
        <Display(Name:="Start Date")>
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property FROM As Date

        <Required(ErrorMessage:="End Date is required")>
        <Display(Name:="End Date")>
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
        Public Property [UNTIL] As Date

        <Display(Name:="In Used")>
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


