Imports System.Net
Imports mTime
Imports System.IO
Imports System.Web.Mvc
Imports mTime.model

Namespace Controllers
    Public Class imgController
        Inherits Controller

        Private db As New model.MasterDB

        '' GET: img
        '<HttpPost>
        'Public Function UploadImg(ByVal postedFile As HttpPostedFileBase) As ActionResult

        '    If postedFile IsNot Nothing Then
        '        'Dim fileName As String = path.GetFileName(postedFile.FileName)
        '        Dim fileName As String = "Company Logo.jpg"
        '        Dim path As String = Server.MapPath("~/img/")

        '        If Not Directory.Exists(path) Then
        '            Directory.CreateDirectory(path)
        '        End If

        '        postedFile.SaveAs(path & fileName)
        '        ViewBag.ImageUrl = "img/" & fileName
        '    End If

        '    Return View()
        'End Function

    End Class
End Namespace