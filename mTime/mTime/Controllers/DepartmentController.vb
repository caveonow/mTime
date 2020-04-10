Imports System.Net
Imports mTime
Imports System.Web.Mvc
Imports mTime.model


Namespace Controllers
    Public Class DepartmentController
        Inherits Controller

        Private db As New model.MasterDB

        Function Index() As ActionResult
            Dim sortedList = db.DEPARTMENT.SortBy("DEPARTMENTID").ToList

            '# Return updated dataset
            Return View(sortedList)
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

                db.DEPARTMENT.Add(department)
                db.SaveChanges()

                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View()

            End If

            Return View("Department")

        End Function

        ' GET : Edit-Department
        Function Edit(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim Department As model.DEPARTMENT = db.DEPARTMENT.Find(id)

            If IsNothing(Department) Then
                Return HttpNotFound()
            End If

            Return View(Department)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="DEPARTMENTID, DEPARTMENTNAME, ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal DEPARTMENTItem As DEPARTMENT) As ActionResult

            'If (ValidateURL(hyperlink.URL)) = False Then
            '    ModelState.AddModelError("URL", "URL is invalid")
            'End If

            If ModelState.IsValid Then

                DEPARTMENTItem.UPDATEDBY = "NICK"
                DEPARTMENTItem.UPDATEDON = Now

                db.Entry(DEPARTMENTItem).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ''# Return to Index 
                'Return RedirectToRoute("HyperlinkList")

                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View(DEPARTMENTItem)

            End If

            Return View("Department")
        End Function

        ' GET : Delete-Department
        Function Delete(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim department As model.DEPARTMENT = db.DEPARTMENT.Find(id)

            If IsNothing(department) Then
                Return HttpNotFound()
            End If
            Return View(department)

        End Function


        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As String) As ActionResult

            Dim department As model.DEPARTMENT = db.DEPARTMENT.Find(id)
            db.DEPARTMENT.Remove(department)
            db.SaveChanges()

            '# Return to Index
            ViewBag.Result = "OK"
            Return View(department)

        End Function

        Protected Overrides Sub Dispose(disposing As Boolean)

            If (disposing) Then
                db.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace