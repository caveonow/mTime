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
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.HOLIDAYID}) |
    @Html.ActionLink("Back to List", "Index")
</p>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
            //Nav Top Menu Part1
            $("#hdr_btn4").addClass("pt2_b_btneff");

            //Nav Left Menu Part1
            $("#leftnav2").addClass("ctr_innav1_btneff");
</script>
