Imports System.Net
Imports mTime

Namespace Controllers

    <RoutePrefix("Reason")>
    Public Class AttendanceStatusController
        Inherits Controller

        Private db As New model.MasterDB

        Function Index() As ActionResult
            Dim sortedList = db.ATTENDANCESTATUS.SortBy("ATTENDANCESTATUSID").ToList

            Return View(sortedList)
        End Function


        ' GET : Create-AttendanceStatus
        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal AttendanceStatus As model.ATTENDANCESTATUS) As ActionResult

            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.ATTENDANCESTATUS.Any(Function(model) model.ATTENDANCESTATUSID = AttendanceStatus.ATTENDANCESTATUSID)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("ATTENDANCESTATUSID", "Attendance Status Code is duplicated")
            End If

            If ModelState.IsValid Then

                AttendanceStatus.ISINUSED = True
                AttendanceStatus.CREATEDON = Now
                AttendanceStatus.CREATEDBY = "SYSTEM"

                db.ATTENDANCESTATUS.Add(AttendanceStatus)
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()

            End If

            Return View(AttendanceStatus)

        End Function

        ' GET : Edit-AttendanceStatus
        Function Edit(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim AttendanceStatus As model.ATTENDANCESTATUS = db.ATTENDANCESTATUS.Find(id)

            If IsNothing(AttendanceStatus) Then
                Return HttpNotFound()
            End If

            Return View(AttendanceStatus)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="ATTENDANCESTATUSID, DESCRIPTION, ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal AttendanceStatus As model.ATTENDANCESTATUS) As ActionResult
            If ModelState.IsValid Then

                AttendanceStatus.UPDATEDBY = "NICK"
                AttendanceStatus.UPDATEDON = Now

                db.Entry(AttendanceStatus).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View(AttendanceStatus)

            End If

            Return View(AttendanceStatus)
        End Function

        ' GET : Delete-AttendanceStatus
        Function Delete(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim AttendanceStatus As model.ATTENDANCESTATUS = db.ATTENDANCESTATUS.Find(id)

            If IsNothing(AttendanceStatus) Then
                Return HttpNotFound()
            End If
            Return View(AttendanceStatus)

        End Function

        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim AttendanceStatus As model.ATTENDANCESTATUS = db.ATTENDANCESTATUS.Find(id)
            db.ATTENDANCESTATUS.Remove(AttendanceStatus)
            db.SaveChanges()

            '# Return to Index 
            ViewBag.Result = "OK"
            Return View(AttendanceStatus)
        End Function
    End Class
End Namespace