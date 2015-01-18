//Change the active class on the sidebar depending on the page...
$(document).ready(function () {

    //Select the side bar class child ul li a
    $(".sidebar ul li a").click(function () {

        //find the current active class and remove the active class
        $(".active-app").removeClass("active-app");

        //add to the currently clicked on
        $(this).addClass("active-app");
    });
});