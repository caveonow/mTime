Imports System.Net
Imports mTime
Imports System.Web.Mvc
Imports mTime.model


Namespace Controllers
    Public Class DepartmentController
        Inherits Controller

        Private db As New model.MasterDB

        Function Index() As ActionResult

            db.

            Dim sortedList = From d In db.DEPARTMENT
                             Order By d.DEPARTMENTNAME Ascending, d.DIVISIONNAME Ascending, d.UNITNAME Ascending
                             Select d

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

            blnIsDuplicated = db.DEPARTMENT.Any(Function(model) model.DEPARTMENTNAME = department.DEPARTMENTNAME And
                                                    model.DIVISIONNAME = department.DIVISIONNAME And
                                                    model.UNITNAME = department.UNITNAME)


            If blnIsDuplicated = True Then
                ModelState.AddModelError("DEPARTMENTNAME", "Department Name is duplicated")
            End If

            If ModelState.IsValid Then

                department.ISINUSED = True
                department.CREATEDON = Now
                department.CREATEDBY = "Nick"

                db.DEPARTMENT.Add(department)
                db.SaveChanges()

                ViewBag.Result = "OK"

                Return View()

            End If

            Return View(department)

        End Function

        ' GET : Edit-Department
        Function Edit(ByVal id As Integer) As ActionResult

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
        Function Edit(<Bind(Include:="DEPARTMENTID, DEPARTMENTNAME, DIVISIONNAME, UNITNAME, ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal Department As DEPARTMENT) As ActionResult

            blnIsDuplicated = db.DEPARTMENT.Any(Function(model) model.DEPARTMENTNAME = Department.DEPARTMENTNAME And
                                          model.DIVISIONNAME = Department.DIVISIONNAME And
                                                    model.UNITNAME = Department.UNITNAME)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("DEPARTMENTNAME", "Department Name is duplicated")
            End If

            If ModelState.IsValid Then

                Department.UPDATEDBY = "NICK"
                Department.UPDATEDON = Now

                db.Entry(Department).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ViewBag.Result = "OK"

                Return View()

            End If

            Return View(Department)
        End Function

        ' GET : Delete-Department
        Function Delete(ByVal id As Integer) As ActionResult

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
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult

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