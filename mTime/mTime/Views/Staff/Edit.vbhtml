@ModelType model.STAFFDEPARTMENT

@Code
    ViewData("Title") = "Edit"
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
                            <span>Edit Staff</span>
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
                            @Html.DropDownListFor(Function(model) model.DEPARTMENTID, Model.DEPARTMENTLIST, "SELECT", New With {.class = "all_input1", .name = "SELECTEDDEPARTMENTNAME"})
                        </div>

                        <div id="id-department-validation" class="b1_inb_part display_none">
                            <div class="rtpt_addbox_pt_error">
                                <span class="field-validation-error">Department is required</span>
                            </div>
                        </div>

                        <div class="b1_inb_part">
                            <div class="inb_pt_tt">Working Shift :</div>
                            @Html.DropDownListFor(Function(model) model.SHIFTID, Model.SHIFTLIST, "SELECT", New With {.class = "all_input1"})
                        </div>

                        <div id="id-shift-validation" class="b1_inb_part display_none">
                            <div class="rtpt_addbox_pt_error">
                                <span class="field-validation-error">Shift is required</span>
                            </div>
                        </div>

                        <div class="b1_inb_part">
                            <div class="checkinbox">
                                @Html.EditorFor(Function(model) model.ISRESIGNED, New With {.htmlAttributes = New With {.class = "", .onchange = "onChangeIsResign()" }})
                                <div class="checkinboxtext">Is Resigned</div>
                            </div>
                        </div>

                        <div id="id-div-resign-date" class="b1_inb_part display_none">
                            <div class="inb_pt_tt">Resign Date :</div>
                            @Html.EditorFor(Function(model) model.RESIGNEDON, New With {.htmlAttributes = New With {.id = "datePickerResignedOn", .class = "all_input1"}})

                            <div id="id-resign-date-validation" class="b1_inb_part display_none">
                                <div class="rtpt_addbox_pt_error">
                                    <span class="field-validation-error">Resign date is required</span>
                                </div>
                            </div>
                        </div>

                        <div Class="footer_row_btn">
                            <a href="@Url.Action("Index", "Staff")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <div id="savebtn" Class="rtpt_savebtn filter1" onclick="onSubmitSave()">
                                Save
                            </div>
                        </div>
                    </div>
                End Using

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
</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")
    <script type="text/javascript">
        $(function () {
            $("#save").click(function () {
                document.forms[0].submit();
                return false;
            });

            $('#datePickerResignedOn').datepicker({
                autoclose: true,
                changeMonth: true,
                changeYear: true,
                language: "en-IE",
                format: "dd/mm/yyyy"
            });

            $.validator.methods.date = function (value, element) {
                return this.optional(element) || moment(value, 'DD/MM/YYYY').isValid();
            };

            onChangeIsResign();
        });

        function onSubmitSave() {
            //reset validation
            $('#id-shift-validation').addClass('display_none');
            $('#id-department-validation').addClass('display_none');
            $('#id-resign-date-validation').addClass('display_none');

            var isValid = true;

            var nricStr = document.getElementById("NRIC").value;
            var departmentIdStr = document.getElementById("DEPARTMENTID").value;
            var shiftIdStr = document.getElementById("SHIFTID").value;
            var isResign = document.getElementById("ISRESIGNED").checked;
            var resignedOnStr = $('#datePickerResignedOn').val();

            if(departmentIdStr === null || departmentIdStr === undefined || departmentIdStr === '') {
                isValid = false;
                $('#id-department-validation').removeClass('display_none');
            }
            if(shiftIdStr === null || shiftIdStr === undefined || shiftIdStr === '') {
                isValid = false;
                $('#id-shift-validation').removeClass('display_none');
            }
            if(isResign !== null && isResign !== undefined && isResign != false) {
                if(resignedOnStr === null || resignedOnStr === undefined || resignedOnStr === '') {
                    isValid = false;
                    $('#id-resign-date-validation').removeClass('display_none');
                }
            }

            if(!isValid)
                return;

            var staffDepartment = {
                NRIC: nricStr,
                DEPARTMENTID: departmentIdStr,
                SHIFTID: shiftIdStr,
                ISRESIGNED: isResign,
                RESIGNEDONSTR: resignedOnStr
            };

            $.ajax({
                url: '/Staff/UpdateStaff',
                type: 'post',
                data: {
                    jsonString: JSON.stringify(staffDepartment)
                },
                success:async function (response) {
                    if(response !== null && response !== undefined && response !== "" && response !== "SUCCESS_UPDATE") {
                        for(var i = 0; i < response.length; i++) {
                            if(response[i] === 'ERROR_SHIFT')
                                $('#id-shift-validation').removeClass('display_none');
                            if(response[i] === 'ERROR_DEPARTMENT')
                                $('#id-department-validation').removeClass('display_none');
                            if(response[i] === 'ERROR_RESIGN_DATE')
                                $('#id-resign-date-validation').removeClass('display_none');
                        }
                    } else {
                        $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                        window.location.href = "@Url.Action("Index", "Staff")";
                    }
                }
            });
        }

        function onChangeIsResign() {
            if(document.getElementById("ISRESIGNED").checked)
                $("#id-div-resign-date").removeClass("display_none");
            else
                $("#id-div-resign-date").addClass("display_none");
        }
    </script>
End Section