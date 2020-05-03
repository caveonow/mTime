@ModelType  model.STAFFDEPARTMENT

@Code
    ViewData("Title") = "DELETE"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="employee_part" style="padding:0 10px;">
        @Using (Html.BeginForm("Import", "Staff", FormMethod.Post))

            @Html.AntiForgeryToken()

            @<div class="epy_pt_rt">
                <div class="inbox_haedtext">

                    <span>New Staff</span>

                    <!--<button type="submit" id="btnSave" name="Command" value="Save">Save</button>-->
                    @*<div onclick="getTableValue()" style="color: white; margin: auto; border: 1px solid; width: 50px; cursor: pointer;">save</div>*@

                    <div onclick="getTableValue()" class="rtpt_savebtn filter1">save</div>

                    <a href="@Url.Action("Index", "Staff")">
                        <div id="closebtn" Class="rtpt_closebtn filter1">
                            Back
                        </div>
                    </a>


                </div>

                <div class="overflow_box">
                    <table id="id-table-employee" class="table_part">
                        <thead>
                            <tr>
                                <th style="width: 220px;">Name</th>
                                <th style="width: 140px;">NRIC</th>
                                <th style="width: 500px;">Department Name</th>
                                <th>Working Shift</th>
                                <th class="display_none"></th>
                            </tr>
                        </thead>

                        <tbody>

                            @For intNo = 0 To Model.FIREBIRDSTAFFLIST.Count - 1

                                @Html.HiddenFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).STAFFNO, New With {.name = "[" + intNo.ToString + "].StaffNo"})
                                @<tr>
                                    <td style="padding: 0 5px;">@Model.FIREBIRDSTAFFLIST(intNo).NAME</td>
                                    <td style="padding: 0 5px;">@Model.FIREBIRDSTAFFLIST(intNo).NRIC</td>
                                    <td style="padding: 0;">
                                        @Html.DropDownListFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).DEPARTMENTID, Model.DEPARTMENTLIST, "SELECT", New With {.class = "all_input1", .name = "DepartmentID", .Style = "border:0; font-size: 12px;"})
                                    </td>
                                    <td style="padding: 0;">
                                        @Html.DropDownListFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).SHIFTID, Model.SHIFTLIST, "SELECT", New With {.class = "all_input1", .name = "ShiftID", .Style = "border:0; font-size: 12px;"})
                                    </td>

                                    <td class="display_none" style="padding: 0 5px;">@Model.FIREBIRDSTAFFLIST(intNo).STAFFNO</td>

                                </tr>

                            Next

                        </tbody>
                    </table>


                </div>

                <div Class="footer_row_total">

                    @If Not IsNothing(Model.FIREBIRDSTAFFLIST) Then
                        @If Model.FIREBIRDSTAFFLIST.Count() > 1 Then
                            @<span>Total : @Model.FIREBIRDSTAFFLIST.Count() row(s)</span>
                        Else
                            @<span>Total : @Model.FIREBIRDSTAFFLIST.Count() row</span>
                        End If

                    Else
                        @<span>Total : 0 row</span>
                    End If

                </div>

            </div>

        End Using

    </div>

    @*</div>

        End Using*@
</div>

<div Class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
<Script type="text/javascript">


    function getTableValue() {
        var staffList = [];
        var table = document.getElementById("id-table-employee");

        for (var i = 1; i < table.rows.length; i++) {
            var row = table.rows[i];
            var staff = {};

            for (var j = 0; j < row.cells.length; j++) {
                if (j == 0) {
                    staff.NAME = row.cells[j].innerText;
                } else if (j == 1) {
                    staff.NRIC = row.cells[j].innerText;
                } else if (j == 2) {
                    staff.DEPARTMENTID = row.cells[j].querySelector("select").value;
                } else if (j == 3) {
                    staff.SHIFTID = row.cells[j].querySelector("select").value;
                }
                else if (j == 4) {
                    staff.STAFFNO = row.cells[j].innerText;

                }
            }

            staffList.push(staff);
        }

        if (staffList !== undefined && staffList !== null && staffList.length >= 0) {
            $.ajax({
                url: '/Staff/Import',
                type: 'post',
                data: {
                    StaffList: JSON.stringify(staffList)
                },
                success: async function (response) {
                }
            });
        }
    }

    // Nav Top Menu Part1
    $("#hdr_btn1").addClass("pt2_b_btneff");
</Script>
