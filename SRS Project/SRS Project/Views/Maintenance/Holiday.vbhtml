@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday</span>

                <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>

            <table>
                <thead>
                    <tr>
                        <th style="width: 90px;"></th>
                        <th style="width: 150px;">Date</th>
                        <th>Description</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td>
                            <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                            <div id="copybtn" class="fa fa-files-o btn_copy"></div>
                            <div id="deletebtn" class="fa fa-trash-o btn_trash"></div>
                        </td>
                        <td>31/8/2020</td>
                        <td>Day Day Holiday</td>
                    </tr>

                    <tr>
                        <td>
                            <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                            <div id="copybtn" class="fa fa-files-o btn_copy"></div>
                            <div id="deletebtn" class="fa fa-trash-o btn_trash"></div>
                        </td>
                        <td>25/12/2020</td>
                        <td>Day Day Holiday</td>
                    </tr>
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                <span>Total 2 iten(s)</span>
            </div>
        </div>

        <div id="addbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday - Add Item</span>
            </div>

            <div class="ctr_holiday_addbox">
                <!-- this is the action that call to the method in maintenance -->
                <form action="/Maintenance/AddHoliday" method="post">
                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Date :</div>
                        <input type="text" id="title" name="title">

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Description :</div>
                        <!-- name must be same with the param name OR Request.Form("title") -->
                        <input type="text" id="description" name="description">

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="hlday_addbox_partbtn">
                        <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                        <!-- need to use input with type="submit" -->
                        <input id="savebtn1" class="rtpt_savebtn filter1" type="submit" value="Save" />
                    </div>
                </form>
            </div>
        </div>

        <div id="editbox-01" class="ctr_rtpt_box display_none">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday - Edit</span>
            </div>

            <div class="ctr_holiday_addbox">
                <form action="/Maintenance/EditHoliday" method="post">
                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Date :</div>
                        <input type="text" id="title" name="title" value="31/8/2020">

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="hlday_addbox_part">
                        <div class="hlday_addbox_pt_tt">Description :</div>
                        <input type="text" id="description" name="description" value="Day Day Holiday">

                        <div class="hlday_addbox_pt_error">Text Error</div>
                    </div>

                    <div class="hlday_addbox_partbtn">
                        <div id="closebtn" class="rtpt_closebtn filter1">Close</div>

                        <input id="savebtn" class="rtpt_savebtn filter1" type="submit" value="Save" />
                    </div>
                </form>
            </div>
        </div>

        <div id="copybox-01" class="ctr_rtpt_popupbox display_none">
            <div class="rtpt_popupbox_inb">
                <div class="fa fa-files-o popupbox_inb_icon"></div>
                <div class="popupbox_inb_tt">Confirm Copy</div>

                <div class="popupbox_inb_btnpart">
                    <div id="closebtn" class="rtpt_closebtn filter1">Close</div>
                    <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                </div>
            </div>
        </div>

        <div id="deletebox-01" class="ctr_rtpt_popupbox display_none">
            <div class="rtpt_popupbox_inb">
                <form action="/Maintenance/DeleteHoliday" method="post">
                    <input type="text" id="uuid" name="uuid" value="123" style="display:none">

                    <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                    <div class="popupbox_inb_tt">Confirm Delete</div>

                    <div class="popupbox_inb_btnpart">
                        <div id="closebtn" class="rtpt_closebtn filter1">Close</div>
                        <input id="yesbtn" type="submit" class="rtpt_yesbtn filter1" value="Yes" />
                    </div>
                </form>
            </div>
        </div>

        @*<div class="ctr_rtpt_footer">
                <div class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>*@
    </div>
</div>
