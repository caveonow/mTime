Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class SHIFT

        <Required(ErrorMessage:="Shift Code is required")>
        Public Property SHIFTID As String
        Public Property ISISFLEXIHOUR As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART1 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND1 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR1 As Integer
        Public Property ISWORKDAY1 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART2 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND2 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR2 As Integer
        Public Property ISWORKDAY2 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART3 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND3 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR3 As Integer
        Public Property ISWORKDAY3 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART4 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND4 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR4 As Integer
        Public Property ISWORKDAY4 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART5 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND5 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR5 As Integer
        Public Property ISWORKDAY5 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART6 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND6 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR6 As Integer
        Public Property ISWORKDAY6 As Boolean

        <Required(ErrorMessage:="Start Time is required")>
        Public Property TIMEINSTART7 As TimeSpan
        <Required(ErrorMessage:="End Time is required")>
        Public Property TIMEINEND7 As TimeSpan
        <Required(ErrorMessage:="Working Hour is required")>
        Public Property WORKHOUR7 As Integer
        Public Property ISWORKDAY7 As Boolean

        <Required(ErrorMessage:="Grace Period for Late-In is required")>
        Public Property GRACEPERIODFORLATEIN As Integer

        <Required(ErrorMessage:="Grace Period for Early Out is required")>
        Public Property GRACEPERIODFOREARLYOUT As Integer

        Public Property REMARK As String
        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace