Imports System.Web.Mvc
Imports System.Net

Namespace Controllers

    Public Class MaintenanceController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Hyperlink
        Function Index() As ActionResult

            ViewBag.TotalCount = db.HYPERLINK.ToList.Count

            'Dim hyperlink As model.HYPERLINK = db.HYPERLINK.ToList

            '# Return updated dataset
            Return View(db.HYPERLINK.ToList)
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

    End Class

End Namespace