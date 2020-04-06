
@ModelType model.POORATTENDANCEREASON

@Code
    ViewData("Title") = "Delete"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm("Delete", "PoorAttendanceReason", method:=FormMethod.Post))

                @Html.AntiForgeryToken()

                @<div class="form-horizontal">

                    @*@Html.HiddenFor(Function(Model) Model.POORATTENDANCEREASONID)*@

                    <div Class="inbox_haedtext">
                        <span> Reason :: Delete</span>
                    </div>

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Reason Code :</div>

                            @Html.TextBoxFor(Function(model) model.POORATTENDANCEREASONID, New With {.Readonly = True, .class = "all_input1 events_none"})

                            @*@Html.TextBoxFor(Function(model) model.POORATTENDANCEREASONID, New With {.Disabled = True})*@
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Description :</div>

                            @Html.TextBoxFor(Function(model) model.DESCRIPTION, New With {.Readonly = True, .class = "all_input1 events_none"})
                            @*@Html.TextBoxFor(Function(model) model.DESCRIPTION, New With {.Disabled = True})*@

                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">For Late-In :</div>
                            <div class="checkinbox">
                                @Html.CheckBoxFor(Function(model) model.ISFORLATEIN, New With {.Disabled = True}
                )
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">For Early-Out :</div>
                            <div class="checkinbox">
                                @Html.CheckBoxFor(Function(model) model.ISFOREARLYOUT, New With {.Disabled = True}
                )
                            </div>

                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">In Used :</div>
                            <div class="checkinbox">
                                @Html.CheckBoxFor(Function(model) model.ISINUSED, New With {.Disabled = True}
                )
                            </div>
                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Reason", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
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
                            <div class="popupbox_inb_tt">Delete @Model.POORATTENDANCEREASONID ? </div>

                            <div class="popupbox_inb_btnpart">
                                <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                                <a href="@Url.Action("Delete", "PoorAttendanceReason")" id="deleteconfirmed">
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
                               window.location.href = "@Url.Action("Reason", "Maintenance")";
                           };
                    </script>
                End If
            End Code
        </div>

    </div>

</div>

<div class="bg_color_w"></div>




@*<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#delete").click(function () {

                if (confirm('Delete ?') == true) {

                    document.forms[0].submit();

                }


                return false;

            });
        });

    </script>*@













