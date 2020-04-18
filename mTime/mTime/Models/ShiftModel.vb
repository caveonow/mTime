Imports System.ComponentModel.DataAnnotations

Namespace model

    Public Class SHIFT

        <Required(ErrorMessage:="Shift Code is required")>
        Public Property SHIFTID As String
        Public Property REMARK As String

        Public Property ISFLEXIHOUR As Boolean

        Public Property TIMEINSTART1 As Nullable(Of TimeSpan)
        Public Property TIMEINEND1 As Nullable(Of TimeSpan)
        Public Property WORKHOUR1 As Nullable(Of Integer)
        Public Property ISWORKDAY1 As Boolean

        Public Property TIMEINSTART2 As Nullable(Of TimeSpan)
        Public Property TIMEINEND2 As Nullable(Of TimeSpan)
        Public Property WORKHOUR2 As Nullable(Of Integer)
        Public Property ISWORKDAY2 As Boolean

        Public Property TIMEINSTART3 As Nullable(Of TimeSpan)
        Public Property TIMEINEND3 As Nullable(Of TimeSpan)
        Public Property WORKHOUR3 As Nullable(Of Integer)
        Public Property ISWORKDAY3 As Boolean

        Public Property TIMEINSTART4 As Nullable(Of TimeSpan)
        Public Property TIMEINEND4 As Nullable(Of TimeSpan)
        Public Property WORKHOUR4 As Nullable(Of Integer)
        Public Property ISWORKDAY4 As Boolean

        Public Property TIMEINSTART5 As Nullable(Of TimeSpan)
        Public Property TIMEINEND5 As Nullable(Of TimeSpan)
        Public Property WORKHOUR5 As Nullable(Of Integer)
        Public Property ISWORKDAY5 As Boolean

        Public Property TIMEINSTART6 As Nullable(Of TimeSpan)
        Public Property TIMEINEND6 As Nullable(Of TimeSpan)
        Public Property WORKHOUR6 As Nullable(Of Integer)
        Public Property ISWORKDAY6 As Boolean

        Public Property TIMEINSTART7 As Nullable(Of TimeSpan)
        Public Property TIMEINEND7 As Nullable(Of TimeSpan)
        Public Property WORKHOUR7 As Nullable(Of Integer)
        Public Property ISWORKDAY7 As Boolean

        Public Property ISINUSED As Boolean
        Public Property CREATEDBY As String
        Public Property CREATEDON As Date
        Public Property UPDATEDBY As String
        Public Property UPDATEDON As Nullable(Of Date)

    End Class

End Namespace