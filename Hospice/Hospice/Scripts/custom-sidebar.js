//Change the active class on the sidebar depending on the page...
$(document).ready(function () {
    //<![CDATA[
    jQuery(function() {
        jQuery('.sidebar ul li a').each(function() {
            if (jQuery(this).attr('href')  ===  window.location.pathname) {
                jQuery(this).addClass('active-app');
            }
        });
    });  
    //]]>
});