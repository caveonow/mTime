Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class HOLIDAY

        Public Property HOLIDAYID As Integer

        '<Display(Name:="Holiday Name")>
        Public Property HOLIDAYNAME As String
        '<Display(Name:="Start Date")>
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")>
        Public Property FROM As Date
        '<Display(Name:="End Date")>
        <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")>
        Public Property [UNTIL] As Date
        '<Display(Name:="Is In Used")>
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace


