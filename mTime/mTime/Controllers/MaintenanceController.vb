Imports System.Web.Mvc

Namespace Controllers

    Public Class MaintenanceController
        Inherits Controller

        ' GET: Maintenance
        Function Index() As ActionResult
            Return View()
        End Function

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
            Return View()
        End Function

        Function AttendanceStatus() As ActionResult
            Return View()
        End Function

        Function WorkingShift() As ActionResult
            Return View()
        End Function

        Function LateTolerant() As ActionResult
            Return View()
        End Function

        ' Holiday - start

        ' have various method but this 2 is enough (HttpGet, HttpPost)
        ' default is get method
        <HttpPost>
        Public Function AddHoliday(ByVal title As String, ByVal description As String) As ActionResult
            ' Can use either of the following method to get the info
            ' Request.Form("title")
            ' Request.Form("description")
            ' title
            ' description

            Debug.WriteLine(Request.Form("title"))
            Debug.WriteLine(Request.Form("description"))
            Debug.WriteLine(title)
            Debug.WriteLine(description)

            ' Return to holiday main page without affecting the URL
            Return RedirectToAction("Holiday")
        End Function

        <HttpPost>
        Public Function EditHoliday(ByVal title As String, ByVal description As String) As ActionResult

            Return RedirectToAction("Holiday")
        End Function

        <HttpPost>
        Public Function DeleteHoliday(ByVal uuid As String) As ActionResult

            Return RedirectToAction("Holiday")
        End Function

        ' Holiday - end

    End Class

End Namespace