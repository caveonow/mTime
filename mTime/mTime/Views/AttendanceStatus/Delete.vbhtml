@ModelType model.ATTENDANCESTATUS

@Code
    ViewData("Title") = "Delete"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm("Delete", "AttendanceStatus", method:=FormMethod.Post))

                @Html.AntiForgeryToken()

                @<div class="form-horizontal">
                    <div Class="ctr_rtpt_b_ht">
                        <span> Attendance Status :: Delete</span>
                    </div>

                    <div Class="ctr_rtpt_addbox">
                        <div Class="rtpt_addbox_part">
                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Attendance Code :</div>

                                @Html.TextBoxFor(Function(model) model.ATTENDANCESTATUSID, New With {.Readonly = True, .Style = "background-color:lightgrey"})
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Description :</div>

                                @Html.TextBoxFor(Function(model) model.DESCRIPTION, New With {.Readonly = True, .Style = "background-color:lightgrey"})
                            </div>

                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">Condition :</div>

                                @Html.TextBoxFor(Function(model) model.CONDITION, New With {.Readonly = True, .Style = "background-color:lightgrey"})
                            </div>

                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="">
                                <div Class="rtpt_addbox_pt_tt">In Used :</div>
                                <div class="rtpt_addbox_checkbox">
                                    @Html.CheckBoxFor(Function(model) model.ISINUSED, New With {.Disabled = True})                                </div>
                                
                            </div>

                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("AttendanceStatus", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <div id="" class="rtpt_deletebtn filter1 deletebtn">
                                Delete
                            </div>

                            <div id="" class="ctr_rtpt_popupbox display_none deletebox-01">
                                <div class="rtpt_popupbox_inb">
                                    <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                                    <div class="popupbox_inb_tt">Delete @Model.ATTENDANCESTATUSID ? </div>

                                    <div class="popupbox_inb_btnpart">
                                        <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                                        <a href="@Url.Action("Delete", "AttendanceStatus")" id="deleteconfirmed">
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
        </div>

    </div>

</div>

<div class="bg_color_w"></div>