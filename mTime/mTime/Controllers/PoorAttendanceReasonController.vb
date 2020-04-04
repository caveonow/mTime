Imports System.Net
Imports mTime

Namespace Controllers

    '<RoutePrefix("Reason")>
    Public Class PoorAttendanceReasonController
        Inherits Controller

        Private db As New model.MasterDB

        '' GET: PoorAttendanceReason
        'Function Index() As ActionResult

        '    '# Return updated dataset
        '    'Return View(db.PoorAttendanceReason.ToList())
        '    Return View()
        'End Function

        'Function Details(ByRef id As Integer) As ActionResult

        '    If IsNothing(id) Then
        '        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        '    End If

        '    Dim PoorAttendanceReason As model.PoorAttendanceReason = db.PoorAttendanceReason.Find(id)

        '    If IsNothing(PoorAttendanceReason) Then
        '        Return HttpNotFound()
        '    End If
        '    Return View(PoorAttendanceReason)

        'End Function


        ' GET : Create-PoorAttendanceReason
        Function Create() As ActionResult
            Return View()
        End Function

        'Function Create(<Bind(Include:="PoorAttendanceReasonID, Title, URL, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn")> ByVal PoorAttendanceReason As PoorAttendanceReason) As ActionResult

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal PoorAttendanceReason As model.POORATTENDANCEREASON) As ActionResult

            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.POORATTENDANCEREASON.Any(Function(model) model.POORATTENDANCEREASONID = PoorAttendanceReason.POORATTENDANCEREASONID)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("POORATTENDANCEREASONID", "Reason Code is duplicated")
            End If

            If PoorAttendanceReason.ISFORLATEIN = False And PoorAttendanceReason.ISFOREARLYOUT = False Then
                ModelState.AddModelError("ISFORLATEIN", "For Late-In and For Early-Out is not ticked")
            End If

            If ModelState.IsValid Then

                PoorAttendanceReason.ISINUSED = True
                PoorAttendanceReason.CREATEDON = Now
                PoorAttendanceReason.CREATEDBY = "Nick"

                db.POORATTENDANCEREASON.Add(PoorAttendanceReason)
                db.SaveChanges()

                ViewBag.Result = "OK"
                'Return RedirectToRoute("PoorAttendanceReasonList")
                Return View()

            End If

            Return View(PoorAttendanceReason)

        End Function


        ' GET : Edit-PoorAttendanceReason
        Function Edit(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim PoorAttendanceReason As model.POORATTENDANCEREASON = db.POORATTENDANCEREASON.Find(id)

            If IsNothing(PoorAttendanceReason) Then
                Return HttpNotFound()
            End If


            'Debug.Print(PoorAttendanceReason.PoorAttendanceReasonID)

            Return View(PoorAttendanceReason)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="POORATTENDANCEREASONID, DESCRIPTION, ISFORLATEIN, ISFOREARLYOUT, ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal PoorAttendanceReason As model.POORATTENDANCEREASON) As ActionResult


            If ModelState.IsValid Then

                PoorAttendanceReason.UPDATEDBY = "NICK"
                PoorAttendanceReason.UPDATEDON = Now

                db.Entry(PoorAttendanceReason).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ''# Return to Index 
                'Return RedirectToRoute("PoorAttendanceReasonList")


                ViewBag.Result = "OK"
                'Return RedirectToRoute("PoorAttendanceReasonList")
                Return View(PoorAttendanceReason)

            End If

            Return View(PoorAttendanceReason)
        End Function

        ' GET : Delete-PoorAttendanceReason
        Function Delete(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim PoorAttendanceReason As model.POORATTENDANCEREASON = db.POORATTENDANCEREASON.Find(id)

            If IsNothing(PoorAttendanceReason) Then
                Return HttpNotFound()
            End If
            Return View(PoorAttendanceReason)

        End Function

        'Function Delete(<Bind(Include:="PoorAttendanceReasonID, TITLE, URL, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal PoorAttendanceReason As model.PoorAttendanceReason) As ActionResult
        '<ActionName("Delete")>

        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As String) As ActionResult

            Debug.Print(id.ToString)

            Dim PoorAttendanceReason As model.POORATTENDANCEREASON = db.POORATTENDANCEREASON.Find(id)
            db.POORATTENDANCEREASON.Remove(PoorAttendanceReason)
            db.SaveChanges()

            '# Return to Index 
            Return RedirectToRoute("PoorAttendanceReasonList")

        End Function

        Protected Overrides Sub Dispose(disposing As Boolean)

            If (disposing) Then
                db.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        'Function Cancel() As ActionResult
        '    Return RedirectToRoute("PoorAttendanceReasonList")
        'End Function

    End Class
End Namespace