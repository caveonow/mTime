Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class SHIFT

        <Required(ErrorMessage:="Shift code is required")>
        Public Property SHIFTID As String

        <Required(ErrorMessage:="Monday start time is required")>
        Public Property FLEXISTARTTIMEFROM1 As TimeSpan
        <Required(ErrorMessage:="Monday end time is required")>
        Public Property FLEXISTARTTIMETO1 As TimeSpan
        <Required(ErrorMessage:="Monday working hour is required")>
        Public Property WORKHOUR1 As Integer
        Public Property ISOFFDAY1 As Boolean

        <Required(ErrorMessage:="Tuesday start time is required")>
        Public Property FLEXISTARTTIMEFROM2 As TimeSpan
        <Required(ErrorMessage:="Tuesday end time is required")>
        Public Property FLEXISTARTTIMETO2 As TimeSpan
        <Required(ErrorMessage:="Tuesday working hour is required")>
        Public Property WORKHOUR2 As Integer
        Public Property ISOFFDAY2 As Boolean

        <Required(ErrorMessage:="Wednesday start time is required")>
        Public Property FLEXISTARTTIMEFROM3 As TimeSpan
        <Required(ErrorMessage:="Wednesday end time is required")>
        Public Property FLEXISTARTTIMETO3 As TimeSpan
        <Required(ErrorMessage:="Wednesday working hour is required")>
        Public Property WORKHOUR3 As Integer
        Public Property ISOFFDAY3 As Boolean

        <Required(ErrorMessage:="Thursday start time is required")>
        Public Property FLEXISTARTTIMEFROM4 As TimeSpan
        <Required(ErrorMessage:="Thursday end time is required")>
        Public Property FLEXISTARTTIMETO4 As TimeSpan
        <Required(ErrorMessage:="Thursday working hour is required")>
        Public Property WORKHOUR4 As Integer
        Public Property ISOFFDAY4 As Boolean

        <Required(ErrorMessage:="Friday start time is required")>
        Public Property FLEXISTARTTIMEFROM5 As TimeSpan
        <Required(ErrorMessage:="Friday end time is required")>
        Public Property FLEXISTARTTIMETO5 As TimeSpan
        <Required(ErrorMessage:="Friday working hour is required")>
        Public Property WORKHOUR5 As Integer
        Public Property ISOFFDAY5 As Boolean

        <Required(ErrorMessage:="Saturday start time is required")>
        Public Property FLEXISTARTTIMEFROM6 As TimeSpan
        <Required(ErrorMessage:="Saturday end time is required")>
        Public Property FLEXISTARTTIMETO6 As TimeSpan
        <Required(ErrorMessage:="Saturday working hour is required")>
        Public Property WORKHOUR6 As Integer
        Public Property ISOFFDAY6 As Boolean

        <Required(ErrorMessage:="Sunday start time is required")>
        Public Property FLEXISTARTTIMEFROM7 As TimeSpan
        <Required(ErrorMessage:="Sunday end time is required")>
        Public Property FLEXISTARTTIMETO7 As TimeSpan
        <Required(ErrorMessage:="Sunday working hour is required")>
        Public Property WORKHOUR7 As Integer
        Public Property ISOFFDAY7 As Boolean

        <Required(ErrorMessage:="Grace period for late in is required")>
        Public Property GRACEPERIODFORLATEIN As Integer
        <Required(ErrorMessage:="Grace period for early out is required")>
        Public Property GRACEPERIODFOREARLYOUT As Integer

        Public Property REMARK As String

        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace