@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Edit"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="addbox-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">
                <span>Holiday :: Edit</span>
            </div>

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()

                @<div class="form-horizontal">

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">
                        @*@Html.ValidationSummary(True, "", New With {.class = "text-danger"})*@
                        @Html.HiddenFor(Function(model) model.HOLIDAYID)

                        <div class="rtpt_addbox_part">
                            @Html.LabelFor(Function(model) model.HOLIDAYNAME, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = "all_input1 events_none"}})
                        </div>

                        <div class="rtpt_addbox_part">
                            @Html.LabelFor(Function(model) model.DATESTART, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            @Html.EditorFor(Function(model) model.DATESTART, New With {.htmlAttributes = New With {.id = "datePickerFrom", .class = "all_input1"}})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.DATESTART)
                            </div>
                        </div>

                        <div class="rtpt_addbox_part">
                            @Html.LabelFor(Function(model) model.DATEEND, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            @Html.EditorFor(Function(model) model.DATEEND, New With {.htmlAttributes = New With {.id = "datePickerUntil", .class = "all_input1"}})
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.DATEEND)
                            </div>
                        </div>

                        <div class="rtpt_addbox_part">
                            @Html.LabelFor(Function(model) model.ISINUSED, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            <div class="checkinbox">
                                @Html.EditorFor(Function(model) model.ISINUSED, New With {.htmlAttributes = New With {.class = ""}})
                            </div>
                        </div>

                        <div class="rtpt_addbox_part" style="display: none">
                            @Html.LabelFor(Function(model) model.CREATEDBY, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            <div class="">
                                <div class="checkbox">
                                    @Html.EditorFor(Function(model) model.CREATEDBY, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                                </div>
                            </div>
                        </div>

                        <div class="rtpt_addbox_part" style="display: none">
                            @Html.LabelFor(Function(model) model.CREATEDON, htmlAttributes:=New With {.class = "rtpt_addbox_pt_tt"})
                            <div class="">
                                <div class="checkbox">
                                    @Html.EditorFor(Function(model) model.CREATEDON, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                                </div>
                            </div>
                        </div>


                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Holiday")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <a href="@Url.Action("Edit", "Holiday")" id="save">
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
                            window.location.href = "@Url.Action("Index", "Holiday")";
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

