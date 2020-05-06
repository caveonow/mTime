Imports System.Net
Imports mTime

Imports mTime.model
Imports FirebirdSql.Data.FirebirdClient

Namespace Controllers
    Public Class StaffController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Employee
        Function Index() As ActionResult

            Dim model = New STAFFDEPARTMENT

            model.DEPARTMENTLIST = GetDepartmentList(Nothing)
            model.SHIFTLIST = GetShiftList(Nothing)

            Dim staffList = (From staff In db.STAFF Where staff.STATUSCODE = "A"
                             Join department In db.DEPARTMENT On department.DEPARTMENTID Equals staff.DEPARTMENTID
                             Select New With {staff.FIRSTNAME, staff.LASTNAME, staff.NRIC, staff.DEPARTMENTID, department.DEPARTMENTNAME,
                                department.DIVISIONNAME, department.UNITNAME}
                             ).ToList

            Dim selectedStaff As model.SELECTEDSTAFF
            Dim staffShiftList = (From staffshift In db.STAFFSHIFT
                                  Where staffshift.EFFECTIVEON <= Now
                                  Select staffshift).ToList


            Dim newList As New List(Of SELECTEDSTAFF)

            If staffList.Count > 0 Then

                For Each row In staffList

                    selectedStaff = New model.SELECTEDSTAFF

                    With selectedStaff
                        .FIRSTNAME = row.FIRSTNAME
                        .LASTNAME = row.LASTNAME
                        .NRIC = row.NRIC
                        .DEPARTMENTID = CType(row.DEPARTMENTID, Integer)
                        .DEPARTMENTNAME = row.DEPARTMENTNAME
                        .DIVISIONNAME = row.DIVISIONNAME
                        .UNITNAME = row.UNITNAME
                    End With

                    Dim temp = staffShiftList
                    temp = temp.Where(Function(m) m.NRIC = row.NRIC).Take(1).ToList

                    If temp.Count > 0 Then
                        With selectedStaff
                            .SHIFTID = temp(0).SHIFTID
                            .EFFECTIVEON = temp(0).EFFECTIVEON
                        End With
                    End If

                    '# Add record to list
                    newList.Add(selectedStaff)

                Next

                model.STAFFSIMPLELIST = newList
            End If

            Return View(model)

        End Function

        Public Function GetDepartmentList(idSelected As String) As List(Of SelectListItem)

            Dim departmentList = From department In db.DEPARTMENT
                                 Select department.DEPARTMENTNAME, department.DIVISIONNAME, department.UNITNAME, department.DEPARTMENTID
                                 Order By DEPARTMENTNAME Ascending

            Dim itemList = New List(Of SelectListItem)
            Dim item As SelectListItem

            Dim strDepartmentname As String = ""

            For Each row In departmentList

                item = New SelectListItem

                strDepartmentname = row.DEPARTMENTNAME

                If Not IsDBNull(row.DIVISIONNAME) And Not row.DIVISIONNAME = "" Then
                    strDepartmentname += " / " + row.DIVISIONNAME
                End If

                If Not IsDBNull(row.UNITNAME) And Not row.UNITNAME = "" Then
                    strDepartmentname += " / " + row.UNITNAME
                End If

                With item
                    .Value = row.DEPARTMENTID
                    .Text = strDepartmentname
                End With

                If Not IsNothing(idSelected) And idSelected = row.DEPARTMENTID Then
                    item.Selected = True
                End If

                itemList.Add(item)

            Next

            Return itemList

        End Function

        Public Function GetShiftList(idSelected) As List(Of SelectListItem)

            Dim shiftList = From shift In db.SHIFT
                            Select shift
                            Order By shift.SHIFTID Ascending

            Dim itemList = New List(Of SelectListItem)
            Dim item As SelectListItem

            For Each row In shiftList

                item = New SelectListItem

                With item
                    .Value = row.SHIFTID
                    .Text = row.SHIFTID
                End With

                If Not IsNothing(idSelected) And idSelected = row.SHIFTID Then
                    item.Selected = True
                End If

                itemList.Add(item)

            Next

            Return itemList

        End Function

        <HttpPost>
        Public Function Index(ByVal FirstName As String, LastName As String, NRIC As String, DEPARTMENTID As String, SHIFTID As String) As ActionResult

            Dim model = New STAFFDEPARTMENT

            model.DEPARTMENTLIST = GetDepartmentList(Nothing)
            model.SHIFTLIST = GetShiftList(Nothing)

            Dim staffList = (From staff In db.STAFF
                             Join department In db.DEPARTMENT On department.DEPARTMENTID Equals staff.DEPARTMENTID
                             Select New With {staff.FIRSTNAME, staff.LASTNAME, staff.NRIC, staff.DEPARTMENTID, department.DEPARTMENTNAME,
                                department.DIVISIONNAME, department.UNITNAME}
                             Order By FirstName Ascending).ToList

            Dim selectedStaff As model.SELECTEDSTAFF
            Dim staffShiftList = (From staffshift In db.STAFFSHIFT
                                  Where staffshift.EFFECTIVEON <= Now
                                  Select staffshift).ToList


            Dim newList As New List(Of SELECTEDSTAFF)

            If staffList.Count > 0 Then

                For Each row In staffList

                    selectedStaff = New model.SELECTEDSTAFF

                    With selectedStaff
                        .FIRSTNAME = row.FIRSTNAME
                        .LASTNAME = row.LASTNAME
                        .NRIC = row.NRIC
                        .DEPARTMENTID = CType(row.DEPARTMENTID, Integer)
                        .DEPARTMENTNAME = row.DEPARTMENTNAME
                        .DIVISIONNAME = row.DIVISIONNAME
                        .UNITNAME = row.UNITNAME
                    End With

                    Dim temp = staffShiftList
                    temp = temp.Where(Function(m) m.NRIC = row.NRIC).Take(1).ToList

                    If temp.Count > 0 Then
                        With selectedStaff
                            .SHIFTID = temp(0).SHIFTID
                            .EFFECTIVEON = temp(0).EFFECTIVEON
                        End With
                    End If

                    '# Add record to list
                    newList.Add(selectedStaff)

                Next

                model.STAFFSIMPLELIST = newList

                If FirstName.Length > 0 Then
                    model.STAFFSIMPLELIST = model.STAFFSIMPLELIST.Where(Function(m) m.FIRSTNAME = FirstName)
                End If

                If LastName.Length > 0 Then
                    model.STAFFSIMPLELIST = model.STAFFSIMPLELIST.Where(Function(m) m.LASTNAME = LastName)
                End If

                If NRIC.Length > 0 Then
                    model.STAFFSIMPLELIST = model.STAFFSIMPLELIST.Where(Function(m) m.NRIC = NRIC)
                End If

                If DEPARTMENTID.Length > 0 Then
                    model.STAFFSIMPLELIST = model.STAFFSIMPLELIST.Where(Function(m) m.DEPARTMENTID = DEPARTMENTID)
                End If

                If SHIFTID.Length > 0 Then
                    model.STAFFSIMPLELIST = model.STAFFSIMPLELIST.Where(Function(m) m.SHIFTID = SHIFTID)
                End If

            End If

            Return View(model)

        End Function

        ' GET : Import from Firebird
        Function Import() As ActionResult

            Dim model = New STAFFDEPARTMENT

            model.DEPARTMENTLIST = GetDepartmentList(Nothing)
            model.SHIFTLIST = GetShiftList(Nothing)

            '# Get new staff list from Firebird DB via ADO.net (DSN-less connection)
            model.FIREBIRDSTAFFLIST = GetFirebirdStaff()

            Return View(model)

        End Function

        <HttpPost>
        Function SaveImport(ByVal staffList As String) As ActionResult

            Dim model = New STAFFDEPARTMENT

            Dim firebirdList = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of model.FIREBIRDSTAFF))(staffList)
            Dim strName As String
            Dim strNRIC As String
            Dim strDepartmentID As String
            Dim strShiftID As String
            Dim strStaffNo As String

            Dim modelStaff As STAFF
            Dim modelStaffShift As STAFFSHIFT

            For Each item In firebirdList

                strName = ""
                strNRIC = ""
                strDepartmentID = ""
                strShiftID = ""
                strStaffNo = ""

                strName = item.NAME
                strNRIC = item.NRIC
                strDepartmentID = item.DEPARTMENTID
                strShiftID = item.SHIFTID
                strStaffNo = item.STAFFNO

                If strDepartmentID.Length > 0 And strShiftID.Length > 0 Then

                    modelStaff = New STAFF
                    modelStaffShift = New STAFFSHIFT

                    With modelStaff
                        .FIRSTNAME = strName
                        .LASTNAME = ""
                        .NRIC = strNRIC
                        .STAFFNO = strStaffNo
                        .DEPARTMENTID = CType(strDepartmentID, Integer)
                        .STAFFGROUPID = "NORM" '# Default to Normal
                        .ISRESIGNED = False
                        .CREATEDON = Now
                        .CREATEDBY = "Nick"
                        .STATUSCODE = "A"
                    End With

                    db.STAFF.Add(modelStaff)
                    db.SaveChanges()

                    With modelStaffShift
                        .NRIC = strNRIC
                        .SHIFTID = strShiftID
                        .EFFECTIVEON = "01-01-1990"
                    End With

                    db.STAFFSHIFT.Add(modelStaffShift)
                    db.SaveChanges()

                End If


            Next

            Return Json(Url.Action("Index", "Staff"))

        End Function

        Function GetFirebirdStaff() As List(Of FIREBIRDSTAFF)

            Dim model = New STAFFDEPARTMENT

            ' Dim conn = New FbConnection("database=localhost:C:\EntryPass\P1_Server\database\COMPANY.FDB;user=;password=;port:3050;")
            Dim conn = New FbConnection("database=localhost:C:\Users\henly\Desktop\freelance\P1_Server\database_new\COMPANY.FDB;user=;password=;port:3050;")
            Dim cmd As FbCommand

            conn.Open()
            cmd = New FbCommand("SELECT * FROM STAFF", conn)

            Dim dr = cmd.ExecuteReader
            Dim strStaffNo As String
            Dim strName As String
            Dim strIC As String

            Dim modelFirebirdStaff As model.FIREBIRDSTAFF
            Dim newList As New List(Of FIREBIRDSTAFF)

            Dim modelStaff As model.STAFF

            If dr.HasRows Then

                strStaffNo = ""
                strName = ""
                strIC = ""

                While (dr.Read)

                    modelFirebirdStaff = New model.FIREBIRDSTAFF

                    If Not IsDBNull(dr("StaffNo")) Then
                        strStaffNo = dr("StaffNo")
                    End If
                    If Not IsDBNull(dr("Name")) Then
                        strName = dr("Name")
                    End If
                    If Not IsDBNull(dr("IC")) Then
                        strIC = dr("IC")
                    End If

                    If strIC.Length > 0 Then

                        modelStaff = db.STAFF.Where(Function(s) s.NRIC = strIC And s.STATUSCODE = "A").SingleOrDefault

                        If IsNothing(modelStaff) Then

                            With modelFirebirdStaff
                                .STAFFNO = strStaffNo
                                .NAME = strName
                                .NRIC = strIC
                                .DEPARTMENTID = vbNull
                                .SHIFTID = vbNull
                            End With

                            '# Add record to list
                            newList.Add(modelFirebirdStaff)

                        End If

                    End If

                End While

            End If

            conn.Close()
            conn.Dispose()

            Return newList

        End Function

        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim StaffDepartment = GetStaffDepartmentInfo(id)

            Return View(StaffDepartment)
        End Function

        Function UpdateStaff(ByVal jsonString As String) As ActionResult
            Dim StaffDepartment = Newtonsoft.Json.JsonConvert.DeserializeObject(Of model.STAFFDEPARTMENT)(jsonString)

            ' Input validation
            Dim isValid = True
            Dim result As New List(Of Object)

            If String.IsNullOrEmpty(StaffDepartment.DEPARTMENTID) Then
                isValid = False
                result.Add("ERROR_DEPARTMENT")
            End If

            If String.IsNullOrEmpty(StaffDepartment.SHIFTID) Then
                isValid = False
                result.Add("ERROR_SHIFT")
            End If

            If StaffDepartment.ISRESIGNED And IsNothing(StaffDepartment.RESIGNEDONSTR) Then
                isValid = False
                result.Add("ERROR_RESIGN_DATE")
            End If

            If Not isValid Then
                Return Json(result, JsonRequestBehavior.AllowGet)
            End If

            ' Convert Date Str to DateTime
            If StaffDepartment.ISRESIGNED And Not IsNothing(StaffDepartment.RESIGNEDONSTR) Then
                Dim format() = {"dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy"}
                Dim expenddt As Date = Date.ParseExact(StaffDepartment.RESIGNEDONSTR, format,
                    System.Globalization.DateTimeFormatInfo.InvariantInfo,
                    Globalization.DateTimeStyles.None)

                StaffDepartment.RESIGNEDON = expenddt
            End If

            ' Get Staff and staff shift info from db
            Dim Staff As model.STAFF = db.STAFF.Where(Function(s) s.NRIC = StaffDepartment.NRIC And s.STATUSCODE = "A").SingleOrDefault
            Dim StaffShift As model.STAFFSHIFT = db.STAFFSHIFT.Where(Function(ss) ss.NRIC = StaffDepartment.NRIC).SingleOrDefault

            If Not IsNothing(Staff) Then
                ' Update staff info based on user input
                With Staff
                    .DEPARTMENTID = StaffDepartment.DEPARTMENTID
                    .ISRESIGNED = StaffDepartment.ISRESIGNED
                    If StaffDepartment.ISRESIGNED Then
                        .RESIGNEDON = StaffDepartment.RESIGNEDON
                    Else
                        .RESIGNEDON = Nothing
                    End If
                    .UPDATEDBY = "SYSTEM"
                    .UPDATEDON = Now
                End With

                db.Entry(Staff).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()
            End If
            If Not IsNothing(StaffShift) Then
                ' Update staff shift
                If Not Staff.ISRESIGNED Then
                    With StaffShift
                        .SHIFTID = StaffDepartment.SHIFTID
                    End With

                    db.Entry(StaffShift).State = System.Data.Entity.EntityState.Modified
                    db.SaveChanges()
                Else
                    db.STAFFSHIFT.Remove(StaffShift)
                    db.SaveChanges()
                End If
            Else
                StaffShift = New model.STAFFSHIFT
                StaffShift.NRIC = StaffDepartment.NRIC
                StaffShift.SHIFTID = StaffDepartment.SHIFTID
                StaffShift.EFFECTIVEON = Now

                db.STAFFSHIFT.Add(StaffShift)
                db.SaveChanges()
            End If

            Return Json("SUCCESS_UPDATE", JsonRequestBehavior.AllowGet)
        End Function

        Function GetStaffDepartmentInfo(id As String)
            Dim Staff As model.STAFF = db.STAFF.Where(Function(s) s.NRIC = id And s.STATUSCODE = "A").SingleOrDefault
            Dim StaffDepartment As New model.STAFFDEPARTMENT

            If IsNothing(Staff) Then
                Return HttpNotFound()
            End If

            Dim StaffShift As model.STAFFSHIFT = db.STAFFSHIFT.Where(Function(ss) ss.NRIC = Staff.NRIC).SingleOrDefault

            With StaffDepartment
                .STAFFNO = Staff.STAFFNO
                .NRIC = Staff.NRIC
                .DEPARTMENTID = Staff.DEPARTMENTID
                If IsNothing(StaffShift) Then
                    .SHIFTID = ""
                Else
                    .SHIFTID = StaffShift.SHIFTID
                End If
                .FIRSTNAME = Staff.FIRSTNAME
                .LASTNAME = Staff.LASTNAME
                .ISRESIGNED = Staff.ISRESIGNED
                .RESIGNEDON = Staff.RESIGNEDON
                .DEPARTMENTLIST = GetDepartmentList(Staff.DEPARTMENTID)
                If IsNothing(StaffShift) Then
                    .SHIFTLIST = GetShiftList(Nothing)
                Else
                    .SHIFTLIST = GetShiftList(StaffShift.SHIFTID)
                End If
                .GENDER = Staff.GENDER
                .CONTACTNO1 = Staff.CONTACTNO1
                .ADDRESS = Staff.ADDRESS
                .EMAIL = Staff.EMAIL
                .GRADE = Staff.GRADE
            End With

            Return StaffDepartment
        End Function

        Function Delete(ByVal id As String)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim StaffDepartment = GetStaffDepartmentInfo(id)

            Return View(StaffDepartment)
        End Function

        Function DeleteStaff(ByVal id As String)
            Dim Staff As model.STAFF = db.STAFF.Where(Function(s) s.NRIC = id).SingleOrDefault

            If Not IsNothing(Staff) Then
                With Staff
                    .STATUSCODE = "D"
                    .UPDATEDBY = "SYSTEM"
                    .UPDATEDON = Now
                End With

                db.Entry(Staff).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()
            End If

            Return Json("SUCCESS_DELETE", JsonRequestBehavior.AllowGet)
        End Function

        Function ResetPassword(ByVal id As String)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim StaffDepartment = GetStaffDepartmentInfo(id)

            Return View(StaffDepartment)
        End Function

        Function ResetPasswordStaff(ByVal id As String)
            Dim Staff As model.STAFF = db.STAFF.Where(Function(s) s.NRIC = id).SingleOrDefault

            If Not IsNothing(Staff) Then
                With Staff
                    .PASSWORD = Nothing
                    .UPDATEDBY = "SYSTEM"
                    .UPDATEDON = Now
                End With

                db.Entry(Staff).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()
            End If

            Return Json("SUCCESS_RESET_PASSWORD", JsonRequestBehavior.AllowGet)
        End Function

        Function InitProfileUpdate()
            Dim id = "750101065066"
            Dim StaffDepartment = GetStaffDepartmentInfo(id)

            Dim result As New List(Of Object)
            result.Add(StaffDepartment)

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function ProfileUpdate(ByVal StaffParam As model.Staff) As ActionResult
            ' Get entire staff value from db
            Dim Staff As model.STAFF = db.STAFF.Where(Function(s) s.NRIC = StaffParam.NRIC).SingleOrDefault

            ' Update necessary fields
            If Not IsNothing(Staff) Then
                With Staff
                    .FIRSTNAME = StaffParam.FIRSTNAME
                    .LASTNAME = StaffParam.LASTNAME
                    .GENDER = StaffParam.GENDER
                    .CONTACTNO1 = StaffParam.CONTACTNO1
                    .ADDRESS = StaffParam.ADDRESS
                    .EMAIL = StaffParam.EMAIL
                    .GRADE = StaffParam.GRADE
                End With

                db.Entry(Staff).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()
            End if

            Return Json("SUCCESS_UPDATE_PROFILE", JsonRequestBehavior.AllowGet)
        End Function

    End Class
End Namespace