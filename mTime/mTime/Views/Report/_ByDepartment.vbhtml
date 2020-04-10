@Code
    ViewData("Title") = "_ByDepartment"
End Code

<div class="report_lt_part">
    <div class="rpt_lt_pt">
        <div class="rpt_lt_box">
            <div class="lt_b_tt">Department :</div>

            <select id="" name="Bulan" class="lt_b_select">
                <option value="Department1">Department1</option>
                <option value="Department2">Department2</option>
                <option value="Department3">Department3</option>
            </select>

            <div class="hlday_addbox_pt_error">Text Error</div>
        </div>       

        <div class="rpt_lt_box">
            <div class="lt_b_tt">Month :</div>

            <select id="" name="Bulan" class="lt_b_select">
                <option value="January, 2020">January, 2020</option>
                <option value="February, 2020">February, 2020</option>
                <option value="March, 2020">March, 2020</option>
                <option value="April, 2020">April, 2020</option>
                <option value="May, 2020">May, 2020</option>
                <option value="June, 2020">June, 2020</option>
                <option value="July, 2020">July, 2020</option>
                <option value="August, 2020">August, 2020</option>
                <option value="September, 2020">September, 2020</option>
                <option value="October, 2020">October, 2020</option>
                <option value="November, 2020">November, 2020</option>
                <option value="December, 2020">December, 2020</option>
            </select>

            <div class="hlday_addbox_pt_error">Text Error</div>
        </div>

        <div class="rpt_lt_ttbox">Plase select a month and department to display all employee under the department and their overtime status. Select employee(s) from the employee list (Tick the checkbox) for print employees' time attendance report.</div>

        <div class="footer_row1_btn">
            <a href="" id="save" class="rtpt_closebtn filter1">
                Display
            </a>
        </div>
    </div>

    <div class="report_rt_part">
        <div class="inbox_haedtext">
            <span>By Department Report</span>
        </div>

        <div class="overflow_box">
            <table class="epy_lt_table" style="width:100%">
                <thead>
                    <tr>
                        <th style="width: 140px;">Date</th>
                        <th>Title</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td>23 May 2020 16:00:00</td>
                        <td>Changes of Shift Schedule</td>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class="footer_row_total">
            <span>Total : 1 row</span>
        </div>
    </div>
</div>