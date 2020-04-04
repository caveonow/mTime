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

                @*<div class="fa fa-refresh rtpt_b_ht_refresh"></div>*@
                <a href="@Url.Action("Create", "Department")">
                <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add</div>
                </a>
            </div>

            <div class="overflow_box">
                <div class="bd_ctr_rightpart1">
                    <div class="ctr_rtpt1_inb">
                        <div class="fa fa-angle-right pn_heading_btm ctr_rtpt1_icon1"></div>
                        <div class="fa fa-building-o ctr_rtpt1_icon2"></div>
                        COMPANY1
                    </div>

                    <ul>
                        @Code
                        Dim TotalCompanyCount = 1
                        End Code

                        @For Each item In model
                        
                        @<li>
                            <div class="fa fa-users li_users_icon"></div>
                            @item.DEPARTMENTNAME
                            @*<div id="renamebtn" class="li_btn_rename"></div>*@
                            @Html.ActionLink("Rename", "Edit", "Department", new with {.id = item.DEPARTMENTID}, new with {.class = "li_btn_rename"})
                            @*<div id="deletebtn" class="li_btn_delete">Delete</div>*@
                            @Html.ActionLink("Delete", "Delete", "Department", new with {.id = item.DEPARTMENTID}, new with {.class = "li_btn_delete"})                      
                         </li>
                         Next item
                    </ul>
                </div>
            </div>

            <div class="ctr_rtpt_b_ftr">

                <span>Total @TotalCompanyCount item(s)</span>
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


        @*<div class="ctr_rtpt_footer">
                <div class="rtpt_ftr_addbtn filter1">Add Item</div>
            </div>*@
    </div>
</div>

<div class="bg_color_w"></div>
