@ModelType IEnumerable(Of mTime.mTime.HOLIDAY)
@Code
    ViewData("Title") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday</span>

                <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                <!-- <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add Item</div> -->
                @Html.ActionLink("Add Item", "Create")
            </div>

            <table>
                <thead>
                    <tr>
                        <th style="width: 90px;">Name</th>
                        <th style="width: 150px;">Date From</th>
                        <th style="width: 150px;">Date To</th>
                        <th>Is Used</th>
                        <th>Created By</th>
                        <th style="width: 150px;">Created Date</th>
                        <th>Updated By</th>
                        <th style="width: 150px;">Updated Date</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each item In Model
                    @<tr>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.HOLIDAYNAME)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.FROM)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.UNTIL)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.ISINUSED)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CREATEDBY)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.CREATEDON)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.UPDATEDBY)
                        </td>
                        <td>
                            @Html.DisplayFor(Function(modelItem) item.UPDATEDON)
                        </td>
                        <td>
                            @Html.ActionLink("Edit", "Edit", New With {.id = item.HOLIDAYID }) |
                            @Html.ActionLink("Details", "Details", New With {.id = item.HOLIDAYID }) |
                            @Html.ActionLink("Delete", "Delete", New With {.id = item.HOLIDAYID })
                        </td>
                    </tr>
                    Next
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                <span>Total 2 iten(s)</span>
            </div>
        </div>

        @*<div class="ctr_rtpt_footer">
            <div class="rtpt_ftr_addbtn filter1">Add Item</div>
        </div>*@
    </div>
</div>