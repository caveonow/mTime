<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <!--<link rel="icon" type="image/vnd.microsoft.icon" href="img/favicon.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">-->
    <meta name="viewport" content="width=1024, initial-scale=1.0">
    <title>mTime</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body onload="display_ct();">
    <div id="login" class="header_part1 display_block">
        <div class="hd_pt1_inbox1">
            <div class="fa fa-clock-o pt1_inbox1_icon"></div>
            MyTime Attendance Management System
            <div class="" id="ct"></div>
        </div>

        <a href="#" id="btn_login" class="hd_pt1_logouticon filter_c1">
            Login
        </a>

        <a href="#" id="btn_firstlogin" class="hd_pt1_logouticon filter_c1">
            First Login
        </a>

        <div class="translate_part">
            <a href="" class="tsl_pt_ttbtn filter_c1">Bahasa Malaysia</a>

            <a href="" class="tsl_pt_ttbtn filter_c1 filter_cs1">English</a>
        </div>
    </div>

    <div id="logout" class="header_part1 display_none">
        <div class="hd_pt1_inbox1">
            <div class="fa fa-clock-o pt1_inbox1_icon"></div>
            MyTime Attendance Management System
            <div class="" id="ct"></div>
        </div>

        <div id="logout_btn" class="hd_pt1_logouticon filter_c1">
            Logout
        </div>

        <div class="hd_pt1_inbox2">
            <a href="#" class="fa fa-user-circle pt1_inbox2_usericon filter_c1"></a>
            Vendor User

            <div class="hd_profile">

                <div class="hd_pf_part1">
                    My Profile
                    <div id="editprofile_btn" class="btn_editprofile filter_c1">Edit</div>
                </div>

                <div class="hd_pf_part2">
                    User Name
                </div>

                <div class="hd_pf_part4">
                    Password
                    <div id="passwordchange_btn" class="pf_p4_tt1">
                        Change
                    </div>
                </div>

                <div id="Feedback_btn" class="hd_pf_part5">Feedback</div>

                <div class="hd_pf_part3">
                    Translate
                    <div class="pf_p3_box">
                        <a href="" class="p3_b_tt1 p3_b_button">EN</a>
                        <div class="p3_b_line"></div>
                        <a href="" class="p3_b_tt2">BM</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="malaysia_logo"></div>

    @RenderBody()

    @*<div>
            <footer>
                <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
            </footer>
        </div>*@

    @*Feedback PopUp *@
    <div id="Feedback_popup" class="popup_bg display_none">
        <div class="Feedback_box">
            <div class="Fbk_b_htr">Feedback</div>

            <div class="Fbk_b_ttarea">
                Please leave us your suggestions and complaints about this application. thank you.

                <textarea id="" rows="4" cols="50" class="b_ttarea_box"></textarea>
            </div>

            <div class="Fbk_b_ftr">
                <div id="closebtn" class="rtpt_closebtn filter1">Cancel</div>

                <div id="sendbtn" class="rtpt_savebtn filter1">Send</div>
            </div>
        </div>
    </div>

    @*PoPup First Login *@
    <div id="firstlogin_popup" class="popup_bg display_none">
        <div class="firstlogin_box">
            <div class="fa fa-user-circle ftlogin_b_icon">
                <div class="ftlogin_b_httt">First Login</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt">NRIC :</div>

                <div class="b_pt_box">
                    <input type="text" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt">Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt">Confirm Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_partbtm">
                <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                <div id="confirmbtn" class="rtpt_savebtn filter1">Confirm</div>
            </div>
        </div>
    </div>

    @*PoPup Login *@
    <div id="login_popup" class="popup_bg display_none">
        <div class="firstlogin_box">
            <div class="fa fa-user-circle ftlogin_b_icon">
                <div class="ftlogin_b_httt">Login</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt">NRIC :</div>

                <div class="b_pt_box">
                    <input type="text" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt">Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_partbtm">
                <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                <div id="loginbtn" class="rtpt_savebtn filter1">Lonig</div>

                <div id="forgotpw_btn" class="rtpt_forgotpwbtn filter1">Forgot Password</div>
            </div>
        </div>
    </div>

    @*PoPup First Login *@
    <div id="passwordchange_popup" class="popup_bg display_none">
        <div class="passwordchange_box">
            <div class="fa fa-user-circle pwchange_b_icon">
                <div class="b_icon_tt">Password Change</div>
            </div>

            <div class="pwchange_b_part">
                <div class="b_pt_tt">NRIC :</div>

                <div class="b_pt_box">
                    <input type="text" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="pwchange_b_part">
                <div class="b_pt_tt">Old Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="pwchange_b_part">
                <div class="b_pt_tt">Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="pwchange_b_part">
                <div class="b_pt_tt">Confirm Password :</div>

                <div class="b_pt_box">
                    <input type="password" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="pwchange_b_partbtm">
                <div id="cancelbtn" class="rtpt_closebtn filter1">Cancel</div>

                <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
            </div>
        </div>
    </div>

    @*PoPup Forgot Password *@
    <div id="forgotpw_popup" class="popup_bg display_none">
        <div class="firstlogin_box">
            <div class="fa fa-user-circle ftlogin_b_icon">
                <div class="ftlogin_b_httt">Account Recovery</div>
            </div>

            <div class="ftlogin_b_part">
                <div class="b_pt_tt1">NRIC :</div>

                <div class="b_pt_box1">
                    <input type="text" id="title" name="title">
                </div>
                <div class="hlday_addbox_pt_error">Text Error</div>
            </div>

            <div class="ftlogin_b_partbtm">
                <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                <div id="sendbtn" class="rtpt_savebtn filter1">Send</div>
            </div>
        </div>
    </div>

    @*PoPup Edit Profile *@
    <div id="editprofile_popup" class="popup_bg display_none">
        <div class="firstlogin_box">
            <div class="fa fa-user-circle ftlogin_b_icon">
                <div class="ftlogin_b_httt">Profile Edit</div>
            </div>

            <div class="edit_pt_box">
                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Name:</div>
                    <input name="title" class="pt_inb_input_none" value="YAHAYA">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Surname:</div>
                    <input name="title" class="pt_inb_input_none" value="ZAINUDDIN">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">NRIC:</div>
                    <input name="title" class="pt_inb_input_none" value="123456-01-1234">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Tel:</div>
                    <input name="title" class="pt_inb_input">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Address:</div>
                    <input name="title" class="pt_inb_input">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Email:</div>
                    <input name="title" class="pt_inb_input">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Dwpartment:</div>
                    <input name="title" class="pt_inb_input_none" value="BAHAGIAN PEMBANGUNAN KEMAHIRAN">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Grade:</div>
                    <input name="title" class="pt_inb_input_none" value="">
                </div>

                <div class="edit_pt_inb">
                    <div class="pt_inb_tt">Working Shift:</div>
                    <input name="title" class="pt_inb_input_none" value="WP3">
                </div>
            </div>

            <div class="ftlogin_b_partbtm">
                <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
            </div>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
