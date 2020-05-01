@Code
    ViewData("Title") = "_Announcement"
End Code

<div class="message_lt_part" >
    <div class="inbox_haedtext">
        <span>Recent Announcement</span>
    </div>

    <div class="overflow_box">
        <table class="epy_lt_table" style="width:100%">
            <thead>
                <tr>
                    <th style="width: 60px;"></th>
                    <th>Title</th>
                    <th style="width: 140px;">Valid From</th>
                    <th style="width: 140px;">Valid To</th>
                </tr>
            </thead>

            <tbody id="id-body-announcement"></tbody>
        </table>
    </div>


    <div class="footer_row_total">
        <span id="id-announcement-count"></span>
    </div>
</div>

<div class="message_rt_part">
    <div class="inbox_haedtext">
        <span>Click "Create" button to create new Announcement </span>
    </div>

    <div id="id-announcement-body" class="overflow_box" style="height: 415px;">
        <div id="id-announcement-hidden-id-announcement" class="display_none">
        </div>

        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Title:</div>
            <div id="id-announcement-title" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Valid From:</div>
            <div id="id-announcement-valid-from" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Valid To:</div>
            <div id="id-announcement-valid-to" class="rtpt_addbox_part"></div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Remarks:</div>
            <div id="id-announcement-remark" class="rtpt_addbox_part"></div>
        </div>
    </div>

    <div id="id-announcement-create-body" class="overflow_box" style="height: 415px;">
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Title:</div>
            <input class="rtpt_addbox_part all_input1 text-box single-line form-control"
                id="id-announcement-create-title"
                type="text"
            />
            
        </div>
        <div id="id-announcement-create-title-validation" class="ctr_rtpt_addbox display_none">
            <div class="rtpt_addbox_pt_error">
                <span class="field-validation-error">Title is required</span>
            </div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Valid From:</div>
            <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                id="id-announcement-create-valid-from" 
                type="datetime"
            />
        </div>
        <div id="id-announcement-create-valid-from-validation" class="ctr_rtpt_addbox display_none">
            <div class="rtpt_addbox_pt_error">
                <span class="field-validation-error">Valid From is required</span>
            </div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Valid To:</div>
            <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                id="id-announcement-create-valid-to" 
                type="datetime" 
            />
        </div>
        <div id="id-announcement-create-valid-to-validation" class="ctr_rtpt_addbox display_none">
            <div class="rtpt_addbox_pt_error">
                <span class="field-validation-error">Valid To is required</span>
            </div>
        </div>
        <div class="ctr_rtpt_addbox">
            <div class="rtpt_label_part">Remarks:</div>
            <input class="rtpt_addbox_part all_input1 text-box single-line form-control" 
                id="id-announcement-create-remark" 
                type="text" 
            />
        </div>
        <div id="id-announcement-create-remark-validation" class="ctr_rtpt_addbox display_none">
            <div class="rtpt_addbox_pt_error">
                <span class="field-validation-error">Remarks is required</span>
            </div>
        </div>
    </div>

    <div class="footer_row_btn" style="margin: 0 0 10px 0;">
        <div id="id-announcement-save" class="rtpt_savebtn" onclick="onClickSaveAnnouncement()">Save</div>
        <div id="id-announcement-create" class="rtpt_yesbtn" onclick="onClickAnnouncementCreate()">Create</div>
        <div id="id-announcement-delete" class="rtpt_deletebtn" onclick="onClickDeleteAnnouncement()">Delete</div>
        <div id="id-announcement-back" class="rtpt_backbtn" onclick="resetTabContent()">Back</div>
    </div>

    <div id="id-announcement-save-successful" Class="ctr_rtpt_popupbox display_none save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Save successfully</div>
        </div>
    </div>

    <div id="id-announcement-delete-successful" Class="ctr_rtpt_popupbox display_none save_ok_popup">
        <div Class="rtpt_popupbox_inb">
            <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
            <div Class="popupbox_inb_tt">Delete successfully</div>
        </div>
    </div>
</div>