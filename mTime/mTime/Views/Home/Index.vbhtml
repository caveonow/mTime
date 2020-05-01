@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_StaffMenuTop")

<div class="body_center">

    <div class="ctr_leftpart_home">
        <div class="leftpart_home_box">
            <div class="ltpt_home_b_httt">
                Hari Cuti Akan Datang
            </div>

            <ul class="leftpart_ul_box">
                <li>
                    <a href="" class="">
                        Hyperlink 01
                    </a>
                </li>

                <li>
                    <a href="" class="">
                        Hyperlink 02
                    </a>
                </li>
            </ul>
        </div>

        <div class="leftpart_home_box">
            <div class="ltpt_home_b_httt">
                Hiperankai
            </div>

            <ul class="leftpart_ul_box">
                <li>
                    <a href="" class="">
                        eModuler Support
                    </a>
                </li>

                <li>
                    <a href="" class="">
                        Malaysia Goverment's Official Portal
                    </a>
                </li>
            </ul>
        </div>
    </div>

    <div class="ctr_rightpart_home">
        <div class="rtpt_home_box">
            @*<div class="rtpt_home_b_img"></div>*@

            <img src="../../img/htr_bg.jpg"  width="100%">

            <div class="rtpt_home_b_tt">
                selamat datang ke MyTie sistem kedatangan. Andb dibenarkan mencetak and membetulkan record kedatangan anda di sini.
            </div>

            <div class="rtpt_home_b_linkpart">Pengumuman</div>
        </div>
    </div>
</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $("#stfhdr_btn1").addClass("pt2_b_btneff");
</script>