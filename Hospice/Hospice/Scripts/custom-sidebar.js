//Change the active class on the sidebar depending on the page...
$(document).ready(function () {
    //<![CDATA[
    $(function() {
        $('.sidebar ul li a').each(function() {
            if ($(this).attr('href')  ===  window.location.pathname) {
                $(this).addClass('active-app');
            }
        });
    });  
    //]]>



    //make sidebar big as viewport or devicing viewing
    var height = $(document).height();
    $('.sidebar').height(height);

    $(window).resize(function () {
        var height = $(document).height();
        $('.sidebar').height(height);
    })

    //Make the side Bar stick while scrolling
    $(window).scroll(function () {
        $('.sidebar').css(top, $(this).scrollTop());
    });
});