@ModelType model.HOLIDAY

@Code
    ViewData("Title") = "Delete"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Code
                If ViewBag.Result = "OK" Then
                    @<script>
                            window.onload = function() {
                              $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                               window.location.href = "@Url.Action("Index", "Holiday")";
                           };
                    </script>
                End If
            End Code

            @Using (Html.BeginForm("Delete", "Holiday", method:=FormMethod.Post))

                @Html.AntiForgeryToken()

                @<div class="form-horizontal">
                    <div Class="inbox_haedtext">
                        <span> Holiday :: Delete</span>
                    </div>

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Holiday Name :</div>
                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = "all_input1 events_none"}})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Start Date :</div>

                            @* @Html.TextBoxFor(Function(model) model.FROM, New With {.Readonly = True, .class = "all_input1 events_none"})*@
                            @Html.EditorFor(Function(model) model.FROM, New With {.htmlAttributes = New With {.id = "datePickerFrom", .class = "all_input1 events_none"}})

                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">End Date :</div>

                            @* @Html.TextBoxFor(Function(model) model.UNTIL, New With {.Readonly = True, .class = "all_input1 events_none"})*@
                            @Html.EditorFor(Function(model) model.UNTIL, New With {.htmlAttributes = New With {.id = "datePickerUntil", .class = "all_input1 events_none"}})


                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">In Used :</div>
                            <div class="checkinbox">
                                @Html.CheckBoxFor(Function(model) model.ISINUSED, New With {.Disabled = True, .class = "check-box"})
                            </div>

                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Holiday")">
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
                            <div class="popupbox_inb_tt">Delete @Model.HOLIDAYNAME ? </div>

                            <div class="popupbox_inb_btnpart">
                                <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                                <a href="@Url.Action("Delete", "Holiday")" id="deleteconfirmed">
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


        </div>

    </div>

</div>

<div class="bg_color_w"></div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")

    <script type="text/javascript">

        // Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav2").addClass("ctr_innav1_btneff");

        $(function () {

            $("#save").click(function () {
                document.forms[0].submit();
                return false;
            });

            $('#datePickerFrom').datepicker({

                autoclose: true,
                changeMonth: true,
                changeYear: true,
                language: "en-IE",
                format: "dd/mm/yyyy"

            });

            $('#datePickerUntil').datepicker({
                autoclose: true,
                changeMonth: true,
                changeYear: true,
                language: "en-IE",
                format: "dd/mm/yyyy"
            });

            $.validator.methods.date = function (value, element) {
                return this.optional(element) || moment(value, 'DD/MM/YYYY').isValid();
            };

        });

    </script>

End Section


@*<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        //Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav2").addClass("ctr_innav1_btneff");
    </script>*@