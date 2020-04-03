Imports System.Web.Mvc

Namespace Controllers
    Public Class FAQController
        Inherits Controller

        ' GET: FAQ
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace