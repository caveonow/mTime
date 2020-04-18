@ModelType mTime.model.COMPANY

@Using (Html.BeginForm("UploadImg", "System", method:=FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()

    @Html.HiddenFor(Function(Model) Model.COMPANYID)
    @Html.HiddenFor(Function(Model) Model.COMPANYLOGOPATH)

    @<div>
        <input type="file" name="postedFile" accept=".png" class="fa fa-folder-open pt1_b2_folderbtn filter1" />
    </div>
End Using

@Code

    If TempData("ImgUploadResult") <> "" Then

        If TempData("ImgUploadResult") = "OK" Then
            @<script>
                 window.onload = function () {
                     $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                 };
            </script>
        Else


            @<script>
                 window.onload = function () {
                     $(".exclamation_ok_popup").addClass("display_block").fadeOut(3000);
                 };
            </script>
        End If

        TempData("ImgUploadResult") = ""

    End If

End Code
