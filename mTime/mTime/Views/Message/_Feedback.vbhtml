@Code
    ViewData("Title") = "_Feedback"
End Code

<div class="message_lt_part">
    <div class="inbox_haedtext">
        <span>Recent Feedback</span>
    </div>

    <div class="overflow_box">
        <table class="epy_lt_table">
            <thead>
                <tr>
                    <th style="width: 60px;"></th>
                    <th style="width: 140px;">Date</th>
                    <th style="width: 200px;">Employee</th>
                    <th>Comment</th>
                </tr>
            </thead>

            <tbody id="id-body-feedback"></tbody>
        </table>
    </div>


    <div class="footer_row_total">
        <span id="id-feedback-count"></span>
    </div>
</div>

<div class="message_rt_part">
    <div class="inbox_haedtext">
        <span>3 months of Feedback is displayed</span>
    </div>

    <div id="id-feedback-body" class="overflow_box" style="height: 415px;">
        <div id="id-feedback-hidden-id-feedback" class="display_none_important">
        </div>

        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Send by:</div>
            <div id="id-feedback-name" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Date:</div>
            <div id="id-feedback-date" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Content:</div>
            <div id="id-feedback-content" class="rtpt_addbox_part"></div>
        </div>
    </div>

    <div id="id-feedback-new-reply-body" class="overflow_box display_none_important">
        <div class="new_message_part" style="height: 415px;">
            <div id="id-feedback-new-personal-message-hidden-id-feedback" class="display_none_important">
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">Receiver:</div>
                <select id="id-feedback-new-personal-message-staff" multiple></select>
            </div>
            <div id="id-feedback-new-personal-message-staff-validation" class="ctr_rtpt_addbox display_none_important">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">Staff is required</span>
                </div>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">About:</div>
                <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                    id="id-feedback-new-personal-message-about" 
                    type="text"
                />
            </div>
            <div id="id-feedback-new-personal-message-about-validation" class="ctr_rtpt_addbox display_none_important">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">About is required</span>
                </div>
            </div>

            <div class="ctr_rtpt_addbox">
                <div class="rtpt_label_part">Content:</div>
                <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                    id="id-feedback-new-personal-message-content" 
                    type="text"
                />
            </div>
            <div id="id-feedback-new-personal-message-content-validation" class="ctr_rtpt_addbox display_none_important">
                <div class="rtpt_addbox_pt_error">
                    <span class="field-validation-error">Content is required</span>
                </div>
            </div>
        </div>
    </div>

    <div class="footer_row_btn" style="margin: 0 0 10px 0;">
        <div id="id-feedback-send" class="rtpt_savebtn" onclick="onClickSendPersonalMessageFromFeedback()">Send</div>
        <div id="id-feedback-reply" class="rtpt_savebtn" onclick="onClickReplyFeedback()">Reply</div>
        <div id="id-feedback-delete" class="rtpt_deletebtn" onclick="onClickDeleteFeedback()">Delete</div>
        <div id="id-feedback-back" class="rtpt_backbtn" onclick="resetTabContent()">Back</div>
    </div>

    <div id="id-feedback-delete-successful" Class="ctr_rtpt_popupbox display_none_important save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Delete successfully</div>
        </div>
    </div>

    <div id="id-feedback-reply-successful" Class="ctr_rtpt_popupbox display_none_important save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Reply successfully</div>
        </div>
    </div>
</div>

