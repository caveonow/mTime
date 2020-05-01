@ModelType model.STAFFDEPARTMENT

@Code
    ViewData("Title") = "List"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="employee_part">
        <div class="epy_pt_lt">
            <div class="epy_lt_box1">

                @Using (Html.BeginForm())

                    @Html.AntiForgeryToken()
                    @<div class="form-horizontal">

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


                    </div>

                End Using


            </div>

        </div>

        @*<div Class="epy_pt_rt">*@
        <div class="epy_pt_rt">
                <div class="inbox_haedtext">

                    <span>Staff</span>
                    <a href="@Url.Action("Import", "Staff")">
                        <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                            Import
                        </div>
                    </a>

                    <!--<div class="fa fa-refresh rtpt_b_ht_refresh"></div>-->
                </div>

                <div class="overflow_box">
                    <table class="epy_lt_table">
                        <thead>
                            <tr>
                                <th style="width: 65px;"></th>
                                <th style="width: 200px;">First Name</th>
                                <th style="width: 200px;">Last Name</th>
                                <th style="width: 140px;">NRIC</th>
                                <th style="width: 200px;">Department Name</th>
                                <th style="width: 200px;">Division Name</th>
                                <th style="width: 200px;">Unit Name</th>
                                <th>Working Shift</th>
                            </tr>
                        </thead>

                        <tbody>

                            @If Not IsNothing(Model.STAFFSIMPLELIST) Then


                                @For Each item In Model.STAFFSIMPLELIST
                                    @<tr>
                                        <td>
                                            <a href="@Url.Action("Edit", "Staff", New With {.id = item.NRIC})">
                                                <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                                            </a>

                                            <a href="@Url.Action("Delete", "Staff", New With {.id = item.NRIC})">
                                                <div id="" class="fa fa-trash-o btn_trash deletebtn"></div>
                                            </a>

                                        </td>
                                        <td style="padding: 0 5px;">@item.FIRSTNAME</td>
                                        <td style="padding: 0 5px;">@item.LASTNAME</td>
                                        <td style="padding: 0 5px;">@item.NRIC</td>
                                        <td style="padding: 0 5px;">@item.DEPARTMENTNAME</td>
                                        <td style="padding: 0 5px;">@item.DIVISIONNAME</td>
                                        <td style="padding: 0 5px;">@item.UNITNAME</td>
                                        <td style="padding: 0 5px;">@item.SHIFTID</td>

                                    </tr>

                                Next

                            End If


                        </tbody>
                    </table>


                </div>

                <div class="footer_row_total">

                    @If Not IsNothing(Model.STAFFSIMPLELIST) Then
                        @If Model.STAFFSIMPLELIST.Count() > 1 Then
                            @<span>Total : @Model.STAFFSIMPLELIST.Count() row(s)</span>
                        Else
                            @<span>Total : @Model.STAFFSIMPLELIST.Count() row</span>
                        End If

                    Else
                        @<span>Total : 0 row</span>
                    End If

                </div>


            @*<div Class="inbox_haedtext">
                    <span>Select an employee from "Employee List" And edit here.</span>
                </div>

                <div Class="overflow_box">

                </div>

                <div Class="footer_row_btn" style="margin: 0 0 10px 0;">
                    <a href="" id="save" Class="rtpt_savebtn filter1">Save</a>
                    <a href="" id="save" Class="rtpt_savebtn filter1">Save All</a>
                    <a href="" id="save" Class="rtpt_deletebtn filter1">Delete</a>
                    <a href="" id="save" Class="rtpt_closebtn filter1">Add Employee</a>
                    <a href="" id="save" Class="rtpt_yesbtn filter1">Reset Login</a>
                </div>*@
        </div>
    </div>
</div>

<div Class="bg_color_w"></div>

<Script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></Script>
<Script type="text/javascript">

    $(function () {
        $("#deleteconfirmed").click(function () {
            document.forms[0].submit();
            return false;
        });
    });


</Script>

<Script type="text/javascript">
    // Nav Top Menu Part1
    $("#hdr_btn1").addClass("pt2_b_btneff");
</Script>
