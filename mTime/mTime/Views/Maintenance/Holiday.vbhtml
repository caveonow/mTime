@Code
    ViewData("Title") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">
                <span>Holiday</span>
                <a href="@Url.Action("Create", "Holiday")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>

            </div>

            @*@Using Html.BeginForm("Holiday", "Maintenance", FormMethod.Get)
                @<p>
                    <select class="form-control" id="yearFilter" name="yearFilter" value="@ViewBag.yearFilter">
                        <option>All</option>
                        @For Each item In ViewBag.yearListing
                            @<option value="@item">@item</option>
                        Next
                    </select>
                    <input type="submit" value="Search" />
                </p>
            End Using
            *@
            <div class="overflow_box">
                <table>
                    <thead>
                        <tr>
                            <th style="width: 90px;" />
                            <th style="width: 90px;">Name</th>
                            <th style="width: 150px;">Date From</th>
                            <th style="width: 150px;">Date To</th>
                            <th>Is Used</th>
                        </tr>
                    </thead>

                    <tbody>
                        @For Each item In Model
                            @<tr>
                                <td>
                                    <a href="@Url.Action("Edit", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-pencil-square-o btn_edit" />
                                    <a href="@Url.Action("Create", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-files-o btn_copy" />
                                    <a href="@Url.Action("Delete", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-trash-o btn_trash deletebtn" />
                                </td>
                                <td>
                                    @item.HOLIDAYNAME
                                </td>
                                <td>
                                    @item.FROM
                                </td>
                                <td>
                                    @item.UNTIL
                                </td>

                                <td style="padding: 0 5px;">
                                    <input type="checkbox" name="isInUsed" checked=@item.ISINUSED disabled="true" class="check-box"/>
                                </td>

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
    $(function () {
        $("#deleteconfirmed").click(function () {
            document.forms[0].submit();
            return false;
        });
    });

</script>

<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav2").addClass("ctr_innav1_btneff");
</script>