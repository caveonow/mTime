Imports System.Net
Imports mTime


Namespace Controllers
    Public Class HyperlinkController
        Inherits Controller

        Private db As New model.MasterDB

        '' GET: Hyperlink
        'Function Index() As ActionResult

        '    '# Return updated dataset
        '    'Return View(db.HYPERLINK.ToList())
        '    Return View()
        'End Function

        'Function Details(ByRef id As Integer) As ActionResult

        '    If IsNothing(id) Then
        '        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        '    End If

        '    Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

        '    If IsNothing(hyperlink) Then
        '        Return HttpNotFound()
        '    End If
        '    Return View(hyperlink)

        'End Function


        ' GET : Create-Hyperlink
        Function Create() As ActionResult
            Return View()
        End Function

        'Function Create(<Bind(Include:="HyperlinkID, Title, URL, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn")> ByVal hyperlink As HYPERLINK) As ActionResult

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal hyperlink As model.HYPERLINK) As ActionResult

            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.HYPERLINK.Any(Function(model) model.TITLE = hyperlink.TITLE)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("TITLE", "Title is duplicated")
            Else
                If (ValidateURL(hyperlink.URL)) = False Then
                    ModelState.AddModelError("URL", "URL is invalid")
                End If
            End If

            If ModelState.IsValid Then

                hyperlink.CREATEDON = Now
                hyperlink.CREATEDBY = "Nick"

                db.HYPERLINK.Add(hyperlink)
                db.SaveChanges()

                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View()

            End If

            Return View(hyperlink)

        End Function

        Function ValidateURL(ByVal URL As String) As Boolean

            Dim IsValidURL As Boolean = False
            Dim uriResult As Uri = Nothing

            'IsValidURL = Uri.TryCreate(URL, UriKind.Absolute, uriResult) & uriResult.Scheme = Uri.UriSchemeHttp

            If (Uri.IsWellFormedUriString(URL, UriKind.Absolute)) Then
                IsValidURL = True
            End If

            Return IsValidURL

        End Function

        ' GET : Edit-Hyperlink
        Function Edit(ByVal id As Integer) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

            If IsNothing(hyperlink) Then
                Return HttpNotFound()
            End If


            'Debug.Print(hyperlink.HYPERLINKID)

            Return View(hyperlink)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="HYPERLINKID, TITLE, URL, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal hyperlink As model.HYPERLINK) As ActionResult

            If (ValidateURL(hyperlink.URL)) = False Then
                ModelState.AddModelError("URL", "URL is invalid")
            End If

            If ModelState.IsValid Then

                hyperlink.UPDATEDBY = "NICK"
                hyperlink.UPDATEDON = Now

                db.Entry(hyperlink).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                ''# Return to Index 
                'Return RedirectToRoute("HyperlinkList")


                ViewBag.Result = "OK"
                'Return RedirectToRoute("HyperlinkList")
                Return View(hyperlink)

            End If

            Return View(hyperlink)
        End Function

        ' GET : Delete-Hyperlink
        Function Delete(ByVal id As Integer) As ActionResult

            Debug.Print("Get : " & id.ToString)

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

            If IsNothing(hyperlink) Then
                Return HttpNotFound()
            End If
            Return View(hyperlink)

        End Function

        'Function Delete(<Bind(Include:="HYPERLINKID, TITLE, URL, CREATEDBY, CREATEDON, UPDAEDBY, UPDATEDBY")> ByVal hyperlink As model.HYPERLINK) As ActionResult
        '<ActionName("Delete")>

        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult

            Debug.Print(id.ToString)

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)
            db.HYPERLINK.Remove(hyperlink)
            db.SaveChanges()

            '# Return to Index 
            Return RedirectToRoute("HyperlinkList")

        End Function

        Protected Overrides Sub Dispose(disposing As Boolean)

            If (disposing) Then
                db.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        'Function Cancel() As ActionResult
        '    Return RedirectToRoute("HyperlinkList")
        'End Function

    End Class
End Namespace