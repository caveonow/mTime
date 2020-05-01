Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Private db As New model.MasterDB

        Function Index() As ActionResult
            Dim sortedList = db.ANNOUNCEMENT.Where(Function(a) Date.Compare(a.VALIDFROM, Date.Today) <= 0 And Date.Compare(a.VALIDTO, Date.Today) >= 0).ToList().OrderByDescending(Function(a) a.VALIDFROM).ToList

            ViewBag.AnnouncementList = sortedList

            Return View()
        End Function

    End Class
End Namespace