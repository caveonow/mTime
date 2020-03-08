<!doctype html>
<html>

<head>
    <meta http-equiv="Content-Type" content="text/html;a charset=utf-8">

    <meta name="keywords" content="Attendance Management System">
    <title>AMS</title>
    <!--<link rel="icon" type="image/vnd.microsoft.icon" href="img/favicon.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">-->
    <meta name="viewport" content="width=1024, initial-scale=1.0">

    <script src="js/jquery-3.4.1.min.js" type="text/javascript"></script>
    <!--<script src="js/popper.min.js" type="text/javascript"></script>-->
    <script src="js/bootstrap.js" type="text/javascript"></script>
    <script src="js/bootstrap.bundle.js" type="text/javascript"></script>

    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap-grid.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap-reboot.css">
    <link rel="stylesheet" type="text/css" href="css/font-awesome.css">
</head>

<body onload="display_ct();">
    <div class="header_part1">
        <div class="hd_pt1_inbox1">
            <div class="fa fa-clock-o pt1_inbox1_icon"></div>
            MyTime Attendance Management System
            <div class="" id="ct"></div>
        </div>

        <a href="#" class="fa fa-sign-out hd_pt1_logouticon filter_c1">
            <div class="logouticon_mo_tt">Logout</div>
        </a>

        <div class="hd_pt1_inbox2">
            <a href="#" class="fa fa-user-circle pt1_inbox2_usericon filter_c1"></a>
            Vendor User

            <div class="hd_profile">

                <div class="arrow_up_c hd_pf_arrow"></div>

                <div class="hd_pf_part1">
                    My Profile
                </div>

                <div class="hd_pf_part2">
                    User Name
                    <div class="pf_p2_box">
                        <div class="p2_b_tt">Vendor User</div>
                        <div class="fa fa-pencil p2_b_icon"></div>
                    </div>

                    <!--<div  class="" style="width: initial; height: inherit; float: right;">
                    <input type="text" class="" style="margin: 3px 0; padding: 0  5px; width: 100px; height: 24px; line-height: 24px; float: right; background-color: #038C76; border: 0;" name="name" maxlength="50" size="12" required>
                        </div>-->
                </div>

                <div class="hd_pf_part3">
                    Translate
                    <div class="pf_p3_box">
                        <a href="" class="p3_b_tt1 p3_b_button">EN</a>
                        <div class="p3_b_line"></div>
                        <a href="" class="p3_b_tt2">BM</a>
                    </div>
                </div>

                <div class="hd_pf_part4">
                    Password
                    <div class="pf_p4_tt1">
                        Change
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="header_part2">
        <div class="hd_pt2_box">
            <a href="" class="pt2_b_btn" id="hdr_btn1">
                <div class="pt2_b_inbtn">Employee</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn2">
                <div class="pt2_b_inbtn">Massages</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn3">
                <div class="pt2_b_inbtn">Report</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn4">
                <div class="pt2_b_inbtn">Maintenance</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn5">
                <div class="pt2_b_inbtn">System</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn6">
                <div class="pt2_b_inbtn">F.A.Q</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>

            <a href="" class="pt2_b_btn" id="hdr_btn7">
                <div class="pt2_b_inbtn">About Us</div>
                <div class="pt2_b_inbtneff"></div>
                <div class="pt2_b_inbtnefflight"></div>
            </a>
        </div>
    </div>

    <div class="body_center">
        <div class="bd_ctr_nav">
            <div class="menu innav1_btnleft_icon">
                <div class="fa fa-angle-left innav1_btt1_btnleft"></div>
            </div>

            <div class="ctr_innav1">
                <div class="ctr_innav1_btt1">
                    <span>General</span>
                </div>

                <a href="" id="leftnav1" class="ctr_innav1_btn">
                    <div class="fa fa-link innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Hyperlink</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Hyperlink</div>
                </a>

                <a href="" id="leftnav2" class="ctr_innav1_btn">
                    <div class="fa fa-sun-o innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Holiday</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Holiday</div>
                </a>

                <a href="" id="leftnav3" class="ctr_innav1_btn">
                    <div class="fa fa-users innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Department</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Department</div>
                </a>

                <a href="" id="leftnav4" class="ctr_innav1_btn">
                    <div class="fa fa-sort-amount-asc innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Grade</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Grade</div>
                </a>

                <a href="" id="leftnav5" class="ctr_innav1_btn">
                    <div class="fa fa-commenting-o innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Reason</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Reason</div>
                </a>

                <a href="" id="leftnav6" class="ctr_innav1_btn">
                    <div class="fa fa-external-link-square innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Attendance Status</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Attendance Status</div>
                </a>

                <a href="" id="leftnav7" class="ctr_innav1_btn">
                    <div class="fa fa-briefcase innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Working Shift</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Working Shift</div>
                </a>

                <a href="" id="leftnav8" class="ctr_innav1_btn">
                    <div class="fa fa-calendar innav1_inbtn_icon"></div>
                    <div class="innav1_inbtn_tt">
                        <span>Late Tolerant</span>
                    </div>
                    <div id="innav1_boxeff" class="display_none">Late Tolerant</div>
                </a>
            </div>

            <div class="ctr_innav2">
                <div class="innav2_btnleft_box"></div>

                <div class="ctr_innav2_btt1">
                    <span>Administration</span>
                </div>

                <a href="" id="left1nav1" class="ctr_innav2_btn">
                    <div class="fa fa-user innav2_inbtn_icon"></div>
                    <div class="innav2_inbtn_tt">
                        <span>Superior</span>
                    </div>
                    <div id="innav2_boxeff" class="display_none">Superior</div>
                </a>

                <a href="" id="left1nav2" class="ctr_innav2_btn">
                    <div class="fa fa-building innav2_inbtn_icon"></div>
                    <div class="innav2_inbtn_tt">
                        <span>Administrator</span>
                    </div>
                    <div id="innav2_boxeff" class="display_none">Administrator</div>
                </a>
            </div>
        </div>

        <div class="bd_ctr_rightpart">
            <div id="rtpt_box-01" class="ctr_rtpt_box">
                <div class="ctr_rtpt_b_ht">
                    <span>Hyperlink</span>
                    <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                </div>

                <table>
                    <thead>
                        <tr>
                            <th style="width: 65px;"></th>
                            <th>Title</th>
                            <th>UPL</th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr>
                            <td>
                                <div id="rtpt_editbtn" class="fa fa-pencil-square-o"></div>
                                <div class="fa fa-trash-o"></div>
                            </td>
                            <td>eModuler Support</td>
                            <td style="padding: 0 5px;">http://Support.emoduler.com</td>
                        </tr>

                        <tr>
                            <td>
                                <div id="rtpt_editbtn" class="fa fa-pencil-square-o"></div>
                                <div class="fa fa-trash-o"></div>
                            </td>
                            <td>eModuler Support 01</td>
                            <td>http://Support.emoduler.com</td>
                        </tr>
                    </tbody>
                </table>

                <div class="ctr_rtpt_b_ftr">
                    <span>Total 2 iten(s)</span>
                </div>
            </div>

            <div id="rtpt_addbox-01" class="ctr_rtpt_box display_none">
                <div class="ctr_rtpt_b_ht">
                    <span>Hyperlink - Add Item</span>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_addbox_part">
                        <div class="rtpt_addbox_pt_tt">Title :</div>
                        <input type="text" id="title" name="title">

                        <div class="rtpt_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="rtpt_addbox_part" style="width: 100%; height: initial; float: left; margin: 0  0 10px 0;">
                        <div class="rtpt_addbox_pt_tt">URL :</div>
                        <input type="text" id="URL" name="URL">

                        <div class="rtpt_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="rtpt_addbox_partbtn">
                        <div id="rtpt_closebtn" class="rtpt_closebtn filter1">Close</div>

                        <div id="rtpt_savebtn" class="rtpt_savebtn filter1">Save</div>
                    </div>
                </div>
            </div>

            <div id="rtpt_editbox-01" class="ctr_rtpt_box display_none">
                <div class="ctr_rtpt_b_ht">
                    <span>Hyperlink - Edit</span>
                </div>

                <div class="ctr_rtpt_addbox">
                    <div class="rtpt_addbox_part">
                        <div class="rtpt_addbox_pt_tt">Title :</div>
                        <input type="text" id="title" name="title" value="eModuler Support">

                        <div class="rtpt_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="rtpt_addbox_part" style="width: 100%; height: initial; float: left; margin: 0  0 10px 0;">
                        <div class="rtpt_addbox_pt_tt">URL :</div>
                        <input type="text" id="URL" name="URL" value="http://Support.emoduler.com">

                        <div class="rtpt_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="rtpt_addbox_partbtn">
                        <div id="rtpt_closebtn" class="rtpt_closebtn filter1">Close</div>

                        <div id="rtpt_savebtn" class="rtpt_savebtn filter1">Save</div>
                    </div>
                </div>
            </div>

            <div class="ctr_rtpt_footer">
                <div class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>
        </div>
    </div>

    <script src="js/ams.js" type="text/javascript"></script>

    <script>
        $("#hdr_btn4").addClass("pt2_b_btneff");
        $("#leftnav1").addClass("ctr_innav1_btneff");
    </script>
</body>
</html>