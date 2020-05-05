@ModelType model.STAFFDEPARTMENT

@Code
    ViewData("Title") = "Reset Password"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="">
        <div class="">
            <div class="epy_lt_box1">

                @Using (Html.BeginForm())

                    @Html.AntiForgeryToken()
                    @<div class="form-horizontal">

                        <div class="inbox_haedtext">
                            <span>Reset Password</span>
                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">First Name :</div>
                            @Html.EditorFor(Function(model) model.FIRSTNAME, New With {.htmlAttributes = New With {.maxlength = 100, .class = "all_input1 events_none"}})
                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">Last Name :</div>
                            @Html.EditorFor(Function(model) model.LASTNAME, New With {.htmlAttributes = New With {.maxlength = 100, .class = "all_input1 events_none"}})
                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">NRIC :</div>
                            @Html.EditorFor(Function(model) model.NRIC, New With {.htmlAttributes = New With {.maxlength = 20, .class = "all_input1 events_none"}})

                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">Department :</div>
                            @Html.DropDownListFor(Function(model) model.DEPARTMENTID, Model.DEPARTMENTLIST, "SELECT", New With {.class = "all_input1 events_none", .name = "SELECTEDDEPARTMENTNAME"})
                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">Working Shift :</div>
                            @Html.DropDownListFor(Function(model) model.SHIFTID, Model.SHIFTLIST, "SELECT", New With {.class = "all_input1 events_none"})
                        </div>

                        <div class="b1_inb_part">
                            <div class="checkinbox">
                                @Html.EditorFor(Function(model) model.ISRESIGNED, New With {.htmlAttributes = New With {.class = "events_none", .onchange = "onChangeIsResign()" }})
                                <div class="checkinboxtext">Is Resigned</div>
                            </div>
                        </div>

                        <div id="id-div-resign-date" class="b1_inb_part display_none">
                            <div class="inb_pt_tt">Resign Date :</div>
                            @Html.EditorFor(Function(model) model.RESIGNEDON, New With {.htmlAttributes = New With {.id = "datePickerResignedOn", .class = "all_input1 events_none"}})
                        </div>

                        <div Class="footer_row_btn">
                            <a href="@Url.Action("Index", "Staff")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>
                            
                            <div id="savebtn" Class="rtpt_savebtn filter1" onclick="onSubmitSave()">
                                Reset Password
                            </div>
                        </div>
                    </div>
                End Using

                <div id="" Class="ctr_rtpt_popupbox display_none save_ok_popup">
                    <div Class="rtpt_popupbox_inb">
                        <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
                        <div Class="popupbox_inb_tt">Password reset successfully</div>
                    </div>
                </div>

                <div id="" Class="ctr_rtpt_popupbox display_none exclamation_ok_popup">
                    <div Class="rtpt_popupbox_inb">
                        <div Class="fa fa-exclamation-circle popupbox_inb_icon_red"></div>
                        <div Class="popupbox_inb_tt">Password reset failed</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        onChangeIsResign();
    });

    function onChangeIsResign() {
        if(document.getElementById("ISRESIGNED").checked)
            $("#id-div-resign-date").removeClass("display_none");
        else
            $("#id-div-resign-date").addClass("display_none");
    }

    function onSubmitSave() {
        $.ajax({
            url: '/Staff/ResetPasswordStaff',
            type: 'post',
            data: {
                id: document.getElementById("NRIC").value
            },
            success:async function (response) {
                $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                window.location.href = "@Url.Action("Index", "Staff")";
            }
        });
    }
</script>