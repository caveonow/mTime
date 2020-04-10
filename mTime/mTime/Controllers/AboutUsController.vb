Imports System.Web.Mvc

Namespace Controllers
    Public Class AboutUsController
        Inherits Controller

        ' GET: AboutUs
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace