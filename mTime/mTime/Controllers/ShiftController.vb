Imports System.Net
Imports mTime

Namespace Controllers

    Public Class ShiftController
        Inherits Controller

        Private db As New model.MasterDB

        Function Index() As ActionResult
            Dim sortedList = db.SHIFT.SortBy("SHIFTID").ToList

            '# Return updated dataset
            Return View(sortedList)
        End Function


        ' GET : Create-Shift
        Function Create() As ActionResult
            Dim Shift As New model.SHIFT

            Shift.ISWORKDAY1 = True
            Shift.ISWORKDAY2 = True
            Shift.ISWORKDAY3 = True
            Shift.ISWORKDAY4 = True
            Shift.ISWORKDAY5 = True
            Shift.ISWORKDAY6 = True
            Shift.ISWORKDAY7 = True

            Shift.ISFLEXIHOUR = True

            Return View(Shift)
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal Shift As model.SHIFT) As ActionResult
            ValidateBeforeSave(Shift)

            ' Check is duplicate
            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.SHIFT.Any(Function(model) model.SHIFTID = Shift.SHIFTID)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("SHIFTID", "Shift Code is duplicated")
            End If

            If ModelState.IsValid Then
                Shift = SetupBeforeSave(Shift)

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
        Function Edit(<Bind(Include:="SHIFTID, ISFLEXIHOUR,
                TIMEINSTART1, TIMEINEND1, WORKHOUR1, ISWORKDAY1, 
                TIMEINSTART2, TIMEINEND2, WORKHOUR2, ISWORKDAY2, 
                TIMEINSTART3, TIMEINEND3, WORKHOUR3, ISWORKDAY3, 
                TIMEINSTART4, TIMEINEND4, WORKHOUR4, ISWORKDAY4, 
                TIMEINSTART5, TIMEINEND5, WORKHOUR5, ISWORKDAY5, 
                TIMEINSTART6, TIMEINEND6, WORKHOUR6, ISWORKDAY6, 
                TIMEINSTART7, TIMEINEND7, WORKHOUR7, ISWORKDAY7, 
                GRACEPERIODFORLATEIN, GRACEPERIODFOREARLYOUT, REMARK,
                ISINUSED, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal Shift As model.SHIFT) As ActionResult

            ValidateBeforeSave(Shift)

            If ModelState.IsValid Then
                ' update time in end 
                Shift = SetupBeforeSave(Shift)
                
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

        Function ValidateBeforeSave(Shift As model.SHIFT)

            Dim intDay As Integer
            Dim blnIsValidInput As Boolean

            For intDay = 1 To 7

                blnIsValidInput = True

                Select Case intDay
                    Case 1

                        If Shift.ISWORKDAY1 Then
                            If IsNothing(Shift.TIMEINSTART1) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND1) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR1) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART1", "Invalid input")
                            End If
                        End If

                    Case 2

                        If Shift.ISWORKDAY2 Then
                            If IsNothing(Shift.TIMEINSTART2) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND2) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR2) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART2", "Invalid input")
                            End If

                        End If


                    Case 3

                        If Shift.ISWORKDAY3 Then
                            If IsNothing(Shift.TIMEINSTART3) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND3) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR3) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART3", "Invalid input")
                            End If

                        End If


                    Case 4

                        If Shift.ISWORKDAY4 Then
                            If IsNothing(Shift.TIMEINSTART4) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND4) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR4) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART4", "Invalid input")
                            End If

                        End If



                    Case 5

                        If Shift.ISWORKDAY5 Then
                            If IsNothing(Shift.TIMEINSTART5) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND5) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR5) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART5", "Invalid input")
                            End If

                        End If

                    Case 6

                        If Shift.ISWORKDAY6 Then
                            If IsNothing(Shift.TIMEINSTART6) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND6) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR6) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART6", "Invalid input")
                            End If

                        End If

                    Case 7

                        If Shift.ISWORKDAY7 Then
                            If IsNothing(Shift.TIMEINSTART7) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.TIMEINEND7) Then
                                blnIsValidInput = False
                            End If
                            If IsNothing(Shift.WORKHOUR7) Then
                                blnIsValidInput = False
                            End If

                            If blnIsValidInput = False Then
                                ModelState.AddModelError("TIMEINSTART7", "Invalid input")
                            End If

                        End If


                End Select






            Next

            '' check everything again
            'If Shift.ISWORKDAY1 Then
            '    If IsNothing(Shift.TIMEINSTART1) Then
            '        ModelState.AddModelError("TIMEINSTART1", "Monday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND1) Then
            '        ModelState.AddModelError("TIMEINEND1", "Monday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR1) Then
            '        ModelState.AddModelError("WORKHOUR1", "Monday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY2 Then
            '    If IsNothing(Shift.TIMEINSTART2) Then
            '        ModelState.AddModelError("TIMEINSTART2", "Tuesday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND2) Then
            '        ModelState.AddModelError("TIMEINEND2", "Tuesday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR2) Then
            '        ModelState.AddModelError("WORKHOUR2", "Tuesday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY3 Then
            '    If IsNothing(Shift.TIMEINSTART3) Then
            '        ModelState.AddModelError("TIMEINSTART3", "Wednesday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND3) Then
            '        ModelState.AddModelError("TIMEINEND3", "Wednesday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR3) Then
            '        ModelState.AddModelError("WORKHOUR3", "Wednesday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY4 Then
            '    If IsNothing(Shift.TIMEINSTART4) Then
            '        ModelState.AddModelError("TIMEINSTART4", "Thursday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND4) Then
            '        ModelState.AddModelError("TIMEINEND4", "Thursday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR4) Then
            '        ModelState.AddModelError("WORKHOUR4", "Thursday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY5 Then
            '    If IsNothing(Shift.TIMEINSTART5) Then
            '        ModelState.AddModelError("TIMEINSTART5", "Friday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND5) Then
            '        ModelState.AddModelError("TIMEINEND5", "Friday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR5) Then
            '        ModelState.AddModelError("WORKHOUR5", "Friday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY6 Then
            '    If IsNothing(Shift.TIMEINSTART6) Then
            '        ModelState.AddModelError("TIMEINSTART6", "Saturday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND6) Then
            '        ModelState.AddModelError("TIMEINEND6", "Saturday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR6) Then
            '        ModelState.AddModelError("WORKHOUR6", "Saturday working hour start is required")
            '    End If
            'End If

            'If Shift.ISWORKDAY7 Then
            '    If IsNothing(Shift.TIMEINSTART7) Then
            '        ModelState.AddModelError("TIMEINSTART7", "Sunday time in start is required")
            '    End If
            '    If IsNothing(Shift.TIMEINEND7) Then
            '        ModelState.AddModelError("TIMEINEND7", "Sunday time in end is required")
            '    End If
            '    If IsNothing(Shift.WORKHOUR7) Then
            '        ModelState.AddModelError("WORKHOUR7", "Sunday working hour start is required")
            '    End If
            'End If

        End Function

        Function SetupBeforeSave(Shift As model.SHIFT) As model.SHIFT
            ' update time in end 
            If Not Shift.ISFLEXIHOUR Then
                Shift.TIMEINEND1 = Shift.TIMEINSTART1
                Shift.TIMEINEND2 = Shift.TIMEINSTART2
                Shift.TIMEINEND3 = Shift.TIMEINSTART3
                Shift.TIMEINEND4 = Shift.TIMEINSTART4
                Shift.TIMEINEND5 = Shift.TIMEINSTART5
                Shift.TIMEINEND6 = Shift.TIMEINSTART6
                Shift.TIMEINEND7 = Shift.TIMEINSTART7
            End If

            Return Shift
        END Function
    End Class
End Namespace