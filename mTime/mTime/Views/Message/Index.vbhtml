@Code
    ViewData("Message") = "Index"
End Code

@Html.Partial("_AdminMenuTop")

    <div class="body_htrcenter">
        <a href="#atdc_part1" id="atdc_tab1" class="htrcenter_tab bg_color_444" onclick="getResult('PersonalMessage')">
            <div class="innav1_inbtn_tt">
                <span>Personal Message</span>
            </div>
        </a>

        <a href="#atdc_part2" id="atdc_tab2" class="htrcenter_tab" onclick="getResult('Announcement')">
            <div class="innav1_inbtn_tt">
                <span id="id-span-announcement">Announcement</span>
            </div>
        </a>

        <a href="#atdc_part3" id="atdc_tab3" class="htrcenter_tab" onclick="getResult('Feedback')">
            <div class="innav1_inbtn_tt">
                <span>Feedback</span>
            </div>
        </a>
    </div>

    <div id="id-tab-contents" class="body_center top130">
        <div id="atdc_part1" class="display_block">@Html.Partial("_PersonalMessage")</div>
        <div id="atdc_part2" class="display_none">@Html.Partial("_Announcement")</div>
        <div id="atdc_part3" class="display_none">@Html.Partial("_Feedback")</div>
    </div>

<div class="bg_color_w"></div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
<script type="text/javascript">
    //Nav Top Menu Part1
    $("#hdr_btn2").addClass("pt2_b_btneff");

    var selectedStaffIdList = [];
    var isLoadedPersonalMessageReceiver = false;
    var isLoadedFeedbackReceiver = false;

    $(function() {
        resetTabContent();
    });

    function getResult(tabValue){
        if(tabValue !== null && tabValue !== undefined && tabValue !== "") {
            resetTabContent();
            
            if(tabValue === "PersonalMessage") {
                $.ajax({
                    url:'/Message/MessageIndex',
                    type:'post',
                    success:async function(response){
                        $("#id-body-personal-message").html(response[0]);
                        $("#id-personal-message-count").html(response[1]);
                    }
                });
            } else if(tabValue === "Announcement") {
                $.ajax({
                    url:'/Message/AnnouncementIndex',
                    type:'post',
                    success:async function(response){
                        $("#id-body-announcement").html(response[0]);
                        $("#id-announcement-count").html(response[1]);
                    }
                });
            } else if(tabValue === "Feedback") {
                $.ajax({
                    url:'/Message/FeedbackIndex',
                    type:'post',
                    success:async function(response){
                        $("#id-body-feedback").html(response[0]);
                        $("#id-feedback-count").html(response[1]);
                    }
                });
            }
        }
    }

    function resetTabContent() {
        //Personal Message
        $('#id-personal-message-body').addClass('visibility_hidden');
        $('#id-personal-message-body').removeClass('display_none');
        $('#id-personal-message-new-reply-body').addClass('display_none');

        $('#id-personal-message-send').addClass('btn_disabled');
        $('#id-personal-message-create').removeClass('btn_disabled');
        $('#id-personal-message-delete').addClass('btn_disabled');
        $('#id-personal-message-back').addClass('btn_disabled');

        //Announcement
        $('#id-announcement-body').addClass('visibility_hidden');
        $('#id-announcement-body').removeClass('display_none');
        $('#id-announcement-create-body').addClass('visibility_hidden');
        $('#id-announcement-create-body').addClass('display_none');

        $('#id-announcement-save').addClass('btn_disabled');
        $('#id-announcement-create').removeClass('btn_disabled');
        $('#id-announcement-delete').addClass('btn_disabled');
        $('#id-announcement-back').addClass('btn_disabled');

        ///Feedback
        $('#id-feedback-body').addClass('visibility_hidden');
        $('#id-feedback-body').removeClass('display_none');
        $('#id-feedback-new-reply-body').addClass('display_none');

        $('#id-feedback-send').addClass('btn_disabled');
        $('#id-feedback-reply').addClass('btn_disabled');
        $('#id-feedback-delete').addClass('btn_disabled');
        $('#id-feedback-back').addClass('btn_disabled');
    }

    function onSelectMessageItem(idMessage) {
        $.ajax({
            url:'/Message/GetMessageItem/' + idMessage,
            type:'post',
            success:async function(response){
                $('#id-personal-message-body').removeClass('visibility_hidden');
                $('#id-personal-message-body').removeClass('display_none');
                $('#id-personal-message-new-reply-body').addClass('display_none');

                $('#id-personal-message-send').addClass('btn_disabled');
                $('#id-personal-message-create').addClass('btn_disabled');
                $('#id-personal-message-delete').removeClass('btn_disabled');
                $('#id-personal-message-back').removeClass('btn_disabled');

                $("#id-personal-message-hidden-id-feedback").html(response[0]);
                $("#id-personal-message-name").html(response[1]);
                $("#id-personal-message-date").html(response[2]);
                $("#id-personal-message-title").html(response[3]);
                $("#id-personal-message-content").html(response[4]);
            }
        });
    }

    function onSelectAnnouncementItem(idMessage) {
        $.ajax({
            url:'/Message/GetAnnouncementItem/' + idMessage,
            type:'post',
            success:async function(response){
                $('#id-announcement-body').removeClass('visibility_hidden');
                $('#id-announcement-body').removeClass('display_none');
                $('#id-announcement-create-body').addClass('visibility_hidden');
                $('#id-announcement-create-body').addClass('display_none');

                $('#id-announcement-delete-successful').addClass('display_none');
                $("#id-announcement-delete-successful").css("display", "");

                $('#id-announcement-save').addClass('btn_disabled');
                $('#id-announcement-create').addClass('btn_disabled');
                $('#id-announcement-delete').removeClass('btn_disabled');
                $('#id-announcement-back').removeClass('btn_disabled');

                $("#id-announcement-hidden-id-announcement").html(response[0]);
                $("#id-announcement-title").html(response[1]);
                $("#id-announcement-valid-from").html(response[2]);
                $("#id-announcement-valid-to").html(response[3]);
                $("#id-announcement-remark").html(response[4]);
            }
        });
    }

    function onSelectFeedbackItem(idFeedback) {
        $.ajax({
            url:'/Message/GetFeedbackItem/' + idFeedback,
            type:'post',
            success:async function(response){
                $('#id-feedback-body').removeClass('visibility_hidden');

                $('#id-feedback-send').addClass('btn_disabled');
                $('#id-feedback-reply').removeClass('btn_disabled');
                $('#id-feedback-delete').removeClass('btn_disabled');
                $('#id-feedback-back').removeClass('btn_disabled');

                $('#id-feedback-delete-successful').addClass('display_none');
                $("#id-feedback-delete-successful").css("display", "");

                $("#id-feedback-hidden-id-feedback").html(response[0]);
                $("#id-feedback-name").html(response[1]);
                $("#id-feedback-date").html(response[2]);
                $("#id-feedback-content").html(response[3]);
            }
        });
    }

    function onClickPersonalMessageCreate() {
        selectedStaffIdList = [];

        $('#id-new-personal-message-hidden-id-feedback').html("");
        $('.token').remove()
        $(".token-search > input").val("")
        $('#id-new-personal-message-about').val("");
        $('#id-new-personal-message-content').val("");

        $.ajax({
            url:'/Message/InitNewPersonalMessage',
            type:'get',
            data: {
                
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "") {
                    var optionList = [];
                    var responseSelectionList = response[0];

                    for(var i = 0; i < responseSelectionList.length; i++) {
                        optionList.push("<option value='" + responseSelectionList[i].NRIC + "'>" + responseSelectionList[i].FIRSTNAME + " " + responseSelectionList[i].LASTNAME + "</option>")
                    }

                    $('#id-personal-message-body').addClass('display_none');
                    $('#id-personal-message-new-reply-body').removeClass('display_none');

                    $('#id-new-personal-message-reply-successful').addClass('display_none');
                    $("#id-new-personal-message-reply-successful").css("display", "");

                    $('#id-personal-message-send').removeClass('btn_disabled');
                    $('#id-personal-message-create').addClass('btn_disabled');
                    $('#id-personal-message-delete').addClass('btn_disabled');
                    $('#id-personal-message-back').removeClass('btn_disabled');

                    $('#id-new-personal-message-staff-validation').addClass('display_none');
                    $('#id-new-personal-message-about-validation').addClass('display_none');
                    $('#id-new-personal-message-content-validation').addClass('display_none');

                    $("#id-new-personal-message-staff").html(optionList);
                    $('#id-new-personal-message-staff').tokenize2({
                        searchFromStart: false,
                        sortable: true,
                        displayNoResultsMessage: true,
                        noResultsMessageText: 'No results mached "%s"',
                        placeholder: "Staff name",
                        zIndexMargin: 99,
                        dropdownMaxItems: 10
                    });

                    if(!isLoadedPersonalMessageReceiver) {
                        $('#id-new-personal-message-staff').on('tokenize:tokens:added', function(e, value, text){
                            selectedStaffIdList.push(value);
                        });
                        
                        $('#id-new-personal-message-staff').on('tokenize:tokens:remove', function(e, value){
                            selectedStaffIdList.splice(selectedStaffIdList.indexOf(value), 1 );
                        });

                        isLoadedPersonalMessageReceiver = true;
                    }
                }
            }
        });
    }

    function onClickDeletePersonalMessage() {
        $('#id-personal-message-delete-successful').addClass('display_none');
        $("#id-personal-message-delete-successful").css("display", "");

        var idPersonalMessageStr = $('#id-personal-message-hidden-id-feedback')[0].innerHTML;

        $.ajax({
            url:'/Message/DeletePersonalMessage',
            type:'post',
            data: {
                id: idPersonalMessageStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_DELETE") {
                    $('#id-personal-message-delete-successful').removeClass('display_none').fadeOut(1500);
                    getResult("PersonalMessage");
                }
            }
        });
    }

    function onClickSendPersonalMessage() {
        $('#id-personal-message-reply-successful').addClass('display_none');
        $("#id-personal-message-reply-successful").css("display", "");

        //reset all validation
        $('#id-new-personal-message-staff-validation').addClass('display_none');
        $('#id-new-personal-message-about-validation').addClass('display_none');
        $('#id-new-personal-message-content-validation').addClass('display_none');

        //js side checking
        var isValid = true;

        var aboutStr = $('#id-new-personal-message-about').val();
        var contentStr = $('#id-new-personal-message-content').val();

        if(selectedStaffIdList === null || selectedStaffIdList === undefined || selectedStaffIdList === '' || selectedStaffIdList.length == 0) {
            isValid = false;
            $('#id-new-personal-message-staff-validation').removeClass('display_none');
        }
        if(aboutStr === null || aboutStr === undefined || aboutStr === '') {
            isValid = false;
            $('#id-new-personal-message-about-validation').removeClass('display_none');
        }
        if(contentStr === null || contentStr === undefined || contentStr === '') {
            isValid = false;
            $('#id-new-personal-message-content-validation').removeClass('display_none');
        }

        if(!isValid)
            return;

        $.ajax({
            url:'/Message/ReplyFeedback',
            type:'post',
            data: {
                nricList: selectedStaffIdList,
                about: aboutStr,
                content: contentStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response !== "SUCCESS_REPLY") {
                    for(var i = 0; i < response.length; i++) {
                        if(response[i] === 'ERROR_STAFF')
                            $('#id-new-personal-message-staff-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_ABOUT')
                            $('#id-new-personal-message-about-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_CONTENT')
                            $('#id-new-personal-message-content-validation').removeClass('display_none');
                    }
                } else if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_REPLY") {
                    $('.token').remove()
                    $(".token-search > input").val("")
                    $('#id-new-personal-message-about').val("");
                    $('#id-new-personal-message-content').val("");

                    $('#id-personal-message-reply-successful').removeClass('display_none').fadeOut(1500);
                    getResult("PersonalMessage");
                }
            }
        });
    }

    function onClickAnnouncementCreate() {
        $('#id-announcement-body').addClass('display_none');
        $('#id-announcement-create-body').removeClass('visibility_hidden');
        $('#id-announcement-create-body').removeClass('display_none');

        $('#id-announcement-save-successful').addClass('display_none');
        $("#id-announcement-save-successful").css("display", "");

        $('#id-announcement-save').removeClass('btn_disabled');
        $('#id-announcement-create').addClass('btn_disabled');
        $('#id-announcement-delete').addClass('btn_disabled');
        $('#id-announcement-back').removeClass('btn_disabled');

        $('#id-announcement-create-title-validation').addClass('display_none');
        $('#id-announcement-create-remark-validation').addClass('display_none');
        $('#id-announcement-create-valid-from-validation').addClass('display_none');
        $('#id-announcement-create-valid-to-validation').addClass('display_none');

        $('#id-announcement-create-valid-from').datepicker({
            autoclose: true,
            changeMonth: true,
            changeYear: true,
            language: "en-IE",
            format: "dd/mm/yyyy"
        });

        $('#id-announcement-create-valid-to').datepicker({
            autoclose: true,
            changeMonth: true,
            changeYear: true,
            language: "en-IE",
            format: "dd/mm/yyyy"
        });

        $('#id-announcement-create-title').val("");
        $('#id-announcement-create-remark').val("");
        $('#id-announcement-create-valid-from').val("");
        $('#id-announcement-create-valid-to').val("");
    }

    function onClickDeleteAnnouncement() {
        $('#id-announcement-delete-successful').addClass('display_none');
        $("#id-announcement-delete-successful").css("display", "");

        var idAnnouncementStr = $('#id-announcement-hidden-id-announcement')[0].innerHTML;

        $.ajax({
            url:'/Message/DeleteAnnouncement',
            type:'post',
            data: {
                id: idAnnouncementStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_DELETE") {
                    $('#id-announcement-delete-successful').removeClass('display_none').fadeOut(1500);
                    getResult("Announcement");
                }
            }
        });
    }

    function onClickSaveAnnouncement() {
        $('#id-announcement-save-successful').addClass('display_none');
        $("#id-announcement-save-successful").css("display", "");

        //reset all validation
        $('#id-announcement-create-title-validation').addClass('display_none');
        $('#id-announcement-create-remark-validation').addClass('display_none');
        $('#id-announcement-create-valid-from-validation').addClass('display_none');
        $('#id-announcement-create-valid-to-validation').addClass('display_none');

        //js side checking
        var isValid = true;
        var titleStr = $('#id-announcement-create-title').val();
        var remarkStr = $('#id-announcement-create-remark').val();
        var validFromStr = $('#id-announcement-create-valid-from').val();
        var validToStr = $('#id-announcement-create-valid-to').val();

        if(titleStr === null || titleStr === undefined || titleStr === '') {
            isValid = false;
            $('#id-announcement-create-title-validation').removeClass('display_none');
        }
        if(remarkStr === null || remarkStr === undefined || remarkStr === '') {
            isValid = false;
            $('#id-announcement-create-remark-validation').removeClass('display_none');
        }
        if(validFromStr === null || validFromStr === undefined || validFromStr === '') {
            isValid = false;
            $('#id-announcement-create-valid-from-validation').removeClass('display_none');
        }
        if(validToStr === null || validToStr === undefined || validToStr === '') {
            isValid = false;
            $('#id-announcement-create-valid-to-validation').removeClass('display_none');
        }

        if(!isValid)
            return;

        //call to save method
        $.ajax({
            url:'/Message/CreateNewAnnoucement',
            type:'post',
            data: {
                title: titleStr,
                remark: remarkStr,
                validFrom: validFromStr,
                validTo: validToStr,
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response !== "SUCCESS_SAVE") {
                    for(var i = 0; i < response.length; i++) {
                        if(response[i] === 'ERROR_TITLE')
                            $('#id-announcement-create-title-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_REMARK')
                            $('#id-announcement-create-remark-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_VALIDFROM')
                            $('#id-announcement-create-valid-from-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_VALIDTO')
                            $('#id-announcement-create-valid-to-validation').removeClass('display_none');
                    }
                } else if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_SAVE") {
                    $('#id-announcement-save-successful').removeClass('display_none').fadeOut(1500);
                    getResult("Announcement");
                }
            }
        });
    }

    function onClickDeleteFeedback() {
        $('#id-feedback-delete-successful').addClass('display_none');
        $("#id-feedback-delete-successful").css("display", "");

        var idFeedbackStr = $('#id-feedback-hidden-id-feedback')[0].innerHTML;

        $.ajax({
            url:'/Message/DeleteFeedback',
            type:'post',
            data: {
                id: idFeedbackStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_DELETE") {
                    $('#id-feedback-delete-successful').removeClass('display_none').fadeOut(1500);
                    getResult("Feedback");
                }
            }
        });
    }

    function onClickReplyFeedback() {
        selectedStaffIdList = [];

        $('#id-feedback-new-personal-message-hidden-id-feedback').html("");
        $('.token').remove()
        $(".token-search > input").val("")
        $('#id-feedback-new-personal-message-about').val("");
        $('#id-feedback-new-personal-message-content').val("");

        var idFeedbackStr = $('#id-feedback-hidden-id-feedback')[0].innerHTML;

        $.ajax({
            url:'/Message/InitNewPersonalMessage',
            type:'get',
            data: {
                idFeedback: idFeedbackStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "") {
                    var optionList = [];
                    var responseSelectionList = response[0];

                    for(var i = 0; i < responseSelectionList.length; i++) {
                        optionList.push("<option value='" + responseSelectionList[i].NRIC + "'>" + responseSelectionList[i].FIRSTNAME + " " + responseSelectionList[i].LASTNAME + "</option>")
                    }

                    $('#id-feedback-body').addClass('display_none');
                    $('#id-feedback-new-reply-body').removeClass('display_none');

                    $('#id-feedback-reply-successful').addClass('display_none');
                    $("#id-feedback-reply-successful").css("display", "");

                    $('#id-feedback-send').removeClass('btn_disabled');
                    $('#id-feedback-reply').addClass('btn_disabled');
                    $('#id-feedback-delete').addClass('btn_disabled');
                    $('#id-feedback-back').removeClass('btn_disabled');

                    $('#id-feedback-new-personal-message-staff-validation').addClass('display_none');
                    $('#id-feedback-new-personal-message-about-validation').addClass('display_none');
                    $('#id-feedback-new-personal-message-content-validation').addClass('display_none');

                    $("#id-feedback-new-personal-message-hidden-id-feedback").html($('#id-feedback-hidden-id-feedback')[0].innerHTML);

                    $("#id-feedback-new-personal-message-staff").html(optionList);
                    $('#id-feedback-new-personal-message-staff').tokenize2({
                        searchFromStart: false,
                        sortable: true,
                        displayNoResultsMessage: true,
                        noResultsMessageText: 'No results mached "%s"',
                        placeholder: "Staff name",
                        zIndexMargin: 99,
                        dropdownMaxItems: 10
                    });

                    if(!isLoadedFeedbackReceiver) {
                        $('#id-feedback-new-personal-message-staff').on('tokenize:tokens:added', function(e, value, text){
                            selectedStaffIdList.push(value);
                        });
                        
                        $('#id-feedback-new-personal-message-staff').on('tokenize:tokens:remove', function(e, value){
                            selectedStaffIdList.splice(selectedStaffIdList.indexOf(value), 1 );
                        });
                        isLoadedFeedbackReceiver = true;
                    }

                    if(response[1] !== undefined && response[1] !== null && response[1] !== '' && 
                        response[2] !== undefined && response[2] !== null && response[2] !== '') {
                        $('#id-feedback-new-personal-message-staff').tokenize2().trigger('tokenize:tokens:add', [response[1], response[2], true]);
                    }
                }
            }
        });
    }

    function onClickSendPersonalMessageFromFeedback() {
        $('#id-feedback-reply-successful').addClass('display_none');
        $("#id-feedback-reply-successful").css("display", "");

        //reset all validation
        $('#id-feedback-new-personal-message-staff-validation').addClass('display_none');
        $('#id-feedback-new-personal-message-about-validation').addClass('display_none');
        $('#id-feedback-new-personal-message-content-validation').addClass('display_none');

        //js side checking
        var isValid = true;

        var aboutStr = $('#id-feedback-new-personal-message-about').val();
        var contentStr = $('#id-feedback-new-personal-message-content').val();

        if(selectedStaffIdList === null || selectedStaffIdList === undefined || selectedStaffIdList === '' || selectedStaffIdList.length == 0) {
            isValid = false;
            $('#id-feedback-new-personal-message-staff-validation').removeClass('display_none');
        }
        if(aboutStr === null || aboutStr === undefined || aboutStr === '') {
            isValid = false;
            $('#id-feedback-new-personal-message-about-validation').removeClass('display_none');
        }
        if(contentStr === null || contentStr === undefined || contentStr === '') {
            isValid = false;
            $('#id-feedback-new-personal-message-content-validation').removeClass('display_none');
        }

        if(!isValid)
            return;

        $.ajax({
            url:'/Message/ReplyFeedback',
            type:'post',
            data: {
                nricList: selectedStaffIdList,
                about: aboutStr,
                content: contentStr,
                idFeedback: $('#id-feedback-new-personal-message-hidden-id-feedback')[0].innerHTML
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response !== "SUCCESS_REPLY") {
                    for(var i = 0; i < response.length; i++) {
                        if(response[i] === 'ERROR_STAFF')
                            $('#id-feedback-new-personal-message-staff-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_ABOUT')
                            $('#id-feedback-new-personal-message-about-validation').removeClass('display_none');
                        if(response[i] === 'ERROR_CONTENT')
                            $('#id-feedback-new-personal-message-content-validation').removeClass('display_none');
                    }
                } else if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_REPLY") {
                    $('#id-feedback-new-personal-message-hidden-id-feedback').html("");
                    $('.token').remove()
                    $(".token-search > input").val("")
                    $('#id-feedback-new-personal-message-about').val("");
                    $('#id-feedback-new-personal-message-content').val("");

                    $('#id-feedback-reply-successful').removeClass('display_none').fadeOut(1500);
                    getResult("Feedback");
                }
            }
        });
    }
</script>