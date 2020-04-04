@ModelType model.HOLIDAY
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.HOLIDAYID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
