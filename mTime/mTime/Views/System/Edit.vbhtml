@ModelType mTime.model.COMPANY


@*@Using (Html.BeginForm("Edit", "System", FormMethod.Post, New With {.enctype = "multipart/form-data"}))*@
@Using (Html.BeginForm("UploadImg", "System", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()
    @<div>

        @Html.HiddenFor(Function(Model) Model.COMPANYID)
        @Html.HiddenFor(Function(Model) Model.COMPANYLOGOPATH)
        @Html.HiddenFor(Function(Model) Model.COMPANYHEADERPATH)
        @Html.HiddenFor(Function(Model) Model.COMPANYNAME)
        @Html.HiddenFor(Function(Model) Model.ADDRESSLINE1)
        @Html.HiddenFor(Function(Model) Model.ADDRESSLINE2)
        @Html.HiddenFor(Function(Model) Model.ADDRESSLINE3)
        @Html.HiddenFor(Function(Model) Model.DEFAULTLANGUAGE)

        <div Class="inbox_haedtext">
            <span> Company Info</span>
        </div>

        <div Class="stbox_lt_part1">
            <div Class="lt_pt1_box1">
                <div Class="pt1_b1_tt">Name :</div>

                @Html.TextBoxFor(Function(model) model.COMPANYNAME, New With {.class = "all_input1", .maxlength = 20})

            </div>

            <div Class="lt_pt1_box1">
                <div Class="pt1_b1_tt">Address :</div>

                @Html.TextAreaFor(Function(model) model.ADDRESSLINE1, New With {.class = "pt1_b1_textarea"})

            </div>

            <div Class="lt_pt1_box1">
                <div Class="pt1_b1_tt">Tel :</div>

                @Html.TextBoxFor(Function(model) model.TELNO, New With {.class = "all_input1"})

            </div>

            <div Class="lt_pt1_box1">
                <div Class="pt1_b1_tt">Fax :</div>

                @Html.TextBoxFor(Function(model) model.FAXNO, New With {.class = "all_input1"})

                <a href="" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>

            <div Class="lt_pt1_box2">
                <div Class="pt1_b2_tt">Company Logo :</div>

                <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style="background-image:url(../../img/malaysia_logo_s.png);">
                @*<a> @Html.Partial("UploadImg")</a>*@

                <input id="UploadImg" type="file" name="postedFile1" accept=".png" class="fa fa-folder-open pt1_b2_folderbtn filter1" />

                <a href="" Class="fa fa-times pt1_b2_deletebtn filter1"></a>

                <a href="" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>
            </div>

            <div Class="lt_pt1_box2">
                <div Class="pt1_b2_tt">Company Header :</div>

                <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style=" background-image:url(../../img/htr_bg.jpg);">
                @Html.TextBoxFor(Function(model) model.COMPANYHEADERPATH, New With {.class = "all_input1 pt1_b2_inputimg"})
                @*<a href="" Class="fa fa-folder-open pt1_b2_folderbtn filter1"></a>*@
                <input id="UploadImg" type="file" name="postedFile2" accept=".png" class="fa fa-folder-open pt1_b2_folderbtn filter1" />

                <a href="" Class="fa fa-times pt1_b2_deletebtn filter1"></a>

                <a href="" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>

            <div Class="lt_pt1_box2">
                <div Class="pt1_b2_tt">Home Header :</div>

                <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style=" background-image:url(../../img/htr_bg.jpg);">
                @Html.TextBoxFor(Function(model) model.HOMEPAGEHEADERPATH, New With {.class = "all_input1 pt1_b2_inputimg"})
                @*<a href="" Class="fa fa-folder-open pt1_b2_folderbtn filter1"></a>*@
                <input id="UploadImg" type="file" name="postedFile3" accept=".png" class="fa fa-folder-open pt1_b2_folderbtn filter1" />

                <a href="" Class="fa fa-times pt1_b2_deletebtn filter1"></a>

                <a href="" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>
        </div>

        <div Class="stbox_lt_part2">
            <input type="submit" value="Save" class="rtpt_savebtn filter1" />
        </div>

    </div>
End Using

@*@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")

    <script type="text/javascript">

        // Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav2").addClass("ctr_innav1_btneff");

        $(function () {

            var importFile = $("#UploadImg");

            importFile.change(function () {

                document.forms[0].submit();
                return false;

                //var fileName = $(this).val().split('\\')[$(this).val().split('\\').length - 1];
                //var fileExtension = $(this).val().substring($(this).val().lastIndexOf(".") + 1, $(this).val().length);

                //if (fileName.length > 0) {

                //    if (fileExtension == "csv") {
                //        //document.forms[0].submit();
                //        //return false;
                //    }

                //var fileUpload = $("#importFile").get(0);
                //var files = fileUpload.files;

                //// Create FormData object
                //var fileData = new FormData();

                //// Looping over all files and add it to FormData object
                //for (var i = 0; i < files.length; i++) {
                //    fileData.append(files[i].name, files[i]);
                //}

                //$.ajax({
                //    url: "/Holiday/ImportHoliday",
                //    type: "POST",
                //    enctype: "multipart/form-data",
                //    contentType: false, // Not to set any content header
                //    processData: false, // Not to process data
                //    data: fileData,
                //    success: function (result) {
                //        //alert(result);
                //        $(".save_ok_popup").addClass("display_block").fadeOut(3000);

                //    },
                //    error: function (err) {
                //        //alert(err.statusText);
                //        //alert("Failed to import file 1");
                //        $(".exclamation_ok_popup").addClass("display_block").fadeOut(3000);
                //    }
                //});

                //}
            });


        });

    </script>

End Section*@