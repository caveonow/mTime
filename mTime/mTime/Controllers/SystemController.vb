Imports System.Net
Imports mTime
Imports System.Web
Imports mTime.model
Imports System.IO

Namespace Controllers
    Public Class SystemController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: System
        Function Index() As ActionResult
            ' get result from db
            Dim Company = db.COMPANY.First

            Return View(Company)
        End Function


        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal company As model.COMPANY) As ActionResult

            Dim blnIsDuplicated As Boolean

            'blnIsDuplicated = db.Department.Any(Function(model) model.DEPARTMENTNAME = department.DEPARTMENTNAME)

            'If blnIsDuplicated = True Then
            '    ModelState.AddModelError("DEPARTMENTNAME", "Title is duplicated")
            'Else
            '    If (ValidateURL(HyperLink.URL)) = False Then
            '        ModelState.AddModelError("URL", "URL is invalid")
            '    End If
            'End If

            If ModelState.IsValid Then

                db.COMPANY.Add(company)
                db.SaveChanges()

                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View()

            End If

            Return View()

        End Function

        ' GET : Edit-Department
        Function Edit(ByVal id As String) As ActionResult

            If IsNothing(id) Then
                Console.WriteLine("Hello World.")
                Create()
            End If

            Dim Department As model.DEPARTMENT = db.DEPARTMENT.Find(id)

            If IsNothing(Department) Then
                Return HttpNotFound()
            End If

            Return View()

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="COMPANYID, COMPANYNAME, ADDRESSLINE1, ADDRESSLINE2, ADDRESSLINE3, TELNO, FAXNO, COMPANYLOGOPATH, COMPANYHEADERPATH, HOMEPAGEHEADERPATH, DEFAULTLANGUAGE, STARTEDON, ALLOWTOSUBMITREASONIN")> ByVal COMPANYItem As COMPANY) As ActionResult

            'If (ValidateURL(hyperlink.URL)) = False Then
            '    ModelState.AddModelError("URL", "URL is invalid")
            'End If

            If Request.Files.Count > 0 Then
                Dim A As String = "A"
            End If

            If ModelState.IsValid Then
                UploadImg(COMPANYItem, postedFile, Nothing, Nothing)

                db.Entry(COMPANYItem).State = System.Data.Entity.EntityState.Modified
                COMPANYItem.STARTEDON = Today()
                db.SaveChanges()

                ViewBag.Result = "OK"
                Return RedirectToAction("Index")

            End If

            Return View()
        End Function

        ' GET: img
        <HttpPost>
        Public Function UploadImg(ByVal Company As model.COMPANY,
                                  ByVal postedFile1 As HttpPostedFileBase,
                                  ByVal postedFile2 As HttpPostedFileBase,
                                  ByVal postedFile3 As HttpPostedFileBase) As ActionResult

            If postedFile1 IsNot Nothing Then
                'Dim fileName As String = path.GetFileName(postedFile.FileName)
                Dim fileName1 As String = "Company Logo.jpg"
                Dim path1 As String = Server.MapPath("~/img/")

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If

                postedFile1.SaveAs(path1 & fileName1)
                ViewBag.ImageUrl = "img/" & fileName1



                'Dim fileName As String = path.GetFileName(postedFile.FileName)
                Dim fileName2 As String = "Company Header.jpg"
                Dim path2 As String = Server.MapPath("~/img/")

                If Not Directory.Exists(path2) Then
                    Directory.CreateDirectory(path2)
                End If

                postedFile2.SaveAs(path2 & fileName2)
                ViewBag.ImageUrl = "img/" & fileName2



                'Dim fileName As String = path.GetFileName(postedFile.FileName)
                Dim fileName3 As String = "Home Header.jpg"
                Dim path3 As String = Server.MapPath("~/img/")

                If Not Directory.Exists(path3) Then
                    Directory.CreateDirectory(path3)
                End If

                postedFile3.SaveAs(path3 & fileName3)
                ViewBag.ImageUrl = "img/" & fileName3
            End If

            If ModelState.IsValid Then
                db.Entry(Company).State = System.Data.Entity.EntityState.Modified
                Company.STARTEDON = Today()

                Debug.WriteLine(Company.COMPANYHEADERPATH)
                Debug.WriteLine(Company.HOMEPAGEHEADERPATH)

                db.SaveChanges()

                ViewBag.Result = "OK"
            End If

            Dim destinationURL As String = "index"
            Return RedirectToAction(HttpUtility.UrlEncode(destinationURL))

            'Return RedirectToAction(HttpUtility.UrlDecode(destinationURL))
        End Function


    End Class
End Namespace