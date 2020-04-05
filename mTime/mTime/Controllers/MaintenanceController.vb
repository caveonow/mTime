Imports System.Web.Mvc
Imports System.Net

Namespace Controllers

    Public Class MaintenanceController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Hyperlink
        Function Index() As ActionResult

            Dim sortedList = db.HYPERLINK.SortBy("TITLE").ToList

            'db.HYPERLINK.ToList

            '# Return updated dataset
            Return View(sortedList)
        End Function

        '' GET: Maintenance
        'Function Index() As ActionResult

        '    Return View()

        'End Function

        Function Holiday(ByVal yearFilter As String) As ActionResult
            ' get result from db
            Dim listing = db.HOLIDAY.SortBy("FROM").ToList

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
            Return View(listing)
        End Function

        Function Department() As ActionResult
            Dim sortedList = db.DEPARTMENT.SortBy("DEPARTMENTID").ToList

            '# Return updated dataset
            Return View(sortedList)
        End Function

        Function Grade() As ActionResult
            Return View()
        End Function

        Function Reason() As ActionResult
            Dim sortedList = db.POORATTENDANCEREASON.SortBy("POORATTENDANCEREASONID").ToList

            Debug.Print("OK")

            '# Return updated dataset
            Return View(sortedList)
        End Function

        Function AttendanceStatus() As ActionResult
            Dim sortedList = db.ATTENDANCESTATUS.SortBy("ATTENDANCESTATUSID").ToList

            Return View(sortedList)
        End Function

        Function Shift() As ActionResult

            Return View()
        End Function

        Function LateTolerant() As ActionResult
            Return View()
        End Function

        Function Staff() As ActionResult
            Return View()
        End Function

    End Class

End Namespace