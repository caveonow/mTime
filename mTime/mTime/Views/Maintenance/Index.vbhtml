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

                    <div class="fa fa-refresh rtpt_b_ht_refresh"></div>

                    <a href="@Url.Action("Create", "Hyperlink" )">
                        <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                            Add Item
                        </div>
                    </a>

                </div>

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
                                    <div id="deletebtn" class="fa fa-trash-o btn_trash"></div>
                            </td>
                            <td>@item.Title</td>
                            <td style="padding: 0 5px;">@item.URL</td>
                        </tr>

                        Next

                    </tbody>
                </table>

                <div class="ctr_rtpt_b_ftr">
                    <span>Total : @ViewBag.TotalCount item(s)</span>
                </div>

            </div>

        </div>
    </div>

