@Code
    ViewData("Title") = "_NewPersonalMessage"
End Code

<div class="new_message_part" style="height: 415px;">
    <div id="id-new-personal-message-hidden-id-feedback" class="display_none">
    </div>

    <div class="ctr_rtpt_addbox">
        <div class="rtpt_label_part">Receiver:</div>
        <select id="chkveg" multiple></select>
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