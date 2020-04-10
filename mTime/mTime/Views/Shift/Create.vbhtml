@ModelType model.SHIFT

@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box" style="height:650px;">
            <div Class="inbox_haedtext">
                <span> Shift :: Add</span>
            </div>

            <div class="bg_bd1_radius shift_addpart" style="top: 54%;">
                <div class="addpt_box" style="">
                    <div class="addpt_b_tt" style="">Shift Code:</div>
                    <input type="text" id="" name="" class="addpt_b_input" style="" />

                    <div Class="hlday_addbox_pt_error" style="padding: 0 300px 0 0;">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="">
                    <div class="addpt_b_tt" style="">Desc:</div>
                    <input type="text" id="" name="" class="addpt_b_input" style="" />

                    <div Class="hlday_addbox_pt_error" style="padding: 0 300px 0 0;">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="">
                    <div class="addpt_b_tt" style="">Type:</div>
                    <select id="cars" class="addpt_b_input">
                        <option value="Flexi" class="type_flexi_btn">Flexi</option>
                        <option value="Normal" class="type_narmal_btn">Normal</option>
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

                <div class="addpt_box start_from_part" style="margin: 0 0;">
                    <div class="addpt_b_tt" style="">Start From</div>
                    <div class="addpt_b_daybox" style="">
                        <input type="text" value="9:00 am" class="b_dayb_inb" />
                        <input type="text" value="9:00 am" class="b_dayb_inb" />
                        <input type="text" value="9:00 am" class="b_dayb_inb" />
                        <input type="text" value="9:00 am" class="b_dayb_inb" />
                        <input type="text" value="9:00 am" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                    </div>
                </div>

                <div class="addpt_box start_until_part" style="margin:0 0;">
                    <div class="addpt_b_tt" style="">Start Until</div>
                    <div class="addpt_b_daybox" style="">
                        <input type="text" value="6:00 pm" class="b_dayb_inb" />
                        <input type="text" value="6:00 pm" class="b_dayb_inb" />
                        <input type="text" value="6:00 pm" class="b_dayb_inb" />
                        <input type="text" value="6:00 pm" class="b_dayb_inb" />
                        <input type="text" value="6:00 pm" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                    </div>
                </div>

                <div class="addpt_box" style="margin:0 0;">
                    <div class="addpt_b_tt" style="">Working Hour</div>
                    <div class="addpt_b_daybox" style="">
                        <input type="text" value="9" class="b_dayb_inb" />
                        <input type="text" value="9" class="b_dayb_inb" />
                        <input type="text" value="9" class="b_dayb_inb" />
                        <input type="text" value="9" class="b_dayb_inb" />
                        <input type="text" value="9" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                        <input type="text" value="" class="b_dayb_inb" />
                    </div>
                </div>

                <div class="addpt_box" style="margin:0 0;">
                    <div class="addpt_b_tt" style="">work Day</div>
                    <div class="addpt_b_daybox" style="">
                        <input type="text" value="Yes" class="b_dayb_inb" />
                        <input type="text" value="Yes" class="b_dayb_inb" />
                        <input type="text" value="Yes" class="b_dayb_inb" />
                        <input type="text" value="Yes" class="b_dayb_inb" />
                        <input type="text" value="Yes" class="b_dayb_inb" />
                        <input type="text" value="No" class="b_dayb_inb" />
                        <input type="text" value="No" class="b_dayb_inb" />
                    </div>

                    <div Class="hlday_addbox_pt_error" style="width:520px">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="margin:10px 0;">
                    <div class="addpt_b_tt" style="">Grace Period:</div>
                    <input type="checkbox" id="" style="margin: 8px 0 0 0;" />

                    <div Class="hlday_addbox_pt_error" style="text-align:left;">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="width:45%;">
                    <div class="addpt_b_tt" style="">Late-in:</div>
                    <input type="text" id="" name="" class="addpt_b_input" style="width:100%;" />

                    <div Class="hlday_addbox_pt_error">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="width:45%;">
                    <div class="addpt_b_tt" style="">Early Out:</div>
                    <input type="text" id="" name="" class="addpt_b_input" style="width:100%;" />

                    <div Class="hlday_addbox_pt_error">
                        Validation Message
                    </div>
                </div>

                <div class="addpt_box" style="">
                    <div class="addpt_b_tt" style="">Type:</div>
                    <select id="cars" class="addpt_b_input">
                        <option value="Yes">Yes</option>
                        <option value="No">No</option>
                    </select>
                </div>

                <div Class="footer_row_btn">
                    <a href="@Url.Action("Shift", "Maintenance")">
                        <div id="closebtn" Class="rtpt_closebtn filter1">
                            Cancel
                        </div>
                    </a>

                    <a href="@Url.Action("Create", "Shift")" id="save">
                        <div id="savebtn" Class="rtpt_savebtn filter1">
                            Save
                        </div>
                    </a>
                </div>
            </div>
        </div>
        @*<div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm())

                @Html.AntiForgeryToken()
                @<div class="form-horizontal">

                    <div Class="inbox_haedtext">
                        <span> Shift :: Add</span>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Shift Code :</div>

                            @Html.TextBoxFor(Function(model) model.SHIFTID, New With {.maxlength = 20, .class = "all_input1"})

                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.SHIFTID)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Remark :</div>

                            @Html.TextBoxFor(Function(model) model.REMARK, New With {.maxlength = 100, .class = "all_input1"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.REMARK)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for late in :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFORLATEIN, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.GRACEPERIODFORLATEIN)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for early out :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFOREARLYOUT, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.GRACEPERIODFOREARLYOUT)
                            </div>
                        </div>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM1, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO1, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR1, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY1)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM2, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO2, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR2, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY2)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM3, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO3, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR3, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY3)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM4, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO4, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR4, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY4)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM5, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO5, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR5, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY5)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM6, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO6, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR6, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY6)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM7, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM7)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO7, New With {.class = "all_input1", .type = "time"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO7)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR7, New With {.class = "all_input1", .type = "number"})
                            <div Class="hlday_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR7)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY7)
                        </div>
                        
                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Shift", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <a href="@Url.Action("Create", "Shift")" id="save">
                                <div id="savebtn" Class="rtpt_savebtn filter1">
                                    Save
                                </div>
                            </a>
                        </div>
                    </div>
                </div>

            End Using

            @Code
                If ViewBag.Result = "OK" Then
                    @<script>
                            window.onload = function() {
                              $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                               window.location.href = "@Url.Action("Shift", "Maintenance")";
                           };
                    </script>
                End If
            End Code


            <div id="" Class="ctr_rtpt_popupbox display_none save_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
                    <div Class="popupbox_inb_tt">Save successfully</div>
                </div>
            </div>

            <div id="" Class="ctr_rtpt_popupbox display_none exclamation_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-exclamation-circle popupbox_inb_icon_red"></div>
                    <div Class="popupbox_inb_tt">Save failed</div>
                </div>
            </div>

        </div>*@
    </div>
</div>

<div class="bg_color_w"></div>


<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("#save").click(function () {
            document.forms[0].submit();
            return false;
        });
    });

    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav7").addClass("ctr_innav1_btneff");

</script>