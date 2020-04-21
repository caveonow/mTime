@ModelType mTime.model.COMPANY


@*@Using (Html.BeginForm("Edit", "System", FormMethod.Post, New With {.enctype = "multipart/form-data"}))*@
@Using (Html.BeginForm("UploadImg", "System", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()
    @<div>

    @Html.HiddenFor(Function(Model) Model.COMPANYID)
    @Html.HiddenFor(Function(Model) Model.ADDRESSLINE2)
    @Html.HiddenFor(Function(Model) Model.ADDRESSLINE3)

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

            @Html.TextBoxFor(Function(model) model.COMPANYLOGOPATH, New With {.class = "all_input1 pt1_b2_inputimg"})

            <input id="UploadImg" type="file" name="postedFile1" accept=".png" class="fa fa-folder-open pt1_b2_folderbtn filter1" />

            <a href="" Class="fa fa-times pt1_b2_deletebtn filter1"></a>

            <a href="" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>
        </div>

        <div Class="lt_pt1_box2">
            <div Class="pt1_b2_tt">Company Header :</div>

            <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style=" background-image:url(../../img/company_logo.jpg Header.jpg);">
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