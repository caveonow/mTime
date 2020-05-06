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

        <div class="Profile_btn pt2_b_btn" id="stfhdr_btn4" style="cursor: pointer">
            <div class="pt2_b_inbtn">Profile</div>
            <div class="pt2_b_inbtneff"></div>
            <div class="pt2_b_inbtnefflight"></div>
        </div>

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

    <div id="profile_update_popup" class="popup_bg display_none">
        <div class="profile_update_box">
            <div class="profile_update_item"> 
                <div class="profile_update_b_htr profile_update">Profile Update</div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Name:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-name" 
                        type="text"
                        maxlength="100"
                    />
                    <div id="id-error-panel-name" class="rtpt_addbox_pt_error display_none">
                        <span>Name is required</span>
                    </div>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Surname:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-surname" 
                        type="text"
                        maxlength="100"
                    />
                    <div id="id-error-panel-surname" class="rtpt_addbox_pt_error display_none">
                        <span>Surame is required</span>
                    </div>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">NRIC:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control events_none"
                        id="id-profile-update-nric" 
                        type="text"
                    />
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Gender:</div>
                    <select id="id-profile-update-gender" class="rtpt_addbox_part all_input1 text-box single-line form-control">
                        
                    </select>
                    <div id="id-error-panel-gender" class="rtpt_addbox_pt_error display_none">
                        <span>Gender is required</span>
                    </div>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Tel:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-tel" 
                        type="text"
                        maxlength="20"
                    />
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Address:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-address" 
                        type="text"
                        maxlength="500"
                    />
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Email:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-email" 
                        type="text"
                        maxlength="100"
                    />
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Department:</div>
                    <select id="id-profile-update-department" class="rtpt_addbox_part all_input1 text-box single-line form-control events_none">
                        
                    </select>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Grade:</div>
                    <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                        id="id-profile-update-grade" 
                        type="text"
                        maxlength="5"
                    />
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_label_part">Working Shift:</div>
                    <select id="id-profile-update-working-shift" class="rtpt_addbox_part all_input1 text-box single-line form-control events_none">
                        
                    </select>
                </div>

                <div class="profile_update_b_ftr">
                    <div id="closebtn" class="rtpt_closebtn filter1">Cancel</div>

                    <input type="button" class="rtpt_savebtn filter1" value="Send" onclick="onSubmitProfileUpdateForm()" style="width: 55px !important"/>
                </div>
            </div>

            <div id="" Class="display_none profile_update_save_ok_popup">
                <div Class="profile_update_rtpt_popupbox_inb">
                    <div Class="fa fa-check-circle-o profile_update_popupbox_inb_icon_blue"></div>
                    <div Class="profile_update_popupbox_inb_tt">Save successfully</div>
                </div>
            </div>
        </div>
    </div>
</div>