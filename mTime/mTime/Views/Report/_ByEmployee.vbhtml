@Code
    ViewData("Title") = "_ByEmployee"
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

        <div class="rpt_lt_box" style="margin-top:20px;">
            <div class="lt_b_radiobox"><input type="radio" class="" style="margin:0 5px 0 0;"> Door Access Report</div>
        </div>

        <div class="rpt_lt_box" style="padding: 0 35px 0 100px;">
            <div class="lt_b_tt">Date :</div>
            <input type="text" id="" name="date" class="all_input1" />
            <a class="fa fa-calendar icon_calendar1_btn"></a>

            <div class="hlday_addbox_pt_error">Text Error</div>
        </div>

        <div class="rpt_lt_box">
            <div class="lt_b_tt">Employee :</div>

            <select id="" name="Bulan" class="lt_b_select">
                <option value="Employee1">Employee1</option>
                <option value="Employee2">Employee2</option>
                <option value="Employee3">Employee3</option>
            </select>

            <div class="hlday_addbox_pt_error">Text Error</div>
        </div>

        <div class="rpt_lt_box" style="margin-top:20px;">
            <div class="lt_b_radiobox"><input type="radio" class="" style="margin:0 5px 0 0;"> Time Attendance Monthly Report</div>
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

        <div class="rpt_lt_box">
            <div class="lt_b_tt">Employee :</div>

            <select id="" name="Bulan" class="lt_b_select">
                <option value="Employee1">Employee1</option>
                <option value="Employee2">Employee2</option>
                <option value="Employee3">Employee3</option>
            </select>

            <div class="hlday_addbox_pt_error">Text Error</div>
        </div>


        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> HLY - Holiday
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> HWK - Off Day
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> ICP - Incomplete Time Attendance (No Time Out)
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> LIN - Late In
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> EOT - Early Out
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> L/E - Late In & Early Out
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> ABS - No Time In & No Time Out
        </div>

        <div class="report_checkbox">
            <input type="checkbox" id="" name="checkbox" value="checkbox" class="margin_checkbox1" checked> OTH - Others
        </div>

        <div class="footer_row_btn" style="padding:0 0; margin-top:20px;">
            <a href="" id="save" class="rtpt_closebtn filter1">
                Display
            </a>
        </div>
    </div>

    <div class="report_rt_part">
        <div class="inbox_haedtext">
            <span>By Employee Report</span>
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