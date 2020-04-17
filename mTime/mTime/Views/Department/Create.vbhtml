@ModelType model.DEPARTMENT

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

                    <div Class="inbox_haedtext">
                        <span> Department :: Add</span>
                    </div>

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Department Name : </div>

                            @Html.TextBoxFor(Function(model) model.DEPARTMENTNAME, New With {.maxlength = 100, .class = "all_input1"})

                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.DEPARTMENTNAME)
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Division Name : </div>

                            @Html.TextBoxFor(Function(model) model.DIVISIONNAME, New With {.maxlength = 100, .class = "all_input1"})
                            
                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.DIVISIONNAME)
                            </div>

                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Unit Name : </div>

                            @Html.TextBoxFor(Function(model) model.UNITNAME, New With {.maxlength = 100, .class = "all_input1"})


                            <div Class="rtpt_addbox_pt_error">
                                @Html.ValidationMessageFor(Function(model) model.UNITNAME)
                            </div>

                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Department")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <a href="@Url.Action("Create", "Department")" id="save">
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
                               window.location.href = "@Url.Action("Index", "Department")";
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

        @*function displayStatus() {

            $(".save_ok_popup").show();
            setInterval(function () {
                seconds--;
                if (seconds == 0) {
                    $(".save_ok_popup").hide();
                    window.location.href = "@Url.Action("index", "Maintenance")";
                }
            }, 1000);

            return false;

        };*@

    });

    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav3").addClass("ctr_innav1_btneff");
</script>