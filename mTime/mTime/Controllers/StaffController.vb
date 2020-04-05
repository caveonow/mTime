Imports System.Web.Mvc

Namespace Controllers
    Public Class StaffController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Staff
        Function Index() As ActionResult
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal staff As model.STAFF) As ActionResult

            If ModelState.IsValid Then

                staff.CREATEDON = Now
                staff.CREATEDBY = "Nick"

                db.STAFF.Add(staff)
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()

            End If

            Return View("index")

        End Function
    End Class
End Namespace