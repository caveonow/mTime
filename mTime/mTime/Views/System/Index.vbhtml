@Code
    ViewData("System") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

    <div class="body_center">
        <div class="systembox_lt">
            <div class="inbox_haedtext">
                <span>Company Info</span>
            </div>

            <div class="stbox_lt_part1">
                <div class="lt_pt1_box1">
                    <div class="pt1_b1_tt">Name :</div>

                    <input type="text" id="title" name="title" class="all_input1">

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box1">
                    <div class="pt1_b1_tt">Address :</div>

                    <textarea type="" id="title" name="title" class="pt1_b1_textarea"></textarea>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box1">
                    <div class="pt1_b1_tt">Tel :</div>

                    <input type="tel" id="title" name="title" class="all_input1">

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box1">
                    <div class="pt1_b1_tt">Fax :</div>

                    <input type="tel" id="title" name="title" class="all_input1">

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>
                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box2">
                    <div class="pt1_b2_tt">Company Logo :</div>

                    <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style="background-image:url(../../img/malaysia_logo_s.png);">

                    <a href="" class="fa fa-folder-open pt1_b2_folderbtn filter1"></a>

                    <a href="" class="fa fa-times pt1_b2_deletebtn filter1"></a>

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box2">
                    <div class="pt1_b2_tt">Company Header :</div>

                    <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style=" background-image:url(../../img/htr_bg.jpg);">

                    <a href="" class="fa fa-folder-open pt1_b2_folderbtn filter1"></a>

                    <a href="" class="fa fa-times pt1_b2_deletebtn filter1"></a>

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="lt_pt1_box2">
                    <div class="pt1_b2_tt">Home Header :</div>

                    <input type="tel" id="title" name="title" class="all_input1 pt1_b2_inputimg" style=" background-image:url(../../img/htr_bg.jpg);">

                    <a href="" class="fa fa-folder-open pt1_b2_folderbtn filter1"></a>

                    <a href="" class="fa fa-times pt1_b2_deletebtn filter1"></a>

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>
            </div>

            <div class="stbox_lt_part2">
                <a href="" id="save" class="rtpt_savebtn filter1">
                    Save
                </a>
            </div>
        </div>


        <div class="systembox_rt1">
            <div class="inbox_haedtext">
                <span>Setting</span>
            </div>

            <div class="stbox_rt1_box">
                <div class="rt1_b_part1">
                    <div class="b_pt1_tt">Grace period (Day) :</div>

                    <input type="number" id="" name="day" value="7" class="all_input1">

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="rt1_b_part1">
                    <div class="b_pt1_tt">Max. Announcement :</div>

                    <input type="number" id="" name="day" value="30" class="all_input1">

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>


                <div class="rt1_b_part1">
                    <div class="b_pt1_tt"> Announcement Expire Day :</div>

                    <input type="number" id="" name="day" value="60" class="all_input1">

                    <a href="" class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="rt1_b_part2">
                    <a href="" id="save" class="rtpt_closebtn filter1">default</a>
                    <a href="" id="save" class="rtpt_savebtn filter1">Save</a>
                </div>
            </div>
        </div>

        <div class="systembox_rt2">
            <div class="inbox_haedtext">
                <span>Housekeeping</span>
            </div>

            <div class="stbox_rt2_box2">
                <div class="rt2_b2_tt">Purge Announcement and Feedback history record regularly can reduce the database size and improve system performance.</div>


                <div class="rt2_b2_box">
                    <a href="" id="save" class="rtpt_savebtn filter1">Purge</a>
                </div>
            </div>
        </div>

        <div class="systembox_rt3">
            <div class="inbox_haedtext">
                <span>Manufacturer</span>
            </div>

            <div class="stbox_rt3_box">
                <div class="rt3_b_httext">
                    eModuler Solutions Sdn. Bhd.
                </div>

                <div class="rt3_b_addtext">
                    22A-D Jalan BS 9,<br />
                    Tanam Bukit Segar<br />
                    Cheras Batu 9
                </div>

                <div class="rt3_b_textbox">
                    <b>Tel</b> <div>: +603-9100 5155</div>
                </div>

                <div class="rt3_b_textbox">
                    <b>Fax</b> <div>: +603-9100 5155</div>
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
    $("#hdr_btn5").addClass("pt2_b_btneff");
</script>