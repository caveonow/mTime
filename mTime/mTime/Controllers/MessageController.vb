Imports System.Web.Mvc

Namespace Controllers

    Public Class MessageController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Message
        Function Index() As ActionResult
            CollectAllNecessaryViewBag()
            SetViewBagPersonalMessageList()


            Return View()
        End Function

        Function SetViewBagPersonalMessageList()
            Dim sortedList = From PersonalMessage In db.PERSONALMESSAGE.Where(Function(pm) Not pm.ISDELETED).ToList().OrderByDescending(Function(pm) pm.CREATEDON).ToList
                             Join Staff In db.STAFF.ToList On PersonalMessage.NRIC Equals Staff.NRIC
                             Select PERSONALMESSAGEID = PersonalMessage.PERSONALMESSAGEID, CREATEDON = PersonalMessage.CREATEDON, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, ABOUT = PersonalMessage.ABOUT

            ViewBag.PersonalMessageList = sortedList
            ViewBag.PersonalMessageListCount = sortedList.Count
        End Function

        Function MessageIndex()
            Dim sortedList = From PersonalMessage In db.PERSONALMESSAGE.Where(Function(pm) Not pm.ISDELETED).ToList().OrderByDescending(Function(pm) pm.CREATEDON).ToList
                             Join Staff In db.STAFF.ToList On PersonalMessage.NRIC Equals Staff.NRIC
                             Select PERSONALMESSAGEID = PersonalMessage.PERSONALMESSAGEID, CREATEDON = PersonalMessage.CREATEDON, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, ABOUT = PersonalMessage.ABOUT

            Dim htmlPersonalMessageList As New List(Of String)
            For Each personalMessageItem As Object In sortedList
                htmlPersonalMessageList.Add(
                    "<tr><td><div class='ball_color1' onclick='onSelectMessageItem(" + personalMessageItem.PERSONALMESSAGEID.ToString +
                    ")'></div></td><td>" + personalMessageItem.CREATEDON +
                    "</td><td>" + personalMessageItem.NAME +
                    "</td><td>" + personalMessageItem.ABOUT + "</td></tr>"
                )
            Next

            Dim result As New List(Of Object)
            result.Add(htmlPersonalMessageList)

            If sortedList.Count > 0 Then
                result.Add("<span>Total : " + sortedList.Count.ToString() + " row(s)</span>")
            Else
                result.Add("<span>Total : " + sortedList.Count.ToString() + " row</span>")
            End If

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function AnnouncementIndex()
            CollectAllNecessaryViewBag()
            Dim sortedList = db.ANNOUNCEMENT.ToList().OrderByDescending(Function(a) a.ANNOUNCEMENTID).ToList

            Dim htmlAnnouncementList As New List(Of String)
            For Each announcementItem As model.ANNOUNCEMENT In sortedList
                htmlAnnouncementList.Add(
                    "<tr><td><div class='fa fa-mouse-pointer' style='cursor: pointer; margin: 5px' onclick='onSelectAnnouncementItem(" + announcementItem.ANNOUNCEMENTID.ToString +
                    ")'/></td><td>" + announcementItem.TITLE +
                    "</td><td>" + Format(announcementItem.VALIDFROM, "Short Date") +
                    "</td><td>" + Format(announcementItem.VALIDTO, "Short Date") +
                    "</td></tr>"
                )
            Next

            Dim result As New List(Of Object)
            result.Add(htmlAnnouncementList)

            If sortedList.Count > 0 Then
                result.Add("Total : " + sortedList.Count.ToString() + " row(s)")
            Else
                result.Add("Total : " + sortedList.Count.ToString() + " row")
            End If

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function FeedbackIndex()
            CollectAllNecessaryViewBag()
            Dim sortedList = From Feedback In db.FEEDBACK.ToList().Where(Function(f) (DateDiff(DateInterval.Month, f.CREATEDON.Value, DateTime.Now) < 3) Or (DateDiff(DateInterval.Month, f.CREATEDON.Value, DateTime.Now) >= 3 And f.CREATEDON.Value.Day >= DateTime.Now.Day)).OrderByDescending(Function(f) f.CREATEDON).ToList
                             Join Staff In db.STAFF.ToList On Feedback.NRIC Equals Staff.NRIC
                             Select FEEDBACKID = Feedback.FEEDBACKID, CREATEDON = Feedback.CREATEDON, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, CONTENT = Feedback.CONTENT, ISREPLIED = Feedback.ISREPLIED

            Dim htmlFeedbackList As New List(Of String)
            For Each feedbackItem As Object In sortedList
                htmlFeedbackList.Add(
                    "<tr><td><div class='fa fa-mouse-pointer" + If(feedbackItem.ISREPLIED, "", " font_bold") + "' style='cursor: pointer; margin: 5px' onclick='onSelectFeedbackItem(" + feedbackItem.FEEDBACKID.ToString +
                    ")'/></td><td class='" + If(feedbackItem.ISREPLIED, "", " font_bold") + "'>" + feedbackItem.CREATEDON +
                    "</td><td class='" + If(feedbackItem.ISREPLIED, "", " font_bold") + "'>" + feedbackItem.NAME +
                    "</td><td class='" + If(feedbackItem.ISREPLIED, "", " font_bold") + "'>" + feedbackItem.CONTENT +
                    "</td></tr>"
                )
            Next

            Dim result As New List(Of Object)
            result.Add(htmlFeedbackList)

            If sortedList.Count > 0 Then
                result.Add("Total : " + sortedList.Count.ToString() + " row(s)")
            Else
                result.Add("Total : " + sortedList.Count.ToString() + " row")
            End If

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function CollectAllNecessaryViewBag()
            ' Personal Message
            ViewBag.PersonalMessageList = ""
            ViewBag.PersonalMessageListCount = 0

            ' Announcement
            ViewBag.AnnouncementList = ""
            ViewBag.AnnouncementListCount = 0

            ' Feedback
            ViewBag.FeedbackList = ""
            ViewBag.FeedbackListCount = 0

        End Function

        Function GetMessageItem(ByVal id As Integer?)
            Dim sortedList = From PersonalMessage In db.PERSONALMESSAGE.Where(Function(pm) pm.PERSONALMESSAGEID = id).ToList
                             Join Staff In db.STAFF.ToList On PersonalMessage.NRIC Equals Staff.NRIC
                             Select PERSONALMESSAGEID = PersonalMessage.PERSONALMESSAGEID, CREATEDON = PersonalMessage.CREATEDON, ABOUT = PersonalMessage.ABOUT, CONTENT = PersonalMessage.CONTENT, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME

            Dim result As New List(Of Object)
            result.Add(sortedList.First.PERSONALMESSAGEID)
            result.Add(sortedList.First.NAME)
            result.Add(Format(sortedList.First.CREATEDON, "General date"))
            result.Add(sortedList.First.ABOUT)
            result.Add(sortedList.First.CONTENT)

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function GetAnnouncementItem(ByVal id As Integer?)
            Dim Announcement As model.ANNOUNCEMENT = db.ANNOUNCEMENT.Find(id)

            Dim result As New List(Of Object)
            result.Add(Announcement.ANNOUNCEMENTID)
            result.Add(Announcement.TITLE)
            result.Add(Format(Announcement.VALIDFROM, "Short Date"))
            result.Add(Format(Announcement.VALIDTO, "Short Date"))
            result.Add(Announcement.REMARK)

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        Function GetFeedbackItem(ByVal id As Integer?)
            Dim sortedList = From Feedback In db.FEEDBACK.Where(Function(f) f.FEEDBACKID = id).ToList
                             Join Staff In db.STAFF.ToList On Feedback.NRIC Equals Staff.NRIC
                             Select FEEDBACKID = Feedback.FEEDBACKID, CREATEDON = Feedback.CREATEDON, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, CONTENT = Feedback.CONTENT

            Dim result As New List(Of Object)
            result.Add(sortedList.First.FEEDBACKID)
            result.Add(sortedList.First.NAME)
            result.Add(Format(sortedList.First.CREATEDON, "General date"))
            result.Add(sortedList.First.CONTENT)

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function DeletePersonalMessage(ByVal id As Integer?)
            Dim PersonalMessage As model.PERSONALMESSAGE = db.PERSONALMESSAGE.Find(id)

            PersonalMessage.ISDELETED = True
            PersonalMessage.DELETEBY = "SYSTEM"
            PersonalMessage.DELETEON = Now

            db.Entry(PersonalMessage).State = System.Data.Entity.EntityState.Modified
            db.SaveChanges()

            Return Json("SUCCESS_DELETE", JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function DeleteAnnouncement(ByVal id As Integer?)
            Dim Announcement As model.ANNOUNCEMENT = db.ANNOUNCEMENT.Find(id)

            db.ANNOUNCEMENT.Remove(Announcement)
            db.SaveChanges()

            Return Json("SUCCESS_DELETE", JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function CreateNewAnnoucement(ByVal title As String, ByVal remark As String, ByVal validFrom As Date?, ByVal validTo As Date?)
            ' input validation
            Dim isValid = True
            Dim result As New List(Of Object)

            If String.IsNullOrEmpty(title) Then
                isValid = False
                result.Add("ERROR_TITLE")
            End If

            If String.IsNullOrEmpty(remark) Then
                isValid = False
                result.Add("ERROR_REMARK")
            End If

            If IsNothing(validFrom) Then
                isValid = False
                result.Add("ERROR_VALIDFROM")
            End If

            If IsNothing(validTo) Then
                isValid = False
                result.Add("ERROR_VALIDTO")
            End If

            If Not isValid Then
                Return Json(result, JsonRequestBehavior.AllowGet)
            End If

            ' transfer into model
            Dim Announcement As New model.ANNOUNCEMENT

            Announcement.TITLE = title
            Announcement.REMARK = remark
            Announcement.VALIDFROM = validFrom
            Announcement.VALIDTO = validTo
            Announcement.CREATEDON = Now
            Announcement.CREATEDBY = "SYSTEM"

            ' actual saving
            db.ANNOUNCEMENT.Add(Announcement)
            db.SaveChanges()

            Return Json("SUCCESS_SAVE", JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function DeleteFeedback(ByVal id As Integer?)
            Dim Feedback As model.FEEDBACK = db.FEEDBACK.Find(id)

            db.FEEDBACK.Remove(Feedback)
            db.SaveChanges()

            Return Json("SUCCESS_DELETE", JsonRequestBehavior.AllowGet)
        End Function

        <HttpGet>
        Function InitNewPersonalMessage(ByVal idFeedback As String)
            ' Get all Staff
            Dim sortedList = db.STAFF.SortBy("FIRSTNAME").SortBy("LASTNAME").ToList

            Dim result As New List(Of Object)
            result.Add(sortedList)

            If Not IsNothing(idFeedback) Then
                Dim feedbackList = From Feedback In db.FEEDBACK.Where(Function(f) f.FEEDBACKID = idFeedback).ToList
                                   Join Staff In db.STAFF.ToList On Feedback.NRIC Equals Staff.NRIC
                                   Select NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, NRIC = Staff.NRIC

                result.Add(feedbackList.First.NRIC)
                result.Add(feedbackList.First.NAME)
            End If

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost>
        Function ReplyFeedback(ByVal nricList As List(Of String), ByVal about As String, ByVal content As String, ByVal idFeedback As Integer?)
            ' input validation
            Dim isValid = True
            Dim result As New List(Of Object)

            If IsNothing(nricList) Then
                isValid = False
                result.Add("ERROR_STAFF")
            End If

            If String.IsNullOrEmpty(about) Then
                isValid = False
                result.Add("ERROR_ABOUT")
            End If

            If String.IsNullOrEmpty(content) Then
                isValid = False
                result.Add("ERROR_CONTENT")
            End If

            If Not isValid Then
                Return Json(result, JsonRequestBehavior.AllowGet)
            End If

            For Each nricItem In nricList
                ' transfer into model
                Dim PersonalMessage As New model.PERSONALMESSAGE

                PersonalMessage.NRIC = nricItem
                PersonalMessage.ABOUT = about
                PersonalMessage.CONTENT = content
                PersonalMessage.FEEDBACKID = idFeedback
                PersonalMessage.ISREAD = False
                PersonalMessage.READON = Nothing
                PersonalMessage.ISDELETED = False
                PersonalMessage.DELETEBY = Nothing
                PersonalMessage.DELETEON = Nothing
                PersonalMessage.CREATEDON = Now
                PersonalMessage.CREATEDBY = "SYSTEM"

                ' actual saving
                db.PERSONALMESSAGE.Add(PersonalMessage)
                db.SaveChanges()

                ' Update feedback
                If Not IsNothing(idFeedback) Then
                    Dim Feedback As model.FEEDBACK = db.FEEDBACK.Find(idFeedback)

                    Feedback.ISREPLIED = True
                    Feedback.REPLIEDBY = "SYSTEM"
                    Feedback.REPLIEDON = Now

                    db.Entry(Feedback).State = System.Data.Entity.EntityState.Modified
                    db.SaveChanges()
                End If
            Next

            Return Json("SUCCESS_REPLY", JsonRequestBehavior.AllowGet)
        End Function
    End Class

End Namespace