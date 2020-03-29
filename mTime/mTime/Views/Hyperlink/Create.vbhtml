
@ModelType model.HYPERLINK

@Code
    ViewData("Title") = "Create"
End Code

@Html.Partial("_AdminMenuTop")

<div class="body_center">
    @Html.Partial("_SubMenuLeft")
    <div class="bd_ctr_rightpart">
        <div id="rtpt_box-01" class="ctr_rtpt_box">

            @Using (Html.BeginForm())

                @Html.AntiForgeryToken()
                @<div class="form-horizontal">

                    <div Class="ctr_rtpt_b_ht">
                        <span> Hyperlink - Add Item</span>
                    </div>

                    <div Class="ctr_rtpt_addbox">
                        <div Class="rtpt_addbox_part">
                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">Title :</div>

                                @Html.TextBoxFor(Function(model) model.TITLE)

                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.TITLE)
                                </div>

                            </div>
                        </div>

                        <div Class="rtpt_addbox_part">

                            <div class="form-group">
                                <div Class="rtpt_addbox_pt_tt">URL :</div>

                                @Html.TextBoxFor(Function(model) model.URL)
                                <div Class="rtpt_addbox_pt_error">
                                    @Html.ValidationMessageFor(Function(model) model.URL)
                                </div>
                            </div>

                        </div>


                        <div Class="rtpt_addbox_partbtn">
                            <a href="@Url.Action("Index", "Maintenance")">
                                <div id="closebtn" Class="rtpt_closebtn filter1">
                                    Cancel
                                </div>
                            </a>
                            <a href="@Url.Action("Create", "Hyperlink")" id="save">
                                <div id="savebtn" Class="rtpt_savebtn filter1">
                                    Save
                                </div>
                            </a>

                        </div>

                    </div>

                </div>

            End Using
        </div>

    </div>

</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("#save").click(function () {         
            document.forms[0].submit();
            return false;
        });
    });

</script>

End If











