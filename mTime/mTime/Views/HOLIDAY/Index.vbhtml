
@ModelType IEnumerable(Of model.HOLIDAY)

@Code
    ViewData("Title") = "List"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")

    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">
            <div class="inbox_haedtext">
                <span>Holiday</span>

                @Using (Html.BeginForm("ImportHoliday", "Holiday", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
                @Html.AntiForgeryToken()
                @<div class="form-horizontal">

                    @*<div id="addnewbtn" class="rtpt_ftr_addbtn filter1">*@
                    <div id="importFilebtn" class="rtpt_ftr_addbtn filter1">
                        <label for="importFile" class="custom-file-upload">
                            Import
                        </label>
                        <input id="importFile" name="postedFile" type="file" accept=".csv" style="display: none;" />
                    </div>
                    @*</div>*@

                </div>
                End Using

                <a href="@Url.Action("Create", "Holiday")">
                    <div id="addnewbtn" class="rtpt_ftr_addbtn filter1">
                        Add
                    </div>
                </a>



            </div>

            <div Class="overflow_box">
                <Table>
                    <thead>
                        <tr>
                            <th style="width: 90px;" />
                            <th>Name</th>
                            <th style="width: 150px;">Start Date</th>
                            <th style="width: 150px;">End Date</th>
                            <th style="width: 90px;">In Used</th>
                        </tr>
                    </thead>

                    <tbody>
                        @For Each item In Model
                        @<tr>
                            <td>
                                <a href="@Url.Action("Edit", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-pencil-square-o btn_edit" />
                                @*<a href="@Url.Action("Create", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-files-o btn_copy" />*@
                                <a href="@Url.Action("Delete", "Holiday", New With {.id = item.HOLIDAYID})" class="fa fa-trash-o btn_trash deletebtn" />
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.HOLIDAYNAME)
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.DATESTART)
                            </td>
                            <td>
                                @Html.DisplayFor(Function(modelItem) item.DATEEND)
                            </td>

                            <td style="padding: 0 5px;">
                                <input type="checkbox" name="isInUsed" checked=@item.ISINUSED onclick="return false" class="check-box" />
                            </td>

                        </tr>
                        Next
                    </tbody>
                </Table>
            </div>

            <div class="ctr_rtpt_b_ftr">

                @If Model.Count() > 1 Then
                @<span>Total : @Model.Count() row(s)</span>
                Else
                @<span>Total : @Model.Count() row</span>
                End If

            </div>

            @Code

                If TempData("HolidayImportResult") <> "" Then

                    If TempData("HolidayImportResult") = "OK" Then
                @<script>
                             window.onload = function () {
                                 $(".save_ok_popup").addClass("display_block").fadeOut(3000);
                             };
                </script>
                    Else


                @<script>
                             window.onload = function () {
                                 $(".exclamation_ok_popup").addClass("display_block").fadeOut(3000);
                             };
                </script>
                    End If

                    TempData("HolidayImportResult") = ""

                End If

            End Code


            <div id="" Class="ctr_rtpt_popupbox display_none save_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
                    <div Class="popupbox_inb_tt">Holiday is imported successfully</div>
                </div>
            </div>

            <div id="" Class="ctr_rtpt_popupbox display_none exclamation_ok_popup">
                <div Class="rtpt_popupbox_inb">
                    <div Class="fa fa-exclamation-circle popupbox_inb_icon_red"></div>
                    <div Class="popupbox_inb_tt">Failed to import Holiday</div>
                </div>
            </div>


        </div>
    </div>
</div>


<div class="bg_color_w"></div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/bootstrap-datepicker.js")

    <script type="text/javascript">

        // Nav Top Menu Part1
        $("#hdr_btn4").addClass("pt2_b_btneff");

        //Nav Left Menu Part1
        $("#leftnav2").addClass("ctr_innav1_btneff");

        $(function () {

            var importFile = $("#importFile");

            importFile.change(function () {

                document.forms[0].submit();
                return false;

                //var fileName = $(this).val().split('\\')[$(this).val().split('\\').length - 1];
                //var fileExtension = $(this).val().substring($(this).val().lastIndexOf(".") + 1, $(this).val().length);

                //if (fileName.length > 0) {

                //    if (fileExtension == "csv") {
                //        //document.forms[0].submit();
                //        //return false;
                //    }

                //var fileUpload = $("#importFile").get(0);
                //var files = fileUpload.files;

                //// Create FormData object
                //var fileData = new FormData();

                //// Looping over all files and add it to FormData object
                //for (var i = 0; i < files.length; i++) {
                //    fileData.append(files[i].name, files[i]);
                //}

                //$.ajax({
                //    url: "/Holiday/ImportHoliday",
                //    type: "POST",
                //    enctype: "multipart/form-data",
                //    contentType: false, // Not to set any content header
                //    processData: false, // Not to process data
                //    data: fileData,
                //    success: function (result) {
                //        //alert(result);
                //        $(".save_ok_popup").addClass("display_block").fadeOut(3000);

                //    },
                //    error: function (err) {
                //        //alert(err.statusText);
                //        //alert("Failed to import file 1");
                //        $(".exclamation_ok_popup").addClass("display_block").fadeOut(3000);
                //    }
                //});

                //}
            });


        });

    </script>

End Section

