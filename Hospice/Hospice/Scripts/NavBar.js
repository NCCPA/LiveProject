//Change the active class on the sidebar depending on the page...
$(document).ready(function () {

    $('.navItem').mouseover(function () {
        $(this).removeClass('hidden-sm');
    });
});