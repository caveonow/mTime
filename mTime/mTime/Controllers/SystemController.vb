Imports System.Net
Imports mTime
Imports System.Web.Mvc
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
                UploadImg(postedFile)

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
        Public Function UploadImg(ByVal postedFile As HttpPostedFileBase) As ActionResult

            If postedFile IsNot Nothing Then
                'Dim fileName As String = path.GetFileName(postedFile.FileName)
                Dim fileName As String = "Company Logo.jpg"
                Dim path As String = Server.MapPath("~/img/")

                If Not Directory.Exists(path) Then
                    Directory.CreateDirectory(path)
                End If

                postedFile.SaveAs(path & fileName)
                ViewBag.ImageUrl = "img/" & fileName
            End If

            Return View()
        End Function


    End Class
End Namespace