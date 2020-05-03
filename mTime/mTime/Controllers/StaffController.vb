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

            model.DEPARTMENTLIST = GetDepartmentList()
            model.SHIFTLIST = GetShiftList()

            Dim staffList = (From staff In db.STAFF
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

        Public Function GetDepartmentList() As List(Of SelectListItem)

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

                itemList.Add(item)

            Next

            Return itemList

        End Function

        Public Function GetShiftList() As List(Of SelectListItem)

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

                itemList.Add(item)

            Next

            Return itemList

        End Function

        <HttpPost>
        Public Function Index(ByVal FirstName As String, LastName As String, NRIC As String, DEPARTMENTID As String, SHIFTID As String) As ActionResult

            Dim model = New STAFFDEPARTMENT

            model.DEPARTMENTLIST = GetDepartmentList()
            model.SHIFTLIST = GetShiftList()

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

            model.DEPARTMENTLIST = GetDepartmentList()
            model.SHIFTLIST = GetShiftList()

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

            Dim conn = New FbConnection("database=localhost:C:\EntryPass\P1_Server\database\COMPANY.FDB;user=;password=;port:3050;")
            'Dim conn = New FbConnection("database=localhost:C:\Users\henly\Desktop\freelance\P1_Server\database\COMPANY.FDB;user=;password=;port:3050;")
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

                        modelStaff = db.STAFF.Find(strIC)

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

    End Class
End Namespace