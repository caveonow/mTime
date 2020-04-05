@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="addbox-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday :: Delete</span>
            </div>

            <div class="ctr_holiday_addbox">
                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">@Html.DisplayNameFor(Function(model) model.HOLIDAYNAME)</div>
                    <div class="hlday_addbox_pt_ttbox events_none">
                        @Html.DisplayFor(Function(model) model.HOLIDAYNAME)
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">@Html.DisplayNameFor(Function(model) model.FROM)</div>
                    <div class="hlday_addbox_pt_ttbox events_none">
                        @Html.DisplayFor(Function(model) model.FROM)
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">@Html.DisplayNameFor(Function(model) model.UNTIL)</div>
                    <div class="hlday_addbox_pt_ttbox events_none">
                        @Html.DisplayFor(Function(model) model.UNTIL)
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">@Html.DisplayNameFor(Function(model) model.ISINUSED)</div>
                    <div class="checkbox1">
                        @Html.DisplayFor(Function(model) model.ISINUSED)
                    </div>
                </div>


                @Using (Html.BeginForm())
                    @Html.AntiForgeryToken()

                    @<div class="hlday_addbox_partbtn">
                        <div class="rtpt_closebtn filter1">@Html.ActionLink("Back to List", "Index")</div>
                        <input type="submit" value="Delete" class="rtpt_deletebtn filter1" />
                    </div>
                End Using
            </div>

            @*<dl class="dl-horizontal">




            <dt>
                @Html.DisplayNameFor(Function(model) model.UNTIL)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.UNTIL)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.ISINUSED)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ISINUSED)
            </dd>
        </dl>*@
        </div>
    </div>
</div>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
            //Nav Top Menu Part1
            $("#hdr_btn4").addClass("pt2_b_btneff");

            //Nav Left Menu Part1
            $("#leftnav2").addClass("ctr_innav1_btneff");
</script>
