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
                <span>Holiday - Edit Item</span>
            </div>
            
            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()

                @<div class="form-horizontal">
                    <hr />
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    @Html.HiddenFor(Function(model) model.HOLIDAYID)

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.HOLIDAYNAME, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.HOLIDAYNAME, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.HOLIDAYNAME, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.FROM, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.FROM, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.FROM, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.UNTIL, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.UNTIL, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.UNTIL, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.ISINUSED, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            <div class="checkbox">
                                @Html.EditorFor(Function(model) model.ISINUSED, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                                @Html.ValidationMessageFor(Function(model) model.ISINUSED, "", New With {.class = "text-danger"})
                            </div>
                        </div>
                    </div>

                    <div class="form-group" style="display: none">
                        @Html.LabelFor(Function(model) model.CREATEDBY, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            <div class="checkbox">
                                @Html.EditorFor(Function(model) model.CREATEDBY, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                            </div>
                        </div>
                    </div>

                    <div class="form-group" style="display: none">
                        @Html.LabelFor(Function(model) model.CREATEDON, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            <div class="checkbox">
                                @Html.EditorFor(Function(model) model.CREATEDON, New With {.htmlAttributes = New With {.style = "margin-left: 0px !important"}})
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            @Html.ActionLink("Back to List", "Index")
                            <input type="submit" value="Save" class="btn btn-default" />
                        </div>
                    </div>
                    </div>
            End Using
        </div>
    </div>
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
