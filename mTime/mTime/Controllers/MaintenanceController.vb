Imports System.Web.Mvc
Imports System.Net

Namespace Controllers

    Public Class MaintenanceController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Hyperlink
        Function Index() As ActionResult

            Dim sortedList = db.HYPERLINK.SortBy("TITLE").ToList

            'db.HYPERLINK.ToList

            '# Return updated dataset
            Return View(sortedList)
        End Function

        '' GET: Maintenance
        'Function Index() As ActionResult

        '    Return View()

        'End Function

        Function Holiday() As ActionResult
            Return View()
        End Function

        Function Department() As ActionResult
            Return View()
        End Function

        Function Grade() As ActionResult
            Return View()
        End Function

        Function Reason() As ActionResult
            Dim sortedList = db.POORATTENDANCEREASON.SortBy("POORATTENDANCEREASONID").ToList

            Debug.Print("OK")

            '# Return updated dataset
            Return View(sortedList)
        End Function

        Function AttendanceStatus() As ActionResult
            Dim sortedList = db.ATTENDANCESTATUS.SortBy("ATTENDANCESTATUSID").ToList

            Return View(sortedList)
        End Function

        Function WorkingShift() As ActionResult
            Return View()
        End Function

        Function LateTolerant() As ActionResult
            Return View()
        End Function

    End Class

End Namespace