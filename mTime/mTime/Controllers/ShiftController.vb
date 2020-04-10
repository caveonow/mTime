Imports System.Net
Imports mTime

Namespace Controllers

    Public Class ShiftController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET : Create-Shift
        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal Shift As model.SHIFT) As ActionResult

            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.SHIFT.Any(Function(model) model.SHIFTID = Shift.SHIFTID)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("SHIFTID", "Shift Code is duplicated")
            End If

            If ModelState.IsValid Then

                Shift.ISINUSED = True
                Shift.CREATEDON = Now
                Shift.CREATEDBY = "SYSTEM"
                Shift.UPDATEDON = Now
                Shift.UPDATEDBY = "SYSTEM"

                db.SHIFT.Add(Shift)
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()

            End If

            Return View(Shift)

        End Function

        ' GET : Details-Shift
        Function Details(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim Shift As model.SHIFT = db.SHIFT.Find(id)

            If IsNothing(Shift) Then
                Return HttpNotFound()
            End If

            Return View(Shift)

        End Function
        

        ' GET : Edit-Shift
        Function Edit(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim Shift As model.SHIFT = db.SHIFT.Find(id)

            If IsNothing(Shift) Then
                Return HttpNotFound()
            End If

            Return View(Shift)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="SHIFTID, 
                FLEXISTARTTIMEFROM1, FLEXISTARTTIMETO1, WORKHOUR1, ISOFFDAY1, 
                FLEXISTARTTIMEFROM2, FLEXISTARTTIMETO2, WORKHOUR2, ISOFFDAY2, 
                FLEXISTARTTIMEFROM3, FLEXISTARTTIMETO3, WORKHOUR3, ISOFFDAY3, 
                FLEXISTARTTIMEFROM4, FLEXISTARTTIMETO4, WORKHOUR4, ISOFFDAY4, 
                FLEXISTARTTIMEFROM5, FLEXISTARTTIMETO5, WORKHOUR5, ISOFFDAY5, 
                FLEXISTARTTIMEFROM6, FLEXISTARTTIMETO6, WORKHOUR6, ISOFFDAY6, 
                FLEXISTARTTIMEFROM7, FLEXISTARTTIMETO7, WORKHOUR7, ISOFFDAY7, 
                GRACEPERIODFORLATEIN, GRACEPERIODFOREARLYOUT, REMARK,
                ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal Shift As model.SHIFT) As ActionResult

            If ModelState.IsValid Then
                Shift.UPDATEDBY = "SYSTEM"
                Shift.UPDATEDON = Now

                db.Entry(Shift).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View(Shift)
            End If

            Return View(Shift)
        End Function

        ' GET : Delete-Shift
        Function Delete(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim Shift As model.SHIFT = db.SHIFT.Find(id)

            If IsNothing(Shift) Then
                Return HttpNotFound()
            End If
            Return View(Shift)

        End Function

        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim Shift As model.SHIFT = db.SHIFT.Find(id)
            db.Shift.Remove(Shift)
            db.SaveChanges()

            '# Return to Index 
            ViewBag.Result = "OK"
            Return View(Shift)
        End Function
    End Class
End Namespace