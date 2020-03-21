Imports System.Web.Mvc

Namespace Controllers

    Public Class AttendanceController
        Inherits Controller

        ' GET: Attendance
        Function Index() As ActionResult
            Return View()
        End Function

        Function _AdjustmentArrival() As ActionResult
            Return View()
        End Function

        Function _AttendanceRecord() As ActionResult
            Return View()
        End Function

        Function _DoorAccess() As ActionResult
            Return View()
        End Function

    End Class

End Namespace