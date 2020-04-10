@Code
    ViewData("AdminFAQ") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center padding0_10">
    <div class="faq_box">
        <div class="faq_b_htrtt">
            <span>F.A.Q</span>
        </div>

        <div class="faq_b_row">
            <div class="b_row_htrtt">
                tab 01 <div class="fa fa-plus faq_heading_btm row_htrtt_icon"></div>
            </div>

            <div class="display_none b_row_htrst">Text 01 Text 01 Text 01</div>
        </div>

        <div class="faq_b_row">
            <div class="b_row_htrtt">
                tab 02 <div class="fa fa-plus faq_heading_btm row_htrtt_icon"></div>
            </div>

            <div class="display_none b_row_htrst">Text 02 Text 02 Text 02</div>
        </div>

        <div class="faq_b_row">
            <div class="b_row_htrtt">
                tab 03 <div class="fa fa-plus faq_heading_btm row_htrtt_icon"></div>
            </div>

            <div class="display_none b_row_htrst">Text 03 Text 03 Text 03</div>
        </div>

        <div class="faq_b_row">
            <div class="b_row_htrtt">
                tab 04 <div class="fa fa-plus faq_heading_btm row_htrtt_icon"></div>
            </div>

            <div class="display_none b_row_htrst">Text 04 Text 04 Text 04</div>
        </div>
    </div>
</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $("#hdr_btn6").addClass("pt2_b_btneff");
</script>