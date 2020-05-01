Imports System.Net
Imports mTime

Namespace Controllers
    Public Class FeedbackController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Feedback
        Function Index() As ActionResult
            Dim sortedList = db.FEEDBACK.SortBy("FEEDBACKID").ToList

            Return View()
        End Function

        ' Staff Feedback
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function SaveStaffFeedback(ByVal Feedback As model.FEEDBACK)
            If IsNothing(Feedback.CONTENT) Then
                Return Json("failed", JsonRequestBehavior.AllowGet)
            Else
                Feedback.NRIC = "123"
                Feedback.ISREPLIED = False
                Feedback.REPLIEDBY = Nothing
                Feedback.REPLIEDON = Nothing
                Feedback.CREATEDBY = "SYSTEM"
                Feedback.CREATEDON = Now

                db.FEEDBACK.Add(Feedback)
                db.SaveChanges()

                Return Json("success", JsonRequestBehavior.AllowGet)
            End If
        End Function

        ' Admin Feedback
        Function GetAdminFeedback()
            SetViewBagFeedbackList()
        End Function

        Function SetViewBagFeedbackList()
            Dim sortedList = db.FEEDBACK.ToList().OrderByDescending(Function(c) c.CREATEDON).ToList()

            ViewBag.FeedbacList = sortedList
        End Function
    End Class
End Namespace