@Code
    ViewData("System") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    <div class="systembox_lt">
        @Html.Partial("CompanyInfoUpdate")
    </div>


    <div class="systembox_rt1">
        @Html.Partial("Setting")
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