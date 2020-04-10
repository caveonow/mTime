<div class="bd_ctr_nav">
    <div class="menu innav1_btnleft_icon">
        <div class="fa fa-angle-left innav1_btt1_btnleft"></div>
    </div>

    <div class="ctr_innav1">
        <div class="ctr_innav1_btt1">
            <span>General</span>
        </div>

        <a href="@Url.Action("Index", "Hyperlink")" id="leftnav1" class="ctr_innav1_btn">
            <div class="fa fa-link innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Hyperlink</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Hyperlink</div>
        </a>
        
        <a href="@Url.Action("Index", "Holiday")" id="leftnav2" class="ctr_innav1_btn">
            <div class="fa fa-sun-o innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Holiday</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Holiday</div>
        </a>

        <a href="@Url.Action("Index", "Department")" id="leftnav3" class="ctr_innav1_btn">
            <div class="fa fa-users innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Department</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Department</div>
        </a>

     
        <a href="@Url.Action("Index", "PoorAttendanceReason")" id="leftnav5" class="ctr_innav1_btn">
            <div class="fa fa-commenting-o innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Reason</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Reason</div>
        </a>

        <a href="@Url.Action("Index", "AttendanceStatus")" id="leftnav6" class="ctr_innav1_btn">
            <div class="fa fa-external-link-square innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Attendance Status</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Attendance Status</div>
        </a>

        <a href="@Url.Action("Index", "Shift")" id="leftnav7" class="ctr_innav1_btn">
            <div class="fa fa-briefcase innav1_inbtn_icon"></div>
            <div class="innav1_inbtn_tt">
                <span>Working Shift</span>
            </div>
            <div id="innav1_boxeff" class="display_none">Working Shift</div>
        </a>

    </div>

    <div class="ctr_innav2">
        <div class="innav2_btnleft_box"></div>

        <div class="ctr_innav2_btt1">
            <span>Administration</span>
        </div>

        <a href="@Url.Action("Superior", "Administration")" id="left1nav9" class="ctr_innav2_btn">
            <div class="fa fa-user innav2_inbtn_icon"></div>
            <div class="innav2_inbtn_tt">
                <span>Superior</span>
            </div>
            <div id="innav2_boxeff" class="display_none">Superior</div>
        </a>

        <a href="@Url.Action("Administrator", "Administration")" id="left1nav10" class="ctr_innav2_btn">
            <div class="fa fa-building innav2_inbtn_icon"></div>
            <div class="innav2_inbtn_tt">
                <span>Administrator</span>
            </div>
            <div id="innav2_boxeff" class="display_none">Administrator</div>
        </a>
    </div>
</div>