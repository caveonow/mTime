@Code
    ViewData("Title") = "Home Page"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">
                <span>Department</span>

                @*<div class="fa fa-refresh rtpt_b_ht_refresh"></div>*@
                <a href="@Url.Action("Create", "Department")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">Add</div>
                </a>
            </div>

            <div class="overflow_box">
                <div class="bd_ctr_rightpart1">
                    <div class="ctr_rtpt1_inb">
                        <div class="fa fa-angle-down fa-angle-down pn_heading_btm ctr_rtpt1_icon1 filter1"></div>
                        <div class="fa fa-building-o ctr_rtpt1_icon2"></div>
                        COMPANY1
                    </div>

                    <ul>
                        @Code
                            Dim TotalCompanyCount = 1
                        End Code

                        @For Each item In model

                            @<li>
                                <div>
                                    <div class="fa fa-users li_users_icon"></div>
                                    <div class="li_text">
                                        @item.DEPARTMENTNAME
                                        <b>: 10</b>
                                    </div>
                                    @*<div id="renamebtn" class="li_btn_rename"></div>*@
                                    @Html.ActionLink("Rename", "Edit", "Department", New With {.id = item.DEPARTMENTID}, New With {.class = "li_btn_rename filter1"})
                                    @*<div id="deletebtn" class="li_btn_delete">Delete</div>*@
                                    @Html.ActionLink("Delete", "Delete", "Department", New With {.id = item.DEPARTMENTID}, New With {.class = "li_btn_delete filter1"})
                                </div>
                            </li>
                        Next item
                    </ul>
                </div>


                @*Sample UI*@
                <div class="bd_ctr_rightpart1">
                    <div class="ctr_rtpt1_inb">
                        <div class="fa fa-angle-down fa-angle-down pn_heading_btm ctr_rtpt1_icon1 filter1"></div>
                        <div class="fa fa-building-o ctr_rtpt1_icon2"></div>
                        Sample UI 1
                    </div>

                    <ul>
                        <li>
                            <div>
                                <div class="fa fa-users li_users_icon"></div>
                                <div class="fa fa-list li_list_icon pn_sumlist_btm filter1"></div>

                                <div class="li_text">
                                    NAME 1
                                    <b>: 10</b>
                                </div>

                                <div id="renamebtn" class="li_btn_rename">Rename</div>
                                <div id="deletebtn" class="li_btn_delete">Delete</div>
                            </div>

                            <ul class="ul_sub">
                                <li class="bg_colorgray1">
                                    <div>
                                        <div class="fa fa-users li_users_icon"></div>
                                        <div class="fa fa-list li_list_icon pn_sumlist_btm filter1"></div>
                                        <div class="li_text">
                                            NAME 1-1
                                            <b>: 10</b>
                                        </div>

                                        <div id="renamebtn" class="li_btn_rename">Rename</div>
                                        <div id="deletebtn" class="li_btn_delete">Delete</div>
                                    </div>

                                    <ul class="ul_sub">
                                        <li class="bg_colorgray1">
                                            <div>
                                                <div class="fa fa-users li_users_icon"></div>
                                                <div class="li_text">
                                                    NAME 1-1
                                                    <b>: 10</b>
                                                </div>

                                                <div id="renamebtn" class="li_btn_rename">Rename</div>
                                                <div id="deletebtn" class="li_btn_delete">Delete</div>
                                            </div>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </li>

                        <li>
                            <div>
                                <div class="fa fa-users li_users_icon"></div>
                                <div class="li_text">
                                    NAME 1
                                    <b>: 10</b>
                                </div>

                                <div id="renamebtn" class="li_btn_rename">Rename</div>
                                <div id="deletebtn" class="li_btn_delete">Delete</div>
                            </div>
                        </li>

                        <li>
                            <div>
                                <div class="fa fa-users li_users_icon"></div>
                                <div class="li_text">
                                    NAME 1
                                    <b>: 10</b>
                                </div>

                                <div id="renamebtn" class="li_btn_rename">Rename</div>
                                <div id="deletebtn" class="li_btn_delete">Delete</div>
                            </div>
                        </li>

                    </ul>
                </div>
                @*Sample UI*@


            </div>

            <div class="ctr_rtpt_b_ftr">

                <span>Total @TotalCompanyCount item(s)</span>
            </div>
        </div>

        <div id="addbox-01" class="ctr_rtpt_box display_none">
            <div class="inbox_haedtext">
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


<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>

<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav3").addClass("ctr_innav1_btneff");
</script>