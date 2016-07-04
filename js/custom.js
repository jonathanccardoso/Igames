$(document).ready(function () {
    $('.slider').slider('start');
    $('.slider').slider({ full_width: true });
    $('ul.tabs').tabs();
    $(".button-collapse").sideNav();
    $(".search-desktop").hide();
    $(".inputy").hide();
    $(".show-search").click(function(){
        $(this).hide();
        $(".search-desktop").show(1200);
        $("#search").focus();
    });
    $(".close").click(function(){
        $(".search-desktop").hide(1200);
        $(".show-search").show(2000);
    });
    $(".button-collapse").click(function(){
        $(".inputy").show();
        $(".inp").focus();
    })
});