@ModelType mTime.model.COMPANY


@Using (Html.BeginForm("Setting", "System", FormMethod.Post))
@Html.AntiForgeryToken()
@<div>

    @Html.HiddenFor(Function(Model) Model.COMPANYID)
    @Html.HiddenFor(Function(Model) Model.COMPANYNAME)
    @Html.HiddenFor(Function(Model) Model.ADDRESSLINE1)
    @Html.HiddenFor(Function(Model) Model.ADDRESSLINE2)
    @Html.HiddenFor(Function(Model) Model.ADDRESSLINE3)
    @Html.HiddenFor(Function(Model) Model.TELNO)
    @Html.HiddenFor(Function(Model) Model.FAXNO)
    @Html.HiddenFor(Function(Model) Model.COMPANYLOGOPATH)
    @Html.HiddenFor(Function(Model) Model.COMPANYHEADERPATH)
    @Html.HiddenFor(Function(Model) Model.HOMEPAGEHEADERPATH)
    @Html.HiddenFor(Function(Model) Model.DEFAULTLANGUAGE)
    @Html.HiddenFor(Function(Model) Model.STARTEDON)
    @Html.HiddenFor(Function(Model) Model.ALLOWTOSUBMITREASONIN)

        <div Class="inbox_haedtext">
            <span> Setting</span>
        </div>

        <div Class="stbox_rt1_box">
            <div Class="rt1_b_part1">
                <div Class="b_pt1_tt">Grace period (Of Day) :                </div>

                @Html.TextBoxFor(Function(model) model.GRACEPERIOD, New With {.class = "all_input1", .maxlength = 3})

                <a href = "" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>

            <div Class="rt1_b_part1">
                <div Class="b_pt1_tt">Max. Announcement :</div>

                @Html.TextBoxFor(Function(model) model.MAXANNOUNCE, New With {.class = "all_input1", .maxlength = 3})

                <a href = "" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>


            <div Class="rt1_b_part1">
                <div Class="b_pt1_tt"> Announcement Expire Day :</div>

                @Html.TextBoxFor(Function(model) model.ANNOUNCEEXPDAY, New With {.class = "all_input1", .maxlength = 3})

                <a href = "" Class="fa fa-info-circle pt1_b1_inforbtn filter1"></a>

            </div>

            <div Class="rt1_b_part2">
                <a href="@Url.Action("DefaultSetting", "System")" Class="rtpt_closebtn filter1">Default</a>
                <input type = "submit" value="Save" Class="rtpt_savebtn filter1" />
            </div>
        </div>
    </div>
End Using
