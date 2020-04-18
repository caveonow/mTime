@*@model IEnumerable<model.POORATTENDANCEREASON>
*@

@Code
    ViewData("Title") = "List"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">

                <span>Reason</span>
                <a href="@Url.Action("Create", "PoorAttendanceReason")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>
                <!--<div class="fa fa-refresh rtpt_b_ht_refresh"></div>-->


            </div>

            <div class="overflow_box">
                <table>
                    <thead>
                        <tr>
                            <th style="width: 65px;"></th>
                            <th>Reason Code</th>
                            <th style="width: 120px;">Description</th>
                            <th style="width: 120px;">For Late-In</th>
                            <th style="width: 120px;">For Early-Out</th>
                            <th style="width: 120px;">In Used</th>
                        </tr>
                    </thead>

                    <tbody>

                        @For Each item In Model
                            @<tr>
                                <td>
                                    <a href="@Url.Action("Edit", "PoorAttendanceReason", New With {.id = item.PoorAttendanceReasonID})">
                                        <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                                    </a>

                                    <a href="@Url.Action("Delete", "PoorAttendanceReason", New With {.id = item.PoorAttendanceReasonID})">
                                        <div id="" class="fa fa-trash-o btn_trash deletebtn"></div>
                                    </a>

                                </td>
                                <td>@item.PoorAttendanceReasonID</td>
                                <td>@item.Description</td>
                                @*
                                    <td>@item.IsForLateIn</td>
                                    <td>@item.IsForEarlyOut</td>
                                    <td>@item.IsInUsed</td>*@


                                <td style="padding: 0 5px;"><input type="checkbox" name="isForLateIn" checked=@item.IsForLateIn onclick="return false" /> </td>
                                <td style="padding: 0 5px;"><input type="checkbox" name="isForEarlyOut" checked=@item.IsForEarlyOut onclick="return false" /> </td>
                                <td style="padding: 0 5px;"><input type="checkbox" name="isInUsed" checked=@item.IsInUsed onclick="return false" /> </td>
                                @*<td style="padding: 0 5px;">@Html.Checkbox("isInUsed", @item.IsInused)</td>*@

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


    <div class="bg_color_w"></div>

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
            $(function () {
                $("#deleteconfirmed").click(function () {
                    document.forms[0].submit();
                    return false;
                });
            });


            //Nav Top Menu Part1
            $("#hdr_btn4").addClass("pt2_b_btneff");

            //Nav Left Menu Part1
            $("#leftnav5").addClass("ctr_innav1_btneff");
    </script>



