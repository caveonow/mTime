@Code
    ViewData("Message") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

    <div class="body_htrcenter">
        <div id="atdc_tab1" class="htrcenter_tab bg_color_444">
            Personal Message
            <div class="tab_btneff tab_eff1"></div>
        </div>

        <div id="atdc_tab2" class="htrcenter_tab">
            Announcement
            <div class="tab_btneff tab_eff2 display_none"></div>
        </div>

        <div id="atdc_tab3" class="htrcenter_tab">
            Feedback
            <div class="tab_btneff tab_eff3 display_none"></div>
        </div>
    </div>

    <div class="body_center top130">
        <div id="atdc_part1" class="display_block">@Html.Partial("_PersonalMessage")</div>

        <div id="atdc_part2" class="display_none">@Html.Partial("_Announcement")</div>

        <div id="atdc_part3" class="display_none">@Html.Partial("_Feedback")</div>
    </div>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>


<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn2").addClass("pt2_b_btneff");
</script>