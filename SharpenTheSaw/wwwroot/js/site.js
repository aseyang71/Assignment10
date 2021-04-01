// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.item1').click(function (e) {
    $('.item1').css("color", "black");
    $(this).css("color", "red");
});