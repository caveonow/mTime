@Code
    ViewData("Title") = "_PersonalMessage"
End Code

<div class="message_lt_part">
    <div class="inbox_haedtext">
        <span>Personal Message</span>
    </div>

    <div class="overflow_box">
        <table class="epy_lt_table">
            <thead>
                <tr>
                    <th style="width: 60px;"></th>
                    <th style="width: 140px;">Date</th>
                    <th style="width: 200px;">Employee</th>
                    <th>Title</th>
                </tr>
            </thead>

            <tbody id="id-body-personal-message">
                @For Each item In ViewBag.PersonalMessageList
                @<tr>
                    <td><div class="ball_color1" onclick="onSelectMessageItem(@item.PERSONALMESSAGEID)"></div></td>
                    <td>@item.CREATEDON</td>
                    <td>@item.NAME</td>
                    <td>@item.ABOUT</td>
                </tr>
                Next
            </tbody>
        </table>
    </div>


    <div id="id-personal-message-count" class="footer_row_total">
        @If ViewBag.PersonalMessageListCount > 1 Then
            @<span>Total : @ViewBag.PersonalMessageListCount row(s)</span>
        Else
            @<span>Total : @ViewBag.PersonalMessageListCount row</span>
        End If
    </div>
</div>

<div class="message_rt_part">
    <div class="inbox_haedtext">
        <span>Click "Create" button to create a new Personal Message and send to employee</span>
    </div>

    <div id="id-personal-message-body" class="overflow_box visibility_hidden" style="height: 415px;">
        <div id="id-personal-message-hidden-id-feedback" class="display_none">
        </div>

        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Send to:</div>
            <div id="id-personal-message-name" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Date:</div>
            <div id="id-personal-message-date" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Title:</div>
            <div id="id-personal-message-title" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Content:</div>
            <div id="id-personal-message-content" class="rtpt_addbox_part"></div>
        </div>
    </div>

    <div id="id-personal-message-new-reply-body" class="overflow_box display_none">
        <div class="new_message_part" style="height: 415px;">
            <div id="id-new-personal-message-hidden-id-feedback" class="display_none">
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">Receiver:</div>
                <select id="id-new-personal-message-staff" multiple></select>
            </div>
            <div id="id-new-personal-message-staff-validation" class="ctr_rtpt_addbox display_none">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">Staff is required</span>
                </div>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">About:</div>
                <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                    id="id-new-personal-message-about" 
                    type="text"
                />
            </div>
            <div id="id-new-personal-message-about-validation" class="ctr_rtpt_addbox display_none">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">About is required</span>
                </div>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">Content:</div>
                <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                    id="id-new-personal-message-content" 
                    type="text"
                />
            </div>
            <div id="id-new-personal-message-content-validation" class="ctr_rtpt_addbox display_none">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">Content is required</span>
                </div>
            </div>
        </div>
    </div>

    <div class="footer_row_btn" style="margin: 0 0 10px 0;">
        <div id="id-personal-message-send" class="rtpt_savebtn btn_disabled" onclick="onClickSendPersonalMessage()">Send</div>
        <div id="id-personal-message-create" class="rtpt_yesbtn" onclick="onClickPersonalMessageCreate()">Create</div>
        <div id="id-personal-message-delete" class="rtpt_deletebtn btn_disabled" onclick="onClickDeletePersonalMessage()">Delete</div>
        <div id="id-personal-message-back" class="rtpt_backbtn btn_disabled" onclick="resetTabContent()">Back</div>
    </div>

    <div id="id-personal-message-delete-successful" Class="ctr_rtpt_popupbox display_none save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Delete successfully</div>
        </div>
    </div>

    <div id="id-personal-message-reply-successful" Class="ctr_rtpt_popupbox display_none save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Reply successfully</div>
        </div>
    </div>
</div>
