@ModelType mTime.mTime.HOLIDAY
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
            
            <dl class="dl-horizontal">
                <dt>
                    @Html.DisplayNameFor(Function(model) model.HOLIDAYNAME)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.HOLIDAYNAME)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.FROM)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.FROM)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.UNTIL)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.UNTIL)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.ISINUSED)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.ISINUSED)
                </dd>
            </dl>

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()

                @<div class="form-actions no-color">
                    <input type="submit" value="Delete" class="btn btn-default" /> |
                    @Html.ActionLink("Back to List", "Index")
                </div>
            End Using
        </div>
    </div>
</div>
