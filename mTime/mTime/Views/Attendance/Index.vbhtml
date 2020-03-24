@Code
    ViewData("Title") = "Attendance Page"
End Code

@Html.Partial("_StaffMenuTop")

<div class="body_htrcenter">
    <div id="atdc_tab1" class="htrcenter_tab bg_color_444">
        Adjustment Arrival
        <div class="tab_btneff tab_eff1"></div>
    </div>

    <div id="atdc_tab2" class="htrcenter_tab">
        Attendance Record
        <div class="tab_btneff tab_eff2 display_none"></div>
    </div>

    <div id="atdc_tab3" class="htrcenter_tab">
        Door Access
        <div class="tab_btneff tab_eff3 display_none"></div>
    </div>
</div>

<div class="body_center top130">

    <div id="atdc_part1" class="display_block">@Html.Partial("_AdjustmentArrival")</div>

    <div id="atdc_part2" class="display_none">@Html.Partial("_AttendanceRecord")</div>

    <div id="atdc_part3" class="display_none">@Html.Partial("_DoorAccess")</div>
</div>