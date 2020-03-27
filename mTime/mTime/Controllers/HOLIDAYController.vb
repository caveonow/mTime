Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports mTime.mTime

Namespace Controllers
    Public Class HOLIDAYController
        Inherits System.Web.Mvc.Controller

        Private db As New mTimedbEntities

        ' GET: HOLIDAYs
        Function Index() As ActionResult
            Return View(db.HOLIDAYs.ToList())
        End Function

        ' GET: HOLIDAYs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As HOLIDAY = db.HOLIDAYs.Find(id)
            If IsNothing(hOLIDAY) Then
                Return HttpNotFound()
            End If
            Return View(hOLIDAY)
        End Function

        ' GET: HOLIDAYs/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: HOLIDAYs/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="HOLIDAYID,HOLIDAYNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal hOLIDAY As HOLIDAY) As ActionResult
            If ModelState.IsValid Then
                db.HOLIDAYs.Add(hOLIDAY)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hOLIDAY)
        End Function

        ' GET: HOLIDAYs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As HOLIDAY = db.HOLIDAYs.Find(id)
            If IsNothing(hOLIDAY) Then
                Return HttpNotFound()
            End If
            Return View(hOLIDAY)
        End Function

        ' POST: HOLIDAYs/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="HOLIDAYID,HOLIDAYNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal hOLIDAY As HOLIDAY) As ActionResult
            If ModelState.IsValid Then
                db.Entry(hOLIDAY).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hOLIDAY)
        End Function

        ' GET: HOLIDAYs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As HOLIDAY = db.HOLIDAYs.Find(id)
            If IsNothing(hOLIDAY) Then
                Return HttpNotFound()
            End If
            Return View(hOLIDAY)
        End Function

        ' POST: HOLIDAYs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim hOLIDAY As HOLIDAY = db.HOLIDAYs.Find(id)
            db.HOLIDAYs.Remove(hOLIDAY)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
