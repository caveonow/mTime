@ModelType PagedList.IPagedList(Of mTime.mTime.HOLIDAY)
@Imports PagedList.Mvc
@Code
    ViewData("Title") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="ctr_rtpt_b_ht">
                <span>Holiday</span>

                <div class="fa fa-refresh rtpt_b_ht_refresh"></div>
                @Html.ActionLink("Add Item", "Create")
            </div>

            @Using Html.BeginForm("Index", "Holiday", FormMethod.Get)
                @<p>
                    
                     <select class="form-control" id="yearFilter" name="yearFilter" value="@ViewBag.yearFilter">
                         <option>All</option>
                         @For Each item In ViewBag.yearListing
                             @<option value="@ViewBag.yearFilter">@item</option>
                         Next
                     </select>
                    <input type="submit" value="Search" />
                </p>
            End Using

            <table>
                <thead>
                    <tr>
                        <th style="width: 110px;" />
                        <th style="width: 90px;">Name</th>
                        <th style="width: 150px;">Date From</th>
                        <th style="width: 150px;">Date To</th>
                        <th>Is Used</th>
                    </tr>
                </thead>

                <tbody>
                    @For Each item In Model
                        @<tr>
                            <td>
                                <a href="@Url.Action("Edit", "HOLIDAY", New With {.id = item.HOLIDAYID})" class="fa fa-pencil-square-o btn_edit" />
                                <a href="@Url.Action("Copy", "HOLIDAY", New With {.id = item.HOLIDAYID})" class="fa fa-files-o btn_copy" />
                                <a href="@Url.Action("Delete", "HOLIDAY", New With {.id = item.HOLIDAYID})" class="fa fa-trash-o btn_trash" />
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.HOLIDAYNAME)
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.FROM)
                                @*@item.FROM.ToString("dd/MM/yyyy")*@
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.UNTIL)
                                @*@item.UNTIL.ToString("dd/MM/yyyy")*@
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.ISINUSED)

                            </td>
                        </tr>
                    Next
                </tbody>
            </table>

            <div class="ctr_rtpt_b_ftr">
                Page @IIf(Model.PageCount < Model.PageNumber, 0, Model.PageNumber) of @Model.PageCount |
                Total @ViewBag.TotalHolidays item(s)

                @Html.PagedListPager(Model, Function(page) Url.Action("Index", New With {page, .yearFilter = ViewBag.yearFilter}))
            </div>
        </div>
    </div>
</div>
