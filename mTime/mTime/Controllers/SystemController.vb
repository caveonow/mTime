Imports System.Web.Mvc

Namespace Controllers
    Public Class SystemController
        Inherits Controller

        ' GET: System
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace