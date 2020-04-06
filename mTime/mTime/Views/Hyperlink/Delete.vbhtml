@ModelType model.HYPERLINK

@Code
    ViewData("Title") = "Delete"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm("Delete", "Hyperlink", method:=FormMethod.Post))

                @Html.AntiForgeryToken()

                @<div class="form-horizontal">

                    @Html.HiddenFor(Function(Model) Model.HYPERLINKID)

                    <div Class="inbox_haedtext">
                        <span> Hyperlink :: Delete</span>
                    </div>

                    <div Class="ctr_rtpt_addbox bg_bd1_radius">
                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">Title :</div>

                            @Html.TextBoxFor(Function(model) model.TITLE, New With {.Readonly = True, .class = "all_input1"})
                        </div>

                        <div Class="rtpt_addbox_part">
                            <div Class="rtpt_addbox_pt_tt">URL :</div>

                            @Html.TextBoxFor(Function(model) model.URL, New With {.Readonly = True, .class = "all_input1"})
                        </div>

                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>

                            <div id="" class="rtpt_deletebtn filter1 deletebtn">
                                Delete
                            </div>

                            <div id="" class="ctr_rtpt_popupbox display_none deletebox-01">
                                <div class="rtpt_popupbox_inb">
                                    <div class="fa fa-trash-o popupbox_inb_icon_red"></div>
                                    <div class="popupbox_inb_tt">Delete @Model.TITLE ? </div>

                                    <div class="popupbox_inb_btnpart">
                                        <div id="closebtn" class="rtpt_closebtn filter1">No</div>

                                        <a href="@Url.Action("Delete", "Hyperlink")" id="deleteconfirmed">
                                            <div id="yesbtn" class="rtpt_yesbtn filter1">Yes</div>
                                        </a>

                                        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
                                        <script type="text/javascript">
                                            $(function () {
                                                $("#deleteconfirmed").click(function () {
                                                    document.forms[0].submit();
                                                    return false;
                                                });
                                            });
                                        </script>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            End Using
        </div>
    </div>
</div>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    //$(function () {
    //    $("#delete").click(function () {

    //        if (confirm('delete ?') == true) {

    //            document.forms[0].submit();

    //        }

    //        return false;

    //    });
    //});

    //Nav Top Menu Part1
    $("#hdr_btn4").addClass("pt2_b_btneff");

    //Nav Left Menu Part1
    $("#leftnav1").addClass("ctr_innav1_btneff");
</script>