Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonalMessageController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: PersonalMessage
        Function Index() As ActionResult
            SetViewBagPersonalMessageList()

            '# Return updated dataset
            Return View()
        End Function

        Function SetViewBagPersonalMessageList()
            Dim sortedList = From PersonalMessage In db.PERSONALMESSAGE.Where(Function(pm) Not pm.ISDELETED).ToList
                             Join Staff In db.STAFF.ToList On PersonalMessage.NRIC Equals Staff.NRIC
                             Select PERSONALMESSAGEID = PersonalMessage.PERSONALMESSAGEID, ISREAD = PersonalMessage.ISREAD, CREATEDON = PersonalMessage.CREATEDON, ABOUT = PersonalMessage.ABOUT, CONTENT = PersonalMessage.CONTENT, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME

            ViewBag.PersonalMessageList = sortedList
            ViewBag.PersonalMessageListCount = sortedList.Count
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

            ' Update status to read
            Dim PersonalMessageModel As model.PERSONALMESSAGE = db.PERSONALMESSAGE.Find(id)

            PersonalMessageModel.ISREAD = True
            PersonalMessageModel.READON = Now

            db.Entry(PersonalMessageModel).State = System.Data.Entity.EntityState.Modified
            db.SaveChanges()

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

        Function MessageIndex()
            Dim sortedList = From PersonalMessage In db.PERSONALMESSAGE.Where(Function(pm) Not pm.ISDELETED).ToList().OrderByDescending(Function(pm) pm.CREATEDON).ToList
                             Join Staff In db.STAFF.ToList On PersonalMessage.NRIC Equals Staff.NRIC
                             Select PERSONALMESSAGEID = PersonalMessage.PERSONALMESSAGEID, ISREAD = PersonalMessage.ISREAD, CREATEDON = PersonalMessage.CREATEDON, NAME = Staff.FIRSTNAME + " " + Staff.LASTNAME, ABOUT = PersonalMessage.ABOUT

            Dim htmlPersonalMessageList As New List(Of String)
            For Each personalMessageItem As Object In sortedList
                htmlPersonalMessageList.Add(
                    "<tr><td><div id='id-email-" + personalMessageItem.PERSONALMESSAGEID.ToString + "' class='fa " + If(personalMessageItem.ISREAD, "fa-envelope-open", "fa-envelope") + " btn_email filter1' onclick='onSelectMessageItem(" + personalMessageItem.PERSONALMESSAGEID.ToString +
                    ")'></div><div class='fa fa-trash-o btn_trash filter1' onclick='deletePersonalMessage(" + personalMessageItem.PERSONALMESSAGEID.ToString + ")'></div></td><td>" + personalMessageItem.CREATEDON +
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
    End Class
End Namespace