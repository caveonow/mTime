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
                    <div Class="inbox_haedtext">
                        <span> Shift :: View</span>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Shift Code :</div>

                            @Html.TextBoxFor(Function(model) model.SHIFTID, New With {.Readonly = True, .class = "all_input1 events_none"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Remark :</div>

                            @Html.TextBoxFor(Function(model) model.REMARK, New With {.maxlength = 100, .class = "all_input1 events_none"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for late in :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFORLATEIN, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Grace period for early out :</div>

                            @Html.TextBoxFor(Function(model) model.GRACEPERIODFOREARLYOUT, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">In Used :</div>

                            @Html.CheckBoxFor(Function(model) model.ISINUSED, New With {.Disabled = True})
                        </div>
                    </div>

                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Monday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday start time :</div>
                            
                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM1, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO1, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR1, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Monday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY1, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Tuesday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM2, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO2, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR2, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Tuesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY2, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Wednesday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM3, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO3, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR3, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Wednesday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY3, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Thursday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM4, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO4, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR4, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Thursday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY4, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Friday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM5, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO5, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR5, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Friday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY5, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:left">
                        <!-- Saturday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM6, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO6, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR6, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Saturday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY6, New With {.Disabled = True})
                        </div>
                    </div>
                    
                    <div Class="ctr_rtpt_addbox special_rtpt_box bg_bd1_radius" style="float:right">
                        <!-- Sunday -->
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday start time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMEFROM7, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday end time :</div>

                            @Html.TextBoxFor(Function(model) model.FLEXISTARTTIMETO7, New With {.class = "all_input1 events_none", .type = "time"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday working hour(s) :</div>

                            @Html.TextBoxFor(Function(model) model.WORKHOUR7, New With {.class = "all_input1 events_none", .type = "number"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Sunday is off day :</div>

                            @Html.CheckBoxFor(Function(model) model.ISOFFDAY7, New With {.Disabled = True})
                        </div>
                    </div>
                        
                    <div Class="rtpt_addbox_partbtn">
                        <a href="@Url.Action("Shift", "Maintenance")">
                            <div id="closebtn" Class="rtpt_closebtn filter1">
                                Back to List
                            </div>
                        </a>
                    </div>
                </div>

            End Using

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