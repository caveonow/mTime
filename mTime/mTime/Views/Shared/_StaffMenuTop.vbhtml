<div class="header_part2">
    <div class="massage_part">1 mesej belum baca daripada pentadbir</div>

    <div class="hd_pt2_box">
        <a href="@Url.Action("Index", "Home")" class="pt2_b_btn" id="stfhdr_btn1">
            <div class="pt2_b_inbtn">Home</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </a>

        <a href="@Url.Action("Index", "Attendance")" class="pt2_b_btn" id="stfhdr_btn2">
            <div class="pt2_b_inbtn">Attendance</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </a>

        <a href="@Url.Action("Index", "PersonalMessage")" class="pt2_b_btn" id="stfhdr_btn3">
            <div class="pt2_b_inbtn">Personal Message</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </a>

        @*<a href="" class="pt2_b_btn" id="stfhdr_btn4">
            <div class="pt2_b_inbtn">Profile</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </a>*@

        @*<div href="@Url.Action("Index", "Feedback")" class="pt2_b_btn" id="stfhdr_btn5">*@
        <div class="Feedback_btn pt2_b_btn" id="stfhdr_btn5" style="cursor: pointer">
            <div class="pt2_b_inbtn">Feedback</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </div>

        <a href="@Url.Action("Index", "FAQ")" class="pt2_b_btn" id="stfhdr_btn6">
            <div class="pt2_b_inbtn">F.A.Q</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </a>

        @*<a href="@Url.Action("Index", "AboutUs")" class="pt2_b_btn" id="stfhdr_btn7">
                <div class="pt2_b_inbtn">About Us</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>*@
    </div>

    <div id="Feedback_popup" class=" popup_bg display_none">
        @Using (Html.BeginForm("", "", FormMethod.Post, New With { .id = "id-form-feedback" }))

        @Html.AntiForgeryToken()
        @<div class="Feedback_box">
            <div class="Fbk_b_htr Fbk">Feedback</div>

            <div class="Fbk_b_ttarea Fbk">
                Please leave us your suggestions and complaints about this application. Thank you.

                <textarea id="id-content" rows="4" cols="50" class="b_ttarea_box" name="CONTENT" maxlength="500"></textarea>
                <div id="id-error-panel-content" class="rtpt_addbox_pt_error display_none">
                    <span>Feedback is required</span>
                </div>
            </div>

            <div class="Fbk_b_ftr Fbk">
                <div id="closebtn" class="rtpt_closebtn filter1">Cancel</div>

                <input type="button" class="rtpt_savebtn filter1" value="Send" onclick="formSubmit()" style="width: 55px !important"/>
            </div>

            <div id="" Class="fbk_ctr_rtpt_popupbox display_none fbk_save_ok_popup">
                <div Class="fbk_rtpt_popupbox_inb">
                    <div Class="fa fa-check-circle-o fbk_popupbox_inb_icon_blue"></div>
                    <div Class="fbk_popupbox_inb_tt">Save successfully</div>
                </div>
            </div>
        </div>
        End Using
    </div>
</div>