Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonalMessageController
        Inherits Controller

        ' GET: PersonalMessage
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace