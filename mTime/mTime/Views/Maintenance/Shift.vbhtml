@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Working Shift</span>

                <a href="@Url.Action("Create", "Shift" )">
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

                        <!--<th>Monday start time</th>
                        <th>Monday end time</th>
                        <th>Monday working hours</th>
                        <th>Is off day on Monday</th>-->

                        <!--<th>Tuesday start time</th>
                        <th>Tuesday end time</th>
                        <th>Tuesday working hours</th>
                        <th>Is off day on Tuesday</th>-->

                        <!--<th>Wednesday start time</th>
                        <th>Wednesday end time</th>
                        <th>Wednesday working hours</th>
                        <th>Is off day on Wednesday</th>-->

                        <!--<th>Thursday start time</th>
                        <th>Thursday end time</th>
                        <th>Thursday working hours</th>
                        <th>Is off day on Thursday</th>-->

                        <!--<th>Friday start time</th>
                        <th>Friday end time</th>
                        <th>Friday working hours</th>
                        <th>Is off day on Friday</th>-->

                        <!--<th>Saturday start time</th>
                        <th>Saturday end time</th>
                        <th>Saturday working hours</th>
                        <th>Is off day on Saturday</th>-->

                        <!--<th>Sunday start time</th>
                        <th>Sunday end time</th>
                        <th>Sunday working hours</th>
                        <th>Is off day on Sunday</th>-->

                        <!--
                        <th>Grace period for late in</th>
                        <th>Grace period for early out</th>-->

                        <th>Remark</th>
                        <th>In Used</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each item In model
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

                            @*<td>@item.FLEXISTARTTIMEFROM1</td>
                            <td>@item.FLEXISTARTTIMEON1</td>
                            <td>@item.WORKHOUR1</td>
                            <td>@item.ISOFFDAY1</td>

                            <td>@item.FLEXISTARTTIMEFROM2</td>
                            <td>@item.FLEXISTARTTIMEON2</td>
                            <td>@item.WORKHOUR2</td>
                            <td>@item.ISOFFDAY2</td>

                            <td>@item.FLEXISTARTTIMEFROM3</td>
                            <td>@item.FLEXISTARTTIMEON3</td>
                            <td>@item.WORKHOUR3</td>
                            <td>@item.ISOFFDAY3</td>

                            <td>@item.FLEXISTARTTIMEFROM4</td>
                            <td>@item.FLEXISTARTTIMEON4</td>
                            <td>@item.WORKHOUR4</td>
                            <td>@item.ISOFFDAY4</td>

                            <td>@item.FLEXISTARTTIMEFROM5</td>
                            <td>@item.FLEXISTARTTIMEON5</td>
                            <td>@item.WORKHOUR5</td>
                            <td>@item.ISOFFDAY5</td>

                            <td>@item.FLEXISTARTTIMEFROM6</td>
                            <td>@item.FLEXISTARTTIMEON6</td>
                            <td>@item.WORKHOUR6</td>
                            <td>@item.ISOFFDAY6</td>

                            <td>@item.FLEXISTARTTIMEFROM7</td>
                            <td>@item.FLEXISTARTTIMEON7</td>
                            <td>@item.WORKHOUR7</td>
                            <td>@item.ISOFFDAY7</td>*@

                            @*<td>@item.GRACEPERIODFORLATEIN</td>
                            <td>@item.GRACEPERIODFOREARLYOUT</td>*@

                            <td>@item.REMARK</td>

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