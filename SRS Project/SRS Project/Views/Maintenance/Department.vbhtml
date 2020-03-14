@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Department</span>

                <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>

            <div class="bd_ctr_rightpart1">
                <div class="ctr_rtpt1_inb">
                    <div class="fa fa-angle-right pn_heading_btm ctr_rtpt1_icon1"></div>
                    <div class="fa fa-building-o ctr_rtpt1_icon2"></div>
                    COMPANY1
                </div>

                <ul>
                    <li>
                        <div class="fa fa-users li_users_icon"></div>TEAM1 (20)
                        <div id="renamebtn" class="li_btn_rename">Rename</div>
                        <div id="deletebtn" class="li_btn_delete">Delete</div>
                    </li>
                    <li>
                        <div class="fa fa-users li_users_icon"></div>TEAM2 (6)
                        <div id="renamebtn" class="li_btn_rename">Rename</div>
                        <div id="deletebtn" class="li_btn_delete">Delete</div>
                    </li>
                    <li>
                        <div class="fa fa-users li_users_icon"></div>TEAM3
                        <div id="renamebtn" class="li_btn_rename">Rename</div>
                        <div id="deletebtn" class="li_btn_delete">Delete</div>
                    </li>
                </ul>
            </div>

            <div class="ctr_rtpt_b_ftr">
                <span>Total 2 iten(s)</span>
            </div>
        </div>

        <div id="addbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Department - Add Item</span>
            </div>

            <div class="ctr_holiday_addbox">
                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Company :</div>
                    <input type="text" id="title" name="title">

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Department :</div>
                    <input type="text" id="URL" name="URL">

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="hlday_addbox_partbtn">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>
                    <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
                </div>
            </div>
        </div>

        <div id="editbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Department - Edit</span>
            </div>

            <div class="ctr_holiday_addbox">
                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Company :</div>
                    <input type="text" id="title" name="title" value="COMPANY 1">

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="hlday_addbox_part">
                    <div class="hlday_addbox_pt_tt">Department :</div>
                    <input type="text" id="URL" name="URL" value="TEAM1">

                    <div class="hlday_addbox_pt_error">Text Error</div>
                </div>

                <div class="hlday_addbox_partbtn">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                    <div id="savebtn" class="rtpt_savebtn filter1">Save</div>
                </div>
            </div>
        </div>

        <div id="deletebox-01" class="ctr_rtpt_popupbox display_none">
            <div class="rtpt_popupbox_inb">
                <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                <div class="popupbox_inb_tt">Confirm Delete</div>

                <div class="popupbox_inb_btnpart">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>
                    <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                </div>
            </div>
        </div>

        @*<div class="ctr_rtpt_footer">
                <div class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>*@
    </div>
</div>