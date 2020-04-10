@ModelType model.HOLIDAY
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
                    <div class="inbox_haedtext">
                        <span>Holiday :: Add</span>
                    </div>

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">
                        <div Class="rtpt_addbox_part">
                            <div class="rtpt_addbox_pt_tt">Holiday Name :</div>

                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = "all_input1"}})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.HOLIDAYNAME)
                            </div>

                        </div>

                        <div class="rtpt_addbox_part">
                            <div class="rtpt_addbox_pt_tt">Start Date :</div>

                            @Html.EditorFor(Function(model) model.FROM, New With {.htmlAttributes = New With {.id = "datePickerFrom", .class = "all_input1"}})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.FROM)
                            </div>
                        </div>

                        <div class="rtpt_addbox_part">
                            <div class="rtpt_addbox_pt_tt">End Date :</div>

                            @Html.EditorFor(Function(model) model.UNTIL, New With {.htmlAttributes = New With {.id = "datePickerUntil", .class = "all_input1"}})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.UNTIL)
                            </div>
                        </div>

                        <div class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Holiday", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <a href="@Url.Action("Create", "Holiday")" id="save">
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
                            window.location.href = "@Url.Action("Holiday", "Maintenance")";
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

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")

    <script type="text/javascript">

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



