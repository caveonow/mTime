Imports System.Web.Mvc

Namespace Controllers

    Public Class AdministrationController
        Inherits Controller

        ' GET: Administration
        Function Superior() As ActionResult
            Return View()
        End Function

        Function Administrator() As ActionResult
            Return View()
        End Function

    End Class

End Namespace