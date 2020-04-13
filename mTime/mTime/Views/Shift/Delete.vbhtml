@ModelType model.SHIFT

@Code
    ViewData("Title") = "Delete"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">

        @Using (Html.BeginForm())

            @Html.AntiForgeryToken()
            @<div id="rtpt_box-01" class="ctr_rtpt_box" style="height:650px;">
                <div Class="inbox_haedtext">
                    <span> Shift :: Delete</span>
                </div>

                @Html.HiddenFor(Function(Model) Model.CREATEDBY)
                @Html.HiddenFor(Function(Model) Model.CREATEDON)
                @Html.HiddenFor(Function(Model) Model.UPDATEDBY)
                @Html.HiddenFor(Function(Model) Model.UPDATEDON)
            
                <div class="bg_bd1_radius shift_addpart" style="top: 54%;">
                    <div class="addpt_box" style="">
                        <div class="addpt_b_tt" style="">Shift Code:</div>
                        @Html.TextBoxFor(Function(model) model.SHIFTID, New With {.maxlength = 20, .class = "all_input1 events_none"})

                        <div Class="hlday_addbox_pt_error" style="padding: 0 300px 0 0;">
                            @Html.ValidationMessageFor(Function(model) model.SHIFTID)
                        </div>
                    </div>

                    <div class="addpt_box" style="">
                        <div class="addpt_b_tt" style="">Description:</div>
                        @Html.TextBoxFor(Function(model) model.REMARK, New With {.maxlength = 100, .class = "all_input1 events_none"})

                        <div Class="hlday_addbox_pt_error" style="padding: 0 300px 0 0;">
                            @Html.ValidationMessageFor(Function(model) model.REMARK)
                        </div>
                    </div>

                    <div class="addpt_box" style="">
                        <div class="addpt_b_tt" style="">Type:</div>
                        
                        <select id="id-shift-type" class="addpt_b_input events_none" name="ISFLEXIHOUR" onchange="onChangeShiftType()" value="@model.ISFLEXIHOUR" disabled="true">
                            @If(true = model.ISFLEXIHOUR) Then 
                                @<option value="true" class="type_flexi_btn" selected>Flexi</option>
                            Else
                                @<option value="true" class="type_flexi_btn">Flexi</option>
                            End If

                            @If(false = model.ISFLEXIHOUR) Then 
                                @<option value="false" class="type_narmal_btn" selected>Normal</option>
                            Else
                                @<option value="false" class="type_narmal_btn">Normal</option>
                            End If
                        </select>
                        
                    </div>

                    <div class="addpt_box" style="margin:0 0;">
                        <div class="addpt_b_tt" style=""></div>
                        <div class="addpt_b_daybox" style="">
                            <div class="b_dayb_inb events_none">Mon</div>
                            <div class="b_dayb_inb events_none">Tue</div>
                            <div class="b_dayb_inb events_none">Wed</div>
                            <div class="b_dayb_inb events_none">Thu</div>
                            <div class="b_dayb_inb events_none">Fri</div>
                            <div class="b_dayb_inb events_none">Sat</div>
                            <div class="b_dayb_inb events_none">Sun</div>
                        </div>
                    </div>

                    <div class="addpt_box" style="margin:0 0;">
                        <div class="addpt_b_tt" style="">Work Day</div>
                        <div class="addpt_b_daybox" style="">
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY1, New With { .id = "id-is-workday-1", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(1)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY2, New With { .id = "id-is-workday-2", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(2)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY3, New With { .id = "id-is-workday-3", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(3)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY4, New With { .id = "id-is-workday-4", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(4)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY5, New With { .id = "id-is-workday-5", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(5)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY6, New With { .id = "id-is-workday-6", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(6)", .disabled = "true" })
                            </div>
                            <div class="b_dayb_inb events_none">
                                @Html.CheckBoxFor(Function(model) model.ISWORKDAY7, New With { .id = "id-is-workday-7", .class = "b_dayb_inb", .style = "margin: 7px 41px 7px 41px;", .onchange = "onChangeIsWorkDay(7)", .disabled = "true" })
                            </div>
                        </div>
                    </div>

                    <div class="addpt_box start_from_part" style="margin: 0 0;">
                        <div class="addpt_b_tt" style="">Time In Start</div>
                        <div class="addpt_b_daybox" style="">
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART1, New With { .id = "id-time-start-1", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART2, New With { .id = "id-time-start-2", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART3, New With { .id = "id-time-start-3", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART4, New With { .id = "id-time-start-4", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART5, New With { .id = "id-time-start-5", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART6, New With { .id = "id-time-start-6", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINSTART7, New With { .id = "id-time-start-7", .class = "b_dayb_inb events_none", .type = "time" })
                        </div>
                    </div>

                    <div id="id-row-time-end" class="addpt_box start_until_part" style="margin:0 0;">
                        <div class="addpt_b_tt" style="">Time In End</div>
                        <div class="addpt_b_daybox" style="">
                            @Html.TextBoxFor(Function(model) model.TIMEINEND1, New With { .id = "id-time-end-1", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND2, New With { .id = "id-time-end-2", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND3, New With { .id = "id-time-end-3", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND4, New With { .id = "id-time-end-4", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND5, New With { .id = "id-time-end-5", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND6, New With { .id = "id-time-end-6", .class = "b_dayb_inb events_none", .type = "time" })
                            @Html.TextBoxFor(Function(model) model.TIMEINEND7, New With { .id = "id-time-end-7", .class = "b_dayb_inb events_none", .type = "time" })
                        </div>
                    </div>

                    <div class="addpt_box" style="margin:0 0;">
                        <div class="addpt_b_tt" style="">Working Hour</div>
                        <div class="addpt_b_daybox" style="">
                            @Html.TextBoxFor(Function(model) model.WORKHOUR1, New With { .id = "id-work-hour-1", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR2, New With { .id = "id-work-hour-2", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR3, New With { .id = "id-work-hour-3", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR4, New With { .id = "id-work-hour-4", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR5, New With { .id = "id-work-hour-5", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR6, New With { .id = "id-work-hour-6", .class = "b_dayb_inb events_none", .type = "number" })
                            @Html.TextBoxFor(Function(model) model.WORKHOUR7, New With { .id = "id-work-hour-7", .class = "b_dayb_inb events_none", .type = "number" })
                        </div>
                    </div>

                    <div class="addpt_box" style="margin:10px 0;">
                        <div class="addpt_b_tt" style="font-weight: bolder; width: 100%; left: unset; position: unset; text-align: left; }">Grace Period</div>
                    </div>

                    <div class="addpt_box" style="width:45%;">
                        <div class="addpt_b_tt" style="">Late-in:</div>
                        @Html.TextBoxFor(Function(model) model.GRACEPERIODFORLATEIN, New With {.class = "b_dayb_inb all_input1 events_none", .type = "number", .style = "width:100%;" })
                    </div>

                    <div class="addpt_box" style="width:45%;">
                        <div class="addpt_b_tt" style="">Early Out:</div>
                        @Html.TextBoxFor(Function(model) model.GRACEPERIODFOREARLYOUT, New With {.class = "b_dayb_inb all_input1 events_none", .type = "number", .style = "width:100%;" })
                    </div>

                    <div class="addpt_box" style="">
                        <div class="addpt_b_tt" style="">In Used:</div>
                        <select id="id-in-used" class="addpt_b_input events_none" name="ISINUSED" disabled="true">
                            @If(true = model.ISINUSED) Then 
                                @<option value="true" class="type_flexi_btn" selected>Yes</option>
                            Else
                                @<option value="true" class="type_flexi_btn">Yes</option>
                            End If

                            @If(false = model.ISINUSED) Then 
                                @<option value="false" class="type_narmal_btn" selected>No</option>
                            Else
                                @<option value="false" class="type_narmal_btn">No</option>
                            End If
                        </select>
                    </div>

                    <div Class="footer_row_btn">
                        <a href="@Url.Action("Index", "Shift")">
                            <div id="closebtn" Class="rtpt_closebtn filter1">
                                Back to List
                            </div>
                        </a>

                        <div id="" class="rtpt_deletebtn filter1 deletebtn">
                            Delete
                        </div>
                    </div>
                </div>
                <div id="" class="ctr_rtpt_popupbox display_none deletebox-01">
                    <div class="rtpt_popupbox_inb">
                        <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                        <div class="popupbox_inb_tt">Delete @Model.SHIFTID ? </div>

                        <div class="popupbox_inb_btnpart">
                            <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                            <a href="@Url.Action("Delete", "Shift")" id="deleteconfirmed">
                                <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                            </a>

                            <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
                            <script type="text/javascript">
                                $(function () {
                                    $("#deleteconfirmed").click(function () {
                                        document.forms[0].submit();
                                        return false;
                                    });
                                });

                            </script>

                        </div>
                    </div>
                </div>
            </div>
        End Using

        @Code
            If ViewBag.Result = "OK" Then
                @<script>
                        window.onload = function() {
                            $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                            window.location.href = "@Url.Action("Index", "Shift")";
                        };
                </script>
            End If
        End Code
    </div>
</div>

<div class="bg_color_w"></div>


<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")
    <script type="text/javascript">
        $(function () {
            $("#save").click(function () {
                document.forms[0].submit();
                return false;
            });

            //refresh disabled
            for(var i = 1; i < 8; i++)
                onChangeIsWorkDay(i);

            //refresh display none
            onChangeShiftType();
        });

        function onChangeIsWorkDay(num) {
            var tempNum = (num === undefined || num === null || num === "") ? 1: num;

            if(document.getElementById("id-is-workday-" + tempNum).checked) {
                $("#id-time-start-" + tempNum).attr("disabled", false);
                $("#id-time-end-" + tempNum).attr("disabled", false);
                $("#id-work-hour-" + tempNum).attr("disabled", false);
            } else {
                $("#id-time-start-" + tempNum).attr("disabled", "disabled");
                $("#id-time-end-" + tempNum).attr("disabled", "disabled");
                $("#id-work-hour-" + tempNum).attr("disabled", "disabled");

                $("#id-time-start-" + tempNum).val("");
                $("#id-time-end-" + tempNum).val("");
                $("#id-work-hour-" + tempNum).val("");
            }
        }

        function onChangeShiftType() {
            var shiftType = document.getElementById("id-shift-type").value;

            if(shiftType === "false") {
                $("#id-row-time-end").css("display", "none");
            } else {
                $("#id-row-time-end").css("display", "");
            }
        }

        //Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav6").addClass("ctr_innav1_btneff");

    </script>
End Section