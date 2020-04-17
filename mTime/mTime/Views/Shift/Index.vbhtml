@Code
    ViewData("Title") = "List"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Working Shift</span>

                <a href="@Url.Action("Create", "Shift")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>
            </div>

            <table>
                <thead>
                    <tr>
                        <th style="width: 85px;"></th>
                        <th>Shift code</th>
                        <th>Description</th>
                        <th>In Used</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each item In Model
                        @<tr>
                            <td>
                                <a href="@Url.Action("Edit", "Shift", New With {.id = item.SHIFTID})">
                                    <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                                </a>

                                <a href="@Url.Action("Details", "Shift", New With {.id = item.SHIFTID})">
                                    <div id="editbtn" class="fa fa-eye btn_edit"></div>
                                </a>

                                <a href="@Url.Action("Delete", "Shift", New With {.id = item.SHIFTID})">
                                    <div id="" class="fa fa-trash-o btn_trash"></div>
                                </a>
                            </td>

                            <td>@item.SHIFTID</td>
                            <td>@item.REMARK</td>

                            <td style="padding: 0 5px;"><input type="checkbox" name="isInUsed" checked=@item.IsInUsed disabled="true" /> </td>
                        </tr>
                    Next
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                @If Model.Count() > 1 Then
                    @<span>Total : @Model.Count() row(s)</span>
                Else
                    @<span>Total : @Model.Count() row</span>
                End If
            </div>
        </div>
    </div>
</div>


<div class="bg_color_w"></div>