
@Code
    ViewData("Title") = "List"
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
                        @ViewBag.CompanyName
                    </div>

                    @Code
                        Dim strDepartmentName As String = vbNull
                        Dim strDivisionName As String = vbNull
                        Dim strUnitName As String = vbNull
                    End Code

                    @*<div Class="li_text">*@

                    <ul>
                        @For Each item In Model

                            @If IsDBNull(strDepartmentName) Or (strDepartmentName <> item.DEPARTMENTNAME) Then

                                @<li class="li_level01">
                                     <div>
                                         <div Class="fa fa-users li_users_icon" style="color:darkblue"></div>
                                            @item.DEPARTMENTNAME
                                         <span class="badge badge-info" style="font-size:8pt">@item.DEPARTMENTSTAFFCOUNT</span>

                                         @Code
                                             strDepartmentName = item.DEPARTMENTNAME
                                             strDivisionName = vbNull
                                             strUnitName = vbNull
                                         End Code

                                     </div>
                                </li>
                            End If


                            @if IsDBNull(strDivisionName) Or (strDivisionName <> item.DIVISIONNAME) Then

                                @Code
                                    strDivisionName = item.DIVISIONNAME
                                    strUnitName = vbNull
                                End Code

                                @<ul Class="ul_sub">
                                    <li class="li_level02">
                                        <div>
                                            <div Class="fa fa-users li_users_icon" style="color:brown"></div>
                                            @If item.DIVISIONNAME = "" Then
                                                @<span>-</span>
                                            Else
                                                @item.DIVISIONNAME
                                            End If

                                            <span class="badge badge-info" style="font-size:8pt">@item.DIVISIONSTAFFCOUNT</span>

                                        </div>
                                    </li>
                                </ul>

                                    End If

                            @Code
                                strUnitName = item.UNITNAME
                            End code

                            @<ul style="padding: 0 10px 0 55px !important;">
                                <li class="li_level03">
                                    <div>
                                        <div Class="fa fa-users li_users_icon" style="color:darkslategray"></div>

                                        @If item.UNITNAME = "" Then
                                            @<span>-</span>
                                        Else
                                            @item.UNITNAME
                                        End If


                                        <span class="badge badge-info" style="font-size:8pt">@item.UNITSTAFFCOUNT</span>

                                        @Html.ActionLink("Edit", "Edit", "Department", New With {.id = item.DEPARTMENTID}, New With {.class = "li_btn_rename filter1"})
                                        @Html.ActionLink("Delete", "Delete", "Department", New With {.id = item.DEPARTMENTID}, New With {.class = "li_btn_delete filter1"})


                                    </div>
                                </li>
                            </ul>

                        Next
                    </ul>


                </div>

                <div Class="ctr_rtpt_b_ftr">

                </div>

            </div>

        </div>

    </div>

</div>

<div Class="bg_color_w"></div>


<Script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></Script>

<Script type="text/javascript">
    // Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav3").addClass("ctr_innav1_btneff");
</Script>
