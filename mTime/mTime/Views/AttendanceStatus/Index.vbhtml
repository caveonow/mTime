@Code
    ViewData("Title") = "List"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">
                <span>Attendance Status</span>

                <a href="@Url.Action("Create", "AttendanceStatus")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>
            </div>

            <div class="overflow_box">
                <table>
                    <thead>
                        <tr>
                            <th style="width: 65px;"></th>
                            <th style="width: 250px;">Attendance Status Code</th>
                            <th>Description</th>                        
                            <th>In Used</th>
                        </tr>
                    </thead>

                    <tbody>
                        @For Each item In Model
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
    <td style="padding: 0 5px;"><input type="checkbox" name="isInUsed" checked=@item.IsInUsed onclick="return false" /> </td>
</tr>
                        Next
                    </tbody>
                </table>
            </div>

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


<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav6").addClass("ctr_innav1_btneff");
</script>