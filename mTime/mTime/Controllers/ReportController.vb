Imports System.Web.Mvc

Namespace Controllers

    Public Class ReportController
        Inherits Controller

        ' GET: Report
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Ratio Analysis
        Function _RatioAnalysis() As ActionResult
            Return View()
        End Function

        ' GET: By Employee
        Function _ByEmployee() As ActionResult
            Return View()
        End Function

        ' GET: By Department
        Function _ByDepartment() As ActionResult
            Return View()
        End Function

        ' GET: Analysis
        Function _Analysis() As ActionResult
            Return View()
        End Function

    End Class

End Namespace