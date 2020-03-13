<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <!--<link rel="icon" type="image/vnd.microsoft.icon" href="img/favicon.ico" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">-->
    <meta name="viewport" content="width=1024, initial-scale=1.0">
    <title>SRS Project</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body onload="display_ct();">
    <div class="header_part1">
        <div class="hd_pt1_inbox1">
            <div class="fa fa-clock-o pt1_inbox1_icon"></div>
            MyTime Attendance Management System
            <div class="" id="ct"></div>
        </div>

        <a href="#" class="hd_pt1_logouticon filter_c1">
            Logout
            @*<div class="logouticon_mo_tt">Logout</div>*@
        </a>

        <div class="hd_pt1_inbox2">
            <a href="#" class="fa fa-user-circle pt1_inbox2_usericon filter_c1"></a>
            Vendor User

            <div class="hd_profile">

                @*<div class="arrow_up_c hd_pf_arrow"></div>*@

                <div class="hd_pf_part1">
                    My Profile
                    <div class="" style="width:initial; height:inherit; float:right; font-size:12px; text-align:right; line-height:30px;">Edit</div>
                </div>

                <div class="hd_pf_part2">
                    User Name
                    @*<div class="pf_p2_box">
                            <div class="p2_b_tt">Vendor User</div>
                            <div class="fa fa-pencil p2_b_icon"></div>
                        </div>*@
                </div>

                <div class="hd_pf_part3">
                    Translate
                    <div class="pf_p3_box">
                        <a href="" class="p3_b_tt1 p3_b_button">EN</a>
                        <div class="p3_b_line"></div>
                        <a href="" class="p3_b_tt2">BM</a>
                    </div>
                </div>

                @*<div class="hd_pf_part4">
                        Password
                        <div class="pf_p4_tt1">
                            Change
                        </div>
                    </div>*@
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

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>