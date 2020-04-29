@ModelType model.PERSONALMESSAGE

@Code
    ViewData("Title") = "Private Message Page"
End Code

@Html.Partial("_StaffMenuTop")

<div class="body_center">
    <div class="message_lt_part">
        <div class="inbox_haedtext">
            <span>Personal Message</span>
        </div>

        <div class="overflow_box">
            <table class="epy_lt_table">
                <thead>
                    <tr>
                        <th style="width: 65px;"></th>
                        <th style="width: 160px;">Date</th>
                        <th>Sender</th>
                        <th>Title</th>
                    </tr>
                </thead>

                <tbody id="id-body-personal-message">
                    @For Each item In ViewBag.PersonalMessageList
                    @<tr>
                        <td>
                            @If (true = item.ISREAD) Then
                                @<div id="id-email-@item.PERSONALMESSAGEID" class="fa fa-envelope-open btn_email filter1" onclick="onSelectMessageItem(@item.PERSONALMESSAGEID)"></div>
                            Else
                                @<div id="id-email-@item.PERSONALMESSAGEID" class="fa fa-envelope btn_email filter1" onclick="onSelectMessageItem(@item.PERSONALMESSAGEID)"></div>
                            End If
                            <div class="fa fa-trash-o btn_trash filter1" onclick="deletePersonalMessage(@item.PERSONALMESSAGEID)"></div>
                        </td>
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

    <div class="mse_pt_msebox message_rt_part">
        <div class="msebox_htr">
            <span>Private Message</span>

            <div id="id-personal-message-body" class="overflow_box visibility_hidden">
                <div class="new_message_part" style="height: 415px;">

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
            </div>

            <div class="footer_row_btn" style="margin: 0 0 10px 0;">
                <div id="id-personal-message-delete" class="rtpt_deletebtn btn_disabled" onclick="onClickDeletePersonalMessage()">Delete</div>
                <div id="id-personal-message-back" class="rtpt_backbtn btn_disabled" onclick="resetContent()">Back</div>
            </div>
        </div>

        <div id="id-personal-message-delete-successful" Class="ctr_rtpt_popupbox display_none save_ok_popup">
            <div Class="rtpt_popupbox_inb">
                <div Class="fa fa-check-circle-o popupbox_inb_icon_blue"></div>
                <div Class="popupbox_inb_tt">Delete successfully</div>
            </div>
        </div>

        <div class="msebox_ttbox display_none">
            <b>Cetakan laporan kedatangan bulanan</b>
            <br><br>

            Sila sCetakan laporan kedatangan bulanan anda dan menghantarkannya kepadan penyelia anda. Sebelum membuat cetakan,anda boleh mengubah taraf kedatangan dan memberikan alasan untuk datang lewat atau balik awal. Terima kasih dengan kerjasama kamu.
        </div>
    </div>
</div>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
<script type="text/javascript">
    $("#stfhdr_btn3").addClass("pt2_b_btneff");

    function resetContent() {
        $('#id-personal-message-body').addClass('visibility_hidden');

        $('#id-personal-message-delete').addClass('btn_disabled');
        $('#id-personal-message-back').addClass('btn_disabled');
    }

    function onSelectMessageItem(idMessage) {
        $("#id-email-" + idMessage).addClass("fa-envelope-open");
        $("#id-email-" + idMessage).removeClass("fa-envelope");

        $.ajax({
            url:'/PersonalMessage/GetMessageItem',
            type:'get',
            data: {
                id: idMessage
            },
            success:async function(response){
                $('#id-personal-message-body').removeClass('visibility_hidden');

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

    function onClickDeletePersonalMessage() {
        var idPersonalMessageStr = $('#id-personal-message-hidden-id-feedback')[0].innerHTML;

        deletePersonalMessage(idPersonalMessageStr);
    }

    function deletePersonalMessage(idPersonalMessageStr) {
        $('#id-personal-message-delete-successful').addClass('display_none');
        $("#id-personal-message-delete-successful").css("display", "");

        $.ajax({
            url:'/PersonalMessage/DeletePersonalMessage',
            type:'post',
            data: {
                id: idPersonalMessageStr
            },
            success:async function(response){
                if(response !== null && response !== undefined && response !== "" && response === "SUCCESS_DELETE") {
                    $('#id-personal-message-delete-successful').removeClass('display_none').fadeOut(1500);

                    resetContent();
                    getResult();
                }
            }
        });
    }

    function getResult() {
        $.ajax({
            url:'/PersonalMessage/MessageIndex',
            type:'post',
            success:async function(response){
                $("#id-body-personal-message").html(response[0]);
                $("#id-personal-message-count").html(response[1]);
            }
        });
    }
</script>