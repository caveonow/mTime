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

            'As IOrderedQueryable(Of STAFFSHIFT)
            'Dim list As List(Of STAFFSHIFT)

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

        Function SaveImport(ByVal StaffList As String)
            Dim FirebirdList = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of model.FIREBIRDSTAFF))(StaffList)
            For Each item In FirebirdList
                Debug.WriteLine(item.NRIC)
                Debug.WriteLine(item.NAME)
                Debug.WriteLine(item.DEPARTMENTID)
                Debug.WriteLine(item.SHIFTID)
                Debug.WriteLine("===========")
            Next
        End Function

        <HttpPost>
        Function Import(ByVal model As model.STAFFDEPARTMENT, firebirdList As IList(Of FIREBIRDSTAFF)) As ActionResult


            Dim strName As String
            Dim strNRIC As String
            Dim strDepartmentID As String
            Dim strShiftID As String

            'For Each obj In model.FIREBIRDSTAFFLIST
            '    strName = obj.NAME
            'Next

            'model.DEPARTMENTLIST = firebirdList.ToList

            'Dim intCount = model.DEPARTMENTLIST.Count

            'Debug.Print(intCount.ToString)

            'For Each obj In model.FIREBIRDSTAFFLIST


            'Next

            'Dim list = model.FIREBIRDSTAFFLIST




            'If ModelState.IsValid Then
            '    strName = model.FIREBIRDSTAFFLIST(0).NAME.ToString
            'End If

            'Dim itemList As New List(Of SELECTEDSTAFF)

            'itemList = list
            'Dim intCount = List.Count

            'Dim intCount = model.FIREBIRDSTAFFLIST
            'Dim itemList As New List(Of SELECTEDSTAFF)

            'itemList = model.FIREBIRDSTAFFLIST

            'Dim intCount = itemList.Count
            'Dim intNo As Integer


            'For intNo = 0 To intCount - 1
            '    strName = itemList(intNo).NAME

            'Next



            If ModelState.IsValid Then

                For Each item In model.FIREBIRDSTAFFLIST
                    strName = item.NAME
                    strNRIC = item.NRIC
                    strDepartmentID = item.DEPARTMENTID
                    strShiftID = item.SHIFTID
                Next

            End If



            'Dim item As ListItem

            'strName = list(0).NAME

            'For Each item In model.FIREBIRDSTAFFLIST
            '    strName = item.NAME
            '    strNRIC = item.NRIC
            '    strDepartmentID = item.DEPARTMENTID
            '    strShiftID = item.SHIFTID
            'Next

            Return View()
        End Function



        Function GetFirebirdStaff() As List(Of FIREBIRDSTAFF)

            Dim model = New STAFFDEPARTMENT

            Dim conn = New FbConnection("database=localhost:C:\Users\henly\Desktop\freelance\P1_Server\database\COMPANY.FDB;user=;password=;port:3050;")
            Dim cmd As FbCommand

            conn.Open()
            cmd = New FbCommand("SELECT * FROM STAFF", conn)

            Dim dr = cmd.ExecuteReader
            Dim strStaffNo As String
            Dim strName As String
            Dim strIC As String

            Dim firebirdStaff As model.FIREBIRDSTAFF
            Dim newList As New List(Of FIREBIRDSTAFF)

            If dr.HasRows Then

                strStaffNo = ""
                strName = ""
                strIC = ""

                While (dr.Read)

                    firebirdStaff = New model.FIREBIRDSTAFF

                    If Not IsDBNull(dr("StaffNo")) Then
                        strStaffNo = dr("StaffNo")
                    End If
                    If Not IsDBNull(dr("Name")) Then
                        strName = dr("Name")
                    End If
                    If Not IsDBNull(dr("IC")) Then
                        strIC = dr("IC")
                    End If

                    With firebirdStaff
                        .STAFFNO = strStaffNo
                        .NAME = strName
                        .NRIC = strIC
                        .DEPARTMENTID = vbNull
                        .SHIFTID = vbNull
                    End With

                    '# Add record to list
                    newList.Add(firebirdStaff)

                End While

            End If

            conn.Close()
            conn.Dispose()

            Return newList

        End Function

    End Class
End Namespace