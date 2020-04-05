@ModelType model.STAFF

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
                        <span> Staff :: Add</span>
                    </div>

                    <div Class="ctr_rtpt_addbox">
                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Department ID: </div>

                                @Html.TextBoxFor(Function(model) model.NRIC, New With {.maxlength = 20})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.NRIC)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Staff No: </div>

                                @Html.TextBoxFor(Function(model) model.STAFFNO, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.STAFFNO)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">First Name:</div>

                                @Html.TextBoxFor(Function(model) model.FIRSTNAME)
                                <div Class="rtpt_addbox_pt_error">
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Last Name: </div>

                                @Html.TextBoxFor(Function(model) model.LASTNAME, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.LASTNAME)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Last Name: </div>

                                @Html.TextBoxFor(Function(model) model.STAFFGROUPID, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.STAFFGROUPID)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Last Name: </div>

                                @Html.TextBoxFor(Function(model) model.GENDER, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.GENDER)
                                </div>
                            </div>
                        </div>


                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Last Name: </div>

                                @Html.TextBoxFor(Function(model) model.GRADE, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.GRADE)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Last Name: </div>

                                @Html.TextBoxFor(Function(model) model.CONTACTNO1, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.CONTACTNO1)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Address: </div>

                                @Html.TextBoxFor(Function(model) model.ADDRESS, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.ADDRESS)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Email: </div>

                                @Html.TextBoxFor(Function(model) model.EMAIL, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.EMAIL)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Department ID: </div>

                                @Html.TextBoxFor(Function(model) model.DEPARTMENTID, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.DEPARTMENTID)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Status: </div>

                                @Html.TextBoxFor(Function(model) model.STATUS, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.STATUS)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Password: </div>

                                @Html.TextBoxFor(Function(model) model.PASSWORD, New With {.maxlength = 100})

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.PASSWORD)
                                </div>
                            </div>
                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Maintenance")">
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
                               window.location.href = "@Url.Action("Department", "Maintenance")";
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
</script>