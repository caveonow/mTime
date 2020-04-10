Imports System.Data.Entity
Imports System.Net
Imports mTime
Imports PagedList

Namespace Controllers
    Public Class holidayController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: HOLIDAYs
        ' Function Index(ByVal page As Integer?, ByVal yearFilter As String) As ActionResult
        '     ' https://www.mikesdotnetting.com/article/243/mvc-5-with-ef-6-in-visual-basic-sorting-filtering-and-paging

        '     ' paging
        '     Dim pg = 1

        '     If Not IsNothing(page) Then
        '         pg = page
        '     End If

        '     ' get result from db
        '     Dim listing = db.HOLIDAY.ToList()

        '     ' get all available year for dropdown
        '     Dim yearListing As New List(Of Integer)

        '     For Each listingItem As model.HOLIDAY In listing
        '         yearListing.Add(Year(listingItem.FROM))
        '     Next

        '     ' add current year if is empty
        '     If IsNothing(yearListing) Or yearListing.Count <= 0 Then
        '         yearListing.Add(System.DateTime.Now.Year)
        '     Else
        '         yearListing = yearListing.Distinct().ToList()
        '     End If

        '     ' Filter the year
        '     If Not IsNothing(yearFilter) And Not yearFilter = "All" Then
        '         listing = listing.Where(Function(h) Year(h.FROM) = yearFilter).ToList()
        '     End If

        '     ' add necessary viewbag
        '     ViewBag.TotalHolidays = listing.Count
        '     ViewBag.yearListing = yearListing
        '     ViewBag.yearFilter = yearFilter

        '     ' Return with paging
        '     Return View(listing.ToPagedList(pg, 10))
        ' End Function

        ' GET: HOLIDAYs/Details/5
        ' Function Details(ByVal id As Integer?) As ActionResult
        '     If IsNothing(id) Then
        '         Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        '     End If
        '     Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
        '     If IsNothing(hOLIDAY) Then
        '         Return HttpNotFound()
        '     End If
        '     Return View(hOLIDAY)
        ' End Function

        ' GET: HOLIDAYs/Create
        Function Create(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return View()
            Else
                Dim hOLIDAY As model.HOLIDAY = db.HOLIDAY.Find(id)
                If IsNothing(hOLIDAY) Then
                    Return HttpNotFound()
                End If
                Return View(hOLIDAY)
            End If
        End Function

        ' POST: HOLIDAYs/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal holiday As model.HOLIDAY) As ActionResult


            ' Check is same year
            If Not checkIsSameYear(holiday.FROM, holiday.UNTIL) Then
                'ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Year not same")
            Else

                If DateDiff(DateInterval.Day, holiday.FROM, holiday.UNTIL) < 0 Then
                    ModelState.AddModelError("Until", "End Date must latest than Start Date")
                End If

            End If

            'validateBeforeSave(hOLIDAY)

            If ModelState.IsValid Then

                holiday.ISINUSED = True
                holiday.CREATEDBY = "SYSTEM"
                holiday.CREATEDON = System.DateTime.Now
                holiday.UPDATEDBY = "SYSTEM"
                holiday.UPDATEDON = System.DateTime.Now

                db.HOLIDAY.Add(holiday)
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()
            End If

            Return View(holiday)
        End Function

        ' GET: HOLIDAYs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim holiday As model.HOLIDAY = db.HOLIDAY.Find(id)
            If IsNothing(holiday) Then
                Return HttpNotFound()
            End If
            Return View(holiday)
        End Function

        ' POST: HOLIDAYs/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="HOLIDAYID,HOLIDAYNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal holiday As model.HOLIDAY) As ActionResult
            ' Check is same year
            If Not checkIsSameYear(holiday.FROM, holiday.UNTIL) Then
                'ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Cross year is not allowed")
            Else
                If DateDiff(DateInterval.Day, holiday.FROM, holiday.UNTIL) < 0 Then
                    ModelState.AddModelError("Until", "End Date must latest than Start Date")
                End If
            End If

            'validateBeforeSave(hOLIDAY)

            If ModelState.IsValid Then
                holiday.UPDATEDBY = "SYSTEM"
                holiday.UPDATEDON = System.DateTime.Now

                db.Entry(holiday).State = EntityState.Modified
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()
            End If

            Return View(holiday)
        End Function

        ' GET: HOLIDAYs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim holiday As model.HOLIDAY = db.HOLIDAY.Find(id)
            If IsNothing(holiday) Then
                Return HttpNotFound()
            End If
            Return View(holiday)
        End Function

        ' POST: HOLIDAYs/Delete/5
        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim holiday As model.HOLIDAY = db.HOLIDAY.Find(id)
            holiday.UPDATEDBY = "SYSTEM"
            holiday.UPDATEDON = System.DateTime.Now

            db.HOLIDAY.Remove(holiday)
            db.SaveChanges()

            ViewBag.Result = "OK"
            Return View(holiday)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Function checkIsSameYear(firstDate As DateTime, secondDate As DateTime) As Boolean

            If IsDBNull(firstDate) = False Or IsDBNull(secondDate) = False Then
                If (Year(firstDate) = Year(secondDate)) Then
                    Return True
                End If
            End If

            Return False
        End Function


        'Private Sub validateBeforeSave(holiday As model.holiday)
        '    If IsNothing(holiday.holidayNAME) Then
        '        ModelState.AddModelError("holidayNAME", "Name is required")
        '    End If

        '    If IsNothing(holiday.FROM) Then
        '        ModelState.AddModelError("FROM", "Date from is required")
        '    End If

        '    If IsNothing(holiday.UNTIL) Then
        '        ModelState.AddModelError("UNTIL", "Date to is required")
        '    End If
        'End Sub
    End Class
End Namespace
