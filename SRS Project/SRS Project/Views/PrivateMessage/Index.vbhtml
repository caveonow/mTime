@Code
    ViewData("Title") = "Private Message Page"
End Code

@Html.Partial("_StaffMenuTop")

<div class="body_center">
    <div class="message_part">
        <table class="mse_pt_table">
            <thead class="">
                <tr>
                    <th style="width: 65px;"></th>
                    <th style="width: 160px;">Date</th>
                    <th>Title</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <div id="email01" class="fa fa-envelope btn_email filter1"></div>
                        <div class="fa fa-trash-o btn_trash filter1"></div>
                    </td>
                    <td>18 Feb 2020 18:11:40</td>
                    <td>1. Cetakan laporan kedatangan bulanan</td>
                </tr>

                <tr>
                    <td>
                        <div class="fa fa-envelope btn_email filter1"></div>
                        <div class="fa fa-trash-o btn_trash filter1"></div>
                    </td>
                    <td>18 Feb 2020 18:11:40</td>
                    <td>2.Kedatangan Bulanan</td>
                </tr>
            </tbody>
        </table>

        <div class="mse_pt_itenbox">
            <span>Total 2 iten(s)</span>
        </div>
    </div>

    <div class="mse_pt_msebox">
        <div class="msebox_htr">
            <span>Private Message</span>

            <div class="rtpt_ftr_deletebtn filter1 deletebtn display_none">Clear</div>
            <div class="msebox_htr_date display_none">18 Feb 2020 18:11:40</div>
        </div>

        <div class="msebox_ttbox display_none">
            <b>Cetakan laporan kedatangan bulanan</b>
            <br><br>

            Sila sCetakan laporan kedatangan bulanan anda dan menghantarkannya kepadan penyelia anda. Sebelum membuat cetakan,anda boleh mengubah taraf kedatangan dan memberikan alasan untuk datang lewat atau balik awal. Terima kasih dengan kerjasama kamu.
        </div>
    </div>
</div>