Imports System.Web.Mvc
Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Globalization

'Imports System.Data.Entity

Imports PagedList

Namespace Controllers
    Public Class holidayController
        Inherits Controller

        Private db As New model.MasterDB
        <HttpGet>
        Function Index(ByVal yearFilter As String) As ActionResult
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

        ' GET: HOLIDAYs/Create
        Function Create(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return View()
            Else
                Dim Holiday As model.HOLIDAY = db.HOLIDAY.Find(id)
                If IsNothing(Holiday) Then
                    Return HttpNotFound()
                End If
                Return View(Holiday)
            End If
        End Function

        ' POST: Holidays/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal Holiday As model.HOLIDAY) As ActionResult


            ' Check is same year
            If Not checkIsSameYear(Holiday.FROM, Holiday.UNTIL) Then
                'ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Year not same")
            Else

                If DateDiff(DateInterval.Day, Holiday.FROM, Holiday.UNTIL) < 0 Then
                    ModelState.AddModelError("Until", "End Date must latest than Start Date")
                End If

            End If

            'validateBeforeSave(Holiday)

            If ModelState.IsValid Then

                Holiday.ISINUSED = True
                Holiday.CREATEDBY = "SYSTEM"
                Holiday.CREATEDON = System.DateTime.Now
                Holiday.UPDATEDBY = "SYSTEM"
                Holiday.UPDATEDON = System.DateTime.Now

                db.HOLIDAY.Add(Holiday)
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()
            End If

            Return View(Holiday)
        End Function

        ' GET: Holidays/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim Holiday As model.HOLIDAY = db.HOLIDAY.Find(id)
            If IsNothing(Holiday) Then
                Return HttpNotFound()
            End If
            Return View(Holiday)
        End Function

        ' POST: Holidays/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="HolidayID,HolidayNAME,FROM,UNTIL,ISINUSED,CREATEDBY,CREATEDON,UPDATEDBY,UPDATEDON")> ByVal Holiday As model.HOLIDAY) As ActionResult
            ' Check is same year
            If Not checkIsSameYear(Holiday.FROM, Holiday.UNTIL) Then
                'ModelState.AddModelError("FROM", "Year not same")
                ModelState.AddModelError("Until", "Cross year is not allowed")
            Else
                If DateDiff(DateInterval.Day, Holiday.FROM, Holiday.UNTIL) < 0 Then
                    ModelState.AddModelError("Until", "End Date must latest than Start Date")
                End If
            End If

            'validateBeforeSave(Holiday)

            If ModelState.IsValid Then
                Holiday.UPDATEDBY = "SYSTEM"
                Holiday.UPDATEDON = System.DateTime.Now

                db.Entry(Holiday).State = EntityState.Modified
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return View()
            End If

            Return View(Holiday)
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


        <HttpPost>
        Function ImportHoliday(ByVal postedFile As HttpPostedFileBase) As ActionResult

            Dim db As New model.MasterDB
            Dim holiday As model.HOLIDAY

            Dim strResult As String = ""
            Dim strFileFolder As String
            Dim strFilename As String

            Dim intRowNo As Integer
            Dim intRowCount As Integer

            Dim intCellNo As Integer

            Dim strHeader(3) As String

            Dim strHolidayName As String
            Dim strStartDate As String
            Dim strEndDate As String

            Dim dteStartDate As Date
            Dim dteEndDate As Date

            Dim blnIsValidCSVFile As Boolean

            If Not IsNothing(postedFile) Then

                '# Create Folder
                strFileFolder = Server.MapPath("~/Temp/")

                If Directory.Exists(strFileFolder) = False Then
                    Directory.CreateDirectory(strFileFolder)
                End If

                strFilename = strFileFolder & Path.GetFileName(postedFile.FileName)
                postedFile.SaveAs(strFilename)

                Dim csvData As String = System.IO.File.ReadAllText(strFilename)

                intRowNo = 1
                intRowCount = 0

                blnIsValidCSVFile = True

                'Check all data in CSV File
                For Each row As String In csvData.Split(ControlChars.Lf)
                    If Not String.IsNullOrEmpty(row) Then

                        intCellNo = 1
                        strHolidayName = ""
                        strStartDate = ""
                        strEndDate = ""

                        For Each cell As String In row.Split(","c)

                            If intRowNo = 1 Then
                                'Check CSV file header

                                Select Case intCellNo
                                    Case 1
                                        strHeader(0) = cell.Trim

                                        If strHeader(0).ToUpper <> "HOLIDAY NAME" Then
                                            blnIsValidCSVFile = False
                                        End If
                                    Case 2
                                        strHeader(1) = cell.Trim

                                        If strHeader(1).ToUpper <> "START DATE" Then
                                            blnIsValidCSVFile = False
                                        End If

                                    Case 3
                                        strHeader(2) = cell.Trim

                                        If strHeader(2).ToUpper <> "END DATE" Then
                                            blnIsValidCSVFile = False
                                        End If

                                    Case Else
                                End Select


                            Else
                                Select Case intCellNo
                                    Case 1
                                        strHolidayName = cell.Trim

                                        If strHolidayName.Length = 0 Then
                                            blnIsValidCSVFile = False
                                        End If
                                    Case 2
                                        strStartDate = cell.Trim

                                        Try

                                            blnIsValidCSVFile = DateTime.TryParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dteStartDate)


                                            'If IsDate(strStartDate) = True Then
                                            '    dteStartDate = DateTime.Parse(strStartDate)
                                            'Else
                                            '    blnIsValidCSVFile = False
                                            'End If

                                        Catch ex As Exception
                                            blnIsValidCSVFile = False
                                        End Try


                                    Case 3
                                        strEndDate = cell.Trim

                                        Try

                                            'If IsDate(strEndDate) = True Then
                                            '    dteEndDate = DateTime.Parse(strEndDate)
                                            'Else
                                            '    blnIsValidCSVFile = False
                                            'End If

                                            blnIsValidCSVFile = DateTime.TryParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dteEndDate)


                                        Catch ex As Exception
                                            blnIsValidCSVFile = False
                                        End Try

                                    Case Else
                                End Select


                            End If


                            If blnIsValidCSVFile = False Then
                                Exit For
                            Else
                                intCellNo += 1
                            End If

                        Next

                        If blnIsValidCSVFile = False Then
                            Exit For
                        Else
                            If intRowNo > 1 Then
                                intRowCount += 1
                            End If
                        End If

                        intRowNo += 1

                    End If



                Next


                intRowNo = 1

                If blnIsValidCSVFile = True And intRowCount >= 1 Then

                    '# Add data to database

                    For Each row As String In csvData.Split(ControlChars.Lf)
                        If Not String.IsNullOrEmpty(row) Then

                            intCellNo = 1
                            strHolidayName = ""
                            strStartDate = ""
                            strEndDate = ""

                            For Each cell As String In row.Split(","c)

                                '# Skip header
                                If intRowNo > 1 Then

                                    Select Case intCellNo
                                        Case 1
                                            strHolidayName = cell.Trim
                                        Case 2
                                            strStartDate = cell.Trim
                                        Case 3
                                            strEndDate = cell.Trim
                                        Case Else
                                    End Select


                                End If

                                intCellNo += 1

                            Next


                            If intRowNo > 1 Then

                                '# Start Add

                                holiday = New model.HOLIDAY

                                holiday.HOLIDAYNAME = strHolidayName

                                'With dteStartDate
                                '    .Day = Mid(strStartDate, 1, 2)

                                'End With

                                DateTime.TryParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dteStartDate)
                                DateTime.TryParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dteEndDate)

                                holiday.FROM = dteStartDate
                                holiday.UNTIL = dteEndDate

                                holiday.ISINUSED = True
                                holiday.CREATEDBY = "SYSTEM"
                                holiday.CREATEDON = System.DateTime.Now
                                holiday.UPDATEDBY = "SYSTEM"
                                holiday.UPDATEDON = System.DateTime.Now

                                db.HOLIDAY.Add(holiday)
                                db.SaveChanges()

                            End If

                            intRowNo += 1

                        End If

                    Next

                    TempData("HolidayImportResult") = "OK"

                Else
                    TempData("HolidayImportResult") = "NG"
                End If


            Else
                TempData("HolidayImportResult") = "NG"
            End If

            TempData("RowCount") = intRowCount.ToString

            Return RedirectToAction("Index")

        End Function

        '<HttpPost>
        'Function ImportHoliday() As ActionResult

        '    Dim strFileFolder As String
        '    Dim strResult As String = ""
        '    Dim strFilename As String
        '    Dim objFile As HttpPostedFileBase
        '    Dim strSplittedFilename() As String

        '    If Request.Files.Count > 0 Then

        '        Try


        '            Dim objFiles As HttpFileCollectionBase = Request.Files

        '            For intI = 0 To objFiles.Count - 1

        '                objFile = objFiles(intI)

        '                strFilename = ""

        '                'If Request.Browser.Browser.ToUpper = "IE" Or Request.Browser.Browser.ToUpper = "INTERNETEXPLORER" Then
        '                '    strSplittedFilename = objFile.FileName.Split("\\")
        '                '    strFilename = strSplittedFilename(strSplittedFilename.Length - 1)
        '                'Else
        '                '    strFilename = objFile.FileName
        '                'End If

        '                strSplittedFilename = objFile.FileName.Split("\\")
        '                strFilename = strSplittedFilename(strSplittedFilename.Length - 1)


        '                '# Create Folder
        '                strFileFolder = Server.MapPath("~/Temp/")

        '                If Directory.Exists(strFileFolder) = False Then
        '                    Directory.CreateDirectory(strFileFolder)
        '                End If

        '                objFile.SaveAs(strFileFolder & strFilename)

        '            Next

        '            'ViewBag.ImportFileResult = "OK"
        '            'Return View()

        '            'Return Json("Holiday is imported")

        '            'Return RedirectToAction("Holiday", "Maintenance", "")

        '        Catch ex As Exception
        '            'Return Json("Failed to import Holiday")

        '            'ViewBag.ImportFileResult = "NG"
        '            'Return View()

        '            'Return RedirectToAction("Holiday", "Maintenance", "")

        '        End Try

        '    Else

        '        'Return RedirectToAction("Holiday", "Maintenance", "")

        '        'Return Json("Holiday is not imported")

        '        'ViewBag.ImportFileResult = "NG"
        '        'Return View()
        '    End If

        '    Return View()

        'End Function

    End Class
End Namespace
