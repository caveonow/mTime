@Code
    ViewData("Report") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_htrcenter">
    <div id="atdc_tab1" class="htrcenter_tab bg_color_444">
        By Employee
        <div class="tab_btneff tab_eff1"></div>
    </div>

    <div id="atdc_tab2" class="htrcenter_tab">
        By Department
        <div class="tab_btneff tab_eff2 display_none"></div>
    </div>

    <div id="atdc_tab3" class="htrcenter_tab">
        Analysis
        <div class="tab_btneff tab_eff3 display_none"></div>
    </div>

    <div id="atdc_tab4" class="htrcenter_tab">
        Ratio Analysis
        <div class="tab_btneff tab_eff4 display_none"></div>
    </div>
</div>

<div class="body_center top130">
    <div id="atdc_part1" class="display_block">@Html.Partial("_ByEmployee")</div>

    <div id="atdc_part2" class="display_none">@Html.Partial("_ByDepartment")</div>

    <div id="atdc_part3" class="display_none">@Html.Partial("_Analysis")</div>

    <div id="atdc_part4" class="display_none">@Html.Partial("_RatioAnalysis")</div>
</div>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn3").addClass("pt2_b_btneff");
</script>