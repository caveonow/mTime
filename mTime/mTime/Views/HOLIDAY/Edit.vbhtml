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


    <div class="hlday_addbox_partbtn">
        <div class="rtpt_closebtn filter1">@Html.ActionLink("Back to List", "Index")</div>

        <input id="savebtn1" class="rtpt_savebtn filter1" type="submit" value="Save" />
    </div>
</div>
            End Using
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
</script>