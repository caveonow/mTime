@ModelType model.ATTENDANCESTATUS

@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm())

                @Html.AntiForgeryToken()
                @<div class="form-horizontal">

                    <div Class="ctr_rtpt_b_ht">
                        <span> Attendance Status :: Add</span>
                    </div>

                    <div Class="ctr_rtpt_addbox">
                        <div Class="rtpt_addbox_part">
                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Attendance Code :</div>

                                @Html.TextBoxFor(Function(model) model.ATTENDANCESTATUSID, New With {.maxlength = 20})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.ATTENDANCESTATUSID)
                                </div>

                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Description :</div>

                                @Html.TextBoxFor(Function(model) model.DESCRIPTION, New With {.maxlength = 200})
                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.DESCRIPTION)
                                </div>
                            </div>

                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Condition :</div>

                                @Html.TextBoxFor(Function(model) model.CONDITION, New With {.maxlength = 10})
                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.CONDITION)
                                </div>
                            </div>

                        </div>
                        
                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("AttendanceStatus", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <a href="@Url.Action("Create", "AttendanceStatus")" id="save">
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
                               window.location.href = "@Url.Action("AttendanceStatus", "Maintenance")";
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
<script type="text/javascript">
    $(function () {
        $("#save").click(function () {
            document.forms[0].submit();
            return false;
        });
    });

</script>


















