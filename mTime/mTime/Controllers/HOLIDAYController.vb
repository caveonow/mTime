Imports System.Data.Entity
Imports System.Net
Imports mTime
Imports PagedList

Namespace Controllers
    Public Class HOLIDAYController
        Inherits System.Web.Mvc.Controller

        Private db As New mTime.model.MasterDB

        ' GET: HOLIDAYs
        Function Index(ByVal page As Integer?, ByVal yearFilter As String) As ActionResult
            ' https://www.mikesdotnetting.com/article/243/mvc-5-with-ef-6-in-visual-basic-sorting-filtering-and-paging

            ' paging
            Dim pg = 1

            If Not IsNothing(page) Then
                pg = page
            End If

            ' get result from db
            Dim listing = db.HOLIDAY.ToList()

            ' get all available year for dropdown
            Dim yearListing As New List(Of Integer)

            For Each listingItem As model.HOLIDAY In listing
                yearListing.Add(Year(listingItem.FROM))
            Next

            ' add current year if is empty
            If IsNothing(yearListing) Or yearListing.Count <= 0 Then
                yearListing.Add(System.DateTime.Now.Year)
            Else
                yearListing = yearListing.Distinct().ToList()
            End If

            ' Filter the year
            If Not IsNothing(yearFilter) And Not yearFilter = "All" Then
                listing = listing.Where(Function(h) Year(h.FROM) = yearFilter).ToList()
            End If

            ' add necessary viewbag
            ViewBag.TotalHolidays = listing.Count
            ViewBag.yearListing = yearListing
            ViewBag.yearFilter = yearFilter

            ' Return with paging
            Return View(listing.ToPagedList(pg, 10))
        End Function

        ' GET: HOLIDAYs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
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
        Function Create(<Bind(Include:="HOLIDAYID,HOLIDAYNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal hOLIDAY As model.HOLIDAY) As ActionResult
            ' Check is same year
            If Not checkIsSameYear(hOLIDAY.FROM, hOLIDAY.UNTIL) Then
                ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Year not same")
            End If

            validateBeforeSave(hOLIDAY)

            If ModelState.IsValid Then
                hOLIDAY.CREATEDBY = "SYSTEM"
                hOLIDAY.CREATEDON = System.DateTime.Now
                hOLIDAY.UPDATEDBY = "SYSTEM"
                hOLIDAY.UPDATEDON = System.DateTime.Now

                db.HOLIDAY.Add(hOLIDAY)
                db.SaveChanges()

                ' https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/inputbox-function
                ' show successfully save dialog
                Dim Msg, Style, Title, Response
                Msg = "Save successfully"
                Style = vbOKOnly
                Title = "Save successfully"
                Response = MsgBox(Msg, Style, Title)
                If Response = vbOK Then
                    Return RedirectToAction("Index")
                Else
                    Return RedirectToAction("Index")
                End If
            End If

            Return View(hOLIDAY)
        End Function

        ' GET: HOLIDAYs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
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
        Function Edit(<Bind(Include:="HOLIDAYID,HOLIDAYNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal hOLIDAY As model.HOLIDAY) As ActionResult
            ' Check is same year
            If Not checkIsSameYear(hOLIDAY.FROM, hOLIDAY.UNTIL) Then
                ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Year not same")
            End If

            validateBeforeSave(hOLIDAY)

            If ModelState.IsValid Then
                hOLIDAY.UPDATEDBY = "SYSTEM"
                hOLIDAY.UPDATEDON = System.DateTime.Now

                db.Entry(hOLIDAY).State = EntityState.Modified
                db.SaveChanges()

                ' show successfully update dialog
                Dim Msg, Style, Title, Response
                Msg = "Update successfully"
                Style = vbOKOnly
                Title = "Update successfully"
                Response = MsgBox(Msg, Style, Title)
                If Response = vbOK Then
                    Return RedirectToAction("Index")
                Else
                    Return RedirectToAction("Index")
                End If
            End If
            Return View(hOLIDAY)
        End Function

        ' GET: HOLIDAYs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
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
            Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
            hOLIDAY.UPDATEDBY = "SYSTEM"
            hOLIDAY.UPDATEDON = System.DateTime.Now

            db.HOLIDAY.Remove(hOLIDAY)
            db.SaveChanges()

            ' show successfully delete dialog
            Dim Msg, Style, Title, Response
            Msg = "Delete successfully"
            Style = vbOKOnly
            Title = "Delete successfully"
            Response = MsgBox(Msg, Style, Title)
            If Response = vbOK Then
                Return RedirectToAction("Index")
            Else
                Return RedirectToAction("Index")
            End If
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' GET: HOLIDAYs/Copy/5
        Function Copy(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
            If IsNothing(hOLIDAY) Then
                Return HttpNotFound()
            End If
            Return View("Create", hOLIDAY)
        End Function

        Function checkIsSameYear(firstDate As DateTime, secondDate As DateTime) As Boolean
            If (Year(firstDate) = Year(secondDate)) Then
                Return True
            End If

            Return False
        End Function

        Private Sub validateBeforeSave(holiday As model.HOLIDAY)
            If IsNothing(holiday.HOLIDAYNAME) Then
                ModelState.AddModelError("HOLIDAYNAME", "Name is required")
            End If

            If IsNothing(holiday.FROM) Then
                ModelState.AddModelError("FROM", "Date from is required")
            End If

            If IsNothing(holiday.UNTIL) Then
                ModelState.AddModelError("UNTIL", "Date to is required")
            End If
        End Sub
    End Class
End Namespace
