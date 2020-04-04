Imports System.Net
Imports mTime
Imports System.Web.Mvc

Namespace Controllers
    Public Class DepartmentController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Department
        Function Index() As ActionResult
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal department As model.DEPARTMENT) As ActionResult

            Dim blnIsDuplicated As Boolean

            'blnIsDuplicated = db.Department.Any(Function(model) model.DEPARTMENTNAME = department.DEPARTMENTNAME)

            'If blnIsDuplicated = True Then
            '    ModelState.AddModelError("DEPARTMENTNAME", "Title is duplicated")
            'Else
            '    If (ValidateURL(HyperLink.URL)) = False Then
            '        ModelState.AddModelError("URL", "URL is invalid")
            '    End If
            'End If

            If ModelState.IsValid Then

                department.CREATEDON = Now
                department.CREATEDBY = "Nick"

                db.Department.Add(department)
                db.SaveChanges()

                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View()

            End If

            Return View("Department")

        End Function


    End Class
End Namespace