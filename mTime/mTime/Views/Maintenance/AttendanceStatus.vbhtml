@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Attendance Status</span>

                <a href="@Url.Action("Create", "AttendanceStatus" )">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>
            </div>

            <table>
                <thead>
                    <tr>
                        <th style="width: 65px;"></th>
                        <th style="width: 250px;">Attendance Code</th>
                        <th>Description</th>
                        <th>CONDITION</th>
                        <th>In Used</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each item In model
                        @<tr>
                            <td>
                                <a href="@Url.Action("Edit", "AttendanceStatus", New With {.id = item.ATTENDANCESTATUSID})">
                                    <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                                </a>

                                <a href="@Url.Action("Delete", "AttendanceStatus", New With {.id = item.ATTENDANCESTATUSID})">
                                    <div id="" class="fa fa-trash-o btn_trash"></div>
                                </a>
                            </td>
                            <td>@item.ATTENDANCESTATUSID</td>
                            <td>@item.DESCRIPTION</td>
                            <td>@item.CONDITION</td>
                            <td style="padding: 0 5px;"><input type="checkbox" name="isInUsed" checked=@item.IsInUsed disabled="true"/> </td>
                        </tr>
                    Next
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                @If Model.Count() > 1 Then
                @<span>Total : @Model.Count() row(s)</span>
                else
                @<span>Total : @Model.Count() row</span>
                end if
            </div>
        </div>
    </div>
</div>

<div class="bg_color_w"></div>