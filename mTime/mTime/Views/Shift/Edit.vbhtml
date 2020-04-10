@ModelType model.SHIFT

@Code
    ViewData("Title") = "Edit"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm())

                @Html.AntiForgeryToken()
                @<div class="form-horizontal">
                    @Html.HiddenFor(Function(Model) Model.SHIFTID)
                    @Html.HiddenFor(Function(Model) Model.CREATEDBY)
                    @Html.HiddenFor(Function(Model) Model.CREATEDON)
                    @Html.HiddenFor(Function(Model) Model.UPDATEDBY)
                    @Html.HiddenFor(Function(Model) Model.UPDATEDON)

                    <div Class="inbox_haedtext">
                        <span> Shift :: Edit</span>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Shift Code :</div>

                            @Html.TextBoxFor(Function(model) model.SHIFTID, New With {.Readonly = True, .class = "all_input1 events_none"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Remark :</div>

                            @Html.TextBoxFor(Function(model) model.REMARK, New With {.maxlength = 100, .class = "all_input1"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.REMARK)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for late in :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFORLATEIN, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.GRACEPERIODFORLATEIN)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for early out :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFOREARLYOUT, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.GRACEPERIODFOREARLYOUT)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">In Used :</div>

                            @Html.CheckBoxFor(Function(model) model.ISINUSED)
                        </div>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Monday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday start time :</div>
                            
                            @*@Html.DisplayFor(Function(model) model.FLEXISTARTTIMEFROM1)*@
                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM1, New With {.class = "all_input1", .type = "time"})
                            @*<input class="all_input1" 
                                data-val="true" 
                                data-val-required="Monday start time is required" 
                                id="FLEXISTARTTIMEFROM1" 
                                name="FLEXISTARTTIMEFROM1" 
                                type="time" 
                                value="@model.FLEXISTARTTIMEFROM1.Date.ToString('HH:mm')" 
                            />
                            *@
                            @*<input class="all_input1" 
                                data-val="true" 
                                data-val-date="The field FLEXISTARTTIMEFROM1 must be a date." 
                                data-val-required="Monday start time is required" 
                                id="FLEXISTARTTIMEFROM1" 
                                name="FLEXISTARTTIMEFROM1" 
                                type="time" 
                                value="@model.FLEXISTARTTIMEFROM1"
                            />*@
                            @*@Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM1, New With {.id = "FLEXISTARTTIMEFROM1", .class = "all_input1", .type = "time"})*@
                            @*@Html.EditorFor(Function(model) model.FLEXISTARTTIMEFROM1, "ShortDate")*@
                            @*@model.FLEXISTARTTIMEFROM1.ToString("HH:mm")*@
                            @*@Convert.ToDateTime(Function(model) model.FLEXISTARTTIMEFROM1).ToString("dd/MM/yyyy hh:mm")*@
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO1, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR1, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR1)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY1)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Tuesday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM2, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO2, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR2, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR2)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY2)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Wednesday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM3, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO3, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR3, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR3)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY3)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Thursday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM4, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO4, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR4, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR4)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY4)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Friday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM5, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO5, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR5, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR5)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY5)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Saturday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM6, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO6, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR6, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.WORKHOUR6)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY6)
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Sunday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM7, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMEFROM7)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO7, New With {.class = "all_input1", .type = "time"})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FLEXISTARTTIMETO7)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR7, New With {.class = "all_input1", .type = "number"})
                            <div Class="rtpt_addbox_pt_error">
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

        </div>
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
        });

        //Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav6").addClass("ctr_innav1_btneff");

    </script>
End Section