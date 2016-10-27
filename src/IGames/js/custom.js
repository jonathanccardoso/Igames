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
});

$(document).ready(function () {
    // the "href" attribute of .modal-trigger must specify the modal ID that wants to be triggered
    $('.modal-trigger').leanModal();
});