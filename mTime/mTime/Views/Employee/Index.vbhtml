@Code
    ViewData("Employee") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="employee_part" style="">
        <div class="epy_pt_lt" style="">
            <div class="epy_lt_box1" style="">

                <div class="inbox_haedtext">
                    <span>Search Employee</span>
                </div>

                <div class="lt_b1_inb" style="">
                    <div class="b1_inb_part" style="">
                        <div class="inb_pt_tt" style="">Name :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part" style="">
                        <div class="inb_pt_tt" style="">Sumame :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part" style="">
                        <div class="inb_pt_tt" style="">NRIC :</div>

                        <input type="text" id="title" name="title" class="all_input1">
                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part" style="">
                        <div class="inb_pt_tt" style="">Department :</div>

                        <select id="cars" class="all_input1">
                            <option value="EP1">EP1</option>
                            <option value="EP2">EP2</option>
                            <option value="EP3">EP3</option>
                            <option value="EP4">EP4</option>
                        </select>

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part1" style="">
                        <div class="inb_pt1_tt" style="">Working Shift :</div>

                        <select id="cars" class="all_input1">
                            <option value="EP1">EP1</option>
                            <option value="EP2">EP2</option>
                            <option value="EP3">EP3</option>
                            <option value="EP4">EP4</option>
                        </select>

                        <a class="fa fa-calendar events_none icon_calendar_btn" style=""></a>

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="b1_inb_part" style="">
                        <input type="checkbox" id="" name="vehicle1" style="margin:5px 5px 0 0;">
                        <div class="inb_pt_checkboxtt" style="">Show Resigned Employees</div>
                    </div>

                    <div class="footer_row_btn" style="padding:0 0;">
                        <a href="" id="save" class="rtpt_closebtn filter1">
                            Display
                        </a>
                    </div>
                </div>
            </div>

            <div class="epy_lt_box2" style="">

                <div class="inbox_haedtext">
                    <span>Employee List</span>
                </div>

                <div class="overflow_box" style="height: 300px;">
                    <table class="epy_lt_table" style="">
                        <thead style="">
                            <tr>
                                <th style="width: 200px;">Name</th>
                                <th style="width: 100px;">Sumame</th>
                                <th style="width: 150px;">NRIC</th>
                                <th style="width: 100px;">Department</th>
                                <th style="width: 100px;">Working Shift</th>
                            </tr>
                        </thead>

                        <tbody style="">
                            <tr>
                                <td style="">1</td>
                                <td style="">1</td>
                                <td style="">1</td>
                                <td style="">1</td>
                                <td style="padding: 0 5px;">1</td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <div class="footer_row_total" style="">
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