@ModelType mTime.mTime.HOLIDAY
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>HOLIDAY</h4>
    <hr />
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.CREATEDBY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CREATEDBY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CREATEDON)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CREATEDON)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UPDATEDBY)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UPDATEDBY)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UPDATEDON)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UPDATEDON)
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
