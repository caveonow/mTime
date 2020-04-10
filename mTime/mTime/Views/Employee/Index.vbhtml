@Code
    ViewData("Employee") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="employee_part">
        <div class="epy_pt_lt">
            <div class="epy_lt_box1">

                <div class="inbox_haedtext">
                    <span>Search Employee</span>
                </div>

                <div class="lt_b1_inb">
                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Name :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Sumame :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">NRIC :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part">
                        <div class="inb_pt_tt">Department :</div>

                        <select id="cars" class="all_input1">
                            <option value="EP1">EP1</option>
                            <option value="EP2">EP2</option>
                            <option value="EP3">EP3</option>
                            <option value="EP4">EP4</option>
                        </select>

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part1">
                        <div class="inb_pt1_tt">Working Shift :</div>

                        <select id="cars" class="all_input1">
                            <option value="EP1">EP1</option>
                            <option value="EP2">EP2</option>
                            <option value="EP3">EP3</option>
                            <option value="EP4">EP4</option>
                        </select>

                        <a class="fa fa-calendar events_none icon_calendar_btn"></a>

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part">
                        <input type="checkbox" id="" name="vehicle1" style="margin:5px 5px 0 0;">
                        <div class="inb_pt_checkboxtt">Show Resigned Employees</div>
                    </div>

                    <div class="footer_row_btn" style="padding:0 0;">
                        <a href="" id="save" class="rtpt_closebtn filter1">
                            Display
                        </a>
                    </div>
                </div>
            </div>

            <div class="epy_lt_box2">

                <div class="inbox_haedtext">
                    <span>Employee List</span>
                </div>

                <div class="overflow_box" style="height: 300px;">
                    <table class="epy_lt_table">
                        <thead>
                            <tr>
                                <th style="width: 200px;">Name</th>
                                <th style="width: 100px;">Sumame</th>
                                <th style="width: 150px;">NRIC</th>
                                <th style="width: 100px;">Department</th>
                                <th style="width: 100px;">Working Shift</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>1</td>
                                <td>1</td>
                                <td>1</td>
                                <td style="padding: 0 5px;">1</td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <div class="footer_row_total">
                    <span>Total : 0 row</span>
                </div>
            </div>
        </div>

        <div class="epy_pt_rt">
            <div class="inbox_haedtext">
                <span>Select an employee from "Employee List" and edit here.</span>
            </div>

            <div class="overflow_box">

            </div>

            <div class="footer_row_btn" style="margin: 0 0 10px 0;">
                <a href="" id="save" class="rtpt_savebtn filter1">Save</a>
                <a href="" id="save" class="rtpt_savebtn filter1">Save All</a>
                <a href="" id="save" class="rtpt_deletebtn filter1">Delete</a>
                <a href="" id="save" class="rtpt_closebtn filter1">Add Employee</a>
                <a href="" id="save" class="rtpt_yesbtn filter1">Reset Login</a>
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
    $("#hdr_btn1").addClass("pt2_b_btneff");
</script>