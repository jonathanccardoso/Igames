﻿$(document).ready(function () {
    $('.modal-trigger').leanModal();
    $('.carousel').carousel();
    $('#modal1').click(function () {
        $('#modal').openModal();
    });
    $('.modal-close').click(function () {
        $('#modal').closeModal();
    });
    $('.modal-jogo').click(function () {
        $('.modal').openModal();
    });
    $('.modal-close').click(function () {
        $('.modal').closeModal();
    });
    $('.slider').slider('start');
    $('.slider').slider({ full_width: true });
    $('ul.tabs').tabs();
    $(".button-collapse").sideNav();
    $('select').material_select();
    $(".search-desktop").hide();
    $(".search-mobile").hide();
    $(".show-search").click(function () {
        $(this).hide();
        $(".search-desktop").show(1200);
        $("#search").focus();
    });
    $(".close").click(function () {
        $(".search-desktop").hide(1200);
        $(".show-search").show(2000);
    });
    $("#search").focusout(function () {
        $(".search-desktop").hide(1200);
        $(".show-search").show(2000);
    });
    $(".search").click(function () {
        $(this).hide();
        $(".search-mobile").fadeIn(500, function () {
            $(".mobileSearch").focus();
        });
    });
    $(".mobile-close").click(function () {
        $(".search-mobile").hide();
        $(".search").fadeIn(1000);
    });
    $(".mobileSearch").focusout(function () {
        $(".search-mobile").hide();
        $(".search").fadeIn(1000);
    });
    $(".dropdown-button").dropdown({
        inDuration: 300,
        outDuration: 225,
        constrain_width: false,
        hover: true,
        gutter: 0,
        belowOrigin: true,
        alignment: "left"
    });
    $(".fixed-action-btn").openFAB();
    $(".fbtn-floating-btn").closeFAB();

});
