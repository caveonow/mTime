'Imports System.Web.Mvc

'Namespace Controllers
'    Public Class SharedController
'        Inherits Controller

'        ' GET: Shared
'        Function Index() As ActionResult
'            Return View()
'        End Function
'    End Class
'End Namespace

Public Class SharedController
    Inherits System.Web.Mvc.Controller

    Function _SubMenuLeft() As ActionResult
        Return View()
    End Function

    Function _AdminMenuTop() As ActionResult
        Return View()
    End Function

End Class