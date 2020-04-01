    @*@model IEnumerable<model.HYPERLINK>
    *@

    @Code
    ViewData("Title") = "Home Page"
    End Code

    @Html.Partial("_AdminMenuTop")

    <div class="body_center">
        @Html.Partial("_SubMenuLeft")

        <div class="bd_ctr_rightpart">
            <div id="rtpt_box-01" class="ctr_rtpt_box">
                <div class="ctr_rtpt_b_ht">

                    <span>Hyperlink</span>
                    <a href="@Url.Action("Create", "Hyperlink" )">
                        <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                            Add
                        </div>
                    </a>
                    <!--<div class="fa fa-refresh rtpt_b_ht_refresh"></div>-->


                </div>

                <div class="overflow_box">
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 65px;"></th>
                                <th style="width: 250px;">Title</th>
                                <th>URL</th>
                            </tr>
                        </thead>

                        <tbody>

                            @For Each item In model                            
                            @<tr>
                                <td>
                                    <a href="@Url.Action("Edit", "Hyperlink" , New With {.id=item.HyperlinkID})">
                                        <div id="editbtn" class="fa fa-pencil-square-o btn_edit"></div>
                                    </a>

                                    <a href="@Url.Action("Delete", "Hyperlink" , New With {.id=item.HyperlinkID})">
                                        <div id="" class="fa fa-trash-o btn_trash deletebtn"></div>
                                    </a>

                                </td>
                                <td>@item.Title</td>
                                <td style="padding: 0 5px;">@item.URL</td>
                            </tr>

                            Next

                        </tbody>
                    </table>

                    @*<div id="" class="ctr_rtpt_popupbox deletebox-01 display_none">
                        <div class="rtpt_popupbox_inb">
                            <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                            <div class="popupbox_inb_tt">Confirm Delete</div>

                            <div class="popupbox_inb_btnpart">
                                <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                                <a href="@Url.Action("Delete", "Hyperlink" , New With {.id=item.HyperlinkID} )" id="deleteconfirmed">
                                    <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                                </a>
                            </div>
                        </div>

                    </div>*@

                </div>

                <div class="ctr_rtpt_b_ftr">

                    @If Model.Count() > 1 Then
                    @<span>Total : @Model.Count() row(s)</span>
                    else
                    @<span>Total : @Model.Count() row</span>
                    end if

                </div>
            </div>
        </div>

        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script type="text/javascript">
            $(function () {
                $("#deleteconfirmed").click(function () {
                    document.forms[0].submit();
                    return false;
                });
            });

        </script>

        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script type="text/javascript">
            $("#leftnav1").addClass("ctr_innav1_btneff");
        </script>



