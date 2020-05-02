@ModelType  model.STAFFDEPARTMENT

@Code
    ViewData("Title") = "Import"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="employee_part">
        <div class="epy_pt_lt">
            <div class="epy_lt_box1">

                @*@Using (Html.BeginForm())

                    @Html.AntiForgeryToken()
                    @<div class="form-horizontal">

                        @Html.HiddenFor(Function(Model) Model.FIREBIRDSTAFFLIST)*@

                <div class="inbox_haedtext">
                    <span>Search Staff</span>
                </div>

                <div class="lt_b1_inb">
                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">First Name :</div>
                        @Html.EditorFor(Function(model) model.FIRSTNAME, New With {.htmlAttributes = New With {.maxlength = 100, .class = "all_input1"}})
                    </div>

                    @*<div class="b1_inb_part">
                            <div class="inb_pt_tt">First Name :</div>
                            @Html.EditorFor(Function(model) model.FIRSTNAME, New With {.htmlAttributes = New With {.maxlength = 100, .class = "all_input1"}})
                        </div>*@

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Last Name :</div>

                        @*<input type="text" id="title" name="title" class="all_input1">*@
                        @Html.EditorFor(Function(model) model.LASTNAME, New With {.htmlAttributes = New With {.maxlength = 100, .class = "all_input1"}})
                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">NRIC :</div>

                        @*<input type="text" id="NRIC1" name="NRIC" class="all_input1">*@
                        @Html.EditorFor(Function(model) model.NRIC, New With {.htmlAttributes = New With {.maxlength = 20, .class = "all_input1"}})

                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Department :</div>
                        @Html.DropDownListFor(Function(model) model.DEPARTMENTID, Model.DEPARTMENTLIST, "SELECT", New With {.class = "all_input1", .name = "SELECTEDDEPARTMENTNAME"})

                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Working Shift :</div>
                        @Html.DropDownListFor(Function(model) model.SHIFTID, Model.SHIFTLIST, "SELECT", New With {.class = "all_input1"})
                        @*<a class="fa fa-calendar events_none icon_calendar_btn"></a>*@
                    </div>

                    <div class="b1_inb_part">
                        @*<input type="checkbox" id="" name="vehicle1" style="margin:5px 5px 0 0;">*@
                        @*@Html.CheckBoxFor(Function(model) model.SHOWRESIGNEDSTAFF, New With {.class = "all_input1"})*@


                        <div class="checkinbox">
                            @Html.EditorFor(Function(model) model.SHOWRESIGNEDSTAFF, New With {.htmlAttributes = New With {.class = ""}})
                            <div class="checkinboxtext">Include Resigned</div>
                        </div>

                    </div>

                    <input type="submit" value='Submit' class="rtpt_ftr_addbtn filter1" />

                </div>


                @*</div>

                    End Using*@


            </div>

        </div>

        @Using (Html.BeginForm("Import", "Staff", FormMethod.Post))

            @Html.AntiForgeryToken()

            @<div class="form-horizontal">

                @*<fieldset>*@

                @*<div Class="epy_pt_rt">*@
                <div class="epy_pt_rt">
                    <div class="inbox_haedtext">

                        @*@Html.HiddenFor(Model.FIREBIRDSTAFFLIST)*@

                        <span>New Staff</span>

                        <!--<button type="submit" id="btnSave" name="Command" value="Save">Save</button>-->

                        <div onclick="getTableValue()" style="color: white; margin: auto; border: 1px solid; width: 50px; cursor: pointer;">save</div>

                        @*<a href="@Url.Action("Import", "Staff")" id="save">
                                <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                                    Save
                                </div>
                            </a>*@
                    </div>

                    <div class="overflow_box">
                        <table id="id-table-employee" class="epy_lt_table">
                            <thead>
                                <tr>
                                    <th style="width: 400px;">Name</th>
                                    <th style="width: 140px;">NRIC</th>
                                    <th style="width: 200px;">Department Name</th>
                                    <th>Working Shift</th>
                                </tr>
                            </thead>

                            <tbody>

                                @For intNo = 0 To Model.FIREBIRDSTAFFLIST.Count - 1

                                    @Html.HiddenFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).STAFFNO, New With {.name = "[" + intNo.ToString + "].StaffNo"})
                                    @<tr>
                                        <td style="padding: 0 5px;">@Html.LabelFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).NAME, New With {.name = "[" + intNo.ToString + "].Name"})</td>
                                        <td style="padding: 0 5px;">@Html.LabelFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).NRIC, New With {.name = "[" + intNo.ToString + "].NRIC"})</td>
                                        @*<td style="padding: 0 5px;">@item.DEPARTMENTID</td>*@
                                        <td>
                                            @Html.DropDownListFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).DEPARTMENTID, Model.DEPARTMENTLIST, "SELECT", New With {.class = "all_input1", .name = "DepartmentID"})
                                        </td>
                                        @*<td style="padding: 0 5px;">@item.SHIFTID</td>*@
                                        <td>
                                            @Html.DropDownListFor(Function(model) model.FIREBIRDSTAFFLIST(intNo).SHIFTID, Model.SHIFTLIST, "SELECT", New With {.class = "all_input1", .name = "ShiftID"})
                                        </td>
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

                @*</fieldset>*@


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

    // $(function () {
    //     $("#save").click(function () {
    //         document.forms[0].submit();
    //         //$(this).closest('form')[0].submit();
    //         Return False;
    //     });
    // });
    
    function getTableValue() {
        var staffList = [];
        var table = document.getElementById("id-table-employee");

        for (var i = 1; i < table.rows.length; i++) {            
            var row = table.rows[i];
            var staff = {};

            for(var j = 0; j < row.cells.length; j++) {
                if(j == 0) {
                    staff.NAME = row.cells[j].innerText;
                } else if(j == 1) {
                    staff.NRIC = row.cells[j].innerText;
                } else if(j == 2) {
                    staff.DEPARTMENTID = row.cells[j].querySelector("select").value;
                } else if(j == 3) {
                    staff.SHIFTID = row.cells[j].querySelector("select").value;
                }
            }

            staffList.push(staff);
        }

        if(staffList !== undefined && staffList !== null && staffList.length >= 0) {
            $.ajax({
                url:'/Staff/SaveImport',
                type:'post',
                data: {
                    StaffList: staffList
                },
                success:async function(response){
                    
                }
            });
        }
    }

    // Nav Top Menu Part1
    $("#hdr_btn1").addClass("pt2_b_btneff");
</Script>
