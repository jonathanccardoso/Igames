$(document).ready(function () {
    $('#modal1').click(function () {
        $('#modal').openModal();
    });
    $('.modal-close').click(function () {
        $('.modal').closeModal();
    });
    $('.slider').slider('start');
    $('.slider').slider({ full_width: true });
    $('ul.tabs').tabs();
    $(".button-collapse").sideNav();
    $(".search-desktop").hide();
    $(".search-mobile").hide();
    $(".mobileSearch").hide();
    $(".show-search").click(function () {
        $(this).hide();
        $(".search-desktop").show(1200);
        $("#search").focus();
    });
    $(".close").click(function () {
        $(".search-desktop").hide(1200);
        $(".show-search").show(2000);
    });
    $(".search").click(function () {
        $(".search-mobile").fadeIn(2000).focus();
        $(".mobileSearch").show();
    });
    $("#search").focusout(function () {
        $(".search-desktop").hide(1200);
        $(".show-search").show(2000);
    });
});