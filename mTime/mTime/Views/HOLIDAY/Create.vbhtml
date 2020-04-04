@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="addbox-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday - Add Item</span>
            </div>

            @Using (Html.BeginForm("Create", "HOLIDAY", FormMethod.Post))
            @Html.AntiForgeryToken()
            @<div class="ctr_holiday_addbox">
                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Holiday Name :</div>
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With { .htmlAttributes = New With { .class = "form-control input_field_fill_available" } })
                        @Html.ValidationMessageFor(Function(model) model.HOLIDAYNAME, "", New With { .class = "text-danger" })
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Date From :</div>
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.FROM, New With { .htmlAttributes = New With { .class = "form-control input_field_fill_available" } })
                        @Html.ValidationMessageFor(Function(model) model.FROM, "", New With { .class = "text-danger" })
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Date To :</div>
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.UNTIL, New With { .htmlAttributes = New With { .class = "form-control input_field_fill_available" } })
                        @Html.ValidationMessageFor(Function(model) model.UNTIL, "", New With { .class = "text-danger" })
                    </div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Is Used :</div>
                    <div class="col-md-8">
                        @Html.EditorFor(Function(model) model.ISINUSED, New With { .htmlAttributes = New With { .style = "width: -webkit-fill-available; float: left" } })
                        @Html.ValidationMessageFor(Function(model) model.ISINUSED, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="hlday_addbox_partbtn">
                    @Html.ActionLink("Back to List", "Index")
                    <input id="savebtn1" class="rtpt_savebtn filter1" type="submit" value="Create" />
                </div>
            </div>
            End Using
        </div>
    </div>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
