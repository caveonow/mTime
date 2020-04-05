@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Edit"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="addbox-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday :: Edit</span>
            </div>

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()

                @<div class="ctr_holiday_addbox">
                    <hr />
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    @Html.HiddenFor(Function(model) model.HOLIDAYID)

                    <div class="hlday_addbox_part">
                        @Html.LabelFor(Function(model) model.HOLIDAYNAME, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = ""}})
                            @Html.ValidationMessageFor(Function(model) model.HOLIDAYNAME, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part">
                        @Html.LabelFor(Function(model) model.FROM, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            @Html.EditorFor(Function(model) model.FROM, New With {.htmlAttributes = New With {.class = ""}})
                            @Html.ValidationMessageFor(Function(model) model.FROM, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part">
                        @Html.LabelFor(Function(model) model.UNTIL, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            @Html.EditorFor(Function(model) model.UNTIL, New With {.htmlAttributes = New With {.class = ""}})
                            @Html.ValidationMessageFor(Function(model) model.UNTIL, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part">
                        @Html.LabelFor(Function(model) model.ISINUSED, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            @Html.EditorFor(Function(model) model.ISINUSED, New With {.htmlAttributes = New With {.class = "checkbox1"}})
                            @Html.ValidationMessageFor(Function(model) model.ISINUSED, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="hlday_addbox_part" style="display: none">
                        @Html.LabelFor(Function(model) model.CREATEDBY, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            <div class="checkbox">
                                @Html.EditorFor(Function(model) model.CREATEDBY, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                            </div>
                        </div>
                    </div>

                    <div class="hlday_addbox_part" style="display: none">
                        @Html.LabelFor(Function(model) model.CREATEDON, htmlAttributes:=New With {.class = "hlday_addbox_pt_tt"})
                        <div class="">
                            <div class="checkbox">
                                @Html.EditorFor(Function(model) model.CREATEDON, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                            </div>
                        </div>
                    </div>


                    <div Class="rtpt_addbox_partbtn">
                        <a href="@Url.Action("Holiday", "Maintenance")">
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
End Section

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav2").addClass("ctr_innav1_btneff");

    $(function () {
        $("#save").click(function () {
            document.forms[0].submit();
            return false;
        });
    });
</script>