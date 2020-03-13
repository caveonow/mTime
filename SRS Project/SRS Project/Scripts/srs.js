﻿//jQuery(document).ready(function ($) {
//    var alterClass = function () {
//        var ww = document.body.clientWidth;

//        if (ww < 1279) {
//            $(".body_center").css("height", "88%");
//        }
//        else if (ww >= 1280 && ww <= 1439) {
//            $(".body_center").css("height", "85%");
//        }
//        else if (ww >= 1440) {
//            $(".body_center").css("height", "90%");
//        }
//    };

//    $(window).resize(function () {
//        alterClass();
//    });

//    alterClass();
//});

//Nav Top Menu Part1
$("#hdr_btn4").addClass("pt2_b_btneff");

//Nav Left Menu Part1
$("#leftnav1").addClass("ctr_innav1_btneff");

$(function () {
    var pull = $(".pn_heading_btm");

    pull.on("click", function (e) {
        e.preventDefault();
        $(e.target.parentElement.nextElementSibling).slideToggle();
        $(e.target).toggleClass('fa-angle-down');
    });
});

// Nav Left Full Part Menu Toggle Cookies
getCookies("menu");

function getCookies(name) {
    var match = document.cookie.match(new RegExp('(^| )' + name + '=([^;]+)'));
    if (match) {
        if (match[2] === "show") {
            showMenu();
        }
        else {
            hideMenu();
        }
    }
    else
        hideMenu();
}

function menuToggle(name) {
    var match = document.cookie.match(new RegExp('(^| )' + name + '=([^;]+)'));
    if (match) {
        if (match[2] === "on") {
            showMenu();
        }
        else {
            hideMenu();
        }
    }
    else
        showMenu();
}

$(".innav1_btnleft_icon").click(function () {
    menuToggle("toggle");
});

function showMenu() {
    document.cookie = "menu=show";
    document.cookie = "toggle=off";
    lt_icon_toogle = false;

    // Nav Left
    $(".bd_ctr_nav, .ctr_innav1, .ctr_innav2").css("width", "40px");
    $(".fa-angle-left").removeClass("fa-angle-left").addClass("fa-bars");
    $(".innav1_btnleft_icon").css("width", "40px").css("height", "40px").css("background-color", "#222");
    $(".ctr_innav1_btt1, .innav1_inbtn_tt, .ctr_innav2_btt1, .innav2_inbtn_tt").css("display", "none");
    $(".innav2_btnleft_box").css("display", "block");

    $(".bd_ctr_rightpart, .rightpart_eff").css("padding-left", "50px").addClass("rightpart_eff");
    $("#rtpt_closebtn, #rtpt_savebtn, #rtpt_editbtn, #renamebtn").click(function () {
        $(".bd_ctr_rightpart").css("padding-left", "50px");
    });

    $(".rtpt_ftr_addbtn").click(function () {
        $(".bd_ctr_rightpart").css("padding-left", "50px");
    });

    $(".ctr_innav1_btn").hover(
        function () {
            $("#innav1_boxeff").removeClass("innav1_inbtn_ttbox");
            $("a #innav1_boxeff").addClass("display_none");
            $("#innav2_boxeff").removeClass("innav2_inbtn_ttbox");
            $("a #innav2_boxeff").addClass("display_none");
        }, function () {
            $("#innav1_boxeff").addClass("innav1_inbtn_ttbox").removeClass("display_none");
            $("a #innav1_boxeff").addClass("display_none").addClass("innav1_inbtn_ttbox");
            $("#innav2_boxeff").addClass("innav2_inbtn_ttbox").removeClass("display_none");
            $("a #innav2_boxeff").addClass("display_none").addClass("innav2_inbtn_ttbox");
        }
    );
}

