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
            Dim company = db.COMPANY.First

            Return View(company)
        End Function

        <HttpGet>
        Public Function DefaultSetting(ByVal Company As model.COMPANY) As ActionResult

            Company.GRACEPERIOD = "60"
            Company.MAXANNOUNCE = "60"
            Company.ANNOUNCEEXPDAY = "60"

            Return View(Company)
        End Function

        ' GET: Save Company
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

                db.SaveChanges()

                ViewBag.Result = "OK"
            End If

            Dim destinationURL As String = "index"
            Return RedirectToAction(HttpUtility.UrlEncode(destinationURL))

            'Return RedirectToAction(HttpUtility.UrlDecode(destinationURL))
        End Function


        ' GET: Save Setting
        <HttpPost>
        Public Function Setting(ByVal Company As model.COMPANY) As ActionResult

            'If ModelState.IsValid Then
            db.Entry(Company).State = System.Data.Entity.EntityState.Modified
                Company.STARTEDON = Today()

                db.SaveChanges()

                ViewBag.Result = "OK"
            'End If

            Dim destinationURL As String = "index"
            Return RedirectToAction(HttpUtility.UrlEncode(destinationURL))

            'Return RedirectToAction(HttpUtility.UrlDecode(destinationURL))
        End Function
    End Class
End Namespace