function hideMenu() {
    document.cookie = "menu=hide";
    document.cookie = "toggle=on";
    lt_icon_toogle = true;

    // Nav Left
    $(".bd_ctr_nav, .ctr_innav1, .ctr_innav2").css("width", "200px");
    $(".fa-bars").removeClass("fa-bars").addClass("fa-angle-left");
    $(".innav1_btnleft_icon").css("width", "auto").css("height", "auto").css("background-color", "none");
    $(".ctr_innav1_btt1, .innav1_inbtn_tt, .ctr_innav2_btt1, .innav2_inbtn_tt").css("display", "block");
    $(".innav2_btnleft_box").css("display", "none");

    $(".bd_ctr_rightpart").css("padding-left", "210px").removeClass("rightpart_eff");
    $("#rtpt_closebtn, #rtpt_savebtn, #rtpt_editbtn, #renamebtn").click(function () {
        $(".bd_ctr_rightpart").css("padding-left", "210px");
    });

    $(".rtpt_ftr_addbtn").click(function () {
        $(".bd_ctr_rightpart").css("padding-left", "210px");
    });

    $(".ctr_innav1_btn").hover(
        function () {
            $("#innav1_boxeff").removeClass("innav1_inbtn_ttbox");
            $("a #innav1_boxeff").addClass("display_none");
            $("#innav2_boxeff").removeClass("innav2_inbtn_ttbox");
            $("a #innav2_boxeff").addClass("display_none");
        }, function () {
            $("#innav1_boxeff").removeClass("innav1_inbtn_ttbox").removeClass("display_none");
            $("a #innav1_boxeff").removeClass("innav1_inbtn_ttbox").addClass("display_none");
            $("#innav2_boxeff").removeClass("innav2_inbtn_ttbox").removeClass("display_none");
            $("a #innav2_boxeff").removeClass("innav2_inbtn_ttbox").addClass("display_none");
        }
    );
}
// Nav Left Full Part Menu Toggle Cookies

//Day and Time
var options = { year: 'numeric', month: 'short', day: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric', hour12: false };
function display_c() {
    var refresh = 1000; // Refresh rate in milli seconds
    mytime = setTimeout('display_ct()', refresh)
}

function display_ct() {
    var strcount;
    var x = new Date();
    document.getElementById('ct').innerHTML = x.toLocaleString('en-US', options);
    tt = display_c();
}

$(".pt1_inbox2_usericon").click(function () {
    $(".hd_profile").slideToggle("fast");
    $(".pt1_inbox2_usericon").toggleClass("filter_cs1");
});

//Hyperlink Page jquery
$("#addnewbtn").click(function () {
    //$(".bd_ctr_rightpart").css("padding", "0 10px 15px 210px");
    $("#addbox-01").addClass("display_block").removeClass("display_none");
    $("#rtpt_box-01, .ctr_rtpt_footer").addClass("display_none").removeClass("display_block");
});

$("#closebtn, #savebtn, #yesbtn").click(function () {
    //$(".bd_ctr_rightpart").css("padding", "0 10px 50px 210px");
    $("#addbox-01, #editbox-01, #copybox-01, #deletebox-01").addClass("display_none").removeClass("display_block");
    $("#rtpt_box-01, .ctr_rtpt_footer").addClass("display_block").removeClass("display_none");
});

$("#editbtn, #renamebtn").click(function () {
    //$(".bd_ctr_rightpart").css("padding", "0 10px 15px 210px");
    $("#editbox-01").addClass("display_block").removeClass("display_none");
    $("#rtpt_box-01, .ctr_rtpt_footer").addClass("display_none").removeClass("display_block");
});

$("#copybtn").click(function () {
    $("#copybox-01").addClass("display_block").removeClass("display_none");
});

$("#deletebtn").click(function () {
    $("#deletebox-01").addClass("display_block").removeClass("display_none");
});

////Holiday Page jquery
//$("#holiday_add").click(function () {
//    $(".bd_ctr_rightpart").css("padding", "0 10px 15px 210px");
//    $("#holiday_addbox-01").addClass("display_block").removeClass("display_none");
//    $("#holiday_box-01, .ctr_rtpt_footer").addClass("display_none").removeClass("display_block");
//});

//$("#rtpt_closebtn, #rtpt_savebtn").click(function () {
//    //$(".bd_ctr_rightpart").css("padding", "0 10px 50px 210px");
//    $(".bd_ctr_rightpart").css("padding", "0 10px 15px 210px");
//    $("#holiday_addbox-01, #holiday_editbox-01").addClass("display_none").removeClass("display_block");
//    $("#holiday_box-01, .ctr_rtpt_footer").addClass("display_block").removeClass("display_none");
//});

//$("#rtpt_editbtn").click(function () {
//    $(".bd_ctr_rightpart").css("padding", "0 10px 15px 210px");
//    $("#holiday_editbox-01").addClass("display_block").removeClass("display_none");
//    $("#holiday_box-01, .ctr_rtpt_footer").addClass("display_none").removeClass("display_block");
//});